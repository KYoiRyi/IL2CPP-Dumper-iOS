// ========================================================
// Dumped by @desirepro
// Assembly: RootMotion.dll
// Classes:  226
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.Baker.Mode AnimationClips;  // const
        public static RootMotion.Baker.Mode AnimationStates;  // const
        public static RootMotion.Baker.Mode PlayableDirector;  // const
        public static RootMotion.Baker.Mode Realtime;  // const

    }

    // TypeToken: 0x2000004  // size: 0x80
    public sealed class BakerDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x07977CB8  token: 0x6000014
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000015
        public virtual System.Void Invoke(UnityEngine.AnimationClip clip, System.Single time) { }
        // RVA: 0x095F5C78  token: 0x6000016
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.AnimationClip clip, System.Single time, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000017
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct BasedUponRotation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.Baker.ClipSettings.BasedUponRotation Original;  // const
        public static RootMotion.Baker.ClipSettings.BasedUponRotation BodyOrientation;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct BasedUponY
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.Baker.ClipSettings.BasedUponY Original;  // const
        public static RootMotion.Baker.ClipSettings.BasedUponY CenterOfMass;  // const
        public static RootMotion.Baker.ClipSettings.BasedUponY Feet;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct BasedUponXZ
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.Baker.ClipSettings.BasedUponXZ Original;  // const
        public static RootMotion.Baker.ClipSettings.BasedUponXZ CenterOfMass;  // const

    }

    // TypeToken: 0x2000005  // size: 0x40
    public class ClipSettings
    {
        // Fields
        public System.Boolean loopTime;  // 0x10
        public System.Boolean loopBlend;  // 0x11
        public System.Single cycleOffset;  // 0x14
        public System.Boolean loopBlendOrientation;  // 0x18
        public RootMotion.Baker.ClipSettings.BasedUponRotation basedUponRotation;  // 0x1c
        public System.Single orientationOffsetY;  // 0x20
        public System.Boolean loopBlendPositionY;  // 0x24
        public RootMotion.Baker.ClipSettings.BasedUponY basedUponY;  // 0x28
        public System.Single level;  // 0x2c
        public System.Boolean loopBlendPositionXZ;  // 0x30
        public RootMotion.Baker.ClipSettings.BasedUponXZ basedUponXZ;  // 0x34
        public System.Boolean mirror;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000018
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x38
    public class LimbOrientation
    {
        // Fields
        public UnityEngine.Vector3 upperBoneForwardAxis;  // 0x10
        public UnityEngine.Vector3 lowerBoneForwardAxis;  // 0x1c
        public UnityEngine.Vector3 lastBoneLeftAxis;  // 0x28

        // Methods
        // RVA: 0x03D587B0  token: 0x6000060
        public System.Void .ctor(UnityEngine.Vector3 upperBoneForwardAxis, UnityEngine.Vector3 lowerBoneForwardAxis, UnityEngine.Vector3 lastBoneLeftAxis) { }

    }

    // TypeToken: 0x2000016  // size: 0x14
    public sealed struct BoneType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.BipedNaming.BoneType Unassigned;  // const
        public static RootMotion.BipedNaming.BoneType Spine;  // const
        public static RootMotion.BipedNaming.BoneType Head;  // const
        public static RootMotion.BipedNaming.BoneType Arm;  // const
        public static RootMotion.BipedNaming.BoneType Leg;  // const
        public static RootMotion.BipedNaming.BoneType Tail;  // const
        public static RootMotion.BipedNaming.BoneType Eye;  // const

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct BoneSide
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.BipedNaming.BoneSide Center;  // const
        public static RootMotion.BipedNaming.BoneSide Left;  // const
        public static RootMotion.BipedNaming.BoneSide Right;  // const

    }

    // TypeToken: 0x2000019  // size: 0x12
    public sealed struct AutoDetectParams
    {
        // Fields
        public System.Boolean legsParentInSpine;  // 0x10
        public System.Boolean includeEyes;  // 0x11

        // Properties
        RootMotion.BipedReferences.AutoDetectParams Default { get; /* RVA: 0x03D74300 */ }

        // Methods
        // RVA: 0x03D67530  token: 0x6000091
        public System.Void .ctor(System.Boolean legsParentInSpine, System.Boolean includeEyes) { }

    }

    // TypeToken: 0x200002E  // size: 0x80
    public sealed class Logger : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x055582DC  token: 0x600012E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600012F
        public virtual System.Void Invoke(System.String message) { }
        // RVA: 0x0389C3B0  token: 0x6000130
        public virtual System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000131
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000030  // size: 0x14
    public sealed struct State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.Demos.Navigator.State Idle;  // const
        public static RootMotion.Demos.Navigator.State Seeking;  // const
        public static RootMotion.Demos.Navigator.State OnPath;  // const

    }

    // TypeToken: 0x200003A  // size: 0x14
    public sealed struct DOF
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.Finger.DOF One;  // const
        public static RootMotion.FinalIK.Finger.DOF Three;  // const

    }

    // TypeToken: 0x200003D  // size: 0x80
    public sealed class GrounderDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x6000194
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000195
        public virtual System.Void Invoke() { }
        // RVA: 0x042BE018  token: 0x6000196
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000197
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000040  // size: 0x20
    public class SpineEffector
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effectorType;  // 0x10
        public System.Single horizontalWeight;  // 0x14
        public System.Single verticalWeight;  // 0x18

        // Methods
        // RVA: 0x03D58F50  token: 0x60001B9
        public System.Void .ctor() { }
        // RVA: 0x03D74A50  token: 0x60001BA
        public System.Void .ctor(RootMotion.FinalIK.FullBodyBipedEffector effectorType, System.Single horizontalWeight, System.Single verticalWeight) { }

    }

    // TypeToken: 0x2000043  // size: 0x38
    public sealed struct Foot
    {
        // Fields
        public RootMotion.FinalIK.IKSolver solver;  // 0x10
        public UnityEngine.Transform transform;  // 0x18
        public UnityEngine.Quaternion rotation;  // 0x20
        public RootMotion.FinalIK.Grounding.Leg leg;  // 0x30

        // Methods
        // RVA: 0x09606160  token: 0x60001D9
        public System.Void .ctor(RootMotion.FinalIK.IKSolver solver, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000045  // size: 0x14
    public sealed struct Quality
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.Grounding.Quality Fastest;  // const
        public static RootMotion.FinalIK.Grounding.Quality Simple;  // const
        public static RootMotion.FinalIK.Grounding.Quality Best;  // const
        public static RootMotion.FinalIK.Grounding.Quality Custom;  // const

    }

    // TypeToken: 0x2000046  // size: 0x80
    public sealed class OnRaycastDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03521AA0  token: 0x6000200
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x05011CFC  token: 0x6000201
        public virtual System.Boolean Invoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0960CEB0  token: 0x6000202
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C0FC0  token: 0x6000203
        public virtual System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000047  // size: 0x80
    public sealed class OnCapsuleCastDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03521B30  token: 0x6000204
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x050112A8  token: 0x6000205
        public virtual System.Boolean Invoke(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0960CD70  token: 0x6000206
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C0FC0  token: 0x6000207
        public virtual System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000048  // size: 0x80
    public sealed class OnSphereCastDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03521A10  token: 0x6000208
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x05010C40  token: 0x6000209
        public virtual System.Boolean Invoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0960CFDC  token: 0x600020A
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C0FC0  token: 0x600020B
        public virtual System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000049  // size: 0x328
    public class Leg
    {
        // Fields
        private System.Boolean <isGrounded>k__BackingField;  // 0x10
        private UnityEngine.Vector3 <IKPosition>k__BackingField;  // 0x14
        public UnityEngine.Quaternion rotationOffset;  // 0x20
        private System.Boolean <initiated>k__BackingField;  // 0x30
        private System.Single <heightFromGround>k__BackingField;  // 0x34
        private System.Single <fowardMoveFromGround>k__BackingField;  // 0x38
        private System.Single <rightMoveFromGround>k__BackingField;  // 0x3c
        private UnityEngine.Vector3 <velocity>k__BackingField;  // 0x40
        private UnityEngine.Transform <transform>k__BackingField;  // 0x50
        private System.Single <IKOffset>k__BackingField;  // 0x58
        private System.Single <IKOffsetZ>k__BackingField;  // 0x5c
        private System.Single <IKOffsetX>k__BackingField;  // 0x60
        private UnityEngine.RaycastHit <heelHit>k__BackingField;  // 0x68
        private UnityEngine.RaycastHit <capsuleHit>k__BackingField;  // 0xa8
        public System.Boolean invertFootCenter;  // 0xe8
        private UnityEngine.Vector3 m_lastEntityPos;  // 0xec
        private UnityEngine.Vector3 m_lastFootPos;  // 0xf8
        private UnityEngine.Vector3 m_lastHeelPoint;  // 0x104
        private UnityEngine.Vector3 m_lastToePoint;  // 0x110
        private UnityEngine.Vector3 m_lastSidePoint;  // 0x11c
        private RootMotion.FinalIK.Grounding grounding;  // 0x128
        private System.Single lastTime;  // 0x130
        private System.Single deltaTime;  // 0x134
        private UnityEngine.Vector3 lastPosition;  // 0x138
        private UnityEngine.Quaternion toHitNormal;  // 0x144
        private UnityEngine.Quaternion r;  // 0x154
        private UnityEngine.Vector3 up;  // 0x164
        private UnityEngine.Vector3 forward;  // 0x170
        private UnityEngine.Vector3 speedDir;  // 0x17c
        private UnityEngine.Vector3 lastTransformPosition;  // 0x188
        private System.Boolean doOverrideFootPosition;  // 0x194
        private UnityEngine.Vector3 overrideFootPosition;  // 0x198
        public UnityEngine.Vector3 transformPosition;  // 0x1a4
        private static readonly Unity.Profiling.ProfilerMarker MARKER_TEMP_PREDICT_FOOT_CAST;  // static @ 0x0
        private static readonly Unity.Profiling.ProfilerMarker MARKER_TEMP_BUILTIN_BEST_CAST;  // static @ 0x8
        public static System.Single MAX_PREDICTION_DISTANCE;  // const
        private UnityEngine.Vector2 lastFramePredictPos;  // 0x1b0
        public UnityEngine.Vector3 predictOffset;  // 0x1b8
        public UnityEngine.Vector3 lastPredictOffset;  // 0x1c4
        public UnityEngine.Vector3 lastPredictOffsetwithPercent;  // 0x1d0
        private UnityEngine.Vector3 m_predictOffsetwithPercent;  // 0x1dc
        private System.Boolean hasPredictThisStep;  // 0x1e8
        public UnityEngine.RaycastHit curPredictHit;  // 0x1f0
        public System.Single curStepTime;  // 0x230
        public UnityEngine.RaycastHit curCapsuleHit;  // 0x238
        public UnityEngine.Vector3 lastLandFootPos;  // 0x278
        private System.Single feetOffsetFromRoot;  // 0x284
        public UnityEngine.Vector3 lastPathPoint;  // 0x288
        public UnityEngine.RaycastHit m_heelHit;  // 0x298
        public UnityEngine.Vector3 curFeetCalculatePos;  // 0x2d8
        private UnityEngine.Vector3 lastCurHitPoint;  // 0x2e4
        public UnityEngine.Vector3 predictLimitForwardOffset;  // 0x2f0
        private System.Single m_maxStep;  // 0x2fc
        private UnityEngine.Vector3 m_lastHitNormal;  // 0x300
        private System.Boolean m_isInStair;  // 0x30c
        public System.Single footSpeed;  // 0x310
        public System.Single heightFromRoot;  // 0x314
        public System.Boolean isLastFrameLegStretch;  // 0x318
        private UnityEngine.Vector3 lastCapusuleHitPos;  // 0x31c

        // Properties
        System.Boolean isGrounded { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        UnityEngine.Vector3 IKPosition { get; /* RVA: 0x01176980 */ set; /* RVA: 0x03D6E520 */ }
        System.Boolean initiated { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }
        System.Single heightFromGround { get; /* RVA: 0x03D56CA0 */ set; /* RVA: 0x03D56CB0 */ }
        System.Single fowardMoveFromGround { get; /* RVA: 0x03D51000 */ set; /* RVA: 0x03D51010 */ }
        System.Single rightMoveFromGround { get; /* RVA: 0x03D4EC60 */ set; /* RVA: 0x03D4ECE0 */ }
        UnityEngine.Vector3 velocity { get; /* RVA: 0x03D52300 */ set; /* RVA: 0x03D52330 */ }
        UnityEngine.Transform transform { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.Single IKOffset { get; /* RVA: 0x03D51080 */ set; /* RVA: 0x03D510B0 */ }
        System.Single IKOffsetZ { get; /* RVA: 0x03D56C10 */ set; /* RVA: 0x03D5BDF0 */ }
        System.Single IKOffsetX { get; /* RVA: 0x03D50D50 */ set; /* RVA: 0x03D50D80 */ }
        UnityEngine.RaycastHit heelHit { get; /* RVA: 0x03D749C0 */ set; /* RVA: 0x03D74A20 */ }
        UnityEngine.RaycastHit capsuleHit { get; /* RVA: 0x03D74990 */ set; /* RVA: 0x03D749F0 */ }
        UnityEngine.RaycastHit GetHitPoint { get; /* RVA: 0x0960CCDC */ }
        UnityEngine.Vector3 right { get; /* RVA: 0x02388EC0 */ }
        UnityEngine.Vector3 speedRight { get; /* RVA: 0x03577330 */ }
        UnityEngine.Vector3 predictOffsetwithPercent { get; /* RVA: 0x031145F0 */ }
        System.Boolean isLeft { get; /* RVA: 0x02E50A90 */ }
        System.Boolean isMoving { get; /* RVA: 0x0960CD50 */ }
        System.Single stepHeightFromGround { get; /* RVA: 0x0303B890 */ }
        System.Single stepForwardFromGround { get; /* RVA: 0x0306A270 */ }
        System.Single stepRightFromGround { get; /* RVA: 0x0306A2A0 */ }
        UnityEngine.Vector3 animFootGroundPos { get; /* RVA: 0x0238FC10 */ }
        System.Single rootYOffset { get; /* RVA: 0x02388AC0 */ }

        // Methods
        // RVA: 0x03D74970  token: 0x6000227
        public System.Void SetFootPosition(UnityEngine.Vector3 position) { }
        // RVA: 0x030DB9F0  token: 0x600022A
        public System.Void Initiate(RootMotion.FinalIK.Grounding grounding, UnityEngine.Transform transform) { }
        // RVA: 0x030DBAD0  token: 0x600022B
        public System.Void OnEnable() { }
        // RVA: 0x0960C978  token: 0x600022C
        public System.Void Reset() { }
        // RVA: 0x02E509F0  token: 0x600022E
        private System.Void _ResetPredictReference(UnityEngine.RaycastHit curHit) { }
        // RVA: 0x02A5D410  token: 0x600022F
        private System.Void _PredictNextStepHit(UnityEngine.Vector3 prediction, UnityEngine.Vector3 predictVec, System.Boolean canChangeHeight) { }
        // RVA: 0x02A5D640  token: 0x6000230
        private System.Single _CanHitPointLand(UnityEngine.RaycastHit hit, UnityEngine.RaycastHit& predictHit) { }
        // RVA: 0x022F51C0  token: 0x6000233
        public System.Void Process() { }
        // RVA: 0x032071E0  token: 0x6000234
        private System.Void _UpdateHeelHit(System.Single curStepPercent, UnityEngine.Vector3 prediction) { }
        // RVA: 0x032072E0  token: 0x6000235
        private UnityEngine.Vector3 _UpdatePredictOffset(System.Single curStepPercent) { }
        // RVA: 0x02EC8C80  token: 0x6000236
        public System.Void FinalSetIKPosition(UnityEngine.Vector3 thighPos) { }
        // RVA: 0x029FA5B0  token: 0x600023A
        private UnityEngine.RaycastHit GetCapsuleHit(UnityEngine.Vector3 offsetFromHeel, UnityEngine.Vector3 predictPos) { }
        // RVA: 0x0960BE2C  token: 0x600023B
        private UnityEngine.RaycastHit GetCapsuleHit(UnityEngine.Vector3 offsetFromHeel) { }
        // RVA: 0x027EA3C0  token: 0x600023C
        private UnityEngine.RaycastHit GetRaycastHitCustom(UnityEngine.Vector3 offsetFromHeel) { }
        // RVA: 0x0960C528  token: 0x600023D
        private UnityEngine.RaycastHit GetRaycastHit(UnityEngine.Vector3 offsetFromHeel) { }
        // RVA: 0x02387690  token: 0x600023E
        private UnityEngine.Vector3 RotateNormal(UnityEngine.Vector3 normal) { }
        // RVA: 0x0960CC14  token: 0x600023F
        private System.Void SetFootToPoint(UnityEngine.Vector3 normal, UnityEngine.Vector3 point) { }
        // RVA: 0x0960CA04  token: 0x6000240
        private System.Void SetFootToPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 heelHitPoint) { }
        // RVA: 0x02387320  token: 0x6000241
        private System.Void SetFootToPoint(UnityEngine.Vector3 normal, UnityEngine.Vector3 pointForXZ, UnityEngine.Vector3 pointForY) { }
        // RVA: 0x0285CE70  token: 0x6000242
        private System.Void SetFootToPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 heelHitPoint, UnityEngine.Vector3 footNormal, System.Boolean isLimitByComplex) { }
        // RVA: 0x023883F0  token: 0x6000243
        private System.Single GetHeightFromGround(UnityEngine.Vector3 hitPoint) { }
        // RVA: 0x0264A1F0  token: 0x6000244
        private System.Void RotateFoot() { }
        // RVA: 0x03D74960  token: 0x6000245
        private UnityEngine.Quaternion GetRotationOffsetTarget() { }
        // RVA: 0x02387700  token: 0x6000248
        private UnityEngine.Vector3 RotateNormalWithLimit(UnityEngine.Vector3 normal) { }
        // RVA: 0x030DB980  token: 0x6000249
        public System.Void .ctor() { }
        // RVA: 0x03CBA040  token: 0x600024A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004A  // size: 0x48
    public class Pelvis
    {
        // Fields
        private UnityEngine.Vector3 <IKOffset>k__BackingField;  // 0x10
        private System.Single <heightOffset>k__BackingField;  // 0x1c
        private System.Single forwardOffset;  // 0x20
        public System.Single pelivsSpeedY;  // 0x24
        private RootMotion.FinalIK.Grounding grounding;  // 0x28
        private UnityEngine.Vector3 lastRootPosition;  // 0x30
        private System.Single damperF;  // 0x3c
        private System.Boolean initiated;  // 0x40
        private System.Single lastTime;  // 0x44

        // Properties
        UnityEngine.Vector3 IKOffset { get; /* RVA: 0x03D55550 */ set; /* RVA: 0x03D55570 */ }
        System.Single heightOffset { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }

        // Methods
        // RVA: 0x030DBB30  token: 0x600024F
        public System.Void Initiate(RootMotion.FinalIK.Grounding grounding) { }
        // RVA: 0x0960D4D0  token: 0x6000250
        public System.Void Reset() { }
        // RVA: 0x030DBB60  token: 0x6000251
        public System.Void OnEnable() { }
        // RVA: 0x0281B9E0  token: 0x6000252
        public System.Void Process(System.Single pelivsOffset, System.Single _forwardOffset, System.Boolean isGrounded, System.Boolean islastFrameLegStretch, System.Boolean isSameLegReflastFrame) { }
        // RVA: 0x0960D108  token: 0x6000253
        private UnityEngine.RaycastHit GetRaycastHitCustom(UnityEngine.Vector3 rayOrigin) { }
        // RVA: 0x0350B670  token: 0x6000254
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000058  // size: 0xC0
    public class References
    {
        // Fields
        public UnityEngine.Transform root;  // 0x10
        public UnityEngine.Transform pelvis;  // 0x18
        public UnityEngine.Transform spine;  // 0x20
        public UnityEngine.Transform chest;  // 0x28
        public UnityEngine.Transform neck;  // 0x30
        public UnityEngine.Transform head;  // 0x38
        public UnityEngine.Transform leftShoulder;  // 0x40
        public UnityEngine.Transform leftUpperArm;  // 0x48
        public UnityEngine.Transform leftForearm;  // 0x50
        public UnityEngine.Transform leftHand;  // 0x58
        public UnityEngine.Transform rightShoulder;  // 0x60
        public UnityEngine.Transform rightUpperArm;  // 0x68
        public UnityEngine.Transform rightForearm;  // 0x70
        public UnityEngine.Transform rightHand;  // 0x78
        public UnityEngine.Transform leftThigh;  // 0x80
        public UnityEngine.Transform leftCalf;  // 0x88
        public UnityEngine.Transform leftFoot;  // 0x90
        public UnityEngine.Transform leftToes;  // 0x98
        public UnityEngine.Transform rightThigh;  // 0xa0
        public UnityEngine.Transform rightCalf;  // 0xa8
        public UnityEngine.Transform rightFoot;  // 0xb0
        public UnityEngine.Transform rightToes;  // 0xb8

        // Properties
        System.Boolean isFilled { get; /* RVA: 0x0961F888 */ }
        System.Boolean isEmpty { get; /* RVA: 0x0961F518 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60002B0
        public System.Void .ctor() { }
        // RVA: 0x0961F2D4  token: 0x60002B1
        public System.Void .ctor(RootMotion.BipedReferences b) { }
        // RVA: 0x0961EFB4  token: 0x60002B2
        public UnityEngine.Transform[] GetTransforms() { }
        // RVA: 0x0961EB1C  token: 0x60002B5
        public static System.Boolean AutoDetectReferences(UnityEngine.Transform root, RootMotion.FinalIK.VRIK.References& references) { }

    }

    // TypeToken: 0x200005C  // size: 0x30
    public class BendBone
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public System.Single weight;  // 0x18
        private UnityEngine.Quaternion defaultLocalRotation;  // 0x1c

        // Methods
        // RVA: 0x0960D5F0  token: 0x60002CE
        public System.Void .ctor() { }
        // RVA: 0x0960D5B8  token: 0x60002CF
        public System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }
        // RVA: 0x0960D584  token: 0x60002D0
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x0960D550  token: 0x60002D1
        public System.Void FixTransforms() { }

    }

    // TypeToken: 0x200005E  // size: 0x40
    public class ChildConstraint
    {
        // Fields
        public System.Single pushElasticity;  // 0x10
        public System.Single pullElasticity;  // 0x14
        private UnityEngine.Transform bone1;  // 0x18
        private UnityEngine.Transform bone2;  // 0x20
        private System.Single <nominalDistance>k__BackingField;  // 0x28
        private System.Boolean <isRigid>k__BackingField;  // 0x2c
        private System.Single crossFade;  // 0x30
        private System.Single inverseCrossFade;  // 0x34
        private System.Int32 chain1Index;  // 0x38
        private System.Int32 chain2Index;  // 0x3c

        // Properties
        System.Single nominalDistance { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x03D4F490 */ }
        System.Boolean isRigid { get; /* RVA: 0x03D4F1A0 */ set; /* RVA: 0x03D4F1B0 */ }

        // Methods
        // RVA: 0x0960F670  token: 0x60002EA
        public System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, System.Single pushElasticity, System.Single pullElasticity) { }
        // RVA: 0x0960F130  token: 0x60002EB
        public System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0960F188  token: 0x60002EC
        public System.Void OnPreSolve(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0960F35C  token: 0x60002ED
        public System.Void Solve(RootMotion.FinalIK.IKSolverFullBody solver) { }

    }

    // TypeToken: 0x200005F  // size: 0x14
    public sealed struct Smoothing
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.FBIKChain.Smoothing None;  // const
        public static RootMotion.FinalIK.FBIKChain.Smoothing Exponential;  // const
        public static RootMotion.FinalIK.FBIKChain.Smoothing Cubic;  // const

    }

    // TypeToken: 0x2000063  // size: 0xD0
    public class BoneMap
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public System.Int32 chainIndex;  // 0x18
        public System.Int32 nodeIndex;  // 0x1c
        public UnityEngine.Vector3 defaultLocalPosition;  // 0x20
        public UnityEngine.Quaternion defaultLocalRotation;  // 0x2c
        public UnityEngine.Vector3 localSwingAxis;  // 0x3c
        public UnityEngine.Vector3 localTwistAxis;  // 0x48
        public UnityEngine.Vector3 planePosition;  // 0x54
        public UnityEngine.Vector3 ikPosition;  // 0x60
        public UnityEngine.Quaternion defaultLocalTargetRotation;  // 0x6c
        private UnityEngine.Quaternion maintainRotation;  // 0x7c
        public System.Single length;  // 0x8c
        public UnityEngine.Quaternion animatedRotation;  // 0x90
        private UnityEngine.Transform planeBone1;  // 0xa0
        private UnityEngine.Transform planeBone2;  // 0xa8
        private UnityEngine.Transform planeBone3;  // 0xb0
        private System.Int32 plane1ChainIndex;  // 0xb8
        private System.Int32 plane1NodeIndex;  // 0xbc
        private System.Int32 plane2ChainIndex;  // 0xc0
        private System.Int32 plane2NodeIndex;  // 0xc4
        private System.Int32 plane3ChainIndex;  // 0xc8
        private System.Int32 plane3NodeIndex;  // 0xcc

        // Properties
        UnityEngine.Vector3 swingDirection { get; /* RVA: 0x0960E928 */ }
        System.Boolean isNodeBone { get; /* RVA: 0x0960E720 */ }
        UnityEngine.Quaternion lastAnimatedTargetRotation { get; /* RVA: 0x0960E728 */ }

        // Methods
        // RVA: 0x0960DA40  token: 0x600030E
        public System.Void Initiate(UnityEngine.Transform transform, RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0960E1B8  token: 0x6000310
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x0960D718  token: 0x6000311
        public System.Void FixTransform(System.Boolean position) { }
        // RVA: 0x0960DE14  token: 0x6000313
        public System.Void SetLength(RootMotion.FinalIK.IKMapping.BoneMap nextBone) { }
        // RVA: 0x0960DFE4  token: 0x6000314
        public System.Void SetLocalSwingAxis(RootMotion.FinalIK.IKMapping.BoneMap swingTarget) { }
        // RVA: 0x0960DEB4  token: 0x6000315
        public System.Void SetLocalSwingAxis(RootMotion.FinalIK.IKMapping.BoneMap bone1, RootMotion.FinalIK.IKMapping.BoneMap bone2) { }
        // RVA: 0x0960DFF0  token: 0x6000316
        public System.Void SetLocalTwistAxis(UnityEngine.Vector3 twistDirection, UnityEngine.Vector3 normalDirection) { }
        // RVA: 0x0960E090  token: 0x6000317
        public System.Void SetPlane(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Transform planeBone1, UnityEngine.Transform planeBone2, UnityEngine.Transform planeBone3) { }
        // RVA: 0x0960E5BC  token: 0x6000318
        public System.Void UpdatePlane(System.Boolean rotation, System.Boolean position) { }
        // RVA: 0x0960DDD8  token: 0x6000319
        public System.Void SetIKPosition() { }
        // RVA: 0x0960DA8C  token: 0x600031A
        public System.Void MaintainRotation() { }
        // RVA: 0x0960E17C  token: 0x600031B
        public System.Void SetToIKPosition() { }
        // RVA: 0x0960D614  token: 0x600031C
        public System.Void FixToNode(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight, RootMotion.FinalIK.IKSolver.Node fixNode) { }
        // RVA: 0x0960D780  token: 0x600031D
        public UnityEngine.Vector3 GetPlanePosition(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0960DAC0  token: 0x600031E
        public System.Void PositionToPlane(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0960DCF0  token: 0x600031F
        public System.Void RotateToPlane(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight) { }
        // RVA: 0x0960E3BC  token: 0x6000320
        public System.Void Swing(UnityEngine.Vector3 swingTarget, System.Single weight) { }
        // RVA: 0x0960E214  token: 0x6000321
        public System.Void Swing(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single weight) { }
        // RVA: 0x0960E440  token: 0x6000322
        public System.Void Twist(UnityEngine.Vector3 twistDirection, UnityEngine.Vector3 normalDirection, System.Single weight) { }
        // RVA: 0x0960DC58  token: 0x6000323
        public System.Void RotateToMaintain(System.Single weight) { }
        // RVA: 0x0960DB10  token: 0x6000324
        public System.Void RotateToEffector(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight) { }
        // RVA: 0x0960D878  token: 0x6000325
        private UnityEngine.Quaternion GetTargetRotation(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x03D74A60  token: 0x6000327
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000066  // size: 0x14
    public sealed struct BoneMapType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Parent;  // const
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Bone1;  // const
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Bone2;  // const
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Bone3;  // const

    }

    // TypeToken: 0x2000069  // size: 0x58
    public class Point
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public System.Single weight;  // 0x18
        public UnityEngine.Vector3 solverPosition;  // 0x1c
        public UnityEngine.Quaternion solverRotation;  // 0x28
        public UnityEngine.Vector3 defaultLocalPosition;  // 0x38
        public UnityEngine.Quaternion defaultLocalRotation;  // 0x44

        // Methods
        // RVA: 0x029EF5B0  token: 0x600035E
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x0251A6B0  token: 0x600035F
        public System.Void FixTransform() { }
        // RVA: 0x0961EA84  token: 0x6000360
        public System.Void UpdateSolverPosition() { }
        // RVA: 0x0961E9EC  token: 0x6000361
        public System.Void UpdateSolverLocalPosition() { }
        // RVA: 0x0961EAC0  token: 0x6000362
        public System.Void UpdateSolverState() { }
        // RVA: 0x0961EA28  token: 0x6000363
        public System.Void UpdateSolverLocalState() { }
        // RVA: 0x029ED9A0  token: 0x6000364
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006A  // size: 0x80
    public class Bone : Point
    {
        // Fields
        public System.Single length;  // 0x58
        public System.Single sqrMag;  // 0x5c
        public UnityEngine.Vector3 axis;  // 0x60
        private RootMotion.FinalIK.RotationLimit _rotationLimit;  // 0x70
        private System.Boolean isLimited;  // 0x78

        // Properties
        RootMotion.FinalIK.RotationLimit rotationLimit { get; /* RVA: 0x029EFAA0 */ set; /* RVA: 0x0960F0D0 */ }

        // Methods
        // RVA: 0x0960EDD8  token: 0x6000367
        public System.Void Swing(UnityEngine.Vector3 swingTarget, System.Single weight) { }
        // RVA: 0x0960E9E0  token: 0x6000368
        public static System.Void SolverSwing(RootMotion.FinalIK.IKSolver.Bone[] bones, System.Int32 index, UnityEngine.Vector3 swingTarget, System.Single weight) { }
        // RVA: 0x0960EC08  token: 0x6000369
        public System.Void Swing2D(UnityEngine.Vector3 swingTarget, System.Single weight) { }
        // RVA: 0x0960E9A4  token: 0x600036A
        public System.Void SetToSolverPosition() { }
        // RVA: 0x029ED940  token: 0x600036B
        public System.Void .ctor() { }
        // RVA: 0x0960F060  token: 0x600036C
        public System.Void .ctor(UnityEngine.Transform transform) { }
        // RVA: 0x0960EFDC  token: 0x600036D
        public System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }

    }

    // TypeToken: 0x200006B  // size: 0x70
    public class Node : Point
    {
        // Fields
        public System.Single length;  // 0x58
        public System.Single effectorPositionWeight;  // 0x5c
        public System.Single effectorRotationWeight;  // 0x60
        public UnityEngine.Vector3 offset;  // 0x64

        // Methods
        // RVA: 0x0961E9A0  token: 0x600036E
        public System.Void .ctor() { }
        // RVA: 0x0961E970  token: 0x600036F
        public System.Void .ctor(UnityEngine.Transform transform) { }
        // RVA: 0x0961E9A8  token: 0x6000370
        public System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }

    }

    // TypeToken: 0x200006C  // size: 0x80
    public sealed class UpdateDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02E30410  token: 0x6000371
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000372
        public virtual System.Void Invoke() { }
        // RVA: 0x042BE018  token: 0x6000373
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000374
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200006D  // size: 0x80
    public sealed class IterationDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056ECA08  token: 0x6000375
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000376
        public virtual System.Void Invoke(System.Int32 i) { }
        // RVA: 0x0961E52C  token: 0x6000377
        public virtual System.IAsyncResult BeginInvoke(System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000378
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007A  // size: 0x14
    public sealed struct BendModifier
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Animation;  // const
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Target;  // const
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Parent;  // const
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Arm;  // const
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Goal;  // const

    }

    // TypeToken: 0x200007B  // size: 0x2C
    public sealed struct AxisDirection
    {
        // Fields
        public UnityEngine.Vector3 direction;  // 0x10
        public UnityEngine.Vector3 axis;  // 0x1c
        public System.Single dot;  // 0x28

        // Methods
        // RVA: 0x025D3C30  token: 0x6000420
        public System.Void .ctor(UnityEngine.Vector3 direction, UnityEngine.Vector3 axis) { }

    }

    // TypeToken: 0x200007D  // size: 0x98
    public class LookAtBone : Bone
    {
        // Fields
        public UnityEngine.Vector3 positionOffset;  // 0x80
        public UnityEngine.Vector3 baseForwardOffsetEuler;  // 0x8c

        // Properties
        UnityEngine.Vector3 forward { get; /* RVA: 0x0258A9F0 */ }

        // Methods
        // RVA: 0x029ED920  token: 0x6000442
        public System.Void .ctor() { }
        // RVA: 0x029ED030  token: 0x6000443
        public System.Void .ctor(UnityEngine.Transform transform) { }
        // RVA: 0x035042E0  token: 0x6000444
        public System.Void Initiate(UnityEngine.Transform root) { }
        // RVA: 0x0258A6B0  token: 0x6000445
        public System.Void LookAt(UnityEngine.Vector3 direction, System.Single weight) { }
        // RVA: 0x0962F5D8  token: 0x6000446
        public UnityEngine.Quaternion LookAtReturnRotation(UnityEngine.Vector3 direction, System.Single weight) { }

    }

    // TypeToken: 0x200007F  // size: 0xA0
    public class TrigonometricBone : Bone
    {
        // Fields
        private UnityEngine.Quaternion targetToLocalSpace;  // 0x80
        private UnityEngine.Vector3 defaultLocalBendNormal;  // 0x90

        // Methods
        // RVA: 0x02B22AD0  token: 0x600045F
        public System.Void Initiate(UnityEngine.Vector3 childPosition, UnityEngine.Vector3 bendNormal) { }
        // RVA: 0x0258A520  token: 0x6000460
        public UnityEngine.Quaternion GetRotation(UnityEngine.Vector3 direction, UnityEngine.Vector3 bendNormal) { }
        // RVA: 0x0238EAC0  token: 0x6000461
        public UnityEngine.Vector3 GetBendNormalFromCurrentRotation() { }
        // RVA: 0x042726F4  token: 0x6000462
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000082  // size: 0x14
    public sealed struct ShoulderRotationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationMode YawPitch;  // const
        public static RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationMode FromTo;  // const

    }

    // TypeToken: 0x2000081  // size: 0x158
    public class Arm : BodyPart
    {
        // Fields
        public UnityEngine.Transform target;  // 0x48
        public System.Single positionWeight;  // 0x50
        public System.Single rotationWeight;  // 0x54
        public System.Single shoulderRotationWeight;  // 0x58
        public RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode;  // 0x5c
        public System.Single shoulderTwistWeight;  // 0x60
        public System.Single shoulderYawOffset;  // 0x64
        public System.Single shoulderPitchOffset;  // 0x68
        public UnityEngine.Transform bendGoal;  // 0x70
        public System.Single bendGoalWeight;  // 0x78
        public System.Single swivelOffset;  // 0x7c
        public UnityEngine.Vector3 wristToPalmAxis;  // 0x80
        public UnityEngine.Vector3 palmToThumbAxis;  // 0x8c
        public System.Single armLengthMlp;  // 0x98
        public UnityEngine.AnimationCurve stretchCurve;  // 0xa0
        public UnityEngine.Vector3 IKPosition;  // 0xa8
        public UnityEngine.Quaternion IKRotation;  // 0xb4
        public UnityEngine.Vector3 bendDirection;  // 0xc4
        public UnityEngine.Vector3 handPositionOffset;  // 0xd0
        private UnityEngine.Vector3 <position>k__BackingField;  // 0xdc
        private UnityEngine.Quaternion <rotation>k__BackingField;  // 0xe8
        private System.Boolean hasShoulder;  // 0xf8
        private UnityEngine.Vector3 chestForwardAxis;  // 0xfc
        private UnityEngine.Vector3 chestUpAxis;  // 0x108
        private UnityEngine.Quaternion chestRotation;  // 0x114
        private UnityEngine.Vector3 chestForward;  // 0x124
        private UnityEngine.Vector3 chestUp;  // 0x130
        private UnityEngine.Quaternion forearmRelToUpperArm;  // 0x13c
        private UnityEngine.Vector3 upperArmBendAxis;  // 0x14c

        // Properties
        UnityEngine.Vector3 position { get; /* RVA: 0x03D74B10 */ set; /* RVA: 0x03D74B30 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x03D6B980 */ set; /* RVA: 0x03D74B50 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone shoulder { get; /* RVA: 0x09632D88 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone upperArm { get; /* RVA: 0x09632DB0 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone forearm { get; /* RVA: 0x09632CF0 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone hand { get; /* RVA: 0x09632D3C */ }

        // Methods
        // RVA: 0x0962FDD0  token: 0x6000489
        protected virtual System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        // RVA: 0x096307D0  token: 0x600048A
        public virtual System.Void PreSolve(System.Single scale) { }
        // RVA: 0x0962F6D4  token: 0x600048B
        public virtual System.Void ApplyOffsets(System.Single scale) { }
        // RVA: 0x096323A0  token: 0x600048C
        private System.Void Stretching() { }
        // RVA: 0x09630A18  token: 0x600048D
        public System.Void Solve(System.Boolean isLeft) { }
        // RVA: 0x096309FC  token: 0x600048E
        public virtual System.Void ResetOffsets() { }
        // RVA: 0x09632978  token: 0x600048F
        public virtual System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        // RVA: 0x0962F73C  token: 0x6000490
        private System.Single DamperValue(System.Single value, System.Single min, System.Single max, System.Single weight) { }
        // RVA: 0x0962F7E4  token: 0x6000491
        private UnityEngine.Vector3 GetBendNormal(UnityEngine.Vector3 dir) { }
        // RVA: 0x09632860  token: 0x6000492
        private System.Void Visualize(RootMotion.FinalIK.IKSolverVR.VirtualBone bone1, RootMotion.FinalIK.IKSolverVR.VirtualBone bone2, RootMotion.FinalIK.IKSolverVR.VirtualBone bone3, UnityEngine.Color color) { }
        // RVA: 0x09632BB8  token: 0x6000493
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x48
    public abstract class BodyPart
    {
        // Fields
        private System.Single <sqrMag>k__BackingField;  // 0x10
        private System.Single <mag>k__BackingField;  // 0x14
        public RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones;  // 0x18
        protected System.Boolean initiated;  // 0x20
        protected UnityEngine.Vector3 rootPosition;  // 0x24
        protected UnityEngine.Quaternion rootRotation;  // 0x30
        protected System.Int32 index;  // 0x40
        protected System.Int32 LOD;  // 0x44

        // Properties
        System.Single sqrMag { get; /* RVA: 0x03D4E7A0 */ set; /* RVA: 0x03D50CA0 */ }
        System.Single mag { get; /* RVA: 0x03D51930 */ set; /* RVA: 0x03D51940 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000494
        protected virtual System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x6000495
        public virtual System.Void PreSolve(System.Single scale) { }
        // RVA: -1  // abstract  token: 0x6000496
        public virtual System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        // RVA: -1  // abstract  token: 0x6000497
        public virtual System.Void ApplyOffsets(System.Single scale) { }
        // RVA: -1  // abstract  token: 0x6000498
        public virtual System.Void ResetOffsets() { }
        // RVA: 0x03D4EEA0  token: 0x600049D
        public System.Void SetLOD(System.Int32 LOD) { }
        // RVA: 0x09632F98  token: 0x600049E
        public System.Void Read(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        // RVA: 0x09632DF8  token: 0x600049F
        public System.Void MovePosition(UnityEngine.Vector3 position) { }
        // RVA: 0x09632EDC  token: 0x60004A0
        public System.Void MoveRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x0963331C  token: 0x60004A1
        public System.Void Translate(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x096331C0  token: 0x60004A2
        public System.Void TranslateRoot(UnityEngine.Vector3 newRootPos, UnityEngine.Quaternion newRootRot) { }
        // RVA: 0x096330A0  token: 0x60004A3
        public System.Void RotateTo(RootMotion.FinalIK.IKSolverVR.VirtualBone bone, UnityEngine.Quaternion rotation, System.Single weight) { }
        // RVA: 0x09633370  token: 0x60004A4
        public System.Void Visualize(UnityEngine.Color color) { }
        // RVA: 0x09633488  token: 0x60004A5
        public System.Void Visualize() { }
        // RVA: 0x096334B8  token: 0x60004A6
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000084  // size: 0xA8
    public class Footstep
    {
        // Fields
        public System.Single stepSpeed;  // 0x10
        public UnityEngine.Vector3 characterSpaceOffset;  // 0x14
        public UnityEngine.Vector3 position;  // 0x20
        public UnityEngine.Quaternion rotation;  // 0x2c
        public UnityEngine.Quaternion stepToRootRot;  // 0x3c
        public System.Boolean isSupportLeg;  // 0x4c
        public System.Boolean relaxFlag;  // 0x4d
        private System.Single <stepProgress>k__BackingField;  // 0x50
        public UnityEngine.Vector3 stepFrom;  // 0x54
        public UnityEngine.Vector3 stepTo;  // 0x60
        public UnityEngine.Quaternion stepFromRot;  // 0x6c
        public UnityEngine.Quaternion stepToRot;  // 0x7c
        private UnityEngine.Quaternion footRelativeToRoot;  // 0x8c
        private System.Single supportLegW;  // 0x9c
        private System.Single supportLegWV;  // 0xa0

        // Properties
        System.Boolean isStepping { get; /* RVA: 0x09633AC4 */ }
        System.Single stepProgress { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x03D51CA0 */ }

        // Methods
        // RVA: 0x096339A0  token: 0x60004AA
        public System.Void .ctor(UnityEngine.Quaternion rootRotation, UnityEngine.Vector3 footPosition, UnityEngine.Quaternion footRotation, UnityEngine.Vector3 characterSpaceOffset) { }
        // RVA: 0x03D74B60  token: 0x60004AB
        public System.Void Reset(UnityEngine.Quaternion rootRotation, UnityEngine.Vector3 footPosition, UnityEngine.Quaternion footRotation) { }
        // RVA: 0x09633518  token: 0x60004AC
        public System.Void StepTo(UnityEngine.Vector3 p, UnityEngine.Quaternion rootRotation, System.Single stepThreshold) { }
        // RVA: 0x09633738  token: 0x60004AD
        public System.Void UpdateStepping(UnityEngine.Vector3 p, UnityEngine.Quaternion rootRotation, System.Single speed, System.Single deltaTime) { }
        // RVA: 0x09633640  token: 0x60004AE
        public System.Void UpdateStanding(UnityEngine.Quaternion rootRotation, System.Single minAngle, System.Single speed, System.Single deltaTime) { }
        // RVA: 0x0963384C  token: 0x60004AF
        public System.Void Update(RootMotion.InterpolationMode interpolation, UnityEngine.Events.UnityEvent onStep, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000085  // size: 0x150
    public class Leg : BodyPart
    {
        // Fields
        public UnityEngine.Transform target;  // 0x48
        public System.Single positionWeight;  // 0x50
        public System.Single rotationWeight;  // 0x54
        public UnityEngine.Transform bendGoal;  // 0x58
        public System.Single bendGoalWeight;  // 0x60
        public System.Single swivelOffset;  // 0x64
        public System.Single bendToTargetWeight;  // 0x68
        public System.Single legLengthMlp;  // 0x6c
        public UnityEngine.AnimationCurve stretchCurve;  // 0x70
        public UnityEngine.Vector3 IKPosition;  // 0x78
        public UnityEngine.Quaternion IKRotation;  // 0x84
        public UnityEngine.Vector3 footPositionOffset;  // 0x94
        public UnityEngine.Vector3 heelPositionOffset;  // 0xa0
        public UnityEngine.Quaternion footRotationOffset;  // 0xac
        public System.Single currentMag;  // 0xbc
        public System.Boolean useAnimatedBendNormal;  // 0xc0
        private UnityEngine.Vector3 <position>k__BackingField;  // 0xc4
        private UnityEngine.Quaternion <rotation>k__BackingField;  // 0xd0
        private System.Boolean <hasToes>k__BackingField;  // 0xe0
        private UnityEngine.Vector3 <thighRelativeToPelvis>k__BackingField;  // 0xe4
        private UnityEngine.Vector3 footPosition;  // 0xf0
        private UnityEngine.Quaternion footRotation;  // 0xfc
        private UnityEngine.Vector3 bendNormal;  // 0x10c
        private UnityEngine.Quaternion calfRelToThigh;  // 0x118
        private UnityEngine.Quaternion thighRelToFoot;  // 0x128
        private UnityEngine.Vector3 <bendNormalRelToPelvis>k__BackingField;  // 0x138
        private UnityEngine.Vector3 <bendNormalRelToTarget>k__BackingField;  // 0x144

        // Properties
        UnityEngine.Vector3 position { get; /* RVA: 0x03D5B430 */ set; /* RVA: 0x03D69480 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x03D5B210 */ set; /* RVA: 0x03D5B220 */ }
        System.Boolean hasToes { get; /* RVA: 0x03D58140 */ set; /* RVA: 0x03D59200 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone thigh { get; /* RVA: 0x09632D88 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone calf { get; /* RVA: 0x06E95EB4 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone foot { get; /* RVA: 0x09637FE4 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone toes { get; /* RVA: 0x0963803C */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone lastBone { get; /* RVA: 0x0963800C */ }
        UnityEngine.Vector3 thighRelativeToPelvis { get; /* RVA: 0x03D74AA0 */ set; /* RVA: 0x03D74AC0 */ }
        UnityEngine.Vector3 bendNormalRelToPelvis { get; /* RVA: 0x03D74BB0 */ set; /* RVA: 0x03D74BF0 */ }
        UnityEngine.Vector3 bendNormalRelToTarget { get; /* RVA: 0x03D74BD0 */ set; /* RVA: 0x03D74C10 */ }

        // Methods
        // RVA: 0x096365FC  token: 0x60004C1
        protected virtual System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        // RVA: 0x09636E38  token: 0x60004C2
        public virtual System.Void PreSolve(System.Single scale) { }
        // RVA: 0x09635988  token: 0x60004C3
        public virtual System.Void ApplyOffsets(System.Single scale) { }
        // RVA: 0x09635FCC  token: 0x60004C4
        private System.Void ApplyPositionOffset(UnityEngine.Vector3 offset, System.Single weight) { }
        // RVA: 0x096360B4  token: 0x60004C5
        private System.Void ApplyRotationOffset(UnityEngine.Quaternion offset, System.Single weight) { }
        // RVA: 0x09637474  token: 0x60004C6
        public System.Void Solve(System.Boolean stretch) { }
        // RVA: 0x0963628C  token: 0x60004C7
        private System.Void FixTwistRotations() { }
        // RVA: 0x096376FC  token: 0x60004C8
        private System.Void Stretching() { }
        // RVA: 0x09637CB4  token: 0x60004C9
        public virtual System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        // RVA: 0x0963740C  token: 0x60004CA
        public virtual System.Void ResetOffsets() { }
        // RVA: 0x09637EF8  token: 0x60004CB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000087  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.IKSolverVR.Locomotion.Mode Procedural;  // const
        public static RootMotion.FinalIK.IKSolverVR.Locomotion.Mode Animated;  // const

    }

    // TypeToken: 0x2000086  // size: 0x180
    public class Locomotion
    {
        // Fields
        public RootMotion.FinalIK.IKSolverVR.Locomotion.Mode mode;  // 0x10
        public System.Single weight;  // 0x14
        public System.Single moveThreshold;  // 0x18
        private System.Byte animationHeader;  // 0x1c
        public System.Single minAnimationSpeed;  // 0x20
        public System.Single maxAnimationSpeed;  // 0x24
        public System.Single animationSmoothTime;  // 0x28
        private System.Byte rootPositionHeader;  // 0x2c
        public UnityEngine.Vector2 standOffset;  // 0x30
        public System.Single rootLerpSpeedWhileMoving;  // 0x38
        public System.Single rootLerpSpeedWhileStopping;  // 0x3c
        public System.Single rootLerpSpeedWhileTurning;  // 0x40
        public System.Single maxRootOffset;  // 0x44
        private System.Byte rootRotationHeader;  // 0x48
        public System.Single maxRootAngleMoving;  // 0x4c
        public System.Single maxRootAngleStanding;  // 0x50
        public System.Single stepLengthMlp;  // 0x54
        private UnityEngine.Animator animator;  // 0x58
        private UnityEngine.Vector3 velocityLocal;  // 0x60
        private UnityEngine.Vector3 velocityLocalV;  // 0x6c
        private UnityEngine.Vector3 lastCorrection;  // 0x78
        private UnityEngine.Vector3 lastHeadTargetPos;  // 0x84
        private UnityEngine.Vector3 lastSpeedRootPos;  // 0x90
        private UnityEngine.Vector3 lastEndRootPos;  // 0x9c
        private System.Single rootLerpSpeed;  // 0xa8
        private System.Single rootVelocityV;  // 0xac
        private System.Single animSpeed;  // 0xb0
        private System.Single animSpeedV;  // 0xb4
        private System.Single stopMoveTimer;  // 0xb8
        private System.Single turn;  // 0xbc
        private System.Single maxRootAngleV;  // 0xc0
        private System.Single currentAnimationSmoothTime;  // 0xc4
        private System.Boolean isMoving;  // 0xc8
        private System.Boolean firstFrame;  // 0xc9
        private static System.Int32 VRIK_Horizontal;  // static @ 0x0
        private static System.Int32 VRIK_Vertical;  // static @ 0x4
        private static System.Int32 VRIK_IsMoving;  // static @ 0x8
        private static System.Int32 VRIK_Speed;  // static @ 0xc
        private static System.Int32 VRIK_Turn;  // static @ 0x10
        private static System.Boolean isHashed;  // static @ 0x14
        private System.Single lastVelLocalMag;  // 0xcc
        public System.Single footDistance;  // 0xd0
        public System.Single stepThreshold;  // 0xd4
        public System.Single angleThreshold;  // 0xd8
        public System.Single comAngleMlp;  // 0xdc
        public System.Single maxVelocity;  // 0xe0
        public System.Single velocityFactor;  // 0xe4
        public System.Single maxLegStretch;  // 0xe8
        public System.Single rootSpeed;  // 0xec
        public System.Single stepSpeed;  // 0xf0
        public UnityEngine.AnimationCurve stepHeight;  // 0xf8
        public System.Single maxBodyYOffset;  // 0x100
        public UnityEngine.AnimationCurve heelHeight;  // 0x108
        public System.Single relaxLegTwistMinAngle;  // 0x110
        public System.Single relaxLegTwistSpeed;  // 0x114
        public RootMotion.InterpolationMode stepInterpolation;  // 0x118
        public UnityEngine.Vector3 offset;  // 0x11c
        public System.Boolean blockingEnabled;  // 0x128
        public UnityEngine.LayerMask blockingLayers;  // 0x12c
        public System.Single raycastRadius;  // 0x130
        public System.Single raycastHeight;  // 0x134
        public UnityEngine.Events.UnityEvent onLeftFootstep;  // 0x138
        public UnityEngine.Events.UnityEvent onRightFootstep;  // 0x140
        private UnityEngine.Vector3 <centerOfMass>k__BackingField;  // 0x148
        private RootMotion.FinalIK.IKSolverVR.Footstep[] footsteps;  // 0x158
        private UnityEngine.Vector3 lastComPosition;  // 0x160
        private UnityEngine.Vector3 comVelocity;  // 0x16c
        private System.Int32 leftFootIndex;  // 0x178
        private System.Int32 rightFootIndex;  // 0x17c

        // Properties
        UnityEngine.Vector3 centerOfMass { get; /* RVA: 0x03D5B7F0 */ set; /* RVA: 0x03D5B8B0 */ }
        UnityEngine.Vector3 leftFootstepPosition { get; /* RVA: 0x0963C298 */ }
        UnityEngine.Vector3 rightFootstepPosition { get; /* RVA: 0x0963C31C */ }
        UnityEngine.Quaternion leftFootstepRotation { get; /* RVA: 0x0963C2DC */ }
        UnityEngine.Quaternion rightFootstepRotation { get; /* RVA: 0x0963C360 */ }

        // Methods
        // RVA: 0x09638F7C  token: 0x60004CC
        public System.Void Initiate(UnityEngine.Animator animator, UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasToes, System.Single scale) { }
        // RVA: 0x096395E4  token: 0x60004CD
        public System.Void Reset(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations) { }
        // RVA: 0x09639030  token: 0x60004CE
        public System.Void Relax() { }
        // RVA: 0x09638988  token: 0x60004CF
        public System.Void AddDeltaRotation(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot) { }
        // RVA: 0x096382F0  token: 0x60004D0
        public System.Void AddDeltaPosition(UnityEngine.Vector3 delta) { }
        // RVA: 0x09638BFC  token: 0x60004D1
        public System.Void Initiate_Animated(UnityEngine.Animator animator, UnityEngine.Vector3[] positions) { }
        // RVA: 0x09639038  token: 0x60004D2
        private System.Void ResetParams(UnityEngine.Vector3[] positions) { }
        // RVA: 0x096390F8  token: 0x60004D3
        public System.Void Reset_Animated(UnityEngine.Vector3[] positions) { }
        // RVA: 0x0963834C  token: 0x60004D4
        private System.Void AddDeltaRotation_Animated(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot) { }
        // RVA: 0x09638064  token: 0x60004D5
        private System.Void AddDeltaPosition_Animated(UnityEngine.Vector3 delta) { }
        // RVA: 0x09639614  token: 0x60004D6
        public System.Void Solve_Animated(RootMotion.FinalIK.IKSolverVR solver, System.Single scale, System.Single deltaTime) { }
        // RVA: 0x09638CB0  token: 0x60004D9
        private System.Void Initiate_Procedural(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasToes, System.Single scale) { }
        // RVA: 0x09639348  token: 0x60004DA
        private System.Void Reset_Procedural(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations) { }
        // RVA: 0x09638FDC  token: 0x60004DB
        private System.Void Relax_Procedural() { }
        // RVA: 0x09638574  token: 0x60004DC
        private System.Void AddDeltaRotation_Procedural(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot) { }
        // RVA: 0x09638168  token: 0x60004DD
        private System.Void AddDeltaPosition_Procedural(UnityEngine.Vector3 delta) { }
        // RVA: 0x0963A620  token: 0x60004DE
        public System.Void Solve_Procedural(RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Spine spine, RootMotion.FinalIK.IKSolverVR.Leg leftLeg, RootMotion.FinalIK.IKSolverVR.Leg rightLeg, RootMotion.FinalIK.IKSolverVR.Arm leftArm, RootMotion.FinalIK.IKSolverVR.Arm rightArm, System.Int32 supportLegIndex, UnityEngine.Vector3& leftFootPosition, UnityEngine.Vector3& rightFootPosition, UnityEngine.Quaternion& leftFootRotation, UnityEngine.Quaternion& rightFootRotation, System.Single& leftFootOffset, System.Single& rightFootOffset, System.Single& leftHeelOffset, System.Single& rightHeelOffset, System.Single scale, System.Single deltaTime) { }
        // RVA: 0x0963BF60  token: 0x60004E3
        private System.Boolean StepBlocked(UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 toPosition, UnityEngine.Vector3 rootPosition) { }
        // RVA: 0x09638A0C  token: 0x60004E4
        private System.Boolean CanStep() { }
        // RVA: 0x09638A6C  token: 0x60004E5
        private static System.Boolean GetLineSphereCollision(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 sphereCenter, System.Single sphereRadius) { }
        // RVA: 0x0963C0EC  token: 0x60004E6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x230
    public class Spine : BodyPart
    {
        // Fields
        public UnityEngine.Transform headTarget;  // 0x48
        public System.Single positionWeight;  // 0x50
        public System.Single rotationWeight;  // 0x54
        public System.Single headClampWeight;  // 0x58
        public System.Single minHeadHeight;  // 0x5c
        public System.Single useAnimatedHeadHeightWeight;  // 0x60
        public System.Single useAnimatedHeadHeightRange;  // 0x64
        public System.Single animatedHeadHeightBlend;  // 0x68
        public UnityEngine.Transform pelvisTarget;  // 0x70
        public System.Single pelvisPositionWeight;  // 0x78
        public System.Single pelvisRotationWeight;  // 0x7c
        public System.Single maintainPelvisPosition;  // 0x80
        public UnityEngine.Transform chestGoal;  // 0x88
        public System.Single chestGoalWeight;  // 0x90
        public System.Single chestClampWeight;  // 0x94
        public System.Single rotateChestByHands;  // 0x98
        public System.Single bodyPosStiffness;  // 0x9c
        public System.Single bodyRotStiffness;  // 0xa0
        public System.Single neckStiffness;  // 0xa4
        public System.Single moveBodyBackWhenCrouching;  // 0xa8
        public System.Single maxRootAngle;  // 0xac
        public System.Single rootHeadingOffset;  // 0xb0
        public UnityEngine.Vector3 IKPositionHead;  // 0xb4
        public UnityEngine.Quaternion IKRotationHead;  // 0xc0
        public UnityEngine.Vector3 IKPositionPelvis;  // 0xd0
        public UnityEngine.Quaternion IKRotationPelvis;  // 0xdc
        public UnityEngine.Vector3 goalPositionChest;  // 0xec
        public UnityEngine.Vector3 pelvisPositionOffset;  // 0xf8
        public UnityEngine.Vector3 chestPositionOffset;  // 0x104
        public UnityEngine.Vector3 headPositionOffset;  // 0x110
        public UnityEngine.Quaternion pelvisRotationOffset;  // 0x11c
        public UnityEngine.Quaternion chestRotationOffset;  // 0x12c
        public UnityEngine.Quaternion headRotationOffset;  // 0x13c
        public UnityEngine.Vector3 faceDirection;  // 0x14c
        private UnityEngine.Vector3 headPosition;  // 0x158
        private UnityEngine.Quaternion <anchorRotation>k__BackingField;  // 0x164
        private UnityEngine.Quaternion <anchorRelativeToHead>k__BackingField;  // 0x174
        private UnityEngine.Quaternion headRotation;  // 0x184
        private UnityEngine.Quaternion pelvisRotation;  // 0x194
        private UnityEngine.Quaternion anchorRelativeToPelvis;  // 0x1a4
        private UnityEngine.Quaternion pelvisRelativeRotation;  // 0x1b4
        private UnityEngine.Quaternion chestRelativeRotation;  // 0x1c4
        private UnityEngine.Vector3 headDeltaPosition;  // 0x1d4
        private UnityEngine.Quaternion pelvisDeltaRotation;  // 0x1e0
        private UnityEngine.Quaternion chestTargetRotation;  // 0x1f0
        private System.Int32 pelvisIndex;  // 0x200
        private System.Int32 spineIndex;  // 0x204
        private System.Int32 chestIndex;  // 0x208
        private System.Int32 neckIndex;  // 0x20c
        private System.Int32 headIndex;  // 0x210
        private System.Single length;  // 0x214
        private System.Boolean hasChest;  // 0x218
        private System.Boolean hasNeck;  // 0x219
        private System.Boolean hasLegs;  // 0x21a
        private System.Single headHeight;  // 0x21c
        private System.Single sizeMlp;  // 0x220
        private UnityEngine.Vector3 chestForward;  // 0x224

        // Properties
        RootMotion.FinalIK.IKSolverVR.VirtualBone pelvis { get; /* RVA: 0x0963FEC4 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone firstSpineBone { get; /* RVA: 0x0963FE34 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone chest { get; /* RVA: 0x0963FDF0 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone head { get; /* RVA: 0x0963FE64 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone neck { get; /* RVA: 0x0963FE94 */ }
        UnityEngine.Quaternion anchorRotation { get; /* RVA: 0x03D74C40 */ set; /* RVA: 0x03D74C60 */ }
        UnityEngine.Quaternion anchorRelativeToHead { get; /* RVA: 0x03D74C30 */ set; /* RVA: 0x03D74C50 */ }

        // Methods
        // RVA: 0x0963DA38  token: 0x60004F0
        protected virtual System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        // RVA: 0x0963E5A0  token: 0x60004F1
        public virtual System.Void PreSolve(System.Single scale) { }
        // RVA: 0x0963C778  token: 0x60004F2
        public virtual System.Void ApplyOffsets(System.Single scale) { }
        // RVA: 0x0963D160  token: 0x60004F3
        private System.Void CalculateChestTargetRotation(RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Arm[] arms) { }
        // RVA: 0x0963EEB8  token: 0x60004F4
        public System.Void Solve(UnityEngine.Animator animator, RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Leg[] legs, RootMotion.FinalIK.IKSolverVR.Arm[] arms, System.Single scale) { }
        // RVA: 0x0963D328  token: 0x60004F5
        private System.Void FABRIKPass(UnityEngine.Vector3 animatedPelvisPos, UnityEngine.Vector3 rootUp, System.Single weight) { }
        // RVA: 0x0963EBA0  token: 0x60004F6
        private System.Void SolvePelvis() { }
        // RVA: 0x0963FA28  token: 0x60004F7
        public virtual System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        // RVA: 0x0963EAEC  token: 0x60004F8
        public virtual System.Void ResetOffsets() { }
        // RVA: 0x0963C3A0  token: 0x60004F9
        private System.Void AdjustChestByHands(UnityEngine.Quaternion& chestTargetRotation, RootMotion.FinalIK.IKSolverVR.Arm[] arms) { }
        // RVA: 0x0963D54C  token: 0x60004FA
        public System.Void InverseTranslateToHead(RootMotion.FinalIK.IKSolverVR.Leg[] legs, System.Boolean limited, System.Boolean useCurrentLegMag, UnityEngine.Vector3 offset, System.Single w) { }
        // RVA: 0x0963F5C8  token: 0x60004FB
        private System.Void TranslatePelvis(RootMotion.FinalIK.IKSolverVR.Leg[] legs, UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation, System.Single scale) { }
        // RVA: 0x0963D6DC  token: 0x60004FC
        private UnityEngine.Vector3 LimitPelvisPosition(RootMotion.FinalIK.IKSolverVR.Leg[] legs, UnityEngine.Vector3 pelvisPosition, System.Boolean useCurrentLegMag, System.Int32 it) { }
        // RVA: 0x0963CCDC  token: 0x60004FD
        private System.Void Bend(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 firstIndex, System.Int32 lastIndex, UnityEngine.Quaternion targetRotation, System.Single clampWeight, System.Boolean uniformWeight, System.Single w) { }
        // RVA: 0x0963CEF0  token: 0x60004FE
        private System.Void Bend(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 firstIndex, System.Int32 lastIndex, UnityEngine.Quaternion targetRotation, UnityEngine.Quaternion rotationOffset, System.Single clampWeight, System.Boolean uniformWeight, System.Single w) { }
        // RVA: 0x0963FC34  token: 0x60004FF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000089  // size: 0x14
    public sealed struct PositionOffset
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset Pelvis;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset Chest;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset Head;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset LeftHand;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset RightHand;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset LeftFoot;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset RightFoot;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset LeftHeel;  // const
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset RightHeel;  // const

    }

    // TypeToken: 0x200008A  // size: 0x14
    public sealed struct RotationOffset
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.IKSolverVR.RotationOffset Pelvis;  // const
        public static RootMotion.FinalIK.IKSolverVR.RotationOffset Chest;  // const
        public static RootMotion.FinalIK.IKSolverVR.RotationOffset Head;  // const

    }

    // TypeToken: 0x200008B  // size: 0x60
    public class VirtualBone
    {
        // Fields
        public UnityEngine.Vector3 readPosition;  // 0x10
        public UnityEngine.Quaternion readRotation;  // 0x1c
        public UnityEngine.Vector3 solverPosition;  // 0x2c
        public UnityEngine.Quaternion solverRotation;  // 0x38
        public System.Single length;  // 0x48
        public System.Single sqrMag;  // 0x4c
        public UnityEngine.Vector3 axis;  // 0x50

        // Methods
        // RVA: 0x03D74C70  token: 0x6000500
        public System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x03D74C70  token: 0x6000501
        public System.Void Read(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x0964261C  token: 0x6000502
        public static System.Void SwingRotation(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Vector3 swingTarget, System.Single weight) { }
        // RVA: 0x09641108  token: 0x6000503
        public static System.Single PreSolve(RootMotion.FinalIK.IKSolverVR.VirtualBone[]& bones) { }
        // RVA: 0x096413C0  token: 0x6000504
        public static System.Void RotateAroundPoint(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Vector3 point, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09641544  token: 0x6000505
        public static System.Void RotateBy(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09641704  token: 0x6000506
        public static System.Void RotateBy(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Quaternion rotation) { }
        // RVA: 0x096418BC  token: 0x6000507
        public static System.Void RotateTo(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Quaternion rotation) { }
        // RVA: 0x096420D4  token: 0x6000508
        public static System.Void SolveTrigonometric(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 first, System.Int32 second, System.Int32 third, UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 bendNormal, System.Single weight) { }
        // RVA: 0x09640F4C  token: 0x6000509
        private static UnityEngine.Vector3 GetDirectionToBendPoint(UnityEngine.Vector3 direction, System.Single directionMag, UnityEngine.Vector3 bendDirection, System.Single sqrMag1, System.Single sqrMag2) { }
        // RVA: 0x09641C44  token: 0x600050A
        public static System.Void SolveFABRIK(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 targetPosition, System.Single weight, System.Single minNormalizedTargetDistance, System.Int32 iterations, System.Single length, UnityEngine.Vector3 startOffset) { }
        // RVA: 0x09641B60  token: 0x600050B
        private static UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        // RVA: 0x09641970  token: 0x600050C
        public static System.Void SolveCCD(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Vector3 targetPosition, System.Single weight, System.Int32 iterations) { }

    }

    // TypeToken: 0x2000091  // size: 0x30
    public class InteractionEvent
    {
        // Fields
        public System.Single time;  // 0x10
        public System.Boolean pause;  // 0x14
        public System.Boolean pickUp;  // 0x15
        public RootMotion.FinalIK.InteractionObject.AnimatorEvent[] animations;  // 0x18
        public RootMotion.FinalIK.InteractionObject.Message[] messages;  // 0x20
        public UnityEngine.Events.UnityEvent unityEvent;  // 0x28

        // Methods
        // RVA: 0x096483A4  token: 0x600054E
        public System.Void Activate(UnityEngine.Transform t) { }
        // RVA: 0x0350B670  token: 0x600054F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000092  // size: 0x20
    public class Message
    {
        // Fields
        public System.String function;  // 0x10
        public UnityEngine.GameObject recipient;  // 0x18
        private static System.String empty;  // const

        // Methods
        // RVA: 0x0964F1C4  token: 0x6000550
        public System.Void Send(UnityEngine.Transform t) { }
        // RVA: 0x0350B670  token: 0x6000551
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000093  // size: 0x38
    public class AnimatorEvent
    {
        // Fields
        public UnityEngine.Animator animator;  // 0x10
        public UnityEngine.Animation animation;  // 0x18
        public System.String animationState;  // 0x20
        public System.Single crossfadeTime;  // 0x28
        public System.Int32 layer;  // 0x2c
        public System.Boolean resetNormalizedTime;  // 0x30
        private static System.String empty;  // const

        // Methods
        // RVA: 0x09643BA8  token: 0x6000552
        public System.Void Activate(System.Boolean pickUp) { }
        // RVA: 0x09643C68  token: 0x6000553
        private System.Void Activate(UnityEngine.Animator animator) { }
        // RVA: 0x09643AEC  token: 0x6000554
        private System.Void Activate(UnityEngine.Animation animation) { }
        // RVA: 0x03D74CA0  token: 0x6000555
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000095  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionWeight;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type RotationWeight;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionOffsetX;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionOffsetY;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionOffsetZ;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type Pull;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type Reach;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type RotateBoneWeight;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type Push;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PushParent;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PoserWeight;  // const
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type BendGoalWeight;  // const

    }

    // TypeToken: 0x2000094  // size: 0x20
    public class WeightCurve
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type type;  // 0x10
        public UnityEngine.AnimationCurve curve;  // 0x18

        // Methods
        // RVA: 0x096546E0  token: 0x6000556
        public System.Single GetValue(System.Single timer) { }
        // RVA: 0x0350B670  token: 0x6000557
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000096  // size: 0x20
    public class Multiplier
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type curve;  // 0x10
        public System.Single multiplier;  // 0x14
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type result;  // 0x18

        // Methods
        // RVA: 0x0964F29C  token: 0x6000558
        public System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve weightCurve, System.Single timer) { }
        // RVA: 0x03D58F50  token: 0x6000559
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000098  // size: 0x80
    public sealed class InteractionDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BD450  token: 0x6000598
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000599
        public virtual System.Void Invoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject) { }
        // RVA: 0x0964829C  token: 0x600059A
        public virtual System.IAsyncResult BeginInvoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600059B
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000099  // size: 0x80
    public sealed class InteractionEventDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x08077564  token: 0x600059C
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x600059D
        public virtual System.Void Invoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionObject.InteractionEvent interactionEvent) { }
        // RVA: 0x0964831C  token: 0x600059E
        public virtual System.IAsyncResult BeginInvoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionObject.InteractionEvent interactionEvent, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600059F
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200009B  // size: 0x14
    public sealed struct RotationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.InteractionTarget.RotationMode TwoDOF;  // const
        public static RootMotion.FinalIK.InteractionTarget.RotationMode ThreeDOF;  // const

    }

    // TypeToken: 0x200009C  // size: 0x18
    public class Multiplier
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type curve;  // 0x10
        public System.Single multiplier;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x60005AC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009E  // size: 0x30
    public class CharacterPosition
    {
        // Fields
        public System.Boolean use;  // 0x10
        public UnityEngine.Vector2 offset;  // 0x14
        public System.Single angleOffset;  // 0x1c
        public System.Single maxAngle;  // 0x20
        public System.Single radius;  // 0x24
        public System.Boolean orbit;  // 0x28
        public System.Boolean fixYAxis;  // 0x29

        // Properties
        UnityEngine.Vector3 offset3D { get; /* RVA: 0x03D74D50 */ }
        UnityEngine.Vector3 direction3D { get; /* RVA: 0x09645990 */ }

        // Methods
        // RVA: 0x09645348  token: 0x60005B6
        public System.Boolean IsInRange(UnityEngine.Transform character, UnityEngine.Transform trigger, System.Single& error) { }
        // RVA: 0x03D74D40  token: 0x60005B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009F  // size: 0x30
    public class CameraPosition
    {
        // Fields
        public UnityEngine.Collider lookAtTarget;  // 0x10
        public UnityEngine.Vector3 direction;  // 0x18
        public System.Single maxDistance;  // 0x24
        public System.Single maxAngle;  // 0x28
        public System.Boolean fixYAxis;  // 0x2c

        // Methods
        // RVA: 0x09644EF4  token: 0x60005B8
        public UnityEngine.Quaternion GetRotation() { }
        // RVA: 0x09645054  token: 0x60005B9
        public System.Boolean IsInRange(UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit hit, UnityEngine.Transform trigger, System.Single& error) { }
        // RVA: 0x096452F0  token: 0x60005BA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1  // size: 0x20
    public class Interaction
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject interactionObject;  // 0x10
        public RootMotion.FinalIK.FullBodyBipedEffector[] effectors;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60005BD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0  // size: 0x38
    public class Range
    {
        // Fields
        public System.String name;  // 0x10
        public System.Boolean show;  // 0x18
        public RootMotion.FinalIK.InteractionTrigger.CharacterPosition characterPosition;  // 0x20
        public RootMotion.FinalIK.InteractionTrigger.CameraPosition cameraPosition;  // 0x28
        public RootMotion.FinalIK.InteractionTrigger.Range.Interaction[] interactions;  // 0x30

        // Methods
        // RVA: 0x09650A40  token: 0x60005BB
        public System.Boolean IsInRange(UnityEngine.Transform character, UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit raycastHit, UnityEngine.Transform trigger, System.Single& maxError) { }
        // RVA: 0x03D587A0  token: 0x60005BC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3  // size: 0x40
    public class Map
    {
        // Fields
        public UnityEngine.Transform bone;  // 0x10
        public UnityEngine.Transform target;  // 0x18
        private UnityEngine.Vector3 defaultLocalPosition;  // 0x20
        private UnityEngine.Quaternion defaultLocalRotation;  // 0x2c

        // Methods
        // RVA: 0x0964F190  token: 0x60005C5
        public System.Void .ctor(UnityEngine.Transform bone, UnityEngine.Transform target) { }
        // RVA: 0x0960E1B8  token: 0x60005C6
        public System.Void StoreDefaultState() { }
        // RVA: 0x0964EFD4  token: 0x60005C7
        public System.Void FixTransform() { }
        // RVA: 0x0964F034  token: 0x60005C8
        public System.Void Update(System.Single localRotationWeight, System.Single localPositionWeight) { }

    }

    // TypeToken: 0x20000A7  // size: 0x78
    public class Rigidbone
    {
        // Fields
        public UnityEngine.Rigidbody r;  // 0x10
        public UnityEngine.Transform t;  // 0x18
        public UnityEngine.Collider collider;  // 0x20
        public UnityEngine.Joint joint;  // 0x28
        public UnityEngine.Rigidbody c;  // 0x30
        public System.Boolean updateAnchor;  // 0x38
        public UnityEngine.Vector3 deltaPosition;  // 0x3c
        public UnityEngine.Quaternion deltaRotation;  // 0x48
        public System.Single deltaTime;  // 0x58
        public UnityEngine.Vector3 lastPosition;  // 0x5c
        public UnityEngine.Quaternion lastRotation;  // 0x68

        // Methods
        // RVA: 0x09651284  token: 0x60005EA
        public System.Void .ctor(UnityEngine.Rigidbody r) { }
        // RVA: 0x09650F10  token: 0x60005EB
        public System.Void RecordVelocity() { }
        // RVA: 0x0965102C  token: 0x60005EC
        public System.Void WakeUp(System.Single velocityWeight, System.Single angularVelocityWeight) { }

    }

    // TypeToken: 0x20000A8  // size: 0x38
    public class Child
    {
        // Fields
        public UnityEngine.Transform t;  // 0x10
        public UnityEngine.Vector3 localPosition;  // 0x18
        public UnityEngine.Quaternion localRotation;  // 0x24

        // Methods
        // RVA: 0x09645BD8  token: 0x60005ED
        public System.Void .ctor(UnityEngine.Transform transform) { }
        // RVA: 0x09645A20  token: 0x60005EE
        public System.Void FixTransform(System.Single weight) { }
        // RVA: 0x09645B7C  token: 0x60005EF
        public System.Void StoreLocalState() { }

    }

    // TypeToken: 0x20000A9  // size: 0x28
    public sealed class <DisableRagdollSmooth>d__21 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public RootMotion.FinalIK.RagdollUtility <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60005F0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60005F1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096543CC  token: 0x60005F2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09654594  token: 0x60005F4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000AE  // size: 0x38
    public class ReachCone
    {
        // Fields
        public UnityEngine.Vector3[] tetrahedron;  // 0x10
        public System.Single volume;  // 0x18
        public UnityEngine.Vector3 S;  // 0x1c
        public UnityEngine.Vector3 B;  // 0x28

        // Properties
        UnityEngine.Vector3 o { get; /* RVA: 0x09650EE4 */ }
        UnityEngine.Vector3 a { get; /* RVA: 0x09650E44 */ }
        UnityEngine.Vector3 b { get; /* RVA: 0x09650E74 */ }
        UnityEngine.Vector3 c { get; /* RVA: 0x09650EA4 */ }
        System.Boolean isValid { get; /* RVA: 0x09650ED4 */ }

        // Methods
        // RVA: 0x09650CE8  token: 0x6000629
        public System.Void .ctor(UnityEngine.Vector3 _o, UnityEngine.Vector3 _a, UnityEngine.Vector3 _b, UnityEngine.Vector3 _c) { }
        // RVA: 0x09650B30  token: 0x600062B
        public System.Void Calculate() { }

    }

    // TypeToken: 0x20000AF  // size: 0x20
    public class LimitPoint
    {
        // Fields
        public UnityEngine.Vector3 point;  // 0x10
        public System.Single tangentWeight;  // 0x1c

        // Methods
        // RVA: 0x0964E300  token: 0x600062C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2  // size: 0x28
    public sealed class <TurnToTarget>d__37 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public RootMotion.FinalIK.AimController <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600063C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600063D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096545E0  token: 0x600063E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09654694  token: 0x6000640
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B4  // size: 0x38
    public class Pose
    {
        // Fields
        public System.Boolean visualize;  // 0x10
        public System.String name;  // 0x18
        public UnityEngine.Vector3 direction;  // 0x20
        public System.Single yaw;  // 0x2c
        public System.Single pitch;  // 0x30
        private System.Single angleBuffer;  // 0x34

        // Methods
        // RVA: 0x0964F4A0  token: 0x6000645
        public System.Boolean IsInDirection(UnityEngine.Vector3 d) { }
        // RVA: 0x03D56CB0  token: 0x6000646
        public System.Void SetAngleBuffer(System.Single value) { }
        // RVA: 0x03D74DB0  token: 0x6000647
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7  // size: 0x18
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public System.Single weight;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x600064D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6  // size: 0x50
    public class Body
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public UnityEngine.Transform relativeTo;  // 0x18
        public RootMotion.FinalIK.Amplifier.Body.EffectorLink[] effectorLinks;  // 0x20
        public System.Single verticalWeight;  // 0x28
        public System.Single horizontalWeight;  // 0x2c
        public System.Single speed;  // 0x30
        private UnityEngine.Vector3 lastRelativePos;  // 0x34
        private UnityEngine.Vector3 smoothDelta;  // 0x40
        private System.Boolean firstUpdate;  // 0x4c

        // Methods
        // RVA: 0x0964447C  token: 0x600064A
        public System.Void Update(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single w, System.Single deltaTime) { }
        // RVA: 0x03D74CB0  token: 0x600064B
        private static UnityEngine.Vector3 Multiply(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        // RVA: 0x03D74D10  token: 0x600064C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD  // size: 0x48
    public abstract class HitPoint
    {
        // Fields
        public System.String name;  // 0x10
        public UnityEngine.Collider collider;  // 0x18
        private System.Single crossFadeTime;  // 0x20
        private System.Single <crossFader>k__BackingField;  // 0x24
        private System.Single <timer>k__BackingField;  // 0x28
        private UnityEngine.Vector3 <force>k__BackingField;  // 0x2c
        private System.Single length;  // 0x38
        private System.Single crossFadeSpeed;  // 0x3c
        private System.Single lastTime;  // 0x40

        // Properties
        System.Boolean inProgress { get; /* RVA: 0x09647BEC */ }
        System.Single crossFader { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x03D52500 */ }
        System.Single timer { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x03D4F490 */ }
        UnityEngine.Vector3 force { get; /* RVA: 0x03D59800 */ set; /* RVA: 0x03D5BF30 */ }

        // Methods
        // RVA: 0x09647B10  token: 0x600066D
        public virtual System.Void Hit(UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        // RVA: 0x09647A48  token: 0x600066E
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        // RVA: -1  // abstract  token: 0x600066F
        protected virtual System.Single GetLength() { }
        // RVA: -1  // abstract  token: 0x6000670
        protected virtual System.Void CrossFadeStart() { }
        // RVA: -1  // abstract  token: 0x6000671
        protected virtual System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        // RVA: 0x03D74D90  token: 0x6000672
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF  // size: 0x30
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public System.Single weight;  // 0x14
        private UnityEngine.Vector3 lastValue;  // 0x18
        private UnityEngine.Vector3 current;  // 0x24

        // Methods
        // RVA: 0x096467F0  token: 0x6000677
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Vector3 offset, System.Single crossFader) { }
        // RVA: 0x03D74D70  token: 0x6000678
        public System.Void CrossFadeStart() { }
        // RVA: 0x0350B670  token: 0x6000679
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE  // size: 0x60
    public class HitPointEffector : HitPoint
    {
        // Fields
        public UnityEngine.AnimationCurve offsetInForceDirection;  // 0x48
        public UnityEngine.AnimationCurve offsetInUpDirection;  // 0x50
        public RootMotion.FinalIK.HitReaction.HitPointEffector.EffectorLink[] effectorLinks;  // 0x58

        // Methods
        // RVA: 0x09647768  token: 0x6000673
        protected virtual System.Single GetLength() { }
        // RVA: 0x0964771C  token: 0x6000674
        protected virtual System.Void CrossFadeStart() { }
        // RVA: 0x09647870  token: 0x6000675
        protected virtual System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        // RVA: 0x03D74D90  token: 0x6000676
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1  // size: 0x40
    public class BoneLink
    {
        // Fields
        public UnityEngine.Transform bone;  // 0x10
        public System.Single weight;  // 0x18
        private UnityEngine.Quaternion lastValue;  // 0x1c
        private UnityEngine.Quaternion current;  // 0x2c

        // Methods
        // RVA: 0x096448BC  token: 0x600067F
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Quaternion offset, System.Single crossFader) { }
        // RVA: 0x03D74D30  token: 0x6000680
        public System.Void CrossFadeStart() { }
        // RVA: 0x096449C0  token: 0x6000681
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0  // size: 0x70
    public class HitPointBone : HitPoint
    {
        // Fields
        public UnityEngine.AnimationCurve aroundCenterOfMass;  // 0x48
        public RootMotion.FinalIK.HitReaction.HitPointBone.BoneLink[] boneLinks;  // 0x50
        private UnityEngine.Rigidbody rigidbody;  // 0x58
        private UnityEngine.Vector3 comAxis;  // 0x60

        // Methods
        // RVA: 0x09647488  token: 0x600067A
        public virtual System.Void Hit(UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        // RVA: 0x0964740C  token: 0x600067B
        protected virtual System.Single GetLength() { }
        // RVA: 0x096473C8  token: 0x600067C
        protected virtual System.Void CrossFadeStart() { }
        // RVA: 0x09647648  token: 0x600067D
        protected virtual System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        // RVA: 0x03D74D90  token: 0x600067E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3  // size: 0x48
    public abstract class Offset
    {
        // Fields
        public System.String name;  // 0x10
        public UnityEngine.Collider collider;  // 0x18
        private System.Single crossFadeTime;  // 0x20
        private System.Single <crossFader>k__BackingField;  // 0x24
        private System.Single <timer>k__BackingField;  // 0x28
        private UnityEngine.Vector3 <force>k__BackingField;  // 0x2c
        private System.Single length;  // 0x38
        private System.Single crossFadeSpeed;  // 0x3c
        private System.Single lastTime;  // 0x40

        // Properties
        System.Single crossFader { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x03D52500 */ }
        System.Single timer { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x03D4F490 */ }
        UnityEngine.Vector3 force { get; /* RVA: 0x03D59800 */ set; /* RVA: 0x03D5BF30 */ }

        // Methods
        // RVA: 0x0964F3A4  token: 0x600068B
        public virtual System.Void Hit(UnityEngine.Vector3 force, UnityEngine.AnimationCurve[] curves, UnityEngine.Vector3 point) { }
        // RVA: 0x0964F2CC  token: 0x600068C
        public System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        // RVA: -1  // abstract  token: 0x600068D
        protected virtual System.Single GetLength(UnityEngine.AnimationCurve[] curves) { }
        // RVA: -1  // abstract  token: 0x600068E
        protected virtual System.Void CrossFadeStart() { }
        // RVA: -1  // abstract  token: 0x600068F
        protected virtual System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        // RVA: 0x03D74D90  token: 0x6000690
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5  // size: 0x30
    public class PositionOffsetLink
    {
        // Fields
        public RootMotion.FinalIK.IKSolverVR.PositionOffset positionOffset;  // 0x10
        public System.Single weight;  // 0x14
        private UnityEngine.Vector3 lastValue;  // 0x18
        private UnityEngine.Vector3 current;  // 0x24

        // Methods
        // RVA: 0x0964F758  token: 0x6000695
        public System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.Vector3 offset, System.Single crossFader) { }
        // RVA: 0x03D74D70  token: 0x6000696
        public System.Void CrossFadeStart() { }
        // RVA: 0x0350B670  token: 0x6000697
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C4  // size: 0x58
    public class PositionOffset : Offset
    {
        // Fields
        public System.Int32 forceDirCurveIndex;  // 0x48
        public System.Int32 upDirCurveIndex;  // 0x4c
        public RootMotion.FinalIK.HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;  // 0x50

        // Methods
        // RVA: 0x0964F854  token: 0x6000691
        protected virtual System.Single GetLength(UnityEngine.AnimationCurve[] curves) { }
        // RVA: 0x0964F808  token: 0x6000692
        protected virtual System.Void CrossFadeStart() { }
        // RVA: 0x0964F9C8  token: 0x6000693
        protected virtual System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        // RVA: 0x03D74DD0  token: 0x6000694
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7  // size: 0x38
    public class RotationOffsetLink
    {
        // Fields
        public RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset;  // 0x10
        public System.Single weight;  // 0x14
        private UnityEngine.Quaternion lastValue;  // 0x18
        private UnityEngine.Quaternion current;  // 0x28

        // Methods
        // RVA: 0x09653E24  token: 0x600069D
        public System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.Quaternion offset, System.Single crossFader) { }
        // RVA: 0x03D74E10  token: 0x600069E
        public System.Void CrossFadeStart() { }
        // RVA: 0x09653F00  token: 0x600069F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6  // size: 0x70
    public class RotationOffset : Offset
    {
        // Fields
        public System.Int32 curveIndex;  // 0x48
        public RootMotion.FinalIK.HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;  // 0x50
        private UnityEngine.Rigidbody rigidbody;  // 0x58
        private UnityEngine.Vector3 comAxis;  // 0x60

        // Methods
        // RVA: 0x0965402C  token: 0x6000698
        public virtual System.Void Hit(UnityEngine.Vector3 force, UnityEngine.AnimationCurve[] curves, UnityEngine.Vector3 point) { }
        // RVA: 0x09653F74  token: 0x6000699
        protected virtual System.Single GetLength(UnityEngine.AnimationCurve[] curves) { }
        // RVA: 0x09653F30  token: 0x600069A
        protected virtual System.Void CrossFadeStart() { }
        // RVA: 0x096541F4  token: 0x600069B
        protected virtual System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        // RVA: 0x03D74D90  token: 0x600069C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA  // size: 0x18
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public System.Single weight;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x60006A6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9  // size: 0x68
    public class Body
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public RootMotion.FinalIK.Inertia.Body.EffectorLink[] effectorLinks;  // 0x18
        public System.Single speed;  // 0x20
        public System.Single acceleration;  // 0x24
        public System.Single matchVelocity;  // 0x28
        public System.Single gravity;  // 0x2c
        private UnityEngine.Vector3 delta;  // 0x30
        private UnityEngine.Vector3 lazyPoint;  // 0x3c
        private UnityEngine.Vector3 direction;  // 0x48
        private UnityEngine.Vector3 lastPosition;  // 0x54
        private System.Boolean firstUpdate;  // 0x60

        // Methods
        // RVA: 0x09643F48  token: 0x60006A3
        public System.Void Reset() { }
        // RVA: 0x09644008  token: 0x60006A4
        public System.Void Update(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, System.Single deltaTime) { }
        // RVA: 0x03D74CF0  token: 0x60006A5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD  // size: 0x38
    public class OffsetLimits
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public System.Single spring;  // 0x14
        public System.Boolean x;  // 0x18
        public System.Boolean y;  // 0x19
        public System.Boolean z;  // 0x1a
        public System.Single minX;  // 0x1c
        public System.Single maxX;  // 0x20
        public System.Single minY;  // 0x24
        public System.Single maxY;  // 0x28
        public System.Single minZ;  // 0x2c
        public System.Single maxZ;  // 0x30

        // Methods
        // RVA: 0x09654F34  token: 0x60006B5
        public System.Void Apply(RootMotion.FinalIK.IKEffector e, UnityEngine.Quaternion rootRotation) { }
        // RVA: 0x0965510C  token: 0x60006B6
        private System.Single SpringAxis(System.Single value, System.Single min, System.Single max) { }
        // RVA: 0x09655140  token: 0x60006B7
        private System.Single Spring(System.Single value, System.Single limit, System.Boolean negative) { }
        // RVA: 0x0350B670  token: 0x60006B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE  // size: 0x28
    public sealed class <Initiate>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public RootMotion.FinalIK.OffsetModifier <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60006B9
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60006BA
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09657938  token: 0x60006BB
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09657AA4  token: 0x60006BD
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000D0  // size: 0x28
    public sealed class <Initiate>d__7 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public RootMotion.FinalIK.OffsetModifierVRIK <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60006C6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60006C7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09657780  token: 0x60006C8
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096578EC  token: 0x60006CA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000D2  // size: 0x38
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public UnityEngine.Vector3 offset;  // 0x14
        public UnityEngine.Vector3 pin;  // 0x20
        public UnityEngine.Vector3 pinWeight;  // 0x2c

        // Methods
        // RVA: 0x09654C6C  token: 0x60006CF
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, UnityEngine.Quaternion rotation) { }
        // RVA: 0x0350B670  token: 0x60006D0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5  // size: 0x18
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public System.Single weight;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x60006D7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4  // size: 0x60
    public class Avoider
    {
        // Fields
        public UnityEngine.Transform[] raycastFrom;  // 0x10
        public UnityEngine.Transform raycastTo;  // 0x18
        public System.Single raycastRadius;  // 0x20
        public RootMotion.FinalIK.PenetrationAvoidance.Avoider.EffectorLink[] effectors;  // 0x28
        public System.Single smoothTimeIn;  // 0x30
        public System.Single smoothTimeOut;  // 0x34
        public UnityEngine.LayerMask layers;  // 0x38
        private UnityEngine.Vector3 offset;  // 0x3c
        private UnityEngine.Vector3 offsetTarget;  // 0x48
        private UnityEngine.Vector3 offsetV;  // 0x54

        // Methods
        // RVA: 0x09654AA8  token: 0x60006D3
        public System.Void Solve(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        // RVA: 0x09654700  token: 0x60006D4
        private UnityEngine.Vector3 GetOffsetTarget(RootMotion.FinalIK.IKSolverFullBodyBiped solver) { }
        // RVA: 0x09654880  token: 0x60006D5
        private UnityEngine.Vector3 Raycast(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        // RVA: 0x03D74E20  token: 0x60006D6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8  // size: 0x18
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;  // 0x10
        public System.Single weight;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x60006E7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7  // size: 0x48
    public class RecoilOffset
    {
        // Fields
        public UnityEngine.Vector3 offset;  // 0x10
        public System.Single additivity;  // 0x1c
        public System.Single maxAdditiveOffsetMag;  // 0x20
        public RootMotion.FinalIK.Recoil.RecoilOffset.EffectorLink[] effectorLinks;  // 0x28
        private UnityEngine.Vector3 additiveOffset;  // 0x30
        private UnityEngine.Vector3 lastOffset;  // 0x3c

        // Methods
        // RVA: 0x09655B5C  token: 0x60006E4
        public System.Void Start() { }
        // RVA: 0x09655948  token: 0x60006E5
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Quaternion rotation, System.Single masterWeight, System.Single length, System.Single timeLeft) { }
        // RVA: 0x03D74E30  token: 0x60006E6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9  // size: 0x14
    public sealed struct Handedness
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.Recoil.Handedness Right;  // const
        public static RootMotion.FinalIK.Recoil.Handedness Left;  // const

    }

    // TypeToken: 0x20000DC  // size: 0x88
    public class Settings
    {
        // Fields
        public System.Single scaleMlp;  // 0x10
        public UnityEngine.Vector3 headTrackerForward;  // 0x14
        public UnityEngine.Vector3 headTrackerUp;  // 0x20
        public UnityEngine.Vector3 handTrackerForward;  // 0x2c
        public UnityEngine.Vector3 handTrackerUp;  // 0x38
        public UnityEngine.Vector3 footTrackerForward;  // 0x44
        public UnityEngine.Vector3 footTrackerUp;  // 0x50
        public UnityEngine.Vector3 headOffset;  // 0x5c
        public UnityEngine.Vector3 handOffset;  // 0x68
        public System.Single footForwardOffset;  // 0x74
        public System.Single footInwardOffset;  // 0x78
        public System.Single footHeadingOffset;  // 0x7c
        public System.Single pelvisPositionWeight;  // 0x80
        public System.Single pelvisRotationWeight;  // 0x84

        // Methods
        // RVA: 0x09656DF0  token: 0x60006FD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE  // size: 0x30
    public class Target
    {
        // Fields
        public System.Boolean used;  // 0x10
        public UnityEngine.Vector3 localPosition;  // 0x14
        public UnityEngine.Quaternion localRotation;  // 0x20

        // Methods
        // RVA: 0x096576E4  token: 0x60006FF
        public System.Void .ctor(UnityEngine.Transform t) { }
        // RVA: 0x0965767C  token: 0x6000700
        public System.Void SetTo(UnityEngine.Transform t) { }

    }

    // TypeToken: 0x20000DD  // size: 0x70
    public class CalibrationData
    {
        // Fields
        public System.Single scale;  // 0x10
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target head;  // 0x18
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target leftHand;  // 0x20
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target rightHand;  // 0x28
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target pelvis;  // 0x30
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target leftFoot;  // 0x38
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target rightFoot;  // 0x40
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target leftLegGoal;  // 0x48
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target rightLegGoal;  // 0x50
        public UnityEngine.Vector3 pelvisTargetRight;  // 0x58
        public System.Single pelvisPositionWeight;  // 0x64
        public System.Single pelvisRotationWeight;  // 0x68

        // Methods
        // RVA: 0x0350B670  token: 0x60006FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2  // size: 0x20
    public sealed struct __StaticArrayInitTypeSize=16
    {
    }

    // TypeToken: 0x20000E1  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72;  // static @ 0x0

    }

namespace RootMotion
{

    // TypeToken: 0x2000002  // size: 0x90
    public abstract class Baker : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Int32 frameRate;  // 0x18
        public System.Single keyReductionError;  // 0x1c
        public RootMotion.Baker.Mode mode;  // 0x20
        public UnityEngine.AnimationClip[] animationClips;  // 0x28
        public System.String[] animationStates;  // 0x30
        public System.String saveToFolder;  // 0x38
        public System.String appendName;  // 0x40
        public System.String saveName;  // 0x48
        private System.Boolean <isBaking>k__BackingField;  // 0x50
        private System.Single <bakingProgress>k__BackingField;  // 0x54
        public UnityEngine.Animator animator;  // 0x58
        public UnityEngine.Playables.PlayableDirector director;  // 0x60
        public RootMotion.Baker.BakerDelegate OnStartClip;  // 0x68
        public RootMotion.Baker.BakerDelegate OnUpdateClip;  // 0x70
        public System.Boolean inheritClipSettings;  // 0x78
        public RootMotion.Baker.ClipSettings clipSettings;  // 0x80
        private System.Single <clipLength>k__BackingField;  // 0x88
        protected System.Boolean addLoopFrame;  // 0x8c

        // Properties
        System.Boolean isBaking { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }
        System.Single bakingProgress { get; /* RVA: 0x03D4F670 */ set; /* RVA: 0x03D4F680 */ }
        System.Single clipLength { get; /* RVA: 0x03D56E70 */ set; /* RVA: 0x03D56E90 */ }

        // Methods
        // RVA: 0x095F8BB8  token: 0x6000001
        private System.Void OpenUserManual() { }
        // RVA: 0x095F8B84  token: 0x6000002
        private System.Void OpenScriptReference() { }
        // RVA: 0x095F8BEC  token: 0x6000003
        private System.Void SupportGroup() { }
        // RVA: 0x095F8B50  token: 0x6000004
        private System.Void ASThread() { }
        // RVA: -1  // abstract  token: 0x6000009
        protected virtual UnityEngine.Transform GetCharacterRoot() { }
        // RVA: -1  // abstract  token: 0x600000A
        protected virtual System.Void OnStartBaking() { }
        // RVA: -1  // abstract  token: 0x600000B
        protected virtual System.Void OnSetLoopFrame(System.Single time) { }
        // RVA: -1  // abstract  token: 0x600000C
        protected virtual System.Void OnSetCurves(UnityEngine.AnimationClip& clip) { }
        // RVA: -1  // abstract  token: 0x600000D
        protected virtual System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame) { }
        // RVA: 0x0350B670  token: 0x6000010
        public System.Void BakeClip() { }
        // RVA: 0x0350B670  token: 0x6000011
        public System.Void StartBaking() { }
        // RVA: 0x0350B670  token: 0x6000012
        public System.Void StopBaking() { }
        // RVA: 0x095F8C20  token: 0x6000013
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0xD0
    public class GenericBaker : RootMotion.Baker
    {
        // Fields
        public System.Boolean markAsLegacy;  // 0x90
        public UnityEngine.Transform root;  // 0x98
        public UnityEngine.Transform rootNode;  // 0xa0
        public UnityEngine.Transform[] ignoreList;  // 0xa8
        public UnityEngine.Transform[] bakePositionList;  // 0xb0
        private RootMotion.BakerTransform[] children;  // 0xb8
        private RootMotion.BakerTransform rootChild;  // 0xc0
        private System.Int32 rootChildIndex;  // 0xc8

        // Methods
        // RVA: 0x095FF27C  token: 0x6000019
        private System.Void Awake() { }
        // RVA: 0x011AC510  token: 0x600001A
        protected virtual UnityEngine.Transform GetCharacterRoot() { }
        // RVA: 0x095FF71C  token: 0x600001B
        protected virtual System.Void OnStartBaking() { }
        // RVA: 0x095FF6B4  token: 0x600001C
        protected virtual System.Void OnSetLoopFrame(System.Single time) { }
        // RVA: 0x095FF5E4  token: 0x600001D
        protected virtual System.Void OnSetCurves(UnityEngine.AnimationClip& clip) { }
        // RVA: 0x095FF64C  token: 0x600001E
        protected virtual System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame) { }
        // RVA: 0x095FF544  token: 0x600001F
        private System.Boolean IsIgnored(UnityEngine.Transform t) { }
        // RVA: 0x095FF4A4  token: 0x6000020
        private System.Boolean BakePosition(UnityEngine.Transform t) { }
        // RVA: 0x095FF810  token: 0x6000021
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x30
    public class TQ
    {
        // Fields
        public UnityEngine.Vector3 t;  // 0x10
        public UnityEngine.Quaternion q;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x6000022
        public System.Void .ctor() { }
        // RVA: 0x03D74890  token: 0x6000023
        public System.Void .ctor(UnityEngine.Vector3 translation, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x200000B  // size: 0x10
    public class AvatarUtility
    {
        // Methods
        // RVA: 0x095F4F44  token: 0x6000024
        public static UnityEngine.Quaternion GetPostRotation(UnityEngine.Avatar avatar, UnityEngine.AvatarIKGoal avatarIKGoal) { }
        // RVA: 0x095F4984  token: 0x6000025
        public static RootMotion.TQ GetIKGoalTQ(UnityEngine.Avatar avatar, System.Single humanScale, UnityEngine.AvatarIKGoal avatarIKGoal, RootMotion.TQ bodyPositionRotation, RootMotion.TQ boneTQ) { }
        // RVA: 0x095F52C4  token: 0x6000026
        public static RootMotion.TQ WorldSpaceIKGoalToBone(RootMotion.TQ goalTQ, UnityEngine.Avatar avatar, UnityEngine.AvatarIKGoal avatarIKGoal) { }
        // RVA: 0x095F5140  token: 0x6000027
        public static RootMotion.TQ GetWorldSpaceIKGoal(RootMotion.BakerHumanoidQT ikQT, RootMotion.BakerHumanoidQT rootQT, System.Single time, System.Single humanScale) { }
        // RVA: 0x095F5290  token: 0x6000028
        public static UnityEngine.HumanBodyBones HumanIDFromAvatarIKGoal(UnityEngine.AvatarIKGoal avatarIKGoal) { }
        // RVA: 0x0350B670  token: 0x6000029
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x10
    public static class BakerUtilities
    {
        // Methods
        // RVA: 0x095F89C0  token: 0x600002A
        public static System.Void ReduceKeyframes(UnityEngine.AnimationCurve curve, System.Single maxError) { }
        // RVA: 0x095F8690  token: 0x600002B
        public static UnityEngine.Keyframe[] GetReducedKeyframes(UnityEngine.AnimationCurve curve, System.Single maxError) { }
        // RVA: 0x095F8A00  token: 0x600002C
        public static System.Void SetLoopFrame(System.Single time, UnityEngine.AnimationCurve curve) { }
        // RVA: 0x0350B670  token: 0x600002D
        public static System.Void SetTangentMode(UnityEngine.AnimationCurve curve) { }
        // RVA: 0x095F84F8  token: 0x600002E
        public static UnityEngine.Quaternion EnsureQuaternionContinuity(UnityEngine.Quaternion lastQ, UnityEngine.Quaternion q) { }

    }

    // TypeToken: 0x200000D  // size: 0xA0
    public class BakerHumanoidQT
    {
        // Fields
        private UnityEngine.Transform transform;  // 0x10
        private System.String Qx;  // 0x18
        private System.String Qy;  // 0x20
        private System.String Qz;  // 0x28
        private System.String Qw;  // 0x30
        private System.String Tx;  // 0x38
        private System.String Ty;  // 0x40
        private System.String Tz;  // 0x48
        public UnityEngine.AnimationCurve rotX;  // 0x50
        public UnityEngine.AnimationCurve rotY;  // 0x58
        public UnityEngine.AnimationCurve rotZ;  // 0x60
        public UnityEngine.AnimationCurve rotW;  // 0x68
        public UnityEngine.AnimationCurve posX;  // 0x70
        public UnityEngine.AnimationCurve posY;  // 0x78
        public UnityEngine.AnimationCurve posZ;  // 0x80
        private UnityEngine.AvatarIKGoal goal;  // 0x88
        private UnityEngine.Quaternion lastQ;  // 0x8c
        private System.Boolean lastQSet;  // 0x9c

        // Methods
        // RVA: 0x095F6A6C  token: 0x600002F
        public System.Void .ctor(System.String name) { }
        // RVA: 0x095F6BD0  token: 0x6000030
        public System.Void .ctor(UnityEngine.Transform transform, UnityEngine.AvatarIKGoal goal, System.String name) { }
        // RVA: 0x095F5D94  token: 0x6000031
        public UnityEngine.Quaternion EvaluateRotation(System.Single time) { }
        // RVA: 0x095F5CF8  token: 0x6000032
        public UnityEngine.Vector3 EvaluatePosition(System.Single time) { }
        // RVA: 0x095F5E5C  token: 0x6000033
        public RootMotion.TQ Evaluate(System.Single time) { }
        // RVA: 0x0350B670  token: 0x6000034
        public System.Void GetCurvesFromClip(UnityEngine.AnimationClip clip, UnityEngine.Animator animator) { }
        // RVA: 0x095F6074  token: 0x6000035
        public System.Void Reset() { }
        // RVA: 0x095F65B0  token: 0x6000036
        public System.Void SetIKKeyframes(System.Single time, UnityEngine.Avatar avatar, UnityEngine.Transform root, System.Single humanScale, UnityEngine.Vector3 bodyPosition, UnityEngine.Quaternion bodyRotation) { }
        // RVA: 0x095F68F0  token: 0x6000037
        public System.Void SetKeyframes(System.Single time, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x095F5F60  token: 0x6000038
        public System.Void MoveLastKeyframes(System.Single time) { }
        // RVA: 0x095F69E4  token: 0x6000039
        public System.Void SetLoopFrame(System.Single time) { }
        // RVA: 0x0350B670  token: 0x600003A
        public System.Void SetRootLoopFrame(System.Single time) { }
        // RVA: 0x095F5EFC  token: 0x600003B
        private System.Void MoveLastKeyframe(System.Single time, UnityEngine.AnimationCurve curve) { }
        // RVA: 0x095F5FF8  token: 0x600003C
        public System.Void MultiplyLength(UnityEngine.AnimationCurve curve, System.Single mlp) { }
        // RVA: 0x095F6214  token: 0x600003D
        public System.Void SetCurves(UnityEngine.AnimationClip& clip, System.Single maxError, System.Single lengthMlp) { }

    }

    // TypeToken: 0x200000E  // size: 0x28
    public class BakerMuscle
    {
        // Fields
        public UnityEngine.AnimationCurve curve;  // 0x10
        private System.Int32 muscleIndex;  // 0x18
        private System.String propertyName;  // 0x20

        // Methods
        // RVA: 0x095F78AC  token: 0x600003E
        public System.Void .ctor(System.Int32 muscleIndex) { }
        // RVA: 0x095F6D60  token: 0x600003F
        private System.String MuscleNameToPropertyName(System.String n) { }
        // RVA: 0x095F5FF8  token: 0x6000040
        public System.Void MultiplyLength(UnityEngine.AnimationCurve curve, System.Single mlp) { }
        // RVA: 0x095F7760  token: 0x6000041
        public System.Void SetCurves(UnityEngine.AnimationClip& clip, System.Single maxError, System.Single lengthMlp) { }
        // RVA: 0x095F76FC  token: 0x6000042
        public System.Void Reset() { }
        // RVA: 0x095F785C  token: 0x6000043
        public System.Void SetKeyframe(System.Single time, System.Single[] muscles) { }
        // RVA: 0x095F789C  token: 0x6000044
        public System.Void SetLoopFrame(System.Single time) { }

    }

    // TypeToken: 0x200000F  // size: 0x80
    public class BakerTransform
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public UnityEngine.AnimationCurve posX;  // 0x18
        public UnityEngine.AnimationCurve posY;  // 0x20
        public UnityEngine.AnimationCurve posZ;  // 0x28
        public UnityEngine.AnimationCurve rotX;  // 0x30
        public UnityEngine.AnimationCurve rotY;  // 0x38
        public UnityEngine.AnimationCurve rotZ;  // 0x40
        public UnityEngine.AnimationCurve rotW;  // 0x48
        private System.String relativePath;  // 0x50
        private System.Boolean recordPosition;  // 0x58
        private UnityEngine.Vector3 relativePosition;  // 0x5c
        private System.Boolean isRootNode;  // 0x68
        private UnityEngine.Quaternion relativeRotation;  // 0x6c

        // Methods
        // RVA: 0x095F8470  token: 0x6000045
        public System.Void .ctor(UnityEngine.Transform transform, UnityEngine.Transform root, System.Boolean recordPosition, System.Boolean isRootNode) { }
        // RVA: 0x03D74310  token: 0x6000046
        public System.Void SetRelativeSpace(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x095F7F94  token: 0x6000047
        public System.Void SetCurves(UnityEngine.AnimationClip& clip) { }
        // RVA: 0x095F7AEC  token: 0x6000048
        private System.Void AddRootMotionCurves(UnityEngine.AnimationClip& clip) { }
        // RVA: 0x095F7E1C  token: 0x6000049
        public System.Void Reset() { }
        // RVA: 0x095F7D98  token: 0x600004A
        public System.Void ReduceKeyframes(System.Single maxError) { }
        // RVA: 0x095F8264  token: 0x600004B
        public System.Void SetKeyframes(System.Single time) { }
        // RVA: 0x095F7910  token: 0x600004C
        public System.Void AddLoopFrame(System.Single time) { }

    }

    // TypeToken: 0x2000010  // size: 0x138
    public class HumanoidBaker : RootMotion.Baker
    {
        // Fields
        public System.Boolean bakeHandIK;  // 0x90
        public System.Single IKKeyReductionError;  // 0x94
        public System.Int32 muscleFrameRateDiv;  // 0x98
        private RootMotion.BakerMuscle[] bakerMuscles;  // 0xa0
        private RootMotion.BakerHumanoidQT rootQT;  // 0xa8
        private RootMotion.BakerHumanoidQT leftFootQT;  // 0xb0
        private RootMotion.BakerHumanoidQT rightFootQT;  // 0xb8
        private RootMotion.BakerHumanoidQT leftHandQT;  // 0xc0
        private RootMotion.BakerHumanoidQT rightHandQT;  // 0xc8
        private System.Single[] muscles;  // 0xd0
        private UnityEngine.HumanPose pose;  // 0xd8
        private UnityEngine.HumanPoseHandler handler;  // 0x100
        private UnityEngine.Vector3 bodyPosition;  // 0x108
        private UnityEngine.Quaternion bodyRotation;  // 0x114
        private System.Int32 mN;  // 0x124
        private UnityEngine.Quaternion lastBodyRotation;  // 0x128

        // Methods
        // RVA: 0x096001B4  token: 0x600004D
        private System.Void Awake() { }
        // RVA: 0x096006B0  token: 0x600004E
        protected virtual UnityEngine.Transform GetCharacterRoot() { }
        // RVA: 0x09600D70  token: 0x600004F
        protected virtual System.Void OnStartBaking() { }
        // RVA: 0x09600C90  token: 0x6000050
        protected virtual System.Void OnSetLoopFrame(System.Single time) { }
        // RVA: 0x096006D0  token: 0x6000051
        protected virtual System.Void OnSetCurves(UnityEngine.AnimationClip& clip) { }
        // RVA: 0x096008DC  token: 0x6000052
        protected virtual System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame) { }
        // RVA: 0x09600E54  token: 0x6000053
        private System.Void UpdateHumanPose() { }
        // RVA: 0x09600F40  token: 0x6000054
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.Axis X;  // const
        public static RootMotion.Axis Y;  // const
        public static RootMotion.Axis Z;  // const

    }

    // TypeToken: 0x2000012  // size: 0x10
    public class AxisTools
    {
        // Methods
        // RVA: 0x095F5C38  token: 0x6000055
        public static UnityEngine.Vector3 ToVector3(RootMotion.Axis axis) { }
        // RVA: 0x095F5BF8  token: 0x6000056
        public static RootMotion.Axis ToAxis(UnityEngine.Vector3 v) { }
        // RVA: 0x095F57FC  token: 0x6000057
        public static RootMotion.Axis GetAxisToPoint(UnityEngine.Transform t, UnityEngine.Vector3 worldPosition) { }
        // RVA: 0x095F5710  token: 0x6000058
        public static RootMotion.Axis GetAxisToDirection(UnityEngine.Transform t, UnityEngine.Vector3 direction) { }
        // RVA: 0x095F5B48  token: 0x6000059
        public static UnityEngine.Vector3 GetAxisVectorToPoint(UnityEngine.Transform t, UnityEngine.Vector3 worldPosition) { }
        // RVA: 0x095F58E8  token: 0x600005A
        public static UnityEngine.Vector3 GetAxisVectorToDirection(UnityEngine.Transform t, UnityEngine.Vector3 direction) { }
        // RVA: 0x095F5954  token: 0x600005B
        public static UnityEngine.Vector3 GetAxisVectorToDirection(UnityEngine.Quaternion r, UnityEngine.Vector3 direction) { }
        // RVA: 0x0350B670  token: 0x600005C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x30
    public class BipedLimbOrientations
    {
        // Fields
        public RootMotion.BipedLimbOrientations.LimbOrientation leftArm;  // 0x10
        public RootMotion.BipedLimbOrientations.LimbOrientation rightArm;  // 0x18
        public RootMotion.BipedLimbOrientations.LimbOrientation leftLeg;  // 0x20
        public RootMotion.BipedLimbOrientations.LimbOrientation rightLeg;  // 0x28

        // Properties
        RootMotion.BipedLimbOrientations UMA { get; /* RVA: 0x095F96EC */ }
        RootMotion.BipedLimbOrientations MaxBiped { get; /* RVA: 0x095F945C */ }

        // Methods
        // RVA: 0x02F73D30  token: 0x600005D
        public System.Void .ctor(RootMotion.BipedLimbOrientations.LimbOrientation leftArm, RootMotion.BipedLimbOrientations.LimbOrientation rightArm, RootMotion.BipedLimbOrientations.LimbOrientation leftLeg, RootMotion.BipedLimbOrientations.LimbOrientation rightLeg) { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public static class BipedNaming
    {
        // Fields
        public static System.String[] typeLeft;  // static @ 0x0
        public static System.String[] typeRight;  // static @ 0x8
        public static System.String[] typeSpine;  // static @ 0x10
        public static System.String[] typeHead;  // static @ 0x18
        public static System.String[] typeArm;  // static @ 0x20
        public static System.String[] typeLeg;  // static @ 0x28
        public static System.String[] typeTail;  // static @ 0x30
        public static System.String[] typeEye;  // static @ 0x38
        public static System.String[] typeExclude;  // static @ 0x40
        public static System.String[] typeExcludeSpine;  // static @ 0x48
        public static System.String[] typeExcludeHead;  // static @ 0x50
        public static System.String[] typeExcludeArm;  // static @ 0x58
        public static System.String[] typeExcludeLeg;  // static @ 0x60
        public static System.String[] typeExcludeTail;  // static @ 0x68
        public static System.String[] typeExcludeEye;  // static @ 0x70
        public static System.String[] pelvis;  // static @ 0x78
        public static System.String[] hand;  // static @ 0x80
        public static System.String[] foot;  // static @ 0x88

        // Methods
        // RVA: 0x095F9D10  token: 0x6000061
        public static UnityEngine.Transform[] GetBonesOfType(RootMotion.BipedNaming.BoneType boneType, UnityEngine.Transform[] bones) { }
        // RVA: 0x095F9B58  token: 0x6000062
        public static UnityEngine.Transform[] GetBonesOfSide(RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones) { }
        // RVA: 0x095F9CA8  token: 0x6000063
        public static UnityEngine.Transform[] GetBonesOfTypeAndSide(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones) { }
        // RVA: 0x095F9E60  token: 0x6000064
        public static UnityEngine.Transform GetFirstBoneOfTypeAndSide(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones) { }
        // RVA: 0x095F9EE4  token: 0x6000065
        public static UnityEngine.Transform GetNamingMatch(UnityEngine.Transform[] transforms, System.String[][] namings) { }
        // RVA: 0x095F99E8  token: 0x6000066
        public static RootMotion.BipedNaming.BoneType GetBoneType(System.String boneName) { }
        // RVA: 0x095F997C  token: 0x6000067
        public static RootMotion.BipedNaming.BoneSide GetBoneSide(System.String boneName) { }
        // RVA: 0x095F9AE0  token: 0x6000068
        public static UnityEngine.Transform GetBone(UnityEngine.Transform[] transforms, RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, System.String[][] namings) { }
        // RVA: 0x095FB4D0  token: 0x6000069
        private static System.Boolean isLeft(System.String boneName) { }
        // RVA: 0x095FB618  token: 0x600006A
        private static System.Boolean isRight(System.String boneName) { }
        // RVA: 0x095FB6D8  token: 0x600006B
        private static System.Boolean isSpine(System.String boneName) { }
        // RVA: 0x095FB448  token: 0x600006C
        private static System.Boolean isHead(System.String boneName) { }
        // RVA: 0x095FB338  token: 0x600006D
        private static System.Boolean isArm(System.String boneName) { }
        // RVA: 0x095FB590  token: 0x600006E
        private static System.Boolean isLeg(System.String boneName) { }
        // RVA: 0x095FB760  token: 0x600006F
        private static System.Boolean isTail(System.String boneName) { }
        // RVA: 0x095FB3C0  token: 0x6000070
        private static System.Boolean isEye(System.String boneName) { }
        // RVA: 0x095FB7E8  token: 0x6000071
        private static System.Boolean isTypeExclude(System.String boneName) { }
        // RVA: 0x095FB930  token: 0x6000072
        private static System.Boolean matchesNaming(System.String boneName, System.String[] namingConvention) { }
        // RVA: 0x095FB274  token: 0x6000073
        private static System.Boolean excludesNaming(System.String boneName, System.String[] namingConvention) { }
        // RVA: 0x095FB898  token: 0x6000074
        private static System.Boolean matchesLastLetter(System.String boneName, System.String[] namingConvention) { }
        // RVA: 0x095F9FC4  token: 0x6000075
        private static System.Boolean LastLetterIs(System.String boneName, System.String letter) { }
        // RVA: 0x095FB2DC  token: 0x6000076
        private static System.String firstLetter(System.String boneName) { }
        // RVA: 0x095FB83C  token: 0x6000077
        private static System.String lastLetter(System.String boneName) { }
        // RVA: 0x095F9FFC  token: 0x6000078
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x98
    public class BipedReferences
    {
        // Fields
        public UnityEngine.Transform root;  // 0x10
        public UnityEngine.Transform pelvis;  // 0x18
        public UnityEngine.Transform leftThigh;  // 0x20
        public UnityEngine.Transform leftCalf;  // 0x28
        public UnityEngine.Transform leftFoot;  // 0x30
        public UnityEngine.Transform rightThigh;  // 0x38
        public UnityEngine.Transform rightCalf;  // 0x40
        public UnityEngine.Transform rightFoot;  // 0x48
        public UnityEngine.Transform leftUpperArm;  // 0x50
        public UnityEngine.Transform leftForearm;  // 0x58
        public UnityEngine.Transform leftHand;  // 0x60
        public UnityEngine.Transform rightUpperArm;  // 0x68
        public UnityEngine.Transform rightForearm;  // 0x70
        public UnityEngine.Transform rightHand;  // 0x78
        public UnityEngine.Transform head;  // 0x80
        public UnityEngine.Transform[] spine;  // 0x88
        public UnityEngine.Transform[] eyes;  // 0x90

        // Properties
        System.Boolean isFilled { get; /* RVA: 0x029EC8B0 */ }
        System.Boolean isEmpty { get; /* RVA: 0x095FDB14 */ }

        // Methods
        // RVA: 0x095FD1F4  token: 0x600007B
        public virtual System.Boolean IsEmpty(System.Boolean includeRoot) { }
        // RVA: 0x095FC350  token: 0x600007C
        public virtual System.Boolean Contains(UnityEngine.Transform t, System.Boolean ignoreRoot) { }
        // RVA: 0x095FC158  token: 0x600007D
        public static System.Boolean AutoDetectReferences(RootMotion.BipedReferences& references, UnityEngine.Transform root, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        // RVA: 0x095FC79C  token: 0x600007E
        public static System.Void DetectReferencesByNaming(RootMotion.BipedReferences& references, UnityEngine.Transform root, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        // RVA: 0x095FBCB8  token: 0x600007F
        public static System.Void AssignHumanoidReferences(RootMotion.BipedReferences& references, UnityEngine.Animator animator, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        // RVA: 0x029ECCA0  token: 0x6000080
        public static System.Boolean SetupError(RootMotion.BipedReferences references, System.String& errorMessage) { }
        // RVA: 0x095FDA48  token: 0x6000081
        public static System.Boolean SetupWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        // RVA: 0x095FD500  token: 0x6000082
        private static System.Boolean IsNeckBone(UnityEngine.Transform bone, UnityEngine.Transform leftUpperArm) { }
        // RVA: 0x095FB9E0  token: 0x6000083
        private static System.Boolean AddBoneToEyes(UnityEngine.Transform bone, RootMotion.BipedReferences& references, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        // RVA: 0x095FBB70  token: 0x6000084
        private static System.Boolean AddBoneToSpine(UnityEngine.Transform bone, RootMotion.BipedReferences& references, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        // RVA: 0x095FC67C  token: 0x6000085
        private static System.Void DetectLimb(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform& firstBone, UnityEngine.Transform& secondBone, UnityEngine.Transform& lastBone, UnityEngine.Transform[] transforms) { }
        // RVA: 0x095FBABC  token: 0x6000086
        private static System.Void AddBoneToHierarchy(UnityEngine.Transform[]& bones, UnityEngine.Transform transform) { }
        // RVA: 0x029F0320  token: 0x6000087
        private static System.Boolean LimbError(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, System.String& errorMessage) { }
        // RVA: 0x095FD5BC  token: 0x6000088
        private static System.Boolean LimbWarning(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, System.String& warningMessage) { }
        // RVA: 0x029ED9D0  token: 0x6000089
        private static System.Boolean SpineError(RootMotion.BipedReferences references, System.String& errorMessage) { }
        // RVA: 0x0115F4C0  token: 0x600008A
        private static System.Boolean SpineWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        // RVA: 0x029ECDC0  token: 0x600008B
        private static System.Boolean EyesError(RootMotion.BipedReferences references, System.String& errorMessage) { }
        // RVA: 0x0115F4C0  token: 0x600008C
        private static System.Boolean EyesWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        // RVA: 0x095FD850  token: 0x600008D
        private static System.Boolean RootHeightWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        // RVA: 0x095FCF30  token: 0x600008E
        private static System.Boolean FacingAxisWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        // RVA: 0x095FD14C  token: 0x600008F
        private static System.Single GetVerticalOffset(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Quaternion rotation) { }
        // RVA: 0x029ED130  token: 0x6000090
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x20
    public class Comments : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String text;  // 0x18

        // Methods
        // RVA: 0x0426FE60  token: 0x6000093
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x30
    public class DemoGUIMessage : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String text;  // 0x18
        public UnityEngine.Color color;  // 0x20

        // Methods
        // RVA: 0x095FE0AC  token: 0x6000094
        private System.Void OnGUI() { }
        // RVA: 0x095FE150  token: 0x6000095
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x10
    public class Hierarchy
    {
        // Methods
        // RVA: 0x029EF630  token: 0x6000096
        public static System.Boolean HierarchyIsValid(UnityEngine.Transform[] bones) { }
        // RVA: 0x029EFEA0  token: 0x6000097
        public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects) { }
        // RVA: 0x029EF6A0  token: 0x6000098
        public static System.Boolean IsAncestor(UnityEngine.Transform transform, UnityEngine.Transform ancestor) { }
        // RVA: 0x095FFAC8  token: 0x6000099
        public static System.Boolean ContainsChild(UnityEngine.Transform transform, UnityEngine.Transform child) { }
        // RVA: 0x095FF86C  token: 0x600009A
        public static System.Void AddAncestors(UnityEngine.Transform transform, UnityEngine.Transform blocker, UnityEngine.Transform[]& array) { }
        // RVA: 0x095FFBA0  token: 0x600009B
        public static UnityEngine.Transform GetAncestor(UnityEngine.Transform transform, System.Int32 minChildCount) { }
        // RVA: 0x095FFDC4  token: 0x600009C
        public static UnityEngine.Transform GetFirstCommonAncestor(UnityEngine.Transform t1, UnityEngine.Transform t2) { }
        // RVA: 0x095FFEF0  token: 0x600009D
        public static UnityEngine.Transform GetFirstCommonAncestor(UnityEngine.Transform[] transforms) { }
        // RVA: 0x095FFC74  token: 0x600009E
        public static UnityEngine.Transform GetFirstCommonAncestorRecursive(UnityEngine.Transform transform, UnityEngine.Transform[] transforms) { }
        // RVA: 0x09600010  token: 0x600009F
        public static System.Boolean IsCommonAncestor(UnityEngine.Transform transform, UnityEngine.Transform[] transforms) { }
        // RVA: 0x0350B670  token: 0x60000A0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x20
    public class InspectorComment : UnityEngine.PropertyAttribute
    {
        // Fields
        public System.String name;  // 0x10
        public System.String color;  // 0x18

        // Methods
        // RVA: 0x09601048  token: 0x60000A1
        public System.Void .ctor(System.String name) { }
        // RVA: 0x09600FD4  token: 0x60000A2
        public System.Void .ctor(System.String name, System.String color) { }

    }

    // TypeToken: 0x200001E  // size: 0x14
    public sealed struct InterpolationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.InterpolationMode None;  // const
        public static RootMotion.InterpolationMode InOutCubic;  // const
        public static RootMotion.InterpolationMode InOutQuintic;  // const
        public static RootMotion.InterpolationMode InOutSine;  // const
        public static RootMotion.InterpolationMode InQuintic;  // const
        public static RootMotion.InterpolationMode InQuartic;  // const
        public static RootMotion.InterpolationMode InCubic;  // const
        public static RootMotion.InterpolationMode InQuadratic;  // const
        public static RootMotion.InterpolationMode InElastic;  // const
        public static RootMotion.InterpolationMode InElasticSmall;  // const
        public static RootMotion.InterpolationMode InElasticBig;  // const
        public static RootMotion.InterpolationMode InSine;  // const
        public static RootMotion.InterpolationMode InBack;  // const
        public static RootMotion.InterpolationMode OutQuintic;  // const
        public static RootMotion.InterpolationMode OutQuartic;  // const
        public static RootMotion.InterpolationMode OutCubic;  // const
        public static RootMotion.InterpolationMode OutInCubic;  // const
        public static RootMotion.InterpolationMode OutInQuartic;  // const
        public static RootMotion.InterpolationMode OutElastic;  // const
        public static RootMotion.InterpolationMode OutElasticSmall;  // const
        public static RootMotion.InterpolationMode OutElasticBig;  // const
        public static RootMotion.InterpolationMode OutSine;  // const
        public static RootMotion.InterpolationMode OutBack;  // const
        public static RootMotion.InterpolationMode OutBackCubic;  // const
        public static RootMotion.InterpolationMode OutBackQuartic;  // const
        public static RootMotion.InterpolationMode BackInCubic;  // const
        public static RootMotion.InterpolationMode BackInQuartic;  // const

    }

    // TypeToken: 0x200001F  // size: 0x10
    public class Interp
    {
        // Methods
        // RVA: 0x096010B4  token: 0x60000A3
        public static System.Single Float(System.Single t, RootMotion.InterpolationMode mode) { }
        // RVA: 0x096016C4  token: 0x60000A4
        public static UnityEngine.Vector3 V3(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, System.Single t, RootMotion.InterpolationMode mode) { }
        // RVA: 0x0281C190  token: 0x60000A5
        public static System.Single LerpValue(System.Single value, System.Single target, System.Single increaseSpeed, System.Single decreaseSpeed) { }
        // RVA: 0x03D74560  token: 0x60000A6
        private static System.Single None(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74490  token: 0x60000A7
        private static System.Single InOutCubic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D744C0  token: 0x60000A8
        private static System.Single InOutQuintic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74540  token: 0x60000A9
        private static System.Single InQuintic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74520  token: 0x60000AA
        private static System.Single InQuartic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D743B0  token: 0x60000AB
        private static System.Single InCubic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74510  token: 0x60000AC
        private static System.Single InQuadratic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74820  token: 0x60000AD
        private static System.Single OutQuintic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D747C0  token: 0x60000AE
        private static System.Single OutQuartic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74600  token: 0x60000AF
        private static System.Single OutCubic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74740  token: 0x60000B0
        private static System.Single OutInCubic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74780  token: 0x60000B1
        private static System.Single OutInQuartic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74340  token: 0x60000B2
        private static System.Single BackInCubic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74370  token: 0x60000B3
        private static System.Single BackInQuartic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74570  token: 0x60000B4
        private static System.Single OutBackCubic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D745B0  token: 0x60000B5
        private static System.Single OutBackQuartic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D746C0  token: 0x60000B6
        private static System.Single OutElasticSmall(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74640  token: 0x60000B7
        private static System.Single OutElasticBig(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D74430  token: 0x60000B8
        private static System.Single InElasticSmall(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x03D743D0  token: 0x60000B9
        private static System.Single InElasticBig(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x09601548  token: 0x60000BA
        private static System.Single InSine(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x09601688  token: 0x60000BB
        private static System.Single OutSine(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x096014F4  token: 0x60000BC
        private static System.Single InOutSine(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x0960142C  token: 0x60000BD
        private static System.Single InElastic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x096015D0  token: 0x60000BE
        private static System.Single OutElastic(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x09601404  token: 0x60000BF
        private static System.Single InBack(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x09601594  token: 0x60000C0
        private static System.Single OutBack(System.Single t, System.Single b, System.Single c) { }
        // RVA: 0x0350B670  token: 0x60000C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public static class LayerMaskExtensions
    {
        // Methods
        // RVA: 0x09601874  token: 0x60000C2
        public static System.Boolean Contains(UnityEngine.LayerMask mask, System.Int32 layer) { }
        // RVA: 0x093A97C8  token: 0x60000C3
        public static UnityEngine.LayerMask Create(System.String[] layerNames) { }
        // RVA: 0x093A97D0  token: 0x60000C4
        public static UnityEngine.LayerMask Create(System.Int32[] layerNumbers) { }
        // RVA: 0x093A97D8  token: 0x60000C5
        public static UnityEngine.LayerMask NamesToMask(System.String[] layerNames) { }
        // RVA: 0x093A9834  token: 0x60000C6
        public static UnityEngine.LayerMask LayerNumbersToMask(System.Int32[] layerNumbers) { }
        // RVA: 0x03D71FC0  token: 0x60000C7
        public static UnityEngine.LayerMask Inverse(UnityEngine.LayerMask original) { }
        // RVA: 0x093A96E8  token: 0x60000C8
        public static UnityEngine.LayerMask AddToMask(UnityEngine.LayerMask original, System.String[] layerNames) { }
        // RVA: 0x093A9A18  token: 0x60000C9
        public static UnityEngine.LayerMask RemoveFromMask(UnityEngine.LayerMask original, System.String[] layerNames) { }
        // RVA: 0x09601884  token: 0x60000CA
        public static System.String[] MaskToNames(UnityEngine.LayerMask original) { }
        // RVA: 0x09601960  token: 0x60000CB
        public static System.Int32[] MaskToNumbers(UnityEngine.LayerMask original) { }
        // RVA: 0x09601A28  token: 0x60000CC
        public static System.String MaskToString(UnityEngine.LayerMask original) { }
        // RVA: 0x09601A64  token: 0x60000CD
        public static System.String MaskToString(UnityEngine.LayerMask original, System.String delimiter) { }

    }

    // TypeToken: 0x2000021
    public abstract class LazySingleton`1 : UnityEngine.MonoBehaviour
    {
        // Fields
        private static T sInstance;  // static @ 0x0

        // Properties
        System.Boolean hasInstance { get; /* RVA: -1  // not resolved */ }
        T instance { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000D0
        protected virtual System.Void Awake() { }
        // RVA: -1  // not resolved  token: 0x60000D1
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x14
    public sealed struct ShowIfMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.ShowIfMode Disabled;  // const
        public static RootMotion.ShowIfMode Hidden;  // const

    }

    // TypeToken: 0x2000023  // size: 0x30
    public class ShowIfAttribute : UnityEngine.PropertyAttribute
    {
        // Fields
        private System.String <propName>k__BackingField;  // 0x10
        private System.Object <propValue>k__BackingField;  // 0x18
        private System.Object <otherPropValue>k__BackingField;  // 0x20
        private System.Boolean <indent>k__BackingField;  // 0x28
        private RootMotion.ShowIfMode <mode>k__BackingField;  // 0x2c

        // Properties
        System.String propName { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Object propValue { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Object otherPropValue { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Boolean indent { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        RootMotion.ShowIfMode mode { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }

        // Methods
        // RVA: 0x0960363C  token: 0x60000DC
        public System.Void .ctor(System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }

    }

    // TypeToken: 0x2000024  // size: 0x38
    public class ShowRangeIfAttribute : RootMotion.ShowIfAttribute
    {
        // Fields
        private System.Single <min>k__BackingField;  // 0x30
        private System.Single <max>k__BackingField;  // 0x34

        // Properties
        System.Single min { get; /* RVA: 0x03D4F5D0 */ set; /* RVA: 0x03D4F5E0 */ }
        System.Single max { get; /* RVA: 0x03D56CA0 */ set; /* RVA: 0x03D56CB0 */ }

        // Methods
        // RVA: 0x096037E8  token: 0x60000E1
        public System.Void .ctor(System.Single min, System.Single max, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }

    }

    // TypeToken: 0x2000025  // size: 0x40
    public class ShowLargeHeaderIf : RootMotion.ShowIfAttribute
    {
        // Fields
        public System.String name;  // 0x30
        public System.String color;  // 0x38

        // Methods
        // RVA: 0x09603734  token: 0x60000E2
        public System.Void .ctor(System.String name, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }
        // RVA: 0x09603684  token: 0x60000E3
        public System.Void .ctor(System.String name, System.String color, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }

    }

    // TypeToken: 0x2000026  // size: 0x20
    public class LargeHeader : UnityEngine.PropertyAttribute
    {
        // Fields
        public System.String name;  // 0x10
        public System.String color;  // 0x18

        // Methods
        // RVA: 0x09601808  token: 0x60000E4
        public System.Void .ctor(System.String name) { }
        // RVA: 0x09601794  token: 0x60000E5
        public System.Void .ctor(System.String name, System.String color) { }

    }

    // TypeToken: 0x2000027  // size: 0x10
    public static class QuaTools
    {
        // Methods
        // RVA: 0x09602F10  token: 0x60000E6
        public static System.Single GetYaw(UnityEngine.Quaternion space, UnityEngine.Vector3 forward) { }
        // RVA: 0x09602E90  token: 0x60000E7
        public static System.Single GetPitch(UnityEngine.Quaternion space, UnityEngine.Vector3 forward) { }
        // RVA: 0x09602C2C  token: 0x60000E8
        public static System.Single GetBank(UnityEngine.Quaternion space, UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        // RVA: 0x09602F88  token: 0x60000E9
        public static System.Single GetYaw(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09602DD4  token: 0x60000EA
        public static System.Single GetPitch(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09602A30  token: 0x60000EB
        public static System.Single GetBank(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        // RVA: 0x0960304C  token: 0x60000EC
        public static UnityEngine.Quaternion Lerp(UnityEngine.Quaternion fromRotation, UnityEngine.Quaternion toRotation, System.Single weight) { }
        // RVA: 0x096034D4  token: 0x60000ED
        public static UnityEngine.Quaternion Slerp(UnityEngine.Quaternion fromRotation, UnityEngine.Quaternion toRotation, System.Single weight) { }
        // RVA: 0x096030A8  token: 0x60000EE
        public static UnityEngine.Quaternion LinearBlend(UnityEngine.Quaternion q, System.Single weight) { }
        // RVA: 0x09603530  token: 0x60000EF
        public static UnityEngine.Quaternion SphericalBlend(UnityEngine.Quaternion q, System.Single weight) { }
        // RVA: 0x096026E0  token: 0x60000F0
        public static UnityEngine.Quaternion FromToAroundAxis(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection, UnityEngine.Vector3 axis) { }
        // RVA: 0x02B23BE0  token: 0x60000F1
        public static UnityEngine.Quaternion RotationToLocalSpace(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        // RVA: 0x096027F4  token: 0x60000F2
        public static UnityEngine.Quaternion FromToRotation(UnityEngine.Quaternion from, UnityEngine.Quaternion to) { }
        // RVA: 0x09602898  token: 0x60000F3
        public static UnityEngine.Vector3 GetAxis(UnityEngine.Vector3 v) { }
        // RVA: 0x0960255C  token: 0x60000F4
        public static UnityEngine.Quaternion ClampRotation(UnityEngine.Quaternion rotation, System.Single clampWeight, System.Int32 clampSmoothing) { }
        // RVA: 0x09602470  token: 0x60000F5
        public static System.Single ClampAngle(System.Single angle, System.Single clampWeight, System.Int32 clampSmoothing) { }
        // RVA: 0x09603124  token: 0x60000F6
        public static UnityEngine.Quaternion MatchRotation(UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetAxis1, UnityEngine.Vector3 targetAxis2, UnityEngine.Vector3 axis1, UnityEngine.Vector3 axis2) { }
        // RVA: 0x096035EC  token: 0x60000F7
        public static UnityEngine.Vector3 ToBiPolar(UnityEngine.Vector3 euler) { }
        // RVA: 0x096035AC  token: 0x60000F8
        public static System.Single ToBiPolar(System.Single angle) { }
        // RVA: 0x0960324C  token: 0x60000F9
        public static UnityEngine.Quaternion MirrorYZ(UnityEngine.Quaternion r, UnityEngine.Quaternion space) { }
        // RVA: 0x096033C4  token: 0x60000FA
        public static UnityEngine.Quaternion MirrorYZ(UnityEngine.Quaternion r) { }

    }

    // TypeToken: 0x2000028
    public abstract class Singleton`1 : UnityEngine.MonoBehaviour
    {
        // Fields
        private static T sInstance;  // static @ 0x0

        // Properties
        T instance { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000FC
        public static System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60000FD
        protected virtual System.Void Awake() { }
        // RVA: -1  // not resolved  token: 0x60000FE
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x38
    public class SolverManager : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean fixTransforms;  // 0x18
        private UnityEngine.Animator animator;  // 0x20
        private UnityEngine.Animation legacy;  // 0x28
        private System.Boolean updateFrame;  // 0x30
        private System.Boolean componentInitiated;  // 0x31
        private System.Boolean skipSolverUpdate;  // 0x32

        // Properties
        System.Boolean animatePhysics { get; /* RVA: 0x02DBA970 */ }
        System.Boolean isAnimated { get; /* RVA: 0x02C6B6E0 */ }

        // Methods
        // RVA: 0x09603854  token: 0x60000FF
        public System.Void Disable() { }
        // RVA: 0x0350B670  token: 0x6000100
        protected virtual System.Void InitiateSolver() { }
        // RVA: 0x0350B670  token: 0x6000101
        protected virtual System.Void UpdateSolver() { }
        // RVA: 0x0350B670  token: 0x6000102
        protected virtual System.Void FixTransforms() { }
        // RVA: 0x096038CC  token: 0x6000103
        private System.Void OnDisable() { }
        // RVA: 0x02C6B5A0  token: 0x6000104
        private System.Void Start() { }
        // RVA: 0x02C6B5B0  token: 0x6000106
        public System.Void Initiate() { }
        // RVA: 0x02DBA780  token: 0x6000107
        private System.Void Update() { }
        // RVA: 0x02C6B5F0  token: 0x6000108
        private System.Void FindAnimatorRecursive(UnityEngine.Transform t, System.Boolean findInChildren) { }
        // RVA: 0x02DBA800  token: 0x600010A
        private System.Void FixedUpdate() { }
        // RVA: 0x02DBA7C0  token: 0x600010B
        private System.Void LateUpdate() { }
        // RVA: 0x096038F8  token: 0x600010C
        public System.Void UpdateSolverExternal() { }
        // RVA: 0x042726E8  token: 0x600010D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002A  // size: 0x20
    public class TriggerEventBroadcaster : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject target;  // 0x18

        // Methods
        // RVA: 0x09603928  token: 0x600010E
        private System.Void OnTriggerEnter(UnityEngine.Collider collider) { }
        // RVA: 0x09603A58  token: 0x600010F
        private System.Void OnTriggerStay(UnityEngine.Collider collider) { }
        // RVA: 0x096039C0  token: 0x6000110
        private System.Void OnTriggerExit(UnityEngine.Collider collider) { }
        // RVA: 0x0426FE60  token: 0x6000111
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x10
    public static class V2Tools
    {
        // Methods
        // RVA: 0x03D51590  token: 0x6000112
        public static UnityEngine.Vector2 XZ(UnityEngine.Vector3 v) { }
        // RVA: 0x09603B40  token: 0x6000113
        public static System.Single DeltaAngle(UnityEngine.Vector2 dir1, UnityEngine.Vector2 dir2) { }
        // RVA: 0x09603AF0  token: 0x6000114
        public static System.Single DeltaAngleXZ(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2) { }
        // RVA: 0x09603B9C  token: 0x6000115
        public static System.Boolean LineCircleIntersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 c, System.Single r) { }
        // RVA: 0x09603CB0  token: 0x6000116
        public static System.Boolean RayCircleIntersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 dir, UnityEngine.Vector2 c, System.Single r) { }

    }

    // TypeToken: 0x200002C  // size: 0x10
    public static class V3Tools
    {
        // Methods
        // RVA: 0x03D748B0  token: 0x6000117
        public static System.Single GetYaw(UnityEngine.Vector3 forward) { }
        // RVA: 0x09604910  token: 0x6000118
        public static System.Single GetPitch(UnityEngine.Vector3 forward) { }
        // RVA: 0x09604850  token: 0x6000119
        public static System.Single GetBank(UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        // RVA: 0x09604A00  token: 0x600011A
        public static System.Single GetYaw(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward) { }
        // RVA: 0x09604954  token: 0x600011B
        public static System.Single GetPitch(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward) { }
        // RVA: 0x096046B8  token: 0x600011C
        public static System.Single GetBank(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        // RVA: 0x09604C8C  token: 0x600011D
        public static UnityEngine.Vector3 Lerp(UnityEngine.Vector3 fromVector, UnityEngine.Vector3 toVector, System.Single weight) { }
        // RVA: 0x09604EC0  token: 0x600011E
        public static UnityEngine.Vector3 Slerp(UnityEngine.Vector3 fromVector, UnityEngine.Vector3 toVector, System.Single weight) { }
        // RVA: 0x09604488  token: 0x600011F
        public static UnityEngine.Vector3 ExtractVertical(UnityEngine.Vector3 v, UnityEngine.Vector3 verticalAxis, System.Single weight) { }
        // RVA: 0x09604344  token: 0x6000120
        public static UnityEngine.Vector3 ExtractHorizontal(UnityEngine.Vector3 v, UnityEngine.Vector3 normal, System.Single weight) { }
        // RVA: 0x096045B4  token: 0x6000121
        public static UnityEngine.Vector3 Flatten(UnityEngine.Vector3 v, UnityEngine.Vector3 normal) { }
        // RVA: 0x09604184  token: 0x6000122
        public static UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing) { }
        // RVA: 0x09603DD4  token: 0x6000123
        public static UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing, System.Boolean& changed) { }
        // RVA: 0x09603FA0  token: 0x6000124
        public static UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing, System.Single& clampValue) { }
        // RVA: 0x0285D270  token: 0x6000125
        public static UnityEngine.Vector3 LineToPlane(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint) { }
        // RVA: 0x09604D04  token: 0x6000126
        public static UnityEngine.Vector3 PointToPlane(UnityEngine.Vector3 point, UnityEngine.Vector3 planePosition, UnityEngine.Vector3 planeNormal) { }
        // RVA: 0x09604F40  token: 0x6000127
        public static UnityEngine.Vector3 TransformPointUnscaled(UnityEngine.Transform t, UnityEngine.Vector3 point) { }
        // RVA: 0x09604AB0  token: 0x6000128
        public static UnityEngine.Vector3 InverseTransformPointUnscaled(UnityEngine.Transform t, UnityEngine.Vector3 point) { }
        // RVA: 0x09604B9C  token: 0x6000129
        public static UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 tPos, UnityEngine.Quaternion tRot, UnityEngine.Vector3 tScale, UnityEngine.Vector3 point) { }
        // RVA: 0x0960501C  token: 0x600012A
        public static UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 tPos, UnityEngine.Quaternion tRot, UnityEngine.Vector3 tScale, UnityEngine.Vector3 point) { }
        // RVA: 0x0950BFE0  token: 0x600012B
        public static UnityEngine.Vector3 Div(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }

    }

    // TypeToken: 0x200002D  // size: 0x10
    public static class Warning
    {
        // Fields
        public static System.Boolean logged;  // static @ 0x0

        // Methods
        // RVA: 0x09605188  token: 0x600012C
        public static System.Void Log(System.String message, RootMotion.Warning.Logger logger, System.Boolean logInEditMode) { }
        // RVA: 0x096050E8  token: 0x600012D
        public static System.Void Log(System.String message, UnityEngine.Transform context, System.Boolean logInEditMode) { }

    }

}

namespace RootMotion.Demos
{

    // TypeToken: 0x200002F  // size: 0x70
    public class Navigator
    {
        // Fields
        public System.Boolean activeTargetSeeking;  // 0x10
        public System.Single cornerRadius;  // 0x14
        public System.Single recalculateOnPathDistance;  // 0x18
        public System.Single maxSampleDistance;  // 0x1c
        public System.Single nextPathInterval;  // 0x20
        private UnityEngine.Vector3 <normalizedDeltaPosition>k__BackingField;  // 0x24
        private RootMotion.Demos.Navigator.State <state>k__BackingField;  // 0x30
        private UnityEngine.Transform transform;  // 0x38
        private System.Int32 cornerIndex;  // 0x40
        private UnityEngine.Vector3[] corners;  // 0x48
        private UnityEngine.AI.NavMeshPath path;  // 0x50
        private UnityEngine.Vector3 lastTargetPosition;  // 0x58
        private System.Boolean initiated;  // 0x64
        private System.Single nextPathTime;  // 0x68

        // Properties
        UnityEngine.Vector3 normalizedDeltaPosition { get; /* RVA: 0x03D59780 */ set; /* RVA: 0x03D5A9E0 */ }
        RootMotion.Demos.Navigator.State state { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }

        // Methods
        // RVA: 0x09601D64  token: 0x6000136
        public System.Void Initiate(UnityEngine.Transform transform) { }
        // RVA: 0x09601E44  token: 0x6000137
        public System.Void Update(UnityEngine.Vector3 targetPosition) { }
        // RVA: 0x09601AF0  token: 0x6000138
        private System.Void CalculatePath(UnityEngine.Vector3 targetPosition) { }
        // RVA: 0x09601B74  token: 0x6000139
        private System.Boolean Find(UnityEngine.Vector3 targetPosition) { }
        // RVA: 0x09601E28  token: 0x600013A
        private System.Void Stop() { }
        // RVA: 0x09601D38  token: 0x600013B
        private System.Single HorDistance(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        // RVA: 0x096021FC  token: 0x600013C
        public System.Void Visualize() { }
        // RVA: 0x0960240C  token: 0x600013D
        public System.Void .ctor() { }

    }

}

namespace RootMotion.FinalIK
{

    // TypeToken: 0x2000031  // size: 0x48
    public class BipedIK : RootMotion.SolverManager
    {
        // Fields
        public RootMotion.BipedReferences references;  // 0x38
        public RootMotion.FinalIK.BipedIKSolvers solvers;  // 0x40

        // Methods
        // RVA: 0x095F902C  token: 0x600013E
        private System.Void OpenUserManual() { }
        // RVA: 0x095F8FF8  token: 0x600013F
        private System.Void OpenScriptReference() { }
        // RVA: 0x095F9418  token: 0x6000140
        private System.Void SupportGroup() { }
        // RVA: 0x095F8E5C  token: 0x6000141
        private System.Void ASThread() { }
        // RVA: 0x095F8EF0  token: 0x6000142
        public System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x095F8F64  token: 0x6000143
        public System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x095F9060  token: 0x6000144
        public System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single weight) { }
        // RVA: 0x095F90CC  token: 0x6000145
        public System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single weight) { }
        // RVA: 0x095F9098  token: 0x6000146
        public System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 IKPosition) { }
        // RVA: 0x095F9104  token: 0x6000147
        public System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion IKRotation) { }
        // RVA: 0x095F8F14  token: 0x6000148
        public UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x095F8F88  token: 0x6000149
        public UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x095F9160  token: 0x600014A
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight, System.Single clampWeightHead, System.Single clampWeightEyes) { }
        // RVA: 0x095F9130  token: 0x600014B
        public System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition) { }
        // RVA: 0x095F91CC  token: 0x600014C
        public System.Void SetSpinePosition(UnityEngine.Vector3 spinePosition) { }
        // RVA: 0x095F91FC  token: 0x600014D
        public System.Void SetSpineWeight(System.Single weight) { }
        // RVA: 0x095F8E90  token: 0x600014E
        public RootMotion.FinalIK.IKSolverLimb GetGoalIK(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x095F8FC0  token: 0x600014F
        public System.Void InitiateBipedIK() { }
        // RVA: 0x095F944C  token: 0x6000150
        public System.Void UpdateBipedIK() { }
        // RVA: 0x095F9224  token: 0x6000151
        public System.Void SetToDefaults() { }
        // RVA: 0x0238DCF0  token: 0x6000152
        protected virtual System.Void FixTransforms() { }
        // RVA: 0x0270AC20  token: 0x6000153
        protected virtual System.Void InitiateSolver() { }
        // RVA: 0x0238DF80  token: 0x6000154
        protected virtual System.Void UpdateSolver() { }
        // RVA: 0x095F8FD0  token: 0x6000155
        public System.Void LogWarning(System.String message) { }
        // RVA: 0x029ED080  token: 0x6000156
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x60
    public class BipedIKSolvers
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLimb leftFoot;  // 0x10
        public RootMotion.FinalIK.IKSolverLimb rightFoot;  // 0x18
        public RootMotion.FinalIK.IKSolverLimb leftHand;  // 0x20
        public RootMotion.FinalIK.IKSolverLimb rightHand;  // 0x28
        public RootMotion.FinalIK.IKSolverFABRIK spine;  // 0x30
        public RootMotion.FinalIK.IKSolverLookAt lookAt;  // 0x38
        public RootMotion.FinalIK.IKSolverAim aim;  // 0x40
        public RootMotion.FinalIK.Constraints pelvis;  // 0x48
        private RootMotion.FinalIK.IKSolverLimb[] _limbs;  // 0x50
        private RootMotion.FinalIK.IKSolver[] _ikSolvers;  // 0x58

        // Properties
        RootMotion.FinalIK.IKSolverLimb[] limbs { get; /* RVA: 0x0238E810 */ }
        RootMotion.FinalIK.IKSolver[] ikSolvers { get; /* RVA: 0x095F8D04 */ }

        // Methods
        // RVA: 0x029EDD00  token: 0x6000159
        public System.Void AssignReferences(RootMotion.BipedReferences references) { }
        // RVA: 0x029ED1A0  token: 0x600015A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000033  // size: 0x20
    public abstract class Constraint
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public System.Single weight;  // 0x18

        // Properties
        System.Boolean isValid { get; /* RVA: 0x095FE05C */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600015C
        public virtual System.Void UpdateConstraint() { }
        // RVA: 0x0350B670  token: 0x600015D
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x30
    public class ConstraintPosition : RootMotion.FinalIK.Constraint
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x20

        // Methods
        // RVA: 0x095FDD58  token: 0x600015E
        public virtual System.Void UpdateConstraint() { }
        // RVA: 0x0350B670  token: 0x600015F
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x6000160
        public System.Void .ctor(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000035  // size: 0x48
    public class ConstraintPositionOffset : RootMotion.FinalIK.Constraint
    {
        // Fields
        public UnityEngine.Vector3 offset;  // 0x20
        private UnityEngine.Vector3 defaultLocalPosition;  // 0x2c
        private UnityEngine.Vector3 lastLocalPosition;  // 0x38
        private System.Boolean initiated;  // 0x44

        // Properties
        System.Boolean positionChanged { get; /* RVA: 0x095FDCD4 */ }

        // Methods
        // RVA: 0x095FDB20  token: 0x6000161
        public virtual System.Void UpdateConstraint() { }
        // RVA: 0x0350B670  token: 0x6000162
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x6000163
        public System.Void .ctor(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000036  // size: 0x30
    public class ConstraintRotation : RootMotion.FinalIK.Constraint
    {
        // Fields
        public UnityEngine.Quaternion rotation;  // 0x20

        // Methods
        // RVA: 0x095FDFC4  token: 0x6000165
        public virtual System.Void UpdateConstraint() { }
        // RVA: 0x0350B670  token: 0x6000166
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x6000167
        public System.Void .ctor(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000037  // size: 0x78
    public class ConstraintRotationOffset : RootMotion.FinalIK.Constraint
    {
        // Fields
        public UnityEngine.Quaternion offset;  // 0x20
        private UnityEngine.Quaternion defaultRotation;  // 0x30
        private UnityEngine.Quaternion defaultLocalRotation;  // 0x40
        private UnityEngine.Quaternion lastLocalRotation;  // 0x50
        private UnityEngine.Quaternion defaultTargetLocalRotation;  // 0x60
        private System.Boolean initiated;  // 0x70

        // Properties
        System.Boolean rotationChanged { get; /* RVA: 0x095FDF6C */ }

        // Methods
        // RVA: 0x095FDE04  token: 0x6000168
        public virtual System.Void UpdateConstraint() { }
        // RVA: 0x0350B670  token: 0x6000169
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x600016A
        public System.Void .ctor(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000038  // size: 0x58
    public class Constraints
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public UnityEngine.Transform target;  // 0x18
        public UnityEngine.Vector3 positionOffset;  // 0x20
        public UnityEngine.Vector3 position;  // 0x2c
        public System.Single positionWeight;  // 0x38
        public UnityEngine.Vector3 rotationOffset;  // 0x3c
        public UnityEngine.Vector3 rotation;  // 0x48
        public System.Single rotationWeight;  // 0x54

        // Methods
        // RVA: 0x02E4DC40  token: 0x600016C
        public System.Boolean IsValid() { }
        // RVA: 0x039D9660  token: 0x600016D
        public System.Void Initiate(UnityEngine.Transform transform) { }
        // RVA: 0x02E4D7D0  token: 0x600016E
        public System.Void Update() { }
        // RVA: 0x0350B670  token: 0x600016F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0xB8
    public class Finger
    {
        // Fields
        public System.Single weight;  // 0x10
        public System.Single rotationWeight;  // 0x14
        public RootMotion.FinalIK.Finger.DOF rotationDOF;  // 0x18
        public System.Boolean fixBone1Twist;  // 0x1c
        public UnityEngine.Transform bone1;  // 0x20
        public UnityEngine.Transform bone2;  // 0x28
        public UnityEngine.Transform bone3;  // 0x30
        public UnityEngine.Transform tip;  // 0x38
        public UnityEngine.Transform target;  // 0x40
        private System.Boolean <initiated>k__BackingField;  // 0x48
        private RootMotion.FinalIK.IKSolverLimb solver;  // 0x50
        private UnityEngine.Quaternion bone3RelativeToTarget;  // 0x58
        private UnityEngine.Vector3 bone3DefaultLocalPosition;  // 0x68
        private UnityEngine.Quaternion bone3DefaultLocalRotation;  // 0x74
        private UnityEngine.Vector3 bone1Axis;  // 0x84
        private UnityEngine.Vector3 tipAxis;  // 0x90
        private UnityEngine.Vector3 bone1TwistAxis;  // 0x9c
        private UnityEngine.Vector3 defaultBendNormal;  // 0xa8

        // Properties
        System.Boolean initiated { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }
        UnityEngine.Vector3 IKPosition { get; /* RVA: 0x095FF1E0 */ set; /* RVA: 0x095FF230 */ }
        UnityEngine.Quaternion IKRotation { get; /* RVA: 0x095FF20C */ set; /* RVA: 0x095FF25C */ }

        // Methods
        // RVA: 0x095FEA44  token: 0x6000176
        public System.Boolean IsValid(System.String& errorMessage) { }
        // RVA: 0x095FE24C  token: 0x6000177
        public System.Void Initiate(UnityEngine.Transform hand, System.Int32 index) { }
        // RVA: 0x095FE178  token: 0x6000178
        public System.Void FixTransforms() { }
        // RVA: 0x095FEB0C  token: 0x6000179
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x095FEBC4  token: 0x600017A
        public System.Void Update(System.Single masterWeight) { }
        // RVA: 0x03D74330  token: 0x600017B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B  // size: 0x50
    public class FingerRig : RootMotion.SolverManager
    {
        // Fields
        public System.Single weight;  // 0x38
        public RootMotion.FinalIK.Finger[] fingers;  // 0x40
        private System.Boolean <initiated>k__BackingField;  // 0x48

        // Properties
        System.Boolean initiated { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }

        // Methods
        // RVA: 0x09605EB4  token: 0x600017E
        public System.Boolean IsValid(System.String& errorMessage) { }
        // RVA: 0x09605B58  token: 0x600017F
        public System.Void AutoDetect() { }
        // RVA: 0x096059D4  token: 0x6000180
        public System.Void AddFinger(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform tip, UnityEngine.Transform target) { }
        // RVA: 0x09605F1C  token: 0x6000181
        public System.Void RemoveFinger(System.Int32 index) { }
        // RVA: 0x09605918  token: 0x6000182
        private System.Void AddChildrenRecursive(UnityEngine.Transform parent, UnityEngine.Transform[]& array) { }
        // RVA: 0x09605E1C  token: 0x6000183
        protected virtual System.Void InitiateSolver() { }
        // RVA: 0x0960609C  token: 0x6000184
        public System.Void UpdateFingerSolvers() { }
        // RVA: 0x09605DB4  token: 0x6000185
        public System.Void FixFingerTransforms() { }
        // RVA: 0x09606050  token: 0x6000186
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x096060FC  token: 0x6000187
        protected virtual System.Void UpdateSolver() { }
        // RVA: 0x09605E08  token: 0x6000188
        protected virtual System.Void FixTransforms() { }
        // RVA: 0x09606104  token: 0x6000189
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0x50
    public abstract class Grounder : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single weight;  // 0x18
        public System.Single maintianPelvisFootWeight;  // 0x1c
        public System.Single footAdsorbWeight;  // 0x20
        public RootMotion.FinalIK.Grounding solver;  // 0x28
        public RootMotion.FinalIK.Grounder.GrounderDelegate OnPreGrounder;  // 0x30
        public RootMotion.FinalIK.Grounder.GrounderDelegate OnPostGrounder;  // 0x38
        public RootMotion.FinalIK.Grounder.GrounderDelegate OnPostIK;  // 0x40
        private System.Boolean <initiated>k__BackingField;  // 0x48

        // Properties
        System.Boolean initiated { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600018A
        public virtual System.Void ResetPosition() { }
        // RVA: 0x0960B8E0  token: 0x600018D
        protected UnityEngine.Vector3 GetSpineOffsetTarget() { }
        // RVA: 0x095F8FD0  token: 0x600018E
        protected System.Void LogWarning(System.String message) { }
        // RVA: 0x0960B538  token: 0x600018F
        private UnityEngine.Vector3 GetLegSpineBendVector(RootMotion.FinalIK.Grounding.Leg leg) { }
        // RVA: 0x0960B6E4  token: 0x6000190
        private UnityEngine.Vector3 GetLegSpineTangent(RootMotion.FinalIK.Grounding.Leg leg) { }
        // RVA: -1  // abstract  token: 0x6000191
        protected virtual System.Void OpenUserManual() { }
        // RVA: -1  // abstract  token: 0x6000192
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x035217C0  token: 0x6000193
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0xB8
    public class GrounderBipedIK : RootMotion.FinalIK.Grounder
    {
        // Fields
        public RootMotion.FinalIK.BipedIK ik;  // 0x50
        public System.Single spineBend;  // 0x58
        public System.Single spineSpeed;  // 0x5c
        private UnityEngine.Transform[] feet;  // 0x60
        private UnityEngine.Quaternion[] footRotations;  // 0x68
        private UnityEngine.Vector3 animatedPelvisLocalPosition;  // 0x70
        private UnityEngine.Vector3 solvedPelvisLocalPosition;  // 0x7c
        private UnityEngine.Vector3 spineOffset;  // 0x88
        private System.Single lastWeight;  // 0x94
        private System.Single lastAdsorbWeight;  // 0x98
        private System.Single rightFootOffsetY;  // 0x9c
        private System.Single leftFootOffsetY;  // 0xa0
        private System.Single rightFootOri;  // 0xa4
        private System.Single leftFootOri;  // 0xa8
        public UnityEngine.Transform ikOriReferenceBone;  // 0xb0

        // Properties
        System.Single RightFootOffsetY { get; /* RVA: 0x03D58000 */ }
        System.Single LeftFootOffsetY { get; /* RVA: 0x03D58340 */ }
        System.Single RightFootOri { get; /* RVA: 0x03D56EE0 */ }
        System.Single LeftFootOri { get; /* RVA: 0x03D58510 */ }

        // Methods
        // RVA: 0x09606A68  token: 0x6000198
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x09606A34  token: 0x6000199
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x09606A9C  token: 0x600019A
        public virtual System.Void ResetPosition() { }
        // RVA: 0x030DB2A0  token: 0x600019F
        private System.Boolean IsReadyToInitiate() { }
        // RVA: 0x030DB240  token: 0x60001A0
        private System.Void Update() { }
        // RVA: 0x030DB360  token: 0x60001A1
        private System.Void Initiate() { }
        // RVA: 0x03D4DFF0  token: 0x60001A2
        private System.Void OnDisable() { }
        // RVA: 0x02648710  token: 0x60001A3
        private System.Void OnSolverUpdate() { }
        // RVA: 0x026492D0  token: 0x60001A4
        private System.Void SetLegIK(RootMotion.FinalIK.IKSolverLimb limb, System.Int32 index) { }
        // RVA: 0x026483A0  token: 0x60001A5
        private System.Void OnPostSolverUpdate() { }
        // RVA: 0x03D43420  token: 0x60001A6
        private System.Void OnDestroy() { }
        // RVA: 0x02503630  token: 0x60001A7
        private UnityEngine.Quaternion ClampPitchAndRollAroundForward(UnityEngine.Quaternion Q, UnityEngine.Quaternion calfQ, System.Single minPitch, System.Single maxPitch, System.Single minRoll, System.Single maxRoll) { }
        // RVA: 0x02503B30  token: 0x60001A8
        private System.Single NormalizeAngle(System.Single angle) { }
        // RVA: 0x03521730  token: 0x60001A9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003F  // size: 0x80
    public class GrounderFBBIK : RootMotion.FinalIK.Grounder
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedIK ik;  // 0x50
        public System.Single spineBend;  // 0x58
        public System.Single spineSpeed;  // 0x5c
        public RootMotion.FinalIK.GrounderFBBIK.SpineEffector[] spine;  // 0x60
        private UnityEngine.Transform[] feet;  // 0x68
        private UnityEngine.Vector3 spineOffset;  // 0x70
        private System.Boolean firstSolve;  // 0x7c

        // Methods
        // RVA: 0x09607680  token: 0x60001AA
        private System.Void OpenTutorial() { }
        // RVA: 0x096076B4  token: 0x60001AB
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0960764C  token: 0x60001AC
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x096076E8  token: 0x60001AD
        public virtual System.Void ResetPosition() { }
        // RVA: 0x09606DEC  token: 0x60001AE
        private System.Boolean IsReadyToInitiate() { }
        // RVA: 0x096078D0  token: 0x60001AF
        private System.Void Update() { }
        // RVA: 0x03D566D0  token: 0x60001B0
        private System.Void FixedUpdate() { }
        // RVA: 0x03D566D0  token: 0x60001B1
        private System.Void LateUpdate() { }
        // RVA: 0x09606ADC  token: 0x60001B2
        private System.Void Initiate() { }
        // RVA: 0x09607170  token: 0x60001B3
        private System.Void OnSolverUpdate() { }
        // RVA: 0x09607720  token: 0x60001B4
        private System.Void SetLegIK(RootMotion.FinalIK.IKEffector effector, RootMotion.FinalIK.Grounding.Leg leg) { }
        // RVA: 0x09607048  token: 0x60001B5
        private System.Void OnDrawGizmosSelected() { }
        // RVA: 0x09607158  token: 0x60001B6
        private System.Void OnPostSolverUpdate() { }
        // RVA: 0x09606E64  token: 0x60001B7
        private System.Void OnDestroy() { }
        // RVA: 0x0960792C  token: 0x60001B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000041  // size: 0xB8
    public class GrounderIK : RootMotion.FinalIK.Grounder
    {
        // Fields
        public RootMotion.FinalIK.IK[] legs;  // 0x50
        public UnityEngine.Transform pelvis;  // 0x58
        public UnityEngine.Transform characterRoot;  // 0x60
        public System.Single rootRotationWeight;  // 0x68
        public System.Single rootRotationSpeed;  // 0x6c
        public System.Single maxRootRotationAngle;  // 0x70
        private UnityEngine.Transform[] feet;  // 0x78
        private UnityEngine.Quaternion[] footRotations;  // 0x80
        private UnityEngine.Vector3 animatedPelvisLocalPosition;  // 0x88
        private UnityEngine.Vector3 solvedPelvisLocalPosition;  // 0x94
        private System.Int32 solvedFeet;  // 0xa0
        private System.Boolean solved;  // 0xa4
        private System.Single lastWeight;  // 0xa8
        private UnityEngine.Rigidbody characterRootRigidbody;  // 0xb0

        // Methods
        // RVA: 0x096086DC  token: 0x60001BB
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x096086A8  token: 0x60001BC
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x09608710  token: 0x60001BD
        public virtual System.Void ResetPosition() { }
        // RVA: 0x09607E10  token: 0x60001BE
        private System.Boolean IsReadyToInitiate() { }
        // RVA: 0x096081B4  token: 0x60001BF
        private System.Void OnDisable() { }
        // RVA: 0x09608C80  token: 0x60001C0
        private System.Void Update() { }
        // RVA: 0x096079B4  token: 0x60001C1
        private System.Void Initiate() { }
        // RVA: 0x09608440  token: 0x60001C2
        private System.Void OnSolverUpdate() { }
        // RVA: 0x09608998  token: 0x60001C3
        private System.Void SetLegIK(System.Int32 index) { }
        // RVA: 0x0960826C  token: 0x60001C4
        private System.Void OnPostSolverUpdate() { }
        // RVA: 0x09607F8C  token: 0x60001C5
        private System.Void OnDestroy() { }
        // RVA: 0x0960907C  token: 0x60001C6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x150
    public class GrounderQuadruped : RootMotion.FinalIK.Grounder
    {
        // Fields
        public RootMotion.FinalIK.Grounding forelegSolver;  // 0x50
        public System.Single rootRotationWeight;  // 0x58
        public System.Single minRootRotation;  // 0x5c
        public System.Single maxRootRotation;  // 0x60
        public System.Single rootRotationSpeed;  // 0x64
        public System.Single maxLegOffset;  // 0x68
        public System.Single maxForeLegOffset;  // 0x6c
        public System.Single maintainHeadRotationWeight;  // 0x70
        public UnityEngine.Transform characterRoot;  // 0x78
        public UnityEngine.Transform pelvis;  // 0x80
        public UnityEngine.Transform lastSpineBone;  // 0x88
        public UnityEngine.Transform head;  // 0x90
        public RootMotion.FinalIK.IK[] legs;  // 0x98
        public RootMotion.FinalIK.IK[] forelegs;  // 0xa0
        public UnityEngine.Vector3 gravity;  // 0xa8
        private RootMotion.FinalIK.GrounderQuadruped.Foot[] feet;  // 0xb8
        private UnityEngine.Vector3 animatedPelvisLocalPosition;  // 0xc0
        private UnityEngine.Quaternion animatedPelvisLocalRotation;  // 0xcc
        private UnityEngine.Quaternion animatedHeadLocalRotation;  // 0xdc
        private UnityEngine.Vector3 solvedPelvisLocalPosition;  // 0xec
        private UnityEngine.Quaternion solvedPelvisLocalRotation;  // 0xf8
        private UnityEngine.Quaternion solvedHeadLocalRotation;  // 0x108
        private System.Int32 solvedFeet;  // 0x118
        private System.Boolean solved;  // 0x11c
        private System.Single angle;  // 0x120
        private UnityEngine.Transform forefeetRoot;  // 0x128
        private UnityEngine.Quaternion headRotation;  // 0x130
        private System.Single lastWeight;  // 0x140
        private UnityEngine.Rigidbody characterRootRigidbody;  // 0x148

        // Methods
        // RVA: 0x0960A948  token: 0x60001C7
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0960A914  token: 0x60001C8
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0960A97C  token: 0x60001C9
        public virtual System.Void ResetPosition() { }
        // RVA: 0x09609BAC  token: 0x60001CA
        private System.Boolean IsReadyToInitiate() { }
        // RVA: 0x09609A64  token: 0x60001CB
        private System.Boolean IsReadyToInitiateLegs(RootMotion.FinalIK.IK[] ikComponents) { }
        // RVA: 0x09609DC8  token: 0x60001CC
        private System.Void OnDisable() { }
        // RVA: 0x0960B3F0  token: 0x60001CD
        private System.Void Update() { }
        // RVA: 0x09609688  token: 0x60001CE
        private System.Void Initiate() { }
        // RVA: 0x09609324  token: 0x60001CF
        private UnityEngine.Transform[] InitiateFeet(RootMotion.FinalIK.IK[] ikComponents, RootMotion.FinalIK.GrounderQuadruped.Foot[]& f, System.Int32 indexOffset) { }
        // RVA: 0x09609CAC  token: 0x60001D0
        private System.Void LateUpdate() { }
        // RVA: 0x0960AB40  token: 0x60001D1
        private System.Void RootRotation() { }
        // RVA: 0x0960A10C  token: 0x60001D2
        private System.Void OnSolverUpdate() { }
        // RVA: 0x0960B158  token: 0x60001D3
        private System.Void UpdateForefeetRoot() { }
        // RVA: 0x0960AFEC  token: 0x60001D4
        private System.Void SetFootIK(RootMotion.FinalIK.GrounderQuadruped.Foot foot, System.Single maxOffset) { }
        // RVA: 0x09609E34  token: 0x60001D5
        private System.Void OnPostSolverUpdate() { }
        // RVA: 0x09609D8C  token: 0x60001D6
        private System.Void OnDestroy() { }
        // RVA: 0x09609108  token: 0x60001D7
        private System.Void DestroyLegs(RootMotion.FinalIK.IK[] ikComponents) { }
        // RVA: 0x0960B450  token: 0x60001D8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x190
    public class Grounding
    {
        // Fields
        public UnityEngine.Transform IKFootBoneL;  // 0x10
        public UnityEngine.Transform IKFootBoneR;  // 0x18
        public System.Single floorLogicTheta;  // 0x20
        public System.Single floorAnimTheta;  // 0x24
        public System.Single floorPredictTheta;  // 0x28
        public System.Single floorFeetThetaByFoot;  // 0x2c
        public System.Single floorFeetThetaByRoot;  // 0x30
        public System.Single floorFeetThetaByLogic;  // 0x34
        public System.Single betweenFeetDistance;  // 0x38
        public System.Boolean isMoving;  // 0x3c
        public System.Boolean isAccelerating;  // 0x3d
        public System.Boolean isPlayingMontage;  // 0x3e
        public System.Boolean isOnMovableBase;  // 0x3f
        public System.Single SG_timeRef;  // 0x40
        public System.Single gait;  // 0x44
        public System.Single startAnimWeight;  // 0x48
        public UnityEngine.Vector3 playerSpeed;  // 0x4c
        private System.Boolean m_isAcceleratingLastFrame;  // 0x58
        public System.Boolean isLastFrameInvalid;  // 0x59
        public System.Single maxLegLength;  // 0x5c
        public System.Single maxFeetOffset;  // 0x60
        public System.Single minPelvisHeight;  // 0x64
        public UnityEngine.LayerMask layers;  // 0x68
        public System.Single maxStep;  // 0x6c
        public System.Single heightOffset;  // 0x70
        public System.Single footSpeed;  // 0x74
        public System.Single footRadius;  // 0x78
        public System.Single footCenterOffset;  // 0x7c
        public System.Single prediction;  // 0x80
        public System.Single footRotationWeight;  // 0x84
        public System.Single footRotationSpeed;  // 0x88
        public System.Single maxFootRotationAngleFore;  // 0x8c
        public System.Single maxFootRotationAngleBack;  // 0x90
        public System.Single maxFootRotationAngleIn;  // 0x94
        public System.Single maxFootRotationAngleOut;  // 0x98
        public System.Boolean rotateSolver;  // 0x9c
        public System.Single pelvisSpeed;  // 0xa0
        public System.Single pelvisSpeedXZ;  // 0xa4
        public System.Single pelvisDamper;  // 0xa8
        public System.Single lowerPelvisWeight;  // 0xac
        public System.Single liftPelvisWeight;  // 0xb0
        public System.Single rootSphereCastRadius;  // 0xb4
        public System.Boolean overstepFallsDown;  // 0xb8
        public RootMotion.FinalIK.Grounding.Quality quality;  // 0xbc
        private RootMotion.BipedReferences <references>k__BackingField;  // 0xc0
        private RootMotion.FinalIK.Grounding.Leg[] <legs>k__BackingField;  // 0xc8
        private RootMotion.FinalIK.Grounding.Pelvis <pelvis>k__BackingField;  // 0xd0
        private System.Boolean <isGrounded>k__BackingField;  // 0xd8
        private UnityEngine.Transform <root>k__BackingField;  // 0xe0
        private UnityEngine.RaycastHit <rootHit>k__BackingField;  // 0xe8
        public RootMotion.FinalIK.Grounding.OnRaycastDelegate Raycast;  // 0x128
        public RootMotion.FinalIK.Grounding.OnCapsuleCastDelegate CapsuleCast;  // 0x130
        public RootMotion.FinalIK.Grounding.OnSphereCastDelegate SphereCast;  // 0x138
        private UnityEngine.Transform <entityTransform>k__BackingField;  // 0x140
        private System.Boolean <entityIsOnMovableBase>k__BackingField;  // 0x148
        private UnityEngine.Vector3 <entityRelativePosition>k__BackingField;  // 0x14c
        private UnityEngine.Quaternion <entityRelativeRotation>k__BackingField;  // 0x158
        private System.Boolean lastIsDependingLeftLeg;  // 0x168
        private System.Boolean isSameLegWithLastFrame;  // 0x169
        private System.Single rootDeltaAngle;  // 0x16c
        private System.Single pelvisForwardOffset;  // 0x170
        private UnityEngine.Vector3 m_lastFrameForwardVec;  // 0x174
        private System.Boolean lastIsUsingLoswest;  // 0x180
        private System.Single m_actualMaxFootOffset;  // 0x184
        public System.Single forwardFeetOffset;  // 0x188
        public System.Boolean isUsingLoswest;  // 0x18c
        public System.Boolean isDependingLeftLeg;  // 0x18d
        private System.Boolean initiated;  // 0x18e

        // Properties
        RootMotion.BipedReferences references { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x058B426C */ }
        RootMotion.FinalIK.Grounding.Leg[] legs { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x058B4280 */ }
        RootMotion.FinalIK.Grounding.Pelvis pelvis { get; /* RVA: 0x03D50050 */ set; /* RVA: 0x0554A7E0 */ }
        System.Boolean isGrounded { get; /* RVA: 0x03D51180 */ set; /* RVA: 0x03D511E0 */ }
        UnityEngine.Transform root { get; /* RVA: 0x03D51140 */ set; /* RVA: 0x0589D964 */ }
        UnityEngine.RaycastHit rootHit { get; /* RVA: 0x03D6B8F0 */ set; /* RVA: 0x03D74930 */ }
        System.Boolean rootGrounded { get; /* RVA: 0x0232EB60 */ }
        UnityEngine.Transform entityTransform { get; /* RVA: 0x03D57300 */ set; /* RVA: 0x058B3FD8 */ }
        System.Boolean entityIsOnMovableBase { get; /* RVA: 0x03D57CB0 */ set; /* RVA: 0x03D5A1F0 */ }
        UnityEngine.Vector3 entityRelativePosition { get; /* RVA: 0x03D748D0 */ set; /* RVA: 0x03D74900 */ }
        UnityEngine.Quaternion entityRelativeRotation { get; /* RVA: 0x03D748F0 */ set; /* RVA: 0x03D74920 */ }
        UnityEngine.Vector3 up { get; /* RVA: 0x02388E40 */ }
        UnityEngine.Vector3 forward { get; /* RVA: 0x0281B940 */ }
        System.Boolean useRootRotation { get; /* RVA: 0x02388EA0 */ }

        // Methods
        // RVA: 0x023884A0  token: 0x60001DA
        private System.Void _UpdateFloorPredictTheta() { }
        // RVA: 0x023887F0  token: 0x60001DB
        private System.Void _UpdateFloorFeetThetaByFoot() { }
        // RVA: 0x0281B6E0  token: 0x60001DC
        private System.Void _UpdateFloorFeetThetaByRoot() { }
        // RVA: 0x027E9AC0  token: 0x60001F2
        public UnityEngine.RaycastHit GetRootHit(System.Single maxDistanceMlp) { }
        // RVA: 0x030DBBD0  token: 0x60001F3
        public System.Boolean IsValid(System.String& errorMessage) { }
        // RVA: 0x030DB6F0  token: 0x60001F4
        public System.Void Initiate(UnityEngine.Transform root, UnityEngine.Transform[] feet, RootMotion.BipedReferences references) { }
        // RVA: 0x02390970  token: 0x60001F5
        public System.Void Update() { }
        // RVA: 0x0960BBB0  token: 0x60001F6
        public UnityEngine.Vector3 GetLegsPlaneNormal() { }
        // RVA: 0x0960BDBC  token: 0x60001F7
        public System.Void Reset() { }
        // RVA: 0x0960BDA4  token: 0x60001F8
        public System.Void LogWarning(System.String message) { }
        // RVA: 0x02388DF0  token: 0x60001FB
        public System.Single GetVerticalOffset(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        // RVA: 0x0960B9C0  token: 0x60001FC
        public UnityEngine.Vector3 Flatten(UnityEngine.Vector3 v) { }
        // RVA: 0x0960BAB4  token: 0x60001FE
        public UnityEngine.Vector3 GetFootCenterOffset() { }
        // RVA: 0x03521850  token: 0x60001FF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004B  // size: 0x40
    public class AimIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverAim solver;  // 0x38

        // Methods
        // RVA: 0x0960532C  token: 0x6000255
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x096052C4  token: 0x6000256
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x096052F8  token: 0x6000257
        private System.Void OpenSetupTutorial() { }
        // RVA: 0x09605360  token: 0x6000258
        private System.Void SupportGroup() { }
        // RVA: 0x09605290  token: 0x6000259
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x600025A
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x09605394  token: 0x600025B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x40
    public class ArmIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverArm solver;  // 0x38

        // Methods
        // RVA: 0x09605470  token: 0x600025C
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0960543C  token: 0x600025D
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x096054A4  token: 0x600025E
        private System.Void SupportGroup() { }
        // RVA: 0x09605408  token: 0x600025F
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x6000260
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x096054D8  token: 0x6000261
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004D  // size: 0x40
    public class CCDIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverCCD solver;  // 0x38

        // Methods
        // RVA: 0x096055B4  token: 0x6000262
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x09605580  token: 0x6000263
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x096055E8  token: 0x6000264
        private System.Void SupportGroup() { }
        // RVA: 0x0960554C  token: 0x6000265
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x6000266
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0960561C  token: 0x6000267
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x40
    public class FABRIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverFABRIK solver;  // 0x38

        // Methods
        // RVA: 0x0960583C  token: 0x6000268
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x09605808  token: 0x6000269
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x09605870  token: 0x600026A
        private System.Void SupportGroup() { }
        // RVA: 0x096057D4  token: 0x600026B
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x600026C
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x096058A4  token: 0x600026D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004F  // size: 0x40
    public class FABRIKRoot : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverFABRIKRoot solver;  // 0x38

        // Methods
        // RVA: 0x096056F8  token: 0x600026E
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x096056C4  token: 0x600026F
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0960572C  token: 0x6000270
        private System.Void SupportGroup() { }
        // RVA: 0x09605690  token: 0x6000271
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x6000272
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x09605760  token: 0x6000273
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000050  // size: 0x48
    public class FullBodyBipedIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.BipedReferences references;  // 0x38
        public RootMotion.FinalIK.IKSolverFullBodyBiped solver;  // 0x40

        // Methods
        // RVA: 0x09606364  token: 0x6000274
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x096062FC  token: 0x6000275
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x09606330  token: 0x6000276
        private System.Void OpenSetupTutorial() { }
        // RVA: 0x096062C8  token: 0x6000277
        private System.Void OpenInspectorTutorial() { }
        // RVA: 0x09606954  token: 0x6000278
        private System.Void SupportGroup() { }
        // RVA: 0x096061BC  token: 0x6000279
        private System.Void ASThread() { }
        // RVA: 0x09606918  token: 0x600027A
        public System.Void SetReferences(RootMotion.BipedReferences references, UnityEngine.Transform rootNode) { }
        // RVA: 0x03D4E2B0  token: 0x600027B
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x09606398  token: 0x600027C
        public System.Boolean ReferencesError(System.String& errorMessage) { }
        // RVA: 0x09606578  token: 0x600027D
        public System.Boolean ReferencesWarning(System.String& warningMessage) { }
        // RVA: 0x096068EC  token: 0x600027E
        private System.Void Reinitiate() { }
        // RVA: 0x096061F0  token: 0x600027F
        private System.Void AutoDetectReferences() { }
        // RVA: 0x09606988  token: 0x6000280
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000051  // size: 0x38
    public abstract class IK : RootMotion.SolverManager
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000281
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0961E4CC  token: 0x6000282
        protected virtual System.Void UpdateSolver() { }
        // RVA: 0x0961E470  token: 0x6000283
        protected virtual System.Void InitiateSolver() { }
        // RVA: 0x0961E42C  token: 0x6000284
        protected virtual System.Void FixTransforms() { }
        // RVA: -1  // abstract  token: 0x6000285
        protected virtual System.Void OpenUserManual() { }
        // RVA: -1  // abstract  token: 0x6000286
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x042726E8  token: 0x6000287
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000052  // size: 0x30
    public class IKExecutionOrder : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.IK[] IKComponents;  // 0x18
        public UnityEngine.Animator animator;  // 0x20
        private System.Boolean fixedFrame;  // 0x28

        // Properties
        System.Boolean animatePhysics { get; /* RVA: 0x096193F4 */ }

        // Methods
        // RVA: 0x09619374  token: 0x6000289
        private System.Void Start() { }
        // RVA: 0x096193C8  token: 0x600028A
        private System.Void Update() { }
        // RVA: 0x096192D0  token: 0x600028B
        private System.Void FixedUpdate() { }
        // RVA: 0x09619300  token: 0x600028C
        private System.Void LateUpdate() { }
        // RVA: 0x09619260  token: 0x600028D
        private System.Void FixTransforms() { }
        // RVA: 0x0426FE60  token: 0x600028E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x40
    public class LegIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLeg solver;  // 0x38

        // Methods
        // RVA: 0x0961E60C  token: 0x600028F
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0961E5D8  token: 0x6000290
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0961E640  token: 0x6000291
        private System.Void SupportGroup() { }
        // RVA: 0x0961E5A4  token: 0x6000292
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x6000293
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0961E674  token: 0x6000294
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000054  // size: 0x40
    public class LimbIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLimb solver;  // 0x38

        // Methods
        // RVA: 0x0961E750  token: 0x6000295
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0961E71C  token: 0x6000296
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0961E784  token: 0x6000297
        private System.Void SupportGroup() { }
        // RVA: 0x0961E6E8  token: 0x6000298
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x6000299
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0961E7B8  token: 0x600029A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x40
    public class LookAtIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLookAt solver;  // 0x38

        // Methods
        // RVA: 0x0961E894  token: 0x600029B
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0961E860  token: 0x600029C
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0961E8C8  token: 0x600029D
        private System.Void SupportGroup() { }
        // RVA: 0x0961E82C  token: 0x600029E
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x600029F
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0961E8FC  token: 0x60002A0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000056  // size: 0x40
    public class TrigonometricIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverTrigonometric solver;  // 0x38

        // Methods
        // RVA: 0x0961FD54  token: 0x60002A1
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0961FD20  token: 0x60002A2
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0961FD88  token: 0x60002A3
        private System.Void SupportGroup() { }
        // RVA: 0x0961FCEC  token: 0x60002A4
        private System.Void ASThread() { }
        // RVA: 0x03D4E2A0  token: 0x60002A5
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0961FDBC  token: 0x60002A6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000057  // size: 0x48
    public class VRIK : RootMotion.FinalIK.IK
    {
        // Fields
        public RootMotion.FinalIK.VRIK.References references;  // 0x38
        public RootMotion.FinalIK.IKSolverVR solver;  // 0x40

        // Methods
        // RVA: 0x0961FF50  token: 0x60002A7
        protected virtual System.Void OpenUserManual() { }
        // RVA: 0x0961FEE8  token: 0x60002A8
        protected virtual System.Void OpenScriptReference() { }
        // RVA: 0x0961FF1C  token: 0x60002A9
        private System.Void OpenSetupTutorial() { }
        // RVA: 0x0961FE30  token: 0x60002AA
        public System.Void AutoDetectReferences() { }
        // RVA: 0x0961FE54  token: 0x60002AB
        public System.Void GuessHandOrientations() { }
        // RVA: 0x03D4E2B0  token: 0x60002AC
        public virtual RootMotion.FinalIK.IKSolver GetIKSolver() { }
        // RVA: 0x0961FE80  token: 0x60002AD
        protected virtual System.Void InitiateSolver() { }
        // RVA: 0x0961FF84  token: 0x60002AE
        protected virtual System.Void UpdateSolver() { }
        // RVA: 0x096200D8  token: 0x60002AF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x28
    public class FABRIKChain
    {
        // Fields
        public RootMotion.FinalIK.FABRIK ik;  // 0x10
        public System.Single pull;  // 0x18
        public System.Single pin;  // 0x1c
        public System.Int32[] children;  // 0x20

        // Methods
        // RVA: 0x0960F9CC  token: 0x60002B6
        public System.Boolean IsValid(System.String& message) { }
        // RVA: 0x0960F9A8  token: 0x60002B7
        public System.Void Initiate() { }
        // RVA: 0x0960FA7C  token: 0x60002B8
        public System.Void Stage1(RootMotion.FinalIK.FABRIKChain[] chain) { }
        // RVA: 0x0960FB70  token: 0x60002B9
        public System.Void Stage2(UnityEngine.Vector3 rootPosition, RootMotion.FinalIK.FABRIKChain[] chain) { }
        // RVA: 0x0960F6AC  token: 0x60002BA
        private UnityEngine.Vector3 GetCentroid(RootMotion.FinalIK.FABRIKChain[] chain) { }
        // RVA: 0x0960FC98  token: 0x60002BB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005A  // size: 0x78
    public class FBBIKArmBending : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedIK ik;  // 0x18
        public UnityEngine.Vector3 bendDirectionOffsetLeft;  // 0x20
        public UnityEngine.Vector3 bendDirectionOffsetRight;  // 0x2c
        public UnityEngine.Vector3 characterSpaceBendOffsetLeft;  // 0x38
        public UnityEngine.Vector3 characterSpaceBendOffsetRight;  // 0x44
        private UnityEngine.Quaternion leftHandTargetRotation;  // 0x50
        private UnityEngine.Quaternion rightHandTargetRotation;  // 0x60
        private System.Boolean initiated;  // 0x70

        // Methods
        // RVA: 0x0960FCE8  token: 0x60002BC
        private System.Void LateUpdate() { }
        // RVA: 0x0961042C  token: 0x60002BD
        private System.Void OnPostFBBIK() { }
        // RVA: 0x09610304  token: 0x60002BE
        private System.Void OnDestroy() { }
        // RVA: 0x0426FE60  token: 0x60002BF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x170
    public class FBBIKHeadEffector : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedIK ik;  // 0x18
        public System.Single positionWeight;  // 0x20
        public System.Single bodyWeight;  // 0x24
        public System.Single thighWeight;  // 0x28
        public System.Boolean handsPullBody;  // 0x2c
        public System.Single rotationWeight;  // 0x30
        public System.Single bodyClampWeight;  // 0x34
        public System.Single headClampWeight;  // 0x38
        public System.Single bendWeight;  // 0x3c
        public RootMotion.FinalIK.FBBIKHeadEffector.BendBone[] bendBones;  // 0x40
        public System.Single CCDWeight;  // 0x48
        public System.Single roll;  // 0x4c
        public System.Single damper;  // 0x50
        public UnityEngine.Transform[] CCDBones;  // 0x58
        public System.Single postStretchWeight;  // 0x60
        public System.Single maxStretch;  // 0x64
        public System.Single stretchDamper;  // 0x68
        public System.Boolean fixHead;  // 0x6c
        public UnityEngine.Transform[] stretchBones;  // 0x70
        public UnityEngine.Vector3 chestDirection;  // 0x78
        public System.Single chestDirectionWeight;  // 0x84
        public UnityEngine.Transform[] chestBones;  // 0x88
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostHeadEffectorFK;  // 0x90
        private UnityEngine.Vector3 offset;  // 0x98
        private UnityEngine.Vector3 headToBody;  // 0xa4
        private UnityEngine.Vector3 shoulderCenterToHead;  // 0xb0
        private UnityEngine.Vector3 headToLeftThigh;  // 0xbc
        private UnityEngine.Vector3 headToRightThigh;  // 0xc8
        private UnityEngine.Vector3 leftShoulderPos;  // 0xd4
        private UnityEngine.Vector3 rightShoulderPos;  // 0xe0
        private System.Single shoulderDist;  // 0xec
        private System.Single leftShoulderDist;  // 0xf0
        private System.Single rightShoulderDist;  // 0xf4
        private UnityEngine.Quaternion chestRotation;  // 0xf8
        private UnityEngine.Quaternion headRotationRelativeToRoot;  // 0x108
        private UnityEngine.Quaternion[] ccdDefaultLocalRotations;  // 0x118
        private UnityEngine.Vector3 headLocalPosition;  // 0x120
        private UnityEngine.Quaternion headLocalRotation;  // 0x12c
        private UnityEngine.Vector3[] stretchLocalPositions;  // 0x140
        private UnityEngine.Quaternion[] stretchLocalRotations;  // 0x148
        private UnityEngine.Vector3[] chestLocalPositions;  // 0x150
        private UnityEngine.Quaternion[] chestLocalRotations;  // 0x158
        private System.Int32 bendBonesCount;  // 0x160
        private System.Int32 ccdBonesCount;  // 0x164
        private System.Int32 stretchBonesCount;  // 0x168
        private System.Int32 chestBonesCount;  // 0x16c

        // Methods
        // RVA: 0x096137B8  token: 0x60002C0
        private System.Void Start() { }
        // RVA: 0x09612A80  token: 0x60002C1
        private System.Void OnStoreDefaultLocalState() { }
        // RVA: 0x09611C18  token: 0x60002C2
        private System.Void OnFixTransforms() { }
        // RVA: 0x09612204  token: 0x60002C3
        private System.Void OnPreRead() { }
        // RVA: 0x09613488  token: 0x60002C4
        private System.Void SpineBend() { }
        // RVA: 0x09610600  token: 0x60002C5
        private System.Void CCDPass() { }
        // RVA: 0x09610C34  token: 0x60002C6
        private System.Void Iterate(System.Int32 iteration) { }
        // RVA: 0x09612004  token: 0x60002C7
        private System.Void OnPostUpdate() { }
        // RVA: 0x09610988  token: 0x60002C8
        private System.Void ChestDirection() { }
        // RVA: 0x09612FB4  token: 0x60002C9
        private System.Void PostStretching() { }
        // RVA: 0x096116E4  token: 0x60002CA
        private System.Void LerpSolverPosition(RootMotion.FinalIK.IKEffector effector, UnityEngine.Vector3 position, System.Single weight, UnityEngine.Vector3 offset) { }
        // RVA: 0x0961331C  token: 0x60002CB
        private System.Void Solve(UnityEngine.Vector3& pos1, UnityEngine.Vector3& pos2, System.Single nominalDistance) { }
        // RVA: 0x09611804  token: 0x60002CC
        private System.Void OnDestroy() { }
        // RVA: 0x09613C68  token: 0x60002CD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005D  // size: 0x88
    public class FBIKChain
    {
        // Fields
        public System.Single pin;  // 0x10
        public System.Single pull;  // 0x14
        public System.Single push;  // 0x18
        public System.Single pushParent;  // 0x1c
        public System.Single reach;  // 0x20
        public RootMotion.FinalIK.FBIKChain.Smoothing reachSmoothing;  // 0x24
        public RootMotion.FinalIK.FBIKChain.Smoothing pushSmoothing;  // 0x28
        public RootMotion.FinalIK.IKSolver.Node[] nodes;  // 0x30
        public System.Int32[] children;  // 0x38
        public RootMotion.FinalIK.FBIKChain.ChildConstraint[] childConstraints;  // 0x40
        public RootMotion.FinalIK.IKConstraintBend bendConstraint;  // 0x48
        private System.Single rootLength;  // 0x50
        private System.Boolean initiated;  // 0x54
        private System.Single length;  // 0x58
        private System.Single distance;  // 0x5c
        private RootMotion.FinalIK.IKSolver.Point p;  // 0x60
        private System.Single reachForce;  // 0x68
        private System.Single pullParentSum;  // 0x6c
        private System.Single[] crossFades;  // 0x70
        private System.Single sqrMag1;  // 0x78
        private System.Single sqrMag2;  // 0x7c
        private System.Single sqrMagDif;  // 0x80
        private static System.Single maxLimbLength;  // const

        // Methods
        // RVA: 0x09616570  token: 0x60002D2
        public System.Void .ctor() { }
        // RVA: 0x09616414  token: 0x60002D3
        public System.Void .ctor(System.Single pin, System.Single pull, UnityEngine.Transform[] nodeTransforms) { }
        // RVA: 0x096156E4  token: 0x60002D4
        public System.Void SetNodes(UnityEngine.Transform[] boneTransforms) { }
        // RVA: 0x096147F0  token: 0x60002D5
        public System.Int32 GetNodeIndex(UnityEngine.Transform boneTransform) { }
        // RVA: 0x09614A30  token: 0x60002D6
        public System.Boolean IsValid(System.String& message) { }
        // RVA: 0x09614898  token: 0x60002D7
        public System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09615208  token: 0x60002D8
        public System.Void ReadPose(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean fullBody) { }
        // RVA: 0x09613FE8  token: 0x60002D9
        private System.Void CalculateBoneLengths(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09614EA4  token: 0x60002DA
        public System.Void Reach(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09614B14  token: 0x60002DB
        public UnityEngine.Vector3 Push(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09615BDC  token: 0x60002DC
        public System.Void SolveTrigonometric(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean calculateBendDirection) { }
        // RVA: 0x09615ED8  token: 0x60002DD
        public System.Void Stage1(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x096162F4  token: 0x60002DE
        public System.Void Stage2(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 position) { }
        // RVA: 0x09615840  token: 0x60002DF
        public System.Void SolveConstraintSystems(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09615954  token: 0x60002E0
        private UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        // RVA: 0x09614630  token: 0x60002E1
        protected UnityEngine.Vector3 GetDirToBendPoint(UnityEngine.Vector3 direction, UnityEngine.Vector3 bendDirection, System.Single directionMagnitude) { }
        // RVA: 0x096157DC  token: 0x60002E2
        private System.Void SolveChildConstraints(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09615A2C  token: 0x60002E3
        private System.Void SolveLinearConstraint(RootMotion.FinalIK.IKSolver.Node node1, RootMotion.FinalIK.IKSolver.Node node2, System.Single crossFade, System.Single distance) { }
        // RVA: 0x096144F4  token: 0x60002E4
        public System.Void ForwardReach(UnityEngine.Vector3 position) { }
        // RVA: 0x09613E3C  token: 0x60002E5
        private System.Void BackwardReach(UnityEngine.Vector3 position) { }

    }

    // TypeToken: 0x2000060  // size: 0x88
    public class IKConstraintBend
    {
        // Fields
        public UnityEngine.Transform bone1;  // 0x10
        public UnityEngine.Transform bone2;  // 0x18
        public UnityEngine.Transform bone3;  // 0x20
        public UnityEngine.Transform bendGoal;  // 0x28
        public UnityEngine.Vector3 direction;  // 0x30
        public UnityEngine.Quaternion rotationOffset;  // 0x3c
        public System.Single weight;  // 0x4c
        public UnityEngine.Vector3 defaultLocalDirection;  // 0x50
        public UnityEngine.Vector3 defaultChildDirection;  // 0x5c
        public System.Single clampF;  // 0x68
        private System.Int32 chainIndex1;  // 0x6c
        private System.Int32 nodeIndex1;  // 0x70
        private System.Int32 chainIndex2;  // 0x74
        private System.Int32 nodeIndex2;  // 0x78
        private System.Int32 chainIndex3;  // 0x7c
        private System.Int32 nodeIndex3;  // 0x80
        private System.Boolean <initiated>k__BackingField;  // 0x84
        private System.Boolean limbOrientationsSet;  // 0x85

        // Properties
        System.Boolean initiated { get; /* RVA: 0x03D51AD0 */ set; /* RVA: 0x03D51B30 */ }

        // Methods
        // RVA: 0x09616F20  token: 0x60002EE
        public System.Boolean IsValid(RootMotion.FinalIK.IKSolverFullBody solver, RootMotion.Warning.Logger logger) { }
        // RVA: 0x09617938  token: 0x60002F1
        public System.Void .ctor() { }
        // RVA: 0x09617908  token: 0x60002F2
        public System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3) { }
        // RVA: 0x0285BDC0  token: 0x60002F3
        public System.Void SetBones(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3) { }
        // RVA: 0x09616C30  token: 0x60002F4
        public System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09617708  token: 0x60002F5
        public System.Void SetLimbOrientation(UnityEngine.Vector3 upper, UnityEngine.Vector3 lower, UnityEngine.Vector3 last) { }
        // RVA: 0x096170AC  token: 0x60002F6
        public System.Void LimitBend(System.Single solverWeight, System.Single positionWeight) { }
        // RVA: 0x09616674  token: 0x60002F7
        public UnityEngine.Vector3 GetDir(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0961760C  token: 0x60002F8
        private UnityEngine.Vector3 OrthoToLimb(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 tangent) { }
        // RVA: 0x09617510  token: 0x60002F9
        private UnityEngine.Vector3 OrthoToBone1(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 tangent) { }

    }

    // TypeToken: 0x2000061  // size: 0xF0
    public class IKEffector
    {
        // Fields
        public UnityEngine.Transform bone;  // 0x10
        public UnityEngine.Transform target;  // 0x18
        public System.Single positionWeight;  // 0x20
        public System.Single rotationWeight;  // 0x24
        public UnityEngine.Vector3 position;  // 0x28
        public UnityEngine.Quaternion rotation;  // 0x34
        public UnityEngine.Vector3 positionOffset;  // 0x44
        private System.Boolean <isEndEffector>k__BackingField;  // 0x50
        public System.Boolean effectChildNodes;  // 0x51
        public System.Single maintainRelativePositionWeight;  // 0x54
        public UnityEngine.Transform[] childBones;  // 0x58
        public UnityEngine.Transform planeBone1;  // 0x60
        public UnityEngine.Transform planeBone2;  // 0x68
        public UnityEngine.Transform planeBone3;  // 0x70
        public UnityEngine.Quaternion planeRotationOffset;  // 0x78
        private System.Single posW;  // 0x88
        private System.Single rotW;  // 0x8c
        private UnityEngine.Vector3[] localPositions;  // 0x90
        private System.Boolean usePlaneNodes;  // 0x98
        private UnityEngine.Quaternion animatedPlaneRotation;  // 0x9c
        private UnityEngine.Vector3 animatedPosition;  // 0xac
        private System.Boolean firstUpdate;  // 0xb8
        private System.Int32 chainIndex;  // 0xbc
        private System.Int32 nodeIndex;  // 0xc0
        private System.Int32 plane1ChainIndex;  // 0xc4
        private System.Int32 plane1NodeIndex;  // 0xc8
        private System.Int32 plane2ChainIndex;  // 0xcc
        private System.Int32 plane2NodeIndex;  // 0xd0
        private System.Int32 plane3ChainIndex;  // 0xd4
        private System.Int32 plane3NodeIndex;  // 0xd8
        private System.Int32[] childChainIndexes;  // 0xe0
        private System.Int32[] childNodeIndexes;  // 0xe8

        // Properties
        System.Boolean isEndEffector { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }

        // Methods
        // RVA: 0x09617958  token: 0x60002FA
        public RootMotion.FinalIK.IKSolver.Node GetNode(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09618A34  token: 0x60002FD
        public System.Void PinToBone(System.Single positionWeight, System.Single rotationWeight) { }
        // RVA: 0x09618F9C  token: 0x60002FE
        public System.Void .ctor() { }
        // RVA: 0x096190E4  token: 0x60002FF
        public System.Void .ctor(UnityEngine.Transform bone, UnityEngine.Transform[] childBones) { }
        // RVA: 0x09618198  token: 0x6000300
        public System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        // RVA: 0x09617EBC  token: 0x6000301
        public System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09618AFC  token: 0x6000302
        public System.Void ResetOffset(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09618BDC  token: 0x6000303
        public System.Void SetToTarget() { }
        // RVA: 0x096183FC  token: 0x6000304
        public System.Void OnPreSolve(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x096183E8  token: 0x6000305
        public System.Void OnPostWrite() { }
        // RVA: 0x096179B0  token: 0x6000306
        private UnityEngine.Quaternion GetPlaneRotation(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09618C7C  token: 0x6000307
        public System.Void Update(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09617BC4  token: 0x6000308
        private UnityEngine.Vector3 GetPosition(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Quaternion& planeRotationOffset) { }

    }

    // TypeToken: 0x2000062  // size: 0x10
    public class IKMapping
    {
        // Methods
        // RVA: 0x0232EB60  token: 0x6000309
        public virtual System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        // RVA: 0x0350B670  token: 0x600030A
        public virtual System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0961C180  token: 0x600030B
        protected System.Boolean BoneIsValid(UnityEngine.Transform bone, RootMotion.FinalIK.IKSolver solver, System.String& message, RootMotion.Warning.Logger logger) { }
        // RVA: 0x09615954  token: 0x600030C
        protected UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        // RVA: 0x0350B670  token: 0x600030D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x28
    public class IKMappingBone : RootMotion.FinalIK.IKMapping
    {
        // Fields
        public UnityEngine.Transform bone;  // 0x10
        public System.Single maintainRotationWeight;  // 0x18
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap;  // 0x20

        // Methods
        // RVA: 0x09619538  token: 0x6000328
        public virtual System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        // RVA: 0x09619624  token: 0x6000329
        public System.Void .ctor() { }
        // RVA: 0x096196A8  token: 0x600032A
        public System.Void .ctor(UnityEngine.Transform bone) { }
        // RVA: 0x096195D4  token: 0x600032B
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x0961946C  token: 0x600032C
        public System.Void FixTransforms() { }
        // RVA: 0x09619490  token: 0x600032D
        public virtual System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x096195B4  token: 0x600032E
        public System.Void ReadPose() { }
        // RVA: 0x096195F4  token: 0x600032F
        public System.Void WritePose(System.Single solverWeight) { }

    }

    // TypeToken: 0x2000065  // size: 0x60
    public class IKMappingLimb : RootMotion.FinalIK.IKMapping
    {
        // Fields
        public UnityEngine.Transform parentBone;  // 0x10
        public UnityEngine.Transform bone1;  // 0x18
        public UnityEngine.Transform bone2;  // 0x20
        public UnityEngine.Transform bone3;  // 0x28
        public System.Single maintainRotationWeight;  // 0x30
        public System.Single weight;  // 0x34
        public System.Boolean updatePlaneRotations;  // 0x38
        private RootMotion.FinalIK.IKMapping.BoneMap boneMapParent;  // 0x40
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap1;  // 0x48
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap2;  // 0x50
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap3;  // 0x58

        // Methods
        // RVA: 0x09619B80  token: 0x6000330
        public virtual System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        // RVA: 0x096197EC  token: 0x6000331
        public RootMotion.FinalIK.IKMapping.BoneMap GetBoneMap(RootMotion.FinalIK.IKMappingLimb.BoneMapType boneMap) { }
        // RVA: 0x09619CD4  token: 0x6000332
        public System.Void SetLimbOrientation(UnityEngine.Vector3 upper, UnityEngine.Vector3 lower) { }
        // RVA: 0x0961A230  token: 0x6000333
        public System.Void .ctor() { }
        // RVA: 0x0961A3A4  token: 0x6000334
        public System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform parentBone) { }
        // RVA: 0x09619C8C  token: 0x6000335
        public System.Void SetBones(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform parentBone) { }
        // RVA: 0x0961A01C  token: 0x6000336
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x09619744  token: 0x6000337
        public System.Void FixTransforms() { }
        // RVA: 0x0961988C  token: 0x6000338
        public virtual System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x09619C10  token: 0x6000339
        public System.Void ReadPose() { }
        // RVA: 0x0961A0B8  token: 0x600033A
        public System.Void WritePose(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean fullBody) { }

    }

    // TypeToken: 0x2000067  // size: 0x78
    public class IKMappingSpine : RootMotion.FinalIK.IKMapping
    {
        // Fields
        public UnityEngine.Transform[] spineBones;  // 0x10
        public UnityEngine.Transform leftUpperArmBone;  // 0x18
        public UnityEngine.Transform rightUpperArmBone;  // 0x20
        public UnityEngine.Transform leftThighBone;  // 0x28
        public UnityEngine.Transform rightThighBone;  // 0x30
        public System.Int32 iterations;  // 0x38
        public System.Single twistWeight;  // 0x3c
        private System.Int32 rootNodeIndex;  // 0x40
        private RootMotion.FinalIK.IKMapping.BoneMap[] spine;  // 0x48
        private RootMotion.FinalIK.IKMapping.BoneMap leftUpperArm;  // 0x50
        private RootMotion.FinalIK.IKMapping.BoneMap rightUpperArm;  // 0x58
        private RootMotion.FinalIK.IKMapping.BoneMap leftThigh;  // 0x60
        private RootMotion.FinalIK.IKMapping.BoneMap rightThigh;  // 0x68
        private System.Boolean useFABRIK;  // 0x70

        // Methods
        // RVA: 0x0961B004  token: 0x600033B
        public virtual System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        // RVA: 0x0961BFE0  token: 0x600033C
        public System.Void .ctor() { }
        // RVA: 0x0961BDC8  token: 0x600033D
        public System.Void .ctor(UnityEngine.Transform[] spineBones, UnityEngine.Transform leftUpperArmBone, UnityEngine.Transform rightUpperArmBone, UnityEngine.Transform leftThighBone, UnityEngine.Transform rightThighBone) { }
        // RVA: 0x07D6BBD4  token: 0x600033E
        public System.Void SetBones(UnityEngine.Transform[] spineBones, UnityEngine.Transform leftUpperArmBone, UnityEngine.Transform rightUpperArmBone, UnityEngine.Transform leftThighBone, UnityEngine.Transform rightThighBone) { }
        // RVA: 0x0961B968  token: 0x600033F
        public System.Void StoreDefaultLocalState() { }
        // RVA: 0x0961A6A8  token: 0x6000340
        public System.Void FixTransforms() { }
        // RVA: 0x0961A868  token: 0x6000341
        public virtual System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0961B9BC  token: 0x6000342
        private System.Boolean UseFABRIK() { }
        // RVA: 0x0961B64C  token: 0x6000343
        public System.Void ReadPose() { }
        // RVA: 0x0961B9E8  token: 0x6000344
        public System.Void WritePose(RootMotion.FinalIK.IKSolverFullBody solver) { }
        // RVA: 0x0961A714  token: 0x6000345
        public System.Void ForwardReach(UnityEngine.Vector3 position) { }
        // RVA: 0x0961A584  token: 0x6000346
        private System.Void BackwardReach(UnityEngine.Vector3 position) { }
        // RVA: 0x0961B2D8  token: 0x6000347
        private System.Void MapToSolverPositions(RootMotion.FinalIK.IKSolverFullBody solver) { }

    }

    // TypeToken: 0x2000068  // size: 0x58
    public abstract class IKSolver
    {
        // Fields
        public System.Boolean executedInEditor;  // 0x10
        public UnityEngine.Vector3 IKPosition;  // 0x14
        public System.Single IKPositionWeight;  // 0x20
        private System.Boolean <initiated>k__BackingField;  // 0x24
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreInitiate;  // 0x28
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostInitiate;  // 0x30
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreUpdate;  // 0x38
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostUpdate;  // 0x40
        protected System.Boolean firstInitiation;  // 0x48
        protected UnityEngine.Transform root;  // 0x50

        // Properties
        System.Boolean initiated { get; /* RVA: 0x03D4F090 */ set; /* RVA: 0x03D4F0A0 */ }

        // Methods
        // RVA: 0x0961E02C  token: 0x6000348
        public System.Boolean IsValid() { }
        // RVA: -1  // abstract  token: 0x6000349
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x0270B4B0  token: 0x600034A
        public System.Void Initiate(UnityEngine.Transform root) { }
        // RVA: 0x0238E920  token: 0x600034B
        public System.Void Update() { }
        // RVA: 0x01176980  token: 0x600034C
        public virtual UnityEngine.Vector3 GetIKPosition() { }
        // RVA: 0x03D6E520  token: 0x600034D
        public System.Void SetIKPosition(UnityEngine.Vector3 position) { }
        // RVA: 0x03D4F2E0  token: 0x600034E
        public System.Single GetIKPositionWeight() { }
        // RVA: 0x0961E408  token: 0x600034F
        public System.Void SetIKPositionWeight(System.Single weight) { }
        // RVA: 0x03D4EAF0  token: 0x6000350
        public UnityEngine.Transform GetRoot() { }
        // RVA: -1  // abstract  token: 0x6000353
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: -1  // abstract  token: 0x6000354
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: -1  // abstract  token: 0x6000355
        public virtual System.Void FixTransforms() { }
        // RVA: -1  // abstract  token: 0x6000356
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: -1  // abstract  token: 0x6000357
        protected virtual System.Void OnInitiate() { }
        // RVA: -1  // abstract  token: 0x6000358
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0961E080  token: 0x6000359
        protected System.Void LogWarning(System.String message) { }
        // RVA: 0x029EF470  token: 0x600035A
        public static UnityEngine.Transform ContainsDuplicateBone(RootMotion.FinalIK.IKSolver.Bone[] bones) { }
        // RVA: 0x029EE840  token: 0x600035B
        public static System.Boolean HierarchyIsValid(RootMotion.FinalIK.IKSolver.Bone[] bones) { }
        // RVA: 0x0961E098  token: 0x600035C
        protected static System.Single PreSolveBones(RootMotion.FinalIK.IKSolver.Bone[]& bones) { }
        // RVA: 0x03D74A90  token: 0x600035D
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200006E  // size: 0xF0
    public class IKSolverAim : RootMotion.FinalIK.IKSolverHeuristic
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x88
        public UnityEngine.Vector3 axis;  // 0x90
        public UnityEngine.Vector3 poleAxis;  // 0x9c
        public UnityEngine.Vector3 polePosition;  // 0xa8
        public System.Single poleWeight;  // 0xb4
        public UnityEngine.Transform poleTarget;  // 0xb8
        public System.Single clampWeight;  // 0xc0
        public System.Int32 clampSmoothing;  // 0xc4
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;  // 0xc8
        private System.Single step;  // 0xd0
        private UnityEngine.Vector3 clampedIKPosition;  // 0xd4
        private RootMotion.FinalIK.RotationLimit transformLimit;  // 0xe0
        private UnityEngine.Transform lastTransform;  // 0xe8

        // Properties
        UnityEngine.Vector3 transformAxis { get; /* RVA: 0x0961CE10 */ }
        UnityEngine.Vector3 transformPoleAxis { get; /* RVA: 0x0961CE94 */ }
        System.Int32 minBones { get; /* RVA: 0x01168950 */ }
        UnityEngine.Vector3 localDirection { get; /* RVA: 0x0961CD60 */ }

        // Methods
        // RVA: 0x0961C27C  token: 0x6000379
        public System.Single GetAngle() { }
        // RVA: 0x029EE1E0  token: 0x600037C
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x02ED2CE0  token: 0x600037D
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0961CC4C  token: 0x600037F
        private System.Void Solve() { }
        // RVA: 0x0961C348  token: 0x6000380
        private UnityEngine.Vector3 GetClampedIKPosition() { }
        // RVA: 0x0961C71C  token: 0x6000381
        private System.Void RotateToTarget(UnityEngine.Vector3 targetPosition, RootMotion.FinalIK.IKSolver.Bone bone, System.Single weight) { }
        // RVA: 0x029ED550  token: 0x6000383
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006F  // size: 0xB8
    public class IKSolverArm : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public System.Single IKRotationWeight;  // 0x58
        public UnityEngine.Quaternion IKRotation;  // 0x5c
        public RootMotion.FinalIK.IKSolver.Point chest;  // 0x70
        public RootMotion.FinalIK.IKSolver.Point shoulder;  // 0x78
        public RootMotion.FinalIK.IKSolver.Point upperArm;  // 0x80
        public RootMotion.FinalIK.IKSolver.Point forearm;  // 0x88
        public RootMotion.FinalIK.IKSolver.Point hand;  // 0x90
        public System.Boolean isLeft;  // 0x98
        public RootMotion.FinalIK.IKSolverVR.Arm arm;  // 0xa0
        private UnityEngine.Vector3[] positions;  // 0xa8
        private UnityEngine.Quaternion[] rotations;  // 0xb0

        // Methods
        // RVA: 0x0961D1EC  token: 0x6000384
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x0961DA54  token: 0x6000385
        public System.Boolean SetChain(UnityEngine.Transform chest, UnityEngine.Transform shoulder, UnityEngine.Transform upperArm, UnityEngine.Transform forearm, UnityEngine.Transform hand, UnityEngine.Transform root) { }
        // RVA: 0x0961D0E8  token: 0x6000386
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x0961CF7C  token: 0x6000387
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x0961DB84  token: 0x6000388
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x0961CF18  token: 0x6000389
        public virtual System.Void FixTransforms() { }
        // RVA: 0x0961D4E8  token: 0x600038A
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x0961D564  token: 0x600038B
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0961DB04  token: 0x600038C
        private System.Void Solve() { }
        // RVA: 0x0961D590  token: 0x600038D
        private System.Void Read() { }
        // RVA: 0x0961DBE4  token: 0x600038E
        private System.Void Write() { }
        // RVA: 0x0961DE34  token: 0x600038F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x90
    public class IKSolverCCD : RootMotion.FinalIK.IKSolverHeuristic
    {
        // Fields
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;  // 0x88

        // Methods
        // RVA: 0x09620174  token: 0x6000390
        public System.Void FadeOutBoneWeights() { }
        // RVA: 0x0962020C  token: 0x6000391
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x09620288  token: 0x6000392
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x09620540  token: 0x6000393
        protected System.Void Solve(UnityEngine.Vector3 targetPosition) { }
        // RVA: 0x09620C9C  token: 0x6000394
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000071  // size: 0xA0
    public class IKSolverFABRIK : RootMotion.FinalIK.IKSolverHeuristic
    {
        // Fields
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;  // 0x88
        private System.Boolean[] limitedBones;  // 0x90
        private UnityEngine.Vector3[] solverLocalPositions;  // 0x98

        // Properties
        System.Boolean boneLengthCanBeZero { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x09623518  token: 0x6000395
        public System.Void SolveForward(UnityEngine.Vector3 position) { }
        // RVA: 0x0962347C  token: 0x6000396
        public System.Void SolveBackward(UnityEngine.Vector3 position) { }
        // RVA: 0x096225C0  token: 0x6000397
        public virtual UnityEngine.Vector3 GetIKPosition() { }
        // RVA: 0x029EEBF0  token: 0x6000398
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x031AB200  token: 0x6000399
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x096235B4  token: 0x600039B
        private UnityEngine.Vector3 SolveJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        // RVA: 0x09622FB0  token: 0x600039C
        private System.Void OnPreSolve() { }
        // RVA: 0x09622F68  token: 0x600039D
        private System.Void OnPostSolve() { }
        // RVA: 0x0962369C  token: 0x600039E
        private System.Void Solve(UnityEngine.Vector3 targetPosition) { }
        // RVA: 0x096223E4  token: 0x600039F
        private System.Void ForwardReach(UnityEngine.Vector3 position) { }
        // RVA: 0x096238B0  token: 0x60003A0
        private System.Void SolverMove(System.Int32 index, UnityEngine.Vector3 offset) { }
        // RVA: 0x096239C8  token: 0x60003A1
        private System.Void SolverRotate(System.Int32 index, UnityEngine.Quaternion rotation, System.Boolean recursive) { }
        // RVA: 0x09623944  token: 0x60003A2
        private System.Void SolverRotateChildren(System.Int32 index, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09623724  token: 0x60003A3
        private System.Void SolverMoveChildrenAroundPoint(System.Int32 index, UnityEngine.Quaternion rotation) { }
        // RVA: 0x029EE450  token: 0x60003A4
        private UnityEngine.Quaternion GetParentSolverRotation(System.Int32 index) { }
        // RVA: 0x029EE580  token: 0x60003A5
        private UnityEngine.Vector3 GetParentSolverPosition(System.Int32 index) { }
        // RVA: 0x0962265C  token: 0x60003A6
        private UnityEngine.Quaternion GetLimitedRotation(System.Int32 index, UnityEngine.Quaternion q, System.Boolean& changed) { }
        // RVA: 0x09622798  token: 0x60003A7
        private System.Void LimitForward(System.Int32 rotateBone, System.Int32 limitBone) { }
        // RVA: 0x096223B0  token: 0x60003A8
        private System.Void BackwardReach(UnityEngine.Vector3 position) { }
        // RVA: 0x09622290  token: 0x60003A9
        private System.Void BackwardReachUnlimited(UnityEngine.Vector3 position) { }
        // RVA: 0x09621CD4  token: 0x60003AA
        private System.Void BackwardReachLimited(UnityEngine.Vector3 position) { }
        // RVA: 0x09622DFC  token: 0x60003AB
        private System.Void MapToSolverPositions() { }
        // RVA: 0x09622D0C  token: 0x60003AC
        private System.Void MapToSolverPositionsLimited() { }
        // RVA: 0x029ED5B0  token: 0x60003AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000072  // size: 0x88
    public class IKSolverFABRIKRoot : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public System.Int32 iterations;  // 0x58
        public System.Single rootPin;  // 0x5c
        public RootMotion.FinalIK.FABRIKChain[] chains;  // 0x60
        private System.Boolean zeroWeightApplied;  // 0x68
        private System.Boolean[] isRoot;  // 0x70
        private UnityEngine.Vector3 rootDefaultPosition;  // 0x78

        // Methods
        // RVA: 0x096212D4  token: 0x60003AE
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x09621BEC  token: 0x60003AF
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x09620D9C  token: 0x60003B0
        public virtual System.Void FixTransforms() { }
        // RVA: 0x09621920  token: 0x60003B1
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x09621244  token: 0x60003B2
        private System.Boolean IsRoot(System.Int32 index) { }
        // RVA: 0x096219F0  token: 0x60003B3
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x096211BC  token: 0x60003B4
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x09621144  token: 0x60003B5
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x09620CA4  token: 0x60003B6
        private System.Void AddPointsToArray(RootMotion.FinalIK.IKSolver.Point[]& array, RootMotion.FinalIK.FABRIKChain chain) { }
        // RVA: 0x09620E3C  token: 0x60003B7
        private UnityEngine.Vector3 GetCentroid() { }
        // RVA: 0x09621C7C  token: 0x60003B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000073  // size: 0xD0
    public class IKSolverFullBody : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public System.Int32 iterations;  // 0x58
        public RootMotion.FinalIK.FBIKChain[] chain;  // 0x60
        public RootMotion.FinalIK.IKEffector[] effectors;  // 0x68
        public RootMotion.FinalIK.IKMappingSpine spineMapping;  // 0x70
        public RootMotion.FinalIK.IKMappingBone[] boneMappings;  // 0x78
        public RootMotion.FinalIK.IKMappingLimb[] limbMappings;  // 0x80
        public System.Boolean FABRIKPass;  // 0x88
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreRead;  // 0x90
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreSolve;  // 0x98
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;  // 0xa0
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPostIteration;  // 0xa8
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreBend;  // 0xb0
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostSolve;  // 0xb8
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnStoreDefaultLocalState;  // 0xc0
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnFixTransforms;  // 0xc8

        // Methods
        // RVA: 0x09626CF4  token: 0x60003B9
        public RootMotion.FinalIK.IKEffector GetEffector(UnityEngine.Transform t) { }
        // RVA: 0x09626CB0  token: 0x60003BA
        public RootMotion.FinalIK.FBIKChain GetChain(UnityEngine.Transform transform) { }
        // RVA: 0x09626BAC  token: 0x60003BB
        public System.Int32 GetChainIndex(UnityEngine.Transform transform) { }
        // RVA: 0x09626DB0  token: 0x60003BC
        public RootMotion.FinalIK.IKSolver.Node GetNode(System.Int32 chainIndex, System.Int32 nodeIndex) { }
        // RVA: 0x09626B30  token: 0x60003BD
        public System.Void GetChainAndNodeIndexes(UnityEngine.Transform transform, System.Int32& chainIndex, System.Int32& nodeIndex) { }
        // RVA: 0x09626F38  token: 0x60003BE
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x09626DF8  token: 0x60003BF
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x09627084  token: 0x60003C0
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x096279FC  token: 0x60003C1
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x09626A68  token: 0x60003C2
        public virtual System.Void FixTransforms() { }
        // RVA: 0x09627234  token: 0x60003C3
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x09627340  token: 0x60003C4
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x096274A0  token: 0x60003C5
        protected virtual System.Void ReadPose() { }
        // RVA: 0x096276C8  token: 0x60003C6
        protected virtual System.Void Solve() { }
        // RVA: 0x09626A2C  token: 0x60003C7
        protected virtual System.Void ApplyBendConstraints() { }
        // RVA: 0x09627AB0  token: 0x60003C8
        protected virtual System.Void WritePose() { }
        // RVA: 0x09627B70  token: 0x60003C9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000074  // size: 0x14
    public sealed struct FullBodyBipedEffector
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.FullBodyBipedEffector Body;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftShoulder;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector RightShoulder;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftThigh;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector RightThigh;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftHand;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector RightHand;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftFoot;  // const
        public static RootMotion.FinalIK.FullBodyBipedEffector RightFoot;  // const

    }

    // TypeToken: 0x2000075  // size: 0x14
    public sealed struct FullBodyBipedChain
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RootMotion.FinalIK.FullBodyBipedChain LeftArm;  // const
        public static RootMotion.FinalIK.FullBodyBipedChain RightArm;  // const
        public static RootMotion.FinalIK.FullBodyBipedChain LeftLeg;  // const
        public static RootMotion.FinalIK.FullBodyBipedChain RightLeg;  // const

    }

    // TypeToken: 0x2000076  // size: 0x100
    public class IKSolverFullBodyBiped : RootMotion.FinalIK.IKSolverFullBody
    {
        // Fields
        public UnityEngine.Transform rootNode;  // 0xd0
        public System.Single spineStiffness;  // 0xd8
        public System.Single pullBodyVertical;  // 0xdc
        public System.Single pullBodyHorizontal;  // 0xe0
        private UnityEngine.Vector3 <pullBodyOffset>k__BackingField;  // 0xe4
        private UnityEngine.Vector3 offset;  // 0xf0

        // Properties
        RootMotion.FinalIK.IKEffector bodyEffector { get; /* RVA: 0x09626850 */ }
        RootMotion.FinalIK.IKEffector leftShoulderEffector { get; /* RVA: 0x09626924 */ }
        RootMotion.FinalIK.IKEffector rightShoulderEffector { get; /* RVA: 0x09626A0C */ }
        RootMotion.FinalIK.IKEffector leftThighEffector { get; /* RVA: 0x09626934 */ }
        RootMotion.FinalIK.IKEffector rightThighEffector { get; /* RVA: 0x09626A1C */ }
        RootMotion.FinalIK.IKEffector leftHandEffector { get; /* RVA: 0x096268C0 */ }
        RootMotion.FinalIK.IKEffector rightHandEffector { get; /* RVA: 0x096269A8 */ }
        RootMotion.FinalIK.IKEffector leftFootEffector { get; /* RVA: 0x096268B0 */ }
        RootMotion.FinalIK.IKEffector rightFootEffector { get; /* RVA: 0x09626998 */ }
        RootMotion.FinalIK.FBIKChain leftArmChain { get; /* RVA: 0x0962685C */ }
        RootMotion.FinalIK.FBIKChain rightArmChain { get; /* RVA: 0x09626944 */ }
        RootMotion.FinalIK.FBIKChain leftLegChain { get; /* RVA: 0x096268D0 */ }
        RootMotion.FinalIK.FBIKChain rightLegChain { get; /* RVA: 0x096269B8 */ }
        RootMotion.FinalIK.IKMappingLimb leftArmMapping { get; /* RVA: 0x09626884 */ }
        RootMotion.FinalIK.IKMappingLimb rightArmMapping { get; /* RVA: 0x0962696C */ }
        RootMotion.FinalIK.IKMappingLimb leftLegMapping { get; /* RVA: 0x096268F8 */ }
        RootMotion.FinalIK.IKMappingLimb rightLegMapping { get; /* RVA: 0x096269E0 */ }
        RootMotion.FinalIK.IKMappingBone headMapping { get; /* RVA: 0x096248FC */ }
        UnityEngine.Vector3 pullBodyOffset { get; /* RVA: 0x03D74AA0 */ set; /* RVA: 0x03D74AC0 */ }

        // Methods
        // RVA: 0x09624FFC  token: 0x60003DC
        public System.Void SetChainWeights(RootMotion.FinalIK.FullBodyBipedChain c, System.Single pull, System.Single reach) { }
        // RVA: 0x09625060  token: 0x60003DD
        public System.Void SetEffectorWeights(RootMotion.FinalIK.FullBodyBipedEffector effector, System.Single positionWeight, System.Single rotationWeight) { }
        // RVA: 0x0962445C  token: 0x60003DE
        public RootMotion.FinalIK.FBIKChain GetChain(RootMotion.FinalIK.FullBodyBipedChain c) { }
        // RVA: 0x096244DC  token: 0x60003DF
        public RootMotion.FinalIK.FBIKChain GetChain(RootMotion.FinalIK.FullBodyBipedEffector effector) { }
        // RVA: 0x0962458C  token: 0x60003E0
        public RootMotion.FinalIK.IKEffector GetEffector(RootMotion.FinalIK.FullBodyBipedEffector effector) { }
        // RVA: 0x096246C4  token: 0x60003E1
        public RootMotion.FinalIK.IKEffector GetEndEffector(RootMotion.FinalIK.FullBodyBipedChain c) { }
        // RVA: 0x096249C4  token: 0x60003E2
        public RootMotion.FinalIK.IKMappingLimb GetLimbMapping(RootMotion.FinalIK.FullBodyBipedChain chain) { }
        // RVA: 0x09624A50  token: 0x60003E3
        public RootMotion.FinalIK.IKMappingLimb GetLimbMapping(RootMotion.FinalIK.FullBodyBipedEffector effector) { }
        // RVA: 0x03D4EB30  token: 0x60003E4
        public RootMotion.FinalIK.IKMappingSpine GetSpineMapping() { }
        // RVA: 0x096248FC  token: 0x60003E5
        public RootMotion.FinalIK.IKMappingBone GetHeadMapping() { }
        // RVA: 0x096241BC  token: 0x60003E6
        public RootMotion.FinalIK.IKConstraintBend GetBendConstraint(RootMotion.FinalIK.FullBodyBipedChain limb) { }
        // RVA: 0x09624B90  token: 0x60003E7
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x096253AC  token: 0x60003E8
        public System.Void SetToReferences(RootMotion.BipedReferences references, UnityEngine.Transform rootNode) { }
        // RVA: 0x09623E40  token: 0x60003E9
        public static UnityEngine.Transform DetectRootNodeBone(RootMotion.BipedReferences references) { }
        // RVA: 0x09625340  token: 0x60003EA
        public System.Void SetLimbOrientations(RootMotion.BipedLimbOrientations o) { }
        // RVA: 0x09625114  token: 0x60003ED
        private System.Void SetLimbOrientation(RootMotion.FinalIK.FullBodyBipedChain chain, RootMotion.BipedLimbOrientations.LimbOrientation limbOrientation) { }
        // RVA: 0x09624924  token: 0x60003EE
        private static UnityEngine.Transform GetLeftClavicle(RootMotion.BipedReferences references) { }
        // RVA: 0x09624AF0  token: 0x60003EF
        private static UnityEngine.Transform GetRightClavicle(RootMotion.BipedReferences references) { }
        // RVA: 0x09623DA8  token: 0x60003F0
        private static System.Boolean Contains(UnityEngine.Transform[] array, UnityEngine.Transform transform) { }
        // RVA: 0x09624EF8  token: 0x60003F1
        protected virtual System.Void ReadPose() { }
        // RVA: 0x09624D24  token: 0x60003F2
        private System.Void PullBody() { }
        // RVA: 0x09624244  token: 0x60003F3
        private UnityEngine.Vector3 GetBodyOffset() { }
        // RVA: 0x09624744  token: 0x60003F4
        private UnityEngine.Vector3 GetHandBodyPull(RootMotion.FinalIK.IKEffector effector, RootMotion.FinalIK.FBIKChain arm, UnityEngine.Vector3 offset) { }
        // RVA: 0x09623A58  token: 0x60003F5
        protected virtual System.Void ApplyBendConstraints() { }
        // RVA: 0x09626760  token: 0x60003F6
        protected virtual System.Void WritePose() { }
        // RVA: 0x09626834  token: 0x60003F7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x88
    public class IKSolverHeuristic : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public UnityEngine.Transform target;  // 0x58
        public System.Single tolerance;  // 0x60
        public System.Int32 maxIterations;  // 0x64
        public System.Boolean useRotationLimits;  // 0x68
        public System.Boolean XY;  // 0x69
        public RootMotion.FinalIK.IKSolver.Bone[] bones;  // 0x70
        protected UnityEngine.Vector3 lastLocalDirection;  // 0x78
        protected System.Single chainLength;  // 0x84

        // Properties
        System.Int32 minBones { get; /* RVA: 0x02102C70 */ }
        System.Boolean boneLengthCanBeZero { get; /* RVA: 0x0232EB60 */ }
        System.Boolean allowCommonParent { get; /* RVA: 0x0115F4C0 */ }
        UnityEngine.Vector3 localDirection { get; /* RVA: 0x09628490 */ }
        System.Single positionOffset { get; /* RVA: 0x096285DC */ }

        // Methods
        // RVA: 0x029EE6D0  token: 0x60003F8
        public System.Boolean SetChain(UnityEngine.Transform[] hierarchy, UnityEngine.Transform root) { }
        // RVA: 0x09627C90  token: 0x60003F9
        public System.Void AddBone(UnityEngine.Transform bone) { }
        // RVA: 0x029EE7E0  token: 0x60003FA
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x09627D94  token: 0x60003FB
        public virtual System.Void FixTransforms() { }
        // RVA: 0x029EE8C0  token: 0x60003FC
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x03D4EB30  token: 0x60003FD
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x09627DF4  token: 0x60003FE
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x0350B670  token: 0x6000402
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x0350B670  token: 0x6000403
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x029EEF50  token: 0x6000404
        protected System.Void InitiateBones() { }
        // RVA: 0x09627EB0  token: 0x6000407
        protected UnityEngine.Vector3 GetSingularityOffset() { }
        // RVA: 0x09628200  token: 0x6000408
        private System.Boolean SingularityDetected() { }
        // RVA: 0x029ED640  token: 0x6000409
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000078  // size: 0xC0
    public class IKSolverLeg : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public System.Single IKRotationWeight;  // 0x58
        public UnityEngine.Quaternion IKRotation;  // 0x5c
        public RootMotion.FinalIK.IKSolver.Point pelvis;  // 0x70
        public RootMotion.FinalIK.IKSolver.Point thigh;  // 0x78
        public RootMotion.FinalIK.IKSolver.Point calf;  // 0x80
        public RootMotion.FinalIK.IKSolver.Point foot;  // 0x88
        public RootMotion.FinalIK.IKSolver.Point toe;  // 0x90
        public RootMotion.FinalIK.IKSolverVR.Leg leg;  // 0x98
        public UnityEngine.Vector3 heelOffset;  // 0xa0
        private UnityEngine.Vector3[] positions;  // 0xb0
        private UnityEngine.Quaternion[] rotations;  // 0xb8

        // Methods
        // RVA: 0x096288C4  token: 0x600040A
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x0961DA54  token: 0x600040B
        public System.Boolean SetChain(UnityEngine.Transform pelvis, UnityEngine.Transform thigh, UnityEngine.Transform calf, UnityEngine.Transform foot, UnityEngine.Transform toe, UnityEngine.Transform root) { }
        // RVA: 0x096287C0  token: 0x600040C
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x09628654  token: 0x600040D
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x0961DB84  token: 0x600040E
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x0961CF18  token: 0x600040F
        public virtual System.Void FixTransforms() { }
        // RVA: 0x09628BC0  token: 0x6000410
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x09628C3C  token: 0x6000411
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x09629128  token: 0x6000412
        private System.Void Solve() { }
        // RVA: 0x09628C68  token: 0x6000413
        private System.Void Read() { }
        // RVA: 0x09629214  token: 0x6000414
        private System.Void Write() { }
        // RVA: 0x09629464  token: 0x6000415
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x140
    public class IKSolverLimb : RootMotion.FinalIK.IKSolverTrigonometric
    {
        // Fields
        public UnityEngine.AvatarIKGoal goal;  // 0xa8
        public RootMotion.FinalIK.IKSolverLimb.BendModifier bendModifier;  // 0xac
        public System.Single maintainRotationWeight;  // 0xb0
        public System.Single bendModifierWeight;  // 0xb4
        public UnityEngine.Transform bendGoal;  // 0xb8
        private System.Boolean maintainBendFor1Frame;  // 0xc0
        private System.Boolean maintainRotationFor1Frame;  // 0xc1
        private UnityEngine.Quaternion defaultRootRotation;  // 0xc4
        private UnityEngine.Quaternion parentDefaultRotation;  // 0xd4
        private UnityEngine.Quaternion bone3RotationBeforeSolve;  // 0xe4
        private UnityEngine.Quaternion maintainRotation;  // 0xf4
        private UnityEngine.Quaternion bone3DefaultRotation;  // 0x104
        private UnityEngine.Vector3 _bendNormal;  // 0x114
        private UnityEngine.Vector3 animationNormal;  // 0x120
        private RootMotion.FinalIK.IKSolverLimb.AxisDirection[] axisDirectionsLeft;  // 0x130
        private RootMotion.FinalIK.IKSolverLimb.AxisDirection[] axisDirectionsRight;  // 0x138

        // Properties
        RootMotion.FinalIK.IKSolverLimb.AxisDirection[] axisDirections { get; /* RVA: 0x096296E4 */ }

        // Methods
        // RVA: 0x0238E980  token: 0x6000416
        public System.Void MaintainRotation() { }
        // RVA: 0x0238E9F0  token: 0x6000417
        public System.Void MaintainBend() { }
        // RVA: 0x029EF7E0  token: 0x6000418
        protected virtual System.Void OnInitiateVirtual() { }
        // RVA: 0x02DD1C30  token: 0x6000419
        protected virtual System.Void OnUpdateVirtual() { }
        // RVA: 0x02F82720  token: 0x600041A
        protected virtual System.Void OnPostSolveVirtual() { }
        // RVA: 0x0962965C  token: 0x600041B
        public System.Void .ctor() { }
        // RVA: 0x029ED390  token: 0x600041C
        public System.Void .ctor(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x025D3940  token: 0x600041E
        private System.Void StoreAxisDirections(RootMotion.FinalIK.IKSolverLimb.AxisDirection[]& axisDirections) { }
        // RVA: 0x02DD1D00  token: 0x600041F
        private UnityEngine.Vector3 GetModifiedBendNormal() { }

    }

    // TypeToken: 0x200007C  // size: 0xF8
    public class IKSolverLookAt : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public UnityEngine.Transform target;  // 0x58
        public RootMotion.FinalIK.IKSolverLookAt.LookAtBone[] spine;  // 0x60
        private UnityEngine.Quaternion[] m_spineVirtualBones;  // 0x68
        public RootMotion.FinalIK.IKSolverLookAt.LookAtBone head;  // 0x70
        private UnityEngine.Quaternion m_headVirtualBones;  // 0x78
        public RootMotion.FinalIK.IKSolverLookAt.LookAtBone[] eyes;  // 0x88
        private UnityEngine.Quaternion m_eyeVirtualBone;  // 0x90
        public System.Single bodyWeight;  // 0xa0
        public System.Single headWeight;  // 0xa4
        public System.Single eyesWeight;  // 0xa8
        public System.Single clampWeight;  // 0xac
        public System.Single clampWeightHead;  // 0xb0
        public System.Single clampWeightEyes;  // 0xb4
        public System.Int32 clampSmoothing;  // 0xb8
        public UnityEngine.AnimationCurve spineWeightCurve;  // 0xc0
        public UnityEngine.Vector3 spineTargetOffset;  // 0xc8
        protected UnityEngine.Vector3[] spineForwards;  // 0xd8
        protected UnityEngine.Vector3[] headForwards;  // 0xe0
        protected UnityEngine.Vector3[] eyeForward;  // 0xe8
        private System.Boolean isDirty;  // 0xf0

        // Properties
        UnityEngine.Quaternion[] spineVirtualBone { get; /* RVA: 0x09629CB0 */ set; /* RVA: 0x038C5570 */ }
        UnityEngine.Quaternion headVirtualBones { get; /* RVA: 0x03D58660 */ set; /* RVA: 0x03D6C700 */ }
        UnityEngine.Quaternion eyeVirtualBone { get; /* RVA: 0x03D68BC0 */ set; /* RVA: 0x03D6C0C0 */ }
        System.Boolean spineIsValid { get; /* RVA: 0x029EDF20 */ }
        System.Boolean spineIsEmpty { get; /* RVA: 0x029EE060 */ }
        System.Boolean headIsValid { get; /* RVA: 0x029EE090 */ }
        System.Boolean headIsEmpty { get; /* RVA: 0x030EA160 */ }
        System.Boolean eyesIsValid { get; /* RVA: 0x029EDFF0 */ }
        System.Boolean eyesIsEmpty { get; /* RVA: 0x02F8DDE0 */ }

        // Methods
        // RVA: 0x0961E408  token: 0x6000427
        public System.Void SetLookAtWeight(System.Single weight) { }
        // RVA: 0x09629A0C  token: 0x6000428
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight) { }
        // RVA: 0x09629AFC  token: 0x6000429
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight) { }
        // RVA: 0x09629C38  token: 0x600042A
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight) { }
        // RVA: 0x09629A54  token: 0x600042B
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight) { }
        // RVA: 0x09629B60  token: 0x600042C
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight, System.Single clampWeightHead, System.Single clampWeightEyes) { }
        // RVA: 0x029EE360  token: 0x600042D
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x03D74AE0  token: 0x600042E
        public System.Void SetDirty() { }
        // RVA: 0x031265D0  token: 0x600042F
        public virtual System.Void FixTransforms() { }
        // RVA: 0x029EE0A0  token: 0x6000430
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x09629838  token: 0x6000431
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x09629700  token: 0x6000432
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x029ECE70  token: 0x6000433
        public System.Boolean SetChain(UnityEngine.Transform[] spine, UnityEngine.Transform head, UnityEngine.Transform[] eyes, UnityEngine.Transform root) { }
        // RVA: 0x03504070  token: 0x6000434
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x02F8DBD0  token: 0x6000435
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x02589FC0  token: 0x6000438
        protected System.Void SolveSpine() { }
        // RVA: 0x025897A0  token: 0x600043B
        protected System.Void SolveHead() { }
        // RVA: 0x02F8DD30  token: 0x600043E
        protected System.Void SolveEyes() { }
        // RVA: 0x02E4E8C0  token: 0x600043F
        protected UnityEngine.Vector3[] GetForwards(UnityEngine.Vector3[]& forwards, UnityEngine.Vector3 baseForward, UnityEngine.Vector3 targetForward, System.Int32 bones, System.Single clamp) { }
        // RVA: 0x029ECF40  token: 0x6000440
        protected System.Void SetBones(UnityEngine.Transform[] array, RootMotion.FinalIK.IKSolverLookAt.LookAtBone[]& bones) { }
        // RVA: 0x029ED6A0  token: 0x6000441
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007E  // size: 0xA8
    public class IKSolverTrigonometric : RootMotion.FinalIK.IKSolver
    {
        // Fields
        public UnityEngine.Transform target;  // 0x58
        public System.Single IKRotationWeight;  // 0x60
        public UnityEngine.Quaternion IKRotation;  // 0x64
        public UnityEngine.Vector3 bendNormal;  // 0x74
        public RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBone bone1;  // 0x80
        public RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBone bone2;  // 0x88
        public RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBone bone3;  // 0x90
        protected UnityEngine.Vector3 weightIKPosition;  // 0x98
        protected System.Boolean directHierarchy;  // 0xa4

        // Methods
        // RVA: 0x0962A118  token: 0x6000448
        public System.Void SetBendGoalPosition(UnityEngine.Vector3 goalPosition, System.Single weight) { }
        // RVA: 0x02B229A0  token: 0x6000449
        public System.Void SetBendPlaneToCurrent() { }
        // RVA: 0x03D74B00  token: 0x600044A
        public System.Void SetIKRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x0962A324  token: 0x600044B
        public System.Void SetIKRotationWeight(System.Single weight) { }
        // RVA: 0x03D74AF0  token: 0x600044C
        public UnityEngine.Quaternion GetIKRotation() { }
        // RVA: 0x03D50D50  token: 0x600044D
        public System.Single GetIKRotationWeight() { }
        // RVA: 0x0962A054  token: 0x600044E
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x09629F5C  token: 0x600044F
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x029EF560  token: 0x6000450
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x0251A850  token: 0x6000451
        public virtual System.Void FixTransforms() { }
        // RVA: 0x029F0700  token: 0x6000452
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x029EDEA0  token: 0x6000453
        public System.Boolean SetChain(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform root) { }
        // RVA: 0x0962A348  token: 0x6000454
        public static System.Void Solve(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 bendNormal, System.Single weight) { }
        // RVA: 0x09629DA0  token: 0x6000455
        private static UnityEngine.Vector3 GetDirectionToBendPoint(UnityEngine.Vector3 direction, System.Single directionMag, UnityEngine.Vector3 bendDirection, System.Single sqrMag1, System.Single sqrMag2) { }
        // RVA: 0x02B228B0  token: 0x6000456
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x02B22790  token: 0x6000457
        private System.Boolean IsDirectHierarchy() { }
        // RVA: 0x02B229D0  token: 0x6000458
        public System.Void InitiateBones() { }
        // RVA: 0x0238FE90  token: 0x6000459
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0350B670  token: 0x600045A
        protected virtual System.Void OnInitiateVirtual() { }
        // RVA: 0x0350B670  token: 0x600045B
        protected virtual System.Void OnUpdateVirtual() { }
        // RVA: 0x0350B670  token: 0x600045C
        protected virtual System.Void OnPostSolveVirtual() { }
        // RVA: 0x025893E0  token: 0x600045D
        protected UnityEngine.Vector3 GetBendDirection(UnityEngine.Vector3 IKPosition, UnityEngine.Vector3 bendNormal) { }
        // RVA: 0x029ED430  token: 0x600045E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x188
    public class IKSolverVR : RootMotion.FinalIK.IKSolver
    {
        // Fields
        private UnityEngine.Animator <animator>k__BackingField;  // 0x58
        private UnityEngine.Transform[] solverTransforms;  // 0x60
        private System.Boolean hasChest;  // 0x68
        private System.Boolean hasNeck;  // 0x69
        private System.Boolean hasShoulders;  // 0x6a
        private System.Boolean hasToes;  // 0x6b
        private System.Boolean hasLegs;  // 0x6c
        private System.Boolean hasArms;  // 0x6d
        private UnityEngine.Vector3[] readPositions;  // 0x70
        private UnityEngine.Quaternion[] readRotations;  // 0x78
        private UnityEngine.Vector3[] solvedPositions;  // 0x80
        private UnityEngine.Quaternion[] solvedRotations;  // 0x88
        private UnityEngine.Quaternion[] defaultLocalRotations;  // 0x90
        private UnityEngine.Vector3[] defaultLocalPositions;  // 0x98
        private UnityEngine.Vector3 rootV;  // 0xa0
        private UnityEngine.Vector3 rootVelocity;  // 0xac
        private UnityEngine.Vector3 bodyOffset;  // 0xb8
        private System.Int32 supportLegIndex;  // 0xc4
        private System.Int32 lastLOD;  // 0xc8
        private System.Single lastLocomotionWeight;  // 0xcc
        public System.Int32 LOD;  // 0xd0
        public System.Single scale;  // 0xd4
        public System.Boolean plantFeet;  // 0xd8
        private RootMotion.FinalIK.IKSolverVR.VirtualBone <rootBone>k__BackingField;  // 0xe0
        public RootMotion.FinalIK.IKSolverVR.Spine spine;  // 0xe8
        public RootMotion.FinalIK.IKSolverVR.Arm leftArm;  // 0xf0
        public RootMotion.FinalIK.IKSolverVR.Arm rightArm;  // 0xf8
        public RootMotion.FinalIK.IKSolverVR.Leg leftLeg;  // 0x100
        public RootMotion.FinalIK.IKSolverVR.Leg rightLeg;  // 0x108
        public RootMotion.FinalIK.IKSolverVR.Locomotion locomotion;  // 0x110
        private RootMotion.FinalIK.IKSolverVR.Leg[] legs;  // 0x118
        private RootMotion.FinalIK.IKSolverVR.Arm[] arms;  // 0x120
        private UnityEngine.Vector3 headPosition;  // 0x128
        private UnityEngine.Vector3 headDeltaPosition;  // 0x134
        private UnityEngine.Vector3 raycastOriginPelvis;  // 0x140
        private UnityEngine.Vector3 lastOffset;  // 0x14c
        private UnityEngine.Vector3 debugPos1;  // 0x158
        private UnityEngine.Vector3 debugPos2;  // 0x164
        private UnityEngine.Vector3 debugPos3;  // 0x170
        private UnityEngine.Vector3 debugPos4;  // 0x17c

        // Properties
        UnityEngine.Animator animator { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone { get; /* RVA: 0x03D51140 */ set; /* RVA: 0x0589D964 */ }

        // Methods
        // RVA: 0x0962CEC0  token: 0x6000465
        public System.Void SetToReferences(RootMotion.FinalIK.VRIK.References references) { }
        // RVA: 0x0962BCBC  token: 0x6000466
        public System.Void GuessHandOrientations(RootMotion.FinalIK.VRIK.References references, System.Boolean onlyIfZero) { }
        // RVA: 0x0962ADD0  token: 0x6000467
        public System.Void DefaultAnimationCurves() { }
        // RVA: 0x0962A978  token: 0x6000468
        public System.Void AddPositionOffset(RootMotion.FinalIK.IKSolverVR.PositionOffset positionOffset, UnityEngine.Vector3 value) { }
        // RVA: 0x0962AC84  token: 0x6000469
        public System.Void AddRotationOffset(RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset, UnityEngine.Vector3 value) { }
        // RVA: 0x0962ACDC  token: 0x600046A
        public System.Void AddRotationOffset(RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset, UnityEngine.Quaternion value) { }
        // RVA: 0x0962A82C  token: 0x600046B
        public System.Void AddPlatformMotion(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation, UnityEngine.Vector3 platformPivot) { }
        // RVA: 0x0962CD88  token: 0x600046C
        public System.Void Reset() { }
        // RVA: 0x0962E9EC  token: 0x600046D
        public virtual System.Void StoreDefaultLocalState() { }
        // RVA: 0x0962AF88  token: 0x600046E
        public virtual System.Void FixTransforms() { }
        // RVA: 0x0962BB48  token: 0x600046F
        public virtual RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        // RVA: 0x0962BAF8  token: 0x6000470
        public virtual RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        // RVA: 0x0962C008  token: 0x6000471
        public virtual System.Boolean IsValid(System.String& message) { }
        // RVA: 0x0962B15C  token: 0x6000472
        private UnityEngine.Vector3 GetNormal(UnityEngine.Transform[] transforms) { }
        // RVA: 0x0962BBF8  token: 0x6000473
        private static UnityEngine.Keyframe[] GetSineKeyframes(System.Single mag) { }
        // RVA: 0x0962EB44  token: 0x6000474
        private System.Void UpdateSolverTransforms() { }
        // RVA: 0x0962C28C  token: 0x6000475
        protected virtual System.Void OnInitiate() { }
        // RVA: 0x0962C2E0  token: 0x6000476
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0962EC88  token: 0x6000477
        private System.Void WriteTransforms() { }
        // RVA: 0x0962C820  token: 0x6000478
        private System.Void Read(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Boolean hasArms) { }
        // RVA: 0x0962D1C4  token: 0x6000479
        private System.Void Solve() { }
        // RVA: 0x0962BB98  token: 0x600047A
        private UnityEngine.Vector3 GetPosition(System.Int32 index) { }
        // RVA: 0x0962BBC8  token: 0x600047B
        private UnityEngine.Quaternion GetRotation(System.Int32 index) { }
        // RVA: 0x0962F160  token: 0x600047E
        private System.Void Write() { }
        // RVA: 0x0962B410  token: 0x600047F
        private UnityEngine.Vector3 GetPelvisOffset(System.Single deltaTime) { }
        // RVA: 0x0962F2C0  token: 0x6000480
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008C  // size: 0x28
    public class TwistRelaxer : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.IK ik;  // 0x18
        public RootMotion.FinalIK.TwistSolver[] twistSolvers;  // 0x20

        // Methods
        // RVA: 0x09640138  token: 0x600050D
        public System.Void Start() { }
        // RVA: 0x096402F0  token: 0x600050E
        private System.Void Update() { }
        // RVA: 0x096400AC  token: 0x600050F
        private System.Void OnPostUpdate() { }
        // RVA: 0x0963FEF4  token: 0x6000510
        private System.Void LateUpdate() { }
        // RVA: 0x0963FF80  token: 0x6000511
        private System.Void OnDestroy() { }
        // RVA: 0x0964038C  token: 0x6000512
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008D  // size: 0x90
    public class TwistSolver
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public UnityEngine.Transform parent;  // 0x18
        public UnityEngine.Transform[] children;  // 0x20
        public System.Single weight;  // 0x28
        public System.Single parentChildCrossfade;  // 0x2c
        public System.Single twistAngleOffset;  // 0x30
        private UnityEngine.Vector3 twistAxis;  // 0x34
        private UnityEngine.Vector3 axis;  // 0x40
        private UnityEngine.Vector3 axisRelativeToParentDefault;  // 0x4c
        private UnityEngine.Vector3 axisRelativeToChildDefault;  // 0x58
        private UnityEngine.Quaternion[] childRotations;  // 0x68
        private System.Boolean inititated;  // 0x70
        private UnityEngine.Quaternion defaultLocalRotation;  // 0x74
        private UnityEngine.Quaternion[] defaultChildLocalRotations;  // 0x88

        // Methods
        // RVA: 0x09640EB0  token: 0x6000513
        public System.Void .ctor() { }
        // RVA: 0x09640490  token: 0x6000514
        public System.Void Initiate() { }
        // RVA: 0x096403DC  token: 0x6000515
        public System.Void FixTransforms() { }
        // RVA: 0x09640A4C  token: 0x6000516
        public System.Void Relax() { }

    }

    // TypeToken: 0x200008E  // size: 0xD0
    public class InteractionEffector
    {
        // Fields
        private RootMotion.FinalIK.FullBodyBipedEffector <effectorType>k__BackingField;  // 0x10
        private System.Boolean <isPaused>k__BackingField;  // 0x14
        private RootMotion.FinalIK.InteractionObject <interactionObject>k__BackingField;  // 0x18
        private RootMotion.FinalIK.Poser poser;  // 0x20
        private RootMotion.FinalIK.IKEffector effector;  // 0x28
        private System.Single timer;  // 0x30
        private System.Single length;  // 0x34
        private System.Single weight;  // 0x38
        private System.Single fadeInSpeed;  // 0x3c
        private System.Single defaultPositionWeight;  // 0x40
        private System.Single defaultRotationWeight;  // 0x44
        private System.Single defaultPull;  // 0x48
        private System.Single defaultReach;  // 0x4c
        private System.Single defaultPush;  // 0x50
        private System.Single defaultPushParent;  // 0x54
        private System.Single defaultBendGoalWeight;  // 0x58
        private System.Single resetTimer;  // 0x5c
        private System.Boolean positionWeightUsed;  // 0x60
        private System.Boolean rotationWeightUsed;  // 0x61
        private System.Boolean pullUsed;  // 0x62
        private System.Boolean reachUsed;  // 0x63
        private System.Boolean pushUsed;  // 0x64
        private System.Boolean pushParentUsed;  // 0x65
        private System.Boolean bendGoalWeightUsed;  // 0x66
        private System.Boolean pickedUp;  // 0x67
        private System.Boolean defaults;  // 0x68
        private System.Boolean pickUpOnPostFBBIK;  // 0x69
        private UnityEngine.Vector3 pickUpPosition;  // 0x6c
        private UnityEngine.Vector3 pausePositionRelative;  // 0x78
        private UnityEngine.Quaternion pickUpRotation;  // 0x84
        private UnityEngine.Quaternion pauseRotationRelative;  // 0x94
        private RootMotion.FinalIK.InteractionTarget interactionTarget;  // 0xa8
        private UnityEngine.Transform target;  // 0xb0
        private System.Collections.Generic.List<System.Boolean> triggered;  // 0xb8
        private RootMotion.FinalIK.InteractionSystem interactionSystem;  // 0xc0
        private System.Boolean started;  // 0xc8

        // Properties
        RootMotion.FinalIK.FullBodyBipedEffector effectorType { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.Boolean isPaused { get; /* RVA: 0x03D58C00 */ set; /* RVA: 0x03D58C20 */ }
        RootMotion.FinalIK.InteractionObject interactionObject { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean inInteraction { get; /* RVA: 0x09635900 */ }
        System.Single progress { get; /* RVA: 0x09635950 */ }

        // Methods
        // RVA: 0x09635874  token: 0x600051E
        public System.Void .ctor(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x09633AD4  token: 0x600051F
        public System.Void Initiate(RootMotion.FinalIK.InteractionSystem interactionSystem) { }
        // RVA: 0x09634D40  token: 0x6000520
        private System.Void StoreDefaults() { }
        // RVA: 0x09634244  token: 0x6000521
        public System.Boolean ResetToDefaults(System.Single speed, System.Single deltaTime) { }
        // RVA: 0x09633E78  token: 0x6000522
        public System.Boolean Pause() { }
        // RVA: 0x096346B4  token: 0x6000523
        public System.Boolean Resume() { }
        // RVA: 0x09634B10  token: 0x6000524
        public System.Boolean Start(RootMotion.FinalIK.InteractionObject interactionObject, System.String tag, System.Single fadeInTime, System.Boolean interrupt) { }
        // RVA: 0x09634708  token: 0x6000525
        public System.Boolean Start(RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionTarget interactionTarget, System.Single fadeInTime, System.Boolean interrupt) { }
        // RVA: 0x096351D8  token: 0x6000526
        public System.Void Update(UnityEngine.Transform root, System.Single speed, System.Single deltaTime) { }
        // RVA: 0x09634F30  token: 0x6000528
        private System.Void TriggerUntriggeredEvents(System.Boolean checkTime, System.Boolean& pickUp, System.Boolean& pause) { }
        // RVA: 0x09633F98  token: 0x6000529
        private System.Void PickUp(UnityEngine.Transform root) { }
        // RVA: 0x09634C18  token: 0x600052A
        public System.Boolean Stop() { }
        // RVA: 0x09633B8C  token: 0x600052B
        public System.Void OnPostFBBIK() { }

    }

    // TypeToken: 0x200008F  // size: 0x40
    public class InteractionLookAt
    {
        // Fields
        public RootMotion.FinalIK.LookAtIK ik;  // 0x10
        public System.Single lerpSpeed;  // 0x18
        public System.Single weightSpeed;  // 0x1c
        public System.Boolean isPaused;  // 0x20
        private UnityEngine.Transform lookAtTarget;  // 0x28
        private System.Single stopLookTime;  // 0x30
        private System.Single weight;  // 0x34
        private System.Boolean firstFBBIKSolve;  // 0x38

        // Methods
        // RVA: 0x0964844C  token: 0x600052C
        public System.Void Look(UnityEngine.Transform target, System.Single time) { }
        // RVA: 0x096485D8  token: 0x600052D
        public System.Void OnFixTransforms() { }
        // RVA: 0x09648830  token: 0x600052E
        public System.Void Update() { }
        // RVA: 0x0964871C  token: 0x600052F
        public System.Void SolveSpine() { }
        // RVA: 0x09648658  token: 0x6000530
        public System.Void SolveHead() { }
        // RVA: 0x03D74DA0  token: 0x6000531
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000090  // size: 0x60
    public class InteractionObject : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform otherLookAtTarget;  // 0x18
        public UnityEngine.Transform otherTargetsRoot;  // 0x20
        public UnityEngine.Transform positionOffsetSpace;  // 0x28
        public RootMotion.FinalIK.InteractionObject.WeightCurve[] weightCurves;  // 0x30
        public RootMotion.FinalIK.InteractionObject.Multiplier[] multipliers;  // 0x38
        public RootMotion.FinalIK.InteractionObject.InteractionEvent[] events;  // 0x40
        private System.Single <length>k__BackingField;  // 0x48
        private RootMotion.FinalIK.InteractionSystem <lastUsedInteractionSystem>k__BackingField;  // 0x50
        private RootMotion.FinalIK.InteractionTarget[] targets;  // 0x58

        // Properties
        System.Single length { get; /* RVA: 0x03D58370 */ set; /* RVA: 0x03D5BE60 */ }
        RootMotion.FinalIK.InteractionSystem lastUsedInteractionSystem { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        UnityEngine.Transform lookAtTarget { get; /* RVA: 0x09649DD8 */ }
        UnityEngine.Transform targetsRoot { get; /* RVA: 0x09649E40 */ }

        // Methods
        // RVA: 0x09649D18  token: 0x6000532
        private System.Void OpenUserManual() { }
        // RVA: 0x09649C14  token: 0x6000533
        private System.Void OpenScriptReference() { }
        // RVA: 0x09649C48  token: 0x6000534
        private System.Void OpenTutorial1() { }
        // RVA: 0x09649C7C  token: 0x6000535
        private System.Void OpenTutorial2() { }
        // RVA: 0x09649CB0  token: 0x6000536
        private System.Void OpenTutorial3() { }
        // RVA: 0x09649CE4  token: 0x6000537
        private System.Void OpenTutorial4() { }
        // RVA: 0x09649D54  token: 0x6000538
        private System.Void SupportGroup() { }
        // RVA: 0x09648A54  token: 0x6000539
        private System.Void ASThread() { }
        // RVA: 0x09649A60  token: 0x600053E
        public System.Void Initiate() { }
        // RVA: 0x09649668  token: 0x6000540
        public RootMotion.FinalIK.InteractionTarget GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionSystem interactionSystem) { }
        // RVA: 0x09649484  token: 0x6000541
        public System.Boolean CurveUsed(RootMotion.FinalIK.InteractionObject.WeightCurve.Type type) { }
        // RVA: 0x03D4EAA0  token: 0x6000542
        public RootMotion.FinalIK.InteractionTarget[] GetTargets() { }
        // RVA: 0x09649550  token: 0x6000543
        public UnityEngine.Transform GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType, System.String tag) { }
        // RVA: 0x02C926C0  token: 0x6000544
        public System.Void OnStartInteraction(RootMotion.FinalIK.InteractionSystem interactionSystem) { }
        // RVA: 0x09648A88  token: 0x6000545
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionTarget target, System.Single timer, System.Single weight) { }
        // RVA: 0x096497FC  token: 0x6000546
        public System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType, RootMotion.FinalIK.InteractionTarget target, System.Single timer) { }
        // RVA: 0x09649D4C  token: 0x6000548
        private System.Void Start() { }
        // RVA: 0x09648EE8  token: 0x6000549
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject.WeightCurve.Type type, System.Single value, System.Single weight) { }
        // RVA: 0x0964979C  token: 0x600054A
        private UnityEngine.Transform GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x09649A0C  token: 0x600054B
        private System.Int32 GetWeightCurveIndex(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType) { }
        // RVA: 0x096494FC  token: 0x600054C
        private System.Int32 GetMultiplierIndex(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType) { }
        // RVA: 0x09649D88  token: 0x600054D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000097  // size: 0x108
    public class InteractionSystem : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String targetTag;  // 0x18
        public System.Single fadeInTime;  // 0x20
        public System.Single speed;  // 0x24
        public System.Single resetToDefaultsSpeed;  // 0x28
        public UnityEngine.Collider characterCollider;  // 0x30
        public UnityEngine.Transform FPSCamera;  // 0x38
        public UnityEngine.LayerMask camRaycastLayers;  // 0x40
        public System.Single camRaycastDistance;  // 0x44
        private System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> <triggersInRange>k__BackingField;  // 0x48
        private System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> inContact;  // 0x50
        private System.Collections.Generic.List<System.Int32> bestRangeIndexes;  // 0x58
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionStart;  // 0x60
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionPause;  // 0x68
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionPickUp;  // 0x70
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionResume;  // 0x78
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionStop;  // 0x80
        public RootMotion.FinalIK.InteractionSystem.InteractionEventDelegate OnInteractionEvent;  // 0x88
        public UnityEngine.RaycastHit raycastHit;  // 0x90
        private RootMotion.FinalIK.FullBodyBipedIK fullBody;  // 0xd0
        public RootMotion.FinalIK.InteractionLookAt lookAt;  // 0xd8
        private RootMotion.FinalIK.InteractionEffector[] interactionEffectors;  // 0xe0
        private System.Boolean <initiated>k__BackingField;  // 0xe8
        private UnityEngine.Collider lastCollider;  // 0xf0
        private UnityEngine.Collider c;  // 0xf8
        private System.Single lastTime;  // 0x100

        // Properties
        System.Boolean inInteraction { get; /* RVA: 0x0964D634 */ }
        RootMotion.FinalIK.FullBodyBipedIK ik { get; /* RVA: 0x03D50050 */ set; /* RVA: 0x0554A7E0 */ }
        System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> triggersInRange { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        System.Boolean initiated { get; /* RVA: 0x03D554A0 */ set; /* RVA: 0x03D554D0 */ }

        // Methods
        // RVA: 0x0964B74C  token: 0x600055A
        private System.Void OpenUserManual() { }
        // RVA: 0x0964B648  token: 0x600055B
        private System.Void OpenScriptReference() { }
        // RVA: 0x0964B67C  token: 0x600055C
        private System.Void OpenTutorial1() { }
        // RVA: 0x0964B6B0  token: 0x600055D
        private System.Void OpenTutorial2() { }
        // RVA: 0x0964B6E4  token: 0x600055E
        private System.Void OpenTutorial3() { }
        // RVA: 0x0964B718  token: 0x600055F
        private System.Void OpenTutorial4() { }
        // RVA: 0x0964C31C  token: 0x6000560
        private System.Void SupportGroup() { }
        // RVA: 0x09649EA8  token: 0x6000561
        private System.Void ASThread() { }
        // RVA: 0x0964A938  token: 0x6000563
        public System.Boolean IsInInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964AB58  token: 0x6000564
        public System.Boolean IsPaused(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964AAC8  token: 0x6000565
        public System.Boolean IsPaused() { }
        // RVA: 0x0964A9E8  token: 0x6000566
        public System.Boolean IsInSync() { }
        // RVA: 0x0964BB14  token: 0x6000567
        public System.Boolean StartInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, System.Boolean interrupt) { }
        // RVA: 0x0964BA28  token: 0x6000568
        public System.Boolean StartInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionTarget target, System.Boolean interrupt) { }
        // RVA: 0x0964B7E4  token: 0x6000569
        public System.Boolean PauseInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964B9AC  token: 0x600056A
        public System.Boolean ResumeInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964C2A0  token: 0x600056B
        public System.Boolean StopInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964B780  token: 0x600056C
        public System.Void PauseAll() { }
        // RVA: 0x0964B948  token: 0x600056D
        public System.Void ResumeAll() { }
        // RVA: 0x0964C24C  token: 0x600056E
        public System.Void StopAll() { }
        // RVA: 0x0964A63C  token: 0x600056F
        public RootMotion.FinalIK.InteractionObject GetInteractionObject(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964A774  token: 0x6000570
        public System.Single GetProgress(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        // RVA: 0x0964A6B8  token: 0x6000571
        public System.Single GetMinActiveProgress() { }
        // RVA: 0x0964CB38  token: 0x6000572
        public System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt) { }
        // RVA: 0x0964C6D8  token: 0x6000573
        public System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt, RootMotion.FinalIK.InteractionObject& interactionObject) { }
        // RVA: 0x0964C8BC  token: 0x6000574
        public System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt, RootMotion.FinalIK.InteractionTarget& interactionTarget) { }
        // RVA: 0x0964A1B4  token: 0x6000575
        public RootMotion.FinalIK.InteractionTrigger.Range GetClosestInteractionRange() { }
        // RVA: 0x0964A088  token: 0x6000576
        public RootMotion.FinalIK.InteractionObject GetClosestInteractionObjectInRange() { }
        // RVA: 0x0964A28C  token: 0x6000577
        public RootMotion.FinalIK.InteractionTarget GetClosestInteractionTargetInRange() { }
        // RVA: 0x0964A0C8  token: 0x6000578
        public RootMotion.FinalIK.InteractionObject[] GetClosestInteractionObjectsInRange() { }
        // RVA: 0x0964A2FC  token: 0x6000579
        public RootMotion.FinalIK.InteractionTarget[] GetClosestInteractionTargetsInRange() { }
        // RVA: 0x0964C350  token: 0x600057A
        public System.Boolean TriggerEffectorsReady(System.Int32 index) { }
        // RVA: 0x0964A7F4  token: 0x600057B
        public RootMotion.FinalIK.InteractionTrigger.Range GetTriggerRange(System.Int32 index) { }
        // RVA: 0x0964A458  token: 0x600057C
        public System.Int32 GetClosestTriggerIndex() { }
        // RVA: 0x0964BC00  token: 0x6000583
        public System.Void Start() { }
        // RVA: 0x0964A8F8  token: 0x6000584
        private System.Void InteractionPause(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        // RVA: 0x0964A918  token: 0x6000585
        private System.Void InteractionResume(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        // RVA: 0x0964A918  token: 0x6000586
        private System.Void InteractionStop(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        // RVA: 0x0964ACCC  token: 0x6000587
        private System.Void LookAtInteraction(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        // RVA: 0x0964B480  token: 0x6000588
        public System.Void OnTriggerEnter(UnityEngine.Collider c) { }
        // RVA: 0x0964B578  token: 0x6000589
        public System.Void OnTriggerExit(UnityEngine.Collider c) { }
        // RVA: 0x09649EDC  token: 0x600058A
        private System.Boolean ContactIsInRange(System.Int32 index, System.Int32& bestRangeIndex) { }
        // RVA: 0x0964B238  token: 0x600058B
        private System.Void OnDrawGizmosSelected() { }
        // RVA: 0x0964D044  token: 0x600058C
        public System.Void Update() { }
        // RVA: 0x0964B860  token: 0x600058D
        private System.Void Raycasting() { }
        // RVA: 0x0964CDF8  token: 0x600058E
        private System.Void UpdateTriggerEventBroadcasting() { }
        // RVA: 0x0964B318  token: 0x600058F
        private System.Void OnEnable() { }
        // RVA: 0x0964CCCC  token: 0x6000590
        private System.Void UpdateEffectors() { }
        // RVA: 0x0964B404  token: 0x6000591
        private System.Void OnPreFBBIK() { }
        // RVA: 0x0964B35C  token: 0x6000592
        private System.Void OnPostFBBIK() { }
        // RVA: 0x0964B338  token: 0x6000593
        private System.Void OnFixTransforms() { }
        // RVA: 0x0964AD38  token: 0x6000594
        private System.Void OnDestroy() { }
        // RVA: 0x0964AC04  token: 0x6000595
        private System.Boolean IsValid(System.Boolean log) { }
        // RVA: 0x0964C5F0  token: 0x6000596
        private System.Boolean TriggerIndexIsValid(System.Int32 index) { }
        // RVA: 0x0964D254  token: 0x6000597
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009A  // size: 0x70
    public class InteractionTarget : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effectorType;  // 0x18
        public RootMotion.FinalIK.InteractionTarget.Multiplier[] multipliers;  // 0x20
        public System.Single interactionSpeedMlp;  // 0x28
        public UnityEngine.Transform pivot;  // 0x30
        public RootMotion.FinalIK.InteractionTarget.RotationMode rotationMode;  // 0x38
        public UnityEngine.Vector3 twistAxis;  // 0x3c
        public System.Single twistWeight;  // 0x48
        public System.Single swingWeight;  // 0x4c
        public System.Single threeDOFWeight;  // 0x50
        public System.Boolean rotateOnce;  // 0x54
        private UnityEngine.Quaternion defaultLocalRotation;  // 0x58
        private UnityEngine.Transform lastPivot;  // 0x68

        // Methods
        // RVA: 0x0964D85C  token: 0x60005A0
        private System.Void OpenUserManual() { }
        // RVA: 0x0964D758  token: 0x60005A1
        private System.Void OpenScriptReference() { }
        // RVA: 0x0964D78C  token: 0x60005A2
        private System.Void OpenTutorial1() { }
        // RVA: 0x0964D7C0  token: 0x60005A3
        private System.Void OpenTutorial2() { }
        // RVA: 0x0964D7F4  token: 0x60005A4
        private System.Void OpenTutorial3() { }
        // RVA: 0x0964D828  token: 0x60005A5
        private System.Void OpenTutorial4() { }
        // RVA: 0x0964DF8C  token: 0x60005A6
        private System.Void SupportGroup() { }
        // RVA: 0x0964D6C4  token: 0x60005A7
        private System.Void ASThread() { }
        // RVA: 0x0964D6F8  token: 0x60005A8
        public System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve.Type curveType) { }
        // RVA: 0x0964D890  token: 0x60005A9
        public System.Void ResetRotation() { }
        // RVA: 0x0964D90C  token: 0x60005AA
        public System.Void RotateTo(UnityEngine.Transform bone) { }
        // RVA: 0x0964DFC0  token: 0x60005AB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009D  // size: 0x20
    public class InteractionTrigger : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.InteractionTrigger.Range[] ranges;  // 0x18

        // Methods
        // RVA: 0x0964E248  token: 0x60005AD
        private System.Void OpenUserManual() { }
        // RVA: 0x0964E1E0  token: 0x60005AE
        private System.Void OpenScriptReference() { }
        // RVA: 0x0964E214  token: 0x60005AF
        private System.Void OpenTutorial4() { }
        // RVA: 0x0964E27C  token: 0x60005B0
        private System.Void SupportGroup() { }
        // RVA: 0x0964DFFC  token: 0x60005B1
        private System.Void ASThread() { }
        // RVA: 0x0964E030  token: 0x60005B2
        public System.Int32 GetBestRangeIndex(UnityEngine.Transform character, UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit raycastHit) { }
        // RVA: 0x0964E2B0  token: 0x60005B3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2  // size: 0x58
    public class GenericPoser : RootMotion.FinalIK.Poser
    {
        // Fields
        public RootMotion.FinalIK.GenericPoser.Map[] maps;  // 0x50

        // Methods
        // RVA: 0x096468DC  token: 0x60005BE
        public virtual System.Void AutoMapping() { }
        // RVA: 0x09646BDC  token: 0x60005BF
        protected virtual System.Void InitiatePoser() { }
        // RVA: 0x09646C38  token: 0x60005C0
        protected virtual System.Void UpdatePoser() { }
        // RVA: 0x09646B0C  token: 0x60005C1
        protected virtual System.Void FixPoserTransforms() { }
        // RVA: 0x09646BE4  token: 0x60005C2
        private System.Void StoreDefaultState() { }
        // RVA: 0x09646B60  token: 0x60005C3
        private UnityEngine.Transform GetTargetNamed(System.String tName, UnityEngine.Transform[] array) { }
        // RVA: 0x09646D10  token: 0x60005C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4  // size: 0x78
    public class HandPoser : RootMotion.FinalIK.Poser
    {
        // Fields
        protected UnityEngine.Transform[] children;  // 0x50
        private UnityEngine.Transform _poseRoot;  // 0x58
        private UnityEngine.Transform[] poseChildren;  // 0x60
        private UnityEngine.Vector3[] defaultLocalPositions;  // 0x68
        private UnityEngine.Quaternion[] defaultLocalRotations;  // 0x70

        // Methods
        // RVA: 0x09646D18  token: 0x60005C9
        public virtual System.Void AutoMapping() { }
        // RVA: 0x09646EC4  token: 0x60005CA
        protected virtual System.Void InitiatePoser() { }
        // RVA: 0x09646DD0  token: 0x60005CB
        protected virtual System.Void FixPoserTransforms() { }
        // RVA: 0x09647078  token: 0x60005CC
        protected virtual System.Void UpdatePoser() { }
        // RVA: 0x09646F14  token: 0x60005CD
        protected System.Void StoreDefaultState() { }
        // RVA: 0x09646D10  token: 0x60005CE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A5  // size: 0x50
    public abstract class Poser : RootMotion.SolverManager
    {
        // Fields
        public UnityEngine.Transform poseRoot;  // 0x38
        public System.Single weight;  // 0x40
        public System.Single localRotationWeight;  // 0x44
        public System.Single localPositionWeight;  // 0x48
        private System.Boolean initiated;  // 0x4c

        // Methods
        // RVA: -1  // abstract  token: 0x60005CF
        public virtual System.Void AutoMapping() { }
        // RVA: 0x05FED3AC  token: 0x60005D0
        public System.Void UpdateManual() { }
        // RVA: -1  // abstract  token: 0x60005D1
        protected virtual System.Void InitiatePoser() { }
        // RVA: -1  // abstract  token: 0x60005D2
        protected virtual System.Void UpdatePoser() { }
        // RVA: -1  // abstract  token: 0x60005D3
        protected virtual System.Void FixPoserTransforms() { }
        // RVA: 0x0964F700  token: 0x60005D4
        protected virtual System.Void UpdateSolver() { }
        // RVA: 0x0964F6D8  token: 0x60005D5
        protected virtual System.Void InitiateSolver() { }
        // RVA: 0x0964F6C4  token: 0x60005D6
        protected virtual System.Void FixTransforms() { }
        // RVA: 0x0964F73C  token: 0x60005D7
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000A6  // size: 0x78
    public class RagdollUtility : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.IK ik;  // 0x18
        public System.Single ragdollToAnimationTime;  // 0x20
        public System.Boolean applyIkOnRagdoll;  // 0x24
        public System.Single applyVelocity;  // 0x28
        public System.Single applyAngularVelocity;  // 0x2c
        private UnityEngine.Animator animator;  // 0x30
        private RootMotion.FinalIK.RagdollUtility.Rigidbone[] rigidbones;  // 0x38
        private RootMotion.FinalIK.RagdollUtility.Child[] children;  // 0x40
        private System.Boolean enableRagdollFlag;  // 0x48
        private UnityEngine.AnimatorUpdateMode animatorUpdateMode;  // 0x4c
        private RootMotion.FinalIK.IK[] allIKComponents;  // 0x50
        private System.Boolean[] fixTransforms;  // 0x58
        private System.Single ragdollWeight;  // 0x60
        private System.Single ragdollWeightV;  // 0x64
        private System.Boolean fixedFrame;  // 0x68
        private System.Boolean[] disabledIKComponents;  // 0x70

        // Properties
        System.Boolean isRagdoll { get; /* RVA: 0x096509E0 */ }
        System.Boolean ikUsed { get; /* RVA: 0x096508E4 */ }

        // Methods
        // RVA: 0x0964FCD8  token: 0x60005D8
        public System.Void EnableRagdoll() { }
        // RVA: 0x0964FC90  token: 0x60005D9
        public System.Void DisableRagdoll() { }
        // RVA: 0x096501AC  token: 0x60005DA
        public System.Void Start() { }
        // RVA: 0x0964FC34  token: 0x60005DB
        private System.Collections.IEnumerator DisableRagdollSmooth() { }
        // RVA: 0x09650600  token: 0x60005DC
        private System.Void Update() { }
        // RVA: 0x0964FD5C  token: 0x60005DD
        private System.Void FixedUpdate() { }
        // RVA: 0x0964FD94  token: 0x60005DE
        private System.Void LateUpdate() { }
        // RVA: 0x0964FC08  token: 0x60005DF
        private System.Void AfterLastIK() { }
        // RVA: 0x0964FBD0  token: 0x60005E0
        private System.Void AfterAnimation() { }
        // RVA: 0x0964FF2C  token: 0x60005E1
        private System.Void OnFinalPose() { }
        // RVA: 0x0964FF68  token: 0x60005E2
        private System.Void RagdollEnabler() { }
        // RVA: 0x09650160  token: 0x60005E4
        private System.Void RecordVelocities() { }
        // RVA: 0x096505B4  token: 0x60005E6
        private System.Void StoreLocalState() { }
        // RVA: 0x0964FD00  token: 0x60005E7
        private System.Void FixTransforms(System.Single weight) { }
        // RVA: 0x0964FE00  token: 0x60005E8
        private System.Void OnDestroy() { }
        // RVA: 0x096507F0  token: 0x60005E9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AA  // size: 0x38
    public abstract class RotationLimit : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 axis;  // 0x18
        public UnityEngine.Quaternion defaultLocalRotation;  // 0x24
        private System.Boolean <defaultLocalRotationOverride>k__BackingField;  // 0x34
        private System.Boolean initiated;  // 0x35
        private System.Boolean applicationQuit;  // 0x36
        private System.Boolean defaultLocalRotationSet;  // 0x37

        // Properties
        UnityEngine.Vector3 secondaryAxis { get; /* RVA: 0x03D74DF0 */ }
        UnityEngine.Vector3 crossAxis { get; /* RVA: 0x09653DB4 */ }
        System.Boolean defaultLocalRotationOverride { get; /* RVA: 0x03D4F570 */ set; /* RVA: 0x03D4F590 */ }

        // Methods
        // RVA: 0x09653D50  token: 0x60005F6
        public System.Void SetDefaultLocalRotation() { }
        // RVA: 0x03D74DE0  token: 0x60005F7
        public System.Void SetDefaultLocalRotation(UnityEngine.Quaternion localRotation) { }
        // RVA: 0x09653934  token: 0x60005F8
        public UnityEngine.Quaternion GetLimitedLocalRotation(UnityEngine.Quaternion localRotation, System.Boolean& changed) { }
        // RVA: 0x096537A8  token: 0x60005F9
        public System.Boolean Apply() { }
        // RVA: 0x0965390C  token: 0x60005FA
        public System.Void Disable() { }
        // RVA: -1  // abstract  token: 0x60005FF
        protected virtual UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09653844  token: 0x6000600
        private System.Void Awake() { }
        // RVA: 0x09653AD0  token: 0x6000601
        private System.Void LateUpdate() { }
        // RVA: 0x095F8FD0  token: 0x6000602
        public System.Void LogWarning(System.String message) { }
        // RVA: 0x09653AD8  token: 0x6000603
        protected static UnityEngine.Quaternion Limit1DOF(UnityEngine.Quaternion rotation, UnityEngine.Vector3 axis) { }
        // RVA: 0x09653B88  token: 0x6000604
        protected static UnityEngine.Quaternion LimitTwist(UnityEngine.Quaternion rotation, UnityEngine.Vector3 axis, UnityEngine.Vector3 orthoAxis, System.Single twistLimit) { }
        // RVA: 0x09653A58  token: 0x6000605
        protected static System.Single GetOrthogonalAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 normal) { }
        // RVA: 0x09653D90  token: 0x6000606
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000AB  // size: 0x40
    public class RotationLimitAngle : RootMotion.FinalIK.RotationLimit
    {
        // Fields
        public System.Single limit;  // 0x38
        public System.Single twistLimit;  // 0x3c

        // Methods
        // RVA: 0x0965172C  token: 0x6000607
        private System.Void OpenUserManual() { }
        // RVA: 0x096516F8  token: 0x6000608
        private System.Void OpenScriptReference() { }
        // RVA: 0x09651760  token: 0x6000609
        private System.Void SupportGroup() { }
        // RVA: 0x096513F8  token: 0x600060A
        private System.Void ASThread() { }
        // RVA: 0x0965142C  token: 0x600060B
        protected virtual UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x096514F0  token: 0x600060C
        private UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09651794  token: 0x600060D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC  // size: 0x50
    public class RotationLimitHinge : RootMotion.FinalIK.RotationLimit
    {
        // Fields
        public System.Boolean useLimits;  // 0x38
        public System.Single min;  // 0x3c
        public System.Single max;  // 0x40
        public System.Single zeroAxisDisplayOffset;  // 0x44
        private System.Single lastAngle;  // 0x48

        // Methods
        // RVA: 0x09651A74  token: 0x600060E
        private System.Void OpenUserManual() { }
        // RVA: 0x09651A40  token: 0x600060F
        private System.Void OpenScriptReference() { }
        // RVA: 0x09651AA8  token: 0x6000610
        private System.Void SupportGroup() { }
        // RVA: 0x096517AC  token: 0x6000611
        private System.Void ASThread() { }
        // RVA: 0x09651A0C  token: 0x6000612
        protected virtual UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x096517E0  token: 0x6000613
        private UnityEngine.Quaternion LimitHinge(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09651ADC  token: 0x6000614
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD  // size: 0x58
    public class RotationLimitPolygonal : RootMotion.FinalIK.RotationLimit
    {
        // Fields
        public System.Single twistLimit;  // 0x38
        public System.Int32 smoothIterations;  // 0x3c
        public RootMotion.FinalIK.RotationLimitPolygonal.LimitPoint[] points;  // 0x40
        public UnityEngine.Vector3[] P;  // 0x48
        public RootMotion.FinalIK.RotationLimitPolygonal.ReachCone[] reachCones;  // 0x50

        // Methods
        // RVA: 0x09652460  token: 0x6000615
        private System.Void OpenUserManual() { }
        // RVA: 0x0965242C  token: 0x6000616
        private System.Void OpenScriptReference() { }
        // RVA: 0x09653130  token: 0x6000617
        private System.Void SupportGroup() { }
        // RVA: 0x09651AF8  token: 0x6000618
        private System.Void ASThread() { }
        // RVA: 0x0965297C  token: 0x6000619
        public System.Void SetLimitPoints(RootMotion.FinalIK.RotationLimitPolygonal.LimitPoint[] points) { }
        // RVA: 0x09652090  token: 0x600061A
        protected virtual UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09652F58  token: 0x600061B
        private System.Void Start() { }
        // RVA: 0x09652598  token: 0x600061C
        public System.Void ResetToDefault() { }
        // RVA: 0x09651B2C  token: 0x600061D
        public System.Void BuildReachCones() { }
        // RVA: 0x096529F0  token: 0x600061E
        private UnityEngine.Vector3[] SmoothPoints() { }
        // RVA: 0x09652040  token: 0x600061F
        private System.Single GetScalar(System.Int32 k) { }
        // RVA: 0x09652494  token: 0x6000620
        private UnityEngine.Vector3 PointToTangentPlane(UnityEngine.Vector3 p, System.Single r) { }
        // RVA: 0x09653164  token: 0x6000621
        private UnityEngine.Vector3 TangentPointToSphere(UnityEngine.Vector3 q, System.Single r) { }
        // RVA: 0x0965217C  token: 0x6000622
        private UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09651EF8  token: 0x6000623
        private System.Int32 GetReachCone(UnityEngine.Vector3 L) { }
        // RVA: 0x096532D0  token: 0x6000624
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0  // size: 0x48
    public class RotationLimitSpline : RootMotion.FinalIK.RotationLimit
    {
        // Fields
        public System.Single twistLimit;  // 0x38
        public UnityEngine.AnimationCurve spline;  // 0x40

        // Methods
        // RVA: 0x09653710  token: 0x600062D
        private System.Void OpenUserManual() { }
        // RVA: 0x096536DC  token: 0x600062E
        private System.Void OpenScriptReference() { }
        // RVA: 0x09653764  token: 0x600062F
        private System.Void SupportGroup() { }
        // RVA: 0x09653328  token: 0x6000630
        private System.Void ASThread() { }
        // RVA: 0x09653744  token: 0x6000631
        public System.Void SetSpline(UnityEngine.Keyframe[] keyframes) { }
        // RVA: 0x0965335C  token: 0x6000632
        protected virtual UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09653420  token: 0x6000633
        public UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation) { }
        // RVA: 0x09653798  token: 0x6000634
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1  // size: 0xD0
    public class AimController : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.AimIK ik;  // 0x18
        public System.Single weight;  // 0x20
        public UnityEngine.Transform target;  // 0x28
        public System.Single targetSwitchSmoothTime;  // 0x30
        public System.Single weightSmoothTime;  // 0x34
        public System.Boolean smoothTurnTowardsTarget;  // 0x38
        public System.Single maxRadiansDelta;  // 0x3c
        public System.Single maxMagnitudeDelta;  // 0x40
        public System.Single slerpSpeed;  // 0x44
        public System.Single smoothDampTime;  // 0x48
        public UnityEngine.Vector3 pivotOffsetFromRoot;  // 0x4c
        public System.Single minDistance;  // 0x58
        public UnityEngine.Vector3 offset;  // 0x5c
        public System.Single maxRootAngle;  // 0x68
        public System.Boolean turnToTarget;  // 0x6c
        public System.Single turnToTargetTime;  // 0x70
        public System.Boolean useAnimatedAimDirection;  // 0x74
        public UnityEngine.Vector3 animatedAimDirection;  // 0x78
        private UnityEngine.Transform lastTarget;  // 0x88
        private System.Single switchWeight;  // 0x90
        private System.Single switchWeightV;  // 0x94
        private System.Single weightV;  // 0x98
        private UnityEngine.Vector3 lastPosition;  // 0x9c
        private UnityEngine.Vector3 dir;  // 0xa8
        private System.Boolean lastSmoothTowardsTarget;  // 0xb4
        private System.Boolean turningToTarget;  // 0xb5
        private System.Single turnToTargetMlp;  // 0xb8
        private System.Single turnToTargetMlpV;  // 0xbc
        private System.Single yawV;  // 0xc0
        private System.Single pitchV;  // 0xc4
        private System.Single dirMagV;  // 0xc8

        // Properties
        UnityEngine.Vector3 pivot { get; /* RVA: 0x09643748 */ }

        // Methods
        // RVA: 0x0964356C  token: 0x6000635
        private System.Void Start() { }
        // RVA: 0x09642918  token: 0x6000636
        private System.Void LateUpdate() { }
        // RVA: 0x096427E0  token: 0x6000638
        private System.Void ApplyMinDistance() { }
        // RVA: 0x096432A8  token: 0x6000639
        private System.Void RootRotation() { }
        // RVA: 0x0964365C  token: 0x600063A
        private System.Collections.IEnumerator TurnToTarget() { }
        // RVA: 0x096436B8  token: 0x600063B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3  // size: 0x28
    public class AimPoser : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single angleBuffer;  // 0x18
        public RootMotion.FinalIK.AimPoser.Pose[] poses;  // 0x20

        // Methods
        // RVA: 0x09643850  token: 0x6000642
        public RootMotion.FinalIK.AimPoser.Pose GetPose(UnityEngine.Vector3 localDirection) { }
        // RVA: 0x09643918  token: 0x6000643
        public System.Void SetPoseActive(RootMotion.FinalIK.AimPoser.Pose pose) { }
        // RVA: 0x09643978  token: 0x6000644
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5  // size: 0x38
    public class Amplifier : RootMotion.FinalIK.OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.Amplifier.Body[] bodies;  // 0x30

        // Methods
        // RVA: 0x096439D0  token: 0x6000648
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x07B4A6A8  token: 0x6000649
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8  // size: 0x58
    public class BodyTilt : RootMotion.FinalIK.OffsetModifier
    {
        // Fields
        public System.Single tiltSpeed;  // 0x30
        public System.Single tiltSensitivity;  // 0x34
        public RootMotion.FinalIK.OffsetPose poseLeft;  // 0x38
        public RootMotion.FinalIK.OffsetPose poseRight;  // 0x40
        private System.Single tiltAngle;  // 0x48
        private UnityEngine.Vector3 lastForward;  // 0x4c

        // Methods
        // RVA: 0x09643EE0  token: 0x600064E
        protected virtual System.Void Start() { }
        // RVA: 0x09643D04  token: 0x600064F
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x09643F2C  token: 0x6000650
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9  // size: 0x28
    public class CCDBendGoal : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.CCDIK ik;  // 0x18
        public System.Single weight;  // 0x20

        // Methods
        // RVA: 0x09644E00  token: 0x6000651
        private System.Void Start() { }
        // RVA: 0x096449F0  token: 0x6000652
        private System.Void BeforeIK() { }
        // RVA: 0x09644CD8  token: 0x6000653
        private System.Void OnDestroy() { }
        // RVA: 0x03CFE7F0  token: 0x6000654
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA  // size: 0x38
    public class EditorIK : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator animator;  // 0x18
        public RootMotion.FinalIK.EditorIKPose defaultPose;  // 0x20
        public UnityEngine.Transform[] bones;  // 0x28
        private RootMotion.FinalIK.IK <ik>k__BackingField;  // 0x30

        // Properties
        RootMotion.FinalIK.IK ik { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x09646350  token: 0x6000657
        private System.Void OnEnable() { }
        // RVA: 0x09646284  token: 0x6000658
        private System.Void OnDisable() { }
        // RVA: 0x0964614C  token: 0x6000659
        private System.Void OnDestroy() { }
        // RVA: 0x09646498  token: 0x600065A
        public System.Void StoreDefaultPose() { }
        // RVA: 0x09645F7C  token: 0x600065B
        public System.Boolean Initiate() { }
        // RVA: 0x09646510  token: 0x600065C
        public System.Void Update() { }
        // RVA: 0x096467A0  token: 0x600065D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB  // size: 0x28
    public class EditorIKPose : UnityEngine.ScriptableObject
    {
        // Fields
        public UnityEngine.Vector3[] localPositions;  // 0x18
        public UnityEngine.Quaternion[] localRotations;  // 0x20

        // Properties
        System.Boolean poseStored { get; /* RVA: 0x09645F5C */ }

        // Methods
        // RVA: 0x09645D98  token: 0x600065F
        public System.Void Store(UnityEngine.Transform[] T) { }
        // RVA: 0x09645C40  token: 0x6000660
        public System.Boolean Restore(UnityEngine.Transform[] T) { }
        // RVA: 0x09645EE4  token: 0x6000661
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC  // size: 0x40
    public class HitReaction : RootMotion.FinalIK.OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.HitReaction.HitPointEffector[] effectorHitPoints;  // 0x30
        public RootMotion.FinalIK.HitReaction.HitPointBone[] boneHitPoints;  // 0x38

        // Properties
        System.Boolean inProgress { get; /* RVA: 0x09648110 */ }

        // Methods
        // RVA: 0x09648068  token: 0x6000663
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x09647E88  token: 0x6000664
        public System.Void Hit(UnityEngine.Collider collider, UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        // RVA: 0x07B4A6A8  token: 0x6000665
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C2  // size: 0x48
    public class HitReactionVRIK : RootMotion.FinalIK.OffsetModifierVRIK
    {
        // Fields
        public UnityEngine.AnimationCurve[] offsetCurves;  // 0x30
        public RootMotion.FinalIK.HitReactionVRIK.PositionOffset[] positionOffsets;  // 0x38
        public RootMotion.FinalIK.HitReactionVRIK.RotationOffset[] rotationOffsets;  // 0x40

        // Methods
        // RVA: 0x09647DE4  token: 0x6000682
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x09647BFC  token: 0x6000683
        public System.Void Hit(UnityEngine.Collider collider, UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        // RVA: 0x07B4A6A8  token: 0x6000684
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8  // size: 0x40
    public class Inertia : RootMotion.FinalIK.OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.Inertia.Body[] bodies;  // 0x30
        public RootMotion.FinalIK.OffsetModifier.OffsetLimits[] limits;  // 0x38

        // Methods
        // RVA: 0x09648240  token: 0x60006A0
        public System.Void ResetBodies() { }
        // RVA: 0x09648190  token: 0x60006A1
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x07B4A6A8  token: 0x60006A2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB  // size: 0x98
    public class LookAtController : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.LookAtIK ik;  // 0x18
        public UnityEngine.Transform target;  // 0x20
        public System.Single weight;  // 0x28
        public UnityEngine.Vector3 offset;  // 0x2c
        public System.Single targetSwitchSmoothTime;  // 0x38
        public System.Single weightSmoothTime;  // 0x3c
        public System.Boolean smoothTurnTowardsTarget;  // 0x40
        public System.Single maxRadiansDelta;  // 0x44
        public System.Single maxMagnitudeDelta;  // 0x48
        public System.Single slerpSpeed;  // 0x4c
        public UnityEngine.Vector3 pivotOffsetFromRoot;  // 0x50
        public System.Single minDistance;  // 0x5c
        public System.Single maxRootAngle;  // 0x60
        private UnityEngine.Transform lastTarget;  // 0x68
        private System.Single switchWeight;  // 0x70
        private System.Single switchWeightV;  // 0x74
        private System.Single weightV;  // 0x78
        private UnityEngine.Vector3 lastPosition;  // 0x7c
        private UnityEngine.Vector3 dir;  // 0x88
        private System.Boolean lastSmoothTowardsTarget;  // 0x94

        // Properties
        UnityEngine.Vector3 pivot { get; /* RVA: 0x0964EECC */ }

        // Methods
        // RVA: 0x0964EDA0  token: 0x60006A7
        private System.Void Start() { }
        // RVA: 0x0964E45C  token: 0x60006A8
        private System.Void LateUpdate() { }
        // RVA: 0x0964E324  token: 0x60006AA
        private System.Void ApplyMinDistance() { }
        // RVA: 0x0964EB3C  token: 0x60006AB
        private System.Void RootRotation() { }
        // RVA: 0x0964EE68  token: 0x60006AC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CC  // size: 0x30
    public abstract class OffsetModifier : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single weight;  // 0x18
        public RootMotion.FinalIK.FullBodyBipedIK ik;  // 0x20
        protected System.Single lastTime;  // 0x28

        // Properties
        System.Single deltaTime { get; /* RVA: 0x09655408 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60006AE
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x0965572C  token: 0x60006AF
        protected virtual System.Void Start() { }
        // RVA: 0x096554E4  token: 0x60006B0
        private System.Collections.IEnumerator Initiate() { }
        // RVA: 0x09655540  token: 0x60006B1
        private System.Void ModifyOffset() { }
        // RVA: 0x09655424  token: 0x60006B2
        protected System.Void ApplyLimits(RootMotion.FinalIK.OffsetModifier.OffsetLimits[] limits) { }
        // RVA: 0x09655604  token: 0x60006B3
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x07B4A6A8  token: 0x60006B4
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF  // size: 0x30
    public abstract class OffsetModifierVRIK : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single weight;  // 0x18
        public RootMotion.FinalIK.VRIK ik;  // 0x20
        private System.Single lastTime;  // 0x28

        // Properties
        System.Single deltaTime { get; /* RVA: 0x09655408 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60006C0
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x096553E4  token: 0x60006C1
        protected virtual System.Void Start() { }
        // RVA: 0x0965519C  token: 0x60006C2
        private System.Collections.IEnumerator Initiate() { }
        // RVA: 0x096551F8  token: 0x60006C3
        private System.Void ModifyOffset() { }
        // RVA: 0x096552BC  token: 0x60006C4
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x07B4A6A8  token: 0x60006C5
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1  // size: 0x20
    public class OffsetPose : UnityEngine.MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.OffsetPose.EffectorLink[] effectorLinks;  // 0x18

        // Methods
        // RVA: 0x09655750  token: 0x60006CC
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        // RVA: 0x096557FC  token: 0x60006CD
        public System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, UnityEngine.Quaternion rotation) { }
        // RVA: 0x0965588C  token: 0x60006CE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3  // size: 0x38
    public class PenetrationAvoidance : RootMotion.FinalIK.OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.PenetrationAvoidance.Avoider[] avoiders;  // 0x30

        // Methods
        // RVA: 0x096558DC  token: 0x60006D1
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x07B4A6A8  token: 0x60006D2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6  // size: 0xF8
    public class Recoil : RootMotion.FinalIK.OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.AimIK aimIK;  // 0x30
        public RootMotion.FinalIK.AimIK headIK;  // 0x38
        public System.Boolean aimIKSolvedLast;  // 0x40
        public RootMotion.FinalIK.Recoil.Handedness handedness;  // 0x44
        public System.Boolean twoHanded;  // 0x48
        public UnityEngine.AnimationCurve recoilWeight;  // 0x50
        public System.Single magnitudeRandom;  // 0x58
        public UnityEngine.Vector3 rotationRandom;  // 0x5c
        public UnityEngine.Vector3 handRotationOffset;  // 0x68
        public System.Single blendTime;  // 0x74
        public RootMotion.FinalIK.Recoil.RecoilOffset[] offsets;  // 0x78
        public UnityEngine.Quaternion rotationOffset;  // 0x80
        private System.Single magnitudeMlp;  // 0x90
        private System.Single endTime;  // 0x94
        private UnityEngine.Quaternion handRotation;  // 0x98
        private UnityEngine.Quaternion secondaryHandRelativeRotation;  // 0xa8
        private UnityEngine.Quaternion randomRotation;  // 0xb8
        private System.Single length;  // 0xc8
        private System.Boolean initiated;  // 0xcc
        private System.Single blendWeight;  // 0xd0
        private System.Single w;  // 0xd4
        private UnityEngine.Quaternion primaryHandRotation;  // 0xd8
        private System.Boolean handRotationsSet;  // 0xe8
        private UnityEngine.Vector3 aimIKAxis;  // 0xec

        // Properties
        System.Boolean isFinished { get; /* RVA: 0x09656D00 */ }
        RootMotion.FinalIK.IKEffector primaryHandEffector { get; /* RVA: 0x09656D20 */ }
        RootMotion.FinalIK.IKEffector secondaryHandEffector { get; /* RVA: 0x09656D88 */ }
        UnityEngine.Transform primaryHand { get; /* RVA: 0x09656D68 */ }
        UnityEngine.Transform secondaryHand { get; /* RVA: 0x09656DD0 */ }

        // Methods
        // RVA: 0x09656C74  token: 0x60006D9
        public System.Void SetHandRotations(UnityEngine.Quaternion leftHandRotation, UnityEngine.Quaternion rightHandRotation) { }
        // RVA: 0x09655DC8  token: 0x60006DA
        public System.Void Fire(System.Single magnitude) { }
        // RVA: 0x09656128  token: 0x60006DB
        protected virtual System.Void OnModifyOffset() { }
        // RVA: 0x09655C80  token: 0x60006DC
        private System.Void AfterFBBIK() { }
        // RVA: 0x09655BD0  token: 0x60006DD
        private System.Void AfterAimIK() { }
        // RVA: 0x09655F14  token: 0x60006E2
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09656C94  token: 0x60006E3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA  // size: 0x30
    public class ShoulderRotator : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single weight;  // 0x18
        public System.Single offset;  // 0x1c
        private RootMotion.FinalIK.FullBodyBipedIK ik;  // 0x20
        private System.Boolean skip;  // 0x28

        // Methods
        // RVA: 0x09657548  token: 0x60006E8
        private System.Void Start() { }
        // RVA: 0x09657470  token: 0x60006E9
        private System.Void RotateShoulders() { }
        // RVA: 0x0965701C  token: 0x60006EA
        private System.Void RotateShoulder(RootMotion.FinalIK.FullBodyBipedChain chain, System.Single weight, System.Single offset) { }
        // RVA: 0x09656EB8  token: 0x60006EB
        private RootMotion.FinalIK.IKMapping.BoneMap GetParentBoneMap(RootMotion.FinalIK.FullBodyBipedChain chain) { }
        // RVA: 0x09656EF4  token: 0x60006EC
        private System.Void OnDestroy() { }
        // RVA: 0x09657664  token: 0x60006ED
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000DB  // size: 0x10
    public static class VRIKCalibrator
    {
        // Methods
        // RVA: 0x0965C148  token: 0x60006EE
        public static System.Void RecalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, RootMotion.FinalIK.VRIKCalibrator.Settings settings) { }
        // RVA: 0x0965C0E8  token: 0x60006EF
        public static System.Void RecalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, System.Single scaleMlp) { }
        // RVA: 0x09659418  token: 0x60006F0
        private static System.Void CalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.Settings settings) { }
        // RVA: 0x09659438  token: 0x60006F1
        private static System.Void CalibrateScale(RootMotion.FinalIK.VRIK ik, System.Single scaleMlp) { }
        // RVA: 0x0965A13C  token: 0x60006F2
        public static RootMotion.FinalIK.VRIKCalibrator.CalibrationData Calibrate(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.Settings settings, UnityEngine.Transform headTracker, UnityEngine.Transform bodyTracker, UnityEngine.Transform leftHandTracker, UnityEngine.Transform rightHandTracker, UnityEngine.Transform leftFootTracker, UnityEngine.Transform rightFootTracker) { }
        // RVA: 0x09658CD8  token: 0x60006F3
        private static System.Void CalibrateLeg(RootMotion.FinalIK.VRIKCalibrator.Settings settings, UnityEngine.Transform tracker, RootMotion.FinalIK.IKSolverVR.Leg leg, UnityEngine.Transform lastBone, UnityEngine.Vector3 rootForward, System.Boolean isLeft) { }
        // RVA: 0x096595C4  token: 0x60006F4
        public static System.Void Calibrate(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, UnityEngine.Transform headTracker, UnityEngine.Transform bodyTracker, UnityEngine.Transform leftHandTracker, UnityEngine.Transform rightHandTracker, UnityEngine.Transform leftFootTracker, UnityEngine.Transform rightFootTracker) { }
        // RVA: 0x09658A88  token: 0x60006F5
        private static System.Void CalibrateLeg(RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, UnityEngine.Transform tracker, RootMotion.FinalIK.IKSolverVR.Leg leg, UnityEngine.Transform lastBone, UnityEngine.Vector3 rootForward, System.Boolean isLeft) { }
        // RVA: 0x0965B92C  token: 0x60006F6
        public static RootMotion.FinalIK.VRIKCalibrator.CalibrationData Calibrate(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform centerEyeAnchor, UnityEngine.Transform leftHandAnchor, UnityEngine.Transform rightHandAnchor, UnityEngine.Vector3 centerEyePositionOffset, UnityEngine.Vector3 centerEyeRotationOffset, UnityEngine.Vector3 handPositionOffset, UnityEngine.Vector3 handRotationOffset, System.Single scaleMlp) { }
        // RVA: 0x096584F8  token: 0x60006F7
        public static System.Void CalibrateHead(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform centerEyeAnchor, UnityEngine.Vector3 anchorPositionOffset, UnityEngine.Vector3 anchorRotationOffset) { }
        // RVA: 0x09657AF0  token: 0x60006F8
        public static System.Void CalibrateBody(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform pelvisTracker, UnityEngine.Vector3 trackerPositionOffset, UnityEngine.Vector3 trackerRotationOffset) { }
        // RVA: 0x096582A8  token: 0x60006F9
        public static System.Void CalibrateHands(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform leftHandAnchor, UnityEngine.Transform rightHandAnchor, UnityEngine.Vector3 anchorPositionOffset, UnityEngine.Vector3 anchorRotationOffset) { }
        // RVA: 0x09657DEC  token: 0x60006FA
        private static System.Void CalibrateHand(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform anchor, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 rotationOffset, System.Boolean isLeft) { }
        // RVA: 0x0965BF6C  token: 0x60006FB
        public static UnityEngine.Vector3 GuessWristToPalmAxis(UnityEngine.Transform hand, UnityEngine.Transform forearm) { }
        // RVA: 0x0965BB78  token: 0x60006FC
        public static UnityEngine.Vector3 GuessPalmToThumbAxis(UnityEngine.Transform hand, UnityEngine.Transform forearm) { }

    }

    // TypeToken: 0x20000DF  // size: 0x30
    public class VRIKLODController : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Renderer LODRenderer;  // 0x18
        public System.Single LODDistance;  // 0x20
        public System.Boolean allowCulled;  // 0x24
        private RootMotion.FinalIK.VRIK ik;  // 0x28

        // Methods
        // RVA: 0x0965C2C8  token: 0x6000701
        private System.Void Start() { }
        // RVA: 0x0965C310  token: 0x6000702
        private System.Void Update() { }
        // RVA: 0x0965C16C  token: 0x6000703
        private System.Int32 GetLODLevel() { }
        // RVA: 0x0965C344  token: 0x6000704
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0  // size: 0x48
    public class VRIKRootController : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 <pelvisTargetRight>k__BackingField;  // 0x18
        private UnityEngine.Transform pelvisTarget;  // 0x28
        private UnityEngine.Transform leftFootTarget;  // 0x30
        private UnityEngine.Transform rightFootTarget;  // 0x38
        private RootMotion.FinalIK.VRIK ik;  // 0x40

        // Properties
        UnityEngine.Vector3 pelvisTargetRight { get; /* RVA: 0x03D52510 */ set; /* RVA: 0x03D52530 */ }

        // Methods
        // RVA: 0x0965C358  token: 0x6000707
        private System.Void Awake() { }
        // RVA: 0x0965C484  token: 0x6000708
        public System.Void Calibrate() { }
        // RVA: 0x0965C6A8  token: 0x6000709
        public System.Void Calibrate(RootMotion.FinalIK.VRIKCalibrator.CalibrationData data) { }
        // RVA: 0x0965C958  token: 0x600070A
        private System.Void OnPreUpdate() { }
        // RVA: 0x0965C830  token: 0x600070B
        private System.Void OnDestroy() { }
        // RVA: 0x0426FE60  token: 0x600070C
        public System.Void .ctor() { }

    }

}

