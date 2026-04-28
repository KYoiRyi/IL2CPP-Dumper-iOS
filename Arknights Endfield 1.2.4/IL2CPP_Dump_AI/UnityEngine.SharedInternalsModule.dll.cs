// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.SharedInternalsModule.dll
// Classes:  29
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

CLASS: UnityEngine.AssetFileNameExtensionAttribute
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private   readonly System.String                   <preferredExtension>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.IEnumerable<System.String><otherExtensions>k__BackingField  // 0x18
METHODS:
  RVA=0x03D49070  token=0x6000001  System.Void .ctor(System.String preferredExtension, System.String[] otherExtensions)
END_CLASS

CLASS: UnityEngine.ThreadAndSerializationSafeAttribute
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.WritableAttribute
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000003  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UnityEngineModuleAssembly
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.NativeClassAttribute
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <QualifiedNativeName>k__BackingField  // 0x10
  private           System.String                   <Declaration>k__BackingField  // 0x18
PROPERTIES:
  QualifiedNativeName  set=0x0426FEE0
  Declaration  set=0x022C3A90
METHODS:
  RVA=0x03A5A4E0  token=0x6000007  System.Void .ctor(System.String qualifiedCppName)
  RVA=0x02676770  token=0x6000008  System.Void .ctor(System.String qualifiedCppName, System.String declaration)
END_CLASS

CLASS: UnityEngine.UnityString
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02E3A560  token=0x6000009  System.String Format(System.String fmt, System.Object[] args)
END_CLASS

CLASS: UnityEngine.Bindings.VisibleToOtherModulesAttribute
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600000A  System.Void .ctor()
  RVA=0x0350B670  token=0x600000B  System.Void .ctor(System.String[] modules)
END_CLASS

CLASS: UnityEngine.Bindings.NativeConditionalAttribute
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x28
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Condition>k__BackingField  // 0x10
  private           System.String                   <StubReturnStatement>k__BackingField  // 0x18
  private           System.Boolean                  <Enabled>k__BackingField  // 0x20
PROPERTIES:
  Condition  set=0x0426FEE0
  StubReturnStatement  set=0x022C3A90
  Enabled  set=0x03D4EFC0
METHODS:
  RVA=0x03D4C380  token=0x600000F  System.Void .ctor(System.String condition)
  RVA=0x09E28BB4  token=0x6000010  System.Void .ctor(System.String condition, System.String stubReturnStatement)
END_CLASS

CLASS: UnityEngine.Bindings.NativeHeaderAttribute
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Header>k__BackingField  // 0x10
PROPERTIES:
  Header  set=0x0426FEE0
METHODS:
  RVA=0x03617700  token=0x6000012  System.Void .ctor(System.String header)
END_CLASS

CLASS: UnityEngine.Bindings.NativeNameAttribute
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
PROPERTIES:
  Name  set=0x0426FEE0
METHODS:
  RVA=0x03CF6B60  token=0x6000014  System.Void .ctor(System.String name)
END_CLASS

CLASS: UnityEngine.Bindings.NativeWritableSelfAttribute
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.Boolean                  <WritableSelf>k__BackingField  // 0x10
PROPERTIES:
  WritableSelf  set=0x03D4E960
METHODS:
  RVA=0x01168960  token=0x6000016  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.NativeMethodAttribute
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Boolean                  <IsThreadSafe>k__BackingField  // 0x18
  private           System.Boolean                  <IsFreeFunction>k__BackingField  // 0x19
  private           System.Boolean                  <ThrowsException>k__BackingField  // 0x1a
  private           System.Boolean                  <HasExplicitThis>k__BackingField  // 0x1b
PROPERTIES:
  Name  set=0x0426FEE0
  IsThreadSafe  set=0x01002B40
  IsFreeFunction  set=0x03D4EFB0
  ThrowsException  set=0x03D4EFD0
  HasExplicitThis  set=0x03D522A0
METHODS:
  RVA=0x0350B670  token=0x600001C  System.Void .ctor()
  RVA=0x09E28C20  token=0x600001D  System.Void .ctor(System.String name)
  RVA=0x09E28D38  token=0x600001E  System.Void .ctor(System.String name, System.Boolean isFreeFunction)
  RVA=0x09E28BE4  token=0x600001F  System.Void .ctor(System.String name, System.Boolean isFreeFunction, System.Boolean isThreadSafe)
END_CLASS

CLASS: UnityEngine.Bindings.TargetType
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Bindings.TargetType Function  // const
  public    static  UnityEngine.Bindings.TargetType Field  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Bindings.NativePropertyAttribute
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x28
EXTENDS: UnityEngine.Bindings.NativeMethodAttribute
FIELDS:
  private           UnityEngine.Bindings.TargetType <TargetType>k__BackingField  // 0x20
PROPERTIES:
  TargetType  set=0x01003B60
