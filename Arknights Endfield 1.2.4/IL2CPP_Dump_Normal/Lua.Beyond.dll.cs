// ========================================================
// Dumped by @desirepro
// Assembly: Lua.Beyond.dll
// Classes:  47
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000A  // size: 0x80
    public sealed class DispatchEventFunc : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02977ED0  token: 0x6000011
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000012
        public virtual System.Void Invoke(System.String eventName, XLua.LuaTable luaTable) { }
        // RVA: 0x04CB7664  token: 0x6000013
        public virtual System.IAsyncResult BeginInvoke(System.String eventName, XLua.LuaTable luaTable, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000014
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000B  // size: 0x20
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public Beyond.Lua.LuaEventSystem <>4__this;  // 0x10
        public System.String eventName;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000015
        public System.Void .ctor() { }
        // RVA: 0x0893F050  token: 0x6000016
        private System.Void <DispatchEvent>b__0() { }

    }

    // TypeToken: 0x200000C
    public sealed class <>c__DisplayClass10_0`1
    {
        // Fields
        public Beyond.Lua.LuaEventSystem <>4__this;  // 0x0
        public System.String eventName;  // 0x0
        public T arg;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000017
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000018
        private System.Void <DispatchEvent>b__0() { }

    }

    // TypeToken: 0x200000D
    public sealed class <>c__DisplayClass11_0`2
    {
        // Fields
        public Beyond.Lua.LuaEventSystem <>4__this;  // 0x0
        public System.String eventName;  // 0x0
        public T0 arg0;  // 0x0
        public T1 arg1;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000019
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600001A
        private System.Void <DispatchEvent>b__0() { }

    }

    // TypeToken: 0x200000E
    public sealed class <>c__DisplayClass12_0`3
    {
        // Fields
        public Beyond.Lua.LuaEventSystem <>4__this;  // 0x0
        public System.String eventName;  // 0x0
        public T0 arg0;  // 0x0
        public T1 arg1;  // 0x0
        public T2 arg2;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600001B
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600001C
        private System.Void <DispatchEvent>b__0() { }

    }

    // TypeToken: 0x200000F
    public sealed class <>c__DisplayClass13_0`4
    {
        // Fields
        public Beyond.Lua.LuaEventSystem <>4__this;  // 0x0
        public System.String eventName;  // 0x0
        public T0 arg0;  // 0x0
        public T1 arg1;  // 0x0
        public T2 arg2;  // 0x0
        public T3 arg3;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600001D
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600001E
        private System.Void <DispatchEvent>b__0() { }

    }

    // TypeToken: 0x2000010
    public sealed class <>c__DisplayClass14_0`5
    {
        // Fields
        public Beyond.Lua.LuaEventSystem <>4__this;  // 0x0
        public System.String eventName;  // 0x0
        public T0 arg0;  // 0x0
        public T1 arg1;  // 0x0
        public T2 arg2;  // 0x0
        public T3 arg3;  // 0x0
        public T4 arg4;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600001F
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000020
        private System.Void <DispatchEvent>b__0() { }

    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct ValueType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Lua.LuaCustomConfig.ValueType Bool;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Int;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Float;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType String;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Vector2;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Vector3;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Color;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Lua;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType GameObject;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType RectTransform;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType AnimationCurve;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType LayerMask;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Material;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Enum;  // const
        public static Beyond.Lua.LuaCustomConfig.ValueType Vector4;  // const

    }

    // TypeToken: 0x2000014  // size: 0xD8
    public class Item : Beyond.ILuaCallCSharp
    {
        // Fields
        public System.String name;  // 0x10
        public System.String description;  // 0x18
        public Beyond.Lua.LuaCustomConfig.ValueType valueType;  // 0x20
        public System.Boolean boolValue;  // 0x24
        public System.Int32 intValue;  // 0x28
        public System.Single floatValue;  // 0x2c
        public System.String stringValue;  // 0x30
        public UnityEngine.Vector2 vector2Value;  // 0x38
        public UnityEngine.Vector3 vector3Value;  // 0x40
        public UnityEngine.Vector4 vector4Value;  // 0x4c
        public UnityEngine.Color colorValue;  // 0x5c
        public System.String luaValue;  // 0x70
        public UnityEngine.GameObject gameObjectValue;  // 0x78
        public UnityEngine.RectTransform rectTransformValue;  // 0x80
        public UnityEngine.AnimationCurve curveValue;  // 0x88
        public UnityEngine.LayerMask layerMaskValue;  // 0x90
        public UnityEngine.Material material;  // 0x98
        public System.String enumTypeAQName;  // 0xa0
        public System.String enumTypeFullName;  // 0xa8
        public System.String enumAssemblyName;  // 0xb0
        public System.Int32 enumValue;  // 0xb8
        public System.String luaTableJson;  // 0xc0
        private System.String m_lastLuaValue;  // 0xc8
        private System.Type m_cachedEnumType;  // 0xd0

        // Methods
        // RVA: 0x08939CA8  token: 0x6000038
        public System.Boolean HasLuaValueChanged() { }
        // RVA: 0x08939D60  token: 0x6000039
        public System.Boolean ShouldSerializeLuaTableJson() { }
        // RVA: 0x08939D04  token: 0x600003A
        public System.Void MarkLuaValueProcessed() { }
        // RVA: 0x08939908  token: 0x600003B
        public System.Type GetEnumType() { }
        // RVA: 0x08939AF4  token: 0x600003C
        public System.Object GetEnumValueObject() { }
        // RVA: 0x030BFFE0  token: 0x600003D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x20
    public sealed class <>c__DisplayClass15_0
    {
        // Fields
        public System.Collections.Generic.List<System.Object> keys1;  // 0x10
        public System.Collections.Generic.List<System.Object> keys2;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600003E
        public System.Void .ctor() { }
        // RVA: 0x0893EDE0  token: 0x600003F
        private System.Void <_CompareLuaTables>b__0(System.Object k, System.Object _) { }
        // RVA: 0x0893EE34  token: 0x6000040
        private System.Void <_CompareLuaTables>b__1(System.Object k, System.Object _) { }

    }

    // TypeToken: 0x2000016  // size: 0x18
    public sealed class <>c__DisplayClass23_0
    {
        // Fields
        public Newtonsoft.Json.Linq.JObject jObject;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000041
        public System.Void .ctor() { }
        // RVA: 0x0893EE88  token: 0x6000042
        private System.Void <ConvertLuaTableToJson>b__0(System.Object key, System.Object value) { }

    }

    // TypeToken: 0x2000019  // size: 0x80
    public sealed class LuaHotFixInvoker : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x07D612E8  token: 0x6000048
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0102B410  token: 0x6000049
        public virtual System.Boolean Invoke(System.String luaCode) { }
        // RVA: 0x0389C3B0  token: 0x600004A
        public virtual System.IAsyncResult BeginInvoke(System.String luaCode, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD8EC  token: 0x600004B
        public virtual System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200001D  // size: 0x38
    public class TickEvent : Beyond.DisposedUnityEvent`1
    {
        // Methods
        // RVA: 0x0323A1B0  token: 0x600007F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x28
    public class ComponentRefDict : Beyond.SerializeReferenceDictionary`2
    {
        // Methods
        // RVA: 0x02815B80  token: 0x6000087
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000021  // size: 0x20
    public class CustomUIStyleInfo
    {
        // Fields
        public Beyond.UI.CustomUIStyle style;  // 0x10
        public UnityEngine.Component component;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000089
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x18
    public class RefExtraInfo
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Lua.LuaReference.RefExtraInfo.CustomUIStyleInfo> customUIStyles;  // 0x10

        // Methods
        // RVA: 0x037CA630  token: 0x6000088
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Lua.LuaReference.<>c <>9;  // static @ 0x0
        public static System.Predicate<Beyond.Lua.LuaReference> <>9__7_0;  // static @ 0x8

        // Methods
        // RVA: 0x0893F138  token: 0x600008A
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600008B
        public System.Void .ctor() { }
        // RVA: 0x0893ED94  token: 0x600008C
        private System.Boolean <Reset>b__7_0(Beyond.Lua.LuaReference item) { }

    }

    // TypeToken: 0x200002A  // size: 0x18
    public class ImageContentParam
    {
        // Fields
        public System.String path;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000F1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x20
    public sealed class <>c__DisplayClass33_0
    {
        // Fields
        public System.Single from;  // 0x10
        public XLua.LuaFunction setter;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000F2
        public System.Void .ctor() { }
        // RVA: 0x03D4E7A0  token: 0x60000F3
        private System.Single <TweenTo>b__0() { }
        // RVA: 0x0893EF8C  token: 0x60000F4
        private System.Void <TweenTo>b__1(System.Single value) { }

    }

namespace Beyond.Lua
{

    // TypeToken: 0x2000008  // size: 0x18
    public abstract class CsToLuaClass
    {
        // Fields
        protected XLua.LuaTable m_luaTable;  // 0x10

        // Methods
        // RVA: 0x08935D44  token: 0x6000007
        public System.Void .ctor(System.String luaPath) { }

    }

    // TypeToken: 0x2000009  // size: 0x48
    public class LuaEventSystem : Beyond.ILuaEventSystem, Beyond.ICommonCallLua, System.IDisposable
    {
        // Fields
        private Beyond.Lua.LuaEventSystem.DispatchEventFunc m_luaNotify;  // 0x10
        private System.IntPtr L;  // 0x18
        private XLua.ObjectTranslator m_translator;  // 0x20
        private System.IntPtr m_eventNameBytesPtr;  // 0x28
        private System.Byte[] m_eventNameBytes;  // 0x30
        private XLua.LuaEnv m_luaEnv;  // 0x38
        private System.Int32 csNotifyRef;  // 0x40

        // Methods
        // RVA: 0x0332F850  token: 0x6000008
        public System.Void .ctor() { }
        // RVA: 0x03488720  token: 0x6000009
        public virtual System.Void DispatchEvent(System.String eventName) { }
        // RVA: -1  // generic def  token: 0x600000A
        public virtual System.Void DispatchEvent(System.String eventName, T arg) { }
        // RVA: -1  // generic def  token: 0x600000B
        public virtual System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1) { }
        // RVA: -1  // generic def  token: 0x600000C
        public virtual System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2) { }
        // RVA: -1  // generic def  token: 0x600000D
        public virtual System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        // RVA: -1  // generic def  token: 0x600000E
        public virtual System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        // RVA: 0x025D44B0  token: 0x600000F
        public System.Void PushEventName(System.String eventName) { }
        // RVA: 0x0893C40C  token: 0x6000010
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x2000011  // size: 0x18
    public class CSharpCallLuaRegistration
    {
        // Fields
        private Beyond.Lua.LuaEventSystem m_luaEventSystem;  // 0x10

        // Methods
        // RVA: 0x0332FA60  token: 0x6000021
        public System.Void Init() { }
        // RVA: 0x08935CA4  token: 0x6000022
        public System.Void Dispose() { }
        // RVA: 0x0350B670  token: 0x6000023
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x28
    public class LuaCustomConfig : UnityEngine.MonoBehaviour, Beyond.ILuaCallCSharp, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Lua.LuaCustomConfig.Item> itemList;  // 0x18
        private System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> m_itemDict;  // 0x20

        // Properties
        System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> itemDict { get; /* RVA: 0x0893C228 */ }

        // Methods
        // RVA: 0x0356B820  token: 0x6000025
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: 0x034BB050  token: 0x6000026
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x0893BCBC  token: 0x6000027
        private System.Boolean _ProcessLuaTableItem(Beyond.Lua.LuaCustomConfig.Item item) { }
        // RVA: 0x0893A218  token: 0x6000028
        public System.Boolean ShouldProcessEnumItem(Beyond.Lua.LuaCustomConfig.Item item) { }
        // RVA: 0x0893BAE8  token: 0x6000029
        private System.Boolean _ProcessEnumItem(Beyond.Lua.LuaCustomConfig.Item item) { }
        // RVA: 0x0893BF38  token: 0x600002A
        private System.Boolean _ValidateLuaTableConsistency(System.String luaCode, System.String json) { }
        // RVA: 0x0893ACF0  token: 0x600002B
        private XLua.LuaTable _JsonToLuaTableForValidation(System.String json, XLua.LuaEnv luaEnv) { }
        // RVA: 0x0893AFE4  token: 0x600002C
        private System.Void _PopulateLuaTableFromJTokenForValidation(XLua.LuaTable luaTable, Newtonsoft.Json.Linq.JToken jToken, XLua.LuaEnv luaEnv) { }
        // RVA: 0x0893A86C  token: 0x600002D
        private System.Object _ConvertJValueToObjectForValidation(Newtonsoft.Json.Linq.JToken jValue) { }
        // RVA: 0x0893A2B8  token: 0x600002E
        private System.Boolean _CompareLuaTables(XLua.LuaTable table1, XLua.LuaTable table2) { }
        // RVA: 0x0893A724  token: 0x600002F
        private System.Boolean _CompareValues(System.Object value1, System.Object value2) { }
        // RVA: 0x0893AB64  token: 0x6000030
        private System.Boolean _IsNumericType(System.Object obj) { }
        // RVA: 0x031307E0  token: 0x6000031
        public System.Void InitConfigTable(XLua.LuaTable configTable) { }
        // RVA: 0x0893AE3C  token: 0x6000032
        private XLua.LuaTable _JsonToLuaTable(System.String json, XLua.LuaEnv luaEnv) { }
        // RVA: 0x0893B47C  token: 0x6000033
        private System.Void _PopulateLuaTableFromJToken(XLua.LuaTable luaTable, Newtonsoft.Json.Linq.JToken jToken) { }
        // RVA: 0x0893A9E4  token: 0x6000034
        private System.Object _ConvertJValueToObject(Newtonsoft.Json.Linq.JToken jValue) { }
        // RVA: 0x08939DD0  token: 0x6000035
        public static System.String ConvertLuaCodeToJson(System.String luaCode) { }
        // RVA: 0x0893A09C  token: 0x6000036
        public static System.String ConvertLuaTableToJson(XLua.LuaTable luaTable) { }
        // RVA: 0x03367F70  token: 0x6000037
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x18
    public class LuaDebugSocketManager : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x03C910C0  token: 0x6000043
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x10
    public static class LuaHotFix
    {
        // Methods
        // RVA: 0x0893C97C  token: 0x6000044
        public static System.Void LuaHotFixTest() { }
        // RVA: 0x0893C884  token: 0x6000045
        public static System.Boolean HotFixLua(System.String lua) { }
        // RVA: 0x0893C4A8  token: 0x6000046
        public static System.Boolean HotFixLua(System.Byte[] lua) { }
        // RVA: 0x0893C540  token: 0x6000047
        public static System.Boolean HotFixLua(System.Span<System.Byte> lua, System.Int32 length) { }

    }

    // TypeToken: 0x200001A  // size: 0x10
    public class LoadLuaProxy : XLua.ILoadLuaProxy
    {
        // Methods
        // RVA: 0x03CB42A0  token: 0x600004C
        private static System.Void _RunOnStart() { }
        // RVA: 0x02D3C020  token: 0x600004D
        public virtual System.Byte[] LoadLua(System.String name) { }
        // RVA: 0x0350B670  token: 0x600004E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x10
    public class LuaMethodPointerModule
    {
        // Methods
        // RVA: 0x03B2E3F0  token: 0x600004F
        private static System.Void _RunOnStart() { }
        // RVA: 0x0350B670  token: 0x6000050
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0xC0
    public class LuaManager : Beyond.BaseTickManager, Beyond.ILuaProxy
    {
        // Fields
        private static Beyond.Lua.LuaManager <instance>k__BackingField;  // static @ 0x0
        private static System.Single TICK_INTERVAL;  // const
        private readonly Beyond.Lua.CSharpCallLuaRegistration m_csCallLua;  // 0x70
        private Beyond.Gameplay.PeriodicTimer m_envTickTimer;  // 0x78
        public static System.Boolean s_xluaReflectionOpt;  // static @ 0x8
        private XLua.LuaEnv <luaEnv>k__BackingField;  // 0x80
        public System.Action<XLua.LuaTable,System.String,Beyond.Lua.LuaUIWidget> wrapUIWidgetFunction;  // 0x88
        public System.Action<XLua.LuaTable,System.String,Beyond.Lua.LuaReference> bindLuaRefFunction;  // 0x90
        private System.Boolean m_isQuittingApplication;  // 0x98
        public Beyond.Lua.LuaManager.TickEvent actionTick;  // 0xa0
        public Beyond.Lua.LuaManager.TickEvent actionLateTick;  // 0xa8
        public Beyond.Lua.LuaManager.TickEvent actionTailTick;  // 0xb0
        public Beyond.Lua.LuaManager.TickEvent actionRenderDone;  // 0xb8

        // Properties
        Beyond.Lua.LuaManager instance { get; /* RVA: 0x03D2E220 */ set; /* RVA: 0x0893D4B4 */ }
        XLua.LuaEnv luaEnv { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }
        System.Boolean isQuittingApplication { get; /* RVA: 0x03D58690 */ set; /* RVA: 0x0893D510 */ }
        Beyond.FrameTickGroup frameTickGroup { get; /* RVA: 0x03D51110 */ }

        // Methods
        // RVA: 0x03103810  token: 0x6000053
        public static System.Void CreateInstance() { }
        // RVA: 0x03103590  token: 0x6000054
        public static System.Void DestroyInstance() { }
        // RVA: 0x0323A020  token: 0x6000055
        public System.Void .ctor() { }
        // RVA: 0x029A6AC0  token: 0x6000058
        public static System.Boolean IsEnableMultithreadGC() { }
        // RVA: 0x025D4CC0  token: 0x6000059
        public static System.Boolean IsLuaGCing() { }
        // RVA: 0x0332FF70  token: 0x600005A
        protected virtual System.Void OnInit() { }
        // RVA: 0x0893CB5C  token: 0x600005B
        public static System.String GetLuaStack() { }
        // RVA: 0x03B2E660  token: 0x600005C
        protected virtual System.Void OnRelease() { }
        // RVA: 0x0893CF14  token: 0x600005D
        public static System.Void ReStartLuaProfiler() { }
        // RVA: 0x0893D2F0  token: 0x6000060
        private System.Void _ReleaseDelegateInAnotherStackFrame() { }
        // RVA: 0x02BE1ED0  token: 0x6000061
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x02BE3470  token: 0x6000062
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x02BE3640  token: 0x6000063
        public virtual System.Void TailLateTick(System.Single deltaTime) { }
        // RVA: 0x0893CAD8  token: 0x6000064
        public System.String GetLuaFileRealPath(System.String modulePath) { }
        // RVA: 0x02BE1BD0  token: 0x6000065
        public System.Boolean IsLuaFileExist(System.String modulePath) { }
        // RVA: 0x0893CD20  token: 0x6000066
        public System.Int64 LoadLuaByteByFileRealPath(System.String modulePath, System.Int32& len) { }
        // RVA: 0x02BE1420  token: 0x6000067
        public System.Byte[] LoadLua(System.String modulePath) { }
        // RVA: 0x0893CDE8  token: 0x6000068
        public System.IntPtr LoadLuaBytePtr(System.String modulePath) { }
        // RVA: 0x039C53F0  token: 0x6000069
        public System.Byte[] LoadLuaBytes(System.String& modulePath) { }
        // RVA: 0x0332FD40  token: 0x600006A
        private System.Void _RegisterCSharpCallLua() { }
        // RVA: 0x02D3CA10  token: 0x600006B
        private static System.Void _Register3rdPartyLibraries(XLua.LuaEnv env) { }
        // RVA: 0x0893D018  token: 0x600006C
        private static System.Void _HyperLuaLogCallback(System.IntPtr L, System.Int32 level, System.String text) { }
        // RVA: 0x0893D104  token: 0x600006D
        private static System.Void _LuaUtilsLogCallback(System.Int32 level, System.String text) { }
        // RVA: 0x0893D194  token: 0x600006E
        private System.Void _OnEnvLangChanged(Beyond.GEnums.EnvLang lang) { }
        // RVA: 0x0893CA40  token: 0x600006F
        public virtual System.Object[] DoString(System.String code) { }
        // RVA: 0x032CFAF0  token: 0x6000070
        public virtual System.IntPtr GetLuaState() { }
        // RVA: 0x030CDB70  token: 0x6000071
        public virtual System.Void ClearAllUnityObjectUserdata() { }
        // RVA: 0x0893D268  token: 0x6000072
        private System.Void _OnRenderDone(HG.Rendering.Runtime.HGRenderPipeCallbackArgs args) { }
        // RVA: 0x02BE3990  token: 0x6000073
        private System.Void _OnRenderDone() { }
        // RVA: 0x0332FEA0  token: 0x6000074
        public System.Boolean AddLuaEventAfterGCDo(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x0893CF54  token: 0x6000075
        public static System.Void RemoveLuaEventAfterGCDo(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x0893C9BC  token: 0x6000076
        public System.Void AddOnceLuaEventAfterGCDo(UnityEngine.Events.UnityAction action) { }
        // RVA: 0x03058750  token: 0x6000077
        public static System.Int32 LuaCalculateABPathHash(System.IntPtr L) { }
        // RVA: 0x024D6F00  token: 0x6000078
        public static System.Void CasterStringPathHash(System.IntPtr L, System.Int32 index, Beyond.Resource.StringPathHash& o) { }
        // RVA: 0x024D8180  token: 0x6000079
        public static System.Boolean CheckStringPathHash(System.IntPtr L, System.Int32 index) { }
        // RVA: 0x03D44320  token: 0x600007B
        private static System.Void .cctor() { }
        // RVA: 0x0589C8E8  token: 0x600007C
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0589C8C0  token: 0x600007D
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x0589C8E0  token: 0x600007E
        public System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x200001E  // size: 0x40
    public class LuaReference : UnityEngine.MonoBehaviour, Beyond.ILuaCallCSharp
    {
        // Fields
        public Beyond.Lua.LuaReference.ComponentRefDict refDict;  // 0x18
        public Beyond.SerializeReferenceDictionary<System.String,Beyond.Lua.LuaReference.RefExtraInfo> refExtraInfoDict;  // 0x20
        public System.Boolean isRootRef;  // 0x28
        public System.Collections.Generic.List<Beyond.Lua.LuaReference> subReferences;  // 0x30
        private XLua.LuaTable m_table;  // 0x38

        // Methods
        // RVA: 0x0893DA7C  token: 0x6000080
        private System.Void Reset() { }
        // RVA: 0x0260DFA0  token: 0x6000081
        private System.Void OnDestroy() { }
        // RVA: 0x0260CEA0  token: 0x6000082
        private System.Void _UnBindFromXluaRef() { }
        // RVA: 0x0260B090  token: 0x6000083
        public System.Void BindToLua(XLua.LuaTable table) { }
        // RVA: 0x0260BC50  token: 0x6000084
        private System.Void _BindSelfReferences(XLua.LuaTable table) { }
        // RVA: 0x0893D598  token: 0x6000085
        public System.Boolean ContainsGameObject(UnityEngine.GameObject obj, System.Boolean recursive) { }
        // RVA: 0x02815690  token: 0x6000086
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x48
    public sealed struct LuaTestReflectionOptStruct
    {
        // Fields
        public System.Int32 a;  // 0x10
        public System.String b;  // 0x18
        public System.Int64 l;  // 0x20
        public System.UInt64 ul;  // 0x28
        public System.Single f;  // 0x30
        public System.Double d;  // 0x38
        public System.Boolean bl;  // 0x40

        // Properties
        System.Int32 a1 { get; /* RVA: 0x03D4E980 */ }
        System.String b1 { get; /* RVA: 0x03D50DE0 */ }
        System.Int64 l1 { get; /* RVA: 0x020B7B20 */ }
        System.UInt64 ul1 { get; /* RVA: 0x01041090 */ }
        System.Single f1 { get; /* RVA: 0x03D4F2E0 */ }
        System.Double d1 { get; /* RVA: 0x03D4F5B0 */ }
        System.Boolean bl1 { get; /* RVA: 0x03D4EF60 */ }

        // Methods
        // RVA: 0x0893E718  token: 0x6000094
        public System.Void .ctor(System.Int32 a, System.String b, System.Int64 l, System.UInt64 ul, System.Single f, System.Double d, System.Boolean bl) { }
        // RVA: 0x0893E4F8  token: 0x6000095
        public System.Int32 TestInt(System.Int32 a) { }
        // RVA: 0x0893E6D8  token: 0x6000096
        public System.Void TestVoid() { }
        // RVA: 0x0893E660  token: 0x6000097
        public System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct) { }
        // RVA: 0x0893E610  token: 0x6000098
        public System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct) { }
        // RVA: 0x0893E59C  token: 0x6000099
        public System.Object TestReturnObj() { }
        // RVA: 0x0893E54C  token: 0x600009A
        public System.Void TestObjParam(System.Object obj) { }

    }

    // TypeToken: 0x2000024  // size: 0x48
    public sealed struct LuaTestReflectionOptStruct2
    {
        // Fields
        public System.Int32 a;  // 0x10
        public System.String b;  // 0x18
        public System.Int64 l;  // 0x20
        public System.UInt64 ul;  // 0x28
        public System.Single f;  // 0x30
        public System.Double d;  // 0x38
        public System.Boolean bl;  // 0x40

        // Properties
        System.Int32 a1 { get; /* RVA: 0x03D4E980 */ }
        System.String b1 { get; /* RVA: 0x03D50DE0 */ }
        System.Int64 l1 { get; /* RVA: 0x020B7B20 */ }
        System.UInt64 ul1 { get; /* RVA: 0x01041090 */ }
        System.Single f1 { get; /* RVA: 0x03D4F2E0 */ }
        System.Double d1 { get; /* RVA: 0x03D4F5B0 */ }
        System.Boolean bl1 { get; /* RVA: 0x03D4EF60 */ }

        // Methods
        // RVA: 0x0893E2D8  token: 0x60000A2
        public System.Int32 TestInt(System.Int32 a) { }
        // RVA: 0x0893E4B8  token: 0x60000A3
        public System.Void TestVoid() { }
        // RVA: 0x0893E440  token: 0x60000A4
        public System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct) { }
        // RVA: 0x0893E3F0  token: 0x60000A5
        public System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct2& testStruct) { }
        // RVA: 0x0893E37C  token: 0x60000A6
        public System.Object TestReturnObj() { }
        // RVA: 0x0893E32C  token: 0x60000A7
        public System.Void TestObjParam(System.Object obj) { }

    }

    // TypeToken: 0x2000025  // size: 0x14
    public sealed struct ETestEnum
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Lua.ETestEnum Test1;  // const
        public static Beyond.Lua.ETestEnum Test2;  // const

    }

    // TypeToken: 0x2000026  // size: 0x20
    public class LuaTestReflectionOpt2
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> TestList;  // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,System.String> TestDict;  // 0x18

        // Methods
        // RVA: 0x0893E10C  token: 0x60000A8
        public System.Void TestVoid() { }
        // RVA: 0x0893DD60  token: 0x60000A9
        public System.Int32 TestInt(System.Int32 a) { }
        // RVA: 0x0893DF8C  token: 0x60000AA
        public System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct) { }
        // RVA: 0x0893DF14  token: 0x60000AB
        public System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct) { }
        // RVA: 0x0893DEC4  token: 0x60000AC
        public System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct) { }
        // RVA: 0x0893DE50  token: 0x60000AD
        public System.Object TestReturnObj() { }
        // RVA: 0x0893DDB4  token: 0x60000AE
        public System.Void TestObjParam(System.Object obj) { }
        // RVA: 0x0893DD10  token: 0x60000AF
        public System.Void TestEnum(Beyond.Lua.ETestEnum e) { }
        // RVA: 0x0893DE04  token: 0x60000B0
        public Beyond.Lua.ETestEnum TestReturnEnum() { }
        // RVA: 0x0893E004  token: 0x60000B1
        public Beyond.Lua.LuaTestReflectionOptStruct TestStruct(Beyond.Lua.LuaTestReflectionOptStruct a) { }
        // RVA: 0x0893E14C  token: 0x60000B2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x20
    public class LuaTestReflectionOpt
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> TestList;  // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,System.String> TestDict;  // 0x18

        // Methods
        // RVA: 0x0893EB5C  token: 0x60000B3
        public System.Void TestVoid() { }
        // RVA: 0x0893E7B0  token: 0x60000B4
        public System.Int32 TestInt(System.Int32 a) { }
        // RVA: 0x0893E9DC  token: 0x60000B5
        public System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct) { }
        // RVA: 0x0893E964  token: 0x60000B6
        public System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct) { }
        // RVA: 0x0893E914  token: 0x60000B7
        public System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct) { }
        // RVA: 0x0893E8A0  token: 0x60000B8
        public System.Object TestReturnObj() { }
        // RVA: 0x0893E804  token: 0x60000B9
        public System.Void TestObjParam(System.Object obj) { }
        // RVA: 0x0893E760  token: 0x60000BA
        public System.Void TestEnum(Beyond.Lua.ETestEnum e) { }
        // RVA: 0x0893E854  token: 0x60000BB
        public Beyond.Lua.ETestEnum TestReturnEnum() { }
        // RVA: 0x0893EA54  token: 0x60000BC
        public Beyond.Lua.LuaTestReflectionOptStruct TestStruct(Beyond.Lua.LuaTestReflectionOptStruct a) { }
        // RVA: 0x0893EB9C  token: 0x60000BD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000028  // size: 0x48
    public class LuaUIWidget : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public System.String id;  // 0x18
        public System.Boolean isEmbeddedWidget;  // 0x20
        private XLua.LuaTable <table>k__BackingField;  // 0x28
        public XLua.LuaFunction onEnable;  // 0x30
        public XLua.LuaFunction onDisable;  // 0x38
        public XLua.LuaFunction onDestroy;  // 0x40

        // Properties
        XLua.LuaTable table { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x03743D60 */ }

        // Methods
        // RVA: 0x0893ED28  token: 0x60000C0
        private System.Void Reset() { }
        // RVA: 0x025E5070  token: 0x60000C1
        private System.Void OnEnable() { }
        // RVA: 0x025E4FD0  token: 0x60000C2
        private System.Void OnDisable() { }
        // RVA: 0x03561EE0  token: 0x60000C3
        private System.Void OnDestroy() { }
        // RVA: 0x0260E090  token: 0x60000C4
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x60000C5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x10
    public static class UtilsForLua
    {
        // Fields
        private static UnityEngine.Vector3[] s_worldCorners;  // static @ 0x0

        // Methods
        // RVA: 0x03B742E0  token: 0x60000C6
        public static UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset) { }
        // RVA: 0x02874B30  token: 0x60000C7
        public static UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset, UnityEngine.Transform parent) { }
        // RVA: 0x02874A90  token: 0x60000C8
        public static UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset, UnityEngine.GameObject parent) { }
        // RVA: 0x08940890  token: 0x60000C9
        public static System.Void UIContainerResize(UnityEngine.Transform container, System.Int32 size, System.Int32 templateIndex) { }
        // RVA: 0x0894063C  token: 0x60000CA
        public static System.Int32 TurnOffLayer(System.Int32 value, System.String layerName) { }
        // RVA: 0x089406A0  token: 0x60000CB
        public static System.Int32 TurnOnLayer(System.Int32 value, System.String layerName) { }
        // RVA: 0x089404CC  token: 0x60000CC
        public static System.Int32 ToggleLayer(System.Int32 value, System.String layerName) { }
        // RVA: 0x0893FE4C  token: 0x60000CD
        public static System.Void SetPosX(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x0893FEEC  token: 0x60000CE
        public static System.Void SetPosY(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x0893FF8C  token: 0x60000CF
        public static System.Void SetPosZ(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x08940020  token: 0x60000D0
        public static System.Void SetRotX(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x089400C0  token: 0x60000D1
        public static System.Void SetRotY(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x08940160  token: 0x60000D2
        public static System.Void SetRotZ(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x089401F4  token: 0x60000D3
        public static System.Void SetScaleX(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x08940294  token: 0x60000D4
        public static System.Void SetScaleY(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x08940334  token: 0x60000D5
        public static System.Void SetScaleZ(UnityEngine.Transform t, System.Single value) { }
        // RVA: 0x02AE9FF0  token: 0x60000D6
        public static System.Void ClearUIComponents(UnityEngine.GameObject gameObject) { }
        // RVA: 0x0893FB28  token: 0x60000D7
        public static System.Boolean RayCast(UnityEngine.RaycastHit& hitInfo, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction interaction) { }
        // RVA: 0x0893FC24  token: 0x60000D8
        public static System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction interaction) { }
        // RVA: 0x02B37BD0  token: 0x60000D9
        public static UnityEngine.Bounds GetRectTransformBounds(UnityEngine.RectTransform transform) { }
        // RVA: 0x0893FD20  token: 0x60000DA
        public static UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        // RVA: 0x0893F680  token: 0x60000DB
        public static UnityEngine.Vector3 GetRectTransformCenterPosition(UnityEngine.RectTransform rectTransform) { }
        // RVA: 0x0893F19C  token: 0x60000DC
        public static UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local) { }
        // RVA: 0x0893F818  token: 0x60000DD
        public static System.Collections.Generic.List<System.String> GetStringList() { }
        // RVA: 0x0893F7B4  token: 0x60000DE
        public static System.Int32 GetStringHash(System.String str) { }
        // RVA: 0x0893F254  token: 0x60000DF
        public static System.Single EntityDistance(Beyond.Gameplay.Core.Entity a, Beyond.Gameplay.Core.Entity b) { }
        // RVA: 0x0893F8A8  token: 0x60000E0
        public static System.Void OpenAccountCenter() { }
        // RVA: 0x0893F310  token: 0x60000E1
        public static System.Void ExitGame() { }
        // RVA: 0x0893F560  token: 0x60000E2
        public static System.String GetCurrentUID() { }
        // RVA: 0x089403C8  token: 0x60000E3
        public static System.Boolean StartPayment(System.String productId, System.String signParams) { }
        // RVA: 0x089405A4  token: 0x60000E4
        public static System.Boolean TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, HG.Rendering.Runtime.HGCharacterVolume& hgCharacterVolume) { }
        // RVA: 0x0893F38C  token: 0x60000E5
        public static System.Single GetAnimationCurveLength(UnityEngine.AnimationCurve curve) { }
        // RVA: 0x08940704  token: 0x60000E6
        public static DG.Tweening.Tweener TweenTo(System.Single from, System.Single to, System.Single duration, XLua.LuaFunction setter) { }
        // RVA: 0x0333FE20  token: 0x60000E7
        public static System.Boolean IsNull(UnityEngine.Object o) { }
        // RVA: 0x0893F914  token: 0x60000E8
        public static Beyond.Lua.UtilsForLua.ImageContentParam ParseImageContent(System.String xml) { }
        // RVA: 0x0893FDD0  token: 0x60000E9
        public static System.Void ReturnToLogin() { }
        // RVA: 0x0893FAD8  token: 0x60000EA
        public static System.Void QuitGame(System.Int32 exitCode) { }
        // RVA: 0x08940458  token: 0x60000EB
        public static System.Void ToggleCharInfoInUpgradePanelOption(System.Boolean isIn) { }
        // RVA: 0x08940530  token: 0x60000EC
        public static System.Void ToggleWeaponInUpgradePanelOption(System.Boolean isIn) { }
        // RVA: 0x0893F4B4  token: 0x60000ED
        public static Cinemachine.CinemachineTransposer GetCinemachineTransposer(Cinemachine.CinemachineVirtualCamera vcam) { }
        // RVA: 0x0893F408  token: 0x60000EE
        public static Cinemachine.CinemachineComposer GetCinemachineComposer(Cinemachine.CinemachineVirtualCamera vcam) { }
        // RVA: 0x0893F5E4  token: 0x60000EF
        public static CinemachineCameraOffset GetOrAddCinemachineCameraOffset(Cinemachine.CinemachineVirtualCamera vcam) { }
        // RVA: 0x03D43270  token: 0x60000F0
        private static System.Void .cctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000003
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000005
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000006
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

    // TypeToken: 0x200002C  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x60000F5
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x05163BA0  token: 0x60000F6
        public System.Void __Gen_Wrap_0(System.Object P0, System.Object P1) { }
        // RVA: 0x0514F380  token: 0x60000F7
        public System.Boolean __Gen_Wrap_1() { }
        // RVA: 0x050F3444  token: 0x60000F8
        public System.Void __Gen_Wrap_2() { }
        // RVA: 0x04274234  token: 0x60000F9
        public System.Void __Gen_Wrap_3(System.Object P0) { }
        // RVA: 0x08938060  token: 0x60000FA
        public System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> __Gen_Wrap_4(System.Object P0) { }
        // RVA: 0x089389F0  token: 0x60000FB
        public System.String __Gen_Wrap_5(System.Object P0) { }
        // RVA: 0x089391A0  token: 0x60000FC
        public System.Object __Gen_Wrap_6(System.Object P0, System.Object P1) { }
        // RVA: 0x05160E44  token: 0x60000FD
        public System.Void __Gen_Wrap_7(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x0893974C  token: 0x60000FE
        public XLua.LuaTable __Gen_Wrap_8(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x05153920  token: 0x60000FF
        public System.Boolean __Gen_Wrap_9(System.Object P0, System.Object P1) { }
        // RVA: 0x05488110  token: 0x6000100
        public System.Boolean __Gen_Wrap_10(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x05150B1C  token: 0x6000101
        public System.Void __Gen_Wrap_11(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x08935E1C  token: 0x6000102
        public System.Type __Gen_Wrap_12(System.Object P0) { }
        // RVA: 0x08935F0C  token: 0x6000103
        public System.Object __Gen_Wrap_13(System.Object P0) { }
        // RVA: 0x0514EF5C  token: 0x6000104
        public System.Boolean __Gen_Wrap_14(System.Object P0) { }
        // RVA: 0x08935FFC  token: 0x6000105
        public System.Boolean __Gen_Wrap_15(System.Span<System.Byte> P0, System.Int32 P1) { }
        // RVA: 0x0893611C  token: 0x6000106
        public System.Byte[] __Gen_Wrap_16(System.Object P0, System.Object P1) { }
        // RVA: 0x08936228  token: 0x6000107
        public System.Void __Gen_Wrap_17(System.Object P0, HG.Rendering.Runtime.HGRenderPipeCallbackArgs P1) { }
        // RVA: 0x08936328  token: 0x6000108
        public System.String __Gen_Wrap_18() { }
        // RVA: 0x089363E0  token: 0x6000109
        public System.Void __Gen_Wrap_19(System.IntPtr P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x050F1370  token: 0x600010A
        public System.Void __Gen_Wrap_20(System.Int32 P0, System.Object P1) { }
        // RVA: 0x089364C4  token: 0x600010B
        public System.Byte[] __Gen_Wrap_21(System.Object P0, System.String& P1) { }
        // RVA: 0x055FFD60  token: 0x600010C
        public System.Void __Gen_Wrap_22(System.Object P0, Beyond.GEnums.EnvLang P1) { }
        // RVA: 0x05152658  token: 0x600010D
        public System.Int32 __Gen_Wrap_23(System.IntPtr P0) { }
        // RVA: 0x089365FC  token: 0x600010E
        public System.Void __Gen_Wrap_24(System.IntPtr P0, System.Int32 P1, Beyond.Resource.StringPathHash& P2) { }
        // RVA: 0x08936734  token: 0x600010F
        public System.Boolean __Gen_Wrap_25(System.IntPtr P0, System.Int32 P1) { }
        // RVA: 0x050F0448  token: 0x6000110
        public System.Void __Gen_Wrap_26(System.Object P0, System.Boolean P1) { }
        // RVA: 0x050F0008  token: 0x6000111
        public System.Void __Gen_Wrap_27(System.Object P0, System.Single P1) { }
        // RVA: 0x08936820  token: 0x6000112
        public System.String __Gen_Wrap_28(System.Object P0, System.Object P1) { }
        // RVA: 0x08936918  token: 0x6000113
        public System.Int64 __Gen_Wrap_29(System.Object P0, System.Object P1, System.Int32& P2) { }
        // RVA: 0x0870040C  token: 0x6000114
        public System.IntPtr __Gen_Wrap_30(System.Object P0, System.Object P1) { }
        // RVA: 0x08936A30  token: 0x6000115
        public System.Object[] __Gen_Wrap_31(System.Object P0, System.Object P1) { }
        // RVA: 0x0516CA20  token: 0x6000116
        public System.IntPtr __Gen_Wrap_32(System.Object P0) { }
        // RVA: 0x050EF298  token: 0x6000117
        public System.Boolean __Gen_Wrap_33(Beyond.Lua.LuaReference P0) { }
        // RVA: 0x0561AEBC  token: 0x6000118
        public System.Boolean __Gen_Wrap_34(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x08936B28  token: 0x6000119
        public System.Int32 __Gen_Wrap_35(Beyond.Lua.LuaTestReflectionOptStruct& P0, System.Int32 P1) { }
        // RVA: 0x08936CB0  token: 0x600011A
        public System.Void __Gen_Wrap_36(Beyond.Lua.LuaTestReflectionOptStruct& P0) { }
        // RVA: 0x08936E0C  token: 0x600011B
        public System.Void __Gen_Wrap_37(Beyond.Lua.LuaTestReflectionOptStruct& P0, Beyond.Lua.LuaTestReflectionOptStruct P1) { }
        // RVA: 0x08936FB4  token: 0x600011C
        public System.Void __Gen_Wrap_38(Beyond.Lua.LuaTestReflectionOptStruct& P0, Beyond.Lua.LuaTestReflectionOptStruct& P1) { }
        // RVA: 0x089371B0  token: 0x600011D
        public System.Object __Gen_Wrap_39(Beyond.Lua.LuaTestReflectionOptStruct& P0) { }
        // RVA: 0x08937330  token: 0x600011E
        public System.Void __Gen_Wrap_40(Beyond.Lua.LuaTestReflectionOptStruct& P0, System.Object P1) { }
        // RVA: 0x089374A8  token: 0x600011F
        public System.Int32 __Gen_Wrap_41(Beyond.Lua.LuaTestReflectionOptStruct2& P0, System.Int32 P1) { }
        // RVA: 0x08937630  token: 0x6000120
        public System.Void __Gen_Wrap_42(Beyond.Lua.LuaTestReflectionOptStruct2& P0) { }
        // RVA: 0x0893778C  token: 0x6000121
        public System.Void __Gen_Wrap_43(Beyond.Lua.LuaTestReflectionOptStruct2& P0, Beyond.Lua.LuaTestReflectionOptStruct2 P1) { }
        // RVA: 0x08937934  token: 0x6000122
        public System.Void __Gen_Wrap_44(Beyond.Lua.LuaTestReflectionOptStruct2& P0, Beyond.Lua.LuaTestReflectionOptStruct2& P1) { }
        // RVA: 0x08937B30  token: 0x6000123
        public System.Object __Gen_Wrap_45(Beyond.Lua.LuaTestReflectionOptStruct2& P0) { }
        // RVA: 0x08937CB0  token: 0x6000124
        public System.Void __Gen_Wrap_46(Beyond.Lua.LuaTestReflectionOptStruct2& P0, System.Object P1) { }
        // RVA: 0x05613324  token: 0x6000125
        public System.Int32 __Gen_Wrap_47(System.Object P0, System.Int32 P1) { }
        // RVA: 0x08937E28  token: 0x6000126
        public System.Void __Gen_Wrap_48(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct P1) { }
        // RVA: 0x08937F44  token: 0x6000127
        public System.Void __Gen_Wrap_49(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct2 P1) { }
        // RVA: 0x0893813C  token: 0x6000128
        public System.Void __Gen_Wrap_50(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct& P1) { }
        // RVA: 0x055FFD60  token: 0x6000129
        public System.Void __Gen_Wrap_51(System.Object P0, Beyond.Lua.ETestEnum P1) { }
        // RVA: 0x05477F10  token: 0x600012A
        public Beyond.Lua.ETestEnum __Gen_Wrap_52(System.Object P0) { }
        // RVA: 0x089382B4  token: 0x600012B
        public Beyond.Lua.LuaTestReflectionOptStruct __Gen_Wrap_53(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct P1) { }
        // RVA: 0x08938420  token: 0x600012C
        public UnityEngine.GameObject __Gen_Wrap_54(System.Object P0) { }
        // RVA: 0x08938510  token: 0x600012D
        public UnityEngine.GameObject __Gen_Wrap_55(System.Object P0, System.Object P1) { }
        // RVA: 0x087040F0  token: 0x600012E
        public System.Void __Gen_Wrap_56(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x0893861C  token: 0x600012F
        public System.Int32 __Gen_Wrap_57(System.Int32 P0, System.Object P1) { }
        // RVA: 0x089386F4  token: 0x6000130
        public System.Boolean __Gen_Wrap_58(UnityEngine.RaycastHit& P0, UnityEngine.Ray P1, System.Single P2, System.Int32 P3, UnityEngine.QueryTriggerInteraction P4) { }
        // RVA: 0x0893889C  token: 0x6000131
        public System.Int32 __Gen_Wrap_59(UnityEngine.Ray P0, System.Object P1, System.Single P2, System.Int32 P3, UnityEngine.QueryTriggerInteraction P4) { }
        // RVA: 0x08938ACC  token: 0x6000132
        public UnityEngine.Bounds __Gen_Wrap_60(System.Object P0) { }
        // RVA: 0x08938BD0  token: 0x6000133
        public UnityEngine.Rect __Gen_Wrap_61(System.Object P0, System.Object P1) { }
        // RVA: 0x08938CE8  token: 0x6000134
        public UnityEngine.Vector3 __Gen_Wrap_62(System.Object P0) { }
        // RVA: 0x08938DE8  token: 0x6000135
        public UnityEngine.Bounds __Gen_Wrap_63(System.Object P0, System.Object P1) { }
        // RVA: 0x08938F08  token: 0x6000136
        public System.Collections.Generic.List<System.String> __Gen_Wrap_64() { }
        // RVA: 0x05477F10  token: 0x6000137
        public System.Int32 __Gen_Wrap_65(System.Object P0) { }
        // RVA: 0x0870A4D8  token: 0x6000138
        public System.Single __Gen_Wrap_66(System.Object P0, System.Object P1) { }
        // RVA: 0x08938FC0  token: 0x6000139
        public System.Boolean __Gen_Wrap_67(System.Object P0, HG.Rendering.Runtime.HGCharacterVolume& P1) { }
        // RVA: 0x089390E4  token: 0x600013A
        public System.Single __Gen_Wrap_68(System.Object P0) { }
        // RVA: 0x050F18D0  token: 0x600013B
        public System.Single __Gen_Wrap_69() { }
        // RVA: 0x050F0B68  token: 0x600013C
        public System.Void __Gen_Wrap_70(System.Single P0) { }
        // RVA: 0x089392AC  token: 0x600013D
        public DG.Tweening.Tweener __Gen_Wrap_71(System.Single P0, System.Single P1, System.Single P2, System.Object P3) { }
        // RVA: 0x089393DC  token: 0x600013E
        public Beyond.Lua.UtilsForLua.ImageContentParam __Gen_Wrap_72(System.Object P0) { }
        // RVA: 0x050EE9C4  token: 0x600013F
        public System.Void __Gen_Wrap_73(System.Int32 P0) { }
        // RVA: 0x050F0C14  token: 0x6000140
        public System.Void __Gen_Wrap_74(System.Boolean P0) { }
        // RVA: 0x089394B8  token: 0x6000141
        public Cinemachine.CinemachineTransposer __Gen_Wrap_75(System.Object P0) { }
        // RVA: 0x08939594  token: 0x6000142
        public Cinemachine.CinemachineComposer __Gen_Wrap_76(System.Object P0) { }
        // RVA: 0x08939670  token: 0x6000143
        public CinemachineCameraOffset __Gen_Wrap_77(System.Object P0) { }
        // RVA: 0x03D059C0  token: 0x6000144
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x08939874  token: 0x6000145
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x6000146
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x200002E  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000147
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x08940C5C  token: 0x6000148
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x02BE3A60  token: 0x6000149
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x08940B18  token: 0x600014A
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x08940BE4  token: 0x600014B
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x08940CC0  token: 0x600014C
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x08940A74  token: 0x600014D
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x200002F  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-Lua-LuaEventSystem-PushEventName0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-IsLuaGCing0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-AddOnceLuaEventAfterGCDo0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaEventSystem-DispatchEvent0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaEventSystem-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Lua-CSharpCallLuaRegistration-Init0;  // const
        public static IFix.IDMAP0 Beyond-Lua-CSharpCallLuaRegistration-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-get_itemDict0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-OnBeforeSerialize0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-OnAfterDeserialize0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-MarkLuaValueProcessed0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-ConvertLuaTableToJson0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-ConvertLuaCodeToJson0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ConvertJValueToObjectForValidation0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJTokenForValidation0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_JsonToLuaTableForValidation0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_IsNumericType0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_CompareValues0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_CompareLuaTables0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ValidateLuaTableConsistency0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ProcessLuaTableItem0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-ShouldProcessEnumItem0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ProcessEnumItem0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ConvertJValueToObject0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJToken0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_JsonToLuaTable0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-GetEnumType0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-GetEnumValueObject0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-InitConfigTable0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-HasLuaValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-ShouldSerializeLuaTableJson0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaHotFix-LuaHotFixTest0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaHotFix-HotFixLua0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaHotFix-HotFixLua1;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaHotFix-HotFixLua2;  // const
        public static IFix.IDMAP0 Beyond-Lua-LoadLuaProxy-_RunOnStart0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LoadLuaProxy-LoadLua0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaMethodPointerModule-_RunOnStart0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-CreateInstance0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-DestroyInstance0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-IsEnableMultithreadGC0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_OnRenderDone0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_OnRenderDone1;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-GetLuaStack0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_HyperLuaLogCallback0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_LuaUtilsLogCallback0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_Register3rdPartyLibraries0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLuaBytes0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_OnEnvLangChanged0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LuaCalculateABPathHash0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-CasterStringPathHash0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-CheckStringPathHash0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_RegisterCSharpCallLua0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-ReStartLuaProfiler0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-set_isQuittingApplication0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-Tick0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-TailLateTick0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-GetLuaFileRealPath0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-IsLuaFileExist0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLuaByteByFileRealPath0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLua0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLuaBytePtr0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-DoString0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-GetLuaState0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-ClearAllUnityObjectUserdata0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-AddLuaEventAfterGCDo0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-RemoveLuaEventAfterGCDo0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-_UnBindFromXluaRef0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-_BindSelfReferences0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-BindToLua0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-ContainsGameObject0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestInt0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestVoid0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam20;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestReturnObj0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestObjParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestInt0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestVoid0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam20;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestReturnObj0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestObjParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestVoid0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestInt0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStructParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStructParam1;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStructParam20;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestReturnObj0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestObjParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestEnum0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestReturnEnum0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStruct0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestVoid0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestInt0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStructParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStructParam1;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStructParam20;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestReturnObj0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestObjParam0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestEnum0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestReturnEnum0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStruct0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CreateObject0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CreateObject1;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CreateObject2;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-UIContainerResize0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TurnOffLayer0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TurnOnLayer0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ToggleLayer0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetPosX0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetPosY0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetPosZ0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetRotX0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetRotY0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetRotZ0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetScaleX0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetScaleY0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetScaleZ0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ClearUIComponents0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-RayCast0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-RaycastNonAlloc0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetRectTransformBounds0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-RectTransformToScreenRect0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetRectTransformCenterPosition0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CalcBoundOfRectTransform0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetStringList0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetStringHash0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-EntityDistance0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-OpenAccountCenter0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ExitGame0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetCurrentUID0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-StartPayment0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TryGetCharacterVolume0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetAnimationCurveLength0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TweenTo0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-IsNull0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ParseImageContent0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ReturnToLogin0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-QuitGame0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ToggleCharInfoInUpgradePanelOption0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ToggleWeaponInUpgradePanelOption0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetCinemachineTransposer0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetCinemachineComposer0;  // const
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetOrAddCinemachineCameraOffset0;  // const

    }

}

