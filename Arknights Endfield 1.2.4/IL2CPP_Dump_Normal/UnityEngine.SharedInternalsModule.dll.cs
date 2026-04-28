// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.SharedInternalsModule.dll
// Classes:  29
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace UnityEngine
{

    // TypeToken: 0x2000002  // size: 0x20
    public sealed class AssetFileNameExtensionAttribute : System.Attribute
    {
        // Fields
        private readonly System.String <preferredExtension>k__BackingField;  // 0x10
        private readonly System.Collections.Generic.IEnumerable<System.String> <otherExtensions>k__BackingField;  // 0x18

        // Methods
        // RVA: 0x03D49070  token: 0x6000001
        public System.Void .ctor(System.String preferredExtension, System.String[] otherExtensions) { }

    }

    // TypeToken: 0x2000003  // size: 0x10
    public class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class WritableAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000003
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class UnityEngineModuleAssembly : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public sealed class NativeClassAttribute : System.Attribute
    {
        // Fields
        private System.String <QualifiedNativeName>k__BackingField;  // 0x10
        private System.String <Declaration>k__BackingField;  // 0x18

        // Properties
        System.String QualifiedNativeName { set; /* RVA: 0x0426FEE0 */ }
        System.String Declaration { set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x03A5A4E0  token: 0x6000007
        public System.Void .ctor(System.String qualifiedCppName) { }
        // RVA: 0x02676770  token: 0x6000008
        public System.Void .ctor(System.String qualifiedCppName, System.String declaration) { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public sealed class UnityString
    {
        // Methods
        // RVA: 0x02E3A560  token: 0x6000009
        public static System.String Format(System.String fmt, System.Object[] args) { }

    }

}

namespace UnityEngine.Bindings
{

    // TypeToken: 0x2000008  // size: 0x10
    public class VisibleToOtherModulesAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600000A
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x600000B
        public System.Void .ctor(System.String[] modules) { }

    }

    // TypeToken: 0x2000009  // size: 0x28
    public class NativeConditionalAttribute : System.Attribute
    {
        // Fields
        private System.String <Condition>k__BackingField;  // 0x10
        private System.String <StubReturnStatement>k__BackingField;  // 0x18
        private System.Boolean <Enabled>k__BackingField;  // 0x20

        // Properties
        System.String Condition { set; /* RVA: 0x0426FEE0 */ }
        System.String StubReturnStatement { set; /* RVA: 0x022C3A90 */ }
        System.Boolean Enabled { set; /* RVA: 0x03D4EFC0 */ }

        // Methods
        // RVA: 0x03D4C380  token: 0x600000F
        public System.Void .ctor(System.String condition) { }
        // RVA: 0x09E28BB4  token: 0x6000010
        public System.Void .ctor(System.String condition, System.String stubReturnStatement) { }

    }

    // TypeToken: 0x200000A  // size: 0x18
    public class NativeHeaderAttribute : System.Attribute
    {
        // Fields
        private System.String <Header>k__BackingField;  // 0x10

        // Properties
        System.String Header { set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x03617700  token: 0x6000012
        public System.Void .ctor(System.String header) { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public class NativeNameAttribute : System.Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10

        // Properties
        System.String Name { set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x03CF6B60  token: 0x6000014
        public System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed class NativeWritableSelfAttribute : System.Attribute
    {
        // Fields
        private System.Boolean <WritableSelf>k__BackingField;  // 0x10

        // Properties
        System.Boolean WritableSelf { set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x01168960  token: 0x6000016
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x20
    public class NativeMethodAttribute : System.Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private System.Boolean <IsThreadSafe>k__BackingField;  // 0x18
        private System.Boolean <IsFreeFunction>k__BackingField;  // 0x19
        private System.Boolean <ThrowsException>k__BackingField;  // 0x1a
        private System.Boolean <HasExplicitThis>k__BackingField;  // 0x1b

        // Properties
        System.String Name { set; /* RVA: 0x0426FEE0 */ }
        System.Boolean IsThreadSafe { set; /* RVA: 0x01002B40 */ }
        System.Boolean IsFreeFunction { set; /* RVA: 0x03D4EFB0 */ }
        System.Boolean ThrowsException { set; /* RVA: 0x03D4EFD0 */ }
        System.Boolean HasExplicitThis { set; /* RVA: 0x03D522A0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600001C
        public System.Void .ctor() { }
        // RVA: 0x09E28C20  token: 0x600001D
        public System.Void .ctor(System.String name) { }
        // RVA: 0x09E28D38  token: 0x600001E
        public System.Void .ctor(System.String name, System.Boolean isFreeFunction) { }
        // RVA: 0x09E28BE4  token: 0x600001F
        public System.Void .ctor(System.String name, System.Boolean isFreeFunction, System.Boolean isThreadSafe) { }

    }

    // TypeToken: 0x200000E  // size: 0x14
    public sealed struct TargetType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Bindings.TargetType Function;  // const
        public static UnityEngine.Bindings.TargetType Field;  // const

    }

    // TypeToken: 0x200000F  // size: 0x28
    public class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
    {
        // Fields
        private UnityEngine.Bindings.TargetType <TargetType>k__BackingField;  // 0x20

        // Properties
        UnityEngine.Bindings.TargetType TargetType { set; /* RVA: 0x01003B60 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000021
        public System.Void .ctor() { }
        // RVA: 0x09E28D60  token: 0x6000022
        public System.Void .ctor(System.String name) { }
        // RVA: 0x09E28D68  token: 0x6000023
        public System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType) { }
        // RVA: 0x09E28DA0  token: 0x6000024
        public System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType, System.Boolean isThreadSafe) { }

    }

    // TypeToken: 0x2000010  // size: 0x14
    public sealed struct CodegenOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Bindings.CodegenOptions Auto;  // const
        public static UnityEngine.Bindings.CodegenOptions Custom;  // const
        public static UnityEngine.Bindings.CodegenOptions Force;  // const

    }

    // TypeToken: 0x2000011  // size: 0x10
    public class NativeAsStructAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000025
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x28
    public class NativeTypeAttribute : System.Attribute
    {
        // Fields
        private System.String <Header>k__BackingField;  // 0x10
        private System.String <IntermediateScriptingStructName>k__BackingField;  // 0x18
        private UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;  // 0x20

        // Properties
        System.String Header { set; /* RVA: 0x0426FEE0 */ }
        System.String IntermediateScriptingStructName { set; /* RVA: 0x022C3A90 */ }
        UnityEngine.Bindings.CodegenOptions CodegenOptions { set; /* RVA: 0x01003B60 */ }

        // Methods
        // RVA: 0x03D4E2C0  token: 0x6000029
        public System.Void .ctor() { }
        // RVA: 0x01003B60  token: 0x600002A
        public System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions) { }
        // RVA: 0x03CF35A0  token: 0x600002B
        public System.Void .ctor(System.String header) { }
        // RVA: 0x03D4D1F0  token: 0x600002C
        public System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions, System.String intermediateStructName) { }

    }

    // TypeToken: 0x2000013  // size: 0x18
    public class NotNullAttribute : System.Attribute
    {
        // Fields
        private System.String <Exception>k__BackingField;  // 0x10

        // Properties
        System.String Exception { set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600002E
        public System.Void .ctor(System.String exception) { }

    }

    // TypeToken: 0x2000014  // size: 0x10
    public class UnmarshalledAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600002F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x20
    public class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
    {
        // Methods
        // RVA: 0x03D5E9B0  token: 0x6000030
        public System.Void .ctor() { }
        // RVA: 0x09E28B78  token: 0x6000031
        public System.Void .ctor(System.String name) { }
        // RVA: 0x09E28B94  token: 0x6000032
        public System.Void .ctor(System.String name, System.Boolean isThreadSafe) { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
    {
        // Methods
        // RVA: 0x03D587A0  token: 0x6000033
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct StaticAccessorType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Bindings.StaticAccessorType Dot;  // const
        public static UnityEngine.Bindings.StaticAccessorType Arrow;  // const
        public static UnityEngine.Bindings.StaticAccessorType DoubleColon;  // const
        public static UnityEngine.Bindings.StaticAccessorType ArrowWithDefaultReturnIfNull;  // const

    }

    // TypeToken: 0x2000018  // size: 0x20
    public class StaticAccessorAttribute : System.Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private UnityEngine.Bindings.StaticAccessorType <Type>k__BackingField;  // 0x18

        // Properties
        System.String Name { set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Bindings.StaticAccessorType Type { set; /* RVA: 0x03D4E9C0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000036
        private System.Void .ctor(System.String name) { }
        // RVA: 0x02738A30  token: 0x6000037
        public System.Void .ctor(System.String name, UnityEngine.Bindings.StaticAccessorType type) { }

    }

    // TypeToken: 0x2000019  // size: 0x18
    public class NativeThrowsAttribute : System.Attribute
    {
        // Fields
        private System.Boolean <ThrowsException>k__BackingField;  // 0x10

        // Properties
        System.Boolean ThrowsException { set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x01168960  token: 0x6000039
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x18
    public class IgnoreAttribute : System.Attribute
    {
        // Fields
        private System.Boolean <DoesNotContributeToSize>k__BackingField;  // 0x10

        // Properties
        System.Boolean DoesNotContributeToSize { set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600003B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x10
    public class PreventReadOnlyInstanceModificationAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600003C
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.Scripting
{

    // TypeToken: 0x200001C  // size: 0x18
    public class UsedByNativeCodeAttribute : System.Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10

        // Properties
        System.String Name { set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600003D
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x600003E
        public System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x200001D  // size: 0x20
    public class RequiredByNativeCodeAttribute : System.Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;  // 0x10
        private System.Boolean <Optional>k__BackingField;  // 0x18
        private System.Boolean <GenerateProxy>k__BackingField;  // 0x19

        // Properties
        System.String Name { set; /* RVA: 0x0426FEE0 */ }
        System.Boolean Optional { set; /* RVA: 0x01002B40 */ }
        System.Boolean GenerateProxy { set; /* RVA: 0x03D4EFB0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000040
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x6000041
        public System.Void .ctor(System.String name) { }

    }

}

