// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextCoreFontEngineModule.dll
// Classes:  20
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

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TextCore.FaceInfo
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x70
FIELDS:
  private           System.Int32                    m_FaceIndex  // 0x10
  private           System.String                   m_FamilyName  // 0x18
  private           System.String                   m_StyleName  // 0x20
  private           System.Int32                    m_PointSize  // 0x28
  private           System.Single                   m_Scale  // 0x2c
  private           System.Int32                    m_UnitsPerEM  // 0x30
  private           System.Single                   m_LineHeight  // 0x34
  private           System.Single                   m_AscentLine  // 0x38
  private           System.Single                   m_CapLine  // 0x3c
  private           System.Single                   m_MeanLine  // 0x40
  private           System.Single                   m_Baseline  // 0x44
  private           System.Single                   m_DescentLine  // 0x48
  private           System.Single                   m_SuperscriptOffset  // 0x4c
  private           System.Single                   m_SuperscriptSize  // 0x50
  private           System.Single                   m_SubscriptOffset  // 0x54
  private           System.Single                   m_SubscriptSize  // 0x58
  private           System.Single                   m_UnderlineOffset  // 0x5c
  private           System.Single                   m_UnderlineThickness  // 0x60
  private           System.Single                   m_StrikethroughOffset  // 0x64
  private           System.Single                   m_StrikethroughThickness  // 0x68
  private           System.Single                   m_TabWidth  // 0x6c
PROPERTIES:
  faceIndex  get=0x03D85860
  familyName  get=0x03D85A90  set=0x0558FF08
  styleName  get=0x03D66B80  set=0x0426FEE0
  pointSize  get=0x03D68AE0  set=0x03D4E9C0
  scale  get=0x03D87EB0  set=0x03D4F120
  lineHeight  get=0x03D86CB0  set=0x03D52500
  ascentLine  get=0x03D88060  set=0x03D4F490
  capLine  get=0x03D87EE0  set=0x03D4F3B0
  meanLine  get=0x03D84BA0  set=0x03D4F5E0
  baseline  get=0x042743D0  set=0x03D56CB0
  descentLine  get=0x04270730  set=0x03D51010
  superscriptOffset  get=0x04270790  set=0x03D4ECE0
  superscriptSize  get=0x04270740  set=0x03D4ECF0
  subscriptOffset  get=0x04270750  set=0x03D4ED00
  subscriptSize  get=0x04270760  set=0x03D5BE60
  underlineOffset  get=0x03D88030  set=0x03D5E680
  underlineThickness  get=0x03D88080  set=0x03D51CA0
  strikethroughOffset  get=0x03D88040  set=0x03D4F680
  strikethroughThickness  set=0x03D510B0
  tabWidth  get=0x03D88070  set=0x03D5BDF0
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.GlyphClassDefinitionType
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeUndefined  // const
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeBase  // const
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeLigature  // const
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeMark  // const
  public    static  UnityEngine.TextCore.GlyphClassDefinitionTypeComponent  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.GlyphRect
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Int32                    m_X  // 0x10
  private           System.Int32                    m_Y  // 0x14
  private           System.Int32                    m_Width  // 0x18
  private           System.Int32                    m_Height  // 0x1c
  private   static readonly UnityEngine.TextCore.GlyphRect  s_ZeroGlyphRect  // static @ 0x0
PROPERTIES:
  x  get=0x03D85860
  y  get=0x03D698C0
  width  get=0x03D68070
  height  get=0x03D682F0
  zero  get=0x02EE9550
METHODS:
  RVA=0x03D517E0  token=0x600002E  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
  RVA=0x09E2F6F0  token=0x600002F  System.Int32 GetHashCode()
  RVA=0x09E2F690  token=0x6000030  System.Boolean Equals(System.Object obj)
  RVA=0x09E2F614  token=0x6000031  System.Boolean Equals(UnityEngine.TextCore.GlyphRect other)
  RVA=0x03D3E8A0  token=0x6000032  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.GlyphMetrics
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x24
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Single                   m_Width  // 0x10
  private           System.Single                   m_Height  // 0x14
  private           System.Single                   m_HorizontalBearingX  // 0x18
  private           System.Single                   m_HorizontalBearingY  // 0x1c
  private           System.Single                   m_HorizontalAdvance  // 0x20
