// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRDebugger.dll
// Classes:  159
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

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
  public    static readonly SRDebug.<>c                     <>9  // static @ 0x0
  public    static  System.Action<SRDebugger.Services.ConsoleEntry><>9__9_0  // static @ 0x8
METHODS:
  RVA=0x03D122F0  token=0x6000007  System.Void .cctor()
  RVA=0x0350B670  token=0x6000008  System.Void .ctor()
  RVA=0x096BAA1C  token=0x6000009  System.Void <GetDefaultCopyConsoleItemCallback>b__9_0(SRDebugger.Services.ConsoleEntry entry)
END_CLASS

CLASS: SRDebug
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
  public    static  System.String                   Version  // const
  private   static  System.Boolean                  <IsInitialized>k__BackingField  // static @ 0x0
  public    static  System.Action<SRDebugger.Services.ConsoleEntry>CopyConsoleItemCallback  // static @ 0x8
PROPERTIES:
  IsInitialized  get=0x096B88D8  set=0x096B8928
  Instance  get=0x096B8884
METHODS:
  RVA=0x03A273C0  token=0x6000004  System.Void Init()
  RVA=0x03B3D280  token=0x6000005  System.Action<SRDebugger.Services.ConsoleEntry> GetDefaultCopyConsoleItemCallback()
  RVA=0x03B3D220  token=0x6000006  System.Void .cctor()
END_CLASS

CLASS: <GetEnumerator>d__18
TYPE:  sealed class
TOKEN: 0x200000A
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           T                               <>2__current  // 0x0
  public            SRDebugger.CircularBuffer<T>    <>4__this  // 0x0
  private           System.ArraySegment<T>[]        <>7__wrap1  // 0x0
  private           System.Int32                    <>7__wrap2  // 0x0
  private           System.ArraySegment<T>          <segment>5__4  // 0x0
  private           System.Int32                    <i>5__5  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<T>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000032  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000033  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000034  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000036  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x2000013
SIZE:  0x18
FIELDS:
  public            System.Object                   value  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000072  System.Void .ctor()
  RVA=0x020B7B20  token=0x6000073  System.Object <Create>b__0()
END_CLASS

CLASS: ShortcutActions
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.ShortcutActionsNone  // const
  public    static  SRDebugger.Settings.ShortcutActionsOpenSystemInfoTab  // const
  public    static  SRDebugger.Settings.ShortcutActionsOpenConsoleTab  // const
  public    static  SRDebugger.Settings.ShortcutActionsOpenOptionsTab  // const
  public    static  SRDebugger.Settings.ShortcutActionsOpenProfilerTab  // const
  public    static  SRDebugger.Settings.ShortcutActionsOpenBugReporterTab  // const
  public    static  SRDebugger.Settings.ShortcutActionsClosePanel  // const
  public    static  SRDebugger.Settings.ShortcutActionsOpenPanel  // const
  public    static  SRDebugger.Settings.ShortcutActionsTogglePanel  // const
  public    static  SRDebugger.Settings.ShortcutActionsShowBugReportPopover  // const
  public    static  SRDebugger.Settings.ShortcutActionsToggleDockedConsole  // const
  public    static  SRDebugger.Settings.ShortcutActionsToggleDockedProfiler  // const
METHODS:
END_CLASS

CLASS: TriggerBehaviours
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.TriggerBehavioursTripleTap  // const
  public    static  SRDebugger.Settings.TriggerBehavioursTapAndHold  // const
  public    static  SRDebugger.Settings.TriggerBehavioursDoubleTap  // const
METHODS:
END_CLASS

CLASS: TriggerEnableModes
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.TriggerEnableModesEnabled  // const
  public    static  SRDebugger.Settings.TriggerEnableModesMobileOnly  // const
  public    static  SRDebugger.Settings.TriggerEnableModesOff  // const
  public    static  SRDebugger.Settings.TriggerEnableModesDevelopmentBuildsOnly  // const
METHODS:
END_CLASS

CLASS: UIModes
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.Settings.UIModes     NewInputSystem  // const
  public    static  SRDebugger.Settings.UIModes     LegacyInputSystem  // const
METHODS:
END_CLASS

CLASS: KeyboardShortcut
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x28
FIELDS:
  public            SRDebugger.Settings.ShortcutActionsAction  // 0x10
  public            System.Boolean                  Alt  // 0x14
  public            System.Boolean                  Control  // 0x15
  public            UnityEngine.KeyCode             Key  // 0x18
  public            System.Boolean                  Shift  // 0x1c
  public            System.Nullable<UnityEngine.InputSystem.Key>Cached_KeyCode  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60000A3  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001D
SIZE:  0x10
FIELDS:
  public    static readonly SRDebugger.Settings.<>c         <>9  // static @ 0x0
  public    static  System.Func<System.Int32,System.Boolean><>9__42_0  // static @ 0x8
METHODS:
  RVA=0x096BABBC  token=0x60000A4  System.Void .cctor()
  RVA=0x0350B670  token=0x60000A5  System.Void .ctor()
  RVA=0x096BAAFC  token=0x60000A6  System.Boolean <set_EntryCode>b__42_0(System.Int32 p)
END_CLASS

CLASS: CopyToClipboardStates
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStatesHidden  // const
  public    static  SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStatesVisible  // const
  public    static  SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStatesActivated  // const
METHODS:
END_CLASS

CLASS: <FadeCopyButton>d__44
TYPE:  sealed class
TOKEN: 0x200002A
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            SRDebugger.UI.Tabs.ConsoleTabController<>4__this  // 0x20
  private           System.Single                   <startTime>5__2  // 0x28
  private           System.Single                   <endTime>5__3  // 0x2c
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000E2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000E3  System.Void System.IDisposable.Dispose()
  RVA=0x096BA0B4  token=0x60000E4  System.Boolean MoveNext()
  RVA=0x096BA240  token=0x60000E6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: CategoryInstance
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x20
FIELDS:
  private           SRDebugger.UI.Other.CategoryGroup<CategoryGroup>k__BackingField  // 0x10
  public    readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>Options  // 0x18
PROPERTIES:
  CategoryGroup  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x096AB90C  token=0x6000104  System.Void .ctor(SRDebugger.UI.Other.CategoryGroup group)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200002E
SIZE:  0x10
FIELDS:
  public    static readonly SRDebugger.UI.Tabs.OptionsTabController.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<SRDebugger.OptionDefinition>>,System.String><>9__29_0  // static @ 0x8
  public    static  System.Comparison<SRDebugger.OptionDefinition><>9__30_0  // static @ 0x10
METHODS:
  RVA=0x096BAC20  token=0x6000105  System.Void .cctor()
  RVA=0x0350B670  token=0x6000106  System.Void .ctor()
  RVA=0x096BAA9C  token=0x6000107  System.String <Populate>b__29_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<SRDebugger.OptionDefinition>> p)
  RVA=0x096BA9E8  token=0x6000108  System.Int32 <CreateCategory>b__30_0(SRDebugger.OptionDefinition d1, SRDebugger.OptionDefinition d2)
END_CLASS

CLASS: <>c__DisplayClass30_0
TYPE:  sealed class
TOKEN: 0x200002F
SIZE:  0x20
FIELDS:
  public            SRDebugger.UI.Tabs.OptionsTabController<>4__this  // 0x10
  public            SRDebugger.UI.Tabs.OptionsTabController.CategoryInstancecategoryInstance  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000109  System.Void .ctor()
  RVA=0x096BAB5C  token=0x600010A  System.Void <CreateCategory>b__1(System.Boolean b)
END_CLASS

CLASS: <SubmitCo>d__18
TYPE:  sealed class
TOKEN: 0x2000033
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            SRDebugger.UI.Other.BugReportSheetController<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000122  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000123  System.Void System.IDisposable.Dispose()
  RVA=0x096BA564  token=0x6000124  System.Boolean MoveNext()
  RVA=0x096BA99C  token=0x6000126  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass15_0
TYPE:  sealed class
TOKEN: 0x2000044
SIZE:  0x20
FIELDS:
  public            SRDebugger.UI.Other.SRTabController<>4__this  // 0x10
  public            SRDebugger.UI.Other.SRTab       tab  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000181  System.Void .ctor()
  RVA=0x096BAB34  token=0x6000182  System.Void <AddTab>b__0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000045
SIZE:  0x10
FIELDS:
  public    static readonly SRDebugger.UI.Other.SRTabController.<>c<>9  // static @ 0x0
  public    static  System.Comparison<SRDebugger.UI.Other.SRTab><>9__17_0  // static @ 0x8
METHODS:
  RVA=0x096BAC84  token=0x6000183  System.Void .cctor()
  RVA=0x0350B670  token=0x6000184  System.Void .ctor()
  RVA=0x096BAAD0  token=0x6000185  System.Int32 <SortTabs>b__17_0(SRDebugger.UI.Other.SRTab t1, SRDebugger.UI.Other.SRTab t2)
END_CLASS

CLASS: <ScrollToBottom>d__30
TYPE:  sealed class
TOKEN: 0x200004A
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            SRDebugger.UI.Controls.ConsoleLogControl<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001A2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001A3  System.Void System.IDisposable.Dispose()
  RVA=0x096BA400  token=0x60001A4  System.Boolean MoveNext()
  RVA=0x096BA518  token=0x60001A6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass14_0
TYPE:  sealed class
TOKEN: 0x2000051
SIZE:  0x20
FIELDS:
  public            System.Int32                    number  // 0x10
  public            SRDebugger.UI.Controls.PinEntryControl<>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001D7  System.Void .ctor()
  RVA=0x096BAB0C  token=0x60001D8  System.Void <Awake>b__0()
END_CLASS

CLASS: <CleanUp>d__8
TYPE:  sealed class
TOKEN: 0x2000053
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            SRDebugger.UI.Controls.ProfilerMemoryBlock<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001DF  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001E0  System.Void System.IDisposable.Dispose()
  RVA=0x096B9FC0  token=0x60001E1  System.Boolean MoveNext()
  RVA=0x096BA068  token=0x60001E3  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: VerticalAlignments
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignmentsTop  // const
  public    static  SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignmentsBottom  // const
METHODS:
END_CLASS

CLASS: ValueRange
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x20
FIELDS:
  public            System.Double                   MaxValue  // 0x10
  public            System.Double                   MinValue  // 0x18
METHODS:
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x2000078
SIZE:  0x18
FIELDS:
  public            SRDebugger.Services.BugReportCompleteCallbackcompleteHandler  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002B8  System.Void .ctor()
  RVA=0x096BAB8C  token=0x60002B9  System.Void <SendBugReport>b__0(SRDebugger.BugReportSubmitResult result)
END_CLASS

CLASS: <OpenCo>d__7
TYPE:  sealed class
TOKEN: 0x200007A
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Boolean                  takeScreenshot  // 0x20
  public            SRDebugger.Services.Implementation.BugReportPopoverService<>4__this  // 0x28
  public            System.String                   descriptionText  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002C5  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002C6  System.Void System.IDisposable.Dispose()
  RVA=0x096BA28C  token=0x60002C7  System.Boolean MoveNext()
  RVA=0x096BA3B4  token=0x60002C9  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: OptionContainerEventHandler
TYPE:  class
TOKEN: 0x2000081
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private   readonly SRDebugger.Services.Implementation.OptionsServiceImpl_service  // 0x10
  private   readonly SRDebugger.IOptionContainer     _container  // 0x18
METHODS:
  RVA=0x096BDD64  token=0x6000303  System.Void .ctor(SRDebugger.Services.Implementation.OptionsServiceImpl service, SRDebugger.IOptionContainer container)
  RVA=0x096BDBA0  token=0x6000304  System.Void ContainerOnOptionAdded(SRDebugger.OptionDefinition obj)
  RVA=0x096BDBCC  token=0x6000305  System.Void ContainerOnOptionRemoved(SRDebugger.OptionDefinition obj)
  RVA=0x096BDBF8  token=0x6000306  System.Void Dispose()
END_CLASS

CLASS: ReflectionOptionContainer
TYPE:  class
TOKEN: 0x2000082
SIZE:  0x20
IMPLEMENTS: SRDebugger.IOptionContainer
FIELDS:
  private           System.Collections.Generic.List<SRDebugger.OptionDefinition>_options  // 0x10
  private   readonly System.Object                   _target  // 0x18
PROPERTIES:
  IsDynamic  get=0x0115F4C0
  Options  get=0x03D3CD20
EVENTS:
  OptionAdded  add=add_OptionAdded  remove=remove_OptionAdded
  OptionRemoved  add=add_OptionRemoved  remove=remove_OptionRemoved
METHODS:
  RVA=0x04276BB8  token=0x600030D  System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions()
  RVA=0x022C3A90  token=0x600030E  System.Void .ctor(System.Object target)
  RVA=0x096C102C  token=0x600030F  System.Boolean Equals(SRDebugger.Services.Implementation.OptionsServiceImpl.ReflectionOptionContainer other)
  RVA=0x096C0F78  token=0x6000310  System.Boolean Equals(System.Object obj)
  RVA=0x03D4A220  token=0x6000311  System.Int32 GetHashCode()
END_CLASS

CLASS: <>c__DisplayClass51_0
TYPE:  sealed class
TOKEN: 0x2000086
SIZE:  0x18
FIELDS:
  public            SRDebugger.ActionCompleteCallbackonComplete  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000353  System.Void .ctor()
  RVA=0x096C57B8  token=0x6000354  System.Void <ShowBugReportSheet>b__0(System.Boolean succeed, System.String message)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x2000089
SIZE:  0x18
FIELDS:
  public            SRDebugger.InfoEntry            info  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000375  System.Void .ctor()
  RVA=0x05830650  token=0x6000376  System.Boolean <Add>b__0(SRDebugger.InfoEntry p)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200008A
SIZE:  0x10
FIELDS:
  public    static readonly SRDebugger.Services.Implementation.StandardSystemInformationService.<>c<>9  // static @ 0x0
  public    static  System.Func<System.Object>      <>9__6_0  // static @ 0x8
  public    static  System.Func<System.Object>      <>9__6_1  // static @ 0x10
  public    static  System.Func<System.Object>      <>9__6_2  // static @ 0x18
  public    static  System.Func<System.Object>      <>9__6_3  // static @ 0x20
  public    static  System.Func<System.Object>      <>9__6_4  // static @ 0x28
  public    static  System.Func<System.Object>      <>9__6_5  // static @ 0x30
  public    static  System.Func<System.Object>      <>9__6_6  // static @ 0x38
  public    static  System.Func<System.Object>      <>9__6_7  // static @ 0x40
  public    static  System.Func<System.Object>      <>9__6_8  // static @ 0x48
METHODS:
  RVA=0x03D13B50  token=0x6000377  System.Void .cctor()
  RVA=0x0350B670  token=0x6000378  System.Void .ctor()
  RVA=0x096C5414  token=0x6000379  System.Object <CreateDefaultSet>b__6_0()
  RVA=0x096C5484  token=0x600037A  System.Object <CreateDefaultSet>b__6_1()
  RVA=0x096C54C8  token=0x600037B  System.Object <CreateDefaultSet>b__6_2()
  RVA=0x096C550C  token=0x600037C  System.Object <CreateDefaultSet>b__6_3()
  RVA=0x096C5550  token=0x600037D  System.Object <CreateDefaultSet>b__6_4()
  RVA=0x096C5594  token=0x600037E  System.Object <CreateDefaultSet>b__6_5()
  RVA=0x096C55D8  token=0x600037F  System.Object <CreateDefaultSet>b__6_6()
  RVA=0x096C561C  token=0x6000380  System.Object <CreateDefaultSet>b__6_7()
  RVA=0x096C5720  token=0x6000381  System.Object <CreateDefaultSet>b__6_8()
END_CLASS

CLASS: <EndOfFrameCoroutine>d__19
TYPE:  sealed class
TOKEN: 0x200008E
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            SRDebugger.Profiler.SRPProfilerService<>4__this  // 0x20
  private           UnityEngine.WaitForEndOfFrame   <endOfFrame>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600039E  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600039F  System.Void System.IDisposable.Dispose()
  RVA=0x0233AC40  token=0x60003A0  System.Boolean MoveNext()
  RVA=0x096C4BFC  token=0x60003A2  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <Submit>d__9
TYPE:  sealed class
TOKEN: 0x2000092
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            SRDebugger.Internal.BugReportApi<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003B0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003B1  System.Void System.IDisposable.Dispose()
  RVA=0x096C4E70  token=0x60003B2  System.Boolean MoveNext()
  RVA=0x096C53C8  token=0x60003B4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <ScreenshotCaptureCo>d__1
TYPE:  sealed class
TOKEN: 0x2000094
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003B8  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003B9  System.Void System.IDisposable.Dispose()
  RVA=0x096C4C48  token=0x60003BA  System.Boolean MoveNext()
  RVA=0x096C4E24  token=0x60003BC  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: OptionType
TYPE:  sealed struct
TOKEN: 0x2000098
SIZE:  0x20
FIELDS:
  public    readonly System.Type                     Type  // 0x10
  public    readonly System.Boolean                  IsReadyOnly  // 0x18
