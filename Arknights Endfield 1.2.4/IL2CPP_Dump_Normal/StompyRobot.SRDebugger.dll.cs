// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRDebugger.dll
// Classes:  159
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly SRDebug.<>c <>9;  // static @ 0x0
        public static System.Action<SRDebugger.Services.ConsoleEntry> <>9__9_0;  // static @ 0x8

        // Methods
        // RVA: 0x03D122F0  token: 0x6000007
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000008
        public System.Void .ctor() { }
        // RVA: 0x096BAA1C  token: 0x6000009
        private System.Void <GetDefaultCopyConsoleItemCallback>b__9_0(SRDebugger.Services.ConsoleEntry entry) { }

    }

    // TypeToken: 0x2000002  // size: 0x10
    public static class SRDebug
    {
        // Fields
        public static System.String Version;  // const
        private static System.Boolean <IsInitialized>k__BackingField;  // static @ 0x0
        public static System.Action<SRDebugger.Services.ConsoleEntry> CopyConsoleItemCallback;  // static @ 0x8

        // Properties
        System.Boolean IsInitialized { get; /* RVA: 0x096B88D8 */ set; /* RVA: 0x096B8928 */ }
        SRDebugger.Services.IDebugService Instance { get; /* RVA: 0x096B8884 */ }

        // Methods
        // RVA: 0x03A273C0  token: 0x6000004
        public static System.Void Init() { }
        // RVA: 0x03B3D280  token: 0x6000005
        public static System.Action<SRDebugger.Services.ConsoleEntry> GetDefaultCopyConsoleItemCallback() { }
        // RVA: 0x03B3D220  token: 0x6000006
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public sealed class <GetEnumerator>d__18 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private T <>2__current;  // 0x0
        public SRDebugger.CircularBuffer<T> <>4__this;  // 0x0
        private System.ArraySegment<T>[] <>7__wrap1;  // 0x0
        private System.Int32 <>7__wrap2;  // 0x0
        private System.ArraySegment<T> <segment>5__4;  // 0x0
        private System.Int32 <i>5__5;  // 0x0

        // Properties
        T System.Collections.Generic.IEnumerator<T>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000032
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x6000033
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000034
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000036
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000013  // size: 0x18
    public sealed class <>c__DisplayClass12_0
    {
        // Fields
        public System.Object value;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000072
        public System.Void .ctor() { }
        // RVA: 0x020B7B20  token: 0x6000073
        private System.Object <Create>b__0() { }

    }

    // TypeToken: 0x2000018  // size: 0x14
    public sealed struct ShortcutActions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.Settings.ShortcutActions None;  // const
        public static SRDebugger.Settings.ShortcutActions OpenSystemInfoTab;  // const
        public static SRDebugger.Settings.ShortcutActions OpenConsoleTab;  // const
        public static SRDebugger.Settings.ShortcutActions OpenOptionsTab;  // const
        public static SRDebugger.Settings.ShortcutActions OpenProfilerTab;  // const
        public static SRDebugger.Settings.ShortcutActions OpenBugReporterTab;  // const
        public static SRDebugger.Settings.ShortcutActions ClosePanel;  // const
        public static SRDebugger.Settings.ShortcutActions OpenPanel;  // const
        public static SRDebugger.Settings.ShortcutActions TogglePanel;  // const
        public static SRDebugger.Settings.ShortcutActions ShowBugReportPopover;  // const
        public static SRDebugger.Settings.ShortcutActions ToggleDockedConsole;  // const
        public static SRDebugger.Settings.ShortcutActions ToggleDockedProfiler;  // const

    }

    // TypeToken: 0x2000019  // size: 0x14
    public sealed struct TriggerBehaviours
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.Settings.TriggerBehaviours TripleTap;  // const
        public static SRDebugger.Settings.TriggerBehaviours TapAndHold;  // const
        public static SRDebugger.Settings.TriggerBehaviours DoubleTap;  // const

    }

    // TypeToken: 0x200001A  // size: 0x14
    public sealed struct TriggerEnableModes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.Settings.TriggerEnableModes Enabled;  // const
        public static SRDebugger.Settings.TriggerEnableModes MobileOnly;  // const
        public static SRDebugger.Settings.TriggerEnableModes Off;  // const
        public static SRDebugger.Settings.TriggerEnableModes DevelopmentBuildsOnly;  // const

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct UIModes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.Settings.UIModes NewInputSystem;  // const
        public static SRDebugger.Settings.UIModes LegacyInputSystem;  // const

    }

    // TypeToken: 0x200001C  // size: 0x28
    public sealed class KeyboardShortcut
    {
        // Fields
        public SRDebugger.Settings.ShortcutActions Action;  // 0x10
        public System.Boolean Alt;  // 0x14
        public System.Boolean Control;  // 0x15
        public UnityEngine.KeyCode Key;  // 0x18
        public System.Boolean Shift;  // 0x1c
        public System.Nullable<UnityEngine.InputSystem.Key> Cached_KeyCode;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60000A3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly SRDebugger.Settings.<>c <>9;  // static @ 0x0
        public static System.Func<System.Int32,System.Boolean> <>9__42_0;  // static @ 0x8

        // Methods
        // RVA: 0x096BABBC  token: 0x60000A4
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60000A5
        public System.Void .ctor() { }
        // RVA: 0x096BAAFC  token: 0x60000A6
        private System.Boolean <set_EntryCode>b__42_0(System.Int32 p) { }

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct CopyToClipboardStates
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates Hidden;  // const
        public static SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates Visible;  // const
        public static SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates Activated;  // const

    }

    // TypeToken: 0x200002A  // size: 0x30
    public sealed class <FadeCopyButton>d__44 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public SRDebugger.UI.Tabs.ConsoleTabController <>4__this;  // 0x20
        private System.Single <startTime>5__2;  // 0x28
        private System.Single <endTime>5__3;  // 0x2c

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000E2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000E3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096BA0B4  token: 0x60000E4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096BA240  token: 0x60000E6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200002D  // size: 0x20
    public class CategoryInstance
    {
        // Fields
        private SRDebugger.UI.Other.CategoryGroup <CategoryGroup>k__BackingField;  // 0x10
        public readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> Options;  // 0x18

        // Properties
        SRDebugger.UI.Other.CategoryGroup CategoryGroup { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x096AB90C  token: 0x6000104
        public System.Void .ctor(SRDebugger.UI.Other.CategoryGroup group) { }

    }

    // TypeToken: 0x200002E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly SRDebugger.UI.Tabs.OptionsTabController.<>c <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<SRDebugger.OptionDefinition>>,System.String> <>9__29_0;  // static @ 0x8
        public static System.Comparison<SRDebugger.OptionDefinition> <>9__30_0;  // static @ 0x10

        // Methods
        // RVA: 0x096BAC20  token: 0x6000105
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000106
        public System.Void .ctor() { }
        // RVA: 0x096BAA9C  token: 0x6000107
        private System.String <Populate>b__29_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<SRDebugger.OptionDefinition>> p) { }
        // RVA: 0x096BA9E8  token: 0x6000108
        private System.Int32 <CreateCategory>b__30_0(SRDebugger.OptionDefinition d1, SRDebugger.OptionDefinition d2) { }

    }

    // TypeToken: 0x200002F  // size: 0x20
    public sealed class <>c__DisplayClass30_0
    {
        // Fields
        public SRDebugger.UI.Tabs.OptionsTabController <>4__this;  // 0x10
        public SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance categoryInstance;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000109
        public System.Void .ctor() { }
        // RVA: 0x096BAB5C  token: 0x600010A
        private System.Void <CreateCategory>b__1(System.Boolean b) { }

    }

    // TypeToken: 0x2000033  // size: 0x28
    public sealed class <SubmitCo>d__18 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public SRDebugger.UI.Other.BugReportSheetController <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000122
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000123
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096BA564  token: 0x6000124
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096BA99C  token: 0x6000126
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000044  // size: 0x20
    public sealed class <>c__DisplayClass15_0
    {
        // Fields
        public SRDebugger.UI.Other.SRTabController <>4__this;  // 0x10
        public SRDebugger.UI.Other.SRTab tab;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000181
        public System.Void .ctor() { }
        // RVA: 0x096BAB34  token: 0x6000182
        private System.Void <AddTab>b__0() { }

    }

    // TypeToken: 0x2000045  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly SRDebugger.UI.Other.SRTabController.<>c <>9;  // static @ 0x0
        public static System.Comparison<SRDebugger.UI.Other.SRTab> <>9__17_0;  // static @ 0x8

        // Methods
        // RVA: 0x096BAC84  token: 0x6000183
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000184
        public System.Void .ctor() { }
        // RVA: 0x096BAAD0  token: 0x6000185
        private System.Int32 <SortTabs>b__17_0(SRDebugger.UI.Other.SRTab t1, SRDebugger.UI.Other.SRTab t2) { }

    }

    // TypeToken: 0x200004A  // size: 0x28
    public sealed class <ScrollToBottom>d__30 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public SRDebugger.UI.Controls.ConsoleLogControl <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001A2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001A3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096BA400  token: 0x60001A4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096BA518  token: 0x60001A6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000051  // size: 0x20
    public sealed class <>c__DisplayClass14_0
    {
        // Fields
        public System.Int32 number;  // 0x10
        public SRDebugger.UI.Controls.PinEntryControl <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001D7
        public System.Void .ctor() { }
        // RVA: 0x096BAB0C  token: 0x60001D8
        private System.Void <Awake>b__0() { }

    }

    // TypeToken: 0x2000053  // size: 0x28
    public sealed class <CleanUp>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public SRDebugger.UI.Controls.ProfilerMemoryBlock <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001DF
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001E0
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096B9FC0  token: 0x60001E1
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096BA068  token: 0x60001E3
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000058  // size: 0x14
    public sealed struct VerticalAlignments
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments Top;  // const
        public static SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments Bottom;  // const

    }

    // TypeToken: 0x200005E  // size: 0x20
    public sealed struct ValueRange
    {
        // Fields
        public System.Double MaxValue;  // 0x10
        public System.Double MinValue;  // 0x18

    }

    // TypeToken: 0x2000078  // size: 0x18
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public SRDebugger.Services.BugReportCompleteCallback completeHandler;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002B8
        public System.Void .ctor() { }
        // RVA: 0x096BAB8C  token: 0x60002B9
        private System.Void <SendBugReport>b__0(SRDebugger.BugReportSubmitResult result) { }

    }

    // TypeToken: 0x200007A  // size: 0x38
    public sealed class <OpenCo>d__7 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Boolean takeScreenshot;  // 0x20
        public SRDebugger.Services.Implementation.BugReportPopoverService <>4__this;  // 0x28
        public System.String descriptionText;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002C5
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002C6
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096BA28C  token: 0x60002C7
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096BA3B4  token: 0x60002C9
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000081  // size: 0x20
    public class OptionContainerEventHandler : System.IDisposable
    {
        // Fields
        private readonly SRDebugger.Services.Implementation.OptionsServiceImpl _service;  // 0x10
        private readonly SRDebugger.IOptionContainer _container;  // 0x18

        // Methods
        // RVA: 0x096BDD64  token: 0x6000303
        public System.Void .ctor(SRDebugger.Services.Implementation.OptionsServiceImpl service, SRDebugger.IOptionContainer container) { }
        // RVA: 0x096BDBA0  token: 0x6000304
        private System.Void ContainerOnOptionAdded(SRDebugger.OptionDefinition obj) { }
        // RVA: 0x096BDBCC  token: 0x6000305
        private System.Void ContainerOnOptionRemoved(SRDebugger.OptionDefinition obj) { }
        // RVA: 0x096BDBF8  token: 0x6000306
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x2000082  // size: 0x20
    public class ReflectionOptionContainer : SRDebugger.IOptionContainer
    {
        // Fields
        private System.Collections.Generic.List<SRDebugger.OptionDefinition> _options;  // 0x10
        private readonly System.Object _target;  // 0x18

        // Properties
        System.Boolean IsDynamic { get; /* RVA: 0x0115F4C0 */ }
        System.Collections.Generic.List<SRDebugger.OptionDefinition> Options { get; /* RVA: 0x03D3CD20 */ }

        // Events
        event System.Action<SRDebugger.OptionDefinition> OptionAdded;
        event System.Action<SRDebugger.OptionDefinition> OptionRemoved;

        // Methods
        // RVA: 0x04276BB8  token: 0x600030D
        public virtual System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions() { }
        // RVA: 0x022C3A90  token: 0x600030E
        public System.Void .ctor(System.Object target) { }
        // RVA: 0x096C102C  token: 0x600030F
        protected System.Boolean Equals(SRDebugger.Services.Implementation.OptionsServiceImpl.ReflectionOptionContainer other) { }
        // RVA: 0x096C0F78  token: 0x6000310
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x03D4A220  token: 0x6000311
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000086  // size: 0x18
    public sealed class <>c__DisplayClass51_0
    {
        // Fields
        public SRDebugger.ActionCompleteCallback onComplete;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000353
        public System.Void .ctor() { }
        // RVA: 0x096C57B8  token: 0x6000354
        private System.Void <ShowBugReportSheet>b__0(System.Boolean succeed, System.String message) { }

    }

    // TypeToken: 0x2000089  // size: 0x18
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public SRDebugger.InfoEntry info;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000375
        public System.Void .ctor() { }
        // RVA: 0x05830650  token: 0x6000376
        private System.Boolean <Add>b__0(SRDebugger.InfoEntry p) { }

    }

    // TypeToken: 0x200008A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly SRDebugger.Services.Implementation.StandardSystemInformationService.<>c <>9;  // static @ 0x0
        public static System.Func<System.Object> <>9__6_0;  // static @ 0x8
        public static System.Func<System.Object> <>9__6_1;  // static @ 0x10
        public static System.Func<System.Object> <>9__6_2;  // static @ 0x18
        public static System.Func<System.Object> <>9__6_3;  // static @ 0x20
        public static System.Func<System.Object> <>9__6_4;  // static @ 0x28
        public static System.Func<System.Object> <>9__6_5;  // static @ 0x30
        public static System.Func<System.Object> <>9__6_6;  // static @ 0x38
        public static System.Func<System.Object> <>9__6_7;  // static @ 0x40
        public static System.Func<System.Object> <>9__6_8;  // static @ 0x48

        // Methods
        // RVA: 0x03D13B50  token: 0x6000377
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000378
        public System.Void .ctor() { }
        // RVA: 0x096C5414  token: 0x6000379
        private System.Object <CreateDefaultSet>b__6_0() { }
        // RVA: 0x096C5484  token: 0x600037A
        private System.Object <CreateDefaultSet>b__6_1() { }
        // RVA: 0x096C54C8  token: 0x600037B
        private System.Object <CreateDefaultSet>b__6_2() { }
        // RVA: 0x096C550C  token: 0x600037C
        private System.Object <CreateDefaultSet>b__6_3() { }
        // RVA: 0x096C5550  token: 0x600037D
        private System.Object <CreateDefaultSet>b__6_4() { }
        // RVA: 0x096C5594  token: 0x600037E
        private System.Object <CreateDefaultSet>b__6_5() { }
        // RVA: 0x096C55D8  token: 0x600037F
        private System.Object <CreateDefaultSet>b__6_6() { }
        // RVA: 0x096C561C  token: 0x6000380
        private System.Object <CreateDefaultSet>b__6_7() { }
        // RVA: 0x096C5720  token: 0x6000381
        private System.Object <CreateDefaultSet>b__6_8() { }

    }

    // TypeToken: 0x200008E  // size: 0x30
    public sealed class <EndOfFrameCoroutine>d__19 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public SRDebugger.Profiler.SRPProfilerService <>4__this;  // 0x20
        private UnityEngine.WaitForEndOfFrame <endOfFrame>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600039E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600039F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0233AC40  token: 0x60003A0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096C4BFC  token: 0x60003A2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000092  // size: 0x28
    public sealed class <Submit>d__9 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public SRDebugger.Internal.BugReportApi <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003B0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003B1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096C4E70  token: 0x60003B2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096C53C8  token: 0x60003B4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000094  // size: 0x20
    public sealed class <ScreenshotCaptureCo>d__1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003B8
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003B9
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096C4C48  token: 0x60003BA
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096C4E24  token: 0x60003BC
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000098  // size: 0x20
    public sealed struct OptionType
    {
        // Fields
        public readonly System.Type Type;  // 0x10
        public readonly System.Boolean IsReadyOnly;  // 0x18

        // Methods
        // RVA: 0x071B198C  token: 0x60003CB
        public System.Void .ctor(System.Type type, System.Boolean isReadyOnly) { }
        // RVA: 0x096BE908  token: 0x60003CC
        public System.Boolean Equals(SRDebugger.Internal.OptionControlFactory.OptionType other) { }
        // RVA: 0x096BE898  token: 0x60003CD
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x096BE940  token: 0x60003CE
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000099  // size: 0x18
    public sealed class <>c__DisplayClass8_0
    {
        // Fields
        public SRDebugger.OptionDefinition from;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60003CF
        public System.Void .ctor() { }
        // RVA: 0x096C57D0  token: 0x60003D0
        private System.Boolean <TryGetDataControlPrefab>b__0(SRDebugger.UI.Controls.DataBoundControl p) { }

    }

    // TypeToken: 0x200009F  // size: 0x34
    public sealed struct __StaticArrayInitTypeSize=36
    {
    }

    // TypeToken: 0x200009E  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0B92E635AE849B517CA3A2F28C2502AF8675E5C6C01CD75EA9F53120E81DDAAA;  // static @ 0x0

    }

namespace Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation
{

    // TypeToken: 0x2000004  // size: 0x20
    public sealed class ConsoleFilterStateService : SRDebugger.Services.IConsoleFilterState
    {
        // Fields
        private SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;  // 0x10
        private readonly System.Boolean[] _states;  // 0x18

        // Events
        event SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;

        // Methods
        // RVA: 0x096AC424  token: 0x600000C
        public System.Void .ctor() { }
        // RVA: 0x096AC2CC  token: 0x600000D
        public virtual System.Void SetConsoleFilterState(UnityEngine.LogType type, System.Boolean newState) { }
        // RVA: 0x096AC250  token: 0x600000E
        public virtual System.Boolean GetConsoleFilterState(UnityEngine.LogType type) { }
        // RVA: 0x096AC28C  token: 0x600000F
        private static UnityEngine.LogType GetType(UnityEngine.LogType type) { }

    }

}

