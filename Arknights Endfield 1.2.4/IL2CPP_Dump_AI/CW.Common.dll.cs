// ========================================================
// Dumped by @desirepro
// Assembly: CW.Common.dll
// Classes:  34
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

CLASS: LinkType
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwDemoButton.LinkType PreviousScene  // const
  public    static  CW.Common.CwDemoButton.LinkType NextScene  // const
  public    static  CW.Common.CwDemoButton.LinkType Publisher  // const
  public    static  CW.Common.CwDemoButton.LinkType URL  // const
  public    static  CW.Common.CwDemoButton.LinkType Isolate  // const
METHODS:
END_CLASS

CLASS: ToggleType
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwDemoButton.ToggleTypeKeepSelected  // const
  public    static  CW.Common.CwDemoButton.ToggleTypeToggleSelection  // const
  public    static  CW.Common.CwDemoButton.ToggleTypeSelectPrevious  // const
METHODS:
END_CLASS

CLASS: IHasChildren
TYPE:  interface
TOKEN: 0x200000D
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600007D  System.Boolean HasChild(CW.Common.CwChild child)
END_CLASS

CLASS: FollowType
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwFollow.FollowType   TargetTransform  // const
  public    static  CW.Common.CwFollow.FollowType   MainCamera  // const
METHODS:
END_CLASS

CLASS: UpdateType
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwFollow.UpdateType   Update  // const
  public    static  CW.Common.CwFollow.UpdateType   LateUpdate  // const
METHODS:
END_CLASS

CLASS: AxisGesture
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwInputManager.AxisGestureHorizontalDrag  // const
  public    static  CW.Common.CwInputManager.AxisGestureVerticalDrag  // const
  public    static  CW.Common.CwInputManager.AxisGestureTwist  // const
  public    static  CW.Common.CwInputManager.AxisGestureHorizontalPull  // const
  public    static  CW.Common.CwInputManager.AxisGestureVerticalPull  // const
METHODS:
END_CLASS

CLASS: Axis
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x34
FIELDS:
  public            System.Int32                    FingerCount  // 0x10
  public            System.Boolean                  FingerInvert  // 0x14
  public            CW.Common.CwInputManager.AxisGestureFingerGesture  // 0x18
  public            System.Single                   FingerSensitivity  // 0x1c
  public            UnityEngine.KeyCode             KeyNegative  // 0x20
  public            UnityEngine.KeyCode             KeyPositive  // 0x24
  public            UnityEngine.KeyCode             KeyNegativeAlt  // 0x28
  public            UnityEngine.KeyCode             KeyPositiveAlt  // 0x2c
  public            System.Single                   KeySensitivity  // 0x30
METHODS:
  RVA=0x03D520F0  token=0x60000B3  System.Void .ctor(System.Int32 fCount, System.Boolean fInvert, CW.Common.CwInputManager.AxisGesture fGesture, System.Single fSensitivty, UnityEngine.KeyCode kNegative, UnityEngine.KeyCode kPositive, UnityEngine.KeyCode kNegativeAlt, UnityEngine.KeyCode kPositiveAlt, System.Single kSensitivity)
  RVA=0x056EDD38  token=0x60000B4  System.Single GetValue(System.Single delta)
END_CLASS

CLASS: Trigger
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x18
FIELDS:
  public            System.Boolean                  UseFinger  // 0x10
  public            System.Boolean                  UseMouse  // 0x11
  public            UnityEngine.KeyCode             UseKey  // 0x14
METHODS:
  RVA=0x03D52540  token=0x60000B5  System.Void .ctor(System.Boolean uFinger, System.Boolean uMouse, UnityEngine.KeyCode uKey)
  RVA=0x056F56C0  token=0x60000B6  System.Boolean WentDown(CW.Common.CwInputManager.Finger finger)
  RVA=0x056F5620  token=0x60000B7  System.Boolean IsDown(CW.Common.CwInputManager.Finger finger)
  RVA=0x056F5760  token=0x60000B8  System.Boolean WentUp(CW.Common.CwInputManager.Finger finger, System.Boolean useAnyFinger)
END_CLASS

CLASS: Link
TYPE:  abstract class
TOKEN: 0x2000016
SIZE:  0x18
FIELDS:
  public            CW.Common.CwInputManager.Finger Finger  // 0x10