METHODS:
  RVA=0x071B198C  token=0x60003CB  System.Void .ctor(System.Type type, System.Boolean isReadyOnly)
  RVA=0x096BE908  token=0x60003CC  System.Boolean Equals(SRDebugger.Internal.OptionControlFactory.OptionType other)
  RVA=0x096BE898  token=0x60003CD  System.Boolean Equals(System.Object obj)
  RVA=0x096BE940  token=0x60003CE  System.Int32 GetHashCode()
END_CLASS

CLASS: <>c__DisplayClass8_0
TYPE:  sealed class
TOKEN: 0x2000099
SIZE:  0x18
FIELDS:
  public            SRDebugger.OptionDefinition     from  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003CF  System.Void .ctor()
  RVA=0x096C57D0  token=0x60003D0  System.Boolean <TryGetDataControlPrefab>b__0(SRDebugger.UI.Controls.DataBoundControl p)
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  sealed struct
TOKEN: 0x200009F
SIZE:  0x34
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x200009E
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360B92E635AE849B517CA3A2F28C2502AF8675E5C6C01CD75EA9F53120E81DDAAA  // static @ 0x0
METHODS:
END_CLASS

CLASS: Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation.ConsoleFilterStateService
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x20
IMPLEMENTS: SRDebugger.Services.IConsoleFilterState
FIELDS:
  private           SRDebugger.Services.ConsoleStateChangedEventHandlerFilterStateChange  // 0x10
  private   readonly System.Boolean[]                _states  // 0x18
EVENTS:
  FilterStateChange  add=add_FilterStateChange  remove=remove_FilterStateChange
METHODS:
  RVA=0x096AC424  token=0x600000C  System.Void .ctor()
  RVA=0x096AC2CC  token=0x600000D  System.Void SetConsoleFilterState(UnityEngine.LogType type, System.Boolean newState)
  RVA=0x096AC250  token=0x600000E  System.Boolean GetConsoleFilterState(UnityEngine.LogType type)
  RVA=0x096AC28C  token=0x600000F  UnityEngine.LogType GetType(UnityEngine.LogType type)
END_CLASS

CLASS: SRDebugger.AutoInitialize
TYPE:  static class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.RuntimeInitializeLoadTypeInitializeLoadType  // const
METHODS:
  RVA=0x03A274B0  token=0x6000010  System.Void OnLoadBeforeScene()
  RVA=0x03A27360  token=0x6000011  System.Void OnLoad()
END_CLASS

CLASS: SRDebugger.BugReport
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x38
FIELDS:
  public            System.Collections.Generic.List<SRDebugger.Services.ConsoleEntry>ConsoleLog  // 0x10
  public            System.String                   Email  // 0x18
  public            System.Byte[]                   ScreenshotData  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>>SystemInformation  // 0x28
  public            System.String                   UserDescription  // 0x30
METHODS:
  RVA=0x0350B670  token=0x6000012  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.BugReportSubmitResult
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x20
FIELDS:
  private   readonly System.Boolean                  <IsSuccessful>k__BackingField  // 0x10
  private   readonly System.String                   <ErrorMessage>k__BackingField  // 0x18
PROPERTIES:
  Success  get=0x096AB4A0
  IsSuccessful  get=0x011797F0
  ErrorMessage  get=0x01041090
METHODS:
  RVA=0x096AB444  token=0x6000014  SRDebugger.BugReportSubmitResult Error(System.String errorMessage)
  RVA=0x02F73D00  token=0x6000017  System.Void .ctor(System.Boolean successful, System.String error)
END_CLASS

CLASS: SRDebugger.IBugReporterHandler
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
PROPERTIES:
  IsUsable  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000019  System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
END_CLASS