namespace SRDebugger
{

    // TypeToken: 0x2000005  // size: 0x10
    public static class AutoInitialize
    {
        // Fields
        private static UnityEngine.RuntimeInitializeLoadType InitializeLoadType;  // const

        // Methods
        // RVA: 0x03A274B0  token: 0x6000010
        public static System.Void OnLoadBeforeScene() { }
        // RVA: 0x03A27360  token: 0x6000011
        public static System.Void OnLoad() { }

    }

    // TypeToken: 0x2000006  // size: 0x38
    public class BugReport
    {
        // Fields
        public System.Collections.Generic.List<SRDebugger.Services.ConsoleEntry> ConsoleLog;  // 0x10
        public System.String Email;  // 0x18
        public System.Byte[] ScreenshotData;  // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> SystemInformation;  // 0x28
        public System.String UserDescription;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x6000012
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x20
    public sealed class BugReportSubmitResult
    {
        // Fields
        private readonly System.Boolean <IsSuccessful>k__BackingField;  // 0x10
        private readonly System.String <ErrorMessage>k__BackingField;  // 0x18

        // Properties
        SRDebugger.BugReportSubmitResult Success { get; /* RVA: 0x096AB4A0 */ }
        System.Boolean IsSuccessful { get; /* RVA: 0x011797F0 */ }
        System.String ErrorMessage { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x096AB444  token: 0x6000014
        public static SRDebugger.BugReportSubmitResult Error(System.String errorMessage) { }
        // RVA: 0x02F73D00  token: 0x6000017
        private System.Void .ctor(System.Boolean successful, System.String error) { }

    }

    // TypeToken: 0x2000008
    public interface IBugReporterHandler
    {
        // Properties
        System.Boolean IsUsable { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000019
        public virtual System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }

    }

    // TypeToken: 0x2000009
    public class CircularBuffer`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        private readonly T[] _buffer;  // 0x0
        private System.Int32 _end;  // 0x0
        private System.Int32 _count;  // 0x0
        private System.Int32 _start;  // 0x0

        // Properties
        System.Int32 Capacity { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsFull { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsEmpty { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600001A
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x600001B
        public System.Void .ctor(System.Int32 capacity, T[] items) { }
        // RVA: -1  // not resolved  token: 0x6000022
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000023
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000024
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000025
        public T Front() { }
        // RVA: -1  // not resolved  token: 0x6000026
        public T Back() { }
        // RVA: -1  // not resolved  token: 0x6000027
        public System.Void PushBack(T item) { }
        // RVA: -1  // not resolved  token: 0x6000028
        public System.Void PushFront(T item) { }
        // RVA: -1  // not resolved  token: 0x6000029
        public System.Void PopBack() { }
        // RVA: -1  // not resolved  token: 0x600002A
        public System.Void PopFront() { }
        // RVA: -1  // not resolved  token: 0x600002B
        public T[] ToArray() { }
        // RVA: -1  // not resolved  token: 0x600002C
        private System.Void ThrowIfEmpty(System.String message) { }
        // RVA: -1  // not resolved  token: 0x600002D
        private System.Void Increment(System.Int32& index) { }
        // RVA: -1  // not resolved  token: 0x600002E
        private System.Void Decrement(System.Int32& index) { }
        // RVA: -1  // not resolved  token: 0x600002F
        private System.Int32 InternalIndex(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000030
        private System.ArraySegment<T> ArrayOne() { }
        // RVA: -1  // not resolved  token: 0x6000031
        private System.ArraySegment<T> ArrayTwo() { }

    }

    // TypeToken: 0x200000B  // size: 0x38
    public sealed class OptionDefinition
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private System.String <Category>k__BackingField;  // 0x18
        private System.Int32 <SortPriority>k__BackingField;  // 0x20
        private SRF.Helpers.MethodReference <Method>k__BackingField;  // 0x28
        private SRF.Helpers.PropertyReference <Property>k__BackingField;  // 0x30

        // Properties
        System.String Name { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String Category { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Int32 SortPriority { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x01003B60 */ }
        System.Boolean IsMethod { get; /* RVA: 0x05693D38 */ }
        System.Boolean IsProperty { get; /* RVA: 0x085839D0 */ }
        SRF.Helpers.MethodReference Method { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        SRF.Helpers.PropertyReference Property { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x03864580  token: 0x6000044
        private System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority) { }
        // RVA: 0x096B37D0  token: 0x6000045
        public System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.MethodReference method) { }
        // RVA: 0x096B37A0  token: 0x6000046
        public System.Void .ctor(System.String name, System.String category, System.Int32 sortPriority, SRF.Helpers.PropertyReference property) { }
        // RVA: 0x096B36FC  token: 0x6000047
        public static SRDebugger.OptionDefinition FromMethod(System.String name, System.Action callback, System.String category, System.Int32 sortPriority) { }
        // RVA: -1  // generic def  token: 0x6000048
        public static SRDebugger.OptionDefinition Create(System.String name, System.Func<T> getter, System.Action<T> setter, System.String category, System.Int32 sortPriority) { }

    }

    // TypeToken: 0x200000C
    public interface IOptionContainer
    {
        // Properties
        System.Boolean IsDynamic { get; /* RVA: -1  // abstract */ }

        // Events
        event System.Action<SRDebugger.OptionDefinition> OptionAdded;
        event System.Action<SRDebugger.OptionDefinition> OptionRemoved;

        // Methods
        // RVA: -1  // abstract  token: 0x6000049
        public virtual System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> GetOptions() { }

    }

    // TypeToken: 0x200000D  // size: 0x30
    public sealed class DynamicOptionContainer : SRDebugger.IOptionContainer
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.OptionDefinition> _options;  // 0x10
        private readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition> _optionsReadOnly;  // 0x18
        private System.Action<SRDebugger.OptionDefinition> OptionAdded;  // 0x20
        private System.Action<SRDebugger.OptionDefinition> OptionRemoved;  // 0x28

        // Properties
        System.Collections.Generic.IList<SRDebugger.OptionDefinition> Options { get; /* RVA: 0x01041090 */ }
        System.Boolean IsDynamic { get; /* RVA: 0x0232EB60 */ }

        // Events
        event System.Action<SRDebugger.OptionDefinition> OptionAdded;
        event System.Action<SRDebugger.OptionDefinition> OptionRemoved;

        // Methods
        // RVA: 0x096B01B0  token: 0x6000050
        public System.Void .ctor() { }
        // RVA: 0x096B00D0  token: 0x6000051
        public System.Void AddOption(SRDebugger.OptionDefinition option) { }
        // RVA: 0x096B013C  token: 0x6000052
        public System.Boolean RemoveOption(SRDebugger.OptionDefinition option) { }
        // RVA: 0x020B7B20  token: 0x6000053
        private virtual System.Collections.Generic.IEnumerable<SRDebugger.OptionDefinition> SRDebugger.IOptionContainer.GetOptions() { }

    }

    // TypeToken: 0x200000E  // size: 0x80
    public sealed class VisibilityChangedDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06892B88  token: 0x6000059
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600005A
        public virtual System.Void Invoke(System.Boolean isVisible) { }
        // RVA: 0x096BAD94  token: 0x600005B
        public virtual System.IAsyncResult BeginInvoke(System.Boolean isVisible, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600005C
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000F  // size: 0x80
    public sealed class ActionCompleteCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06892B88  token: 0x600005D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600005E
        public virtual System.Void Invoke(System.Boolean success) { }
        // RVA: 0x096A9AB8  token: 0x600005F
        public virtual System.IAsyncResult BeginInvoke(System.Boolean success, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000060
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000010  // size: 0x80
    public sealed class PinnedUiCanvasCreated : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x6000061
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000062
        public virtual System.Void Invoke(UnityEngine.RectTransform canvasTransform) { }
        // RVA: 0x0389C3B0  token: 0x6000063
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.RectTransform canvasTransform, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000064
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public sealed struct EntryCode : System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        public readonly System.Int32 Digit1;  // 0x10
        public readonly System.Int32 Digit2;  // 0x14
        public readonly System.Int32 Digit3;  // 0x18
        public readonly System.Int32 Digit4;  // 0x1c

        // Properties
        System.Int32 Count { get; /* RVA: 0x03D50CD0 */ }
        System.Int32 Item { get; /* RVA: 0x096B0774 */ }

        // Methods
        // RVA: 0x096B059C  token: 0x6000065
        public System.Void .ctor(System.Int32 digit1, System.Int32 digit2, System.Int32 digit3, System.Int32 digit4) { }
        // RVA: 0x096B0484  token: 0x6000066
        public virtual System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() { }
        // RVA: 0x096B0594  token: 0x6000067
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000012  // size: 0x28
    public sealed class InfoEntry
    {
        // Fields
        private System.String <Title>k__BackingField;  // 0x10
        private System.Boolean <IsPrivate>k__BackingField;  // 0x18
        private System.Func<System.Object> _valueGetter;  // 0x20

        // Properties
        System.String Title { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Object Value { get; /* RVA: 0x096B1100 */ }
        System.Boolean IsPrivate { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x0315D1E0  token: 0x600006F
        public static SRDebugger.InfoEntry Create(System.String name, System.Func<System.Object> getter, System.Boolean isPrivate) { }
        // RVA: 0x0315D270  token: 0x6000070
        public static SRDebugger.InfoEntry Create(System.String name, System.Object value, System.Boolean isPrivate) { }
        // RVA: 0x0350B670  token: 0x6000071
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct DefaultTabs
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.DefaultTabs SystemInformation;  // const
        public static SRDebugger.DefaultTabs Options;  // const
        public static SRDebugger.DefaultTabs Console;  // const
        public static SRDebugger.DefaultTabs Profiler;  // const
        public static SRDebugger.DefaultTabs BugReporter;  // const

    }

    // TypeToken: 0x2000015  // size: 0x14
    public sealed struct PinAlignment
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.PinAlignment TopLeft;  // const
        public static SRDebugger.PinAlignment TopRight;  // const
        public static SRDebugger.PinAlignment BottomLeft;  // const
        public static SRDebugger.PinAlignment BottomRight;  // const
        public static SRDebugger.PinAlignment CenterLeft;  // const
        public static SRDebugger.PinAlignment CenterRight;  // const
        public static SRDebugger.PinAlignment TopCenter;  // const
        public static SRDebugger.PinAlignment BottomCenter;  // const

    }

    // TypeToken: 0x2000016  // size: 0x14
    public sealed struct ConsoleAlignment
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRDebugger.ConsoleAlignment Top;  // const
        public static SRDebugger.ConsoleAlignment Bottom;  // const

    }

    // TypeToken: 0x2000017  // size: 0xA8
    public class Settings : UnityEngine.ScriptableObject
    {
        // Fields
        private static System.String ResourcesName;  // const
        private static SRDebugger.Settings _instance;  // static @ 0x0
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;  // 0x18
        private System.Boolean _isEnabled;  // 0x20
        private System.Boolean _disableWelcomePopup;  // 0x21
        private SRDebugger.Settings.UIModes _uiInputMode;  // 0x24
        private SRDebugger.DefaultTabs _defaultTab;  // 0x28
        private SRDebugger.Settings.TriggerEnableModes _triggerEnableMode;  // 0x2c
        private SRDebugger.Settings.TriggerBehaviours _triggerBehaviour;  // 0x30
        private System.Boolean _errorNotification;  // 0x34
        private System.Boolean _enableKeyboardShortcuts;  // 0x35
        private SRDebugger.Settings.KeyboardShortcut[] _keyboardShortcuts;  // 0x38
        private SRDebugger.Settings.KeyboardShortcut[] _newKeyboardShortcuts;  // 0x40
        private System.Boolean _keyboardModifierControl;  // 0x48
        private System.Boolean _keyboardModifierAlt;  // 0x49
        private System.Boolean _keyboardModifierShift;  // 0x4a
        private System.Boolean _keyboardEscapeClose;  // 0x4b
        private System.Boolean _enableBackgroundTransparency;  // 0x4c
        private System.Single _backgroundTransparency;  // 0x50
        private System.Boolean _collapseDuplicateLogEntries;  // 0x54
        private System.Boolean _richTextInConsole;  // 0x55
        private System.Boolean _requireEntryCode;  // 0x56
        private System.Boolean _requireEntryCodeEveryTime;  // 0x57
        private System.Int32[] _entryCode;  // 0x58
        private System.Boolean _useDebugCamera;  // 0x60
        private System.Int32 _debugLayer;  // 0x64
        private System.Single _debugCameraDepth;  // 0x68
        private System.String _apiKey;  // 0x70
        private System.Boolean _enableBugReporter;  // 0x78
        private System.Boolean _enableBugReportScreenshot;  // 0x79
        private SRDebugger.DefaultTabs[] _disabledTabs;  // 0x80
        private SRDebugger.PinAlignment _profilerAlignment;  // 0x88
        private SRDebugger.PinAlignment _optionsAlignment;  // 0x8c
        private SRDebugger.ConsoleAlignment _consoleAlignment;  // 0x90
        private SRDebugger.PinAlignment _triggerPosition;  // 0x94
        private System.Int32 _maximumConsoleEntries;  // 0x98
        private System.Boolean _enableEventSystemCreation;  // 0x9c
        private System.Boolean _automaticShowCursor;  // 0x9d
        private System.Single _uiScale;  // 0xa0
        private System.Boolean _unloadOnClose;  // 0xa4

        // Properties
        SRDebugger.Settings Instance { get; /* RVA: 0x0267B8C0 */ }
        System.Boolean IsEnabled { get; /* RVA: 0x03D4EF90 */ }
        SRDebugger.Settings.UIModes UIInputMode { get; /* RVA: 0x03D4E2E0 */ }
        SRDebugger.DefaultTabs DefaultTab { get; /* RVA: 0x03D4EB90 */ }
        SRDebugger.Settings.TriggerEnableModes EnableTrigger { get; /* RVA: 0x03D4EDD0 */ }
        SRDebugger.Settings.TriggerBehaviours TriggerBehaviour { get; /* RVA: 0x03D4ED20 */ }
        System.Boolean ErrorNotification { get; /* RVA: 0x03D4F570 */ }
        System.Boolean EnableKeyboardShortcuts { get; /* RVA: 0x03D4F560 */ }
        System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> KeyboardShortcuts { get; /* RVA: 0x03D4E2B0 */ }
        System.Boolean KeyboardEscapeClose { get; /* RVA: 0x03D56CD0 */ }
        System.Boolean EnableBackgroundTransparency { get; /* RVA: 0x03D4F520 */ }
        System.Single BackgroundTransparency { get; /* RVA: 0x03D51C90 */ }
        System.Boolean RequireCode { get; /* RVA: 0x03D58490 */ }
        System.Boolean RequireEntryCodeEveryTime { get; /* RVA: 0x03D58480 */ }
        System.Collections.Generic.IList<System.Int32> EntryCode { get; /* RVA: 0x096B99F8 */ set; /* RVA: 0x096B9B00 */ }
        System.Boolean UseDebugCamera { get; /* RVA: 0x03D519A0 */ }
        System.Int32 DebugLayer { get; /* RVA: 0x03D50B30 */ }
        System.Single DebugCameraDepth { get; /* RVA: 0x03D56A40 */ }
        System.Boolean CollapseDuplicateLogEntries { get; /* RVA: 0x03D4F320 */ }
        System.Boolean RichTextInConsole { get; /* RVA: 0x03D4F310 */ }
        System.String ApiKey { get; /* RVA: 0x03D4EB30 */ }
        System.Boolean EnableBugReporter { get; /* RVA: 0x03D4F800 */ }
        System.Boolean EnableBugReportScreenshot { get; /* RVA: 0x03D51AE0 */ }
        System.Collections.Generic.IList<SRDebugger.DefaultTabs> DisabledTabs { get; /* RVA: 0x03D4EAE0 */ }
        SRDebugger.PinAlignment TriggerPosition { get; /* RVA: 0x03D5B3A0 */ }
        SRDebugger.PinAlignment ProfilerAlignment { get; /* RVA: 0x03D4F0B0 */ }
        SRDebugger.PinAlignment OptionsAlignment { get; /* RVA: 0x03D4F3D0 */ }
        SRDebugger.ConsoleAlignment ConsoleAlignment { get; /* RVA: 0x03D4FB60 */ set; /* RVA: 0x03D4FB70 */ }
        System.Int32 MaximumConsoleEntries { get; /* RVA: 0x03D4EB50 */ set; /* RVA: 0x03D4EB80 */ }
        System.Boolean EnableEventSystemGeneration { get; /* RVA: 0x03D5E1C0 */ set; /* RVA: 0x03D5E200 */ }
        System.Boolean AutomaticallyShowCursor { get; /* RVA: 0x03D6E090 */ }
        System.Single UIScale { get; /* RVA: 0x03D58340 */ set; /* RVA: 0x096B9D10 */ }
        System.Boolean UnloadOnClose { get; /* RVA: 0x03D58450 */ }

        // Events
        event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        // Methods
        // RVA: 0x0389EEB0  token: 0x6000075
        private static SRDebugger.Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts() { }
        // RVA: 0x03A44180  token: 0x6000076
        private System.Void UpgradeKeyboardShortcuts() { }
        // RVA: 0x096B98D4  token: 0x600009E
        private System.Void OnPropertyChanged(System.String propertyName) { }
        // RVA: 0x096B9834  token: 0x600009F
        private static System.Void ClearCache() { }
        // RVA: 0x03A44130  token: 0x60000A0
        private static SRDebugger.Settings GetInstance() { }
        // RVA: 0x03A44090  token: 0x60000A1
        private static SRDebugger.Settings GetOrCreateInstance() { }
        // RVA: 0x0389ED90  token: 0x60000A2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E  // size: 0x48
    public class SRDebuggerInit : SRF.SRMonoBehaviourEx
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x60000A7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x20
    public class NumberRangeAttribute : System.Attribute
    {
        // Fields
        public readonly System.Double Max;  // 0x10
        public readonly System.Double Min;  // 0x18

        // Methods
        // RVA: 0x03D4E420  token: 0x60000A8
        public System.Void .ctor(System.Double min, System.Double max) { }

    }

    // TypeToken: 0x2000020  // size: 0x18
    public class IncrementAttribute : System.Attribute
    {
        // Fields
        public readonly System.Double Increment;  // 0x10

        // Methods
        // RVA: 0x03D4E410  token: 0x60000A9
        public System.Void .ctor(System.Double increment) { }

    }

    // TypeToken: 0x2000021  // size: 0x18
    public class SortAttribute : System.Attribute
    {
        // Fields
        public readonly System.Int32 SortPriority;  // 0x10

        // Methods
        // RVA: 0x010410F0  token: 0x60000AA
        public System.Void .ctor(System.Int32 priority) { }

    }

    // TypeToken: 0x2000022  // size: 0x10
    public static class VersionInfo
    {
        // Fields
        public static System.String Version;  // const

    }

}

namespace SRDebugger.Internal
{

    // TypeToken: 0x200008F  // size: 0x10
    public static class SRDebugApi
    {
        // Fields
        public static System.String Protocol;  // const
        public static System.String EndPoint;  // const
        public static System.String BugReportEndPoint;  // const

    }

    // TypeToken: 0x2000090  // size: 0x10
    public static class SRDebugApiUtil
    {
        // Methods
        // RVA: 0x096C1054  token: 0x60003A4
        public static System.String ParseErrorException(System.Net.WebException ex) { }
        // RVA: 0x096C1130  token: 0x60003A5
        public static System.String ParseErrorResponse(System.String response, System.String fallback) { }
        // RVA: 0x096C1750  token: 0x60003A6
        public static System.Boolean ReadResponse(System.Net.HttpWebRequest request, System.String& result) { }
        // RVA: 0x096C15C8  token: 0x60003A7
        public static System.String ReadResponseStream(System.Net.WebResponse stream) { }

    }

    // TypeToken: 0x2000091  // size: 0x48
    public class BugReportApi : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.String _apiKey;  // 0x18
        private SRDebugger.BugReport _bugReport;  // 0x20
        private System.Boolean _isBusy;  // 0x28
        private UnityEngine.Networking.UnityWebRequest _webRequest;  // 0x30
        private System.Action<SRDebugger.BugReportSubmitResult> _onComplete;  // 0x38
        private System.IProgress<System.Single> _progress;  // 0x40

        // Methods
        // RVA: 0x096BB654  token: 0x60003A8
        public static System.Void Submit(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }
        // RVA: 0x096BB520  token: 0x60003A9
        private System.Void Init(SRDebugger.BugReport report, System.String apiKey, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }
        // RVA: 0x096BB7F0  token: 0x60003AA
        private System.Void Update() { }
        // RVA: 0x096BB794  token: 0x60003AB
        private System.Collections.IEnumerator Submit() { }
        // RVA: 0x096BB568  token: 0x60003AC
        private System.Void SetCompletionState(SRDebugger.BugReportSubmitResult result) { }
        // RVA: 0x096BB0B8  token: 0x60003AD
        private static System.String BuildJsonRequest(SRDebugger.BugReport report) { }
        // RVA: 0x096BB234  token: 0x60003AE
        private static System.Collections.Generic.List<System.Collections.Generic.List<System.String>> CreateConsoleDump() { }
        // RVA: 0x0426FE60  token: 0x60003AF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000093  // size: 0x10
    public class BugReportScreenshotUtil
    {
        // Fields
        public static System.Byte[] ScreenshotData;  // static @ 0x0

        // Methods
        // RVA: 0x096BB860  token: 0x60003B6
        public static System.Collections.IEnumerator ScreenshotCaptureCo() { }
        // RVA: 0x0350B670  token: 0x60003B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000095  // size: 0x10
    public class InternalBugReporterHandler : SRDebugger.IBugReporterHandler
    {
        // Properties
        System.Boolean IsUsable { get; /* RVA: 0x096BCE4C */ }

        // Methods
        // RVA: 0x096BCDF8  token: 0x60003BF
        public virtual System.Void Submit(SRDebugger.BugReport report, System.Action<SRDebugger.BugReportSubmitResult> onComplete, System.IProgress<System.Single> progress) { }
        // RVA: 0x0350B670  token: 0x60003C0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000096  // size: 0x20
    public sealed class InternalOptionsRegistry
    {
        // Fields
        private System.Collections.Generic.List<System.Object> _registeredContainers;  // 0x10
        private System.Action<System.Object> _handler;  // 0x18

        // Methods
        // RVA: 0x026CCCF0  token: 0x60003C1
        public System.Void AddOptionContainer(System.Object obj) { }
        // RVA: 0x026CBDD0  token: 0x60003C2
        public System.Void SetHandler(System.Action<System.Object> action) { }
        // RVA: 0x03CFD4F0  token: 0x60003C3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000097  // size: 0x10
    public static class OptionControlFactory
    {
        // Fields
        private static System.Collections.Generic.IList<SRDebugger.UI.Controls.DataBoundControl> _dataControlPrefabs;  // static @ 0x0
        private static SRDebugger.UI.Controls.Data.ActionControl _actionControlPrefab;  // static @ 0x8
        private static readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionControlFactory.OptionType,SRDebugger.UI.Controls.DataBoundControl> TypeCache;  // static @ 0x10

        // Methods
        // RVA: 0x096BDEE4  token: 0x60003C4
        public static System.Boolean CanCreateControl(SRDebugger.OptionDefinition from) { }
        // RVA: 0x096BE08C  token: 0x60003C5
        public static SRDebugger.UI.Controls.OptionsControlBase CreateControl(SRDebugger.OptionDefinition from, System.String categoryPrefix) { }
        // RVA: 0x096BE45C  token: 0x60003C6
        private static System.Void PopulateDataControlPrefabs() { }
        // RVA: 0x096BDF8C  token: 0x60003C7
        private static SRDebugger.UI.Controls.Data.ActionControl CreateActionControl(SRDebugger.OptionDefinition from, System.String categoryPrefix) { }
        // RVA: 0x096BE178  token: 0x60003C8
        private static SRDebugger.UI.Controls.DataBoundControl CreateDataControl(SRDebugger.OptionDefinition from, System.String categoryPrefix) { }
        // RVA: 0x096BE628  token: 0x60003C9
        private static SRDebugger.UI.Controls.DataBoundControl TryGetDataControlPrefab(SRDebugger.OptionDefinition from) { }
        // RVA: 0x096BE804  token: 0x60003CA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009A  // size: 0x10
    public static class SRDebugPaths
    {
        // Fields
        public static System.String DataControlsResourcesPath;  // const
        public static System.String TriggerPrefabPath;  // const
        public static System.String DebugPanelPrefabPath;  // const
        public static System.String PinnedUIPrefabPath;  // const
        public static System.String DockConsolePrefabPath;  // const
        public static System.String PinEntryPrefabPath;  // const
        public static System.String BugReportPopoverPath;  // const
        public static System.String BugReportSheetPath;  // const

    }

    // TypeToken: 0x200009B  // size: 0x10
    public static class Service
    {
        // Fields
        private static SRDebugger.Services.IConsoleService _consoleService;  // static @ 0x0
        private static SRDebugger.Services.IDebugPanelService _debugPanelService;  // static @ 0x8
        private static SRDebugger.Services.IDebugTriggerService _debugTriggerService;  // static @ 0x10
        private static SRDebugger.Services.IPinnedUIService _pinnedUiService;  // static @ 0x18
        private static SRDebugger.Services.IDebugCameraService _debugCameraService;  // static @ 0x20
        private static SRDebugger.Services.IOptionsService _optionsService;  // static @ 0x28
        private static SRDebugger.Services.IDockConsoleService _dockConsoleService;  // static @ 0x30

        // Properties
        SRDebugger.Services.IConsoleService Console { get; /* RVA: 0x096C3564 */ }
        SRDebugger.Services.IDockConsoleService DockConsole { get; /* RVA: 0x096C36AC */ }
        SRDebugger.Services.IDebugPanelService Panel { get; /* RVA: 0x096C37FC */ }
        SRDebugger.Services.IDebugTriggerService Trigger { get; /* RVA: 0x096C394C */ }
        SRDebugger.Services.IPinnedUIService PinnedUI { get; /* RVA: 0x096C38A4 */ }
        SRDebugger.Services.IDebugCameraService DebugCamera { get; /* RVA: 0x096C3604 */ }
        SRDebugger.Services.IOptionsService Options { get; /* RVA: 0x096C3754 */ }

    }

    // TypeToken: 0x200009C  // size: 0x50
    public class SRDebugStrings
    {
        // Fields
        public static readonly SRDebugger.Internal.SRDebugStrings Current;  // static @ 0x0
        public readonly System.String Console_MessageTruncated;  // 0x10
        public readonly System.String Console_NoStackTrace;  // 0x18
        public readonly System.String PinEntryPrompt;  // 0x20
        public readonly System.String Profiler_DisableProfilerInfo;  // 0x28
        public readonly System.String Profiler_EnableProfilerInfo;  // 0x30
        public readonly System.String Profiler_NoProInfo;  // 0x38
        public readonly System.String Profiler_NotSupported;  // 0x40
        public readonly System.String ProfilerCameraListenerHelp;  // 0x48

        // Methods
        // RVA: 0x096C3070  token: 0x60003D8
        public System.Void .ctor() { }
        // RVA: 0x096C3000  token: 0x60003D9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009D  // size: 0x10
    public static class SRDebuggerUtil
    {
        // Properties
        System.Boolean IsMobilePlatform { get; /* RVA: 0x096C3538 */ }

        // Methods
        // RVA: 0x096C33DC  token: 0x60003DB
        public static System.Boolean EnsureEventSystemExists() { }
        // RVA: 0x096C32DC  token: 0x60003DC
        public static System.Void CreateDefaultEventSystem() { }
        // RVA: 0x096C3190  token: 0x60003DD
        private static System.Void AddInputSystem(UnityEngine.GameObject go) { }
        // RVA: 0x096C31F0  token: 0x60003DE
        private static System.Void AddLegacyInputSystem(UnityEngine.GameObject go) { }
        // RVA: 0x02678EF0  token: 0x60003DF
        public static System.Collections.Generic.List<SRDebugger.OptionDefinition> ScanForOptions(System.Object obj) { }
        // RVA: 0x096C3514  token: 0x60003E0
        public static System.String GetNumberString(System.Int32 value, System.Int32 max, System.String exceedsMaxString) { }
        // RVA: 0x096C3234  token: 0x60003E1
        public static System.Void ConfigureCanvas(UnityEngine.Canvas canvas) { }

    }

}

namespace SRDebugger.Profiler
{

    // TypeToken: 0x200008B  // size: 0x20
    public class ProfilerLateUpdateListener : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Action OnLateUpdate;  // 0x18

        // Methods
        // RVA: 0x03180DF0  token: 0x6000382
        private System.Void LateUpdate() { }
        // RVA: 0x0426FE60  token: 0x6000383
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008C  // size: 0x88
    public class ProfilerServiceImpl : SRF.Service.SRServiceBase`1, SRDebugger.Services.IProfilerService
    {
        // Fields
        private System.Single <AverageFrameTime>k__BackingField;  // 0x48
        private System.Single <LastFrameTime>k__BackingField;  // 0x4c
        private static System.Int32 FrameBufferSize;  // const
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> _frameBuffer;  // 0x50
        private SRDebugger.Profiler.ProfilerLateUpdateListener _lateUpdateListener;  // 0x58
        private readonly System.Diagnostics.Stopwatch _stopwatch;  // 0x60
        private System.Double _updateDuration;  // 0x68
        private System.Double _renderStartTime;  // 0x70
        private System.Double _renderDuration;  // 0x78
        private System.Int32 _camerasThisFrame;  // 0x80

