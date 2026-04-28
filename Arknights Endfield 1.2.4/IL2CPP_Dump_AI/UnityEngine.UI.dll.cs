// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UI.dll
// Classes:  229
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

CLASS: ButtonClickedEvent
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent
FIELDS:
METHODS:
  RVA=0x04271C98  token=0x6000015  System.Void .ctor()
END_CLASS

CLASS: <OnFinishSubmit>d__9
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.UI.Button           <>4__this  // 0x20
  private           System.Single                   <fadeTime>5__2  // 0x28
  private           System.Single                   <elapsedTime>5__3  // 0x2c
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000016  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000017  System.Void System.IDisposable.Dispose()
  RVA=0x09E66A70  token=0x6000018  System.Boolean MoveNext()
  RVA=0x09E66B64  token=0x600001A  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: IFactoryControls
TYPE:  interface
TOKEN: 0x2000012
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600006B  UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components)
END_CLASS

CLASS: DefaultRuntimeFactory
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x10
IMPLEMENTS: IFactoryControls
FIELDS:
  public    static  UnityEngine.UI.DefaultControls.IFactoryControlsDefault  // static @ 0x0
METHODS:
  RVA=0x09E60A84  token=0x600006C  UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components)
  RVA=0x0350B670  token=0x600006D  System.Void .ctor()
  RVA=0x09E60AF4  token=0x600006E  System.Void .cctor()
END_CLASS

CLASS: Resources
TYPE:  sealed struct
TOKEN: 0x2000014
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
TOKEN: 0x2000016
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ICancelHandler
FIELDS:
  private           UnityEngine.UI.Text             m_Text  // 0x18
  private           UnityEngine.UI.Image            m_Image  // 0x20
  private           UnityEngine.RectTransform       m_RectTransform  // 0x28
  private           UnityEngine.UI.Toggle           m_Toggle  // 0x30
PROPERTIES:
  text  get=0x01041090  set=0x022C3A90
  image  get=0x03D4EB40  set=0x04271930
  rectTransform  get=0x03D4EAC0  set=0x02C92F10
  toggle  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x09E60C0C  token=0x60000A9  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09E60B94  token=0x60000AA  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0426FE60  token=0x60000AB  System.Void .ctor()
END_CLASS

CLASS: OptionData
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x20
FIELDS:
  private           System.String                   m_Text  // 0x10
  private           UnityEngine.Sprite              m_Image  // 0x18
PROPERTIES:
  text  get=0x020B7B20  set=0x0426FEE0
  image  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x60000B0  System.Void .ctor()
  RVA=0x0426FEE0  token=0x60000B1  System.Void .ctor(System.String text)
  RVA=0x022C3A90  token=0x60000B2  System.Void .ctor(UnityEngine.Sprite image)
  RVA=0x02676770  token=0x60000B3  System.Void .ctor(System.String text, UnityEngine.Sprite image)
END_CLASS

CLASS: OptionDataList
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>m_Options  // 0x10
PROPERTIES:
  options  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x09E66910  token=0x60000B6  System.Void .ctor()
END_CLASS

CLASS: DropdownEvent
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09E60B58  token=0x60000B7  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass63_0
TYPE:  sealed class
TOKEN: 0x200001A
SIZE:  0x20
FIELDS:
  public            UnityEngine.UI.Dropdown.DropdownItemitem  // 0x10
  public            UnityEngine.UI.Dropdown         <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60000B8  System.Void .ctor()
  RVA=0x09E66BB0  token=0x60000B9  System.Void <Show>b__0(System.Boolean x)
END_CLASS

CLASS: <DelayedDestroyDropdownList>d__75
TYPE:  sealed class
TOKEN: 0x200001B
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Single                   delay  // 0x20
  public            UnityEngine.UI.Dropdown         <>4__this  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000BA  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000BB  System.Void System.IDisposable.Dispose()
  RVA=0x09E66988  token=0x60000BC  System.Boolean MoveNext()
  RVA=0x09E66A24  token=0x60000BE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: BlockingObjects
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsNone  // const
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsTwoD  // const
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsThreeD  // const
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsAll  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000021
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UI.GraphicRaycaster.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.UI.Graphic><>9__27_0  // static @ 0x8
METHODS:
  RVA=0x03D14B10  token=0x6000133  System.Void .cctor()
  RVA=0x0350B670  token=0x6000134  System.Void .ctor()
  RVA=0x02319F00  token=0x6000135  System.Int32 <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2)
END_CLASS

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Type       Simple  // const
  public    static  UnityEngine.UI.Image.Type       Sliced  // const
  public    static  UnityEngine.UI.Image.Type       Tiled  // const
  public    static  UnityEngine.UI.Image.Type       Filled  // const
  public    static  UnityEngine.UI.Image.Type       Mirror  // const
  public    static  UnityEngine.UI.Image.Type       Quarter  // const
METHODS:
END_CLASS

CLASS: FillMethod
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.FillMethod Horizontal  // const
  public    static  UnityEngine.UI.Image.FillMethod Vertical  // const
  public    static  UnityEngine.UI.Image.FillMethod Radial90  // const
  public    static  UnityEngine.UI.Image.FillMethod Radial180  // const
  public    static  UnityEngine.UI.Image.FillMethod Radial360  // const
METHODS:
END_CLASS

CLASS: OriginHorizontal
TYPE:  sealed struct
TOKEN: 0x2000027
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.OriginHorizontalLeft  // const
  public    static  UnityEngine.UI.Image.OriginHorizontalRight  // const
METHODS:
END_CLASS

CLASS: OriginVertical
TYPE:  sealed struct
TOKEN: 0x2000028
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.OriginVerticalBottom  // const
  public    static  UnityEngine.UI.Image.OriginVerticalTop  // const
METHODS:
END_CLASS

CLASS: Origin90
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Origin90   BottomLeft  // const
  public    static  UnityEngine.UI.Image.Origin90   TopLeft  // const
  public    static  UnityEngine.UI.Image.Origin90   TopRight  // const
  public    static  UnityEngine.UI.Image.Origin90   BottomRight  // const
METHODS:
END_CLASS

CLASS: Origin180
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Origin180  Bottom  // const
  public    static  UnityEngine.UI.Image.Origin180  Left  // const
  public    static  UnityEngine.UI.Image.Origin180  Top  // const
  public    static  UnityEngine.UI.Image.Origin180  Right  // const
METHODS:
END_CLASS

CLASS: Origin360
TYPE:  sealed struct
TOKEN: 0x200002B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Origin360  Bottom  // const
  public    static  UnityEngine.UI.Image.Origin360  Right  // const
  public    static  UnityEngine.UI.Image.Origin360  Top  // const
  public    static  UnityEngine.UI.Image.Origin360  Left  // const
METHODS:
END_CLASS

CLASS: SlicedSpriteParams
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x34
FIELDS:
  public            System.Boolean                  slicedParamNeedUpdate  // 0x10
  public            UnityEngine.Vector2             inner_PosMin  // 0x14
  public            UnityEngine.Vector2             inner_PosMax  // 0x1c
  public            UnityEngine.Vector2             inner_UVMin  // 0x24
  public            UnityEngine.Vector2             inner_UVMax  // 0x2c
METHODS:
  RVA=0x03D89BB0  token=0x60001A4  System.Void .ctor(System.Boolean slicedParamNeedUpdate, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax)
END_CLASS

CLASS: EDynamicAtlasActiveMode
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.UI.Image.EDynamicAtlasActiveModeActiveOnAwake  // const
  public    static  UnityEngine.UI.Image.EDynamicAtlasActiveModeActiveOnEnable  // const
METHODS:
END_CLASS

CLASS: ContentType
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.ContentTypeStandard  // const
  public    static  UnityEngine.UI.InputField.ContentTypeAutocorrected  // const
  public    static  UnityEngine.UI.InputField.ContentTypeIntegerNumber  // const
  public    static  UnityEngine.UI.InputField.ContentTypeDecimalNumber  // const
  public    static  UnityEngine.UI.InputField.ContentTypeAlphanumeric  // const
  public    static  UnityEngine.UI.InputField.ContentTypeName  // const
  public    static  UnityEngine.UI.InputField.ContentTypeEmailAddress  // const
  public    static  UnityEngine.UI.InputField.ContentTypePassword  // const
  public    static  UnityEngine.UI.InputField.ContentTypePin  // const
  public    static  UnityEngine.UI.InputField.ContentTypeCustom  // const
METHODS:
END_CLASS

CLASS: InputType
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.InputTypeStandard  // const
  public    static  UnityEngine.UI.InputField.InputTypeAutoCorrect  // const
  public    static  UnityEngine.UI.InputField.InputTypePassword  // const
METHODS:
END_CLASS

CLASS: CharacterValidation
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.CharacterValidationNone  // const
  public    static  UnityEngine.UI.InputField.CharacterValidationInteger  // const
  public    static  UnityEngine.UI.InputField.CharacterValidationDecimal  // const
  public    static  UnityEngine.UI.InputField.CharacterValidationAlphanumeric  // const
  public    static  UnityEngine.UI.InputField.CharacterValidationName  // const
  public    static  UnityEngine.UI.InputField.CharacterValidationEmailAddress  // const
METHODS:
END_CLASS

CLASS: LineType
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.LineTypeSingleLine  // const
  public    static  UnityEngine.UI.InputField.LineTypeMultiLineSubmit  // const
  public    static  UnityEngine.UI.InputField.LineTypeMultiLineNewline  // const
METHODS:
END_CLASS

CLASS: OnValidateInput
TYPE:  sealed class
TOKEN: 0x2000035
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09CFC420  token=0x600024A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01035ED0  token=0x600024B  System.Char Invoke(System.String text, System.Int32 charIndex, System.Char addedChar)
  RVA=0x09F6E848  token=0x600024C  System.IAsyncResult BeginInvoke(System.String text, System.Int32 charIndex, System.Char addedChar, System.AsyncCallback callback, System.Object object)
  RVA=0x080658B0  token=0x600024D  System.Char EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SubmitEvent
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09F6E8E4  token=0x600024E  System.Void .ctor()
END_CLASS

CLASS: EndEditEvent
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09F65708  token=0x600024F  System.Void .ctor()
END_CLASS

CLASS: OnChangeEvent
TYPE:  class
TOKEN: 0x2000038
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09F6E80C  token=0x6000250  System.Void .ctor()
END_CLASS

CLASS: EditState
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.EditStateContinue  // const
  public    static  UnityEngine.UI.InputField.EditStateFinish  // const
METHODS:
END_CLASS

CLASS: <CaretBlink>d__169
TYPE:  sealed class
TOKEN: 0x200003A
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.UI.InputField       <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000251  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000252  System.Void System.IDisposable.Dispose()
  RVA=0x09F6E920  token=0x6000253  System.Boolean MoveNext()
  RVA=0x09F6EA40  token=0x6000255  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <MouseDragOutsideRect>d__191
TYPE:  sealed class
TOKEN: 0x200003B
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.EventSystems.PointerEventDataeventData  // 0x20
  public            UnityEngine.UI.InputField       <>4__this  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000257  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000258  System.Void System.IDisposable.Dispose()
  RVA=0x09F6EAD8  token=0x6000259  System.Boolean MoveNext()
  RVA=0x09F6ED60  token=0x600025B  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: AspectMode
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeNone  // const
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeWidthControlsHeight  // const
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeHeightControlsWidth  // const
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeFitInParent  // const
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeEnvelopeParent  // const
METHODS:
END_CLASS

CLASS: ScaleMode
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasScaler.ScaleModeConstantPixelSize  // const
  public    static  UnityEngine.UI.CanvasScaler.ScaleModeScaleWithScreenSize  // const
  public    static  UnityEngine.UI.CanvasScaler.ScaleModeConstantPhysicalSize  // const
METHODS:
END_CLASS

CLASS: ScreenMatchMode
TYPE:  sealed struct
TOKEN: 0x2000040
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasScaler.ScreenMatchModeMatchWidthOrHeight  // const
  public    static  UnityEngine.UI.CanvasScaler.ScreenMatchModeExpand  // const
  public    static  UnityEngine.UI.CanvasScaler.ScreenMatchModeShrink  // const
METHODS:
END_CLASS

CLASS: Unit
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasScaler.UnitCentimeters  // const
  public    static  UnityEngine.UI.CanvasScaler.UnitMillimeters  // const
  public    static  UnityEngine.UI.CanvasScaler.UnitInches  // const
  public    static  UnityEngine.UI.CanvasScaler.UnitPoints  // const
  public    static  UnityEngine.UI.CanvasScaler.UnitPicas  // const
METHODS:
END_CLASS

CLASS: FitMode
TYPE:  sealed struct
TOKEN: 0x2000043
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.ContentSizeFitter.FitModeUnconstrained  // const
  public    static  UnityEngine.UI.ContentSizeFitter.FitModeMinSize  // const
  public    static  UnityEngine.UI.ContentSizeFitter.FitModePreferredSize  // const
METHODS:
END_CLASS

CLASS: Corner
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GridLayoutGroup.CornerUpperLeft  // const
  public    static  UnityEngine.UI.GridLayoutGroup.CornerUpperRight  // const
  public    static  UnityEngine.UI.GridLayoutGroup.CornerLowerLeft  // const
  public    static  UnityEngine.UI.GridLayoutGroup.CornerLowerRight  // const
METHODS:
END_CLASS

CLASS: Axis
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GridLayoutGroup.AxisHorizontal  // const
  public    static  UnityEngine.UI.GridLayoutGroup.AxisVertical  // const
METHODS:
END_CLASS

CLASS: Constraint
TYPE:  sealed struct
TOKEN: 0x2000047
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GridLayoutGroup.ConstraintFlexible  // const
  public    static  UnityEngine.UI.GridLayoutGroup.ConstraintFixedColumnCount  // const
  public    static  UnityEngine.UI.GridLayoutGroup.ConstraintFixedRowCount  // const
METHODS:
END_CLASS

CLASS: <DelayedSetDirty>d__56
TYPE:  sealed class
TOKEN: 0x2000051
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.RectTransform       rectTransform  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000314  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000315  System.Void System.IDisposable.Dispose()
  RVA=0x033F8E60  token=0x6000316  System.Boolean MoveNext()
  RVA=0x09F6EA8C  token=0x6000318  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000053
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UI.LayoutRebuilder.<>c<>9  // static @ 0x0
  public    static  System.Predicate<UnityEngine.Component><>9__10_0  // static @ 0x8
  public    static  UnityEngine.Events.UnityAction<UnityEngine.Component><>9__12_0  // static @ 0x10
  public    static  UnityEngine.Events.UnityAction<UnityEngine.Component><>9__12_1  // static @ 0x18
  public    static  UnityEngine.Events.UnityAction<UnityEngine.Component><>9__12_2  // static @ 0x20
  public    static  UnityEngine.Events.UnityAction<UnityEngine.Component><>9__12_3  // static @ 0x28
METHODS:
  RVA=0x03D19E50  token=0x600032E  System.Void .cctor()
  RVA=0x0350B670  token=0x600032F  System.Void .ctor()
  RVA=0x0365AB80  token=0x6000330  UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0()
  RVA=0x02337A90  token=0x6000331  System.Void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x)
  RVA=0x02519810  token=0x6000332  System.Boolean <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e)
  RVA=0x024A53E0  token=0x6000333  System.Void <Rebuild>b__12_0(UnityEngine.Component e)
  RVA=0x0259FAC0  token=0x6000334  System.Void <Rebuild>b__12_1(UnityEngine.Component e)
  RVA=0x02EE1550  token=0x6000335  System.Void <Rebuild>b__12_2(UnityEngine.Component e)
  RVA=0x0259FA10  token=0x6000336  System.Void <Rebuild>b__12_3(UnityEngine.Component e)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000055
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UI.LayoutUtility.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__3_0  // static @ 0x8
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__4_0  // static @ 0x10
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__4_1  // static @ 0x18
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__5_0  // static @ 0x20
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__6_0  // static @ 0x28
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__7_0  // static @ 0x30
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__7_1  // static @ 0x38
  public    static  System.Func<UnityEngine.UI.ILayoutElement,System.Single><>9__8_0  // static @ 0x40
METHODS:
  RVA=0x03D1A030  token=0x6000342  System.Void .cctor()
  RVA=0x0350B670  token=0x6000343  System.Void .ctor()
  RVA=0x02E88B90  token=0x6000344  System.Single <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e)
  RVA=0x02E88BB0  token=0x6000345  System.Single <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e)
  RVA=0x025A0AE0  token=0x6000346  System.Single <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e)
  RVA=0x025A0480  token=0x6000347  System.Single <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e)
  RVA=0x025A0740  token=0x6000348  System.Single <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e)
  RVA=0x025A0740  token=0x6000349  System.Single <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e)
  RVA=0x025A05D0  token=0x600034A  System.Single <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e)
  RVA=0x025A08A0  token=0x600034B  System.Single <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e)
END_CLASS

CLASS: CullStateChangedEvent
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x02434120  token=0x6000373  System.Void .ctor()
END_CLASS

CLASS: Mode
TYPE:  sealed struct
TOKEN: 0x200005F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Navigation.Mode  None  // const
  public    static  UnityEngine.UI.Navigation.Mode  Horizontal  // const
  public    static  UnityEngine.UI.Navigation.Mode  Vertical  // const
  public    static  UnityEngine.UI.Navigation.Mode  Automatic  // const
  public    static  UnityEngine.UI.Navigation.Mode  Explicit  // const
METHODS:
END_CLASS

CLASS: Direction
TYPE:  sealed struct
TOKEN: 0x2000063
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Scrollbar.DirectionLeftToRight  // const
  public    static  UnityEngine.UI.Scrollbar.DirectionRightToLeft  // const
  public    static  UnityEngine.UI.Scrollbar.DirectionBottomToTop  // const
  public    static  UnityEngine.UI.Scrollbar.DirectionTopToBottom  // const
METHODS:
END_CLASS

CLASS: ScrollEvent
TYPE:  class
TOKEN: 0x2000064
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x02848F50  token=0x60003D8  System.Void .ctor()
END_CLASS

CLASS: Axis
TYPE:  sealed struct
TOKEN: 0x2000065
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Scrollbar.Axis   Horizontal  // const
  public    static  UnityEngine.UI.Scrollbar.Axis   Vertical  // const
METHODS:
END_CLASS

CLASS: <ClickRepeat>d__58
TYPE:  sealed class
TOKEN: 0x2000066
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.UI.Scrollbar        <>4__this  // 0x20
  public            UnityEngine.Vector2             screenPosition  // 0x28
  public            UnityEngine.Camera              camera  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003D9  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003DA  System.Void System.IDisposable.Dispose()
  RVA=0x09F75CA0  token=0x60003DB  System.Boolean MoveNext()
  RVA=0x09F75EC8  token=0x60003DD  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: MovementType
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.ScrollRect.MovementTypeUnrestricted  // const
  public    static  UnityEngine.UI.ScrollRect.MovementTypeElastic  // const
  public    static  UnityEngine.UI.ScrollRect.MovementTypeClamped  // const
METHODS:
END_CLASS

CLASS: ScrollbarVisibility
TYPE:  sealed struct
TOKEN: 0x2000069
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.ScrollRect.ScrollbarVisibilityPermanent  // const
  public    static  UnityEngine.UI.ScrollRect.ScrollbarVisibilityAutoHide  // const
  public    static  UnityEngine.UI.ScrollRect.ScrollbarVisibilityAutoHideAndExpandViewport  // const
METHODS:
END_CLASS

CLASS: ScrollRectEvent
TYPE:  class
TOKEN: 0x200006A
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x0284A5F0  token=0x600043C  System.Void .ctor()
END_CLASS

CLASS: Transition
TYPE:  sealed struct
TOKEN: 0x200006C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Selectable.TransitionNone  // const
  public    static  UnityEngine.UI.Selectable.TransitionColorTint  // const
  public    static  UnityEngine.UI.Selectable.TransitionSpriteSwap  // const
  public    static  UnityEngine.UI.Selectable.TransitionAnimation  // const
METHODS:
END_CLASS

CLASS: SelectionState
TYPE:  sealed struct
TOKEN: 0x200006D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Selectable.SelectionStateNormal  // const
  public    static  UnityEngine.UI.Selectable.SelectionStateHighlighted  // const
  public    static  UnityEngine.UI.Selectable.SelectionStatePressed  // const
  public    static  UnityEngine.UI.Selectable.SelectionStateSelected  // const
  public    static  UnityEngine.UI.Selectable.SelectionStateDisabled  // const
METHODS:
END_CLASS

CLASS: Direction
TYPE:  sealed struct
TOKEN: 0x2000074
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Slider.Direction LeftToRight  // const
  public    static  UnityEngine.UI.Slider.Direction RightToLeft  // const
  public    static  UnityEngine.UI.Slider.Direction BottomToTop  // const
  public    static  UnityEngine.UI.Slider.Direction TopToBottom  // const
METHODS:
END_CLASS

CLASS: SliderEvent
TYPE:  class
TOKEN: 0x2000075
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x028484B0  token=0x60004DD  System.Void .ctor()
END_CLASS

CLASS: Axis
TYPE:  sealed struct
TOKEN: 0x2000076
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Slider.Axis      Horizontal  // const
  public    static  UnityEngine.UI.Slider.Axis      Vertical  // const
METHODS:
END_CLASS

CLASS: MatEntry
TYPE:  class
TOKEN: 0x2000079
SIZE:  0x40
FIELDS:
  public            UnityEngine.Material            baseMat  // 0x10
  public            UnityEngine.Material            customMat  // 0x18
  public            System.Int32                    count  // 0x20
  public            System.Int32                    stencilId  // 0x24
  public            UnityEngine.Rendering.StencilOp operation  // 0x28
  public            UnityEngine.Rendering.CompareFunctioncompareFunction  // 0x2c
  public            System.Int32                    readMask  // 0x30
  public            System.Int32                    writeMask  // 0x34
  public            System.Boolean                  useAlphaClip  // 0x38
  public            UnityEngine.Rendering.ColorWriteMaskcolorMask  // 0x3c
METHODS:
  RVA=0x03D89BE0  token=0x60004EE  System.Void .ctor()
END_CLASS

CLASS: ToggleTransition
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Toggle.ToggleTransitionNone  // const
  public    static  UnityEngine.UI.Toggle.ToggleTransitionFade  // const
METHODS:
END_CLASS

CLASS: ToggleEvent
TYPE:  class
TOKEN: 0x200007D
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x02848210  token=0x6000536  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200007F
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UI.ToggleGroup.<>c  <>9  // static @ 0x0
  public    static  System.Predicate<UnityEngine.UI.Toggle><>9__13_0  // static @ 0x8
  public    static  System.Func<UnityEngine.UI.Toggle,System.Boolean><>9__14_0  // static @ 0x10
METHODS:
  RVA=0x03D13430  token=0x6000545  System.Void .cctor()
  RVA=0x0350B670  token=0x6000546  System.Void .ctor()
  RVA=0x03D4D870  token=0x6000547  System.Boolean <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x)
  RVA=0x03D07B60  token=0x6000548  System.Boolean <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x)
END_CLASS

CLASS: Raycast3DCallback
TYPE:  sealed class
TOKEN: 0x2000081
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F6F978  token=0x600054B  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09F6F190  token=0x600054C  System.Boolean Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i)
  RVA=0x09F6F890  token=0x600054D  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  RVA=0x050C0FC0  token=0x600054E  System.Boolean EndInvoke(UnityEngine.RaycastHit& hit, System.IAsyncResult result)
END_CLASS

CLASS: RaycastAllCallback
TYPE:  sealed class
TOKEN: 0x2000082
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F6EFF8  token=0x600054F  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09F6EFC0  token=0x6000550  UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i)
  RVA=0x09F6FA40  token=0x6000551  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  RVA=0x04276D7C  token=0x6000552  UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetRaycastNonAllocCallback
TYPE:  sealed class
TOKEN: 0x2000083
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F6F1D0  token=0x6000553  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09F6F190  token=0x6000554  System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i)
  RVA=0x09F6F298  token=0x6000555  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  RVA=0x04279B70  token=0x6000556  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Raycast2DCallback
TYPE:  sealed class
TOKEN: 0x2000084
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F6F7C8  token=0x6000557  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09F6F76C  token=0x6000558  UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i)
  RVA=0x09F6F6A4  token=0x6000559  System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  RVA=0x06F4E714  token=0x600055A  UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetRayIntersectionAllCallback
TYPE:  sealed class
TOKEN: 0x2000085
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F6EFF8  token=0x600055B  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09F6EFC0  token=0x600055C  UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i)
  RVA=0x09F6EF08  token=0x600055D  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  RVA=0x04276D7C  token=0x600055E  UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetRayIntersectionAllNonAllocCallback
TYPE:  sealed class
TOKEN: 0x2000086
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F6F1D0  token=0x600055F  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09F6F190  token=0x6000560  System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i)
  RVA=0x09F6F0C0  token=0x6000561  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  RVA=0x04279B70  token=0x6000562  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ColorTweenMode
TYPE:  sealed struct
TOKEN: 0x2000092
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModeAll  // const
  public    static  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModeRGB  // const
  public    static  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModeAlpha  // const
METHODS:
END_CLASS

CLASS: ColorTweenCallback
TYPE:  class
TOKEN: 0x2000093
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x024A3F40  token=0x60005B6  System.Void .ctor()
END_CLASS

CLASS: FloatTweenCallback
TYPE:  class
TOKEN: 0x2000095
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09F78E54  token=0x60005C4  System.Void .ctor()
END_CLASS

CLASS: <Start>d__2
TYPE:  sealed class
TOKEN: 0x2000097
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
  RVA=-1  // not resolved  token=0x60005CA  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x60005CB  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x60005CC  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60005CE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: PointerEventType
TYPE:  sealed struct
TOKEN: 0x2000099
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PanelEventHandler.PointerEventTypeDefault  // const
  public    static  UnityEngine.UIElements.PanelEventHandler.PointerEventTypeDown  // const
  public    static  UnityEngine.UIElements.PanelEventHandler.PointerEventTypeUp  // const
METHODS:
END_CLASS