METHODS:
  RVA=-1  // generic def  token=0x60000B9  T Find(System.Collections.Generic.List<T> links, CW.Common.CwInputManager.Finger finger)
  RVA=-1  // generic def  token=0x60000BA  T Create(System.Collections.Generic.List<T>& links, CW.Common.CwInputManager.Finger finger)
  RVA=-1  // generic def  token=0x60000BB  System.Void ClearAll(System.Collections.Generic.List<T> links)
  RVA=-1  // generic def  token=0x60000BC  System.Void ClearAndRemove(System.Collections.Generic.List<T> links, T link)
  RVA=0x0350B670  token=0x60000BD  System.Void Clear()
  RVA=0x0350B670  token=0x60000BE  System.Void .ctor()
END_CLASS

CLASS: Finger
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x50
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            System.Single                   Pressure  // 0x14
  public            System.Boolean                  Down  // 0x18
  public            System.Boolean                  Up  // 0x19
  public            System.Single                   Age  // 0x1c
  public            System.Boolean                  StartedOverGui  // 0x20
  public            UnityEngine.Vector2             StartScreenPosition  // 0x24
  public            UnityEngine.Vector2             ScreenPosition  // 0x2c
  public            UnityEngine.Vector2             ScreenPositionOld  // 0x34
  public            UnityEngine.Vector2             ScreenPositionOldOld  // 0x3c
  public            UnityEngine.Vector2             ScreenPositionOldOldOld  // 0x44
PROPERTIES:
  SmoothScreenPositionDelta  get=0x056F5584
METHODS:
  RVA=0x056F5448  token=0x60000C0  UnityEngine.Vector2 GetSmoothScreenPosition(System.Single t)
  RVA=0x0350B670  token=0x60000C1  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001E
SIZE:  0x10
FIELDS:
  public    static readonly CW.Common.CwHelper.<>c          <>9  // static @ 0x0
METHODS:
  RVA=0x056F5A10  token=0x6000108  System.Void .cctor()
  RVA=0x0350B670  token=0x6000109  System.Void .ctor()
  RVA=0x056F5820  token=0x600010A  System.Void <.cctor>b__11_0(UnityEngine.Camera camera)
  RVA=0x056F589C  token=0x600010B  System.Void <.cctor>b__11_1(UnityEngine.Camera camera)
  RVA=0x056F5918  token=0x600010C  System.Void <.cctor>b__11_2(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera)
  RVA=0x056F5994  token=0x600010D  System.Void <.cctor>b__11_3(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera)
END_CLASS

CLASS: Pipeline
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwShaderBundle.PipelineInvalid  // const
  public    static  CW.Common.CwShaderBundle.PipelineStandard  // const
  public    static  CW.Common.CwShaderBundle.PipelineURP2019  // const
  public    static  CW.Common.CwShaderBundle.PipelineURP2020  // const
  public    static  CW.Common.CwShaderBundle.PipelineURP2021  // const
  public    static  CW.Common.CwShaderBundle.PipelineHDRP2019  // const
  public    static  CW.Common.CwShaderBundle.PipelineHDRP2020  // const
  public    static  CW.Common.CwShaderBundle.PipelineHDRP2021  // const
  public    static  CW.Common.CwShaderBundle.PipelineCOUNT  // const
METHODS:
END_CLASS

CLASS: ShaderVariant
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x28
FIELDS:
  public            CW.Common.CwShaderBundle.PipelinePipe  // 0x10
  public            System.String                   Code  // 0x18
  public            System.Int32                    Hash  // 0x20
  public            System.Boolean                  Dirty  // 0x24
PROPERTIES:
  HashString  get=0x056F55C4
METHODS:
  RVA=0x0350B670  token=0x6000130  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwCameraLook
TYPE:  class
TOKEN: 0x2000002
SIZE:  0xA0
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Boolean                  listen  // 0x18
  private           System.Single                   damping  // 0x1c
  private           System.Single                   sensitivity  // 0x20
  private           CW.Common.CwInputManager.Axis   pitchControls  // 0x24
  private           CW.Common.CwInputManager.Axis   yawControls  // 0x48
  private           CW.Common.CwInputManager.Axis   rollControls  // 0x6c
  private           UnityEngine.Quaternion          remainingDelta  // 0x90
PROPERTIES:
  Listen  get=0x01002A50  set=0x01002B40
  Damping  get=0x03D4F110  set=0x03D4F120
  Sensitivity  get=0x03D4F2E0  set=0x03D4F2F0
  PitchControls  get=0x03D52130  set=0x03D52190
  YawControls  get=0x03D52170  set=0x03D521D0
  RollControls  get=0x03D52150  set=0x03D521B0
