// ========================================================
// Dumped by @desirepro
// Assembly: System.Runtime.Serialization.dll
// Classes:  5
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace System.Runtime.Serialization
{

    // TypeToken: 0x2000002  // size: 0x18
    public sealed class DataContractAttribute : System.Attribute
    {
        // Fields
        private System.Boolean isReference;  // 0x10

        // Properties
        System.Boolean IsReference { get; /* RVA: 0x011797F0 */ }

    }

    // TypeToken: 0x2000003  // size: 0x20
    public sealed class DataMemberAttribute : System.Attribute
    {
        // Fields
        private System.String name;  // 0x10
        private System.Int32 order;  // 0x18
        private System.Boolean isRequired;  // 0x1c
        private System.Boolean emitDefaultValue;  // 0x1d

        // Properties
        System.String Name { get; /* RVA: 0x020B7B20 */ }
        System.Int32 Order { get; /* RVA: 0x020D1AC0 */ }
        System.Boolean IsRequired { get; /* RVA: 0x03D4E9A0 */ }
        System.Boolean EmitDefaultValue { get; /* RVA: 0x03D50D90 */ }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public sealed class EnumMemberAttribute : System.Attribute
    {
        // Fields
        private System.String value;  // 0x10

        // Properties
        System.String Value { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000006
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public sealed class IgnoreDataMemberAttribute : System.Attribute
    {
    }

}