        // Properties
        System.Single AverageFrameTime { get; /* RVA: 0x03D58370 */ set; /* RVA: 0x03D5BE60 */ }
        System.Single LastFrameTime { get; /* RVA: 0x03D50200 */ set; /* RVA: 0x03D5E680 */ }
        SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; /* RVA: 0x03D4EAF0 */ }

        // Methods
        // RVA: 0x096C077C  token: 0x6000389
        protected virtual System.Void Awake() { }
        // RVA: 0x096C0D38  token: 0x600038A
        protected virtual System.Void Update() { }
        // RVA: 0x096C0C9C  token: 0x600038B
        protected System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime) { }
        // RVA: 0x096C0C2C  token: 0x600038C
        private System.Void OnLateUpdate() { }
        // RVA: 0x096C0BAC  token: 0x600038D
        private System.Void OnCameraPreRender(UnityEngine.Camera cam) { }
        // RVA: 0x096C0B38  token: 0x600038E
        private System.Void OnCameraPostRender(UnityEngine.Camera cam) { }
        // RVA: 0x096C0A80  token: 0x600038F
        private System.Void EndFrame() { }
        // RVA: 0x096C0EBC  token: 0x6000390
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008D  // size: 0x80
    public class SRPProfilerService : SRF.Service.SRServiceBase`1, SRDebugger.Services.IProfilerService
    {
        // Fields
        private System.Single <AverageFrameTime>k__BackingField;  // 0x48
        private System.Single <LastFrameTime>k__BackingField;  // 0x4c
        private static System.Int32 FrameBufferSize;  // const
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> _frameBuffer;  // 0x50
        private SRDebugger.Profiler.ProfilerLateUpdateListener _lateUpdateListener;  // 0x58
        private System.Double _updateDuration;  // 0x60
        private System.Double _renderStartTime;  // 0x68
        private System.Double _renderDuration;  // 0x70
        private readonly System.Diagnostics.Stopwatch _stopwatch;  // 0x78

        // Properties
        System.Single AverageFrameTime { get; /* RVA: 0x03D58370 */ set; /* RVA: 0x03D5BE60 */ }
        System.Single LastFrameTime { get; /* RVA: 0x03D50200 */ set; /* RVA: 0x03D5E680 */ }
        SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; /* RVA: 0x03D4EAF0 */ }

        // Methods
        // RVA: 0x0268DBE0  token: 0x6000396
        protected virtual System.Void Awake() { }
        // RVA: 0x0233A400  token: 0x6000397
        protected virtual System.Void Update() { }
        // RVA: 0x0268DDD0  token: 0x6000398
        private System.Collections.IEnumerator EndOfFrameCoroutine() { }
        // RVA: 0x0233AD50  token: 0x6000399
        protected System.Void PushFrame(System.Double totalTime, System.Double updateTime, System.Double renderTime) { }
        // RVA: 0x0233ABC0  token: 0x600039A
        private System.Void OnLateUpdate() { }
        // RVA: 0x0233AEA0  token: 0x600039B
        private System.Void RenderPipelineOnBeginFrameRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        // RVA: 0x0233A9E0  token: 0x600039C
        private System.Void EndFrame() { }
        // RVA: 0x03C92F70  token: 0x600039D
        public System.Void .ctor() { }

    }

}

namespace SRDebugger.Scripts
{

    // TypeToken: 0x2000023  // size: 0x70
    public class DebuggerTabController : SRF.SRMonoBehaviourEx
    {
        // Fields
        private SRDebugger.UI.Other.SRTab _aboutTabInstance;  // 0x48
        private System.Nullable<SRDebugger.DefaultTabs> _activeTab;  // 0x50
        private System.Boolean _hasStarted;  // 0x58
        public SRDebugger.UI.Other.SRTab AboutTab;  // 0x60
        public SRDebugger.UI.Other.SRTabController TabController;  // 0x68

        // Properties
        System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; /* RVA: 0x096AF248 */ }

        // Methods
        // RVA: 0x096AEE6C  token: 0x60000AC
        protected virtual System.Void Start() { }
        // RVA: 0x096AEC08  token: 0x60000AD
        public System.Boolean OpenTab(SRDebugger.DefaultTabs tab) { }
        // RVA: 0x096AEDFC  token: 0x60000AE
        public System.Void ShowAboutTab() { }
        // RVA: 0x0426FE60  token: 0x60000AF
        public System.Void .ctor() { }

    }

}

namespace SRDebugger.Services
{

    // TypeToken: 0x2000061  // size: 0x20
    public sealed class ConsoleFilterStateService
    {
        // Fields
        private SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;  // 0x10
        private System.Boolean[] _states;  // 0x18

        // Events
        event SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;

        // Methods
        // RVA: 0x096AC33C  token: 0x6000230
        public System.Void .ctor() { }
        // RVA: 0x096AC2CC  token: 0x6000231
        public System.Void SetState(UnityEngine.LogType type, System.Boolean newState) { }
        // RVA: 0x096AC250  token: 0x6000232
        public System.Boolean GetState(UnityEngine.LogType type) { }
        // RVA: 0x096AC28C  token: 0x6000233
        private static UnityEngine.LogType GetType(UnityEngine.LogType type) { }

    }

    // TypeToken: 0x2000062  // size: 0x80
    public sealed class BugReportCompleteCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x096AA3C0  token: 0x6000234
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000235
        public virtual System.Void Invoke(System.Boolean didSucceed, System.String errorMessage) { }
        // RVA: 0x096AA340  token: 0x6000236
        public virtual System.IAsyncResult BeginInvoke(System.Boolean didSucceed, System.String errorMessage, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000237
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000063  // size: 0x80
    public sealed class BugReportProgressCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x07D6D6C4  token: 0x6000238
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000239
        public virtual System.Void Invoke(System.Single progress) { }
        // RVA: 0x096AADC8  token: 0x600023A
        public virtual System.IAsyncResult BeginInvoke(System.Single progress, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600023B
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000064
    public interface IBugReportService
    {
        // Properties
        System.Boolean IsUsable { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600023D
        public virtual System.Void SetHandler(SRDebugger.IBugReporterHandler handler) { }
        // RVA: -1  // abstract  token: 0x600023E
        public virtual System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progressCallback) { }

    }

    // TypeToken: 0x2000065  // size: 0x80
    public sealed class ConsoleStateChangedEventHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x07A5D00C  token: 0x600023F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000240
        public virtual System.Void Invoke(UnityEngine.LogType logType, System.Boolean newState) { }
        // RVA: 0x096ACCF4  token: 0x6000241
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.LogType logType, System.Boolean newState, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000242
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000066
    public interface IConsoleFilterState
    {
        // Events
        event SRDebugger.Services.ConsoleStateChangedEventHandler FilterStateChange;

        // Methods
        // RVA: -1  // abstract  token: 0x6000245
        public virtual System.Void SetConsoleFilterState(UnityEngine.LogType logType, System.Boolean enabled) { }
        // RVA: -1  // abstract  token: 0x6000246
        public virtual System.Boolean GetConsoleFilterState(UnityEngine.LogType logType) { }

    }

    // TypeToken: 0x2000067  // size: 0x80
    public sealed class ConsoleUpdatedEventHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0613B2F0  token: 0x6000247
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000248
        public virtual System.Void Invoke(SRDebugger.Services.IConsoleService console) { }
        // RVA: 0x0389C3B0  token: 0x6000249
        public virtual System.IAsyncResult BeginInvoke(SRDebugger.Services.IConsoleService console, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600024A
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000068
    public interface IConsoleService
    {
        // Properties
        System.Int32 CriticalCount { get; /* RVA: -1  // abstract */ }
        System.Int32 ErrorCount { get; /* RVA: -1  // abstract */ }
        System.Int32 WarningCount { get; /* RVA: -1  // abstract */ }
        System.Int32 InfoCount { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> Entries { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> AllEntries { get; /* RVA: -1  // abstract */ }
        System.Boolean LoggingEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean LogHandlerIsOverriden { get; /* RVA: -1  // abstract */ }

        // Events
        event SRDebugger.Services.ConsoleUpdatedEventHandler Updated;
        event SRDebugger.Services.ConsoleUpdatedEventHandler Error;

        // Methods
        // RVA: -1  // abstract  token: 0x6000258
        public virtual System.Void Clear() { }

    }

    // TypeToken: 0x2000069  // size: 0x38
    public class ConsoleEntry
    {
        // Fields
        private static System.Int32 MessagePreviewLength;  // const
        private static System.Int32 StackTracePreviewLength;  // const
        private System.String _messagePreview;  // 0x10
        private System.String _stackTracePreview;  // 0x18
        public System.Int32 Count;  // 0x20
        public UnityEngine.LogType LogType;  // 0x24
        public System.String Message;  // 0x28
        public System.String StackTrace;  // 0x30

        // Properties
        System.String MessagePreview { get; /* RVA: 0x096AC0D8 */ }
        System.String StackTracePreview { get; /* RVA: 0x096AC194 */ }

        // Methods
        // RVA: 0x03D58950  token: 0x6000259
        public System.Void .ctor() { }
        // RVA: 0x096AC084  token: 0x600025A
        public System.Void .ctor(SRDebugger.Services.ConsoleEntry other) { }
        // RVA: 0x096AC024  token: 0x600025D
        public System.Boolean Matches(SRDebugger.Services.ConsoleEntry other) { }

    }

    // TypeToken: 0x200006A
    public interface IDebugCameraService
    {
        // Properties
        UnityEngine.Camera Camera { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200006B
    public interface IDebugPanelService
    {
        // Properties
        System.Boolean IsLoaded { get; /* RVA: -1  // abstract */ }
        System.Boolean IsVisible { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; /* RVA: -1  // abstract */ }

        // Events
        event System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> VisibilityChanged;

        // Methods
        // RVA: -1  // abstract  token: 0x6000265
        public virtual System.Void Unload() { }
        // RVA: -1  // abstract  token: 0x6000266
        public virtual System.Void OpenTab(SRDebugger.DefaultTabs tab) { }

    }

    // TypeToken: 0x200006C
    public interface IDebugService
    {
        // Properties
        SRDebugger.Settings Settings { get; /* RVA: -1  // abstract */ }
        System.Boolean IsDebugPanelVisible { get; /* RVA: -1  // abstract */ }
        System.Boolean IsTriggerEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean IsTriggerErrorNotificationEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        SRDebugger.Services.IDockConsoleService DockConsole { get; /* RVA: -1  // abstract */ }
        SRDebugger.Services.IConsoleFilterState ConsoleFilter { get; /* RVA: -1  // abstract */ }
        System.Boolean IsProfilerDocked { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Events
        event SRDebugger.VisibilityChangedDelegate PanelVisibilityChanged;
        event SRDebugger.PinnedUiCanvasCreated PinnedUiCanvasCreated;

        // Methods
        // RVA: -1  // abstract  token: 0x6000271
        public virtual System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category) { }
        // RVA: -1  // abstract  token: 0x6000272
        public virtual System.Void ShowDebugPanel(System.Boolean requireEntryCode) { }
        // RVA: -1  // abstract  token: 0x6000273
        public virtual System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode) { }
        // RVA: -1  // abstract  token: 0x6000274
        public virtual System.Void HideDebugPanel() { }
        // RVA: -1  // abstract  token: 0x6000275
        public virtual System.Void SetEntryCode(SRDebugger.EntryCode newCode) { }
        // RVA: -1  // abstract  token: 0x6000276
        public virtual System.Void DisableEntryCode() { }
        // RVA: -1  // abstract  token: 0x6000277
        public virtual System.Void DestroyDebugPanel() { }
        // RVA: -1  // abstract  token: 0x6000278
        public virtual System.Void AddOptionContainer(System.Object container) { }
        // RVA: -1  // abstract  token: 0x6000279
        public virtual System.Void RemoveOptionContainer(System.Object container) { }
        // RVA: -1  // abstract  token: 0x600027A
        public virtual System.Void AddOption(SRDebugger.OptionDefinition option) { }
        // RVA: -1  // abstract  token: 0x600027B
        public virtual System.Boolean RemoveOption(SRDebugger.OptionDefinition option) { }
        // RVA: -1  // abstract  token: 0x600027C
        public virtual System.Void PinAllOptions(System.String category) { }
        // RVA: -1  // abstract  token: 0x600027D
        public virtual System.Void UnpinAllOptions(System.String category) { }
        // RVA: -1  // abstract  token: 0x600027E
        public virtual System.Void PinOption(System.String name) { }
        // RVA: -1  // abstract  token: 0x600027F
        public virtual System.Void UnpinOption(System.String name) { }
        // RVA: -1  // abstract  token: 0x6000280
        public virtual System.Void ClearPinnedOptions() { }
        // RVA: -1  // abstract  token: 0x6000281
        public virtual System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent) { }
        // RVA: -1  // abstract  token: 0x6000286
        public virtual UnityEngine.RectTransform EnableWorldSpaceMode() { }
        // RVA: -1  // abstract  token: 0x6000287
        public virtual System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler) { }

    }

    // TypeToken: 0x200006D
    public interface IDebugTriggerService
    {
        // Properties
        System.Boolean IsEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean ShowErrorNotification { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        SRDebugger.PinAlignment Position { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200006E
    public interface IDockConsoleService
    {
        // Properties
        System.Boolean IsVisible { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean IsExpanded { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        SRDebugger.ConsoleAlignment Alignment { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200006F
    public interface IOptionsService
    {
        // Properties
        System.Collections.Generic.ICollection<SRDebugger.OptionDefinition> Options { get; /* RVA: -1  // abstract */ }

        // Events
        event System.EventHandler OptionsUpdated;

        // Methods
        // RVA: -1  // abstract  token: 0x6000297
        public virtual System.Void Scan(System.Object obj) { }
        // RVA: -1  // abstract  token: 0x6000298
        public virtual System.Void AddContainer(System.Object obj) { }
        // RVA: -1  // abstract  token: 0x6000299
        public virtual System.Void AddContainer(SRDebugger.IOptionContainer optionContainer) { }
        // RVA: -1  // abstract  token: 0x600029A
        public virtual System.Void RemoveContainer(System.Object obj) { }
        // RVA: -1  // abstract  token: 0x600029B
        public virtual System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer) { }

    }

    // TypeToken: 0x2000070  // size: 0x80
    public sealed class PinEntryCompleteCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06892B88  token: 0x600029C
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600029D
        public virtual System.Void Invoke(System.Boolean validPinEntered) { }
        // RVA: 0x096B5BD4  token: 0x600029E
        public virtual System.IAsyncResult BeginInvoke(System.Boolean validPinEntered, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600029F
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000071
    public interface IPinEntryService
    {
        // Properties
        System.Boolean IsShowingKeypad { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60002A1
        public virtual System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel) { }

    }

    // TypeToken: 0x2000072
    public interface IPinnedUIService
    {
        // Properties
        System.Boolean IsProfilerPinned { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Events
        event System.Action<SRDebugger.OptionDefinition,System.Boolean> OptionPinStateChanged;
        event System.Action<UnityEngine.RectTransform> OptionsCanvasCreated;

        // Methods
        // RVA: -1  // abstract  token: 0x60002A8
        public virtual System.Void Pin(SRDebugger.OptionDefinition option, System.Int32 order) { }
        // RVA: -1  // abstract  token: 0x60002A9
        public virtual System.Void Unpin(SRDebugger.OptionDefinition option) { }
        // RVA: -1  // abstract  token: 0x60002AA
        public virtual System.Void UnpinAll() { }
        // RVA: -1  // abstract  token: 0x60002AB
        public virtual System.Boolean HasPinned(SRDebugger.OptionDefinition option) { }

    }

    // TypeToken: 0x2000073  // size: 0x10
    public static class ProfilerServiceSelector
    {
        // Methods
        // RVA: 0x02EAA550  token: 0x60002AC
        public static System.Type GetProfilerServiceType() { }

    }

    // TypeToken: 0x2000074  // size: 0x30
    public sealed struct ProfilerFrame
    {
        // Fields
        public System.Double FrameTime;  // 0x10
        public System.Double OtherTime;  // 0x18
        public System.Double RenderTime;  // 0x20
        public System.Double UpdateTime;  // 0x28

    }

    // TypeToken: 0x2000075
    public interface IProfilerService
    {
        // Properties
        System.Single AverageFrameTime { get; /* RVA: -1  // abstract */ }
        System.Single LastFrameTime { get; /* RVA: -1  // abstract */ }
        SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000076
    public interface ISystemInformationService
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60002B0
        public virtual System.Collections.Generic.IEnumerable<System.String> GetCategories() { }
        // RVA: -1  // abstract  token: 0x60002B1
        public virtual System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category) { }
        // RVA: -1  // abstract  token: 0x60002B2
        public virtual System.Void Add(SRDebugger.InfoEntry info, System.String category) { }
        // RVA: -1  // abstract  token: 0x60002B3
        public virtual System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate) { }

    }

}

namespace SRDebugger.Services.Implementation
{

    // TypeToken: 0x2000077  // size: 0x18
    public class BugReportApiService : SRDebugger.Services.IBugReportService
    {
        // Fields
        private SRDebugger.IBugReporterHandler _handler;  // 0x10

        // Properties
        System.Boolean IsUsable { get; /* RVA: 0x096AA328 */ }

        // Methods
        // RVA: 0x096AA21C  token: 0x60002B5
        public virtual System.Void SetHandler(SRDebugger.IBugReporterHandler handler) { }
        // RVA: 0x096A9F38  token: 0x60002B6
        public virtual System.Void SendBugReport(SRDebugger.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, System.IProgress<System.Single> progress) { }
        // RVA: 0x096AA2D8  token: 0x60002B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x68
    public class BugReportPopoverService : SRF.Service.SRServiceBase`1
    {
        // Fields
        private SRDebugger.Services.BugReportCompleteCallback _callback;  // 0x48
        private System.Boolean _isVisible;  // 0x50
        private SRDebugger.UI.Other.BugReportPopoverRoot _popover;  // 0x58
        private SRDebugger.UI.Other.BugReportSheetController _sheet;  // 0x60

