// ========================================================
// Dumped by @desirepro
// Assembly: Rendering.Beyond.dll
// Classes:  142
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

CLASS: LDstaticObjectLightmappingDataLoader
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  test  // 0x18
  public            System.Boolean                  recover  // 0x19
  public            UnityEngine.Renderer[]          ldLightmappedRenderer  // 0x20
  public            System.Int32[]                  ldLightmappedRendererLightmapIndex  // 0x28
  public            UnityEngine.Vector4[]           ldLightmappedRendererLightmapUvScale  // 0x30
METHODS:
  RVA=0x093CB218  token=0x6000001  System.Void RecoverLightmapdata()
  RVA=0x0426FE60  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: WarmUpReason
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonNoReason  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonFirstEntryGame  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonLodChange  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonAssetUpdate  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonAppUpdate  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonGraphicsAPIChange  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonShaderCacheSmall  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonShaderCacheIOInvalid  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonDevOverride  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonCrashRetry  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonRemoteCtrlRetry  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonShaderCacheApiInvalid  // const
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasonDriverVersionUpdate  // const
METHODS:
END_CLASS

CLASS: TimeCostCounter
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x20
FIELDS:
  private   static  System.Single                   MAX_DELTA_TIME  // const
  private   static  System.Single                   MAX_DELTA_TIME_FIX  // const
  private           System.Single                   <duration>k__BackingField  // 0x10
  private           System.Single                   m_lastRealTime  // 0x14
  private           System.Single                   m_maxDurationSecond  // 0x18
PROPERTIES:
  duration  get=0x03D4E7A0  set=0x03D50CA0
  isTimeOut  get=0x093CC8E8
METHODS:
  RVA=0x093CC8D4  token=0x6000051  System.Void .ctor(System.Single maxDurationMilliSecond)
  RVA=0x093CC808  token=0x6000052  System.Void Begin()
  RVA=0x093CC860  token=0x6000053  System.Void Tick()
END_CLASS

CLASS: <WarmupShadersLogin>d__55
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Boolean                  supportsRaytracing  // 0x20
  private           System.Collections.Generic.List<Beyond.Resource.FAssetProxyHandle><assetProxyHandles>5__2  // 0x28
  private           System.Collections.Generic.List<UnityEngine.HGPsoWarmupCollection><loadedAssets>5__3  // 0x30
  private           System.Int32                    <unfinishedCount>5__4  // 0x38
  private           Beyond.Rendering.ShaderWarmupManager.TimeCostCounter<timeCostCounter>5__5  // 0x40
  private           System.Int32                    <i>5__6  // 0x48
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000054  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000055  System.Void System.IDisposable.Dispose()
  RVA=0x0223C410  token=0x6000056  System.Boolean MoveNext()
  RVA=0x0223FD30  token=0x6000058  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_LoadPsoAssets>d__56
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Collections.Generic.List<Beyond.Resource.StringPathHash>resPathList  // 0x20
  public            System.Collections.Generic.List<Beyond.Resource.FAssetProxyHandle>assetProxyHandles  // 0x28
  public            System.Collections.Generic.List<UnityEngine.HGPsoWarmupCollection>loadedAssets  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600005A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600005B  System.Void System.IDisposable.Dispose()
  RVA=0x02241FF0  token=0x600005C  System.Boolean MoveNext()
  RVA=0x02244070  token=0x600005E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <WarmupShadersScene>d__57
TYPE:  sealed class
TOKEN: 0x2000013
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   scene  // 0x20
  private           System.String                   <path>5__2  // 0x28
  private           Beyond.Resource.FAssetProxyHandle<assetHandle>5__3  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000060  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000061  System.Void System.IDisposable.Dispose()
  RVA=0x0223FD80  token=0x6000062  System.Boolean MoveNext()
  RVA=0x02241FA0  token=0x6000064  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <WarmupOnePso>d__58
TYPE:  sealed class
TOKEN: 0x2000014
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.HGPsoWarmupCollectionpsoC  // 0x20
  public            System.Int32                    startIndex  // 0x28
  public            System.Int32                    warmupCount  // 0x2c
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000066  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000067  System.Void System.IDisposable.Dispose()
  RVA=0x0223B6E0  token=0x6000068  System.Boolean MoveNext()
  RVA=0x0223C3C0  token=0x600006A  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_WarmupOnePsoTimeLimited>d__59
TYPE:  sealed class
TOKEN: 0x2000015
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            UnityEngine.HGPsoWarmupCollectionpsoC  // 0x20
  public            System.Int32                    desiredWarmupCount  // 0x28
  public            Beyond.Rendering.ShaderWarmupManager.TimeCostCountertimeStart  // 0x30
  public            System.Int32                    startIndex  // 0x38
  private           System.Int32                    <warmupCountPerStepMainJobCompile>5__2  // 0x3c
  private           System.Int32                    <totalCount>5__3  // 0x40
  private           System.Int32                    <compileTotalCount>5__4  // 0x44
  private           System.Int32                    <countToCleanUp>5__5  // 0x48
  private           System.Int32                    <backJobLastLeftCount>5__6  // 0x4c
  private           System.Int32                    <leftBackJobCount>5__7  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600006C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600006D  System.Void System.IDisposable.Dispose()
  RVA=0x022440C0  token=0x600006E  System.Boolean MoveNext()
  RVA=0x02245A80  token=0x6000070  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ShaderWarmupRemoteBlackDevice
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x40
FIELDS:
  public            System.String                   deviceModel  // 0x10
  public            System.String                   graphicsDeviceName  // 0x18
  public            System.String                   graphicsDeviceVersion  // 0x20
  public            System.String                   os  // 0x28
  public            System.String                   cpuName  // 0x30
  public            System.String                   disableFeature  // 0x38
METHODS:
  RVA=0x0350B670  token=0x6000077  System.Void .ctor()
END_CLASS

CLASS: ShaderWarmupGlobalConfig
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x18
FIELDS:
  public            System.Boolean                  disableDriverVerDetect  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000078  System.Void .ctor()
END_CLASS

CLASS: ShaderWarmupRemoteBlacklist
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x20
FIELDS:
  public            System.Collections.Generic.List<Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupRemoteBlackDevice>devices  // 0x10
  public            Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupGlobalConfigconfig  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000079  System.Void .ctor()
END_CLASS

CLASS: Result
TYPE:  sealed class
TOKEN: 0x200001B
SIZE:  0x48
FIELDS:
  public            System.String                   driverVersion  // 0x10
  public            System.String                   deviceName  // 0x18
  public            System.String                   deviceDesc  // 0x20
  public            System.String                   mfg  // 0x28
  public            System.Int32                    score  // 0x30
  public            System.String                   driverKey  // 0x38
  public            System.String                   keyId  // 0x40
METHODS:
  RVA=0x022372F0  token=0x600008E  System.String ToString()
  RVA=0x0350B670  token=0x600008F  System.Void .ctor()
  RVA=0x022382B0  token=0x6000090  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: SafeRegistryHandle
TYPE:  sealed class
TOKEN: 0x200001C
SIZE:  0x20
EXTENDS: Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
FIELDS:
METHODS:
  RVA=0x02238980  token=0x6000091  System.Void .ctor()
  RVA=0x02C9C390  token=0x6000092  System.Void .ctor(System.IntPtr preexistingHandle, System.Boolean ownsHandle)
  RVA=0x022382E0  token=0x6000093  System.Boolean ReleaseHandle()
END_CLASS

CLASS: RegistryRights
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.WindowsGpuDriverVersion.RegistryRightsKEY_QUERY_VALUE  // const
METHODS:
END_CLASS

CLASS: SP_DEVINFO_DATA
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x30
FIELDS:
  public            System.UInt32                   cbSize  // 0x10
  public            System.Guid                     classGuid  // 0x14
  public            System.UInt32                   devInst  // 0x24
  public            System.IntPtr                   reserved  // 0x28
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200001F
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Rendering.WindowsGpuDriverVersion.<>c<>9  // static @ 0x0
  public    static  System.Comparison<Beyond.Rendering.WindowsGpuDriverVersion.Result><>9__18_0  // static @ 0x8
METHODS:
  RVA=0x0223B380  token=0x6000094  System.Void .cctor()
  RVA=0x0350B670  token=0x6000095  System.Void .ctor()
  RVA=0x0223B340  token=0x6000096  System.Int32 <GetAllDisplayDriverVersions>b__18_0(Beyond.Rendering.WindowsGpuDriverVersion.Result a, Beyond.Rendering.WindowsGpuDriverVersion.Result b)
END_CLASS

CLASS: ChunkData
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x30
FIELDS:
  public            UnityEngine.Vector3[]           centers  // 0x10
  public            UnityEngine.Vector3[]           extents  // 0x18
  public            UnityEngine.Vector3[]           vertexData  // 0x20
  public            System.Single[]                 areas  // 0x28
METHODS:
END_CLASS

CLASS: SubSceneDataPerSceneStateArea
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector2Int[]        chunkCoords  // 0x10
  public            Beyond.Rendering.HGSOCSubSceneData.ChunkData[]chunkDataArray  // 0x18
METHODS:
END_CLASS

CLASS: MeshRendererToSync
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x30
FIELDS:
  public            UnityEngine.Transform           captureTransform  // 0x10
  public            UnityEngine.Renderer            captureRenderer  // 0x18
  public            UnityEngine.Transform           followTransform  // 0x20
  public            UnityEngine.Renderer            followRenderer  // 0x28
METHODS:
END_CLASS

CLASS: CaptureRenderGameObject
TYPE:  class
TOKEN: 0x200002A
SIZE:  0x28
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.MeshRenderer        meshRenderer  // 0x18
  public            UnityEngine.MeshFilter          meshFilter  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60000B7  System.Void .ctor()
END_CLASS

CLASS: RendererInfo
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x50
FIELDS:
  public            UnityEngine.Renderer            renderer  // 0x10
  public            Beyond.Rendering.EntityVFXRendererMasktypeMask  // 0x18
  public            System.Int32                    subMeshCount  // 0x1c
  public            UnityEngine.Rendering.ShadowCastingModeoriShadowCastingMode  // 0x20
  public            UnityEngine.Experimental.Rendering.RayTracingModeoriRayTracingMode  // 0x24
  public            UnityEngine.Material[]          sourceMaterials  // 0x28
  public            System.Boolean                  materialReplacing  // 0x30
  public            UnityEngine.Material[]          replacingMaterials  // 0x38
  public            UnityEngine.Vector4             customPerDrawData0  // 0x40
PROPERTIES:
  currentMeshMaterials  get=0x022CDC10
METHODS:
  RVA=0x0350B670  token=0x60000D9  System.Void .ctor()
END_CLASS

CLASS: AddedMaterialInfo
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x40
FIELDS:
  public            System.Int32                    handle  // 0x10
  public            UnityEngine.Material            material  // 0x18
  public            Beyond.Rendering.EntityVFXRendererMaskmask  // 0x20
  public            Beyond.Rendering.AddMaterialConfigconfig  // 0x28
  public            System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>customizeMaterialDict  // 0x38
METHODS:
END_CLASS

CLASS: SourceMaterialCustomizeData
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x18
FIELDS:
  public            UnityEngine.Texture             colorTexture  // 0x10
METHODS:
END_CLASS

CLASS: AddedMaterialController
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x58
FIELDS:
  public    static  System.Int32                    MAX_ACTIVE_ADDED_MATERIAL  // const
  public            System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.AddedMaterialInfo>addedMaterialInfos  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,System.Single>m_addictiveFloatProperties  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4>m_addictiveVectorProperties  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Texture>m_addictiveTextureProperties  // 0x28
  private           System.Boolean                  m_useCustomizeRendererProperty  // 0x30
  private           Beyond.Rendering.EntityCustomizeRendererPropertyConfigm_customizeRendererPropertyConfig  // 0x38
  private           System.Boolean                  m_initedCustomizeRendererPropertyConfig  // 0x40
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,Beyond.Rendering.EntityRenderHelperMaterialController.SourceMaterialCustomizeData>m_sourceMaterialCustomizeDatas  // 0x48
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>m_rendererInfos  // 0x50
  private   static  System.Int32                    s_handleCount  // static @ 0x0
METHODS:
  RVA=0x03787550  token=0x60000DA  System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> rendererInfos, Beyond.Rendering.EntityCustomizeRendererPropertyConfig customizeRendererPropertyConfig)
  RVA=0x093C58AC  token=0x60000DB  System.Void _InitCustomizeRendererProperty()
  RVA=0x022CDA50  token=0x60000DC  System.Void Reset()
  RVA=0x036F5FF0  token=0x60000DD  System.Int32 RequireAddMaterial(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask mask, Beyond.Rendering.AddMaterialConfig config)
  RVA=0x036F61D0  token=0x60000DE  Beyond.Rendering.EntityVFXRendererMask RequireRemoveMaterial(System.Int32 handle)
  RVA=0x093C5718  token=0x60000DF  UnityEngine.Material _GetCustomizePropertyMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.AddedMaterialInfo addedMaterialInfo, UnityEngine.Material material)
  RVA=0x022CDAA0  token=0x60000E0  System.Void ApplySharedMaterialArray(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo)
  RVA=0x093C4EAC  token=0x60000E1  System.Boolean GetAddedMaterialsOfCustomizeProperties(System.Int32 handle, System.Collections.Generic.List<UnityEngine.Material> result)
  RVA=0x093C541C  token=0x60000E2  System.Void SetAddictiveFloatProperty(System.Int32 propertyId, System.Single value)
  RVA=0x093C51C4  token=0x60000E3  System.Single GetAddictiveFloatProperty(System.Int32 propertyId, System.Single defaultValue)
  RVA=0x093C560C  token=0x60000E4  System.Void SetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 value)
  RVA=0x093C5334  token=0x60000E5  UnityEngine.Vector4 GetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 defaultValue)
  RVA=0x093C5514  token=0x60000E6  System.Void SetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture value)
  RVA=0x093C527C  token=0x60000E7  UnityEngine.Texture GetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture defaultValue)
  RVA=0x0350B670  token=0x60000E8  System.Void .ctor()
END_CLASS

CLASS: CustomPerDrawDataController
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>m_rendererInfos  // 0x10
  private           System.Single                   m_characterEnvironmentEffectPackedValue  // 0x18