CLASS: PointerEvent
TYPE:  class
TOKEN: 0x200009A
SIZE:  0x80
IMPLEMENTS: UnityEngine.UIElements.IPointerEvent
FIELDS:
  private           System.Int32                    <pointerId>k__BackingField  // 0x10
  private           System.String                   <pointerType>k__BackingField  // 0x18
  private           System.Boolean                  <isPrimary>k__BackingField  // 0x20
  private           System.Int32                    <button>k__BackingField  // 0x24
  private           System.Int32                    <pressedButtons>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <position>k__BackingField  // 0x2c
  private           UnityEngine.Vector3             <localPosition>k__BackingField  // 0x38
  private           UnityEngine.Vector3             <deltaPosition>k__BackingField  // 0x44
  private           System.Single                   <deltaTime>k__BackingField  // 0x50
  private           System.Int32                    <clickCount>k__BackingField  // 0x54
  private           System.Single                   <pressure>k__BackingField  // 0x58
  private           System.Single                   <tangentialPressure>k__BackingField  // 0x5c
  private           System.Single                   <altitudeAngle>k__BackingField  // 0x60
  private           System.Single                   <azimuthAngle>k__BackingField  // 0x64
  private           System.Single                   <twist>k__BackingField  // 0x68
  private           UnityEngine.Vector2             <radius>k__BackingField  // 0x6c
  private           UnityEngine.Vector2             <radiusVariance>k__BackingField  // 0x74
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x7c
PROPERTIES:
  pointerId  get=0x03D4E340  set=0x010410F0
  pointerType  get=0x01041090  set=0x022C3A90
  isPrimary  get=0x03D4EF90  set=0x03D4EFC0
  button  get=0x03D4E2E0  set=0x03D4E2F0
  pressedButtons  get=0x03D4EB90  set=0x03D4EBA0
  position  get=0x03D59800  set=0x03D5BF30
  localPosition  get=0x03D69690  set=0x03D68D90
  deltaPosition  get=0x03D5BDA0  set=0x03D5BDC0
  deltaTime  get=0x03D51C90  set=0x03D51CA0
  clickCount  get=0x03D4EEC0  set=0x03D4EF10
  pressure  get=0x03D51080  set=0x03D510B0
  tangentialPressure  get=0x03D56C10  set=0x03D5BDF0
  altitudeAngle  get=0x03D50D50  set=0x03D50D80
  azimuthAngle  get=0x03D50D60  set=0x03D50D70
  twist  get=0x03D56A40  set=0x03D59110
  radius  get=0x03D5C200  set=0x03D55B80
  radiusVariance  get=0x03D89EB0  set=0x03D89ED0
  modifiers  get=0x03D4EC90  set=0x03D4ED10
  shiftKey  get=0x09F7D034
  ctrlKey  get=0x09F7D02C
  commandKey  get=0x09F7D024
  altKey  get=0x09F7D01C
  actionKey  get=0x09F7CFE8
METHODS:
  RVA=0x09F7CAC0  token=0x600061C  System.Void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType)
  RVA=0x03D89E80  token=0x600061D  System.Void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride)
  RVA=0x0350B670  token=0x600061E  System.Void .ctor()
  RVA=0x09F7CFD4  token=0x600061F  System.Boolean <Read>g__InRange|82_0(System.Int32 i, System.Int32 start, System.Int32 count)
END_CLASS

CLASS: FloatIntBits
TYPE:  sealed struct
TOKEN: 0x200009C
SIZE:  0x14
FIELDS:
  public            System.Single                   f  // 0x10
  public            System.Int32                    i  // 0x10
METHODS:
END_CLASS

CLASS: InputButton
TYPE:  sealed struct
TOKEN: 0x20000A1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.PointerEventData.InputButtonLeft  // const
  public    static  UnityEngine.EventSystems.PointerEventData.InputButtonRight  // const
  public    static  UnityEngine.EventSystems.PointerEventData.InputButtonMiddle  // const
METHODS:
END_CLASS

CLASS: FramePressState
TYPE:  sealed struct
TOKEN: 0x20000A2
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStatePressed  // const
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStateReleased  // const
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStatePressedAndReleased  // const
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStateNotChanged  // const
METHODS:
END_CLASS

CLASS: ProfilerMarkers
TYPE:  static class
TOKEN: 0x20000B8
SIZE:  0x10
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  Update  // static @ 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  TickModules  // static @ 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  CurrentModuleProcess  // static @ 0x10
  public    static readonly Unity.Profiling.ProfilerMarker  RaycastAll  // static @ 0x18
  public    static readonly Unity.Profiling.ProfilerMarker  RaycastAllSort  // static @ 0x20
METHODS:
  RVA=0x03B1D970  token=0x60006B2  System.Void .cctor()
END_CLASS

CLASS: UIToolkitOverrideConfig
TYPE:  sealed struct
TOKEN: 0x20000B9
SIZE:  0x20
FIELDS:
  public            UnityEngine.EventSystems.EventSystemactiveEventSystem  // 0x10
  public            System.Boolean                  sendEvents  // 0x18
  public            System.Boolean                  createPanelGameObjectsOnStart  // 0x19
METHODS:
END_CLASS

CLASS: <>c__DisplayClass53_0
TYPE:  sealed class
TOKEN: 0x20000BA
SIZE:  0x18
FIELDS:
  public            UnityEngine.GameObject          go  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60006B3  System.Void .ctor()
  RVA=0x09F84150  token=0x60006B4  System.Void <CreateUIToolkitPanelGameObject>b__0()
END_CLASS

CLASS: TriggerEvent
TYPE:  class
TOKEN: 0x20000BC
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x09F84114  token=0x60006CC  System.Void .ctor()
END_CLASS

CLASS: Entry
TYPE:  class
TOKEN: 0x20000BD
SIZE:  0x20
FIELDS:
  public            UnityEngine.EventSystems.EventTriggerTypeeventID  // 0x10
  public            UnityEngine.EventSystems.EventTrigger.TriggerEventcallback  // 0x18
METHODS:
  RVA=0x09F77B28  token=0x60006CD  System.Void .ctor()
END_CLASS

CLASS: EventFunction`1
TYPE:  sealed class
TOKEN: 0x20000C0
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x60006FB  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x60006FC  System.Void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=-1  // runtime  token=0x60006FD  System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x60006FE  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ButtonState
TYPE:  class
TOKEN: 0x20000C4
SIZE:  0x20
FIELDS:
  private           UnityEngine.EventSystems.PointerEventData.InputButtonm_Button  // 0x10
  private           UnityEngine.EventSystems.PointerInputModule.MouseButtonEventDatam_EventData  // 0x18
PROPERTIES:
  eventData  get=0x01041090  set=0x022C3A90
  button  get=0x03D4E340  set=0x010410F0
METHODS:
  RVA=0x0350B670  token=0x600073A  System.Void .ctor()
END_CLASS

CLASS: MouseState
TYPE:  class
TOKEN: 0x20000C5
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState>m_TrackedButtons  // 0x10
METHODS:
  RVA=0x09F78F8C  token=0x600073B  System.Boolean AnyPressesThisFrame()
  RVA=0x09F7902C  token=0x600073C  System.Boolean AnyReleasesThisFrame()
  RVA=0x09F790CC  token=0x600073D  UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button)
  RVA=0x09F79204  token=0x600073E  System.Void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data)
  RVA=0x09F79254  token=0x600073F  System.Void .ctor()
END_CLASS

CLASS: MouseButtonEventData
TYPE:  class
TOKEN: 0x20000C6
SIZE:  0x20
FIELDS:
  public            UnityEngine.EventSystems.PointerEventData.FramePressStatebuttonState  // 0x10
  public            UnityEngine.EventSystems.PointerEventDatabuttonData  // 0x18
METHODS:
  RVA=0x093E67CC  token=0x6000740  System.Boolean PressedThisFrame()
  RVA=0x071262D0  token=0x6000741  System.Boolean ReleasedThisFrame()
  RVA=0x0350B670  token=0x6000742  System.Void .ctor()
END_CLASS

CLASS: ProfilerMarkers
TYPE:  static class
TOKEN: 0x20000C8
SIZE:  0x10
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  Process  // static @ 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessMouseEvent  // static @ 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessMousePress  // static @ 0x10
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchEvents  // static @ 0x18
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchPress  // static @ 0x20
METHODS:
  RVA=0x09F7EAF4  token=0x6000767  System.Void .cctor()
END_CLASS

CLASS: InputMode
TYPE:  sealed struct
TOKEN: 0x20000C9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.StandaloneInputModule.InputModeMouse  // const
  public    static  UnityEngine.EventSystems.StandaloneInputModule.InputModeButtons  // const
METHODS:
END_CLASS

CLASS: ProfilerMarkers
TYPE:  static class
TOKEN: 0x20000CB
SIZE:  0x10
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  Process  // static @ 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchEvents  // static @ 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchPress  // static @ 0x10
METHODS:
  RVA=0x09F7EA20  token=0x6000777  System.Void .cctor()
END_CLASS

CLASS: RaycastHitComparer
TYPE:  class
TOKEN: 0x20000D1
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IComparer`1
FIELDS:
  public    static  UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparerinstance  // static @ 0x0
METHODS:
  RVA=0x09F7ED3C  token=0x6000794  System.Int32 Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y)
  RVA=0x0350B670  token=0x6000795  System.Void .ctor()
  RVA=0x09F7ED68  token=0x6000796  System.Void .cctor()
END_CLASS

CLASS: AutoScope
TYPE:  sealed struct
TOKEN: 0x20000D7
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007B8  System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1> marker, TP1 p1)
  RVA=-1  // not resolved  token=0x60007B9  System.Void Dispose()
END_CLASS

CLASS: AutoScope
TYPE:  sealed struct
TOKEN: 0x20000D9
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007BF  System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2> marker, TP1 p1, TP2 p2)
  RVA=-1  // not resolved  token=0x60007C0  System.Void Dispose()
END_CLASS

CLASS: AutoScope
TYPE:  sealed struct
TOKEN: 0x20000DB
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007C6  System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2,TP3> marker, TP1 p1, TP2 p2, TP3 p3)
  RVA=-1  // not resolved  token=0x60007C7  System.Void Dispose()
END_CLASS

CLASS: ProfilerMarkerScope
TYPE:  sealed struct
TOKEN: 0x20000DD
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60007DB  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker)
  RVA=0x0350B670  token=0x60007DC  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int32 context)
  RVA=0x0350B670  token=0x60007DD  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context)
  RVA=0x0350B670  token=0x60007DE  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Single context)
  RVA=0x0350B670  token=0x60007DF  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context)
  RVA=0x0350B670  token=0x60007E0  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context, System.String context2)
  RVA=0x0350B670  token=0x60007E1  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context, System.String context2)
  RVA=0x0350B670  token=0x60007E2  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context, System.Int64 context2)
  RVA=0x0350B670  token=0x60007E3  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Object obj)
  RVA=0x0350B670  token=0x60007E4  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Transform transform, System.Boolean path)
  RVA=0x0350B670  token=0x60007E5  System.Void Dispose()
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  sealed struct
TOKEN: 0x20000E5
SIZE:  0x1C
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x20000E4
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=121C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB  // static @ 0x0
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: Unity.Profiling.ProfilerCounter`1
TYPE:  sealed struct
TOKEN: 0x20000D4
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007A9  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit)
  RVA=-1  // not resolved  token=0x60007AA  System.Void Sample(T value)
END_CLASS

CLASS: Unity.Profiling.ProfilerCounterValue`1
TYPE:  sealed struct
TOKEN: 0x20000D5
SIZE:  0x11
FIELDS:
PROPERTIES:
  Value  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60007AB  System.Void .ctor(System.String name)
  RVA=-1  // not resolved  token=0x60007AC  System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit)
  RVA=-1  // not resolved  token=0x60007AD  System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions)
  RVA=-1  // not resolved  token=0x60007AE  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit)
  RVA=-1  // not resolved  token=0x60007AF  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions)
  RVA=-1  // not resolved  token=0x60007B2  System.Void Sample()
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker`1
TYPE:  sealed struct
TOKEN: 0x20000D6
SIZE:  0x11
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007B3  System.Void .ctor(System.String name, System.String param1Name)
  RVA=-1  // not resolved  token=0x60007B4  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name)
  RVA=-1  // not resolved  token=0x60007B5  System.Void Begin(TP1 p1)
  RVA=-1  // not resolved  token=0x60007B6  System.Void End()
  RVA=-1  // not resolved  token=0x60007B7  Unity.Profiling.ProfilerMarker.AutoScope<TP1> Auto(TP1 p1)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker`2
TYPE:  sealed struct
TOKEN: 0x20000D8
SIZE:  0x11
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007BA  System.Void .ctor(System.String name, System.String param1Name, System.String param2Name)
  RVA=-1  // not resolved  token=0x60007BB  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name)
  RVA=-1  // not resolved  token=0x60007BC  System.Void Begin(TP1 p1, TP2 p2)
  RVA=-1  // not resolved  token=0x60007BD  System.Void End()
  RVA=-1  // not resolved  token=0x60007BE  Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2> Auto(TP1 p1, TP2 p2)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker`3
TYPE:  sealed struct
TOKEN: 0x20000DA
SIZE:  0x11
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60007C1  System.Void .ctor(System.String name, System.String param1Name, System.String param2Name, System.String param3Name)
  RVA=-1  // not resolved  token=0x60007C2  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name, System.String param3Name)
  RVA=-1  // not resolved  token=0x60007C3  System.Void Begin(TP1 p1, TP2 p2, TP3 p3)
  RVA=-1  // not resolved  token=0x60007C4  System.Void End()
  RVA=-1  // not resolved  token=0x60007C5  Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2,TP3> Auto(TP1 p1, TP2 p2, TP3 p3)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarkerExtension
TYPE:  static class
TOKEN: 0x20000DC
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F7E4E0  token=0x60007C8  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int32 metadata)
  RVA=0x09F7E9AC  token=0x60007C9  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt32 metadata)
  RVA=0x09F7E8BC  token=0x60007CA  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata)
  RVA=0x09F7E934  token=0x60007CB  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt64 metadata)
  RVA=0x09F7E694  token=0x60007CC  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Single metadata)
  RVA=0x09F7E554  token=0x60007CD  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Double metadata)
  RVA=0x09F7E48C  token=0x60007CE  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata)
  RVA=0x09F7E70C  token=0x60007CF  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata, System.String metadata2)
  RVA=0x09F7E7E4  token=0x60007D0  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata, System.String metadata2)
  RVA=0x09F7E5CC  token=0x60007D1  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata, System.Int64 metadata2)
  RVA=0x0115F4C0  token=0x60007D2  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker)
  RVA=0x03D89EF0  token=0x60007D3  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int32 context)
  RVA=0x03D89EF0  token=0x60007D4  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context)
  RVA=0x03D89EF0  token=0x60007D5  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Single context)
  RVA=0x03D89EF0  token=0x60007D6  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context)
  RVA=0x03D89EE0  token=0x60007D7  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context, System.String context2)
  RVA=0x03D89EE0  token=0x60007D8  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context, System.String context2)
  RVA=0x03D89EE0  token=0x60007D9  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context, System.Int64 context2)
  RVA=0x03D89EE0  token=0x60007DA  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, UnityEngine.Transform transform, System.Boolean path)
END_CLASS

CLASS: Unity.Profiling.MonoObject_64
TYPE:  sealed struct
TOKEN: 0x20000DE
SIZE:  0x20
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x18
METHODS:
END_CLASS

CLASS: Unity.Profiling.MonoObject_32
TYPE:  sealed struct
TOKEN: 0x20000DF
SIZE:  0x20
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x14
METHODS:
END_CLASS

CLASS: Unity.Profiling.MonoString_64
TYPE:  sealed struct
TOKEN: 0x20000E0
SIZE:  0x28
FIELDS:
  public            Unity.Profiling.MonoObject_64   obj  // 0x10
  public            System.Int32                    length  // 0x20
  public            System.Char                     firstChar  // 0x24
METHODS:
END_CLASS

CLASS: Unity.Profiling.MonoString_32
TYPE:  sealed struct
TOKEN: 0x20000E1
SIZE:  0x20
FIELDS:
  public            Unity.Profiling.MonoObject_32   obj  // 0x10
  public            System.Int32                    length  // 0x18
  public            System.Char                     firstChar  // 0x1c
METHODS:
END_CLASS

CLASS: Unity.Profiling.ProfilerString
TYPE:  class
TOKEN: 0x20000E2
SIZE:  0x30
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.Int32                    MAX  // const
  private           System.String                   m_buffer  // 0x10
  private           System.Int32                    m_length  // 0x18
  private           System.Int32*                   m_strCount  // 0x20
  private           System.UInt64                   m_handler  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60007E6  System.Void .ctor(System.Int32 count)
  RVA=0x0350B670  token=0x60007E7  System.Void Dispose()
  RVA=0x020B7B20  token=0x60007E8  System.String ToString()
  RVA=0x09F7ED1C  token=0x60007E9  System.String op_Implicit(Unity.Profiling.ProfilerString handle)
  RVA=0x09F7EC34  token=0x60007EA  System.Void Append(System.String value)
END_CLASS

CLASS: Unity.Profiling.ProfilerUtility
TYPE:  sealed struct
TOKEN: 0x20000E3
SIZE:  0x11
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60007EB  System.Byte GetProfilerMarkerDataType()
END_CLASS

CLASS: UnityEngine.EventSystems.AxisEventData
TYPE:  class
TOKEN: 0x200009D
SIZE:  0x30
EXTENDS: UnityEngine.EventSystems.BaseEventData
FIELDS:
  private           UnityEngine.Vector2             <moveVector>k__BackingField  // 0x20
  private           UnityEngine.EventSystems.MoveDirection<moveDir>k__BackingField  // 0x28
PROPERTIES:
  moveVector  get=0x03D71660  set=0x03D4ED30
  moveDir  get=0x03D4EB90  set=0x03D4EBA0
METHODS:
  RVA=0x09F76CEC  token=0x6000630  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
END_CLASS

CLASS: UnityEngine.EventSystems.AbstractEventData
TYPE:  abstract class
TOKEN: 0x200009E
SIZE:  0x18
FIELDS:
  protected         System.Boolean                  m_Used  // 0x10
PROPERTIES:
  used  get=0x011797F0
METHODS:
  RVA=0x03D557C0  token=0x6000631  System.Void Reset()
  RVA=0x01168960  token=0x6000632  System.Void Use()
  RVA=0x0350B670  token=0x6000634  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseEventData
TYPE:  class
TOKEN: 0x200009F
SIZE:  0x20
EXTENDS: UnityEngine.EventSystems.AbstractEventData
FIELDS:
  private   readonly UnityEngine.EventSystems.EventSystemm_EventSystem  // 0x18
PROPERTIES:
  currentInputModule  get=0x05F986E4
  selectedObject  get=0x05F407B4  set=0x09F76D14
METHODS:
  RVA=0x022C3A90  token=0x6000635  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
END_CLASS

CLASS: UnityEngine.EventSystems.PointerEventData
TYPE:  class
TOKEN: 0x20000A0
SIZE:  0x160
EXTENDS: UnityEngine.EventSystems.BaseEventData
FIELDS:
  private           UnityEngine.GameObject          <pointerEnter>k__BackingField  // 0x20
  private           UnityEngine.GameObject          m_PointerPress  // 0x28
  private           UnityEngine.GameObject          <lastPress>k__BackingField  // 0x30
  private           UnityEngine.GameObject          <rawPointerPress>k__BackingField  // 0x38
  private           UnityEngine.GameObject          <pointerDrag>k__BackingField  // 0x40
  private           UnityEngine.GameObject          <pointerClick>k__BackingField  // 0x48
  private           UnityEngine.EventSystems.RaycastResult<pointerCurrentRaycast>k__BackingField  // 0x50
  private           UnityEngine.EventSystems.RaycastResult<pointerPressRaycast>k__BackingField  // 0x98
  public            System.Collections.Generic.List<UnityEngine.GameObject>hovered  // 0xe0
  private           System.Boolean                  <eligibleForClick>k__BackingField  // 0xe8
  private           System.Int32                    <pointerId>k__BackingField  // 0xec
  private           UnityEngine.Vector2             <position>k__BackingField  // 0xf0
  private           UnityEngine.Vector2             <delta>k__BackingField  // 0xf8
  private           UnityEngine.Vector2             <pressPosition>k__BackingField  // 0x100
  private           UnityEngine.Vector3             <worldPosition>k__BackingField  // 0x108
  private           UnityEngine.Vector3             <worldNormal>k__BackingField  // 0x114
  private           System.Single                   <clickTime>k__BackingField  // 0x120
  private           System.Int32                    <clickCount>k__BackingField  // 0x124
  private           UnityEngine.Vector2             <scrollDelta>k__BackingField  // 0x128
  private           System.Boolean                  <useDragThreshold>k__BackingField  // 0x130
  private           System.Boolean                  <dragging>k__BackingField  // 0x131
  private           UnityEngine.EventSystems.PointerEventData.InputButton<button>k__BackingField  // 0x134
  private           System.Single                   <pressure>k__BackingField  // 0x138
  private           System.Single                   <tangentialPressure>k__BackingField  // 0x13c
  private           System.Single                   <altitudeAngle>k__BackingField  // 0x140
  private           System.Single                   <azimuthAngle>k__BackingField  // 0x144
  private           System.Single                   <twist>k__BackingField  // 0x148
  private           UnityEngine.Vector2             <radius>k__BackingField  // 0x14c
  private           UnityEngine.Vector2             <radiusVariance>k__BackingField  // 0x154
  private           System.Boolean                  <fullyExited>k__BackingField  // 0x15c
  private           System.Boolean                  <reentered>k__BackingField  // 0x15d
PROPERTIES:
  pointerEnter  get=0x03D4EB40  set=0x04271930
  lastPress  get=0x01003830  set=0x04270470
  rawPointerPress  get=0x03D4E2A0  set=0x0388FF30
  pointerDrag  get=0x03D4E2B0  set=0x03CB2D80
  pointerClick  get=0x03D4EA70  set=0x02692290
  pointerCurrentRaycast  get=0x03D89D10  set=0x09F7CA44
  pointerPressRaycast  get=0x03D89D50  set=0x09F7CA7C
  eligibleForClick  get=0x03D554A0  set=0x03D554D0
  pointerId  get=0x03D58150  set=0x03D68F50
  position  get=0x03D56D10  set=0x03D51970
  delta  get=0x03D89CE0  set=0x03D89E20
  pressPosition  get=0x03D89D90  set=0x03D89E40
  worldPosition  get=0x03D5C360  set=0x03D5C3A0
  worldNormal  get=0x03D5B7A0  set=0x03D5B860
  clickTime  get=0x03D583D0  set=0x03D884B0
  clickCount  get=0x03D6DED0  set=0x03D742C0
  scrollDelta  get=0x03D89DF0  set=0x03D89E70
  useDragThreshold  get=0x03D57B50  set=0x03D5A340
  dragging  get=0x03D89D00  set=0x03D89E30
  button  get=0x03D4FC40  set=0x03D886C0
  pressure  get=0x03D57590  set=0x03D59AB0
  tangentialPressure  get=0x03D57900  set=0x03D86E50
  altitudeAngle  get=0x03D56EB0  set=0x03D56F30
  azimuthAngle  get=0x03D57D40  set=0x03D89E10
  twist  get=0x03D58220  set=0x03D5B6A0
  radius  get=0x03D89DD0  set=0x03D89E60
  radiusVariance  get=0x03D89DB0  set=0x03D89E50
  fullyExited  get=0x03D5BC90  set=0x03D5BCE0
  reentered  get=0x03D5BC60  set=0x03D5BCB0
  enterEventCamera  get=0x09F7C938
  pressEventCamera  get=0x09F7C9BC
  pointerPress  get=0x03D4EAC0  set=0x022C1E00
METHODS:
  RVA=0x022C3990  token=0x6000673  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
  RVA=0x022C22A0  token=0x6000674  System.Boolean IsPointerMoving()
  RVA=0x028C1410  token=0x6000675  System.Boolean IsScrolling()
  RVA=0x09F7C3B8  token=0x600067A  System.String ToString()
END_CLASS

CLASS: UnityEngine.EventSystems.EventHandle
TYPE:  sealed struct
TOKEN: 0x20000A3
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.EventHandleUnused  // const
  public    static  UnityEngine.EventSystems.EventHandleUsed  // const
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.IEventSystemHandler
TYPE:  interface
TOKEN: 0x20000A4
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerMoveHandler
TYPE:  interface
TOKEN: 0x20000A5
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600067B  System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerEnterHandler
TYPE:  interface
TOKEN: 0x20000A6
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600067C  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerExitHandler
TYPE:  interface
TOKEN: 0x20000A7
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600067D  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerDownHandler
TYPE:  interface
TOKEN: 0x20000A8
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600067E  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerUpHandler
TYPE:  interface
TOKEN: 0x20000A9
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600067F  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerClickHandler
TYPE:  interface
TOKEN: 0x20000AA
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000680  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IBeginDragHandler
TYPE:  interface
TOKEN: 0x20000AB
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000681  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IInitializePotentialDragHandler
TYPE:  interface
TOKEN: 0x20000AC
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000682  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IDragHandler
TYPE:  interface
TOKEN: 0x20000AD
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000683  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IEndDragHandler
TYPE:  interface
TOKEN: 0x20000AE
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000684  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IDropHandler
TYPE:  interface
TOKEN: 0x20000AF
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000685  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IScrollHandler
TYPE:  interface
TOKEN: 0x20000B0
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000686  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IUpdateSelectedHandler
TYPE:  interface
TOKEN: 0x20000B1
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000687  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.ISelectHandler
TYPE:  interface
TOKEN: 0x20000B2
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000688  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IDeselectHandler
TYPE:  interface
TOKEN: 0x20000B3
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000689  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IMoveHandler
TYPE:  interface
TOKEN: 0x20000B4
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600068A  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.ISubmitHandler
TYPE:  interface
TOKEN: 0x20000B5
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600068B  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.ICancelHandler
TYPE:  interface
TOKEN: 0x20000B6
IMPLEMENTS: UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600068C  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.EventSystem
TYPE:  class
TOKEN: 0x20000B7
SIZE:  0x50
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule>m_SystemInputModules  // 0x18
  private           UnityEngine.EventSystems.BaseInputModulem_CurrentInputModule  // 0x20
  private   static  System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem>m_EventSystems  // static @ 0x0
  private           UnityEngine.GameObject          m_FirstSelected  // 0x28
  private           System.Boolean                  m_sendNavigationEvents  // 0x30
  private           System.Int32                    m_DragThreshold  // 0x34
  private           UnityEngine.GameObject          m_CurrentSelected  // 0x38
  private           System.Boolean                  m_HasFocus  // 0x40
  private           System.Boolean                  m_SelectionGuard  // 0x41
  private           UnityEngine.EventSystems.BaseEventDatam_DummyData  // 0x48
  private   static readonly System.Comparison<UnityEngine.EventSystems.RaycastResult>s_RaycastComparer  // static @ 0x8
  private   static  UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfigs_UIToolkitOverride  // static @ 0x10
PROPERTIES:
  current  get=0x022B2A60  set=0x09F782F8
  sendNavigationEvents  get=0x03D4EF60  set=0x03D4EF70
  pixelDragThreshold  get=0x03D4EE00  set=0x03D4EE40
  currentInputModule  get=0x03D4EB40
  firstSelectedGameObject  get=0x03D4EAC0  set=0x02C92F10
  currentSelectedGameObject  get=0x03D4E2A0
  lastSelectedGameObject  get=0x01002730
  isFocused  get=0x03D4EE90
  alreadySelecting  get=0x03D4F7B0
  baseEventDataCache  get=0x09F78284
  isUIToolkitActiveEventSystem  get=0x036FEAB0
  sendUIToolkitEvents  get=0x036FDE90
  createUIToolkitPanelGameObjectsOnStart  get=0x036FE960