METHODS:
  RVA=0x056EE38C  token=0x600000D  System.Void Start()
  RVA=0x0350B670  token=0x600000E  System.Void OnDisable()
  RVA=0x056EE3CC  token=0x600000F  System.Void Update()
  RVA=0x0350B670  token=0x6000010  System.Void OnApplicationFocus(System.Boolean focus)
  RVA=0x056EE008  token=0x6000011  System.Void AddToDelta()
  RVA=0x056EE214  token=0x6000012  System.Void DampenDelta()
  RVA=0x056EE3F4  token=0x6000013  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwCameraMove
TYPE:  class
TOKEN: 0x2000003
SIZE:  0xA0
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Boolean                  listen  // 0x18
  private           System.Single                   damping  // 0x1c
  private           System.Single                   sensitivity  // 0x20
  private           CW.Common.CwInputManager.Axis   horizontalControls  // 0x24
  private           CW.Common.CwInputManager.Axis   depthControls  // 0x48
  private           CW.Common.CwInputManager.Axis   verticalControls  // 0x6c
  private           UnityEngine.Vector3             remainingDelta  // 0x90
PROPERTIES:
  Listen  get=0x01002A50  set=0x01002B40
  Damping  get=0x03D4F110  set=0x03D4F120
  Sensitivity  get=0x03D4F2E0  set=0x03D4F2F0
  HorizontalControls  get=0x03D52130  set=0x03D52190
  DepthControls  get=0x03D52170  set=0x03D521D0
  VerticalControls  get=0x03D52150  set=0x03D521B0
METHODS:
  RVA=0x056EE88C  token=0x6000020  System.Void Start()
  RVA=0x056EE8CC  token=0x6000021  System.Void Update()
  RVA=0x056EE4D8  token=0x6000022  System.Void AddToDelta()
  RVA=0x056EE6FC  token=0x6000023  System.Void DampenDelta()
  RVA=0x056EE8F4  token=0x6000024  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwCameraPivot
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x78
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Boolean                  listen  // 0x18
  private           System.Single                   damping  // 0x1c
  private           CW.Common.CwInputManager.Axis   pitchControls  // 0x20
  private           CW.Common.CwInputManager.Axis   yawControls  // 0x44
  private           UnityEngine.Vector3             remainingDelta  // 0x68
PROPERTIES:
  Listen  get=0x01002A50  set=0x01002B40
  Damping  get=0x03D4F110  set=0x03D4F120
  PitchControls  get=0x03D521F0  set=0x03D52230
  YawControls  get=0x03D52210  set=0x03D52250
METHODS:
  RVA=0x056EEC10  token=0x600002D  System.Void OnEnable()
  RVA=0x056EEC50  token=0x600002E  System.Void Update()
  RVA=0x056EE9D0  token=0x600002F  System.Void AddToDelta()
  RVA=0x056EEA34  token=0x6000030  System.Void DampenDelta()
  RVA=0x056EEC78  token=0x6000031  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDemo
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Boolean                  upgradeInputModule  // 0x18
  private           System.Boolean                  changeExposureInHDRP  // 0x19
  private           System.Boolean                  changeVisualEnvironmentInHDRP  // 0x1a
  private           System.Boolean                  changeFogInHDRP  // 0x1b
  private           System.Boolean                  changeCloudsInHDRP  // 0x1c
  private           System.Boolean                  changeMotionBlurInHDRP  // 0x1d
  private           System.Boolean                  upgradeLightsInHDRP  // 0x1e
  private           System.Boolean                  upgradeCamerasInHDRP  // 0x1f
PROPERTIES:
  UpgradeInputModule  get=0x01002A50  set=0x01002B40
  ChangeExposureInHDRP  get=0x03D4EF80  set=0x03D4EFB0
  ChangeVisualEnvironmentInHDRP  get=0x03D4EFA0  set=0x03D4EFD0
  ChangeFogInHDRP  get=0x03D52270  set=0x03D522A0
  ChangeCloudsInHDRP  get=0x03D4E9A0  set=0x03D4E9B0
  ChangeMotionBlurInHDRP  get=0x03D50D90  set=0x03D522B0
  UpgradeLightsInHDRP  get=0x03D52290  set=0x03D522D0
  UpgradeCamerasInHDRP  get=0x03D52280  set=0x03D522C0
