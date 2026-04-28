// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AssetBundleModule.dll
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

namespace UnityEngine
{

    // TypeToken: 0x2000002  // size: 0x18
    public class AssetBundle : UnityEngine.Object
    {
        // Fields
        private static System.Action onMissReferencedScript;  // static @ 0x0
        public static System.Func<System.Int64,System.String> hashToStringPath;  // static @ 0x8
        public static System.Func<System.Int64,System.Boolean> checkHashValid;  // static @ 0x10
        public static System.Action<System.String> addPathSting;  // static @ 0x18

        // Properties
        System.Boolean enableLazyCloseFile { set; /* RVA: 0x03D03230 */ }
        System.UInt32 memoryBudgetKB { get; /* RVA: 0x09D97B98 */ set; /* RVA: 0x09D97BA4 */ }

        // Methods
        // RVA: 0x09D97B58  token: 0x6000001
        private System.Void .ctor() { }
        // RVA: 0x09D97AE0  token: 0x6000002
        public static System.Void UnloadAllAssetBundles(System.Boolean unloadAllObjects) { }
        // RVA: 0x09D97494  token: 0x6000003
        private static UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native() { }
        // RVA: 0x09D974C0  token: 0x6000004
        public static System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles() { }
        // RVA: 0x04271E4C  token: 0x6000005
        public static System.Void WaitForAllAsyncOperationsToComplete() { }
        // RVA: 0x03D47190  token: 0x6000006
        private static System.Void WaitForAllAsyncOperationsToComplete_Internal() { }
        // RVA: 0x09D97530  token: 0x6000007
        private static System.Void InvokeOnMissReferencedScriptOnBehaviour() { }
        // RVA: 0x09D97AA0  token: 0x6000009
        private static System.Boolean TryCloseLazyCloseFile_Internal(System.Boolean force) { }
        // RVA: 0x09D97AD4  token: 0x600000A
        public static System.Boolean TryCloseLazyCloseFile(System.Boolean force) { }
        // RVA: 0x09D974CC  token: 0x600000B
        private static System.String HashToStringPath(System.Int64 hash) { }
        // RVA: 0x09D97438  token: 0x600000C
        private static System.Boolean CheckHashValid(System.Int64 hash) { }
        // RVA: 0x09D973E8  token: 0x600000D
        private static System.Void AddPathStringToCSharp(System.String path) { }
        // RVA: 0x030394D0  token: 0x600000E
        private static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        // RVA: 0x09D97854  token: 0x600000F
        public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path) { }
        // RVA: 0x04270158  token: 0x6000010
        public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        // RVA: 0x0312BF80  token: 0x6000011
        private static UnityEngine.AssetBundle LoadFromFile_Internal(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        // RVA: 0x09D97864  token: 0x6000012
        public static UnityEngine.AssetBundle LoadFromFile(System.String path) { }
        // RVA: 0x04271EDC  token: 0x6000013
        public static UnityEngine.AssetBundle LoadFromFile(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        // RVA: 0x09D97874  token: 0x6000014
        private static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(System.Byte[] binary, System.UInt32 crc) { }
        // RVA: 0x09D978B4  token: 0x6000015
        public static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(System.Byte[] binary) { }
        // RVA: -1  // generic def  token: 0x6000016
        public T LoadAsset(System.String name) { }
        // RVA: 0x04271ED0  token: 0x6000017
        public UnityEngine.Object LoadAsset(System.Int64 hash, System.Type type) { }
        // RVA: 0x09D97738  token: 0x6000018
        public UnityEngine.Object LoadAsset(System.String name, System.Type type) { }
        // RVA: 0x09D976E4  token: 0x6000019
        private UnityEngine.Object LoadAsset_Internal(System.String name, System.Type type) { }
        // RVA: 0x028D5D20  token: 0x600001A
        private UnityEngine.Object LoadAssetByHash_Internal(System.Int64 hash, System.Type type) { }
        // RVA: -1  // generic def  token: 0x600001B
        public UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name) { }
        // RVA: 0x09D975C8  token: 0x600001C
        public UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name, System.Type type) { }
        // RVA: 0x028D7C80  token: 0x600001D
        public UnityEngine.AssetBundleRequest LoadAssetAsync(System.Int64 hash, System.Type type) { }
        // RVA: 0x09D97924  token: 0x600001E
        public UnityEngine.AssetBundleRequest LoadSubAssetAsync(System.String name, System.Int64 subAssetInstanceID, System.Type type) { }
        // RVA: 0x09D97574  token: 0x600001F
        private UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(System.String name, System.Type type) { }
        // RVA: 0x028D7CF0  token: 0x6000020
        private UnityEngine.AssetBundleRequest LoadAssetAsyncByHash_Internal(System.Int64 hash, System.Type type) { }
        // RVA: 0x030F6E10  token: 0x6000021
        public System.Void Unload(System.Boolean unloadAllLoadedObjects) { }
        // RVA: 0x09D97B14  token: 0x6000022
        public UnityEngine.AsyncOperation UnloadAsync(System.Boolean unloadAllLoadedObjects) { }
        // RVA: 0x09D978C0  token: 0x6000023
        private UnityEngine.AssetBundleRequest LoadSubAssetAsync_Internal(System.String name, System.Int64 instanceID, System.Type type) { }

    }

    // TypeToken: 0x2000003  // size: 0x20
    public class AssetBundleCreateRequest : UnityEngine.AsyncOperation
    {
        // Properties
        UnityEngine.AssetBundle assetBundle { get; /* RVA: 0x028D62B0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000027
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class AssetBundleLoadingCache
    {
        // Properties
        System.UInt32 maxBlocksPerFile { get; /* RVA: 0x09D973BC */ set; /* RVA: 0x039B9D10 */ }
        System.UInt32 blockCount { get; /* RVA: 0x039B9C90 */ set; /* RVA: 0x039B9CD0 */ }
        System.UInt32 blockSize { get; /* RVA: 0x039B9B90 */ }
        System.UInt32 memoryBudgetKB { get; /* RVA: 0x039B9B70 */ set; /* RVA: 0x039B9BD0 */ }

    }

    // TypeToken: 0x2000005  // size: 0x20
    public class AssetBundleRecompressOperation : UnityEngine.AsyncOperation
    {
    }

    // TypeToken: 0x2000006  // size: 0x30
    public class AssetBundleRequest : UnityEngine.ResourceRequest
    {
        // Properties
        UnityEngine.Object asset { get; /* RVA: 0x04271E54 */ }

        // Methods
        // RVA: 0x028D5D80  token: 0x600002F
        protected virtual UnityEngine.Object GetResult() { }
        // RVA: 0x0350B670  token: 0x6000031
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.Experimental.AssetBundlePatching
{

    // TypeToken: 0x2000007  // size: 0x10
    public static class AssetBundleUtility
    {
        // Methods
        // RVA: 0x035659F0  token: 0x6000032
        public static System.Int32 LZ4Decompress(System.Void* src, System.Int32 srcSize, System.Void* dst, System.Int32 dstSize) { }
        // RVA: 0x03565970  token: 0x6000033
        public static System.Int32 LZ4Decompress(System.Byte[] src, System.Int32 srcOffset, System.Int32 srcSize, System.Byte[] dst, System.Int32 dstOffset, System.Int32 dstSize) { }

    }

}