METHODS:
  RVA=0x03CE10A0  token=0x6000699  System.Void .ctor()
  RVA=0x037A0510  token=0x600069A  System.Void UpdateModules()
  RVA=0x022C3500  token=0x600069C  System.Void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer)
  RVA=0x09F77FDC  token=0x600069E  System.Void SetSelectedGameObject(UnityEngine.GameObject selected)
  RVA=0x0231A230  token=0x600069F  System.Int32 RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs)
  RVA=0x023964C0  token=0x60006A0  System.Void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults)
  RVA=0x09F77E54  token=0x60006A1  System.Boolean IsPointerOverGameObject()
  RVA=0x09F77DD4  token=0x60006A2  System.Boolean IsPointerOverGameObject(System.Int32 pointerId)
  RVA=0x09F78010  token=0x60006A6  System.Void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, System.Boolean sendEvents, System.Boolean createPanelGameObjectsOnStart)
  RVA=0x09F77B94  token=0x60006A7  System.Void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel)
  RVA=0x036FDF00  token=0x60006A8  System.Void Start()
  RVA=0x09F77E64  token=0x60006A9  System.Void OnDestroy()
  RVA=0x036FDDD0  token=0x60006AA  System.Void OnEnable()
  RVA=0x09F77EF4  token=0x60006AB  System.Void OnDisable()
  RVA=0x022B22A0  token=0x60006AC  System.Void TickModules()
  RVA=0x03134980  token=0x60006AD  System.Void OnApplicationFocus(System.Boolean hasFocus)
  RVA=0x022B1F30  token=0x60006AE  System.Void Update()
  RVA=0x03C850A0  token=0x60006AF  System.Void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module)
  RVA=0x09F78154  token=0x60006B0  System.String ToString()
  RVA=0x03B20B10  token=0x60006B1  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EventSystems.EventTrigger
TYPE:  class
TOKEN: 0x20000BB
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerExitHandler UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IPointerUpHandler UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IInitializePotentialDragHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IDropHandler UnityEngine.EventSystems.IScrollHandler UnityEngine.EventSystems.IUpdateSelectedHandler UnityEngine.EventSystems.ISelectHandler UnityEngine.EventSystems.IDeselectHandler UnityEngine.EventSystems.IMoveHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.EventSystems.ICancelHandler
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry>m_Delegates  // 0x18
PROPERTIES:
  delegates  get=0x09F7864C  set=0x022C3A90
  triggers  get=0x09F78654  set=0x022C3A90
METHODS:
  RVA=0x0426FE60  token=0x60006B7  System.Void .ctor()
  RVA=0x09F78454  token=0x60006BA  System.Void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F785DC  token=0x60006BB  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F785EC  token=0x60006BC  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7856C  token=0x60006BD  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7857C  token=0x60006BE  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F785CC  token=0x60006BF  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F785FC  token=0x60006C0  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F785BC  token=0x60006C1  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7861C  token=0x60006C2  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F7855C  token=0x60006C3  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F7860C  token=0x60006C4  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F785AC  token=0x60006C5  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  RVA=0x09F7863C  token=0x60006C6  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F7859C  token=0x60006C7  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7853C  token=0x60006C8  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7858C  token=0x60006C9  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7862C  token=0x60006CA  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F7854C  token=0x60006CB  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.EventTriggerType
TYPE:  sealed struct
TOKEN: 0x20000BE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerEnter  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerExit  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerDown  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerUp  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerClick  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeDrag  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeDrop  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeScroll  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeUpdateSelected  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeSelect  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeDeselect  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeMove  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeInitializePotentialDrag  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeBeginDrag  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeEndDrag  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeSubmit  // const
  public    static  UnityEngine.EventSystems.EventTriggerTypeCancel  // const
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.ExecuteEvents
TYPE:  static class
TOKEN: 0x20000BF
SIZE:  0x10
FIELDS:
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler>s_PointerMoveHandler  // static @ 0x0
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>s_PointerEnterHandler  // static @ 0x8
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>s_PointerExitHandler  // static @ 0x10
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>s_PointerDownHandler  // static @ 0x18
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>s_PointerUpHandler  // static @ 0x20
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>s_PointerClickHandler  // static @ 0x28
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>s_InitializePotentialDragHandler  // static @ 0x30
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>s_BeginDragHandler  // static @ 0x38
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>s_DragHandler  // static @ 0x40
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>s_EndDragHandler  // static @ 0x48
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>s_DropHandler  // static @ 0x50
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>s_ScrollHandler  // static @ 0x58
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>s_UpdateSelectedHandler  // static @ 0x60
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>s_SelectHandler  // static @ 0x68
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>s_DeselectHandler  // static @ 0x70
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>s_MoveHandler  // static @ 0x78
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>s_SubmitHandler  // static @ 0x80
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>s_CancelHandler  // static @ 0x88
  private   static readonly System.Collections.Generic.List<UnityEngine.Transform>s_InternalTransformList  // static @ 0x90
PROPERTIES:
  pointerMoveHandler  get=0x09F78C70
  pointerEnterHandler  get=0x09F78BD0
  pointerExitHandler  get=0x09F78C20
  pointerDownHandler  get=0x09F78B80
  pointerUpHandler  get=0x09F78CC0
  pointerClickHandler  get=0x09F78B30
  initializePotentialDrag  get=0x09F78A90
  beginDragHandler  get=0x09F788AC
  dragHandler  get=0x09F789A0
  endDragHandler  get=0x09F78A40
  dropHandler  get=0x09F789F0
  scrollHandler  get=0x09F78D10
  updateSelectedHandler  get=0x09F78E04
  selectHandler  get=0x09F78D60
  deselectHandler  get=0x09F78950
  moveHandler  get=0x09F78AE0
  submitHandler  get=0x09F78DB0
  cancelHandler  get=0x09F788FC
METHODS:
  RVA=-1  // generic def  token=0x60006CE  T ValidateEventData(UnityEngine.EventSystems.BaseEventData data)
  RVA=0x09F786F0  token=0x60006CF  System.Void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x022B4880  token=0x60006D0  System.Void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x022B4800  token=0x60006D1  System.Void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0284C450  token=0x60006D2  System.Void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0284C630  token=0x60006D3  System.Void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0284C290  token=0x60006D4  System.Void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03B41430  token=0x60006D5  System.Void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03976620  token=0x60006D6  System.Void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x02911820  token=0x60006D7  System.Void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03126290  token=0x60006D8  System.Void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F787C4  token=0x60006D9  System.Void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x028C1330  token=0x60006DA  System.Void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x02CD92C0  token=0x60006DB  System.Void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03CDD030  token=0x60006DC  System.Void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03CBAA70  token=0x60006DD  System.Void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F78838  token=0x60006DE  System.Void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F787AC  token=0x60006DF  System.Void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F786D8  token=0x60006E0  System.Void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x02704D50  token=0x60006F3  System.Void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain)
  RVA=-1  // generic def  token=0x60006F4  System.Boolean Execute(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor)
  RVA=-1  // generic def  token=0x60006F5  UnityEngine.GameObject ExecuteHierarchy(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction)
  RVA=-1  // generic def  token=0x60006F6  System.Boolean ShouldSendToComponent(UnityEngine.Component component)
  RVA=-1  // generic def  token=0x60006F7  System.Void GetEventList(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results)
  RVA=-1  // generic def  token=0x60006F8  System.Boolean CanHandleEvent(UnityEngine.GameObject go)
  RVA=-1  // generic def  token=0x60006F9  UnityEngine.GameObject GetEventHandler(UnityEngine.GameObject root)
  RVA=0x02E20360  token=0x60006FA  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseInput
TYPE:  class
TOKEN: 0x20000C1
SIZE:  0x18
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
PROPERTIES:
  compositionString  get=0x036E6FE0
  imeCompositionMode  get=0x09F77644  set=0x042768C0
  compositionCursorPos  get=0x09F7763C  set=0x0427312C
  mousePresent  get=0x09E75CCC
  mousePosition  get=0x09F7764C
  mouseScrollDelta  get=0x09F77674
  touchSupported  get=0x09F7767C
  touchCount  get=0x089CEE70
METHODS:
  RVA=0x09F77618  token=0x6000705  System.Boolean GetMouseButtonDown(System.Int32 button)
  RVA=0x09F77624  token=0x6000706  System.Boolean GetMouseButtonUp(System.Int32 button)
  RVA=0x09F77630  token=0x6000707  System.Boolean GetMouseButton(System.Int32 button)
  RVA=0x0943BB00  token=0x600070C  UnityEngine.Touch GetTouch(System.Int32 index)
  RVA=0x09F7760C  token=0x600070D  System.Single GetAxisRaw(System.String axisName)
  RVA=0x09E75CC0  token=0x600070E  System.Boolean GetButtonDown(System.String buttonName)
  RVA=0x0426FE60  token=0x600070F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseInputModule
TYPE:  abstract class
TOKEN: 0x20000C2
SIZE:  0x48
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  protected         System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_RaycastResultCache  // 0x18
  private           UnityEngine.EventSystems.AxisEventDatam_AxisEventData  // 0x20
  private           UnityEngine.EventSystems.EventSystemm_EventSystem  // 0x28
  private           UnityEngine.EventSystems.BaseEventDatam_BaseEventData  // 0x30
  protected         UnityEngine.EventSystems.BaseInputm_InputOverride  // 0x38
  private           UnityEngine.EventSystems.BaseInputm_DefaultInput  // 0x40
PROPERTIES:
  input  get=0x022B4110
  inputOverride  get=0x03D4E2A0  set=0x0388FF30
  eventSystem  get=0x03D4EAC0
METHODS:
  RVA=0x037A0440  token=0x6000714  System.Void OnEnable()
  RVA=0x09F775EC  token=0x6000715  System.Void OnDisable()
  RVA=-1  // abstract  token=0x6000716  System.Void Process()
  RVA=0x022C2F90  token=0x6000717  UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates)
  RVA=0x09F76E28  token=0x6000718  UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y)
  RVA=0x09F76DB8  token=0x6000719  UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone)
  RVA=0x030FB710  token=0x600071A  UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2)
  RVA=0x09F76F20  token=0x600071B  System.Void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget)
  RVA=0x09F76E38  token=0x600071C  UnityEngine.EventSystems.AxisEventData GetAxisEventData(System.Single x, System.Single y, System.Single moveDeadZone)
  RVA=0x022C3900  token=0x600071D  UnityEngine.EventSystems.BaseEventData GetBaseEventData()
  RVA=0x0115F4C0  token=0x600071E  System.Boolean IsPointerOverGameObject(System.Int32 pointerId)
  RVA=0x030DD5E0  token=0x600071F  System.Boolean ShouldActivateModule()
  RVA=0x0350B670  token=0x6000720  System.Void DeactivateModule()
  RVA=0x0350B670  token=0x6000721  System.Void ActivateModule()
  RVA=0x0350B670  token=0x6000722  System.Void UpdateModule()
  RVA=0x0232EB60  token=0x6000723  System.Boolean IsModuleSupported()
  RVA=0x09F76D3C  token=0x6000724  System.Int32 ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData)
  RVA=0x0284AC10  token=0x6000725  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.PointerInputModule
TYPE:  abstract class
TOKEN: 0x20000C3
SIZE:  0x58
EXTENDS: UnityEngine.EventSystems.BaseInputModule
FIELDS:
  public    static  System.Int32                    kMouseLeftId  // const
  public    static  System.Int32                    kMouseRightId  // const
  public    static  System.Int32                    kMouseMiddleId  // const
  public    static  System.Int32                    kFakeTouchesId  // const
  protected         System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData>m_PointerData  // 0x48
  private   readonly UnityEngine.EventSystems.PointerInputModule.MouseStatem_MouseState  // 0x50
METHODS:
  RVA=0x09F7D854  token=0x6000726  System.Boolean GetPointerData(System.Int32 id, UnityEngine.EventSystems.PointerEventData& data, System.Boolean create)
  RVA=0x09F7DF70  token=0x6000727  System.Void RemovePointerData(UnityEngine.EventSystems.PointerEventData data)
  RVA=0x09F7D948  token=0x6000728  UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released)
  RVA=0x09F7D1EC  token=0x6000729  System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to)
  RVA=0x09F7DFCC  token=0x600072A  UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 buttonId)
  RVA=0x09F7D460  token=0x600072B  UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData()
  RVA=0x09F7D46C  token=0x600072C  UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(System.Int32 id)
  RVA=0x09F7D438  token=0x600072D  UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(System.Int32 id)
  RVA=0x093E9C98  token=0x600072E  System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold)
  RVA=0x09F7DF24  token=0x600072F  System.Void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent)
  RVA=0x09F7DD04  token=0x6000730  System.Void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent)
  RVA=0x09F7DC9C  token=0x6000731  System.Boolean IsPointerOverGameObject(System.Int32 pointerId)
  RVA=0x09F7D03C  token=0x6000732  System.Void ClearSelection()
  RVA=0x09F7E044  token=0x6000733  System.String ToString()
  RVA=0x09F7D36C  token=0x6000734  System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent)
  RVA=0x09F7E2D8  token=0x6000735  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.StandaloneInputModule
TYPE:  class
TOKEN: 0x20000C7
SIZE:  0xB8
EXTENDS: UnityEngine.EventSystems.PointerInputModule
FIELDS:
  private           System.Single                   m_PrevActionTime  // 0x58
  private           UnityEngine.Vector2             m_LastMoveVector  // 0x5c
  private           System.Int32                    m_ConsecutiveMoveCount  // 0x64
  private           UnityEngine.Vector2             m_LastMousePosition  // 0x68
  private           UnityEngine.Vector2             m_MousePosition  // 0x70
  private           UnityEngine.GameObject          m_CurrentFocusedGameObject  // 0x78
  private           UnityEngine.EventSystems.PointerEventDatam_InputPointerEvent  // 0x80
  private           System.String                   m_HorizontalAxis  // 0x88
  private           System.String                   m_VerticalAxis  // 0x90
  private           System.String                   m_SubmitButton  // 0x98
  private           System.String                   m_CancelButton  // 0xa0
  private           System.Single                   m_InputActionsPerSecond  // 0xa8
  private           System.Single                   m_RepeatDelay  // 0xac
  private           System.Boolean                  m_ForceModuleActive  // 0xb0
PROPERTIES:
  inputMode  get=0x01002730
  allowActivationOnMobileDevice  get=0x01151530  set=0x01151540
  forceModuleActive  get=0x01151530  set=0x01151540
  inputActionsPerSecond  get=0x03D58510  set=0x03D6DF40
  repeatDelay  get=0x03D58380  set=0x03D6DF50
  horizontalAxis  get=0x03D4EA60  set=0x04274DA0
  verticalAxis  get=0x03D4EA90  set=0x051DFCB4
  submitButton  get=0x011AC510  set=0x051417AC
  cancelButton  get=0x03D4EA80  set=0x04270264
METHODS:
  RVA=0x09F8239C  token=0x6000743  System.Void .ctor()
  RVA=0x0232EB60  token=0x6000755  System.Boolean ShouldIgnoreEventsOnNoFocus()
  RVA=0x09F82288  token=0x6000756  System.Void UpdateModule()
  RVA=0x09F81A98  token=0x6000757  System.Void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo)
  RVA=0x09F820F0  token=0x6000758  System.Boolean ShouldActivateModule()
  RVA=0x09F7F8D4  token=0x6000759  System.Void ActivateModule()
  RVA=0x09F7F9FC  token=0x600075A  System.Void DeactivateModule()
  RVA=0x09F81940  token=0x600075B  System.Void Process()
  RVA=0x09F802EC  token=0x600075C  System.Boolean ProcessTouchEvents()
  RVA=0x09F80528  token=0x600075D  System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released)
  RVA=0x09F81EB8  token=0x600075E  System.Boolean SendSubmitEventToSelectedObject()
  RVA=0x09F7FA04  token=0x600075F  UnityEngine.Vector2 GetRawMoveVector()
  RVA=0x09F81D14  token=0x6000760  System.Boolean SendMoveEventToSelectedObject()
  RVA=0x09F7FD38  token=0x6000761  System.Void ProcessMouseEvent()
  RVA=0x0115F4C0  token=0x6000762  System.Boolean ForceAutoSelect()
  RVA=0x09F7FB08  token=0x6000763  System.Void ProcessMouseEvent(System.Int32 id)
  RVA=0x09F8201C  token=0x6000764  System.Boolean SendUpdateEventToSelectedObject()
  RVA=0x09F7FE00  token=0x6000765  System.Void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data)
  RVA=0x03D4EB20  token=0x6000766  UnityEngine.GameObject GetCurrentFocusedGameObject()
END_CLASS

CLASS: UnityEngine.EventSystems.TouchInputModule
TYPE:  class
TOKEN: 0x20000CA
SIZE:  0x78
EXTENDS: UnityEngine.EventSystems.PointerInputModule
FIELDS:
  private           UnityEngine.Vector2             m_LastMousePosition  // 0x58
  private           UnityEngine.Vector2             m_MousePosition  // 0x60
  private           UnityEngine.EventSystems.PointerEventDatam_InputPointerEvent  // 0x68
  private           System.Boolean                  m_ForceModuleActive  // 0x70
PROPERTIES:
  allowActivationOnStandalone  get=0x03D4F260  set=0x03D4F290
  forceModuleActive  get=0x03D4F260  set=0x03D4F290
METHODS:
  RVA=0x09F8410C  token=0x6000768  System.Void .ctor()
  RVA=0x09F83FB4  token=0x600076D  System.Void UpdateModule()
  RVA=0x09F82560  token=0x600076E  System.Boolean IsModuleSupported()
  RVA=0x09F83C60  token=0x600076F  System.Boolean ShouldActivateModule()
  RVA=0x09F840E8  token=0x6000770  System.Boolean UseFakeInput()
  RVA=0x09F83B7C  token=0x6000771  System.Void Process()
  RVA=0x09F82470  token=0x6000772  System.Void FakeTouches()
  RVA=0x09F82590  token=0x6000773  System.Void ProcessTouchEvents()
  RVA=0x09F827A4  token=0x6000774  System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released)
  RVA=0x09F7F9FC  token=0x6000775  System.Void DeactivateModule()
  RVA=0x09F83D38  token=0x6000776  System.String ToString()
END_CLASS

CLASS: UnityEngine.EventSystems.MoveDirection
TYPE:  sealed struct
TOKEN: 0x20000CC
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.MoveDirectionLeft  // const
  public    static  UnityEngine.EventSystems.MoveDirectionUp  // const
  public    static  UnityEngine.EventSystems.MoveDirectionRight  // const
  public    static  UnityEngine.EventSystems.MoveDirectionDown  // const
  public    static  UnityEngine.EventSystems.MoveDirectionNone  // const
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.RaycasterManager
TYPE:  static class
TOKEN: 0x20000CD
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster>s_Raycasters  // static @ 0x0
METHODS:
  RVA=0x03327490  token=0x6000778  System.Void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster)
  RVA=0x09F7F2B8  token=0x6000779  System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters()
  RVA=0x03327360  token=0x600077A  System.Void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster)
  RVA=0x03CE3430  token=0x600077B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseRaycaster
TYPE:  abstract class
TOKEN: 0x20000CE
SIZE:  0x20
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  private           UnityEngine.EventSystems.BaseRaycasterm_RootRaycaster  // 0x18
PROPERTIES:
  eventCamera  get=-1  // abstract
  priority  get=0x01002730
  sortOrderPriority  get=0x03D89CD0
  renderOrderPriority  get=0x03D89CD0
  rootRaycaster  get=0x02319F60
METHODS:
  RVA=-1  // abstract  token=0x600077C  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  RVA=0x09F7798C  token=0x6000782  System.String ToString()
  RVA=0x03327440  token=0x6000783  System.Void OnEnable()
  RVA=0x03327310  token=0x6000784  System.Void OnDisable()
  RVA=0x0364B0F0  token=0x6000785  System.Void OnCanvasHierarchyChanged()
  RVA=0x0364B0F0  token=0x6000786  System.Void OnTransformParentChanged()
  RVA=0x0426FE60  token=0x6000787  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.Physics2DRaycaster
TYPE:  class
TOKEN: 0x20000CF
SIZE:  0x48
EXTENDS: UnityEngine.EventSystems.PhysicsRaycaster
FIELDS:
  private           UnityEngine.RaycastHit2D[]      m_Hits  // 0x40
METHODS:
  RVA=0x09F7BBA0  token=0x6000788  System.Void .ctor()
  RVA=0x09F7B604  token=0x6000789  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
END_CLASS

CLASS: UnityEngine.EventSystems.PhysicsRaycaster
TYPE:  class
TOKEN: 0x20000D0
SIZE:  0x40
EXTENDS: UnityEngine.EventSystems.BaseRaycaster
FIELDS:
  protected static  System.Int32                    kNoEventMaskSet  // const
  protected         UnityEngine.Camera              m_EventCamera  // 0x20
  protected         UnityEngine.LayerMask           m_EventMask  // 0x28
  protected         System.Int32                    m_MaxRayIntersections  // 0x2c
  protected         System.Int32                    m_LastMaxRayIntersections  // 0x30
  private           UnityEngine.RaycastHit[]        m_Hits  // 0x38
PROPERTIES:
  eventCamera  get=0x09F7C2A0
  depth  get=0x09F7C21C
  finalEventMask  get=0x09F7C330
  eventMask  get=0x03D4EB90  set=0x03D4EBA0
  maxRayIntersections  get=0x03D4EDD0  set=0x03D4EDE0
METHODS:
  RVA=0x09F7BBA0  token=0x600078A  System.Void .ctor()
  RVA=0x09F7BBB0  token=0x6000792  System.Boolean ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Ray& ray, System.Int32& eventDisplayIndex, System.Single& distanceToClipPlane)
  RVA=0x09F7BE30  token=0x6000793  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
END_CLASS

CLASS: UnityEngine.EventSystems.RaycastResult
TYPE:  sealed struct
TOKEN: 0x20000D2
SIZE:  0x58
FIELDS:
  private           UnityEngine.GameObject          m_GameObject  // 0x10
  public            UnityEngine.EventSystems.BaseRaycastermodule  // 0x18
  public            System.Single                   distance  // 0x20
  public            System.Single                   index  // 0x24
  public            System.Int32                    depth  // 0x28
  public            System.Int32                    sortingLayer  // 0x2c
  public            System.Int32                    sortingOrder  // 0x30
  public            UnityEngine.Vector3             worldPosition  // 0x34
  public            UnityEngine.Vector3             worldNormal  // 0x40
  public            UnityEngine.Vector2             screenPosition  // 0x4c
  public            System.Int32                    displayIndex  // 0x54
PROPERTIES:
  gameObject  get=0x020C61B0  set=0x042715A0
  isValid  get=0x09F7F244
METHODS:
  RVA=0x09F7EDCC  token=0x600079A  System.Void Clear()
  RVA=0x09F7EE74  token=0x600079B  System.String ToString()
END_CLASS

CLASS: UnityEngine.EventSystems.UIBehaviour
TYPE:  abstract class
TOKEN: 0x20000D3
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600079C  System.Void Awake()
  RVA=0x0350B670  token=0x600079D  System.Void OnEnable()
  RVA=0x0350B670  token=0x600079E  System.Void Start()
  RVA=0x0350B670  token=0x600079F  System.Void OnDisable()
  RVA=0x0350B670  token=0x60007A0  System.Void OnDestroy()
  RVA=0x025198D0  token=0x60007A1  System.Boolean IsActive()
  RVA=0x0350B670  token=0x60007A2  System.Void OnRectTransformDimensionsChange()
  RVA=0x0350B670  token=0x60007A3  System.Void OnBeforeTransformParentChanged()
  RVA=0x0350B670  token=0x60007A4  System.Void OnTransformParentChanged()
  RVA=0x0350B670  token=0x60007A5  System.Void OnDidApplyAnimationProperties()
  RVA=0x0350B670  token=0x60007A6  System.Void OnCanvasHierarchyChanged()
  RVA=0x0239C840  token=0x60007A7  System.Boolean IsDestroyed()
  RVA=0x0426FE60  token=0x60007A8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.AnimationTriggers
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x38
FIELDS:
  private   static  System.String                   kDefaultNormalAnimName  // const
  private   static  System.String                   kDefaultHighlightedAnimName  // const
  private   static  System.String                   kDefaultPressedAnimName  // const
  private   static  System.String                   kDefaultSelectedAnimName  // const
  private   static  System.String                   kDefaultDisabledAnimName  // const
  private           System.String                   m_NormalTrigger  // 0x10
  private           System.String                   m_HighlightedTrigger  // 0x18
  private           System.String                   m_PressedTrigger  // 0x20
  private           System.String                   m_SelectedTrigger  // 0x28
  private           System.String                   m_DisabledTrigger  // 0x30
PROPERTIES:
  normalTrigger  get=0x020B7B20  set=0x0426FEE0
  highlightedTrigger  get=0x01041090  set=0x022C3A90
  pressedTrigger  get=0x03D4EB40  set=0x04271930
  selectedTrigger  get=0x03D4EAC0  set=0x02C92F10
  disabledTrigger  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x02848B40  token=0x600000D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.Button
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x188
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ISubmitHandler
FIELDS:
  private           UnityEngine.UI.Button.ButtonClickedEventm_OnClick  // 0x180
PROPERTIES:
  onClick  get=0x03D56B50  set=0x04275C40
METHODS:
  RVA=0x09E5C808  token=0x600000E  System.Void .ctor()
  RVA=0x09E5C790  token=0x6000011  System.Void Press()
  RVA=0x09E5C704  token=0x6000012  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09E5C72C  token=0x6000013  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09E5C6A8  token=0x6000014  System.Collections.IEnumerator OnFinishSubmit()
END_CLASS

CLASS: UnityEngine.UI.CanvasUpdate
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasUpdate     Prelayout  // const
  public    static  UnityEngine.UI.CanvasUpdate     Layout  // const
  public    static  UnityEngine.UI.CanvasUpdate     PostLayout  // const
  public    static  UnityEngine.UI.CanvasUpdate     PreRender  // const
  public    static  UnityEngine.UI.CanvasUpdate     LatePreRender  // const
  public    static  UnityEngine.UI.CanvasUpdate     MaxUpdateValue  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UI.ICanvasElement
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
PROPERTIES:
  transform  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600001C  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=-1  // abstract  token=0x600001E  System.Void LayoutComplete()
  RVA=-1  // abstract  token=0x600001F  System.Void GraphicUpdateComplete()
  RVA=-1  // abstract  token=0x6000020  System.Boolean IsDestroyed()
END_CLASS

CLASS: UnityEngine.UI.CanvasUpdateRegistry
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x30
FIELDS:
  private   static  UnityEngine.UI.CanvasUpdateRegistrys_Instance  // static @ 0x0
  private           System.Boolean                  m_PerformingLayoutUpdate  // 0x10
  private           System.Boolean                  m_PerformingGraphicUpdate  // 0x11
  private           Unity.Profiling.ProfilerMarker[]m_CanvasUpdateProfilerStrings  // 0x18
  private   static  System.String                   m_CullingUpdateProfilerString  // const
  private   readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement>m_LayoutRebuildQueue  // 0x20
  private   readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement>m_GraphicRebuildQueue  // 0x28
  private   static readonly System.Comparison<UnityEngine.UI.ICanvasElement>s_SortLayoutFunction  // static @ 0x8