PROPERTIES:
  width  get=0x03D85AE0
  height  get=0x03D85850
  horizontalBearingX  get=0x03D85840
  horizontalBearingY  get=0x03D85A60
  horizontalAdvance  get=0x03D85830
METHODS:
  RVA=0x03D88090  token=0x6000038  System.Void .ctor(System.Single width, System.Single height, System.Single bearingX, System.Single bearingY, System.Single advance)
  RVA=0x09E2F430  token=0x6000039  System.Int32 GetHashCode()
  RVA=0x09E2F3CC  token=0x600003A  System.Boolean Equals(System.Object obj)
  RVA=0x09E2F344  token=0x600003B  System.Boolean Equals(UnityEngine.TextCore.GlyphMetrics other)
END_CLASS

CLASS: UnityEngine.TextCore.Glyph
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x48
FIELDS:
  private           System.UInt32                   m_Index  // 0x10
  private           UnityEngine.TextCore.GlyphMetricsm_Metrics  // 0x14
  private           UnityEngine.TextCore.GlyphRect  m_GlyphRect  // 0x28
  private           System.Single                   m_Scale  // 0x38
  private           System.Int32                    m_AtlasIndex  // 0x3c
  private           UnityEngine.TextCore.GlyphClassDefinitionTypem_ClassDefinitionType  // 0x40
PROPERTIES:
  index  get=0x03D85B00  set=0x010410F0
  metrics  get=0x03D625F0  set=0x03D88120
  glyphRect  get=0x03D87CE0  set=0x03D59E30
  scale  get=0x04270730  set=0x03D51010
  atlasIndex  get=0x03D85950  set=0x03D4EDC0
  classDefinitionType  get=0x03D85940
METHODS:
  RVA=0x031B6460  token=0x6000047  System.Void .ctor()
  RVA=0x02EE7AE0  token=0x6000048  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
  RVA=0x03D880F0  token=0x6000049  System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphLoadFlags
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_DEFAULT  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_SCALE  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_HINTING  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_RENDER  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_BITMAP  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_FORCE_AUTOHINT  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_MONOCHROME  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_NO_AUTOHINT  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_COLOR  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_COMPUTE_METRICS  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphLoadFlagsLOAD_BITMAP_METRICS_ONLY  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontEngineError
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorSuccess  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File_Path  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File_Format  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File_Structure  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_File  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Table  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Glyph_Index  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Character_Code  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Pixel_Size  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Library  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Face  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_Library_or_Face  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorAtlas_Generation_Cancelled  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorInvalid_SharedTextureData  // const
  public    static  UnityEngine.TextCore.LowLevel.FontEngineErrorOpenTypeLayoutLookup_Mismatch  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphRenderMode
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSMOOTH_HINTED  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSMOOTH  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeCOLOR_HINTED  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeCOLOR  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeRASTER_HINTED  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeRASTER  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF8  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF16  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDF32  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDFAA_HINTED  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDFAA  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphRenderModeSDFBezier  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphPackingMode
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBestShortSideFit  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBestLongSideFit  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBestAreaFit  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeBottomLeftRule  // const
  public    static  UnityEngine.TextCore.LowLevel.GlyphPackingModeContactPointRule  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontReference
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x30
FIELDS:
  public            System.String                   familyName  // 0x10
  public            System.String                   styleName  // 0x18
  public            System.Int32                    faceIndex  // 0x20
  public            System.String                   filePath  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontEngine
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.TextCore.Glyph[]    s_Glyphs  // static @ 0x0
  private   static  System.UInt32[]                 s_GlyphIndexes_MarshallingArray_A  // static @ 0x8
  private   static  UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[]s_GlyphMarshallingStruct_IN  // static @ 0x10
  private   static  UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[]s_GlyphMarshallingStruct_OUT  // static @ 0x18
  private   static  UnityEngine.TextCore.GlyphRect[]s_FreeGlyphRects  // static @ 0x20
  private   static  UnityEngine.TextCore.GlyphRect[]s_UsedGlyphRects  // static @ 0x28
  private   static  UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]s_PairAdjustmentRecords_MarshallingArray  // static @ 0x30
  private   static  System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph>s_GlyphLookupDictionary  // static @ 0x38
