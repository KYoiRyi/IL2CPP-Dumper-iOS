// ========================================================
// Dumped by @desirepro
// Assembly: StompyRobot.SRF.dll
// Classes:  90
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

CLASS: SRDebugUtil
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    LineBufferCount  // const
  private   static  System.Boolean                  <IsFixedUpdate>k__BackingField  // static @ 0x0
PROPERTIES:
  IsFixedUpdate  get=0x096C99B4  set=0x096C99EC
METHODS:
  RVA=0x096C9728  token=0x6000003  System.Void AssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance)
  RVA=0x096C98AC  token=0x6000004  System.Void Assert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance)
  RVA=0x096C99A4  token=0x6000005  System.Void EditorAssertNotNull(System.Object value, System.String message, UnityEngine.MonoBehaviour instance)
  RVA=0x096C99AC  token=0x6000006  System.Void EditorAssert(System.Boolean condition, System.String message, UnityEngine.MonoBehaviour instance)
END_CLASS

CLASS: SRFileUtil
TYPE:  static class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096CA008  token=0x6000007  System.Void DeleteDirectory(System.String path)
  RVA=0x0315D010  token=0x6000008  System.String GetBytesReadable(System.Int64 i)
END_CLASS

CLASS: SRInstantiate
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000009  T Instantiate(T prefab)
  RVA=0x096CA09C  token=0x600000A  UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab)
  RVA=-1  // generic def  token=0x600000B  T Instantiate(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
END_CLASS

CLASS: EaseType
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRMath.EaseType                 Linear  // const
  public    static  SRMath.EaseType                 QuadEaseOut  // const
  public    static  SRMath.EaseType                 QuadEaseIn  // const
  public    static  SRMath.EaseType                 QuadEaseInOut  // const
  public    static  SRMath.EaseType                 QuadEaseOutIn  // const
  public    static  SRMath.EaseType                 ExpoEaseOut  // const
  public    static  SRMath.EaseType                 ExpoEaseIn  // const
  public    static  SRMath.EaseType                 ExpoEaseInOut  // const
  public    static  SRMath.EaseType                 ExpoEaseOutIn  // const
  public    static  SRMath.EaseType                 CubicEaseOut  // const
  public    static  SRMath.EaseType                 CubicEaseIn  // const
  public    static  SRMath.EaseType                 CubicEaseInOut  // const
  public    static  SRMath.EaseType                 CubicEaseOutIn  // const
  public    static  SRMath.EaseType                 QuartEaseOut  // const
  public    static  SRMath.EaseType                 QuartEaseIn  // const
  public    static  SRMath.EaseType                 QuartEaseInOut  // const
  public    static  SRMath.EaseType                 QuartEaseOutIn  // const
  public    static  SRMath.EaseType                 QuintEaseOut  // const
  public    static  SRMath.EaseType                 QuintEaseIn  // const
  public    static  SRMath.EaseType                 QuintEaseInOut  // const
  public    static  SRMath.EaseType                 QuintEaseOutIn  // const
  public    static  SRMath.EaseType                 CircEaseOut  // const
  public    static  SRMath.EaseType                 CircEaseIn  // const
  public    static  SRMath.EaseType                 CircEaseInOut  // const
  public    static  SRMath.EaseType                 CircEaseOutIn  // const
  public    static  SRMath.EaseType                 SineEaseOut  // const
  public    static  SRMath.EaseType                 SineEaseIn  // const
  public    static  SRMath.EaseType                 SineEaseInOut  // const
  public    static  SRMath.EaseType                 SineEaseOutIn  // const
  public    static  SRMath.EaseType                 ElasticEaseOut  // const
  public    static  SRMath.EaseType                 ElasticEaseIn  // const
  public    static  SRMath.EaseType                 ElasticEaseInOut  // const
  public    static  SRMath.EaseType                 ElasticEaseOutIn  // const
  public    static  SRMath.EaseType                 BounceEaseOut  // const
  public    static  SRMath.EaseType                 BounceEaseIn  // const
  public    static  SRMath.EaseType                 BounceEaseInOut  // const
  public    static  SRMath.EaseType                 BounceEaseOutIn  // const
  public    static  SRMath.EaseType                 BackEaseOut  // const
  public    static  SRMath.EaseType                 BackEaseIn  // const
  public    static  SRMath.EaseType                 BackEaseInOut  // const
  public    static  SRMath.EaseType                 BackEaseOutIn  // const
METHODS:
END_CLASS

CLASS: TweenFunctions
TYPE:  static class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096CE8CC  token=0x600001B  System.Single Linear(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE864  token=0x600001C  System.Single ExpoEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE7A4  token=0x600001D  System.Single ExpoEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE6F4  token=0x600001E  System.Single ExpoEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE804  token=0x600001F  System.Single ExpoEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE254  token=0x6000020  System.Single CircEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE15C  token=0x6000021  System.Single CircEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE0C8  token=0x6000022  System.Single CircEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE1B8  token=0x6000023  System.Single CircEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE9D0  token=0x6000024  System.Single QuadEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE93C  token=0x6000025  System.Single QuadEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE8DC  token=0x6000026  System.Single QuadEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE954  token=0x6000027  System.Single QuadEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEE70  token=0x6000028  System.Single SineEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CED78  token=0x6000029  System.Single SineEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CECE4  token=0x600002A  System.Single SineEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEDC4  token=0x600002B  System.Single SineEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE3BC  token=0x600002C  System.Single CubicEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE310  token=0x600002D  System.Single CubicEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE2A0  token=0x600002E  System.Single CubicEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE32C  token=0x600002F  System.Single CubicEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEB34  token=0x6000030  System.Single QuartEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEA74  token=0x6000031  System.Single QuartEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE9F4  token=0x6000032  System.Single QuartEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEA94  token=0x6000033  System.Single QuartEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CECB0  token=0x6000034  System.Single QuintEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEBEC  token=0x6000035  System.Single QuintEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEB6C  token=0x6000036  System.Single QuintEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CEC10  token=0x6000037  System.Single QuintEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE634  token=0x6000038  System.Single ElasticEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE508  token=0x6000039  System.Single ElasticEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE3E8  token=0x600003A  System.Single ElasticEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE5D4  token=0x600003B  System.Single ElasticEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CE008  token=0x600003C  System.Single BounceEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDF2C  token=0x600003D  System.Single BounceEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDE94  token=0x600003E  System.Single BounceEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDF78  token=0x600003F  System.Single BounceEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDE58  token=0x6000040  System.Single BackEaseOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDD7C  token=0x6000041  System.Single BackEaseIn(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDCF4  token=0x6000042  System.Single BackEaseInOut(System.Single t, System.Single b, System.Single c, System.Single d)
  RVA=0x096CDDA8  token=0x6000043  System.Single BackEaseOutIn(System.Single t, System.Single b, System.Single c, System.Single d)
END_CLASS

CLASS: SRMath
TYPE:  static class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D75240  token=0x600000C  System.Single LerpUnclamped(System.Single from, System.Single to, System.Single t)
  RVA=0x03D751E0  token=0x600000D  UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t)
  RVA=0x096CA840  token=0x600000E  System.Single FacingNormalized(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2)
  RVA=0x096CABC8  token=0x600000F  System.Single WrapAngle(System.Single angle)
  RVA=0x096CA8B0  token=0x6000010  System.Single NearestAngle(System.Single to, System.Single angle1, System.Single angle2)
  RVA=0x096CABF0  token=0x6000011  System.Int32 Wrap(System.Int32 max, System.Int32 value)
  RVA=0x096CAC84  token=0x6000012  System.Single Wrap(System.Single max, System.Single value)
  RVA=0x03D751D0  token=0x6000013  System.Single Average(System.Single v1, System.Single v2)
  RVA=0x096CA0F0  token=0x6000014  System.Single Angle(UnityEngine.Vector2 direction)
  RVA=0x096CA1B4  token=0x6000015  System.Single Ease(System.Single from, System.Single to, System.Single t, SRMath.EaseType type)
  RVA=0x096CAB00  token=0x6000016  System.Single SpringLerp(System.Single strength, System.Single deltaTime)
  RVA=0x096CAAC0  token=0x6000017  System.Single SpringLerp(System.Single from, System.Single to, System.Single strength, System.Single deltaTime)
  RVA=0x096CAA38  token=0x6000018  UnityEngine.Vector3 SpringLerp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single strength, System.Single deltaTime)
  RVA=0x096CAB50  token=0x6000019  UnityEngine.Quaternion SpringLerp(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single strength, System.Single deltaTime)
  RVA=0x096CA920  token=0x600001A  System.Single SmoothClamp(System.Single value, System.Single min, System.Single max, System.Single scrollMax, SRMath.EaseType easeType)
