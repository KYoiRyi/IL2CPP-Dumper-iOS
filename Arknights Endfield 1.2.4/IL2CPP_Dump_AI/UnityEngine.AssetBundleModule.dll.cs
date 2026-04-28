// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AssetBundleModule.dll
// Classes:  7
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

CLASS: UnityEngine.AssetBundle
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
  private   static  System.Action                   onMissReferencedScript  // static @ 0x0
  public    static  System.Func<System.Int64,System.String>hashToStringPath  // static @ 0x8
  public    static  System.Func<System.Int64,System.Boolean>checkHashValid  // static @ 0x10
  public    static  System.Action<System.String>    addPathSting  // static @ 0x18
PROPERTIES:
  enableLazyCloseFile  set=0x03D03230
  memoryBudgetKB  get=0x09D97B98  set=0x09D97BA4
METHODS:
  RVA=0x09D97B58  token=0x6000001  System.Void .ctor()
  RVA=0x09D97AE0  token=0x6000002  System.Void UnloadAllAssetBundles(System.Boolean unloadAllObjects)
  RVA=0x09D97494  token=0x6000003  UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native()
  RVA=0x09D974C0  token=0x6000004  System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles()
  RVA=0x04271E4C  token=0x6000005  System.Void WaitForAllAsyncOperationsToComplete()
  RVA=0x03D47190  token=0x6000006  System.Void WaitForAllAsyncOperationsToComplete_Internal()
  RVA=0x09D97530  token=0x6000007  System.Void InvokeOnMissReferencedScriptOnBehaviour()
  RVA=0x09D97AA0  token=0x6000009  System.Boolean TryCloseLazyCloseFile_Internal(System.Boolean force)
  RVA=0x09D97AD4  token=0x600000A  System.Boolean TryCloseLazyCloseFile(System.Boolean force)
  RVA=0x09D974CC  token=0x600000B  System.String HashToStringPath(System.Int64 hash)
  RVA=0x09D97438  token=0x600000C  System.Boolean CheckHashValid(System.Int64 hash)
  RVA=0x09D973E8  token=0x600000D  System.Void AddPathStringToCSharp(System.String path)
  RVA=0x030394D0  token=0x600000E  UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(System.String path, System.UInt32 crc, System.UInt64 offset)
  RVA=0x09D97854  token=0x600000F  UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path)
  RVA=0x04270158  token=0x6000010  UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path, System.UInt32 crc, System.UInt64 offset)
  RVA=0x0312BF80  token=0x6000011  UnityEngine.AssetBundle LoadFromFile_Internal(System.String path, System.UInt32 crc, System.UInt64 offset)
  RVA=0x09D97864  token=0x6000012  UnityEngine.AssetBundle LoadFromFile(System.String path)
  RVA=0x04271EDC  token=0x6000013  UnityEngine.AssetBundle LoadFromFile(System.String path, System.UInt32 crc, System.UInt64 offset)
  RVA=0x09D97874  token=0x6000014  UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(System.Byte[] binary, System.UInt32 crc)
  RVA=0x09D978B4  token=0x6000015  UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(System.Byte[] binary)
  RVA=-1  // generic def  token=0x6000016  T LoadAsset(System.String name)
  RVA=0x04271ED0  token=0x6000017  UnityEngine.Object LoadAsset(System.Int64 hash, System.Type type)
  RVA=0x09D97738  token=0x6000018  UnityEngine.Object LoadAsset(System.String name, System.Type type)
  RVA=0x09D976E4  token=0x6000019  UnityEngine.Object LoadAsset_Internal(System.String name, System.Type type)
  RVA=0x028D5D20  token=0x600001A  UnityEngine.Object LoadAssetByHash_Internal(System.Int64 hash, System.Type type)
  RVA=-1  // generic def  token=0x600001B  UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name)
  RVA=0x09D975C8  token=0x600001C  UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name, System.Type type)
  RVA=0x028D7C80  token=0x600001D  UnityEngine.AssetBundleRequest LoadAssetAsync(System.Int64 hash, System.Type type)
  RVA=0x09D97924  token=0x600001E  UnityEngine.AssetBundleRequest LoadSubAssetAsync(System.String name, System.Int64 subAssetInstanceID, System.Type type)
  RVA=0x09D97574  token=0x600001F  UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(System.String name, System.Type type)
  RVA=0x028D7CF0  token=0x6000020  UnityEngine.AssetBundleRequest LoadAssetAsyncByHash_Internal(System.Int64 hash, System.Type type)
  RVA=0x030F6E10  token=0x6000021  System.Void Unload(System.Boolean unloadAllLoadedObjects)
  RVA=0x09D97B14  token=0x6000022  UnityEngine.AsyncOperation UnloadAsync(System.Boolean unloadAllLoadedObjects)
  RVA=0x09D978C0  token=0x6000023  UnityEngine.AssetBundleRequest LoadSubAssetAsync_Internal(System.String name, System.Int64 instanceID, System.Type type)
END_CLASS

CLASS: UnityEngine.AssetBundleCreateRequest
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x20
EXTENDS: UnityEngine.AsyncOperation
FIELDS:
PROPERTIES:
  assetBundle  get=0x028D62B0
METHODS:
  RVA=0x0350B670  token=0x6000027  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AssetBundleLoadingCache
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
PROPERTIES:
  maxBlocksPerFile  get=0x09D973BC  set=0x039B9D10
  blockCount  get=0x039B9C90  set=0x039B9CD0
  blockSize  get=0x039B9B90
  memoryBudgetKB  get=0x039B9B70  set=0x039B9BD0
METHODS:
END_CLASS

CLASS: UnityEngine.AssetBundleRecompressOperation
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x20
EXTENDS: UnityEngine.AsyncOperation
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AssetBundleRequest
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x30
EXTENDS: UnityEngine.ResourceRequest
FIELDS:
PROPERTIES:
  asset  get=0x04271E54
METHODS:
  RVA=0x028D5D80  token=0x600002F  UnityEngine.Object GetResult()
  RVA=0x0350B670  token=0x6000031  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility
TYPE:  static class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x035659F0  token=0x6000032  System.Int32 LZ4Decompress(System.Void* src, System.Int32 srcSize, System.Void* dst, System.Int32 dstSize)
  RVA=0x03565970  token=0x6000033  System.Int32 LZ4Decompress(System.Byte[] src, System.Int32 srcOffset, System.Int32 srcSize, System.Byte[] dst, System.Int32 dstOffset, System.Int32 dstSize)
END_CLASS