        // Properties
        System.Boolean IsShowingPopover { get; /* RVA: 0x03D4F000 */ }

        // Methods
        // RVA: 0x096AAB60  token: 0x60002BB
        public System.Void ShowBugReporter(SRDebugger.Services.BugReportCompleteCallback callback, System.Boolean takeScreenshotFirst, System.String descriptionText) { }
        // RVA: 0x096AAA58  token: 0x60002BC
        private System.Collections.IEnumerator OpenCo(System.Boolean takeScreenshot, System.String descriptionText) { }
        // RVA: 0x096AACF8  token: 0x60002BD
        private System.Void SubmitComplete(System.Boolean didSucceed, System.String errorMessage) { }
        // RVA: 0x096AA51C  token: 0x60002BE
        private System.Void CancelPressed() { }
        // RVA: 0x096AA8F4  token: 0x60002BF
        private System.Void OnComplete(System.Boolean success, System.String errorMessage, System.Boolean close) { }
        // RVA: 0x096AAD14  token: 0x60002C0
        private System.Void TakingScreenshot() { }
        // RVA: 0x096AAADC  token: 0x60002C1
        private System.Void ScreenshotComplete() { }
        // RVA: 0x096AA488  token: 0x60002C2
        protected virtual System.Void Awake() { }
        // RVA: 0x096AA564  token: 0x60002C3
        private System.Void Load() { }
        // RVA: 0x096AAD94  token: 0x60002C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007B  // size: 0x18
    public class DebugCameraServiceImpl : SRDebugger.Services.IDebugCameraService
    {
        // Fields
        private UnityEngine.Camera _debugCamera;  // 0x10