METHODS:
  RVA=0x056EF894  token=0x6000042  System.Void OnEnable()
  RVA=0x0350B670  token=0x6000043  System.Void TryApplyURP()
  RVA=0x03D4B9D0  token=0x6000044  System.Void TryApplyHDRP()
  RVA=0x0350B670  token=0x6000045  System.Void TryCreateVolume()
  RVA=0x0350B670  token=0x6000046  System.Void TryUpgradeLights()
  RVA=0x0350B670  token=0x6000047  System.Void TryUpgradeCameras()
  RVA=0x0350B670  token=0x6000048  System.Void TryUpgradeEventSystem()
  RVA=0x056EF8A4  token=0x6000049  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDemoButton
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
  private           CW.Common.CwDemoButton.LinkType link  // 0x18
  private           System.String                   urlTarget  // 0x20
  private           UnityEngine.Transform           isolateTarget  // 0x28
  private           CW.Common.CwDemoButton.ToggleTypeisolateToggle  // 0x30
  private           UnityEngine.CanvasGroup         cachedCanvasGroup  // 0x38
  private           UnityEngine.Transform           previousChild  // 0x40
PROPERTIES:
  Link  get=0x020D1AC0  set=0x03D4E9C0
  UrlTarget  get=0x03D4EB40  set=0x04271930
  IsolateTarget  get=0x03D4EAC0  set=0x02C92F10
  IsolateToggle  get=0x03D4ED20  set=0x03D4EE10
METHODS:
  RVA=0x056EF1C4  token=0x6000052  System.Void OnEnable()
  RVA=0x056EF74C  token=0x6000053  System.Void Update()
  RVA=0x056EF20C  token=0x6000054  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x056EF0C8  token=0x6000055  System.Int32 GetCurrentLevel()
  RVA=0x056EF13C  token=0x6000056  System.Int32 GetLevelCount()
  RVA=0x056EF17C  token=0x6000057  System.Void LoadLevel(System.Int32 index)
  RVA=0x0426FE60  token=0x6000058  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDemoButtonBuilder
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x50
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          buttonPrefab  // 0x18
  private           UnityEngine.RectTransform       buttonRoot  // 0x20
  private           UnityEngine.Sprite              icon  // 0x28
  private           UnityEngine.Color               color  // 0x30
  private           System.String                   overrideName  // 0x40
  private           UnityEngine.GameObject          clone  // 0x48
PROPERTIES:
  ButtonPrefab  get=0x01041090  set=0x022C3A90
  ButtonRoot  get=0x03D4EB40  set=0x04271930
  Icon  get=0x03D4EAC0  set=0x02C92F10
  Color  get=0x03D4FD30  set=0x03D4FD40
  OverrideName  get=0x03D4E2B0  set=0x03CB2D80
METHODS:
  RVA=0x056EEE14  token=0x6000063  System.Void Build()
  RVA=0x056EED7C  token=0x6000064  System.Void BuildAll()
  RVA=0x056EF038  token=0x6000065  UnityEngine.GameObject DoInstantiate()
  RVA=0x056EF0A0  token=0x6000066  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwLightIntensity
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Single                   multiplier  // 0x18
  private           System.Single                   intensityInStandard  // 0x1c
  private           System.Single                   intensityInURP  // 0x20
  private           System.Single                   intensityInHDRP  // 0x24
  private           UnityEngine.Light               cachedLight  // 0x28
  private           System.Boolean                  cachedLightSet  // 0x30
PROPERTIES:
  Multiplier  get=0x03D4EBF0  set=0x03D4EC00
  IntensityInStandard  get=0x03D4F110  set=0x03D4F120
  IntensityInURP  get=0x03D4F2E0  set=0x03D4F2F0
  IntensityInHDRP  get=0x03D524F0  set=0x03D52500
  CachedLight  get=0x056F4B04
METHODS:
  RVA=0x056F4A80  token=0x6000070  System.Void Update()
  RVA=0x056F49F8  token=0x6000071  System.Void ApplyIntensity(System.Single intensity)
  RVA=0x056F4AE0  token=0x6000072  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwRotate
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             angularVelocity  // 0x18
  private           UnityEngine.Space               relativeTo  // 0x24
PROPERTIES:
  AngularVelocity  get=0x03D52510  set=0x03D52530
  RelativeTo  get=0x03D4E2E0  set=0x03D4E2F0
METHODS:
  RVA=0x056F50B4  token=0x6000077  System.Void Update()
  RVA=0x056F5148  token=0x6000078  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwChild
TYPE:  abstract class
TOKEN: 0x200000C
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x056EED00  token=0x6000079  System.Void DestroyGameObjectIfInvalid()
  RVA=-1  // abstract  token=0x600007A  CW.Common.CwChild.IHasChildren GetParent()
  RVA=0x0350B670  token=0x600007B  System.Void Start()
  RVA=0x0426FE60  token=0x600007C  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDepthTextureMode
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.DepthTextureMode    depthMode  // 0x18
  private           UnityEngine.Camera              cachedCamera  // 0x20
PROPERTIES:
  DepthMode  get=0x020D1AC0  set=0x056EF95C
