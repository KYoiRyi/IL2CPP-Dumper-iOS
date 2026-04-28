// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextRenderingModule.dll
// Classes:  14
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

CLASS: FontTextureRebuildCallback
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x600002E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x600002F  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.FontStyle
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FontStyle           Normal  // const
  public    static  UnityEngine.FontStyle           Bold  // const
  public    static  UnityEngine.FontStyle           Italic  // const
  public    static  UnityEngine.FontStyle           BoldAndItalic  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextGenerationError
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextGenerationError None  // const
  public    static  UnityEngine.TextGenerationError CustomSizeOnNonDynamicFont  // const
  public    static  UnityEngine.TextGenerationError CustomStyleOnNonDynamicFont  // const
  public    static  UnityEngine.TextGenerationError NoFont  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextGenerationSettings
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x70
FIELDS:
  public            UnityEngine.Font                font  // 0x10
  public            UnityEngine.Color               color  // 0x18
  public            System.Int32                    fontSize  // 0x28
  public            System.Single                   lineSpacing  // 0x2c
  public            System.Boolean                  richText  // 0x30
  public            System.Single                   scaleFactor  // 0x34
  public            UnityEngine.FontStyle           fontStyle  // 0x38
  public            UnityEngine.TextAnchor          textAnchor  // 0x3c
  public            System.Boolean                  alignByGeometry  // 0x40
  public            System.Boolean                  resizeTextForBestFit  // 0x41
  public            System.Int32                    resizeTextMinSize  // 0x44
  public            System.Int32                    resizeTextMaxSize  // 0x48
  public            System.Boolean                  updateBounds  // 0x4c
  public            UnityEngine.VerticalWrapMode    verticalOverflow  // 0x50
  public            UnityEngine.HorizontalWrapMode  horizontalOverflow  // 0x54
  public            UnityEngine.Vector2             generationExtents  // 0x58
  public            UnityEngine.Vector2             pivot  // 0x60
  public            System.Boolean                  generateOutOfBounds  // 0x68
METHODS:
  RVA=0x09E59E7C  token=0x6000001  System.Boolean CompareColors(UnityEngine.Color left, UnityEngine.Color right)
  RVA=0x09E59EF0  token=0x6000002  System.Boolean CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right)
  RVA=0x09E59F30  token=0x6000003  System.Boolean Equals(UnityEngine.TextGenerationSettings other)
END_CLASS

CLASS: UnityEngine.TextGenerator
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0xA8
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.String                   m_LastString  // 0x18
  private           UnityEngine.TextGenerationSettingsm_LastSettings  // 0x20
  private           System.Boolean                  m_HasGenerated  // 0x80
  private           UnityEngine.TextGenerationError m_LastValid  // 0x84
  private   readonly System.Collections.Generic.List<UnityEngine.UIVertex>m_Verts  // 0x88
  private   readonly System.Collections.Generic.List<UnityEngine.UICharInfo>m_Characters  // 0x90
  private   readonly System.Collections.Generic.List<UnityEngine.UILineInfo>m_Lines  // 0x98
  private           System.Boolean                  m_CachedVerts  // 0xa0
  private           System.Boolean                  m_CachedCharacters  // 0xa1
  private           System.Boolean                  m_CachedLines  // 0xa2
PROPERTIES:
  characterCountVisible  get=0x09E5B138
  verts  get=0x09E5B2A4
  characters  get=0x09E5B180
  lines  get=0x09E5B1F4
  rectExtents  get=0x09E5B278
  characterCount  get=0x09E5B14C
  lineCount  get=0x09E5B1C0
METHODS:
  RVA=0x09E5B128  token=0x6000004  System.Void .ctor()
  RVA=0x09E5AFE4  token=0x6000005  System.Void .ctor(System.Int32 initialCapacity)
  RVA=0x09E5A144  token=0x6000006  System.Void Finalize()
  RVA=0x09E5AD5C  token=0x6000007  System.Void System.IDisposable.Dispose()
  RVA=0x09E5AD88  token=0x6000009  UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings)
  RVA=0x03D883A0  token=0x600000A  System.Void Invalidate()
  RVA=0x09E5A220  token=0x600000B  System.Void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters)
  RVA=0x09E5A26C  token=0x600000C  System.Void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines)
  RVA=0x09E5A3B8  token=0x600000D  System.Void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)
  RVA=0x09E5A2F0  token=0x600000E  System.Single GetPreferredWidth(System.String str, UnityEngine.TextGenerationSettings settings)
  RVA=0x09E5A274  token=0x600000F  System.Single GetPreferredHeight(System.String str, UnityEngine.TextGenerationSettings settings)
  RVA=0x09E5A7AC  token=0x6000010  System.Boolean PopulateWithErrors(System.String str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context)
  RVA=0x09E5AD04  token=0x6000011  System.Boolean Populate(System.String str, UnityEngine.TextGenerationSettings settings)
  RVA=0x09E5A6C0  token=0x6000012  UnityEngine.TextGenerationError PopulateWithError(System.String str, UnityEngine.TextGenerationSettings settings)
  RVA=0x09E5A420  token=0x6000013  UnityEngine.TextGenerationError PopulateAlways(System.String str, UnityEngine.TextGenerationSettings settings)
  RVA=0x09E5A3C0  token=0x600001A  System.IntPtr Internal_Create()
  RVA=0x09E5A3EC  token=0x600001B  System.Void Internal_Destroy(System.IntPtr ptr)
  RVA=0x09E5AB94  token=0x600001C  System.Boolean Populate_Internal(System.String str, UnityEngine.Font font, UnityEngine.Color color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, System.Int32 verticalOverFlow, System.Int32 horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, System.Single extentsX, System.Single extentsY, System.Single pivotX, System.Single pivotY, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, System.UInt32& error)
  RVA=0x09E5A9C4  token=0x600001D  System.Boolean Populate_Internal(System.String str, UnityEngine.Font font, UnityEngine.Color color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, UnityEngine.TextGenerationError& error)
  RVA=0x09E5A374  token=0x600001E  System.Void GetVerticesInternal(System.Object vertices)
  RVA=0x09E5A1DC  token=0x600001F  System.Void GetCharactersInternal(System.Object characters)
  RVA=0x09E5A228  token=0x6000020  System.Void GetLinesInternal(System.Object lines)
  RVA=0x09E5B234  token=0x6000021  System.Void get_rectExtents_Injected(UnityEngine.Rect& ret)
  RVA=0x09E5A958  token=0x6000022  System.Boolean Populate_Internal_Injected(System.String str, UnityEngine.Font font, UnityEngine.Color& color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, System.Int32 verticalOverFlow, System.Int32 horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, System.Single extentsX, System.Single extentsY, System.Single pivotX, System.Single pivotY, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, System.UInt32& error)
