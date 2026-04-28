// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.VisualScripting.dll
// Classes:  7
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x28
    public sealed class <>c__DisplayClass13_0
    {
        // Fields
        public Unity.VisualScripting.Flow flow;  // 0x10
        public HoudiniEngineUnity.HEU_InstantiateHDA <>4__this;  // 0x18
        public System.Action ContinueFlow;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000008
        public System.Void .ctor() { }
        // RVA: 0x087F0F0C  token: 0x6000009
        private System.Void <TriggerButton>b__0() { }
        // RVA: 0x087F0F5C  token: 0x600000A
        private System.Void <TriggerButton>b__1(HoudiniEngineUnity.HEU_ReloadEventData data) { }

    }

    // TypeToken: 0x2000005  // size: 0x20
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public Unity.VisualScripting.Flow flow;  // 0x10
        public HoudiniEngineUnity.HEU_ModifyHDA <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000010
        public System.Void .ctor() { }
        // RVA: 0x087F0F94  token: 0x6000011
        private System.Void <TriggerButton>b__0() { }

    }

namespace HoudiniEngineUnity
{

    // TypeToken: 0x2000002  // size: 0xD0
    public class HEU_InstantiateHDA : Unity.VisualScripting.ManualEventUnit`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_UnitButton triggerButton;  // 0x80
        public Unity.VisualScripting.ValueInput inputPath;  // 0x88
        public Unity.VisualScripting.ValueInput inputAsync;  // 0x90
        public Unity.VisualScripting.ValueInput inputPosition;  // 0x98
        public Unity.VisualScripting.ValueOutput outputHDARoot;  // 0xa0
        public Unity.VisualScripting.ValueOutput outputHDAAsset;  // 0xa8
        public Unity.VisualScripting.ValueOutput outputSuccess;  // 0xb0
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot hdaRoot;  // 0xb8
        private HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset;  // 0xc0
        private System.Boolean bSuccess;  // 0xc8

        // Properties
        System.String hookName { get; /* RVA: 0x087F0BC4 */ }

        // Methods
        // RVA: 0x087F04B8  token: 0x6000002
        protected virtual System.Void Definition() { }
        // RVA: 0x087F0794  token: 0x6000003
        public System.Void TriggerButton(Unity.VisualScripting.GraphReference reference) { }
        // RVA: 0x087F0B88  token: 0x6000004
        public System.Void .ctor() { }
        // RVA: 0x03D4E750  token: 0x6000005
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot <Definition>b__12_0(Unity.VisualScripting.Flow flow) { }
        // RVA: 0x03D50E60  token: 0x6000006
        private HoudiniEngineUnity.HEU_HoudiniAsset <Definition>b__12_1(Unity.VisualScripting.Flow flow) { }
        // RVA: 0x03D519D0  token: 0x6000007
        private System.Boolean <Definition>b__12_2(Unity.VisualScripting.Flow flow) { }

    }

    // TypeToken: 0x2000004  // size: 0xA0
    public class HEU_ModifyHDA : Unity.VisualScripting.ManualEventUnit`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_UnitButton triggerButton;  // 0x80
        public Unity.VisualScripting.ValueInput inputHDA;  // 0x88
        public Unity.VisualScripting.ValueOutput outputHDAAsset;  // 0x90
        private HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset;  // 0x98

        // Properties
        System.String hookName { get; /* RVA: 0x087F0EE0 */ }

        // Methods
        // RVA: 0x087F0BF0  token: 0x600000C
        protected virtual System.Void Definition() { }
        // RVA: 0x087F0D04  token: 0x600000D
        public System.Void TriggerButton(Unity.VisualScripting.GraphReference reference) { }
        // RVA: 0x087F0EA4  token: 0x600000E
        public System.Void .ctor() { }
        // RVA: 0x011AC510  token: 0x600000F
        private HoudiniEngineUnity.HEU_HoudiniAsset <Definition>b__6_0(Unity.VisualScripting.Flow flow) { }

    }

    // TypeToken: 0x2000006  // size: 0x18
    public class HEU_UnitButton
    {
        // Fields
        public System.Action action;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000012
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x28
    public class HEU_UnitButtonAttribute : System.Attribute
    {
        // Fields
        public System.String functionName;  // 0x10
        public System.String buttonLabel;  // 0x18
        public System.Int32 buttonWidth;  // 0x20

        // Methods
        // RVA: 0x03864580  token: 0x6000013
        public System.Void .ctor(System.String fnName, System.String btnLabel, System.Int32 btnWidth) { }

    }

}