END_CLASS

CLASS: TOKEN
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRF.Json.Parser.TOKEN           NONE  // const
  public    static  SRF.Json.Parser.TOKEN           CURLY_OPEN  // const
  public    static  SRF.Json.Parser.TOKEN           CURLY_CLOSE  // const
  public    static  SRF.Json.Parser.TOKEN           SQUARED_OPEN  // const
  public    static  SRF.Json.Parser.TOKEN           SQUARED_CLOSE  // const
  public    static  SRF.Json.Parser.TOKEN           COLON  // const
  public    static  SRF.Json.Parser.TOKEN           COMMA  // const
  public    static  SRF.Json.Parser.TOKEN           STRING  // const
  public    static  SRF.Json.Parser.TOKEN           NUMBER  // const
  public    static  SRF.Json.Parser.TOKEN           TRUE  // const
  public    static  SRF.Json.Parser.TOKEN           FALSE  // const
  public    static  SRF.Json.Parser.TOKEN           NULL  // const
METHODS:
END_CLASS

CLASS: Parser
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.String                   WORD_BREAK  // const
  private           System.IO.StringReader          json  // 0x10
PROPERTIES:
  PeekChar  get=0x096C8974
  NextChar  get=0x096C8644
  NextWord  get=0x096C88C4
  NextToken  get=0x096C86A0
METHODS:
  RVA=0x096C85CC  token=0x6000046  System.Void .ctor(System.String jsonString)
  RVA=0x087C8320  token=0x600004B  System.Void Dispose()
  RVA=0x096C7EC0  token=0x600004C  System.Boolean IsWordBreak(System.Char c)
  RVA=0x096C84D4  token=0x600004D  System.Object Parse(System.String jsonString)
  RVA=0x096C8178  token=0x600004E  System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject()
  RVA=0x096C7F38  token=0x600004F  System.Collections.Generic.List<System.Object> ParseArray()
  RVA=0x096C84B0  token=0x6000050  System.Object ParseValue()
  RVA=0x096C8000  token=0x6000051  System.Object ParseByToken(SRF.Json.Parser.TOKEN token)
  RVA=0x096C8284  token=0x6000052  System.String ParseString()
  RVA=0x096C80B4  token=0x6000053  System.Object ParseNumber()
  RVA=0x096C7E30  token=0x6000054  System.Void EatWhitespace()
END_CLASS

CLASS: Serializer
TYPE:  sealed class
TOKEN: 0x200000B
SIZE:  0x18
FIELDS:
  private           System.Text.StringBuilder       builder  // 0x10
METHODS:
  RVA=0x096CCFE8  token=0x6000055  System.Void .ctor()
  RVA=0x096CCF70  token=0x6000056  System.String Serialize(System.Object obj)
  RVA=0x096CCDEC  token=0x6000057  System.Void SerializeValue(System.Object value)
  RVA=0x096CC50C  token=0x6000058  System.Void SerializeObject(System.Collections.IDictionary obj)
  RVA=0x096CC188  token=0x6000059  System.Void SerializeArray(System.Collections.IList anArray)
  RVA=0x096CCB74  token=0x600005A  System.Void SerializeString(System.String str)
  RVA=0x096CC914  token=0x600005B  System.Void SerializeOther(System.Object value)
END_CLASS

CLASS: <GetEnumerator>d__15
TYPE:  sealed class
TOKEN: 0x200000D
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           T                               <>2__current  // 0x0
  public            SRF.SRList<T>                   <>4__this  // 0x0
  private           System.Int32                    <i>5__2  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<T>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600007A  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x600007B  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x600007C  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x600007E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: FieldInfo
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x30
FIELDS:
  public            System.Boolean                  AutoCreate  // 0x10
  public            System.Boolean                  AutoSet  // 0x11
  public            System.Reflection.FieldInfo     Field  // 0x18
  public            System.Boolean                  Import  // 0x20
  public            System.Type                     ImportType  // 0x28
METHODS:
END_CLASS

CLASS: <WaitForSecondsRealTime>d__0
TYPE:  sealed class
TOKEN: 0x2000014
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Single                   time  // 0x20
  private           System.Single                   <endTime>5__2  // 0x24
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000A2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000A3  System.Void System.IDisposable.Dispose()
  RVA=0x096CF200  token=0x60000A4  System.Boolean MoveNext()
  RVA=0x096CF264  token=0x60000A6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <GetChildren>d__0
TYPE:  sealed class
TOKEN: 0x200001A
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Transform           <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  private           UnityEngine.Transform           t  // 0x28
  public            UnityEngine.Transform           <>3__t  // 0x30
  private           System.Int32                    <i>5__2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x60000BE  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000BF  System.Void System.IDisposable.Dispose()
  RVA=0x096CEEAC  token=0x60000C0  System.Boolean MoveNext()
  RVA=0x096CEFC4  token=0x60000C2  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x096CEF28  token=0x60000C4  System.Collections.Generic.IEnumerator<UnityEngine.Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
  RVA=0x096CEFBC  token=0x60000C5  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Operations
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRF.UI.CopyPreferredSizes.OperationsMax  // const
  public    static  SRF.UI.CopyPreferredSizes.OperationsMin  // const
METHODS:
END_CLASS

CLASS: CopySource
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x20
FIELDS:
  public            UnityEngine.RectTransform       Rect  // 0x10
  public            System.Single                   PaddingHeight  // 0x18
  public            System.Single                   PaddingWidth  // 0x1c
METHODS:
  RVA=0x0350B670  token=0x60000EE  System.Void .ctor()
END_CLASS

CLASS: Modes
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  SRF.UI.ResponsiveEnable.Modes   EnableAbove  // const
  public    static  SRF.UI.ResponsiveEnable.Modes   EnableBelow  // const
METHODS:
END_CLASS

CLASS: Entry
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x30
FIELDS:
  public            UnityEngine.Behaviour[]         Components  // 0x10
  public            UnityEngine.GameObject[]        GameObjects  // 0x18
  public            SRF.UI.ResponsiveEnable.Modes   Mode  // 0x20
  public            System.Single                   ThresholdHeight  // 0x24
  public            System.Single                   ThresholdWidth  // 0x28
METHODS:
END_CLASS

CLASS: SizeDefinition
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x18
FIELDS:
  public            System.Single                   ElementWidth  // 0x10
  public            System.Single                   ThresholdWidth  // 0x14
METHODS:
END_CLASS

CLASS: Element
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x20
FIELDS:
  public            SRF.UI.ResponsiveResize.Element.SizeDefinition[]SizeDefinitions  // 0x10
  public            UnityEngine.RectTransform       Target  // 0x18
METHODS:
END_CLASS

CLASS: SpinEvent
TYPE:  class
TOKEN: 0x2000033
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent
FIELDS:
METHODS:
  RVA=0x04271C98  token=0x6000140  System.Void .ctor()
END_CLASS

CLASS: SelectedItemChangedEvent
TYPE:  class
TOKEN: 0x200003D
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x096CC14C  token=0x6000189  System.Void .ctor()
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x38
FIELDS:
  public            System.Object                   Data  // 0x10
  public            System.Int32                    Index  // 0x18
  public            UnityEngine.RectTransform       Rect  // 0x20
  public            SRF.UI.StyleRoot                Root  // 0x28
  public            SRF.UI.Layout.IVirtualView      View  // 0x30
METHODS:
  RVA=0x0350B670  token=0x600018A  System.Void .ctor()
END_CLASS

CLASS: <LoadDependencies>d__8
TYPE:  sealed class
TOKEN: 0x2000044
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            SRF.Service.SRDependencyServiceBase<T><>4__this  // 0x0
  private           System.Type[]                   <>7__wrap1  // 0x0
  private           System.Int32                    <>7__wrap2  // 0x0
  private           SRF.Service.IAsyncService       <a>5__4  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600019C  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x600019D  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x600019E  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60001A0  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <LoadCoroutine>d__11
TYPE:  sealed class
TOKEN: 0x2000046
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            SRF.Service.SRSceneServiceBase<T,TImpl><>4__this  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60001AB  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x60001AC  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x60001AD  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60001AF  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Service
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x20
FIELDS:
  public            System.Object                   Object  // 0x10
  public            System.Type                     Type  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001CA  System.Void .ctor()
END_CLASS

CLASS: ServiceStub
TYPE:  class
TOKEN: 0x200004A
SIZE:  0x30
FIELDS:
  public            System.Func<System.Object>      Constructor  // 0x10
  public            System.Type                     InterfaceType  // 0x18
  public            System.Func<System.Type>        Selector  // 0x20
  public            System.Type                     Type  // 0x28