        // Properties
        UnityEngine.Camera Camera { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x096BB8A4  token: 0x60002CB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007C  // size: 0x38
    public class DebugPanelServiceImpl : UnityEngine.ScriptableObject, SRDebugger.Services.IDebugPanelService, System.IDisposable
    {
        // Fields
        private SRDebugger.UI.DebugPanelRoot _debugPanelRootObject;  // 0x18
        private System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> VisibilityChanged;  // 0x20
        private System.Boolean _isVisible;  // 0x28
        private System.Nullable<System.Boolean> _cursorWasVisible;  // 0x29
        private System.Nullable<UnityEngine.CursorLockMode> _cursorLockMode;  // 0x2c

        // Properties
        SRDebugger.UI.DebugPanelRoot RootObject { get; /* RVA: 0x01041090 */ }
        System.Boolean IsLoaded { get; /* RVA: 0x096BBDBC */ }
        System.Boolean IsVisible { get; /* RVA: 0x096BBE0C */ set; /* RVA: 0x096BBEB8 */ }
        System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; /* RVA: 0x096BBD44 */ }

        // Events
        event System.Action<SRDebugger.Services.IDebugPanelService,System.Boolean> VisibilityChanged;

        // Methods
        // RVA: 0x096BBC2C  token: 0x60002D4
        public virtual System.Void OpenTab(SRDebugger.DefaultTabs tab) { }
        // RVA: 0x096BBC80  token: 0x60002D5
        public virtual System.Void Unload() { }
        // RVA: 0x096BBAA4  token: 0x60002D6
        private System.Void Load() { }
        // RVA: 0x096BBA20  token: 0x60002D7
        public virtual System.Void Dispose() { }
        // RVA: 0x0286F540  token: 0x60002D8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007D  // size: 0x68
    public class DebugTriggerImpl : SRF.Service.SRServiceBase`1, SRDebugger.Services.IDebugTriggerService
    {
        // Fields
        private SRDebugger.PinAlignment _position;  // 0x48
        private SRDebugger.UI.Other.TriggerRoot _trigger;  // 0x50
        private SRDebugger.Services.IConsoleService _consoleService;  // 0x58
        private System.Boolean _showErrorNotification;  // 0x60

        // Properties
        System.Boolean IsEnabled { get; /* RVA: 0x096BC8D8 */ set; /* RVA: 0x026CCB80 */ }
        System.Boolean ShowErrorNotification { get; /* RVA: 0x03D519A0 */ set; /* RVA: 0x03CB4A10 */ }
        SRDebugger.PinAlignment Position { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x026CCC00 */ }

        // Methods
        // RVA: 0x0268DA20  token: 0x60002DF
        protected virtual System.Void Awake() { }
        // RVA: 0x096BC6F4  token: 0x60002E0
        private System.Void OnError(SRDebugger.Services.IConsoleService console) { }
        // RVA: 0x096BC1C8  token: 0x60002E1
        private System.Void CreateTrigger() { }
        // RVA: 0x096BC5E4  token: 0x60002E2
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x096BC5DC  token: 0x60002E3
        private static System.Void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2) { }
        // RVA: 0x096BC768  token: 0x60002E4
        private System.Void OnTriggerButtonClick() { }
        // RVA: 0x096BC7F8  token: 0x60002E5
        private static System.Void SetTriggerPosition(UnityEngine.RectTransform t, SRDebugger.PinAlignment position) { }
        // RVA: 0x03D416A0  token: 0x60002E6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007E  // size: 0x28
    public class DockConsoleServiceImpl : SRDebugger.Services.IDockConsoleService
    {
        // Fields
        private SRDebugger.ConsoleAlignment _alignment;  // 0x10
        private SRDebugger.UI.Other.DockConsoleController _consoleRoot;  // 0x18
        private System.Boolean _didSuspendTrigger;  // 0x20
        private System.Boolean _isExpanded;  // 0x21
        private System.Boolean _isVisible;  // 0x22

        // Properties
        System.Boolean IsVisible { get; /* RVA: 0x03D4F740 */ set; /* RVA: 0x096BCD4C */ }
        System.Boolean IsExpanded { get; /* RVA: 0x03D4F070 */ set; /* RVA: 0x096BCCAC */ }
        SRDebugger.ConsoleAlignment Alignment { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x096BCC24 */ }

        // Methods
        // RVA: 0x096BCBF4  token: 0x60002E7
        public System.Void .ctor() { }
        // RVA: 0x096BCA8C  token: 0x60002EE
        private System.Void Load() { }
        // RVA: 0x096BC954  token: 0x60002EF
        private System.Void CheckTrigger() { }

    }

    // TypeToken: 0x200007F  // size: 0x50
    public class KeyboardShortcutListenerService : SRF.Service.SRServiceBase`1
    {
        // Fields
        private System.Collections.Generic.List<SRDebugger.Settings.KeyboardShortcut> _shortcuts;  // 0x48

        // Methods
        // RVA: 0x096BCE8C  token: 0x60002F0
        protected virtual System.Void Awake() { }
        // RVA: 0x096BD5D0  token: 0x60002F1
        private System.Void ToggleTab(SRDebugger.DefaultTabs t) { }
        // RVA: 0x096BD2EC  token: 0x60002F2
        private System.Void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut) { }
        // RVA: 0x096BDB24  token: 0x60002F3
        protected virtual System.Void Update() { }
        // RVA: 0x096BD6F0  token: 0x60002F4
        private System.Void UpdateInputSystem() { }
        // RVA: 0x096BD97C  token: 0x60002F5
        private System.Void UpdateLegacyInputSystem() { }
        // RVA: 0x096BDB6C  token: 0x60002F6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x38
    public sealed class OptionsServiceImpl : SRDebugger.Services.IOptionsService
    {
        // Fields
        private System.EventHandler OptionsUpdated;  // 0x10
        private readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,System.Collections.Generic.List<SRDebugger.OptionDefinition>> _optionContainerLookup;  // 0x18
        private readonly System.Collections.Generic.Dictionary<SRDebugger.IOptionContainer,SRDebugger.Services.Implementation.OptionsServiceImpl.OptionContainerEventHandler> _optionContainerEventHandlerLookup;  // 0x20
        private readonly System.Collections.Generic.List<SRDebugger.OptionDefinition> _options;  // 0x28
        private readonly System.Collections.Generic.IList<SRDebugger.OptionDefinition> _optionsReadonly;  // 0x30

        // Properties
        System.Collections.Generic.ICollection<SRDebugger.OptionDefinition> Options { get; /* RVA: 0x01003830 */ }

        // Events
        event System.EventHandler OptionsUpdated;

        // Methods
        // RVA: 0x096BEA48  token: 0x60002FA
        private System.Void OptionsContainerOnOptionAdded(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition) { }
        // RVA: 0x096BEB8C  token: 0x60002FB
        private System.Void OptionsContainerOnOptionRemoved(SRDebugger.IOptionContainer container, SRDebugger.OptionDefinition optionDefinition) { }
        // RVA: 0x0386F070  token: 0x60002FC
        public System.Void .ctor() { }
        // RVA: 0x096BEFCC  token: 0x60002FD
        public virtual System.Void Scan(System.Object obj) { }
        // RVA: 0x0386EFE0  token: 0x60002FE
        public virtual System.Void AddContainer(System.Object obj) { }
        // RVA: 0x0386F1E0  token: 0x60002FF
        public virtual System.Void AddContainer(SRDebugger.IOptionContainer optionContainer) { }
        // RVA: 0x096BECA4  token: 0x6000300
        public virtual System.Void RemoveContainer(System.Object obj) { }
        // RVA: 0x096BED40  token: 0x6000301
        public virtual System.Void RemoveContainer(SRDebugger.IOptionContainer optionContainer) { }
        // RVA: 0x096BE9DC  token: 0x6000302
        private System.Void OnOptionsUpdated() { }

    }

    // TypeToken: 0x2000083  // size: 0x68
    public class PinEntryServiceImpl : SRF.Service.SRServiceBase`1, SRDebugger.Services.IPinEntryService
    {
        // Fields
        private SRDebugger.Services.PinEntryCompleteCallback _callback;  // 0x48
        private System.Boolean _isVisible;  // 0x50
        private SRDebugger.UI.Controls.PinEntryControl _pinControl;  // 0x58
        private readonly System.Collections.Generic.List<System.Int32> _requiredPin;  // 0x60

        // Properties
        System.Boolean IsShowingKeypad { get; /* RVA: 0x03D4F000 */ }

        // Methods
        // RVA: 0x096BF3E0  token: 0x6000313
        public virtual System.Void ShowPinEntry(System.Collections.Generic.IReadOnlyList<System.Int32> requiredPin, System.String message, SRDebugger.Services.PinEntryCompleteCallback callback, System.Boolean allowCancel) { }
        // RVA: 0x096BF0FC  token: 0x6000314
        protected virtual System.Void Awake() { }
        // RVA: 0x096BF190  token: 0x6000315
        private System.Void Load() { }
        // RVA: 0x096BF31C  token: 0x6000316
        private System.Void PinControlOnComplete(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel) { }
        // RVA: 0x096BF600  token: 0x6000317
        private System.Void VerifyPin(System.Collections.Generic.IReadOnlyList<System.Int32> pin) { }
        // RVA: 0x096BF75C  token: 0x6000318
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000084  // size: 0x78
    public class PinnedUIServiceImpl : SRF.Service.SRServiceBase`1, SRDebugger.Services.IPinnedUIService
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controlList;  // 0x48
        private readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase> _pinnedObjects;  // 0x50
        private System.Boolean _queueRefresh;  // 0x58
        private SRDebugger.UI.Other.PinnedUIRoot _uiRoot;  // 0x60
        private System.Action<SRDebugger.OptionDefinition,System.Boolean> OptionPinStateChanged;  // 0x68
        private System.Action<UnityEngine.RectTransform> OptionsCanvasCreated;  // 0x70

        // Properties
        SRDebugger.UI.Other.DockConsoleController DockConsoleController { get; /* RVA: 0x096C04E8 */ }
        System.Boolean IsProfilerPinned { get; /* RVA: 0x096C055C */ set; /* RVA: 0x096C06EC */ }

        // Events
        event System.Action<SRDebugger.OptionDefinition,System.Boolean> OptionPinStateChanged;
        event System.Action<UnityEngine.RectTransform> OptionsCanvasCreated;

        // Methods
        // RVA: 0x096BFC98  token: 0x6000320
        public virtual System.Void Pin(SRDebugger.OptionDefinition obj, System.Int32 order) { }
        // RVA: 0x096C0060  token: 0x6000321
        public virtual System.Void Unpin(SRDebugger.OptionDefinition obj) { }
        // RVA: 0x096BFC84  token: 0x6000322
        private System.Void OnPinnedStateChanged(SRDebugger.OptionDefinition option, System.Boolean isPinned) { }
        // RVA: 0x096BFEA8  token: 0x6000323
        public virtual System.Void UnpinAll() { }
        // RVA: 0x096BF7EC  token: 0x6000324
        public virtual System.Boolean HasPinned(SRDebugger.OptionDefinition option) { }
        // RVA: 0x0268DB40  token: 0x6000325
        protected virtual System.Void Awake() { }
        // RVA: 0x096BF840  token: 0x6000326
        private System.Void Load() { }
        // RVA: 0x096C0184  token: 0x6000327
        private System.Void UpdateAnchors() { }
        // RVA: 0x03336BB0  token: 0x6000328
        protected virtual System.Void Update() { }
        // RVA: 0x096BFADC  token: 0x6000329
        private System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs) { }
        // RVA: 0x096BFAD0  token: 0x600032A
        private System.Void OnDebugPanelVisibilityChanged(System.Boolean isVisible) { }
        // RVA: 0x096BFE28  token: 0x600032B
        private System.Void Refresh() { }
        // RVA: 0x03C813B0  token: 0x600032C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000085  // size: 0x80
    public class SRDebugService : SRDebugger.Services.IDebugService
    {
        // Fields
        private SRDebugger.VisibilityChangedDelegate PanelVisibilityChanged;  // 0x10
        private SRDebugger.PinnedUiCanvasCreated PinnedUiCanvasCreated;  // 0x18
        private readonly SRDebugger.Services.IDebugPanelService _debugPanelService;  // 0x20
        private readonly SRDebugger.Services.IDebugTriggerService _debugTrigger;  // 0x28
        private readonly SRDebugger.Services.ISystemInformationService _informationService;  // 0x30
        private readonly SRDebugger.Services.IOptionsService _optionsService;  // 0x38
        private readonly SRDebugger.Services.IPinnedUIService _pinnedUiService;  // 0x40
        private SRDebugger.Services.IConsoleFilterState _consoleFilterState;  // 0x48
        private System.Nullable<SRDebugger.EntryCode> _entryCode;  // 0x50
        private System.Boolean _hasAuthorised;  // 0x64
        private System.Nullable<SRDebugger.DefaultTabs> _queuedTab;  // 0x68
        private UnityEngine.RectTransform _worldSpaceTransform;  // 0x70
        private SRDebugger.DynamicOptionContainer _looseOptionContainer;  // 0x78

        // Properties
        SRDebugger.Services.IDockConsoleService DockConsole { get; /* RVA: 0x096C2CA8 */ }
        SRDebugger.Services.IConsoleFilterState ConsoleFilter { get; /* RVA: 0x096C2C40 */ }
        SRDebugger.Settings Settings { get; /* RVA: 0x042713D4 */ }
        System.Boolean IsDebugPanelVisible { get; /* RVA: 0x096C2CB0 */ }
        System.Boolean IsTriggerEnabled { get; /* RVA: 0x096C2D40 */ set; /* RVA: 0x096C2F68 */ }
        System.Boolean IsTriggerErrorNotificationEnabled { get; /* RVA: 0x096C2D5C */ set; /* RVA: 0x096C2F84 */ }
        System.Boolean IsProfilerDocked { get; /* RVA: 0x096C2CCC */ set; /* RVA: 0x096C2EE4 */ }

        // Events
        event SRDebugger.VisibilityChangedDelegate PanelVisibilityChanged;
        event SRDebugger.PinnedUiCanvasCreated PinnedUiCanvasCreated;

        // Methods
        // RVA: 0x026CD3E0  token: 0x6000333
        public System.Void .ctor() { }
        // RVA: 0x096C1988  token: 0x600033C
        public virtual System.Void AddSystemInfo(SRDebugger.InfoEntry entry, System.String category) { }
        // RVA: 0x096C2668  token: 0x600033D
        public virtual System.Void ShowDebugPanel(System.Boolean requireEntryCode) { }
        // RVA: 0x096C2574  token: 0x600033E
        public virtual System.Void ShowDebugPanel(SRDebugger.DefaultTabs tab, System.Boolean requireEntryCode) { }
        // RVA: 0x096C1DF4  token: 0x600033F
        public virtual System.Void HideDebugPanel() { }
        // RVA: 0x096C23F4  token: 0x6000340
        public virtual System.Void SetEntryCode(SRDebugger.EntryCode newCode) { }
        // RVA: 0x03D751B0  token: 0x6000341
        public virtual System.Void DisableEntryCode() { }
        // RVA: 0x096C1B48  token: 0x6000342
        public virtual System.Void DestroyDebugPanel() { }
        // RVA: 0x096C1810  token: 0x6000343
        public virtual System.Void AddOptionContainer(System.Object container) { }
        // RVA: 0x096C22A8  token: 0x6000344
        public virtual System.Void RemoveOptionContainer(System.Object container) { }
        // RVA: 0x096C188C  token: 0x6000345
        public virtual System.Void AddOption(SRDebugger.OptionDefinition option) { }
        // RVA: 0x096C2324  token: 0x6000346
        public virtual System.Boolean RemoveOption(SRDebugger.OptionDefinition option) { }
        // RVA: 0x096C1E14  token: 0x6000347
        public virtual System.Void PinAllOptions(System.String category) { }
        // RVA: 0x096C2830  token: 0x6000348
        public virtual System.Void UnpinAllOptions(System.String category) { }
        // RVA: 0x096C1F88  token: 0x6000349
        public virtual System.Void PinOption(System.String name) { }
        // RVA: 0x096C29A4  token: 0x600034A
        public virtual System.Void UnpinOption(System.String name) { }
        // RVA: 0x096C1A0C  token: 0x600034B
        public virtual System.Void ClearPinnedOptions() { }
        // RVA: 0x096C2458  token: 0x600034C
        public virtual System.Void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, System.Boolean takeScreenshot, System.String descriptionContent) { }
        // RVA: 0x096C1A78  token: 0x600034D
        private System.Void DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b) { }
        // RVA: 0x096C20FC  token: 0x600034E
        private System.Void PromptEntryCode() { }
        // RVA: 0x096C1BC8  token: 0x600034F
        public virtual UnityEngine.RectTransform EnableWorldSpaceMode() { }
        // RVA: 0x096C233C  token: 0x6000350
        public virtual System.Void SetBugReporterHandler(SRDebugger.IBugReporterHandler bugReporterHandler) { }
        // RVA: 0x096C277C  token: 0x6000351
        private System.Void <.ctor>b__21_0(UnityEngine.RectTransform transform) { }
        // RVA: 0x096C26D4  token: 0x6000352
        private System.Void <PromptEntryCode>b__53_0(System.Boolean entered) { }

    }

    // TypeToken: 0x2000087  // size: 0x58
    public class StandardConsoleService : SRDebugger.Services.IConsoleService, System.IDisposable
    {
        // Fields
        private readonly System.Boolean _collapseEnabled;  // 0x10
        private System.Boolean _hasCleared;  // 0x11
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _allConsoleEntries;  // 0x18
        private SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _consoleEntries;  // 0x20
        private readonly System.Object _threadLock;  // 0x28
        private UnityEngine.ILogHandler _expectedLogHandler;  // 0x30
        private System.Int32 <CriticalCount>k__BackingField;  // 0x38
        private System.Int32 <ErrorCount>k__BackingField;  // 0x3c
        private System.Int32 <WarningCount>k__BackingField;  // 0x40
        private System.Int32 <InfoCount>k__BackingField;  // 0x44
        private SRDebugger.Services.ConsoleUpdatedEventHandler Updated;  // 0x48
        private SRDebugger.Services.ConsoleUpdatedEventHandler Error;  // 0x50

        // Properties
        System.Int32 CriticalCount { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.Int32 ErrorCount { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x03D4EDC0 */ }
        System.Int32 WarningCount { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x03D4EDB0 */ }
        System.Int32 InfoCount { get; /* RVA: 0x03D4EE80 */ set; /* RVA: 0x03D4EEA0 */ }
        System.Boolean LoggingEnabled { get; /* RVA: 0x096C4128 */ set; /* RVA: 0x096C42A4 */ }
        System.Boolean LogHandlerIsOverriden { get; /* RVA: 0x096C40D0 */ }
        System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> Entries { get; /* RVA: 0x096C40C0 */ }
        System.Collections.Generic.IReadOnlyList<SRDebugger.Services.ConsoleEntry> AllEntries { get; /* RVA: 0x01041090 */ }

        // Events
        event SRDebugger.Services.ConsoleUpdatedEventHandler Updated;
        event SRDebugger.Services.ConsoleUpdatedEventHandler Error;

        // Methods
        // RVA: 0x0267B700  token: 0x6000355
        public System.Void .ctor() { }
        // RVA: 0x096C3C2C  token: 0x6000356
        public virtual System.Void Dispose() { }
        // RVA: 0x096C3A6C  token: 0x6000368
        public virtual System.Void Clear() { }
        // RVA: 0x096C3CE0  token: 0x6000369
        protected System.Void OnEntryAdded(SRDebugger.Services.ConsoleEntry entry) { }
        // RVA: 0x096C3E50  token: 0x600036A
        protected System.Void OnEntryDuplicated(SRDebugger.Services.ConsoleEntry entry) { }
        // RVA: 0x096C3F04  token: 0x600036B
        private System.Void OnUpdated() { }
        // RVA: 0x0350B670  token: 0x600036C
        private System.Void UnityLogCallback(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        // RVA: 0x096C39F4  token: 0x600036D
        private System.Void AdjustCounter(UnityEngine.LogType type, System.Int32 amount) { }

    }

    // TypeToken: 0x2000088  // size: 0x18
    public class StandardSystemInformationService : SRDebugger.Services.ISystemInformationService
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.IList<SRDebugger.InfoEntry>> _info;  // 0x10

        // Methods
        // RVA: 0x03CF21E0  token: 0x600036E
        public System.Void .ctor() { }
        // RVA: 0x096C4954  token: 0x600036F
        public virtual System.Collections.Generic.IEnumerable<System.String> GetCategories() { }
        // RVA: 0x096C4AF0  token: 0x6000370
        public virtual System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(System.String category) { }
        // RVA: 0x096C4340  token: 0x6000371
        public virtual System.Void Add(SRDebugger.InfoEntry info, System.String category) { }
        // RVA: 0x096C454C  token: 0x6000372
        public virtual System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> CreateReport(System.Boolean includePrivate) { }
        // RVA: 0x0315D380  token: 0x6000373
        private System.Void CreateDefaultSet() { }
        // RVA: 0x096C499C  token: 0x6000374
        private static System.String GetCloudManifestPrettyName(System.String name) { }

    }

}

namespace SRDebugger.UI
{

    // TypeToken: 0x2000024  // size: 0x68
    public class ProfilerFPSLabel : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Single _nextUpdate;  // 0x48
        private SRDebugger.Services.IProfilerService _profilerService;  // 0x50
        public System.Single UpdateFrequency;  // 0x58
        private UnityEngine.UI.Text _text;  // 0x60

        // Methods
        // RVA: 0x096B6AA0  token: 0x60000B0
        protected virtual System.Void Update() { }
        // RVA: 0x096B6994  token: 0x60000B1
        private System.Void Refresh() { }
        // RVA: 0x096B6ACC  token: 0x60000B2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x60
    public class DebugPanelRoot : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;  // 0x48
        public UnityEngine.CanvasGroup CanvasGroup;  // 0x50
        public SRDebugger.Scripts.DebuggerTabController TabController;  // 0x58

        // Methods
        // RVA: 0x096AEB74  token: 0x60000B3
        public System.Void Close() { }
        // RVA: 0x096AEB18  token: 0x60000B4
        public System.Void CloseAndDestroy() { }
        // RVA: 0x0426FE60  token: 0x60000B5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x80
    public class MobileMenuController : SRF.SRMonoBehaviourEx
    {
        // Fields
        private UnityEngine.UI.Button _closeButton;  // 0x48
        private System.Single _maxMenuWidth;  // 0x50
        private System.Single _peekAmount;  // 0x54
        private System.Single _targetXPosition;  // 0x58
        public UnityEngine.RectTransform Content;  // 0x60
        public UnityEngine.RectTransform Menu;  // 0x68
        public UnityEngine.UI.Button OpenButton;  // 0x70
        public SRDebugger.UI.Other.SRTabController TabController;  // 0x78

        // Properties
        System.Single PeekAmount { get; /* RVA: 0x03D4F670 */ }
        System.Single MaxMenuWidth { get; /* RVA: 0x03D51C90 */ }