PROPERTIES:
  instance  get=0x0239DCC0
METHODS:
  RVA=0x02CD05B0  token=0x6000021  System.Void .ctor()
  RVA=0x0239C000  token=0x6000023  System.Boolean ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239B3A0  token=0x6000024  System.Void CleanInvalidItems()
  RVA=0x0239B5A0  token=0x6000025  System.Void PerformUpdate()
  RVA=0x02DA8E30  token=0x6000026  System.Int32 ParentCount(UnityEngine.Transform child)
  RVA=0x02DA8CC0  token=0x6000027  System.Int32 SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y)
  RVA=0x034CFE10  token=0x6000028  System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239D100  token=0x6000029  System.Boolean TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239DFD0  token=0x600002A  System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239D980  token=0x600002B  System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x09E5C894  token=0x600002C  System.Boolean TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239DDC0  token=0x600002D  System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239CDC0  token=0x600002E  System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239C980  token=0x600002F  System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239CB40  token=0x6000030  System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  RVA=0x0239CD00  token=0x6000031  System.Boolean IsRebuildingLayout()
  RVA=0x0239CD60  token=0x6000032  System.Boolean IsRebuildingGraphics()
  RVA=0x03CBD3B0  token=0x6000033  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.ColorBlock
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x68
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.Color               m_NormalColor  // 0x10
  private           UnityEngine.Color               m_HighlightedColor  // 0x20
  private           UnityEngine.Color               m_PressedColor  // 0x30
  private           UnityEngine.Color               m_SelectedColor  // 0x40
  private           UnityEngine.Color               m_DisabledColor  // 0x50
  private           System.Single                   m_ColorMultiplier  // 0x60
  private           System.Single                   m_FadeDuration  // 0x64
  public    static  UnityEngine.UI.ColorBlock       defaultColorBlock  // static @ 0x0
PROPERTIES:
  normalColor  get=0x03D5B250  set=0x03D5E620
  highlightedColor  get=0x020B7B30  set=0x03D55580
  pressedColor  get=0x03D54E00  set=0x03D54E10
  selectedColor  get=0x03D4FD30  set=0x03D4FD40
  disabledColor  get=0x03D5A160  set=0x03D5D610
  colorMultiplier  get=0x03D51C90  set=0x03D51CA0
  fadeDuration  get=0x03D4F670  set=0x03D4F680
METHODS:
  RVA=0x02561F60  token=0x6000042  System.Void .cctor()
  RVA=0x09E5C8EC  token=0x6000043  System.Boolean Equals(System.Object obj)
  RVA=0x09E5C99C  token=0x6000044  System.Boolean Equals(UnityEngine.UI.ColorBlock other)
  RVA=0x09E5CBA4  token=0x6000045  System.Boolean op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2)
  RVA=0x09E5CC38  token=0x6000046  System.Boolean op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2)
  RVA=0x09E5CB20  token=0x6000047  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UI.ClipperRegistry
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x20
FIELDS:
  private   static  UnityEngine.UI.ClipperRegistry  s_Instance  // static @ 0x0
  private   readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper>m_Clippers  // 0x10
  private   readonly Unity.Profiling.ProfilerMarker  clippersMarker  // 0x18
PROPERTIES:
  instance  get=0x02516E40
METHODS:
  RVA=0x02515620  token=0x6000048  System.Void .ctor()
  RVA=0x02DF7F90  token=0x600004A  System.Void Cull()
  RVA=0x02516DD0  token=0x600004B  System.Void Register(UnityEngine.UI.IClipper c)
  RVA=0x02516D40  token=0x600004C  System.Void Unregister(UnityEngine.UI.IClipper c)
END_CLASS

CLASS: UnityEngine.UI.Clipping
TYPE:  static class
TOKEN: 0x200000D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0233E630  token=0x600004D  UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, System.Boolean& validRect)
END_CLASS

CLASS: UnityEngine.UI.IClipper
TYPE:  interface
TOKEN: 0x200000E
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600004E  System.Void PerformClipping()
END_CLASS

CLASS: UnityEngine.UI.IClippable
TYPE:  interface
TOKEN: 0x200000F
FIELDS:
PROPERTIES:
  gameObject  get=-1  // abstract
  rectTransform  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000050  System.Void RecalculateClipping()
  RVA=-1  // abstract  token=0x6000052  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  RVA=-1  // abstract  token=0x6000053  System.Void SetClipRect(UnityEngine.Rect value, System.Boolean validRect)
  RVA=-1  // abstract  token=0x6000054  System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness)
  RVA=-1  // abstract  token=0x6000055  System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness)
END_CLASS

CLASS: UnityEngine.UI.RectangularVertexClipper
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x20
FIELDS:
  private   readonly UnityEngine.Vector3[]           m_WorldCorners  // 0x10
  private   readonly UnityEngine.Vector3[]           m_CanvasCorners  // 0x18
METHODS:
  RVA=0x023443C0  token=0x6000056  UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c)
  RVA=0x03294BB0  token=0x6000057  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.DefaultControls
TYPE:  static class
TOKEN: 0x2000011
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.UI.DefaultControls.IFactoryControlsm_CurrentFactory  // static @ 0x0
  private   static  System.Single                   kWidth  // const
  private   static  System.Single                   kThickHeight  // const
  private   static  System.Single                   kThinHeight  // const
  private   static  UnityEngine.Vector2             s_ThickElementSize  // static @ 0x8
  private   static  UnityEngine.Vector2             s_ThinElementSize  // static @ 0x10
  private   static  UnityEngine.Vector2             s_ImageElementSize  // static @ 0x18
  private   static  UnityEngine.Color               s_DefaultSelectableColor  // static @ 0x20
  private   static  UnityEngine.Color               s_PanelColor  // static @ 0x30
  private   static  UnityEngine.Color               s_TextColor  // static @ 0x40
PROPERTIES:
  factory  get=0x09E60A34
METHODS:
  RVA=0x09E6055C  token=0x6000059  UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size, System.Type[] components)
  RVA=0x09E60608  token=0x600005A  UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent, System.Type[] components)
  RVA=0x09E606DC  token=0x600005B  System.Void SetDefaultTextValues(UnityEngine.UI.Text lbl)
  RVA=0x09E6068C  token=0x600005C  System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider)
  RVA=0x09E60854  token=0x600005D  System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent)
  RVA=0x09E60794  token=0x600005E  System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer)
  RVA=0x09E5E800  token=0x600005F  UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5CCD0  token=0x6000060  UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5FE38  token=0x6000061  UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5E164  token=0x6000062  UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5EA30  token=0x6000063  UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5F6EC  token=0x6000064  UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5F298  token=0x6000065  UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5FF9C  token=0x6000066  UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5E270  token=0x6000067  UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5D02C  token=0x6000068  UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E5EB3C  token=0x6000069  UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources)
  RVA=0x09E60920  token=0x600006A  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.Dropdown
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x1F0
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.EventSystems.ICancelHandler
FIELDS:
  private           UnityEngine.RectTransform       m_Template  // 0x180
  private           UnityEngine.UI.Text             m_CaptionText  // 0x188
  private           UnityEngine.UI.Image            m_CaptionImage  // 0x190
  private           UnityEngine.UI.Text             m_ItemText  // 0x198
  private           UnityEngine.UI.Image            m_ItemImage  // 0x1a0
  private           System.Int32                    m_Value  // 0x1a8
  private           UnityEngine.UI.Dropdown.OptionDataListm_Options  // 0x1b0
  private           UnityEngine.UI.Dropdown.DropdownEventm_OnValueChanged  // 0x1b8
  private           System.Single                   m_AlphaFadeSpeed  // 0x1c0
  private           UnityEngine.GameObject          m_Dropdown  // 0x1c8
  private           UnityEngine.GameObject          m_Blocker  // 0x1d0
  private           System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem>m_Items  // 0x1d8
  private           UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween>m_AlphaTweenRunner  // 0x1e0
  private           System.Boolean                  validTemplate  // 0x1e8
  private   static  System.Int32                    kHighSortingLayer  // const
  private   static  UnityEngine.UI.Dropdown.OptionDatas_NoOptionData  // static @ 0x0
PROPERTIES:
  template  get=0x03D56B50  set=0x09E63924
  captionText  get=0x03D56AF0  set=0x09E63878
  captionImage  get=0x03D56B70  set=0x09E63850
  itemText  get=0x03D56AE0  set=0x09E638C8
  itemImage  get=0x03D56AD0  set=0x09E638A0
  options  get=0x09E63830  set=0x09E638F0
  onValueChanged  get=0x03D57130  set=0x04275B98
  alphaFadeSpeed  get=0x03D584D0  set=0x03D58600
  value  get=0x03D583A0  set=0x09E6394C
METHODS:
  RVA=0x09E62118  token=0x6000081  System.Void SetValueWithoutNotify(System.Int32 input)
  RVA=0x09E62124  token=0x6000082  System.Void Set(System.Int32 value, System.Boolean sendCallback)
  RVA=0x09E63708  token=0x6000083  System.Void .ctor()
  RVA=0x09E6137C  token=0x6000084  System.Void Awake()
  RVA=0x09E63608  token=0x6000085  System.Void Start()
  RVA=0x09E61CF0  token=0x6000086  System.Void OnDisable()
  RVA=0x09E61E94  token=0x6000087  System.Void RefreshShownValue()
  RVA=0x09E6110C  token=0x6000088  System.Void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options)
  RVA=0x09E60F04  token=0x6000089  System.Void AddOptions(System.Collections.Generic.List<System.String> options)
  RVA=0x09E61008  token=0x600008A  System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options)
  RVA=0x09E61464  token=0x600008B  System.Void ClearOptions()
  RVA=0x09E62214  token=0x600008C  System.Void SetupTemplate(UnityEngine.Canvas rootCanvas)
  RVA=-1  // generic def  token=0x600008D  T GetOrAddComponent(UnityEngine.GameObject go)
  RVA=0x09E61D84  token=0x600008E  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09E61D84  token=0x600008F  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09E61CE8  token=0x6000090  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09E6285C  token=0x6000091  System.Void Show()
  RVA=0x09E614C4  token=0x6000092  UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas)
  RVA=0x09E61A0C  token=0x6000093  System.Void DestroyBlocker(UnityEngine.GameObject blocker)
  RVA=0x09E618F8  token=0x6000094  UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template)
  RVA=0x09E61A58  token=0x6000095  System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList)
  RVA=0x09E6194C  token=0x6000096  UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate)
  RVA=0x0350B670  token=0x6000097  System.Void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item)
  RVA=0x09E60C78  token=0x6000098  UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, System.Boolean selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items)
  RVA=0x09E612F0  token=0x6000099  System.Void AlphaFadeList(System.Single duration, System.Single alpha)
  RVA=0x09E61174  token=0x600009A  System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end)
  RVA=0x09E62078  token=0x600009B  System.Void SetAlpha(System.Single alpha)
  RVA=0x09E61AA4  token=0x600009C  System.Void Hide()
  RVA=0x09E619A0  token=0x600009D  System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay)
  RVA=0x09E61B98  token=0x600009E  System.Void ImmediateDestroyDropdownList()
  RVA=0x09E61D8C  token=0x600009F  System.Void OnSelectItem(UnityEngine.UI.Toggle toggle)
  RVA=0x09E63698  token=0x60000A0  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.FontData
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x40
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           UnityEngine.Font                m_Font  // 0x10
  private           System.Int32                    m_FontSize  // 0x18
  private           UnityEngine.FontStyle           m_FontStyle  // 0x1c
  private           System.Boolean                  m_BestFit  // 0x20
  private           System.Int32                    m_MinSize  // 0x24
  private           System.Int32                    m_MaxSize  // 0x28
  private           UnityEngine.TextAnchor          m_Alignment  // 0x2c
  private           System.Boolean                  m_AlignByGeometry  // 0x30
  private           System.Boolean                  m_RichText  // 0x31
  private           UnityEngine.HorizontalWrapMode  m_HorizontalOverflow  // 0x34
  private           UnityEngine.VerticalWrapMode    m_VerticalOverflow  // 0x38
  private           System.Single                   m_LineSpacing  // 0x3c
PROPERTIES:
  defaultFontData  get=0x09E639A4
  font  get=0x020B7B20  set=0x0426FEE0
  fontSize  get=0x020D1AC0  set=0x03D4E9C0
  fontStyle  get=0x03D4EBB0  set=0x03D4EBC0
  bestFit  get=0x03D4EF90  set=0x03D4EFC0
  minSize  get=0x03D4E2E0  set=0x03D4E2F0
  maxSize  get=0x03D4EB90  set=0x03D4EBA0
  alignment  get=0x03D4EDD0  set=0x03D4EDE0
  alignByGeometry  get=0x03D4EF60  set=0x03D4EF70
  richText  get=0x03D4F2C0  set=0x03D4F2D0
  horizontalOverflow  get=0x03D4EE00  set=0x03D4EE40
  verticalOverflow  get=0x03D4EC30  set=0x03D4ECB0
  lineSpacing  get=0x03D4EC60  set=0x03D4ECE0
METHODS:
  RVA=0x0350B670  token=0x60000D9  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x09E63958  token=0x60000DA  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x0350B670  token=0x60000DB  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.FontUpdateTracker
TYPE:  static class
TOKEN: 0x200001D
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>>m_Tracked  // static @ 0x0
METHODS:
  RVA=0x09E63B88  token=0x60000DC  System.Void TrackText(UnityEngine.UI.Text t)
  RVA=0x09E63A18  token=0x60000DD  System.Void RebuildForFont(UnityEngine.Font f)
  RVA=0x09E63DA8  token=0x60000DE  System.Void UntrackText(UnityEngine.UI.Text t)
  RVA=0x09E63F8C  token=0x60000DF  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.Graphic
TYPE:  abstract class
TOKEN: 0x200001E
SIZE:  0xB0
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ICanvasElement
FIELDS:
  protected static  UnityEngine.Material            s_DefaultUI  // static @ 0x0
  protected static  UnityEngine.Texture2D           s_WhiteTexture  // static @ 0x8
  private   static  System.String                   s_DefaultMaterialName  // static @ 0x10
  private   static  System.String                   s_OverlayShaderKeyword  // static @ 0x18
  protected         UnityEngine.Material            m_Material  // 0x18
  private           UnityEngine.Color               m_Color  // 0x20
  protected         System.Boolean                  m_SkipLayoutUpdate  // 0x30
  protected         System.Boolean                  m_SkipMaterialUpdate  // 0x31
  private           System.Boolean                  m_RaycastTarget  // 0x32
  private           UnityEngine.Vector4             m_RaycastPadding  // 0x34
  private           System.Boolean                  m_RaycastIgnoreMask  // 0x44
  private           UnityEngine.RectTransform       m_RectTransform  // 0x48
  private           UnityEngine.CanvasRenderer      m_CanvasRenderer  // 0x50
  private           UnityEngine.Canvas              m_Canvas  // 0x58
  private           System.Boolean                  m_VertsDirty  // 0x60
  private           System.Boolean                  m_MaterialDirty  // 0x61
  protected         UnityEngine.Events.UnityAction  m_OnDirtyLayoutCallback  // 0x68
  protected         UnityEngine.Events.UnityAction  m_OnDirtyVertsCallback  // 0x70
  protected         UnityEngine.Events.UnityAction  m_OnDirtyMaterialCallback  // 0x78
  protected static  UnityEngine.Mesh                s_Mesh  // static @ 0x20
  private   static readonly UnityEngine.UI.VertexHelper     s_VertexHelper  // static @ 0x28
  protected         UnityEngine.Mesh                m_CachedMesh  // 0x80
  protected         UnityEngine.Vector2[]           m_CachedUvs  // 0x88
  private           UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween>m_ColorTweenRunnerLazy  // 0x90
  protected         System.Boolean                  m_EnableRuntimeAtlas  // 0x98
  protected         UnityEngine.Texture             m_RuntimeAtlasTexture  // 0xa0
  private           System.Boolean                  <useLegacyMeshGeneration>k__BackingField  // 0xa8
PROPERTIES:
  defaultMaterialName  get=0x09E64430  set=0x09E644D0
  defaultGraphicMaterial  get=0x025C3E70
  overlayShaderKeyword  get=0x09E64480  set=0x09E64560
  color  get=0x03D54E00  set=0x025C1E20
  raycastTarget  get=0x03D4F630  set=0x03567B30
  raycastPadding  get=0x03D51E40  set=0x03D51E50
  m_ColorTweenRunner  get=0x024A3DF0
  enableRuntimeAtlas  get=0x03D58690  set=0x09E64530
  runtimeAtlasTexture  get=0x03D4EA80  set=0x09E645C0
  useLegacyMeshGeneration  get=0x011B9C10  set=0x011B9C20
  depth  get=0x02341D00
  rectTransform  get=0x0233FD70
  canvas  get=0x02345AD0
  canvasRenderer  get=0x02341C90
  defaultMaterial  get=0x025C3E20
  material  get=0x030A8360  set=0x034D2AC0
  materialForRendering  get=0x025C6F00
  mainTexture  get=0x03CFAFA0
  workerMesh  get=0x0233EFA0
METHODS:
  RVA=0x024340C0  token=0x60000F2  System.Void .ctor()
  RVA=0x03009260  token=0x60000F3  System.Void SetAllDirty()
  RVA=0x0233E250  token=0x60000F4  System.Void SetLayoutDirty()
  RVA=0x0239D5F0  token=0x60000F5  System.Void SetVerticesDirty()
  RVA=0x0239D260  token=0x60000F6  System.Void SetMaterialDirty()
  RVA=0x02394070  token=0x60000F7  System.Void OnRectTransformDimensionsChange()
  RVA=0x031ED950  token=0x60000F8  System.Void OnBeforeTransformParentChanged()
  RVA=0x031635B0  token=0x60000F9  System.Void OnTransformParentChanged()
  RVA=0x0251D250  token=0x60000FD  System.Void CacheCanvas()
  RVA=0x02399F40  token=0x6000104  System.Void OnEnable()
  RVA=0x0239AE50  token=0x6000105  System.Void OnDisable()
  RVA=0x025CAEC0  token=0x6000106  System.Void OnDestroy()
  RVA=0x025A2510  token=0x6000107  System.Void OnCanvasHierarchyChanged()
  RVA=0x02C6F700  token=0x6000108  System.Void OnCullingChanged()
  RVA=0x02342510  token=0x6000109  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=0x0350B670  token=0x600010A  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x600010B  System.Void GraphicUpdateComplete()
  RVA=0x025C6C70  token=0x600010C  System.Void UpdateMaterial()
  RVA=0x0233E5B0  token=0x600010D  System.Void UpdateGeometry()
  RVA=0x0233F3F0  token=0x600010E  System.Void DoMeshGeneration()
  RVA=0x0398B650  token=0x600010F  System.Void DoLegacyMeshGeneration()
  RVA=0x0350B670  token=0x6000111  System.Void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo)
  RVA=0x03CF0F00  token=0x6000112  System.Void OnPopulateMesh(UnityEngine.Mesh m)
  RVA=0x025A3710  token=0x6000113  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  RVA=0x09E640BC  token=0x6000114  System.Void OnDidApplyAnimationProperties()
  RVA=0x0350B670  token=0x6000115  System.Void SetNativeSize()
  RVA=0x02519020  token=0x6000116  System.Boolean Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  RVA=0x09E640CC  token=0x6000117  UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point)
  RVA=0x0233E320  token=0x6000118  UnityEngine.Rect GetPixelAdjustedRect()
  RVA=0x024A3780  token=0x6000119  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  RVA=0x024A3800  token=0x600011A  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB)
  RVA=0x03C95E10  token=0x600011B  UnityEngine.Color CreateColorFromAlpha(System.Single alpha)
  RVA=0x03C95D40  token=0x600011C  System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  RVA=0x09E64200  token=0x600011D  System.Void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action)
  RVA=0x09E64318  token=0x600011E  System.Void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action)
  RVA=0x02CD8F30  token=0x600011F  System.Void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action)
  RVA=0x02CD8670  token=0x6000120  System.Void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action)
  RVA=0x09E6428C  token=0x6000121  System.Void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action)
  RVA=0x09E643A4  token=0x6000122  System.Void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action)
  RVA=0x03B39A40  token=0x6000123  System.Void .cctor()
  RVA=0x04273A88  token=0x6000124  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.GraphicRaycaster
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x40
EXTENDS: UnityEngine.EventSystems.BaseRaycaster
FIELDS:
  protected static  System.Int32                    kNoEventMaskSet  // const
  private           System.Boolean                  m_IgnoreReversedGraphics  // 0x20
  private           UnityEngine.UI.GraphicRaycaster.BlockingObjectsm_BlockingObjects  // 0x24
  protected         UnityEngine.LayerMask           m_BlockingMask  // 0x28
  private           UnityEngine.Canvas              m_Canvas  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UI.Graphic>m_RaycastResults  // 0x38
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic>s_SortedGraphics  // static @ 0x0
PROPERTIES:
  sortOrderPriority  get=0x02398D70
  renderOrderPriority  get=0x02398EF0
  ignoreReversedGraphics  get=0x03D4EF90  set=0x03D4EFC0
  blockingObjects  get=0x03D4E2E0  set=0x03D4E2F0
  blockingMask  get=0x03D4EB90  set=0x03D4EBA0
  canvas  get=0x02398350
  eventCamera  get=0x02398A50
METHODS:
  RVA=0x034CF540  token=0x600012D  System.Void .ctor()
  RVA=0x023968C0  token=0x600012F  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  RVA=0x0233FE10  token=0x6000131  System.Void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results)
  RVA=0x034CF410  token=0x6000132  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.GraphicRegistry
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x20
FIELDS:
  private   static  UnityEngine.UI.GraphicRegistry  s_Instance  // static @ 0x0
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>>m_Graphics  // 0x10
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>>m_RaycastableGraphics  // 0x18
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic>s_EmptyList  // static @ 0x8
PROPERTIES:
  instance  get=0x02398950
METHODS:
  RVA=0x03A20290  token=0x6000136  System.Void .ctor()
  RVA=0x02399060  token=0x6000138  System.Void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  RVA=0x023998B0  token=0x6000139  System.Void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  RVA=0x023994F0  token=0x600013A  System.Void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  RVA=0x02399C60  token=0x600013B  System.Void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  RVA=0x09E64018  token=0x600013C  System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas)
  RVA=0x02398470  token=0x600013D  System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas)
  RVA=0x034CF4A0  token=0x600013E  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.IGraphicEnabledDisabled
TYPE:  interface
TOKEN: 0x2000023
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600013F  System.Void OnSiblingGraphicEnabledDisabled()
END_CLASS

CLASS: UnityEngine.UI.Image
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x190
EXTENDS: UnityEngine.UI.MaskableGraphic
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver UnityEngine.UI.ILayoutElement UnityEngine.ICanvasRaycastFilter
FIELDS:
  protected static  UnityEngine.Material            s_ETC1DefaultUI  // static @ 0x0
  private           UnityEngine.Sprite              m_Sprite  // 0xe8
  protected         UnityEngine.Rect                m_RuntimeAtlasRect  // 0xf0
  protected         UnityEngine.Rect                m_RuntimeAtlasTextureRect  // 0x100
  protected         UnityEngine.Vector4             m_RuntimeAtlasBorder  // 0x110
  protected         System.Single                   m_RuntimeAtlasPixelsPerUnit  // 0x120
  private           UnityEngine.Sprite              m_OverrideSprite  // 0x128
  private           UnityEngine.UI.Image.Type       m_Type  // 0x130
  private           System.Boolean                  m_PreserveAspect  // 0x134
  private           System.Boolean                  m_FillCenter  // 0x135
  private           UnityEngine.UI.Image.FillMethod m_FillMethod  // 0x138
  private           System.Single                   m_FillAmount  // 0x13c
  private           System.Boolean                  m_FillClockwise  // 0x140
  private           System.Int32                    m_FillOrigin  // 0x144
  private           System.Single                   m_AlphaHitTestMinimumThreshold  // 0x148
  private           System.Boolean                  m_Tracked  // 0x14c
  private           System.Boolean                  m_UseSpriteMesh  // 0x14d
  private           System.Single                   m_PixelsPerUnitMultiplier  // 0x150
  private           System.Single                   m_CachedReferencePixelsPerUnit  // 0x154
  public            UnityEngine.UI.Image.SlicedSpriteParamsslicedSpriteParams  // 0x158
  private           System.Boolean                  bAwakeOnce  // 0x17c
  private   static readonly UnityEngine.Vector2[]           s_VertScratch  // static @ 0x8
  private   static readonly UnityEngine.Vector2[]           s_UVScratch  // static @ 0x10
  private   static  System.Int32                    QuadCount  // const
  private   static readonly UnityEngine.Vector3[]           s_Xy  // static @ 0x18
  private   static readonly UnityEngine.Vector3[]           s_Uv  // static @ 0x20
  private   static  System.Collections.Generic.List<UnityEngine.UI.Image>m_TrackedTexturelessImages  // static @ 0x28
  private   static  System.Boolean                  s_Initialized  // static @ 0x30
  protected static  System.Int32                    VALIDATE_MAX_VERT_COUNT  // const
  private           UnityEngine.UI.Image.EDynamicAtlasActiveModem_DynamicAtlasActiveMode  // 0x17d
  protected         System.Boolean                  _packIntoRuntimeAtlas  // 0x17e
  protected         System.Int32                    m_panelLevel  // 0x180
  public            System.Boolean                  keepOriginUV  // 0x184
  private           System.Action                   dynamicAtlasCallBack  // 0x188
  private   static  System.Boolean                  _sDynamicAtlasInitialized  // static @ 0x31
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Image>s_FreeList  // static @ 0x38
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image>s_TrackedDynamicAtlasImages  // static @ 0x40
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Image>s_FreeListRevert  // static @ 0x48
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image>s_TrackedDynamicAtlasSpriteRevert  // static @ 0x50
  public    static  System.Boolean                  s_AtlasV2  // static @ 0x58