METHODS:
  RVA=0x096CD04C  token=0x60001CB  System.String ToString()
  RVA=0x0350B670  token=0x60001CC  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200004B
SIZE:  0x10
FIELDS:
  public    static readonly SRF.Service.SRServiceManager.<>c<>9  // static @ 0x0
  public    static  System.Func<SRF.Service.SRServiceManager.ServiceStub,System.String><>9__21_0  // static @ 0x8
METHODS:
  RVA=0x096CF19C  token=0x60001CD  System.Void .cctor()
  RVA=0x0350B670  token=0x60001CE  System.Void .ctor()
  RVA=0x096CF010  token=0x60001CF  System.String <UpdateStubs>b__21_0(SRF.Service.SRServiceManager.ServiceStub p)
END_CLASS

CLASS: <>c__DisplayClass26_0
TYPE:  sealed class
TOKEN: 0x200004C
SIZE:  0x18
FIELDS:
  public            SRF.Service.ServiceSelectorAttributeattrib  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001D0  System.Void .ctor()
  RVA=0x03C96EB0  token=0x60001D1  System.Boolean <ScanTypeForSelectors>b__0(SRF.Service.SRServiceManager.ServiceStub p)
END_CLASS

CLASS: <>c__DisplayClass27_0
TYPE:  sealed class
TOKEN: 0x200004D
SIZE:  0x20
FIELDS:
  public            SRF.Service.ServiceConstructorAttributeattrib  // 0x10
  public            System.Reflection.MethodInfo    m  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001D2  System.Void .ctor()
  RVA=0x096CF0E8  token=0x60001D3  System.Boolean <ScanTypeForConstructors>b__0(SRF.Service.SRServiceManager.ServiceStub p)
  RVA=0x096CF158  token=0x60001D4  System.Object <ScanTypeForConstructors>b__1()
END_CLASS

CLASS: <>c__DisplayClass1_0
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x20
FIELDS:
  public            System.Reflection.MethodInfo    method  // 0x10
  public            System.Object                   target  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001D9  System.Void .ctor()
  RVA=0x096CF0BC  token=0x60001DA  System.Object <.ctor>b__0(System.Object[] o)
END_CLASS

CLASS: <>c__DisplayClass4_0
TYPE:  sealed class
TOKEN: 0x2000051
SIZE:  0x18
FIELDS:
  public            System.Action                   action  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001DB  System.Void .ctor()
  RVA=0x096CF17C  token=0x60001DC  System.Object <op_Implicit>b__0(System.Object[] args)
END_CLASS

CLASS: <>c__DisplayClass9_0`1
TYPE:  sealed class
TOKEN: 0x2000054
FIELDS:
  public            System.Action<T>                setter  // 0x0
  public            System.Func<T>                  getter  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001F0  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60001F1  System.Void <FromLambda>b__0(System.Object o)
  RVA=-1  // not resolved  token=0x60001F2  System.Object <FromLambda>b__1()
END_CLASS

CLASS: <>c__DisplayClass10_0
TYPE:  sealed class
TOKEN: 0x2000055
SIZE:  0x20
FIELDS:
  public            System.Object                   target  // 0x10
  public            System.Reflection.PropertyInfo  property  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001F3  System.Void .ctor()
  RVA=0x096CF098  token=0x60001F4  System.Object <.ctor>b__0()
  RVA=0x096CF0A8  token=0x60001F5  System.Void <.ctor>b__1(System.Object v)
END_CLASS

CLASS: <>c__23`1
TYPE:  sealed class
TOKEN: 0x2000056
FIELDS:
  public    static readonly SRF.Helpers.PropertyReference.<>c__23<T><>9  // static @ 0x0
  public    static  System.Func<System.Attribute,System.Boolean><>9__23_0  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60001F6  System.Void .cctor()
  RVA=-1  // not resolved  token=0x60001F7  System.Void .ctor()
  RVA=-1  // not resolved  token=0x60001F8  System.Boolean <GetAttribute>b__23_0(System.Attribute p)
END_CLASS

CLASS: SRF.Json
TYPE:  static class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096C7ACC  token=0x6000044  System.Object Deserialize(System.String json)
  RVA=0x096C7AE8  token=0x6000045  System.String Serialize(System.Object obj)
END_CLASS

CLASS: SRF.SRList`1
TYPE:  class
TOKEN: 0x200000C
IMPLEMENTS: System.Collections.Generic.IList`1 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           T[]                             _buffer  // 0x0
  private           System.Int32                    _count  // 0x0
  private           System.Collections.Generic.EqualityComparer<T>_equalityComparer  // 0x0
  private           System.Collections.ObjectModel.ReadOnlyCollection<T>_readOnlyWrapper  // 0x0