METHODS:
  RVA=0x09E2E2DC  token=0x600004A  UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine()
  RVA=0x09E2E2B0  token=0x600004B  System.Int32 InitializeFontEngine_Internal()
  RVA=0x09E2E470  token=0x600004C  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(System.String filePath, System.Int32 pointSize, System.Int32 faceIndex)
  RVA=0x09E2E31C  token=0x600004D  System.Int32 LoadFontFace_With_Size_And_FaceIndex_Internal(System.String filePath, System.Int32 pointSize, System.Int32 faceIndex)
  RVA=0x02EE9AE0  token=0x600004E  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, System.Int32 pointSize)
  RVA=0x02EE9B40  token=0x600004F  System.Int32 LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, System.Int32 pointSize)
  RVA=0x09E2E410  token=0x6000050  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, System.Int32 pointSize, System.Int32 faceIndex)
  RVA=0x09E2E36C  token=0x6000051  System.Int32 LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, System.Int32 pointSize, System.Int32 faceIndex)
  RVA=0x09E2E4D0  token=0x6000052  UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(System.String familyName, System.String styleName, System.Int32 pointSize)
  RVA=0x09E2E3BC  token=0x6000053  System.Int32 LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(System.String familyName, System.String styleName, System.Int32 pointSize)
  RVA=0x09E2F1A4  token=0x6000054  System.Boolean TryGetSystemFontReference(System.String familyName, System.String styleName, UnityEngine.TextCore.LowLevel.FontReference& fontRef)
  RVA=0x09E2F150  token=0x6000055  System.Boolean TryGetSystemFontReference_Internal(System.String familyName, System.String styleName, UnityEngine.TextCore.LowLevel.FontReference& fontRef)
  RVA=0x09E2E0D8  token=0x6000056  UnityEngine.TextCore.FaceInfo GetFaceInfo()
  RVA=0x09E2E0A4  token=0x6000057  System.Int32 GetFaceInfo_Internal(UnityEngine.TextCore.FaceInfo& faceInfo)
  RVA=0x02EE95C0  token=0x6000058  System.UInt32 GetGlyphIndex(System.UInt32 unicode)
  RVA=0x09E2F038  token=0x6000059  System.Boolean TryGetGlyphWithUnicodeValue(System.UInt32 unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, UnityEngine.TextCore.Glyph& glyph)
  RVA=0x09E2EFE8  token=0x600005A  System.Boolean TryGetGlyphWithUnicodeValue_Internal(System.UInt32 unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyphStruct)
  RVA=0x09E2EED0  token=0x600005B  System.Boolean TryGetGlyphWithIndexValue(System.UInt32 glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, UnityEngine.TextCore.Glyph& glyph)
  RVA=0x09E2EE80  token=0x600005C  System.Boolean TryGetGlyphWithIndexValue_Internal(System.UInt32 glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyphStruct)
  RVA=0x02EE8C60  token=0x600005D  System.Void AddGlyphToTextureByGpu(UnityEngine.TextCore.Glyph& glyph, System.Int32 padding, UnityEngine.RenderTexture texture)
  RVA=0x02EE8D70  token=0x600005E  System.Boolean AddGlyphToTextureByGpu_Internal(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyph, System.Int32 padding, UnityEngine.RenderTexture texture)
  RVA=0x09E2E584  token=0x600005F  System.Void ProcessSDFGenerationRequest(UnityEngine.Material material, UnityEngine.Rendering.ScriptableRenderContext scriptableRenderContext, UnityEngine.Rendering.CommandBuffer cmd)
  RVA=0x09E2E530  token=0x6000060  System.Void ProcessSDFGenerationRequest_Internal(UnityEngine.Material material, System.IntPtr scriptableRenderContext, UnityEngine.Rendering.CommandBuffer cmd)
  RVA=0x09E2E630  token=0x6000061  System.Void SetTextureUploadMode(System.Boolean shouldUploadImmediately)
  RVA=0x02EE7570  token=0x6000062  System.Boolean TryAddGlyphToTexture(System.UInt32 glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture texture, UnityEngine.TextCore.Glyph& glyph)
  RVA=0x02EE7A70  token=0x6000063  System.Boolean TryAddGlyphToTexture_Internal(System.UInt32 glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, System.Int32& freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, System.Int32& usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct& glyph)
  RVA=0x09E2E6C8  token=0x6000064  System.Boolean TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture texture, UnityEngine.TextCore.Glyph[]& glyphs)
  RVA=0x09E2E664  token=0x6000065  System.Boolean TryAddGlyphsToTexture_Internal(System.UInt32[] glyphIndex, System.Int32 padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, System.Int32& freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, System.Int32& usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, System.Int32& glyphCount)
  RVA=0x09E2E178  token=0x6000066  UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(System.UInt32[] glyphIndexes)
  RVA=0x03A1F3E0  token=0x6000067  UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes, System.Int32& recordCount)
  RVA=0x03A1F490  token=0x6000068  System.Int32 PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(System.UInt32[] glyphIndexes, System.Int32& recordCount)
  RVA=0x09E2E27C  token=0x6000069  System.Int32 GetPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords)
  RVA=-1  // generic def  token=0x600006A  System.Void GenericListToMarshallingArray(System.Collections.Generic.List<T>& srcList, T[]& dstArray)
  RVA=-1  // generic def  token=0x600006B  System.Void SetMarshallingArraySize(T[]& marshallingArray, System.Int32 recordCount)
  RVA=0x09E2E5FC  token=0x600006C  System.Void ResetAtlasTexture(UnityEngine.Texture2D texture)
  RVA=0x02EE7C10  token=0x600006D  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontEngineUtilities
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x11
FIELDS:
METHODS:
  RVA=0x09E2E088  token=0x600006E  System.Int32 MaxValue(System.Int32 a, System.Int32 b, System.Int32 c)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x44
