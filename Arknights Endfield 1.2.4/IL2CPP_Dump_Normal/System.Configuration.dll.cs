// ========================================================
// Dumped by @desirepro
// Assembly: System.Configuration.dll
// Classes:  10
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace System.Configuration
{

    // TypeToken: 0x2000002  // size: 0x10
    public abstract class ConfigurationElement
    {
        // Properties
        System.Configuration.ConfigurationPropertyCollection Properties { get; /* RVA: 0x096D0E70 */ }

        // Methods
        // RVA: 0x096D0DE0  token: 0x6000002
        protected internal virtual System.Boolean IsModified() { }
        // RVA: 0x096D0E40  token: 0x6000003
        protected internal virtual System.Void Reset(System.Configuration.ConfigurationElement parentElement) { }
        // RVA: 0x096D0E10  token: 0x6000004
        protected internal virtual System.Void ResetModified() { }

    }

    // TypeToken: 0x2000003  // size: 0x10
    public abstract class ConfigurationSection : System.Configuration.ConfigurationElement
    {
        // Methods
        // RVA: 0x096D0EA0  token: 0x6000005
        protected internal virtual System.Void DeserializeSection(System.Xml.XmlReader reader) { }
        // RVA: 0x096D0ED0  token: 0x6000006
        protected internal virtual System.Boolean IsModified() { }
        // RVA: 0x096D0F00  token: 0x6000007
        protected internal virtual System.Void ResetModified() { }
        // RVA: 0x096D0F30  token: 0x6000008
        protected internal virtual System.String SerializeSection(System.Configuration.ConfigurationElement parentElement, System.String name, System.Configuration.ConfigurationSaveMode saveMode) { }

    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct ConfigurationSaveMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.Configuration.ConfigurationSaveMode Full;  // const
        public static System.Configuration.ConfigurationSaveMode Minimal;  // const
        public static System.Configuration.ConfigurationSaveMode Modified;  // const

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class ConfigurationPropertyCollection
    {
    }

    // TypeToken: 0x2000006  // size: 0x10
    public abstract class ConfigurationElementCollection : System.Configuration.ConfigurationElement
    {
    }

    // TypeToken: 0x2000007  // size: 0x10
    public sealed class ConfigurationCollectionAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000009
        public System.Void .ctor(System.Type itemType) { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public class ConfigurationSectionGroup
    {
    }

    // TypeToken: 0x2000009  // size: 0x10
    public sealed class IgnoreSection : System.Configuration.ConfigurationSection
    {
        // Properties
        System.Configuration.ConfigurationPropertyCollection Properties { get; /* RVA: 0x096D1080 */ }

        // Methods
        // RVA: 0x096D1050  token: 0x600000A
        public System.Void .ctor() { }
        // RVA: 0x096D0F60  token: 0x600000C
        protected internal virtual System.Void DeserializeSection(System.Xml.XmlReader xmlReader) { }
        // RVA: 0x096D0F90  token: 0x600000D
        protected internal virtual System.Boolean IsModified() { }
        // RVA: 0x096D0FF0  token: 0x600000E
        protected internal virtual System.Void Reset(System.Configuration.ConfigurationElement parentSection) { }
        // RVA: 0x096D0FC0  token: 0x600000F
        protected internal virtual System.Void ResetModified() { }
        // RVA: 0x096D1020  token: 0x6000010
        protected internal virtual System.String SerializeSection(System.Configuration.ConfigurationElement parentSection, System.String name, System.Configuration.ConfigurationSaveMode saveMode) { }

    }

}

namespace Unity
{

    // TypeToken: 0x200000A  // size: 0x98
    public sealed class ThrowStub : System.ObjectDisposedException
    {
        // Methods
        // RVA: 0x096D10B0  token: 0x6000011
        public static System.Void ThrowNotSupportedException() { }

    }

}