PROPERTIES:
  Buffer  get=-1  // not resolved  set=-1  // not resolved
  EqualityComparer  get=-1  // not resolved
  Count  get=-1  // not resolved  set=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
  Item  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600005C  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600005D  System.Void .ctor(System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600005E  System.Void .ctor(System.Collections.Generic.IEnumerable<T> source)
  RVA=-1  // not resolved  token=0x6000064  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000065  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000066  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x6000067  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000068  System.Boolean Contains(T item)
  RVA=-1  // not resolved  token=0x6000069  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x600006A  System.Boolean Remove(T item)
  RVA=-1  // not resolved  token=0x600006C  System.Int32 IndexOf(T item)
  RVA=-1  // not resolved  token=0x600006D  System.Void Insert(System.Int32 index, T item)
  RVA=-1  // not resolved  token=0x600006E  System.Void RemoveAt(System.Int32 index)
  RVA=-1  // not resolved  token=0x6000071  System.Void OnBeforeSerialize()
  RVA=-1  // not resolved  token=0x6000072  System.Void OnAfterDeserialize()
  RVA=-1  // not resolved  token=0x6000073  System.Void AddRange(System.Collections.Generic.IEnumerable<T> range)
  RVA=-1  // not resolved  token=0x6000074  System.Void Clear(System.Boolean clean)
  RVA=-1  // not resolved  token=0x6000075  System.Void Clean()
  RVA=-1  // not resolved  token=0x6000076  System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
  RVA=-1  // not resolved  token=0x6000077  System.Void Expand()
  RVA=-1  // not resolved  token=0x6000078  System.Void Trim()
  RVA=-1  // not resolved  token=0x6000079  System.Void Sort(System.Comparison<T> comparer)
END_CLASS

CLASS: SRF.SRMonoBehaviour
TYPE:  abstract class
TOKEN: 0x200000E
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.Collider            _collider  // 0x18
  private           UnityEngine.Transform           _transform  // 0x20
  private           UnityEngine.Rigidbody           _rigidBody  // 0x28
  private           UnityEngine.GameObject          _gameObject  // 0x30
  private           UnityEngine.Rigidbody2D         _rigidbody2D  // 0x38
  private           UnityEngine.Collider2D          _collider2D  // 0x40
PROPERTIES:
  CachedTransform  get=0x0268DF90
  CachedCollider  get=0x096CAD60
  CachedCollider2D  get=0x096CACDC
  CachedRigidBody  get=0x096CAE68
  CachedRigidBody2D  get=0x096CADE4
  CachedGameObject  get=0x0268DF10
  transform  get=0x096CAEEC
METHODS:
  RVA=0x096CACA8  token=0x6000087  System.Void AssertNotNull(System.Object value, System.String fieldName)
  RVA=0x096CACC0  token=0x6000088  System.Void Assert(System.Boolean condition, System.String message)
  RVA=0x096CACA8  token=0x6000089  System.Void EditorAssertNotNull(System.Object value, System.String fieldName)
  RVA=0x096CACC0  token=0x600008A  System.Void EditorAssert(System.Boolean condition, System.String message)
  RVA=0x0426FE60  token=0x600008B  System.Void .ctor()
END_CLASS

CLASS: SRF.RequiredFieldAttribute
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.Boolean                  _autoCreate  // 0x10
  private           System.Boolean                  _autoSearch  // 0x11
  private           System.Boolean                  _editorOnly  // 0x12
PROPERTIES:
  AutoSearch  get=0x03D510E0  set=0x03D510F0
  AutoCreate  get=0x011797F0  set=0x03D4E960
  EditorOnly  get=0x03D519E0  set=0x03D6B770
METHODS:
  RVA=0x03D751C0  token=0x600008C  System.Void .ctor(System.Boolean autoSearch)
  RVA=0x03D64CD0  token=0x600008D  System.Void .ctor()
END_CLASS

CLASS: SRF.ImportAttribute
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type                     Service  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000094  System.Void .ctor()
  RVA=0x0426FEE0  token=0x6000095  System.Void .ctor(System.Type serviceType)
END_CLASS

CLASS: SRF.SRMonoBehaviourEx
TYPE:  abstract class
TOKEN: 0x2000011
SIZE:  0x48
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo>>_checkedFields  // static @ 0x0
METHODS:
  RVA=0x02A6C2A0  token=0x6000096  System.Void CheckFields(SRF.SRMonoBehaviourEx instance, System.Boolean justSet)
  RVA=0x02A6C1B0  token=0x6000097  System.Void PopulateObject(System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo> cache, SRF.SRMonoBehaviourEx instance, System.Boolean justSet)
  RVA=0x02A6D440  token=0x6000098  System.Collections.Generic.List<SRF.SRMonoBehaviourEx.FieldInfo> ScanType(System.Type t)
  RVA=0x04276F4C  token=0x6000099  System.Void Awake()
  RVA=0x0350B670  token=0x600009A  System.Void Start()
  RVA=0x0350B670  token=0x600009B  System.Void Update()
  RVA=0x0350B670  token=0x600009C  System.Void FixedUpdate()
  RVA=0x0350B670  token=0x600009D  System.Void OnEnable()
  RVA=0x0350B670  token=0x600009E  System.Void OnDisable()
  RVA=0x0350B670  token=0x600009F  System.Void OnDestroy()
  RVA=0x0426FE60  token=0x60000A0  System.Void .ctor()
END_CLASS

CLASS: SRF.Coroutines
TYPE:  static class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096C65A4  token=0x60000A1  System.Collections.IEnumerator WaitForSecondsRealTime(System.Single time)
END_CLASS

CLASS: SRF.SRFFloatExtensions
TYPE:  static class
TOKEN: 0x2000015
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D51490  token=0x60000A8  System.Single Sqr(System.Single f)
  RVA=0x03D51630  token=0x60000A9  System.Single SqrRt(System.Single f)
  RVA=0x096C9A28  token=0x60000AA  System.Boolean ApproxZero(System.Single f)
  RVA=0x096C9A34  token=0x60000AB  System.Boolean Approx(System.Single f, System.Single f2)
END_CLASS

CLASS: SRF.SRFGameObjectExtensions
TYPE:  static class
TOKEN: 0x2000016
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60000AC  T GetIComponent(UnityEngine.GameObject t)
  RVA=-1  // generic def  token=0x60000AD  T GetComponentOrAdd(UnityEngine.GameObject obj)
  RVA=-1  // generic def  token=0x60000AE  System.Void RemoveComponentIfExists(UnityEngine.GameObject obj)
  RVA=-1  // generic def  token=0x60000AF  System.Void RemoveComponentsIfExists(UnityEngine.GameObject obj)
  RVA=-1  // generic def  token=0x60000B0  System.Boolean EnableComponentIfExists(UnityEngine.GameObject obj, System.Boolean enable)
  RVA=0x096C9BD4  token=0x60000B1  System.Void SetLayerRecursive(UnityEngine.GameObject o, System.Int32 layer)
  RVA=0x096C9A3C  token=0x60000B2  System.Void SetLayerInternal(UnityEngine.Transform t, System.Int32 layer)
END_CLASS

CLASS: SRF.SRFIListExtensions
TYPE:  static class
TOKEN: 0x2000017
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x60000B3  T Random(System.Collections.Generic.IList<T> list)
  RVA=-1  // generic def  token=0x60000B4  T RandomOrDefault(System.Collections.Generic.IList<T> list)
  RVA=-1  // generic def  token=0x60000B5  T PopLast(System.Collections.Generic.IList<T> list)
END_CLASS

CLASS: SRF.SRFStringExtensions
TYPE:  static class
TOKEN: 0x2000018
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x04275A04  token=0x60000B6  System.String Fmt(System.String formatString, System.Object[] args)
END_CLASS

CLASS: SRF.SRFTransformExtensions
TYPE:  static class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096C9E5C  token=0x60000B7  System.Collections.Generic.IEnumerable<UnityEngine.Transform> GetChildren(UnityEngine.Transform t)
  RVA=0x096C9F54  token=0x60000B8  System.Void ResetLocal(UnityEngine.Transform t)
  RVA=0x096C9C00  token=0x60000B9  UnityEngine.GameObject CreateChild(UnityEngine.Transform t, System.String name)
  RVA=0x096C9FE8  token=0x60000BA  System.Void SetParentMaintainLocals(UnityEngine.Transform t, UnityEngine.Transform parent)
  RVA=0x0969BAA8  token=0x60000BB  System.Void SetLocals(UnityEngine.Transform t, UnityEngine.Transform from)
  RVA=0x096C9ECC  token=0x60000BC  System.Void Match(UnityEngine.Transform t, UnityEngine.Transform from)
  RVA=0x096C9CC8  token=0x60000BD  System.Void DestroyChildren(UnityEngine.Transform t)
END_CLASS

CLASS: SRF.Hierarchy
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x10
FIELDS:
  private   static readonly System.Char[]                   Seperator  // static @ 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>Cache  // static @ 0x8
PROPERTIES:
  Item  get=0x096C7944
METHODS:
  RVA=0x0268EDD0  token=0x60000C7  UnityEngine.Transform Get(System.String key)
  RVA=0x03D01E20  token=0x60000C8  System.Void RuntimeInitialize()
  RVA=0x0350B670  token=0x60000C9  System.Void .ctor()
  RVA=0x03C7CBB0  token=0x60000CA  System.Void .cctor()
END_CLASS

CLASS: SRF.Components.SRAutoSingleton`1
TYPE:  abstract class
TOKEN: 0x2000058
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private   static  T                               _instance  // static @ 0x0
PROPERTIES:
  Instance  get=-1  // not resolved
  HasInstance  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60001FE  System.Void Awake()
  RVA=-1  // not resolved  token=0x60001FF  System.Void OnEnable()
  RVA=-1  // not resolved  token=0x6000200  System.Void OnApplicationQuit()
  RVA=-1  // not resolved  token=0x6000201  System.Void .ctor()
END_CLASS

CLASS: SRF.Components.SRSingleton`1
TYPE:  abstract class
TOKEN: 0x2000059
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private   static  T                               _instance  // static @ 0x0
PROPERTIES:
  Instance  get=-1  // not resolved
  HasInstance  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000204  System.Void Register()
  RVA=-1  // not resolved  token=0x6000205  System.Void Awake()
  RVA=-1  // not resolved  token=0x6000206  System.Void OnEnable()
  RVA=-1  // not resolved  token=0x6000207  System.Void OnApplicationQuit()
  RVA=-1  // not resolved  token=0x6000208  System.Void .ctor()
END_CLASS

CLASS: SRF.Helpers.AssetUtil
TYPE:  static class
TOKEN: 0x200004E
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: SRF.Helpers.MethodReference
TYPE:  sealed class
TOKEN: 0x200004F
SIZE:  0x18
FIELDS:
  private   readonly System.Func<System.Object[],System.Object>_method  // 0x10
METHODS:
  RVA=0x096C7C80  token=0x60001D5  System.Void .ctor(System.Object target, System.Reflection.MethodInfo method)
  RVA=0x0426FEE0  token=0x60001D6  System.Void .ctor(System.Func<System.Object[],System.Object> method)
  RVA=0x0858E0D8  token=0x60001D7  System.Object Invoke(System.Object[] parameters)
  RVA=0x096C7D60  token=0x60001D8  SRF.Helpers.MethodReference op_Implicit(System.Action action)
END_CLASS

CLASS: SRF.Helpers.PropertyValueChangedHandler
TYPE:  sealed class
TOKEN: 0x2000052
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06DE8490  token=0x60001DD  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x60001DE  System.Void Invoke(SRF.Helpers.PropertyReference property)
  RVA=0x0389C3B0  token=0x60001DF  System.IAsyncResult BeginInvoke(SRF.Helpers.PropertyReference property, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x60001E0  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SRF.Helpers.PropertyReference
TYPE:  sealed class
TOKEN: 0x2000053
SIZE:  0x48
FIELDS:
  private   readonly System.Reflection.PropertyInfo  _property  // 0x10
  private   readonly System.Object                   _target  // 0x18
  private   readonly System.Attribute[]              _attributes  // 0x20
  private   readonly System.Func<System.Object>      _getter  // 0x28
  private   readonly System.Action<System.Object>    _setter  // 0x30
  private           System.Collections.Generic.List<SRF.Helpers.PropertyValueChangedHandler>_valueChangedListeners  // 0x38
  private           System.Type                     <PropertyType>k__BackingField  // 0x40
PROPERTIES:
  PropertyType  get=0x03D4E2B0  set=0x03CB2D80
  CanRead  get=0x05693D38
  CanWrite  get=0x085839D0
EVENTS:
  ValueChanged  add=add_ValueChanged  remove=remove_ValueChanged
METHODS:
  RVA=-1  // generic def  token=0x60001E3  SRF.Helpers.PropertyReference FromLambda(System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes)
  RVA=0x096C8D08  token=0x60001E4  System.Void .ctor(System.Object target, System.Reflection.PropertyInfo property)
  RVA=0x096C8EDC  token=0x60001E5  System.Void .ctor(System.Type type, System.Func<System.Object> getter, System.Action<System.Object> setter, System.Attribute[] attributes)
  RVA=0x096C89E8  token=0x60001EA  System.Void NotifyValueChanged()
  RVA=0x096C89D0  token=0x60001EB  System.Object GetValue()
  RVA=0x096C8B74  token=0x60001EC  System.Void SetValue(System.Object value)
  RVA=-1  // generic def  token=0x60001ED  T GetAttribute()
  RVA=0x096C8AF8  token=0x60001EE  System.Void OnTargetPropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
  RVA=0x096C8BEC  token=0x60001EF  System.String ToString()
END_CLASS

CLASS: SRF.Helpers.SRReflection
TYPE:  static class
TOKEN: 0x2000057
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096CB6CC  token=0x60001F9  System.Void SetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p, System.Object value)
  RVA=0x096CB690  token=0x60001FA  System.Object GetPropertyValue(System.Object obj, System.Reflection.PropertyInfo p)
  RVA=-1  // generic def  token=0x60001FB  T GetAttribute(System.Reflection.MemberInfo t)
END_CLASS

CLASS: SRF.Internal.ComponentMenuPaths
TYPE:  static class
TOKEN: 0x200005A
SIZE:  0x10
FIELDS:
  public    static  System.String                   PathRoot  // const
  public    static  System.String                   SRServiceManager  // const
  public    static  System.String                   BehavioursRoot  // const
  public    static  System.String                   DestroyOnDisable  // const
  public    static  System.String                   DontDestroyOnLoad  // const
  public    static  System.String                   MatchTransform  // const
  public    static  System.String                   LookAt  // const
  public    static  System.String                   MatchForwardDirection  // const
  public    static  System.String                   MatchMainCameraForwardDirection  // const
  public    static  System.String                   RuntimePosition  // const
  public    static  System.String                   ScrollTexture  // const
  public    static  System.String                   SmoothFloatBehaviour  // const
  public    static  System.String                   SmoothFollow2D  // const
  public    static  System.String                   SpringFollow  // const
  public    static  System.String                   SmoothMatchTransform  // const
  public    static  System.String                   SpawnPrefab  // const
  public    static  System.String                   Velocity  // const
  public    static  System.String                   SmoothOscillate  // const
  public    static  System.String                   SRDebugCamera  // const
  public    static  System.String                   ComponentsRoot  // const
  public    static  System.String                   SRLineRenderer  // const
  public    static  System.String                   SelectionRoot  // const
  public    static  System.String                   SRSpriteFadeRenderer  // const
  public    static  System.String                   SRMaterialFadeRenderer  // const
  public    static  System.String                   SRCompositeFadeRenderer  // const
  public    static  System.String                   UIRoot  // const
  public    static  System.String                   TiltOnTouch  // const
  public    static  System.String                   ScaleOnTouch  // const
  public    static  System.String                   InheritColour  // const
  public    static  System.String                   FlashGraphic  // const
  public    static  System.String                   CopyPreferredSize  // const
  public    static  System.String                   CopyPreferredSizes  // const
  public    static  System.String                   CopyLayoutElement  // const
  public    static  System.String                   CopySizeIntoLayoutElement  // const
  public    static  System.String                   SRText  // const
  public    static  System.String                   Unselectable  // const
  public    static  System.String                   LongPressButton  // const
  public    static  System.String                   ScrollToBottom  // const
  public    static  System.String                   FlowLayoutGroup  // const
  public    static  System.String                   VirtualVerticalLayoutGroup  // const
  public    static  System.String                   StyleRoot  // const
  public    static  System.String                   StyleComponent  // const
  public    static  System.String                   ResponsiveEnable  // const
  public    static  System.String                   ResponsiveResize  // const
  public    static  System.String                   RetinaScaler  // const
  public    static  System.String                   NumberButton  // const
  public    static  System.String                   NumberSpinner  // const
  public    static  System.String                   SRSpinner  // const
  public    static  System.String                   ContentFitText  // const
METHODS:
END_CLASS

CLASS: SRF.Service.ServiceAttribute
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x18
EXTENDS: UnityEngine.Scripting.PreserveAttribute
FIELDS:
  private           System.Type                     <ServiceType>k__BackingField  // 0x10
PROPERTIES:
  ServiceType  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x600018B  System.Void .ctor(System.Type serviceType)
END_CLASS

CLASS: SRF.Service.ServiceSelectorAttribute
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x18
EXTENDS: UnityEngine.Scripting.PreserveAttribute
FIELDS:
  private           System.Type                     <ServiceType>k__BackingField  // 0x10
PROPERTIES:
  ServiceType  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x600018E  System.Void .ctor(System.Type serviceType)
END_CLASS

CLASS: SRF.Service.ServiceConstructorAttribute
TYPE:  sealed class
TOKEN: 0x2000041
SIZE:  0x18
EXTENDS: UnityEngine.Scripting.PreserveAttribute
FIELDS:
  private           System.Type                     <ServiceType>k__BackingField  // 0x10
PROPERTIES:
  ServiceType  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x6000191  System.Void .ctor(System.Type serviceType)
END_CLASS

CLASS: SRF.Service.IAsyncService
TYPE:  interface
TOKEN: 0x2000042
FIELDS:
PROPERTIES:
  IsLoaded  get=-1  // abstract
METHODS:
END_CLASS

CLASS: SRF.Service.SRDependencyServiceBase`1
TYPE:  abstract class
TOKEN: 0x2000043
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRF.Service.IAsyncService
FIELDS:
  private           System.Boolean                  _isLoaded  // 0x0
PROPERTIES:
  Dependencies  get=-1  // abstract
  IsLoaded  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000197  System.Void Log(System.String msg, UnityEngine.Object target)
  RVA=-1  // not resolved  token=0x6000198  System.Void Start()
  RVA=-1  // not resolved  token=0x6000199  System.Void OnLoaded()
  RVA=-1  // not resolved  token=0x600019A  System.Collections.IEnumerator LoadDependencies()
  RVA=-1  // not resolved  token=0x600019B  System.Void .ctor()
END_CLASS

CLASS: SRF.Service.SRSceneServiceBase`2
TYPE:  abstract class
TOKEN: 0x2000045
EXTENDS: SRF.Service.SRServiceBase`1
IMPLEMENTS: SRF.Service.IAsyncService
FIELDS:
  private           TImpl                           _rootObject  // 0x0
PROPERTIES:
  SceneName  get=-1  // abstract
  RootObject  get=-1  // not resolved
  IsLoaded  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60001A5  System.Void Log(System.String msg, UnityEngine.Object target)
  RVA=-1  // not resolved  token=0x60001A6  System.Void Start()
  RVA=-1  // not resolved  token=0x60001A7  System.Void OnDestroy()
  RVA=-1  // not resolved  token=0x60001A8  System.Void OnLoaded()
  RVA=-1  // not resolved  token=0x60001A9  System.Collections.IEnumerator LoadCoroutine()
  RVA=-1  // not resolved  token=0x60001AA  System.Void .ctor()
END_CLASS

CLASS: SRF.Service.SRServiceBase`1
TYPE:  abstract class
TOKEN: 0x2000047
EXTENDS: SRF.SRMonoBehaviourEx
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x60001B1  System.Void Awake()
  RVA=-1  // not resolved  token=0x60001B2  System.Void OnDestroy()
  RVA=-1  // not resolved  token=0x60001B3  System.Void .ctor()
END_CLASS

CLASS: SRF.Service.SRServiceManager
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x58
EXTENDS: SRF.Components.SRAutoSingleton`1
FIELDS:
  public    static  System.Boolean                  EnableLogging  // const
  public    static  System.Int32                    LoadingCount  // static @ 0x0
  private   static readonly System.Collections.Generic.List<System.Reflection.Assembly>_assemblies  // static @ 0x8
  private   readonly SRF.SRList<SRF.Service.SRServiceManager.Service>_services  // 0x48
  private           System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub>_serviceStubs  // 0x50
  private   static  System.Boolean                  _hasQuit  // static @ 0x10
PROPERTIES:
  IsLoading  get=0x096CBAA0
METHODS:
  RVA=-1  // generic def  token=0x60001B4  System.Void RegisterAssembly()
  RVA=-1  // generic def  token=0x60001B6  T GetService()
  RVA=0x096CB8A8  token=0x60001B7  System.Object GetService(System.Type t)
  RVA=0x02CD72B0  token=0x60001B8  System.Object GetServiceInternal(System.Type t)
  RVA=-1  // generic def  token=0x60001B9  System.Boolean HasService()
  RVA=0x02CD7410  token=0x60001BA  System.Boolean HasService(System.Type t)
  RVA=-1  // generic def  token=0x60001BB  System.Void RegisterService(System.Object service)
  RVA=0x02CD6FF0  token=0x60001BC  System.Void RegisterService(System.Type t, System.Object service)
  RVA=-1  // generic def  token=0x60001BD  System.Void UnRegisterService()
  RVA=0x02CD7E10  token=0x60001BE  System.Void UnRegisterService(System.Type t)
  RVA=0x0268DE30  token=0x60001BF  System.Void Awake()
  RVA=0x02840F80  token=0x60001C0  System.Void UpdateStubs()
  RVA=0x02CD7540  token=0x60001C1  System.Object AutoCreateService(System.Type t)
  RVA=0x096CBA28  token=0x60001C2  System.Void OnApplicationQuit()
  RVA=0x02CD7C60  token=0x60001C3  System.Object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType)
  RVA=0x028420A0  token=0x60001C4  System.Void ScanType(System.Type type)
  RVA=0x028421D0  token=0x60001C5  System.Void ScanTypeForSelectors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
  RVA=0x02842530  token=0x60001C6  System.Void ScanTypeForConstructors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
  RVA=0x028426F0  token=0x60001C7  System.Reflection.MethodInfo[] GetStaticMethods(System.Type t)
  RVA=0x03C973E0  token=0x60001C8  System.Void .ctor()
  RVA=0x03CB6850  token=0x60001C9  System.Void .cctor()
END_CLASS

CLASS: SRF.UI.ContentFitText
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x28
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  public            SRF.UI.SRText                   CopySource  // 0x18
  public            UnityEngine.Vector2             Padding  // 0x20
PROPERTIES:
  minWidth  get=0x096C5B78
  preferredWidth  get=0x096C5C80
  flexibleWidth  get=0x096C5A74
  minHeight  get=0x096C5AF4
  preferredHeight  get=0x096C5BFC
  flexibleHeight  get=0x096C59F4
  layoutPriority  get=0x01002730
METHODS:
  RVA=0x096C5814  token=0x60000D2  System.Void CalculateLayoutInputHorizontal()
  RVA=0x096C5814  token=0x60000D3  System.Void CalculateLayoutInputVertical()
  RVA=0x096C58D0  token=0x60000D4  System.Void OnEnable()
  RVA=0x096C582C  token=0x60000D5  System.Void CopySourceOnLayoutDirty(SRF.UI.SRText srText)
  RVA=0x096C582C  token=0x60000D6  System.Void OnTransformParentChanged()
  RVA=0x096C5834  token=0x60000D7  System.Void OnDisable()
  RVA=0x096C582C  token=0x60000D8  System.Void OnDidApplyAnimationProperties()
  RVA=0x096C582C  token=0x60000D9  System.Void OnBeforeTransformParentChanged()
  RVA=0x096C596C  token=0x60000DA  System.Void SetDirty()
  RVA=0x0426FE60  token=0x60000DB  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopyLayoutElement
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x38
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.UI.ILayoutElement
FIELDS:
  public            System.Boolean                  CopyMinHeight  // 0x18
  public            System.Boolean                  CopyMinWidth  // 0x19
  public            System.Boolean                  CopyPreferredHeight  // 0x1a
  public            System.Boolean                  CopyPreferredWidth  // 0x1b
  public            UnityEngine.RectTransform       CopySource  // 0x20
  public            System.Single                   PaddingMinHeight  // 0x28
  public            System.Single                   PaddingMinWidth  // 0x2c
  public            System.Single                   PaddingPreferredHeight  // 0x30
  public            System.Single                   PaddingPreferredWidth  // 0x34
PROPERTIES:
  preferredWidth  get=0x096C5E9C
  preferredHeight  get=0x096C5E14
  minWidth  get=0x096C5D8C
  minHeight  get=0x096C5D04
  layoutPriority  get=0x02102C70
  flexibleHeight  get=0x03D751A0
  flexibleWidth  get=0x03D751A0
METHODS:
  RVA=0x0350B670  token=0x60000E3  System.Void CalculateLayoutInputHorizontal()
  RVA=0x0350B670  token=0x60000E4  System.Void CalculateLayoutInputVertical()
  RVA=0x0426FE60  token=0x60000E5  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopyPreferredSize
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x48
EXTENDS: UnityEngine.UI.LayoutElement
FIELDS:
  public            UnityEngine.RectTransform       CopySource  // 0x38
  public            System.Single                   PaddingHeight  // 0x40
  public            System.Single                   PaddingWidth  // 0x44
PROPERTIES:
  preferredWidth  get=0x096C5FA4
  preferredHeight  get=0x096C5F24
  layoutPriority  get=0x02102C70
METHODS:
  RVA=0x031659B0  token=0x60000E9  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopyPreferredSizes
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x48
EXTENDS: UnityEngine.UI.LayoutElement
FIELDS:
  public            SRF.UI.CopyPreferredSizes.CopySource[]CopySources  // 0x38
  public            SRF.UI.CopyPreferredSizes.OperationsOperation  // 0x40
PROPERTIES:
  preferredWidth  get=0x096C61AC
  preferredHeight  get=0x096C6024
  layoutPriority  get=0x02102C70
METHODS:
  RVA=0x031659B0  token=0x60000ED  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.CopySizeIntoLayoutElement
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x50
EXTENDS: UnityEngine.UI.LayoutElement
FIELDS:
  public            UnityEngine.RectTransform       CopySource  // 0x38
  public            System.Single                   PaddingHeight  // 0x40
  public            System.Single                   PaddingWidth  // 0x44
  public            System.Boolean                  SetPreferredSize  // 0x48
  public            System.Boolean                  SetMinimumSize  // 0x49
PROPERTIES:
  preferredWidth  get=0x096C6508
  preferredHeight  get=0x096C646C
  minWidth  get=0x096C63D0
  minHeight  get=0x096C6334
  layoutPriority  get=0x02102C70
METHODS:
  RVA=0x031659B0  token=0x60000F4  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.DragHandle
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IBeginDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IEndDragHandler UnityEngine.EventSystems.IDragHandler
FIELDS:
  private           UnityEngine.UI.CanvasScaler     _canvasScaler  // 0x18
  private           System.Single                   _delta  // 0x20
  private           System.Single                   _startValue  // 0x24
  public            UnityEngine.RectTransform.Axis  Axis  // 0x28
  public            System.Boolean                  Invert  // 0x2c
  public            System.Single                   MaxSize  // 0x30
  public            UnityEngine.UI.LayoutElement    TargetLayoutElement  // 0x38
  public            UnityEngine.RectTransform       TargetRectTransform  // 0x40
PROPERTIES:
  Mult  get=0x096C6CD8
METHODS:
  RVA=0x096C68BC  token=0x60000F6  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C68EC  token=0x60000F7  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C6A1C  token=0x60000F8  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C6BBC  token=0x60000F9  System.Void Start()
  RVA=0x096C6C0C  token=0x60000FA  System.Boolean Verify()
  RVA=0x096C66F8  token=0x60000FB  System.Single GetCurrentValue()
  RVA=0x096C6A74  token=0x60000FC  System.Void SetCurrentValue(System.Single value)
  RVA=0x096C65F8  token=0x60000FD  System.Void CommitCurrentValue()
  RVA=0x096C6834  token=0x60000FE  System.Single GetMinSize()
  RVA=0x096C6818  token=0x60000FF  System.Single GetMaxSize()
  RVA=0x096C6CC8  token=0x6000100  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.FlashGraphic
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x50
EXTENDS: UnityEngine.EventSystems.UIBehaviour
IMPLEMENTS: UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerUpHandler
FIELDS:
  public            System.Single                   DecayTime  // 0x18
  public            UnityEngine.Color               DefaultColor  // 0x1c
  public            UnityEngine.Color               FlashColor  // 0x2c
  public            UnityEngine.UI.Graphic          Target  // 0x40
  private           System.Boolean                  _isHoldingUntilNextPress  // 0x48
METHODS:
  RVA=0x096C6DF8  token=0x6000101  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C6E40  token=0x6000102  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C6DB4  token=0x6000103  System.Void OnEnable()
  RVA=0x096C6D3C  token=0x6000104  System.Void Flash()
  RVA=0x096C6CF4  token=0x6000105  System.Void FlashAndHoldUntilNextPress()
  RVA=0x096C6E8C  token=0x6000106  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.InheritColour
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           UnityEngine.UI.Graphic          _graphic  // 0x48
  public            UnityEngine.UI.Graphic          From  // 0x50
PROPERTIES:
  Graphic  get=0x096C7A48
METHODS:
  RVA=0x096C7990  token=0x6000108  System.Void Refresh()
  RVA=0x096C7A40  token=0x6000109  System.Void Update()
  RVA=0x096C7A40  token=0x600010A  System.Void Start()
  RVA=0x0426FE60  token=0x600010B  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.LongPressButton
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x1A8
EXTENDS: UnityEngine.UI.Button
FIELDS:
  private           System.Boolean                  _handled  // 0x188
  private           UnityEngine.UI.Button.ButtonClickedEvent_onLongPress  // 0x190
  private           System.Boolean                  _pressed  // 0x198
  private           System.Single                   _pressedTime  // 0x19c
  public            System.Single                   LongPressDuration  // 0x1a0
PROPERTIES:
  onLongPress  get=0x03D56B70  set=0x04275BAC
METHODS:
  RVA=0x096C7B58  token=0x600010E  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C7B04  token=0x600010F  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C7B78  token=0x6000110  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C7AF0  token=0x6000111  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096C7BA8  token=0x6000112  System.Void Update()
  RVA=0x096C7C00  token=0x6000113  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ResponsiveBase
TYPE:  abstract class
TOKEN: 0x2000027
SIZE:  0x50
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _queueRefresh  // 0x48
PROPERTIES:
  RectTransform  get=0x096C9210
METHODS:
  RVA=0x03D73A50  token=0x6000115  System.Void OnEnable()
  RVA=0x03D73A50  token=0x6000116  System.Void OnRectTransformDimensionsChange()
  RVA=0x096C91E8  token=0x6000117  System.Void Update()
  RVA=-1  // abstract  token=0x6000118  System.Void Refresh()
  RVA=0x095F8FC0  token=0x6000119  System.Void DoRefresh()
  RVA=0x0426FE60  token=0x600011A  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ResponsiveEnable
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x58
EXTENDS: SRF.UI.ResponsiveBase
FIELDS:
  public            SRF.UI.ResponsiveEnable.Entry[] Entries  // 0x50
METHODS:
  RVA=0x096C9260  token=0x600011B  System.Void Refresh()
  RVA=0x096C94DC  token=0x600011C  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ResponsiveResize
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x58
EXTENDS: SRF.UI.ResponsiveBase
FIELDS:
  public            SRF.UI.ResponsiveResize.Element[]Elements  // 0x50
METHODS:
  RVA=0x096C952C  token=0x600011D  System.Void Refresh()
  RVA=0x096C96D8  token=0x600011E  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.ScrollToBottomBehaviour
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.UI.ScrollRect       _scrollRect  // 0x18
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x20
  private           System.Boolean                  _scrollToTop  // 0x28
METHODS:
  RVA=0x096CBFB0  token=0x600011F  System.Void Start()
  RVA=0x096CBE78  token=0x6000120  System.Void OnEnable()
  RVA=0x096CC10C  token=0x6000121  System.Void Trigger()
  RVA=0x096CBE78  token=0x6000122  System.Void OnScrollRectValueChanged(UnityEngine.Vector2 position)
  RVA=0x096CBE80  token=0x6000123  System.Void Refresh()
  RVA=0x096CBF24  token=0x6000124  System.Void SetVisible(System.Boolean truth)
  RVA=0x0426FE60  token=0x6000125  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRNumberButton
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x1A8
EXTENDS: UnityEngine.UI.Button
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IPointerDownHandler UnityEngine.EventSystems.IPointerUpHandler
FIELDS:
  private   static  System.Single                   ExtraThreshold  // const
  public    static  System.Single                   Delay  // const
  private           System.Single                   _delayTime  // 0x188
  private           System.Single                   _downTime  // 0x18c
  private           System.Boolean                  _isDown  // 0x190
  public            System.Double                   Amount  // 0x198
  public            SRF.UI.SRNumberSpinner          TargetField  // 0x1a0
METHODS:
  RVA=0x096CAFF4  token=0x6000126  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CB044  token=0x6000127  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CB064  token=0x6000128  System.Void Update()
  RVA=0x096CAEF4  token=0x6000129  System.Void Apply()
  RVA=0x096CB0F0  token=0x600012A  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRNumberSpinner
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x2D0
EXTENDS: UnityEngine.UI.InputField
FIELDS:
  private           System.Double                   _currentValue  // 0x2a0
  private           System.Double                   _dragStartAmount  // 0x2a8
  private           System.Double                   _dragStep  // 0x2b0
  public            System.Single                   DragSensitivity  // 0x2b8
  public            System.Double                   MaxValue  // 0x2c0
  public            System.Double                   MinValue  // 0x2c8
METHODS:
  RVA=0x096CB108  token=0x600012B  System.Void Awake()
  RVA=0x096CB53C  token=0x600012C  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0350B670  token=0x600012D  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0350B670  token=0x600012E  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CB184  token=0x600012F  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CB388  token=0x6000130  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CB4F0  token=0x6000131  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CB624  token=0x6000132  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRRetinaScaler
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           System.Boolean                  _disablePixelPerfect  // 0x48
  private           System.Int32                    _designDpi  // 0x4c
  private           System.Single                   _lastDpi  // 0x50
METHODS:
  RVA=0x096CB860  token=0x6000133  System.Void Start()
  RVA=0x096CB778  token=0x6000134  System.Void ApplyScaling()
  RVA=0x096CB868  token=0x6000135  System.Void Update()
  RVA=0x096CB898  token=0x6000136  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRSpinner
TYPE:  class
TOKEN: 0x2000032
SIZE:  0x1A0
EXTENDS: UnityEngine.UI.Selectable
IMPLEMENTS: UnityEngine.EventSystems.IDragHandler UnityEngine.EventSystems.IEventSystemHandler UnityEngine.EventSystems.IBeginDragHandler
FIELDS:
  private           System.Single                   _dragDelta  // 0x180
  private           SRF.UI.SRSpinner.SpinEvent      _onSpinDecrement  // 0x188
  private           SRF.UI.SRSpinner.SpinEvent      _onSpinIncrement  // 0x190
  public            System.Single                   DragThreshold  // 0x198
PROPERTIES:
  OnSpinIncrement  get=0x03D56B70  set=0x04275BAC
  OnSpinDecrement  get=0x03D56AF0  set=0x04275C54
METHODS:
  RVA=0x03D75260  token=0x600013B  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CBB34  token=0x600013C  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CBC04  token=0x600013D  System.Void OnIncrement(System.Int32 amount)
  RVA=0x096CBAE8  token=0x600013E  System.Void OnDecrement(System.Int32 amount)
  RVA=0x096CBC50  token=0x600013F  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.SRText
TYPE:  class
TOKEN: 0x2000034
SIZE:  0x120
EXTENDS: UnityEngine.UI.Text
FIELDS:
  private           System.Action<SRF.UI.SRText>    LayoutDirty  // 0x118
EVENTS:
  LayoutDirty  add=add_LayoutDirty  remove=remove_LayoutDirty
METHODS:
  RVA=0x096CBD18  token=0x6000143  System.Void SetLayoutDirty()
  RVA=0x096CBD50  token=0x6000144  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.StyleComponent
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x88
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           SRF.UI.Style                    _activeStyle  // 0x48
  private           SRF.UI.StyleRoot                _cachedRoot  // 0x50
  private           UnityEngine.UI.Graphic          _graphic  // 0x58
  private           System.Boolean                  _hasStarted  // 0x60
  private           UnityEngine.UI.Image            _image  // 0x68
  private           UnityEngine.UI.Selectable       _selectable  // 0x70
  private           System.String                   _styleKey  // 0x78
  public            System.Boolean                  IgnoreImage  // 0x80
PROPERTIES:
  StyleKey  get=0x03D4EB20  set=0x096CD814
METHODS:
  RVA=0x096CD7F4  token=0x6000147  System.Void Start()
  RVA=0x096CD5C8  token=0x6000148  System.Void OnEnable()
  RVA=0x096CD5DC  token=0x6000149  System.Void Refresh(System.Boolean invalidateCache)
  RVA=0x096CD478  token=0x600014A  SRF.UI.StyleRoot GetStyleRoot()
  RVA=0x096CD18C  token=0x600014B  System.Void ApplyStyle()
  RVA=0x096CD7A4  token=0x600014C  System.Void SRStyleDirty()
  RVA=0x0426FE60  token=0x600014D  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.StyleRoot
TYPE:  sealed class
TOKEN: 0x2000036
SIZE:  0x58
EXTENDS: SRF.SRMonoBehaviour
FIELDS:
  private           SRF.UI.StyleSheet               _activeStyleSheet  // 0x48
  public            SRF.UI.StyleSheet               StyleSheet  // 0x50
METHODS:
  RVA=0x096CD83C  token=0x600014E  SRF.UI.Style GetStyle(System.String key)
  RVA=0x096CD900  token=0x600014F  System.Void OnEnable()
  RVA=0x096CD8F8  token=0x6000150  System.Void OnDisable()
  RVA=0x096CD9C4  token=0x6000151  System.Void Update()
  RVA=0x096CD970  token=0x6000152  System.Void OnStyleSheetChanged()
  RVA=0x05D6CFCC  token=0x6000153  System.Void SetDirty()
  RVA=0x0426FE60  token=0x6000154  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Style
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x58
FIELDS:
  public            UnityEngine.Color               ActiveColor  // 0x10
  public            UnityEngine.Color               DisabledColor  // 0x20
  public            UnityEngine.Color               HoverColor  // 0x30
  public            UnityEngine.Sprite              Image  // 0x40
  public            UnityEngine.Color               NormalColor  // 0x48
METHODS:
  RVA=0x096CDC30  token=0x6000155  SRF.UI.Style Copy()
  RVA=0x096CDBD4  token=0x6000156  System.Void CopyFrom(SRF.UI.Style style)
  RVA=0x096CDC9C  token=0x6000157  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.StyleSheet
TYPE:  class
TOKEN: 0x2000038
SIZE:  0x30
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private           System.Collections.Generic.List<System.String>_keys  // 0x18
  private           System.Collections.Generic.List<SRF.UI.Style>_styles  // 0x20
  public            SRF.UI.StyleSheet               Parent  // 0x28
METHODS:
  RVA=0x096CDA34  token=0x6000158  SRF.UI.Style GetStyle(System.String key, System.Boolean searchParent)
  RVA=0x096CDB0C  token=0x6000159  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Unselectable
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x50
EXTENDS: SRF.SRMonoBehaviour
IMPLEMENTS: UnityEngine.EventSystems.ISelectHandler UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
  private           System.Boolean                  _suspectedSelected  // 0x48
METHODS:
  RVA=0x03D73A50  token=0x600015A  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  RVA=0x096CF2B0  token=0x600015B  System.Void Update()
  RVA=0x0426FE60  token=0x600015C  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Layout.FlowLayoutGroup
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x70
EXTENDS: UnityEngine.UI.LayoutGroup
FIELDS:
  private   readonly System.Collections.Generic.IList<UnityEngine.RectTransform>_rowList  // 0x58
  private           System.Single                   _layoutHeight  // 0x60
  public            System.Boolean                  ChildForceExpandHeight  // 0x64
  public            System.Boolean                  ChildForceExpandWidth  // 0x65
  public            System.Single                   Spacing  // 0x68
PROPERTIES:
  IsCenterAlign  get=0x096C78E4
  IsRightAlign  get=0x096C792C
  IsMiddleAlign  get=0x096C7914
  IsLowerAlign  get=0x096C78FC
METHODS:
  RVA=0x096C6EC8  token=0x6000161  System.Void CalculateLayoutInputHorizontal()
  RVA=0x096C7384  token=0x6000162  System.Void SetLayoutHorizontal()
  RVA=0x096C73D0  token=0x6000163  System.Void SetLayoutVertical()
  RVA=0x096C6F4C  token=0x6000164  System.Void CalculateLayoutInputVertical()
  RVA=0x096C741C  token=0x6000165  System.Single SetLayout(System.Single width, System.Int32 axis, System.Boolean layoutInput)
  RVA=0x096C6FA0  token=0x6000166  System.Single CalculateRowVerticalOffset(System.Single groupHeight, System.Single yOffset, System.Single currentRowHeight)
  RVA=0x096C70B4  token=0x6000167  System.Void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, System.Single rowWidth, System.Single rowHeight, System.Single maxWidth, System.Single xOffset, System.Single yOffset, System.Int32 axis)
  RVA=0x096C7024  token=0x6000168  System.Single GetGreatestMinimumChildWidth()
  RVA=0x096C7864  token=0x6000169  System.Void .ctor()
END_CLASS

CLASS: SRF.UI.Layout.IVirtualView
TYPE:  interface
TOKEN: 0x200003B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600016A  System.Void SetDataContext(System.Object data)
END_CLASS

CLASS: SRF.UI.Layout.VirtualVerticalLayoutGroup
TYPE:  class
TOKEN: 0x200003C
SIZE:  0xE8
EXTENDS: UnityEngine.UI.LayoutGroup
IMPLEMENTS: UnityEngine.EventSystems.IPointerClickHandler UnityEngine.EventSystems.IEventSystemHandler
FIELDS:
  private   readonly SRF.SRList<System.Object>       _itemList  // 0x58
  private   readonly SRF.SRList<System.Int32>        _visibleItemList  // 0x60
  private           System.Boolean                  _isDirty  // 0x68
  private           SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row>_rowCache  // 0x70
  private           UnityEngine.UI.ScrollRect       _scrollRect  // 0x78
  private           System.Int32                    _selectedIndex  // 0x80
  private           System.Object                   _selectedItem  // 0x88
  private           SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent_selectedItemChanged  // 0x90
  private           System.Int32                    _visibleItemCount  // 0x98
  private           SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row>_visibleRows  // 0xa0
  public            SRF.UI.StyleSheet               AltRowStyleSheet  // 0xa8
  public            System.Boolean                  EnableSelection  // 0xb0
  public            UnityEngine.RectTransform       ItemPrefab  // 0xb8
  public            System.Int32                    RowPadding  // 0xc0
  public            SRF.UI.StyleSheet               RowStyleSheet  // 0xc8
  public            SRF.UI.StyleSheet               SelectedRowStyleSheet  // 0xd0
  public            System.Single                   Spacing  // 0xd8
  public            System.Boolean                  StickToBottom  // 0xdc
  private           System.Single                   _itemHeight  // 0xe0
PROPERTIES:
  SelectedItemChanged  get=0x03D4EA90  set=0x051DFCB4
  SelectedItem  get=0x03D4EA60  set=0x096D0C7C
  minHeight  get=0x096D0BB0
  ScrollRect  get=0x096D0B2C
  AlignBottom  get=0x096D09A0
  AlignTop  get=0x096D09B8
  ItemHeight  get=0x096D09D0
METHODS:
  RVA=0x096CFBA0  token=0x6000170  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x096CF438  token=0x6000171  System.Void Awake()
  RVA=0x096CFD10  token=0x6000172  System.Void OnScrollRectValueChanged(UnityEngine.Vector2 d)
  RVA=0x096D079C  token=0x6000173  System.Void Start()
  RVA=0x096CFB80  token=0x6000174  System.Void OnEnable()
  RVA=0x096D07A4  token=0x6000175  System.Void Update()
  RVA=0x096CFA58  token=0x6000176  System.Void InvalidateItem(System.Int32 itemIndex)
  RVA=0x096CFFAC  token=0x6000177  System.Void RefreshIndexCache()
  RVA=0x096D0130  token=0x6000178  System.Void ScrollUpdate()
  RVA=0x096CF5A0  token=0x6000179  System.Void CalculateLayoutInputVertical()
  RVA=0x096D04AC  token=0x600017A  System.Void SetLayoutHorizontal()
  RVA=0x096D0658  token=0x600017B  System.Void SetLayoutVertical()
  RVA=0x096D0480  token=0x600017C  System.Void SetDirty()
  RVA=0x096CF378  token=0x600017D  System.Void AddItem(System.Object item)
  RVA=0x096D0080  token=0x600017E  System.Void RemoveItem(System.Object item)
  RVA=0x096CF5E8  token=0x600017F  System.Void ClearItems()
  RVA=0x096CF89C  token=0x6000184  SRF.UI.Layout.VirtualVerticalLayoutGroup.Row GetRow(System.Int32 forIndex)
  RVA=0x096CFF58  token=0x6000185  System.Void RecycleRow(SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
  RVA=0x096CFD68  token=0x6000186  System.Void PopulateRow(System.Int32 index, SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
  RVA=0x096CF69C  token=0x6000187  SRF.UI.Layout.VirtualVerticalLayoutGroup.Row CreateRow()
  RVA=0x096D0880  token=0x6000188  System.Void .ctor()
END_CLASS

