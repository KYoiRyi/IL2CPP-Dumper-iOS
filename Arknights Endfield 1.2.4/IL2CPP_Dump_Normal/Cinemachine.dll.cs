// ========================================================
// Dumped by @desirepro
// Assembly: Cinemachine.dll
// Classes:  204
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x40
    public class CinemachineCameraOffset : Cinemachine.CinemachineExtension
    {
        // Fields
        public UnityEngine.Vector3 m_Offset;  // 0x28
        public Cinemachine.CinemachineCore.Stage m_ApplyAfter;  // 0x34
        public System.Boolean m_PreserveComposition;  // 0x38

        // Methods
        // RVA: 0x0554B3FC  token: 0x6000001
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0554B724  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000003  // size: 0x48
    public class CinemachineRecomposer : Cinemachine.CinemachineExtension
    {
        // Fields
        public Cinemachine.CinemachineCore.Stage m_ApplyAfter;  // 0x28
        public System.Single m_Tilt;  // 0x2c
        public System.Single m_Pan;  // 0x30
        public System.Single m_Dutch;  // 0x34
        public System.Single m_ZoomScale;  // 0x38
        public System.Single m_FollowAttachment;  // 0x3c
        public System.Single m_LookAtAttachment;  // 0x40

        // Methods
        // RVA: 0x03D50400  token: 0x6000003
        private System.Void Reset() { }
        // RVA: 0x05557980  token: 0x6000004
        private System.Void OnValidate() { }
        // RVA: 0x033417D0  token: 0x6000005
        public virtual System.Void PrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x02744A90  token: 0x6000006
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0426FE60  token: 0x6000007
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class CinemachineBeyondCommunicator
    {
        // Fields
        private static System.Func<Cinemachine.CinemachineVirtualCameraBase> <GetLevelCamera>k__BackingField;  // static @ 0x0

        // Properties
        System.Func<Cinemachine.CinemachineVirtualCameraBase> GetLevelCamera { get; /* RVA: 0x055491E4 */ set; /* RVA: 0x0554921C */ }

    }

    // TypeToken: 0x2000005  // size: 0x30
    public class CinemachineTouchInputMapper : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single TouchSensitivityX;  // 0x18
        public System.Single TouchSensitivityY;  // 0x1c
        public System.String TouchXInputMapTo;  // 0x20
        public System.String TouchYInputMapTo;  // 0x28

        // Methods
        // RVA: 0x05557F64  token: 0x600000A
        private System.Void Start() { }
        // RVA: 0x05557EC4  token: 0x600000B
        private System.Single GetInputAxis(System.String axisName) { }
        // RVA: 0x05558014  token: 0x600000C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public sealed class CinemachineMixer : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private Cinemachine.CinemachineBrain mBrain;  // 0x10
        private System.Int32 mBrainOverrideId;  // 0x18
        private System.Boolean mPreviewPlay;  // 0x1c

        // Methods
        // RVA: 0x05555914  token: 0x600000D
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x03D50320  token: 0x600000E
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x05555988  token: 0x600000F
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x055558C4  token: 0x6000010
        private System.Single GetDeltaTime(System.Single deltaTime) { }
        // RVA: 0x03D50330  token: 0x6000011
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x38
    public sealed class CinemachineShot : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        public System.Boolean DisableEvaluateTwiceWhenEnabled;  // 0x18
        public System.Boolean UseVcamBeforeTimeline;  // 0x19
        public System.Boolean UseLevelCamera;  // 0x1a
        public System.String DisplayName;  // 0x20
        public UnityEngine.ExposedReference<Cinemachine.CinemachineVirtualCameraBase> VirtualCamera;  // 0x28

        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x05557EB0 */ }

        // Methods
        // RVA: 0x05557A0C  token: 0x6000013
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x05557D14  token: 0x6000014
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x0286F540  token: 0x6000015
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x18
    public sealed class CinemachineShotPlayable : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public Cinemachine.CinemachineVirtualCameraBase VirtualCamera;  // 0x10

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x055579BC */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000017
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0xC0
    public class CinemachineTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x05558088  token: 0x6000018
        public virtual UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x05558168  token: 0x6000019
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x38
    public sealed struct Instruction
    {
        // Fields
        public Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera;  // 0x10
        public System.Single m_Hold;  // 0x18
        public Cinemachine.CinemachineBlendDefinition m_Blend;  // 0x20

    }

    // TypeToken: 0x200000E  // size: 0x14
    public sealed struct UpdateMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineBrain.UpdateMethod FixedUpdate;  // const
        public static Cinemachine.CinemachineBrain.UpdateMethod LateUpdate;  // const
        public static Cinemachine.CinemachineBrain.UpdateMethod SmartUpdate;  // const
        public static Cinemachine.CinemachineBrain.UpdateMethod ManualUpdate;  // const

    }

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct BrainUpdateMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineBrain.BrainUpdateMethod FixedUpdate;  // const
        public static Cinemachine.CinemachineBrain.BrainUpdateMethod LateUpdate;  // const

    }

    // TypeToken: 0x2000010  // size: 0x30
    public class BrainEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x031718F0  token: 0x6000061
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x30
    public class VcamActivatedEvent : UnityEngine.Events.UnityEvent`2
    {
        // Methods
        // RVA: 0x03171930  token: 0x6000062
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x38
    public class BrainFrame
    {
        // Fields
        public System.Int32 id;  // 0x10
        public Cinemachine.CinemachineBlend blend;  // 0x18
        public Cinemachine.CinemachineBlend workingBlend;  // 0x20
        public Cinemachine.BlendSourceVirtualCamera workingBlendSource;  // 0x28
        public System.Single deltaTimeOverride;  // 0x30

        // Properties
        System.Boolean Active { get; /* RVA: 0x05548774 */ }

        // Methods
        // RVA: 0x03171970  token: 0x6000064
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x28
    public sealed class <AfterPhysics>d__36 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Cinemachine.CinemachineBrain <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000065
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000066
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02FFDDF0  token: 0x6000067
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05558D8C  token: 0x6000069
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000015  // size: 0x18
    public sealed struct Pair
    {
        // Fields
        public System.Int32 a;  // 0x10
        public System.Single b;  // 0x14

    }

    // TypeToken: 0x2000016  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Cinemachine.CinemachineClearShot.<>c <>9;  // static @ 0x0
        public static System.Comparison<Cinemachine.CinemachineClearShot.Pair> <>9__47_0;  // static @ 0x8

        // Methods
        // RVA: 0x05558DD8  token: 0x6000085
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000086
        public System.Void .ctor() { }
        // RVA: 0x03D50440  token: 0x6000087
        private System.Int32 <Randomize>b__47_0(Cinemachine.CinemachineClearShot.Pair p1, Cinemachine.CinemachineClearShot.Pair p2) { }

    }

    // TypeToken: 0x2000018  // size: 0x14
    public sealed struct ResolutionStrategy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineCollider.ResolutionStrategy PullCameraForward;  // const
        public static Cinemachine.CinemachineCollider.ResolutionStrategy PreserveCameraHeight;  // const
        public static Cinemachine.CinemachineCollider.ResolutionStrategy PreserveCameraDistance;  // const

    }

    // TypeToken: 0x2000019  // size: 0x38
    public class VcamExtraState
    {
        // Fields
        public UnityEngine.Vector3 previousDisplacement;  // 0x10
        public System.Single previousLookAt2DisplacedPosLen;  // 0x1c
        public System.Boolean shouldPerformCollisionDamping;  // 0x20
        public System.Boolean previousHitSomething;  // 0x21
        public System.Boolean targetObscured;  // 0x22
        public System.Single occlusionStartTime;  // 0x24
        public System.Collections.Generic.List<UnityEngine.Vector3> debugResolutionPath;  // 0x28
        private System.Single m_SmoothedDistance;  // 0x30
        private System.Single m_SmoothedTime;  // 0x34

        // Methods
        // RVA: 0x0350B670  token: 0x600009D
        public System.Void AddPointToDebugPath(UnityEngine.Vector3 p) { }
        // RVA: 0x027439E0  token: 0x600009E
        public System.Single ApplyDistanceSmoothing(System.Single distance, System.Single smoothingTime) { }
        // RVA: 0x05558E3C  token: 0x600009F
        public System.Void UpdateDistanceSmoothing(System.Single distance) { }
        // RVA: 0x02743AE0  token: 0x60000A0
        public System.Void ResetDistanceSmoothing(System.Single smoothingTime) { }
        // RVA: 0x0350B670  token: 0x60000A1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineConfiner.Mode Confine2D;  // const
        public static Cinemachine.CinemachineConfiner.Mode Confine3D;  // const

    }

    // TypeToken: 0x200001C  // size: 0x20
    public class VcamExtraState
    {
        // Fields
        public UnityEngine.Vector3 m_previousDisplacement;  // 0x10
        public System.Single confinerDisplacement;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x60000AE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E  // size: 0x38
    public class VcamExtraState
    {
        // Fields
        public UnityEngine.Vector3 m_PreviousDisplacement;  // 0x10
        public UnityEngine.Vector3 m_DampedDisplacement;  // 0x1c
        public Cinemachine.ConfinerOven.BakedSolution m_BakedSolution;  // 0x28
        public Cinemachine.CinemachineVirtualCameraBase m_vcam;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x60000B6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0xF8
    public sealed struct ShapeCache
    {
        // Fields
        public Cinemachine.ConfinerOven m_confinerOven;  // 0x10
        public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> m_OriginalPath;  // 0x18
        public UnityEngine.Matrix4x4 m_DeltaWorldToBaked;  // 0x20
        public UnityEngine.Matrix4x4 m_DeltaBakedToWorld;  // 0x60
        private System.Single m_aspectRatio;  // 0xa0
        private System.Single m_maxWindowSize;  // 0xa4
        private System.Single m_maxComputationTimePerFrameInSeconds;  // 0xa8
        private UnityEngine.Matrix4x4 m_bakedToWorld;  // 0xac
        private UnityEngine.Collider2D m_boundingShape2D;  // 0xf0

        // Methods
        // RVA: 0x05558598  token: 0x60000B7
        public System.Void Invalidate() { }
        // RVA: 0x05558754  token: 0x60000B8
        public System.Boolean ValidateCache(UnityEngine.Collider2D boundingShape2D, System.Single maxWindowSize, System.Single aspectRatio, System.Boolean& confinerStateChanged) { }
        // RVA: 0x0555863C  token: 0x60000B9
        private System.Boolean IsValid(UnityEngine.Collider2D& boundingShape2D, System.Single& aspectRatio, System.Single& maxOrthoSize) { }
        // RVA: 0x055583B0  token: 0x60000BA
        private System.Void CalculateDeltaTransformationMatrix() { }

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct UpdateMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineDollyCart.UpdateMethod Update;  // const
        public static Cinemachine.CinemachineDollyCart.UpdateMethod FixedUpdate;  // const
        public static Cinemachine.CinemachineDollyCart.UpdateMethod LateUpdate;  // const

    }

    // TypeToken: 0x2000024  // size: 0x18
    public class VcamExtraState
    {
        // Fields
        public System.Single m_previousFrameZoom;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000CB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x18
    public sealed struct Orbit
    {
        // Fields
        public System.Single m_Height;  // 0x10
        public System.Single m_Radius;  // 0x14

        // Methods
        // RVA: 0x03D50430  token: 0x60000EE
        public System.Void .ctor(System.Single h, System.Single r) { }

    }

    // TypeToken: 0x2000027  // size: 0x80
    public sealed class CreateRigDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055581B4  token: 0x60000EF
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01035ED0  token: 0x60000F0
        public virtual Cinemachine.CinemachineVirtualCamera Invoke(Cinemachine.CinemachineFreeLook vcam, System.String name, Cinemachine.CinemachineVirtualCamera copyFrom) { }

    }

    // TypeToken: 0x2000028  // size: 0x80
    public sealed class DestroyRigDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x60000F1
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x60000F2
        public virtual System.Void Invoke(UnityEngine.GameObject rig) { }

    }

    // TypeToken: 0x200002B  // size: 0x2C
    public sealed struct Waypoint
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Vector3 tangent;  // 0x1c
        public System.Single roll;  // 0x28

    }

    // TypeToken: 0x200002F  // size: 0x20
    public sealed struct Waypoint
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public System.Single roll;  // 0x1c

        // Properties
        UnityEngine.Vector4 AsVector4 { get; /* RVA: 0x0294BC80 */ }

        // Methods
        // RVA: 0x055670E4  token: 0x6000126
        private static Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(UnityEngine.Vector4 v) { }

    }

    // TypeToken: 0x2000031  // size: 0x28
    public sealed struct Instruction
    {
        // Fields
        public System.Int32 m_FullHash;  // 0x10
        public Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera;  // 0x18
        public System.Single m_ActivateAfter;  // 0x20
        public System.Single m_MinDuration;  // 0x24

    }

    // TypeToken: 0x2000032  // size: 0x18
    public sealed struct ParentHash
    {
        // Fields
        public System.Int32 m_Hash;  // 0x10
        public System.Int32 m_ParentHash;  // 0x14

    }

    // TypeToken: 0x2000033  // size: 0x18
    public sealed struct HashPair
    {
        // Fields
        public System.Int32 parentHash;  // 0x10
        public System.Int32 hash;  // 0x14

    }

    // TypeToken: 0x2000035  // size: 0x14
    public sealed struct FillStrategy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineStoryboard.FillStrategy BestFit;  // const
        public static Cinemachine.CinemachineStoryboard.FillStrategy CropImageToFit;  // const
        public static Cinemachine.CinemachineStoryboard.FillStrategy StretchToFit;  // const

    }

    // TypeToken: 0x2000036  // size: 0x38
    public class CanvasInfo
    {
        // Fields
        public UnityEngine.GameObject mCanvas;  // 0x10
        public UnityEngine.Canvas mCanvasComponent;  // 0x18
        public Cinemachine.CinemachineBrain mCanvasParent;  // 0x20
        public UnityEngine.RectTransform mViewport;  // 0x28
        public UnityEngine.UI.RawImage mRawImage;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x600014F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x14
    public sealed struct StoryboardRenderMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineStoryboard.StoryboardRenderMode ScreenSpaceOverlay;  // const
        public static Cinemachine.CinemachineStoryboard.StoryboardRenderMode ScreenSpaceCamera;  // const

    }

    // TypeToken: 0x200003A  // size: 0x20
    public sealed struct Target
    {
        // Fields
        public UnityEngine.Transform target;  // 0x10
        public System.Single weight;  // 0x18
        public System.Single radius;  // 0x1c

    }

    // TypeToken: 0x200003B  // size: 0x14
    public sealed struct PositionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTargetGroup.PositionMode GroupCenter;  // const
        public static Cinemachine.CinemachineTargetGroup.PositionMode GroupAverage;  // const

    }

    // TypeToken: 0x200003C  // size: 0x14
    public sealed struct RotationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTargetGroup.RotationMode Manual;  // const
        public static Cinemachine.CinemachineTargetGroup.RotationMode GroupAverage;  // const

    }

    // TypeToken: 0x200003D  // size: 0x14
    public sealed struct UpdateMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTargetGroup.UpdateMethod Update;  // const
        public static Cinemachine.CinemachineTargetGroup.UpdateMethod FixedUpdate;  // const
        public static Cinemachine.CinemachineTargetGroup.UpdateMethod LateUpdate;  // const

    }

    // TypeToken: 0x200003F  // size: 0x80
    public sealed class CreatePipelineDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055581B4  token: 0x6000189
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01035ED0  token: 0x600018A
        public virtual UnityEngine.Transform Invoke(Cinemachine.CinemachineVirtualCamera vcam, System.String name, Cinemachine.CinemachineComponentBase[] copyFrom) { }

    }

    // TypeToken: 0x2000040  // size: 0x80
    public sealed class DestroyPipelineDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x600018B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600018C
        public virtual System.Void Invoke(UnityEngine.GameObject pipeline) { }

    }

    // TypeToken: 0x2000041  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Cinemachine.CinemachineVirtualCamera.<>c <>9;  // static @ 0x0
        public static System.Comparison<Cinemachine.CinemachineComponentBase> <>9__39_0;  // static @ 0x8
        public static System.Func<Cinemachine.CinemachineComponentBase,System.Boolean> <>9__48_0;  // static @ 0x10

        // Methods
        // RVA: 0x03D194F0  token: 0x600018D
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600018E
        public System.Void .ctor() { }
        // RVA: 0x03B13790  token: 0x600018F
        private System.Int32 <UpdateComponentPipeline>b__39_0(Cinemachine.CinemachineComponentBase c1, Cinemachine.CinemachineComponentBase c2) { }
        // RVA: 0x05566DE8  token: 0x6000190
        private System.Boolean <RequiresUserInput>b__48_0(Cinemachine.CinemachineComponentBase c) { }

    }

    // TypeToken: 0x2000045  // size: 0x60
    public sealed struct FovCache
    {
        // Fields
        public UnityEngine.Rect mFovSoftGuideRect;  // 0x10
        public UnityEngine.Rect mFovHardGuideRect;  // 0x20
        public System.Single mFovH;  // 0x30
        public System.Single mFov;  // 0x34
        private System.Single mOrthoSizeOverDistance;  // 0x38
        private System.Single mAspect;  // 0x3c
        private UnityEngine.Rect mSoftGuideRect;  // 0x40
        private UnityEngine.Rect mHardGuideRect;  // 0x50

        // Methods
        // RVA: 0x02743B50  token: 0x60001B8
        public System.Void UpdateCache(Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, System.Single targetDistance) { }
        // RVA: 0x02741F50  token: 0x60001B9
        private UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, System.Single fov, System.Single fovH, System.Single aspect) { }

    }

    // TypeToken: 0x2000047  // size: 0x14
    public sealed struct FramingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineFramingTransposer.FramingMode Horizontal;  // const
        public static Cinemachine.CinemachineFramingTransposer.FramingMode Vertical;  // const
        public static Cinemachine.CinemachineFramingTransposer.FramingMode HorizontalAndVertical;  // const
        public static Cinemachine.CinemachineFramingTransposer.FramingMode None;  // const

    }

    // TypeToken: 0x2000048  // size: 0x14
    public sealed struct AdjustmentMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineFramingTransposer.AdjustmentMode ZoomOnly;  // const
        public static Cinemachine.CinemachineFramingTransposer.AdjustmentMode DollyOnly;  // const
        public static Cinemachine.CinemachineFramingTransposer.AdjustmentMode DollyThenZoom;  // const

    }

    // TypeToken: 0x200004A  // size: 0x14
    public sealed struct FramingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineGroupComposer.FramingMode Horizontal;  // const
        public static Cinemachine.CinemachineGroupComposer.FramingMode Vertical;  // const
        public static Cinemachine.CinemachineGroupComposer.FramingMode HorizontalAndVertical;  // const

    }

    // TypeToken: 0x200004B  // size: 0x14
    public sealed struct AdjustmentMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineGroupComposer.AdjustmentMode ZoomOnly;  // const
        public static Cinemachine.CinemachineGroupComposer.AdjustmentMode DollyOnly;  // const
        public static Cinemachine.CinemachineGroupComposer.AdjustmentMode DollyThenZoom;  // const

    }

    // TypeToken: 0x2000050  // size: 0x14
    public sealed struct HeadingDefinition
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition PositionDelta;  // const
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition Velocity;  // const
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition TargetForward;  // const
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition WorldForward;  // const

    }

    // TypeToken: 0x200004F  // size: 0x1C
    public sealed struct Heading
    {
        // Fields
        public Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition;  // 0x10
        public System.Int32 m_VelocityFilterStrength;  // 0x14
        public System.Single m_Bias;  // 0x18

        // Methods
        // RVA: 0x03D50880  token: 0x60001F4
        public System.Void .ctor(Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, System.Int32 filterStrength, System.Single bias) { }

    }

    // TypeToken: 0x2000051  // size: 0x80
    public sealed class UpdateHeadingDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x05566FBC  token: 0x60001F5
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x05566F84  token: 0x60001F6
        public virtual System.Single Invoke(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up) { }

    }

    // TypeToken: 0x2000052  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Cinemachine.CinemachineOrbitalTransposer.<>c <>9;  // static @ 0x0
        public static Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate <>9__30_0;  // static @ 0x8

        // Methods
        // RVA: 0x05566F20  token: 0x60001F7
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001F8
        public System.Void .ctor() { }
        // RVA: 0x05566E50  token: 0x60001F9
        private System.Single <.ctor>b__30_0(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up) { }

    }

    // TypeToken: 0x2000054  // size: 0x14
    public sealed struct RecenterTargetMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachinePOV.RecenterTargetMode None;  // const
        public static Cinemachine.CinemachinePOV.RecenterTargetMode FollowTargetForward;  // const
        public static Cinemachine.CinemachinePOV.RecenterTargetMode LookAtTargetForward;  // const

    }

    // TypeToken: 0x2000057  // size: 0x14
    public sealed struct CameraUpMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode Default;  // const
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode Path;  // const
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode PathNoRoll;  // const
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode FollowTarget;  // const
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode FollowTargetNoRoll;  // const

    }

    // TypeToken: 0x2000058  // size: 0x20
    public sealed struct AutoDolly
    {
        // Fields
        public System.Boolean m_Enabled;  // 0x10
        public System.Single m_PositionOffset;  // 0x14
        public System.Int32 m_SearchRadius;  // 0x18
        public System.Int32 m_SearchResolution;  // 0x1c

        // Methods
        // RVA: 0x03D50910  token: 0x6000214
        public System.Void .ctor(System.Boolean enabled, System.Single positionOffset, System.Int32 searchRadius, System.Int32 stepsPerSegment) { }

    }

    // TypeToken: 0x200005A  // size: 0x14
    public sealed struct BindingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTargetOnAssign;  // const
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTargetWithWorldUp;  // const
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTargetNoRoll;  // const
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTarget;  // const
        public static Cinemachine.CinemachineTransposer.BindingMode WorldSpace;  // const
        public static Cinemachine.CinemachineTransposer.BindingMode SimpleFollowWithWorldUp;  // const

    }

    // TypeToken: 0x200005B  // size: 0x14
    public sealed struct AngularDampingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTransposer.AngularDampingMode Euler;  // const
        public static Cinemachine.CinemachineTransposer.AngularDampingMode Quaternion;  // const

    }

    // TypeToken: 0x200005D  // size: 0x14
    public sealed struct SpeedMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.AxisState.SpeedMode MaxSpeed;  // const
        public static Cinemachine.AxisState.SpeedMode InputValueGain;  // const

    }

    // TypeToken: 0x200005E
    public interface IInputAxisProvider
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000231
        public virtual System.Single GetAxisValue(System.Int32 axis) { }

    }

    // TypeToken: 0x200005F  // size: 0x2C
    public sealed struct Recentering
    {
        // Fields
        public System.Boolean m_enabled;  // 0x10
        public System.Single m_WaitTime;  // 0x14
        public System.Single m_RecenteringTime;  // 0x18
        private System.Single mLastAxisInputTime;  // 0x1c
        private System.Single mRecenteringVelocity;  // 0x20
        private System.Int32 m_LegacyHeadingDefinition;  // 0x24
        private System.Int32 m_LegacyVelocityFilterStrength;  // 0x28

        // Methods
        // RVA: 0x03D50AA0  token: 0x6000232
        public System.Void .ctor(System.Boolean enabled, System.Single waitTime, System.Single recenteringTime) { }
        // RVA: 0x0556E23C  token: 0x6000233
        public System.Void Validate() { }
        // RVA: 0x0556E024  token: 0x6000234
        public System.Void CancelRecentering() { }
        // RVA: 0x0556E078  token: 0x6000235
        public System.Void DoRecentering(Cinemachine.AxisState& axis, System.Single deltaTime, System.Single recenterTarget) { }
        // RVA: 0x0556E214  token: 0x6000236
        private System.Boolean LegacyUpgrade(System.Int32& heading, System.Int32& velocityFilter) { }

    }

    // TypeToken: 0x2000061  // size: 0x30
    public sealed struct HGDOFParams
    {
        // Fields
        public System.Boolean enabledForVirtualCamera;  // 0x10
        public System.Boolean enable;  // 0x11
        public System.Single nearRadius;  // 0x14
        public System.Single nearFocusStart;  // 0x18
        public System.Single nearFocusEnd;  // 0x1c
        public System.Single farRadius;  // 0x20
        public System.Single farFocusStart;  // 0x24
        public System.Single farFocusEnd;  // 0x28
        public System.Single temporalFactor;  // 0x2c

    }

    // TypeToken: 0x2000062  // size: 0x14
    public sealed struct BlendHintValue
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CameraState.BlendHintValue Nothing;  // const
        public static Cinemachine.CameraState.BlendHintValue NoPosition;  // const
        public static Cinemachine.CameraState.BlendHintValue NoOrientation;  // const
        public static Cinemachine.CameraState.BlendHintValue NoTransform;  // const
        public static Cinemachine.CameraState.BlendHintValue SphericalPositionBlend;  // const
        public static Cinemachine.CameraState.BlendHintValue CylindricalPositionBlend;  // const
        public static Cinemachine.CameraState.BlendHintValue RadialAimBlend;  // const
        public static Cinemachine.CameraState.BlendHintValue IgnoreLookAtTarget;  // const
        public static Cinemachine.CameraState.BlendHintValue NoLens;  // const

    }

    // TypeToken: 0x2000063  // size: 0x20
    public sealed struct CustomBlendable
    {
        // Fields
        public UnityEngine.Object m_Custom;  // 0x10
        public System.Single m_Weight;  // 0x18

        // Methods
        // RVA: 0x0556D9B4  token: 0x6000248
        public System.Void .ctor(UnityEngine.Object custom, System.Single weight) { }

    }

    // TypeToken: 0x2000066  // size: 0x14
    public sealed struct Style
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineBlendDefinition.Style Cut;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style EaseInOut;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style EaseIn;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style EaseOut;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style HardIn;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style HardOut;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style Linear;  // const
        public static Cinemachine.CinemachineBlendDefinition.Style Custom;  // const

    }

    // TypeToken: 0x200006A  // size: 0x38
    public sealed struct CustomBlend
    {
        // Fields
        public System.String m_From;  // 0x10
        public System.String m_To;  // 0x18
        public Cinemachine.CinemachineBlendDefinition m_Blend;  // 0x20

    }

    // TypeToken: 0x200006B  // size: 0x78
    public class CustomBlendGroup
    {
        // Fields
        public System.Collections.Generic.List<System.String> cameras;  // 0x10
        public Cinemachine.CinemachineBlendDefinition fromSameCamera;  // 0x18
        public Cinemachine.CinemachineBlendDefinition insideGroup;  // 0x30
        public Cinemachine.CinemachineBlendDefinition toGroup;  // 0x48
        public Cinemachine.CinemachineBlendDefinition fromGroup;  // 0x60

        // Methods
        // RVA: 0x0350B670  token: 0x6000277
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x14
    public sealed struct Stage
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineCore.Stage Body;  // const
        public static Cinemachine.CinemachineCore.Stage Aim;  // const
        public static Cinemachine.CinemachineCore.Stage Noise;  // const
        public static Cinemachine.CinemachineCore.Stage Finalize;  // const

    }

    // TypeToken: 0x200006F  // size: 0x80
    public sealed class AxisInputDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03171B00  token: 0x60002AA
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0102B410  token: 0x60002AB
        public virtual System.Single Invoke(System.String axisName) { }

    }

    // TypeToken: 0x2000070  // size: 0x80
    public sealed class GetBlendOverrideDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03411A00  token: 0x60002AC
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0556D9D0  token: 0x60002AD
        public virtual Cinemachine.CinemachineBlendDefinition Invoke(Cinemachine.ICinemachineCamera fromVcam, Cinemachine.ICinemachineCamera toVcam, Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.MonoBehaviour owner) { }

    }

    // TypeToken: 0x2000071  // size: 0x20
    public class UpdateStatus
    {
        // Fields
        public System.Int32 lastUpdateFrame;  // 0x10
        public System.Int32 lastUpdateFixedFrame;  // 0x14
        public Cinemachine.UpdateTracker.UpdateClock lastUpdateMode;  // 0x18
        public System.Single lastUpdateDeltaTime;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x60002AE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000072  // size: 0x14
    public sealed struct UpdateFilter
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineCore.UpdateFilter Fixed;  // const
        public static Cinemachine.CinemachineCore.UpdateFilter Late;  // const
        public static Cinemachine.CinemachineCore.UpdateFilter Smart;  // const
        public static Cinemachine.CinemachineCore.UpdateFilter SmartFixed;  // const
        public static Cinemachine.CinemachineCore.UpdateFilter SmartLate;  // const

    }

    // TypeToken: 0x2000073  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Cinemachine.CinemachineCore.<>c <>9;  // static @ 0x0
        public static System.Comparison<Cinemachine.CinemachineVirtualCameraBase> <>9__30_0;  // static @ 0x8

        // Methods
        // RVA: 0x0556EE68  token: 0x60002AF
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60002B0
        public System.Void .ctor() { }
        // RVA: 0x0556ED78  token: 0x60002B1
        private System.Int32 <GetVirtualCamera>b__30_0(Cinemachine.CinemachineVirtualCameraBase x, Cinemachine.CinemachineVirtualCameraBase y) { }

    }

    // TypeToken: 0x2000076  // size: 0x38
    public class Appearance
    {
        // Fields
        public UnityEngine.Color pathColor;  // 0x10
        public UnityEngine.Color inactivePathColor;  // 0x20
        public System.Single width;  // 0x30

        // Methods
        // RVA: 0x055676B0  token: 0x60002DA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x14
    public sealed struct PositionUnits
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachinePathBase.PositionUnits PathUnits;  // const
        public static Cinemachine.CinemachinePathBase.PositionUnits Distance;  // const
        public static Cinemachine.CinemachinePathBase.PositionUnits Normalized;  // const

    }

    // TypeToken: 0x2000082  // size: 0x14
    public sealed struct Level
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.DocumentationSortingAttribute.Level Undoc;  // const
        public static Cinemachine.DocumentationSortingAttribute.Level API;  // const
        public static Cinemachine.DocumentationSortingAttribute.Level UserRef;  // const

    }

    // TypeToken: 0x2000084  // size: 0x14
    public sealed struct StandbyUpdateMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode Never;  // const
        public static Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode Always;  // const
        public static Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode RoundRobin;  // const

    }

    // TypeToken: 0x2000085  // size: 0x14
    public sealed struct BlendHint
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint None;  // const
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint SphericalPosition;  // const
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint CylindricalPosition;  // const
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint ScreenSpaceAimWhenTargetsDiffer;  // const

    }

    // TypeToken: 0x2000086  // size: 0x20
    public sealed struct TransitionParams
    {
        // Fields
        public Cinemachine.CinemachineVirtualCameraBase.BlendHint m_BlendHint;  // 0x10
        public System.Boolean m_InheritPosition;  // 0x14
        public Cinemachine.CinemachineBrain.VcamActivatedEvent m_OnCameraLive;  // 0x18

    }

    // TypeToken: 0x2000087  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Cinemachine.CinemachineVirtualCameraBase.<>c <>9;  // static @ 0x0
        public static System.Func<Cinemachine.CinemachineExtension,System.Boolean> <>9__67_0;  // static @ 0x8

        // Methods
        // RVA: 0x0556EE04  token: 0x6000328
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000329
        public System.Void .ctor() { }
        // RVA: 0x0556EDAC  token: 0x600032A
        private System.Boolean <RequiresUserInput>b__67_0(Cinemachine.CinemachineExtension extension) { }

    }

    // TypeToken: 0x2000089  // size: 0x40
    public class BakedSolution
    {
        // Fields
        private readonly System.Single <FrustumHeight>k__BackingField;  // 0x10
        private System.Single m_frustumSizeIntSpace;  // 0x14
        private readonly Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;  // 0x18
        private readonly System.Boolean m_HasBones;  // 0x24
        private readonly System.Double m_SqrPolygonDiagonal;  // 0x28
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_OriginalPolygon;  // 0x30
        public System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_Solution;  // 0x38

        // Properties
        System.Single FrustumHeight { get; /* RVA: 0x03D4E7A0 */ }

        // Methods
        // RVA: 0x05568884  token: 0x6000334
        public System.Void .ctor(System.Single aspectRatio, System.Single frustumHeight, System.Boolean hasBones, UnityEngine.Rect polygonBounds, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> originalPolygon, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> solution) { }
        // RVA: 0x0556885C  token: 0x6000335
        public System.Boolean IsValid(System.Single frustumHeight) { }
        // RVA: 0x05567F34  token: 0x6000336
        public UnityEngine.Vector2 ConfinePoint(UnityEngine.Vector2& pointToConfine) { }
        // RVA: 0x055687C0  token: 0x6000337
        private System.Boolean IsInsideOriginal(ClipperLib.IntPoint p) { }
        // RVA: 0x05567EB4  token: 0x6000338
        private static System.Single ClosestPointOnSegment(ClipperLib.IntPoint p, ClipperLib.IntPoint s0, ClipperLib.IntPoint s1) { }
        // RVA: 0x0556872C  token: 0x6000339
        private static ClipperLib.IntPoint IntPointLerp(ClipperLib.IntPoint a, ClipperLib.IntPoint b, System.Single lerp) { }
        // RVA: 0x05568308  token: 0x600033A
        private System.Boolean DoesIntersectOriginal(ClipperLib.IntPoint l1, ClipperLib.IntPoint l2) { }
        // RVA: 0x05568508  token: 0x600033B
        private static System.Int32 FindIntersection(ClipperLib.IntPoint& p1, ClipperLib.IntPoint& p2, ClipperLib.IntPoint& p3, ClipperLib.IntPoint& p4) { }
        // RVA: 0x03D50960  token: 0x600033C
        private static System.Double IntPointDiffSqrMagnitude(ClipperLib.IntPoint p1, ClipperLib.IntPoint p2) { }

    }

    // TypeToken: 0x200008A  // size: 0x1C
    public sealed struct AspectStretcher
    {
        // Fields
        private readonly System.Single <Aspect>k__BackingField;  // 0x10
        private readonly System.Single m_InverseAspect;  // 0x14
        private readonly System.Single m_CenterX;  // 0x18

        // Properties
        System.Single Aspect { get; /* RVA: 0x03D4FA00 */ }

        // Methods
        // RVA: 0x03D508F0  token: 0x600033E
        public System.Void .ctor(System.Single aspect, System.Single centerX) { }
        // RVA: 0x03D50890  token: 0x600033F
        public UnityEngine.Vector2 Stretch(UnityEngine.Vector2 p) { }
        // RVA: 0x03D508C0  token: 0x6000340
        public UnityEngine.Vector2 Unstretch(UnityEngine.Vector2 p) { }

    }

    // TypeToken: 0x200008B  // size: 0x20
    public sealed struct PolygonSolution
    {
        // Fields
        public System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_Polygons;  // 0x10
        public System.Single m_FrustumHeight;  // 0x18

        // Properties
        System.Boolean IsEmpty { get; /* RVA: 0x02361C20 */ }

        // Methods
        // RVA: 0x0556DF50  token: 0x6000341
        public System.Boolean StateChanged(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>& paths) { }

    }

    // TypeToken: 0x200008C  // size: 0x14
    public sealed struct BakingState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.ConfinerOven.BakingState BAKING;  // const
        public static Cinemachine.ConfinerOven.BakingState BAKED;  // const
        public static Cinemachine.ConfinerOven.BakingState TIMEOUT;  // const

    }

    // TypeToken: 0x200008D  // size: 0x58
    public sealed struct BakingStateCache
    {
        // Fields
        public ClipperLib.ClipperOffset offsetter;  // 0x10
        public System.Collections.Generic.List<Cinemachine.ConfinerOven.PolygonSolution> solutions;  // 0x18
        public Cinemachine.ConfinerOven.PolygonSolution rightCandidate;  // 0x20
        public Cinemachine.ConfinerOven.PolygonSolution leftCandidate;  // 0x30
        public System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> maxCandidate;  // 0x40
        public System.Single stepSize;  // 0x48
        public System.Single maxFrustumHeight;  // 0x4c
        public System.Single currentFrustumHeight;  // 0x50
        public System.Single bakeTime;  // 0x54

    }

    // TypeToken: 0x2000090  // size: 0x14
    public sealed struct OverrideModes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.LensSettings.OverrideModes None;  // const
        public static Cinemachine.LensSettings.OverrideModes Orthographic;  // const
        public static Cinemachine.LensSettings.OverrideModes Perspective;  // const
        public static Cinemachine.LensSettings.OverrideModes Physical;  // const

    }

    // TypeToken: 0x2000092  // size: 0x1C
    public sealed struct NoiseParams
    {
        // Fields
        public System.Single Frequency;  // 0x10
        public System.Single Amplitude;  // 0x14
        public System.Boolean Constant;  // 0x18

        // Methods
        // RVA: 0x0556DD14  token: 0x600035C
        public System.Single GetValueAt(System.Single time, System.Single timeOffset) { }

    }

    // TypeToken: 0x2000093  // size: 0x34
    public sealed struct TransformNoiseParams
    {
        // Fields
        public Cinemachine.NoiseSettings.NoiseParams X;  // 0x10
        public Cinemachine.NoiseSettings.NoiseParams Y;  // 0x1c
        public Cinemachine.NoiseSettings.NoiseParams Z;  // 0x28

        // Methods
        // RVA: 0x0556ECD8  token: 0x600035D
        public UnityEngine.Vector3 GetValueAt(System.Single time, UnityEngine.Vector3 timeOffsets) { }

    }

    // TypeToken: 0x2000095  // size: 0x80
    public sealed class OverlapSphereNonAllocDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03641520  token: 0x6000369
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500FCCC  token: 0x600036A
        public virtual System.Int32 Invoke(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000096  // size: 0x80
    public sealed class RaycastDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03641490  token: 0x600036B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500C984  token: 0x600036C
        public virtual System.Boolean Invoke(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000097  // size: 0x80
    public sealed class RaycastNonAllocDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03641400  token: 0x600036D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500C984  token: 0x600036E
        public virtual System.Int32 Invoke(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000098  // size: 0x80
    public sealed class SphereCastNonAllocDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03641370  token: 0x600036F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x05010C40  token: 0x6000370
        public virtual System.Int32 Invoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000099  // size: 0x80
    public sealed class ComputePenetrationDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x036412E0  token: 0x6000371
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500C584  token: 0x6000372
        public virtual System.Boolean Invoke(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }

    }

    // TypeToken: 0x200009D  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.TargetPositionCache.Mode Disabled;  // const
        public static Cinemachine.TargetPositionCache.Mode Record;  // const
        public static Cinemachine.TargetPositionCache.Mode Playback;  // const

    }

    // TypeToken: 0x200009F  // size: 0x2C
    public sealed struct Item
    {
        // Fields
        public UnityEngine.Vector3 Pos;  // 0x10
        public UnityEngine.Quaternion Rot;  // 0x1c

        // Properties
        Cinemachine.TargetPositionCache.CacheCurve.Item Empty { get; /* RVA: 0x0556DB48 */ }

        // Methods
        // RVA: 0x0556DA40  token: 0x600037D
        public static Cinemachine.TargetPositionCache.CacheCurve.Item Lerp(Cinemachine.TargetPositionCache.CacheCurve.Item a, Cinemachine.TargetPositionCache.CacheCurve.Item b, System.Single t) { }

    }

    // TypeToken: 0x200009E  // size: 0x20
    public class CacheCurve
    {
        // Fields
        public System.Single StartTime;  // 0x10
        public System.Single StepSize;  // 0x14
        private System.Collections.Generic.List<Cinemachine.TargetPositionCache.CacheCurve.Item> m_Cache;  // 0x18

        // Methods
        // RVA: 0x05568AE4  token: 0x600037C
        public Cinemachine.TargetPositionCache.CacheCurve.Item Evaluate(System.Single time) { }

    }

    // TypeToken: 0x20000A1  // size: 0x34
    public sealed struct RecordingItem
    {
        // Fields
        public System.Single Time;  // 0x10
        public System.Boolean IsCut;  // 0x14
        public Cinemachine.TargetPositionCache.CacheCurve.Item Item;  // 0x18

    }

    // TypeToken: 0x20000A0  // size: 0x20
    public class CacheEntry
    {
        // Fields
        public Cinemachine.TargetPositionCache.CacheCurve Curve;  // 0x10
        private System.Collections.Generic.List<Cinemachine.TargetPositionCache.CacheEntry.RecordingItem> RawItems;  // 0x18

        // Methods
        // RVA: 0x05568C84  token: 0x600037F
        public System.Void AddRawItem(System.Single time, System.Boolean isCut, UnityEngine.Transform target) { }
        // RVA: 0x05568F1C  token: 0x6000380
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2  // size: 0x18
    public sealed struct TimeRange
    {
        // Fields
        public System.Single Start;  // 0x10
        public System.Single End;  // 0x14

        // Properties
        System.Boolean IsEmpty { get; /* RVA: 0x0556ECCC */ }
        Cinemachine.TargetPositionCache.TimeRange Empty { get; /* RVA: 0x03D50AC0 */ }

        // Methods
        // RVA: 0x0556EC98  token: 0x6000382
        public System.Boolean Contains(System.Single time) { }
        // RVA: 0x0556ECAC  token: 0x6000384
        public System.Void Include(System.Single time) { }

    }

    // TypeToken: 0x20000A4  // size: 0x14
    public sealed struct UpdateClock
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.UpdateTracker.UpdateClock Fixed;  // const
        public static Cinemachine.UpdateTracker.UpdateClock Late;  // const

    }

    // TypeToken: 0x20000A5  // size: 0x68
    public class UpdateStatus
    {
        // Fields
        private System.Int32 windowStart;  // 0x10
        private System.Int32 numWindowLateUpdateMoves;  // 0x14
        private System.Int32 numWindowFixedUpdateMoves;  // 0x18
        private System.Int32 numWindows;  // 0x1c
        private System.Int32 lastFrameUpdated;  // 0x20
        private UnityEngine.Matrix4x4 lastPos;  // 0x24
        private Cinemachine.UpdateTracker.UpdateClock <PreferredUpdate>k__BackingField;  // 0x64

        // Properties
        Cinemachine.UpdateTracker.UpdateClock PreferredUpdate { get; /* RVA: 0x03D50B30 */ set; /* RVA: 0x03D50B40 */ }

        // Methods
        // RVA: 0x05575F2C  token: 0x600038C
        public System.Void .ctor(System.Int32 currentFrame, UnityEngine.Matrix4x4 pos) { }
        // RVA: 0x05575E1C  token: 0x600038D
        public System.Void OnUpdate(System.Int32 currentFrame, Cinemachine.UpdateTracker.UpdateClock currentClock, UnityEngine.Matrix4x4 pos) { }

    }

    // TypeToken: 0x20000A7  // size: 0x18
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public UnityEngine.InputSystem.InputActionReference aRef;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000393
        public System.Void .ctor() { }
        // RVA: 0x055758C0  token: 0x6000394
        private System.Boolean <ResolveForPlayer>b__1(UnityEngine.InputSystem.InputAction x) { }

    }

    // TypeToken: 0x20000AA  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Custom;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode PriorityBoost;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Activate;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Deactivate;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Enable;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Disable;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Play;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Stop;  // const

    }

    // TypeToken: 0x20000AB  // size: 0x30
    public class TriggerEvent : UnityEngine.Events.UnityEvent
    {
        // Methods
        // RVA: 0x04271C98  token: 0x60003A4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC  // size: 0x14
    public sealed struct TimeMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode FromStart;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode FromEnd;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode BeforeNow;  // const
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode AfterNow;  // const

    }

    // TypeToken: 0x20000A9  // size: 0x38
    public sealed struct ActionSettings
    {
        // Fields
        public Cinemachine.CinemachineTriggerAction.ActionSettings.Mode m_Action;  // 0x10
        public UnityEngine.Object m_Target;  // 0x18
        public System.Int32 m_BoostAmount;  // 0x20
        public System.Single m_StartTime;  // 0x24
        public Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode m_Mode;  // 0x28
        public Cinemachine.CinemachineTriggerAction.ActionSettings.TriggerEvent m_Event;  // 0x30

        // Methods
        // RVA: 0x0556F96C  token: 0x60003A2
        public System.Void .ctor(Cinemachine.CinemachineTriggerAction.ActionSettings.Mode action) { }
        // RVA: 0x0556F508  token: 0x60003A3
        public System.Void Invoke() { }

    }

    // TypeToken: 0x20000B1  // size: 0x14
    public sealed struct ImpulseShapes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Custom;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Recoil;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Bump;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Explosion;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Rumble;  // const

    }

    // TypeToken: 0x20000B2  // size: 0x14
    public sealed struct ImpulseTypes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Uniform;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Dissipating;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Propagating;  // const
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Legacy;  // const

    }

    // TypeToken: 0x20000B3  // size: 0x14
    public sealed struct RepeatMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineImpulseDefinition.RepeatMode Stretch;  // const
        public static Cinemachine.CinemachineImpulseDefinition.RepeatMode Loop;  // const

    }

    // TypeToken: 0x20000B4  // size: 0x28
    public class SignalSource : Cinemachine.ISignalSource6D
    {
        // Fields
        private Cinemachine.CinemachineImpulseDefinition m_Def;  // 0x10
        private UnityEngine.Vector3 m_Velocity;  // 0x18

        // Properties
        System.Single SignalDuration { get; /* RVA: 0x05574930 */ }

        // Methods
        // RVA: 0x05574900  token: 0x60003C2
        public System.Void .ctor(Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity) { }
        // RVA: 0x05574828  token: 0x60003C4
        public virtual System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x20000B5  // size: 0x28
    public class LegacySignalSource : Cinemachine.ISignalSource6D
    {
        // Fields
        private Cinemachine.CinemachineImpulseDefinition m_Def;  // 0x10
        private UnityEngine.Vector3 m_Velocity;  // 0x18
        private System.Single m_StartTimeOffset;  // 0x24

        // Properties
        System.Single SignalDuration { get; /* RVA: 0x05574590 */ }

        // Methods
        // RVA: 0x05574510  token: 0x60003C5
        public System.Void .ctor(Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity) { }
        // RVA: 0x05574304  token: 0x60003C7
        public virtual System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x20000B7  // size: 0x40
    public sealed struct ImpulseReaction
    {
        // Fields
        public Cinemachine.NoiseSettings m_SecondaryNoise;  // 0x10
        public System.Single m_AmplitudeGain;  // 0x18
        public System.Single m_FrequencyGain;  // 0x1c
        public System.Single m_Duration;  // 0x20
        private System.Single m_CurrentAmount;  // 0x24
        private System.Single m_CurrentTime;  // 0x28
        private System.Single m_CurrentDamping;  // 0x2c
        private System.Boolean m_Initialized;  // 0x30
        private UnityEngine.Vector3 m_NoiseOffsets;  // 0x34

        // Methods
        // RVA: 0x05574280  token: 0x60003CB
        public System.Void ReSeed() { }
        // RVA: 0x02743FE0  token: 0x60003CC
        public System.Boolean GetReaction(System.Single deltaTime, UnityEngine.Vector3 impulsePos, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x20000BA  // size: 0x30
    public sealed struct EnvelopeDefinition
    {
        // Fields
        public UnityEngine.AnimationCurve m_AttackShape;  // 0x10
        public UnityEngine.AnimationCurve m_DecayShape;  // 0x18
        public System.Single m_AttackTime;  // 0x20
        public System.Single m_SustainTime;  // 0x24
        public System.Single m_DecayTime;  // 0x28
        public System.Boolean m_ScaleWithImpact;  // 0x2c
        public System.Boolean m_HoldForever;  // 0x2d

        // Properties
        System.Single Duration { get; /* RVA: 0x05573430 */ }

        // Methods
        // RVA: 0x03D50AE0  token: 0x60003D7
        public static Cinemachine.CinemachineImpulseManager.EnvelopeDefinition Default() { }
        // RVA: 0x055732E8  token: 0x60003D9
        public System.Single GetValueAt(System.Single offset) { }
        // RVA: 0x0557328C  token: 0x60003DA
        public System.Void ChangeStopTime(System.Single offset, System.Boolean forceNoDecay) { }
        // RVA: 0x055732B8  token: 0x60003DB
        public System.Void Clear() { }
        // RVA: 0x05573404  token: 0x60003DC
        public System.Void Validate() { }

    }

    // TypeToken: 0x20000BC  // size: 0x14
    public sealed struct DirectionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode Fixed;  // const
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode RotateTowardSource;  // const

    }

    // TypeToken: 0x20000BD  // size: 0x14
    public sealed struct DissipationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode LinearDecay;  // const
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode SoftDecay;  // const
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode ExponentialDecay;  // const

    }

    // TypeToken: 0x20000BB  // size: 0x70
    public class ImpulseEvent
    {
        // Fields
        public System.Single m_StartTime;  // 0x10
        public Cinemachine.CinemachineImpulseManager.EnvelopeDefinition m_Envelope;  // 0x18
        public Cinemachine.ISignalSource6D m_SignalSource;  // 0x38
        public UnityEngine.Vector3 m_Position;  // 0x40
        public System.Single m_Radius;  // 0x4c
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;  // 0x50
        public System.Int32 m_Channel;  // 0x54
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;  // 0x58
        public System.Single m_DissipationDistance;  // 0x5c
        public System.Single m_CustomDissipation;  // 0x60
        public System.Single m_PropagationSpeed;  // 0x64
        public System.Boolean m_IgnoreDistance;  // 0x68

        // Properties
        System.Boolean Expired { get; /* RVA: 0x055741E4 */ }

        // Methods
        // RVA: 0x05573D1C  token: 0x60003DE
        public System.Void Cancel(System.Single time, System.Boolean forceNoDecay) { }
        // RVA: 0x05573D98  token: 0x60003DF
        public System.Single DistanceDecay(System.Single distance) { }
        // RVA: 0x05573E84  token: 0x60003E0
        public System.Boolean GetDecayedSignal(UnityEngine.Vector3 listenerPosition, System.Boolean use2D, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        // RVA: 0x05573D34  token: 0x60003E1
        public System.Void Clear() { }
        // RVA: 0x0350B670  token: 0x60003E2
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3  // size: 0x80
    public sealed class OnGUIDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02E30410  token: 0x60003F9
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x60003FA
        public virtual System.Void Invoke() { }

    }

    // TypeToken: 0x20000C7  // size: 0x24
    public sealed struct Item
    {
        // Fields
        public UnityEngine.Vector3 velocity;  // 0x10
        public System.Single weight;  // 0x1c
        public System.Single time;  // 0x20

    }

    // TypeToken: 0x20000CC  // size: 0x1C
    public sealed struct __StaticArrayInitTypeSize=12
    {
    }

    // TypeToken: 0x20000CB  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32;  // static @ 0x0

    }

namespace Cinemachine
{

    // TypeToken: 0x200000A  // size: 0x58
    public class Cinemachine3rdPersonAim : Cinemachine.CinemachineExtension
    {
        // Fields
        public UnityEngine.LayerMask AimCollisionFilter;  // 0x28
        public System.String IgnoreTag;  // 0x30
        public System.Single AimDistance;  // 0x38
        public UnityEngine.RectTransform AimTargetReticle;  // 0x40
        private UnityEngine.Vector3 <AimTarget>k__BackingField;  // 0x48

        // Properties
        UnityEngine.Vector3 AimTarget { get; /* RVA: 0x03D50020 */ set; /* RVA: 0x03D50040 */ }

        // Methods
        // RVA: 0x05548F0C  token: 0x600001C
        private System.Void OnValidate() { }
        // RVA: 0x0554912C  token: 0x600001D
        private System.Void Reset() { }
        // RVA: 0x05548DE0  token: 0x600001E
        public virtual System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05548C24  token: 0x600001F
        private System.Void DrawReticle(Cinemachine.CinemachineBrain brain) { }
        // RVA: 0x05548920  token: 0x6000020
        private UnityEngine.Vector3 ComputeLookAtPoint(UnityEngine.Vector3 camPos, UnityEngine.Transform player) { }
        // RVA: 0x05548794  token: 0x6000021
        private UnityEngine.Vector3 ComputeAimTarget(UnityEngine.Vector3 cameraLookAt, UnityEngine.Transform player) { }
        // RVA: 0x05548F24  token: 0x6000022
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x05549190  token: 0x6000023
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x210
    public class CinemachineBlendListCamera : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;  // 0xa8
        public UnityEngine.Transform m_Follow;  // 0xb0
        public System.Boolean m_ShowDebugText;  // 0xb8
        public System.Boolean m_Loop;  // 0xb9
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;  // 0xc0
        public Cinemachine.CinemachineBlendListCamera.Instruction[] m_Instructions;  // 0xc8
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;  // 0xd0
        private Cinemachine.ICinemachineCamera m_TransitioningFrom;  // 0xd8
        private Cinemachine.CameraState m_State;  // 0xe0
        private System.Single mActivationTime;  // 0x200
        private System.Int32 mCurrentInstruction;  // 0x204
        private Cinemachine.CinemachineBlend mActiveBlend;  // 0x208

        // Properties
        System.String Description { get; /* RVA: 0x0554A6C8 */ }
        Cinemachine.ICinemachineCamera LiveChild { get; /* RVA: 0x03D50050 */ set; /* RVA: 0x0554A7E0 */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D50060 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x0554A7D0 */ set; /* RVA: 0x0554A7F4 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x0554A7B4 */ set; /* RVA: 0x02B47080 */ }
        Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; /* RVA: 0x0554A6A8 */ }
        System.Boolean IsBlending { get; /* RVA: 0x0554A7C4 */ }

        // Methods
        // RVA: 0x0554A1E8  token: 0x6000025
        private System.Void Reset() { }
        // RVA: 0x05549B6C  token: 0x6000028
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x05549FF4  token: 0x600002E
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x05549470  token: 0x600002F
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0554A0C0  token: 0x6000030
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05549550  token: 0x6000031
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05549CAC  token: 0x6000032
        protected virtual System.Void OnEnable() { }
        // RVA: 0x05549B94  token: 0x6000033
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0554A0B8  token: 0x6000034
        private System.Void OnTransformChildrenChanged() { }
        // RVA: 0x05549EB0  token: 0x6000035
        private System.Void OnGuiHandler() { }
        // RVA: 0x05549B38  token: 0x6000038
        private System.Void InvalidateListOfChildren() { }
        // RVA: 0x0554A24C  token: 0x6000039
        private System.Void UpdateListOfChildren() { }
        // RVA: 0x0554A3EC  token: 0x600003A
        private System.Void ValidateInstructions() { }
        // RVA: 0x0554926C  token: 0x600003B
        private System.Void AdvanceCurrentInstruction(System.Single deltaTime) { }
        // RVA: 0x0554A570  token: 0x600003C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x1D0
    public class CinemachineBrain : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean m_ShowDebugText;  // 0x18
        public System.Boolean m_ShowCameraFrustum;  // 0x19
        public System.Boolean m_IgnoreTimeScale;  // 0x1a
        public UnityEngine.Transform m_WorldUpOverride;  // 0x20
        public Cinemachine.CinemachineBrain.UpdateMethod m_UpdateMethod;  // 0x28
        public Cinemachine.CinemachineBrain.BrainUpdateMethod m_BlendUpdateMethod;  // 0x2c
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;  // 0x30
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;  // 0x48
        private UnityEngine.Camera m_OutputCamera;  // 0x50
        private HG.Rendering.Runtime.HGDepthOfField m_OutputDOF;  // 0x58
        public Cinemachine.CinemachineBrain.BrainEvent m_CameraCutEvent;  // 0x60
        public Cinemachine.CinemachineBrain.VcamActivatedEvent m_CameraActivatedEvent;  // 0x68
        private static Cinemachine.ICinemachineCamera mSoloCamera;  // static @ 0x0
        private UnityEngine.Coroutine mPhysicsCoroutine;  // 0x70
        private System.Int32 m_LastFrameUpdated;  // 0x78
        private UnityEngine.WaitForFixedUpdate mWaitForFixedUpdate;  // 0x80
        private System.Collections.Generic.List<Cinemachine.CinemachineBrain.BrainFrame> mFrameStack;  // 0x88
        private System.Int32 mNextFrameId;  // 0x90
        private Cinemachine.CinemachineBlend mCurrentLiveCameras;  // 0x98
        private static readonly UnityEngine.AnimationCurve mDefaultLinearAnimationCurve;  // static @ 0x8
        private Cinemachine.ICinemachineCamera mActiveCameraPreviousFrame;  // 0xa0
        private UnityEngine.GameObject mActiveCameraPreviousFrameGameObject;  // 0xa8
        private Cinemachine.CameraState <CurrentCameraState>k__BackingField;  // 0xb0

        // Properties
        UnityEngine.Camera OutputCamera { get; /* RVA: 0x0274AEA0 */ }
        HG.Rendering.Runtime.HGDepthOfField OutputDOF { get; /* RVA: 0x0274CFA0 */ }
        Cinemachine.ICinemachineCamera SoloCamera { get; /* RVA: 0x0554B244 */ set; /* RVA: 0x0554B30C */ }
        UnityEngine.Vector3 DefaultWorldUp { get; /* RVA: 0x0274AD70 */ }
        Cinemachine.ICinemachineCamera ActiveVirtualCamera { get; /* RVA: 0x0274B6E0 */ }
        System.Boolean IsBlending { get; /* RVA: 0x0274C110 */ }
        Cinemachine.CinemachineBlend ActiveBlend { get; /* RVA: 0x0274B590 */ }
        Cinemachine.CameraState CurrentCameraState { get; /* RVA: 0x03D500E0 */ set; /* RVA: 0x0554B294 */ }

        // Methods
        // RVA: 0x0554A914  token: 0x6000041
        public static UnityEngine.Color GetSoloGUIColor() { }
        // RVA: 0x03170450  token: 0x6000043
        private System.Void OnEnable() { }
        // RVA: 0x0554AA38  token: 0x6000044
        private System.Void OnDisable() { }
        // RVA: 0x0554AF28  token: 0x6000045
        private System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        // RVA: 0x03D44A60  token: 0x6000046
        private System.Void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene) { }
        // RVA: 0x03D4C3C0  token: 0x6000047
        private System.Void Start() { }
        // RVA: 0x0554AC68  token: 0x6000048
        private System.Void OnGuiHandler() { }
        // RVA: 0x03170830  token: 0x6000049
        private System.Collections.IEnumerator AfterPhysics() { }
        // RVA: 0x033E09D0  token: 0x600004A
        private System.Void LateUpdate() { }
        // RVA: 0x0274D5E0  token: 0x600004B
        public System.Void ManualUpdate(System.Single deltaTime) { }
        // RVA: 0x0274DF40  token: 0x600004C
        private System.Single GetEffectiveDeltaTime(System.Boolean fixedDelta) { }
        // RVA: 0x0274A9C0  token: 0x600004D
        private System.Void UpdateVirtualCameras(Cinemachine.CinemachineCore.UpdateFilter updateFilter, System.Single deltaTime) { }
        // RVA: 0x0274B820  token: 0x600004F
        private static Cinemachine.ICinemachineCamera DeepCamBFromBlend(Cinemachine.CinemachineBlend blend) { }
        // RVA: 0x0554A970  token: 0x6000050
        public System.Boolean IsLiveInBlend(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x0554A808  token: 0x6000053
        private System.Int32 GetBrainFrame(System.Int32 withId) { }
        // RVA: 0x0554B044  token: 0x6000054
        public System.Int32 SetCameraOverride(System.Int32 overrideId, Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, System.Single weightB, System.Single deltaTime) { }
        // RVA: 0x0554AF8C  token: 0x6000055
        public System.Void ReleaseCameraOverride(System.Int32 overrideId) { }
        // RVA: 0x0274C180  token: 0x6000056
        private System.Void ProcessActiveCamera(System.Single deltaTime) { }
        // RVA: 0x0274D7C0  token: 0x6000057
        private System.Void UpdateFrame0(System.Single deltaTime) { }
        // RVA: 0x0274DAF0  token: 0x6000058
        public System.Void ComputeCurrentBlend(Cinemachine.CinemachineBlend& outputBlend, System.Int32 numTopLayersToExclude) { }
        // RVA: 0x0274B600  token: 0x6000059
        public System.Boolean IsLive(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x0274A2C0  token: 0x600005C
        public Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue() { }
        // RVA: 0x0332D8C0  token: 0x600005D
        private Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey) { }
        // RVA: 0x0274C7D0  token: 0x600005E
        private System.Void PushStateToUnityCamera(Cinemachine.CameraState& state) { }
        // RVA: 0x03171500  token: 0x600005F
        public System.Void .ctor() { }
        // RVA: 0x03D02A80  token: 0x6000060
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x250
    public class CinemachineClearShot : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;  // 0xa8
        public UnityEngine.Transform m_Follow;  // 0xb0
        public System.Boolean m_ShowDebugText;  // 0xb8
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;  // 0xc0
        public System.Single m_ActivateAfter;  // 0xc8
        public System.Single m_MinDuration;  // 0xcc
        public System.Boolean m_RandomizeChoice;  // 0xd0
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;  // 0xd8
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;  // 0xf0
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;  // 0xf8
        private Cinemachine.CameraState m_State;  // 0x100
        private System.Single mActivationTime;  // 0x220
        private System.Single mPendingActivationTime;  // 0x224
        private Cinemachine.ICinemachineCamera mPendingCamera;  // 0x228
        private Cinemachine.CinemachineBlend mActiveBlend;  // 0x230
        private System.Boolean mRandomizeNow;  // 0x238
        private Cinemachine.CinemachineVirtualCameraBase[] m_RandomizedChilden;  // 0x240
        private Cinemachine.ICinemachineCamera m_TransitioningFrom;  // 0x248

        // Properties
        System.String Description { get; /* RVA: 0x0554D1E8 */ }
        Cinemachine.ICinemachineCamera LiveChild { get; /* RVA: 0x03D50160 */ set; /* RVA: 0x0554D2E0 */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D50170 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x0554A7D0 */ set; /* RVA: 0x0554A7F4 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x0554A7B4 */ set; /* RVA: 0x02B47080 */ }
        System.Boolean IsBlending { get; /* RVA: 0x0554D2D4 */ }
        Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; /* RVA: 0x0554D1C8 */ }

        // Methods
        // RVA: 0x0554C3E4  token: 0x600006F
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x0554CA30  token: 0x6000074
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x0554BDC8  token: 0x6000075
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0554BEA8  token: 0x6000076
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x0554C6FC  token: 0x6000077
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0554C5E4  token: 0x6000078
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0554CAF4  token: 0x6000079
        public System.Void OnTransformChildrenChanged() { }
        // RVA: 0x0554C8EC  token: 0x600007A
        private System.Void OnGuiHandler() { }
        // RVA: 0x0554C39C  token: 0x600007D
        private System.Void InvalidateListOfChildren() { }
        // RVA: 0x0554CE44  token: 0x600007E
        public System.Void ResetRandomization() { }
        // RVA: 0x0554CE70  token: 0x600007F
        private System.Void UpdateListOfChildren() { }
        // RVA: 0x0554B748  token: 0x6000080
        private Cinemachine.ICinemachineCamera ChooseCurrentCamera(UnityEngine.Vector3 worldUp) { }
        // RVA: 0x0554CC0C  token: 0x6000081
        private Cinemachine.CinemachineVirtualCameraBase[] Randomize(Cinemachine.CinemachineVirtualCameraBase[] src) { }
        // RVA: 0x0554C40C  token: 0x6000082
        private Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey) { }
        // RVA: 0x0554CB14  token: 0x6000083
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x0554D050  token: 0x6000084
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x78
    public class CinemachineCollider : Cinemachine.CinemachineExtension
    {
        // Fields
        public UnityEngine.LayerMask m_CollideAgainst;  // 0x28
        public System.String m_IgnoreTag;  // 0x30
        public UnityEngine.LayerMask m_TransparentLayers;  // 0x38
        public System.Single m_MinimumDistanceFromTarget;  // 0x3c
        public System.Boolean m_AvoidObstacles;  // 0x40
        public System.Single m_DistanceLimit;  // 0x44
        public System.Single m_MinimumOcclusionTime;  // 0x48
        public System.Single m_CameraRadius;  // 0x4c
        public Cinemachine.CinemachineCollider.ResolutionStrategy m_Strategy;  // 0x50
        public System.Boolean m_UseFollowInsteadOfLookAt;  // 0x54
        public System.Int32 m_MaximumEffort;  // 0x58
        public System.Single m_SmoothingTime;  // 0x5c
        public System.Single m_Damping;  // 0x60
        public System.Single m_DampingWhenOccluded;  // 0x64
        public System.Single m_OptimalTargetDistance;  // 0x68
        private static System.Single k_PrecisionSlush;  // const
        private UnityEngine.RaycastHit[] m_CornerBuffer;  // 0x70
        private static System.Single k_AngleThreshold;  // const
        private static UnityEngine.ECSColliderResultProxy[] s_ColliderBuffer;  // static @ 0x0

        // Properties
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> DebugPaths { get; /* RVA: 0x0554F3A0 */ }

        // Methods
        // RVA: 0x0554E000  token: 0x6000088
        public System.Boolean IsTargetObscured(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x0554D2F4  token: 0x6000089
        public System.Boolean CameraWasDisplaced(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x0554D71C  token: 0x600008A
        public System.Single GetCameraDisplacementDistance(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x0554E0A0  token: 0x600008B
        private System.Void OnValidate() { }
        // RVA: 0x0554E058  token: 0x600008C
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0554D778  token: 0x600008E
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x02744D10  token: 0x600008F
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0554E83C  token: 0x6000090
        public System.Void ResetExtraData(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x02744DD0  token: 0x6000091
        public virtual System.Void GuardedPostPipelineStageCallback(Cinemachine.ICinemachineCamera vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x02743480  token: 0x6000092
        private UnityEngine.Vector3 PreserveLineOfSight(Cinemachine.CameraState& state, Cinemachine.CinemachineCollider.VcamExtraState& extra) { }
        // RVA: 0x02743770  token: 0x6000093
        private UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, System.Int32 layerMask, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x0554E0EC  token: 0x6000094
        private UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, System.Single targetDistance, System.Int32 iterations, Cinemachine.CinemachineCollider.VcamExtraState& extra) { }
        // RVA: 0x0554D8F4  token: 0x6000095
        private System.Boolean GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3& outDir) { }
        // RVA: 0x0554D790  token: 0x6000096
        private System.Single GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, System.Single targetDistance, UnityEngine.Vector3 lookAtPos) { }
        // RVA: 0x0554D310  token: 0x6000097
        private static System.Single ClampRayToBounds(UnityEngine.Ray ray, System.Single distance, UnityEngine.Bounds bounds) { }
        // RVA: 0x0554E8DC  token: 0x6000098
        private UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos) { }
        // RVA: 0x02742CB0  token: 0x6000099
        private System.Boolean CheckForTargetObstructions(Cinemachine.CameraState& state) { }
        // RVA: 0x02B24CC0  token: 0x600009A
        private static System.Boolean IsTargetOffscreen(Cinemachine.CameraState& state) { }
        // RVA: 0x039CB1C0  token: 0x600009B
        public System.Void .ctor() { }
        // RVA: 0x03D06980  token: 0x600009C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x60
    public class CinemachineConfiner : Cinemachine.CinemachineExtension
    {
        // Fields
        public Cinemachine.CinemachineConfiner.Mode m_ConfineMode;  // 0x28
        public UnityEngine.Collider m_BoundingVolume;  // 0x30
        public UnityEngine.Collider2D m_BoundingShape2D;  // 0x38
        private UnityEngine.Collider2D m_BoundingShape2DCache;  // 0x40
        public System.Boolean m_ConfineScreenEdges;  // 0x48
        public System.Single m_Damping;  // 0x4c
        private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> m_pathCache;  // 0x50
        private System.Int32 m_pathTotalPointCount;  // 0x58

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x05550ED4 */ }

        // Methods
        // RVA: 0x0554FBCC  token: 0x60000A2
        public System.Boolean CameraWasDisplaced(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x055506AC  token: 0x60000A3
        public System.Single GetCameraDisplacementDistance(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x05550730  token: 0x60000A4
        private System.Void OnValidate() { }
        // RVA: 0x055506A4  token: 0x60000A5
        protected virtual System.Void ConnectToVcam(System.Boolean connect) { }
        // RVA: 0x03D50200  token: 0x60000A7
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x05550740  token: 0x60000A8
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x05550708  token: 0x60000A9
        public System.Void InvalidatePathCache() { }
        // RVA: 0x055509D8  token: 0x60000AA
        private System.Boolean ValidatePathCache() { }
        // RVA: 0x0554FBE8  token: 0x60000AB
        private UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 camPos) { }
        // RVA: 0x05550060  token: 0x60000AC
        private UnityEngine.Vector3 ConfineScreenEdges(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& state) { }
        // RVA: 0x05550EC8  token: 0x60000AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x128
    public class CinemachineConfiner2D : Cinemachine.CinemachineExtension
    {
        // Fields
        public UnityEngine.Collider2D m_BoundingShape2D;  // 0x28
        public System.Single m_Damping;  // 0x30
        public System.Single m_MaxWindowSize;  // 0x34
        private System.Single m_MaxComputationTimePerFrameInSeconds;  // 0x38
        private static System.Single k_cornerAngleTreshold;  // const
        private Cinemachine.CinemachineConfiner2D.ShapeCache m_shapeCache;  // 0x40

        // Methods
        // RVA: 0x0554F604  token: 0x60000AF
        public System.Void InvalidateCache() { }
        // RVA: 0x0554FB80  token: 0x60000B0
        public System.Boolean ValidateCache(System.Single cameraAspectRatio) { }
        // RVA: 0x0554F62C  token: 0x60000B1
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0554F568  token: 0x60000B2
        private System.Single CalculateHalfFrustumHeight(Cinemachine.CameraState& state, System.Single& cameraPosLocalZ) { }
        // RVA: 0x0554F610  token: 0x60000B3
        private System.Void OnValidate() { }
        // RVA: 0x03D501F0  token: 0x60000B4
        private System.Void Reset() { }
        // RVA: 0x0554FBBC  token: 0x60000B5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x38
    public class CinemachineDollyCart : UnityEngine.MonoBehaviour
    {
        // Fields
        public Cinemachine.CinemachinePathBase m_Path;  // 0x18
        public System.Boolean forbidRotation;  // 0x20
        public Cinemachine.CinemachineDollyCart.UpdateMethod m_UpdateMethod;  // 0x24
        public Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;  // 0x28
        public System.Single m_Speed;  // 0x2c
        public System.Single m_Position;  // 0x30

        // Methods
        // RVA: 0x05550FD4  token: 0x60000BB
        private System.Void FixedUpdate() { }
        // RVA: 0x055511D0  token: 0x60000BC
        private System.Void Update() { }
        // RVA: 0x05551024  token: 0x60000BD
        private System.Void LateUpdate() { }
        // RVA: 0x05551088  token: 0x60000BE
        private System.Void SetCartPosition(System.Single distanceAlongPath) { }
        // RVA: 0x039CB270  token: 0x60000BF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x1E8
    public class CinemachineExternalCamera : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;  // 0xa8
        private UnityEngine.Camera m_Camera;  // 0xb0
        private Cinemachine.CameraState m_State;  // 0xb8
        private UnityEngine.Transform <Follow>k__BackingField;  // 0x1d8
        public Cinemachine.CinemachineVirtualCameraBase.BlendHint m_BlendHint;  // 0x1e0

        // Properties
        Cinemachine.CameraState State { get; /* RVA: 0x03D50220 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x03D4EB10 */ set; /* RVA: 0x03D4CCB0 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x03D50210 */ set; /* RVA: 0x03D4CCD0 */ }

        // Methods
        // RVA: 0x05551230  token: 0x60000C5
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x03394E70  token: 0x60000C6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x38
    public class CinemachineFollowZoom : Cinemachine.CinemachineExtension
    {
        // Fields
        public System.Single m_Width;  // 0x28
        public System.Single m_Damping;  // 0x2c
        public System.Single m_MinFOV;  // 0x30
        public System.Single m_MaxFOV;  // 0x34

        // Methods
        // RVA: 0x055517FC  token: 0x60000C7
        private System.Void OnValidate() { }
        // RVA: 0x03D4F3A0  token: 0x60000C8
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x02742760  token: 0x60000C9
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x039CB190  token: 0x60000CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x3B8
    public class CinemachineFreeLook : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;  // 0xa8
        public UnityEngine.Transform m_Follow;  // 0xb0
        public System.Boolean m_CommonLens;  // 0xb8
        public Cinemachine.LensSettings m_Lens;  // 0xbc
        public Cinemachine.CinemachineVirtualCameraBase.TransitionParams m_Transitions;  // 0xf0
        private Cinemachine.CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint;  // 0x100
        public Cinemachine.AxisState m_YAxis;  // 0x108
        public Cinemachine.AxisState.Recentering m_YAxisRecentering;  // 0x178
        public Cinemachine.AxisState m_XAxis;  // 0x198
        public Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;  // 0x208
        public Cinemachine.AxisState.Recentering m_RecenterToTargetHeading;  // 0x214
        public Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;  // 0x230
        public System.Single m_SplineCurvature;  // 0x234
        public Cinemachine.CinemachineFreeLook.Orbit[] m_Orbits;  // 0x238
        private System.Single m_LegacyHeadingBias;  // 0x240
        private System.Boolean mUseLegacyRigDefinitions;  // 0x244
        private System.Boolean mIsDestroyed;  // 0x245
        private Cinemachine.CameraState m_State;  // 0x248
        private Cinemachine.CinemachineVirtualCamera[] m_Rigs;  // 0x368
        private Cinemachine.CinemachineOrbitalTransposer[] mOrbitals;  // 0x370
        private Cinemachine.CinemachineBlend mBlendA;  // 0x378
        private Cinemachine.CinemachineBlend mBlendB;  // 0x380
        public static Cinemachine.CinemachineFreeLook.CreateRigDelegate CreateRigOverride;  // static @ 0x0
        public static Cinemachine.CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride;  // static @ 0x8
        private System.Single m_CachedXAxisHeading;  // 0x388
        private Cinemachine.CinemachineFreeLook.Orbit[] m_CachedOrbits;  // 0x390
        private System.Single m_CachedTension;  // 0x398
        private UnityEngine.Vector4[] m_CachedKnots;  // 0x3a0
        private UnityEngine.Vector4[] m_CachedCtrl1;  // 0x3a8
        private UnityEngine.Vector4[] m_CachedCtrl2;  // 0x3b0

        // Properties
        System.String[] RigNames { get; /* RVA: 0x05555734 */ }
        System.Boolean PreviousStateIsValid { get; /* RVA: 0x03D4F7E0 */ set; /* RVA: 0x055557DC */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D502A0 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x0554A7D0 */ set; /* RVA: 0x0554A7F4 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x0554A7B4 */ set; /* RVA: 0x02B47080 */ }

        // Methods
        // RVA: 0x055541C8  token: 0x60000CC
        protected virtual System.Void OnValidate() { }
        // RVA: 0x05552914  token: 0x60000CD
        public Cinemachine.CinemachineVirtualCamera GetRig(System.Int32 i) { }
        // RVA: 0x05553D40  token: 0x60000CF
        protected virtual System.Void OnEnable() { }
        // RVA: 0x05554E08  token: 0x60000D0
        public System.Void UpdateInputAxisProvider() { }
        // RVA: 0x05553C24  token: 0x60000D1
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x05553354  token: 0x60000D2
        private System.Void OnTransformChildrenChanged() { }
        // RVA: 0x05554960  token: 0x60000D3
        private System.Void Reset() { }
        // RVA: 0x0555336C  token: 0x60000DB
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x05553D80  token: 0x60000DC
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x055523F4  token: 0x60000DD
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x05552D38  token: 0x60000DE
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05553E44  token: 0x60000DF
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x0232EB60  token: 0x60000E0
        private virtual System.Boolean RequiresUserInput() { }
        // RVA: 0x05552964  token: 0x60000E1
        private System.Single GetYAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up) { }
        // RVA: 0x05553354  token: 0x60000E2
        private System.Void InvalidateRigCache() { }
        // RVA: 0x05551F70  token: 0x60000E3
        private System.Void DestroyRigs() { }
        // RVA: 0x05551B1C  token: 0x60000E4
        private Cinemachine.CinemachineVirtualCamera[] CreateRigs(Cinemachine.CinemachineVirtualCamera[] copyFrom) { }
        // RVA: 0x05554E9C  token: 0x60000E5
        private System.Void UpdateRigCache() { }
        // RVA: 0x05553478  token: 0x60000E6
        private System.Int32 LocateExistingRigs(System.String[] rigNames, System.Boolean forceOrbital) { }
        // RVA: 0x055550D4  token: 0x60000E7
        private System.Single UpdateXAxisHeading(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up) { }
        // RVA: 0x05554308  token: 0x60000E8
        private System.Void PushSettingsToRigs() { }
        // RVA: 0x05552D08  token: 0x60000E9
        private System.Single GetYAxisValue() { }
        // RVA: 0x05551858  token: 0x60000EA
        private Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x055526D4  token: 0x60000EB
        public UnityEngine.Vector3 GetLocalPositionForCameraFromInput(System.Single t) { }
        // RVA: 0x05554968  token: 0x60000EC
        private System.Void UpdateCachedSpline() { }
        // RVA: 0x05555264  token: 0x60000ED
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x210
    public class CinemachineMixingCamera : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public static System.Int32 MaxCameras;  // const
        public System.Single m_Weight0;  // 0xa8
        public System.Single m_Weight1;  // 0xac
        public System.Single m_Weight2;  // 0xb0
        public System.Single m_Weight3;  // 0xb4
        public System.Single m_Weight4;  // 0xb8
        public System.Single m_Weight5;  // 0xbc
        public System.Single m_Weight6;  // 0xc0
        public System.Single m_Weight7;  // 0xc4
        private Cinemachine.CameraState m_State;  // 0xc8
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;  // 0x1e8
        private UnityEngine.Transform <LookAt>k__BackingField;  // 0x1f0
        private UnityEngine.Transform <Follow>k__BackingField;  // 0x1f8
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;  // 0x200
        private System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase,System.Int32> m_indexMap;  // 0x208

        // Properties
        Cinemachine.ICinemachineCamera LiveChild { get; /* RVA: 0x03D50350 */ set; /* RVA: 0x05556FCC */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D50370 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x03D50360 */ set; /* RVA: 0x05556FE0 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x03D50340 */ set; /* RVA: 0x05556FB8 */ }
        Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; /* RVA: 0x05556F98 */ }

        // Methods
        // RVA: 0x05556150  token: 0x60000F3
        public System.Single GetWeight(System.Int32 index) { }
        // RVA: 0x05556AF4  token: 0x60000F4
        public System.Void SetWeight(System.Int32 index, System.Single w) { }
        // RVA: 0x05556034  token: 0x60000F5
        public System.Single GetWeight(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x055569CC  token: 0x60000F6
        public System.Void SetWeight(Cinemachine.CinemachineVirtualCameraBase vcam, System.Single w) { }
        // RVA: 0x05556750  token: 0x60000FE
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x05555F54  token: 0x60000FF
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x05556730  token: 0x6000100
        protected virtual System.Void OnEnable() { }
        // RVA: 0x05556814  token: 0x6000101
        public System.Void OnTransformChildrenChanged() { }
        // RVA: 0x05556970  token: 0x6000102
        protected virtual System.Void OnValidate() { }
        // RVA: 0x05556694  token: 0x6000103
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x0555664C  token: 0x6000105
        protected System.Void InvalidateListOfChildren() { }
        // RVA: 0x05556C04  token: 0x6000106
        protected System.Void ValidateListOfChildren() { }
        // RVA: 0x0555681C  token: 0x6000107
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05556254  token: 0x6000108
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05556E34  token: 0x6000109
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002A  // size: 0x58
    public class CinemachinePath : Cinemachine.CinemachinePathBase
    {
        // Fields
        public System.Boolean m_Looped;  // 0x48
        public Cinemachine.CinemachinePath.Waypoint[] m_Waypoints;  // 0x50

        // Properties
        System.Single MinPos { get; /* RVA: 0x03D503F0 */ }
        System.Single MaxPos { get; /* RVA: 0x05557944 */ }
        System.Boolean Looped { get; /* RVA: 0x03D4EFE0 */ }
        System.Int32 DistanceCacheSampleStepsPerSegment { get; /* RVA: 0x020D1AC0 */ }

        // Methods
        // RVA: 0x055577D4  token: 0x600010D
        private System.Void Reset() { }
        // RVA: 0x055576EC  token: 0x600010F
        private System.Single GetBoundingIndices(System.Single pos, System.Int32& indexA, System.Int32& indexB) { }
        // RVA: 0x05557284  token: 0x6000110
        public virtual UnityEngine.Vector3 EvaluatePosition(System.Single pos) { }
        // RVA: 0x05557494  token: 0x6000111
        public virtual UnityEngine.Vector3 EvaluateTangent(System.Single pos) { }
        // RVA: 0x05556FF4  token: 0x6000112
        public virtual UnityEngine.Quaternion EvaluateOrientation(System.Single pos) { }
        // RVA: 0x055577C4  token: 0x6000113
        private System.Void OnValidate() { }
        // RVA: 0x055578F4  token: 0x6000114
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x18
    public sealed class CinemachinePipeline : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x6000115
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x18
    public class CinemachinePixelPerfect : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x6000116
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x70
    public class CinemachineSmoothPath : Cinemachine.CinemachinePathBase
    {
        // Fields
        public System.Boolean m_Looped;  // 0x48
        public Cinemachine.CinemachineSmoothPath.Waypoint[] m_Waypoints;  // 0x50
        private Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints1;  // 0x58
        private Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints2;  // 0x60
        private System.Boolean m_IsLoopedCache;  // 0x68

        // Properties
        System.Single MinPos { get; /* RVA: 0x03D503F0 */ }
        System.Single MaxPos { get; /* RVA: 0x05557944 */ }
        System.Boolean Looped { get; /* RVA: 0x03D4EFE0 */ }
        System.Int32 DistanceCacheSampleStepsPerSegment { get; /* RVA: 0x020D1AC0 */ }

        // Methods
        // RVA: 0x055577C4  token: 0x600011B
        private System.Void OnValidate() { }
        // RVA: 0x05560F34  token: 0x600011C
        private System.Void Reset() { }
        // RVA: 0x05560F00  token: 0x600011D
        public virtual System.Void InvalidateDistanceCache() { }
        // RVA: 0x0556103C  token: 0x600011E
        private System.Void UpdateControlPoints() { }
        // RVA: 0x05560E54  token: 0x600011F
        private System.Single GetBoundingIndices(System.Single pos, System.Int32& indexA, System.Int32& indexB) { }
        // RVA: 0x05560A00  token: 0x6000120
        public virtual UnityEngine.Vector3 EvaluatePosition(System.Single pos) { }
        // RVA: 0x05560BF8  token: 0x6000121
        public virtual UnityEngine.Vector3 EvaluateTangent(System.Single pos) { }
        // RVA: 0x05560770  token: 0x6000122
        public virtual UnityEngine.Quaternion EvaluateOrientation(System.Single pos) { }
        // RVA: 0x03D50720  token: 0x6000123
        private UnityEngine.Quaternion RollAroundForward(System.Single angle) { }
        // RVA: 0x0556126C  token: 0x6000124
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x298
    public class CinemachineStateDrivenCamera : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;  // 0xa8
        public UnityEngine.Transform m_Follow;  // 0xb0
        public UnityEngine.Animator m_AnimatedTarget;  // 0xb8
        public System.Int32 m_LayerIndex;  // 0xc0
        public System.Boolean m_ShowDebugText;  // 0xc4
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;  // 0xc8
        public Cinemachine.CinemachineStateDrivenCamera.Instruction[] m_Instructions;  // 0xd0
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;  // 0xd8
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;  // 0xf0
        private Cinemachine.CinemachineStateDrivenCamera.ParentHash[] m_ParentHash;  // 0xf8
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;  // 0x100
        private Cinemachine.ICinemachineCamera m_TransitioningFrom;  // 0x108
        private Cinemachine.CameraState m_State;  // 0x110
        private System.Collections.Generic.Dictionary<UnityEngine.AnimationClip,System.Collections.Generic.List<Cinemachine.CinemachineStateDrivenCamera.HashPair>> mHashCache;  // 0x230
        private System.Single mActivationTime;  // 0x238
        private Cinemachine.CinemachineStateDrivenCamera.Instruction mActiveInstruction;  // 0x240
        private System.Single mPendingActivationTime;  // 0x258
        private Cinemachine.CinemachineStateDrivenCamera.Instruction mPendingInstruction;  // 0x260
        private Cinemachine.CinemachineBlend mActiveBlend;  // 0x278
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> mInstructionDictionary;  // 0x280
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> mStateParentLookup;  // 0x288
        private System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> m_clipInfoList;  // 0x290

        // Properties
        System.String Description { get; /* RVA: 0x05563104 */ }
        Cinemachine.ICinemachineCamera LiveChild { get; /* RVA: 0x03D50770 */ set; /* RVA: 0x055631FC */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D50780 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x0554A7D0 */ set; /* RVA: 0x0554A7F4 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x0554A7B4 */ set; /* RVA: 0x02B47080 */ }
        Cinemachine.CinemachineVirtualCameraBase[] ChildCameras { get; /* RVA: 0x055630E4 */ }
        System.Boolean IsBlending { get; /* RVA: 0x055631F0 */ }

        // Methods
        // RVA: 0x05562098  token: 0x600012A
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x05562900  token: 0x6000130
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x055618E8  token: 0x6000131
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x055629CC  token: 0x6000132
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05561AE4  token: 0x6000133
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x055625CC  token: 0x6000134
        protected virtual System.Void OnEnable() { }
        // RVA: 0x055624B4  token: 0x6000135
        protected virtual System.Void OnDisable() { }
        // RVA: 0x055629C4  token: 0x6000136
        public System.Void OnTransformChildrenChanged() { }
        // RVA: 0x055627BC  token: 0x6000137
        private System.Void OnGuiHandler() { }
        // RVA: 0x0556186C  token: 0x600013A
        public static System.Int32 CreateFakeHash(System.Int32 parentHash, UnityEngine.AnimationClip clip) { }
        // RVA: 0x05562298  token: 0x600013B
        private System.Int32 LookupFakeHash(System.Int32 parentHash, UnityEngine.AnimationClip clip) { }
        // RVA: 0x05562064  token: 0x600013C
        private System.Void InvalidateListOfChildren() { }
        // RVA: 0x05562A88  token: 0x600013D
        private System.Void UpdateListOfChildren() { }
        // RVA: 0x05562C3C  token: 0x600013E
        private System.Void ValidateInstructions() { }
        // RVA: 0x055612BC  token: 0x600013F
        private Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera() { }
        // RVA: 0x055619C8  token: 0x6000140
        private System.Int32 GetClipHash(System.Int32 hash, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        // RVA: 0x055620C0  token: 0x6000141
        private Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey) { }
        // RVA: 0x05562F08  token: 0x6000142
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x78
    public class CinemachineStoryboard : Cinemachine.CinemachineExtension
    {
        // Fields
        public static System.Boolean s_StoryboardGlobalMute;  // static @ 0x0
        public System.Boolean m_ShowImage;  // 0x28
        public UnityEngine.Texture m_Image;  // 0x30
        public Cinemachine.CinemachineStoryboard.FillStrategy m_Aspect;  // 0x38
        public System.Single m_Alpha;  // 0x3c
        public UnityEngine.Vector2 m_Center;  // 0x40
        public UnityEngine.Vector3 m_Rotation;  // 0x48
        public UnityEngine.Vector2 m_Scale;  // 0x54
        public System.Boolean m_SyncScale;  // 0x5c
        public System.Boolean m_MuteCamera;  // 0x5d
        public System.Single m_SplitView;  // 0x60
        public Cinemachine.CinemachineStoryboard.StoryboardRenderMode m_RenderMode;  // 0x64
        public System.Int32 m_SortingOrder;  // 0x68
        public System.Single m_PlaneDistance;  // 0x6c
        private System.Collections.Generic.List<Cinemachine.CinemachineStoryboard.CanvasInfo> mCanvasInfo;  // 0x70

        // Properties
        System.String CanvasName { get; /* RVA: 0x05564914 */ }

        // Methods
        // RVA: 0x0556457C  token: 0x6000143
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x05564678  token: 0x6000144
        private System.Void UpdateRenderCanvas() { }
        // RVA: 0x055633C0  token: 0x6000145
        protected virtual System.Void ConnectToVcam(System.Boolean connect) { }
        // RVA: 0x05563210  token: 0x6000147
        private System.Void CameraUpdatedCallback(Cinemachine.CinemachineBrain brain) { }
        // RVA: 0x05563B60  token: 0x6000148
        private Cinemachine.CinemachineStoryboard.CanvasInfo LocateMyCanvas(Cinemachine.CinemachineBrain parent, System.Boolean createIfNotFound) { }
        // RVA: 0x05563524  token: 0x6000149
        private System.Void CreateCanvas(Cinemachine.CinemachineStoryboard.CanvasInfo ci) { }
        // RVA: 0x05563970  token: 0x600014A
        private System.Void DestroyCanvas() { }
        // RVA: 0x05563F44  token: 0x600014B
        private System.Void PlaceImage(Cinemachine.CinemachineStoryboard.CanvasInfo ci, System.Single alpha) { }
        // RVA: 0x0259F8B0  token: 0x600014C
        private static System.Void StaticBlendingHandler(Cinemachine.CinemachineBrain brain) { }
        // RVA: 0x03411740  token: 0x600014D
        private static System.Void InitializeModule() { }
        // RVA: 0x0556481C  token: 0x600014E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public interface ICinemachineTargetGroup
    {
        // Properties
        UnityEngine.BoundingSphere Sphere { get; /* RVA: -1  // abstract */ }
        System.Boolean IsEmpty { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000152
        public virtual UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer) { }
        // RVA: -1  // abstract  token: 0x6000153
        public virtual System.Void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, UnityEngine.Vector2& minAngles, UnityEngine.Vector2& maxAngles, UnityEngine.Vector2& zRange) { }

    }

    // TypeToken: 0x2000039  // size: 0x68
    public class CinemachineTargetGroup : UnityEngine.MonoBehaviour, Cinemachine.ICinemachineTargetGroup
    {
        // Fields
        public Cinemachine.CinemachineTargetGroup.PositionMode m_PositionMode;  // 0x18
        public Cinemachine.CinemachineTargetGroup.RotationMode m_RotationMode;  // 0x1c
        public Cinemachine.CinemachineTargetGroup.UpdateMethod m_UpdateMethod;  // 0x20
        public Cinemachine.CinemachineTargetGroup.Target[] m_Targets;  // 0x28
        private UnityEngine.Bounds <BoundingBox>k__BackingField;  // 0x30
        private System.Single m_MaxWeight;  // 0x48
        private UnityEngine.Vector3 m_AveragePos;  // 0x4c
        private UnityEngine.BoundingSphere m_BoundingSphere;  // 0x58

        // Properties
        UnityEngine.Transform Transform { get; /* RVA: 0x04273A88 */ }
        UnityEngine.Bounds BoundingBox { get; /* RVA: 0x03D50800 */ set; /* RVA: 0x03D50830 */ }
        UnityEngine.BoundingSphere Sphere { get; /* RVA: 0x03D50820 */ }
        System.Boolean IsEmpty { get; /* RVA: 0x05565FB8 */ }

        // Methods
        // RVA: 0x05564980  token: 0x6000159
        public System.Void AddMember(UnityEngine.Transform t, System.Single weight, System.Single radius) { }
        // RVA: 0x05565DA0  token: 0x600015A
        public System.Void RemoveMember(UnityEngine.Transform t) { }
        // RVA: 0x05565500  token: 0x600015B
        public System.Int32 FindMember(UnityEngine.Transform t) { }
        // RVA: 0x05565C48  token: 0x600015C
        public UnityEngine.BoundingSphere GetWeightedBoundsForMember(System.Int32 index) { }
        // RVA: 0x05565A50  token: 0x600015D
        public virtual UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer) { }
        // RVA: 0x05565E94  token: 0x600015E
        private static UnityEngine.BoundingSphere WeightedMemberBounds(Cinemachine.CinemachineTargetGroup.Target t, UnityEngine.Vector3 avgPos, System.Single maxWeight) { }
        // RVA: 0x055653B0  token: 0x600015F
        public System.Void DoUpdate() { }
        // RVA: 0x055650D4  token: 0x6000160
        private UnityEngine.BoundingSphere CalculateBoundingSphere(System.Single maxWeight) { }
        // RVA: 0x05564C8C  token: 0x6000161
        private UnityEngine.Vector3 CalculateAveragePosition(System.Single& maxWeight) { }
        // RVA: 0x05564A98  token: 0x6000162
        private UnityEngine.Quaternion CalculateAverageOrientation() { }
        // RVA: 0x05564ED0  token: 0x6000163
        private UnityEngine.Bounds CalculateBoundingBox(UnityEngine.Vector3 avgPos, System.Single maxWeight) { }
        // RVA: 0x05565CF0  token: 0x6000164
        private System.Void OnValidate() { }
        // RVA: 0x055655A0  token: 0x6000165
        private System.Void FixedUpdate() { }
        // RVA: 0x05565E64  token: 0x6000166
        private System.Void Update() { }
        // RVA: 0x05565CE0  token: 0x6000167
        private System.Void LateUpdate() { }
        // RVA: 0x055655B0  token: 0x6000168
        public virtual System.Void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, UnityEngine.Vector2& minAngles, UnityEngine.Vector2& maxAngles, UnityEngine.Vector2& zRange) { }
        // RVA: 0x03CBAF20  token: 0x6000169
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0x240
    public class CinemachineVirtualCamera : Cinemachine.CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;  // 0xa8
        public UnityEngine.Transform m_Follow;  // 0xb0
        public Cinemachine.LensSettings m_Lens;  // 0xb8
        public Cinemachine.CinemachineVirtualCameraBase.TransitionParams m_Transitions;  // 0xe8
        private Cinemachine.CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint;  // 0xf8
        public static System.String PipelineName;  // const
        public static Cinemachine.CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride;  // static @ 0x0
        public static Cinemachine.CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride;  // static @ 0x8
        private System.Boolean m_UserIsDragging;  // 0xfc
        protected Cinemachine.CameraState m_State;  // 0x100
        private Cinemachine.CinemachineComponentBase[] m_ComponentPipeline;  // 0x220
        private UnityEngine.Transform m_ComponentOwner;  // 0x228
        private UnityEngine.Transform mCachedLookAtTarget;  // 0x230
        private Cinemachine.CinemachineVirtualCameraBase mCachedLookAtTargetVcam;  // 0x238

        // Properties
        Cinemachine.CameraState State { get; /* RVA: 0x03D50170 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x02747720 */ set; /* RVA: 0x03D4D0F0 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x02747AF0 */ set; /* RVA: 0x02B47080 */ }

        // Methods
        // RVA: 0x03D50850  token: 0x600016F
        public System.Void SetFieldOfView(System.Single fov) { }
        // RVA: 0x055667D4  token: 0x6000170
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x027470F0  token: 0x6000171
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x033183C0  token: 0x6000172
        protected virtual System.Void OnEnable() { }
        // RVA: 0x05566860  token: 0x6000173
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x05566C40  token: 0x6000174
        protected virtual System.Void OnValidate() { }
        // RVA: 0x042760C0  token: 0x6000175
        private System.Void OnTransformChildrenChanged() { }
        // RVA: 0x05566DE0  token: 0x6000176
        private System.Void Reset() { }
        // RVA: 0x055661D4  token: 0x6000177
        private System.Void DestroyPipeline() { }
        // RVA: 0x05566060  token: 0x6000178
        private UnityEngine.Transform CreatePipeline(Cinemachine.CinemachineVirtualCamera copyFrom) { }
        // RVA: 0x042760C0  token: 0x6000179
        public System.Void InvalidateComponentPipeline() { }
        // RVA: 0x055667B4  token: 0x600017A
        public UnityEngine.Transform GetComponentOwner() { }
        // RVA: 0x04276AE0  token: 0x600017B
        public Cinemachine.CinemachineComponentBase[] GetComponentPipeline() { }
        // RVA: 0x03725D40  token: 0x600017C
        public Cinemachine.CinemachineComponentBase GetCinemachineComponent(Cinemachine.CinemachineCore.Stage stage) { }
        // RVA: -1  // generic def  token: 0x600017D
        public T GetCinemachineComponent() { }
        // RVA: -1  // generic def  token: 0x600017E
        public T AddCinemachineComponent() { }
        // RVA: -1  // generic def  token: 0x600017F
        public System.Void DestroyCinemachineComponent() { }
        // RVA: 0x03001400  token: 0x6000180
        private System.Void UpdateComponentPipeline() { }
        // RVA: 0x030024B0  token: 0x6000181
        private static System.Void SetFlagsForHiddenChild(UnityEngine.GameObject child) { }
        // RVA: 0x02747F60  token: 0x6000182
        protected Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05566A6C  token: 0x6000183
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x05566644  token: 0x6000184
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x03D50860  token: 0x6000185
        private System.Void SetStateRawPosition(UnityEngine.Vector3 pos) { }
        // RVA: 0x03651270  token: 0x6000186
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x05566CAC  token: 0x6000187
        private virtual System.Boolean RequiresUserInput() { }
        // RVA: 0x03394FD0  token: 0x6000188
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x80
    public class Cinemachine3rdPersonFollow : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public UnityEngine.Vector3 Damping;  // 0x20
        public UnityEngine.Vector3 ShoulderOffset;  // 0x2c
        public System.Single VerticalArmLength;  // 0x38
        public System.Single CameraSide;  // 0x3c
        public System.Single CameraDistance;  // 0x40
        public UnityEngine.LayerMask CameraCollisionFilter;  // 0x44
        public System.String IgnoreTag;  // 0x48
        public System.Single CameraRadius;  // 0x50
        public System.Single DampingIntoCollision;  // 0x54
        public System.Single DampingFromCollision;  // 0x58
        public System.Boolean DisableDampingCorrection;  // 0x5c
        private UnityEngine.Vector3 m_PreviousFollowTargetPosition;  // 0x60
        private UnityEngine.Vector3 m_DampingCorrection;  // 0x6c
        private System.Single m_CamPosCollisionCorrection;  // 0x78

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0322EB50 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x05559660  token: 0x6000191
        private System.Void OnValidate() { }
        // RVA: 0x03D50460  token: 0x6000192
        private System.Void Reset() { }
        // RVA: 0x05559560  token: 0x6000193
        private System.Void OnDestroy() { }
        // RVA: 0x05559350  token: 0x6000196
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x02B24230  token: 0x6000197
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x055595A0  token: 0x6000198
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x02B24430  token: 0x6000199
        private System.Void PositionCamera(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x05559374  token: 0x600019A
        public System.Void GetRigPositions(UnityEngine.Vector3& root, UnityEngine.Vector3& shoulder, UnityEngine.Vector3& hand) { }
        // RVA: 0x02B24AE0  token: 0x600019B
        private static UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up) { }
        // RVA: 0x02B242B0  token: 0x600019C
        private System.Void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, UnityEngine.Vector3& shoulder, UnityEngine.Vector3& hand) { }
        // RVA: 0x055590F8  token: 0x600019D
        private UnityEngine.Vector3 BeyondResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single cameraRadius) { }
        // RVA: 0x055596DC  token: 0x600019E
        private UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single deltaTime, System.Single cameraRadius, System.Single& collisionCorrection) { }
        // RVA: 0x0332EB50  token: 0x600019F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x50
    public class CinemachineBasicMultiChannelPerlin : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public Cinemachine.NoiseSettings m_NoiseProfile;  // 0x20
        public UnityEngine.Vector3 m_PivotOffset;  // 0x28
        public System.Single m_AmplitudeGain;  // 0x34
        public System.Single m_FrequencyGain;  // 0x38
        private System.Boolean mInitialized;  // 0x3c
        private System.Single mNoiseTime;  // 0x40
        private UnityEngine.Vector3 mNoiseOffsets;  // 0x44

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0555A110 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x05559AE4  token: 0x60001A2
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0555A034  token: 0x60001A3
        public System.Void ReSeed() { }
        // RVA: 0x05559A2C  token: 0x60001A4
        private System.Void Initialize() { }
        // RVA: 0x0555A0B8  token: 0x60001A5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x110
    public class CinemachineComposer : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public UnityEngine.Vector3 m_TrackedObjectOffset;  // 0x20
        public System.Single m_LookaheadTime;  // 0x2c
        public System.Single m_LookaheadSmoothing;  // 0x30
        public System.Boolean m_LookaheadIgnoreY;  // 0x34
        public System.Single m_HorizontalDamping;  // 0x38
        public System.Single m_VerticalDamping;  // 0x3c
        public System.Single m_ScreenX;  // 0x40
        public System.Single m_ScreenY;  // 0x44
        public System.Single m_DeadZoneWidth;  // 0x48
        public System.Single m_DeadZoneHeight;  // 0x4c
        public System.Single m_SoftZoneWidth;  // 0x50
        public System.Single m_SoftZoneHeight;  // 0x54
        public System.Single m_BiasX;  // 0x58
        public System.Single m_BiasY;  // 0x5c
        public System.Boolean m_CenterOnActivate;  // 0x60
        private UnityEngine.Vector3 <TrackedPoint>k__BackingField;  // 0x64
        private UnityEngine.Vector3 m_CameraPosPrevFrame;  // 0x70
        private UnityEngine.Vector3 m_LookAtPrevFrame;  // 0x7c
        private UnityEngine.Vector2 m_ScreenOffsetPrevFrame;  // 0x88
        private UnityEngine.Quaternion m_CameraOrientationPrevFrame;  // 0x90
        private Cinemachine.Utility.PositionPredictor m_Predictor;  // 0xa0
        private Cinemachine.CinemachineComposer.FovCache mCache;  // 0xa8
        private UnityEngine.Vector2 _lastExtra;  // 0xf8
        private UnityEngine.Vector2 _lastOriginalRotToRect;  // 0x100
        public UnityEngine.Vector2 deadZoneDampFactor;  // 0x108

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x027461F0 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01168950 */ }
        UnityEngine.Vector3 TrackedPoint { get; /* RVA: 0x03D50510 */ set; /* RVA: 0x03D50530 */ }
        UnityEngine.Rect SoftGuideRect { get; /* RVA: 0x027447C0 */ set; /* RVA: 0x0555A420 */ }
        UnityEngine.Rect HardGuideRect { get; /* RVA: 0x02744710 */ set; /* RVA: 0x0555A2B8 */ }

        // Methods
        // RVA: 0x02744360  token: 0x60001AA
        protected virtual UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, System.Single deltaTime) { }
        // RVA: 0x0555A17C  token: 0x60001AB
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x03D504F0  token: 0x60001AC
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0555A16C  token: 0x60001AD
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x02744270  token: 0x60001AE
        public virtual System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x027458A0  token: 0x60001AF
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x03D504D0  token: 0x60001B4
        public System.Void ClearOriginalRotToRect() { }
        // RVA: 0x02746400  token: 0x60001B5
        private System.Void RotateToScreenBounds(Cinemachine.CameraState& state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, UnityEngine.Quaternion& rigOrientation, System.Single fov, System.Single fovH, System.Single deltaTime) { }
        // RVA: 0x027455F0  token: 0x60001B6
        private System.Boolean ClampVerticalBounds(UnityEngine.Rect& r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, System.Single fov) { }
        // RVA: 0x0332EC60  token: 0x60001B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x138
    public class CinemachineFramingTransposer : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public UnityEngine.Vector3 m_TrackedObjectOffset;  // 0x20
        public System.Single m_LookaheadTime;  // 0x2c
        public System.Single m_LookaheadSmoothing;  // 0x30
        public System.Boolean m_LookaheadIgnoreY;  // 0x34
        public System.Single m_XDamping;  // 0x38
        public System.Single m_YDamping;  // 0x3c
        public System.Single m_ZDamping;  // 0x40
        public System.Boolean m_TargetMovementOnly;  // 0x44
        public System.Single m_ScreenX;  // 0x48
        public System.Single m_ScreenY;  // 0x4c
        public System.Single m_CameraDistance;  // 0x50
        public System.Single m_DeadZoneWidth;  // 0x54
        public System.Single m_DeadZoneHeight;  // 0x58
        public System.Single m_DeadZoneDepth;  // 0x5c
        public System.Boolean m_UnlimitedSoftZone;  // 0x60
        public System.Single m_SoftZoneWidth;  // 0x64
        public System.Single m_SoftZoneHeight;  // 0x68
        public System.Single m_BiasX;  // 0x6c
        public System.Single m_BiasY;  // 0x70
        public System.Boolean m_CenterOnActivate;  // 0x74
        public Cinemachine.CinemachineFramingTransposer.FramingMode m_GroupFramingMode;  // 0x78
        public Cinemachine.CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode;  // 0x7c
        public System.Single m_GroupFramingSize;  // 0x80
        public System.Single m_MaxDollyIn;  // 0x84
        public System.Single m_MaxDollyOut;  // 0x88
        public System.Single m_MinimumDistance;  // 0x8c
        public System.Single m_MaximumDistance;  // 0x90
        public System.Single m_MinimumFOV;  // 0x94
        public System.Single m_MaximumFOV;  // 0x98
        public System.Single m_MinimumOrthoSize;  // 0x9c
        public System.Single m_MaximumOrthoSize;  // 0xa0
        private static System.Single kMinimumCameraDistance;  // const
        private static System.Single kMinimumGroupSize;  // const
        private UnityEngine.Vector3 m_PreviousCameraPosition;  // 0xa4
        private Cinemachine.Utility.PositionPredictor m_Predictor;  // 0xb0
        private UnityEngine.Vector3 <TrackedPoint>k__BackingField;  // 0xb8
        private System.Boolean m_InheritingPosition;  // 0xc4
        private System.Single m_prevFOV;  // 0xc8
        private UnityEngine.Quaternion m_prevRotation;  // 0xcc
        private UnityEngine.Bounds <LastBounds>k__BackingField;  // 0xdc
        private UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField;  // 0xf4

        // Properties
        UnityEngine.Rect SoftGuideRect { get; /* RVA: 0x0555C7C8 */ set; /* RVA: 0x0555C978 */ }
        UnityEngine.Rect HardGuideRect { get; /* RVA: 0x0555C6AC */ set; /* RVA: 0x0555C810 */ }
        System.Boolean IsValid { get; /* RVA: 0x0555C764 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01002730 */ }
        System.Boolean BodyAppliesAfterAim { get; /* RVA: 0x0232EB60 */ }
        UnityEngine.Vector3 TrackedPoint { get; /* RVA: 0x03D505C0 */ set; /* RVA: 0x03D50630 */ }
        UnityEngine.Bounds LastBounds { get; /* RVA: 0x03D505A0 */ set; /* RVA: 0x03D50610 */ }
        UnityEngine.Matrix4x4 LastBoundsMatrix { get; /* RVA: 0x03D50570 */ set; /* RVA: 0x03D505E0 */ }

        // Methods
        // RVA: 0x0555C30C  token: 0x60001BE
        private System.Void OnValidate() { }
        // RVA: 0x0555C03C  token: 0x60001C4
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x03D50540  token: 0x60001C5
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0555A96C  token: 0x60001C6
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0555C13C  token: 0x60001C7
        public virtual System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        // RVA: 0x0555C4DC  token: 0x60001C8
        private UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, System.Single orthoSize, System.Single aspect) { }
        // RVA: 0x0555C3F8  token: 0x60001C9
        private UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect) { }
        // RVA: 0x0555AF2C  token: 0x60001CE
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0555AD90  token: 0x60001CF
        private System.Single GetTargetHeight(UnityEngine.Vector2 boundsSize) { }
        // RVA: 0x0555A4E0  token: 0x60001D0
        private UnityEngine.Vector3 ComputeGroupBounds(Cinemachine.ICinemachineTargetGroup group, Cinemachine.CameraState& curState) { }
        // RVA: 0x0555A984  token: 0x60001D1
        private static UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Cinemachine.ICinemachineTargetGroup group, UnityEngine.Vector3& pos, UnityEngine.Quaternion orientation) { }
        // RVA: 0x0555C5B0  token: 0x60001D2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x1A0
    public class CinemachineGroupComposer : Cinemachine.CinemachineComposer
    {
        // Fields
        public System.Single m_GroupFramingSize;  // 0x110
        public Cinemachine.CinemachineGroupComposer.FramingMode m_FramingMode;  // 0x114
        public System.Single m_FrameDamping;  // 0x118
        public Cinemachine.CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode;  // 0x11c
        public System.Single m_MaxDollyIn;  // 0x120
        public System.Single m_MaxDollyOut;  // 0x124
        public System.Single m_MinimumDistance;  // 0x128
        public System.Single m_MaximumDistance;  // 0x12c
        public System.Single m_MinimumFOV;  // 0x130
        public System.Single m_MaximumFOV;  // 0x134
        public System.Single m_MinimumOrthoSize;  // 0x138
        public System.Single m_MaximumOrthoSize;  // 0x13c
        private System.Single m_prevFramingDistance;  // 0x140
        private System.Single m_prevFOV;  // 0x144
        private UnityEngine.Bounds <LastBounds>k__BackingField;  // 0x148
        private UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField;  // 0x160

        // Properties
        UnityEngine.Bounds LastBounds { get; /* RVA: 0x03D50680 */ set; /* RVA: 0x03D506D0 */ }
        UnityEngine.Matrix4x4 LastBoundsMatrix { get; /* RVA: 0x03D50650 */ set; /* RVA: 0x03D506A0 */ }

        // Methods
        // RVA: 0x0555DA08  token: 0x60001D3
        private System.Void OnValidate() { }
        // RVA: 0x0555CA38  token: 0x60001D8
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0555CEB4  token: 0x60001D9
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0555CCDC  token: 0x60001DA
        private System.Single GetTargetHeight(UnityEngine.Vector2 boundsSize) { }
        // RVA: 0x0555CA50  token: 0x60001DB
        private static UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Cinemachine.ICinemachineTargetGroup group, UnityEngine.Matrix4x4 observer, UnityEngine.Vector3& newFwd) { }
        // RVA: 0x0555DAD8  token: 0x60001DC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x30
    public class CinemachineHardLockToTarget : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public System.Single m_Damping;  // 0x20
        private UnityEngine.Vector3 m_PreviousTargetPosition;  // 0x24

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0555DCAC */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x03D4F2E0  token: 0x60001DF
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0555DB50  token: 0x60001E0
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0426FE60  token: 0x60001E1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004D  // size: 0x20
    public class CinemachineHardLookAt : Cinemachine.CinemachineComponentBase
    {
        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0555DED8 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01168950 */ }

        // Methods
        // RVA: 0x0555DD10  token: 0x60001E4
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0426FE60  token: 0x60001E5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x180
    public class CinemachineOrbitalTransposer : Cinemachine.CinemachineTransposer
    {
        // Fields
        public Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;  // 0x98
        public Cinemachine.AxisState.Recentering m_RecenterToTargetHeading;  // 0xa4
        public Cinemachine.AxisState m_XAxis;  // 0xc0
        private System.Single m_LegacyRadius;  // 0x130
        private System.Single m_LegacyHeightOffset;  // 0x134
        private System.Single m_LegacyHeadingBias;  // 0x138
        public System.Boolean m_HeadingIsSlave;  // 0x13c
        private Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater;  // 0x140
        private UnityEngine.Vector3 m_LastTargetPosition;  // 0x148
        private Cinemachine.Utility.HeadingTracker mHeadingTracker;  // 0x158
        private UnityEngine.Rigidbody m_TargetRigidBody;  // 0x160
        private UnityEngine.Transform m_PreviousTarget;  // 0x168
        private UnityEngine.Vector3 m_LastCameraPosition;  // 0x170
        private System.Single m_LastHeading;  // 0x17c

        // Properties
        System.Boolean RequiresUserInput { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: 0x0555F2D4  token: 0x60001E6
        protected virtual System.Void OnValidate() { }
        // RVA: 0x0555F42C  token: 0x60001E7
        public System.Single UpdateHeading(System.Single deltaTime, UnityEngine.Vector3 up, Cinemachine.AxisState& axis) { }
        // RVA: 0x0555F46C  token: 0x60001E8
        public System.Single UpdateHeading(System.Single deltaTime, UnityEngine.Vector3 up, Cinemachine.AxisState& axis, Cinemachine.AxisState.Recentering& recentering, System.Boolean isLive) { }
        // RVA: 0x0555EF98  token: 0x60001E9
        private System.Void OnEnable() { }
        // RVA: 0x0555F5A0  token: 0x60001EA
        public System.Void UpdateInputAxisProvider() { }
        // RVA: 0x0555EFE0  token: 0x60001EB
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x0555DF3C  token: 0x60001EC
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0555F120  token: 0x60001ED
        public virtual System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        // RVA: 0x0555E07C  token: 0x60001EE
        public System.Single GetAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up) { }
        // RVA: 0x0555E8B8  token: 0x60001EF
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0555E39C  token: 0x60001F0
        public virtual UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp) { }
        // RVA: 0x0555E4F8  token: 0x60001F2
        private System.Single GetTargetHeading(System.Single currentHeading, UnityEngine.Quaternion targetOrientation) { }
        // RVA: 0x0555F660  token: 0x60001F3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x148
    public class CinemachinePOV : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public Cinemachine.CinemachinePOV.RecenterTargetMode m_RecenterTarget;  // 0x20
        public Cinemachine.AxisState m_VerticalAxis;  // 0x28
        public Cinemachine.AxisState.Recentering m_VerticalRecentering;  // 0x98
        public Cinemachine.AxisState m_HorizontalAxis;  // 0xb8
        public Cinemachine.AxisState.Recentering m_HorizontalRecentering;  // 0x128
        public System.Boolean m_ApplyBeforeBody;  // 0x144

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x05560768 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01168950 */ }
        System.Boolean RequiresUserInput { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: 0x0555FF78  token: 0x60001FC
        private System.Void OnValidate() { }
        // RVA: 0x0555FDD0  token: 0x60001FD
        private System.Void OnEnable() { }
        // RVA: 0x05560414  token: 0x60001FE
        public System.Void UpdateInputAxisProvider() { }
        // RVA: 0x0350B670  token: 0x60001FF
        public virtual System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0555FB3C  token: 0x6000200
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0555F90C  token: 0x6000201
        public UnityEngine.Vector2 GetRecenterTarget() { }
        // RVA: 0x03D506F0  token: 0x6000202
        private static System.Single NormalizeAngle(System.Single angle) { }
        // RVA: 0x0555F8EC  token: 0x6000203
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0555FDD8  token: 0x6000204
        public virtual System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        // RVA: 0x0555FFF8  token: 0x6000206
        private System.Void SetAxesForRotation(UnityEngine.Quaternion targetRot) { }
        // RVA: 0x0556050C  token: 0x6000207
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x38
    public class CinemachineSameAsFollowTarget : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public System.Single m_Damping;  // 0x20
        private UnityEngine.Quaternion m_PreviousReferenceOrientation;  // 0x24

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0556AF18 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01168950 */ }

        // Methods
        // RVA: 0x03D4F2E0  token: 0x600020A
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0556AE20  token: 0x600020B
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0332EAA0  token: 0x600020C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000056  // size: 0x88
    public class CinemachineTrackedDolly : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public Cinemachine.CinemachinePathBase m_Path;  // 0x20
        public System.Single m_PathPosition;  // 0x28
        public Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;  // 0x2c
        public UnityEngine.Vector3 m_PathOffset;  // 0x30
        public System.Single m_XDamping;  // 0x3c
        public System.Single m_YDamping;  // 0x40
        public System.Single m_ZDamping;  // 0x44
        public Cinemachine.CinemachineTrackedDolly.CameraUpMode m_CameraUp;  // 0x48
        public System.Single m_PitchDamping;  // 0x4c
        public System.Single m_YawDamping;  // 0x50
        public System.Single m_RollDamping;  // 0x54
        public Cinemachine.CinemachineTrackedDolly.AutoDolly m_AutoDolly;  // 0x58
        private System.Single m_PreviousPathPosition;  // 0x68
        private UnityEngine.Quaternion m_PreviousOrientation;  // 0x6c
        private UnityEngine.Vector3 m_PreviousCameraPosition;  // 0x7c

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0556BAA0 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01002730 */ }
        UnityEngine.Vector3 AngularDamping { get; /* RVA: 0x0556BA30 */ }

        // Methods
        // RVA: 0x0556B1B8  token: 0x600020F
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0556B210  token: 0x6000210
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0556AF7C  token: 0x6000211
        private UnityEngine.Quaternion GetCameraOrientationAtPathPoint(UnityEngine.Quaternion pathOrientation, UnityEngine.Vector3 up) { }
        // RVA: 0x0332EAD0  token: 0x6000213
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x98
    public class CinemachineTransposer : Cinemachine.CinemachineComponentBase
    {
        // Fields
        public Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;  // 0x20
        public UnityEngine.Vector3 m_FollowOffset;  // 0x24
        public System.Single m_XDamping;  // 0x30
        public System.Single m_YDamping;  // 0x34
        public System.Single m_ZDamping;  // 0x38
        public Cinemachine.CinemachineTransposer.AngularDampingMode m_AngularDampingMode;  // 0x3c
        public System.Single m_PitchDamping;  // 0x40
        public System.Single m_YawDamping;  // 0x44
        public System.Single m_RollDamping;  // 0x48
        public System.Single m_AngularDamping;  // 0x4c
        private System.Boolean <HideOffsetInInspector>k__BackingField;  // 0x50
        private UnityEngine.Vector3 m_PreviousTargetPosition;  // 0x54
        private UnityEngine.Quaternion m_PreviousReferenceOrientation;  // 0x60
        private UnityEngine.Quaternion m_targetOrientationOnAssign;  // 0x70
        private UnityEngine.Vector3 m_PreviousOffset;  // 0x80
        private UnityEngine.Transform m_previousTarget;  // 0x90

        // Properties
        System.Boolean HideOffsetInInspector { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }
        UnityEngine.Vector3 EffectiveOffset { get; /* RVA: 0x02B23BC0 */ }
        System.Boolean IsValid { get; /* RVA: 0x035FE310 */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: 0x01002730 */ }
        UnityEngine.Vector3 Damping { get; /* RVA: 0x02B22CC0 */ }
        UnityEngine.Vector3 AngularDamping { get; /* RVA: 0x02B22CF0 */ }

        // Methods
        // RVA: 0x0556BED0  token: 0x6000215
        protected virtual System.Void OnValidate() { }
        // RVA: 0x0556BC7C  token: 0x600021B
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x02B238A0  token: 0x600021C
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0556BE10  token: 0x600021D
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x0556BAFC  token: 0x600021E
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x02B22D20  token: 0x600021F
        protected System.Void InitPrevFrameStateInfo(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x02B22EA0  token: 0x6000220
        protected System.Void TrackTarget(System.Single deltaTime, UnityEngine.Vector3 up, UnityEngine.Vector3 desiredCameraOffset, UnityEngine.Vector3& outTargetPosition, UnityEngine.Quaternion& outTargetOrient) { }
        // RVA: 0x02B23C90  token: 0x6000221
        protected UnityEngine.Vector3 GetOffsetForMinimumTargetDistance(UnityEngine.Vector3 dampedTargetPos, UnityEngine.Vector3 cameraOffset, UnityEngine.Vector3 cameraFwd, UnityEngine.Vector3 up, UnityEngine.Vector3 actualTargetPos) { }
        // RVA: 0x0556BCFC  token: 0x6000224
        public virtual UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp) { }
        // RVA: 0x02B237A0  token: 0x6000225
        public UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 worldUp) { }
        // RVA: 0x0332EBB0  token: 0x6000226
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005C  // size: 0x80
    public sealed struct AxisState
    {
        // Fields
        public System.Single Value;  // 0x10
        public Cinemachine.AxisState.SpeedMode m_SpeedMode;  // 0x14
        public System.Single m_MaxSpeed;  // 0x18
        public System.Single m_AccelTime;  // 0x1c
        public System.Single m_DecelTime;  // 0x20
        public System.String m_InputAxisName;  // 0x28
        public System.Single m_InputAxisValue;  // 0x30
        public System.Boolean m_InvertInput;  // 0x34
        public System.Single m_MinValue;  // 0x38
        public System.Single m_MaxValue;  // 0x3c
        public System.Boolean m_Wrap;  // 0x40
        public Cinemachine.AxisState.Recentering m_Recentering;  // 0x44
        private System.Single m_CurrentSpeed;  // 0x60
        private System.Single m_LastUpdateTime;  // 0x64
        private System.Int32 m_LastUpdateFrame;  // 0x68
        private static System.Single Epsilon;  // const
        private Cinemachine.AxisState.IInputAxisProvider m_InputAxisProvider;  // 0x70
        private System.Int32 m_InputAxisIndex;  // 0x78
        private System.Boolean <ValueRangeLocked>k__BackingField;  // 0x7c
        private System.Boolean <HasRecentering>k__BackingField;  // 0x7d

        // Properties
        System.Boolean ValueRangeLocked { set; /* RVA: 0x03D50950 */ }
        System.Boolean HasRecentering { set; /* RVA: 0x03D50940 */ }

        // Methods
        // RVA: 0x05567DD4  token: 0x6000227
        public System.Void .ctor(System.Single minValue, System.Single maxValue, System.Boolean wrap, System.Boolean rangeLocked, System.Single maxSpeed, System.Single accelTime, System.Single decelTime, System.String name, System.Boolean invert) { }
        // RVA: 0x05567D8C  token: 0x6000228
        public System.Void Validate() { }
        // RVA: 0x03D50930  token: 0x6000229
        public System.Void Reset() { }
        // RVA: 0x055679B0  token: 0x600022A
        public System.Void SetInputAxisProvider(System.Int32 axis, Cinemachine.AxisState.IInputAxisProvider provider) { }
        // RVA: 0x055679C0  token: 0x600022B
        public System.Boolean Update(System.Single deltaTime) { }
        // RVA: 0x055676E8  token: 0x600022C
        private System.Single ClampValue(System.Single v) { }
        // RVA: 0x055677D0  token: 0x600022D
        private System.Boolean MaxSpeedUpdate(System.Single input, System.Single deltaTime) { }
        // RVA: 0x05567758  token: 0x600022E
        private System.Single GetMaxSpeed() { }

    }

    // TypeToken: 0x2000060  // size: 0x130
    public sealed struct CameraState
    {
        // Fields
        public Cinemachine.CameraState.HGDOFParams DofParams;  // 0x10
        public Cinemachine.LensSettings Lens;  // 0x30
        public UnityEngine.Vector3 ReferenceUp;  // 0x60
        public UnityEngine.Vector3 ReferenceLookAt;  // 0x6c
        public UnityEngine.Vector3 Pivot;  // 0x78
        public UnityEngine.Vector3 NoOffsetPivot;  // 0x84
        public static UnityEngine.Vector3 kNoPoint;  // static @ 0x0
        public UnityEngine.Vector3 RawPosition;  // 0x90
        public UnityEngine.Quaternion RawOrientation;  // 0x9c
        public UnityEngine.Vector3 PositionDampingBypass;  // 0xac
        public System.Single ShotQuality;  // 0xb8
        public UnityEngine.Vector3 PositionCorrection;  // 0xbc
        public UnityEngine.Quaternion OrientationCorrection;  // 0xc8
        public Cinemachine.CameraState.BlendHintValue BlendHint;  // 0xd8
        private Cinemachine.CameraState.CustomBlendable mCustom0;  // 0xe0
        private Cinemachine.CameraState.CustomBlendable mCustom1;  // 0xf0
        private Cinemachine.CameraState.CustomBlendable mCustom2;  // 0x100
        private Cinemachine.CameraState.CustomBlendable mCustom3;  // 0x110
        private System.Collections.Generic.List<Cinemachine.CameraState.CustomBlendable> m_CustomOverflow;  // 0x120
        private System.Int32 <NumCustomBlendables>k__BackingField;  // 0x128

        // Properties
        System.Boolean HasLookAt { get; /* RVA: 0x042715FC */ }
        UnityEngine.Vector3 CorrectedPosition { get; /* RVA: 0x02746180 */ }
        UnityEngine.Quaternion CorrectedOrientation { get; /* RVA: 0x0274D400 */ }
        UnityEngine.Vector3 FinalPosition { get; /* RVA: 0x02746180 */ }
        UnityEngine.Quaternion FinalOrientation { get; /* RVA: 0x0274D360 */ }
        Cinemachine.CameraState Default { get; /* RVA: 0x02749660 */ }
        System.Int32 NumCustomBlendables { get; /* RVA: 0x03D50A10 */ set; /* RVA: 0x03D50A20 */ }

        // Methods
        // RVA: 0x055692C4  token: 0x600023F
        public Cinemachine.CameraState.CustomBlendable GetCustomBlendable(System.Int32 index) { }
        // RVA: 0x05569140  token: 0x6000240
        private System.Int32 FindCustomBlendable(UnityEngine.Object custom) { }
        // RVA: 0x05568F94  token: 0x6000241
        public System.Void AddCustomBlendable(Cinemachine.CameraState.CustomBlendable b) { }
        // RVA: 0x0257F400  token: 0x6000242
        public static Cinemachine.CameraState Lerp(Cinemachine.CameraState& stateA, Cinemachine.CameraState& stateB, System.Single t) { }
        // RVA: 0x055693B0  token: 0x6000243
        private static System.Single InterpolateFOV(System.Single fovA, System.Single fovB, System.Single dA, System.Single dB, System.Single t) { }
        // RVA: 0x02580400  token: 0x6000244
        private static UnityEngine.Vector3 ApplyPosBlendHint(UnityEngine.Vector3 posA, Cinemachine.CameraState.BlendHintValue hintA, UnityEngine.Vector3 posB, Cinemachine.CameraState.BlendHintValue hintB, UnityEngine.Vector3 original, UnityEngine.Vector3 blended) { }
        // RVA: 0x025803D0  token: 0x6000245
        private static UnityEngine.Quaternion ApplyRotBlendHint(UnityEngine.Quaternion rotA, Cinemachine.CameraState.BlendHintValue hintA, UnityEngine.Quaternion rotB, Cinemachine.CameraState.BlendHintValue hintB, UnityEngine.Quaternion original, UnityEngine.Quaternion blended) { }
        // RVA: 0x033BF420  token: 0x6000246
        private UnityEngine.Vector3 InterpolatePosition(UnityEngine.Vector3 posA, UnityEngine.Vector3 pivotA, UnityEngine.Vector3 posB, UnityEngine.Vector3 pivotB, System.Single t, System.Int32& positionCylindricalDir) { }
        // RVA: 0x03D2A840  token: 0x6000247
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x398
    public class CinemachineBlend
    {
        // Fields
        private Cinemachine.ICinemachineCamera m_CamA;  // 0x10
        public Cinemachine.ICinemachineCamera CamB;  // 0x18
        public System.Boolean useSimpleInertialization;  // 0x20
        public System.Boolean InitStateGot;  // 0x21
        public Cinemachine.CameraState InitStateA;  // 0x28
        public Cinemachine.CameraState CurrStateA;  // 0x148
        public Cinemachine.CameraState InitStateB;  // 0x268
        public UnityEngine.AnimationCurve BlendCurve;  // 0x388
        public System.Single TimeInBlend;  // 0x390
        public System.Single Duration;  // 0x394

        // Properties
        Cinemachine.ICinemachineCamera CamA { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0274DE20 */ }
        System.Single BlendWeight { get; /* RVA: 0x055694DC */ }
        System.Boolean IsValid { get; /* RVA: 0x05569724 */ }
        System.Boolean IsComplete { get; /* RVA: 0x055696FC */ }
        System.String Description { get; /* RVA: 0x05569554 */ }
        Cinemachine.CameraState State { get; /* RVA: 0x0274D0C0 */ }

        // Methods
        // RVA: 0x03D50A30  token: 0x600024B
        public System.Void StartSimpleInertialization() { }
        // RVA: 0x0274BAE0  token: 0x6000250
        public System.Boolean Uses(Cinemachine.ICinemachineCamera cam) { }
        // RVA: 0x03171A90  token: 0x6000251
        public System.Void .ctor(Cinemachine.ICinemachineCamera a, Cinemachine.ICinemachineCamera b, UnityEngine.AnimationCurve curve, System.Single duration, System.Single t) { }
        // RVA: 0x0274C030  token: 0x6000252
        public System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000065  // size: 0x28
    public sealed struct CinemachineBlendDefinition
    {
        // Fields
        public Cinemachine.CinemachineBlendDefinition.Style m_Style;  // 0x10
        public System.Single m_Time;  // 0x14
        public UnityEngine.AnimationCurve m_CustomCurve;  // 0x18
        private static UnityEngine.AnimationCurve[] sStandardCurves;  // static @ 0x0
        public System.Boolean m_UseSimpleInertialization;  // 0x20

        // Properties
        System.Single BlendTime { get; /* RVA: 0x0257D980 */ }
        UnityEngine.AnimationCurve BlendCurve { get; /* RVA: 0x0257E580 */ }

        // Methods
        // RVA: 0x04275A64  token: 0x6000255
        public System.Void .ctor(Cinemachine.CinemachineBlendDefinition.Style style, System.Single time) { }
        // RVA: 0x0257E060  token: 0x6000256
        private System.Void CreateStandardCurves() { }

    }

    // TypeToken: 0x2000067  // size: 0x150
    public class StaticPointVirtualCamera : Cinemachine.ICinemachineCamera
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private System.Int32 <Priority>k__BackingField;  // 0x18
        private UnityEngine.Transform <LookAt>k__BackingField;  // 0x20
        private UnityEngine.Transform <Follow>k__BackingField;  // 0x28
        private Cinemachine.CameraState <State>k__BackingField;  // 0x30

        // Properties
        System.String Name { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Int32 Priority { get; /* RVA: 0x020D1AC0 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x03D4EAC0 */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D50990 */ set; /* RVA: 0x05568A70 */ }
        UnityEngine.GameObject VirtualCameraGameObject { get; /* RVA: 0x01002730 */ }
        System.Boolean IsValid { get; /* RVA: 0x0232EB60 */ }
        Cinemachine.ICinemachineCamera ParentCamera { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x0556EA2C  token: 0x6000258
        public System.Void .ctor(Cinemachine.CameraState& state, System.String name) { }
        // RVA: 0x0115F4C0  token: 0x6000263
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x0350B670  token: 0x6000264
        public virtual System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x0350B670  token: 0x6000265
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000068  // size: 0x150
    public class BlendSourceVirtualCamera : Cinemachine.ICinemachineCamera
    {
        // Fields
        private Cinemachine.CinemachineBlend <Blend>k__BackingField;  // 0x10
        private System.Int32 <Priority>k__BackingField;  // 0x18
        private UnityEngine.Transform <LookAt>k__BackingField;  // 0x20
        private UnityEngine.Transform <Follow>k__BackingField;  // 0x28
        private Cinemachine.CameraState <State>k__BackingField;  // 0x30

        // Properties
        Cinemachine.CinemachineBlend Blend { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String Name { get; /* RVA: 0x05568A44 */ }
        System.Int32 Priority { get; /* RVA: 0x020D1AC0 */ }
        UnityEngine.Transform LookAt { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.Transform Follow { get; /* RVA: 0x03D4EAC0 */ }
        Cinemachine.CameraState State { get; /* RVA: 0x03D50990 */ set; /* RVA: 0x05568A70 */ }
        UnityEngine.GameObject VirtualCameraGameObject { get; /* RVA: 0x01002730 */ }
        System.Boolean IsValid { get; /* RVA: 0x05568A2C */ }
        Cinemachine.ICinemachineCamera ParentCamera { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000266
        public System.Void .ctor(Cinemachine.CinemachineBlend blend) { }
        // RVA: 0x05568938  token: 0x6000272
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x05568958  token: 0x6000273
        public virtual System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x0350B670  token: 0x6000274
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000069  // size: 0x28
    public sealed class CinemachineBlenderSettings : UnityEngine.ScriptableObject
    {
        // Fields
        public Cinemachine.CinemachineBlenderSettings.CustomBlend[] m_CustomBlends;  // 0x18
        public Cinemachine.CinemachineBlenderSettings.CustomBlendGroup[] m_CustomBlendGroups;  // 0x20
        public static System.String kBlendFromAnyCameraLabel;  // const

        // Methods
        // RVA: 0x0332DCF0  token: 0x6000275
        public Cinemachine.CinemachineBlendDefinition GetBlendForVirtualCameras(System.String fromCameraName, System.String toCameraName, Cinemachine.CinemachineBlendDefinition defaultBlend) { }
        // RVA: 0x0286F540  token: 0x6000276
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006C  // size: 0x20
    public abstract class CinemachineComponentBase : UnityEngine.MonoBehaviour
    {
        // Fields
        protected static System.Single Epsilon;  // const
        private Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;  // 0x18

        // Properties
        Cinemachine.CinemachineVirtualCameraBase VirtualCamera { get; /* RVA: 0x02747860 */ }
        UnityEngine.Transform FollowTarget { get; /* RVA: 0x02746AF0 */ }
        UnityEngine.Transform LookAtTarget { get; /* RVA: 0x02746C60 */ }
        Cinemachine.ICinemachineTargetGroup AbstractFollowTargetGroup { get; /* RVA: 0x0556976C */ }
        Cinemachine.CinemachineTargetGroup FollowTargetGroup { get; /* RVA: 0x055697B4 */ }
        UnityEngine.Vector3 FollowTargetPosition { get; /* RVA: 0x02B249C0 */ }
        UnityEngine.Quaternion FollowTargetRotation { get; /* RVA: 0x02B248B0 */ }
        Cinemachine.ICinemachineTargetGroup AbstractLookAtTargetGroup { get; /* RVA: 0x05569790 */ }
        Cinemachine.CinemachineTargetGroup LookAtTargetGroup { get; /* RVA: 0x055697F8 */ }
        UnityEngine.Vector3 LookAtTargetPosition { get; /* RVA: 0x0556983C */ }
        UnityEngine.Quaternion LookAtTargetRotation { get; /* RVA: 0x02744600 */ }
        Cinemachine.CameraState VcamState { get; /* RVA: 0x055699C4 */ }
        System.Boolean IsValid { get; /* RVA: -1  // abstract */ }
        Cinemachine.CinemachineCore.Stage Stage { get; /* RVA: -1  // abstract */ }
        System.Boolean BodyAppliesAfterAim { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean RequiresUserInput { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000285
        public virtual System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: -1  // abstract  token: 0x6000288
        public virtual System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x0115F4C0  token: 0x6000289
        public virtual System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        // RVA: 0x0350B670  token: 0x600028A
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x0350B670  token: 0x600028B
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x03D503F0  token: 0x600028C
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0426FE60  token: 0x600028E
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x48
    public sealed class CinemachineCore
    {
        // Fields
        public static readonly System.Int32 kStreamingVersion;  // static @ 0x0
        public static readonly System.String kVersionString;  // static @ 0x8
        private static Cinemachine.CinemachineCore sInstance;  // static @ 0x10
        public static System.Boolean sShowHiddenObjects;  // static @ 0x18
        public static Cinemachine.CinemachineCore.AxisInputDelegate GetInputAxis;  // static @ 0x20
        public static System.Single UniformDeltaTimeOverride;  // static @ 0x28
        public static System.Single CurrentTimeOverride;  // static @ 0x2c
        public static Cinemachine.CinemachineCore.GetBlendOverrideDelegate GetBlendOverride;  // static @ 0x30
        public static Cinemachine.CinemachineBrain.BrainEvent CameraUpdatedEvent;  // static @ 0x38
        public static Cinemachine.CinemachineBrain.BrainEvent CameraCutEvent;  // static @ 0x40
        private System.Collections.Generic.List<Cinemachine.CinemachineBrain> mActiveBrains;  // 0x10
        private System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase> mActiveCameras;  // 0x18
        private System.Boolean m_ActiveCamerasAreSorted;  // 0x20
        private System.Int32 m_ActivationSequence;  // 0x24
        private System.Collections.Generic.List<System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>> mAllCameras;  // 0x28
        private Cinemachine.CinemachineVirtualCameraBase mRoundRobinVcamLastFrame;  // 0x30
        private static System.Single s_LastUpdateTime;  // static @ 0x48
        private static System.Int32 s_FixedFrameCount;  // static @ 0x4c
        private System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase,Cinemachine.CinemachineCore.UpdateStatus> mUpdateStatus;  // 0x38
        private Cinemachine.CinemachineCore.UpdateFilter m_CurrentUpdateFilter;  // 0x40

        // Properties
        Cinemachine.CinemachineCore Instance { get; /* RVA: 0x0274AC70 */ }
        System.Single DeltaTime { get; /* RVA: 0x0556A108 */ }
        System.Single CurrentTime { get; /* RVA: 0x0274BFC0 */ }
        System.Int32 BrainCount { get; /* RVA: 0x02749D60 */ }
        System.Int32 VirtualCameraCount { get; /* RVA: 0x0274AFC0 */ }

        // Methods
        // RVA: 0x0274B000  token: 0x6000293
        public Cinemachine.CinemachineBrain GetActiveBrain(System.Int32 index) { }
        // RVA: 0x03171170  token: 0x6000294
        private System.Void AddActiveBrain(Cinemachine.CinemachineBrain brain) { }
        // RVA: 0x031711E0  token: 0x6000295
        private System.Void RemoveActiveBrain(Cinemachine.CinemachineBrain brain) { }
        // RVA: 0x0274A8E0  token: 0x6000297
        public Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(System.Int32 index) { }
        // RVA: 0x03318CD0  token: 0x6000298
        private System.Void AddActiveCamera(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x03318C40  token: 0x6000299
        private System.Void RemoveActiveCamera(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x05569B2C  token: 0x600029A
        private System.Void CameraDestroyed(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x03318D40  token: 0x600029B
        private System.Void CameraEnabled(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x03318A40  token: 0x600029C
        private System.Void CameraDisabled(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x0274BB70  token: 0x600029D
        private System.Void UpdateAllActiveVirtualCameras(System.Int32 layerMask, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x02748CC0  token: 0x600029E
        private System.Void UpdateVirtualCamera(Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x03CB9CF0  token: 0x600029F
        private static System.Void InitializeModule() { }
        // RVA: 0x05569E40  token: 0x60002A0
        private static UnityEngine.Transform GetUpdateTarget(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x05569F38  token: 0x60002A1
        private Cinemachine.UpdateTracker.UpdateClock GetVcamUpdateStatus(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x02749AE0  token: 0x60002A2
        public System.Boolean IsLive(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x05569FB4  token: 0x60002A3
        public System.Boolean IsLiveInBlend(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x05569BF8  token: 0x60002A4
        public System.Void GenerateCameraActivationEvent(Cinemachine.ICinemachineCamera vcam, Cinemachine.ICinemachineCamera vcamFrom) { }
        // RVA: 0x05569CF0  token: 0x60002A5
        public System.Void GenerateCameraCutEvent(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: 0x02749DA0  token: 0x60002A6
        public Cinemachine.CinemachineBrain FindPotentialTargetBrain(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        // RVA: 0x0556A074  token: 0x60002A7
        public System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x033182B0  token: 0x60002A8
        public System.Void .ctor() { }
        // RVA: 0x031716F0  token: 0x60002A9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000074  // size: 0x28
    public abstract class CinemachineExtension : UnityEngine.MonoBehaviour
    {
        // Fields
        protected static System.Single Epsilon;  // const
        private Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;  // 0x18
        private System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera,System.Object> mExtraState;  // 0x20

        // Properties
        Cinemachine.CinemachineVirtualCameraBase VirtualCamera { get; /* RVA: 0x02743A50 */ }
        System.Boolean RequiresUserInput { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x03CA4A50  token: 0x60002B3
        protected virtual System.Void Awake() { }
        // RVA: 0x0350B670  token: 0x60002B4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0556A178  token: 0x60002B5
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x03CA4A50  token: 0x60002B6
        private System.Void EnsureStarted() { }
        // RVA: 0x02742640  token: 0x60002B7
        protected virtual System.Void ConnectToVcam(System.Boolean connect) { }
        // RVA: 0x0350B670  token: 0x60002B8
        public virtual System.Void PrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& curState, System.Single deltaTime) { }
        // RVA: 0x04271650  token: 0x60002B9
        public System.Void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: -1  // abstract  token: 0x60002BA
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0350B670  token: 0x60002BB
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x0350B670  token: 0x60002BC
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0115F4C0  token: 0x60002BD
        public virtual System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x03D503F0  token: 0x60002BE
        public virtual System.Single GetMaxDampTime() { }
        // RVA: -1  // generic def  token: 0x60002C0
        protected T GetExtraState(Cinemachine.ICinemachineCamera vcam) { }
        // RVA: -1  // generic def  token: 0x60002C1
        protected System.Collections.Generic.List<T> GetAllExtraStates() { }
        // RVA: 0x0426FE60  token: 0x60002C2
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000075  // size: 0x48
    public abstract class CinemachinePathBase : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Int32 m_Resolution;  // 0x18
        public Cinemachine.CinemachinePathBase.Appearance m_Appearance;  // 0x20
        private System.Single[] m_DistanceToPos;  // 0x28
        private System.Single[] m_PosToDistance;  // 0x30
        private System.Int32 m_CachedSampleSteps;  // 0x38
        private System.Single m_PathLength;  // 0x3c
        private System.Single m_cachedPosStepSize;  // 0x40
        private System.Single m_cachedDistanceStepSize;  // 0x44

        // Properties
        System.Single MinPos { get; /* RVA: -1  // abstract */ }
        System.Single MaxPos { get; /* RVA: -1  // abstract */ }
        System.Boolean Looped { get; /* RVA: -1  // abstract */ }
        System.Int32 DistanceCacheSampleStepsPerSegment { get; /* RVA: -1  // abstract */ }
        System.Single PathLength { get; /* RVA: 0x0556ADCC */ }

        // Methods
        // RVA: 0x0556AB1C  token: 0x60002C6
        public virtual System.Single StandardizePos(System.Single pos) { }
        // RVA: -1  // abstract  token: 0x60002C7
        public virtual UnityEngine.Vector3 EvaluatePosition(System.Single pos) { }
        // RVA: -1  // abstract  token: 0x60002C8
        public virtual UnityEngine.Vector3 EvaluateTangent(System.Single pos) { }
        // RVA: -1  // abstract  token: 0x60002C9
        public virtual UnityEngine.Quaternion EvaluateOrientation(System.Single pos) { }
        // RVA: 0x0556A2F4  token: 0x60002CA
        public virtual System.Single FindClosestPoint(UnityEngine.Vector3 p, System.Int32 startSegment, System.Int32 searchRadius, System.Int32 stepsPerSegment) { }
        // RVA: 0x0556A76C  token: 0x60002CB
        public System.Single MinUnit(Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A734  token: 0x60002CC
        public System.Single MaxUnit(Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556ABC0  token: 0x60002CD
        public virtual System.Single StandardizeUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A24C  token: 0x60002CE
        public UnityEngine.Vector3 EvaluatePositionAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A2A0  token: 0x60002CF
        public UnityEngine.Vector3 EvaluateTangentAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A200  token: 0x60002D0
        public UnityEngine.Quaternion EvaluateOrientationAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A704  token: 0x60002D2
        public virtual System.Void InvalidateDistanceCache() { }
        // RVA: 0x0556A188  token: 0x60002D3
        public System.Boolean DistanceCacheIsValid() { }
        // RVA: 0x0556AA88  token: 0x60002D5
        public System.Single StandardizePathDistance(System.Single distance) { }
        // RVA: 0x0556AC38  token: 0x60002D6
        public System.Single ToNativePathUnits(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A608  token: 0x60002D7
        public System.Single FromPathNativeUnits(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        // RVA: 0x0556A794  token: 0x60002D8
        private System.Void ResamplePath(System.Int32 stepsPerSegment) { }
        // RVA: 0x0556AD54  token: 0x60002D9
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000078  // size: 0x10
    public sealed class AxisStatePropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002DB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x10
    public sealed class OrbitalTransposerHeadingPropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002DC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007A  // size: 0x10
    public sealed class VcamTargetPropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002DD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007B  // size: 0x10
    public sealed class CinemachineBlendDefinitionPropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002DE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007C  // size: 0x10
    public sealed class SaveDuringPlayAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002DF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007D  // size: 0x10
    public sealed class NoSaveDuringPlayAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002E0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007E  // size: 0x10
    public sealed class TagFieldAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002E1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007F  // size: 0x10
    public sealed class NoiseSettingsPropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002E2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x18
    public sealed class CinemachineEmbeddedAssetPropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Fields
        public System.Boolean WarnIfNull;  // 0x10

        // Methods
        // RVA: 0x03D4E960  token: 0x60002E3
        public System.Void .ctor(System.Boolean warnIfNull) { }

    }

    // TypeToken: 0x2000081  // size: 0x18
    public sealed class DocumentationSortingAttribute : System.Attribute
    {
        // Fields
        private Cinemachine.DocumentationSortingAttribute.Level <Category>k__BackingField;  // 0x10

        // Properties
        Cinemachine.DocumentationSortingAttribute.Level Category { set; /* RVA: 0x010410F0 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002E5
        public System.Void .ctor(Cinemachine.DocumentationSortingAttribute.Level category) { }

    }

    // TypeToken: 0x2000083  // size: 0xA8
    public abstract class CinemachineVirtualCameraBase : UnityEngine.MonoBehaviour, Cinemachine.ICinemachineCamera
    {
        // Fields
        public System.String[] m_ExcludedPropertiesInInspector;  // 0x18
        public Cinemachine.CinemachineCore.Stage[] m_LockStageInInspector;  // 0x20
        private System.Int32 m_ValidatingStreamVersion;  // 0x28
        private System.Boolean m_OnValidateCalled;  // 0x2c
        private System.Int32 m_StreamingVersion;  // 0x30
        public System.Int32 m_Priority;  // 0x34
        private System.Int32 m_ActivationId;  // 0x38
        public System.Single FollowTargetAttachment;  // 0x3c
        public System.Single LookAtTargetAttachment;  // 0x40
        protected System.Boolean _ignoreLookAtBlend;  // 0x44
        public Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate;  // 0x48
        private System.Collections.Generic.List<Cinemachine.CinemachineExtension> <mExtensions>k__BackingField;  // 0x50
        private System.Boolean <PreviousStateIsValid>k__BackingField;  // 0x58
        private System.Boolean m_WasStarted;  // 0x59
        private System.Boolean mSlaveStatusUpdated;  // 0x5a
        private Cinemachine.CinemachineVirtualCameraBase m_parentVcam;  // 0x60
        private System.Int32 m_QueuePriority;  // 0x68
        private UnityEngine.Transform m_CachedFollowTarget;  // 0x70
        private Cinemachine.CinemachineVirtualCameraBase m_CachedFollowTargetVcam;  // 0x78
        private Cinemachine.ICinemachineTargetGroup m_CachedFollowTargetGroup;  // 0x80
        private UnityEngine.Transform m_CachedLookAtTarget;  // 0x88
        private Cinemachine.CinemachineVirtualCameraBase m_CachedLookAtTargetVcam;  // 0x90
        private Cinemachine.ICinemachineTargetGroup m_CachedLookAtTargetGroup;  // 0x98
        private System.Boolean <FollowTargetChanged>k__BackingField;  // 0xa0
        private System.Boolean <LookAtTargetChanged>k__BackingField;  // 0xa1

        // Properties
        System.Int32 ValidatingStreamVersion { get; /* RVA: 0x03318580 */ set; /* RVA: 0x03D4EBA0 */ }
        System.Collections.Generic.List<Cinemachine.CinemachineExtension> mExtensions { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.String Name { get; /* RVA: 0x04276114 */ }
        System.String Description { get; /* RVA: 0x0556C83C */ }
        System.Int32 Priority { get; /* RVA: 0x03D4EE00 */ set; /* RVA: 0x03D4EE40 */ }
        UnityEngine.GameObject VirtualCameraGameObject { get; /* RVA: 0x0274C6C0 */ }
        System.Boolean IsValid { get; /* RVA: 0x0274BA10 */ }
        Cinemachine.CameraState State { get; /* RVA: -1  // abstract */ }
        Cinemachine.ICinemachineCamera ParentCamera { get; /* RVA: 0x024ADF80 */ }
        UnityEngine.Transform LookAt { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        UnityEngine.Transform Follow { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean PreviousStateIsValid { get; /* RVA: 0x03D4F7E0 */ set; /* RVA: 0x03D4F7F0 */ }
        System.Boolean FollowTargetChanged { get; /* RVA: 0x03D50A40 */ set; /* RVA: 0x03D50A60 */ }
        System.Boolean LookAtTargetChanged { get; /* RVA: 0x03D50A50 */ set; /* RVA: 0x03D50A70 */ }
        Cinemachine.ICinemachineTargetGroup AbstractFollowTargetGroup { get; /* RVA: 0x03D4EAE0 */ }
        Cinemachine.CinemachineVirtualCameraBase FollowTargetAsVcam { get; /* RVA: 0x03D4EB20 */ }
        Cinemachine.ICinemachineTargetGroup AbstractLookAtTargetGroup { get; /* RVA: 0x011AC510 */ }
        Cinemachine.CinemachineVirtualCameraBase LookAtTargetAsVcam { get; /* RVA: 0x03D4EA90 */ }

        // Methods
        // RVA: 0x0556C508  token: 0x60002E8
        public virtual System.Single GetMaxDampTime() { }
        // RVA: 0x0556C1B8  token: 0x60002E9
        public System.Single DetachedFollowTargetDamp(System.Single initial, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x024D9C60  token: 0x60002EA
        public UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime) { }
        // RVA: 0x0556C138  token: 0x60002EB
        public UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x024DB000  token: 0x60002EC
        public System.Single DetachedLookAtTargetDamp(System.Single initial, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x0556C210  token: 0x60002ED
        public UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime) { }
        // RVA: 0x0556C300  token: 0x60002EE
        public UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x02741E70  token: 0x60002EF
        public virtual System.Void AddExtension(Cinemachine.CinemachineExtension extension) { }
        // RVA: 0x0556C6D0  token: 0x60002F0
        public virtual System.Void RemoveExtension(Cinemachine.CinemachineExtension extension) { }
        // RVA: 0x027487D0  token: 0x60002F3
        protected System.Void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& newState, System.Single deltaTime) { }
        // RVA: 0x02747C30  token: 0x60002F4
        protected System.Void InvokePrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& newState, System.Single deltaTime) { }
        // RVA: 0x03651490  token: 0x60002F5
        protected System.Boolean InvokeOnTransitionInExtensions(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x027463F0  token: 0x60002FA
        protected System.Void ApplyPositionBlendMethod(Cinemachine.CameraState& state, Cinemachine.CinemachineVirtualCameraBase.BlendHint hint) { }
        // RVA: 0x0115F4C0  token: 0x60002FF
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: 0x02749090  token: 0x6000306
        public virtual System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: -1  // abstract  token: 0x6000307
        public virtual System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x03651450  token: 0x6000308
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: 0x0556C5AC  token: 0x6000309
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x033188B0  token: 0x600030A
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x03D4D6A0  token: 0x600030B
        protected virtual System.Void Start() { }
        // RVA: 0x0556C724  token: 0x600030C
        private virtual System.Boolean RequiresUserInput() { }
        // RVA: 0x0556C380  token: 0x600030D
        private System.Void EnsureStarted() { }
        // RVA: 0x0556C47C  token: 0x600030E
        public Cinemachine.AxisState.IInputAxisProvider GetInputAxisProvider() { }
        // RVA: 0x0556C67C  token: 0x600030F
        protected virtual System.Void OnValidate() { }
        // RVA: 0x03318660  token: 0x6000310
        protected virtual System.Void OnEnable() { }
        // RVA: 0x033185F0  token: 0x6000311
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0336A230  token: 0x6000312
        protected virtual System.Void Update() { }
        // RVA: 0x03318980  token: 0x6000313
        private System.Void UpdateSlaveStatus() { }
        // RVA: 0x02747730  token: 0x6000314
        public UnityEngine.Transform ResolveLookAt(UnityEngine.Transform localLookAt) { }
        // RVA: 0x02747B00  token: 0x6000315
        public UnityEngine.Transform ResolveFollow(UnityEngine.Transform localFollow) { }
        // RVA: 0x03318B30  token: 0x6000316
        private System.Void UpdateVcamPoolStatus() { }
        // RVA: 0x0556C5A4  token: 0x6000317
        public System.Void MoveToTopOfPrioritySubqueue() { }
        // RVA: 0x0556C604  token: 0x6000318
        public virtual System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x0556C404  token: 0x6000319
        public virtual System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x0556BF00  token: 0x600031A
        protected Cinemachine.CinemachineBlend CreateBlend(Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, Cinemachine.CinemachineBlendDefinition blendDef, Cinemachine.CinemachineBlend activeBlend) { }
        // RVA: 0x027497E0  token: 0x600031B
        protected Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp, Cinemachine.LensSettings& lens) { }
        // RVA: 0x03318830  token: 0x600031C
        private System.Void InvalidateCachedTargets() { }
        // RVA: 0x02746DD0  token: 0x6000321
        protected System.Void UpdateTargetCache() { }
        // RVA: -1  // generic def  token: 0x6000326
        public System.Object GetCinemachineComponent() { }
        // RVA: 0x03395190  token: 0x6000327
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x98
    public class ConfinerOven
    {
        // Fields
        private System.Single m_MinFrustumHeightWithBones;  // 0x10
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_OriginalPolygon;  // 0x18
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_Skeleton;  // 0x20
        private static System.Int64 k_FloatToIntScaler;  // const
        private static System.Single k_IntToFloatScaler;  // const
        private static System.Single k_MinStepSize;  // const
        private UnityEngine.Rect m_PolygonRect;  // 0x28
        private Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;  // 0x38
        private System.Single m_maxComputationTimeForFullSkeletonBakeInSeconds;  // 0x44
        private Cinemachine.ConfinerOven.BakingState <State>k__BackingField;  // 0x48
        public System.Single m_BakeProgress;  // 0x4c
        private Cinemachine.ConfinerOven.BakingStateCache m_Cache;  // 0x50

        // Properties
        Cinemachine.ConfinerOven.BakingState State { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x03D4ECD0 */ }

        // Methods
        // RVA: 0x0556D8DC  token: 0x600032B
        public System.Void .ctor(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& inputPath, System.Single& aspectRatio, System.Single maxFrustumHeight) { }
        // RVA: 0x0556CFB4  token: 0x600032C
        public Cinemachine.ConfinerOven.BakedSolution GetBakedSolution(System.Single frustumHeight) { }
        // RVA: 0x0556D3B0  token: 0x600032F
        private System.Void Initialize(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& inputPath, System.Single& aspectRatio, System.Single maxFrustumHeight) { }
        // RVA: 0x0556C868  token: 0x6000330
        public System.Void BakeConfiner(System.Single maxComputationTimePerFrameInSeconds) { }
        // RVA: 0x0556D238  token: 0x6000331
        private static UnityEngine.Rect GetPolygonBoundingBox(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& polygons) { }
        // RVA: 0x0556CC2C  token: 0x6000332
        private System.Void ComputeSkeleton(System.Collections.Generic.List<Cinemachine.ConfinerOven.PolygonSolution>& solutions) { }

    }

    // TypeToken: 0x200008E
    public interface ICinemachineCamera
    {
        // Properties
        System.String Name { get; /* RVA: -1  // abstract */ }
        System.Int32 Priority { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform LookAt { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform Follow { get; /* RVA: -1  // abstract */ }
        Cinemachine.CameraState State { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject VirtualCameraGameObject { get; /* RVA: -1  // abstract */ }
        System.Boolean IsValid { get; /* RVA: -1  // abstract */ }
        Cinemachine.ICinemachineCamera ParentCamera { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600034B
        public virtual System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        // RVA: -1  // abstract  token: 0x600034C
        public virtual System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        // RVA: -1  // abstract  token: 0x600034D
        public virtual System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x200008F  // size: 0x40
    public sealed struct LensSettings
    {
        // Fields
        public static Cinemachine.LensSettings Default;  // static @ 0x0
        public System.Single FieldOfView;  // 0x10
        public System.Single OrthographicSize;  // 0x14
        public System.Single NearClipPlane;  // 0x18
        public System.Single FarClipPlane;  // 0x1c
        public System.Single Dutch;  // 0x20
        public Cinemachine.LensSettings.OverrideModes ModeOverride;  // 0x24
        public UnityEngine.Vector2 LensShift;  // 0x28
        public UnityEngine.Camera.GateFitMode GateFit;  // 0x30
        private UnityEngine.Vector2 m_SensorSize;  // 0x34
        private System.Boolean m_OrthoFromCamera;  // 0x3c
        private System.Boolean m_PhysicalFromCamera;  // 0x3d

        // Properties
        System.Boolean Orthographic { get; /* RVA: 0x02743FC0 */ }
        UnityEngine.Vector2 SensorSize { get; /* RVA: 0x03D50A80 */ }
        System.Single Aspect { get; /* RVA: 0x02743F40 */ }
        System.Boolean IsPhysicalCamera { get; /* RVA: 0x02749440 */ }

        // Methods
        // RVA: 0x0556DB70  token: 0x6000352
        public static Cinemachine.LensSettings FromCamera(UnityEngine.Camera fromCamera) { }
        // RVA: 0x02749130  token: 0x6000353
        public System.Void SnapshotCameraReadOnlyProperties(UnityEngine.Camera camera) { }
        // RVA: 0x03C8AC40  token: 0x6000354
        public System.Void .ctor(System.Single verticalFOV, System.Single orthographicSize, System.Single nearClip, System.Single farClip, System.Single dutch) { }
        // RVA: 0x0257D820  token: 0x6000355
        public static Cinemachine.LensSettings Lerp(Cinemachine.LensSettings lensA, Cinemachine.LensSettings lensB, System.Single t) { }
        // RVA: 0x0556DCA8  token: 0x6000356
        public System.Void Validate() { }
        // RVA: 0x03C8ABA0  token: 0x6000357
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000091  // size: 0x28
    public sealed class NoiseSettings : Cinemachine.SignalSourceAsset
    {
        // Fields
        public Cinemachine.NoiseSettings.TransformNoiseParams[] PositionNoise;  // 0x18
        public Cinemachine.NoiseSettings.TransformNoiseParams[] OrientationNoise;  // 0x20

        // Properties
        System.Single SignalDuration { get; /* RVA: 0x03D503F0 */ }

        // Methods
        // RVA: 0x0556DD6C  token: 0x6000358
        public static UnityEngine.Vector3 GetCombinedFilterResults(Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, System.Single time, UnityEngine.Vector3 timeOffsets) { }
        // RVA: 0x0556DE78  token: 0x600035A
        public virtual System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        // RVA: 0x03A1C990  token: 0x600035B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000094  // size: 0x10
    public static class RuntimeUtility
    {
        // Fields
        public static Cinemachine.RuntimeUtility.OverlapSphereNonAllocDelegate OverlapSphereNonAlloc;  // static @ 0x0
        public static Cinemachine.RuntimeUtility.RaycastDelegate Raycast;  // static @ 0x8
        public static Cinemachine.RuntimeUtility.RaycastNonAllocDelegate RaycastNonAlloc;  // static @ 0x10
        public static Cinemachine.RuntimeUtility.SphereCastNonAllocDelegate SphereCastNonAlloc;  // static @ 0x18
        public static Cinemachine.RuntimeUtility.ComputePenetrationDelegate ComputePenetration;  // static @ 0x20
        public static System.Int32 ignoreColliderOption;  // static @ 0x28
        private static UnityEngine.RaycastHit[] s_HitBuffer;  // static @ 0x30
        private static System.Int32[] s_PenetrationIndexBuffer;  // static @ 0x38
        private static UnityEngine.SphereCollider s_ScratchCollider;  // static @ 0x40
        private static UnityEngine.GameObject s_ScratchColliderGameObject;  // static @ 0x48

        // Methods
        // RVA: 0x0556E25C  token: 0x600035E
        public static System.Void DestroyObject(UnityEngine.Object obj) { }
        // RVA: 0x0115F4C0  token: 0x600035F
        public static System.Boolean IsPrefab(UnityEngine.GameObject gameObject) { }
        // RVA: 0x02742A40  token: 0x6000360
        public static System.Boolean RaycastIgnoreTag(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single rayLength, System.Int32 layerMask, System.String& ignoreTag) { }
        // RVA: 0x0556E430  token: 0x6000361
        public static System.Int32 GetColliderOptionsFromHit(UnityEngine.RaycastHit hit) { }
        // RVA: 0x0556E790  token: 0x6000362
        public static System.Boolean HasIgnoreColliderOptionFromHit(UnityEngine.RaycastHit hit) { }
        // RVA: 0x0556E720  token: 0x6000363
        public static System.Boolean HasIgnoreColliderOptionFromCollider(UnityEngine.ECSColliderResultProxy collider) { }
        // RVA: 0x02743020  token: 0x6000364
        public static System.Boolean SphereCastIgnoreTag(UnityEngine.Vector3 rayStart, System.Single radius, UnityEngine.Vector3 dir, UnityEngine.RaycastHit& hitInfo, System.Single rayLength, System.Int32 layerMask, System.String& ignoreTag) { }
        // RVA: 0x0556E498  token: 0x6000365
        private static UnityEngine.SphereCollider GetScratchCollider() { }
        // RVA: 0x0556E2BC  token: 0x6000366
        private static System.Void DestroyScratchCollider() { }
        // RVA: 0x0556E80C  token: 0x6000367
        public static UnityEngine.AnimationCurve NormalizeCurve(UnityEngine.AnimationCurve curve, System.Boolean normalizeX, System.Boolean normalizeY) { }
        // RVA: 0x03640D60  token: 0x6000368
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009A
    public interface ISignalSource6D
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000373
        public virtual System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x200009B  // size: 0x18
    public abstract class SignalSourceAsset : UnityEngine.ScriptableObject, Cinemachine.ISignalSource6D
    {
        // Properties
        System.Single SignalDuration { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000375
        public virtual System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        // RVA: 0x0286F540  token: 0x6000376
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200009C  // size: 0x10
    public class TargetPositionCache
    {
        // Fields
        public static System.Boolean UseCache;  // static @ 0x0
        private static Cinemachine.TargetPositionCache.Mode m_CacheMode;  // static @ 0x4
        public static System.Single CurrentTime;  // static @ 0x8
        public static System.Int32 CurrentFrame;  // static @ 0xc
        public static System.Boolean IsCameraCut;  // static @ 0x10
        private static System.Collections.Generic.Dictionary<UnityEngine.Transform,Cinemachine.TargetPositionCache.CacheEntry> m_Cache;  // static @ 0x18
        private static Cinemachine.TargetPositionCache.TimeRange m_CacheTimeRange;  // static @ 0x20

        // Properties
        Cinemachine.TargetPositionCache.Mode CacheMode { get; /* RVA: 0x0556EC1C */ }
        System.Boolean HasCurrentTime { get; /* RVA: 0x0556EC54 */ }

        // Methods
        // RVA: 0x0556EB24  token: 0x6000379
        public static System.Void ClearCache() { }
        // RVA: 0x02749460  token: 0x600037A
        public static UnityEngine.Vector3 GetTargetPosition(UnityEngine.Transform target) { }
        // RVA: 0x02749550  token: 0x600037B
        public static UnityEngine.Quaternion GetTargetRotation(UnityEngine.Transform target) { }

    }

    // TypeToken: 0x20000A3  // size: 0x10
    public class UpdateTracker
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Transform,Cinemachine.UpdateTracker.UpdateStatus> mUpdateStatus;  // static @ 0x0
        private static System.Collections.Generic.List<UnityEngine.Transform> sToDelete;  // static @ 0x8
        private static System.Single mLastUpdateTime;  // static @ 0x10

        // Methods
        // RVA: 0x03D02380  token: 0x6000385
        private static System.Void InitializeModule() { }
        // RVA: 0x0556F158  token: 0x6000386
        private static System.Void UpdateTargets(Cinemachine.UpdateTracker.UpdateClock currentClock) { }
        // RVA: 0x0556EECC  token: 0x6000387
        public static Cinemachine.UpdateTracker.UpdateClock GetPreferredUpdate(UnityEngine.Transform target) { }
        // RVA: 0x0556F0BC  token: 0x6000388
        public static System.Void OnUpdate(Cinemachine.UpdateTracker.UpdateClock currentClock) { }
        // RVA: 0x03C7A7F0  token: 0x6000389
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000A6  // size: 0x38
    public class CinemachineInputProvider : UnityEngine.MonoBehaviour, IInputAxisProvider
    {
        // Fields
        public System.Int32 PlayerIndex;  // 0x18
        public System.Boolean AutoEnableInputs;  // 0x1c
        public UnityEngine.InputSystem.InputActionReference XYAxis;  // 0x20
        public UnityEngine.InputSystem.InputActionReference ZAxis;  // 0x28
        private static System.Int32 NUM_AXES;  // const
        private UnityEngine.InputSystem.InputAction[] m_cachedActions;  // 0x30

        // Methods
        // RVA: 0x05572854  token: 0x600038E
        public virtual System.Single GetAxisValue(System.Int32 axis) { }
        // RVA: 0x05572934  token: 0x600038F
        protected UnityEngine.InputSystem.InputAction ResolveForPlayer(System.Int32 axis, UnityEngine.InputSystem.InputActionReference actionRef) { }
        // RVA: 0x05572920  token: 0x6000390
        protected virtual System.Void OnDisable() { }
        // RVA: 0x05572D94  token: 0x6000391
        public System.Void .ctor() { }
        // RVA: 0x05572C9C  token: 0x6000392
        private static UnityEngine.InputSystem.InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(UnityEngine.InputSystem.Users.InputUser& user, UnityEngine.InputSystem.InputActionReference aRef) { }

    }

    // TypeToken: 0x20000A8  // size: 0x90
    public class CinemachineTriggerAction : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.LayerMask m_LayerMask;  // 0x18
        public System.String m_WithTag;  // 0x20
        public System.String m_WithoutTag;  // 0x28
        public System.Int32 m_SkipFirst;  // 0x30
        public System.Boolean m_Repeating;  // 0x34
        public Cinemachine.CinemachineTriggerAction.ActionSettings m_OnObjectEnter;  // 0x38
        public Cinemachine.CinemachineTriggerAction.ActionSettings m_OnObjectExit;  // 0x60
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_ActiveTriggerObjects;  // 0x88

        // Methods
        // RVA: 0x05572DA8  token: 0x6000395
        private System.Boolean Filter(UnityEngine.GameObject other) { }
        // RVA: 0x05572E38  token: 0x6000396
        private System.Void InternalDoTriggerEnter(UnityEngine.GameObject other) { }
        // RVA: 0x05572EC8  token: 0x6000397
        private System.Void InternalDoTriggerExit(UnityEngine.GameObject other) { }
        // RVA: 0x05573034  token: 0x6000398
        private System.Void OnTriggerEnter(UnityEngine.Collider other) { }
        // RVA: 0x05573068  token: 0x6000399
        private System.Void OnTriggerExit(UnityEngine.Collider other) { }
        // RVA: 0x05572F98  token: 0x600039A
        private System.Void OnCollisionEnter(UnityEngine.Collision other) { }
        // RVA: 0x05573000  token: 0x600039B
        private System.Void OnCollisionExit(UnityEngine.Collision other) { }
        // RVA: 0x05573034  token: 0x600039C
        private System.Void OnTriggerEnter2D(UnityEngine.Collider2D other) { }
        // RVA: 0x05573068  token: 0x600039D
        private System.Void OnTriggerExit2D(UnityEngine.Collider2D other) { }
        // RVA: 0x05572F64  token: 0x600039E
        private System.Void OnCollisionEnter2D(UnityEngine.Collision2D other) { }
        // RVA: 0x05572FCC  token: 0x600039F
        private System.Void OnCollisionExit2D(UnityEngine.Collision2D other) { }
        // RVA: 0x0350B670  token: 0x60003A0
        private System.Void OnEnable() { }
        // RVA: 0x0557309C  token: 0x60003A1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD  // size: 0x40
    public class GroupWeightManipulator : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single m_Weight0;  // 0x18
        public System.Single m_Weight1;  // 0x1c
        public System.Single m_Weight2;  // 0x20
        public System.Single m_Weight3;  // 0x24
        public System.Single m_Weight4;  // 0x28
        public System.Single m_Weight5;  // 0x2c
        public System.Single m_Weight6;  // 0x30
        public System.Single m_Weight7;  // 0x34
        private Cinemachine.CinemachineTargetGroup m_group;  // 0x38

        // Methods
        // RVA: 0x055734BC  token: 0x60003A5
        private System.Void Start() { }
        // RVA: 0x05573450  token: 0x60003A6
        private System.Void OnValidate() { }
        // RVA: 0x05573638  token: 0x60003A7
        private System.Void Update() { }
        // RVA: 0x05573504  token: 0x60003A8
        private System.Void UpdateWeights() { }
        // RVA: 0x05573698  token: 0x60003A9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE  // size: 0x58
    public class CinemachineCollisionImpulseSource : Cinemachine.CinemachineImpulseSource
    {
        // Fields
        public UnityEngine.LayerMask m_LayerMask;  // 0x30
        public System.String m_IgnoreTag;  // 0x38
        public System.Boolean m_UseImpactDirection;  // 0x40
        public System.Boolean m_ScaleImpactWithMass;  // 0x41
        public System.Boolean m_ScaleImpactWithSpeed;  // 0x42
        private UnityEngine.Rigidbody mRigidBody;  // 0x48
        private UnityEngine.Rigidbody2D mRigidBody2D;  // 0x50

        // Methods
        // RVA: 0x05570334  token: 0x60003AA
        private System.Void Start() { }
        // RVA: 0x0350B670  token: 0x60003AB
        private System.Void OnEnable() { }
        // RVA: 0x055702A4  token: 0x60003AC
        private System.Void OnCollisionEnter(UnityEngine.Collision c) { }
        // RVA: 0x05570308  token: 0x60003AD
        private System.Void OnTriggerEnter(UnityEngine.Collider c) { }
        // RVA: 0x0556FFFC  token: 0x60003AE
        private System.Single GetMassAndVelocity(UnityEngine.Collider other, UnityEngine.Vector3& vel) { }
        // RVA: 0x0556FBDC  token: 0x60003AF
        private System.Void GenerateImpactEvent(UnityEngine.Collider other, UnityEngine.Vector3 vel) { }
        // RVA: 0x05570230  token: 0x60003B0
        private System.Void OnCollisionEnter2D(UnityEngine.Collision2D c) { }
        // RVA: 0x055702DC  token: 0x60003B1
        private System.Void OnTriggerEnter2D(UnityEngine.Collider2D c) { }
        // RVA: 0x0556FDC8  token: 0x60003B2
        private System.Single GetMassAndVelocity2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3& vel) { }
        // RVA: 0x0556F9F0  token: 0x60003B3
        private System.Void GenerateImpactEvent2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3 vel) { }
        // RVA: 0x055703A4  token: 0x60003B4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF  // size: 0x30
    public class CinemachineFixedSignal : Cinemachine.SignalSourceAsset
    {
        // Fields
        public UnityEngine.AnimationCurve m_XCurve;  // 0x18
        public UnityEngine.AnimationCurve m_YCurve;  // 0x20
        public UnityEngine.AnimationCurve m_ZCurve;  // 0x28

        // Properties
        System.Single SignalDuration { get; /* RVA: 0x05570B48 */ }

        // Methods
        // RVA: 0x055709E8  token: 0x60003B6
        private System.Single AxisDuration(UnityEngine.AnimationCurve axis) { }
        // RVA: 0x05570AAC  token: 0x60003B7
        public virtual System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        // RVA: 0x05570A68  token: 0x60003B8
        private System.Single AxisValue(UnityEngine.AnimationCurve axis, System.Single time) { }
        // RVA: 0x0286F540  token: 0x60003B9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0  // size: 0x80
    public class CinemachineImpulseDefinition
    {
        // Fields
        public System.Int32 m_ImpulseChannel;  // 0x10
        public Cinemachine.CinemachineImpulseDefinition.ImpulseShapes m_ImpulseShape;  // 0x14
        public UnityEngine.AnimationCurve m_CustomImpulseShape;  // 0x18
        public System.Single m_ImpulseDuration;  // 0x20
        public Cinemachine.CinemachineImpulseDefinition.ImpulseTypes m_ImpulseType;  // 0x24
        public System.Single m_DissipationRate;  // 0x28
        public Cinemachine.SignalSourceAsset m_RawSignal;  // 0x30
        public System.Single m_AmplitudeGain;  // 0x38
        public System.Single m_FrequencyGain;  // 0x3c
        public Cinemachine.CinemachineImpulseDefinition.RepeatMode m_RepeatMode;  // 0x40
        public System.Boolean m_Randomize;  // 0x44
        public Cinemachine.CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope;  // 0x48
        public System.Single m_ImpactRadius;  // 0x68
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;  // 0x6c
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;  // 0x70
        public System.Single m_DissipationDistance;  // 0x74
        public System.Single m_PropagationSpeed;  // 0x78
        private static UnityEngine.AnimationCurve[] sStandardShapes;  // static @ 0x0

        // Properties
        UnityEngine.AnimationCurve ImpulseCurve { get; /* RVA: 0x05571C7C */ }

        // Methods
        // RVA: 0x05571BA4  token: 0x60003BA
        public System.Void OnValidate() { }
        // RVA: 0x05570DE4  token: 0x60003BB
        private static System.Void CreateStandardShapes() { }
        // RVA: 0x05571948  token: 0x60003BC
        private static UnityEngine.AnimationCurve GetStandardCurve(Cinemachine.CinemachineImpulseDefinition.ImpulseShapes shape) { }
        // RVA: 0x05570DA4  token: 0x60003BE
        public System.Void CreateEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        // RVA: 0x05570BA8  token: 0x60003BF
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        // RVA: 0x055719BC  token: 0x60003C0
        private Cinemachine.CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        // RVA: 0x02C61F70  token: 0x60003C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6  // size: 0x68
    public class CinemachineImpulseListener : Cinemachine.CinemachineExtension
    {
        // Fields
        public Cinemachine.CinemachineCore.Stage m_ApplyAfter;  // 0x28
        public System.Int32 m_ChannelMask;  // 0x2c
        public System.Single m_Gain;  // 0x30
        public System.Boolean m_Use2DDistance;  // 0x34
        public System.Boolean m_UseCameraSpace;  // 0x35
        public Cinemachine.CinemachineImpulseListener.ImpulseReaction m_ReactionSettings;  // 0x38

        // Methods
        // RVA: 0x05571CD4  token: 0x60003C8
        private System.Void Reset() { }
        // RVA: 0x027448A0  token: 0x60003C9
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x039CB270  token: 0x60003CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8  // size: 0x10
    public sealed class CinemachineImpulseChannelPropertyAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60003CD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9  // size: 0x28
    public class CinemachineImpulseManager
    {
        // Fields
        private static Cinemachine.CinemachineImpulseManager sInstance;  // static @ 0x0
        private System.Collections.Generic.List<Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents;  // 0x10
        private System.Collections.Generic.List<Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents;  // 0x18
        public System.Boolean IgnoreTimeScale;  // 0x20

        // Properties
        Cinemachine.CinemachineImpulseManager Instance { get; /* RVA: 0x02744810 */ }
        System.Single CurrentTime { get; /* RVA: 0x05572000 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60003CE
        private System.Void .ctor() { }
        // RVA: 0x03D417E0  token: 0x60003D0
        private static System.Void InitializeModule() { }
        // RVA: 0x05571E9C  token: 0x60003D1
        private static System.Single EvaluateDissipationScale(System.Single spread, System.Single normalizedDistance) { }
        // RVA: 0x02744170  token: 0x60003D2
        public System.Boolean GetImpulseAt(UnityEngine.Vector3 listenerLocation, System.Boolean distance2D, System.Int32 channelMask, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        // RVA: 0x05571F3C  token: 0x60003D4
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent NewImpulseEvent() { }
        // RVA: 0x05571D38  token: 0x60003D5
        public System.Void AddImpulseEvent(Cinemachine.CinemachineImpulseManager.ImpulseEvent e) { }
        // RVA: 0x05571DFC  token: 0x60003D6
        public System.Void Clear() { }

    }

    // TypeToken: 0x20000BE  // size: 0x30
    public class CinemachineImpulseSource : UnityEngine.MonoBehaviour
    {
        // Fields
        public Cinemachine.CinemachineImpulseDefinition m_ImpulseDefinition;  // 0x18
        public UnityEngine.Vector3 m_DefaultVelocity;  // 0x20

        // Methods
        // RVA: 0x05572248  token: 0x60003E3
        private System.Void OnValidate() { }
        // RVA: 0x05572268  token: 0x60003E4
        private System.Void Reset() { }
        // RVA: 0x05572050  token: 0x60003E5
        public System.Void GenerateImpulseAtPositionWithVelocity(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        // RVA: 0x0557217C  token: 0x60003E6
        public System.Void GenerateImpulseWithVelocity(UnityEngine.Vector3 velocity) { }
        // RVA: 0x055720DC  token: 0x60003E7
        public System.Void GenerateImpulseWithForce(System.Single force) { }
        // RVA: 0x055721F0  token: 0x60003E8
        public System.Void GenerateImpulse() { }
        // RVA: 0x0557209C  token: 0x60003E9
        public System.Void GenerateImpulseAt(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        // RVA: 0x05572220  token: 0x60003EA
        public System.Void GenerateImpulse(UnityEngine.Vector3 velocity) { }
        // RVA: 0x05572218  token: 0x60003EB
        public System.Void GenerateImpulse(System.Single force) { }
        // RVA: 0x03CB4DB0  token: 0x60003EC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF  // size: 0x70
    public class CinemachineIndependentImpulseListener : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 impulsePosLastFrame;  // 0x18
        private UnityEngine.Quaternion impulseRotLastFrame;  // 0x24
        public System.Int32 m_ChannelMask;  // 0x34
        public System.Single m_Gain;  // 0x38
        public System.Boolean m_Use2DDistance;  // 0x3c
        public System.Boolean m_UseLocalSpace;  // 0x3d
        public Cinemachine.CinemachineImpulseListener.ImpulseReaction m_ReactionSettings;  // 0x40

        // Methods
        // RVA: 0x055726C4  token: 0x60003ED
        private System.Void Reset() { }
        // RVA: 0x05572694  token: 0x60003EE
        private System.Void OnEnable() { }
        // RVA: 0x05572720  token: 0x60003EF
        private System.Void Update() { }
        // RVA: 0x0557235C  token: 0x60003F0
        private System.Void LateUpdate() { }
        // RVA: 0x0426FE60  token: 0x60003F1
        public System.Void .ctor() { }

    }

}

namespace Cinemachine.PostFX
{

    // TypeToken: 0x20000C0  // size: 0x28
    public class CinemachinePostProcessing : Cinemachine.CinemachineExtension
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60003F2
        protected virtual System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        // RVA: 0x0426FE60  token: 0x60003F3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1  // size: 0x18
    public class CinemachineVolumeSettings : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x60003F4
        public System.Void .ctor() { }

    }

}

namespace Cinemachine.Utility
{

    // TypeToken: 0x20000C2  // size: 0x10
    public class CinemachineDebug
    {
        // Fields
        private static System.Collections.Generic.HashSet<UnityEngine.Object> mClients;  // static @ 0x0
        public static Cinemachine.Utility.CinemachineDebug.OnGUIDelegate OnGUIHandlers;  // static @ 0x8
        private static System.Collections.Generic.List<System.Text.StringBuilder> mAvailableStringBuilders;  // static @ 0x10

        // Methods
        // RVA: 0x05570778  token: 0x60003F5
        public static System.Void ReleaseScreenPos(UnityEngine.Object client) { }
        // RVA: 0x05570400  token: 0x60003F6
        public static UnityEngine.Rect GetScreenPos(UnityEngine.Object client, System.String text, UnityEngine.GUIStyle style) { }
        // RVA: 0x055708F4  token: 0x60003F7
        public static System.Text.StringBuilder SBFromPool() { }
        // RVA: 0x05570810  token: 0x60003F8
        public static System.Void ReturnToPool(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x20000C4  // size: 0x40
    public class PositionPredictor
    {
        // Fields
        private UnityEngine.Vector3 m_Velocity;  // 0x10
        private UnityEngine.Vector3 m_SmoothDampVelocity;  // 0x1c
        private UnityEngine.Vector3 m_Pos;  // 0x28
        private System.Boolean m_HavePos;  // 0x34
        public System.Single Smoothing;  // 0x38

        // Methods
        // RVA: 0x0557476C  token: 0x60003FB
        public System.Void ApplyTransformDelta(UnityEngine.Vector3 positionDelta) { }
        // RVA: 0x05574800  token: 0x60003FC
        public System.Void Reset() { }
        // RVA: 0x055745BC  token: 0x60003FD
        public System.Void AddPosition(UnityEngine.Vector3 pos, System.Single deltaTime, System.Single lookaheadTime) { }
        // RVA: 0x055747C0  token: 0x60003FE
        public UnityEngine.Vector3 PredictPositionDelta(System.Single lookaheadTime) { }
        // RVA: 0x0350B670  token: 0x60003FF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5  // size: 0x10
    public static class Damper
    {
        // Methods
        // RVA: 0x024DB130  token: 0x6000400
        public static System.Single Damp(System.Single initial, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x024DB1B0  token: 0x6000401
        public static UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime) { }
        // RVA: 0x0557320C  token: 0x6000402
        public static UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime) { }

    }

    // TypeToken: 0x20000C6  // size: 0x48
    public class HeadingTracker
    {
        // Fields
        private Cinemachine.Utility.HeadingTracker.Item[] mHistory;  // 0x10
        private System.Int32 mTop;  // 0x18
        private System.Int32 mBottom;  // 0x1c
        private System.Int32 mCount;  // 0x20
        private UnityEngine.Vector3 mHeadingSum;  // 0x24
        private System.Single mWeightSum;  // 0x30
        private System.Single mWeightTime;  // 0x34
        private UnityEngine.Vector3 mLastGoodHeading;  // 0x38
        private static System.Single mDecayExponent;  // static @ 0x0

        // Properties
        System.Int32 FilterSize { get; /* RVA: 0x042746EC */ }

        // Methods
        // RVA: 0x05573C40  token: 0x6000403
        public System.Void .ctor(System.Int32 filterSize) { }
        // RVA: 0x05573894  token: 0x6000405
        private System.Void ClearHistory() { }
        // RVA: 0x05573974  token: 0x6000406
        private static System.Single Decay(System.Single time) { }
        // RVA: 0x055736D8  token: 0x6000407
        public System.Void Add(UnityEngine.Vector3 velocity) { }
        // RVA: 0x05573AB4  token: 0x6000408
        private System.Void PopBottom() { }
        // RVA: 0x055738B4  token: 0x6000409
        public System.Void DecayHistory() { }
        // RVA: 0x055739C0  token: 0x600040A
        public UnityEngine.Vector3 GetReliableHeading() { }

    }

    // TypeToken: 0x20000C8  // size: 0x10
    public static class SplineHelpers
    {
        // Methods
        // RVA: 0x055749DC  token: 0x600040B
        public static UnityEngine.Vector3 Bezier3(System.Single t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3) { }
        // RVA: 0x05574B68  token: 0x600040C
        public static UnityEngine.Vector3 BezierTangent3(System.Single t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3) { }
        // RVA: 0x05574950  token: 0x600040D
        public static System.Single Bezier1(System.Single t, System.Single p0, System.Single p1, System.Single p2, System.Single p3) { }
        // RVA: 0x0557517C  token: 0x600040E
        public static System.Void ComputeSmoothControlPoints(UnityEngine.Vector4[]& knot, UnityEngine.Vector4[]& ctrl1, UnityEngine.Vector4[]& ctrl2) { }
        // RVA: 0x05574EC0  token: 0x600040F
        public static System.Void ComputeSmoothControlPointsLooped(UnityEngine.Vector4[]& knot, UnityEngine.Vector4[]& ctrl1, UnityEngine.Vector4[]& ctrl2) { }

    }

    // TypeToken: 0x20000C9  // size: 0x10
    public static class UnityVectorExtensions
    {
        // Methods
        // RVA: 0x0262E1E0  token: 0x6000410
        public static System.Boolean IsNaN(UnityEngine.Vector3 v) { }
        // RVA: 0x05575CE4  token: 0x6000411
        public static System.Single ClosestPointOnSegment(UnityEngine.Vector3 p, UnityEngine.Vector3 s0, UnityEngine.Vector3 s1) { }
        // RVA: 0x05575C4C  token: 0x6000412
        public static System.Single ClosestPointOnSegment(UnityEngine.Vector2 p, UnityEngine.Vector2 s0, UnityEngine.Vector2 s1) { }
        // RVA: 0x02B25350  token: 0x6000413
        public static UnityEngine.Vector3 ProjectOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal) { }
        // RVA: 0x03D50B00  token: 0x6000414
        public static UnityEngine.Vector2 Abs(UnityEngine.Vector2 v) { }
        // RVA: 0x05575DC4  token: 0x6000415
        public static System.Boolean IsUniform(UnityEngine.Vector2 v) { }
        // RVA: 0x0258B400  token: 0x6000416
        public static System.Boolean AlmostZero(UnityEngine.Vector3 v) { }
        // RVA: 0x0238EB70  token: 0x6000417
        public static System.Single Angle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        // RVA: 0x025884E0  token: 0x6000418
        public static System.Single SignedAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up) { }
        // RVA: 0x02B22680  token: 0x6000419
        public static UnityEngine.Quaternion SafeFromToRotation(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up) { }

    }

    // TypeToken: 0x20000CA  // size: 0x10
    public static class UnityQuaternionExtensions
    {
        // Methods
        // RVA: 0x0557593C  token: 0x600041A
        public static UnityEngine.Quaternion SlerpWithReferenceUp(UnityEngine.Quaternion qA, UnityEngine.Quaternion qB, System.Single t, UnityEngine.Vector3 up) { }
        // RVA: 0x025A1560  token: 0x600041B
        public static UnityEngine.Quaternion Normalized(UnityEngine.Quaternion q) { }
        // RVA: 0x0258ADE0  token: 0x600041C
        public static UnityEngine.Vector2 GetCameraRotationToTarget(UnityEngine.Quaternion orient, UnityEngine.Vector3 lookAtDir, UnityEngine.Vector3 worldUp) { }
        // RVA: 0x02745680  token: 0x600041D
        public static UnityEngine.Quaternion ApplyCameraRotation(UnityEngine.Quaternion orient, UnityEngine.Vector2 rot, UnityEngine.Vector3 worldUp) { }

    }

}