PROPERTIES:
  runtimeAtlasRect  get=0x03D6C080  set=0x03D6C110
  runtimeAtlasTextureRect  get=0x03D6C060  set=0x03D6C0E0
  runtimeAtlasBorder  get=0x03D6C050  set=0x03D6C0D0
  runtimeAtlasPixelsPerUnit  get=0x03D583D0  set=0x03D884B0
  sprite  get=0x03D50EA0  set=0x025C39D0
  enableRuntimeAtlasRaw  get=0x03D58690
  enableRuntimeAtlas  get=0x02E55420  set=0x09E64530
  overrideSprite  get=0x09E665E0  set=0x09E66768
  activeSprite  get=0x025C6650
  type  get=0x03D5CE60  set=0x09E66854
  preserveAspect  get=0x03D5AED0  set=0x09E667F4
  fillCenter  get=0x03D5AF00  set=0x09E665E8
  fillMethod  get=0x03D59CD0  set=0x09E666A8
  fillAmount  get=0x03D57900  set=0x02409C90
  fillClockwise  get=0x03D576E0  set=0x09E66648
  fillOrigin  get=0x03D76300  set=0x09E6670C
  eventAlphaThreshold  get=0x03D88460  set=0x03D88490
  alphaHitTestMinimumThreshold  get=0x03D58220  set=0x03D5B6A0
  useSpriteMesh  get=0x03D88480  set=0x09E668B0
  defaultETC1GraphicMaterial  get=0x09E66518
  mainTexture  get=0x025C57E0
  hasBorder  get=0x025A12F0
  pixelsPerUnitMultiplier  get=0x03D581F0  set=0x09E667D0
  pixelsPerUnit  get=0x025A1790
  multipliedPixelsPerUnit  get=0x025A1770
  material  get=0x025C4BA0  set=0x034D2AB0
  minWidth  get=0x03D503F0
  preferredWidth  get=0x025A0C40
  flexibleWidth  get=0x03D751A0
  minHeight  get=0x03D503F0
  preferredHeight  get=0x025A0990
  flexibleHeight  get=0x03D751A0
  layoutPriority  get=0x01002730
  DynamicAtlasActiveMode  get=0x03D88450
METHODS:
  RVA=0x03C84750  token=0x600014D  System.Void ReleaseSprite()
  RVA=0x025CA680  token=0x600014E  System.Void _OnSpriteChanged(UnityEngine.Sprite oldOne)
  RVA=0x03D88440  token=0x600014F  System.Void DisableSpriteOptimizations()
  RVA=0x02432BB0  token=0x6000167  System.Void .ctor()
  RVA=0x0350B670  token=0x6000171  System.Void OnBeforeSerialize()
  RVA=0x023938D0  token=0x6000172  System.Void OnAfterDeserialize()
  RVA=0x033285D0  token=0x6000173  System.Void PreserveSpriteAspectRatio(UnityEngine.Rect& rect, UnityEngine.Vector2 spriteSize)
  RVA=0x025C5D40  token=0x6000174  UnityEngine.Vector4 GetDrawingDimensions(System.Boolean shouldPreserveAspect)
  RVA=0x025A0EF0  token=0x6000175  System.Void SetNativeSize()
  RVA=0x025C4680  token=0x6000176  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
  RVA=0x025C6880  token=0x6000177  System.Void TrackSprite()
  RVA=0x0239AD90  token=0x6000178  System.Void OnEnable()
  RVA=0x0239F370  token=0x6000179  System.Void OnDisable()
  RVA=0x025CA950  token=0x600017A  System.Void Awake()
  RVA=0x025CAE30  token=0x600017B  System.Void OnDestroy()
  RVA=0x025C50D0  token=0x600017C  System.Void UpdateMaterial()
  RVA=0x025A1BD0  token=0x600017D  System.Void OnCanvasHierarchyChanged()
  RVA=0x025A6ED0  token=0x600017E  System.Void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect)
  RVA=0x09E654E8  token=0x600017F  System.Void GenerateSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect)
  RVA=0x025A2CF0  token=0x6000180  System.Void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill)
  RVA=0x02F93F50  token=0x6000181  System.Void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill)
  RVA=0x09E64F80  token=0x6000182  System.Void GenerateMirrorSprite(UnityEngine.UI.VertexHelper toFill)
  RVA=0x09E645EC  token=0x6000183  System.Void GenerateMirrorQuarter(UnityEngine.UI.VertexHelper toFill)
  RVA=0x025A4330  token=0x6000184  System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs)
  RVA=0x025A3A10  token=0x6000185  System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax)
  RVA=0x02636AC0  token=0x6000186  UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect)
  RVA=0x02349130  token=0x6000187  System.Void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, System.Boolean preserveAspect)
  RVA=0x02770A50  token=0x6000188  System.Boolean RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, System.Single fill, System.Boolean invert, System.Int32 corner)
  RVA=0x02770BD0  token=0x6000189  System.Void RadialCut(UnityEngine.Vector3[] xy, System.Single cos, System.Single sin, System.Boolean invert, System.Int32 corner)
  RVA=0x0350B670  token=0x600018A  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x600018B  System.Void CalculateLayoutInputVertical()
  RVA=0x02517520  token=0x6000193  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera)
  RVA=0x09E65E74  token=0x6000194  UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect)
  RVA=0x09E66220  token=0x6000195  System.Void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas)
  RVA=0x09E663A8  token=0x6000196  System.Void TrackImage(UnityEngine.UI.Image g)
  RVA=0x09E664A8  token=0x6000197  System.Void UnTrackImage(UnityEngine.UI.Image g)
  RVA=0x030FB950  token=0x6000198  System.Void OnDidApplyAnimationProperties()
  RVA=0x09E65DCC  token=0x6000199  UnityEngine.Vector4 GetRuntimeAtlasSpritePadding()
  RVA=0x09E65CC0  token=0x600019A  UnityEngine.Vector4 GetRuntimeAtlasSpriteOuterUV()
  RVA=0x09E65A94  token=0x600019B  UnityEngine.Vector4 GetRuntimeAtlasSpriteInnerUV()
  RVA=0x09E65968  token=0x600019C  System.String GetParticlePath()
  RVA=0x025CA9D0  token=0x600019E  System.Void RegisterDynamicAtlas()
  RVA=0x025CA340  token=0x600019F  System.Void UnRegisterDynamicAtlas(UnityEngine.Sprite _sprite)
  RVA=0x02529DA0  token=0x60001A0  System.Void RegisterDynamicAtlasCallBack(System.Action cb)
  RVA=0x0252A230  token=0x60001A1  System.Void UnRegisterDynamicAtlasCallBack(System.Action cb)
  RVA=0x025C9090  token=0x60001A2  System.Void _CanvasRreWillRenderCanvases()
  RVA=0x038E2ED0  token=0x60001A3  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.IMask
TYPE:  interface
TOKEN: 0x200002E
FIELDS:
PROPERTIES:
  rectTransform  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60001A5  System.Boolean Enabled()
END_CLASS

CLASS: UnityEngine.UI.IMaskable
TYPE:  interface
TOKEN: 0x200002F
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001A7  System.Void RecalculateMasking()
END_CLASS

CLASS: UnityEngine.UI.InputField
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x2A0
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IUpdateSelectedHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.UI.ICanvasElement UnityEngine.UI.ILayoutElement
FIELDS:
  protected         UnityEngine.TouchScreenKeyboard m_Keyboard  // 0x180
  private   static readonly System.Char[]                   kSeparators  // static @ 0x0
  private   static  System.Boolean                  s_IsQuestDevice  // static @ 0x8
  protected         UnityEngine.UI.Text             m_TextComponent  // 0x188
  protected         UnityEngine.UI.Graphic          m_Placeholder  // 0x190
  private           UnityEngine.UI.InputField.ContentTypem_ContentType  // 0x198
  private           UnityEngine.UI.InputField.InputTypem_InputType  // 0x19c
  private           System.Char                     m_AsteriskChar  // 0x1a0
  private           UnityEngine.TouchScreenKeyboardTypem_KeyboardType  // 0x1a4
  private           UnityEngine.UI.InputField.LineTypem_LineType  // 0x1a8
  private           System.Boolean                  m_HideMobileInput  // 0x1ac
  private           UnityEngine.UI.InputField.CharacterValidationm_CharacterValidation  // 0x1b0
  private           System.Int32                    m_CharacterLimit  // 0x1b4
  private           UnityEngine.UI.InputField.SubmitEventm_OnSubmit  // 0x1b8
  private           UnityEngine.UI.InputField.EndEditEventm_OnDidEndEdit  // 0x1c0
  private           UnityEngine.UI.InputField.OnChangeEventm_OnValueChanged  // 0x1c8
  private           UnityEngine.UI.InputField.OnValidateInputm_OnValidateInput  // 0x1d0
  private           UnityEngine.Color               m_CaretColor  // 0x1d8
  private           System.Boolean                  m_CustomCaretColor  // 0x1e8
  private           UnityEngine.Color               m_SelectionColor  // 0x1ec
  protected         System.String                   m_Text  // 0x200
  private           System.Single                   m_CaretBlinkRate  // 0x208
  private           System.Int32                    m_CaretWidth  // 0x20c
  private           System.Boolean                  m_ReadOnly  // 0x210
  private           System.Boolean                  m_ShouldActivateOnSelect  // 0x211
  protected         System.Int32                    m_CaretPosition  // 0x214
  protected         System.Int32                    m_CaretSelectPosition  // 0x218
  private           UnityEngine.RectTransform       caretRectTrans  // 0x220
  protected         UnityEngine.UIVertex[]          m_CursorVerts  // 0x228
  private           UnityEngine.TextGenerator       m_InputTextCache  // 0x230
  private           UnityEngine.CanvasRenderer      m_CachedInputRenderer  // 0x238
  private           System.Boolean                  m_PreventFontCallback  // 0x240
  protected         UnityEngine.Mesh                m_Mesh  // 0x248
  private           System.Boolean                  m_AllowInput  // 0x250
  private           System.Boolean                  m_ShouldActivateNextUpdate  // 0x251
  private           System.Boolean                  m_UpdateDrag  // 0x252
  private           System.Boolean                  m_DragPositionOutOfBounds  // 0x253
  private   static  System.Single                   kHScrollSpeed  // const
  private   static  System.Single                   kVScrollSpeed  // const
  protected         System.Boolean                  m_CaretVisible  // 0x254
  private           UnityEngine.Coroutine           m_BlinkCoroutine  // 0x258
  private           System.Single                   m_BlinkStartTime  // 0x260
  protected         System.Int32                    m_DrawStart  // 0x264
  protected         System.Int32                    m_DrawEnd  // 0x268
  private           UnityEngine.Coroutine           m_DragCoroutine  // 0x270
  private           System.String                   m_OriginalText  // 0x278
  private           System.Boolean                  m_WasCanceled  // 0x280
  private           System.Boolean                  m_HasDoneFocusTransition  // 0x281
  private           UnityEngine.WaitForSecondsRealtimem_WaitForSecondsRealtime  // 0x288
  private           System.Boolean                  m_TouchKeyboardAllowsInPlaceEditing  // 0x290
  private           System.Boolean                  m_IsCompositionActive  // 0x291
  private   static  System.String                   kEmailSpecialCharacters  // const
  private   static  System.String                   kOculusQuestDeviceModel  // const
  private           UnityEngine.Event               m_ProcessingEvent  // 0x298
  private   static  System.Int32                    k_MaxTextLength  // const
PROPERTIES:
  input  get=0x09F6D5C4
  compositionString  get=0x09F6D508
  mesh  get=0x09F6D694
  cachedInputTextGenerator  get=0x09F6D3E4
  shouldHideMobileInput  get=0x09F6DA80  set=0x09F6E18C
  shouldActivateOnSelect  get=0x09F6DA5C  set=0x03D89BA0
  text  get=0x03D56BB0  set=0x09F6E494
  isFocused  get=0x03D57B70
  caretBlinkRate  get=0x03D59A50  set=0x09F6DB0C
  caretWidth  get=0x03D84F00  set=0x09F6DC14
  textComponent  get=0x03D56AF0  set=0x09F6E1D8
  placeholder  get=0x03D56B70  set=0x09F6E068
  caretColor  get=0x09F6D460  set=0x09F6DB74
  customCaretColor  get=0x03D57B80  set=0x09F6DDBC
  selectionColor  get=0x03D89B90  set=0x09F6E100
  onEndEdit  get=0x03D571E0  set=0x09F6DF30
  onSubmit  get=0x03D57130  set=0x09F6DF7C
  onValueChange  get=0x03D571D0  set=0x09F6E014
  onValueChanged  get=0x03D571D0  set=0x09F6E01C
  onValidateInput  get=0x03D57000  set=0x09F6DFC8
  characterLimit  get=0x03D75FD0  set=0x09F6DC70
  contentType  get=0x03D59CC0  set=0x09F6DD60
  lineType  get=0x03D583A0  set=0x09F6DE8C
  inputType  get=0x03D59CB0  set=0x09F6DDD4
  touchScreenKeyboard  get=0x03D56B50
  keyboardType  get=0x03D730A0  set=0x09F6DE30
  characterValidation  get=0x03D84CB0  set=0x09F6DD04
  readOnly  get=0x03D58AD0  set=0x03D58AE0
  multiLine  get=0x09F6D738
  asteriskChar  get=0x03D89B80  set=0x09F6DAB0
  wasCanceled  get=0x03D57C70
  caretPositionInternal  get=0x09F6D4B0  set=0x09F6DBB4
  caretSelectPositionInternal  get=0x09F6D4DC  set=0x09F6DBFC
  hasSelection  get=0x09F6D594
  caretPosition  get=0x09F6D4DC  set=0x09F6DBCC
  selectionAnchorPosition  get=0x09F6D4B0  set=0x09F6E0B4
  selectionFocusPosition  get=0x09F6D4DC  set=0x09F6E140
  clipboard  get=0x09D005B0  set=0x09D00AB8
  minWidth  get=0x03D503F0
  preferredWidth  get=0x09F6D8FC
  flexibleWidth  get=0x03D751A0
  minHeight  get=0x03D503F0
  preferredHeight  get=0x09F6D750
  flexibleHeight  get=0x03D751A0
  layoutPriority  get=0x01168950
METHODS:
  RVA=0x09F6D1F0  token=0x60001AA  System.Void .ctor()
  RVA=0x09F6BCCC  token=0x60001B3  System.Void SetTextWithoutNotify(System.String input)
  RVA=0x09F6BCD8  token=0x60001B4  System.Void SetText(System.String value, System.Boolean sendCallback)
  RVA=0x09F66AB4  token=0x60001E1  System.Void ClampPos(System.Int32& pos)
  RVA=0x09F6A958  token=0x60001ED  System.Void OnEnable()
  RVA=0x09F6A554  token=0x60001EE  System.Void OnDisable()
  RVA=0x09F66A58  token=0x60001EF  System.Collections.IEnumerator CaretBlink()
  RVA=0x09F6B6B8  token=0x60001F0  System.Void SetCaretVisible()
  RVA=0x09F6B650  token=0x60001F1  System.Void SetCaretActive()
  RVA=0x09F6C1CC  token=0x60001F2  System.Void UpdateCaretMaterial()
  RVA=0x09F6AD68  token=0x60001F3  System.Void OnFocus()
  RVA=0x09F6B4A8  token=0x60001F4  System.Void SelectAll()
  RVA=0x09F6A398  token=0x60001F5  System.Void MoveTextEnd(System.Boolean shift)
  RVA=0x09F6A3EC  token=0x60001F6  System.Void MoveTextStart(System.Boolean shift)
  RVA=0x09F6C0B4  token=0x60001F9  System.Boolean TouchScreenKeyboardShouldBeUsed()
  RVA=0x09F68874  token=0x60001FA  System.Boolean InPlaceEditing()
  RVA=0x09F68810  token=0x60001FB  System.Boolean InPlaceEditingChanged()
  RVA=0x09F6C11C  token=0x60001FC  System.Void UpdateCaretFromKeyboard()
  RVA=0x09F68E40  token=0x60001FD  System.Void LateUpdate()
  RVA=0x09F6B1D8  token=0x60001FE  UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen)
  RVA=0x09F686AC  token=0x60001FF  System.Int32 GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator)
  RVA=0x09F682C4  token=0x6000200  System.Int32 GetCharacterIndexFromPosition(UnityEngine.Vector2 pos)
  RVA=0x09F6A030  token=0x6000201  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F6A508  token=0x6000202  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F6A7A0  token=0x6000203  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F6A0DC  token=0x6000204  System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F6ABC8  token=0x6000205  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F6AD98  token=0x6000206  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F68A6C  token=0x6000207  UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt)
  RVA=0x09F68A0C  token=0x6000208  System.Boolean IsValidChar(System.Char c)
  RVA=0x09F6B1C0  token=0x6000209  System.Void ProcessEvent(UnityEngine.Event e)
  RVA=0x09F6B008  token=0x600020A  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F68620  token=0x600020B  System.String GetSelectedString()
  RVA=0x09F67240  token=0x600020C  System.Int32 FindtNextWordBegin()
  RVA=0x09F6A2EC  token=0x600020D  System.Void MoveRight(System.Boolean shift, System.Boolean ctrl)
  RVA=0x09F672FC  token=0x600020E  System.Int32 FindtPrevWordBegin()
  RVA=0x09F6A240  token=0x600020F  System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl)
  RVA=0x09F66FBC  token=0x6000210  System.Int32 DetermineCharacterLine(System.Int32 charPos, UnityEngine.TextGenerator generator)
  RVA=0x09F69DDC  token=0x6000211  System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar)
  RVA=0x09F69BEC  token=0x6000212  System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar)
  RVA=0x09F6A234  token=0x6000213  System.Void MoveDown(System.Boolean shift)
  RVA=0x09F6A150  token=0x6000214  System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar)
  RVA=0x09F6A42C  token=0x6000215  System.Void MoveUp(System.Boolean shift)
  RVA=0x09F6A438  token=0x6000216  System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar)
  RVA=0x09F66DE4  token=0x6000217  System.Void Delete()
  RVA=0x09F673B8  token=0x6000218  System.Void ForwardSpace()
  RVA=0x09F66978  token=0x6000219  System.Void Backspace()
  RVA=0x09F68898  token=0x600021A  System.Void Insert(System.Char c)
  RVA=0x09F6CAD0  token=0x600021B  System.Void UpdateTouchKeyboardFromEditChanges()
  RVA=0x09F6B5C0  token=0x600021C  System.Void SendOnValueChangedAndUpdateLabel()
  RVA=0x09F6B5E0  token=0x600021D  System.Void SendOnValueChanged()
  RVA=0x09F6B4E0  token=0x600021E  System.Void SendOnEndEdit()
  RVA=0x09F6B550  token=0x600021F  System.Void SendOnSubmit()
  RVA=0x09F661E0  token=0x6000220  System.Void Append(System.String input)
  RVA=0x09F65F60  token=0x6000221  System.Void Append(System.Char input)
  RVA=0x09F6C69C  token=0x6000222  System.Void UpdateLabel()
  RVA=0x09F689A0  token=0x6000223  System.Boolean IsSelectionVisible()
  RVA=0x09F68578  token=0x6000224  System.Int32 GetLineStartPosition(UnityEngine.TextGenerator gen, System.Int32 line)
  RVA=0x09F684BC  token=0x6000225  System.Int32 GetLineEndPosition(UnityEngine.TextGenerator gen, System.Int32 line)
  RVA=0x09F6B6F8  token=0x6000226  System.Void SetDrawRangeToContainCaretPosition(System.Int32 caretPos)
  RVA=0x09F673B0  token=0x6000227  System.Void ForceLabelUpdate()
  RVA=0x09F69FE4  token=0x6000228  System.Void MarkGeometryAsDirty()
  RVA=0x09F6B1C8  token=0x6000229  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  RVA=0x0350B670  token=0x600022A  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x600022B  System.Void GraphicUpdateComplete()
  RVA=0x09F6C2B0  token=0x600022C  System.Void UpdateGeometry()
  RVA=0x09F66268  token=0x600022D  System.Void AssignPositioningIfNeeded()
  RVA=0x09F6ABEC  token=0x600022E  System.Void OnFillVBO(UnityEngine.Mesh vbo)
  RVA=0x09F67454  token=0x600022F  System.Void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  RVA=0x09F66AE8  token=0x6000230  System.Void CreateCursorVerts()
  RVA=0x09F67B14  token=0x6000231  System.Void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  RVA=0x09F6CB18  token=0x6000232  System.Char Validate(System.String text, System.Int32 pos, System.Char ch)
  RVA=0x09F65E48  token=0x6000233  System.Void ActivateInputField()
  RVA=0x09F65B2C  token=0x6000234  System.Void ActivateInputFieldInternal()
  RVA=0x09F6AF88  token=0x6000235  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F6AD70  token=0x6000236  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F66C50  token=0x6000237  System.Void DeactivateInputField()
  RVA=0x09F6A52C  token=0x6000238  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F6AFC4  token=0x6000239  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F6707C  token=0x600023A  System.Void EnforceContentType()
  RVA=0x09F671AC  token=0x600023B  System.Void EnforceTextHOverflow()
  RVA=0x09F6C04C  token=0x600023C  System.Void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes)
  RVA=0x09F6C09C  token=0x600023D  System.Void SetToCustom()
  RVA=0x09F67058  token=0x600023E  System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant)
  RVA=0x0350B670  token=0x600023F  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x6000240  System.Void CalculateLayoutInputVertical()
  RVA=0x09F6D154  token=0x6000248  System.Void .cctor()
  RVA=0x04273A88  token=0x6000249  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.AspectRatioFitter
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x30
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutSelfController UnityEngine.UI.ILayoutController
FIELDS:
  private           UnityEngine.UI.AspectRatioFitter.AspectModem_AspectMode  // 0x18
  private           System.Single                   m_AspectRatio  // 0x1c
  private           UnityEngine.RectTransform       m_Rect  // 0x20
  private           System.Boolean                  m_DelayedSetDirty  // 0x28
  private           System.Boolean                  m_DoesParentExist  // 0x29
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x2a
PROPERTIES:
  aspectMode  get=0x020D1AC0  set=0x09F65530
  aspectRatio  get=0x03D4F110  set=0x09F65588
  rectTransform  get=0x033BCC80
METHODS:
  RVA=0x03B45ED0  token=0x6000262  System.Void .ctor()
  RVA=0x033BC860  token=0x6000263  System.Void OnEnable()
  RVA=0x033BC650  token=0x6000264  System.Void Start()
  RVA=0x033BC910  token=0x6000265  System.Void OnDisable()
  RVA=0x09F654B0  token=0x6000266  System.Void OnTransformParentChanged()
  RVA=0x036515F0  token=0x6000267  System.Void Update()
  RVA=0x033BC970  token=0x6000268  System.Void OnRectTransformDimensionsChange()
  RVA=0x033BC980  token=0x6000269  System.Void UpdateRect()
  RVA=0x033BC690  token=0x600026A  System.Single GetSizeDeltaToProduceSize(System.Single size, System.Int32 axis)
  RVA=0x033BC790  token=0x600026B  UnityEngine.Vector2 GetParentSize()
  RVA=0x0350B670  token=0x600026C  System.Void SetLayoutHorizontal()
  RVA=0x0350B670  token=0x600026D  System.Void SetLayoutVertical()
  RVA=0x033BC970  token=0x600026E  System.Void SetDirty()
  RVA=0x033BCD10  token=0x600026F  System.Boolean IsComponentValidOnObject()
  RVA=0x033BC680  token=0x6000270  System.Boolean IsAspectModeValid()
  RVA=0x03D4F2A0  token=0x6000271  System.Boolean DoesParentExists()
END_CLASS

CLASS: UnityEngine.UI.CanvasScaler
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x60
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  private           UnityEngine.UI.CanvasScaler.ScaleModem_UiScaleMode  // 0x18
  protected         System.Single                   m_ReferencePixelsPerUnit  // 0x1c
  protected         System.Single                   m_ScaleFactor  // 0x20
  protected         UnityEngine.Vector2             m_ReferenceResolution  // 0x24
  protected         UnityEngine.UI.CanvasScaler.ScreenMatchModem_ScreenMatchMode  // 0x2c
  protected         System.Single                   m_MatchWidthOrHeight  // 0x30
  private   static  System.Single                   kLogBase  // const
  protected         UnityEngine.UI.CanvasScaler.Unitm_PhysicalUnit  // 0x34
  protected         System.Single                   m_FallbackScreenDPI  // 0x38
  protected         System.Single                   m_DefaultSpriteDPI  // 0x3c
  protected         System.Single                   m_DynamicPixelsPerUnit  // 0x40
  private           UnityEngine.Canvas              m_Canvas  // 0x48
  private           System.Single                   m_PrevScaleFactor  // 0x50
  private           System.Single                   m_PrevReferencePixelsPerUnit  // 0x54
  protected         System.Boolean                  m_PresetInfoIsWorld  // 0x58
PROPERTIES:
  uiScaleMode  get=0x020D1AC0  set=0x03D4E9C0
  referencePixelsPerUnit  get=0x03D4F110  set=0x03D4F120
  scaleFactor  get=0x03D4F2E0  set=0x09F6569C
  referenceResolution  get=0x03D50A80  set=0x027FF6C0
  screenMatchMode  get=0x03D4EDD0  set=0x03D4EDE0
  matchWidthOrHeight  get=0x03D4F5D0  set=0x03D4F5E0
  physicalUnit  get=0x03D4EE00  set=0x03D4EE40
  fallbackScreenDPI  get=0x03D51000  set=0x03D51010
  defaultSpriteDPI  get=0x03D4EC60  set=0x09F65688
  dynamicPixelsPerUnit  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x0352E5B0  token=0x6000286  System.Void .ctor()
  RVA=0x02473670  token=0x6000287  System.Void OnEnable()
  RVA=0x02373580  token=0x6000288  System.Void Canvas_preWillRenderCanvases()
  RVA=0x02472550  token=0x6000289  System.Void OnDisable()
  RVA=0x027FE790  token=0x600028A  System.Void HandleManually()
  RVA=0x023737A0  token=0x600028B  System.Void Handle()
  RVA=0x02FEC020  token=0x600028C  System.Void HandleWorldCanvas()
  RVA=0x03D47B30  token=0x600028D  System.Void HandleConstantPixelSize()
  RVA=0x02375490  token=0x600028E  System.Void HandleScaleWithScreenSize()
  RVA=0x09F655E4  token=0x600028F  System.Void HandleConstantPhysicalSize()
  RVA=0x02373A90  token=0x6000290  System.Void SetScaleFactor(System.Single scaleFactor)
  RVA=0x02373AE0  token=0x6000291  System.Void SetReferencePixelsPerUnit(System.Single referencePixelsPerUnit)
END_CLASS

CLASS: UnityEngine.UI.ContentSizeFitter
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x30
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutSelfController UnityEngine.UI.ILayoutController
FIELDS:
  protected         UnityEngine.UI.ContentSizeFitter.FitModem_HorizontalFit  // 0x18
  protected         UnityEngine.UI.ContentSizeFitter.FitModem_VerticalFit  // 0x1c
  private           UnityEngine.RectTransform       m_Rect  // 0x20
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x28
PROPERTIES:
  horizontalFit  get=0x020D1AC0  set=0x0259D3B0
  verticalFit  get=0x03D4EBB0  set=0x09F656B0
  rectTransform  get=0x0259FEA0
METHODS:
  RVA=0x0426FE60  token=0x6000297  System.Void .ctor()
  RVA=0x0259E3B0  token=0x6000298  System.Void OnEnable()
  RVA=0x0259E350  token=0x6000299  System.Void OnDisable()
  RVA=0x0259E3B0  token=0x600029A  System.Void OnRectTransformDimensionsChange()
  RVA=0x0259FE10  token=0x600029B  System.Void HandleSelfFittingAlongAxis(System.Int32 axis)
  RVA=0x0259FDA0  token=0x600029C  System.Void SetLayoutHorizontal()
  RVA=0x0427071C  token=0x600029D  System.Void SetLayoutVertical()
  RVA=0x0259E560  token=0x600029E  System.Void SetDirty()