END_CLASS

CLASS: UnityEngine.TextAlignment
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextAlignment       Left  // const
  public    static  UnityEngine.TextAlignment       Center  // const
  public    static  UnityEngine.TextAlignment       Right  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextAnchor
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextAnchor          UpperLeft  // const
  public    static  UnityEngine.TextAnchor          UpperCenter  // const
  public    static  UnityEngine.TextAnchor          UpperRight  // const
  public    static  UnityEngine.TextAnchor          MiddleLeft  // const
  public    static  UnityEngine.TextAnchor          MiddleCenter  // const
  public    static  UnityEngine.TextAnchor          MiddleRight  // const
  public    static  UnityEngine.TextAnchor          LowerLeft  // const
  public    static  UnityEngine.TextAnchor          LowerCenter  // const
  public    static  UnityEngine.TextAnchor          LowerRight  // const
METHODS:
END_CLASS

CLASS: UnityEngine.HorizontalWrapMode
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HorizontalWrapMode  Wrap  // const
  public    static  UnityEngine.HorizontalWrapMode  Overflow  // const
METHODS:
END_CLASS

CLASS: UnityEngine.VerticalWrapMode
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.VerticalWrapMode    Truncate  // const
  public    static  UnityEngine.VerticalWrapMode    Overflow  // const
METHODS:
END_CLASS

CLASS: UnityEngine.UICharInfo
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x1C
FIELDS:
  public            UnityEngine.Vector2             cursorPos  // 0x10
  public            System.Single                   charWidth  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UILineInfo
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x20
FIELDS:
  public            System.Int32                    startCharIdx  // 0x10
  public            System.Int32                    height  // 0x14
  public            System.Single                   topY  // 0x18
  public            System.Single                   leading  // 0x1c
METHODS:
END_CLASS

CLASS: UnityEngine.UIVertex
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x7C
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             normal  // 0x1c
  public            UnityEngine.Vector4             tangent  // 0x28
  public            UnityEngine.Color32             color  // 0x38
  public            UnityEngine.Vector4             uv0  // 0x3c
  public            UnityEngine.Vector4             uv1  // 0x4c
  public            UnityEngine.Vector4             uv2  // 0x5c
  public            UnityEngine.Vector4             uv3  // 0x6c
  private   static readonly UnityEngine.Color32             s_DefaultColor  // static @ 0x0
  private   static readonly UnityEngine.Vector4             s_DefaultTangent  // static @ 0x4
  public    static  UnityEngine.UIVertex            simpleVert  // static @ 0x14
METHODS:
  RVA=0x0398BE10  token=0x6000023  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Font
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x20
EXTENDS: UnityEngine.Object
FIELDS:
  private   static  System.Action<UnityEngine.Font> textureRebuilt  // static @ 0x0
  private           UnityEngine.Font.FontTextureRebuildCallbackm_FontTextureRebuildCallback  // 0x18
PROPERTIES:
  material  get=0x09E59DAC
  dynamic  get=0x09E59D44
  fontSize  get=0x09E59D78
EVENTS:
  textureRebuilt  add=add_textureRebuilt  remove=remove_textureRebuilt
METHODS:
  RVA=0x09E59C5C  token=0x6000029  System.Void .ctor()
  RVA=0x03046950  token=0x600002A  System.Void InvokeTextureRebuilt_Internal(UnityEngine.Font font)
  RVA=0x09E59BC8  token=0x600002B  System.Boolean HasCharacter(System.Char c)
  RVA=0x09E59BD8  token=0x600002C  System.Boolean HasCharacter(System.Int32 c)
  RVA=0x09E59C18  token=0x600002D  System.Void Internal_CreateFont(UnityEngine.Font self, System.String name)
END_CLASS