FIELDS:
  public            System.UInt32                   index  // 0x10
  public            UnityEngine.TextCore.GlyphMetricsmetrics  // 0x14
  public            UnityEngine.TextCore.GlyphRect  glyphRect  // 0x28
  public            System.Single                   scale  // 0x38
  public            System.Int32                    atlasIndex  // 0x3c
  public            UnityEngine.TextCore.GlyphClassDefinitionTypeclassDefinitionType  // 0x40
METHODS:
  RVA=0x02EE8D20  token=0x600006F  System.Void .ctor(UnityEngine.TextCore.Glyph glyph)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsNone  // const
  public    static  UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsIgnoreLigatures  // const
  public    static  UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsIgnoreSpacingAdjustments  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphValueRecord
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Single                   m_XPlacement  // 0x10
  private           System.Single                   m_YPlacement  // 0x14
  private           System.Single                   m_XAdvance  // 0x18
  private           System.Single                   m_YAdvance  // 0x1c
PROPERTIES:
  xPlacement  get=0x03D85AE0
  yPlacement  get=0x03D85850
  xAdvance  get=0x03D85840
  yAdvance  get=0x03D85A60
METHODS:
  RVA=0x03D880D0  token=0x6000074  UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b)
  RVA=0x09E2F81C  token=0x6000075  System.Int32 GetHashCode()
  RVA=0x09E2F740  token=0x6000076  System.Boolean Equals(System.Object obj)
  RVA=0x09E2F7A0  token=0x6000077  System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x24
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.UInt32                   m_GlyphIndex  // 0x10
  private           UnityEngine.TextCore.LowLevel.GlyphValueRecordm_GlyphValueRecord  // 0x14
PROPERTIES:
  glyphIndex  get=0x03D85860
  glyphValueRecord  get=0x03D879E0
METHODS:
  RVA=0x09E2F2F0  token=0x600007A  System.Int32 GetHashCode()
  RVA=0x09E2F28C  token=0x600007B  System.Boolean Equals(System.Object obj)
  RVA=0x09E2F204  token=0x600007C  System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other)
END_CLASS

CLASS: UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x3C
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecordm_FirstAdjustmentRecord  // 0x10
  private           UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecordm_SecondAdjustmentRecord  // 0x24
  private           UnityEngine.TextCore.LowLevel.FontFeatureLookupFlagsm_FeatureLookupFlags  // 0x38
PROPERTIES:
  firstAdjustmentRecord  get=0x03D880C0
  secondAdjustmentRecord  get=0x03D625F0
METHODS:
  RVA=0x09E2F5AC  token=0x600007F  System.Int32 GetHashCode()
  RVA=0x09E2F484  token=0x6000080  System.Boolean Equals(System.Object obj)
  RVA=0x09E2F4FC  token=0x6000081  System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other)
END_CLASS