END_CLASS

CLASS: UnityEngine.UI.GridLayoutGroup
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x78
EXTENDS: UnityEngine.UI.LayoutGroup
FIELDS:
  protected         UnityEngine.UI.GridLayoutGroup.Cornerm_StartCorner  // 0x58
  protected         UnityEngine.UI.GridLayoutGroup.Axism_StartAxis  // 0x5c
  protected         UnityEngine.Vector2             m_CellSize  // 0x60
  protected         UnityEngine.Vector2             m_Spacing  // 0x68
  protected         UnityEngine.UI.GridLayoutGroup.Constraintm_Constraint  // 0x70
  protected         System.Int32                    m_ConstraintCount  // 0x74
PROPERTIES:
  startCorner  get=0x03D4EF00  set=0x09F65900
  startAxis  get=0x03D4EEF0  set=0x09F658B4
  cellSize  get=0x03D89B40  set=0x09F65760
  spacing  get=0x03D89B60  set=0x09F65860
  constraint  get=0x03D4F0C0  set=0x09F65814
  constraintCount  get=0x03D4F0D0  set=0x09F657B4
METHODS:
  RVA=0x02849F60  token=0x60002AB  System.Void .ctor()
  RVA=0x036BE620  token=0x60002AC  System.Void CalculateLayoutInputHorizontal()
  RVA=0x02EE1740  token=0x60002AD  System.Void CalculateLayoutInputVertical()
  RVA=0x09F65744  token=0x60002AE  System.Void SetLayoutHorizontal()
  RVA=0x09F65750  token=0x60002AF  System.Void SetLayoutVertical()
  RVA=0x03497880  token=0x60002B0  System.Void SetCellsAlongAxis(System.Int32 axis)
END_CLASS

CLASS: UnityEngine.UI.HorizontalLayoutGroup
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x68
EXTENDS: UnityEngine.UI.HorizontalOrVerticalLayoutGroup
FIELDS:
METHODS:
  RVA=0x0335B640  token=0x60002B1  System.Void .ctor()
  RVA=0x024A55E0  token=0x60002B2  System.Void CalculateLayoutInputHorizontal()
  RVA=0x042745E0  token=0x60002B3  System.Void CalculateLayoutInputVertical()
  RVA=0x042706EC  token=0x60002B4  System.Void SetLayoutHorizontal()
  RVA=0x042706DC  token=0x60002B5  System.Void SetLayoutVertical()
END_CLASS

CLASS: UnityEngine.UI.HorizontalOrVerticalLayoutGroup
TYPE:  abstract class
TOKEN: 0x2000049
SIZE:  0x68
EXTENDS: UnityEngine.UI.LayoutGroup
FIELDS:
  protected         System.Single                   m_Spacing  // 0x58
  protected         System.Boolean                  m_ChildForceExpandWidth  // 0x5c
  protected         System.Boolean                  m_ChildForceExpandHeight  // 0x5d
  protected         System.Boolean                  m_ChildControlWidth  // 0x5e
  protected         System.Boolean                  m_ChildControlHeight  // 0x5f
  protected         System.Boolean                  m_ChildScaleWidth  // 0x60
  protected         System.Boolean                  m_ChildScaleHeight  // 0x61
  protected         System.Boolean                  m_ReverseArrangement  // 0x62
PROPERTIES:
  spacing  get=0x03D51080  set=0x03C7DF90
  childForceExpandWidth  get=0x03D4F600  set=0x03641ED0
  childForceExpandHeight  get=0x03D71350  set=0x09F659EC
  childControlWidth  get=0x03D71370  set=0x09F6599C
  childControlHeight  get=0x03D57680  set=0x09F6594C
  childScaleWidth  get=0x03D519A0  set=0x09F65A8C
  childScaleHeight  get=0x03D51F90  set=0x09F65A3C
  reverseArrangement  get=0x03D5B400  set=0x09F65ADC
METHODS:
  RVA=0x024A8150  token=0x60002C6  System.Void CalcAlongAxis(System.Int32 axis, System.Boolean isVertical)
  RVA=0x024A7280  token=0x60002C7  System.Void SetChildrenAlongAxis(System.Int32 axis, System.Boolean isVertical)
  RVA=0x024A87E0  token=0x60002C8  System.Void GetChildSizes(UnityEngine.RectTransform child, System.Int32 axis, System.Boolean controlSize, System.Boolean childForceExpand, System.Single& min, System.Single& preferred, System.Single& flexible)
  RVA=0x0335B640  token=0x60002C9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.ILayoutElement
TYPE:  interface
TOKEN: 0x200004A
FIELDS:
PROPERTIES:
  minWidth  get=-1  // abstract
  preferredWidth  get=-1  // abstract
  flexibleWidth  get=-1  // abstract
  minHeight  get=-1  // abstract
  preferredHeight  get=-1  // abstract
  flexibleHeight  get=-1  // abstract
  layoutPriority  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60002CA  System.Void CalculateLayoutInputHorizontal()
  RVA=-1  // abstract  token=0x60002CB  System.Void CalculateLayoutInputVertical()
END_CLASS

CLASS: UnityEngine.UI.ILayoutController
TYPE:  interface
TOKEN: 0x200004B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60002D3  System.Void SetLayoutHorizontal()
  RVA=-1  // abstract  token=0x60002D4  System.Void SetLayoutVertical()
END_CLASS

CLASS: UnityEngine.UI.ILayoutGroup
TYPE:  interface
TOKEN: 0x200004C
IMPLEMENTS: UnityEngine.UI.ILayoutController
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UI.ILayoutSelfController
TYPE:  interface
TOKEN: 0x200004D
IMPLEMENTS: UnityEngine.UI.ILayoutController
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UI.ILayoutIgnorer
TYPE:  interface
TOKEN: 0x200004E
FIELDS:
PROPERTIES:
  ignoreLayout  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UI.LayoutElement
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x38
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutElement UnityEngine.UI.ILayoutIgnorer
FIELDS:
  private           System.Boolean                  m_IgnoreLayout  // 0x18
  private           System.Single                   m_MinWidth  // 0x1c
  private           System.Single                   m_MinHeight  // 0x20
  private           System.Single                   m_PreferredWidth  // 0x24
  private           System.Single                   m_PreferredHeight  // 0x28
  private           System.Single                   m_FlexibleWidth  // 0x2c
  private           System.Single                   m_FlexibleHeight  // 0x30
  private           System.Int32                    m_LayoutPriority  // 0x34
PROPERTIES:
  ignoreLayout  get=0x01002A50  set=0x022BF6C0
  minWidth  get=0x03D4F110  set=0x09F6E5B0
  minHeight  get=0x03D4F2E0  set=0x09F6E554
  preferredWidth  get=0x03D524F0  set=0x02CD0CC0
  preferredHeight  get=0x03D4F480  set=0x02CD1420
  flexibleWidth  get=0x03D4F3A0  set=0x03197A10
  flexibleHeight  get=0x03D4F5D0  set=0x09F6E4A0
  layoutPriority  get=0x03D4EE00  set=0x09F6E4FC
METHODS:
  RVA=0x0350B670  token=0x60002D8  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x60002D9  System.Void CalculateLayoutInputVertical()
  RVA=0x031659C0  token=0x60002E8  System.Void .ctor()
  RVA=0x02CD1270  token=0x60002E9  System.Void OnEnable()
  RVA=0x02CD1270  token=0x60002EA  System.Void OnTransformParentChanged()
  RVA=0x02CD1270  token=0x60002EB  System.Void OnDisable()
  RVA=0x02CD1270  token=0x60002EC  System.Void OnDidApplyAnimationProperties()
  RVA=0x02CD1270  token=0x60002ED  System.Void OnBeforeTransformParentChanged()
  RVA=0x02CD1280  token=0x60002EE  System.Void SetDirty()
END_CLASS

CLASS: UnityEngine.UI.LayoutGroup
TYPE:  abstract class
TOKEN: 0x2000050
SIZE:  0x58
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutElement UnityEngine.UI.ILayoutGroup UnityEngine.UI.ILayoutController
FIELDS:
  protected         UnityEngine.RectOffset          m_Padding  // 0x18
  protected         UnityEngine.TextAnchor          m_ChildAlignment  // 0x20
  private           UnityEngine.RectTransform       m_Rect  // 0x28
  protected         UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x30
  private           UnityEngine.Vector2             m_TotalMinSize  // 0x34
  private           UnityEngine.Vector2             m_TotalPreferredSize  // 0x3c
  private           UnityEngine.Vector2             m_TotalFlexibleSize  // 0x44
  private           System.Collections.Generic.List<UnityEngine.RectTransform>m_RectChildren  // 0x50
PROPERTIES:
  padding  get=0x01041090  set=0x02CD1220
  childAlignment  get=0x01003B50  set=0x09F6E6AC
  rectTransform  get=0x024A68A0
  rectChildren  get=0x03D4EAF0
  minWidth  get=0x042743D0
  preferredWidth  get=0x04270790
  flexibleWidth  get=0x04270750
  minHeight  get=0x04270730
  preferredHeight  get=0x04270740
  flexibleHeight  get=0x04270760
  layoutPriority  get=0x01002730
  isRootLayoutGroup  get=0x024A4C20
METHODS:
  RVA=0x024A61E0  token=0x60002F5  System.Void CalculateLayoutInputHorizontal()
  RVA=-1  // abstract  token=0x60002F6  System.Void CalculateLayoutInputVertical()
  RVA=-1  // abstract  token=0x60002FE  System.Void SetLayoutHorizontal()
  RVA=-1  // abstract  token=0x60002FF  System.Void SetLayoutVertical()
  RVA=0x028495F0  token=0x6000300  System.Void .ctor()
  RVA=0x024A3500  token=0x6000301  System.Void OnEnable()
  RVA=0x0338BEE0  token=0x6000302  System.Void OnDisable()
  RVA=0x024A3500  token=0x6000303  System.Void OnDidApplyAnimationProperties()
  RVA=0x042700B8  token=0x6000304  System.Single GetTotalMinSize(System.Int32 axis)
  RVA=0x042700C4  token=0x6000305  System.Single GetTotalPreferredSize(System.Int32 axis)
  RVA=0x09F6E60C  token=0x6000306  System.Single GetTotalFlexibleSize(System.Int32 axis)
  RVA=0x024A6000  token=0x6000307  System.Single GetStartOffset(System.Int32 axis, System.Single requiredSpaceWithoutPadding)
  RVA=0x024A69D0  token=0x6000308  System.Single GetAlignmentOnAxis(System.Int32 axis)
  RVA=0x024A6E90  token=0x6000309  System.Void SetLayoutInputForAxis(System.Single totalMin, System.Single totalPreferred, System.Single totalFlexible, System.Int32 axis)
  RVA=0x09F6E618  token=0x600030A  System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos)
  RVA=0x024A5CB0  token=0x600030B  System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single scaleFactor)
  RVA=0x03497DD0  token=0x600030C  System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size)
  RVA=0x024A6AC0  token=0x600030D  System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size, System.Single scaleFactor)
  RVA=0x024A4BF0  token=0x600030F  System.Void OnRectTransformDimensionsChange()
  RVA=0x024A3500  token=0x6000310  System.Void OnTransformChildrenChanged()
  RVA=-1  // generic def  token=0x6000311  System.Void SetProperty(T& currentValue, T newValue)
  RVA=0x024A52C0  token=0x6000312  System.Void SetDirty()
  RVA=0x024A4550  token=0x6000313  System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform)
END_CLASS

CLASS: UnityEngine.UI.LayoutRebuilder
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x20
IMPLEMENTS: UnityEngine.UI.ICanvasElement
FIELDS:
  private           UnityEngine.RectTransform       m_ToRebuild  // 0x10
  private           System.Int32                    m_CachedHashFromTransform  // 0x18
  private   static  UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder>s_Rebuilders  // static @ 0x0
PROPERTIES:
  transform  get=0x020B7B20
METHODS:
  RVA=0x0239D060  token=0x600031A  System.Void Initialize(UnityEngine.RectTransform controller)
  RVA=0x0426F864  token=0x600031B  System.Void Clear()
  RVA=0x038E4060  token=0x600031C  System.Void .cctor()
  RVA=0x0304E030  token=0x600031D  System.Void ReapplyDrivenProperties(UnityEngine.RectTransform driven)
  RVA=0x03322AC0  token=0x600031F  System.Boolean IsDestroyed()
  RVA=0x0251E100  token=0x6000320  System.Void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components)
  RVA=0x02B7C240  token=0x6000321  System.Void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot)
  RVA=0x02B7C330  token=0x6000322  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x02B7C6F0  token=0x6000323  System.Void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action)
  RVA=0x0251D780  token=0x6000324  System.Void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action)
  RVA=0x0251B890  token=0x6000325  System.Void MarkLayoutForRebuild(UnityEngine.RectTransform rect)
  RVA=0x0251E350  token=0x6000326  System.Boolean ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps)
  RVA=0x0239CE40  token=0x6000327  System.Void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller)
  RVA=0x0329DBF0  token=0x6000328  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x6000329  System.Void GraphicUpdateComplete()
  RVA=0x020D1AC0  token=0x600032A  System.Int32 GetHashCode()
  RVA=0x02F82620  token=0x600032B  System.Boolean Equals(System.Object obj)
  RVA=0x09F6E6F8  token=0x600032C  System.String ToString()
  RVA=0x0350B670  token=0x600032D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.LayoutUtility
TYPE:  static class
TOKEN: 0x2000054
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x024A8C80  token=0x6000337  System.Single GetMinSize(UnityEngine.RectTransform rect, System.Int32 axis)
  RVA=0x024A8B20  token=0x6000338  System.Single GetPreferredSize(UnityEngine.RectTransform rect, System.Int32 axis)
  RVA=0x024A8B50  token=0x6000339  System.Single GetFlexibleSize(UnityEngine.RectTransform rect, System.Int32 axis)
  RVA=0x024A7160  token=0x600033A  System.Single GetMinWidth(UnityEngine.RectTransform rect)
  RVA=0x024A8DB0  token=0x600033B  System.Single GetPreferredWidth(UnityEngine.RectTransform rect)
  RVA=0x024A7040  token=0x600033C  System.Single GetFlexibleWidth(UnityEngine.RectTransform rect)
  RVA=0x02F5C880  token=0x600033D  System.Single GetMinHeight(UnityEngine.RectTransform rect)
  RVA=0x02F5CAC0  token=0x600033E  System.Single GetPreferredHeight(UnityEngine.RectTransform rect)
  RVA=0x02F5C9A0  token=0x600033F  System.Single GetFlexibleHeight(UnityEngine.RectTransform rect)
  RVA=0x04270124  token=0x6000340  System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue)
  RVA=0x02517DC0  token=0x6000341  System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue, UnityEngine.UI.ILayoutElement& source)
END_CLASS

CLASS: UnityEngine.UI.VerticalLayoutGroup
TYPE:  class
TOKEN: 0x2000056
SIZE:  0x68
EXTENDS: UnityEngine.UI.HorizontalOrVerticalLayoutGroup
FIELDS:
METHODS:
  RVA=0x0335B640  token=0x600034C  System.Void .ctor()
  RVA=0x024A4BC0  token=0x600034D  System.Void CalculateLayoutInputHorizontal()
  RVA=0x042745F0  token=0x600034E  System.Void CalculateLayoutInputVertical()
  RVA=0x0427070C  token=0x600034F  System.Void SetLayoutHorizontal()
  RVA=0x042706FC  token=0x6000350  System.Void SetLayoutVertical()
END_CLASS

CLASS: UnityEngine.UI.Mask
TYPE:  class
TOKEN: 0x2000057
SIZE:  0x40
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.ICanvasRaycastFilter UnityEngine.UI.IMaterialModifier
FIELDS:
  private           UnityEngine.RectTransform       m_RectTransform  // 0x18
  private           System.Boolean                  m_ShowMaskGraphic  // 0x20
  private           UnityEngine.UI.Graphic          m_Graphic  // 0x28
  private           UnityEngine.Material            m_MaskMaterial  // 0x30
  private           UnityEngine.Material            m_UnmaskMaterial  // 0x38
PROPERTIES:
  rectTransform  get=0x02516120
  showMaskGraphic  get=0x03D4EF90  set=0x09F6E758
  graphic  get=0x025167D0
METHODS:
  RVA=0x03A1E660  token=0x6000355  System.Void .ctor()
  RVA=0x02516230  token=0x6000356  System.Boolean MaskEnabled()
  RVA=0x0350B670  token=0x6000357  System.Void OnSiblingGraphicEnabledDisabled()
  RVA=0x02516680  token=0x6000358  System.Void OnEnable()
  RVA=0x025162B0  token=0x6000359  System.Void OnDisable()
  RVA=0x02516080  token=0x600035A  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  RVA=0x02516490  token=0x600035B  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
END_CLASS

CLASS: UnityEngine.UI.MaskableGraphic
TYPE:  abstract class
TOKEN: 0x2000058
SIZE:  0xE8
EXTENDS: UnityEngine.UI.Graphic
IMPLEMENTS: UnityEngine.UI.IClippable UnityEngine.UI.IMaskable UnityEngine.UI.IMaterialModifier
FIELDS:
  protected         System.Boolean                  m_ShouldRecalculateStencil  // 0xb0
  protected         UnityEngine.Material            m_MaskMaterial  // 0xb8
  private           UnityEngine.UI.RectMask2D       m_ParentMask  // 0xc0
  private           System.Boolean                  m_Maskable  // 0xc8
  private           System.Boolean                  m_IsMaskingGraphic  // 0xc9
  protected         System.Boolean                  m_IncludeForMasking  // 0xca
  private           UnityEngine.UI.MaskableGraphic.CullStateChangedEventm_OnCullStateChanged  // 0xd0
  protected         System.Boolean                  m_ShouldRecalculate  // 0xd8
  protected         System.Int32                    m_StencilValue  // 0xdc
  private   readonly UnityEngine.Vector3[]           m_Corners  // 0xe0
PROPERTIES:
  onCullStateChanged  get=0x03D50050  set=0x0554A7E0
  maskable  get=0x03D519D0  set=0x09F6E7E4
  isMaskingGraphic  get=0x03D58400  set=0x02515FD0
  rootCanvasRect  get=0x02347550
METHODS:
  RVA=0x025C75E0  token=0x6000362  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  RVA=0x02342020  token=0x6000363  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  RVA=0x02341DF0  token=0x6000364  System.Void UpdateCull(System.Boolean cull)
  RVA=0x02EC41E0  token=0x6000365  System.Void SetClipRect(UnityEngine.Rect clipRect, System.Boolean validRect)
  RVA=0x02341BC0  token=0x6000366  System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness)
  RVA=0x02341AF0  token=0x6000367  System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness)
  RVA=0x0239A120  token=0x6000368  System.Void OnEnable()
  RVA=0x0239F4B0  token=0x6000369  System.Void OnDisable()
  RVA=0x03163550  token=0x600036A  System.Void OnTransformParentChanged()
  RVA=0x0350B670  token=0x600036B  System.Void ParentMaskStateChanged()
  RVA=0x025A1D50  token=0x600036C  System.Void OnCanvasHierarchyChanged()
  RVA=0x0239A170  token=0x600036E  System.Void UpdateClipParent()
  RVA=0x02515D70  token=0x600036F  System.Void RecalculateClipping()
  RVA=0x0239F2E0  token=0x6000370  System.Void RecalculateMasking()
  RVA=0x02433960  token=0x6000371  System.Void .ctor()
  RVA=0x0426FB4C  token=0x6000372  UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject()
END_CLASS

CLASS: UnityEngine.UI.MaskUtilities
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02518C70  token=0x6000374  System.Void Notify2DMaskStateChanged(UnityEngine.Component mask)
  RVA=0x025168D0  token=0x6000375  System.Void NotifyStencilStateChanged(UnityEngine.Component mask)
  RVA=0x02517670  token=0x6000376  UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start)
  RVA=0x0251E990  token=0x6000377  System.Int32 GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter)
  RVA=0x0251CDF0  token=0x6000378  System.Boolean IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child)
  RVA=0x0239A3E0  token=0x6000379  UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable)
  RVA=0x02516EE0  token=0x600037A  System.Void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks)
  RVA=0x0350B670  token=0x600037B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.IMaterialModifier
TYPE:  interface
TOKEN: 0x200005B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600037C  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
END_CLASS

CLASS: UnityEngine.UI.Misc
TYPE:  static class
TOKEN: 0x200005C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F6F368  token=0x600037D  System.Void Destroy(UnityEngine.Object obj)
  RVA=0x039B53E0  token=0x600037E  System.Void DestroyImmediate(UnityEngine.Object obj)
END_CLASS

CLASS: UnityEngine.UI.MultipleDisplayUtilities
TYPE:  static class
TOKEN: 0x200005D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F6F434  token=0x600037F  System.Boolean GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Vector2& position)
  RVA=0x0256C470  token=0x6000380  UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position)
END_CLASS

CLASS: UnityEngine.UI.Navigation
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x38
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UI.Navigation.Mode  m_Mode  // 0x10
  private           System.Boolean                  m_WrapAround  // 0x14
  private           UnityEngine.UI.Selectable       m_SelectOnUp  // 0x18
  private           UnityEngine.UI.Selectable       m_SelectOnDown  // 0x20
  private           UnityEngine.UI.Selectable       m_SelectOnLeft  // 0x28
  private           UnityEngine.UI.Selectable       m_SelectOnRight  // 0x30
PROPERTIES:
  mode  get=0x03D4E980  set=0x03D4E970
  wrapAround  get=0x03D55A00  set=0x03D5DDF0
  selectOnUp  get=0x03D50DE0  set=0x0558FF08
  selectOnDown  get=0x020B7B20  set=0x0426FEE0
  selectOnLeft  get=0x01041090  set=0x022C3A90
  selectOnRight  get=0x03D4EB40  set=0x04271930
  defaultNavigation  get=0x03D89BF0
METHODS:
  RVA=0x0314FF60  token=0x600038E  System.Boolean Equals(UnityEngine.UI.Navigation other)
END_CLASS

CLASS: UnityEngine.UI.RawImage
TYPE:  class
TOKEN: 0x2000060
SIZE:  0x100
EXTENDS: UnityEngine.UI.MaskableGraphic
FIELDS:
  private           UnityEngine.Texture             m_Texture  // 0xe8
  private           UnityEngine.Rect                m_UVRect  // 0xf0
PROPERTIES:
  mainTexture  get=0x033F9BE0
  texture  get=0x03D50EA0  set=0x035ED400
  uvRect  get=0x03D6C080  set=0x09F6F644
METHODS:
  RVA=0x02700780  token=0x600038F  System.Void .ctor()
  RVA=0x09F6F50C  token=0x6000395  System.Void SetNativeSize()
  RVA=0x031EA390  token=0x6000396  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  RVA=0x030FB950  token=0x6000397  System.Void OnDidApplyAnimationProperties()
END_CLASS

CLASS: UnityEngine.UI.RectMask2D
TYPE:  class
TOKEN: 0x2000061
SIZE:  0x98
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.IClipper UnityEngine.ICanvasRaycastFilter
FIELDS:
  private   readonly UnityEngine.UI.RectangularVertexClipperm_VertexClipper  // 0x18
  private           UnityEngine.RectTransform       m_RectTransform  // 0x20
  private           System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic>m_MaskableTargets  // 0x28
  private           System.Collections.Generic.HashSet<UnityEngine.UI.IClippable>m_ClipTargets  // 0x30
  private           System.Boolean                  m_ShouldRecalculateClipRects  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UI.RectMask2D>m_Clippers  // 0x40
  private           UnityEngine.Rect                m_LastClipRectCanvasSpace  // 0x48
  private           System.Boolean                  m_ForceClip  // 0x58
  private           UnityEngine.Vector4             m_Padding  // 0x5c
  private           UnityEngine.Vector2Int          m_Softness  // 0x6c
  private           UnityEngine.Vector4             m_HGSoftness  // 0x74
  private           UnityEngine.Canvas              m_Canvas  // 0x88
  private           UnityEngine.Vector3[]           m_Corners  // 0x90
PROPERTIES:
  padding  get=0x03D73B30  set=0x09F6FB38
  softness  get=0x03D55B60  set=0x09F6FB48
  hgSoftness  get=0x03D5D5D0  set=0x09F6FAF8
  Canvas  get=0x0233F1D0
  canvasRect  get=0x0233EBC0
  rectTransform  get=0x0233EE90
  rootCanvasRect  get=0x02343A80
METHODS:
  RVA=0x03294A20  token=0x60003A1  System.Void .ctor()
  RVA=0x02516DA0  token=0x60003A2  System.Void OnEnable()
  RVA=0x02516CA0  token=0x60003A3  System.Void OnDisable()
  RVA=0x02517200  token=0x60003A4  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  RVA=0x023408B0  token=0x60003A6  System.Void PerformClipping()
  RVA=0x02341600  token=0x60003A7  System.Void UpdateClipSoftness()
  RVA=0x0308CBA0  token=0x60003A8  System.Void AddClippable(UnityEngine.UI.IClippable clippable)
  RVA=0x02EC3E40  token=0x60003A9  System.Void RemoveClippable(UnityEngine.UI.IClippable clippable)
  RVA=0x03D5C330  token=0x60003AA  System.Void OnTransformParentChanged()
  RVA=0x0352D200  token=0x60003AB  System.Void OnCanvasHierarchyChanged()
END_CLASS

CLASS: UnityEngine.UI.Scrollbar
TYPE:  class
TOKEN: 0x2000062
SIZE:  0x1C8
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IInitializePotentialDragHandler UnityEngine.UI.ICanvasElement
FIELDS:
  private           UnityEngine.RectTransform       m_HandleRect  // 0x180
  private           UnityEngine.UI.Scrollbar.Directionm_Direction  // 0x188
  private           System.Single                   m_Value  // 0x18c
  private           System.Single                   m_Size  // 0x190
  private           System.Int32                    m_NumberOfSteps  // 0x194
  private           UnityEngine.UI.Scrollbar.ScrollEventm_OnValueChanged  // 0x198
  private           UnityEngine.RectTransform       m_ContainerRect  // 0x1a0
  private           UnityEngine.Vector2             m_Offset  // 0x1a8
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x1b0
  private           UnityEngine.Coroutine           m_PointerDownRepeat  // 0x1b8
  private           System.Boolean                  isPointerDownAndNotDragging  // 0x1c0
  private           System.Boolean                  m_DelayedUpdateVisuals  // 0x1c1
PROPERTIES:
  handleRect  get=0x03D56B50  set=0x09F71C2C
  direction  get=0x03D4FC10  set=0x09F71BD0
  value  get=0x02C6D150  set=0x04271E08
  size  get=0x03D58260  set=0x028C2090
  numberOfSteps  get=0x03D89C40  set=0x09F71C94
  onValueChanged  get=0x03D56AE0  set=0x04275BC0
  stepSize  get=0x09F71BA0
  axis  get=0x02C6D060
  reverseValue  get=0x02C6D180