CLASS: SRDebugger.CircularBuffer`1
TYPE:  class
TOKEN: 0x2000009
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IReadOnlyList`1 System.Collections.Generic.IReadOnlyCollection`1
FIELDS:
  private   readonly T[]                             _buffer  // 0x0
  private           System.Int32                    _end  // 0x0
  private           System.Int32                    _count  // 0x0
  private           System.Int32                    _start  // 0x0
PROPERTIES:
  Capacity  get=-1  // not resolved
  IsFull  get=-1  // not resolved
  IsEmpty  get=-1  // not resolved
  Count  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600001A  System.Void .ctor(System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600001B  System.Void .ctor(System.Int32 capacity, T[] items)
  RVA=-1  // not resolved  token=0x6000022  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000023  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000024  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000025  T Front()
  RVA=-1  // not resolved  token=0x6000026  T Back()
  RVA=-1  // not resolved  token=0x6000027  System.Void PushBack(T item)
  RVA=-1  // not resolved  token=0x6000028  System.Void PushFront(T item)
  RVA=-1  // not resolved  token=0x6000029  System.Void PopBack()
  RVA=-1  // not resolved  token=0x600002A  System.Void PopFront()
  RVA=-1  // not resolved  token=0x600002B  T[] ToArray()
  RVA=-1  // not resolved  token=0x600002C  System.Void ThrowIfEmpty(System.String message)
  RVA=-1  // not resolved  token=0x600002D  System.Void Increment(System.Int32& index)
  RVA=-1  // not resolved  token=0x600002E  System.Void Decrement(System.Int32& index)
  RVA=-1  // not resolved  token=0x600002F  System.Int32 InternalIndex(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000030  System.ArraySegment<T> ArrayOne()
  RVA=-1  // not resolved  token=0x6000031  System.ArraySegment<T> ArrayTwo()
END_CLASS

CLASS: SRDebugger.OptionDefinition
TYPE:  sealed class
TOKEN: 0x200000B
SIZE:  0x38
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.String                   <Category>k__BackingField  // 0x18
  private           System.Int32                    <SortPriority>k__BackingField  // 0x20
  private           SRF.Helpers.MethodReference     <Method>k__BackingField  // 0x28
  private           SRF.Helpers.PropertyReference   <Property>k__BackingField  // 0x30
PROPERTIES:
  Name  get=0x020B7B20  set=0x0426FEE0
  Category  get=0x01041090  set=0x022C3A90
  SortPriority  get=0x01003B50  set=0x01003B60
  IsMethod  get=0x05693D38
  IsProperty  get=0x085839D0
  Method  get=0x03D4EAC0  set=0x02C92F10
  Property  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x03864580  token=0x6000044  System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority)
  RVA=0x096B37D0  token=0x6000045  System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.MethodReference method)
  RVA=0x096B37A0  token=0x6000046  System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.PropertyReference property)
  RVA=0x096B36FC  token=0x6000047  SRDebugger.OptionDefinition FromMethod(System.String name, System.Action callback, System.String category, System.Int32 sortPriority)
  RVA=-1  // generic def  token=0x6000048  SRDebugger.OptionDefinition Create(System.String name, System.Func<T> getter, System.Action<T> setter, System.String category, System.Int32 sortPriority)
END_CLASS

CLASS: SRDebugger.IOptionContainer
TYPE:  interface
TOKEN: 0x200000C
FIELDS:
PROPERTIES:
  IsDynamic  get=-1  // abstract
EVENTS:
  OptionAdded  add=add_OptionAdded  remove=remove_OptionAdded
  OptionRemoved  add=add_OptionRemoved  remove=remove_OptionRemoved
METHODS:
  RVA=-1  // abstract  token=0x6000049  System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions()
END_CLASS

CLASS: SRDebugger.DynamicOptionContainer
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x30
IMPLEMENTS: SRDebugger.IOptionContainer
FIELDS:
  private   readonly System.Collections.Generic.List<SRDebugger.OptionDefinition>_options  // 0x10
  private   readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition>_optionsReadOnly  // 0x18
  private           System.Action<SRDebugger.OptionDefinition>OptionAdded  // 0x20
  private           System.Action<SRDebugger.OptionDefinition>OptionRemoved  // 0x28
PROPERTIES:
  Options  get=0x01041090
  IsDynamic  get=0x0232EB60
EVENTS:
  OptionAdded  add=add_OptionAdded  remove=remove_OptionAdded
  OptionRemoved  add=add_OptionRemoved  remove=remove_OptionRemoved
METHODS:
  RVA=0x096B01B0  token=0x6000050  System.Void .ctor()
  RVA=0x096B00D0  token=0x6000051  System.Void AddOption(SRDebugger.OptionDefinition option)
  RVA=0x096B013C  token=0x6000052  System.Boolean RemoveOption(SRDebugger.OptionDefinition option)
  RVA=0x020B7B20  token=0x6000053  System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> SRDebugger.IOptionContainer.GetOptions()
END_CLASS

CLASS: SRDebugger.VisibilityChangedDelegate
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06892B88  token=0x6000059  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600005A  System.Void Invoke(System.Boolean isVisible)
  RVA=0x096BAD94  token=0x600005B  System.IAsyncResult BeginInvoke(System.Boolean isVisible, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600005C  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.ActionCompleteCallback
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06892B88  token=0x600005D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600005E  System.Void Invoke(System.Boolean success)
  RVA=0x096A9AB8  token=0x600005F  System.IAsyncResult BeginInvoke(System.Boolean success, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000060  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.PinnedUiCanvasCreated
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x055582DC  token=0x6000061  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000062  System.Void Invoke(UnityEngine.RectTransform canvasTransform)
  RVA=0x0389C3B0  token=0x6000063  System.IAsyncResult BeginInvoke(UnityEngine.RectTransform canvasTransform, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000064  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.EntryCode
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IReadOnlyList`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IReadOnlyCollection`1
FIELDS:
  public    readonly System.Int32                    Digit1  // 0x10
  public    readonly System.Int32                    Digit2  // 0x14
  public    readonly System.Int32                    Digit3  // 0x18
  public    readonly System.Int32                    Digit4  // 0x1c
PROPERTIES:
  Count  get=0x03D50CD0
  Item  get=0x096B0774
METHODS:
  RVA=0x096B059C  token=0x6000065  System.Void .ctor(System.Int32 digit1, System.Int32 digit2, System.Int32 digit3, System.Int32 digit4)
  RVA=0x096B0484  token=0x6000066  System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator()
  RVA=0x096B0594  token=0x6000067  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: SRDebugger.InfoEntry
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x28
FIELDS:
  private           System.String                   <Title>k__BackingField  // 0x10
  private           System.Boolean                  <IsPrivate>k__BackingField  // 0x18
  private           System.Func<System.Object>      _valueGetter  // 0x20
PROPERTIES:
  Title  get=0x020B7B20  set=0x0426FEE0
  Value  get=0x096B1100
  IsPrivate  get=0x01002A50  set=0x01002B40
METHODS:
  RVA=0x0315D1E0  token=0x600006F  SRDebugger.InfoEntry Create(System.String name, System.Func<System.Object> getter, System.Boolean isPrivate)
  RVA=0x0315D270  token=0x6000070  SRDebugger.InfoEntry Create(System.String name, System.Object value, System.Boolean isPrivate)
  RVA=0x0350B670  token=0x6000071  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.DefaultTabs
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.DefaultTabs          SystemInformation  // const
  public    static  SRDebugger.DefaultTabs          Options  // const
  public    static  SRDebugger.DefaultTabs          Console  // const
  public    static  SRDebugger.DefaultTabs          Profiler  // const
  public    static  SRDebugger.DefaultTabs          BugReporter  // const
METHODS:
END_CLASS

CLASS: SRDebugger.PinAlignment
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.PinAlignment         TopLeft  // const
  public    static  SRDebugger.PinAlignment         TopRight  // const
  public    static  SRDebugger.PinAlignment         BottomLeft  // const
  public    static  SRDebugger.PinAlignment         BottomRight  // const
  public    static  SRDebugger.PinAlignment         CenterLeft  // const
  public    static  SRDebugger.PinAlignment         CenterRight  // const
  public    static  SRDebugger.PinAlignment         TopCenter  // const
  public    static  SRDebugger.PinAlignment         BottomCenter  // const
METHODS:
END_CLASS

CLASS: SRDebugger.ConsoleAlignment
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRDebugger.ConsoleAlignment     Top  // const
  public    static  SRDebugger.ConsoleAlignment     Bottom  // const
METHODS:
END_CLASS

CLASS: SRDebugger.Settings
TYPE:  class
TOKEN: 0x2000017
SIZE:  0xA8
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private   static  System.String                   ResourcesName  // const
  private   static  SRDebugger.Settings             _instance  // static @ 0x0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x18
  private           System.Boolean                  _isEnabled  // 0x20
  private           System.Boolean                  _disableWelcomePopup  // 0x21
  private           SRDebugger.Settings.UIModes     _uiInputMode  // 0x24
  private           SRDebugger.DefaultTabs          _defaultTab  // 0x28
  private           SRDebugger.Settings.TriggerEnableModes_triggerEnableMode  // 0x2c
  private           SRDebugger.Settings.TriggerBehaviours_triggerBehaviour  // 0x30
  private           System.Boolean                  _errorNotification  // 0x34
  private           System.Boolean                  _enableKeyboardShortcuts  // 0x35
  private           SRDebugger.Settings.KeyboardShortcut[]_keyboardShortcuts  // 0x38
  private           SRDebugger.Settings.KeyboardShortcut[]_newKeyboardShortcuts  // 0x40
  private           System.Boolean                  _keyboardModifierControl  // 0x48
  private           System.Boolean                  _keyboardModifierAlt  // 0x49
  private           System.Boolean                  _keyboardModifierShift  // 0x4a
  private           System.Boolean                  _keyboardEscapeClose  // 0x4b
  private           System.Boolean                  _enableBackgroundTransparency  // 0x4c
  private           System.Single                   _backgroundTransparency  // 0x50
  private           System.Boolean                  _collapseDuplicateLogEntries  // 0x54
  private           System.Boolean                  _richTextInConsole  // 0x55
  private           System.Boolean                  _requireEntryCode  // 0x56
  private           System.Boolean                  _requireEntryCodeEveryTime  // 0x57
  private           System.Int32[]                  _entryCode  // 0x58
  private           System.Boolean                  _useDebugCamera  // 0x60
  private           System.Int32                    _debugLayer  // 0x64
  private           System.Single                   _debugCameraDepth  // 0x68
  private           System.String                   _apiKey  // 0x70
  private           System.Boolean                  _enableBugReporter  // 0x78
  private           System.Boolean                  _enableBugReportScreenshot  // 0x79
  private           SRDebugger.DefaultTabs[]        _disabledTabs  // 0x80
  private           SRDebugger.PinAlignment         _profilerAlignment  // 0x88
  private           SRDebugger.PinAlignment         _optionsAlignment  // 0x8c
  private           SRDebugger.ConsoleAlignment     _consoleAlignment  // 0x90
  private           SRDebugger.PinAlignment         _triggerPosition  // 0x94
  private           System.Int32                    _maximumConsoleEntries  // 0x98
  private           System.Boolean                  _enableEventSystemCreation  // 0x9c
  private           System.Boolean                  _automaticShowCursor  // 0x9d
  private           System.Single                   _uiScale  // 0xa0
  private           System.Boolean                  _unloadOnClose  // 0xa4
PROPERTIES:
  Instance  get=0x0267B8C0
  IsEnabled  get=0x03D4EF90
  UIInputMode  get=0x03D4E2E0
  DefaultTab  get=0x03D4EB90
  EnableTrigger  get=0x03D4EDD0
  TriggerBehaviour  get=0x03D4ED20
  ErrorNotification  get=0x03D4F570
  EnableKeyboardShortcuts  get=0x03D4F560
  KeyboardShortcuts  get=0x03D4E2B0
  KeyboardEscapeClose  get=0x03D56CD0
  EnableBackgroundTransparency  get=0x03D4F520
  BackgroundTransparency  get=0x03D51C90
  RequireCode  get=0x03D58490
  RequireEntryCodeEveryTime  get=0x03D58480
  EntryCode  get=0x096B99F8  set=0x096B9B00
  UseDebugCamera  get=0x03D519A0
  DebugLayer  get=0x03D50B30
  DebugCameraDepth  get=0x03D56A40
  CollapseDuplicateLogEntries  get=0x03D4F320
  RichTextInConsole  get=0x03D4F310
  ApiKey  get=0x03D4EB30
  EnableBugReporter  get=0x03D4F800
  EnableBugReportScreenshot  get=0x03D51AE0
  DisabledTabs  get=0x03D4EAE0
  TriggerPosition  get=0x03D5B3A0
  ProfilerAlignment  get=0x03D4F0B0
  OptionsAlignment  get=0x03D4F3D0
  ConsoleAlignment  get=0x03D4FB60  set=0x03D4FB70
  MaximumConsoleEntries  get=0x03D4EB50  set=0x03D4EB80
  EnableEventSystemGeneration  get=0x03D5E1C0  set=0x03D5E200
  AutomaticallyShowCursor  get=0x03D6E090
  UIScale  get=0x03D58340  set=0x096B9D10
  UnloadOnClose  get=0x03D58450
EVENTS:
  PropertyChanged  add=add_PropertyChanged  remove=remove_PropertyChanged
METHODS:
  RVA=0x0389EEB0  token=0x6000075  SRDebugger.Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts()
  RVA=0x03A44180  token=0x6000076  System.Void UpgradeKeyboardShortcuts()
  RVA=0x096B98D4  token=0x600009E  System.Void OnPropertyChanged(System.String propertyName)
  RVA=0x096B9834  token=0x600009F  System.Void ClearCache()
  RVA=0x03A44130  token=0x60000A0  SRDebugger.Settings GetInstance()
  RVA=0x03A44090  token=0x60000A1  SRDebugger.Settings GetOrCreateInstance()
  RVA=0x0389ED90  token=0x60000A2  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.SRDebuggerInit
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x48
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x60000A7  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.NumberRangeAttribute
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Double                   Max  // 0x10
  public    readonly System.Double                   Min  // 0x18
METHODS:
  RVA=0x03D4E420  token=0x60000A8  System.Void .ctor(System.Double min, System.Double max)
END_CLASS

CLASS: SRDebugger.IncrementAttribute
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Double                   Increment  // 0x10
METHODS:
  RVA=0x03D4E410  token=0x60000A9  System.Void .ctor(System.Double increment)
END_CLASS

CLASS: SRDebugger.SortAttribute
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Int32                    SortPriority  // 0x10
METHODS:
  RVA=0x010410F0  token=0x60000AA  System.Void .ctor(System.Int32 priority)
END_CLASS

CLASS: SRDebugger.VersionInfo
TYPE:  static class
TOKEN: 0x2000022
SIZE:  0x10
FIELDS:
  public    static  System.String                   Version  // const
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.SRDebugApi
TYPE:  static class
TOKEN: 0x200008F
SIZE:  0x10
FIELDS:
  public    static  System.String                   Protocol  // const
  public    static  System.String                   EndPoint  // const
  public    static  System.String                   BugReportEndPoint  // const
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.SRDebugApiUtil
TYPE:  static class
TOKEN: 0x2000090
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096C1054  token=0x60003A4  System.String ParseErrorException(System.Net.WebException ex)
  RVA=0x096C1130  token=0x60003A5  System.String ParseErrorResponse(System.String response, System.String fallback)
  RVA=0x096C1750  token=0x60003A6  System.Boolean ReadResponse(System.Net.HttpWebRequest request, System.String& result)
  RVA=0x096C15C8  token=0x60003A7  System.String ReadResponseStream(System.Net.WebResponse stream)
END_CLASS

CLASS: SRDebugger.Internal.BugReportApi
TYPE:  class
TOKEN: 0x2000091
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.String                   _apiKey  // 0x18
  private           SRDebugger.BugReport            _bugReport  // 0x20
  private           System.Boolean                  _isBusy  // 0x28
  private           UnityEngine.Networking.UnityWebRequest_webRequest  // 0x30
  private           System.Action<SRDebugger.BugReportSubmitResult>_onComplete  // 0x38
  private           System.IProgress<System.Single> _progress  // 0x40
METHODS:
  RVA=0x096BB654  token=0x60003A8  System.Void Submit(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
  RVA=0x096BB520  token=0x60003A9  System.Void Init(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
  RVA=0x096BB7F0  token=0x60003AA  System.Void Update()
  RVA=0x096BB794  token=0x60003AB  System.Collections.IEnumerator Submit()
  RVA=0x096BB568  token=0x60003AC  System.Void SetCompletionState(SRDebugger.BugReportSubmitResult result)
  RVA=0x096BB0B8  token=0x60003AD  System.String BuildJsonRequest(SRDebugger.BugReport report)
  RVA=0x096BB234  token=0x60003AE  System.Collections.Generic.List<System.Collections.Generic.List<System.String>> CreateConsoleDump()
  RVA=0x0426FE60  token=0x60003AF  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.BugReportScreenshotUtil
TYPE:  class
TOKEN: 0x2000093
SIZE:  0x10
FIELDS:
  public    static  System.Byte[]                   ScreenshotData  // static @ 0x0
METHODS:
  RVA=0x096BB860  token=0x60003B6  System.Collections.IEnumerator ScreenshotCaptureCo()
  RVA=0x0350B670  token=0x60003B7  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.InternalBugReporterHandler
TYPE:  class
TOKEN: 0x2000095
SIZE:  0x10
IMPLEMENTS: SRDebugger.IBugReporterHandler
FIELDS:
PROPERTIES:
  IsUsable  get=0x096BCE4C
METHODS:
  RVA=0x096BCDF8  token=0x60003BF  System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress)
  RVA=0x0350B670  token=0x60003C0  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.InternalOptionsRegistry
TYPE:  sealed class
TOKEN: 0x2000096
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<System.Object>_registeredContainers  // 0x10
  private           System.Action<System.Object>    _handler  // 0x18
METHODS:
  RVA=0x026CCCF0  token=0x60003C1  System.Void AddOptionContainer(System.Object obj)
  RVA=0x026CBDD0  token=0x60003C2  System.Void SetHandler(System.Action<System.Object> action)
  RVA=0x03CFD4F0  token=0x60003C3  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Internal.OptionControlFactory
TYPE:  static class
TOKEN: 0x2000097
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.IList<SRDebugger.UI.Controls.DataBoundControl>_dataControlPrefabs  // static @ 0x0
  private   static  SRDebugger.UI.Controls.Data.ActionControl_actionControlPrefab  // static @ 0x8
  private   static readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionControlFactory.OptionType,SRDebugger.UI.Controls.DataBoundControl>TypeCache  // static @ 0x10
METHODS:
  RVA=0x096BDEE4  token=0x60003C4  System.Boolean CanCreateControl(SRDebugger.OptionDefinition from)
  RVA=0x096BE08C  token=0x60003C5  SRDebugger.UI.Controls.OptionsControlBase CreateControl(SRDebugger.OptionDefinition from, System.String categoryPrefix)
  RVA=0x096BE45C  token=0x60003C6  System.Void PopulateDataControlPrefabs()
  RVA=0x096BDF8C  token=0x60003C7  SRDebugger.UI.Controls.Data.ActionControl CreateActionControl(SRDebugger.OptionDefinition from, System.String categoryPrefix)
  RVA=0x096BE178  token=0x60003C8  SRDebugger.UI.Controls.DataBoundControl CreateDataControl(SRDebugger.OptionDefinition from, System.String categoryPrefix)
  RVA=0x096BE628  token=0x60003C9  SRDebugger.UI.Controls.DataBoundControl TryGetDataControlPrefab(SRDebugger.OptionDefinition from)
  RVA=0x096BE804  token=0x60003CA  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.Internal.SRDebugPaths
TYPE:  static class
TOKEN: 0x200009A
SIZE:  0x10
FIELDS:
  public    static  System.String                   DataControlsResourcesPath  // const
  public    static  System.String                   TriggerPrefabPath  // const
  public    static  System.String                   DebugPanelPrefabPath  // const
  public    static  System.String                   PinnedUIPrefabPath  // const
  public    static  System.String                   DockConsolePrefabPath  // const
  public    static  System.String                   PinEntryPrefabPath  // const
  public    static  System.String                   BugReportPopoverPath  // const
  public    static  System.String                   BugReportSheetPath  // const
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.Service
TYPE:  static class
TOKEN: 0x200009B
SIZE:  0x10
FIELDS:
  private   static  SRDebugger.Services.IConsoleService_consoleService  // static @ 0x0
  private   static  SRDebugger.Services.IDebugPanelService_debugPanelService  // static @ 0x8
  private   static  SRDebugger.Services.IDebugTriggerService_debugTriggerService  // static @ 0x10
  private   static  SRDebugger.Services.IPinnedUIService_pinnedUiService  // static @ 0x18
  private   static  SRDebugger.Services.IDebugCameraService_debugCameraService  // static @ 0x20
  private   static  SRDebugger.Services.IOptionsService_optionsService  // static @ 0x28
  private   static  SRDebugger.Services.IDockConsoleService_dockConsoleService  // static @ 0x30
PROPERTIES:
  Console  get=0x096C3564
  DockConsole  get=0x096C36AC
  Panel  get=0x096C37FC
  Trigger  get=0x096C394C
  PinnedUI  get=0x096C38A4
  DebugCamera  get=0x096C3604
  Options  get=0x096C3754
METHODS:
END_CLASS

CLASS: SRDebugger.Internal.SRDebugStrings
TYPE:  class
TOKEN: 0x200009C
SIZE:  0x50
FIELDS:
  public    static readonly SRDebugger.Internal.SRDebugStringsCurrent  // static @ 0x0
  public    readonly System.String                   Console_MessageTruncated  // 0x10
  public    readonly System.String                   Console_NoStackTrace  // 0x18
  public    readonly System.String                   PinEntryPrompt  // 0x20
  public    readonly System.String                   Profiler_DisableProfilerInfo  // 0x28
  public    readonly System.String                   Profiler_EnableProfilerInfo  // 0x30
  public    readonly System.String                   Profiler_NoProInfo  // 0x38
  public    readonly System.String                   Profiler_NotSupported  // 0x40
  public    readonly System.String                   ProfilerCameraListenerHelp  // 0x48
METHODS:
  RVA=0x096C3070  token=0x60003D8  System.Void .ctor()
  RVA=0x096C3000  token=0x60003D9  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.Internal.SRDebuggerUtil
TYPE:  static class
TOKEN: 0x200009D
SIZE:  0x10
FIELDS:
PROPERTIES:
  IsMobilePlatform  get=0x096C3538
METHODS:
  RVA=0x096C33DC  token=0x60003DB  System.Boolean EnsureEventSystemExists()
  RVA=0x096C32DC  token=0x60003DC  System.Void CreateDefaultEventSystem()
  RVA=0x096C3190  token=0x60003DD  System.Void AddInputSystem(UnityEngine.GameObject go)
  RVA=0x096C31F0  token=0x60003DE  System.Void AddLegacyInputSystem(UnityEngine.GameObject go)
  RVA=0x02678EF0  token=0x60003DF  System.Collections.Generic.List<SRDebugger.OptionDefinition> ScanForOptions(System.Object obj)
  RVA=0x096C3514  token=0x60003E0  System.String GetNumberString(System.Int32 value, System.Int32 max, System.String exceedsMaxString)
  RVA=0x096C3234  token=0x60003E1  System.Void ConfigureCanvas(UnityEngine.Canvas canvas)
END_CLASS

CLASS: SRDebugger.Profiler.ProfilerLateUpdateListener
TYPE:  class
TOKEN: 0x200008B
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Action                   OnLateUpdate  // 0x18
METHODS:
  RVA=0x03180DF0  token=0x6000382  System.Void LateUpdate()
  RVA=0x0426FE60  token=0x6000383  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Profiler.ProfilerServiceImpl
TYPE:  class
TOKEN: 0x200008C
SIZE:  0x88
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRDebugger.Services.IProfilerService
FIELDS:
  private           System.Single                   <AverageFrameTime>k__BackingField  // 0x48
  private           System.Single                   <LastFrameTime>k__BackingField  // 0x4c
  private   static  System.Int32                    FrameBufferSize  // const
  private   readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>_frameBuffer  // 0x50
  private           SRDebugger.Profiler.ProfilerLateUpdateListener_lateUpdateListener  // 0x58
  private   readonly System.Diagnostics.Stopwatch    _stopwatch  // 0x60
  private           System.Double                   _updateDuration  // 0x68
  private           System.Double                   _renderStartTime  // 0x70
  private           System.Double                   _renderDuration  // 0x78
  private           System.Int32                    _camerasThisFrame  // 0x80
PROPERTIES:
  AverageFrameTime  get=0x03D58370  set=0x03D5BE60
  LastFrameTime  get=0x03D50200  set=0x03D5E680
  FrameBuffer  get=0x03D4EAF0
METHODS:
  RVA=0x096C077C  token=0x6000389  System.Void Awake()
  RVA=0x096C0D38  token=0x600038A  System.Void Update()
  RVA=0x096C0C9C  token=0x600038B  System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime)
  RVA=0x096C0C2C  token=0x600038C  System.Void OnLateUpdate()
  RVA=0x096C0BAC  token=0x600038D  System.Void OnCameraPreRender(UnityEngine.Camera cam)
  RVA=0x096C0B38  token=0x600038E  System.Void OnCameraPostRender(UnityEngine.Camera cam)
  RVA=0x096C0A80  token=0x600038F  System.Void EndFrame()
  RVA=0x096C0EBC  token=0x6000390  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Profiler.SRPProfilerService
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x80
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRDebugger.Services.IProfilerService
FIELDS:
  private           System.Single                   <AverageFrameTime>k__BackingField  // 0x48
  private           System.Single                   <LastFrameTime>k__BackingField  // 0x4c
  private   static  System.Int32                    FrameBufferSize  // const
  private   readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>_frameBuffer  // 0x50
  private           SRDebugger.Profiler.ProfilerLateUpdateListener_lateUpdateListener  // 0x58
  private           System.Double                   _updateDuration  // 0x60
  private           System.Double                   _renderStartTime  // 0x68
  private           System.Double                   _renderDuration  // 0x70
  private   readonly System.Diagnostics.Stopwatch    _stopwatch  // 0x78
PROPERTIES:
  AverageFrameTime  get=0x03D58370  set=0x03D5BE60
  LastFrameTime  get=0x03D50200  set=0x03D5E680
  FrameBuffer  get=0x03D4EAF0
METHODS:
  RVA=0x0268DBE0  token=0x6000396  System.Void Awake()
  RVA=0x0233A400  token=0x6000397  System.Void Update()
  RVA=0x0268DDD0  token=0x6000398  System.Collections.IEnumerator EndOfFrameCoroutine()
  RVA=0x0233AD50  token=0x6000399  System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime)
  RVA=0x0233ABC0  token=0x600039A  System.Void OnLateUpdate()
  RVA=0x0233AEA0  token=0x600039B  System.Void RenderPipelineOnBeginFrameRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  RVA=0x0233A9E0  token=0x600039C  System.Void EndFrame()
  RVA=0x03C92F70  token=0x600039D  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Scripts.DebuggerTabController
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x70
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           SRDebugger.UI.Other.SRTab       _aboutTabInstance  // 0x48
  private           System.Nullable<SRDebugger.DefaultTabs>_activeTab  // 0x50
  private           System.Boolean                  _hasStarted  // 0x58
  public            SRDebugger.UI.Other.SRTab       AboutTab  // 0x60
  public            SRDebugger.UI.Other.SRTabControllerTabController  // 0x68
PROPERTIES:
  ActiveTab  get=0x096AF248
METHODS:
  RVA=0x096AEE6C  token=0x60000AC  System.Void Start()
  RVA=0x096AEC08  token=0x60000AD  System.Boolean OpenTab(SRDebugger.DefaultTabs tab)
  RVA=0x096AEDFC  token=0x60000AE  System.Void ShowAboutTab()
  RVA=0x0426FE60  token=0x60000AF  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.ConsoleFilterStateService
TYPE:  sealed class
TOKEN: 0x2000061
SIZE:  0x20
FIELDS:
  private           SRDebugger.Services.ConsoleStateChangedEventHandlerFilterStateChange  // 0x10
  private           System.Boolean[]                _states  // 0x18
EVENTS:
  FilterStateChange  add=add_FilterStateChange  remove=remove_FilterStateChange
METHODS:
  RVA=0x096AC33C  token=0x6000230  System.Void .ctor()
  RVA=0x096AC2CC  token=0x6000231  System.Void SetState(UnityEngine.LogType type, System.Boolean newState)
  RVA=0x096AC250  token=0x6000232  System.Boolean GetState(UnityEngine.LogType type)
  RVA=0x096AC28C  token=0x6000233  UnityEngine.LogType GetType(UnityEngine.LogType type)
END_CLASS

CLASS: SRDebugger.Services.BugReportCompleteCallback
TYPE:  sealed class
TOKEN: 0x2000062
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x096AA3C0  token=0x6000234  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000235  System.Void Invoke(System.Boolean didSucceed, System.String errorMessage)
  RVA=0x096AA340  token=0x6000236  System.IAsyncResult BeginInvoke(System.Boolean didSucceed, System.String errorMessage, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000237  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.BugReportProgressCallback
TYPE:  sealed class
TOKEN: 0x2000063
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x07D6D6C4  token=0x6000238  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000239  System.Void Invoke(System.Single progress)
  RVA=0x096AADC8  token=0x600023A  System.IAsyncResult BeginInvoke(System.Single progress, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600023B  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IBugReportService
TYPE:  interface
TOKEN: 0x2000064
FIELDS:
PROPERTIES:
  IsUsable  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600023D  System.Void SetHandler(SRDebugger.IBugReporterHandler handler)
  RVA=-1  // abstract  token=0x600023E  System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progressCallback)
END_CLASS

CLASS: SRDebugger.Services.ConsoleStateChangedEventHandler
TYPE:  sealed class
TOKEN: 0x2000065
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x07A5D00C  token=0x600023F  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000240  System.Void Invoke(UnityEngine.LogType logType, System.Boolean newState)
  RVA=0x096ACCF4  token=0x6000241  System.IAsyncResult BeginInvoke(UnityEngine.LogType logType, System.Boolean newState, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000242  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IConsoleFilterState
TYPE:  interface
TOKEN: 0x2000066
FIELDS:
EVENTS:
  FilterStateChange  add=add_FilterStateChange  remove=remove_FilterStateChange
METHODS:
  RVA=-1  // abstract  token=0x6000245  System.Void SetConsoleFilterState(UnityEngine.LogType logType, System.Boolean enabled)
  RVA=-1  // abstract  token=0x6000246  System.Boolean GetConsoleFilterState(UnityEngine.LogType logType)
END_CLASS

CLASS: SRDebugger.Services.ConsoleUpdatedEventHandler
TYPE:  sealed class
TOKEN: 0x2000067
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0613B2F0  token=0x6000247  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000248  System.Void Invoke(SRDebugger.Services.IConsoleService console)
  RVA=0x0389C3B0  token=0x6000249  System.IAsyncResult BeginInvoke(SRDebugger.Services.IConsoleService console, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600024A  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IConsoleService
TYPE:  interface
TOKEN: 0x2000068
FIELDS:
PROPERTIES:
  CriticalCount  get=-1  // abstract
  ErrorCount  get=-1  // abstract
  WarningCount  get=-1  // abstract
  InfoCount  get=-1  // abstract
  Entries  get=-1  // abstract
  AllEntries  get=-1  // abstract
  LoggingEnabled  get=-1  // abstract  set=-1  // abstract
  LogHandlerIsOverriden  get=-1  // abstract
EVENTS:
  Updated  add=add_Updated  remove=remove_Updated
  Error  add=add_Error  remove=remove_Error
METHODS:
  RVA=-1  // abstract  token=0x6000258  System.Void Clear()
END_CLASS

CLASS: SRDebugger.Services.ConsoleEntry
TYPE:  class
TOKEN: 0x2000069
SIZE:  0x38
FIELDS:
  private   static  System.Int32                    MessagePreviewLength  // const
  private   static  System.Int32                    StackTracePreviewLength  // const
  private           System.String                   _messagePreview  // 0x10
  private           System.String                   _stackTracePreview  // 0x18
  public            System.Int32                    Count  // 0x20
  public            UnityEngine.LogType             LogType  // 0x24
  public            System.String                   Message  // 0x28
  public            System.String                   StackTrace  // 0x30
PROPERTIES:
  MessagePreview  get=0x096AC0D8
  StackTracePreview  get=0x096AC194
METHODS:
  RVA=0x03D58950  token=0x6000259  System.Void .ctor()
  RVA=0x096AC084  token=0x600025A  System.Void .ctor(SRDebugger.Services.ConsoleEntry other)
  RVA=0x096AC024  token=0x600025D  System.Boolean Matches(SRDebugger.Services.ConsoleEntry other)
END_CLASS

CLASS: SRDebugger.Services.IDebugCameraService
TYPE:  interface
TOKEN: 0x200006A
FIELDS:
PROPERTIES:
  Camera  get=-1  // abstract
METHODS:
END_CLASS

CLASS: SRDebugger.Services.IDebugPanelService
TYPE:  interface
TOKEN: 0x200006B
FIELDS:
PROPERTIES:
  IsLoaded  get=-1  // abstract
  IsVisible  get=-1  // abstract  set=-1  // abstract
  ActiveTab  get=-1  // abstract
EVENTS:
  VisibilityChanged  add=add_VisibilityChanged  remove=remove_VisibilityChanged
METHODS:
  RVA=-1  // abstract  token=0x6000265  System.Void Unload()
  RVA=-1  // abstract  token=0x6000266  System.Void OpenTab(SRDebugger.DefaultTabs tab)
END_CLASS

CLASS: SRDebugger.Services.IDebugService
TYPE:  interface
TOKEN: 0x200006C
FIELDS:
PROPERTIES:
  Settings  get=-1  // abstract
  IsDebugPanelVisible  get=-1  // abstract
  IsTriggerEnabled  get=-1  // abstract  set=-1  // abstract
  IsTriggerErrorNotificationEnabled  get=-1  // abstract  set=-1  // abstract
  DockConsole  get=-1  // abstract
  ConsoleFilter  get=-1  // abstract
  IsProfilerDocked  get=-1  // abstract  set=-1  // abstract
EVENTS:
  PanelVisibilityChanged  add=add_PanelVisibilityChanged  remove=remove_PanelVisibilityChanged
  PinnedUiCanvasCreated  add=add_PinnedUiCanvasCreated  remove=remove_PinnedUiCanvasCreated
METHODS:
  RVA=-1  // abstract  token=0x6000271  System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category)
  RVA=-1  // abstract  token=0x6000272  System.Void ShowDebugPanel(System.Boolean requireEntryCode)
  RVA=-1  // abstract  token=0x6000273  System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode)
  RVA=-1  // abstract  token=0x6000274  System.Void HideDebugPanel()
  RVA=-1  // abstract  token=0x6000275  System.Void SetEntryCode(SRDebugger.EntryCode newCode)
  RVA=-1  // abstract  token=0x6000276  System.Void DisableEntryCode()
  RVA=-1  // abstract  token=0x6000277  System.Void DestroyDebugPanel()
  RVA=-1  // abstract  token=0x6000278  System.Void AddOptionContainer(System.Object container)
  RVA=-1  // abstract  token=0x6000279  System.Void RemoveOptionContainer(System.Object container)
  RVA=-1  // abstract  token=0x600027A  System.Void AddOption(SRDebugger.OptionDefinition option)
  RVA=-1  // abstract  token=0x600027B  System.Boolean RemoveOption(SRDebugger.OptionDefinition option)
  RVA=-1  // abstract  token=0x600027C  System.Void PinAllOptions(System.String category)
  RVA=-1  // abstract  token=0x600027D  System.Void UnpinAllOptions(System.String category)
  RVA=-1  // abstract  token=0x600027E  System.Void PinOption(System.String name)
  RVA=-1  // abstract  token=0x600027F  System.Void UnpinOption(System.String name)
  RVA=-1  // abstract  token=0x6000280  System.Void ClearPinnedOptions()
  RVA=-1  // abstract  token=0x6000281  System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent)
  RVA=-1  // abstract  token=0x6000286  UnityEngine.RectTransform EnableWorldSpaceMode()
  RVA=-1  // abstract  token=0x6000287  System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler)
END_CLASS

CLASS: SRDebugger.Services.IDebugTriggerService
TYPE:  interface
TOKEN: 0x200006D
FIELDS:
PROPERTIES:
  IsEnabled  get=-1  // abstract  set=-1  // abstract
  ShowErrorNotification  get=-1  // abstract  set=-1  // abstract
  Position  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: SRDebugger.Services.IDockConsoleService
TYPE:  interface
TOKEN: 0x200006E
FIELDS:
PROPERTIES:
  IsVisible  get=-1  // abstract  set=-1  // abstract
  IsExpanded  get=-1  // abstract  set=-1  // abstract
  Alignment  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: SRDebugger.Services.IOptionsService
TYPE:  interface
TOKEN: 0x200006F
FIELDS:
PROPERTIES:
  Options  get=-1  // abstract
EVENTS:
  OptionsUpdated  add=add_OptionsUpdated  remove=remove_OptionsUpdated
METHODS:
  RVA=-1  // abstract  token=0x6000297  System.Void Scan(System.Object obj)
  RVA=-1  // abstract  token=0x6000298  System.Void AddContainer(System.Object obj)
  RVA=-1  // abstract  token=0x6000299  System.Void AddContainer(SRDebugger.IOptionContainer optionContainer)
  RVA=-1  // abstract  token=0x600029A  System.Void RemoveContainer(System.Object obj)
  RVA=-1  // abstract  token=0x600029B  System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer)
END_CLASS

CLASS: SRDebugger.Services.PinEntryCompleteCallback
TYPE:  sealed class
TOKEN: 0x2000070
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06892B88  token=0x600029C  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600029D  System.Void Invoke(System.Boolean validPinEntered)
  RVA=0x096B5BD4  token=0x600029E  System.IAsyncResult BeginInvoke(System.Boolean validPinEntered, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600029F  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.Services.IPinEntryService
TYPE:  interface
TOKEN: 0x2000071
FIELDS:
PROPERTIES:
  IsShowingKeypad  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60002A1  System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel)
END_CLASS

CLASS: SRDebugger.Services.IPinnedUIService
TYPE:  interface
TOKEN: 0x2000072
FIELDS:
PROPERTIES:
  IsProfilerPinned  get=-1  // abstract  set=-1  // abstract
EVENTS:
  OptionPinStateChanged  add=add_OptionPinStateChanged  remove=remove_OptionPinStateChanged
  OptionsCanvasCreated  add=add_OptionsCanvasCreated  remove=remove_OptionsCanvasCreated
METHODS:
  RVA=-1  // abstract  token=0x60002A8  System.Void Pin(SRDebugger.OptionDefinition option, System.Int32 order)
  RVA=-1  // abstract  token=0x60002A9  System.Void Unpin(SRDebugger.OptionDefinition option)
  RVA=-1  // abstract  token=0x60002AA  System.Void UnpinAll()
  RVA=-1  // abstract  token=0x60002AB  System.Boolean HasPinned(SRDebugger.OptionDefinition option)
END_CLASS

CLASS: SRDebugger.Services.ProfilerServiceSelector
TYPE:  static class
TOKEN: 0x2000073
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02EAA550  token=0x60002AC  System.Type GetProfilerServiceType()
END_CLASS

CLASS: SRDebugger.Services.ProfilerFrame
TYPE:  sealed struct
TOKEN: 0x2000074
SIZE:  0x30
FIELDS:
  public            System.Double                   FrameTime  // 0x10
  public            System.Double                   OtherTime  // 0x18
  public            System.Double                   RenderTime  // 0x20
  public            System.Double                   UpdateTime  // 0x28
METHODS:
END_CLASS

CLASS: SRDebugger.Services.IProfilerService
TYPE:  interface
TOKEN: 0x2000075
FIELDS:
PROPERTIES:
  AverageFrameTime  get=-1  // abstract
  LastFrameTime  get=-1  // abstract
  FrameBuffer  get=-1  // abstract
METHODS:
END_CLASS

CLASS: SRDebugger.Services.ISystemInformationService
TYPE:  interface
TOKEN: 0x2000076
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60002B0  System.Collections.Generic.IEnumerable<System.String> GetCategories()
  RVA=-1  // abstract  token=0x60002B1  System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category)
  RVA=-1  // abstract  token=0x60002B2  System.Void Add(SRDebugger.InfoEntry info, System.String category)
  RVA=-1  // abstract  token=0x60002B3  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate)
END_CLASS

CLASS: SRDebugger.Services.Implementation.BugReportApiService
TYPE:  class
TOKEN: 0x2000077
SIZE:  0x18
IMPLEMENTS: SRDebugger.Services.IBugReportService
FIELDS:
  private           SRDebugger.IBugReporterHandler  _handler  // 0x10
PROPERTIES:
  IsUsable  get=0x096AA328
METHODS:
  RVA=0x096AA21C  token=0x60002B5  System.Void SetHandler(SRDebugger.IBugReporterHandler handler)
  RVA=0x096A9F38  token=0x60002B6  System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progress)
  RVA=0x096AA2D8  token=0x60002B7  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.BugReportPopoverService
TYPE:  class
TOKEN: 0x2000079
SIZE:  0x68
EXTENDS: SRF.Service.SRServiceBase`1
FIELDS:
  private           SRDebugger.Services.BugReportCompleteCallback_callback  // 0x48
  private           System.Boolean                  _isVisible  // 0x50
  private           SRDebugger.UI.Other.BugReportPopoverRoot_popover  // 0x58
  private           SRDebugger.UI.Other.BugReportSheetController_sheet  // 0x60
