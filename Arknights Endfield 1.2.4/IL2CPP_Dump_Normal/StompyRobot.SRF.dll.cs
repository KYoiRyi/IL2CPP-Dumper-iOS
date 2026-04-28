// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRF.dll
// Classes:  90
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x10
    public static class SRDebugUtil
    {
        // Fields
        public static System.Int32 LineBufferCount;  // const
        private static System.Boolean <IsFixedUpdate>k__BackingField;  // static @ 0x0

        // Properties
        System.Boolean IsFixedUpdate { get; /* RVA: 0x096C99B4 */ set; /* RVA: 0x096C99EC */ }

        // Methods
        // RVA: 0x096C9728  token: 0x6000003
        public static System.Void AssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance) { }
        // RVA: 0x096C98AC  token: 0x6000004
        public static System.Void Assert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance) { }
        // RVA: 0x096C99A4  token: 0x6000005
        public static System.Void EditorAssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance) { }
        // RVA: 0x096C99AC  token: 0x6000006
        public static System.Void EditorAssert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance) { }

    }

    // TypeToken: 0x2000003  // size: 0x10
    public static class SRFileUtil
    {
        // Methods
        // RVA: 0x096CA008  token: 0x6000007
        public static System.Void DeleteDirectory(System.String path) { }
        // RVA: 0x0315D010  token: 0x6000008
        public static System.String GetBytesReadable(System.Int64 i) { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class SRInstantiate
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000009
        public static T Instantiate(T prefab) { }
        // RVA: 0x096CA09C  token: 0x600000A
        public static UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab) { }
        // RVA: -1  // generic def  token: 0x600000B
        public static T Instantiate(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct EaseType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRMath.EaseType Linear;  // const
        public static SRMath.EaseType QuadEaseOut;  // const
        public static SRMath.EaseType QuadEaseIn;  // const
        public static SRMath.EaseType QuadEaseInOut;  // const
        public static SRMath.EaseType QuadEaseOutIn;  // const
        public static SRMath.EaseType ExpoEaseOut;  // const
        public static SRMath.EaseType ExpoEaseIn;  // const
        public static SRMath.EaseType ExpoEaseInOut;  // const
        public static SRMath.EaseType ExpoEaseOutIn;  // const
        public static SRMath.EaseType CubicEaseOut;  // const
        public static SRMath.EaseType CubicEaseIn;  // const
        public static SRMath.EaseType CubicEaseInOut;  // const
        public static SRMath.EaseType CubicEaseOutIn;  // const
        public static SRMath.EaseType QuartEaseOut;  // const
        public static SRMath.EaseType QuartEaseIn;  // const
        public static SRMath.EaseType QuartEaseInOut;  // const
        public static SRMath.EaseType QuartEaseOutIn;  // const
        public static SRMath.EaseType QuintEaseOut;  // const
        public static SRMath.EaseType QuintEaseIn;  // const
        public static SRMath.EaseType QuintEaseInOut;  // const
        public static SRMath.EaseType QuintEaseOutIn;  // const
        public static SRMath.EaseType CircEaseOut;  // const
        public static SRMath.EaseType CircEaseIn;  // const
        public static SRMath.EaseType CircEaseInOut;  // const
        public static SRMath.EaseType CircEaseOutIn;  // const
        public static SRMath.EaseType SineEaseOut;  // const
        public static SRMath.EaseType SineEaseIn;  // const
        public static SRMath.EaseType SineEaseInOut;  // const
        public static SRMath.EaseType SineEaseOutIn;  // const
        public static SRMath.EaseType ElasticEaseOut;  // const
        public static SRMath.EaseType ElasticEaseIn;  // const
        public static SRMath.EaseType ElasticEaseInOut;  // const
        public static SRMath.EaseType ElasticEaseOutIn;  // const
        public static SRMath.EaseType BounceEaseOut;  // const
        public static SRMath.EaseType BounceEaseIn;  // const
        public static SRMath.EaseType BounceEaseInOut;  // const
        public static SRMath.EaseType BounceEaseOutIn;  // const
        public static SRMath.EaseType BackEaseOut;  // const
        public static SRMath.EaseType BackEaseIn;  // const
        public static SRMath.EaseType BackEaseInOut;  // const
        public static SRMath.EaseType BackEaseOutIn;  // const

    }

    // TypeToken: 0x2000007  // size: 0x10
    public static class TweenFunctions
    {
        // Methods
        // RVA: 0x096CE8CC  token: 0x600001B
        public static System.Single Linear(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE864  token: 0x600001C
        public static System.Single ExpoEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE7A4  token: 0x600001D
        public static System.Single ExpoEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE6F4  token: 0x600001E
        public static System.Single ExpoEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE804  token: 0x600001F
        public static System.Single ExpoEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE254  token: 0x6000020
        public static System.Single CircEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE15C  token: 0x6000021
        public static System.Single CircEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE0C8  token: 0x6000022
        public static System.Single CircEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE1B8  token: 0x6000023
        public static System.Single CircEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE9D0  token: 0x6000024
        public static System.Single QuadEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE93C  token: 0x6000025
        public static System.Single QuadEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE8DC  token: 0x6000026
        public static System.Single QuadEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE954  token: 0x6000027
        public static System.Single QuadEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEE70  token: 0x6000028
        public static System.Single SineEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CED78  token: 0x6000029
        public static System.Single SineEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CECE4  token: 0x600002A
        public static System.Single SineEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEDC4  token: 0x600002B
        public static System.Single SineEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE3BC  token: 0x600002C
        public static System.Single CubicEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE310  token: 0x600002D
        public static System.Single CubicEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE2A0  token: 0x600002E
        public static System.Single CubicEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE32C  token: 0x600002F
        public static System.Single CubicEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEB34  token: 0x6000030
        public static System.Single QuartEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEA74  token: 0x6000031
        public static System.Single QuartEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE9F4  token: 0x6000032
        public static System.Single QuartEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEA94  token: 0x6000033
        public static System.Single QuartEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CECB0  token: 0x6000034
        public static System.Single QuintEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEBEC  token: 0x6000035
        public static System.Single QuintEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEB6C  token: 0x6000036
        public static System.Single QuintEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CEC10  token: 0x6000037
        public static System.Single QuintEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE634  token: 0x6000038
        public static System.Single ElasticEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE508  token: 0x6000039
        public static System.Single ElasticEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE3E8  token: 0x600003A
        public static System.Single ElasticEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE5D4  token: 0x600003B
        public static System.Single ElasticEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CE008  token: 0x600003C
        public static System.Single BounceEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDF2C  token: 0x600003D
        public static System.Single BounceEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDE94  token: 0x600003E
        public static System.Single BounceEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDF78  token: 0x600003F
        public static System.Single BounceEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDE58  token: 0x6000040
        public static System.Single BackEaseOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDD7C  token: 0x6000041
        public static System.Single BackEaseIn(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDCF4  token: 0x6000042
        public static System.Single BackEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d) { }
        // RVA: 0x096CDDA8  token: 0x6000043
        public static System.Single BackEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d) { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public static class SRMath
    {
        // Methods
        // RVA: 0x03D75240  token: 0x600000C
        public static System.Single LerpUnclamped(System.Single from, System.Single to, System.Single t) { }
        // RVA: 0x03D751E0  token: 0x600000D
        public static UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t) { }
        // RVA: 0x096CA840  token: 0x600000E
        public static System.Single FacingNormalized(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2) { }
        // RVA: 0x096CABC8  token: 0x600000F
        public static System.Single WrapAngle(System.Single angle) { }
        // RVA: 0x096CA8B0  token: 0x6000010
        public static System.Single NearestAngle(System.Single to, System.Single angle1, System.Single angle2) { }
        // RVA: 0x096CABF0  token: 0x6000011
        public static System.Int32 Wrap(System.Int32 max, System.Int32 value) { }
        // RVA: 0x096CAC84  token: 0x6000012
        public static System.Single Wrap(System.Single max, System.Single value) { }
        // RVA: 0x03D751D0  token: 0x6000013
        public static System.Single Average(System.Single v1, System.Single v2) { }
        // RVA: 0x096CA0F0  token: 0x6000014
        public static System.Single Angle(UnityEngine.Vector2 direction) { }
        // RVA: 0x096CA1B4  token: 0x6000015
        public static System.Single Ease(System.Single from, System.Single to, System.Single t, SRMath.EaseType type) { }
        // RVA: 0x096CAB00  token: 0x6000016
        public static System.Single SpringLerp(System.Single strength, System.Single deltaTime) { }
        // RVA: 0x096CAAC0  token: 0x6000017
        public static System.Single SpringLerp(System.Single from, System.Single to, System.Single strength, System.Single deltaTime) { }
        // RVA: 0x096CAA38  token: 0x6000018
        public static UnityEngine.Vector3 SpringLerp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single strength, System.Single deltaTime) { }
        // RVA: 0x096CAB50  token: 0x6000019
        public static UnityEngine.Quaternion SpringLerp(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single strength, System.Single deltaTime) { }
        // RVA: 0x096CA920  token: 0x600001A
        public static System.Single SmoothClamp(System.Single value, System.Single min, System.Single max, System.Single scrollMax, SRMath.EaseType easeType) { }

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct TOKEN
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRF.Json.Parser.TOKEN NONE;  // const
        public static SRF.Json.Parser.TOKEN CURLY_OPEN;  // const
        public static SRF.Json.Parser.TOKEN CURLY_CLOSE;  // const
        public static SRF.Json.Parser.TOKEN SQUARED_OPEN;  // const
        public static SRF.Json.Parser.TOKEN SQUARED_CLOSE;  // const
        public static SRF.Json.Parser.TOKEN COLON;  // const
        public static SRF.Json.Parser.TOKEN COMMA;  // const
        public static SRF.Json.Parser.TOKEN STRING;  // const
        public static SRF.Json.Parser.TOKEN NUMBER;  // const
        public static SRF.Json.Parser.TOKEN TRUE;  // const
        public static SRF.Json.Parser.TOKEN FALSE;  // const
        public static SRF.Json.Parser.TOKEN NULL;  // const

    }

    // TypeToken: 0x2000009  // size: 0x18
    public sealed class Parser : System.IDisposable
    {
        // Fields
        private static System.String WORD_BREAK;  // const
        private System.IO.StringReader json;  // 0x10

        // Properties
        System.Char PeekChar { get; /* RVA: 0x096C8974 */ }
        System.Char NextChar { get; /* RVA: 0x096C8644 */ }
        System.String NextWord { get; /* RVA: 0x096C88C4 */ }
        SRF.Json.Parser.TOKEN NextToken { get; /* RVA: 0x096C86A0 */ }

        // Methods
        // RVA: 0x096C85CC  token: 0x6000046
        private System.Void .ctor(System.String jsonString) { }
        // RVA: 0x087C8320  token: 0x600004B
        public virtual System.Void Dispose() { }
        // RVA: 0x096C7EC0  token: 0x600004C
        public static System.Boolean IsWordBreak(System.Char c) { }
        // RVA: 0x096C84D4  token: 0x600004D
        public static System.Object Parse(System.String jsonString) { }
        // RVA: 0x096C8178  token: 0x600004E
        private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }
        // RVA: 0x096C7F38  token: 0x600004F
        private System.Collections.Generic.List<System.Object> ParseArray() { }
        // RVA: 0x096C84B0  token: 0x6000050
        private System.Object ParseValue() { }
        // RVA: 0x096C8000  token: 0x6000051
        private System.Object ParseByToken(SRF.Json.Parser.TOKEN token) { }
        // RVA: 0x096C8284  token: 0x6000052
        private System.String ParseString() { }
        // RVA: 0x096C80B4  token: 0x6000053
        private System.Object ParseNumber() { }
        // RVA: 0x096C7E30  token: 0x6000054
        private System.Void EatWhitespace() { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public sealed class Serializer
    {
        // Fields
        private System.Text.StringBuilder builder;  // 0x10

        // Methods
        // RVA: 0x096CCFE8  token: 0x6000055
        private System.Void .ctor() { }
        // RVA: 0x096CCF70  token: 0x6000056
        public static System.String Serialize(System.Object obj) { }
        // RVA: 0x096CCDEC  token: 0x6000057
        private System.Void SerializeValue(System.Object value) { }
        // RVA: 0x096CC50C  token: 0x6000058
        private System.Void SerializeObject(System.Collections.IDictionary obj) { }
        // RVA: 0x096CC188  token: 0x6000059
        private System.Void SerializeArray(System.Collections.IList anArray) { }
        // RVA: 0x096CCB74  token: 0x600005A
        private System.Void SerializeString(System.String str) { }
        // RVA: 0x096CC914  token: 0x600005B
        private System.Void SerializeOther(System.Object value) { }

    }

    // TypeToken: 0x200000D
    public sealed class <GetEnumerator>d__15 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private T <>2__current;  // 0x0
        public SRF.SRList<T> <>4__this;  // 0x0
        private System.Int32 <i>5__2;  // 0x0

        // Properties
        T System.Collections.Generic.IEnumerator<T>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600007A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x600007B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x600007C
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600007E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000012  // size: 0x30
    public sealed struct FieldInfo
    {
        // Fields
        public System.Boolean AutoCreate;  // 0x10
        public System.Boolean AutoSet;  // 0x11
        public System.Reflection.FieldInfo Field;  // 0x18
        public System.Boolean Import;  // 0x20
        public System.Type ImportType;  // 0x28

    }

    // TypeToken: 0x2000014  // size: 0x28
    public sealed class <WaitForSecondsRealTime>d__0 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Single time;  // 0x20
        private System.Single <endTime>5__2;  // 0x24

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000A2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000A3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096CF200  token: 0x60000A4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096CF264  token: 0x60000A6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200001A  // size: 0x40
    public sealed class <GetChildren>d__0 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Transform <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        private UnityEngine.Transform t;  // 0x28
        public UnityEngine.Transform <>3__t;  // 0x30
        private System.Int32 <i>5__2;  // 0x38

        // Properties
        UnityEngine.Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x60000BE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000BF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x096CEEAC  token: 0x60000C0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x096CEFC4  token: 0x60000C2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x096CEF28  token: 0x60000C4
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator() { }
        // RVA: 0x096CEFBC  token: 0x60000C5
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000020  // size: 0x14
    public sealed struct Operations
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRF.UI.CopyPreferredSizes.Operations Max;  // const
        public static SRF.UI.CopyPreferredSizes.Operations Min;  // const

    }

    // TypeToken: 0x2000021  // size: 0x20
    public class CopySource
    {
        // Fields
        public UnityEngine.RectTransform Rect;  // 0x10
        public System.Single PaddingHeight;  // 0x18
        public System.Single PaddingWidth;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x60000EE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct Modes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static SRF.UI.ResponsiveEnable.Modes EnableAbove;  // const
        public static SRF.UI.ResponsiveEnable.Modes EnableBelow;  // const

    }

    // TypeToken: 0x200002A  // size: 0x30
    public sealed struct Entry
    {
        // Fields
        public UnityEngine.Behaviour[] Components;  // 0x10
        public UnityEngine.GameObject[] GameObjects;  // 0x18
        public SRF.UI.ResponsiveEnable.Modes Mode;  // 0x20
        public System.Single ThresholdHeight;  // 0x24
        public System.Single ThresholdWidth;  // 0x28

    }

    // TypeToken: 0x200002D  // size: 0x18
    public sealed struct SizeDefinition
    {
        // Fields
        public System.Single ElementWidth;  // 0x10
        public System.Single ThresholdWidth;  // 0x14

    }

    // TypeToken: 0x200002C  // size: 0x20
    public sealed struct Element
    {
        // Fields
        public SRF.UI.ResponsiveResize.Element.SizeDefinition[] SizeDefinitions;  // 0x10
        public UnityEngine.RectTransform Target;  // 0x18

    }

    // TypeToken: 0x2000033  // size: 0x30
    public class SpinEvent : UnityEngine.Events.UnityEvent
    {
        // Methods
        // RVA: 0x04271C98  token: 0x6000140
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003D  // size: 0x30
    public class SelectedItemChangedEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x096CC14C  token: 0x6000189
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0x38
    public class Row
    {
        // Fields
        public System.Object Data;  // 0x10
        public System.Int32 Index;  // 0x18
        public UnityEngine.RectTransform Rect;  // 0x20
        public SRF.UI.StyleRoot Root;  // 0x28
        public SRF.UI.Layout.IVirtualView View;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x600018A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public sealed class <LoadDependencies>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public SRF.Service.SRDependencyServiceBase<T> <>4__this;  // 0x0
        private System.Type[] <>7__wrap1;  // 0x0
        private System.Int32 <>7__wrap2;  // 0x0
        private SRF.Service.IAsyncService <a>5__4;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600019C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x600019D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x600019E
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60001A0
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000046
    public sealed class <LoadCoroutine>d__11 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public SRF.Service.SRSceneServiceBase<T,TImpl> <>4__this;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001AB
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x60001AC
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x60001AD
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60001AF
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000049  // size: 0x20
    public class Service
    {
        // Fields
        public System.Object Object;  // 0x10
        public System.Type Type;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004A  // size: 0x30
    public class ServiceStub
    {
        // Fields
        public System.Func<System.Object> Constructor;  // 0x10
        public System.Type InterfaceType;  // 0x18
        public System.Func<System.Type> Selector;  // 0x20
        public System.Type Type;  // 0x28

        // Methods
        // RVA: 0x096CD04C  token: 0x60001CB
        public virtual System.String ToString() { }
        // RVA: 0x0350B670  token: 0x60001CC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004B  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly SRF.Service.SRServiceManager.<>c <>9;  // static @ 0x0
        public static System.Func<SRF.Service.SRServiceManager.ServiceStub,System.String> <>9__21_0;  // static @ 0x8

        // Methods
        // RVA: 0x096CF19C  token: 0x60001CD
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001CE
        public System.Void .ctor() { }
        // RVA: 0x096CF010  token: 0x60001CF
        private System.String <UpdateStubs>b__21_0(SRF.Service.SRServiceManager.ServiceStub p) { }

    }

    // TypeToken: 0x200004C  // size: 0x18
    public sealed class <>c__DisplayClass26_0
    {
        // Fields
        public SRF.Service.ServiceSelectorAttribute attrib;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001D0
        public System.Void .ctor() { }
        // RVA: 0x03C96EB0  token: 0x60001D1
        private System.Boolean <ScanTypeForSelectors>b__0(SRF.Service.SRServiceManager.ServiceStub p) { }

    }

    // TypeToken: 0x200004D  // size: 0x20
    public sealed class <>c__DisplayClass27_0
    {
        // Fields
        public SRF.Service.ServiceConstructorAttribute attrib;  // 0x10
        public System.Reflection.MethodInfo m;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001D2
        public System.Void .ctor() { }
        // RVA: 0x096CF0E8  token: 0x60001D3
        private System.Boolean <ScanTypeForConstructors>b__0(SRF.Service.SRServiceManager.ServiceStub p) { }
        // RVA: 0x096CF158  token: 0x60001D4
        private System.Object <ScanTypeForConstructors>b__1() { }

    }

    // TypeToken: 0x2000050  // size: 0x20
    public sealed class <>c__DisplayClass1_0
    {
        // Fields
        public System.Reflection.MethodInfo method;  // 0x10
        public System.Object target;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001D9
        public System.Void .ctor() { }
        // RVA: 0x096CF0BC  token: 0x60001DA
        private System.Object <.ctor>b__0(System.Object[] o) { }

    }

    // TypeToken: 0x2000051  // size: 0x18
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public System.Action action;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001DB
        public System.Void .ctor() { }
        // RVA: 0x096CF17C  token: 0x60001DC
        private System.Object <op_Implicit>b__0(System.Object[] args) { }

    }

    // TypeToken: 0x2000054
    public sealed class <>c__DisplayClass9_0`1
    {
        // Fields
        public System.Action<T> setter;  // 0x0
        public System.Func<T> getter;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001F0
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60001F1
        private System.Void <FromLambda>b__0(System.Object o) { }
        // RVA: -1  // not resolved  token: 0x60001F2
        private System.Object <FromLambda>b__1() { }

    }

    // TypeToken: 0x2000055  // size: 0x20
    public sealed class <>c__DisplayClass10_0
    {
        // Fields
        public System.Object target;  // 0x10
        public System.Reflection.PropertyInfo property;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001F3
        public System.Void .ctor() { }
        // RVA: 0x096CF098  token: 0x60001F4
        private System.Object <.ctor>b__0() { }
        // RVA: 0x096CF0A8  token: 0x60001F5
        private System.Void <.ctor>b__1(System.Object v) { }

    }

    // TypeToken: 0x2000056
    public sealed class <>c__23`1
    {
        // Fields
        public static readonly SRF.Helpers.PropertyReference.<>c__23<T> <>9;  // static @ 0x0
        public static System.Func<System.Attribute,System.Boolean> <>9__23_0;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60001F6
        private static System.Void .cctor() { }
        // RVA: -1  // not resolved  token: 0x60001F7
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60001F8
        private System.Boolean <GetAttribute>b__23_0(System.Attribute p) { }

    }

namespace SRF
{

    // TypeToken: 0x2000008  // size: 0x10
    public static class Json
    {
        // Methods
        // RVA: 0x096C7ACC  token: 0x6000044
        public static System.Object Deserialize(System.String json) { }
        // RVA: 0x096C7AE8  token: 0x6000045
        public static System.String Serialize(System.Object obj) { }

    }

    // TypeToken: 0x200000C
    public class SRList`1 : System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private T[] _buffer;  // 0x0
        private System.Int32 _count;  // 0x0
        private System.Collections.Generic.EqualityComparer<T> _equalityComparer;  // 0x0
        private System.Collections.ObjectModel.ReadOnlyCollection<T> _readOnlyWrapper;  // 0x0

        // Properties
        T[] Buffer { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.EqualityComparer<T> EqualityComparer { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600005C
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600005D
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x600005E
        public System.Void .ctor(System.Collections.Generic.IEnumerable<T> source) { }
        // RVA: -1  // not resolved  token: 0x6000064
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000065
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000066
        public virtual System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x6000067
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000068
        public virtual System.Boolean Contains(T item) { }
        // RVA: -1  // not resolved  token: 0x6000069
        public virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x600006A
        public virtual System.Boolean Remove(T item) { }
        // RVA: -1  // not resolved  token: 0x600006C
        public virtual System.Int32 IndexOf(T item) { }
        // RVA: -1  // not resolved  token: 0x600006D
        public virtual System.Void Insert(System.Int32 index, T item) { }
        // RVA: -1  // not resolved  token: 0x600006E
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000071
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: -1  // not resolved  token: 0x6000072
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: -1  // not resolved  token: 0x6000073
        public System.Void AddRange(System.Collections.Generic.IEnumerable<T> range) { }
        // RVA: -1  // not resolved  token: 0x6000074
        public System.Void Clear(System.Boolean clean) { }
        // RVA: -1  // not resolved  token: 0x6000075
        public System.Void Clean() { }
        // RVA: -1  // not resolved  token: 0x6000076
        public System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly() { }
        // RVA: -1  // not resolved  token: 0x6000077
        private System.Void Expand() { }
        // RVA: -1  // not resolved  token: 0x6000078
        public System.Void Trim() { }
        // RVA: -1  // not resolved  token: 0x6000079
        public System.Void Sort(System.Comparison<T> comparer) { }

    }

    // TypeToken: 0x200000E  // size: 0x48
    public abstract class SRMonoBehaviour : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Collider _collider;  // 0x18
        private UnityEngine.Transform _transform;  // 0x20
        private UnityEngine.Rigidbody _rigidBody;  // 0x28
        private UnityEngine.GameObject _gameObject;  // 0x30
        private UnityEngine.Rigidbody2D _rigidbody2D;  // 0x38
        private UnityEngine.Collider2D _collider2D;  // 0x40

        // Properties
        UnityEngine.Transform CachedTransform { get; /* RVA: 0x0268DF90 */ }
        UnityEngine.Collider CachedCollider { get; /* RVA: 0x096CAD60 */ }
        UnityEngine.Collider2D CachedCollider2D { get; /* RVA: 0x096CACDC */ }
        UnityEngine.Rigidbody CachedRigidBody { get; /* RVA: 0x096CAE68 */ }
        UnityEngine.Rigidbody2D CachedRigidBody2D { get; /* RVA: 0x096CADE4 */ }
        UnityEngine.GameObject CachedGameObject { get; /* RVA: 0x0268DF10 */ }
        UnityEngine.Transform transform { get; /* RVA: 0x096CAEEC */ }

        // Methods
        // RVA: 0x096CACA8  token: 0x6000087
        protected System.Void AssertNotNull(System.Object value, System.String fieldName) { }
        // RVA: 0x096CACC0  token: 0x6000088
        protected System.Void Assert(System.Boolean condition, System.String message) { }
        // RVA: 0x096CACA8  token: 0x6000089
        protected System.Void EditorAssertNotNull(System.Object value, System.String fieldName) { }
        // RVA: 0x096CACC0  token: 0x600008A
        protected System.Void EditorAssert(System.Boolean condition, System.String message) { }
        // RVA: 0x0426FE60  token: 0x600008B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x18
    public sealed class RequiredFieldAttribute : System.Attribute
    {
        // Fields
        private System.Boolean _autoCreate;  // 0x10
        private System.Boolean _autoSearch;  // 0x11
        private System.Boolean _editorOnly;  // 0x12

        // Properties
        System.Boolean AutoSearch { get; /* RVA: 0x03D510E0 */ set; /* RVA: 0x03D510F0 */ }
        System.Boolean AutoCreate { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }
        System.Boolean EditorOnly { get; /* RVA: 0x03D519E0 */ set; /* RVA: 0x03D6B770 */ }

        // Methods
        // RVA: 0x03D751C0  token: 0x600008C
        public System.Void .ctor(System.Boolean autoSearch) { }
        // RVA: 0x03D64CD0  token: 0x600008D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public class ImportAttribute : System.Attribute
    {
        // Fields
        public readonly System.Type Service;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000094
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x6000095
        public System.Void .ctor(System.Type serviceType) { }

    }

    // TypeToken: 0x2000011  // size: 0x48
    public abstract class SRMonoBehaviourEx : SRF.SRMonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo>> _checkedFields;  // static @ 0x0

        // Methods
        // RVA: 0x02A6C2A0  token: 0x6000096
        private static System.Void CheckFields(SRF.SRMonoBehaviourEx instance, System.Boolean justSet) { }
        // RVA: 0x02A6C1B0  token: 0x6000097
        private static System.Void PopulateObject(System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo> cache, SRF.SRMonoBehaviourEx instance, System.Boolean justSet) { }
        // RVA: 0x02A6D440  token: 0x6000098
        private static System.Collections.Generic.List<SRF.SRMonoBehaviourEx.FieldInfo> ScanType(System.Type t) { }
        // RVA: 0x04276F4C  token: 0x6000099
        protected virtual System.Void Awake() { }
        // RVA: 0x0350B670  token: 0x600009A
        protected virtual System.Void Start() { }
        // RVA: 0x0350B670  token: 0x600009B
        protected virtual System.Void Update() { }
        // RVA: 0x0350B670  token: 0x600009C
        protected virtual System.Void FixedUpdate() { }
        // RVA: 0x0350B670  token: 0x600009D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0350B670  token: 0x600009E
        protected virtual System.Void OnDisable() { }
        // RVA: 0x0350B670  token: 0x600009F
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0426FE60  token: 0x60000A0
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public static class Coroutines
    {
        // Methods
        // RVA: 0x096C65A4  token: 0x60000A1
        public static System.Collections.IEnumerator WaitForSecondsRealTime(System.Single time) { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public static class SRFFloatExtensions
    {
        // Methods
        // RVA: 0x03D51490  token: 0x60000A8
        public static System.Single Sqr(System.Single f) { }
        // RVA: 0x03D51630  token: 0x60000A9
        public static System.Single SqrRt(System.Single f) { }
        // RVA: 0x096C9A28  token: 0x60000AA
        public static System.Boolean ApproxZero(System.Single f) { }
        // RVA: 0x096C9A34  token: 0x60000AB
        public static System.Boolean Approx(System.Single f, System.Single f2) { }

    }

    // TypeToken: 0x2000016  // size: 0x10
    public static class SRFGameObjectExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60000AC
        public static T GetIComponent(UnityEngine.GameObject t) { }
        // RVA: -1  // generic def  token: 0x60000AD
        public static T GetComponentOrAdd(UnityEngine.GameObject obj) { }
        // RVA: -1  // generic def  token: 0x60000AE
        public static System.Void RemoveComponentIfExists(UnityEngine.GameObject obj) { }
        // RVA: -1  // generic def  token: 0x60000AF
        public static System.Void RemoveComponentsIfExists(UnityEngine.GameObject obj) { }
        // RVA: -1  // generic def  token: 0x60000B0
        public static System.Boolean EnableComponentIfExists(UnityEngine.GameObject obj, System.Boolean enable) { }
        // RVA: 0x096C9BD4  token: 0x60000B1
        public static System.Void SetLayerRecursive(UnityEngine.GameObject o, System.Int32 layer) { }
        // RVA: 0x096C9A3C  token: 0x60000B2
        private static System.Void SetLayerInternal(UnityEngine.Transform t, System.Int32 layer) { }

    }

    // TypeToken: 0x2000017  // size: 0x10
    public static class SRFIListExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60000B3
        public static T Random(System.Collections.Generic.IList<T> list) { }
        // RVA: -1  // generic def  token: 0x60000B4
        public static T RandomOrDefault(System.Collections.Generic.IList<T> list) { }
        // RVA: -1  // generic def  token: 0x60000B5
        public static T PopLast(System.Collections.Generic.IList<T> list) { }

    }

    // TypeToken: 0x2000018  // size: 0x10
    public static class SRFStringExtensions
    {
        // Methods
        // RVA: 0x04275A04  token: 0x60000B6
        public static System.String Fmt(System.String formatString, System.Object[] args) { }

    }

    // TypeToken: 0x2000019  // size: 0x10
    public static class SRFTransformExtensions
    {
        // Methods
        // RVA: 0x096C9E5C  token: 0x60000B7
        public static System.Collections.Generic.IEnumerable<UnityEngine.Transform> GetChildren(UnityEngine.Transform t) { }
        // RVA: 0x096C9F54  token: 0x60000B8
        public static System.Void ResetLocal(UnityEngine.Transform t) { }
        // RVA: 0x096C9C00  token: 0x60000B9
        public static UnityEngine.GameObject CreateChild(UnityEngine.Transform t, System.String name) { }
        // RVA: 0x096C9FE8  token: 0x60000BA
        public static System.Void SetParentMaintainLocals(UnityEngine.Transform t, UnityEngine.Transform parent) { }
        // RVA: 0x0969BAA8  token: 0x60000BB
        public static System.Void SetLocals(UnityEngine.Transform t, UnityEngine.Transform from) { }
        // RVA: 0x096C9ECC  token: 0x60000BC
        public static System.Void Match(UnityEngine.Transform t, UnityEngine.Transform from) { }
        // RVA: 0x096C9CC8  token: 0x60000BD
        public static System.Void DestroyChildren(UnityEngine.Transform t) { }

    }

    // TypeToken: 0x200001B  // size: 0x10
    public class Hierarchy
    {
        // Fields
        private static readonly System.Char[] Seperator;  // static @ 0x0
        private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> Cache;  // static @ 0x8

        // Properties
        UnityEngine.Transform Item { get; /* RVA: 0x096C7944 */ }

        // Methods
        // RVA: 0x0268EDD0  token: 0x60000C7
        public static UnityEngine.Transform Get(System.String key) { }
        // RVA: 0x03D01E20  token: 0x60000C8
        public static System.Void RuntimeInitialize() { }
        // RVA: 0x0350B670  token: 0x60000C9
        public System.Void .ctor() { }
        // RVA: 0x03C7CBB0  token: 0x60000CA
        private static System.Void .cctor() { }

    }

}

namespace SRF.Components
{

    // TypeToken: 0x2000058
    public abstract class SRAutoSingleton`1 : SRF.SRMonoBehaviour
    {
        // Fields
        private static T _instance;  // static @ 0x0

        // Properties
        T Instance { get; /* RVA: -1  // not resolved */ }
        System.Boolean HasInstance { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001FE
        protected virtual System.Void Awake() { }
        // RVA: -1  // not resolved  token: 0x60001FF
        protected virtual System.Void OnEnable() { }
        // RVA: -1  // not resolved  token: 0x6000200
        private System.Void OnApplicationQuit() { }
        // RVA: -1  // not resolved  token: 0x6000201
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public abstract class SRSingleton`1 : SRF.SRMonoBehaviour
    {
        // Fields
        private static T _instance;  // static @ 0x0

        // Properties
        T Instance { get; /* RVA: -1  // not resolved */ }
        System.Boolean HasInstance { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000204
        private System.Void Register() { }
        // RVA: -1  // not resolved  token: 0x6000205
        protected virtual System.Void Awake() { }
        // RVA: -1  // not resolved  token: 0x6000206
        protected virtual System.Void OnEnable() { }
        // RVA: -1  // not resolved  token: 0x6000207
        private System.Void OnApplicationQuit() { }
        // RVA: -1  // not resolved  token: 0x6000208
        protected System.Void .ctor() { }

    }

}

namespace SRF.Helpers
{

    // TypeToken: 0x200004E  // size: 0x10
    public static class AssetUtil
    {
    }

    // TypeToken: 0x200004F  // size: 0x18
    public sealed class MethodReference
    {
        // Fields
        private readonly System.Func<System.Object[],System.Object> _method;  // 0x10

        // Methods
        // RVA: 0x096C7C80  token: 0x60001D5
        public System.Void .ctor(System.Object target, System.Reflection.MethodInfo method) { }
        // RVA: 0x0426FEE0  token: 0x60001D6
        public System.Void .ctor(System.Func<System.Object[],System.Object> method) { }
        // RVA: 0x0858E0D8  token: 0x60001D7
        public System.Object Invoke(System.Object[] parameters) { }
        // RVA: 0x096C7D60  token: 0x60001D8
        public static SRF.Helpers.MethodReference op_Implicit(System.Action action) { }

    }

    // TypeToken: 0x2000052  // size: 0x80
    public sealed class PropertyValueChangedHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06DE8490  token: 0x60001DD
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x60001DE
        public virtual System.Void Invoke(SRF.Helpers.PropertyReference property) { }
        // RVA: 0x0389C3B0  token: 0x60001DF
        public virtual System.IAsyncResult BeginInvoke(SRF.Helpers.PropertyReference property, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x60001E0
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000053  // size: 0x48
    public sealed class PropertyReference
    {
        // Fields
        private readonly System.Reflection.PropertyInfo _property;  // 0x10
        private readonly System.Object _target;  // 0x18
        private readonly System.Attribute[] _attributes;  // 0x20
        private readonly System.Func<System.Object> _getter;  // 0x28
        private readonly System.Action<System.Object> _setter;  // 0x30
        private System.Collections.Generic.List<SRF.Helpers.PropertyValueChangedHandler> _valueChangedListeners;  // 0x38
        private System.Type <PropertyType>k__BackingField;  // 0x40

        // Properties
        System.Type PropertyType { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        System.Boolean CanRead { get; /* RVA: 0x05693D38 */ }
        System.Boolean CanWrite { get; /* RVA: 0x085839D0 */ }

        // Events
        event SRF.Helpers.PropertyValueChangedHandler ValueChanged;

        // Methods
        // RVA: -1  // generic def  token: 0x60001E3
        public static SRF.Helpers.PropertyReference FromLambda(System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes) { }
        // RVA: 0x096C8D08  token: 0x60001E4
        public System.Void .ctor(System.Object target, System.Reflection.PropertyInfo property) { }
        // RVA: 0x096C8EDC  token: 0x60001E5
        public System.Void .ctor(System.Type type, System.Func<System.Object> getter, System.Action<System.Object> setter, System.Attribute[] attributes) { }
        // RVA: 0x096C89E8  token: 0x60001EA
        public System.Void NotifyValueChanged() { }
        // RVA: 0x096C89D0  token: 0x60001EB
        public System.Object GetValue() { }
        // RVA: 0x096C8B74  token: 0x60001EC
        public System.Void SetValue(System.Object value) { }
        // RVA: -1  // generic def  token: 0x60001ED
        public T GetAttribute() { }
        // RVA: 0x096C8AF8  token: 0x60001EE
        private System.Void OnTargetPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e) { }
        // RVA: 0x096C8BEC  token: 0x60001EF
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000057  // size: 0x10
    public static class SRReflection
    {
        // Methods
        // RVA: 0x096CB6CC  token: 0x60001F9
        public static System.Void SetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p, System.Object value) { }
        // RVA: 0x096CB690  token: 0x60001FA
        public static System.Object GetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p) { }
        // RVA: -1  // generic def  token: 0x60001FB
        public static T GetAttribute(System.Reflection.MemberInfo t) { }

    }

}

namespace SRF.Internal
{

    // TypeToken: 0x200005A  // size: 0x10
    public static class ComponentMenuPaths
    {
        // Fields
        public static System.String PathRoot;  // const
        public static System.String SRServiceManager;  // const
        public static System.String BehavioursRoot;  // const
        public static System.String DestroyOnDisable;  // const
        public static System.String DontDestroyOnLoad;  // const
        public static System.String MatchTransform;  // const
        public static System.String LookAt;  // const
        public static System.String MatchForwardDirection;  // const
        public static System.String MatchMainCameraForwardDirection;  // const
        public static System.String RuntimePosition;  // const
        public static System.String ScrollTexture;  // const
        public static System.String SmoothFloatBehaviour;  // const
        public static System.String SmoothFollow2D;  // const
        public static System.String SpringFollow;  // const
        public static System.String SmoothMatchTransform;  // const
        public static System.String SpawnPrefab;  // const
        public static System.String Velocity;  // const
        public static System.String SmoothOscillate;  // const
        public static System.String SRDebugCamera;  // const
        public static System.String ComponentsRoot;  // const
        public static System.String SRLineRenderer;  // const
        public static System.String SelectionRoot;  // const
        public static System.String SRSpriteFadeRenderer;  // const
        public static System.String SRMaterialFadeRenderer;  // const
        public static System.String SRCompositeFadeRenderer;  // const
        public static System.String UIRoot;  // const
        public static System.String TiltOnTouch;  // const
        public static System.String ScaleOnTouch;  // const
        public static System.String InheritColour;  // const
        public static System.String FlashGraphic;  // const
        public static System.String CopyPreferredSize;  // const
        public static System.String CopyPreferredSizes;  // const
        public static System.String CopyLayoutElement;  // const
        public static System.String CopySizeIntoLayoutElement;  // const
        public static System.String SRText;  // const
        public static System.String Unselectable;  // const
        public static System.String LongPressButton;  // const
        public static System.String ScrollToBottom;  // const
        public static System.String FlowLayoutGroup;  // const
        public static System.String VirtualVerticalLayoutGroup;  // const
        public static System.String StyleRoot;  // const
        public static System.String StyleComponent;  // const
        public static System.String ResponsiveEnable;  // const
        public static System.String ResponsiveResize;  // const
        public static System.String RetinaScaler;  // const
        public static System.String NumberButton;  // const
        public static System.String NumberSpinner;  // const
        public static System.String SRSpinner;  // const
        public static System.String ContentFitText;  // const

    }

}

namespace SRF.Service
{

    // TypeToken: 0x200003F  // size: 0x18
    public sealed class ServiceAttribute : UnityEngine.Scripting.PreserveAttribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;  // 0x10

        // Properties
        System.Type ServiceType { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600018B
        public System.Void .ctor(System.Type serviceType) { }

    }

    // TypeToken: 0x2000040  // size: 0x18
    public sealed class ServiceSelectorAttribute : UnityEngine.Scripting.PreserveAttribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;  // 0x10

        // Properties
        System.Type ServiceType { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600018E
        public System.Void .ctor(System.Type serviceType) { }

    }

    // TypeToken: 0x2000041  // size: 0x18
    public sealed class ServiceConstructorAttribute : UnityEngine.Scripting.PreserveAttribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;  // 0x10

        // Properties
        System.Type ServiceType { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000191
        public System.Void .ctor(System.Type serviceType) { }

    }

    // TypeToken: 0x2000042
    public interface IAsyncService
    {
        // Properties
        System.Boolean IsLoaded { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000043
    public abstract class SRDependencyServiceBase`1 : SRF.Service.SRServiceBase`1, SRF.Service.IAsyncService
    {
        // Fields
        private System.Boolean _isLoaded;  // 0x0

        // Properties
        System.Type[] Dependencies { get; /* RVA: -1  // abstract */ }
        System.Boolean IsLoaded { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000197
        private System.Void Log(System.String msg, UnityEngine.Object target) { }
        // RVA: -1  // not resolved  token: 0x6000198
        protected virtual System.Void Start() { }
        // RVA: -1  // not resolved  token: 0x6000199
        protected virtual System.Void OnLoaded() { }
        // RVA: -1  // not resolved  token: 0x600019A
        private System.Collections.IEnumerator LoadDependencies() { }
        // RVA: -1  // not resolved  token: 0x600019B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public abstract class SRSceneServiceBase`2 : SRF.Service.SRServiceBase`1, SRF.Service.IAsyncService
    {
        // Fields
        private TImpl _rootObject;  // 0x0

        // Properties
        System.String SceneName { get; /* RVA: -1  // abstract */ }
        TImpl RootObject { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsLoaded { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001A5
        private System.Void Log(System.String msg, UnityEngine.Object target) { }
        // RVA: -1  // not resolved  token: 0x60001A6
        protected virtual System.Void Start() { }
        // RVA: -1  // not resolved  token: 0x60001A7
        protected virtual System.Void OnDestroy() { }
        // RVA: -1  // not resolved  token: 0x60001A8
        protected virtual System.Void OnLoaded() { }
        // RVA: -1  // not resolved  token: 0x60001A9
        private System.Collections.IEnumerator LoadCoroutine() { }
        // RVA: -1  // not resolved  token: 0x60001AA
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public abstract class SRServiceBase`1 : SRF.SRMonoBehaviourEx
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60001B1
        protected virtual System.Void Awake() { }
        // RVA: -1  // not resolved  token: 0x60001B2
        protected virtual System.Void OnDestroy() { }
        // RVA: -1  // not resolved  token: 0x60001B3
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000048  // size: 0x58
    public class SRServiceManager : SRF.Components.SRAutoSingleton`1
    {
        // Fields
        public static System.Boolean EnableLogging;  // const
        public static System.Int32 LoadingCount;  // static @ 0x0
        private static readonly System.Collections.Generic.List<System.Reflection.Assembly> _assemblies;  // static @ 0x8
        private readonly SRF.SRList<SRF.Service.SRServiceManager.Service> _services;  // 0x48
        private System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> _serviceStubs;  // 0x50
        private static System.Boolean _hasQuit;  // static @ 0x10

        // Properties
        System.Boolean IsLoading { get; /* RVA: 0x096CBAA0 */ }

        // Methods
        // RVA: -1  // generic def  token: 0x60001B4
        public static System.Void RegisterAssembly() { }
        // RVA: -1  // generic def  token: 0x60001B6
        public static T GetService() { }
        // RVA: 0x096CB8A8  token: 0x60001B7
        public static System.Object GetService(System.Type t) { }
        // RVA: 0x02CD72B0  token: 0x60001B8
        private static System.Object GetServiceInternal(System.Type t) { }
        // RVA: -1  // generic def  token: 0x60001B9
        public static System.Boolean HasService() { }
        // RVA: 0x02CD7410  token: 0x60001BA
        public static System.Boolean HasService(System.Type t) { }
        // RVA: -1  // generic def  token: 0x60001BB
        public static System.Void RegisterService(System.Object service) { }
        // RVA: 0x02CD6FF0  token: 0x60001BC
        private static System.Void RegisterService(System.Type t, System.Object service) { }
        // RVA: -1  // generic def  token: 0x60001BD
        public static System.Void UnRegisterService() { }
        // RVA: 0x02CD7E10  token: 0x60001BE
        private static System.Void UnRegisterService(System.Type t) { }
        // RVA: 0x0268DE30  token: 0x60001BF
        protected virtual System.Void Awake() { }
        // RVA: 0x02840F80  token: 0x60001C0
        protected System.Void UpdateStubs() { }
        // RVA: 0x02CD7540  token: 0x60001C1
        protected System.Object AutoCreateService(System.Type t) { }
        // RVA: 0x096CBA28  token: 0x60001C2
        protected System.Void OnApplicationQuit() { }
        // RVA: 0x02CD7C60  token: 0x60001C3
        private static System.Object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType) { }
        // RVA: 0x028420A0  token: 0x60001C4
        private System.Void ScanType(System.Type type) { }
        // RVA: 0x028421D0  token: 0x60001C5
        private static System.Void ScanTypeForSelectors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs) { }
        // RVA: 0x02842530  token: 0x60001C6
        private static System.Void ScanTypeForConstructors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs) { }
        // RVA: 0x028426F0  token: 0x60001C7
        private static System.Reflection.MethodInfo[] GetStaticMethods(System.Type t) { }
        // RVA: 0x03C973E0  token: 0x60001C8
        public System.Void .ctor() { }
        // RVA: 0x03CB6850  token: 0x60001C9
        private static System.Void .cctor() { }

    }

}

namespace SRF.UI
{

    // TypeToken: 0x200001C  // size: 0x28
    public class ContentFitText : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement
    {
        // Fields
        public SRF.UI.SRText CopySource;  // 0x18
        public UnityEngine.Vector2 Padding;  // 0x20

        // Properties
        System.Single minWidth { get; /* RVA: 0x096C5B78 */ }
        System.Single preferredWidth { get; /* RVA: 0x096C5C80 */ }
        System.Single flexibleWidth { get; /* RVA: 0x096C5A74 */ }
        System.Single minHeight { get; /* RVA: 0x096C5AF4 */ }
        System.Single preferredHeight { get; /* RVA: 0x096C5BFC */ }
        System.Single flexibleHeight { get; /* RVA: 0x096C59F4 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x096C5814  token: 0x60000D2
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x096C5814  token: 0x60000D3
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x096C58D0  token: 0x60000D4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096C582C  token: 0x60000D5
        private System.Void CopySourceOnLayoutDirty(SRF.UI.SRText srText) { }
        // RVA: 0x096C582C  token: 0x60000D6
        protected virtual System.Void OnTransformParentChanged() { }
        // RVA: 0x096C5834  token: 0x60000D7
        protected virtual System.Void OnDisable() { }
        // RVA: 0x096C582C  token: 0x60000D8
        protected virtual System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x096C582C  token: 0x60000D9
        protected virtual System.Void OnBeforeTransformParentChanged() { }
        // RVA: 0x096C596C  token: 0x60000DA
        protected System.Void SetDirty() { }
        // RVA: 0x0426FE60  token: 0x60000DB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x38
    public class CopyLayoutElement : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement
    {
        // Fields
        public System.Boolean CopyMinHeight;  // 0x18
        public System.Boolean CopyMinWidth;  // 0x19
        public System.Boolean CopyPreferredHeight;  // 0x1a
        public System.Boolean CopyPreferredWidth;  // 0x1b
        public UnityEngine.RectTransform CopySource;  // 0x20
        public System.Single PaddingMinHeight;  // 0x28
        public System.Single PaddingMinWidth;  // 0x2c
        public System.Single PaddingPreferredHeight;  // 0x30
        public System.Single PaddingPreferredWidth;  // 0x34

        // Properties
        System.Single preferredWidth { get; /* RVA: 0x096C5E9C */ }
        System.Single preferredHeight { get; /* RVA: 0x096C5E14 */ }
        System.Single minWidth { get; /* RVA: 0x096C5D8C */ }
        System.Single minHeight { get; /* RVA: 0x096C5D04 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x02102C70 */ }
        System.Single flexibleHeight { get; /* RVA: 0x03D751A0 */ }
        System.Single flexibleWidth { get; /* RVA: 0x03D751A0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000E3
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x0350B670  token: 0x60000E4
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x0426FE60  token: 0x60000E5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E  // size: 0x48
    public class CopyPreferredSize : UnityEngine.UI.LayoutElement
    {
        // Fields
        public UnityEngine.RectTransform CopySource;  // 0x38
        public System.Single PaddingHeight;  // 0x40
        public System.Single PaddingWidth;  // 0x44

        // Properties
        System.Single preferredWidth { get; /* RVA: 0x096C5FA4 */ }
        System.Single preferredHeight { get; /* RVA: 0x096C5F24 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x031659B0  token: 0x60000E9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x48
    public class CopyPreferredSizes : UnityEngine.UI.LayoutElement
    {
        // Fields
        public SRF.UI.CopyPreferredSizes.CopySource[] CopySources;  // 0x38
        public SRF.UI.CopyPreferredSizes.Operations Operation;  // 0x40

        // Properties
        System.Single preferredWidth { get; /* RVA: 0x096C61AC */ }
        System.Single preferredHeight { get; /* RVA: 0x096C6024 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x031659B0  token: 0x60000ED
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x50
    public class CopySizeIntoLayoutElement : UnityEngine.UI.LayoutElement
    {
        // Fields
        public UnityEngine.RectTransform CopySource;  // 0x38
        public System.Single PaddingHeight;  // 0x40
        public System.Single PaddingWidth;  // 0x44
        public System.Boolean SetPreferredSize;  // 0x48
        public System.Boolean SetMinimumSize;  // 0x49

        // Properties
        System.Single preferredWidth { get; /* RVA: 0x096C6508 */ }
        System.Single preferredHeight { get; /* RVA: 0x096C646C */ }
        System.Single minWidth { get; /* RVA: 0x096C63D0 */ }
        System.Single minHeight { get; /* RVA: 0x096C6334 */ }
        System.Int32 layoutPriority { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x031659B0  token: 0x60000F4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x48
    public class DragHandle : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler
    {
        // Fields
        private UnityEngine.UI.CanvasScaler _canvasScaler;  // 0x18
        private System.Single _delta;  // 0x20
        private System.Single _startValue;  // 0x24
        public UnityEngine.RectTransform.Axis Axis;  // 0x28
        public System.Boolean Invert;  // 0x2c
        public System.Single MaxSize;  // 0x30
        public UnityEngine.UI.LayoutElement TargetLayoutElement;  // 0x38
        public UnityEngine.RectTransform TargetRectTransform;  // 0x40

        // Properties
        System.Single Mult { get; /* RVA: 0x096C6CD8 */ }

        // Methods
        // RVA: 0x096C68BC  token: 0x60000F6
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C68EC  token: 0x60000F7
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C6A1C  token: 0x60000F8
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C6BBC  token: 0x60000F9
        private System.Void Start() { }
        // RVA: 0x096C6C0C  token: 0x60000FA
        private System.Boolean Verify() { }
        // RVA: 0x096C66F8  token: 0x60000FB
        private System.Single GetCurrentValue() { }
        // RVA: 0x096C6A74  token: 0x60000FC
        private System.Void SetCurrentValue(System.Single value) { }
        // RVA: 0x096C65F8  token: 0x60000FD
        private System.Void CommitCurrentValue() { }
        // RVA: 0x096C6834  token: 0x60000FE
        private System.Single GetMinSize() { }
        // RVA: 0x096C6818  token: 0x60000FF
        private System.Single GetMaxSize() { }
        // RVA: 0x096C6CC8  token: 0x6000100
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000024  // size: 0x50
    public class FlashGraphic : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler
    {
        // Fields
        public System.Single DecayTime;  // 0x18
        public UnityEngine.Color DefaultColor;  // 0x1c
        public UnityEngine.Color FlashColor;  // 0x2c
        public UnityEngine.UI.Graphic Target;  // 0x40
        private System.Boolean _isHoldingUntilNextPress;  // 0x48

        // Methods
        // RVA: 0x096C6DF8  token: 0x6000101
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C6E40  token: 0x6000102
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C6DB4  token: 0x6000103
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096C6D3C  token: 0x6000104
        public System.Void Flash() { }
        // RVA: 0x096C6CF4  token: 0x6000105
        public System.Void FlashAndHoldUntilNextPress() { }
        // RVA: 0x096C6E8C  token: 0x6000106
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x58
    public class InheritColour : SRF.SRMonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Graphic _graphic;  // 0x48
        public UnityEngine.UI.Graphic From;  // 0x50

        // Properties
        UnityEngine.UI.Graphic Graphic { get; /* RVA: 0x096C7A48 */ }

        // Methods
        // RVA: 0x096C7990  token: 0x6000108
        private System.Void Refresh() { }
        // RVA: 0x096C7A40  token: 0x6000109
        private System.Void Update() { }
        // RVA: 0x096C7A40  token: 0x600010A
        private System.Void Start() { }
        // RVA: 0x0426FE60  token: 0x600010B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x1A8
    public class LongPressButton : UnityEngine.UI.Button
    {
        // Fields
        private System.Boolean _handled;  // 0x188
        private UnityEngine.UI.Button.ButtonClickedEvent _onLongPress;  // 0x190
        private System.Boolean _pressed;  // 0x198
        private System.Single _pressedTime;  // 0x19c
        public System.Single LongPressDuration;  // 0x1a0

        // Properties
        UnityEngine.UI.Button.ButtonClickedEvent onLongPress { get; /* RVA: 0x03D56B70 */ set; /* RVA: 0x04275BAC */ }

        // Methods
        // RVA: 0x096C7B58  token: 0x600010E
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C7B04  token: 0x600010F
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C7B78  token: 0x6000110
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C7AF0  token: 0x6000111
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096C7BA8  token: 0x6000112
        private System.Void Update() { }
        // RVA: 0x096C7C00  token: 0x6000113
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x50
    public abstract class ResponsiveBase : SRF.SRMonoBehaviour
    {
        // Fields
        private System.Boolean _queueRefresh;  // 0x48

        // Properties
        UnityEngine.RectTransform RectTransform { get; /* RVA: 0x096C9210 */ }

        // Methods
        // RVA: 0x03D73A50  token: 0x6000115
        protected System.Void OnEnable() { }
        // RVA: 0x03D73A50  token: 0x6000116
        protected System.Void OnRectTransformDimensionsChange() { }
        // RVA: 0x096C91E8  token: 0x6000117
        protected System.Void Update() { }
        // RVA: -1  // abstract  token: 0x6000118
        protected virtual System.Void Refresh() { }
        // RVA: 0x095F8FC0  token: 0x6000119
        private System.Void DoRefresh() { }
        // RVA: 0x0426FE60  token: 0x600011A
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000028  // size: 0x58
    public class ResponsiveEnable : SRF.UI.ResponsiveBase
    {
        // Fields
        public SRF.UI.ResponsiveEnable.Entry[] Entries;  // 0x50

        // Methods
        // RVA: 0x096C9260  token: 0x600011B
        protected virtual System.Void Refresh() { }
        // RVA: 0x096C94DC  token: 0x600011C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x58
    public class ResponsiveResize : SRF.UI.ResponsiveBase
    {
        // Fields
        public SRF.UI.ResponsiveResize.Element[] Elements;  // 0x50

        // Methods
        // RVA: 0x096C952C  token: 0x600011D
        protected virtual System.Void Refresh() { }
        // RVA: 0x096C96D8  token: 0x600011E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x30
    public class ScrollToBottomBehaviour : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.ScrollRect _scrollRect;  // 0x18
        private UnityEngine.CanvasGroup _canvasGroup;  // 0x20
        private System.Boolean _scrollToTop;  // 0x28

        // Methods
        // RVA: 0x096CBFB0  token: 0x600011F
        public System.Void Start() { }
        // RVA: 0x096CBE78  token: 0x6000120
        private System.Void OnEnable() { }
        // RVA: 0x096CC10C  token: 0x6000121
        public System.Void Trigger() { }
        // RVA: 0x096CBE78  token: 0x6000122
        private System.Void OnScrollRectValueChanged(UnityEngine.Vector2 position) { }
        // RVA: 0x096CBE80  token: 0x6000123
        private System.Void Refresh() { }
        // RVA: 0x096CBF24  token: 0x6000124
        private System.Void SetVisible(System.Boolean truth) { }
        // RVA: 0x0426FE60  token: 0x6000125
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002F  // size: 0x1A8
    public class SRNumberButton : UnityEngine.UI.Button, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler
    {
        // Fields
        private static System.Single ExtraThreshold;  // const
        public static System.Single Delay;  // const
        private System.Single _delayTime;  // 0x188
        private System.Single _downTime;  // 0x18c
        private System.Boolean _isDown;  // 0x190
        public System.Double Amount;  // 0x198
        public SRF.UI.SRNumberSpinner TargetField;  // 0x1a0

        // Methods
        // RVA: 0x096CAFF4  token: 0x6000126
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CB044  token: 0x6000127
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CB064  token: 0x6000128
        protected virtual System.Void Update() { }
        // RVA: 0x096CAEF4  token: 0x6000129
        private System.Void Apply() { }
        // RVA: 0x096CB0F0  token: 0x600012A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x2D0
    public class SRNumberSpinner : UnityEngine.UI.InputField
    {
        // Fields
        private System.Double _currentValue;  // 0x2a0
        private System.Double _dragStartAmount;  // 0x2a8
        private System.Double _dragStep;  // 0x2b0
        public System.Single DragSensitivity;  // 0x2b8
        public System.Double MaxValue;  // 0x2c0
        public System.Double MinValue;  // 0x2c8

        // Methods
        // RVA: 0x096CB108  token: 0x600012B
        protected virtual System.Void Awake() { }
        // RVA: 0x096CB53C  token: 0x600012C
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0350B670  token: 0x600012D
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0350B670  token: 0x600012E
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CB184  token: 0x600012F
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CB388  token: 0x6000130
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CB4F0  token: 0x6000131
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CB624  token: 0x6000132
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0x58
    public class SRRetinaScaler : SRF.SRMonoBehaviour
    {
        // Fields
        private System.Boolean _disablePixelPerfect;  // 0x48
        private System.Int32 _designDpi;  // 0x4c
        private System.Single _lastDpi;  // 0x50

        // Methods
        // RVA: 0x096CB860  token: 0x6000133
        private System.Void Start() { }
        // RVA: 0x096CB778  token: 0x6000134
        private System.Void ApplyScaling() { }
        // RVA: 0x096CB868  token: 0x6000135
        private System.Void Update() { }
        // RVA: 0x096CB898  token: 0x6000136
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x1A0
    public class SRSpinner : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler
    {
        // Fields
        private System.Single _dragDelta;  // 0x180
        private SRF.UI.SRSpinner.SpinEvent _onSpinDecrement;  // 0x188
        private SRF.UI.SRSpinner.SpinEvent _onSpinIncrement;  // 0x190
        public System.Single DragThreshold;  // 0x198

        // Properties
        SRF.UI.SRSpinner.SpinEvent OnSpinIncrement { get; /* RVA: 0x03D56B70 */ set; /* RVA: 0x04275BAC */ }
        SRF.UI.SRSpinner.SpinEvent OnSpinDecrement { get; /* RVA: 0x03D56AF0 */ set; /* RVA: 0x04275C54 */ }

        // Methods
        // RVA: 0x03D75260  token: 0x600013B
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CBB34  token: 0x600013C
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CBC04  token: 0x600013D
        private System.Void OnIncrement(System.Int32 amount) { }
        // RVA: 0x096CBAE8  token: 0x600013E
        private System.Void OnDecrement(System.Int32 amount) { }
        // RVA: 0x096CBC50  token: 0x600013F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x120
    public class SRText : UnityEngine.UI.Text
    {
        // Fields
        private System.Action<SRF.UI.SRText> LayoutDirty;  // 0x118

        // Events
        event System.Action<SRF.UI.SRText> LayoutDirty;

        // Methods
        // RVA: 0x096CBD18  token: 0x6000143
        public virtual System.Void SetLayoutDirty() { }
        // RVA: 0x096CBD50  token: 0x6000144
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x88
    public class StyleComponent : SRF.SRMonoBehaviour
    {
        // Fields
        private SRF.UI.Style _activeStyle;  // 0x48
        private SRF.UI.StyleRoot _cachedRoot;  // 0x50
        private UnityEngine.UI.Graphic _graphic;  // 0x58
        private System.Boolean _hasStarted;  // 0x60
        private UnityEngine.UI.Image _image;  // 0x68
        private UnityEngine.UI.Selectable _selectable;  // 0x70
        private System.String _styleKey;  // 0x78
        public System.Boolean IgnoreImage;  // 0x80

        // Properties
        System.String StyleKey { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x096CD814 */ }

        // Methods
        // RVA: 0x096CD7F4  token: 0x6000147
        private System.Void Start() { }
        // RVA: 0x096CD5C8  token: 0x6000148
        private System.Void OnEnable() { }
        // RVA: 0x096CD5DC  token: 0x6000149
        public System.Void Refresh(System.Boolean invalidateCache) { }
        // RVA: 0x096CD478  token: 0x600014A
        private SRF.UI.StyleRoot GetStyleRoot() { }
        // RVA: 0x096CD18C  token: 0x600014B
        private System.Void ApplyStyle() { }
        // RVA: 0x096CD7A4  token: 0x600014C
        private System.Void SRStyleDirty() { }
        // RVA: 0x0426FE60  token: 0x600014D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000036  // size: 0x58
    public sealed class StyleRoot : SRF.SRMonoBehaviour
    {
        // Fields
        private SRF.UI.StyleSheet _activeStyleSheet;  // 0x48
        public SRF.UI.StyleSheet StyleSheet;  // 0x50

        // Methods
        // RVA: 0x096CD83C  token: 0x600014E
        public SRF.UI.Style GetStyle(System.String key) { }
        // RVA: 0x096CD900  token: 0x600014F
        private System.Void OnEnable() { }
        // RVA: 0x096CD8F8  token: 0x6000150
        private System.Void OnDisable() { }
        // RVA: 0x096CD9C4  token: 0x6000151
        private System.Void Update() { }
        // RVA: 0x096CD970  token: 0x6000152
        private System.Void OnStyleSheetChanged() { }
        // RVA: 0x05D6CFCC  token: 0x6000153
        public System.Void SetDirty() { }
        // RVA: 0x0426FE60  token: 0x6000154
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x58
    public class Style
    {
        // Fields
        public UnityEngine.Color ActiveColor;  // 0x10
        public UnityEngine.Color DisabledColor;  // 0x20
        public UnityEngine.Color HoverColor;  // 0x30
        public UnityEngine.Sprite Image;  // 0x40
        public UnityEngine.Color NormalColor;  // 0x48

        // Methods
        // RVA: 0x096CDC30  token: 0x6000155
        public SRF.UI.Style Copy() { }
        // RVA: 0x096CDBD4  token: 0x6000156
        public System.Void CopyFrom(SRF.UI.Style style) { }
        // RVA: 0x096CDC9C  token: 0x6000157
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000038  // size: 0x30
    public class StyleSheet : UnityEngine.ScriptableObject
    {
        // Fields
        private System.Collections.Generic.List<System.String> _keys;  // 0x18
        private System.Collections.Generic.List<SRF.UI.Style> _styles;  // 0x20
        public SRF.UI.StyleSheet Parent;  // 0x28

        // Methods
        // RVA: 0x096CDA34  token: 0x6000158
        public SRF.UI.Style GetStyle(System.String key, System.Boolean searchParent) { }
        // RVA: 0x096CDB0C  token: 0x6000159
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x50
    public sealed class Unselectable : SRF.SRMonoBehaviour, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        // Fields
        private System.Boolean _suspectedSelected;  // 0x48

        // Methods
        // RVA: 0x03D73A50  token: 0x600015A
        public virtual System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        // RVA: 0x096CF2B0  token: 0x600015B
        private System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x600015C
        public System.Void .ctor() { }

    }

}

namespace SRF.UI.Layout
{

    // TypeToken: 0x200003A  // size: 0x70
    public class FlowLayoutGroup : UnityEngine.UI.LayoutGroup
    {
        // Fields
        private readonly System.Collections.Generic.IList<UnityEngine.RectTransform> _rowList;  // 0x58
        private System.Single _layoutHeight;  // 0x60
        public System.Boolean ChildForceExpandHeight;  // 0x64
        public System.Boolean ChildForceExpandWidth;  // 0x65
        public System.Single Spacing;  // 0x68

        // Properties
        System.Boolean IsCenterAlign { get; /* RVA: 0x096C78E4 */ }
        System.Boolean IsRightAlign { get; /* RVA: 0x096C792C */ }
        System.Boolean IsMiddleAlign { get; /* RVA: 0x096C7914 */ }
        System.Boolean IsLowerAlign { get; /* RVA: 0x096C78FC */ }

        // Methods
        // RVA: 0x096C6EC8  token: 0x6000161
        public virtual System.Void CalculateLayoutInputHorizontal() { }
        // RVA: 0x096C7384  token: 0x6000162
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x096C73D0  token: 0x6000163
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x096C6F4C  token: 0x6000164
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x096C741C  token: 0x6000165
        public System.Single SetLayout(System.Single width, System.Int32 axis, System.Boolean layoutInput) { }
        // RVA: 0x096C6FA0  token: 0x6000166
        private System.Single CalculateRowVerticalOffset(System.Single groupHeight, System.Single yOffset, System.Single currentRowHeight) { }
        // RVA: 0x096C70B4  token: 0x6000167
        protected System.Void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, System.Single rowWidth, System.Single rowHeight, System.Single maxWidth, System.Single xOffset, System.Single yOffset, System.Int32 axis) { }
        // RVA: 0x096C7024  token: 0x6000168
        public System.Single GetGreatestMinimumChildWidth() { }
        // RVA: 0x096C7864  token: 0x6000169
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public interface IVirtualView
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600016A
        public virtual System.Void SetDataContext(System.Object data) { }

    }

    // TypeToken: 0x200003C  // size: 0xE8
    public class VirtualVerticalLayoutGroup : UnityEngine.UI.LayoutGroup, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        // Fields
        private readonly SRF.SRList<System.Object> _itemList;  // 0x58
        private readonly SRF.SRList<System.Int32> _visibleItemList;  // 0x60
        private System.Boolean _isDirty;  // 0x68
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _rowCache;  // 0x70
        private UnityEngine.UI.ScrollRect _scrollRect;  // 0x78
        private System.Int32 _selectedIndex;  // 0x80
        private System.Object _selectedItem;  // 0x88
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent _selectedItemChanged;  // 0x90
        private System.Int32 _visibleItemCount;  // 0x98
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _visibleRows;  // 0xa0
        public SRF.UI.StyleSheet AltRowStyleSheet;  // 0xa8
        public System.Boolean EnableSelection;  // 0xb0
        public UnityEngine.RectTransform ItemPrefab;  // 0xb8
        public System.Int32 RowPadding;  // 0xc0
        public SRF.UI.StyleSheet RowStyleSheet;  // 0xc8
        public SRF.UI.StyleSheet SelectedRowStyleSheet;  // 0xd0
        public System.Single Spacing;  // 0xd8
        public System.Boolean StickToBottom;  // 0xdc
        private System.Single _itemHeight;  // 0xe0

        // Properties
        SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent SelectedItemChanged { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x051DFCB4 */ }
        System.Object SelectedItem { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x096D0C7C */ }
        System.Single minHeight { get; /* RVA: 0x096D0BB0 */ }
        UnityEngine.UI.ScrollRect ScrollRect { get; /* RVA: 0x096D0B2C */ }
        System.Boolean AlignBottom { get; /* RVA: 0x096D09A0 */ }
        System.Boolean AlignTop { get; /* RVA: 0x096D09B8 */ }
        System.Single ItemHeight { get; /* RVA: 0x096D09D0 */ }

        // Methods
        // RVA: 0x096CFBA0  token: 0x6000170
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x096CF438  token: 0x6000171
        protected virtual System.Void Awake() { }
        // RVA: 0x096CFD10  token: 0x6000172
        private System.Void OnScrollRectValueChanged(UnityEngine.Vector2 d) { }
        // RVA: 0x096D079C  token: 0x6000173
        protected virtual System.Void Start() { }
        // RVA: 0x096CFB80  token: 0x6000174
        protected virtual System.Void OnEnable() { }
        // RVA: 0x096D07A4  token: 0x6000175
        protected System.Void Update() { }
        // RVA: 0x096CFA58  token: 0x6000176
        protected System.Void InvalidateItem(System.Int32 itemIndex) { }
        // RVA: 0x096CFFAC  token: 0x6000177
        protected System.Void RefreshIndexCache() { }
        // RVA: 0x096D0130  token: 0x6000178
        protected System.Void ScrollUpdate() { }
        // RVA: 0x096CF5A0  token: 0x6000179
        public virtual System.Void CalculateLayoutInputVertical() { }
        // RVA: 0x096D04AC  token: 0x600017A
        public virtual System.Void SetLayoutHorizontal() { }
        // RVA: 0x096D0658  token: 0x600017B
        public virtual System.Void SetLayoutVertical() { }
        // RVA: 0x096D0480  token: 0x600017C
        private System.Void SetDirty() { }
        // RVA: 0x096CF378  token: 0x600017D
        public System.Void AddItem(System.Object item) { }
        // RVA: 0x096D0080  token: 0x600017E
        public System.Void RemoveItem(System.Object item) { }
        // RVA: 0x096CF5E8  token: 0x600017F
        public System.Void ClearItems() { }
        // RVA: 0x096CF89C  token: 0x6000184
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row GetRow(System.Int32 forIndex) { }
        // RVA: 0x096CFF58  token: 0x6000185
        private System.Void RecycleRow(SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row) { }
        // RVA: 0x096CFD68  token: 0x6000186
        private System.Void PopulateRow(System.Int32 index, SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row) { }
        // RVA: 0x096CF69C  token: 0x6000187
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row CreateRow() { }
        // RVA: 0x096D0880  token: 0x6000188
        public System.Void .ctor() { }

    }

}