        // Methods
        // RVA: 0x096B2288  token: 0x60000B8
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B2150  token: 0x60000B9
        protected virtual System.Void OnDisable() { }
        // RVA: 0x096B1D9C  token: 0x60000BA
        private System.Void CreateCloseButton() { }
        // RVA: 0x096B255C  token: 0x60000BB
        private System.Void SetRectSize(UnityEngine.RectTransform rect) { }
        // RVA: 0x096B1D5C  token: 0x60000BC
        private System.Void CloseButtonClicked() { }
        // RVA: 0x096B2610  token: 0x60000BD
        protected virtual System.Void Update() { }
        // RVA: 0x096B1D5C  token: 0x60000BE
        private System.Void TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab) { }
        // RVA: 0x096B2504  token: 0x60000BF
        public System.Void Open() { }
        // RVA: 0x096B1D64  token: 0x60000C0
        public System.Void Close() { }
        // RVA: 0x096B2700  token: 0x60000C1
        public System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Controls
{

    // TypeToken: 0x2000048  // size: 0x88
    public class ConsoleEntryView : SRF.SRMonoBehaviourEx, SRF.UI.Layout.IVirtualView
    {
        // Fields
        public static System.String ConsoleBlobInfo;  // const
        public static System.String ConsoleBlobWarning;  // const
        public static System.String ConsoleBlobError;  // const
        public static System.String ConsoleBlobCritical;  // const
        private System.Int32 _count;  // 0x48
        private System.Boolean _hasCount;  // 0x4c
        private SRDebugger.Services.ConsoleEntry _prevData;  // 0x50
        private UnityEngine.RectTransform _rectTransform;  // 0x58
        public UnityEngine.UI.Text Count;  // 0x60
        public UnityEngine.CanvasGroup CountContainer;  // 0x68
        public SRF.UI.StyleComponent ImageStyle;  // 0x70
        public UnityEngine.UI.Text Message;  // 0x78
        public UnityEngine.UI.Text StackTrace;  // 0x80

        // Methods
        // RVA: 0x096ABCE8  token: 0x6000189
        public virtual System.Void SetDataContext(System.Object data) { }
        // RVA: 0x096ABC44  token: 0x600018A
        protected virtual System.Void Awake() { }
        // RVA: 0x0426FE60  token: 0x600018B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x80
    public class ConsoleLogControl : SRF.SRMonoBehaviourEx
    {
        // Fields
        private SRF.UI.Layout.VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;  // 0x48
        private UnityEngine.UI.ScrollRect _consoleScrollRect;  // 0x50
        private System.Boolean _isDirty;  // 0x58
        private System.Nullable<UnityEngine.Vector2> _scrollPosition;  // 0x5c
        private System.Boolean _showCriticals;  // 0x68
        private System.Boolean _showErrors;  // 0x69
        private System.Boolean _showInfo;  // 0x6a
        private System.Boolean _showWarnings;  // 0x6b
        public System.Action<SRDebugger.Services.ConsoleEntry> SelectedItemChanged;  // 0x70
        private System.String _filter;  // 0x78

        // Properties
        System.Boolean ShowCriticals { get; /* RVA: 0x03D4F3F0 */ set; /* RVA: 0x03D75140 */ }
        System.Boolean ShowErrors { get; /* RVA: 0x03D4F3C0 */ set; /* RVA: 0x03D75150 */ }
        System.Boolean ShowWarnings { get; /* RVA: 0x03D75130 */ set; /* RVA: 0x03D75170 */ }
        System.Boolean ShowInfo { get; /* RVA: 0x03D75120 */ set; /* RVA: 0x03D75160 */ }
        System.Boolean EnableSelection { get; /* RVA: 0x096ACC78 */ set; /* RVA: 0x096ACC98 */ }
        System.String Filter { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x096ACCB8 */ }

        // Methods
        // RVA: 0x096AC75C  token: 0x6000198
        protected virtual System.Void Awake() { }
        // RVA: 0x096ACBB4  token: 0x6000199
        protected virtual System.Void Start() { }
        // RVA: 0x096ACB58  token: 0x600019A
        private System.Collections.IEnumerator ScrollToBottom() { }
        // RVA: 0x096AC874  token: 0x600019B
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x096AC914  token: 0x600019C
        private System.Void OnSelectedItemChanged(System.Object arg0) { }
        // RVA: 0x096ACBDC  token: 0x600019D
        protected virtual System.Void Update() { }
        // RVA: 0x096AC970  token: 0x600019E
        private System.Void Refresh() { }
        // RVA: 0x03D72A60  token: 0x600019F
        private System.Void SetIsDirty() { }
        // RVA: 0x03D72A60  token: 0x60001A0
        private System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console) { }
        // RVA: 0x096ACC68  token: 0x60001A1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004B  // size: 0x80
    public abstract class DataBoundControl : SRDebugger.UI.Controls.OptionsControlBase
    {
        // Fields
        private System.Boolean _hasStarted;  // 0x60
        private System.Boolean _isReadOnly;  // 0x61
        private System.Object _prevValue;  // 0x68
        private SRF.Helpers.PropertyReference _prop;  // 0x70
        private System.String <PropertyName>k__BackingField;  // 0x78

        // Properties
        SRF.Helpers.PropertyReference Property { get; /* RVA: 0x03D4EB30 */ }
        System.Boolean IsReadOnly { get; /* RVA: 0x03D51F90 */ }
        System.String PropertyName { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }

        // Methods
        // RVA: 0x096AE65C  token: 0x60001AC
        public System.Void Bind(System.String propertyName, SRF.Helpers.PropertyReference prop) { }
        // RVA: 0x08250BC4  token: 0x60001AD
        private System.Void OnValueChanged(SRF.Helpers.PropertyReference property) { }
        // RVA: 0x096AE9BC  token: 0x60001AE
        protected System.Void UpdateValue(System.Object newValue) { }
        // RVA: 0x096AE898  token: 0x60001AF
        public virtual System.Void Refresh() { }
        // RVA: 0x0350B670  token: 0x60001B0
        protected virtual System.Void OnBind(System.String propertyName, System.Type t) { }
        // RVA: -1  // abstract  token: 0x60001B1
        protected virtual System.Void OnValueUpdated(System.Object newValue) { }
        // RVA: -1  // abstract  token: 0x60001B2
        public virtual System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        // RVA: 0x096AE99C  token: 0x60001B3
        protected virtual System.Void Start() { }
        // RVA: 0x096AE7E8  token: 0x60001B4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096AE754  token: 0x60001B5
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0426FE60  token: 0x60001B6
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x60
    public abstract class OptionsControlBase : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _selectionModeEnabled;  // 0x48
        public UnityEngine.UI.Toggle SelectionModeToggle;  // 0x50
        public SRDebugger.OptionDefinition Option;  // 0x58

        // Properties
        System.Boolean SelectionModeEnabled { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x096B3A08 */ }
        System.Boolean IsSelected { get; /* RVA: 0x096B3910 */ set; /* RVA: 0x096B3930 */ }

        // Methods
        // RVA: 0x096B3800  token: 0x60001BB
        protected virtual System.Void Awake() { }
        // RVA: 0x096B3850  token: 0x60001BC
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0350B670  token: 0x60001BD
        public virtual System.Void Refresh() { }
        // RVA: 0x0426FE60  token: 0x60001BE
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200004D  // size: 0x58
    public class InfoBlock : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.UI.Text Content;  // 0x48
        public UnityEngine.UI.Text Title;  // 0x50

        // Methods
        // RVA: 0x0426FE60  token: 0x60001BF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x198
    public class MultiTapButton : UnityEngine.UI.Button
    {
        // Fields
        private System.Single _lastTap;  // 0x188
        private System.Int32 _tapCount;  // 0x18c
        public System.Int32 RequiredTapCount;  // 0x190
        public System.Single ResetTime;  // 0x194

        // Methods
        // RVA: 0x096B2718  token: 0x60001C0
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096B278C  token: 0x60001C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004F  // size: 0x80
    public sealed class PinEntryControlCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06DE9D50  token: 0x60001C2
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x60001C3
        public virtual System.Void Invoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel) { }
        // RVA: 0x096B5C4C  token: 0x60001C4
        public virtual System.IAsyncResult BeginInvoke(System.Collections.Generic.IList<System.Int32> result, System.Boolean didCancel, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x60001C5
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000050  // size: 0xA8
    public class PinEntryControl : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _isVisible;  // 0x48
        private System.Collections.Generic.List<System.Int32> _numbers;  // 0x50
        public UnityEngine.UI.Image Background;  // 0x58
        public System.Boolean CanCancel;  // 0x60
        public UnityEngine.UI.Button CancelButton;  // 0x68
        public UnityEngine.UI.Text CancelButtonText;  // 0x70
        public UnityEngine.CanvasGroup CanvasGroup;  // 0x78
        public UnityEngine.Animator DotAnimator;  // 0x80
        public UnityEngine.UI.Button[] NumberButtons;  // 0x88
        public UnityEngine.UI.Toggle[] NumberDots;  // 0x90
        public UnityEngine.UI.Text PromptText;  // 0x98
        private SRDebugger.UI.Controls.PinEntryControlCallback Complete;  // 0xa0

        // Events
        event SRDebugger.UI.Controls.PinEntryControlCallback Complete;

        // Methods
        // RVA: 0x096B5CCC  token: 0x60001C8
        protected virtual System.Void Awake() { }
        // RVA: 0x096B6190  token: 0x60001C9
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B60FC  token: 0x60001CA
        protected virtual System.Void OnDisable() { }
        // RVA: 0x096B647C  token: 0x60001CB
        protected virtual System.Void Update() { }
        // RVA: 0x096B5F28  token: 0x60001CC
        private System.Void HandleCharacter(System.Char i) { }
        // RVA: 0x096B641C  token: 0x60001CD
        public System.Void Show() { }
        // RVA: 0x096B5FA8  token: 0x60001CE
        public System.Void Hide() { }
        // RVA: 0x096B5EDC  token: 0x60001CF
        public System.Void Clear() { }
        // RVA: 0x096B6224  token: 0x60001D0
        public System.Void PlayInvalidCodeAnimation() { }
        // RVA: 0x096B6060  token: 0x60001D1
        protected System.Void OnComplete() { }
        // RVA: 0x096B6004  token: 0x60001D2
        protected System.Void OnCancel() { }
        // RVA: 0x096B5E6C  token: 0x60001D3
        private System.Void CancelButtonPressed() { }
        // RVA: 0x096B6270  token: 0x60001D4
        public System.Void PushNumber(System.Int32 number) { }
        // RVA: 0x096B6330  token: 0x60001D5
        private System.Void RefreshState() { }
        // RVA: 0x096B6554  token: 0x60001D6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000052  // size: 0x68
    public class ProfilerMemoryBlock : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Single _lastRefresh;  // 0x48
        public UnityEngine.UI.Text CurrentUsedText;  // 0x50
        public UnityEngine.UI.Slider Slider;  // 0x58
        public UnityEngine.UI.Text TotalAllocatedText;  // 0x60

        // Methods
        // RVA: 0x096B8044  token: 0x60001D9
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B8234  token: 0x60001DA
        protected virtual System.Void Update() { }
        // RVA: 0x096B8070  token: 0x60001DB
        public System.Void TriggerRefresh() { }
        // RVA: 0x096B804C  token: 0x60001DC
        public System.Void TriggerCleanup() { }
        // RVA: 0x096B7FE8  token: 0x60001DD
        private System.Collections.IEnumerator CleanUp() { }
        // RVA: 0x0426FE60  token: 0x60001DE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000054  // size: 0x78
    public class ProfilerMonoBlock : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Single _lastRefresh;  // 0x48
        public UnityEngine.UI.Text CurrentUsedText;  // 0x50
        public UnityEngine.GameObject NotSupportedMessage;  // 0x58
        public UnityEngine.UI.Slider Slider;  // 0x60
        public UnityEngine.UI.Text TotalAllocatedText;  // 0x68
        private System.Boolean _isSupported;  // 0x70

        // Methods
        // RVA: 0x096B82B4  token: 0x60001E5
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B8560  token: 0x60001E6
        protected virtual System.Void Update() { }
        // RVA: 0x096B836C  token: 0x60001E7
        public System.Void TriggerRefresh() { }
        // RVA: 0x096B831C  token: 0x60001E8
        public System.Void TriggerCollection() { }
        // RVA: 0x0426FE60  token: 0x60001E9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x68
    public class ProfilerEnableControl : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _previousState;  // 0x48
        public UnityEngine.UI.Text ButtonText;  // 0x50
        public UnityEngine.UI.Button EnableButton;  // 0x58
        public UnityEngine.UI.Text Text;  // 0x60

        // Methods
        // RVA: 0x096B6710  token: 0x60001EA
        protected virtual System.Void Start() { }
        // RVA: 0x096B6868  token: 0x60001EB
        protected System.Void UpdateLabels() { }
        // RVA: 0x096B6968  token: 0x60001EC
        protected virtual System.Void Update() { }
        // RVA: 0x096B680C  token: 0x60001ED
        public System.Void ToggleProfiler() { }
        // RVA: 0x0426FE60  token: 0x60001EE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000056  // size: 0x60
    public class ProfilerGraphAxisLabel : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Single _prevFrameTime;  // 0x48
        private System.Nullable<System.Single> _queuedFrameTime;  // 0x4c
        private System.Single _yPosition;  // 0x54
        public UnityEngine.UI.Text Text;  // 0x58

        // Methods
        // RVA: 0x096B6D10  token: 0x60001EF
        protected virtual System.Void Update() { }
        // RVA: 0x096B6C94  token: 0x60001F0
        public System.Void SetValue(System.Single frameTime, System.Single yPosition) { }
        // RVA: 0x096B6ADC  token: 0x60001F1
        private System.Void SetValueInternal(System.Single frameTime) { }
        // RVA: 0x0426FE60  token: 0x60001F2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000057  // size: 0x108
    public class ProfilerGraphControl : UnityEngine.UI.Graphic
    {
        // Fields
        public SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments VerticalAlignment;  // 0xb0
        private static readonly System.Single[] ScaleSteps;  // static @ 0x0
        public System.Boolean FloatingScale;  // 0xb4
        public System.Boolean TargetFpsUseApplication;  // 0xb5
        public System.Boolean DrawAxes;  // 0xb6
        public System.Int32 TargetFps;  // 0xb8
        public System.Boolean Clip;  // 0xbc
        public static System.Single DataPointMargin;  // const
        public static System.Single DataPointVerticalMargin;  // const
        public static System.Single DataPointWidth;  // const
        public System.Int32 VerticalPadding;  // 0xc0
        public static System.Int32 LineCount;  // const
        public UnityEngine.Color[] LineColours;  // 0xc8
        private SRDebugger.Services.IProfilerService _profilerService;  // 0xd0
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel[] _axisLabels;  // 0xd8
        private UnityEngine.Rect _clipBounds;  // 0xe0
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> _meshVertices;  // 0xf0
        private readonly System.Collections.Generic.List<UnityEngine.Color32> _meshVertexColors;  // 0xf8
        private readonly System.Collections.Generic.List<System.Int32> _meshTriangles;  // 0x100

        // Methods
        // RVA: 0x096B70AC  token: 0x60001F3
        protected virtual System.Void Awake() { }
        // RVA: 0x0350B670  token: 0x60001F4
        protected virtual System.Void Start() { }
        // RVA: 0x096B7DB4  token: 0x60001F5
        protected System.Void Update() { }
        // RVA: 0x096B78C8  token: 0x60001F6
        protected virtual System.Void OnPopulateMesh(UnityEngine.Mesh m) { }
        // RVA: 0x096B73DC  token: 0x60001F7
        protected System.Void DrawDataPoint(System.Single xPosition, System.Single verticalScale, SRDebugger.Services.ProfilerFrame frame) { }
        // RVA: 0x096B71D4  token: 0x60001F8
        protected System.Void DrawAxis(System.Single frameTime, System.Single yPosition, SRDebugger.UI.Controls.ProfilerGraphAxisLabel label) { }
        // RVA: 0x096B6D74  token: 0x60001F9
        protected System.Void AddRect(UnityEngine.Vector3 tl, UnityEngine.Vector3 tr, UnityEngine.Vector3 bl, UnityEngine.Vector3 br, UnityEngine.Color c) { }
        // RVA: 0x096B783C  token: 0x60001FA
        protected SRDebugger.Services.ProfilerFrame GetFrame(System.Int32 i) { }
        // RVA: 0x096B7198  token: 0x60001FB
        protected System.Int32 CalculateVisibleDataPointCount() { }
        // RVA: 0x096B7798  token: 0x60001FC
        protected System.Int32 GetFrameBufferCurrentSize() { }
        // RVA: 0x096B77E4  token: 0x60001FD
        protected System.Int32 GetFrameBufferMaxSize() { }
        // RVA: 0x096B7110  token: 0x60001FE
        protected System.Single CalculateMaxFrameTime() { }
        // RVA: 0x096B76C8  token: 0x60001FF
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel GetAxisLabel(System.Int32 index) { }
        // RVA: 0x096B7E50  token: 0x6000200
        public System.Void .ctor() { }
        // RVA: 0x096B7DC4  token: 0x6000201
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x70
    public class SRTabButton : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Behaviour ActiveToggle;  // 0x48
        public UnityEngine.UI.Button Button;  // 0x50
        public UnityEngine.RectTransform ExtraContentContainer;  // 0x58
        public SRF.UI.StyleComponent IconStyleComponent;  // 0x60
        public UnityEngine.UI.Text TitleText;  // 0x68

        // Properties
        System.Boolean IsActive { get; /* RVA: 0x096B897C */ set; /* RVA: 0x096B899C */ }

        // Methods
        // RVA: 0x0426FE60  token: 0x6000204
        public System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Controls.Data
{

    // TypeToken: 0x200005A  // size: 0x78
    public class ActionControl : SRDebugger.UI.Controls.OptionsControlBase
    {
        // Fields
        private SRF.Helpers.MethodReference _method;  // 0x60
        public UnityEngine.UI.Button Button;  // 0x68
        public UnityEngine.UI.Text Title;  // 0x70

        // Properties
        SRF.Helpers.MethodReference Method { get; /* RVA: 0x03D4EB00 */ }

        // Methods
        // RVA: 0x096A9C80  token: 0x6000206
        protected virtual System.Void Start() { }
        // RVA: 0x096A9B30  token: 0x6000207
        private System.Void ButtonOnClick() { }
        // RVA: 0x096A9C48  token: 0x6000208
        public System.Void SetMethod(System.String methodName, SRF.Helpers.MethodReference method) { }
        // RVA: 0x0426FE60  token: 0x6000209
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x90
    public class BoolControl : SRDebugger.UI.Controls.DataBoundControl
    {
        // Fields
        public UnityEngine.UI.Text Title;  // 0x80
        public UnityEngine.UI.Toggle Toggle;  // 0x88

        // Methods
        // RVA: 0x096A9E28  token: 0x600020A
        protected virtual System.Void Start() { }
        // RVA: 0x096A9EE0  token: 0x600020B
        private System.Void ToggleOnValueChanged(System.Boolean isOn) { }
        // RVA: 0x096A9D80  token: 0x600020C
        protected virtual System.Void OnBind(System.String propertyName, System.Type t) { }
        // RVA: 0x096A9DC4  token: 0x600020D
        protected virtual System.Void OnValueUpdated(System.Object newValue) { }
        // RVA: 0x096A9D1C  token: 0x600020E
        public virtual System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        // RVA: 0x0426FE60  token: 0x600020F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005C  // size: 0xC0
    public class EnumControl : SRDebugger.UI.Controls.DataBoundControl
    {
        // Fields
        private System.Object _lastValue;  // 0x80
        private System.String[] _names;  // 0x88
        private System.Array _values;  // 0x90
        public UnityEngine.UI.LayoutElement ContentLayoutElement;  // 0x98
        public UnityEngine.GameObject[] DisableOnReadOnly;  // 0xa0
        public SRF.UI.SRSpinner Spinner;  // 0xa8
        public UnityEngine.UI.Text Title;  // 0xb0
        public UnityEngine.UI.Text Value;  // 0xb8

        // Methods
        // RVA: 0x096AE99C  token: 0x6000210
        protected virtual System.Void Start() { }
        // RVA: 0x096B08C0  token: 0x6000211
        protected virtual System.Void OnBind(System.String propertyName, System.Type t) { }
        // RVA: 0x096B0B1C  token: 0x6000212
        protected virtual System.Void OnValueUpdated(System.Object newValue) { }
        // RVA: 0x093C0C94  token: 0x6000213
        public virtual System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        // RVA: 0x096B0BD8  token: 0x6000214
        private System.Void SetIndex(System.Int32 i) { }
        // RVA: 0x096B07F8  token: 0x6000215
        public System.Void GoToNext() { }
        // RVA: 0x096B085C  token: 0x6000216
        public System.Void GoToPrevious() { }
        // RVA: 0x0426FE60  token: 0x6000217
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005D  // size: 0xB8
    public class NumberControl : SRDebugger.UI.Controls.DataBoundControl
    {
        // Fields
        private static readonly System.Type[] IntegerTypes;  // static @ 0x0
        private static readonly System.Type[] DecimalTypes;  // static @ 0x8
        public static readonly System.Collections.Generic.Dictionary<System.Type,SRDebugger.UI.Controls.Data.NumberControl.ValueRange> ValueRanges;  // static @ 0x10
        private System.String _lastValue;  // 0x80
        private System.Type _type;  // 0x88
        public UnityEngine.GameObject[] DisableOnReadOnly;  // 0x90
        public SRF.UI.SRNumberButton DownNumberButton;  // 0x98
        public SRF.UI.SRNumberSpinner NumberSpinner;  // 0xa0
        public UnityEngine.UI.Text Title;  // 0xa8
        public SRF.UI.SRNumberButton UpNumberButton;  // 0xb0

        // Methods
        // RVA: 0x096B31C4  token: 0x6000218
        protected virtual System.Void Start() { }
        // RVA: 0x096B2F48  token: 0x6000219
        private System.Void OnValueChanged(System.String newValue) { }
        // RVA: 0x096B2BD4  token: 0x600021A
        protected virtual System.Void OnBind(System.String propertyName, System.Type t) { }
        // RVA: 0x096B30BC  token: 0x600021B
        protected virtual System.Void OnValueUpdated(System.Object newValue) { }
        // RVA: 0x096B27A8  token: 0x600021C
        public virtual System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        // RVA: 0x096B2B10  token: 0x600021D
        protected static System.Boolean IsIntegerType(System.Type t) { }
        // RVA: 0x096B2A4C  token: 0x600021E
        protected static System.Boolean IsDecimalType(System.Type t) { }
        // RVA: 0x096B280C  token: 0x600021F
        protected System.Double GetMaxValue(System.Type t) { }
        // RVA: 0x096B292C  token: 0x6000220
        protected System.Double GetMinValue(System.Type t) { }
        // RVA: 0x0426FE60  token: 0x6000221
        public System.Void .ctor() { }
        // RVA: 0x096B327C  token: 0x6000222
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x90
    public class ReadOnlyControl : SRDebugger.UI.Controls.DataBoundControl
    {
        // Fields
        public UnityEngine.UI.Text ValueText;  // 0x80
        public UnityEngine.UI.Text Title;  // 0x88

        // Methods
        // RVA: 0x096AE99C  token: 0x6000223
        protected virtual System.Void Start() { }
        // RVA: 0x096B87F4  token: 0x6000224
        protected virtual System.Void OnBind(System.String propertyName, System.Type t) { }
        // RVA: 0x096B8818  token: 0x6000225
        protected virtual System.Void OnValueUpdated(System.Object newValue) { }
        // RVA: 0x096B8774  token: 0x6000226
        public virtual System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        // RVA: 0x0426FE60  token: 0x6000227
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000060  // size: 0x90
    public class StringControl : SRDebugger.UI.Controls.DataBoundControl
    {
        // Fields
        public UnityEngine.UI.InputField InputField;  // 0x80
        public UnityEngine.UI.Text Title;  // 0x88

        // Methods
        // RVA: 0x096B9F08  token: 0x6000228
        protected virtual System.Void Start() { }
        // RVA: 0x096B9E78  token: 0x6000229
        private System.Void OnValueChanged(System.String newValue) { }
        // RVA: 0x096B9DEC  token: 0x600022A
        protected virtual System.Void OnBind(System.String propertyName, System.Type t) { }
        // RVA: 0x096B9E80  token: 0x600022B
        protected virtual System.Void OnValueUpdated(System.Object newValue) { }
        // RVA: 0x096B9D70  token: 0x600022C
        public virtual System.Boolean CanBind(System.Type type, System.Boolean isReadOnly) { }
        // RVA: 0x0426FE60  token: 0x600022D
        public System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Other
{

    // TypeToken: 0x2000031  // size: 0x58
    public class BugReportPopoverRoot : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.CanvasGroup CanvasGroup;  // 0x48
        public UnityEngine.RectTransform Container;  // 0x50

        // Methods
        // RVA: 0x0426FE60  token: 0x6000111
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0xA8
    public class BugReportSheetController : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.GameObject ButtonContainer;  // 0x48
        public UnityEngine.UI.Text ButtonText;  // 0x50
        public UnityEngine.UI.Button CancelButton;  // 0x58
        public System.Action CancelPressed;  // 0x60
        public UnityEngine.UI.InputField DescriptionField;  // 0x68
        public UnityEngine.UI.InputField EmailField;  // 0x70
        public UnityEngine.UI.Slider ProgressBar;  // 0x78
        public UnityEngine.UI.Text ResultMessageText;  // 0x80
        public System.Action ScreenshotComplete;  // 0x88
        public UnityEngine.UI.Button SubmitButton;  // 0x90
        public System.Action<System.Boolean,System.String> SubmitComplete;  // 0x98
        public System.Action TakingScreenshot;  // 0xa0

        // Properties
        System.Boolean IsCancelButtonEnabled { get; /* RVA: 0x096AB3DC */ set; /* RVA: 0x096AB40C */ }

        // Methods
        // RVA: 0x096AB270  token: 0x6000114
        protected virtual System.Void Start() { }
        // RVA: 0x096AB2F8  token: 0x6000115
        public System.Void Submit() { }
        // RVA: 0x096AAE44  token: 0x6000116
        public System.Void Cancel() { }
        // RVA: 0x096AB29C  token: 0x6000117
        private System.Collections.IEnumerator SubmitCo() { }
        // RVA: 0x096AB044  token: 0x6000118
        private System.Void OnBugReportProgress(System.Single progress) { }
        // RVA: 0x096AAF88  token: 0x6000119
        private System.Void OnBugReportComplete(System.Boolean didSucceed, System.String errorMessage) { }
        // RVA: 0x096AB118  token: 0x600011A
        protected System.Void SetLoadingSpinnerVisible(System.Boolean visible) { }
        // RVA: 0x096AAEC8  token: 0x600011B
        protected System.Void ClearForm() { }
        // RVA: 0x096AB170  token: 0x600011C
        protected System.Void ShowErrorMessage(System.String userMessage, System.String serverMessage) { }
        // RVA: 0x096AAE58  token: 0x600011D
        protected System.Void ClearErrorMessage() { }
        // RVA: 0x096AB0AC  token: 0x600011E
        protected System.Void SetFormEnabled(System.Boolean e) { }
        // RVA: 0x096AAF40  token: 0x600011F
        private System.String GetDefaultEmailFieldContents() { }
        // RVA: 0x096AB068  token: 0x6000120
        private System.Void SetDefaultEmailFieldContents(System.String value) { }
        // RVA: 0x0426FE60  token: 0x6000121
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x78
    public class CategoryGroup : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.RectTransform Container;  // 0x48
        public UnityEngine.UI.Text Header;  // 0x50
        public UnityEngine.GameObject Background;  // 0x58
        public UnityEngine.UI.Toggle SelectionToggle;  // 0x60
        public UnityEngine.GameObject[] EnabledDuringSelectionMode;  // 0x68
        private System.Boolean _selectionModeEnabled;  // 0x70

        // Properties
        System.Boolean IsSelected { get; /* RVA: 0x096AB7B4 */ set; /* RVA: 0x096AB7D4 */ }
        System.Boolean SelectionModeEnabled { get; /* RVA: 0x03D4F260 */ set; /* RVA: 0x096AB8AC */ }

        // Methods
        // RVA: 0x096AB760  token: 0x600012C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x68
    public class ConfigureCanvasFromSettings : SRF.SRMonoBehaviour
    {
        // Fields
        private UnityEngine.Canvas _canvas;  // 0x48
        private UnityEngine.UI.CanvasScaler _canvasScaler;  // 0x50
        private System.Single _originalScale;  // 0x58
        private System.Single _lastSetScale;  // 0x5c
        private SRDebugger.Settings _settings;  // 0x60

        // Methods
        // RVA: 0x096ABAC8  token: 0x600012D
        private System.Void Start() { }
        // RVA: 0x096AB99C  token: 0x600012E
        private System.Void OnDestroy() { }
        // RVA: 0x096ABA5C  token: 0x600012F
        private System.Void SettingsOnPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs) { }
        // RVA: 0x0426FE60  token: 0x6000130
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000036  // size: 0x80
    public class ConsoleTabQuickViewControl : SRF.SRMonoBehaviourEx
    {
        // Fields
        private static System.Int32 Max;  // const
        private static readonly System.String MaxString;  // static @ 0x0
        private System.Int32 _prevCriticalCount;  // 0x48
        private System.Int32 _prevErrorCount;  // 0x4c
        private System.Int32 _prevInfoCount;  // 0x50
        private System.Int32 _prevWarningCount;  // 0x54
        public SRDebugger.Services.IConsoleService ConsoleService;  // 0x58
        public UnityEngine.UI.Text CriticalCountText;  // 0x60
        public UnityEngine.UI.Text ErrorCountText;  // 0x68
        public UnityEngine.UI.Text InfoCountText;  // 0x70
        public UnityEngine.UI.Text WarningCountText;  // 0x78

        // Methods
        // RVA: 0x096AE274  token: 0x6000131
        protected virtual System.Void Awake() { }
        // RVA: 0x096AE344  token: 0x6000132
        protected virtual System.Void Update() { }
        // RVA: 0x096AE314  token: 0x6000133
        private static System.Boolean HasChanged(System.Int32 newCount, System.Int32& oldCount, System.Int32 max) { }
        // RVA: 0x096AE644  token: 0x6000134
        public System.Void .ctor() { }
        // RVA: 0x096AE5C8  token: 0x6000135
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x60
    public class DebugPanelBackgroundBehaviour : SRF.SRMonoBehaviour
    {
        // Fields
        private SRF.UI.StyleComponent _styleComponent;  // 0x48
        public System.String TransparentStyleKey;  // 0x50
        private SRF.UI.StyleSheet _styleSheet;  // 0x58

        // Methods
        // RVA: 0x096AEA08  token: 0x6000136
        private System.Void Awake() { }
        // RVA: 0x096AEAD0  token: 0x6000137
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000038  // size: 0xE0
    public class DockConsoleController : SRF.SRMonoBehaviourEx, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        // Fields
        public static System.Single NonFocusOpacity;  // const
        private System.Boolean _isDirty;  // 0x48
        private System.Boolean _isDragging;  // 0x49
        private System.Int32 _pointersOver;  // 0x4c
        public SRDebugger.Services.IConsoleFilterState FilterState;  // 0x50
        public UnityEngine.GameObject BottomHandle;  // 0x58
        public UnityEngine.CanvasGroup CanvasGroup;  // 0x60
        public SRDebugger.UI.Controls.ConsoleLogControl Console;  // 0x68
        public UnityEngine.GameObject Dropdown;  // 0x70
        public UnityEngine.UI.Image DropdownToggleSprite;  // 0x78
        public UnityEngine.UI.Text TextCriticals;  // 0x80
        public UnityEngine.UI.Text TextErrors;  // 0x88
        public UnityEngine.UI.Text TextInfo;  // 0x90
        public UnityEngine.UI.Text TextWarnings;  // 0x98
        public UnityEngine.UI.Toggle ToggleCriticals;  // 0xa0
        public UnityEngine.UI.Toggle ToggleErrors;  // 0xa8
        public UnityEngine.UI.Toggle ToggleInfo;  // 0xb0
        public UnityEngine.UI.Toggle ToggleWarnings;  // 0xb8
        public UnityEngine.GameObject TopBar;  // 0xc0
        public UnityEngine.GameObject TopHandle;  // 0xc8
        public UnityEngine.GameObject TopSafeAreaSpacer;  // 0xd0
        public UnityEngine.GameObject BottomSafeAreaSpacer;  // 0xd8

        // Properties
        System.Boolean IsVisible { get; /* RVA: 0x096B007C */ set; /* RVA: 0x096B00A0 */ }

        // Methods
        // RVA: 0x096AFB2C  token: 0x600013A
        protected virtual System.Void Start() { }
        // RVA: 0x096AF3EC  token: 0x600013B
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x096AF4E0  token: 0x600013C
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03D75190  token: 0x600013D
        protected virtual System.Void OnDisable() { }
        // RVA: 0x096B006C  token: 0x600013E
        protected virtual System.Void Update() { }
        // RVA: 0x096AF508  token: 0x600013F
        private System.Void OnFilterStateChange(UnityEngine.LogType logType, System.Boolean newState) { }
        // RVA: 0x03D73A50  token: 0x6000140
        private System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console) { }
        // RVA: 0x096AFAA0  token: 0x6000141
        public System.Void SetDropdownVisibility(System.Boolean visible) { }
        // RVA: 0x096AF804  token: 0x6000142
        public System.Void SetAlignmentMode(SRDebugger.ConsoleAlignment alignment) { }
        // RVA: 0x096AF5D0  token: 0x6000143
        private System.Void Refresh() { }
        // RVA: 0x096AF588  token: 0x6000144
        private System.Void RefreshAlpha() { }
        // RVA: 0x096AFEC8  token: 0x6000145
        public System.Void ToggleDropdownVisible() { }
        // RVA: 0x096AF390  token: 0x6000146
        public System.Void MenuButtonPressed() { }
        // RVA: 0x096AF36C  token: 0x6000147
        public System.Void ClearButtonPressed() { }
        // RVA: 0x096AFEFC  token: 0x6000148
        public System.Void TogglesUpdated() { }
        // RVA: 0x096AF568  token: 0x6000149
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData e) { }
        // RVA: 0x096AF578  token: 0x600014A
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData e) { }
        // RVA: 0x096AF3E0  token: 0x600014B
        public System.Void OnBeginDrag() { }
        // RVA: 0x096AF4F4  token: 0x600014C
        public System.Void OnEndDrag() { }
        // RVA: 0x0426FE60  token: 0x600014D
        public System.Void .ctor() { }
        // RVA: 0x096AFFAC  token: 0x600014E
        private System.Void <Start>b__25_0(System.Boolean isOn) { }
        // RVA: 0x096AFFDC  token: 0x600014F
        private System.Void <Start>b__25_1(System.Boolean isOn) { }
        // RVA: 0x096B000C  token: 0x6000150
        private System.Void <Start>b__25_2(System.Boolean isOn) { }
        // RVA: 0x096B003C  token: 0x6000151
        private System.Void <Start>b__25_3(System.Boolean isOn) { }

    }

    // TypeToken: 0x2000039  // size: 0x30
    public class ErrorNotifier : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.Single DisplayTime;  // const
        private UnityEngine.Animator _animator;  // 0x18
        private System.Int32 _triggerHash;  // 0x20
        private System.Single _hideTime;  // 0x24
        private System.Boolean _isShowing;  // 0x28
        private System.Boolean _queueWarning;  // 0x29

        // Properties
        System.Boolean IsVisible { get; /* RVA: 0x03D4ED50 */ }

        // Methods
        // RVA: 0x096B0C1C  token: 0x6000153
        private System.Void Awake() { }
        // RVA: 0x03D5CAD0  token: 0x6000154
        public System.Void ShowErrorWarning() { }
        // RVA: 0x096B0C58  token: 0x6000155
        private System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x6000156
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003A  // size: 0x28
    public class FloatOverElement : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
    {
        // Fields
        public UnityEngine.RectTransform CopyFrom;  // 0x18
        private UnityEngine.DrivenRectTransformTracker _tracker;  // 0x20

        // Methods
        // RVA: 0x096B0CDC  token: 0x6000157
        private System.Void Copy() { }
        // RVA: 0x096B0E88  token: 0x6000158
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x096B0E88  token: 0x6000159
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x0426FE60  token: 0x600015A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B  // size: 0x98
    public class HandleManager : SRF.SRMonoBehaviour
    {
        // Fields
        private System.Boolean _hasSet;  // 0x48
        public UnityEngine.GameObject BottomHandle;  // 0x50
        public UnityEngine.GameObject BottomLeftHandle;  // 0x58
        public UnityEngine.GameObject BottomRightHandle;  // 0x60
        public SRDebugger.PinAlignment DefaultAlignment;  // 0x68
        public UnityEngine.GameObject LeftHandle;  // 0x70
        public UnityEngine.GameObject RightHandle;  // 0x78
        public UnityEngine.GameObject TopHandle;  // 0x80
        public UnityEngine.GameObject TopLeftHandle;  // 0x88
        public UnityEngine.GameObject TopRightHandle;  // 0x90

        // Methods
        // RVA: 0x096B10EC  token: 0x600015B
        private System.Void Start() { }
        // RVA: 0x096B0F00  token: 0x600015C
        public System.Void SetAlignment(SRDebugger.PinAlignment alignment) { }
        // RVA: 0x096B0E90  token: 0x600015D
        private System.Void SetActive(UnityEngine.GameObject obj, System.Boolean active) { }
        // RVA: 0x0426FE60  token: 0x600015E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public interface IEnableTab
    {
        // Properties
        System.Boolean IsEnabled { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200003D  // size: 0x58
    public class LoadingSpinnerBehaviour : SRF.SRMonoBehaviour
    {
        // Fields
        private System.Single _dt;  // 0x48
        public System.Int32 FrameCount;  // 0x4c
        public System.Single SpinDuration;  // 0x50

        // Methods
        // RVA: 0x096B1C38  token: 0x6000160
        private System.Void Update() { }
        // RVA: 0x096B1D44  token: 0x6000161
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0x88
    public class PinnedUIRoot : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;  // 0x48
        public UnityEngine.RectTransform Container;  // 0x50
        public SRDebugger.UI.Other.DockConsoleController DockConsoleController;  // 0x58
        public UnityEngine.GameObject Options;  // 0x60
        public SRF.UI.Layout.FlowLayoutGroup OptionsLayoutGroup;  // 0x68
        public UnityEngine.GameObject Profiler;  // 0x70
        public SRDebugger.UI.Other.HandleManager ProfilerHandleManager;  // 0x78
        public UnityEngine.UI.VerticalLayoutGroup ProfilerVerticalLayoutGroup;  // 0x80

        // Methods
        // RVA: 0x0426FE60  token: 0x6000162
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003F  // size: 0x28
    public class SafeAreaSizer : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement
    {
        // Fields
        private UnityEngine.RectTransform.Edge _edge;  // 0x18
        public System.Single Scale;  // 0x1c
        private System.Single _height;  // 0x20
        private System.Single _width;  // 0x24

        // Properties
        UnityEngine.RectTransform.Edge Edge { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x096B9708 */ }
        System.Single preferredWidth { get; /* RVA: 0x03D524F0 */ }
        System.Single preferredHeight { get; /* RVA: 0x03D4F2E0 */ }
        System.Single minWidth { get; /* RVA: 0x03D524F0 */ }
        System.Single minHeight { get; /* RVA: 0x03D4F2E0 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x02102C70 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }

        // Methods
        // RVA: 0x096B9468  token: 0x600016C
        private System.Void Refresh() { }
        // RVA: 0x096B943C  token: 0x600016D
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x096B943C  token: 0x600016E
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x03B45ED0  token: 0x600016F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000040  // size: 0x18
    public class ScrollSettingsBehaviour : UnityEngine.MonoBehaviour
    {
        // Fields
        public static System.Single ScrollSensitivity;  // const

        // Methods
        // RVA: 0x096B9794  token: 0x6000170
        private System.Void Awake() { }
        // RVA: 0x0426FE60  token: 0x6000171
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000041  // size: 0x48
    public class SetLayerFromSettings : SRF.SRMonoBehaviour
    {
        // Methods
        // RVA: 0x096B97F8  token: 0x6000172
        private System.Void Start() { }
        // RVA: 0x0426FE60  token: 0x6000173
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x90
    public class SRTab : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.RectTransform HeaderExtraContent;  // 0x48
        public UnityEngine.Sprite Icon;  // 0x50
        public UnityEngine.RectTransform IconExtraContent;  // 0x58
        public System.String IconStyleKey;  // 0x60
        public System.Int32 SortIndex;  // 0x68
        public SRDebugger.UI.Controls.SRTabButton TabButton;  // 0x70
        private System.String _title;  // 0x78
        private System.String _longTitle;  // 0x80
        private System.String _key;  // 0x88

        // Properties
        System.String Title { get; /* RVA: 0x03D4EB20 */ }
        System.String LongTitle { get; /* RVA: 0x096B9424 */ }
        System.String Key { get; /* RVA: 0x03D4EA60 */ }

        // Methods
        // RVA: 0x096B93DC  token: 0x6000177
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x88
    public class SRTabController : SRF.SRMonoBehaviourEx
    {
        // Fields
        private readonly SRF.SRList<SRDebugger.UI.Other.SRTab> _tabs;  // 0x48
        private SRDebugger.UI.Other.SRTab _activeTab;  // 0x50
        public UnityEngine.RectTransform TabButtonContainer;  // 0x58
        public SRDebugger.UI.Controls.SRTabButton TabButtonPrefab;  // 0x60
        public UnityEngine.RectTransform TabContentsContainer;  // 0x68
        public UnityEngine.RectTransform TabHeaderContentContainer;  // 0x70
        public UnityEngine.UI.Text TabHeaderText;  // 0x78
        private System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> ActiveTabChanged;  // 0x80

        // Properties
        SRDebugger.UI.Other.SRTab ActiveTab { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x096B93D4 */ }
        System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> Tabs { get; /* RVA: 0x096B92FC */ }

        // Events
        event System.Action<SRDebugger.UI.Other.SRTabController,SRDebugger.UI.Other.SRTab> ActiveTabChanged;

        // Methods
        // RVA: 0x096B89BC  token: 0x600017D
        public System.Void AddTab(SRDebugger.UI.Other.SRTab tab, System.Boolean visibleInSidebar) { }
        // RVA: 0x096B8CC8  token: 0x600017E
        private System.Void MakeActive(SRDebugger.UI.Other.SRTab tab) { }
        // RVA: 0x096B9030  token: 0x600017F
        private System.Void SortTabs() { }
        // RVA: 0x096B9208  token: 0x6000180
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x70
    public class TriggerRoot : SRF.SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;  // 0x48
        public SRF.UI.LongPressButton TapHoldButton;  // 0x50
        public UnityEngine.RectTransform TriggerTransform;  // 0x58
        public SRDebugger.UI.Other.ErrorNotifier ErrorNotifier;  // 0x60
        public SRDebugger.UI.Controls.MultiTapButton TripleTapButton;  // 0x68

        // Methods
        // RVA: 0x0426FE60  token: 0x6000186
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000047  // size: 0x58
    public class VersionTextBehaviour : SRF.SRMonoBehaviourEx
    {
        // Fields
        public System.String Format;  // 0x48
        public UnityEngine.UI.Text Text;  // 0x50

        // Methods
        // RVA: 0x096BACE8  token: 0x6000187
        protected virtual System.Void Start() { }
        // RVA: 0x096BAD4C  token: 0x6000188
        public System.Void .ctor() { }

    }

}

namespace SRDebugger.UI.Tabs
{

    // TypeToken: 0x2000027  // size: 0x58
    public class BugReportTabController : SRF.SRMonoBehaviourEx, SRDebugger.UI.Other.IEnableTab
    {
        // Fields
        public SRDebugger.UI.Other.BugReportSheetController BugReportSheetPrefab;  // 0x48
        public UnityEngine.RectTransform Container;  // 0x50

        // Properties
        System.Boolean IsEnabled { get; /* RVA: 0x096AB6BC */ }

        // Methods
        // RVA: 0x096AB540  token: 0x60000C3
        protected virtual System.Void Start() { }
        // RVA: 0x096AB670  token: 0x60000C4
        private System.Void TakingScreenshot() { }
        // RVA: 0x096AB4F4  token: 0x60000C5
        private System.Void ScreenshotComplete() { }
        // RVA: 0x0426FE60  token: 0x60000C6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000028  // size: 0x118
    public class ConsoleTabController : SRF.SRMonoBehaviourEx
    {
        // Fields
        private static System.Int32 MaxLength;  // const
        private UnityEngine.Canvas _consoleCanvas;  // 0x48
        private System.Boolean _isDirty;  // 0x50
        private static System.Boolean _hasWarnedAboutLogHandler;  // static @ 0x0
        private static System.Boolean _hasWarnedAboutLoggingDisabled;  // static @ 0x1
        public SRDebugger.Services.IConsoleFilterState FilterState;  // 0x58
        public SRDebugger.UI.Controls.ConsoleLogControl ConsoleLogControl;  // 0x60
        public UnityEngine.UI.Toggle PinToggle;  // 0x68
        public UnityEngine.UI.ScrollRect StackTraceScrollRect;  // 0x70
        public UnityEngine.UI.Text StackTraceText;  // 0x78
        public UnityEngine.UI.Toggle ToggleCriticals;  // 0x80
        public UnityEngine.UI.Text ToggleCriticalsText;  // 0x88
        public UnityEngine.UI.Toggle ToggleErrors;  // 0x90
        public UnityEngine.UI.Text ToggleErrorsText;  // 0x98
        public UnityEngine.UI.Toggle ToggleInfo;  // 0xa0
        public UnityEngine.UI.Text ToggleInfoText;  // 0xa8
        public UnityEngine.UI.Toggle ToggleWarnings;  // 0xb0
        public UnityEngine.UI.Text ToggleWarningsText;  // 0xb8
        public UnityEngine.GameObject CopyToClipboardContainer;  // 0xc0
        public UnityEngine.GameObject CopyToClipboardButton;  // 0xc8
        public UnityEngine.GameObject CopyToClipboardMessage;  // 0xd0
        public UnityEngine.CanvasGroup CopyToClipboardMessageCanvasGroup;  // 0xd8
        public UnityEngine.GameObject LoggingIsDisabledCanvasGroup;  // 0xe0
        public UnityEngine.GameObject LogHandlerHasBeenOverridenGroup;  // 0xe8
        public UnityEngine.UI.Toggle FilterToggle;  // 0xf0
        public UnityEngine.UI.InputField FilterField;  // 0xf8
        public UnityEngine.GameObject FilterBarContainer;  // 0x100
        private SRDebugger.Services.ConsoleEntry _selectedItem;  // 0x108
        private UnityEngine.Coroutine _fadeButtonCoroutine;  // 0x110

        // Methods
        // RVA: 0x096ADB10  token: 0x60000C7
        protected virtual System.Void Start() { }
        // RVA: 0x096AD2D0  token: 0x60000C8
        private System.Void OnFilterStateChange(UnityEngine.LogType logtype, System.Boolean newstate) { }
        // RVA: 0x096ACF3C  token: 0x60000C9
        private System.Void FilterToggleValueChanged(System.Boolean isOn) { }
        // RVA: 0x096ACFBC  token: 0x60000CA
        private System.Void FilterValueChanged(System.String filterText) { }
        // RVA: 0x096AD330  token: 0x60000CB
        private System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b) { }
        // RVA: 0x096AD3CC  token: 0x60000CC
        private System.Void PinToggleValueChanged(System.Boolean isOn) { }
        // RVA: 0x096AD1C8  token: 0x60000CD
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x03D75180  token: 0x60000CE
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096AD2C8  token: 0x60000CF
        protected virtual System.Void OnDisable() { }
        // RVA: 0x096ACDB8  token: 0x60000D0
        private System.Void ConsoleLogSelectedItemChanged(System.Object item) { }
        // RVA: 0x096AE264  token: 0x60000D1
        protected virtual System.Void Update() { }
        // RVA: 0x096AD3F8  token: 0x60000D2
        private System.Void PopulateStackTraceArea(SRDebugger.Services.ConsoleEntry entry) { }
        // RVA: 0x096ACE0C  token: 0x60000D3
        public System.Void CopyToClipboard() { }
        // RVA: 0x096AD950  token: 0x60000D4
        private System.Void SetCopyToClipboardButtonState(SRDebugger.UI.Tabs.ConsoleTabController.CopyToClipboardStates state) { }
        // RVA: 0x096ACEE0  token: 0x60000D5
        private System.Collections.IEnumerator FadeCopyButton() { }
        // RVA: 0x096AE148  token: 0x60000D6
        private System.Void StopAnimations() { }
        // RVA: 0x096AD5CC  token: 0x60000D7
        private System.Void Refresh() { }
        // RVA: 0x03D75180  token: 0x60000D8
        private System.Void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console) { }
        // RVA: 0x096ACD88  token: 0x60000D9
        public System.Void Clear() { }
        // RVA: 0x096AD038  token: 0x60000DA
        public System.Void LogHandlerHasBeenOverridenOkayButtonPress() { }
        // RVA: 0x096AD090  token: 0x60000DB
        public System.Void LoggingDisableCloseAndIgnorePressed() { }
        // RVA: 0x096AD0EC  token: 0x60000DC
        public System.Void LoggingDisableReenablePressed() { }
        // RVA: 0x0426FE60  token: 0x60000DD
        public System.Void .ctor() { }
        // RVA: 0x096AE1A4  token: 0x60000DE
        private System.Void <Start>b__29_0(System.Boolean isOn) { }
        // RVA: 0x096AE1D4  token: 0x60000DF
        private System.Void <Start>b__29_1(System.Boolean isOn) { }
        // RVA: 0x096AE204  token: 0x60000E0
        private System.Void <Start>b__29_2(System.Boolean isOn) { }
        // RVA: 0x096AE234  token: 0x60000E1
        private System.Void <Start>b__29_3(System.Boolean isOn) { }

    }

    // TypeToken: 0x200002B  // size: 0x70
    public class InfoTabController : SRF.SRMonoBehaviourEx
    {
        // Fields
        public static System.Char Tick;  // const
        public static System.Char Cross;  // const
        public static System.String NameColor;  // const
        private System.Collections.Generic.Dictionary<System.String,SRDebugger.UI.Controls.InfoBlock> _infoBlocks;  // 0x48
        public SRDebugger.UI.Controls.InfoBlock InfoBlockPrefab;  // 0x50
        public UnityEngine.RectTransform LayoutContainer;  // 0x58
        public SRF.UI.FlashGraphic ToggleButton;  // 0x60
        private System.Boolean _updateEveryFrame;  // 0x68

        // Methods
        // RVA: 0x096B1B3C  token: 0x60000E8
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B1B74  token: 0x60000E9
        public System.Void Refresh() { }
        // RVA: 0x096B1BA8  token: 0x60000EA
        protected virtual System.Void Update() { }
        // RVA: 0x096B1214  token: 0x60000EB
        public System.Void ActivateRefreshEveryFrame() { }
        // RVA: 0x096B174C  token: 0x60000EC
        private System.Void InternalRefresh() { }
        // RVA: 0x096B12E0  token: 0x60000ED
        private System.Void FillInfoBlock(SRDebugger.UI.Controls.InfoBlock block, System.Collections.Generic.IList<SRDebugger.InfoEntry> info) { }
        // RVA: 0x096B1248  token: 0x60000EE
        private SRDebugger.UI.Controls.InfoBlock CreateBlock(System.String title) { }
        // RVA: 0x096B1BB8  token: 0x60000EF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0xB0
    public class OptionsTabController : SRF.SRMonoBehaviourEx
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controls;  // 0x48
        private readonly System.Collections.Generic.List<SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance> _categories;  // 0x50
        private readonly System.Collections.Generic.Dictionary<SRDebugger.OptionDefinition,SRDebugger.UI.Controls.OptionsControlBase> _options;  // 0x58
        private System.Boolean _queueRefresh;  // 0x60
        private System.Boolean _selectionModeEnabled;  // 0x61
        private UnityEngine.Canvas _optionCanvas;  // 0x68
        public SRDebugger.UI.Controls.Data.ActionControl ActionControlPrefab;  // 0x70
        public SRDebugger.UI.Other.CategoryGroup CategoryGroupPrefab;  // 0x78
        public UnityEngine.RectTransform ContentContainer;  // 0x80
        public UnityEngine.GameObject NoOptionsNotice;  // 0x88
        public UnityEngine.UI.Toggle PinButton;  // 0x90
        public UnityEngine.GameObject PinPromptSpacer;  // 0x98
        public UnityEngine.GameObject PinPromptText;  // 0xa0
        private System.Boolean _isTogglingCategory;  // 0xa8

        // Methods
        // RVA: 0x096B58A8  token: 0x60000F0
        protected virtual System.Void Start() { }
        // RVA: 0x096B4710  token: 0x60000F1
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x096B4A24  token: 0x60000F2
        private System.Void OnOptionPinnedStateChanged(SRDebugger.OptionDefinition optionDefinition, System.Boolean isPinned) { }
        // RVA: 0x096B4AF4  token: 0x60000F3
        private System.Void OnOptionsUpdated(System.Object sender, System.EventArgs eventArgs) { }
        // RVA: 0x096B4990  token: 0x60000F4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B48A4  token: 0x60000F5
        protected virtual System.Void OnDisable() { }
        // RVA: 0x096B5AAC  token: 0x60000F6
        protected virtual System.Void Update() { }
        // RVA: 0x096B4B14  token: 0x60000F7
        private System.Void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, System.Boolean b) { }
        // RVA: 0x096B5548  token: 0x60000F8
        public System.Void SetSelectionModeEnabled(System.Boolean isEnabled) { }
        // RVA: 0x096B5408  token: 0x60000F9
        private System.Void Refresh() { }
        // RVA: 0x096B3CD0  token: 0x60000FA
        private System.Void CommitPinnedOptions() { }
        // RVA: 0x096B5244  token: 0x60000FB
        private System.Void RefreshCategorySelection() { }
        // RVA: 0x096B4AC4  token: 0x60000FC
        private System.Void OnOptionSelectionToggle(System.Boolean selected) { }
        // RVA: 0x096B465C  token: 0x60000FD
        private System.Void OnCategorySelectionToggle(SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance category, System.Boolean selected) { }
        // RVA: 0x096B4BC8  token: 0x60000FE
        protected System.Void Populate() { }
        // RVA: 0x096B3EFC  token: 0x60000FF
        protected System.Void CreateCategory(System.String title, System.Collections.Generic.List<SRDebugger.OptionDefinition> options) { }
        // RVA: 0x096B3B04  token: 0x6000100
        private System.Void Clear() { }
        // RVA: 0x096B5AC0  token: 0x6000101
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x58
    public class ProfilerTabController : SRF.SRMonoBehaviourEx
    {
        // Fields
        private System.Boolean _isDirty;  // 0x48
        public UnityEngine.UI.Toggle PinToggle;  // 0x50

        // Methods
        // RVA: 0x096B86AC  token: 0x600010B
        protected virtual System.Void Start() { }
        // RVA: 0x096B85E0  token: 0x600010C
        private System.Void PinToggleValueChanged(System.Boolean isOn) { }
        // RVA: 0x03D73A50  token: 0x600010D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096B8764  token: 0x600010E
        protected virtual System.Void Update() { }
        // RVA: 0x096B8634  token: 0x600010F
        private System.Void Refresh() { }
        // RVA: 0x0426FE60  token: 0x6000110
        public System.Void .ctor() { }

    }

}