METHODS:
  RVA=0x03318FF0  token=0x60000E9  System.Single _PackUNorm8ToFloat(System.Single packed, System.Single value, System.Int32 bitShift)
  RVA=0x02CE2160  token=0x60000EA  System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> allRendererInfos)
  RVA=0x022CD650  token=0x60000EB  System.Void Reset()
  RVA=0x02717690  token=0x60000EC  System.Void SetFloatToCustomPerDraw(Beyond.Rendering.EntityRenderHelperCustomPerDrawType type, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093C92D4  token=0x60000ED  System.Void SetVectorToCustomPerDraw(Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType type, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x0350B670  token=0x60000EE  System.Void .ctor()
END_CLASS

CLASS: MeshMaterialGroupData
TYPE:  class
TOKEN: 0x2000032
SIZE:  0x50
FIELDS:
  public            Beyond.Rendering.EntityVFXRendererMaskmask  // 0x10
  public            System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>rendererInfos  // 0x18
  public            System.Collections.Generic.Dictionary<System.Int32,System.Single>floatProperties  // 0x20
  public            System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4>vectorProperties  // 0x28
  public            System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Texture>textureProperties  // 0x30
  public            System.Collections.Generic.Dictionary<System.String,System.Boolean>keywordStates  // 0x38
  public            System.Boolean                  depthOnlyPassControlling  // 0x40
  public            System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>src2dstMaterialDict  // 0x48
METHODS:
  RVA=0x0341D870  token=0x60000EF  System.Void CopyFrom(Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData src)
  RVA=0x022D0F10  token=0x60000F0  System.Void Clear()
  RVA=0x0350B670  token=0x60000F1  System.Void .ctor()
END_CLASS

CLASS: MeshMaterialController
TYPE:  class
TOKEN: 0x2000033
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData>m_meshMaterialDatas  // 0x10
  private   static  System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData>s_cacheMeshMaterialDatas  // static @ 0x0
  private   static readonly System.String                   VFX_MATERIAL_POSTFIX  // static @ 0x8
METHODS:
  RVA=0x022D0DC0  token=0x60000F2  System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> allRendererInfos)
  RVA=0x022CFC10  token=0x60000F3  System.Void Reset()
  RVA=0x093D3CA8  token=0x60000F4  System.Void SetKeywordEnableToAllMaterial(System.String keyword, System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093D3310  token=0x60000F5  System.Void SetDepthOnlyPassEnableToAllMaterial(System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x022D2170  token=0x60000F6  System.Void SetFloatToAllMaterial(System.Int32 nameId, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093D2D70  token=0x60000F7  System.Void ReleaseFloatToAllMaterial(System.Int32 nameId, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x022CF360  token=0x60000F8  System.Void SetVectorToAllMaterial(System.Int32 nameId, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093D3130  token=0x60000F9  System.Void ReleaseVectorToAllMaterial(System.Int32 nameId, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093D43F0  token=0x60000FA  System.Void SetTextureToAllMaterial(System.Int32 nameId, UnityEngine.Texture value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093D2F50  token=0x60000FB  System.Void ReleaseTextureToAllMaterial(System.Int32 nameId, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x02E7ED80  token=0x60000FC  System.Void _CreateReplaceMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo, Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData groupData)
  RVA=0x093D4C6C  token=0x60000FD  System.Void _CopyReplaceMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo, Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData groupData)
  RVA=0x022D16C0  token=0x60000FE  System.Void _ReleaseAllReplaceMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData groupData)
  RVA=0x02E804F0  token=0x60000FF  System.Void _ReplaceSharedMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo, UnityEngine.Material[] newMaterials)
  RVA=0x022D0CB0  token=0x6000100  System.Void _GetAffectGroupData(Beyond.Rendering.EntityVFXRendererMask rendererMask, System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData> result)
  RVA=0x0341D6C0  token=0x6000101  System.Void _SplitRenderers(System.Int32 oldStateIndex, Beyond.Rendering.EntityVFXRendererMask newMask)
  RVA=0x093D4850  token=0x6000102  System.Void SetZTestInMaterial(System.String shaderName, System.Boolean enable)
  RVA=0x0350B670  token=0x6000103  System.Void .ctor()
  RVA=0x03C9B320  token=0x6000104  System.Void .cctor()
END_CLASS

CLASS: RendererInfo
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x28
FIELDS:
  public            UnityEngine.Renderer            renderer  // 0x10
  private           System.String                   m_rendererName  // 0x18
  public            System.Boolean                  oriVisible  // 0x20
  public            System.Boolean                  curVisible  // 0x21
PROPERTIES:
  rendererName  get=0x02FB2A40
METHODS:
  RVA=0x0350B670  token=0x6000110  System.Void .ctor()
END_CLASS

CLASS: TimeMode
TYPE:  sealed struct
TOKEN: 0x2000040
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXAfterImageData.TimeModeInterval  // const
  public    static  Beyond.Rendering.EntityVFXAfterImageData.TimeModeBurst  // const
METHODS:
END_CLASS

CLASS: State
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXControllerStateBase.StateEnd  // const
  public    static  Beyond.Rendering.EntityVFXControllerStateBase.StateStart  // const
  public    static  Beyond.Rendering.EntityVFXControllerStateBase.StateLoop  // const
  public    static  Beyond.Rendering.EntityVFXControllerStateBase.StateEnding  // const
METHODS:
END_CLASS

CLASS: UVSet
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXDissolveData.UVSetUV  // const
  public    static  Beyond.Rendering.EntityVFXDissolveData.UVSetUV2  // const
METHODS:
END_CLASS

CLASS: VATData
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x28
FIELDS:
  public            UnityEngine.Texture             factoryVATMap  // 0x10
  public            UnityEngine.Vector4             factoryVATMapParams  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000175  System.Void .ctor()
END_CLASS

CLASS: AddedMaterialData
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x30
FIELDS:
  public            UnityEngine.Material            srcMaterial  // 0x10
  public            UnityEngine.Material[]          materialInstancesOfEachVAT  // 0x18
  public            System.Collections.Generic.Dictionary<System.Int32,System.Single>savedFloatProperties  // 0x20
  public            System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4>savedVectorProperties  // 0x28
METHODS:
  RVA=0x093CCC78  token=0x6000176  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x200005A
SIZE:  0x18
FIELDS:
  public            UnityEngine.Material            src  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000177  System.Void .ctor()
  RVA=0x093D7BA0  token=0x6000178  System.Boolean <_GetAddedMaterialIndex>b__0(Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData data)
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x200005B
SIZE:  0x18
FIELDS:
  public            UnityEngine.Material            src  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000179  System.Void .ctor()
  RVA=0x093D7C04  token=0x600017A  System.Boolean <_RemoveVATMaterial>b__0(Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData data)
END_CLASS

CLASS: VATMaterialData
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x20
FIELDS:
  public            System.Int32                    refCount  // 0x10
  public            UnityEngine.Material            vatMaterial  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600017E  System.Void .ctor()
END_CLASS

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x200005F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXSetParamsData.TypeCharacter  // const
  public    static  Beyond.Rendering.EntityVFXSetParamsData.TypeVFX  // const
  public    static  Beyond.Rendering.EntityVFXSetParamsData.TypeLit  // const
METHODS:
END_CLASS

CLASS: PsoInfoWrapperItem
TYPE:  class
TOKEN: 0x200006D
SIZE:  0x30
FIELDS:
  public            System.String                   infoJson  // 0x10
  public            System.Single                   time  // 0x18
  public            System.Int32                    codeSize  // 0x1c
  public            System.Boolean                  isMissing  // 0x20
  public            System.String                   levelId  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60001ED  System.Void .ctor()
END_CLASS

CLASS: PsoInfoWrapper
TYPE:  class
TOKEN: 0x200006E
SIZE:  0x58
FIELDS:
  public            UnityEngine.RuntimePlatform     platform  // 0x10
  public            System.String                   lastCL  // 0x18
  public            System.String                   lastEngineCl  // 0x20
  public            System.String                   deviceModel  // 0x28
  public            System.String                   devVersion  // 0x30
  public            System.String                   branch  // 0x38
  public            UnityEngine.Rendering.GraphicsDeviceTypegraphicsDeviceType  // 0x40
  public            System.Int32                    shaderLod  // 0x44
  public            System.Int32                    infoVersion  // 0x48
  public            System.Boolean                  isDebug  // 0x4c
  public            System.Collections.Generic.List<Beyond.Rendering.PsoCreateUploadHelper.PsoInfoWrapperItem>psoInfoWrapperItems  // 0x50
METHODS:
  RVA=0x093D5948  token=0x60001EE  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass35_0
TYPE:  sealed class
TOKEN: 0x200006F
SIZE:  0x28
FIELDS:
  public            System.String                   path  // 0x10
  public            System.String                   serverFileName  // 0x18
  public            Beyond.Rendering.PsoCreateUploadHelper.PsoInfoWrapperpsoInfoWrapper  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60001EF  System.Void .ctor()
  RVA=0x093D7C68  token=0x60001F0  System.Void <_CreateAndUploadFinalJson>b__0(System.Object param)
END_CLASS

CLASS: <>c__DisplayClass41_0
TYPE:  sealed class
TOKEN: 0x2000070
SIZE:  0x30
FIELDS:
  public            System.String                   urlPath  // 0x10
  public            System.String                   rawFilePath  // 0x18
  public            System.String                   serverFileNameOverride  // 0x20
  public            System.Action<System.Boolean,System.String,System.String>callback  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60001F1  System.Void .ctor()
  RVA=0x093D7D9C  token=0x60001F2  System.Void <_UploadFile>b__0(System.Object param)
END_CLASS

CLASS: <>c__DisplayClass42_0
TYPE:  sealed class
TOKEN: 0x2000071
SIZE:  0x28
FIELDS:
  public            System.Action<System.Boolean,System.String,System.String>callback  // 0x10
  public            System.String                   fileServerUrl  // 0x18
  public            System.String                   errorMessage  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60001F3  System.Void .ctor()
  RVA=0x093D7F80  token=0x60001F4  System.Void <_UploadFileToServer>b__1(System.Object _)
  RVA=0x093D7F80  token=0x60001F5  System.Void <_UploadFileToServer>b__2(System.Object _)
END_CLASS

CLASS: <>c__DisplayClass42_1
TYPE:  sealed class
TOKEN: 0x2000072
SIZE:  0x20
FIELDS:
  public            System.String                   result  // 0x10
  public            Beyond.Rendering.PsoCreateUploadHelper.<>c__DisplayClass42_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60001F6  System.Void .ctor()
  RVA=0x093D7FB4  token=0x60001F7  System.Void <_UploadFileToServer>b__0(System.Object _)
END_CLASS

CLASS: <_UploadFileToServer>d__42
TYPE:  sealed struct
TOKEN: 0x2000073
SIZE:  0xA0
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncVoidMethodBuilder<>t__builder  // 0x18
  public            System.Action<System.Boolean,System.String,System.String>callback  // 0x38
  public            System.String                   urlPath  // 0x40
  public            System.String                   serverFileNameOverride  // 0x48
  public            System.String                   rawFilePath  // 0x50
  private           Beyond.Rendering.PsoCreateUploadHelper.<>c__DisplayClass42_1<>8__1  // 0x58
  private           Beyond.Rendering.PsoCreateUploadHelper.<>c__DisplayClass42_0<>8__2  // 0x60
  private           System.String                   <filePathServerUrl>5__2  // 0x68
  private           System.IO.Stream                <fileStream>5__3  // 0x70
  private           System.Net.Http.HttpClient      <httpClient>5__4  // 0x78
  private           System.Net.Http.MultipartFormDataContent<content>5__5  // 0x80
  private           System.Net.Http.HttpResponseMessage<response>5__6  // 0x88
  private           System.Runtime.CompilerServices.TaskAwaiter<System.Net.Http.HttpResponseMessage><>u__1  // 0x90
  private           System.Runtime.CompilerServices.TaskAwaiter<System.String><>u__2  // 0x98
METHODS:
  RVA=0x093D7FF4  token=0x60001F8  System.Void MoveNext()
  RVA=0x042760AC  token=0x60001F9  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <>c__DisplayClass41_0
TYPE:  sealed class
TOKEN: 0x2000075
SIZE:  0x38
FIELDS:
  public            System.Single[,]                sdf  // 0x10
  public            System.Collections.Generic.HashSet<System.Int32>hashList  // 0x18
  public            System.Int32                    xCount  // 0x20
  public            System.Collections.Generic.Queue<UnityEngine.Vector2Int>pendingList  // 0x28
  public            System.Action<System.Int32,System.Int32><>9__0  // 0x30
METHODS:
  RVA=0x0350B670  token=0x600020F  System.Void .ctor()
  RVA=0x093D7CD0  token=0x6000210  System.Void <_CalculateEdgeSignedDistance>b__0(System.Int32 tx, System.Int32 tz)
END_CLASS

CLASS: <>c__DisplayClass41_1
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x28
FIELDS:
  public            System.Int32                    ix  // 0x10
  public            System.Int32                    iz  // 0x14
  public            System.Single                   minDistance  // 0x18
  public            Beyond.Rendering.VFXSludgeBaker.<>c__DisplayClass41_0CS$<>8__locals1  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000211  System.Void .ctor()
  RVA=0x093D7E18  token=0x6000212  System.Void <_CalculateEdgeSignedDistance>b__1(System.Int32 tx, System.Int32 tz)
END_CLASS

CLASS: BoundsUtil
TYPE:  static class
TOKEN: 0x2000078
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x093CCD38  token=0x6000214  System.Void GetTopBottomPoints(UnityEngine.Bounds bounds, UnityEngine.Transform t, UnityEngine.Vector3& topPoint, UnityEngine.Vector3& bottomPoint, System.Nullable<UnityEngine.Vector3> upDir)
END_CLASS

CLASS: Frame
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x2C
FIELDS:
  public            UnityEngine.Vector3             origin  // 0x10
  public            UnityEngine.Quaternion          rot  // 0x1c
METHODS:
  RVA=0x03D5C820  token=0x6000220  System.Void .ctor(UnityEngine.Vector3 origin, UnityEngine.Quaternion rot)
  RVA=0x093DD518  token=0x6000221  UnityEngine.Vector3 WorldToFrame(UnityEngine.Vector3 pWorld)
  RVA=0x093DD424  token=0x6000222  UnityEngine.Vector3 FrameToWorld(UnityEngine.Vector3 pFrame)
END_CLASS

CLASS: EdgeMode
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeModeUseSplineOrder  // const
  public    static  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeModeConvexHull  // const
METHODS:
END_CLASS

CLASS: ProcessResult
TYPE:  class
TOKEN: 0x200007C
SIZE:  0x40
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector3>samples3D  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Vector2>projected2D  // 0x18
  public            System.Collections.Generic.List<System.Int32>edgeIndices  // 0x20
  public            System.Collections.Generic.List<System.Int32>simplifiedIndices  // 0x28
  public            System.Single                   worldMinY  // 0x30
  public            System.Single                   worldMaxY  // 0x34
  public            System.Single                   frameMinY  // 0x38
  public            System.Single                   frameMaxY  // 0x3c
METHODS:
  RVA=0x0350B670  token=0x6000223  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass6_0
TYPE:  sealed class
TOKEN: 0x200007D
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector2>pts  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000224  System.Void .ctor()
  RVA=0x093E0A44  token=0x6000225  System.Int32 <ConvexHullIndices>b__0(System.Int32 i, System.Int32 j)
END_CLASS

CLASS: Spline2DProjectAndSimplify
TYPE:  static class
TOKEN: 0x2000079
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x093D6130  token=0x6000215  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame MakeFrameFromPlaneNormal(UnityEngine.Vector3 planeOrigin, UnityEngine.Vector3 planeNormal)
  RVA=0x093D606C  token=0x6000216  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame MakeFrameByYaw(UnityEngine.Vector3 origin, System.Single yawDeg)
  RVA=0x093D6AD8  token=0x6000217  System.Collections.Generic.List<UnityEngine.Vector3> SampleUniformByArcLength(UnityEngine.Splines.SplineContainer container, System.Single stepMeters, System.Int32 splineIndex, System.Boolean closed, System.Single oversample)
  RVA=0x093D67F4  token=0x6000218  System.Void ProjectWorldToFrameXZ(System.Collections.Generic.List<UnityEngine.Vector3> worldPts, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame frame, System.Collections.Generic.List<UnityEngine.Vector2>& projected2D, System.Collections.Generic.List<System.Single>& frameYs, System.Single& worldMinY, System.Single& worldMaxY, System.Single& frameMinY, System.Single& frameMaxY)
  RVA=0x093D5A38  token=0x6000219  System.Collections.Generic.List<System.Int32> ConvexHullIndices(System.Collections.Generic.List<UnityEngine.Vector2> pts)
  RVA=0x093D750C  token=0x600021A  System.Single _AngleDegAt(System.Collections.Generic.List<UnityEngine.Vector2> p, System.Int32 i, System.Boolean closed)
  RVA=0x093D7768  token=0x600021B  System.Single _CurvatureAt(System.Collections.Generic.List<UnityEngine.Vector2> p, System.Int32 i, System.Boolean closed)
  RVA=0x093D7A70  token=0x600021C  System.Single _PointToSegmentDistance2D(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p)
  RVA=0x093D7068  token=0x600021D  System.Collections.Generic.List<System.Int32> Simplify2D_ByCurvatureAngleDeviation(System.Collections.Generic.List<UnityEngine.Vector2> poly, System.Boolean closed, System.Single angleDegThresh, System.Single deltaKappaThresh, System.Single devEps)
  RVA=0x093D6258  token=0x600021E  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult Process(UnityEngine.Splines.SplineContainer container, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame frame, System.Single stepMeters, System.Int32 splineIndex, System.Boolean splineClosed, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode edgeMode, System.Single angleDegThresh, System.Single deltaKappaThresh, System.Single devEpsFactor)
  RVA=0x093D74B4  token=0x600021F  System.Single <ConvexHullIndices>g__Cross|6_1(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c)
END_CLASS

CLASS: <>c__DisplayClass0_0
TYPE:  sealed struct
TOKEN: 0x200007F
SIZE:  0x30
FIELDS:
  public            System.Int32                    lutResolution  // 0x10
  public            UnityEngine.Splines.SplineContainercontainer  // 0x18
  public            System.Int32                    splineIndex  // 0x20
  public            System.Boolean                  worldSpace  // 0x24
  public            System.Boolean                  closed  // 0x25
  public            System.Single                   totalLen  // 0x28
METHODS:
END_CLASS

CLASS: SplineSamplingUtils
TYPE:  static class
TOKEN: 0x200007E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x093E00D8  token=0x6000226  System.Collections.Generic.List<UnityEngine.Vector2> SampleByArcLength(UnityEngine.Splines.SplineContainer container, System.Single step, System.Int32 splineIndex, System.Int32 lutResolution, System.Boolean closed, System.Boolean worldSpace)
  RVA=0x093E08FC  token=0x6000227  UnityEngine.Vector3 <SampleByArcLength>g__P|0_0(System.Int32 i, Beyond.Rendering.VFXSludgeNavUtils.SplineSamplingUtils.<>c__DisplayClass0_0& )
  RVA=0x093E0A14  token=0x6000228  System.Single <SampleByArcLength>g__WrapLen|0_1(System.Single s, Beyond.Rendering.VFXSludgeNavUtils.SplineSamplingUtils.<>c__DisplayClass0_0& )
END_CLASS

CLASS: PolySimplify
TYPE:  static class
TOKEN: 0x2000080
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x093DFA84  token=0x6000229  System.Collections.Generic.List<UnityEngine.Vector3> SimplifyByAngle(System.Collections.Generic.List<UnityEngine.Vector3> pts, System.Single maxTurnDeg, System.Single minEdgeLen, System.Boolean closed)
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  sealed struct
TOKEN: 0x200008A
SIZE:  0x24
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000089
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=207848C87B1819709EC2A0D678BCD530B3C49CA3BB2F61B8FCEF827B64DE251E15  // static @ 0x0
METHODS:
END_CLASS

CLASS: Beyond.Rendering.CustomPerDrawDataChannelUtils
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    HOUDINI_VAT_INDEX  // const
  public    static  System.Int32                    HOUDINI_VAT_CHANNEL  // const
  public    static  System.Int32                    LIT_EMISSIVE_INDEX  // const
  public    static  System.Int32                    LIT_EMISSIVE_ANIMATION_SWEEP_INDEX  // const
  public    static  System.Int32                    LIT_EMISSIVE_ALBEDO_INDEX  // const
  public    static  System.Int32                    UV_ANIMATION_INDEX  // const
  public    static  System.Int32                    MOVING_BAMBOO_CUR_PARAM_INDEX  // const
  public    static  System.Int32                    MOVING_BAMBOO_LAST_PARAM_INDEX  // const
  public    static  System.Int32                    LIT_DISSOLVE_INDEX  // const
  public    static  System.Int32                    LIT_DISSOLVE_CHANNEL  // const
  public    static  System.Int32                    CHARACTER_PARAMS_INDEX  // const
  public    static  System.Int32                    CHARACTER_ENVIRONMENT_EFFECT_INTENSITY_CHANNEL  // const
  public    static  System.Int32                    CHARACTER_WET_EFFECT_WORLD_SPACE_HEIGHT_CHANNEL  // const
  public    static  System.Int32                    CHARACTER_DISSOLVE_SCHEDULE_OFFSET_CHANNEL  // const
  public    static  System.Int32                    CHARACTER_RAIN_EFFECT_INTENSITY_CHANNEL_BIT  // const
  public    static  System.Int32                    CHARACTER_WET_EFFECT_INTENSITY_CHANNEL_BIT  // const
  public    static  System.Int32                    CHARACTER_WET_EFFECT_GLOBAL_INTENSITY_CHANNEL_BIT  // const
  public    static  System.Int32                    CHARACTER_SNOW_EFFECT_INTENSITY_CHANNEL_BIT  // const
  public    static  System.Int32                    CHARACTER_PARAMS_CHANNEL_BIT_BIAS  // const
  public    static  System.Int32                    CHANNELS_PER_PARAM  // const
  public    static  System.Int32                    VFX_ALPHA_INDEX  // const
  public    static  System.Int32                    VFX_ALPHA_DEFAULT_CHANNEL  // const
METHODS:
  RVA=0x093C9028  token=0x600001B  System.Void SetPerDrawData_LitDissolve(UnityEngine.Renderer affectRenderer, System.Single dissolve)
  RVA=0x093C8F8C  token=0x600001C  System.Void SetPerDrawData_HoudiniVAT(UnityEngine.Renderer affectRenderer, System.Int32 displayFrame)
  RVA=0x093C90C0  token=0x600001D  System.Void SetPerDrawData_MovingBamboo(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 curParam, UnityEngine.Vector4 lastParam)
  RVA=0x025AD010  token=0x600001E  System.Void SetPerDrawData_EmissiveColor(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 emissive)
  RVA=0x025AD080  token=0x600001F  System.Void SetPerDrawData_EmissiveAlbedoColor(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 emissiveAlbedo)
  RVA=0x034066A0  token=0x6000020  System.Void SetPerDrawData_SweepLightIntensity(UnityEngine.Renderer affectRenderer, System.Single intensity)
  RVA=0x093C9180  token=0x6000021  System.Void SetPerDrawData_UVAnimation(UnityEngine.Renderer affectRenderer, System.Single animationEnable, System.Single customAddTime)
  RVA=0x02718380  token=0x6000022  System.Void SetPerDrawData_CharacterParams(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 param0)
  RVA=0x093C9230  token=0x6000023  System.Void SetPerDrawData_VFXAlpha0(UnityEngine.Renderer affectRenderer, System.Single alpha)
  RVA=0x0350B670  token=0x6000024  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.PipelineSettingHelper
TYPE:  static class
TOKEN: 0x200000C
SIZE:  0x10
FIELDS:
  public    static  System.String                   SETTING_FOLDER  // const
  public    static  System.String                   SETTING_FILE_LIST  // const
METHODS:
  RVA=0x02F44060  token=0x6000025  System.Void LoadPipelineSettings()
  RVA=0x02F44A20  token=0x6000026  System.String _LoadSetting(System.String settingName)
  RVA=0x02F44970  token=0x6000027  System.String _GetFullSettingPath(System.String settingName)
END_CLASS

CLASS: Beyond.Rendering.ResourceRouter
TYPE:  static class
TOKEN: 0x200000D
SIZE:  0x10
FIELDS:
  private   static  System.String                   DYNAMIC_ENVIRONMENTS_FOLDER  // const
METHODS:
  RVA=0x093CB554  token=0x6000028  System.String _GetCategoryFolder(Beyond.Resource.RootCategory category)
  RVA=0x093CB4B0  token=0x6000029  System.String GetEnvironmentsFullPath(Beyond.Resource.RootCategory category, System.Boolean isDevOnly)
  RVA=0x093CB450  token=0x600002A  System.String GetDecalResourcesPath()
  RVA=0x093CB3AC  token=0x600002B  System.String GetDecalResourcesFullPath(Beyond.Resource.RootCategory category, System.Boolean isDevOnly)
END_CLASS

CLASS: Beyond.Rendering.ShaderWarmupManager
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   RUNTIME_PSO_COLLECTION_FOLDER  // static @ 0x0
  private   static  System.String                   WARM_UP_KEY_WORD  // const
  private   static  System.String                   WARM_UP_API_KEY_WORD  // const
  private   static  System.String                   WARM_UP_DRIVER_KEY_WORD  // const
  private   static  System.String                   WARM_UP_REASON_KEY_WORD  // const
  private   static  System.String                   WARMUP_RETRY_COUNT  // const
  private   static  System.String                   WARMUP_UNFINISHED_COUNT  // const
  private   static  System.String                   FEATURE_RAYTRACING  // const
  private   static  System.String                   FEATURE_ONE_PASS  // const
  private   static  System.Int32                    SHADER_COMPILE_WEIGHT  // const
  public    static readonly System.Int32                    UNFINISHED_RETRY_COUNT_LIMIT  // static @ 0x8
  public    static readonly System.Int32                    CACHE_FAILED_RETRY_COUNT_LIMIT  // static @ 0xc
  public    static  System.Boolean                  s_shouldUseOverride  // static @ 0x10
  public    static  System.Boolean                  s_needWarmupOverride  // static @ 0x11
  public    static  System.Int32                    s_forceLoginWarmupStartIndex  // static @ 0x14
  public    static  System.Int32                    s_forceLoginWarmupCount  // static @ 0x18
  public    static  System.Int32                    s_forceSceneWarmupStartIndex  // static @ 0x1c
  public    static  System.Int32                    s_forceSceneWarmupCount  // static @ 0x20
  private   static  System.String                   s_disabledFeature  // static @ 0x28
  private   static  System.Boolean                  s_warmupByCacheLoadChecked  // static @ 0x30
  private   static  System.Boolean                  s_isDeviceInBlackList  // static @ 0x31
  private   static  System.Boolean                  s_isDx11DriverCheck  // static @ 0x32
  public    static  System.Int32                    s_warmupTotalCount  // static @ 0x34
  public    static  System.Int32                    s_warmupTotalCountWeighted  // static @ 0x38
  public    static  System.Int32                    s_warmupRemainCountWeighted  // static @ 0x3c
  private   static  System.Int32                    s_warmupFinishedCount  // static @ 0x40
  private   static  System.Int32                    s_cacheFileSizeBefore  // static @ 0x44
  private   static  System.Int32                    s_compileTotalCount  // static @ 0x48
  public    static  System.Single                   s_loginWarmUpTime  // static @ 0x4c
  public    static  Beyond.Rendering.ShaderWarmupManager.WarmUpReasons_loginWarmUpReason  // static @ 0x50
  public    static  System.Int64                    s_cacheSizeRecompileThreshold  // static @ 0x58
  public    static  System.Int32                    s_warmupCountPerWorkerMainJobCompile  // static @ 0x60
  public    static  System.Int32                    s_warmupCountPerStepBackJobCompile  // static @ 0x64
  public    static  System.Int32                    s_warmupCountPerStepMainJob  // static @ 0x68
  public    static  System.Int32                    s_warmupCountPerStepBackJob  // static @ 0x6c
  public    static  System.Int32                    s_warmupCountPerStepBackDispatchLimit  // static @ 0x70
  public    static  System.Int32                    s_warmupCountToClean  // static @ 0x74
  public    static  System.Int32                    s_warmupTimeLimitMobile  // static @ 0x78
  public    static  System.Int32                    s_warmupTimeLimitPC  // static @ 0x7c
  public    static  System.String                   s_vulkanCacheFileName  // static @ 0x80
  public    static  System.String                   s_iosCacheFileName  // static @ 0x88
PROPERTIES:
  isWarming  get=0x0323F060
METHODS:
  RVA=0x093CBC90  token=0x600002D  System.String GetPsoName(UnityEngine.RuntimePlatform platform, UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType, System.Int32 shaderLod, System.String levelId)
  RVA=0x093CBBA4  token=0x600002E  System.String GetPsoName(UnityEngine.RuntimePlatform platform, UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType, System.Int32 shaderLod, System.String levelId, System.String feature)
  RVA=0x093CBD68  token=0x600002F  System.String GetPsoPath(System.String psoName)
  RVA=0x03CAC710  token=0x6000030  System.String GetLoginWarmupDetail()
  RVA=0x093CC0F4  token=0x6000031  System.Int64 _GetCacheFileSize()
  RVA=0x03746280  token=0x6000032  System.Void ProcessRemoteConfig(System.String remoteConfigStr)
  RVA=0x093CBE38  token=0x6000033  System.Void MarkNeedShaderWarmUp(Beyond.Rendering.ShaderWarmupManager.WarmUpReason reason)
  RVA=0x093CBEC8  token=0x6000034  System.Void MarkWarmUpLoginFinish()
  RVA=0x093CBB48  token=0x6000035  System.Void CleanLoadedPso()
  RVA=0x093CC3FC  token=0x6000036  System.Void _MarkWarmUpLoginFinish()
  RVA=0x03745F70  token=0x6000037  System.Boolean CheckNeedWarmUpLogin()
  RVA=0x093CBFF0  token=0x6000038  System.Collections.IEnumerator WarmupShadersLogin(System.Boolean supportsRaytracing)
  RVA=0x093CC338  token=0x6000039  System.Collections.IEnumerator _LoadPsoAssets(System.Collections.Generic.List<Beyond.Resource.StringPathHash> resPathList, System.Collections.Generic.List<Beyond.Resource.FAssetProxyHandle> assetProxyHandles, System.Collections.Generic.List<UnityEngine.HGPsoWarmupCollection> loadedAssets)
  RVA=0x093CC068  token=0x600003A  System.Collections.IEnumerator WarmupShadersScene(System.String scene)
  RVA=0x093CBF40  token=0x600003B  System.Collections.IEnumerator WarmupOnePso(UnityEngine.HGPsoWarmupCollection psoC, System.Int32 startIndex, System.Int32 warmupCount)
  RVA=0x093CC738  token=0x600003C  System.Collections.IEnumerator _WarmupOnePsoTimeLimited(UnityEngine.HGPsoWarmupCollection psoC, System.Int32 startIndex, System.Int32 desiredWarmupCount, Beyond.Rendering.ShaderWarmupManager.TimeCostCounter timeStart)
  RVA=0x093CC654  token=0x600003D  System.Void _StepProgress(System.Int32 newFinishedCount, System.Int32& compileTotalCount)
  RVA=0x02D78130  token=0x600003E  System.Boolean _CheckNeedWarmUpByFirstEntry()
  RVA=0x03746E20  token=0x600003F  System.Boolean _CheckNeedWarmUpByDeviceState()
  RVA=0x02D77F50  token=0x6000040  System.Boolean _IsNeedWarmupByGraphicsChange()
  RVA=0x03748DC0  token=0x6000041  System.Boolean _IsNeedWarmupByCacheOutdated()
  RVA=0x093CC564  token=0x6000042  System.Void _SetWarmupRetryCount(System.Int32 count)
  RVA=0x093CC5DC  token=0x6000043  System.Void _SetWarmupUnfinishedCount(System.Int32 count)
  RVA=0x093CC4A4  token=0x6000044  System.Void _MarkWarmupFinishAPI()
  RVA=0x022397F0  token=0x6000045  System.Boolean _IsNeedWarmupDx11Driver()
  RVA=0x0223A660  token=0x6000046  System.Void _MarkWarmupDx11Driver()
  RVA=0x03746140  token=0x6000047  System.Void _ResetWarmUpStats()
  RVA=0x037460D0  token=0x6000048  System.Boolean _IsDeviceSupportWarmUp()
  RVA=0x093CC2B0  token=0x6000049  System.Boolean _IsFeatureEnabled(System.String featureKeyword)
  RVA=0x037461C0  token=0x600004A  System.Boolean _CheckWarmUpUnfinishedOften()
  RVA=0x093CC23C  token=0x600004B  System.Int32 _GetLoginTimeLimit()
  RVA=0x0350B670  token=0x600004C  System.Void .ctor()
  RVA=0x0398F770  token=0x600004D  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.ShaderWarmupManagerRemoteCfg
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x18
FIELDS:
  private           Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupRemoteBlacklistm_blacklist  // 0x10
PROPERTIES:
  cpuNameForWarmUp  get=0x04273158
METHODS:
  RVA=0x03746BA0  token=0x6000072  System.Void .ctor(System.String blackListStr)
  RVA=0x02238C80  token=0x6000073  System.Boolean IsEnableDx11DriverVersionDetect()
  RVA=0x03746C10  token=0x6000074  System.Boolean IsDeviceInBlackList(System.String& disabledFeature)
  RVA=0x093CB8B4  token=0x6000076  System.Boolean _CheckDeviceMatch(Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupRemoteBlackDevice blacklistDevice, System.String currentDeviceModel, System.String currentGraphicsDeviceName, System.String currentGraphicsDeviceVersion, System.String currentProcessorType, System.String currentOS)
END_CLASS

CLASS: Beyond.Rendering.WindowsGpuDriverVersion
TYPE:  static class
TOKEN: 0x200001A
SIZE:  0x10
FIELDS:
  private   static readonly System.Guid                     GUID_DEVCLASS_DISPLAY  // static @ 0x0
  private   static  System.UInt32                   DIGCF_PRESENT  // const
  private   static  System.UInt32                   SPDRP_DEVICEDESC  // const
  private   static  System.UInt32                   SPDRP_MFG  // const
  private   static  System.UInt32                   SPDRP_FRIENDLYNAME  // const
  private   static  System.UInt32                   SPDRP_DRIVER  // const
  private   static  System.UInt32                   DICS_FLAG_GLOBAL  // const
  private   static  System.UInt32                   DIREG_DRV  // const
  private   static readonly System.IntPtr                   INVALID_HANDLE_VALUE  // static @ 0x10
  private   static  System.Int32                    ERROR_SUCCESS  // const
  private   static  System.Int32                    ERROR_NO_MORE_ITEMS  // const
  private   static  System.Int32                    ERROR_INSUFFICIENT_BUFFER  // const
  private   static  System.Int32                    ERROR_MORE_DATA  // const
  private   static  System.UInt32                   REG_SZ  // const
  private   static  System.UInt32                   REG_EXPAND_SZ  // const
METHODS:
  RVA=0x02248F90  token=0x600007A  System.String GetCurrentDriverVersion()
  RVA=0x02247A90  token=0x600007B  Beyond.Rendering.WindowsGpuDriverVersion.Result GetBestMatch()
  RVA=0x02245AD0  token=0x600007C  System.Collections.Generic.List<Beyond.Rendering.WindowsGpuDriverVersion.Result> GetAllDisplayDriverVersions()
  RVA=0x0224ACD0  token=0x600007D  System.String SerializeAllResults(System.Collections.Generic.List<Beyond.Rendering.WindowsGpuDriverVersion.Result> results)
  RVA=0x0224A6A0  token=0x600007E  System.String SerializeAllCurrentResults()
  RVA=0x02249860  token=0x600007F  System.Boolean IsBestMatchDriverVersionChanged(System.String serialized)
  RVA=0x022504E0  token=0x6000080  System.Boolean _TryGetDriverVersionByKeyId(System.String serialized, System.String keyId, System.String& driverVersion)
  RVA=0x0224F2B0  token=0x6000081  System.Int32 _ScoreAgainstUnityCurrentGpu(System.String friendlyName, System.String deviceDesc, System.String mfg)
  RVA=0x0224C7B0  token=0x6000082  System.Boolean _ContainsIgnoreCase(System.String a, System.String b)
  RVA=0x0224CB50  token=0x6000083  System.String _GetDeviceRegistryPropertyString(System.IntPtr infoSet, Beyond.Rendering.WindowsGpuDriverVersion.SP_DEVINFO_DATA& devInfo, System.UInt32 prop)
  RVA=0x0224DC60  token=0x6000084  System.String _GetDriverKeySuffix(System.String driverKey)
  RVA=0x0224E2C0  token=0x6000085  System.String _ReadRegistrySz(Beyond.Rendering.WindowsGpuDriverVersion.SafeRegistryHandle hKey, System.String valueName)
  RVA=0x0224A4C0  token=0x6000086  System.Int32 RegCloseKey(System.IntPtr hKey)
  RVA=0x0224BF00  token=0x6000087  System.IntPtr SetupDiGetClassDevs(System.Guid& classGuid, System.IntPtr enumerator, System.IntPtr hwndParent, System.UInt32 flags)
  RVA=0x0224BE20  token=0x6000088  System.Boolean SetupDiEnumDeviceInfo(System.IntPtr deviceInfoSet, System.UInt32 memberIndex, Beyond.Rendering.WindowsGpuDriverVersion.SP_DEVINFO_DATA& deviceInfoData)
  RVA=0x0224BFF0  token=0x6000089  System.Boolean SetupDiGetDeviceRegistryProperty(System.IntPtr deviceInfoSet, Beyond.Rendering.WindowsGpuDriverVersion.SP_DEVINFO_DATA& deviceInfoData, System.UInt32 property, System.UInt32& propertyRegDataType, System.IntPtr propertyBuffer, System.UInt32 propertyBufferSize, System.UInt32& requiredSize)
  RVA=0x0224C100  token=0x600008A  Beyond.Rendering.WindowsGpuDriverVersion.SafeRegistryHandle SetupDiOpenDevRegKey(System.IntPtr deviceInfoSet, Beyond.Rendering.WindowsGpuDriverVersion.SP_DEVINFO_DATA& deviceInfoData, System.UInt32 scope, System.UInt32 hwProfile, System.UInt32 keyType, System.Int32 samDesired)
  RVA=0x0224BD90  token=0x600008B  System.Boolean SetupDiDestroyDeviceInfoList(System.IntPtr deviceInfoSet)
  RVA=0x0224A540  token=0x600008C  System.Int32 RegQueryValueEx(Beyond.Rendering.WindowsGpuDriverVersion.SafeRegistryHandle hKey, System.String lpValueName, System.IntPtr lpReserved, System.UInt32& lpType, System.IntPtr lpData, System.UInt32& lpcbData)
  RVA=0x022511F0  token=0x600008D  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.SOCHelper
TYPE:  static class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
  public    static readonly System.Int32                    CHUNK_SIZE  // static @ 0x0
  public    static  System.String                   SOC_FOLDER_NAME  // const
  public    static  System.String                   SOC_INTERMEDIATE_FILE_NAME  // const
METHODS:
  RVA=0x093CB5DC  token=0x6000097  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.SceneStateAreaKey
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.UInt32                   sceneStateMask  // 0x10
  public            System.Int32                    areaId  // 0x14
  public    static readonly Beyond.Rendering.SceneStateAreaKeyDEFAULT  // static @ 0x0
METHODS:
  RVA=0x03D4E4B0  token=0x6000098  System.Void .ctor(System.UInt32 sceneStateMask, System.Int32 areaId)
  RVA=0x093CB618  token=0x6000099  System.Boolean Equals(Beyond.Rendering.SceneStateAreaKey other)
  RVA=0x093CB680  token=0x600009A  System.Boolean Equals(System.Object obj)
  RVA=0x093CB728  token=0x600009B  System.Int32 GetHashCode()
  RVA=0x093CB870  token=0x600009C  System.Void .cctor()
  RVA=0x093CB7C0  token=0x600009D  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  RVA=0x093CB820  token=0x600009E  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.Rendering.HGSOCSubSceneData
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x28
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            Beyond.Rendering.SceneStateAreaKey[]keyArray  // 0x18
  public            Beyond.Rendering.HGSOCSubSceneData.SubSceneDataPerSceneStateArea[]dataArray  // 0x20
METHODS:
  RVA=0x0286F540  token=0x600009F  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.HGSOCDataHelper
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Single                   fallOffStrength  // 0x18
  public            System.Single                   innerBlendWeight  // 0x1c
  private           System.Boolean                  <displayQuadOccluders>k__BackingField  // 0x20
  private           System.Boolean                  <displayHGOccluders>k__BackingField  // 0x21
  public            UnityEngine.Material            material  // 0x28
  public            UnityEngine.HGOccluder[]        occluders  // 0x30
PROPERTIES:
  displayQuadOccluders  get=0x03D4EF90  set=0x03D4EFC0
  displayHGOccluders  get=0x03D4F070  set=0x03D4F080
METHODS:
  RVA=0x093CB200  token=0x60000A4  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityRenderAlphaDitherController
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x30
FIELDS:
  private           Beyond.Rendering.IRendererHelperm_owner  // 0x10
  private           System.Single                   m_ditherAlpha  // 0x18
  private   static  System.Int32                    s_CharDitherFade  // static @ 0x0
  private   static  System.Int32                    s_DitherTransparentAlpha  // static @ 0x4
  private           System.Collections.Generic.Dictionary<System.Int32,System.Single>m_alphaPerHandles  // 0x20
  private           System.Boolean                  m_lastSetAllRendererEnabled  // 0x28
METHODS:
  RVA=0x02836EA0  token=0x60000A5  System.Void .ctor(Beyond.Rendering.IRendererHelper owner)
  RVA=0x02836990  token=0x60000A6  System.Void ResetDitherAlpha()
  RVA=0x028364C0  token=0x60000A7  System.Boolean SetDitherAlpha(System.Single alpha, System.Int32 handle)
  RVA=0x02836440  token=0x60000A8  System.Single GetDitherAlpha()
  RVA=0x035632F0  token=0x60000A9  System.Void Reset()
  RVA=0x02836610  token=0x60000AA  System.Boolean _ApplyNewAlpha()
  RVA=0x023E9280  token=0x60000AB  System.Single _GetCurMinAlpha()
  RVA=0x02C6AA70  token=0x60000AC  System.Collections.Generic.Dictionary<System.Int32,System.Single> GetAlphaDictionary()
  RVA=0x028367C0  token=0x60000AD  System.Void _SetMaterialDitherAlpha(System.Single value)
  RVA=0x02836770  token=0x60000AE  System.Boolean _SetMaterialDitherEnabled(System.Boolean enabled)
  RVA=0x03CF29E0  token=0x60000AF  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.EntityRenderCapturedEntity
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x28
FIELDS:
  public            UnityEngine.GameObject          rootGameObject  // 0x10
  public            System.Collections.Generic.List<UnityEngine.MeshRenderer>meshRenderers  // 0x18
  public            System.Collections.Generic.List<UnityEngine.MeshRenderer>capturedRenderers  // 0x20
METHODS:
  RVA=0x093CA738  token=0x60000B0  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityRenderCaptureMeshController
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x40
FIELDS:
  private           Beyond.Rendering.IRendererHelperm_owner  // 0x10
  private           UnityEngine.GameObject          m_gameObject  // 0x18
  private           UnityEngine.LODGroup            m_lodGroup  // 0x20
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderCapturedEntity>m_capturedEntities  // 0x28
  private           System.Int32                    m_meshRendererToSyncFrame  // 0x30
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderCaptureMeshController.MeshRendererToSync>m_meshRendererToSync  // 0x38
METHODS:
  RVA=0x028370F0  token=0x60000B1  System.Void .ctor(Beyond.Rendering.IRendererHelper owner, UnityEngine.GameObject gameObject)
  RVA=0x034BEF70  token=0x60000B2  System.Void Reset()
  RVA=0x03316A80  token=0x60000B3  System.Void LateTick()
  RVA=0x093C94F8  token=0x60000B4  Beyond.Rendering.EntityRenderCapturedEntity Capture(UnityEngine.GameObject root)
  RVA=0x03316AC0  token=0x60000B5  System.Void _SyncTransformInRenderPipeline()
  RVA=0x093CA43C  token=0x60000B6  System.Void Release(Beyond.Rendering.EntityRenderCapturedEntity mesh)
END_CLASS

CLASS: Beyond.Rendering.EntityRendererTypeConfig
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x30
FIELDS:
  public            System.Boolean                  useRegex  // 0x10
  public            System.String                   regexString  // 0x18
  public            System.Text.RegularExpressions.Regexregex  // 0x20
  public            Beyond.Rendering.EntityVFXRendererTypetype  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60000B8  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityRenderHelperMaterialController
TYPE:  class
TOKEN: 0x200002C
SIZE:  0x38
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.Material>s_cachedMaterialList  // static @ 0x0
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>m_rendererInfos  // 0x10
  private           Beyond.Rendering.EntityRenderHelperMaterialController.AddedMaterialControllerm_addedMaterialController  // 0x18
  private           Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialControllerm_meshMaterialController  // 0x20
  private           System.Collections.Generic.Dictionary<Beyond.Rendering.EntityVFXRendererMask,System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>>m_renderInfoIndexPerMask  // 0x28
  private           Beyond.Rendering.EntityRenderHelperMaterialController.CustomPerDrawDataControllerm_customPerDrawDataController  // 0x30
  private   static  Beyond.PoolCore.ObjectPool<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>s_rendererInfoPool  // static @ 0x8
  private   static  Beyond.PoolCore.ObjectPool<System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>>s_rendererInfoListPool  // static @ 0x10
  private   static  System.Int32                    s_ZTestGBuffer  // static @ 0x18
  private   static  System.Int32                    s_OutlineZTest  // static @ 0x1c
  private   static  System.String                   s_AlphaBlendOnKeyword  // static @ 0x20
METHODS:
  RVA=0x025AA270  token=0x60000B9  System.Void Init(System.Collections.Generic.List<UnityEngine.Renderer> allRenderers, System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> configs, Beyond.Rendering.EntityCustomizeRendererPropertyConfig customRendererPropertyConfig)
  RVA=0x02839450  token=0x60000BA  System.Void OnRelease()
  RVA=0x022CF1D0  token=0x60000BB  System.Void Reset()
  RVA=0x022D0FD0  token=0x60000BC  System.Boolean IsAllRendererValid()
  RVA=0x025ACD50  token=0x60000BD  System.Void StopShadowCasting(System.Boolean stopRayTracing)
  RVA=0x025ACE50  token=0x60000BE  System.Void RevertShadowCastingMode()
  RVA=0x036F5A90  token=0x60000BF  System.Int32 AddMaterialToAllRenderer(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask rendererMask, Beyond.Rendering.AddMaterialConfig config)
  RVA=0x093CAD40  token=0x60000C0  System.Void SetAddictiveFloatProperty(System.Int32 propertyId, System.Single value)
  RVA=0x093CA864  token=0x60000C1  System.Single GetAddictiveFloatProperty(System.Int32 propertyId, System.Single defaultValue)
  RVA=0x093CAE40  token=0x60000C2  System.Void SetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 value)
  RVA=0x093CA964  token=0x60000C3  UnityEngine.Vector4 GetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 defaultValue)
  RVA=0x093CADC0  token=0x60000C4  System.Void SetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture value)
  RVA=0x093CA8E4  token=0x60000C5  UnityEngine.Texture GetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture defaultValue)
  RVA=0x036F5920  token=0x60000C6  System.Void RemoveMaterialFromAllRenderer(System.Int32 handle)
  RVA=0x093CA7E0  token=0x60000C7  System.Boolean GetAddedMaterialsOfCustomizeProperties(System.Int32 handle, System.Collections.Generic.List<UnityEngine.Material> result)
  RVA=0x093CAF54  token=0x60000C8  System.Void SetKeywordEnableToAllMaterial(System.String keyword, System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093CAED4  token=0x60000C9  System.Void SetDepthOnlyPassEnableToAllMaterial(System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x02CE3950  token=0x60000CA  System.Void SetFloatToCustomPerDraw(Beyond.Rendering.EntityRenderHelperCustomPerDrawType type, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093CB080  token=0x60000CB  System.Void SetVectorToCustomPerDraw(Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType type, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x034DD9D0  token=0x60000CC  System.Void SetFloatToAllMaterial(System.Int32 nameId, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x022CF150  token=0x60000CD  System.Void SetVectorToAllMaterial(System.Int32 nameId, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x093CAFEC  token=0x60000CE  System.Void SetTextureToAllMaterial(System.Int32 nameId, UnityEngine.Texture value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=0x036F5CA0  token=0x60000CF  System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> _GetRenderersOfRendererMask(Beyond.Rendering.EntityVFXRendererMask rendererMask, System.Boolean affectAll)
  RVA=0x025A9D30  token=0x60000D0  System.Int32 _GetSubMeshCount(UnityEngine.Renderer renderer)
  RVA=0x02716640  token=0x60000D1  System.Void SetManualDitherAlphaValue(System.Single value)
  RVA=0x02716DE0  token=0x60000D2  System.Boolean SetManualDitherEnable(System.Boolean enable)
  RVA=0x024D9EF0  token=0x60000D3  UnityEngine.Bounds GetRendererBounds()
  RVA=0x093CB180  token=0x60000D4  System.Void SetZTestInMaterial(System.String shaderName, System.Boolean enable)
  RVA=0x093CAA24  token=0x60000D5  Beyond.Rendering.RenderHelperType GetRenderHelperType()
  RVA=0x0350B670  token=0x60000D6  System.Void .ctor()
  RVA=0x039C38A0  token=0x60000D7  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.EntityRenderHelperCustomPerDrawType
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityRenderHelperCustomPerDrawTypeRainEffectIntensity  // const
  public    static  Beyond.Rendering.EntityRenderHelperCustomPerDrawTypeWetEffectIntensity  // const
  public    static  Beyond.Rendering.EntityRenderHelperCustomPerDrawTypeWetEffectGlobalIntensity  // const
  public    static  Beyond.Rendering.EntityRenderHelperCustomPerDrawTypeSnowEffectIntensity  // const
  public    static  Beyond.Rendering.EntityRenderHelperCustomPerDrawTypeWetEffectWorldSpaceHeight  // const
  public    static  Beyond.Rendering.EntityRenderHelperCustomPerDrawTypeCharacterDissolveScheduleOffset  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawTypeEmissive  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityRenderHelperVisibleController
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo>m_rendererInfos  // 0x10
  private           System.Collections.Generic.Dictionary<UnityEngine.Renderer,Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo>m_dictionary  // 0x18
  private   static  Beyond.PoolCore.ObjectPool<System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo>>s_rendererInfoListPool  // static @ 0x0
  private   static  Beyond.PoolCore.ObjectPool<System.Collections.Generic.Dictionary<UnityEngine.Renderer,Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo>>s_rendererInfoDictPool  // static @ 0x8
METHODS:
  RVA=0x025AA0B0  token=0x6000105  System.Void Init(System.Collections.Generic.List<UnityEngine.Renderer> allRenderers)
  RVA=0x093CE01C  token=0x6000106  System.Void _InitDictionary()
  RVA=0x02839350  token=0x6000107  System.Void Release()
  RVA=0x02FB2910  token=0x6000108  System.Void SetVisibleByNameContainsStr(System.String name, System.Boolean visible)
  RVA=0x093CDF54  token=0x6000109  System.Void SetVisibleByRenderer(UnityEngine.Renderer renderer, System.Boolean visible)
  RVA=0x093CDCA0  token=0x600010A  System.Void ResetVisibleByNameContainsStr(System.String name)
  RVA=0x093CDE84  token=0x600010B  System.Void ResetVisibleByRenderer(UnityEngine.Renderer renderer)
  RVA=0x0312F070  token=0x600010C  System.Void Reset()
  RVA=0x0350B670  token=0x600010D  System.Void .ctor()
  RVA=0x03B32C80  token=0x600010E  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.EntityRenderMaterialManager
TYPE:  class
TOKEN: 0x2000038
SIZE:  0x50
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,System.Single>m_floatProperties  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Texture>m_textureProperties  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4>m_vectorProperties  // 0x20
  private           System.Collections.Generic.HashSet<System.String>m_EnabledKeyWords  // 0x28
  private           System.Collections.Generic.HashSet<System.String>m_DisabledKeyWords  // 0x30
  private           System.Boolean                  m_shaderPassEnabled  // 0x38
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,System.Boolean>m_oriMaterialShaderPassEnabled  // 0x40
  private   static  System.Int32                    s_ZTestGBuffer  // static @ 0x0
  private           System.Collections.Generic.List<UnityEngine.Material>m_materials  // 0x48
METHODS:
  RVA=0x093CEE84  token=0x6000111  System.Void SetFloat(System.Int32 nameID, System.Single value)
  RVA=0x093CF188  token=0x6000112  System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value)
  RVA=0x093CF280  token=0x6000113  System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value)
  RVA=0x093CE224  token=0x6000114  System.Void AddMaterial(UnityEngine.Material material)
  RVA=0x093CEA70  token=0x6000115  System.Void RemoveMaterial(UnityEngine.Material material)
  RVA=0x093CE8C0  token=0x6000116  System.Void ClearMaterials()
  RVA=0x093CEF7C  token=0x6000117  System.Void SetKeywordEnable(System.String keyword, System.Boolean enable)
  RVA=0x093CEB08  token=0x6000118  System.Void SetDepthOnlyEnabled(System.Boolean enable)
  RVA=0x093CF398  token=0x6000119  System.Void SetZTestInMaterial(System.String shaderName, System.Boolean enable)
  RVA=0x093CF524  token=0x600011A  System.Void _RevertMaterial(UnityEngine.Material material)
  RVA=0x093CF7C4  token=0x600011B  System.Void .ctor()
  RVA=0x093CF774  token=0x600011C  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXCurve
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x28
FIELDS:
  public            UnityEngine.AnimationCurve      curve  // 0x10
  public            UnityEngine.Vector2             rangeEdit  // 0x18
  public            UnityEngine.Vector2             rangeLimit  // 0x20
METHODS:
  RVA=0x0426FEE0  token=0x600011D  System.Void .ctor(UnityEngine.AnimationCurve curve)
END_CLASS

CLASS: Beyond.Rendering.EntityVFXCurveEvaluateResult
TYPE:  sealed struct
TOKEN: 0x200003A
SIZE:  0x48
FIELDS:
  public            UnityEngine.Rendering.ShaderPropertyTypepropertyType  // 0x10
  public            System.String                   propertyName  // 0x18
  public            System.Int32                    propertyId  // 0x20
  public            System.Single                   floatValue  // 0x24
  public            UnityEngine.Vector4             vectorValue  // 0x28
  public            UnityEngine.Vector4             textureScaleOffset  // 0x38
METHODS:
END_CLASS

CLASS: Beyond.Rendering.AddMaterialConfig
TYPE:  sealed struct
TOKEN: 0x200003B
SIZE:  0x20
FIELDS:
  public            System.Boolean                  useColorTexture  // 0x10
  public            System.String                   colorTextureName  // 0x18
PROPERTIES:
  useCustomizeProperty  get=0x03D51020
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXCurveData
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x58
FIELDS:
  public            System.String                   propertyName  // 0x10
  public            UnityEngine.Rendering.ShaderPropertyTypepropertyType  // 0x18
  public            Beyond.Rendering.EntityVFXCurve curve  // 0x20
  public            Beyond.Rendering.EntityVFXCurve curveX  // 0x28
  public            Beyond.Rendering.EntityVFXCurve curveY  // 0x30
  public            Beyond.Rendering.EntityVFXCurve curveZ  // 0x38
  public            Beyond.Rendering.EntityVFXCurve curveW  // 0x40
  public            UnityEngine.Gradient            gradient  // 0x48
  public            System.Single                   colorIntensity  // 0x50
METHODS:
  RVA=0x03D07BD0  token=0x600011F  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXAddictiveMaterialData
TYPE:  class
TOKEN: 0x200003D
SIZE:  0xD8
FIELDS:
  public            Beyond.Rendering.EntityVFXPriorityTypepriorityType  // 0x10
  public            Beyond.Rendering.EntityVFXRendererMaskrendererMask  // 0x14
  public            System.Boolean                  useScaledTime  // 0x18
  public            System.Boolean                  enableVertColorIfMeshHasVFXVertColor  // 0x19
  public            UnityEngine.Material            material  // 0x20
  public            System.Boolean                  loop  // 0x28
  public            System.Boolean                  useDissolveCurve  // 0x29
  public            System.Boolean                  useScanCurve  // 0x2a
  public            System.Boolean                  useCutoffPosY  // 0x2b
  public            System.Boolean                  useCutoffPosYAutoBounds  // 0x2c
  public            System.Single                   cutoffPosYAbsoluteBounds  // 0x30
  public            System.Boolean                  useCutoffLocalDirection  // 0x34
  public            UnityEngine.Vector3             cutoffDirection  // 0x38
  public            System.Single                   duration  // 0x44
  public            System.Boolean                  useStartCurve  // 0x48
  public            UnityEngine.AnimationCurve      opacityCurve  // 0x50
  public            UnityEngine.AnimationCurve      dissolveCurve  // 0x58
  public            UnityEngine.AnimationCurve      scanCurve  // 0x60
  public            UnityEngine.AnimationCurve      cutoffPosYCurve  // 0x68
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customCurves  // 0x70
  public            System.Boolean                  useLoopCurve  // 0x78
  public            System.Single                   loopDuration  // 0x7c
  public            UnityEngine.AnimationCurve      loopCurve  // 0x80
  public            UnityEngine.AnimationCurve      dissolveLoopCurve  // 0x88
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customLoopCurves  // 0x90
  public            System.Boolean                  useEndCurve  // 0x98
  public            System.Single                   endDuration  // 0x9c
  public            UnityEngine.AnimationCurve      endCurve  // 0xa0
  public            UnityEngine.AnimationCurve      dissolveEndCurve  // 0xa8
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customEndCurves  // 0xb0
  public            System.Boolean                  useAddictiveProperties  // 0xb8
  public            System.Boolean                  useAddictivePropertiesUpdate  // 0xb9
  public            System.Collections.Generic.List<System.String>addictiveVectorProperties  // 0xc0
  public            System.Boolean                  useColorTexture  // 0xc8
  public            System.String                   colorTextureName  // 0xd0
METHODS:
  RVA=0x0381D2A0  token=0x6000120  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXAddictiveMaterialAsset
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x38
EXTENDS: Beyond.Rendering.EntityVFXAssetBase
FIELDS:
  public            Beyond.Rendering.EntityVFXAddictiveMaterialDatadata  // 0x30
METHODS:
  RVA=0x038D01E0  token=0x6000121  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXAfterImageData
TYPE:  class
TOKEN: 0x200003F
SIZE:  0x78
FIELDS:
  public            System.Boolean                  useScaledTime  // 0x10
  public            Beyond.Rendering.EntityVFXAfterImageData.TimeModetimeMode  // 0x14
  public            System.Boolean                  loop  // 0x18
  public            System.Single                   duration  // 0x1c
  public            System.Single                   timeInterval  // 0x20
  public            System.Collections.Generic.List<System.Single>timeBurst  // 0x28
  public            UnityEngine.Material            depthOnlyMaterial  // 0x30
  public            UnityEngine.Material            material  // 0x38
  public            UnityEngine.Material            materialOutline  // 0x40
  public            System.Single                   lifeTime  // 0x48
  public            UnityEngine.AnimationCurve      opacityCurve  // 0x50
  public            UnityEngine.AnimationCurve      dissolveCurve  // 0x58
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customCurves  // 0x60
  public            UnityEngine.AnimationCurve      opacityCurveOutline  // 0x68
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customCurvesOutline  // 0x70
METHODS:
  RVA=0x03D42BE0  token=0x6000122  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXAfterImageAsset
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x38
EXTENDS: Beyond.Rendering.EntityVFXAssetBase
FIELDS:
  public            Beyond.Rendering.EntityVFXAfterImageDatadata  // 0x30
METHODS:
  RVA=0x038D01E0  token=0x6000123  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityCustomizeRendererType
TYPE:  sealed struct
TOKEN: 0x2000042
SIZE:  0x28
FIELDS:
  public            System.Boolean                  useContainStr  // 0x10
  public            System.String                   rendererNameRegex  // 0x18
  public            Beyond.Rendering.EntityVFXRendererTypetype  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXAsset
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x40
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            Beyond.Rendering.RenderHelperTyperenderHelperType  // 0x18
  public            System.Boolean                  useCustomRenderer  // 0x1c
  public            System.Collections.Generic.List<Beyond.Rendering.EntityCustomizeRendererType>customRenderers  // 0x20
  public            System.Boolean                  meshHasVFXVertColor  // 0x28
  public            System.Boolean                  useCustomRendererProperty  // 0x29
  public            Beyond.Rendering.EntityCustomizeRendererPropertyConfigcustomRendererPropertyConfig  // 0x30
  private           System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig>m_rendererTypeConfigs  // 0x38
METHODS:
  RVA=0x034968A0  token=0x6000124  System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> GetRendererTypeConfigs(System.Boolean forceUpdate)
  RVA=0x0399C530  token=0x6000125  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXRendererType
TYPE:  sealed struct
TOKEN: 0x2000044
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXRendererTypeNormal  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeBody  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeCloth  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeEyebrow  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeEyeShadow  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeFace  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeHair  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeHairShadow  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeIris  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeWeapon1  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeWeapon2  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart1  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart2  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart3  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart4  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart5  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart6  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart7  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart8  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart9  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart10  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart11  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart12  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart13  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart14  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypePart15  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeAlphaQuadAvoidAddMaterial  // const
  public    static  Beyond.Rendering.EntityVFXRendererTypeCount  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXRendererMask
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXRendererMaskNormal  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskBody  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskCloth  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskEyebrow  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskEyeShadow  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskFace  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskHair  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskHairShadow  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskIris  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskWeapon1  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskWeapon2  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart1  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart2  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart3  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart4  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart5  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart6  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart7  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart8  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart9  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart10  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart11  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart12  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart13  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart14  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskPart15  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskAlphaQuadAvoidAddMaterial  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskAll  // const
  public    static  Beyond.Rendering.EntityVFXRendererMaskAllWithoutAlphaQuad  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXPriorityType
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXPriorityTypeNormal  // const
  public    static  Beyond.Rendering.EntityVFXPriorityTypeUltiSkillTimeline  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.SettingLodLevel
TYPE:  sealed struct
TOKEN: 0x2000047
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.SettingLodLevelNone  // const
  public    static  Beyond.Rendering.SettingLodLevelLow  // const
  public    static  Beyond.Rendering.SettingLodLevelMid  // const
  public    static  Beyond.Rendering.SettingLodLevelHigh  // const
  public    static  Beyond.Rendering.SettingLodLevelHighest  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.AssetPlatformLayers
TYPE:  sealed struct
TOKEN: 0x2000048
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.AssetPlatformLayersPC  // const
  public    static  Beyond.Rendering.AssetPlatformLayersMobile  // const
  public    static  Beyond.Rendering.AssetPlatformLayersOther  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EffectTargetLayers
TYPE:  sealed struct
TOKEN: 0x2000049
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EffectTargetLayersMain  // const
  public    static  Beyond.Rendering.EffectTargetLayersGuard  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXAssetBase
TYPE:  class
TOKEN: 0x200004A
SIZE:  0x30
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            System.Boolean                  useECSRenderer  // 0x18
  public            Beyond.Rendering.SettingLodLevelsettingLodLevel  // 0x1c
  public            Beyond.Rendering.AssetPlatformLayersplatformLayer  // 0x20
  public            Beyond.Rendering.EffectTargetLayerstargetLayer  // 0x24
  private           System.String                   m_assetName  // 0x28
PROPERTIES:
  assetName  get=0x093CF9EC
METHODS:
  RVA=0x04276C40  token=0x6000127  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.VFXType
TYPE:  sealed struct
TOKEN: 0x200004B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.VFXType        Addictive  // const
  public    static  Beyond.Rendering.VFXType        Dissolve  // const
  public    static  Beyond.Rendering.VFXType        Max  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXControllerBase
TYPE:  class
TOKEN: 0x200004C
SIZE:  0x48
FIELDS:
  public            Beyond.Rendering.SettingLodLevelsettingLodLevel  // 0x10
  public            Beyond.Rendering.AssetPlatformLayersplatformLayer  // 0x14
  public            Beyond.Rendering.EffectTargetLayerstargetLayer  // 0x18
  protected         Beyond.Rendering.IRendererHelperm_owner  // 0x20
  protected         System.Boolean                  m_isPlaying  // 0x28
  private           System.Boolean                  m_isHiding  // 0x29
  protected         System.Boolean                  m_isKeyword  // 0x2a
  private           System.String                   m_vfxName  // 0x30
  private           System.Single                   m_destroyTime  // 0x38
  private           System.Single                   m_lastTickTime  // 0x3c
  public            System.Boolean                  preload  // 0x40
  public            System.Boolean                  fromTimeline  // 0x41
PROPERTIES:
  isPlaying  get=0x03D4ED50
  isHiding  get=0x03D4F2A0
  isKeyword  get=0x03D4F4B0
  vfxName  get=0x01003830
  destroyTime  get=0x03D51000  set=0x03D51010
  lastTickTime  get=0x03D4EC60  set=0x03D4ECE0
METHODS:
  RVA=0x0386BBC0  token=0x6000130  System.Void SetOwner(System.String name, Beyond.Rendering.IRendererHelper owner)
  RVA=0x02DE0850  token=0x6000131  System.Void InitLOD(Beyond.Rendering.EntityVFXAssetBase vfxAssetBase)
  RVA=0x02DE1130  token=0x6000132  System.Void SetName(System.String name)
  RVA=0x093CFD28  token=0x6000133  System.Boolean PoolTick()
  RVA=0x093CFA58  token=0x6000134  System.Void Destroy()
  RVA=0x093CFBB0  token=0x6000135  System.Void OnDestroy()
  RVA=0x093CFCE4  token=0x6000136  System.Void Play()
  RVA=0x093CFE90  token=0x6000137  System.Void Stop(System.Boolean forceStop)
  RVA=0x093CFD78  token=0x6000138  System.Void Replay()
  RVA=0x093CFEE4  token=0x6000139  System.Void Tick(System.Single logicDeltaTime)
  RVA=0x036F5580  token=0x600013A  System.Void RefreshLastTickTime()
  RVA=0x0338AC90  token=0x600013B  System.Single GetDeltaTimeFromLastTick(System.Boolean useScaledTime)
  RVA=0x093CFB08  token=0x600013C  Beyond.Rendering.EntityVFXPriorityType GetPriorityType()
  RVA=0x093CFABC  token=0x600013D  System.Boolean GetNeedTick()
  RVA=0x093CFB54  token=0x600013E  System.Void Hide()
  RVA=0x093CFBF4  token=0x600013F  System.Void OnHide()
  RVA=0x093CFE38  token=0x6000140  System.Void Show()
  RVA=0x093CFCA0  token=0x6000141  System.Void OnShow()
  RVA=0x093CFDBC  token=0x6000142  System.Void Sample(System.Single time, System.Boolean ending)
  RVA=0x093CFC38  token=0x6000143  System.Void OnSample(System.Single time, System.Boolean ending)
  RVA=0x03D57FC0  token=0x6000144  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXControllerStateBase
TYPE:  abstract class
TOKEN: 0x200004D
SIZE:  0x58
EXTENDS: Beyond.Rendering.EntityVFXControllerBase
FIELDS:
  private           System.Single                   <m_passTime>k__BackingField  // 0x48
  private           System.Single                   <m_loopPassTime>k__BackingField  // 0x4c
  private           System.Single                   <m_endPassTime>k__BackingField  // 0x50
  private           Beyond.Rendering.EntityVFXControllerStateBase.Statem_curState  // 0x54
PROPERTIES:
  m_passTime  get=0x03D58370  set=0x03D5BE60
  m_loopPassTime  get=0x03D50200  set=0x03D5E680
  m_endPassTime  get=0x03D51C90  set=0x03D51CA0
  useScaledTime  get=0x0115F4C0
  useStartCurve  get=0x0115F4C0
  useLoopCurve  get=0x0115F4C0
  useEndCurve  get=0x0115F4C0
  loop  get=0x0115F4C0
  duration  get=0x03D51A60
  loopDuration  get=0x03D51A60
  endDuration  get=0x03D503F0
METHODS:
  RVA=0x036F5520  token=0x600014B  System.Void Play()
  RVA=0x093D003C  token=0x600014C  System.Void Replay()
  RVA=0x03D030A0  token=0x600014D  System.Void Stop(System.Boolean forceStop)
  RVA=0x035A66C0  token=0x600014E  System.Boolean GetNeedTick()
  RVA=0x0338ABE0  token=0x600014F  System.Void Tick(System.Single logicDeltaTime)
  RVA=0x093CFF38  token=0x6000150  System.Void OnSample(System.Single time, System.Boolean ending)
  RVA=-1  // abstract  token=0x6000159  System.Void UpdateStart()
  RVA=-1  // abstract  token=0x600015A  System.Void UpdateLoop()
  RVA=-1  // abstract  token=0x600015B  System.Void UpdateStop()
  RVA=0x03D030F0  token=0x600015C  System.Void _FinalStop()
  RVA=-1  // abstract  token=0x600015D  System.Void OnFinalStop()
  RVA=0x03D57FC0  token=0x600015E  System.Void .ctor()
  RVA=0x058D7D9C  token=0x600015F  System.Void <>iFixBaseProxy_Play()
  RVA=0x058D7DA4  token=0x6000160  System.Void <>iFixBaseProxy_Replay()
  RVA=0x058D7DAC  token=0x6000161  System.Void <>iFixBaseProxy_Stop(System.Boolean P0)
  RVA=0x058D8A54  token=0x6000162  System.Boolean <>iFixBaseProxy_GetNeedTick()
  RVA=0x058D7DB4  token=0x6000163  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x058D7D8C  token=0x6000164  System.Void <>iFixBaseProxy_OnSample(System.Single P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.Rendering.EntityCustomizePropertyName
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityCustomizePropertyNameNone  // const
  public    static  Beyond.Rendering.EntityCustomizePropertyNameAlphaTex  // const
  public    static  Beyond.Rendering.EntityCustomizePropertyNameNormalTex  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityCustomizeMatchMethod
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityCustomizeMatchMethodNone  // const
  public    static  Beyond.Rendering.EntityCustomizeMatchMethodAll  // const
  public    static  Beyond.Rendering.EntityCustomizeMatchMethodRendererName  // const
  public    static  Beyond.Rendering.EntityCustomizeMatchMethodSourceMaterial0  // const
  public    static  Beyond.Rendering.EntityCustomizeMatchMethodSourceMesh  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityCustomizeRendererPropertyConfig
TYPE:  class
TOKEN: 0x2000051
SIZE:  0x28
FIELDS:
  public            System.Boolean                  useColorTexture  // 0x10
  public            System.Boolean                  useAutoFindColorTexture  // 0x11
  public            System.String                   autoFindColorTextureName  // 0x18
  public            Beyond.SerializeFieldDictionary<UnityEngine.Material,UnityEngine.Texture>preConfigColorTextureDict  // 0x20
METHODS:
  RVA=0x093CDBF8  token=0x6000165  UnityEngine.Texture GetColorTexture(UnityEngine.Material material)
  RVA=0x0350B670  token=0x6000166  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXKeywordEnum
TYPE:  sealed struct
TOKEN: 0x2000052
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.EntityVFXKeywordEnumNone  // const
  public    static  Beyond.Rendering.EntityVFXKeywordEnumDissolve  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.EntityVFXDissolveData
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x98
FIELDS:
  public            Beyond.Rendering.EntityVFXPriorityTypepriorityType  // 0x10
  public            Beyond.Rendering.EntityVFXRendererMaskrendererMask  // 0x14
  public            System.Boolean                  useScaledTime  // 0x18
  public            System.Boolean                  loop  // 0x19
  public            System.Single                   duration  // 0x1c
  public            Beyond.Rendering.EntityVFXDissolveData.UVSetuvSet  // 0x20
  public            System.Boolean                  useCutoffPosY  // 0x24
  public            System.Boolean                  useCutoffPosYAutoBounds  // 0x25
  public            System.Single                   cutoffPosYAbsoluteBounds  // 0x28
  public            System.Boolean                  useCutoffLocalDirection  // 0x2c
  public            UnityEngine.Vector3             cutoffDirection  // 0x30
  public            System.Single                   cutoffUseDissolve  // 0x3c
  public            System.Boolean                  stopShadowCasting  // 0x40
  public            System.Boolean                  stopRayTracingMeanTime  // 0x41
  public            System.Single                   stopShadowCastingDelay  // 0x44
  public            System.Single                   revertShadowCastingDelay  // 0x48
  public            UnityEngine.Texture2D           dissolveTexture  // 0x50
  public            UnityEngine.Vector4             dissolveTextureTillingOffset  // 0x58
  public            System.Single                   dissolveEdgeSharp  // 0x68
  public            UnityEngine.Color               dissolveEmissiveColor  // 0x6c
  public            System.Single                   dissolveEmissiveEdge  // 0x7c
  public            System.Boolean                  useLocalScreenUV  // 0x80
  public            UnityEngine.AnimationCurve      dissolveValueCurve  // 0x88
  public            UnityEngine.AnimationCurve      cutoffPosYCurve  // 0x90
METHODS:
  RVA=0x03A1C920  token=0x6000167  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXDissolveAsset
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x38
EXTENDS: Beyond.Rendering.EntityVFXAssetBase
FIELDS:
  public            Beyond.Rendering.EntityVFXDissolveDatadata  // 0x30
METHODS:
  RVA=0x038D01E0  token=0x6000168  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityFactoryRendererInfo
TYPE:  class
TOKEN: 0x2000056
SIZE:  0x20
FIELDS:
  public            System.Int32                    subMeshCount  // 0x10
  public            System.Boolean                  enableVAT  // 0x14
  public            System.Int32                    vatIndex  // 0x18
  public            System.Int32                    initMaterialsCount  // 0x1c
METHODS:
  RVA=0x0350B670  token=0x6000169  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXFactoryAddedMaterialManager
TYPE:  class
TOKEN: 0x2000057
SIZE:  0x30
FIELDS:
  private   static readonly System.Int32                    S_ENABLE_FACTORY_VAT  // static @ 0x0
  private   static readonly System.Int32                    S_FACTORY_VAT_MAP  // static @ 0x4
  private   static readonly System.Int32                    S_FACTORY_VAT_MAP_PARAMS  // static @ 0x8
  private           System.Collections.Generic.List<Beyond.Rendering.EntityFactoryRendererInfo>m_factoryRendererInfos  // 0x10
  private           System.Collections.Generic.List<Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.VATData>m_vatDatas  // 0x18
  private           System.Collections.Generic.List<Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData>m_addedMaterialDatas  // 0x20
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData>m_addedMaterialDataDict  // 0x28
METHODS:
  RVA=0x093D0124  token=0x600016A  System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityFactoryRendererInfo> factoryRendererInfos)
  RVA=0x093D0674  token=0x600016B  System.Void _AddVATMaterial(UnityEngine.Material src)
  RVA=0x093D0ADC  token=0x600016C  UnityEngine.Material _GetVATMaterial(Beyond.Rendering.EntityFactoryRendererInfo rendererInfo, UnityEngine.Material src)
  RVA=0x093D09B8  token=0x600016D  System.Int32 _GetAddedMaterialIndex(Beyond.Rendering.EntityFactoryRendererInfo rendererInfo, UnityEngine.Material src)
  RVA=0x093D0BAC  token=0x600016E  System.Void _RemoveVATMaterial(UnityEngine.Material src)
  RVA=0x093D00A0  token=0x600016F  System.Void AddMaterialToAllRenderer(UnityEngine.Material material)
  RVA=0x093D0278  token=0x6000170  System.Void RemoveMaterialFromAllRenderer(UnityEngine.Material material)
  RVA=0x093D03E8  token=0x6000171  System.Void SetFloatToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, System.Single value)
  RVA=0x093D051C  token=0x6000172  System.Void SetVectorToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, UnityEngine.Vector4 value)
  RVA=0x093D0DB4  token=0x6000173  System.Void .ctor()
  RVA=0x093D0D0C  token=0x6000174  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXFactoryMaterialCache
TYPE:  static class
TOKEN: 0x200005C
SIZE:  0x10
FIELDS:
  private   static readonly System.Int32                    S_FACTORY_VAT_MAP  // static @ 0x0
  private   static readonly System.Int32                    S_FACTORY_VAT_MAP_PARAMS  // static @ 0x4
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,Beyond.Rendering.EntityVFXFactoryMaterialCache.VATMaterialData>>s_cachedMaterials  // static @ 0x8
METHODS:
  RVA=0x093D0F0C  token=0x600017B  UnityEngine.Material GetVATMaterial(UnityEngine.Material srcMaterial, UnityEngine.Texture factoryVATMap, UnityEngine.Vector4 factoryVATMapParams)
  RVA=0x093D1220  token=0x600017C  System.Void ReleaseVATMaterial(UnityEngine.Material srcMaterial, UnityEngine.Texture factoryVATMap)
  RVA=0x093D1454  token=0x600017D  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXSetParamsData
TYPE:  class
TOKEN: 0x200005E
SIZE:  0x50
FIELDS:
  public            Beyond.Rendering.EntityVFXPriorityTypepriorityType  // 0x10
  public            Beyond.Rendering.EntityVFXRendererMaskrendererMask  // 0x14
  public            System.Boolean                  useScaledTime  // 0x18
  public            System.Boolean                  loop  // 0x19
  public            Beyond.Rendering.EntityVFXSetParamsData.Typetype  // 0x1c
  public            System.Single                   duration  // 0x20
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customCurves  // 0x28
  public            System.Boolean                  useLoopCurve  // 0x30
  public            System.Single                   loopDuration  // 0x34
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customLoopCurves  // 0x38
  public            System.Single                   endDuration  // 0x40
  public            System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData>customEndCurves  // 0x48
METHODS:
  RVA=0x03D4D0D0  token=0x600017F  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXSetParamsAsset
TYPE:  class
TOKEN: 0x2000060
SIZE:  0x38
EXTENDS: Beyond.Rendering.EntityVFXAssetBase
FIELDS:
  public            Beyond.Rendering.EntityVFXSetParamsDatadata  // 0x30
METHODS:
  RVA=0x038D01E0  token=0x6000180  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.EntityVFXUtils
TYPE:  static class
TOKEN: 0x2000061
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x025AA760  token=0x6000181  Beyond.Rendering.EntityVFXRendererMask ToMask(Beyond.Rendering.EntityVFXRendererType type)
  RVA=0x093D16AC  token=0x6000182  System.Void CalculateCutOffBounds(Beyond.Rendering.IRendererHelper owner, System.Boolean useCutoffLocalDirection, UnityEngine.Vector3 cutoffDirectionData, System.Boolean useCutoffPosYAutoBounds, System.Single cutoffPosYAbsoluteBounds, System.Single& cutoffMin, System.Single& cutoffMax, UnityEngine.Vector3& cutoffDirection)
  RVA=0x093D18E8  token=0x6000183  System.ValueTuple<System.Single,System.Single> GetBoundsMinMaxOfDirection(UnityEngine.Bounds bounds, UnityEngine.Vector3 direction)
  RVA=0x093D153C  token=0x6000184  System.Void ApplyEntityVFXCurves(UnityEngine.Material material, System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> curveDataList, System.Single schedule)
  RVA=0x022CEE30  token=0x6000185  Beyond.Rendering.EntityVFXCurveEvaluateResult Evaluate(Beyond.Rendering.EntityVFXCurveData curveData, System.Single schedule)
  RVA=0x093D1C38  token=0x6000186  System.Void _UpdateCurve(UnityEngine.Material material, Beyond.Rendering.EntityVFXCurveData curveData, System.Single schedule)
  RVA=0x093D1AF8  token=0x6000187  System.Boolean IsCharacterShader(System.String name)
  RVA=0x093D1B98  token=0x6000188  System.Boolean IsLitShader(System.String name)
END_CLASS

CLASS: Beyond.Rendering.ICaptureMesh
TYPE:  interface
TOKEN: 0x2000062
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000189  Beyond.Rendering.EntityRenderCapturedEntity Capture(UnityEngine.GameObject placeRoot)
  RVA=-1  // abstract  token=0x600018A  System.Void Release(Beyond.Rendering.EntityRenderCapturedEntity mesh)
END_CLASS

CLASS: Beyond.Rendering.RenderHelperType
TYPE:  sealed struct
TOKEN: 0x2000063
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.RenderHelperTypeUnknown  // const
  public    static  Beyond.Rendering.RenderHelperTypeCharacter  // const
  public    static  Beyond.Rendering.RenderHelperTypeLit  // const
  public    static  Beyond.Rendering.RenderHelperTypeMix  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.IRendererHelper
TYPE:  interface
TOKEN: 0x2000064
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600018B  System.Void Reset()
  RVA=-1  // abstract  token=0x600018C  System.Void Play(System.String vfxName)
  RVA=-1  // abstract  token=0x600018D  System.Void Stop(System.String vfxName)
  RVA=-1  // abstract  token=0x600018E  System.Void ShowAll()
  RVA=-1  // abstract  token=0x600018F  System.Void HideAll()
  RVA=-1  // abstract  token=0x6000190  System.Void SetDitherAlpha(System.Single ditherAlpha, System.Int32 handle)
  RVA=-1  // abstract  token=0x6000191  System.Single GetDitherAlpha()
  RVA=-1  // abstract  token=0x6000192  System.Void ResetAllDitherAlpha()
  RVA=-1  // abstract  token=0x6000193  System.Void ClearEffectCache(System.String name)
  RVA=-1  // abstract  token=0x6000194  System.Void SetVisibleByNameContainsStr(System.String name, System.Boolean visible)
  RVA=-1  // abstract  token=0x6000195  System.Void SetVisibleByRenderer(UnityEngine.Renderer renderer, System.Boolean visible)
  RVA=-1  // abstract  token=0x6000196  System.Int32 AddMaterialToAllRenderer(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask rendererMask, Beyond.Rendering.AddMaterialConfig config)
  RVA=-1  // abstract  token=0x6000197  System.Void RemoveMaterialFromAllRenderer(System.Int32 handle)
  RVA=-1  // abstract  token=0x6000198  System.Boolean GetAddedMaterialsOfCustomizeProperties(System.Int32 handle, System.Collections.Generic.List<UnityEngine.Material> result)
  RVA=-1  // abstract  token=0x6000199  System.Void SetKeywordEnableToAllMaterial(System.String keyword, System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=-1  // abstract  token=0x600019A  System.Void SetFloatToAllMaterial(System.Int32 nameId, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=-1  // abstract  token=0x600019B  System.Void SetFloatToCustomPerDraw(Beyond.Rendering.EntityRenderHelperCustomPerDrawType type, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=-1  // abstract  token=0x600019C  System.Void SetTextureToAllMaterial(System.Int32 nameId, UnityEngine.Texture value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=-1  // abstract  token=0x600019D  System.Void SetVectorToAllMaterial(System.Int32 nameId, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=-1  // abstract  token=0x600019E  System.Void SetFloatToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, System.Single value)
  RVA=-1  // abstract  token=0x600019F  System.Void SetVectorToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, UnityEngine.Vector4 value)
  RVA=-1  // abstract  token=0x60001A0  System.Void SetAddictiveFloatProperty(System.Int32 propertyId, System.Single value)
  RVA=-1  // abstract  token=0x60001A1  System.Single GetAddictiveFloatProperty(System.Int32 propertyId, System.Single defaultValue)
  RVA=-1  // abstract  token=0x60001A2  System.Void SetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 value)
  RVA=-1  // abstract  token=0x60001A3  UnityEngine.Vector4 GetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 defaultValue)
  RVA=-1  // abstract  token=0x60001A4  System.Void SetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture value)
  RVA=-1  // abstract  token=0x60001A5  UnityEngine.Texture GetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture defaultValue)
  RVA=-1  // abstract  token=0x60001A6  System.Void StopShadowCasting(System.Boolean stopRayTracing)
  RVA=-1  // abstract  token=0x60001A7  System.Void RevertShadowCastingMode()
  RVA=-1  // abstract  token=0x60001A8  System.Void SetDepthOnlyEnabledToAllMaterial(System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask)
  RVA=-1  // abstract  token=0x60001A9  System.Boolean SetManualDitherEnable(System.Boolean enable)
  RVA=-1  // abstract  token=0x60001AA  System.Void SetManualDitherAlphaValue(System.Single value)
  RVA=-1  // abstract  token=0x60001AB  UnityEngine.Bounds GetRendererBounds()
  RVA=-1  // abstract  token=0x60001AC  UnityEngine.Matrix4x4 GetTransform()
  RVA=-1  // abstract  token=0x60001AD  System.Boolean IsFactory()
  RVA=-1  // abstract  token=0x60001AE  Beyond.Rendering.RenderHelperType GetRenderHelperType(System.Boolean forceCalculate)
  RVA=-1  // abstract  token=0x60001AF  System.Void SetTimeScale(System.Single timeScale)
  RVA=-1  // abstract  token=0x60001B0  System.Single GetTimeScale()
  RVA=-1  // abstract  token=0x60001B1  System.Boolean GetMeshHasVFXVertColor()
  RVA=-1  // abstract  token=0x60001B2  System.Boolean CanPlay(Beyond.Rendering.SettingLodLevel settingLodLevel, Beyond.Rendering.AssetPlatformLayers platformLayer, Beyond.Rendering.EffectTargetLayers targetLayer)
END_CLASS

CLASS: Beyond.Rendering.CommonVAT
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x50
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static readonly System.Int32                    S_COMMON_VAT_PLAY_PARAMS  // static @ 0x0
  public            Beyond.Rendering.RuntimeVATData data  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>>m_animDic  // 0x20
  private           System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>m_curClips  // 0x28
  private           Beyond.Rendering.VATPropertySetterm_propertySetter  // 0x30
  private           System.Int32                    m_curIndex  // 0x38
  private           System.Int32                    m_nextPlayTimerId  // 0x3c
  private           System.Boolean                  m_hasNextAnimToPlay  // 0x40
  private           System.String                   m_nextAnimName  // 0x48
PROPERTIES:
  PropertySetterType  get=0x093CDB60
METHODS:
  RVA=0x093CD14C  token=0x60001B4  System.Void Start()
  RVA=0x093CD0B4  token=0x60001B5  System.Void Play(System.String name, System.Boolean playWhenComplete)
  RVA=0x093CD56C  token=0x60001B6  System.Void _DoPlay(System.String name)
  RVA=0x093CD750  token=0x60001B7  System.Void _NextPlay()
  RVA=0x093CD484  token=0x60001B8  System.Void _CreateTimer(System.Single time, System.Action func, System.String funcName)
  RVA=0x093CD3F4  token=0x60001B9  System.Void _ClearTimer()
  RVA=0x093CD918  token=0x60001BA  System.Void _UpdateProperty(Beyond.Rendering.RuntimeVATAnimationClip runtimeVatAnimationClip)
  RVA=0x093CDA8C  token=0x60001BB  System.Void .ctor()
  RVA=0x093CDA3C  token=0x60001BC  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.FactoryVAT
TYPE:  class
TOKEN: 0x2000066
SIZE:  0x90
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.Rendering.RuntimeVATData data  // 0x18
  public            System.Single                   speed  // 0x20
  public            System.Single                   passTime  // 0x24
  public            System.Int32                    lastFrame  // 0x28
  public            System.Int32                    curFrame  // 0x2c
  public            System.Boolean                  preview  // 0x30
  private           UnityEngine.MaterialPropertyBlockm_materialPropertyBlock  // 0x38
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>>m_animDic  // 0x40
  private           System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>m_curClips  // 0x48
  private           System.Int32                    m_curIndex  // 0x50
  private           System.Action                   m_callBack  // 0x58
  private           System.Boolean                  m_hasNextAnimToPlay  // 0x60
  private           System.String                   m_nextAnimName  // 0x68
  private           System.Action                   m_nextAnimCallBack  // 0x70
  private   static readonly System.Int32                    S_FACTORY_VAT_FRAME  // static @ 0x0
  private   static readonly System.Int32                    S_FACTORY_VAT_LAST_FRAME  // static @ 0x4
  private           System.Collections.Generic.List<UnityEngine.Renderer>m_allRenderers  // 0x78
  private           System.Collections.Generic.List<UnityEngine.Renderer>m_dynamicRenders  // 0x80
  private           System.Collections.Generic.List<UnityEngine.Renderer>m_staticRenders  // 0x88
METHODS:
  RVA=0x093D1F28  token=0x60001BD  System.Void Start()
  RVA=0x093D1ED8  token=0x60001BE  System.Void Reset()
  RVA=0x093D2984  token=0x60001BF  System.Void _UpdateAnim()
  RVA=0x093D1DCC  token=0x60001C0  System.Void OnUpdate()
  RVA=0x093D1E1C  token=0x60001C1  System.Void Play(System.String name, System.Action callBack, System.Boolean whenComplete)
  RVA=0x093D2128  token=0x60001C2  System.Void _DoPlay(System.String name, System.Action callBack)
  RVA=0x093D24A0  token=0x60001C3  System.Void _InitRenderer()
  RVA=0x093D2248  token=0x60001C4  System.Void _InitRenderer_MeshRender(UnityEngine.LODGroup lodGroup)
  RVA=0x093D2934  token=0x60001C5  System.Void _SetParamsToRenderer()
  RVA=0x093D280C  token=0x60001C6  System.Void _SetParamsToRenderer_MeshRender()
  RVA=0x093D27BC  token=0x60001C7  System.Void _ReSetParamsToRenderer()
  RVA=0x093D2584  token=0x60001C8  System.Void _ReSetParamsToRenderer_MeshRender()
  RVA=0x093D2BDC  token=0x60001C9  System.Void .ctor()
  RVA=0x093D2B60  token=0x60001CA  System.Void .cctor()
END_CLASS

CLASS: Beyond.Rendering.RuntimeVATAnimationClip
TYPE:  class
TOKEN: 0x2000067
SIZE:  0x30
FIELDS:
  public            System.String                   stateName  // 0x10
  public            System.String                   name  // 0x18
  public            System.Boolean                  loop  // 0x20
  public            System.Int32                    startFrame  // 0x24
  public            System.Int32                    endFrame  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60001CB  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.RuntimeVATData
TYPE:  class
TOKEN: 0x2000068
SIZE:  0x38
FIELDS:
  public            UnityEngine.Texture             vatMap  // 0x10
  public            System.Boolean                  fullRigidBody  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>bonePoses  // 0x20
  public            System.Single                   frameRate  // 0x28
  public            System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>animationClips  // 0x30
METHODS:
  RVA=0x093D59C0  token=0x60001CC  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.VATPropertySetter
TYPE:  abstract class
TOKEN: 0x2000069
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001CD  System.Void Init(UnityEngine.GameObject gameObject)
  RVA=-1  // abstract  token=0x60001CE  System.Void SetFloat(System.Int32 id, System.Single value)
  RVA=-1  // abstract  token=0x60001CF  System.Void SetVector(System.Int32 id, UnityEngine.Vector4 value)
  RVA=0x0350B670  token=0x60001D0  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.VATRendererPropertySetter
TYPE:  class
TOKEN: 0x200006A
SIZE:  0x20
EXTENDS: Beyond.Rendering.VATPropertySetter
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Renderer>m_allRenderers  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Material>m_allMaterials  // 0x18
METHODS:
  RVA=0x093D9C68  token=0x60001D1  System.Void Init(UnityEngine.GameObject gameObject)
  RVA=0x093D9EE8  token=0x60001D2  System.Void SetFloat(System.Int32 id, System.Single value)
  RVA=0x093DA070  token=0x60001D3  System.Void SetVector(System.Int32 id, UnityEngine.Vector4 value)
  RVA=0x0350B670  token=0x60001D4  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.VATEntityRendererHelperPropertySetter
TYPE:  class
TOKEN: 0x200006B
SIZE:  0x18
EXTENDS: Beyond.Rendering.VATPropertySetter
FIELDS:
  private           Beyond.Rendering.IRendererHelperm_rendererHelper  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60001D5  System.Void .ctor(Beyond.Rendering.IRendererHelper rendererHelper)
  RVA=0x093D9B00  token=0x60001D6  System.Void Init(UnityEngine.GameObject gameObject)
  RVA=0x093D9B54  token=0x60001D7  System.Void SetFloat(System.Int32 id, System.Single value)
  RVA=0x093D9BD4  token=0x60001D8  System.Void SetVector(System.Int32 id, UnityEngine.Vector4 value)
END_CLASS

CLASS: Beyond.Rendering.PsoCreateUploadHelper
TYPE:  class
TOKEN: 0x200006C
SIZE:  0x18
FIELDS:
  protected static  System.Int32                    PSO_UPLOAD_INFO_VERSION  // const
  protected static  System.Int32                    MAX_UPLOAD_COUNT_PER_LOOP  // const
  protected static  System.Int32                    MAX_UPLOAD_COUNT_PER_LOOP_LARGE  // const
  protected static  System.Int32                    MAX_UPLOAD_SIZE_PER_LOOP  // const
  protected static  System.Int32                    MAX_UPLOAD_SIZE_PER_LOOP_LARGE  // const
  protected static  System.Single                   TICK_INTERVAL  // const
  protected static  System.Int32                    TICK_UPLOAD_INTERVAL  // const
  protected static  System.Single                   CREATE_TIME_SMALL_DROP  // const
  protected static  Beyond.Rendering.PsoCreateUploadHelpers_instance  // static @ 0x0
  public    static  System.Int32                    s_enabled  // static @ 0x8
  protected static  System.Int32                    s_tickCount  // static @ 0xc
  public    static  System.Boolean                  s_skipUploadFile  // static @ 0x10
  public    static  System.Boolean                  s_isShaderWarming  // static @ 0x11
  public    static  System.Boolean                  s_enableTimeLimit  // static @ 0x12
  private   static  System.String                   s_persistentDataPath  // static @ 0x18
  private   static  System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<System.String,System.Single,System.Int32,System.Boolean,System.String>>s_concurrentQueue  // static @ 0x20
  private           System.Int32                    m_timerId  // 0x10
  private   static  System.String                   URL  // const
  private   static  System.String                   TOKEN  // const
  private   static  System.Threading.SynchronizationContexts_mainSyncContext  // static @ 0x28
  private   static  System.Int32                    s_mainThreadId  // static @ 0x30
PROPERTIES:
  instance  get=0x02C35AD0
  persistentDataPath  get=0x0268B5D0
METHODS:
  RVA=0x03B2DAE0  token=0x60001DA  System.Void .cctor()
  RVA=0x038216F0  token=0x60001DC  System.Void Initialize()
  RVA=0x026898B0  token=0x60001DD  System.Void Init()
  RVA=0x0319A020  token=0x60001DE  System.Void _SceneLoadStartHandler(Beyond.EventData<System.String,System.String>& args)
  RVA=0x093D5070  token=0x60001DF  System.Void Dispose()
  RVA=0x0319AB20  token=0x60001E0  System.Boolean IsPsoRecordEnabled()
  RVA=0x093D4FE4  token=0x60001E1  System.Void BeforeWarmUpBegin()
  RVA=0x093D4F4C  token=0x60001E2  System.Void AfterWarmUpFinish()
  RVA=0x0319A9C0  token=0x60001E3  System.Void _Tick()
  RVA=0x0323EF10  token=0x60001E4  System.Void _PsoUploadProcessOneCallBack(System.String infoJson, UnityEngine.HGPsoExtInfo info)
  RVA=0x0328F6E0  token=0x60001E5  System.String _PsoUpdateGameInfoCallBack()
  RVA=0x0319AAE0  token=0x60001E6  System.Void _UploadPipelineCreatedInfo(System.Boolean timeLimit)
  RVA=0x0319B760  token=0x60001E7  System.Void _CreateAndUploadFinalJson(System.Boolean timeLimit)
  RVA=0x093D5234  token=0x60001E8  System.Void _CreateAndUploadFileToServer(System.String path, System.String serverFileName, Beyond.Rendering.PsoCreateUploadHelper.PsoInfoWrapper psoInfoWrapper)
  RVA=0x093D57E0  token=0x60001E9  System.Void _UploadFile(System.String urlPath, System.String rawFilePath, System.String serverFileNameOverride, System.Action<System.Boolean,System.String,System.String> callback)
  RVA=0x093D56B8  token=0x60001EA  System.Void _UploadFileToServer(System.String urlPath, System.String rawFilePath, System.String serverFileNameOverride, System.Action<System.Boolean,System.String,System.String> callback)
  RVA=0x093D51CC  token=0x60001EB  System.Void _Callback(System.Boolean success, System.String msg, System.String url)
  RVA=0x0350B670  token=0x60001EC  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.VFXSludgeBaker
TYPE:  class
TOKEN: 0x2000074
SIZE:  0xB8
FIELDS:
  public            UnityEngine.Splines.SplineContainersplineContainer  // 0x10
  public            UnityEngine.Transform           rootTransform  // 0x18
  public            System.Single                   thickness  // 0x20
  public            System.Single                   density  // 0x24
  public            System.Single                   maxHeight  // 0x28
  public            System.Single                   blurIntensity  // 0x2c
  public            System.Single                   gridHeightOffset  // 0x30
  public            System.Single                   topLimit  // 0x34
  public            System.Single                   bottomLimit  // 0x38
  public            UnityEngine.Texture2D           bakedTexture1  // 0x40
  public            UnityEngine.Bounds              localBounds  // 0x48
  public            System.Single                   maxHighPowerZoneSignedDistance  // 0x60
  public            System.Single                   maxEdgeToHighPowerZoneSignedDistance  // 0x64
  private           System.Collections.Generic.List<UnityEngine.Vector3>m_localPolygon  // 0x68
  private           System.Int32                    m_xCount  // 0x70
  private           System.Int32                    m_zCount  // 0x74
  private           System.Single[,]                m_raycastHeights  // 0x78
  private           System.Single[,]                m_topHeights  // 0x80
  private           UnityEngine.Vector3[,]          m_normals  // 0x88
  private           System.Single[,]                m_edgeSignedDistance  // 0x90
  private           System.Single[,]                m_highPowerZoneSignedDistance  // 0x98
  private           System.Boolean[,]               m_inPolygon  // 0xa0
  private           System.Boolean[,]               m_inHighPowerZone  // 0xa8
  private   static  System.Single                   EXTEND_SIZE  // const
  public            System.Single                   rayCastPosY  // 0xb0
METHODS:
  RVA=0x093DD3B4  token=0x60001FA  System.Void .ctor(UnityEngine.Splines.SplineContainer splineContainer, UnityEngine.Transform target, System.Single density, System.Single thickness, System.Single maxHeight, System.Single blurIntensity, System.Single gridHeightOffset)
  RVA=0x093DA21C  token=0x60001FB  System.Void Bake()
  RVA=0x093DB8AC  token=0x60001FC  System.Void _CalculatePolygonAndBounds()
  RVA=0x093DA2B4  token=0x60001FD  UnityEngine.Vector2Int GetLocalIndex(UnityEngine.Vector3 localPosition)
  RVA=0x093DA398  token=0x60001FE  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Vector2Int index)
  RVA=0x093DCB68  token=0x60001FF  System.Void _RaycastSceneObjectsHeight()
  RVA=0x093DB360  token=0x6000200  System.Void _CalculateInPolygon()
  RVA=0x093DAF40  token=0x6000201  System.Void _CalculateInHighPowerZone()
  RVA=0x093DC348  token=0x6000202  System.Single[] _CreateGaussianKernel(System.Int32 size, System.Single sigma)
  RVA=0x093DC114  token=0x6000203  System.Single[,] _Convolution(System.Single[,] src, System.Single[] kernel, UnityEngine.Vector2Int offsetDir)
  RVA=0x093DA4BC  token=0x6000204  System.Void _BlurTopHeight()
  RVA=0x093DBC1C  token=0x6000205  System.Void _CalculateThicknessAndTopHeight()
  RVA=0x093DB584  token=0x6000206  System.Void _CalculateNormals()
  RVA=0x093DC640  token=0x6000207  System.Void _ForAround(System.Int32 ix, System.Int32 iz, System.Int32 xCount, System.Int32 zCount, System.Action<System.Int32,System.Int32> callback)
  RVA=0x093DC7A8  token=0x6000208  System.Int32 _GetHash(System.Int32 ix, System.Int32 iz)
  RVA=0x093DC73C  token=0x6000209  System.Int32 _GetHash(System.Int32 ix, System.Int32 iz, System.Int32 xCount)
  RVA=0x093DA6A8  token=0x600020A  System.Void _CalculateEdgeSignedDistance(System.Single[,] sdf)
  RVA=0x093DAA60  token=0x600020B  System.Void _CalculateEdgeSignedDistance()
  RVA=0x093DC818  token=0x600020C  UnityEngine.Color _GetTextureColor1(System.Int32 ix, System.Int32 iz)
  RVA=0x093DCA18  token=0x600020D  UnityEngine.Color _GetTextureColor2(System.Int32 ix, System.Int32 iz)
  RVA=0x093DC4AC  token=0x600020E  System.Void _CreateTexture()
END_CLASS

CLASS: Beyond.Rendering.VFXSludgeNavUtils
TYPE:  class
TOKEN: 0x2000077
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000213  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.VFXSludgeUtils
TYPE:  static class
TOKEN: 0x2000081
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x093E1690  token=0x600022A  System.Collections.Generic.List<UnityEngine.Vector3> GetPolygonOffSpline(UnityEngine.Splines.SplineContainer splineContainer, System.Single splitDistance, System.Int32 splineIndex)
  RVA=0x093E1078  token=0x600022B  System.Void GetPolygonOffSplineWithSimplify(UnityEngine.Splines.SplineContainer container, System.Collections.Generic.List<UnityEngine.Vector2>& points, System.Int32 splineIndex, System.Boolean closed, System.Boolean isDebug, System.Boolean isConvexHull)
  RVA=0x093E0CEC  token=0x600022C  System.Collections.Generic.List<UnityEngine.Vector3> GetPolygonOffByPolyLine(System.Collections.Generic.List<UnityEngine.Vector2> polylinePoints, UnityEngine.Transform transform, System.Single splitDistance)
  RVA=0x093E0B30  token=0x600022D  System.Collections.Generic.List<UnityEngine.Vector3> CalculatePointPolygonHorizonRayCross(System.Collections.Generic.List<UnityEngine.Vector3> polygon, UnityEngine.Vector3 point)
END_CLASS

CLASS: Beyond.Rendering.HGTerrain
TYPE:  class
TOKEN: 0x2000082
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x600022E  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.ToggleFunc
TYPE:  sealed class
TOKEN: 0x2000083
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x056E13A4  token=0x600022F  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000230  System.Void Invoke(Beyond.Rendering.HGTerrainHelper terrainHelper)
  RVA=0x0389C3B0  token=0x6000231  System.IAsyncResult BeginInvoke(Beyond.Rendering.HGTerrainHelper terrainHelper, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000232  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Rendering.HGTerrainHelper
TYPE:  class
TOKEN: 0x2000084
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x6000233  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.LODLightmapping.LightmapInfoTransfer
TYPE:  class
TOKEN: 0x2000086
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.MeshRenderer        _lightmappedRenderer  // 0x18
  private           UnityEngine.MeshRenderer        m_currentRenderer  // 0x20
METHODS:
  RVA=0x093DF880  token=0x6000241  System.Void OnEnable()
  RVA=0x093DF7E8  token=0x6000242  System.Void Awake()
  RVA=0x093DF8D0  token=0x6000243  System.Void _RendererInfoTransfer()
  RVA=0x0426FE60  token=0x6000244  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.LODLightmapping.LodLightmappingMode
TYPE:  sealed struct
TOKEN: 0x2000087
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Rendering.LODLightmapping.LodLightmappingModeAllFromLightProbe  // const
  public    static  Beyond.Rendering.LODLightmapping.LodLightmappingModeAllFromLOD0  // const
  public    static  Beyond.Rendering.LODLightmapping.LodLightmappingModeUseDifferentLightmapAreaForLODs  // const
METHODS:
END_CLASS

CLASS: Beyond.Rendering.LODLightmapping.LODLightmapping
TYPE:  class
TOKEN: 0x2000088
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.Rendering.LODLightmapping.LodLightmappingModemode  // 0x18
  public            UnityEngine.Vector4             lightmapScaleOffset  // 0x1c
  public            System.Int32                    lightmapIndex  // 0x2c
METHODS:
  RVA=0x093DF414  token=0x6000245  System.Void RendererInfoTransfer()
  RVA=0x03C94940  token=0x6000246  System.Void .ctor()
END_CLASS

CLASS: Beyond.Rendering.SplineMovingObjects.HGSplineMovingObjects
TYPE:  class
TOKEN: 0x2000085
SIZE:  0x278
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: HG.Rendering.Runtime.IVFXPlayable
FIELDS:
  private           UnityEngine.HyperGryph.SplineObjectsDescdesc  // 0x18
  private           UnityEngine.HyperGryph.SplineObjectsKnotData[]knotData  // 0x258
  private           System.Boolean                  fixedPostion  // 0x260
  private           System.Boolean                  optimizeCurve  // 0x261
  private           System.UInt32                   m_instanceHandle  // 0x264
  private           Unity.Collections.NativeArray<UnityEngine.HyperGryph.SplineObjectsKnotData>m_stonesKnotDataNativeArray  // 0x268
METHODS:
  RVA=0x093DDA7C  token=0x6000234  System.Void _CreateInstance()
  RVA=0x093DDD58  token=0x6000235  System.Void _ExtractSplineData()
  RVA=0x093DDCF0  token=0x6000236  System.Void _DestroyInstance()
  RVA=0x093DDFDC  token=0x6000237  System.Void _Release()
  RVA=0x093DD9C4  token=0x6000238  System.Void Update()
  RVA=0x093DD880  token=0x6000239  System.Void OnEnable()
  RVA=0x093DD680  token=0x600023A  System.Void OnDisable()
  RVA=0x093DD630  token=0x600023B  System.Void OnDestroy()
  RVA=0x093DD6D0  token=0x600023C  System.Void OnDrawGizmosSelected()
  RVA=0x093DD8D0  token=0x600023D  System.Void Pause()
  RVA=0x093DD924  token=0x600023E  System.Void Play()
  RVA=0x093DD974  token=0x600023F  System.Void Stop()
  RVA=0x093DE080  token=0x6000240  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_enableFastPathBuffer  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x6000016  System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity)
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000017  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000018  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  RVA=0x0350B670  token=0x6000019  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600001A  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.ContainerWaterManager
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x170
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static readonly System.Int32                    DISPLACEMENT_TEX  // static @ 0x0
  private   static readonly System.Int32                    DISPLACEMENT_TEX_ST  // static @ 0x4
  private   static readonly System.Int32                    WATER_MENISCUS_WIDTH  // static @ 0x8
  private   static readonly System.Int32                    ICE_POSITION  // static @ 0xc
  public            UnityEngine.Material            waveMaterial  // 0x18
  public            UnityEngine.Texture2D           waveTexture  // 0x20
  public            UnityEngine.Transform           iceBall  // 0x28
  public            UnityEngine.Renderer            liquidRenderer  // 0x30
  private           System.Single[][]               m_waveN  // 0x38
  private           System.Single[][]               m_waveNm1  // 0x40
  private           System.Single[][]               m_waveNp1  // 0x48
  private   readonly System.Single                   m_cylinderRadius  // 0x50
  private           System.Single                   _dx  // 0x54
  private           System.Int32                    m_nx  // 0x58
  private           System.Int32                    m_ny  // 0x5c
  public            System.Single                   CFL  // 0x60
  public            System.Single                   c  // 0x64
  private           System.Single                   m_dt  // 0x68
  private           System.Single                   m_t  // 0x6c
  public            System.Boolean                  reflectiveBoundary  // 0x70
  private           System.Single                   _waveMultiplier  // 0x74
  private           System.Single                   _pulseFrequency  // 0x78
  private           System.Single                   _pulseMagnitude  // 0x7c
  private           System.Single                   _elasticity  // 0x80
  private           System.Single                   _viscosity  // 0x84
  private           System.Single                   _surfaceTension  // 0x88
  private           System.Boolean                  _adaptiveQuality  // 0x8c
  private           System.Single                   _targetFrameTime  // 0x90
  private           System.Single                   m_lastFrameTime  // 0x94
  private           UnityEngine.UI.RawImage         _debugDisplay  // 0x98
  private           System.Int32                    _updateFrequency  // 0xa0
  private           System.Int32                    m_frameCounter  // 0xa4
  private           System.Single                   m_currentYRotationSpeed  // 0xa8
  private           System.Boolean                  m_needsTextureUpdate  // 0xac
  private           UnityEngine.Vector3             m_lastIceBallPosition  // 0xb0
  private           UnityEngine.Quaternion          m_lastIceBallRotation  // 0xbc
  private   readonly System.Single                   m_iceBallRadius  // 0xcc
  private           System.Single                   _rippleUpdateInterval  // 0xd0
  private           System.Single                   _rippleBaseStrength  // 0xd4
  private           System.Single                   _rippleRadius  // 0xd8
  private           System.Single                   _rippleWaveLength  // 0xdc
  private           System.Single                   _rippleSpeed  // 0xe0
  private           System.Single                   _distanceDecayPower  // 0xe4
  private           System.Single                   _meltingUniformity  // 0xe8
  private           System.Single                   _meltingVariation  // 0xec
  private           System.Single                   m_lastRippleUpdateTime  // 0xf0
  private           System.Single                   m_ripplePhase  // 0xf4
  private           System.Single                   _rotationWaveMultiplier  // 0xf8
  private           System.Single                   _rotationSensitivity  // 0xfc
  private           System.Boolean[,]               m_cylinderMask  // 0x100
  private           System.Collections.Generic.List<UnityEngine.Vector2Int>m_activePoints  // 0x108
  private           UnityEngine.Color32[]           m_cachedPixels  // 0x110
  private           System.Single                   _normalMeniscusWidth  // 0x118
  private           System.Single                   _vortexDetectionThreshold  // 0x11c
  private           System.Single                   _vortexTransitionTime  // 0x120
  private           System.Boolean                  m_isVortexActive  // 0x124
  private           System.Single                   m_vortexTransitionProgress  // 0x128
  private           System.Single                   m_lastVortexCheckTime  // 0x12c
  private           System.Single                   m_lastYAxisStopTime  // 0x130
  private           System.Boolean                  m_wasYAxisRotating  // 0x134
  private   readonly System.Single                   m_yAxisStopDelay  // 0x138
  private   static  System.Single                   VORTEX_CHECK_INTERVAL  // const
  private           System.Single                   _movementDistanceThreshold  // 0x13c
  private           System.Single                   _movementRecoveryDelay  // 0x140
  private           System.Boolean                  m_isMovementActive  // 0x144
  private           System.Single                   m_lastMovementStopTime  // 0x148
  private           System.Boolean                  m_wasMoving  // 0x14c
  private           System.Single                   m_currentMeniscusWidth  // 0x150
  private           System.Boolean                  m_isMeniscusTransitioning  // 0x154
  private           System.Single                   m_meniscusTransitionStartTime  // 0x158
  private           System.Single                   m_meniscusTransitionStartValue  // 0x15c
  private           UnityEngine.Vector2Int          m_tempTexturePos  // 0x160
  private           UnityEngine.Vector2Int          m_tempNearestPoint  // 0x168
PROPERTIES:
  dy  get=0x03D4F670
METHODS:
  RVA=0x093C5D70  token=0x6000004  System.Void Start()
  RVA=0x093C68A4  token=0x6000005  System.Void _InitializeWaveSystem()
  RVA=0x093C6E78  token=0x6000006  System.Void _PrecomputeCylinderMask()
  RVA=0x093C70A8  token=0x6000007  System.Void _UnifiedWaveStep(System.Boolean isEditorUpdate)
  RVA=0x093C8CD4  token=0x6000008  System.Boolean _WorldToTextureCoords(UnityEngine.Vector3 worldPos, UnityEngine.Vector2Int& texturePos)
  RVA=0x093C6D68  token=0x6000009  System.Boolean _IsInsideCylinder(System.Int32 i, System.Int32 j)
  RVA=0x093C6DFC  token=0x600000A  System.Boolean _IsValidPosition(System.Int32 x, System.Int32 y)
  RVA=0x093C6224  token=0x600000B  System.Void _ApplyMatrixToTexture(System.Single[][] state, UnityEngine.Texture2D& tex, System.Single waveMultiplier)
  RVA=0x093C6688  token=0x600000C  System.Void _ApplyReflectiveBoundary()
  RVA=0x093C60D0  token=0x600000D  System.Void _ApplyAbsorptiveBoundary()
  RVA=0x093C673C  token=0x600000E  UnityEngine.Vector2Int _FindNearestInsidePoint(System.Int32 x, System.Int32 y)
  RVA=0x093C8934  token=0x600000F  System.Void _UpdateVortexState(System.Boolean isEditorUpdate)
  RVA=0x093C5BC8  token=0x6000010  System.Void ResetWaveTexture()
  RVA=0x093C5DF0  token=0x6000011  System.Void Update()
  RVA=0x093C8E88  token=0x6000012  System.Void .ctor()
  RVA=0x093C8DB8  token=0x6000013  System.Void .cctor()
END_CLASS

CLASS: HG.Rendering.Runtime.VFXLockTransform
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x6000014  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000015  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200008B
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x6000247  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x04274234  token=0x6000248  System.Void __Gen_Wrap_0(System.Object P0)
  RVA=0x055FF73C  token=0x6000249  System.Boolean __Gen_Wrap_1(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x093DEADC  token=0x600024A  UnityEngine.Vector2Int __Gen_Wrap_2(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x093DEBF0  token=0x600024B  System.Boolean __Gen_Wrap_3(System.Object P0, UnityEngine.Vector3 P1, UnityEngine.Vector2Int& P2)
  RVA=0x05477860  token=0x600024C  System.Void __Gen_Wrap_4(System.Object P0, System.Boolean P1)
  RVA=0x093DED70  token=0x600024D  System.Void __Gen_Wrap_5(System.Object P0, System.Object P1, UnityEngine.Texture2D& P2, System.Single P3)
  RVA=0x050F0008  token=0x600024E  System.Void __Gen_Wrap_6(System.Object P0, System.Single P1)
  RVA=0x0549D548  token=0x600024F  System.Void __Gen_Wrap_7(System.Object P0, System.Int32 P1)
  RVA=0x093DEEB0  token=0x6000250  System.Void __Gen_Wrap_8(System.Object P0, UnityEngine.Vector4 P1, UnityEngine.Vector4 P2)
  RVA=0x093DEFE4  token=0x6000251  System.Void __Gen_Wrap_9(System.Object P0, UnityEngine.Vector4 P1)
  RVA=0x054A1120  token=0x6000252  System.Void __Gen_Wrap_10(System.Object P0, System.Single P1, System.Single P2)
  RVA=0x093DE284  token=0x6000253  System.String __Gen_Wrap_11(System.Object P0)
  RVA=0x050F3444  token=0x6000254  System.Void __Gen_Wrap_12()
  RVA=0x093DE374  token=0x6000255  System.String __Gen_Wrap_13(Beyond.Resource.RootCategory P0)
  RVA=0x093DE450  token=0x6000256  System.String __Gen_Wrap_14(Beyond.Resource.RootCategory P0, System.Boolean P1)
  RVA=0x093DE548  token=0x6000257  System.String __Gen_Wrap_15()
  RVA=0x093DE614  token=0x6000258  System.String __Gen_Wrap_16(UnityEngine.RuntimePlatform P0, UnityEngine.Rendering.GraphicsDeviceType P1, System.Int32 P2, System.Object P3)
  RVA=0x093DE738  token=0x6000259  System.String __Gen_Wrap_17(UnityEngine.RuntimePlatform P0, UnityEngine.Rendering.GraphicsDeviceType P1, System.Int32 P2, System.Object P3, System.Object P4)
  RVA=0x0516C778  token=0x600025A  System.Int64 __Gen_Wrap_18()
  RVA=0x093DE86C  token=0x600025B  System.Boolean __Gen_Wrap_19(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5)
  RVA=0x093DE9A4  token=0x600025C  System.Boolean __Gen_Wrap_20(System.Object P0, System.String& P1)
  RVA=0x0225F050  token=0x600025D  System.Boolean __Gen_Wrap_21(System.Object P0)
  RVA=0x01414CE0  token=0x600025E  System.Void __Gen_Wrap_22(Beyond.Rendering.ShaderWarmupManager.WarmUpReason P0)
  RVA=0x0225F310  token=0x600025F  System.String __Gen_Wrap_23(System.IntPtr P0, Beyond.Rendering.WindowsGpuDriverVersion.SP_DEVINFO_DATA& P1, System.UInt32 P2)
  RVA=0x02260230  token=0x6000260  System.Boolean __Gen_Wrap_24(System.Object P0, System.Object P1)
  RVA=0x011E6540  token=0x6000261  System.Int32 __Gen_Wrap_25(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x022605F0  token=0x6000262  System.String __Gen_Wrap_26(System.Object P0, System.Object P1)
  RVA=0x0131C100  token=0x6000263  System.Int32 __Gen_Wrap_27(Beyond.Rendering.WindowsGpuDriverVersion.Result P0, Beyond.Rendering.WindowsGpuDriverVersion.Result P1)
  RVA=0x02261020  token=0x6000264  System.Collections.Generic.List<Beyond.Rendering.WindowsGpuDriverVersion.Result> __Gen_Wrap_28()
  RVA=0x02261860  token=0x6000265  System.Boolean __Gen_Wrap_29()
  RVA=0x017AB0B0  token=0x6000266  System.Void __Gen_Wrap_30(System.Int32 P0)
  RVA=0x02261A20  token=0x6000267  Beyond.Rendering.WindowsGpuDriverVersion.Result __Gen_Wrap_31()
  RVA=0x02262260  token=0x6000268  System.Boolean __Gen_Wrap_32(System.Object P0, System.Object P1, System.String& P2)
  RVA=0x02262DA0  token=0x6000269  System.Collections.IEnumerator __Gen_Wrap_33(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x010E9170  token=0x600026A  System.Int32 __Gen_Wrap_34()
  RVA=0x022638A0  token=0x600026B  System.Void __Gen_Wrap_35(System.Int32 P0, System.Int32& P1)
  RVA=0x02263AD0  token=0x600026C  System.Collections.IEnumerator __Gen_Wrap_36(System.Object P0, System.Int32 P1, System.Int32 P2, System.Object P3)
  RVA=0x02264520  token=0x600026D  System.Collections.IEnumerator __Gen_Wrap_37(System.Boolean P0)
  RVA=0x02264DA0  token=0x600026E  System.Collections.IEnumerator __Gen_Wrap_38(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x02265710  token=0x600026F  System.Collections.IEnumerator __Gen_Wrap_39(System.Object P0)
  RVA=0x02266040  token=0x6000270  System.Boolean __Gen_Wrap_40(Beyond.Rendering.SceneStateAreaKey& P0, Beyond.Rendering.SceneStateAreaKey P1)
  RVA=0x02266CE0  token=0x6000271  System.Boolean __Gen_Wrap_41(Beyond.Rendering.SceneStateAreaKey& P0, System.Object P1)
  RVA=0x02267980  token=0x6000272  System.Int32 __Gen_Wrap_42(Beyond.Rendering.SceneStateAreaKey& P0)
  RVA=0x02268530  token=0x6000273  System.Single __Gen_Wrap_43(System.Object P0)
  RVA=0x022687F0  token=0x6000274  System.Boolean __Gen_Wrap_44(System.Object P0, System.Boolean P1)
  RVA=0x02268AE0  token=0x6000275  System.Boolean __Gen_Wrap_45(System.Object P0, System.Single P1, System.Int32 P2)
  RVA=0x02268E00  token=0x6000276  System.Collections.Generic.Dictionary<System.Int32,System.Single> __Gen_Wrap_46(System.Object P0)
  RVA=0x02269740  token=0x6000277  System.Void __Gen_Wrap_47(System.Object P0, System.Object P1)
  RVA=0x02269AF0  token=0x6000278  Beyond.Rendering.EntityRenderCapturedEntity __Gen_Wrap_48(System.Object P0, System.Object P1)
  RVA=0x01367D80  token=0x6000279  System.Int32 __Gen_Wrap_49(System.Object P0, System.Object P1)
  RVA=0x0121B9D0  token=0x600027A  Beyond.Rendering.EntityVFXRendererMask __Gen_Wrap_50(Beyond.Rendering.EntityVFXRendererType P0)
  RVA=0x0226A510  token=0x600027B  System.Void __Gen_Wrap_51(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x0226A9A0  token=0x600027C  System.Void __Gen_Wrap_52(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  RVA=0x0226AF10  token=0x600027D  UnityEngine.Material __Gen_Wrap_53(System.Object P0, Beyond.Rendering.EntityRenderHelperMaterialController.AddedMaterialInfo P1, System.Object P2)
  RVA=0x0226BCE0  token=0x600027E  UnityEngine.Texture __Gen_Wrap_54(System.Object P0, System.Object P1)
  RVA=0x0226C710  token=0x600027F  System.Int32 __Gen_Wrap_55(System.Object P0, System.Object P1, Beyond.Rendering.EntityVFXRendererMask P2, Beyond.Rendering.AddMaterialConfig P3)
  RVA=0x0226CEE0  token=0x6000280  System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> __Gen_Wrap_56(System.Object P0, Beyond.Rendering.EntityVFXRendererMask P1, System.Boolean P2)
  RVA=0x01449B10  token=0x6000281  System.Void __Gen_Wrap_57(System.Object P0, System.Int32 P1, System.Single P2)
  RVA=0x01AD4620  token=0x6000282  System.Single __Gen_Wrap_58(System.Object P0, System.Int32 P1, System.Single P2)
  RVA=0x0226D870  token=0x6000283  System.Void __Gen_Wrap_59(System.Object P0, System.Int32 P1, UnityEngine.Vector4 P2)
  RVA=0x0226DEE0  token=0x6000284  UnityEngine.Vector4 __Gen_Wrap_60(System.Object P0, System.Int32 P1, UnityEngine.Vector4 P2)
  RVA=0x01062520  token=0x6000285  System.Void __Gen_Wrap_61(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x0226EBA0  token=0x6000286  UnityEngine.Texture __Gen_Wrap_62(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x0120E440  token=0x6000287  Beyond.Rendering.EntityVFXRendererMask __Gen_Wrap_63(System.Object P0, System.Int32 P1)
  RVA=0x01470460  token=0x6000288  System.Boolean __Gen_Wrap_64(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x01204510  token=0x6000289  System.Void __Gen_Wrap_65(System.Object P0, System.Int32 P1, Beyond.Rendering.EntityVFXRendererMask P2)
  RVA=0x011C4DD0  token=0x600028A  System.Void __Gen_Wrap_66(System.Object P0, Beyond.Rendering.EntityVFXRendererMask P1, System.Object P2)
  RVA=0x015D2D40  token=0x600028B  System.Void __Gen_Wrap_67(System.Object P0, System.Object P1, System.Boolean P2, Beyond.Rendering.EntityVFXRendererMask P3)
  RVA=0x01A83500  token=0x600028C  System.Void __Gen_Wrap_68(System.Object P0, System.Boolean P1, Beyond.Rendering.EntityVFXRendererMask P2)
  RVA=0x0226F5D0  token=0x600028D  System.Single __Gen_Wrap_69(System.Object P0, System.Single P1, System.Single P2, System.Int32 P3)
  RVA=0x011F7520  token=0x600028E  System.Void __Gen_Wrap_70(System.Object P0, Beyond.Rendering.EntityRenderHelperCustomPerDrawType P1, System.Single P2, Beyond.Rendering.EntityVFXRendererMask P3)
  RVA=0x0226F920  token=0x600028F  System.Void __Gen_Wrap_71(System.Object P0, Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType P1, UnityEngine.Vector4 P2, Beyond.Rendering.EntityVFXRendererMask P3)
  RVA=0x011F7520  token=0x6000290  System.Void __Gen_Wrap_72(System.Object P0, System.Int32 P1, System.Single P2, Beyond.Rendering.EntityVFXRendererMask P3)
  RVA=0x0226FFD0  token=0x6000291  System.Void __Gen_Wrap_73(System.Object P0, System.Int32 P1, UnityEngine.Vector4 P2, Beyond.Rendering.EntityVFXRendererMask P3)
  RVA=0x01542D70  token=0x6000292  System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Object P2, Beyond.Rendering.EntityVFXRendererMask P3)
  RVA=0x022706A0  token=0x6000293  UnityEngine.Bounds __Gen_Wrap_75(System.Object P0)
  RVA=0x0180A7B0  token=0x6000294  System.Void __Gen_Wrap_76(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x0112C230  token=0x6000295  Beyond.Rendering.RenderHelperType __Gen_Wrap_77(System.Object P0)
  RVA=0x02270F90  token=0x6000296  System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> __Gen_Wrap_78(System.Object P0, System.Boolean P1)
  RVA=0x022718F0  token=0x6000297  System.Single __Gen_Wrap_79(System.Object P0, System.Boolean P1)
  RVA=0x0112C230  token=0x6000298  Beyond.Rendering.EntityVFXPriorityType __Gen_Wrap_80(System.Object P0)
  RVA=0x02271BE0  token=0x6000299  System.Void __Gen_Wrap_81(System.Object P0, System.Single P1, System.Boolean P2)
  RVA=0x02271EE0  token=0x600029A  UnityEngine.Material __Gen_Wrap_82(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x011E77F0  token=0x600029B  System.Boolean __Gen_Wrap_83(Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData P0)
  RVA=0x01AB8A20  token=0x600029C  System.Void __Gen_Wrap_84(System.Object P0, System.Object P1, System.Int32 P2, System.Single P3)
  RVA=0x022729E0  token=0x600029D  System.Void __Gen_Wrap_85(System.Object P0, System.Object P1, System.Int32 P2, UnityEngine.Vector4 P3)
  RVA=0x02273140  token=0x600029E  UnityEngine.Material __Gen_Wrap_86(System.Object P0, System.Object P1, UnityEngine.Vector4 P2)
  RVA=0x02273EF0  token=0x600029F  System.ValueTuple<System.Single,System.Single> __Gen_Wrap_87(UnityEngine.Bounds P0, UnityEngine.Vector3 P1)
  RVA=0x02274E50  token=0x60002A0  System.Void __Gen_Wrap_88(System.Object P0, System.Boolean P1, UnityEngine.Vector3 P2, System.Boolean P3, System.Single P4, System.Single& P5, System.Single& P6, UnityEngine.Vector3& P7)
  RVA=0x02275AD0  token=0x60002A1  Beyond.Rendering.EntityVFXCurveEvaluateResult __Gen_Wrap_89(System.Object P0, System.Single P1)
  RVA=0x02276430  token=0x60002A2  System.Void __Gen_Wrap_90(System.Object P0, System.Object P1, System.Single P2)
  RVA=0x02276800  token=0x60002A3  System.Void __Gen_Wrap_91(System.Object P0, System.Single P1, System.Object P2, System.Object P3)
  RVA=0x01061D10  token=0x60002A4  System.Void __Gen_Wrap_92(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3)
  RVA=0x02276C70  token=0x60002A5  System.Void __Gen_Wrap_93(System.Object P0, UnityEngine.HGPsoExtInfo P1)
  RVA=0x022772F0  token=0x60002A6  System.Void __Gen_Wrap_94(System.Boolean P0)
  RVA=0x022774E0  token=0x60002A7  System.Void __Gen_Wrap_95(System.Boolean P0, System.Object P1, System.Object P2)
  RVA=0x02277880  token=0x60002A8  System.Void __Gen_Wrap_96(System.Object P0, Beyond.EventData<System.String,System.String>& P1)
  RVA=0x02277F20  token=0x60002A9  System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_97(System.Object P0, System.Single P1, System.Int32 P2)
  RVA=0x022788A0  token=0x60002AA  UnityEngine.Vector3 __Gen_Wrap_98(System.Object P0, UnityEngine.Vector2Int P1)
  RVA=0x02279530  token=0x60002AB  System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_99(System.Object P0, UnityEngine.Vector3 P1)
  RVA=0x02251B90  token=0x60002AC  UnityEngine.Vector2Int __Gen_Wrap_100(System.Object P0, UnityEngine.Vector3 P1)
  RVA=0x018AAA70  token=0x60002AD  System.Int32 __Gen_Wrap_101(System.Int32 P0, System.Int32 P1, System.Int32 P2)
  RVA=0x0128D790  token=0x60002AE  System.Void __Gen_Wrap_102(System.Int32 P0, System.Int32 P1)
  RVA=0x022527E0  token=0x60002AF  System.Void __Gen_Wrap_103(System.Int32 P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Object P4)
  RVA=0x02252B00  token=0x60002B0  UnityEngine.Color __Gen_Wrap_104(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x02253420  token=0x60002B1  System.Single[] __Gen_Wrap_105(System.Int32 P0, System.Single P1)
  RVA=0x02253CB0  token=0x60002B2  System.Single[,] __Gen_Wrap_106(System.Object P0, System.Object P1, UnityEngine.Vector2Int P2)
  RVA=0x0132E5D0  token=0x60002B3  System.Int32 __Gen_Wrap_107(System.Object P0, System.Int32 P1, System.Int32 P2)
  RVA=0x02254A90  token=0x60002B4  System.Void __Gen_Wrap_108(UnityEngine.Bounds P0, System.Object P1, UnityEngine.Vector3& P2, UnityEngine.Vector3& P3, System.Nullable<UnityEngine.Vector3> P4)
  RVA=0x02255A20  token=0x60002B5  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_109(UnityEngine.Vector3 P0, UnityEngine.Vector3 P1)
  RVA=0x022566C0  token=0x60002B6  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_110(UnityEngine.Vector3 P0, System.Single P1)
  RVA=0x022572A0  token=0x60002B7  System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_111(System.Object P0, System.Single P1, System.Int32 P2, System.Boolean P3, System.Single P4)
  RVA=0x02257C60  token=0x60002B8  UnityEngine.Vector3 __Gen_Wrap_112(Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame& P0, UnityEngine.Vector3 P1)
  RVA=0x02258C00  token=0x60002B9  System.Void __Gen_Wrap_113(System.Object P0, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, System.Collections.Generic.List<UnityEngine.Vector2>& P2, System.Collections.Generic.List<System.Single>& P3, System.Single& P4, System.Single& P5, System.Single& P6, System.Single& P7)
  RVA=0x014F7500  token=0x60002BA  System.Int32 __Gen_Wrap_114(System.Int32 P0, System.Int32 P1)
  RVA=0x02259C80  token=0x60002BB  System.Collections.Generic.List<System.Int32> __Gen_Wrap_115(System.Object P0)
  RVA=0x0225A5B0  token=0x60002BC  System.Single __Gen_Wrap_116(System.Object P0, System.Int32 P1, System.Boolean P2)
  RVA=0x0225A8B0  token=0x60002BD  System.Single __Gen_Wrap_117(UnityEngine.Vector2 P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2)
  RVA=0x0225B050  token=0x60002BE  System.Collections.Generic.List<System.Int32> __Gen_Wrap_118(System.Object P0, System.Boolean P1, System.Single P2, System.Single P3, System.Single P4)
  RVA=0x0225BA50  token=0x60002BF  Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __Gen_Wrap_119(System.Object P0, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, System.Single P2, System.Int32 P3, System.Boolean P4, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, System.Single P6, System.Single P7, System.Single P8)
  RVA=0x0225C720  token=0x60002C0  System.Collections.Generic.List<UnityEngine.Vector2> __Gen_Wrap_120(System.Object P0, System.Single P1, System.Int32 P2, System.Int32 P3, System.Boolean P4, System.Boolean P5)
  RVA=0x0225D100  token=0x60002C1  System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_121(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3)
  RVA=0x0225DAF0  token=0x60002C2  System.Void __Gen_Wrap_122(System.Object P0, System.Collections.Generic.List<UnityEngine.Vector2>& P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  RVA=0x0225E600  token=0x60002C3  System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_123(System.Object P0, System.Object P1, System.Single P2)
  RVA=0x03D05560  token=0x60002C4  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x200008C
SIZE:  0x60
EXTENDS: IFix.Core.AnonymousStorey
IMPLEMENTS: System.IDisposable System.Collections.IEnumerator System.Collections.Generic.IEnumerator`1 System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4c
  private           System.Int32                    methodId_4  // 0x50
  private           System.Int32                    methodId_5  // 0x54
  private           System.Int32                    methodId_6  // 0x58
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x093DF1C8
  System.Collections.IEnumerator.Current  get=0x093DF274
METHODS:
  RVA=0x05152EA8  token=0x60002C5  System.Void System.IDisposable.Dispose()
  RVA=0x05152C48  token=0x60002C6  System.Boolean MoveNext()
  RVA=0x05152D80  token=0x60002C8  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x092AF434  token=0x60002CA  System.Void MoveNext()
  RVA=0x092AF694  token=0x60002CB  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0)
  RVA=0x093DF320  token=0x60002CC  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x093DF13C  token=0x60002CD  System.Void RefAwaitUnsafeOnCompleteMethod()
  RVA=0x093DF0F8  token=0x60002CE  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60002CF  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x093E1AC0  token=0x60002D0  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x027182E0  token=0x60002D1  System.Boolean IsPatched(System.Int32 id)
  RVA=0x093E197C  token=0x60002D2  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x093E1A48  token=0x60002D3  System.Object CreateWrapper(System.Int32 id)
  RVA=0x093E1B24  token=0x60002D4  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x093E18D8  token=0x60002D5  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x200008E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_PrecomputeCylinderMask0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_InitializeWaveSystem0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-Start0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_IsInsideCylinder0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_ApplyReflectiveBoundary0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_FindNearestInsidePoint0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_ApplyAbsorptiveBoundary0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_WorldToTextureCoords0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_IsValidPosition0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_UnifiedWaveStep0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_ApplyMatrixToTexture0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-_UpdateVortexState0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-ResetWaveTexture0  // const
  public    static  IFix.IDMAP0                     HG-Rendering-Runtime-ContainerWaterManager-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_LitDissolve0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_HoudiniVAT0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_MovingBamboo0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveAlbedoColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepLightIntensity0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_UVAnimation0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_CharacterParams0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_VFXAlpha00  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PipelineSettingHelper-_GetFullSettingPath0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PipelineSettingHelper-_LoadSetting0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PipelineSettingHelper-LoadPipelineSettings0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ResourceRouter-_GetCategoryFolder0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ResourceRouter-GetEnvironmentsFullPath0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ResourceRouter-GetDecalResourcesPath0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ResourceRouter-GetDecalResourcesFullPath0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-GetPsoName0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-GetPsoName1  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-GetPsoPath0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_GetCacheFileSize0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-GetLoginWarmupDetail0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManagerRemoteCfg-_CheckDeviceMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsDeviceInBlackList0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsEnableDx11DriverVersionDetect0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-ProcessRemoteConfig0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-MarkNeedShaderWarmUp0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_MarkWarmupFinishAPI0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_MarkWarmUpLoginFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-_GetDeviceRegistryPropertyString0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-_ContainsIgnoreCase0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-_ScoreAgainstUnityCurrentGpu0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-_GetDriverKeySuffix0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-_ReadRegistrySz0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-GetAllDisplayDriverVersions0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllResults0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_MarkWarmupDx11Driver0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-MarkWarmUpLoginFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-CleanLoadedPso0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_ResetWarmUpStats0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportWarmUp0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByFirstEntry0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByGraphicsChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_SetWarmupRetryCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_SetWarmupUnfinishedCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_CheckWarmUpUnfinishedOften0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-GetBestMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-_TryGetDriverVersionByKeyId0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-IsBestMatchDriverVersionChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupDx11Driver0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByCacheOutdated0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByDeviceState0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-CheckNeedWarmUpLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_LoadPsoAssets0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_GetLoginTimeLimit0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-IsPsoRecordEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-BeforeWarmUpBegin0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_StepProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-AfterWarmUpFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoTimeLimited0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-WarmupShadersLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-WarmupOnePso0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-WarmupShadersScene0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Begin0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-GetCurrentDriverVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllCurrentResults0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-Result-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-WindowsGpuDriverVersion-SafeRegistryHandle-ReleaseHandle0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SceneStateAreaKey-Equals0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SceneStateAreaKey-Equals1  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SceneStateAreaKey-GetHashCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-_GetCurMinAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-_ApplyNewAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-ResetDitherAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-SetDitherAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-GetDitherAlpha0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderAlphaDitherController-GetAlphaDictionary0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderCaptureMeshController-Release0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderCaptureMeshController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderCaptureMeshController-_SyncTransformInRenderPipeline0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderCaptureMeshController-LateTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderCaptureMeshController-Capture0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-_GetSubMeshCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXUtils-ToMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_GetCustomizePropertyMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-ApplySharedMaterialArray0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReplaceSharedMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReleaseAllReplaceMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-IsAllRendererValid0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-StopShadowCasting0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-RevertShadowCastingMode0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityCustomizeRendererPropertyConfig-GetColorTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_InitCustomizeRendererProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireAddMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-_GetRenderersOfRendererMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddMaterialToAllRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveFloatProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveFloatProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveFloatProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveFloatProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveVectorProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveVectorProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveVectorProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveVectorProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveTextureProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveTextureProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveTextureProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveTextureProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireRemoveMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-RemoveMaterialFromAllRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddedMaterialsOfCustomizeProperties0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-GetAddedMaterialsOfCustomizeProperties0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-CopyFrom0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CopyReplaceMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_SplitRenderers0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_GetAffectGroupData0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CreateReplaceMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetKeywordEnableToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetKeywordEnableToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetDepthOnlyPassEnableToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetDepthOnlyPassEnableToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-_PackUNorm8ToFloat0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetFloatToCustomPerDraw0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToCustomPerDraw0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetVectorToCustomPerDraw0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToCustomPerDraw0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetFloatToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetVectorToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetTextureToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetTextureToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherAlphaValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-GetRendererBounds0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetZTestInMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-SetZTestInMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-GetRenderHelperType0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseFloatToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseVectorToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseTextureToAllMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-_InitDictionary0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-Release0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-get_rendererName0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByNameContainsStr0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByNameContainsStr0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderHelperVisibleController-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-SetFloat0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-SetTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-SetVector0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-AddMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-_RevertMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-RemoveMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-ClearMaterials0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-SetKeywordEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-SetDepthOnlyEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityRenderMaterialManager-SetZTestInMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXAsset-GetRendererTypeConfigs0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXAssetBase-get_assetName0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-SetOwner0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-InitLOD0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-SetName0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Destroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Stop0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Replay0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-RefreshLastTickTime0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-GetDeltaTimeFromLastTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-GetPriorityType0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-GetNeedTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-OnHide0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Hide0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-OnShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Show0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-OnSample0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerBase-Sample0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-Replay0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-_FinalStop0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-Stop0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-GetNeedTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXControllerStateBase-OnSample0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_AddVATMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetVATMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetAddedMaterialIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_RemoveVATMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-AddMaterialToAllRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-RemoveMaterialFromAllRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetFloatToFactoryMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetVectorToFactoryMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryMaterialCache-GetVATMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXFactoryMaterialCache-ReleaseVATMaterial0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXUtils-GetBoundsMinMaxOfDirection0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXUtils-CalculateCutOffBounds0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXUtils-Evaluate0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXUtils-_UpdateCurve0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-EntityVFXUtils-ApplyEntityVFXCurves0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-get_PropertySetterType0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-_ClearTimer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-_UpdateProperty0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-_CreateTimer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-_NextPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-_DoPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-CommonVAT-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_InitRenderer_MeshRender0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_InitRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer_MeshRender0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-Reset0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_SetParamsToRenderer_MeshRender0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_SetParamsToRenderer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_DoPlay0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-_UpdateAnim0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-OnUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-FactoryVAT-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VATRendererPropertySetter-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VATRendererPropertySetter-SetFloat0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VATRendererPropertySetter-SetVector0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VATEntityRendererHelperPropertySetter-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetFloat0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetVector0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_PsoUploadProcessOneCallBack0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_PsoUpdateGameInfoCallBack0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-Initialize0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_UploadPipelineCreatedInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_Callback0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_UploadFileToServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFileToServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFinalJson0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_SceneLoadStartHandler0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-PsoCreateUploadHelper-_UploadFile0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSpline0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculatePolygonAndBounds0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-GetLocalPosition0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_RaycastSceneObjectsHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeUtils-CalculatePointPolygonHorizonRayCross0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-GetLocalIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculateInPolygon0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculateInHighPowerZone0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_GetHash0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_ForAround0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance1  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_BlurTopHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculateThicknessAndTopHeight0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CalculateNormals0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_GetTextureColor10  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CreateTexture0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-Bake0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_CreateGaussianKernel0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_Convolution0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_GetHash1  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeBaker-_GetTextureColor20  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-BoundsUtil-GetTopBottomPoints0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameFromPlaneNormal0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameByYaw0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-SampleUniformByArcLength0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-WorldToFrame0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ProjectWorldToFrameXZ0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ConvexHullIndices0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_AngleDegAt0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_CurvatureAt0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_PointToSegmentDistance2D0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Simplify2D_ByCurvatureAngleDeviation0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Process0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-FrameToWorld0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-SplineSamplingUtils-SampleByArcLength0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeNavUtils-PolySimplify-SimplifyByAngle0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSplineWithSimplify0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-VFXSludgeUtils-GetPolygonOffByPolyLine0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_CreateInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_ExtractSplineData0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_DestroyInstance0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_Release0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDrawGizmosSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Pause0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Play0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Stop0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-_RendererInfoTransfer0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Rendering-LODLightmapping-LODLightmapping-RendererInfoTransfer0  // const
METHODS:
END_CLASS

