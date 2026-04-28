// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Formats.USD.Common.dll
// Classes:  10
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

CLASS: UsageAnalyticsData
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x20
FIELDS:
  public            System.Boolean                  InitSucceeded  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
METHODS:
END_CLASS

CLASS: ImportAnalyticsData
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x28
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  IncludesMeshes  // 0x21
  public            System.Boolean                  IncludesPointInstancer  // 0x22
  public            System.Boolean                  IncludesMaterials  // 0x23
  public            System.Boolean                  IncludesSkel  // 0x24
METHODS:
END_CLASS

CLASS: ImportResult
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x1C
FIELDS:
  public            System.Boolean                  Success  // 0x10
  public            Unity.Formats.USD.ImportType    ImportType  // 0x14
  public            System.Boolean                  ContainsMeshes  // 0x18
  public            System.Boolean                  ContainsPointInstancer  // 0x19
  public            System.Boolean                  ContainsSkel  // 0x1a
  public            System.Boolean                  ContainsMaterials  // 0x1b
PROPERTIES:
  Default  get=0x03D4E630
METHODS:
END_CLASS

CLASS: ReimportAnalyticsData
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x28
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  ForceRebuild  // 0x21
  public            System.Boolean                  IncludesMeshes  // 0x22
  public            System.Boolean                  IncludesPointInstancer  // 0x23
  public            System.Boolean                  IncludesMaterials  // 0x24
  public            System.Boolean                  IncludesSkel  // 0x25
METHODS:
END_CLASS

CLASS: ExportAnalyticsData
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x28
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  OnlyOverrides  // 0x21
METHODS:
END_CLASS

CLASS: RecorderExportAnalyticsData
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x28
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  OnlyOverrides  // 0x21
  public            System.Int32                    FrameCount  // 0x24
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.InitUsd
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  m_usdInitialized  // static @ 0x0
  private   static  System.Boolean                  m_usdInitializeFailed  // static @ 0x1
  private   static  USD.NET.Unity.DiagnosticHandler m_handler  // static @ 0x8
METHODS:
  RVA=0x09B68EC0  token=0x6000001  System.Boolean Initialize()
  RVA=0x09B69160  token=0x6000002  System.Void SetupUsdPath(System.String sourceFilePath)
END_CLASS

CLASS: Unity.Formats.USD.ImportType
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.ImportType    Initial  // const
  public    static  Unity.Formats.USD.ImportType    ForceRebuild  // const
  public    static  Unity.Formats.USD.ImportType    Refresh  // const
  public    static  Unity.Formats.USD.ImportType    Streaming  // const
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.UsdEditorAnalytics
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    k_MaxEventsPerHour  // const
  private   static  System.Int32                    k_MaxNumberOfElements  // const
  private   static  System.String                   k_VendorKey  // const
  private   static  System.String                   k_UsageEventName  // const
  private   static  System.String                   k_ImportEventName  // const
  private   static  System.String                   k_ReimportEventName  // const
  private   static  System.String                   k_ExportEventName  // const
  private   static  System.String                   k_RecorderExportEventName  // const
  public    static  System.Collections.Generic.Dictionary<System.String,System.Boolean>sUsdEditorAnalyticsEvents  // static @ 0x0
METHODS:
  RVA=0x0115F4C0  token=0x6000003  System.Boolean RegisterAnalytics(System.String eventName)
  RVA=0x0350B670  token=0x6000004  System.Void SendUsageEvent(System.Boolean success, System.Double timeTakenMs)
  RVA=0x0350B670  token=0x6000005  System.Void SendImportEvent(System.String fileExtension, System.Double timeTakenMs, Unity.Formats.USD.UsdEditorAnalytics.ImportResult importResult)
  RVA=0x0350B670  token=0x6000006  System.Void SendReimportEvent(System.String fileExtension, System.Double timeTakenMs, Unity.Formats.USD.UsdEditorAnalytics.ImportResult importResult)
  RVA=0x0350B670  token=0x6000007  System.Void SendExportEvent(System.String fileExtension, System.Double timeTakenMs, System.Boolean exportSucceeded, System.Boolean onlyOverrides)
  RVA=0x0350B670  token=0x6000008  System.Void SendRecorderExportEvent(System.String fileExtension, System.Double timeTakenMs, System.Boolean exportSucceeded, System.Boolean onlyOverrides, System.Int32 frameCount)
  RVA=0x09B69298  token=0x6000009  System.Void .cctor()
END_CLASS