PROPERTIES:
  IsShowingPopover  get=0x03D4F000
METHODS:
  RVA=0x096AAB60  token=0x60002BB  System.Void ShowBugReporter(SRDebugger.Services.BugReportCompleteCallback callback, System.Boolean takeScreenshotFirst, System.String descriptionText)
  RVA=0x096AAA58  token=0x60002BC  System.Collections.IEnumerator OpenCo(System.Boolean takeScreenshot, System.String descriptionText)
  RVA=0x096AACF8  token=0x60002BD  System.Void SubmitComplete(System.Boolean didSucceed, System.String errorMessage)
  RVA=0x096AA51C  token=0x60002BE  System.Void CancelPressed()
  RVA=0x096AA8F4  token=0x60002BF  System.Void OnComplete(System.Boolean success, System.String errorMessage, System.Boolean close)
  RVA=0x096AAD14  token=0x60002C0  System.Void TakingScreenshot()
  RVA=0x096AAADC  token=0x60002C1  System.Void ScreenshotComplete()
  RVA=0x096AA488  token=0x60002C2  System.Void Awake()
  RVA=0x096AA564  token=0x60002C3  System.Void Load()
  RVA=0x096AAD94  token=0x60002C4  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DebugCameraServiceImpl
TYPE:  class
TOKEN: 0x200007B
SIZE:  0x18
IMPLEMENTS: SRDebugger.Services.IDebugCameraService
FIELDS:
  private           UnityEngine.Camera              _debugCamera  // 0x10
PROPERTIES:
  Camera  get=0x020B7B20
METHODS:
  RVA=0x096BB8A4  token=0x60002CB  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DebugPanelServiceImpl
TYPE:  class
TOKEN: 0x200007C
SIZE:  0x38
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: SRDebugger.Services.IDebugPanelService System.IDisposable
FIELDS:
  private           SRDebugger.UI.DebugPanelRoot    _debugPanelRootObject  // 0x18
  private           System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean>VisibilityChanged  // 0x20
  private           System.Boolean                  _isVisible  // 0x28
  private           System.Nullable<System.Boolean> _cursorWasVisible  // 0x29
  private           System.Nullable<UnityEngine.CursorLockMode>_cursorLockMode  // 0x2c
PROPERTIES:
  RootObject  get=0x01041090
  IsLoaded  get=0x096BBDBC
  IsVisible  get=0x096BBE0C  set=0x096BBEB8
  ActiveTab  get=0x096BBD44
EVENTS:
  VisibilityChanged  add=add_VisibilityChanged  remove=remove_VisibilityChanged
METHODS:
  RVA=0x096BBC2C  token=0x60002D4  System.Void OpenTab(SRDebugger.DefaultTabs tab)
  RVA=0x096BBC80  token=0x60002D5  System.Void Unload()
  RVA=0x096BBAA4  token=0x60002D6  System.Void Load()
  RVA=0x096BBA20  token=0x60002D7  System.Void Dispose()
  RVA=0x0286F540  token=0x60002D8  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DebugTriggerImpl
TYPE:  class
TOKEN: 0x200007D
SIZE:  0x68
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRDebugger.Services.IDebugTriggerService
FIELDS:
  private           SRDebugger.PinAlignment         _position  // 0x48
  private           SRDebugger.UI.Other.TriggerRoot _trigger  // 0x50
  private           SRDebugger.Services.IConsoleService_consoleService  // 0x58
  private           System.Boolean                  _showErrorNotification  // 0x60
PROPERTIES:
  IsEnabled  get=0x096BC8D8  set=0x026CCB80
  ShowErrorNotification  get=0x03D519A0  set=0x03CB4A10
  Position  get=0x03D4EC50  set=0x026CCC00
METHODS:
  RVA=0x0268DA20  token=0x60002DF  System.Void Awake()
  RVA=0x096BC6F4  token=0x60002E0  System.Void OnError(SRDebugger.Services.IConsoleService console)
  RVA=0x096BC1C8  token=0x60002E1  System.Void CreateTrigger()
  RVA=0x096BC5E4  token=0x60002E2  System.Void OnDestroy()
  RVA=0x096BC5DC  token=0x60002E3  System.Void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2)
  RVA=0x096BC768  token=0x60002E4  System.Void OnTriggerButtonClick()
  RVA=0x096BC7F8  token=0x60002E5  System.Void SetTriggerPosition(UnityEngine.RectTransform t, SRDebugger.PinAlignment position)
  RVA=0x03D416A0  token=0x60002E6  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.DockConsoleServiceImpl
TYPE:  class
TOKEN: 0x200007E
SIZE:  0x28
IMPLEMENTS: SRDebugger.Services.IDockConsoleService
FIELDS:
  private           SRDebugger.ConsoleAlignment     _alignment  // 0x10
  private           SRDebugger.UI.Other.DockConsoleController_consoleRoot  // 0x18
  private           System.Boolean                  _didSuspendTrigger  // 0x20
  private           System.Boolean                  _isExpanded  // 0x21
  private           System.Boolean                  _isVisible  // 0x22
PROPERTIES:
  IsVisible  get=0x03D4F740  set=0x096BCD4C
  IsExpanded  get=0x03D4F070  set=0x096BCCAC
  Alignment  get=0x03D4E340  set=0x096BCC24
