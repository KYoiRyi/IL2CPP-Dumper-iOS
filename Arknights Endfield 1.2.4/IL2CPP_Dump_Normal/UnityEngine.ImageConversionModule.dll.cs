// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.ImageConversionModule.dll
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
    public static class ImageConversion
    {
        // Methods
        // RVA: 0x09DF911C  token: 0x6000001
        public static System.Byte[] EncodeToTGA(UnityEngine.Texture2D tex) { }
        // RVA: 0x09DF90E8  token: 0x6000002
        public static System.Byte[] EncodeToPNG(UnityEngine.Texture2D tex) { }
        // RVA: 0x09DF9098  token: 0x6000003
        public static System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex, System.Int32 quality) { }
        // RVA: 0x09DF90D8  token: 0x6000004
        public static System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex) { }
        // RVA: 0x09DF9058  token: 0x6000005
        public static System.Byte[] EncodeToEXR(UnityEngine.Texture2D tex, UnityEngine.Texture2D.EXRFlags flags) { }
        // RVA: 0x09DF904C  token: 0x6000006
        public static System.Byte[] EncodeToEXR(UnityEngine.Texture2D tex) { }
        // RVA: 0x09DF9160  token: 0x6000007
        public static System.Boolean LoadImage(UnityEngine.Texture2D tex, System.Byte[] data, System.Boolean markNonReadable) { }
        // RVA: 0x09DF9150  token: 0x6000008
        public static System.Boolean LoadImage(UnityEngine.Texture2D tex, System.Byte[] data) { }

    }

}