METHODS:
  RVA=0x0350B670  token=0x6000021  System.Void .ctor()
  RVA=0x09E28D60  token=0x6000022  System.Void .ctor(System.String name)
  RVA=0x09E28D68  token=0x6000023  System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType)
  RVA=0x09E28DA0  token=0x6000024  System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType, System.Boolean isThreadSafe)
END_CLASS

CLASS: UnityEngine.Bindings.CodegenOptions
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Bindings.CodegenOptionsAuto  // const
  public    static  UnityEngine.Bindings.CodegenOptionsCustom  // const
  public    static  UnityEngine.Bindings.CodegenOptionsForce  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Bindings.NativeAsStructAttribute
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000025  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.NativeTypeAttribute
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x28
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Header>k__BackingField  // 0x10
  private           System.String                   <IntermediateScriptingStructName>k__BackingField  // 0x18
  private           UnityEngine.Bindings.CodegenOptions<CodegenOptions>k__BackingField  // 0x20
PROPERTIES:
  Header  set=0x0426FEE0
  IntermediateScriptingStructName  set=0x022C3A90
  CodegenOptions  set=0x01003B60
METHODS:
  RVA=0x03D4E2C0  token=0x6000029  System.Void .ctor()
  RVA=0x01003B60  token=0x600002A  System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions)
  RVA=0x03CF35A0  token=0x600002B  System.Void .ctor(System.String header)
  RVA=0x03D4D1F0  token=0x600002C  System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions, System.String intermediateStructName)
END_CLASS

CLASS: UnityEngine.Bindings.NotNullAttribute
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Exception>k__BackingField  // 0x10
PROPERTIES:
  Exception  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x600002E  System.Void .ctor(System.String exception)
END_CLASS

CLASS: UnityEngine.Bindings.UnmarshalledAttribute
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600002F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.FreeFunctionAttribute
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x20
EXTENDS: UnityEngine.Bindings.NativeMethodAttribute
FIELDS:
METHODS:
  RVA=0x03D5E9B0  token=0x6000030  System.Void .ctor()
  RVA=0x09E28B78  token=0x6000031  System.Void .ctor(System.String name)
  RVA=0x09E28B94  token=0x6000032  System.Void .ctor(System.String name, System.Boolean isThreadSafe)
END_CLASS

CLASS: UnityEngine.Bindings.ThreadSafeAttribute
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x20
EXTENDS: UnityEngine.Bindings.NativeMethodAttribute
FIELDS:
METHODS:
  RVA=0x03D587A0  token=0x6000033  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.StaticAccessorType
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Bindings.StaticAccessorTypeDot  // const
  public    static  UnityEngine.Bindings.StaticAccessorTypeArrow  // const
  public    static  UnityEngine.Bindings.StaticAccessorTypeDoubleColon  // const
  public    static  UnityEngine.Bindings.StaticAccessorTypeArrowWithDefaultReturnIfNull  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Bindings.StaticAccessorAttribute
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           UnityEngine.Bindings.StaticAccessorType<Type>k__BackingField  // 0x18
PROPERTIES:
  Name  set=0x0426FEE0
  Type  set=0x03D4E9C0
METHODS:
  RVA=0x0426FEE0  token=0x6000036  System.Void .ctor(System.String name)
  RVA=0x02738A30  token=0x6000037  System.Void .ctor(System.String name, UnityEngine.Bindings.StaticAccessorType type)
END_CLASS

CLASS: UnityEngine.Bindings.NativeThrowsAttribute
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.Boolean                  <ThrowsException>k__BackingField  // 0x10
PROPERTIES:
  ThrowsException  set=0x03D4E960
METHODS:
  RVA=0x01168960  token=0x6000039  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.IgnoreAttribute
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.Boolean                  <DoesNotContributeToSize>k__BackingField  // 0x10
PROPERTIES:
  DoesNotContributeToSize  set=0x03D4E960
METHODS:
  RVA=0x0350B670  token=0x600003B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.PreventReadOnlyInstanceModificationAttribute
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600003C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Scripting.UsedByNativeCodeAttribute
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
PROPERTIES:
  Name  set=0x0426FEE0
METHODS:
  RVA=0x0350B670  token=0x600003D  System.Void .ctor()
  RVA=0x0426FEE0  token=0x600003E  System.Void .ctor(System.String name)
END_CLASS

CLASS: UnityEngine.Scripting.RequiredByNativeCodeAttribute
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Boolean                  <Optional>k__BackingField  // 0x18
  private           System.Boolean                  <GenerateProxy>k__BackingField  // 0x19
PROPERTIES:
  Name  set=0x0426FEE0
  Optional  set=0x01002B40
  GenerateProxy  set=0x03D4EFB0
METHODS:
  RVA=0x0350B670  token=0x6000040  System.Void .ctor()
  RVA=0x0426FEE0  token=0x6000041  System.Void .ctor(System.String name)
END_CLASS