METHODS:
  RVA=0x096BCBF4  token=0x60002E7  System.Void .ctor()
  RVA=0x096BCA8C  token=0x60002EE  System.Void Load()
  RVA=0x096BC954  token=0x60002EF  System.Void CheckTrigger()
END_CLASS

CLASS: SRDebugger.Services.Implementation.KeyboardShortcutListenerService
TYPE:  class
TOKEN: 0x200007F
SIZE:  0x50
EXTENDS: SRF.Service.SRServiceBase`1
FIELDS:
  private           System.Collections.Generic.List<SRDebugger.Settings.KeyboardShortcut>_shortcuts  // 0x48
METHODS:
  RVA=0x096BCE8C  token=0x60002F0  System.Void Awake()
  RVA=0x096BD5D0  token=0x60002F1  System.Void ToggleTab(SRDebugger.DefaultTabs t)
  RVA=0x096BD2EC  token=0x60002F2  System.Void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut)
  RVA=0x096BDB24  token=0x60002F3  System.Void Update()
  RVA=0x096BD6F0  token=0x60002F4  System.Void UpdateInputSystem()
  RVA=0x096BD97C  token=0x60002F5  System.Void UpdateLegacyInputSystem()
  RVA=0x096BDB6C  token=0x60002F6  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.OptionsServiceImpl
TYPE:  sealed class
TOKEN: 0x2000080
SIZE:  0x38
IMPLEMENTS: SRDebugger.Services.IOptionsService
FIELDS:
  private           System.EventHandler             OptionsUpdated  // 0x10
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,System.Collections.Generic.List<SRDebugger.OptionDefinition>>_optionContainerLookup  // 0x18
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,SRDebugger.Services.Implementation.OptionsServiceImpl.OptionContainerEventHandler>_optionContainerEventHandlerLookup  // 0x20
  private   readonly System.Collections.Generic.List<SRDebugger.OptionDefinition>_options  // 0x28
  private   readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition>_optionsReadonly  // 0x30
PROPERTIES:
  Options  get=0x01003830
EVENTS:
  OptionsUpdated  add=add_OptionsUpdated  remove=remove_OptionsUpdated
METHODS:
  RVA=0x096BEA48  token=0x60002FA  System.Void OptionsContainerOnOptionAdded(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition)
  RVA=0x096BEB8C  token=0x60002FB  System.Void OptionsContainerOnOptionRemoved(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition)
  RVA=0x0386F070  token=0x60002FC  System.Void .ctor()
  RVA=0x096BEFCC  token=0x60002FD  System.Void Scan(System.Object obj)
  RVA=0x0386EFE0  token=0x60002FE  System.Void AddContainer(System.Object obj)
  RVA=0x0386F1E0  token=0x60002FF  System.Void AddContainer(SRDebugger.IOptionContainer optionContainer)
  RVA=0x096BECA4  token=0x6000300  System.Void RemoveContainer(System.Object obj)
  RVA=0x096BED40  token=0x6000301  System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer)
  RVA=0x096BE9DC  token=0x6000302  System.Void OnOptionsUpdated()
END_CLASS

CLASS: SRDebugger.Services.Implementation.PinEntryServiceImpl
TYPE:  class
TOKEN: 0x2000083
SIZE:  0x68
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRDebugger.Services.IPinEntryService
FIELDS:
  private           SRDebugger.Services.PinEntryCompleteCallback_callback  // 0x48
  private           System.Boolean                  _isVisible  // 0x50
  private           SRDebugger.UI.Controls.PinEntryControl_pinControl  // 0x58
  private   readonly System.Collections.Generic.List<System.Int32>_requiredPin  // 0x60
PROPERTIES:
  IsShowingKeypad  get=0x03D4F000
METHODS:
  RVA=0x096BF3E0  token=0x6000313  System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel)
  RVA=0x096BF0FC  token=0x6000314  System.Void Awake()
  RVA=0x096BF190  token=0x6000315  System.Void Load()
  RVA=0x096BF31C  token=0x6000316  System.Void PinControlOnComplete(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel)
  RVA=0x096BF600  token=0x6000317  System.Void VerifyPin(System.Collections.Generic.IReadOnlyList<System.Int32> pin)
  RVA=0x096BF75C  token=0x6000318  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.PinnedUIServiceImpl
TYPE:  class
TOKEN: 0x2000084
SIZE:  0x78
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRDebugger.Services.IPinnedUIService
FIELDS:
  private   readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>_controlList  // 0x48
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase>_pinnedObjects  // 0x50
  private           System.Boolean                  _queueRefresh  // 0x58
  private           SRDebugger.UI.Other.PinnedUIRoot_uiRoot  // 0x60
  private           System.Action<SRDebugger.OptionDefinition,System.Boolean>OptionPinStateChanged  // 0x68
  private           System.Action<UnityEngine.RectTransform>OptionsCanvasCreated  // 0x70
PROPERTIES:
  DockConsoleController  get=0x096C04E8
  IsProfilerPinned  get=0x096C055C  set=0x096C06EC
EVENTS:
  OptionPinStateChanged  add=add_OptionPinStateChanged  remove=remove_OptionPinStateChanged
  OptionsCanvasCreated  add=add_OptionsCanvasCreated  remove=remove_OptionsCanvasCreated
METHODS:
  RVA=0x096BFC98  token=0x6000320  System.Void Pin(SRDebugger.OptionDefinition obj, System.Int32 order)
  RVA=0x096C0060  token=0x6000321  System.Void Unpin(SRDebugger.OptionDefinition obj)
  RVA=0x096BFC84  token=0x6000322  System.Void OnPinnedStateChanged(SRDebugger.OptionDefinition option, System.Boolean isPinned)
  RVA=0x096BFEA8  token=0x6000323  System.Void UnpinAll()
  RVA=0x096BF7EC  token=0x6000324  System.Boolean HasPinned(SRDebugger.OptionDefinition option)
  RVA=0x0268DB40  token=0x6000325  System.Void Awake()
  RVA=0x096BF840  token=0x6000326  System.Void Load()
  RVA=0x096C0184  token=0x6000327  System.Void UpdateAnchors()
  RVA=0x03336BB0  token=0x6000328  System.Void Update()
  RVA=0x096BFADC  token=0x6000329  System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs)
  RVA=0x096BFAD0  token=0x600032A  System.Void OnDebugPanelVisibilityChanged(System.Boolean isVisible)
  RVA=0x096BFE28  token=0x600032B  System.Void Refresh()
  RVA=0x03C813B0  token=0x600032C  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.Services.Implementation.SRDebugService
TYPE:  class
TOKEN: 0x2000085
SIZE:  0x80
IMPLEMENTS: SRDebugger.Services.IDebugService
FIELDS:
  private           SRDebugger.VisibilityChangedDelegatePanelVisibilityChanged  // 0x10
  private           SRDebugger.PinnedUiCanvasCreatedPinnedUiCanvasCreated  // 0x18
  private   readonly SRDebugger.Services.IDebugPanelService_debugPanelService  // 0x20
  private   readonly SRDebugger.Services.IDebugTriggerService_debugTrigger  // 0x28
  private   readonly SRDebugger.Services.ISystemInformationService_informationService  // 0x30
  private   readonly SRDebugger.Services.IOptionsService_optionsService  // 0x38
  private   readonly SRDebugger.Services.IPinnedUIService_pinnedUiService  // 0x40
  private           SRDebugger.Services.IConsoleFilterState_consoleFilterState  // 0x48
  private           System.Nullable<SRDebugger.EntryCode>_entryCode  // 0x50
  private           System.Boolean                  _hasAuthorised  // 0x64
  private           System.Nullable<SRDebugger.DefaultTabs>_queuedTab  // 0x68
  private           UnityEngine.RectTransform       _worldSpaceTransform  // 0x70
  private           SRDebugger.DynamicOptionContainer_looseOptionContainer  // 0x78
PROPERTIES:
  DockConsole  get=0x096C2CA8
  ConsoleFilter  get=0x096C2C40
  Settings  get=0x042713D4
  IsDebugPanelVisible  get=0x096C2CB0
  IsTriggerEnabled  get=0x096C2D40  set=0x096C2F68
  IsTriggerErrorNotificationEnabled  get=0x096C2D5C  set=0x096C2F84
  IsProfilerDocked  get=0x096C2CCC  set=0x096C2EE4
EVENTS:
  PanelVisibilityChanged  add=add_PanelVisibilityChanged  remove=remove_PanelVisibilityChanged
  PinnedUiCanvasCreated  add=add_PinnedUiCanvasCreated  remove=remove_PinnedUiCanvasCreated
METHODS:
  RVA=0x026CD3E0  token=0x6000333  System.Void .ctor()
  RVA=0x096C1988  token=0x600033C  System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category)
  RVA=0x096C2668  token=0x600033D  System.Void ShowDebugPanel(System.Boolean requireEntryCode)
  RVA=0x096C2574  token=0x600033E  System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode)
  RVA=0x096C1DF4  token=0x600033F  System.Void HideDebugPanel()
  RVA=0x096C23F4  token=0x6000340  System.Void SetEntryCode(SRDebugger.EntryCode newCode)
  RVA=0x03D751B0  token=0x6000341  System.Void DisableEntryCode()
  RVA=0x096C1B48  token=0x6000342  System.Void DestroyDebugPanel()
  RVA=0x096C1810  token=0x6000343  System.Void AddOptionContainer(System.Object container)
  RVA=0x096C22A8  token=0x6000344  System.Void RemoveOptionContainer(System.Object container)
  RVA=0x096C188C  token=0x6000345  System.Void AddOption(SRDebugger.OptionDefinition option)
  RVA=0x096C2324  token=0x6000346  System.Boolean RemoveOption(SRDebugger.OptionDefinition option)
  RVA=0x096C1E14  token=0x6000347  System.Void PinAllOptions(System.String category)
  RVA=0x096C2830  token=0x6000348  System.Void UnpinAllOptions(System.String category)
  RVA=0x096C1F88  token=0x6000349  System.Void PinOption(System.String name)
  RVA=0x096C29A4  token=0x600034A  System.Void UnpinOption(System.String name)
  RVA=0x096C1A0C  token=0x600034B  System.Void ClearPinnedOptions()
  RVA=0x096C2458  token=0x600034C  System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent)
  RVA=0x096C1A78  token=0x600034D  System.Void DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b)
  RVA=0x096C20FC  token=0x600034E  System.Void PromptEntryCode()
  RVA=0x096C1BC8  token=0x600034F  UnityEngine.RectTransform EnableWorldSpaceMode()
  RVA=0x096C233C  token=0x6000350  System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler)
  RVA=0x096C277C  token=0x6000351  System.Void <.ctor>b__21_0(UnityEngine.RectTransform transform)
  RVA=0x096C26D4  token=0x6000352  System.Void <PromptEntryCode>b__53_0(System.Boolean entered)
END_CLASS

CLASS: SRDebugger.Services.Implementation.StandardConsoleService
TYPE:  class
TOKEN: 0x2000087
SIZE:  0x58
IMPLEMENTS: SRDebugger.Services.IConsoleService System.IDisposable
FIELDS:
  private   readonly System.Boolean                  _collapseEnabled  // 0x10
  private           System.Boolean                  _hasCleared  // 0x11
  private   readonly SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry>_allConsoleEntries  // 0x18
  private           SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry>_consoleEntries  // 0x20
  private   readonly System.Object                   _threadLock  // 0x28
  private           UnityEngine.ILogHandler         _expectedLogHandler  // 0x30
  private           System.Int32                    <CriticalCount>k__BackingField  // 0x38
  private           System.Int32                    <ErrorCount>k__BackingField  // 0x3c
  private           System.Int32                    <WarningCount>k__BackingField  // 0x40
  private           System.Int32                    <InfoCount>k__BackingField  // 0x44
  private           SRDebugger.Services.ConsoleUpdatedEventHandlerUpdated  // 0x48
  private           SRDebugger.Services.ConsoleUpdatedEventHandlerError  // 0x50
PROPERTIES:
  CriticalCount  get=0x03D4EC30  set=0x03D4ECB0
  ErrorCount  get=0x03D4ED90  set=0x03D4EDC0
  WarningCount  get=0x03D4ED80  set=0x03D4EDB0
  InfoCount  get=0x03D4EE80  set=0x03D4EEA0
  LoggingEnabled  get=0x096C4128  set=0x096C42A4
  LogHandlerIsOverriden  get=0x096C40D0
  Entries  get=0x096C40C0
  AllEntries  get=0x01041090
EVENTS:
  Updated  add=add_Updated  remove=remove_Updated
  Error  add=add_Error  remove=remove_Error
METHODS:
  RVA=0x0267B700  token=0x6000355  System.Void .ctor()
  RVA=0x096C3C2C  token=0x6000356  System.Void Dispose()
  RVA=0x096C3A6C  token=0x6000368  System.Void Clear()
  RVA=0x096C3CE0  token=0x6000369  System.Void OnEntryAdded(SRDebugger.Services.ConsoleEntry entry)
  RVA=0x096C3E50  token=0x600036A  System.Void OnEntryDuplicated(SRDebugger.Services.ConsoleEntry entry)
  RVA=0x096C3F04  token=0x600036B  System.Void OnUpdated()
  RVA=0x0350B670  token=0x600036C  System.Void UnityLogCallback(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  RVA=0x096C39F4  token=0x600036D  System.Void AdjustCounter(UnityEngine.LogType type, System.Int32 amount)
END_CLASS

CLASS: SRDebugger.Services.Implementation.StandardSystemInformationService
TYPE:  class
TOKEN: 0x2000088
SIZE:  0x18
IMPLEMENTS: SRDebugger.Services.ISystemInformationService
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.IList<SRDebugger.InfoEntry>>_info  // 0x10
METHODS:
  RVA=0x03CF21E0  token=0x600036E  System.Void .ctor()
  RVA=0x096C4954  token=0x600036F  System.Collections.Generic.IEnumerable<System.String> GetCategories()
  RVA=0x096C4AF0  token=0x6000370  System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category)
  RVA=0x096C4340  token=0x6000371  System.Void Add(SRDebugger.InfoEntry info, System.String category)
  RVA=0x096C454C  token=0x6000372  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate)
  RVA=0x0315D380  token=0x6000373  System.Void CreateDefaultSet()
  RVA=0x096C499C  token=0x6000374  System.String GetCloudManifestPrettyName(System.String name)
END_CLASS

CLASS: SRDebugger.UI.ProfilerFPSLabel
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x68
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _nextUpdate  // 0x48
  private           SRDebugger.Services.IProfilerService_profilerService  // 0x50
  public            System.Single                   UpdateFrequency  // 0x58
  private           UnityEngine.UI.Text             _text  // 0x60
METHODS:
  RVA=0x096B6AA0  token=0x60000B0  System.Void Update()
  RVA=0x096B6994  token=0x60000B1  System.Void Refresh()
  RVA=0x096B6ACC  token=0x60000B2  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.DebugPanelRoot
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x60
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Canvas              Canvas  // 0x48
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x50
  public            SRDebugger.Scripts.DebuggerTabControllerTabController  // 0x58
METHODS:
  RVA=0x096AEB74  token=0x60000B3  System.Void Close()
  RVA=0x096AEB18  token=0x60000B4  System.Void CloseAndDestroy()
  RVA=0x0426FE60  token=0x60000B5  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.MobileMenuController
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x80
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           UnityEngine.UI.Button           _closeButton  // 0x48
  private           System.Single                   _maxMenuWidth  // 0x50
  private           System.Single                   _peekAmount  // 0x54
  private           System.Single                   _targetXPosition  // 0x58
  public            UnityEngine.RectTransform       Content  // 0x60
  public            UnityEngine.RectTransform       Menu  // 0x68
  public            UnityEngine.UI.Button           OpenButton  // 0x70
  public            SRDebugger.UI.Other.SRTabControllerTabController  // 0x78
PROPERTIES:
  PeekAmount  get=0x03D4F670
  MaxMenuWidth  get=0x03D51C90
METHODS:
  RVA=0x096B2288  token=0x60000B8  System.Void OnEnable()
  RVA=0x096B2150  token=0x60000B9  System.Void OnDisable()
  RVA=0x096B1D9C  token=0x60000BA  System.Void CreateCloseButton()
  RVA=0x096B255C  token=0x60000BB  System.Void SetRectSize(UnityEngine.RectTransform rect)
  RVA=0x096B1D5C  token=0x60000BC  System.Void CloseButtonClicked()
  RVA=0x096B2610  token=0x60000BD  System.Void Update()
  RVA=0x096B1D5C  token=0x60000BE  System.Void TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab)
  RVA=0x096B2504  token=0x60000BF  System.Void Open()
  RVA=0x096B1D64  token=0x60000C0  System.Void Close()
  RVA=0x096B2700  token=0x60000C1  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ConsoleEntryView
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x88
EXTENDS: SRF.SRMonoBehaviourEx
IMPLEMENTS: SRF.UI.Layout.IVirtualView
FIELDS:
  public    static  System.String                   ConsoleBlobInfo  // const
  public    static  System.String                   ConsoleBlobWarning  // const
  public    static  System.String                   ConsoleBlobError  // const
  public    static  System.String                   ConsoleBlobCritical  // const
  private           System.Int32                    _count  // 0x48
  private           System.Boolean                  _hasCount  // 0x4c
  private           SRDebugger.Services.ConsoleEntry_prevData  // 0x50
  private           UnityEngine.RectTransform       _rectTransform  // 0x58
  public            UnityEngine.UI.Text             Count  // 0x60
  public            UnityEngine.CanvasGroup         CountContainer  // 0x68
  public            SRF.UI.StyleComponent           ImageStyle  // 0x70
  public            UnityEngine.UI.Text             Message  // 0x78
  public            UnityEngine.UI.Text             StackTrace  // 0x80
METHODS:
  RVA=0x096ABCE8  token=0x6000189  System.Void SetDataContext(System.Object data)
  RVA=0x096ABC44  token=0x600018A  System.Void Awake()
  RVA=0x0426FE60  token=0x600018B  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ConsoleLogControl
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x80
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           SRF.UI.Layout.VirtualVerticalLayoutGroup_consoleScrollLayoutGroup  // 0x48
  private           UnityEngine.UI.ScrollRect       _consoleScrollRect  // 0x50
  private           System.Boolean                  _isDirty  // 0x58
  private           System.Nullable<UnityEngine.Vector2>_scrollPosition  // 0x5c
  private           System.Boolean                  _showCriticals  // 0x68
  private           System.Boolean                  _showErrors  // 0x69
  private           System.Boolean                  _showInfo  // 0x6a
  private           System.Boolean                  _showWarnings  // 0x6b
  public            System.Action<SRDebugger.Services.ConsoleEntry>SelectedItemChanged  // 0x70
  private           System.String                   _filter  // 0x78
PROPERTIES:
  ShowCriticals  get=0x03D4F3F0  set=0x03D75140
  ShowErrors  get=0x03D4F3C0  set=0x03D75150
  ShowWarnings  get=0x03D75130  set=0x03D75170
  ShowInfo  get=0x03D75120  set=0x03D75160
  EnableSelection  get=0x096ACC78  set=0x096ACC98
  Filter  get=0x03D4EB20  set=0x096ACCB8
METHODS:
  RVA=0x096AC75C  token=0x6000198  System.Void Awake()
  RVA=0x096ACBB4  token=0x6000199  System.Void Start()
  RVA=0x096ACB58  token=0x600019A  System.Collections.IEnumerator ScrollToBottom()
  RVA=0x096AC874  token=0x600019B  System.Void OnDestroy()
  RVA=0x096AC914  token=0x600019C  System.Void OnSelectedItemChanged(System.Object arg0)
  RVA=0x096ACBDC  token=0x600019D  System.Void Update()
  RVA=0x096AC970  token=0x600019E  System.Void Refresh()
  RVA=0x03D72A60  token=0x600019F  System.Void SetIsDirty()
  RVA=0x03D72A60  token=0x60001A0  System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
  RVA=0x096ACC68  token=0x60001A1  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.DataBoundControl
TYPE:  abstract class
TOKEN: 0x200004B
SIZE:  0x80
EXTENDS: SRDebugger.UI.Controls.OptionsControlBase
FIELDS:
  private           System.Boolean                  _hasStarted  // 0x60
  private           System.Boolean                  _isReadOnly  // 0x61
  private           System.Object                   _prevValue  // 0x68
  private           SRF.Helpers.PropertyReference   _prop  // 0x70
  private           System.String                   <PropertyName>k__BackingField  // 0x78
PROPERTIES:
  Property  get=0x03D4EB30
  IsReadOnly  get=0x03D51F90
  PropertyName  get=0x03D4EB20  set=0x051DFCA4
METHODS:
  RVA=0x096AE65C  token=0x60001AC  System.Void Bind(System.String propertyName, SRF.Helpers.PropertyReference prop)
  RVA=0x08250BC4  token=0x60001AD  System.Void OnValueChanged(SRF.Helpers.PropertyReference property)
  RVA=0x096AE9BC  token=0x60001AE  System.Void UpdateValue(System.Object newValue)
  RVA=0x096AE898  token=0x60001AF  System.Void Refresh()
  RVA=0x0350B670  token=0x60001B0  System.Void OnBind(System.String propertyName, System.Type t)
  RVA=-1  // abstract  token=0x60001B1  System.Void OnValueUpdated(System.Object newValue)
  RVA=-1  // abstract  token=0x60001B2  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  RVA=0x096AE99C  token=0x60001B3  System.Void Start()
  RVA=0x096AE7E8  token=0x60001B4  System.Void OnEnable()
  RVA=0x096AE754  token=0x60001B5  System.Void OnDisable()
  RVA=0x0426FE60  token=0x60001B6  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.OptionsControlBase
TYPE:  abstract class
TOKEN: 0x200004C
SIZE:  0x60
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _selectionModeEnabled  // 0x48
  public            UnityEngine.UI.Toggle           SelectionModeToggle  // 0x50
  public            SRDebugger.OptionDefinition     Option  // 0x58
PROPERTIES:
  SelectionModeEnabled  get=0x03D4EFE0  set=0x096B3A08
  IsSelected  get=0x096B3910  set=0x096B3930
METHODS:
  RVA=0x096B3800  token=0x60001BB  System.Void Awake()
  RVA=0x096B3850  token=0x60001BC  System.Void OnEnable()
  RVA=0x0350B670  token=0x60001BD  System.Void Refresh()
  RVA=0x0426FE60  token=0x60001BE  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.InfoBlock
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.UI.Text             Content  // 0x48
  public            UnityEngine.UI.Text             Title  // 0x50
METHODS:
  RVA=0x0426FE60  token=0x60001BF  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.MultiTapButton
TYPE:  class
TOKEN: 0x200004E
SIZE:  0x198
EXTENDS: UnityEngine.UI.Button
FIELDS:
  private           System.Single                   _lastTap  // 0x188
  private           System.Int32                    _tapCount  // 0x18c
  public            System.Int32                    RequiredTapCount  // 0x190
  public            System.Single                   ResetTime  // 0x194
METHODS:
  RVA=0x096B2718  token=0x60001C0  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096B278C  token=0x60001C1  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.PinEntryControlCallback
TYPE:  sealed class
TOKEN: 0x200004F
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06DE9D50  token=0x60001C2  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x60001C3  System.Void Invoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel)
  RVA=0x096B5C4C  token=0x60001C4  System.IAsyncResult BeginInvoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x60001C5  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRDebugger.UI.Controls.PinEntryControl
TYPE:  class
TOKEN: 0x2000050
SIZE:  0xA8
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _isVisible  // 0x48
  private           System.Collections.Generic.List<System.Int32>_numbers  // 0x50
  public            UnityEngine.UI.Image            Background  // 0x58
  public            System.Boolean                  CanCancel  // 0x60
  public            UnityEngine.UI.Button           CancelButton  // 0x68
  public            UnityEngine.UI.Text             CancelButtonText  // 0x70
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x78
  public            UnityEngine.Animator            DotAnimator  // 0x80
  public            UnityEngine.UI.Button[]         NumberButtons  // 0x88
  public            UnityEngine.UI.Toggle[]         NumberDots  // 0x90
  public            UnityEngine.UI.Text             PromptText  // 0x98
  private           SRDebugger.UI.Controls.PinEntryControlCallbackComplete  // 0xa0
EVENTS:
  Complete  add=add_Complete  remove=remove_Complete
METHODS:
  RVA=0x096B5CCC  token=0x60001C8  System.Void Awake()
  RVA=0x096B6190  token=0x60001C9  System.Void OnEnable()
  RVA=0x096B60FC  token=0x60001CA  System.Void OnDisable()
  RVA=0x096B647C  token=0x60001CB  System.Void Update()
  RVA=0x096B5F28  token=0x60001CC  System.Void HandleCharacter(System.Char i)
  RVA=0x096B641C  token=0x60001CD  System.Void Show()
  RVA=0x096B5FA8  token=0x60001CE  System.Void Hide()
  RVA=0x096B5EDC  token=0x60001CF  System.Void Clear()
  RVA=0x096B6224  token=0x60001D0  System.Void PlayInvalidCodeAnimation()
  RVA=0x096B6060  token=0x60001D1  System.Void OnComplete()
  RVA=0x096B6004  token=0x60001D2  System.Void OnCancel()
  RVA=0x096B5E6C  token=0x60001D3  System.Void CancelButtonPressed()
  RVA=0x096B6270  token=0x60001D4  System.Void PushNumber(System.Int32 number)
  RVA=0x096B6330  token=0x60001D5  System.Void RefreshState()
  RVA=0x096B6554  token=0x60001D6  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerMemoryBlock
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x68
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _lastRefresh  // 0x48
  public            UnityEngine.UI.Text             CurrentUsedText  // 0x50
  public            UnityEngine.UI.Slider           Slider  // 0x58
  public            UnityEngine.UI.Text             TotalAllocatedText  // 0x60
METHODS:
  RVA=0x096B8044  token=0x60001D9  System.Void OnEnable()
  RVA=0x096B8234  token=0x60001DA  System.Void Update()
  RVA=0x096B8070  token=0x60001DB  System.Void TriggerRefresh()
  RVA=0x096B804C  token=0x60001DC  System.Void TriggerCleanup()
  RVA=0x096B7FE8  token=0x60001DD  System.Collections.IEnumerator CleanUp()
  RVA=0x0426FE60  token=0x60001DE  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerMonoBlock
TYPE:  class
TOKEN: 0x2000054
SIZE:  0x78
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _lastRefresh  // 0x48
  public            UnityEngine.UI.Text             CurrentUsedText  // 0x50
  public            UnityEngine.GameObject          NotSupportedMessage  // 0x58
  public            UnityEngine.UI.Slider           Slider  // 0x60
  public            UnityEngine.UI.Text             TotalAllocatedText  // 0x68
  private           System.Boolean                  _isSupported  // 0x70
METHODS:
  RVA=0x096B82B4  token=0x60001E5  System.Void OnEnable()
  RVA=0x096B8560  token=0x60001E6  System.Void Update()
  RVA=0x096B836C  token=0x60001E7  System.Void TriggerRefresh()
  RVA=0x096B831C  token=0x60001E8  System.Void TriggerCollection()
  RVA=0x0426FE60  token=0x60001E9  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerEnableControl
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x68
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _previousState  // 0x48
  public            UnityEngine.UI.Text             ButtonText  // 0x50
  public            UnityEngine.UI.Button           EnableButton  // 0x58
  public            UnityEngine.UI.Text             Text  // 0x60
METHODS:
  RVA=0x096B6710  token=0x60001EA  System.Void Start()
  RVA=0x096B6868  token=0x60001EB  System.Void UpdateLabels()
  RVA=0x096B6968  token=0x60001EC  System.Void Update()
  RVA=0x096B680C  token=0x60001ED  System.Void ToggleProfiler()
  RVA=0x0426FE60  token=0x60001EE  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerGraphAxisLabel
TYPE:  class
TOKEN: 0x2000056
SIZE:  0x60
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Single                   _prevFrameTime  // 0x48
  private           System.Nullable<System.Single>  _queuedFrameTime  // 0x4c
  private           System.Single                   _yPosition  // 0x54
  public            UnityEngine.UI.Text             Text  // 0x58
METHODS:
  RVA=0x096B6D10  token=0x60001EF  System.Void Update()
  RVA=0x096B6C94  token=0x60001F0  System.Void SetValue(System.Single frameTime, System.Single yPosition)
  RVA=0x096B6ADC  token=0x60001F1  System.Void SetValueInternal(System.Single frameTime)
  RVA=0x0426FE60  token=0x60001F2  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.ProfilerGraphControl
TYPE:  class
TOKEN: 0x2000057
SIZE:  0x108
EXTENDS: UnityEngine.UI.Graphic
FIELDS:
  public            SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignmentsVerticalAlignment  // 0xb0
  private   static readonly System.Single[]                 ScaleSteps  // static @ 0x0
  public            System.Boolean                  FloatingScale  // 0xb4
  public            System.Boolean                  TargetFpsUseApplication  // 0xb5
  public            System.Boolean                  DrawAxes  // 0xb6
  public            System.Int32                    TargetFps  // 0xb8
  public            System.Boolean                  Clip  // 0xbc
  public    static  System.Single                   DataPointMargin  // const
  public    static  System.Single                   DataPointVerticalMargin  // const
  public    static  System.Single                   DataPointWidth  // const
  public            System.Int32                    VerticalPadding  // 0xc0
  public    static  System.Int32                    LineCount  // const
  public            UnityEngine.Color[]             LineColours  // 0xc8
  private           SRDebugger.Services.IProfilerService_profilerService  // 0xd0
  private           SRDebugger.UI.Controls.ProfilerGraphAxisLabel[]_axisLabels  // 0xd8
  private           UnityEngine.Rect                _clipBounds  // 0xe0
  private   readonly System.Collections.Generic.List<UnityEngine.Vector3>_meshVertices  // 0xf0
  private   readonly System.Collections.Generic.List<UnityEngine.Color32>_meshVertexColors  // 0xf8
  private   readonly System.Collections.Generic.List<System.Int32>_meshTriangles  // 0x100
METHODS:
  RVA=0x096B70AC  token=0x60001F3  System.Void Awake()
  RVA=0x0350B670  token=0x60001F4  System.Void Start()
  RVA=0x096B7DB4  token=0x60001F5  System.Void Update()
  RVA=0x096B78C8  token=0x60001F6  System.Void OnPopulateMesh(UnityEngine.Mesh m)
  RVA=0x096B73DC  token=0x60001F7  System.Void DrawDataPoint(System.Single xPosition, System.Single verticalScale, SRDebugger.Services.ProfilerFrame frame)
  RVA=0x096B71D4  token=0x60001F8  System.Void DrawAxis(System.Single frameTime, System.Single yPosition, SRDebugger.UI.Controls.ProfilerGraphAxisLabel label)
  RVA=0x096B6D74  token=0x60001F9  System.Void AddRect(UnityEngine.Vector3 tl, UnityEngine.Vector3 tr, UnityEngine.Vector3 bl, UnityEngine.Vector3 br, UnityEngine.Color c)
  RVA=0x096B783C  token=0x60001FA  SRDebugger.Services.ProfilerFrame GetFrame(System.Int32 i)
  RVA=0x096B7198  token=0x60001FB  System.Int32 CalculateVisibleDataPointCount()
  RVA=0x096B7798  token=0x60001FC  System.Int32 GetFrameBufferCurrentSize()
  RVA=0x096B77E4  token=0x60001FD  System.Int32 GetFrameBufferMaxSize()
  RVA=0x096B7110  token=0x60001FE  System.Single CalculateMaxFrameTime()
  RVA=0x096B76C8  token=0x60001FF  SRDebugger.UI.Controls.ProfilerGraphAxisLabel GetAxisLabel(System.Int32 index)
  RVA=0x096B7E50  token=0x6000200  System.Void .ctor()
  RVA=0x096B7DC4  token=0x6000201  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.SRTabButton
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x70
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Behaviour           ActiveToggle  // 0x48
  public            UnityEngine.UI.Button           Button  // 0x50
  public            UnityEngine.RectTransform       ExtraContentContainer  // 0x58
  public            SRF.UI.StyleComponent           IconStyleComponent  // 0x60
  public            UnityEngine.UI.Text             TitleText  // 0x68
PROPERTIES:
  IsActive  get=0x096B897C  set=0x096B899C
METHODS:
  RVA=0x0426FE60  token=0x6000204  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.ActionControl
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x78
EXTENDS: SRDebugger.UI.Controls.OptionsControlBase
FIELDS:
  private           SRF.Helpers.MethodReference     _method  // 0x60
  public            UnityEngine.UI.Button           Button  // 0x68
  public            UnityEngine.UI.Text             Title  // 0x70
PROPERTIES:
  Method  get=0x03D4EB00
METHODS:
  RVA=0x096A9C80  token=0x6000206  System.Void Start()
  RVA=0x096A9B30  token=0x6000207  System.Void ButtonOnClick()
  RVA=0x096A9C48  token=0x6000208  System.Void SetMethod(System.String methodName, SRF.Helpers.MethodReference method)
  RVA=0x0426FE60  token=0x6000209  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.BoolControl
TYPE:  class
TOKEN: 0x200005B
SIZE:  0x90
EXTENDS: SRDebugger.UI.Controls.DataBoundControl
FIELDS:
  public            UnityEngine.UI.Text             Title  // 0x80
  public            UnityEngine.UI.Toggle           Toggle  // 0x88
METHODS:
  RVA=0x096A9E28  token=0x600020A  System.Void Start()
  RVA=0x096A9EE0  token=0x600020B  System.Void ToggleOnValueChanged(System.Boolean isOn)
  RVA=0x096A9D80  token=0x600020C  System.Void OnBind(System.String propertyName, System.Type t)
  RVA=0x096A9DC4  token=0x600020D  System.Void OnValueUpdated(System.Object newValue)
  RVA=0x096A9D1C  token=0x600020E  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  RVA=0x0426FE60  token=0x600020F  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.EnumControl
TYPE:  class
TOKEN: 0x200005C
SIZE:  0xC0
EXTENDS: SRDebugger.UI.Controls.DataBoundControl
FIELDS:
  private           System.Object                   _lastValue  // 0x80
  private           System.String[]                 _names  // 0x88
  private           System.Array                    _values  // 0x90
  public            UnityEngine.UI.LayoutElement    ContentLayoutElement  // 0x98
  public            UnityEngine.GameObject[]        DisableOnReadOnly  // 0xa0
  public            SRF.UI.SRSpinner                Spinner  // 0xa8
  public            UnityEngine.UI.Text             Title  // 0xb0
  public            UnityEngine.UI.Text             Value  // 0xb8
METHODS:
  RVA=0x096AE99C  token=0x6000210  System.Void Start()
  RVA=0x096B08C0  token=0x6000211  System.Void OnBind(System.String propertyName, System.Type t)
  RVA=0x096B0B1C  token=0x6000212  System.Void OnValueUpdated(System.Object newValue)
  RVA=0x093C0C94  token=0x6000213  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  RVA=0x096B0BD8  token=0x6000214  System.Void SetIndex(System.Int32 i)
  RVA=0x096B07F8  token=0x6000215  System.Void GoToNext()
  RVA=0x096B085C  token=0x6000216  System.Void GoToPrevious()
  RVA=0x0426FE60  token=0x6000217  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.NumberControl
TYPE:  class
TOKEN: 0x200005D
SIZE:  0xB8
EXTENDS: SRDebugger.UI.Controls.DataBoundControl
FIELDS:
  private   static readonly System.Type[]                   IntegerTypes  // static @ 0x0
  private   static readonly System.Type[]                   DecimalTypes  // static @ 0x8
  public    static readonly System.Collections.Generic.Dictionary<System.Type,SRDebugger.UI.Controls.Data.NumberControl.ValueRange>ValueRanges  // static @ 0x10
  private           System.String                   _lastValue  // 0x80
  private           System.Type                     _type  // 0x88
  public            UnityEngine.GameObject[]        DisableOnReadOnly  // 0x90
  public            SRF.UI.SRNumberButton           DownNumberButton  // 0x98
  public            SRF.UI.SRNumberSpinner          NumberSpinner  // 0xa0
  public            UnityEngine.UI.Text             Title  // 0xa8
  public            SRF.UI.SRNumberButton           UpNumberButton  // 0xb0
METHODS:
  RVA=0x096B31C4  token=0x6000218  System.Void Start()
  RVA=0x096B2F48  token=0x6000219  System.Void OnValueChanged(System.String newValue)
  RVA=0x096B2BD4  token=0x600021A  System.Void OnBind(System.String propertyName, System.Type t)
  RVA=0x096B30BC  token=0x600021B  System.Void OnValueUpdated(System.Object newValue)
  RVA=0x096B27A8  token=0x600021C  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  RVA=0x096B2B10  token=0x600021D  System.Boolean IsIntegerType(System.Type t)
  RVA=0x096B2A4C  token=0x600021E  System.Boolean IsDecimalType(System.Type t)
  RVA=0x096B280C  token=0x600021F  System.Double GetMaxValue(System.Type t)
  RVA=0x096B292C  token=0x6000220  System.Double GetMinValue(System.Type t)
  RVA=0x0426FE60  token=0x6000221  System.Void .ctor()
  RVA=0x096B327C  token=0x6000222  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.ReadOnlyControl
TYPE:  class
TOKEN: 0x200005F
SIZE:  0x90
EXTENDS: SRDebugger.UI.Controls.DataBoundControl
FIELDS:
  public            UnityEngine.UI.Text             ValueText  // 0x80
  public            UnityEngine.UI.Text             Title  // 0x88
METHODS:
  RVA=0x096AE99C  token=0x6000223  System.Void Start()
  RVA=0x096B87F4  token=0x6000224  System.Void OnBind(System.String propertyName, System.Type t)
  RVA=0x096B8818  token=0x6000225  System.Void OnValueUpdated(System.Object newValue)
  RVA=0x096B8774  token=0x6000226  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  RVA=0x0426FE60  token=0x6000227  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Controls.Data.StringControl
TYPE:  class
TOKEN: 0x2000060
SIZE:  0x90
EXTENDS: SRDebugger.UI.Controls.DataBoundControl
FIELDS:
  public            UnityEngine.UI.InputField       InputField  // 0x80
  public            UnityEngine.UI.Text             Title  // 0x88
METHODS:
  RVA=0x096B9F08  token=0x6000228  System.Void Start()
  RVA=0x096B9E78  token=0x6000229  System.Void OnValueChanged(System.String newValue)
  RVA=0x096B9DEC  token=0x600022A  System.Void OnBind(System.String propertyName, System.Type t)
  RVA=0x096B9E80  token=0x600022B  System.Void OnValueUpdated(System.Object newValue)
  RVA=0x096B9D70  token=0x600022C  System.Boolean CanBind(System.Type type, System.Boolean isReadOnly)
  RVA=0x0426FE60  token=0x600022D  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.BugReportPopoverRoot
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x48
  public            UnityEngine.RectTransform       Container  // 0x50
METHODS:
  RVA=0x0426FE60  token=0x6000111  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.BugReportSheetController
TYPE:  class
TOKEN: 0x2000032
SIZE:  0xA8
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.GameObject          ButtonContainer  // 0x48
  public            UnityEngine.UI.Text             ButtonText  // 0x50
  public            UnityEngine.UI.Button           CancelButton  // 0x58
  public            System.Action                   CancelPressed  // 0x60
  public            UnityEngine.UI.InputField       DescriptionField  // 0x68
  public            UnityEngine.UI.InputField       EmailField  // 0x70
  public            UnityEngine.UI.Slider           ProgressBar  // 0x78
  public            UnityEngine.UI.Text             ResultMessageText  // 0x80
  public            System.Action                   ScreenshotComplete  // 0x88
  public            UnityEngine.UI.Button           SubmitButton  // 0x90
  public            System.Action<System.Boolean,System.String>SubmitComplete  // 0x98
  public            System.Action                   TakingScreenshot  // 0xa0
PROPERTIES:
  IsCancelButtonEnabled  get=0x096AB3DC  set=0x096AB40C
METHODS:
  RVA=0x096AB270  token=0x6000114  System.Void Start()
  RVA=0x096AB2F8  token=0x6000115  System.Void Submit()
  RVA=0x096AAE44  token=0x6000116  System.Void Cancel()
  RVA=0x096AB29C  token=0x6000117  System.Collections.IEnumerator SubmitCo()
  RVA=0x096AB044  token=0x6000118  System.Void OnBugReportProgress(System.Single progress)
  RVA=0x096AAF88  token=0x6000119  System.Void OnBugReportComplete(System.Boolean didSucceed, System.String errorMessage)
  RVA=0x096AB118  token=0x600011A  System.Void SetLoadingSpinnerVisible(System.Boolean visible)
  RVA=0x096AAEC8  token=0x600011B  System.Void ClearForm()
  RVA=0x096AB170  token=0x600011C  System.Void ShowErrorMessage(System.String userMessage, System.String serverMessage)
  RVA=0x096AAE58  token=0x600011D  System.Void ClearErrorMessage()
  RVA=0x096AB0AC  token=0x600011E  System.Void SetFormEnabled(System.Boolean e)
  RVA=0x096AAF40  token=0x600011F  System.String GetDefaultEmailFieldContents()
  RVA=0x096AB068  token=0x6000120  System.Void SetDefaultEmailFieldContents(System.String value)
  RVA=0x0426FE60  token=0x6000121  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.CategoryGroup
TYPE:  class
TOKEN: 0x2000034
SIZE:  0x78
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.RectTransform       Container  // 0x48
  public            UnityEngine.UI.Text             Header  // 0x50
  public            UnityEngine.GameObject          Background  // 0x58
  public            UnityEngine.UI.Toggle           SelectionToggle  // 0x60
  public            UnityEngine.GameObject[]        EnabledDuringSelectionMode  // 0x68
  private           System.Boolean                  _selectionModeEnabled  // 0x70
PROPERTIES:
  IsSelected  get=0x096AB7B4  set=0x096AB7D4
  SelectionModeEnabled  get=0x03D4F260  set=0x096AB8AC
METHODS:
  RVA=0x096AB760  token=0x600012C  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.ConfigureCanvasFromSettings
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x68
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           UnityEngine.Canvas              _canvas  // 0x48
  private           UnityEngine.UI.CanvasScaler     _canvasScaler  // 0x50
  private           System.Single                   _originalScale  // 0x58
  private           System.Single                   _lastSetScale  // 0x5c
  private           SRDebugger.Settings             _settings  // 0x60
METHODS:
  RVA=0x096ABAC8  token=0x600012D  System.Void Start()
  RVA=0x096AB99C  token=0x600012E  System.Void OnDestroy()
  RVA=0x096ABA5C  token=0x600012F  System.Void SettingsOnPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
  RVA=0x0426FE60  token=0x6000130  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.ConsoleTabQuickViewControl
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x80
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private   static  System.Int32                    Max  // const
  private   static readonly System.String                   MaxString  // static @ 0x0
  private           System.Int32                    _prevCriticalCount  // 0x48
  private           System.Int32                    _prevErrorCount  // 0x4c
  private           System.Int32                    _prevInfoCount  // 0x50
  private           System.Int32                    _prevWarningCount  // 0x54
  public            SRDebugger.Services.IConsoleServiceConsoleService  // 0x58
  public            UnityEngine.UI.Text             CriticalCountText  // 0x60
  public            UnityEngine.UI.Text             ErrorCountText  // 0x68
  public            UnityEngine.UI.Text             InfoCountText  // 0x70
  public            UnityEngine.UI.Text             WarningCountText  // 0x78
METHODS:
  RVA=0x096AE274  token=0x6000131  System.Void Awake()
  RVA=0x096AE344  token=0x6000132  System.Void Update()
  RVA=0x096AE314  token=0x6000133  System.Boolean HasChanged(System.Int32 newCount, System.Int32& oldCount, System.Int32 max)
  RVA=0x096AE644  token=0x6000134  System.Void .ctor()
  RVA=0x096AE5C8  token=0x6000135  System.Void .cctor()
END_CLASS

CLASS: SRDebugger.UI.Other.DebugPanelBackgroundBehaviour
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x60
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           SRF.UI.StyleComponent           _styleComponent  // 0x48
  public            System.String                   TransparentStyleKey  // 0x50
  private           SRF.UI.StyleSheet               _styleSheet  // 0x58
METHODS:
  RVA=0x096AEA08  token=0x6000136  System.Void Awake()
  RVA=0x096AEAD0  token=0x6000137  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.DockConsoleController
TYPE:  class
TOKEN: 0x2000038
SIZE:  0xE0
EXTENDS: SRF.SRMonoBehaviourEx
IMPLEMENTS: UnityEngine.EventSystems.IPointerEnterHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerExitHandler
FIELDS:
  public    static  System.Single                   NonFocusOpacity  // const
  private           System.Boolean                  _isDirty  // 0x48
  private           System.Boolean                  _isDragging  // 0x49
  private           System.Int32                    _pointersOver  // 0x4c
  public            SRDebugger.Services.IConsoleFilterStateFilterState  // 0x50
  public            UnityEngine.GameObject          BottomHandle  // 0x58
  public            UnityEngine.CanvasGroup         CanvasGroup  // 0x60
  public            SRDebugger.UI.Controls.ConsoleLogControlConsole  // 0x68
  public            UnityEngine.GameObject          Dropdown  // 0x70
  public            UnityEngine.UI.Image            DropdownToggleSprite  // 0x78
  public            UnityEngine.UI.Text             TextCriticals  // 0x80
  public            UnityEngine.UI.Text             TextErrors  // 0x88
  public            UnityEngine.UI.Text             TextInfo  // 0x90
  public            UnityEngine.UI.Text             TextWarnings  // 0x98
  public            UnityEngine.UI.Toggle           ToggleCriticals  // 0xa0
  public            UnityEngine.UI.Toggle           ToggleErrors  // 0xa8
  public            UnityEngine.UI.Toggle           ToggleInfo  // 0xb0
  public            UnityEngine.UI.Toggle           ToggleWarnings  // 0xb8
  public            UnityEngine.GameObject          TopBar  // 0xc0
  public            UnityEngine.GameObject          TopHandle  // 0xc8
  public            UnityEngine.GameObject          TopSafeAreaSpacer  // 0xd0
  public            UnityEngine.GameObject          BottomSafeAreaSpacer  // 0xd8
PROPERTIES:
  IsVisible  get=0x096B007C  set=0x096B00A0
METHODS:
  RVA=0x096AFB2C  token=0x600013A  System.Void Start()
  RVA=0x096AF3EC  token=0x600013B  System.Void OnDestroy()
  RVA=0x096AF4E0  token=0x600013C  System.Void OnEnable()
  RVA=0x03D75190  token=0x600013D  System.Void OnDisable()
  RVA=0x096B006C  token=0x600013E  System.Void Update()
  RVA=0x096AF508  token=0x600013F  System.Void OnFilterStateChange(UnityEngine.LogType logType, System.Boolean newState)
  RVA=0x03D73A50  token=0x6000140  System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
  RVA=0x096AFAA0  token=0x6000141  System.Void SetDropdownVisibility(System.Boolean visible)
  RVA=0x096AF804  token=0x6000142  System.Void SetAlignmentMode(SRDebugger.ConsoleAlignment alignment)
  RVA=0x096AF5D0  token=0x6000143  System.Void Refresh()
  RVA=0x096AF588  token=0x6000144  System.Void RefreshAlpha()
  RVA=0x096AFEC8  token=0x6000145  System.Void ToggleDropdownVisible()
  RVA=0x096AF390  token=0x6000146  System.Void MenuButtonPressed()
  RVA=0x096AF36C  token=0x6000147  System.Void ClearButtonPressed()
  RVA=0x096AFEFC  token=0x6000148  System.Void TogglesUpdated()
  RVA=0x096AF568  token=0x6000149  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData e)
  RVA=0x096AF578  token=0x600014A  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData e)
  RVA=0x096AF3E0  token=0x600014B  System.Void OnBeginDrag()
  RVA=0x096AF4F4  token=0x600014C  System.Void OnEndDrag()
  RVA=0x0426FE60  token=0x600014D  System.Void .ctor()
  RVA=0x096AFFAC  token=0x600014E  System.Void <Start>b__25_0(System.Boolean isOn)
  RVA=0x096AFFDC  token=0x600014F  System.Void <Start>b__25_1(System.Boolean isOn)
  RVA=0x096B000C  token=0x6000150  System.Void <Start>b__25_2(System.Boolean isOn)
  RVA=0x096B003C  token=0x6000151  System.Void <Start>b__25_3(System.Boolean isOn)
END_CLASS

CLASS: SRDebugger.UI.Other.ErrorNotifier
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.Single                   DisplayTime  // const
  private           UnityEngine.Animator            _animator  // 0x18
  private           System.Int32                    _triggerHash  // 0x20
  private           System.Single                   _hideTime  // 0x24
  private           System.Boolean                  _isShowing  // 0x28
  private           System.Boolean                  _queueWarning  // 0x29
PROPERTIES:
  IsVisible  get=0x03D4ED50
METHODS:
  RVA=0x096B0C1C  token=0x6000153  System.Void Awake()
  RVA=0x03D5CAD0  token=0x6000154  System.Void ShowErrorWarning()
  RVA=0x096B0C58  token=0x6000155  System.Void Update()
  RVA=0x0426FE60  token=0x6000156  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.FloatOverElement
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x28
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutSelfController UnityEngine.UI.ILayoutController
FIELDS:
  public            UnityEngine.RectTransform       CopyFrom  // 0x18
  private           UnityEngine.DrivenRectTransformTracker_tracker  // 0x20
METHODS:
  RVA=0x096B0CDC  token=0x6000157  System.Void Copy()
  RVA=0x096B0E88  token=0x6000158  System.Void SetLayoutHorizontal()
  RVA=0x096B0E88  token=0x6000159  System.Void SetLayoutVertical()
  RVA=0x0426FE60  token=0x600015A  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.HandleManager
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x98
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _hasSet  // 0x48
  public            UnityEngine.GameObject          BottomHandle  // 0x50
  public            UnityEngine.GameObject          BottomLeftHandle  // 0x58
  public            UnityEngine.GameObject          BottomRightHandle  // 0x60
  public            SRDebugger.PinAlignment         DefaultAlignment  // 0x68
  public            UnityEngine.GameObject          LeftHandle  // 0x70
  public            UnityEngine.GameObject          RightHandle  // 0x78
  public            UnityEngine.GameObject          TopHandle  // 0x80
  public            UnityEngine.GameObject          TopLeftHandle  // 0x88
  public            UnityEngine.GameObject          TopRightHandle  // 0x90
METHODS:
  RVA=0x096B10EC  token=0x600015B  System.Void Start()
  RVA=0x096B0F00  token=0x600015C  System.Void SetAlignment(SRDebugger.PinAlignment alignment)
  RVA=0x096B0E90  token=0x600015D  System.Void SetActive(UnityEngine.GameObject obj, System.Boolean active)
  RVA=0x0426FE60  token=0x600015E  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.IEnableTab
TYPE:  interface
TOKEN: 0x200003C
FIELDS:
PROPERTIES:
  IsEnabled  get=-1  // abstract
METHODS:
END_CLASS

CLASS: SRDebugger.UI.Other.LoadingSpinnerBehaviour
TYPE:  class
TOKEN: 0x200003D
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           System.Single                   _dt  // 0x48
  public            System.Int32                    FrameCount  // 0x4c
  public            System.Single                   SpinDuration  // 0x50
METHODS:
  RVA=0x096B1C38  token=0x6000160  System.Void Update()
  RVA=0x096B1D44  token=0x6000161  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.PinnedUIRoot
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x88
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Canvas              Canvas  // 0x48
  public            UnityEngine.RectTransform       Container  // 0x50
  public            SRDebugger.UI.Other.DockConsoleControllerDockConsoleController  // 0x58
  public            UnityEngine.GameObject          Options  // 0x60
  public            SRF.UI.Layout.FlowLayoutGroup   OptionsLayoutGroup  // 0x68
  public            UnityEngine.GameObject          Profiler  // 0x70
  public            SRDebugger.UI.Other.HandleManagerProfilerHandleManager  // 0x78
  public            UnityEngine.UI.VerticalLayoutGroupProfilerVerticalLayoutGroup  // 0x80
METHODS:
  RVA=0x0426FE60  token=0x6000162  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SafeAreaSizer
TYPE:  class
TOKEN: 0x200003F
SIZE:  0x28
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  private           UnityEngine.RectTransform.Edge  _edge  // 0x18
  public            System.Single                   Scale  // 0x1c
  private           System.Single                   _height  // 0x20
  private           System.Single                   _width  // 0x24
PROPERTIES:
  Edge  get=0x020D1AC0  set=0x096B9708
  preferredWidth  get=0x03D524F0
  preferredHeight  get=0x03D4F2E0
  minWidth  get=0x03D524F0
  minHeight  get=0x03D4F2E0
  layoutPriority  get=0x02102C70
  flexibleHeight  get=0x03D751A0
  flexibleWidth  get=0x03D751A0
METHODS:
  RVA=0x096B9468  token=0x600016C  System.Void Refresh()
  RVA=0x096B943C  token=0x600016D  System.Void CalculateLayoutInputHorizontal()
  RVA=0x096B943C  token=0x600016E  System.Void CalculateLayoutInputVertical()
  RVA=0x03B45ED0  token=0x600016F  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.ScrollSettingsBehaviour
TYPE:  class
TOKEN: 0x2000040
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public    static  System.Single                   ScrollSensitivity  // const
METHODS:
  RVA=0x096B9794  token=0x6000170  System.Void Awake()
  RVA=0x0426FE60  token=0x6000171  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SetLayerFromSettings
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x48
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
METHODS:
  RVA=0x096B97F8  token=0x6000172  System.Void Start()
  RVA=0x0426FE60  token=0x6000173  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SRTab
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x90
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.RectTransform       HeaderExtraContent  // 0x48
  public            UnityEngine.Sprite              Icon  // 0x50
  public            UnityEngine.RectTransform       IconExtraContent  // 0x58
  public            System.String                   IconStyleKey  // 0x60
  public            System.Int32                    SortIndex  // 0x68
  public            SRDebugger.UI.Controls.SRTabButtonTabButton  // 0x70
  private           System.String                   _title  // 0x78
  private           System.String                   _longTitle  // 0x80
  private           System.String                   _key  // 0x88
PROPERTIES:
  Title  get=0x03D4EB20
  LongTitle  get=0x096B9424
  Key  get=0x03D4EA60
METHODS:
  RVA=0x096B93DC  token=0x6000177  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.SRTabController
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x88
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private   readonly SRF.SRList<SRDebugger.UI.Other.SRTab>_tabs  // 0x48
  private           SRDebugger.UI.Other.SRTab       _activeTab  // 0x50
  public            UnityEngine.RectTransform       TabButtonContainer  // 0x58
  public            SRDebugger.UI.Controls.SRTabButtonTabButtonPrefab  // 0x60
  public            UnityEngine.RectTransform       TabContentsContainer  // 0x68
  public            UnityEngine.RectTransform       TabHeaderContentContainer  // 0x70
  public            UnityEngine.UI.Text             TabHeaderText  // 0x78
  private           System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab>ActiveTabChanged  // 0x80
PROPERTIES:
  ActiveTab  get=0x03D4EAF0  set=0x096B93D4
  Tabs  get=0x096B92FC
EVENTS:
  ActiveTabChanged  add=add_ActiveTabChanged  remove=remove_ActiveTabChanged
METHODS:
  RVA=0x096B89BC  token=0x600017D  System.Void AddTab(SRDebugger.UI.Other.SRTab tab, System.Boolean visibleInSidebar)
  RVA=0x096B8CC8  token=0x600017E  System.Void MakeActive(SRDebugger.UI.Other.SRTab tab)
  RVA=0x096B9030  token=0x600017F  System.Void SortTabs()
  RVA=0x096B9208  token=0x6000180  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.TriggerRoot
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x70
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            UnityEngine.Canvas              Canvas  // 0x48
  public            SRF.UI.LongPressButton          TapHoldButton  // 0x50
  public            UnityEngine.RectTransform       TriggerTransform  // 0x58
  public            SRDebugger.UI.Other.ErrorNotifierErrorNotifier  // 0x60
  public            SRDebugger.UI.Controls.MultiTapButtonTripleTapButton  // 0x68
METHODS:
  RVA=0x0426FE60  token=0x6000186  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Other.VersionTextBehaviour
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public            System.String                   Format  // 0x48
  public            UnityEngine.UI.Text             Text  // 0x50
METHODS:
  RVA=0x096BACE8  token=0x6000187  System.Void Start()
  RVA=0x096BAD4C  token=0x6000188  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.BugReportTabController
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviourEx
IMPLEMENTS: SRDebugger.UI.Other.IEnableTab
FIELDS:
  public            SRDebugger.UI.Other.BugReportSheetControllerBugReportSheetPrefab  // 0x48
  public            UnityEngine.RectTransform       Container  // 0x50
PROPERTIES:
  IsEnabled  get=0x096AB6BC
METHODS:
  RVA=0x096AB540  token=0x60000C3  System.Void Start()
  RVA=0x096AB670  token=0x60000C4  System.Void TakingScreenshot()
  RVA=0x096AB4F4  token=0x60000C5  System.Void ScreenshotComplete()
  RVA=0x0426FE60  token=0x60000C6  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.ConsoleTabController
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x118
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private   static  System.Int32                    MaxLength  // const
  private           UnityEngine.Canvas              _consoleCanvas  // 0x48
  private           System.Boolean                  _isDirty  // 0x50
  private   static  System.Boolean                  _hasWarnedAboutLogHandler  // static @ 0x0
  private   static  System.Boolean                  _hasWarnedAboutLoggingDisabled  // static @ 0x1
  public            SRDebugger.Services.IConsoleFilterStateFilterState  // 0x58
  public            SRDebugger.UI.Controls.ConsoleLogControlConsoleLogControl  // 0x60
  public            UnityEngine.UI.Toggle           PinToggle  // 0x68
  public            UnityEngine.UI.ScrollRect       StackTraceScrollRect  // 0x70
  public            UnityEngine.UI.Text             StackTraceText  // 0x78
  public            UnityEngine.UI.Toggle           ToggleCriticals  // 0x80
  public            UnityEngine.UI.Text             ToggleCriticalsText  // 0x88
  public            UnityEngine.UI.Toggle           ToggleErrors  // 0x90
  public            UnityEngine.UI.Text             ToggleErrorsText  // 0x98
  public            UnityEngine.UI.Toggle           ToggleInfo  // 0xa0
  public            UnityEngine.UI.Text             ToggleInfoText  // 0xa8
  public            UnityEngine.UI.Toggle           ToggleWarnings  // 0xb0
  public            UnityEngine.UI.Text             ToggleWarningsText  // 0xb8
  public            UnityEngine.GameObject          CopyToClipboardContainer  // 0xc0
  public            UnityEngine.GameObject          CopyToClipboardButton  // 0xc8
  public            UnityEngine.GameObject          CopyToClipboardMessage  // 0xd0
  public            UnityEngine.CanvasGroup         CopyToClipboardMessageCanvasGroup  // 0xd8
  public            UnityEngine.GameObject          LoggingIsDisabledCanvasGroup  // 0xe0
  public            UnityEngine.GameObject          LogHandlerHasBeenOverridenGroup  // 0xe8
  public            UnityEngine.UI.Toggle           FilterToggle  // 0xf0
  public            UnityEngine.UI.InputField       FilterField  // 0xf8
  public            UnityEngine.GameObject          FilterBarContainer  // 0x100
  private           SRDebugger.Services.ConsoleEntry_selectedItem  // 0x108
  private           UnityEngine.Coroutine           _fadeButtonCoroutine  // 0x110
METHODS:
  RVA=0x096ADB10  token=0x60000C7  System.Void Start()
  RVA=0x096AD2D0  token=0x60000C8  System.Void OnFilterStateChange(UnityEngine.LogType logtype, System.Boolean newstate)
  RVA=0x096ACF3C  token=0x60000C9  System.Void FilterToggleValueChanged(System.Boolean isOn)
  RVA=0x096ACFBC  token=0x60000CA  System.Void FilterValueChanged(System.String filterText)
  RVA=0x096AD330  token=0x60000CB  System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b)
  RVA=0x096AD3CC  token=0x60000CC  System.Void PinToggleValueChanged(System.Boolean isOn)
  RVA=0x096AD1C8  token=0x60000CD  System.Void OnDestroy()
  RVA=0x03D75180  token=0x60000CE  System.Void OnEnable()
  RVA=0x096AD2C8  token=0x60000CF  System.Void OnDisable()
  RVA=0x096ACDB8  token=0x60000D0  System.Void ConsoleLogSelectedItemChanged(System.Object item)
  RVA=0x096AE264  token=0x60000D1  System.Void Update()
  RVA=0x096AD3F8  token=0x60000D2  System.Void PopulateStackTraceArea(SRDebugger.Services.ConsoleEntry entry)
  RVA=0x096ACE0C  token=0x60000D3  System.Void CopyToClipboard()
  RVA=0x096AD950  token=0x60000D4  System.Void SetCopyToClipboardButtonState(SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates state)
  RVA=0x096ACEE0  token=0x60000D5  System.Collections.IEnumerator FadeCopyButton()
  RVA=0x096AE148  token=0x60000D6  System.Void StopAnimations()
  RVA=0x096AD5CC  token=0x60000D7  System.Void Refresh()
  RVA=0x03D75180  token=0x60000D8  System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
  RVA=0x096ACD88  token=0x60000D9  System.Void Clear()
  RVA=0x096AD038  token=0x60000DA  System.Void LogHandlerHasBeenOverridenOkayButtonPress()
  RVA=0x096AD090  token=0x60000DB  System.Void LoggingDisableCloseAndIgnorePressed()
  RVA=0x096AD0EC  token=0x60000DC  System.Void LoggingDisableReenablePressed()
  RVA=0x0426FE60  token=0x60000DD  System.Void .ctor()
  RVA=0x096AE1A4  token=0x60000DE  System.Void <Start>b__29_0(System.Boolean isOn)
  RVA=0x096AE1D4  token=0x60000DF  System.Void <Start>b__29_1(System.Boolean isOn)
  RVA=0x096AE204  token=0x60000E0  System.Void <Start>b__29_2(System.Boolean isOn)
  RVA=0x096AE234  token=0x60000E1  System.Void <Start>b__29_3(System.Boolean isOn)
END_CLASS

CLASS: SRDebugger.UI.Tabs.InfoTabController
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x70
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  public    static  System.Char                     Tick  // const
  public    static  System.Char                     Cross  // const
  public    static  System.String                   NameColor  // const
  private           System.Collections.Generic.Dictionary<System.String,SRDebugger.UI.Controls.InfoBlock>_infoBlocks  // 0x48
  public            SRDebugger.UI.Controls.InfoBlockInfoBlockPrefab  // 0x50
  public            UnityEngine.RectTransform       LayoutContainer  // 0x58
  public            SRF.UI.FlashGraphic             ToggleButton  // 0x60
  private           System.Boolean                  _updateEveryFrame  // 0x68
METHODS:
  RVA=0x096B1B3C  token=0x60000E8  System.Void OnEnable()
  RVA=0x096B1B74  token=0x60000E9  System.Void Refresh()
  RVA=0x096B1BA8  token=0x60000EA  System.Void Update()
  RVA=0x096B1214  token=0x60000EB  System.Void ActivateRefreshEveryFrame()
  RVA=0x096B174C  token=0x60000EC  System.Void InternalRefresh()
  RVA=0x096B12E0  token=0x60000ED  System.Void FillInfoBlock(SRDebugger.UI.Controls.InfoBlock block, System.Collections.Generic.IList<SRDebugger.InfoEntry> info)
  RVA=0x096B1248  token=0x60000EE  SRDebugger.UI.Controls.InfoBlock CreateBlock(System.String title)
  RVA=0x096B1BB8  token=0x60000EF  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.OptionsTabController
TYPE:  class
TOKEN: 0x200002C
SIZE:  0xB0
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private   readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>_controls  // 0x48
  private   readonly System.Collections.Generic.List<SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance>_categories  // 0x50
  private   readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase>_options  // 0x58
  private           System.Boolean                  _queueRefresh  // 0x60
  private           System.Boolean                  _selectionModeEnabled  // 0x61
  private           UnityEngine.Canvas              _optionCanvas  // 0x68
  public            SRDebugger.UI.Controls.Data.ActionControlActionControlPrefab  // 0x70
  public            SRDebugger.UI.Other.CategoryGroupCategoryGroupPrefab  // 0x78
  public            UnityEngine.RectTransform       ContentContainer  // 0x80
  public            UnityEngine.GameObject          NoOptionsNotice  // 0x88
  public            UnityEngine.UI.Toggle           PinButton  // 0x90
  public            UnityEngine.GameObject          PinPromptSpacer  // 0x98
  public            UnityEngine.GameObject          PinPromptText  // 0xa0
  private           System.Boolean                  _isTogglingCategory  // 0xa8
METHODS:
  RVA=0x096B58A8  token=0x60000F0  System.Void Start()
  RVA=0x096B4710  token=0x60000F1  System.Void OnDestroy()
  RVA=0x096B4A24  token=0x60000F2  System.Void OnOptionPinnedStateChanged(SRDebugger.OptionDefinition optionDefinition, System.Boolean isPinned)
  RVA=0x096B4AF4  token=0x60000F3  System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs)
  RVA=0x096B4990  token=0x60000F4  System.Void OnEnable()
  RVA=0x096B48A4  token=0x60000F5  System.Void OnDisable()
  RVA=0x096B5AAC  token=0x60000F6  System.Void Update()
  RVA=0x096B4B14  token=0x60000F7  System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b)
  RVA=0x096B5548  token=0x60000F8  System.Void SetSelectionModeEnabled(System.Boolean isEnabled)
  RVA=0x096B5408  token=0x60000F9  System.Void Refresh()
  RVA=0x096B3CD0  token=0x60000FA  System.Void CommitPinnedOptions()
  RVA=0x096B5244  token=0x60000FB  System.Void RefreshCategorySelection()
  RVA=0x096B4AC4  token=0x60000FC  System.Void OnOptionSelectionToggle(System.Boolean selected)
  RVA=0x096B465C  token=0x60000FD  System.Void OnCategorySelectionToggle(SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance category, System.Boolean selected)
  RVA=0x096B4BC8  token=0x60000FE  System.Void Populate()
  RVA=0x096B3EFC  token=0x60000FF  System.Void CreateCategory(System.String title, System.Collections.Generic.List<SRDebugger.OptionDefinition> options)
  RVA=0x096B3B04  token=0x6000100  System.Void Clear()
  RVA=0x096B5AC0  token=0x6000101  System.Void .ctor()
END_CLASS

CLASS: SRDebugger.UI.Tabs.ProfilerTabController
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
  private           System.Boolean                  _isDirty  // 0x48
  public            UnityEngine.UI.Toggle           PinToggle  // 0x50
METHODS:
  RVA=0x096B86AC  token=0x600010B  System.Void Start()
  RVA=0x096B85E0  token=0x600010C  System.Void PinToggleValueChanged(System.Boolean isOn)
  RVA=0x03D73A50  token=0x600010D  System.Void OnEnable()
  RVA=0x096B8764  token=0x600010E  System.Void Update()
  RVA=0x096B8634  token=0x600010F  System.Void Refresh()
  RVA=0x0426FE60  token=0x6000110  System.Void .ctor()
END_CLASS

