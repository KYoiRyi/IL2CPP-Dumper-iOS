// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.XRModule.dll
// Classes:  32
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct TrackingStateEventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.XR.InputTracking.TrackingStateEventType NodeAdded;  // const
        public static UnityEngine.XR.InputTracking.TrackingStateEventType NodeRemoved;  // const
        public static UnityEngine.XR.InputTracking.TrackingStateEventType TrackingAcquired;  // const
        public static UnityEngine.XR.InputTracking.TrackingStateEventType TrackingLost;  // const

    }

    // TypeToken: 0x2000014  // size: 0xE8
    public sealed struct XRRenderPass
    {
        // Fields
        private System.IntPtr displaySubsystemInstance;  // 0x10
        public System.Int32 renderPassIndex;  // 0x18
        public UnityEngine.Rendering.RenderTargetIdentifier renderTarget;  // 0x20
        public UnityEngine.RenderTextureDescriptor renderTargetDesc;  // 0x48
        public System.Boolean hasMotionVectorPass;  // 0x7c
        public UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget;  // 0x80
        public UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc;  // 0xa8
        public System.Boolean shouldFillOutDepth;  // 0xdc
        public System.Int32 cullingPassIndex;  // 0xe0

    }

    // TypeToken: 0x2000015  // size: 0x20
    public sealed struct XRMirrorViewBlitDesc
    {
        // Fields
        private System.IntPtr displaySubsystemInstance;  // 0x10
        public System.Boolean nativeBlitAvailable;  // 0x18
        public System.Boolean nativeBlitInvalidStates;  // 0x19
        public System.Int32 blitParamsCount;  // 0x1c

    }

    // TypeToken: 0x200001F  // size: 0x18
    public sealed struct MeshTransformList : System.IDisposable
    {
        // Fields
        private readonly System.IntPtr m_Self;  // 0x10

        // Methods
        // RVA: 0x09F8CB64  token: 0x6000041
        public virtual System.Void Dispose() { }
        // RVA: 0x09F8CB70  token: 0x6000042
        private static System.Void Dispose(System.IntPtr self) { }

    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002  // size: 0x10
    public sealed class EmbeddedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class IsReadOnlyAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.XR
{

    // TypeToken: 0x2000004  // size: 0x10
    public static class InputTracking
    {
        // Fields
        private static System.Action<UnityEngine.XR.XRNodeState> trackingAcquired;  // static @ 0x0
        private static System.Action<UnityEngine.XR.XRNodeState> trackingLost;  // static @ 0x8
        private static System.Action<UnityEngine.XR.XRNodeState> nodeAdded;  // static @ 0x10
        private static System.Action<UnityEngine.XR.XRNodeState> nodeRemoved;  // static @ 0x18

        // Methods
        // RVA: 0x09F8C4EC  token: 0x6000003
        private static System.Void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, System.Int64 uniqueID, System.Boolean tracked) { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct XRNode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.XR.XRNode LeftEye;  // const
        public static UnityEngine.XR.XRNode RightEye;  // const
        public static UnityEngine.XR.XRNode CenterEye;  // const
        public static UnityEngine.XR.XRNode Head;  // const
        public static UnityEngine.XR.XRNode LeftHand;  // const
        public static UnityEngine.XR.XRNode RightHand;  // const
        public static UnityEngine.XR.XRNode GameController;  // const
        public static UnityEngine.XR.XRNode TrackingReference;  // const
        public static UnityEngine.XR.XRNode HardwareTracker;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct AvailableTrackingData
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.XR.AvailableTrackingData None;  // const
        public static UnityEngine.XR.AvailableTrackingData PositionAvailable;  // const
        public static UnityEngine.XR.AvailableTrackingData RotationAvailable;  // const
        public static UnityEngine.XR.AvailableTrackingData VelocityAvailable;  // const
        public static UnityEngine.XR.AvailableTrackingData AngularVelocityAvailable;  // const
        public static UnityEngine.XR.AvailableTrackingData AccelerationAvailable;  // const
        public static UnityEngine.XR.AvailableTrackingData AngularAccelerationAvailable;  // const

    }

    // TypeToken: 0x2000008  // size: 0x70
    public sealed struct XRNodeState
    {
        // Fields
        private UnityEngine.XR.XRNode m_Type;  // 0x10
        private UnityEngine.XR.AvailableTrackingData m_AvailableFields;  // 0x14
        private UnityEngine.Vector3 m_Position;  // 0x18
        private UnityEngine.Quaternion m_Rotation;  // 0x24
        private UnityEngine.Vector3 m_Velocity;  // 0x34
        private UnityEngine.Vector3 m_AngularVelocity;  // 0x40
        private UnityEngine.Vector3 m_Acceleration;  // 0x4c
        private UnityEngine.Vector3 m_AngularAcceleration;  // 0x58
        private System.Int32 m_Tracked;  // 0x64
        private System.UInt64 m_UniqueID;  // 0x68

        // Properties
        System.UInt64 uniqueID { set; /* RVA: 0x03D4F270 */ }
        UnityEngine.XR.XRNode nodeType { set; /* RVA: 0x03D4E970 */ }
        System.Boolean tracked { set; /* RVA: 0x09F8CE00 */ }

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct InputFeatureType
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static UnityEngine.XR.InputFeatureType Custom;  // const
        public static UnityEngine.XR.InputFeatureType Binary;  // const
        public static UnityEngine.XR.InputFeatureType DiscreteStates;  // const
        public static UnityEngine.XR.InputFeatureType Axis1D;  // const
        public static UnityEngine.XR.InputFeatureType Axis2D;  // const
        public static UnityEngine.XR.InputFeatureType Axis3D;  // const
        public static UnityEngine.XR.InputFeatureType Rotation;  // const
        public static UnityEngine.XR.InputFeatureType Hand;  // const
        public static UnityEngine.XR.InputFeatureType Bone;  // const
        public static UnityEngine.XR.InputFeatureType Eyes;  // const
        public static UnityEngine.XR.InputFeatureType kUnityXRInputFeatureTypeInvalid;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct ConnectionChangeType
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static UnityEngine.XR.ConnectionChangeType Connected;  // const
        public static UnityEngine.XR.ConnectionChangeType Disconnected;  // const
        public static UnityEngine.XR.ConnectionChangeType ConfigChange;  // const

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct InputDeviceCharacteristics
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static UnityEngine.XR.InputDeviceCharacteristics None;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics HeadMounted;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics Camera;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics HeldInHand;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics HandTracking;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics EyeTracking;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics TrackedDevice;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics Controller;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics TrackingReference;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics Left;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics Right;  // const
        public static UnityEngine.XR.InputDeviceCharacteristics Simulated6DOF;  // const

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct InputTrackingState
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static UnityEngine.XR.InputTrackingState None;  // const
        public static UnityEngine.XR.InputTrackingState Position;  // const
        public static UnityEngine.XR.InputTrackingState Rotation;  // const
        public static UnityEngine.XR.InputTrackingState Velocity;  // const
        public static UnityEngine.XR.InputTrackingState AngularVelocity;  // const
        public static UnityEngine.XR.InputTrackingState Acceleration;  // const
        public static UnityEngine.XR.InputTrackingState AngularAcceleration;  // const
        public static UnityEngine.XR.InputTrackingState All;  // const

    }

    // TypeToken: 0x200000D  // size: 0x20
    public sealed struct InputFeatureUsage : System.IEquatable`1
    {
        // Fields
        private System.String m_Name;  // 0x10
        private UnityEngine.XR.InputFeatureType m_InternalType;  // 0x18

        // Properties
        System.String name { get; /* RVA: 0x0253BE20 */ }
        UnityEngine.XR.InputFeatureType internalType { get; /* RVA: 0x03D68070 */ }

        // Methods
        // RVA: 0x09F8C404  token: 0x6000009
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F8C47C  token: 0x600000A
        public virtual System.Boolean Equals(UnityEngine.XR.InputFeatureUsage other) { }
        // RVA: 0x09F8C4BC  token: 0x600000B
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000E  // size: 0x20
    public sealed struct InputDevice : System.IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;  // 0x10
        private System.Boolean m_Initialized;  // 0x18

        // Properties
        System.UInt64 deviceId { get; /* RVA: 0x09F8C330 */ }

        // Methods
        // RVA: 0x03D89F90  token: 0x600000C
        private System.Void .ctor(System.UInt64 deviceId) { }
        // RVA: 0x09F8C258  token: 0x600000E
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F8C2E0  token: 0x600000F
        public virtual System.Boolean Equals(UnityEngine.XR.InputDevice other) { }
        // RVA: 0x09F8C314  token: 0x6000010
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000F  // size: 0x20
    public sealed struct Hand : System.IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;  // 0x10
        private System.UInt32 m_FeatureIndex;  // 0x18

        // Properties
        System.UInt64 deviceId { get; /* RVA: 0x0253BE20 */ }
        System.UInt32 featureIndex { get; /* RVA: 0x03D68070 */ }

        // Methods
        // RVA: 0x09F8C118  token: 0x6000013
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F8C010  token: 0x6000014
        public virtual System.Boolean Equals(UnityEngine.XR.Hand other) { }
        // RVA: 0x03D89F20  token: 0x6000015
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000010  // size: 0x20
    public sealed struct Eyes : System.IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;  // 0x10
        private System.UInt32 m_FeatureIndex;  // 0x18

        // Properties
        System.UInt64 deviceId { get; /* RVA: 0x0253BE20 */ }
        System.UInt32 featureIndex { get; /* RVA: 0x03D68070 */ }

        // Methods
        // RVA: 0x09F8C0A0  token: 0x6000018
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F8C010  token: 0x6000019
        public virtual System.Boolean Equals(UnityEngine.XR.Eyes other) { }
        // RVA: 0x03D89F20  token: 0x600001A
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public sealed struct Bone : System.IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;  // 0x10
        private System.UInt32 m_FeatureIndex;  // 0x18

        // Properties
        System.UInt64 deviceId { get; /* RVA: 0x0253BE20 */ }
        System.UInt32 featureIndex { get; /* RVA: 0x03D68070 */ }

        // Methods
        // RVA: 0x09F8C028  token: 0x600001D
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F8C010  token: 0x600001E
        public virtual System.Boolean Equals(UnityEngine.XR.Bone other) { }
        // RVA: 0x03D89F20  token: 0x600001F
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public class InputDevices
    {
        // Fields
        private static System.Action<UnityEngine.XR.InputDevice> deviceConnected;  // static @ 0x0
        private static System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;  // static @ 0x8
        private static System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;  // static @ 0x10

        // Methods
        // RVA: 0x09F8C344  token: 0x6000020
        private static System.Void InvokeConnectionEvent(System.UInt64 deviceId, UnityEngine.XR.ConnectionChangeType change) { }

    }

    // TypeToken: 0x2000013  // size: 0x28
    public class XRDisplaySubsystem : UnityEngine.IntegratedSubsystem`1
    {
        // Fields
        private System.Action<System.Boolean> displayFocusChanged;  // 0x20

        // Methods
        // RVA: 0x09F8CBCC  token: 0x6000021
        private System.Void InvokeDisplayFocusChanged(System.Boolean focus) { }
        // RVA: 0x09F8CBE8  token: 0x6000022
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x18
    public class XRDisplaySubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor`1
    {
        // Methods
        // RVA: 0x09F8CBA4  token: 0x6000023
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x30
    public class XRInputSubsystem : UnityEngine.IntegratedSubsystem`1
    {
        // Fields
        private System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;  // 0x20
        private System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;  // 0x28

        // Methods
        // RVA: 0x09F8CCB0  token: 0x6000024
        private static System.Void InvokeTrackingOriginUpdatedEvent(System.IntPtr internalPtr) { }
        // RVA: 0x09F8CC38  token: 0x6000025
        private static System.Void InvokeBoundaryChangedEvent(System.IntPtr internalPtr) { }
        // RVA: 0x09F8CD28  token: 0x6000026
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x18
    public class XRInputSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor`1
    {
        // Methods
        // RVA: 0x09F8CC10  token: 0x6000027
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x20
    public sealed struct MeshId : System.IEquatable`1
    {
        // Fields
        private static UnityEngine.XR.MeshId s_InvalidId;  // static @ 0x0
        private System.UInt64 m_SubId1;  // 0x10
        private System.UInt64 m_SubId2;  // 0x18

        // Methods
        // RVA: 0x09F8CAAC  token: 0x6000028
        public virtual System.String ToString() { }
        // RVA: 0x03D85F30  token: 0x6000029
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09F8CA28  token: 0x600002A
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0558249C  token: 0x600002B
        public virtual System.Boolean Equals(UnityEngine.XR.MeshId other) { }
        // RVA: 0x09F8CB28  token: 0x600002C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x14
    public sealed struct MeshGenerationStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.XR.MeshGenerationStatus Success;  // const
        public static UnityEngine.XR.MeshGenerationStatus InvalidMeshId;  // const
        public static UnityEngine.XR.MeshGenerationStatus GenerationAlreadyInProgress;  // const
        public static UnityEngine.XR.MeshGenerationStatus Canceled;  // const
        public static UnityEngine.XR.MeshGenerationStatus UnknownError;  // const

    }

    // TypeToken: 0x200001B  // size: 0x10
    public static class HashCodeHelper
    {
        // Methods
        // RVA: 0x03D89F40  token: 0x600002D
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2) { }
        // RVA: 0x03D89F50  token: 0x600002E
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3) { }
        // RVA: 0x03D89F70  token: 0x600002F
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4) { }
        // RVA: 0x09F8C1F4  token: 0x6000030
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5) { }
        // RVA: 0x09F8C1C8  token: 0x6000031
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6) { }
        // RVA: 0x09F8C190  token: 0x6000032
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6, System.Int32 hash7) { }
        // RVA: 0x09F8C218  token: 0x6000033
        public static System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6, System.Int32 hash7, System.Int32 hash8) { }

    }

    // TypeToken: 0x200001C  // size: 0x68
    public sealed struct MeshGenerationResult : System.IEquatable`1
    {
        // Fields
        private readonly UnityEngine.XR.MeshId <MeshId>k__BackingField;  // 0x10
        private readonly UnityEngine.Mesh <Mesh>k__BackingField;  // 0x20
        private readonly UnityEngine.MeshCollider <MeshCollider>k__BackingField;  // 0x28
        private readonly UnityEngine.XR.MeshGenerationStatus <Status>k__BackingField;  // 0x30
        private readonly UnityEngine.XR.MeshVertexAttributes <Attributes>k__BackingField;  // 0x34
        private readonly System.UInt64 <Timestamp>k__BackingField;  // 0x38
        private readonly UnityEngine.Vector3 <Position>k__BackingField;  // 0x40
        private readonly UnityEngine.Quaternion <Rotation>k__BackingField;  // 0x4c
        private readonly UnityEngine.Vector3 <Scale>k__BackingField;  // 0x5c

        // Properties
        UnityEngine.XR.MeshId MeshId { get; /* RVA: 0x03D5B250 */ }
        UnityEngine.Mesh Mesh { get; /* RVA: 0x020B7B20 */ }
        UnityEngine.MeshCollider MeshCollider { get; /* RVA: 0x01041090 */ }
        UnityEngine.XR.MeshGenerationStatus Status { get; /* RVA: 0x01003B50 */ }
        UnityEngine.XR.MeshVertexAttributes Attributes { get; /* RVA: 0x03D4E2E0 */ }
        UnityEngine.Vector3 Position { get; /* RVA: 0x03D51B80 */ }
        UnityEngine.Quaternion Rotation { get; /* RVA: 0x03D5E660 */ }
        UnityEngine.Vector3 Scale { get; /* RVA: 0x03D58880 */ }

        // Methods
        // RVA: 0x09F8C6AC  token: 0x600003C
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09F8C75C  token: 0x600003D
        public virtual System.Boolean Equals(UnityEngine.XR.MeshGenerationResult other) { }
        // RVA: 0x09F8C8C4  token: 0x600003E
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct MeshVertexAttributes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.XR.MeshVertexAttributes None;  // const
        public static UnityEngine.XR.MeshVertexAttributes Normals;  // const
        public static UnityEngine.XR.MeshVertexAttributes Tangents;  // const
        public static UnityEngine.XR.MeshVertexAttributes UVs;  // const
        public static UnityEngine.XR.MeshVertexAttributes Colors;  // const

    }

    // TypeToken: 0x200001E  // size: 0x20
    public class XRMeshSubsystem : UnityEngine.IntegratedSubsystem`1
    {
        // Methods
        // RVA: 0x09F8CD78  token: 0x600003F
        private System.Void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete) { }
        // RVA: 0x09F8CDD8  token: 0x6000040
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x18
    public class XRMeshSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor`1
    {
        // Methods
        // RVA: 0x09F8CD50  token: 0x6000043
        public System.Void .ctor() { }

    }

}

