// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.JSONSerializeModule.dll
// Classes:  2
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

    // TypeToken: 0x2000002  // size: 0x10
    public static class JsonUtility
    {
        // Methods
        // RVA: 0x032FF5D0  token: 0x6000001
        private static System.String ToJsonInternal(System.Object obj, System.Boolean prettyPrint) { }
        // RVA: 0x031A62D0  token: 0x6000002
        private static System.Object FromJsonInternal(System.String json, System.Object objectToOverwrite, System.Type type) { }
        // RVA: 0x0427445C  token: 0x6000003
        public static System.String ToJson(System.Object obj) { }
        // RVA: 0x032FF530  token: 0x6000004
        public static System.String ToJson(System.Object obj, System.Boolean prettyPrint) { }
        // RVA: -1  // generic def  token: 0x6000005
        public static T FromJson(System.String json) { }
        // RVA: 0x031A61F0  token: 0x6000006
        public static System.Object FromJson(System.String json, System.Type type) { }
        // RVA: 0x09E14CC0  token: 0x6000007
        public static System.Void FromJsonOverwrite(System.String json, System.Object objectToOverwrite) { }

    }

}

