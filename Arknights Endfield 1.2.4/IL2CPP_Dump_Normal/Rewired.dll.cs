// ========================================================
// Dumped by @desirepro
// Assembly: Rewired.dll
// Classes:  55
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000011  // size: 0x28
    public sealed class DataStore : IDataStore
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,System.Object> _data;  // 0x10
        private readonly System.String _absFilePath;  // 0x18
        private Rewired.Data.UserDataStore_File.IDataHandler _dataHandler;  // 0x20

        // Methods
        // RVA: 0x093E2F14  token: 0x600023E
        public System.Void .ctor(System.String fileName, System.String absDirectory, Rewired.Data.UserDataStore_File.IDataHandler dataHandler) { }
        // RVA: 0x093E2E94  token: 0x600023F
        public virtual System.Boolean TryGetValue(System.String key, System.Object& value) { }
        // RVA: 0x093E2E1C  token: 0x6000240
        public virtual System.Boolean SetValue(System.String key, System.Object value) { }
        // RVA: 0x093E2CF8  token: 0x6000241
        public virtual System.Boolean Save() { }
        // RVA: 0x093E2B30  token: 0x6000242
        public virtual System.Boolean Load() { }
        // RVA: 0x093E29D4  token: 0x6000243
        public virtual System.Boolean Clear() { }

    }

    // TypeToken: 0x2000012  // size: 0x20
    public sealed class LocalFileDataHandler : IDataHandler
    {
        // Fields
        private readonly System.Func<Rewired.Data.UserDataStore_File.DataFormat> _dataFormatDelegate;  // 0x10
        private readonly Rewired.Data.UserDataStore_File.Codec _codec;  // 0x18

        // Methods
        // RVA: 0x093E66FC  token: 0x6000244
        public System.Void .ctor(System.Func<Rewired.Data.UserDataStore_File.DataFormat> dataFormatDelegate, Rewired.Data.UserDataStore_File.Codec codec) { }
        // RVA: 0x093E6334  token: 0x6000245
        public virtual System.Boolean Load(System.String absoluteFilePath, System.String& data) { }
        // RVA: 0x093E6518  token: 0x6000246
        public virtual System.Boolean Save(System.String absoluteFilePath, System.String data) { }
        // RVA: 0x093E6274  token: 0x6000247
        public virtual System.Boolean Clear(System.String absoluteFilePath) { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public abstract class Codec
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000248
        public virtual System.Byte[] Encode(System.String string) { }
        // RVA: -1  // abstract  token: 0x6000249
        public virtual System.String Decode(System.Byte[] data) { }
        // RVA: 0x0350B670  token: 0x600024A
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x10
    public sealed class UTF8Text : Codec
    {
        // Methods
        // RVA: 0x093EEC98  token: 0x600024B
        public virtual System.Byte[] Encode(System.String string) { }
        // RVA: 0x093EEC68  token: 0x600024C
        public virtual System.String Decode(System.Byte[] data) { }
        // RVA: 0x0350B670  token: 0x600024D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x18
    public sealed class CLZF2 : Codec
    {
        // Fields
        private readonly Rewired.Utils.Libraries.CLZF2.CLZF2 _cLZF2;  // 0x10

        // Methods
        // RVA: 0x093E2470  token: 0x600024E
        public System.Void .ctor() { }
        // RVA: 0x093E2420  token: 0x600024F
        public virtual System.Byte[] Encode(System.String string) { }
        // RVA: 0x093E23C4  token: 0x6000250
        public virtual System.String Decode(System.Byte[] data) { }

    }

    // TypeToken: 0x2000016
    public interface IDataHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000251
        public virtual System.Boolean Load(System.String absoluteFilePath, System.String& data) { }
        // RVA: -1  // abstract  token: 0x6000252
        public virtual System.Boolean Save(System.String absoluteFilePath, System.String data) { }
        // RVA: -1  // abstract  token: 0x6000253
        public virtual System.Boolean Clear(System.String absoluteFilePath) { }

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct DataFormat
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Rewired.Data.UserDataStore_File.DataFormat Text;  // const
        public static Rewired.Data.UserDataStore_File.DataFormat Binary;  // const

    }

    // TypeToken: 0x200001A  // size: 0x20
    public class PlayerInfo
    {
        // Fields
        public System.Int32 id;  // 0x10
        public System.Boolean hasKeyboard;  // 0x14
        public System.Boolean hasMouse;  // 0x15
        public Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;  // 0x18

        // Properties
        System.Int32 joystickCount { get; /* RVA: 0x093E6B70 */ }

        // Methods
        // RVA: 0x093E6AF4  token: 0x60002AE
        public System.Int32 IndexOfJoystick(System.Int32 joystickId) { }
        // RVA: 0x093E6ADC  token: 0x60002AF
        public System.Boolean ContainsJoystick(System.Int32 joystickId) { }
        // RVA: 0x0350B670  token: 0x60002B0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x30
    public class JoystickInfo
    {
        // Fields
        public System.Guid instanceGuid;  // 0x10
        public System.String hardwareIdentifier;  // 0x20
        public System.Int32 id;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60002B1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x18
    public class ControllerAssignmentSaveInfo
    {
        // Fields
        public Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.PlayerInfo[] players;  // 0x10

        // Properties
        System.Int32 playerCount { get; /* RVA: 0x0352ADE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60002A9
        public System.Void .ctor() { }
        // RVA: 0x093E2568  token: 0x60002AA
        public System.Void .ctor(System.Int32 playerCount) { }
        // RVA: 0x093E24EC  token: 0x60002AB
        public System.Int32 IndexOfPlayer(System.Int32 playerId) { }
        // RVA: 0x093E24D4  token: 0x60002AC
        public System.Boolean ContainsPlayer(System.Int32 playerId) { }

    }

    // TypeToken: 0x200001C  // size: 0x20
    public class JoystickAssignmentHistoryInfo
    {
        // Fields
        public readonly Rewired.Joystick joystick;  // 0x10
        public readonly System.Int32 oldJoystickId;  // 0x18

        // Methods
        // RVA: 0x093E61F8  token: 0x60002B2
        public System.Void .ctor(Rewired.Joystick joystick, System.Int32 oldJoystickId) { }

    }

    // TypeToken: 0x200001D
    public interface IDataStore
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60002B3
        public virtual System.Boolean Save() { }
        // RVA: -1  // abstract  token: 0x60002B4
        public virtual System.Boolean Load() { }
        // RVA: -1  // abstract  token: 0x60002B5
        public virtual System.Boolean Clear() { }
        // RVA: -1  // abstract  token: 0x60002B6
        public virtual System.Boolean TryGetValue(System.String key, System.Object& result) { }
        // RVA: -1  // abstract  token: 0x60002B7
        public virtual System.Boolean SetValue(System.String key, System.Object value) { }

    }

    // TypeToken: 0x200001E  // size: 0x18
    public sealed class <>c__DisplayClass71_0
    {
        // Fields
        public Rewired.Joystick joystick;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002B8
        public System.Void .ctor() { }
        // RVA: 0x093A0DBC  token: 0x60002B9
        private System.Boolean <LoadJoystickAssignmentsNow>b__0(Rewired.Data.UserDataStore_KeyValue.JoystickAssignmentHistoryInfo x) { }

    }

    // TypeToken: 0x200001F  // size: 0x18
    public sealed class <>c__DisplayClass71_1
    {
        // Fields
        public Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002BA
        public System.Void .ctor() { }
        // RVA: 0x093EEC40  token: 0x60002BB
        private System.Boolean <LoadJoystickAssignmentsNow>b__1(Rewired.Data.UserDataStore_KeyValue.JoystickAssignmentHistoryInfo x) { }

    }

    // TypeToken: 0x2000020  // size: 0x18
    public sealed class <>c__DisplayClass71_2
    {
        // Fields
        public Rewired.Joystick match;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002BC
        public System.Void .ctor() { }
        // RVA: 0x093A0DBC  token: 0x60002BD
        private System.Boolean <LoadJoystickAssignmentsNow>b__2(Rewired.Data.UserDataStore_KeyValue.JoystickAssignmentHistoryInfo x) { }

    }

    // TypeToken: 0x2000021  // size: 0x28
    public sealed class <LoadJoystickAssignmentsDeferred>d__73 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Rewired.Data.UserDataStore_KeyValue <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002BE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002BF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x093EEA18  token: 0x60002C0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x093EEAE0  token: 0x60002C2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000024  // size: 0x20
    public class PlayerInfo
    {
        // Fields
        public System.Int32 id;  // 0x10
        public System.Boolean hasKeyboard;  // 0x14
        public System.Boolean hasMouse;  // 0x15
        public Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;  // 0x18

        // Properties
        System.Int32 joystickCount { get; /* RVA: 0x093E6B70 */ }

        // Methods
        // RVA: 0x093E6AF4  token: 0x600031F
        public System.Int32 IndexOfJoystick(System.Int32 joystickId) { }
        // RVA: 0x093E6ADC  token: 0x6000320
        public System.Boolean ContainsJoystick(System.Int32 joystickId) { }
        // RVA: 0x0350B670  token: 0x6000321
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x30
    public class JoystickInfo
    {
        // Fields
        public System.Guid instanceGuid;  // 0x10
        public System.String hardwareIdentifier;  // 0x20
        public System.Int32 id;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000322
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x18
    public class ControllerAssignmentSaveInfo
    {
        // Fields
        public Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;  // 0x10

        // Properties
        System.Int32 playerCount { get; /* RVA: 0x0352ADE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600031A
        public System.Void .ctor() { }
        // RVA: 0x093E2630  token: 0x600031B
        public System.Void .ctor(System.Int32 playerCount) { }
        // RVA: 0x093E24EC  token: 0x600031C
        public System.Int32 IndexOfPlayer(System.Int32 playerId) { }
        // RVA: 0x093E24D4  token: 0x600031D
        public System.Boolean ContainsPlayer(System.Int32 playerId) { }

    }

    // TypeToken: 0x2000026  // size: 0x20
    public class JoystickAssignmentHistoryInfo
    {
        // Fields
        public readonly Rewired.Joystick joystick;  // 0x10
        public readonly System.Int32 oldJoystickId;  // 0x18

        // Methods
        // RVA: 0x093E617C  token: 0x6000323
        public System.Void .ctor(Rewired.Joystick joystick, System.Int32 oldJoystickId) { }

    }

    // TypeToken: 0x2000027  // size: 0x18
    public sealed class <>c__DisplayClass78_0
    {
        // Fields
        public Rewired.Joystick joystick;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000324
        public System.Void .ctor() { }
        // RVA: 0x093A0DBC  token: 0x6000325
        private System.Boolean <LoadJoystickAssignmentsNow>b__0(Rewired.Data.UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) { }

    }

    // TypeToken: 0x2000028  // size: 0x18
    public sealed class <>c__DisplayClass78_1
    {
        // Fields
        public Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000326
        public System.Void .ctor() { }
        // RVA: 0x093EEC40  token: 0x6000327
        private System.Boolean <LoadJoystickAssignmentsNow>b__1(Rewired.Data.UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) { }

    }

    // TypeToken: 0x2000029  // size: 0x18
    public sealed class <>c__DisplayClass78_2
    {
        // Fields
        public Rewired.Joystick match;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000328
        public System.Void .ctor() { }
        // RVA: 0x093A0DBC  token: 0x6000329
        private System.Boolean <LoadJoystickAssignmentsNow>b__2(Rewired.Data.UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) { }

    }

    // TypeToken: 0x200002A  // size: 0x28
    public sealed class <LoadJoystickAssignmentsDeferred>d__80 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Rewired.Data.UserDataStore_PlayerPrefs <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600032A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600032B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x093EEB2C  token: 0x600032C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x093EEBF4  token: 0x600032E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200002F  // size: 0x18
    public class MouseState
    {
        // Fields
        private System.Collections.Generic.List<Rewired.Integration.UnityUI.RewiredPointerInputModule.ButtonState> m_TrackedButtons;  // 0x10

        // Methods
        // RVA: 0x093E67E0  token: 0x6000365
        public System.Boolean AnyPressesThisFrame() { }
        // RVA: 0x093E686C  token: 0x6000366
        public System.Boolean AnyReleasesThisFrame() { }
        // RVA: 0x093E68F8  token: 0x6000367
        public Rewired.Integration.UnityUI.RewiredPointerInputModule.ButtonState GetButtonState(System.Int32 button) { }
        // RVA: 0x093E6A14  token: 0x6000368
        public System.Void SetButtonState(System.Int32 button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, Rewired.Integration.UnityUI.PlayerPointerEventData data) { }
        // RVA: 0x093E6A64  token: 0x6000369
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x20
    public class MouseButtonEventData
    {
        // Fields
        public UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;  // 0x10
        public Rewired.Integration.UnityUI.PlayerPointerEventData buttonData;  // 0x18

        // Methods
        // RVA: 0x093E67CC  token: 0x600036A
        public System.Boolean PressedThisFrame() { }
        // RVA: 0x071262D0  token: 0x600036B
        public System.Boolean ReleasedThisFrame() { }
        // RVA: 0x0350B670  token: 0x600036C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0x20
    public class ButtonState
    {
        // Fields
        private System.Int32 m_Button;  // 0x10
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData m_EventData;  // 0x18

        // Properties
        Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData eventData { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Int32 button { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000371
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x28
    public sealed class UnityInputSource : Rewired.UI.IMouseInputSource, Rewired.UI.ITouchInputSource
    {
        // Fields
        private UnityEngine.Vector2 m_MousePosition;  // 0x10
        private UnityEngine.Vector2 m_MousePositionPrev;  // 0x18
        private System.Int32 m_LastUpdatedFrame;  // 0x20

        // Properties
        System.Int32 Rewired.UI.IMouseInputSource.playerId { get; /* RVA: 0x093EED78 */ }
        System.Int32 Rewired.UI.ITouchInputSource.playerId { get; /* RVA: 0x093EED78 */ }
        System.Boolean Rewired.UI.IMouseInputSource.enabled { get; /* RVA: 0x093EED40 */ }
        System.Boolean Rewired.UI.IMouseInputSource.locked { get; /* RVA: 0x093EED58 */ }
        System.Int32 Rewired.UI.IMouseInputSource.buttonCount { get; /* RVA: 0x093EED28 */ }
        UnityEngine.Vector2 Rewired.UI.IMouseInputSource.screenPosition { get; /* RVA: 0x093EEDCC */ }
        UnityEngine.Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta { get; /* RVA: 0x093EED8C */ }
        UnityEngine.Vector2 Rewired.UI.IMouseInputSource.wheelDelta { get; /* RVA: 0x093EEDFC */ }
        System.Boolean Rewired.UI.ITouchInputSource.touchSupported { get; /* RVA: 0x093EEE90 */ }
        System.Int32 Rewired.UI.ITouchInputSource.touchCount { get; /* RVA: 0x093EEE78 */ }

        // Methods
        // RVA: 0x093EECC8  token: 0x6000377
        private virtual System.Boolean Rewired.UI.IMouseInputSource.GetButtonDown(System.Int32 button) { }
        // RVA: 0x093EECE8  token: 0x6000378
        private virtual System.Boolean Rewired.UI.IMouseInputSource.GetButtonUp(System.Int32 button) { }
        // RVA: 0x093EED08  token: 0x6000379
        private virtual System.Boolean Rewired.UI.IMouseInputSource.GetButton(System.Int32 button) { }
        // RVA: 0x093EEE14  token: 0x600037F
        private virtual UnityEngine.Touch Rewired.UI.ITouchInputSource.GetTouch(System.Int32 index) { }
        // RVA: 0x093EEEA8  token: 0x6000380
        private System.Void TryUpdate() { }
        // RVA: 0x03D5C2D0  token: 0x6000381
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x20
    public class PlayerSetting
    {
        // Fields
        public System.Int32 playerId;  // 0x10
        public System.Collections.Generic.List<Rewired.Components.PlayerMouse> playerMice;  // 0x18

        // Methods
        // RVA: 0x095F46E4  token: 0x60003DD
        public System.Void .ctor() { }
        // RVA: 0x095F475C  token: 0x60003DE
        private System.Void .ctor(Rewired.Integration.UnityUI.RewiredStandaloneInputModule.PlayerSetting other) { }
        // RVA: 0x095F4684  token: 0x60003DF
        public Rewired.Integration.UnityUI.RewiredStandaloneInputModule.PlayerSetting Clone() { }

    }

namespace Rewired
{

    // TypeToken: 0x2000002
    public interface IGamepadTemplate : Rewired.IControllerTemplate
    {
        // Properties
        Rewired.IControllerTemplateButton actionBottomRow1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton a { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton actionBottomRow2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton b { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton actionBottomRow3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton c { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton actionTopRow1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton x { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton actionTopRow2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton y { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton actionTopRow3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton z { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftShoulder1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftBumper { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis leftShoulder2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis leftTrigger { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightShoulder1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightBumper { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis rightShoulder2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis rightTrigger { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton center1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton back { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton center2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton start { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton center3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton guide { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThumbStick leftStick { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThumbStick rightStick { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateDPad dPad { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000003
    public interface IRacingWheelTemplate : Rewired.IControllerTemplate
    {
        // Properties
        Rewired.IControllerTemplateAxis wheel { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis accelerator { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis brake { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis clutch { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shiftDown { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shiftUp { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheelButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton shifter10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton reverseGear { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton select { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton start { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton systemButton { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton horn { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateDPad dPad { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000004
    public interface IHOTASTemplate : Rewired.IControllerTemplate
    {
        // Properties
        Rewired.IControllerTemplateButton stickTrigger { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickTriggerStage2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickPinkyButton { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickPinkyTrigger { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton11 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton stickBaseButton12 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton mode1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton mode2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton mode3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton11 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton12 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton13 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton14 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleBaseButton15 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleSlider1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleSlider2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleSlider3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleSlider4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleDial1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleDial2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleDial3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis throttleDial4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel1Forward { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel1Back { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel1Press { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel2Forward { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel2Back { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel2Press { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel3Forward { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel3Back { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton throttleWheel3Press { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis leftPedal { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis rightPedal { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis slidePedals { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateStick stick { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThumbStick stickMiniStick1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThumbStick stickMiniStick2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat stickHat1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat stickHat2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat stickHat3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat stickHat4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle throttle1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle throttle2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThumbStick throttleMiniStick { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat throttleHat1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat throttleHat2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat throttleHat3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat throttleHat4 { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000005
    public interface IFlightYokeTemplate : Rewired.IControllerTemplate
    {
        // Properties
        Rewired.IControllerTemplateButton leftPaddle { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightPaddle { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftGripButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftGripButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftGripButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftGripButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftGripButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton leftGripButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightGripButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightGripButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightGripButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightGripButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightGripButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton rightGripButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton centerButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheel1Up { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheel1Down { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheel1Press { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheel2Up { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheel2Down { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton wheel2Press { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton consoleButton10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton mode1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton mode2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton mode3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateYoke yoke { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle lever1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle lever2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle lever3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle lever4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle lever5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat leftGripHat { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat rightGripHat { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000006
    public interface IFlightPedalsTemplate : Rewired.IControllerTemplate
    {
        // Properties
        Rewired.IControllerTemplateAxis leftPedal { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis rightPedal { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis slide { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000007
    public interface ISixDofControllerTemplate : Rewired.IControllerTemplate
    {
        // Properties
        Rewired.IControllerTemplateAxis extraAxis1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis extraAxis2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis extraAxis3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateAxis extraAxis4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button3 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button4 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button5 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button6 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button7 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button8 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button9 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button10 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button11 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button12 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button13 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button14 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button15 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button16 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button17 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button18 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button19 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button20 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button21 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button22 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button23 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button24 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button25 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button26 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button27 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button28 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button29 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button30 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button31 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateButton button32 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat hat1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateHat hat2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle throttle1 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateThrottle throttle2 { get; /* RVA: -1  // abstract */ }
        Rewired.IControllerTemplateStick6D stick { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000008  // size: 0x78
    public sealed class GamepadTemplate : Rewired.ControllerTemplate, Rewired.IGamepadTemplate, Rewired.IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;  // static @ 0x0
        public static System.Int32 elementId_leftStickX;  // const
        public static System.Int32 elementId_leftStickY;  // const
        public static System.Int32 elementId_rightStickX;  // const
        public static System.Int32 elementId_rightStickY;  // const
        public static System.Int32 elementId_actionBottomRow1;  // const
        public static System.Int32 elementId_a;  // const
        public static System.Int32 elementId_actionBottomRow2;  // const
        public static System.Int32 elementId_b;  // const
        public static System.Int32 elementId_actionBottomRow3;  // const
        public static System.Int32 elementId_c;  // const
        public static System.Int32 elementId_actionTopRow1;  // const
        public static System.Int32 elementId_x;  // const
        public static System.Int32 elementId_actionTopRow2;  // const
        public static System.Int32 elementId_y;  // const
        public static System.Int32 elementId_actionTopRow3;  // const
        public static System.Int32 elementId_z;  // const
        public static System.Int32 elementId_leftShoulder1;  // const
        public static System.Int32 elementId_leftBumper;  // const
        public static System.Int32 elementId_leftShoulder2;  // const
        public static System.Int32 elementId_leftTrigger;  // const
        public static System.Int32 elementId_rightShoulder1;  // const
        public static System.Int32 elementId_rightBumper;  // const
        public static System.Int32 elementId_rightShoulder2;  // const
        public static System.Int32 elementId_rightTrigger;  // const
        public static System.Int32 elementId_center1;  // const
        public static System.Int32 elementId_back;  // const
        public static System.Int32 elementId_center2;  // const
        public static System.Int32 elementId_start;  // const
        public static System.Int32 elementId_center3;  // const
        public static System.Int32 elementId_guide;  // const
        public static System.Int32 elementId_leftStickButton;  // const
        public static System.Int32 elementId_rightStickButton;  // const
        public static System.Int32 elementId_dPadUp;  // const
        public static System.Int32 elementId_dPadRight;  // const
        public static System.Int32 elementId_dPadDown;  // const
        public static System.Int32 elementId_dPadLeft;  // const
        public static System.Int32 elementId_leftStick;  // const
        public static System.Int32 elementId_rightStick;  // const
        public static System.Int32 elementId_dPad;  // const

        // Properties
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow1 { get; /* RVA: 0x093E4324 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.a { get; /* RVA: 0x093E42E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2 { get; /* RVA: 0x093E4364 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.b { get; /* RVA: 0x093E44A4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3 { get; /* RVA: 0x093E43A4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.c { get; /* RVA: 0x093E4524 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1 { get; /* RVA: 0x093E43E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.x { get; /* RVA: 0x093E4964 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2 { get; /* RVA: 0x093E4424 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.y { get; /* RVA: 0x093E49A4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3 { get; /* RVA: 0x093E4464 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.z { get; /* RVA: 0x093E49E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1 { get; /* RVA: 0x093E46E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper { get; /* RVA: 0x093E46A4 */ }
        Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2 { get; /* RVA: 0x093E4724 */ }
        Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger { get; /* RVA: 0x093E47A4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1 { get; /* RVA: 0x093E4824 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper { get; /* RVA: 0x093E47E4 */ }
        Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2 { get; /* RVA: 0x093E4864 */ }
        Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger { get; /* RVA: 0x093E48E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.center1 { get; /* RVA: 0x093E4564 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.back { get; /* RVA: 0x093E44E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.center2 { get; /* RVA: 0x093E45A4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.start { get; /* RVA: 0x093E4924 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.center3 { get; /* RVA: 0x093E45E4 */ }
        Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.guide { get; /* RVA: 0x093E4664 */ }
        Rewired.IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick { get; /* RVA: 0x093E4764 */ }
        Rewired.IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick { get; /* RVA: 0x093E48A4 */ }
        Rewired.IControllerTemplateDPad Rewired.IGamepadTemplate.dPad { get; /* RVA: 0x093E4624 */ }

        // Methods
        // RVA: 0x093E3638  token: 0x600011A
        public System.Void .ctor(System.Object payload) { }
        // RVA: 0x093E4A24  token: 0x600011B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x78
    public sealed class RacingWheelTemplate : Rewired.ControllerTemplate, Rewired.IRacingWheelTemplate, Rewired.IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;  // static @ 0x0
        public static System.Int32 elementId_wheel;  // const
        public static System.Int32 elementId_accelerator;  // const
        public static System.Int32 elementId_brake;  // const
        public static System.Int32 elementId_clutch;  // const
        public static System.Int32 elementId_shiftDown;  // const
        public static System.Int32 elementId_shiftUp;  // const
        public static System.Int32 elementId_wheelButton1;  // const
        public static System.Int32 elementId_wheelButton2;  // const
        public static System.Int32 elementId_wheelButton3;  // const
        public static System.Int32 elementId_wheelButton4;  // const
        public static System.Int32 elementId_wheelButton5;  // const
        public static System.Int32 elementId_wheelButton6;  // const
        public static System.Int32 elementId_wheelButton7;  // const
        public static System.Int32 elementId_wheelButton8;  // const
        public static System.Int32 elementId_wheelButton9;  // const
        public static System.Int32 elementId_wheelButton10;  // const
        public static System.Int32 elementId_consoleButton1;  // const
        public static System.Int32 elementId_consoleButton2;  // const
        public static System.Int32 elementId_consoleButton3;  // const
        public static System.Int32 elementId_consoleButton4;  // const
        public static System.Int32 elementId_consoleButton5;  // const
        public static System.Int32 elementId_consoleButton6;  // const
        public static System.Int32 elementId_consoleButton7;  // const
        public static System.Int32 elementId_consoleButton8;  // const
        public static System.Int32 elementId_consoleButton9;  // const
        public static System.Int32 elementId_consoleButton10;  // const
        public static System.Int32 elementId_shifter1;  // const
        public static System.Int32 elementId_shifter2;  // const
        public static System.Int32 elementId_shifter3;  // const
        public static System.Int32 elementId_shifter4;  // const
        public static System.Int32 elementId_shifter5;  // const
        public static System.Int32 elementId_shifter6;  // const
        public static System.Int32 elementId_shifter7;  // const
        public static System.Int32 elementId_shifter8;  // const
        public static System.Int32 elementId_shifter9;  // const
        public static System.Int32 elementId_shifter10;  // const
        public static System.Int32 elementId_reverseGear;  // const
        public static System.Int32 elementId_select;  // const
        public static System.Int32 elementId_start;  // const
        public static System.Int32 elementId_systemButton;  // const
        public static System.Int32 elementId_horn;  // const
        public static System.Int32 elementId_dPadUp;  // const
        public static System.Int32 elementId_dPadRight;  // const
        public static System.Int32 elementId_dPadDown;  // const
        public static System.Int32 elementId_dPadLeft;  // const
        public static System.Int32 elementId_dPad;  // const

        // Properties
        Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.wheel { get; /* RVA: 0x093E783C */ }
        Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator { get; /* RVA: 0x093E6DFC */ }
        Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake { get; /* RVA: 0x093E6E3C */ }
        Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch { get; /* RVA: 0x093E6E7C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown { get; /* RVA: 0x093E723C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp { get; /* RVA: 0x093E727C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1 { get; /* RVA: 0x093E75FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2 { get; /* RVA: 0x093E763C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3 { get; /* RVA: 0x093E767C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4 { get; /* RVA: 0x093E76BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5 { get; /* RVA: 0x093E76FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6 { get; /* RVA: 0x093E773C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7 { get; /* RVA: 0x093E777C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8 { get; /* RVA: 0x093E77BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9 { get; /* RVA: 0x093E77FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10 { get; /* RVA: 0x093E75BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1 { get; /* RVA: 0x093E6EFC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2 { get; /* RVA: 0x093E6F3C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3 { get; /* RVA: 0x093E6F7C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4 { get; /* RVA: 0x093E6FBC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5 { get; /* RVA: 0x093E6FFC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6 { get; /* RVA: 0x093E703C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7 { get; /* RVA: 0x093E707C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8 { get; /* RVA: 0x093E70BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9 { get; /* RVA: 0x093E70FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10 { get; /* RVA: 0x093E6EBC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1 { get; /* RVA: 0x093E72FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2 { get; /* RVA: 0x093E733C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3 { get; /* RVA: 0x093E737C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4 { get; /* RVA: 0x093E73BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5 { get; /* RVA: 0x093E73FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6 { get; /* RVA: 0x093E743C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7 { get; /* RVA: 0x093E747C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8 { get; /* RVA: 0x093E74BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9 { get; /* RVA: 0x093E74FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10 { get; /* RVA: 0x093E72BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear { get; /* RVA: 0x093E71BC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.select { get; /* RVA: 0x093E71FC */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.start { get; /* RVA: 0x093E753C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton { get; /* RVA: 0x093E757C */ }
        Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.horn { get; /* RVA: 0x093E717C */ }
        Rewired.IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad { get; /* RVA: 0x093E713C */ }

        // Methods
        // RVA: 0x093E3638  token: 0x6000146
        public System.Void .ctor(System.Object payload) { }
        // RVA: 0x093E7878  token: 0x6000147
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x78
    public sealed class HOTASTemplate : Rewired.ControllerTemplate, Rewired.IHOTASTemplate, Rewired.IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;  // static @ 0x0
        public static System.Int32 elementId_stickX;  // const
        public static System.Int32 elementId_stickY;  // const
        public static System.Int32 elementId_stickRotate;  // const
        public static System.Int32 elementId_stickMiniStick1X;  // const
        public static System.Int32 elementId_stickMiniStick1Y;  // const
        public static System.Int32 elementId_stickMiniStick1Press;  // const
        public static System.Int32 elementId_stickMiniStick2X;  // const
        public static System.Int32 elementId_stickMiniStick2Y;  // const
        public static System.Int32 elementId_stickMiniStick2Press;  // const
        public static System.Int32 elementId_stickTrigger;  // const
        public static System.Int32 elementId_stickTriggerStage2;  // const
        public static System.Int32 elementId_stickPinkyButton;  // const
        public static System.Int32 elementId_stickPinkyTrigger;  // const
        public static System.Int32 elementId_stickButton1;  // const
        public static System.Int32 elementId_stickButton2;  // const
        public static System.Int32 elementId_stickButton3;  // const
        public static System.Int32 elementId_stickButton4;  // const
        public static System.Int32 elementId_stickButton5;  // const
        public static System.Int32 elementId_stickButton6;  // const
        public static System.Int32 elementId_stickButton7;  // const
        public static System.Int32 elementId_stickButton8;  // const
        public static System.Int32 elementId_stickButton9;  // const
        public static System.Int32 elementId_stickButton10;  // const
        public static System.Int32 elementId_stickBaseButton1;  // const
        public static System.Int32 elementId_stickBaseButton2;  // const
        public static System.Int32 elementId_stickBaseButton3;  // const
        public static System.Int32 elementId_stickBaseButton4;  // const
        public static System.Int32 elementId_stickBaseButton5;  // const
        public static System.Int32 elementId_stickBaseButton6;  // const
        public static System.Int32 elementId_stickBaseButton7;  // const
        public static System.Int32 elementId_stickBaseButton8;  // const
        public static System.Int32 elementId_stickBaseButton9;  // const
        public static System.Int32 elementId_stickBaseButton10;  // const
        public static System.Int32 elementId_stickBaseButton11;  // const
        public static System.Int32 elementId_stickBaseButton12;  // const
        public static System.Int32 elementId_stickHat1Up;  // const
        public static System.Int32 elementId_stickHat1UpRight;  // const
        public static System.Int32 elementId_stickHat1Right;  // const
        public static System.Int32 elementId_stickHat1DownRight;  // const
        public static System.Int32 elementId_stickHat1Down;  // const
        public static System.Int32 elementId_stickHat1DownLeft;  // const
        public static System.Int32 elementId_stickHat1Left;  // const
        public static System.Int32 elementId_stickHat1Up_Left;  // const
        public static System.Int32 elementId_stickHat2Up;  // const
        public static System.Int32 elementId_stickHat2Up_right;  // const
        public static System.Int32 elementId_stickHat2Right;  // const
        public static System.Int32 elementId_stickHat2Down_Right;  // const
        public static System.Int32 elementId_stickHat2Down;  // const
        public static System.Int32 elementId_stickHat2Down_Left;  // const
        public static System.Int32 elementId_stickHat2Left;  // const
        public static System.Int32 elementId_stickHat2Up_Left;  // const
        public static System.Int32 elementId_stickHat3Up;  // const
        public static System.Int32 elementId_stickHat3Up_Right;  // const
        public static System.Int32 elementId_stickHat3Right;  // const
        public static System.Int32 elementId_stickHat3Down_Right;  // const
        public static System.Int32 elementId_stickHat3Down;  // const
        public static System.Int32 elementId_stickHat3Down_Left;  // const
        public static System.Int32 elementId_stickHat3Left;  // const
        public static System.Int32 elementId_stickHat3Up_Left;  // const
        public static System.Int32 elementId_stickHat4Up;  // const
        public static System.Int32 elementId_stickHat4Up_Right;  // const
        public static System.Int32 elementId_stickHat4Right;  // const
        public static System.Int32 elementId_stickHat4Down_Right;  // const
        public static System.Int32 elementId_stickHat4Down;  // const
        public static System.Int32 elementId_stickHat4Down_Left;  // const
        public static System.Int32 elementId_stickHat4Left;  // const
        public static System.Int32 elementId_stickHat4Up_Left;  // const
        public static System.Int32 elementId_mode1;  // const
        public static System.Int32 elementId_mode2;  // const
        public static System.Int32 elementId_mode3;  // const
        public static System.Int32 elementId_throttle1Axis;  // const
        public static System.Int32 elementId_throttle2Axis;  // const
        public static System.Int32 elementId_throttle1MinDetent;  // const
        public static System.Int32 elementId_throttle2MinDetent;  // const
        public static System.Int32 elementId_throttleButton1;  // const
        public static System.Int32 elementId_throttleButton2;  // const
        public static System.Int32 elementId_throttleButton3;  // const
        public static System.Int32 elementId_throttleButton4;  // const
        public static System.Int32 elementId_throttleButton5;  // const
        public static System.Int32 elementId_throttleButton6;  // const
        public static System.Int32 elementId_throttleButton7;  // const
        public static System.Int32 elementId_throttleButton8;  // const
        public static System.Int32 elementId_throttleButton9;  // const
        public static System.Int32 elementId_throttleButton10;  // const
        public static System.Int32 elementId_throttleBaseButton1;  // const
        public static System.Int32 elementId_throttleBaseButton2;  // const
        public static System.Int32 elementId_throttleBaseButton3;  // const
        public static System.Int32 elementId_throttleBaseButton4;  // const
        public static System.Int32 elementId_throttleBaseButton5;  // const
        public static System.Int32 elementId_throttleBaseButton6;  // const
        public static System.Int32 elementId_throttleBaseButton7;  // const
        public static System.Int32 elementId_throttleBaseButton8;  // const
        public static System.Int32 elementId_throttleBaseButton9;  // const
        public static System.Int32 elementId_throttleBaseButton10;  // const
        public static System.Int32 elementId_throttleBaseButton11;  // const
        public static System.Int32 elementId_throttleBaseButton12;  // const
        public static System.Int32 elementId_throttleBaseButton13;  // const
        public static System.Int32 elementId_throttleBaseButton14;  // const
        public static System.Int32 elementId_throttleBaseButton15;  // const
        public static System.Int32 elementId_throttleSlider1;  // const
        public static System.Int32 elementId_throttleSlider2;  // const
        public static System.Int32 elementId_throttleSlider3;  // const
        public static System.Int32 elementId_throttleSlider4;  // const
        public static System.Int32 elementId_throttleDial1;  // const
        public static System.Int32 elementId_throttleDial2;  // const
        public static System.Int32 elementId_throttleDial3;  // const
        public static System.Int32 elementId_throttleDial4;  // const
        public static System.Int32 elementId_throttleMiniStickX;  // const
        public static System.Int32 elementId_throttleMiniStickY;  // const
        public static System.Int32 elementId_throttleMiniStickPress;  // const
        public static System.Int32 elementId_throttleWheel1Forward;  // const
        public static System.Int32 elementId_throttleWheel1Back;  // const
        public static System.Int32 elementId_throttleWheel1Press;  // const
        public static System.Int32 elementId_throttleWheel2Forward;  // const
        public static System.Int32 elementId_throttleWheel2Back;  // const
        public static System.Int32 elementId_throttleWheel2Press;  // const
        public static System.Int32 elementId_throttleWheel3Forward;  // const
        public static System.Int32 elementId_throttleWheel3Back;  // const
        public static System.Int32 elementId_throttleWheel3Press;  // const
        public static System.Int32 elementId_throttleHat1Up;  // const
        public static System.Int32 elementId_throttleHat1Up_Right;  // const
        public static System.Int32 elementId_throttleHat1Right;  // const
        public static System.Int32 elementId_throttleHat1Down_Right;  // const
        public static System.Int32 elementId_throttleHat1Down;  // const
        public static System.Int32 elementId_throttleHat1Down_Left;  // const
        public static System.Int32 elementId_throttleHat1Left;  // const
        public static System.Int32 elementId_throttleHat1Up_Left;  // const
        public static System.Int32 elementId_throttleHat2Up;  // const
        public static System.Int32 elementId_throttleHat2Up_Right;  // const
        public static System.Int32 elementId_throttleHat2Right;  // const
        public static System.Int32 elementId_throttleHat2Down_Right;  // const
        public static System.Int32 elementId_throttleHat2Down;  // const
        public static System.Int32 elementId_throttleHat2Down_Left;  // const
        public static System.Int32 elementId_throttleHat2Left;  // const
        public static System.Int32 elementId_throttleHat2Up_Left;  // const
        public static System.Int32 elementId_throttleHat3Up;  // const
        public static System.Int32 elementId_throttleHat3Up_Right;  // const
        public static System.Int32 elementId_throttleHat3Right;  // const
        public static System.Int32 elementId_throttleHat3Down_Right;  // const
        public static System.Int32 elementId_throttleHat3Down;  // const
        public static System.Int32 elementId_throttleHat3Down_Left;  // const
        public static System.Int32 elementId_throttleHat3Left;  // const
        public static System.Int32 elementId_throttleHat3Up_Left;  // const
        public static System.Int32 elementId_throttleHat4Up;  // const
        public static System.Int32 elementId_throttleHat4Up_Right;  // const
        public static System.Int32 elementId_throttleHat4Right;  // const
        public static System.Int32 elementId_throttleHat4Down_Right;  // const
        public static System.Int32 elementId_throttleHat4Down;  // const
        public static System.Int32 elementId_throttleHat4Down_Left;  // const
        public static System.Int32 elementId_throttleHat4Left;  // const
        public static System.Int32 elementId_throttleHat4Up_Left;  // const
        public static System.Int32 elementId_leftPedal;  // const
        public static System.Int32 elementId_rightPedal;  // const
        public static System.Int32 elementId_slidePedals;  // const
        public static System.Int32 elementId_stick;  // const
        public static System.Int32 elementId_stickMiniStick1;  // const
        public static System.Int32 elementId_stickMiniStick2;  // const
        public static System.Int32 elementId_stickHat1;  // const
        public static System.Int32 elementId_stickHat2;  // const
        public static System.Int32 elementId_stickHat3;  // const
        public static System.Int32 elementId_stickHat4;  // const
        public static System.Int32 elementId_throttle1;  // const
        public static System.Int32 elementId_throttle2;  // const
        public static System.Int32 elementId_throttleMiniStick;  // const
        public static System.Int32 elementId_throttleHat1;  // const
        public static System.Int32 elementId_throttleHat2;  // const
        public static System.Int32 elementId_throttleHat3;  // const
        public static System.Int32 elementId_throttleHat4;  // const

        // Properties
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickTrigger { get; /* RVA: 0x093E53C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2 { get; /* RVA: 0x093E5388 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton { get; /* RVA: 0x093E5308 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger { get; /* RVA: 0x093E5348 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1 { get; /* RVA: 0x093E4F48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2 { get; /* RVA: 0x093E4F88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3 { get; /* RVA: 0x093E4FC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4 { get; /* RVA: 0x093E5008 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5 { get; /* RVA: 0x093E5048 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6 { get; /* RVA: 0x093E5088 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7 { get; /* RVA: 0x093E50C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8 { get; /* RVA: 0x093E5108 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9 { get; /* RVA: 0x093E5148 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10 { get; /* RVA: 0x093E4F08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1 { get; /* RVA: 0x093E4CC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2 { get; /* RVA: 0x093E4D08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3 { get; /* RVA: 0x093E4D48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4 { get; /* RVA: 0x093E4D88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5 { get; /* RVA: 0x093E4DC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6 { get; /* RVA: 0x093E4E08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7 { get; /* RVA: 0x093E4E48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8 { get; /* RVA: 0x093E4E88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9 { get; /* RVA: 0x093E4EC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10 { get; /* RVA: 0x093E4C08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11 { get; /* RVA: 0x093E4C48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12 { get; /* RVA: 0x093E4C88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.mode1 { get; /* RVA: 0x093E4AC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.mode2 { get; /* RVA: 0x093E4B08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.mode3 { get; /* RVA: 0x093E4B48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1 { get; /* RVA: 0x093E58C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2 { get; /* RVA: 0x093E5908 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3 { get; /* RVA: 0x093E5948 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4 { get; /* RVA: 0x093E5988 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5 { get; /* RVA: 0x093E59C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6 { get; /* RVA: 0x093E5A08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7 { get; /* RVA: 0x093E5A48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8 { get; /* RVA: 0x093E5A88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9 { get; /* RVA: 0x093E5AC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10 { get; /* RVA: 0x093E5888 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1 { get; /* RVA: 0x093E5648 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2 { get; /* RVA: 0x093E5688 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3 { get; /* RVA: 0x093E56C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4 { get; /* RVA: 0x093E5708 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5 { get; /* RVA: 0x093E5748 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6 { get; /* RVA: 0x093E5788 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7 { get; /* RVA: 0x093E57C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8 { get; /* RVA: 0x093E5808 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9 { get; /* RVA: 0x093E5848 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10 { get; /* RVA: 0x093E54C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11 { get; /* RVA: 0x093E5508 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12 { get; /* RVA: 0x093E5548 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13 { get; /* RVA: 0x093E5588 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14 { get; /* RVA: 0x093E55C8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15 { get; /* RVA: 0x093E5608 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1 { get; /* RVA: 0x093E5D48 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2 { get; /* RVA: 0x093E5D88 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3 { get; /* RVA: 0x093E5DC8 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4 { get; /* RVA: 0x093E5E08 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1 { get; /* RVA: 0x093E5B08 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2 { get; /* RVA: 0x093E5B48 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3 { get; /* RVA: 0x093E5B88 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4 { get; /* RVA: 0x093E5BC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward { get; /* RVA: 0x093E5E88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back { get; /* RVA: 0x093E5E48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press { get; /* RVA: 0x093E5EC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward { get; /* RVA: 0x093E5F48 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back { get; /* RVA: 0x093E5F08 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press { get; /* RVA: 0x093E5F88 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward { get; /* RVA: 0x093E6008 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back { get; /* RVA: 0x093E5FC8 */ }
        Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press { get; /* RVA: 0x093E6048 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal { get; /* RVA: 0x093E4A88 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal { get; /* RVA: 0x093E4B88 */ }
        Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals { get; /* RVA: 0x093E4BC8 */ }
        Rewired.IControllerTemplateStick Rewired.IHOTASTemplate.stick { get; /* RVA: 0x093E5408 */ }
        Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1 { get; /* RVA: 0x093E5288 */ }
        Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2 { get; /* RVA: 0x093E52C8 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1 { get; /* RVA: 0x093E5188 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2 { get; /* RVA: 0x093E51C8 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3 { get; /* RVA: 0x093E5208 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4 { get; /* RVA: 0x093E5248 */ }
        Rewired.IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1 { get; /* RVA: 0x093E5448 */ }
        Rewired.IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2 { get; /* RVA: 0x093E5488 */ }
        Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick { get; /* RVA: 0x093E5D08 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1 { get; /* RVA: 0x093E5C08 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2 { get; /* RVA: 0x093E5C48 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3 { get; /* RVA: 0x093E5C88 */ }
        Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4 { get; /* RVA: 0x093E5CC8 */ }

        // Methods
        // RVA: 0x093E3638  token: 0x60001A0
        public System.Void .ctor(System.Object payload) { }
        // RVA: 0x093E6088  token: 0x60001A1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x78
    public sealed class FlightYokeTemplate : Rewired.ControllerTemplate, Rewired.IFlightYokeTemplate, Rewired.IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;  // static @ 0x0
        public static System.Int32 elementId_rotateYoke;  // const
        public static System.Int32 elementId_yokeZ;  // const
        public static System.Int32 elementId_leftPaddle;  // const
        public static System.Int32 elementId_rightPaddle;  // const
        public static System.Int32 elementId_lever1Axis;  // const
        public static System.Int32 elementId_lever1MinDetent;  // const
        public static System.Int32 elementId_lever2Axis;  // const
        public static System.Int32 elementId_lever2MinDetent;  // const
        public static System.Int32 elementId_lever3Axis;  // const
        public static System.Int32 elementId_lever3MinDetent;  // const
        public static System.Int32 elementId_lever4Axis;  // const
        public static System.Int32 elementId_lever4MinDetent;  // const
        public static System.Int32 elementId_lever5Axis;  // const
        public static System.Int32 elementId_lever5MinDetent;  // const
        public static System.Int32 elementId_leftGripButton1;  // const
        public static System.Int32 elementId_leftGripButton2;  // const
        public static System.Int32 elementId_leftGripButton3;  // const
        public static System.Int32 elementId_leftGripButton4;  // const
        public static System.Int32 elementId_leftGripButton5;  // const
        public static System.Int32 elementId_leftGripButton6;  // const
        public static System.Int32 elementId_rightGripButton1;  // const
        public static System.Int32 elementId_rightGripButton2;  // const
        public static System.Int32 elementId_rightGripButton3;  // const
        public static System.Int32 elementId_rightGripButton4;  // const
        public static System.Int32 elementId_rightGripButton5;  // const
        public static System.Int32 elementId_rightGripButton6;  // const
        public static System.Int32 elementId_centerButton1;  // const
        public static System.Int32 elementId_centerButton2;  // const
        public static System.Int32 elementId_centerButton3;  // const
        public static System.Int32 elementId_centerButton4;  // const
        public static System.Int32 elementId_centerButton5;  // const
        public static System.Int32 elementId_centerButton6;  // const
        public static System.Int32 elementId_centerButton7;  // const
        public static System.Int32 elementId_centerButton8;  // const
        public static System.Int32 elementId_wheel1Up;  // const
        public static System.Int32 elementId_wheel1Down;  // const
        public static System.Int32 elementId_wheel1Press;  // const
        public static System.Int32 elementId_wheel2Up;  // const
        public static System.Int32 elementId_wheel2Down;  // const
        public static System.Int32 elementId_wheel2Press;  // const
        public static System.Int32 elementId_leftGripHatUp;  // const
        public static System.Int32 elementId_leftGripHatUpRight;  // const
        public static System.Int32 elementId_leftGripHatRight;  // const
        public static System.Int32 elementId_leftGripHatDownRight;  // const
        public static System.Int32 elementId_leftGripHatDown;  // const
        public static System.Int32 elementId_leftGripHatDownLeft;  // const
        public static System.Int32 elementId_leftGripHatLeft;  // const
        public static System.Int32 elementId_leftGripHatUpLeft;  // const
        public static System.Int32 elementId_rightGripHatUp;  // const
        public static System.Int32 elementId_rightGripHatUpRight;  // const
        public static System.Int32 elementId_rightGripHatRight;  // const
        public static System.Int32 elementId_rightGripHatDownRight;  // const
        public static System.Int32 elementId_rightGripHatDown;  // const
        public static System.Int32 elementId_rightGripHatDownLeft;  // const
        public static System.Int32 elementId_rightGripHatLeft;  // const
        public static System.Int32 elementId_rightGripHatUpLeft;  // const
        public static System.Int32 elementId_consoleButton1;  // const
        public static System.Int32 elementId_consoleButton2;  // const
        public static System.Int32 elementId_consoleButton3;  // const
        public static System.Int32 elementId_consoleButton4;  // const
        public static System.Int32 elementId_consoleButton5;  // const
        public static System.Int32 elementId_consoleButton6;  // const
        public static System.Int32 elementId_consoleButton7;  // const
        public static System.Int32 elementId_consoleButton8;  // const
        public static System.Int32 elementId_consoleButton9;  // const
        public static System.Int32 elementId_consoleButton10;  // const
        public static System.Int32 elementId_mode1;  // const
        public static System.Int32 elementId_mode2;  // const
        public static System.Int32 elementId_mode3;  // const
        public static System.Int32 elementId_yoke;  // const
        public static System.Int32 elementId_lever1;  // const
        public static System.Int32 elementId_lever2;  // const
        public static System.Int32 elementId_lever3;  // const
        public static System.Int32 elementId_lever4;  // const
        public static System.Int32 elementId_lever5;  // const
        public static System.Int32 elementId_leftGripHat;  // const
        public static System.Int32 elementId_rightGripHat;  // const

        // Properties
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftPaddle { get; /* RVA: 0x093E3C80 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle { get; /* RVA: 0x093E4080 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1 { get; /* RVA: 0x093E3AC0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2 { get; /* RVA: 0x093E3B00 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3 { get; /* RVA: 0x093E3B40 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4 { get; /* RVA: 0x093E3B80 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5 { get; /* RVA: 0x093E3BC0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6 { get; /* RVA: 0x093E3C00 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1 { get; /* RVA: 0x093E3EC0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2 { get; /* RVA: 0x093E3F00 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3 { get; /* RVA: 0x093E3F40 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4 { get; /* RVA: 0x093E3F80 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5 { get; /* RVA: 0x093E3FC0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6 { get; /* RVA: 0x093E4000 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1 { get; /* RVA: 0x093E3640 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2 { get; /* RVA: 0x093E3680 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3 { get; /* RVA: 0x093E36C0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4 { get; /* RVA: 0x093E3700 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5 { get; /* RVA: 0x093E3740 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6 { get; /* RVA: 0x093E3780 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7 { get; /* RVA: 0x093E37C0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8 { get; /* RVA: 0x093E3800 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up { get; /* RVA: 0x093E4140 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down { get; /* RVA: 0x093E40C0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press { get; /* RVA: 0x093E4100 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up { get; /* RVA: 0x093E4200 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down { get; /* RVA: 0x093E4180 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press { get; /* RVA: 0x093E41C0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1 { get; /* RVA: 0x093E3880 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2 { get; /* RVA: 0x093E38C0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3 { get; /* RVA: 0x093E3900 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4 { get; /* RVA: 0x093E3940 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5 { get; /* RVA: 0x093E3980 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6 { get; /* RVA: 0x093E39C0 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7 { get; /* RVA: 0x093E3A00 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8 { get; /* RVA: 0x093E3A40 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9 { get; /* RVA: 0x093E3A80 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10 { get; /* RVA: 0x093E3840 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1 { get; /* RVA: 0x093E3E00 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2 { get; /* RVA: 0x093E3E40 */ }
        Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3 { get; /* RVA: 0x093E3E80 */ }
        Rewired.IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke { get; /* RVA: 0x093E4240 */ }
        Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1 { get; /* RVA: 0x093E3CC0 */ }
        Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2 { get; /* RVA: 0x093E3D00 */ }
        Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3 { get; /* RVA: 0x093E3D40 */ }
        Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4 { get; /* RVA: 0x093E3D80 */ }
        Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5 { get; /* RVA: 0x093E3DC0 */ }
        Rewired.IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat { get; /* RVA: 0x093E3C40 */ }
        Rewired.IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat { get; /* RVA: 0x093E4040 */ }

        // Methods
        // RVA: 0x093E3638  token: 0x60001D3
        public System.Void .ctor(System.Object payload) { }
        // RVA: 0x093E4280  token: 0x60001D4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x78
    public sealed class FlightPedalsTemplate : Rewired.ControllerTemplate, Rewired.IFlightPedalsTemplate, Rewired.IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;  // static @ 0x0
        public static System.Int32 elementId_leftPedal;  // const
        public static System.Int32 elementId_rightPedal;  // const
        public static System.Int32 elementId_slide;  // const

        // Properties
        Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.leftPedal { get; /* RVA: 0x093E3518 */ }
        Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal { get; /* RVA: 0x093E3554 */ }
        Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide { get; /* RVA: 0x093E3594 */ }

        // Methods
        // RVA: 0x093E3638  token: 0x60001D8
        public System.Void .ctor(System.Object payload) { }
        // RVA: 0x093E35D4  token: 0x60001D9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x78
    public sealed class SixDofControllerTemplate : Rewired.ControllerTemplate, Rewired.ISixDofControllerTemplate, Rewired.IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;  // static @ 0x0
        public static System.Int32 elementId_positionX;  // const
        public static System.Int32 elementId_positionY;  // const
        public static System.Int32 elementId_positionZ;  // const
        public static System.Int32 elementId_rotationX;  // const
        public static System.Int32 elementId_rotationY;  // const
        public static System.Int32 elementId_rotationZ;  // const
        public static System.Int32 elementId_throttle1Axis;  // const
        public static System.Int32 elementId_throttle1MinDetent;  // const
        public static System.Int32 elementId_throttle2Axis;  // const
        public static System.Int32 elementId_throttle2MinDetent;  // const
        public static System.Int32 elementId_extraAxis1;  // const
        public static System.Int32 elementId_extraAxis2;  // const
        public static System.Int32 elementId_extraAxis3;  // const
        public static System.Int32 elementId_extraAxis4;  // const
        public static System.Int32 elementId_button1;  // const
        public static System.Int32 elementId_button2;  // const
        public static System.Int32 elementId_button3;  // const
        public static System.Int32 elementId_button4;  // const
        public static System.Int32 elementId_button5;  // const
        public static System.Int32 elementId_button6;  // const
        public static System.Int32 elementId_button7;  // const
        public static System.Int32 elementId_button8;  // const
        public static System.Int32 elementId_button9;  // const
        public static System.Int32 elementId_button10;  // const
        public static System.Int32 elementId_button11;  // const
        public static System.Int32 elementId_button12;  // const
        public static System.Int32 elementId_button13;  // const
        public static System.Int32 elementId_button14;  // const
        public static System.Int32 elementId_button15;  // const
        public static System.Int32 elementId_button16;  // const
        public static System.Int32 elementId_button17;  // const
        public static System.Int32 elementId_button18;  // const
        public static System.Int32 elementId_button19;  // const
        public static System.Int32 elementId_button20;  // const
        public static System.Int32 elementId_button21;  // const
        public static System.Int32 elementId_button22;  // const
        public static System.Int32 elementId_button23;  // const
        public static System.Int32 elementId_button24;  // const
        public static System.Int32 elementId_button25;  // const
        public static System.Int32 elementId_button26;  // const
        public static System.Int32 elementId_button27;  // const
        public static System.Int32 elementId_button28;  // const
        public static System.Int32 elementId_button29;  // const
        public static System.Int32 elementId_button30;  // const
        public static System.Int32 elementId_button31;  // const
        public static System.Int32 elementId_button32;  // const
        public static System.Int32 elementId_hat1Up;  // const
        public static System.Int32 elementId_hat1UpRight;  // const
        public static System.Int32 elementId_hat1Right;  // const
        public static System.Int32 elementId_hat1DownRight;  // const
        public static System.Int32 elementId_hat1Down;  // const
        public static System.Int32 elementId_hat1DownLeft;  // const
        public static System.Int32 elementId_hat1Left;  // const
        public static System.Int32 elementId_hat1UpLeft;  // const
        public static System.Int32 elementId_hat2Up;  // const
        public static System.Int32 elementId_hat2UpRight;  // const
        public static System.Int32 elementId_hat2Right;  // const
        public static System.Int32 elementId_hat2DownRight;  // const
        public static System.Int32 elementId_hat2Down;  // const
        public static System.Int32 elementId_hat2DownLeft;  // const
        public static System.Int32 elementId_hat2Left;  // const
        public static System.Int32 elementId_hat2UpLeft;  // const
        public static System.Int32 elementId_hat1;  // const
        public static System.Int32 elementId_hat2;  // const
        public static System.Int32 elementId_throttle1;  // const
        public static System.Int32 elementId_throttle2;  // const
        public static System.Int32 elementId_stick;  // const

        // Properties
        Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis1 { get; /* RVA: 0x093EE774 */ }
        Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2 { get; /* RVA: 0x093EE7B4 */ }
        Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3 { get; /* RVA: 0x093EE7F4 */ }
        Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4 { get; /* RVA: 0x093EE834 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1 { get; /* RVA: 0x093EE1F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2 { get; /* RVA: 0x093EE4B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3 { get; /* RVA: 0x093EE5B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4 { get; /* RVA: 0x093EE5F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5 { get; /* RVA: 0x093EE634 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6 { get; /* RVA: 0x093EE674 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7 { get; /* RVA: 0x093EE6B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8 { get; /* RVA: 0x093EE6F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9 { get; /* RVA: 0x093EE734 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10 { get; /* RVA: 0x093EDF74 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11 { get; /* RVA: 0x093EDFB4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12 { get; /* RVA: 0x093EDFF4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13 { get; /* RVA: 0x093EE034 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14 { get; /* RVA: 0x093EE074 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15 { get; /* RVA: 0x093EE0B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16 { get; /* RVA: 0x093EE0F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17 { get; /* RVA: 0x093EE134 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18 { get; /* RVA: 0x093EE174 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19 { get; /* RVA: 0x093EE1B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20 { get; /* RVA: 0x093EE234 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21 { get; /* RVA: 0x093EE274 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22 { get; /* RVA: 0x093EE2B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23 { get; /* RVA: 0x093EE2F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24 { get; /* RVA: 0x093EE334 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25 { get; /* RVA: 0x093EE374 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26 { get; /* RVA: 0x093EE3B4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27 { get; /* RVA: 0x093EE3F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28 { get; /* RVA: 0x093EE434 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29 { get; /* RVA: 0x093EE474 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30 { get; /* RVA: 0x093EE4F4 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31 { get; /* RVA: 0x093EE534 */ }
        Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32 { get; /* RVA: 0x093EE574 */ }
        Rewired.IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1 { get; /* RVA: 0x093EE874 */ }
        Rewired.IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2 { get; /* RVA: 0x093EE8B4 */ }
        Rewired.IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1 { get; /* RVA: 0x093EE934 */ }
        Rewired.IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2 { get; /* RVA: 0x093EE974 */ }
        Rewired.IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick { get; /* RVA: 0x093EE8F4 */ }

        // Methods
        // RVA: 0x093E3638  token: 0x6000203
        public System.Void .ctor(System.Object payload) { }
        // RVA: 0x093EE9B4  token: 0x6000204
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x58
    public sealed class InputManager : Rewired.InputManager_Base
    {
        // Fields
        private System.Boolean ignoreRecompile;  // 0x50

        // Methods
        // RVA: 0x03170440  token: 0x6000205
        protected virtual System.Void OnInitialized() { }
        // RVA: 0x093E6174  token: 0x6000206
        protected virtual System.Void OnDeinitialized() { }
        // RVA: 0x03CFE450  token: 0x6000207
        protected virtual System.Void DetectPlatform() { }
        // RVA: 0x0350B670  token: 0x6000208
        protected virtual System.Void CheckRecompile() { }
        // RVA: 0x03D2CCC0  token: 0x6000209
        protected virtual Rewired.Utils.Interfaces.IExternalTools GetExternalTools() { }
        // RVA: 0x093E60EC  token: 0x600020A
        private System.Boolean CheckDeviceName(System.String searchPattern, System.String deviceName, System.String deviceModel) { }
        // RVA: 0x031709B0  token: 0x600020B
        private System.Void SubscribeEvents() { }
        // RVA: 0x03170A60  token: 0x600020C
        private System.Void UnsubscribeEvents() { }
        // RVA: 0x02F73E80  token: 0x600020D
        private System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        // RVA: 0x03CEB330  token: 0x600020E
        public System.Void .ctor() { }

    }

}

namespace Rewired.Data
{

    // TypeToken: 0x2000010  // size: 0x68
    public class UserDataStore_File : Rewired.Data.UserDataStore_KeyValue
    {
        // Fields
        private static readonly System.String thisScriptName;  // static @ 0x0
        private static System.String logPrefix;  // const
        private static System.String defaultExtensionText;  // const
        private static System.String defaultExtensionBinary;  // const
        private static System.String defaultFileName;  // const
        private System.String _fileName;  // 0x38
        private Rewired.Data.UserDataStore_File.DataFormat _dataFormat;  // 0x40
        private System.String __directory;  // 0x48
        private Rewired.Data.UserDataStore_File.DataStore _dataStore;  // 0x50
        private Rewired.Data.UserDataStore_File.IDataHandler __dataHandler;  // 0x58
        private System.Boolean _initialized;  // 0x60

        // Properties
        System.String directory { get; /* RVA: 0x093EF210 */ set; /* RVA: 0x093EF28C */ }
        System.String fileName { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x093EF2BC */ }
        Rewired.Data.UserDataStore_File.DataFormat dataFormat { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x093EF248 */ }
        Rewired.Data.UserDataStore_File.IDataHandler dataHandler { get; /* RVA: 0x093EF110 */ set; /* RVA: 0x093EF25C */ }
        Rewired.Data.UserDataStore_KeyValue.IDataStore dataStore { get; /* RVA: 0x03D4EAF0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000238
        protected virtual System.Void SetInitialValues() { }
        // RVA: 0x093EEFF4  token: 0x6000239
        protected virtual System.Void OnInitialize() { }
        // RVA: 0x093EEF24  token: 0x600023A
        private System.Void OnDataSourceChanged() { }
        // RVA: 0x093EF0B0  token: 0x600023B
        public System.Void .ctor() { }
        // RVA: 0x093EF018  token: 0x600023C
        private static System.Void .cctor() { }
        // RVA: 0x03D4ED80  token: 0x600023D
        private Rewired.Data.UserDataStore_File.DataFormat <get_dataHandler>b__17_0() { }

    }

    // TypeToken: 0x2000018  // size: 0x38
    public abstract class UserDataStore_KeyValue : Rewired.Data.UserDataStore
    {
        // Fields
        private static readonly System.String thisScriptName;  // static @ 0x0
        private static System.String logPrefix;  // const
        private static System.String key_controllerAssignments;  // const
        private static System.Int32 controllerMapKeyVersion;  // const
        private System.Boolean _isEnabled;  // 0x18
        private System.Boolean _loadDataOnStart;  // 0x19
        private System.Boolean _loadJoystickAssignments;  // 0x1a
        private System.Boolean _loadKeyboardAssignments;  // 0x1b
        private System.Boolean _loadMouseAssignments;  // 0x1c
        private System.Boolean _allowImpreciseJoystickAssignmentMatching;  // 0x1d
        private System.Boolean _deferredJoystickAssignmentLoadPending;  // 0x1e
        private System.Boolean _wasJoystickEverDetected;  // 0x1f
        private System.Collections.Generic.List<System.Int32> __allActionIds;  // 0x20
        private System.String __allActionIdsString;  // 0x28
        private readonly System.Text.StringBuilder _sb;  // 0x30

        // Properties
        System.Boolean isEnabled { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Boolean loadDataOnStart { get; /* RVA: 0x03D4EF80 */ set; /* RVA: 0x03D4EFB0 */ }
        System.Boolean loadJoystickAssignments { get; /* RVA: 0x03D4EFA0 */ set; /* RVA: 0x03D4EFD0 */ }
        System.Boolean loadKeyboardAssignments { get; /* RVA: 0x03D52270 */ set; /* RVA: 0x03D522A0 */ }
        System.Boolean loadMouseAssignments { get; /* RVA: 0x03D4E9A0 */ set; /* RVA: 0x03D4E9B0 */ }
        Rewired.Data.UserDataStore_KeyValue.IDataStore dataStore { get; /* RVA: -1  // abstract */ }
        System.Boolean loadControllerAssignments { get; /* RVA: 0x093F4A50 */ }
        System.Collections.Generic.List<System.Int32> allActionIds { get; /* RVA: 0x093F4910 */ }
        System.String allActionIdsString { get; /* RVA: 0x093F47F8 */ }

        // Methods
        // RVA: 0x093F4354  token: 0x6000262
        public virtual System.Void Save() { }
        // RVA: 0x093F36D8  token: 0x6000263
        public virtual System.Void SaveControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F3604  token: 0x6000264
        public virtual System.Void SaveControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F4294  token: 0x6000265
        public virtual System.Void SavePlayerData(System.Int32 playerId) { }
        // RVA: 0x093F3DE8  token: 0x6000266
        public virtual System.Void SaveInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F2D8C  token: 0x6000267
        public virtual System.Void Load() { }
        // RVA: 0x093F0CE8  token: 0x6000268
        public virtual System.Void LoadControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F0DCC  token: 0x6000269
        public virtual System.Void LoadControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F2CCC  token: 0x600026A
        public virtual System.Void LoadPlayerData(System.Int32 playerId) { }
        // RVA: 0x093F1450  token: 0x600026B
        public virtual System.Void LoadInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F2F20  token: 0x600026C
        protected virtual System.Void OnInitialize() { }
        // RVA: 0x093F2E48  token: 0x600026D
        protected virtual System.Void OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x093F2EF0  token: 0x600026E
        protected virtual System.Void OnControllerPreDisconnect(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x093F2EC0  token: 0x600026F
        protected virtual System.Void OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x093F3994  token: 0x6000270
        public virtual System.Void SaveControllerMap(System.Int32 playerId, Rewired.ControllerMap controllerMap) { }
        // RVA: 0x093F0FB0  token: 0x6000271
        public virtual Rewired.ControllerMap LoadControllerMap(System.Int32 playerId, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093EFAA0  token: 0x6000272
        public virtual System.Void ClearSaveData() { }
        // RVA: 0x093F0954  token: 0x6000273
        private System.Int32 LoadAll() { }
        // RVA: 0x093F2A34  token: 0x6000274
        private System.Int32 LoadPlayerDataNow(System.Int32 playerId) { }
        // RVA: 0x093F2AA4  token: 0x6000275
        private System.Int32 LoadPlayerDataNow(Rewired.Player player) { }
        // RVA: 0x093F0888  token: 0x6000276
        private System.Int32 LoadAllJoystickCalibrationData() { }
        // RVA: 0x093F257C  token: 0x6000277
        private System.Int32 LoadJoystickCalibrationData(Rewired.Joystick joystick) { }
        // RVA: 0x093F25B4  token: 0x6000278
        private System.Int32 LoadJoystickCalibrationData(System.Int32 joystickId) { }
        // RVA: 0x093F2624  token: 0x6000279
        private System.Int32 LoadJoystickData(System.Int32 joystickId) { }
        // RVA: 0x093F0C5C  token: 0x600027A
        private System.Int32 LoadControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F0CC8  token: 0x600027B
        private System.Int32 LoadControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F1070  token: 0x600027C
        private System.Int32 LoadControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F0E9C  token: 0x600027D
        private Rewired.ControllerMap LoadControllerMap(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093F1520  token: 0x600027E
        private System.Int32 LoadInputBehaviors(System.Int32 playerId) { }
        // RVA: 0x093F12E8  token: 0x600027F
        private System.Int32 LoadInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F13AC  token: 0x6000280
        private System.Int32 LoadInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        // RVA: 0x093F0B9C  token: 0x6000281
        private System.Boolean LoadControllerAssignmentsNow() { }
        // RVA: 0x093F276C  token: 0x6000282
        private System.Boolean LoadKeyboardAndMouseAssignmentsNow(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo data) { }
        // RVA: 0x093F16A4  token: 0x6000283
        private System.Boolean LoadJoystickAssignmentsNow(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo data) { }
        // RVA: 0x093F0A58  token: 0x6000284
        private Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }
        // RVA: 0x093F1648  token: 0x6000285
        private System.Collections.IEnumerator LoadJoystickAssignmentsDeferred() { }
        // RVA: 0x093F30E0  token: 0x6000286
        private System.Void SaveAll() { }
        // RVA: 0x093F420C  token: 0x6000287
        private System.Void SavePlayerDataNow(System.Int32 playerId) { }
        // RVA: 0x093F4148  token: 0x6000288
        private System.Void SavePlayerDataNow(Rewired.Player player) { }
        // RVA: 0x093F3024  token: 0x6000289
        private System.Void SaveAllJoystickCalibrationData() { }
        // RVA: 0x093F3F24  token: 0x600028A
        private System.Void SaveJoystickCalibrationData(System.Int32 joystickId) { }
        // RVA: 0x093F3F94  token: 0x600028B
        private System.Void SaveJoystickCalibrationData(Rewired.Joystick joystick) { }
        // RVA: 0x093F4028  token: 0x600028C
        private System.Void SaveJoystickData(System.Int32 joystickId) { }
        // RVA: 0x093F35A8  token: 0x600028D
        private System.Void SaveControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F35F0  token: 0x600028E
        private System.Void SaveControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F3B44  token: 0x600028F
        private System.Void SaveControllerMaps(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        // RVA: 0x093F3A38  token: 0x6000290
        private System.Void SaveControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F37BC  token: 0x6000291
        private System.Void SaveControllerMap(Rewired.Player player, Rewired.ControllerMap controllerMap) { }
        // RVA: 0x093F3EB8  token: 0x6000292
        private System.Void SaveInputBehaviors(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        // RVA: 0x093F3D0C  token: 0x6000293
        private System.Void SaveInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F3C98  token: 0x6000294
        private System.Void SaveInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        // RVA: 0x093F31DC  token: 0x6000295
        private System.Boolean SaveControllerAssignments() { }
        // RVA: 0x093EF7DC  token: 0x6000296
        private static System.Void AppendBaseKey(System.Text.StringBuilder sb, Rewired.Player player) { }
        // RVA: 0x093EFD70  token: 0x6000297
        private System.String GetControllerMapKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        // RVA: 0x093EFE8C  token: 0x6000298
        private System.String GetControllerMapKnownActionIdsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        // RVA: 0x093EF84C  token: 0x6000299
        private static System.Void AppendControllerMapKeyCommonSuffix(System.Text.StringBuilder sb, Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 keyVersion) { }
        // RVA: 0x093F06F0  token: 0x600029A
        private System.String GetJoystickCalibrationMapKey(Rewired.Joystick joystick) { }
        // RVA: 0x093F0574  token: 0x600029B
        private System.String GetInputBehaviorKey(Rewired.Player player, System.Int32 inputBehaviorId) { }
        // RVA: 0x093EFC68  token: 0x600029C
        private System.String GetControllerMapJson(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093EFFA8  token: 0x600029D
        private System.Collections.Generic.List<System.Int32> GetControllerMapKnownActionIds(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093F066C  token: 0x600029E
        private System.String GetJoystickCalibrationMapJson(Rewired.Joystick joystick) { }
        // RVA: 0x093F04E0  token: 0x600029F
        private System.String GetInputBehaviorJson(Rewired.Player player, System.Int32 id) { }
        // RVA: 0x093EF2EC  token: 0x60002A0
        private System.Void AddDefaultMappingsForNewActions(Rewired.ControllerIdentifier controllerIdentifier, Rewired.ControllerMap controllerMap, System.Collections.Generic.List<System.Int32> knownActionIds) { }
        // RVA: 0x093EFB18  token: 0x60002A1
        private Rewired.Joystick FindJoystickPrecise(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }
        // RVA: 0x093F4410  token: 0x60002A2
        private System.Boolean TryFindJoysticksImprecise(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, System.Collections.Generic.List<Rewired.Joystick>& matches) { }
        // RVA: 0x093F2FA8  token: 0x60002A3
        private System.Void RefreshLayoutManager(System.Int32 playerId) { }
        // RVA: 0x093F0180  token: 0x60002A4
        private static System.Int32 GetDuplicateIndex(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier) { }
        // RVA: 0x093F45C4  token: 0x60002A5
        private static System.Boolean TryGetString(Rewired.Data.UserDataStore_KeyValue.IDataStore store, System.String key, System.String& result) { }
        // RVA: 0x093F477C  token: 0x60002A6
        protected System.Void .ctor() { }
        // RVA: 0x093F46E4  token: 0x60002A7
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x40
    public class UserDataStore_PlayerPrefs : Rewired.Data.UserDataStore
    {
        // Fields
        private static System.String thisScriptName;  // const
        private static System.String logPrefix;  // const
        private static System.String editorLoadedMessage;  // const
        private static System.String playerPrefsKeySuffix_controllerAssignments;  // const
        private static System.Int32 controllerMapPPKeyVersion_original;  // const
        private static System.Int32 controllerMapPPKeyVersion_includeDuplicateJoystickIndex;  // const
        private static System.Int32 controllerMapPPKeyVersion_supportDisconnectedControllers;  // const
        private static System.Int32 controllerMapPPKeyVersion_includeFormatVersion;  // const
        private static System.Int32 controllerMapPPKeyVersion;  // const
        private System.Boolean isEnabled;  // 0x18
        private System.Boolean loadDataOnStart;  // 0x19
        private System.Boolean loadJoystickAssignments;  // 0x1a
        private System.Boolean loadKeyboardAssignments;  // 0x1b
        private System.Boolean loadMouseAssignments;  // 0x1c
        private System.String playerPrefsKeyPrefix;  // 0x20
        private System.Boolean allowImpreciseJoystickAssignmentMatching;  // 0x28
        private System.Boolean deferredJoystickAssignmentLoadPending;  // 0x29
        private System.Boolean wasJoystickEverDetected;  // 0x2a
        private System.Collections.Generic.List<System.Int32> __allActionIds;  // 0x30
        private System.String __allActionIdsString;  // 0x38

        // Properties
        System.Boolean IsEnabled { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Boolean LoadDataOnStart { get; /* RVA: 0x03D4EF80 */ set; /* RVA: 0x03D4EFB0 */ }
        System.Boolean LoadJoystickAssignments { get; /* RVA: 0x03D4EFA0 */ set; /* RVA: 0x03D4EFD0 */ }
        System.Boolean LoadKeyboardAssignments { get; /* RVA: 0x03D52270 */ set; /* RVA: 0x03D522A0 */ }
        System.Boolean LoadMouseAssignments { get; /* RVA: 0x03D4E9A0 */ set; /* RVA: 0x03D4E9B0 */ }
        System.String PlayerPrefsKeyPrefix { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String playerPrefsKey_controllerAssignments { get; /* RVA: 0x093F9B54 */ }
        System.Boolean loadControllerAssignments { get; /* RVA: 0x093F4A50 */ }
        System.Collections.Generic.List<System.Int32> allActionIds { get; /* RVA: 0x093F9A14 */ }
        System.String allActionIdsString { get; /* RVA: 0x093F98FC */ }

        // Methods
        // RVA: 0x093F9684  token: 0x60002D4
        public virtual System.Void Save() { }
        // RVA: 0x093F8B14  token: 0x60002D5
        public virtual System.Void SaveControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F8BAC  token: 0x60002D6
        public virtual System.Void SaveControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F960C  token: 0x60002D7
        public virtual System.Void SavePlayerData(System.Int32 playerId) { }
        // RVA: 0x093F91D8  token: 0x60002D8
        public virtual System.Void SaveInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F8324  token: 0x60002D9
        public virtual System.Void Load() { }
        // RVA: 0x093F642C  token: 0x60002DA
        public virtual System.Void LoadControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F63A4  token: 0x60002DB
        public virtual System.Void LoadControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F82AC  token: 0x60002DC
        public virtual System.Void LoadPlayerData(System.Int32 playerId) { }
        // RVA: 0x093F6A78  token: 0x60002DD
        public virtual System.Void LoadInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F8468  token: 0x60002DE
        protected virtual System.Void OnInitialize() { }
        // RVA: 0x093F8390  token: 0x60002DF
        protected virtual System.Void OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x093F8438  token: 0x60002E0
        protected virtual System.Void OnControllerPreDisconnect(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x093F8408  token: 0x60002E1
        protected virtual System.Void OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args) { }
        // RVA: 0x093F8C34  token: 0x60002E2
        public virtual System.Void SaveControllerMap(System.Int32 playerId, Rewired.ControllerMap controllerMap) { }
        // RVA: 0x093F64C4  token: 0x60002E3
        public virtual Rewired.ControllerMap LoadControllerMap(System.Int32 playerId, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093F603C  token: 0x60002E4
        private System.Int32 LoadAll() { }
        // RVA: 0x093F8014  token: 0x60002E5
        private System.Int32 LoadPlayerDataNow(System.Int32 playerId) { }
        // RVA: 0x093F8084  token: 0x60002E6
        private System.Int32 LoadPlayerDataNow(Rewired.Player player) { }
        // RVA: 0x093F5F70  token: 0x60002E7
        private System.Int32 LoadAllJoystickCalibrationData() { }
        // RVA: 0x093F7B5C  token: 0x60002E8
        private System.Int32 LoadJoystickCalibrationData(Rewired.Joystick joystick) { }
        // RVA: 0x093F7B94  token: 0x60002E9
        private System.Int32 LoadJoystickCalibrationData(System.Int32 joystickId) { }
        // RVA: 0x093F7C04  token: 0x60002EA
        private System.Int32 LoadJoystickData(System.Int32 joystickId) { }
        // RVA: 0x093F6318  token: 0x60002EB
        private System.Int32 LoadControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F6384  token: 0x60002EC
        private System.Int32 LoadControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F6698  token: 0x60002ED
        private System.Int32 LoadControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F6584  token: 0x60002EE
        private Rewired.ControllerMap LoadControllerMap(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093F6B00  token: 0x60002EF
        private System.Int32 LoadInputBehaviors(System.Int32 playerId) { }
        // RVA: 0x093F69B4  token: 0x60002F0
        private System.Int32 LoadInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F6910  token: 0x60002F1
        private System.Int32 LoadInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        // RVA: 0x093F6258  token: 0x60002F2
        private System.Boolean LoadControllerAssignmentsNow() { }
        // RVA: 0x093F7D4C  token: 0x60002F3
        private System.Boolean LoadKeyboardAndMouseAssignmentsNow(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }
        // RVA: 0x093F6C84  token: 0x60002F4
        private System.Boolean LoadJoystickAssignmentsNow(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }
        // RVA: 0x093F6140  token: 0x60002F5
        private Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }
        // RVA: 0x093F6C28  token: 0x60002F6
        private System.Collections.IEnumerator LoadJoystickAssignmentsDeferred() { }
        // RVA: 0x093F8628  token: 0x60002F7
        private System.Void SaveAll() { }
        // RVA: 0x093F94D0  token: 0x60002F8
        private System.Void SavePlayerDataNow(System.Int32 playerId) { }
        // RVA: 0x093F9548  token: 0x60002F9
        private System.Void SavePlayerDataNow(Rewired.Player player) { }
        // RVA: 0x093F856C  token: 0x60002FA
        private System.Void SaveAllJoystickCalibrationData() { }
        // RVA: 0x093F92CC  token: 0x60002FB
        private System.Void SaveJoystickCalibrationData(System.Int32 joystickId) { }
        // RVA: 0x093F933C  token: 0x60002FC
        private System.Void SaveJoystickCalibrationData(Rewired.Joystick joystick) { }
        // RVA: 0x093F93B0  token: 0x60002FD
        private System.Void SaveJoystickData(System.Int32 joystickId) { }
        // RVA: 0x093F8AC8  token: 0x60002FE
        private System.Void SaveControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F8AA4  token: 0x60002FF
        private System.Void SaveControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F8E64  token: 0x6000300
        private System.Void SaveControllerMaps(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        // RVA: 0x093F8FB8  token: 0x6000301
        private System.Void SaveControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        // RVA: 0x093F8CC0  token: 0x6000302
        private System.Void SaveControllerMap(Rewired.Player player, Rewired.ControllerMap controllerMap) { }
        // RVA: 0x093F9260  token: 0x6000303
        private System.Void SaveInputBehaviors(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        // RVA: 0x093F9110  token: 0x6000304
        private System.Void SaveInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        // RVA: 0x093F90C4  token: 0x6000305
        private System.Void SaveInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        // RVA: 0x093F870C  token: 0x6000306
        private System.Boolean SaveControllerAssignments() { }
        // RVA: 0x093F4F54  token: 0x6000307
        private System.Boolean ControllerAssignmentSaveDataExists() { }
        // RVA: 0x093F50F0  token: 0x6000308
        private System.String GetBasePlayerPrefsKey(Rewired.Player player) { }
        // RVA: 0x093F56BC  token: 0x6000309
        private System.String GetControllerMapPlayerPrefsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        // RVA: 0x093F5154  token: 0x600030A
        private System.String GetControllerMapKnownActionIdsPlayerPrefsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        // RVA: 0x093F53B8  token: 0x600030B
        private static System.String GetControllerMapPlayerPrefsKeyCommonSuffix(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        // RVA: 0x093F5DCC  token: 0x600030C
        private System.String GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick) { }
        // RVA: 0x093F5CBC  token: 0x600030D
        private System.String GetInputBehaviorPlayerPrefsKey(Rewired.Player player, System.Int32 inputBehaviorId) { }
        // RVA: 0x093F58A4  token: 0x600030E
        private System.String GetControllerMapXml(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093F521C  token: 0x600030F
        private System.Collections.Generic.List<System.Int32> GetControllerMapKnownActionIds(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        // RVA: 0x093F5EFC  token: 0x6000310
        private System.String GetJoystickCalibrationMapXml(Rewired.Joystick joystick) { }
        // RVA: 0x093F5D48  token: 0x6000311
        private System.String GetInputBehaviorXml(Rewired.Player player, System.Int32 id) { }
        // RVA: 0x093F4A64  token: 0x6000312
        private System.Void AddDefaultMappingsForNewActions(Rewired.ControllerIdentifier controllerIdentifier, Rewired.ControllerMap controllerMap, System.Collections.Generic.List<System.Int32> knownActionIds) { }
        // RVA: 0x093F4FA0  token: 0x6000313
        private Rewired.Joystick FindJoystickPrecise(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }
        // RVA: 0x093F96F0  token: 0x6000314
        private System.Boolean TryFindJoysticksImprecise(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, System.Collections.Generic.List<Rewired.Joystick>& matches) { }
        // RVA: 0x093F595C  token: 0x6000315
        private static System.Int32 GetDuplicateIndex(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier) { }
        // RVA: 0x093F84F0  token: 0x6000316
        private System.Void RefreshLayoutManager(System.Int32 playerId) { }
        // RVA: 0x093F5784  token: 0x6000317
        private static System.Type GetControllerMapType(Rewired.ControllerType controllerType) { }
        // RVA: 0x093F98A4  token: 0x6000318
        public System.Void .ctor() { }

    }

}

namespace Rewired.Integration.UnityUI
{

    // TypeToken: 0x200002C  // size: 0x180
    public class PlayerPointerEventData : UnityEngine.EventSystems.PointerEventData
    {
        // Fields
        private System.Int32 <playerId>k__BackingField;  // 0x160
        private System.Int32 <inputSourceIndex>k__BackingField;  // 0x164
        private Rewired.UI.IMouseInputSource <mouseSource>k__BackingField;  // 0x168
        private Rewired.UI.ITouchInputSource <touchSource>k__BackingField;  // 0x170
        private Rewired.Integration.UnityUI.PointerEventType <sourceType>k__BackingField;  // 0x178
        private System.Int32 <buttonIndex>k__BackingField;  // 0x17c

        // Properties
        System.Int32 playerId { get; /* RVA: 0x03D5AFA0 */ set; /* RVA: 0x03D72300 */ }
        System.Int32 inputSourceIndex { get; /* RVA: 0x03D5A840 */ set; /* RVA: 0x03D5A8C0 */ }
        Rewired.UI.IMouseInputSource mouseSource { get; /* RVA: 0x03D570F0 */ set; /* RVA: 0x058B3CA4 */ }
        Rewired.UI.ITouchInputSource touchSource { get; /* RVA: 0x03D574A0 */ set; /* RVA: 0x04275C18 */ }
        Rewired.Integration.UnityUI.PointerEventType sourceType { get; /* RVA: 0x03D6D0A0 */ set; /* RVA: 0x03D72310 */ }
        System.Int32 buttonIndex { get; /* RVA: 0x03D5DB50 */ set; /* RVA: 0x03D5DB60 */ }

        // Methods
        // RVA: 0x093E6DD0  token: 0x6000340
        public System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        // RVA: 0x093E6B84  token: 0x6000341
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200002D  // size: 0x58
    public class RewiredEventSystem : UnityEngine.EventSystems.EventSystem
    {
        // Fields
        private System.Boolean _alwaysUpdate;  // 0x50

        // Properties
        System.Boolean alwaysUpdate { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }

        // Methods
        // RVA: 0x093E78DC  token: 0x6000344
        protected virtual System.Void Update() { }
        // RVA: 0x093E7A18  token: 0x6000345
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x70
    public abstract class RewiredPointerInputModule : UnityEngine.EventSystems.BaseInputModule
    {
        // Fields
        public static System.Int32 kMouseLeftId;  // const
        public static System.Int32 kMouseRightId;  // const
        public static System.Int32 kMouseMiddleId;  // const
        public static System.Int32 kFakeTouchesId;  // const
        private static System.Int32 customButtonsStartingId;  // const
        private static System.Int32 customButtonsMaxCount;  // const
        private static System.Int32 customButtonsLastId;  // const
        private readonly System.Collections.Generic.List<Rewired.UI.IMouseInputSource> m_MouseInputSourcesList;  // 0x48
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,Rewired.Integration.UnityUI.PlayerPointerEventData>[]> m_PlayerPointerData;  // 0x50
        private Rewired.UI.ITouchInputSource m_UserDefaultTouchInputSource;  // 0x58
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource;  // 0x60
        private readonly Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseState m_MouseState;  // 0x68

        // Properties
        Rewired.Integration.UnityUI.RewiredPointerInputModule.UnityInputSource defaultInputSource { get; /* RVA: 0x093EA2DC */ }
        Rewired.UI.IMouseInputSource defaultMouseInputSource { get; /* RVA: 0x093EA344 */ }
        Rewired.UI.ITouchInputSource defaultTouchInputSource { get; /* RVA: 0x093EA344 */ }
        System.Boolean isMouseSupported { get; /* RVA: 0x093EA34C */ }

        // Methods
        // RVA: 0x093E9578  token: 0x6000349
        protected System.Boolean IsDefaultMouse(Rewired.UI.IMouseInputSource mouse) { }
        // RVA: 0x093E85C4  token: 0x600034A
        public Rewired.UI.IMouseInputSource GetMouseInputSource(System.Int32 playerId, System.Int32 mouseIndex) { }
        // RVA: 0x093E9AC8  token: 0x600034B
        public System.Void RemoveMouseInputSource(Rewired.UI.IMouseInputSource source) { }
        // RVA: 0x093E7A64  token: 0x600034C
        public System.Void AddMouseInputSource(Rewired.UI.IMouseInputSource source) { }
        // RVA: 0x093E84AC  token: 0x600034D
        public System.Int32 GetMouseInputSourceCount(System.Int32 playerId) { }
        // RVA: 0x093E92B8  token: 0x600034E
        public Rewired.UI.ITouchInputSource GetTouchInputSource(System.Int32 playerId, System.Int32 sourceIndex) { }
        // RVA: 0x093E9C1C  token: 0x600034F
        public System.Void RemoveTouchInputSource(Rewired.UI.ITouchInputSource source) { }
        // RVA: 0x093E7B40  token: 0x6000350
        public System.Void AddTouchInputSource(Rewired.UI.ITouchInputSource source) { }
        // RVA: 0x093E9290  token: 0x6000351
        public System.Int32 GetTouchInputSourceCount(System.Int32 playerId) { }
        // RVA: 0x093E7C04  token: 0x6000352
        protected System.Void ClearMouseInputSources() { }
        // RVA: -1  // abstract  token: 0x6000354
        protected virtual System.Boolean IsDefaultPlayer(System.Int32 playerId) { }
        // RVA: 0x093E8F28  token: 0x6000355
        protected System.Boolean GetPointerData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, Rewired.Integration.UnityUI.PlayerPointerEventData& data, System.Boolean create, Rewired.Integration.UnityUI.PointerEventType pointerEventType) { }
        // RVA: 0x093E8080  token: 0x6000356
        private Rewired.Integration.UnityUI.PlayerPointerEventData CreatePointerEventData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, Rewired.Integration.UnityUI.PointerEventType pointerEventType) { }
        // RVA: 0x093E9B70  token: 0x6000357
        protected System.Void RemovePointerData(Rewired.Integration.UnityUI.PlayerPointerEventData data) { }
        // RVA: 0x093E932C  token: 0x6000358
        protected Rewired.Integration.UnityUI.PlayerPointerEventData GetTouchPointerEventData(System.Int32 playerId, System.Int32 touchDeviceIndex, UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released) { }
        // RVA: 0x093E875C  token: 0x6000359
        protected virtual Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseState GetMousePointerEventData(System.Int32 playerId, System.Int32 mouseIndex) { }
        // RVA: 0x093E8288  token: 0x600035A
        protected Rewired.Integration.UnityUI.PlayerPointerEventData GetLastPointerEventData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, System.Boolean ignorePointerTypeId, Rewired.Integration.UnityUI.PointerEventType pointerEventType) { }
        // RVA: 0x093E9C98  token: 0x600035B
        private static System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold) { }
        // RVA: 0x093E99E4  token: 0x600035C
        protected virtual System.Void ProcessMove(Rewired.Integration.UnityUI.PlayerPointerEventData pointerEvent) { }
        // RVA: 0x093E9784  token: 0x600035D
        protected virtual System.Void ProcessDrag(Rewired.Integration.UnityUI.PlayerPointerEventData pointerEvent) { }
        // RVA: 0x093E9594  token: 0x600035E
        public virtual System.Boolean IsPointerOverGameObject(System.Int32 pointerTypeId) { }
        // RVA: 0x093E7C4C  token: 0x600035F
        protected System.Void ClearSelection() { }
        // RVA: 0x093E9D44  token: 0x6000360
        public virtual System.String ToString() { }
        // RVA: 0x093E81BC  token: 0x6000361
        protected System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent) { }
        // RVA: 0x093E7FA4  token: 0x6000362
        protected System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to) { }
        // RVA: 0x093E9CD8  token: 0x6000363
        protected UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 playerId, System.Int32 mouseIndex, System.Int32 buttonId) { }
        // RVA: 0x093EA1D8  token: 0x6000364
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct PointerEventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Rewired.Integration.UnityUI.PointerEventType Mouse;  // const
        public static Rewired.Integration.UnityUI.PointerEventType Touch;  // const

    }

    // TypeToken: 0x2000034  // size: 0x108
    public sealed class RewiredStandaloneInputModule : Rewired.Integration.UnityUI.RewiredPointerInputModule
    {
        // Fields
        private static System.String DEFAULT_ACTION_MOVE_HORIZONTAL;  // const
        private static System.String DEFAULT_ACTION_MOVE_VERTICAL;  // const
        private static System.String DEFAULT_ACTION_SUBMIT;  // const
        private static System.String DEFAULT_ACTION_CANCEL;  // const
        private Rewired.InputManager_Base rewiredInputManager;  // 0x70
        private System.Boolean useAllRewiredGamePlayers;  // 0x78
        private System.Boolean useRewiredSystemPlayer;  // 0x79
        private System.Int32[] rewiredPlayerIds;  // 0x80
        private System.Boolean usePlayingPlayersOnly;  // 0x88
        private System.Collections.Generic.List<Rewired.Components.PlayerMouse> playerMice;  // 0x90
        private System.Boolean moveOneElementPerAxisPress;  // 0x98
        private System.Boolean setActionsById;  // 0x99
        private System.Int32 horizontalActionId;  // 0x9c
        private System.Int32 verticalActionId;  // 0xa0
        private System.Int32 submitActionId;  // 0xa4
        private System.Int32 cancelActionId;  // 0xa8
        private System.String m_HorizontalAxis;  // 0xb0
        private System.String m_VerticalAxis;  // 0xb8
        private System.String m_SubmitButton;  // 0xc0
        private System.String m_CancelButton;  // 0xc8
        private System.Single m_InputActionsPerSecond;  // 0xd0
        private System.Single m_RepeatDelay;  // 0xd4
        private System.Boolean m_allowMouseInput;  // 0xd8
        private System.Boolean m_allowMouseInputIfTouchSupported;  // 0xd9
        private System.Boolean m_allowTouchInput;  // 0xda
        private System.Boolean m_deselectIfBackgroundClicked;  // 0xdb
        private System.Boolean m_deselectBeforeSelecting;  // 0xdc
        private System.Boolean m_ForceModuleActive;  // 0xdd
        private System.Int32[] playerIds;  // 0xe0
        private System.Boolean recompiling;  // 0xe8
        private System.Boolean isTouchSupported;  // 0xe9
        private System.Double m_PrevActionTime;  // 0xf0
        private UnityEngine.Vector2 m_LastMoveVector;  // 0xf8
        private System.Int32 m_ConsecutiveMoveCount;  // 0x100
        private System.Boolean m_HasFocus;  // 0x104

        // Properties
        Rewired.InputManager_Base RewiredInputManager { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        System.Boolean UseAllRewiredGamePlayers { get; /* RVA: 0x03D4F800 */ set; /* RVA: 0x093EDBAC */ }
        System.Boolean UseRewiredSystemPlayer { get; /* RVA: 0x03D51AE0 */ set; /* RVA: 0x093EDBC8 */ }
        System.Int32[] RewiredPlayerIds { get; /* RVA: 0x093ED6F0 */ set; /* RVA: 0x093EDA18 */ }
        System.Boolean UsePlayingPlayersOnly { get; /* RVA: 0x03D51D50 */ set; /* RVA: 0x03D56D40 */ }
        System.Collections.Generic.List<Rewired.Components.PlayerMouse> PlayerMice { get; /* RVA: 0x093ED678 */ set; /* RVA: 0x093ED95C */ }
        System.Boolean MoveOneElementPerAxisPress { get; /* RVA: 0x03D58690 */ set; /* RVA: 0x03D5CE20 */ }
        System.Boolean allowMouseInput { get; /* RVA: 0x03D51180 */ set; /* RVA: 0x03D511E0 */ }
        System.Boolean allowMouseInputIfTouchSupported { get; /* RVA: 0x03D51160 */ set; /* RVA: 0x03D511C0 */ }
        System.Boolean allowTouchInput { get; /* RVA: 0x03D51170 */ set; /* RVA: 0x03D511D0 */ }
        System.Boolean deselectIfBackgroundClicked { get; /* RVA: 0x03D51190 */ set; /* RVA: 0x03D511F0 */ }
        System.Boolean deselectBeforeSelecting { get; /* RVA: 0x03D72330 */ set; /* RVA: 0x03D72350 */ }
        System.Boolean SetActionsById { get; /* RVA: 0x03D6E080 */ set; /* RVA: 0x093EDAA4 */ }
        System.Int32 HorizontalActionId { get; /* RVA: 0x03D51960 */ set; /* RVA: 0x093ED86C */ }
        System.Int32 VerticalActionId { get; /* RVA: 0x03D50E50 */ set; /* RVA: 0x093EDBE4 */ }
        System.Int32 SubmitActionId { get; /* RVA: 0x03D51870 */ set; /* RVA: 0x093EDABC */ }
        System.Int32 CancelActionId { get; /* RVA: 0x03D51860 */ set; /* RVA: 0x093ED77C */ }
        System.Boolean isMouseSupported { get; /* RVA: 0x093ED740 */ }
        System.Boolean isTouchAllowed { get; /* RVA: 0x03D51170 */ }
        System.Boolean allowActivationOnMobileDevice { get; /* RVA: 0x03D56760 */ set; /* RVA: 0x03D72340 */ }
        System.Boolean forceModuleActive { get; /* RVA: 0x03D56760 */ set; /* RVA: 0x03D72340 */ }
        System.Single inputActionsPerSecond { get; /* RVA: 0x03D57560 */ set; /* RVA: 0x03D57580 */ }
        System.Single repeatDelay { get; /* RVA: 0x03D57550 */ set; /* RVA: 0x03D57570 */ }
        System.String horizontalAxis { get; /* RVA: 0x03D4EAD0 */ set; /* RVA: 0x093EDD7C */ }
        System.String verticalAxis { get; /* RVA: 0x03D4E750 */ set; /* RVA: 0x093EDECC */ }
        System.String submitButton { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x093EDE24 */ }
        System.String cancelButton { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x093EDCD4 */ }

        // Methods
        // RVA: 0x093ED4E8  token: 0x60003B6
        private System.Void .ctor() { }
        // RVA: 0x093EA4B8  token: 0x60003B7
        protected virtual System.Void Awake() { }
        // RVA: 0x093ED480  token: 0x60003B8
        public virtual System.Void UpdateModule() { }
        // RVA: 0x0232EB60  token: 0x60003B9
        public virtual System.Boolean IsModuleSupported() { }
        // RVA: 0x093ED128  token: 0x60003BA
        public virtual System.Boolean ShouldActivateModule() { }
        // RVA: 0x093EA400  token: 0x60003BB
        public virtual System.Void ActivateModule() { }
        // RVA: 0x093EA7C4  token: 0x60003BC
        public virtual System.Void DeactivateModule() { }
        // RVA: 0x093EC3C0  token: 0x60003BD
        public virtual System.Void Process() { }
        // RVA: 0x093EBCB4  token: 0x60003BE
        private System.Boolean ProcessTouchEvents() { }
        // RVA: 0x093EBE18  token: 0x60003BF
        private System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released) { }
        // RVA: 0x093EC768  token: 0x60003C0
        private System.Boolean SendSubmitEventToSelectedObject() { }
        // RVA: 0x093EAB20  token: 0x60003C1
        private UnityEngine.Vector2 GetRawMoveVector() { }
        // RVA: 0x093EC4B0  token: 0x60003C2
        private System.Boolean SendMoveEventToSelectedObject() { }
        // RVA: 0x093EA5BC  token: 0x60003C3
        private System.Void CheckButtonOrKeyMovement(System.Boolean& downHorizontal, System.Boolean& downVertical) { }
        // RVA: 0x093EB624  token: 0x60003C4
        private System.Void ProcessMouseEvents() { }
        // RVA: 0x093EB370  token: 0x60003C5
        private System.Void ProcessMouseEvent(System.Int32 playerId, System.Int32 pointerIndex) { }
        // RVA: 0x093EC958  token: 0x60003C6
        private System.Boolean SendUpdateEventToSelectedObject() { }
        // RVA: 0x093EB764  token: 0x60003C7
        private System.Void ProcessMousePress(Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData data) { }
        // RVA: 0x093EADDC  token: 0x60003C8
        private System.Void HandleMouseTouchDeselectionOnSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent) { }
        // RVA: 0x03D72320  token: 0x60003C9
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        // RVA: 0x093ED418  token: 0x60003CA
        private System.Boolean ShouldIgnoreEventsOnNoFocus() { }
        // RVA: 0x093EB23C  token: 0x60003CB
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x093EB0E0  token: 0x60003CC
        protected virtual System.Boolean IsDefaultPlayer(System.Int32 playerId) { }
        // RVA: 0x093EAF48  token: 0x60003CD
        private System.Void InitializeRewired() { }
        // RVA: 0x093ECDC8  token: 0x60003CE
        private System.Void SetupRewiredVars() { }
        // RVA: 0x093ECCDC  token: 0x60003CF
        private System.Void SetUpRewiredPlayerMice() { }
        // RVA: 0x093ECA2C  token: 0x60003D0
        private System.Void SetUpRewiredActions() { }
        // RVA: 0x093EA964  token: 0x60003D1
        private System.Boolean GetButton(Rewired.Player player, System.Int32 actionId) { }
        // RVA: 0x093EA930  token: 0x60003D2
        private System.Boolean GetButtonDown(Rewired.Player player, System.Int32 actionId) { }
        // RVA: 0x093EAAEC  token: 0x60003D3
        private System.Boolean GetNegativeButton(Rewired.Player player, System.Int32 actionId) { }
        // RVA: 0x093EAAB8  token: 0x60003D4
        private System.Boolean GetNegativeButtonDown(Rewired.Player player, System.Int32 actionId) { }
        // RVA: 0x093EA8FC  token: 0x60003D5
        private System.Single GetAxis(Rewired.Player player, System.Int32 actionId) { }
        // RVA: 0x093EA728  token: 0x60003D6
        private System.Void CheckEditorRecompile() { }
        // RVA: 0x093EB350  token: 0x60003D7
        private System.Void OnEditorRecompile() { }
        // RVA: 0x093EA784  token: 0x60003D8
        private System.Void ClearRewiredVars() { }
        // RVA: 0x093EA7CC  token: 0x60003D9
        private System.Boolean DidAnyMouseMove() { }
        // RVA: 0x093EA998  token: 0x60003DA
        private System.Boolean GetMouseButtonDownOnAnyMouse(System.Int32 buttonIndex) { }
        // RVA: 0x093EB360  token: 0x60003DB
        private System.Void OnRewiredInitialized() { }
        // RVA: 0x093EB368  token: 0x60003DC
        private System.Void OnRewiredShutDown() { }

    }

}

namespace Rewired.Internal
{

    // TypeToken: 0x200002B  // size: 0x10
    public static class ControllerTemplateFactory
    {
        // Fields
        private static readonly System.Type[] _defaultTemplateTypes;  // static @ 0x0
        private static readonly System.Type[] _defaultTemplateInterfaceTypes;  // static @ 0x8

        // Properties
        System.Type[] templateTypes { get; /* RVA: 0x093E2984 */ }
        System.Type[] templateInterfaceTypes { get; /* RVA: 0x093E2934 */ }

        // Methods
        // RVA: 0x093E26F8  token: 0x6000332
        public static Rewired.IControllerTemplate Create(System.Guid typeGuid, System.Object payload) { }
        // RVA: 0x0384DD70  token: 0x6000333
        private static System.Void .cctor() { }

    }

}

namespace Rewired.Localization
{

    // TypeToken: 0x2000036  // size: 0x38
    public class LocalizedStringProvider : Rewired.Localization.LocalizedStringProviderBase
    {
        // Fields
        private UnityEngine.TextAsset _localizedStringsFile;  // 0x20
        private System.Collections.Generic.Dictionary<System.String,System.String> _dictionary;  // 0x28
        private System.Boolean _initialized;  // 0x30

        // Properties
        System.Collections.Generic.Dictionary<System.String,System.String> dictionary { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        UnityEngine.TextAsset localizedStringsFile { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x095F4660 */ }
        System.Boolean initialized { get; /* RVA: 0x03D4EF60 */ }

        // Methods
        // RVA: 0x095F43BC  token: 0x60003E5
        protected virtual System.Boolean Initialize() { }
        // RVA: 0x095F4454  token: 0x60003E6
        protected virtual System.Boolean TryLoadLocalizedStringData() { }
        // RVA: 0x095F43D8  token: 0x60003E7
        protected virtual System.Boolean TryGetLocalizedString(System.String key, System.String& result) { }
        // RVA: 0x095F45E0  token: 0x60003E8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x20
    public abstract class LocalizedStringProviderBase : UnityEngine.MonoBehaviour, Rewired.Interfaces.ILocalizedStringProvider
    {
        // Fields
        private System.Boolean _prefetch;  // 0x18

        // Properties
        System.Boolean prefetch { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x095F42E8 */ }
        System.Boolean initialized { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: 0x095F3FE4  token: 0x60003EC
        protected virtual System.Void OnEnable() { }
        // RVA: 0x095F3EF4  token: 0x60003ED
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0350B670  token: 0x60003EE
        protected virtual System.Void Update() { }
        // RVA: 0x095F4134  token: 0x60003EF
        protected virtual System.Void TrySetLocalizedStringProvider() { }
        // RVA: -1  // abstract  token: 0x60003F0
        protected virtual System.Boolean Initialize() { }
        // RVA: 0x095F401C  token: 0x60003F1
        public virtual System.Void Reload() { }
        // RVA: -1  // abstract  token: 0x60003F2
        protected virtual System.Boolean TryGetLocalizedString(System.String key, System.String& result) { }
        // RVA: 0x095F40E8  token: 0x60003F3
        private virtual System.Boolean Rewired.Interfaces.ILocalizedStringProvider.TryGetLocalizedString(System.String key, System.String& result) { }
        // RVA: 0x0426FE60  token: 0x60003F4
        protected System.Void .ctor() { }

    }

}

namespace Rewired.Utils
{

    // TypeToken: 0x200000F  // size: 0x28
    public class ExternalTools : Rewired.Utils.Interfaces.IExternalTools
    {
        // Fields
        private static System.Func<System.Object> _getPlatformInitializerDelegate;  // static @ 0x0
        private System.Boolean _isEditorPaused;  // 0x10
        private System.Action<System.Boolean> _EditorPausedStateChangedEvent;  // 0x18
        private System.Action<System.UInt32,System.Boolean> XboxOneInput_OnGamepadStateChange;  // 0x20

        // Properties
        System.Func<System.Object> getPlatformInitializerDelegate { get; /* RVA: 0x093E3390 */ set; /* RVA: 0x093E34C8 */ }
        System.Boolean isEditorPaused { get; /* RVA: 0x011797F0 */ }
        System.Boolean UnityInput_IsTouchPressureSupported { get; /* RVA: 0x093E3388 */ }

        // Events
        event System.Action<System.Boolean> EditorPausedStateChangedEvent;
        event System.Action<System.UInt32,System.Boolean> XboxOneInput_OnGamepadStateChange;

        // Methods
        // RVA: 0x0350B670  token: 0x6000211
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000212
        public virtual System.Void Destroy() { }
        // RVA: 0x04276AD8  token: 0x6000216
        public virtual System.Object GetPlatformInitializer() { }
        // RVA: 0x093E3150  token: 0x6000217
        public virtual System.String GetFocusedEditorWindowTitle() { }
        // RVA: 0x0115F4C0  token: 0x6000218
        public virtual System.Boolean IsEditorSceneViewFocused() { }
        // RVA: 0x0115F4C0  token: 0x6000219
        public virtual System.Boolean LinuxInput_IsJoystickPreconfigured(System.String name) { }
        // RVA: 0x01002730  token: 0x600021C
        public virtual System.Int32 XboxOneInput_GetUserIdForGamepad(System.UInt32 id) { }
        // RVA: 0x01002730  token: 0x600021D
        public virtual System.UInt64 XboxOneInput_GetControllerId(System.UInt32 unityJoystickId) { }
        // RVA: 0x0115F4C0  token: 0x600021E
        public virtual System.Boolean XboxOneInput_IsGamepadActive(System.UInt32 unityJoystickId) { }
        // RVA: 0x093E32C4  token: 0x600021F
        public virtual System.String XboxOneInput_GetControllerType(System.UInt64 xboxControllerId) { }
        // RVA: 0x01002730  token: 0x6000220
        public virtual System.UInt32 XboxOneInput_GetJoystickId(System.UInt64 xboxControllerId) { }
        // RVA: 0x0350B670  token: 0x6000221
        public virtual System.Void XboxOne_Gamepad_UpdatePlugin() { }
        // RVA: 0x0115F4C0  token: 0x6000222
        public virtual System.Boolean XboxOne_Gamepad_SetGamepadVibration(System.UInt64 xboxOneJoystickId, System.Single leftMotor, System.Single rightMotor, System.Single leftTriggerLevel, System.Single rightTriggerLevel) { }
        // RVA: 0x0350B670  token: 0x6000223
        public virtual System.Void XboxOne_Gamepad_PulseVibrateMotor(System.UInt64 xboxOneJoystickId, System.Int32 motorInt, System.Single startLevel, System.Single endLevel, System.UInt64 durationMS) { }
        // RVA: 0x093E30A0  token: 0x6000224
        public virtual System.Void GetDeviceVIDPIDs(System.Collections.Generic.List<System.Int32>& vids, System.Collections.Generic.List<System.Int32>& pids) { }
        // RVA: 0x03D5CD90  token: 0x6000225
        public virtual System.Int32 GetAndroidAPILevel() { }
        // RVA: 0x03269810  token: 0x6000226
        public virtual System.Void WindowsStandalone_ForwardRawInput(System.IntPtr rawInputHeaderIndices, System.IntPtr rawInputDataIndices, System.UInt32 indicesCount, System.IntPtr rawInputData, System.UInt32 rawInputDataSize) { }
        // RVA: 0x093E3188  token: 0x6000227
        public virtual System.Boolean UnityUI_Graphic_GetRaycastTarget(System.Object graphic) { }
        // RVA: 0x093E321C  token: 0x6000228
        public virtual System.Void UnityUI_Graphic_SetRaycastTarget(System.Object graphic, System.Boolean value) { }
        // RVA: 0x03D722F0  token: 0x600022A
        public virtual System.Single UnityInput_GetTouchPressure(UnityEngine.Touch& touch) { }
        // RVA: 0x03D722E0  token: 0x600022B
        public virtual System.Single UnityInput_GetTouchMaximumPossiblePressure(UnityEngine.Touch& touch) { }
        // RVA: 0x093E3044  token: 0x600022C
        public virtual Rewired.IControllerTemplate CreateControllerTemplate(System.Guid typeGuid, System.Object payload) { }
        // RVA: 0x02CA4470  token: 0x600022D
        public virtual System.Type[] GetControllerTemplateTypes() { }
        // RVA: 0x02CA4560  token: 0x600022E
        public virtual System.Type[] GetControllerTemplateInterfaceTypes() { }

    }

}