METHODS:
  RVA=0x056EF8BC  token=0x6000080  System.Void UpdateDepthMode()
  RVA=0x056EF954  token=0x6000081  System.Void Update()
  RVA=0x0426FE60  token=0x6000082  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwFollow
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x50
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           CW.Common.CwFollow.FollowType   follow  // 0x18
  private           UnityEngine.Transform           target  // 0x20
  private           System.Single                   damping  // 0x28
  private           System.Boolean                  rotate  // 0x2c
  private           System.Boolean                  ignoreZ  // 0x2d
  private           CW.Common.CwFollow.UpdateType   followIn  // 0x30
  private           UnityEngine.Vector3             localPosition  // 0x34
  private           UnityEngine.Vector3             localRotation  // 0x40
PROPERTIES:
  Follow  get=0x020D1AC0  set=0x03D4E9C0
  Target  get=0x03D4EB40  set=0x04271930
  Damping  get=0x03D4F480  set=0x03D4F490
  Rotate  get=0x03D4F1A0  set=0x03D4F1B0
  IgnoreZ  get=0x03D4F4C0  set=0x03D4F4F0
  FollowIn  get=0x03D4ED20  set=0x03D4EE10
  LocalPosition  get=0x03D522E0  set=0x03D52320
  LocalRotation  get=0x03D52300  set=0x03D52330
METHODS:
  RVA=0x056EF978  token=0x6000093  System.Void UpdatePosition()
  RVA=0x056EFC38  token=0x6000094  System.Void Update()
  RVA=0x056EF968  token=0x6000095  System.Void LateUpdate()
  RVA=0x056EFC48  token=0x6000096  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwInputManager
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.LayerMask           guiLayers  // 0x18
  private   static  System.Action<CW.Common.CwInputManager.Finger>OnFingerDown  // static @ 0x0
  private   static  System.Action<CW.Common.CwInputManager.Finger>OnFingerUpdate  // static @ 0x8
  private   static  System.Action<CW.Common.CwInputManager.Finger>OnFingerUp  // static @ 0x10
  public    static  System.Int32                    MOUSE_FINGER_INDEX  // const
  public    static  System.Int32                    HOVER_FINGER_INDEX  // const
  private   static  System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>tempRaycastResults  // static @ 0x18
  private   static  UnityEngine.EventSystems.PointerEventDatatempPointerEventData  // static @ 0x20
  private   static  UnityEngine.EventSystems.EventSystemtempEventSystem  // static @ 0x28
  private   static  System.Collections.Generic.List<CW.Common.CwInputManager.Finger>fingers  // static @ 0x30
  private   static  System.Collections.Generic.List<CW.Common.CwInputManager.Finger>filteredFingers  // static @ 0x38
  private   static  System.Collections.Generic.Stack<CW.Common.CwInputManager.Finger>pool  // static @ 0x40
PROPERTIES:
  GuiLayers  get=0x020D1AC0  set=0x03D4E9C0
  Fingers  get=0x056F40B0
  ScaleFactor  get=0x056F4100
EVENTS:
  OnFingerDown  add=add_OnFingerDown  remove=remove_OnFingerDown
  OnFingerUpdate  add=add_OnFingerUpdate  remove=remove_OnFingerUpdate
  OnFingerUp  add=add_OnFingerUp  remove=remove_OnFingerUp
