// ========================================================
// Dumped by @desirepro
// Assembly: Input.Beyond.dll
// Classes:  72
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct CursorMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode SoftwareCursor;  // const
        public static UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode HardwareCursorIfAvailable;  // const

    }

    // TypeToken: 0x2000013  // size: 0x30
    public class Binding
    {
        // Fields
        public Beyond.Input.InputBindingInfo info;  // 0x10
        public System.Single pressDownTime;  // 0x18
        public System.Boolean isUsedForBlock;  // 0x1c
        public System.Boolean isCommonOpenUIAction;  // 0x1d
        public System.Int32 longPressTimerId;  // 0x20
        public System.Single longPressTime;  // 0x24
        public System.Boolean enableContinuousTrigger;  // 0x28
        public Beyond.Input.InputContinuousTriggerType continuousTriggerType;  // 0x2c

        // Methods
        // RVA: 0x02856C30  token: 0x6000072
        public System.Void .ctor(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct TriggerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.GamepadCheckerBase.TriggerType NORMAL;  // const
        public static Beyond.Input.GamepadCheckerBase.TriggerType CONTINUOUS;  // const
        public static Beyond.Input.GamepadCheckerBase.TriggerType STOP_CONTINUOUS;  // const

    }

    // TypeToken: 0x2000018  // size: 0x28
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public Beyond.Input.GamepadOnLongPressChecker <>4__this;  // 0x10
        public Beyond.Input.GamepadCheckerBase.Binding binding;  // 0x18
        public Beyond.Input.GamepadKeyCode keyCode;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000086
        public System.Void .ctor() { }
        // RVA: 0x088B2C9C  token: 0x6000087
        private System.Void <CreateTriggerBindingAction>b__0() { }

    }

    // TypeToken: 0x200001B  // size: 0x28
    public class CursorSpeedPhase
    {
        // Fields
        public System.Single maxJsValue;  // 0x10
        public System.Single minSpeed;  // 0x14
        public System.Single maxSpeed;  // 0x18
        public System.Single acceleration;  // 0x1c
        public System.Single accelerationSpeed;  // 0x20
        public System.Single maxAcceleration;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x60000B9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Input.HGVirtualMouse.<>c <>9;  // static @ 0x0
        public static System.Predicate<UnityEngine.UI.Selectable> <>9__78_0;  // static @ 0x8

        // Methods
        // RVA: 0x088B2CC8  token: 0x60000BA
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60000BB
        public System.Void .ctor() { }
        // RVA: 0x088B280C  token: 0x60000BC
        private System.Boolean <ChangeHoverState>b__78_0(UnityEngine.UI.Selectable o) { }

    }

    // TypeToken: 0x2000027  // size: 0x20
    public class KeyCaches
    {
        // Fields
        public System.Boolean escapeKeyDown;  // 0x10
        public System.Boolean mouse0KeyDown;  // 0x11
        public System.Boolean mouse1KeyDown;  // 0x12
        public System.Boolean escapeKeyUp;  // 0x13
        public System.Boolean mouse0KeyUp;  // 0x14
        public System.Boolean mouse1KeyUp;  // 0x15
        public System.Boolean escapeKey;  // 0x16
        public System.Boolean mouse0Key;  // 0x17
        public System.Boolean mouse1Key;  // 0x18

        // Methods
        // RVA: 0x02853C40  token: 0x60001DE
        public System.Void UpdateKeyStat() { }
        // RVA: 0x0350B670  token: 0x60001DF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000028  // size: 0x14
    public sealed struct KeyCodeState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.InputManager.KeyCodeState Pressed;  // const
        public static Beyond.Input.InputManager.KeyCodeState OnPress;  // const
        public static Beyond.Input.InputManager.KeyCodeState OnRelease;  // const

    }

    // TypeToken: 0x2000029  // size: 0x30
    public class ControllerHintInfo : System.IComparable`1, Beyond.PoolCore.IReusable
    {
        // Fields
        public System.String actionId;  // 0x10
        public System.Int32 priority;  // 0x18
        public Beyond.Input.InputBindingInfo bind;  // 0x20
        public Beyond.Input.IBindingView hintView;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60001E0
        public System.Void .ctor() { }
        // RVA: 0x088A8554  token: 0x60001E1
        public System.Void .ctor(Beyond.Input.IBindingView hintView, Beyond.Input.InputBindingInfo bind) { }
        // RVA: 0x088A855C  token: 0x60001E2
        public System.Void .ctor(System.String actionId) { }
        // RVA: 0x088A83F4  token: 0x60001E3
        public System.Void Reset(Beyond.Input.IBindingView newHintView, Beyond.Input.InputBindingInfo newBind) { }
        // RVA: 0x088A84A0  token: 0x60001E4
        public System.Void Reset(System.String resetActionId) { }
        // RVA: 0x088A82D8  token: 0x60001E5
        public virtual System.Int32 CompareTo(Beyond.Input.InputManager.ControllerHintInfo other) { }
        // RVA: 0x088A8338  token: 0x60001E6
        public virtual System.Void OnAllocate() { }
        // RVA: 0x088A837C  token: 0x60001E7
        public virtual System.Void OnRecycle() { }

    }

    // TypeToken: 0x200002A  // size: 0x14
    public sealed struct SkillButtonState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.InputManager.SkillButtonState None;  // const
        public static Beyond.Input.InputManager.SkillButtonState JustPressed;  // const

    }

    // TypeToken: 0x200002B  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Input.InputManager.<>c <>9;  // static @ 0x0
        public static System.Action <>9__94_0;  // static @ 0x8
        public static System.Action <>9__221_0;  // static @ 0x10
        public static System.Text.RegularExpressions.MatchEvaluator <>9__290_0;  // static @ 0x18

        // Methods
        // RVA: 0x03D179F0  token: 0x60001E8
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001E9
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x60001EA
        private System.Void <_InitDeviceChangeBinding>b__94_0() { }
        // RVA: 0x0350B670  token: 0x60001EB
        private System.Void <_CreateVirtualMouse>b__221_0() { }
        // RVA: 0x088B2858  token: 0x60001EC
        private System.String <ParseTextActionId>b__290_0(System.Text.RegularExpressions.Match match) { }

    }

    // TypeToken: 0x2000032  // size: 0x30
    public class Binding
    {
        // Fields
        public Beyond.Input.InputBindingInfo info;  // 0x10
        public System.Single pressDownTime;  // 0x18
        public System.Boolean isUsedForBlock;  // 0x1c
        public System.Int32 longPressTimerId;  // 0x20
        public System.Single longPressTime;  // 0x24
        public System.Boolean enableContinuousTrigger;  // 0x28
        public System.Boolean isCommonOpenUIAction;  // 0x29
        public Beyond.Input.InputContinuousTriggerType continuousTriggerType;  // 0x2c

        // Methods
        // RVA: 0x028572A0  token: 0x60001FC
        public System.Void .ctor(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct TriggerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.KeyboardCheckerBase.TriggerType NORMAL;  // const
        public static Beyond.Input.KeyboardCheckerBase.TriggerType CONTINUOUS;  // const
        public static Beyond.Input.KeyboardCheckerBase.TriggerType STOP_CONTINUOUS;  // const

    }

    // TypeToken: 0x2000037  // size: 0x30
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public System.ValueTuple<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>> key;  // 0x10
        public Beyond.Input.KeyboardCheckerBase.Binding targetBinding;  // 0x20
        public Beyond.Input.KeyboardOnLongPressChecker <>4__this;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000213
        public System.Void .ctor() { }
        // RVA: 0x088B7E80  token: 0x6000214
        private System.Void <CheckKeyboardInput>b__0() { }

    }

    // TypeToken: 0x2000044  // size: 0x30
    public sealed struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x2000043  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 E680B0AF74F1D11AFCE59DFB222E2F946D48C66AE24640EE35784361EEA2E0C4;  // static @ 0x0

    }

namespace Beyond.Input
{

    // TypeToken: 0x200000A  // size: 0x58
    public class ControllerNaviManager
    {
        // Fields
        public System.Collections.Generic.LinkedList<UnityEngine.UI.SelectableNaviGroup> layerStackList;  // 0x10
        public UnityEngine.UI.Selectable curTarget;  // 0x18
        private readonly System.Collections.Generic.HashSet<System.String> m_naviLockSet;  // 0x20
        private System.Int32 m_targetInputBindingGroupId;  // 0x28
        private System.Int32 m_naviInputBindingGroupId;  // 0x2c
        private UnityEngine.UI.Selectable m_lastEnableNaviTarget;  // 0x30
        private UnityEngine.UI.NavigationBindingType <navigationBindingType>k__BackingField;  // 0x38
        private System.Collections.Generic.Dictionary<UnityEngine.UI.NavigationBindingType,System.Int32> m_naviBindingGroupIds;  // 0x40
        private Beyond.Input.InputManager m_inputManager;  // 0x48
        private static System.Single SCORE_OFFSET;  // const
        private System.Boolean <forceEnableNaviForGuide>k__BackingField;  // 0x50

        // Properties
        UnityEngine.UI.NavigationBindingType navigationBindingType { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.Boolean forceEnableNaviForGuide { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }

        // Methods
        // RVA: 0x035A95B0  token: 0x600002D
        public System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        // RVA: 0x035AA6D0  token: 0x600002E
        public System.Void SetNaviBindingType(UnityEngine.UI.NavigationBindingType bindingType) { }
        // RVA: 0x028532B0  token: 0x600002F
        public System.Void Tick() { }
        // RVA: 0x02C6FC90  token: 0x6000030
        private System.Boolean _RemoveLayer(UnityEngine.UI.SelectableNaviGroup group, UnityEngine.UI.SelectableNaviGroup curLayer) { }
        // RVA: 0x02C701C0  token: 0x6000031
        private System.Void _RemoveLayerFromStack(UnityEngine.UI.SelectableNaviGroup group, System.Boolean silentMode) { }
        // RVA: 0x03A507E0  token: 0x6000032
        private System.Void _SetTarget(UnityEngine.UI.Selectable target) { }
        // RVA: 0x088A99BC  token: 0x6000033
        private System.Void _OnLayerSelected(UnityEngine.UI.SelectableNaviGroup topLayer) { }
        // RVA: 0x088A8DA4  token: 0x6000034
        private System.Boolean _DefaultNavigate(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x088A9BE8  token: 0x6000035
        private UnityEngine.UI.Selectable _TryFindBestNaviTargetInGroup(UnityEngine.UI.SelectableNaviGroup group, UnityEngine.Vector3 pos, UnityEngine.Vector3 dir, System.Double curMaxScore, System.Double& maxScore) { }
        // RVA: 0x088A9F8C  token: 0x6000036
        private UnityEngine.UI.Selectable _TryFindBestNaviTarget(System.Collections.Generic.HashSet<UnityEngine.UI.Selectable> targets, UnityEngine.Vector3 curPos, UnityEngine.Vector3 dir, UnityEngine.UI.NaviStrategy strategy, System.Double curMaxScore, System.Double& maxScore) { }
        // RVA: 0x088A97B4  token: 0x6000037
        private static UnityEngine.Vector3 _GetPointOnRectEdge(UnityEngine.RectTransform rectTransform, UnityEngine.Vector2 dir) { }
        // RVA: 0x088A89C8  token: 0x600003A
        public System.Void SetForceEnableNavi(System.Boolean enable) { }
        // RVA: 0x024B1C30  token: 0x600003B
        public System.Void UpdateNaviInputBindingState() { }
        // RVA: 0x024B1EA0  token: 0x600003C
        public System.Boolean IsNavigationBindingEnabled() { }
        // RVA: 0x0304D9A0  token: 0x600003D
        public System.Void TryRemoveLayer(UnityEngine.UI.SelectableNaviGroup group) { }
        // RVA: 0x02C70150  token: 0x600003E
        public System.Boolean IsLayerInStack(UnityEngine.UI.SelectableNaviGroup group) { }
        // RVA: 0x088A8744  token: 0x600003F
        public System.Boolean IsTopLayer(UnityEngine.UI.SelectableNaviGroup group) { }
        // RVA: 0x036F07B0  token: 0x6000040
        public System.Void ChangeAndTrySetNaviBindingType(UnityEngine.UI.SelectableNaviGroup naviGroup, UnityEngine.UI.NavigationBindingType naviBindingType) { }
        // RVA: 0x088A8C74  token: 0x6000041
        public System.Void TryAutoSetTarget() { }
        // RVA: 0x03A50790  token: 0x6000042
        public System.Void SetTarget(UnityEngine.UI.Selectable target) { }
        // RVA: 0x088A8A4C  token: 0x6000043
        public System.Void SetTargetInSilentModeIfNecessary(UnityEngine.UI.SelectableNaviGroup naviGroup, UnityEngine.UI.Selectable selectable) { }
        // RVA: 0x088A86B8  token: 0x6000044
        public System.Boolean IsNaviTarget(UnityEngine.UI.Selectable target) { }
        // RVA: 0x088A8564  token: 0x6000045
        public UnityEngine.Vector3 GetNaviVector(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x088A8840  token: 0x6000046
        public System.Void Navigate(UnityEngine.UI.NaviDirection dir) { }
        // RVA: 0x088A8B7C  token: 0x6000047
        public System.Void ToggleNavigation(System.String key, System.Boolean active) { }
        // RVA: 0x088A8D64  token: 0x6000048
        private System.Void <.ctor>b__12_0() { }
        // RVA: 0x088A8D94  token: 0x6000049
        private System.Void <.ctor>b__12_1() { }
        // RVA: 0x088A8D74  token: 0x600004A
        private System.Void <.ctor>b__12_2() { }
        // RVA: 0x088A8D84  token: 0x600004B
        private System.Void <.ctor>b__12_3() { }
        // RVA: 0x088A8D74  token: 0x600004C
        private System.Void <.ctor>b__12_4() { }
        // RVA: 0x088A8D84  token: 0x600004D
        private System.Void <.ctor>b__12_5() { }
        // RVA: 0x088A8D64  token: 0x600004E
        private System.Void <.ctor>b__12_6() { }
        // RVA: 0x088A8D94  token: 0x600004F
        private System.Void <.ctor>b__12_7() { }
        // RVA: 0x088A8D64  token: 0x6000050
        private System.Void <.ctor>b__12_8() { }
        // RVA: 0x088A8D94  token: 0x6000051
        private System.Void <.ctor>b__12_9() { }
        // RVA: 0x088A8D74  token: 0x6000052
        private System.Void <.ctor>b__12_10() { }
        // RVA: 0x088A8D84  token: 0x6000053
        private System.Void <.ctor>b__12_11() { }
        // RVA: 0x088A8D74  token: 0x6000054
        private System.Void <.ctor>b__12_12() { }
        // RVA: 0x088A8D84  token: 0x6000055
        private System.Void <.ctor>b__12_13() { }
        // RVA: 0x088A8D64  token: 0x6000056
        private System.Void <.ctor>b__12_14() { }
        // RVA: 0x088A8D94  token: 0x6000057
        private System.Void <.ctor>b__12_15() { }
        // RVA: 0x088A8D64  token: 0x6000058
        private System.Void <.ctor>b__12_16() { }
        // RVA: 0x088A8D94  token: 0x6000059
        private System.Void <.ctor>b__12_17() { }
        // RVA: 0x088A8D74  token: 0x600005A
        private System.Void <.ctor>b__12_18() { }
        // RVA: 0x088A8D84  token: 0x600005B
        private System.Void <.ctor>b__12_19() { }
        // RVA: 0x088A8D74  token: 0x600005C
        private System.Void <.ctor>b__12_20() { }
        // RVA: 0x088A8D84  token: 0x600005D
        private System.Void <.ctor>b__12_21() { }
        // RVA: 0x088A8D64  token: 0x600005E
        private System.Void <.ctor>b__12_22() { }
        // RVA: 0x088A8D94  token: 0x600005F
        private System.Void <.ctor>b__12_23() { }
        // RVA: 0x088A8D64  token: 0x6000060
        private System.Void <.ctor>b__12_24() { }
        // RVA: 0x088A8D94  token: 0x6000061
        private System.Void <.ctor>b__12_25() { }
        // RVA: 0x088A8D74  token: 0x6000062
        private System.Void <.ctor>b__12_26() { }
        // RVA: 0x088A8D84  token: 0x6000063
        private System.Void <.ctor>b__12_27() { }
        // RVA: 0x088A8D74  token: 0x6000064
        private System.Void <.ctor>b__12_28() { }
        // RVA: 0x088A8D84  token: 0x6000065
        private System.Void <.ctor>b__12_29() { }
        // RVA: 0x088A8D64  token: 0x6000066
        private System.Void <.ctor>b__12_30() { }
        // RVA: 0x088A8D94  token: 0x6000067
        private System.Void <.ctor>b__12_31() { }

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct ActionOnSetNaviTarget
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.ActionOnSetNaviTarget None;  // const
        public static Beyond.Input.ActionOnSetNaviTarget AutoTriggerOnClick;  // const
        public static Beyond.Input.ActionOnSetNaviTarget PressConfirmTriggerOnClick;  // const

    }

    // TypeToken: 0x200000C  // size: 0x10
    public static class ControllerNaviUtils
    {
    }

    // TypeToken: 0x200000D  // size: 0x20
    public class PSTriggerEffectCfg : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Plugins.LibScePad.TriggerEffectCommandUnion> commands;  // 0x18

        // Methods
        // RVA: 0x0426FE60  token: 0x6000068
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x14
    public sealed struct KeyboardKeyCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.KeyboardKeyCode None;  // const
        public static Beyond.Input.KeyboardKeyCode Backspace;  // const
        public static Beyond.Input.KeyboardKeyCode Tab;  // const
        public static Beyond.Input.KeyboardKeyCode Clear;  // const
        public static Beyond.Input.KeyboardKeyCode Return;  // const
        public static Beyond.Input.KeyboardKeyCode Pause;  // const
        public static Beyond.Input.KeyboardKeyCode EscapeOnly;  // const
        public static Beyond.Input.KeyboardKeyCode Space;  // const
        public static Beyond.Input.KeyboardKeyCode Exclaim;  // const
        public static Beyond.Input.KeyboardKeyCode DoubleQuote;  // const
        public static Beyond.Input.KeyboardKeyCode Hash;  // const
        public static Beyond.Input.KeyboardKeyCode Dollar;  // const
        public static Beyond.Input.KeyboardKeyCode Percent;  // const
        public static Beyond.Input.KeyboardKeyCode Ampersand;  // const
        public static Beyond.Input.KeyboardKeyCode Quote;  // const
        public static Beyond.Input.KeyboardKeyCode LeftParen;  // const
        public static Beyond.Input.KeyboardKeyCode RightParen;  // const
        public static Beyond.Input.KeyboardKeyCode Asterisk;  // const
        public static Beyond.Input.KeyboardKeyCode Plus;  // const
        public static Beyond.Input.KeyboardKeyCode Comma;  // const
        public static Beyond.Input.KeyboardKeyCode Minus;  // const
        public static Beyond.Input.KeyboardKeyCode Period;  // const
        public static Beyond.Input.KeyboardKeyCode Slash;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha0;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha1;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha2;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha3;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha4;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha5;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha6;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha7;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha8;  // const
        public static Beyond.Input.KeyboardKeyCode Alpha9;  // const
        public static Beyond.Input.KeyboardKeyCode Colon;  // const
        public static Beyond.Input.KeyboardKeyCode Semicolon;  // const
        public static Beyond.Input.KeyboardKeyCode Less;  // const
        public static Beyond.Input.KeyboardKeyCode Equals;  // const
        public static Beyond.Input.KeyboardKeyCode Greater;  // const
        public static Beyond.Input.KeyboardKeyCode Question;  // const
        public static Beyond.Input.KeyboardKeyCode At;  // const
        public static Beyond.Input.KeyboardKeyCode LeftBracket;  // const
        public static Beyond.Input.KeyboardKeyCode Backslash;  // const
        public static Beyond.Input.KeyboardKeyCode RightBracket;  // const
        public static Beyond.Input.KeyboardKeyCode Caret;  // const
        public static Beyond.Input.KeyboardKeyCode Underscore;  // const
        public static Beyond.Input.KeyboardKeyCode BackQuote;  // const
        public static Beyond.Input.KeyboardKeyCode A;  // const
        public static Beyond.Input.KeyboardKeyCode B;  // const
        public static Beyond.Input.KeyboardKeyCode C;  // const
        public static Beyond.Input.KeyboardKeyCode D;  // const
        public static Beyond.Input.KeyboardKeyCode E;  // const
        public static Beyond.Input.KeyboardKeyCode F;  // const
        public static Beyond.Input.KeyboardKeyCode G;  // const
        public static Beyond.Input.KeyboardKeyCode H;  // const
        public static Beyond.Input.KeyboardKeyCode I;  // const
        public static Beyond.Input.KeyboardKeyCode J;  // const
        public static Beyond.Input.KeyboardKeyCode K;  // const
        public static Beyond.Input.KeyboardKeyCode L;  // const
        public static Beyond.Input.KeyboardKeyCode M;  // const
        public static Beyond.Input.KeyboardKeyCode N;  // const
        public static Beyond.Input.KeyboardKeyCode O;  // const
        public static Beyond.Input.KeyboardKeyCode P;  // const
        public static Beyond.Input.KeyboardKeyCode Q;  // const
        public static Beyond.Input.KeyboardKeyCode R;  // const
        public static Beyond.Input.KeyboardKeyCode S;  // const
        public static Beyond.Input.KeyboardKeyCode T;  // const
        public static Beyond.Input.KeyboardKeyCode U;  // const
        public static Beyond.Input.KeyboardKeyCode V;  // const
        public static Beyond.Input.KeyboardKeyCode W;  // const
        public static Beyond.Input.KeyboardKeyCode X;  // const
        public static Beyond.Input.KeyboardKeyCode Y;  // const
        public static Beyond.Input.KeyboardKeyCode Z;  // const
        public static Beyond.Input.KeyboardKeyCode LeftCurlyBracket;  // const
        public static Beyond.Input.KeyboardKeyCode Pipe;  // const
        public static Beyond.Input.KeyboardKeyCode RightCurlyBracket;  // const
        public static Beyond.Input.KeyboardKeyCode Tilde;  // const
        public static Beyond.Input.KeyboardKeyCode Delete;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad0;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad1;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad2;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad3;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad4;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad5;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad6;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad7;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad8;  // const
        public static Beyond.Input.KeyboardKeyCode Keypad9;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadPeriod;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadDivide;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadMultiply;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadMinus;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadPlus;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadEnter;  // const
        public static Beyond.Input.KeyboardKeyCode KeypadEquals;  // const
        public static Beyond.Input.KeyboardKeyCode UpArrow;  // const
        public static Beyond.Input.KeyboardKeyCode DownArrow;  // const
        public static Beyond.Input.KeyboardKeyCode RightArrow;  // const
        public static Beyond.Input.KeyboardKeyCode LeftArrow;  // const
        public static Beyond.Input.KeyboardKeyCode Insert;  // const
        public static Beyond.Input.KeyboardKeyCode Home;  // const
        public static Beyond.Input.KeyboardKeyCode End;  // const
        public static Beyond.Input.KeyboardKeyCode PageUp;  // const
        public static Beyond.Input.KeyboardKeyCode PageDown;  // const
        public static Beyond.Input.KeyboardKeyCode F1;  // const
        public static Beyond.Input.KeyboardKeyCode F2;  // const
        public static Beyond.Input.KeyboardKeyCode F3;  // const
        public static Beyond.Input.KeyboardKeyCode F4;  // const
        public static Beyond.Input.KeyboardKeyCode F5;  // const
        public static Beyond.Input.KeyboardKeyCode F6;  // const
        public static Beyond.Input.KeyboardKeyCode F7;  // const
        public static Beyond.Input.KeyboardKeyCode F8;  // const
        public static Beyond.Input.KeyboardKeyCode F9;  // const
        public static Beyond.Input.KeyboardKeyCode F10;  // const
        public static Beyond.Input.KeyboardKeyCode F11;  // const
        public static Beyond.Input.KeyboardKeyCode F12;  // const
        public static Beyond.Input.KeyboardKeyCode F13;  // const
        public static Beyond.Input.KeyboardKeyCode F14;  // const
        public static Beyond.Input.KeyboardKeyCode F15;  // const
        public static Beyond.Input.KeyboardKeyCode Numlock;  // const
        public static Beyond.Input.KeyboardKeyCode CapsLock;  // const
        public static Beyond.Input.KeyboardKeyCode ScrollLock;  // const
        public static Beyond.Input.KeyboardKeyCode RightShift;  // const
        public static Beyond.Input.KeyboardKeyCode LeftShift;  // const
        public static Beyond.Input.KeyboardKeyCode RightControl;  // const
        public static Beyond.Input.KeyboardKeyCode LeftControl;  // const
        public static Beyond.Input.KeyboardKeyCode RightAlt;  // const
        public static Beyond.Input.KeyboardKeyCode LeftAlt;  // const
        public static Beyond.Input.KeyboardKeyCode RightApple;  // const
        public static Beyond.Input.KeyboardKeyCode RightCommand;  // const
        public static Beyond.Input.KeyboardKeyCode RightMeta;  // const
        public static Beyond.Input.KeyboardKeyCode LeftApple;  // const
        public static Beyond.Input.KeyboardKeyCode LeftCommand;  // const
        public static Beyond.Input.KeyboardKeyCode LeftMeta;  // const
        public static Beyond.Input.KeyboardKeyCode LeftWindows;  // const
        public static Beyond.Input.KeyboardKeyCode RightWindows;  // const
        public static Beyond.Input.KeyboardKeyCode AltGr;  // const
        public static Beyond.Input.KeyboardKeyCode Help;  // const
        public static Beyond.Input.KeyboardKeyCode Print;  // const
        public static Beyond.Input.KeyboardKeyCode SysReq;  // const
        public static Beyond.Input.KeyboardKeyCode Break;  // const
        public static Beyond.Input.KeyboardKeyCode Menu;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse0;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse1;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse2;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse3;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse4;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse5;  // const
        public static Beyond.Input.KeyboardKeyCode Mouse6;  // const
        public static Beyond.Input.KeyboardKeyCode EscapeWithRightMouse;  // const

    }

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct GamepadKeyCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.GamepadKeyCode None;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickX;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickY;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickBtn;  // const
        public static Beyond.Input.GamepadKeyCode RightStickX;  // const
        public static Beyond.Input.GamepadKeyCode RightStickY;  // const
        public static Beyond.Input.GamepadKeyCode RightStickBtn;  // const
        public static Beyond.Input.GamepadKeyCode ArrowUp;  // const
        public static Beyond.Input.GamepadKeyCode ArrowDown;  // const
        public static Beyond.Input.GamepadKeyCode ArrowLeft;  // const
        public static Beyond.Input.GamepadKeyCode ArrowRight;  // const
        public static Beyond.Input.GamepadKeyCode A;  // const
        public static Beyond.Input.GamepadKeyCode B;  // const
        public static Beyond.Input.GamepadKeyCode X;  // const
        public static Beyond.Input.GamepadKeyCode Y;  // const
        public static Beyond.Input.GamepadKeyCode LB;  // const
        public static Beyond.Input.GamepadKeyCode LT;  // const
        public static Beyond.Input.GamepadKeyCode RB;  // const
        public static Beyond.Input.GamepadKeyCode RT;  // const
        public static Beyond.Input.GamepadKeyCode LeftMenuBtn;  // const
        public static Beyond.Input.GamepadKeyCode RightMenuBtn;  // const
        public static Beyond.Input.GamepadKeyCode Home;  // const
        public static Beyond.Input.GamepadKeyCode TouchPanel;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickUp;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickDown;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickLeft;  // const
        public static Beyond.Input.GamepadKeyCode LeftStickRight;  // const
        public static Beyond.Input.GamepadKeyCode RightStickUp;  // const
        public static Beyond.Input.GamepadKeyCode RightStickDown;  // const
        public static Beyond.Input.GamepadKeyCode RightStickLeft;  // const
        public static Beyond.Input.GamepadKeyCode RightStickRight;  // const

    }

    // TypeToken: 0x2000010  // size: 0x14
    public sealed struct InputTimingType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.InputTimingType OnPress;  // const
        public static Beyond.Input.InputTimingType OnRelease;  // const
        public static Beyond.Input.InputTimingType OnClick;  // const
        public static Beyond.Input.InputTimingType OnLongPress;  // const

    }

    // TypeToken: 0x2000011  // size: 0x14
    public sealed struct InputContinuousTriggerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.InputContinuousTriggerType NormalDelayAndLoopTime;  // const
        public static Beyond.Input.InputContinuousTriggerType EveryTick;  // const

    }

    // TypeToken: 0x2000012  // size: 0x38
    public abstract class GamepadCheckerBase
    {
        // Fields
        protected Beyond.Input.InputManager m_inputManager;  // 0x10
        protected Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> m_normalBindingInfos;  // 0x18
        protected Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>>> m_modifyBindingInfos;  // 0x20
        protected System.Collections.Generic.HashSet<Beyond.Input.GamepadKeyCode> m_usedKeyCache;  // 0x28
        protected System.Collections.Generic.List<System.ValueTuple<Beyond.Input.GamepadCheckerBase.Binding,Beyond.Input.GamepadCheckerBase.TriggerType>> m_tmpNeedTriggerCallbacks;  // 0x30

        // Properties
        Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> normalBindingInfos { get; /* RVA: 0x088AC1C8 */ }
        Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>>> modifyBindingInfos { get; /* RVA: 0x088AC17C */ }

        // Methods
        // RVA: 0x037CAAD0  token: 0x600006B
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        // RVA: 0x02856930  token: 0x600006C
        public virtual Beyond.Input.GamepadCheckerBase.Binding OnCreateBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        // RVA: 0x02859010  token: 0x600006D
        public virtual Beyond.Input.GamepadCheckerBase.Binding OnDeleteBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x02856B10  token: 0x600006E
        protected Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> GetInputDic(Beyond.Input.GamepadInput input) { }
        // RVA: 0x088ABDD8  token: 0x600006F
        public virtual System.Void CheckGamepadInput() { }
        // RVA: 0x088ABD74  token: 0x6000070
        protected virtual System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        // RVA: 0x088ABF1C  token: 0x6000071
        public virtual System.Void TriggerActions() { }

    }

    // TypeToken: 0x2000015  // size: 0x48
    public class GamepadChecker : Beyond.Input.GamepadCheckerBase
    {
        // Fields
        private System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> m_checkFunc;  // 0x38
        private System.Boolean <isPressChecker>k__BackingField;  // 0x40

        // Properties
        System.Boolean isPressChecker { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }

        // Methods
        // RVA: 0x037CAA80  token: 0x6000075
        public System.Void .ctor(System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> checkFunc, System.Boolean isPress, Beyond.Input.InputManager inputManager) { }
        // RVA: 0x088AC214  token: 0x6000076
        protected virtual System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        // RVA: 0x088AC880  token: 0x6000077
        public System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }

    }

    // TypeToken: 0x2000016  // size: 0x38
    public class GamepadOnClickChecker : Beyond.Input.GamepadCheckerBase
    {
        // Methods
        // RVA: 0x088AD414  token: 0x6000078
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        // RVA: 0x088AC888  token: 0x6000079
        protected virtual System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        // RVA: 0x088ACFEC  token: 0x600007A
        public System.Void ClearKeyPressed(Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x088AC880  token: 0x600007B
        public System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }

    }

    // TypeToken: 0x2000017  // size: 0x48
    public class GamepadOnLongPressChecker : Beyond.Input.GamepadCheckerBase
    {
        // Fields
        private System.Action<Beyond.Input.GamepadKeyCode> m_onTriggerOnLongPress;  // 0x38
        private System.Collections.Generic.Dictionary<Beyond.Input.GamepadInput,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> m_bindings;  // 0x40

        // Methods
        // RVA: 0x037CA920  token: 0x600007C
        public System.Void .ctor(System.Action<Beyond.Input.GamepadKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) { }
        // RVA: 0x088ADB44  token: 0x600007D
        public System.Action CreateTriggerBindingAction(Beyond.Input.GamepadCheckerBase.Binding binding, Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x088AD41C  token: 0x600007E
        protected virtual System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        // RVA: 0x088ADE68  token: 0x600007F
        private System.Void _OnTriggerBinding(Beyond.Input.GamepadCheckerBase.Binding binding, Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x036F95D0  token: 0x6000080
        public virtual Beyond.Input.GamepadCheckerBase.Binding OnCreateBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        // RVA: 0x036F94F0  token: 0x6000081
        public virtual Beyond.Input.GamepadCheckerBase.Binding OnDeleteBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x088ADC44  token: 0x6000082
        public System.Single GetInputLongPressStartTime(Beyond.Input.GamepadInput input, System.Int32 bindingId) { }
        // RVA: 0x088AC880  token: 0x6000083
        public System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }
        // RVA: 0x088ADE50  token: 0x6000084
        public Beyond.Input.GamepadCheckerBase.Binding <>iFixBaseProxy_OnCreateBinding(Beyond.Input.GamepadInput P0, Beyond.Input.InputBindingInfo P1, System.Boolean P2) { }
        // RVA: 0x088ADE60  token: 0x6000085
        public Beyond.Input.GamepadCheckerBase.Binding <>iFixBaseProxy_OnDeleteBinding(Beyond.Input.GamepadInput P0, Beyond.Input.InputBindingInfo P1) { }

    }

    // TypeToken: 0x2000019  // size: 0x48
    public class GamepadOnReleaseChecker : Beyond.Input.GamepadCheckerBase
    {
        // Fields
        private readonly System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> m_checkFunc;  // 0x38
        private readonly System.Collections.Generic.Dictionary<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadKeyCode>> m_modifyBindingPressedDic;  // 0x40

        // Methods
        // RVA: 0x037CA9D0  token: 0x6000088
        public System.Void .ctor(System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> checkFunc, Beyond.Input.InputManager inputManager) { }
        // RVA: 0x088AE7B8  token: 0x6000089
        public virtual System.Void CheckGamepadInput() { }
        // RVA: 0x088AE12C  token: 0x600008A
        protected virtual System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        // RVA: 0x088AEE9C  token: 0x600008B
        private System.Boolean <CheckGamepadInput>b__3_0(Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x088AEEC4  token: 0x600008C
        public System.Void <>iFixBaseProxy_CheckGamepadInput() { }
        // RVA: 0x088AC880  token: 0x600008D
        public System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }

    }

    // TypeToken: 0x200001A  // size: 0x170
    public class HGVirtualMouse : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.Single STANDARD_SCREEN_WIDTH;  // const
        public System.Boolean keepMousePosOnEnable;  // 0x18
        private UnityEngine.RectTransform m_CursorTransform;  // 0x20
        private UnityEngine.Animator m_animator;  // 0x28
        public System.Single currentCursorSpeed;  // 0x30
        public System.Single currentCursorAcc;  // 0x34
        public System.Collections.Generic.List<Beyond.Input.HGVirtualMouse.CursorSpeedPhase> speedPhaseList;  // 0x38
        public System.Collections.Generic.List<Beyond.Input.HGVirtualMouse.CursorSpeedPhase> hoverSpeedPhaseList;  // 0x40
        public System.Collections.Generic.List<Beyond.Input.HGVirtualMouse.CursorSpeedPhase> secondHoverSpeedPhaseList;  // 0x48
        private System.Single m_ScrollSpeed;  // 0x50
        private UnityEngine.InputSystem.InputActionProperty m_StickAction;  // 0x58
        private UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;  // 0x70
        private UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;  // 0x88
        private UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;  // 0xa0
        private UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;  // 0xb8
        private UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;  // 0xd0
        private UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;  // 0xe8
        private UnityEngine.RectTransform _canvasTransform;  // 0x100
        private UnityEngine.InputSystem.Mouse m_VirtualMouse;  // 0x108
        private UnityEngine.InputSystem.Mouse m_SystemMouse;  // 0x110
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;  // 0x118
        private System.Double m_LastTime;  // 0x120
        private UnityEngine.Vector2 m_LastStickValue;  // 0x128
        private System.Single m_lastDisabledTime;  // 0x130
        private System.Single _resetCursorPosMinInterval;  // 0x134
        public System.Int32 leftBtnBindingGroupId;  // 0x138
        public System.Int32 leftBtnPressBindingId;  // 0x13c
        public System.Int32 leftBtnReleaseBindingId;  // 0x140
        private System.Collections.Generic.HashSet<UnityEngine.UI.Selectable> m_hoverTargets;  // 0x148
        private System.Boolean <isHoverOn>k__BackingField;  // 0x150
        private System.Boolean m_usingHoverSpd;  // 0x151
        private System.Int32 m_encounterHoverCount;  // 0x154
        private System.Single m_animatorHoverValue;  // 0x158
        private System.Boolean m_isIdle;  // 0x15c
        private System.Single _hoverAnimationChangeSpeed;  // 0x160
        private System.Boolean <mouseIconVisible>k__BackingField;  // 0x164
        private UnityEngine.CanvasGroup m_iconCanvasGroup;  // 0x168

        // Properties
        UnityEngine.RectTransform cursorTransform { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Single scrollSpeed { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x03D51CA0 */ }
        UnityEngine.InputSystem.Mouse virtualMouse { get; /* RVA: 0x03D56D30 */ }
        UnityEngine.InputSystem.InputActionProperty stickAction { get; /* RVA: 0x03D6DC30 */ set; /* RVA: 0x088B15C8 */ }
        UnityEngine.InputSystem.InputActionProperty leftButtonAction { get; /* RVA: 0x03D6DBC0 */ set; /* RVA: 0x088B1288 */ }
        UnityEngine.InputSystem.InputActionProperty rightButtonAction { get; /* RVA: 0x03D6DC10 */ set; /* RVA: 0x088B1490 */ }
        UnityEngine.InputSystem.InputActionProperty middleButtonAction { get; /* RVA: 0x03D6DBE0 */ set; /* RVA: 0x088B1388 */ }
        UnityEngine.InputSystem.InputActionProperty forwardButtonAction { get; /* RVA: 0x03D6DAF0 */ set; /* RVA: 0x088B1180 */ }
        UnityEngine.InputSystem.InputActionProperty backButtonAction { get; /* RVA: 0x03D697B0 */ set; /* RVA: 0x088B1078 */ }
        UnityEngine.InputSystem.InputActionProperty scrollWheelAction { get; /* RVA: 0x03D6B920 */ set; /* RVA: 0x088B1598 */ }
        System.Boolean isHoverOn { get; /* RVA: 0x03D56A80 */ set; /* RVA: 0x03D6CF10 */ }
        System.Boolean mouseIconVisible { get; /* RVA: 0x03D6DC00 */ set; /* RVA: 0x03D6DC50 */ }

        // Methods
        // RVA: 0x088AF91C  token: 0x60000A1
        protected System.Void OnEnable() { }
        // RVA: 0x088AF590  token: 0x60000A2
        protected System.Void OnDisable() { }
        // RVA: 0x088B097C  token: 0x60000A3
        private System.Void _UpdateMotion() { }
        // RVA: 0x088B040C  token: 0x60000A4
        private System.Void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        // RVA: 0x088B011C  token: 0x60000A5
        public System.Void TriggerLeftButton(System.Boolean isPressed) { }
        // RVA: 0x088AF198  token: 0x60000A6
        public System.Void ClearLeftButtonState() { }
        // RVA: 0x088B062C  token: 0x60000A7
        private static System.Void _SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install) { }
        // RVA: 0x088B06F0  token: 0x60000A8
        private static System.Void _SetAction(UnityEngine.InputSystem.InputActionProperty& field, UnityEngine.InputSystem.InputActionProperty value) { }
        // RVA: 0x088AF418  token: 0x60000A9
        public System.Void OnAfterInputUpdate() { }
        // RVA: 0x088B0264  token: 0x60000AC
        private System.Void Update() { }
        // RVA: 0x088AEF58  token: 0x60000AD
        public System.Void ChangeHoverState(UnityEngine.UI.Selectable target, System.Boolean isHoverOn) { }
        // RVA: 0x088B0394  token: 0x60000AE
        private System.Void _ChangeHoverState(System.Boolean isHoverOn) { }
        // RVA: 0x088AF288  token: 0x60000AF
        public UnityEngine.UI.Selectable GetCurHoverSelectable() { }
        // RVA: 0x088AF468  token: 0x60000B0
        private System.Void OnDestroy() { }
        // RVA: 0x088B0844  token: 0x60000B1
        private System.Void _SyncScale() { }
        // RVA: 0x088AEECC  token: 0x60000B4
        private System.Void Awake() { }
        // RVA: 0x088B00A0  token: 0x60000B5
        public System.Void SetMouseIconVisible(System.Boolean active) { }
        // RVA: 0x0398A6C0  token: 0x60000B6
        public System.Void .ctor() { }
        // RVA: 0x088B024C  token: 0x60000B7
        private System.Void <OnEnable>b__32_0() { }
        // RVA: 0x088B0258  token: 0x60000B8
        private System.Void <OnEnable>b__32_1() { }

    }

    // TypeToken: 0x200001D  // size: 0x60
    public class InputBindingInfo
    {
        // Fields
        private static System.UInt32 s_nextEnabledPriority;  // static @ 0x0
        private readonly System.Int32 <id>k__BackingField;  // 0x10
        private System.Action m_callback;  // 0x18
        private Beyond.Input.InputBindingGroup <group>k__BackingField;  // 0x20
        public System.String playerActionId;  // 0x28
        private System.Boolean <shouldShowControllerHint>k__BackingField;  // 0x30
        private System.Int32 <controllerHintPriority>k__BackingField;  // 0x34
        private System.Boolean <isCommonOpenUIAction>k__BackingField;  // 0x38
        private System.Boolean <selfEnabled>k__BackingField;  // 0x39
        private System.Boolean <groupEnabled>k__BackingField;  // 0x3a
        private System.Boolean <parentIgnored>k__BackingField;  // 0x3b
        public System.Boolean forceKeyhintToGrayState;  // 0x3c
        private System.UInt32 <enabledPriority>k__BackingField;  // 0x40
        private System.Int32 <actionPriority>k__BackingField;  // 0x44
        private Beyond.Input.IBindingView m_bindingView;  // 0x48
        private System.String m_text;  // 0x50
        public static System.Single s_continuousTriggerFirstDelayTime;  // static @ 0x4
        public static System.Single s_continuousTriggerLoopDelayTime;  // static @ 0x8
        public static System.Single s_continuousTriggerLoopQuickDelayTime;  // static @ 0xc
        private System.Int32 m_continuousTriggerTimerId;  // 0x58

        // Properties
        System.Int32 id { get; /* RVA: 0x03D4E340 */ }
        Beyond.Input.InputBindingGroup group { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Boolean shouldShowControllerHint { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }
        System.Int32 controllerHintPriority { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x03D4EE40 */ }
        System.Boolean isCommonOpenUIAction { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Boolean selfEnabled { get; /* RVA: 0x03D4F300 */ set; /* RVA: 0x03D4F330 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x03D4F500 */ set; /* RVA: 0x03D4F530 */ }
        System.Boolean enabled { get; /* RVA: 0x024AEA80 */ }
        System.Boolean parentIgnored { get; /* RVA: 0x03D4F510 */ set; /* RVA: 0x03D4F540 */ }
        System.UInt32 enabledPriority { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x03D4EDB0 */ }
        System.Int32 actionPriority { get; /* RVA: 0x03D4EE80 */ set; /* RVA: 0x03D4EEA0 */ }
        Beyond.Input.IBindingView bindingView { get; /* RVA: 0x02BDFF00 */ set; /* RVA: 0x02692290 */ }
        System.String text { get; /* RVA: 0x02BDFE40 */ set; /* RVA: 0x02C926C0 */ }

        // Methods
        // RVA: 0x028571E0  token: 0x60000BD
        private static System.UInt32 _GetNextEnabledPriority() { }
        // RVA: 0x028570F0  token: 0x60000D6
        public System.Void .ctor(System.Int32 id, Beyond.Input.InputBindingGroup group, System.Action callback, System.String playerActionId, Beyond.Input.PlayerActionInfo actionInfo) { }
        // RVA: 0x088B1664  token: 0x60000D7
        public System.Void ChangeGroup(Beyond.Input.InputBindingGroup newGroup) { }
        // RVA: 0x02C6EFB0  token: 0x60000D8
        public System.Void SetSelfEnabled(System.Boolean value) { }
        // RVA: 0x02858A20  token: 0x60000D9
        public System.Void OnGroupEnabledChanged(System.Boolean value) { }
        // RVA: 0x088B173C  token: 0x60000DA
        public System.Void SetParentIgnored(System.Boolean value) { }
        // RVA: 0x0362B660  token: 0x60000DB
        public System.Void Trigger() { }
        // RVA: 0x088B1798  token: 0x60000DC
        public System.Void StartContinuousTrigger(Beyond.Input.InputContinuousTriggerType continuousTriggerType) { }
        // RVA: 0x088B1C24  token: 0x60000DD
        private System.Void _TryContinuousTrigger() { }
        // RVA: 0x02858AC0  token: 0x60000DE
        public System.Void StopContinuousTrigger() { }
        // RVA: 0x0362B6A0  token: 0x60000DF
        private System.Void _RealTriggerCallback() { }
        // RVA: 0x02859430  token: 0x60000E0
        public System.Void OnDelete() { }
        // RVA: 0x088B16E4  token: 0x60000E1
        public System.Object GetCallbackTarget() { }
        // RVA: 0x03D045C0  token: 0x60000E2
        private static System.Void .cctor() { }
        // RVA: 0x088B1944  token: 0x60000E3
        private System.Void <StartContinuousTrigger>b__64_0() { }
        // RVA: 0x088B1A38  token: 0x60000E4
        private System.Void <StartContinuousTrigger>b__64_1() { }
        // RVA: 0x088B1B2C  token: 0x60000E5
        private System.Void <StartContinuousTrigger>b__64_2() { }

    }

    // TypeToken: 0x200001E  // size: 0x38
    public class InputBindingGroup
    {
        // Fields
        private readonly System.Int32 <id>k__BackingField;  // 0x10
        private System.Boolean <selfEnabled>k__BackingField;  // 0x14
        private System.Boolean <parentEnabled>k__BackingField;  // 0x15
        private System.Boolean <parentIgnored>k__BackingField;  // 0x16
        private Beyond.Input.InputBindingGroup <parent>k__BackingField;  // 0x18
        private readonly System.Collections.Generic.LinkedList<Beyond.Input.InputBindingGroup> <subGroups>k__BackingField;  // 0x20
        private readonly System.Collections.Generic.LinkedList<Beyond.Input.InputBindingInfo> <subInfos>k__BackingField;  // 0x28
        private Beyond.Input.IBindingView m_groupView;  // 0x30

        // Properties
        System.Int32 id { get; /* RVA: 0x03D4E340 */ }
        System.Boolean selfEnabled { get; /* RVA: 0x03D58C00 */ set; /* RVA: 0x03D58C20 */ }
        System.Boolean parentEnabled { get; /* RVA: 0x03D58C10 */ set; /* RVA: 0x03D58C30 */ }
        System.Boolean enabled { get; /* RVA: 0x024B2740 */ }
        System.Boolean parentIgnored { get; /* RVA: 0x03D6DC60 */ set; /* RVA: 0x03D6DC70 */ }
        Beyond.Input.InputBindingGroup parent { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Collections.Generic.LinkedList<Beyond.Input.InputBindingGroup> subGroups { get; /* RVA: 0x03D4EB40 */ }
        System.Collections.Generic.LinkedList<Beyond.Input.InputBindingInfo> subInfos { get; /* RVA: 0x03D4EAC0 */ }
        Beyond.Input.IBindingView groupView { get; /* RVA: 0x02BDFF80 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x022B0460  token: 0x60000F4
        public System.Void .ctor(System.Int32 id, Beyond.Input.InputBindingGroup parent) { }
        // RVA: 0x03610B10  token: 0x60000F5
        public System.Void ChangeParent(Beyond.Input.InputBindingGroup newParent) { }
        // RVA: 0x02858400  token: 0x60000F6
        public System.Void SetSelfEnabled(System.Boolean value) { }
        // RVA: 0x088B15F8  token: 0x60000F7
        public System.Void SetParentIgnored(System.Boolean value) { }
        // RVA: 0x02858980  token: 0x60000F8
        public System.Void OnParentEnabledChanged(System.Boolean value) { }
        // RVA: 0x02858490  token: 0x60000F9
        private System.Void _OnBindingGroupStateChanged() { }

    }

    // TypeToken: 0x200001F  // size: 0x28
    public class InputBindingGroupMonoTarget : UnityEngine.MonoBehaviour, Beyond.Input.IBindingGroupTarget
    {
        // Fields
        private System.Int32 m_groupId;  // 0x18
        private System.Boolean m_init;  // 0x1c
        private System.Boolean m_internalEnabled;  // 0x1d
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;  // 0x20

        // Properties
        System.Int32 groupId { get; /* RVA: 0x02C70B10 */ }
        System.Boolean groupEnabled { get; /* RVA: 0x037260D0 */ }
        Beyond.Input.InputBindingGroupMonoTarget parent { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D4EB40 */ }
        System.Boolean internalEnabled { get; /* RVA: 0x03D50D90 */ set; /* RVA: 0x02C70F60 */ }

        // Methods
        // RVA: 0x02C70B30  token: 0x6000101
        public System.Void Init() { }
        // RVA: 0x02C70F70  token: 0x6000102
        public System.Void UpdateState() { }
        // RVA: 0x02C70940  token: 0x6000103
        public System.Void DeleteGroup() { }
        // RVA: 0x02C70AD0  token: 0x6000104
        private System.Void Awake() { }
        // RVA: 0x02C70DF0  token: 0x6000105
        private System.Void OnEnable() { }
        // RVA: 0x02C70DB0  token: 0x6000106
        private System.Void OnDisable() { }
        // RVA: 0x03854A20  token: 0x6000107
        private System.Void OnDestroy() { }
        // RVA: 0x03628080  token: 0x6000108
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public interface IBindingGroupTarget
    {
        // Properties
        System.Int32 groupId { get; /* RVA: -1  // abstract */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: -1  // abstract */ }
        System.Boolean groupEnabled { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000021
    public interface IBindingTarget
    {
        // Properties
        System.Int32 bindingId { get; /* RVA: -1  // abstract */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: -1  // abstract */ }
        System.Boolean bindingEnabled { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000022  // size: 0x14
    public sealed struct BindingViewState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.BindingViewState Normal;  // const
        public static Beyond.Input.BindingViewState Disabled;  // const
        public static Beyond.Input.BindingViewState Hide;  // const

    }

    // TypeToken: 0x2000023  // size: 0x14
    public sealed struct BindingViewActionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.BindingViewActionType Default;  // const
        public static Beyond.Input.BindingViewActionType ButtonClick;  // const
        public static Beyond.Input.BindingViewActionType ButtonLongPress;  // const
        public static Beyond.Input.BindingViewActionType ButtonPressStart;  // const
        public static Beyond.Input.BindingViewActionType ButtonPressEnd;  // const
        public static Beyond.Input.BindingViewActionType ButtonDoubleClick;  // const
        public static Beyond.Input.BindingViewActionType SliderAdd;  // const
        public static Beyond.Input.BindingViewActionType SliderReduce;  // const
        public static Beyond.Input.BindingViewActionType SliderStick;  // const

    }

    // TypeToken: 0x2000024
    public interface IBindingView
    {
        // Properties
        System.String bindingViewActionId { get; /* RVA: -1  // abstract */ }
        System.String bindingViewLabelText { get; /* RVA: -1  // abstract */ }
        Beyond.DisposedUnityEvent bindingViewUpdateEvent { get; /* RVA: -1  // abstract */ }
        System.Boolean interactable { get; /* RVA: -1  // abstract */ }
        UnityEngine.RectTransform redDotTrans { get; /* RVA: -1  // abstract */ }
        System.Boolean bindingEnabled { get; /* RVA: -1  // abstract */ }
        Beyond.Input.BindingViewState bindingViewState { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000116
        public virtual System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        // RVA: -1  // abstract  token: 0x6000117
        public virtual System.Void OnInputKeyDown(System.Boolean isActionTrigger) { }
        // RVA: -1  // abstract  token: 0x6000118
        public virtual System.Void OnInputKeyUp(System.Boolean isActionTrigger) { }

    }

    // TypeToken: 0x2000025  // size: 0x14
    public sealed struct InputSettingLevel
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Input.InputSettingLevel Default;  // const
        public static Beyond.Input.InputSettingLevel Custom;  // const
        public static Beyond.Input.InputSettingLevel Pending;  // const

    }

    // TypeToken: 0x2000026  // size: 0x1B0
    public class InputManager : Beyond.Singleton`1, System.IDisposable
    {
        // Fields
        public static System.Single s_longPressTime;  // static @ 0x0
        private static System.Collections.Generic.Dictionary<Beyond.Input.KeyboardKeyCode,System.String> s_keyboardKeyCode2StringDict;  // static @ 0x8
        private static System.Collections.Generic.Dictionary<Beyond.Input.GamepadKeyCode,System.String> s_gamepadKeyCode2StringDict;  // static @ 0x10
        public System.Boolean enableController;  // 0x10
        public System.Boolean enableMarketingCamera;  // 0x11
        private System.Int32 m_nextInputId;  // 0x14
        private System.Int32 m_nextGroupId;  // 0x18
        private Beyond.Input.InputBindingGroup m_rootGroup;  // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.Input.InputBindingGroup> m_groups;  // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.Input.InputBindingInfo> m_bindingInfos;  // 0x30
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.Int32>> m_action2BindingDic;  // 0x38
        private Beyond.Input.KeyboardChecker m_onPressKeyboardChecker;  // 0x40
        private Beyond.Input.KeyboardChecker m_onReleaseKeyboardChecker;  // 0x48
        private Beyond.Input.KeyboardOnClickChecker m_onClickKeyboardChecker;  // 0x50
        private Beyond.Input.KeyboardOnLongPressChecker m_onLongPressKeyboardChecker;  // 0x58
        private Beyond.Input.GamepadChecker m_onPressGamepadChecker;  // 0x60
        private Beyond.Input.GamepadOnReleaseChecker m_onReleaseGamepadChecker;  // 0x68
        private Beyond.Input.GamepadOnClickChecker m_onClickGamepadChecker;  // 0x70
        private Beyond.Input.GamepadOnLongPressChecker m_onLongPressGamepadChecker;  // 0x78
        private Beyond.Input.RealCursorManager m_realCursorManager;  // 0x80
        public static Beyond.MultiAction<Rewired.Joystick,Beyond.DeviceInfo.ControllerType> onJoystickChanged;  // static @ 0x18
        private Rewired.Joystick <joystick>k__BackingField;  // 0x88
        private Rewired.IGamepadTemplate <gamepadTemplate>k__BackingField;  // 0x90
        private Rewired.ControllerExtensions.IDualShock4Extension <gamepadDualShock4Extension>k__BackingField;  // 0x98
        private System.Int32 m_touchPanelBtnIndex;  // 0xa0
        private System.Int32 m_leftMenuBtnIndex;  // 0xa4
        private Beyond.Input.InputManager.KeyCaches m_keyCaches;  // 0xa8
        private Beyond.TickFunction m_lateTickFunction;  // 0xb0
        public Beyond.MultiAction onInputLateTick;  // 0xb8
        public System.Action beforeCheckInput;  // 0xc0
        public System.Action afterCheckInput;  // 0xc8
        public System.Boolean trimNonTargetInputChecks;  // 0xd0
        public System.Boolean commonOpenUIActionTriggered;  // 0xd1
        private static System.Boolean s_isNonSupportPsController;  // static @ 0x20
        public System.Boolean needProcessTryChange;  // 0xd2
        public System.Boolean disableChangeInputDeviceCheck;  // 0xd3
        private System.Boolean <inChangingInputDevice>k__BackingField;  // 0xd4
        private System.Boolean m_lastAnyOtherDeviceKey;  // 0xd5
        private System.Int32 m_controllerForbidClickBindingId;  // 0xd8
        private System.Boolean m_ignoreFirstMouseUpOnFocusBack;  // 0xdc
        private static readonly Beyond.Input.KeyboardKeyCode[] S_CACHED_KEYBOARD_KEY_CODES;  // static @ 0x28
        private System.Boolean m_hasFocusedInputFiled;  // 0xdd
        private static System.Single STICK_DEAD_ZONE_MAGNITUDE;  // const
        private static System.Single STICK_MIN_VALUE;  // const
        private static System.Single STICK_DEAD_ZONE_SQRT_MAGNITUDE;  // const
        private Beyond.Resource.IAssetLoader m_assetLoader;  // 0xe0
        private Beyond.SerializeFieldDictionary<System.String,Beyond.Input.PlayerActionInfo> m_defaultSetting;  // 0xe8
        private Beyond.SerializeFieldDictionary<System.String,Beyond.Input.PlayerActionInfo> m_customSetting;  // 0xf0
        private Beyond.SerializeFieldDictionary<System.String,Beyond.Input.PlayerActionInfo> m_pendingSetting;  // 0xf8
        private Beyond.Input.InputRebindConfig m_rebindConfig;  // 0x100
        private System.Collections.Generic.Dictionary<System.String,Beyond.Input.InputRebindActionScopeConfig> m_rebindActionScopeConfigs;  // 0x108
        private System.Collections.Generic.Dictionary<System.String,Beyond.Input.PlayerActionInfo> m_anonymousActionInfos;  // 0x110
        private System.Int32 m_nextAnonymousPlayerActionId;  // 0x118
        private static System.String INPUT_MANAGER_CANVAS_PREFAB_PATH;  // const
        private Beyond.Input.HGVirtualMouse <virtualMouse>k__BackingField;  // 0x120
        private UnityEngine.InputSystem.UI.DebugVirtualMouseInput <debugVirtualMouse>k__BackingField;  // 0x128
        private UnityEngine.Transform <canvasRoot>k__BackingField;  // 0x130
        private UnityEngine.Transform <controllerMask>k__BackingField;  // 0x138
        private System.Boolean <usingVirtualMouse>k__BackingField;  // 0x140
        private System.Int32 m_virtualMouseBindingGroupId;  // 0x144
        private UnityEngine.Transform <customControllerMouseTrans>k__BackingField;  // 0x148
        private UnityEngine.Camera <customControllerMouseUICamera>k__BackingField;  // 0x150
        private System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo> m_tmpControllerHintInfoList;  // 0x158
        private static Beyond.Input.GamepadKeyCode s_controllerIndicatorKey;  // static @ 0x30
        private static readonly Beyond.Input.GamepadKeyCode[] s_skillGamepadKeyCodes;  // static @ 0x38
        public static Beyond.Input.GamepadKeyCode s_comboSkillButtonKey;  // static @ 0x40
        private static Beyond.Input.GamepadKeyCode s_attackButtonKey;  // static @ 0x44
        private System.Single m_skillIndicatorPressTime;  // 0x160
        private System.Int32 m_skillIndicatorReleaseFrame;  // 0x164
        private readonly Beyond.Input.InputManager.SkillButtonState[] m_lastFrameSkillButtonStates;  // 0x168
        private static Unity.Profiling.ProfilerMarker s_updateControllerIndicatorMarker;  // static @ 0x48
        public readonly System.Collections.Generic.HashSet<System.String> guideUseActionIds;  // 0x170
        private static System.Single DEFAULT_VIBRATE_LEVEL;  // const
        private static System.Text.RegularExpressions.Regex s_actIdRegex;  // static @ 0x50
        private static System.String TEXT_SPRITE_FORMAT;  // const
        private static System.Single TEXT_SPRITE_SCALE;  // const
        public static System.String LONG_PRESS_KEY_ICON_POSTFIX;  // const
        private static System.String KEY_HINT_ICON_COMMON_FOLDER;  // const
        private static System.String KEYBOARD_KEY_HINT_ICON_PATH;  // const
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_PS5;  // const
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_PS4;  // const
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_XBOX;  // const
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_FALLBACK;  // const
        public static System.String s_virtualMouseClickHintActionId;  // static @ 0x58
        public static System.String s_virtualMouseLongPressHintActionId;  // static @ 0x60
        public Beyond.MultiAction<UnityEngine.Vector2> onStartSwipeTouchPanel;  // 0x178
        public Beyond.MultiAction<UnityEngine.Vector2,UnityEngine.Vector2> onSwipeTouchPanel;  // 0x180
        public Beyond.MultiAction onEndSwipeTouchPanel;  // 0x188
        private System.Boolean <isSwipingTouchPanel>k__BackingField;  // 0x190
        private UnityEngine.Vector2 m_lastTouchPanelPos;  // 0x194
        public Beyond.Input.ControllerNaviManager controllerNaviManager;  // 0x1a0
        public System.Boolean disableCheckInputForNetMask;  // 0x1a8

        // Properties
        System.Boolean inHideCursorMode { get; /* RVA: 0x03334EB0 */ }
        System.Boolean needShowCursor { get; /* RVA: 0x024AFD10 */ }
        System.Boolean cursorVisible { get; /* RVA: 0x024ADFC0 */ }
        System.Boolean anyKeyDown { get; /* RVA: 0x02851290 */ }
        UnityEngine.Vector2 mouseScrollDelta { get; /* RVA: 0x02850010 */ }
        System.Boolean multiTouchEnabled { get; /* RVA: 0x022B4420 */ set; /* RVA: 0x0382CBD0 */ }
        System.Boolean usingController { get; /* RVA: 0x024AFD40 */ set; /* RVA: 0x088A823C */ }
        System.Boolean virtualMouseIconVisible { get; /* RVA: 0x088A820C */ }
        System.Int32 invalidID { get; /* RVA: 0x01002730 */ }
        Rewired.Joystick joystick { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x04274DA0 */ }
        Rewired.IGamepadTemplate gamepadTemplate { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x051DFCB4 */ }
        Rewired.ControllerExtensions.IDualShock4Extension gamepadDualShock4Extension { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x051417AC */ }
        System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.Int32>> action2BindingDic { get; /* RVA: 0x029E2D20 */ }
        System.Int32 rootGroupId { get; /* RVA: 0x088A81F0 */ }
        System.Boolean isNonSupportPsController { get; /* RVA: 0x088A81A0 */ }
        System.Boolean inChangingInputDevice { get; /* RVA: 0x03D6D690 */ set; /* RVA: 0x03D6DB30 */ }
        Beyond.Input.HGVirtualMouse virtualMouse { get; /* RVA: 0x03D56D50 */ set; /* RVA: 0x04275CA4 */ }
        UnityEngine.InputSystem.UI.DebugVirtualMouseInput debugVirtualMouse { get; /* RVA: 0x03D56F00 */ set; /* RVA: 0x04275CB8 */ }
        UnityEngine.Transform canvasRoot { get; /* RVA: 0x03D56D00 */ set; /* RVA: 0x04275CCC */ }
        UnityEngine.Transform controllerMask { get; /* RVA: 0x03D56EF0 */ set; /* RVA: 0x04275CE0 */ }
        System.Boolean usingVirtualMouse { get; /* RVA: 0x03D576E0 */ set; /* RVA: 0x03D576F0 */ }
        UnityEngine.Vector3 mousePosition { get; /* RVA: 0x0284FE00 */ }
        UnityEngine.Transform customControllerMouseTrans { get; /* RVA: 0x03D571B0 */ set; /* RVA: 0x058B3DA8 */ }
        UnityEngine.Camera customControllerMouseUICamera { get; /* RVA: 0x03D57200 */ set; /* RVA: 0x058B3DD0 */ }
        System.Boolean isSwipingTouchPanel { get; /* RVA: 0x03D57C30 */ set; /* RVA: 0x03D5A070 */ }

        // Methods
        // RVA: 0x038278F0  token: 0x600012C
        private System.Void .ctor() { }
        // RVA: 0x0297A6F0  token: 0x600012D
        public System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x02973B20  token: 0x600012E
        private System.Void _Init() { }
        // RVA: 0x088A4F98  token: 0x600012F
        public System.Void Release() { }
        // RVA: 0x088A6690  token: 0x6000130
        private System.Void _ClearTickFunction() { }
        // RVA: 0x088A4F48  token: 0x6000131
        public System.Void OnApplicationQuit() { }
        // RVA: 0x088A6414  token: 0x6000132
        private System.Void _ClearEvents() { }
        // RVA: 0x028530F0  token: 0x6000133
        private System.Void _OnAfterInputUpdate() { }
        // RVA: 0x088A783C  token: 0x6000134
        private System.Void _OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x088A7994  token: 0x6000135
        private System.Void _OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x03A29D60  token: 0x6000136
        private System.Void _TryFindGamepad() { }
        // RVA: 0x088A7A24  token: 0x6000137
        private System.Void _SetJoystick(Rewired.Joystick js) { }
        // RVA: 0x02852DA0  token: 0x6000138
        private System.Void _CheckInput() { }
        // RVA: 0x088A7214  token: 0x600013A
        private Beyond.DeviceInfo.ControllerType _GetControllerType(Rewired.Joystick js) { }
        // RVA: 0x029A6F30  token: 0x600013B
        public System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        // RVA: 0x03A90AE0  token: 0x600013E
        private System.Void _InitDeviceChangeBinding() { }
        // RVA: 0x02CAA210  token: 0x600013F
        private System.Void _RefreshDeviceChangeBinding() { }
        // RVA: 0x028519C0  token: 0x6000140
        public System.Void CheckUsingController() { }
        // RVA: 0x088A63BC  token: 0x6000141
        private System.Boolean _CheckAnyKeyForTouchChangeDevice() { }
        // RVA: 0x088A613C  token: 0x6000142
        private System.Boolean _CheckAnyKeyForKeyboardChangeDevice() { }
        // RVA: 0x088A5FB8  token: 0x6000143
        private System.Boolean _AnyKeyDownForKeyboardChangeDevice() { }
        // RVA: 0x088A8050  token: 0x6000144
        private System.Void _TryChangeInputDeviceType(Beyond.DeviceInfo.InputType inputType) { }
        // RVA: 0x02CAA370  token: 0x6000145
        private System.Void _SyncUsingControllerState() { }
        // RVA: 0x088A5C78  token: 0x6000146
        public System.Void ToggleInputDeviceChangeMode(System.Boolean inChanging) { }
        // RVA: 0x088A59D8  token: 0x6000147
        public System.Void ToggleForceShowRealCursor(System.Boolean forceShow) { }
        // RVA: 0x088A2430  token: 0x6000148
        public System.Void ChangeInputTypeAndSyncState(Beyond.DeviceInfo.InputType inputType) { }
        // RVA: 0x03D444E0  token: 0x6000149
        private System.Void _OnFocusedInputFieldChanged(Beyond.EventData<System.Boolean>& v) { }
        // RVA: 0x0348A070  token: 0x600014A
        private System.Void _CreateTickFunction() { }
        // RVA: 0x02858D80  token: 0x600014B
        private System.Void _RemovePlayerActionCheck(Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x028565E0  token: 0x600014C
        private System.Void _AddPlayerActionCheck(Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x028566B0  token: 0x600014D
        private System.Void _AddPlayerActionCheck(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x028567D0  token: 0x600014E
        private System.Void _AddPlayerActionCheck(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x02858E50  token: 0x600014F
        private System.Void _RemovePlayerActionCheck(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x02858F00  token: 0x6000150
        private System.Void _RemovePlayerActionCheck(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x0362B4E0  token: 0x6000151
        public System.Boolean GetKey(Beyond.Input.KeyboardKeyCode keyCode) { }
        // RVA: 0x088A4630  token: 0x6000152
        public System.Boolean GetKeyOrDown(Beyond.Input.KeyboardKeyCode keyCode) { }
        // RVA: 0x02853B30  token: 0x6000153
        public System.Boolean GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode) { }
        // RVA: 0x02853BB0  token: 0x6000154
        public System.Boolean GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode) { }
        // RVA: 0x088A42BC  token: 0x6000155
        public UnityEngine.Vector2 GetGamepadStickValue(System.Boolean isLeft, System.Boolean checkDeadZone) { }
        // RVA: 0x088A2684  token: 0x6000156
        public static System.Boolean CheckGamepadStickInDeadZone(UnityEngine.Vector2 stickValue) { }
        // RVA: 0x088A266C  token: 0x6000157
        public static System.Boolean CheckGamepadStickInDeadZone(System.Single stickAxisValue) { }
        // RVA: 0x088A43D0  token: 0x6000158
        public System.Single GetGamepadTriggerValue(System.Boolean isLeft) { }
        // RVA: 0x088A4674  token: 0x6000159
        public System.Boolean GetKey(Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x088A4514  token: 0x600015A
        public System.Boolean GetKeyDown(Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x088A4664  token: 0x600015B
        public System.Boolean GetKeyUp(Beyond.Input.GamepadKeyCode keyCode) { }
        // RVA: 0x088A2140  token: 0x600015C
        public System.Boolean AnyKeyboardKey(System.String[] actionScopes, Beyond.Input.KeyboardKeyCode& keyCode, System.Boolean& isBlackList) { }
        // RVA: 0x088A6088  token: 0x600015D
        private System.Boolean _AnyKeyboardKey(Beyond.Input.KeyboardKeyCode[] keyCodes, Beyond.Input.KeyboardKeyCode& keyCode) { }
        // RVA: 0x02851B00  token: 0x600015E
        public System.Boolean AnyGamepadKey() { }
        // RVA: 0x02852330  token: 0x600015F
        public System.Boolean AnyMouseKeyDown() { }
        // RVA: 0x088A23B0  token: 0x6000160
        public System.Boolean AnyMouseKey() { }
        // RVA: 0x088A2330  token: 0x6000161
        public System.Boolean AnyMouseKeyUp() { }
        // RVA: 0x028512E0  token: 0x6000162
        public static System.Boolean AnyKeyDown() { }
        // RVA: 0x024ADEA0  token: 0x6000163
        private System.Boolean _CheckGamepadKeyCode(Beyond.Input.GamepadKeyCode keyCode, Beyond.Input.InputManager.KeyCodeState state) { }
        // RVA: 0x088A27A8  token: 0x6000164
        public System.Int32 CreateBinding(Beyond.Input.PlayerActionInfo actionInfo, System.Action callback, System.Int32 groupId, System.String& actionId) { }
        // RVA: 0x02C6D680  token: 0x6000165
        public System.Int32 CreateBinding(System.String actionId, System.Action callback, System.Int32 groupId) { }
        // RVA: 0x088A2860  token: 0x6000166
        public System.Int32 CreateBinding(Beyond.Input.KeyboardKeyCode key, System.String modifyKeys, Beyond.Input.InputTimingType timing, System.Action callback, System.Int32 groupId) { }
        // RVA: 0x02856D10  token: 0x6000167
        public System.Int32 CreateBindingByActionId(System.String actionId, System.Action callback, System.Int32 groupId) { }
        // RVA: 0x0304DC80  token: 0x6000168
        public System.Void DeleteBinding(System.Int32 id) { }
        // RVA: 0x02C6EF00  token: 0x6000169
        public System.Void ToggleBinding(System.Int32 id, System.Boolean active) { }
        // RVA: 0x022B02E0  token: 0x600016A
        public System.Int32 CreateGroup(System.Int32 parentGroupId) { }
        // RVA: 0x02C721F0  token: 0x600016B
        public System.Void DeleteGroup(System.Int32 id) { }
        // RVA: 0x03650B50  token: 0x600016C
        public System.Void DeleteInGroup(System.Int32 groupId) { }
        // RVA: 0x024B2550  token: 0x600016D
        public System.Void ToggleGroup(System.Int32 id, System.Boolean active) { }
        // RVA: 0x024AE5D0  token: 0x600016E
        public System.Boolean IsBindingEnabled(System.Int32 id, System.Boolean needLogError) { }
        // RVA: 0x088A36E8  token: 0x600016F
        public System.Void ForceBindingKeyhintToGray(System.Int32 id, System.Boolean grayState) { }
        // RVA: 0x088A4B7C  token: 0x6000170
        public System.Boolean IsBindingKeyhintGray(System.Int32 id) { }
        // RVA: 0x024B2350  token: 0x6000171
        public System.Boolean IsGroupEnabled(System.Int32 id) { }
        // RVA: 0x088A5C10  token: 0x6000172
        public System.Void ToggleHideCursor() { }
        // RVA: 0x03D1E960  token: 0x6000173
        public System.Void ResetCursorInHideCursorMode() { }
        // RVA: 0x029A7100  token: 0x6000174
        public System.Void ToggleCursorInHideCursorMode(System.String key, System.Boolean showCursor) { }
        // RVA: 0x02D7ABD0  token: 0x6000175
        public System.Void ToggleAllInput(System.Boolean active) { }
        // RVA: 0x088A5624  token: 0x6000176
        public System.Void SetBindingView(System.Int32 bindingId, Beyond.Input.IBindingView bindingView) { }
        // RVA: 0x02A73CE0  token: 0x6000177
        public System.Void SetGroupView(System.Int32 groupId, Beyond.Input.IBindingView groupView) { }
        // RVA: 0x03610970  token: 0x6000178
        public System.Void ChangeParent(System.Boolean isGroup, System.Int32 id, System.Int32 newParentGroupId) { }
        // RVA: 0x03610890  token: 0x6000179
        public System.Int32 GetGroupParentId(System.Boolean isGroup, System.Int32 id) { }
        // RVA: 0x088A49F4  token: 0x600017A
        public System.Void IgnoreBindingGroupParent(System.Int32 groupId, System.Boolean parentIgnored) { }
        // RVA: 0x088A4AB8  token: 0x600017B
        public System.Void IgnoreBindingParent(System.Int32 bindingId, System.Boolean parentIgnored) { }
        // RVA: 0x088A3938  token: 0x600017C
        public Beyond.Input.KeyboardKeyCode GetActionKeyboardKeyCode(System.String actionId, System.Boolean isModifyKey, System.Boolean isPrimary) { }
        // RVA: 0x034BA190  token: 0x600017D
        public Beyond.Input.GamepadKeyCode GetActionGamepadKeyCode(System.String actionId, System.Boolean isModifyKey, System.Boolean isPrimary, Beyond.Input.InputSettingLevel level) { }
        // RVA: 0x088A2F10  token: 0x600017E
        public System.Void DeleteCustomBinding(System.String actionId, Beyond.Input.InputDeviceFlags deviceFlags) { }
        // RVA: 0x02F0CA30  token: 0x600017F
        public System.Void DeleteAllCustomBindings(Beyond.Input.InputDeviceFlags deviceFlags) { }
        // RVA: 0x02C6AD00  token: 0x6000180
        public System.Void SetBindingText(System.Int32 id, System.String text) { }
        // RVA: 0x02BDFD80  token: 0x6000181
        public System.String GetBindingText(System.Int32 id) { }
        // RVA: 0x088A496C  token: 0x6000182
        public System.Boolean HasBinding(System.Int32 id) { }
        // RVA: 0x02BE0100  token: 0x6000183
        public System.String GetActionText(System.String actionId) { }
        // RVA: 0x02BE0190  token: 0x6000184
        public static System.String GetActionText(Beyond.Input.PlayerActionInfo info, System.String actionId) { }
        // RVA: 0x088A2550  token: 0x6000185
        public System.Boolean CheckActionKeyCodeConflict(System.String actionId, Beyond.Input.KeyboardKeyCode keyCode, System.Boolean& isPrimary) { }
        // RVA: 0x02857390  token: 0x6000186
        private System.Void _DeleteGroup(Beyond.Input.InputBindingGroup group, System.Boolean isRootCall) { }
        // RVA: 0x02857470  token: 0x6000187
        private System.Void _DeleteInGroup(Beyond.Input.InputBindingGroup group) { }
        // RVA: 0x028592F0  token: 0x6000188
        private System.Void _RealRemoveBindingInfo(Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x02913E30  token: 0x6000189
        public System.Single GetAxis(System.String name) { }
        // RVA: 0x02BDE7F0  token: 0x600018A
        public System.Void GetBindingInfo(System.Int32 bindingId, System.String& actionId, Beyond.Input.IBindingView& bindingView) { }
        // RVA: 0x02C6D7A0  token: 0x600018B
        private System.Void _LoadSetting() { }
        // RVA: 0x02C6DF60  token: 0x600018C
        public System.Void LoadSetting() { }
        // RVA: 0x02C6DE80  token: 0x600018D
        public System.Boolean IsPlayerActionIdValid(System.String id) { }
        // RVA: 0x02856FD0  token: 0x600018E
        public Beyond.Input.PlayerActionInfo GetPlayerActionInfo(System.String id, Beyond.Input.InputSettingLevel level) { }
        // RVA: 0x088A24E8  token: 0x600018F
        public System.Void ChangePlayerAction(System.String id, Beyond.Input.PlayerActionInfo actionInfo) { }
        // RVA: 0x088A1FC4  token: 0x6000190
        public System.String AddAnonymousPlayerAction(Beyond.Input.PlayerActionInfo actionInfo) { }
        // RVA: 0x03B107B0  token: 0x6000191
        private System.Void _LoadCustomInputSetting() { }
        // RVA: 0x088A75B0  token: 0x6000192
        private Beyond.Input.PlayerActionInfo _GetOrCreatePendingActionInfo(System.String actionId) { }
        // RVA: 0x088A2CF0  token: 0x6000193
        public System.Boolean CustomizeActionKey(System.String actionId, Beyond.Input.KeyboardKeyCode key, System.Boolean isPrimary, System.String overrideKeyIconName) { }
        // RVA: 0x088A2A18  token: 0x6000194
        public System.Boolean CustomizeActionKey(System.String actionId, System.Nullable<Beyond.Input.GamepadKeyCode> modifyKey, System.Nullable<Beyond.Input.GamepadKeyCode> key, System.Boolean isPrimary, System.String overrideKeyIconName) { }
        // RVA: 0x088A272C  token: 0x6000195
        public System.Void ClearPendingInputSetting() { }
        // RVA: 0x02F0BB70  token: 0x6000196
        public System.Void SaveCustomInputSetting() { }
        // RVA: 0x03801880  token: 0x60001A1
        private System.Void _CreateCanvas() { }
        // RVA: 0x03801B20  token: 0x60001A2
        private System.Void _CreateDebugVirtualMouse() { }
        // RVA: 0x03801BC0  token: 0x60001A3
        private System.Void _CreateVirtualMouse() { }
        // RVA: 0x029A71D0  token: 0x60001A4
        private System.Void _ToggleVirtualMouse(System.Boolean active, System.Boolean forceUpdate) { }
        // RVA: 0x029A7170  token: 0x60001A5
        private System.Void _CheckVirtualMouseState() { }
        // RVA: 0x0284FE70  token: 0x60001A7
        public static UnityEngine.Vector3 GetMousePos() { }
        // RVA: 0x088A58C8  token: 0x60001A8
        public System.Void SetOnlyVirtualMousePos(UnityEngine.Vector2 newPos) { }
        // RVA: 0x088A56E4  token: 0x60001A9
        public static System.Void SetMousePos(UnityEngine.Vector2 newPos, System.Boolean hideVirtualMouse) { }
        // RVA: 0x024AEFE0  token: 0x60001AA
        public static System.Boolean GetMouseButton(System.Int32 button) { }
        // RVA: 0x0284ED60  token: 0x60001AB
        public static System.Boolean IsLeftMouseDown() { }
        // RVA: 0x02850210  token: 0x60001AC
        public static System.Boolean GetMouseButtonDown(System.Int32 button) { }
        // RVA: 0x028500A0  token: 0x60001AD
        public static System.Boolean GetMouseButtonUp(System.Int32 button) { }
        // RVA: 0x03D48150  token: 0x60001B2
        public System.Void SetCustomControllerMouse(UnityEngine.Transform trans, UnityEngine.Camera uiCamera) { }
        // RVA: 0x088A4058  token: 0x60001B3
        public System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo> GetEmptyControllerHintInfoList() { }
        // RVA: 0x088A3B28  token: 0x60001B4
        public System.Void GetControllerHintInfos(System.Int32 groupId, System.Boolean ignoreRootEnabled, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        // RVA: 0x088A3A78  token: 0x60001B5
        public System.Void GetControllerHintInfos(System.Collections.Generic.List<System.String> actionIdList, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        // RVA: 0x088A6AAC  token: 0x60001B6
        private System.Void _GetControllerHintInfos(Beyond.Input.InputBindingGroup group, System.Boolean ignoreRootEnabled, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        // RVA: 0x088A68D8  token: 0x60001B7
        private System.Void _GetControllerHintInfos(System.Collections.Generic.List<System.String> actionIdList, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        // RVA: 0x088A4680  token: 0x60001B8
        public System.Single GetPlayerActionLongPressStartTime(System.String actionId, System.Single& longPressTime) { }
        // RVA: 0x088A37A0  token: 0x60001B9
        public System.Single GetActionBindingLongPressStartTime(System.Int32 bindingId, System.Single& longPressTime) { }
        // RVA: 0x038C88F0  token: 0x60001BA
        public System.Boolean GetControllerIndicatorState() { }
        // RVA: 0x03B294E0  token: 0x60001BB
        public System.Boolean CheckNormalAttackBtn() { }
        // RVA: 0x0297A790  token: 0x60001BC
        private System.Void _UpdateControllerIndicator(System.Single deltaTime) { }
        // RVA: 0x088A5DE8  token: 0x60001BD
        public System.Int32 TryPressControllerIndicatorWhenSkillButtonJustPressed() { }
        // RVA: 0x088A5D10  token: 0x60001BE
        public System.Void TryClickSkillButtonWhenControllerIndicatorJustRelease(System.Int32 charIndex) { }
        // RVA: 0x037C9F40  token: 0x60001BF
        private System.Void _RefreshControllerBattleButton() { }
        // RVA: 0x088A209C  token: 0x60001C0
        public System.Void AddGuideUseActionId(System.String actionId) { }
        // RVA: 0x088A4FE8  token: 0x60001C1
        public System.Void RemoveGuideUseActionId(System.String actionId) { }
        // RVA: 0x088A26B0  token: 0x60001C2
        public System.Void ClearGuideUseActionIds() { }
        // RVA: 0x088A5F04  token: 0x60001C3
        public System.Void VibrateController(System.Single time, System.Single level) { }
        // RVA: 0x088A74DC  token: 0x60001C4
        private static System.String _GetGamepadKeyIconFolderPath() { }
        // RVA: 0x02C73810  token: 0x60001C5
        public static System.String GetStringByKeyboardKeyCode(Beyond.Input.KeyboardKeyCode code) { }
        // RVA: 0x088A47C4  token: 0x60001C6
        public static System.String GetStringByGamepadKeyCode(Beyond.Input.GamepadKeyCode code) { }
        // RVA: 0x088A4524  token: 0x60001C7
        public static System.String GetKeyIconPath(Beyond.Input.GamepadInput inputInfo, System.Boolean isModifyKey, System.Boolean isFullPath, System.Boolean ignoreOverrideKeyIcon) { }
        // RVA: 0x088A420C  token: 0x60001C8
        public static System.String GetGamepadKeyIconPath(System.String keyStr, System.Boolean isLongPress, System.Boolean isFullPath) { }
        // RVA: 0x02C732D0  token: 0x60001C9
        public static System.String GetKeyIconPath(Beyond.Input.KeyboardInput inputInfo, System.Boolean isModifyKey, System.Boolean isFullPath) { }
        // RVA: 0x02C73380  token: 0x60001CA
        public static System.String GetKeyIconPath(Beyond.Input.KeyboardInput inputInfo, System.Boolean isModifyKey, System.Boolean isLongPress, System.Boolean isFullPath) { }
        // RVA: 0x02C734E0  token: 0x60001CB
        private static System.String _GetKeyIconPath(System.String path, System.String keyStr, System.Boolean isLongPress, System.Boolean isFullPath) { }
        // RVA: 0x037680F0  token: 0x60001CC
        public static System.String ParseTextActionId(System.String text) { }
        // RVA: 0x088A4C24  token: 0x60001CD
        public System.Void MoveMouseTo(UnityEngine.RectTransform target, UnityEngine.Camera uiCamera) { }
        // RVA: 0x088A4EA0  token: 0x60001CE
        public System.Void MoveVirtualMouseTo(UnityEngine.RectTransform target, UnityEngine.Camera uiCamera, System.Boolean hideVirtualMouse) { }
        // RVA: 0x088A5964  token: 0x60001CF
        public System.Void SetVirtualMouseIconVisible(System.Boolean active) { }
        // RVA: 0x088A6700  token: 0x60001D2
        private System.Void _ControllerTouchPanelTick() { }
        // RVA: 0x0284E4B0  token: 0x60001D3
        public static System.Int32 GetTouchId(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02CACD80  token: 0x60001D4
        public static System.Boolean GetPressPosByTouchId(System.Int32 touchId, UnityEngine.Vector2& position) { }
        // RVA: 0x088A3660  token: 0x60001D5
        public virtual System.Void Dispose() { }
        // RVA: 0x088A508C  token: 0x60001D6
        public static System.Void RemoveUnusedInput() { }
        // RVA: 0x03A5A340  token: 0x60001D7
        private System.Void _OnNetMaskChanged(Beyond.EventData<System.Boolean>& v) { }
        // RVA: 0x088A3C1C  token: 0x60001D8
        public System.String GetCurJsInfos() { }
        // RVA: 0x034961D0  token: 0x60001D9
        private static System.Void .cctor() { }
        // RVA: 0x088A5EC4  token: 0x60001DA
        private System.Void <_Init>b__65_0(Beyond.Input.KeyboardKeyCode key) { }
        // RVA: 0x088A5EE4  token: 0x60001DB
        private System.Void <_Init>b__65_1(Beyond.Input.GamepadKeyCode key) { }
        // RVA: 0x03B72CD0  token: 0x60001DC
        private System.Void <_Init>b__65_2() { }
        // RVA: 0x03D49CB0  token: 0x60001DD
        private System.Void <_Init>b__65_3() { }

    }

    // TypeToken: 0x200002C  // size: 0x20
    public class InputRebindConfig : UnityEngine.ScriptableObject
    {
        // Fields
        public static System.String INPUT_REBIND_CONFIG_PATH;  // const
        public Beyond.Input.InputRebindActionScopeConfig[] actionScopeConfigs;  // 0x18

        // Methods
        // RVA: 0x0286F540  token: 0x60001ED
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x28
    public class InputRebindActionScopeConfig
    {
        // Fields
        public System.String name;  // 0x10
        public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeWhiteList;  // 0x18
        public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeBlackList;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60001EE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x20
    public class InputSetting : UnityEngine.ScriptableObject
    {
        // Fields
        public static System.String CUSTOM_SETTING_DIRECTORY_NAME;  // const
        public static System.String CUSTOM_SETTING_JSON_FILE_NAME;  // const
        public Beyond.SerializeFieldDictionaryPaired<System.String,Beyond.Input.PlayerActionInfo> actionInfos;  // 0x18

        // Methods
        // RVA: 0x0286D830  token: 0x60001EF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002F  // size: 0x20
    public class InputSettingConfig : UnityEngine.ScriptableObject
    {
        // Fields
        public static System.String INPUT_SETTING_CONFIG_PATH;  // const
        public System.Collections.Generic.List<Beyond.Input.InputSetting> inputSettingList;  // 0x18

        // Methods
        // RVA: 0x03CF2860  token: 0x60001F0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x10
    public static class InputUtils
    {
        // Methods
        // RVA: 0x088B1D94  token: 0x60001F1
        public static System.Void IgnoreBindingParent(Beyond.Input.IBindingTarget target, System.Boolean active) { }
        // RVA: 0x088B1CE8  token: 0x60001F2
        public static System.Void IgnoreBindingGroupParent(Beyond.Input.IBindingGroupTarget target, System.Boolean active) { }
        // RVA: 0x088B1C8C  token: 0x60001F3
        public static System.Boolean HasFlag(Beyond.Input.InputDeviceFlags value, Beyond.Input.InputDeviceFlags target) { }

    }

    // TypeToken: 0x2000031  // size: 0x20
    public abstract class KeyboardCheckerBase
    {
        // Fields
        protected Beyond.Input.InputManager m_inputManager;  // 0x10
        protected static System.Int32 CTRL;  // const
        protected static System.Int32 SHIFT;  // const
        protected static System.Int32 ALT;  // const
        protected static System.Int32 MAX_INDEX;  // const
        protected static System.Int32[] s_checkPriority;  // static @ 0x0
        protected System.Collections.Generic.List<Beyond.DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>>> m_bindingInfos;  // 0x18

        // Properties
        System.Collections.Generic.List<Beyond.DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>>> bindingInfos { get; /* RVA: 0x088B1EEC */ }

        // Methods
        // RVA: 0x02975800  token: 0x60001F5
        protected System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        // RVA: 0x02857250  token: 0x60001F6
        public static System.Int32 GetModifyIndex(Beyond.Input.KeyboardInput input) { }
        // RVA: 0x028563F0  token: 0x60001F7
        public virtual Beyond.Input.KeyboardCheckerBase.Binding OnCreateBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        // RVA: 0x02859480  token: 0x60001F8
        public virtual Beyond.Input.KeyboardCheckerBase.Binding OnDeleteBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x088B1EA8  token: 0x60001F9
        public virtual System.Void CheckKeyboardInput() { }
        // RVA: 0x03415700  token: 0x60001FA
        public virtual System.Void TriggerActions() { }
        // RVA: 0x03CE3D30  token: 0x60001FB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x40
    public class KeyboardChecker : Beyond.Input.KeyboardCheckerBase
    {
        // Fields
        private System.Func<Beyond.Input.KeyboardKeyCode,System.Boolean> m_checkFunc;  // 0x20
        private System.Boolean <isPressChecker>k__BackingField;  // 0x28
        private System.Collections.Generic.HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache;  // 0x30
        private System.Collections.Generic.List<System.ValueTuple<Beyond.Input.KeyboardCheckerBase.Binding,Beyond.Input.KeyboardCheckerBase.TriggerType>> m_tmpNeedTriggerCallbacks;  // 0x38

        // Properties
        System.Boolean isPressChecker { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }

        // Methods
        // RVA: 0x029756A0  token: 0x60001FF
        public System.Void .ctor(System.Func<Beyond.Input.KeyboardKeyCode,System.Boolean> checkFunc, System.Boolean isPress, Beyond.Input.InputManager inputManager) { }
        // RVA: 0x02853EB0  token: 0x6000200
        public virtual System.Void CheckKeyboardInput() { }
        // RVA: 0x02851D00  token: 0x6000201
        public virtual System.Void TriggerActions() { }
        // RVA: 0x088B1F3C  token: 0x6000202
        public System.Void <>iFixBaseProxy_CheckKeyboardInput() { }
        // RVA: 0x088B1F44  token: 0x6000203
        public System.Void <>iFixBaseProxy_TriggerActions() { }

    }

    // TypeToken: 0x2000035  // size: 0x38
    public class KeyboardOnClickChecker : Beyond.Input.KeyboardCheckerBase
    {
        // Fields
        private System.Collections.Generic.HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache;  // 0x20
        private System.Collections.Generic.List<System.ValueTuple<Beyond.Input.KeyboardCheckerBase.Binding,Beyond.Input.KeyboardCheckerBase.TriggerType>> m_tmpNeedTriggerCallbacks;  // 0x28
        private System.Collections.Generic.List<Beyond.ListSet<Beyond.Input.KeyboardKeyCode>> m_combinationKeyPressedInfo;  // 0x30

        // Methods
        // RVA: 0x038303E0  token: 0x6000204
        public System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        // RVA: 0x02854960  token: 0x6000205
        public virtual System.Void CheckKeyboardInput() { }
        // RVA: 0x02851400  token: 0x6000206
        public virtual System.Void TriggerActions() { }
        // RVA: 0x088B1F4C  token: 0x6000207
        public System.Void ClearKeyPressed(Beyond.Input.KeyboardKeyCode keyCode) { }
        // RVA: 0x088B1F3C  token: 0x6000208
        public System.Void <>iFixBaseProxy_CheckKeyboardInput() { }
        // RVA: 0x088B1F44  token: 0x6000209
        public System.Void <>iFixBaseProxy_TriggerActions() { }

    }

    // TypeToken: 0x2000036  // size: 0x38
    public class KeyboardOnLongPressChecker : Beyond.Input.KeyboardCheckerBase
    {
        // Fields
        private System.Action<Beyond.Input.KeyboardKeyCode> m_onTriggerOnLongPress;  // 0x20
        private System.Collections.Generic.Dictionary<Beyond.Input.KeyboardInput,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>> m_bindings;  // 0x28
        private System.Collections.Generic.HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache;  // 0x30

        // Methods
        // RVA: 0x03B46090  token: 0x600020A
        public System.Void .ctor(System.Action<Beyond.Input.KeyboardKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) { }
        // RVA: 0x02852390  token: 0x600020B
        public virtual System.Void CheckKeyboardInput() { }
        // RVA: 0x088B26EC  token: 0x600020C
        private System.Void _OnTriggerBinding(Beyond.Input.KeyboardCheckerBase.Binding binding, Beyond.Input.KeyboardKeyCode keyCode) { }
        // RVA: 0x088B243C  token: 0x600020D
        public virtual Beyond.Input.KeyboardCheckerBase.Binding OnCreateBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        // RVA: 0x088B25B4  token: 0x600020E
        public virtual Beyond.Input.KeyboardCheckerBase.Binding OnDeleteBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        // RVA: 0x088B222C  token: 0x600020F
        public System.Single GetInputLongPressStartTime(Beyond.Input.KeyboardInput input, System.Int32 bindingId) { }
        // RVA: 0x088B1F3C  token: 0x6000210
        public System.Void <>iFixBaseProxy_CheckKeyboardInput() { }
        // RVA: 0x088B26D4  token: 0x6000211
        public Beyond.Input.KeyboardCheckerBase.Binding <>iFixBaseProxy_OnCreateBinding(Beyond.Input.KeyboardInput P0, Beyond.Input.InputBindingInfo P1, System.Boolean P2) { }
        // RVA: 0x088B26E4  token: 0x6000212
        public Beyond.Input.KeyboardCheckerBase.Binding <>iFixBaseProxy_OnDeleteBinding(Beyond.Input.KeyboardInput P0, Beyond.Input.InputBindingInfo P1) { }

    }

    // TypeToken: 0x2000038  // size: 0x10
    public class PlayerActionIdAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000215
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x11
    public sealed struct InputDeviceFlags
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Input.InputDeviceFlags None;  // const
        public static Beyond.Input.InputDeviceFlags Keyboard;  // const
        public static Beyond.Input.InputDeviceFlags Gamepad;  // const
        public static Beyond.Input.InputDeviceFlags All;  // const

    }

    // TypeToken: 0x200003A  // size: 0x58
    public class PlayerActionInfo
    {
        // Fields
        public System.Boolean isCommonOpenUIAction;  // 0x10
        public Beyond.Input.KeyboardInput primaryKeyboardInput;  // 0x18
        public Beyond.Input.GamepadInput primaryGamepadInput;  // 0x20
        public System.Int32 priority;  // 0x28
        public System.Boolean needShowControllerHint;  // 0x2c
        public System.Int32 controllerHintPriority;  // 0x30
        public System.String overrideTextId;  // 0x38
        public System.Boolean needSecond;  // 0x40
        public System.Boolean hideSecondInKeyHint;  // 0x41
        public Beyond.Input.KeyboardInput secondaryKeyboardInput;  // 0x48
        public Beyond.Input.GamepadInput secondaryGamepadInput;  // 0x50

        // Methods
        // RVA: 0x088B7CC4  token: 0x6000216
        public System.Void ResetHintProority() { }
        // RVA: 0x088B7BBC  token: 0x6000217
        public System.Boolean DeviceInputEquals(Beyond.Input.PlayerActionInfo other, Beyond.Input.InputDeviceFlags deviceFlags) { }
        // RVA: 0x088B7AE0  token: 0x6000218
        public System.Void DeviceInputCopyFrom(Beyond.Input.PlayerActionInfo other, Beyond.Input.InputDeviceFlags deviceFlags) { }
        // RVA: 0x01168960  token: 0x6000219
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public abstract class DeviceInput`1 : System.IEquatable`1
    {
        // Fields
        public Beyond.Input.InputTimingType timingType;  // 0x0
        public System.Boolean blockOtherTiming;  // 0x0
        public System.Single longPressTime;  // 0x0
        public System.Boolean enableContinuousTrigger;  // 0x0
        public Beyond.Input.InputContinuousTriggerType continuousTriggerType;  // 0x0
        public System.String overrideKeyIconName;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600021A
        public virtual System.String GetModifyText() { }
        // RVA: -1  // not resolved  token: 0x600021B
        public virtual System.String GetKeyCodeText() { }
        // RVA: -1  // not resolved  token: 0x600021C
        public virtual System.Int32 GetKeyCodeEnumIntValue() { }
        // RVA: -1  // not resolved  token: 0x600021D
        public virtual System.Void SetKeyCodeEnumByIntValue(System.Int32 value) { }
        // RVA: -1  // not resolved  token: 0x600021E
        public virtual System.Void ClearKeyCode() { }
        // RVA: -1  // not resolved  token: 0x600021F
        public virtual System.Boolean IsValid() { }
        // RVA: -1  // not resolved  token: 0x6000220
        public virtual System.Void CopyFrom(T other) { }
        // RVA: -1  // abstract  token: 0x6000221
        public virtual System.Boolean Equals(T other) { }
        // RVA: -1  // not resolved  token: 0x6000222
        public virtual System.String ToString() { }
        // RVA: -1  // not resolved  token: 0x6000223
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0x38
    public class KeyboardInput : Beyond.Input.DeviceInput`1
    {
        // Fields
        public Beyond.Input.KeyboardKeyCode key;  // 0x30
        public System.Boolean useCtrl;  // 0x34
        public System.Boolean useShift;  // 0x35
        public System.Boolean useAlt;  // 0x36

        // Properties
        System.String modifyString { get; /* RVA: 0x088B7A04 */ }

        // Methods
        // RVA: 0x088B7878  token: 0x6000224
        public virtual System.String GetModifyText() { }
        // RVA: 0x088B7628  token: 0x6000225
        public virtual System.String GetKeyCodeText() { }
        // RVA: 0x088B75DC  token: 0x6000226
        public virtual System.Int32 GetKeyCodeEnumIntValue() { }
        // RVA: 0x088B797C  token: 0x6000227
        public virtual System.Void SetKeyCodeEnumByIntValue(System.Int32 value) { }
        // RVA: 0x088B7478  token: 0x6000229
        public virtual System.Void ClearKeyCode() { }
        // RVA: 0x03C906C0  token: 0x600022A
        public virtual System.Boolean IsValid() { }
        // RVA: 0x088B74D4  token: 0x600022B
        public virtual System.Void CopyFrom(Beyond.Input.KeyboardInput other) { }
        // RVA: 0x088B7574  token: 0x600022C
        public virtual System.Boolean Equals(Beyond.Input.KeyboardInput other) { }
        // RVA: 0x032E1470  token: 0x600022D
        public System.Void .ctor() { }
        // RVA: 0x088B79EC  token: 0x600022E
        public System.String <>iFixBaseProxy_GetModifyText() { }
        // RVA: 0x088B79E4  token: 0x600022F
        public System.String <>iFixBaseProxy_GetKeyCodeText() { }
        // RVA: 0x088B79DC  token: 0x6000230
        public System.Int32 <>iFixBaseProxy_GetKeyCodeEnumIntValue() { }
        // RVA: 0x088B79FC  token: 0x6000231
        public System.Void <>iFixBaseProxy_SetKeyCodeEnumByIntValue(System.Int32 P0) { }
        // RVA: 0x088B79D4  token: 0x6000232
        public System.Void <>iFixBaseProxy_ClearKeyCode() { }
        // RVA: 0x088B79F4  token: 0x6000233
        public System.Boolean <>iFixBaseProxy_IsValid() { }

    }

    // TypeToken: 0x200003D  // size: 0x38
    public class GamepadInput : Beyond.Input.DeviceInput`1
    {
        // Fields
        public Beyond.Input.GamepadKeyCode key;  // 0x30
        public Beyond.Input.GamepadKeyCode modifyKey;  // 0x34

        // Methods
        // RVA: 0x088B2EF4  token: 0x6000234
        public virtual System.String GetModifyText() { }
        // RVA: 0x088B2E6C  token: 0x6000235
        public virtual System.String GetKeyCodeText() { }
        // RVA: 0x088B2E20  token: 0x6000236
        public virtual System.Int32 GetKeyCodeEnumIntValue() { }
        // RVA: 0x088B2FEC  token: 0x6000237
        public virtual System.Void SetKeyCodeEnumByIntValue(System.Int32 value) { }
        // RVA: 0x088B2D2C  token: 0x6000238
        public virtual System.Void ClearKeyCode() { }
        // RVA: 0x088B2F9C  token: 0x6000239
        public virtual System.Boolean IsValid() { }
        // RVA: 0x088B2D8C  token: 0x600023A
        public virtual System.Void CopyFrom(Beyond.Input.GamepadInput other) { }
        // RVA: 0x03CB5F60  token: 0x600023B
        public virtual System.Boolean Equals(Beyond.Input.GamepadInput other) { }
        // RVA: 0x032E14B0  token: 0x600023C
        public System.Void .ctor() { }
        // RVA: 0x088B305C  token: 0x600023D
        public System.String <>iFixBaseProxy_GetModifyText() { }
        // RVA: 0x088B3054  token: 0x600023E
        public System.String <>iFixBaseProxy_GetKeyCodeText() { }
        // RVA: 0x088B304C  token: 0x600023F
        public System.Int32 <>iFixBaseProxy_GetKeyCodeEnumIntValue() { }
        // RVA: 0x088B306C  token: 0x6000240
        public System.Void <>iFixBaseProxy_SetKeyCodeEnumByIntValue(System.Int32 P0) { }
        // RVA: 0x088B3044  token: 0x6000241
        public System.Void <>iFixBaseProxy_ClearKeyCode() { }
        // RVA: 0x088B3064  token: 0x6000242
        public System.Boolean <>iFixBaseProxy_IsValid() { }

    }

    // TypeToken: 0x200003E  // size: 0x20
    public class RealCursorManager
    {
        // Fields
        private System.Boolean <forceShowCursorForF5>k__BackingField;  // 0x10
        private System.Boolean <forceHideCursorForUsingController>k__BackingField;  // 0x11
        private System.Boolean <isUsingVirtualMouse>k__BackingField;  // 0x12
        private System.Boolean <forceShowRealCursorForChangeInput>k__BackingField;  // 0x13
        private System.Collections.Generic.Dictionary<System.String,System.Boolean> m_internalCursorState;  // 0x18

        // Properties
        System.Boolean forceShowCursorForF5 { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        System.Boolean forceHideCursorForUsingController { get; /* RVA: 0x03D510E0 */ set; /* RVA: 0x03D510F0 */ }
        System.Boolean isUsingVirtualMouse { get; /* RVA: 0x03D519E0 */ set; /* RVA: 0x03D6B770 */ }
        System.Boolean forceShowRealCursorForChangeInput { get; /* RVA: 0x03D69BB0 */ set; /* RVA: 0x03D6DC80 */ }

        // Methods
        // RVA: 0x03CEF140  token: 0x600024B
        public System.Void .ctor() { }
        // RVA: 0x02CAA270  token: 0x600024C
        public System.Void SetForceHideCursorForController(System.Boolean forceHide, System.Boolean isUsingVirtualMouse) { }
        // RVA: 0x088B7DB0  token: 0x600024D
        public System.Void SetDebugShowCursorMode(System.Boolean enableDebug) { }
        // RVA: 0x088B7E18  token: 0x600024E
        public System.Void ToggleForceShowRealCursorForChangeInput(System.Boolean forceShow) { }
        // RVA: 0x024AF990  token: 0x600024F
        public System.Boolean IsNeedShowCursor() { }
        // RVA: 0x029A87E0  token: 0x6000250
        public System.Void ResetCursorInHideCursorMode() { }
        // RVA: 0x029A7370  token: 0x6000251
        public System.Void ToggleCursorInHideCursorMode(System.String operationKey, System.Boolean showCursor) { }
        // RVA: 0x029A7480  token: 0x6000252
        public System.Void CalcState(System.Boolean forceUpdate) { }
        // RVA: 0x029A74F0  token: 0x6000253
        private System.Void _ToggleCursorInternal(System.Boolean enable, System.Boolean forceUpdate) { }

    }

    // TypeToken: 0x200003F  // size: 0x10
    public class TextIdAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000254
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000040  // size: 0x78
    public class UIEvent : UnityEngine.Events.UnityEvent, Beyond.Input.IBindingTarget
    {
        // Fields
        private System.Boolean m_bindingInit;  // 0x30
        public System.Boolean useBindingAction;  // 0x31
        public System.String playerActionId;  // 0x38
        public Beyond.Input.PlayerActionInfo anonymousPlayerActionInfo;  // 0x40
        public System.String anonymousPlayerActionId;  // 0x48
        private System.Int32 <bindingId>k__BackingField;  // 0x50
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;  // 0x58
        private System.Action m_bindAct;  // 0x60
        private System.Action m_onUpdateKeyAct;  // 0x68
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction> m_calls;  // 0x70

        // Properties
        System.Boolean bindingEnabled { get; /* RVA: 0x088B867C */ }
        System.Int32 bindingId { get; /* RVA: 0x03D4EED0 */ set; /* RVA: 0x03D4EF20 */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        System.Int32 count { get; /* RVA: 0x088B8724 */ }

        // Methods
        // RVA: 0x088B8538  token: 0x600025A
        private System.Void _CreatePlayerActionBinding() { }
        // RVA: 0x088B8068  token: 0x600025B
        public System.Void InitBinding(Beyond.Input.IBindingGroupTarget parent, System.Action bindAct, System.Action onUpdateKeyAct) { }
        // RVA: 0x088B8140  token: 0x600025C
        public System.Void Invoke() { }
        // RVA: 0x088B8498  token: 0x600025D
        public System.Void UpdateKeys() { }
        // RVA: 0x088B7FFC  token: 0x600025E
        public System.Void ChangeBindingPlayerAction(System.String actionId) { }
        // RVA: 0x088B7EAC  token: 0x6000260
        public System.Void AddListener(UnityEngine.Events.UnityAction call) { }
        // RVA: 0x088B83C8  token: 0x6000261
        public System.Void RemoveListener(UnityEngine.Events.UnityAction call) { }
        // RVA: 0x088B8210  token: 0x6000262
        public System.Void RemoveAllListeners() { }
        // RVA: 0x088B866C  token: 0x6000263
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class UIEvent`1 : UnityEngine.Events.UnityEvent`1, Beyond.Input.IBindingTarget
    {
        // Fields
        private System.Boolean m_bindingInit;  // 0x0
        public System.Boolean useBindingAction;  // 0x0
        public System.String playerActionId;  // 0x0
        public Beyond.Input.PlayerActionInfo anonymousPlayerActionInfo;  // 0x0
        public System.String anonymousPlayerActionId;  // 0x0
        public System.Boolean useAnonymousAction;  // 0x0
        public System.Boolean tempForceEnable;  // 0x0
        private System.Int32 <bindingId>k__BackingField;  // 0x0
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;  // 0x0
        private System.Action m_bindAct;  // 0x0
        private System.Action m_onUpdateKeyAct;  // 0x0
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction<T0>> m_calls;  // 0x0

        // Properties
        System.Boolean bindingEnabled { get; /* RVA: -1  // not resolved */ }
        System.Int32 bindingId { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Int32 count { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000269
        private System.Void _CreatePlayerActionBinding() { }
        // RVA: -1  // not resolved  token: 0x600026A
        public System.Void InitBinding(Beyond.Input.IBindingGroupTarget parent, System.Action bindAct, System.Action onUpdateKeyAct) { }
        // RVA: -1  // not resolved  token: 0x600026B
        public System.Void Invoke(T0 arg0) { }
        // RVA: -1  // not resolved  token: 0x600026C
        public Beyond.Input.PlayerActionInfo GetEventPlayerActionInfo() { }
        // RVA: -1  // not resolved  token: 0x600026D
        public System.Void UpdateKeys() { }
        // RVA: -1  // not resolved  token: 0x600026E
        public System.Void ChangeBindingPlayerAction(System.String actionId) { }
        // RVA: -1  // not resolved  token: 0x600026F
        public System.Void StopUseBinding() { }
        // RVA: -1  // not resolved  token: 0x6000270
        public System.String GetActionId() { }
        // RVA: -1  // not resolved  token: 0x6000272
        public System.Void AddListener(UnityEngine.Events.UnityAction<T0> call) { }
        // RVA: -1  // not resolved  token: 0x6000273
        public System.Void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }
        // RVA: -1  // not resolved  token: 0x6000274
        public System.Void RemoveAllListeners() { }
        // RVA: -1  // not resolved  token: 0x6000275
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class UIEvent`2 : UnityEngine.Events.UnityEvent`2, Beyond.Input.IBindingTarget
    {
        // Fields
        private System.Boolean m_bindingInit;  // 0x0
        public System.Boolean useBindingAction;  // 0x0
        public System.String playerActionId;  // 0x0
        public Beyond.Input.PlayerActionInfo anonymousPlayerActionInfo;  // 0x0
        public System.String anonymousPlayerActionId;  // 0x0
        private System.Int32 <bindingId>k__BackingField;  // 0x0
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;  // 0x0
        private System.Action m_bindAct;  // 0x0
        private System.Action m_onUpdateKeyAct;  // 0x0
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction<T0,T1>> m_calls;  // 0x0

        // Properties
        System.Boolean bindingEnabled { get; /* RVA: -1  // not resolved */ }
        System.Int32 bindingId { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        Beyond.Input.IBindingGroupTarget parentTarget { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Int32 count { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600027B
        private System.Void _CreatePlayerActionBinding() { }
        // RVA: -1  // not resolved  token: 0x600027C
        public System.Void InitBinding(Beyond.Input.IBindingGroupTarget parent, System.Action bindAct, System.Action onUpdateKeyAct) { }
        // RVA: -1  // not resolved  token: 0x600027D
        public System.Void Invoke(T0 arg0, T1 arg1) { }
        // RVA: -1  // not resolved  token: 0x600027E
        public System.Void UpdateKeys() { }
        // RVA: -1  // not resolved  token: 0x600027F
        public System.Void ChangeBindingPlayerAction(System.String actionId) { }
        // RVA: -1  // not resolved  token: 0x6000281
        public System.Void AddListener(UnityEngine.Events.UnityAction<T0,T1> call) { }
        // RVA: -1  // not resolved  token: 0x6000282
        public System.Void RemoveListener(UnityEngine.Events.UnityAction<T0,T1> call) { }
        // RVA: -1  // not resolved  token: 0x6000283
        public System.Void RemoveAllListeners() { }
        // RVA: -1  // not resolved  token: 0x6000284
        public System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000005  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000026
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000027
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000028
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000029
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600002A
        public System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000045  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000285
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x0514EF5C  token: 0x6000286
        public System.Boolean __Gen_Wrap_0(System.Object P0) { }
        // RVA: 0x050EF068  token: 0x6000287
        public System.UInt32 __Gen_Wrap_1() { }
        // RVA: 0x04274234  token: 0x6000288
        public System.Void __Gen_Wrap_2(System.Object P0) { }
        // RVA: 0x05477860  token: 0x6000289
        public System.Void __Gen_Wrap_3(System.Object P0, System.Boolean P1) { }
        // RVA: 0x05477648  token: 0x600028A
        public System.Void __Gen_Wrap_4(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x0549D548  token: 0x600028B
        public System.Void __Gen_Wrap_5(System.Object P0, UnityEngine.UI.NavigationBindingType P1) { }
        // RVA: 0x0548C780  token: 0x600028C
        public System.Boolean __Gen_Wrap_6(System.Object P0, System.Int32 P1) { }
        // RVA: 0x054790D0  token: 0x600028D
        public System.Void __Gen_Wrap_7(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x0562978C  token: 0x600028E
        public System.Boolean __Gen_Wrap_8(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x05163BA0  token: 0x600028F
        public System.Void __Gen_Wrap_9(System.Object P0, System.Object P1) { }
        // RVA: 0x088B3358  token: 0x6000290
        public UnityEngine.Vector3 __Gen_Wrap_10(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        // RVA: 0x088B3474  token: 0x6000291
        public UnityEngine.Vector3 __Gen_Wrap_11(System.Object P0, UnityEngine.Vector2 P1) { }
        // RVA: 0x088B35B8  token: 0x6000292
        public UnityEngine.UI.Selectable __Gen_Wrap_12(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3, UnityEngine.UI.NaviStrategy P4, System.Double P5, System.Double& P6) { }
        // RVA: 0x088B3784  token: 0x6000293
        public UnityEngine.UI.Selectable __Gen_Wrap_13(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3, System.Double P4, System.Double& P5) { }
        // RVA: 0x05E7433C  token: 0x6000294
        public System.Boolean __Gen_Wrap_14(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        // RVA: 0x05153920  token: 0x6000295
        public System.Boolean __Gen_Wrap_15(System.Object P0, System.Object P1) { }
        // RVA: 0x0516413C  token: 0x6000296
        public System.Void __Gen_Wrap_16(System.Object P0, System.Object P1, UnityEngine.UI.NavigationBindingType P2) { }
        // RVA: 0x05150B1C  token: 0x6000297
        public System.Void __Gen_Wrap_17(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x055FFD60  token: 0x6000298
        public System.Void __Gen_Wrap_18(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        // RVA: 0x088B3940  token: 0x6000299
        public Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> __Gen_Wrap_19(System.Object P0) { }
        // RVA: 0x088B3A1C  token: 0x600029A
        public Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>>> __Gen_Wrap_20(System.Object P0) { }
        // RVA: 0x088B3AF8  token: 0x600029B
        public Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> __Gen_Wrap_21(System.Object P0, System.Object P1) { }
        // RVA: 0x088B3C04  token: 0x600029C
        public Beyond.Input.GamepadCheckerBase.Binding __Gen_Wrap_22(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x088B3D38  token: 0x600029D
        public Beyond.Input.GamepadCheckerBase.Binding __Gen_Wrap_23(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x0516413C  token: 0x600029E
        public System.Void __Gen_Wrap_24(System.Object P0, System.Object P1, Beyond.Input.GamepadKeyCode P2) { }
        // RVA: 0x051624BC  token: 0x600029F
        public System.Void __Gen_Wrap_25() { }
        // RVA: 0x0549D548  token: 0x60002A0
        public System.Void __Gen_Wrap_26(System.Object P0, Beyond.Input.InputContinuousTriggerType P1) { }
        // RVA: 0x088B3E60  token: 0x60002A1
        public Beyond.Input.IBindingView __Gen_Wrap_27(System.Object P0) { }
        // RVA: 0x055FFD60  token: 0x60002A2
        public System.Void __Gen_Wrap_28(System.Object P0, Beyond.Input.GamepadKeyCode P1) { }
        // RVA: 0x088B3F50  token: 0x60002A3
        public Beyond.Input.PlayerActionInfo __Gen_Wrap_29(System.Object P0, System.Object P1, Beyond.Input.InputSettingLevel P2) { }
        // RVA: 0x088B4074  token: 0x60002A4
        public System.String __Gen_Wrap_30(System.Object P0, System.Object P1) { }
        // RVA: 0x088B4180  token: 0x60002A5
        public System.String __Gen_Wrap_31(System.Object P0) { }
        // RVA: 0x088B4270  token: 0x60002A6
        public System.Action __Gen_Wrap_32(System.Object P0, System.Object P1, Beyond.Input.GamepadKeyCode P2) { }
        // RVA: 0x088B4384  token: 0x60002A7
        public System.Single __Gen_Wrap_33(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x05151D64  token: 0x60002A8
        public System.Boolean __Gen_Wrap_34(Beyond.Input.GamepadKeyCode P0) { }
        // RVA: 0x088B4488  token: 0x60002A9
        public System.Void __Gen_Wrap_35(UnityEngine.InputSystem.InputActionProperty P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x088B45AC  token: 0x60002AA
        public System.Void __Gen_Wrap_36(UnityEngine.InputSystem.InputActionProperty& P0, UnityEngine.InputSystem.InputActionProperty P1) { }
        // RVA: 0x088B4724  token: 0x60002AB
        public System.Void __Gen_Wrap_37(System.Object P0, UnityEngine.InputSystem.InputActionProperty P1) { }
        // RVA: 0x088B482C  token: 0x60002AC
        public System.Void __Gen_Wrap_38(System.Object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1) { }
        // RVA: 0x054761A8  token: 0x60002AD
        public System.Int32 __Gen_Wrap_39(System.Object P0, System.Int32 P1) { }
        // RVA: 0x050EF614  token: 0x60002AE
        public System.Int32 __Gen_Wrap_40(System.Object P0) { }
        // RVA: 0x088B492C  token: 0x60002AF
        public Beyond.Input.KeyboardCheckerBase.Binding __Gen_Wrap_41(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x088B4A60  token: 0x60002B0
        public System.Int32 __Gen_Wrap_42(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        // RVA: 0x050EF298  token: 0x60002B1
        public System.Boolean __Gen_Wrap_43(UnityEngine.UI.Selectable P0) { }
        // RVA: 0x088B4B74  token: 0x60002B2
        public UnityEngine.UI.Selectable __Gen_Wrap_44(System.Object P0) { }
        // RVA: 0x088B4C50  token: 0x60002B3
        public Beyond.Input.KeyboardCheckerBase.Binding __Gen_Wrap_45(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x0549D548  token: 0x60002B4
        public System.Void __Gen_Wrap_46(System.Object P0, System.Int32 P1) { }
        // RVA: 0x088B4D78  token: 0x60002B5
        public System.Object __Gen_Wrap_47(System.Object P0) { }
        // RVA: 0x0514F380  token: 0x60002B6
        public System.Boolean __Gen_Wrap_48() { }
        // RVA: 0x088B4E54  token: 0x60002B7
        public UnityEngine.Vector2 __Gen_Wrap_49(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x088B4F7C  token: 0x60002B8
        public UnityEngine.Vector2 __Gen_Wrap_50() { }
        // RVA: 0x0514F660  token: 0x60002B9
        public System.Void __Gen_Wrap_51(System.Boolean P0) { }
        // RVA: 0x05E3DBF4  token: 0x60002BA
        public System.Void __Gen_Wrap_52(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x0549D548  token: 0x60002BB
        public System.Void __Gen_Wrap_53(System.Object P0, Beyond.DeviceInfo.InputType P1) { }
        // RVA: 0x088B5048  token: 0x60002BC
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.Int32>> __Gen_Wrap_54(System.Object P0) { }
        // RVA: 0x050F0008  token: 0x60002BD
        public System.Void __Gen_Wrap_55(System.Object P0, System.Single P1) { }
        // RVA: 0x055FFD60  token: 0x60002BE
        public System.Void __Gen_Wrap_56(System.Object P0, Beyond.Input.KeyboardKeyCode P1) { }
        // RVA: 0x050EE9C4  token: 0x60002BF
        public System.Void __Gen_Wrap_57(Beyond.Input.KeyboardKeyCode P0) { }
        // RVA: 0x050EE9C4  token: 0x60002C0
        public System.Void __Gen_Wrap_58(Beyond.Input.GamepadKeyCode P0) { }
        // RVA: 0x050EF354  token: 0x60002C1
        public Beyond.DeviceInfo.ControllerType __Gen_Wrap_59(System.Object P0, System.Object P1) { }
        // RVA: 0x088B5138  token: 0x60002C2
        public System.String __Gen_Wrap_60(Beyond.Input.GamepadKeyCode P0) { }
        // RVA: 0x088B5224  token: 0x60002C3
        public System.String __Gen_Wrap_61() { }
        // RVA: 0x088B52F0  token: 0x60002C4
        public System.String __Gen_Wrap_62(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x088B5424  token: 0x60002C5
        public System.String __Gen_Wrap_63(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x088B554C  token: 0x60002C6
        public System.String __Gen_Wrap_64(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x088B5680  token: 0x60002C7
        public System.String __Gen_Wrap_65(Beyond.Input.KeyboardKeyCode P0) { }
        // RVA: 0x088B576C  token: 0x60002C8
        public System.Single __Gen_Wrap_66(System.Object P0, System.Boolean P1) { }
        // RVA: 0x088B5858  token: 0x60002C9
        public System.Void __Gen_Wrap_67(System.Object P0, Beyond.EventData<System.Boolean>& P1) { }
        // RVA: 0x088B5978  token: 0x60002CA
        public System.Boolean __Gen_Wrap_68(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode& P2) { }
        // RVA: 0x088B5A90  token: 0x60002CB
        public System.Boolean __Gen_Wrap_69(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode& P2, System.Boolean& P3) { }
        // RVA: 0x0561022C  token: 0x60002CC
        public System.Boolean __Gen_Wrap_70(System.Object P0, Beyond.Input.GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2) { }
        // RVA: 0x088B5BDC  token: 0x60002CD
        public System.Int32 __Gen_Wrap_71(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.String& P4) { }
        // RVA: 0x088B5D4C  token: 0x60002CE
        public System.Int32 __Gen_Wrap_72(System.Object P0, Beyond.Input.KeyboardKeyCode P1, System.Object P2, Beyond.Input.InputTimingType P3, System.Object P4, System.Int32 P5) { }
        // RVA: 0x0578888C  token: 0x60002CF
        public System.Boolean __Gen_Wrap_73(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x0514F720  token: 0x60002D0
        public System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x088B5E70  token: 0x60002D1
        public System.Void __Gen_Wrap_75(System.Object P0, System.Boolean P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x088B5F78  token: 0x60002D2
        public System.Int32 __Gen_Wrap_76(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        // RVA: 0x088B607C  token: 0x60002D3
        public Beyond.Input.KeyboardKeyCode __Gen_Wrap_77(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x088B6184  token: 0x60002D4
        public Beyond.Input.GamepadKeyCode __Gen_Wrap_78(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, Beyond.Input.InputSettingLevel P4) { }
        // RVA: 0x05164540  token: 0x60002D5
        public System.Boolean __Gen_Wrap_79(Beyond.Input.InputDeviceFlags P0, Beyond.Input.InputDeviceFlags P1) { }
        // RVA: 0x0563A144  token: 0x60002D6
        public System.Boolean __Gen_Wrap_80(System.Object P0, System.Object P1, Beyond.Input.InputDeviceFlags P2) { }
        // RVA: 0x05E48B74  token: 0x60002D7
        public System.Void __Gen_Wrap_81(System.Object P0, System.Object P1, Beyond.Input.InputDeviceFlags P2) { }
        // RVA: 0x0563E0E0  token: 0x60002D8
        public System.Void __Gen_Wrap_82(System.Object P0, Beyond.Input.InputDeviceFlags P1) { }
        // RVA: 0x088B62A8  token: 0x60002D9
        public System.String __Gen_Wrap_83(System.Object P0, System.Int32 P1) { }
        // RVA: 0x088B63B4  token: 0x60002DA
        public System.Boolean __Gen_Wrap_84(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode P2, System.Boolean& P3) { }
        // RVA: 0x054AB15C  token: 0x60002DB
        public System.Single __Gen_Wrap_85(System.Object P0, System.Object P1) { }
        // RVA: 0x088B64DC  token: 0x60002DC
        public System.Void __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.String& P2, Beyond.Input.IBindingView& P3) { }
        // RVA: 0x088B6654  token: 0x60002DD
        public Beyond.Input.PlayerActionInfo __Gen_Wrap_87(System.Object P0, System.Object P1) { }
        // RVA: 0x088B6760  token: 0x60002DE
        public System.Boolean __Gen_Wrap_88(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode P2, System.Boolean P3, System.Object P4) { }
        // RVA: 0x088B6884  token: 0x60002DF
        public System.Boolean __Gen_Wrap_89(System.Object P0, System.Object P1, System.Nullable<Beyond.Input.GamepadKeyCode> P2, System.Nullable<Beyond.Input.GamepadKeyCode> P3, System.Boolean P4, System.Object P5) { }
        // RVA: 0x088B69F4  token: 0x60002E0
        public UnityEngine.Vector3 __Gen_Wrap_90() { }
        // RVA: 0x088B6AE8  token: 0x60002E1
        public System.Void __Gen_Wrap_91(UnityEngine.Vector2 P0, System.Boolean P1) { }
        // RVA: 0x088B6BF0  token: 0x60002E2
        public System.Void __Gen_Wrap_92(System.Object P0, UnityEngine.Vector2 P1) { }
        // RVA: 0x0514DE88  token: 0x60002E3
        public System.Boolean __Gen_Wrap_93(System.Int32 P0) { }
        // RVA: 0x088B6CF8  token: 0x60002E4
        public System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo> __Gen_Wrap_94(System.Object P0) { }
        // RVA: 0x088B6DD4  token: 0x60002E5
        public System.Void __Gen_Wrap_95(System.Object P0, System.Object P1, System.Boolean P2, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& P3) { }
        // RVA: 0x088B6F18  token: 0x60002E6
        public System.Void __Gen_Wrap_96(System.Object P0, System.Int32 P1, System.Boolean P2, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& P3) { }
        // RVA: 0x088B705C  token: 0x60002E7
        public System.Void __Gen_Wrap_97(System.Object P0, System.Object P1, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& P2) { }
        // RVA: 0x088B718C  token: 0x60002E8
        public System.Single __Gen_Wrap_98(System.Object P0, System.Object P1, System.Single& P2) { }
        // RVA: 0x088B72B8  token: 0x60002E9
        public System.Single __Gen_Wrap_99(System.Object P0, System.Int32 P1, System.Single& P2) { }
        // RVA: 0x054A1120  token: 0x60002EA
        public System.Void __Gen_Wrap_100(System.Object P0, System.Single P1, System.Single P2) { }
        // RVA: 0x088B3074  token: 0x60002EB
        public System.String __Gen_Wrap_101(System.Text.RegularExpressions.Match P0) { }
        // RVA: 0x05648770  token: 0x60002EC
        public System.Void __Gen_Wrap_102(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x088B3150  token: 0x60002ED
        public System.Boolean __Gen_Wrap_103(System.Int32 P0, UnityEngine.Vector2& P1) { }
        // RVA: 0x050EF354  token: 0x60002EE
        public System.Int32 __Gen_Wrap_104(System.Object P0, System.Object P1) { }
        // RVA: 0x088B327C  token: 0x60002EF
        public System.Collections.Generic.List<Beyond.DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>>> __Gen_Wrap_105(System.Object P0) { }
        // RVA: 0x0516413C  token: 0x60002F0
        public System.Void __Gen_Wrap_106(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode P2) { }
        // RVA: 0x05160E44  token: 0x60002F1
        public System.Void __Gen_Wrap_107(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x03D06130  token: 0x60002F2
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x088B73E4  token: 0x60002F3
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x60002F4
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000047  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60002F5
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x088B894C  token: 0x60002F6
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x024AEDE0  token: 0x60002F7
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x088B8808  token: 0x60002F8
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x088B88D4  token: 0x60002F9
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x088B89B0  token: 0x60002FA
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x088B8764  token: 0x60002FB
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000048  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-get_enabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-_GetNextEnabledPriority0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-StopContinuousTrigger0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-OnGroupEnabledChanged0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-OnParentEnabledChanged0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-_OnBindingGroupStateChanged0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-SetSelfEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetNaviBindingType0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsGroupEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsNavigationBindingEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-UpdateNaviInputBindingState0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-Tick0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_RemoveLayerFromStack0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_RemoveLayer0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_OnLayerSelected0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-GetNaviVector0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_GetPointOnRectEdge0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_TryFindBestNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_TryFindBestNaviTargetInGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_DefaultNavigate0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetForceEnableNavi0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-TryAutoSetTarget0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-TryRemoveLayer0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsLayerInStack0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsTopLayer0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-ChangeAndTrySetNaviBindingType0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetTargetInSilentModeIfNecessary0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsNaviTarget0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-Navigate0;  // const
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-ToggleNavigation0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-get_normalBindingInfos0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-get_modifyBindingInfos0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-GetInputDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-OnCreateBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-OnDeleteBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-CheckDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-CheckGamepadInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-_RealTriggerCallback0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-Trigger0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-get_enabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-_TryContinuousTrigger0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-StartContinuousTrigger0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-TriggerActions0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadChecker-CheckDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-get_groupView0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-get_bindingView0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnClickChecker-CheckDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnClickChecker-ClearKeyPressed0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetPlayerActionInfo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionText0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionText1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-get_text0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-_OnTriggerBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-CreateTriggerBindingAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-CheckDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-OnCreateBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-OnDeleteBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-GetInputLongPressStartTime0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnReleaseChecker-CheckGamepadInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadOnReleaseChecker-CheckDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_SetActionCallback0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_SetAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_leftButtonAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_rightButtonAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_middleButtonAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_forwardButtonAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_backButtonAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-SetMouseIconVisible0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_OnButtonActionTriggered0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-TriggerLeftButton0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-GetModifyIndex0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-OnCreateBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AddPlayerActionCheck0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AddPlayerActionCheck1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AddPlayerActionCheck2;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBindingByActionId0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_ChangeHoverState0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-ChangeHoverState0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_SyncScale0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_UpdateMotion0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-ClearLeftButtonState0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnAfterInputUpdate0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-Update0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-GetCurHoverSelectable0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-OnDeleteBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RemovePlayerActionCheck0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RemovePlayerActionCheck1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RemovePlayerActionCheck2;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-OnDelete0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RealRemoveBindingInfo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_DeleteInGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_DeleteGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-Awake0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-ChangeGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-SetSelfEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-SetParentIgnored0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-GetCallbackTarget0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-ChangeParent0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-SetParentIgnored0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-get_groupEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-UpdateState0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-Init0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-DeleteGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-Awake0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_cursorVisible0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGamepadStickValue0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_mouseScrollDelta0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_multiTouchEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-set_multiTouchEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-_ToggleCursorInternal0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-IsNeedShowCursor0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-CalcState0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-SetForceHideCursorForController0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ToggleVirtualMouse0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckVirtualMouseState0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RefreshDeviceChangeBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_SyncUsingControllerState0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-ToggleCursorInHideCursorMode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleCursorInHideCursorMode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ChangeInputTypeAndSyncState0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_TryChangeInputDeviceType0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-set_usingController0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_action2BindingDic0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-TryClickSkillButtonWhenControllerIndicatorJustRelease0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_UpdateControllerIndicator0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateTickFunction0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnClickChecker-ClearKeyPressed0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_LoadCustomInputSetting0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_LoadSetting0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetControllerType0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_SetJoystick0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnControllerConnected0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_TryFindGamepad0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnControllerDisconnected0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateDebugVirtualMouse0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetStringByGamepadKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetGamepadKeyIconFolderPath0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetKeyIconPath0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGamepadKeyIconPath0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetKeyIconPath0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetStringByKeyboardKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetKeyIconPath1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetKeyIconPath2;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateVirtualMouse0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateCanvas0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_InitDeviceChangeBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-KeyCaches-UpdateKeyStat0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGamepadTriggerValue0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyGamepadKey0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckAnyKeyForTouchChangeDevice0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyMouseKeyUp0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AnyKeyDownForKeyboardChangeDevice0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckAnyKeyForKeyboardChangeDevice0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CheckUsingController0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-CheckKeyboardInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-TriggerActions0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ControllerTouchPanelTick0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnAfterInputUpdate0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnNetMaskChanged0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnFocusedInputFieldChanged0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_Init0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ClearTickFunction0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-Release0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ClearEvents0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-OnApplicationQuit0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-OnApplicationFocus0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-ResetCursorInHideCursorMode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ResetCursorInHideCursorMode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleInputDeviceChangeMode0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-ToggleForceShowRealCursorForChangeInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleForceShowRealCursor0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AnyKeyboardKey0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyKeyboardKey0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyMouseKeyDown0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyMouseKey0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyKeyDown0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckGamepadKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AddAnonymousPlayerAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBinding1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBinding2;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteInGroup0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsBindingEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ForceBindingKeyhintToGray0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsBindingKeyhintGray0;  // const
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-SetDebugShowCursorMode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleHideCursor0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleAllInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetBindingView0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetGroupView0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ChangeParent0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGroupParentId0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IgnoreBindingGroupParent0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IgnoreBindingParent0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionKeyboardKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionGamepadKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputUtils-HasFlag0;  // const
        public static IFix.IDMAP0 Beyond-Input-PlayerActionInfo-DeviceInputEquals0;  // const
        public static IFix.IDMAP0 Beyond-Input-PlayerActionInfo-DeviceInputCopyFrom0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteCustomBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RefreshControllerBattleButton0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteAllCustomBindings0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetBindingText0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetBindingText0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-HasBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CheckActionKeyCodeConflict0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetAxis0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetBindingInfo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-LoadSetting0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsPlayerActionIdValid0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ChangePlayerAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetOrCreatePendingActionInfo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CustomizeActionKey0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CustomizeActionKey1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ClearPendingInputSetting0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SaveCustomInputSetting0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMousePos0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetVirtualMouseIconVisible0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetMousePos0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetOnlyVirtualMousePos0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMouseButton0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsLeftMouseDown0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMouseButtonDown0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMouseButtonUp0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetCustomControllerMouse0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetEmptyControllerHintInfoList0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetControllerHintInfos0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetControllerHintInfos0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-Reset1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetControllerHintInfos1;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetControllerHintInfos1;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-GetInputLongPressStartTime0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetPlayerActionLongPressStartTime0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionBindingLongPressStartTime0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetControllerIndicatorState0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-CheckNormalAttackBtn0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-TryPressControllerIndicatorWhenSkillButtonJustPressed0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-AddGuideUseActionId0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-RemoveGuideUseActionId0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ClearGuideUseActionIds0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-VibrateController0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ParseTextActionId0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-MoveMouseTo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-MoveVirtualMouseTo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetTouchId0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetPressPosByTouchId0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-RemoveUnusedInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetCurJsInfos0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-CompareTo0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-OnAllocate0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-OnRecycle0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputUtils-IgnoreBindingParent0;  // const
        public static IFix.IDMAP0 Beyond-Input-InputUtils-IgnoreBindingGroupParent0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-get_bindingInfos0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardChecker-CheckKeyboardInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardChecker-TriggerActions0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnClickChecker-CheckKeyboardInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnClickChecker-TriggerActions0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-_OnTriggerBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-CheckKeyboardInput0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-OnCreateBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-OnDeleteBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-PlayerActionInfo-ResetHintProority0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-GetModifyText0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-GetKeyCodeText0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-GetKeyCodeEnumIntValue0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-SetKeyCodeEnumByIntValue0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-get_modifyString0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-ClearKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-CopyFrom0;  // const
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-GetModifyText0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-GetKeyCodeText0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-GetKeyCodeEnumIntValue0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-SetKeyCodeEnumByIntValue0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-ClearKeyCode0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-CopyFrom0;  // const
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-get_bindingEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-_CreatePlayerActionBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-InitBinding0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-Invoke0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-UpdateKeys0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-ChangeBindingPlayerAction0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-AddListener0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-RemoveListener0;  // const
        public static IFix.IDMAP0 Beyond-Input-UIEvent-RemoveAllListeners0;  // const

    }

}

namespace UnityEngine.InputSystem.UI
{

    // TypeToken: 0x2000003  // size: 0x128
    public class DebugVirtualMouseInput : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode m_CursorMode;  // 0x18
        private UnityEngine.UI.Graphic m_CursorGraphic;  // 0x20
        private UnityEngine.RectTransform m_CursorTransform;  // 0x28
        private UnityEngine.RectTransform _canvasTransform;  // 0x30
        private UnityEngine.Canvas m_Canvas;  // 0x38
        private System.Single m_CursorSpeed;  // 0x40
        private System.Single m_ScrollSpeed;  // 0x44
        private UnityEngine.InputSystem.InputActionProperty m_StickAction;  // 0x48
        private UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;  // 0x60
        private UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;  // 0x78
        private UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;  // 0x90
        private UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;  // 0xa8
        private UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;  // 0xc0
        private UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;  // 0xd8
        private UnityEngine.InputSystem.Mouse m_VirtualMouse;  // 0xf0
        private UnityEngine.InputSystem.Mouse m_SystemMouse;  // 0xf8
        private System.Action m_AfterInputUpdateDelegate;  // 0x100
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;  // 0x108
        private System.Double m_LastTime;  // 0x110
        private UnityEngine.Vector2 m_LastStickValue;  // 0x118
        private System.Single m_canvasScale;  // 0x120

        // Properties
        UnityEngine.RectTransform cursorTransform { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        System.Single cursorSpeed { get; /* RVA: 0x03D4EC70 */ set; /* RVA: 0x03D4ECF0 */ }
        UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode cursorMode { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x088AB968 */ }
        UnityEngine.UI.Graphic cursorGraphic { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x088AB944 */ }
        System.Single scrollSpeed { get; /* RVA: 0x03D4EC80 */ set; /* RVA: 0x03D4ED00 */ }
        UnityEngine.InputSystem.Mouse virtualMouse { get; /* RVA: 0x03D51950 */ }
        UnityEngine.InputSystem.InputActionProperty stickAction { get; /* RVA: 0x03D5D670 */ set; /* RVA: 0x088ABD44 */ }
        UnityEngine.InputSystem.InputActionProperty leftButtonAction { get; /* RVA: 0x03D5D690 */ set; /* RVA: 0x088ABB04 */ }
        UnityEngine.InputSystem.InputActionProperty rightButtonAction { get; /* RVA: 0x03D68BE0 */ set; /* RVA: 0x088ABC5C */ }
        UnityEngine.InputSystem.InputActionProperty middleButtonAction { get; /* RVA: 0x03D6DB80 */ set; /* RVA: 0x088ABBAC */ }
        UnityEngine.InputSystem.InputActionProperty forwardButtonAction { get; /* RVA: 0x03D6DB60 */ set; /* RVA: 0x088ABA4C */ }
        UnityEngine.InputSystem.InputActionProperty backButtonAction { get; /* RVA: 0x03D6DB40 */ set; /* RVA: 0x088AB88C */ }
        UnityEngine.InputSystem.InputActionProperty scrollWheelAction { get; /* RVA: 0x03D6DBA0 */ set; /* RVA: 0x088ABD14 */ }

        // Methods
        // RVA: 0x088AA980  token: 0x600001B
        protected System.Void OnEnable() { }
        // RVA: 0x088AA6E4  token: 0x600001C
        protected System.Void OnDisable() { }
        // RVA: 0x088AB43C  token: 0x600001D
        private System.Void _TryFindCanvas() { }
        // RVA: 0x088AB244  token: 0x600001E
        private System.Void _TryEnableHardwareCursor() { }
        // RVA: 0x088AB144  token: 0x600001F
        private System.Void _SyncScale() { }
        // RVA: 0x088AB498  token: 0x6000020
        private System.Void _UpdateMotion() { }
        // RVA: 0x088AADB0  token: 0x6000021
        private System.Void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        // RVA: 0x088AAFE0  token: 0x6000022
        private static System.Void _SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install) { }
        // RVA: 0x088AB04C  token: 0x6000023
        private static System.Void _SetAction(UnityEngine.InputSystem.InputActionProperty& field, UnityEngine.InputSystem.InputActionProperty value) { }
        // RVA: 0x088AADA8  token: 0x6000024
        private System.Void _OnAfterInputUpdate() { }
        // RVA: 0x03D42B50  token: 0x6000025
        public System.Void .ctor() { }

    }

}

