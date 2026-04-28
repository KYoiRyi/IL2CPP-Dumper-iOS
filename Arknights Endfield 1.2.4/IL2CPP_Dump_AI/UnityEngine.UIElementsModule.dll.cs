// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIElementsModule.dll
// Classes:  869
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

CLASS: TextureInfo
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x68
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  public            UnityEngine.UIElements.DynamicAtlasPagepage  // 0x18
  public            System.Int32                    counter  // 0x20
  public            UnityEngine.UIElements.UIR.Allocator2D.Alloc2Dalloc  // 0x28
  public            UnityEngine.RectInt             rect  // 0x58
  public    static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.DynamicAtlas.TextureInfo>pool  // static @ 0x0
METHODS:
  RVA=0x09E77E20  token=0x6000026  UnityEngine.UIElements.DynamicAtlas.TextureInfo Create()
  RVA=0x09E77E70  token=0x6000027  System.Void Reset(UnityEngine.UIElements.DynamicAtlas.TextureInfo info)
  RVA=0x09E77FE8  token=0x6000028  System.Void .ctor()
  RVA=0x09E77EB4  token=0x6000029  System.Void .cctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09E783B0  token=0x600002D  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x78
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_PropertyPath  // 0x70
METHODS:
  RVA=0x09E78500  token=0x600002E  System.Void .ctor()
  RVA=0x09E78428  token=0x600002F  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: DragDirection
TYPE:  sealed struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>None  // const
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>LowToHigh  // const
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>HighToLow  // const
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>Free  // const
METHODS:
END_CLASS

CLASS: ButtonClickStatus
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x38
FIELDS:
  public            UnityEngine.UIElements.VisualElementm_Target  // 0x10
  public            UnityEngine.Vector3             m_PointerDownPosition  // 0x18
  public            System.Int64                    m_LastPointerDownTime  // 0x28
  public            System.Int32                    m_ClickCount  // 0x30
METHODS:
  RVA=0x09E69584  token=0x600006C  System.Void Reset()
  RVA=0x0350B670  token=0x600006D  System.Void .ctor()
END_CLASS

CLASS: <m_Counters>e__FixedBuffer
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x4010
FIELDS:
  public            System.Byte                     FixedElementField  // 0x10
METHODS:
END_CLASS

CLASS: UpdateMode
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DefaultEventSystem.UpdateModeAlways  // const
  public    static  UnityEngine.UIElements.DefaultEventSystem.UpdateModeIgnoreIfAppNotFocused  // const
METHODS:
END_CLASS

CLASS: IInput
TYPE:  interface
TOKEN: 0x200001C
FIELDS:
PROPERTIES:
  touchCount  get=-1  // abstract
  mousePresent  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60000AD  System.Boolean GetButtonDown(System.String button)
  RVA=-1  // abstract  token=0x60000AE  System.Single GetAxisRaw(System.String axis)
  RVA=-1  // abstract  token=0x60000B0  UnityEngine.Touch GetTouch(System.Int32 index)
END_CLASS

CLASS: Input
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x10
IMPLEMENTS: IInput
FIELDS:
PROPERTIES:
  touchCount  get=0x089CEE70
  mousePresent  get=0x09E75CCC
METHODS:
  RVA=0x09E75CC0  token=0x60000B2  System.Boolean GetButtonDown(System.String button)
  RVA=0x09E75CB4  token=0x60000B3  System.Single GetAxisRaw(System.String axis)
  RVA=0x0943BB00  token=0x60000B5  UnityEngine.Touch GetTouch(System.Int32 index)
  RVA=0x0350B670  token=0x60000B7  System.Void .ctor()
END_CLASS

CLASS: NoInput
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x10
IMPLEMENTS: IInput
FIELDS:
PROPERTIES:
  touchCount  get=0x01002730
  mousePresent  get=0x0115F4C0
METHODS:
  RVA=0x0115F4C0  token=0x60000B8  System.Boolean GetButtonDown(System.String button)
  RVA=0x03D503F0  token=0x60000B9  System.Single GetAxisRaw(System.String axis)
  RVA=0x03D88660  token=0x60000BB  UnityEngine.Touch GetTouch(System.Int32 index)
  RVA=0x0350B670  token=0x60000BD  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.DefaultEventSystem.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase><>9__23_0  // static @ 0x8
  public    static  System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase><>9__23_1  // static @ 0x10
  public    static  System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase><>9__23_2  // static @ 0x18
  public    static  System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase><>9__24_0  // static @ 0x20
  public    static  System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase><>9__24_1  // static @ 0x28
  public    static  System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase><>9__24_2  // static @ 0x30
  public    static  System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Touch,UnityEngine.UIElements.EventBase><>9__30_0  // static @ 0x38
METHODS:
  RVA=0x09E7834C  token=0x60000BE  System.Void .cctor()
  RVA=0x0350B670  token=0x60000BF  System.Void .ctor()
  RVA=0x09E78108  token=0x60000C0  UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__23_0(UnityEngine.UIElements.DefaultEventSystem self)
  RVA=0x09E78158  token=0x60000C1  UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__23_1(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.UIElements.DefaultEventSystem self)
  RVA=0x09E781E4  token=0x60000C2  UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__23_2(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.UIElements.DefaultEventSystem self)
  RVA=0x09E782B4  token=0x60000C3  UnityEngine.UIElements.EventBase <SendInputEvents>b__24_0(UnityEngine.UIElements.DefaultEventSystem self)
  RVA=0x09E782E4  token=0x60000C4  UnityEngine.UIElements.EventBase <SendInputEvents>b__24_1(UnityEngine.UIElements.DefaultEventSystem self)
  RVA=0x09E78318  token=0x60000C5  UnityEngine.UIElements.EventBase <SendInputEvents>b__24_2(UnityEngine.UIElements.DefaultEventSystem self)
  RVA=0x09E78010  token=0x60000C6  UnityEngine.UIElements.EventBase <ProcessTouchEvents>b__30_0(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.Touch _touch)
  RVA=0x0115F4C0  token=0x60000C7  System.Boolean <.cctor>b__41_0()
END_CLASS

CLASS: Status
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusNone  // const
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusNormal  // const
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusDisabled  // const
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusChecked  // const
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusHidden  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x2000027
SIZE:  0x18
FIELDS:
  public            UnityEngine.UIElements.DropdownMenuAction.Statusstatus  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000DA  System.Void .ctor()
  RVA=0x03D4E340  token=0x60000DB  UnityEngine.UIElements.DropdownMenuAction.Status <AppendAction>b__0(UnityEngine.UIElements.DropdownMenuAction e)
END_CLASS

CLASS: EventRecord
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.EventBasem_Event  // 0x10
  public            UnityEngine.UIElements.IPanel   m_Panel  // 0x18
METHODS:
END_CLASS

CLASS: DispatchContext
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x20
FIELDS:
  public            System.UInt32                   m_GateCount  // 0x10
  public            System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>m_Queue  // 0x18
METHODS:
END_CLASS

CLASS: FocusedElement
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.VisualElementm_SubTreeRoot  // 0x10
  public            UnityEngine.UIElements.Focusablem_FocusedElement  // 0x18
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09E783EC  token=0x600015E  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x70
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09E78590  token=0x600015F  System.Void .ctor()
END_CLASS

CLASS: GUIGlobals
TYPE:  sealed struct
TOKEN: 0x200003C
SIZE:  0x88
FIELDS:
  public            UnityEngine.Matrix4x4           matrix  // 0x10
  public            UnityEngine.Color               color  // 0x50
  public            UnityEngine.Color               contentColor  // 0x60
  public            UnityEngine.Color               backgroundColor  // 0x70
  public            System.Boolean                  enabled  // 0x80
  public            System.Boolean                  changed  // 0x81
  public            System.Int32                    displayIndex  // 0x84
METHODS:
END_CLASS

CLASS: <>c__DisplayClass5_0
TYPE:  sealed struct
TOKEN: 0x2000043
SIZE:  0x18
FIELDS:
  public            UnityEngine.UIElements.KeyDownEventevt  // 0x10
METHODS:
END_CLASS

CLASS: <>c__DisplayClass6_0
TYPE:  sealed struct
TOKEN: 0x2000044
SIZE:  0x18
FIELDS:
  public            UnityEngine.UIElements.KeyDownEventevt  // 0x10
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200005B
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.BaseRuntimePanel.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x09E7E48C  token=0x600023E  System.Void .cctor()
  RVA=0x0350B670  token=0x600023F  System.Void .ctor()
  RVA=0x03D51810  token=0x6000240  UnityEngine.Vector2 <.cctor>b__44_0(UnityEngine.Vector2 p)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000064
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.ScheduledItem.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x09E7E428  token=0x6000273  System.Void .cctor()
  RVA=0x0350B670  token=0x6000274  System.Void .ctor()
  RVA=0x0232EB60  token=0x6000275  System.Boolean <.cctor>b__25_0()
  RVA=0x0115F4C0  token=0x6000276  System.Boolean <.cctor>b__25_1()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000078
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09E7E4F0  token=0x60003BF  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000079
SIZE:  0x70
EXTENDS: UnityEngine.UIElements.UxmlTraits
FIELDS:
  protected         UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ViewDataKey  // 0x20
  protected         UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.PickingMode>m_PickingMode  // 0x28
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Tooltip  // 0x30
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.UsageHints>m_UsageHints  // 0x38
  private           UnityEngine.UIElements.UxmlIntAttributeDescription<focusIndex>k__BackingField  // 0x40
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_TabIndex  // 0x48
  private           UnityEngine.UIElements.UxmlBoolAttributeDescription<focusable>k__BackingField  // 0x50
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Class  // 0x58
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ContentContainer  // 0x60
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Style  // 0x68
PROPERTIES:
  focusIndex  get=0x03D4E2B0
  focusable  get=0x03D4EAF0
METHODS:
  RVA=0x09E7E52C  token=0x60003C2  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09E7E798  token=0x60003C3  System.Void .ctor()
END_CLASS

CLASS: MeasureMode
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElement.MeasureModeUndefined  // const
  public    static  UnityEngine.UIElements.VisualElement.MeasureModeExactly  // const
  public    static  UnityEngine.UIElements.VisualElement.MeasureModeAtMost  // const
METHODS:
END_CLASS

CLASS: RenderTargetMode
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeNone  // const
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeNoColorConversion  // const
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeLinearToGamma  // const
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeGammaToLinear  // const
METHODS:
END_CLASS

CLASS: Hierarchy
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x18
FIELDS:
  private   static  System.String                   k_InvalidHierarchyChangeMsg  // const
  private   readonly UnityEngine.UIElements.VisualElementm_Owner  // 0x10
PROPERTIES:
  parent  get=0x09E7C6C8
  childCount  get=0x09E7C680
  Item  get=0x09E7C620
METHODS:
  RVA=0x042715A0  token=0x60003C5  System.Void .ctor(UnityEngine.UIElements.VisualElement element)
  RVA=0x09E7B3E8  token=0x60003C6  System.Void Add(UnityEngine.UIElements.VisualElement child)
  RVA=0x09E7B9F8  token=0x60003C7  System.Void Insert(System.Int32 index, UnityEngine.UIElements.VisualElement child)
  RVA=0x09E7C3D8  token=0x60003C8  System.Void Remove(UnityEngine.UIElements.VisualElement child)
  RVA=0x09E7C10C  token=0x60003C9  System.Void RemoveAt(System.Int32 index)
  RVA=0x09E7B544  token=0x60003CA  System.Void Clear()
  RVA=0x09E7B474  token=0x60003CB  System.Void BringToFront(UnityEngine.UIElements.VisualElement child)
  RVA=0x09E7C510  token=0x60003CC  System.Void SendToBack(UnityEngine.UIElements.VisualElement child)
  RVA=0x09E7BE40  token=0x60003CD  System.Void PlaceBehind(UnityEngine.UIElements.VisualElement child, UnityEngine.UIElements.VisualElement over)
  RVA=0x09E7BD3C  token=0x60003CE  System.Void MoveChildElement(UnityEngine.UIElements.VisualElement child, System.Int32 currentIndex, System.Int32 nextIndex)
  RVA=0x09E7B998  token=0x60003D1  System.Int32 IndexOf(UnityEngine.UIElements.VisualElement element)
  RVA=0x09E7B920  token=0x60003D2  UnityEngine.UIElements.VisualElement ElementAt(System.Int32 index)
  RVA=0x09E7B524  token=0x60003D3  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
  RVA=0x09E7C59C  token=0x60003D4  System.Void SetParent(UnityEngine.UIElements.VisualElement value)
  RVA=0x09E7BF2C  token=0x60003D5  System.Void PutChildAtIndex(UnityEngine.UIElements.VisualElement child, System.Int32 index)
  RVA=0x09E7C35C  token=0x60003D6  System.Void RemoveChildAtIndex(System.Int32 index)
  RVA=0x09E7C034  token=0x60003D7  System.Void ReleaseChildList()
  RVA=0x09D7F378  token=0x60003D8  System.Boolean Equals(UnityEngine.UIElements.VisualElement.Hierarchy other)
  RVA=0x09E7B92C  token=0x60003D9  System.Boolean Equals(System.Object obj)
  RVA=0x0711E2B8  token=0x60003DA  System.Int32 GetHashCode()
  RVA=0x0232CE30  token=0x60003DB  System.Boolean op_Equality(UnityEngine.UIElements.VisualElement.Hierarchy x, UnityEngine.UIElements.VisualElement.Hierarchy y)
END_CLASS

CLASS: BaseVisualElementScheduledItem
TYPE:  abstract class
TOKEN: 0x200007D
SIZE:  0x50
EXTENDS: UnityEngine.UIElements.ScheduledItem
IMPLEMENTS: UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementPanelActivatable
FIELDS:
  private           UnityEngine.UIElements.VisualElement<element>k__BackingField  // 0x38
  public            System.Boolean                  isScheduled  // 0x40
  private           UnityEngine.UIElements.VisualElementPanelActivatorm_Activator  // 0x48
PROPERTIES:
  element  get=0x03D4E2A0  set=0x0388FF30
  isActive  get=0x09E7A948
METHODS:
  RVA=0x09E7A8A8  token=0x60003DF  System.Void .ctor(UnityEngine.UIElements.VisualElement handler)
  RVA=0x03D886F0  token=0x60003E0  UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 delayMs)
  RVA=0x09E7A620  token=0x60003E1  UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 intervalMs)
  RVA=0x09E7A6F4  token=0x60003E2  System.Void OnItemUnscheduled()
  RVA=0x09E7A884  token=0x60003E3  System.Void Resume()
  RVA=0x09E7A860  token=0x60003E4  System.Void Pause()
  RVA=0x09E7A6BC  token=0x60003E5  System.Void ExecuteLater(System.Int64 delayMs)
  RVA=0x09E7A724  token=0x60003E6  System.Void OnPanelActivate()
  RVA=0x09E7A7C8  token=0x60003E7  System.Void OnPanelDeactivate()
  RVA=0x09E7A5E4  token=0x60003E8  System.Boolean CanBeActivated()
END_CLASS

CLASS: VisualElementScheduledItem`1
TYPE:  abstract class
TOKEN: 0x200007E
EXTENDS: BaseVisualElementScheduledItem
FIELDS:
  public            ActionType                      updateEvent  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60003E9  System.Void .ctor(UnityEngine.UIElements.VisualElement handler, ActionType upEvent)
END_CLASS

CLASS: TimerStateScheduledItem
TYPE:  class
TOKEN: 0x200007F
SIZE:  0x58
EXTENDS: VisualElementScheduledItem`1
FIELDS:
METHODS:
  RVA=0x09E7E32C  token=0x60003EA  System.Void .ctor(UnityEngine.UIElements.VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent)
  RVA=0x09E7E2F4  token=0x60003EB  System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state)
END_CLASS

CLASS: SimpleScheduledItem
TYPE:  class
TOKEN: 0x2000080
SIZE:  0x58
EXTENDS: VisualElementScheduledItem`1
FIELDS:
METHODS:
  RVA=0x09E7D818  token=0x60003EC  System.Void .ctor(UnityEngine.UIElements.VisualElement handler, System.Action updateEvent)
  RVA=0x09E7D7F0  token=0x60003ED  System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state)
END_CLASS

CLASS: CustomStyleAccess
TYPE:  class
TOKEN: 0x2000081
SIZE:  0x20
IMPLEMENTS: UnityEngine.UIElements.ICustomStyle
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_CustomProperties  // 0x10
  private           System.Single                   m_DpiScaling  // 0x18
METHODS:
  RVA=0x05754818  token=0x60003EE  System.Void SetContext(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, System.Single dpiScaling)
  RVA=0x09E7B038  token=0x60003EF  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, System.Single& value)
  RVA=0x09E7ADC0  token=0x60003F0  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, System.Int32& value)
  RVA=0x09E7AC7C  token=0x60003F1  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, UnityEngine.Color& value)
  RVA=0x09E7AE74  token=0x60003F2  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, UnityEngine.Texture2D& value)
  RVA=0x09E7B1FC  token=0x60003F3  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, UnityEngine.Sprite& value)
  RVA=0x09E7B0E0  token=0x60003F4  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, UnityEngine.UIElements.VectorImage& value)
  RVA=0x09E7B31C  token=0x60003F5  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, System.String& value)
  RVA=0x09E7AF90  token=0x60003F6  System.Boolean TryGetValue(System.String propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue& customProp)
  RVA=0x09E7ABBC  token=0x60003F7  System.Void LogCustomPropertyWarning(System.String propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp)
  RVA=0x0350B670  token=0x60003F8  System.Void .ctor()
END_CLASS

CLASS: TypeData
TYPE:  class
TOKEN: 0x2000082
SIZE:  0x28
FIELDS:
  private   readonly System.Type                     <type>k__BackingField  // 0x10
  private           System.String                   m_FullTypeName  // 0x18
  private           System.String                   m_TypeName  // 0x20
PROPERTIES:
  type  get=0x020B7B20
  fullTypeName  get=0x09ED0F60
  typeName  get=0x09ED0FA8
METHODS:
  RVA=0x09ED0EE0  token=0x60003FA  System.Void .ctor(System.Type type)
END_CLASS

CLASS: <>c__DisplayClass322_0
TYPE:  sealed class
TOKEN: 0x2000083
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.VisualElement<>4__this  // 0x10
  public            UnityEngine.UIElements.Experimental.StyleValuesto  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60003FD  System.Void .ctor()
  RVA=0x09ED1364  token=0x60003FE  UnityEngine.UIElements.Experimental.StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(UnityEngine.UIElements.VisualElement e)
END_CLASS

CLASS: TransitionState
TYPE:  sealed struct
TOKEN: 0x2000086
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateNone  // const
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateRunning  // const
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateStarted  // const
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateEnded  // const
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateCanceled  // const
METHODS:
END_CLASS

CLASS: AnimationDataSet`2
TYPE:  sealed struct
TOKEN: 0x2000087
FIELDS:
  public            UnityEngine.UIElements.VisualElement[]elements  // 0x0
  public            UnityEngine.UIElements.StyleSheets.StylePropertyId[]properties  // 0x0
  public            TTimingData[]                   timing  // 0x0
  public            TStyleData[]                    style  // 0x0
  public            System.Int32                    count  // 0x0
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Int32>indices  // 0x0
PROPERTIES:
  capacity  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600042A  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x600042B  UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData,TStyleData> Create()
  RVA=-1  // not resolved  token=0x600042C  System.Boolean IndexOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32& index)
  RVA=-1  // not resolved  token=0x600042D  System.Void Add(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TTimingData timingData, TStyleData styleData)
  RVA=-1  // not resolved  token=0x600042E  System.Void Remove(System.Int32 cancelledIndex)
  RVA=-1  // not resolved  token=0x600042F  System.Void Replace(System.Int32 index, TTimingData timingData, TStyleData styleData)
  RVA=-1  // not resolved  token=0x6000430  System.Void RemoveAll(UnityEngine.UIElements.VisualElement ve)
  RVA=-1  // not resolved  token=0x6000431  System.Void RemoveAll()
  RVA=-1  // not resolved  token=0x6000432  System.Void GetActivePropertiesForElement(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties)
END_CLASS

CLASS: EqualityComparer
TYPE:  class
TOKEN: 0x2000089
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IEqualityComparer`1
FIELDS:
METHODS:
  RVA=0x09ECDED8  token=0x6000435  System.Boolean Equals(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair x, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair y)
  RVA=0x09ECDEF0  token=0x6000436  System.Int32 GetHashCode(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair obj)
  RVA=0x0350B670  token=0x6000437  System.Void .ctor()
END_CLASS

CLASS: ElementPropertyPair
TYPE:  sealed struct
TOKEN: 0x2000088
SIZE:  0x20
FIELDS:
  public    static readonly System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair>Comparer  // static @ 0x0
  public    readonly UnityEngine.UIElements.VisualElementelement  // 0x10
  public    readonly UnityEngine.UIElements.StyleSheets.StylePropertyIdproperty  // 0x18
METHODS:
  RVA=0x04274600  token=0x6000433  System.Void .ctor(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId property)
  RVA=0x09ECDE68  token=0x6000434  System.Void .cctor()
END_CLASS

CLASS: Values
TYPE:  abstract class
TOKEN: 0x200008A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000438  System.Void CancelAllAnimations()
  RVA=-1  // abstract  token=0x6000439  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve)
  RVA=-1  // abstract  token=0x600043A  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // abstract  token=0x600043B  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // abstract  token=0x600043C  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  RVA=-1  // abstract  token=0x600043D  System.Void Update(System.Int64 currentTimeMs)
  RVA=-1  // abstract  token=0x600043E  System.Void UpdateValues()
  RVA=-1  // abstract  token=0x600043F  System.Void UpdateComputedStyle()
  RVA=-1  // abstract  token=0x6000440  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x0350B670  token=0x6000441  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200008D
FIELDS:
  public    static readonly UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T><>9  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000462  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000463  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000464  System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> <.cctor>b__11_0()
END_CLASS

CLASS: TransitionEventsFrameState
TYPE:  class
TOKEN: 0x200008C
FIELDS:
  private   static readonly UnityEngine.Pool.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>>k_EventQueuePool  // static @ 0x0
  public    readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState>elementPropertyStateDelta  // 0x0
  public    readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>>elementPropertyQueuedEvents  // 0x0
  public            UnityEngine.UIElements.IPanel   panel  // 0x0
  private           System.Int32                    m_ChangesCount  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600045B  System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue()
  RVA=-1  // not resolved  token=0x600045C  System.Void RegisterChange()
  RVA=-1  // not resolved  token=0x600045D  System.Void UnregisterChange()
  RVA=-1  // not resolved  token=0x600045E  System.Boolean StateChanged()
  RVA=-1  // not resolved  token=0x600045F  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000460  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000461  System.Void .cctor()
END_CLASS

CLASS: TimingData
TYPE:  sealed struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int64                    startTimeMs  // 0x0
  public            System.Int32                    durationMs  // 0x0
  public            System.Func<System.Single,System.Single>easingCurve  // 0x0
  public            System.Single                   easedProgress  // 0x0
  public            System.Single                   reversingShorteningFactor  // 0x0
  public            System.Boolean                  isStarted  // 0x0
  public            System.Int32                    delayMs  // 0x0
METHODS:
END_CLASS

CLASS: StyleData
TYPE:  sealed struct
TOKEN: 0x200008F
FIELDS:
  public            T                               startValue  // 0x0
  public            T                               endValue  // 0x0
  public            T                               reversingAdjustedStartValue  // 0x0
  public            T                               currentValue  // 0x0
METHODS:
END_CLASS

CLASS: EmptyData
TYPE:  sealed struct
TOKEN: 0x2000090
SIZE:  0x11
FIELDS:
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>Default  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000465  System.Void .cctor()
END_CLASS

CLASS: Values`1
TYPE:  abstract class
TOKEN: 0x200008B
EXTENDS: Values
FIELDS:
  private           System.Int64                    m_CurrentTimeMs  // 0x0
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T>m_CurrentFrameEventsState  // 0x0
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T>m_NextFrameEventsState  // 0x0
  public            UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TimingData<T>,UnityEngine.UIElements.StylePropertyAnimationSystem.Values.StyleData<T>>running  // 0x0
  public            UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>,T>completed  // 0x0
PROPERTIES:
  isEmpty  get=-1  // not resolved
  SameFunc  get=-1  // abstract
METHODS:
  RVA=-1  // not resolved  token=0x6000444  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T& a, T& b)
  RVA=-1  // not resolved  token=0x6000445  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000446  System.Void SwapFrameStates()
  RVA=-1  // not resolved  token=0x6000447  System.Void QueueEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp)
  RVA=-1  // not resolved  token=0x6000448  System.Void ClearEventQueue(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp)
  RVA=-1  // not resolved  token=0x6000449  System.Void QueueTransitionRunEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex)
  RVA=-1  // not resolved  token=0x600044A  System.Void QueueTransitionStartEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex)
  RVA=-1  // not resolved  token=0x600044B  System.Void QueueTransitionEndEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex)
  RVA=-1  // not resolved  token=0x600044C  System.Void QueueTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex, System.Int64 panelElapsedMs)
  RVA=-1  // not resolved  token=0x600044D  System.Void SendTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex, System.Int64 panelElapsedMs)
  RVA=-1  // not resolved  token=0x600044E  System.Void CancelAllAnimations()
  RVA=-1  // not resolved  token=0x600044F  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve)
  RVA=-1  // not resolved  token=0x6000450  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // not resolved  token=0x6000451  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // not resolved  token=0x6000452  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  RVA=-1  // not resolved  token=0x6000453  System.Single ComputeReversingShorteningFactor(System.Int32 oldIndex)
  RVA=-1  // not resolved  token=0x6000454  System.Int32 ComputeReversingDuration(System.Int32 newTransitionDurationMs, System.Single newReversingShorteningFactor)
  RVA=-1  // not resolved  token=0x6000455  System.Int32 ComputeReversingDelay(System.Int32 delayMs, System.Single newReversingShorteningFactor)
  RVA=-1  // not resolved  token=0x6000456  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve, System.Int64 currentTimeMs)
  RVA=-1  // not resolved  token=0x6000457  System.Void ForceComputedStyleEndValue(System.Int32 runningIndex)
  RVA=-1  // not resolved  token=0x6000458  System.Void Update(System.Int64 currentTimeMs)
  RVA=-1  // not resolved  token=0x6000459  System.Void ProcessEventQueue()
  RVA=-1  // not resolved  token=0x600045A  System.Void UpdateProgress(System.Int64 currentTimeMs)
END_CLASS

CLASS: ValuesFloat
TYPE:  class
TOKEN: 0x2000091
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<System.Single,System.Single,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x096C9A34  token=0x6000467  System.Boolean IsSame(System.Single a, System.Single b)
  RVA=0x03D86320  token=0x6000468  System.Single Lerp(System.Single a, System.Single b, System.Single t)
  RVA=0x09ED5ED8  token=0x6000469  System.Void UpdateValues()
  RVA=0x09ED5D90  token=0x600046A  System.Void UpdateComputedStyle()
  RVA=0x09ED5E44  token=0x600046B  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED5F54  token=0x600046C  System.Void .ctor()
END_CLASS

CLASS: ValuesInt
TYPE:  class
TOKEN: 0x2000092
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<System.Int32,System.Int32,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x06505FF4  token=0x600046E  System.Boolean IsSame(System.Int32 a, System.Int32 b)
  RVA=0x09ED62F8  token=0x600046F  System.Int32 Lerp(System.Int32 a, System.Int32 b, System.Single t)
  RVA=0x09ED6460  token=0x6000470  System.Void UpdateValues()
  RVA=0x09ED63AC  token=0x6000471  System.Void UpdateComputedStyle()
  RVA=0x09ED6318  token=0x6000472  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED64E8  token=0x6000473  System.Void .ctor()
END_CLASS

CLASS: ValuesLength
TYPE:  class
TOKEN: 0x2000093
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED65C0  token=0x6000475  System.Boolean IsSame(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b)
  RVA=0x09ED6584  token=0x6000476  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length& a, UnityEngine.UIElements.Length& b)
  RVA=0x09ED65F8  token=0x6000477  UnityEngine.UIElements.Length Lerp(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b, System.Single t)
  RVA=0x09ED6788  token=0x6000478  System.Void UpdateValues()
  RVA=0x09ED6640  token=0x6000479  System.Void UpdateComputedStyle()
  RVA=0x09ED66F4  token=0x600047A  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED6814  token=0x600047B  System.Void .ctor()
END_CLASS

CLASS: ValuesColor
TYPE:  class
TOKEN: 0x2000094
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED5A30  token=0x600047D  System.Boolean IsSame(UnityEngine.Color c, UnityEngine.Color d)
  RVA=0x09ED5AA4  token=0x600047E  UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, System.Single t)
  RVA=0x09ED5C44  token=0x600047F  System.Void UpdateValues()
  RVA=0x09ED5B80  token=0x6000480  System.Void UpdateComputedStyle()
  RVA=0x09ED5AE0  token=0x6000481  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED5CF4  token=0x6000482  System.Void .ctor()
END_CLASS

CLASS: ValuesDiscrete`1
TYPE:  abstract class
TOKEN: 0x2000095
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<T,T,System.Boolean> <SameFunc>k__BackingField  // 0x0
PROPERTIES:
  SameFunc  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000484  System.Boolean IsSame(T a, T b)
  RVA=-1  // not resolved  token=0x6000485  T Lerp(T a, T b, System.Single t)
  RVA=-1  // not resolved  token=0x6000486  System.Void UpdateValues()
  RVA=-1  // not resolved  token=0x6000487  System.Void .ctor()
END_CLASS

CLASS: ValuesBackground
TYPE:  class
TOKEN: 0x2000096
SIZE:  0x90
EXTENDS: ValuesDiscrete`1
FIELDS:
METHODS:
  RVA=0x09ED5924  token=0x6000488  System.Void UpdateComputedStyle()
  RVA=0x09ED5878  token=0x6000489  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED59F4  token=0x600048A  System.Void .ctor()
END_CLASS

CLASS: ValuesFontDefinition
TYPE:  class
TOKEN: 0x2000097
SIZE:  0x90
EXTENDS: ValuesDiscrete`1
FIELDS:
METHODS:
  RVA=0x09ED6090  token=0x600048B  System.Void UpdateComputedStyle()
  RVA=0x09ED5FF0  token=0x600048C  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED6154  token=0x600048D  System.Void .ctor()
END_CLASS

CLASS: ValuesFont
TYPE:  class
TOKEN: 0x2000098
SIZE:  0x90
EXTENDS: ValuesDiscrete`1
FIELDS:
METHODS:
  RVA=0x09ED6214  token=0x600048E  System.Void UpdateComputedStyle()
  RVA=0x09ED6190  token=0x600048F  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED62BC  token=0x6000490  System.Void .ctor()
END_CLASS

CLASS: ValuesTextShadow
TYPE:  class
TOKEN: 0x2000099
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED6FD8  token=0x6000492  System.Boolean IsSame(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b)
  RVA=0x09ED7028  token=0x6000493  UnityEngine.UIElements.TextShadow Lerp(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, System.Single t)
  RVA=0x09ED723C  token=0x6000494  System.Void UpdateValues()
  RVA=0x09ED7160  token=0x6000495  System.Void UpdateComputedStyle()
  RVA=0x09ED70A8  token=0x6000496  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED732C  token=0x6000497  System.Void .ctor()
END_CLASS

CLASS: ValuesScale
TYPE:  class
TOKEN: 0x200009A
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED6C88  token=0x6000499  System.Boolean IsSame(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b)
  RVA=0x09ED6DC8  token=0x600049A  System.Void UpdateComputedStyle()
  RVA=0x09ED6D28  token=0x600049B  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED6CB4  token=0x600049C  UnityEngine.UIElements.Scale Lerp(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b, System.Single t)
  RVA=0x09ED6E8C  token=0x600049D  System.Void UpdateValues()
  RVA=0x09ED6F3C  token=0x600049E  System.Void .ctor()
END_CLASS

CLASS: ValuesRotate
TYPE:  class
TOKEN: 0x200009B
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED68B0  token=0x60004A0  System.Boolean IsSame(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b)
  RVA=0x09ED6A44  token=0x60004A1  System.Void UpdateComputedStyle()
  RVA=0x09ED6998  token=0x60004A2  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED68F4  token=0x60004A3  UnityEngine.UIElements.Rotate Lerp(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b, System.Single t)
  RVA=0x09ED6B14  token=0x60004A4  System.Void UpdateValues()
  RVA=0x09ED6BEC  token=0x60004A5  System.Void .ctor()
END_CLASS

CLASS: ValuesTranslate
TYPE:  class
TOKEN: 0x200009C
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED77BC  token=0x60004A7  System.Boolean IsSame(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b)
  RVA=0x09ED7790  token=0x60004A8  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate& a, UnityEngine.UIElements.Translate& b)
  RVA=0x09ED7944  token=0x60004A9  System.Void UpdateComputedStyle()
  RVA=0x09ED7898  token=0x60004AA  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED7800  token=0x60004AB  UnityEngine.UIElements.Translate Lerp(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b, System.Single t)
  RVA=0x09ED7A14  token=0x60004AC  System.Void UpdateValues()
  RVA=0x09ED7AEC  token=0x60004AD  System.Void .ctor()
END_CLASS

CLASS: ValuesTransformOrigin
TYPE:  class
TOKEN: 0x200009D
SIZE:  0x90
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean><SameFunc>k__BackingField  // 0x88
PROPERTIES:
  SameFunc  get=0x03D4EA60
METHODS:
  RVA=0x09ED73F4  token=0x60004AF  System.Boolean IsSame(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b)
  RVA=0x09ED73C8  token=0x60004B0  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin& a, UnityEngine.UIElements.TransformOrigin& b)
  RVA=0x09ED7564  token=0x60004B1  System.Void UpdateComputedStyle()
  RVA=0x09ED74BC  token=0x60004B2  System.Void UpdateComputedStyle(System.Int32 i)
  RVA=0x09ED7430  token=0x60004B3  UnityEngine.UIElements.TransformOrigin Lerp(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b, System.Single t)
  RVA=0x09ED7630  token=0x60004B4  System.Void UpdateValues()
  RVA=0x09ED76F4  token=0x60004B5  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x20000A0
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
PROPERTIES:
  uxmlName  get=0x09ED5168
  uxmlQualifiedName  get=0x09ED5194
METHODS:
  RVA=0x09ED512C  token=0x60004CB  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x20000A1
SIZE:  0x80
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Template  // 0x78
METHODS:
  RVA=0x09ED5208  token=0x60004CC  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09ED57E0  token=0x60004CD  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x20000A4
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09ED50F0  token=0x60004E8  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x20000A5
SIZE:  0x90
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x78
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_EnableRichText  // 0x80
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_DisplayTooltipWhenElided  // 0x88
METHODS:
  RVA=0x09ED5548  token=0x60004E9  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09ED568C  token=0x60004EA  System.Void .ctor()
END_CLASS

CLASS: CreateRuntimePanelDelegate
TYPE:  sealed class
TOKEN: 0x20000A9
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06E93748  token=0x6000512  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0102B410  token=0x6000513  UnityEngine.UIElements.BaseRuntimePanel Invoke(UnityEngine.ScriptableObject ownerObject)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000AA
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIElementsRuntimeUtility.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.UIElements.Panel><>9__47_0  // static @ 0x8
METHODS:
  RVA=0x03D14F90  token=0x6000514  System.Void .cctor()
  RVA=0x0350B670  token=0x6000515  System.Void .ctor()
  RVA=0x0350B670  token=0x6000516  System.Void <.cctor>b__9_0()
  RVA=0x09ED1310  token=0x6000517  System.Void <.cctor>b__9_1(System.Int32 displayIndex, System.Int32 sortOrder)
  RVA=0x09ED1094  token=0x6000518  System.Int32 <SortPanels>b__47_0(UnityEngine.UIElements.Panel a, UnityEngine.UIElements.Panel b)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000AD
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIEventRegistration.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x03D1A870  token=0x6000527  System.Void .cctor()
  RVA=0x0350B670  token=0x6000528  System.Void .ctor()
  RVA=0x09ED116C  token=0x6000529  System.Void <.cctor>b__1_0()
  RVA=0x09ED11AC  token=0x600052A  System.Void <.cctor>b__1_1()
  RVA=0x09ED11EC  token=0x600052B  System.Boolean <.cctor>b__1_2(System.Int32 i, System.IntPtr ptr)
  RVA=0x09ED1244  token=0x600052C  System.Void <.cctor>b__1_3()
  RVA=0x09ED1284  token=0x600052D  System.Boolean <.cctor>b__1_4(System.Exception exception)
  RVA=0x09ED12D0  token=0x600052E  System.Void <.cctor>b__1_5()
END_CLASS

CLASS: IVisualPredicateWrapper
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000543  System.Boolean Predicate(System.Object e)
END_CLASS

CLASS: IsOfType`1
TYPE:  class
TOKEN: 0x20000B2
IMPLEMENTS: IVisualPredicateWrapper
FIELDS:
  public    static  UnityEngine.UIElements.UQuery.IsOfType<T>s_Instance  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000544  System.Boolean Predicate(System.Object e)
  RVA=-1  // not resolved  token=0x6000545  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000546  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000B4
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UQuery.UQueryMatcher.<>c<>9  // static @ 0x0
  public    static  System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo><>9__5_0  // static @ 0x8
METHODS:
  RVA=0x09ED138C  token=0x600054D  System.Void .cctor()
  RVA=0x0350B670  token=0x600054E  System.Void .ctor()
  RVA=0x0350B670  token=0x600054F  System.Void <TraverseRecursive>b__5_0(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i)
END_CLASS

CLASS: UQueryMatcher
TYPE:  abstract class
TOKEN: 0x20000B3
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.StyleSheets.HierarchyTraversal
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher>m_Matchers  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000547  System.Void .ctor()
  RVA=0x09ED50A0  token=0x6000548  System.Void Traverse(UnityEngine.UIElements.VisualElement element)
  RVA=0x03D4E3A0  token=0x6000549  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  RVA=0x0350B670  token=0x600054A  System.Void NoProcessResult(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i)
  RVA=0x09ED4EA8  token=0x600054B  System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  RVA=0x09ED4E7C  token=0x600054C  System.Void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers)
END_CLASS

CLASS: SingleQueryMatcher
TYPE:  abstract class
TOKEN: 0x20000B5
SIZE:  0x20
EXTENDS: UQueryMatcher
FIELDS:
  private           UnityEngine.UIElements.VisualElement<match>k__BackingField  // 0x18
PROPERTIES:
  match  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09ECE004  token=0x6000552  System.Void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers)
  RVA=0x0246CF60  token=0x6000553  System.Boolean IsInUse()
  RVA=-1  // abstract  token=0x6000554  UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew()
  RVA=0x0350B670  token=0x6000555  System.Void .ctor()
END_CLASS

CLASS: FirstQueryMatcher
TYPE:  class
TOKEN: 0x20000B6
SIZE:  0x20
EXTENDS: SingleQueryMatcher
FIELDS:
  public    static readonly UnityEngine.UIElements.UQuery.FirstQueryMatcherInstance  // static @ 0x0
METHODS:
  RVA=0x09ECDF5C  token=0x6000556  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  RVA=0x09ECDF20  token=0x6000557  UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew()
  RVA=0x0350B670  token=0x6000558  System.Void .ctor()
  RVA=0x09ECDF7C  token=0x6000559  System.Void .cctor()
END_CLASS

CLASS: ListQueryMatcher`1
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: UQueryMatcher
FIELDS:
  private           System.Collections.Generic.List<TElement><matches>k__BackingField  // 0x0
PROPERTIES:
  matches  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000568  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  RVA=-1  // not resolved  token=0x6000569  System.Void Reset()
  RVA=-1  // not resolved  token=0x600056A  System.Void .ctor()
END_CLASS

CLASS: ActionQueryMatcher
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: UQueryMatcher
FIELDS:
  private           System.Action<T>                <callBack>k__BackingField  // 0x0
PROPERTIES:
  callBack  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600056C  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  RVA=-1  // not resolved  token=0x600056D  System.Void .ctor()
END_CLASS

CLASS: Enumerator
TYPE:  sealed struct
TOKEN: 0x20000BA
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>iterationList  // 0x0
  private           System.Int32                    currentIndex  // 0x0
PROPERTIES:
  Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600056E  System.Void .ctor(UnityEngine.UIElements.UQueryState<T> queryState)
  RVA=-1  // not resolved  token=0x6000571  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000572  System.Void Reset()
  RVA=-1  // not resolved  token=0x6000573  System.Void Dispose()
END_CLASS

CLASS: DefaultFocusOrder
TYPE:  sealed struct
TOKEN: 0x20000CD
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrderChildOrder  // const
  public    static  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrderPositionXY  // const
  public    static  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrderPositionYX  // const
METHODS:
END_CLASS

CLASS: FocusRingRecord
TYPE:  class
TOKEN: 0x20000CE
SIZE:  0x30
FIELDS:
  public            System.Int32                    m_AutoIndex  // 0x10
  public            UnityEngine.UIElements.Focusablem_Focusable  // 0x18
  public            System.Boolean                  m_IsSlot  // 0x20
  public            System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord>m_ScopeNavigationOrder  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60005B6  System.Void .ctor()
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x20000D8
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.StateWaiting  // const
  public    static  UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.StateTrackingAddOrMove  // const
  public    static  UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.StateTrackingRemove  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000DD
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord><>9__24_0  // static @ 0x8
METHODS:
  RVA=0x09ED13F0  token=0x600060D  System.Void .cctor()
  RVA=0x0350B670  token=0x600060E  System.Void .ctor()
  RVA=0x09ED1050  token=0x600060F  System.Int32 <ProcessMatchedRules>b__24_0(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b)
END_CLASS

CLASS: UpdaterArray
TYPE:  class
TOKEN: 0x20000E1
SIZE:  0x18
FIELDS:
  private           UnityEngine.UIElements.IVisualTreeUpdater[]m_VisualTreeUpdaters  // 0x10
PROPERTIES:
  Item  get=0x0594E120  set=0x0594E14C
  Item  get=0x0594E120
METHODS:
  RVA=0x09ED50A8  token=0x600061E  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass20_0
TYPE:  sealed class
TOKEN: 0x20000E9
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.BaseTreeViewController<>4__this  // 0x10
  public            UnityEngine.UIElements.ReusableTreeViewItemtreeItem  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000688  System.Void .ctor()
  RVA=0x09EF20E0  token=0x6000689  System.Void <PostInitRegistration>b__0()
END_CLASS

CLASS: <GetItemIds>d__9
TYPE:  sealed class
TOKEN: 0x20000F1
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Int32                    <>2__current  // 0x0
  private           System.Int32                    <>l__initialThreadId  // 0x0
  private           System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>>items  // 0x0
  public            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>><>3__items  // 0x0
  private           System.Collections.Generic.IEnumerator<UnityEngine.UIElements.TreeViewItemData<T>><>s__1  // 0x0
  private           UnityEngine.UIElements.TreeViewItemData<T><item>5__2  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Int32>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60006E2  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x60006E3  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x60006E4  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60006E5  System.Void <>m__Finally1()
  RVA=-1  // not resolved  token=0x60006E7  System.Void System.Collections.IEnumerator.Reset()
  RVA=-1  // not resolved  token=0x60006E9  System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
  RVA=-1  // not resolved  token=0x60006EA  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <GetAllItemIds>d__13
TYPE:  sealed class
TOKEN: 0x20000F2
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Int32                    <>2__current  // 0x0
  private           System.Int32                    <>l__initialThreadId  // 0x0
  private           System.Collections.Generic.IEnumerable<System.Int32>rootIds  // 0x0
  public            System.Collections.Generic.IEnumerable<System.Int32><>3__rootIds  // 0x0
  public            UnityEngine.UIElements.TreeDataController<T><>4__this  // 0x0
  private           System.Collections.Generic.IEnumerator<System.Int32><currentIterator>5__1  // 0x0
  private           System.Boolean                  <hasNext>5__2  // 0x0
  private           System.Int32                    <currentItemId>5__3  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Int32>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60006EB  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x60006EC  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x60006ED  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60006EF  System.Void System.Collections.IEnumerator.Reset()
  RVA=-1  // not resolved  token=0x60006F1  System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
  RVA=-1  // not resolved  token=0x60006F2  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ContentHeightCacheInfo
TYPE:  sealed struct
TOKEN: 0x20000F6
FIELDS:
  public    readonly System.Single                   sum  // 0x0
  public    readonly System.Int32                    count  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000737  System.Void .ctor(System.Single sum, System.Int32 count)
END_CLASS

CLASS: VirtualizationChange
TYPE:  sealed struct
TOKEN: 0x20000F7
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>None  // const
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>Resize  // const
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>Scroll  // const
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>ForcedScroll  // const
METHODS:
END_CLASS

CLASS: ScrollDirection
TYPE:  sealed struct
TOKEN: 0x20000F8
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>Idle  // const
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>Up  // const
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>Down  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000100
FIELDS:
  public    static readonly UnityEngine.UIElements.VerticalVirtualizationController.<>c<T><>9  // static @ 0x0
  public    static  System.Func<T>                  <>9__30_0  // static @ 0x0
  public    static  System.Action<T>                <>9__30_1  // static @ 0x0
  public    static  System.Action<T>                <>9__30_2  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000793  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6000794  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000795  T <.ctor>b__30_0()
  RVA=-1  // not resolved  token=0x6000796  System.Void <.ctor>b__30_1(T i)
  RVA=-1  // not resolved  token=0x6000797  System.Void <.ctor>b__30_2(T i)
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000103
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Label  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60007BA  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60007BB  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x60007BC  System.Collections.Generic.List<System.String> ParseChoiceList(System.String choicesFromBag)
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000107
SIZE:  0xD8
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowFoldoutHeader  // 0xb0
  private   readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionm_HeaderTitle  // 0xb8
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowAddRemoveFooter  // 0xc0
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ListViewReorderMode>m_ReorderMode  // 0xc8
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowBoundCollectionSize  // 0xd0
METHODS:
  RVA=0x09EF27A0  token=0x60007E0  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09EF2E94  token=0x60007E1  System.Void .ctor()
END_CLASS

CLASS: SliderKey
TYPE:  sealed struct
TOKEN: 0x200010A
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>None  // const
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Lowest  // const
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>LowerPage  // const
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Lower  // const
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Higher  // const
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>HigherPage  // const
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Highest  // const
METHODS:
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200010C
SIZE:  0xB8
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_AutoExpand  // 0xb0
METHODS:
  RVA=0x09EF2A5C  token=0x6000835  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09EF3608  token=0x6000836  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000111
SIZE:  0xB0
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlIntAttributeDescriptionm_FixedItemHeight  // 0x78
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.CollectionVirtualizationMethod>m_VirtualizationMethod  // 0x80
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowBorder  // 0x88
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType>m_SelectionType  // 0x90
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground>m_ShowAlternatingRowBackgrounds  // 0x98
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Reorderable  // 0xa0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_HorizontalScrollingEnabled  // 0xa8
METHODS:
  RVA=0x09EF3124  token=0x6000896  System.Void .ctor()
  RVA=0x09EF2B2C  token=0x6000897  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: Selection
TYPE:  class
TOKEN: 0x2000112
SIZE:  0x40
FIELDS:
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_IndexLookup  // 0x10
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_IdLookup  // 0x18
  private           System.Int32                    m_MinIndex  // 0x20
  private           System.Int32                    m_MaxIndex  // 0x24
  private           System.Collections.Generic.List<System.Int32><selectedIds>k__BackingField  // 0x28
  public    readonly System.Collections.Generic.List<System.Int32>indices  // 0x30
  public    readonly System.Collections.Generic.Dictionary<System.Int32,System.Object>items  // 0x38
PROPERTIES:
  selectedIds  get=0x03D4EAC0  set=0x02C92F10
  indexCount  get=0x09EF1C38
  idCount  get=0x09EF1BF8
  minIndex  get=0x09EF1CA0
  maxIndex  get=0x09EF1C78
  capacity  get=0x09EF1BB0  set=0x09EF1CC8
METHODS:
  RVA=0x09EF1894  token=0x60008A0  System.Int32 FirstIndex()
  RVA=0x09EF1840  token=0x60008A1  System.Boolean ContainsIndex(System.Int32 index)
  RVA=0x09EF17EC  token=0x60008A2  System.Boolean ContainsId(System.Int32 id)
  RVA=0x09EF1574  token=0x60008A3  System.Void AddId(System.Int32 id)
  RVA=0x09EF15EC  token=0x60008A4  System.Void AddIndex(System.Int32 index, System.Object obj)
  RVA=0x09EF1974  token=0x60008A5  System.Boolean TryRemove(System.Int32 index)
  RVA=0x09EF18FC  token=0x60008A6  System.Void RemoveId(System.Int32 id)
  RVA=0x09EF1778  token=0x60008A7  System.Void ClearItems()
  RVA=0x09EF16A8  token=0x60008A8  System.Void ClearIds()
  RVA=0x09EF170C  token=0x60008A9  System.Void ClearIndices()
  RVA=0x09EF17C0  token=0x60008AA  System.Void Clear()
  RVA=0x09EF1A64  token=0x60008AB  System.Void .ctor()
END_CLASS

CLASS: <get_selectedItems>d__72
TYPE:  sealed class
TOKEN: 0x2000113
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            UnityEngine.UIElements.BaseVerticalCollectionView<>4__this  // 0x28
  private           System.Collections.Generic.List.Enumerator<System.Int32><>s__1  // 0x30
  private           System.Int32                    <index>5__2  // 0x48
  private           System.Object                   <item>5__3  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x07BF60A4  token=0x60008AC  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x09EF25C0  token=0x60008AD  System.Void System.IDisposable.Dispose()
  RVA=0x09EF2144  token=0x60008AE  System.Boolean MoveNext()
  RVA=0x09EF2638  token=0x60008AF  System.Void <>m__Finally1()
  RVA=0x09EF2574  token=0x60008B1  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09EF24D0  token=0x60008B3  System.Collections.Generic.IEnumerator<System.Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
  RVA=0x09EF256C  token=0x60008B4  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <>c__DisplayClass163_0
TYPE:  sealed class
TOKEN: 0x2000114
SIZE:  0x18
FIELDS:
  public            System.Int32                    id  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60008B5  System.Void .ctor()
  RVA=0x09EF20C0  token=0x60008B6  System.Boolean <GetRootElementForId>b__0(UnityEngine.UIElements.ReusableCollectionItem t)
END_CLASS

CLASS: <>c__DisplayClass173_0
TYPE:  sealed struct
TOKEN: 0x2000115
SIZE:  0x28
FIELDS:
  public            System.Boolean                  selectedIndicesChanged  // 0x10
  public            UnityEngine.UIElements.BaseVerticalCollectionView<>4__this  // 0x18
  public            System.Int32                    previousSelectionCount  // 0x20
METHODS:
END_CLASS

CLASS: <>c__DisplayClass184_0
TYPE:  sealed struct
TOKEN: 0x2000116
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.BaseVerticalCollectionView<>4__this  // 0x10
  public            System.Boolean                  shiftKey  // 0x18
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200011A
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`1
FIELDS:
METHODS:
  RVA=0x09EF26EC  token=0x60008BE  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200011C
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09EF2728  token=0x60008C7  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200011D
SIZE:  0x90
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09EF37F0  token=0x60008C8  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200011F
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09EF26B0  token=0x60008CD  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000120
SIZE:  0x80
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09EF37B4  token=0x60008CE  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000122
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09EF2674  token=0x60008DF  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000123
SIZE:  0x90
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_Index  // 0x80
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Choices  // 0x88
METHODS:
  RVA=0x09EF2D5C  token=0x60008E0  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09EF36AC  token=0x60008E1  System.Void .ctor()
END_CLASS

CLASS: PopupTextElement
TYPE:  class
TOKEN: 0x2000124
SIZE:  0x488
EXTENDS: UnityEngine.UIElements.TextElement
FIELDS:
METHODS:
  RVA=0x09EEF5EC  token=0x60008E2  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09EEF684  token=0x60008E3  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass38_0
TYPE:  sealed class
TOKEN: 0x2000125
SIZE:  0x20
FIELDS:
  public            System.String                   item  // 0x10
  public            UnityEngine.UIElements.DropdownField<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60008E4  System.Void .ctor()
  RVA=0x09EF211C  token=0x60008E5  System.Void <AddMenuItems>b__0()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000127
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09EF2764  token=0x60008F1  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000128
SIZE:  0x88
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x78
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Value  // 0x80
METHODS:
  RVA=0x09EF2958  token=0x60008F2  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09EF3508  token=0x60008F3  System.Void .ctor()
END_CLASS

CLASS: MenuItem
TYPE:  class
TOKEN: 0x200012B
SIZE:  0x30
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.UIElements.VisualElementelement  // 0x18
  public            System.Action                   action  // 0x20
  public            System.Action<System.Object>    actionUserData  // 0x28
METHODS:
  RVA=0x0350B670  token=0x600090F  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass27_0
TYPE:  sealed struct
TOKEN: 0x200012C
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.GenericDropdownMenu<>4__this  // 0x10
  public            System.Int32                    selectedIndex  // 0x18
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200012E
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01A64  token=0x6000914  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200012F
SIZE:  0x80
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x78
METHODS:
  RVA=0x09F02A6C  token=0x6000915  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F03968  token=0x6000916  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000132
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01ADC  token=0x600091E  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000133
SIZE:  0x80
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x70
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType>m_MessageType  // 0x78
METHODS:
  RVA=0x09F0296C  token=0x600091F  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F03CD0  token=0x6000920  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000135
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F018C0  token=0x6000934  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000136
SIZE:  0x70
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09F03DDC  token=0x6000935  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200013B
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01AA0  token=0x600094E  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200013C
SIZE:  0x90
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09F031C8  token=0x600094F  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200013E
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01B18  token=0x6000957  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200013F
SIZE:  0xD8
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09F031D0  token=0x6000958  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000141
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F018FC  token=0x600097B  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000142
SIZE:  0xA0
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_MinValue  // 0x80
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_MaxValue  // 0x88
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowLimit  // 0x90
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighLimit  // 0x98
METHODS:
  RVA=0x09F01BCC  token=0x600097C  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F03490  token=0x600097D  System.Void .ctor()
END_CLASS

CLASS: DragState
TYPE:  sealed struct
TOKEN: 0x2000143
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateNoThumb  // const
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateMinThumb  // const
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateMiddleThumb  // const
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateMaxThumb  // const
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000145
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01884  token=0x6000981  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000146
SIZE:  0x90
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09F031C8  token=0x6000982  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000148
SIZE:  0x98
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowValue  // 0x78
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighValue  // 0x80
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_Value  // 0x88
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Title  // 0x90
METHODS:
  RVA=0x09F027EC  token=0x6000990  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F03AE4  token=0x6000991  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200014A
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01A28  token=0x6000993  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200014C
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01B54  token=0x600099F  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200014D
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x88
METHODS:
  RVA=0x09F02288  token=0x60009A0  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F03120  token=0x60009A1  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200014F
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01974  token=0x60009A9  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000150
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Choices  // 0x88
METHODS:
  RVA=0x09F026FC  token=0x60009AA  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F0365C  token=0x60009AB  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000152
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F019EC  token=0x60009B1  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000153
SIZE:  0xA0
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlLongAttributeDescriptionm_Delay  // 0x90
  private           UnityEngine.UIElements.UxmlLongAttributeDescriptionm_Interval  // 0x98
METHODS:
  RVA=0x09F01D60  token=0x60009B2  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F039F8  token=0x60009B3  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000155
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01B90  token=0x60009CC  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000156
SIZE:  0x90
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowValue  // 0x70
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighValue  // 0x78
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection>m_Direction  // 0x80
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_Value  // 0x88
METHODS:
  RVA=0x09F020CC  token=0x60009CD  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F03704  token=0x60009CE  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200015A
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F01938  token=0x6000A1D  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200015B
SIZE:  0xD8
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollViewMode>m_ScrollViewMode  // 0x70
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.NestedInteractionKind>m_NestedInteractionKind  // 0x78
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowHorizontal  // 0x80
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowVertical  // 0x88
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility>m_HorizontalScrollerVisibility  // 0x90
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility>m_VerticalScrollerVisibility  // 0x98
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HorizontalPageSize  // 0xa0
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_VerticalPageSize  // 0xa8
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_MouseWheelScrollSize  // 0xb0
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.TouchScrollBehavior>m_TouchScrollBehavior  // 0xb8
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_ScrollDecelerationRate  // 0xc0
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_Elasticity  // 0xc8
  private           UnityEngine.UIElements.UxmlLongAttributeDescriptionm_ElasticAnimationIntervalMs  // 0xd0
METHODS:
  RVA=0x09F0236C  token=0x6000A1E  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F02B48  token=0x6000A1F  System.Void .ctor()
END_CLASS

CLASS: TouchScrollBehavior
TYPE:  sealed struct
TOKEN: 0x200015C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollBehaviorUnrestricted  // const
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollBehaviorElastic  // const
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollBehaviorClamped  // const
METHODS:
END_CLASS

CLASS: NestedInteractionKind
TYPE:  sealed struct
TOKEN: 0x200015D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollView.NestedInteractionKindDefault  // const
  public    static  UnityEngine.UIElements.ScrollView.NestedInteractionKindStopScrolling  // const
  public    static  UnityEngine.UIElements.ScrollView.NestedInteractionKindForwardScrolling  // const
METHODS:
END_CLASS

CLASS: TouchScrollingResult
TYPE:  sealed struct
TOKEN: 0x200015E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollingResultApply  // const
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollingResultForward  // const
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollingResultBlock  // const
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000160
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F019B0  token=0x6000A28  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000161
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowValue  // 0x88
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighValue  // 0x90
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_PageSize  // 0x98
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowInputField  // 0xa0
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection>m_Direction  // 0xa8
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Inverted  // 0xb0
METHODS:
  RVA=0x09F01E74  token=0x6000A29  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F031D8  token=0x6000A2A  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000163
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F15084  token=0x6000A35  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000164
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_LowValue  // 0x88
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_HighValue  // 0x90
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_PageSize  // 0x98
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowInputField  // 0xa0
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection>m_Direction  // 0xa8
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Inverted  // 0xb0
METHODS:
  RVA=0x09F151E0  token=0x6000A36  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F15ED0  token=0x6000A37  System.Void .ctor()
END_CLASS

CLASS: OnDetectFocusChangeFunction
TYPE:  sealed class
TOKEN: 0x2000167
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x6000A44  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x6000A45  System.Void Invoke()
END_CLASS

CLASS: OnIndexChangeFunction
TYPE:  sealed class
TOKEN: 0x2000168
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x6000A46  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x6000A47  System.Void Invoke()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200016A
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F14F94  token=0x6000A52  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200016B
SIZE:  0xC0
EXTENDS: UxmlTraits
FIELDS:
  private   static readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionk_Value  // static @ 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Multiline  // 0xb8
METHODS:
  RVA=0x09F15578  token=0x6000A53  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F15A90  token=0x6000A54  System.Void .ctor()
  RVA=0x09F15998  token=0x6000A55  System.Void .cctor()
END_CLASS

CLASS: TextInput
TYPE:  class
TOKEN: 0x200016C
SIZE:  0x428
EXTENDS: TextInputBase
FIELDS:
  private           System.Boolean                  m_Multiline  // 0x420
PROPERTIES:
  parentTextField  get=0x09F120D8
  multiline  get=0x03D89130  set=0x09F12168
  isPasswordField  set=0x09F12118
METHODS:
  RVA=0x09F11F5C  token=0x6000A59  System.Void SetTextAlign()
  RVA=0x03D89120  token=0x6000A5B  System.String StringToValue(System.String str)
  RVA=0x09F1200C  token=0x6000A5C  System.Void SyncTextEngine()
  RVA=0x09F117B0  token=0x6000A5D  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F11DF8  token=0x6000A5E  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1209C  token=0x6000A5F  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200016F
EXTENDS: UnityEngine.UIElements.BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_MaxLength  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Password  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_MaskCharacter  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_IsReadOnly  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_IsDelayed  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000A7B  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6000A7C  System.Void .ctor()
END_CLASS

CLASS: TextInputBase
TYPE:  abstract class
TOKEN: 0x2000170
EXTENDS: UnityEngine.UIElements.VisualElement
IMPLEMENTS: UnityEngine.UIElements.ITextInputField UnityEngine.UIElements.IEventHandler UnityEngine.UIElements.ITextElement
FIELDS:
  private           System.String                   m_OriginalText  // 0x0
  private           System.Boolean                  <isReadOnly>k__BackingField  // 0x0
  private           System.Int32                    <maxLength>k__BackingField  // 0x0
  private           System.Char                     <maskChar>k__BackingField  // 0x0
  private           System.Boolean                  <isPasswordField>k__BackingField  // 0x0
  private           System.Boolean                  <doubleClickSelectsWord>k__BackingField  // 0x0
  private           System.Boolean                  <tripleClickSelectsLine>k__BackingField  // 0x0
  private           System.Boolean                  <isDelayed>k__BackingField  // 0x0
  private           System.Boolean                  <isDragging>k__BackingField  // 0x0
  private           System.Boolean                  m_TouchScreenTextFieldInitialized  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_HardwareKeyboardPoller  // 0x0
  private           UnityEngine.Color               m_SelectionColor  // 0x0
  private           UnityEngine.Color               m_CursorColor  // 0x0
  private           UnityEngine.UIElements.TextEditorEventHandler<editorEventHandler>k__BackingField  // 0x0
  private           UnityEngine.UIElements.TextEditorEngine<editorEngine>k__BackingField  // 0x0
  private           UnityEngine.UIElements.ITextHandlem_TextHandle  // 0x0
  private           System.String                   m_Text  // 0x0
PROPERTIES:
  UnityEngine.UIElements.ITextInputField.isReadOnly  get=-1  // not resolved
  isReadOnly  get=-1  // not resolved  set=-1  // not resolved
  maxLength  get=-1  // not resolved  set=-1  // not resolved
  maskChar  get=-1  // not resolved  set=-1  // not resolved
  isPasswordField  get=-1  // not resolved  set=-1  // not resolved
  doubleClickSelectsWord  get=-1  // not resolved  set=-1  // not resolved
  tripleClickSelectsLine  get=-1  // not resolved  set=-1  // not resolved
  isDelayed  get=-1  // not resolved  set=-1  // not resolved
  isDragging  get=-1  // not resolved
  touchScreenTextField  get=-1  // not resolved
  touchScreenTextFieldChanged  get=-1  // not resolved
  selectionColor  get=-1  // not resolved
  cursorColor  get=-1  // not resolved
  hasFocus  get=-1  // not resolved
  editorEventHandler  get=-1  // not resolved  set=-1  // not resolved
  editorEngine  get=-1  // not resolved  set=-1  // not resolved
  text  get=-1  // not resolved  set=-1  // not resolved
  UnityEngine.UIElements.ITextInputField.hasFocus  get=-1  // not resolved
  UnityEngine.UIElements.ITextInputField.editorEngine  get=-1  // not resolved
  UnityEngine.UIElements.ITextInputField.isDelayed  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000A7D  System.Void ResetValueAndText()
  RVA=-1  // not resolved  token=0x6000A7E  System.Void SaveValueAndText()
  RVA=-1  // not resolved  token=0x6000A7F  System.Void RestoreValueAndText()
  RVA=-1  // not resolved  token=0x6000A80  System.Void UpdateText(System.String value)
  RVA=-1  // not resolved  token=0x6000A81  TValueType StringToValue(System.String str)
  RVA=-1  // not resolved  token=0x6000A82  System.Void UpdateValueFromText()
  RVA=-1  // not resolved  token=0x6000A9E  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000A9F  System.Void InitTextEditorEventHandler()
  RVA=-1  // not resolved  token=0x6000AA0  UnityEngine.UIElements.DropdownMenuAction.Status CutActionStatus(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=-1  // not resolved  token=0x6000AA1  UnityEngine.UIElements.DropdownMenuAction.Status CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=-1  // not resolved  token=0x6000AA2  UnityEngine.UIElements.DropdownMenuAction.Status PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=-1  // not resolved  token=0x6000AA3  System.Void ProcessMenuCommand(System.String command)
  RVA=-1  // not resolved  token=0x6000AA4  System.Void Cut(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=-1  // not resolved  token=0x6000AA5  System.Void Copy(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=-1  // not resolved  token=0x6000AA6  System.Void Paste(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=-1  // not resolved  token=0x6000AA7  System.Void OnInputCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  RVA=-1  // not resolved  token=0x6000AA8  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent attachEvent)
  RVA=-1  // not resolved  token=0x6000AA9  System.Void SyncTextEngine()
  RVA=-1  // not resolved  token=0x6000AAA  System.String CullString(System.String s)
  RVA=-1  // not resolved  token=0x6000AAB  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  RVA=-1  // not resolved  token=0x6000AAC  System.Void DrawWithTextSelectionAndCursor(UnityEngine.UIElements.MeshGenerationContext mgc, System.String newText, System.Single pixelsPerPoint)
  RVA=-1  // not resolved  token=0x6000AAD  System.Boolean AcceptCharacter(System.Char c)
  RVA=-1  // not resolved  token=0x6000AAE  System.Void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent evt)
  RVA=-1  // not resolved  token=0x6000AAF  System.Void OnDetectFocusChange()
  RVA=-1  // not resolved  token=0x6000AB0  System.Void OnCursorIndexChange()
  RVA=-1  // not resolved  token=0x6000AB1  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=-1  // not resolved  token=0x6000AB2  System.Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // not resolved  token=0x6000AB3  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // not resolved  token=0x6000AB4  System.Void ProcessEventAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // not resolved  token=0x6000AB5  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // not resolved  token=0x6000AB7  System.Void UnityEngine.UIElements.ITextInputField.SyncTextEngine()
  RVA=-1  // not resolved  token=0x6000AB8  System.Boolean UnityEngine.UIElements.ITextInputField.AcceptCharacter(System.Char c)
  RVA=-1  // not resolved  token=0x6000AB9  System.String UnityEngine.UIElements.ITextInputField.CullString(System.String s)
  RVA=-1  // not resolved  token=0x6000ABA  System.Void UnityEngine.UIElements.ITextInputField.UpdateText(System.String value)
  RVA=-1  // not resolved  token=0x6000ABD  System.Void UnityEngine.UIElements.ITextInputField.UpdateValueFromText()
  RVA=-1  // not resolved  token=0x6000ABE  System.Void DeferGUIStyleRectSync()
  RVA=-1  // not resolved  token=0x6000ABF  System.Void OnPercentResolved(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=-1  // not resolved  token=0x6000AC0  System.Void SyncGUIStyle(UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInput, UnityEngine.GUIStyle style)
  RVA=-1  // not resolved  token=0x6000AC1  System.Boolean IsLayoutUsingPercent(UnityEngine.UIElements.VisualElement ve)
  RVA=-1  // not resolved  token=0x6000AC2  System.Void AssignRect(UnityEngine.RectOffset rect, System.Int32 left, System.Int32 top, System.Int32 right, System.Int32 bottom)
  RVA=-1  // not resolved  token=0x6000AC3  System.Void <ProcessEventAtTarget>b__99_0()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000172
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F14FD0  token=0x6000AC8  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000173
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x88
METHODS:
  RVA=0x09F150FC  token=0x6000AC9  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F16190  token=0x6000ACA  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000176
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F14F58  token=0x6000AD9  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000177
SIZE:  0xB8
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  RVA=0x09F16188  token=0x6000ADA  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200017D
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F15048  token=0x6000B07  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200017E
SIZE:  0x88
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_FixedPaneIndex  // 0x70
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_FixedPaneInitialDimension  // 0x78
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation>m_Orientation  // 0x80
METHODS:
  RVA=0x09F156F0  token=0x6000B08  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F15B38  token=0x6000B09  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x2000183
EXTENDS: UnityEngine.UIElements.UxmlObjectFactory`2
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000B45  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass15_0
TYPE:  sealed class
TOKEN: 0x2000185
FIELDS:
  public            UnityEngine.UIElements.VisualTreeAssetasset  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000B49  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000B4A  UnityEngine.UIElements.VisualElement <Init>b__0()
END_CLASS

CLASS: <>c__DisplayClass15_1
TYPE:  sealed class
TOKEN: 0x2000186
FIELDS:
  public            UnityEngine.UIElements.VisualTreeAssetasset  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000B4B  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000B4C  UnityEngine.UIElements.VisualElement <Init>b__1()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x2000184
EXTENDS: UnityEngine.UIElements.UxmlObjectTraits`1
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Visible  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Width  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_MinWidth  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_MaxWidth  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Stretch  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Sortable  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Optional  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Resizable  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_HeaderTemplateId  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_CellTemplateId  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000B46  UnityEngine.UIElements.Length ParseLength(System.String str, UnityEngine.UIElements.Length defaultValue)
  RVA=-1  // not resolved  token=0x6000B47  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6000B48  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass53_0
TYPE:  sealed class
TOKEN: 0x2000188
SIZE:  0x20
FIELDS:
  public            System.Single                   totalColumnWidth  // 0x10
  public            UnityEngine.UIElements.ColumnLayout<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000B77  System.Void .ctor()
  RVA=0x09F14EB4  token=0x6000B78  System.Void <RecomputeToMaxWidthProportionally>b__1(UnityEngine.UIElements.Column c)
END_CLASS

CLASS: <>c__DisplayClass54_0
TYPE:  sealed class
TOKEN: 0x2000189
SIZE:  0x20
FIELDS:
  public            System.Single                   totalColumnsWidth  // 0x10
  public            UnityEngine.UIElements.ColumnLayout<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000B79  System.Void .ctor()
  RVA=0x09F14EB4  token=0x6000B7A  System.Void <RecomputeToMinWidthProportionally>b__1(UnityEngine.UIElements.Column c)
END_CLASS

CLASS: StretchMode
TYPE:  sealed struct
TOKEN: 0x200018C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Columns.StretchModeGrow  // const
  public    static  UnityEngine.UIElements.Columns.StretchModeGrowAndFill  // const
METHODS:
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x200018D
EXTENDS: UnityEngine.UIElements.UxmlObjectFactory`2
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000BAA  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x200018E
EXTENDS: UnityEngine.UIElements.UxmlObjectTraits`1
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionm_PrimaryColumnName  // 0x0
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.Columns.StretchMode>m_StretchMode  // 0x0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Reorderable  // 0x0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Resizable  // 0x0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ResizePreview  // 0x0
  private   readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.Column>m_Columns  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BAB  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6000BAC  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200018F
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.Columns.<>c<>9  // static @ 0x0
  public    static  System.Predicate<UnityEngine.UIElements.Column><>9__76_0  // static @ 0x8
METHODS:
  RVA=0x09F14EF4  token=0x6000BAD  System.Void .cctor()
  RVA=0x0350B670  token=0x6000BAE  System.Void .ctor()
  RVA=0x09F14E9C  token=0x6000BAF  System.Boolean <UpdateVisibleColumns>b__76_0(UnityEngine.UIElements.Column c)
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000192
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F1500C  token=0x6000BDB  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000193
SIZE:  0xF0
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_SortingEnabled  // 0xd8
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns>m_Columns  // 0xe0
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions>m_SortColumnDescriptions  // 0xe8
METHODS:
  RVA=0x09F15430  token=0x6000BDC  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F15CB0  token=0x6000BDD  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000195
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=0x09F150C0  token=0x6000BEB  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000196
SIZE:  0xD0
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_SortingEnabled  // 0xb8
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns>m_Columns  // 0xc0
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions>m_SortColumnDescriptions  // 0xc8
METHODS:
  RVA=0x09F15850  token=0x6000BEC  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F15DC0  token=0x6000BED  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x2000199
EXTENDS: UnityEngine.UIElements.UxmlObjectFactory`2
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000BFB  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x200019A
EXTENDS: UnityEngine.UIElements.UxmlObjectTraits`1
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ColumnName  // 0x0
  private   readonly UnityEngine.UIElements.UxmlIntAttributeDescriptionm_ColumnIndex  // 0x0
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SortDirection>m_SortDescription  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000BFC  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6000BFD  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x200019C
EXTENDS: UnityEngine.UIElements.UxmlObjectFactory`2
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000C0C  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x200019D
EXTENDS: UnityEngine.UIElements.UxmlObjectTraits`1
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.SortColumnDescription>m_SortColumnDescriptions  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000C0D  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6000C0E  System.Void .ctor()
END_CLASS

CLASS: DragState
TYPE:  sealed struct
TOKEN: 0x20001A2
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DragEventsProcessor.DragStateNone  // const
  public    static  UnityEngine.UIElements.DragEventsProcessor.DragStateCanStartDrag  // const
  public    static  UnityEngine.UIElements.DragEventsProcessor.DragStateDragging  // const
METHODS:
END_CLASS

CLASS: DragPosition
TYPE:  sealed struct
TOKEN: 0x20001B1
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.Int32                    insertAtIndex  // 0x10
  public            System.Int32                    parentId  // 0x14
  public            System.Int32                    childIndex  // 0x18
  public            UnityEngine.UIElements.ReusableCollectionItemrecycledItem  // 0x20
  public            UnityEngine.UIElements.DragAndDropPositiondropPosition  // 0x28
METHODS:
  RVA=0x09F1731C  token=0x6000C7E  System.Boolean Equals(UnityEngine.UIElements.ListViewDragger.DragPosition other)
  RVA=0x09F1729C  token=0x6000C7F  System.Boolean Equals(System.Object obj)
  RVA=0x09F17380  token=0x6000C80  System.Int32 GetHashCode()
END_CLASS

CLASS: DropData
TYPE:  class
TOKEN: 0x20001B6
SIZE:  0x30
FIELDS:
  public            System.Int32[]                  expandedIdsBeforeDrag  // 0x10
  public            System.Int32[]                  draggedIds  // 0x18
  public            System.Int32                    lastItemId  // 0x20
  public            System.Single                   expandItemBeginTimerMs  // 0x24
  public            UnityEngine.Vector2             expandItemBeginPosition  // 0x28
METHODS:
  RVA=0x03D5C2D0  token=0x6000C9B  System.Void .ctor()
END_CLASS

CLASS: TreeItemState
TYPE:  sealed struct
TOKEN: 0x20001B7
SIZE:  0x18
FIELDS:
  public            System.Int32                    parentId  // 0x10
  public            System.Int32                    childIndex  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x6000C9C  System.Void .ctor(System.Int32 parentId, System.Int32 childIndex)
END_CLASS

CLASS: EventPropagation
TYPE:  sealed struct
TOKEN: 0x20001C8
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.EventBase.EventPropagationNone  // const
  public    static  UnityEngine.UIElements.EventBase.EventPropagationBubbles  // const
  public    static  UnityEngine.UIElements.EventBase.EventPropagationTricklesDown  // const
  public    static  UnityEngine.UIElements.EventBase.EventPropagationCancellable  // const
  public    static  UnityEngine.UIElements.EventBase.EventPropagationSkipDisabledElements  // const
  public    static  UnityEngine.UIElements.EventBase.EventPropagationIgnoreCompositeRoots  // const
METHODS:
END_CLASS

CLASS: LifeCycleStatus
TYPE:  sealed struct
TOKEN: 0x20001C9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusNone  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusPropagationStopped  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusImmediatePropagationStopped  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusDefaultPrevented  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusDispatching  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusPooled  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusIMGUIEventIsValid  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusStopDispatch  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusPropagateToIMGUI  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusDispatched  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusProcessed  // const
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusProcessedByFocusController  // const
METHODS:
END_CLASS

CLASS: EventBehavior
TYPE:  sealed struct
TOKEN: 0x20001E7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehaviorNone  // const
  public    static  UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehaviorIsCapturable  // const
  public    static  UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehaviorIsSentExclusivelyToCapturingElement  // const
METHODS:
END_CLASS

CLASS: Direction
TYPE:  sealed struct
TOKEN: 0x20001FF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionNone  // const
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionLeft  // const
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionUp  // const
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionRight  // const
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionDown  // const
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionNext  // const
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionPrevious  // const
METHODS:
END_CLASS

CLASS: Direction
TYPE:  sealed struct
TOKEN: 0x2000201
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.NavigationTabEvent.DirectionNone  // const
  public    static  UnityEngine.UIElements.NavigationTabEvent.DirectionNext  // const
  public    static  UnityEngine.UIElements.NavigationTabEvent.DirectionPrevious  // const
METHODS:
END_CLASS

CLASS: LocationFlag
TYPE:  sealed struct
TOKEN: 0x2000209
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PointerDeviceState.LocationFlagNone  // const
  public    static  UnityEngine.UIElements.PointerDeviceState.LocationFlagOutsidePanel  // const
METHODS:
END_CLASS

CLASS: PointerLocation
TYPE:  sealed struct
TOKEN: 0x200020A
SIZE:  0x28
FIELDS:
  private           UnityEngine.Vector2             <Position>k__BackingField  // 0x10
  private           UnityEngine.UIElements.IPanel   <Panel>k__BackingField  // 0x18
  private           UnityEngine.UIElements.PointerDeviceState.LocationFlag<Flags>k__BackingField  // 0x20
PROPERTIES:
  Position  get=0x020C61B0  set=0x03D51730
  Panel  get=0x03D50DE0  set=0x0558FF08
  Flags  get=0x03D4E340  set=0x010410F0
METHODS:
  RVA=0x09F214EC  token=0x6000E52  System.Void SetLocation(UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x200021C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PropagationPaths.TypeNone  // const
  public    static  UnityEngine.UIElements.PropagationPaths.TypeTrickleDown  // const
  public    static  UnityEngine.UIElements.PropagationPaths.TypeBubbleUp  // const
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  sealed struct
TOKEN: 0x2000220
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName>m_Enumerator  // 0x10
PROPERTIES:
  Current  get=0x09F18700
  System.Collections.IEnumerator.Current  get=0x09F18694
METHODS:
  RVA=0x09F186EC  token=0x6000EE2  System.Void .ctor(System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> enumerator)
  RVA=0x09F18658  token=0x6000EE3  System.Boolean MoveNext()
  RVA=0x0350B670  token=0x6000EE6  System.Void Reset()
  RVA=0x09F18630  token=0x6000EE7  System.Void Dispose()
END_CLASS

CLASS: ChangeDirection
TYPE:  class
TOKEN: 0x200022E
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.FocusChangeDirection
FIELDS:
METHODS:
  RVA=0x09F16798  token=0x6000F12  System.Void .ctor(System.Int32 i)
END_CLASS

CLASS: FocusableHierarchyTraversal
TYPE:  sealed struct
TOKEN: 0x200022F
SIZE:  0x38
FIELDS:
  public            UnityEngine.UIElements.VisualElementcurrentFocusable  // 0x10
  public            UnityEngine.Rect                validRect  // 0x18
  public            System.Boolean                  firstPass  // 0x28
  public            UnityEngine.UIElements.NavigateFocusRing.ChangeDirectiondirection  // 0x30
METHODS:
  RVA=0x09F1AB40  token=0x6000F13  System.Boolean ValidateHierarchyTraversal(UnityEngine.UIElements.VisualElement v)
  RVA=0x09F1AAA0  token=0x6000F14  System.Boolean ValidateElement(UnityEngine.UIElements.VisualElement v)
  RVA=0x09F1A718  token=0x6000F15  System.Int32 Order(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b)
  RVA=0x09F1A7C8  token=0x6000F16  System.Int32 StrictOrder(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b)
  RVA=0x09F1A844  token=0x6000F17  System.Int32 StrictOrder(UnityEngine.Rect ra, UnityEngine.Rect rb)
  RVA=0x09F1A990  token=0x6000F18  System.Int32 TieBreaker(UnityEngine.Rect ra, UnityEngine.Rect rb)
  RVA=0x09F1A61C  token=0x6000F19  UnityEngine.UIElements.VisualElement GetBestOverall(UnityEngine.UIElements.VisualElement candidate, UnityEngine.UIElements.VisualElement bestSoFar)
END_CLASS

CLASS: RuntimePanelAccess
TYPE:  class
TOKEN: 0x2000233
SIZE:  0x20
FIELDS:
  private   readonly UnityEngine.UIElements.PanelSettingsm_Settings  // 0x10
  private           UnityEngine.UIElements.BaseRuntimePanelm_RuntimePanel  // 0x18
PROPERTIES:
  isInitialized  get=0x02702DB0
  panel  get=0x09F22754
METHODS:
  RVA=0x0426FEE0  token=0x6000F4C  System.Void .ctor(UnityEngine.UIElements.PanelSettings settings)
  RVA=0x09F225E8  token=0x6000F4F  System.Void DisposePanel()
  RVA=0x09F22718  token=0x6000F50  System.Void SetTargetTexture()
  RVA=0x09F226BC  token=0x6000F51  System.Void SetSortingPriority()
  RVA=0x09F226EC  token=0x6000F52  System.Void SetTargetDisplay()
  RVA=0x09F22534  token=0x6000F53  UnityEngine.UIElements.BaseRuntimePanel CreateRelatedRuntimePanel()
  RVA=0x09F2261C  token=0x6000F54  System.Void DisposeRelatedPanel()
  RVA=0x09F2266C  token=0x6000F55  System.Void MarkPotentiallyEmpty()
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x2000239
SIZE:  0x28
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.Row>s_Pool  // static @ 0x0
  private           System.Int32                    <offsetX>k__BackingField  // 0x10
  private           System.Int32                    <offsetY>k__BackingField  // 0x14
  private           System.Int32                    <width>k__BackingField  // 0x18
  private           System.Int32                    <height>k__BackingField  // 0x1c
  public            System.Int32                    Cursor  // 0x20
PROPERTIES:
  offsetX  get=0x03D4E340  set=0x010410F0
  offsetY  get=0x03D50CC0  set=0x03D595B0
  width  get=0x020D1AC0  set=0x03D4E9C0
  height  set=0x03D4EBC0
METHODS:
  RVA=0x09F3E9C0  token=0x6000F96  UnityEngine.UIElements.UIRAtlasAllocator.Row Acquire(System.Int32 offsetX, System.Int32 offsetY, System.Int32 width, System.Int32 height)
  RVA=0x09F3EA64  token=0x6000F97  System.Void Release()
  RVA=0x0350B670  token=0x6000F98  System.Void .ctor()
  RVA=0x09F3EAE4  token=0x6000F99  System.Void .cctor()
END_CLASS

CLASS: AreaNode
TYPE:  class
TOKEN: 0x200023A
SIZE:  0x30
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.AreaNode>s_Pool  // static @ 0x0
  public            UnityEngine.RectInt             rect  // 0x10
  public            UnityEngine.UIElements.UIRAtlasAllocator.AreaNodeprevious  // 0x20
  public            UnityEngine.UIElements.UIRAtlasAllocator.AreaNodenext  // 0x28
METHODS:
  RVA=0x09F3570C  token=0x6000F9A  UnityEngine.UIElements.UIRAtlasAllocator.AreaNode Acquire(UnityEngine.RectInt rect)
  RVA=0x09F3586C  token=0x6000F9B  System.Void Release()
  RVA=0x09F358DC  token=0x6000F9C  System.Void RemoveFromChain()
  RVA=0x09F357A8  token=0x6000F9D  System.Void AddAfter(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous)
  RVA=0x0350B670  token=0x6000F9E  System.Void .ctor()
  RVA=0x09F3593C  token=0x6000F9F  System.Void .cctor()
END_CLASS

CLASS: BorderParams
TYPE:  sealed struct
TOKEN: 0x2000241
SIZE:  0xC8
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            UnityEngine.Color               playmodeTintColor  // 0x20
  public            UnityEngine.Color               leftColor  // 0x30
  public            UnityEngine.Color               topColor  // 0x40
  public            UnityEngine.Color               rightColor  // 0x50
  public            UnityEngine.Color               bottomColor  // 0x60
  public            System.Single                   leftWidth  // 0x70
  public            System.Single                   topWidth  // 0x74
  public            System.Single                   rightWidth  // 0x78
  public            System.Single                   bottomWidth  // 0x7c
  public            UnityEngine.Vector2             topLeftRadius  // 0x80
  public            UnityEngine.Vector2             topRightRadius  // 0x88
  public            UnityEngine.Vector2             bottomRightRadius  // 0x90
  public            UnityEngine.Vector2             bottomLeftRadius  // 0x98
  public            UnityEngine.Material            material  // 0xa0
  private           UnityEngine.UIElements.ColorPageleftColorPage  // 0xa8
  private           UnityEngine.UIElements.ColorPagetopColorPage  // 0xb0
  private           UnityEngine.UIElements.ColorPagerightColorPage  // 0xb8
  private           UnityEngine.UIElements.ColorPagebottomColorPage  // 0xc0
METHODS:
END_CLASS

CLASS: RectangleParams
TYPE:  sealed struct
TOKEN: 0x2000242
SIZE:  0xD8
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            UnityEngine.Rect                uv  // 0x20
  public            UnityEngine.Color               color  // 0x30
  public            UnityEngine.Texture             texture  // 0x40
  public            UnityEngine.Sprite              sprite  // 0x48
  public            UnityEngine.UIElements.VectorImagevectorImage  // 0x50
  public            UnityEngine.Material            material  // 0x58
  public            UnityEngine.ScaleMode           scaleMode  // 0x60
  public            UnityEngine.Color               playmodeTintColor  // 0x64
  public            UnityEngine.Vector2             topLeftRadius  // 0x74
  public            UnityEngine.Vector2             topRightRadius  // 0x7c
  public            UnityEngine.Vector2             bottomRightRadius  // 0x84
  public            UnityEngine.Vector2             bottomLeftRadius  // 0x8c
  public            System.Int32                    leftSlice  // 0x94
  public            System.Int32                    topSlice  // 0x98
  public            System.Int32                    rightSlice  // 0x9c
  public            System.Int32                    bottomSlice  // 0xa0
  public            System.Single                   sliceScale  // 0xa4
  private           UnityEngine.Rect                spriteGeomRect  // 0xa8
  public            UnityEngine.Vector4             rectInset  // 0xb8
  private           UnityEngine.UIElements.ColorPagecolorPage  // 0xc8
  private           UnityEngine.UIElements.MeshGenerationContext.MeshFlagsmeshFlags  // 0xd0
METHODS:
  RVA=0x09F3D260  token=0x6000FC8  System.Void AdjustUVsForScaleMode(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.Rect& rectOut, UnityEngine.Rect& uvOut)
  RVA=0x09F3CAB8  token=0x6000FC9  System.Void AdjustSpriteUVsForScaleMode(UnityEngine.Rect containerRect, UnityEngine.Rect srcRect, UnityEngine.Rect spriteGeomRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.Rect& rectOut, UnityEngine.Rect& uvOut)
  RVA=0x09F3E434  token=0x6000FCA  UnityEngine.Rect RectIntersection(UnityEngine.Rect a, UnityEngine.Rect b)
  RVA=0x09F3D618  token=0x6000FCB  UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite sprite)
  RVA=0x09F3D75C  token=0x6000FCC  UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite sprite)
  RVA=0x09F3D468  token=0x6000FCD  UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect uv, UnityEngine.SpritePackingRotation rotation)
  RVA=0x09F3E0F8  token=0x6000FCE  UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext)
  RVA=0x09F3D900  token=0x6000FCF  UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeSprite(UnityEngine.Rect containerRect, UnityEngine.Rect subRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext, System.Boolean hasRadius, UnityEngine.Vector4& slices)
  RVA=0x09F3E2B0  token=0x6000FD0  UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeVectorTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.UIElements.VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext)
  RVA=0x09F3D8A0  token=0x6000FD1  System.Boolean HasRadius(System.Single epsilon)
END_CLASS

CLASS: TextParams
TYPE:  sealed struct
TOKEN: 0x2000243
SIZE:  0xA8
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            System.String                   text  // 0x20
  public            UnityEngine.Font                font  // 0x28
  public            UnityEngine.UIElements.FontDefinitionfontDefinition  // 0x30
  public            System.Int32                    fontSize  // 0x40
  public            UnityEngine.UIElements.Length   letterSpacing  // 0x44
  public            UnityEngine.UIElements.Length   wordSpacing  // 0x4c
  public            UnityEngine.UIElements.Length   paragraphSpacing  // 0x54
  public            UnityEngine.FontStyle           fontStyle  // 0x5c
  public            UnityEngine.Color               fontColor  // 0x60
  public            UnityEngine.TextAnchor          anchor  // 0x70
  public            System.Boolean                  wordWrap  // 0x74
  public            System.Single                   wordWrapWidth  // 0x78
  public            System.Boolean                  richText  // 0x7c
  public            UnityEngine.Color               playmodeTintColor  // 0x80
  public            UnityEngine.UIElements.TextOverflowtextOverflow  // 0x90
  public            UnityEngine.UIElements.TextOverflowPositiontextOverflowPosition  // 0x94
  public            UnityEngine.UIElements.OverflowInternaloverflow  // 0x98
  public            UnityEngine.UIElements.IPanel   panel  // 0xa0
METHODS:
  RVA=0x09F409A8  token=0x6000FD2  System.Int32 GetHashCode()
  RVA=0x09F40F74  token=0x6000FD3  UnityEngine.UIElements.MeshGenerationContextUtils.TextParams MakeStyleBased(UnityEngine.UIElements.VisualElement ve, System.String text)
  RVA=0x09F40B7C  token=0x6000FD4  UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single scaling)
END_CLASS

CLASS: MeshFlags
TYPE:  sealed struct
TOKEN: 0x2000245
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MeshGenerationContext.MeshFlagsNone  // const
  public    static  UnityEngine.UIElements.MeshGenerationContext.MeshFlagsUVisDisplacement  // const
  public    static  UnityEngine.UIElements.MeshGenerationContext.MeshFlagsSkipDynamicAtlas  // const
METHODS:
END_CLASS

CLASS: TextureInfo
TYPE:  sealed struct
TOKEN: 0x2000249
SIZE:  0x20
FIELDS:
  public            UnityEngine.Texture             texture  // 0x10
  public            System.Boolean                  dynamic  // 0x18
  public            System.Int32                    refCount  // 0x1c
METHODS:
END_CLASS

CLASS: Unit
TYPE:  sealed struct
TOKEN: 0x200024D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Angle.UnitDegree  // const
  public    static  UnityEngine.UIElements.Angle.UnitGradian  // const
  public    static  UnityEngine.UIElements.Angle.UnitRadian  // const
  public    static  UnityEngine.UIElements.Angle.UnitTurn  // const
  public    static  UnityEngine.UIElements.Angle.UnitNone  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000252
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.ComputedTransitionUtils.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Single,System.Single><>9__12_0  // static @ 0x8
  public    static  System.Func<System.Single,System.Single><>9__12_1  // static @ 0x10
  public    static  System.Func<System.Single,System.Single><>9__12_2  // static @ 0x18
  public    static  System.Func<System.Single,System.Single><>9__12_3  // static @ 0x20
  public    static  System.Func<System.Single,System.Single><>9__12_4  // static @ 0x28
  public    static  System.Func<System.Single,System.Single><>9__12_5  // static @ 0x30
  public    static  System.Func<System.Single,System.Single><>9__12_6  // static @ 0x38
  public    static  System.Func<System.Single,System.Single><>9__12_7  // static @ 0x40
  public    static  System.Func<System.Single,System.Single><>9__12_8  // static @ 0x48
  public    static  System.Func<System.Single,System.Single><>9__12_9  // static @ 0x50
  public    static  System.Func<System.Single,System.Single><>9__12_10  // static @ 0x58
  public    static  System.Func<System.Single,System.Single><>9__12_11  // static @ 0x60
  public    static  System.Func<System.Single,System.Single><>9__12_12  // static @ 0x68
  public    static  System.Func<System.Single,System.Single><>9__12_13  // static @ 0x70
  public    static  System.Func<System.Single,System.Single><>9__12_14  // static @ 0x78
  public    static  System.Func<System.Single,System.Single><>9__12_15  // static @ 0x80
  public    static  System.Func<System.Single,System.Single><>9__12_16  // static @ 0x88
  public    static  System.Func<System.Single,System.Single><>9__12_17  // static @ 0x90
  public    static  System.Func<System.Single,System.Single><>9__12_18  // static @ 0x98
  public    static  System.Func<System.Single,System.Single><>9__12_19  // static @ 0xa0
  public    static  System.Func<System.Single,System.Single><>9__12_20  // static @ 0xa8
  public    static  System.Func<System.Single,System.Single><>9__12_21  // static @ 0xb0
  public    static  System.Func<System.Single,System.Single><>9__12_22  // static @ 0xb8
METHODS:
  RVA=0x09F428B0  token=0x60010AC  System.Void .cctor()
  RVA=0x0350B670  token=0x60010AD  System.Void .ctor()
  RVA=0x03D89540  token=0x60010AE  System.Single <ConvertTransitionFunction>b__12_0(System.Single t)
  RVA=0x03D89600  token=0x60010AF  System.Single <ConvertTransitionFunction>b__12_1(System.Single t)
  RVA=0x03D89610  token=0x60010B0  System.Single <ConvertTransitionFunction>b__12_2(System.Single t)
  RVA=0x09F42878  token=0x60010B1  System.Single <ConvertTransitionFunction>b__12_3(System.Single t)
  RVA=0x03D89630  token=0x60010B2  System.Single <ConvertTransitionFunction>b__12_4(System.Single t)
  RVA=0x03D89640  token=0x60010B3  System.Single <ConvertTransitionFunction>b__12_5(System.Single t)
  RVA=0x03D89670  token=0x60010B4  System.Single <ConvertTransitionFunction>b__12_6(System.Single t)
  RVA=0x03D89690  token=0x60010B5  System.Single <ConvertTransitionFunction>b__12_7(System.Single t)
  RVA=0x03D896D0  token=0x60010B6  System.Single <ConvertTransitionFunction>b__12_8(System.Single t)
  RVA=0x09F42884  token=0x60010B7  System.Single <ConvertTransitionFunction>b__12_9(System.Single t)
  RVA=0x09F427A4  token=0x60010B8  System.Single <ConvertTransitionFunction>b__12_10(System.Single t)
  RVA=0x03D89570  token=0x60010B9  System.Single <ConvertTransitionFunction>b__12_11(System.Single t)
  RVA=0x03D895D0  token=0x60010BA  System.Single <ConvertTransitionFunction>b__12_12(System.Single t)
  RVA=0x09F427B8  token=0x60010BB  System.Single <ConvertTransitionFunction>b__12_13(System.Single t)
  RVA=0x09F427C4  token=0x60010BC  System.Single <ConvertTransitionFunction>b__12_14(System.Single t)
  RVA=0x09F427D0  token=0x60010BD  System.Single <ConvertTransitionFunction>b__12_15(System.Single t)
  RVA=0x09F427DC  token=0x60010BE  System.Single <ConvertTransitionFunction>b__12_16(System.Single t)
  RVA=0x09F427E8  token=0x60010BF  System.Single <ConvertTransitionFunction>b__12_17(System.Single t)
  RVA=0x09F427F4  token=0x60010C0  System.Single <ConvertTransitionFunction>b__12_18(System.Single t)
  RVA=0x09F42824  token=0x60010C1  System.Single <ConvertTransitionFunction>b__12_19(System.Single t)
  RVA=0x09F42830  token=0x60010C2  System.Single <ConvertTransitionFunction>b__12_20(System.Single t)
  RVA=0x09F42860  token=0x60010C3  System.Single <ConvertTransitionFunction>b__12_21(System.Single t)
  RVA=0x09F4286C  token=0x60010C4  System.Single <ConvertTransitionFunction>b__12_22(System.Single t)
END_CLASS

CLASS: InlineRule
TYPE:  sealed struct
TOKEN: 0x200025A
SIZE:  0x28
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleRulerule  // 0x18
  public            UnityEngine.UIElements.StyleSheets.StylePropertyId[]propertyIds  // 0x20
METHODS:
END_CLASS

CLASS: Unit
TYPE:  sealed struct
TOKEN: 0x200025D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Length.UnitPixel  // const
  public    static  UnityEngine.UIElements.Length.UnitPercent  // const
  public    static  UnityEngine.UIElements.Length.UnitAuto  // const
  public    static  UnityEngine.UIElements.Length.UnitNone  // const
METHODS:
END_CLASS

CLASS: RefCounted
TYPE:  class
TOKEN: 0x2000263
FIELDS:
  private   static  System.UInt32                   m_NextId  // static @ 0x0
  private           System.Int32                    m_RefCount  // 0x0
  private   readonly System.UInt32                   m_Id  // 0x0
  public            T                               value  // 0x0
PROPERTIES:
  refCount  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600117E  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600117F  System.Void Acquire()
  RVA=-1  // not resolved  token=0x6001180  System.Void Release()
  RVA=-1  // not resolved  token=0x6001181  UnityEngine.UIElements.StyleDataRef.RefCounted<T> Copy()
  RVA=-1  // not resolved  token=0x6001182  System.Void .cctor()
END_CLASS

CLASS: <hashes>e__FixedBuffer
TYPE:  sealed struct
TOKEN: 0x200027E
SIZE:  0x20
FIELDS:
  public            System.Int32                    FixedElementField  // 0x10
METHODS:
END_CLASS

CLASS: PseudoStateData
TYPE:  sealed struct
TOKEN: 0x2000280
SIZE:  0x18
FIELDS:
  public    readonly UnityEngine.UIElements.PseudoStatesstate  // 0x10
  public    readonly System.Boolean                  negate  // 0x14
METHODS:
  RVA=0x03D58750  token=0x60012A9  System.Void .ctor(UnityEngine.UIElements.PseudoStates state, System.Boolean negate)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000281
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.StyleComplexSelector.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.StyleSelector,System.String><>9__24_0  // static @ 0x8
METHODS:
  RVA=0x09F571E0  token=0x60012AA  System.Void .cctor()
  RVA=0x0350B670  token=0x60012AB  System.Void .ctor()
  RVA=0x09688020  token=0x60012AC  System.String <ToString>b__24_0(UnityEngine.UIElements.StyleSelector x)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000285
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.StyleSelector.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.StyleSelectorPart,System.String><>9__10_0  // static @ 0x8
METHODS:
  RVA=0x09F570B4  token=0x60012B8  System.Void .cctor()
  RVA=0x0350B670  token=0x60012B9  System.Void .ctor()
  RVA=0x09F57018  token=0x60012BA  System.String <ToString>b__10_0(UnityEngine.UIElements.StyleSelectorPart p)
END_CLASS

CLASS: ImportStruct
TYPE:  sealed struct
TOKEN: 0x200028A
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.StyleSheetstyleSheet  // 0x10
  public            System.String[]                 mediaQueries  // 0x18
METHODS:
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed struct
TOKEN: 0x2000293
SIZE:  0x14
FIELDS:
  public            System.Int32                    hash  // 0x10
METHODS:
END_CLASS

CLASS: Result
TYPE:  sealed struct
TOKEN: 0x2000295
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleVariableResolver.ResultValid  // const
  public    static  UnityEngine.UIElements.StyleVariableResolver.ResultInvalid  // const
  public    static  UnityEngine.UIElements.StyleVariableResolver.ResultNotFound  // const
METHODS:
END_CLASS

CLASS: ResolveContext
TYPE:  sealed struct
TOKEN: 0x2000296
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleValueHandle[]handles  // 0x18
METHODS:
END_CLASS

CLASS: AttributeOverride
TYPE:  sealed struct
TOKEN: 0x20002A7
SIZE:  0x28
FIELDS:
  public            System.String                   m_ElementName  // 0x10
  public            System.String                   m_AttributeName  // 0x18
  public            System.String                   m_Value  // 0x20
METHODS:
END_CLASS

CLASS: Use
TYPE:  sealed struct
TOKEN: 0x20002A9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseNone  // const
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseOptional  // const
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseProhibited  // const
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseRequired  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002AC
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UxmlStringAttributeDescription.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.String,System.String><>9__3_0  // static @ 0x8
  public    static  System.Func<System.String,System.String,System.String><>9__4_0  // static @ 0x10
METHODS:
  RVA=0x09F5717C  token=0x6001371  System.Void .cctor()
  RVA=0x0350B670  token=0x6001372  System.Void .ctor()
  RVA=0x03D51810  token=0x6001373  System.String <GetValueFromBag>b__3_0(System.String s, System.String t)
  RVA=0x03D51810  token=0x6001374  System.String <TryGetValueFromBag>b__4_0(System.String s, System.String t)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002AE
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UxmlFloatAttributeDescription.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Single,System.Single><>9__3_0  // static @ 0x8
METHODS:
  RVA=0x09F57050  token=0x6001378  System.Void .cctor()
  RVA=0x0350B670  token=0x6001379  System.Void .ctor()
  RVA=0x09F57008  token=0x600137A  System.Single <GetValueFromBag>b__3_0(System.String s, System.Single f)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002B0
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UxmlIntAttributeDescription.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Int32,System.Int32><>9__3_0  // static @ 0x8
  public    static  System.Func<System.String,System.Int32,System.Int32><>9__4_0  // static @ 0x10
METHODS:
  RVA=0x09F57244  token=0x600137F  System.Void .cctor()
  RVA=0x0350B670  token=0x6001380  System.Void .ctor()
  RVA=0x09F56FD0  token=0x6001381  System.Int32 <GetValueFromBag>b__3_0(System.String s, System.Int32 i)
  RVA=0x09F56FD0  token=0x6001382  System.Int32 <TryGetValueFromBag>b__4_0(System.String s, System.Int32 i)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002B2
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UxmlLongAttributeDescription.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Int64,System.Int64><>9__3_0  // static @ 0x8
METHODS:
  RVA=0x09F572A8  token=0x6001386  System.Void .cctor()
  RVA=0x0350B670  token=0x6001387  System.Void .ctor()
  RVA=0x09F56FE0  token=0x6001388  System.Int64 <GetValueFromBag>b__3_0(System.String s, System.Int64 l)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002B4
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UxmlBoolAttributeDescription.<>c<>9  // static @ 0x0
  public    static  System.Func<System.String,System.Boolean,System.Boolean><>9__3_0  // static @ 0x8
METHODS:
  RVA=0x09F57118  token=0x600138C  System.Void .cctor()
  RVA=0x0350B670  token=0x600138D  System.Void .ctor()
  RVA=0x09F56FF4  token=0x600138E  System.Boolean <GetValueFromBag>b__3_0(System.String s, System.Boolean b)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002B6
FIELDS:
  public    static readonly UnityEngine.UIElements.UxmlEnumAttributeDescription.<>c<T><>9  // static @ 0x0
  public    static  System.Func<System.String,T,T>  <>9__3_0  // static @ 0x0
  public    static  System.Func<System.String,T,T>  <>9__4_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6001393  System.Void .cctor()
  RVA=-1  // not resolved  token=0x6001394  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6001395  T <GetValueFromBag>b__3_0(System.String s, T convertible)
  RVA=-1  // not resolved  token=0x6001396  T <TryGetValueFromBag>b__4_0(System.String s, T convertible)
END_CLASS

CLASS: UsingEntry
TYPE:  sealed struct
TOKEN: 0x20002CC
SIZE:  0x28
FIELDS:
  private   static readonly System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry>comparer  // static @ 0x0
  public            System.String                   alias  // 0x10
  public            System.String                   path  // 0x18
  public            UnityEngine.UIElements.VisualTreeAssetasset  // 0x20
METHODS:
  RVA=0x09F58A58  token=0x6001400  System.Void .ctor(System.String alias, System.String path)
  RVA=0x09F589E8  token=0x6001401  System.Void .cctor()
END_CLASS

CLASS: UsingEntryComparer
TYPE:  class
TOKEN: 0x20002CD
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IComparer`1
FIELDS:
METHODS:
  RVA=0x09F589C4  token=0x6001402  System.Int32 Compare(UnityEngine.UIElements.VisualTreeAsset.UsingEntry x, UnityEngine.UIElements.VisualTreeAsset.UsingEntry y)
  RVA=0x0350B670  token=0x6001403  System.Void .ctor()
END_CLASS

CLASS: SlotDefinition
TYPE:  sealed struct
TOKEN: 0x20002CE
SIZE:  0x20
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Int32                    insertionPointId  // 0x18
METHODS:
END_CLASS

CLASS: SlotUsageEntry
TYPE:  sealed struct
TOKEN: 0x20002CF
SIZE:  0x20
FIELDS:
  public            System.String                   slotName  // 0x10
  public            System.Int32                    assetId  // 0x18
METHODS:
END_CLASS

CLASS: UxmlObjectEntry
TYPE:  sealed struct
TOKEN: 0x20002D0
SIZE:  0x20
FIELDS:
  public            System.Int32                    parentId  // 0x10
  public            System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset>uxmlObjectAssets  // 0x18
METHODS:
  RVA=0x071AED58  token=0x6001404  System.Void .ctor(System.Int32 parentId, System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets)
END_CLASS

CLASS: AssetEntry
TYPE:  sealed struct
TOKEN: 0x20002D1
SIZE:  0x30
FIELDS:
  public            System.String                   path  // 0x10
  public            System.String                   typeFullName  // 0x18
  public            UnityEngine.Object              asset  // 0x20
  private           System.Type                     m_CachedType  // 0x28
PROPERTIES:
  type  get=0x09F455EC
METHODS:
  RVA=0x09F4557C  token=0x6001406  System.Void .ctor(System.String path, System.Type type, UnityEngine.Object asset)
END_CLASS

CLASS: <get_templateDependencies>d__19
TYPE:  sealed class
TOKEN: 0x20002D2
SIZE:  0x80
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.UIElements.VisualTreeAsset<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            UnityEngine.UIElements.VisualTreeAsset<>4__this  // 0x28
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualTreeAsset><sent>5__1  // 0x30
  private           System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.VisualTreeAsset.UsingEntry><>s__2  // 0x38
  private           UnityEngine.UIElements.VisualTreeAsset.UsingEntry<entry>5__3  // 0x60
  private           UnityEngine.UIElements.VisualTreeAsset<vta>5__4  // 0x78
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x07BF60A4  token=0x6001407  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x09F58910  token=0x6001408  System.Void System.IDisposable.Dispose()
  RVA=0x09F580D0  token=0x6001409  System.Boolean MoveNext()
  RVA=0x09F58988  token=0x600140A  System.Void <>m__Finally1()
  RVA=0x09F588C4  token=0x600140C  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09F58820  token=0x600140E  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator()
  RVA=0x09F588BC  token=0x600140F  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_stylesheets>d__23
TYPE:  sealed class
TOKEN: 0x20002D3
SIZE:  0xA0
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.UIElements.StyleSheet<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            UnityEngine.UIElements.VisualTreeAsset<>4__this  // 0x28
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheet><sent>5__1  // 0x30
  private           System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.VisualElementAsset><>s__2  // 0x38
  private           UnityEngine.UIElements.VisualElementAsset<vea>5__3  // 0x50
  private           System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StyleSheet><>s__4  // 0x58
  private           UnityEngine.UIElements.StyleSheet<stylesheet>5__5  // 0x70
  private           System.Collections.Generic.List.Enumerator<System.String><>s__6  // 0x78
  private           System.String                   <stylesheetPath>5__7  // 0x90
  private           UnityEngine.UIElements.StyleSheet<stylesheet>5__8  // 0x98
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x07BF60A4  token=0x6001410  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x09F57EC8  token=0x6001411  System.Void System.IDisposable.Dispose()
  RVA=0x09F5730C  token=0x6001412  System.Boolean MoveNext()
  RVA=0x09F5801C  token=0x6001413  System.Void <>m__Finally1()
  RVA=0x09F58058  token=0x6001414  System.Void <>m__Finally2()
  RVA=0x09F58094  token=0x6001415  System.Void <>m__Finally3()
  RVA=0x09F57E7C  token=0x6001417  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09F57DD8  token=0x6001419  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator()
  RVA=0x09F57E74  token=0x600141A  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <>c__DisplayClass61_0
TYPE:  sealed class
TOKEN: 0x20002D4
SIZE:  0x18
FIELDS:
  public            UnityEngine.UIElements.VisualElementAssetchildVea  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600141B  System.Void .ctor()
  RVA=0x09F5702C  token=0x600141C  System.Boolean <CloneSetupRecursively>b__0(UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry u)
END_CLASS

CLASS: <>c__DisplayClass65_0
TYPE:  sealed struct
TOKEN: 0x20002D5
SIZE:  0x18
FIELDS:
  public            UnityEngine.UIElements.VisualElementAssetasset  // 0x10
METHODS:
END_CLASS

CLASS: Area
TYPE:  class
TOKEN: 0x20002D8
SIZE:  0x28
FIELDS:
  public            UnityEngine.RectInt             rect  // 0x10
  public            UnityEngine.UIElements.UIR.BestFitAllocatorallocator  // 0x20
METHODS:
  RVA=0x09F454FC  token=0x6001431  System.Void .ctor(UnityEngine.RectInt rect)
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x20002D9
SIZE:  0x58
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  public            UnityEngine.RectInt             rect  // 0x18
  public            UnityEngine.UIElements.UIR.Allocator2D.Areaarea  // 0x28
  public            UnityEngine.UIElements.UIR.BestFitAllocatorallocator  // 0x30
  public            UnityEngine.UIElements.UIR.Allocalloc  // 0x38
  public            UnityEngine.UIElements.UIR.Allocator2D.Rownext  // 0x50
  public    static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.Allocator2D.Row>pool  // static @ 0x0
METHODS:
  RVA=0x09F506B4  token=0x6001432  UnityEngine.UIElements.UIR.Allocator2D.Row Create()
  RVA=0x09F50704  token=0x6001433  System.Void Reset(UnityEngine.UIElements.UIR.Allocator2D.Row row)
  RVA=0x09F5088C  token=0x6001434  System.Void .ctor()
  RVA=0x09F50758  token=0x6001435  System.Void .cctor()
END_CLASS

CLASS: Alloc2D
TYPE:  sealed struct
TOKEN: 0x20002DA
SIZE:  0x40
FIELDS:
  public            UnityEngine.RectInt             rect  // 0x10
  public            UnityEngine.UIElements.UIR.Allocator2D.Rowrow  // 0x20
  public            UnityEngine.UIElements.UIR.Allocalloc  // 0x28
METHODS:
  RVA=0x09F44958  token=0x6001436  System.Void .ctor(UnityEngine.UIElements.UIR.Allocator2D.Row row, UnityEngine.UIElements.UIR.Alloc alloc, System.Int32 width, System.Int32 height)
END_CLASS

CLASS: RawTexture
TYPE:  sealed struct
TOKEN: 0x20002DC
SIZE:  0x20
FIELDS:
  public            UnityEngine.Color32[]           rgba  // 0x10
  public            System.Int32                    width  // 0x18
  public            System.Int32                    height  // 0x1c
METHODS:
  RVA=0x09F50620  token=0x6001446  System.Void WriteRawInt2Packed(System.Int32 v0, System.Int32 v1, System.Int32 destX, System.Int32 destY)
  RVA=0x09F50574  token=0x6001447  System.Void WriteRawFloat4Packed(System.Single f0, System.Single f1, System.Single f2, System.Single f3, System.Int32 destX, System.Int32 destY)
END_CLASS

CLASS: Allocator
TYPE:  sealed class
TOKEN: 0x20002E3
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0823952C  token=0x600146D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01035ED0  token=0x600146E  UnityEngine.UIElements.MeshWriteData Invoke(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
END_CLASS

CLASS: AllocMeshData
TYPE:  sealed struct
TOKEN: 0x20002E2
SIZE:  0x40
FIELDS:
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatoralloc  // 0x10
  private           UnityEngine.Texture             texture  // 0x18
  private           UnityEngine.UIElements.TextureIdsvgTexture  // 0x20
  private           UnityEngine.Material            material  // 0x28
  private           UnityEngine.UIElements.MeshGenerationContext.MeshFlagsflags  // 0x30
  private           UnityEngine.UIElements.UIR.BMPAlloccolorAlloc  // 0x34
METHODS:
  RVA=0x09E89054  token=0x600146C  UnityEngine.UIElements.MeshWriteData Allocate(System.UInt32 vertexCount, System.UInt32 indexCount)
END_CLASS

CLASS: ClipCounts
TYPE:  sealed struct
TOKEN: 0x20002E4
SIZE:  0x28
FIELDS:
  public            System.Int32                    firstClippedIndex  // 0x10
  public            System.Int32                    firstDegenerateIndex  // 0x14
  public            System.Int32                    lastClippedIndex  // 0x18
  public            System.Int32                    clippedTriangles  // 0x1c
  public            System.Int32                    addedTriangles  // 0x20
  public            System.Int32                    degenerateTriangles  // 0x24
METHODS:
END_CLASS

CLASS: VertexClipEdge
TYPE:  sealed struct
TOKEN: 0x20002E5
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeNone  // const
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeLeft  // const
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeTop  // const
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeRight  // const
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeBottom  // const
METHODS:
END_CLASS

CLASS: DepthOrderedDirtyTracking
TYPE:  sealed struct
TOKEN: 0x20002E8
SIZE:  0x38
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>heads  // 0x10
  public            System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>tails  // 0x18
  public            System.Int32[]                  minDepths  // 0x20
  public            System.Int32[]                  maxDepths  // 0x28
  public            System.UInt32                   dirtyID  // 0x30
METHODS:
  RVA=0x09E89BAC  token=0x60014A9  System.Void EnsureFits(System.Int32 maxDepth)
  RVA=0x09E89C2C  token=0x60014AA  System.Void RegisterDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses dirtyTypeClass)
  RVA=0x09E899B8  token=0x60014AB  System.Void ClearDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypesInverse)
  RVA=0x09E89DF0  token=0x60014AC  System.Void Reset()
END_CLASS

CLASS: RenderChainStaticIndexAllocator
TYPE:  sealed struct
TOKEN: 0x20002E9
SIZE:  0x11
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain>renderChains  // static @ 0x0
METHODS:
  RVA=0x09E8A0FC  token=0x60014AD  System.Int32 AllocateIndex(UnityEngine.UIElements.UIR.RenderChain renderChain)
  RVA=0x09E8A208  token=0x60014AE  System.Void FreeIndex(System.Int32 index)
  RVA=0x09E8A090  token=0x60014AF  UnityEngine.UIElements.UIR.RenderChain AccessIndex(System.Int32 index)
  RVA=0x09E8A278  token=0x60014B0  System.Void .cctor()
END_CLASS

CLASS: RenderNodeData
TYPE:  sealed struct
TOKEN: 0x20002EA
SIZE:  0x70
FIELDS:
  public            UnityEngine.Material            standardMaterial  // 0x10
  public            UnityEngine.Material            initialMaterial  // 0x18
  public            UnityEngine.MaterialPropertyBlockmatPropBlock  // 0x20
  public            UnityEngine.UIElements.UIR.RenderChainCommandfirstCommand  // 0x28
  public            UnityEngine.UIElements.UIR.UIRenderDevicedevice  // 0x30
  public            UnityEngine.Texture             vectorAtlas  // 0x38
  public            UnityEngine.Texture             shaderInfoAtlas  // 0x40
  public            System.Single                   dpiScale  // 0x48
  public            Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4>transformConstants  // 0x50
  public            Unity.Collections.NativeSlice<UnityEngine.Vector4>clipRectConstants  // 0x60
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002EB
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.RenderChain.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.UIR.RenderChainCommand><>9__37_0  // static @ 0x8
  public    static  System.Action<UnityEngine.UIElements.UIR.RenderChainCommand><>9__37_1  // static @ 0x10
METHODS:
  RVA=0x09E96654  token=0x60014B1  System.Void .cctor()
  RVA=0x0350B670  token=0x60014B2  System.Void .ctor()
  RVA=0x09E96604  token=0x60014B3  UnityEngine.UIElements.UIR.RenderChainCommand <.ctor>b__37_0()
  RVA=0x0350B670  token=0x60014B4  System.Void <.ctor>b__37_1(UnityEngine.UIElements.UIR.RenderChainCommand cmd)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002F4
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x09E96780  token=0x60014CC  System.Void .cctor()
  RVA=0x0350B670  token=0x60014CD  System.Void .ctor()
  RVA=0x09E96508  token=0x60014CE  UnityEngine.Color32 <.cctor>b__2_0(UnityEngine.Color c)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002F6
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x09E966B8  token=0x60014D1  System.Void .cctor()
  RVA=0x0350B670  token=0x60014D2  System.Void .ctor()
  RVA=0x03D65E70  token=0x60014D3  UnityEngine.Color <.cctor>b__2_0(UnityEngine.Color c)
END_CLASS

CLASS: Edges
TYPE:  sealed struct
TOKEN: 0x20002F9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesNone  // const
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesLeft  // const
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesTop  // const
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesRight  // const
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesBottom  // const
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesAll  // const
METHODS:
END_CLASS

CLASS: BlitInfo
TYPE:  sealed struct
TOKEN: 0x20002FC
SIZE:  0x48
FIELDS:
  public            UnityEngine.Texture             src  // 0x10
  public            UnityEngine.RectInt             srcRect  // 0x18
  public            UnityEngine.Vector2Int          dstPos  // 0x28
  public            System.Int32                    border  // 0x30
  public            UnityEngine.Color               tint  // 0x34
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20002FF
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.VectorImageRenderInfoPool.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.UIR.VectorImageRenderInfo><>9__0_0  // static @ 0x8
  public    static  System.Action<UnityEngine.UIElements.UIR.VectorImageRenderInfo><>9__0_1  // static @ 0x10
METHODS:
  RVA=0x09E9671C  token=0x6001509  System.Void .cctor()
  RVA=0x0350B670  token=0x600150A  System.Void .ctor()
  RVA=0x09E96574  token=0x600150B  UnityEngine.UIElements.UIR.VectorImageRenderInfo <.ctor>b__0_0()
  RVA=0x09E965C4  token=0x600150C  System.Void <.ctor>b__0_1(UnityEngine.UIElements.UIR.VectorImageRenderInfo vectorImageInfo)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000302
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.GradientRemapPool.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.UIR.GradientRemap><>9__0_0  // static @ 0x8
  public    static  System.Action<UnityEngine.UIElements.UIR.GradientRemap><>9__0_1  // static @ 0x10
METHODS:
  RVA=0x09E967E4  token=0x6001510  System.Void .cctor()
  RVA=0x0350B670  token=0x6001511  System.Void .ctor()
  RVA=0x09E96524  token=0x6001512  UnityEngine.UIElements.UIR.GradientRemap <.ctor>b__0_0()
  RVA=0x09E965E4  token=0x6001513  System.Void <.ctor>b__0_1(UnityEngine.UIElements.UIR.GradientRemap gradientRemap)
END_CLASS

CLASS: Page
TYPE:  sealed struct
TOKEN: 0x2000308
SIZE:  0x18
FIELDS:
  public            System.UInt16                   x  // 0x10
  public            System.UInt16                   y  // 0x12
  public            System.Int32                    freeSlots  // 0x14
METHODS:
END_CLASS

CLASS: AllocToUpdate
TYPE:  sealed struct
TOKEN: 0x200030D
SIZE:  0x60
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            System.UInt32                   allocTime  // 0x14
  public            UnityEngine.UIElements.UIR.MeshHandlemeshHandle  // 0x18
  public            UnityEngine.UIElements.UIR.AllocpermAllocVerts  // 0x20
  public            UnityEngine.UIElements.UIR.AllocpermAllocIndices  // 0x38
  public            UnityEngine.UIElements.UIR.Page permPage  // 0x50
  public            System.Boolean                  copyBackIndices  // 0x58
METHODS:
END_CLASS

CLASS: AllocToFree
TYPE:  sealed struct
TOKEN: 0x200030E
SIZE:  0x38
FIELDS:
  public            UnityEngine.UIElements.UIR.Allocalloc  // 0x10
  public            UnityEngine.UIElements.UIR.Page page  // 0x28
  public            System.Boolean                  vertices  // 0x30
METHODS:
END_CLASS

CLASS: DeviceToFree
TYPE:  sealed struct
TOKEN: 0x200030F
SIZE:  0x20
FIELDS:
  public            System.UInt32                   handle  // 0x10
  public            UnityEngine.UIElements.UIR.Page page  // 0x18
METHODS:
  RVA=0x09E9DDC8  token=0x600157B  System.Void Dispose()
END_CLASS

CLASS: EvaluationState
TYPE:  sealed struct
TOKEN: 0x2000310
SIZE:  0x50
FIELDS:
  public            UnityEngine.MaterialPropertyBlockstateMatProps  // 0x10
  public            UnityEngine.Material            defaultMat  // 0x18
  public            UnityEngine.UIElements.UIR.StatecurState  // 0x20
  public            UnityEngine.UIElements.UIR.Page curPage  // 0x40
  public            System.Boolean                  mustApplyMaterial  // 0x48
  public            System.Boolean                  mustApplyCommonBlock  // 0x49
  public            System.Boolean                  mustApplyStateBlock  // 0x4a
  public            System.Boolean                  mustApplyStencil  // 0x4b
METHODS:
END_CLASS

CLASS: DrawStatistics
TYPE:  sealed struct
TOKEN: 0x2000311
SIZE:  0x34
FIELDS:
  public            System.Int32                    currentFrameIndex  // 0x10
  public            System.UInt32                   totalIndices  // 0x14
  public            System.UInt32                   commandCount  // 0x18
  public            System.UInt32                   drawCommandCount  // 0x1c
  public            System.UInt32                   materialSetCount  // 0x20
  public            System.UInt32                   drawRangeCount  // 0x24
  public            System.UInt32                   drawRangeCallCount  // 0x28
  public            System.UInt32                   immediateDraws  // 0x2c
  public            System.UInt32                   stencilRefChanges  // 0x30
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000312
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.UIRenderDevice.<>c<>9  // static @ 0x0
  public    static  System.Func<UnityEngine.UIElements.UIR.MeshHandle><>9__53_0  // static @ 0x8
  public    static  System.Action<UnityEngine.UIElements.UIR.MeshHandle><>9__53_1  // static @ 0x10
METHODS:
  RVA=0x09EA275C  token=0x600157C  System.Void .cctor()
  RVA=0x0350B670  token=0x600157D  System.Void .ctor()
  RVA=0x09EA270C  token=0x600157E  UnityEngine.UIElements.UIR.MeshHandle <.ctor>b__53_0()
  RVA=0x0350B670  token=0x600157F  System.Void <.ctor>b__53_1(UnityEngine.UIElements.UIR.MeshHandle mh)
END_CLASS

CLASS: BlockPool
TYPE:  class
TOKEN: 0x2000315
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.UIR.LinkedPool`1
FIELDS:
METHODS:
  RVA=0x09E99E04  token=0x6001588  UnityEngine.UIElements.UIR.BestFitAllocator.Block CreateBlock()
  RVA=0x0350B670  token=0x6001589  System.Void ResetBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block)
  RVA=0x09E99E54  token=0x600158A  System.Void .ctor()
END_CLASS

CLASS: Block
TYPE:  class
TOKEN: 0x2000316
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  public            System.UInt32                   start  // 0x18
  public            System.UInt32                   end  // 0x1c
  public            UnityEngine.UIElements.UIR.BestFitAllocator.Blockprev  // 0x20
  public            UnityEngine.UIElements.UIR.BestFitAllocator.Blocknext  // 0x28
  public            UnityEngine.UIElements.UIR.BestFitAllocator.BlockprevAvailable  // 0x30
  public            UnityEngine.UIElements.UIR.BestFitAllocator.BlocknextAvailable  // 0x38
  public            System.Boolean                  allocated  // 0x40
PROPERTIES:
  size  get=0x03D88B90
METHODS:
  RVA=0x09E99F38  token=0x600158C  System.Void .ctor()
END_CLASS

CLASS: DataSet`1
TYPE:  class
TOKEN: 0x2000319
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Boolean                  <disposed>k__BackingField  // 0x0
  public            UnityEngine.UIElements.UIR.Utility.GPUBuffer<T>gpuData  // 0x0
  public            Unity.Collections.NativeArray<T>cpuData  // 0x0
  public            Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>updateRanges  // 0x0
  public            UnityEngine.UIElements.UIR.GPUBufferAllocatorallocator  // 0x0
  private   readonly System.UInt32                   m_UpdateRangePoolSize  // 0x0
  private           System.UInt32                   m_ElemStride  // 0x0
  private           System.UInt32                   m_UpdateRangeMin  // 0x0
  private           System.UInt32                   m_UpdateRangeMax  // 0x0
  private           System.UInt32                   m_UpdateRangesEnqueued  // 0x0
  private           System.UInt32                   m_UpdateRangesBatchStart  // 0x0
  private           System.Boolean                  m_UpdateRangesSaturated  // 0x0
PROPERTIES:
  disposed  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6001598  System.Void .ctor(UnityEngine.UIElements.UIR.Utility.GPUBufferType bufferType, System.UInt32 totalCount, System.UInt32 maxQueuedFrameCount, System.UInt32 updateRangePoolSize, System.Boolean mockBuffer)
  RVA=-1  // not resolved  token=0x600159B  System.Void Dispose()
  RVA=-1  // not resolved  token=0x600159C  System.Void Dispose(System.Boolean disposing)
  RVA=-1  // not resolved  token=0x600159D  System.Void RegisterUpdate(System.UInt32 start, System.UInt32 size)
  RVA=-1  // not resolved  token=0x600159E  System.Boolean HasMappedBufferRange()
  RVA=-1  // not resolved  token=0x600159F  System.Void SendUpdates()
  RVA=-1  // not resolved  token=0x60015A0  System.Void SendFullRange()
  RVA=-1  // not resolved  token=0x60015A1  System.Void SendPartialRanges()
  RVA=-1  // not resolved  token=0x60015A2  System.Void ResetUpdateState()
END_CLASS

CLASS: Entry
TYPE:  sealed struct
TOKEN: 0x2000323
SIZE:  0x70
FIELDS:
  public            Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>vertices  // 0x10
  public            Unity.Collections.NativeSlice<System.UInt16>indices  // 0x20
  public            UnityEngine.Material            material  // 0x30
  public            UnityEngine.Texture             custom  // 0x38
  public            UnityEngine.Texture             font  // 0x40
  public            System.Single                   fontTexSDFScale  // 0x48
  public            UnityEngine.UIElements.TextureIdtexture  // 0x4c
  public            UnityEngine.UIElements.UIR.RenderChainCommandcustomCommand  // 0x50
  public            UnityEngine.UIElements.UIR.BMPAllocclipRectID  // 0x58
  public            UnityEngine.UIElements.UIR.VertexFlagsaddFlags  // 0x60
  public            System.Boolean                  uvIsDisplacement  // 0x64
  public            System.Boolean                  isTextEntry  // 0x65
  public            System.Boolean                  isClipRegisterEntry  // 0x66
  public            System.Int32                    stencilRef  // 0x68
  public            System.Int32                    maskDepth  // 0x6c
METHODS:
END_CLASS

CLASS: ClosingInfo
TYPE:  sealed struct
TOKEN: 0x2000324
SIZE:  0x48
FIELDS:
  public            System.Boolean                  needsClosing  // 0x10
  public            System.Boolean                  popViewMatrix  // 0x11
  public            System.Boolean                  popScissorClip  // 0x12
  public            System.Boolean                  blitAndPopRenderTexture  // 0x13
  public            System.Boolean                  PopDefaultMaterial  // 0x14
  public            UnityEngine.UIElements.UIR.RenderChainCommandclipUnregisterDrawCommand  // 0x18
  public            Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>clipperRegisterVertices  // 0x20
  public            Unity.Collections.NativeSlice<System.UInt16>clipperRegisterIndices  // 0x30
  public            System.Int32                    clipperRegisterIndexOffset  // 0x40
  public            System.Int32                    maskStencilRef  // 0x44
METHODS:
END_CLASS

CLASS: TempDataAlloc`1
TYPE:  sealed struct
TOKEN: 0x2000325
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Int32                    maxPoolElemCount  // 0x0
  private           Unity.Collections.NativeArray<T>pool  // 0x0
  private           System.Collections.Generic.List<Unity.Collections.NativeArray<T>>excess  // 0x0
  private           System.UInt32                   takenFromPool  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6001607  System.Void .ctor(System.Int32 maxPoolElems)
  RVA=-1  // not resolved  token=0x6001608  System.Void Dispose()
  RVA=-1  // not resolved  token=0x6001609  Unity.Collections.NativeSlice<T> Alloc(System.UInt32 count)
  RVA=-1  // not resolved  token=0x600160A  System.Void SessionDone()
END_CLASS

CLASS: ColumnState
TYPE:  sealed struct
TOKEN: 0x200032E
SIZE:  0x30
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.String                   name  // 0x18
  public            System.Single                   actualWidth  // 0x20
  public            UnityEngine.UIElements.Length   width  // 0x24
  public            System.Boolean                  visible  // 0x2c
METHODS:
END_CLASS

CLASS: ViewState
TYPE:  class
TOKEN: 0x200032D
SIZE:  0x28
FIELDS:
  private           System.Boolean                  m_HasPersistedData  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortDescriptions  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewState.ColumnState>m_OrderedColumnStates  // 0x20
METHODS:
  RVA=0x09EBB0EC  token=0x6001678  System.Void Save(UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header)
  RVA=0x09EBAD30  token=0x6001679  System.Void Apply(UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header)
  RVA=0x09EBB518  token=0x600167A  System.Void .ctor()
END_CLASS

CLASS: ColumnData
TYPE:  class
TOKEN: 0x200032F
SIZE:  0x20
FIELDS:
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumn<control>k__BackingField  // 0x10
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle<resizeHandle>k__BackingField  // 0x18
PROPERTIES:
  control  get=0x020B7B20  set=0x0426FEE0
  resizeHandle  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x0350B670  token=0x600167F  System.Void .ctor()
END_CLASS

CLASS: SortedColumnState
TYPE:  sealed struct
TOKEN: 0x2000330
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.SortColumnDescriptioncolumnDesc  // 0x10
  public            UnityEngine.UIElements.SortDirectiondirection  // 0x18
METHODS:
  RVA=0x04274600  token=0x6001680  System.Void .ctor(UnityEngine.UIElements.SortColumnDescription desc, UnityEngine.UIElements.SortDirection dir)
END_CLASS

CLASS: <>c__DisplayClass65_0
TYPE:  sealed class
TOKEN: 0x2000331
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.Column   column  // 0x10
  public            UnityEngine.UIElements.Internal.MultiColumnCollectionHeader<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6001681  System.Void .ctor()
  RVA=0x09EB4B48  token=0x6001682  System.Void <OnContextualMenuManipulator>b__1(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=0x09EB4B74  token=0x6001683  UnityEngine.UIElements.DropdownMenuAction.Status <OnContextualMenuManipulator>b__2(UnityEngine.UIElements.DropdownMenuAction a)
END_CLASS

CLASS: <>c__DisplayClass71_0
TYPE:  sealed class
TOKEN: 0x2000332
SIZE:  0x18
FIELDS:
  public            UnityEngine.UIElements.Column   column  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6001684  System.Void .ctor()
  RVA=0x09EB4BF0  token=0x6001685  System.Boolean <UpdateSortColumnDescriptionsOnClick>b__0(UnityEngine.UIElements.SortColumnDescription d)
END_CLASS

CLASS: Unit
TYPE:  sealed struct
TOKEN: 0x200033F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitUnitless  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitPixel  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitPercent  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitSecond  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitMillisecond  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitDegree  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitGradian  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitRadian  // const
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitTurn  // const
METHODS:
END_CLASS

CLASS: GetCursorIdFunction
TYPE:  sealed class
TOKEN: 0x2000344
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09EBC48C  token=0x600174E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01165340  token=0x600174F  System.Int32 Invoke(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle)
END_CLASS

CLASS: SheetHandleKey
TYPE:  sealed struct
TOKEN: 0x2000349
SIZE:  0x18
FIELDS:
  public    readonly System.Int32                    sheetInstanceID  // 0x10
  public    readonly System.Int32                    index  // 0x14
METHODS:
  RVA=0x09EBF734  token=0x600175B  System.Void .ctor(UnityEngine.UIElements.StyleSheet sheet, System.Int32 index)
END_CLASS

CLASS: SheetHandleKeyComparer
TYPE:  class
TOKEN: 0x200034A
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IEqualityComparer`1
FIELDS:
METHODS:
  RVA=0x06F68450  token=0x600175C  System.Boolean Equals(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey x, UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey y)
  RVA=0x03D66CE0  token=0x600175D  System.Int32 GetHashCode(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey key)
  RVA=0x0350B670  token=0x600175E  System.Void .ctor()
END_CLASS

CLASS: MatchContext
TYPE:  sealed struct
TOKEN: 0x2000352
SIZE:  0x18
FIELDS:
  public            System.Int32                    valueIndex  // 0x10
  public            System.Int32                    matchedVariableCount  // 0x14
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=108
TYPE:  sealed struct
TOKEN: 0x2000365
SIZE:  0x7C
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000364
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1082658253827592C8000DF6C48FD5487B674D9E695DB670A56FDEAB2B7F291523E  // static @ 0x0
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

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.AlignmentUtils
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E672EC  token=0x6000003  System.Single RoundToPixelGrid(System.Single v, System.Single pixelsPerPoint, System.Single offset)
  RVA=0x09E672C4  token=0x6000004  System.Single CeilToPixelGrid(System.Single v, System.Single pixelsPerPoint, System.Single offset)
END_CLASS

CLASS: UnityEngine.UIElements.AtlasBase
TYPE:  abstract class
TOKEN: 0x2000005
SIZE:  0x18
FIELDS:
  private           UnityEngine.UIElements.TextureRegistrytextureRegistry  // 0x10
METHODS:
  RVA=0x09E67820  token=0x6000005  System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId& atlas, UnityEngine.RectInt& atlasRect)
  RVA=0x0350B670  token=0x6000006  System.Void ReturnAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas)
  RVA=0x0350B670  token=0x6000007  System.Void Reset()
  RVA=0x0350B670  token=0x6000008  System.Void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000009  System.Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x600000A  System.Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel)
  RVA=0x09E6776C  token=0x600000B  System.Void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel panel)
  RVA=0x094B48E8  token=0x600000C  System.Void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel panel)
  RVA=0x094C1B40  token=0x600000D  System.Void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel)
  RVA=0x09E67780  token=0x600000E  System.Void RepaintTexturedElements(UnityEngine.UIElements.IPanel panel)
  RVA=0x09E67800  token=0x600000F  System.Void SetDynamicTexture(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture)
  RVA=0x09E67878  token=0x6000010  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasFilters
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersNone  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersReadability  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersSize  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersFormat  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersColorSpace  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersFilterMode  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasCustomFilter
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x07D66090  token=0x6000011  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01165340  token=0x6000012  System.Boolean Invoke(UnityEngine.Texture2D texture, UnityEngine.UIElements.DynamicAtlasFilters& filtersToApply)
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlas
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x58
EXTENDS: UnityEngine.UIElements.AtlasBase
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.DynamicAtlas.TextureInfo>m_Database  // 0x18
  private           UnityEngine.UIElements.DynamicAtlasPagem_PointPage  // 0x20
  private           UnityEngine.UIElements.DynamicAtlasPagem_BilinearPage  // 0x28
  private           UnityEngine.ColorSpace          m_ColorSpace  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UIElements.IPanel>m_Panels  // 0x38
  private           System.Int32                    m_MinAtlasSize  // 0x40
  private           System.Int32                    m_MaxAtlasSize  // 0x44
  private           System.Int32                    m_MaxSubTextureSize  // 0x48
  private           UnityEngine.UIElements.DynamicAtlasFiltersm_ActiveFilters  // 0x4c
  private           UnityEngine.UIElements.DynamicAtlasCustomFilterm_CustomFilter  // 0x50
PROPERTIES:
  isInitialized  get=0x09E6F4B0
  minAtlasSize  set=0x09E6F554
  maxAtlasSize  set=0x09E6F524
  defaultFilters  get=0x03D55C10
  activeFilters  set=0x09E6F4C4
  maxSubTextureSize  get=0x03D86EF0  set=0x09E6F53C
  customFilter  set=0x09E6F4DC
METHODS:
  RVA=0x09E6EC8C  token=0x6000014  System.Void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel)
  RVA=0x09E6ED08  token=0x6000015  System.Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel)
  RVA=0x09E6EE00  token=0x6000016  System.Void Reset()
  RVA=0x09E6E8C0  token=0x6000017  System.Void InitPages()
  RVA=0x09E6E83C  token=0x6000018  System.Void DestroyPages()
  RVA=0x09E6EFD4  token=0x6000019  System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId& atlas, UnityEngine.RectInt& atlasRect)
  RVA=0x09E6EEA0  token=0x600001A  System.Void ReturnAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas)
  RVA=0x09E6ED90  token=0x600001B  System.Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel)
  RVA=0x09E6E9E4  token=0x600001C  System.Boolean IsTextureFormatSupported(UnityEngine.TextureFormat format)
  RVA=0x09E6EB40  token=0x600001D  System.Boolean IsTextureValid(UnityEngine.Texture2D texture, UnityEngine.FilterMode atlasFilterMode)
  RVA=0x09E6F3C4  token=0x6000025  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BindableElement
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x3D0
EXTENDS: UnityEngine.UIElements.VisualElement
IMPLEMENTS: UnityEngine.UIElements.IBindable
FIELDS:
  private           UnityEngine.UIElements.IBinding <binding>k__BackingField  // 0x3c0
  private           System.String                   <bindingPath>k__BackingField  // 0x3c8
PROPERTIES:
  binding  get=0x03D57010
  bindingPath  set=0x058B3B50
METHODS:
  RVA=0x09E69538  token=0x600002C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ClampedDragger`1
TYPE:  class
TOKEN: 0x200000D
EXTENDS: UnityEngine.UIElements.Clickable
FIELDS:
  private           System.Action                   dragging  // 0x0
  private           System.Action                   draggingEnded  // 0x0
  private           UnityEngine.UIElements.ClampedDragger.DragDirection<T><dragDirection>k__BackingField  // 0x0
  private           UnityEngine.UIElements.BaseSlider<T><slider>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <startMousePosition>k__BackingField  // 0x0
PROPERTIES:
  dragDirection  get=-1  // not resolved  set=-1  // not resolved
  slider  set=-1  // not resolved
  startMousePosition  get=-1  // not resolved  set=-1  // not resolved
  delta  get=-1  // not resolved
EVENTS:
  dragging  add=add_dragging  remove=remove_dragging
  draggingEnded  add=add_draggingEnded  remove=remove_draggingEnded
METHODS:
  RVA=-1  // not resolved  token=0x600003A  System.Void .ctor(UnityEngine.UIElements.BaseSlider<T> slider, System.Action clickHandler, System.Action dragHandler)
  RVA=-1  // not resolved  token=0x600003B  System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  RVA=-1  // not resolved  token=0x600003C  System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  RVA=-1  // not resolved  token=0x600003D  System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition)
END_CLASS

CLASS: UnityEngine.UIElements.Clickable
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x78
EXTENDS: UnityEngine.UIElements.PointerManipulator
FIELDS:
  private           System.Action<UnityEngine.UIElements.EventBase>clickedWithEventInfo  // 0x38
  private           System.Action                   clicked  // 0x40
  private   readonly System.Int64                    m_Delay  // 0x48
  private   readonly System.Int64                    m_Interval  // 0x50
  private           System.Boolean                  <active>k__BackingField  // 0x58
  private           UnityEngine.Vector2             <lastMousePosition>k__BackingField  // 0x5c
  private           System.Int32                    m_ActivePointerId  // 0x64
  private           System.Boolean                  m_AcceptClicksIfDisabled  // 0x68
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_Repeater  // 0x70
PROPERTIES:
  active  get=0x03D4F7E0  set=0x03D4F7F0
  lastMousePosition  get=0x03D88530  set=0x03D6E7B0
  acceptClicksIfDisabled  get=0x03D4F3F0  set=0x09E6BAC4
  invokePolicy  get=0x09E6B998
EVENTS:
  clickedWithEventInfo  add=add_clickedWithEventInfo  remove=remove_clickedWithEventInfo
  clicked  add=add_clicked  remove=remove_clicked
METHODS:
  RVA=0x09E6B710  token=0x6000049  System.Void .ctor(System.Action handler, System.Int64 delay, System.Int64 interval)
  RVA=0x09E6B74C  token=0x600004A  System.Void .ctor(System.Action<UnityEngine.UIElements.EventBase> handler)
  RVA=0x09E6B7E0  token=0x600004B  System.Void .ctor(System.Action handler)
  RVA=0x09E6A854  token=0x600004C  System.Void OnTimer(UnityEngine.UIElements.TimerState timerState)
  RVA=0x09E6A1E8  token=0x600004D  System.Boolean IsRepeatable()
  RVA=0x09E6AD0C  token=0x600004E  System.Void RegisterCallbacksOnTarget()
  RVA=0x09E6B2D4  token=0x600004F  System.Void UnregisterCallbacksFromTarget()
  RVA=0x09E6A268  token=0x6000050  System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt)
  RVA=0x09E6A328  token=0x6000051  System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt)
  RVA=0x09E6A394  token=0x6000052  System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt)
  RVA=0x09E6A1FC  token=0x6000053  System.Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt)
  RVA=0x09E6A548  token=0x6000054  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  RVA=0x09E6A65C  token=0x6000055  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  RVA=0x09E6A744  token=0x6000056  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09E6A458  token=0x6000057  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  RVA=0x09E6A4D8  token=0x6000058  System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  RVA=0x09E6A108  token=0x6000059  System.Boolean ContainsPointer(System.Int32 pointerId)
  RVA=0x09E6A19C  token=0x600005A  System.Boolean IsNotMouseEvent(System.Int32 pointerId)
  RVA=0x09E6A15C  token=0x600005B  System.Void Invoke(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E6B1C8  token=0x600005C  System.Void SimulateSingleClick(UnityEngine.UIElements.EventBase evt, System.Int32 delayMs)
  RVA=0x09E6A9A0  token=0x600005D  System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  RVA=0x09E6ABA0  token=0x600005E  System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition)
  RVA=0x09E6AC08  token=0x600005F  System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  RVA=0x09E6A8D0  token=0x6000060  System.Void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, System.Int32 pointerId)
  RVA=0x09E6B2AC  token=0x6000061  System.Void <SimulateSingleClick>b__43_0()
END_CLASS

CLASS: UnityEngine.UIElements.ClickDetector
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus>m_ClickStatus  // 0x10
  private   static  System.Int32                    <s_DoubleClickTime>k__BackingField  // static @ 0x0
PROPERTIES:
  s_DoubleClickTime  get=0x09E6A064  set=0x09E6A0B4
METHODS:
  RVA=0x09E69ED4  token=0x6000064  System.Void .ctor()
  RVA=0x09E69D3C  token=0x6000065  System.Void StartClickTracking(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E69AE8  token=0x6000066  System.Void SendClickEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E695C0  token=0x6000067  System.Void CancelClickTracking(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E6989C  token=0x6000068  System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E697B0  token=0x6000069  System.Boolean ContainsPointer(UnityEngine.UIElements.VisualElement element, UnityEngine.Vector2 position)
  RVA=0x09E69650  token=0x600006A  System.Void Cleanup(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  RVA=0x09E69E98  token=0x600006B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ContextualMenuManager
TYPE:  abstract class
TOKEN: 0x2000012
SIZE:  0x18
FIELDS:
  private           System.Boolean                  <displayMenuHandledOSX>k__BackingField  // 0x10
PROPERTIES:
  displayMenuHandledOSX  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=-1  // abstract  token=0x6000070  System.Void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IEventHandler eventHandler)
  RVA=0x09E6BB04  token=0x6000071  System.Void DisplayMenu(UnityEngine.UIElements.EventBase triggerEvent, UnityEngine.UIElements.IEventHandler target)
  RVA=-1  // abstract  token=0x6000072  System.Void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.EventBase triggerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.ContextualMenuManipulator
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.MouseManipulator
FIELDS:
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent>m_MenuBuilder  // 0x30
METHODS:
  RVA=0x09E6C2AC  token=0x6000073  System.Void .ctor(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> menuBuilder)
  RVA=0x09E6BE14  token=0x6000074  System.Void RegisterCallbacksOnTarget()
  RVA=0x09E6C060  token=0x6000075  System.Void UnregisterCallbacksFromTarget()
  RVA=0x09E6BD5C  token=0x6000076  System.Void OnMouseUpDownEvent(UnityEngine.UIElements.IMouseEvent evt)
  RVA=0x09E6BD04  token=0x6000077  System.Void OnMouseDownEventOSX(UnityEngine.UIElements.MouseDownEvent evt)
  RVA=0x09E6BDC4  token=0x6000078  System.Void OnMouseUpEventOSX(UnityEngine.UIElements.MouseUpEvent evt)
  RVA=0x09E6BCA8  token=0x6000079  System.Void OnKeyUpEvent(UnityEngine.UIElements.KeyUpEvent evt)
  RVA=0x09E6BC2C  token=0x600007A  System.Void DoDisplayMenu(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E6BC94  token=0x600007B  System.Void OnContextualMenuEvent(UnityEngine.UIElements.ContextualMenuPopulateEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.CountingBloomFilter
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x4010
FIELDS:
  private           UnityEngine.UIElements.CountingBloomFilter.<m_Counters>e__FixedBufferm_Counters  // 0x10
METHODS:
  RVA=0x09E6C38C  token=0x600007C  System.Void AdjustSlot(System.UInt32 index, System.Boolean increment)
  RVA=0x03D88550  token=0x600007D  System.UInt32 Hash1(System.UInt32 hash)
  RVA=0x03D88560  token=0x600007E  System.UInt32 Hash2(System.UInt32 hash)
  RVA=0x09E6C408  token=0x600007F  System.Boolean IsSlotEmpty(System.UInt32 index)
  RVA=0x09E6C3DC  token=0x6000080  System.Void InsertHash(System.UInt32 hash)
  RVA=0x09E6C414  token=0x6000081  System.Void RemoveHash(System.UInt32 hash)
  RVA=0x09E6C3B0  token=0x6000082  System.Boolean ContainsHash(System.UInt32 hash)
END_CLASS

CLASS: UnityEngine.UIElements.AncestorFilter
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x4018
FIELDS:
  private           UnityEngine.UIElements.CountingBloomFilterm_CountingBloomFilter  // 0x10
  private           System.Collections.Generic.Stack<System.Int32>m_HashStack  // 0x4010
METHODS:
  RVA=0x09E676EC  token=0x6000083  System.Void .ctor()
  RVA=0x09E6731C  token=0x6000084  System.Void AddHash(System.Int32 hash)
  RVA=0x09E67380  token=0x6000085  System.Boolean IsCandidate(UnityEngine.UIElements.StyleComplexSelector complexSel)
  RVA=0x09E674B8  token=0x6000086  System.Void PushElement(UnityEngine.UIElements.VisualElement element)
  RVA=0x09E673F8  token=0x6000087  System.Void PopElement()
END_CLASS

CLASS: UnityEngine.UIElements.Cursor
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.Texture2D           <texture>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <hotspot>k__BackingField  // 0x18
  private           System.Int32                    <defaultCursorId>k__BackingField  // 0x20
PROPERTIES:
  texture  get=0x020C61B0  set=0x042715A0
  hotspot  get=0x03D67720  set=0x03D55BA0
  defaultCursorId  get=0x03D4E340  set=0x010410F0
METHODS:
  RVA=0x09E6C53C  token=0x600008E  System.Boolean Equals(System.Object obj)
  RVA=0x09E6C5C0  token=0x600008F  System.Boolean Equals(UnityEngine.UIElements.Cursor other)
  RVA=0x09E6C684  token=0x6000090  System.Int32 GetHashCode()
  RVA=0x09E6C7CC  token=0x6000091  System.Boolean op_Equality(UnityEngine.UIElements.Cursor style1, UnityEngine.UIElements.Cursor style2)
  RVA=0x09E6C758  token=0x6000092  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.ICursorManager
TYPE:  interface
TOKEN: 0x2000018
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000093  System.Void SetCursor(UnityEngine.UIElements.Cursor cursor)
  RVA=-1  // abstract  token=0x6000094  System.Void ResetCursor()
END_CLASS

CLASS: UnityEngine.UIElements.CursorManager
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x18
IMPLEMENTS: UnityEngine.UIElements.ICursorManager
FIELDS:
  private           System.Boolean                  <isCursorOverriden>k__BackingField  // 0x10
PROPERTIES:
  isCursorOverriden  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=0x09E6C480  token=0x6000097  System.Void SetCursor(UnityEngine.UIElements.Cursor cursor)
  RVA=0x09E6C440  token=0x6000098  System.Void ResetCursor()
  RVA=0x0350B670  token=0x6000099  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DefaultEventSystem
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x68
FIELDS:
  private   static  System.Func<System.Boolean>     IsEditorRemoteConnected  // static @ 0x0
  private           UnityEngine.UIElements.DefaultEventSystem.IInputm_Input  // 0x10
  private   readonly System.String                   m_HorizontalAxis  // 0x18
  private   readonly System.String                   m_VerticalAxis  // 0x20
  private   readonly System.String                   m_SubmitButton  // 0x28
  private   readonly System.String                   m_CancelButton  // 0x30
  private   readonly System.Single                   m_InputActionsPerSecond  // 0x38
  private   readonly System.Single                   m_RepeatDelay  // 0x3c
  private           System.Boolean                  m_SendingTouchEvents  // 0x40
  private           UnityEngine.Event               m_Event  // 0x48
  private           UnityEngine.UIElements.BaseRuntimePanelm_FocusedPanel  // 0x50
  private           System.Int32                    m_ConsecutiveMoveCount  // 0x58
  private           UnityEngine.Vector2             m_LastMoveVector  // 0x5c
  private           System.Single                   m_PrevActionTime  // 0x64
PROPERTIES:
  isAppFocused  get=0x042744F0
  input  get=0x09E6DA70
  focusedPanel  get=0x03D4EAF0  set=0x09E6DAA4
METHODS:
  RVA=0x09E6C7F8  token=0x600009C  UnityEngine.UIElements.DefaultEventSystem.IInput GetDefaultInput()
  RVA=0x09E6D668  token=0x600009D  System.Boolean ShouldIgnoreEventsOnAppNotFocused()
  RVA=0x09E6D85C  token=0x60000A0  System.Void Update(UnityEngine.UIElements.DefaultEventSystem.UpdateMode updateMode)
  RVA=0x09E6CE78  token=0x60000A1  System.Void SendIMGUIEvents()
  RVA=0x09E6D394  token=0x60000A2  System.Void SendInputEvents()
  RVA=-1  // generic def  token=0x60000A3  System.Void SendFocusBasedEvent(System.Func<TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg)
  RVA=-1  // generic def  token=0x60000A4  System.Void SendPositionBasedEvent(UnityEngine.Vector3 mousePosition, UnityEngine.Vector3 delta, System.Int32 pointerId, System.Nullable<System.Int32> targetDisplay, System.Func<UnityEngine.Vector3,UnityEngine.Vector3,TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg, System.Boolean deselectIfNoTarget)
  RVA=0x09E6D7FC  token=0x60000A5  System.Void UpdateFocusedPanel(UnityEngine.UIElements.BaseRuntimePanel runtimePanel)
  RVA=0x09E6CA1C  token=0x60000A6  UnityEngine.UIElements.EventBase MakeTouchEvent(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers)
  RVA=0x09E6CB18  token=0x60000A7  System.Boolean ProcessTouchEvents()
  RVA=0x09E6C920  token=0x60000A8  UnityEngine.Vector2 GetRawMoveVector()
  RVA=0x09E6D680  token=0x60000A9  System.Boolean ShouldSendMoveFromInput()
  RVA=0x09E6C900  token=0x60000AA  UnityEngine.Vector2 GetLocalScreenPosition(UnityEngine.Event evt, System.Nullable<System.Int32>& targetDisplay)
  RVA=0x09E6D97C  token=0x60000AB  System.Void .ctor()
  RVA=0x09E6D8B8  token=0x60000AC  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.DisposeHelper
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E6DDD0  token=0x60000C8  System.Void NotifyDisposedUsed(System.IDisposable disposable)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuEventInfo
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x30
FIELDS:
  private   readonly UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x10
  private   readonly UnityEngine.Vector2             <mousePosition>k__BackingField  // 0x14
  private   readonly UnityEngine.Vector2             <localMousePosition>k__BackingField  // 0x1c
  private   readonly System.Char                     <character>k__BackingField  // 0x24
  private   readonly UnityEngine.KeyCode             <keyCode>k__BackingField  // 0x28
METHODS:
  RVA=0x09E6DEF4  token=0x60000C9  System.Void .ctor(UnityEngine.UIElements.EventBase e)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuItem
TYPE:  abstract class
TOKEN: 0x2000022
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000CA  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuSeparator
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.DropdownMenuItem
FIELDS:
  private   readonly System.String                   <subMenuPath>k__BackingField  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000CB  System.Void .ctor(System.String subMenuPath)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuAction
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x40
EXTENDS: UnityEngine.UIElements.DropdownMenuItem
FIELDS:
  private   readonly System.String                   <name>k__BackingField  // 0x10
  private           UnityEngine.UIElements.DropdownMenuAction.Status<status>k__BackingField  // 0x18
  private           UnityEngine.UIElements.DropdownMenuEventInfo<eventInfo>k__BackingField  // 0x20
  private           System.Object                   <userData>k__BackingField  // 0x28
  private   readonly System.Action<UnityEngine.UIElements.DropdownMenuAction>actionCallback  // 0x30
  private   readonly System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status>actionStatusCallback  // 0x38
PROPERTIES:
  status  set=0x03D4E9C0
  eventInfo  set=0x04271930
  userData  set=0x02C92F10
METHODS:
  RVA=0x03D88580  token=0x60000CF  UnityEngine.UIElements.DropdownMenuAction.Status AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=0x03D88570  token=0x60000D0  UnityEngine.UIElements.DropdownMenuAction.Status AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction a)
  RVA=0x09E6DEAC  token=0x60000D1  System.Void .ctor(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, System.Object userData)
  RVA=0x09E6DE6C  token=0x60000D2  System.Void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo eventInfo)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenu
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem>m_MenuItems  // 0x10
  private           UnityEngine.UIElements.DropdownMenuEventInfom_DropdownMenuEventInfo  // 0x18
METHODS:
  RVA=0x03D66B80  token=0x60000D3  System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems()
  RVA=0x09E6E21C  token=0x60000D4  System.Void AppendAction(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, System.Object userData)
  RVA=0x09E6E0F8  token=0x60000D5  System.Void AppendAction(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, UnityEngine.UIElements.DropdownMenuAction.Status status)
  RVA=0x09E6E2D8  token=0x60000D6  System.Void AppendSeparator(System.String subMenuPath)
  RVA=0x09E6E3DC  token=0x60000D7  System.Void InsertSeparator(System.String subMenuPath, System.Int32 atIndex)
  RVA=0x09E6E4F4  token=0x60000D8  System.Void PrepareForDisplay(UnityEngine.UIElements.EventBase e)
  RVA=0x09E6E744  token=0x60000D9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DropdownUtility
TYPE:  static class
TOKEN: 0x2000028
SIZE:  0x10
FIELDS:
  private   static  System.Func<UnityEngine.UIElements.IGenericMenu>MakeDropdownFunc  // static @ 0x0
METHODS:
  RVA=0x09E6E7BC  token=0x60000DC  UnityEngine.UIElements.IGenericMenu CreateDropdown()
END_CLASS

CLASS: UnityEngine.UIElements.DispatchMode
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DispatchModeDefault  // const
  public    static  UnityEngine.UIElements.DispatchModeQueued  // const
  public    static  UnityEngine.UIElements.DispatchModeImmediate  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.EventDispatcherGate
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x18
IMPLEMENTS: System.IDisposable System.IEquatable`1
FIELDS:
  private   readonly UnityEngine.UIElements.EventDispatcherm_Dispatcher  // 0x10
METHODS:
  RVA=0x09E6F60C  token=0x60000DD  System.Void .ctor(UnityEngine.UIElements.EventDispatcher d)
  RVA=0x09E6F56C  token=0x60000DE  System.Void Dispose()
  RVA=0x09E6F58C  token=0x60000DF  System.Boolean Equals(UnityEngine.UIElements.EventDispatcherGate other)
  RVA=0x09E6F59C  token=0x60000E0  System.Boolean Equals(System.Object obj)
  RVA=0x0711E2B8  token=0x60000E1  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.EventDispatcher
TYPE:  sealed class
TOKEN: 0x200002B
SIZE:  0x48
FIELDS:
  private           UnityEngine.UIElements.ClickDetectorm_ClickDetector  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.IEventDispatchingStrategy>m_DispatchingStrategies  // 0x18
  private   static readonly UnityEngine.UIElements.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>>k_EventQueuePool  // static @ 0x0
  private           System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>m_Queue  // 0x20
  private   readonly UnityEngine.UIElements.PointerDispatchState<pointerState>k__BackingField  // 0x28
  private           System.UInt32                   m_GateCount  // 0x30
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.EventDispatcher.DispatchContext>m_DispatchContexts  // 0x38
  private   static readonly UnityEngine.UIElements.IEventDispatchingStrategy[]s_EditorStrategies  // static @ 0x8
  private           System.Boolean                  m_Immediate  // 0x40
  private           System.Boolean                  <processingEvents>k__BackingField  // 0x41
PROPERTIES:
  pointerState  get=0x03D4EAC0
  dispatchImmediately  get=0x09E70600
  processingEvents  set=0x03D4F7D0
METHODS:
  RVA=0x09E6F894  token=0x60000E3  UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies)
  RVA=0x09E70440  token=0x60000E4  System.Void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies)
  RVA=0x09E6F8F4  token=0x60000E7  System.Void Dispatch(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x03D88590  token=0x60000E8  System.Void CloseGate()
  RVA=0x09E6FA50  token=0x60000E9  System.Void OpenGate()
  RVA=0x09E6FAB8  token=0x60000EA  System.Void ProcessEventQueue()
  RVA=0x09E6FDE0  token=0x60000EB  System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x09E6F688  token=0x60000EC  System.Void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, System.Boolean imguiEventIsInitiallyUsed)
  RVA=0x09E7015C  token=0x60000ED  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Focusable
TYPE:  abstract class
TOKEN: 0x200002E
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.CallbackEventHandler
FIELDS:
  private           System.Boolean                  <focusable>k__BackingField  // 0x20
  private           System.Int32                    <tabIndex>k__BackingField  // 0x24
  private           System.Boolean                  m_DelegatesFocus  // 0x28
  private           System.Boolean                  m_ExcludeFromFocusRing  // 0x29
PROPERTIES:
  focusController  get=-1  // abstract
  focusable  get=0x03D4EF90  set=0x03D4EFC0
  tabIndex  get=0x03D4E2E0  set=0x03D4E2F0
  delegatesFocus  get=0x03D885B0  set=0x03D4ED60
  excludeFromFocusRing  get=0x03D885C0  set=0x09E71E04
  canGrabFocus  get=0x03D4EF90
METHODS:
  RVA=0x03D885A0  token=0x60000EE  System.Void .ctor()
  RVA=0x09E71BC0  token=0x60000F9  System.Void Focus()
  RVA=0x09E71B7C  token=0x60000FA  System.Void Blur()
  RVA=0x09E71B40  token=0x60000FB  System.Void BlurImmediately()
  RVA=0x09E71D6C  token=0x60000FC  UnityEngine.UIElements.Focusable GetFocusDelegate()
  RVA=0x09E71C58  token=0x60000FD  UnityEngine.UIElements.Focusable GetFirstFocusableChild(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E71BB8  token=0x60000FE  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E71BB8  token=0x60000FF  System.Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E71DC4  token=0x6000100  System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.FocusChangeDirection
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly UnityEngine.UIElements.FocusChangeDirection<unspecified>k__BackingField  // static @ 0x0
  private   static readonly UnityEngine.UIElements.FocusChangeDirection<none>k__BackingField  // static @ 0x8
  private   static readonly UnityEngine.UIElements.FocusChangeDirection<lastValue>k__BackingField  // static @ 0x10
  private   readonly System.Int32                    m_Value  // 0x10
PROPERTIES:
  unspecified  get=0x09E707C4
  none  get=0x09E70774
  lastValue  get=0x09E70724
METHODS:
  RVA=0x010410F0  token=0x6000104  System.Void .ctor(System.Int32 value)
  RVA=0x09E70814  token=0x6000105  System.Int32 op_Implicit(UnityEngine.UIElements.FocusChangeDirection fcd)
  RVA=0x095F944C  token=0x6000106  System.Void System.IDisposable.Dispose()
  RVA=0x0350B670  token=0x6000107  System.Void Dispose()
  RVA=0x09E70614  token=0x6000108  System.Void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f)
  RVA=0x09E70650  token=0x6000109  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IFocusRing
TYPE:  interface
TOKEN: 0x2000030
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600010A  UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e)
  RVA=-1  // abstract  token=0x600010B  UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction)
END_CLASS

CLASS: UnityEngine.UIElements.FocusController
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x38
FIELDS:
  private   readonly UnityEngine.UIElements.IFocusRing<focusRing>k__BackingField  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.FocusController.FocusedElement>m_FocusedElements  // 0x18
  private           UnityEngine.UIElements.Focusablem_LastFocusedElement  // 0x20
  private           UnityEngine.UIElements.Focusablem_LastPendingFocusedElement  // 0x28
  private           System.Int32                    m_PendingFocusCount  // 0x30
  private           System.Int32                    <imguiKeyboardControl>k__BackingField  // 0x34
PROPERTIES:
  focusRing  get=0x020B7B20
  focusedElement  get=0x09E71B00
  imguiKeyboardControl  get=0x03D4EE00  set=0x03D4EE40
METHODS:
  RVA=0x09E71A68  token=0x600010C  System.Void .ctor(UnityEngine.UIElements.IFocusRing focusRing)
  RVA=0x09E711DC  token=0x600010F  System.Boolean IsFocused(UnityEngine.UIElements.Focusable f)
  RVA=0x09E70E9C  token=0x6000110  UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement retargetAgainst)
  RVA=0x09E70E04  token=0x6000111  UnityEngine.UIElements.Focusable GetLeafFocusedElement()
  RVA=0x09E71308  token=0x6000112  System.Boolean IsLocalElement(UnityEngine.UIElements.Focusable f)
  RVA=0x09E7132C  token=0x6000113  System.Boolean IsPendingFocus(UnityEngine.UIElements.Focusable f)
  RVA=0x09E71520  token=0x6000114  System.Void SetFocusToLastFocusedElement()
  RVA=0x09E70A30  token=0x6000115  System.Void BlurLastFocusedElement()
  RVA=0x09E70B00  token=0x6000116  System.Void DoFocusChange(UnityEngine.UIElements.Focusable f)
  RVA=0x09E70C40  token=0x6000117  UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection direction)
  RVA=0x09E70928  token=0x6000118  System.Void AboutToReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E71418  token=0x6000119  System.Void ReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E70820  token=0x600011A  System.Void AboutToGrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E710CC  token=0x600011B  System.Void GrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E70AA8  token=0x600011C  System.Void Blur(UnityEngine.UIElements.Focusable focusable, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E7172C  token=0x600011D  System.Void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E717AC  token=0x600011E  System.Void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, UnityEngine.UIElements.FocusChangeDirection direction, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E71580  token=0x600011F  UnityEngine.UIElements.Focusable SwitchFocusOnEvent(UnityEngine.UIElements.EventBase e)
  RVA=0x09E713A8  token=0x6000120  System.Void ReevaluateFocus()
  RVA=0x09E70D20  token=0x6000121  System.Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable target, UnityEngine.UIElements.Focusable& effectiveTarget)
  RVA=0x09E719CC  token=0x6000124  System.Void SyncIMGUIFocus(System.Int32 imguiKeyboardControlID, UnityEngine.UIElements.Focusable imguiContainerHavingKeyboardControl, System.Boolean forceSwitch)
END_CLASS

CLASS: UnityEngine.UIElements.GroupBoxUtility
TYPE:  static class
TOKEN: 0x2000033
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox,UnityEngine.UIElements.IGroupManager>s_GroupManagers  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption,UnityEngine.UIElements.IGroupManager>s_GroupOptionManagerCache  // static @ 0x8
  private   static readonly System.Type                     k_GenericGroupBoxType  // static @ 0x10
METHODS:
  RVA=-1  // generic def  token=0x6000125  System.Void RegisterGroupBoxOptionCallbacks(T option)
  RVA=-1  // generic def  token=0x6000126  System.Void OnOptionSelected(T selectedOption)
  RVA=0x09E722C8  token=0x6000127  System.Void OnOptionAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09E724A8  token=0x6000128  System.Void OnOptionDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09E71EBC  token=0x6000129  UnityEngine.UIElements.IGroupManager FindOrCreateGroupManager(UnityEngine.UIElements.IGroupBox groupBox)
  RVA=0x09E7221C  token=0x600012A  System.Void OnGroupBoxDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09E72634  token=0x600012B  System.Void OnPanelDestroyed(UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09E72700  token=0x600012C  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IGroupBoxOption
TYPE:  interface
TOKEN: 0x2000034
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600012D  System.Void SetSelected(System.Boolean selected)
END_CLASS

CLASS: UnityEngine.UIElements.IGroupBox
TYPE:  interface
TOKEN: 0x2000035
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IGroupBox`1
TYPE:  interface
TOKEN: 0x2000036
IMPLEMENTS: UnityEngine.UIElements.IGroupBox
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IGroupManager
TYPE:  interface
TOKEN: 0x2000037
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600012E  System.Void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption)
  RVA=-1  // abstract  token=0x600012F  System.Void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option)
  RVA=-1  // abstract  token=0x6000130  System.Void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option)
END_CLASS

CLASS: UnityEngine.UIElements.DefaultGroupManager
TYPE:  class
TOKEN: 0x2000038
SIZE:  0x20
IMPLEMENTS: UnityEngine.UIElements.IGroupManager
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption>m_GroupOptions  // 0x10
  private           UnityEngine.UIElements.IGroupBoxOptionm_SelectedOption  // 0x18
METHODS:
  RVA=0x09E6DAF4  token=0x6000131  System.Void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption)
  RVA=0x09E6DC84  token=0x6000132  System.Void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option)
  RVA=0x09E6DD04  token=0x6000133  System.Void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option)
  RVA=0x09E6DD58  token=0x6000134  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IMGUIContainer
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x4D8
EXTENDS: UnityEngine.UIElements.VisualElement
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Action                   m_OnGUIHandler  // 0x3c0
  private           UnityEngine.ObjectGUIState      m_ObjectGUIState  // 0x3c8
  private           System.Boolean                  useOwnerObjectGUIState  // 0x3d0
  private           UnityEngine.Rect                <lastWorldClip>k__BackingField  // 0x3d4
  private           System.Boolean                  m_CullingEnabled  // 0x3e4
  private           System.Boolean                  m_IsFocusDelegated  // 0x3e5
  private           System.Boolean                  m_RefreshCachedLayout  // 0x3e6
  private           UnityEngine.GUILayoutUtility.LayoutCachem_Cache  // 0x3e8
  private           UnityEngine.Rect                m_CachedClippingRect  // 0x3f0
  private           UnityEngine.Matrix4x4           m_CachedTransform  // 0x400
  private           UnityEngine.UIElements.ContextType<contextType>k__BackingField  // 0x440
  private           System.Boolean                  lostFocus  // 0x444
  private           System.Boolean                  receivedFocus  // 0x445
  private           UnityEngine.UIElements.FocusChangeDirectionfocusChangeDirection  // 0x448
  private           System.Boolean                  hasFocusableControls  // 0x450
  private           System.Int32                    newKeyboardFocusControlID  // 0x454
  private           System.Boolean                  <focusOnlyIfHasFocusableControls>k__BackingField  // 0x458
  public    static readonly System.String                   ussClassName  // static @ 0x0
  private   static readonly System.String                   ussFoldoutChildDepthClassName  // static @ 0x8
  private   static readonly System.Collections.Generic.List<System.String>ussFoldoutChildDepthClassNames  // static @ 0x10
  private           UnityEngine.UIElements.IMGUIContainer.GUIGlobalsm_GUIGlobals  // 0x45c
  private   static readonly Unity.Profiling.ProfilerMarker  k_OnGUIMarker  // static @ 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  k_ImmediateCallbackMarker  // static @ 0x20
  private   static  UnityEngine.Event               s_DefaultMeasureEvent  // static @ 0x28
  private   static  UnityEngine.Event               s_MeasureEvent  // static @ 0x30
  private   static  UnityEngine.Event               s_CurrentEvent  // static @ 0x38
PROPERTIES:
  onGUIHandler  get=0x03D88610  set=0x09E75BF0
  guiState  get=0x09E75AE8
  lastWorldClip  get=0x03D88600  set=0x03D88630
  cullingEnabled  get=0x03D885E0
  cache  get=0x09E75A44
  layoutMeasuredWidth  get=0x09E75BC0
  layoutMeasuredHeight  get=0x09E75B90
  contextType  get=0x03D885D0  set=0x03D88620
  focusOnlyIfHasFocusableControls  get=0x03D885F0
  canGrabFocus  get=0x09E75AC4
METHODS:
  RVA=0x09E75478  token=0x6000142  System.Void .cctor()
  RVA=0x09E75A38  token=0x6000143  System.Void .ctor()
  RVA=0x09E75854  token=0x6000144  System.Void .ctor(System.Action onGUIHandler)
  RVA=0x09E74BE4  token=0x6000145  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  RVA=0x09E74E3C  token=0x6000146  System.Void SaveGlobals()
  RVA=0x09E74CFC  token=0x6000147  System.Void RestoreGlobals()
  RVA=0x09E72F5C  token=0x6000148  System.Void DoOnGUI(UnityEngine.Event evt, UnityEngine.Matrix4x4 parentTransform, UnityEngine.Rect clippingRect, System.Boolean isComputingLayout, UnityEngine.Rect layoutSize, System.Action onGUIHandler, System.Boolean canAffectFocus)
  RVA=0x09E74BD0  token=0x6000149  System.Void MarkDirtyLayout()
  RVA=0x09E74328  token=0x600014A  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E729F0  token=0x600014B  System.Void DoIMGUIRepaint()
  RVA=0x09E75014  token=0x600014C  System.Boolean SendEventToIMGUI(UnityEngine.UIElements.EventBase evt, System.Boolean canAffectFocus, System.Boolean verifyBounds)
  RVA=0x09E74F3C  token=0x600014D  System.Boolean SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase evt, System.Boolean canAffectFocus, System.Boolean verifyBounds)
  RVA=0x09E753E8  token=0x600014E  System.Boolean VerifyBounds(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E747CC  token=0x600014F  System.Boolean IsContainerCapturingTheMouse()
  RVA=0x09E74A3C  token=0x6000150  System.Boolean IsLocalEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E7492C  token=0x6000151  System.Boolean IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E74864  token=0x6000152  System.Boolean IsDockAreaMouseUp(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E74490  token=0x6000153  System.Boolean HandleIMGUIEvent(UnityEngine.Event e, System.Boolean canAffectFocus)
  RVA=0x09E743A8  token=0x6000154  System.Boolean HandleIMGUIEvent(UnityEngine.Event e, System.Action onGUIHandler, System.Boolean canAffectFocus)
  RVA=0x09E744B4  token=0x6000155  System.Boolean HandleIMGUIEvent(UnityEngine.Event e, UnityEngine.Matrix4x4 worldTransform, UnityEngine.Rect clippingRect, System.Action onGUIHandler, System.Boolean canAffectFocus)
  RVA=0x09E73EBC  token=0x6000156  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E752A4  token=0x6000157  System.Void SetFoldoutDepthClass()
  RVA=0x09E72CD0  token=0x6000158  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09E74120  token=0x6000159  UnityEngine.Rect GetCurrentClipRect()
  RVA=0x09E74198  token=0x600015A  System.Void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer container, UnityEngine.Event evt, UnityEngine.Matrix4x4& transform, UnityEngine.Rect& clipRect)
  RVA=0x09E72980  token=0x600015B  System.Void Dispose()
  RVA=0x09E729D0  token=0x600015C  System.Void Dispose(System.Boolean disposeManaged)
  RVA=0x09E753D8  token=0x600015D  System.Void <DoOnGUI>b__56_0()
END_CLASS

CLASS: UnityEngine.UIElements.ImmediateModeException
TYPE:  class
TOKEN: 0x200003D
SIZE:  0x90
EXTENDS: System.Exception
FIELDS:
METHODS:
  RVA=0x09E75C50  token=0x6000160  System.Void .ctor(System.Exception inner)
END_CLASS

CLASS: UnityEngine.UIElements.SelectionType
TYPE:  sealed struct
TOKEN: 0x200003E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.SelectionTypeNone  // const
  public    static  UnityEngine.UIElements.SelectionTypeSingle  // const
  public    static  UnityEngine.UIElements.SelectionTypeMultiple  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ISerializableJsonDictionary
TYPE:  interface
TOKEN: 0x200003F
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000161  System.Void Set(System.String key, T value)
  RVA=-1  // abstract  token=0x6000162  T Get(System.String key)
  RVA=-1  // abstract  token=0x6000163  System.Void Overwrite(System.Object obj, System.String key)
  RVA=-1  // abstract  token=0x6000164  System.Boolean ContainsKey(System.String key)
END_CLASS

CLASS: UnityEngine.UIElements.ITransform
TYPE:  interface
TOKEN: 0x2000040
FIELDS:
PROPERTIES:
  position  get=-1  // abstract  set=-1  // abstract
  scale  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardNavigationOperation
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationNone  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationSelectAll  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationCancel  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationSubmit  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationPrevious  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationNext  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationMoveRight  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationMoveLeft  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationPageUp  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationPageDown  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationBegin  // const
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationEnd  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardNavigationManipulator
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x20
EXTENDS: UnityEngine.UIElements.Manipulator
FIELDS:
  private   readonly System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase>m_Action  // 0x18
METHODS:
  RVA=0x022C3A90  token=0x6000168  System.Void .ctor(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> action)
  RVA=0x09E75E50  token=0x6000169  System.Void RegisterCallbacksOnTarget()
  RVA=0x09E761EC  token=0x600016A  System.Void UnregisterCallbacksFromTarget()
  RVA=0x09E75D34  token=0x600016B  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=0x09E75E14  token=0x600016C  System.Void OnRuntimeKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=0x09E75CF8  token=0x600016D  System.Void OnEditorKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=0x09E75D94  token=0x600016E  System.Void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent evt)
  RVA=0x09E75E04  token=0x600016F  System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt)
  RVA=0x09E75DA4  token=0x6000170  System.Void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent evt)
  RVA=0x09E75CD4  token=0x6000171  System.Void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation operation, UnityEngine.UIElements.EventBase evt)
  RVA=0x09E76144  token=0x6000172  UnityEngine.UIElements.KeyboardNavigationOperation <OnRuntimeKeyDown>g__GetOperation|5_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass5_0& )
  RVA=0x09E7604C  token=0x6000173  UnityEngine.UIElements.KeyboardNavigationOperation <OnEditorKeyDown>g__GetOperation|6_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass6_0& )
END_CLASS

CLASS: UnityEngine.UIElements.ManipulatorActivationFilter
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.MouseButton<button>k__BackingField  // 0x10
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x14
  private           System.Int32                    <clickCount>k__BackingField  // 0x18
PROPERTIES:
  button  get=0x03D4E980  set=0x03D4E970
  modifiers  get=0x03D4E990  set=0x03D51720
  clickCount  get=0x03D516F0
METHODS:
  RVA=0x09E764BC  token=0x6000179  System.Boolean Equals(System.Object obj)
  RVA=0x051408A4  token=0x600017A  System.Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter other)
  RVA=0x03D88640  token=0x600017B  System.Int32 GetHashCode()
  RVA=0x09E76754  token=0x600017C  System.Boolean Matches(UnityEngine.UIElements.IMouseEvent e)
  RVA=0x09E765C4  token=0x600017D  System.Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent e)
  RVA=0x09E766D4  token=0x600017E  System.Boolean Matches(UnityEngine.UIElements.IPointerEvent e)
  RVA=0x09E7653C  token=0x600017F  System.Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent e)
  RVA=0x09E7664C  token=0x6000180  System.Boolean MatchModifiers(System.Boolean alt, System.Boolean ctrl, System.Boolean shift, System.Boolean command)
END_CLASS

CLASS: UnityEngine.UIElements.IManipulator
TYPE:  interface
TOKEN: 0x2000046
FIELDS:
PROPERTIES:
  target  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Manipulator
TYPE:  abstract class
TOKEN: 0x2000047
SIZE:  0x18
IMPLEMENTS: UnityEngine.UIElements.IManipulator
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_Target  // 0x10
PROPERTIES:
  target  get=0x03D66B80  set=0x09E767D4
METHODS:
  RVA=-1  // abstract  token=0x6000182  System.Void RegisterCallbacksOnTarget()
  RVA=-1  // abstract  token=0x6000183  System.Void UnregisterCallbacksFromTarget()
  RVA=0x0350B670  token=0x6000186  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseButton
TYPE:  sealed struct
TOKEN: 0x2000048
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MouseButtonLeftMouse  // const
  public    static  UnityEngine.UIElements.MouseButtonRightMouse  // const
  public    static  UnityEngine.UIElements.MouseButtonMiddleMouse  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureController
TYPE:  static class
TOKEN: 0x2000049
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E768BC  token=0x6000187  System.Boolean HasMouseCapture(UnityEngine.UIElements.IEventHandler handler)
  RVA=0x09E76824  token=0x6000188  System.Void CaptureMouse(UnityEngine.UIElements.IEventHandler handler)
  RVA=0x09E7692C  token=0x6000189  System.Void ReleaseMouse(UnityEngine.UIElements.IEventHandler handler)
END_CLASS

CLASS: UnityEngine.UIElements.MouseManipulator
TYPE:  abstract class
TOKEN: 0x200004A
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.Manipulator
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter><activators>k__BackingField  // 0x18
  private           UnityEngine.UIElements.ManipulatorActivationFilterm_currentActivator  // 0x20
PROPERTIES:
  activators  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09E76B4C  token=0x600018C  System.Void .ctor()
  RVA=0x09E769C4  token=0x600018D  System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent e)
  RVA=0x09E76B28  token=0x600018E  System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent e)
END_CLASS

CLASS: UnityEngine.UIElements.ObjectPool`1
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private   readonly System.Collections.Generic.Stack<T>m_Stack  // 0x0
  private           System.Int32                    m_MaxSize  // 0x0
PROPERTIES:
  maxSize  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000191  System.Void .ctor(System.Int32 maxSize)
  RVA=-1  // not resolved  token=0x6000192  System.Int32 Size()
  RVA=-1  // not resolved  token=0x6000193  T Get()
  RVA=-1  // not resolved  token=0x6000194  System.Void Release(T element)
END_CLASS

CLASS: UnityEngine.UIElements.ContextType
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ContextTypePlayer  // const
  public    static  UnityEngine.UIElements.ContextTypeEditor  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VersionChangeType
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VersionChangeTypeBindings  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeViewData  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeHierarchy  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeLayout  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeStyleSheet  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeStyles  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeOverflow  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeBorderRadius  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeBorderWidth  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeTransform  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeSize  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeRepaint  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeOpacity  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeColor  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeRenderHints  // const
  public    static  UnityEngine.UIElements.VersionChangeTypeTransitionProperty  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UsageHints
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UsageHintsNone  // const
  public    static  UnityEngine.UIElements.UsageHintsDynamicTransform  // const
  public    static  UnityEngine.UIElements.UsageHintsGroupTransform  // const
  public    static  UnityEngine.UIElements.UsageHintsMaskContainer  // const
  public    static  UnityEngine.UIElements.UsageHintsDynamicColor  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.RenderHints
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.RenderHintsNone  // const
  public    static  UnityEngine.UIElements.RenderHintsGroupTransform  // const
  public    static  UnityEngine.UIElements.RenderHintsBoneTransform  // const
  public    static  UnityEngine.UIElements.RenderHintsClipWithScissors  // const
  public    static  UnityEngine.UIElements.RenderHintsMaskContainer  // const
  public    static  UnityEngine.UIElements.RenderHintsDynamicColor  // const
  public    static  UnityEngine.UIElements.RenderHintsDirtyOffset  // const
  public    static  UnityEngine.UIElements.RenderHintsDirtyGroupTransform  // const
  public    static  UnityEngine.UIElements.RenderHintsDirtyBoneTransform  // const
  public    static  UnityEngine.UIElements.RenderHintsDirtyClipWithScissors  // const
  public    static  UnityEngine.UIElements.RenderHintsDirtyMaskContainer  // const
  public    static  UnityEngine.UIElements.RenderHintsDirtyAll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PanelClearSettings
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x24
FIELDS:
  public            System.Boolean                  clearDepthStencil  // 0x10
  public            System.Boolean                  clearColor  // 0x11
  public            UnityEngine.Color               color  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.RepaintData
TYPE:  class
TOKEN: 0x2000051
SIZE:  0x70
FIELDS:
  private           UnityEngine.Matrix4x4           <currentOffset>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <mousePosition>k__BackingField  // 0x50
  private           UnityEngine.Rect                <currentWorldClip>k__BackingField  // 0x58
  private           UnityEngine.Event               <repaintEvent>k__BackingField  // 0x68
PROPERTIES:
  currentOffset  get=0x03D5E0E0
  currentWorldClip  get=0x03D50820
  repaintEvent  get=0x03D4EAB0  set=0x038C5570
METHODS:
  RVA=0x09E77DE8  token=0x6000199  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.HierarchyEvent
TYPE:  sealed class
TOKEN: 0x2000052
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09E72858  token=0x600019A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x600019B  System.Void Invoke(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType)
END_CLASS

CLASS: UnityEngine.UIElements.IPanel
TYPE:  interface
TOKEN: 0x2000053
IMPLEMENTS: System.IDisposable
FIELDS:
PROPERTIES:
  visualTree  get=-1  // abstract
  dispatcher  get=-1  // abstract
  contextType  get=-1  // abstract
  focusController  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60001A0  UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point)
END_CLASS

CLASS: UnityEngine.UIElements.BaseVisualElementPanel
TYPE:  abstract class
TOKEN: 0x2000054
SIZE:  0xA0
IMPLEMENTS: UnityEngine.UIElements.IPanel System.IDisposable UnityEngine.UIElements.IGroupBox
FIELDS:
  private           System.Action<UnityEngine.UIElements.BaseVisualElementPanel>panelDisposed  // 0x10
  private           System.Single                   m_Scale  // 0x18
  private           UnityEngine.Yoga.YogaConfig     yogaConfig  // 0x20
  private           System.Single                   m_PixelsPerPoint  // 0x28
  private           UnityEngine.UIElements.PanelClearSettings<clearSettings>k__BackingField  // 0x2c
  private           System.Boolean                  <duringLayoutPhase>k__BackingField  // 0x40
  private           UnityEngine.UIElements.RepaintData<repaintData>k__BackingField  // 0x48
  private           UnityEngine.UIElements.ICursorManager<cursorManager>k__BackingField  // 0x50
  private           UnityEngine.UIElements.ContextualMenuManager<contextualMenuManager>k__BackingField  // 0x58
  private           System.Boolean                  <disposed>k__BackingField  // 0x60
  private           UnityEngine.UIElements.ElementUnderPointerm_TopElementUnderPointers  // 0x68
  private           System.Action                   standardShaderChanged  // 0x70
  private           System.Action                   standardWorldSpaceShaderChanged  // 0x78
  private           System.Action                   atlasChanged  // 0x80
  private           System.Action<UnityEngine.Material>updateMaterial  // 0x88
  private           UnityEngine.UIElements.HierarchyEventhierarchyChanged  // 0x90
  private           System.Action<UnityEngine.UIElements.IPanel>beforeUpdate  // 0x98
PROPERTIES:
  IMGUIEventInterests  get=-1  // abstract  set=-1  // abstract
  ownerObject  get=-1  // abstract  set=-1  // abstract
  saveViewData  get=-1  // abstract
  getViewDataDictionary  get=-1  // abstract
  IMGUIContainersCount  get=-1  // abstract  set=-1  // abstract
  focusController  get=-1  // abstract  set=-1  // abstract
  rootIMGUIContainer  get=-1  // abstract
  scale  get=0x03D85C60  set=0x09E694A4
  pixelsPerPoint  set=0x09E69410
  scaledPixelsPerPoint  get=0x03D88510
  clearSettings  get=0x03D884F0  set=0x03D88520
  duringLayoutPhase  get=0x03D4EE90  set=0x03D4EEB0
  version  get=-1  // abstract
  hierarchyVersion  get=-1  // abstract
  repaintData  get=0x03D4EA70  set=0x02692290
  cursorManager  get=0x03D4EAF0  set=0x02C926C0
  contextualMenuManager  get=0x03D4EAA0  set=0x03081D30
  visualTree  get=-1  // abstract
  dispatcher  get=-1  // abstract  set=-1  // abstract
  scheduler  get=-1  // abstract
  styleAnimationSystem  get=-1  // abstract  set=-1  // abstract
  contextType  get=-1  // abstract  set=-1  // abstract
  disposed  get=0x03D519A0  set=0x03D519B0
  standardShader  get=-1  // abstract
  standardWorldSpaceShader  get=0x03D85B20
  atlas  get=-1  // abstract  set=-1  // abstract
EVENTS:
  panelDisposed  add=add_panelDisposed  remove=remove_panelDisposed
  standardShaderChanged  add=add_standardShaderChanged  remove=remove_standardShaderChanged
  standardWorldSpaceShaderChanged  add=add_standardWorldSpaceShaderChanged  remove=remove_standardWorldSpaceShaderChanged
  atlasChanged  add=add_atlasChanged  remove=remove_atlasChanged
  hierarchyChanged  add=add_hierarchyChanged  remove=remove_hierarchyChanged
METHODS:
  RVA=0x09E68D28  token=0x60001AE  System.Void .ctor()
  RVA=0x09E6877C  token=0x60001AF  System.Void Dispose()
  RVA=0x09E687CC  token=0x60001B0  System.Void Dispose(System.Boolean disposing)
  RVA=-1  // abstract  token=0x60001B1  System.Void Repaint(UnityEngine.Event e)
  RVA=-1  // abstract  token=0x60001B2  System.Void ValidateLayout()
  RVA=-1  // abstract  token=0x60001B3  System.Void UpdateAnimations()
  RVA=-1  // abstract  token=0x60001B4  System.Void UpdateBindings()
  RVA=-1  // abstract  token=0x60001B5  System.Void ApplyStyles()
  RVA=-1  // abstract  token=0x60001C0  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.VersionChangeType changeTypeFlag)
  RVA=0x09E68A48  token=0x60001CA  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=-1  // abstract  token=0x60001D0  UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point)
  RVA=-1  // abstract  token=0x60001D1  UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  RVA=-1  // abstract  token=0x60001D4  UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  RVA=0x09E688C0  token=0x60001D5  UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId)
  RVA=0x09E68950  token=0x60001D6  UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(System.Int32 pointerId, UnityEngine.Vector2 pointerPos, UnityEngine.UIElements.EventBase triggerEvent)
  RVA=0x09E686F0  token=0x60001D7  System.Void ClearCachedElementUnderPointer(System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent)
  RVA=0x09E68720  token=0x60001D8  System.Void CommitElementUnderPointers()
  RVA=0x09E688E0  token=0x60001E1  System.Void InvokeAtlasChanged()
  RVA=0x09E68938  token=0x60001E4  System.Void InvokeUpdateMaterial(UnityEngine.Material mat)
  RVA=0x09E68910  token=0x60001E7  System.Void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType)
  RVA=0x09E688F4  token=0x60001E8  System.Void InvokeBeforeUpdate()
  RVA=0x09E68AE0  token=0x60001E9  System.Void UpdateElementUnderPointers()
  RVA=0x09E68C84  token=0x60001EA  System.Void Update()
END_CLASS

CLASS: UnityEngine.UIElements.LoadResourceFunction
TYPE:  sealed class
TOKEN: 0x2000055
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09E763E8  token=0x60001EB  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01022980  token=0x60001EC  UnityEngine.Object Invoke(System.String pathName, System.Type type, System.Single dpiScaling)
END_CLASS

CLASS: UnityEngine.UIElements.TimeMsFunction
TYPE:  sealed class
TOKEN: 0x2000056
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06F0B438  token=0x60001ED  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x06F0A8DC  token=0x60001EE  System.Int64 Invoke()
END_CLASS

CLASS: UnityEngine.UIElements.GetViewDataDictionary
TYPE:  sealed class
TOKEN: 0x2000057
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06F0B438  token=0x60001EF  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x06F0A8DC  token=0x60001F0  UnityEngine.UIElements.ISerializableJsonDictionary Invoke()
END_CLASS

CLASS: UnityEngine.UIElements.SavePersistentViewData
TYPE:  sealed class
TOKEN: 0x2000058
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x60001F1  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x60001F2  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.UIElements.Panel
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x158
EXTENDS: UnityEngine.UIElements.BaseVisualElementPanel
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_RootContainer  // 0xa0
  private           UnityEngine.UIElements.VisualTreeUpdaterm_VisualTreeUpdater  // 0xa8
  private           UnityEngine.UIElements.IStylePropertyAnimationSystemm_StylePropertyAnimationSystem  // 0xb0
  private           System.String                   m_PanelName  // 0xb8
  private           System.UInt32                   m_Version  // 0xc0
  private           System.UInt32                   m_RepaintVersion  // 0xc4
  private           System.UInt32                   m_HierarchyVersion  // 0xc8
  private           Unity.Profiling.ProfilerMarker  m_MarkerBeforeUpdate  // 0xd0
  private           Unity.Profiling.ProfilerMarker  m_MarkerUpdate  // 0xd8
  private           Unity.Profiling.ProfilerMarker  m_MarkerLayout  // 0xe0
  private           Unity.Profiling.ProfilerMarker  m_MarkerBindings  // 0xe8
  private           Unity.Profiling.ProfilerMarker  m_MarkerAnimations  // 0xf0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerPickAll  // static @ 0x0
  private           UnityEngine.UIElements.EventDispatcher<dispatcher>k__BackingField  // 0xf8
  private           UnityEngine.UIElements.TimerEventSchedulerm_Scheduler  // 0x100
  private           UnityEngine.ScriptableObject    <ownerObject>k__BackingField  // 0x108
  private           UnityEngine.UIElements.ContextType<contextType>k__BackingField  // 0x110
  private           UnityEngine.UIElements.SavePersistentViewData<saveViewData>k__BackingField  // 0x118
  private           UnityEngine.UIElements.GetViewDataDictionary<getViewDataDictionary>k__BackingField  // 0x120
  private           UnityEngine.UIElements.FocusController<focusController>k__BackingField  // 0x128
  private           UnityEngine.EventInterests      <IMGUIEventInterests>k__BackingField  // 0x130
  private   static  UnityEngine.UIElements.LoadResourceFunction<loadResourceFunc>k__BackingField  // static @ 0x8
  private   static  UnityEngine.UIElements.TimeMsFunction<TimeSinceStartup>k__BackingField  // static @ 0x10
  private           System.Int32                    <IMGUIContainersCount>k__BackingField  // 0x134
  private           UnityEngine.UIElements.IMGUIContainer<rootIMGUIContainer>k__BackingField  // 0x138
  private           UnityEngine.Shader              m_StandardShader  // 0x140
  private           UnityEngine.UIElements.AtlasBasem_Atlas  // 0x148
  private           System.Boolean                  m_ValidatingLayout  // 0x150
  private   static  System.Action<UnityEngine.UIElements.Panel>beforeAnyRepaint  // static @ 0x18
PROPERTIES:
  visualTree  get=0x03D87D10
  dispatcher  get=0x03D50160  set=0x0554D2E0
  timerEventScheduler  get=0x09E77C3C
  scheduler  get=0x09E77C30
  styleAnimationSystem  get=0x03D4EAD0  set=0x09E77D50
  ownerObject  get=0x03D56D30  set=0x0589D950
  contextType  get=0x03D5D640  set=0x03D5D660
  saveViewData  get=0x03D571F0
  getViewDataDictionary  get=0x03D56D50
  focusController  get=0x03D56F00  set=0x04275CB8
  IMGUIEventInterests  get=0x03D88680  set=0x03D886D0
  loadResourceFunc  get=0x09E77BE0
  name  get=0x03D87DD0  set=0x09E77D28
  TimeSinceStartup  get=0x09E77B90
  IMGUIContainersCount  get=0x03D4FC40  set=0x03D886C0
  rootIMGUIContainer  get=0x03D56EF0
  version  get=0x03D57EF0
  hierarchyVersion  get=0x03D51FB0
  standardShader  get=0x03D886B0
  atlas  get=0x03D886A0  set=0x09E77CB8
METHODS:
  RVA=0x09E76F34  token=0x6000205  UnityEngine.Object LoadResource(System.String pathName, System.Type type, System.Single dpiScaling)
  RVA=0x09E76EE4  token=0x6000206  System.Void Focus()
  RVA=0x09E76BEC  token=0x6000207  System.Void Blur()
  RVA=0x09E76C18  token=0x600020A  System.Void CreateMarkers()
  RVA=0x09E77830  token=0x6000214  System.Void .ctor(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.EventDispatcher dispatcher)
  RVA=0x09E76E8C  token=0x6000215  System.Void Dispose(System.Boolean disposing)
  RVA=0x09E775E8  token=0x6000216  System.Int64 TimeSinceStartupMs()
  RVA=0x09E76E6C  token=0x6000217  System.Int64 DefaultTimeSinceStartupMs()
  RVA=0x09E772A4  token=0x6000218  UnityEngine.UIElements.VisualElement PickAll(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  RVA=0x09E77024  token=0x6000219  UnityEngine.UIElements.VisualElement PerformPick(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  RVA=0x09E77200  token=0x600021A  UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  RVA=0x09E77308  token=0x600021B  UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point)
  RVA=0x09E7775C  token=0x600021C  System.Void ValidateLayout()
  RVA=0x09E77680  token=0x600021D  System.Void UpdateAnimations()
  RVA=0x09E776A8  token=0x600021E  System.Void UpdateBindings()
  RVA=0x09E76BC4  token=0x600021F  System.Void ApplyStyles()
  RVA=0x09E776D0  token=0x6000220  System.Void UpdateForRepaint()
  RVA=0x09E77434  token=0x6000221  System.Void Repaint(UnityEngine.Event e)
  RVA=0x09E76FDC  token=0x6000222  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09E76F10  token=0x6000223  UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  RVA=0x09E777D0  token=0x6000224  System.Void .cctor()
  RVA=0x09E77678  token=0x6000225  UnityEngine.Vector2Int <Pick>g__PixelOf|99_0(UnityEngine.Vector2 p)
END_CLASS

CLASS: UnityEngine.UIElements.BaseRuntimePanel
TYPE:  abstract class
TOKEN: 0x200005A
SIZE:  0x1D8
EXTENDS: UnityEngine.UIElements.Panel
FIELDS:
  private           UnityEngine.GameObject          m_SelectableGameObject  // 0x158
  private   static  System.Int32                    s_CurrentRuntimePanelCounter  // static @ 0x0
  private   readonly System.Int32                    m_RuntimePanelCreationIndex  // 0x160
  private           System.Single                   m_SortingPriority  // 0x164
  private           System.Action                   destroyed  // 0x168
  private           UnityEngine.Shader              m_StandardWorldSpaceShader  // 0x170
  private           System.Boolean                  m_DrawToCameras  // 0x178
  private           UnityEngine.RenderTexture       targetTexture  // 0x180
  private           UnityEngine.Matrix4x4           panelToWorld  // 0x188
  private           System.Int32                    <targetDisplay>k__BackingField  // 0x1c8
  private   static readonly System.Func<UnityEngine.Vector2,UnityEngine.Vector2>DefaultScreenToPanelSpace  // static @ 0x8
  private           System.Func<UnityEngine.Vector2,UnityEngine.Vector2>m_ScreenToPanelSpace  // 0x1d0
PROPERTIES:
  selectableGameObject  get=0x03D570A0  set=0x09E685E4
  sortingPriority  get=0x03D58290  set=0x09E68678
  standardWorldSpaceShader  get=0x03D884D0
  drawToCameras  get=0x03D884C0  set=0x09E684F4
  targetDisplay  get=0x03D5DDB0  set=0x03D884E0
  screenRenderingWidth  get=0x09E683A4
  screenRenderingHeight  get=0x09E682EC
  screenToPanelSpace  get=0x03D57000  set=0x09E6856C
EVENTS:
  destroyed  add=add_destroyed  remove=remove_destroyed
METHODS:
  RVA=0x09E68140  token=0x600022C  System.Void .ctor(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.EventDispatcher dispatcher)
  RVA=0x09E67B7C  token=0x600022D  System.Void Dispose(System.Boolean disposing)
  RVA=0x09E67CD8  token=0x6000235  System.Void Repaint(UnityEngine.Event e)
  RVA=0x09E67ED8  token=0x6000238  UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2 screen)
  RVA=0x09E67F28  token=0x6000239  System.Boolean ScreenToPanel(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenDelta, UnityEngine.Vector2& panelPosition, UnityEngine.Vector2& panelDelta, System.Boolean allowOutside)
  RVA=0x09E678CC  token=0x600023A  System.Void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel panel)
  RVA=0x09E67C44  token=0x600023B  System.Void PointerLeavesPanel(System.Int32 pointerId, UnityEngine.Vector2 position)
  RVA=0x09E67BC0  token=0x600023C  System.Void PointerEntersPanel(System.Int32 pointerId, UnityEngine.Vector2 position)
  RVA=0x09E68064  token=0x600023D  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IRuntimePanelComponent
TYPE:  interface
TOKEN: 0x200005C
FIELDS:
PROPERTIES:
  panel  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureHelper
TYPE:  static class
TOKEN: 0x200005D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E7C7A0  token=0x6000242  UnityEngine.UIElements.PointerDispatchState GetStateFor(UnityEngine.UIElements.IEventHandler handler)
  RVA=0x09E7C808  token=0x6000243  System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  RVA=0x09E7C720  token=0x6000244  System.Void CapturePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  RVA=0x09E7C8B4  token=0x6000245  System.Void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  RVA=0x09E7C758  token=0x6000246  UnityEngine.UIElements.IEventHandler GetCapturingElement(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  RVA=0x09E7C8EC  token=0x6000247  System.Void ReleasePointer(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  RVA=0x09E7C6E8  token=0x6000248  System.Void ActivateCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  RVA=0x09E7C844  token=0x6000249  System.Void PreventCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  RVA=0x09E7C924  token=0x600024A  System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.IPointerEvent evt)
  RVA=0x09E7C87C  token=0x600024B  System.Void ProcessPointerCapture(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
END_CLASS

CLASS: UnityEngine.UIElements.PointerDispatchState
TYPE:  class
TOKEN: 0x200005E
SIZE:  0x28
FIELDS:
  private           UnityEngine.UIElements.IEventHandler[]m_PendingPointerCapture  // 0x10
  private           UnityEngine.UIElements.IEventHandler[]m_PointerCapture  // 0x18
  private           System.Boolean[]                m_ShouldSendCompatibilityMouseEvents  // 0x20
METHODS:
  RVA=0x09E7D264  token=0x600024C  System.Void .ctor()
  RVA=0x09E7D18C  token=0x600024D  System.Void Reset()
  RVA=0x0594E120  token=0x600024E  UnityEngine.UIElements.IEventHandler GetCapturingElement(System.Int32 pointerId)
  RVA=0x09E7CAF8  token=0x600024F  System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  RVA=0x09E7CA10  token=0x6000250  System.Void CapturePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  RVA=0x09E7D124  token=0x6000251  System.Void ReleasePointer(System.Int32 pointerId)
  RVA=0x09E7D148  token=0x6000252  System.Void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  RVA=0x09E7CB58  token=0x6000253  System.Void ProcessPointerCapture(System.Int32 pointerId)
  RVA=0x09E7C9E0  token=0x6000254  System.Void ActivateCompatibilityMouseEvents(System.Int32 pointerId)
  RVA=0x09E7CB28  token=0x6000255  System.Void PreventCompatibilityMouseEvents(System.Int32 pointerId)
  RVA=0x09E7D204  token=0x6000256  System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.PointerManipulator
TYPE:  abstract class
TOKEN: 0x200005F
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.MouseManipulator
FIELDS:
  private           System.Int32                    m_CurrentPointerId  // 0x30
METHODS:
  RVA=0x09E7D338  token=0x6000257  System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent e)
  RVA=0x09E7D4A4  token=0x6000258  System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent e)
  RVA=0x09E7D4C8  token=0x6000259  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ProjectionUtils
TYPE:  static class
TOKEN: 0x2000060
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E7D4D0  token=0x600025A  UnityEngine.Matrix4x4 Ortho(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single near, System.Single far)
END_CLASS

CLASS: UnityEngine.UIElements.TimerState
TYPE:  sealed struct
TOKEN: 0x2000061
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Int64                    <start>k__BackingField  // 0x10
  private           System.Int64                    <now>k__BackingField  // 0x18
PROPERTIES:
  start  get=0x020C61B0  set=0x03D51730
  now  get=0x03D50DE0  set=0x03D55BA0
  deltaTime  get=0x03D88740
METHODS:
  RVA=0x09E7E3B0  token=0x6000260  System.Boolean Equals(System.Object obj)
  RVA=0x09E7E384  token=0x6000261  System.Boolean Equals(UnityEngine.UIElements.TimerState other)
  RVA=0x03D88700  token=0x6000262  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.IScheduler
TYPE:  interface
TOKEN: 0x2000062
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000263  System.Void Unschedule(UnityEngine.UIElements.ScheduledItem item)
  RVA=-1  // abstract  token=0x6000264  System.Void Schedule(UnityEngine.UIElements.ScheduledItem item)
  RVA=-1  // abstract  token=0x6000265  System.Void UpdateScheduledEvents()
END_CLASS

CLASS: UnityEngine.UIElements.ScheduledItem
TYPE:  abstract class
TOKEN: 0x2000063
SIZE:  0x38
FIELDS:
  public            System.Func<System.Boolean>     timerUpdateStopCondition  // 0x10
  public    static readonly System.Func<System.Boolean>     OnceCondition  // static @ 0x0
  public    static readonly System.Func<System.Boolean>     ForeverCondition  // static @ 0x8
  private           System.Int64                    <startMs>k__BackingField  // 0x18
  private           System.Int64                    <delayMs>k__BackingField  // 0x20
  private           System.Int64                    <intervalMs>k__BackingField  // 0x28
  private           System.Int64                    <endTimeMs>k__BackingField  // 0x30
PROPERTIES:
  startMs  get=0x01041090  set=0x03D4EC10
  delayMs  get=0x03D4EB40  set=0x03D4ED30
  intervalMs  get=0x03D4EAC0  set=0x03D4ED70
  endTimeMs  get=0x01003830
METHODS:
  RVA=0x09E7D790  token=0x600026D  System.Void .ctor()
  RVA=0x09E7D5EC  token=0x600026E  System.Void ResetStartTime()
  RVA=-1  // abstract  token=0x600026F  System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state)
  RVA=0x0350B670  token=0x6000270  System.Void OnItemUnscheduled()
  RVA=0x09E7D638  token=0x6000271  System.Boolean ShouldUnschedule()
  RVA=0x09E7D658  token=0x6000272  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TimerEventScheduler
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x38
IMPLEMENTS: UnityEngine.UIElements.IScheduler
FIELDS:
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem>m_ScheduledItems  // 0x10
  private           System.Boolean                  m_TransactionMode  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem>m_ScheduleTransactions  // 0x20
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.ScheduledItem>m_UnscheduleTransactions  // 0x28
  private           System.Boolean                  disableThrottling  // 0x30
  private           System.Int32                    m_LastUpdatedIndex  // 0x34
METHODS:
  RVA=0x09E7D9E8  token=0x6000277  System.Void Schedule(UnityEngine.UIElements.ScheduledItem item)
  RVA=0x09E7D978  token=0x6000278  System.Boolean RemovedScheduledItemAt(System.Int32 index)
  RVA=0x09E7DBDC  token=0x6000279  System.Void Unschedule(UnityEngine.UIElements.ScheduledItem item)
  RVA=0x09E7D8DC  token=0x600027A  System.Boolean PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem sItem)
  RVA=0x09E7DE4C  token=0x600027B  System.Void UpdateScheduledEvents()
  RVA=0x09E7E1F8  token=0x600027C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.Spacing
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x20
FIELDS:
  public            System.Single                   left  // 0x10
  public            System.Single                   top  // 0x14
  public            System.Single                   right  // 0x18
  public            System.Single                   bottom  // 0x1c
PROPERTIES:
  horizontal  get=0x03D85E70
  vertical  get=0x03D85E00
METHODS:
  RVA=0x03D516B0  token=0x600027F  System.Void .ctor(System.Single left, System.Single top, System.Single right, System.Single bottom)
  RVA=0x09E7D870  token=0x6000280  UnityEngine.Rect op_Subtraction(UnityEngine.Rect r, UnityEngine.UIElements.Spacing a)
END_CLASS

CLASS: UnityEngine.UIElements.Position
TYPE:  sealed struct
TOKEN: 0x2000067
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Position Relative  // const
  public    static  UnityEngine.UIElements.Position Absolute  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.OverflowInternal
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.OverflowInternalVisible  // const
  public    static  UnityEngine.UIElements.OverflowInternalHidden  // const
  public    static  UnityEngine.UIElements.OverflowInternalScroll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.OverflowClipBox
TYPE:  sealed struct
TOKEN: 0x2000069
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.OverflowClipBoxPaddingBox  // const
  public    static  UnityEngine.UIElements.OverflowClipBoxContentBox  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.FlexDirection
TYPE:  sealed struct
TOKEN: 0x200006A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.FlexDirectionColumn  // const
  public    static  UnityEngine.UIElements.FlexDirectionColumnReverse  // const
  public    static  UnityEngine.UIElements.FlexDirectionRow  // const
  public    static  UnityEngine.UIElements.FlexDirectionRowReverse  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Wrap
TYPE:  sealed struct
TOKEN: 0x200006B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Wrap     NoWrap  // const
  public    static  UnityEngine.UIElements.Wrap     Wrap  // const
  public    static  UnityEngine.UIElements.Wrap     WrapReverse  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Align
TYPE:  sealed struct
TOKEN: 0x200006C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Align    Auto  // const
  public    static  UnityEngine.UIElements.Align    FlexStart  // const
  public    static  UnityEngine.UIElements.Align    Center  // const
  public    static  UnityEngine.UIElements.Align    FlexEnd  // const
  public    static  UnityEngine.UIElements.Align    Stretch  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Justify
TYPE:  sealed struct
TOKEN: 0x200006D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Justify  FlexStart  // const
  public    static  UnityEngine.UIElements.Justify  Center  // const
  public    static  UnityEngine.UIElements.Justify  FlexEnd  // const
  public    static  UnityEngine.UIElements.Justify  SpaceBetween  // const
  public    static  UnityEngine.UIElements.Justify  SpaceAround  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextOverflowPosition
TYPE:  sealed struct
TOKEN: 0x200006E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TextOverflowPositionEnd  // const
  public    static  UnityEngine.UIElements.TextOverflowPositionStart  // const
  public    static  UnityEngine.UIElements.TextOverflowPositionMiddle  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextOverflow
TYPE:  sealed struct
TOKEN: 0x200006F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TextOverflowClip  // const
  public    static  UnityEngine.UIElements.TextOverflowEllipsis  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TransformOriginOffset
TYPE:  sealed struct
TOKEN: 0x2000070
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TransformOriginOffsetLeft  // const
  public    static  UnityEngine.UIElements.TransformOriginOffsetRight  // const
  public    static  UnityEngine.UIElements.TransformOriginOffsetTop  // const
  public    static  UnityEngine.UIElements.TransformOriginOffsetBottom  // const
  public    static  UnityEngine.UIElements.TransformOriginOffsetCenter  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Visibility
TYPE:  sealed struct
TOKEN: 0x2000071
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisibilityVisible  // const
  public    static  UnityEngine.UIElements.VisibilityHidden  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.WhiteSpace
TYPE:  sealed struct
TOKEN: 0x2000072
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.WhiteSpaceNormal  // const
  public    static  UnityEngine.UIElements.WhiteSpaceNoWrap  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DisplayStyle
TYPE:  sealed struct
TOKEN: 0x2000073
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DisplayStyleFlex  // const
  public    static  UnityEngine.UIElements.DisplayStyleNone  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IStylePainter
TYPE:  interface
TOKEN: 0x2000074
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000281  System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  RVA=-1  // abstract  token=0x6000282  System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  RVA=-1  // abstract  token=0x6000283  System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled)
END_CLASS

CLASS: UnityEngine.UIElements.CursorPositionStylePainterParameters
TYPE:  sealed struct
TOKEN: 0x2000075
SIZE:  0x48
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            System.String                   text  // 0x20
  public            UnityEngine.Font                font  // 0x28
  public            System.Int32                    fontSize  // 0x30
  public            UnityEngine.FontStyle           fontStyle  // 0x34
  public            UnityEngine.TextAnchor          anchor  // 0x38
  public            System.Single                   wordWrapWidth  // 0x3c
  public            System.Boolean                  richText  // 0x40
  public            System.Int32                    cursorIndex  // 0x44
METHODS:
  RVA=0x09E7A964  token=0x6000284  UnityEngine.UIElements.CursorPositionStylePainterParameters GetDefault(UnityEngine.UIElements.VisualElement ve, System.String text)
  RVA=0x09E7AAE0  token=0x6000285  UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(System.Single scaling)
END_CLASS

CLASS: UnityEngine.UIElements.IStylePropertyAnimations
TYPE:  interface
TOKEN: 0x2000076
FIELDS:
PROPERTIES:
  runningAnimationCount  get=-1  // abstract  set=-1  // abstract
  completedAnimationCount  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000286  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single from, System.Single to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000287  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000288  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000289  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600028A  System.Boolean StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600028B  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600028C  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600028D  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600028E  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600028F  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000290  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000291  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000292  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000293  System.Void UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // abstract  token=0x6000294  System.Void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  RVA=-1  // abstract  token=0x6000295  System.Void CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // abstract  token=0x6000296  System.Void CancelAllAnimations()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElement
TYPE:  class
TOKEN: 0x2000077
SIZE:  0x3C0
EXTENDS: UnityEngine.UIElements.Focusable
IMPLEMENTS: UnityEngine.UIElements.IStylePropertyAnimations UnityEngine.UIElements.ITransform UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures UnityEngine.UIElements.IVisualElementScheduler UnityEngine.UIElements.IResolvedStyle
FIELDS:
  private           System.Int32                    <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField  // 0x30
  private           System.Int32                    <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField  // 0x34
  private   static  System.UInt32                   s_NextId  // static @ 0x0
  private   static  System.Collections.Generic.List<System.String>s_EmptyClassList  // static @ 0x8
  private   static readonly UnityEngine.PropertyName        userDataPropertyKey  // static @ 0x10
  public    static readonly System.String                   disabledUssClassName  // static @ 0x18
  private           System.String                   m_Name  // 0x38
  private           System.Collections.Generic.List<System.String>m_ClassList  // 0x40
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.PropertyName,System.Object>>m_PropertyBag  // 0x48
  private           UnityEngine.UIElements.VisualElementFlagsm_Flags  // 0x50
  private           System.String                   m_ViewDataKey  // 0x58
  private           UnityEngine.UIElements.RenderHintsm_RenderHints  // 0x60
  private           UnityEngine.Rect                lastLayout  // 0x64
  private           UnityEngine.Rect                lastPseudoPadding  // 0x74
  private           UnityEngine.UIElements.UIR.RenderChainVEDatarenderChainData  // 0x88
  private           UnityEngine.Rect                m_Layout  // 0x1e0
  private           UnityEngine.Rect                m_BoundingBox  // 0x1f0
  private           UnityEngine.Rect                m_WorldBoundingBox  // 0x200
  private           UnityEngine.Matrix4x4           m_WorldTransformCache  // 0x210
  private           UnityEngine.Matrix4x4           m_WorldTransformInverseCache  // 0x250
  private           UnityEngine.Rect                m_WorldClip  // 0x290
  private           UnityEngine.Rect                m_WorldClipMinusGroup  // 0x2a0
  private           System.Boolean                  m_WorldClipIsInfinite  // 0x2b0
  private   static readonly UnityEngine.Rect                s_InfiniteRect  // static @ 0x20
  private           UnityEngine.UIElements.PseudoStatestriggerPseudoMask  // 0x2b4
  private           UnityEngine.UIElements.PseudoStatesdependencyPseudoMask  // 0x2b8
  private           UnityEngine.UIElements.PseudoStatesm_PseudoStates  // 0x2bc
  private           System.Int32                    <containedPointerIds>k__BackingField  // 0x2c0
  private           UnityEngine.UIElements.PickingMode<pickingMode>k__BackingField  // 0x2c4
  private           UnityEngine.Yoga.YogaNode       <yogaNode>k__BackingField  // 0x2c8
  private           UnityEngine.UIElements.ComputedStylem_Style  // 0x2d0
  private           UnityEngine.UIElements.StyleVariableContextvariableContext  // 0x328
  private           System.Int32                    inheritedStylesHash  // 0x330
  private   readonly System.UInt32                   controlid  // 0x334
  private           System.Int32                    imguiContainerDescendantCount  // 0x338
  private           System.Boolean                  <enabledSelf>k__BackingField  // 0x33c
  private           UnityEngine.UIElements.LanguageDirectionm_LanguageDirection  // 0x340
  private           UnityEngine.UIElements.LanguageDirectionm_LocalLanguageDirection  // 0x344
  private           System.Action<UnityEngine.UIElements.MeshGenerationContext><generateVisualContent>k__BackingField  // 0x348
  private           Unity.Profiling.ProfilerMarker  k_GenerateVisualContentMarker  // 0x350
  private           UnityEngine.UIElements.VisualElement.RenderTargetModem_SubRenderTargetMode  // 0x358
  private   static  UnityEngine.Material            s_runtimeMaterial  // static @ 0x30
  private           UnityEngine.Material            m_defaultMaterial  // 0x360
  private           System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>m_RunningAnimations  // 0x368
  private   static  System.String                   k_RootVisualContainerName  // const
  private           UnityEngine.UIElements.VisualElement.Hierarchy<hierarchy>k__BackingField  // 0x370
  private           System.Boolean                  <isRootVisualContainer>k__BackingField  // 0x378
  private           System.Boolean                  <cacheAsBitmap>k__BackingField  // 0x379
  private           UnityEngine.UIElements.VisualElementm_PhysicalParent  // 0x380
  private           UnityEngine.UIElements.VisualElementm_LogicalParent  // 0x388
  private   static readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>s_EmptyList  // static @ 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>m_Children  // 0x390
  private           UnityEngine.UIElements.BaseVisualElementPanel<elementPanel>k__BackingField  // 0x398
  private           UnityEngine.UIElements.VisualTreeAssetm_VisualTreeAssetSource  // 0x3a0
  private   static  UnityEngine.UIElements.VisualElement.CustomStyleAccesss_CustomStyleAccess  // static @ 0x40
  private           UnityEngine.UIElements.InlineStyleAccessinlineStyleAccess  // 0x3a8
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>styleSheetList  // 0x3b0
  private   static readonly System.Text.RegularExpressions.Regexs_InternalStyleSheetPath  // static @ 0x48
  private   static readonly UnityEngine.PropertyName        tooltipPropertyKey  // static @ 0x50
  private   static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.UIElements.VisualElement.TypeData>s_TypeData  // static @ 0x58
  private           UnityEngine.UIElements.VisualElement.TypeDatam_TypeData  // 0x3b8
PROPERTIES:
  hasRunningAnimations  get=0x09E87DAC
  hasCompletedAnimations  get=0x09E87CBC
  UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount  get=0x03D4ED20  set=0x03D4EE10
  UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount  get=0x03D4EE00  set=0x03D4EE40
  styleAnimation  get=0x0339AE90
  isCompositeRoot  get=0x09E87DD8  set=0x09E88788
  isHierarchyDisplayed  get=0x09E87DE4  set=0x09E887B4
  viewDataKey  get=0x03D87D70  set=0x09E88F3C
  enableViewDataPersistence  get=0x09E87C5C  set=0x09E8872C
  userData  get=0x09E8840C  set=0x09E88ED8
  canGrabFocus  get=0x09E8798C
  focusController  get=0x09E87C78
  usageHints  get=0x09E883F4  set=0x09E88E50
  renderHints  get=0x03D88AC0  set=0x09E88C7C
  transform  get=0x03D86CE0
  UnityEngine.UIElements.ITransform.position  get=0x09E8643C  set=0x09E864BC
  UnityEngine.UIElements.ITransform.scale  get=0x09E8647C
  isLayoutManual  get=0x09E87DF0  set=0x09E887E4
  scaledPixelsPerPoint  get=0x09E8816C
  layout  get=0x09E87E84  set=0x09E88868
  contentRect  get=0x09E87B08
  paddingRect  get=0x09E87F84
  isBoundingBoxDirty  get=0x09E87DCC  set=0x09E8875C
  isWorldBoundingBoxDirty  get=0x09E87E64  set=0x09E88810
  boundingBox  get=0x09E87940
  worldBoundingBox  get=0x09E88518
  boundingBoxInParentSpace  get=0x09E878F0
  worldBound  get=0x09E88490
  localBound  get=0x09E87F34
  rect  get=0x09E8810C
  isWorldTransformDirty  get=0x09187244  set=0x099BCDD8
  isWorldTransformInverseDirty  get=0x09E87E7C  set=0x099BCE04
  worldTransform  get=0x09E88698
  worldTransformRef  get=0x09E8866C
  worldTransformInverse  get=0x09E88640
  isWorldClipDirty  get=0x09E87E70  set=0x09E8883C
  worldClip  get=0x09E885F4
  worldClipMinusGroup  get=0x09E885A8
  worldClipIsInfinite  get=0x09E8856C
  pseudoStates  get=0x03D88AB0  set=0x09E88C10
  containedPointerIds  get=0x03D6CBB0  set=0x03D88AE0
  pickingMode  get=0x03D88AA0  set=0x03D88B10
  name  get=0x03D86EB0  set=0x09E88BC8
  classList  get=0x09E87A6C
  fullTypeName  get=0x09E87C98
  typeName  get=0x09E883D0
  yogaNode  get=0x03D55DF0  set=0x058B3E0C
  computedStyle  get=0x03D88A40
  hasInlineStyle  get=0x09E87DA0
  styleInitialized  get=0x09E8818C  set=0x09E88D20
  isParentEnabledInHierarchy  get=0x09E87DFC
  enabledInHierarchy  get=0x09E87C68
  enabledSelf  get=0x03D88A60  set=0x03D88AF0
  visible  get=0x09E88470  set=0x09E88F90
  generateVisualContent  get=0x03D55E30  set=0x058B3ED4
  requireMeasureFunction  get=0x09E88160  set=0x09E88CBC
  subRenderTargetMode  get=0x03D88AD0
  defaultMaterial  get=0x03D88A50
  experimental  get=0x03D86CE0
  UnityEngine.UIElements.IExperimentalFeatures.animation  get=0x03D86CE0
  hierarchy  get=0x03D55E50  set=0x058B41E0
  isRootVisualContainer  get=0x03D88A70  set=0x03D88B00
  disableClipping  get=0x09E87C50  set=0x09E886FC
  parent  get=0x03D88A90
  elementPanel  get=0x03D4F830  set=0x0544EF54
  panel  get=0x03D88A80
  contentContainer  get=0x03D86CE0
  visualTreeAssetSource  set=0x058B4168
  Item  get=0x09E87884
  childCount  get=0x09E87A0C
  positionWithLayout  get=0x09E8804C
  hasDefaultRotationAndScale  get=0x09E87CDC
  schedule  get=0x03D86CE0
  style  get=0x09E88198
  customStyle  get=0x09E87BD0
  styleSheets  get=0x02712100
  tooltip  get=0x09E88218  set=0x09E88D50
  typeData  get=0x09E88294
  resolvedStyle  get=0x0339AE90
  UnityEngine.UIElements.IResolvedStyle.backgroundColor  get=0x09E85468
  UnityEngine.UIElements.IResolvedStyle.borderBottomColor  get=0x09E85494
  UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius  get=0x09E854C0
  UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius  get=0x09E854E4
  UnityEngine.UIElements.IResolvedStyle.borderBottomWidth  get=0x09E85508
  UnityEngine.UIElements.IResolvedStyle.borderLeftColor  get=0x09E8552C
  UnityEngine.UIElements.IResolvedStyle.borderLeftWidth  get=0x09E85558
  UnityEngine.UIElements.IResolvedStyle.borderRightColor  get=0x09E8557C
  UnityEngine.UIElements.IResolvedStyle.borderRightWidth  get=0x09E855A8
  UnityEngine.UIElements.IResolvedStyle.borderTopColor  get=0x09E855CC
  UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius  get=0x09E855F8
  UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius  get=0x09E8561C
  UnityEngine.UIElements.IResolvedStyle.borderTopWidth  get=0x09E85640
  UnityEngine.UIElements.IResolvedStyle.bottom  get=0x09E85664
  UnityEngine.UIElements.IResolvedStyle.color  get=0x09E85688
  UnityEngine.UIElements.IResolvedStyle.display  get=0x09E856B4
  UnityEngine.UIElements.IResolvedStyle.flexDirection  get=0x09E856C4
  UnityEngine.UIElements.IResolvedStyle.flexGrow  get=0x09E856D4
  UnityEngine.UIElements.IResolvedStyle.flexShrink  get=0x09E856E4
  UnityEngine.UIElements.IResolvedStyle.height  get=0x09E856F4
  UnityEngine.UIElements.IResolvedStyle.left  get=0x09E85718
  UnityEngine.UIElements.IResolvedStyle.marginBottom  get=0x09E8573C
  UnityEngine.UIElements.IResolvedStyle.marginLeft  get=0x09E85760
  UnityEngine.UIElements.IResolvedStyle.marginRight  get=0x09E85784
  UnityEngine.UIElements.IResolvedStyle.marginTop  get=0x09E857A8
  UnityEngine.UIElements.IResolvedStyle.minHeight  get=0x09E857CC
  UnityEngine.UIElements.IResolvedStyle.minWidth  get=0x09E857FC
  UnityEngine.UIElements.IResolvedStyle.opacity  get=0x09E8582C
  UnityEngine.UIElements.IResolvedStyle.paddingBottom  get=0x09E8583C
  UnityEngine.UIElements.IResolvedStyle.paddingLeft  get=0x09E85860
  UnityEngine.UIElements.IResolvedStyle.paddingRight  get=0x09E85884
  UnityEngine.UIElements.IResolvedStyle.paddingTop  get=0x09E858A8
  UnityEngine.UIElements.IResolvedStyle.right  get=0x09E858CC
  UnityEngine.UIElements.IResolvedStyle.scale  get=0x09E858F0
  UnityEngine.UIElements.IResolvedStyle.top  get=0x09E8591C
  UnityEngine.UIElements.IResolvedStyle.transformOrigin  get=0x09E85940
  UnityEngine.UIElements.IResolvedStyle.translate  get=0x09E85970
  UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor  get=0x09E859A0
  UnityEngine.UIElements.IResolvedStyle.unitySliceLeft  get=0x09E859CC
  UnityEngine.UIElements.IResolvedStyle.unitySliceRight  get=0x09E859DC
  UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor  get=0x09E859EC
  UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth  get=0x09E85A18
  UnityEngine.UIElements.IResolvedStyle.visibility  get=0x09E85A28
  UnityEngine.UIElements.IResolvedStyle.whiteSpace  get=0x09E85A38
  UnityEngine.UIElements.IResolvedStyle.width  get=0x09E85A48
METHODS:
  RVA=0x09E81BEC  token=0x60002A1  UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
  RVA=0x09E85E6C  token=0x60002A3  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single from, System.Single to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85C34  token=0x60002A4  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85D34  token=0x60002A5  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E8603C  token=0x60002A6  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85C34  token=0x60002A7  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E862F4  token=0x60002A8  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E86190  token=0x60002A9  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85CB4  token=0x60002AA  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E8622C  token=0x60002AB  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85EF0  token=0x60002AC  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E860D8  token=0x60002AD  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85DB4  token=0x60002AE  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85F8C  token=0x60002AF  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09E85B04  token=0x60002B0  System.Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09E85A6C  token=0x60002B1  System.Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations()
  RVA=0x09E863A8  token=0x60002B2  System.Void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09E85B90  token=0x60002B3  System.Void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  RVA=0x09E84F1C  token=0x60002B4  System.Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length& from, UnityEngine.UIElements.Length& to, System.Int32 subPropertyIndex)
  RVA=0x09E8512C  token=0x60002B5  System.Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin& from, UnityEngine.UIElements.TransformOrigin& to)
  RVA=0x09E851D4  token=0x60002B6  System.Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate& from, UnityEngine.UIElements.Translate& to)
  RVA=0x09E81630  token=0x60002B7  System.Nullable<System.Single> GetParentSizeForLengthConversion(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 subPropertyIndex)
  RVA=0x03D88770  token=0x60002C8  System.Void MarkRenderHintsClean()
  RVA=0x09E80408  token=0x60002D2  System.Void ClearManualLayout()
  RVA=0x09E867C0  token=0x60002DC  System.Void UpdateBoundingBox()
  RVA=0x09E86C6C  token=0x60002DD  System.Void UpdateWorldBoundingBox()
  RVA=0x09E86FD0  token=0x60002E8  System.Void UpdateWorldTransform()
  RVA=0x09E86F64  token=0x60002E9  System.Void UpdateWorldTransformInverse()
  RVA=0x09E80B38  token=0x60002EF  System.Void EnsureWorldTransformAndClipUpToDate()
  RVA=0x09E86CE4  token=0x60002F0  System.Void UpdateWorldClip()
  RVA=0x09E80678  token=0x60002F1  UnityEngine.Rect CombineClipRects(UnityEngine.Rect rect, UnityEngine.Rect parentRect)
  RVA=0x09E849D0  token=0x60002F2  UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect worldRect)
  RVA=0x09E80704  token=0x60002F3  UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect position, UnityEngine.Matrix4x4 mat)
  RVA=0x09E86BA4  token=0x60002F8  System.Void UpdateHoverPseudoState()
  RVA=0x09E80140  token=0x6000306  System.Void ChangeIMGUIContainerCount(System.Int32 delta)
  RVA=0x09E87594  token=0x6000307  System.Void .ctor()
  RVA=0x09E80B74  token=0x6000308  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x09E81C10  token=0x6000309  UnityEngine.Rect GetTooltipRect()
  RVA=0x09E8477C  token=0x600030A  System.Void SetTooltip(UnityEngine.UIElements.TooltipEvent e)
  RVA=0x09E81294  token=0x600030B  System.Void Focus()
  RVA=0x09E83C68  token=0x600030C  System.Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel p)
  RVA=0x09E87174  token=0x600030D  System.Void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel destinationPanel)
  RVA=0x09E81C3C  token=0x600030E  System.Void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel prevPanel)
  RVA=0x09E83710  token=0x600030F  System.Void SendEvent(UnityEngine.UIElements.EventBase e)
  RVA=0x09E8372C  token=0x6000310  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09E81EB4  token=0x6000311  System.Void IncrementVersion(UnityEngine.UIElements.VersionChangeType changeType)
  RVA=0x09E8211C  token=0x6000312  System.Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType changeType)
  RVA=0x09E838CC  token=0x6000313  System.Boolean SetEnabledFromHierarchyPrivate(System.Boolean state)
  RVA=0x09E83BA4  token=0x6000318  System.Void SetEnabled(System.Boolean value)
  RVA=0x09E826F0  token=0x6000319  System.Void PropagateEnabledToChildren(System.Boolean value)
  RVA=0x09E821C0  token=0x600031C  System.Void MarkDirtyRepaint()
  RVA=0x09E81FDC  token=0x600031F  System.Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  RVA=0x09E814AC  token=0x6000320  System.Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder key)
  RVA=0x09E81438  token=0x6000321  System.String GetFullHierarchicalViewDataKey()
  RVA=-1  // generic def  token=0x6000322  T GetOrCreateViewData(System.Object existing, System.String key)
  RVA=0x09E8239C  token=0x6000323  System.Void OverwriteFromViewData(System.Object obj, System.String key)
  RVA=0x09E836A4  token=0x6000324  System.Void SaveViewData()
  RVA=0x09E8213C  token=0x6000325  System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean existingState)
  RVA=0x09E82328  token=0x6000326  System.Void OnViewDataReady(System.Boolean enablePersistence)
  RVA=0x0350B670  token=0x6000327  System.Void OnViewDataReady()
  RVA=0x09E808E4  token=0x6000328  System.Boolean ContainsPoint(UnityEngine.Vector2 localPoint)
  RVA=0x09E7F090  token=0x600032B  System.Void AssignMeasureFunction()
  RVA=0x09E830EC  token=0x600032C  System.Void RemoveMeasureFunction()
  RVA=0x03D88750  token=0x600032D  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09E821E0  token=0x600032E  UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode)
  RVA=0x09E80FC0  token=0x600032F  System.Void FinalizeLayout()
  RVA=0x09E83BBC  token=0x6000330  System.Void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule)
  RVA=0x09E837B0  token=0x6000331  System.Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle& newStyle)
  RVA=0x09E84BA8  token=0x6000332  System.String ToString()
  RVA=0x03D87CC0  token=0x6000333  System.Collections.Generic.List<System.String> GetClassesForIteration()
  RVA=0x09E7EE58  token=0x6000334  System.Void AddToClassList(System.String className)
  RVA=0x09E82F8C  token=0x6000335  System.Void RemoveFromClassList(System.String className)
  RVA=0x09E80B14  token=0x6000336  System.Void EnableInClassList(System.String className, System.Boolean enable)
  RVA=0x09E8036C  token=0x6000337  System.Boolean ClassListContains(System.String cls)
  RVA=0x09E81B00  token=0x6000338  System.Object GetProperty(UnityEngine.PropertyName key)
  RVA=0x09E84714  token=0x6000339  System.Void SetProperty(UnityEngine.PropertyName key, System.Object value)
  RVA=0x09E81E50  token=0x600033A  System.Boolean HasProperty(UnityEngine.PropertyName key)
  RVA=0x09E8527C  token=0x600033B  System.Boolean TryGetPropertyInternal(UnityEngine.PropertyName key, System.Object& value)
  RVA=0x09E8017C  token=0x600033C  System.Void CheckUserKeyArgument(UnityEngine.PropertyName key)
  RVA=0x09E8453C  token=0x600033D  System.Void SetPropertyInternal(UnityEngine.PropertyName key, System.Object value)
  RVA=0x09E86A38  token=0x600033E  System.Void UpdateCursorStyle(System.Int64 eventType)
  RVA=0x09E813D0  token=0x6000341  UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem()
  RVA=0x09E82E50  token=0x6000342  System.Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  RVA=0x09E866E0  token=0x6000343  System.Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  RVA=0x09E86754  token=0x6000344  System.Void UnregisterRunningAnimations()
  RVA=0x09E82F28  token=0x6000345  System.Void RegisterRunningAnimations()
  RVA=-1  // generic def  token=0x6000346  UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement,T> fromValueGetter, T to, System.Int32 durationMs, System.Action<UnityEngine.UIElements.VisualElement,T> onValueChanged)
  RVA=0x09E7F124  token=0x6000347  System.Void AssignStyleValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues src)
  RVA=0x09E827A8  token=0x6000348  UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues targetValuesToRead)
  RVA=0x09E8538C  token=0x6000349  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs)
  RVA=0x09E84874  token=0x600034A  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs)
  RVA=0x09E84844  token=0x6000353  System.Boolean ShouldClip()
  RVA=0x09E7EFCC  token=0x600035A  System.Void Add(UnityEngine.UIElements.VisualElement child)
  RVA=0x09E81F44  token=0x600035B  System.Void Insert(System.Int32 index, UnityEngine.UIElements.VisualElement element)
  RVA=0x09E80628  token=0x600035C  System.Void Clear()
  RVA=0x09E80B08  token=0x600035D  UnityEngine.UIElements.VisualElement ElementAt(System.Int32 index)
  RVA=0x09E81ED4  token=0x6000360  System.Int32 IndexOf(UnityEngine.UIElements.VisualElement element)
  RVA=0x09E80994  token=0x6000361  UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> childIndexes)
  RVA=0x09E811B0  token=0x6000362  System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<System.Int32> outChildIndexes)
  RVA=0x09E802D4  token=0x6000363  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
  RVA=0x09E7FDEC  token=0x6000364  System.Void BringToFront()
  RVA=0x09E83744  token=0x6000365  System.Void SendToBack()
  RVA=0x09E82588  token=0x6000366  System.Void PlaceBehind(UnityEngine.UIElements.VisualElement sibling)
  RVA=0x09E83080  token=0x6000367  System.Void RemoveFromHierarchy()
  RVA=-1  // generic def  token=0x6000368  T GetFirstOfType()
  RVA=-1  // generic def  token=0x6000369  T GetFirstAncestorOfType()
  RVA=0x09E80928  token=0x600036A  System.Boolean Contains(UnityEngine.UIElements.VisualElement child)
  RVA=0x09E81310  token=0x600036B  System.Void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  RVA=0x09E8102C  token=0x600036C  UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement other)
  RVA=0x09E81BA8  token=0x600036D  UnityEngine.UIElements.VisualElement GetRoot()
  RVA=0x09E81B68  token=0x600036E  UnityEngine.UIElements.VisualElement GetRootVisualContainer()
  RVA=0x09E8153C  token=0x600036F  UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
  RVA=0x09E81A20  token=0x6000370  UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
  RVA=0x09E83630  token=0x6000371  UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement retargetAgainst)
  RVA=0x09E8189C  token=0x6000373  System.Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4& result)
  RVA=0x09E82318  token=0x6000375  System.Single Min(System.Single a, System.Single b, System.Single c, System.Single d)
  RVA=0x09E821D0  token=0x6000376  System.Single Max(System.Single a, System.Single b, System.Single c, System.Single d)
  RVA=0x09E84D04  token=0x6000377  System.Void TransformAlignedRectToParentSpace(UnityEngine.Rect& rect)
  RVA=0x09E7FE58  token=0x6000378  UnityEngine.Rect CalculateConservativeRect(UnityEngine.Matrix4x4& matrix, UnityEngine.Rect rect)
  RVA=0x09E84E1C  token=0x6000379  System.Void TransformAlignedRect(UnityEngine.Matrix4x4& matrix, UnityEngine.Rect& rect)
  RVA=0x09E8234C  token=0x600037A  System.Void OrderMinMaxRect(UnityEngine.Rect& rect)
  RVA=0x03D889B0  token=0x600037B  UnityEngine.Vector2 MultiplyMatrix44Point2(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector2 point)
  RVA=0x03D88A00  token=0x600037C  UnityEngine.Vector2 MultiplyVector2(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector2 vector)
  RVA=0x03D88780  token=0x600037D  System.Void MultiplyMatrix34(UnityEngine.Matrix4x4& lhs, UnityEngine.Matrix4x4& rhs, UnityEngine.Matrix4x4& res)
  RVA=0x09E84E90  token=0x600037E  System.Void TranslateMatrix34(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector3 rhs, UnityEngine.Matrix4x4& res)
  RVA=0x03D84330  token=0x600037F  System.Void TranslateMatrix34InPlace(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector3 rhs)
  RVA=0x09E86580  token=0x6000381  UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent)
  RVA=0x09E86630  token=0x6000382  UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action updateEvent)
  RVA=0x09E7ECBC  token=0x6000386  System.Void AddStyleSheetPath(System.String sheetPath)
  RVA=0x09E83110  token=0x6000387  UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length length, System.Boolean isRow)
  RVA=0x09E834E4  token=0x6000388  UnityEngine.Vector3 ResolveTranslate()
  RVA=0x09E83364  token=0x6000389  UnityEngine.Vector3 ResolveTransformOrigin()
  RVA=0x09E83208  token=0x600038A  UnityEngine.Quaternion ResolveRotation()
  RVA=0x09E832C8  token=0x600038B  UnityEngine.Vector3 ResolveScale()
  RVA=0x09E872A8  token=0x60003BD  System.Void .cctor()
  RVA=0x09E8537C  token=0x60003BE  UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__262_0(UnityEngine.Yoga.YogaNode node, System.Single f, UnityEngine.Yoga.YogaMeasureMode mode, System.Single f1, UnityEngine.Yoga.YogaMeasureMode heightMode)
END_CLASS

CLASS: UnityEngine.UIElements.IStylePropertyAnimationSystem
TYPE:  interface
TOKEN: 0x2000084
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60003FF  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Single startValue, System.Single endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000400  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32 startValue, System.Int32 endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000401  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000402  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000403  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000404  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000405  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000406  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000407  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000408  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x6000409  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600040A  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=-1  // abstract  token=0x600040B  System.Void CancelAllAnimations()
  RVA=-1  // abstract  token=0x600040C  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner)
  RVA=-1  // abstract  token=0x600040D  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // abstract  token=0x600040E  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=-1  // abstract  token=0x600040F  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds)
  RVA=-1  // abstract  token=0x6000410  System.Void Update()
END_CLASS

CLASS: UnityEngine.UIElements.StylePropertyAnimationSystem
TYPE:  class
TOKEN: 0x2000085
SIZE:  0x88
IMPLEMENTS: UnityEngine.UIElements.IStylePropertyAnimationSystem
FIELDS:
  private           System.Int64                    m_CurrentTimeMs  // 0x10
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFloatm_Floats  // 0x18
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesIntm_Ints  // 0x20
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesLengthm_Lengths  // 0x28
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesColorm_Colors  // 0x30
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesBackgroundm_Backgrounds  // 0x38
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontDefinitionm_FontDefinitions  // 0x40
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontm_Fonts  // 0x48
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTextShadowm_TextShadows  // 0x50
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesScalem_Scale  // 0x58
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesRotatem_Rotate  // 0x60
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTranslatem_Translate  // 0x68
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTransformOriginm_TransformOrigin  // 0x70
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyAnimationSystem.Values>m_AllValues  // 0x78
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,UnityEngine.UIElements.StylePropertyAnimationSystem.Values>m_PropertyToValues  // 0x80
METHODS:
  RVA=0x09ECF79C  token=0x6000411  System.Void .ctor()
  RVA=-1  // generic def  token=0x6000412  T GetOrCreate(T& values)
  RVA=-1  // generic def  token=0x6000413  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values)
  RVA=0x09ECF2F4  token=0x6000414  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Single startValue, System.Single endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECF028  token=0x6000415  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32 startValue, System.Int32 endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECED94  token=0x6000416  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECEE58  token=0x6000417  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECEBC0  token=0x6000418  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECECB8  token=0x6000419  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECF494  token=0x600041A  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECF1E4  token=0x600041B  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECF3B8  token=0x600041C  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECF0E8  token=0x600041D  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECF558  token=0x600041E  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECEF34  token=0x600041F  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09ECE75C  token=0x6000420  System.Void CancelAllAnimations()
  RVA=0x09ECE86C  token=0x6000421  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner)
  RVA=0x09ECE9E8  token=0x6000422  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09ECF654  token=0x6000423  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09ECEA78  token=0x6000424  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds)
  RVA=-1  // generic def  token=0x6000425  System.Void UpdateTracking(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values)
  RVA=0x03D66B80  token=0x6000426  System.Int64 CurrentTimeMs()
  RVA=0x09ECF6E4  token=0x6000427  System.Void Update()
END_CLASS

CLASS: UnityEngine.UIElements.StylePropertyName
TYPE:  sealed struct
TOKEN: 0x200009E
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   readonly UnityEngine.UIElements.StyleSheets.StylePropertyId<id>k__BackingField  // 0x10
  private   readonly System.String                   <name>k__BackingField  // 0x18
PROPERTIES:
  id  get=0x03D4E980
  name  get=0x03D50DE0
METHODS:
  RVA=0x09ECF8F4  token=0x60004B8  UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(System.String name)
  RVA=0x09ECF9C0  token=0x60004B9  System.Void .ctor(UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId)
  RVA=0x09ECF978  token=0x60004BA  System.Void .ctor(System.String name)
  RVA=0x09ECFA6C  token=0x60004BB  System.Boolean op_Equality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs)
  RVA=0x09ECFAA8  token=0x60004BC  System.Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs)
  RVA=0x09ECFA74  token=0x60004BD  UnityEngine.UIElements.StylePropertyName op_Implicit(System.String name)
  RVA=0x03D85860  token=0x60004BE  System.Int32 GetHashCode()
  RVA=0x09ECF888  token=0x60004BF  System.Boolean Equals(System.Object other)
  RVA=0x09ECF8EC  token=0x60004C0  System.Boolean Equals(UnityEngine.UIElements.StylePropertyName other)
  RVA=0x03D85A90  token=0x60004C1  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.TemplateContainer
TYPE:  class
TOKEN: 0x200009F
SIZE:  0x3E8
EXTENDS: UnityEngine.UIElements.BindableElement
FIELDS:
  private           System.String                   <templateId>k__BackingField  // 0x3d0
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x3d8
  private           UnityEngine.UIElements.VisualTreeAssetm_TemplateSource  // 0x3e0
PROPERTIES:
  templateId  get=0x03D55EC0  set=0x058B40A0
  templateSource  set=0x058B4258
  contentContainer  get=0x03D88DF0
METHODS:
  RVA=0x09ECFAFC  token=0x60004C5  System.Void .ctor()
  RVA=0x09ECFAB4  token=0x60004C6  System.Void .ctor(System.String templateId)
  RVA=0x058B3D30  token=0x60004C8  System.Void SetContentContainer(UnityEngine.UIElements.VisualElement content)
END_CLASS

CLASS: UnityEngine.UIElements.ITextElement
TYPE:  interface
TOKEN: 0x20000A2
FIELDS:
PROPERTIES:
  text  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextElement
TYPE:  class
TOKEN: 0x20000A3
SIZE:  0x488
EXTENDS: UnityEngine.UIElements.BindableElement
IMPLEMENTS: UnityEngine.UIElements.ITextElement UnityEngine.UIElements.INotifyValueChanged`1
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  private           UnityEngine.UIElements.ITextHandlem_TextHandle  // 0x3d0
  private   static  System.Int32                    maxTextVertices  // static @ 0x8
  private           System.String                   m_Text  // 0x3d8
  private           System.Boolean                  m_EnableRichText  // 0x3e0
  private           System.Boolean                  m_DisplayTooltipWhenElided  // 0x3e1
  private           System.Boolean                  <isElided>k__BackingField  // 0x3e2
  private   static readonly System.String                   k_EllipsisText  // static @ 0x10
  private           System.Boolean                  m_WasElided  // 0x3e3
  private           System.Boolean                  m_UpdateTextParams  // 0x3e4
  private           UnityEngine.UIElements.MeshGenerationContextUtils.TextParamsm_TextParams  // 0x3e8
  private           System.Int32                    m_PreviousTextParamsHashCode  // 0x480
PROPERTIES:
  textHandle  get=0x03D88E30  set=0x058B40A0
  text  get=0x09ED09C8  set=0x09ED0A50
  enableRichText  get=0x03D88E10  set=0x09ED0A34
  displayTooltipWhenElided  get=0x03D88E00  set=0x09ED0A04
  isElided  get=0x03D88E20  set=0x03D88E40
  UnityEngine.UIElements.INotifyValueChanged<System.String>.value  get=0x09ED033C  set=0x09ED0384
METHODS:
  RVA=0x09ED081C  token=0x60004CF  System.Void .ctor()
  RVA=0x09ECFF3C  token=0x60004D2  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09ED0238  token=0x60004D3  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  RVA=0x09ED00B8  token=0x60004DC  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  RVA=0x09ECFB6C  token=0x60004DD  System.String ElideText(System.String drawText, System.String ellipsisText, System.Single width, UnityEngine.UIElements.TextOverflowPosition textOverflowPosition)
  RVA=0x09ED04D8  token=0x60004DE  System.Void UpdateTooltip()
  RVA=0x09ED0534  token=0x60004DF  System.Void UpdateVisibleText()
  RVA=0x09ED0240  token=0x60004E0  System.Boolean ShouldElide()
  RVA=0x09ED0290  token=0x60004E1  System.Boolean TextLibraryCanElide()
  RVA=0x09ED0080  token=0x60004E2  UnityEngine.Vector2 MeasureTextSize(System.String textToMeasure, System.Single width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09ECFB08  token=0x60004E3  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09ED02D0  token=0x60004E6  System.Void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(System.String newValue)
  RVA=0x09ED0748  token=0x60004E7  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextShadow
TYPE:  sealed struct
TOKEN: 0x20000A6
SIZE:  0x2C
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            UnityEngine.Vector2             offset  // 0x10
  public            System.Single                   blurRadius  // 0x18
  public            UnityEngine.Color               color  // 0x1c
METHODS:
  RVA=0x09ED0AA0  token=0x60004EB  System.Boolean Equals(System.Object obj)
  RVA=0x09ED0B2C  token=0x60004EC  System.Boolean Equals(UnityEngine.UIElements.TextShadow other)
  RVA=0x09ED0BC8  token=0x60004ED  System.Int32 GetHashCode()
  RVA=0x09ED0E5C  token=0x60004EE  System.Boolean op_Equality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2)
  RVA=0x09ED0E8C  token=0x60004EF  System.Boolean op_Inequality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2)
  RVA=0x09ED0D84  token=0x60004F0  System.String ToString()
  RVA=0x09ED0C1C  token=0x60004F1  UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, System.Single t)
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsPackageUtility
TYPE:  static class
TOKEN: 0x20000A7
SIZE:  0x10
FIELDS:
  private   static readonly System.String                   EditorResourcesBasePath  // static @ 0x0
  private   static readonly System.Boolean                  IsUIEPackageLoaded  // static @ 0x8
METHODS:
  RVA=0x09ED1454  token=0x60004F2  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsRuntimeUtility
TYPE:  static class
TOKEN: 0x20000A8
SIZE:  0x10
FIELDS:
  private   static  System.Action<UnityEngine.UIElements.BaseRuntimePanel>onCreatePanel  // static @ 0x0
  private   static  System.Boolean                  s_RegisteredPlayerloopCallback  // static @ 0x8
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.Panel>s_SortedRuntimePanels  // static @ 0x10
  private   static  System.Boolean                  s_PanelOrderingDirty  // static @ 0x18
  private   static readonly System.String                   s_RepaintProfilerMarkerName  // static @ 0x20
  private   static readonly Unity.Profiling.ProfilerMarker  s_RepaintProfilerMarker  // static @ 0x28
  private   static  System.Int32                    currentOverlayIndex  // static @ 0x30
  private   static  UnityEngine.Object              <activeEventSystem>k__BackingField  // static @ 0x38
  private   static  UnityEngine.UIElements.DefaultEventSystems_DefaultEventSystem  // static @ 0x40
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.PanelSettings>s_PotentiallyEmptyPanelSettings  // static @ 0x48
PROPERTIES:
  activeEventSystem  get=0x09ED264C  set=0x09ED2874
  useDefaultEventSystem  get=0x09ED2750
  defaultEventSystem  get=0x09ED269C
EVENTS:
  onCreatePanel  add=add_onCreatePanel  remove=remove_onCreatePanel
METHODS:
  RVA=0x02DF5C80  token=0x60004F5  System.Void .cctor()
  RVA=0x09ED1518  token=0x60004F6  UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent)
  RVA=0x09ED1688  token=0x60004F7  UnityEngine.UIElements.BaseRuntimePanel FindOrCreateRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate)
  RVA=0x09ED157C  token=0x60004F8  System.Void DisposeRuntimePanel(UnityEngine.ScriptableObject ownerObject)
  RVA=0x09ED1A7C  token=0x60004F9  System.Void RegisterCachedPanelInternal(System.Int32 instanceID, UnityEngine.UIElements.IPanel panel)
  RVA=0x09ED1BEC  token=0x60004FA  System.Void RemoveCachedPanelInternal(System.Int32 instanceID)
  RVA=0x09ED2000  token=0x60004FB  System.Void RepaintOffscreenPanels()
  RVA=0x09ED218C  token=0x60004FC  System.Void RepaintOverlayPanel(UnityEngine.UIElements.BaseRuntimePanel panel)
  RVA=0x09ED14C4  token=0x60004FD  System.Void BeginRenderOverlays(System.Int32 displayIndex)
  RVA=0x09ED1E98  token=0x60004FE  System.Void RenderOverlaysBeforePriority(System.Int32 displayIndex, System.Single maxPriority)
  RVA=0x09ED162C  token=0x60004FF  System.Void EndRenderOverlays(System.Int32 displayIndex)
  RVA=0x036FEBA0  token=0x6000503  System.Void RegisterEventSystem(UnityEngine.Object eventSystem)
  RVA=0x09ED23CC  token=0x6000504  System.Void UnregisterEventSystem(UnityEngine.Object eventSystem)
  RVA=0x09ED24AC  token=0x6000506  System.Void UpdateRuntimePanels()
  RVA=0x09ED180C  token=0x6000507  System.Void MarkPotentiallyEmpty(UnityEngine.UIElements.PanelSettings settings)
  RVA=0x09ED1CF8  token=0x6000508  System.Void RemoveUnusedPanels()
  RVA=0x09ED1B4C  token=0x6000509  System.Void RegisterPlayerloopCallback()
  RVA=0x09ED2454  token=0x600050A  System.Void UnregisterPlayerloopCallback()
  RVA=0x09ED237C  token=0x600050B  System.Void SetPanelOrderingDirty()
  RVA=0x036FE8C0  token=0x600050C  System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels()
  RVA=0x036FED50  token=0x600050D  System.Void SortPanels()
  RVA=0x09ED18C0  token=0x600050E  UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, System.Nullable<System.Int32>& targetDisplay)
  RVA=0x09ED1930  token=0x600050F  UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, System.Nullable<System.Int32>& targetDisplay)
  RVA=0x09ED22B8  token=0x6000510  UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, System.Int32 targetDisplay)
  RVA=0x03D88E50  token=0x6000511  UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta)
END_CLASS

CLASS: UnityEngine.UIElements.IUIElementsUtility
TYPE:  interface
TOKEN: 0x20000AB
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000519  System.Boolean TakeCapture()
  RVA=-1  // abstract  token=0x600051A  System.Boolean ReleaseCapture()
  RVA=-1  // abstract  token=0x600051B  System.Boolean ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& eventHandled)
  RVA=-1  // abstract  token=0x600051C  System.Boolean CleanupRoots()
  RVA=-1  // abstract  token=0x600051D  System.Boolean EndContainerGUIFromException(System.Exception exception)
  RVA=-1  // abstract  token=0x600051E  System.Boolean MakeCurrentIMGUIContainerDirty()
END_CLASS

CLASS: UnityEngine.UIElements.UIEventRegistration
TYPE:  static class
TOKEN: 0x20000AC
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility>s_Utilities  // static @ 0x0
METHODS:
  RVA=0x03805060  token=0x600051F  System.Void .cctor()
  RVA=0x03CAA6F0  token=0x6000520  System.Void RegisterUIElementSystem(UnityEngine.UIElements.IUIElementsUtility utility)
  RVA=0x09ED4248  token=0x6000521  System.Void TakeCapture()
  RVA=0x09ED40D4  token=0x6000522  System.Void ReleaseCapture()
  RVA=0x09ED3BC0  token=0x6000523  System.Boolean EndContainerGUIFromException(System.Exception exception)
  RVA=0x09ED3EF4  token=0x6000524  System.Boolean ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr)
  RVA=0x09ED3A40  token=0x6000525  System.Void CleanupRoots()
  RVA=0x09ED3D74  token=0x6000526  System.Void MakeCurrentIMGUIContainerDirty()
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsUtility
TYPE:  class
TOKEN: 0x20000AE
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IUIElementsUtility
FIELDS:
  private   static  System.Collections.Generic.Stack<UnityEngine.UIElements.IMGUIContainer>s_ContainerStack  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.Panel>s_UIElementsCache  // static @ 0x8
  private   static  UnityEngine.Event               s_EventInstance  // static @ 0x10
  private   static  UnityEngine.Color               editorPlayModeTintColor  // static @ 0x18
  private   static  System.Single                   singleLineHeight  // static @ 0x28
  private   static  UnityEngine.UIElements.UIElementsUtilitys_Instance  // static @ 0x30
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.Panel>s_PanelsIterationList  // static @ 0x38
  private   static readonly System.String                   s_RepaintProfilerMarkerName  // static @ 0x40
  private   static readonly System.String                   s_EventProfilerMarkerName  // static @ 0x48
  private   static readonly Unity.Profiling.ProfilerMarker  s_RepaintProfilerMarker  // static @ 0x50
  private   static readonly Unity.Profiling.ProfilerMarker  s_EventProfilerMarker  // static @ 0x58
METHODS:
  RVA=0x03CAA6A0  token=0x600052F  System.Void .ctor()
  RVA=0x09ED3740  token=0x6000530  System.Boolean UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty()
  RVA=0x09ED38F8  token=0x6000531  System.Boolean UnityEngine.UIElements.IUIElementsUtility.TakeCapture()
  RVA=0x03D4E3A0  token=0x6000532  System.Boolean UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture()
  RVA=0x09ED37EC  token=0x6000533  System.Boolean UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& eventHandled)
  RVA=0x09ED35F0  token=0x6000534  System.Boolean UnityEngine.UIElements.IUIElementsUtility.CleanupRoots()
  RVA=0x09ED369C  token=0x6000535  System.Boolean UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(System.Exception exception)
  RVA=0x09ED348C  token=0x6000536  System.Void RegisterCachedPanel(System.Int32 instanceID, UnityEngine.UIElements.Panel panel)
  RVA=0x09ED3508  token=0x6000537  System.Void RemoveCachedPanel(System.Int32 instanceID)
  RVA=0x09ED3574  token=0x6000538  System.Boolean TryGetPanel(System.Int32 instanceID, UnityEngine.UIElements.Panel& panel)
  RVA=0x09ED28D4  token=0x6000539  System.Void BeginContainerGUI(UnityEngine.GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, UnityEngine.UIElements.IMGUIContainer container)
  RVA=0x09ED3240  token=0x600053A  System.Void EndContainerGUI(UnityEngine.Event evt, UnityEngine.Rect layoutSize)
  RVA=0x09ED2A8C  token=0x600053B  UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent)
  RVA=0x09ED2AF0  token=0x600053C  UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType)
  RVA=0x09ED2D78  token=0x600053D  System.Boolean DoDispatch(UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x036FEF50  token=0x600053E  System.Void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, UnityEngine.UIElements.ContextType contextType)
  RVA=0x036FF030  token=0x600053F  System.Collections.Generic.Dictionary.Enumerator<System.Int32,UnityEngine.UIElements.Panel> GetPanelsIterator()
  RVA=0x09ED33FC  token=0x6000540  System.Single PixelsPerUnitScaleForElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.Sprite sprite)
  RVA=0x02DF60F0  token=0x6000541  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.RuleMatcher
TYPE:  sealed struct
TOKEN: 0x20000AF
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleComplexSelectorcomplexSelector  // 0x18
METHODS:
  RVA=0x09ECDFE0  token=0x6000542  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.UQuery
TYPE:  static class
TOKEN: 0x20000B0
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UQueryState`1
TYPE:  sealed struct
TOKEN: 0x20000B7
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.IEquatable`1
FIELDS:
  private   static  UnityEngine.UIElements.UQueryState.ActionQueryMatcher<T>s_Action  // static @ 0x0
  private   readonly UnityEngine.UIElements.VisualElementm_Element  // 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher>m_Matchers  // 0x0
  private   static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,T>s_List  // static @ 0x0
  private   static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,UnityEngine.UIElements.VisualElement>s_EnumerationList  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600055A  System.Void .ctor(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers)
  RVA=-1  // not resolved  token=0x600055B  UnityEngine.UIElements.UQueryState<T> RebuildOn(UnityEngine.UIElements.VisualElement element)
  RVA=-1  // not resolved  token=0x600055C  T Single(UnityEngine.UIElements.UQuery.SingleQueryMatcher matcher)
  RVA=-1  // not resolved  token=0x600055D  T First()
  RVA=-1  // not resolved  token=0x600055E  System.Void ToList(System.Collections.Generic.List<T> results)
  RVA=-1  // not resolved  token=0x600055F  UnityEngine.UIElements.UQueryState.Enumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000560  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000561  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000562  System.Boolean Equals(UnityEngine.UIElements.UQueryState<T> other)
  RVA=-1  // not resolved  token=0x6000563  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x6000564  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x6000565  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UQueryBuilder`1
TYPE:  sealed struct
TOKEN: 0x20000BB
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector>m_StyleSelectors  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart>m_Parts  // 0x0
  private           UnityEngine.UIElements.VisualElementm_Element  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher>m_Matchers  // 0x0
  private           UnityEngine.UIElements.StyleSelectorRelationshipm_Relationship  // 0x0
  private           System.Int32                    pseudoStatesMask  // 0x0
  private           System.Int32                    negatedPseudoStatesMask  // 0x0
PROPERTIES:
  styleSelectors  get=-1  // not resolved
  parts  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000576  System.Void .ctor(UnityEngine.UIElements.VisualElement visualElement)
  RVA=-1  // not resolved  token=0x6000577  UnityEngine.UIElements.UQueryBuilder<T> Class(System.String classname)
  RVA=-1  // not resolved  token=0x6000578  UnityEngine.UIElements.UQueryBuilder<T> Name(System.String id)
  RVA=-1  // generic def  token=0x6000579  UnityEngine.UIElements.UQueryBuilder<T2> OfType(System.String name, System.String className)
  RVA=-1  // not resolved  token=0x600057A  UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType()
  RVA=-1  // not resolved  token=0x600057B  System.Void AddClass(System.String c)
  RVA=-1  // not resolved  token=0x600057C  System.Void AddName(System.String id)
  RVA=-1  // generic def  token=0x600057D  System.Void AddType()
  RVA=-1  // generic def  token=0x600057E  UnityEngine.UIElements.UQueryBuilder<T2> AddRelationship(UnityEngine.UIElements.StyleSelectorRelationship relationship)
  RVA=-1  // not resolved  token=0x600057F  System.Void AddPseudoStatesRuleIfNecessasy()
  RVA=-1  // not resolved  token=0x6000580  System.Void FinishSelector()
  RVA=-1  // not resolved  token=0x6000581  System.Boolean CurrentSelectorEmpty()
  RVA=-1  // not resolved  token=0x6000582  System.Void FinishCurrentSelector()
  RVA=-1  // not resolved  token=0x6000583  UnityEngine.UIElements.UQueryState<T> Build()
  RVA=-1  // not resolved  token=0x6000584  System.Void ToList(System.Collections.Generic.List<T> results)
  RVA=-1  // not resolved  token=0x6000585  System.Boolean Equals(UnityEngine.UIElements.UQueryBuilder<T> other)
  RVA=-1  // not resolved  token=0x6000586  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x6000587  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.UQueryExtensions
TYPE:  static class
TOKEN: 0x20000BC
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementEmptyQuery  // static @ 0x0
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementNameQuery  // static @ 0x10
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementClassQuery  // static @ 0x20
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementNameAndClassQuery  // static @ 0x30
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeQuery  // static @ 0x40
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeAndNameQuery  // static @ 0x50
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeAndClassQuery  // static @ 0x60
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeAndNameAndClassQuery  // static @ 0x70
METHODS:
  RVA=-1  // generic def  token=0x6000588  T Q(UnityEngine.UIElements.VisualElement e, System.String name, System.String className)
  RVA=0x09ED43C8  token=0x6000589  UnityEngine.UIElements.VisualElement Q(UnityEngine.UIElements.VisualElement e, System.String name, System.String className)
  RVA=-1  // generic def  token=0x600058A  UnityEngine.UIElements.UQueryBuilder<T> Query(UnityEngine.UIElements.VisualElement e, System.String name, System.String className)
  RVA=0x09ED4790  token=0x600058B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.GradientType
TYPE:  sealed struct
TOKEN: 0x20000BD
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.GradientTypeLinear  // const
  public    static  UnityEngine.UIElements.GradientTypeRadial  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.AddressMode
TYPE:  sealed struct
TOKEN: 0x20000BE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.AddressModeWrap  // const
  public    static  UnityEngine.UIElements.AddressModeClamp  // const
  public    static  UnityEngine.UIElements.AddressModeMirror  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VectorImageVertex
TYPE:  sealed struct
TOKEN: 0x20000BF
SIZE:  0x2C
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Color32             tint  // 0x1c
  public            UnityEngine.Vector2             uv  // 0x20
  public            System.UInt32                   settingIndex  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.GradientSettings
TYPE:  sealed struct
TOKEN: 0x20000C0
SIZE:  0x30
FIELDS:
  public            UnityEngine.UIElements.GradientTypegradientType  // 0x10
  public            UnityEngine.UIElements.AddressModeaddressMode  // 0x14
  public            UnityEngine.Vector2             radialFocus  // 0x18
  public            UnityEngine.RectInt             location  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VectorImage
TYPE:  class
TOKEN: 0x20000C1
SIZE:  0x40
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private           UnityEngine.Texture2D           atlas  // 0x18
  private           UnityEngine.UIElements.VectorImageVertex[]vertices  // 0x20
  private           System.UInt16[]                 indices  // 0x28
  private           UnityEngine.UIElements.GradientSettings[]settings  // 0x30
  private           UnityEngine.Vector2             size  // 0x38
METHODS:
  RVA=0x09ED7B88  token=0x600058C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PseudoStates
TYPE:  sealed struct
TOKEN: 0x20000C2
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PseudoStatesActive  // const
  public    static  UnityEngine.UIElements.PseudoStatesHover  // const
  public    static  UnityEngine.UIElements.PseudoStatesChecked  // const
  public    static  UnityEngine.UIElements.PseudoStatesDisabled  // const
  public    static  UnityEngine.UIElements.PseudoStatesFocus  // const
  public    static  UnityEngine.UIElements.PseudoStatesRoot  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFlags
TYPE:  sealed struct
TOKEN: 0x20000C3
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldTransformDirty  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldTransformInverseDirty  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldClipDirty  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsBoundingBoxDirty  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldBoundingBoxDirty  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsLayoutManual  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsCompositeRoot  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsRequireMeasureFunction  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsEnableViewDataPersistence  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsDisableClipping  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsNeedsAttachToPanelEvent  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsHierarchyDisplayed  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsStyleInitialized  // const
  public    static  UnityEngine.UIElements.VisualElementFlagsInit  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PickingMode
TYPE:  sealed struct
TOKEN: 0x20000C4
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PickingModePosition  // const
  public    static  UnityEngine.UIElements.PickingModeIgnore  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.LanguageDirection
TYPE:  sealed struct
TOKEN: 0x20000C5
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.LanguageDirectionInherit  // const
  public    static  UnityEngine.UIElements.LanguageDirectionLTR  // const
  public    static  UnityEngine.UIElements.LanguageDirectionRTL  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementListPool
TYPE:  static class
TOKEN: 0x20000C6
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>>pool  // static @ 0x0
METHODS:
  RVA=0x09EDA008  token=0x600058D  System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  RVA=0x09EDA0A8  token=0x600058E  System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(System.Int32 initialCapacity)
  RVA=0x09EDA168  token=0x600058F  System.Void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  RVA=0x09EDA1F8  token=0x6000590  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ObjectListPool`1
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>>pool  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000591  System.Collections.Generic.List<T> Get()
  RVA=-1  // not resolved  token=0x6000592  System.Void Release(System.Collections.Generic.List<T> elements)
  RVA=-1  // not resolved  token=0x6000593  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementExtensions
TYPE:  static class
TOKEN: 0x20000C8
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09ED85F4  token=0x6000594  System.Void StretchToParentSize(UnityEngine.UIElements.VisualElement elem)
  RVA=0x09ED84E0  token=0x6000595  System.Void AddManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator)
  RVA=0x09ED85E0  token=0x6000596  System.Void RemoveManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator)
  RVA=0x09ED8848  token=0x6000597  UnityEngine.Vector2 WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p)
  RVA=0x09ED8524  token=0x6000598  UnityEngine.Vector2 LocalToWorld(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p)
  RVA=0x09ED8764  token=0x6000599  UnityEngine.Rect WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Rect r)
  RVA=0x09ED84F4  token=0x600059A  UnityEngine.Vector2 ChangeCoordinatesTo(UnityEngine.UIElements.VisualElement src, UnityEngine.UIElements.VisualElement dest, UnityEngine.Vector2 point)
END_CLASS

CLASS: UnityEngine.UIElements.IExperimentalFeatures
TYPE:  interface
TOKEN: 0x20000C9
FIELDS:
PROPERTIES:
  animation  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFocusChangeDirection
TYPE:  class
TOKEN: 0x20000CA
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.FocusChangeDirection
FIELDS:
  private   static readonly UnityEngine.UIElements.VisualElementFocusChangeDirections_Left  // static @ 0x0
  private   static readonly UnityEngine.UIElements.VisualElementFocusChangeDirections_Right  // static @ 0x8
PROPERTIES:
  left  get=0x09ED8A5C
  right  get=0x09ED8AAC
METHODS:
  RVA=0x09ED8A0C  token=0x600059E  System.Void .ctor(System.Int32 value)
  RVA=0x09ED8904  token=0x600059F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFocusChangeTarget
TYPE:  class
TOKEN: 0x20000CB
SIZE:  0x20
EXTENDS: UnityEngine.UIElements.FocusChangeDirection
FIELDS:
  private   static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget>Pool  // static @ 0x0
  private           UnityEngine.UIElements.Focusable<target>k__BackingField  // 0x18
PROPERTIES:
  target  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09ED8B98  token=0x60005A0  UnityEngine.UIElements.VisualElementFocusChangeTarget GetPooled(UnityEngine.UIElements.Focusable target)
  RVA=0x09ED8B1C  token=0x60005A1  System.Void Dispose()
  RVA=0x09ED8AFC  token=0x60005A2  System.Void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f)
  RVA=0x09ED8CB0  token=0x60005A3  System.Void .ctor()
  RVA=0x09ED8C1C  token=0x60005A6  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFocusRing
TYPE:  class
TOKEN: 0x20000CC
SIZE:  0x28
IMPLEMENTS: UnityEngine.UIElements.IFocusRing
FIELDS:
  private   readonly UnityEngine.UIElements.VisualElementroot  // 0x10
  private           UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder<defaultFocusOrder>k__BackingField  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord>m_FocusRing  // 0x20
PROPERTIES:
  focusController  get=0x09ED9FE4
  defaultFocusOrder  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x09ED9F4C  token=0x60005A7  System.Void .ctor(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder dfo)
  RVA=0x09ED9024  token=0x60005AB  System.Int32 FocusRingAutoIndexSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b)
  RVA=0x09ED945C  token=0x60005AC  System.Int32 FocusRingSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b)
  RVA=0x09ED8F64  token=0x60005AD  System.Void DoUpdate()
  RVA=0x09ED8D0C  token=0x60005AE  System.Void BuildRingForScopeRecursive(UnityEngine.UIElements.VisualElement ve, System.Int32& scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList)
  RVA=0x09ED9CA4  token=0x60005AF  System.Void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList)
  RVA=0x09ED9718  token=0x60005B0  System.Int32 GetFocusableInternalIndex(UnityEngine.UIElements.Focusable f)
  RVA=0x09ED9564  token=0x60005B1  UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e)
  RVA=0x09ED97A8  token=0x60005B2  UnityEngine.UIElements.FocusChangeDirection GetKeyDownFocusChangeDirection(UnityEngine.UIElements.EventBase e)
  RVA=0x09ED995C  token=0x60005B3  UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction)
  RVA=0x09ED98D4  token=0x60005B4  UnityEngine.UIElements.Focusable GetNextFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable)
  RVA=0x09ED9BE0  token=0x60005B5  UnityEngine.UIElements.Focusable GetPreviousFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable)
END_CLASS

CLASS: UnityEngine.UIElements.IVisualElementScheduledItem
TYPE:  interface
TOKEN: 0x20000CF
FIELDS:
PROPERTIES:
  isActive  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60005B8  System.Void Resume()
  RVA=-1  // abstract  token=0x60005B9  System.Void Pause()
  RVA=-1  // abstract  token=0x60005BA  System.Void ExecuteLater(System.Int64 delayMs)
  RVA=-1  // abstract  token=0x60005BB  UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 delayMs)
  RVA=-1  // abstract  token=0x60005BC  UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 intervalMs)
END_CLASS

CLASS: UnityEngine.UIElements.IVisualElementScheduler
TYPE:  interface
TOKEN: 0x20000D0
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60005BD  UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent)
  RVA=-1  // abstract  token=0x60005BE  UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action updateEvent)
END_CLASS

CLASS: UnityEngine.UIElements.IVisualElementPanelActivatable
TYPE:  interface
TOKEN: 0x20000D1
FIELDS:
PROPERTIES:
  element  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60005C0  System.Boolean CanBeActivated()
  RVA=-1  // abstract  token=0x60005C1  System.Void OnPanelActivate()
  RVA=-1  // abstract  token=0x60005C2  System.Void OnPanelDeactivate()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementPanelActivator
TYPE:  class
TOKEN: 0x20000D2
SIZE:  0x20
FIELDS:
  private           UnityEngine.UIElements.IVisualElementPanelActivatablem_Activatable  // 0x10
  private           System.Boolean                  <isActive>k__BackingField  // 0x18
  private           System.Boolean                  <isDetaching>k__BackingField  // 0x19
PROPERTIES:
  isActive  get=0x01002A50  set=0x01002B40
  isDetaching  get=0x03D4EF80  set=0x03D4EFB0
METHODS:
  RVA=0x0426FEE0  token=0x60005C7  System.Void .ctor(UnityEngine.UIElements.IVisualElementPanelActivatable activatable)
  RVA=0x09EDA428  token=0x60005C8  System.Void SetActive(System.Boolean action)
  RVA=0x09EDA328  token=0x60005C9  System.Void SendActivation()
  RVA=0x09EDA3A8  token=0x60005CA  System.Void SendDeactivation()
  RVA=0x09EDA28C  token=0x60005CB  System.Void OnEnter(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09EDA29C  token=0x60005CC  System.Void OnLeave(UnityEngine.UIElements.DetachFromPanelEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementStyleSheetSet
TYPE:  sealed struct
TOKEN: 0x20000D3
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   readonly UnityEngine.UIElements.VisualElementm_Element  // 0x10
METHODS:
  RVA=0x042715A0  token=0x60005CD  System.Void .ctor(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EDA660  token=0x60005CE  System.Void Add(UnityEngine.UIElements.StyleSheet styleSheet)
  RVA=0x09EDA868  token=0x60005CF  System.Boolean Remove(UnityEngine.UIElements.StyleSheet styleSheet)
  RVA=0x09E6F58C  token=0x60005D0  System.Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet other)
  RVA=0x09EDA7F8  token=0x60005D1  System.Boolean Equals(System.Object obj)
  RVA=0x0711E2B8  token=0x60005D2  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementUtils
TYPE:  static class
TOKEN: 0x20000D4
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<System.String>s_usedNames  // static @ 0x0
  private   static readonly System.Type                     s_FoldoutType  // static @ 0x8
METHODS:
  RVA=0x09EDAB54  token=0x60005D3  System.String GetUniqueName(System.String nameBase)
  RVA=0x09EDA9B4  token=0x60005D4  System.Int32 GetFoldoutDepth(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EDAA64  token=0x60005D5  System.Int32 GetListAndFoldoutDepth(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EDAC48  token=0x60005D6  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementAnimationSystem
TYPE:  class
TOKEN: 0x20000D5
SIZE:  0x40
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>m_Animations  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>m_IterationList  // 0x28
  private           System.Boolean                  m_HasNewAnimations  // 0x30
  private           System.Boolean                  m_IterationListDirty  // 0x31
  private   static readonly System.String                   s_Description  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x8
  private   static readonly System.String                   s_StylePropertyAnimationDescription  // static @ 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  s_StylePropertyAnimationProfilerMarker  // static @ 0x18
  private           System.Int64                    lastUpdate  // 0x38
PROPERTIES:
  profilerMarker  get=0x09ED8440
  stylePropertyAnimationProfilerMarker  get=0x09ED8490
METHODS:
  RVA=0x09ED7D74  token=0x60005D9  System.Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  RVA=0x09ED7DD0  token=0x60005DA  System.Void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
  RVA=0x09ED7BD8  token=0x60005DB  System.Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  RVA=0x09ED7C34  token=0x60005DC  System.Void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
  RVA=0x09ED7F0C  token=0x60005DD  System.Void Update()
  RVA=0x0350B670  token=0x60005DE  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09ED837C  token=0x60005DF  System.Void .ctor()
  RVA=0x09ED8270  token=0x60005E0  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.HierarchyChangeType
TYPE:  sealed struct
TOKEN: 0x20000D6
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.HierarchyChangeTypeAdd  // const
  public    static  UnityEngine.UIElements.HierarchyChangeTypeRemove  // const
  public    static  UnityEngine.UIElements.HierarchyChangeTypeMove  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater
TYPE:  abstract class
TOKEN: 0x20000D7
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private           UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.Statem_State  // 0x20
  private           UnityEngine.UIElements.VisualElementm_CurrentChangeElement  // 0x28
  private           UnityEngine.UIElements.VisualElementm_CurrentChangeParent  // 0x30
METHODS:
  RVA=-1  // abstract  token=0x60005E1  System.Void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type)
  RVA=0x09ECDA48  token=0x60005E2  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09ECDC10  token=0x60005E3  System.Void Update()
  RVA=0x09ECDB20  token=0x60005E4  System.Void ProcessNewChange(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09ECDA88  token=0x60005E5  System.Void ProcessAddOrMove(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09ECDB9C  token=0x60005E6  System.Void ProcessRemove(UnityEngine.UIElements.VisualElement ve)
  RVA=0x03D4E2C0  token=0x60005E7  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleCache
TYPE:  static class
TOKEN: 0x20000D9
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int64,UnityEngine.UIElements.ComputedStyle>s_ComputedStyleCache  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.StyleVariableContext>s_StyleVariableContextCache  // static @ 0x8
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.ComputedTransitionProperty[]>s_ComputedTransitionsCache  // static @ 0x10
METHODS:
  RVA=0x09ECE2FC  token=0x60005E8  System.Boolean TryGetValue(System.Int64 hash, UnityEngine.UIElements.ComputedStyle& data)
  RVA=0x09ECE04C  token=0x60005E9  System.Void SetValue(System.Int64 hash, UnityEngine.UIElements.ComputedStyle& data)
  RVA=0x09ECE204  token=0x60005EA  System.Boolean TryGetValue(System.Int32 hash, UnityEngine.UIElements.StyleVariableContext& data)
  RVA=0x09ECE10C  token=0x60005EB  System.Void SetValue(System.Int32 hash, UnityEngine.UIElements.StyleVariableContext data)
  RVA=0x09ECE280  token=0x60005EC  System.Boolean TryGetValue(System.Int32 hash, UnityEngine.UIElements.ComputedTransitionProperty[]& data)
  RVA=0x09ECE188  token=0x60005ED  System.Void SetValue(System.Int32 hash, UnityEngine.UIElements.ComputedTransitionProperty[] data)
  RVA=0x09ECE378  token=0x60005EE  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeStyleUpdater
TYPE:  class
TOKEN: 0x20000DA
SIZE:  0x50
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ApplyStyleUpdateList  // 0x20
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_TransitionPropertyUpdateList  // 0x28
  private           System.Boolean                  m_IsApplyingStyles  // 0x30
  private           System.UInt32                   m_Version  // 0x34
  private           System.UInt32                   m_LastVersion  // 0x38
  private           UnityEngine.UIElements.VisualTreeStyleUpdaterTraversalm_StyleContextHierarchyTraversal  // 0x40
  private   static readonly System.String                   s_Description  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x8
  private           System.Boolean                  <disposed>k__BackingField  // 0x48
PROPERTIES:
  profilerMarker  get=0x09EDE218
  disposed  get=0x03D4EFE0  set=0x03D4F010
METHODS:
  RVA=0x09EDDCD0  token=0x60005F0  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09EDDD84  token=0x60005F1  System.Void Update()
  RVA=0x09EDDC9C  token=0x60005F4  System.Void Dispose(System.Boolean disposing)
  RVA=0x09EDDBE4  token=0x60005F5  System.Void ApplyStyles()
  RVA=0x09EDE12C  token=0x60005F6  System.Void .ctor()
  RVA=0x09EDE098  token=0x60005F7  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleMatchingContext
TYPE:  class
TOKEN: 0x20000DB
SIZE:  0x38
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>m_StyleSheetStack  // 0x10
  public            UnityEngine.UIElements.StyleVariableContextvariableContext  // 0x18
  public            UnityEngine.UIElements.VisualElementcurrentElement  // 0x20
  public            System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo>processResult  // 0x28
  public            UnityEngine.UIElements.AncestorFilterancestorFilter  // 0x30
PROPERTIES:
  styleSheetCount  get=0x09ECE71C
METHODS:
  RVA=0x09ECE60C  token=0x60005F9  System.Void .ctor(System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult)
  RVA=0x09ECE4D4  token=0x60005FA  System.Void AddStyleSheet(UnityEngine.UIElements.StyleSheet sheet)
  RVA=0x09ECE5A8  token=0x60005FB  System.Void RemoveStyleSheetRange(System.Int32 index, System.Int32 count)
  RVA=0x09ECE554  token=0x60005FC  UnityEngine.UIElements.StyleSheet GetStyleSheetAt(System.Int32 index)
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal
TYPE:  class
TOKEN: 0x20000DC
SIZE:  0x50
EXTENDS: UnityEngine.UIElements.StyleSheets.HierarchyTraversal
FIELDS:
  private           UnityEngine.UIElements.StyleVariableContextm_ProcessVarContext  // 0x10
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_UpdateList  // 0x18
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ParentList  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>m_TempMatchResults  // 0x28
  private           System.Single                   <currentPixelsPerPoint>k__BackingField  // 0x30
  private           UnityEngine.UIElements.StyleMatchingContextm_StyleMatchingContext  // 0x38
  private           UnityEngine.UIElements.StyleSheets.StylePropertyReaderm_StylePropertyReader  // 0x40
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId>m_AnimatedProperties  // 0x48
PROPERTIES:
  currentPixelsPerPoint  get=0x03D4F5D0  set=0x03D4F5E0
METHODS:
  RVA=0x03D4F5E0  token=0x60005FF  System.Void PrepareTraversal(System.Single pixelsPerPoint)
  RVA=0x09EDC0D0  token=0x6000600  System.Void AddChangedElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09EDC310  token=0x6000601  System.Void Clear()
  RVA=0x09EDD110  token=0x6000602  System.Void PropagateToChildren(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDD1D0  token=0x6000603  System.Void PropagateToParents(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDC534  token=0x6000604  System.Void OnProcessMatchResult(UnityEngine.UIElements.VisualElement current, UnityEngine.UIElements.StyleSheets.MatchResultInfo info)
  RVA=0x09EDD2D4  token=0x6000605  System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  RVA=0x09EDD03C  token=0x6000606  System.Void ProcessTransitions(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle)
  RVA=0x09EDC38C  token=0x6000607  System.Void ForceUpdateTransitions(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EDC154  token=0x6000608  System.Void CancelAnimationsWithNoTransitionProperty(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& newStyle)
  RVA=0x09EDD250  token=0x6000609  System.Boolean ShouldSkipElement(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EDC568  token=0x600060A  UnityEngine.UIElements.ComputedStyle ProcessMatchedRules(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors)
  RVA=0x09EDCF7C  token=0x600060B  System.Void ProcessMatchedVariables(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule)
  RVA=0x09EDD998  token=0x600060C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeTransformClipUpdater
TYPE:  class
TOKEN: 0x20000DE
SIZE:  0x28
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private           System.UInt32                   m_Version  // 0x20
  private           System.UInt32                   m_LastVersion  // 0x24
  private   static readonly System.String                   s_Description  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x8
PROPERTIES:
  profilerMarker  get=0x09EDE5AC
METHODS:
  RVA=0x09EDE3EC  token=0x6000611  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09EDE2C4  token=0x6000612  System.Void DirtyHierarchy(UnityEngine.UIElements.VisualElement ve, System.Boolean mustDirtyWorldTransform, System.Boolean mustDirtyWorldClip)
  RVA=0x09EDE268  token=0x6000613  System.Void DirtyBoundingBoxHierarchy(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDE4C0  token=0x6000614  System.Void Update()
  RVA=0x03D65C60  token=0x6000615  System.Void .ctor()
  RVA=0x09EDE518  token=0x6000616  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeUpdatePhase
TYPE:  sealed struct
TOKEN: 0x20000DF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseViewData  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseBindings  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseAnimation  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseStyles  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseLayout  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseTransformClip  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseRepaint  // const
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseCount  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeUpdater
TYPE:  sealed class
TOKEN: 0x20000E0
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private           UnityEngine.UIElements.BaseVisualElementPanelm_Panel  // 0x10
  private           UnityEngine.UIElements.VisualTreeUpdater.UpdaterArraym_UpdaterArray  // 0x18
METHODS:
  RVA=0x09EDE8C0  token=0x6000617  System.Void .ctor(UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09EDE5FC  token=0x6000618  System.Void Dispose()
  RVA=0x09EDE7F4  token=0x6000619  System.Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  RVA=0x09EDE68C  token=0x600061A  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=-1  // generic def  token=0x600061B  System.Void SetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  RVA=0x09EDE66C  token=0x600061C  UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  RVA=0x09EDE6F8  token=0x600061D  System.Void SetDefaultUpdaters()
END_CLASS

CLASS: UnityEngine.UIElements.IVisualTreeUpdater
TYPE:  interface
TOKEN: 0x20000E2
IMPLEMENTS: System.IDisposable
FIELDS:
PROPERTIES:
  panel  set=-1  // abstract
  profilerMarker  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000624  System.Void Update()
  RVA=-1  // abstract  token=0x6000625  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
END_CLASS

CLASS: UnityEngine.UIElements.BaseVisualTreeUpdater
TYPE:  abstract class
TOKEN: 0x20000E3
SIZE:  0x20
IMPLEMENTS: UnityEngine.UIElements.IVisualTreeUpdater System.IDisposable
FIELDS:
  private           System.Action<UnityEngine.UIElements.BaseVisualElementPanel>panelChanged  // 0x10
  private           UnityEngine.UIElements.BaseVisualElementPanelm_Panel  // 0x18
PROPERTIES:
  panel  get=0x03D61D00  set=0x09ECDE34
  visualTree  get=0x09ECDD84
  profilerMarker  get=-1  // abstract
EVENTS:
  panelChanged  add=add_panelChanged  remove=remove_panelChanged
METHODS:
  RVA=0x09ECDCA8  token=0x600062C  System.Void Dispose()
  RVA=0x0350B670  token=0x600062D  System.Void Dispose(System.Boolean disposing)
  RVA=-1  // abstract  token=0x600062E  System.Void Update()
  RVA=-1  // abstract  token=0x600062F  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x0350B670  token=0x6000630  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeViewDataUpdater
TYPE:  class
TOKEN: 0x20000E4
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_UpdateList  // 0x20
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ParentList  // 0x28
  private           System.UInt32                   m_Version  // 0x30
  private           System.UInt32                   m_LastVersion  // 0x34
  private   static readonly System.String                   s_Description  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x8
PROPERTIES:
  profilerMarker  get=0x09EDEDC8
METHODS:
  RVA=0x09EDE940  token=0x6000632  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09EDEA3C  token=0x6000633  System.Void Update()
  RVA=0x09EDEB40  token=0x6000634  System.Void ValidateViewDataOnSubTree(UnityEngine.UIElements.VisualElement ve, System.Boolean enablePersistence)
  RVA=0x09EDE9BC  token=0x6000635  System.Void PropagateToParents(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDED18  token=0x6000636  System.Void .ctor()
  RVA=0x09EDEC84  token=0x6000637  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IBindingRequest
TYPE:  interface
TOKEN: 0x20000E5
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000638  System.Void Bind(UnityEngine.UIElements.VisualElement element)
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeBindingsUpdater
TYPE:  class
TOKEN: 0x20000E6
SIZE:  0x70
EXTENDS: UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater
FIELDS:
  private   static readonly UnityEngine.PropertyName        s_BindingRequestObjectVEPropertyName  // static @ 0x0
  private   static readonly UnityEngine.PropertyName        s_AdditionalBindingObjectVEPropertyName  // static @ 0x4
  private   static readonly System.String                   s_Description  // static @ 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerBindingRequestsMarker  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerUpdate  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerPoll  // static @ 0x28
  private   static  System.Boolean                  <disableBindingsThrottling>k__BackingField  // static @ 0x30
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsWithBindings  // 0x38
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsToAdd  // 0x40
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsToRemove  // 0x48
  private           System.Int64                    m_LastUpdateTime  // 0x50
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsToBind  // 0x58
  private           System.Collections.Generic.Dictionary<System.Object,System.Object><temporaryObjectCache>k__BackingField  // 0x60
  private           System.Collections.Generic.List<UnityEngine.UIElements.IBinding>updatedBindings  // 0x68
PROPERTIES:
  profilerMarker  get=0x09EDC080
  temporaryObjectCache  get=0x03D4EB00
METHODS:
  RVA=0x09EDADEC  token=0x600063A  UnityEngine.UIElements.IBinding GetBindingObjectFromElement(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDB318  token=0x600063B  System.Void StartTracking(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDB490  token=0x600063C  System.Void StopTracking(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDAD74  token=0x600063E  UnityEngine.UIElements.IBinding GetAdditionalBinding(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDB204  token=0x600063F  System.Void StartTrackingRecursive(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDB390  token=0x6000640  System.Void StopTrackingRecursive(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EDAE98  token=0x6000641  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09EDAE70  token=0x6000642  System.Void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type)
  RVA=0x09EDAD34  token=0x6000643  System.Int64 CurrentTime()
  RVA=0x09EDAF78  token=0x6000644  System.Void PerformTrackingOperations()
  RVA=0x09EDB8D8  token=0x6000645  System.Void Update()
  RVA=0x09EDB508  token=0x6000646  System.Void UpdateBindings()
  RVA=0x09EDBED0  token=0x6000647  System.Void .ctor()
  RVA=0x09EDBD0C  token=0x6000648  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseListViewController
TYPE:  abstract class
TOKEN: 0x20000E7
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.CollectionViewController
FIELDS:
  private           System.Action                   itemsSourceSizeChanged  // 0x30
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsAdded  // 0x38
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsRemoved  // 0x40
PROPERTIES:
  baseListView  get=0x09ECD860
EVENTS:
  itemsSourceSizeChanged  add=add_itemsSourceSizeChanged  remove=remove_itemsSourceSizeChanged
  itemsAdded  add=add_itemsAdded  remove=remove_itemsAdded
  itemsRemoved  add=add_itemsRemoved  remove=remove_itemsRemoved
METHODS:
  RVA=0x09ECCC04  token=0x6000650  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=0x09ECCDB4  token=0x6000651  System.Void PostInitRegistration(UnityEngine.UIElements.ReusableListViewItem listItem)
  RVA=0x09ECCB34  token=0x6000652  System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  RVA=0x03D663A0  token=0x6000653  System.Boolean NeedsDragHandle(System.Int32 index)
  RVA=0x09ECC4BC  token=0x6000654  System.Void AddItems(System.Int32 itemCount)
  RVA=0x09ECCCD4  token=0x6000655  System.Void Move(System.Int32 index, System.Int32 newIndex)
  RVA=0x09ECD1A4  token=0x6000656  System.Void RemoveItem(System.Int32 index)
  RVA=0x09ECD404  token=0x6000657  System.Void RemoveItems(System.Collections.Generic.List<System.Int32> indices)
  RVA=0x09ECD2BC  token=0x6000658  System.Void RemoveItems(System.Int32 itemCount)
  RVA=0x09ECC9B8  token=0x6000659  System.Void ClearItems()
  RVA=0x09ECD018  token=0x600065A  System.Void RaiseOnSizeChanged()
  RVA=0x09ECCFF0  token=0x600065B  System.Void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09ECD004  token=0x600065C  System.Void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09ECC8D8  token=0x600065D  System.Array AddToArray(System.Array source, System.Int32 itemCount)
  RVA=0x09ECD028  token=0x600065E  System.Array RemoveFromArray(System.Array source, System.Collections.Generic.List<System.Int32> indicesToRemove)
  RVA=0x09ECD550  token=0x600065F  System.Void Swap(System.Int32 lhs, System.Int32 rhs)
  RVA=0x09ECCA54  token=0x6000660  System.Void EnsureItemSourceCanBeResized()
  RVA=0x0350B670  token=0x6000661  System.Void .ctor()
  RVA=0x09ECD620  token=0x6000662  System.Boolean <AddItems>g__IsGenericList|15_0(System.Type t)
END_CLASS

CLASS: UnityEngine.UIElements.BaseTreeViewController
TYPE:  abstract class
TOKEN: 0x20000E8
SIZE:  0x58
EXTENDS: UnityEngine.UIElements.CollectionViewController
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeItem>m_TreeItems  // 0x30
  private           System.Collections.Generic.List<System.Int32>m_RootIndices  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>m_ItemWrappers  // 0x40
  private           System.Collections.Generic.HashSet<System.Int32>m_TreeItemIdsWithItemWrappers  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>m_WrapperInsertionList  // 0x50
  private   static readonly Unity.Profiling.ProfilerMarker  K_ExpandItemByIndex  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_CreateWrappers  // static @ 0x8
PROPERTIES:
  baseTreeView  get=0x09EE40E4
  itemsSource  get=0x01041090  set=0x09EE4120
METHODS:
  RVA=0x09EE3B94  token=0x6000666  System.Void RebuildTree()
  RVA=0x03D86EB0  token=0x6000667  System.Collections.Generic.IEnumerable<System.Int32> GetRootItemIds()
  RVA=-1  // abstract  token=0x6000668  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
  RVA=-1  // abstract  token=0x6000669  System.Int32 GetParentId(System.Int32 id)
  RVA=-1  // abstract  token=0x600066A  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  RVA=-1  // abstract  token=0x600066B  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree)
  RVA=0x09EE3214  token=0x600066C  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=0x09EE303C  token=0x600066D  System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  RVA=0x09EE3100  token=0x600066E  System.Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=0x09EE3984  token=0x600066F  System.Void PostInitRegistration(UnityEngine.UIElements.ReusableTreeViewItem treeItem)
  RVA=0x09EE33D8  token=0x6000670  System.Void OnItemPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EE387C  token=0x6000671  System.Void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
  RVA=0x09EE2E70  token=0x6000672  System.Int32 GetIndexForId(System.Int32 id)
  RVA=0x09EE2D8C  token=0x6000673  System.Int32 GetIdForIndex(System.Int32 index)
  RVA=0x09EE2FBC  token=0x6000674  System.Boolean HasChildren(System.Int32 id)
  RVA=0x09EE2338  token=0x6000675  System.Boolean Exists(System.Int32 id)
  RVA=0x09EE2F20  token=0x6000676  System.Boolean HasChildrenByIndex(System.Int32 index)
  RVA=0x09EE2D0C  token=0x6000677  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIdsByIndex(System.Int32 index)
  RVA=0x09EE2B24  token=0x6000678  System.Int32 GetChildIndexForId(System.Int32 id)
  RVA=0x09EE2E2C  token=0x6000679  System.Int32 GetIndentationDepth(System.Int32 id)
  RVA=0x09EE2E00  token=0x600067A  System.Int32 GetIndentationDepthByIndex(System.Int32 index)
  RVA=0x03D663A0  token=0x600067B  System.Boolean CanChangeExpandedState(System.Int32 id)
  RVA=0x09EE3318  token=0x600067C  System.Boolean IsExpanded(System.Int32 id)
  RVA=0x09EE3290  token=0x600067D  System.Boolean IsExpandedByIndex(System.Int32 index)
  RVA=0x09EE238C  token=0x600067E  System.Void ExpandItemByIndex(System.Int32 index, System.Boolean expandAllChildren, System.Boolean refresh)
  RVA=0x09EE29D0  token=0x600067F  System.Void ExpandItem(System.Int32 id, System.Boolean expandAllChildren, System.Boolean refresh)
  RVA=0x09EE1A9C  token=0x6000680  System.Void CollapseItemByIndex(System.Int32 index, System.Boolean collapseAllChildren)
  RVA=0x09EE1DE0  token=0x6000681  System.Void CollapseItem(System.Int32 id, System.Boolean collapseAllChildren)
  RVA=0x09EE3E2C  token=0x6000682  System.Void RegenerateWrappers()
  RVA=0x09EE1F08  token=0x6000683  System.Void CreateWrappers(System.Collections.Generic.IEnumerable<System.Int32> treeViewItemIds, System.Int32 depth, System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>& wrappers)
  RVA=0x09EE337C  token=0x6000684  System.Boolean IsIndexValid(System.Int32 index)
  RVA=0x09EE3B80  token=0x6000685  System.Void RaiseItemParentChanged(System.Int32 id, System.Int32 newParentId)
  RVA=0x09EE3F58  token=0x6000686  System.Void .ctor()
  RVA=0x09EE3EC0  token=0x6000687  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.CollectionViewController
TYPE:  abstract class
TOKEN: 0x20000EA
SIZE:  0x30
IMPLEMENTS: System.IDisposable
FIELDS:
  private           UnityEngine.UIElements.BaseVerticalCollectionViewm_View  // 0x10
  private           System.Collections.IList        m_ItemsSource  // 0x18
  private           System.Action                   itemsSourceChanged  // 0x20
  private           System.Action<System.Int32,System.Int32>itemIndexChanged  // 0x28
PROPERTIES:
  itemsSource  get=0x01041090  set=0x09EEAB7C
  view  get=0x020B7B20
EVENTS:
  itemsSourceChanged  add=add_itemsSourceChanged  remove=remove_itemsSourceChanged
  itemIndexChanged  add=add_itemIndexChanged  remove=remove_itemIndexChanged
METHODS:
  RVA=0x022C3A90  token=0x6000690  System.Void SetItemsSourceWithoutNotify(System.Collections.IList source)
  RVA=0x09EEA8AC  token=0x6000692  System.Void SetView(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  RVA=0x0350B670  token=0x6000693  System.Void PrepareView()
  RVA=0x09EEA688  token=0x6000694  System.Void Dispose()
  RVA=0x09EEA720  token=0x6000695  System.Int32 GetItemsCount()
  RVA=0x09EEA740  token=0x6000696  System.Int32 GetItemsMinCount()
  RVA=0x03D66C70  token=0x6000697  System.Int32 GetIndexForId(System.Int32 id)
  RVA=0x03D66C70  token=0x6000698  System.Int32 GetIdForIndex(System.Int32 index)
  RVA=0x09EEA6C0  token=0x6000699  System.Object GetItemForIndex(System.Int32 index)
  RVA=0x09EEA82C  token=0x600069A  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=0x09EEA748  token=0x600069B  System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  RVA=0x09EEA864  token=0x600069C  System.Void InvokeUnbindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  RVA=0x09EEA804  token=0x600069D  System.Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=-1  // abstract  token=0x600069E  UnityEngine.UIElements.VisualElement MakeItem()
  RVA=-1  // abstract  token=0x600069F  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=-1  // abstract  token=0x60006A0  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=-1  // abstract  token=0x60006A1  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EEA89C  token=0x60006A2  System.Void RaiseItemsSourceChanged()
  RVA=0x09EE3B80  token=0x60006A3  System.Void RaiseItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex)
  RVA=0x0350B670  token=0x60006A4  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DefaultMultiColumnTreeViewController`1
TYPE:  class
TOKEN: 0x20000EB
EXTENDS: UnityEngine.UIElements.MultiColumnTreeViewController
FIELDS:
  private           UnityEngine.UIElements.TreeDataController<T>m_TreeDataController  // 0x0
PROPERTIES:
  treeDataController  get=-1  // not resolved
  itemsSource  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60006A6  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  RVA=-1  // not resolved  token=0x60006A9  System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items)
  RVA=-1  // not resolved  token=0x60006AA  System.Object GetItemForIndex(System.Int32 index)
  RVA=-1  // not resolved  token=0x60006AB  System.Int32 GetParentId(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006AC  System.Boolean HasChildren(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006AD  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006AE  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree)
  RVA=-1  // not resolved  token=0x60006AF  System.Boolean IsChildOf(System.Int32 childId, System.Int32 id)
  RVA=-1  // not resolved  token=0x60006B0  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
END_CLASS

CLASS: UnityEngine.UIElements.DefaultTreeViewController`1
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: UnityEngine.UIElements.TreeViewController
FIELDS:
  private           UnityEngine.UIElements.TreeDataController<T>m_TreeDataController  // 0x0
PROPERTIES:
  treeDataController  get=-1  // not resolved
  itemsSource  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60006B4  System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items)
  RVA=-1  // not resolved  token=0x60006B5  System.Object GetItemForIndex(System.Int32 index)
  RVA=-1  // not resolved  token=0x60006B6  System.Int32 GetParentId(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006B7  System.Boolean HasChildren(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006B8  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006B9  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree)
  RVA=-1  // not resolved  token=0x60006BA  System.Boolean IsChildOf(System.Int32 childId, System.Int32 id)
  RVA=-1  // not resolved  token=0x60006BB  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
  RVA=-1  // not resolved  token=0x60006BC  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ListViewController
TYPE:  class
TOKEN: 0x20000ED
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.BaseListViewController
FIELDS:
PROPERTIES:
  listView  get=0x09EEEE34
METHODS:
  RVA=0x09EEECEC  token=0x60006BE  UnityEngine.UIElements.VisualElement MakeItem()
  RVA=0x09EEEB30  token=0x60006BF  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EEEDEC  token=0x60006C0  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EEECB4  token=0x60006C1  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  RVA=0x0350B670  token=0x60006C2  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnListViewController
TYPE:  class
TOKEN: 0x20000EE
SIZE:  0x50
EXTENDS: UnityEngine.UIElements.BaseListViewController
FIELDS:
  private           UnityEngine.UIElements.MultiColumnControllerm_ColumnController  // 0x48
PROPERTIES:
  columnController  get=0x03D4EA70
  header  get=0x09EEF30C
METHODS:
  RVA=0x09EEF270  token=0x60006C5  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  RVA=0x09EEEFDC  token=0x60006C6  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=0x09EEF0BC  token=0x60006C7  UnityEngine.UIElements.VisualElement MakeItem()
  RVA=0x09EEEE70  token=0x60006C8  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EEF18C  token=0x60006C9  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EEEEFC  token=0x60006CA  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EEF0DC  token=0x60006CB  System.Void PrepareView()
  RVA=0x09EEEF1C  token=0x60006CC  System.Void Dispose()
  RVA=0x09EEF1AC  token=0x60006CD  System.Void UpdateReorderClassList()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnTreeViewController
TYPE:  abstract class
TOKEN: 0x20000EF
SIZE:  0x60
EXTENDS: UnityEngine.UIElements.BaseTreeViewController
FIELDS:
  private           UnityEngine.UIElements.MultiColumnControllerm_ColumnController  // 0x58
PROPERTIES:
  columnController  get=0x03D4EAA0
  header  get=0x09EEF5DC
METHODS:
  RVA=0x09EEF520  token=0x60006D0  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  RVA=0x09EEF408  token=0x60006D1  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  RVA=0x09EEF4B8  token=0x60006D2  UnityEngine.UIElements.VisualElement MakeItem()
  RVA=0x09EEF31C  token=0x60006D3  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EEF500  token=0x60006D4  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EEF3A8  token=0x60006D5  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EEF4D8  token=0x60006D6  System.Void PrepareView()
  RVA=0x09EEF3C8  token=0x60006D7  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.TreeDataController`1
TYPE:  sealed class
TOKEN: 0x20000F0
FIELDS:
  private           UnityEngine.UIElements.TreeData<T>m_TreeData  // 0x0
  private           System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<System.Int32>>m_IteratorStack  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60006D8  System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems)
  RVA=-1  // not resolved  token=0x60006D9  T GetDataForId(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006DA  System.Int32 GetParentId(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006DB  System.Boolean HasChildren(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006DC  System.Collections.Generic.IEnumerable<System.Int32> GetItemIds(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items)
  RVA=-1  // not resolved  token=0x60006DD  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  RVA=-1  // not resolved  token=0x60006DE  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex)
  RVA=-1  // not resolved  token=0x60006DF  System.Boolean IsChildOf(System.Int32 childId, System.Int32 id)
  RVA=-1  // not resolved  token=0x60006E0  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
  RVA=-1  // not resolved  token=0x60006E1  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewController
TYPE:  abstract class
TOKEN: 0x20000F3
SIZE:  0x58
EXTENDS: UnityEngine.UIElements.BaseTreeViewController
FIELDS:
PROPERTIES:
  treeView  get=0x09EF2084
METHODS:
  RVA=0x09EF1EF0  token=0x60006F4  UnityEngine.UIElements.VisualElement MakeItem()
  RVA=0x09EF1D58  token=0x60006F5  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EF1FF0  token=0x60006F6  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09EF1EB8  token=0x60006F7  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  RVA=0x09EF2038  token=0x60006F8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.CollectionVirtualizationController
TYPE:  abstract class
TOKEN: 0x20000F4
SIZE:  0x18
FIELDS:
  protected readonly UnityEngine.UIElements.ScrollViewm_ScrollView  // 0x10
PROPERTIES:
  firstVisibleIndex  get=-1  // abstract  set=-1  // abstract
  visibleItemCount  get=-1  // abstract
  activeItems  get=-1  // abstract
METHODS:
  RVA=0x0426FEE0  token=0x60006FC  System.Void .ctor(UnityEngine.UIElements.ScrollView scrollView)
  RVA=-1  // abstract  token=0x60006FD  System.Void Refresh(System.Boolean rebuild)
  RVA=-1  // abstract  token=0x60006FE  System.Void ScrollToItem(System.Int32 id)
  RVA=-1  // abstract  token=0x60006FF  System.Void Resize(UnityEngine.Vector2 size)
  RVA=-1  // abstract  token=0x6000700  System.Void OnScroll(UnityEngine.Vector2 offset)
  RVA=-1  // abstract  token=0x6000701  System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position)
  RVA=-1  // abstract  token=0x6000702  System.Single GetExpectedItemHeight(System.Int32 index)
  RVA=-1  // abstract  token=0x6000703  System.Single GetExpectedContentHeight()
  RVA=-1  // abstract  token=0x6000704  System.Void OnFocus(UnityEngine.UIElements.VisualElement leafTarget)
  RVA=-1  // abstract  token=0x6000705  System.Void OnBlur(UnityEngine.UIElements.VisualElement willFocus)
  RVA=-1  // abstract  token=0x6000706  System.Void UpdateBackground()
  RVA=-1  // abstract  token=0x6000708  System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=-1  // abstract  token=0x6000709  System.Void EndDrag(System.Int32 dropIndex)
END_CLASS

CLASS: UnityEngine.UIElements.DynamicHeightVirtualizationController`1
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: UnityEngine.UIElements.VerticalVirtualizationController`1
FIELDS:
  private           System.Int32                    m_HighestCachedIndex  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Single>m_ItemHeightCache  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T>>m_ContentHeightCache  // 0x0
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_WaitingCache  // 0x0
  private           System.Int32                    m_ForcedFirstVisibleItem  // 0x0
  private           System.Int32                    m_ForcedLastVisibleItem  // 0x0
  private           System.Boolean                  m_StickToBottom  // 0x0
  private           UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>m_LastChange  // 0x0
  private           UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>m_ScrollDirection  // 0x0
  private           UnityEngine.Vector2             m_DelayedScrollOffset  // 0x0
  private           System.Single                   m_AccumulatedHeight  // 0x0
  private           System.Single                   m_MinimumItemHeight  // 0x0
  private           System.Action                   m_FillCallback  // 0x0
  private           System.Action                   m_ScrollCallback  // 0x0
  private           System.Action                   m_ScrollResetCallback  // 0x0
  private           System.Action<UnityEngine.UIElements.ReusableCollectionItem>m_GeometryChangedCallback  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScheduledItem  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScrollScheduledItem  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScrollResetScheduledItem  // 0x0
  private           System.Predicate<System.Int32>  m_IndexOutOfBoundsPredicate  // 0x0
PROPERTIES:
  defaultExpectedHeight  get=-1  // not resolved
  contentPadding  get=-1  // not resolved  set=-1  // not resolved
  contentHeight  get=-1  // not resolved  set=-1  // not resolved
  anchoredIndex  get=-1  // not resolved  set=-1  // not resolved
  anchorOffset  get=-1  // not resolved  set=-1  // not resolved
  viewportMaxOffset  get=-1  // not resolved
  alwaysRebindOnRefresh  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000715  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  RVA=-1  // not resolved  token=0x6000716  System.Void Refresh(System.Boolean rebuild)
  RVA=-1  // not resolved  token=0x6000717  System.Void ScrollToItem(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000718  System.Void Resize(UnityEngine.Vector2 size)
  RVA=-1  // not resolved  token=0x6000719  System.Void OnScroll(UnityEngine.Vector2 scrollOffset)
  RVA=-1  // not resolved  token=0x600071A  System.Void OnScrollUpdate()
  RVA=-1  // not resolved  token=0x600071B  System.Void CycleItems(System.Int32 firstIndex)
  RVA=-1  // not resolved  token=0x600071C  System.Boolean NeedsFill()
  RVA=-1  // not resolved  token=0x600071D  System.Void Fill()
  RVA=-1  // not resolved  token=0x600071E  System.Void UpdateScrollViewContainer(System.Single previousHeight, System.Single newHeight)
  RVA=-1  // not resolved  token=0x600071F  System.Void ApplyScrollViewUpdate(System.Boolean dimensionsOnly)
  RVA=-1  // not resolved  token=0x6000720  System.Void UpdateAnchor()
  RVA=-1  // not resolved  token=0x6000721  System.Void ScheduleFill()
  RVA=-1  // not resolved  token=0x6000722  System.Void ScheduleScroll()
  RVA=-1  // not resolved  token=0x6000723  System.Void ScheduleScrollDirectionReset()
  RVA=-1  // not resolved  token=0x6000724  System.Void ResetScroll()
  RVA=-1  // not resolved  token=0x6000725  System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position)
  RVA=-1  // not resolved  token=0x6000726  System.Single GetExpectedItemHeight(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000727  System.Int32 GetFirstVisibleItem(System.Single offset)
  RVA=-1  // not resolved  token=0x6000728  System.Single GetExpectedContentHeight()
  RVA=-1  // not resolved  token=0x6000729  System.Single GetContentHeightForIndex(System.Int32 lastIndex)
  RVA=-1  // not resolved  token=0x600072A  UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T> GetCachedContentHeight(System.Int32 index)
  RVA=-1  // not resolved  token=0x600072B  System.Void RegisterItemHeight(System.Int32 index, System.Single height)
  RVA=-1  // not resolved  token=0x600072C  System.Void UnregisterItemHeight(System.Int32 index)
  RVA=-1  // not resolved  token=0x600072D  System.Void CleanItemHeightCache()
  RVA=-1  // not resolved  token=0x600072E  System.Void OnRecycledItemGeometryChanged(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=-1  // not resolved  token=0x600072F  System.Boolean UpdateRegisteredHeight(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=-1  // not resolved  token=0x6000730  T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex)
  RVA=-1  // not resolved  token=0x6000731  System.Void ReleaseItem(System.Int32 activeItemsIndex)
  RVA=-1  // not resolved  token=0x6000732  System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=-1  // not resolved  token=0x6000733  System.Void EndDrag(System.Int32 dropIndex)
  RVA=-1  // not resolved  token=0x6000734  System.Void HideItem(System.Int32 activeItemsIndex)
  RVA=-1  // not resolved  token=0x6000735  System.Void MarkWaitingForLayout(T item)
  RVA=-1  // not resolved  token=0x6000736  System.Boolean IsIndexOutOfBounds(System.Int32 i)
END_CLASS

CLASS: UnityEngine.UIElements.FixedHeightVirtualizationController`1
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: UnityEngine.UIElements.VerticalVirtualizationController`1
FIELDS:
PROPERTIES:
  resolvedItemHeight  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000739  System.Boolean VisibleItemPredicate(T i)
  RVA=-1  // not resolved  token=0x600073A  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  RVA=-1  // not resolved  token=0x600073B  System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position)
  RVA=-1  // not resolved  token=0x600073C  System.Single GetExpectedItemHeight(System.Int32 index)
  RVA=-1  // not resolved  token=0x600073D  System.Single GetExpectedContentHeight()
  RVA=-1  // not resolved  token=0x600073E  System.Void ScrollToItem(System.Int32 index)
  RVA=-1  // not resolved  token=0x600073F  System.Void Resize(UnityEngine.Vector2 size)
  RVA=-1  // not resolved  token=0x6000740  System.Void OnScroll(UnityEngine.Vector2 scrollOffset)
  RVA=-1  // not resolved  token=0x6000741  T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex)
  RVA=-1  // not resolved  token=0x6000742  System.Void EndDrag(System.Int32 dropIndex)
END_CLASS

CLASS: UnityEngine.UIElements.ReusableCollectionItem
TYPE:  class
TOKEN: 0x20000FA
SIZE:  0x48
FIELDS:
  private           UnityEngine.UIElements.VisualElement<bindableElement>k__BackingField  // 0x10
  private           UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues><animator>k__BackingField  // 0x18
  private           System.Int32                    <index>k__BackingField  // 0x20
  private           System.Int32                    <id>k__BackingField  // 0x24
  private           System.Boolean                  <isDragGhost>k__BackingField  // 0x28
  private           System.Action<UnityEngine.UIElements.ReusableCollectionItem>onGeometryChanged  // 0x30
  protected         UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent>m_GeometryChangedEventCallback  // 0x38
  private           System.Action<UnityEngine.UIElements.ReusableCollectionItem>onDestroy  // 0x40
PROPERTIES:
  rootElement  get=0x020B7B20
  bindableElement  get=0x020B7B20  set=0x0426FEE0
  animator  get=0x01041090  set=0x022C3A90
  index  get=0x01003B50  set=0x01003B60
  id  get=0x03D4E2E0  set=0x03D4E2F0
  isDragGhost  get=0x03D4ED50  set=0x03D4ED60
EVENTS:
  onGeometryChanged  add=add_onGeometryChanged  remove=remove_onGeometryChanged
  onDestroy  add=add_onDestroy  remove=remove_onDestroy
METHODS:
  RVA=0x09EEFAD8  token=0x6000752  System.Void .ctor()
  RVA=0x0426FEE0  token=0x6000753  System.Void Init(UnityEngine.UIElements.VisualElement item)
  RVA=0x09EEF7F4  token=0x6000754  System.Void PreAttachElement()
  RVA=0x09EEF6E8  token=0x6000755  System.Void DetachElement()
  RVA=0x09EEF6D0  token=0x6000756  System.Void DestroyElement()
  RVA=0x09EEF9D4  token=0x6000757  System.Void SetSelected(System.Boolean selected)
  RVA=0x09EEF8A0  token=0x6000758  System.Void SetDragGhost(System.Boolean dragGhost)
  RVA=0x09EEF7DC  token=0x6000759  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.ReusableListViewItem
TYPE:  class
TOKEN: 0x20000FB
SIZE:  0x60
EXTENDS: UnityEngine.UIElements.ReusableCollectionItem
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_Container  // 0x48
  private           UnityEngine.UIElements.VisualElementm_DragHandle  // 0x50
  private           UnityEngine.UIElements.VisualElementm_ItemContainer  // 0x58
PROPERTIES:
  rootElement  get=0x09EF03C0
METHODS:
  RVA=0x09EEFE04  token=0x600075B  System.Void Init(UnityEngine.UIElements.VisualElement item, System.Boolean usesAnimatedDragger)
  RVA=0x09EF00D8  token=0x600075C  System.Void UpdateHierarchy(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElement item, System.Boolean usesAnimatedDragger)
  RVA=0x09EEFFC4  token=0x600075D  System.Void UpdateDragHandle(System.Boolean needsDragHandle)
  RVA=0x09EEFEC8  token=0x600075E  System.Void PreAttachElement()
  RVA=0x09EEFD8C  token=0x600075F  System.Void DetachElement()
  RVA=0x09EEFF40  token=0x6000760  System.Void SetDragGhost(System.Boolean dragGhost)
  RVA=0x09EF03B8  token=0x6000761  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ReusableMultiColumnListViewItem
TYPE:  class
TOKEN: 0x20000FC
SIZE:  0x60
EXTENDS: UnityEngine.UIElements.ReusableListViewItem
FIELDS:
PROPERTIES:
  rootElement  get=0x020B7B20
METHODS:
  RVA=0x0350B670  token=0x6000763  System.Void Init(UnityEngine.UIElements.VisualElement item)
  RVA=0x09EF03D0  token=0x6000764  System.Void Init(UnityEngine.UIElements.VisualElement container, UnityEngine.UIElements.Columns columns, System.Boolean usesAnimatedDrag)
  RVA=0x09EF03B8  token=0x6000765  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ReusableMultiColumnTreeViewItem
TYPE:  class
TOKEN: 0x20000FD
SIZE:  0xA0
EXTENDS: UnityEngine.UIElements.ReusableTreeViewItem
FIELDS:
PROPERTIES:
  rootElement  get=0x020B7B20
METHODS:
  RVA=0x0350B670  token=0x6000767  System.Void Init(UnityEngine.UIElements.VisualElement item)
  RVA=0x09EF05F0  token=0x6000768  System.Void Init(UnityEngine.UIElements.VisualElement container, UnityEngine.UIElements.Columns columns)
  RVA=0x09EF07F8  token=0x6000769  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ReusableTreeViewItem
TYPE:  class
TOKEN: 0x20000FE
SIZE:  0xA0
EXTENDS: UnityEngine.UIElements.ReusableCollectionItem
FIELDS:
  private           UnityEngine.UIElements.Toggle   m_Toggle  // 0x48
  private           UnityEngine.UIElements.VisualElementm_Container  // 0x50
  private           UnityEngine.UIElements.VisualElementm_IndentElement  // 0x58
  private           UnityEngine.UIElements.VisualElementm_BindableContainer  // 0x60
  private           UnityEngine.UIElements.VisualElementm_Checkmark  // 0x68
  private           System.Action<UnityEngine.UIElements.PointerUpEvent>onPointerUp  // 0x70
  private           System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>>onToggleValueChanged  // 0x78
  private           System.Int32                    m_Depth  // 0x80
  private           System.Single                   m_IndentWidth  // 0x84
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent>m_PointerUpCallback  // 0x88
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>>m_ToggleValueChangedCallback  // 0x90
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent>m_ToggleGeometryChangedCallback  // 0x98
PROPERTIES:
  rootElement  get=0x09EF144C
EVENTS:
  onPointerUp  add=add_onPointerUp  remove=remove_onPointerUp
  onToggleValueChanged  add=add_onToggleValueChanged  remove=remove_onToggleValueChanged
METHODS:
  RVA=0x09EF11FC  token=0x600076F  System.Void .ctor()
  RVA=0x09EF0DA8  token=0x6000770  System.Void Init(UnityEngine.UIElements.VisualElement item)
  RVA=0x09EF0994  token=0x6000771  System.Void InitExpandHierarchy(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElement item)
  RVA=0x09EF0F7C  token=0x6000772  System.Void PreAttachElement()
  RVA=0x09EF0800  token=0x6000773  System.Void DetachElement()
  RVA=0x09EF097C  token=0x6000774  System.Void Indent(System.Int32 depth)
  RVA=0x09EF10F8  token=0x6000775  System.Void SetExpandedWithoutNotify(System.Boolean expanded)
  RVA=0x09EF1110  token=0x6000776  System.Void SetToggleVisibility(System.Boolean visible)
  RVA=0x09EF0E94  token=0x6000777  System.Void OnToggleGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EF112C  token=0x6000778  System.Void UpdateIndentLayout()
  RVA=0x09EF0E80  token=0x6000779  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EF0F68  token=0x600077A  System.Void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
END_CLASS

CLASS: UnityEngine.UIElements.VerticalVirtualizationController`1
TYPE:  abstract class
TOKEN: 0x20000FF
EXTENDS: UnityEngine.UIElements.CollectionVirtualizationController
FIELDS:
  private   readonly UnityEngine.Pool.ObjectPool<T>  m_Pool  // 0x0
  protected         UnityEngine.UIElements.BaseVerticalCollectionViewm_CollectionView  // 0x0
  protected         System.Collections.Generic.List<T>m_ActiveItems  // 0x0
  protected         T                               m_DraggedItem  // 0x0
  private           System.Int32                    m_LastFocusedElementIndex  // 0x0
  private           System.Collections.Generic.List<System.Int32>m_LastFocusedElementTreeChildIndexes  // 0x0
  protected readonly System.Func<T,System.Boolean>   m_VisibleItemPredicateDelegate  // 0x0
  protected         System.Collections.Generic.List<T>m_ScrollInsertionList  // 0x0
  private           UnityEngine.UIElements.VisualElementm_EmptyRows  // 0x0
PROPERTIES:
  activeItems  get=-1  // not resolved
  itemsCount  get=-1  // not resolved
  firstVisibleItem  get=-1  // not resolved
  lastVisibleItem  get=-1  // not resolved
  visibleItemCount  get=-1  // not resolved
  serializedData  get=-1  // not resolved
  firstVisibleIndex  get=-1  // not resolved  set=-1  // not resolved
  lastHeight  get=-1  // not resolved
  alwaysRebindOnRefresh  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600077D  System.Boolean VisibleItemPredicate(T i)
  RVA=-1  // not resolved  token=0x6000786  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  RVA=-1  // not resolved  token=0x6000787  System.Void Refresh(System.Boolean rebuild)
  RVA=-1  // not resolved  token=0x6000788  System.Void Setup(T recycledItem, System.Int32 newIndex)
  RVA=-1  // not resolved  token=0x6000789  System.Void OnFocus(UnityEngine.UIElements.VisualElement leafTarget)
  RVA=-1  // not resolved  token=0x600078A  System.Void OnBlur(UnityEngine.UIElements.VisualElement willFocus)
  RVA=-1  // not resolved  token=0x600078B  System.Void HandleFocus(UnityEngine.UIElements.ReusableCollectionItem recycledItem, System.Int32 previousIndex)
  RVA=-1  // not resolved  token=0x600078C  System.Void UpdateBackground()
  RVA=-1  // not resolved  token=0x600078D  System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=-1  // not resolved  token=0x600078E  System.Void EndDrag(System.Int32 dropIndex)
  RVA=-1  // not resolved  token=0x600078F  T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex)
  RVA=-1  // not resolved  token=0x6000790  System.Void ReleaseItem(System.Int32 activeItemsIndex)
  RVA=-1  // not resolved  token=0x6000791  System.Void OnDestroyItem(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=-1  // not resolved  token=0x6000792  System.Int32 GetDraggedIndex()
END_CLASS

CLASS: UnityEngine.UIElements.BaseBoolField
TYPE:  abstract class
TOKEN: 0x2000101
SIZE:  0x438
EXTENDS: UnityEngine.UIElements.BaseField`1
FIELDS:
  protected         UnityEngine.UIElements.Label    m_Label  // 0x418
  protected readonly UnityEngine.UIElements.VisualElementm_CheckMark  // 0x420
  private           UnityEngine.UIElements.Clickablem_Clickable  // 0x428
  private           System.String                   m_OriginalText  // 0x430
PROPERTIES:
  text  get=0x09EDF79C  set=0x09EDF7BC
METHODS:
  RVA=0x09EDF514  token=0x6000798  System.Void .ctor(System.String label)
  RVA=0x09EDF2A4  token=0x6000799  System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt)
  RVA=0x09EDF21C  token=0x600079A  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=0x09EDF008  token=0x600079D  System.Void InitLabel()
  RVA=0x09EDF2D0  token=0x600079E  System.Void SetValueWithoutNotify(System.Boolean newValue)
  RVA=0x09EDF0A4  token=0x600079F  System.Void OnClickEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09EDF384  token=0x60007A0  System.Void ToggleValue()
  RVA=0x09EDF3B4  token=0x60007A1  System.Void UpdateMixedValueContent()
END_CLASS

CLASS: UnityEngine.UIElements.BaseField`1
TYPE:  abstract class
TOKEN: 0x2000102
EXTENDS: UnityEngine.UIElements.BindableElement
IMPLEMENTS: UnityEngine.UIElements.INotifyValueChanged`1
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x0
  public    static readonly System.String                   inputUssClassName  // static @ 0x0
  public    static readonly System.String                   noLabelVariantUssClassName  // static @ 0x0
  public    static readonly System.String                   labelDraggerVariantUssClassName  // static @ 0x0
  public    static readonly System.String                   mixedValueLabelUssClassName  // static @ 0x0
  public    static readonly System.String                   alignedFieldUssClassName  // static @ 0x0
  private   static readonly System.String                   inspectorFieldUssClassName  // static @ 0x0
  protected internalstatic readonly System.String                   mixedValueString  // static @ 0x0
  protected internalstatic readonly UnityEngine.PropertyName        serializedPropertyCopyName  // static @ 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Single>s_LabelWidthRatioProperty  // static @ 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Single>s_LabelExtraPaddingProperty  // static @ 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Single>s_LabelBaseMinWidthProperty  // static @ 0x0
  private           System.Single                   m_LabelWidthRatio  // 0x0
  private           System.Single                   m_LabelExtraPadding  // 0x0
  private           System.Single                   m_LabelBaseMinWidth  // 0x0
  private           UnityEngine.UIElements.VisualElementm_VisualInput  // 0x0
  private           TValueType                      m_Value  // 0x0
  private           UnityEngine.UIElements.Label    <labelElement>k__BackingField  // 0x0
  private           System.Boolean                  m_ShowMixedValue  // 0x0
  private           UnityEngine.UIElements.Label    m_MixedValueLabel  // 0x0
  private           UnityEngine.UIElements.VisualElementm_CachedInspectorElement  // 0x0
  private           System.Int32                    m_CachedListAndFoldoutDepth  // 0x0
PROPERTIES:
  visualInput  get=-1  // not resolved  set=-1  // not resolved
  rawValue  get=-1  // not resolved  set=-1  // not resolved
  value  get=-1  // not resolved  set=-1  // not resolved
  labelElement  get=-1  // not resolved  set=-1  // not resolved
  label  get=-1  // not resolved  set=-1  // not resolved
  showMixedValue  get=-1  // not resolved  set=-1  // not resolved
  mixedValueLabel  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60007AF  System.Void .ctor(System.String label)
  RVA=-1  // not resolved  token=0x60007B0  System.Void .ctor(System.String label, UnityEngine.UIElements.VisualElement visualInput)
  RVA=-1  // not resolved  token=0x60007B1  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e)
  RVA=-1  // not resolved  token=0x60007B2  System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt)
  RVA=-1  // not resolved  token=0x60007B3  System.Void OnInspectorFieldGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  RVA=-1  // not resolved  token=0x60007B4  System.Void AlignLabel()
  RVA=-1  // not resolved  token=0x60007B5  System.Void UpdateMixedValueContent()
  RVA=-1  // not resolved  token=0x60007B6  System.Void SetValueWithoutNotify(TValueType newValue)
  RVA=-1  // not resolved  token=0x60007B7  System.Void OnViewDataReady()
  RVA=-1  // not resolved  token=0x60007B8  UnityEngine.Rect GetTooltipRect()
  RVA=-1  // not resolved  token=0x60007B9  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseFieldTraits`2
TYPE:  class
TOKEN: 0x2000104
EXTENDS: UxmlTraits
FIELDS:
  private           TValueUxmlAttributeType         m_Value  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60007BD  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x60007BE  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ListViewReorderMode
TYPE:  sealed struct
TOKEN: 0x2000105
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ListViewReorderModeSimple  // const
  public    static  UnityEngine.UIElements.ListViewReorderModeAnimated  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.BaseListView
TYPE:  abstract class
TOKEN: 0x2000106
SIZE:  0x538
EXTENDS: UnityEngine.UIElements.BaseVerticalCollectionView
FIELDS:
  private   static readonly System.String                   k_SizeFieldLabel  // static @ 0x0
  private           System.Boolean                  m_ShowBoundCollectionSize  // 0x4a8
  private           System.Boolean                  m_ShowFoldoutHeader  // 0x4a9
  private           System.String                   m_HeaderTitle  // 0x4b0
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsAdded  // 0x4b8
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsRemoved  // 0x4c0
  private           System.Action                   itemsSourceSizeChanged  // 0x4c8
  private           UnityEngine.UIElements.Label    m_ListViewLabel  // 0x4d0
  protected         UnityEngine.UIElements.Foldout  m_Foldout  // 0x4d8
  protected         UnityEngine.UIElements.TextFieldm_ArraySizeField  // 0x4e0
  private           System.Boolean                  m_IsOverMultiEditLimit  // 0x4e8
  private           UnityEngine.UIElements.VisualElementm_Footer  // 0x4f0
  private           UnityEngine.UIElements.Button   m_AddButton  // 0x4f8
  private           UnityEngine.UIElements.Button   m_RemoveButton  // 0x500
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>m_ItemAddedCallback  // 0x508
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>m_ItemRemovedCallback  // 0x510
  private           System.Action                   m_ItemsSourceSizeChangedCallback  // 0x518
  private           UnityEngine.UIElements.ListViewReorderModem_ReorderMode  // 0x520
  private           System.Action                   reorderModeChanged  // 0x528
  public    static readonly System.String                   ussClassName  // static @ 0x8
  public    static readonly System.String                   itemUssClassName  // static @ 0x10
  public    static readonly System.String                   emptyLabelUssClassName  // static @ 0x18
  public    static readonly System.String                   overMaxMultiEditLimitClassName  // static @ 0x20
  public    static readonly System.String                   reorderableUssClassName  // static @ 0x28
  public    static readonly System.String                   reorderableItemUssClassName  // static @ 0x30
  public    static readonly System.String                   reorderableItemContainerUssClassName  // static @ 0x38
  public    static readonly System.String                   reorderableItemHandleUssClassName  // static @ 0x40
  public    static readonly System.String                   reorderableItemHandleBarUssClassName  // static @ 0x48
  public    static readonly System.String                   footerUssClassName  // static @ 0x50
  public    static readonly System.String                   foldoutHeaderUssClassName  // static @ 0x58
  public    static readonly System.String                   arraySizeFieldUssClassName  // static @ 0x60
  public    static readonly System.String                   arraySizeFieldWithHeaderUssClassName  // static @ 0x68
  public    static readonly System.String                   arraySizeFieldWithFooterUssClassName  // static @ 0x70
  public    static readonly System.String                   listViewWithHeaderUssClassName  // static @ 0x78
  public    static readonly System.String                   listViewWithFooterUssClassName  // static @ 0x80
  public    static readonly System.String                   scrollViewWithFooterUssClassName  // static @ 0x88
  public    static readonly System.String                   footerAddButtonName  // static @ 0x90
  public    static readonly System.String                   footerRemoveButtonName  // static @ 0x98
  private           System.String                   m_MaxMultiEditStr  // 0x530
  private   static readonly System.String                   k_EmptyListStr  // static @ 0xa0
PROPERTIES:
  showBoundCollectionSize  get=0x03D88E80  set=0x09EE1820
  showFoldoutHeader  get=0x03D88E90  set=0x09EE1838
  headerTitle  set=0x09EE178C
  showAddRemoveFooter  get=0x09EE16A8  set=0x09EE1818
  footer  get=0x03D6C880
  viewController  get=0x09EE16B4
  reorderMode  get=0x03D88E70  set=0x09EE17CC
EVENTS:
  reorderModeChanged  add=add_reorderModeChanged  remove=remove_reorderModeChanged
METHODS:
  RVA=0x09EE0810  token=0x60007C3  System.Void SetupArraySizeField()
  RVA=0x09EDF98C  token=0x60007C7  System.Void EnableFooter(System.Boolean enabled)
  RVA=0x09EDF844  token=0x60007C8  System.Void AddItems(System.Int32 itemCount)
  RVA=0x09EE01C0  token=0x60007C9  System.Void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<System.String> evt)
  RVA=0x09EE0BAC  token=0x60007CA  System.Void UpdateArraySizeField()
  RVA=0x09EE0C6C  token=0x60007CB  System.Void UpdateListViewLabel()
  RVA=0x09EE00A4  token=0x60007CC  System.Void OnAddClicked()
  RVA=0x09EE044C  token=0x60007CD  System.Void OnRemoveClicked()
  RVA=0x09EDF950  token=0x60007D0  System.Void CreateVirtualizationController()
  RVA=0x09EE05BC  token=0x60007D1  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  RVA=0x09EE03A8  token=0x60007D2  System.Void OnItemAdded(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09EE03C0  token=0x60007D3  System.Void OnItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09EE03D8  token=0x60007D4  System.Void OnItemsSourceSizeChanged()
  RVA=0x09EDF8D0  token=0x60007D9  UnityEngine.UIElements.ListViewDragger CreateDragger()
  RVA=0x09EDF870  token=0x60007DA  UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
  RVA=0x09EE1588  token=0x60007DB  System.Void .ctor()
  RVA=0x09EE0590  token=0x60007DC  System.Void PostRefresh()
  RVA=0x09EDFDA4  token=0x60007DD  System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altPressed)
  RVA=0x09EE0EA0  token=0x60007DE  System.Void .cctor()
  RVA=0x09EE0B64  token=0x60007DF  System.Void <OnAddClicked>b__38_0()
END_CLASS

CLASS: UnityEngine.UIElements.SliderDirection
TYPE:  sealed struct
TOKEN: 0x2000108
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.SliderDirectionHorizontal  // const
  public    static  UnityEngine.UIElements.SliderDirectionVertical  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.BaseSlider`1
TYPE:  abstract class
TOKEN: 0x2000109
EXTENDS: UnityEngine.UIElements.BaseField`1
FIELDS:
  private           UnityEngine.UIElements.VisualElement<dragContainer>k__BackingField  // 0x0
  private           UnityEngine.UIElements.VisualElement<dragElement>k__BackingField  // 0x0
  private           UnityEngine.UIElements.VisualElement<dragBorderElement>k__BackingField  // 0x0
  private           UnityEngine.UIElements.TextField<inputTextField>k__BackingField  // 0x0
  private           TValueType                      m_LowValue  // 0x0
  private           TValueType                      m_HighValue  // 0x0
  private           System.Single                   m_PageSize  // 0x0
  private           System.Boolean                  m_ShowInputField  // 0x0
  private           System.Boolean                  <clamped>k__BackingField  // 0x0
  private           UnityEngine.UIElements.ClampedDragger<TValueType><clampedDragger>k__BackingField  // 0x0
  private           UnityEngine.Rect                m_DragElementStartPos  // 0x0
  private           UnityEngine.UIElements.SliderDirectionm_Direction  // 0x0
  private           System.Boolean                  m_Inverted  // 0x0
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x0
  public    static readonly System.String                   inputUssClassName  // static @ 0x0
  public    static readonly System.String                   horizontalVariantUssClassName  // static @ 0x0
  public    static readonly System.String                   verticalVariantUssClassName  // static @ 0x0
  public    static readonly System.String                   dragContainerUssClassName  // static @ 0x0
  public    static readonly System.String                   trackerUssClassName  // static @ 0x0
  public    static readonly System.String                   draggerUssClassName  // static @ 0x0
  public    static readonly System.String                   draggerBorderUssClassName  // static @ 0x0
  public    static readonly System.String                   textFieldClassName  // static @ 0x0
PROPERTIES:
  dragContainer  get=-1  // not resolved  set=-1  // not resolved
  dragElement  get=-1  // not resolved  set=-1  // not resolved
  dragBorderElement  get=-1  // not resolved  set=-1  // not resolved
  inputTextField  get=-1  // not resolved  set=-1  // not resolved
  lowValue  get=-1  // not resolved  set=-1  // not resolved
  highValue  get=-1  // not resolved  set=-1  // not resolved
  pageSize  get=-1  // not resolved  set=-1  // not resolved
  showInputField  get=-1  // not resolved  set=-1  // not resolved
  clamped  get=-1  // not resolved  set=-1  // not resolved
  clampedDragger  get=-1  // not resolved  set=-1  // not resolved
  value  get=-1  // not resolved  set=-1  // not resolved
  direction  get=-1  // not resolved  set=-1  // not resolved
  inverted  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60007EE  System.Void SetHighValueWithoutNotify(TValueType newHighValue)
  RVA=-1  // not resolved  token=0x60007F7  TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound)
  RVA=-1  // not resolved  token=0x60007F8  TValueType GetClampedValue(TValueType newValue)
  RVA=-1  // not resolved  token=0x60007FB  System.Void SetValueWithoutNotify(TValueType newValue)
  RVA=-1  // not resolved  token=0x6000800  System.Void .ctor(System.String label, TValueType start, TValueType end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  RVA=-1  // not resolved  token=0x6000801  System.Single GetClosestPowerOfTen(System.Single positiveNumber)
  RVA=-1  // not resolved  token=0x6000802  System.Single RoundToMultipleOf(System.Single value, System.Single roundingValue)
  RVA=-1  // not resolved  token=0x6000803  System.Void ClampValue()
  RVA=-1  // abstract  token=0x6000804  TValueType SliderLerpUnclamped(TValueType a, TValueType b, System.Single interpolant)
  RVA=-1  // abstract  token=0x6000805  System.Single SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue)
  RVA=-1  // abstract  token=0x6000806  TValueType ParseStringToValue(System.String stringValue)
  RVA=-1  // abstract  token=0x6000807  System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> sliderKey, System.Boolean isShift)
  RVA=-1  // not resolved  token=0x6000808  TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, System.Single positionInterpolant)
  RVA=-1  // not resolved  token=0x6000809  System.Void SetSliderValueFromDrag()
  RVA=-1  // not resolved  token=0x600080A  System.Void ComputeValueAndDirectionFromDrag(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos)
  RVA=-1  // not resolved  token=0x600080B  System.Void SetSliderValueFromClick()
  RVA=-1  // not resolved  token=0x600080C  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=-1  // not resolved  token=0x600080D  System.Void ComputeValueAndDirectionFromClick(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos, System.Single dragElementLastPos)
  RVA=-1  // not resolved  token=0x600080E  System.Void AdjustDragElement(System.Single factor)
  RVA=-1  // not resolved  token=0x600080F  System.Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=-1  // not resolved  token=0x6000810  System.Void OnViewDataReady()
  RVA=-1  // not resolved  token=0x6000811  System.Boolean SameValues(System.Single a, System.Single b, System.Single epsilon)
  RVA=-1  // not resolved  token=0x6000812  System.Void UpdateDragElementPosition()
  RVA=-1  // not resolved  token=0x6000813  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // not resolved  token=0x6000814  System.Void UpdateTextFieldVisibility()
  RVA=-1  // not resolved  token=0x6000815  System.Void UpdateTextFieldValue()
  RVA=-1  // not resolved  token=0x6000816  System.Void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent evt)
  RVA=-1  // not resolved  token=0x6000817  System.Void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String> evt)
  RVA=-1  // not resolved  token=0x6000818  System.Void UpdateMixedValueContent()
  RVA=-1  // not resolved  token=0x6000819  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseTreeView
TYPE:  abstract class
TOKEN: 0x200010B
SIZE:  0x4B8
EXTENDS: UnityEngine.UIElements.BaseVerticalCollectionView
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   itemUssClassName  // static @ 0x8
  public    static readonly System.String                   itemToggleUssClassName  // static @ 0x10
  public    static readonly System.String                   itemIndentsContainerUssClassName  // static @ 0x18
  public    static readonly System.String                   itemIndentUssClassName  // static @ 0x20
  public    static readonly System.String                   itemContentContainerUssClassName  // static @ 0x28
  private           System.Boolean                  m_AutoExpand  // 0x4a8
  private           System.Collections.Generic.List<System.Int32>m_ExpandedItemIds  // 0x4b0
PROPERTIES:
  itemsSource  get=0x09EE4EC0
  viewController  get=0x09EE4EE8
  autoExpand  get=0x03D88E80  set=0x09EE4F28
  expandedItemIds  get=0x03D57330  set=0x058B4014
METHODS:
  RVA=0x09EE42B0  token=0x600081C  System.Void CreateVirtualizationController()
  RVA=0x09EE4A34  token=0x600081D  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  RVA=0x09EE484C  token=0x600081E  System.Void OnItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex)
  RVA=0x09EE4250  token=0x600081F  UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
  RVA=0x09EE4EB0  token=0x6000824  System.Void .ctor()
  RVA=0x09EE4D68  token=0x6000825  System.Void .ctor(System.Int32 itemHeight)
  RVA=0x09EE488C  token=0x6000826  System.Void OnViewDataReady()
  RVA=0x09EE44A4  token=0x6000827  System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altPressed)
  RVA=0x09EE48E8  token=0x6000828  System.Void SetSelectionById(System.Int32 id)
  RVA=0x09EE48DC  token=0x6000829  System.Void SetSelectionById(System.Collections.Generic.IEnumerable<System.Int32> ids)
  RVA=0x09EE495C  token=0x600082A  System.Void SetSelectionInternalById(System.Collections.Generic.IEnumerable<System.Int32> ids, System.Boolean sendNotification)
  RVA=0x09EE43B8  token=0x600082B  System.Int32 GetItemIndex(System.Int32 id, System.Boolean expand)
  RVA=0x09EE4820  token=0x600082C  System.Boolean IsExpanded(System.Int32 id)
  RVA=0x09EE41FC  token=0x600082D  System.Void CollapseItem(System.Int32 id, System.Boolean collapseAllChildren)
  RVA=0x09EE4370  token=0x600082E  System.Void ExpandItem(System.Int32 id, System.Boolean expandAllChildren)
  RVA=0x09EE4854  token=0x600082F  System.Void OnTreeViewPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EE47F4  token=0x6000830  System.Boolean IsExpandedByIndex(System.Int32 index)
  RVA=0x09EE417C  token=0x6000831  System.Void CollapseItemByIndex(System.Int32 index, System.Boolean collapseAll)
  RVA=0x09EE42EC  token=0x6000832  System.Void ExpandItemByIndex(System.Int32 index, System.Boolean expandAll)
  RVA=0x09EE4B64  token=0x6000833  System.Void .cctor()
  RVA=0x09EE4B58  token=0x6000834  System.Int32 <SetSelectionInternalById>b__47_0(System.Int32 id)
END_CLASS

CLASS: UnityEngine.UIElements.AlternatingRowBackground
TYPE:  sealed struct
TOKEN: 0x200010D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.AlternatingRowBackgroundNone  // const
  public    static  UnityEngine.UIElements.AlternatingRowBackgroundContentOnly  // const
  public    static  UnityEngine.UIElements.AlternatingRowBackgroundAll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CollectionVirtualizationMethod
TYPE:  sealed struct
TOKEN: 0x200010E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.CollectionVirtualizationMethodFixedHeight  // const
  public    static  UnityEngine.UIElements.CollectionVirtualizationMethodDynamicHeight  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.SerializedVirtualizationData
TYPE:  class
TOKEN: 0x200010F
SIZE:  0x30
FIELDS:
  public            UnityEngine.Vector2             scrollOffset  // 0x10
  public            System.Int32                    firstVisibleIndex  // 0x18
  public            System.Single                   contentPadding  // 0x1c
  public            System.Single                   contentHeight  // 0x20
  public            System.Int32                    anchoredItemIndex  // 0x24
  public            System.Single                   anchorOffset  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000837  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseVerticalCollectionView
TYPE:  abstract class
TOKEN: 0x2000110
SIZE:  0x4A8
EXTENDS: UnityEngine.UIElements.BindableElement
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_RefreshMarker  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_RebuildMarker  // static @ 0x8
  private           System.Action<System.Collections.Generic.IEnumerable<System.Object>>itemsChosen  // 0x3d0
  private           System.Action<System.Collections.Generic.IEnumerable<System.Object>>selectionChanged  // 0x3d8
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>selectedIndicesChanged  // 0x3e0
  private           System.Action<System.Int32,System.Int32>itemIndexChanged  // 0x3e8
  private           System.Action                   itemsSourceChanged  // 0x3f0
  private           System.Action                   selectionNotChanged  // 0x3f8
  private           System.Func<UnityEngine.UIElements.CanStartDragArgs,System.Boolean>canStartDrag  // 0x400
  private           System.Func<UnityEngine.UIElements.SetupDragAndDropArgs,UnityEngine.UIElements.StartDragArgs>setupDragAndDrop  // 0x408
  private           System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode>dragAndDropUpdate  // 0x410
  private           System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode>handleDrop  // 0x418
  private           UnityEngine.UIElements.SelectionTypem_SelectionType  // 0x420
  private   static readonly System.Collections.Generic.List<UnityEngine.UIElements.ReusableCollectionItem>k_EmptyItems  // static @ 0x10
  private           System.Boolean                  m_HorizontalScrollingEnabled  // 0x424
  private           UnityEngine.UIElements.AlternatingRowBackgroundm_ShowAlternatingRowBackgrounds  // 0x428
  private   static readonly System.Int32                    s_DefaultItemHeight  // static @ 0x18
  private           System.Single                   m_FixedItemHeight  // 0x42c
  private           System.Boolean                  m_ItemHeightIsInline  // 0x430
  private           UnityEngine.UIElements.CollectionVirtualizationMethodm_VirtualizationMethod  // 0x434
  private   readonly UnityEngine.UIElements.ScrollViewm_ScrollView  // 0x438
  private           UnityEngine.UIElements.CollectionViewControllerm_ViewController  // 0x440
  private           UnityEngine.UIElements.CollectionVirtualizationControllerm_VirtualizationController  // 0x448
  private           UnityEngine.UIElements.KeyboardNavigationManipulatorm_NavigationManipulator  // 0x450
  private           UnityEngine.UIElements.SerializedVirtualizationDataserializedVirtualizationData  // 0x458
  private   readonly System.Collections.Generic.List<System.Int32>m_SelectedIds  // 0x460
  private   readonly UnityEngine.UIElements.BaseVerticalCollectionView.Selectionm_Selection  // 0x468
  private           System.Single                   m_LastHeight  // 0x470
  private           System.Boolean                  m_IsRangeSelectionDirectionUp  // 0x474
  private           UnityEngine.UIElements.ListViewDraggerm_Dragger  // 0x478
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Int32>s_ItemHeightProperty  // static @ 0x20
  private           System.Action<System.Int32,System.Int32>m_ItemIndexChangedCallback  // 0x480
  private           System.Action                   m_ItemsSourceChangedCallback  // 0x488
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_RebuildScheduled  // 0x490
  public    static readonly System.String                   ussClassName  // static @ 0x28
  public    static readonly System.String                   borderUssClassName  // static @ 0x30
  public    static readonly System.String                   itemUssClassName  // static @ 0x38
  public    static readonly System.String                   dragHoverBarUssClassName  // static @ 0x40
  public    static readonly System.String                   dragHoverMarkerUssClassName  // static @ 0x48
  public    static readonly System.String                   itemDragHoverUssClassName  // static @ 0x50
  public    static readonly System.String                   itemSelectedVariantUssClassName  // static @ 0x58
  public    static readonly System.String                   itemAlternativeBackgroundUssClassName  // static @ 0x60
  public    static readonly System.String                   listScrollViewUssClassName  // static @ 0x68
  private   static readonly System.String                   backgroundFillUssClassName  // static @ 0x70
  private           UnityEngine.Vector3             m_TouchDownPosition  // 0x498
PROPERTIES:
  itemsSource  get=0x09EE9A00  set=0x09EE9CF4
  contentContainer  get=0x01002730
  selectionType  get=0x03D88EC0  set=0x09EE9D88
  selectedItems  get=0x09EE9B1C
  selectedIndex  get=0x09EE9AB4  set=0x09EE77FC
  selectedIndices  get=0x09EE9AFC
  selectedIds  get=0x09EE9A94
  activeItems  get=0x09EE999C
  scrollView  get=0x03D55F00
  dragger  get=0x03D57420
  virtualizationController  get=0x09EE9B8C
  viewController  get=0x03D55F40
  showBorder  set=0x09EE9E08
  reorderable  get=0x09EE9A24  set=0x09EE9D24
  horizontalScrollingEnabled  set=0x09EE9C90
  showAlternatingRowBackgrounds  get=0x03D88ED0  set=0x09EE9DF0
  virtualizationMethod  get=0x03D88EE0  set=0x09EE9E7C
  fixedItemHeight  get=0x03D88EA0  set=0x09EE9B94
  lastHeight  get=0x03D88EB0
METHODS:
  RVA=0x09EE6478  token=0x6000838  System.Boolean HasCanStartDrag()
  RVA=0x09EE7804  token=0x6000839  System.Boolean RaiseCanStartDrag(UnityEngine.UIElements.ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids)
  RVA=0x09EE79B0  token=0x600083A  UnityEngine.UIElements.StartDragArgs RaiseSetupDragAndDrop(UnityEngine.UIElements.ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids, UnityEngine.UIElements.StartDragArgs args)
  RVA=0x09EE7928  token=0x600083B  UnityEngine.UIElements.DragVisualMode RaiseHandleDragAndDrop(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs)
  RVA=0x09EE78A0  token=0x600083C  UnityEngine.UIElements.DragVisualMode RaiseDrop(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs)
  RVA=0x09EE84C4  token=0x600084C  System.Single ResolveItemHeight(System.Single height)
  RVA=0x09EE5AEC  token=0x6000858  System.Void CreateVirtualizationController()
  RVA=0x09EE6354  token=0x6000859  UnityEngine.UIElements.CollectionVirtualizationController GetOrCreateVirtualizationController()
  RVA=-1  // generic def  token=0x600085A  System.Void CreateVirtualizationController()
  RVA=0x09EE62E8  token=0x600085B  UnityEngine.UIElements.CollectionViewController GetOrCreateViewController()
  RVA=-1  // abstract  token=0x600085C  UnityEngine.UIElements.CollectionViewController CreateViewController()
  RVA=0x09EE8BDC  token=0x600085D  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  RVA=0x09EE5A8C  token=0x600085E  UnityEngine.UIElements.ListViewDragger CreateDragger()
  RVA=0x09EE64AC  token=0x600085F  System.Void InitializeDragAndDropController(System.Boolean enableReordering)
  RVA=-1  // abstract  token=0x6000860  UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
  RVA=0x09EE92DC  token=0x6000861  System.Void .ctor()
  RVA=0x09EE9904  token=0x6000862  System.Void .ctor(System.Collections.IList itemsSource, System.Single itemHeight)
  RVA=0x09EE638C  token=0x6000863  UnityEngine.UIElements.VisualElement GetRootElementForId(System.Int32 id)
  RVA=0x09EE6484  token=0x6000864  System.Boolean HasValidDataAndBindings()
  RVA=0x09EE6F90  token=0x6000865  System.Void OnItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex)
  RVA=0x09EE6FBC  token=0x6000866  System.Void OnItemsSourceChanged()
  RVA=0x09EE7BEC  token=0x6000867  System.Void RefreshItems()
  RVA=0x09EE7AA0  token=0x6000868  System.Void Rebuild()
  RVA=0x09EE8514  token=0x6000869  System.Void ScheduleRebuild()
  RVA=0x09EE7D54  token=0x600086A  System.Void RefreshSelection()
  RVA=0x09EE738C  token=0x600086B  System.Void PostRefresh()
  RVA=0x09EE863C  token=0x600086C  System.Void ScrollToItem(System.Int32 index)
  RVA=0x09EE85D0  token=0x600086D  System.Void ScrollToItemById(System.Int32 id)
  RVA=0x09EE7238  token=0x600086E  System.Void OnScroll(UnityEngine.Vector2 offset)
  RVA=0x09EE8450  token=0x600086F  System.Void Resize(UnityEngine.Vector2 size)
  RVA=0x09EE6890  token=0x6000870  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09EE6CDC  token=0x6000871  System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09EE5378  token=0x6000872  System.Boolean Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, System.Boolean shiftKey, System.Boolean altKey)
  RVA=0x09EE5794  token=0x6000873  System.Void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent)
  RVA=0x03D4E3A0  token=0x6000874  System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altKey)
  RVA=0x09EE70FC  token=0x6000875  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  RVA=0x09EE7038  token=0x6000876  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  RVA=0x09EE6FD0  token=0x6000877  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  RVA=0x09EE7174  token=0x6000878  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EE7444  token=0x6000879  System.Void ProcessPointerDown(UnityEngine.UIElements.IPointerEvent evt)
  RVA=0x09EE7594  token=0x600087A  System.Void ProcessPointerUp(UnityEngine.UIElements.IPointerEvent evt)
  RVA=0x09EE5C40  token=0x600087B  System.Void DoSelect(UnityEngine.Vector2 localPosition, System.Int32 clickCount, System.Boolean actionKey, System.Boolean shiftKey)
  RVA=0x09EE5B28  token=0x600087C  System.Void DoRangeSelection(System.Int32 rangeSelectionFinalIndex)
  RVA=0x09EE77FC  token=0x600087D  System.Void ProcessSingleClick(System.Int32 clickedIndex)
  RVA=0x09EE868C  token=0x600087E  System.Void SelectAll()
  RVA=0x09EE5188  token=0x600087F  System.Void AddToSelection(System.Int32 index)
  RVA=0x09EE51F8  token=0x6000880  System.Void AddToSelection(System.Collections.Generic.IList<System.Int32> indexes)
  RVA=0x09EE4F5C  token=0x6000881  System.Void AddToSelectionWithoutValidation(System.Int32 index)
  RVA=0x09EE8404  token=0x6000882  System.Void RemoveFromSelection(System.Int32 index)
  RVA=0x09EE8248  token=0x6000883  System.Void RemoveFromSelectionWithoutValidation(System.Int32 index)
  RVA=0x09EE8B58  token=0x6000884  System.Void SetSelection(System.Int32 index)
  RVA=0x09EE8B4C  token=0x6000885  System.Void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09EE8B40  token=0x6000886  System.Void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09EE8920  token=0x6000887  System.Void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Boolean sendNotification)
  RVA=0x09EE659C  token=0x6000888  System.Boolean MatchesExistingSelection(System.Collections.Generic.IEnumerable<System.Int32> indices)
  RVA=0x09EE6818  token=0x6000889  System.Void NotifyOfSelectionChange()
  RVA=0x09EE5A38  token=0x600088A  System.Void ClearSelection()
  RVA=0x09EE58DC  token=0x600088B  System.Void ClearSelectionWithoutValidation()
  RVA=0x09EE734C  token=0x600088C  System.Void OnViewDataReady()
  RVA=0x09EE6064  token=0x600088D  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x09EE7290  token=0x600088E  System.Void OnSizeChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EE6BDC  token=0x600088F  System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  RVA=0x0350B670  token=0x6000890  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x09EE8DDC  token=0x6000891  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x09EE8E18  token=0x6000892  System.Void .cctor()
  RVA=0x09EE8DC8  token=0x6000893  System.Void <.ctor>b__160_0(System.Single v)
  RVA=0x09EE8D80  token=0x6000894  System.Void <RefreshSelection>g__NotifyIfChanged|173_0(UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass173_0& )
  RVA=0x09EE8CD0  token=0x6000895  System.Void <Apply>g__HandleSelectionAndScroll|184_0(System.Int32 index, UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass184_0& )
END_CLASS

CLASS: UnityEngine.UIElements.IBindable
TYPE:  interface
TOKEN: 0x2000117
FIELDS:
PROPERTIES:
  binding  get=-1  // abstract
  bindingPath  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IBinding
TYPE:  interface
TOKEN: 0x2000118
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60008B9  System.Void PreUpdate()
  RVA=-1  // abstract  token=0x60008BA  System.Void Update()
  RVA=-1  // abstract  token=0x60008BB  System.Void Release()
END_CLASS

CLASS: UnityEngine.UIElements.Box
TYPE:  class
TOKEN: 0x2000119
SIZE:  0x3C0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
METHODS:
  RVA=0x09EE9F10  token=0x60008BC  System.Void .ctor()
  RVA=0x09EE9EB4  token=0x60008BD  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Button
TYPE:  class
TOKEN: 0x200011B
SIZE:  0x490
EXTENDS: UnityEngine.UIElements.TextElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  private           UnityEngine.UIElements.Clickablem_Clickable  // 0x488
  private   static readonly System.String                   NonEmptyString  // static @ 0x8
PROPERTIES:
  clickable  get=0x03D88EF0  set=0x09EEA618
METHODS:
  RVA=0x09EEA60C  token=0x60008C1  System.Void .ctor()
  RVA=0x09EEA474  token=0x60008C2  System.Void .ctor(System.Action clickEvent)
  RVA=0x09EEA3A4  token=0x60008C3  System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt)
  RVA=0x09EEA30C  token=0x60008C4  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=0x09EEA260  token=0x60008C5  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09EEA3DC  token=0x60008C6  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ButtonStripField
TYPE:  class
TOKEN: 0x200011E
SIZE:  0x420
EXTENDS: UnityEngine.UIElements.BaseField`1
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.Button>m_Buttons  // 0x418
PROPERTIES:
  buttons  get=0x09EEA180
METHODS:
  RVA=0x09EEA0D0  token=0x60008CA  System.Void .ctor()
  RVA=0x09EEA04C  token=0x60008CB  System.Void SetValueWithoutNotify(System.Int32 newValue)
  RVA=0x09EE9F84  token=0x60008CC  System.Void RefreshButtonsState()
END_CLASS

CLASS: UnityEngine.UIElements.DropdownField
TYPE:  class
TOKEN: 0x2000121
SIZE:  0x450
EXTENDS: UnityEngine.UIElements.BaseField`1
FIELDS:
  private           System.Collections.Generic.List<System.String>m_Choices  // 0x418
  private           UnityEngine.UIElements.TextElementm_TextElement  // 0x420
  private           UnityEngine.UIElements.VisualElementm_ArrowElement  // 0x428
  private           System.Func<System.String,System.String>m_FormatSelectedValueCallback  // 0x430
  private           System.Func<System.String,System.String>m_FormatListItemCallback  // 0x438
  private           System.Func<UnityEngine.UIElements.IGenericMenu>createMenuCallback  // 0x440
  private           System.Int32                    m_Index  // 0x448
  private   static readonly System.String                   ussClassNameBasePopupField  // static @ 0x0
  private   static readonly System.String                   textUssClassNameBasePopupField  // static @ 0x8
  private   static readonly System.String                   arrowUssClassNameBasePopupField  // static @ 0x10
  private   static readonly System.String                   labelUssClassNameBasePopupField  // static @ 0x18
  private   static readonly System.String                   inputUssClassNameBasePopupField  // static @ 0x20
  private   static readonly System.String                   ussClassNamePopupField  // static @ 0x28
  private   static readonly System.String                   labelUssClassNamePopupField  // static @ 0x30
  private   static readonly System.String                   inputUssClassNamePopupField  // static @ 0x38
PROPERTIES:
  textElement  get=0x03D88F00
  index  set=0x09EEBBCC
  choices  set=0x09EEBB6C
  value  get=0x09EEBB30  set=0x09EEBC54
METHODS:
  RVA=0x09EEB23C  token=0x60008D0  System.String GetValueToDisplay()
  RVA=0x09EEB194  token=0x60008D1  System.String GetListItemToDisplay(System.String value)
  RVA=0x09EEBB24  token=0x60008D3  System.Void .ctor()
  RVA=0x09EEB810  token=0x60008D4  System.Void .ctor(System.String label)
  RVA=0x09EEAC1C  token=0x60008D5  System.Void AddMenuItems(UnityEngine.UIElements.IGenericMenu menu)
  RVA=0x09EEB030  token=0x60008D6  System.Void ChangeValueFromMenu(System.String menuItem)
  RVA=0x09EEB2C4  token=0x60008DA  System.Void SetValueWithoutNotify(System.String newValue)
  RVA=0x09EEB044  token=0x60008DB  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x09EEB380  token=0x60008DC  System.Void ShowMenu()
  RVA=0x09EEB4D0  token=0x60008DD  System.Void UpdateMixedValueContent()
  RVA=0x09EEB590  token=0x60008DE  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Foldout
TYPE:  class
TOKEN: 0x2000126
SIZE:  0x3E8
EXTENDS: UnityEngine.UIElements.BindableElement
IMPLEMENTS: UnityEngine.UIElements.INotifyValueChanged`1
FIELDS:
  private           UnityEngine.UIElements.Toggle   m_Toggle  // 0x3d0
  private           UnityEngine.UIElements.VisualElementm_Container  // 0x3d8
  private           System.Boolean                  m_Value  // 0x3e0
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   toggleUssClassName  // static @ 0x8
  public    static readonly System.String                   contentUssClassName  // static @ 0x10
  public    static readonly System.String                   inputUssClassName  // static @ 0x18
  public    static readonly System.String                   checkmarkUssClassName  // static @ 0x20
  public    static readonly System.String                   textUssClassName  // static @ 0x28
  private   static readonly System.String                   ussFoldoutDepthClassName  // static @ 0x30
  private   static readonly System.Int32                    ussFoldoutMaxDepth  // static @ 0x38
PROPERTIES:
  toggle  get=0x03D55EC0
  contentContainer  get=0x03D55ED0
  text  set=0x09EEC53C
  value  get=0x03D88F10  set=0x09EEC638
METHODS:
  RVA=0x09EEBE88  token=0x60008EB  System.Void SetValueWithoutNotify(System.Boolean newValue)
  RVA=0x09EEBE50  token=0x60008EC  System.Void OnViewDataReady()
  RVA=0x09EEC1E4  token=0x60008ED  System.Void .ctor()
  RVA=0x09EEBCD0  token=0x60008EE  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09EEBF74  token=0x60008EF  System.Void .cctor()
  RVA=0x09EEBF24  token=0x60008F0  System.Void <.ctor>b__25_0(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
END_CLASS

CLASS: UnityEngine.UIElements.IGenericMenu
TYPE:  interface
TOKEN: 0x2000129
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60008F4  System.Void AddItem(System.String itemName, System.Boolean isChecked, System.Action action)
  RVA=-1  // abstract  token=0x60008F5  System.Void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, System.Boolean anchored)
END_CLASS

CLASS: UnityEngine.UIElements.GenericDropdownMenu
TYPE:  class
TOKEN: 0x200012A
SIZE:  0x60
IMPLEMENTS: UnityEngine.UIElements.IGenericMenu
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   itemUssClassName  // static @ 0x8
  public    static readonly System.String                   labelUssClassName  // static @ 0x10
  public    static readonly System.String                   containerInnerUssClassName  // static @ 0x18
  public    static readonly System.String                   containerOuterUssClassName  // static @ 0x20
  public    static readonly System.String                   checkmarkUssClassName  // static @ 0x28
  public    static readonly System.String                   separatorUssClassName  // static @ 0x30
  private           System.Collections.Generic.List<UnityEngine.UIElements.GenericDropdownMenu.MenuItem>m_Items  // 0x10
  private           UnityEngine.UIElements.VisualElementm_MenuContainer  // 0x18
  private           UnityEngine.UIElements.VisualElementm_OuterContainer  // 0x20
  private           UnityEngine.UIElements.ScrollViewm_ScrollView  // 0x28
  private           UnityEngine.UIElements.VisualElementm_PanelRootVisualContainer  // 0x30
  private           UnityEngine.UIElements.VisualElementm_TargetElement  // 0x38
  private           UnityEngine.Rect                m_DesiredRect  // 0x40
  private           UnityEngine.UIElements.KeyboardNavigationManipulatorm_NavigationManipulator  // 0x50
  private           UnityEngine.Vector2             m_MousePosition  // 0x58
PROPERTIES:
  contentContainer  get=0x09EEEB0C
METHODS:
  RVA=0x09EEE7E0  token=0x60008F7  System.Void .ctor()
  RVA=0x09EED804  token=0x60008F8  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09EEDBC4  token=0x60008F9  System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09EED724  token=0x60008FA  System.Void Hide()
  RVA=0x09EECCC4  token=0x60008FB  System.Void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent)
  RVA=0x09EECB1C  token=0x60008FC  System.Boolean Apply(UnityEngine.UIElements.KeyboardNavigationOperation op)
  RVA=0x09EEDFC4  token=0x60008FD  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  RVA=0x09EEE0EC  token=0x60008FE  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  RVA=0x09EEE214  token=0x60008FF  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EEDEEC  token=0x6000900  System.Void OnFocusOut(UnityEngine.UIElements.FocusOutEvent evt)
  RVA=0x09EEDFBC  token=0x6000901  System.Void OnParentResized(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EEE474  token=0x6000902  System.Void UpdateSelection(UnityEngine.UIElements.VisualElement target)
  RVA=0x09EECD00  token=0x6000903  System.Void ChangeSelectedIndex(System.Int32 newIndex, System.Int32 previousIndex)
  RVA=0x09EED69C  token=0x6000904  System.Int32 GetSelectedIndex()
  RVA=0x09EEC744  token=0x6000905  System.Void AddItem(System.String itemName, System.Boolean isChecked, System.Action action)
  RVA=0x09EECA70  token=0x6000906  System.Void AddSeparator(System.String path)
  RVA=0x09EEC77C  token=0x6000907  UnityEngine.UIElements.GenericDropdownMenu.MenuItem AddItem(System.String itemName, System.Boolean isChecked, System.Boolean isEnabled, System.Object data)
  RVA=0x09EECE1C  token=0x6000908  System.Void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, System.Boolean anchored)
  RVA=0x09EEDFBC  token=0x6000909  System.Void OnTargetElementDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09EEDBBC  token=0x600090A  System.Void OnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EED2C8  token=0x600090B  System.Void EnsureVisibilityInParent()
  RVA=0x09EEE584  token=0x600090C  System.Void .cctor()
  RVA=0x09EEE344  token=0x600090D  System.Void <Apply>g__UpdateSelectionDown|27_0(System.Int32 newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass27_0& )
  RVA=0x09EEE3E4  token=0x600090E  System.Void <Apply>g__UpdateSelectionUp|27_1(System.Int32 newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass27_0& )
END_CLASS

CLASS: UnityEngine.UIElements.GroupBox
TYPE:  class
TOKEN: 0x200012D
SIZE:  0x3D8
EXTENDS: UnityEngine.UIElements.BindableElement
IMPLEMENTS: UnityEngine.UIElements.IGroupBox
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  private           UnityEngine.UIElements.Label    m_TitleLabel  // 0x3d0
PROPERTIES:
  text  set=0x09EF41D0
METHODS:
  RVA=0x09EF41C4  token=0x6000911  System.Void .ctor()
  RVA=0x09EF414C  token=0x6000912  System.Void .ctor(System.String text)
  RVA=0x09EF409C  token=0x6000913  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.HelpBoxMessageType
TYPE:  sealed struct
TOKEN: 0x2000130
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeNone  // const
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeInfo  // const
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeWarning  // const
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeError  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.HelpBox
TYPE:  class
TOKEN: 0x2000131
SIZE:  0x3E0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   iconUssClassName  // static @ 0x10
  public    static readonly System.String                   iconInfoUssClassName  // static @ 0x18
  public    static readonly System.String                   iconwarningUssClassName  // static @ 0x20
  public    static readonly System.String                   iconErrorUssClassName  // static @ 0x28
  private           UnityEngine.UIElements.HelpBoxMessageTypem_HelpBoxMessageType  // 0x3c0
  private           UnityEngine.UIElements.VisualElementm_Icon  // 0x3c8
  private           System.String                   m_IconClass  // 0x3d0
  private           UnityEngine.UIElements.Label    m_Label  // 0x3d8
PROPERTIES:
  text  set=0x09EF486C
  messageType  set=0x09EF484C
METHODS:
  RVA=0x09EF4678  token=0x6000919  System.Void .ctor()
  RVA=0x09EF46C4  token=0x600091A  System.Void .ctor(System.String text, UnityEngine.UIElements.HelpBoxMessageType messageType)
  RVA=0x09EF4304  token=0x600091B  System.String GetIconClass(UnityEngine.UIElements.HelpBoxMessageType messageType)
  RVA=0x09EF43AC  token=0x600091C  System.Void UpdateIcon(UnityEngine.UIElements.HelpBoxMessageType messageType)
  RVA=0x09EF4470  token=0x600091D  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Image
TYPE:  class
TOKEN: 0x2000134
SIZE:  0x408
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  private           UnityEngine.ScaleMode           m_ScaleMode  // 0x3c0
  private           UnityEngine.Texture             m_Image  // 0x3c8
  private           UnityEngine.Sprite              m_Sprite  // 0x3d0
  private           UnityEngine.UIElements.VectorImagem_VectorImage  // 0x3d8
  private           UnityEngine.Rect                m_UV  // 0x3e0
  private           UnityEngine.Color               m_TintColor  // 0x3f0
  private           System.Boolean                  m_ImageIsInline  // 0x400
  private           System.Boolean                  m_ScaleModeIsInline  // 0x401
  private           System.Boolean                  m_TintColorIsInline  // 0x402
  public    static readonly System.String                   ussClassName  // static @ 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D>s_ImageProperty  // static @ 0x8
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite>s_SpriteProperty  // static @ 0x10
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage>s_VectorImageProperty  // static @ 0x18
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.String>s_ScaleModeProperty  // static @ 0x20
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color>s_TintColorProperty  // static @ 0x28
PROPERTIES:
  image  get=0x03D88F50  set=0x09EF59F8
  sprite  get=0x03D88E30  set=0x09EF5BF8
  vectorImage  get=0x03D88DF0  set=0x09EF5DC4
  sourceRect  get=0x09EF59CC
  uv  get=0x03D88F80
  scaleMode  get=0x03D88F60
  tintColor  get=0x03D88F70
METHODS:
  RVA=0x09EF5824  token=0x600092B  System.Void .ctor()
  RVA=0x09EF4C50  token=0x600092C  UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Texture texture)
  RVA=0x09EF4CF0  token=0x600092D  UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Sprite sprite)
  RVA=0x09EF4890  token=0x600092E  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  RVA=0x09EF51E8  token=0x600092F  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  RVA=0x09EF4DF0  token=0x6000930  System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  RVA=0x09EF55D0  token=0x6000931  System.Void SetScaleMode(UnityEngine.ScaleMode mode)
  RVA=0x09EF4AC0  token=0x6000932  UnityEngine.Rect GetSourceRect()
  RVA=0x09EF55F4  token=0x6000933  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.INotifyValueChanged`1
TYPE:  interface
TOKEN: 0x2000137
FIELDS:
PROPERTIES:
  value  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000938  System.Void SetValueWithoutNotify(T newValue)
END_CLASS

CLASS: UnityEngine.UIElements.INotifyValueChangedExtensions
TYPE:  static class
TOKEN: 0x2000138
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000939  System.Boolean RegisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback)
  RVA=-1  // generic def  token=0x600093A  System.Boolean UnregisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback)
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardTextEditorEventHandler
TYPE:  class
TOKEN: 0x2000139
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.TextEditorEventHandler
FIELDS:
  private           System.Boolean                  m_Changed  // 0x20
  private           System.Boolean                  m_Dragged  // 0x21
  private           System.Boolean                  m_DragToPosition  // 0x22
  private           System.Boolean                  m_SelectAllOnMouseUp  // 0x23
  private           System.String                   m_PreDrawCursorText  // 0x28
  private           System.Boolean                  m_IsClicking  // 0x30
  private           UnityEngine.Vector2             m_ClickStartPosition  // 0x34
  private   readonly UnityEngine.Event               m_ImguiEvent  // 0x40
PROPERTIES:
  isClicking  get=0x03D4EF60  set=0x09EF7770
METHODS:
  RVA=0x09EF76E0  token=0x600093D  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField)
  RVA=0x09EF5FC4  token=0x600093E  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x09EF66F8  token=0x600093F  System.Void OnFocus(UnityEngine.UIElements.FocusEvent _)
  RVA=0x09EF63E4  token=0x6000940  System.Void OnBlur(UnityEngine.UIElements.BlurEvent _)
  RVA=0x09EF6B9C  token=0x6000941  System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt)
  RVA=0x09EF702C  token=0x6000942  System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt)
  RVA=0x09EF6F20  token=0x6000943  System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt)
  RVA=0x09EF7580  token=0x6000944  System.Void ProcessDragMove(UnityEngine.UIElements.MouseMoveEvent evt)
  RVA=0x09EF63A0  token=0x6000945  System.Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2 start, UnityEngine.Vector2 current)
  RVA=0x09EF67D4  token=0x6000946  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  RVA=0x09EF7114  token=0x6000947  System.Void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent evt)
  RVA=0x09EF63F0  token=0x6000948  System.Void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent evt)
  RVA=0x09EF72F8  token=0x6000949  System.Void PreDrawCursor(System.String newText)
  RVA=0x09EF72D0  token=0x600094A  System.Void PostDrawCursor()
END_CLASS

CLASS: UnityEngine.UIElements.Label
TYPE:  class
TOKEN: 0x200013A
SIZE:  0x488
EXTENDS: UnityEngine.UIElements.TextElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
METHODS:
  RVA=0x09EF7888  token=0x600094B  System.Void .ctor()
  RVA=0x09EF77F8  token=0x600094C  System.Void .ctor(System.String text)
  RVA=0x09EF779C  token=0x600094D  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ListView
TYPE:  class
TOKEN: 0x200013D
SIZE:  0x558
EXTENDS: UnityEngine.UIElements.BaseListView
FIELDS:
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeItem  // 0x538
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_BindItem  // 0x540
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32><unbindItem>k__BackingField  // 0x548
  private           System.Action<UnityEngine.UIElements.VisualElement><destroyItem>k__BackingField  // 0x550
PROPERTIES:
  makeItem  get=0x03D6CB00
  bindItem  get=0x03D6CB10
  unbindItem  get=0x03D6CB20
  destroyItem  get=0x03D6CB30
METHODS:
  RVA=0x09EF790C  token=0x6000954  System.Boolean HasValidDataAndBindings()
  RVA=0x09EF78D0  token=0x6000955  UnityEngine.UIElements.CollectionViewController CreateViewController()
  RVA=0x09EF7948  token=0x6000956  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MinMaxSlider
TYPE:  class
TOKEN: 0x2000140
SIZE:  0x478
EXTENDS: UnityEngine.UIElements.BaseField`1
FIELDS:
  private           UnityEngine.UIElements.VisualElement<dragElement>k__BackingField  // 0x418
  private           UnityEngine.UIElements.VisualElement<dragMinThumb>k__BackingField  // 0x420
  private           UnityEngine.UIElements.VisualElement<dragMaxThumb>k__BackingField  // 0x428
  private           UnityEngine.UIElements.ClampedDragger<System.Single><clampedDragger>k__BackingField  // 0x430
  private           UnityEngine.Vector2             m_DragElementStartPos  // 0x438
  private           UnityEngine.Vector2             m_ValueStartPos  // 0x440
  private           UnityEngine.Rect                m_DragMinThumbRect  // 0x448
  private           UnityEngine.Rect                m_DragMaxThumbRect  // 0x458
  private           UnityEngine.UIElements.MinMaxSlider.DragStatem_DragState  // 0x468
  private           System.Single                   m_MinLimit  // 0x46c
  private           System.Single                   m_MaxLimit  // 0x470
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   inputUssClassName  // static @ 0x10
  public    static readonly System.String                   trackerUssClassName  // static @ 0x18
  public    static readonly System.String                   draggerUssClassName  // static @ 0x20
  public    static readonly System.String                   minThumbUssClassName  // static @ 0x28
  public    static readonly System.String                   maxThumbUssClassName  // static @ 0x30
PROPERTIES:
  dragElement  get=0x03D57150  set=0x058B3D1C
  dragMinThumb  get=0x03D57320  set=0x058B4000
  dragMaxThumb  get=0x03D55F30  set=0x058B3EAC
  clampedDragger  get=0x03D55F10  set=0x058B3E5C
  minValue  get=0x09EF92DC  set=0x09EF95B0
  maxValue  get=0x09EF92B8  set=0x09EF9540
  value  get=0x09EF9300  set=0x09EF9620
  lowLimit  get=0x03D88FC0  set=0x09EF9444
  highLimit  get=0x03D88FB0  set=0x09EF9344
METHODS:
  RVA=0x09EF815C  token=0x6000967  System.Void SetValueWithoutNotify(UnityEngine.Vector2 newValue)
  RVA=0x09EF8C88  token=0x600096C  System.Void .ctor()
  RVA=0x09EF8CC8  token=0x600096D  System.Void .ctor(System.String label, System.Single minValue, System.Single maxValue, System.Single minLimit, System.Single maxLimit)
  RVA=0x09EF79A8  token=0x600096E  UnityEngine.Vector2 ClampValues(UnityEngine.Vector2 valueToClamp)
  RVA=0x09EF89A8  token=0x600096F  System.Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EF81D8  token=0x6000970  System.Void UpdateDragElementPosition()
  RVA=0x03D88F90  token=0x6000971  System.Single SliderLerpUnclamped(System.Single a, System.Single b, System.Single interpolant)
  RVA=0x09EF81C4  token=0x6000972  System.Single SliderNormalizeValue(System.Single currentValue, System.Single lowerValue, System.Single higherValue)
  RVA=0x09EF7C38  token=0x6000973  System.Single ComputeValueFromPosition(System.Single positionToConvert)
  RVA=0x09EF7D1C  token=0x6000974  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x09EF80CC  token=0x6000975  System.Void SetSliderValueFromDrag()
  RVA=0x09EF7DD4  token=0x6000976  System.Void SetSliderValueFromClick()
  RVA=0x09EF7A28  token=0x6000977  System.Void ComputeValueDragStateNoThumb(System.Single lowLimitPosition, System.Single highLimitPosition, System.Single dragElementPos)
  RVA=0x09EF7AC4  token=0x6000978  System.Void ComputeValueFromDraggingThumb(System.Single dragElementStartPos, System.Single dragElementEndPos)
  RVA=0x0350B670  token=0x6000979  System.Void UpdateMixedValueContent()
  RVA=0x09EF8A2C  token=0x600097A  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PopupWindow
TYPE:  class
TOKEN: 0x2000144
SIZE:  0x490
EXTENDS: UnityEngine.UIElements.TextElement
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x488
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   contentUssClassName  // static @ 0x8
PROPERTIES:
  contentContainer  get=0x03D88EF0
METHODS:
  RVA=0x09EF972C  token=0x600097E  System.Void .ctor()
  RVA=0x09EF967C  token=0x6000980  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.AbstractProgressBar
TYPE:  abstract class
TOKEN: 0x2000147
SIZE:  0x3F8
EXTENDS: UnityEngine.UIElements.BindableElement
IMPLEMENTS: UnityEngine.UIElements.INotifyValueChanged`1
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   containerUssClassName  // static @ 0x8
  public    static readonly System.String                   titleUssClassName  // static @ 0x10
  public    static readonly System.String                   titleContainerUssClassName  // static @ 0x18
  public    static readonly System.String                   progressUssClassName  // static @ 0x20
  public    static readonly System.String                   backgroundUssClassName  // static @ 0x28
  private   readonly UnityEngine.UIElements.VisualElementm_Background  // 0x3d0
  private   readonly UnityEngine.UIElements.VisualElementm_Progress  // 0x3d8
  private   readonly UnityEngine.UIElements.Label    m_Title  // 0x3e0
  private           System.Single                   m_LowValue  // 0x3e8
  private           System.Single                   m_HighValue  // 0x3ec
  private           System.Single                   m_Value  // 0x3f0
PROPERTIES:
  title  set=0x09EF3F0C
  lowValue  get=0x03D88F30  set=0x09EF3EF4
  highValue  get=0x03D88F20  set=0x09EF3EDC
  value  get=0x03D88F40  set=0x09EF3F30
METHODS:
  RVA=0x09EF3BA8  token=0x6000988  System.Void .ctor()
  RVA=0x09EF38E0  token=0x6000989  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  RVA=0x09EF3994  token=0x600098C  System.Void SetValueWithoutNotify(System.Single newValue)
  RVA=0x09EF38F4  token=0x600098D  System.Void SetProgress(System.Single p)
  RVA=0x09EF3838  token=0x600098E  System.Single CalculateProgressWidth(System.Single width)
  RVA=0x09EF39A4  token=0x600098F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ProgressBar
TYPE:  class
TOKEN: 0x2000149
SIZE:  0x3F8
EXTENDS: UnityEngine.UIElements.AbstractProgressBar
FIELDS:
METHODS:
  RVA=0x09EF9858  token=0x6000992  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.RadioButton
TYPE:  class
TOKEN: 0x200014B
SIZE:  0x440
EXTENDS: UnityEngine.UIElements.BaseBoolField
IMPLEMENTS: UnityEngine.UIElements.IGroupBoxOption
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   inputUssClassName  // static @ 0x10
  public    static readonly System.String                   checkmarkBackgroundUssClassName  // static @ 0x18
  public    static readonly System.String                   checkmarkUssClassName  // static @ 0x20
  public    static readonly System.String                   textUssClassName  // static @ 0x28
  private           UnityEngine.UIElements.VisualElementm_CheckmarkBackground  // 0x438
PROPERTIES:
  value  get=0x09EFA70C  set=0x09EFA748
METHODS:
  RVA=0x09EFA4FC  token=0x6000996  System.Void .ctor()
  RVA=0x09EFA508  token=0x6000997  System.Void .ctor(System.String label)
  RVA=0x09EFA10C  token=0x6000998  System.Void InitLabel()
  RVA=0x09EFA1B0  token=0x6000999  System.Void ToggleValue()
  RVA=0x09EFA17C  token=0x600099A  System.Void SetSelected(System.Boolean selected)
  RVA=0x09EFA190  token=0x600099B  System.Void SetValueWithoutNotify(System.Boolean newValue)
  RVA=0x09EFA1E0  token=0x600099C  System.Void UpdateCheckmark()
  RVA=0x09EFA260  token=0x600099D  System.Void UpdateMixedValueContent()
  RVA=0x09EFA2F8  token=0x600099E  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.RadioButtonGroup
TYPE:  class
TOKEN: 0x200014E
SIZE:  0x430
EXTENDS: UnityEngine.UIElements.BaseField`1
IMPLEMENTS: UnityEngine.UIElements.IGroupBox
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  private           System.Collections.Generic.IEnumerable<System.String>m_Choices  // 0x418
  private           System.Collections.Generic.List<UnityEngine.UIElements.RadioButton>m_RadioButtons  // 0x420
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>>m_RadioButtonValueChangedCallback  // 0x428
PROPERTIES:
  choices  set=0x09EF9D88
METHODS:
  RVA=0x09EF9D78  token=0x60009A3  System.Void .ctor()
  RVA=0x09EF9BDC  token=0x60009A4  System.Void .ctor(System.String label, System.Collections.Generic.List<System.String> radioButtonChoices)
  RVA=0x09EF98A4  token=0x60009A5  System.Void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
  RVA=0x09EF9960  token=0x60009A6  System.Void SetValueWithoutNotify(System.Int32 newValue)
  RVA=0x09EF99B0  token=0x60009A7  System.Void UpdateRadioButtons()
  RVA=0x09EF9B80  token=0x60009A8  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.RepeatButton
TYPE:  class
TOKEN: 0x2000151
SIZE:  0x490
EXTENDS: UnityEngine.UIElements.TextElement
FIELDS:
  private           UnityEngine.UIElements.Clickablem_Clickable  // 0x488
  public    static readonly System.String                   ussClassName  // static @ 0x0
METHODS:
  RVA=0x09EFA988  token=0x60009AC  System.Void .ctor()
  RVA=0x09EFA930  token=0x60009AD  System.Void .ctor(System.Action clickEvent, System.Int64 delay, System.Int64 interval)
  RVA=0x09EFA80C  token=0x60009AE  System.Void SetAction(System.Action clickEvent, System.Int64 delay, System.Int64 interval)
  RVA=0x09EFA7E8  token=0x60009AF  System.Void AddAction(System.Action clickEvent)
  RVA=0x09EFA8D4  token=0x60009B0  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Scroller
TYPE:  class
TOKEN: 0x2000154
SIZE:  0x3E0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  private           System.Action<System.Single>    valueChanged  // 0x3c0
  private           UnityEngine.UIElements.Slider   <slider>k__BackingField  // 0x3c8
  private           UnityEngine.UIElements.RepeatButton<lowButton>k__BackingField  // 0x3d0
  private           UnityEngine.UIElements.RepeatButton<highButton>k__BackingField  // 0x3d8
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   horizontalVariantUssClassName  // static @ 0x8
  public    static readonly System.String                   verticalVariantUssClassName  // static @ 0x10
  public    static readonly System.String                   sliderUssClassName  // static @ 0x18
  public    static readonly System.String                   lowButtonUssClassName  // static @ 0x20
  public    static readonly System.String                   highButtonUssClassName  // static @ 0x28
PROPERTIES:
  slider  get=0x03D56FF0  set=0x058B3B50
  lowButton  get=0x03D55EC0  set=0x058B40A0
  highButton  get=0x03D55ED0  set=0x058B3D30
  value  get=0x09F007F8  set=0x09F00AA0
  lowValue  get=0x09F007B0  set=0x09F00A48
  highValue  get=0x09F00768  set=0x09F009F0
  direction  set=0x09F008AC
EVENTS:
  valueChanged  add=add_valueChanged  remove=remove_valueChanged
METHODS:
  RVA=0x09F00290  token=0x60009C3  System.Void .ctor()
  RVA=0x09F002B8  token=0x60009C4  System.Void .ctor(System.Single lowValue, System.Single highValue, System.Action<System.Single> valueChanged, UnityEngine.UIElements.SliderDirection direction)
  RVA=0x09EFFDE4  token=0x60009C5  System.Void Adjust(System.Single factor)
  RVA=0x09EFFE58  token=0x60009C6  System.Void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<System.Single> evt)
  RVA=0x09F0007C  token=0x60009C7  System.Void ScrollPageUp()
  RVA=0x09EFFFAC  token=0x60009C8  System.Void ScrollPageDown()
  RVA=0x09EFFFBC  token=0x60009C9  System.Void ScrollPageUp(System.Single factor)
  RVA=0x09EFFEEC  token=0x60009CA  System.Void ScrollPageDown(System.Single factor)
  RVA=0x09F0008C  token=0x60009CB  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ScrollViewMode
TYPE:  sealed struct
TOKEN: 0x2000157
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollViewModeVertical  // const
  public    static  UnityEngine.UIElements.ScrollViewModeHorizontal  // const
  public    static  UnityEngine.UIElements.ScrollViewModeVerticalAndHorizontal  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ScrollerVisibility
TYPE:  sealed struct
TOKEN: 0x2000158
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollerVisibilityAuto  // const
  public    static  UnityEngine.UIElements.ScrollerVisibilityAlwaysVisible  // const
  public    static  UnityEngine.UIElements.ScrollerVisibilityHidden  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ScrollView
TYPE:  class
TOKEN: 0x2000159
SIZE:  0x4B0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  private           System.Int32                    m_FirstLayoutPass  // 0x3c0
  private           UnityEngine.UIElements.ScrollerVisibilitym_HorizontalScrollerVisibility  // 0x3c4
  private           UnityEngine.UIElements.ScrollerVisibilitym_VerticalScrollerVisibility  // 0x3c8
  private           UnityEngine.UIElements.VisualElementm_AttachedRootVisualContainer  // 0x3d0
  private           System.Single                   m_SingleLineHeight  // 0x3d8
  private           System.Boolean                  m_MouseWheelScrollSizeIsInline  // 0x3dc
  private           System.Single                   m_HorizontalPageSize  // 0x3e0
  private           System.Single                   m_VerticalPageSize  // 0x3e4
  private           System.Single                   m_MouseWheelScrollSize  // 0x3e8
  private   static readonly System.Single                   k_DefaultScrollDecelerationRate  // static @ 0x0
  private           System.Single                   m_ScrollDecelerationRate  // 0x3ec
  private           System.Single                   k_ScaledPixelsPerPointMultiplier  // 0x3f0
  private           System.Single                   k_TouchScrollInertiaBaseTimeInterval  // 0x3f4
  private   static readonly System.Single                   k_DefaultElasticity  // static @ 0x4
  private           System.Single                   m_Elasticity  // 0x3f8
  private           UnityEngine.UIElements.ScrollView.TouchScrollBehaviorm_TouchScrollBehavior  // 0x3fc
  private           UnityEngine.UIElements.ScrollView.NestedInteractionKindm_NestedInteractionKind  // 0x400
  private   static readonly System.Int64                    k_DefaultElasticAnimationInterval  // static @ 0x8
  private           System.Int64                    m_ElasticAnimationIntervalMs  // 0x408
  private   readonly UnityEngine.UIElements.VisualElement<contentViewport>k__BackingField  // 0x410
  private   readonly UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField  // 0x418
  private   readonly UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField  // 0x420
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x428
  private           UnityEngine.UIElements.VisualElementm_ContentAndVerticalScrollContainer  // 0x430
  private           System.Single                   previousVerticalTouchScrollTimeStamp  // 0x438
  private           System.Single                   previousHorizontalTouchScrollTimeStamp  // 0x43c
  private           System.Single                   elapsedTimeSinceLastVerticalTouchScroll  // 0x440
  private           System.Single                   elapsedTimeSinceLastHorizontalTouchScroll  // 0x444
  public    static readonly System.String                   ussClassName  // static @ 0x10
  public    static readonly System.String                   viewportUssClassName  // static @ 0x18
  public    static readonly System.String                   horizontalVariantViewportUssClassName  // static @ 0x20
  public    static readonly System.String                   verticalVariantViewportUssClassName  // static @ 0x28
  public    static readonly System.String                   verticalHorizontalVariantViewportUssClassName  // static @ 0x30
  public    static readonly System.String                   contentAndVerticalScrollUssClassName  // static @ 0x38
  public    static readonly System.String                   contentUssClassName  // static @ 0x40
  public    static readonly System.String                   horizontalVariantContentUssClassName  // static @ 0x48
  public    static readonly System.String                   verticalVariantContentUssClassName  // static @ 0x50
  public    static readonly System.String                   verticalHorizontalVariantContentUssClassName  // static @ 0x58
  public    static readonly System.String                   hScrollerUssClassName  // static @ 0x60
  public    static readonly System.String                   vScrollerUssClassName  // static @ 0x68
  public    static readonly System.String                   horizontalVariantUssClassName  // static @ 0x70
  public    static readonly System.String                   verticalVariantUssClassName  // static @ 0x78
  public    static readonly System.String                   verticalHorizontalVariantUssClassName  // static @ 0x80
  public    static readonly System.String                   scrollVariantUssClassName  // static @ 0x88
  private           UnityEngine.UIElements.ScrollViewModem_Mode  // 0x448
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScheduledLayoutPassResetItem  // 0x450
  private           UnityEngine.Vector2             m_StartPosition  // 0x458
  private           UnityEngine.Vector2             m_PointerStartPosition  // 0x460
  private           UnityEngine.Vector2             m_Velocity  // 0x468
  private           UnityEngine.Vector2             m_SpringBackVelocity  // 0x470
  private           UnityEngine.Vector2             m_LowBounds  // 0x478
  private           UnityEngine.Vector2             m_HighBounds  // 0x480
  private           System.Single                   m_LastVelocityLerpTime  // 0x488
  private           System.Boolean                  m_StartedMoving  // 0x48c
  private           System.Boolean                  m_TouchPointerMoveAllowed  // 0x48d
  private           System.Boolean                  m_TouchStoppedVelocity  // 0x48e
  private           UnityEngine.UIElements.VisualElementm_CapturedTarget  // 0x490
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerMoveEvent>m_CapturedTargetPointerMoveCallback  // 0x498
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent>m_CapturedTargetPointerUpCallback  // 0x4a0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_PostPointerUpAnimation  // 0x4a8
PROPERTIES:
  horizontalScrollerVisibility  get=0x03D89010  set=0x09EFFAD8
  verticalScrollerVisibility  get=0x03D89060  set=0x09EFFDA0
  showHorizontal  set=0x09EFFC90
  showVertical  set=0x09EFFCB0
  needsHorizontal  get=0x09EFF854
  needsVertical  get=0x09EFF894
  isVerticalScrollDisplayed  get=0x09EFF82C
  isHorizontalScrollDisplayed  get=0x09EFF804
  scrollOffset  get=0x09EFF8D4  set=0x09EFFBC0
  horizontalPageSize  set=0x09EFFAC8
  verticalPageSize  set=0x09EFFD90
  mouseWheelScrollSize  get=0x03D68DF0  set=0x09EFFB30
  scrollableWidth  get=0x09EFF990
  scrollableHeight  get=0x09EFF924
  hasInertia  get=0x09EFF7F0
  scrollDecelerationRate  get=0x03D89040  set=0x09EFFBAC
  elasticity  get=0x03D89000  set=0x09EFFAB4
  touchScrollBehavior  get=0x03D89050  set=0x09EFFCD0
  nestedInteractionKind  get=0x03D89030  set=0x03D89070
  elasticAnimationIntervalMs  set=0x09EFF9FC
  contentViewport  get=0x03D570D0
  horizontalScroller  get=0x03D57150
  verticalScroller  get=0x03D57320
  contentContainer  get=0x03D88FF0
  mode  get=0x03D89020  set=0x09EFFB1C
METHODS:
  RVA=0x09EFC610  token=0x60009EB  System.Void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EFD210  token=0x60009EC  System.Void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EFE058  token=0x60009ED  System.Void UpdateHorizontalSliderPageSize()
  RVA=0x09EFE448  token=0x60009EE  System.Void UpdateVerticalSliderPageSize()
  RVA=0x09EFDE14  token=0x60009EF  System.Void UpdateContentViewTransform()
  RVA=0x09EFD608  token=0x60009F0  System.Void ScrollTo(UnityEngine.UIElements.VisualElement child)
  RVA=0x09EFB7A8  token=0x60009F1  System.Single GetXDeltaOffset(UnityEngine.UIElements.VisualElement child)
  RVA=0x09EFB914  token=0x60009F2  System.Single GetYDeltaOffset(UnityEngine.UIElements.VisualElement child)
  RVA=0x09EFB754  token=0x60009F3  System.Single GetDeltaDistance(System.Single viewMin, System.Single viewMax, System.Single childBoundaryMin, System.Single childBoundaryMax)
  RVA=0x09EFF7E4  token=0x60009F8  System.Void .ctor()
  RVA=0x09EFEA90  token=0x60009F9  System.Void .ctor(UnityEngine.UIElements.ScrollViewMode scrollViewMode)
  RVA=0x09EFD800  token=0x60009FC  System.Void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode mode)
  RVA=0x09EFBBE4  token=0x60009FD  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09EFC064  token=0x60009FE  System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09EFC7B8  token=0x60009FF  System.Void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent evt)
  RVA=0x09EFC6EC  token=0x6000A00  System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  RVA=0x09EFC4EC  token=0x6000A01  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EFD550  token=0x6000A02  System.Void ScheduleResetLayoutPass()
  RVA=0x03D88FE0  token=0x6000A03  System.Void ResetLayoutPass()
  RVA=0x09EFB0AC  token=0x6000A04  System.Single ComputeElasticOffset(System.Single deltaPointer, System.Single initialScrollOffset, System.Single lowLimit, System.Single hardLowLimit, System.Single highLimit, System.Single hardHighLimit)
  RVA=0x09EFB214  token=0x6000A05  System.Void ComputeInitialSpringBackVelocity()
  RVA=0x09EFDBD8  token=0x6000A06  System.Void SpringBack()
  RVA=0x09EFAB60  token=0x6000A07  System.Void ApplyScrollInertia()
  RVA=0x09EFD294  token=0x6000A08  System.Void PostPointerUpAnimation()
  RVA=0x09EFC8A0  token=0x6000A09  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  RVA=0x09EFCA7C  token=0x6000A0A  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  RVA=0x09EFC694  token=0x6000A0B  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  RVA=0x09EFCCD0  token=0x6000A0C  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EFBA8C  token=0x6000A0D  System.Void InitTouchScrolling(UnityEngine.Vector2 position)
  RVA=0x09EFB324  token=0x6000A0E  UnityEngine.UIElements.ScrollView.TouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2 position)
  RVA=0x09EFAE94  token=0x6000A0F  System.Boolean ApplyTouchScrolling(UnityEngine.Vector2 newScrollOffset)
  RVA=0x09EFD478  token=0x6000A10  System.Boolean ReleaseScrolling(System.Int32 pointerId, UnityEngine.UIElements.IEventHandler target)
  RVA=0x09EFB680  token=0x6000A11  System.Void ExecuteElasticSpringAnimation()
  RVA=0x09EFA9FC  token=0x6000A12  System.Void AdjustScrollers()
  RVA=0x09EFE130  token=0x6000A13  System.Void UpdateScrollers(System.Boolean displayHorizontal, System.Boolean displayVertical)
  RVA=0x09EFD0C0  token=0x6000A14  System.Void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EFCD60  token=0x6000A15  System.Void OnScrollWheel(UnityEngine.UIElements.WheelEvent evt)
  RVA=0x09EFCD58  token=0x6000A16  System.Void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt)
  RVA=0x03D88FD0  token=0x6000A17  System.Void OnRootPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EFD394  token=0x6000A18  System.Void ReadSingleLineHeight()
  RVA=0x09EFDF34  token=0x6000A19  System.Void UpdateElasticBehaviour()
  RVA=0x09EFE520  token=0x6000A1A  System.Void .cctor()
  RVA=0x09EFDD7C  token=0x6000A1B  System.Void <.ctor>b__126_0(System.Single value)
  RVA=0x09EFDDC8  token=0x6000A1C  System.Void <.ctor>b__126_1(System.Single value)
END_CLASS

CLASS: UnityEngine.UIElements.Slider
TYPE:  class
TOKEN: 0x200015F
SIZE:  0x468
EXTENDS: UnityEngine.UIElements.BaseSlider`1
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   inputUssClassName  // static @ 0x10
METHODS:
  RVA=0x09F01828  token=0x6000A20  System.Void .ctor()
  RVA=0x09F01854  token=0x6000A21  System.Void .ctor(System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  RVA=0x09F016E8  token=0x6000A22  System.Void .ctor(System.String label, System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  RVA=0x09F01470  token=0x6000A23  System.Single SliderLerpUnclamped(System.Single a, System.Single b, System.Single interpolant)
  RVA=0x09EF81C4  token=0x6000A24  System.Single SliderNormalizeValue(System.Single currentValue, System.Single lowerValue, System.Single higherValue)
  RVA=0x09F013B8  token=0x6000A25  System.Single ParseStringToValue(System.String stringValue)
  RVA=0x09F01224  token=0x6000A26  System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<System.Single> sliderKey, System.Boolean isShift)
  RVA=0x09F015E0  token=0x6000A27  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.SliderInt
TYPE:  class
TOKEN: 0x2000162
SIZE:  0x468
EXTENDS: UnityEngine.UIElements.BaseSlider`1
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   inputUssClassName  // static @ 0x10
PROPERTIES:
  pageSize  get=0x09F01194  set=0x09F011D4
METHODS:
  RVA=0x09F0102C  token=0x6000A2B  System.Void .ctor()
  RVA=0x09F0105C  token=0x6000A2C  System.Void .ctor(System.String label, System.Int32 start, System.Int32 end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  RVA=0x09F00ED4  token=0x6000A2F  System.Int32 SliderLerpUnclamped(System.Int32 a, System.Int32 b, System.Single interpolant)
  RVA=0x09F00EF4  token=0x6000A30  System.Single SliderNormalizeValue(System.Int32 currentValue, System.Int32 lowerValue, System.Int32 higherValue)
  RVA=0x09F00EA4  token=0x6000A31  System.Int32 ParseStringToValue(System.String stringValue)
  RVA=0x09F00AC8  token=0x6000A32  System.Void ComputeValueAndDirectionFromClick(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos, System.Single dragElementLastPos)
  RVA=0x09F00CFC  token=0x6000A33  System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<System.Int32> sliderKey, System.Boolean isShift)
  RVA=0x09F00F24  token=0x6000A34  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextEditorEventHandler
TYPE:  class
TOKEN: 0x2000165
SIZE:  0x20
FIELDS:
  private           UnityEngine.UIElements.TextEditorEngine<editorEngine>k__BackingField  // 0x10
  private           UnityEngine.UIElements.ITextInputField<textInputField>k__BackingField  // 0x18
PROPERTIES:
  editorEngine  get=0x020B7B20  set=0x0426FEE0
  textInputField  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09F11248  token=0x6000A3C  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField)
  RVA=0x0350B670  token=0x6000A3D  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F11130  token=0x6000A3E  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.TextEditorEngine
TYPE:  class
TOKEN: 0x2000166
SIZE:  0xA0
EXTENDS: UnityEngine.TextEditor
FIELDS:
  private           UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunctionm_DetectFocusChangeFunction  // 0x90
  private           UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunctionm_IndexChangeFunction  // 0x98
PROPERTIES:
  localPosition  get=0x03D890E0
METHODS:
  RVA=0x09F110DC  token=0x6000A3F  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction detectFocusChange, UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction indexChangeFunction)
  RVA=0x09F110B4  token=0x6000A41  System.Void OnDetectFocusChange()
  RVA=0x09F1108C  token=0x6000A42  System.Void OnCursorIndexChange()
  RVA=0x09F1108C  token=0x6000A43  System.Void OnSelectIndexChange()
END_CLASS

CLASS: UnityEngine.UIElements.TextField
TYPE:  class
TOKEN: 0x2000169
SIZE:  0x438
EXTENDS: UnityEngine.UIElements.TextInputBaseField`1
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   inputUssClassName  // static @ 0x10
PROPERTIES:
  textInput  get=0x09F11680
  multiline  set=0x09F11708
  value  get=0x09F116CC  set=0x09F11738
METHODS:
  RVA=0x09F11674  token=0x6000A4A  System.Void .ctor()
  RVA=0x09F11648  token=0x6000A4B  System.Void .ctor(System.String label)
  RVA=0x09F11488  token=0x6000A4C  System.Void .ctor(System.String label, System.Int32 maxLength, System.Boolean multiline, System.Boolean isPasswordField, System.Char maskChar)
  RVA=0x09F11308  token=0x6000A4F  System.Void SetValueWithoutNotify(System.String newValue)
  RVA=0x09F11284  token=0x6000A50  System.Void OnViewDataReady()
  RVA=0x09F11380  token=0x6000A51  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ITextInputField
TYPE:  interface
TOKEN: 0x200016D
IMPLEMENTS: UnityEngine.UIElements.IEventHandler UnityEngine.UIElements.ITextElement
FIELDS:
PROPERTIES:
  hasFocus  get=-1  // abstract
  doubleClickSelectsWord  get=-1  // abstract
  tripleClickSelectsLine  get=-1  // abstract
  isReadOnly  get=-1  // abstract
  isDelayed  get=-1  // abstract
  isPasswordField  get=-1  // abstract
  editorEngine  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000A67  System.Void SyncTextEngine()
  RVA=-1  // abstract  token=0x6000A68  System.Boolean AcceptCharacter(System.Char c)
  RVA=-1  // abstract  token=0x6000A69  System.String CullString(System.String s)
  RVA=-1  // abstract  token=0x6000A6A  System.Void UpdateText(System.String value)
  RVA=-1  // abstract  token=0x6000A6B  System.Void UpdateValueFromText()
END_CLASS

CLASS: UnityEngine.UIElements.TextInputBaseField`1
TYPE:  abstract class
TOKEN: 0x200016E
EXTENDS: UnityEngine.UIElements.BaseField`1
FIELDS:
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color>s_SelectionColorProperty  // static @ 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color>s_CursorColorProperty  // static @ 0x0
  private           System.Int32                    m_VisualInputTabIndex  // 0x0
  private           UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType>m_TextInputBase  // 0x0
  private           UnityEngine.UIElements.ITextHandle<iTextHandle>k__BackingField  // 0x0
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x0
  public    static readonly System.String                   inputUssClassName  // static @ 0x0
  public    static readonly System.String                   singleLineInputUssClassName  // static @ 0x0
  public    static readonly System.String                   multilineInputUssClassName  // static @ 0x0
  public    static readonly System.String                   textInputUssName  // static @ 0x0
  private           System.Action<System.Boolean>   onIsReadOnlyChanged  // 0x0
PROPERTIES:
  textInputBase  get=-1  // not resolved
  iTextHandle  set=-1  // not resolved
  text  set=-1  // not resolved
  isReadOnly  set=-1  // not resolved
  isPasswordField  set=-1  // not resolved
  maxLength  set=-1  // not resolved
  isDelayed  get=-1  // not resolved  set=-1  // not resolved
  maskChar  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000A75  System.Void .ctor(System.String label, System.Int32 maxLength, System.Char maskChar, UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInputBase)
  RVA=-1  // not resolved  token=0x6000A76  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e)
  RVA=-1  // not resolved  token=0x6000A77  System.Void OnFieldCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  RVA=-1  // not resolved  token=0x6000A78  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // not resolved  token=0x6000A79  System.Void UpdateMixedValueContent()
  RVA=-1  // not resolved  token=0x6000A7A  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Toggle
TYPE:  class
TOKEN: 0x2000171
SIZE:  0x438
EXTENDS: UnityEngine.UIElements.BaseBoolField
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   labelUssClassName  // static @ 0x8
  public    static readonly System.String                   inputUssClassName  // static @ 0x10
  public    static readonly System.String                   noTextVariantUssClassName  // static @ 0x18
  public    static readonly System.String                   checkmarkUssClassName  // static @ 0x20
  public    static readonly System.String                   textUssClassName  // static @ 0x28
METHODS:
  RVA=0x09F12584  token=0x6000AC4  System.Void .ctor()
  RVA=0x09F12488  token=0x6000AC5  System.Void .ctor(System.String label)
  RVA=0x09F12214  token=0x6000AC6  System.Void InitLabel()
  RVA=0x09F12284  token=0x6000AC7  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TouchScreenTextEditorEventHandler
TYPE:  class
TOKEN: 0x2000174
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.TextEditorEventHandler
FIELDS:
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_TouchKeyboardPoller  // 0x20
  private           UnityEngine.UIElements.VisualElementm_LastPointerDownTarget  // 0x28
METHODS:
  RVA=0x09F12BB0  token=0x6000ACB  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField)
  RVA=0x09F12AB0  token=0x6000ACC  System.Void PollTouchScreenKeyboard()
  RVA=0x09F12590  token=0x6000ACD  System.Void DoPollTouchScreenKeyboard()
  RVA=0x09F12758  token=0x6000ACE  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.TreeView
TYPE:  class
TOKEN: 0x2000175
SIZE:  0x4D8
EXTENDS: UnityEngine.UIElements.BaseTreeView
FIELDS:
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeItem  // 0x4b8
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_BindItem  // 0x4c0
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32><unbindItem>k__BackingField  // 0x4c8
  private           System.Action<UnityEngine.UIElements.VisualElement><destroyItem>k__BackingField  // 0x4d0
PROPERTIES:
  makeItem  get=0x03D57340  set=0x09F12DB4
  bindItem  get=0x03D572F0  set=0x09F12D64
  unbindItem  get=0x03D6C890
  destroyItem  get=0x03D5A3B0
METHODS:
  RVA=0x09F12C9C  token=0x6000AD5  System.Boolean HasValidDataAndBindings()
  RVA=0x09F12C40  token=0x6000AD6  UnityEngine.UIElements.CollectionViewController CreateViewController()
  RVA=0x09F12CD8  token=0x6000AD7  System.Void .ctor()
  RVA=0x09F12CE8  token=0x6000AD8  System.Void .ctor(System.Func<UnityEngine.UIElements.VisualElement> makeItem, System.Action<UnityEngine.UIElements.VisualElement,System.Int32> bindItem)
END_CLASS

CLASS: UnityEngine.UIElements.TreeData`1
TYPE:  sealed struct
TOKEN: 0x2000178
FIELDS:
  private   readonly System.Collections.Generic.IList<System.Int32>m_RootItemIds  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeViewItemData<T>>m_Tree  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_ParentIds  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>m_ChildrenIds  // 0x0
PROPERTIES:
  rootItemIds  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000ADC  System.Void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems)
  RVA=-1  // not resolved  token=0x6000ADD  UnityEngine.UIElements.TreeViewItemData<T> GetDataForId(System.Int32 id)
  RVA=-1  // not resolved  token=0x6000ADE  System.Int32 GetParentId(System.Int32 id)
  RVA=-1  // not resolved  token=0x6000ADF  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex)
  RVA=-1  // not resolved  token=0x6000AE0  System.Boolean HasAncestor(System.Int32 childId, System.Int32 ancestorId)
  RVA=-1  // not resolved  token=0x6000AE1  System.Void AddItemToParent(UnityEngine.UIElements.TreeViewItemData<T> item, System.Int32 parentId, System.Int32 childIndex)
  RVA=-1  // not resolved  token=0x6000AE2  System.Void RemoveFromParent(System.Int32 id, System.Int32 parentId)
  RVA=-1  // not resolved  token=0x6000AE3  System.Void UpdateParentTree(UnityEngine.UIElements.TreeViewItemData<T> current)
  RVA=-1  // not resolved  token=0x6000AE4  System.Void RefreshTree(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems)
  RVA=-1  // not resolved  token=0x6000AE5  System.Void BuildTree(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items, System.Boolean isRoot)
END_CLASS

CLASS: UnityEngine.UIElements.TreeItem
TYPE:  sealed struct
TOKEN: 0x2000179
SIZE:  0x20
FIELDS:
  private   readonly System.Int32                    <id>k__BackingField  // 0x10
  private   readonly System.Int32                    <parentId>k__BackingField  // 0x14
  private   readonly System.Collections.Generic.IEnumerable<System.Int32><childrenIds>k__BackingField  // 0x18
PROPERTIES:
  id  get=0x03D4E980
  parentId  get=0x03D4E990
  childrenIds  get=0x03D50DE0
  hasChildren  get=0x09F12BE8
METHODS:
  RVA=0x042713DC  token=0x6000AEA  System.Void .ctor(System.Int32 id, System.Int32 parentId, System.Collections.Generic.IEnumerable<System.Int32> childrenIds)
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewItemWrapper
TYPE:  sealed struct
TOKEN: 0x200017A
SIZE:  0x28
FIELDS:
  public    readonly UnityEngine.UIElements.TreeItem item  // 0x10
  public    readonly System.Int32                    depth  // 0x20
PROPERTIES:
  id  get=0x03D4E980
  childrenIds  get=0x03D50DE0
  hasChildren  get=0x09F12C38
METHODS:
  RVA=0x071AF1D4  token=0x6000AEE  System.Void .ctor(UnityEngine.UIElements.TreeItem item, System.Int32 depth)
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewItemData`1
TYPE:  sealed struct
TOKEN: 0x200017B
FIELDS:
  private   readonly System.Int32                    <id>k__BackingField  // 0x0
  private   readonly T                               m_Data  // 0x0
  private   readonly System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>>m_Children  // 0x0
PROPERTIES:
  id  get=-1  // not resolved
  data  get=-1  // not resolved
  children  get=-1  // not resolved
  hasChildren  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000AF3  System.Void InsertChild(UnityEngine.UIElements.TreeViewItemData<T> child, System.Int32 index)
  RVA=-1  // not resolved  token=0x6000AF4  System.Void RemoveChild(System.Int32 childId)
  RVA=-1  // not resolved  token=0x6000AF5  System.Int32 GetChildIndex(System.Int32 itemId)
  RVA=-1  // not resolved  token=0x6000AF6  System.Void ReplaceChild(UnityEngine.UIElements.TreeViewItemData<T> newChild)
END_CLASS

CLASS: UnityEngine.UIElements.TwoPaneSplitView
TYPE:  class
TOKEN: 0x200017C
SIZE:  0x420
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  private   static readonly System.String                   s_UssClassName  // static @ 0x0
  private   static readonly System.String                   s_ContentContainerClassName  // static @ 0x8
  private   static readonly System.String                   s_HandleDragLineClassName  // static @ 0x10
  private   static readonly System.String                   s_HandleDragLineVerticalClassName  // static @ 0x18
  private   static readonly System.String                   s_HandleDragLineHorizontalClassName  // static @ 0x20
  private   static readonly System.String                   s_HandleDragLineAnchorClassName  // static @ 0x28
  private   static readonly System.String                   s_HandleDragLineAnchorVerticalClassName  // static @ 0x30
  private   static readonly System.String                   s_HandleDragLineAnchorHorizontalClassName  // static @ 0x38
  private   static readonly System.String                   s_VerticalClassName  // static @ 0x40
  private   static readonly System.String                   s_HorizontalClassName  // static @ 0x48
  private           UnityEngine.UIElements.VisualElementm_LeftPane  // 0x3c0
  private           UnityEngine.UIElements.VisualElementm_RightPane  // 0x3c8
  private           UnityEngine.UIElements.VisualElementm_FixedPane  // 0x3d0
  private           UnityEngine.UIElements.VisualElementm_FlexedPane  // 0x3d8
  private           System.Single                   m_FixedPaneDimension  // 0x3e0
  private           UnityEngine.UIElements.VisualElementm_DragLine  // 0x3e8
  private           UnityEngine.UIElements.VisualElementm_DragLineAnchor  // 0x3f0
  private           System.Boolean                  m_CollapseMode  // 0x3f8
  private           UnityEngine.UIElements.VisualElementm_Content  // 0x400
  private           UnityEngine.UIElements.TwoPaneSplitViewOrientationm_Orientation  // 0x408
  private           System.Int32                    m_FixedPaneIndex  // 0x40c
  private           System.Single                   m_FixedPaneInitialDimension  // 0x410
  private           UnityEngine.UIElements.TwoPaneSplitViewResizerm_Resizer  // 0x418
PROPERTIES:
  fixedPane  get=0x03D55EC0
  flexedPane  get=0x03D55ED0
  fixedPaneIndex  get=0x03D89150
  fixedPaneDimension  get=0x09F14E5C  set=0x09F14E80
  contentContainer  get=0x03D89140
METHODS:
  RVA=0x09F14BDC  token=0x6000AFC  System.Void .ctor()
  RVA=0x09F137E4  token=0x6000AFD  System.Void Init(System.Int32 fixedPaneIndex, System.Single fixedPaneInitialDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation)
  RVA=0x09F13B3C  token=0x6000AFE  System.Void OnPostDisplaySetup(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09F13E38  token=0x6000AFF  System.Void PostDisplaySetup()
  RVA=0x09F13E00  token=0x6000B00  System.Void OnSizeChange(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09F13C24  token=0x6000B01  System.Void OnSizeChange()
  RVA=0x09F13E08  token=0x6000B03  System.Void OnViewDataReady()
  RVA=0x09F14794  token=0x6000B04  System.Void SetDragLineOffset(System.Single offset)
  RVA=0x09F14854  token=0x6000B05  System.Void SetFixedPaneDimension(System.Single dimension)
  RVA=0x09F14914  token=0x6000B06  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TwoPaneSplitViewOrientation
TYPE:  sealed struct
TOKEN: 0x200017F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TwoPaneSplitViewOrientationHorizontal  // const
  public    static  UnityEngine.UIElements.TwoPaneSplitViewOrientationVertical  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TwoPaneSplitViewResizer
TYPE:  class
TOKEN: 0x2000180
SIZE:  0x58
EXTENDS: UnityEngine.UIElements.PointerManipulator
FIELDS:
  private           UnityEngine.Vector3             m_Start  // 0x38
  protected         System.Boolean                  m_Active  // 0x44
  private           UnityEngine.UIElements.TwoPaneSplitViewm_SplitView  // 0x48
  private           System.Int32                    m_Direction  // 0x50
  private           UnityEngine.UIElements.TwoPaneSplitViewOrientationm_Orientation  // 0x54
PROPERTIES:
  fixedPane  get=0x09F13754
  flexedPane  get=0x09F137C4
  fixedPaneMinDimension  get=0x09F13704
  flexedPaneMinDimension  get=0x09F13774
METHODS:
  RVA=0x09F13650  token=0x6000B0E  System.Void .ctor(UnityEngine.UIElements.TwoPaneSplitView splitView, System.Int32 dir, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation)
  RVA=0x09F13348  token=0x6000B0F  System.Void RegisterCallbacksOnTarget()
  RVA=0x09F134CC  token=0x6000B10  System.Void UnregisterCallbacksFromTarget()
  RVA=0x09F12E04  token=0x6000B11  System.Void ApplyDelta(System.Single delta)
  RVA=0x09F1310C  token=0x6000B12  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e)
  RVA=0x09F131B8  token=0x6000B13  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e)
  RVA=0x09F132BC  token=0x6000B14  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e)
END_CLASS

CLASS: UnityEngine.UIElements.ColumnDataType
TYPE:  sealed struct
TOKEN: 0x2000181
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ColumnDataTypeName  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeTitle  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeIcon  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeVisibility  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeWidth  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeMaxWidth  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeMinWidth  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeStretchable  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeSortable  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeOptional  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeResizable  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeHeaderTemplate  // const
  public    static  UnityEngine.UIElements.ColumnDataTypeCellTemplate  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Column
TYPE:  class
TOKEN: 0x2000182
SIZE:  0xC0
FIELDS:
  private   static readonly System.String                   k_InvalidTemplateError  // static @ 0x0
  private           System.String                   m_Name  // 0x10
  private           System.String                   m_Title  // 0x18
  private           UnityEngine.UIElements.Backgroundm_Icon  // 0x20
  private           System.Boolean                  m_Visible  // 0x40
  private           UnityEngine.UIElements.Length   m_Width  // 0x44
  private           UnityEngine.UIElements.Length   m_MinWidth  // 0x4c
  private           UnityEngine.UIElements.Length   m_MaxWidth  // 0x54
  private           System.Single                   m_DesiredWidth  // 0x5c
  private           System.Boolean                  m_Stretchable  // 0x60
  private           System.Boolean                  m_Sortable  // 0x61
  private           System.Boolean                  m_Optional  // 0x62
  private           System.Boolean                  m_Resizable  // 0x63
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeHeader  // 0x68
  private           System.Action<UnityEngine.UIElements.VisualElement>m_BindHeader  // 0x70
  private           System.Action<UnityEngine.UIElements.VisualElement>m_UnbindHeader  // 0x78
  private           System.Action<UnityEngine.UIElements.VisualElement>m_DestroyHeader  // 0x80
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeCell  // 0x88
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_BindCell  // 0x90
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_UnbindCellItem  // 0x98
  private           System.Action<UnityEngine.UIElements.VisualElement><destroyCell>k__BackingField  // 0xa0
  private           UnityEngine.UIElements.Columns  <collection>k__BackingField  // 0xa8
  private           System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType>changed  // 0xb0
  private           System.Action<UnityEngine.UIElements.Column>resized  // 0xb8
PROPERTIES:
  name  get=0x020B7B20  set=0x09F0821C
  title  get=0x01041090  set=0x09F082C4
  icon  get=0x03D890A0
  index  get=0x09F07F04
  displayIndex  get=0x09F07E88
  visibleIndex  get=0x09F07F30
  visible  get=0x03D4EE90  set=0x09F0830C
  width  get=0x03D890D0  set=0x09F08324
  minWidth  get=0x03D56700  set=0x09F081DC
  maxWidth  get=0x03D890C0  set=0x09F0819C
  desiredWidth  get=0x03D56C10  set=0x09F080CC
  sortable  get=0x03D51F90  set=0x09F08294
  stretchable  get=0x03D519A0  set=0x09F082AC
  optional  get=0x03D5B400  set=0x09F08264
  resizable  get=0x03D5B3F0  set=0x09F0827C
  makeHeader  get=0x03D4EAB0  set=0x09F08154
  bindHeader  get=0x03D4EB30
  unbindHeader  get=0x03D4EB20
  destroyHeader  get=0x03D4EAE0
  makeCell  get=0x03D4EA60  set=0x09F08100
  bindCell  get=0x03D4EA90
  unbindCell  get=0x011AC510
  destroyCell  get=0x03D4EA80
  collection  get=0x03D4EB10  set=0x0554A7F4
EVENTS:
  changed  add=add_changed  remove=remove_changed
  resized  add=add_resized  remove=remove_resized
METHODS:
  RVA=0x09F07C94  token=0x6000B3F  System.Void NotifyChange(UnityEngine.UIElements.ColumnDataType type)
  RVA=0x09F07C6C  token=0x6000B40  System.Single GetWidth(System.Single layoutWidth)
  RVA=0x09F07C1C  token=0x6000B41  System.Single GetMaxWidth(System.Single layoutWidth)
  RVA=0x09F07C44  token=0x6000B42  System.Single GetMinWidth(System.Single layoutWidth)
  RVA=0x09F07D10  token=0x6000B43  System.Void .ctor()
  RVA=0x09F07CB4  token=0x6000B44  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ColumnLayout
TYPE:  class
TOKEN: 0x2000187
SIZE:  0x90
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_StretchableColumns  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_FixedColumns  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_RelativeWidthColumns  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_MixedWidthColumns  // 0x28
  private           UnityEngine.UIElements.Columns  m_Columns  // 0x30
  private           System.Single                   m_ColumnsWidth  // 0x38
  private           System.Boolean                  m_ColumnsWidthDirty  // 0x3c
  private           System.Single                   m_MaxColumnsWidth  // 0x40
  private           System.Single                   m_MinColumnsWidth  // 0x44
  private           System.Boolean                  m_IsDirty  // 0x48
  private           System.Single                   m_PreviousWidth  // 0x4c
  private           System.Single                   m_LayoutWidth  // 0x50
  private           System.Boolean                  m_DragResizeInPreviewMode  // 0x54
  private           System.Boolean                  m_DragResizing  // 0x55
  private           System.Single                   m_DragStartPos  // 0x58
  private           System.Single                   m_DragLastPos  // 0x5c
  private           System.Single                   m_DragInitialColumnWidth  // 0x60
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DragStretchableColumns  // 0x68
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DragRelativeColumns  // 0x70
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DragFixedColumns  // 0x78
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,System.Single>m_PreviewDesiredWidths  // 0x80
  private           System.Action                   layoutRequested  // 0x88
PROPERTIES:
  columns  get=0x01003830
  columnsWidth  get=0x09F07978
  layoutWidth  get=0x03D51C90
  minColumnsWidth  get=0x03D4EC80
  maxColumnsWidth  get=0x03D4EC70
  hasStretchableColumns  get=0x09F07B40
  hasRelativeWidthColumns  get=0x09F07AE4
EVENTS:
  layoutRequested  add=add_layoutRequested  remove=remove_layoutRequested
METHODS:
  RVA=0x09F075C4  token=0x6000B56  System.Void .ctor(UnityEngine.UIElements.Columns columns)
  RVA=0x09F04688  token=0x6000B57  System.Void Dirty()
  RVA=0x09F05D8C  token=0x6000B58  System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index)
  RVA=0x09F05EA4  token=0x6000B59  System.Void OnColumnRemoved(UnityEngine.UIElements.Column column)
  RVA=0x09F05F8C  token=0x6000B5A  System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to)
  RVA=0x09F06B80  token=0x6000B5B  System.Boolean RequiresLayoutUpdate(UnityEngine.UIElements.ColumnDataType type)
  RVA=0x09F05E74  token=0x6000B5C  System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  RVA=0x03D89090  token=0x6000B5D  System.Void OnColumnResized(UnityEngine.UIElements.Column column)
  RVA=0x09F05D7C  token=0x6000B5E  System.Boolean IsClamped(System.Single value, System.Single min, System.Single max)
  RVA=0x09F049E4  token=0x6000B5F  System.Void DoLayout(System.Single width)
  RVA=0x09F07048  token=0x6000B60  System.Void StretchResizeColumns(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize)
  RVA=0x09F04824  token=0x6000B61  System.Void DistributeOverflow(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize)
  RVA=0x09F046C0  token=0x6000B62  System.Void DistributeExcess(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize)
  RVA=0x09F06294  token=0x6000B63  System.Single RecomputeToMaxWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  RVA=0x09F06704  token=0x6000B64  System.Single RecomputeToMinWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  RVA=0x09F06180  token=0x6000B65  System.Single RecomputeToDesiredWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly, System.Boolean distributeOverflow)
  RVA=0x09F05F94  token=0x6000B66  System.Single RecomputeToDesiredWidth(UnityEngine.UIElements.Column column, System.Single distributedDelta, System.Boolean setDesiredWidthOnly, System.Boolean distributeOverflow)
  RVA=0x09F069EC  token=0x6000B67  System.Single RecomputeToMinWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  RVA=0x09F06568  token=0x6000B68  System.Single RecomputeToMaxWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  RVA=0x09F06C88  token=0x6000B69  System.Void ResizeToFit(System.Single width)
  RVA=0x09F06B98  token=0x6000B6A  System.Void ResizeColumn(UnityEngine.UIElements.Column column, System.Single width, System.Boolean setDesiredWidthOnly)
  RVA=0x09F0435C  token=0x6000B6B  System.Void BeginDragResize(UnityEngine.UIElements.Column column, System.Single pos, System.Boolean previewMode)
  RVA=0x09F05C28  token=0x6000B6C  System.Single GetDesiredPosition(UnityEngine.UIElements.Column column)
  RVA=0x09F05CE4  token=0x6000B6D  System.Single GetDesiredWidth(UnityEngine.UIElements.Column c)
  RVA=0x09F056E8  token=0x6000B6E  System.Void DragResize(UnityEngine.UIElements.Column column, System.Single pos)
  RVA=0x09F05A0C  token=0x6000B6F  System.Void EndDragResize(UnityEngine.UIElements.Column column, System.Boolean cancelled)
  RVA=0x09F071D0  token=0x6000B70  System.Void UpdateCache()
  RVA=0x09F07448  token=0x6000B71  System.Void UpdateMinAndMaxColumnsWidth()
  RVA=0x09F0460C  token=0x6000B72  System.Void ClearCache()
  RVA=0x09F07108  token=0x6000B73  System.Int32 <DoLayout>b__49_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
  RVA=0x09F07108  token=0x6000B74  System.Int32 <DoLayout>b__49_1(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
  RVA=0x09F07108  token=0x6000B75  System.Int32 <RecomputeToMaxWidthProportionally>b__53_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
  RVA=0x09F0716C  token=0x6000B76  System.Int32 <RecomputeToMinWidthProportionally>b__54_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
END_CLASS

CLASS: UnityEngine.UIElements.ColumnsDataType
TYPE:  sealed struct
TOKEN: 0x200018A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ColumnsDataTypePrimaryColumn  // const
  public    static  UnityEngine.UIElements.ColumnsDataTypeStretchMode  // const
  public    static  UnityEngine.UIElements.ColumnsDataTypeReorderable  // const
  public    static  UnityEngine.UIElements.ColumnsDataTypeResizable  // const
  public    static  UnityEngine.UIElements.ColumnsDataTypeResizePreview  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Columns
TYPE:  class
TOKEN: 0x200018B
SIZE:  0x70
IMPLEMENTS: System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           System.Collections.Generic.IList<UnityEngine.UIElements.Column>m_Columns  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DisplayColumns  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_VisibleColumns  // 0x20
  private           System.Boolean                  m_VisibleColumnsDirty  // 0x28
  private           UnityEngine.UIElements.Columns.StretchModem_StretchMode  // 0x2c
  private           System.Boolean                  m_Reorderable  // 0x30
  private           System.Boolean                  m_Resizable  // 0x31
  private           System.Boolean                  m_ResizePreview  // 0x32
  private           System.String                   m_PrimaryColumnName  // 0x38
  private           System.Action<UnityEngine.UIElements.ColumnsDataType>changed  // 0x40
  private           System.Action<UnityEngine.UIElements.Column,System.Int32>columnAdded  // 0x48
  private           System.Action<UnityEngine.UIElements.Column>columnRemoved  // 0x50
  private           System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType>columnChanged  // 0x58
  private           System.Action<UnityEngine.UIElements.Column>columnResized  // 0x60
  private           System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32>columnReordered  // 0x68
PROPERTIES:
  primaryColumnName  get=0x03D4E2A0  set=0x09F09940
  reorderable  get=0x03D4EF60  set=0x09F09988
  resizable  get=0x03D4F2C0  set=0x09F099A0
  resizePreview  get=0x03D4F630  set=0x09F099B8
  displayList  get=0x09F095C0
  visibleList  get=0x09F095DC
  stretchMode  get=0x03D4EDD0  set=0x09F099D0
  Count  get=0x09F09390
  IsReadOnly  get=0x09F093D8
  Item  get=0x09F09424
  Item  get=0x09F09424
EVENTS:
  changed  add=add_changed  remove=remove_changed
  columnAdded  add=add_columnAdded  remove=remove_columnAdded
  columnRemoved  add=add_columnRemoved  remove=remove_columnRemoved
  columnChanged  add=add_columnChanged  remove=remove_columnChanged
  columnResized  add=add_columnResized  remove=remove_columnResized
  columnReordered  add=add_columnReordered  remove=remove_columnReordered
METHODS:
  RVA=0x09F08A28  token=0x6000B93  System.Boolean IsPrimary(UnityEngine.UIElements.Column column)
  RVA=0x09F086D0  token=0x6000B94  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.Column> GetEnumerator()
  RVA=0x09F08DD0  token=0x6000B95  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x09F08378  token=0x6000B96  System.Void Add(UnityEngine.UIElements.Column item)
  RVA=0x09F083DC  token=0x6000B97  System.Void Clear()
  RVA=0x09F085D4  token=0x6000B98  System.Boolean Contains(UnityEngine.UIElements.Column item)
  RVA=0x09F0847C  token=0x6000B99  System.Boolean Contains(System.String name)
  RVA=0x09F08628  token=0x6000B9A  System.Void CopyTo(UnityEngine.UIElements.Column[] array, System.Int32 arrayIndex)
  RVA=0x09F08B08  token=0x6000B9B  System.Boolean Remove(UnityEngine.UIElements.Column column)
  RVA=0x09F08AA8  token=0x6000B9C  System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  RVA=0x09F08AF4  token=0x6000B9D  System.Void OnColumnResized(UnityEngine.UIElements.Column column)
  RVA=0x09F08718  token=0x6000BA0  System.Int32 IndexOf(UnityEngine.UIElements.Column column)
  RVA=0x09F087E8  token=0x6000BA1  System.Void Insert(System.Int32 index, UnityEngine.UIElements.Column column)
  RVA=0x09F08CDC  token=0x6000BA4  System.Void ReorderDisplay(System.Int32 from, System.Int32 to)
  RVA=0x09F08768  token=0x6000BA5  System.Void InitOrderColumns()
  RVA=0x09F08688  token=0x6000BA6  System.Void DirtyVisibleColumns()
  RVA=0x09F08DDC  token=0x6000BA7  System.Void UpdateVisibleColumns()
  RVA=0x09F08A94  token=0x6000BA8  System.Void NotifyChange(UnityEngine.UIElements.ColumnsDataType type)
  RVA=0x09F08FC0  token=0x6000BA9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnController
TYPE:  class
TOKEN: 0x2000190
SIZE:  0x38
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly UnityEngine.PropertyName        k_BoundColumnVePropertyName  // static @ 0x0
  private   static readonly UnityEngine.PropertyName        bindableElementPropertyName  // static @ 0x4
  private   static readonly System.String                   baseUssClassName  // static @ 0x8
  private   static readonly System.String                   k_HeaderContainerViewDataKey  // static @ 0x10
  public    static readonly System.String                   headerContainerUssClassName  // static @ 0x18
  public    static readonly System.String                   rowContainerUssClassName  // static @ 0x20
  public    static readonly System.String                   cellUssClassName  // static @ 0x28
  public    static readonly System.String                   cellLabelUssClassName  // static @ 0x30
  private   static readonly System.String                   k_HeaderViewDataKey  // static @ 0x38
  private           System.Action                   columnSortingChanged  // 0x10
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>headerContextMenuPopulateEvent  // 0x18
  private           UnityEngine.UIElements.BaseVerticalCollectionViewm_View  // 0x20
  private           UnityEngine.UIElements.VisualElementm_HeaderContainer  // 0x28
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeaderm_MultiColumnHeader  // 0x30
PROPERTIES:
  header  get=0x01003830
EVENTS:
  columnSortingChanged  add=add_columnSortingChanged  remove=remove_columnSortingChanged
  headerContextMenuPopulateEvent  add=add_headerContextMenuPopulateEvent  remove=remove_headerContextMenuPopulateEvent
METHODS:
  RVA=0x09F0F2AC  token=0x6000BB5  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  RVA=-1  // generic def  token=0x6000BB6  System.Void BindCellItem(UnityEngine.UIElements.VisualElement ve, System.Int32 rowIndex, UnityEngine.UIElements.Column column, T item)
  RVA=0x09F0ECF0  token=0x6000BB7  System.Void UnbindCellItem(UnityEngine.UIElements.VisualElement ve, System.Int32 rowIndex, UnityEngine.UIElements.Column column)
  RVA=0x09F0DA78  token=0x6000BB8  UnityEngine.UIElements.VisualElement DefaultMakeCellItem()
  RVA=-1  // generic def  token=0x6000BB9  System.Void DefaultBindCellItem(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Column column, T item)
  RVA=0x09F0E2E4  token=0x6000BBA  UnityEngine.UIElements.VisualElement MakeItem()
  RVA=-1  // generic def  token=0x6000BBB  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index, T item)
  RVA=0x09F0ED24  token=0x6000BBC  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  RVA=0x09F0DAFC  token=0x6000BBD  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  RVA=0x09F0E9EC  token=0x6000BBE  System.Void PrepareView(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  RVA=0x09F0DD2C  token=0x6000BBF  System.Void Dispose()
  RVA=0x09F0E8A0  token=0x6000BC0  System.Void OnHorizontalScrollerValueChanged(System.Single v)
  RVA=0x09F0E8C0  token=0x6000BC1  System.Void OnViewportGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09F0E634  token=0x6000BC2  System.Void OnColumnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09F0EF30  token=0x6000BC3  System.Void UpdateContentContainer(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  RVA=0x0576F918  token=0x6000BC4  System.Void OnColumnSortingChanged()
  RVA=0x09F0E88C  token=0x6000BC5  System.Void OnContextMenuPopulateEvent(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column)
  RVA=0x09F0E678  token=0x6000BC6  System.Void OnColumnResized(System.Int32 index, System.Single width)
  RVA=0x09F0E5DC  token=0x6000BC7  System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index)
  RVA=0x09F0E5DC  token=0x6000BC8  System.Void OnColumnRemoved(UnityEngine.UIElements.Column column)
  RVA=0x09F0E640  token=0x6000BC9  System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to)
  RVA=0x09F0E854  token=0x6000BCA  System.Void OnColumnsChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  RVA=0x09F0E5FC  token=0x6000BCB  System.Void OnColumnChanged(UnityEngine.UIElements.ColumnsDataType type)
  RVA=0x09F0E5DC  token=0x6000BCC  System.Void OnViewDataRestored()
  RVA=0x09F0F008  token=0x6000BCD  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnListView
TYPE:  class
TOKEN: 0x2000191
SIZE:  0x568
EXTENDS: UnityEngine.UIElements.BaseListView
FIELDS:
  private           UnityEngine.UIElements.Columns  m_Columns  // 0x538
  private           System.Boolean                  m_SortingEnabled  // 0x540
  private           UnityEngine.UIElements.SortColumnDescriptionsm_SortColumnDescriptions  // 0x548
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortedColumns  // 0x550
  private           System.Action                   columnSortingChanged  // 0x558
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>headerContextMenuPopulateEvent  // 0x560
PROPERTIES:
  viewController  get=0x09F0FE4C
  columns  get=0x03D6CB00  set=0x09F0FE90
  sortColumnDescriptions  get=0x03D6CB20  set=0x09F0FEF4
  sortingEnabled  set=0x09F0FF88
METHODS:
  RVA=0x09F0FDE4  token=0x6000BD4  System.Void .ctor()
  RVA=0x09F0FC90  token=0x6000BD5  System.Void .ctor(UnityEngine.UIElements.Columns columns)
  RVA=0x09F0F958  token=0x6000BD6  UnityEngine.UIElements.CollectionViewController CreateViewController()
  RVA=0x09F0FA54  token=0x6000BD7  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  RVA=0x09F0F9EC  token=0x6000BD8  System.Void CreateVirtualizationController()
  RVA=0x09F0FA28  token=0x6000BD9  System.Void RaiseColumnSortingChanged()
  RVA=0x09F0FA3C  token=0x6000BDA  System.Void RaiseHeaderContextMenuPopulate(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column)
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnTreeView
TYPE:  class
TOKEN: 0x2000194
SIZE:  0x4E8
EXTENDS: UnityEngine.UIElements.BaseTreeView
FIELDS:
  private           UnityEngine.UIElements.Columns  m_Columns  // 0x4b8
  private           System.Boolean                  m_SortingEnabled  // 0x4c0
  private           UnityEngine.UIElements.SortColumnDescriptionsm_SortColumnDescriptions  // 0x4c8
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortedColumns  // 0x4d0
  private           System.Action                   columnSortingChanged  // 0x4d8
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>headerContextMenuPopulateEvent  // 0x4e0
PROPERTIES:
  viewController  get=0x09F104E8
  columns  get=0x03D57340  set=0x09F1052C
  sortColumnDescriptions  get=0x03D6C890  set=0x09F10590
  sortingEnabled  set=0x09F10624
METHODS:
  RVA=0x09F10480  token=0x6000BE4  System.Void .ctor()
  RVA=0x09F1032C  token=0x6000BE5  System.Void .ctor(UnityEngine.UIElements.Columns columns)
  RVA=0x09F0FFE8  token=0x6000BE6  UnityEngine.UIElements.CollectionViewController CreateViewController()
  RVA=0x09F100F0  token=0x6000BE7  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  RVA=0x09F10088  token=0x6000BE8  System.Void CreateVirtualizationController()
  RVA=0x09F100C4  token=0x6000BE9  System.Void RaiseColumnSortingChanged()
  RVA=0x09F100D8  token=0x6000BEA  System.Void RaiseHeaderContextMenuPopulate(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column)
END_CLASS

CLASS: UnityEngine.UIElements.SortDirection
TYPE:  sealed struct
TOKEN: 0x2000197
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.SortDirectionAscending  // const
  public    static  UnityEngine.UIElements.SortDirectionDescending  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.SortColumnDescription
TYPE:  class
TOKEN: 0x2000198
SIZE:  0x38
FIELDS:
  private           System.Int32                    m_ColumnIndex  // 0x10
  private           System.String                   m_ColumnName  // 0x18
  private           UnityEngine.UIElements.SortDirectionm_SortDirection  // 0x20
  private           UnityEngine.UIElements.Column   <column>k__BackingField  // 0x28
  private           System.Action<UnityEngine.UIElements.SortColumnDescription>changed  // 0x30
PROPERTIES:
  columnName  get=0x01041090  set=0x09F10874
  columnIndex  get=0x03D4E340  set=0x09F1084C
  column  get=0x03D4EAC0  set=0x02C92F10
  direction  get=0x01003B50  set=0x09F108C0
EVENTS:
  changed  add=add_changed  remove=remove_changed
METHODS:
  RVA=0x03D51990  token=0x6000BF8  System.Void .ctor()
  RVA=0x09F106FC  token=0x6000BF9  System.Void .ctor(System.Int32 columnIndex, UnityEngine.UIElements.SortDirection direction)
  RVA=0x09F106C4  token=0x6000BFA  System.Void .ctor(System.String columnName, UnityEngine.UIElements.SortDirection direction)
END_CLASS

CLASS: UnityEngine.UIElements.SortColumnDescriptions
TYPE:  class
TOKEN: 0x200019B
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private   readonly System.Collections.Generic.IList<UnityEngine.UIElements.SortColumnDescription>m_Descriptions  // 0x10
  private           System.Action                   changed  // 0x18
PROPERTIES:
  Count  get=0x09F10E8C
  IsReadOnly  get=0x09F10ED4
EVENTS:
  changed  add=add_changed  remove=remove_changed
METHODS:
  RVA=0x09F10A78  token=0x6000C00  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.SortColumnDescription> GetEnumerator()
  RVA=0x09F10D74  token=0x6000C01  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x09F108E8  token=0x6000C02  System.Void Add(UnityEngine.UIElements.SortColumnDescription item)
  RVA=0x09F1094C  token=0x6000C03  System.Void Clear()
  RVA=0x09F109C4  token=0x6000C04  System.Boolean Contains(UnityEngine.UIElements.SortColumnDescription item)
  RVA=0x09F10A18  token=0x6000C05  System.Void CopyTo(UnityEngine.UIElements.SortColumnDescription[] array, System.Int32 arrayIndex)
  RVA=0x09F10C3C  token=0x6000C06  System.Boolean Remove(UnityEngine.UIElements.SortColumnDescription desc)
  RVA=0x0788F298  token=0x6000C07  System.Void OnDescriptionChanged(UnityEngine.UIElements.SortColumnDescription desc)
  RVA=0x09F10AC0  token=0x6000C0A  System.Void Insert(System.Int32 index, UnityEngine.UIElements.SortColumnDescription desc)
  RVA=0x09F10D80  token=0x6000C0B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseReorderableDragAndDropController
TYPE:  abstract class
TOKEN: 0x200019E
SIZE:  0x28
IMPLEMENTS: UnityEngine.UIElements.ICollectionDragAndDropController UnityEngine.UIElements.IDragAndDropController`1 UnityEngine.UIElements.IReorderable
FIELDS:
  protected readonly UnityEngine.UIElements.BaseVerticalCollectionViewm_View  // 0x10
  protected         System.Collections.Generic.List<System.Int32>m_SortedSelectedIds  // 0x18
  private           System.Boolean                  <enableReordering>k__BackingField  // 0x20
PROPERTIES:
  enableReordering  get=0x03D4EF90  set=0x03D4EFC0
METHODS:
  RVA=0x01041090  token=0x6000C0F  System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds()
  RVA=0x09F042C8  token=0x6000C10  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView view)
  RVA=0x03D89080  token=0x6000C13  System.Boolean CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIndices)
  RVA=0x09F03F5C  token=0x6000C14  UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, System.Boolean skipText)
  RVA=0x09F03F3C  token=0x6000C15  System.Int32 CompareId(System.Int32 id1, System.Int32 id2)
  RVA=-1  // abstract  token=0x6000C16  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  RVA=-1  // abstract  token=0x6000C17  System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  RVA=0x0350B670  token=0x6000C18  System.Void DragCleanup()
  RVA=0x0350B670  token=0x6000C19  System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition)
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropUtility
TYPE:  static class
TOKEN: 0x200019F
SIZE:  0x10
FIELDS:
  private   static  System.Func<UnityEngine.UIElements.IDragAndDrop>s_MakeDragAndDropClientFunc  // static @ 0x0
  private   static  UnityEngine.UIElements.IDragAndDrops_DragAndDropEditor  // static @ 0x8
  private   static  UnityEngine.UIElements.IDragAndDrops_DragAndDropPlayMode  // static @ 0x10
METHODS:
  RVA=0x09F0A020  token=0x6000C1A  UnityEngine.UIElements.IDragAndDrop GetDragAndDrop(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.DefaultDragAndDropClient
TYPE:  class
TOKEN: 0x20001A0
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.DragAndDropData
IMPLEMENTS: UnityEngine.UIElements.IDragAndDrop
FIELDS:
  private   readonly System.Collections.Hashtable    m_GenericData  // 0x10
  private           UnityEngine.UIElements.Label    m_DraggedInfoLabel  // 0x18
  private           UnityEngine.UIElements.DragVisualModem_VisualMode  // 0x20
  private           System.Collections.Generic.IEnumerable<UnityEngine.Object>m_UnityObjectReferences  // 0x28
PROPERTIES:
  source  get=0x09F09FE0
  data  get=0x0339AE90
METHODS:
  RVA=0x09F09A2C  token=0x6000C1C  System.Object GetGenericData(System.String key)
  RVA=0x09F09A8C  token=0x6000C1D  System.Void StartDrag(UnityEngine.UIElements.StartDragArgs args, UnityEngine.Vector3 pointerPosition)
  RVA=0x09F09EBC  token=0x6000C1E  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  RVA=0x0350B670  token=0x6000C1F  System.Void AcceptDrag()
  RVA=0x01003B60  token=0x6000C20  System.Void SetVisualMode(UnityEngine.UIElements.DragVisualMode mode)
  RVA=0x09F099E8  token=0x6000C21  System.Void DragCleanup()
  RVA=0x09F09F7C  token=0x6000C23  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DragEventsProcessor
TYPE:  abstract class
TOKEN: 0x20001A1
SIZE:  0x30
FIELDS:
  private           System.Boolean                  m_IsRegistered  // 0x10
  private           UnityEngine.UIElements.DragEventsProcessor.DragStatem_DragState  // 0x14
  private           UnityEngine.Vector3             m_Start  // 0x18
  private   readonly UnityEngine.UIElements.VisualElementm_Target  // 0x28
PROPERTIES:
  supportsDragEvents  get=0x0232EB60
  useDragEvents  get=0x09F0B0E0
  dragAndDrop  get=0x09F0B014
  isEditorContext  get=0x09F0B03C
METHODS:
  RVA=0x09F0AEE8  token=0x6000C28  System.Void .ctor(UnityEngine.UIElements.VisualElement target)
  RVA=0x09F0AAEC  token=0x6000C29  System.Void RegisterCallbacksFromTarget(UnityEngine.UIElements.AttachToPanelEvent evt)
  RVA=0x09F0A7F4  token=0x6000C2A  System.Void RegisterCallbacksFromTarget()
  RVA=0x09F0AEDC  token=0x6000C2B  System.Void UnregisterCallbacksFromTarget(UnityEngine.UIElements.DetachFromPanelEvent evt)
  RVA=0x09F0AAF4  token=0x6000C2C  System.Void UnregisterCallbacksFromTarget(System.Boolean unregisterPanelEvents)
  RVA=-1  // abstract  token=0x6000C2D  System.Boolean CanStartDrag(UnityEngine.Vector3 pointerPosition)
  RVA=-1  // abstract  token=0x6000C2E  UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition)
  RVA=-1  // abstract  token=0x6000C2F  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  RVA=-1  // abstract  token=0x6000C30  System.Void OnDrop(UnityEngine.Vector3 pointerPosition)
  RVA=-1  // abstract  token=0x6000C31  System.Void ClearDragAndDropUI(System.Boolean dragCancelled)
  RVA=0x09F0A32C  token=0x6000C32  System.Void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent evt)
  RVA=0x09F0A688  token=0x6000C33  System.Void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09F0A400  token=0x6000C34  System.Void OnPointerLeaveEvent(UnityEngine.UIElements.PointerLeaveEvent evt)
  RVA=0x09F0A228  token=0x6000C35  System.Void OnPointerCancelEvent(UnityEngine.UIElements.PointerCancelEvent evt)
  RVA=0x09F0A2CC  token=0x6000C36  System.Void OnPointerCapturedOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  RVA=0x09F0A410  token=0x6000C37  System.Void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent evt)
  RVA=0x09F0A14C  token=0x6000C38  UnityEngine.UIElements.DragEventsProcessor GetDropTarget(UnityEngine.Vector2 position)
END_CLASS

CLASS: UnityEngine.UIElements.ICollectionDragAndDropController
TYPE:  interface
TOKEN: 0x20001A3
IMPLEMENTS: UnityEngine.UIElements.IDragAndDropController`1 UnityEngine.UIElements.IReorderable
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IDragAndDrop
TYPE:  interface
TOKEN: 0x20001A4
FIELDS:
PROPERTIES:
  data  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000C39  System.Void StartDrag(UnityEngine.UIElements.StartDragArgs args, UnityEngine.Vector3 pointerPosition)
  RVA=-1  // abstract  token=0x6000C3A  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  RVA=-1  // abstract  token=0x6000C3B  System.Void AcceptDrag()
  RVA=-1  // abstract  token=0x6000C3C  System.Void DragCleanup()
  RVA=-1  // abstract  token=0x6000C3D  System.Void SetVisualMode(UnityEngine.UIElements.DragVisualMode visualMode)
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropData
TYPE:  abstract class
TOKEN: 0x20001A5
SIZE:  0x10
FIELDS:
PROPERTIES:
  source  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000C3F  System.Object GetGenericData(System.String key)
  RVA=0x0350B670  token=0x6000C41  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IDragAndDropController`1
TYPE:  interface
TOKEN: 0x20001A6
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000C42  System.Boolean CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIndices)
  RVA=-1  // abstract  token=0x6000C43  UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIndices, System.Boolean skipText)
  RVA=-1  // abstract  token=0x6000C44  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(TArgs args)
  RVA=-1  // abstract  token=0x6000C45  System.Void OnDrop(TArgs args)
  RVA=-1  // abstract  token=0x6000C46  System.Void DragCleanup()
  RVA=-1  // abstract  token=0x6000C47  System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition)
  RVA=-1  // abstract  token=0x6000C48  System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds()
END_CLASS

CLASS: UnityEngine.UIElements.DragVisualMode
TYPE:  sealed struct
TOKEN: 0x20001A7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DragVisualModeNone  // const
  public    static  UnityEngine.UIElements.DragVisualModeCopy  // const
  public    static  UnityEngine.UIElements.DragVisualModeMove  // const
  public    static  UnityEngine.UIElements.DragVisualModeRejected  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CanStartDragArgs
TYPE:  sealed struct
TOKEN: 0x20001A8
SIZE:  0x28
FIELDS:
  public    readonly UnityEngine.UIElements.VisualElementdraggedElement  // 0x10
  public    readonly System.Int32                    id  // 0x18
  public    readonly System.Collections.Generic.IEnumerable<System.Int32>selectedIds  // 0x20
METHODS:
  RVA=0x07F17684  token=0x6000C49  System.Void .ctor(UnityEngine.UIElements.VisualElement draggedElement, System.Int32 id, System.Collections.Generic.IEnumerable<System.Int32> selectedIds)
END_CLASS

CLASS: UnityEngine.UIElements.SetupDragAndDropArgs
TYPE:  sealed struct
TOKEN: 0x20001A9
SIZE:  0x40
FIELDS:
  public    readonly UnityEngine.UIElements.VisualElementdraggedElement  // 0x10
  public    readonly System.Collections.Generic.IEnumerable<System.Int32>selectedIds  // 0x18
  public    readonly UnityEngine.UIElements.StartDragArgsstartDragArgs  // 0x20
METHODS:
  RVA=0x09F10684  token=0x6000C4A  System.Void .ctor(UnityEngine.UIElements.VisualElement draggedElement, System.Collections.Generic.IEnumerable<System.Int32> selectedIds, UnityEngine.UIElements.StartDragArgs startDragArgs)
END_CLASS

CLASS: UnityEngine.UIElements.HandleDragAndDropArgs
TYPE:  sealed struct
TOKEN: 0x20001AA
SIZE:  0x38
FIELDS:
  private   readonly UnityEngine.UIElements.DragAndDropArgsm_DragAndDropArgs  // 0x10
  private   readonly UnityEngine.Vector2             <position>k__BackingField  // 0x30
METHODS:
  RVA=0x09F0B110  token=0x6000C4B  System.Void .ctor(UnityEngine.Vector2 position, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs)
END_CLASS

CLASS: UnityEngine.UIElements.StartDragArgs
TYPE:  sealed struct
TOKEN: 0x20001AB
SIZE:  0x30
FIELDS:
  private   readonly System.String                   <title>k__BackingField  // 0x10
  private   readonly UnityEngine.UIElements.DragVisualMode<visualMode>k__BackingField  // 0x18
  private           System.Collections.Hashtable    <genericData>k__BackingField  // 0x20
  private           System.Collections.Generic.IEnumerable<UnityEngine.Object><unityObjectReferences>k__BackingField  // 0x28
PROPERTIES:
  title  get=0x020C61B0
  visualMode  get=0x03D516F0
  genericData  get=0x020B7B20  set=0x0426FEE0
  unityObjectReferences  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09F11054  token=0x6000C4C  System.Void .ctor(System.String title, UnityEngine.UIElements.DragVisualMode visualMode)
  RVA=0x09F10FB4  token=0x6000C53  System.Void SetGenericData(System.String key, System.Object data)
END_CLASS

CLASS: UnityEngine.UIElements.IListDragAndDropArgs
TYPE:  interface
TOKEN: 0x20001AC
FIELDS:
PROPERTIES:
  insertAtIndex  get=-1  // abstract
  parentId  get=-1  // abstract
  childIndex  get=-1  // abstract
  dragAndDropData  get=-1  // abstract
  dragAndDropPosition  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropArgs
TYPE:  sealed struct
TOKEN: 0x20001AD
SIZE:  0x30
IMPLEMENTS: UnityEngine.UIElements.IListDragAndDropArgs
FIELDS:
  private           System.Object                   <target>k__BackingField  // 0x10
  private           System.Int32                    <insertAtIndex>k__BackingField  // 0x18
  private           System.Int32                    <parentId>k__BackingField  // 0x1c
  private           System.Int32                    <childIndex>k__BackingField  // 0x20
  private           UnityEngine.UIElements.DragAndDropPosition<dragAndDropPosition>k__BackingField  // 0x24
  private           UnityEngine.UIElements.DragAndDropData<dragAndDropData>k__BackingField  // 0x28
PROPERTIES:
  target  set=0x042715A0
  insertAtIndex  get=0x03D516F0  set=0x03D51710
  parentId  get=0x03D4FBF0  set=0x03D55690
  childIndex  get=0x03D4E340  set=0x010410F0
  dragAndDropPosition  get=0x03D50CC0  set=0x03D595B0
  dragAndDropData  get=0x01041090  set=0x022C3A90
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropPosition
TYPE:  sealed struct
TOKEN: 0x20001AE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DragAndDropPositionOverItem  // const
  public    static  UnityEngine.UIElements.DragAndDropPositionBetweenItems  // const
  public    static  UnityEngine.UIElements.DragAndDropPositionOutsideItems  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IReorderable
TYPE:  interface
TOKEN: 0x20001AF
FIELDS:
PROPERTIES:
  enableReordering  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ListViewDragger
TYPE:  class
TOKEN: 0x20001B0
SIZE:  0x78
EXTENDS: UnityEngine.UIElements.DragEventsProcessor
FIELDS:
  private           UnityEngine.UIElements.ListViewDragger.DragPositionm_LastDragPosition  // 0x30
  private           UnityEngine.UIElements.VisualElementm_DragHoverBar  // 0x50
  private           UnityEngine.UIElements.VisualElementm_DragHoverItemMarker  // 0x58
  private           UnityEngine.UIElements.VisualElementm_DragHoverSiblingMarker  // 0x60
  private           System.Single                   m_LeftIndentation  // 0x68
  private           System.Single                   m_SiblingBottom  // 0x6c
  private           UnityEngine.UIElements.ICollectionDragAndDropController<dragAndDropController>k__BackingField  // 0x70
PROPERTIES:
  targetView  get=0x09F0DA3C
  targetScrollView  get=0x09F0DA18
  dragAndDropController  get=0x03D4EB30  set=0x0519C3C8
METHODS:
  RVA=0x09F0DA00  token=0x6000C6A  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView listView)
  RVA=0x09F0B758  token=0x6000C6B  System.Boolean CanStartDrag(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F0D224  token=0x6000C6C  UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F0D83C  token=0x6000C6D  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F0C0EC  token=0x6000C6E  UnityEngine.UIElements.DragVisualMode GetVisualMode(UnityEngine.Vector3 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
  RVA=0x09F0CC84  token=0x6000C6F  System.Void OnDrop(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F0C2E8  token=0x6000C70  System.Void HandleDragAndScroll(UnityEngine.Vector2 pointerPosition)
  RVA=0x09F0C25C  token=0x6000C71  System.Void HandleAutoExpansion(UnityEngine.Vector2 pointerPosition)
  RVA=0x09F0B12C  token=0x6000C72  System.Void ApplyDragAndDropUI(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition)
  RVA=0x09F0D478  token=0x6000C73  System.Boolean TryGetDragPosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
  RVA=0x09F0CA5C  token=0x6000C74  System.Void HandleTreePosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
  RVA=0x09F0C4C4  token=0x6000C75  System.Void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition, UnityEngine.Vector2 pointerPosition)
  RVA=0x09F0BD98  token=0x6000C76  System.Void GetPreviousAndNextItemsIgnoringDraggedItems(System.Int32 insertAtIndex, System.Int32& previousItemId, System.Int32& nextItemId)
  RVA=0x09F0CB2C  token=0x6000C77  UnityEngine.UIElements.DragAndDropArgs MakeDragAndDropArgs(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition)
  RVA=0x09F0BCC4  token=0x6000C78  System.Single GetHoverBarTopPosition(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=0x09F0CE70  token=0x6000C79  System.Void PlaceHoverBarAtElement(UnityEngine.UIElements.ReusableCollectionItem item)
  RVA=0x09F0CEA8  token=0x6000C7A  System.Void PlaceHoverBarAt(System.Single top, System.Single indentationPadding, System.Single siblingBottom)
  RVA=0x09F0B9D4  token=0x6000C7B  System.Void ClearDragAndDropUI(System.Boolean dragCancelled)
  RVA=0x09F0BF18  token=0x6000C7C  UnityEngine.UIElements.ReusableCollectionItem GetRecycledItem(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F0D7B4  token=0x6000C7D  System.Void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(UnityEngine.UIElements.GeometryChangedEvent e)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewDraggerExtension
TYPE:  static class
TOKEN: 0x20001B2
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F1C5A8  token=0x6000C81  UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromId(UnityEngine.UIElements.BaseVerticalCollectionView listView, System.Int32 id)
  RVA=0x09F1C6F8  token=0x6000C82  UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromIndex(UnityEngine.UIElements.BaseVerticalCollectionView listView, System.Int32 index)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewDraggerAnimated
TYPE:  class
TOKEN: 0x20001B3
SIZE:  0xB0
EXTENDS: UnityEngine.UIElements.ListViewDragger
FIELDS:
  private           System.Int32                    m_DragStartIndex  // 0x78
  private           System.Int32                    m_CurrentIndex  // 0x7c
  private           System.Single                   m_SelectionHeight  // 0x80
  private           System.Single                   m_LocalOffsetOnStart  // 0x84
  private           UnityEngine.Vector3             m_CurrentPointerPosition  // 0x88
  private           UnityEngine.UIElements.ReusableCollectionItemm_Item  // 0x98
  private           UnityEngine.UIElements.ReusableCollectionItemm_OffsetItem  // 0xa0
  private           System.Boolean                  <isDragging>k__BackingField  // 0xa8
PROPERTIES:
  isDragging  get=0x011B9C10  set=0x011B9C20
  draggedItem  get=0x011AC510
  supportsDragEvents  get=0x0115F4C0
METHODS:
  RVA=0x09F1C5A0  token=0x6000C87  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView listView)
  RVA=0x09F1B874  token=0x6000C88  UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F1BED8  token=0x6000C89  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  RVA=0x09F1B2D4  token=0x6000C8A  System.Void Animate(UnityEngine.UIElements.ReusableCollectionItem element, System.Single paddingTop)
  RVA=0x09F1B530  token=0x6000C8B  System.Void OnDrop(UnityEngine.Vector3 pointerPosition)
  RVA=0x0350B670  token=0x6000C8C  System.Void ClearDragAndDropUI(System.Boolean dragCancelled)
  RVA=0x09F1BEA4  token=0x6000C8D  System.Boolean TryGetDragPosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewReorderableDragAndDropController
TYPE:  class
TOKEN: 0x20001B4
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.BaseReorderableDragAndDropController
FIELDS:
  protected readonly UnityEngine.UIElements.BaseListViewm_ListView  // 0x28
METHODS:
  RVA=0x09F1CAE0  token=0x6000C8E  System.Void .ctor(UnityEngine.UIElements.BaseListView view)
  RVA=0x09F1C848  token=0x6000C8F  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  RVA=0x09F1C8B8  token=0x6000C90  System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewReorderableDragAndDropController
TYPE:  class
TOKEN: 0x20001B5
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.BaseReorderableDragAndDropController
FIELDS:
  protected         UnityEngine.UIElements.TreeViewReorderableDragAndDropController.DropDatam_DropData  // 0x28
  protected readonly UnityEngine.UIElements.BaseTreeViewm_TreeView  // 0x30
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ExpandDropItemScheduledItem  // 0x38
  private           System.Action                   m_ExpandDropItemCallback  // 0x40
METHODS:
  RVA=0x09F24168  token=0x6000C91  System.Void .ctor(UnityEngine.UIElements.BaseTreeView view)
  RVA=0x09F22F04  token=0x6000C92  System.Int32 CompareId(System.Int32 id1, System.Int32 id2)
  RVA=0x09F240A0  token=0x6000C93  UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, System.Boolean skipText)
  RVA=0x09F23940  token=0x6000C94  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  RVA=0x09F23998  token=0x6000C95  System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  RVA=0x09F23534  token=0x6000C96  System.Void DragCleanup()
  RVA=0x09F23EEC  token=0x6000C97  System.Void RestoreExpanded(System.Collections.Generic.List<System.Int32> ids)
  RVA=0x09F237B0  token=0x6000C98  System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition)
  RVA=0x09F234C8  token=0x6000C99  System.Void DelayExpandDropItem()
  RVA=0x09F2360C  token=0x6000C9A  System.Void ExpandDropItem()
END_CLASS

CLASS: UnityEngine.UIElements.IPointerCaptureEventInternal
TYPE:  interface
TOKEN: 0x20001B8
FIELDS:
PROPERTIES:
  pointerId  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureEventBase`1
TYPE:  abstract class
TOKEN: 0x20001B9
EXTENDS: UnityEngine.UIElements.EventBase`1
IMPLEMENTS: UnityEngine.UIElements.IPointerCaptureEventInternal
FIELDS:
  private           UnityEngine.UIElements.IEventHandler<relatedTarget>k__BackingField  // 0x0
  private           System.Int32                    <pointerId>k__BackingField  // 0x0
PROPERTIES:
  relatedTarget  set=-1  // not resolved
  pointerId  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000CA1  System.Void Init()
  RVA=-1  // not resolved  token=0x6000CA2  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000CA3  T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.IEventHandler relatedTarget, System.Int32 pointerId)
  RVA=-1  // not resolved  token=0x6000CA4  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureOutEvent
TYPE:  class
TOKEN: 0x20001BA
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.PointerCaptureEventBase`1
FIELDS:
METHODS:
  RVA=0x09F204C0  token=0x6000CA5  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureEvent
TYPE:  class
TOKEN: 0x20001BB
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.PointerCaptureEventBase`1
FIELDS:
METHODS:
  RVA=0x09F20484  token=0x6000CA6  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureEventBase`1
TYPE:  abstract class
TOKEN: 0x20001BC
EXTENDS: UnityEngine.UIElements.PointerCaptureEventBase`1
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000CA7  System.Void Init()
  RVA=-1  // not resolved  token=0x6000CA8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureOutEvent
TYPE:  class
TOKEN: 0x20001BD
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.MouseCaptureEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1CFE8  token=0x6000CA9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureEvent
TYPE:  class
TOKEN: 0x20001BE
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.MouseCaptureEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1CFAC  token=0x6000CAA  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ChangeEvent`1
TYPE:  class
TOKEN: 0x20001BF
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private           T                               <previousValue>k__BackingField  // 0x0
  private           T                               <newValue>k__BackingField  // 0x0
PROPERTIES:
  previousValue  get=-1  // not resolved  set=-1  // not resolved
  newValue  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000CAF  System.Void Init()
  RVA=-1  // not resolved  token=0x6000CB0  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000CB1  UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue)
  RVA=-1  // not resolved  token=0x6000CB2  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.CommandEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001C0
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F168D4  token=0x6000CB3  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F16914  token=0x6000CB4  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000CB5  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ICommandEvent
TYPE:  interface
TOKEN: 0x20001C1
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CommandEventBase`1
TYPE:  abstract class
TOKEN: 0x20001C2
EXTENDS: UnityEngine.UIElements.EventBase`1
IMPLEMENTS: UnityEngine.UIElements.ICommandEvent
FIELDS:
  private           System.String                   m_CommandName  // 0x0
PROPERTIES:
  commandName  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000CB8  System.Void Init()
  RVA=-1  // not resolved  token=0x6000CB9  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000CBA  T GetPooled(UnityEngine.Event systemEvent)
  RVA=-1  // not resolved  token=0x6000CBB  T GetPooled(System.String commandName)
  RVA=-1  // not resolved  token=0x6000CBC  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ValidateCommandEvent
TYPE:  class
TOKEN: 0x20001C3
SIZE:  0x88
EXTENDS: UnityEngine.UIElements.CommandEventBase`1
FIELDS:
METHODS:
  RVA=0x09F25EA4  token=0x6000CBD  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ExecuteCommandEvent
TYPE:  class
TOKEN: 0x20001C4
SIZE:  0x88
EXTENDS: UnityEngine.UIElements.CommandEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1A424  token=0x6000CBE  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DefaultDispatchingStrategy
TYPE:  class
TOKEN: 0x20001C5
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F170D0  token=0x6000CBF  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F17110  token=0x6000CC0  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000CC1  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ElementUnderPointer
TYPE:  class
TOKEN: 0x20001C6
SIZE:  0x40
FIELDS:
  private           UnityEngine.UIElements.VisualElement[]m_PendingTopElementUnderPointer  // 0x10
  private           UnityEngine.UIElements.VisualElement[]m_TopElementUnderPointer  // 0x18
  private           UnityEngine.UIElements.IPointerEvent[]m_TriggerPointerEvent  // 0x20
  private           UnityEngine.UIElements.IMouseEvent[]m_TriggerMouseEvent  // 0x28
  private           UnityEngine.Vector2[]           m_PickingPointerPositions  // 0x30
  private           System.Boolean[]                m_IsPickingPointerTemporaries  // 0x38
METHODS:
  RVA=0x09F180C8  token=0x6000CC2  UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId, UnityEngine.Vector2& pickPosition, System.Boolean& isTemporary)
  RVA=0x0594E120  token=0x6000CC3  UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId)
  RVA=0x09F18380  token=0x6000CC4  System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.Vector2 pointerPos)
  RVA=0x09F18008  token=0x6000CC5  UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase triggerEvent)
  RVA=0x09F184AC  token=0x6000CC6  System.Void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent)
  RVA=0x09F18364  token=0x6000CC7  System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent)
  RVA=0x09F18150  token=0x6000CC8  System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent, System.Boolean temporary)
  RVA=0x09F17460  token=0x6000CC9  System.Void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher dispatcher, UnityEngine.UIElements.ContextType contextType)
  RVA=0x09F184C8  token=0x6000CCA  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventBase
TYPE:  abstract class
TOKEN: 0x20001C7
SIZE:  0x78
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.Int64                    s_LastTypeId  // static @ 0x0
  private   static  System.UInt64                   s_NextEventId  // static @ 0x8
  private           System.Int64                    <timestamp>k__BackingField  // 0x10
  private           System.UInt64                   <eventId>k__BackingField  // 0x18
  private           System.UInt64                   <triggerEventId>k__BackingField  // 0x20
  private           UnityEngine.UIElements.EventBase.EventPropagation<propagation>k__BackingField  // 0x28
  private           UnityEngine.UIElements.PropagationPathsm_Path  // 0x30
  private           UnityEngine.UIElements.EventBase.LifeCycleStatus<lifeCycleStatus>k__BackingField  // 0x38
  private           UnityEngine.UIElements.IEventHandler<leafTarget>k__BackingField  // 0x40
  private           UnityEngine.UIElements.IEventHandlerm_Target  // 0x48
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler><skipElements>k__BackingField  // 0x50
  private           UnityEngine.UIElements.PropagationPhase<propagationPhase>k__BackingField  // 0x58
  private           UnityEngine.UIElements.IEventHandlerm_CurrentTarget  // 0x60
  private           UnityEngine.Event               m_ImguiEvent  // 0x68
  private           UnityEngine.Vector2             <originalMousePosition>k__BackingField  // 0x70
PROPERTIES:
  eventTypeId  get=0x03D6EF40
  timestamp  get=0x020B7B20  set=0x03D517C0
  eventId  get=0x01041090  set=0x03D4EC10
  triggerEventId  set=0x03D4ED30
  propagation  get=0x03D4EB90  set=0x03D4EBA0
  path  get=0x09F18A8C  set=0x09F18E00
  lifeCycleStatus  get=0x03D4EC30  set=0x03D4ECB0
  bubbles  get=0x09F18A38
  tricklesDown  get=0x09F18B88
  skipDisabledElements  get=0x09F18B78  set=0x09F18ED0
  ignoreCompositeRoots  get=0x09F18A54  set=0x09F18CB0
  leafTarget  get=0x03D4E2B0  set=0x03CB2D80
  target  get=0x03D87DB0  set=0x09F18F08
  skipElements  get=0x03D4EAF0
  isPropagationStopped  get=0x09F18A84  set=0x09F18DE4
  isImmediatePropagationStopped  get=0x09F18A7C  set=0x09F18DC8
  isDefaultPrevented  get=0x09F18A74  set=0x09F18DAC
  propagationPhase  get=0x03D4EF00  set=0x03D4EF50
  currentTarget  get=0x03D87D60  set=0x09F18B90
  dispatch  get=0x09F18A40  set=0x09F18C7C
  dispatched  get=0x09F18A48  set=0x09F18C94
  processed  get=0x09F18B60  set=0x09F18E98
  processedByFocusController  get=0x09F18B54  set=0x09F18E7C
  stopDispatch  get=0x09F18B80  set=0x09F18EEC
  propagateToIMGUI  get=0x09F18B6C  set=0x09F18EB4
  imguiEventIsValid  get=0x09F18A5C  set=0x09F18CCC
  imguiEvent  get=0x09F18A64  set=0x09F18CE8
  originalMousePosition  get=0x03D5B650  set=0x03D4EE60
  pooled  get=0x09F18B4C  set=0x09F18E60
METHODS:
  RVA=0x09F188F8  token=0x6000CCB  System.Int64 RegisterEventType()
  RVA=0x03D4ED30  token=0x6000CD2  System.Void SetTriggerEventId(System.UInt64 id)
  RVA=0x0350B670  token=0x6000CD9  System.Void PreDispatch()
  RVA=0x0350B670  token=0x6000CDA  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000CDB  System.Void PostDispatch()
  RVA=0x09F188E4  token=0x6000CDC  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=0x09F1893C  token=0x6000CE8  System.Boolean Skip(UnityEngine.UIElements.IEventHandler h)
  RVA=0x09F189A0  token=0x6000CEB  System.Void StopPropagation()
  RVA=0x09F18990  token=0x6000CEE  System.Void StopImmediatePropagation()
  RVA=0x09F188EC  token=0x6000CF1  System.Void PreventDefault()
  RVA=0x09F18878  token=0x6000CF8  System.Void MarkReceivedByDispatcher()
  RVA=0x09F18744  token=0x6000D09  System.Void Init()
  RVA=0x09F1874C  token=0x6000D0A  System.Void LocalInit()
  RVA=0x09F189A8  token=0x6000D0B  System.Void .ctor()
  RVA=-1  // abstract  token=0x6000D0E  System.Void Acquire()
  RVA=-1  // abstract  token=0x6000D0F  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventBase`1
TYPE:  abstract class
TOKEN: 0x20001CA
EXTENDS: UnityEngine.UIElements.EventBase
FIELDS:
  private   static readonly System.Int64                    s_TypeId  // static @ 0x0
  private   static readonly UnityEngine.UIElements.ObjectPool<T>s_Pool  // static @ 0x0
  private           System.Int32                    m_RefCount  // 0x0
PROPERTIES:
  eventTypeId  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000D10  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000D11  System.Int64 TypeId()
  RVA=-1  // not resolved  token=0x6000D12  System.Void Init()
  RVA=-1  // not resolved  token=0x6000D13  T GetPooled()
  RVA=-1  // not resolved  token=0x6000D14  T GetPooled(UnityEngine.UIElements.EventBase e)
  RVA=-1  // not resolved  token=0x6000D15  System.Void ReleasePooled(T evt)
  RVA=-1  // not resolved  token=0x6000D16  System.Void Acquire()
  RVA=-1  // not resolved  token=0x6000D17  System.Void Dispose()
  RVA=-1  // not resolved  token=0x6000D19  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventCallback`1
TYPE:  sealed class
TOKEN: 0x20001CB
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000D1A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000D1B  System.Void Invoke(TEventType evt)
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackFunctorBase
TYPE:  abstract class
TOKEN: 0x20001CC
SIZE:  0x18
FIELDS:
  private   readonly UnityEngine.UIElements.CallbackPhase<phase>k__BackingField  // 0x10
  private   readonly UnityEngine.UIElements.InvokePolicy<invokePolicy>k__BackingField  // 0x14
PROPERTIES:
  phase  get=0x03D4E340
  invokePolicy  get=0x03D50CC0
METHODS:
  RVA=0x03D50CB0  token=0x6000D1E  System.Void .ctor(UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy)
  RVA=-1  // abstract  token=0x6000D1F  System.Void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase)
  RVA=-1  // abstract  token=0x6000D20  System.Boolean IsEquivalentTo(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  RVA=0x09F18F38  token=0x6000D21  System.Boolean PhaseMatches(UnityEngine.UIElements.PropagationPhase propagationPhase)
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackFunctor`1
TYPE:  class
TOKEN: 0x20001CD
EXTENDS: UnityEngine.UIElements.EventCallbackFunctorBase
FIELDS:
  private   readonly UnityEngine.UIElements.EventCallback<TEventType>m_Callback  // 0x0
  private   readonly System.Int64                    m_EventTypeId  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000D22  System.Void .ctor(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy)
  RVA=-1  // not resolved  token=0x6000D23  System.Void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase)
  RVA=-1  // not resolved  token=0x6000D24  System.Boolean IsEquivalentTo(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
END_CLASS

CLASS: UnityEngine.UIElements.TrickleDown
TYPE:  sealed struct
TOKEN: 0x20001CE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TrickleDownNoTrickleDown  // const
  public    static  UnityEngine.UIElements.TrickleDownTrickleDown  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CallbackPhase
TYPE:  sealed struct
TOKEN: 0x20001CF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.CallbackPhaseTargetAndBubbleUp  // const
  public    static  UnityEngine.UIElements.CallbackPhaseTrickleDownAndTarget  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.InvokePolicy
TYPE:  sealed struct
TOKEN: 0x20001D0
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.InvokePolicyDefault  // const
  public    static  UnityEngine.UIElements.InvokePolicyIncludeDisabled  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackListPool
TYPE:  class
TOKEN: 0x20001D1
SIZE:  0x18
FIELDS:
  private   readonly System.Collections.Generic.Stack<UnityEngine.UIElements.EventCallbackList>m_Stack  // 0x10
METHODS:
  RVA=0x09F18F5C  token=0x6000D25  UnityEngine.UIElements.EventCallbackList Get(UnityEngine.UIElements.EventCallbackList initializer)
  RVA=0x09F19028  token=0x6000D26  System.Void Release(UnityEngine.UIElements.EventCallbackList element)
  RVA=0x09F1908C  token=0x6000D27  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackList
TYPE:  class
TOKEN: 0x20001D2
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase>m_List  // 0x10
  private           System.Int32                    <trickleDownCallbackCount>k__BackingField  // 0x18
  private           System.Int32                    <bubbleUpCallbackCount>k__BackingField  // 0x1c
PROPERTIES:
  trickleDownCallbackCount  get=0x020D1AC0  set=0x03D4E9C0
  bubbleUpCallbackCount  get=0x03D4EBB0  set=0x03D4EBC0
  Count  get=0x09F1963C
  Item  get=0x09F1967C
METHODS:
  RVA=0x09F19524  token=0x6000D2C  System.Void .ctor()
  RVA=0x09F195A4  token=0x6000D2D  System.Void .ctor(UnityEngine.UIElements.EventCallbackList source)
  RVA=0x09F1934C  token=0x6000D2E  System.Boolean Contains(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  RVA=0x09F1936C  token=0x6000D2F  UnityEngine.UIElements.EventCallbackFunctorBase Find(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  RVA=0x09F19438  token=0x6000D30  System.Boolean Remove(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  RVA=0x09F1928C  token=0x6000D31  System.Void Add(UnityEngine.UIElements.EventCallbackFunctorBase item)
  RVA=0x09F19104  token=0x6000D32  System.Void AddRange(UnityEngine.UIElements.EventCallbackList list)
  RVA=0x09F192FC  token=0x6000D35  System.Void Clear()
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackRegistry
TYPE:  class
TOKEN: 0x20001D3
SIZE:  0x28
FIELDS:
  private   static readonly UnityEngine.UIElements.EventCallbackListPools_ListPool  // static @ 0x0
  private           UnityEngine.UIElements.EventCallbackListm_Callbacks  // 0x10
  private           UnityEngine.UIElements.EventCallbackListm_TemporaryCallbacks  // 0x18
  private           System.Int32                    m_IsInvoking  // 0x20
METHODS:
  RVA=0x09F19784  token=0x6000D36  UnityEngine.UIElements.EventCallbackList GetCallbackList(UnityEngine.UIElements.EventCallbackList initializer)
  RVA=0x09F1999C  token=0x6000D37  System.Void ReleaseCallbackList(UnityEngine.UIElements.EventCallbackList toRelease)
  RVA=0x03D4E2C0  token=0x6000D38  System.Void .ctor()
  RVA=0x09F196E4  token=0x6000D39  UnityEngine.UIElements.EventCallbackList GetCallbackListForWriting()
  RVA=0x09F196D0  token=0x6000D3A  UnityEngine.UIElements.EventCallbackList GetCallbackListForReading()
  RVA=0x09F199FC  token=0x6000D3B  System.Boolean UnregisterCallback(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  RVA=-1  // generic def  token=0x6000D3C  System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown, UnityEngine.UIElements.InvokePolicy invokePolicy)
  RVA=-1  // generic def  token=0x6000D3D  System.Boolean UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  RVA=0x09F19814  token=0x6000D3E  System.Void InvokeCallbacks(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase)
  RVA=0x09F197FC  token=0x6000D3F  System.Boolean HasTrickleDownHandlers()
  RVA=0x09F197E4  token=0x6000D40  System.Boolean HasBubbleHandlers()
  RVA=0x09F19A6C  token=0x6000D41  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IEventHandler
TYPE:  interface
TOKEN: 0x20001D4
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000D42  System.Void SendEvent(UnityEngine.UIElements.EventBase e)
  RVA=-1  // abstract  token=0x6000D43  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.CallbackEventHandler
TYPE:  abstract class
TOKEN: 0x20001D5
SIZE:  0x20
IMPLEMENTS: UnityEngine.UIElements.IEventHandler
FIELDS:
  private           System.Boolean                  isIMGUIContainer  // 0x10
  private           UnityEngine.UIElements.EventCallbackRegistrym_CallbackRegistry  // 0x18
METHODS:
  RVA=-1  // generic def  token=0x6000D44  System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  RVA=-1  // generic def  token=0x6000D45  System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.InvokePolicy invokePolicy, UnityEngine.UIElements.TrickleDown useTrickleDown)
  RVA=-1  // generic def  token=0x6000D46  System.Void UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  RVA=-1  // abstract  token=0x6000D47  System.Void SendEvent(UnityEngine.UIElements.EventBase e)
  RVA=-1  // abstract  token=0x6000D48  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode)
  RVA=0x09F164D4  token=0x6000D49  System.Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F16490  token=0x6000D4A  System.Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase evt)
  RVA=0x0986C8A8  token=0x6000D4B  System.Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase evt)
  RVA=0x0986C8A8  token=0x6000D4C  System.Void UnityEngine.UIElements.IEventHandler.HandleEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F16534  token=0x6000D4D  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1677C  token=0x6000D4E  System.Boolean HasTrickleDownHandlers()
  RVA=0x09F16760  token=0x6000D4F  System.Boolean HasBubbleUpHandlers()
  RVA=0x0350B670  token=0x6000D50  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000D51  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000D52  System.Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000D53  System.Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt)
  RVA=0x03D557C0  token=0x6000D54  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusEventBase`1
TYPE:  abstract class
TOKEN: 0x20001D6
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private           UnityEngine.UIElements.Focusable<relatedTarget>k__BackingField  // 0x0
  private           UnityEngine.UIElements.FocusChangeDirection<direction>k__BackingField  // 0x0
  private           UnityEngine.UIElements.FocusController<focusController>k__BackingField  // 0x0
  private           System.Boolean                  <IsFocusDelegated>k__BackingField  // 0x0
PROPERTIES:
  relatedTarget  get=-1  // not resolved  set=-1  // not resolved
  direction  get=-1  // not resolved  set=-1  // not resolved
  focusController  get=-1  // not resolved  set=-1  // not resolved
  IsFocusDelegated  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000D5D  System.Void Init()
  RVA=-1  // not resolved  token=0x6000D5E  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000D5F  T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.Focusable relatedTarget, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.FocusController focusController, System.Boolean bIsFocusDelegated)
  RVA=-1  // not resolved  token=0x6000D60  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusOutEvent
TYPE:  class
TOKEN: 0x20001D7
SIZE:  0xA0
EXTENDS: UnityEngine.UIElements.FocusEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1A594  token=0x6000D61  System.Void Init()
  RVA=0x03D89170  token=0x6000D62  System.Void LocalInit()
  RVA=0x09F1A5D8  token=0x6000D63  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BlurEvent
TYPE:  class
TOKEN: 0x20001D8
SIZE:  0xA0
EXTENDS: UnityEngine.UIElements.FocusEventBase`1
FIELDS:
METHODS:
  RVA=0x09F163F4  token=0x6000D64  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=0x09F16454  token=0x6000D65  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusInEvent
TYPE:  class
TOKEN: 0x20001D9
SIZE:  0xA0
EXTENDS: UnityEngine.UIElements.FocusEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1A50C  token=0x6000D66  System.Void Init()
  RVA=0x03D89170  token=0x6000D67  System.Void LocalInit()
  RVA=0x09F1A550  token=0x6000D68  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusEvent
TYPE:  class
TOKEN: 0x20001DA
SIZE:  0xA0
EXTENDS: UnityEngine.UIElements.FocusEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1A460  token=0x6000D69  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=0x09F1A4D0  token=0x6000D6A  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PropagationPhase
TYPE:  sealed struct
TOKEN: 0x20001DB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PropagationPhaseNone  // const
  public    static  UnityEngine.UIElements.PropagationPhaseTrickleDown  // const
  public    static  UnityEngine.UIElements.PropagationPhaseAtTarget  // const
  public    static  UnityEngine.UIElements.PropagationPhaseDefaultActionAtTarget  // const
  public    static  UnityEngine.UIElements.PropagationPhaseBubbleUp  // const
  public    static  UnityEngine.UIElements.PropagationPhaseDefaultAction  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IEventDispatchingStrategy
TYPE:  interface
TOKEN: 0x20001DC
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000D6B  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=-1  // abstract  token=0x6000D6C  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.EventDispatchUtilities
TYPE:  static class
TOKEN: 0x20001DD
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F19B94  token=0x6000D6D  System.Void PropagateEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1A250  token=0x6000D6E  System.Void PropagateToIMGUIContainer(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.EventBase evt)
  RVA=0x09F19AE8  token=0x6000D6F  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.IMGUIEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001DE
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F1ACFC  token=0x6000D70  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1AD3C  token=0x6000D71  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000D72  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.InputEvent
TYPE:  class
TOKEN: 0x20001DF
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private           System.String                   <previousData>k__BackingField  // 0x80
  private           System.String                   <newData>k__BackingField  // 0x88
PROPERTIES:
  previousData  set=0x051DFC94
  newData  set=0x04274DA0
METHODS:
  RVA=0x09F1AF2C  token=0x6000D75  System.Void Init()
  RVA=0x09F1AF70  token=0x6000D76  System.Void LocalInit()
  RVA=0x09F1AE98  token=0x6000D77  UnityEngine.UIElements.InputEvent GetPooled(System.String previousData, System.String newData)
  RVA=0x09F1AFA8  token=0x6000D78  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001E0
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F1B148  token=0x6000D79  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1B188  token=0x6000D7A  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000D7B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IKeyboardEvent
TYPE:  interface
TOKEN: 0x20001E1
FIELDS:
PROPERTIES:
  modifiers  get=-1  // abstract
  character  get=-1  // abstract
  keyCode  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardEventBase`1
TYPE:  abstract class
TOKEN: 0x20001E2
EXTENDS: UnityEngine.UIElements.EventBase`1
IMPLEMENTS: UnityEngine.UIElements.IKeyboardEvent
FIELDS:
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           System.Char                     <character>k__BackingField  // 0x0
  private           UnityEngine.KeyCode             <keyCode>k__BackingField  // 0x0
PROPERTIES:
  modifiers  get=-1  // not resolved  set=-1  // not resolved
  character  get=-1  // not resolved  set=-1  // not resolved
  keyCode  get=-1  // not resolved  set=-1  // not resolved
  shiftKey  get=-1  // not resolved
  ctrlKey  get=-1  // not resolved
  commandKey  get=-1  // not resolved
  altKey  get=-1  // not resolved
  actionKey  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000D8A  System.Void Init()
  RVA=-1  // not resolved  token=0x6000D8B  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000D8C  T GetPooled(System.Char c, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers)
  RVA=-1  // not resolved  token=0x6000D8D  T GetPooled(UnityEngine.Event systemEvent)
  RVA=-1  // not resolved  token=0x6000D8E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.KeyDownEvent
TYPE:  class
TOKEN: 0x20001E3
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.KeyboardEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1B004  token=0x6000D8F  System.Void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent)
  RVA=0x09F1B0D0  token=0x6000D90  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.KeyUpEvent
TYPE:  class
TOKEN: 0x20001E4
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.KeyboardEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1B10C  token=0x6000D91  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.GeometryChangedEvent
TYPE:  class
TOKEN: 0x20001E5
SIZE:  0xA8
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private           UnityEngine.Rect                <oldRect>k__BackingField  // 0x80
  private           UnityEngine.Rect                <newRect>k__BackingField  // 0x90
  private           System.Int32                    <layoutPass>k__BackingField  // 0xa0
PROPERTIES:
  oldRect  get=0x03D5AAF0  set=0x03D68EB0
  newRect  get=0x03D68BC0  set=0x03D6C0C0
  layoutPass  get=0x03D50E50  set=0x03D50F20
METHODS:
  RVA=0x09F1ABE0  token=0x6000D92  UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect oldRect, UnityEngine.Rect newRect)
  RVA=0x09F1AC5C  token=0x6000D93  System.Void Init()
  RVA=0x03D89180  token=0x6000D94  System.Void LocalInit()
  RVA=0x09F1ACA0  token=0x6000D9B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureDispatchingStrategy
TYPE:  class
TOKEN: 0x20001E6
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F1CB10  token=0x6000D9C  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1CB78  token=0x6000D9D  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000D9E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001E8
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F1D318  token=0x6000D9F  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1D358  token=0x6000DA0  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel iPanel)
  RVA=0x09F1D5DC  token=0x6000DA1  System.Boolean SendEventToTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09F1D5A8  token=0x6000DA2  System.Boolean SendEventToRegularTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09F1D448  token=0x6000DA3  System.Boolean SendEventToIMGUIContainer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09F1D618  token=0x6000DA4  System.Void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09F1D69C  token=0x6000DA5  System.Void UpdateElementUnderMouse(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel, UnityEngine.UIElements.VisualElement& elementUnderMouse)
  RVA=0x09F1D408  token=0x6000DA6  System.Boolean IsDone(UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000DA7  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IMouseEvent
TYPE:  interface
TOKEN: 0x20001E9
FIELDS:
PROPERTIES:
  modifiers  get=-1  // abstract
  mousePosition  get=-1  // abstract
  localMousePosition  get=-1  // abstract
  mouseDelta  get=-1  // abstract
  clickCount  get=-1  // abstract
  button  get=-1  // abstract
  pressedButtons  get=-1  // abstract
  shiftKey  get=-1  // abstract
  ctrlKey  get=-1  // abstract
  commandKey  get=-1  // abstract
  altKey  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IMouseEventInternal
TYPE:  interface
TOKEN: 0x20001EA
FIELDS:
PROPERTIES:
  triggeredByOS  get=-1  // abstract  set=-1  // abstract
  recomputeTopElementUnderMouse  get=-1  // abstract  set=-1  // abstract
  sourcePointerEvent  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.MouseEventBase`1
TYPE:  abstract class
TOKEN: 0x20001EB
EXTENDS: UnityEngine.UIElements.EventBase`1
IMPLEMENTS: UnityEngine.UIElements.IMouseEvent UnityEngine.UIElements.IMouseEventInternal
FIELDS:
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <mousePosition>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <localMousePosition>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <mouseDelta>k__BackingField  // 0x0
  private           System.Int32                    <clickCount>k__BackingField  // 0x0
  private           System.Int32                    <button>k__BackingField  // 0x0
  private           System.Int32                    <pressedButtons>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField  // 0x0
  private           UnityEngine.UIElements.IPointerEvent<UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField  // 0x0
PROPERTIES:
  modifiers  get=-1  // not resolved  set=-1  // not resolved
  mousePosition  get=-1  // not resolved  set=-1  // not resolved
  localMousePosition  get=-1  // not resolved  set=-1  // not resolved
  mouseDelta  get=-1  // not resolved  set=-1  // not resolved
  clickCount  get=-1  // not resolved  set=-1  // not resolved
  button  get=-1  // not resolved  set=-1  // not resolved
  pressedButtons  get=-1  // not resolved  set=-1  // not resolved
  shiftKey  get=-1  // not resolved
  ctrlKey  get=-1  // not resolved
  commandKey  get=-1  // not resolved
  altKey  get=-1  // not resolved
  UnityEngine.UIElements.IMouseEventInternal.triggeredByOS  get=-1  // not resolved  set=-1  // not resolved
  UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse  get=-1  // not resolved  set=-1  // not resolved
  UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent  get=-1  // not resolved  set=-1  // not resolved
  currentTarget  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000DD1  System.Void Init()
  RVA=-1  // not resolved  token=0x6000DD2  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000DD5  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=-1  // not resolved  token=0x6000DD6  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=-1  // not resolved  token=0x6000DD7  T GetPooled(UnityEngine.Event systemEvent)
  RVA=-1  // not resolved  token=0x6000DD8  T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition, System.Boolean recomputeTopElementUnderMouse)
  RVA=-1  // not resolved  token=0x6000DD9  T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent)
  RVA=-1  // not resolved  token=0x6000DDA  T GetPooled(UnityEngine.UIElements.IPointerEvent pointerEvent)
  RVA=-1  // not resolved  token=0x6000DDB  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseDownEvent
TYPE:  class
TOKEN: 0x20001EC
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1D030  token=0x6000DDC  System.Void Init()
  RVA=0x03D89160  token=0x6000DDD  System.Void LocalInit()
  RVA=0x09F1D128  token=0x6000DDE  System.Void .ctor()
  RVA=0x09F1D074  token=0x6000DDF  UnityEngine.UIElements.MouseDownEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent)
  RVA=0x09F1D024  token=0x6000DE0  UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerDownEvent pointerEvent)
  RVA=0x09F1D024  token=0x6000DE1  UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.MouseUpEvent
TYPE:  class
TOKEN: 0x20001ED
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1DE3C  token=0x6000DE2  System.Void Init()
  RVA=0x03D89160  token=0x6000DE3  System.Void LocalInit()
  RVA=0x09F1DF34  token=0x6000DE4  System.Void .ctor()
  RVA=0x09F1DE80  token=0x6000DE5  UnityEngine.UIElements.MouseUpEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent)
  RVA=0x09F1DE30  token=0x6000DE6  UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent)
  RVA=0x09F1DE30  token=0x6000DE7  UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent)
  RVA=0x09F1DE30  token=0x6000DE8  UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerCancelEvent pointerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.MouseMoveEvent
TYPE:  class
TOKEN: 0x20001EE
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1DD30  token=0x6000DE9  System.Void Init()
  RVA=0x03D891A0  token=0x6000DEA  System.Void LocalInit()
  RVA=0x09F1DD74  token=0x6000DEB  System.Void .ctor()
  RVA=0x09F1DCF4  token=0x6000DEC  UnityEngine.UIElements.MouseMoveEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.ContextClickEvent
TYPE:  class
TOKEN: 0x20001EF
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F16AA4  token=0x6000DED  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.WheelEvent
TYPE:  class
TOKEN: 0x20001F0
SIZE:  0xC8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
  private           UnityEngine.Vector3             <delta>k__BackingField  // 0xb8
PROPERTIES:
  delta  get=0x03D505C0  set=0x03D50630
METHODS:
  RVA=0x09F25EE0  token=0x6000DF0  UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Event systemEvent)
  RVA=0x09F25F74  token=0x6000DF1  UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Vector3 delta, UnityEngine.UIElements.IPointerEvent pointerEvent)
  RVA=0x09F25FE0  token=0x6000DF2  System.Void Init()
  RVA=0x09F2603C  token=0x6000DF3  System.Void LocalInit()
  RVA=0x09F26060  token=0x6000DF4  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseEnterEvent
TYPE:  class
TOKEN: 0x20001F1
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1D16C  token=0x6000DF5  System.Void Init()
  RVA=0x03D891B0  token=0x6000DF6  System.Void LocalInit()
  RVA=0x09F1D1B0  token=0x6000DF7  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseLeaveEvent
TYPE:  class
TOKEN: 0x20001F2
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1DA94  token=0x6000DF8  System.Void Init()
  RVA=0x03D891B0  token=0x6000DF9  System.Void LocalInit()
  RVA=0x09F1DAD8  token=0x6000DFA  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseEnterWindowEvent
TYPE:  class
TOKEN: 0x20001F3
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1D1F4  token=0x6000DFB  System.Void Init()
  RVA=0x03D891C0  token=0x6000DFC  System.Void LocalInit()
  RVA=0x09F1D2D4  token=0x6000DFD  System.Void .ctor()
  RVA=0x09F1D238  token=0x6000DFE  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.MouseLeaveWindowEvent
TYPE:  class
TOKEN: 0x20001F4
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1DBB0  token=0x6000DFF  System.Void Init()
  RVA=0x09F1DBFC  token=0x6000E00  System.Void LocalInit()
  RVA=0x09F1DCA8  token=0x6000E01  System.Void .ctor()
  RVA=0x09F1DB1C  token=0x6000E02  UnityEngine.UIElements.MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent)
  RVA=0x09F1DC0C  token=0x6000E03  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.MouseOverEvent
TYPE:  class
TOKEN: 0x20001F5
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1DDF4  token=0x6000E04  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseOutEvent
TYPE:  class
TOKEN: 0x20001F6
SIZE:  0xB8
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1DDB8  token=0x6000E05  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ContextualMenuPopulateEvent
TYPE:  class
TOKEN: 0x20001F7
SIZE:  0xD0
EXTENDS: UnityEngine.UIElements.MouseEventBase`1
FIELDS:
  private           UnityEngine.UIElements.DropdownMenu<menu>k__BackingField  // 0xb8
  private           UnityEngine.UIElements.EventBase<triggerEvent>k__BackingField  // 0xc0
  private           UnityEngine.UIElements.ContextualMenuManagerm_ContextualMenuManager  // 0xc8
PROPERTIES:
  menu  get=0x03D4E750  set=0x058AAF64
  triggerEvent  get=0x03D50E60  set=0x058B426C
METHODS:
  RVA=0x09F16AE0  token=0x6000E0A  UnityEngine.UIElements.ContextualMenuPopulateEvent GetPooled(UnityEngine.UIElements.EventBase triggerEvent, UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.ContextualMenuManager menuManager)
  RVA=0x09F16E5C  token=0x6000E0B  System.Void Init()
  RVA=0x09F16EA0  token=0x6000E0C  System.Void LocalInit()
  RVA=0x09F16FDC  token=0x6000E0D  System.Void .ctor()
  RVA=0x09F16F08  token=0x6000E0E  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.MouseEventsHelper
TYPE:  static class
TOKEN: 0x20001F8
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000E0F  System.Void SendEnterLeave(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition)
  RVA=0x09F1D890  token=0x6000E10  System.Void SendMouseOverMouseOut(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition)
END_CLASS

CLASS: UnityEngine.UIElements.PointerEventsHelper
TYPE:  static class
TOKEN: 0x20001F9
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000E11  System.Void SendEnterLeave(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId)
  RVA=0x09F21254  token=0x6000E12  System.Void SendOverOut(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId)
END_CLASS

CLASS: UnityEngine.UIElements.NavigationEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001FA
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F1EC98  token=0x6000E13  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F1ECD8  token=0x6000E14  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000E15  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.INavigationEvent
TYPE:  interface
TOKEN: 0x20001FB
FIELDS:
PROPERTIES:
  shiftKey  get=-1  // abstract
  altKey  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.NavigationDeviceType
TYPE:  sealed struct
TOKEN: 0x20001FC
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.NavigationDeviceTypeUnknown  // const
  public    static  UnityEngine.UIElements.NavigationDeviceTypeKeyboard  // const
  public    static  UnityEngine.UIElements.NavigationDeviceTypeNonKeyboard  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.NavigationEventBase`1
TYPE:  abstract class
TOKEN: 0x20001FD
EXTENDS: UnityEngine.UIElements.EventBase`1
IMPLEMENTS: UnityEngine.UIElements.INavigationEvent
FIELDS:
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           UnityEngine.UIElements.NavigationDeviceType<deviceType>k__BackingField  // 0x0
PROPERTIES:
  modifiers  get=-1  // not resolved  set=-1  // not resolved
  shiftKey  get=-1  // not resolved
  altKey  get=-1  // not resolved
  deviceType  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000E1D  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000E1E  System.Void Init()
  RVA=-1  // not resolved  token=0x6000E1F  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000E20  T GetPooled(UnityEngine.EventModifiers modifiers)
  RVA=-1  // not resolved  token=0x6000E21  T GetPooled(UnityEngine.UIElements.NavigationDeviceType deviceType, UnityEngine.EventModifiers modifiers)
END_CLASS

CLASS: UnityEngine.UIElements.NavigationMoveEvent
TYPE:  class
TOKEN: 0x20001FE
SIZE:  0x98
EXTENDS: UnityEngine.UIElements.NavigationEventBase`1
FIELDS:
  private           UnityEngine.UIElements.NavigationMoveEvent.Direction<direction>k__BackingField  // 0x88
  private           UnityEngine.Vector2             <move>k__BackingField  // 0x8c
PROPERTIES:
  direction  get=0x03D4F0B0  set=0x03D4F0E0
  move  set=0x03D68020
METHODS:
  RVA=0x09F1ED54  token=0x6000E22  UnityEngine.UIElements.NavigationMoveEvent.Direction DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone)
  RVA=0x09F1EDC4  token=0x6000E26  UnityEngine.UIElements.NavigationMoveEvent GetPooled(UnityEngine.Vector2 moveVector, UnityEngine.EventModifiers modifiers)
  RVA=0x09F1EE60  token=0x6000E27  System.Void Init()
  RVA=0x09F1EEBC  token=0x6000E28  System.Void .ctor()
  RVA=0x09F1EEAC  token=0x6000E29  System.Void LocalInit()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationTabEvent
TYPE:  class
TOKEN: 0x2000200
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.NavigationEventBase`1
FIELDS:
  private           UnityEngine.UIElements.NavigationTabEvent.Direction<direction>k__BackingField  // 0x88
PROPERTIES:
  direction  set=0x03D4F0E0
METHODS:
  RVA=0x09F1EF44  token=0x6000E2B  UnityEngine.UIElements.NavigationTabEvent.Direction DetermineMoveDirection(System.Int32 moveValue)
  RVA=0x09F1EF58  token=0x6000E2C  UnityEngine.UIElements.NavigationTabEvent GetPooled(System.Int32 moveValue)
  RVA=0x09F1EFBC  token=0x6000E2D  System.Void Init()
  RVA=0x09F1F000  token=0x6000E2E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationCancelEvent
TYPE:  class
TOKEN: 0x2000202
SIZE:  0x88
EXTENDS: UnityEngine.UIElements.NavigationEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1EC5C  token=0x6000E2F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationSubmitEvent
TYPE:  class
TOKEN: 0x2000203
SIZE:  0x88
EXTENDS: UnityEngine.UIElements.NavigationEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1EF08  token=0x6000E30  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelChangedEventBase`1
TYPE:  abstract class
TOKEN: 0x2000204
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private           UnityEngine.UIElements.IPanel   <originPanel>k__BackingField  // 0x0
  private           UnityEngine.UIElements.IPanel   <destinationPanel>k__BackingField  // 0x0
PROPERTIES:
  originPanel  get=-1  // not resolved  set=-1  // not resolved
  destinationPanel  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000E35  System.Void Init()
  RVA=-1  // not resolved  token=0x6000E36  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000E37  T GetPooled(UnityEngine.UIElements.IPanel originPanel, UnityEngine.UIElements.IPanel destinationPanel)
  RVA=-1  // not resolved  token=0x6000E38  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.AttachToPanelEvent
TYPE:  class
TOKEN: 0x2000205
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.PanelChangedEventBase`1
FIELDS:
METHODS:
  RVA=0x09F163B8  token=0x6000E39  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DetachFromPanelEvent
TYPE:  class
TOKEN: 0x2000206
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.PanelChangedEventBase`1
FIELDS:
METHODS:
  RVA=0x09F17260  token=0x6000E3A  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureDispatchingStrategy
TYPE:  class
TOKEN: 0x2000207
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F20168  token=0x6000E3B  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F201A8  token=0x6000E3C  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x0350B670  token=0x6000E3D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerDeviceState
TYPE:  static class
TOKEN: 0x2000208
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.UIElements.PointerDeviceState.PointerLocation[]s_PlayerPointerLocations  // static @ 0x0
  private   static  System.Int32[]                  s_PressedButtons  // static @ 0x8
  private   static readonly UnityEngine.UIElements.IPanel[] s_PlayerPanelWithSoftPointerCapture  // static @ 0x10
METHODS:
  RVA=0x09F20934  token=0x6000E3E  System.Void RemovePanelData(UnityEngine.UIElements.IPanel panel)
  RVA=0x09F20A8C  token=0x6000E3F  System.Void SavePointerPosition(System.Int32 pointerId, UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.ContextType contextType)
  RVA=0x09F20780  token=0x6000E40  System.Void PressButton(System.Int32 pointerId, System.Int32 buttonId)
  RVA=0x09F2088C  token=0x6000E41  System.Void ReleaseButton(System.Int32 pointerId, System.Int32 buttonId)
  RVA=0x09F20828  token=0x6000E42  System.Void ReleaseAllButtons(System.Int32 pointerId)
  RVA=0x09F205C0  token=0x6000E43  UnityEngine.Vector2 GetPointerPosition(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType)
  RVA=0x09F204FC  token=0x6000E44  UnityEngine.UIElements.IPanel GetPanel(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType)
  RVA=0x091AEB04  token=0x6000E45  System.Boolean HasFlagFast(UnityEngine.UIElements.PointerDeviceState.LocationFlag flagSet, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag)
  RVA=0x09F2070C  token=0x6000E46  System.Boolean HasLocationFlag(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag)
  RVA=0x09F2062C  token=0x6000E47  System.Int32 GetPressedButtons(System.Int32 pointerId)
  RVA=0x09F20690  token=0x6000E48  System.Boolean HasAdditionalPressedButtons(System.Int32 pointerId, System.Int32 exceptButtonId)
  RVA=0x09F20B18  token=0x6000E49  System.Void SetPlayerPanelWithSoftPointerCapture(System.Int32 pointerId, UnityEngine.UIElements.IPanel panel)
  RVA=0x09F2055C  token=0x6000E4A  UnityEngine.UIElements.IPanel GetPlayerPanelWithSoftPointerCapture(System.Int32 pointerId)
  RVA=0x09F20B9C  token=0x6000E4B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerEventDispatchingStrategy
TYPE:  class
TOKEN: 0x200020B
SIZE:  0x10
IMPLEMENTS: UnityEngine.UIElements.IEventDispatchingStrategy
FIELDS:
METHODS:
  RVA=0x09F20F4C  token=0x6000E53  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F20F8C  token=0x6000E54  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x09F20FC8  token=0x6000E55  System.Void SendEventToTarget(UnityEngine.UIElements.EventBase evt)
  RVA=0x09F20FF0  token=0x6000E56  System.Void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  RVA=0x09F21114  token=0x6000E57  System.Void UpdateElementUnderPointer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.VisualElement& elementUnderPointer)
  RVA=0x0350B670  token=0x6000E58  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerType
TYPE:  static class
TOKEN: 0x200020C
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   mouse  // static @ 0x0
  public    static readonly System.String                   touch  // static @ 0x8
  public    static readonly System.String                   pen  // static @ 0x10
  public    static readonly System.String                   unknown  // static @ 0x18
METHODS:
  RVA=0x09F21A8C  token=0x6000E59  System.String GetPointerType(System.Int32 pointerId)
  RVA=0x09F21B18  token=0x6000E5A  System.Boolean IsDirectManipulationDevice(System.String pointerType)
  RVA=0x09F21B8C  token=0x6000E5B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerId
TYPE:  static class
TOKEN: 0x200020D
SIZE:  0x10
FIELDS:
  public    static readonly System.Int32                    maxPointers  // static @ 0x0
  public    static readonly System.Int32                    invalidPointerId  // static @ 0x4
  public    static readonly System.Int32                    mousePointerId  // static @ 0x8
  public    static readonly System.Int32                    touchPointerIdBase  // static @ 0xc
  public    static readonly System.Int32                    touchPointerCount  // static @ 0x10
  public    static readonly System.Int32                    penPointerIdBase  // static @ 0x14
  public    static readonly System.Int32                    penPointerCount  // static @ 0x18
  private   static readonly System.Int32[]                  hoveringPointers  // static @ 0x20
METHODS:
  RVA=0x03B5B2B0  token=0x6000E5C  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IPointerEvent
TYPE:  interface
TOKEN: 0x200020E
FIELDS:
PROPERTIES:
  pointerId  get=-1  // abstract
  pointerType  get=-1  // abstract
  isPrimary  get=-1  // abstract
  button  get=-1  // abstract
  pressedButtons  get=-1  // abstract
  position  get=-1  // abstract
  localPosition  get=-1  // abstract
  deltaPosition  get=-1  // abstract
  deltaTime  get=-1  // abstract
  clickCount  get=-1  // abstract
  pressure  get=-1  // abstract
  tangentialPressure  get=-1  // abstract
  altitudeAngle  get=-1  // abstract
  azimuthAngle  get=-1  // abstract
  twist  get=-1  // abstract
  radius  get=-1  // abstract
  radiusVariance  get=-1  // abstract
  modifiers  get=-1  // abstract
  shiftKey  get=-1  // abstract
  ctrlKey  get=-1  // abstract
  commandKey  get=-1  // abstract
  altKey  get=-1  // abstract
  actionKey  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IPointerEventInternal
TYPE:  interface
TOKEN: 0x200020F
FIELDS:
PROPERTIES:
  triggeredByOS  get=-1  // abstract  set=-1  // abstract
  recomputeTopElementUnderPointer  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PointerEventBase`1
TYPE:  abstract class
TOKEN: 0x2000210
EXTENDS: UnityEngine.UIElements.EventBase`1
IMPLEMENTS: UnityEngine.UIElements.IPointerEvent UnityEngine.UIElements.IPointerEventInternal
FIELDS:
  private           System.Int32                    <pointerId>k__BackingField  // 0x0
  private           System.String                   <pointerType>k__BackingField  // 0x0
  private           System.Boolean                  <isPrimary>k__BackingField  // 0x0
  private           System.Int32                    <button>k__BackingField  // 0x0
  private           System.Int32                    <pressedButtons>k__BackingField  // 0x0
  private           UnityEngine.Vector3             <position>k__BackingField  // 0x0
  private           UnityEngine.Vector3             <localPosition>k__BackingField  // 0x0
  private           UnityEngine.Vector3             <deltaPosition>k__BackingField  // 0x0
  private           System.Single                   <deltaTime>k__BackingField  // 0x0
  private           System.Int32                    <clickCount>k__BackingField  // 0x0
  private           System.Single                   <pressure>k__BackingField  // 0x0
  private           System.Single                   <tangentialPressure>k__BackingField  // 0x0
  private           System.Single                   <altitudeAngle>k__BackingField  // 0x0
  private           System.Single                   <azimuthAngle>k__BackingField  // 0x0
  private           System.Single                   <twist>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <radius>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <radiusVariance>k__BackingField  // 0x0
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField  // 0x0
PROPERTIES:
  pointerId  get=-1  // not resolved  set=-1  // not resolved
  pointerType  get=-1  // not resolved  set=-1  // not resolved
  isPrimary  get=-1  // not resolved  set=-1  // not resolved
  button  get=-1  // not resolved  set=-1  // not resolved
  pressedButtons  get=-1  // not resolved  set=-1  // not resolved
  position  get=-1  // not resolved  set=-1  // not resolved
  localPosition  get=-1  // not resolved  set=-1  // not resolved
  deltaPosition  get=-1  // not resolved  set=-1  // not resolved
  deltaTime  get=-1  // not resolved  set=-1  // not resolved
  clickCount  get=-1  // not resolved  set=-1  // not resolved
  pressure  get=-1  // not resolved  set=-1  // not resolved
  tangentialPressure  get=-1  // not resolved  set=-1  // not resolved
  altitudeAngle  get=-1  // not resolved  set=-1  // not resolved
  azimuthAngle  get=-1  // not resolved  set=-1  // not resolved
  twist  get=-1  // not resolved  set=-1  // not resolved
  radius  get=-1  // not resolved  set=-1  // not resolved
  radiusVariance  get=-1  // not resolved  set=-1  // not resolved
  modifiers  get=-1  // not resolved  set=-1  // not resolved
  shiftKey  get=-1  // not resolved
  ctrlKey  get=-1  // not resolved
  commandKey  get=-1  // not resolved
  altKey  get=-1  // not resolved
  actionKey  get=-1  // not resolved
  UnityEngine.UIElements.IPointerEventInternal.triggeredByOS  get=-1  // not resolved  set=-1  // not resolved
  UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer  get=-1  // not resolved  set=-1  // not resolved
  currentTarget  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000EA5  System.Void Init()
  RVA=-1  // not resolved  token=0x6000EA6  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000EA9  System.Boolean IsMouse(UnityEngine.Event systemEvent)
  RVA=-1  // not resolved  token=0x6000EAA  T GetPooled(UnityEngine.Event systemEvent)
  RVA=-1  // not resolved  token=0x6000EAB  T GetPooled(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers)
  RVA=-1  // not resolved  token=0x6000EAC  T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId)
  RVA=-1  // not resolved  token=0x6000EAD  T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent)
  RVA=-1  // not resolved  token=0x6000EAE  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=-1  // not resolved  token=0x6000EAF  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
  RVA=-1  // not resolved  token=0x6000EB0  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerDownEvent
TYPE:  sealed class
TOKEN: 0x2000211
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F20CC8  token=0x6000EB1  System.Void Init()
  RVA=0x09F20D0C  token=0x6000EB2  System.Void LocalInit()
  RVA=0x09F20E80  token=0x6000EB3  System.Void .ctor()
  RVA=0x09F20D34  token=0x6000EB4  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.PointerMoveEvent
TYPE:  sealed class
TOKEN: 0x2000212
SIZE:  0x100
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
  private           System.Boolean                  <isHandledByDraggable>k__BackingField  // 0xf8
PROPERTIES:
  isHandledByDraggable  get=0x03D57BB0  set=0x03D89210
METHODS:
  RVA=0x09F21570  token=0x6000EB7  System.Void Init()
  RVA=0x09F215B4  token=0x6000EB8  System.Void LocalInit()
  RVA=0x09F21920  token=0x6000EB9  System.Void .ctor()
  RVA=0x09F215E4  token=0x6000EBA  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.PointerStationaryEvent
TYPE:  sealed class
TOKEN: 0x2000213
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F219DC  token=0x6000EBB  System.Void Init()
  RVA=0x09F21A20  token=0x6000EBC  System.Void LocalInit()
  RVA=0x09F21A48  token=0x6000EBD  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerUpEvent
TYPE:  sealed class
TOKEN: 0x2000214
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F21C9C  token=0x6000EBE  System.Void Init()
  RVA=0x09F20D0C  token=0x6000EBF  System.Void LocalInit()
  RVA=0x09F21EA4  token=0x6000EC0  System.Void .ctor()
  RVA=0x09F21CE0  token=0x6000EC1  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.PointerCancelEvent
TYPE:  sealed class
TOKEN: 0x2000215
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1FF00  token=0x6000EC2  System.Void Init()
  RVA=0x09F1FF44  token=0x6000EC3  System.Void LocalInit()
  RVA=0x09F20124  token=0x6000EC4  System.Void .ctor()
  RVA=0x09F1FF6C  token=0x6000EC5  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.ClickEvent
TYPE:  sealed class
TOKEN: 0x2000216
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F1684C  token=0x6000EC6  System.Void Init()
  RVA=0x03D89160  token=0x6000EC7  System.Void LocalInit()
  RVA=0x09F16890  token=0x6000EC8  System.Void .ctor()
  RVA=0x09F167E8  token=0x6000EC9  UnityEngine.UIElements.ClickEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent, System.Int32 clickCount)
END_CLASS

CLASS: UnityEngine.UIElements.PointerEnterEvent
TYPE:  sealed class
TOKEN: 0x2000217
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F20EC4  token=0x6000ECA  System.Void Init()
  RVA=0x03D89200  token=0x6000ECB  System.Void LocalInit()
  RVA=0x09F20F08  token=0x6000ECC  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerLeaveEvent
TYPE:  sealed class
TOKEN: 0x2000218
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F21464  token=0x6000ECD  System.Void Init()
  RVA=0x03D89200  token=0x6000ECE  System.Void LocalInit()
  RVA=0x09F214A8  token=0x6000ECF  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerOverEvent
TYPE:  sealed class
TOKEN: 0x2000219
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F219A0  token=0x6000ED0  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerOutEvent
TYPE:  sealed class
TOKEN: 0x200021A
SIZE:  0xF8
EXTENDS: UnityEngine.UIElements.PointerEventBase`1
FIELDS:
METHODS:
  RVA=0x09F21964  token=0x6000ED1  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PropagationPaths
TYPE:  class
TOKEN: 0x200021B
SIZE:  0x28
FIELDS:
  private   static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.PropagationPaths>s_Pool  // static @ 0x0
  public    readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>trickleDownPath  // 0x10
  public    readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>targetElements  // 0x18
  public    readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>bubbleUpPath  // 0x20
  private   static  System.Int32                    k_DefaultPropagationDepth  // const
  private   static  System.Int32                    k_DefaultTargetCount  // const
METHODS:
  RVA=0x09F22298  token=0x6000ED2  System.Void .ctor()
  RVA=0x09F22070  token=0x6000ED3  UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths paths)
  RVA=0x09F21EE8  token=0x6000ED4  UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement elem, UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths.Type pathTypesRequested)
  RVA=0x09F2214C  token=0x6000ED5  System.Void Release()
  RVA=0x09F22204  token=0x6000ED6  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.CustomStyleResolvedEvent
TYPE:  class
TOKEN: 0x200021D
SIZE:  0x80
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
PROPERTIES:
  customStyle  get=0x09F17074
METHODS:
  RVA=0x09F17020  token=0x6000ED8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TooltipEvent
TYPE:  class
TOKEN: 0x200021E
SIZE:  0x98
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private           System.String                   <tooltip>k__BackingField  // 0x80
  private           UnityEngine.Rect                <rect>k__BackingField  // 0x88
PROPERTIES:
  tooltip  set=0x051DFC94
  rect  set=0x03D76370
METHODS:
  RVA=0x09F22D0C  token=0x6000EDB  System.Void Init()
  RVA=0x09F22D50  token=0x6000EDC  System.Void LocalInit()
  RVA=0x09F22DB8  token=0x6000EDD  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StylePropertyNameCollection
TYPE:  sealed struct
TOKEN: 0x200021F
SIZE:  0x18
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>propertiesList  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000EDE  System.Void .ctor(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list)
  RVA=0x09F22BB8  token=0x6000EDF  UnityEngine.UIElements.StylePropertyNameCollection.Enumerator GetEnumerator()
  RVA=0x09F22C4C  token=0x6000EE0  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator()
  RVA=0x09F22CAC  token=0x6000EE1  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionEventBase`1
TYPE:  abstract class
TOKEN: 0x2000221
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
  private   readonly UnityEngine.UIElements.StylePropertyNameCollection<stylePropertyNames>k__BackingField  // 0x0
  private           System.Double                   <elapsedTime>k__BackingField  // 0x0
PROPERTIES:
  stylePropertyNames  get=-1  // not resolved
  elapsedTime  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000EEA  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000EEB  System.Void Init()
  RVA=-1  // not resolved  token=0x6000EEC  System.Void LocalInit()
  RVA=-1  // not resolved  token=0x6000EED  T GetPooled(UnityEngine.UIElements.StylePropertyName stylePropertyName, System.Double elapsedTime)
END_CLASS

CLASS: UnityEngine.UIElements.TransitionRunEvent
TYPE:  sealed class
TOKEN: 0x2000222
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.TransitionEventBase`1
FIELDS:
METHODS:
  RVA=0x09F22E8C  token=0x6000EEE  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionStartEvent
TYPE:  sealed class
TOKEN: 0x2000223
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.TransitionEventBase`1
FIELDS:
METHODS:
  RVA=0x09F22EC8  token=0x6000EEF  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionEndEvent
TYPE:  sealed class
TOKEN: 0x2000224
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.TransitionEventBase`1
FIELDS:
METHODS:
  RVA=0x09F22E50  token=0x6000EF0  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionCancelEvent
TYPE:  sealed class
TOKEN: 0x2000225
SIZE:  0x90
EXTENDS: UnityEngine.UIElements.TransitionEventBase`1
FIELDS:
METHODS:
  RVA=0x09F22E14  token=0x6000EF1  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IMGUIEvent
TYPE:  class
TOKEN: 0x2000226
SIZE:  0x80
EXTENDS: UnityEngine.UIElements.EventBase`1
FIELDS:
METHODS:
  RVA=0x09F1AD80  token=0x6000EF2  UnityEngine.UIElements.IMGUIEvent GetPooled(UnityEngine.Event systemEvent)
  RVA=0x09F1ADF8  token=0x6000EF3  System.Void Init()
  RVA=0x03D891A0  token=0x6000EF4  System.Void LocalInit()
  RVA=0x09F1AE3C  token=0x6000EF5  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebuggerLogCall
TYPE:  sealed struct
TOKEN: 0x2000227
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000EF6  System.Void .ctor(System.Delegate callback, UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000EF7  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebuggerLogIMGUICall
TYPE:  sealed struct
TOKEN: 0x2000228
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000EF8  System.Void .ctor(UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000EF9  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebuggerLogExecuteDefaultAction
TYPE:  sealed struct
TOKEN: 0x2000229
SIZE:  0x11
IMPLEMENTS: System.IDisposable
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000EFA  System.Void .ctor(UnityEngine.UIElements.EventBase evt)
  RVA=0x0350B670  token=0x6000EFB  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebugger
TYPE:  class
TOKEN: 0x200022A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000EFC  System.Void LogPropagationPaths(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths paths)
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasFiltersInternal
TYPE:  sealed struct
TOKEN: 0x200022B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalNone  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalReadability  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalSize  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalFormat  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalColorSpace  // const
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalFilterMode  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasSettings
TYPE:  class
TOKEN: 0x200022C
SIZE:  0x28
FIELDS:
  private           System.Int32                    m_MinAtlasSize  // 0x10
  private           System.Int32                    m_MaxAtlasSize  // 0x14
  private           System.Int32                    m_MaxSubTextureSize  // 0x18
  private           UnityEngine.UIElements.DynamicAtlasFiltersInternalm_ActiveFilters  // 0x1c
  private           UnityEngine.UIElements.DynamicAtlasCustomFilterm_CustomFilter  // 0x20
PROPERTIES:
  minAtlasSize  get=0x03D4E340  set=0x010410F0
  maxAtlasSize  get=0x03D50CC0  set=0x03D595B0
  maxSubTextureSize  get=0x020D1AC0  set=0x03D4E9C0
  activeFilters  get=0x03D4EBB0  set=0x03D4EBC0
  defaultFilters  get=0x03D55C10
  customFilter  get=0x03D4EB40  set=0x04271930
  defaults  get=0x09F173F0
METHODS:
  RVA=0x0350B670  token=0x6000F09  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.NavigateFocusRing
TYPE:  class
TOKEN: 0x200022D
SIZE:  0x20
IMPLEMENTS: UnityEngine.UIElements.IFocusRing
FIELDS:
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionLeft  // static @ 0x0
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionRight  // static @ 0x8
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionUp  // static @ 0x10
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionDown  // static @ 0x18
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionNext  // static @ 0x20
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionPrevious  // static @ 0x28
  private   readonly UnityEngine.UIElements.VisualElementm_Root  // 0x10
  private   readonly UnityEngine.UIElements.VisualElementFocusRingm_Ring  // 0x18
PROPERTIES:
  focusController  get=0x09ED9FE4
METHODS:
  RVA=0x09F1EBD4  token=0x6000F0B  System.Void .ctor(UnityEngine.UIElements.VisualElement root)
  RVA=0x09F1DF78  token=0x6000F0C  UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e)
  RVA=0x09F1E790  token=0x6000F0D  UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction)
  RVA=0x09F1E2C0  token=0x6000F0E  UnityEngine.UIElements.Focusable GetNextFocusable2D(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction)
  RVA=0x09F1E93C  token=0x6000F0F  System.Boolean IsActive(UnityEngine.UIElements.VisualElement v)
  RVA=0x09F1E97C  token=0x6000F10  System.Boolean IsNavigable(UnityEngine.UIElements.Focusable focusable)
  RVA=0x09F1E9C4  token=0x6000F11  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelScaleMode
TYPE:  sealed struct
TOKEN: 0x2000230
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PanelScaleModeConstantPixelSize  // const
  public    static  UnityEngine.UIElements.PanelScaleModeConstantPhysicalSize  // const
  public    static  UnityEngine.UIElements.PanelScaleModeScaleWithScreenSize  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PanelScreenMatchMode
TYPE:  sealed struct
TOKEN: 0x2000231
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PanelScreenMatchModeMatchWidthOrHeight  // const
  public    static  UnityEngine.UIElements.PanelScreenMatchModeShrink  // const
  public    static  UnityEngine.UIElements.PanelScreenMatchModeExpand  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PanelSettings
TYPE:  class
TOKEN: 0x2000232
SIZE:  0xD0
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private   static  System.Int32                    k_DefaultSortingOrder  // const
  private   static  System.Single                   k_DefaultScaleValue  // const
  private   static  System.String                   k_DefaultStyleSheetPath  // const
  private           UnityEngine.UIElements.ThemeStyleSheetthemeUss  // 0x18
  private           UnityEngine.RenderTexture       m_TargetTexture  // 0x20
  private           UnityEngine.UIElements.PanelScaleModem_ScaleMode  // 0x28
  private           System.Single                   m_Scale  // 0x2c
  private   static  System.Single                   DefaultDpi  // const
  private           System.Single                   m_ReferenceDpi  // 0x30
  private           System.Single                   m_FallbackDpi  // 0x34
  private           UnityEngine.Vector2Int          m_ReferenceResolution  // 0x38
  private           UnityEngine.UIElements.PanelScreenMatchModem_ScreenMatchMode  // 0x40
  private           System.Single                   m_Match  // 0x44
  private           System.Single                   m_SortingOrder  // 0x48
  private           System.Int32                    m_TargetDisplay  // 0x4c
  private           System.Boolean                  m_ClearDepthStencil  // 0x50
  private           System.Boolean                  m_ClearColor  // 0x51
  private           UnityEngine.Color               m_ColorClearValue  // 0x54
  private           UnityEngine.UIElements.PanelSettings.RuntimePanelAccessm_PanelAccess  // 0x68
  private           UnityEngine.UIElements.UIDocumentListm_AttachedUIDocumentsList  // 0x70
  private           UnityEngine.UIElements.DynamicAtlasSettingsm_DynamicAtlasSettings  // 0x78
  private           UnityEngine.Shader              m_AtlasBlitShader  // 0x80
  private           UnityEngine.Shader              m_RuntimeShader  // 0x88
  private           UnityEngine.Shader              m_RuntimeWorldShader  // 0x90
  public            UnityEngine.UIElements.PanelTextSettingstextSettings  // 0x98
  private           UnityEngine.Rect                m_TargetRect  // 0xa0
  private           System.Single                   m_ResolvedScale  // 0xb0
  private           UnityEngine.UIElements.StyleSheetm_OldThemeUss  // 0xb8
  private           System.Int32                    m_EmptyPanelCounter  // 0xc0
  private           System.Single                   <ScreenDPI>k__BackingField  // 0xc4
  private           System.Func<UnityEngine.Vector2,UnityEngine.Vector2>m_AssignedScreenToPanel  // 0xc8
PROPERTIES:
  themeStyleSheet  get=0x03D61D00  set=0x09F1FED8
  targetTexture  get=0x03D4EB40  set=0x09F1FEA8
  scaleMode  get=0x03D4EB90  set=0x03D4EBA0
  scale  get=0x03D4F3A0  set=0x03D4F3B0
  referenceDpi  get=0x03D4F5D0  set=0x09F1FE4C
  fallbackDpi  get=0x03D56CA0  set=0x09F1FE20
  referenceResolution  get=0x03D4E2A0  set=0x03D4EE50
  screenMatchMode  get=0x03D4ED80  set=0x03D4EDB0
  match  get=0x03D4EC80  set=0x03D4ED00
  sortingOrder  get=0x03D58370  set=0x09F1FE78
  targetDisplay  get=0x03D4EDF0  set=0x09F1FE84
  clearDepthStencil  get=0x03D4F000  set=0x03D4F030
  depthClearValue  get=0x03D891E0
  clearColor  get=0x03D518F0  set=0x03D51900
  colorClearValue  get=0x03D891D0  set=0x03D891F0
  panel  get=0x09F1FDD0
  visualTree  get=0x09F1FDF0
  dynamicAtlasSettings  get=0x03D4EB20  set=0x051DFCA4
  ScreenDPI  get=0x03D58470  set=0x03D69550
METHODS:
  RVA=0x09F1F4B8  token=0x6000F2E  System.Void ApplySortingOrder()
  RVA=0x09F1FCE8  token=0x6000F3C  System.Void .ctor()
  RVA=0x0350B670  token=0x6000F3D  System.Void Reset()
  RVA=0x09F1FABC  token=0x6000F3E  System.Void OnEnable()
  RVA=0x09F1F768  token=0x6000F3F  System.Void OnDisable()
  RVA=0x09F1F768  token=0x6000F40  System.Void DisposePanel()
  RVA=0x09F1FCC8  token=0x6000F43  System.Void UpdateScreenDPI()
  RVA=0x09F1F4D8  token=0x6000F44  System.Void ApplyThemeStyleSheet(UnityEngine.UIElements.VisualElement root)
  RVA=0x09F1F954  token=0x6000F45  System.Void InitializeShaders()
  RVA=0x09F1F048  token=0x6000F46  System.Void ApplyPanelSettings()
  RVA=0x09F1FC80  token=0x6000F47  System.Void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> screentoPanelSpaceFunction)
  RVA=0x09F1FB90  token=0x6000F48  System.Single ResolveScale(UnityEngine.Rect targetRect, System.Single screenDpi)
  RVA=0x09F1F788  token=0x6000F49  UnityEngine.Rect GetDisplayRect()
  RVA=0x09F1F638  token=0x6000F4A  System.Void AttachAndInsertUIDocumentToVisualTree(UnityEngine.UIElements.UIDocument uiDocument)
  RVA=0x09F1F6EC  token=0x6000F4B  System.Void DetachUIDocument(UnityEngine.UIElements.UIDocument uiDocument)
END_CLASS

CLASS: UnityEngine.UIElements.RuntimeEventDispatcher
TYPE:  static class
TOKEN: 0x2000234
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F22380  token=0x6000F56  UnityEngine.UIElements.EventDispatcher Create()
END_CLASS

CLASS: UnityEngine.UIElements.RuntimePanel
TYPE:  class
TOKEN: 0x2000235
SIZE:  0x1E0
EXTENDS: UnityEngine.UIElements.BaseRuntimePanel
FIELDS:
  private   static readonly UnityEngine.UIElements.EventDispatchers_EventDispatcher  // static @ 0x0
  private   readonly UnityEngine.UIElements.PanelSettingsm_PanelSettings  // 0x1d8
PROPERTIES:
  panelSettings  get=0x03D50210
METHODS:
  RVA=0x09F228D4  token=0x6000F58  UnityEngine.UIElements.RuntimePanel Create(UnityEngine.ScriptableObject ownerObject)
  RVA=0x09F22A00  token=0x6000F59  System.Void .ctor(UnityEngine.ScriptableObject ownerObject)
  RVA=0x09F22934  token=0x6000F5A  System.Void Update()
  RVA=0x09F229B0  token=0x6000F5B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIDocumentList
TYPE:  class
TOKEN: 0x2000236
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIDocument>m_AttachedUIDocuments  // 0x10
METHODS:
  RVA=0x09F24548  token=0x6000F5C  System.Void RemoveFromListAndFromVisualTree(UnityEngine.UIElements.UIDocument uiDocument)
  RVA=0x09F24230  token=0x6000F5D  System.Void AddToListAndToVisualTree(UnityEngine.UIElements.UIDocument uiDocument, UnityEngine.UIElements.VisualElement visualTree, System.Int32 firstInsertIndex)
  RVA=0x09F245B4  token=0x6000F5E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIDocument
TYPE:  sealed class
TOKEN: 0x2000237
SIZE:  0x60
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.String                   k_RootStyleClassName  // const
  private   static  System.String                   k_VisualElementNameSuffix  // const
  private   static  System.Int32                    k_DefaultSortingOrder  // const
  private   static  System.Int32                    s_CurrentUIDocumentCounter  // static @ 0x0
  private   readonly System.Int32                    m_UIDocumentCreationIndex  // 0x18
  private           UnityEngine.UIElements.PanelSettingsm_PanelSettings  // 0x20
  private           UnityEngine.UIElements.PanelSettingsm_PreviousPanelSettings  // 0x28
  private           UnityEngine.UIElements.UIDocumentm_ParentUI  // 0x30
  private           UnityEngine.UIElements.UIDocumentListm_ChildrenContent  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIDocument>m_ChildrenContentCopy  // 0x40
  private           UnityEngine.UIElements.VisualTreeAssetsourceAsset  // 0x48
  private           UnityEngine.UIElements.VisualElementm_RootVisualElement  // 0x50
  private           System.Int32                    m_FirstChildInsertIndex  // 0x58
  private           System.Single                   m_SortingOrder  // 0x5c
PROPERTIES:
  panelSettings  get=0x03D85A20  set=0x09F25320
  parentUI  get=0x01003830  set=0x04270470
  visualTreeAsset  get=0x03D87DB0  set=0x09F25640
  rootVisualElement  get=0x03D87E30
  firstChildInserIndex  get=0x03D4EF00
  sortingOrder  get=0x03D56C10  set=0x09F25624
METHODS:
  RVA=0x09F2478C  token=0x6000F69  System.Void ApplySortingOrder()
  RVA=0x09F252A0  token=0x6000F6A  System.Void .ctor()
  RVA=0x09F24794  token=0x6000F6B  System.Void Awake()
  RVA=0x09F24878  token=0x6000F6C  System.Void OnEnable()
  RVA=0x09F2519C  token=0x6000F6D  System.Void SetupFromHierarchy()
  RVA=0x09F2479C  token=0x6000F6E  UnityEngine.UIElements.UIDocument FindUIDocumentParent()
  RVA=0x09F250AC  token=0x6000F6F  System.Void Reset()
  RVA=0x09F2462C  token=0x6000F70  System.Void AddChildAndInsertContentToVisualTree(UnityEngine.UIElements.UIDocument child)
  RVA=0x09F24FF0  token=0x6000F71  System.Void RemoveChild(UnityEngine.UIElements.UIDocument child)
  RVA=0x09F24BBC  token=0x6000F72  System.Void RecreateUI()
  RVA=0x09F25224  token=0x6000F73  System.Void SetupRootClassList()
  RVA=0x09F246D8  token=0x6000F74  System.Void AddRootVisualElementToTree()
  RVA=0x09F25004  token=0x6000F75  System.Void RemoveFromHierarchy()
  RVA=0x09F24844  token=0x6000F76  System.Void OnDisable()
  RVA=0x09F24928  token=0x6000F77  System.Void OnTransformChildrenChanged()
  RVA=0x09F24B14  token=0x6000F78  System.Void OnTransformParentChanged()
  RVA=0x09F24B1C  token=0x6000F79  System.Void ReactToHierarchyChanged()
END_CLASS

CLASS: UnityEngine.UIElements.UIRAtlasAllocator
TYPE:  class
TOKEN: 0x2000238
SIZE:  0x50
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly System.Int32                    <maxAtlasSize>k__BackingField  // 0x10
  private   readonly System.Int32                    <maxImageWidth>k__BackingField  // 0x14
  private   readonly System.Int32                    <maxImageHeight>k__BackingField  // 0x18
  private           System.Int32                    <virtualWidth>k__BackingField  // 0x1c
  private           System.Int32                    <virtualHeight>k__BackingField  // 0x20
  private           System.Int32                    <physicalWidth>k__BackingField  // 0x24
  private           System.Int32                    <physicalHeight>k__BackingField  // 0x28
  private           UnityEngine.UIElements.UIRAtlasAllocator.AreaNodem_FirstUnpartitionedArea  // 0x30
  private           UnityEngine.UIElements.UIRAtlasAllocator.Row[]m_OpenRows  // 0x38
  private           System.Int32                    m_1SidePadding  // 0x40
  private           System.Int32                    m_2SidePadding  // 0x44
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTryAllocate  // static @ 0x0
  private           System.Boolean                  <disposed>k__BackingField  // 0x48
PROPERTIES:
  maxAtlasSize  get=0x03D4E340
  maxImageWidth  get=0x03D50CC0
  maxImageHeight  get=0x020D1AC0
  virtualWidth  get=0x03D4EBB0  set=0x03D4EBC0
  virtualHeight  get=0x01003B50  set=0x01003B60
  physicalWidth  get=0x03D4E2E0  set=0x03D4E2F0
  physicalHeight  get=0x03D4EB90  set=0x03D4EBA0
  disposed  get=0x03D4EFE0  set=0x03D4F010
METHODS:
  RVA=0x09F257D0  token=0x6000F87  System.Void Dispose()
  RVA=0x09F2573C  token=0x6000F88  System.Void Dispose(System.Boolean disposing)
  RVA=0x09F25820  token=0x6000F89  System.Int32 GetLog2OfNextPower(System.Int32 n)
  RVA=0x09F25D28  token=0x6000F8A  System.Void .ctor(System.Int32 initialAtlasSize, System.Int32 maxAtlasSize, System.Int32 sidePadding)
  RVA=0x09F25848  token=0x6000F8B  System.Boolean TryAllocate(System.Int32 width, System.Int32 height, UnityEngine.RectInt& location)
  RVA=0x09F25B3C  token=0x6000F8C  System.Boolean TryPartitionArea(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode areaNode, System.Int32 rowIndex, System.Int32 rowHeight, System.Int32 minWidth)
  RVA=0x09F25664  token=0x6000F8D  System.Void BuildAreas()
  RVA=0x09F25CC8  token=0x6000F8E  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasPage
TYPE:  class
TOKEN: 0x200023B
SIZE:  0x60
IMPLEMENTS: System.IDisposable
FIELDS:
  private           UnityEngine.UIElements.TextureId<textureId>k__BackingField  // 0x10
  private           UnityEngine.RenderTexture       <atlas>k__BackingField  // 0x18
  private   readonly UnityEngine.RenderTextureFormat <format>k__BackingField  // 0x20
  private   readonly UnityEngine.FilterMode          <filterMode>k__BackingField  // 0x24
  private   readonly UnityEngine.Vector2Int          <minSize>k__BackingField  // 0x28
  private   readonly UnityEngine.Vector2Int          <maxSize>k__BackingField  // 0x30
  private   readonly System.Int32                    m_1Padding  // 0x38
  private   readonly System.Int32                    m_2Padding  // 0x3c
  private           UnityEngine.UIElements.UIR.Allocator2Dm_Allocator  // 0x40
  private           UnityEngine.UIElements.UIR.TextureBlitterm_Blitter  // 0x48
  private           UnityEngine.Vector2Int          m_CurrentSize  // 0x50
  private   static  System.Int32                    s_TextureCounter  // static @ 0x0
  private           System.Boolean                  <disposed>k__BackingField  // 0x58
PROPERTIES:
  textureId  get=0x03D4E340  set=0x010410F0
  atlas  get=0x01041090  set=0x022C3A90
  format  get=0x01003B50
  filterMode  get=0x03D4E2E0
  disposed  get=0x03D4F7E0  set=0x03D4F7F0
METHODS:
  RVA=0x09F38A40  token=0x6000FA6  System.Void .ctor(UnityEngine.RenderTextureFormat format, UnityEngine.FilterMode filterMode, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize)
  RVA=0x09F382FC  token=0x6000FA9  System.Void Dispose()
  RVA=0x09F38198  token=0x6000FAA  System.Void Dispose(System.Boolean disposing)
  RVA=0x09F38400  token=0x6000FAB  System.Boolean TryAdd(UnityEngine.Texture2D image, UnityEngine.UIElements.UIR.Allocator2D.Alloc2D& alloc, UnityEngine.RectInt& rect)
  RVA=0x09F388F0  token=0x6000FAC  System.Void Update(UnityEngine.Texture2D image, UnityEngine.RectInt rect)
  RVA=0x09F3834C  token=0x6000FAD  System.Void Remove(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc)
  RVA=0x09F3803C  token=0x6000FAE  System.Void Commit()
  RVA=0x09F385CC  token=0x6000FAF  System.Void UpdateAtlasTexture()
  RVA=0x09F3807C  token=0x6000FB0  UnityEngine.RenderTexture CreateAtlasTexture()
END_CLASS

CLASS: UnityEngine.UIElements.UIRLayoutUpdater
TYPE:  class
TOKEN: 0x200023C
SIZE:  0x28
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private   static readonly System.String                   s_Description  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x8
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>>changeEventsList  // 0x20
PROPERTIES:
  profilerMarker  get=0x09F43350
METHODS:
  RVA=0x09F42B80  token=0x6000FB2  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09F4307C  token=0x6000FB3  System.Void Update()
  RVA=0x09F42BB8  token=0x6000FB4  System.Void UpdateSubTree(UnityEngine.UIElements.VisualElement ve, System.Boolean isDisplayed, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents)
  RVA=0x09F42914  token=0x6000FB5  System.Void DispatchChangeEvents(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents, System.Int32 currentLayoutPass)
  RVA=0x09F432D8  token=0x6000FB6  System.Void .ctor()
  RVA=0x09F43244  token=0x6000FB7  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Vertex
TYPE:  sealed struct
TOKEN: 0x200023D
SIZE:  0x4C
FIELDS:
  public    static readonly System.Single                   nearZ  // static @ 0x0
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Color32             tint  // 0x1c
  public            UnityEngine.Vector2             uv  // 0x20
  private           UnityEngine.Color32             xformClipPages  // 0x28
  private           UnityEngine.Color32             ids  // 0x2c
  private           UnityEngine.Color32             flags  // 0x30
  private           UnityEngine.Color32             opacityColorPages  // 0x34
  private           UnityEngine.Vector4             circle  // 0x38
  private           System.Single                   textureId  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.MeshWriteData
TYPE:  class
TOKEN: 0x200023E
SIZE:  0x48
FIELDS:
  private           Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>m_Vertices  // 0x10
  private           Unity.Collections.NativeSlice<System.UInt16>m_Indices  // 0x20
  private           UnityEngine.Rect                m_UVRegion  // 0x30
  private           System.Int32                    currentIndex  // 0x40
  private           System.Int32                    currentVertex  // 0x44
PROPERTIES:
  vertexCount  get=0x09F3CA84
  indexCount  get=0x09F3CA50
  uvRegion  get=0x03D87900
METHODS:
  RVA=0x0350B670  token=0x6000FB8  System.Void .ctor()
  RVA=0x09F3C9CC  token=0x6000FBC  System.Void SetNextVertex(UnityEngine.UIElements.Vertex vertex)
  RVA=0x09F3C978  token=0x6000FBD  System.Void SetNextIndex(System.UInt16 index)
  RVA=0x09F3C8C0  token=0x6000FBE  System.Void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices)
  RVA=0x09F3C808  token=0x6000FBF  System.Void SetAllIndices(System.UInt16[] indices)
  RVA=0x03D89260  token=0x6000FC0  System.Void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices)
  RVA=0x03D89290  token=0x6000FC1  System.Void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, UnityEngine.Rect uvRegion)
END_CLASS

CLASS: UnityEngine.UIElements.ColorPage
TYPE:  sealed struct
TOKEN: 0x200023F
SIZE:  0x18
FIELDS:
  public            System.Boolean                  isValid  // 0x10
  public            UnityEngine.Color32             pageAndID  // 0x14
METHODS:
  RVA=0x09F36250  token=0x6000FC2  UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.BMPAlloc alloc)
END_CLASS

CLASS: UnityEngine.UIElements.MeshGenerationContextUtils
TYPE:  static class
TOKEN: 0x2000240
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F3C614  token=0x6000FC3  System.Void Rectangle(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  RVA=0x09F3C6CC  token=0x6000FC4  System.Void Text(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  RVA=0x09F3C458  token=0x6000FC5  UnityEngine.Vector2 ConvertBorderRadiusPercentToPoints(UnityEngine.Vector2 borderRectSize, UnityEngine.UIElements.Length length)
  RVA=0x09F3C4B8  token=0x6000FC6  System.Void GetVisualElementRadii(UnityEngine.UIElements.VisualElement ve, UnityEngine.Vector2& topLeft, UnityEngine.Vector2& bottomLeft, UnityEngine.Vector2& topRight, UnityEngine.Vector2& bottomRight)
  RVA=0x09F3C350  token=0x6000FC7  System.Void AdjustBackgroundSizeForBorders(UnityEngine.UIElements.VisualElement visualElement, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams)
END_CLASS

CLASS: UnityEngine.UIElements.MeshGenerationContext
TYPE:  class
TOKEN: 0x2000244
SIZE:  0x18
FIELDS:
  private           UnityEngine.UIElements.IStylePainterpainter  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000FD5  System.Void .ctor(UnityEngine.UIElements.IStylePainter painter)
END_CLASS

CLASS: UnityEngine.UIElements.UIRRepaintUpdater
TYPE:  class
TOKEN: 0x2000246
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.BaseVisualTreeUpdater
FIELDS:
  private           UnityEngine.UIElements.BaseVisualElementPanelattachedPanel  // 0x20
  private           UnityEngine.UIElements.UIR.RenderChainrenderChain  // 0x28
  private   static readonly System.String                   s_Description  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // static @ 0x8
  private           System.Boolean                  <drawStats>k__BackingField  // 0x30
  private           System.Boolean                  <breakBatches>k__BackingField  // 0x31
  private           System.Boolean                  <disposed>k__BackingField  // 0x32
PROPERTIES:
  profilerMarker  get=0x09F441BC
  drawStats  get=0x03D4EF60
  breakBatches  get=0x03D4F2C0
  disposed  get=0x03D4F630  set=0x03D4F640
METHODS:
  RVA=0x09F44140  token=0x6000FD6  System.Void .ctor()
  RVA=0x09F43D38  token=0x6000FDA  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  RVA=0x09F43F08  token=0x6000FDB  System.Void Update()
  RVA=0x09F43578  token=0x6000FDC  UnityEngine.UIElements.UIR.RenderChain CreateRenderChain()
  RVA=0x09F44040  token=0x6000FDD  System.Void .cctor()
  RVA=0x09F438B0  token=0x6000FDE  System.Void OnGraphicsResourcesRecreate(System.Boolean recreate)
  RVA=0x09F43A10  token=0x6000FDF  System.Void OnPanelChanged(UnityEngine.UIElements.BaseVisualElementPanel obj)
  RVA=0x09F433A0  token=0x6000FE0  System.Void AttachToPanel()
  RVA=0x09F43634  token=0x6000FE1  System.Void DetachFromPanel()
  RVA=0x09F43810  token=0x6000FE2  System.Void InitRenderChain()
  RVA=0x09F435DC  token=0x6000FE3  System.Void DestroyRenderChain()
  RVA=0x09F43A08  token=0x6000FE4  System.Void OnPanelAtlasChanged()
  RVA=0x09F43A30  token=0x6000FE5  System.Void OnPanelHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType)
  RVA=0x09F43A90  token=0x6000FE6  System.Void OnPanelStandardShaderChanged()
  RVA=0x09F43BE4  token=0x6000FE7  System.Void OnPanelStandardWorldSpaceShaderChanged()
  RVA=0x09F43E78  token=0x6000FE8  System.Void ResetAllElementsDataRecursive(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F437EC  token=0x6000FEB  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: UnityEngine.UIElements.TextureId
TYPE:  sealed struct
TOKEN: 0x2000247
SIZE:  0x14
FIELDS:
  private   readonly System.Int32                    m_Index  // 0x10
  public    static readonly UnityEngine.UIElements.TextureIdinvalid  // static @ 0x0
PROPERTIES:
  index  get=0x03D5B1A0
METHODS:
  RVA=0x03D5B1B0  token=0x6000FEC  System.Void .ctor(System.Int32 index)
  RVA=0x09F412AC  token=0x6000FEE  System.Single ConvertToGpu()
  RVA=0x09F412F8  token=0x6000FEF  System.Boolean Equals(System.Object obj)
  RVA=0x03D85860  token=0x6000FF0  System.Int32 GetHashCode()
  RVA=0x06505FF4  token=0x6000FF1  System.Boolean op_Equality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right)
  RVA=0x09F413A4  token=0x6000FF2  System.Boolean op_Inequality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right)
  RVA=0x09F41368  token=0x6000FF3  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextureRegistry
TYPE:  class
TOKEN: 0x2000248
SIZE:  0x28
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.TextureRegistry.TextureInfo>m_Textures  // 0x10
  private           System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.TextureId>m_TextureToId  // 0x18
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.TextureId>m_FreeIds  // 0x20
  private   static  System.Int32                    maxTextures  // const
  private   static readonly UnityEngine.UIElements.TextureRegistry<instance>k__BackingField  // static @ 0x0
PROPERTIES:
  instance  get=0x09F41F8C
METHODS:
  RVA=0x09F41824  token=0x6000FF5  UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId id)
  RVA=0x09F4155C  token=0x6000FF6  UnityEngine.UIElements.TextureId AllocAndAcquireDynamic()
  RVA=0x09F41BEC  token=0x6000FF7  System.Void UpdateDynamic(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture)
  RVA=0x09F4156C  token=0x6000FF8  UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture texture, System.Boolean dynamic)
  RVA=0x09F413EC  token=0x6000FF9  UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture tex)
  RVA=0x09F419A4  token=0x6000FFA  System.Void Release(UnityEngine.UIElements.TextureId id)
  RVA=0x09F41E78  token=0x6000FFB  System.Void .ctor()
  RVA=0x09F41E08  token=0x6000FFC  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIRUtility
TYPE:  static class
TOKEN: 0x200024A
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   k_DefaultShaderName  // static @ 0x0
  public    static readonly System.String                   k_DefaultWorldSpaceShaderName  // static @ 0x8
METHODS:
  RVA=0x09F443C4  token=0x6000FFD  System.Boolean ShapeWindingIsClockwise(System.Int32 maskDepth, System.Int32 stencilRef)
  RVA=0x09F442E8  token=0x6000FFE  System.Boolean IsRoundRect(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F4434C  token=0x6000FFF  System.Boolean IsVectorImageBackground(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F442C8  token=0x6001000  System.Boolean IsElementSelfHidden(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F4420C  token=0x6001001  System.Void Destroy(UnityEngine.Object obj)
  RVA=0x09F442B0  token=0x6001002  System.Int32 GetPrevPow2(System.Int32 n)
  RVA=0x09F442A0  token=0x6001003  System.Int32 GetNextPow2(System.Int32 n)
  RVA=0x09F4428C  token=0x6001004  System.Int32 GetNextPow2Exp(System.Int32 n)
  RVA=0x09F44430  token=0x6001005  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.AngleUnit
TYPE:  sealed struct
TOKEN: 0x200024B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.AngleUnitDegree  // const
  public    static  UnityEngine.UIElements.AngleUnitGradian  // const
  public    static  UnityEngine.UIElements.AngleUnitRadian  // const
  public    static  UnityEngine.UIElements.AngleUnitTurn  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Angle
TYPE:  sealed struct
TOKEN: 0x200024C
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.Angle.Unitm_Unit  // 0x14
PROPERTIES:
  value  get=0x03D4FA00
METHODS:
  RVA=0x03D89220  token=0x6001006  UnityEngine.UIElements.Angle None()
  RVA=0x03D4F9E0  token=0x6001008  System.Void .ctor(System.Single value, UnityEngine.UIElements.AngleUnit unit)
  RVA=0x03D4F9E0  token=0x6001009  System.Void .ctor(System.Single value, UnityEngine.UIElements.Angle.Unit unit)
  RVA=0x09F35548  token=0x600100A  System.Single ToDegrees()
  RVA=0x03D89240  token=0x600100B  UnityEngine.UIElements.Angle op_Implicit(System.Single value)
  RVA=0x09F356E0  token=0x600100C  System.Boolean op_Equality(UnityEngine.UIElements.Angle lhs, UnityEngine.UIElements.Angle rhs)
  RVA=0x09F35514  token=0x600100D  System.Boolean Equals(UnityEngine.UIElements.Angle other)
  RVA=0x09F354A4  token=0x600100E  System.Boolean Equals(System.Object obj)
  RVA=0x09F35528  token=0x600100F  System.Int32 GetHashCode()
  RVA=0x09F355A0  token=0x6001010  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.Background
TYPE:  sealed struct
TOKEN: 0x200024E
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.Texture2D           m_Texture  // 0x10
  private           UnityEngine.Sprite              m_Sprite  // 0x18
  private           UnityEngine.RenderTexture       m_RenderTexture  // 0x20
  private           UnityEngine.UIElements.VectorImagem_VectorImage  // 0x28
PROPERTIES:
  texture  get=0x0253BE20  set=0x09F36120
  sprite  get=0x03D85A90  set=0x09F36088
  renderTexture  get=0x03D66B80  set=0x09F35FF0
  vectorImage  get=0x03D61D00  set=0x09F361B8
METHODS:
  RVA=0x09F35CD4  token=0x6001019  UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D t)
  RVA=0x09F35C4C  token=0x600101A  UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture rt)
  RVA=0x09F35C90  token=0x600101B  UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite s)
  RVA=0x09F35D18  token=0x600101C  UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage vi)
  RVA=0x09F35AA4  token=0x600101D  UnityEngine.UIElements.Background FromObject(System.Object obj)
  RVA=0x09F35EF4  token=0x600101E  System.Boolean op_Equality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs)
  RVA=0x09F35FB4  token=0x600101F  System.Boolean op_Inequality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs)
  RVA=0x09F35A64  token=0x6001020  System.Boolean Equals(UnityEngine.UIElements.Background other)
  RVA=0x09F359D0  token=0x6001021  System.Boolean Equals(System.Object obj)
  RVA=0x09F35D5C  token=0x6001022  System.Int32 GetHashCode()
  RVA=0x09F35DF8  token=0x6001023  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.ComputedStyle
TYPE:  sealed struct
TOKEN: 0x200024F
SIZE:  0x68
FIELDS:
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.InheritedData>inheritedData  // 0x10
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.LayoutData>layoutData  // 0x18
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.RareData>rareData  // 0x20
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransformData>transformData  // 0x28
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransitionData>transitionData  // 0x30
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.VisualData>visualData  // 0x38
  public            UnityEngine.Yoga.YogaNode       yogaNode  // 0x40
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue>customProperties  // 0x48
  public            System.Int64                    matchingRulesHash  // 0x50
  public            System.Single                   dpiScaling  // 0x58
  public            UnityEngine.UIElements.ComputedTransitionProperty[]computedTransitions  // 0x60
PROPERTIES:
  customPropertiesCount  get=0x09F33FD4
  hasTransition  get=0x09F341DC
  alignContent  get=0x09F33A24
  alignItems  get=0x09F33A64
  alignSelf  get=0x09F33AA4
  backgroundColor  get=0x09F33AE4
  backgroundImage  get=0x09F33B34
  borderBottomColor  get=0x09F33B90
  borderBottomLeftRadius  get=0x09F33BE4
  borderBottomRightRadius  get=0x09F33C24
  borderBottomWidth  get=0x09F33C64
  borderLeftColor  get=0x09F33CA4
  borderLeftWidth  get=0x09F33CF8
  borderRightColor  get=0x09F33D38
  borderRightWidth  get=0x09F33D8C
  borderTopColor  get=0x09F33DCC
  borderTopLeftRadius  get=0x09F33E20
  borderTopRightRadius  get=0x09F33E64
  borderTopWidth  get=0x09F33EA8
  bottom  get=0x09F33EE8
  color  get=0x09F33F28
  cursor  get=0x09F33F78
  display  get=0x09F3401C
  flexBasis  get=0x09F3405C
  flexDirection  get=0x09F3409C
  flexGrow  get=0x09F340DC
  flexShrink  get=0x09F3411C
  flexWrap  get=0x09F3415C
  fontSize  get=0x09F3419C
  height  get=0x09F341F0
  justifyContent  get=0x09F34230
  left  get=0x09F34270
  letterSpacing  get=0x09F342B0
  marginBottom  get=0x09F342F0
  marginLeft  get=0x09F34330
  marginRight  get=0x09F34370
  marginTop  get=0x09F343B0
  maxHeight  get=0x09F343F0
  maxWidth  get=0x09F34430
  minHeight  get=0x09F34470
  minWidth  get=0x09F344B4
  opacity  get=0x09F344F8
  overflow  get=0x09F3453C
  paddingBottom  get=0x09F34580
  paddingLeft  get=0x09F345C4
  paddingRight  get=0x09F34608
  paddingTop  get=0x09F3464C
  position  get=0x09F34690
  right  get=0x09F346D4
  rotate  get=0x09F34718
  scale  get=0x09F34774
  textOverflow  get=0x09F347C8
  textShadow  get=0x09F34808
  top  get=0x09F34868
  transformOrigin  get=0x09F348AC
  transitionDelay  get=0x09F34904
  transitionDuration  get=0x09F34944
  transitionProperty  get=0x09F34984
  transitionTimingFunction  get=0x09F349C4
  translate  get=0x09F34A04
  unityBackgroundImageTintColor  get=0x09F34A60
  unityBackgroundScaleMode  get=0x09F34AB4
  unityFont  get=0x09F34B84
  unityFontDefinition  get=0x09F34AF4
  unityFontStyleAndWeight  get=0x09F34B44
  unityOverflowClipBox  get=0x09F34BC4
  unityParagraphSpacing  get=0x09F34C04
  unitySliceBottom  get=0x09F34C44
  unitySliceLeft  get=0x09F34C84
  unitySliceRight  get=0x09F34CC4
  unitySliceTop  get=0x09F34D04
  unityTextAlign  get=0x09F34D44
  unityTextOutlineColor  get=0x09F34D84
  unityTextOutlineWidth  get=0x09F34DD4
  unityTextOverflowPosition  get=0x09F34E14
  visibility  get=0x09F34E54
  whiteSpace  get=0x09F34E94
  width  get=0x09F34ED4
  wordSpacing  get=0x09F34F18
METHODS:
  RVA=0x09F2DCD0  token=0x6001026  System.Void FinalizeApply(UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F33604  token=0x6001027  System.Void SyncWithLayout(UnityEngine.Yoga.YogaNode targetNode)
  RVA=0x09F275BC  token=0x6001028  System.Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2764C  token=0x6001029  System.Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleKeyword keyword, UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2DEB4  token=0x600102A  System.Void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
  RVA=0x09F2621C  token=0x600102B  System.Void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
  RVA=0x09F261D0  token=0x600102C  System.Void ApplyAllPropertyInitial()
  RVA=0x05D62B3C  token=0x600102D  System.Void ResetComputedTransitions()
  RVA=0x09F2D4D8  token=0x600102E  UnityEngine.UIElements.VersionChangeType CompareChanges(UnityEngine.UIElements.ComputedStyle& x, UnityEngine.UIElements.ComputedStyle& y)
  RVA=0x09F2F808  token=0x600102F  System.Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleTranslate translate, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09F2DAE4  token=0x600107D  UnityEngine.UIElements.ComputedStyle Create(UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2D944  token=0x600107E  UnityEngine.UIElements.ComputedStyle CreateInitial()
  RVA=0x09F260BC  token=0x600107F  UnityEngine.UIElements.ComputedStyle Acquire()
  RVA=0x09F2DDEC  token=0x6001080  System.Void Release()
  RVA=0x09F2D818  token=0x6001081  System.Void CopyFrom(UnityEngine.UIElements.ComputedStyle& other)
  RVA=0x09F28DF4  token=0x6001082  System.Void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2C3FC  token=0x6001083  System.Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2C0EC  token=0x6001084  System.Void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged sv, UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2BED8  token=0x6001085  System.Void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor)
  RVA=0x09F2BFE0  token=0x6001086  System.Void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow st)
  RVA=0x09F26304  token=0x6001087  System.Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& other)
  RVA=0x09F2A508  token=0x6001088  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length newValue)
  RVA=0x09F2A1C0  token=0x6001089  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single newValue)
  RVA=0x09F2AF30  token=0x600108A  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 newValue)
  RVA=0x09F2BC6C  token=0x600108B  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color newValue)
  RVA=0x09F2B894  token=0x600108C  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background newValue)
  RVA=0x09F2ADF0  token=0x600108D  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font newValue)
  RVA=0x09F2B9E0  token=0x600108E  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition newValue)
  RVA=0x09F2BB24  token=0x600108F  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow newValue)
  RVA=0x09F2B4D4  token=0x6001090  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate newValue)
  RVA=0x09F2B754  token=0x6001091  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin newValue)
  RVA=0x09F2A07C  token=0x6001092  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate newValue)
  RVA=0x09F2B618  token=0x6001093  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale newValue)
  RVA=0x09F315AC  token=0x6001094  System.Boolean StartAnimation(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09F2DF48  token=0x6001095  System.Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09F2F928  token=0x6001096  System.Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StyleValue sv, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  RVA=0x09F2C040  token=0x6001097  System.Void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin st)
  RVA=0x09F2C094  token=0x6001098  System.Void ApplyStyleTranslate(UnityEngine.UIElements.Translate translateValue)
  RVA=0x09F2BF38  token=0x6001099  System.Void ApplyStyleRotate(UnityEngine.UIElements.Rotate rotateValue)
  RVA=0x09F2BF90  token=0x600109A  System.Void ApplyStyleScale(UnityEngine.UIElements.Scale scaleValue)
  RVA=0x09F2766C  token=0x600109B  System.Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
  RVA=0x09F276B4  token=0x600109C  System.Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F2D18C  token=0x600109D  System.Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle)
  RVA=0x09F2D1C0  token=0x600109E  System.Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& parentStyle)
END_CLASS

CLASS: UnityEngine.UIElements.ComputedTransitionProperty
TYPE:  sealed struct
TOKEN: 0x2000250
SIZE:  0x28
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.StylePropertyIdid  // 0x10
  public            System.Int32                    durationMs  // 0x14
  public            System.Int32                    delayMs  // 0x18
  public            System.Func<System.Single,System.Single>easingCurve  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ComputedTransitionUtils
TYPE:  static class
TOKEN: 0x2000251
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty>s_ComputedTransitionsBuffer  // static @ 0x0
METHODS:
  RVA=0x09F37F58  token=0x600109F  System.Void UpdateComputedTransitions(UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09F37C10  token=0x60010A0  System.Boolean HasTransitionProperty(UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F37B28  token=0x60010A1  System.Boolean GetTransitionProperty(UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedTransitionProperty& result)
  RVA=0x09F3752C  token=0x60010A2  UnityEngine.UIElements.ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09F376A4  token=0x60010A3  System.Int32 GetTransitionHashCode(UnityEngine.UIElements.ComputedStyle& cs)
  RVA=0x09F37D80  token=0x60010A4  System.Boolean SameTransitionProperty(UnityEngine.UIElements.ComputedStyle& x, UnityEngine.UIElements.ComputedStyle& y)
  RVA=0x09F37CB8  token=0x60010A5  System.Boolean SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b)
  RVA=0x09F37E90  token=0x60010A6  System.Boolean SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b)
  RVA=0x09F362F4  token=0x60010A7  System.Void ComputeTransitionPropertyData(UnityEngine.UIElements.ComputedStyle& computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData)
  RVA=-1  // generic def  token=0x60010A8  T GetWrappingTransitionData(System.Collections.Generic.List<T> list, System.Int32 i, T defaultValue)
  RVA=0x09F37500  token=0x60010A9  System.Int32 ConvertTransitionTime(UnityEngine.UIElements.TimeValue time)
  RVA=0x09F3654C  token=0x60010AA  System.Func<System.Single,System.Single> ConvertTransitionFunction(UnityEngine.UIElements.EasingMode mode)
  RVA=0x09F37FB0  token=0x60010AB  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.CustomStyleProperty`1
TYPE:  sealed struct
TOKEN: 0x2000253
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x0
PROPERTIES:
  name  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60010C7  System.Void .ctor(System.String propertyName)
  RVA=-1  // not resolved  token=0x60010C8  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x60010C9  System.Boolean Equals(UnityEngine.UIElements.CustomStyleProperty<T> other)
  RVA=-1  // not resolved  token=0x60010CA  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.ICustomStyle
TYPE:  interface
TOKEN: 0x2000254
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60010CB  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, System.Single& value)
  RVA=-1  // abstract  token=0x60010CC  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, System.Int32& value)
  RVA=-1  // abstract  token=0x60010CD  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, UnityEngine.Color& value)
  RVA=-1  // abstract  token=0x60010CE  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, UnityEngine.Texture2D& value)
  RVA=-1  // abstract  token=0x60010CF  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, UnityEngine.Sprite& value)
  RVA=-1  // abstract  token=0x60010D0  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, UnityEngine.UIElements.VectorImage& value)
  RVA=-1  // abstract  token=0x60010D1  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, System.String& value)
END_CLASS

CLASS: UnityEngine.UIElements.EasingMode
TYPE:  sealed struct
TOKEN: 0x2000255
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.EasingModeEase  // const
  public    static  UnityEngine.UIElements.EasingModeEaseIn  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOut  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOut  // const
  public    static  UnityEngine.UIElements.EasingModeLinear  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInSine  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOutSine  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOutSine  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInCubic  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOutCubic  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOutCubic  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInCirc  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOutCirc  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOutCirc  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInElastic  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOutElastic  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOutElastic  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInBack  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOutBack  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOutBack  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInBounce  // const
  public    static  UnityEngine.UIElements.EasingModeEaseOutBounce  // const
  public    static  UnityEngine.UIElements.EasingModeEaseInOutBounce  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.EasingFunction
TYPE:  sealed struct
TOKEN: 0x2000256
SIZE:  0x14
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.EasingModem_Mode  // 0x10
PROPERTIES:
  mode  get=0x03D4E980
METHODS:
  RVA=0x03D4E970  token=0x60010D3  System.Void .ctor(UnityEngine.UIElements.EasingMode mode)
  RVA=0x03D86CF0  token=0x60010D4  UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode easingMode)
  RVA=0x06505FF4  token=0x60010D5  System.Boolean op_Equality(UnityEngine.UIElements.EasingFunction lhs, UnityEngine.UIElements.EasingFunction rhs)
  RVA=0x095CAFF8  token=0x60010D6  System.Boolean Equals(UnityEngine.UIElements.EasingFunction other)
  RVA=0x09F38B6C  token=0x60010D7  System.Boolean Equals(System.Object obj)
  RVA=0x09F38BD4  token=0x60010D8  System.String ToString()
  RVA=0x03D85860  token=0x60010D9  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.FontDefinition
TYPE:  sealed struct
TOKEN: 0x2000257
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.Font                m_Font  // 0x10
  private           UnityEngine.TextCore.Text.FontAssetm_FontAsset  // 0x18
PROPERTIES:
  font  get=0x0253BE20
  fontAsset  get=0x03D85A90
METHODS:
  RVA=0x09F38CE4  token=0x60010DC  UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font f)
  RVA=0x09F38E10  token=0x60010DD  UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset f)
  RVA=0x09F38D1C  token=0x60010DE  UnityEngine.UIElements.FontDefinition FromObject(System.Object obj)
  RVA=0x09F38F10  token=0x60010DF  System.Boolean IsEmpty()
  RVA=0x09F38F94  token=0x60010E0  System.String ToString()
  RVA=0x09F38C9C  token=0x60010E1  System.Boolean Equals(UnityEngine.UIElements.FontDefinition other)
  RVA=0x09F38C24  token=0x60010E2  System.Boolean Equals(System.Object obj)
  RVA=0x09F38E48  token=0x60010E3  System.Int32 GetHashCode()
  RVA=0x09F3900C  token=0x60010E4  System.Boolean op_Equality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right)
  RVA=0x09F3902C  token=0x60010E5  System.Boolean op_Inequality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueCollection
TYPE:  class
TOKEN: 0x2000258
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue>m_Values  // 0x10
METHODS:
  RVA=0x09F4013C  token=0x60010E6  UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F40068  token=0x60010E7  UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F400D0  token=0x60010E8  UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F402FC  token=0x60010E9  System.Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleSheets.StyleValue& value)
  RVA=0x09F401CC  token=0x60010EA  System.Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
  RVA=0x09F4045C  token=0x60010EB  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.InlineStyleAccess
TYPE:  class
TOKEN: 0x2000259
SIZE:  0x100
EXTENDS: UnityEngine.UIElements.StyleValueCollection
IMPLEMENTS: UnityEngine.UIElements.IStyle
FIELDS:
  private   static  UnityEngine.UIElements.StyleSheets.StylePropertyReaders_StylePropertyReader  // static @ 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValueManaged>m_ValuesManaged  // 0x18
  private           UnityEngine.UIElements.VisualElement<ve>k__BackingField  // 0x20
  private           System.Boolean                  m_HasInlineCursor  // 0x28
  private           UnityEngine.UIElements.StyleCursorm_InlineCursor  // 0x30
  private           System.Boolean                  m_HasInlineTextShadow  // 0x50
  private           UnityEngine.UIElements.StyleTextShadowm_InlineTextShadow  // 0x54
  private           System.Boolean                  m_HasInlineTransformOrigin  // 0x74
  private           UnityEngine.UIElements.StyleTransformOriginm_InlineTransformOrigin  // 0x78
  private           System.Boolean                  m_HasInlineTranslate  // 0x90
  private           UnityEngine.UIElements.StyleTranslatem_InlineTranslateOperation  // 0x94
  private           System.Boolean                  m_HasInlineRotate  // 0xb0
  private           UnityEngine.UIElements.StyleRotatem_InlineRotateOperation  // 0xb4
  private           System.Boolean                  m_HasInlineScale  // 0xd0
  private           UnityEngine.UIElements.StyleScalem_InlineScale  // 0xd4
  private           UnityEngine.UIElements.InlineStyleAccess.InlineRulem_InlineRule  // 0xe8
PROPERTIES:
  ve  get=0x03D4EB40  set=0x04271930
  UnityEngine.UIElements.IStyle.cursor  get=0x09F3A7FC
  UnityEngine.UIElements.IStyle.textShadow  get=0x09F3A9E8
  UnityEngine.UIElements.IStyle.transformOrigin  get=0x09F3AA50
  UnityEngine.UIElements.IStyle.translate  get=0x09F3AAC0  set=0x09F3BE1C
  UnityEngine.UIElements.IStyle.rotate  get=0x09F3A900
  UnityEngine.UIElements.IStyle.scale  get=0x09F3A980
  UnityEngine.UIElements.IStyle.backgroundColor  set=0x09F3AB7C
  UnityEngine.UIElements.IStyle.borderBottomColor  set=0x09F3ABCC
  UnityEngine.UIElements.IStyle.borderBottomLeftRadius  set=0x09F3AC1C
  UnityEngine.UIElements.IStyle.borderBottomRightRadius  set=0x09F3AC70
  UnityEngine.UIElements.IStyle.borderBottomWidth  set=0x09F3ACC4
  UnityEngine.UIElements.IStyle.borderLeftColor  set=0x09F3AD40
  UnityEngine.UIElements.IStyle.borderLeftWidth  set=0x09F3AD90
  UnityEngine.UIElements.IStyle.borderRightColor  set=0x09F3AE0C
  UnityEngine.UIElements.IStyle.borderRightWidth  set=0x09F3AE5C
  UnityEngine.UIElements.IStyle.borderTopColor  set=0x09F3AED8
  UnityEngine.UIElements.IStyle.borderTopLeftRadius  set=0x09F3AF28
  UnityEngine.UIElements.IStyle.borderTopRightRadius  set=0x09F3AF7C
  UnityEngine.UIElements.IStyle.borderTopWidth  set=0x09F3AFD0
  UnityEngine.UIElements.IStyle.bottom  set=0x09F3B04C
  UnityEngine.UIElements.IStyle.color  set=0x09F3B0E4
  UnityEngine.UIElements.IStyle.display  get=0x09F3A864  set=0x09F3B134
  UnityEngine.UIElements.IStyle.flexBasis  set=0x09F3B1D4
  UnityEngine.UIElements.IStyle.flexDirection  set=0x09F3B26C
  UnityEngine.UIElements.IStyle.flexGrow  set=0x09F3B30C
  UnityEngine.UIElements.IStyle.flexShrink  set=0x09F3B384
  UnityEngine.UIElements.IStyle.fontSize  set=0x09F3B3FC
  UnityEngine.UIElements.IStyle.height  set=0x09F3B450
  UnityEngine.UIElements.IStyle.left  set=0x09F3B4E8
  UnityEngine.UIElements.IStyle.marginBottom  set=0x09F3B580
  UnityEngine.UIElements.IStyle.marginLeft  set=0x09F3B618
  UnityEngine.UIElements.IStyle.marginRight  set=0x09F3B6B0
  UnityEngine.UIElements.IStyle.marginTop  set=0x09F3B748
  UnityEngine.UIElements.IStyle.maxHeight  set=0x09F3B7E0
  UnityEngine.UIElements.IStyle.maxWidth  set=0x09F3B878
  UnityEngine.UIElements.IStyle.minWidth  set=0x09F3B910
  UnityEngine.UIElements.IStyle.opacity  set=0x09F3B9A8
  UnityEngine.UIElements.IStyle.paddingBottom  set=0x09F3B9EC
  UnityEngine.UIElements.IStyle.paddingLeft  set=0x09F3BA84
  UnityEngine.UIElements.IStyle.paddingRight  set=0x09F3BB1C
  UnityEngine.UIElements.IStyle.paddingTop  get=0x09F3A8C4  set=0x09F3BBB4
  UnityEngine.UIElements.IStyle.position  set=0x09F3BC4C
  UnityEngine.UIElements.IStyle.right  set=0x09F3BCEC
  UnityEngine.UIElements.IStyle.top  set=0x09F3BD84
  UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor  set=0x09F3BE74
  UnityEngine.UIElements.IStyle.visibility  set=0x09F3BEC4
  UnityEngine.UIElements.IStyle.width  get=0x09F3AB40  set=0x09F3BF34
METHODS:
  RVA=0x09F3C048  token=0x60010EE  System.Void .ctor(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F39D8C  token=0x60010EF  System.Void Finalize()
  RVA=0x09F3A1DC  token=0x60010F0  System.Void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule)
  RVA=0x09F39E5C  token=0x60010F1  System.Boolean IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F39200  token=0x60010F2  System.Void ApplyInlineStyles(UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09F3A3CC  token=0x60010FA  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleLength inlineValue)
  RVA=0x09F3A60C  token=0x60010FB  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleFloat inlineValue)
  RVA=0x09F3A4DC  token=0x60010FC  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleColor inlineValue)
  RVA=-1  // generic def  token=0x60010FD  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue)
  RVA=0x09F3A28C  token=0x60010FE  System.Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate inlineValue)
  RVA=0x09F39964  token=0x60010FF  System.Void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate translate)
  RVA=0x09F39B30  token=0x6001100  System.Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
  RVA=0x09F3A104  token=0x6001101  System.Boolean RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09F3904C  token=0x6001102  System.Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& newStyle)
  RVA=0x09F3A710  token=0x6001103  System.Boolean TryGetInlineCursor(UnityEngine.UIElements.StyleCursor& value)
  RVA=0x09F3A790  token=0x6001104  System.Boolean TryGetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow& value)
  RVA=0x09F3A7AC  token=0x6001105  System.Boolean TryGetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin& value)
  RVA=0x09F3A7CC  token=0x6001106  System.Boolean TryGetInlineTranslate(UnityEngine.UIElements.StyleTranslate& value)
  RVA=0x09F3A73C  token=0x6001107  System.Boolean TryGetInlineRotate(UnityEngine.UIElements.StyleRotate& value)
  RVA=0x09F3A76C  token=0x6001108  System.Boolean TryGetInlineScale(UnityEngine.UIElements.StyleScale& value)
  RVA=0x09F3BFCC  token=0x6001135  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.LengthUnit
TYPE:  sealed struct
TOKEN: 0x200025B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.LengthUnitPixel  // const
  public    static  UnityEngine.UIElements.LengthUnitPercent  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Length
TYPE:  sealed struct
TOKEN: 0x200025C
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private   static  System.Single                   k_MaxValue  // const
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.Length.Unitm_Unit  // 0x14
PROPERTIES:
  value  get=0x03D4FA00  set=0x09F3C32C
  unit  get=0x03D4E990
METHODS:
  RVA=0x09F3C158  token=0x6001136  UnityEngine.UIElements.Length Percent(System.Single value)
  RVA=0x09F3C078  token=0x6001137  UnityEngine.UIElements.Length Auto()
  RVA=0x09F3C128  token=0x6001138  UnityEngine.UIElements.Length None()
  RVA=0x09F3C118  token=0x600113C  System.Boolean IsAuto()
  RVA=0x09F3C120  token=0x600113D  System.Boolean IsNone()
  RVA=0x09F3C2D8  token=0x600113E  System.Void .ctor(System.Single value)
  RVA=0x09F3C2E4  token=0x600113F  System.Void .ctor(System.Single value, UnityEngine.UIElements.LengthUnit unit)
  RVA=0x09F3C2AC  token=0x6001140  System.Void .ctor(System.Single value, UnityEngine.UIElements.Length.Unit unit)
  RVA=0x09F3C2EC  token=0x6001141  UnityEngine.UIElements.Length op_Implicit(System.Single value)
  RVA=0x09F356E0  token=0x6001142  System.Boolean op_Equality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs)
  RVA=0x09F3C318  token=0x6001143  System.Boolean op_Inequality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs)
  RVA=0x09F35514  token=0x6001144  System.Boolean Equals(UnityEngine.UIElements.Length other)
  RVA=0x09F3C0A8  token=0x6001145  System.Boolean Equals(System.Object obj)
  RVA=0x09F35528  token=0x6001146  System.Int32 GetHashCode()
  RVA=0x09F3C188  token=0x6001147  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.Rotate
TYPE:  sealed struct
TOKEN: 0x200025E
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Angle    m_Angle  // 0x10
  private           UnityEngine.Vector3             m_Axis  // 0x18
  private           System.Boolean                  m_IsNone  // 0x24
PROPERTIES:
  angle  get=0x020C61B0  set=0x03D51730
  axis  get=0x03D5E630
METHODS:
  RVA=0x09F3E868  token=0x6001148  System.Void .ctor(UnityEngine.UIElements.Angle angle)
  RVA=0x09F3E6E4  token=0x6001149  UnityEngine.UIElements.Rotate Initial()
  RVA=0x09F3E760  token=0x600114A  UnityEngine.UIElements.Rotate None()
  RVA=0x09F3E88C  token=0x600114E  System.Boolean op_Equality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs)
  RVA=0x09F3E980  token=0x600114F  System.Boolean op_Inequality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs)
  RVA=0x09F3E620  token=0x6001150  System.Boolean Equals(UnityEngine.UIElements.Rotate other)
  RVA=0x09F3E588  token=0x6001151  System.Boolean Equals(System.Object obj)
  RVA=0x09F3E664  token=0x6001152  System.Int32 GetHashCode()
  RVA=0x09F3E808  token=0x6001153  System.String ToString()
  RVA=0x09F3E7AC  token=0x6001154  UnityEngine.Quaternion ToQuaternion()
END_CLASS

CLASS: UnityEngine.UIElements.Scale
TYPE:  sealed struct
TOKEN: 0x200025F
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.Vector3             m_Scale  // 0x10
  private           System.Boolean                  m_IsNone  // 0x1c
PROPERTIES:
  value  get=0x03D56520
METHODS:
  RVA=0x03D892B0  token=0x6001155  System.Void .ctor(UnityEngine.Vector3 scale)
  RVA=0x09F3EC3C  token=0x6001156  UnityEngine.UIElements.Scale Initial()
  RVA=0x09F3EC90  token=0x6001157  UnityEngine.UIElements.Scale None()
  RVA=0x09F3ECD8  token=0x6001159  System.Boolean op_Equality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs)
  RVA=0x09F3ED2C  token=0x600115A  System.Boolean op_Inequality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs)
  RVA=0x09F3EB78  token=0x600115B  System.Boolean Equals(UnityEngine.UIElements.Scale other)
  RVA=0x09F3EBA4  token=0x600115C  System.Boolean Equals(System.Object obj)
  RVA=0x09F3EC28  token=0x600115D  System.Int32 GetHashCode()
  RVA=0x09F3ECCC  token=0x600115E  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleColor
TYPE:  sealed struct
TOKEN: 0x2000260
SIZE:  0x24
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.Color               m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x20
PROPERTIES:
  value  get=0x09F3EEB4
  keyword  get=0x03D85B00
METHODS:
  RVA=0x03D70590  token=0x6001161  System.Void .ctor(UnityEngine.Color v)
  RVA=0x03D675E0  token=0x6001162  System.Void .ctor(UnityEngine.Color v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3EEE0  token=0x6001163  System.Boolean op_Equality(UnityEngine.UIElements.StyleColor lhs, UnityEngine.UIElements.StyleColor rhs)
  RVA=0x03D892E0  token=0x6001164  UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color v)
  RVA=0x09F3ED5C  token=0x6001165  System.Boolean Equals(UnityEngine.UIElements.StyleColor other)
  RVA=0x09F3ED98  token=0x6001166  System.Boolean Equals(System.Object obj)
  RVA=0x09F3EE2C  token=0x6001167  System.Int32 GetHashCode()
  RVA=0x09F3EE4C  token=0x6001168  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleCursor
TYPE:  sealed struct
TOKEN: 0x2000261
SIZE:  0x30
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Cursor   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x28
PROPERTIES:
  value  get=0x09F3F0BC
  keyword  get=0x03D68AE0
METHODS:
  RVA=0x09F3F078  token=0x600116B  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F0A0  token=0x600116C  System.Void .ctor(UnityEngine.UIElements.Cursor v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F0F0  token=0x600116D  System.Boolean op_Equality(UnityEngine.UIElements.StyleCursor lhs, UnityEngine.UIElements.StyleCursor rhs)
  RVA=0x09F3F150  token=0x600116E  UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3EF30  token=0x600116F  System.Boolean Equals(UnityEngine.UIElements.StyleCursor other)
  RVA=0x09F3EF70  token=0x6001170  System.Boolean Equals(System.Object obj)
  RVA=0x09F3EFF0  token=0x6001171  System.Int32 GetHashCode()
  RVA=0x09F3F010  token=0x6001172  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleDataRef`1
TYPE:  sealed struct
TOKEN: 0x2000262
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.StyleDataRef.RefCounted<T>m_Ref  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6001173  UnityEngine.UIElements.StyleDataRef<T> Acquire()
  RVA=-1  // not resolved  token=0x6001174  System.Void Release()
  RVA=-1  // not resolved  token=0x6001175  System.Void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other)
  RVA=-1  // not resolved  token=0x6001176  T& Read()
  RVA=-1  // not resolved  token=0x6001177  T& Write()
  RVA=-1  // not resolved  token=0x6001178  UnityEngine.UIElements.StyleDataRef<T> Create()
  RVA=-1  // not resolved  token=0x6001179  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x600117A  System.Boolean op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs)
  RVA=-1  // not resolved  token=0x600117B  System.Boolean Equals(UnityEngine.UIElements.StyleDataRef<T> other)
  RVA=-1  // not resolved  token=0x600117C  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: UnityEngine.UIElements.StyleEnum`1
TYPE:  sealed struct
TOKEN: 0x2000264
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           T                               m_Value  // 0x0
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x0
PROPERTIES:
  value  get=-1  // not resolved
  keyword  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6001185  System.Void .ctor(T v)
  RVA=-1  // not resolved  token=0x6001186  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=-1  // not resolved  token=0x6001187  System.Void .ctor(T v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=-1  // not resolved  token=0x6001188  System.Boolean op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs)
  RVA=-1  // not resolved  token=0x6001189  System.Boolean op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs)
  RVA=-1  // not resolved  token=0x600118A  UnityEngine.UIElements.StyleEnum<T> op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=-1  // not resolved  token=0x600118B  UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v)
  RVA=-1  // not resolved  token=0x600118C  System.Boolean Equals(UnityEngine.UIElements.StyleEnum<T> other)
  RVA=-1  // not resolved  token=0x600118D  System.Boolean Equals(System.Object obj)
  RVA=-1  // not resolved  token=0x600118E  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x600118F  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleFloat
TYPE:  sealed struct
TOKEN: 0x2000265
SIZE:  0x18
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x14
PROPERTIES:
  value  get=0x09F3F278
  keyword  get=0x03D698C0
METHODS:
  RVA=0x03D4F9F0  token=0x6001192  System.Void .ctor(System.Single v)
  RVA=0x03D89300  token=0x6001193  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D4F9E0  token=0x6001194  System.Void .ctor(System.Single v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F288  token=0x6001195  System.Boolean op_Equality(UnityEngine.UIElements.StyleFloat lhs, UnityEngine.UIElements.StyleFloat rhs)
  RVA=0x03D89310  token=0x6001196  UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D89240  token=0x6001197  UnityEngine.UIElements.StyleFloat op_Implicit(System.Single v)
  RVA=0x09F3F204  token=0x6001198  System.Boolean Equals(UnityEngine.UIElements.StyleFloat other)
  RVA=0x09F3F194  token=0x6001199  System.Boolean Equals(System.Object obj)
  RVA=0x09F35528  token=0x600119A  System.Int32 GetHashCode()
  RVA=0x09F3F218  token=0x600119B  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleInt
TYPE:  sealed struct
TOKEN: 0x2000266
SIZE:  0x18
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           System.Int32                    m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x14
PROPERTIES:
  value  get=0x07D32E6C
  keyword  get=0x03D698C0
METHODS:
  RVA=0x03D89300  token=0x600119E  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D698B0  token=0x600119F  System.Void .ctor(System.Int32 v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F398  token=0x60011A0  System.Boolean op_Equality(UnityEngine.UIElements.StyleInt lhs, UnityEngine.UIElements.StyleInt rhs)
  RVA=0x03D89310  token=0x60011A1  UnityEngine.UIElements.StyleInt op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F324  token=0x60011A2  System.Boolean Equals(UnityEngine.UIElements.StyleInt other)
  RVA=0x09F3F2B4  token=0x60011A3  System.Boolean Equals(System.Object obj)
  RVA=0x03D86E80  token=0x60011A4  System.Int32 GetHashCode()
  RVA=0x09F3F338  token=0x60011A5  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleLength
TYPE:  sealed struct
TOKEN: 0x2000267
SIZE:  0x1C
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Length   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x18
PROPERTIES:
  value  get=0x09F3F594
  keyword  get=0x03D68070
METHODS:
  RVA=0x09F3F514  token=0x60011A8  System.Void .ctor(System.Single v)
  RVA=0x09F3F588  token=0x60011A9  System.Void .ctor(UnityEngine.UIElements.Length v)
  RVA=0x09F3F550  token=0x60011AA  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F560  token=0x60011AB  System.Void .ctor(UnityEngine.UIElements.Length v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F5AC  token=0x60011AC  System.Boolean op_Equality(UnityEngine.UIElements.StyleLength lhs, UnityEngine.UIElements.StyleLength rhs)
  RVA=0x09F3F610  token=0x60011AD  UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F64C  token=0x60011AE  UnityEngine.UIElements.StyleLength op_Implicit(System.Single v)
  RVA=0x09F3F5D0  token=0x60011AF  UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.Length v)
  RVA=0x09F3F3B4  token=0x60011B0  System.Boolean Equals(UnityEngine.UIElements.StyleLength other)
  RVA=0x09F3F3F4  token=0x60011B1  System.Boolean Equals(System.Object obj)
  RVA=0x09F3F48C  token=0x60011B2  System.Int32 GetHashCode()
  RVA=0x09F3F4AC  token=0x60011B3  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleRotate
TYPE:  sealed struct
TOKEN: 0x2000268
SIZE:  0x2C
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Rotate   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x28
PROPERTIES:
  value  get=0x09F3F0BC
  keyword  get=0x03D68AE0
METHODS:
  RVA=0x03D89330  token=0x60011B6  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D67550  token=0x60011B7  System.Void .ctor(UnityEngine.UIElements.Rotate v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F7F4  token=0x60011B8  System.Boolean op_Equality(UnityEngine.UIElements.StyleRotate lhs, UnityEngine.UIElements.StyleRotate rhs)
  RVA=0x03D89360  token=0x60011B9  UnityEngine.UIElements.StyleRotate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F714  token=0x60011BA  System.Boolean Equals(UnityEngine.UIElements.StyleRotate other)
  RVA=0x09F3F688  token=0x60011BB  System.Boolean Equals(System.Object obj)
  RVA=0x09F3F764  token=0x60011BC  System.Int32 GetHashCode()
  RVA=0x09F3F784  token=0x60011BD  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleScale
TYPE:  sealed struct
TOKEN: 0x2000269
SIZE:  0x24
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Scale    m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x20
PROPERTIES:
  value  get=0x09F3F9C4
  keyword  get=0x03D85B00
METHODS:
  RVA=0x03D89390  token=0x60011C0  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D675E0  token=0x60011C1  System.Void .ctor(UnityEngine.UIElements.Scale v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F9DC  token=0x60011C2  System.Boolean op_Equality(UnityEngine.UIElements.StyleScale lhs, UnityEngine.UIElements.StyleScale rhs)
  RVA=0x03D893A0  token=0x60011C3  UnityEngine.UIElements.StyleScale op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3F86C  token=0x60011C4  System.Boolean Equals(UnityEngine.UIElements.StyleScale other)
  RVA=0x09F3F8A8  token=0x60011C5  System.Boolean Equals(System.Object obj)
  RVA=0x09F3F93C  token=0x60011C6  System.Int32 GetHashCode()
  RVA=0x09F3F95C  token=0x60011C7  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleTranslate
TYPE:  sealed struct
TOKEN: 0x200026A
SIZE:  0x2C
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Translatem_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x28
PROPERTIES:
  value  get=0x09F3F0BC
  keyword  get=0x03D68AE0
METHODS:
  RVA=0x03D894A0  token=0x60011CA  System.Void .ctor(UnityEngine.UIElements.Translate v)
  RVA=0x03D89330  token=0x60011CB  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D67550  token=0x60011CC  System.Void .ctor(UnityEngine.UIElements.Translate v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3FFF0  token=0x60011CD  System.Boolean op_Equality(UnityEngine.UIElements.StyleTranslate lhs, UnityEngine.UIElements.StyleTranslate rhs)
  RVA=0x03D89360  token=0x60011CE  UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D894C0  token=0x60011CF  UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.Translate v)
  RVA=0x09F3FE84  token=0x60011D0  System.Boolean Equals(UnityEngine.UIElements.StyleTranslate other)
  RVA=0x09F3FED4  token=0x60011D1  System.Boolean Equals(System.Object obj)
  RVA=0x09F3FF60  token=0x60011D2  System.Int32 GetHashCode()
  RVA=0x09F3FF80  token=0x60011D3  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleTextShadow
TYPE:  sealed struct
TOKEN: 0x200026B
SIZE:  0x30
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x10
  private           UnityEngine.UIElements.TextShadowm_Value  // 0x14
PROPERTIES:
  value  get=0x09F3FB94
  keyword  get=0x03D85860
METHODS:
  RVA=0x03D893B0  token=0x60011D6  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D893E0  token=0x60011D7  System.Void .ctor(UnityEngine.UIElements.TextShadow v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3FBD0  token=0x60011D8  System.Boolean op_Equality(UnityEngine.UIElements.StyleTextShadow lhs, UnityEngine.UIElements.StyleTextShadow rhs)
  RVA=0x03D89400  token=0x60011D9  UnityEngine.UIElements.StyleTextShadow op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3FAC4  token=0x60011DA  System.Boolean Equals(UnityEngine.UIElements.StyleTextShadow other)
  RVA=0x09F3FA30  token=0x60011DB  System.Boolean Equals(System.Object obj)
  RVA=0x09F3FB04  token=0x60011DC  System.Int32 GetHashCode()
  RVA=0x09F3FB2C  token=0x60011DD  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleTransformOrigin
TYPE:  sealed struct
TOKEN: 0x200026C
SIZE:  0x28
IMPLEMENTS: UnityEngine.UIElements.IStyleValue`1 System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.TransformOriginm_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x24
PROPERTIES:
  value  get=0x09F3FDD4
  keyword  get=0x03D4FB00
METHODS:
  RVA=0x03D89440  token=0x60011E0  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x03D89450  token=0x60011E1  System.Void .ctor(UnityEngine.UIElements.TransformOrigin v, UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3FDF4  token=0x60011E2  System.Boolean op_Equality(UnityEngine.UIElements.StyleTransformOrigin lhs, UnityEngine.UIElements.StyleTransformOrigin rhs)
  RVA=0x03D89470  token=0x60011E3  UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F3FC6C  token=0x60011E4  System.Boolean Equals(UnityEngine.UIElements.StyleTransformOrigin other)
  RVA=0x09F3FCB0  token=0x60011E5  System.Boolean Equals(System.Object obj)
  RVA=0x09F3FD48  token=0x60011E6  System.Int32 GetHashCode()
  RVA=0x09F3FD68  token=0x60011E7  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.IStyleValue`1
TYPE:  interface
TOKEN: 0x200026D
FIELDS:
PROPERTIES:
  value  get=-1  // abstract
  keyword  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleKeyword
TYPE:  sealed struct
TOKEN: 0x200026E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleKeywordUndefined  // const
  public    static  UnityEngine.UIElements.StyleKeywordNull  // const
  public    static  UnityEngine.UIElements.StyleKeywordAuto  // const
  public    static  UnityEngine.UIElements.StyleKeywordNone  // const
  public    static  UnityEngine.UIElements.StyleKeywordInitial  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueExtensions
TYPE:  static class
TOKEN: 0x200026F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60011EA  System.String DebugString(UnityEngine.UIElements.IStyleValue<T> styleValue)
  RVA=0x09F40888  token=0x60011EB  UnityEngine.Yoga.YogaValue ToYogaValue(UnityEngine.UIElements.Length length)
  RVA=0x09F404D4  token=0x60011EC  UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F405CC  token=0x60011ED  UnityEngine.UIElements.Rotate ToRotate(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F406C0  token=0x60011EE  UnityEngine.UIElements.Scale ToScale(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F40794  token=0x60011EF  UnityEngine.UIElements.Translate ToTranslate(UnityEngine.UIElements.StyleKeyword keyword)
  RVA=0x09F405A4  token=0x60011F0  UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleLength styleLength)
  RVA=-1  // generic def  token=0x60011F1  System.Void CopyFrom(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other)
END_CLASS

CLASS: UnityEngine.UIElements.TimeUnit
TYPE:  sealed struct
TOKEN: 0x2000270
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TimeUnit Second  // const
  public    static  UnityEngine.UIElements.TimeUnit Millisecond  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TimeValue
TYPE:  sealed struct
TOKEN: 0x2000271
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.TimeUnit m_Unit  // 0x14
PROPERTIES:
  value  get=0x03D4FA00
  unit  get=0x03D4E990
METHODS:
  RVA=0x03D4F9F0  token=0x60011F4  System.Void .ctor(System.Single value)
  RVA=0x03D4F9E0  token=0x60011F5  System.Void .ctor(System.Single value, UnityEngine.UIElements.TimeUnit unit)
  RVA=0x03D89240  token=0x60011F6  UnityEngine.UIElements.TimeValue op_Implicit(System.Single value)
  RVA=0x09F356E0  token=0x60011F7  System.Boolean op_Equality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs)
  RVA=0x09F3C318  token=0x60011F8  System.Boolean op_Inequality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs)
  RVA=0x09F35514  token=0x60011F9  System.Boolean Equals(UnityEngine.UIElements.TimeValue other)
  RVA=0x09F41FDC  token=0x60011FA  System.Boolean Equals(System.Object obj)
  RVA=0x09F35528  token=0x60011FB  System.Int32 GetHashCode()
  RVA=0x09F4204C  token=0x60011FC  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.TransformOrigin
TYPE:  sealed struct
TOKEN: 0x2000272
SIZE:  0x24
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Length   m_X  // 0x10
  private           UnityEngine.UIElements.Length   m_Y  // 0x18
  private           System.Single                   m_Z  // 0x20
PROPERTIES:
  x  get=0x020C61B0  set=0x03D51730
  y  get=0x03D50DE0  set=0x03D55BA0
  z  get=0x03D4E7A0
METHODS:
  RVA=0x03D6B6A0  token=0x60011FD  System.Void .ctor(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, System.Single z)
  RVA=0x09F42240  token=0x60011FE  UnityEngine.UIElements.TransformOrigin Initial()
  RVA=0x09F423AC  token=0x6001204  System.Boolean op_Equality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs)
  RVA=0x09F42438  token=0x6001205  System.Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs)
  RVA=0x09F42114  token=0x6001206  System.Boolean Equals(UnityEngine.UIElements.TransformOrigin other)
  RVA=0x09F42150  token=0x6001207  System.Boolean Equals(System.Object obj)
  RVA=0x09F421E4  token=0x6001208  System.Int32 GetHashCode()
  RVA=0x09F4228C  token=0x6001209  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.Translate
TYPE:  sealed struct
TOKEN: 0x2000273
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.UIElements.Length   m_X  // 0x10
  private           UnityEngine.UIElements.Length   m_Y  // 0x18
  private           System.Single                   m_Z  // 0x20
  private           System.Boolean                  m_isNone  // 0x24
PROPERTIES:
  x  get=0x020C61B0  set=0x03D51730
  y  get=0x03D50DE0  set=0x03D55BA0
  z  get=0x03D4E7A0
METHODS:
  RVA=0x03D89520  token=0x600120A  System.Void .ctor(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, System.Single z)
  RVA=0x03D894F0  token=0x600120B  UnityEngine.UIElements.Translate None()
  RVA=0x09F42670  token=0x6001211  System.Boolean op_Equality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs)
  RVA=0x09F42764  token=0x6001212  System.Boolean op_Inequality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs)
  RVA=0x09F42474  token=0x6001213  System.Boolean Equals(UnityEngine.UIElements.Translate other)
  RVA=0x09F424B8  token=0x6001214  System.Boolean Equals(System.Object obj)
  RVA=0x09F421E4  token=0x6001215  System.Int32 GetHashCode()
  RVA=0x09F42550  token=0x6001216  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.IResolvedStyle
TYPE:  interface
TOKEN: 0x2000274
FIELDS:
PROPERTIES:
  backgroundColor  get=-1  // abstract
  borderBottomColor  get=-1  // abstract
  borderBottomLeftRadius  get=-1  // abstract
  borderBottomRightRadius  get=-1  // abstract
  borderBottomWidth  get=-1  // abstract
  borderLeftColor  get=-1  // abstract
  borderLeftWidth  get=-1  // abstract
  borderRightColor  get=-1  // abstract
  borderRightWidth  get=-1  // abstract
  borderTopColor  get=-1  // abstract
  borderTopLeftRadius  get=-1  // abstract
  borderTopRightRadius  get=-1  // abstract
  borderTopWidth  get=-1  // abstract
  bottom  get=-1  // abstract
  color  get=-1  // abstract
  display  get=-1  // abstract
  flexDirection  get=-1  // abstract
  flexGrow  get=-1  // abstract
  flexShrink  get=-1  // abstract
  height  get=-1  // abstract
  left  get=-1  // abstract
  marginBottom  get=-1  // abstract
  marginLeft  get=-1  // abstract
  marginRight  get=-1  // abstract
  marginTop  get=-1  // abstract
  minHeight  get=-1  // abstract
  minWidth  get=-1  // abstract
  opacity  get=-1  // abstract
  paddingBottom  get=-1  // abstract
  paddingLeft  get=-1  // abstract
  paddingRight  get=-1  // abstract
  paddingTop  get=-1  // abstract
  right  get=-1  // abstract
  scale  get=-1  // abstract
  top  get=-1  // abstract
  transformOrigin  get=-1  // abstract
  translate  get=-1  // abstract
  unityBackgroundImageTintColor  get=-1  // abstract
  unitySliceLeft  get=-1  // abstract
  unitySliceRight  get=-1  // abstract
  unityTextOutlineColor  get=-1  // abstract
  unityTextOutlineWidth  get=-1  // abstract
  visibility  get=-1  // abstract
  whiteSpace  get=-1  // abstract
  width  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IStyle
TYPE:  interface
TOKEN: 0x2000275
FIELDS:
PROPERTIES:
  backgroundColor  set=-1  // abstract
  borderBottomColor  set=-1  // abstract
  borderBottomLeftRadius  set=-1  // abstract
  borderBottomRightRadius  set=-1  // abstract
  borderBottomWidth  set=-1  // abstract
  borderLeftColor  set=-1  // abstract
  borderLeftWidth  set=-1  // abstract
  borderRightColor  set=-1  // abstract
  borderRightWidth  set=-1  // abstract
  borderTopColor  set=-1  // abstract
  borderTopLeftRadius  set=-1  // abstract
  borderTopRightRadius  set=-1  // abstract
  borderTopWidth  set=-1  // abstract
  bottom  set=-1  // abstract
  color  set=-1  // abstract
  cursor  get=-1  // abstract
  display  get=-1  // abstract  set=-1  // abstract
  flexBasis  set=-1  // abstract
  flexDirection  set=-1  // abstract
  flexGrow  set=-1  // abstract
  flexShrink  set=-1  // abstract
  fontSize  set=-1  // abstract
  height  set=-1  // abstract
  left  set=-1  // abstract
  marginBottom  set=-1  // abstract
  marginLeft  set=-1  // abstract
  marginRight  set=-1  // abstract
  marginTop  set=-1  // abstract
  maxHeight  set=-1  // abstract
  maxWidth  set=-1  // abstract
  minWidth  set=-1  // abstract
  opacity  set=-1  // abstract
  paddingBottom  set=-1  // abstract
  paddingLeft  set=-1  // abstract
  paddingRight  set=-1  // abstract
  paddingTop  get=-1  // abstract  set=-1  // abstract
  position  set=-1  // abstract
  right  set=-1  // abstract
  rotate  get=-1  // abstract
  scale  get=-1  // abstract
  textShadow  get=-1  // abstract
  top  set=-1  // abstract
  transformOrigin  get=-1  // abstract
  translate  get=-1  // abstract  set=-1  // abstract
  unityBackgroundImageTintColor  set=-1  // abstract
  visibility  set=-1  // abstract
  width  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IStyleDataGroup`1
TYPE:  interface
TOKEN: 0x2000276
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6001277  T Copy()
  RVA=-1  // abstract  token=0x6001278  System.Void CopyFrom(T& other)
END_CLASS

CLASS: UnityEngine.UIElements.InheritedData
TYPE:  sealed struct
TOKEN: 0x2000277
SIZE:  0xA0
IMPLEMENTS: UnityEngine.UIElements.IStyleDataGroup`1 System.IEquatable`1
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            UnityEngine.UIElements.Length   fontSize  // 0x20
  public            UnityEngine.UIElements.Length   letterSpacing  // 0x28
  public            UnityEngine.UIElements.TextShadowtextShadow  // 0x30
  public            UnityEngine.Font                unityFont  // 0x50
  public            UnityEngine.UIElements.FontDefinitionunityFontDefinition  // 0x58
  public            UnityEngine.FontStyle           unityFontStyleAndWeight  // 0x68
  public            UnityEngine.UIElements.Length   unityParagraphSpacing  // 0x6c
  public            UnityEngine.TextAnchor          unityTextAlign  // 0x74
  public            UnityEngine.Color               unityTextOutlineColor  // 0x78
  public            System.Single                   unityTextOutlineWidth  // 0x88
  public            UnityEngine.UIElements.Visibilityvisibility  // 0x8c
  public            UnityEngine.UIElements.WhiteSpacewhiteSpace  // 0x90
  public            UnityEngine.UIElements.Length   wordSpacing  // 0x94
METHODS:
  RVA=0x03D896E0  token=0x6001279  UnityEngine.UIElements.InheritedData Copy()
  RVA=0x09F462C8  token=0x600127A  System.Void CopyFrom(UnityEngine.UIElements.InheritedData& other)
  RVA=0x09F4667C  token=0x600127B  System.Boolean op_Equality(UnityEngine.UIElements.InheritedData lhs, UnityEngine.UIElements.InheritedData rhs)
  RVA=0x09F46384  token=0x600127C  System.Boolean Equals(UnityEngine.UIElements.InheritedData other)
  RVA=0x09F46450  token=0x600127D  System.Boolean Equals(System.Object obj)
  RVA=0x09F4651C  token=0x600127E  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.LayoutData
TYPE:  sealed struct
TOKEN: 0x2000278
SIZE:  0xE0
IMPLEMENTS: UnityEngine.UIElements.IStyleDataGroup`1 System.IEquatable`1
FIELDS:
  public            UnityEngine.UIElements.Align    alignContent  // 0x10
  public            UnityEngine.UIElements.Align    alignItems  // 0x14
  public            UnityEngine.UIElements.Align    alignSelf  // 0x18
  public            System.Single                   borderBottomWidth  // 0x1c
  public            System.Single                   borderLeftWidth  // 0x20
  public            System.Single                   borderRightWidth  // 0x24
  public            System.Single                   borderTopWidth  // 0x28
  public            UnityEngine.UIElements.Length   bottom  // 0x2c
  public            UnityEngine.UIElements.DisplayStyledisplay  // 0x34
  public            UnityEngine.UIElements.Length   flexBasis  // 0x38
  public            UnityEngine.UIElements.FlexDirectionflexDirection  // 0x40
  public            System.Single                   flexGrow  // 0x44
  public            System.Single                   flexShrink  // 0x48
  public            UnityEngine.UIElements.Wrap     flexWrap  // 0x4c
  public            UnityEngine.UIElements.Length   height  // 0x50
  public            UnityEngine.UIElements.Justify  justifyContent  // 0x58
  public            UnityEngine.UIElements.Length   left  // 0x5c
  public            UnityEngine.UIElements.Length   marginBottom  // 0x64
  public            UnityEngine.UIElements.Length   marginLeft  // 0x6c
  public            UnityEngine.UIElements.Length   marginRight  // 0x74
  public            UnityEngine.UIElements.Length   marginTop  // 0x7c
  public            UnityEngine.UIElements.Length   maxHeight  // 0x84
  public            UnityEngine.UIElements.Length   maxWidth  // 0x8c
  public            UnityEngine.UIElements.Length   minHeight  // 0x94
  public            UnityEngine.UIElements.Length   minWidth  // 0x9c
  public            UnityEngine.UIElements.Length   paddingBottom  // 0xa4
  public            UnityEngine.UIElements.Length   paddingLeft  // 0xac
  public            UnityEngine.UIElements.Length   paddingRight  // 0xb4
  public            UnityEngine.UIElements.Length   paddingTop  // 0xbc
  public            UnityEngine.UIElements.Position position  // 0xc4
  public            UnityEngine.UIElements.Length   right  // 0xc8
  public            UnityEngine.UIElements.Length   top  // 0xd0
  public            UnityEngine.UIElements.Length   width  // 0xd8
METHODS:
  RVA=0x03D89840  token=0x600127F  UnityEngine.UIElements.LayoutData Copy()
  RVA=0x03D89730  token=0x6001280  System.Void CopyFrom(UnityEngine.UIElements.LayoutData& other)
  RVA=0x09F475A4  token=0x6001281  System.Boolean op_Equality(UnityEngine.UIElements.LayoutData lhs, UnityEngine.UIElements.LayoutData rhs)
  RVA=0x09F47218  token=0x6001282  System.Boolean Equals(UnityEngine.UIElements.LayoutData other)
  RVA=0x09F47120  token=0x6001283  System.Boolean Equals(System.Object obj)
  RVA=0x09F47324  token=0x6001284  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.RareData
TYPE:  sealed struct
TOKEN: 0x2000279
SIZE:  0x58
IMPLEMENTS: UnityEngine.UIElements.IStyleDataGroup`1 System.IEquatable`1
FIELDS:
  public            UnityEngine.UIElements.Cursor   cursor  // 0x10
  public            UnityEngine.UIElements.TextOverflowtextOverflow  // 0x28
  public            UnityEngine.Color               unityBackgroundImageTintColor  // 0x2c
  public            UnityEngine.ScaleMode           unityBackgroundScaleMode  // 0x3c
  public            UnityEngine.UIElements.OverflowClipBoxunityOverflowClipBox  // 0x40
  public            System.Int32                    unitySliceBottom  // 0x44
  public            System.Int32                    unitySliceLeft  // 0x48
  public            System.Int32                    unitySliceRight  // 0x4c
  public            System.Int32                    unitySliceTop  // 0x50
  public            UnityEngine.UIElements.TextOverflowPositionunityTextOverflowPosition  // 0x54
METHODS:
  RVA=0x03D89980  token=0x6001285  UnityEngine.UIElements.RareData Copy()
  RVA=0x09F501B4  token=0x6001286  System.Void CopyFrom(UnityEngine.UIElements.RareData& other)
  RVA=0x09F50378  token=0x6001287  System.Boolean op_Equality(UnityEngine.UIElements.RareData lhs, UnityEngine.UIElements.RareData rhs)
  RVA=0x09F50284  token=0x6001288  System.Boolean Equals(UnityEngine.UIElements.RareData other)
  RVA=0x09F501E4  token=0x6001289  System.Boolean Equals(System.Object obj)
  RVA=0x09F50300  token=0x600128A  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.TransformData
TYPE:  sealed struct
TOKEN: 0x200027A
SIZE:  0x64
IMPLEMENTS: UnityEngine.UIElements.IStyleDataGroup`1 System.IEquatable`1
FIELDS:
  public            UnityEngine.UIElements.Rotate   rotate  // 0x10
  public            UnityEngine.UIElements.Scale    scale  // 0x28
  public            UnityEngine.UIElements.TransformOrigintransformOrigin  // 0x38
  public            UnityEngine.UIElements.Translatetranslate  // 0x4c
METHODS:
  RVA=0x03D89A50  token=0x600128B  UnityEngine.UIElements.TransformData Copy()
  RVA=0x03D89A20  token=0x600128C  System.Void CopyFrom(UnityEngine.UIElements.TransformData& other)
  RVA=0x09F56914  token=0x600128D  System.Boolean op_Equality(UnityEngine.UIElements.TransformData lhs, UnityEngine.UIElements.TransformData rhs)
  RVA=0x09F5677C  token=0x600128E  System.Boolean Equals(UnityEngine.UIElements.TransformData other)
  RVA=0x09F56800  token=0x600128F  System.Boolean Equals(System.Object obj)
  RVA=0x09F568AC  token=0x6001290  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionData
TYPE:  sealed struct
TOKEN: 0x200027B
SIZE:  0x30
IMPLEMENTS: UnityEngine.UIElements.IStyleDataGroup`1 System.IEquatable`1
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>transitionDelay  // 0x10
  public            System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>transitionDuration  // 0x18
  public            System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>transitionProperty  // 0x20
  public            System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>transitionTimingFunction  // 0x28
METHODS:
  RVA=0x09F56C88  token=0x6001291  UnityEngine.UIElements.TransitionData Copy()
  RVA=0x09F56B30  token=0x6001292  System.Void CopyFrom(UnityEngine.UIElements.TransitionData& other)
  RVA=0x09F56F98  token=0x6001293  System.Boolean op_Equality(UnityEngine.UIElements.TransitionData lhs, UnityEngine.UIElements.TransitionData rhs)
  RVA=0x09F56E30  token=0x6001294  System.Boolean Equals(UnityEngine.UIElements.TransitionData other)
  RVA=0x09F56E70  token=0x6001295  System.Boolean Equals(System.Object obj)
  RVA=0x09F56F04  token=0x6001296  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.VisualData
TYPE:  sealed struct
TOKEN: 0x200027C
SIZE:  0xA8
IMPLEMENTS: UnityEngine.UIElements.IStyleDataGroup`1 System.IEquatable`1
FIELDS:
  public            UnityEngine.Color               backgroundColor  // 0x10
  public            UnityEngine.UIElements.BackgroundbackgroundImage  // 0x20
  public            UnityEngine.Color               borderBottomColor  // 0x40
  public            UnityEngine.UIElements.Length   borderBottomLeftRadius  // 0x50
  public            UnityEngine.UIElements.Length   borderBottomRightRadius  // 0x58
  public            UnityEngine.Color               borderLeftColor  // 0x60
  public            UnityEngine.Color               borderRightColor  // 0x70
  public            UnityEngine.Color               borderTopColor  // 0x80
  public            UnityEngine.UIElements.Length   borderTopLeftRadius  // 0x90
  public            UnityEngine.UIElements.Length   borderTopRightRadius  // 0x98
  public            System.Single                   opacity  // 0xa0
  public            UnityEngine.UIElements.OverflowInternaloverflow  // 0xa4
METHODS:
  RVA=0x03D89A80  token=0x6001297  UnityEngine.UIElements.VisualData Copy()
  RVA=0x09F5B0A4  token=0x6001298  System.Void CopyFrom(UnityEngine.UIElements.VisualData& other)
  RVA=0x09F5B444  token=0x6001299  System.Boolean op_Equality(UnityEngine.UIElements.VisualData lhs, UnityEngine.UIElements.VisualData rhs)
  RVA=0x09F5B17C  token=0x600129A  System.Boolean Equals(UnityEngine.UIElements.VisualData other)
  RVA=0x09F5B264  token=0x600129B  System.Boolean Equals(System.Object obj)
  RVA=0x09F5B33C  token=0x600129C  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.Hashes
TYPE:  sealed struct
TOKEN: 0x200027D
SIZE:  0x20
FIELDS:
  public    static  System.Int32                    kSize  // const
  public            UnityEngine.UIElements.Hashes.<hashes>e__FixedBufferhashes  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleComplexSelector
TYPE:  class
TOKEN: 0x200027F
SIZE:  0x58
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver
FIELDS:
  public            UnityEngine.UIElements.Hashes   ancestorHashes  // 0x10
  private           System.Int32                    m_Specificity  // 0x20
  private           UnityEngine.UIElements.StyleRule<rule>k__BackingField  // 0x28
  private           System.Boolean                  m_isSimple  // 0x30
  private           UnityEngine.UIElements.StyleSelector[]m_Selectors  // 0x38
  private           System.Int32                    ruleIndex  // 0x40
  private           UnityEngine.UIElements.StyleComplexSelectornextInTable  // 0x48
  private           System.Int32                    orderInStyleSheet  // 0x50
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector.PseudoStateData>s_PseudoStates  // static @ 0x0
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart>m_HashList  // static @ 0x8
PROPERTIES:
  specificity  get=0x03D86CC0
  rule  get=0x03D4EAC0  set=0x02C92F10
  isSimple  get=0x03D86CA0
  selectors  get=0x03D86EB0  set=0x09F510AC
METHODS:
  RVA=0x0350B670  token=0x60012A3  System.Void OnBeforeSerialize()
  RVA=0x09F50E18  token=0x60012A4  System.Void OnAfterDeserialize()
  RVA=0x09F508B4  token=0x60012A5  System.Void CachePseudoStateMasks()
  RVA=0x09F50E3C  token=0x60012A6  System.String ToString()
  RVA=0x0350B670  token=0x60012A7  System.Void .ctor()
  RVA=0x09F51018  token=0x60012A8  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleProperty
TYPE:  class
TOKEN: 0x2000282
SIZE:  0x30
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           System.Int32                    m_Line  // 0x18
  private           UnityEngine.UIElements.StyleValueHandle[]m_Values  // 0x20
  private           System.Boolean                  isCustomProperty  // 0x28
  private           System.Boolean                  requireVariableResolve  // 0x29
PROPERTIES:
  name  get=0x03D66B80
  values  get=0x03D85A20
METHODS:
  RVA=0x0350B670  token=0x60012AF  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleRule
TYPE:  class
TOKEN: 0x2000283
SIZE:  0x20
FIELDS:
  private           UnityEngine.UIElements.StyleProperty[]m_Properties  // 0x10
  private           System.Int32                    line  // 0x18
  private           System.Int32                    customPropertiesCount  // 0x1c
PROPERTIES:
  properties  get=0x03D66B80
METHODS:
  RVA=0x0350B670  token=0x60012B1  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelector
TYPE:  class
TOKEN: 0x2000284
SIZE:  0x28
FIELDS:
  private           UnityEngine.UIElements.StyleSelectorPart[]m_Parts  // 0x10
  private           UnityEngine.UIElements.StyleSelectorRelationshipm_PreviousRelationship  // 0x18
  private           System.Int32                    pseudoStateMask  // 0x1c
  private           System.Int32                    negatedPseudoStateMask  // 0x20
PROPERTIES:
  parts  get=0x03D66B80  set=0x0426FEE0
  previousRelationship  get=0x03D68AE0  set=0x03D4E9C0
METHODS:
  RVA=0x09F512A8  token=0x60012B6  System.String ToString()
  RVA=0x03D899B0  token=0x60012B7  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelectorPart
TYPE:  sealed struct
TOKEN: 0x2000286
SIZE:  0x28
FIELDS:
  private           System.String                   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleSelectorTypem_Type  // 0x18
  private           System.Object                   tempData  // 0x20
PROPERTIES:
  value  get=0x0253BE20
  type  get=0x03D68070  set=0x03D51710
METHODS:
  RVA=0x09F511D0  token=0x60012BE  System.String ToString()
  RVA=0x09F510E0  token=0x60012BF  UnityEngine.UIElements.StyleSelectorPart CreateClass(System.String className)
  RVA=0x09F51130  token=0x60012C0  UnityEngine.UIElements.StyleSelectorPart CreateId(System.String Id)
  RVA=0x09F51180  token=0x60012C1  UnityEngine.UIElements.StyleSelectorPart CreatePredicate(System.Object predicate)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelectorRelationship
TYPE:  sealed struct
TOKEN: 0x2000287
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSelectorRelationshipNone  // const
  public    static  UnityEngine.UIElements.StyleSelectorRelationshipChild  // const
  public    static  UnityEngine.UIElements.StyleSelectorRelationshipDescendent  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelectorType
TYPE:  sealed struct
TOKEN: 0x2000288
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSelectorTypeUnknown  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypeWildcard  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypeType  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypeClass  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypePseudoClass  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypeRecursivePseudoClass  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypeID  // const
  public    static  UnityEngine.UIElements.StyleSelectorTypePredicate  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheet
TYPE:  class
TOKEN: 0x2000289
SIZE:  0x98
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private           System.Boolean                  m_ImportedWithErrors  // 0x18
  private           System.Boolean                  m_ImportedWithWarnings  // 0x19
  private           UnityEngine.UIElements.StyleRule[]m_Rules  // 0x20
  private           UnityEngine.UIElements.StyleComplexSelector[]m_ComplexSelectors  // 0x28
  private           System.Single[]                 floats  // 0x30
  private           UnityEngine.UIElements.StyleSheets.Dimension[]dimensions  // 0x38
  private           UnityEngine.Color[]             colors  // 0x40
  private           System.String[]                 strings  // 0x48
  private           UnityEngine.Object[]            assets  // 0x50
  private           UnityEngine.UIElements.StyleSheet.ImportStruct[]imports  // 0x58
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>m_FlattenedImportedStyleSheets  // 0x60
  private           System.Int32                    m_ContentHash  // 0x68
  private           UnityEngine.UIElements.StyleSheets.ScalableImage[]scalableImages  // 0x70
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector>orderedNameSelectors  // 0x78
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector>orderedTypeSelectors  // 0x80
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector>orderedClassSelectors  // 0x88
  private           System.Boolean                  m_IsDefaultStyleSheet  // 0x90
  private   static  System.String                   kCustomPropertyMarker  // static @ 0x0
PROPERTIES:
  importedWithErrors  get=0x03D899E0  set=0x01002B40
  importedWithWarnings  get=0x03D899F0  set=0x03D4EFB0
  rules  get=0x03D85A20  set=0x09F527A0
  complexSelectors  get=0x03D86CD0  set=0x09F5265C
  flattenedRecursiveImports  get=0x03D87D60
  contentHash  get=0x03D899D0  set=0x03D4EF30
  isDefaultStyleSheet  get=0x03D89A00  set=0x09F52680
METHODS:
  RVA=-1  // generic def  token=0x60012CF  System.Boolean TryCheckAccess(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle, T& value)
  RVA=-1  // generic def  token=0x60012D0  T CheckAccess(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F51680  token=0x60012D1  System.Void OnEnable()
  RVA=0x09F515FC  token=0x60012D2  System.Void FlattenImportedStyleSheetsRecursive()
  RVA=0x09F51504  token=0x60012D3  System.Void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet sheet)
  RVA=0x09F51C94  token=0x60012D4  System.Void SetupReferences()
  RVA=0x03D899C0  token=0x60012D5  UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F518A4  token=0x60012D6  System.Single ReadFloat(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F523A0  token=0x60012D7  System.Boolean TryReadFloat(UnityEngine.UIElements.StyleValueHandle handle, System.Single& value)
  RVA=0x09F51788  token=0x60012D8  UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F52230  token=0x60012D9  System.Boolean TryReadDimension(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.UIElements.StyleSheets.Dimension& value)
  RVA=0x09F516F4  token=0x60012DA  UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F521B0  token=0x60012DB  System.Boolean TryReadColor(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.Color& value)
  RVA=0x09F51BBC  token=0x60012DC  System.String ReadString(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F52500  token=0x60012DD  System.Boolean TryReadString(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  RVA=0x09F51838  token=0x60012DE  System.String ReadEnum(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F52320  token=0x60012DF  System.Boolean TryReadEnum(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  RVA=0x09F51C28  token=0x60012E0  System.String ReadVariable(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F52580  token=0x60012E1  System.Boolean TryReadVariable(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  RVA=0x09F51ABC  token=0x60012E2  System.String ReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F52480  token=0x60012E3  System.Boolean TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  RVA=0x09F51688  token=0x60012E4  UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F51A50  token=0x60012E5  System.String ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F52130  token=0x60012E6  System.Boolean TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.Object& value)
  RVA=0x03D899C0  token=0x60012E7  UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F5194C  token=0x60012E8  System.String ReadFunctionName(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F51B28  token=0x60012E9  UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F51458  token=0x60012EA  System.Boolean CustomStartsWith(System.String originalString, System.String pattern)
  RVA=0x0286F540  token=0x60012EB  System.Void .ctor()
  RVA=0x09F52600  token=0x60012EC  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueFunction
TYPE:  sealed struct
TOKEN: 0x200028B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleValueFunctionUnknown  // const
  public    static  UnityEngine.UIElements.StyleValueFunctionVar  // const
  public    static  UnityEngine.UIElements.StyleValueFunctionEnv  // const
  public    static  UnityEngine.UIElements.StyleValueFunctionLinearGradient  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueFunctionExtension
TYPE:  static class
TOKEN: 0x200028C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F527C4  token=0x60012ED  System.String ToUssString(UnityEngine.UIElements.StyleValueFunction svf)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueHandle
TYPE:  sealed struct
TOKEN: 0x200028D
SIZE:  0x18
FIELDS:
  private           UnityEngine.UIElements.StyleValueTypem_ValueType  // 0x10
  private           System.Int32                    valueIndex  // 0x14
PROPERTIES:
  valueType  get=0x03D85860  set=0x03D4E970
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueKeyword
TYPE:  sealed struct
TOKEN: 0x200028E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleValueKeywordInherit  // const
  public    static  UnityEngine.UIElements.StyleValueKeywordInitial  // const
  public    static  UnityEngine.UIElements.StyleValueKeywordAuto  // const
  public    static  UnityEngine.UIElements.StyleValueKeywordUnset  // const
  public    static  UnityEngine.UIElements.StyleValueKeywordTrue  // const
  public    static  UnityEngine.UIElements.StyleValueKeywordFalse  // const
  public    static  UnityEngine.UIElements.StyleValueKeywordNone  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueKeywordExtension
TYPE:  static class
TOKEN: 0x200028F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F528DC  token=0x60012F0  System.String ToUssString(UnityEngine.UIElements.StyleValueKeyword svk)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueType
TYPE:  sealed struct
TOKEN: 0x2000290
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleValueTypeInvalid  // const
  public    static  UnityEngine.UIElements.StyleValueTypeKeyword  // const
  public    static  UnityEngine.UIElements.StyleValueTypeFloat  // const
  public    static  UnityEngine.UIElements.StyleValueTypeDimension  // const
  public    static  UnityEngine.UIElements.StyleValueTypeColor  // const
  public    static  UnityEngine.UIElements.StyleValueTypeResourcePath  // const
  public    static  UnityEngine.UIElements.StyleValueTypeAssetReference  // const
  public    static  UnityEngine.UIElements.StyleValueTypeEnum  // const
  public    static  UnityEngine.UIElements.StyleValueTypeVariable  // const
  public    static  UnityEngine.UIElements.StyleValueTypeString  // const
  public    static  UnityEngine.UIElements.StyleValueTypeFunction  // const
  public    static  UnityEngine.UIElements.StyleValueTypeCommaSeparator  // const
  public    static  UnityEngine.UIElements.StyleValueTypeScalableImage  // const
  public    static  UnityEngine.UIElements.StyleValueTypeMissingAssetReference  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleVariable
TYPE:  sealed struct
TOKEN: 0x2000291
SIZE:  0x28
FIELDS:
  public    readonly System.String                   name  // 0x10
  public    readonly UnityEngine.UIElements.StyleSheetsheet  // 0x18
  public    readonly UnityEngine.UIElements.StyleValueHandle[]handles  // 0x20
METHODS:
  RVA=0x0314F010  token=0x60012F1  System.Void .ctor(System.String name, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles)
  RVA=0x09F53E40  token=0x60012F2  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.StyleVariableContext
TYPE:  class
TOKEN: 0x2000292
SIZE:  0x30
FIELDS:
  public    static readonly UnityEngine.UIElements.StyleVariableContextnone  // static @ 0x0
  private           System.Int32                    m_VariableHash  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleVariable>m_Variables  // 0x18
  private           System.Collections.Generic.List<System.Int32>m_SortedHash  // 0x20
  private           System.Collections.Generic.List<System.Int32>m_UnsortedHash  // 0x28
METHODS:
  RVA=0x09F52B68  token=0x60012F3  System.Void Add(UnityEngine.UIElements.StyleVariable sv)
  RVA=0x09F52A6C  token=0x60012F4  System.Void AddInitialRange(UnityEngine.UIElements.StyleVariableContext other)
  RVA=0x09F52D90  token=0x60012F5  System.Void Clear()
  RVA=0x09F530C4  token=0x60012F6  System.Void .ctor()
  RVA=0x09F52F94  token=0x60012F7  System.Void .ctor(UnityEngine.UIElements.StyleVariableContext other)
  RVA=0x09F52E1C  token=0x60012F8  System.Boolean TryFindVariable(System.String name, UnityEngine.UIElements.StyleVariable& v)
  RVA=0x03D85B00  token=0x60012F9  System.Int32 GetVariableHash()
  RVA=0x09F52F24  token=0x60012FA  System.Void .cctor()
  RVA=0x03D89A10  token=0x60012FB  System.Int32 <Add>g__ComputeOrderSensitiveHash|7_0(System.Int32 index, UnityEngine.UIElements.StyleVariableContext.<>c__DisplayClass7_0& )
END_CLASS

CLASS: UnityEngine.UIElements.StyleVariableResolver
TYPE:  class
TOKEN: 0x2000294
SIZE:  0x50
FIELDS:
  private   static  System.Int32                    kMaxResolves  // const
  private   static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParsers_SyntaxParser  // static @ 0x0
  private           UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcherm_Matcher  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_ResolvedValues  // 0x18
  private           System.Collections.Generic.Stack<System.String>m_ResolvedVarStack  // 0x20
  private           UnityEngine.UIElements.StylePropertym_Property  // 0x28
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleVariableResolver.ResolveContext>m_ContextStack  // 0x30
  private           UnityEngine.UIElements.StyleVariableResolver.ResolveContextm_CurrentContext  // 0x38
  private           UnityEngine.UIElements.StyleVariableContext<variableContext>k__BackingField  // 0x48
PROPERTIES:
  currentSheet  get=0x03D4E2A0
  currentHandles  get=0x03D4E2B0
  resolvedValues  get=0x01041090
  variableContext  get=0x03D4EA70  set=0x02692290
METHODS:
  RVA=0x09F53240  token=0x6001301  System.Void Init(UnityEngine.UIElements.StyleProperty property, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles)
  RVA=0x09F53418  token=0x6001302  System.Void PushContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles)
  RVA=0x09F53394  token=0x6001303  System.Void PopContext()
  RVA=0x09F531BC  token=0x6001304  System.Void AddValue(UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09F537FC  token=0x6001305  System.Boolean ResolveVarFunction(System.Int32& index)
  RVA=0x09F536D4  token=0x6001306  UnityEngine.UIElements.StyleVariableResolver.Result ResolveVarFunction(System.Int32& index, System.Int32 argc, System.String varName)
  RVA=0x09F53B3C  token=0x6001307  System.Boolean ValidateResolvedValues()
  RVA=0x09F538C0  token=0x6001308  UnityEngine.UIElements.StyleVariableResolver.Result ResolveVariable(System.String variableName)
  RVA=0x09F534C0  token=0x6001309  UnityEngine.UIElements.StyleVariableResolver.Result ResolveFallback(System.Int32& index)
  RVA=0x09F532EC  token=0x600130A  System.Void ParseVarFunction(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles, System.Int32& index, System.Int32& argCount, System.String& variableName)
  RVA=0x09F53CFC  token=0x600130B  System.Void .ctor()
  RVA=0x09F53C80  token=0x600130C  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ThemeStyleSheet
TYPE:  class
TOKEN: 0x2000297
SIZE:  0x98
EXTENDS: UnityEngine.UIElements.StyleSheet
FIELDS:
METHODS:
  RVA=0x09F5670C  token=0x600130D  System.Void OnEnable()
  RVA=0x09F56730  token=0x600130E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelTextSettings
TYPE:  class
TOKEN: 0x2000298
SIZE:  0xA0
EXTENDS: UnityEngine.TextCore.Text.TextSettings
FIELDS:
  private   static  UnityEngine.UIElements.PanelTextSettingss_DefaultPanelTextSettings  // static @ 0x0
  private   static  System.Func<System.String,UnityEngine.Object>EditorGUIUtilityLoad  // static @ 0x8
  private   static  System.Func<UnityEngine.SystemLanguage>GetCurrentLanguage  // static @ 0x10
  private   static readonly System.String                   s_DefaultEditorPanelTextSettingPath  // static @ 0x18
PROPERTIES:
  defaultPanelTextSettings  get=0x09F500A4
METHODS:
  RVA=0x09F4FC00  token=0x6001310  System.Void UpdateLocalizationFontAsset()
  RVA=0x09F4FBF4  token=0x6001311  UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font)
  RVA=0x09F5009C  token=0x6001312  System.Void .ctor()
  RVA=0x09F5003C  token=0x6001313  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ITextHandle
TYPE:  interface
TOKEN: 0x2000299
FIELDS:
PROPERTIES:
  MeasuredSizes  set=-1  // abstract
  RoundedSizes  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6001314  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling)
  RVA=-1  // abstract  token=0x6001315  System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=-1  // abstract  token=0x6001316  System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=-1  // abstract  token=0x6001317  System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint)
  RVA=-1  // abstract  token=0x6001318  UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint)
  RVA=-1  // abstract  token=0x6001319  System.Boolean IsLegacy()
  RVA=-1  // abstract  token=0x600131A  System.Boolean IsElided()
END_CLASS

CLASS: UnityEngine.UIElements.TextCoreHandle
TYPE:  sealed struct
TOKEN: 0x200029A
SIZE:  0x48
IMPLEMENTS: UnityEngine.UIElements.ITextHandle
FIELDS:
  private           UnityEngine.Vector2             <MeasuredSizes>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <RoundedSizes>k__BackingField  // 0x18
  private           UnityEngine.Vector2             m_PreferredSize  // 0x20
  private           System.Int32                    m_PreviousGenerationSettingsHash  // 0x28
  private           UnityEngine.TextCore.Text.TextGenerationSettingsm_CurrentGenerationSettings  // 0x30
  private   static  UnityEngine.TextCore.Text.TextGenerationSettingss_LayoutSettings  // static @ 0x0
  private           UnityEngine.TextCore.Text.TextInfom_TextInfoMesh  // 0x38
  private   static  UnityEngine.TextCore.Text.TextInfos_TextInfoLayout  // static @ 0x8
  private           System.Boolean                  isDirty  // 0x40
PROPERTIES:
  MeasuredSizes  get=0x020C61B0  set=0x03D51730
  RoundedSizes  get=0x03D67720  set=0x03D55BA0
  textInfoMesh  get=0x09F5516C
  textInfoLayout  get=0x09F550A0
METHODS:
  RVA=0x09F54480  token=0x6001321  UnityEngine.UIElements.ITextHandle New()
  RVA=0x03D4E3A0  token=0x6001324  System.Boolean IsLegacy()
  RVA=0x09F543F8  token=0x6001325  System.Boolean IsDirty(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms)
  RVA=0x09F540B4  token=0x6001326  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling)
  RVA=0x09F53FF8  token=0x6001327  System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=0x09F53F3C  token=0x6001328  System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=0x09F54140  token=0x6001329  System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint)
  RVA=0x09F54CEC  token=0x600132A  UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint)
  RVA=0x09F54B98  token=0x600132B  System.Void UpdatePreferredValues(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms)
  RVA=0x09F5423C  token=0x600132C  UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams)
  RVA=0x09F54544  token=0x600132D  System.Void UpdateGenerationSettingsCommon(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings)
  RVA=0x09F5442C  token=0x600132E  System.Boolean IsElided()
  RVA=0x09F55024  token=0x600132F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextNativeHandle
TYPE:  sealed struct
TOKEN: 0x200029B
SIZE:  0x38
IMPLEMENTS: UnityEngine.UIElements.ITextHandle
FIELDS:
  private           UnityEngine.Vector2             <MeasuredSizes>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <RoundedSizes>k__BackingField  // 0x18
  private           Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex>textVertices  // 0x20
  private           System.Int32                    m_PreviousTextParamsHash  // 0x30
PROPERTIES:
  MeasuredSizes  get=0x020C61B0  set=0x03D51730
  RoundedSizes  get=0x03D67720  set=0x03D55BA0
METHODS:
  RVA=0x09F55700  token=0x6001334  UnityEngine.UIElements.ITextHandle New()
  RVA=0x03D663A0  token=0x6001335  System.Boolean IsLegacy()
  RVA=0x09F553EC  token=0x6001336  System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint)
  RVA=0x09F5575C  token=0x6001337  UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint)
  RVA=0x09F5547C  token=0x6001338  Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=0x09F55370  token=0x6001339  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling)
  RVA=0x09F55290  token=0x600133A  System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=0x09F551DC  token=0x600133B  System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  RVA=0x03D4E3A0  token=0x600133C  System.Boolean IsElided()
END_CLASS

CLASS: UnityEngine.UIElements.TextUtilities
TYPE:  static class
TOKEN: 0x200029C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09F557AC  token=0x600133D  System.Single ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, System.Single pixelsPerPoint)
  RVA=0x09F56364  token=0x600133E  UnityEngine.Vector2 MeasureVisualElementTextSize(UnityEngine.UIElements.VisualElement ve, System.String textToMeasure, System.Single width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode, UnityEngine.UIElements.ITextHandle textHandle)
  RVA=0x09F5583C  token=0x600133F  UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam)
  RVA=0x09F559B0  token=0x6001340  UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F55AE8  token=0x6001341  UnityEngine.Font GetFont(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam)
  RVA=0x09F55C40  token=0x6001342  UnityEngine.Font GetFont(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F562B8  token=0x6001343  System.Boolean IsFontAssigned(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F561EC  token=0x6001344  System.Boolean IsFontAssigned(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams)
  RVA=0x09F56080  token=0x6001345  UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09F56108  token=0x6001346  UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam)
  RVA=0x09F55D88  token=0x6001347  UnityEngine.UIElements.UIR.TextCoreSettings GetTextCoreSettingsForElement(UnityEngine.UIElements.VisualElement ve)
END_CLASS

CLASS: UnityEngine.UIElements.IUxmlAttributes
TYPE:  interface
TOKEN: 0x200029D
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6001348  System.Boolean TryGetAttributeValue(System.String attributeName, System.String& value)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlRootElementFactory
TYPE:  class
TOKEN: 0x200029E
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
PROPERTIES:
  uxmlName  get=0x09F5A7D0
  uxmlQualifiedName  get=0x09F5A7FC
METHODS:
  RVA=0x03D85B20  token=0x600134B  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F5A794  token=0x600134C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlRootElementTraits
TYPE:  class
TOKEN: 0x200029F
SIZE:  0x28
EXTENDS: UnityEngine.UIElements.UxmlTraits
FIELDS:
  protected         UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Class  // 0x20
METHODS:
  RVA=0x09F5A870  token=0x600134D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlStyleFactory
TYPE:  class
TOKEN: 0x20002A0
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
PROPERTIES:
  uxmlName  get=0x09F5ACD8
  uxmlQualifiedName  get=0x09F5AD04
METHODS:
  RVA=0x03D85B20  token=0x6001350  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F5AC9C  token=0x6001351  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlStyleTraits
TYPE:  class
TOKEN: 0x20002A1
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Path  // 0x20
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Src  // 0x28
METHODS:
  RVA=0x09F5AD78  token=0x6001352  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTemplateFactory
TYPE:  class
TOKEN: 0x20002A2
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
PROPERTIES:
  uxmlName  get=0x09F5AED8
  uxmlQualifiedName  get=0x09F5AF04
METHODS:
  RVA=0x03D85B20  token=0x6001355  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F5AE9C  token=0x6001356  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTemplateTraits
TYPE:  class
TOKEN: 0x20002A3
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Path  // 0x20
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Src  // 0x28
METHODS:
  RVA=0x09F5AF78  token=0x6001357  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAttributeOverridesFactory
TYPE:  class
TOKEN: 0x20002A4
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
PROPERTIES:
  uxmlName  get=0x09F590D8
  uxmlQualifiedName  get=0x09F59104
METHODS:
  RVA=0x03D85B20  token=0x600135A  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F5909C  token=0x600135B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAttributeOverridesTraits
TYPE:  class
TOKEN: 0x20002A5
SIZE:  0x20
EXTENDS: UnityEngine.UIElements.UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ElementName  // 0x18
METHODS:
  RVA=0x09F59178  token=0x600135C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TemplateAsset
TYPE:  class
TOKEN: 0x20002A6
SIZE:  0x88
EXTENDS: UnityEngine.UIElements.VisualElementAsset
FIELDS:
  private           System.String                   m_TemplateAlias  // 0x70
  private           System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride>m_AttributeOverrides  // 0x78
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry>m_SlotUsages  // 0x80
PROPERTIES:
  attributeOverrides  get=0x09F53EB4
  slotUsages  get=0x03D87E00
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAttributeDescription
TYPE:  abstract class
TOKEN: 0x20002A8
SIZE:  0x40
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           System.String[]                 m_ObsoleteNames  // 0x18
  private           System.String                   <type>k__BackingField  // 0x20
  private           System.String                   <typeNamespace>k__BackingField  // 0x28
  private           UnityEngine.UIElements.UxmlAttributeDescription.Use<use>k__BackingField  // 0x30
  private           UnityEngine.UIElements.UxmlTypeRestriction<restriction>k__BackingField  // 0x38
PROPERTIES:
  name  get=0x020B7B20  set=0x0426FEE0
  obsoleteNames  set=0x09F59048
  type  set=0x04271930
  typeNamespace  set=0x02C92F10
  use  set=0x03D4EE10
  restriction  set=0x0388FF30
METHODS:
  RVA=0x07D83124  token=0x600135F  System.Void .ctor()
  RVA=0x09F58CC4  token=0x6001367  System.Boolean TryGetValueFromBagAsString(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.String& value)
  RVA=-1  // generic def  token=0x6001368  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue, T& value)
  RVA=-1  // generic def  token=0x6001369  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
TYPE:  abstract class
TOKEN: 0x20002AA
EXTENDS: UnityEngine.UIElements.UxmlAttributeDescription
FIELDS:
  private           T                               <defaultValue>k__BackingField  // 0x0
PROPERTIES:
  defaultValue  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // abstract  token=0x600136A  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x600136D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlStringAttributeDescription
TYPE:  class
TOKEN: 0x20002AB
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  RVA=0x09F5ABF4  token=0x600136E  System.Void .ctor()
  RVA=0x09F5A944  token=0x600136F  System.String GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F5AA98  token=0x6001370  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.String& value)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlFloatAttributeDescription
TYPE:  class
TOKEN: 0x20002AD
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  RVA=0x09F59808  token=0x6001375  System.Void .ctor()
  RVA=0x09F596B0  token=0x6001376  System.Single GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F59630  token=0x6001377  System.Single ConvertValueToFloat(System.String v, System.Single defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlIntAttributeDescription
TYPE:  class
TOKEN: 0x20002AF
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  RVA=0x09F59B64  token=0x600137B  System.Void .ctor()
  RVA=0x09F598B8  token=0x600137C  System.Int32 GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F59A0C  token=0x600137D  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Int32& value)
  RVA=0x09F59888  token=0x600137E  System.Int32 ConvertValueToInt(System.String v, System.Int32 defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlLongAttributeDescription
TYPE:  class
TOKEN: 0x20002B1
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  RVA=0x09F59D78  token=0x6001383  System.Void .ctor()
  RVA=0x09F59C24  token=0x6001384  System.Int64 GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F59BF0  token=0x6001385  System.Int64 ConvertValueToLong(System.String v, System.Int64 defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlBoolAttributeDescription
TYPE:  class
TOKEN: 0x20002B3
SIZE:  0x48
EXTENDS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  RVA=0x09F593C4  token=0x6001389  System.Void .ctor()
  RVA=0x09F59270  token=0x600138A  System.Boolean GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F59208  token=0x600138B  System.Boolean ConvertValueToBool(System.String v, System.Boolean defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlEnumAttributeDescription`1
TYPE:  class
TOKEN: 0x20002B5
EXTENDS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x600138F  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6001390  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6001391  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, T& value)
  RVA=-1  // generic def  token=0x6001392  U ConvertValueToEnum(System.String v, U defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectAttributeDescription`1
TYPE:  class
TOKEN: 0x20002B7
FIELDS:
  private           T                               <defaultValue>k__BackingField  // 0x0
PROPERTIES:
  defaultValue  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6001398  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x6001399  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectListAttributeDescription`1
TYPE:  class
TOKEN: 0x20002B8
EXTENDS: UnityEngine.UIElements.UxmlObjectAttributeDescription`1
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x600139A  System.Collections.Generic.List<T> GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x600139B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTraits
TYPE:  abstract class
TOKEN: 0x20002B9
SIZE:  0x18
FIELDS:
  private           System.Boolean                  <canHaveAnyAttribute>k__BackingField  // 0x10
PROPERTIES:
  canHaveAnyAttribute  set=0x03D4E960
METHODS:
  RVA=0x01168960  token=0x600139C  System.Void .ctor()
  RVA=0x0350B670  token=0x600139E  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.IUxmlFactory
TYPE:  interface
TOKEN: 0x20002BA
FIELDS:
PROPERTIES:
  uxmlQualifiedName  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60013A0  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // abstract  token=0x60013A1  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlFactory`2
TYPE:  class
TOKEN: 0x20002BB
IMPLEMENTS: UnityEngine.UIElements.IUxmlFactory
FIELDS:
  private           TTraits                         m_Traits  // 0x0
PROPERTIES:
  uxmlName  get=-1  // not resolved
  uxmlNamespace  get=-1  // not resolved
  uxmlQualifiedName  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60013A2  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60013A6  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x60013A7  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlFactory`1
TYPE:  class
TOKEN: 0x20002BC
EXTENDS: UnityEngine.UIElements.UxmlFactory`2
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60013A8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseUxmlTraits
TYPE:  abstract class
TOKEN: 0x20002BD
SIZE:  0x18
FIELDS:
  private           System.Boolean                  <canHaveAnyAttribute>k__BackingField  // 0x10
PROPERTIES:
  canHaveAnyAttribute  set=0x03D4E960
METHODS:
  RVA=0x01168960  token=0x60013A9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectTraits`1
TYPE:  abstract class
TOKEN: 0x20002BE
EXTENDS: UnityEngine.UIElements.BaseUxmlTraits
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60013AB  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x60013AC  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IBaseUxmlFactory
TYPE:  interface
TOKEN: 0x20002BF
FIELDS:
PROPERTIES:
  uxmlQualifiedName  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60013AE  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.IBaseUxmlObjectFactory
TYPE:  interface
TOKEN: 0x20002C0
IMPLEMENTS: UnityEngine.UIElements.IBaseUxmlFactory
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IUxmlObjectFactory`1
TYPE:  interface
TOKEN: 0x20002C1
IMPLEMENTS: UnityEngine.UIElements.IBaseUxmlObjectFactory UnityEngine.UIElements.IBaseUxmlFactory
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60013AF  T CreateObject(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectFactory`2
TYPE:  class
TOKEN: 0x20002C2
EXTENDS: UnityEngine.UIElements.BaseUxmlFactory`2
IMPLEMENTS: UnityEngine.UIElements.IUxmlObjectFactory`1 UnityEngine.UIElements.IBaseUxmlObjectFactory UnityEngine.UIElements.IBaseUxmlFactory
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60013B0  TCreatedType CreateObject(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  RVA=-1  // not resolved  token=0x60013B1  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseUxmlFactory`2
TYPE:  abstract class
TOKEN: 0x20002C3
FIELDS:
  private           TTraits                         m_Traits  // 0x0
PROPERTIES:
  uxmlQualifiedName  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60013B2  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60013B4  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAsset
TYPE:  class
TOKEN: 0x20002C4
SIZE:  0x30
IMPLEMENTS: UnityEngine.UIElements.IUxmlAttributes
FIELDS:
  private           System.String                   m_FullTypeName  // 0x10
  private           System.Int32                    m_Id  // 0x18
  private           System.Int32                    m_OrderInDocument  // 0x1c
  private           System.Int32                    m_ParentId  // 0x20
  protected         System.Collections.Generic.List<System.String>m_Properties  // 0x28
PROPERTIES:
  fullTypeName  get=0x020B7B20
  id  get=0x020D1AC0
  orderInDocument  get=0x03D4EBB0
  parentId  get=0x01003B50
METHODS:
  RVA=0x09F58BE4  token=0x60013B9  System.Boolean TryGetAttributeValue(System.String propertyName, System.String& value)
  RVA=0x09F58A8C  token=0x60013BA  System.Void SetAttribute(System.String name, System.String value)
  RVA=0x09F58A94  token=0x60013BB  System.Void SetOrAddProperty(System.String propertyName, System.String propertyValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectAsset
TYPE:  sealed class
TOKEN: 0x20002C5
SIZE:  0x30
EXTENDS: UnityEngine.UIElements.UxmlAsset
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectFactoryRegistry
TYPE:  class
TOKEN: 0x20002C6
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>>s_Factories  // static @ 0x0
PROPERTIES:
  factories  get=0x09F5A6D4
METHODS:
  RVA=0x09F59FE4  token=0x60013BD  System.Void RegisterFactory(UnityEngine.UIElements.IBaseUxmlObjectFactory factory)
  RVA=0x09F5A674  token=0x60013BE  System.Boolean TryGetFactories(System.String fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>& factoryList)
  RVA=0x09F59E04  token=0x60013BF  System.Void RegisterEngineFactories()
  RVA=0x09F5A408  token=0x60013C0  System.Void RegisterUserFactories()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTypeRestriction
TYPE:  abstract class
TOKEN: 0x20002C7
SIZE:  0x10
IMPLEMENTS: System.IEquatable`1
FIELDS:
METHODS:
  RVA=0x0232CE30  token=0x60013C1  System.Boolean Equals(UnityEngine.UIElements.UxmlTypeRestriction other)
  RVA=0x0350B670  token=0x60013C2  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlEnumeration
TYPE:  class
TOKEN: 0x20002C8
SIZE:  0x18
EXTENDS: UnityEngine.UIElements.UxmlTypeRestriction
FIELDS:
  private           System.Collections.Generic.List<System.String>m_Values  // 0x10
PROPERTIES:
  values  get=0x03D66B80  set=0x09F595DC
METHODS:
  RVA=0x09F59450  token=0x60013C5  System.Boolean Equals(UnityEngine.UIElements.UxmlTypeRestriction other)
  RVA=0x09F59564  token=0x60013C6  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementAsset
TYPE:  class
TOKEN: 0x20002C9
SIZE:  0x70
EXTENDS: UnityEngine.UIElements.UxmlAsset
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           System.String                   m_Name  // 0x30
  private           System.Int32                    m_RuleIndex  // 0x38
  private           System.String                   m_Text  // 0x40
  private           UnityEngine.UIElements.PickingModem_PickingMode  // 0x48
  private           System.String[]                 m_Classes  // 0x50
  private           System.Collections.Generic.List<System.String>m_StylesheetPaths  // 0x58
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>m_Stylesheets  // 0x60
  private           System.Boolean                  m_SkipClone  // 0x68
PROPERTIES:
  ruleIndex  get=0x03D86D20
  classes  get=0x03D87E30
  stylesheetPaths  get=0x09F5C00C
  hasStylesheetPaths  get=0x05C72CF8
  stylesheets  get=0x09F5C090
  hasStylesheets  get=0x05B08B40
  skipClone  get=0x03D4F3F0
METHODS:
  RVA=0x0350B670  token=0x60013CE  System.Void OnBeforeSerialize()
  RVA=0x09F5BE8C  token=0x60013CF  System.Void OnAfterDeserialize()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFactoryRegistry
TYPE:  class
TOKEN: 0x20002CA
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>>s_Factories  // static @ 0x0
PROPERTIES:
  factories  get=0x09F5D284
METHODS:
  RVA=0x09F5CB88  token=0x60013D1  System.Void RegisterFactory(UnityEngine.UIElements.IUxmlFactory factory)
  RVA=0x09F5D218  token=0x60013D2  System.Boolean TryGetValue(System.String fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>& factoryList)
  RVA=0x09F5C114  token=0x60013D3  System.Void RegisterEngineFactories()
  RVA=0x09F5CFAC  token=0x60013D4  System.Void RegisterUserFactories()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeAsset
TYPE:  class
TOKEN: 0x20002CB
SIZE:  0x68
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private   static  System.String                   LinkedVEAInTemplatePropertyName  // static @ 0x0
  private           System.Boolean                  m_ImportedWithErrors  // 0x18
  private           System.Boolean                  m_ImportedWithWarnings  // 0x19
  private   static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement>s_TemporarySlotInsertionPoints  // static @ 0x8
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UsingEntry>m_Usings  // 0x20
  private           UnityEngine.UIElements.StyleSheetinlineSheet  // 0x28
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>m_VisualElementAssets  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset>m_TemplateAssets  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry>m_UxmlObjectEntries  // 0x40
  private           System.Collections.Generic.List<System.Int32>m_UxmlObjectIds  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.AssetEntry>m_AssetEntries  // 0x50
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition>m_Slots  // 0x58
  private           System.Int32                    m_ContentContainerId  // 0x60
  private           System.Int32                    m_ContentHash  // 0x64
PROPERTIES:
  importedWithErrors  get=0x03D899E0  set=0x01002B40
  importedWithWarnings  get=0x03D899F0  set=0x03D4EFB0
  templateDependencies  get=0x09F5FEBC
  stylesheets  get=0x09F5FE4C
  visualElementAssets  get=0x03D86D10  set=0x04270470
  templateAssets  get=0x03D86EB0  set=0x0388FF30
  uxmlObjectEntries  get=0x03D4E2B0
  uxmlObjectIds  get=0x03D4EA70
  slots  get=0x03D87D70  set=0x03081D30
  contentContainerId  get=0x03D88AC0  set=0x03D4F5A0
  contentHash  get=0x03D89AE0  set=0x03D50B40
METHODS:
  RVA=0x09F5F03C  token=0x60013D9  System.Int32 GetNextChildSerialNumber()
  RVA=0x09F5F73C  token=0x60013E2  System.Void RegisterUxmlObject(UnityEngine.UIElements.UxmlObjectAsset uxmlObjectAsset)
  RVA=-1  // generic def  token=0x60013E3  System.Collections.Generic.List<T> GetUxmlObjects(UnityEngine.UIElements.IUxmlAttributes asset, UnityEngine.UIElements.CreationContext cc)
  RVA=0x09F5D344  token=0x60013E4  System.Boolean AssetEntryExists(System.String path, System.Type type)
  RVA=0x09F5F62C  token=0x60013E5  System.Void RegisterAssetEntry(System.String path, System.Type type, UnityEngine.Object asset)
  RVA=-1  // generic def  token=0x60013E6  T GetAsset(System.String path)
  RVA=0x09F5F0BC  token=0x60013E7  UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry GetUxmlObjectEntry(System.Int32 id)
  RVA=0x09F5F1F0  token=0x60013E8  UnityEngine.UIElements.IBaseUxmlObjectFactory GetUxmlObjectFactory(UnityEngine.UIElements.UxmlObjectAsset uxmlObjectAsset)
  RVA=0x09F5F510  token=0x60013ED  UnityEngine.UIElements.TemplateContainer Instantiate()
  RVA=0x09F5F4D4  token=0x60013EE  UnityEngine.UIElements.TemplateContainer Instantiate(System.String bindingPath)
  RVA=0x09F5E8C8  token=0x60013EF  UnityEngine.UIElements.TemplateContainer CloneTree()
  RVA=0x09F5E70C  token=0x60013F0  UnityEngine.UIElements.TemplateContainer CloneTree(System.String bindingPath)
  RVA=0x09F5DFE0  token=0x60013F1  System.Void CloneTree(UnityEngine.UIElements.VisualElement target)
  RVA=0x09F5E718  token=0x60013F2  System.Void CloneTree(UnityEngine.UIElements.VisualElement target, System.Int32& firstElementIndex, System.Int32& elementAddedCount)
  RVA=0x09F5E008  token=0x60013F3  System.Void CloneTree(UnityEngine.UIElements.VisualElement target, System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides)
  RVA=0x09F5D6D4  token=0x60013F4  UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset root, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, UnityEngine.UIElements.CreationContext context)
  RVA=0x09F5E8D4  token=0x60013F5  System.Int32 CompareForOrder(UnityEngine.UIElements.VisualElementAsset a, UnityEngine.UIElements.VisualElementAsset b)
  RVA=0x09F5FBA8  token=0x60013F6  System.Boolean TryGetSlotInsertionPoint(System.Int32 insertionPointId, System.String& slotName)
  RVA=0x09F5F938  token=0x60013F7  UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String templateName)
  RVA=0x09F5E904  token=0x60013F8  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.CreationContext ctx)
  RVA=0x09F5D4C8  token=0x60013F9  System.Void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element)
  RVA=0x09F5D534  token=0x60013FA  System.Void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element)
  RVA=0x0286F540  token=0x60013FD  System.Void .ctor()
  RVA=0x09F5FD84  token=0x60013FE  System.Void .cctor()
  RVA=0x09F5FC68  token=0x60013FF  UnityEngine.UIElements.VisualElement <Create>g__CreateError|65_0(UnityEngine.UIElements.VisualTreeAsset.<>c__DisplayClass65_0& )
END_CLASS

CLASS: UnityEngine.UIElements.CreationContext
TYPE:  sealed struct
TOKEN: 0x20002D6
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public    static readonly UnityEngine.UIElements.CreationContextDefault  // static @ 0x0
  private           UnityEngine.UIElements.VisualElement<target>k__BackingField  // 0x10
  private           UnityEngine.UIElements.VisualTreeAsset<visualTreeAsset>k__BackingField  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement><slotInsertionPoints>k__BackingField  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride><attributeOverrides>k__BackingField  // 0x28
PROPERTIES:
  target  get=0x020C61B0  set=0x042715A0
  visualTreeAsset  get=0x03D50DE0  set=0x0558FF08
  slotInsertionPoints  get=0x020B7B20  set=0x0426FEE0
  attributeOverrides  get=0x01041090  set=0x022C3A90
METHODS:
  RVA=0x09F45A7C  token=0x6001425  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target)
  RVA=0x09F459E8  token=0x6001426  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target)
  RVA=0x09F457E8  token=0x6001427  System.Boolean Equals(System.Object obj)
  RVA=0x09F45674  token=0x6001428  System.Boolean Equals(UnityEngine.UIElements.CreationContext other)
  RVA=0x09F45874  token=0x6001429  System.Int32 GetHashCode()
  RVA=0x09F459A8  token=0x600142A  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.Easing
TYPE:  static class
TOKEN: 0x200035E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D4B9D0  token=0x60017BD  System.Single Linear(System.Single t)
  RVA=0x03D88D60  token=0x60017BE  System.Single InSine(System.Single t)
  RVA=0x03D88DE0  token=0x60017BF  System.Single OutSine(System.Single t)
  RVA=0x03D88D10  token=0x60017C0  System.Single InOutSine(System.Single t)
  RVA=0x03D88D50  token=0x60017C1  System.Single InQuad(System.Single t)
  RVA=0x03D88DC0  token=0x60017C2  System.Single OutQuad(System.Single t)
  RVA=0x09ECA54C  token=0x60017C3  System.Single InOutQuad(System.Single t)
  RVA=0x03D88D00  token=0x60017C4  System.Single InCubic(System.Single t)
  RVA=0x09ECA5C4  token=0x60017C5  System.Single OutCubic(System.Single t)
  RVA=0x09ECA47C  token=0x60017C6  System.Single InOutCubic(System.Single t)
  RVA=0x03D88D40  token=0x60017C7  System.Single InPower(System.Single t, System.Int32 power)
  RVA=0x09ECA67C  token=0x60017C8  System.Single OutPower(System.Single t, System.Int32 power)
  RVA=0x09ECA4D4  token=0x60017C9  System.Single InOutPower(System.Single t, System.Int32 power)
  RVA=0x09ECA278  token=0x60017CA  System.Single InBounce(System.Single t)
  RVA=0x093BA8B0  token=0x60017CB  System.Single OutBounce(System.Single t)
  RVA=0x09ECA3A4  token=0x60017CC  System.Single InOutBounce(System.Single t)
  RVA=0x09ECA2AC  token=0x60017CD  System.Single InElastic(System.Single t)
  RVA=0x09ECA5EC  token=0x60017CE  System.Single OutElastic(System.Single t)
  RVA=0x09ECA48C  token=0x60017CF  System.Single InOutElastic(System.Single t)
  RVA=0x03D71FD0  token=0x60017D0  System.Single InBack(System.Single t)
  RVA=0x09ECA590  token=0x60017D1  System.Single OutBack(System.Single t)
  RVA=0x09ECA334  token=0x60017D2  System.Single InOutBack(System.Single t)
  RVA=0x03D88CA0  token=0x60017D3  System.Single InCirc(System.Single t)
  RVA=0x03D88D90  token=0x60017D4  System.Single OutCirc(System.Single t)
  RVA=0x09ECA414  token=0x60017D5  System.Single InOutCirc(System.Single t)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.StyleValues
TYPE:  sealed struct
TOKEN: 0x200035F
SIZE:  0x18
FIELDS:
  private           UnityEngine.UIElements.StyleValueCollectionm_StyleValues  // 0x10
PROPERTIES:
  top  set=0x09ECBDE4
  left  set=0x09ECBD34
  width  set=0x09ECBE18
  height  set=0x09ECBD24
  right  set=0x09ECBDD4
  bottom  set=0x09ECBCE0
  color  set=0x09ECBCF0
  backgroundColor  set=0x09ECBC18
  unityBackgroundImageTintColor  set=0x09ECBDF4
  borderColor  set=0x09ECBC6C
  marginLeft  set=0x09ECBD54
  marginTop  set=0x09ECBD74
  marginRight  set=0x09ECBD64
  marginBottom  set=0x09ECBD44
  paddingLeft  set=0x09ECBDA4
  paddingTop  get=0x09ECBBDC  set=0x09ECBDC4
  paddingRight  set=0x09ECBDB4
  paddingBottom  set=0x09ECBD94
  borderLeftWidth  set=0x09ECBC90
  borderRightWidth  set=0x09ECBCA0
  borderTopWidth  set=0x09ECBCD0
  borderBottomWidth  set=0x09ECBC5C
  borderTopLeftRadius  set=0x09ECBCB0
  borderTopRightRadius  set=0x09ECBCC0
  borderBottomLeftRadius  set=0x09ECBC3C
  borderBottomRightRadius  set=0x09ECBC4C
  opacity  set=0x09ECBD84
  flexGrow  set=0x09ECBD14
  flexShrink  set=0x09ECBD14
METHODS:
  RVA=0x09ECBAB4  token=0x60017F4  System.Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single value)
  RVA=0x09ECBB10  token=0x60017F5  System.Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color value)
  RVA=0x09ECBB70  token=0x60017F6  UnityEngine.UIElements.StyleValueCollection Values()
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.ITransitionAnimations
TYPE:  interface
TOKEN: 0x2000360
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60017F7  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.Lerp
TYPE:  static class
TOKEN: 0x2000361
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D86320  token=0x60017F8  System.Single Interpolate(System.Single start, System.Single end, System.Single ratio)
  RVA=0x09ECA6C0  token=0x60017F9  UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, System.Single ratio)
  RVA=0x09ECA704  token=0x60017FA  UnityEngine.UIElements.Experimental.StyleValues Interpolate(UnityEngine.UIElements.Experimental.StyleValues start, UnityEngine.UIElements.Experimental.StyleValues end, System.Single ratio)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.IValueAnimationUpdate
TYPE:  interface
TOKEN: 0x2000362
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60017FB  System.Void Tick(System.Int64 currentTimeMs)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.ValueAnimation`1
TYPE:  sealed class
TOKEN: 0x2000363
IMPLEMENTS: UnityEngine.UIElements.Experimental.IValueAnimationUpdate
FIELDS:
  private           System.Int64                    m_StartTimeMs  // 0x0
  private           System.Int32                    m_DurationMs  // 0x0
  private           System.Func<System.Single,System.Single><easingCurve>k__BackingField  // 0x0
  private           System.Boolean                  <isRunning>k__BackingField  // 0x0
  private           System.Action                   <onAnimationCompleted>k__BackingField  // 0x0
  private           System.Boolean                  <autoRecycle>k__BackingField  // 0x0
  private           System.Boolean                  <recycled>k__BackingField  // 0x0
  private   static  UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.Experimental.ValueAnimation<T>>sObjectPool  // static @ 0x0
  private           UnityEngine.UIElements.VisualElement<owner>k__BackingField  // 0x0
  private           System.Action<UnityEngine.UIElements.VisualElement,T><valueUpdated>k__BackingField  // 0x0
  private           System.Func<UnityEngine.UIElements.VisualElement,T><initialValue>k__BackingField  // 0x0
  private           System.Func<T,T,System.Single,T><interpolator>k__BackingField  // 0x0
  private           T                               _from  // 0x0
  private           System.Boolean                  fromValueSet  // 0x0
  private           T                               <to>k__BackingField  // 0x0
PROPERTIES:
  durationMs  get=-1  // not resolved  set=-1  // not resolved
  easingCurve  get=-1  // not resolved  set=-1  // not resolved
  isRunning  get=-1  // not resolved  set=-1  // not resolved
  onAnimationCompleted  get=-1  // not resolved  set=-1  // not resolved
  autoRecycle  get=-1  // not resolved  set=-1  // not resolved
  recycled  get=-1  // not resolved  set=-1  // not resolved
  owner  get=-1  // not resolved  set=-1  // not resolved
  valueUpdated  get=-1  // not resolved  set=-1  // not resolved
  initialValue  get=-1  // not resolved  set=-1  // not resolved
  interpolator  get=-1  // not resolved  set=-1  // not resolved
  from  get=-1  // not resolved  set=-1  // not resolved
  to  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6001814  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6001815  System.Void Start()
  RVA=-1  // not resolved  token=0x6001816  System.Void Stop()
  RVA=-1  // not resolved  token=0x6001817  System.Void Recycle()
  RVA=-1  // not resolved  token=0x6001818  System.Void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(System.Int64 currentTimeMs)
  RVA=-1  // not resolved  token=0x6001819  System.Void SetDefaultValues()
  RVA=-1  // not resolved  token=0x600181A  System.Void Unregister()
  RVA=-1  // not resolved  token=0x600181B  System.Void Register()
  RVA=-1  // not resolved  token=0x600181C  System.Void SetOwner(UnityEngine.UIElements.VisualElement e)
  RVA=-1  // not resolved  token=0x600181D  System.Void CheckNotRecycled()
  RVA=-1  // not resolved  token=0x600181E  UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement e, System.Func<T,T,System.Single,T> interpolator)
  RVA=-1  // not resolved  token=0x600181F  UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive()
  RVA=-1  // not resolved  token=0x6001820  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMovePreview
TYPE:  class
TOKEN: 0x2000327
SIZE:  0x3C0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
METHODS:
  RVA=0x09EAFD60  token=0x6001613  System.Void .ctor()
  RVA=0x09EAFCD4  token=0x6001614  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreview
TYPE:  class
TOKEN: 0x2000328
SIZE:  0x3C0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   visualUssClassName  // static @ 0x8
METHODS:
  RVA=0x09EAFBF4  token=0x6001615  System.Void .ctor()
  RVA=0x09EAFB10  token=0x6001616  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.ColumnMover
TYPE:  class
TOKEN: 0x2000329
SIZE:  0x98
EXTENDS: UnityEngine.UIElements.PointerManipulator
FIELDS:
  private           System.Single                   m_StartPos  // 0x38
  private           System.Single                   m_LastPos  // 0x3c
  private           System.Boolean                  m_Active  // 0x40
  private           System.Boolean                  m_Moving  // 0x41
  private           System.Boolean                  m_Cancelled  // 0x42
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeaderm_Header  // 0x48
  private           UnityEngine.UIElements.VisualElementm_PreviewElement  // 0x50
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreviewm_LocationPreviewElement  // 0x58
  private           UnityEngine.UIElements.Column   m_ColumnToMove  // 0x60
  private           System.Single                   m_ColumnToMovePos  // 0x68
  private           System.Single                   m_ColumnToMoveWidth  // 0x6c
  private           UnityEngine.UIElements.Column   m_DestinationColumn  // 0x70
  private           System.Boolean                  m_MoveBeforeDestination  // 0x78
  private           UnityEngine.UIElements.ColumnLayout<columnLayout>k__BackingField  // 0x80
  private           System.Action<UnityEngine.UIElements.Internal.ColumnMover>activeChanged  // 0x88
  private           System.Action<UnityEngine.UIElements.Internal.ColumnMover>movingChanged  // 0x90
PROPERTIES:
  columnLayout  get=0x03D4EAE0  set=0x051DFC94
  active  get=0x03D4EE90  set=0x09EAA3AC
  moving  get=0x03D4F7B0  set=0x09EAA3D8
EVENTS:
  activeChanged  add=add_activeChanged  remove=remove_activeChanged
  movingChanged  add=add_movingChanged  remove=remove_movingChanged
METHODS:
  RVA=0x09EAA0F8  token=0x6001621  System.Void .ctor()
  RVA=0x09EA941C  token=0x6001622  System.Void RegisterCallbacksOnTarget()
  RVA=0x09EA98CC  token=0x6001623  System.Void UnregisterCallbacksFromTarget()
  RVA=0x09EA8A4C  token=0x6001624  System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt)
  RVA=0x09EA8B08  token=0x6001625  System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt)
  RVA=0x09EA8B78  token=0x6001626  System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt)
  RVA=0x09EA89E0  token=0x6001627  System.Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt)
  RVA=0x09EA8D2C  token=0x6001628  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  RVA=0x09EA8E34  token=0x6001629  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  RVA=0x09EA8F20  token=0x600162A  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  RVA=0x09EA8C3C  token=0x600162B  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  RVA=0x09EA8CBC  token=0x600162C  System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  RVA=0x09EA8934  token=0x600162D  System.Boolean IsNotMouseEvent(System.Int32 pointerId)
  RVA=0x09EA9028  token=0x600162E  System.Void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, System.Int32 pointerId)
  RVA=0x09EA8980  token=0x600162F  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent e)
  RVA=0x09EA90D8  token=0x6001630  System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  RVA=0x09EA9270  token=0x6001631  System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Vector2 localPosition)
  RVA=0x09EA934C  token=0x6001632  System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  RVA=0x09EA8400  token=0x6001633  System.Void BeginDragMove(System.Single pos)
  RVA=0x09EA87F8  token=0x6001634  System.Void DragMove(System.Single pos)
  RVA=0x09EA9F8C  token=0x6001635  System.Void UpdatePreviewPosition()
  RVA=0x09EA9D7C  token=0x6001636  System.Void UpdateMoveLocation()
  RVA=0x09EA8804  token=0x6001637  System.Void EndDragMove(System.Boolean cancelled)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizePreview
TYPE:  class
TOKEN: 0x200032A
SIZE:  0x3C0
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   visualUssClassName  // static @ 0x8
METHODS:
  RVA=0x09EB0098  token=0x6001638  System.Void .ctor()
  RVA=0x09EAFFB4  token=0x6001639  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.ColumnResizer
TYPE:  class
TOKEN: 0x200032B
SIZE:  0x70
EXTENDS: UnityEngine.UIElements.PointerManipulator
FIELDS:
  private           UnityEngine.Vector2             m_Start  // 0x38
  protected         System.Boolean                  m_Active  // 0x40
  private           System.Boolean                  m_Resizing  // 0x41
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeaderm_Header  // 0x48
  private           UnityEngine.UIElements.Column   m_Column  // 0x50
  private           UnityEngine.UIElements.VisualElementm_PreviewElement  // 0x58
  private           UnityEngine.UIElements.ColumnLayout<columnLayout>k__BackingField  // 0x60
  private           System.Boolean                  <preview>k__BackingField  // 0x68
PROPERTIES:
  columnLayout  get=0x03D4EB00  set=0x039274B0
  preview  get=0x03D4F3F0  set=0x03D4F440
METHODS:
  RVA=0x09EAAE50  token=0x600163E  System.Void .ctor(UnityEngine.UIElements.Column column)
  RVA=0x09EAA9B8  token=0x600163F  System.Void RegisterCallbacksOnTarget()
  RVA=0x09EAABB4  token=0x6001640  System.Void UnregisterCallbacksFromTarget()
  RVA=0x09EAA4EC  token=0x6001641  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent e)
  RVA=0x09EAA554  token=0x6001642  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e)
  RVA=0x09EAA7AC  token=0x6001643  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e)
  RVA=0x09EAA898  token=0x6001644  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e)
  RVA=0x09EAA404  token=0x6001645  System.Void BeginDragResize(System.Single pos)
  RVA=0x09EAA448  token=0x6001646  System.Void DragResize(System.Single pos)
  RVA=0x09EAADB0  token=0x6001647  System.Void UpdatePreviewPosition()
  RVA=0x09EAA488  token=0x6001648  System.Void EndDragResize(System.Single pos, System.Boolean cancelled)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnCollectionHeader
TYPE:  class
TOKEN: 0x200032C
SIZE:  0x440
EXTENDS: UnityEngine.UIElements.VisualElement
IMPLEMENTS: System.IDisposable
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   columnContainerUssClassName  // static @ 0x8
  public    static readonly System.String                   handleContainerUssClassName  // static @ 0x10
  public    static readonly System.String                   reorderableUssClassName  // static @ 0x18
  private           System.Boolean                  m_SortingEnabled  // 0x3c0
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortedColumns  // 0x3c8
  private           UnityEngine.UIElements.SortColumnDescriptionsm_SortDescriptions  // 0x3d0
  private           System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.SortedColumnState>m_OldSortedColumnStates  // 0x3d8
  private           System.Boolean                  m_SortingUpdatesTemporarilyDisabled  // 0x3e0
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewStatem_ViewState  // 0x3e8
  private           System.Boolean                  m_ApplyingViewState  // 0x3f0
  private           System.Boolean                  m_DoLayoutScheduled  // 0x3f1
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData><columnDataMap>k__BackingField  // 0x3f8
  private   readonly UnityEngine.UIElements.ColumnLayout<columnLayout>k__BackingField  // 0x400
  private   readonly UnityEngine.UIElements.VisualElement<columnContainer>k__BackingField  // 0x408
  private   readonly UnityEngine.UIElements.VisualElement<resizeHandleContainer>k__BackingField  // 0x410
  private   readonly UnityEngine.UIElements.Columns  <columns>k__BackingField  // 0x418
  private           System.Action<System.Int32,System.Single>columnResized  // 0x420
  private           System.Action                   columnSortingChanged  // 0x428
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>contextMenuPopulateEvent  // 0x430
  private           System.Action                   viewDataRestored  // 0x438
PROPERTIES:
  isApplyingViewState  get=0x03D88BD0
  columnDataMap  get=0x03D57080
  columnLayout  get=0x03D57290
  columnContainer  get=0x03D57280
  resizeHandleContainer  get=0x03D570D0
  sortedColumns  get=0x03D56FF0
  sortDescriptions  get=0x03D55EC0  set=0x09EAF78C
  columns  get=0x03D57150
  sortingEnabled  get=0x03D88BE0  set=0x09EAF840
EVENTS:
  columnResized  add=add_columnResized  remove=remove_columnResized
  columnSortingChanged  add=add_columnSortingChanged  remove=remove_columnSortingChanged
  contextMenuPopulateEvent  add=add_contextMenuPopulateEvent  remove=remove_contextMenuPopulateEvent
  viewDataRestored  add=add_viewDataRestored  remove=remove_viewDataRestored
METHODS:
  RVA=0x09EAE584  token=0x600165C  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  RVA=0x09EAD2C0  token=0x600165D  System.Void ScheduleDoLayout()
  RVA=0x09EAD244  token=0x600165E  System.Void ResizeToFit()
  RVA=0x09EADACC  token=0x600165F  System.Void UpdateSortedColumns()
  RVA=0x09EAD3CC  token=0x6001660  System.Void UpdateColumnControls()
  RVA=0x09EABBA0  token=0x6001661  System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index)
  RVA=0x09EABBA8  token=0x6001662  System.Void OnColumnAdded(UnityEngine.UIElements.Column column)
  RVA=0x09EAC2A8  token=0x6001663  System.Void OnColumnRemoved(UnityEngine.UIElements.Column column)
  RVA=0x09EABEEC  token=0x6001664  System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  RVA=0x09EAC50C  token=0x6001665  System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to)
  RVA=0x09EAC6A8  token=0x6001666  System.Void OnColumnResized(UnityEngine.UIElements.Column column)
  RVA=0x09EAC6B0  token=0x6001667  System.Void OnContextualMenuManipulator(UnityEngine.UIElements.ContextualMenuPopulateEvent evt)
  RVA=0x09EACFE4  token=0x6001668  System.Void OnMoveManipulatorActivated(UnityEngine.UIElements.Internal.ColumnMover mover)
  RVA=0x09EACF70  token=0x6001669  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  RVA=0x09EABB4C  token=0x600166A  System.Void DoLayout()
  RVA=0x09EAC0F0  token=0x600166B  System.Void OnColumnControlGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  RVA=0x09EABF50  token=0x600166C  System.Void OnColumnClicked(UnityEngine.UIElements.EventBase evt)
  RVA=0x09EAD8A8  token=0x600166D  System.Void UpdateSortColumnDescriptionsOnClick(UnityEngine.UIElements.Column column, UnityEngine.EventModifiers modifiers)
  RVA=0x09EAD34C  token=0x600166E  System.Void ScrollHorizontally(System.Single horizontalOffset)
  RVA=0x09EAD1B8  token=0x600166F  System.Void RaiseColumnResized(System.Int32 columnIndex)
  RVA=0x09EAD214  token=0x6001670  System.Void RaiseColumnSortingChanged()
  RVA=0x09EAAFAC  token=0x6001671  System.Void ApplyColumnSorting()
  RVA=0x09EAE094  token=0x6001672  System.Void UpdateSortingStatus()
  RVA=0x09EAD060  token=0x6001673  System.Void OnViewDataReady()
  RVA=0x09EAD284  token=0x6001674  System.Void SaveViewState()
  RVA=0x09EAB4F4  token=0x6001675  System.Void Dispose()
  RVA=0x09EAE428  token=0x6001676  System.Void .cctor()
  RVA=0x09EAD3C4  token=0x6001677  System.Void <OnContextualMenuManipulator>b__65_0(UnityEngine.UIElements.DropdownMenuAction a)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicator
TYPE:  class
TOKEN: 0x2000333
SIZE:  0x3C8
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   arrowUssClassName  // static @ 0x8
  public    static readonly System.String                   indexLabelUssClassName  // static @ 0x10
  private           UnityEngine.UIElements.Label    m_IndexLabel  // 0x3c0
PROPERTIES:
  sortOrderLabel  set=0x09EB0414
METHODS:
  RVA=0x09EB02B0  token=0x6001687  System.Void .ctor()
  RVA=0x09EB0178  token=0x6001688  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnIcon
TYPE:  class
TOKEN: 0x2000334
SIZE:  0x410
EXTENDS: UnityEngine.UIElements.Image
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  private           System.Boolean                  <isImageInline>k__BackingField  // 0x408
PROPERTIES:
  isImageInline  get=0x03D88BF0  set=0x03D88C00
METHODS:
  RVA=0x09EAFA28  token=0x600168B  System.Void .ctor()
  RVA=0x09EAF87C  token=0x600168C  System.Void UpdateClassList()
  RVA=0x09EAF99C  token=0x600168D  System.Void .cctor()
  RVA=0x09EAF874  token=0x600168E  System.Void <.ctor>b__5_0(UnityEngine.UIElements.CustomStyleResolvedEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumn
TYPE:  class
TOKEN: 0x2000335
SIZE:  0x3F8
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   sortableUssClassName  // static @ 0x8
  public    static readonly System.String                   sortedAscendingUssClassName  // static @ 0x10
  public    static readonly System.String                   sortedDescendingUssClassName  // static @ 0x18
  public    static readonly System.String                   movingUssClassName  // static @ 0x20
  public    static readonly System.String                   contentContainerUssClassName  // static @ 0x28
  public    static readonly System.String                   contentUssClassName  // static @ 0x30
  public    static readonly System.String                   defaultContentUssClassName  // static @ 0x38
  public    static readonly System.String                   hasIconUssClassName  // static @ 0x40
  public    static readonly System.String                   hasTitleUssClassName  // static @ 0x48
  public    static readonly System.String                   titleUssClassName  // static @ 0x50
  public    static readonly System.String                   iconElementName  // static @ 0x58
  public    static readonly System.String                   titleElementName  // static @ 0x60
  private   static readonly System.String                   s_BoundVEPropertyName  // static @ 0x68
  private   static readonly System.String                   s_BindingCallbackVEPropertyName  // static @ 0x70
  private   static readonly System.String                   s_UnbindingCallbackVEPropertyName  // static @ 0x78
  private   static readonly System.String                   s_DestroyCallbackVEPropertyName  // static @ 0x80
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x3c0
  private           UnityEngine.UIElements.VisualElementm_Content  // 0x3c8
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicatorm_SortIndicatorContainer  // 0x3d0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScheduledHeaderTemplateUpdate  // 0x3d8
  private           UnityEngine.UIElements.Clickable<clickable>k__BackingField  // 0x3e0
  private           UnityEngine.UIElements.Internal.ColumnMover<mover>k__BackingField  // 0x3e8
  private           UnityEngine.UIElements.Column   <column>k__BackingField  // 0x3f0
PROPERTIES:
  clickable  get=0x03D55EE0  set=0x058B4258
  mover  get=0x03D572E0  set=0x058B3F9C
  sortOrderLabel  set=0x09EB1E30
  column  get=0x03D57310  set=0x058B3FEC
  content  get=0x03D56FF0  set=0x09EB1BE8
  isContentBound  get=0x09EB1B44  set=0x09EB1D88
METHODS:
  RVA=0x09EB166C  token=0x600169A  System.Void .ctor(UnityEngine.UIElements.Column column)
  RVA=0x09EB0A18  token=0x600169B  System.Void InitManipulators()
  RVA=0x09EB0E28  token=0x600169C  System.Void UpdateDataFromColumn()
  RVA=0x09EB0438  token=0x600169D  System.Void BindHeaderContent()
  RVA=0x09EB0D50  token=0x600169E  System.Void UnbindHeaderContent()
  RVA=0x09EB0954  token=0x600169F  System.Void DestroyHeaderContent()
  RVA=0x09EB0510  token=0x60016A0  UnityEngine.UIElements.VisualElement CreateDefaultHeaderContent()
  RVA=0x09EB0694  token=0x60016A1  System.Void DefaultBindHeaderContent(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EB0EEC  token=0x60016A2  System.Void UpdateHeaderTemplate()
  RVA=0x09EB0E68  token=0x60016A3  System.Void UpdateGeometryFromColumn()
  RVA=0x09EB111C  token=0x60016A4  System.Void .cctor()
  RVA=0x09EB0C94  token=0x60016A5  System.Void <.ctor>b__45_0(UnityEngine.UIElements.Column c, UnityEngine.UIElements.ColumnDataType role)
  RVA=0x09EB0D48  token=0x60016A6  System.Void <.ctor>b__45_1(UnityEngine.UIElements.Column c)
  RVA=0x09EB0C00  token=0x60016A7  System.Void <InitManipulators>b__46_0(UnityEngine.UIElements.Internal.ColumnMover mv)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle
TYPE:  class
TOKEN: 0x2000336
SIZE:  0x3C8
EXTENDS: UnityEngine.UIElements.VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // static @ 0x0
  public    static readonly System.String                   dragAreaUssClassName  // static @ 0x8
  private   readonly UnityEngine.UIElements.VisualElement<dragArea>k__BackingField  // 0x3c0
PROPERTIES:
  dragArea  get=0x03D57010
METHODS:
  RVA=0x09EAFEC4  token=0x60016A9  System.Void .ctor()
  RVA=0x09EAFDE0  token=0x60016AA  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.HierarchyTraversal
TYPE:  abstract class
TOKEN: 0x2000337
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09EAAF94  token=0x60016AB  System.Void Traverse(UnityEngine.UIElements.VisualElement element)
  RVA=-1  // abstract  token=0x60016AC  System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  RVA=0x09EAAEE4  token=0x60016AD  System.Void Recurse(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  RVA=0x0350B670  token=0x60016AE  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyUtil
TYPE:  static class
TOKEN: 0x2000338
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheets.StylePropertyId>s_AnimatablePropertiesHash  // static @ 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyId>s_NameToId  // static @ 0x8
  private   static readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,System.String>s_IdToName  // static @ 0x10
  private   static readonly UnityEngine.UIElements.StyleSheets.StylePropertyId[]s_AnimatableProperties  // static @ 0x18
METHODS:
  RVA=0x09EB2D60  token=0x60016AF  System.Void .cctor()
  RVA=0x09EB1E54  token=0x60016B0  System.Boolean IsAnimatable(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  RVA=0x09EB1FA0  token=0x60016B1  System.Boolean TryGetEnumIntValue(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, System.String value, System.Int32& intValue)
  RVA=0x09EB1EC0  token=0x60016B2  System.Boolean IsMatchingShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyId shorthand, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.InitialStyle
TYPE:  static class
TOKEN: 0x2000339
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.UIElements.ComputedStyles_InitialStyle  // static @ 0x0
PROPERTIES:
  alignContent  get=0x09EBD6F8
  alignItems  get=0x09EBD758
  alignSelf  get=0x09EBD7B8
  backgroundColor  get=0x09EBD818
  backgroundImage  get=0x09EBD884
  borderBottomColor  get=0x09EBD8F8
  borderBottomLeftRadius  get=0x09EBD964
  borderBottomRightRadius  get=0x09EBD9C4
  borderBottomWidth  get=0x09EBDA24
  borderLeftColor  get=0x09EBDA84
  borderLeftWidth  get=0x09EBDAF0
  borderRightColor  get=0x09EBDB50
  borderRightWidth  get=0x09EBDBBC
  borderTopColor  get=0x09EBDC1C
  borderTopLeftRadius  get=0x09EBDC88
  borderTopRightRadius  get=0x09EBDCEC
  borderTopWidth  get=0x09EBDD50
  bottom  get=0x09EBDDB0
  color  get=0x09EBDE10
  cursor  get=0x09EBDE78
  display  get=0x09EBDEEC
  flexBasis  get=0x09EBDF4C
  flexDirection  get=0x09EBDFAC
  flexGrow  get=0x09EBE00C
  flexShrink  get=0x09EBE06C
  flexWrap  get=0x09EBE0CC
  fontSize  get=0x09EBE12C
  height  get=0x09EBE188
  justifyContent  get=0x09EBE1E8
  left  get=0x09EBE248
  letterSpacing  get=0x09EBE2A8
  marginBottom  get=0x09EBE304
  marginLeft  get=0x09EBE364
  marginRight  get=0x09EBE3C4
  marginTop  get=0x09EBE424
  maxHeight  get=0x09EBE484
  maxWidth  get=0x09EBE4E4
  minHeight  get=0x09EBE544
  minWidth  get=0x09EBE5A8
  opacity  get=0x09EBE60C
  overflow  get=0x09EBE670
  paddingBottom  get=0x09EBE6D4
  paddingLeft  get=0x09EBE738
  paddingRight  get=0x09EBE79C
  paddingTop  get=0x09EBE800
  position  get=0x09EBE864
  right  get=0x09EBE8C8
  rotate  get=0x09EBE92C
  scale  get=0x09EBE9A0
  textOverflow  get=0x09EBEA0C
  textShadow  get=0x09EBEA6C
  top  get=0x09EBEAE4
  transformOrigin  get=0x09EBEB48
  transitionDelay  get=0x09EBEBBC
  transitionDuration  get=0x09EBEC1C
  transitionProperty  get=0x09EBEC7C
  transitionTimingFunction  get=0x09EBECDC
  translate  get=0x09EBED3C
  unityBackgroundImageTintColor  get=0x09EBEDB4
  unityBackgroundScaleMode  get=0x09EBEE20
  unityFont  get=0x09EBEF44
  unityFontDefinition  get=0x09EBEE80
  unityFontStyleAndWeight  get=0x09EBEEE8
  unityOverflowClipBox  get=0x09EBEFA0
  unityParagraphSpacing  get=0x09EBF000
  unitySliceBottom  get=0x09EBF05C
  unitySliceLeft  get=0x09EBF0BC
  unitySliceRight  get=0x09EBF11C
  unitySliceTop  get=0x09EBF17C
  unityTextAlign  get=0x09EBF1DC
  unityTextOutlineColor  get=0x09EBF238
  unityTextOutlineWidth  get=0x09EBF2A0
  unityTextOverflowPosition  get=0x09EBF2FC
  visibility  get=0x09EBF35C
  whiteSpace  get=0x09EBF3B8
  width  get=0x09EBF418
  wordSpacing  get=0x09EBF47C
METHODS:
  RVA=0x09EBC718  token=0x60016B3  UnityEngine.UIElements.ComputedStyle& Get()
  RVA=0x09EBC67C  token=0x60016B4  UnityEngine.UIElements.ComputedStyle Acquire()
  RVA=0x09EBC764  token=0x60016B5  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.ShorthandApplicator
TYPE:  static class
TOKEN: 0x200033A
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>s_TransitionDelayList  // static @ 0x0
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>s_TransitionDurationList  // static @ 0x8
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>s_TransitionPropertyList  // static @ 0x10
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>s_TransitionTimingFunctionList  // static @ 0x18
METHODS:
  RVA=0x09EBF76C  token=0x6001703  System.Void ApplyBorderColor(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBF868  token=0x6001704  System.Void ApplyBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBF954  token=0x6001705  System.Void ApplyBorderWidth(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBFA3C  token=0x6001706  System.Void ApplyFlex(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBFB08  token=0x6001707  System.Void ApplyMargin(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBFBEC  token=0x6001708  System.Void ApplyPadding(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBFCDC  token=0x6001709  System.Void ApplyTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EBFE14  token=0x600170A  System.Void ApplyUnityTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  RVA=0x09EC0384  token=0x600170B  System.Boolean CompileFlexShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Single& grow, System.Single& shrink, UnityEngine.UIElements.Length& basis)
  RVA=0x09EBFEB8  token=0x600170C  System.Void CompileBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.Length& top, UnityEngine.UIElements.Length& right, UnityEngine.UIElements.Length& bottom, UnityEngine.UIElements.Length& left)
  RVA=0x09EC0228  token=0x600170D  System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.Length& top, UnityEngine.UIElements.Length& right, UnityEngine.UIElements.Length& bottom, UnityEngine.UIElements.Length& left)
  RVA=0x09EC017C  token=0x600170E  System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Single& top, System.Single& right, System.Single& bottom, System.Single& left)
  RVA=0x09EBFFA8  token=0x600170F  System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.Color& top, UnityEngine.Color& right, UnityEngine.Color& bottom, UnityEngine.Color& left)
  RVA=0x09EC0538  token=0x6001710  System.Void CompileTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.Color& outlineColor, System.Single& outlineWidth)
  RVA=0x09EC05F0  token=0x6001711  System.Void CompileTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDelay, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDuration, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>& outProperty, System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>& outTimingFunction)
  RVA=0x09EC0B5C  token=0x6001712  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyCache
TYPE:  static class
TOKEN: 0x200033B
SIZE:  0x10
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_PropertySyntaxCache  // static @ 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_NonTerminalValues  // static @ 0x8
METHODS:
  RVA=0x09EC0D88  token=0x6001713  System.Boolean TryGetSyntax(System.String name, System.String& syntax)
  RVA=0x09EC0D08  token=0x6001714  System.Boolean TryGetNonTerminalValue(System.String name, System.String& syntax)
  RVA=0x09EC0E04  token=0x6001715  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleEnumType
TYPE:  sealed struct
TOKEN: 0x200033C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeAlign  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeDisplayStyle  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeEasingMode  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeFlexDirection  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeFontStyle  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeJustify  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeOverflow  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeOverflowClipBox  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeOverflowInternal  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypePosition  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeScaleMode  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTextAnchor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTextOverflow  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTextOverflowPosition  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTransformOriginOffset  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeVisibility  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeWhiteSpace  // const
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeWrap  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyId
TYPE:  sealed struct
TOKEN: 0x200033D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnknown  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdCustom  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAlignContent  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAlignItems  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAlignSelf  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAll  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBackgroundColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBackgroundImage  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomLeftRadius  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomRightRadius  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderLeftColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderLeftWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderRadius  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderRightColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderRightWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopLeftRadius  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopRightRadius  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBottom  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdCursor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdDisplay  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlex  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexBasis  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexDirection  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexGrow  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexShrink  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexWrap  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFontSize  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdHeight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdJustifyContent  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdLeft  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdLetterSpacing  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMargin  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginBottom  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginLeft  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginRight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginTop  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMaxHeight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMaxWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMinHeight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMinWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdOpacity  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdOverflow  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPadding  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingBottom  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingLeft  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingRight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingTop  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPosition  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdRight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdRotate  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdScale  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTextOverflow  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTextShadow  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTop  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransformOrigin  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransition  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionDelay  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionDuration  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionProperty  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionTimingFunction  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTranslate  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityBackgroundImageTintColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityBackgroundScaleMode  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityFont  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityFontDefinition  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityFontStyleAndWeight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityOverflowClipBox  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityParagraphSpacing  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceBottom  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceLeft  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceRight  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceTop  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextAlign  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOutline  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOutlineColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOutlineWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOverflowPosition  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdVisibility  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdWhiteSpace  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdWidth  // const
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdWordSpacing  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Dimension
TYPE:  sealed struct
TOKEN: 0x200033E
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.Dimension.Unitunit  // 0x10
  public            System.Single                   value  // 0x14
METHODS:
  RVA=0x03D88C60  token=0x6001716  System.Void .ctor(System.Single value, UnityEngine.UIElements.StyleSheets.Dimension.Unit unit)
  RVA=0x09EBC1D8  token=0x6001717  UnityEngine.UIElements.Length ToLength()
  RVA=0x09EBC374  token=0x6001718  UnityEngine.UIElements.TimeValue ToTime()
  RVA=0x09EBC18C  token=0x6001719  UnityEngine.UIElements.Angle ToAngle()
  RVA=0x09EBC394  token=0x600171A  System.Boolean op_Equality(UnityEngine.UIElements.StyleSheets.Dimension lhs, UnityEngine.UIElements.StyleSheets.Dimension rhs)
  RVA=0x09EBC150  token=0x600171B  System.Boolean Equals(UnityEngine.UIElements.StyleSheets.Dimension other)
  RVA=0x09EBC0E0  token=0x600171C  System.Boolean Equals(System.Object obj)
  RVA=0x09EBC164  token=0x600171D  System.Int32 GetHashCode()
  RVA=0x09EBC208  token=0x600171E  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.ScalableImage
TYPE:  sealed struct
TOKEN: 0x2000340
SIZE:  0x20
FIELDS:
  public            UnityEngine.Texture2D           normalImage  // 0x10
  public            UnityEngine.Texture2D           highResolutionImage  // 0x18
METHODS:
  RVA=0x09EBF4DC  token=0x600171F  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyValue
TYPE:  sealed struct
TOKEN: 0x2000341
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleValueHandlehandle  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.ImageSource
TYPE:  sealed struct
TOKEN: 0x2000342
SIZE:  0x30
FIELDS:
  public            UnityEngine.Texture2D           texture  // 0x10
  public            UnityEngine.Sprite              sprite  // 0x18
  public            UnityEngine.UIElements.VectorImagevectorImage  // 0x20
  public            UnityEngine.RenderTexture       renderTexture  // 0x28
METHODS:
  RVA=0x09EBC5B4  token=0x6001720  System.Boolean IsNull()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyReader
TYPE:  class
TOKEN: 0x2000343
SIZE:  0x60
FIELDS:
  private   static  UnityEngine.UIElements.StyleSheets.StylePropertyReader.GetCursorIdFunctiongetCursorIdFunc  // static @ 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_Values  // 0x10
  private           System.Collections.Generic.List<System.Int32>m_ValueCount  // 0x18
  private           UnityEngine.UIElements.StyleVariableResolverm_Resolver  // 0x20
  private           UnityEngine.UIElements.StyleSheetm_Sheet  // 0x28
  private           UnityEngine.UIElements.StyleProperty[]m_Properties  // 0x30
  private           UnityEngine.UIElements.StyleSheets.StylePropertyId[]m_PropertyIds  // 0x38
  private           System.Int32                    m_CurrentValueIndex  // 0x40
  private           System.Int32                    m_CurrentPropertyIndex  // 0x44
  private           UnityEngine.UIElements.StyleProperty<property>k__BackingField  // 0x48
  private           UnityEngine.UIElements.StyleSheets.StylePropertyId<propertyId>k__BackingField  // 0x50
  private           System.Int32                    <valueCount>k__BackingField  // 0x54
  private           System.Single                   <dpiScaling>k__BackingField  // 0x58
PROPERTIES:
  property  get=0x03D4EA70  set=0x02692290
  propertyId  get=0x03D4EED0  set=0x03D4EF20
  valueCount  get=0x03D4EEC0  set=0x03D4EF10
  dpiScaling  get=0x03D51080  set=0x03D510B0
METHODS:
  RVA=0x09EC48CC  token=0x6001729  System.Void SetContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleComplexSelector selector, UnityEngine.UIElements.StyleVariableContext varContext, System.Single dpiScaling)
  RVA=0x09EC4A64  token=0x600172A  System.Void SetInlineContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleProperty[] properties, UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds, System.Single dpiScaling)
  RVA=0x09EC24C0  token=0x600172B  UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty()
  RVA=0x09EC2020  token=0x600172C  UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(System.Int32 index)
  RVA=0x09EC1FBC  token=0x600172D  UnityEngine.UIElements.StyleValueType GetValueType(System.Int32 index)
  RVA=0x09EC212C  token=0x600172E  System.Boolean IsValueType(System.Int32 index, UnityEngine.UIElements.StyleValueType type)
  RVA=0x09EC20A0  token=0x600172F  System.Boolean IsKeyword(System.Int32 index, UnityEngine.UIElements.StyleValueKeyword keyword)
  RVA=0x09EC255C  token=0x6001730  System.String ReadAsString(System.Int32 index)
  RVA=0x09EC34F4  token=0x6001731  UnityEngine.UIElements.Length ReadLength(System.Int32 index)
  RVA=0x09EC4130  token=0x6001732  UnityEngine.UIElements.TimeValue ReadTimeValue(System.Int32 index)
  RVA=0x09EC459C  token=0x6001733  UnityEngine.UIElements.Translate ReadTranslate(System.Int32 index)
  RVA=0x09EC42DC  token=0x6001734  UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 index)
  RVA=0x09EC3A44  token=0x6001735  UnityEngine.UIElements.Rotate ReadRotate(System.Int32 index)
  RVA=0x09EC3D58  token=0x6001736  UnityEngine.UIElements.Scale ReadScale(System.Int32 index)
  RVA=0x09EC2D60  token=0x6001737  System.Single ReadFloat(System.Int32 index)
  RVA=0x09EC347C  token=0x6001738  System.Int32 ReadInt(System.Int32 index)
  RVA=0x09EC2824  token=0x6001739  UnityEngine.Color ReadColor(System.Int32 index)
  RVA=0x09EC2C8C  token=0x600173A  System.Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, System.Int32 index)
  RVA=0x09EC2DD4  token=0x600173B  UnityEngine.UIElements.FontDefinition ReadFontDefinition(System.Int32 index)
  RVA=0x09EC31E4  token=0x600173C  UnityEngine.Font ReadFont(System.Int32 index)
  RVA=0x09EC25CC  token=0x600173D  UnityEngine.UIElements.Background ReadBackground(System.Int32 index)
  RVA=0x09EC292C  token=0x600173E  UnityEngine.UIElements.Cursor ReadCursor(System.Int32 index)
  RVA=0x09EC3E94  token=0x600173F  UnityEngine.UIElements.TextShadow ReadTextShadow(System.Int32 index)
  RVA=0x09EC35B0  token=0x6001740  System.Void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, System.Int32 index)
  RVA=0x09EC3838  token=0x6001741  System.Void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, System.Int32 index)
  RVA=0x09EC36FC  token=0x6001742  System.Void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, System.Int32 index)
  RVA=0x09EC21A0  token=0x6001743  System.Void LoadProperties()
  RVA=0x09EC49A8  token=0x6001744  System.Void SetCurrentProperty()
  RVA=0x09EC4424  token=0x6001745  UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue zVvalue)
  RVA=0x09EC41F0  token=0x6001746  UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue value, System.Boolean& isVertical, System.Boolean& isHorizontal)
  RVA=0x09EC46EC  token=0x6001747  UnityEngine.UIElements.Translate ReadTranslate(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3)
  RVA=0x09EC3BE0  token=0x6001748  UnityEngine.UIElements.Scale ReadScale(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3)
  RVA=0x09EC3988  token=0x6001749  UnityEngine.UIElements.Rotate ReadRotate(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3, UnityEngine.UIElements.StyleSheets.StylePropertyValue val4)
  RVA=0x09EC2BF4  token=0x600174A  System.Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue value)
  RVA=0x09EC24E4  token=0x600174B  UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue value)
  RVA=0x09EC4AB0  token=0x600174C  System.Boolean TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue propertyValue, System.Single dpiScaling, UnityEngine.UIElements.StyleSheets.ImageSource& source)
  RVA=0x09EC5028  token=0x600174D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.MatchResultInfo
TYPE:  sealed struct
TOKEN: 0x2000345
SIZE:  0x1C
FIELDS:
  public    readonly System.Boolean                  success  // 0x10
  public    readonly UnityEngine.UIElements.PseudoStatestriggerPseudoMask  // 0x14
  public    readonly UnityEngine.UIElements.PseudoStatesdependencyPseudoMask  // 0x18
METHODS:
  RVA=0x03D88C70  token=0x6001750  System.Void .ctor(System.Boolean success, UnityEngine.UIElements.PseudoStates triggerPseudoMask, UnityEngine.UIElements.PseudoStates dependencyPseudoMask)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.SelectorMatchRecord
TYPE:  sealed struct
TOKEN: 0x2000346
SIZE:  0x28
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            System.Int32                    styleSheetIndexInStack  // 0x18
  public            UnityEngine.UIElements.StyleComplexSelectorcomplexSelector  // 0x20
METHODS:
  RVA=0x09EBF70C  token=0x6001751  System.Void .ctor(UnityEngine.UIElements.StyleSheet sheet, System.Int32 styleSheetIndexInStack)
  RVA=0x09EBF5F0  token=0x6001752  System.Int32 Compare(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSelectorHelper
TYPE:  static class
TOKEN: 0x2000347
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09EC5FB8  token=0x6001753  UnityEngine.UIElements.StyleSheets.MatchResultInfo MatchesSelector(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSelector selector)
  RVA=0x09EC5E28  token=0x6001754  System.Boolean MatchRightToLeft(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult)
  RVA=0x09EC5848  token=0x6001755  System.Void FastLookup(System.Collections.Generic.IDictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, UnityEngine.UIElements.StyleMatchingContext context, System.String input, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord& record)
  RVA=0x09EC5990  token=0x6001756  System.Void FindMatches(UnityEngine.UIElements.StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, System.Int32 parentSheetIndex)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSheetCache
TYPE:  static class
TOKEN: 0x2000348
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKeyComparers_Comparer  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey,UnityEngine.UIElements.StyleSheets.StylePropertyId[]>s_RulePropertyIdsCache  // static @ 0x8
METHODS:
  RVA=0x09EC62DC  token=0x6001757  UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleSheet sheet, System.Int32 ruleIndex)
  RVA=0x09EC647C  token=0x6001758  UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleRule rule)
  RVA=0x09EC621C  token=0x6001759  UnityEngine.UIElements.StyleSheets.StylePropertyId GetPropertyId(UnityEngine.UIElements.StyleRule rule, System.Int32 index)
  RVA=0x09EC652C  token=0x600175A  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSheetColor
TYPE:  static class
TOKEN: 0x200034B
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.Color32>s_NameToColor  // static @ 0x0
METHODS:
  RVA=0x09EC6620  token=0x600175F  System.Boolean TryGetColor(System.String name, UnityEngine.Color& color)
  RVA=0x03D88C80  token=0x6001760  UnityEngine.Color32 HexToColor32(System.UInt32 color)
  RVA=0x09EC66C0  token=0x6001761  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSheetExtensions
TYPE:  static class
TOKEN: 0x200034C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09EC83F4  token=0x6001762  System.String ReadAsString(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle)
  RVA=0x09EC83DC  token=0x6001763  System.Boolean IsVarFunction(UnityEngine.UIElements.StyleValueHandle handle)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleValue
TYPE:  sealed struct
TOKEN: 0x200034D
SIZE:  0x28
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.StylePropertyIdid  // 0x10
  public            UnityEngine.UIElements.StyleKeywordkeyword  // 0x14
  public            System.Single                   number  // 0x18
  public            UnityEngine.UIElements.Length   length  // 0x18
  public            UnityEngine.Color               color  // 0x18
  public            System.Runtime.InteropServices.GCHandleresource  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleValueManaged
TYPE:  sealed struct
TOKEN: 0x200034E
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.StylePropertyIdid  // 0x10
  public            UnityEngine.UIElements.StyleKeywordkeyword  // 0x14
  public            System.Object                   value  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.MatchResultErrorCode
TYPE:  sealed struct
TOKEN: 0x200034F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeNone  // const
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeSyntax  // const
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeEmptyValue  // const
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeExpectedEndOfValue  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.MatchResult
TYPE:  sealed struct
TOKEN: 0x2000350
SIZE:  0x20
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeerrorCode  // 0x10
  public            System.String                   errorValue  // 0x18
PROPERTIES:
  success  get=0x022FBAA0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.BaseStyleMatcher
TYPE:  abstract class
TOKEN: 0x2000351
SIZE:  0x20
FIELDS:
  protected static readonly System.Text.RegularExpressions.Regexs_CustomIdentRegex  // static @ 0x0
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext>m_ContextStack  // 0x10
  private           UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContextm_CurrentContext  // 0x18
PROPERTIES:
  valueCount  get=-1  // abstract
  isCurrentVariable  get=-1  // abstract
  isCurrentComma  get=-1  // abstract
  hasCurrent  get=0x09EBC0BC
  currentIndex  get=0x020D1AC0  set=0x03D4E9C0
  matchedVariableCount  get=0x03D4EBB0  set=0x03D4EBC0
METHODS:
  RVA=-1  // abstract  token=0x6001765  System.Boolean MatchKeyword(System.String keyword)
  RVA=-1  // abstract  token=0x6001766  System.Boolean MatchNumber()
  RVA=-1  // abstract  token=0x6001767  System.Boolean MatchInteger()
  RVA=-1  // abstract  token=0x6001768  System.Boolean MatchLength()
  RVA=-1  // abstract  token=0x6001769  System.Boolean MatchPercentage()
  RVA=-1  // abstract  token=0x600176A  System.Boolean MatchColor()
  RVA=-1  // abstract  token=0x600176B  System.Boolean MatchResource()
  RVA=-1  // abstract  token=0x600176C  System.Boolean MatchUrl()
  RVA=-1  // abstract  token=0x600176D  System.Boolean MatchTime()
  RVA=-1  // abstract  token=0x600176E  System.Boolean MatchAngle()
  RVA=-1  // abstract  token=0x600176F  System.Boolean MatchCustomIdent()
  RVA=0x09EBB620  token=0x6001778  System.Void Initialize()
  RVA=0x09EBBEE4  token=0x6001779  System.Void MoveNext()
  RVA=0x09EBBF64  token=0x600177A  System.Void SaveContext()
  RVA=0x09EBBF18  token=0x600177B  System.Void RestoreContext()
  RVA=0x09EBB5D8  token=0x600177C  System.Void DropContext()
  RVA=0x09EBBE44  token=0x600177D  System.Boolean Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBB8F8  token=0x600177E  System.Boolean MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBB830  token=0x600177F  System.Boolean MatchExpressionWithMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBB9BC  token=0x6001780  System.Boolean MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBB69C  token=0x6001781  System.Boolean MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBBD5C  token=0x6001782  System.Boolean MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBBD44  token=0x6001783  System.Boolean MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBB668  token=0x6001784  System.Boolean MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBBC14  token=0x6001785  System.Int32 MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBBACC  token=0x6001786  System.Int32 MatchManyByOrder(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Int32* matchOrder)
  RVA=0x09EBBA64  token=0x6001787  System.Boolean MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBB764  token=0x6001788  System.Boolean MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  RVA=0x09EBC044  token=0x6001789  System.Void .ctor()
  RVA=0x09EBBFB0  token=0x600178A  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher
TYPE:  class
TOKEN: 0x2000353
SIZE:  0x28
EXTENDS: UnityEngine.UIElements.StyleSheets.BaseStyleMatcher
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_Values  // 0x20
PROPERTIES:
  current  get=0x09EC5714
  valueCount  get=0x09EC5808
  isCurrentVariable  get=0x0115F4C0
  isCurrentComma  get=0x09EC5794
METHODS:
  RVA=0x09EC5550  token=0x600178F  UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values)
  RVA=0x09EC5330  token=0x6001790  System.Boolean MatchKeyword(System.String keyword)
  RVA=0x09EC5310  token=0x6001791  System.Boolean MatchNumber()
  RVA=0x09EC5310  token=0x6001792  System.Boolean MatchInteger()
  RVA=0x09EC53CC  token=0x6001793  System.Boolean MatchLength()
  RVA=0x09EC5440  token=0x6001794  System.Boolean MatchPercentage()
  RVA=0x09EC519C  token=0x6001795  System.Boolean MatchColor()
  RVA=0x09EC54B4  token=0x6001796  System.Boolean MatchResource()
  RVA=0x09EC5524  token=0x6001797  System.Boolean MatchUrl()
  RVA=0x09EC54D4  token=0x6001798  System.Boolean MatchTime()
  RVA=0x09EC5258  token=0x6001799  System.Boolean MatchCustomIdent()
  RVA=0x09EC5120  token=0x600179A  System.Boolean MatchAngle()
  RVA=0x09EC56C8  token=0x600179B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.Expression
TYPE:  class
TOKEN: 0x2000354
SIZE:  0x38
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypetype  // 0x10
  public            UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultipliermultiplier  // 0x14
  public            UnityEngine.UIElements.StyleSheets.Syntax.DataTypedataType  // 0x20
  public            UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorcombinator  // 0x24
  public            UnityEngine.UIElements.StyleSheets.Syntax.Expression[]subExpressions  // 0x28
  public            System.String                   keyword  // 0x30
METHODS:
  RVA=0x09EBC42C  token=0x600179C  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType
TYPE:  sealed struct
TOKEN: 0x2000355
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeUnknown  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeData  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeKeyword  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeCombinator  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.DataType
TYPE:  sealed struct
TOKEN: 0x2000356
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeNone  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeNumber  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeInteger  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeLength  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypePercentage  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeColor  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeResource  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeUrl  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeTime  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeAngle  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeCustomIdent  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator
TYPE:  sealed struct
TOKEN: 0x2000357
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorNone  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorOr  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorOrOr  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorAndAnd  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorJuxtaposition  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorGroup  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType
TYPE:  sealed struct
TOKEN: 0x2000358
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeNone  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeZeroOrMore  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeOneOrMore  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeZeroOrOne  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeRanges  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeOneOrMoreComma  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeGroupAtLeastOne  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier
TYPE:  sealed struct
TOKEN: 0x2000359
SIZE:  0x1C
FIELDS:
  public    static  System.Int32                    Infinity  // const
  private           UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypem_Type  // 0x10
  public            System.Int32                    min  // 0x14
  public            System.Int32                    max  // 0x18
PROPERTIES:
  type  get=0x03D85860  set=0x09EBC424
METHODS:
  RVA=0x09EBC40C  token=0x600179F  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type)
  RVA=0x09EBC3B8  token=0x60017A0  System.Void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser
TYPE:  class
TOKEN: 0x200035A
SIZE:  0x30
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.Expression>m_ProcessExpressionList  // 0x10
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.Expression>m_ExpressionStack  // 0x18
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator>m_CombinatorStack  // 0x20
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.Syntax.Expression>m_ParsedExpressionCache  // 0x28
METHODS:
  RVA=0x09EC9D44  token=0x60017A1  UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(System.String syntax)
  RVA=0x09EC8DD0  token=0x60017A2  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC9EE8  token=0x60017A3  System.Void ProcessCombinatorStack()
  RVA=0x09EC9B94  token=0x60017A4  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC877C  token=0x60017A5  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC904C  token=0x60017A6  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC88F0  token=0x60017A7  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC9490  token=0x60017A8  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(System.String syntax)
  RVA=0x09EC95C4  token=0x60017A9  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC92E8  token=0x60017AA  System.Void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier& multiplier)
  RVA=0x09EC9A5C  token=0x60017AB  System.Void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, System.Int32& min, System.Int32& max)
  RVA=0x09EC86D8  token=0x60017AC  System.Void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  RVA=0x09EC8740  token=0x60017AD  System.Boolean IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token)
  RVA=0x09EC872C  token=0x60017AE  System.Boolean IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token)
  RVA=0x09EC875C  token=0x60017AF  System.Boolean IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token)
  RVA=0x09ECA120  token=0x60017B0  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType
TYPE:  sealed struct
TOKEN: 0x200035B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeUnknown  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeString  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeNumber  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeSpace  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeSingleBar  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeDoubleBar  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeDoubleAmpersand  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeComma  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeSingleQuote  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeAsterisk  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypePlus  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeQuestionMark  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeHashMark  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeExclamationPoint  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeOpenBracket  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeCloseBracket  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeOpenBrace  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeCloseBrace  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeLessThan  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeGreaterThan  // const
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeEnd  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken
TYPE:  sealed struct
TOKEN: 0x200035C
SIZE:  0x28
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypetype  // 0x10
  public            System.String                   text  // 0x18
  public            System.Int32                    number  // 0x20
METHODS:
  RVA=0x09ECAD40  token=0x60017B1  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType t)
  RVA=0x09ECAD64  token=0x60017B2  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, System.String text)
  RVA=0x09ECAD88  token=0x60017B3  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, System.Int32 number)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer
TYPE:  class
TOKEN: 0x200035D
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken>m_Tokens  // 0x10
  private           System.Int32                    m_CurrentTokenIndex  // 0x18
PROPERTIES:
  current  get=0x09ECB9FC
METHODS:
  RVA=0x09ECAF78  token=0x60017B5  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext()
  RVA=0x09ECB02C  token=0x60017B6  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext()
  RVA=0x09ECB0E4  token=0x60017B7  System.Void Tokenize(System.String syntax)
  RVA=0x09ECAE00  token=0x60017B8  System.Boolean IsNextCharacter(System.String s, System.Int32 index, System.Char c)
  RVA=0x09ECAE3C  token=0x60017B9  System.Boolean IsNextLetterOrDash(System.String s, System.Int32 index)
  RVA=0x09ECAEF8  token=0x60017BA  System.Boolean IsNextNumber(System.String s, System.Int32 index)
  RVA=0x09ECADB0  token=0x60017BB  System.Int32 GlobCharacter(System.String s, System.Int32 index, System.Char c)
  RVA=0x09ECB980  token=0x60017BC  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Allocator2D
TYPE:  class
TOKEN: 0x20002D7
SIZE:  0x40
FIELDS:
  private   readonly UnityEngine.Vector2Int          m_MinSize  // 0x10
  private   readonly UnityEngine.Vector2Int          m_MaxSize  // 0x18
  private   readonly UnityEngine.Vector2Int          m_MaxAllocSize  // 0x20
  private   readonly System.Int32                    m_RowHeightBias  // 0x28
  private   readonly UnityEngine.UIElements.UIR.Allocator2D.Row[]m_Rows  // 0x30
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area>m_Areas  // 0x38
METHODS:
  RVA=0x09F45330  token=0x600142B  System.Void .ctor(UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize, System.Int32 rowHeightBias)
  RVA=0x09F44ED4  token=0x600142C  System.Boolean TryAllocate(System.Int32 width, System.Int32 height, UnityEngine.UIElements.UIR.Allocator2D.Alloc2D& alloc2D)
  RVA=0x09F44CD0  token=0x600142D  System.Void Free(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D)
  RVA=0x09F449F8  token=0x600142E  System.Void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize)
  RVA=0x09F44C04  token=0x600142F  UnityEngine.Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, System.Int32 rowHeightBias)
  RVA=0x09F44B9C  token=0x6001430  UnityEngine.UIElements.UIR.Allocator2D.Row[] BuildRowArray(System.Int32 maxRowHeight, System.Int32 rowHeightBias)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GradientSettingsAtlas
TYPE:  class
TOKEN: 0x20002DB
SIZE:  0x40
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerWrite  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerCommit  // static @ 0x8
  private   readonly System.Int32                    m_Length  // 0x10
  private   readonly System.Int32                    m_ElemWidth  // 0x14
  private           UnityEngine.UIElements.UIR.BestFitAllocatorm_Allocator  // 0x18
  private           UnityEngine.Texture2D           m_Atlas  // 0x20
  private           UnityEngine.UIElements.UIR.GradientSettingsAtlas.RawTexturem_RawAtlas  // 0x28
  private   static  System.Int32                    s_TextureCounter  // static @ 0x10
  private           System.Boolean                  <disposed>k__BackingField  // 0x38
  private           System.Boolean                  <MustCommit>k__BackingField  // 0x39
PROPERTIES:
  length  get=0x03D85B00
  disposed  get=0x03D4F190  set=0x03D4E280
  atlas  get=0x03D85A20
  MustCommit  get=0x03D4F300  set=0x03D4F330
METHODS:
  RVA=0x09F45C20  token=0x600143A  System.Void Dispose()
  RVA=0x09F45C70  token=0x600143B  System.Void Dispose(System.Boolean disposing)
  RVA=0x09F462B4  token=0x600143C  System.Void .ctor(System.Int32 length)
  RVA=0x09F45E24  token=0x600143D  System.Void Reset()
  RVA=0x09F45AF8  token=0x600143F  UnityEngine.UIElements.UIR.Alloc Add(System.Int32 count)
  RVA=0x09F45EDC  token=0x6001440  System.Void Write(UnityEngine.UIElements.UIR.Alloc alloc, UnityEngine.UIElements.GradientSettings[] settings, UnityEngine.UIElements.UIR.GradientRemap remap)
  RVA=0x09F45BBC  token=0x6001443  System.Void Commit()
  RVA=0x09F45CD0  token=0x6001444  System.Void PrepareAtlas()
  RVA=0x09F4621C  token=0x6001445  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
TYPE:  class
TOKEN: 0x20002DD
FIELDS:
  private           T                               poolNext  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6001448  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.LinkedPool`1
TYPE:  class
TOKEN: 0x20002DE
FIELDS:
  private   readonly System.Func<T>                  m_CreateFunc  // 0x0
  private   readonly System.Action<T>                m_ResetAction  // 0x0
  private   readonly System.Int32                    m_Limit  // 0x0
  private           T                               m_PoolFirst  // 0x0
  private           System.Int32                    <Count>k__BackingField  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6001449  System.Void .ctor(System.Func<T> createFunc, System.Action<T> resetAction, System.Int32 limit)
  RVA=-1  // not resolved  token=0x600144C  System.Void Clear()
  RVA=-1  // not resolved  token=0x600144D  T Get()
  RVA=-1  // not resolved  token=0x600144E  System.Void Return(T item)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BasicNode`1
TYPE:  class
TOKEN: 0x20002DF
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  public            UnityEngine.UIElements.UIR.BasicNode<T>next  // 0x0
  public            T                               data  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600144F  System.Void AppendTo(UnityEngine.UIElements.UIR.BasicNode<T>& first)
  RVA=-1  // not resolved  token=0x6001450  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BasicNodePool`1
TYPE:  class
TOKEN: 0x20002E0
EXTENDS: UnityEngine.UIElements.UIR.LinkedPool`1
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6001451  System.Void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node)
  RVA=-1  // not resolved  token=0x6001452  UnityEngine.UIElements.UIR.BasicNode<T> Create()
  RVA=-1  // not resolved  token=0x6001453  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.MeshBuilder
TYPE:  static class
TOKEN: 0x20002E1
SIZE:  0x10
FIELDS:
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphics9Slice  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphicsSplitTriangle  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphicsScaleTriangle  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphicsStretch  // static @ 0x18
  private   static readonly System.Int32                    s_MaxTextMeshVertices  // static @ 0x20
  private   static readonly System.UInt16[]                 slicedQuadIndices  // static @ 0x28
  private   static readonly System.Single[]                 k_TexCoordSlicesX  // static @ 0x30
  private   static readonly System.Single[]                 k_TexCoordSlicesY  // static @ 0x38
  private   static readonly System.Single[]                 k_PositionSlicesX  // static @ 0x40
  private   static readonly System.Single[]                 k_PositionSlicesY  // static @ 0x48
  private   static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge[]s_AllClipEdges  // static @ 0x50
METHODS:
  RVA=0x09F49ED8  token=0x6001454  System.Void MakeBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09F4ACA8  token=0x6001455  System.Void MakeSolidRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09F4B514  token=0x6001456  System.Void MakeTexturedRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage)
  RVA=0x09F49598  token=0x6001457  UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, System.Int32 index, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.VertexFlags flags, System.Boolean isDynamicColor)
  RVA=0x03D898C0  token=0x6001458  UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, UnityEngine.Vector2 offset)
  RVA=0x09F49DE4  token=0x6001459  System.Int32 LimitTextVertices(System.Int32 vertexCount, System.Boolean logTruncation)
  RVA=0x09F4B1B8  token=0x600145A  System.Void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.UIR.VertexFlags flags, System.Boolean isDynamicColor)
  RVA=0x09F4AE9C  token=0x600145B  System.Void MakeText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09F4F48C  token=0x600145C  System.Void UpdateText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.Matrix4x4 transform, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 flags, UnityEngine.Color32 opacityPageSettingIndex, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices)
  RVA=0x09F49FD0  token=0x600145D  System.Void MakeQuad(UnityEngine.Rect rcPosition, UnityEngine.Rect rcTexCoord, UnityEngine.Color color, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage)
  RVA=0x09F4A3D4  token=0x600145E  System.Void MakeSlicedQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09F4CD10  token=0x600145F  System.Void MakeVectorGraphics(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Int32& finalVertexCount, System.Int32& finalIndexCount)
  RVA=0x09F4C524  token=0x6001460  System.Void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, System.UInt16[] svgIndices, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Int32& finalVertexCount, System.Int32& finalIndexCount)
  RVA=0x09F4EC40  token=0x6001461  System.Void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, System.UInt16* indices, System.Int32& vertexCount, System.Int32 indexToProcess, System.Int32& indexCount, System.Single svgWidth, System.Single svgHeight, UnityEngine.Vector4 sliceLTRB, System.Int32 sliceIndex)
  RVA=0x09F4E9CC  token=0x6001462  System.Void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, System.Int32 vertexCount, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB)
  RVA=0x09F4BD28  token=0x6001463  System.Void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, System.UInt16[] svgIndices, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB, System.Boolean stretch, UnityEngine.Color tint, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09F4F6B4  token=0x6001464  UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, System.UInt16[] indices, UnityEngine.Vector4 clipRectMinMax)
  RVA=0x09F4E4E4  token=0x6001465  System.Void RectClip(UnityEngine.UIElements.Vertex[] vertices, System.UInt16[] indices, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts cc, System.Int32& newVertexCount)
  RVA=0x09F4D804  token=0x6001466  System.Void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, System.UInt16* it, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, System.UInt16& nextNewVertex)
  RVA=0x09F4974C  token=0x6001467  UnityEngine.Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, System.Single x, System.Single y)
  RVA=0x09F49A80  token=0x6001468  UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, System.Single x, System.Single y, UnityEngine.Vector3 uvw)
  RVA=0x09F498B0  token=0x6001469  UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, System.Int32 e0, System.Int32 e1, System.Single t)
  RVA=0x09F49CB4  token=0x600146A  System.Single IntersectSegments(System.Single ax, System.Single ay, System.Single bx, System.Single by, System.Single cx, System.Single cy, System.Single dx, System.Single dy)
  RVA=0x09F4F8F4  token=0x600146B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ChainBuilderStats
TYPE:  sealed struct
TOKEN: 0x20002E6
SIZE:  0x70
FIELDS:
  public            System.UInt32                   elementsAdded  // 0x10
  public            System.UInt32                   elementsRemoved  // 0x14
  public            System.UInt32                   recursiveClipUpdates  // 0x18
  public            System.UInt32                   recursiveClipUpdatesExpanded  // 0x1c
  public            System.UInt32                   nonRecursiveClipUpdates  // 0x20
  public            System.UInt32                   recursiveTransformUpdates  // 0x24
  public            System.UInt32                   recursiveTransformUpdatesExpanded  // 0x28
  public            System.UInt32                   recursiveOpacityUpdates  // 0x2c
  public            System.UInt32                   recursiveOpacityUpdatesExpanded  // 0x30
  public            System.UInt32                   colorUpdates  // 0x34
  public            System.UInt32                   colorUpdatesExpanded  // 0x38
  public            System.UInt32                   recursiveVisualUpdates  // 0x3c
  public            System.UInt32                   recursiveVisualUpdatesExpanded  // 0x40
  public            System.UInt32                   nonRecursiveVisualUpdates  // 0x44
  public            System.UInt32                   dirtyProcessed  // 0x48
  public            System.UInt32                   nudgeTransformed  // 0x4c
  public            System.UInt32                   boneTransformed  // 0x50
  public            System.UInt32                   skipTransformed  // 0x54
  public            System.UInt32                   visualUpdateTransformed  // 0x58
  public            System.UInt32                   updatedMeshAllocations  // 0x5c
  public            System.UInt32                   newMeshAllocations  // 0x60
  public            System.UInt32                   groupTransformElementsChanged  // 0x64
  public            System.UInt32                   immedateRenderersActive  // 0x68
  public            System.UInt32                   textUpdates  // 0x6c
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChain
TYPE:  class
TOKEN: 0x20002E7
SIZE:  0x228
IMPLEMENTS: System.IDisposable
FIELDS:
  private           UnityEngine.UIElements.UIR.RenderChainCommandm_FirstCommand  // 0x10
  private           UnityEngine.UIElements.UIR.RenderChain.DepthOrderedDirtyTrackingm_DirtyTracker  // 0x18
  private           UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.RenderChainCommand>m_CommandPool  // 0x40
  private           UnityEngine.UIElements.UIR.BasicNodePool<UnityEngine.UIElements.UIR.TextureEntry>m_TexturePool  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain.RenderNodeData>m_RenderNodesData  // 0x50
  private           UnityEngine.Shader              m_DefaultShader  // 0x58
  private           UnityEngine.Shader              m_DefaultWorldSpaceShader  // 0x60
  private           UnityEngine.Material            m_DefaultMat  // 0x68
  private           UnityEngine.Material            m_DefaultWorldSpaceMat  // 0x70
  private           System.Boolean                  m_BlockDirtyRegistration  // 0x78
  private           System.Int32                    m_StaticIndex  // 0x7c
  private           System.Int32                    m_ActiveRenderNodes  // 0x80
  private           System.Int32                    m_CustomMaterialCommands  // 0x84
  private           UnityEngine.UIElements.UIR.ChainBuilderStatsm_Stats  // 0x88
  private           System.UInt32                   m_StatsElementsAdded  // 0xe8
  private           System.UInt32                   m_StatsElementsRemoved  // 0xec
  private           UnityEngine.UIElements.VisualElementm_FirstTextElement  // 0xf0
  private           UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainterm_TextUpdatePainter  // 0xf8
  private           System.Int32                    m_TextElementCount  // 0x100
  private           System.Int32                    m_DirtyTextStartIndex  // 0x104
  private           System.Int32                    m_DirtyTextRemaining  // 0x108
  private           System.Boolean                  m_FontWasReset  // 0x10c
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.VisualElement,UnityEngine.Vector2>m_LastGroupTransformElementScale  // 0x110
  private           UnityEngine.UIElements.TextureRegistrym_TextureRegistry  // 0x118
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerProcess  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerClipProcessing  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerOpacityProcessing  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerColorsProcessing  // static @ 0x18
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTransformProcessing  // static @ 0x20
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerVisualsProcessing  // static @ 0x28
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTextRegen  // static @ 0x30
  private           System.Boolean                  <disposed>k__BackingField  // 0x120
  private   static  System.Action                   OnPreRender  // static @ 0x38
  private           UnityEngine.UIElements.BaseVisualElementPanel<panel>k__BackingField  // 0x128
  private           UnityEngine.UIElements.UIR.UIRenderDevice<device>k__BackingField  // 0x130
  private           UnityEngine.UIElements.AtlasBase<atlas>k__BackingField  // 0x138
  private           UnityEngine.UIElements.UIR.VectorImageManager<vectorImageManager>k__BackingField  // 0x140
  private           UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocatorshaderInfoAllocator  // 0x148
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter<painter>k__BackingField  // 0x218
  private           System.Boolean                  <drawStats>k__BackingField  // 0x220
  private           System.Boolean                  <drawInCameras>k__BackingField  // 0x221
PROPERTIES:
  disposed  get=0x03D57B30  set=0x03D5A200
  panel  get=0x03D56F00  set=0x04275CB8
  device  get=0x03D56D00  set=0x04275CCC
  atlas  get=0x03D56EF0  set=0x04275CE0
  vectorImageManager  get=0x03D57300  set=0x058B3FD8
  painter  get=0x03D570B0  set=0x058B3C54
  drawStats  get=0x03D88B40  set=0x03D88B60
  drawInCameras  get=0x03D88B30  set=0x03D88B50
  defaultShader  set=0x09E8DFD0
  defaultWorldSpaceShader  set=0x09E8E074
METHODS:
  RVA=0x09E8D964  token=0x600146F  System.Void .cctor()
  RVA=0x09E8DBF8  token=0x6001470  System.Void .ctor(UnityEngine.UIElements.BaseVisualElementPanel panel)
  RVA=0x09E8A6D4  token=0x6001471  System.Void Constructor(UnityEngine.UIElements.BaseVisualElementPanel panelObj, UnityEngine.UIElements.UIR.UIRenderDevice deviceObj, UnityEngine.UIElements.AtlasBase atlas, UnityEngine.UIElements.UIR.VectorImageManager vectorImageMan)
  RVA=0x09E8AA5C  token=0x6001472  System.Void Destructor()
  RVA=0x09E8ACD0  token=0x6001475  System.Void Dispose()
  RVA=0x09E8ACA4  token=0x6001476  System.Void Dispose(System.Boolean disposing)
  RVA=0x09E8C3A0  token=0x6001477  System.Void ProcessChanges()
  RVA=0x09E8CBE4  token=0x6001478  System.Void Render()
  RVA=0x09E8C91C  token=0x6001479  System.Void ProcessTextRegen(System.Boolean timeSliced)
  RVA=0x09E8D198  token=0x600147A  System.Void UIEOnChildAdded(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8D43C  token=0x600147B  System.Void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8D348  token=0x600147C  System.Void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8D140  token=0x600147D  System.Void StopTrackingGroupTransformElement(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8D790  token=0x600147E  System.Void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8D5CC  token=0x600147F  System.Void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical)
  RVA=0x09E8D6F4  token=0x6001480  System.Void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical)
  RVA=0x09E8D664  token=0x6001481  System.Void UIEOnColorChanged(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8D82C  token=0x6001482  System.Void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean transformChanged, System.Boolean clipRectSizeChanged)
  RVA=0x09E8D8C8  token=0x6001483  System.Void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical)
  RVA=0x09E8B758  token=0x6001494  UnityEngine.Material GetStandardMaterial()
  RVA=0x09E8B844  token=0x6001495  UnityEngine.Material GetStandardWorldSpaceMaterial()
  RVA=0x09E8B680  token=0x6001496  System.Void EnsureFitsDepth(System.Int32 depth)
  RVA=0x09E8A62C  token=0x6001497  System.Void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8A51C  token=0x6001498  UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand()
  RVA=0x09E8B68C  token=0x6001499  System.Void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd)
  RVA=0x09E8C1E8  token=0x600149A  System.Void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand command)
  RVA=0x09E8C268  token=0x600149B  System.Void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand firstCommand, UnityEngine.UIElements.UIR.RenderChainCommand lastCommand)
  RVA=0x09E8A4A8  token=0x600149C  System.Void AddTextElement(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8CB1C  token=0x600149D  System.Void RemoveTextElement(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8B930  token=0x600149E  System.Void OnGroupTransformElementChangedTransform(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8A3CC  token=0x600149F  UnityEngine.UIElements.UIR.RenderChain.RenderNodeData AccessRenderNodeData(System.IntPtr obj)
  RVA=0x09E8C29C  token=0x60014A0  System.Void OnRenderNodeExecute(System.IntPtr obj)
  RVA=0x09E8BDE0  token=0x60014A1  System.Void OnRegisterIntermediateRenderers(UnityEngine.Camera camera)
  RVA=0x09E8BA64  token=0x60014A2  System.Void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel rtp, UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChain.RenderNodeData& rnd, UnityEngine.Camera camera, System.Int32 sameDistanceSortPriority)
  RVA=0x09E8CF58  token=0x60014A3  System.Void RepaintTexturedElements()
  RVA=0x03D88B20  token=0x60014A4  System.Void OnFontReset(UnityEngine.Font font)
  RVA=0x09E8A578  token=0x60014A5  System.Void AppendTexture(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture src, UnityEngine.UIElements.TextureId id, System.Boolean isAtlas)
  RVA=0x09E8D00C  token=0x60014A6  System.Void ResetTextures(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E8AD20  token=0x60014A7  System.Void DrawStats()
  RVA=0x09E8B72C  token=0x60014A8  UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement ve)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderDataDirtyTypes
TYPE:  sealed struct
TOKEN: 0x20002EC
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesNone  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesTransform  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesClipRectSize  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesClipping  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesClippingHierarchy  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesVisuals  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesVisualsHierarchy  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesOpacity  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesOpacityHierarchy  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesColor  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses
TYPE:  sealed struct
TOKEN: 0x20002ED
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesClipping  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesOpacity  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesColor  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesTransformSize  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesVisuals  // const
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesCount  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChainVEData
TYPE:  sealed struct
TOKEN: 0x20002EE
SIZE:  0x168
FIELDS:
  private           UnityEngine.UIElements.VisualElementprev  // 0x10
  private           UnityEngine.UIElements.VisualElementnext  // 0x18
  private           UnityEngine.UIElements.VisualElementgroupTransformAncestor  // 0x20
  private           UnityEngine.UIElements.VisualElementboneTransformAncestor  // 0x28
  private           UnityEngine.UIElements.VisualElementprevDirty  // 0x30
  private           UnityEngine.UIElements.VisualElementnextDirty  // 0x38
  private           System.Int32                    hierarchyDepth  // 0x40
  private           UnityEngine.UIElements.UIR.RenderDataDirtyTypesdirtiedValues  // 0x44
  private           System.UInt32                   dirtyID  // 0x48
  private           UnityEngine.UIElements.UIR.RenderChainCommandfirstCommand  // 0x50
  private           UnityEngine.UIElements.UIR.RenderChainCommandlastCommand  // 0x58
  private           UnityEngine.UIElements.UIR.RenderChainCommandfirstClosingCommand  // 0x60
  private           UnityEngine.UIElements.UIR.RenderChainCommandlastClosingCommand  // 0x68
  private           System.Boolean                  isInChain  // 0x70
  private           System.Boolean                  isHierarchyHidden  // 0x71
  private           System.Boolean                  localFlipsWinding  // 0x72
  private           System.Boolean                  localTransformScaleZero  // 0x73
  private           System.Boolean                  worldFlipsWinding  // 0x74
  private           UnityEngine.UIElements.UIR.Implementation.ClipMethodclipMethod  // 0x78
  private           System.Int32                    childrenStencilRef  // 0x7c
  private           System.Int32                    childrenMaskDepth  // 0x80
  private           System.Boolean                  disableNudging  // 0x84
  private           System.Boolean                  usesLegacyText  // 0x85
  private           UnityEngine.UIElements.UIR.MeshHandledata  // 0x88
  private           UnityEngine.UIElements.UIR.MeshHandleclosingData  // 0x90
  private           UnityEngine.Matrix4x4           verticesSpace  // 0x98
  private           System.Int32                    displacementUVStart  // 0xd8
  private           System.Int32                    displacementUVEnd  // 0xdc
  private           UnityEngine.UIElements.UIR.BMPAlloctransformID  // 0xe0
  private           UnityEngine.UIElements.UIR.BMPAllocclipRectID  // 0xe8
  private           UnityEngine.UIElements.UIR.BMPAllocopacityID  // 0xf0
  private           UnityEngine.UIElements.UIR.BMPAlloctextCoreSettingsID  // 0xf8
  private           UnityEngine.UIElements.UIR.BMPAllocbackgroundColorID  // 0x100
  private           UnityEngine.UIElements.UIR.BMPAllocborderLeftColorID  // 0x108
  private           UnityEngine.UIElements.UIR.BMPAllocborderTopColorID  // 0x110
  private           UnityEngine.UIElements.UIR.BMPAllocborderRightColorID  // 0x118
  private           UnityEngine.UIElements.UIR.BMPAllocborderBottomColorID  // 0x120
  private           UnityEngine.UIElements.UIR.BMPAlloctintColorID  // 0x128
  private           System.Single                   compositeOpacity  // 0x130
  private           UnityEngine.Color               backgroundColor  // 0x134
  private           UnityEngine.UIElements.VisualElementprevText  // 0x148
  private           UnityEngine.UIElements.VisualElementnextText  // 0x150
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChainTextEntry>textEntries  // 0x158
  private           UnityEngine.UIElements.UIR.BasicNode<UnityEngine.UIElements.UIR.TextureEntry>textures  // 0x160
PROPERTIES:
  lastClosingOrLastCommand  get=0x09E8A3BC
METHODS:
  RVA=0x09E8A30C  token=0x60014B6  System.Boolean AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E8A364  token=0x60014B7  System.Boolean InheritsID(UnityEngine.UIElements.UIR.BMPAlloc alloc)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChainTextEntry
TYPE:  sealed struct
TOKEN: 0x20002EF
SIZE:  0x20
FIELDS:
  private           UnityEngine.UIElements.UIR.RenderChainCommandcommand  // 0x10
  private           System.Int32                    firstVertex  // 0x18
  private           System.Int32                    vertexCount  // 0x1c
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextureEntry
TYPE:  sealed struct
TOKEN: 0x20002F0
SIZE:  0x20
FIELDS:
  public            UnityEngine.Texture             source  // 0x10
  public            UnityEngine.UIElements.TextureIdactual  // 0x18
  public            System.Boolean                  replaced  // 0x1c
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BaseShaderInfoStorage
TYPE:  abstract class
TOKEN: 0x20002F1
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  protected static  System.Int32                    s_TextureCounter  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerCopyTexture  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerGetTextureData  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerUpdateTexture  // static @ 0x18
  private           System.Boolean                  <disposed>k__BackingField  // 0x10
PROPERTIES:
  texture  get=-1  // abstract
  disposed  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=-1  // abstract  token=0x60014B9  System.Boolean AllocateRect(System.Int32 width, System.Int32 height, UnityEngine.RectInt& uvs)
  RVA=-1  // abstract  token=0x60014BA  System.Void SetTexel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
  RVA=-1  // abstract  token=0x60014BB  System.Void UpdateTexture()
  RVA=0x09E891C8  token=0x60014BE  System.Void Dispose()
  RVA=0x05152C08  token=0x60014BF  System.Void Dispose(System.Boolean disposing)
  RVA=0x0350B670  token=0x60014C0  System.Void .ctor()
  RVA=0x09E89218  token=0x60014C1  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ShaderInfoStorage`1
TYPE:  class
TOKEN: 0x20002F2
EXTENDS: UnityEngine.UIElements.UIR.BaseShaderInfoStorage
FIELDS:
  private   readonly System.Int32                    m_InitialSize  // 0x0
  private   readonly System.Int32                    m_MaxSize  // 0x0
  private   readonly UnityEngine.TextureFormat       m_Format  // 0x0
  private   readonly System.Func<UnityEngine.Color,T>m_Convert  // 0x0
  private           UnityEngine.UIElements.UIRAtlasAllocatorm_Allocator  // 0x0
  private           UnityEngine.Texture2D           m_Texture  // 0x0
  private           Unity.Collections.NativeArray<T>m_Texels  // 0x0
PROPERTIES:
  texture  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60014C2  System.Void .ctor(UnityEngine.TextureFormat format, System.Func<UnityEngine.Color,T> convert, System.Int32 initialSize, System.Int32 maxSize)
  RVA=-1  // not resolved  token=0x60014C3  System.Void Dispose(System.Boolean disposing)
  RVA=-1  // not resolved  token=0x60014C5  System.Boolean AllocateRect(System.Int32 width, System.Int32 height, UnityEngine.RectInt& uvs)
  RVA=-1  // not resolved  token=0x60014C6  System.Void SetTexel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
  RVA=-1  // not resolved  token=0x60014C7  System.Void UpdateTexture()
  RVA=-1  // not resolved  token=0x60014C8  System.Void CreateOrExpandTexture()
  RVA=-1  // not resolved  token=0x60014C9  System.Void CpuBlit(Unity.Collections.NativeArray<T> src, System.Int32 srcWidth, System.Int32 srcHeight, Unity.Collections.NativeArray<T> dst, System.Int32 dstWidth, System.Int32 dstHeight)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32
TYPE:  class
TOKEN: 0x20002F3
SIZE:  0x50
EXTENDS: UnityEngine.UIElements.UIR.ShaderInfoStorage`1
FIELDS:
  private   static readonly System.Func<UnityEngine.Color,UnityEngine.Color32>s_Convert  // static @ 0x0
METHODS:
  RVA=0x09E8E1DC  token=0x60014CA  System.Void .ctor(System.Int32 initialSize, System.Int32 maxSize)
  RVA=0x09E8E118  token=0x60014CB  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat
TYPE:  class
TOKEN: 0x20002F5
SIZE:  0x50
EXTENDS: UnityEngine.UIElements.UIR.ShaderInfoStorage`1
FIELDS:
  private   static readonly System.Func<UnityEngine.Color,UnityEngine.Color>s_Convert  // static @ 0x0
METHODS:
  RVA=0x09E8E32C  token=0x60014CF  System.Void .ctor(System.Int32 initialSize, System.Int32 maxSize)
  RVA=0x09E8E268  token=0x60014D0  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Shaders
TYPE:  static class
TOKEN: 0x20002F7
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   k_AtlasBlit  // static @ 0x0
  public    static readonly System.String                   k_Editor  // static @ 0x8
  public    static readonly System.String                   k_Runtime  // static @ 0x10
  public    static readonly System.String                   k_RuntimeWorld  // static @ 0x18
  public    static readonly System.String                   k_GraphView  // static @ 0x20
METHODS:
  RVA=0x09E8E3B8  token=0x60014D4  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Tessellation
TYPE:  static class
TOKEN: 0x20002F8
SIZE:  0x10
FIELDS:
  private   static  System.Single                   kEpsilon  // static @ 0x0
  private   static  System.Single                   kUnusedArc  // static @ 0x4
  private   static  System.UInt16                   kSubdivisions  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTessellateRect  // static @ 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTessellateBorder  // static @ 0x18
  private   static  UnityEngine.UIElements.UIR.Tessellation.Edges[]s_AllEdges  // static @ 0x20
METHODS:
  RVA=0x09E92774  token=0x60014D5  System.Void TessellateRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Boolean computeUVs)
  RVA=0x09E91320  token=0x60014D6  System.Void TessellateQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09E8F324  token=0x60014D7  System.Void TessellateBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  RVA=0x09E93CA4  token=0x60014D8  System.Void TessellateRoundedCorners(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E93494  token=0x60014D9  System.Void TessellateRoundedBorders(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams& border, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E939C0  token=0x60014DA  System.Void TessellateRoundedCorner(UnityEngine.Rect rect, UnityEngine.Color32 color, System.Single posZ, UnityEngine.Vector2 radius, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E92DB0  token=0x60014DB  System.Void TessellateRoundedBorder(UnityEngine.Rect rect, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.Vector2 radius, System.Single leftWidth, System.Single topWidth, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E8EFE4  token=0x60014DC  UnityEngine.Vector2 IntersectLines(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3)
  RVA=0x09E8F0D8  token=0x60014DD  System.Int32 LooseCompare(System.Single a, System.Single b)
  RVA=0x09E8FD98  token=0x60014DE  System.Void TessellateComplexBorderCorner(UnityEngine.Rect rect, UnityEngine.Vector2 radius, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E9238C  token=0x60014DF  System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E917F0  token=0x60014E0  System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E8E998  token=0x60014E1  System.Int32 EdgesCount(UnityEngine.UIElements.UIR.Tessellation.Edges edges)
  RVA=0x09E918BC  token=0x60014E2  System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Vector2* offsets, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E8E9C8  token=0x60014E3  System.Void EncodeStraightArc(UnityEngine.UIElements.Vertex& v0, UnityEngine.UIElements.Vertex& v1, UnityEngine.UIElements.Vertex& center, System.Single radius)
  RVA=0x09E8EBB8  token=0x60014E4  System.Void ExpandTriangle(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3 center, System.Single factor)
  RVA=0x09E90CB4  token=0x60014E5  System.Void TessellateQuadSingleEdge(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E940B4  token=0x60014E6  System.Void TessellateStraightBorder(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, System.Single miterOffset, UnityEngine.Color color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E8EE1C  token=0x60014E7  UnityEngine.Vector4 GetInterpolatedCircle(UnityEngine.Vector2 p, UnityEngine.UIElements.Vertex& v0, UnityEngine.UIElements.Vertex& v1, UnityEngine.UIElements.Vertex& v2)
  RVA=0x09E8E62C  token=0x60014E8  System.Void ComputeBarycentricCoordinates(UnityEngine.Vector2 p, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, System.Single& u, System.Single& v, System.Single& w)
  RVA=0x09E9043C  token=0x60014E9  System.Void TessellateFilledFan(UnityEngine.Vector2 center, UnityEngine.Vector2 radius, UnityEngine.Vector2 miterOffset, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E8F8C0  token=0x60014EA  System.Void TessellateBorderedFan(UnityEngine.Vector2 center, UnityEngine.Vector2 outerRadius, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  RVA=0x09E8F168  token=0x60014EB  System.Void MirrorVertices(UnityEngine.Rect rect, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, System.Int32 vertexStart, System.Int32 vertexCount, System.Boolean flipHorizontal)
  RVA=0x09E8ED58  token=0x60014EC  System.Void FlipWinding(Unity.Collections.NativeSlice<System.UInt16> indices, System.Int32 indexStart, System.Int32 indexCount)
  RVA=0x09E8E7B0  token=0x60014ED  System.Void ComputeUVs(UnityEngine.Rect tessellatedRect, UnityEngine.Rect textureRect, UnityEngine.Rect uvRegion, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices)
  RVA=0x09E94DA8  token=0x60014EE  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextCoreSettings
TYPE:  sealed struct
TOKEN: 0x20002FA
SIZE:  0x50
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            UnityEngine.Color               faceColor  // 0x10
  public            UnityEngine.Color               outlineColor  // 0x20
  public            System.Single                   outlineWidth  // 0x30
  public            UnityEngine.Color               underlayColor  // 0x34
  public            UnityEngine.Vector2             underlayOffset  // 0x44
  public            System.Single                   underlaySoftness  // 0x4c
METHODS:
  RVA=0x09E94F0C  token=0x60014EF  System.Boolean Equals(System.Object obj)
  RVA=0x09E94FA0  token=0x60014F0  System.Boolean Equals(UnityEngine.UIElements.UIR.TextCoreSettings other)
  RVA=0x09E950BC  token=0x60014F1  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextureBlitter
TYPE:  class
TOKEN: 0x20002FB
SIZE:  0x50
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly System.Int32[]                  k_TextureIds  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_CommitSampler  // static @ 0x8
  private           UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo[]m_SingleBlit  // 0x10
  private           UnityEngine.Material            m_BlitMaterial  // 0x18
  private           UnityEngine.MaterialPropertyBlockm_Properties  // 0x20
  private           UnityEngine.RectInt             m_Viewport  // 0x28
  private           UnityEngine.RenderTexture       m_PrevRT  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo>m_PendingBlits  // 0x40
  private           System.Boolean                  <disposed>k__BackingField  // 0x48
PROPERTIES:
  disposed  get=0x03D4EFE0  set=0x03D4F010
METHODS:
  RVA=0x09E9551C  token=0x60014F4  System.Void Dispose()
  RVA=0x09E9556C  token=0x60014F5  System.Void Dispose(System.Boolean disposing)
  RVA=0x09E95C1C  token=0x60014F6  System.Void .cctor()
  RVA=0x09E95D3C  token=0x60014F7  System.Void .ctor(System.Int32 capacity)
  RVA=0x09E95B1C  token=0x60014F8  System.Void QueueBlit(UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, System.Boolean addBorder, UnityEngine.Color tint)
  RVA=0x09E9536C  token=0x60014F9  System.Void BlitOneNow(UnityEngine.RenderTexture dst, UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, System.Boolean addBorder, UnityEngine.Color tint)
  RVA=0x09E95460  token=0x60014FA  System.Void Commit(UnityEngine.RenderTexture dst)
  RVA=0x09E95164  token=0x60014FB  System.Void BeginBlit(UnityEngine.RenderTexture dst)
  RVA=0x09E955D8  token=0x60014FC  System.Void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, System.Int32 startIndex)
  RVA=0x09E95A80  token=0x60014FD  System.Void EndBlit()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextureSlotManager
TYPE:  class
TOKEN: 0x20002FD
SIZE:  0x40
FIELDS:
  private   static readonly System.Int32                    k_SlotCount  // static @ 0x0
  private   static readonly System.Int32[]                  slotIds  // static @ 0x8
  private   static readonly System.Int32                    textureTableId  // static @ 0x10
  private           UnityEngine.UIElements.TextureId[]m_Textures  // 0x10
  private           System.Int32[]                  m_Tickets  // 0x18
  private           System.Int32                    m_CurrentTicket  // 0x20
  private           System.Int32                    m_FirstUsedTicket  // 0x24
  private           UnityEngine.Vector4[]           m_GpuTextures  // 0x28
  private           System.Int32                    <FreeSlots>k__BackingField  // 0x30
  private           UnityEngine.UIElements.TextureRegistrytextureRegistry  // 0x38
PROPERTIES:
  FreeSlots  get=0x03D4ED20  set=0x03D4EE10
METHODS:
  RVA=0x09E96284  token=0x60014FE  System.Void .cctor()
  RVA=0x09E963EC  token=0x60014FF  System.Void .ctor()
  RVA=0x09E96130  token=0x6001500  System.Void Reset()
  RVA=0x09E9622C  token=0x6001501  System.Void StartNewBatch()
  RVA=0x09E96080  token=0x6001502  System.Int32 IndexOf(UnityEngine.UIElements.TextureId id)
  RVA=0x09E88FFC  token=0x6001503  System.Void MarkUsed(System.Int32 slotIndex)
  RVA=0x09E95FCC  token=0x6001506  System.Int32 FindOldestSlot()
  RVA=0x09E95DEC  token=0x6001507  System.Void Bind(UnityEngine.UIElements.TextureId id, System.Int32 slot, UnityEngine.MaterialPropertyBlock mat)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VectorImageRenderInfoPool
TYPE:  class
TOKEN: 0x20002FE
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.UIR.LinkedPool`1
FIELDS:
METHODS:
  RVA=0x09E9922C  token=0x6001508  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VectorImageRenderInfo
TYPE:  class
TOKEN: 0x2000300
SIZE:  0x40
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  public            System.Int32                    useCount  // 0x18
  public            UnityEngine.UIElements.UIR.GradientRemapfirstGradientRemap  // 0x20
  public            UnityEngine.UIElements.UIR.AllocgradientSettingsAlloc  // 0x28
METHODS:
  RVA=0x09E993F0  token=0x600150D  System.Void Reset()
  RVA=0x09E9941C  token=0x600150E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GradientRemapPool
TYPE:  class
TOKEN: 0x2000301
SIZE:  0x38
EXTENDS: UnityEngine.UIElements.UIR.LinkedPool`1
FIELDS:
METHODS:
  RVA=0x09E89E48  token=0x600150F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GradientRemap
TYPE:  class
TOKEN: 0x2000303
SIZE:  0x40
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  public            System.Int32                    origIndex  // 0x18
  public            System.Int32                    destIndex  // 0x1c
  public            UnityEngine.RectInt             location  // 0x20
  public            UnityEngine.UIElements.UIR.GradientRemapnext  // 0x30
  public            UnityEngine.UIElements.TextureIdatlas  // 0x38
METHODS:
  RVA=0x09E8A00C  token=0x6001514  System.Void Reset()
  RVA=0x09E8A068  token=0x6001515  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VectorImageManager
TYPE:  class
TOKEN: 0x2000304
SIZE:  0x40
IMPLEMENTS: System.IDisposable
FIELDS:
  public    static  System.Collections.Generic.List<UnityEngine.UIElements.UIR.VectorImageManager>instances  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerRegister  // static @ 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerUnregister  // static @ 0x10
  private   readonly UnityEngine.UIElements.AtlasBasem_Atlas  // 0x10
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo>m_Registered  // 0x18
  private           UnityEngine.UIElements.UIR.VectorImageRenderInfoPoolm_RenderInfoPool  // 0x20
  private           UnityEngine.UIElements.UIR.GradientRemapPoolm_GradientRemapPool  // 0x28
  private           UnityEngine.UIElements.UIR.GradientSettingsAtlasm_GradientSettingsAtlas  // 0x30
  private           System.Boolean                  m_LoggedExhaustedSettingsAtlas  // 0x38
  private           System.Boolean                  <disposed>k__BackingField  // 0x39
PROPERTIES:
  atlas  get=0x09E99218
  disposed  get=0x03D4F300  set=0x03D4F330
METHODS:
  RVA=0x09E99090  token=0x6001517  System.Void .ctor(UnityEngine.UIElements.AtlasBase atlas)
  RVA=0x09E98B64  token=0x600151A  System.Void Dispose()
  RVA=0x09E98A5C  token=0x600151B  System.Void Dispose(System.Boolean disposing)
  RVA=0x09E98A28  token=0x600151C  System.Void Commit()
  RVA=0x09E9893C  token=0x600151D  UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context)
  RVA=0x09E98BB4  token=0x600151E  UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context)
  RVA=0x09E98F88  token=0x600151F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.OwnedState
TYPE:  sealed struct
TOKEN: 0x2000305
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.OwnedStateInherited  // const
  public    static  UnityEngine.UIElements.UIR.OwnedStateOwned  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BMPAlloc
TYPE:  sealed struct
TOKEN: 0x2000306
SIZE:  0x18
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocInvalid  // static @ 0x0
  public            System.Int32                    page  // 0x10
  public            System.UInt16                   pageLine  // 0x14
  public            System.Byte                     bitIndex  // 0x16
  public            UnityEngine.UIElements.UIR.OwnedStateownedState  // 0x17
METHODS:
  RVA=0x09E89084  token=0x6001520  System.Boolean Equals(UnityEngine.UIElements.UIR.BMPAlloc other)
  RVA=0x09E890A4  token=0x6001521  System.Boolean IsValid()
  RVA=0x09E890B0  token=0x6001522  System.String ToString()
  RVA=0x09E8917C  token=0x6001523  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BitmapAllocator32
TYPE:  sealed struct
TOKEN: 0x2000307
SIZE:  0x30
FIELDS:
  private           System.Int32                    m_PageHeight  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.BitmapAllocator32.Page>m_Pages  // 0x18
  private           System.Collections.Generic.List<System.UInt32>m_AllocMap  // 0x20
  private           System.Int32                    m_EntryWidth  // 0x28
  private           System.Int32                    m_EntryHeight  // 0x2c
PROPERTIES:
  entryWidth  get=0x03D68AE0
  entryHeight  get=0x03D66B90
METHODS:
  RVA=0x09E895E4  token=0x6001524  System.Void Construct(System.Int32 pageHeight, System.Int32 entryWidth, System.Int32 entryHeight)
  RVA=0x09E89740  token=0x6001525  System.Void ForceFirstAlloc(System.UInt16 firstPageX, System.UInt16 firstPageY)
  RVA=0x09E892EC  token=0x6001526  UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage storage)
  RVA=0x09E89810  token=0x6001527  System.Void Free(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E89940  token=0x600152A  System.Void GetAllocPageAtlasLocation(System.Int32 page, System.UInt16& x, System.UInt16& y)
  RVA=0x09E89704  token=0x600152B  System.Byte CountTrailingZeroes(System.UInt32 val)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator
TYPE:  sealed struct
TOKEN: 0x2000309
SIZE:  0xE0
FIELDS:
  private           UnityEngine.UIElements.UIR.BaseShaderInfoStoragem_Storage  // 0x10
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_TransformAllocator  // 0x18
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_ClipRectAllocator  // 0x38
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_OpacityAllocator  // 0x58
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_ColorAllocator  // 0x78
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_TextSettingsAllocator  // 0x98
  private           System.Boolean                  m_StorageReallyCreated  // 0xb8
  private           System.Boolean                  m_VertexTexturingEnabled  // 0xb9
  private           Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.Transform3x4>m_Transforms  // 0xc0
  private           Unity.Collections.NativeArray<UnityEngine.Vector4>m_ClipRects  // 0xd0
  private   static readonly UnityEngine.Vector2Int          identityTransformTexel  // static @ 0x0
  private   static readonly UnityEngine.Vector2Int          infiniteClipRectTexel  // static @ 0x8
  private   static readonly UnityEngine.Vector2Int          fullOpacityTexel  // static @ 0x10
  private   static readonly UnityEngine.Vector2Int          clearColorTexel  // static @ 0x18
  private   static readonly UnityEngine.Vector2Int          defaultTextCoreSettingsTexel  // static @ 0x20
  private   static readonly UnityEngine.Matrix4x4           identityTransformValue  // static @ 0x28
  private   static readonly UnityEngine.Vector4             identityTransformRow0Value  // static @ 0x68
  private   static readonly UnityEngine.Vector4             identityTransformRow1Value  // static @ 0x78
  private   static readonly UnityEngine.Vector4             identityTransformRow2Value  // static @ 0x88
  private   static readonly UnityEngine.Vector4             infiniteClipRectValue  // static @ 0x98
  private   static readonly UnityEngine.Vector4             fullOpacityValue  // static @ 0xa8
  private   static readonly UnityEngine.Vector4             clearColorValue  // static @ 0xb8
  private   static readonly UnityEngine.UIElements.UIR.TextCoreSettingsdefaultTextCoreSettingsValue  // static @ 0xc8
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocidentityTransform  // static @ 0x108
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocinfiniteClipRect  // static @ 0x110
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocfullOpacity  // static @ 0x118
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocclearColor  // static @ 0x120
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocdefaultTextCoreSettings  // static @ 0x128
PROPERTIES:
  pageWidth  get=0x03D88B80
  pageHeight  get=0x03D88B70
  transformConstants  get=0x09E988D0
  clipRectConstants  get=0x09E98864
  atlas  get=0x09E987E4
METHODS:
  RVA=0x09E96A78  token=0x600152E  UnityEngine.Vector2Int AllocToTexelCoord(UnityEngine.UIElements.UIR.BitmapAllocator32& allocator, UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E96A28  token=0x600152F  System.Int32 AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E96BAC  token=0x6001530  System.Boolean AtlasRectMatchesPage(UnityEngine.UIElements.UIR.BitmapAllocator32& allocator, UnityEngine.UIElements.UIR.BMPAlloc defAlloc, UnityEngine.RectInt atlasRect)
  RVA=0x09E96E34  token=0x6001534  System.Void Construct()
  RVA=0x09E97560  token=0x6001535  System.Void ReallyCreateStorage()
  RVA=0x09E97134  token=0x6001536  System.Void Dispose()
  RVA=0x09E97478  token=0x6001537  System.Void IssuePendingStorageChanges()
  RVA=0x09E96AD8  token=0x6001538  UnityEngine.UIElements.UIR.BMPAlloc AllocTransform()
  RVA=0x09E96848  token=0x6001539  UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect()
  RVA=0x09E96974  token=0x600153A  UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity()
  RVA=0x09E9691C  token=0x600153B  UnityEngine.UIElements.UIR.BMPAlloc AllocColor()
  RVA=0x09E969CC  token=0x600153C  UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings settings)
  RVA=0x09E98154  token=0x600153D  System.Void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Matrix4x4 xform)
  RVA=0x09E97B84  token=0x600153E  System.Void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Vector4 clipRect)
  RVA=0x09E97DBC  token=0x600153F  System.Void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, System.Single opacity)
  RVA=0x09E97CAC  token=0x6001540  System.Void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Color color, System.Boolean isEditorContext)
  RVA=0x09E97EB8  token=0x6001541  System.Void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.UIElements.UIR.TextCoreSettings settings, System.Boolean isEditorContext)
  RVA=0x09E973F4  token=0x6001542  System.Void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E971E0  token=0x6001543  System.Void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E972E8  token=0x6001544  System.Void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E97264  token=0x6001545  System.Void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E9736C  token=0x6001546  System.Void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E98480  token=0x6001547  UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E96C70  token=0x6001548  UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E9748C  token=0x6001549  UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E96D60  token=0x600154A  UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E983A8  token=0x600154B  UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  RVA=0x09E98570  token=0x600154C  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Transform3x4
TYPE:  sealed struct
TOKEN: 0x200030A
SIZE:  0x40
FIELDS:
  public            UnityEngine.Vector4             v0  // 0x10
  public            UnityEngine.Vector4             v1  // 0x20
  public            UnityEngine.Vector4             v2  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.MeshHandle
TYPE:  class
TOKEN: 0x200030B
SIZE:  0x60
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  private           UnityEngine.UIElements.UIR.AllocallocVerts  // 0x18
  private           UnityEngine.UIElements.UIR.AllocallocIndices  // 0x30
  private           System.UInt32                   triangleCount  // 0x48
  private           UnityEngine.UIElements.UIR.Page allocPage  // 0x50
  private           System.UInt32                   allocTime  // 0x58
  private           System.UInt32                   updateAllocID  // 0x5c
METHODS:
  RVA=0x09E9E3B8  token=0x600154D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.UIRenderDevice
TYPE:  class
TOKEN: 0x200030C
SIZE:  0xB0
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly System.Boolean                  m_MockDevice  // 0x10
  private           System.IntPtr                   m_DefaultStencilState  // 0x18
  private           System.IntPtr                   m_VertexDecl  // 0x20
  private           UnityEngine.UIElements.UIR.Page m_FirstPage  // 0x28
  private           System.UInt32                   m_NextPageVertexCount  // 0x30
  private           System.UInt32                   m_LargeMeshVertexCount  // 0x34
  private           System.Single                   m_IndexToVertexCountRatio  // 0x38
  private           System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToFree>>m_DeferredFrees  // 0x40
  private           System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate>>m_Updates  // 0x48
  private           System.UInt32[]                 m_Fences  // 0x50
  private           UnityEngine.MaterialPropertyBlockm_StandardMatProps  // 0x58
  private           System.UInt32                   m_FrameIndex  // 0x60
  private           System.UInt32                   m_NextUpdateID  // 0x64
  private           UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatisticsm_DrawStats  // 0x68
  private   readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.MeshHandle>m_MeshHandles  // 0x90
  private   readonly UnityEngine.UIElements.UIR.DrawParamsm_DrawParams  // 0x98
  private   readonly UnityEngine.UIElements.UIR.TextureSlotManagerm_TextureSlotManager  // 0xa0
  private   static  System.Collections.Generic.LinkedList<UnityEngine.UIElements.UIR.UIRenderDevice.DeviceToFree>m_DeviceFreeQueue  // static @ 0x0
  private   static  System.Int32                    m_ActiveDeviceCount  // static @ 0x8
  private   static  System.Boolean                  m_SubscribedToNotifications  // static @ 0xc
  private   static  System.Boolean                  m_SynchronousFree  // static @ 0xd
  private   static readonly System.Int32                    s_FontTexPropID  // static @ 0x10
  private   static readonly System.Int32                    s_FontTexSDFScaleID  // static @ 0x14
  private   static readonly System.Int32                    s_GradientSettingsTexID  // static @ 0x18
  private   static readonly System.Int32                    s_ShaderInfoTexID  // static @ 0x1c
  private   static readonly System.Int32                    s_TransformsPropID  // static @ 0x20
  private   static readonly System.Int32                    s_ClipRectsPropID  // static @ 0x24
  private   static readonly System.Int32                    s_ClipSpaceParamsID  // static @ 0x28
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerAllocate  // static @ 0x30
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerFree  // static @ 0x38
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerAdvanceFrame  // static @ 0x40
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerFence  // static @ 0x48
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerBeforeDraw  // static @ 0x50
  private   static  System.Nullable<System.Boolean> s_VertexTexturingIsAvailable  // static @ 0x58
  private   static  System.Nullable<System.Boolean> s_ShaderModelIs35  // static @ 0x5a
  private   readonly System.UInt32                   <maxVerticesPerPage>k__BackingField  // 0xa8
  private           System.Boolean                  <breakBatches>k__BackingField  // 0xac
  private   static  UnityEngine.Texture2D           s_DefaultShaderInfoTexFloat  // static @ 0x60
  private   static  UnityEngine.Texture2D           s_DefaultShaderInfoTexARGB8  // static @ 0x68
  private           System.Boolean                  <disposed>k__BackingField  // 0xad
PROPERTIES:
  maxVerticesPerPage  get=0x03D51860
  breakBatches  get=0x03D5B640  set=0x03D5B670
  defaultShaderInfoTexFloat  get=0x09EA790C
  defaultShaderInfoTexARGB8  get=0x09EA7550
  vertexTexturingIsAvailable  get=0x09EA801C
  shaderModelIs35  get=0x09EA7E80
  fullyCreated  get=0x02B84230
  disposed  get=0x03D56770  set=0x03D88BC0
METHODS:
  RVA=0x09EA6C4C  token=0x6001551  System.Void .cctor()
  RVA=0x09EA7534  token=0x6001552  System.Void .ctor(System.UInt32 initialVertexCapacity, System.UInt32 initialIndexCapacity)
  RVA=0x09EA6FCC  token=0x6001553  System.Void .ctor(System.UInt32 initialVertexCapacity, System.UInt32 initialIndexCapacity, System.Boolean mockDevice)
  RVA=0x09EA537C  token=0x6001558  System.Void InitVertexDeclaration()
  RVA=0x09EA3E88  token=0x6001559  System.Void CompleteCreation()
  RVA=0x09EA40F0  token=0x600155D  System.Void Dispose()
  RVA=0x09EA3FA4  token=0x600155E  System.Void Dispose(System.Boolean disposing)
  RVA=0x09EA33B0  token=0x600155F  UnityEngine.UIElements.UIR.MeshHandle Allocate(System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset)
  RVA=0x09EA67C0  token=0x6001560  System.Void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData)
  RVA=0x09EA69BC  token=0x6001561  System.Void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset)
  RVA=0x09EA661C  token=0x6001562  System.Void UpdateCopyBackIndices(UnityEngine.UIElements.UIR.MeshHandle mesh, System.Boolean copyBackIndices)
  RVA=0x09EA27C0  token=0x6001563  System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(UnityEngine.UIElements.UIR.MeshHandle mesh)
  RVA=0x09EA5E88  token=0x6001564  System.Boolean TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.Alloc& va, UnityEngine.UIElements.UIR.Alloc& ia, System.Boolean shortLived)
  RVA=0x09EA3478  token=0x6001565  System.Void Allocate(UnityEngine.UIElements.UIR.MeshHandle meshHandle, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.Boolean shortLived)
  RVA=0x09EA5FBC  token=0x6001566  System.Void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset, UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate& allocToUpdate, System.Boolean copyBackIndices)
  RVA=0x09EA4CBC  token=0x6001567  System.Void Free(UnityEngine.UIElements.UIR.MeshHandle mesh)
  RVA=0x09EA52C0  token=0x6001568  UnityEngine.Vector4 GetClipSpaceParams()
  RVA=0x09EA57F8  token=0x6001569  System.Void OnFrameRenderingBegin()
  RVA=-1  // generic def  token=0x600156A  Unity.Collections.NativeSlice<T> PtrToSlice(System.Void* p, System.Int32 count)
  RVA=0x09EA3CC4  token=0x600156B  System.Void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand cmd, System.Int32 textureSlot, UnityEngine.Material newMat, System.Boolean newMatDiffers, System.Boolean newFontDiffers, UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState& st)
  RVA=0x09EA3B7C  token=0x600156C  System.Void ApplyBatchState(UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState& st, System.Boolean allowMaterialChange)
  RVA=0x09EA4140  token=0x600156D  System.Void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand head, UnityEngine.Material initialMat, UnityEngine.Material defaultMat, UnityEngine.Texture gradientSettings, UnityEngine.Texture shaderInfo, System.Single pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, UnityEngine.MaterialPropertyBlock stateMatProps, System.Boolean allowMaterialChange, System.Exception& immediateException)
  RVA=0x09EA6710  token=0x600156E  System.Void UpdateFenceValue()
  RVA=0x09EA5510  token=0x600156F  System.Void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange* ranges, System.Int32& rangesReady, System.Int32& rangesStart, System.Int32 rangesCount, UnityEngine.UIElements.UIR.Page curPage)
  RVA=-1  // generic def  token=0x6001570  System.Void DrawRanges(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges)
  RVA=0x09EA6B9C  token=0x6001571  System.Void WaitOnCpuFence(System.UInt32 fence)
  RVA=0x09EA2830  token=0x6001572  System.Void AdvanceFrame()
  RVA=0x09EA5D94  token=0x6001573  System.Void PruneUnusedPages()
  RVA=0x09EA5894  token=0x6001574  System.Void PrepareForGfxDeviceRecreate()
  RVA=0x09EA6BF8  token=0x6001575  System.Void WrapUpGfxDeviceRecreate()
  RVA=0x09EA4C64  token=0x6001576  System.Void FlushAllPendingDeviceDisposes()
  RVA=0x03D88BA0  token=0x6001577  UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics GatherDrawStatistics()
  RVA=0x09EA5A1C  token=0x6001578  System.Void ProcessDeviceFreeQueue()
  RVA=0x09EA5760  token=0x6001579  System.Void OnEngineUpdateGlobal()
  RVA=0x09EA57A0  token=0x600157A  System.Void OnFlushPendingResources()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Alloc
TYPE:  sealed struct
TOKEN: 0x2000313
SIZE:  0x28
FIELDS:
  public            System.UInt32                   start  // 0x10
  public            System.UInt32                   size  // 0x14
  private           System.Object                   handle  // 0x18
  private           System.Boolean                  shortLived  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BestFitAllocator
TYPE:  class
TOKEN: 0x2000314
SIZE:  0x38
FIELDS:
  private   readonly System.UInt32                   <totalSize>k__BackingField  // 0x10
  private           UnityEngine.UIElements.UIR.BestFitAllocator.Blockm_FirstBlock  // 0x18
  private           UnityEngine.UIElements.UIR.BestFitAllocator.Blockm_FirstAvailableBlock  // 0x20
  private           UnityEngine.UIElements.UIR.BestFitAllocator.BlockPoolm_BlockPool  // 0x28
  private           System.UInt32                   m_HighWatermark  // 0x30
PROPERTIES:
  totalSize  get=0x03D4E340
  highWatermark  get=0x03D85A80
METHODS:
  RVA=0x09E99D44  token=0x6001580  System.Void .ctor(System.UInt32 size)
  RVA=0x09E996BC  token=0x6001583  UnityEngine.UIElements.UIR.Alloc Allocate(System.UInt32 size)
  RVA=0x09E999EC  token=0x6001584  System.Void Free(UnityEngine.UIElements.UIR.Alloc alloc)
  RVA=0x09E998BC  token=0x6001585  UnityEngine.UIElements.UIR.BestFitAllocator.Block CoalesceBlockWithPrevious(UnityEngine.UIElements.UIR.BestFitAllocator.Block block)
  RVA=0x09E99880  token=0x6001586  UnityEngine.UIElements.UIR.BestFitAllocator.Block BestFitFindAvailableBlock(System.UInt32 size)
  RVA=0x09E99BEC  token=0x6001587  System.Void SplitBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block, System.UInt32 size)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GPUBufferAllocator
TYPE:  class
TOKEN: 0x2000317
SIZE:  0x20
FIELDS:
  private           UnityEngine.UIElements.UIR.BestFitAllocatorm_Low  // 0x10
  private           UnityEngine.UIElements.UIR.BestFitAllocatorm_High  // 0x18
PROPERTIES:
  isEmpty  get=0x09E9E388
METHODS:
  RVA=0x09E9E2E4  token=0x600158D  System.Void .ctor(System.UInt32 maxSize)
  RVA=0x09E9E118  token=0x600158E  UnityEngine.UIElements.UIR.Alloc Allocate(System.UInt32 size, System.Boolean shortLived)
  RVA=0x09E9E234  token=0x600158F  System.Void Free(UnityEngine.UIElements.UIR.Alloc alloc)
  RVA=0x09E9E2B0  token=0x6001591  System.Boolean HighLowCollide()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Page
TYPE:  class
TOKEN: 0x2000318
SIZE:  0x38
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Boolean                  <disposed>k__BackingField  // 0x10
  public            UnityEngine.UIElements.UIR.Page.DataSet<UnityEngine.UIElements.Vertex>vertices  // 0x18
  public            UnityEngine.UIElements.UIR.Page.DataSet<System.UInt16>indices  // 0x20
  public            UnityEngine.UIElements.UIR.Page next  // 0x28
  public            System.Int32                    framesEmpty  // 0x30
PROPERTIES:
  disposed  get=0x011797F0  set=0x03D4E960
  isEmpty  get=0x09E9E5FC
METHODS:
  RVA=0x09E9E4B4  token=0x6001592  System.Void .ctor(System.UInt32 vertexMaxCount, System.UInt32 indexMaxCount, System.UInt32 maxQueuedFrameCount, System.Boolean mockPage)
  RVA=0x09E9E464  token=0x6001595  System.Void Dispose()
  RVA=0x09E9E3E0  token=0x6001596  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VertexFlags
TYPE:  sealed struct
TOKEN: 0x200031A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsSolid  // const
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsText  // const
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsTextured  // const
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsDynamic  // const
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsSvgGradients  // const
  public    static  UnityEngine.UIElements.UIR.VertexFlagsLastType  // const
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsGraphViewEdge  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.State
TYPE:  sealed struct
TOKEN: 0x200031B
SIZE:  0x30
FIELDS:
  public            UnityEngine.Material            material  // 0x10
  public            UnityEngine.Texture             font  // 0x18
  public            System.Single                   fontTexSDFScale  // 0x20
  public            UnityEngine.UIElements.TextureIdtexture  // 0x24
  public            System.Int32                    stencilRef  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.CommandType
TYPE:  sealed struct
TOKEN: 0x200031C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.CommandTypeDraw  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypeImmediateCull  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypeImmediate  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePushView  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePopView  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePushScissor  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePopScissor  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePushRenderTexture  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePopRenderTexture  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypeBlitToPreviousRT  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePushDefaultMaterial  // const
  public    static  UnityEngine.UIElements.UIR.CommandTypePopDefaultMaterial  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.DrawParams
TYPE:  class
TOKEN: 0x200031D
SIZE:  0x30
FIELDS:
  private   static readonly UnityEngine.Rect                k_UnlimitedRect  // static @ 0x0
  private   static readonly UnityEngine.Rect                k_FullNormalizedRect  // static @ 0x10
  private   readonly System.Collections.Generic.Stack<UnityEngine.Matrix4x4>view  // 0x10
  private   readonly System.Collections.Generic.Stack<UnityEngine.Rect>scissor  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.RenderTexture>renderTexture  // 0x20
  private   readonly System.Collections.Generic.List<UnityEngine.Material>defaultMaterial  // 0x28
METHODS:
  RVA=0x09E9DDFC  token=0x60015A3  System.Void Reset()
  RVA=0x09E9DFAC  token=0x60015A4  System.Void .ctor()
  RVA=0x09E9DF54  token=0x60015A5  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChainCommand
TYPE:  class
TOKEN: 0x200031E
SIZE:  0x70
EXTENDS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
FIELDS:
  private           UnityEngine.UIElements.VisualElementowner  // 0x18
  private           UnityEngine.UIElements.UIR.RenderChainCommandprev  // 0x20
  private           UnityEngine.UIElements.UIR.RenderChainCommandnext  // 0x28
  private           System.Boolean                  closing  // 0x30
  private           UnityEngine.UIElements.UIR.CommandTypetype  // 0x34
  private           UnityEngine.UIElements.UIR.Statestate  // 0x38
  private           UnityEngine.UIElements.UIR.MeshHandlemesh  // 0x58
  private           System.Int32                    indexOffset  // 0x60
  private           System.Int32                    indexCount  // 0x64
  private           System.Action                   callback  // 0x68
  private   static readonly System.Int32                    k_ID_MainTex  // static @ 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_ImmediateOverheadMarker  // static @ 0x8
METHODS:
  RVA=0x09E9F630  token=0x60015A6  System.Void Reset()
  RVA=0x09E9E8D8  token=0x60015A7  System.Void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams drawParams, System.Single pixelsPerPoint, System.Exception& immediateException)
  RVA=0x09E9E658  token=0x60015A8  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture destination, System.Single depth)
  RVA=0x09E9E7C8  token=0x60015A9  UnityEngine.Rect CombineScissorRects(UnityEngine.Rect r0, UnityEngine.Rect r1)
  RVA=0x09E9F558  token=0x60015AA  UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect rect, System.Single pixelsPerPoint)
  RVA=0x09E9F724  token=0x60015AB  System.Void .ctor()
  RVA=0x09E9F698  token=0x60015AC  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.CommandGenerator
TYPE:  static class
TOKEN: 0x200031F
SIZE:  0x10
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_ConvertEntriesToCommandsMarker  // static @ 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_NudgeVerticesMarker  // static @ 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  k_ComputeTransformMatrixMarker  // static @ 0x10
  private   static  UnityEngine.Material            s_blitMaterial_LinearToGamma  // static @ 0x18
  private   static  UnityEngine.Material            s_blitMaterial_GammaToLinear  // static @ 0x20
  private   static  UnityEngine.Material            s_blitMaterial_NoChange  // static @ 0x28
  private   static  UnityEngine.Shader              s_blitShader  // static @ 0x30
METHODS:
  RVA=0x09E9B3C0  token=0x60015AD  System.Void GetVerticesTransformInfo(UnityEngine.UIElements.VisualElement ve, UnityEngine.Matrix4x4& transform)
  RVA=0x09E9A0FC  token=0x60015AE  System.Void ComputeTransformMatrix(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement ancestor, UnityEngine.Matrix4x4& result)
  RVA=0x09E9BA20  token=0x60015AF  System.Boolean IsParentOrAncestorOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement child)
  RVA=0x09E9BE70  token=0x60015B0  UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo PaintElement(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09E9A82C  token=0x60015B1  UnityEngine.Material CreateBlitShader(System.Single colorConversion)
  RVA=0x09E9B11C  token=0x60015B2  UnityEngine.Material GetBlitMaterial(UnityEngine.UIElements.VisualElement.RenderTargetMode mode)
  RVA=0x09E99F60  token=0x60015B3  System.Void ClosePaintElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo closingInfo, UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09E9DBE8  token=0x60015B4  System.Void UpdateOrAllocate(UnityEngine.UIElements.UIR.MeshHandle& data, System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.UIElements.UIR.UIRenderDevice device, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& verts, Unity.Collections.NativeSlice<System.UInt16>& indices, System.UInt16& indexOffset, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09E9A480  token=0x60015B5  System.Void CopyTransformVertsPos(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, System.Boolean isText, System.Single textureId)
  RVA=0x09E9A22C  token=0x60015B6  System.Void CopyTransformVertsPosAndVec(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, System.Boolean isText, System.Single textureId)
  RVA=0x09E9A638  token=0x60015B7  System.Void CopyTriangleIndicesFlipWindingOrder(Unity.Collections.NativeSlice<System.UInt16> source, Unity.Collections.NativeSlice<System.UInt16> target, System.Int32 indexOffset)
  RVA=0x09E9A794  token=0x60015B8  System.Void CopyTriangleIndices(Unity.Collections.NativeSlice<System.UInt16> source, Unity.Collections.NativeSlice<System.UInt16> target, System.Int32 indexOffset)
  RVA=0x09E9BAB0  token=0x60015B9  System.Boolean NudgeVerticesToNewSpace(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device)
  RVA=0x09E9A9F8  token=0x60015BA  System.Void DoNudgeVertices(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.MeshHandle mesh, UnityEngine.Matrix4x4& nudgeTransform)
  RVA=0x09E9B8C8  token=0x60015BB  UnityEngine.UIElements.UIR.RenderChainCommand InjectMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& cmdPrev, UnityEngine.UIElements.UIR.RenderChainCommand& cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, System.Int32 indexCount, System.Int32 indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, System.Int32 stencilRef)
  RVA=0x09E9B65C  token=0x60015BC  UnityEngine.UIElements.UIR.RenderChainCommand InjectClosingMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& cmdPrev, UnityEngine.UIElements.UIR.RenderChainCommand& cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, System.Int32 indexCount, System.Int32 indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, System.Int32 stencilRef)
  RVA=0x09E9AF30  token=0x60015BD  System.Void FindCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  RVA=0x09E9ADB0  token=0x60015BE  System.Void FindClosingCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  RVA=0x09E9B7B8  token=0x60015BF  System.Void InjectCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  RVA=0x09E9B514  token=0x60015C0  System.Void InjectClosingCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  RVA=0x09E9D87C  token=0x60015C1  System.Void ResetCommands(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E9DCF4  token=0x60015C2  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.ClipMethod
TYPE:  sealed struct
TOKEN: 0x2000320
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodUndetermined  // const
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodNotClipped  // const
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodScissor  // const
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodShaderDiscard  // const
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodStencil  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.RenderEvents
TYPE:  static class
TOKEN: 0x2000321
SIZE:  0x10
FIELDS:
  private   static readonly System.Single                   VisibilityTreshold  // static @ 0x0
METHODS:
  RVA=0x09EA1AA4  token=0x60015C3  System.Void ProcessOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA1C0C  token=0x60015C4  System.Void ProcessOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA1B94  token=0x60015C5  System.Void ProcessOnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA1D04  token=0x60015C6  System.Void ProcessOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA1DCC  token=0x60015C7  System.Void ProcessOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA1EBC  token=0x60015C8  System.Void ProcessRegenText(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter painter, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA151C  token=0x60015C9  UnityEngine.Matrix4x4 GetTransformIDTransformInfo(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA12C4  token=0x60015CA  UnityEngine.Vector4 GetClipRectIDClipInfo(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09E9F74C  token=0x60015CB  System.UInt32 DepthFirstOnChildAdded(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.Int32 index, System.Boolean resetState)
  RVA=0x09E9FD54  token=0x60015CC  System.UInt32 DepthFirstOnChildRemoving(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA030C  token=0x60015CD  System.Void DepthFirstOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean hierarchical, System.Boolean isRootOfChange, System.Boolean isPendingHierarchicalRepaint, System.Boolean inheritedClipRectIDChanged, System.Boolean inheritedMaskingChanged, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA07CC  token=0x60015CE  System.Void DepthFirstOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, System.Single parentCompositeOpacity, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean hierarchical, UnityEngine.UIElements.UIR.ChainBuilderStats& stats, System.Boolean isDoingFullVertexRegeneration)
  RVA=0x09EA1980  token=0x60015CF  System.Void OnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA0B44  token=0x60015D0  System.Void DepthFirstOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.UIRenderDevice device, System.Boolean isAncestorOfChangeSkinned, System.Boolean transformChanged, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA0EE8  token=0x60015D1  System.Void DepthFirstOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean parentHierarchyHidden, System.Boolean hierarchical, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  RVA=0x09EA22B0  token=0x60015D2  System.Boolean UpdateTextCoreSettings(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA1920  token=0x60015D3  System.Boolean IsElementHierarchyHidden(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA14B0  token=0x60015D4  UnityEngine.UIElements.VisualElement GetLastDeepestChild(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA11D4  token=0x60015D5  UnityEngine.UIElements.UIR.Implementation.ClipMethod DetermineSelfClipMethod(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA21F4  token=0x60015D6  System.Boolean UpdateLocalFlipsWinding(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA25D0  token=0x60015D7  System.Void UpdateWorldFlipsWinding(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA2638  token=0x60015D8  System.Void UpdateZeroScaling(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA195C  token=0x60015D9  System.Boolean NeedsTransformID(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA1940  token=0x60015DA  System.Boolean NeedsColorID(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA1674  token=0x60015DB  System.Boolean InitColorIDs(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA1F18  token=0x60015DC  System.Void SetColorValues(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EA26D0  token=0x60015DD  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.UIRStylePainter
TYPE:  class
TOKEN: 0x2000322
SIZE:  0x178
IMPLEMENTS: UnityEngine.UIElements.IStylePainter System.IDisposable
FIELDS:
  private           UnityEngine.UIElements.UIR.RenderChainm_Owner  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry>m_Entries  // 0x18
  private           UnityEngine.UIElements.AtlasBasem_Atlas  // 0x20
  private           UnityEngine.UIElements.UIR.VectorImageManagerm_VectorImageManager  // 0x28
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entrym_CurrentEntry  // 0x30
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfom_ClosingInfo  // 0x90
  private           System.Int32                    m_MaskDepth  // 0xc8
  private           System.Int32                    m_StencilRef  // 0xcc
  private           UnityEngine.UIElements.UIR.BMPAllocm_ClipRectID  // 0xd0
  private           System.Int32                    m_SVGBackgroundEntryIndex  // 0xd8
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<UnityEngine.UIElements.Vertex>m_VertsPool  // 0xe0
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<System.UInt16>m_IndicesPool  // 0x108
  private           System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData>m_MeshWriteDataPool  // 0x130
  private           System.Int32                    m_NextMeshWriteDataPoolItem  // 0x138
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatorm_AllocRawVertsIndicesDelegate  // 0x140
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatorm_AllocThroughDrawMeshDelegate  // 0x148
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatorm_AllocThroughDrawGradientsDelegate  // 0x150
  private   readonly UnityEngine.UIElements.MeshGenerationContext<meshGenerationContext>k__BackingField  // 0x158
  private           UnityEngine.UIElements.VisualElement<currentElement>k__BackingField  // 0x160
  private           System.Int32                    <totalVertices>k__BackingField  // 0x168
  private           System.Int32                    <totalIndices>k__BackingField  // 0x16c
  private           System.Boolean                  <disposed>k__BackingField  // 0x170
PROPERTIES:
  meshGenerationContext  get=0x03D570A0
  currentElement  get=0x03D570E0  set=0x058B3C90
  entries  get=0x03D61D00
  closingInfo  get=0x03D88C10
  totalVertices  get=0x03D4FCB0  set=0x03D4FCC0
  totalIndices  get=0x03D5A800  set=0x03D5A870
  disposed  get=0x03D57C60  set=0x03D6DF80
  visualElement  get=0x03D88C50
METHODS:
  RVA=0x09EB99B8  token=0x60015DE  UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData()
  RVA=0x09EB5224  token=0x60015DF  UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
  RVA=0x09EB5330  token=0x60015E0  UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
  RVA=0x09EB5304  token=0x60015E1  UnityEngine.UIElements.MeshWriteData AllocThroughDrawGradients(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
  RVA=0x09EB9FB4  token=0x60015E2  System.Void .ctor(UnityEngine.UIElements.UIR.RenderChain renderChain)
  RVA=0x09EB5C04  token=0x60015EE  System.Void Dispose()
  RVA=0x09EB5C54  token=0x60015EF  System.Void Dispose(System.Boolean disposing)
  RVA=0x09EB57D0  token=0x60015F0  System.Void Begin(UnityEngine.UIElements.VisualElement ve)
  RVA=0x09EB9B14  token=0x60015F1  System.Void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd)
  RVA=0x09EB9A7C  token=0x60015F2  System.Void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, System.Int32 indexOffset)
  RVA=0x09EB4C64  token=0x60015F3  UnityEngine.UIElements.MeshWriteData AddGradientsEntry(System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.UIElements.TextureId texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags)
  RVA=0x09EB5FB8  token=0x60015F4  UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.Texture texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags)
  RVA=0x09EB7B70  token=0x60015F5  System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  RVA=0x09EB754C  token=0x60015F6  System.Void DrawTextNative(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  RVA=0x09EB701C  token=0x60015F7  System.Void DrawTextCore(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  RVA=0x09EB63EC  token=0x60015F8  System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  RVA=0x09EB5CD4  token=0x60015F9  System.Void DrawBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams)
  RVA=0x09EB5E9C  token=0x60015FA  System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled)
  RVA=0x09EB81A8  token=0x60015FC  System.Void DrawVisualElementBackground()
  RVA=0x09EB8C10  token=0x60015FD  System.Void DrawVisualElementBorder()
  RVA=0x09EB55E8  token=0x60015FE  System.Void ApplyVisualElementClipping()
  RVA=0x09EB4F00  token=0x60015FF  System.UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[] vertices, System.UInt16[] indices)
  RVA=0x09EB6AB0  token=0x6001600  System.Void DrawSprite(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  RVA=0x09EB535C  token=0x6001601  System.Void ApplyInset(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, UnityEngine.Texture tex)
  RVA=0x09EB7CBC  token=0x6001602  System.Void DrawVectorImage(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  RVA=0x09EB9B84  token=0x6001603  System.Void Reset()
  RVA=0x09EB9C74  token=0x6001604  System.Void ValidateMeshWriteData()
  RVA=0x09EB9100  token=0x6001605  System.Void GenerateStencilClipEntryForRoundedRectBackground()
  RVA=0x09EB9740  token=0x6001606  System.Void GenerateStencilClipEntryForSVGBackground()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter
TYPE:  class
TOKEN: 0x2000326
SIZE:  0x68
IMPLEMENTS: UnityEngine.UIElements.IStylePainter System.IDisposable
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_CurrentElement  // 0x10
  private           System.Int32                    m_TextEntryIndex  // 0x18
  private           Unity.Collections.NativeArray<UnityEngine.UIElements.Vertex>m_DudVerts  // 0x20
  private           Unity.Collections.NativeArray<System.UInt16>m_DudIndices  // 0x30
  private           Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>m_MeshDataVerts  // 0x40
  private           UnityEngine.Color32             m_XFormClipPages  // 0x50
  private           UnityEngine.Color32             m_IDs  // 0x54
  private           UnityEngine.Color32             m_Flags  // 0x58
  private           UnityEngine.Color32             m_OpacityColorPages  // 0x5c
  private   readonly UnityEngine.UIElements.MeshGenerationContext<meshGenerationContext>k__BackingField  // 0x60
PROPERTIES:
  meshGenerationContext  get=0x03D4EB00
METHODS:
  RVA=0x09EBACC8  token=0x600160C  System.Void .ctor()
  RVA=0x09EBA368  token=0x600160D  System.Void Begin(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device)
  RVA=0x09EBAC38  token=0x600160E  System.Void End()
  RVA=0x09EBA5F0  token=0x600160F  System.Void Dispose()
  RVA=0x0350B670  token=0x6001610  System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  RVA=0x0350B670  token=0x6001611  System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled)
  RVA=0x09EBA670  token=0x6001612  System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
END_CLASS