METHODS:
  RVA=0x056F302C  token=0x60000A1  System.Collections.Generic.List<CW.Common.CwInputManager.Finger> GetFingers(System.Boolean ignoreStartedOverGui, System.Boolean ignoreHover)
  RVA=0x056F3350  token=0x60000A2  System.Boolean PointOverGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers)
  RVA=0x056F33C4  token=0x60000A3  System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> RaycastGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers)
  RVA=0x056F29AC  token=0x60000A4  UnityEngine.Vector2 GetAveragePosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  RVA=0x056F27F0  token=0x60000A5  UnityEngine.Vector2 GetAverageOldPosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  RVA=0x056F2B68  token=0x60000A6  UnityEngine.Vector2 GetAveragePullScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  RVA=0x056F25F8  token=0x60000A7  UnityEngine.Vector2 GetAverageDeltaScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  RVA=0x056F2D60  token=0x60000A8  System.Single GetAverageTwistRadians(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  RVA=0x056F23A8  token=0x60000A9  System.Void EnsureThisComponentExists()
  RVA=0x056F375C  token=0x60000AA  System.Void Update()
  RVA=0x056F24B8  token=0x60000AB  CW.Common.CwInputManager.Finger FindFinger(System.Int32 index)
  RVA=0x056F2184  token=0x60000AC  System.Void AddFinger(System.Int32 index, UnityEngine.Vector2 screenPosition, System.Single pressure, System.Boolean set)
  RVA=0x056F3240  token=0x60000AD  UnityEngine.Vector2 Hermite(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, System.Single t)
  RVA=0x03D523D0  token=0x60000AE  System.Single HermiteInterpolate(System.Single y0, System.Single y1, System.Single y2, System.Single y3, System.Single mu, System.Single mu2, System.Single mu3)
  RVA=0x03D523A0  token=0x60000AF  System.Single GetRadians(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 referencePoint)
  RVA=0x056F2F44  token=0x60000B0  System.Single GetDeltaRadians(CW.Common.CwInputManager.Finger finger, UnityEngine.Vector2 referencePoint, UnityEngine.Vector2 lastReferencePoint)
  RVA=0x056F3E4C  token=0x60000B1  System.Void .ctor()
  RVA=0x056F3C94  token=0x60000B2  System.Void .cctor()
END_CLASS

CLASS: CW.Common.CwRenderTextureManager
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Int32                    lifetime  // 0x18
PROPERTIES:
  Lifetime  get=0x020D1AC0  set=0x03D4E9C0
METHODS:
  RVA=0x056F4B5C  token=0x60000C4  UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc, System.String title)
  RVA=0x056F4C0C  token=0x60000C5  UnityEngine.RenderTexture ReleaseTemporary(UnityEngine.RenderTexture renderTexture)
  RVA=0x056F4C78  token=0x60000C6  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwRoot
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.Collections.Generic.List<CW.Common.CwRoot>instances  // static @ 0x0
PROPERTIES:
  Exists  get=0x056F4FA8
  Root  get=0x056F5008
METHODS:
  RVA=0x056F4C88  token=0x60000C9  UnityEngine.Transform GetRoot()
  RVA=0x056F4E00  token=0x60000CA  System.Void OnEnable()
  RVA=0x056F4D90  token=0x60000CB  System.Void OnDisable()
  RVA=0x0426FE60  token=0x60000CC  System.Void .ctor()
  RVA=0x056F4F1C  token=0x60000CD  System.Void .cctor()
END_CLASS

CLASS: CW.Common.CwSeedAttribute
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000CE  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwShared
TYPE:  static class
TOKEN: 0x200001B
SIZE:  0x10
FIELDS:
  public    static  System.String                   HelpUrlPrefix  // const
  public    static  System.String                   ComponentMenuPrefix  // const
  public    static  System.String                   GameObjectMenuPrefix  // const
METHODS:
END_CLASS

CLASS: CW.Common.CwGuide
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x40
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            System.String                   LongName  // 0x18
  public            System.String                   ShortName  // 0x20
  public            UnityEngine.TextAsset           Documentation  // 0x28
  private           UnityEngine.Texture2D           icon  // 0x30
  private           System.String                   version  // 0x38
PROPERTIES:
  Icon  get=0x056EFC64
  Version  get=0x056EFD48
METHODS:
  RVA=0x0286F540  token=0x60000D1  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwHelper
TYPE:  static class
TOKEN: 0x200001D
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Stack<UnityEngine.Random.State>seedStates  // static @ 0x0
  public    static  System.Collections.Generic.List<UnityEngine.Material>tempMaterials  // static @ 0x8
  public    static  System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock>tempProperties  // static @ 0x10
  private   static  System.Action<UnityEngine.Camera>OnCameraPreRender  // static @ 0x18
  private   static  System.Action<UnityEngine.Camera>OnCameraPostRender  // static @ 0x20
  private   static  System.Collections.Generic.Stack<UnityEngine.RenderTexture>actives  // static @ 0x28
  private   static  System.Int32                    uniqueSeed  // static @ 0x30
  private   static  System.Collections.Generic.List<UnityEngine.Material>materials  // static @ 0x38
EVENTS:
  OnCameraPreRender  add=add_OnCameraPreRender  remove=remove_OnCameraPreRender
  OnCameraPostRender  add=add_OnCameraPostRender  remove=remove_OnCameraPostRender
