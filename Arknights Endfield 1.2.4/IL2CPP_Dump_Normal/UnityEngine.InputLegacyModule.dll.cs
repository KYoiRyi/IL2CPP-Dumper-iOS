// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.InputLegacyModule.dll
// Classes:  14
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000E  // size: 0x20
    public sealed struct HitInfo
    {
        // Fields
        public UnityEngine.GameObject target;  // 0x10
        public UnityEngine.Camera camera;  // 0x18

        // Methods
        // RVA: 0x0369E510  token: 0x6000066
        public System.Void SendMessage(System.String name) { }
        // RVA: 0x0256E940  token: 0x6000067
        public static System.Boolean op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists) { }
        // RVA: 0x0256EA70  token: 0x6000068
        public static System.Boolean Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002  // size: 0x14
    public sealed struct TouchPhase
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TouchPhase Began;  // const
        public static UnityEngine.TouchPhase Moved;  // const
        public static UnityEngine.TouchPhase Stationary;  // const
        public static UnityEngine.TouchPhase Ended;  // const
        public static UnityEngine.TouchPhase Canceled;  // const

    }

    // TypeToken: 0x2000003  // size: 0x14
    public sealed struct IMECompositionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.IMECompositionMode Auto;  // const
        public static UnityEngine.IMECompositionMode On;  // const
        public static UnityEngine.IMECompositionMode Off;  // const

    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct TouchType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TouchType Direct;  // const
        public static UnityEngine.TouchType Indirect;  // const
        public static UnityEngine.TouchType Stylus;  // const

    }

    // TypeToken: 0x2000005  // size: 0x54
    public sealed struct Touch
    {
        // Fields
        private System.Int32 m_FingerId;  // 0x10
        private UnityEngine.Vector2 m_Position;  // 0x14
        private UnityEngine.Vector2 m_RawPosition;  // 0x1c
        private UnityEngine.Vector2 m_PositionDelta;  // 0x24
        private System.Single m_TimeDelta;  // 0x2c
        private System.Int32 m_TapCount;  // 0x30
        private UnityEngine.TouchPhase m_Phase;  // 0x34
        private UnityEngine.TouchType m_Type;  // 0x38
        private System.Single m_Pressure;  // 0x3c
        private System.Single m_maximumPossiblePressure;  // 0x40
        private System.Single m_Radius;  // 0x44
        private System.Single m_RadiusVariance;  // 0x48
        private System.Single m_AltitudeAngle;  // 0x4c
        private System.Single m_AzimuthAngle;  // 0x50

        // Properties
        System.Int32 fingerId { get; /* RVA: 0x03D85860 */ }
        UnityEngine.Vector2 position { get; /* RVA: 0x03D87EC0 */ set; /* RVA: 0x03D55C00 */ }
        UnityEngine.Vector2 rawPosition { get; /* RVA: 0x03D87EF0 */ set; /* RVA: 0x03D87F20 */ }
        UnityEngine.Vector2 deltaPosition { get; /* RVA: 0x03D61D10 */ set; /* RVA: 0x03D87F10 */ }
        System.Single deltaTime { get; /* RVA: 0x03D87EB0 */ }
        System.Int32 tapCount { get; /* RVA: 0x03D86CC0 */ }
        UnityEngine.TouchPhase phase { get; /* RVA: 0x03D85AA0 */ }
        System.Single pressure { get; /* RVA: 0x03D87EE0 */ }
        System.Single maximumPossiblePressure { get; /* RVA: 0x03D84BA0 */ }
        UnityEngine.TouchType type { get; /* RVA: 0x03D86D30 */ }
        System.Single altitudeAngle { get; /* RVA: 0x04270790 */ }
        System.Single azimuthAngle { get; /* RVA: 0x04270740 */ }
        System.Single radius { get; /* RVA: 0x042743D0 */ }
        System.Single radiusVariance { get; /* RVA: 0x04270730 */ }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct DeviceOrientation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.DeviceOrientation Unknown;  // const
        public static UnityEngine.DeviceOrientation Portrait;  // const
        public static UnityEngine.DeviceOrientation PortraitUpsideDown;  // const
        public static UnityEngine.DeviceOrientation LandscapeLeft;  // const
        public static UnityEngine.DeviceOrientation LandscapeRight;  // const
        public static UnityEngine.DeviceOrientation FaceUp;  // const
        public static UnityEngine.DeviceOrientation FaceDown;  // const

    }

    // TypeToken: 0x2000007  // size: 0x20
    public sealed struct AccelerationEvent
    {
        // Fields
        private System.Single x;  // 0x10
        private System.Single y;  // 0x14
        private System.Single z;  // 0x18
        private System.Single m_TimeDelta;  // 0x1c

    }

    // TypeToken: 0x2000008  // size: 0x18
    public class Gyroscope
    {
        // Fields
        private System.Int32 m_GyroIndex;  // 0x10

        // Methods
        // RVA: 0x010410F0  token: 0x6000012
        private System.Void .ctor(System.Int32 index) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public class LocationService
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000013
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x10
    public class Compass
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000014
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x10
    public class CameraRaycastHelper
    {
        // Methods
        // RVA: 0x09E1421C  token: 0x6000015
        private static UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        // RVA: 0x09E14204  token: 0x6000016
        private static UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        // RVA: 0x0306AA60  token: 0x6000017
        private static UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, UnityEngine.Ray& ray, System.Single distance, System.Int32 layerMask) { }
        // RVA: 0x0306AAD0  token: 0x6000018
        private static UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, UnityEngine.Ray& ray, System.Single distance, System.Int32 layerMask) { }

    }

    // TypeToken: 0x200000C  // size: 0x10
    public class Input
    {
        // Fields
        private static UnityEngine.LocationService locationServiceInstance;  // static @ 0x0
        private static UnityEngine.Compass compassInstance;  // static @ 0x8
        private static UnityEngine.Gyroscope s_MainGyro;  // static @ 0x10

        // Properties
        System.Boolean simulateMouseWithTouches { get; /* RVA: 0x09E14A58 */ set; /* RVA: 0x03B728A0 */ }
        System.Boolean anyKey { get; /* RVA: 0x09E1466C */ }
        System.Boolean anyKeyDown { get; /* RVA: 0x03324750 */ }
        System.String inputString { get; /* RVA: 0x09E14940 */ }
        UnityEngine.Vector3 mousePosition { get; /* RVA: 0x024B1690 */ }
        UnityEngine.Vector2 mouseScrollDelta { get; /* RVA: 0x024B3290 */ }
        UnityEngine.IMECompositionMode imeCompositionMode { get; /* RVA: 0x09E148E8 */ set; /* RVA: 0x03D46FD0 */ }
        System.String compositionString { get; /* RVA: 0x036E6FF0 */ }
        System.Boolean imeIsSelected { get; /* RVA: 0x09E14914 */ }
        UnityEngine.Vector2 compositionCursorPos { get; /* RVA: 0x09E147C0 */ set; /* RVA: 0x09E14B70 */ }
        System.Boolean eatKeyPressOnTextFieldFocus { get; /* RVA: 0x09E14810 */ set; /* RVA: 0x09E14B8C */ }
        System.Boolean mousePresent { get; /* RVA: 0x024B3320 */ }
        System.Int32 touchCount { get; /* RVA: 0x02912010 */ }
        System.Boolean touchPressureSupported { get; /* RVA: 0x09E14AB0 */ }
        System.Boolean stylusTouchSupported { get; /* RVA: 0x09E14A84 */ }
        System.Boolean touchSupported { get; /* RVA: 0x09E14ADC */ }
        System.Boolean multiTouchEnabled { get; /* RVA: 0x09E14A2C */ set; /* RVA: 0x03B72950 */ }
        System.Boolean isGyroAvailable { get; /* RVA: 0x09E1496C */ }
        UnityEngine.DeviceOrientation deviceOrientation { get; /* RVA: 0x09E147E4 */ }
        UnityEngine.Vector3 acceleration { get; /* RVA: 0x09E14648 */ }
        System.Boolean compensateSensors { get; /* RVA: 0x09E14760 */ set; /* RVA: 0x09E14B3C */ }
        System.Int32 accelerationEventCount { get; /* RVA: 0x09E1454C */ }
        System.Boolean backButtonLeavesApp { get; /* RVA: 0x09E14698 */ set; /* RVA: 0x09E14B08 */ }
        UnityEngine.LocationService location { get; /* RVA: 0x09E14998 */ }
        UnityEngine.Compass compass { get; /* RVA: 0x09E146C4 */ }
        UnityEngine.Gyroscope gyro { get; /* RVA: 0x09E1483C */ }
        UnityEngine.Touch[] touches { get; /* RVA: 0x02911F40 */ }
        UnityEngine.AccelerationEvent[] accelerationEvents { get; /* RVA: 0x09E14578 */ }

        // Methods
        // RVA: 0x02F4C640  token: 0x6000019
        private static System.Boolean GetKeyInt(UnityEngine.KeyCode key) { }
        // RVA: 0x09E143D0  token: 0x600001A
        private static System.Boolean GetKeyString(System.String name) { }
        // RVA: 0x02F8B780  token: 0x600001B
        private static System.Boolean GetKeyUpInt(UnityEngine.KeyCode key) { }
        // RVA: 0x09E14404  token: 0x600001C
        private static System.Boolean GetKeyUpString(System.String name) { }
        // RVA: 0x02ED3470  token: 0x600001D
        private static System.Boolean GetKeyDownInt(UnityEngine.KeyCode key) { }
        // RVA: 0x09E14390  token: 0x600001E
        private static System.Boolean GetKeyDownString(System.String name) { }
        // RVA: 0x09E1429C  token: 0x600001F
        public static System.Single GetAxis(System.String axisName) { }
        // RVA: 0x024B3250  token: 0x6000020
        public static System.Single GetAxisRaw(System.String axisName) { }
        // RVA: 0x024B3130  token: 0x6000021
        public static System.Boolean GetButton(System.String buttonName) { }
        // RVA: 0x09E142D0  token: 0x6000022
        public static System.Boolean GetButtonDown(System.String buttonName) { }
        // RVA: 0x09E14304  token: 0x6000023
        public static System.Boolean GetButtonUp(System.String buttonName) { }
        // RVA: 0x024AF7D0  token: 0x6000024
        public static System.Boolean GetMouseButton(System.Int32 button) { }
        // RVA: 0x024B1760  token: 0x6000025
        public static System.Boolean GetMouseButtonDown(System.Int32 button) { }
        // RVA: 0x028501D0  token: 0x6000026
        public static System.Boolean GetMouseButtonUp(System.Int32 button) { }
        // RVA: 0x09E144C8  token: 0x6000027
        public static System.Void ResetInputAxes() { }
        // RVA: 0x09E14364  token: 0x6000028
        public static System.String[] GetJoystickNames() { }
        // RVA: 0x09E14490  token: 0x6000029
        public static UnityEngine.Touch GetTouch(System.Int32 index) { }
        // RVA: 0x09E14274  token: 0x600002A
        public static UnityEngine.AccelerationEvent GetAccelerationEvent(System.Int32 index) { }
        // RVA: 0x04271CA0  token: 0x600002B
        public static System.Boolean GetKey(UnityEngine.KeyCode key) { }
        // RVA: 0x09E14444  token: 0x600002C
        public static System.Boolean GetKey(System.String name) { }
        // RVA: 0x04271CB8  token: 0x600002D
        public static System.Boolean GetKeyUp(UnityEngine.KeyCode key) { }
        // RVA: 0x09E14438  token: 0x600002E
        public static System.Boolean GetKeyUp(System.String name) { }
        // RVA: 0x04271CAC  token: 0x600002F
        public static System.Boolean GetKeyDown(UnityEngine.KeyCode key) { }
        // RVA: 0x09E143C4  token: 0x6000030
        public static System.Boolean GetKeyDown(System.String name) { }
        // RVA: 0x0350B670  token: 0x6000031
        private static System.Void SimulateTouch(UnityEngine.Touch touch) { }
        // RVA: 0x09E14538  token: 0x6000032
        private static System.Void SimulateTouchInternal(UnityEngine.Touch touch, System.Int64 timestamp) { }
        // RVA: 0x09E14338  token: 0x6000053
        private static System.Int32 GetGyroInternal() { }
        // RVA: 0x024B1720  token: 0x6000057
        private static System.Boolean CheckDisabled() { }
        // RVA: 0x0350B670  token: 0x6000058
        public System.Void .ctor() { }
        // RVA: 0x09E14450  token: 0x6000059
        private static System.Void GetTouch_Injected(System.Int32 index, UnityEngine.Touch& ret) { }
        // RVA: 0x09E14234  token: 0x600005A
        private static System.Void GetAccelerationEvent_Injected(System.Int32 index, UnityEngine.AccelerationEvent& ret) { }
        // RVA: 0x09E144F4  token: 0x600005B
        private static System.Void SimulateTouchInternal_Injected(UnityEngine.Touch& touch, System.Int64 timestamp) { }
        // RVA: 0x024B16E0  token: 0x600005C
        private static System.Void get_mousePosition_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x024B32E0  token: 0x600005D
        private static System.Void get_mouseScrollDelta_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09E1478C  token: 0x600005E
        private static System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x03D1BBC0  token: 0x600005F
        private static System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E14614  token: 0x6000060
        private static System.Void get_acceleration_Injected(UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x200000D  // size: 0x10
    public class SendMouseEvents
    {
        // Fields
        private static System.Boolean s_MouseUsed;  // static @ 0x0
        private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_LastHit;  // static @ 0x8
        private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_MouseDownHit;  // static @ 0x10
        private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_CurrentHit;  // static @ 0x18
        private static UnityEngine.Camera[] m_Cameras;  // static @ 0x20
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,UnityEngine.Vector2>> s_GetMouseState;  // static @ 0x28
        private static UnityEngine.Vector2 s_MousePosition;  // static @ 0x30
        private static System.Boolean s_MouseButtonPressedThisFrame;  // static @ 0x38
        private static System.Boolean s_MouseButtonIsPressed;  // static @ 0x39

        // Methods
        // RVA: 0x024B1500  token: 0x6000061
        private static System.Void UpdateMouse() { }
        // RVA: 0x09E14BC0  token: 0x6000062
        private static System.Void SetMouseMoved() { }
        // RVA: 0x0256CF10  token: 0x6000063
        private static System.Void DoSendMouseEvents(System.Int32 skipRTCameras) { }
        // RVA: 0x0256DFA0  token: 0x6000064
        private static System.Void SendEvents(System.Int32 i, UnityEngine.SendMouseEvents.HitInfo hit) { }
        // RVA: 0x03C84CE0  token: 0x6000065
        private static System.Void .cctor() { }

    }

}