METHODS:
  RVA=0x02848F90  token=0x60003B0  System.Void .ctor()
  RVA=0x09F71910  token=0x60003B3  System.Void SetValueWithoutNotify(System.Single input)
  RVA=0x0350B670  token=0x60003BB  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x0350B670  token=0x60003BC  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x60003BD  System.Void GraphicUpdateComplete()
  RVA=0x03916020  token=0x60003BE  System.Void OnEnable()
  RVA=0x0361D5F0  token=0x60003BF  System.Void OnDisable()
  RVA=0x038DDF60  token=0x60003C0  System.Void Update()
  RVA=0x03916060  token=0x60003C1  System.Void UpdateCachedReferences()
  RVA=0x02C6D080  token=0x60003C2  System.Void Set(System.Single input, System.Boolean sendCallback)
  RVA=0x03B0D650  token=0x60003C3  System.Void OnRectTransformDimensionsChange()
  RVA=0x02C6CED0  token=0x60003C6  System.Void UpdateVisuals()
  RVA=0x09F7191C  token=0x60003C7  System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F710B8  token=0x60003C8  System.Void DoUpdateDrag(UnityEngine.Vector2 handleCorner, System.Single remainingSize)
  RVA=0x09F711F4  token=0x60003C9  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F71248  token=0x60003CA  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F71458  token=0x60003CB  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F716EC  token=0x60003CC  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F71040  token=0x60003CD  System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F70FB0  token=0x60003CE  System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera)
  RVA=0x09F717B4  token=0x60003CF  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F714FC  token=0x60003D0  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  RVA=0x09F71158  token=0x60003D1  UnityEngine.UI.Selectable FindSelectableOnLeft()
  RVA=0x09F7118C  token=0x60003D2  UnityEngine.UI.Selectable FindSelectableOnRight()
  RVA=0x09F711C0  token=0x60003D3  UnityEngine.UI.Selectable FindSelectableOnUp()
  RVA=0x09F71124  token=0x60003D4  UnityEngine.UI.Selectable FindSelectableOnDown()
  RVA=0x09F714E0  token=0x60003D5  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F717D4  token=0x60003D6  System.Void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts)
  RVA=0x04273A88  token=0x60003D7  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.ScrollRect
TYPE:  class
TOKEN: 0x2000067
SIZE:  0x150
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IInitializePotentialDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IScrollHandler UnityEngine.UI.ICanvasElement UnityEngine.UI.ILayoutElement UnityEngine.UI.ILayoutGroup UnityEngine.UI.ILayoutController
FIELDS:
  private           UnityEngine.RectTransform       m_Content  // 0x18
  private           System.Boolean                  m_Horizontal  // 0x20
  private           System.Boolean                  m_Vertical  // 0x21
  protected         UnityEngine.GameObject          m_scrollEnableNode  // 0x28
  private           UnityEngine.UI.ScrollRect.MovementTypem_MovementType  // 0x30
  private           System.Single                   m_Elasticity  // 0x34
  private           System.Boolean                  m_Inertia  // 0x38
  private           System.Single                   m_DecelerationRate  // 0x3c
  private           System.Single                   m_ScrollSensitivity  // 0x40
  private           UnityEngine.RectTransform       m_Viewport  // 0x48
  private           UnityEngine.UI.Scrollbar        m_HorizontalScrollbar  // 0x50
  private           UnityEngine.UI.Scrollbar        m_VerticalScrollbar  // 0x58
  private           UnityEngine.UI.ScrollRect.ScrollbarVisibilitym_HorizontalScrollbarVisibility  // 0x60
  private           UnityEngine.UI.ScrollRect.ScrollbarVisibilitym_VerticalScrollbarVisibility  // 0x64
  private           System.Single                   m_HorizontalScrollbarSpacing  // 0x68
  private           System.Single                   m_VerticalScrollbarSpacing  // 0x6c
  private           UnityEngine.UI.ScrollRect.ScrollRectEventm_OnValueChanged  // 0x70
  public            System.Boolean                  disableScroll  // 0x78
  public            UnityEngine.UI.ScrollRect.ScrollRectEventOnScrollStart  // 0x80
  public            UnityEngine.UI.ScrollRect.ScrollRectEventOnScrollEnd  // 0x88
  private           UnityEngine.Vector2             m_PointerStartLocalCursor  // 0x90
  protected         UnityEngine.Vector2             m_ContentStartPosition  // 0x98
  private           UnityEngine.RectTransform       m_ViewRect  // 0xa0
  protected         UnityEngine.Bounds              m_ContentBounds  // 0xa8
  private           UnityEngine.Bounds              m_ViewBounds  // 0xc0
  private           UnityEngine.Vector2             m_Velocity  // 0xd8
  protected         System.Boolean                  m_Dragging  // 0xe0
  protected         System.Boolean                  m_onScrollEndCbFlag  // 0xe1
  protected         System.Boolean                  m_Scrolling  // 0xe2
  private           UnityEngine.Vector2             m_PrevPosition  // 0xe4
  private           UnityEngine.Bounds              m_PrevContentBounds  // 0xec
  private           UnityEngine.Bounds              m_PrevViewBounds  // 0x104
  private           System.Boolean                  m_HasRebuiltLayout  // 0x11c
  private           System.Boolean                  m_HSliderExpand  // 0x11d
  private           System.Boolean                  m_VSliderExpand  // 0x11e
  private           System.Single                   m_HSliderHeight  // 0x120
  private           System.Single                   m_VSliderWidth  // 0x124
  private           UnityEngine.RectTransform       m_Rect  // 0x128
  private           UnityEngine.RectTransform       m_HorizontalScrollbarRect  // 0x130
  private           UnityEngine.RectTransform       m_VerticalScrollbarRect  // 0x138
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x140
  private   readonly UnityEngine.Vector3[]           m_Corners  // 0x148
PROPERTIES:
  content  get=0x01041090  set=0x022C3A90
  horizontal  get=0x03D4EF90  set=0x03D4EFC0
  vertical  get=0x03D4F070  set=0x03D4F080
  movementType  get=0x03D4ED20  set=0x03D4EE10
  elasticity  get=0x03D56CA0  set=0x03D56CB0
  inertia  get=0x03D4F190  set=0x03D4E280
  decelerationRate  get=0x03D4EC60  set=0x03D4ECE0
  scrollSensitivity  get=0x03D4EC70  set=0x03D4ECF0
  viewport  get=0x03D4EA70  set=0x09F70F8C
  horizontalScrollbar  get=0x03D4EAF0  set=0x09F70C28
  verticalScrollbar  get=0x03D4EAA0  set=0x09F70E04
  horizontalScrollbarVisibility  get=0x03D4F050  set=0x09F70C1C
  verticalScrollbarVisibility  get=0x03D50B30  set=0x09F70DF8
  horizontalScrollbarSpacing  get=0x03D56A40  set=0x09F70C10
  verticalScrollbarSpacing  get=0x03D56C50  set=0x09F70DEC
  onValueChanged  get=0x03D4EB30  set=0x0519C3C8
  viewRect  get=0x0233DFC0
  velocity  get=0x03D89C10  set=0x03D89C30
  rectTransform  get=0x034CFD70
  normalizedPosition  get=0x028C2610  set=0x09F70DB0
  horizontalNormalizedPosition  get=0x028C2650  set=0x04274DE0
  verticalNormalizedPosition  get=0x028C27F0  set=0x04274DEC
  hScrollingNeeded  get=0x0233D230
  vScrollingNeeded  get=0x0233D2D0
  minWidth  get=0x03D751A0
  preferredWidth  get=0x03D751A0
  flexibleWidth  get=0x03D751A0
  minHeight  get=0x03D751A0
  preferredHeight  get=0x03D751A0
  flexibleHeight  get=0x03D751A0
  layoutPriority  get=0x03D5CD90
METHODS:
  RVA=0x0284A4A0  token=0x6000403  System.Void .ctor()
  RVA=0x0337CC00  token=0x6000404  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x0350B670  token=0x6000405  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x6000406  System.Void GraphicUpdateComplete()
  RVA=0x0337CE20  token=0x6000407  System.Void UpdateCachedData()
  RVA=0x034CFB80  token=0x6000408  System.Void OnEnable()
  RVA=0x034CF820  token=0x6000409  System.Void OnDisable()
  RVA=0x0363A500  token=0x600040A  System.Boolean IsActive()
  RVA=0x0233D1C0  token=0x600040B  System.Void EnsureLayoutHasRebuilt()
  RVA=0x09F70BE4  token=0x600040C  System.Void StopMovement()
  RVA=0x028C1440  token=0x600040D  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData data)
  RVA=0x09F70BF0  token=0x600040E  System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position)
  RVA=0x03B414F0  token=0x600040F  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F706BC  token=0x6000410  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F70AD8  token=0x6000411  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F707E8  token=0x6000412  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x034E5060  token=0x6000413  System.Void SetContentAnchoredPosition(UnityEngine.Vector2 position)
  RVA=0x0233C2A0  token=0x6000414  System.Void LateUpdate()
  RVA=0x0337CC60  token=0x6000415  System.Void UpdatePrevData()
  RVA=0x028C2220  token=0x6000416  System.Void UpdateScrollbars(UnityEngine.Vector2 offset)
  RVA=0x04274DE0  token=0x600041D  System.Void SetHorizontalNormalizedPosition(System.Single value)
  RVA=0x034556D0  token=0x600041E  System.Void SetVerticalNormalizedPosition(System.Single value)
  RVA=0x034556E0  token=0x600041F  System.Void SetNormalizedPosition(System.Single value, System.Int32 axis)
  RVA=0x09F70AFC  token=0x6000420  System.Single RubberDelta(System.Single overStretching, System.Single viewSize)
  RVA=0x034CFCF0  token=0x6000421  System.Void OnRectTransformDimensionsChange()
  RVA=0x0350B670  token=0x6000424  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x6000425  System.Void CalculateLayoutInputVertical()
  RVA=0x0337CD50  token=0x600042D  System.Void SetLayoutHorizontal()
  RVA=0x034DE930  token=0x600042E  System.Void SetLayoutVertical()
  RVA=0x0233D010  token=0x600042F  System.Void UpdateScrollbarVisibility()
  RVA=0x0233D070  token=0x6000430  System.Void UpdateOneScrollbarVisibility(System.Boolean xScrollingNeeded, System.Boolean xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar)
  RVA=0x034DEA90  token=0x6000431  System.Void UpdateScrollbarLayout()
  RVA=0x030C1010  token=0x6000432  System.Void UpdateScrollEnableNode()
  RVA=0x0233D790  token=0x6000433  System.Void UpdateBounds()
  RVA=0x0233D380  token=0x6000434  System.Void AdjustBounds(UnityEngine.Bounds& viewBounds, UnityEngine.Vector2& contentPivot, UnityEngine.Vector3& contentSize, UnityEngine.Vector3& contentPos)
  RVA=0x0233D580  token=0x6000435  UnityEngine.Bounds GetBounds()
  RVA=0x0238C980  token=0x6000436  UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, UnityEngine.Matrix4x4& viewWorldToLocalMatrix)
  RVA=0x0233CD20  token=0x6000437  UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta)
  RVA=0x0233CD70  token=0x6000438  UnityEngine.Vector2 InternalCalculateOffset(UnityEngine.Bounds& viewBounds, UnityEngine.Bounds& contentBounds, System.Boolean horizontal, System.Boolean vertical, UnityEngine.UI.ScrollRect.MovementType movementType, UnityEngine.Vector2& delta)
  RVA=0x034CFD00  token=0x6000439  System.Void SetDirty()
  RVA=0x09F70B44  token=0x600043A  System.Void SetDirtyCaching()
  RVA=0x04273A88  token=0x600043B  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.Selectable
TYPE:  class
TOKEN: 0x200006B
SIZE:  0x180
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IMoveHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IPointerUpHandler UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IPointerExitHandler UnityEngine.EventSystems.ISelectHandler UnityEngine.EventSystems.IDeselectHandler
FIELDS:
  protected static  UnityEngine.UI.Selectable[]     s_Selectables  // static @ 0x0
  protected static  System.Int32                    s_SelectableCount  // static @ 0x8
  private           System.Boolean                  m_EnableCalled  // 0x18
  private           UnityEngine.UI.Navigation       m_Navigation  // 0x20
  private           UnityEngine.UI.Selectable.Transitionm_Transition  // 0x48
  private           UnityEngine.UI.ColorBlock       m_Colors  // 0x4c
  private           UnityEngine.UI.SpriteState      m_SpriteState  // 0xa8
  private           UnityEngine.UI.AnimationTriggersm_AnimationTriggers  // 0xc8
  private           System.Boolean                  m_Interactable  // 0xd0
  private           UnityEngine.UI.Graphic          m_TargetGraphic  // 0xd8
  protected         System.Boolean                  m_NotifyHover  // 0xe0
  protected         UnityEngine.GameObject          m_HoverEnableNode  // 0xe8
  protected         System.String                   m_HoverAudioKey  // 0xf0
  protected         System.Boolean                  _enableUnityNavi  // 0xf8
  private           System.Boolean                  m_GroupsAllowInteraction  // 0xf9
  protected         System.Int32                    m_CurrentIndex  // 0xfc
  private           System.Boolean                  <isPointerInside>k__BackingField  // 0x100
  private           System.Boolean                  <isPointerDown>k__BackingField  // 0x101
  private           System.Boolean                  <hasSelection>k__BackingField  // 0x102
  private   readonly System.Collections.Generic.List<UnityEngine.CanvasGroup>m_CanvasGroupCache  // 0x108
  public    static  UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable,System.Boolean>onAnyHoverChange  // static @ 0x10
  private   readonly UnityEngine.Events.UnityEvent<System.Boolean><onHoverChange>k__BackingField  // 0x110
  public            System.Boolean                  enableControllerNavi  // 0x118
  public            UnityEngine.Transform           overrideNaviHintRectTransform  // 0x120
  public            System.Single                   overrideNaviHintRectScale  // 0x128
  public            System.Boolean                  changeNaviHintParent  // 0x12c
  public            System.Boolean                  hideNaviHint  // 0x12d
  public            System.Boolean                  needNaviConfirmKeyHint  // 0x12e
  public            System.Boolean                  useExplicitNaviSelect  // 0x12f
  public            System.Boolean                  banExplicitOnLeft  // 0x130
  public            System.Boolean                  banExplicitOnRight  // 0x131
  public            System.Boolean                  banExplicitOnUp  // 0x132
  public            System.Boolean                  banExplicitOnDown  // 0x133
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnLeft  // 0x138
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnRight  // 0x140
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnUp  // 0x148
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnDown  // 0x150
  private           System.Boolean                  <isNaviTarget>k__BackingField  // 0x158
  public            System.Action<System.Boolean,System.Boolean,System.Boolean>onIsNaviTargetChanged  // 0x160
  private           System.Boolean                  <isNavigationSilent>k__BackingField  // 0x168
  public            UnityEngine.UI.SelectableNaviGroupnaviGroup  // 0x170
  private           System.Boolean                  m_naviInited  // 0x178
PROPERTIES:
  allSelectablesArray  get=0x09F72F38
  allSelectableCount  get=0x09F72EE8
  allSelectables  get=0x09F72FBC
  hoverAudioKey  get=0x03D51950
  navigation  get=0x03D581B0  set=0x02C70710
  transition  get=0x03D4EC50  set=0x09F73250
  colors  get=0x03D89C50  set=0x09F730E8
  spriteState  get=0x03D89C90  set=0x09F73184
  animationTriggers  get=0x03D4E7C0  set=0x09F7308C
  targetGraphic  get=0x03D4E7B0  set=0x09F731F4
  interactable  get=0x03D58E40  set=0x02C3BC20
  isPointerInside  get=0x03D56750  set=0x03D89CC0
  isPointerDown  get=0x03D75780  set=0x03D89CB0
  hasSelection  get=0x03D554B0  set=0x03D554E0
  image  get=0x09F7304C  set=0x05142FC4
  animator  get=0x022B3BD0
  currentSelectionState  get=0x022B2B40
  onHoverChange  get=0x03D56CF0
  isNaviTarget  get=0x03D5AC60  set=0x03D5AC70
  isNavigationSilent  get=0x03D5BC50  set=0x03D5BCA0
METHODS:
  RVA=0x09F71D24  token=0x6000440  System.Int32 AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables)
  RVA=0x028488B0  token=0x6000456  System.Void .ctor()
  RVA=0x02C705D0  token=0x600045A  System.Void Awake()
  RVA=0x0251CA00  token=0x600045B  System.Void OnCanvasGroupChanged()
  RVA=0x022B2B90  token=0x600045C  System.Boolean IsInteractable()
  RVA=0x09F72930  token=0x600045D  System.Void OnDidApplyAnimationProperties()
  RVA=0x022B1BA0  token=0x600045E  System.Void OnEnable()
  RVA=0x039DD000  token=0x600045F  System.Void OnTransformParentChanged()
  RVA=0x036E62D0  token=0x6000460  System.Void OnSetProperty()
  RVA=0x022B2BB0  token=0x6000461  System.Void OnDisable()
  RVA=0x022B3C50  token=0x6000462  System.Void OnApplicationFocus(System.Boolean hasFocus)
  RVA=0x022B30D0  token=0x6000464  System.Void InstantClearState()
  RVA=0x022B2E50  token=0x6000465  System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant)
  RVA=0x09F7211C  token=0x6000466  UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir)
  RVA=0x09F7267C  token=0x6000467  UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir)
  RVA=0x09F728A0  token=0x6000468  System.Void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel)
  RVA=0x09F71F0C  token=0x6000469  UnityEngine.UI.Selectable FindSelectableOnLeft()
  RVA=0x09F71FBC  token=0x600046A  UnityEngine.UI.Selectable FindSelectableOnRight()
  RVA=0x09F7206C  token=0x600046B  UnityEngine.UI.Selectable FindSelectableOnUp()
  RVA=0x09F71E5C  token=0x600046C  UnityEngine.UI.Selectable FindSelectableOnDown()
  RVA=0x09F72938  token=0x600046D  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  RVA=0x022B31B0  token=0x600046E  System.Void StartColorTween(UnityEngine.Color targetColor, System.Boolean instant)
  RVA=0x09F71DCC  token=0x600046F  System.Void DoSpriteSwap(UnityEngine.Sprite newSprite)
  RVA=0x022B39D0  token=0x6000470  System.Void TriggerAnimation(System.String triggername)
  RVA=0x09F72850  token=0x6000471  System.Boolean IsHighlighted()
  RVA=0x022B3C80  token=0x6000472  System.Boolean IsPressed()
  RVA=0x022B4090  token=0x6000473  System.Void EvaluateAndTransitionToSelectionState()
  RVA=0x0284C830  token=0x6000474  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0284C800  token=0x6000475  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x022B4B20  token=0x6000476  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x022B4C20  token=0x6000477  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x03CDD160  token=0x6000478  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x03CBABA0  token=0x6000479  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F72A14  token=0x600047A  System.Void Select()
  RVA=0x024B2200  token=0x600047B  System.Void _RefreshHoverEnableNode(System.Boolean active)
  RVA=0x0350B670  token=0x600047C  System.Void OnInteractableChanged()
  RVA=0x02C6F620  token=0x600047E  System.Void _NotifyIsHover(System.Boolean isHover)
  RVA=0x02C71AF0  token=0x600047F  System.Void OnDestroy()
  RVA=0x09F72654  token=0x6000480  System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId)
  RVA=0x09F72AE0  token=0x6000485  System.Void SetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode, System.Boolean isGroupChanged)
  RVA=0x09F729A8  token=0x6000486  System.Void OnNaviTargetEnabledAgain()
  RVA=0x0350B670  token=0x6000487  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  RVA=0x02C70790  token=0x6000488  System.Void TryFindNaviGroup()
  RVA=0x09F725DC  token=0x6000489  UnityEngine.UI.SelectableNaviGroup GetLayerGroup()
  RVA=0x09F72C88  token=0x600048A  System.Boolean TryFindExplicitNaviTarget(UnityEngine.UI.NaviDirection dir, UnityEngine.UI.Selectable& target)
  RVA=0x09F72E10  token=0x600048B  System.Boolean banExplicitNavi(UnityEngine.UI.NaviDirection dir)
  RVA=0x022B2D90  token=0x600048C  System.Void _TryRegisterOnNaviGroup()
  RVA=0x02C71B30  token=0x600048D  System.Void _TryUnRegisterOnNaviGroup()
  RVA=0x04275CE0  token=0x600048E  System.Void SetExplicitSelectOnLeft(UnityEngine.UI.Selectable selectable)
  RVA=0x058B3FD8  token=0x600048F  System.Void SetExplicitSelectOnRight(UnityEngine.UI.Selectable selectable)
  RVA=0x058B3DA8  token=0x6000490  System.Void SetExplicitSelectOnUp(UnityEngine.UI.Selectable selectable)
  RVA=0x058B3DD0  token=0x6000491  System.Void SetExplicitSelectOnDown(UnityEngine.UI.Selectable selectable)
  RVA=0x09F72C28  token=0x6000492  System.Void SetExplicitSelect(UnityEngine.UI.Selectable left, UnityEngine.UI.Selectable right, UnityEngine.UI.Selectable up, UnityEngine.UI.Selectable down)
  RVA=0x03C84DD0  token=0x6000493  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.NaviDirection
TYPE:  sealed struct
TOKEN: 0x200006E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.NaviDirection    None  // const
  public    static  UnityEngine.UI.NaviDirection    Up  // const
  public    static  UnityEngine.UI.NaviDirection    Down  // const
  public    static  UnityEngine.UI.NaviDirection    Left  // const
  public    static  UnityEngine.UI.NaviDirection    Right  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UI.NaviStrategy
TYPE:  sealed struct
TOKEN: 0x200006F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.NaviStrategy     Normal  // const
  public    static  UnityEngine.UI.NaviStrategy     Strict  // const
  public    static  UnityEngine.UI.NaviStrategy     NotInternalFirst  // const
  public    static  UnityEngine.UI.NaviStrategy     VerticalOnlyWithInternalWrap  // const
  public    static  UnityEngine.UI.NaviStrategy     HorizontalOnlyWithInternalWrap  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UI.NavigationBindingType
TYPE:  sealed struct
TOKEN: 0x2000070
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.NavigationBindingTypeInValid  // const
  public    static  UnityEngine.UI.NavigationBindingTypeAllDirections  // const
  public    static  UnityEngine.UI.NavigationBindingTypeHorizontalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeVerticalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeArrowAllDirections  // const
  public    static  UnityEngine.UI.NavigationBindingTypeArrowHorizontalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeArrowVerticalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsAllDirections  // const
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsHorizontalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsVerticalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsOnlyAllDirections  // const
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsOnlyHorizontalOnly  // const
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsOnlyVerticalOnly  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UI.SelectableNaviGroup
TYPE:  abstract class
TOKEN: 0x2000071
SIZE:  0xA0
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  isIsolate  // 0x18
  public            System.Boolean                  isLayer  // 0x19
  public            System.Boolean                  removeLayerOnDisable  // 0x1a
  public            UnityEngine.UI.SelectableNaviGroupparentNaviGroup  // 0x20
  public            UnityEngine.UI.NaviStrategy     internalNaviStrategy  // 0x28
  public            UnityEngine.UI.NavigationBindingTypenavigationBindingType  // 0x2c
  public            System.Boolean                  enablePartner  // 0x30
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnUp  // 0x38
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnDown  // 0x40
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnLeft  // 0x48
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnRight  // 0x50
  protected         System.Boolean                  m_inited  // 0x58
  protected         UnityEngine.UI.Selectable       m_layerSelectedTarget  // 0x60
  public            System.Collections.Generic.HashSet<UnityEngine.UI.Selectable>targets  // 0x68
  public            System.Collections.Generic.HashSet<UnityEngine.UI.SelectableNaviGroup>subGroups  // 0x70
  public            UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable>onSetLayerSelectedTarget  // 0x78
  public            UnityEngine.Events.UnityEvent<System.Boolean>onIsTopLayerChanged  // 0x80
  public            UnityEngine.Events.UnityEvent<UnityEngine.UI.NaviDirection>onDefaultNaviFailed  // 0x88
  public            UnityEngine.Events.UnityEvent   onRemoveFromLayerStack  // 0x90
  protected         System.Boolean                  m_isTopLayer  // 0x98
PROPERTIES:
  LayerSelectedTarget  get=0x02C707E0
  IsTopLayer  get=0x03D58690  set=0x09F71D0C
METHODS:
  RVA=0x09F71D04  token=0x6000495  System.Void Reset()
  RVA=0x02C6F9C0  token=0x6000496  System.Void OnEnable()
  RVA=0x04272FC0  token=0x6000497  System.Void OnDisable()
  RVA=0x0304D760  token=0x6000498  System.Void OnDestroy()
  RVA=0x02C6FB50  token=0x6000499  System.Void _Init()
  RVA=0x02C70280  token=0x600049A  System.Void TryFindParentNaviGroup()
  RVA=0x02C700D0  token=0x600049B  UnityEngine.UI.SelectableNaviGroup GetLayerGroup()
  RVA=0x02C6FF20  token=0x600049E  System.Void SetLayerSelectedTarget(UnityEngine.UI.Selectable value, System.Boolean silentMode)
  RVA=0x02C70250  token=0x600049F  System.Void OnRemoveFromLayerStack()
  RVA=0x02C6F090  token=0x60004A0  System.Void _OnIsTopLayerChanged()
  RVA=0x0350B670  token=0x60004A1  System.Void _OnSelectableNaviGroupInited()
  RVA=0x0350B670  token=0x60004A2  System.Void _BeforeSelectableNaviGroupDestroy()
  RVA=0x0350B670  token=0x60004A3  System.Void _OnSelectableNaviGroupDisabled()
  RVA=0x0350B670  token=0x60004A4  System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value)
  RVA=0x0350B670  token=0x60004A5  System.Void _OnRemoveFromLayerStack()
  RVA=0x0283A100  token=0x60004A6  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.SetPropertyUtility
TYPE:  static class
TOKEN: 0x2000072
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x025C1E90  token=0x60004A7  System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue)
  RVA=-1  // generic def  token=0x60004A8  System.Boolean SetStruct(T& currentValue, T newValue)
  RVA=-1  // generic def  token=0x60004A9  System.Boolean SetClass(T& currentValue, T newValue)
END_CLASS

CLASS: UnityEngine.UI.Slider
TYPE:  class
TOKEN: 0x2000073
SIZE:  0x1E8
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IInitializePotentialDragHandler UnityEngine.UI.ICanvasElement
FIELDS:
  private           UnityEngine.RectTransform       m_FillRect  // 0x180
  private           UnityEngine.RectTransform       m_HandleRect  // 0x188
  private           UnityEngine.UI.Slider.Direction m_Direction  // 0x190
  private           System.Single                   m_MinValue  // 0x194
  private           System.Single                   m_MaxValue  // 0x198
  private           System.Boolean                  m_WholeNumbers  // 0x19c
  protected         System.Single                   m_Value  // 0x1a0
  private           UnityEngine.UI.Slider.SliderEventm_OnValueChanged  // 0x1a8
  private           UnityEngine.UI.Image            m_FillImage  // 0x1b0
  private           UnityEngine.Transform           m_FillTransform  // 0x1b8
  private           UnityEngine.RectTransform       m_FillContainerRect  // 0x1c0
  private           UnityEngine.Transform           m_HandleTransform  // 0x1c8
  private           UnityEngine.RectTransform       m_HandleContainerRect  // 0x1d0
  private           UnityEngine.Vector2             m_Offset  // 0x1d8
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x1e0
  private           System.Boolean                  m_DelayedUpdateVisuals  // 0x1e1