METHODS:
  RVA=0x056F1990  token=0x60000D6  System.Void .cctor()
  RVA=-1  // generic def  token=0x60000D7  T GetOrAddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo)
  RVA=-1  // generic def  token=0x60000D8  T AddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo)
  RVA=0x056F0EC8  token=0x60000D9  System.Boolean IndexInMask(System.Int32 index, System.Int32 mask)
  RVA=0x056F0B0C  token=0x60000DA  UnityEngine.Camera GetCamera(UnityEngine.Camera currentCamera, UnityEngine.GameObject gameObject)
  RVA=0x056F0BD0  token=0x60000DB  UnityEngine.Vector3 GetObserverPosition(UnityEngine.Transform observer)
  RVA=0x056F09B4  token=0x60000DC  System.Boolean Enabled(UnityEngine.Behaviour b)
  RVA=0x056F0290  token=0x60000DD  System.Void BeginSeed()
  RVA=0x056F01F8  token=0x60000DE  System.Void BeginSeed(System.Int32 newSeed)
  RVA=0x056F0A88  token=0x60000DF  System.Void EndSeed()
  RVA=0x056F0314  token=0x60000E0  UnityEngine.Color Brighten(UnityEngine.Color color, System.Single brightness, System.Boolean convertToGamma)
  RVA=0x03D52360  token=0x60000E1  UnityEngine.Color Premultiply(UnityEngine.Color color)
  RVA=0x056F13C8  token=0x60000E2  System.Single Saturate(System.Single c)
  RVA=0x056F13F4  token=0x60000E3  UnityEngine.Color Saturate(UnityEngine.Color c)
  RVA=-1  // generic def  token=0x60000E4  System.Void Resize(System.Collections.Generic.List<T> list, System.Int32 size)
  RVA=0x056F1800  token=0x60000E5  System.Single Sharpness(System.Single a, System.Single p)
  RVA=0x056F18C4  token=0x60000E6  UnityEngine.Color ToLinear(UnityEngine.Color gamma)
  RVA=0x056F1908  token=0x60000E7  System.Single ToLinear(System.Single gamma)
  RVA=0x056F1880  token=0x60000E8  UnityEngine.Color ToGamma(UnityEngine.Color linear)
  RVA=0x056F184C  token=0x60000E9  System.Single ToGamma(System.Single linear)
  RVA=0x056F193C  token=0x60000EA  System.Single UniformScale(UnityEngine.Vector3 scale)
  RVA=0x056F016C  token=0x60000EB  System.Void BeginActive(UnityEngine.RenderTexture renderTexture)
  RVA=0x056F0A18  token=0x60000EC  System.Void EndActive()
  RVA=0x056F1484  token=0x60000ED  System.Void SetTempMaterial(UnityEngine.Material material)
  RVA=0x056F1550  token=0x60000EE  System.Void SetTempMaterial(UnityEngine.Material material1, UnityEngine.Material material2)
  RVA=0x056F1654  token=0x60000EF  System.Void SetTempMaterial(System.Collections.Generic.List<UnityEngine.Material> materials)
  RVA=0x056F1734  token=0x60000F0  System.Void SetTempMaterial(UnityEngine.MaterialPropertyBlock properties)
  RVA=0x056EFF1C  token=0x60000F1  System.Void AddMaterial(UnityEngine.Renderer r, UnityEngine.Material m)
  RVA=0x056F1144  token=0x60000F2  System.Void ReplaceMaterial(UnityEngine.Renderer r, UnityEngine.Material m)
  RVA=0x056F0F4C  token=0x60000F3  System.Void RemoveMaterial(UnityEngine.Renderer r, UnityEngine.Material m)
  RVA=0x056F0810  token=0x60000F4  UnityEngine.Texture2D CreateTempTexture2D(System.String name, System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mips, System.Boolean linear)
  RVA=0x056F06B0  token=0x60000F5  UnityEngine.Material CreateTempMaterial(System.String materialName, System.String shaderName)
  RVA=0x056F0784  token=0x60000F6  UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Shader shader)
  RVA=0x056F0624  token=0x60000F7  UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Material source)
  RVA=-1  // generic def  token=0x60000F8  T Destroy(T o)
  RVA=0x056F051C  token=0x60000F9  UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, System.String recordUndo)
  RVA=0x056F03C4  token=0x60000FA  UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, UnityEngine.Vector3 localScale, System.String recordUndo)
  RVA=-1  // generic def  token=0x60000FB  T CreateElement(UnityEngine.Transform parent)
  RVA=0x056F0F14  token=0x60000FC  System.Single Reciprocal(System.Single v)
  RVA=0x056F0F30  token=0x60000FD  System.Double Reciprocal(System.Double v)
  RVA=0x056F098C  token=0x60000FE  System.Single Divide(System.Single a, System.Single b)
  RVA=0x056F09A0  token=0x60000FF  System.Double Divide(System.Double a, System.Double b)
  RVA=0x056EFEB0  token=0x6000100  System.Single Acos(System.Single v)
  RVA=0x056EFE44  token=0x6000101  System.Double Acos(System.Double v)
  RVA=0x056F0944  token=0x6000102  System.Single DampenFactor(System.Single speed, System.Single elapsed)
  RVA=0x056F08CC  token=0x6000103  System.Single DampenFactor(System.Single damping, System.Single deltaTime, System.Single linear)
  RVA=0x03D52340  token=0x6000104  System.Single Atan2(UnityEngine.Vector2 xy)
  RVA=0x056F0ED8  token=0x6000105  System.Int32 Mod(System.Int32 a, System.Int32 b)
  RVA=0x056F0EEC  token=0x6000106  System.Single Mod(System.Single a, System.Single b)
  RVA=0x056F0C9C  token=0x6000107  UnityEngine.Texture2D GetReadableCopy(UnityEngine.Texture texture, UnityEngine.TextureFormat format, System.Boolean mipMaps, System.Int32 width, System.Int32 height)
