// ========================================================
// Dumped by @desirepro
// Assembly: CW.Common.dll
// Classes:  34
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct LinkType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static CW.Common.CwDemoButton.LinkType PreviousScene;  // const
        public static CW.Common.CwDemoButton.LinkType NextScene;  // const
        public static CW.Common.CwDemoButton.LinkType Publisher;  // const
        public static CW.Common.CwDemoButton.LinkType URL;  // const
        public static CW.Common.CwDemoButton.LinkType Isolate;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct ToggleType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static CW.Common.CwDemoButton.ToggleType KeepSelected;  // const
        public static CW.Common.CwDemoButton.ToggleType ToggleSelection;  // const
        public static CW.Common.CwDemoButton.ToggleType SelectPrevious;  // const

    }

    // TypeToken: 0x200000D
    public interface IHasChildren
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600007D
        public virtual System.Boolean HasChild(CW.Common.CwChild child) { }

    }

    // TypeToken: 0x2000010  // size: 0x14
    public sealed struct FollowType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static CW.Common.CwFollow.FollowType TargetTransform;  // const
        public static CW.Common.CwFollow.FollowType MainCamera;  // const

    }

    // TypeToken: 0x2000011  // size: 0x14
    public sealed struct UpdateType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static CW.Common.CwFollow.UpdateType Update;  // const
        public static CW.Common.CwFollow.UpdateType LateUpdate;  // const

    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct AxisGesture
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static CW.Common.CwInputManager.AxisGesture HorizontalDrag;  // const
        public static CW.Common.CwInputManager.AxisGesture VerticalDrag;  // const
        public static CW.Common.CwInputManager.AxisGesture Twist;  // const
        public static CW.Common.CwInputManager.AxisGesture HorizontalPull;  // const
        public static CW.Common.CwInputManager.AxisGesture VerticalPull;  // const

    }

    // TypeToken: 0x2000014  // size: 0x34
    public sealed struct Axis
    {
        // Fields
        public System.Int32 FingerCount;  // 0x10
        public System.Boolean FingerInvert;  // 0x14
        public CW.Common.CwInputManager.AxisGesture FingerGesture;  // 0x18
        public System.Single FingerSensitivity;  // 0x1c
        public UnityEngine.KeyCode KeyNegative;  // 0x20
        public UnityEngine.KeyCode KeyPositive;  // 0x24
        public UnityEngine.KeyCode KeyNegativeAlt;  // 0x28
        public UnityEngine.KeyCode KeyPositiveAlt;  // 0x2c
        public System.Single KeySensitivity;  // 0x30

        // Methods
        // RVA: 0x03D520F0  token: 0x60000B3
        public System.Void .ctor(System.Int32 fCount, System.Boolean fInvert, CW.Common.CwInputManager.AxisGesture fGesture, System.Single fSensitivty, UnityEngine.KeyCode kNegative, UnityEngine.KeyCode kPositive, UnityEngine.KeyCode kNegativeAlt, UnityEngine.KeyCode kPositiveAlt, System.Single kSensitivity) { }
        // RVA: 0x056EDD38  token: 0x60000B4
        public System.Single GetValue(System.Single delta) { }

    }

    // TypeToken: 0x2000015  // size: 0x18
    public sealed struct Trigger
    {
        // Fields
        public System.Boolean UseFinger;  // 0x10
        public System.Boolean UseMouse;  // 0x11
        public UnityEngine.KeyCode UseKey;  // 0x14

        // Methods
        // RVA: 0x03D52540  token: 0x60000B5
        public System.Void .ctor(System.Boolean uFinger, System.Boolean uMouse, UnityEngine.KeyCode uKey) { }
        // RVA: 0x056F56C0  token: 0x60000B6
        public System.Boolean WentDown(CW.Common.CwInputManager.Finger finger) { }
        // RVA: 0x056F5620  token: 0x60000B7
        public System.Boolean IsDown(CW.Common.CwInputManager.Finger finger) { }
        // RVA: 0x056F5760  token: 0x60000B8
        public System.Boolean WentUp(CW.Common.CwInputManager.Finger finger, System.Boolean useAnyFinger) { }

    }

    // TypeToken: 0x2000016  // size: 0x18
    public abstract class Link
    {
        // Fields
        public CW.Common.CwInputManager.Finger Finger;  // 0x10

        // Methods
        // RVA: -1  // generic def  token: 0x60000B9
        public static T Find(System.Collections.Generic.List<T> links, CW.Common.CwInputManager.Finger finger) { }
        // RVA: -1  // generic def  token: 0x60000BA
        public static T Create(System.Collections.Generic.List<T>& links, CW.Common.CwInputManager.Finger finger) { }
        // RVA: -1  // generic def  token: 0x60000BB
        public static System.Void ClearAll(System.Collections.Generic.List<T> links) { }
        // RVA: -1  // generic def  token: 0x60000BC
        public static System.Void ClearAndRemove(System.Collections.Generic.List<T> links, T link) { }
        // RVA: 0x0350B670  token: 0x60000BD
        public virtual System.Void Clear() { }
        // RVA: 0x0350B670  token: 0x60000BE
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x50
    public class Finger
    {
        // Fields
        public System.Int32 Index;  // 0x10
        public System.Single Pressure;  // 0x14
        public System.Boolean Down;  // 0x18
        public System.Boolean Up;  // 0x19
        public System.Single Age;  // 0x1c
        public System.Boolean StartedOverGui;  // 0x20
        public UnityEngine.Vector2 StartScreenPosition;  // 0x24
        public UnityEngine.Vector2 ScreenPosition;  // 0x2c
        public UnityEngine.Vector2 ScreenPositionOld;  // 0x34
        public UnityEngine.Vector2 ScreenPositionOldOld;  // 0x3c
        public UnityEngine.Vector2 ScreenPositionOldOldOld;  // 0x44

        // Properties
        System.Single SmoothScreenPositionDelta { get; /* RVA: 0x056F5584 */ }

        // Methods
        // RVA: 0x056F5448  token: 0x60000C0
        public UnityEngine.Vector2 GetSmoothScreenPosition(System.Single t) { }
        // RVA: 0x0350B670  token: 0x60000C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly CW.Common.CwHelper.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x056F5A10  token: 0x6000108
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000109
        public System.Void .ctor() { }
        // RVA: 0x056F5820  token: 0x600010A
        private System.Void <.cctor>b__11_0(UnityEngine.Camera camera) { }
        // RVA: 0x056F589C  token: 0x600010B
        private System.Void <.cctor>b__11_1(UnityEngine.Camera camera) { }
        // RVA: 0x056F5918  token: 0x600010C
        private System.Void <.cctor>b__11_2(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera) { }
        // RVA: 0x056F5994  token: 0x600010D
        private System.Void <.cctor>b__11_3(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera) { }

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct Pipeline
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static CW.Common.CwShaderBundle.Pipeline Invalid;  // const
        public static CW.Common.CwShaderBundle.Pipeline Standard;  // const
        public static CW.Common.CwShaderBundle.Pipeline URP2019;  // const
        public static CW.Common.CwShaderBundle.Pipeline URP2020;  // const
        public static CW.Common.CwShaderBundle.Pipeline URP2021;  // const
        public static CW.Common.CwShaderBundle.Pipeline HDRP2019;  // const
        public static CW.Common.CwShaderBundle.Pipeline HDRP2020;  // const
        public static CW.Common.CwShaderBundle.Pipeline HDRP2021;  // const
        public static CW.Common.CwShaderBundle.Pipeline COUNT;  // const

    }

    // TypeToken: 0x2000022  // size: 0x28
    public class ShaderVariant
    {
        // Fields
        public CW.Common.CwShaderBundle.Pipeline Pipe;  // 0x10
        public System.String Code;  // 0x18
        public System.Int32 Hash;  // 0x20
        public System.Boolean Dirty;  // 0x24

        // Properties
        System.String HashString { get; /* RVA: 0x056F55C4 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000130
        public System.Void .ctor() { }

    }

namespace CW.Common
{

    // TypeToken: 0x2000002  // size: 0xA0
    public class CwCameraLook : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean listen;  // 0x18
        private System.Single damping;  // 0x1c
        private System.Single sensitivity;  // 0x20
        private CW.Common.CwInputManager.Axis pitchControls;  // 0x24
        private CW.Common.CwInputManager.Axis yawControls;  // 0x48
        private CW.Common.CwInputManager.Axis rollControls;  // 0x6c
        private UnityEngine.Quaternion remainingDelta;  // 0x90

        // Properties
        System.Boolean Listen { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Single Damping { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }
        System.Single Sensitivity { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x03D4F2F0 */ }
        CW.Common.CwInputManager.Axis PitchControls { get; /* RVA: 0x03D52130 */ set; /* RVA: 0x03D52190 */ }
        CW.Common.CwInputManager.Axis YawControls { get; /* RVA: 0x03D52170 */ set; /* RVA: 0x03D521D0 */ }
        CW.Common.CwInputManager.Axis RollControls { get; /* RVA: 0x03D52150 */ set; /* RVA: 0x03D521B0 */ }

        // Methods
        // RVA: 0x056EE38C  token: 0x600000D
        protected virtual System.Void Start() { }
        // RVA: 0x0350B670  token: 0x600000E
        protected virtual System.Void OnDisable() { }
        // RVA: 0x056EE3CC  token: 0x600000F
        protected virtual System.Void Update() { }
        // RVA: 0x0350B670  token: 0x6000010
        protected virtual System.Void OnApplicationFocus(System.Boolean focus) { }
        // RVA: 0x056EE008  token: 0x6000011
        private System.Void AddToDelta() { }
        // RVA: 0x056EE214  token: 0x6000012
        private System.Void DampenDelta() { }
        // RVA: 0x056EE3F4  token: 0x6000013
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000003  // size: 0xA0
    public class CwCameraMove : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean listen;  // 0x18
        private System.Single damping;  // 0x1c
        private System.Single sensitivity;  // 0x20
        private CW.Common.CwInputManager.Axis horizontalControls;  // 0x24
        private CW.Common.CwInputManager.Axis depthControls;  // 0x48
        private CW.Common.CwInputManager.Axis verticalControls;  // 0x6c
        private UnityEngine.Vector3 remainingDelta;  // 0x90

        // Properties
        System.Boolean Listen { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Single Damping { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }
        System.Single Sensitivity { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x03D4F2F0 */ }
        CW.Common.CwInputManager.Axis HorizontalControls { get; /* RVA: 0x03D52130 */ set; /* RVA: 0x03D52190 */ }
        CW.Common.CwInputManager.Axis DepthControls { get; /* RVA: 0x03D52170 */ set; /* RVA: 0x03D521D0 */ }
        CW.Common.CwInputManager.Axis VerticalControls { get; /* RVA: 0x03D52150 */ set; /* RVA: 0x03D521B0 */ }

        // Methods
        // RVA: 0x056EE88C  token: 0x6000020
        protected virtual System.Void Start() { }
        // RVA: 0x056EE8CC  token: 0x6000021
        protected virtual System.Void Update() { }
        // RVA: 0x056EE4D8  token: 0x6000022
        private System.Void AddToDelta() { }
        // RVA: 0x056EE6FC  token: 0x6000023
        private System.Void DampenDelta() { }
        // RVA: 0x056EE8F4  token: 0x6000024
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x78
    public class CwCameraPivot : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean listen;  // 0x18
        private System.Single damping;  // 0x1c
        private CW.Common.CwInputManager.Axis pitchControls;  // 0x20
        private CW.Common.CwInputManager.Axis yawControls;  // 0x44
        private UnityEngine.Vector3 remainingDelta;  // 0x68

        // Properties
        System.Boolean Listen { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Single Damping { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }
        CW.Common.CwInputManager.Axis PitchControls { get; /* RVA: 0x03D521F0 */ set; /* RVA: 0x03D52230 */ }
        CW.Common.CwInputManager.Axis YawControls { get; /* RVA: 0x03D52210 */ set; /* RVA: 0x03D52250 */ }

        // Methods
        // RVA: 0x056EEC10  token: 0x600002D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x056EEC50  token: 0x600002E
        protected virtual System.Void Update() { }
        // RVA: 0x056EE9D0  token: 0x600002F
        private System.Void AddToDelta() { }
        // RVA: 0x056EEA34  token: 0x6000030
        private System.Void DampenDelta() { }
        // RVA: 0x056EEC78  token: 0x6000031
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x20
    public class CwDemo : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean upgradeInputModule;  // 0x18
        private System.Boolean changeExposureInHDRP;  // 0x19
        private System.Boolean changeVisualEnvironmentInHDRP;  // 0x1a
        private System.Boolean changeFogInHDRP;  // 0x1b
        private System.Boolean changeCloudsInHDRP;  // 0x1c
        private System.Boolean changeMotionBlurInHDRP;  // 0x1d
        private System.Boolean upgradeLightsInHDRP;  // 0x1e
        private System.Boolean upgradeCamerasInHDRP;  // 0x1f

        // Properties
        System.Boolean UpgradeInputModule { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Boolean ChangeExposureInHDRP { get; /* RVA: 0x03D4EF80 */ set; /* RVA: 0x03D4EFB0 */ }
        System.Boolean ChangeVisualEnvironmentInHDRP { get; /* RVA: 0x03D4EFA0 */ set; /* RVA: 0x03D4EFD0 */ }
        System.Boolean ChangeFogInHDRP { get; /* RVA: 0x03D52270 */ set; /* RVA: 0x03D522A0 */ }
        System.Boolean ChangeCloudsInHDRP { get; /* RVA: 0x03D4E9A0 */ set; /* RVA: 0x03D4E9B0 */ }
        System.Boolean ChangeMotionBlurInHDRP { get; /* RVA: 0x03D50D90 */ set; /* RVA: 0x03D522B0 */ }
        System.Boolean UpgradeLightsInHDRP { get; /* RVA: 0x03D52290 */ set; /* RVA: 0x03D522D0 */ }
        System.Boolean UpgradeCamerasInHDRP { get; /* RVA: 0x03D52280 */ set; /* RVA: 0x03D522C0 */ }

        // Methods
        // RVA: 0x056EF894  token: 0x6000042
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0350B670  token: 0x6000043
        protected virtual System.Void TryApplyURP() { }
        // RVA: 0x03D4B9D0  token: 0x6000044
        protected virtual System.Void TryApplyHDRP() { }
        // RVA: 0x0350B670  token: 0x6000045
        private System.Void TryCreateVolume() { }
        // RVA: 0x0350B670  token: 0x6000046
        private System.Void TryUpgradeLights() { }
        // RVA: 0x0350B670  token: 0x6000047
        private System.Void TryUpgradeCameras() { }
        // RVA: 0x0350B670  token: 0x6000048
        private System.Void TryUpgradeEventSystem() { }
        // RVA: 0x056EF8A4  token: 0x6000049
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x48
    public class CwDemoButton : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        // Fields
        private CW.Common.CwDemoButton.LinkType link;  // 0x18
        private System.String urlTarget;  // 0x20
        private UnityEngine.Transform isolateTarget;  // 0x28
        private CW.Common.CwDemoButton.ToggleType isolateToggle;  // 0x30
        private UnityEngine.CanvasGroup cachedCanvasGroup;  // 0x38
        private UnityEngine.Transform previousChild;  // 0x40

        // Properties
        CW.Common.CwDemoButton.LinkType Link { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.String UrlTarget { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        UnityEngine.Transform IsolateTarget { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        CW.Common.CwDemoButton.ToggleType IsolateToggle { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }

        // Methods
        // RVA: 0x056EF1C4  token: 0x6000052
        protected virtual System.Void OnEnable() { }
        // RVA: 0x056EF74C  token: 0x6000053
        protected virtual System.Void Update() { }
        // RVA: 0x056EF20C  token: 0x6000054
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x056EF0C8  token: 0x6000055
        private static System.Int32 GetCurrentLevel() { }
        // RVA: 0x056EF13C  token: 0x6000056
        private static System.Int32 GetLevelCount() { }
        // RVA: 0x056EF17C  token: 0x6000057
        private static System.Void LoadLevel(System.Int32 index) { }
        // RVA: 0x0426FE60  token: 0x6000058
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x50
    public class CwDemoButtonBuilder : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject buttonPrefab;  // 0x18
        private UnityEngine.RectTransform buttonRoot;  // 0x20
        private UnityEngine.Sprite icon;  // 0x28
        private UnityEngine.Color color;  // 0x30
        private System.String overrideName;  // 0x40
        private UnityEngine.GameObject clone;  // 0x48

        // Properties
        UnityEngine.GameObject ButtonPrefab { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.RectTransform ButtonRoot { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        UnityEngine.Sprite Icon { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        UnityEngine.Color Color { get; /* RVA: 0x03D4FD30 */ set; /* RVA: 0x03D4FD40 */ }
        System.String OverrideName { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }

        // Methods
        // RVA: 0x056EEE14  token: 0x6000063
        public System.Void Build() { }
        // RVA: 0x056EED7C  token: 0x6000064
        public System.Void BuildAll() { }
        // RVA: 0x056EF038  token: 0x6000065
        private UnityEngine.GameObject DoInstantiate() { }
        // RVA: 0x056EF0A0  token: 0x6000066
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x38
    public class CwLightIntensity : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Single multiplier;  // 0x18
        private System.Single intensityInStandard;  // 0x1c
        private System.Single intensityInURP;  // 0x20
        private System.Single intensityInHDRP;  // 0x24
        private UnityEngine.Light cachedLight;  // 0x28
        private System.Boolean cachedLightSet;  // 0x30

        // Properties
        System.Single Multiplier { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x03D4EC00 */ }
        System.Single IntensityInStandard { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }
        System.Single IntensityInURP { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x03D4F2F0 */ }
        System.Single IntensityInHDRP { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x03D52500 */ }
        UnityEngine.Light CachedLight { get; /* RVA: 0x056F4B04 */ }

        // Methods
        // RVA: 0x056F4A80  token: 0x6000070
        protected virtual System.Void Update() { }
        // RVA: 0x056F49F8  token: 0x6000071
        private System.Void ApplyIntensity(System.Single intensity) { }
        // RVA: 0x056F4AE0  token: 0x6000072
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x28
    public class CwRotate : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 angularVelocity;  // 0x18
        private UnityEngine.Space relativeTo;  // 0x24

        // Properties
        UnityEngine.Vector3 AngularVelocity { get; /* RVA: 0x03D52510 */ set; /* RVA: 0x03D52530 */ }
        UnityEngine.Space RelativeTo { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }

        // Methods
        // RVA: 0x056F50B4  token: 0x6000077
        protected virtual System.Void Update() { }
        // RVA: 0x056F5148  token: 0x6000078
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public abstract class CwChild : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x056EED00  token: 0x6000079
        public System.Void DestroyGameObjectIfInvalid() { }
        // RVA: -1  // abstract  token: 0x600007A
        protected virtual CW.Common.CwChild.IHasChildren GetParent() { }
        // RVA: 0x0350B670  token: 0x600007B
        protected virtual System.Void Start() { }
        // RVA: 0x0426FE60  token: 0x600007C
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x28
    public class CwDepthTextureMode : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.DepthTextureMode depthMode;  // 0x18
        private UnityEngine.Camera cachedCamera;  // 0x20

        // Properties
        UnityEngine.DepthTextureMode DepthMode { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x056EF95C */ }

        // Methods
        // RVA: 0x056EF8BC  token: 0x6000080
        public System.Void UpdateDepthMode() { }
        // RVA: 0x056EF954  token: 0x6000081
        protected virtual System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x6000082
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x50
    public class CwFollow : UnityEngine.MonoBehaviour
    {
        // Fields
        private CW.Common.CwFollow.FollowType follow;  // 0x18
        private UnityEngine.Transform target;  // 0x20
        private System.Single damping;  // 0x28
        private System.Boolean rotate;  // 0x2c
        private System.Boolean ignoreZ;  // 0x2d
        private CW.Common.CwFollow.UpdateType followIn;  // 0x30
        private UnityEngine.Vector3 localPosition;  // 0x34
        private UnityEngine.Vector3 localRotation;  // 0x40

        // Properties
        CW.Common.CwFollow.FollowType Follow { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        UnityEngine.Transform Target { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Single Damping { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x03D4F490 */ }
        System.Boolean Rotate { get; /* RVA: 0x03D4F1A0 */ set; /* RVA: 0x03D4F1B0 */ }
        System.Boolean IgnoreZ { get; /* RVA: 0x03D4F4C0 */ set; /* RVA: 0x03D4F4F0 */ }
        CW.Common.CwFollow.UpdateType FollowIn { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }
        UnityEngine.Vector3 LocalPosition { get; /* RVA: 0x03D522E0 */ set; /* RVA: 0x03D52320 */ }
        UnityEngine.Vector3 LocalRotation { get; /* RVA: 0x03D52300 */ set; /* RVA: 0x03D52330 */ }

        // Methods
        // RVA: 0x056EF978  token: 0x6000093
        public System.Void UpdatePosition() { }
        // RVA: 0x056EFC38  token: 0x6000094
        protected virtual System.Void Update() { }
        // RVA: 0x056EF968  token: 0x6000095
        protected virtual System.Void LateUpdate() { }
        // RVA: 0x056EFC48  token: 0x6000096
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x20
    public class CwInputManager : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.LayerMask guiLayers;  // 0x18
        private static System.Action<CW.Common.CwInputManager.Finger> OnFingerDown;  // static @ 0x0
        private static System.Action<CW.Common.CwInputManager.Finger> OnFingerUpdate;  // static @ 0x8
        private static System.Action<CW.Common.CwInputManager.Finger> OnFingerUp;  // static @ 0x10
        public static System.Int32 MOUSE_FINGER_INDEX;  // const
        public static System.Int32 HOVER_FINGER_INDEX;  // const
        private static System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> tempRaycastResults;  // static @ 0x18
        private static UnityEngine.EventSystems.PointerEventData tempPointerEventData;  // static @ 0x20
        private static UnityEngine.EventSystems.EventSystem tempEventSystem;  // static @ 0x28
        private static System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers;  // static @ 0x30
        private static System.Collections.Generic.List<CW.Common.CwInputManager.Finger> filteredFingers;  // static @ 0x38
        private static System.Collections.Generic.Stack<CW.Common.CwInputManager.Finger> pool;  // static @ 0x40

        // Properties
        UnityEngine.LayerMask GuiLayers { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Collections.Generic.List<CW.Common.CwInputManager.Finger> Fingers { get; /* RVA: 0x056F40B0 */ }
        System.Single ScaleFactor { get; /* RVA: 0x056F4100 */ }

        // Events
        event System.Action<CW.Common.CwInputManager.Finger> OnFingerDown;
        event System.Action<CW.Common.CwInputManager.Finger> OnFingerUpdate;
        event System.Action<CW.Common.CwInputManager.Finger> OnFingerUp;

        // Methods
        // RVA: 0x056F302C  token: 0x60000A1
        public static System.Collections.Generic.List<CW.Common.CwInputManager.Finger> GetFingers(System.Boolean ignoreStartedOverGui, System.Boolean ignoreHover) { }
        // RVA: 0x056F3350  token: 0x60000A2
        public static System.Boolean PointOverGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers) { }
        // RVA: 0x056F33C4  token: 0x60000A3
        public static System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> RaycastGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers) { }
        // RVA: 0x056F29AC  token: 0x60000A4
        public static UnityEngine.Vector2 GetAveragePosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        // RVA: 0x056F27F0  token: 0x60000A5
        public static UnityEngine.Vector2 GetAverageOldPosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        // RVA: 0x056F2B68  token: 0x60000A6
        public static UnityEngine.Vector2 GetAveragePullScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        // RVA: 0x056F25F8  token: 0x60000A7
        public static UnityEngine.Vector2 GetAverageDeltaScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        // RVA: 0x056F2D60  token: 0x60000A8
        public static System.Single GetAverageTwistRadians(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        // RVA: 0x056F23A8  token: 0x60000A9
        public static System.Void EnsureThisComponentExists() { }
        // RVA: 0x056F375C  token: 0x60000AA
        protected virtual System.Void Update() { }
        // RVA: 0x056F24B8  token: 0x60000AB
        private CW.Common.CwInputManager.Finger FindFinger(System.Int32 index) { }
        // RVA: 0x056F2184  token: 0x60000AC
        private System.Void AddFinger(System.Int32 index, UnityEngine.Vector2 screenPosition, System.Single pressure, System.Boolean set) { }
        // RVA: 0x056F3240  token: 0x60000AD
        private static UnityEngine.Vector2 Hermite(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, System.Single t) { }
        // RVA: 0x03D523D0  token: 0x60000AE
        private static System.Single HermiteInterpolate(System.Single y0, System.Single y1, System.Single y2, System.Single y3, System.Single mu, System.Single mu2, System.Single mu3) { }
        // RVA: 0x03D523A0  token: 0x60000AF
        private static System.Single GetRadians(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 referencePoint) { }
        // RVA: 0x056F2F44  token: 0x60000B0
        private static System.Single GetDeltaRadians(CW.Common.CwInputManager.Finger finger, UnityEngine.Vector2 referencePoint, UnityEngine.Vector2 lastReferencePoint) { }
        // RVA: 0x056F3E4C  token: 0x60000B1
        public System.Void .ctor() { }
        // RVA: 0x056F3C94  token: 0x60000B2
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x20
    public class CwRenderTextureManager : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Int32 lifetime;  // 0x18

        // Properties
        System.Int32 Lifetime { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x056F4B5C  token: 0x60000C4
        public static UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc, System.String title) { }
        // RVA: 0x056F4C0C  token: 0x60000C5
        public static UnityEngine.RenderTexture ReleaseTemporary(UnityEngine.RenderTexture renderTexture) { }
        // RVA: 0x056F4C78  token: 0x60000C6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x18
    public class CwRoot : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.List<CW.Common.CwRoot> instances;  // static @ 0x0

        // Properties
        System.Boolean Exists { get; /* RVA: 0x056F4FA8 */ }
        UnityEngine.Transform Root { get; /* RVA: 0x056F5008 */ }

        // Methods
        // RVA: 0x056F4C88  token: 0x60000C9
        public static UnityEngine.Transform GetRoot() { }
        // RVA: 0x056F4E00  token: 0x60000CA
        protected virtual System.Void OnEnable() { }
        // RVA: 0x056F4D90  token: 0x60000CB
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0426FE60  token: 0x60000CC
        public System.Void .ctor() { }
        // RVA: 0x056F4F1C  token: 0x60000CD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x10
    public class CwSeedAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60000CE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x10
    public static class CwShared
    {
        // Fields
        public static System.String HelpUrlPrefix;  // const
        public static System.String ComponentMenuPrefix;  // const
        public static System.String GameObjectMenuPrefix;  // const

    }

    // TypeToken: 0x200001C  // size: 0x40
    public class CwGuide : UnityEngine.ScriptableObject
    {
        // Fields
        public System.String LongName;  // 0x18
        public System.String ShortName;  // 0x20
        public UnityEngine.TextAsset Documentation;  // 0x28
        private UnityEngine.Texture2D icon;  // 0x30
        private System.String version;  // 0x38

        // Properties
        UnityEngine.Texture2D Icon { get; /* RVA: 0x056EFC64 */ }
        System.String Version { get; /* RVA: 0x056EFD48 */ }

        // Methods
        // RVA: 0x0286F540  token: 0x60000D1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x10
    public static class CwHelper
    {
        // Fields
        private static System.Collections.Generic.Stack<UnityEngine.Random.State> seedStates;  // static @ 0x0
        public static System.Collections.Generic.List<UnityEngine.Material> tempMaterials;  // static @ 0x8
        public static System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> tempProperties;  // static @ 0x10
        private static System.Action<UnityEngine.Camera> OnCameraPreRender;  // static @ 0x18
        private static System.Action<UnityEngine.Camera> OnCameraPostRender;  // static @ 0x20
        private static System.Collections.Generic.Stack<UnityEngine.RenderTexture> actives;  // static @ 0x28
        private static System.Int32 uniqueSeed;  // static @ 0x30
        private static System.Collections.Generic.List<UnityEngine.Material> materials;  // static @ 0x38

        // Events
        event System.Action<UnityEngine.Camera> OnCameraPreRender;
        event System.Action<UnityEngine.Camera> OnCameraPostRender;

        // Methods
        // RVA: 0x056F1990  token: 0x60000D6
        private static System.Void .cctor() { }
        // RVA: -1  // generic def  token: 0x60000D7
        public static T GetOrAddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo) { }
        // RVA: -1  // generic def  token: 0x60000D8
        public static T AddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo) { }
        // RVA: 0x056F0EC8  token: 0x60000D9
        public static System.Boolean IndexInMask(System.Int32 index, System.Int32 mask) { }
        // RVA: 0x056F0B0C  token: 0x60000DA
        public static UnityEngine.Camera GetCamera(UnityEngine.Camera currentCamera, UnityEngine.GameObject gameObject) { }
        // RVA: 0x056F0BD0  token: 0x60000DB
        public static UnityEngine.Vector3 GetObserverPosition(UnityEngine.Transform observer) { }
        // RVA: 0x056F09B4  token: 0x60000DC
        public static System.Boolean Enabled(UnityEngine.Behaviour b) { }
        // RVA: 0x056F0290  token: 0x60000DD
        public static System.Void BeginSeed() { }
        // RVA: 0x056F01F8  token: 0x60000DE
        public static System.Void BeginSeed(System.Int32 newSeed) { }
        // RVA: 0x056F0A88  token: 0x60000DF
        public static System.Void EndSeed() { }
        // RVA: 0x056F0314  token: 0x60000E0
        public static UnityEngine.Color Brighten(UnityEngine.Color color, System.Single brightness, System.Boolean convertToGamma) { }
        // RVA: 0x03D52360  token: 0x60000E1
        public static UnityEngine.Color Premultiply(UnityEngine.Color color) { }
        // RVA: 0x056F13C8  token: 0x60000E2
        public static System.Single Saturate(System.Single c) { }
        // RVA: 0x056F13F4  token: 0x60000E3
        public static UnityEngine.Color Saturate(UnityEngine.Color c) { }
        // RVA: -1  // generic def  token: 0x60000E4
        public static System.Void Resize(System.Collections.Generic.List<T> list, System.Int32 size) { }
        // RVA: 0x056F1800  token: 0x60000E5
        public static System.Single Sharpness(System.Single a, System.Single p) { }
        // RVA: 0x056F18C4  token: 0x60000E6
        public static UnityEngine.Color ToLinear(UnityEngine.Color gamma) { }
        // RVA: 0x056F1908  token: 0x60000E7
        public static System.Single ToLinear(System.Single gamma) { }
        // RVA: 0x056F1880  token: 0x60000E8
        public static UnityEngine.Color ToGamma(UnityEngine.Color linear) { }
        // RVA: 0x056F184C  token: 0x60000E9
        public static System.Single ToGamma(System.Single linear) { }
        // RVA: 0x056F193C  token: 0x60000EA
        public static System.Single UniformScale(UnityEngine.Vector3 scale) { }
        // RVA: 0x056F016C  token: 0x60000EB
        public static System.Void BeginActive(UnityEngine.RenderTexture renderTexture) { }
        // RVA: 0x056F0A18  token: 0x60000EC
        public static System.Void EndActive() { }
        // RVA: 0x056F1484  token: 0x60000ED
        public static System.Void SetTempMaterial(UnityEngine.Material material) { }
        // RVA: 0x056F1550  token: 0x60000EE
        public static System.Void SetTempMaterial(UnityEngine.Material material1, UnityEngine.Material material2) { }
        // RVA: 0x056F1654  token: 0x60000EF
        public static System.Void SetTempMaterial(System.Collections.Generic.List<UnityEngine.Material> materials) { }
        // RVA: 0x056F1734  token: 0x60000F0
        public static System.Void SetTempMaterial(UnityEngine.MaterialPropertyBlock properties) { }
        // RVA: 0x056EFF1C  token: 0x60000F1
        public static System.Void AddMaterial(UnityEngine.Renderer r, UnityEngine.Material m) { }
        // RVA: 0x056F1144  token: 0x60000F2
        public static System.Void ReplaceMaterial(UnityEngine.Renderer r, UnityEngine.Material m) { }
        // RVA: 0x056F0F4C  token: 0x60000F3
        public static System.Void RemoveMaterial(UnityEngine.Renderer r, UnityEngine.Material m) { }
        // RVA: 0x056F0810  token: 0x60000F4
        public static UnityEngine.Texture2D CreateTempTexture2D(System.String name, System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mips, System.Boolean linear) { }
        // RVA: 0x056F06B0  token: 0x60000F5
        public static UnityEngine.Material CreateTempMaterial(System.String materialName, System.String shaderName) { }
        // RVA: 0x056F0784  token: 0x60000F6
        public static UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Shader shader) { }
        // RVA: 0x056F0624  token: 0x60000F7
        public static UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Material source) { }
        // RVA: -1  // generic def  token: 0x60000F8
        public static T Destroy(T o) { }
        // RVA: 0x056F051C  token: 0x60000F9
        public static UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, System.String recordUndo) { }
        // RVA: 0x056F03C4  token: 0x60000FA
        public static UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, UnityEngine.Vector3 localScale, System.String recordUndo) { }
        // RVA: -1  // generic def  token: 0x60000FB
        public static T CreateElement(UnityEngine.Transform parent) { }
        // RVA: 0x056F0F14  token: 0x60000FC
        public static System.Single Reciprocal(System.Single v) { }
        // RVA: 0x056F0F30  token: 0x60000FD
        public static System.Double Reciprocal(System.Double v) { }
        // RVA: 0x056F098C  token: 0x60000FE
        public static System.Single Divide(System.Single a, System.Single b) { }
        // RVA: 0x056F09A0  token: 0x60000FF
        public static System.Double Divide(System.Double a, System.Double b) { }
        // RVA: 0x056EFEB0  token: 0x6000100
        public static System.Single Acos(System.Single v) { }
        // RVA: 0x056EFE44  token: 0x6000101
        public static System.Double Acos(System.Double v) { }
        // RVA: 0x056F0944  token: 0x6000102
        public static System.Single DampenFactor(System.Single speed, System.Single elapsed) { }
        // RVA: 0x056F08CC  token: 0x6000103
        public static System.Single DampenFactor(System.Single damping, System.Single deltaTime, System.Single linear) { }
        // RVA: 0x03D52340  token: 0x6000104
        public static System.Single Atan2(UnityEngine.Vector2 xy) { }
        // RVA: 0x056F0ED8  token: 0x6000105
        public static System.Int32 Mod(System.Int32 a, System.Int32 b) { }
        // RVA: 0x056F0EEC  token: 0x6000106
        public static System.Single Mod(System.Single a, System.Single b) { }
        // RVA: 0x056F0C9C  token: 0x6000107
        public static UnityEngine.Texture2D GetReadableCopy(UnityEngine.Texture texture, UnityEngine.TextureFormat format, System.Boolean mipMaps, System.Int32 width, System.Int32 height) { }

    }

    // TypeToken: 0x200001F  // size: 0x10
    public static class CwInput
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.KeyCode,UnityEngine.InputSystem.Key> keyMapping;  // static @ 0x0

        // Methods
        // RVA: 0x0235C360  token: 0x600010E
        private static System.Void Enable() { }
        // RVA: 0x056F45DC  token: 0x600010F
        private static UnityEngine.InputSystem.Controls.ButtonControl GetMouseButtonControl(System.Int32 index) { }
        // RVA: 0x056F4380  token: 0x6000110
        private static UnityEngine.InputSystem.Controls.ButtonControl GetButtonControl(UnityEngine.KeyCode oldKey) { }
        // RVA: 0x056F4858  token: 0x6000111
        public static System.Int32 GetTouchCount() { }
        // RVA: 0x056F48BC  token: 0x6000112
        public static System.Void GetTouch(System.Int32 index, System.Int32& id, UnityEngine.Vector2& position, System.Single& pressure, System.Boolean& set) { }
        // RVA: 0x056F46DC  token: 0x6000113
        public static UnityEngine.Vector2 GetMousePosition() { }
        // RVA: 0x056F4520  token: 0x6000114
        public static System.Boolean GetKeyWentDown(UnityEngine.KeyCode oldKey) { }
        // RVA: 0x056F44CC  token: 0x6000115
        public static System.Boolean GetKeyIsHeld(UnityEngine.KeyCode oldKey) { }
        // RVA: 0x056F4574  token: 0x6000116
        public static System.Boolean GetKeyWentUp(UnityEngine.KeyCode oldKey) { }
        // RVA: 0x056F473C  token: 0x6000117
        public static System.Boolean GetMouseWentDown(System.Int32 index) { }
        // RVA: 0x056F4688  token: 0x6000118
        public static System.Boolean GetMouseIsHeld(System.Int32 index) { }
        // RVA: 0x056F4790  token: 0x6000119
        public static System.Boolean GetMouseWentUp(System.Int32 index) { }
        // RVA: 0x056F47E4  token: 0x600011A
        public static System.Single GetMouseWheelDelta() { }
        // RVA: 0x056F4674  token: 0x600011B
        public static System.Boolean GetMouseExists() { }
        // RVA: 0x056F45C8  token: 0x600011C
        public static System.Boolean GetKeyboardExists() { }
        // RVA: 0x03633F00  token: 0x600011D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x38
    public class CwShaderBundle : UnityEngine.ScriptableObject
    {
        // Fields
        private System.String title;  // 0x18
        private UnityEngine.Shader target;  // 0x20
        private System.Int32 variantHash;  // 0x28
        private System.Int32 projectHash;  // 0x2c
        private System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant> variants;  // 0x30

        // Properties
        System.String Title { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.Shader Target { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Int32 VariantHash { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        System.Int32 ProjectHash { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }
        System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant> Variants { get; /* RVA: 0x056F53C4 */ }
        System.Boolean Dirty { get; /* RVA: 0x056F52B8 */ }

        // Methods
        // RVA: 0x056F5214  token: 0x6000128
        public static System.Int32 GetProjectHash() { }
        // RVA: 0x056F516C  token: 0x6000129
        public static CW.Common.CwShaderBundle.Pipeline DetectProjectPipeline() { }
        // RVA: 0x056F529C  token: 0x600012A
        public static System.Boolean IsStandard(CW.Common.CwShaderBundle.Pipeline pipe) { }
        // RVA: 0x056F5270  token: 0x600012B
        public static System.Boolean IsScriptable(CW.Common.CwShaderBundle.Pipeline pipe) { }
        // RVA: 0x056F52A4  token: 0x600012C
        public static System.Boolean IsURP(CW.Common.CwShaderBundle.Pipeline pipe) { }
        // RVA: 0x056F525C  token: 0x600012D
        public static System.Boolean IsHDRP(CW.Common.CwShaderBundle.Pipeline pipe) { }
        // RVA: 0x0286F540  token: 0x600012E
        public System.Void .ctor() { }

    }

}