PROPERTIES:
  fillRect  get=0x03D56B50  set=0x09F73DDC
  handleRect  get=0x03D56AF0  set=0x09F73E44
  direction  get=0x03D760B0  set=0x09F73D80
  minValue  get=0x03D58B50  set=0x03B72620
  maxValue  get=0x03D583C0  set=0x03B727B0
  wholeNumbers  get=0x03D5B0C0  set=0x09F73EDC
  value  get=0x027E8BB0  set=0x042725E4
  normalizedValue  get=0x027E8B40  set=0x09F73EAC
  onValueChanged  get=0x03D57170  set=0x04275BE8
  stepSize  get=0x09F73D54
  axis  get=0x027E87F0
  reverseValue  get=0x027E7CA0
METHODS:
  RVA=0x09F73B18  token=0x60004B8  System.Void SetValueWithoutNotify(System.Single input)
  RVA=0x02848250  token=0x60004BE  System.Void .ctor()
  RVA=0x0350B670  token=0x60004BF  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x0350B670  token=0x60004C0  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x60004C1  System.Void GraphicUpdateComplete()
  RVA=0x02529580  token=0x60004C2  System.Void OnEnable()
  RVA=0x0361D5F0  token=0x60004C3  System.Void OnDisable()
  RVA=0x02394050  token=0x60004C4  System.Void Update()
  RVA=0x09F733AC  token=0x60004C5  System.Void OnDidApplyAnimationProperties()
  RVA=0x025295C0  token=0x60004C6  System.Void UpdateCachedReferences()
  RVA=0x09F732A8  token=0x60004C7  System.Single ClampValue(System.Single input)
  RVA=0x0272C470  token=0x60004C8  System.Void Set(System.Single input, System.Boolean sendCallback)
  RVA=0x0350B670  token=0x60004C9  System.Void OnValueChanged()
  RVA=0x0350B670  token=0x60004CA  System.Void OnClickSliderBar()
  RVA=0x0350B670  token=0x60004CB  System.Void OnClickSliderHandle()
  RVA=0x036ABA40  token=0x60004CC  System.Void OnRectTransformDimensionsChange()
  RVA=0x027E8810  token=0x60004CF  System.Void UpdateVisuals()
  RVA=0x09F73B24  token=0x60004D0  System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam)
  RVA=0x03D65EB0  token=0x60004D1  System.Single CustomProcessNormalizedValue(System.Single val)
  RVA=0x09F711F4  token=0x60004D2  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F73800  token=0x60004D3  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F735C8  token=0x60004D4  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F73618  token=0x60004D5  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  RVA=0x09F73310  token=0x60004D6  UnityEngine.UI.Selectable FindSelectableOnLeft()
  RVA=0x09F73344  token=0x60004D7  UnityEngine.UI.Selectable FindSelectableOnRight()
  RVA=0x09F73378  token=0x60004D8  UnityEngine.UI.Selectable FindSelectableOnUp()
  RVA=0x09F732DC  token=0x60004D9  UnityEngine.UI.Selectable FindSelectableOnDown()
  RVA=0x09F714E0  token=0x60004DA  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F739DC  token=0x60004DB  System.Void SetDirection(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts)
  RVA=0x04273A88  token=0x60004DC  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.SpriteState
TYPE:  sealed struct
TOKEN: 0x2000077
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.Sprite              m_HighlightedSprite  // 0x10
  private           UnityEngine.Sprite              m_PressedSprite  // 0x18
  private           UnityEngine.Sprite              m_SelectedSprite  // 0x20
  private           UnityEngine.Sprite              m_DisabledSprite  // 0x28
PROPERTIES:
  highlightedSprite  get=0x020C61B0  set=0x042715A0
  pressedSprite  get=0x03D50DE0  set=0x0558FF08
  selectedSprite  get=0x020B7B20  set=0x0426FEE0
  disabledSprite  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09F73F50  token=0x60004E6  System.Boolean Equals(UnityEngine.UI.SpriteState other)
END_CLASS

CLASS: UnityEngine.UI.StencilMaterial
TYPE:  static class
TOKEN: 0x2000078
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry>m_List  // static @ 0x0
  private   static  System.Boolean                  s_EnableStencilMaterialWarning  // static @ 0x8
METHODS:
  RVA=0x01002730  token=0x60004E7  UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID)
  RVA=0x02516830  token=0x60004E8  UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask)
  RVA=0x09F74130  token=0x60004E9  System.Void LogWarningWhenNotInBatchmode(System.String warning, UnityEngine.Object context)
  RVA=0x028006E0  token=0x60004EA  UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, System.Int32 readMask, System.Int32 writeMask)
  RVA=0x0239F570  token=0x60004EB  System.Void Remove(UnityEngine.Material customMat)
  RVA=0x09F7401C  token=0x60004EC  System.Void ClearAll()
  RVA=0x03CBCE10  token=0x60004ED  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.Text
TYPE:  class
TOKEN: 0x200007A
SIZE:  0x118
EXTENDS: UnityEngine.UI.MaskableGraphic
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  private           UnityEngine.UI.FontData         m_FontData  // 0xe8
  protected         System.String                   m_Text  // 0xf0
  private           UnityEngine.TextGenerator       m_TextCache  // 0xf8
  private           UnityEngine.TextGenerator       m_TextCacheForLayout  // 0x100
  protected static  UnityEngine.Material            s_DefaultText  // static @ 0x0
  protected         System.Boolean                  m_DisableFontTextureRebuiltCallback  // 0x108
  private   readonly UnityEngine.UIVertex[]          m_TempVerts  // 0x110
PROPERTIES:
  cachedTextGenerator  get=0x09F74E44
  cachedTextGeneratorForLayout  get=0x09F74DC8
  mainTexture  get=0x09F74F98
  font  get=0x09F74F38  set=0x09F7561C
  text  get=0x03D51950  set=0x09F758B0
  supportRichText  get=0x09F754D4  set=0x09F7586C
  resizeTextForBestFit  get=0x09F75474  set=0x09F757A0
  resizeTextMinSize  get=0x09F754B4  set=0x09F75828
  resizeTextMaxSize  get=0x09F75494  set=0x09F757E4
  alignment  get=0x09F74DA8  set=0x09F75550
  alignByGeometry  get=0x09F74D88  set=0x09F75514
  fontSize  get=0x09F74EF8  set=0x09F75594
  horizontalOverflow  get=0x09F74F58  set=0x09F75710
  verticalOverflow  get=0x09F754F4  set=0x09F7597C
  lineSpacing  get=0x09F74F78  set=0x09F75754
  fontStyle  get=0x09F74F18  set=0x09F755D8
  pixelsPerUnit  get=0x09F75120
  minWidth  get=0x03D503F0
  preferredWidth  get=0x09F75384
  flexibleWidth  get=0x03D751A0
  minHeight  get=0x03D503F0
  preferredHeight  get=0x09F7525C
  flexibleHeight  get=0x03D751A0
  layoutPriority  get=0x01002730
METHODS:
  RVA=0x09F74CDC  token=0x60004EF  System.Void .ctor()
  RVA=0x09F742A8  token=0x60004F3  System.Void FontTextureChanged()
  RVA=0x09F74654  token=0x600050F  System.Void OnEnable()
  RVA=0x09F74608  token=0x6000510  System.Void OnDisable()
  RVA=0x09F74C74  token=0x6000511  System.Void UpdateGeometry()
  RVA=0x09F74250  token=0x6000512  System.Void AssignDefaultFont()
  RVA=0x09F741B8  token=0x6000513  System.Void AssignDefaultFontIfNecessary()
  RVA=0x09F74370  token=0x6000514  UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents)
  RVA=0x09F7457C  token=0x6000515  UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor)
  RVA=0x09F746BC  token=0x6000516  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
  RVA=0x0350B670  token=0x6000517  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x6000518  System.Void CalculateLayoutInputVertical()
END_CLASS

CLASS: UnityEngine.UI.Toggle
TYPE:  class
TOKEN: 0x200007B
SIZE:  0x1A8
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.UI.ICanvasElement
FIELDS:
  public            UnityEngine.UI.Toggle.ToggleTransitiontoggleTransition  // 0x180
  public            UnityEngine.UI.Graphic          graphic  // 0x188
  private           UnityEngine.UI.ToggleGroup      m_Group  // 0x190
  public            UnityEngine.UI.Toggle.ToggleEventonValueChanged  // 0x198
  private           System.Boolean                  m_IsOn  // 0x1a0
PROPERTIES:
  group  get=0x03D56B70  set=0x09F75C78
  isOn  get=0x03D57C40  set=0x02C6BE20
METHODS:
  RVA=0x02848160  token=0x6000522  System.Void .ctor()
  RVA=0x0350B670  token=0x6000523  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  RVA=0x0350B670  token=0x6000524  System.Void LayoutComplete()
  RVA=0x0350B670  token=0x6000525  System.Void GraphicUpdateComplete()
  RVA=0x09F75B08  token=0x6000526  System.Void OnDestroy()
  RVA=0x02C6C100  token=0x6000527  System.Void OnEnable()
  RVA=0x02C6C070  token=0x6000528  System.Void OnDisable()
  RVA=0x09F75B84  token=0x6000529  System.Void OnDidApplyAnimationProperties()
  RVA=0x02C6C2F0  token=0x600052A  System.Void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, System.Boolean setMemberValue)
  RVA=0x04276904  token=0x600052D  System.Void SetIsOnWithoutNotify(System.Boolean value)
  RVA=0x02C6BE30  token=0x600052E  System.Void Set(System.Boolean value, System.Boolean sendCallback)
  RVA=0x02C6C140  token=0x600052F  System.Void PlayEffect(System.Boolean instant)
  RVA=0x04272FA8  token=0x6000530  System.Void Start()
  RVA=0x02C6ACA0  token=0x6000531  System.Void InternalToggle()
  RVA=0x09F75C44  token=0x6000532  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0968FA40  token=0x6000533  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x0350B670  token=0x6000534  System.Void OnValueChange()
  RVA=0x04273A88  token=0x6000535  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.ToggleGroup
TYPE:  class
TOKEN: 0x200007E
SIZE:  0x28
EXTENDS: UnityEngine.EventSystems.UIBehaviour
FIELDS:
  private           System.Boolean                  m_AllowSwitchOff  // 0x18
  protected         System.Collections.Generic.List<UnityEngine.UI.Toggle>m_Toggles  // 0x20
PROPERTIES:
  allowSwitchOff  get=0x01002A50  set=0x01002B40
METHODS:
  RVA=0x03726C20  token=0x6000539  System.Void .ctor()
  RVA=0x02C6AE20  token=0x600053A  System.Void Start()
  RVA=0x02C6AE20  token=0x600053B  System.Void OnEnable()
  RVA=0x02C6AF20  token=0x600053C  System.Void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle)
  RVA=0x02C6AE30  token=0x600053D  System.Void NotifyToggleOn(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback)
  RVA=0x02C6C460  token=0x600053E  System.Void UnregisterToggle(UnityEngine.UI.Toggle toggle)
  RVA=0x02C6BFB0  token=0x600053F  System.Void RegisterToggle(UnityEngine.UI.Toggle toggle)
  RVA=0x02C6AFD0  token=0x6000540  System.Void EnsureValidState()
  RVA=0x02C6B420  token=0x6000541  System.Boolean AnyTogglesOn()
  RVA=0x02C6B2E0  token=0x6000542  System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles()
  RVA=0x09F759C0  token=0x6000543  UnityEngine.UI.Toggle GetFirstActiveToggle()
  RVA=0x09F75A30  token=0x6000544  System.Void SetAllTogglesOff(System.Boolean sendCallback)
END_CLASS

CLASS: UnityEngine.UI.ReflectionMethodsCache
TYPE:  class
TOKEN: 0x2000080
SIZE:  0x40
FIELDS:
  public            UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallbackraycast3D  // 0x10
  public            UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallbackraycast3DAll  // 0x18
  public            UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallbackgetRaycastNonAlloc  // 0x20
  public            UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallbackraycast2D  // 0x28
  public            UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallbackgetRayIntersectionAll  // 0x30
  public            UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallbackgetRayIntersectionAllNonAlloc  // 0x38
  private   static  UnityEngine.UI.ReflectionMethodsCaches_ReflectionMethodsCache  // static @ 0x0
PROPERTIES:
  Singleton  get=0x09F7062C
METHODS:
  RVA=0x09F6FB70  token=0x6000549  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.VertexHelper
TYPE:  class
TOKEN: 0x2000087
SIZE:  0x60
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Vector3>m_Positions  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Color32>m_Colors  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv0S  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv1S  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv2S  // 0x30
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv3S  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Vector3>m_Normals  // 0x40
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Tangents  // 0x48
  private           System.Collections.Generic.List<System.Int32>m_Indices  // 0x50
  private   static readonly UnityEngine.Vector4             s_DefaultTangent  // static @ 0x0
  private   static readonly UnityEngine.Vector3             s_DefaultNormal  // static @ 0x10
  private           System.Boolean                  m_ListsInitalized  // 0x58
PROPERTIES:
  currentVertCount  get=0x025A39D0
  currentIndexCount  get=0x09F76800
METHODS:
  RVA=0x0350B670  token=0x6000563  System.Void .ctor()
  RVA=0x09F765C8  token=0x6000564  System.Void .ctor(UnityEngine.Mesh m)
  RVA=0x025A6CE0  token=0x6000565  System.Void InitializeListIfRequired()
  RVA=0x036D4C20  token=0x6000566  System.Void Dispose()
  RVA=0x02337B50  token=0x6000567  System.Void Clear()
  RVA=0x09F760C4  token=0x600056A  System.Void PopulateUIVertex(UnityEngine.UIVertex& vertex, System.Int32 i)
  RVA=0x09F76280  token=0x600056B  System.Void SetUIVertex(UnityEngine.UIVertex vertex, System.Int32 i)
  RVA=0x025A84D0  token=0x600056C  System.Void FillMesh(UnityEngine.Mesh mesh)
  RVA=0x025A6590  token=0x600056D  System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent)
  RVA=0x025A5E30  token=0x600056E  System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent)
  RVA=0x025A5670  token=0x600056F  System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0)
  RVA=0x036A4D70  token=0x6000570  System.Void AddVert(UnityEngine.UIVertex v)
  RVA=0x025A52A0  token=0x6000571  System.Void AddTriangle(System.Int32 idx0, System.Int32 idx1, System.Int32 idx2)
  RVA=0x02CDBCF0  token=0x6000572  System.Void AddUIVertexQuad(UnityEngine.UIVertex[] verts)
  RVA=0x09F75F14  token=0x6000573  System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices)
  RVA=0x09F75FD4  token=0x6000574  System.Void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
  RVA=0x09F7604C  token=0x6000575  System.Void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream)
  RVA=0x0398BF50  token=0x6000576  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.BaseVertexEffect
TYPE:  abstract class
TOKEN: 0x2000088
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000577  System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)
  RVA=0x0350B670  token=0x6000578  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.BaseMeshEffect
TYPE:  abstract class
TOKEN: 0x2000089
SIZE:  0x20
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.IMeshModifier
FIELDS:
  private           UnityEngine.UI.Graphic          m_Graphic  // 0x18
PROPERTIES:
  graphic  get=0x09F77908
METHODS:
  RVA=0x09F77888  token=0x600057A  System.Void OnEnable()
  RVA=0x09F77808  token=0x600057B  System.Void OnDisable()
  RVA=0x09F77788  token=0x600057C  System.Void OnDidApplyAnimationProperties()
  RVA=0x09F77684  token=0x600057D  System.Void ModifyMesh(UnityEngine.Mesh mesh)
  RVA=-1  // abstract  token=0x600057E  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
  RVA=0x0426FE60  token=0x600057F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.IVertexModifier
TYPE:  interface
TOKEN: 0x200008A
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000580  System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
END_CLASS

CLASS: UnityEngine.UI.IMeshModifier
TYPE:  interface
TOKEN: 0x200008B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000581  System.Void ModifyMesh(UnityEngine.Mesh mesh)
  RVA=-1  // abstract  token=0x6000582  System.Void ModifyMesh(UnityEngine.UI.VertexHelper verts)
END_CLASS

CLASS: UnityEngine.UI.Outline
TYPE:  class
TOKEN: 0x200008C
SIZE:  0x40
EXTENDS: UnityEngine.UI.Shadow
FIELDS:
METHODS:
  RVA=0x09F79564  token=0x6000583  System.Void .ctor()
  RVA=0x09F792CC  token=0x6000584  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
END_CLASS

CLASS: UnityEngine.UI.PositionAsUV1
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x20
EXTENDS: UnityEngine.UI.BaseMeshEffect
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x6000585  System.Void .ctor()
  RVA=0x09F7E390  token=0x6000586  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
END_CLASS

CLASS: UnityEngine.UI.Shadow
TYPE:  class
TOKEN: 0x200008E
SIZE:  0x40
EXTENDS: UnityEngine.UI.BaseMeshEffect
FIELDS:
  private           UnityEngine.Color               m_EffectColor  // 0x20
  private           UnityEngine.Vector2             m_EffectDistance  // 0x30
  private           System.Boolean                  m_UseGraphicAlpha  // 0x38
  private   static  System.Single                   kMaxEffectDistance  // const
PROPERTIES:
  effectColor  get=0x03D54E00  set=0x09F7F6BC
  effectDistance  get=0x03D69670  set=0x09F7F748
  useGraphicAlpha  get=0x03D4F190  set=0x09F7F84C
METHODS:
  RVA=0x03D474D0  token=0x6000587  System.Void .ctor()
  RVA=0x09F7F308  token=0x600058E  System.Void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y)
  RVA=0x09F7F584  token=0x600058F  System.Void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y)
  RVA=0x09F7F594  token=0x6000590  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
END_CLASS

CLASS: UnityEngine.UI.Collections.IndexedSet`1
TYPE:  class
TOKEN: 0x200008F
IMPLEMENTS: System.Collections.Generic.IList`1 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly System.Collections.Generic.List<T>m_List  // 0x0
  private           System.Collections.Generic.Dictionary<T,System.Int32>m_Dictionary  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000591  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000592  System.Boolean AddUnique(T item)
  RVA=-1  // not resolved  token=0x6000593  System.Boolean Remove(T item)
  RVA=-1  // not resolved  token=0x6000594  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000595  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000596  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000597  System.Boolean Contains(T item)
  RVA=-1  // not resolved  token=0x6000598  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x600059B  System.Int32 IndexOf(T item)
  RVA=-1  // not resolved  token=0x600059C  System.Void Insert(System.Int32 index, T item)
  RVA=-1  // not resolved  token=0x600059D  System.Void RemoveAt(System.Int32 index)
  RVA=-1  // not resolved  token=0x60005A0  System.Void RemoveAll(System.Predicate<T> match)
  RVA=-1  // not resolved  token=0x60005A1  System.Void Sort(System.Comparison<T> sortLayoutFunction)
  RVA=-1  // not resolved  token=0x60005A2  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.ITweenValue
TYPE:  interface
TOKEN: 0x2000090
FIELDS:
PROPERTIES:
  ignoreTimeScale  get=-1  // abstract
  duration  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60005A3  System.Void TweenValue(System.Single floatPercentage)
  RVA=-1  // abstract  token=0x60005A6  System.Boolean ValidTarget()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.ColorTween
TYPE:  sealed struct
TOKEN: 0x2000091
SIZE:  0x48
IMPLEMENTS: UnityEngine.UI.CoroutineTween.ITweenValue
FIELDS:
  private           UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallbackm_Target  // 0x10
  private           UnityEngine.Color               m_StartColor  // 0x18
  private           UnityEngine.Color               m_TargetColor  // 0x28
  private           UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModem_TweenMode  // 0x38
  private           System.Single                   m_Duration  // 0x3c
  private           System.Boolean                  m_IgnoreTimeScale  // 0x40
PROPERTIES:
  startColor  get=0x020C61C0  set=0x03D707A0
  targetColor  get=0x03D51D80  set=0x03D51D90
  tweenMode  get=0x03D4EB90  set=0x03D4EBA0
  duration  get=0x03D4F3A0  set=0x03D4F3B0
  ignoreTimeScale  get=0x03D4EF60  set=0x03D4EF70
METHODS:
  RVA=0x0317A040  token=0x60005B1  System.Void TweenValue(System.Single floatPercentage)
  RVA=0x024A3EA0  token=0x60005B2  System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback)
  RVA=0x03D4EF60  token=0x60005B3  System.Boolean GetIgnoreTimescale()
  RVA=0x03D4F3A0  token=0x60005B4  System.Single GetDuration()
  RVA=0x0317A1F0  token=0x60005B5  System.Boolean ValidTarget()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.FloatTween
TYPE:  sealed struct
TOKEN: 0x2000094
SIZE:  0x28
IMPLEMENTS: UnityEngine.UI.CoroutineTween.ITweenValue
FIELDS:
  private           UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallbackm_Target  // 0x10
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
  RVA=0x09F78F28  token=0x60005BF  System.Void TweenValue(System.Single floatPercentage)
  RVA=0x09F78E90  token=0x60005C0  System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback)
  RVA=0x03D58C00  token=0x60005C1  System.Boolean GetIgnoreTimescale()
  RVA=0x03D4E7A0  token=0x60005C2  System.Single GetDuration()
  RVA=0x022B4F90  token=0x60005C3  System.Boolean ValidTarget()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.TweenRunner`1
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  protected         UnityEngine.MonoBehaviour       m_CoroutineContainer  // 0x0
  protected         System.Collections.IEnumerator  m_Tween  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60005C5  System.Collections.IEnumerator Start(T tweenInfo)
  RVA=-1  // not resolved  token=0x60005C6  System.Void Init(UnityEngine.MonoBehaviour coroutineContainer)
  RVA=-1  // not resolved  token=0x60005C7  System.Void StartTween(T info)
  RVA=-1  // not resolved  token=0x60005C8  System.Void StopTween()
  RVA=-1  // not resolved  token=0x60005C9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelEventHandler
TYPE:  class
TOKEN: 0x2000098
SIZE:  0x38
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerMoveHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerUpHandler UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.ISubmitHandler UnityEngine.EventSystems.ICancelHandler UnityEngine.EventSystems.IMoveHandler UnityEngine.EventSystems.IScrollHandler UnityEngine.EventSystems.ISelectHandler UnityEngine.EventSystems.IDeselectHandler UnityEngine.EventSystems.IPointerExitHandler UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.UIElements.IRuntimePanelComponent
FIELDS:
  private           UnityEngine.UIElements.BaseRuntimePanelm_Panel  // 0x18
  private   readonly UnityEngine.UIElements.PanelEventHandler.PointerEventm_PointerEvent  // 0x20
  private           System.Boolean                  m_Selecting  // 0x28
  private           UnityEngine.Event               m_Event  // 0x30
  private   static  UnityEngine.EventModifiers      s_Modifiers  // static @ 0x0
PROPERTIES:
  panel  get=0x01041090  set=0x09F7AED0
  selectableGameObject  get=0x09F7AEBC
  eventSystem  get=0x09F7AE6C
METHODS:
  RVA=0x09F796F4  token=0x60005D4  System.Void OnEnable()
  RVA=0x09F79658  token=0x60005D5  System.Void OnDisable()
  RVA=0x09F7A5A8  token=0x60005D6  System.Void RegisterCallbacks()
  RVA=0x09F7AB6C  token=0x60005D7  System.Void UnregisterCallbacks()
  RVA=0x09F797D8  token=0x60005D8  System.Void OnPanelDestroyed()
  RVA=0x09F79660  token=0x60005D9  System.Void OnElementFocus(UnityEngine.UIElements.FocusEvent e)
  RVA=0x0350B670  token=0x60005DA  System.Void OnElementBlur(UnityEngine.UIElements.BlurEvent e)
  RVA=0x09F79FD8  token=0x60005DB  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F79644  token=0x60005DC  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F79C58  token=0x60005DD  System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F79D44  token=0x60005DE  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F797E4  token=0x60005DF  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F79A1C  token=0x60005E0  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F799A8  token=0x60005E1  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7A070  token=0x60005E2  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F79578  token=0x60005E3  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x09F796FC  token=0x60005E4  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  RVA=0x09F79E98  token=0x60005E5  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x09F7A750  token=0x60005E6  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData)
  RVA=0x09F7A79C  token=0x60005E7  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent)
  RVA=0x09F7AD14  token=0x60005E8  System.Void Update()
  RVA=0x09F7956C  token=0x60005E9  System.Void LateUpdate()
  RVA=0x09F7A13C  token=0x60005EA  System.Void ProcessImguiEvents(System.Boolean isSelected)
  RVA=0x09F7A288  token=0x60005EB  System.Void ProcessKeyboardEvent(UnityEngine.Event e)
  RVA=0x09F7A384  token=0x60005EC  System.Void ProcessTabEvent(UnityEngine.Event e)
  RVA=0x09F7A9BC  token=0x60005ED  System.Void SendTabEvent(UnityEngine.Event e, System.Int32 direction)
  RVA=0x09F7A8D4  token=0x60005EE  System.Void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers)
  RVA=0x09F7A7EC  token=0x60005EF  System.Void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers)
  RVA=0x09F7AA80  token=0x60005F0  System.Void SendTextEvent(UnityEngine.Event e, System.Char c, UnityEngine.EventModifiers modifiers)
  RVA=0x09F7A3F8  token=0x60005F1  System.Boolean ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType)
  RVA=0x09F7ADD4  token=0x60005F2  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelRaycaster
TYPE:  class
TOKEN: 0x200009B
SIZE:  0x28
EXTENDS: UnityEngine.EventSystems.BaseRaycaster
IMPLEMENTS: UnityEngine.UIElements.IRuntimePanelComponent
FIELDS:
  private           UnityEngine.UIElements.BaseRuntimePanelm_Panel  // 0x20
PROPERTIES:
  panel  get=0x03D4EB40  set=0x09F7B594
  selectableGameObject  get=0x09F7B564
  sortOrderPriority  get=0x09F7B578
  renderOrderPriority  get=0x09F7B54C
  eventCamera  get=0x01002730
METHODS:
  RVA=0x09F7B424  token=0x6000622  System.Void RegisterCallbacks()
  RVA=0x09F7B4B8  token=0x6000623  System.Void UnregisterCallbacks()
  RVA=0x09F7AF40  token=0x6000624  System.Void OnPanelDestroyed()
  RVA=0x09F7AF4C  token=0x6000628  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  RVA=0x03D70290  token=0x600062A  System.Int32 ConvertFloatBitsToInt(System.Single f)
  RVA=0x0426FE60  token=0x600062B  System.Void .ctor()
END_CLASS