END_CLASS

CLASS: CW.Common.CwInput
TYPE:  static class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.KeyCode,UnityEngine.InputSystem.Key>keyMapping  // static @ 0x0
METHODS:
  RVA=0x0235C360  token=0x600010E  System.Void Enable()
  RVA=0x056F45DC  token=0x600010F  UnityEngine.InputSystem.Controls.ButtonControl GetMouseButtonControl(System.Int32 index)
  RVA=0x056F4380  token=0x6000110  UnityEngine.InputSystem.Controls.ButtonControl GetButtonControl(UnityEngine.KeyCode oldKey)
  RVA=0x056F4858  token=0x6000111  System.Int32 GetTouchCount()
  RVA=0x056F48BC  token=0x6000112  System.Void GetTouch(System.Int32 index, System.Int32& id, UnityEngine.Vector2& position, System.Single& pressure, System.Boolean& set)
  RVA=0x056F46DC  token=0x6000113  UnityEngine.Vector2 GetMousePosition()
  RVA=0x056F4520  token=0x6000114  System.Boolean GetKeyWentDown(UnityEngine.KeyCode oldKey)
  RVA=0x056F44CC  token=0x6000115  System.Boolean GetKeyIsHeld(UnityEngine.KeyCode oldKey)
  RVA=0x056F4574  token=0x6000116  System.Boolean GetKeyWentUp(UnityEngine.KeyCode oldKey)
  RVA=0x056F473C  token=0x6000117  System.Boolean GetMouseWentDown(System.Int32 index)
  RVA=0x056F4688  token=0x6000118  System.Boolean GetMouseIsHeld(System.Int32 index)
  RVA=0x056F4790  token=0x6000119  System.Boolean GetMouseWentUp(System.Int32 index)
  RVA=0x056F47E4  token=0x600011A  System.Single GetMouseWheelDelta()
  RVA=0x056F4674  token=0x600011B  System.Boolean GetMouseExists()
  RVA=0x056F45C8  token=0x600011C  System.Boolean GetKeyboardExists()
  RVA=0x03633F00  token=0x600011D  System.Void .cctor()
END_CLASS

CLASS: CW.Common.CwShaderBundle
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x38
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private           System.String                   title  // 0x18
  private           UnityEngine.Shader              target  // 0x20
  private           System.Int32                    variantHash  // 0x28
  private           System.Int32                    projectHash  // 0x2c
  private           System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant>variants  // 0x30
PROPERTIES:
  Title  get=0x01041090  set=0x022C3A90
  Target  get=0x03D4EB40  set=0x04271930
  VariantHash  get=0x03D4EB90  set=0x03D4EBA0
  ProjectHash  get=0x03D4EDD0  set=0x03D4EDE0
  Variants  get=0x056F53C4
  Dirty  get=0x056F52B8
METHODS:
  RVA=0x056F5214  token=0x6000128  System.Int32 GetProjectHash()
  RVA=0x056F516C  token=0x6000129  CW.Common.CwShaderBundle.Pipeline DetectProjectPipeline()
  RVA=0x056F529C  token=0x600012A  System.Boolean IsStandard(CW.Common.CwShaderBundle.Pipeline pipe)
  RVA=0x056F5270  token=0x600012B  System.Boolean IsScriptable(CW.Common.CwShaderBundle.Pipeline pipe)
  RVA=0x056F52A4  token=0x600012C  System.Boolean IsURP(CW.Common.CwShaderBundle.Pipeline pipe)
  RVA=0x056F525C  token=0x600012D  System.Boolean IsHDRP(CW.Common.CwShaderBundle.Pipeline pipe)
  RVA=0x0286F540  token=0x600012E  System.Void .ctor()
END_CLASS

