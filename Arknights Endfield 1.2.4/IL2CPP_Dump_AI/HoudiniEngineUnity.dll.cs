// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.dll
// Classes:  439
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

CLASS: <>f__AnonymousType0`2
TYPE:  sealed class
TOKEN: 0x2000002
FIELDS:
  private   readonly <owner>j__TPar                  <owner>i__Field  // 0x0
  private   readonly <houdiniVersionRequired>j__TPar <houdiniVersionRequired>i__Field  // 0x0
PROPERTIES:
  owner  get=-1  // not resolved
  houdiniVersionRequired  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000003  System.Void .ctor(<owner>j__TPar owner, <houdiniVersionRequired>j__TPar houdiniVersionRequired)
  RVA=-1  // not resolved  token=0x6000004  System.Boolean Equals(System.Object value)
  RVA=-1  // not resolved  token=0x6000005  System.Int32 GetHashCode()
  RVA=-1  // not resolved  token=0x6000006  System.String ToString()
END_CLASS

CLASS: HEU_BoundingVolume
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
PROPERTIES:
  BoundingCollider  get=0x087D35D8
METHODS:
  RVA=0x087D33A0  token=0x6000008  System.Collections.Generic.List<UnityEngine.GameObject> GetAllIntersectingObjects()
  RVA=0x0426FE60  token=0x6000009  System.Void .ctor()
END_CLASS

CLASS: HEU_ExampleEvergreenQuery
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x087D899C  token=0x600000A  System.Void StartQuery()
  RVA=0x087D8694  token=0x600000B  HoudiniEngineUnity.HEU_HoudiniAsset QueryHoudiniAsset(UnityEngine.GameObject rootGO)
  RVA=0x087D836C  token=0x600000C  System.Void CookAsset(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset)
  RVA=0x087D7FFC  token=0x600000D  System.Void ChangeParmsAndCook(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset)
  RVA=0x087D8810  token=0x600000E  System.Void QueryObjects(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset)
  RVA=0x087D85D0  token=0x600000F  System.Void QueryGeoParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo)
  RVA=0x087D888C  token=0x6000010  System.Void QueryPartAttributeByOwner(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.Int32 count, System.Text.StringBuilder sb)
  RVA=0x087D8380  token=0x6000011  System.Void QueryAttributeByStorageType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String attrName)
  RVA=0x087D8504  token=0x6000012  System.Void QueryAttribute(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.String objName, System.String geoName, System.Int32 partID, System.String attrName)
  RVA=0x0350B670  token=0x6000013  System.Void .ctor()
END_CLASS

CLASS: HEU_ExampleInstanceCustomAttribute
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x087D8B7C  token=0x6000014  System.Void InstancerCallback()
  RVA=-1  // generic def  token=0x6000015  System.Void LogArray(System.String name, T[] arr, System.Int32 tupleSize)
  RVA=0x087D8EFC  token=0x6000016  System.Void LogAttr(HoudiniEngineUnity.HEU_OutputAttribute outAttr)
  RVA=0x0426FE60  token=0x6000017  System.Void .ctor()
END_CLASS

CLASS: HEU_ScriptCallbackExample
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.String                   _msg  // 0x18
METHODS:
  RVA=0x087EF628  token=0x6000018  System.Void AssetCallbackWithMsg(System.String msg)
  RVA=0x087EF5D4  token=0x6000019  System.Void AssetCallbackNoMsg()
  RVA=0x0426FE60  token=0x600001A  System.Void .ctor()
END_CLASS

CLASS: OutputMode
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HEU_ScriptMeshInputUVLayoutExample.OutputModeCOPY  // const
  public    static  HEU_ScriptMeshInputUVLayoutExample.OutputModeREPLACE  // const
METHODS:
END_CLASS

CLASS: HEU_ScriptMeshInputUVLayoutExample
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x087EF6AC  token=0x600001B  System.Void ApplyUVLayoutTo(UnityEngine.GameObject[] gameObjects, HEU_ScriptMeshInputUVLayoutExample.OutputMode outputMode, System.String output_name_suffix)
  RVA=0x0350B670  token=0x600001C  System.Void .ctor()
END_CLASS

CLASS: HEU_ScriptParameterExample
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            UnityEngine.GameObject          _evergreenGameObject  // 0x18
  private           HoudiniEngineUnity.HEU_HoudiniAsset_evergreenAsset  // 0x20
  public            System.Single                   _updateRate  // 0x28
  public            System.Single                   _scale  // 0x2c
METHODS:
  RVA=0x087EF80C  token=0x600001D  System.Void .ctor()
END_CLASS

CLASS: HEU_AssetEventReceiverTest
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x087D2334  token=0x600001E  System.Void ReloadCallback(HoudiniEngineUnity.HEU_ReloadEventData Data)
  RVA=0x087D21D0  token=0x600001F  System.Void CookedCallback(HoudiniEngineUnity.HEU_CookedEventData Data)
  RVA=0x087D206C  token=0x6000020  System.Void BakedCallback(HoudiniEngineUnity.HEU_BakedEventData Data)
  RVA=0x0426FE60  token=0x6000021  System.Void .ctor()
END_CLASS

CLASS: CurveEditState
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateINVALID  // const
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateGENERATED  // const
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateEDITING  // const
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateREQUIRES_GENERATION  // const
METHODS:
END_CLASS

CLASS: Interaction
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionVIEW  // const
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionADD  // const
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionEDIT  // const
METHODS:
END_CLASS

CLASS: CurveDrawCollision
TYPE:  sealed struct
TOKEN: 0x2000027
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Curve.CurveDrawCollisionCOLLIDERS  // const
  public    static  HoudiniEngineUnity.HEU_Curve.CurveDrawCollisionLAYERMASK  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass59_0
TYPE:  sealed class
TOKEN: 0x2000028
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector3>points  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000A0  System.Void .ctor()
  RVA=0x087EFCB4  token=0x60000A1  System.Void <GetAllPoints>b__0(HoudiniEngineUnity.CurveNodeData transform)
END_CLASS

CLASS: <>c__DisplayClass86_0
TYPE:  sealed class
TOKEN: 0x2000029
SIZE:  0x40
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector3>positions  // 0x10
  public            System.Boolean                  hasRotations  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Quaternion>rotations  // 0x20
  public            System.Boolean                  hasScales  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Vector3>scales  // 0x30
  public            System.Collections.Generic.List<System.Int32>curveCountIndices  // 0x38
METHODS:
  RVA=0x0350B670  token=0x60000A2  System.Void .ctor()
  RVA=0x087EFD24  token=0x60000A3  System.Void <UpdateCurveInputForCurveParts>b__0(HoudiniEngineUnity.CurveNodeData data)
END_CLASS

CLASS: <>c__DisplayClass87_0
TYPE:  sealed class
TOKEN: 0x200002A
SIZE:  0x28
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector3>positions  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Quaternion>rotations  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Vector3>scales  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60000A4  System.Void .ctor()
  RVA=0x087EFE44  token=0x60000A5  System.Void <UpdateCurveInputForCustomAttributes>b__0(HoudiniEngineUnity.CurveNodeData data)
  RVA=0x087EFF34  token=0x60000A6  System.Void <UpdateCurveInputForCustomAttributes>b__1(System.Int32 nIndex1, System.Int32 nIndex2, System.Single fCoeff, System.Int32 nInsertIndex)
  RVA=0x087F0224  token=0x60000A7  System.Void <UpdateCurveInputForCustomAttributes>b__2(System.Int32 nIndex, System.Int32 nInsertIndex)
END_CLASS

CLASS: <>c__DisplayClass89_0
TYPE:  sealed class
TOKEN: 0x200002B
SIZE:  0x20
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Vector3>rotations  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Vector3>scales  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60000A8  System.Void .ctor()
  RVA=0x087F041C  token=0x60000A9  System.Void <UpdatePoints>b__0(HoudiniEngineUnity.CurveNodeData data)
END_CLASS

CLASS: HEU_AssetType
TYPE:  sealed struct
TOKEN: 0x2000030
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_HDA  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_CURVE  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_INPUT  // const
METHODS:
END_CLASS

CLASS: AssetBuildAction
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionNONE  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionRELOAD  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionCOOK  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionINVALID  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionSTRIP_HEDATA  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionDUPLICATE  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionRESET_PARAMS  // const
METHODS:
END_CLASS

CLASS: AssetCookStatus
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusNONE  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusCOOKING  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusPOSTCOOK  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusLOADING  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusPOSTLOAD  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusPRELOAD  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusSELECT_SUBASSET  // const
METHODS:
END_CLASS

CLASS: AssetCookResult
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResultNONE  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResultSUCCESS  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResultERRORED  // const
METHODS:
END_CLASS

CLASS: UpdateUIDelegate
TYPE:  sealed class
TOKEN: 0x2000034
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x6000206  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x6000207  System.Void Invoke()
  RVA=0x042BE018  token=0x6000208  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000209  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AssetInstantiationMethod
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethodDEFAULT  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethodDUPLICATED  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethodUNDO  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass266_0
TYPE:  sealed class
TOKEN: 0x2000036
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.TransformData>previousTransformValues  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600020A  System.Void .ctor()
  RVA=0x08804A94  token=0x600020B  System.Void <BakeToExistingPrefab>b__0(UnityEngine.Transform trans)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000037
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.HEU_HoudiniAsset.<>c<>9  // static @ 0x0
  public    static  System.Func<HoudiniEngineUnity.HEU_InputNode,System.Boolean><>9__278_0  // static @ 0x8
  public    static  System.Func<HoudiniEngineUnity.HEU_ObjectNode,System.Boolean><>9__316_0  // static @ 0x10
  public    static  System.Func<HoudiniEngineUnity.HEU_Curve,System.Boolean><>9__339_0  // static @ 0x18
  public    static  System.Func<HoudiniEngineUnity.HEU_AttributesStore,System.Boolean><>9__340_0  // static @ 0x20
  public    static  System.Func<HoudiniEngineUnity.HEU_Curve,System.Boolean><>9__377_0  // static @ 0x28
  public    static  System.Func<HoudiniEngineUnity.HEU_ObjectNode,System.Boolean><>9__408_0  // static @ 0x30
  public    static  System.Func<HoudiniEngineUnity.HEU_Curve,System.Boolean><>9__408_1  // static @ 0x38
  public    static  System.Func<HoudiniEngineUnity.HEU_MaterialData,System.Boolean><>9__408_2  // static @ 0x40
METHODS:
  RVA=0x08804E58  token=0x600020C  System.Void .cctor()
  RVA=0x0350B670  token=0x600020D  System.Void .ctor()
  RVA=0x088049B0  token=0x600020E  System.Boolean <GetNonParameterInputNodes>b__278_0(HoudiniEngineUnity.HEU_InputNode node)
  RVA=0x08804964  token=0x600020F  System.Boolean <DoPostCookWork>b__316_0(HoudiniEngineUnity.HEU_ObjectNode obj)
  RVA=0x08804A48  token=0x6000210  System.Boolean <UploadCurvesParameters>b__339_0(HoudiniEngineUnity.HEU_Curve curve)
  RVA=0x088049FC  token=0x6000211  System.Boolean <UploadAttributeValues>b__340_0(HoudiniEngineUnity.HEU_AttributesStore store)
  RVA=0x0880481C  token=0x6000212  System.Boolean <ClearInvalidCurves>b__377_0(HoudiniEngineUnity.HEU_Curve curve)
  RVA=0x08804868  token=0x6000213  System.Boolean <ClearInvalidLists>b__408_0(HoudiniEngineUnity.HEU_ObjectNode node)
  RVA=0x088048B4  token=0x6000214  System.Boolean <ClearInvalidLists>b__408_1(HoudiniEngineUnity.HEU_Curve curve)
  RVA=0x08804900  token=0x6000215  System.Boolean <ClearInvalidLists>b__408_2(HoudiniEngineUnity.HEU_MaterialData data)
END_CLASS

CLASS: <>c__DisplayClass409_0
TYPE:  sealed class
TOKEN: 0x2000038
SIZE:  0x28
FIELDS:
  public            HoudiniEngineUnity.HEU_HoudiniAssetnewAsset  // 0x10
  public            System.Int32                    i  // 0x18
  public            System.Predicate<HoudiniEngineUnity.HEU_Curve><>9__0  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000216  System.Void .ctor()
  RVA=0x08804B4C  token=0x6000217  System.Boolean <CopyPropertiesTo>b__0(HoudiniEngineUnity.HEU_Curve curve)
END_CLASS

CLASS: InputNodeType
TYPE:  sealed struct
TOKEN: 0x200003B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InputNodeTypeCONNECTION  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputNodeTypeNODE  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputNodeTypePARAMETER  // const
METHODS:
END_CLASS

CLASS: InputObjectType
TYPE:  sealed struct
TOKEN: 0x200003C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeHDA  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeUNITY_MESH  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeCURVE  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeTERRAIN  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeBOUNDING_BOX  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeTILEMAP  // const
METHODS:
END_CLASS

CLASS: InternalObjectType
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InternalObjectTypeUNKNOWN  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InternalObjectTypeHDA  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InternalObjectTypeUNITY_MESH  // const
METHODS:
END_CLASS

CLASS: InputActions
TYPE:  sealed struct
TOKEN: 0x200003E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InputActionsACTION  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputActionsDELETE  // const
  public    static  HoudiniEngineUnity.HEU_InputNode.InputActionsINSERT  // const
METHODS:
END_CLASS

CLASS: HEU_InputObjectUICache
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600027C  System.Void .ctor()
END_CLASS

CLASS: HEU_InputAssetUICache
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600027D  System.Void .ctor()
END_CLASS

CLASS: PartOutputType
TYPE:  sealed struct
TOKEN: 0x2000049
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeNONE  // const
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeMESH  // const
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeVOLUME  // const
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeCURVE  // const
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeINSTANCER  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200004A
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.HEU_PartData.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.LOD><>9__96_0  // static @ 0x8
METHODS:
  RVA=0x08804DF4  token=0x6000302  System.Void .cctor()
  RVA=0x0350B670  token=0x6000303  System.Void .ctor()
  RVA=0x0880494C  token=0x6000304  System.Int32 <CopyGameObjectComponents>b__96_0(UnityEngine.LOD a, UnityEngine.LOD b)
END_CLASS

CLASS: <>c__DisplayClass97_0
TYPE:  sealed class
TOKEN: 0x200004B
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.TransformData>previousTransformValues  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000305  System.Void .ctor()
  RVA=0x08804BCC  token=0x6000306  System.Void <CopyChildGameObjects>b__0(UnityEngine.Transform trans)
END_CLASS

CLASS: <>c__DisplayClass99_0
TYPE:  sealed class
TOKEN: 0x200004C
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.TransformData>previousTransformValues  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000307  System.Void .ctor()
  RVA=0x08804C84  token=0x6000308  System.Void <BakePartToGameObject>b__0(UnityEngine.Transform trans)
END_CLASS

CLASS: <>c__DisplayClass99_1
TYPE:  sealed class
TOKEN: 0x200004D
SIZE:  0x18
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.TransformData>previousTransformValues  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000309  System.Void .ctor()
  RVA=0x08804D3C  token=0x600030A  System.Void <BakePartToGameObject>b__1(UnityEngine.Transform trans)
END_CLASS

CLASS: AttributeType
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeUNDEFINED  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeBOOL  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeINT  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeFLOAT  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeSTRING  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeMAX  // const
METHODS:
END_CLASS

CLASS: AttributeState
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeStateINVALID  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeStateSYNCED  // const
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeStateLOCAL_DIRTY  // const
METHODS:
END_CLASS

CLASS: SetAttributeValueFunc
TYPE:  sealed class
TOKEN: 0x2000052
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x088205A0  token=0x6000342  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01028930  token=0x6000343  System.Void Invoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x088204D4  token=0x6000344  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000345  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: HEU_ImportAssetOptions
TYPE:  sealed struct
TOKEN: 0x2000057
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsDefault  // const
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsForceUpdate  // const
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsForceSynchronousImport  // const
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsImportRecursive  // const
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsDontDownloadFromCacheServer  // const
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsForceUncompressedImport  // const
METHODS:
END_CLASS

CLASS: RegSAM
TYPE:  sealed struct
TOKEN: 0x200005D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMQueryValue  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMSetValue  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMCreateSubKey  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMEnumerateSubKeys  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMNotify  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMCreateLink  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWOW64_32Key  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWOW64_64Key  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWOW64_Res  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMRead  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWrite  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMExecute  // const
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMAllAccess  // const
METHODS:
END_CLASS

CLASS: DataType
TYPE:  sealed struct
TOKEN: 0x2000060
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeBOOL  // const
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeINT  // const
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeLONG  // const
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeFLOAT  // const
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeSTRING  // const
METHODS:
END_CLASS

CLASS: StoreData
TYPE:  class
TOKEN: 0x2000061
SIZE:  0x20
FIELDS:
  public            HoudiniEngineUnity.HEU_PluginStorage.DataType_type  // 0x10
  public            System.String                   _valueStr  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60004AE  System.Void .ctor()
END_CLASS

CLASS: StoreDataArray`1
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  public            T[]                             _array  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x60004AF  System.Void .ctor()
END_CLASS

CLASS: HEU_HandleType
TYPE:  sealed struct
TOKEN: 0x2000064
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Handle.HEU_HandleTypeXFORM  // const
  public    static  HoudiniEngineUnity.HEU_Handle.HEU_HandleTypeUNSUPPORTED  // const
METHODS:
END_CLASS

CLASS: HEU_HandleParamType
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamTypeTRANSLATE  // const
  public    static  HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamTypeROTATE  // const
  public    static  HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamTypeSCALE  // const
METHODS:
END_CLASS

CLASS: ModifierAction
TYPE:  sealed struct
TOKEN: 0x20000C3
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionMULTIPARM_INSERT  // const
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionMULTIPARM_REMOVE  // const
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionMULTIPARM_CLEAR  // const
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionSET_FLOAT  // const
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionSET_INT  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass82_0
TYPE:  sealed class
TOKEN: 0x20000C5
SIZE:  0x20
FIELDS:
  public            System.Int32                    parentID  // 0x10
  public            System.Predicate<HoudiniEngineUnity.HAPI_ParmInfo><>9__0  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000592  System.Void .ctor()
  RVA=0x05CEC5C4  token=0x6000593  System.Boolean <Initialize>b__0(HoudiniEngineUnity.HAPI_ParmInfo p)
END_CLASS

CLASS: <>c__DisplayClass83_0
TYPE:  sealed class
TOKEN: 0x20000C6
SIZE:  0x20
FIELDS:
  public            System.Int32                    parentID  // 0x10
  public            System.Predicate<HoudiniEngineUnity.HAPI_ParmInfo><>9__0  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000594  System.Void .ctor()
  RVA=0x05CEC5C4  token=0x6000595  System.Boolean <Initialize4HGTool>b__0(HoudiniEngineUnity.HAPI_ParmInfo p)
END_CLASS

CLASS: LinkState
TYPE:  sealed struct
TOKEN: 0x20000CB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateINACTIVE  // const
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateLINKING  // const
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateLINKED  // const
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateERROR_NOT_LINKED  // const
METHODS:
END_CLASS

CLASS: UpdateUIDelegate
TYPE:  sealed class
TOKEN: 0x20000CC
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x60005FA  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x60005FB  System.Void Invoke()
  RVA=0x042BE018  token=0x60005FC  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x60005FD  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: <>c__DisplayClass107_0
TYPE:  sealed class
TOKEN: 0x20000CD
SIZE:  0x28
FIELDS:
  public            HoudiniEngineUnity.HEU_PDGAssetLink<>4__this  // 0x10
  public            System.Action<HoudiniEngineUnity.HEU_TOPNodeData,HoudiniEngineUnity.HEU_SyncedEventData>OnSynced  // 0x18
  public            HoudiniEngineUnity.HEU_TOPNodeDatatopNode  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60005FE  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass107_1
TYPE:  sealed class
TOKEN: 0x20000CE
SIZE:  0x20
FIELDS:
  public            HoudiniEngineUnity.HEU_GeoSync  geoSync  // 0x10
  public            HoudiniEngineUnity.HEU_PDGAssetLink.<>c__DisplayClass107_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60005FF  System.Void .ctor()
  RVA=0x0882F84C  token=0x6000600  System.Void <LoadResults>b__0(HoudiniEngineUnity.HEU_SyncedEventData Data)
END_CLASS

CLASS: PDGState
TYPE:  sealed struct
TOKEN: 0x20000D2
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateNONE  // const
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateDIRTIED  // const
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateDIRTYING  // const
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateCOOKING  // const
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateCOOK_COMPLETE  // const
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateCOOK_FAILED  // const
METHODS:
END_CLASS

CLASS: OnWorkItemLoadResultsDelegate
TYPE:  sealed class
TOKEN: 0x20000D6
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x056E13A4  token=0x6000636  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000637  System.Void Invoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced)
  RVA=0x0389C3B0  token=0x6000638  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000639  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: EventMessageColor
TYPE:  sealed struct
TOKEN: 0x20000D7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PDGSession.EventMessageColorDEFAULT  // const
  public    static  HoudiniEngineUnity.HEU_PDGSession.EventMessageColorWARNING  // const
  public    static  HoudiniEngineUnity.HEU_PDGSession.EventMessageColorERROR  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass35_0
TYPE:  sealed class
TOKEN: 0x20000D8
SIZE:  0x28
FIELDS:
  public            System.Int32[]                  allNetworkNodeIds  // 0x10
  public            System.Int32                    idx  // 0x18
  public            System.Predicate<System.Int32>  <>9__0  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600063A  System.Void .ctor()
  RVA=0x0882F924  token=0x600063B  System.Boolean <GetNonBypassedNetworkIds>b__0(System.Int32 id)
END_CLASS

CLASS: Source
TYPE:  sealed struct
TOKEN: 0x20000F2
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceDEFAULT  // const
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceHOUDINI  // const
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceUNITY  // const
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceSUBSTANCE  // const
METHODS:
END_CLASS

CLASS: CreateSessionFromTypeDelegate
TYPE:  sealed class
TOKEN: 0x20000FB
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06E93748  token=0x600091D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0102B410  token=0x600091E  HoudiniEngineUnity.HEU_SessionBase Invoke(System.Type type)
  RVA=0x0389C3B0  token=0x600091F  System.IAsyncResult BeginInvoke(System.Type type, System.AsyncCallback callback, System.Object object)
  RVA=0x04276D7C  token=0x6000920  HoudiniEngineUnity.HEU_SessionBase EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Status
TYPE:  sealed struct
TOKEN: 0x20000FE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusStopped  // const
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusStarted  // const
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusConnecting  // const
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusInitializing  // const
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusConnected  // const
METHODS:
END_CLASS

CLASS: AssetSyncCallback
TYPE:  sealed class
TOKEN: 0x2000100
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x056E13A4  token=0x600092D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600092E  System.Void Invoke(HoudiniEngineUnity.HEU_AssetSync assetSync)
  RVA=0x0389C3B0  token=0x600092F  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AssetSync assetSync, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000930  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TaskStatus
TYPE:  sealed struct
TOKEN: 0x2000107
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusNONE  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusPENDING_START  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusSTARTED  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusREQUIRE_UPDATE  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusPENDING_COMPLETE  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusCOMPLETED  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusUNUSED  // const
METHODS:
END_CLASS

CLASS: TaskResult
TYPE:  sealed struct
TOKEN: 0x2000108
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultNONE  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultSUCCESS  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultFAILED  // const
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultKILLED  // const
METHODS:
END_CLASS

CLASS: TaskCallback
TYPE:  sealed class
TOKEN: 0x2000109
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x056E13A4  token=0x600096A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600096B  System.Void Invoke(HoudiniEngineUnity.HEU_Task task)
  RVA=0x0389C3B0  token=0x600096C  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_Task task, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600096D  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: BuildType
TYPE:  sealed struct
TOKEN: 0x200010B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeNONE  // const
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeLOAD  // const
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeCOOK  // const
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeRELOAD  // const
METHODS:
END_CLASS

CLASS: LoadType
TYPE:  sealed struct
TOKEN: 0x2000114
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadTypeFILE  // const
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadTypeNODE  // const
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadTypeASSET  // const
METHODS:
END_CLASS

CLASS: LoadStatus
TYPE:  sealed struct
TOKEN: 0x2000116
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusNONE  // const
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusSTARTED  // const
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusSUCCESS  // const
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusERROR  // const
METHODS:
END_CLASS

CLASS: HEU_LoadData
TYPE:  class
TOKEN: 0x2000115
SIZE:  0x38
FIELDS:
  public            System.Int32                    _cookNodeID  // 0x10
  public            HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus_loadStatus  // 0x14
  public            System.Text.StringBuilder       _logStr  // 0x18
  public            HoudiniEngineUnity.HEU_SessionBase_session  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject>_loadedObjects  // 0x28
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase>_idBuffersMap  // 0x30
METHODS:
  RVA=0x0350B670  token=0x60009C1  System.Void .ctor()
END_CLASS

CLASS: HEU_LoadObject
TYPE:  class
TOKEN: 0x2000117
SIZE:  0x30
FIELDS:
  public            System.Int32                    _objectNodeID  // 0x10
  public            System.Int32                    _displayNodeID  // 0x14
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume>_terrainBuffers  // 0x18
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh>_meshBuffers  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer>_instancerBuffers  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60009C2  System.Void .ctor()
END_CLASS

CLASS: HEU_LoadCallbackType
TYPE:  sealed struct
TOKEN: 0x2000118
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackTypePRECOOK  // const
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackTypePOSTCOOK  // const
METHODS:
END_CLASS

CLASS: HEU_LoadCallback
TYPE:  sealed class
TOKEN: 0x2000119
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x08162834  token=0x60009C3  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x011360D0  token=0x60009C4  System.Void Invoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType)
  RVA=0x0883F9A4  token=0x60009C5  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x60009C6  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: HEU_ReplacePrefabOptions
TYPE:  sealed struct
TOKEN: 0x200011D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptionsDefault  // const
  public    static  HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptionsConnectToPrefab  // const
  public    static  HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptionsReplaceNameBased  // const
METHODS:
END_CLASS

CLASS: GetArray1ArgDel`1
TYPE:  sealed class
TOKEN: 0x2000123
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000A8A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000A8B  System.Boolean Invoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length)
  RVA=-1  // runtime  token=0x6000A8C  System.IAsyncResult BeginInvoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000A8D  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetArray2ArgDel`2
TYPE:  sealed class
TOKEN: 0x2000124
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000A8E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000A8F  System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length)
  RVA=-1  // runtime  token=0x6000A90  System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000A91  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetArray3ArgDel`3
TYPE:  sealed class
TOKEN: 0x2000125
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000A92  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000A93  System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length)
  RVA=-1  // runtime  token=0x6000A94  System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000A95  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetAttributeArrayInputFunc`1
TYPE:  sealed class
TOKEN: 0x2000126
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000A96  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000A97  System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end)
  RVA=-1  // runtime  token=0x6000A98  System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000A99  System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& info, System.IAsyncResult result)
END_CLASS

CLASS: SetAttributeArrayFunc`1
TYPE:  sealed class
TOKEN: 0x2000127
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x6000A9A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x6000A9B  System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end)
  RVA=-1  // runtime  token=0x6000A9C  System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object)
  RVA=-1  // runtime  token=0x6000A9D  System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.IAsyncResult result)
END_CLASS

CLASS: ColliderType
TYPE:  sealed struct
TOKEN: 0x200012B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeNONE  // const
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeBOX  // const
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSPHERE  // const
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeMESH  // const
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSIMPLE_BOX  // const
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSIMPLE_SPHERE  // const
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSIMPLE_CAPSULE  // const
METHODS:
END_CLASS

CLASS: HEU_ColliderInfo
TYPE:  class
TOKEN: 0x200012A
SIZE:  0x58
FIELDS:
  public            HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType_colliderType  // 0x10
  public            UnityEngine.Vector3             _colliderCenter  // 0x14
  public            UnityEngine.Vector3             _colliderSize  // 0x20
  public            System.Single                   _colliderRadius  // 0x2c
  public            System.Boolean                  _convexCollider  // 0x30
  public            System.String                   _collisionGroupName  // 0x38
  public            UnityEngine.Vector3[]           _collisionVertices  // 0x40
  public            System.Int32[]                  _collisionIndices  // 0x48
  public            UnityEngine.MeshTopology        _meshTopology  // 0x50
  public            System.Boolean                  _isTrigger  // 0x54
METHODS:
  RVA=0x0350B670  token=0x6000AB9  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200012C
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.HEU_GenerateGeoCache.<>c<>9  // static @ 0x0
  public    static  System.Predicate<UnityEngine.Material><>9__63_0  // static @ 0x8
  public    static  System.Comparison<System.Single><>9__65_0  // static @ 0x10
METHODS:
  RVA=0x08854750  token=0x6000ABA  System.Void .cctor()
  RVA=0x0350B670  token=0x6000ABB  System.Void .ctor()
  RVA=0x08854704  token=0x6000ABC  System.Boolean <GetFinalMaterialsFromComparingNewWithPrevious>b__63_0(UnityEngine.Material material)
  RVA=0x088546E8  token=0x6000ABD  System.Int32 <GenerateLODMeshesFromGeoGroups>b__65_0(System.Single a, System.Single b)
END_CLASS

CLASS: HEU_InputDataMeshes
TYPE:  class
TOKEN: 0x2000134
SIZE:  0x28
EXTENDS: HoudiniEngineUnity.HEU_InputData
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh>_inputMeshes  // 0x18
  public            System.Boolean                  _hasLOD  // 0x20
METHODS:
  RVA=0x088465BC  token=0x6000AE0  System.Void .ctor()
END_CLASS

CLASS: HEU_InputColliderType
TYPE:  sealed struct
TOKEN: 0x2000135
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeNONE  // const
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeBOX  // const
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeSPHERE  // const
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeCAPSULE  // const
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeMESH  // const
METHODS:
END_CLASS

CLASS: HEU_InputDataCollider
TYPE:  class
TOKEN: 0x2000136
SIZE:  0x20
FIELDS:
  public            UnityEngine.Collider            _collider  // 0x10
  public            HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType_colliderType  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000AE1  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataMesh
TYPE:  class
TOKEN: 0x2000137
SIZE:  0x60
FIELDS:
  public            UnityEngine.Mesh                _mesh  // 0x10
  public            UnityEngine.Material[]          _materials  // 0x18
  public            System.String                   _meshPath  // 0x20
  public            System.String                   _meshName  // 0x28
  public            System.Int32                    _numVertices  // 0x30
  public            System.Int32                    _numSubMeshes  // 0x34
  public            System.UInt32[]                 _indexStart  // 0x38
  public            System.UInt32[]                 _indexCount  // 0x40
  public            System.Single                   _LODScreenTransition  // 0x48
  public            UnityEngine.Transform           _transform  // 0x50
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataCollider>_colliders  // 0x58
METHODS:
  RVA=0x0350B670  token=0x6000AE2  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataTerrain
TYPE:  class
TOKEN: 0x2000139
SIZE:  0x80
EXTENDS: HoudiniEngineUnity.HEU_InputData
FIELDS:
  public            System.String                   _heightFieldName  // 0x18
  public            System.Int32                    _parentNodeID  // 0x20
  public            System.Single                   _voxelSize  // 0x24
  public            UnityEngine.Terrain             _terrain  // 0x28
  public            UnityEngine.TerrainData         _terrainData  // 0x30
  public            System.Int32                    _numPointsX  // 0x38
  public            System.Int32                    _numPointsY  // 0x3c
  public            HoudiniEngineUnity.HAPI_Transform_transform  // 0x40
  public            System.Single                   _heightScale  // 0x68
  public            System.Int32                    _heightfieldNodeID  // 0x6c
  public            System.Int32                    _heightNodeID  // 0x70
  public            System.Int32                    _maskNodeID  // 0x74
  public            System.Int32                    _mergeNodeID  // 0x78
METHODS:
  RVA=0x08846634  token=0x6000AF0  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataTilemap
TYPE:  class
TOKEN: 0x200013C
SIZE:  0x28
EXTENDS: HoudiniEngineUnity.HEU_InputData
FIELDS:
  public            UnityEngine.Tilemaps.Tilemap    _tilemap  // 0x18
  public            UnityEngine.Transform           _transform  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000AF8  System.Void .ctor()
END_CLASS

CLASS: ToolType
TYPE:  sealed struct
TOKEN: 0x2000146
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeGENERATOR  // const
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeOPERATOR_SINGLE  // const
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeOPERATOR_MULTI  // const
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeBATCH  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass19_0
TYPE:  sealed class
TOKEN: 0x2000149
SIZE:  0x18
FIELDS:
  public            System.String                   shelfName  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000B59  System.Void .ctor()
  RVA=0x05A49258  token=0x6000B5A  System.Boolean <AddShelf>b__0(HoudiniEngineUnity.HEU_Shelf shelf)
END_CLASS

CLASS: Type
TYPE:  sealed struct
TOKEN: 0x200014E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONNode.Enumerator.TypeNone  // const
  public    static  HoudiniEngineUnity.JSONNode.Enumerator.TypeArray  // const
  public    static  HoudiniEngineUnity.JSONNode.Enumerator.TypeObject  // const
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  sealed struct
TOKEN: 0x200014D
SIZE:  0x58
FIELDS:
  private           HoudiniEngineUnity.JSONNode.Enumerator.Typetype  // 0x10
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode>m_Object  // 0x18
  private           System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode>m_Array  // 0x40
PROPERTIES:
  IsValid  get=0x0426F724
  Current  get=0x08854858
METHODS:
  RVA=0x08854824  token=0x6000BBF  System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum)
  RVA=0x03B109F0  token=0x6000BC0  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum)
  RVA=0x088547B4  token=0x6000BC2  System.Boolean MoveNext()
END_CLASS

CLASS: ValueEnumerator
TYPE:  sealed struct
TOKEN: 0x200014F
SIZE:  0x58
FIELDS:
  private           HoudiniEngineUnity.JSONNode.Enumeratorm_Enumerator  // 0x10
PROPERTIES:
  Current  get=0x08867B98
METHODS:
  RVA=0x0885EBAC  token=0x6000BC3  System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum)
  RVA=0x0885EAD8  token=0x6000BC4  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum)
  RVA=0x0885EB78  token=0x6000BC5  System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator)
  RVA=0x0885EAD0  token=0x6000BC7  System.Boolean MoveNext()
  RVA=0x03D6D9B0  token=0x6000BC8  HoudiniEngineUnity.JSONNode.ValueEnumerator GetEnumerator()
END_CLASS

CLASS: KeyEnumerator
TYPE:  sealed struct
TOKEN: 0x2000150
SIZE:  0x58
FIELDS:
  private           HoudiniEngineUnity.JSONNode.Enumeratorm_Enumerator  // 0x10
PROPERTIES:
  Current  get=0x0885EC44
METHODS:
  RVA=0x0885EBAC  token=0x6000BC9  System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum)
  RVA=0x0885EAD8  token=0x6000BCA  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum)
  RVA=0x0885EB78  token=0x6000BCB  System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator)
  RVA=0x0885EAD0  token=0x6000BCD  System.Boolean MoveNext()
  RVA=0x03D6D9B0  token=0x6000BCE  HoudiniEngineUnity.JSONNode.KeyEnumerator GetEnumerator()
END_CLASS

CLASS: LinqEnumerator
TYPE:  class
TOKEN: 0x2000151
SIZE:  0x60
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           HoudiniEngineUnity.JSONNode     m_Node  // 0x10
  private           HoudiniEngineUnity.JSONNode.Enumeratorm_Enumerator  // 0x18
PROPERTIES:
  Current  get=0x0885EED4
  System.Collections.IEnumerator.Current  get=0x0885EE00
METHODS:
  RVA=0x0885EE58  token=0x6000BCF  System.Void .ctor(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x0885ED24  token=0x6000BD2  System.Boolean MoveNext()
  RVA=0x0885EC84  token=0x6000BD3  System.Void Dispose()
  RVA=0x0885ECC0  token=0x6000BD4  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> GetEnumerator()
  RVA=0x0885ED30  token=0x6000BD5  System.Void Reset()
  RVA=0x0885ED9C  token=0x6000BD6  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_Children>d__40
TYPE:  sealed class
TOKEN: 0x2000152
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           HoudiniEngineUnity.JSONNode     <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000BD7  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000BD8  System.Void System.IDisposable.Dispose()
  RVA=0x03D4C410  token=0x6000BD9  System.Boolean MoveNext()
  RVA=0x088674F4  token=0x6000BDB  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x08867474  token=0x6000BDD  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator()
  RVA=0x088674EC  token=0x6000BDE  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_DeepChildren>d__42
TYPE:  sealed class
TOKEN: 0x2000153
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           HoudiniEngineUnity.JSONNode     <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            HoudiniEngineUnity.JSONNode     <>4__this  // 0x28
  private           System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode><>7__wrap1  // 0x30
  private           System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode><>7__wrap2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000BDF  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x08867A18  token=0x6000BE0  System.Void System.IDisposable.Dispose()
  RVA=0x08867540  token=0x6000BE1  System.Boolean MoveNext()
  RVA=0x08867B04  token=0x6000BE2  System.Void <>m__Finally1()
  RVA=0x08867B4C  token=0x6000BE3  System.Void <>m__Finally2()
  RVA=0x088679CC  token=0x6000BE5  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x08867938  token=0x6000BE7  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator()
  RVA=0x088679C4  token=0x6000BE8  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_Children>d__22
TYPE:  sealed class
TOKEN: 0x2000155
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           HoudiniEngineUnity.JSONNode     <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            HoudiniEngineUnity.JSONArray    <>4__this  // 0x28
  private           System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode><>7__wrap1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000BF9  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x08866FB8  token=0x6000BFA  System.Void System.IDisposable.Dispose()
  RVA=0x08866C90  token=0x6000BFB  System.Boolean MoveNext()
  RVA=0x08867030  token=0x6000BFC  System.Void <>m__Finally1()
  RVA=0x08866F6C  token=0x6000BFE  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x08866ED8  token=0x6000C00  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator()
  RVA=0x08866F64  token=0x6000C01  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <>c__DisplayClass21_0
TYPE:  sealed class
TOKEN: 0x2000157
SIZE:  0x18
FIELDS:
  public            HoudiniEngineUnity.JSONNode     aNode  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000C13  System.Void .ctor()
  RVA=0x08866540  token=0x6000C14  System.Boolean <Remove>b__0(System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> k)
END_CLASS

CLASS: <get_Children>d__23
TYPE:  sealed class
TOKEN: 0x2000158
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           HoudiniEngineUnity.JSONNode     <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  public            HoudiniEngineUnity.JSONObject   <>4__this  // 0x28
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode><>7__wrap1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000C15  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x088673C0  token=0x6000C16  System.Void System.IDisposable.Dispose()
  RVA=0x0886706C  token=0x6000C17  System.Boolean MoveNext()
  RVA=0x08867438  token=0x6000C18  System.Void <>m__Finally1()
  RVA=0x08867374  token=0x6000C1A  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x088672E0  token=0x6000C1C  System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator()
  RVA=0x0886736C  token=0x6000C1D  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: RequireStruct`1
TYPE:  class
TOKEN: 0x2000164
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000C9E  System.Void .ctor()
END_CLASS

CLASS: RequireClass`1
TYPE:  class
TOKEN: 0x2000165
FIELDS:
METHODS:
  RVA=-1  // not resolved  token=0x6000C9F  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000178
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_LODGroup_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.LODGroup,HoudiniEngineUnity.Test_LODGroup><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.LODGroup,HoudiniEngineUnity.Test_LODGroup><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866B64  token=0x6000CBE  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CBF  System.Void .ctor()
  RVA=0x08865944  token=0x6000CC0  HoudiniEngineUnity.Test_LODGroup <ToTestObject>b__1_0(UnityEngine.LODGroup lod)
  RVA=0x08865EE4  token=0x6000CC1  HoudiniEngineUnity.Test_LODGroup <ToTestObject>b__2_0(UnityEngine.LODGroup lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200017B
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Transform_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Transform,HoudiniEngineUnity.Test_Transform><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Transform,HoudiniEngineUnity.Test_Transform><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866650  token=0x6000CC8  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CC9  System.Void .ctor()
  RVA=0x08865A04  token=0x6000CCA  HoudiniEngineUnity.Test_Transform <ToTestObject>b__1_0(UnityEngine.Transform lod)
  RVA=0x088663C0  token=0x6000CCB  HoudiniEngineUnity.Test_Transform <ToTestObject>b__2_0(UnityEngine.Transform lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200017E
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Material_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Material,HoudiniEngineUnity.Test_Material><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Material,HoudiniEngineUnity.Test_Material><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x088666B4  token=0x6000CD2  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CD3  System.Void .ctor()
  RVA=0x08865B24  token=0x6000CD4  HoudiniEngineUnity.Test_Material <ToTestObject>b__1_0(UnityEngine.Material lod)
  RVA=0x08865FA4  token=0x6000CD5  HoudiniEngineUnity.Test_Material <ToTestObject>b__2_0(UnityEngine.Material lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000181
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Collider_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Collider,HoudiniEngineUnity.Test_Collider><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Collider,HoudiniEngineUnity.Test_Collider><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x0886677C  token=0x6000CDC  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CDD  System.Void .ctor()
  RVA=0x08865888  token=0x6000CDE  HoudiniEngineUnity.Test_Collider <ToTestObject>b__1_0(UnityEngine.Collider lod)
  RVA=0x088660C4  token=0x6000CDF  HoudiniEngineUnity.Test_Collider <ToTestObject>b__2_0(UnityEngine.Collider lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000184
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_BoxCollider_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.BoxCollider,HoudiniEngineUnity.Test_BoxCollider><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.BoxCollider,HoudiniEngineUnity.Test_BoxCollider><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866588  token=0x6000CE6  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CE7  System.Void .ctor()
  RVA=0x088659A4  token=0x6000CE8  HoudiniEngineUnity.Test_BoxCollider <ToTestObject>b__1_0(UnityEngine.BoxCollider lod)
  RVA=0x088664E0  token=0x6000CE9  HoudiniEngineUnity.Test_BoxCollider <ToTestObject>b__2_0(UnityEngine.BoxCollider lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000187
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_SphereCollider_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.SphereCollider,HoudiniEngineUnity.Test_SphereCollider><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.SphereCollider,HoudiniEngineUnity.Test_SphereCollider><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866970  token=0x6000CF0  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CF1  System.Void .ctor()
  RVA=0x08865D64  token=0x6000CF2  HoudiniEngineUnity.Test_SphereCollider <ToTestObject>b__1_0(UnityEngine.SphereCollider lod)
  RVA=0x088661E4  token=0x6000CF3  HoudiniEngineUnity.Test_SphereCollider <ToTestObject>b__2_0(UnityEngine.SphereCollider lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200018A
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_CapsuleCollider_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.CapsuleCollider,HoudiniEngineUnity.Test_CapsuleCollider><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.CapsuleCollider,HoudiniEngineUnity.Test_CapsuleCollider><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866718  token=0x6000CFA  System.Void .cctor()
  RVA=0x0350B670  token=0x6000CFB  System.Void .ctor()
  RVA=0x08865AC4  token=0x6000CFC  HoudiniEngineUnity.Test_CapsuleCollider <ToTestObject>b__1_0(UnityEngine.CapsuleCollider lod)
  RVA=0x08866184  token=0x6000CFD  HoudiniEngineUnity.Test_CapsuleCollider <ToTestObject>b__2_0(UnityEngine.CapsuleCollider lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200018D
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_MeshCollider_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.MeshCollider,HoudiniEngineUnity.Test_MeshCollider><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.MeshCollider,HoudiniEngineUnity.Test_MeshCollider><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866A38  token=0x6000D04  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D05  System.Void .ctor()
  RVA=0x08865828  token=0x6000D06  HoudiniEngineUnity.Test_MeshCollider <ToTestObject>b__1_0(UnityEngine.MeshCollider lod)
  RVA=0x08866004  token=0x6000D07  HoudiniEngineUnity.Test_MeshCollider <ToTestObject>b__2_0(UnityEngine.MeshCollider lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000190
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Mesh_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Mesh,HoudiniEngineUnity.Test_Mesh><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Mesh,HoudiniEngineUnity.Test_Mesh><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x0886690C  token=0x6000D0E  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D0F  System.Void .ctor()
  RVA=0x08865B84  token=0x6000D10  HoudiniEngineUnity.Test_Mesh <ToTestObject>b__1_0(UnityEngine.Mesh lod)
  RVA=0x08865E84  token=0x6000D11  HoudiniEngineUnity.Test_Mesh <ToTestObject>b__2_0(UnityEngine.Mesh lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000193
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_MeshRenderer_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.MeshRenderer,HoudiniEngineUnity.Test_MeshRenderer><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.MeshRenderer,HoudiniEngineUnity.Test_MeshRenderer><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x088667E0  token=0x6000D18  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D19  System.Void .ctor()
  RVA=0x08865E24  token=0x6000D1A  HoudiniEngineUnity.Test_MeshRenderer <ToTestObject>b__1_0(UnityEngine.MeshRenderer lod)
  RVA=0x08866480  token=0x6000D1B  HoudiniEngineUnity.Test_MeshRenderer <ToTestObject>b__2_0(UnityEngine.MeshRenderer lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000196
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_MeshFilter_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.MeshFilter,HoudiniEngineUnity.Test_MeshFilter><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.MeshFilter,HoudiniEngineUnity.Test_MeshFilter><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866C2C  token=0x6000D22  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D23  System.Void .ctor()
  RVA=0x08865D04  token=0x6000D24  HoudiniEngineUnity.Test_MeshFilter <ToTestObject>b__1_0(UnityEngine.MeshFilter lod)
  RVA=0x08865F44  token=0x6000D25  HoudiniEngineUnity.Test_MeshFilter <ToTestObject>b__2_0(UnityEngine.MeshFilter lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200019B
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Gradient_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Gradient,HoudiniEngineUnity.Test_Gradient><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Gradient,HoudiniEngineUnity.Test_Gradient><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x088669D4  token=0x6000D2F  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D30  System.Void .ctor()
  RVA=0x08865DC4  token=0x6000D31  HoudiniEngineUnity.Test_Gradient <ToTestObject>b__1_0(UnityEngine.Gradient lod)
  RVA=0x08866064  token=0x6000D32  HoudiniEngineUnity.Test_Gradient <ToTestObject>b__2_0(UnityEngine.Gradient lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200019E
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_AnimationCurve_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.AnimationCurve,HoudiniEngineUnity.Test_AnimationCurve><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.AnimationCurve,HoudiniEngineUnity.Test_AnimationCurve><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x088668A8  token=0x6000D39  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D3A  System.Void .ctor()
  RVA=0x08865BE4  token=0x6000D3B  HoudiniEngineUnity.Test_AnimationCurve <ToTestObject>b__1_0(UnityEngine.AnimationCurve lod)
  RVA=0x08866360  token=0x6000D3C  HoudiniEngineUnity.Test_AnimationCurve <ToTestObject>b__2_0(UnityEngine.AnimationCurve lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20001A1
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_TerrainLayer_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.TerrainLayer,HoudiniEngineUnity.Test_TerrainLayer><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.TerrainLayer,HoudiniEngineUnity.Test_TerrainLayer><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866A9C  token=0x6000D43  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D44  System.Void .ctor()
  RVA=0x08865A64  token=0x6000D45  HoudiniEngineUnity.Test_TerrainLayer <ToTestObject>b__1_0(UnityEngine.TerrainLayer lod)
  RVA=0x08866300  token=0x6000D46  HoudiniEngineUnity.Test_TerrainLayer <ToTestObject>b__2_0(UnityEngine.TerrainLayer lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20001A4
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Texture2D_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Texture2D,HoudiniEngineUnity.Test_Texture2D><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Texture2D,HoudiniEngineUnity.Test_Texture2D><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866BC8  token=0x6000D4D  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D4E  System.Void .ctor()
  RVA=0x088657C8  token=0x6000D4F  HoudiniEngineUnity.Test_Texture2D <ToTestObject>b__1_0(UnityEngine.Texture2D lod)
  RVA=0x08866420  token=0x6000D50  HoudiniEngineUnity.Test_Texture2D <ToTestObject>b__2_0(UnityEngine.Texture2D lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20001A7
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_TreeInstance_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.TreeInstance,HoudiniEngineUnity.Test_TreeInstance><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.TreeInstance,HoudiniEngineUnity.Test_TreeInstance><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866844  token=0x6000D56  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D57  System.Void .ctor()
  RVA=0x088658E8  token=0x6000D58  HoudiniEngineUnity.Test_TreeInstance <ToTestObject>b__1_0(UnityEngine.TreeInstance lod)
  RVA=0x08866244  token=0x6000D59  HoudiniEngineUnity.Test_TreeInstance <ToTestObject>b__2_0(UnityEngine.TreeInstance lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20001AA
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_TerrainData_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.TerrainData,HoudiniEngineUnity.Test_TerrainData><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.TerrainData,HoudiniEngineUnity.Test_TerrainData><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x08866B00  token=0x6000D60  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D61  System.Void .ctor()
  RVA=0x08865CA4  token=0x6000D62  HoudiniEngineUnity.Test_TerrainData <ToTestObject>b__1_0(UnityEngine.TerrainData lod)
  RVA=0x088662A0  token=0x6000D63  HoudiniEngineUnity.Test_TerrainData <ToTestObject>b__2_0(UnityEngine.TerrainData lod)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20001AD
SIZE:  0x10
FIELDS:
  public    static readonly HoudiniEngineUnity.Test_Terrain_Extensions.<>c<>9  // static @ 0x0
  public    static  System.Converter<UnityEngine.Terrain,HoudiniEngineUnity.Test_Terrain><>9__1_0  // static @ 0x8
  public    static  System.Converter<UnityEngine.Terrain,HoudiniEngineUnity.Test_Terrain><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x088665EC  token=0x6000D6A  System.Void .cctor()
  RVA=0x0350B670  token=0x6000D6B  System.Void .ctor()
  RVA=0x08865C44  token=0x6000D6C  HoudiniEngineUnity.Test_Terrain <ToTestObject>b__1_0(UnityEngine.Terrain lod)
  RVA=0x08866124  token=0x6000D6D  HoudiniEngineUnity.Test_Terrain <ToTestObject>b__2_0(UnityEngine.Terrain lod)
END_CLASS

CLASS: PaintMergeMode
TYPE:  sealed struct
TOKEN: 0x20001AF
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeREPLACE  // const
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeADD  // const
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeSUBTRACT  // const
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeMULTIPLY  // const
METHODS:
END_CLASS

CLASS: PaintMeshVisibility
TYPE:  sealed struct
TOKEN: 0x20001B0
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibilityAUTO  // const
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibilitySHOW  // const
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibilityHIDE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetEventType
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeUNKNOWN  // const
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeRELOAD  // const
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeCOOK  // const
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeBAKE_NEW  // const
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeBAKE_UPDATE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetEventData
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x30
FIELDS:
  public            HoudiniEngineUnity.HEU_HoudiniAssetAsset  // 0x10
  public            System.Boolean                  CookSuccess  // 0x18
  public            System.Collections.Generic.List<UnityEngine.GameObject>OutputObjects  // 0x20
  public            HoudiniEngineUnity.HEU_AssetEventTypeEventType  // 0x28
METHODS:
  RVA=0x03240600  token=0x6000022  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ReloadEventData
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x30
EXTENDS: HoudiniEngineUnity.HEU_AssetEventData
FIELDS:
METHODS:
  RVA=0x087EF5B0  token=0x6000023  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CookedEventData
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x30
EXTENDS: HoudiniEngineUnity.HEU_AssetEventData
FIELDS:
METHODS:
  RVA=0x087D3650  token=0x6000024  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_BakedEventData
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x38
EXTENDS: HoudiniEngineUnity.HEU_AssetEventData
FIELDS:
  public            System.Boolean                  IsNewBake  // 0x30
METHODS:
  RVA=0x087D3370  token=0x6000025  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PreAssetEventData
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x20
FIELDS:
  public            HoudiniEngineUnity.HEU_HoudiniAssetAsset  // 0x10
  public            HoudiniEngineUnity.HEU_AssetEventTypeAssetType  // 0x18
METHODS:
  RVA=0x02738A30  token=0x6000026  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_AssetEventType assetType)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ReloadDataEvent
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x087EF574  token=0x6000027  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CookedDataEvent
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x087D3614  token=0x6000028  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_BakedDataEvent
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x087D3334  token=0x6000029  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PreAssetEvent
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x087EF478  token=0x600002A  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetPreset
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x50
FIELDS:
  public            System.Char[]                   _identifier  // 0x10
  public            System.Int32                    _version  // 0x18
  public            System.String                   _assetOPName  // 0x20
  public            System.Byte[]                   _parameterPreset  // 0x28
  public            System.Collections.Generic.List<System.String>_curveNames  // 0x30
  public            System.Collections.Generic.List<System.Byte[]>_curvePresets  // 0x38
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset>inputPresets  // 0x40
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset>volumeCachePresets  // 0x48
METHODS:
  RVA=0x087D3040  token=0x600002B  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputPreset
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x48
FIELDS:
  private           HoudiniEngineUnity.HEU_InputNode.InputObjectType_inputObjectType  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectPreset>_inputObjectPresets  // 0x18
  public            System.String                   _inputAssetName  // 0x20
  public            System.Int32                    _inputIndex  // 0x28
  public            System.String                   _inputName  // 0x30
  public            System.Boolean                  _keepWorldTransform  // 0x38
  public            System.Boolean                  _packGeometryBeforeMerging  // 0x39
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputAssetPreset>_inputAssetPresets  // 0x40
PROPERTIES:
  InputObjectType  get=0x087EF44C  set=0x087EF458
METHODS:
  RVA=0x087EF38C  token=0x600002E  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputObjectPreset
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x40
FIELDS:
  public            System.String                   _gameObjectName  // 0x10
  public            System.Boolean                  _isSceneObject  // 0x18
  public            System.Boolean                  _useTransformOffset  // 0x19
  public            UnityEngine.Vector3             _translateOffset  // 0x1c
  public            UnityEngine.Vector3             _rotateOffset  // 0x28
  public            UnityEngine.Vector3             _scaleOffset  // 0x34
METHODS:
  RVA=0x087EF32C  token=0x600002F  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputAssetPreset
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x18
FIELDS:
  public            System.String                   _gameObjectName  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000030  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeLayerPreset
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x28
FIELDS:
  public            System.String                   _layerName  // 0x10
  public            System.Single                   _strength  // 0x18
  public            System.Boolean                  _uiExpanded  // 0x1c
  public            System.Int32                    _tile  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000031  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeCachePreset
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x40
FIELDS:
  public            System.String                   _objName  // 0x10
  public            System.String                   _geoName  // 0x18
  public            System.Boolean                  _uiExpanded  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayerPreset>_volumeLayersPresets  // 0x28
  public            System.String                   _terrainDataPath  // 0x30
  public            System.Int32                    _tile  // 0x38
METHODS:
  RVA=0x087EFC3C  token=0x6000032  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_RecookPreset
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x20
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset>_volumeCachePresets  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset>_inputPresets  // 0x18
METHODS:
  RVA=0x087EF4B4  token=0x6000033  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetPresetUtility
TYPE:  static class
TOKEN: 0x200001C
SIZE:  0x10
FIELDS:
  public    static  System.Char[]                   PRESET_IDENTIFIER  // static @ 0x0
  public    static  System.Int32                    PRESET_VERSION  // static @ 0x8
METHODS:
  RVA=0x087D2A44  token=0x6000034  System.Void SaveAssetPresetToFile(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath)
  RVA=0x087D2498  token=0x6000035  System.Void LoadPresetFileIntoAssetAndCook(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath)
  RVA=0x087D2FBC  token=0x6000036  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Vector3SerializationSurrogate
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x10
IMPLEMENTS: System.Runtime.Serialization.ISerializationSurrogate
FIELDS:
METHODS:
  RVA=0x087EF9F4  token=0x6000037  System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x087EFABC  token=0x6000038  System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
  RVA=0x0350B670  token=0x6000039  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Vector2SerializationSurrogate
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x10
IMPLEMENTS: System.Runtime.Serialization.ISerializationSurrogate
FIELDS:
METHODS:
  RVA=0x087EF824  token=0x600003A  System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x087EF8C8  token=0x600003B  System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
  RVA=0x0350B670  token=0x600003C  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetSerializedMetaData
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x30
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.Boolean                  _softDeleted  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>>_savedCurveNodeData  // 0x20
  private           System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo>_savedInputCurveInfo  // 0x28
PROPERTIES:
  SoftDeleted  get=0x01002A50  set=0x01002B40
  SavedCurveNodeData  get=0x03D4EB40
  SavedInputCurveInfo  get=0x03D4EAC0
METHODS:
  RVA=0x087D3198  token=0x6000041  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AssetSerializedMetaData other)
  RVA=0x087D322C  token=0x6000042  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetUpdater
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000043  System.Void .cctor()
  RVA=0x087D32F4  token=0x6000044  System.Void OnBeforeAssemblyReload()
  RVA=0x0350B670  token=0x6000045  System.Void Update()
  RVA=0x0350B670  token=0x6000046  System.Void AddAssetForUpdate(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x0350B670  token=0x6000047  System.Void RemoveAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x0350B670  token=0x6000048  System.Void AddNodeSyncForUpdate(HoudiniEngineUnity.HEU_BaseSync nodeSync)
  RVA=0x0350B670  token=0x6000049  System.Void RemoveNodeSync(HoudiniEngineUnity.HEU_BaseSync nodeSync)
  RVA=0x0350B670  token=0x600004A  System.Void OnPrefabInstanceUpdate(UnityEngine.GameObject instance)
  RVA=0x0350B670  token=0x600004B  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.CurveNodeData
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x38
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             rotation  // 0x1c
  public            UnityEngine.Vector3             scale  // 0x28
  public            System.Int32                    curveCountIndex  // 0x34
METHODS:
  RVA=0x087D1EE0  token=0x600004C  System.Void .ctor()
  RVA=0x087D1E70  token=0x600004D  System.Void .ctor(UnityEngine.Vector3 position)
  RVA=0x087D1F40  token=0x600004E  System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x087D1FC8  token=0x600004F  System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  RVA=0x087D1DD0  token=0x6000050  System.Void .ctor(HoudiniEngineUnity.CurveNodeData other)
  RVA=0x087D1C04  token=0x6000051  UnityEngine.Quaternion GetRotation()
  RVA=0x087D1C40  token=0x6000052  System.Boolean IsEquivalentTo(HoudiniEngineUnity.CurveNodeData other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputCurveInfo
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x28
FIELDS:
  public            HoudiniEngineUnity.HAPI_CurveTypecurveType  // 0x10
  public            System.Int32                    order  // 0x14
  public            System.Boolean                  closed  // 0x18
  public            System.Boolean                  reverse  // 0x19
  public            HoudiniEngineUnity.HAPI_InputCurveMethodinputMethod  // 0x1c
  public            HoudiniEngineUnity.HAPI_InputCurveParameterizationbreakpointParameterization  // 0x20
METHODS:
  RVA=0x087EF0D0  token=0x6000053  HoudiniEngineUnity.HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HoudiniEngineUnity.HAPI_InputCurveInfo curveInfo)
  RVA=0x087EF1FC  token=0x6000054  System.String[] GetCurveTypeNames()
  RVA=0x087EF2A4  token=0x6000055  System.String[] GetInputMethodNames()
  RVA=0x087EF154  token=0x6000056  System.String[] GetBreakpointParameterizationNames()
  RVA=0x03D6D3C0  token=0x6000057  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CurveDataType
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_CurveDataTypeINVALID  // const
  public    static  HoudiniEngineUnity.HEU_CurveDataTypeGEO_COORDS_PARAM  // const
  public    static  HoudiniEngineUnity.HEU_CurveDataTypeHAPI_COORDS_PARAM  // const
  public    static  HoudiniEngineUnity.HEU_CurveDataTypePOSITION_ATTRIBUTE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Curve
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x90
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_Curve HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.Int32                    _geoID  // 0x18
  private           System.Int32                    _partID  // 0x1c
  private           System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>_curveNodeData  // 0x20
  private           UnityEngine.Vector3[]           _vertices  // 0x28
  private           System.Boolean                  _isEditable  // 0x30
  private           HoudiniEngineUnity.HEU_Parameters_parameters  // 0x38
  private           System.Boolean                  _bUploadParameterPreset  // 0x40
  private           System.String                   _curveName  // 0x48
  private           UnityEngine.GameObject          _targetGameObject  // 0x50
  private           System.Boolean                  _isGeoCurve  // 0x58
  private           HoudiniEngineUnity.HEU_Curve.CurveEditState_editState  // 0x5c
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionPreferredNextInteractionMode  // static @ 0x0
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x60
  private           System.Boolean                  _bIsInputCurve  // 0x68
  private           System.Boolean                  _bIsPartCurve  // 0x69
  private           System.Boolean                  _cachedCurveInfoValid  // 0x6a
  private           System.Int32[]                  _cachedCurveCounts  // 0x70
  private           System.Int32[]                  _cachedCurveCountSums  // 0x78
  private           HoudiniEngineUnity.HEU_CurveDataType_curveDataType  // 0x80
  private           HoudiniEngineUnity.HEU_InputCurveInfo_inputCurveInfo  // 0x88
PROPERTIES:
  TargetGameObject  get=0x03D4EAF0  set=0x02C926C0
  GeoID  get=0x020D1AC0
  PartID  get=0x03D4EBB0
  CurveNodeData  get=0x03D4EB40
  Parameters  get=0x03D4E2A0
  CurveName  get=0x03D4EA70
  IsInputCurve  get=0x03D4F3F0
  IsPartCurve  get=0x03D4F3C0
  InputCurveInfo  get=0x03D4EA60
  EditState  get=0x03D4EEF0
  ParentAsset  get=0x03D4EB00
  CurveDataType  get=0x03D4EC20
METHODS:
  RVA=0x03D4EEB0  token=0x6000062  System.Void SetUploadParameterPreset(System.Boolean bValue)
  RVA=0x087D52C8  token=0x6000066  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x087D60AC  token=0x6000067  System.Void Recook()
  RVA=0x03D4EF60  token=0x6000068  System.Boolean IsEditable()
  RVA=0x03D4F7E0  token=0x6000069  System.Boolean IsGeoCurve()
  RVA=0x087D6360  token=0x600006A  System.Void SetCurveName(System.String name)
  RVA=0x087D6678  token=0x600006B  System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset)
  RVA=0x087D6534  token=0x600006C  System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  RVA=0x087D63E0  token=0x600006D  System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset)
  RVA=0x087D4BB0  token=0x600006E  UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex)
  RVA=0x03D4EB40  token=0x600006F  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms()
  RVA=0x087D4978  token=0x6000070  System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints()
  RVA=0x087D4D38  token=0x6000071  System.Int32 GetNumPoints()
  RVA=0x087D5650  token=0x6000072  System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  RVA=0x087D55A8  token=0x6000073  System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  RVA=0x087D3710  token=0x6000074  System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  RVA=0x087D3674  token=0x6000075  System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  RVA=0x087D6118  token=0x6000076  System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset)
  RVA=0x087D3808  token=0x6000077  System.Void ClearCurveNodeData(System.Boolean bRecookAsset)
  RVA=0x087D6058  token=0x6000078  System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset)
  RVA=0x087D632C  token=0x6000079  System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset)
  RVA=0x087D535C  token=0x600007A  UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex)
  RVA=0x087D5424  token=0x600007B  System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints()
  RVA=0x087D3F54  token=0x600007C  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData()
  RVA=0x087D3894  token=0x600007D  HoudiniEngineUnity.HEU_Curve CreateSetupCurve(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean isEditable, System.String curveName, System.Int32 geoID, System.Int32 partID, System.Boolean bGeoCurve)
  RVA=0x087D7D0C  token=0x600007E  System.Void UsePreviousCurveData(System.String curveName)
  RVA=0x087D4B68  token=0x600007F  HoudiniEngineUnity.HEU_CurveDataType GetCurveDataType(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D674C  token=0x6000080  System.Boolean ShouldKeepNode(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D3C30  token=0x6000081  System.Void DestroyAllData(System.Boolean bIsRebuild)
  RVA=0x087D7BA8  token=0x6000082  System.Void UploadParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x087D61B0  token=0x6000083  System.Void ResetCurveParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x087D6464  token=0x6000084  System.Void SetCurveParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Byte[] parameterPreset)
  RVA=0x087D7228  token=0x6000085  System.Void UpdateCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId)
  RVA=0x087D4AF8  token=0x6000086  System.Int32[] GetCurveCounts(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoId, System.Int32 partID)
  RVA=0x087D45A8  token=0x6000087  System.Void GenerateMesh(UnityEngine.GameObject inGameObject, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D4200  token=0x6000088  System.Void GenerateMeshForSingleObject(UnityEngine.GameObject targetObject, UnityEngine.Vector3[] vertexList)
  RVA=0x087D5A60  token=0x6000089  System.Void OnPresyncParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x087D4D78  token=0x600008A  System.Int32 GetOrderForCurveType(System.Int32 requestedOrder, HoudiniEngineUnity.HAPI_CurveType curveType)
  RVA=0x087D6954  token=0x600008B  System.Boolean UpdateCurveInputForCurveParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x087D6E8C  token=0x600008C  System.Boolean UpdateCurveInputForCustomAttributes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x087D67A4  token=0x600008D  System.Void SyncFromParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bNewCurve)
  RVA=0x087D73F8  token=0x600008E  System.Void UpdatePoints(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D5A98  token=0x600008F  System.Void ProjectToCollidersInternal(HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, UnityEngine.Vector3 rayDirection, System.Single rayDistance)
  RVA=0x087D503C  token=0x6000090  System.String GetPointsString(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> points)
  RVA=0x087D4DC4  token=0x6000091  System.String GetPointsString(System.Collections.Generic.List<UnityEngine.Vector3> points)
  RVA=0x03D4EF40  token=0x6000092  System.Void SetEditState(HoudiniEngineUnity.HEU_Curve.CurveEditState editState)
  RVA=0x087D5538  token=0x6000093  UnityEngine.Vector3 GetTransformedPosition(UnityEngine.Vector3 inPosition)
  RVA=0x087D4CC8  token=0x6000094  UnityEngine.Vector3 GetInvertedTransformedPosition(UnityEngine.Vector3 inPosition)
  RVA=0x087D4C58  token=0x6000095  UnityEngine.Vector3 GetInvertedTransformedDirection(UnityEngine.Vector3 inPosition)
  RVA=0x03D4EAC0  token=0x6000096  UnityEngine.Vector3[] GetVertices()
  RVA=0x087D6270  token=0x6000097  System.Void SetCurveGeometryVisibilityInternal(System.Boolean bVisible)
  RVA=0x087D3ED8  token=0x6000098  System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D7C90  token=0x6000099  System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D3E5C  token=0x600009A  System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087D684C  token=0x600009B  System.Void UpdateCachedCurveInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean copyCurveSettings)
  RVA=0x087D4A88  token=0x600009C  System.Int32 GetCurveCountIndexFromPositionIndex(System.Int32 positionIndex)
  RVA=0x087D5A38  token=0x600009D  System.Boolean IsMeshCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x087D5748  token=0x600009E  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Curve other)
  RVA=0x087D7F78  token=0x600009F  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeneratedOutput
TYPE:  class
TOKEN: 0x200002C
SIZE:  0x28
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HEU_GeneratedOutputData_outputData  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutputData>_childOutputs  // 0x18
  private           System.Boolean                  isInstancer  // 0x20
PROPERTIES:
  IsInstancer  get=0x03D4EF90  set=0x03D4EFC0
METHODS:
  RVA=0x087DA24C  token=0x60000AC  System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutput output)
  RVA=0x087DA394  token=0x60000AD  System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  RVA=0x087D9C00  token=0x60000AE  UnityEngine.Material[] GetGeneratedMaterialsForGameObject(HoudiniEngineUnity.HEU_GeneratedOutput output, UnityEngine.GameObject inGameObject)
  RVA=0x087D9DBC  token=0x60000AF  System.Boolean HasLODGroup(HoudiniEngineUnity.HEU_GeneratedOutput output)
  RVA=0x087DA0EC  token=0x60000B0  System.Boolean IsOutputUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutput output)
  RVA=0x087D9F80  token=0x60000B1  System.Boolean IsOutputDataUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  RVA=0x087D9398  token=0x60000B2  System.Void ClearGeneratedMaterialReferences(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData)
  RVA=0x087D96C8  token=0x60000B3  System.Void DestroyAllGeneratedColliders(HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  RVA=0x087D9A5C  token=0x60000B4  System.Void DestroyGeneratedOutput(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput)
  RVA=0x087D98A0  token=0x60000B5  System.Void DestroyGeneratedOutputChildren(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput)
  RVA=0x087D9A04  token=0x60000B6  System.Void DestroyGeneratedOutputData(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData, System.Boolean bDontDeletePersistantResources)
  RVA=0x087D93BC  token=0x60000B7  System.Void ClearMaterialsNoLongerUsed(UnityEngine.Material[] materialsToCheck, UnityEngine.Material[] materialsInUse)
  RVA=0x087D948C  token=0x60000B8  System.Void CopyMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData sourceOutputData, HoudiniEngineUnity.HEU_GeneratedOutputData destOutputData)
  RVA=0x087DA44C  token=0x60000B9  System.Void WriteOutputToAssetCache(UnityEngine.GameObject parentObject, System.String outputPath, System.Boolean bIsInstancer)
  RVA=0x087D9250  token=0x60000BA  System.Void BakeGameObjectComponents(UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.String outputPath, System.Boolean bIsInstancer)
  RVA=0x087D9E04  token=0x60000BB  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutput other)
  RVA=0x087DA4BC  token=0x60000BC  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeneratedOutputData
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x28
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.GameObject          _gameObject  // 0x10
  public            UnityEngine.Material[]          _renderMaterials  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Collider>_colliders  // 0x20
METHODS:
  RVA=0x087D9028  token=0x60000BD  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutputData other)
  RVA=0x087D91D8  token=0x60000BE  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeoNode
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x78
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_GeoNode HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent UnityEngine.ISerializationCallbackReceiver HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           HoudiniEngineUnity.HAPI_GeoInfo _geoInfo  // 0x18
  private           System.String                   _geoName  // 0x40
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData>_parts  // 0x48
  private           HoudiniEngineUnity.HEU_ObjectNode_containerObjectNode  // 0x50
  private           HoudiniEngineUnity.HEU_InputNode_inputNode  // 0x58
  private           HoudiniEngineUnity.HEU_Curve    _geoCurve  // 0x60
  private           HoudiniEngineUnity.HEU_VolumeCache_volumeCache  // 0x68
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache>_volumeCaches  // 0x70
PROPERTIES:
  ParentAsset  get=0x087DE394
  GeoID  get=0x01003B50
  GeoInfo  get=0x03D65C80
  GeoName  get=0x03D4E2B0
  GeoType  get=0x020D1AC0
  Editable  get=0x03D4F090
  Displayable  get=0x087DE314
  Parts  get=0x03D4EA70
  ObjectNode  get=0x03D4EAF0
  InputNode  get=0x03D4EAA0
  GeoCurve  get=0x03D4EB00
  VolumeCaches  get=0x03D4EB30
METHODS:
  RVA=0x087DE2F4  token=0x60000CB  System.Void .ctor()
  RVA=0x0350B670  token=0x60000CC  System.Void OnBeforeSerialize()
  RVA=0x087DC550  token=0x60000CD  System.Void OnAfterDeserialize()
  RVA=0x087DBC98  token=0x60000CE  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x087DD660  token=0x60000CF  System.Void Recook()
  RVA=0x087DC534  token=0x60000D0  System.Boolean IsVisible()
  RVA=0x086E1564  token=0x60000D1  System.Boolean IsIntermediate()
  RVA=0x087DC3F0  token=0x60000D2  System.Boolean IsIntermediateOrEditable()
  RVA=0x087DC3DC  token=0x60000D3  System.Boolean IsGeoInputType()
  RVA=0x059BC74C  token=0x60000D4  System.Boolean IsGeoCurveType()
  RVA=0x087DA8B4  token=0x60000D5  System.Void DestroyAllData(System.Boolean bIsRebuild)
  RVA=0x087DD6D4  token=0x60000D6  System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part)
  RVA=0x087DB8C0  token=0x60000D7  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=0x087DB9E4  token=0x60000D8  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=0x087DB768  token=0x60000D9  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=0x087DBB08  token=0x60000DA  HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID)
  RVA=0x087DB1CC  token=0x60000DB  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  RVA=0x03D4EA70  token=0x60000DC  System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts()
  RVA=0x087DBFC8  token=0x60000DD  System.Void HideAllGeometry()
  RVA=0x087DAC14  token=0x60000DE  System.Void DisableAllColliders()
  RVA=0x087DBD3C  token=0x60000DF  HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex)
  RVA=0x087DD738  token=0x60000E0  System.Void Reset()
  RVA=0x087DC05C  token=0x60000E1  System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo, HoudiniEngineUnity.HEU_ObjectNode containerObjectNode)
  RVA=0x087DACA8  token=0x60000E2  System.Boolean DoesThisRequirePotentialCook()
  RVA=0x087DDF6C  token=0x60000E3  System.Void UpdateGeo(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DCFD4  token=0x60000E4  System.Void ProcessUnityScriptAttribute(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DC83C  token=0x60000E5  System.Void ProcessPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData& partData)
  RVA=0x087DDA94  token=0x60000E6  System.Void SetupGameObjectAndTransform(HoudiniEngineUnity.HEU_PartData partData, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x087DBBB8  token=0x60000E7  System.Void GetPartsByOutputType(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts)
  RVA=0x087DAE68  token=0x60000E8  System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DACF0  token=0x60000E9  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DC644  token=0x60000EA  System.Void ProcessGeoCurve(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DDD44  token=0x60000EB  System.Void SetupGeoCurveGameObjectAndTransform(HoudiniEngineUnity.HEU_Curve curve)
  RVA=0x087DA82C  token=0x60000EC  System.Void ClearObjectInstances()
  RVA=0x087DDA10  token=0x60000ED  System.Void SetGeoInfo(HoudiniEngineUnity.HAPI_GeoInfo geoInfo)
  RVA=0x087DAD90  token=0x60000EE  System.String GeneratePartFullName(System.String partName)
  RVA=0x03D4E2B0  token=0x60000EF  System.String GenerateGeoCurveName()
  RVA=0x087DBF90  token=0x60000F0  System.Boolean HasGeoNodeChanged(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DA568  token=0x60000F1  System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform)
  RVA=0x087DB3C8  token=0x60000F2  System.Void GetDebugInfo(System.Text.StringBuilder sb)
  RVA=0x087DC408  token=0x60000F3  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  RVA=0x087DB0A8  token=0x60000F4  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  RVA=0x087DBE78  token=0x60000F5  System.Boolean HasAttribInstancer()
  RVA=0x087DD7E8  token=0x60000F6  System.Void SetAttributeModifiersOnPartOutputs(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087DA71C  token=0x60000F7  System.Void CalculateVisiblity(System.Boolean bParentVisibility)
  RVA=0x087DA68C  token=0x60000F8  System.Void CalculateColliderState()
  RVA=0x087DD188  token=0x60000F9  System.Void ProcessVolumeParts(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Boolean bRebuild)
  RVA=0x087DAA8C  token=0x60000FA  System.Void DestroyVolumeCache()
  RVA=0x087DDF10  token=0x60000FB  System.String ToString()
  RVA=0x087DC178  token=0x60000FC  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeoNode other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniAsset
TYPE:  sealed class
TOKEN: 0x200002F
SIZE:  0x268
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: HoudiniEngineUnity.IHEU_HoudiniAsset HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType_assetType  // 0x18
  private           HoudiniEngineUnity.HAPI_AssetInfo_assetInfo  // 0x1c
  private           HoudiniEngineUnity.HAPI_NodeInfo_nodeInfo  // 0x5c
  private           System.String                   _assetName  // 0xa0
  private           System.String                   _assetOpName  // 0xa8
  private           System.String                   _assetHelp  // 0xb0
  private           System.Int32                    _assetID  // 0xb8
  private           System.String                   _assetPath  // 0xc0
  private           System.Boolean                  _loadAssetFromMemory  // 0xc8
  private           System.Boolean                  _alwaysOverwriteOnLoad  // 0xc9
  private           UnityEngine.Object              _assetFileObject  // 0xd0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectNode>_objectNodes  // 0xd8
  private           UnityEngine.GameObject          _rootGameObject  // 0xe0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData>_materialCache  // 0xe8
  private           HoudiniEngineUnity.HEU_Parameters_parameters  // 0xf0
  private           UnityEngine.Matrix4x4           _lastSyncedTransformMatrix  // 0xf8
  private           System.Collections.Generic.List<UnityEngine.Matrix4x4>_lastSyncedChildTransformMatrices  // 0x138
  private           System.String                   _assetCacheFolderPath  // 0x140
  private           System.String[]                 _subassetNames  // 0x148
  private           System.Int32                    _selectedSubassetIndex  // 0x150
  private           HoudiniEngineUnity.HEU_AssetPreset_savedAssetPreset  // 0x158
  private           HoudiniEngineUnity.HEU_RecookPreset_recookPreset  // 0x160
  private           System.Int32                    _totalCookCount  // 0x168
  private           HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction_requestBuildAction  // 0x16c
  private           System.Boolean                  _checkParameterChangeForCook  // 0x170
  private           System.Boolean                  _skipCookCheck  // 0x171
  private           System.Boolean                  _uploadParameters  // 0x172
  private           System.Boolean                  _forceUploadInputs  // 0x173
  private           System.Boolean                  _upstreamCookChanged  // 0x174
  private           HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus_cookStatus  // 0x178
  private           HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult_lastCookResult  // 0x17c
  private           System.Boolean                  _isCookingAssetReloaded  // 0x180
  private           System.Boolean                  _bForceUpdate  // 0x181
  private           System.Int64                    _sessionID  // 0x188
  private           System.Boolean                  <WarnedPrefabNotSupported>k__BackingField  // 0x190
  private           System.Boolean                  _uiLocked  // 0x191
  private           System.Boolean                  _showHDAOptions  // 0x192
  private           System.Boolean                  _showGenerateSection  // 0x193
  private           System.Boolean                  _showBakeSection  // 0x194
  private           System.Boolean                  _showEventsSection  // 0x195
  private           System.Boolean                  _showCurvesSection  // 0x196
  private           System.Boolean                  _showInputNodesSection  // 0x197
  private           System.Boolean                  _showToolsSection  // 0x198
  private           System.Boolean                  _showTerrainSection  // 0x199
  private           HoudiniEngineUnity.HEU_InstanceInputUIState_instanceInputUIState  // 0x1a0
  private           HoudiniEngineUnity.HEU_ReloadDataEvent_reloadDataEvent  // 0x1a8
  private           HoudiniEngineUnity.HEU_CookedDataEvent_cookedDataEvent  // 0x1b0
  private           HoudiniEngineUnity.HEU_BakedDataEvent_bakedDataEvent  // 0x1b8
  private           HoudiniEngineUnity.HEU_PreAssetEvent_preAssetEvent  // 0x1c0
  private           HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate_refreshUIDelegate  // 0x1c8
  private           HoudiniEngineUnity.HEU_CookedDataEvent_downstreamConnectionCookedEvent  // 0x1d0
  private           System.Boolean                  _generateUVs  // 0x1d8
  private           System.Boolean                  _generateTangents  // 0x1d9
  private           System.Boolean                  _generateNormals  // 0x1da
  private           System.Boolean                  _pushTransformToHoudini  // 0x1db
  private           System.Boolean                  _transformChangeTriggersCooks  // 0x1dc
  private           System.Boolean                  _cookingTriggersDownCooks  // 0x1dd
  private           System.Boolean                  _autoCookOnParameterChange  // 0x1de
  private           System.Boolean                  _ignoreNonDisplayNodes  // 0x1df
  private           System.Boolean                  _useOutputNodes  // 0x1e0
  private           System.Boolean                  _generateMeshUsingPoints  // 0x1e1
  private           System.Boolean                  _useLODGroups  // 0x1e2
  private           System.Boolean                  _splitGeosByGroup  // 0x1e3
  private           System.Boolean                  _sessionSyncAutoCook  // 0x1e4
  private           System.Boolean                  _bakeUpdateKeepPreviousTransformValues  // 0x1e5
  private           System.Boolean                  _pauseCooking  // 0x1e6
  private           System.Boolean                  _curveEditorEnabled  // 0x1e7
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve>_curves  // 0x1e8
  private           HoudiniEngineUnity.HEU_Curve.CurveDrawCollision_curveDrawCollision  // 0x1f0
  private           System.Collections.Generic.List<UnityEngine.Collider>_curveDrawColliders  // 0x1f8
  private           UnityEngine.LayerMask           _curveDrawLayerMask  // 0x200
  private           System.Single                   _curveProjectMaxDistance  // 0x204
  private           UnityEngine.Vector3             _curveProjectDirection  // 0x208
  private           System.Boolean                  _curveProjectDirectionToView  // 0x214
  private           System.Boolean                  _curveDisableScaleRotation  // 0x215
  private           System.Boolean                  _curveCookOnDrag  // 0x216
  private           System.Boolean                  _curveFrameSelectedNodes  // 0x217
  private           System.Single                   _curveFrameSelectedNodeDistance  // 0x218
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode>_inputNodes  // 0x220
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle>_handles  // 0x228
  private           System.Boolean                  _handlesEnabled  // 0x230
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache>_volumeCaches  // 0x238
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore>_attributeStores  // 0x240
  private           System.Boolean                  _editableNodesToolsEnabled  // 0x248
  private           HoudiniEngineUnity.HEU_ToolsInfo_toolsInfo  // 0x250
  private           HoudiniEngineUnity.HEU_AssetSerializedMetaData_serializedMetaData  // 0x258
  private           System.Boolean                  _pendingAutoCookOnMouseRelease  // 0x260
PROPERTIES:
  LoadAssetFromMemory  get=0x03D519D0  set=0x03D57500
  AlwaysOverwriteOnLoad  get=0x03D58400  set=0x03D6D220
  GenerateUVs  get=0x03D57B10  set=0x03D5A480
  GenerateTangents  get=0x03D6D180  set=0x03D6D320
  GenerateNormals  get=0x03D6D170  set=0x03D6D310
  PushTransformToHoudini  get=0x03D6D1E0  set=0x03D6D360
  TransformChangeTriggersCooks  get=0x03D6D200  set=0x03D6D390
  CookingTriggersDownCooks  get=0x03D5C290  set=0x03D6D250
  AutoCookOnParameterChange  get=0x03D6D100  set=0x03D6D230
  IgnoreNonDisplayNodes  get=0x03D6D190  set=0x03D6D340
  UseOutputNodes  get=0x03D58E20  set=0x03D6D3B0
  GenerateMeshUsingPoints  get=0x03D6D160  set=0x03D6D300
  UseLODGroups  get=0x03D6D210  set=0x03D6D3A0
  SplitGeosByGroup  get=0x03D5ACA0  set=0x03D6D380
  SessionSyncAutoCook  get=0x03D56B40  set=0x03D6D370
  BakeUpdateKeepPreviousTransformValues  get=0x03D5ACB0  set=0x03D6D240
  PauseCooking  get=0x03D6D1D0  set=0x03D6D350
  CurveEditorEnabled  get=0x03D5ACD0  set=0x03D6D280
  CurveDrawCollision  get=0x087EF07C  set=0x087EF0B0
  CurveDrawLayerMask  get=0x03D5A250  set=0x03D5A290
  CurveProjectMaxDistance  get=0x03D59A40  set=0x03D6D2E0
  CurveProjectDirection  get=0x03D5AD60  set=0x03D6D2C0
  CurveProjectDirectionToView  get=0x03D6D150  set=0x03D6D2B0
  CurveDisableScaleRotation  get=0x03D6D120  set=0x03D6D270
  CurveFrameSelectedNodes  get=0x03D6D140  set=0x03D6D2A0
  CurveFrameSelectedNodeDistance  get=0x03D59960  set=0x03D6D290
  HandlesEnabled  get=0x03D57C20  set=0x03D6D330
  EditableNodesToolsEnabled  get=0x03D5BEE0  set=0x03D6D2F0
  AssetType  get=0x087EF040
  AssetInfo  get=0x03D6D0D0
  NodeInfo  get=0x03D6D1A0
  AssetName  get=0x03D4EA80
  AssetOpName  get=0x03D4EB10
  AssetHelp  get=0x03D4EAD0
  AssetID  get=0x03D57DA0
  AssetPath  get=0x03D50E60
  OwnerGameObject  get=0x0426FB4C
  RootGameObject  get=0x03D51140
  MaterialCache  get=0x03D50EA0
  Parameters  get=0x03D51950
  AssetCacheFolder  get=0x03D57300
  SubassetNames  get=0x03D571B0
  SelectedSubassetIndex  get=0x03D6D1F0
  CookStatus  get=0x087EF06C
  LastCookResult  get=0x087EF08C
  SessionID  get=0x03D56AF0
  Curves  get=0x03D50350
  InputNodes  get=0x03D57430
  VolumeCaches  get=0x03D57220
  ReloadDataEvent  get=0x03D57170
  CookedDataEvent  get=0x03D57160
  BakedDataEvent  get=0x03D57130
  PreAssetEvent  get=0x03D571E0
  AssetTypeInternal  get=0x020D1AC0
  WarnedPrefabNotSupported  get=0x03D57C30  set=0x03D5A070
  InstanceInputUIState  get=0x03D56AD0  set=0x04275BD4
  RefreshUIDelegate  get=0x03D571D0  set=0x04275C7C
  CurveDrawCollisionInternal  get=0x03D6D130
  CurveCookOnDrag  get=0x03D6D110  set=0x03D6D260
  Handles  get=0x03D57480
  AttributeStores  get=0x03D56B10
  ToolsInfo  get=0x03D57350
  SerializedMetaData  get=0x03D57440
  PendingAutoCookOnMouseRelease  get=0x03D57B60  set=0x03D59550
METHODS:
  RVA=0x03D6D0A0  token=0x600014F  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus GetCookStatus()
  RVA=0x03D5DB50  token=0x6000150  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult GetLastCookResult()
  RVA=0x03D50340  token=0x6000158  System.Collections.Generic.List<UnityEngine.Collider> GetCurveDrawColliders()
  RVA=0x03D5A250  token=0x6000159  UnityEngine.LayerMask GetCurveDrawLayerMask()
  RVA=0x03D5A290  token=0x600015A  System.Void SetCurveDrawLayerMask(UnityEngine.LayerMask mask)
  RVA=0x0232EB60  token=0x6000163  System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters)
  RVA=0x0232EB60  token=0x6000164  System.Boolean RequestReload(System.Boolean bAsync)
  RVA=0x0232EB60  token=0x6000165  System.Boolean RequestResetParameters(System.Boolean bAsync)
  RVA=0x087E3DE4  token=0x6000166  UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject)
  RVA=0x087E312C  token=0x6000167  System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild)
  RVA=0x087E02A8  token=0x6000168  UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath)
  RVA=0x087E05BC  token=0x6000169  UnityEngine.GameObject BakeToNewStandalone()
  RVA=0x087DF054  token=0x600016A  System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO)
  RVA=0x087DF6CC  token=0x600016B  System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO)
  RVA=0x087E8DA0  token=0x600016C  System.Boolean IsAssetValid()
  RVA=0x087E7518  token=0x600016D  System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=0x087E7768  token=0x600016E  System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=0x087E5E20  token=0x600016F  HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName)
  RVA=0x087DE554  token=0x6000170  System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider)
  RVA=0x087EB6D0  token=0x6000171  System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider)
  RVA=0x087E0F1C  token=0x6000172  System.Boolean ClearCurveDrawColliders()
  RVA=0x087E64B8  token=0x6000173  HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName)
  RVA=0x087E5204  token=0x6000174  HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName)
  RVA=0x087E6444  token=0x6000175  HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index)
  RVA=0x087E6AE8  token=0x6000176  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes()
  RVA=0x087E7B84  token=0x6000177  System.Int32 GetVolumeCacheCount()
  RVA=0x087E5B14  token=0x6000178  HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid)
  RVA=0x087E6F68  token=0x6000179  HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName)
  RVA=0x087E7640  token=0x600017A  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes)
  RVA=0x087E6830  token=0x600017B  HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=0x087EC34C  token=0x600017C  System.Void ResetParametersToDefault()
  RVA=0x087E8178  token=0x600017D  System.Void HideAllGeometry()
  RVA=0x087E3420  token=0x600017E  System.Void DisableAllColliders()
  RVA=0x087E698C  token=0x600017F  HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material)
  RVA=0x087E1378  token=0x6000180  System.Void ClearMaterialCache()
  RVA=0x087EB834  token=0x6000181  System.Void RemoveMaterial(UnityEngine.Material material)
  RVA=0x087EC1F0  token=0x6000182  System.Void ResetMaterialOverrides()
  RVA=0x087E534C  token=0x6000183  HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset()
  RVA=0x087E73B0  token=0x6000184  HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink()
  RVA=0x087E8298  token=0x6000185  HoudiniEngineUnity.HEU_HoudiniAssetRoot InstantiateHDA(System.String filePath, System.Boolean bAsync, UnityEngine.Vector3 initialPosition)
  RVA=0x087E79B0  token=0x6000186  HoudiniEngineUnity.HEU_PartData GetSceneHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=0x087E7890  token=0x6000187  HoudiniEngineUnity.HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(UnityEngine.GameObject outputGameObject)
  RVA=0x087E9D5C  token=0x6000188  System.Boolean IsHoudiniAssetOutput(UnityEngine.GameObject go)
  RVA=0x087E9E88  token=0x6000189  System.Boolean IsHoudiniAssetRoot(UnityEngine.GameObject go)
  RVA=0x087ECAD8  token=0x600018A  System.Void SetupAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String filePath, UnityEngine.GameObject rootGameObject, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E0944  token=0x600018B  System.Void CleanUpAndDisable()
  RVA=0x087E8D50  token=0x600018C  System.Boolean IsAssetSavedInScene()
  RVA=0x0350B670  token=0x600018D  System.Void Awake()
  RVA=0x03D6D0B0  token=0x600018E  System.Void InvalidateAsset()
  RVA=0x0350B670  token=0x600018F  System.Void OnEnable()
  RVA=0x0350B670  token=0x6000190  System.Void OnDestroy()
  RVA=0x0350B670  token=0x6000191  System.Void AssetUpdate()
  RVA=0x0350B670  token=0x6000192  System.Void PostAssetUpdate()
  RVA=0x087EBF20  token=0x6000193  System.Void RequestBakeInPlace()
  RVA=0x03D6D080  token=0x6000194  System.Void ClearBuildRequest()
  RVA=0x087E8160  token=0x6000195  System.Boolean HasValidAssetPath()
  RVA=0x087EAFF4  token=0x6000196  System.Void ProcessRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex)
  RVA=0x087E8C94  token=0x6000197  System.Void InvokeReloadEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=0x087ECEF0  token=0x6000198  System.Boolean StartRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex)
  RVA=0x087E4200  token=0x6000199  System.Boolean FinishRebuild()
  RVA=0x087EB36C  token=0x600019A  System.Boolean RecookAsync(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync)
  RVA=0x087EB48C  token=0x600019B  System.Boolean RecookBlocking(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync)
  RVA=0x087E35C8  token=0x600019C  System.Void DoPostCookWork(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E9EF4  token=0x600019D  System.Boolean IsValidForInteraction(System.String& errorMessage)
  RVA=0x087EA8DC  token=0x600019E  System.Void OnValidate()
  RVA=0x087E4164  token=0x600019F  System.Void ExecutePostCookCallbacks()
  RVA=0x087E8BD8  token=0x60001A0  System.Void InvokePostCookEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=0x087E84B0  token=0x60001A1  System.Boolean InternalStartRecook(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync)
  RVA=0x087E8358  token=0x60001A2  System.Void InternalSetAssetID(System.Int32 assetID)
  RVA=0x03D6D0C0  token=0x60001A3  System.Void SetCookStatus(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus status, HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult result)
  RVA=0x087EAC18  token=0x60001A4  System.Void ProcessPoskCook()
  RVA=0x087ECECC  token=0x60001A5  System.Boolean StartHoudiniCookNode(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EAA68  token=0x60001A6  System.Void ProcessHoudiniCookStatus(System.Boolean bAsync)
  RVA=0x087E390C  token=0x60001A7  System.Boolean DoesAssetRequireRecook()
  RVA=0x087E340C  token=0x60001A8  System.Void DeleteSessionDataOnly()
  RVA=0x087E0ABC  token=0x60001A9  System.Void CleanUpInputNodes()
  RVA=0x087E33BC  token=0x60001AA  System.Void DeleteAssetCacheData(System.Boolean bRegisterUndo)
  RVA=0x087E4FF0  token=0x60001AB  System.Void GenerateParameters(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E3D60  token=0x60001AC  System.Void DownloadParameterPresetFromHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EEB74  token=0x60001AD  System.Void UploadParameterPresetToHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EDEA0  token=0x60001AE  System.Void UpdateParameterInputsToHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate)
  RVA=0x087E9F64  token=0x60001AF  System.Boolean LoadAssetFileWithSubasset(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex)
  RVA=0x087E2A90  token=0x60001B0  System.Boolean CreateAndCookAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 subassetIndex, System.Int32& newAssetID, System.Boolean bCookTemplatedGeos)
  RVA=0x087E2BB8  token=0x60001B1  System.Void CreateAssetInputs(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E4818  token=0x60001B2  System.Void ForceUploadParameters(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EE548  token=0x60001B3  System.Void UploadCurvesParameters(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bCheckParamsChanged)
  RVA=0x087EDFA4  token=0x60001B4  System.Void UploadAttributeValues(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087ED14C  token=0x60001B5  System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EE9A4  token=0x60001B6  System.Void UploadInputNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate, System.Boolean bUpdateAll)
  RVA=0x087E7D6C  token=0x60001B7  System.Boolean HasInputNodeTransformChanged()
  RVA=0x087EA708  token=0x60001B8  System.Void NotifyInputNodesCookFinished()
  RVA=0x087E2FF0  token=0x60001B9  System.Boolean CreateObjects(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087ED464  token=0x60001BA  System.Void UpdateAllObjectNodes(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E2F0C  token=0x60001BB  HoudiniEngineUnity.HEU_ObjectNode CreateObjectNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo, HoudiniEngineUnity.HAPI_Transform& objectTranform)
  RVA=0x087E4EB8  token=0x60001BC  System.Void GenerateObjectsGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild)
  RVA=0x087EA854  token=0x60001BD  System.Int32 NumAttributeStores()
  RVA=0x087E5B8C  token=0x60001BE  HoudiniEngineUnity.HEU_AttributesStore GetAttributeStore(System.String geoName, System.Int32 partID)
  RVA=0x087E484C  token=0x60001BF  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E4B3C  token=0x60001C0  System.Void GenerateInstances(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E4974  token=0x60001C1  System.Void GenerateHandles(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E09BC  token=0x60001C2  System.Void CleanUpHandles()
  RVA=0x087E60C4  token=0x60001C3  HoudiniEngineUnity.HEU_Handle GetHandleByName(System.String handleName)
  RVA=0x03D57480  token=0x60001C4  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> GetHandles()
  RVA=0x087EA898  token=0x60001C5  System.Int32 NumHandles()
  RVA=0x087E7238  token=0x60001C6  HoudiniEngineUnity.HAPI_Transform GetObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectID)
  RVA=0x087E72F4  token=0x60001C7  HoudiniEngineUnity.HEU_ObjectNode GetObjectWithID(System.Int32 objId)
  RVA=0x087E8B18  token=0x60001C8  System.Void InvokeBakedEvent(System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake)
  RVA=0x087E13C0  token=0x60001C9  UnityEngine.GameObject CloneAssetWithoutHDA(System.String& bakedAssetPath, System.Boolean bWriteMeshesToAssetDatabase, System.Boolean bReconnectPrefabInstances)
  RVA=0x087EA820  token=0x60001CA  System.Void NotifyUpstreamCooked(HoudiniEngineUnity.HEU_CookedEventData Data)
  RVA=0x087E18F4  token=0x60001CB  System.Void ConnectToUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset)
  RVA=0x087E3538  token=0x60001CC  System.Void DisconnectFromUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset)
  RVA=0x087DE660  token=0x60001CD  System.Void AddDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver)
  RVA=0x087EB784  token=0x60001CE  System.Void RemoveDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver)
  RVA=0x087E0CE4  token=0x60001CF  System.Void ClearAllUpstreamConnections()
  RVA=0x087EDD78  token=0x60001D0  System.Void UpdateInputsOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EB22C  token=0x60001D1  System.Void ReconnectInputsUpstreamNotifications()
  RVA=0x087E6200  token=0x60001D2  System.Void GetHoudiniTransformAndApply(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EED58  token=0x60001D3  System.Void UploadUnityTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bOnlySendIfChangedFromLastSync)
  RVA=0x087EDB98  token=0x60001D4  System.Void UpdateHoudiniMaterials(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087EB94C  token=0x60001D5  System.Void RemoveUnusedMaterials()
  RVA=0x087E8D6C  token=0x60001D6  System.Boolean IsAssetValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087E7EBC  token=0x60001D7  System.Boolean HasTransformChangedSinceLastUpdate()
  RVA=0x087E5CEC  token=0x60001D8  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  RVA=0x087E0F68  token=0x60001D9  System.Void ClearInvalidCurves()
  RVA=0x087E5F8C  token=0x60001DA  System.Int32 GetEditableCurveCount()
  RVA=0x087DE5DC  token=0x60001DB  System.Void AddCurve(HoudiniEngineUnity.HEU_Curve curve)
  RVA=0x087EB72C  token=0x60001DC  System.Void RemoveCurve(HoudiniEngineUnity.HEU_Curve curve)
  RVA=0x03D57430  token=0x60001DD  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetInputNodes()
  RVA=0x087DE6E0  token=0x60001DE  System.Void AddInputNode(HoudiniEngineUnity.HEU_InputNode node)
  RVA=0x087EB7DC  token=0x60001DF  System.Void RemoveInputNode(HoudiniEngineUnity.HEU_InputNode node)
  RVA=0x087E8290  token=0x60001E0  System.Void InputNodeNotifyRemoved(HoudiniEngineUnity.HEU_InputNode node)
  RVA=0x087DE7D0  token=0x60001E1  System.Void AddVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache)
  RVA=0x087EBD98  token=0x60001E2  System.Void RemoveVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache)
  RVA=0x087DE400  token=0x60001E3  System.Void AddAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore)
  RVA=0x087EB678  token=0x60001E4  System.Void RemoveAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore)
  RVA=0x087EBE1C  token=0x60001E5  System.Void ReorderAttributeStore(System.Int32 oldIndex, System.Int32 newIndex)
  RVA=0x087EA910  token=0x60001E6  System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos)
  RVA=0x087DE764  token=0x60001E7  System.Void AddToAssetDBCache(System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, UnityEngine.Object& targetAssetDBObject)
  RVA=0x087EC730  token=0x60001E8  System.Void SetCurvesVisibilityInScene(System.Boolean bShow)
  RVA=0x087E7AEC  token=0x60001E9  System.String GetValidAssetCacheFolderPath()
  RVA=0x087E082C  token=0x60001EA  System.Void CalculateVisibility()
  RVA=0x087E0714  token=0x60001EB  System.Void CalculateColliderState()
  RVA=0x087EA240  token=0x60001EC  System.Void LoadAssetPresetAndCook(HoudiniEngineUnity.HEU_AssetPreset assetPreset)
  RVA=0x087DEB6C  token=0x60001ED  System.Void ApplyRecookPreset()
  RVA=0x087DE854  token=0x60001EE  System.Boolean ApplyInputPresets(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> inputPresets, System.Boolean bAddMissingInputsToRecookPreset)
  RVA=0x087E7BC8  token=0x60001EF  HoudiniEngineUnity.HEU_VolumeCachePreset GetVolumeCachePreset(System.String objName, System.String geoName, System.Int32 tile)
  RVA=0x087EBD34  token=0x60001F0  System.Void RemoveVolumeCachePreset(HoudiniEngineUnity.HEU_VolumeCachePreset preset)
  RVA=0x087DEC0C  token=0x60001F1  System.Boolean ApplyVolumeCachePresets(System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> volumeCachePresets)
  RVA=0x087ED294  token=0x60001F2  System.Void SyncInternalParametersForUndoCompare()
  RVA=0x087EDF38  token=0x60001F3  System.Boolean UpdateSessionSync()
  RVA=0x087EDF90  token=0x60001F4  System.Void UpdateTotalCookCount()
  RVA=0x087EBF34  token=0x60001F5  System.Void ResetAndCopyInstantiatedProperties(HoudiniEngineUnity.HEU_HoudiniAsset newAsset)
  RVA=0x087E6688  token=0x60001F6  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod GetInstantiationMethod()
  RVA=0x087E65FC  token=0x60001F7  HoudiniEngineUnity.HEU_HoudiniAsset GetInstantiatedObject()
  RVA=0x087E1090  token=0x60001F8  System.Void ClearInvalidLists()
  RVA=0x087E1984  token=0x60001F9  System.Void CopyPropertiesTo(HoudiniEngineUnity.HEU_HoudiniAsset newAsset)
  RVA=0x087EC900  token=0x60001FA  System.Void SetSoftDeleted()
  RVA=0x087ED068  token=0x60001FB  System.Void SyncChildTransforms()
  RVA=0x087DEFE4  token=0x60001FC  HoudiniEngineUnity.HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus assetCookStatus)
  RVA=0x087DEFE4  token=0x60001FD  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus AssetCookStatus_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookStatusWrapper assetCookStatus)
  RVA=0x087DEFC4  token=0x60001FE  HoudiniEngineUnity.HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult assetCookResult)
  RVA=0x087DEFC4  token=0x60001FF  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult AssetCookResult_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookResultWrapper assetCookResult)
  RVA=0x087E3104  token=0x6000200  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HoudiniEngineUnity.HEU_Curve.CurveDrawCollision curveDrawCollision)
  RVA=0x087E311C  token=0x6000201  HoudiniEngineUnity.HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper curveDrawCollision)
  RVA=0x087DF02C  token=0x6000202  HoudiniEngineUnity.HEU_AssetTypeWrapper AssetType_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType)
  RVA=0x087DF02C  token=0x6000203  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType AssetType_WrapperToInternal(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType)
  RVA=0x087E8DDC  token=0x6000204  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x087EEDC4  token=0x6000205  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniAssetRoot
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           HoudiniEngineUnity.HEU_HoudiniAsset_houdiniAsset  // 0x18
  private           System.Collections.Generic.List<UnityEngine.GameObject>_bakeTargets  // 0x20
PROPERTIES:
  HoudiniAsset  get=0x01041090
  BakeTargets  get=0x03D4EB40
METHODS:
  RVA=0x087F4614  token=0x600021A  System.Void OnDestroy()
  RVA=0x087F46B8  token=0x600021B  System.Void RemoveHoudiniEngineAssetData()
  RVA=0x087F45B0  token=0x600021C  System.Void ClearHoudiniEngineReferences()
  RVA=0x087F4604  token=0x600021D  System.Void DestroyRootComponent(HoudiniEngineUnity.HEU_HoudiniAssetRoot assetRoot)
  RVA=0x087F4764  token=0x600021E  System.Void Reset()
  RVA=0x087F4820  token=0x600021F  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputNode
TYPE:  class
TOKEN: 0x200003A
SIZE:  0xA8
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_InputNode HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           HoudiniEngineUnity.HEU_InputNode.InputNodeType_inputNodeType  // 0x18
  private           HoudiniEngineUnity.HEU_InputNode.InputObjectType_inputObjectType  // 0x1c
  private           HoudiniEngineUnity.HEU_InputNode.InputObjectType_pendingInputObjectType  // 0x20
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo>_inputObjects  // 0x28
  private           System.Collections.Generic.List<System.Int32>_inputObjectsConnectedAssetIDs  // 0x30
  private           UnityEngine.GameObject          _inputAsset  // 0x38
  private           UnityEngine.GameObject          _connectedInputAsset  // 0x40
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo>_inputAssetInfos  // 0x48
  private           System.Int32                    _nodeID  // 0x50
  private           System.Int32                    _inputIndex  // 0x54
  private           System.Boolean                  _requiresCook  // 0x58
  private           System.Boolean                  _requiresUpload  // 0x59
  private           System.String                   _inputName  // 0x60
  private           System.String                   _labelName  // 0x68
  private           System.String                   _paramName  // 0x70
  private           System.Int32                    _connectedNodeID  // 0x78
  private           System.Boolean                  _keepWorldTransform  // 0x7c
  private           System.Boolean                  _packGeometryBeforeMerging  // 0x7d
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x80
  private           HoudiniEngineUnity.HEU_InputInterfaceMeshSettings_meshSettings  // 0x88
  private           HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings_tilemapSettings  // 0x90
  private           System.Boolean                  _usingSelectFromHierarchy  // 0x98
  public            HoudiniEngineUnity.HEU_InputNodeUICache_uiCache  // 0xa0
PROPERTIES:
  ParentAsset  get=0x03D4EAE0
  KeepWorldTransform  get=0x03D58A60  set=0x03D58A90
  PackGeometryBeforeMerging  get=0x03D6CFA0  set=0x03D6D3E0
  NodeType  get=0x087F9420
  ObjectType  get=0x087F9440
  PendingObjectType  get=0x087F944C  set=0x087F9458
  InputNodeID  get=0x03D4EED0
  InputName  get=0x03D4EB00
  LabelName  get=0x03D4EAB0
  ParamName  get=0x03D4EB30
  MeshSettings  get=0x03D4EA60
  TilemapSettings  get=0x03D4EA90
  InputType  get=0x020D1AC0
  InputObjects  get=0x03D4EAC0
  InputAssetInfos  get=0x03D4EA70
  RequiresCook  get=0x03D4F7E0  set=0x03D4F7F0
  RequiresUpload  get=0x03D589D0  set=0x03D5B3E0
METHODS:
  RVA=0x087F5DBC  token=0x6000236  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x087F7A8C  token=0x6000237  System.Void Recook()
  RVA=0x062FD96C  token=0x6000238  System.Boolean IsAssetInput()
  RVA=0x087F71D4  token=0x6000239  System.Int32 NumInputEntries()
  RVA=0x087F5A0C  token=0x600023A  UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index)
  RVA=0x087F5C20  token=0x600023B  UnityEngine.GameObject[] GetInputEntryGameObjects()
  RVA=0x087F8254  token=0x600023C  System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  RVA=0x087F64D0  token=0x600023D  System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  RVA=0x087F4A80  token=0x600023E  System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset)
  RVA=0x087F7DD8  token=0x600023F  System.Void ResetInputNode(System.Boolean bRecookAsset)
  RVA=0x087F4C60  token=0x6000240  System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset)
  RVA=0x087F7B60  token=0x6000241  System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset)
  RVA=0x087F7AF8  token=0x6000242  System.Void RemoveAllInputEntries(System.Boolean bRecookAsset)
  RVA=0x087F819C  token=0x6000243  System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset)
  RVA=0x087F80D8  token=0x6000244  System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset)
  RVA=0x087F7F48  token=0x6000245  System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset)
  RVA=0x087F8010  token=0x6000246  System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset)
  RVA=0x087F4B20  token=0x6000247  System.Boolean AreAnyInputHDAsConnected()
  RVA=0x087F58DC  token=0x6000248  System.Int32 GetConnectedInputCount()
  RVA=0x087F5950  token=0x6000249  System.Int32 GetConnectedNodeID(System.Int32 index)
  RVA=0x087F6BE8  token=0x600024A  System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
  RVA=0x087F7248  token=0x600024B  System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
  RVA=0x087F5404  token=0x600024C  HoudiniEngineUnity.HEU_InputNode CreateSetupInput(System.Int32 nodeID, System.Int32 inputIndex, System.String inputName, System.String labelName, HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x03D4EF20  token=0x600024D  System.Void SetInputNodeID(System.Int32 nodeID)
  RVA=0x087F54B8  token=0x600024E  System.Void DestroyAllData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F7E68  token=0x600024F  System.Void ResetInputObjectTransforms()
  RVA=0x087F7E1C  token=0x6000250  System.Void ResetInputNode(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F4A44  token=0x6000251  HoudiniEngineUnity.HEU_InputObjectInfo AddInputEntryAtEndMesh(UnityEngine.GameObject newEntryGameObject)
  RVA=0x087F4A08  token=0x6000252  HoudiniEngineUnity.HEU_InputHDAInfo AddInputEntryAtEndHDA(UnityEngine.GameObject newEntryGameObject)
  RVA=0x087F4CC8  token=0x6000253  System.Void ChangeInputType(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode.InputObjectType newType)
  RVA=0x087F7D88  token=0x6000254  System.Void ResetConnectionForForceUpdate(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F88A0  token=0x6000255  System.Void UploadInput(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F861C  token=0x6000256  System.Void UploadHDAInput(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F8D58  token=0x6000257  System.Void UploadUnityInput(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F7860  token=0x6000258  System.Void ReconnectToUpstreamAsset()
  RVA=0x087F5390  token=0x6000259  HoudiniEngineUnity.HEU_InputObjectInfo CreateInputObjectInfo(UnityEngine.GameObject inputGameObject)
  RVA=0x087F5328  token=0x600025A  HoudiniEngineUnity.HEU_InputHDAInfo CreateInputHDAInfo(UnityEngine.GameObject inputGameObject)
  RVA=0x087F6798  token=0x600025B  HoudiniEngineUnity.HEU_InputObjectInfo InternalAddInputObjectAtEnd(UnityEngine.GameObject newInputGameObject)
  RVA=0x087F672C  token=0x600025C  HoudiniEngineUnity.HEU_InputHDAInfo InternalAddInputHDAAtEnd(UnityEngine.GameObject newInputHDA)
  RVA=0x087F568C  token=0x600025D  System.Void DisconnectConnectedMergeNode(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F4CF8  token=0x600025E  System.Void ClearConnectedInputHDAs()
  RVA=0x087F4EDC  token=0x600025F  System.Void ConnectToMergeObject(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F54FC  token=0x6000260  System.Void DisconnectAndDestroyInputs(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F8CCC  token=0x6000261  System.Boolean UploadObjectMergeTransformType(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F8C40  token=0x6000262  System.Boolean UploadObjectMergePackGeometry(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F6014  token=0x6000263  System.Boolean HasInputNodeTransformChanged()
  RVA=0x087F8744  token=0x6000264  System.Void UploadInputObjectTransforms(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F84B0  token=0x6000265  System.Void UpdateOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F4F80  token=0x6000266  System.Void CopyInputValuesTo(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode destInputNode)
  RVA=0x087F6C20  token=0x6000267  System.Void LoadPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputPreset inputPreset)
  RVA=0x087F57C0  token=0x6000268  System.Boolean FindAddToInputHDA(System.String gameObjectName)
  RVA=0x087F715C  token=0x6000269  System.Void NotifyParentRemovedInput()
  RVA=0x087F4EC4  token=0x600026A  System.Void ClearUICache()
  RVA=0x087F5F34  token=0x600026B  System.Void HandleSelectedObjectsForInputObjects(UnityEngine.GameObject[] selectedObjects)
  RVA=0x087F5E54  token=0x600026C  System.Void HandleSelectedObjectsForInputHDAs(UnityEngine.GameObject[] selectedObjects)
  RVA=0x087F6804  token=0x600026D  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputNode other)
  RVA=0x087F5D78  token=0x600026E  HoudiniEngineUnity.HEU_InputNode.InternalObjectType GetInternalObjectType(HoudiniEngineUnity.HEU_InputNode.InputObjectType type)
  RVA=0x087DEFC4  token=0x600026F  HoudiniEngineUnity.HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType)
  RVA=0x087DEFC4  token=0x6000270  HoudiniEngineUnity.HEU_InputNode.InputNodeType InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNodeTypeWrapper inputNodeType)
  RVA=0x087F6480  token=0x6000271  HoudiniEngineUnity.HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputObjectType inputType)
  RVA=0x087F6480  token=0x6000272  HoudiniEngineUnity.HEU_InputNode.InputObjectType InputObjectType_WrapperToInternal(HoudiniEngineUnity.HEU_InputObjectTypeWrapper inputType)
  RVA=0x087F9288  token=0x6000273  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputObjectInfo
TYPE:  class
TOKEN: 0x200003F
SIZE:  0xA8
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.GameObject          _gameObject  // 0x10
  public            UnityEngine.Terrain             _terrainReference  // 0x18
  public            HEU_BoundingVolume              _boundingVolumeReference  // 0x20
  public            UnityEngine.Tilemaps.Tilemap    _tilemapReference  // 0x28
  public            UnityEngine.Matrix4x4           _syncdTransform  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>_syncdChildTransforms  // 0x70
  public            System.Boolean                  _useTransformOffset  // 0x78
  public            UnityEngine.Vector3             _translateOffset  // 0x7c
  public            UnityEngine.Vector3             _rotateOffset  // 0x88
  public            UnityEngine.Vector3             _scaleOffset  // 0x94
  public            System.Type                     _inputInterfaceType  // 0xa0
METHODS:
  RVA=0x087F9478  token=0x6000274  System.Void CopyTo(HoudiniEngineUnity.HEU_InputObjectInfo destObject)
  RVA=0x087F97D8  token=0x6000275  System.Void SetReferencesFromGameObject()
  RVA=0x087F957C  token=0x6000276  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputObjectInfo other)
  RVA=0x087F98C0  token=0x6000277  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputHDAInfo
TYPE:  class
TOKEN: 0x2000040
SIZE:  0x28
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.GameObject          _pendingGO  // 0x10
  public            UnityEngine.GameObject          _connectedGO  // 0x18
  public            System.Int32                    _connectedInputNodeID  // 0x20
  public            System.Int32                    _connectedMergeNodeID  // 0x24
METHODS:
  RVA=0x087F48A0  token=0x6000278  System.Void CopyTo(HoudiniEngineUnity.HEU_InputHDAInfo destInfo)
  RVA=0x087F48E4  token=0x6000279  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputHDAInfo other)
  RVA=0x03D6D3D0  token=0x600027A  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputNodeUICache
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x20
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputObjectUICache>_inputObjectCache  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputAssetUICache>_inputAssetCache  // 0x18
METHODS:
  RVA=0x087F4948  token=0x600027B  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InstanceInputUIState
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x28
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.Boolean                  _showInstanceInputs  // 0x18
  public            System.Int32                    _numInputsToShowUI  // 0x1c
  public            System.Int32                    _inputsPageIndexUI  // 0x20
METHODS:
  RVA=0x087F99BC  token=0x600027E  System.Void CopyTo(HoudiniEngineUnity.HEU_InstanceInputUIState dest)
  RVA=0x087F99E4  token=0x600027F  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstanceInputUIState other)
  RVA=0x087F9B3C  token=0x6000280  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ObjectInstanceInfo
TYPE:  class
TOKEN: 0x2000045
SIZE:  0x40
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InstancedInput>_instancedInputs  // 0x18
  public            HoudiniEngineUnity.HEU_PartData _partTarget  // 0x20
  public            System.Int32                    _instancedObjectNodeID  // 0x28
  public            System.String                   _instancedObjectPath  // 0x30
  public            System.Collections.Generic.List<UnityEngine.GameObject>_instances  // 0x38
METHODS:
  RVA=0x087F9D08  token=0x6000281  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectInstanceInfo other)
  RVA=0x087F9E28  token=0x6000282  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InstancedInput
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x30
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.GameObject          _instancedGameObject  // 0x10
  public            UnityEngine.Vector3             _rotationOffset  // 0x18
  public            UnityEngine.Vector3             _scaleOffset  // 0x24
METHODS:
  RVA=0x087F9B50  token=0x6000283  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstancedInput other)
  RVA=0x087F9CDC  token=0x6000284  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ObjectNode
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x80
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_ObjectNode HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.String                   _objName  // 0x18
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x20
  private           HoudiniEngineUnity.HAPI_ObjectInfo_objectInfo  // 0x28
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode>_geoNodes  // 0x48
  private           HoudiniEngineUnity.HAPI_Transform_objectTransform  // 0x50
  private           System.Collections.Generic.List<System.Int32>_recentlyDestroyedParts  // 0x78
PROPERTIES:
  ParentAsset  get=0x03D4EB40
  ObjectID  get=0x03D4ED90
  ObjectName  get=0x01041090
  ObjectInfo  get=0x03D5D990
  GeoNodes  get=0x03D4EA70
  ObjectTransform  get=0x03D6D410
METHODS:
  RVA=0x087FC010  token=0x600028B  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x087FCAF0  token=0x600028C  System.Void Recook()
  RVA=0x03D4F570  token=0x600028D  System.Boolean IsInstanced()
  RVA=0x03D4F630  token=0x600028E  System.Boolean IsVisible()
  RVA=0x087FC750  token=0x600028F  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  RVA=0x087FBC74  token=0x6000290  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=0x087FBEEC  token=0x6000291  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=0x087FBB1C  token=0x6000292  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=0x087FB9DC  token=0x6000293  HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName)
  RVA=0x087FB610  token=0x6000294  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  RVA=0x087FBD98  token=0x6000295  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes)
  RVA=0x087FC0A4  token=0x6000296  System.Void HideAllGeometry()
  RVA=0x087FA57C  token=0x6000297  System.Void DisableAllColliders()
  RVA=0x087FC62C  token=0x6000298  System.Boolean IsInstancer()
  RVA=0x087FCF00  token=0x6000299  System.Void .ctor()
  RVA=0x087FCB54  token=0x600029A  System.Void Reset()
  RVA=0x087FCC54  token=0x600029B  System.Void SyncWithObjectInfo(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087FC1B8  token=0x600029C  System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, HoudiniEngineUnity.HAPI_Transform objectTranform, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bUseOutputNodes)
  RVA=0x087FA690  token=0x600029D  System.Void GatherAllAssetOutputsLegacy(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode>& geoNodes)
  RVA=0x087FA4A4  token=0x600029E  System.Void DestroyAllData(System.Boolean bIsRebuild)
  RVA=0x087FA3F8  token=0x600029F  HoudiniEngineUnity.HEU_GeoNode CreateGeoNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo)
  RVA=0x087FB744  token=0x60002A0  System.Void GetDebugInfo(System.Text.StringBuilder sb)
  RVA=0x03D6D3F0  token=0x60002A1  System.Void SetObjectInfo(HoudiniEngineUnity.HAPI_ObjectInfo newObjectInfo)
  RVA=0x087FCD80  token=0x60002A2  System.Void UpdateObject(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate)
  RVA=0x087FA860  token=0x60002A3  System.Void GenerateGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild)
  RVA=0x087FB3A8  token=0x60002A4  System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087FA73C  token=0x60002A5  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F9EF4  token=0x60002A6  System.Void ApplyObjectTransformToGeoNodes()
  RVA=0x087FB4CC  token=0x60002A7  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  RVA=0x087FAFC8  token=0x60002A8  System.Void GenerateObjectInstances(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087FA248  token=0x60002A9  System.Void ClearObjectInstances(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087FC87C  token=0x60002AA  System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos)
  RVA=0x087FC9CC  token=0x60002AB  System.Void ProcessUnityScriptAttributes(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087FA128  token=0x60002AC  System.Void CalculateVisibility()
  RVA=0x087FA014  token=0x60002AD  System.Void CalculateColliderState()
  RVA=0x087FCD24  token=0x60002AE  System.String ToString()
  RVA=0x087FC3B4  token=0x60002AF  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectNode other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PartData
TYPE:  class
TOKEN: 0x2000048
SIZE:  0xA0
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_PartData HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.Int32                    _partID  // 0x18
  private           System.String                   _partName  // 0x20
  private           System.Int32                    _objectNodeID  // 0x28
  private           System.Int32                    _geoID  // 0x2c
  private           HoudiniEngineUnity.HAPI_PartType_partType  // 0x30
  private           HoudiniEngineUnity.HEU_GeoNode  _geoNode  // 0x38
  private           System.Boolean                  _isAttribInstancer  // 0x40
  private           System.Boolean                  _isPartInstanced  // 0x41
  private           System.Int32                    _partPointCount  // 0x44
  private           System.Boolean                  _isObjectInstancer  // 0x48
  private           System.Boolean                  _objectInstancesGenerated  // 0x49
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo>_objectInstanceInfos  // 0x50
  private           UnityEngine.Vector3             _terrainOffsetPosition  // 0x58
  private           UnityEngine.Object              _assetDBTerrainData  // 0x68
  private           System.Boolean                  _isPartEditable  // 0x70
  private           HoudiniEngineUnity.HEU_PartData.PartOutputType_partOutputType  // 0x74
  private           HoudiniEngineUnity.HEU_Curve    _curve  // 0x78
  private           HoudiniEngineUnity.HEU_AttributesStore_attributesStore  // 0x80
  private           System.Boolean                  _haveInstancesBeenGenerated  // 0x88
  private           System.Int32                    _meshVertexCount  // 0x8c
  private           HoudiniEngineUnity.HEU_GeneratedOutput_generatedOutput  // 0x90
  private           System.String                   _volumeLayerName  // 0x98
PROPERTIES:
  ParentAsset  get=0x088047AC
  PartID  get=0x020D1AC0
  PartName  get=0x03D4EB40
  GeoID  get=0x03D4EDD0
  PartType  get=0x03D4ED20
  ParentGeoNode  get=0x03D4E2A0
  ObjectInstanceInfos  get=0x03D4EAF0
  Curve  get=0x03D4EB20
  MeshVertexCount  get=0x03D4F3D0
  GeneratedOutput  get=0x03D4EA90
  OutputGameObject  get=0x08804784
METHODS:
  RVA=0x08804700  token=0x60002BB  System.Void .ctor()
  RVA=0x08803410  token=0x60002BC  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x08803D60  token=0x60002BD  System.Void Recook()
  RVA=0x08803B60  token=0x60002BE  System.Boolean IsPartInstancer()
  RVA=0x03D4EE90  token=0x60002BF  System.Boolean IsAttribInstancer()
  RVA=0x08803B44  token=0x60002C0  System.Boolean IsInstancerAnyType()
  RVA=0x03D4F7B0  token=0x60002C1  System.Boolean IsPartInstanced()
  RVA=0x03D4EE80  token=0x60002C2  System.Int32 GetPartPointCount()
  RVA=0x03D4EFE0  token=0x60002C3  System.Boolean IsObjectInstancer()
  RVA=0x08803B70  token=0x60002C4  System.Boolean IsPartVolume()
  RVA=0x08803B58  token=0x60002C5  System.Boolean IsPartCurve()
  RVA=0x08803B68  token=0x60002C6  System.Boolean IsPartMesh()
  RVA=0x03D4F260  token=0x60002C7  System.Boolean IsPartEditable()
  RVA=0x03D51D50  token=0x60002C8  System.Boolean HaveInstancesBeenGenerated()
  RVA=0x08803DF8  token=0x60002C9  System.Void SetGameObjectName(System.String partName)
  RVA=0x08803FF0  token=0x60002CA  System.Void SetGameObject(UnityEngine.GameObject gameObject)
  RVA=0x051417AC  token=0x60002CB  System.Void SetVolumeLayerName(System.String name)
  RVA=0x011AC510  token=0x60002CC  System.String GetVolumeLayerName()
  RVA=0x088009C0  token=0x60002CD  System.Void DestroyAllData(System.Boolean bIsRebuild)
  RVA=0x08803B78  token=0x60002CE  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  RVA=0x08803304  token=0x60002CF  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=0x088033A8  token=0x60002D0  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=0x08803120  token=0x60002D1  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject)
  RVA=0x087FDD58  token=0x60002D2  System.Void CalculateVisibility(System.Boolean bParentVisibility, System.Boolean bParentDisplayGeo)
  RVA=0x087FDE84  token=0x60002D3  System.Void ClearInstances()
  RVA=0x08802ED4  token=0x60002D4  HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly)
  RVA=0x088042E8  token=0x60002D5  System.Void SetVisiblity(System.Boolean bVisibility)
  RVA=0x08803DD4  token=0x60002D6  System.Void SetColliderState(System.Boolean bEnabled)
  RVA=0x08803240  token=0x60002D7  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path)
  RVA=0x08803190  token=0x60002D8  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID)
  RVA=0x03D58910  token=0x60002D9  System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition)
  RVA=0x08804144  token=0x60002DA  System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser)
  RVA=0x088034B4  token=0x60002DB  System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, System.Int32 geoID, System.Int32 objectNodeID, HoudiniEngineUnity.HEU_GeoNode geoNode, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData.PartOutputType partOutputType, System.Boolean isEditable, System.Boolean isObjectInstancer, System.Boolean isAttribInstancer)
  RVA=0x087FCFC8  token=0x60002DC  System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform)
  RVA=0x08802F58  token=0x60002DD  System.Void GetDebugInfo(System.Text.StringBuilder sb)
  RVA=0x08802D94  token=0x60002DE  System.Void GetClonableObjects(System.Collections.Generic.List<UnityEngine.GameObject> clonableObjects)
  RVA=0x08802E38  token=0x60002DF  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  RVA=0x03D4F010  token=0x60002E0  System.Void SetObjectInstancer(System.Boolean bObjectInstancer)
  RVA=0x087FE18C  token=0x60002E1  System.Void ClearObjectInstanceInfos()
  RVA=0x087FDF6C  token=0x60002E2  System.Void ClearInvalidObjectInstanceInfos()
  RVA=0x087FDD84  token=0x60002E3  System.Void ClearGeneratedData()
  RVA=0x087FDDA0  token=0x60002E4  System.Void ClearGeneratedMeshOutput()
  RVA=0x087FDE3C  token=0x60002E5  System.Void ClearGeneratedVolumeOutput()
  RVA=0x08802C00  token=0x60002E6  System.Boolean GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08800D58  token=0x60002E7  System.Void GenerateInstancesFromObjectID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectNodeID, System.String[] instancePrefixes, System.String[] instanceMaterialPaths)
  RVA=0x0880183C  token=0x60002E8  System.Void GenerateInstancesFromObject(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ObjectNode sourceObject, System.String[] instancePrefixes, System.String[] instanceMaterialPaths)
  RVA=0x088011C0  token=0x60002E9  System.Void GenerateInstancesFromObjectIds(HoudiniEngineUnity.HEU_SessionBase session, System.String[] instancePrefixes, System.String[] instanceMaterialPaths)
  RVA=0x08801BB0  token=0x60002EA  System.Void GenerateInstancesFromUnityAssetPathAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.String unityInstanceAttr)
  RVA=0x08800480  token=0x60002EB  System.Void CreateNewInstanceFromObject(UnityEngine.GameObject sourceObject, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Int32 instancedObjectNodeID, System.String instancedObjectPath, UnityEngine.Vector3 rotationOffset, UnityEngine.Vector3 scaleOffset, System.String[] instancePrefixes, System.String[] instanceMaterialPaths, UnityEngine.GameObject collisionSrcGO, System.Boolean copyParentFlags)
  RVA=0x08800CBC  token=0x60002EC  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087FDABC  token=0x60002ED  System.Void CalculateColliderState()
  RVA=0x087FE6AC  token=0x60002EE  System.Void CopyGameObjectComponents(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> lodTransformValues)
  RVA=0x087FE2FC  token=0x60002EF  System.Void CopyChildGameObjects(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bKeepPreviousTransformValues)
  RVA=0x087FD97C  token=0x60002F0  UnityEngine.GameObject BakePartToNewGameObject(UnityEngine.Transform parentTransform, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances)
  RVA=0x087FD100  token=0x60002F1  System.Void BakePartToGameObject(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject srcGO, UnityEngine.GameObject targetGO, System.String assetName, System.Boolean bIsInstancer, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues)
  RVA=0x087FD830  token=0x60002F2  System.Void BakePartToGameObject(UnityEngine.GameObject targetGO, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues)
  RVA=0x088027CC  token=0x60002F3  System.Boolean GenerateMesh(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups)
  RVA=0x08803BF8  token=0x60002F4  System.Void ProcessCurvePart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId)
  RVA=0x0880457C  token=0x60002F5  System.Void SyncAttributesStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x088044B0  token=0x60002F6  System.Void SetupAttributeGeometry(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08800AF8  token=0x60002F7  System.Void DestroyAttributesStore()
  RVA=0x08803BA4  token=0x60002F8  System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos)
  RVA=0x08804020  token=0x60002F9  System.Void SetObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> sourceObjectInstanceInfos)
  RVA=0x03D4EAF0  token=0x60002FA  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> GetObjectInstanceInfos()
  RVA=0x08800874  token=0x60002FB  HoudiniEngineUnity.HEU_ObjectInstanceInfo CreateObjectInstanceInfo(UnityEngine.GameObject instancedObject, System.Int32 instancedObjectNodeID, System.String instancedObjectPath)
  RVA=0x087FCF8C  token=0x60002FC  System.String AppendBakedCloneName(System.String name)
  RVA=0x088046A4  token=0x60002FD  System.String ToString()
  RVA=0x08800C10  token=0x60002FE  System.Void DestroyParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> parts, System.Boolean bIsRebuild)
  RVA=0x08800BDC  token=0x60002FF  System.Void DestroyPart(HoudiniEngineUnity.HEU_PartData part, System.Boolean bIsRebuild)
  RVA=0x087FE244  token=0x6000300  System.Boolean ComposeUnityInstanceSplitHierarchy(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Transform parentTransform, System.Int32 numInstances, UnityEngine.Transform[]& instanceToChildTransform)
  RVA=0x08803670  token=0x6000301  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_PartData other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AttributeData
TYPE:  sealed class
TOKEN: 0x200004E
SIZE:  0x68
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_AttributeInfo_attributeInfo  // 0x10
  public            System.String                   _name  // 0x38
  public            HoudiniEngineUnity.HEU_AttributeData.AttributeType_attributeType  // 0x40
  public            System.Int32[]                  _intValues  // 0x48
  public            System.Single[]                 _floatValues  // 0x50
  public            System.String[]                 _stringValues  // 0x58
  public            HoudiniEngineUnity.HEU_AttributeData.AttributeState_attributeState  // 0x60
METHODS:
  RVA=0x087F1118  token=0x600030B  System.Boolean IsColorAttribute()
  RVA=0x087F0FE4  token=0x600030C  System.Void CopyValuesTo(HoudiniEngineUnity.HEU_AttributeData destAttrData)
  RVA=0x087F1170  token=0x600030D  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributeData other)
  RVA=0x0350B670  token=0x600030E  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AttributesStore
TYPE:  class
TOKEN: 0x2000051
SIZE:  0x98
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.Int32                    _geoID  // 0x18
  private           System.Int32                    _partID  // 0x1c
  private           System.String                   _geoName  // 0x20
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData>_attributeDatas  // 0x28
  private           System.Boolean                  _hasColorAttribute  // 0x30
  private           UnityEngine.Material            _localMaterial  // 0x38
  private           UnityEngine.Transform           _outputTransform  // 0x40
  private           UnityEngine.Vector3[]           _positionAttributeValues  // 0x48
  private           System.Int32[]                  _vertexIndices  // 0x50
  private           UnityEngine.GameObject          _outputGameObject  // 0x58
  private           UnityEngine.Mesh                _outputMesh  // 0x60
  private           UnityEngine.Material[]          _outputMaterials  // 0x68
  private           UnityEngine.MeshCollider        _outputCollider  // 0x70
  private           UnityEngine.Mesh                _outputColliderMesh  // 0x78
  private           UnityEngine.MeshCollider        _outputMeshCollider  // 0x80
  private           UnityEngine.MeshCollider        _localMeshCollider  // 0x88
  private           System.Boolean                  _outputMeshRendererInitiallyEnabled  // 0x90
  private           System.Boolean                  _outputMeshColliderInitiallyEnabled  // 0x91
PROPERTIES:
  GeoID  get=0x020D1AC0
  PartID  get=0x03D4EBB0
  GeoName  get=0x03D4EB40
  OutputTransform  get=0x03D4E2B0
  OutputMesh  get=0x03D4EB00
METHODS:
  RVA=0x03D4EF60  token=0x6000312  System.Boolean HasColorAttribute()
  RVA=0x087F1960  token=0x6000315  System.Void DestroyAllData(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x087F3EA4  token=0x6000316  System.Void SyncAllAttributesFrom(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, UnityEngine.GameObject outputGameObject)
  RVA=0x087F3850  token=0x6000317  System.Void SetupMeshAndMaterials(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HAPI_PartType partType, UnityEngine.GameObject outputGameObject)
  RVA=0x087F2454  token=0x6000318  System.Boolean HasDirtyAttributes()
  RVA=0x087F4124  token=0x6000319  System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F2D44  token=0x600031A  System.Void PopulateAttributeData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  RVA=0x087F235C  token=0x600031B  System.Void GetAttributesList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributesList, HoudiniEngineUnity.HAPI_AttributeOwner ownerType, System.Int32 attributeCount)
  RVA=0x087F42D8  token=0x600031C  System.Void UpdateAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData)
  RVA=0x087F4188  token=0x600031D  System.Void UpdateAttributeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributeDataList)
  RVA=0x087F3408  token=0x600031E  System.Void RefreshUpstreamInputs(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F4434  token=0x600031F  System.Boolean UploadAttributeViaMeshInput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x087F3620  token=0x6000320  System.Void SetAttributeDataSyncd(HoudiniEngineUnity.HEU_AttributeData attributeData)
  RVA=0x087F3604  token=0x6000321  System.Void SetAttributeDataDirty(HoudiniEngineUnity.HEU_AttributeData attributeData)
  RVA=0x087F18A8  token=0x6000322  HoudiniEngineUnity.HEU_AttributeData CreateAttribute(System.String attributeName, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  RVA=0x087F1DE8  token=0x6000323  HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.String name)
  RVA=0x087F1F28  token=0x6000324  HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.Int32 index)
  RVA=0x087F1F98  token=0x6000325  System.Collections.Generic.List<System.String> GetAttributeNames()
  RVA=0x087F1B8C  token=0x6000326  System.Void EnablePaintCollider()
  RVA=0x087F1A74  token=0x6000327  System.Void DisablePaintCollider()
  RVA=0x087F3C18  token=0x6000328  System.Void ShowPaintMesh()
  RVA=0x087F25C8  token=0x6000329  System.Void HidePaintMesh()
  RVA=0x087F2578  token=0x600032A  System.Boolean HasMeshForPainting()
  RVA=0x087F23CC  token=0x600032B  UnityEngine.MeshCollider GetPaintMeshCollider()
  RVA=0x087F2CE0  token=0x600032C  System.Void PaintAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 attributeIndex, System.Single paintFactor, HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc setAttrFunc)
  RVA=0x087F36B0  token=0x600032D  System.Void SetAttributeEditValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Int32[] values)
  RVA=0x087F363C  token=0x600032E  System.Void SetAttributeEditValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Single[] values)
  RVA=0x087F3724  token=0x600032F  System.Void SetAttributeEditValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.String[] values)
  RVA=0x087F34F4  token=0x6000330  System.Void ReplaceAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F152C  token=0x6000331  System.Void AddAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F3DD8  token=0x6000332  System.Void SubtractAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F2BD0  token=0x6000333  System.Void MultiplyAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F3440  token=0x6000334  System.Void ReplaceAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F147C  token=0x6000335  System.Void AddAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F3D20  token=0x6000336  System.Void SubtractAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F2B10  token=0x6000337  System.Void MultiplyAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F37AC  token=0x6000338  System.Void SetAttributeValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  RVA=0x087F1D34  token=0x6000339  System.Void FillAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools)
  RVA=0x087F15F8  token=0x600033A  System.Boolean AreAttributesDirty()
  RVA=0x087F2434  token=0x600033B  System.Void GetPositionAttributeValues(UnityEngine.Vector3[]& positionArray)
  RVA=0x087F2444  token=0x600033C  System.Void GetVertexIndices(System.Int32[]& indices)
  RVA=0x087F212C  token=0x600033D  HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc GetAttributeSetValueFunction(HoudiniEngineUnity.HEU_AttributeData.AttributeType attrType, HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode paintMergeMode)
  RVA=0x087F1710  token=0x600033E  System.Void CopyAttributeValuesTo(HoudiniEngineUnity.HEU_AttributesStore destAttrStore)
  RVA=0x087F2AF8  token=0x600033F  System.Boolean IsValidStore(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x087F26A0  token=0x6000340  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributesStore other)
  RVA=0x087F44E0  token=0x6000341  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_OutputAttribute
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x40
FIELDS:
  public            System.String                   _name  // 0x10
  public            HoudiniEngineUnity.HAPI_AttributeOwner_class  // 0x18
  public            HoudiniEngineUnity.HAPI_StorageType_type  // 0x1c
  public            System.Int32                    _count  // 0x20
  public            System.Int32                    _tupleSize  // 0x24
  public            System.Int32[]                  _intValues  // 0x28
  public            System.Single[]                 _floatValues  // 0x30
  public            System.String[]                 _stringValues  // 0x38
METHODS:
  RVA=0x0350B670  token=0x6000346  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_OutputAttributeDictionary
TYPE:  class
TOKEN: 0x2000054
SIZE:  0x28
EXTENDS: HoudiniEngineUnity.HEU_SerializableDictionary`2
FIELDS:
METHODS:
  RVA=0x0880AF6C  token=0x6000347  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_OutputAttributesStore
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           HoudiniEngineUnity.HEU_OutputAttributeDictionary_attributes  // 0x18
METHODS:
  RVA=0x0880B044  token=0x6000348  System.Void SetAttribute(HoudiniEngineUnity.HEU_OutputAttribute attribute)
  RVA=0x0880AFDC  token=0x6000349  HoudiniEngineUnity.HEU_OutputAttribute GetAttribute(System.String name)
  RVA=0x0880AF94  token=0x600034A  System.Void Clear()
  RVA=0x0880B114  token=0x600034B  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetDatabase
TYPE:  static class
TOKEN: 0x2000056
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08805DD4  token=0x600034C  System.String GetAssetCachePath()
  RVA=0x088065B0  token=0x600034D  System.String GetUnityProjectPath()
  RVA=0x08805F68  token=0x600034E  System.String GetAssetRelativePath(System.String inFullPath)
  RVA=0x08806238  token=0x600034F  System.String GetPackagesRelativePath(System.String inFullPath)
  RVA=0x0880660C  token=0x6000350  System.String GetValidAssetPath(System.String inPath)
  RVA=0x08805ED8  token=0x6000351  System.String GetAssetPath(UnityEngine.Object asset)
  RVA=0x08805EA0  token=0x6000352  System.String GetAssetPathWithSubAssetSupport(UnityEngine.Object asset)
  RVA=0x08806358  token=0x6000353  System.Void GetSubAssetPathFromPath(System.String fullPath, System.String& mainPath, System.String& subPath)
  RVA=0x08805F10  token=0x6000354  System.String GetAssetRelativePathStart()
  RVA=0x088061E0  token=0x6000355  System.String GetPackagesRelativePathStart()
  RVA=0x08805E1C  token=0x6000356  System.String GetAssetFullPath(System.String inPath)
  RVA=0x08806B8C  token=0x6000357  System.Boolean IsPathRelativeToAssets(System.String inPath)
  RVA=0x08806C10  token=0x6000358  System.Boolean IsPathRelativeToPackages(System.String inPath)
  RVA=0x088060A8  token=0x6000359  System.String GetAssetRootPath(UnityEngine.Object asset)
  RVA=0x08806578  token=0x600035A  System.String GetUniqueAssetPath(System.String path)
  RVA=0x08805E68  token=0x600035B  System.String GetAssetOrScenePath(UnityEngine.Object inputObject)
  RVA=0x08806A80  token=0x600035C  System.Boolean IsPathInAssetCache(System.String path)
  RVA=0x08806A10  token=0x600035D  System.Boolean IsPathInAssetCacheBakedFolder(System.String path)
  RVA=0x08806A48  token=0x600035E  System.Boolean IsPathInAssetCacheWorkingFolder(System.String path)
  RVA=0x08806968  token=0x600035F  System.Boolean IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset)
  RVA=0x088069A0  token=0x6000360  System.Boolean IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset)
  RVA=0x08805B88  token=0x6000361  System.String CreateAssetCacheFolder(System.String suggestedAssetPath, System.Int32 hash)
  RVA=0x08805CC8  token=0x6000362  System.Void DeleteAssetCacheFolder(System.String assetCacheFolderPath)
  RVA=0x08805D30  token=0x6000363  System.Void DeleteAsset(UnityEngine.Object asset)
  RVA=0x08805C94  token=0x6000364  System.Void DeleteAssetAtPath(System.String path)
  RVA=0x08805CFC  token=0x6000365  System.Void DeleteAssetIfInBakedFolder(UnityEngine.Object asset)
  RVA=0x088059CC  token=0x6000366  System.Boolean ContainsAsset(UnityEngine.Object assetObject)
  RVA=0x08805AE4  token=0x6000367  System.Boolean CopyAsset(System.String path, System.String newPath)
  RVA=0x08805AAC  token=0x6000368  UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, System.String copyAssetFolder, System.String relativePath, System.Type type, System.Boolean bOverwriteExisting)
  RVA=0x08805A74  token=0x6000369  UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting)
  RVA=0x08805A04  token=0x600036A  UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting)
  RVA=0x08805A3C  token=0x600036B  UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, System.String targetPath, System.Type type)
  RVA=0x08805B1C  token=0x600036C  UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type)
  RVA=0x08805BF4  token=0x600036D  System.Void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, System.String assetCacheRoot, System.String relativeFolderPath, System.String assetFileName, System.Type type, System.Boolean bOverwriteExisting)
  RVA=0x08805BC0  token=0x600036E  System.Void CreateAsset(UnityEngine.Object asset, System.String path)
  RVA=0x08805B54  token=0x600036F  System.Void CreateAddObjectInAssetCacheFolder(System.String assetName, System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, System.String& exportRootPath, UnityEngine.Object& assetDBObject)
  RVA=0x088056D4  token=0x6000370  System.Void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject)
  RVA=0x0350B670  token=0x6000371  System.Void SaveAndRefreshDatabase()
  RVA=0x0350B670  token=0x6000372  System.Void SaveAssetDatabase()
  RVA=0x0350B670  token=0x6000373  System.Void RefreshAssetDatabase()
  RVA=0x08806D04  token=0x6000374  UnityEngine.Object LoadAssetAtPath(System.String assetPath, System.Type type)
  RVA=0x08806D3C  token=0x6000375  UnityEngine.Object LoadSubAssetAtPath(System.String mainPath, System.String subAssetPath)
  RVA=0x08806CCC  token=0x6000376  UnityEngine.Object[] LoadAllAssetsAtPath(System.String assetPath)
  RVA=0x08806C94  token=0x6000377  UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(System.String assetPath)
  RVA=0x08806934  token=0x6000378  System.Void ImportAsset(System.String assetPath, HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions heuOptions)
  RVA=0x088061A8  token=0x6000379  System.String GetAssetWorkingPath()
  RVA=0x08805D9C  token=0x600037A  System.String GetAssetBakedPath()
  RVA=0x08805D64  token=0x600037B  System.String GetAssetBakedPathWithAssetName(System.String assetName)
  RVA=0x08805C5C  token=0x600037C  System.String CreateUniqueBakePath(System.String assetName)
  RVA=0x08805C28  token=0x600037D  System.Void CreatePathWithFolders(System.String inPath)
  RVA=0x088057C0  token=0x600037E  System.String AppendMeshesPathToAssetFolder(System.String inAssetCacheFolder)
  RVA=0x08805950  token=0x600037F  System.String AppendTexturesPathToAssetFolder(System.String inAssetCacheFolder)
  RVA=0x08805708  token=0x6000380  System.String AppendMaterialsPathToAssetFolder(System.String inAssetCacheFolder)
  RVA=0x088058D4  token=0x6000381  System.String AppendTerrainPathToAssetFolder(System.String inAssetCacheFolder)
  RVA=0x088060E0  token=0x6000382  System.String[] GetAssetSubFolders()
  RVA=0x0880583C  token=0x6000383  System.String AppendPrefabPath(System.String inAssetCacheFolder, System.String assetName)
  RVA=0x08805784  token=0x6000384  System.String AppendMeshesAssetFileName(System.String assetName)
  RVA=0x0115F4C0  token=0x6000385  System.Boolean IsSubAsset(UnityEngine.Object obj)
  RVA=0x01002730  token=0x6000386  System.String[] GetAssetPathsFromAssetBundle(System.String assetBundleFileName)
  RVA=0x088069D8  token=0x6000387  System.Boolean IsAssetSavedInScene(UnityEngine.GameObject go)
  RVA=0x0350B670  token=0x6000388  System.Void SelectAssetAtPath(System.String path)
  RVA=0x0350B670  token=0x6000389  System.Void PrintDependencies(UnityEngine.GameObject targetGO)
  RVA=0x088064C8  token=0x600038A  System.String GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj)
  RVA=0x0232EB60  token=0x600038B  System.Boolean IsValidFolderName(System.String name)
  RVA=-1  // generic def  token=0x600038C  T LoadUnityAssetFromUniqueAssetPath(System.String assetPath)
  RVA=-1  // generic def  token=0x600038D  T GetBuiltinExtraResource(System.String resourceName)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Defines
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x10
FIELDS:
  public    static  System.String                   HEU_PRODUCT_NAME  // const
  public    static  System.String                   HEU_NAME  // const
  public    static  System.String                   HEU_PLUGIN_PATH  // static @ 0x0
  public    static  System.String                   HEU_TEXTURES_PATH  // static @ 0x8
  public    static  System.String                   HEU_BAKED_ASSETS_PATH  // static @ 0x10
  public    static  System.String                   HEU_ENGINE_ASSETS  // static @ 0x18
  public    static  System.String                   HAPI_PATH  // const
  public    static  System.String                   HEU_ENVPATH_PREFIX  // const
  public    static  System.String                   HEU_ENVPATH_KEY  // const
  public    static  System.Int32                    HEU_INVALID_NODE_ID  // const
  public    static  System.String                   HEU_DEFAULT_ASSET_NAME  // const
  public    static  System.String                   HEU_SESSION_PIPENAME  // const
  public    static  System.String                   HEU_SESSION_LOCALHOST  // const
  public    static  System.Int32                    HEU_SESSION_PORT  // const
  public    static  System.Single                   HEU_SESSION_TIMEOUT  // const
  public    static  System.Boolean                  HEU_SESSION_AUTOCLOSE  // const
  public    static  System.Int32                    HAPI_MAX_PAGE_SIZE  // const
  public    static  System.Int32                    HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW  // const
  public    static  System.Int32                    HAPI_MAX_VERTICES_PER_FACE  // const
  public    static  System.Boolean                  HAPI_CURVE_REFINE_TO_LINEAR  // const
  public    static  System.Single                   HAPI_CURVE_LOD  // const
  public    static  System.Single                   HAPI_VOLUME_POSITION_MULT  // const
  public    static  System.Single                   HAPI_VOLUME_SURFACE_MAX_PT_PER_C  // const
  public    static  System.Single                   HAPI_VOLUME_SURFACE_DELTA_MULT  // const
  public    static  System.Single                   HAPI_VOLUME_SURFACE_PT_SIZE_MULT  // const
  public    static  System.String                   DEFAULT_TOP_NODE_FILTER  // const
  public    static  System.String                   DEFAULT_TOP_OUTPUT_FILTER  // const
  public    static  System.String                   HAPI_ATTRIB_ORIENT  // const
  public    static  System.String                   HAPI_ATTRIB_ROTATION  // const
  public    static  System.String                   HAPI_ATTRIB_SCALE  // const
  public    static  System.String                   HAPI_ATTRIB_ALPHA  // const
  public    static  System.String                   HAPI_HANDLE_TRANSFORM  // const
  public    static  System.Int32                    HAPI_MAX_UVS  // const
  public    static  System.String                   HAPI_OBJMERGE_TRANSFORM_PARAM  // const
  public    static  System.String                   HAPI_OBJMERGE_PACK_GEOMETRY  // const
  public    static  System.String                   HAPI_OBJPATH_1_PARAM  // const
  public    static  System.String                   NO_EXISTING_SESSION  // const
  public    static  System.String                   HEU_ERROR_TITLE  // const
  public    static  System.String                   HEU_INSTALL_INFO  // const
  public    static  System.String                   PLUGIN_STORE_KEYS  // const
  public    static  System.String                   PLUGIN_STORE_DATA  // const
  public    static  System.String                   PLUGIN_SESSION_DATA  // const
  public    static  System.String                   PLUGIN_SETTINGS_FILE  // const
  public    static  System.String                   PLUGIN_SESSION_FILE  // const
  public    static  System.String                   COOK_LOGS_FILE  // const
  public    static  System.String                   DEFAULT_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_RENDERED_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_RENDERED_CONVEX_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_CONVEX_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_SIMPLE_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_SIMPLE_RENDERED_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO  // const
  public    static  System.String                   DEFAULT_COLLISION_TRIGGER  // const
  public    static  System.String                   DEFAULT_UNITY_MATERIAL_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE  // const
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_YPOS  // const
  public    static  System.String                   HEIGHTFIELD_TREEPROTOTYPE  // const
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX  // const
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE  // const
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE  // const
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH  // const
  public    static  System.String                   HEIGHTFIELD_UNITY_TILE  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_DISTANCE  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_DENSITY  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD  // const
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE  // const
  public    static  System.String                   HEIGHTFIELD_LAYER_ATTR_TYPE  // const
  public    static  System.String                   HEIGHTFIELD_LAYER_TYPE_DETAIL  // const
  public    static  System.String                   HAPI_HEIGHTFIELD_TILE_ATTR  // const
  public    static  System.String                   HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT  // const
  public    static  System.String                   HAPI_HEIGHTFIELD_LAYERNAME_MASK  // const
  public    static  System.String                   MAT_OGL_DIFF_ATTR  // const
  public    static  System.String                   MAT_DIFF_ATTR  // const
  public    static  System.String                   MAT_OGL_TEX1_ATTR  // const
  public    static  System.String                   MAT_OGL_TEX1_ATTR_ENABLED  // const
  public    static  System.String                   MAT_BASECOLOR_ATTR  // const
  public    static  System.String                   MAT_BASECOLOR_ATTR_ENABLED  // const
  public    static  System.String                   MAT_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_NORMAL_ATTR  // const
  public    static  System.String                   MAT_NORMAL_ATTR  // const
  public    static  System.String                   MAT_NORMAL_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_SPEC_ATTR  // const
  public    static  System.String                   MAT_SPEC_ATTR  // const
  public    static  System.String                   MAT_OGL_SPEC_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_SPEC_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_SPEC_MAP_ATTR  // const
  public    static  System.String                   MAT_SPEC_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_ROUGH_ATTR  // const
  public    static  System.String                   MAT_ROUGH_ATTR  // const
  public    static  System.String                   MAT_OGL_ROUGH_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_ROUGH_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_ROUGH_MAP_ATTR  // const
  public    static  System.String                   MAT_ROUGH_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_METALLIC_ATTR  // const
  public    static  System.String                   MAT_METALLIC_ATTR  // const
  public    static  System.String                   MAT_OGL_METALLIC_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_METALLIC_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_METALLIC_MAP_ATTR  // const
  public    static  System.String                   MAT_METALLIC_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_EMISSIVE_ATTR  // const
  public    static  System.String                   MAT_EMISSIVE_ATTR  // const
  public    static  System.String                   MAT_OGL_EMISSIVE_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_EMISSIVE_MAP_ATTR  // const
  public    static  System.String                   MAT_EMISSIVE_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_ALPHA_ATTR  // const
  public    static  System.String                   MAT_ALPHA_ATTR  // const
  public    static  System.String                   MAT_OGL_OPACITY_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_OPACITY_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OPACITY_MAP_ATTR  // const
  public    static  System.String                   MAT_OPACITY_MAP_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_TRANSPARENCY_ATTR  // const
  public    static  System.String                   MAT_OGL_TRANSPARENCY_ATTR_ENABLED  // const
  public    static  System.String                   MAT_OGL_OCCLUSION_MAP_ATTR  // const
  public    static  System.String                   MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED  // const
  public    static  System.String                   CURVE_COORDS_PARAM  // const
  public    static  System.String                   CURVE_TYPE_PARAM  // const
  public    static  System.String                   CURVE_METHOD_PARAM  // const
  public    static  System.String                   CURVE_CLOSE_PARAM  // const
  public    static  System.String                   CURVE_REVERSE_PARAM  // const
  public    static  System.String                   HENGINE_STORE_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_TAG_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_SCRIPT_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_INSTANCE_ATTR  // const
  public    static  System.String                   UNITY_USE_INSTANCE_FLAGS_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_INPUT_MESH_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_STATIC_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_LAYER_ATTR  // const
  public    static  System.String                   DEFAULT_UNITY_MESH_READABLE  // const
  public    static  System.String                   DEFAULT_INSTANCE_PREFIX_ATTR  // const
  public    static  System.String                   UNITY_SHADER_COLOR  // const
  public    static  System.String                   UNITY_SHADER_SPEC_COLOR  // const
  public    static  System.String                   UNITY_SHADER_SPEC_MAP  // const
  public    static  System.String                   UNITY_SHADER_METALLIC  // const
  public    static  System.String                   UNITY_SHADER_METALLIC_MAP  // const
  public    static  System.String                   UNITY_SHADER_BUMP_MAP  // const
  public    static  System.String                   UNITY_SHADER_EMISSION_COLOR  // const
  public    static  System.String                   UNITY_SHADER_EMISSION_MAP  // const
  public    static  System.String                   UNITY_SHADER_SMOOTHNESS  // const
  public    static  System.String                   UNITY_SHADER_SMOOTHNESS_MAP  // const
  public    static  System.String                   UNITY_SHADER_SHININESS  // const
  public    static  System.String                   UNITY_SHADER_OCCLUSION  // const
  public    static  System.String                   UNITY_SHADER_OCCLUSION_MAP  // const
  public    static  System.String                   UNITY_SHADER_OPACITY  // const
  public    static  System.String                   UNITY_SHADER_OPACITY_MAP  // const
  public    static  System.String                   UNITY_EDITORONLY_TAG  // const
  public    static  System.String                   UNITY_HDADATA_NAME  // const
  public    static  System.String                   HOUDINI_SHADER_PREFIX  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER_SPECULAR  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_SPECULAR  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_SPECULAR  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY  // const
  public    static  System.String                   DEFAULT_CURVE_SHADER  // const
  public    static  System.String                   DEFAULT_TERRAIN_SHADER  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER_HDRP  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_HDRP  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_HDRP  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER_HDRP_SPECULAR  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR  // const
  public    static  System.String                   DEFAULT_CURVE_SHADER_HDRP  // const
  public    static  System.String                   DEFAULT_TERRAIN_SHADER_HDRP  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER_URP  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_URP  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_URP  // const
  public    static  System.String                   DEFAULT_STANDARD_SHADER_URP_SPECULAR  // const
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR  // const
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR  // const
  public    static  System.String                   DEFAULT_CURVE_SHADER_URP  // const
  public    static  System.String                   DEFAULT_TERRAIN_SHADER_URP  // const
  public    static  System.String                   DEFAULT_UNITY_BUILTIN_RESOURCES  // const
  public    static  System.String                   DEFAULT_TERRAIN_MATERIAL_PATH  // const
  public    static  System.String                   DEFAULT_TERRAIN_MATERIAL_PATH_HDRP  // const
  public    static  System.String                   DEFAULT_TERRAIN_MATERIAL_PATH_URP  // const
  public    static  System.String                   DEFAULT_MATERIAL  // const
  public    static  System.Int32                    DEFAULT_MATERIAL_KEY  // static @ 0x20
  public    static  System.String                   EDITABLE_MATERIAL  // const
  public    static  System.Int32                    EDITABLE_MATERIAL_KEY  // static @ 0x24
  public    static  System.Int32                    HEU_INVALID_MATERIAL  // const
  public    static  System.String                   HEU_ASSET_CACHE_PATH  // const
  public    static  System.String                   HEU_WORKING_PATH  // const
  public    static  System.String                   HEU_BAKED_PATH  // const
  public    static  System.String                   HEU_BAKED_HDA  // const
  public    static  System.String                   HEU_BAKED_CLONE  // const
  public    static  System.String                   HEU_INSTANCE  // const
  public    static  System.String                   HEU_INSTANCE_PATTERN  // const
  public    static  System.String                   HEU_INSTANCE_SPLIT_ATTR  // const
  public    static  System.String                   HEU_DEFAULT_GEO_GROUP_NAME  // const
  public    static  System.String                   HEU_DEFAULT_LOD_NAME  // const
  public    static  System.String                   HEU_UNITY_LOD_TRANSITION_ATTR  // const
  public    static  System.String                   HEU_SUBASSET  // const
  public    static  System.String                   HEU_HENGINE_TOOLS_SHIPPED_FOLDER  // const
  public    static  System.String                   HEU_HENGINE_SHIPPED_SHELF  // const
  public    static  System.String                   HEU_PATH_KEY_PROJECT  // const
  public    static  System.String                   HEU_PATH_KEY_PLUGIN  // const
  public    static  System.String                   HEU_PATH_KEY_HFS  // const
  public    static  System.String                   HEU_PATH_KEY_TOOL  // const
  public    static  System.String                   HEU_USERMSG_NONEDITOR_NOT_SUPPORTED  // const
  public    static  System.String                   HEU_TERRAIN_SPLAT_DEFAULT  // const
  public    static  System.String                   HEU_FOLDER_MESHES  // const
  public    static  System.String                   HEU_FOLDER_MATERIALS  // const
  public    static  System.String                   HEU_FOLDER_TERRAIN  // const
  public    static  System.String                   HEU_FOLDER_TILE  // const
  public    static  System.String                   HEU_FOLDER_TEXTURES  // const
  public    static  System.String                   HEU_EXT_ASSET  // const
  public    static  System.String                   HEU_EXT_MAT  // const
  public    static  System.String                   HEU_EXT_TERRAINDATA  // const
  public    static  System.String                   HEU_EXT_TERRAINLAYER  // const
  public    static  System.String                   HEU_KEY_CTRL  // const
METHODS:
  RVA=0x0350B670  token=0x600038E  System.Void .ctor()
  RVA=0x08806DD4  token=0x600038F  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HAPIUtility
TYPE:  static class
TOKEN: 0x2000059
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08808DF8  token=0x6000390  System.String GetHoudiniEngineInstallationInfo()
  RVA=0x088087AC  token=0x6000391  System.String GetEnvironmentPath()
  RVA=0x08809500  token=0x6000392  System.String GetRealPathFromHFSPath(System.String inPath)
  RVA=0x08807E88  token=0x6000393  System.Boolean DoesMappedPathExist(System.String inPath)
  RVA=0x0880983C  token=0x6000394  System.Boolean IsHoudiniAssetFile(System.String filePath)
  RVA=0x08807EF8  token=0x6000395  System.String FindHoudiniAssetFileInPathWithExt(System.String filePath)
  RVA=0x08809E74  token=0x6000396  System.Void Log(System.String message)
  RVA=0x08809E6C  token=0x6000397  System.Void LogWarning(System.String message)
  RVA=0x08809E64  token=0x6000398  System.Void LogError(System.String message)
  RVA=0x08809E08  token=0x6000399  System.String LocateValidFilePath(UnityEngine.Object inObject)
  RVA=0x03D51810  token=0x600039A  System.String LocateValidFilePath(System.String assetName, System.String inFilePath)
  RVA=0x08809624  token=0x600039B  UnityEngine.GameObject InstantiateHDA(System.String filePath, UnityEngine.Vector3 initialPosition, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, System.Boolean bLoadFromMemory, System.Boolean bAlwaysOverwriteOnLoad, UnityEngine.GameObject rootGO)
  RVA=0x08809D54  token=0x600039C  System.Boolean LoadHDAFile(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.Int32& assetLibraryID, System.String[]& assetNames)
  RVA=0x088078E4  token=0x600039D  System.Boolean CreateAndCookAssetNode(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID)
  RVA=0x08807950  token=0x600039E  System.Boolean CreateAndCookCurveAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID)
  RVA=0x088079A4  token=0x600039F  System.Boolean CreateAndCookInputAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID)
  RVA=0x088076A8  token=0x60003A0  System.Boolean CookNodeInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.String assetName)
  RVA=0x088076A8  token=0x60003A1  System.Boolean CookNodeInHoudiniWithOptions(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions options, System.String assetName)
  RVA=0x08808770  token=0x60003A2  HoudiniEngineUnity.HAPI_CookOptions GetDefaultCookOptions(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08809E7C  token=0x60003A3  System.Boolean ProcessHoudiniCookStatus(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName)
  RVA=0x08807A0C  token=0x60003A4  UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  RVA=0x08807A60  token=0x60003A5  UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  RVA=0x08807B14  token=0x60003A6  UnityEngine.GameObject CreateNewCurveAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  RVA=0x08807B48  token=0x60003A7  UnityEngine.GameObject CreateNewInputAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  RVA=0x01002730  token=0x60003A8  UnityEngine.GameObject LoadGeoWithNewGeoSync(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08807B7C  token=0x60003A9  System.Void DestroyChildren(UnityEngine.Transform inTransform)
  RVA=0x08807E78  token=0x60003AA  System.Void DestroyGameObject(UnityEngine.GameObject gameObect, System.Boolean bRegisterUndo)
  RVA=-1  // generic def  token=0x60003AB  System.Void DestroyChildrenWithComponent(UnityEngine.GameObject gameObject)
  RVA=0x08809954  token=0x60003AC  System.Boolean IsNodeValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID)
  RVA=0x08808690  token=0x60003AD  HoudiniEngineUnity.HEU_HoudiniAssetRoot GetAssetInScene(System.Int32 assetID)
  RVA=0x08807434  token=0x60003AE  System.Void ApplyWorldTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform)
  RVA=0x088071D0  token=0x60003AF  System.Void ApplyLocalTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform)
  RVA=0x08806FA0  token=0x60003B0  System.Void ApplyLocalTransfromFromHoudiniToUnityForInstance(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform)
  RVA=0x08807380  token=0x60003B1  System.Void ApplyMatrixToLocalTransform(UnityEngine.Matrix4x4& matrix, UnityEngine.Transform transform)
  RVA=0x08808ED4  token=0x60003B2  UnityEngine.Matrix4x4 GetMatrixFromHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Boolean bConvertToUnity)
  RVA=0x088092FC  token=0x60003B3  UnityEngine.Quaternion GetQuaternion(UnityEngine.Matrix4x4& m)
  RVA=0x088092B0  token=0x60003B4  UnityEngine.Vector3 GetPosition(UnityEngine.Matrix4x4& m)
  RVA=0x08809EFC  token=0x60003B5  System.Void SetMatrixPosition(UnityEngine.Matrix4x4& m, UnityEngine.Vector3& position)
  RVA=0x03D6D540  token=0x60003B6  UnityEngine.Vector3 GetScale(UnityEngine.Matrix4x4& m)
  RVA=0x0880881C  token=0x60003B7  HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransformFromMatrix(UnityEngine.Matrix4x4& mat)
  RVA=0x08808C64  token=0x60003B8  HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransform(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s)
  RVA=0x08808A08  token=0x60003B9  HoudiniEngineUnity.HAPI_Transform GetHAPITransformQuatFromMatrix(UnityEngine.Matrix4x4& mat)
  RVA=0x08808E24  token=0x60003BA  UnityEngine.Matrix4x4 GetMatrix4x4(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s)
  RVA=0x088099CC  token=0x60003BB  System.Boolean IsSameTransform(UnityEngine.Matrix4x4& transformMatrix, UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s)
  RVA=0x056649E4  token=0x60003BC  System.Boolean IsEqualTol(System.Single a, System.Single b, System.Single t)
  RVA=0x08809AB0  token=0x60003BD  System.Boolean IsTransformEqual(HoudiniEngineUnity.HAPI_Transform& transA, HoudiniEngineUnity.HAPI_Transform& transB)
  RVA=0x08809C58  token=0x60003BE  System.Boolean IsViewportEqual(HoudiniEngineUnity.HAPI_Viewport& viewA, HoudiniEngineUnity.HAPI_Viewport& viewB)
  RVA=0x08809A84  token=0x60003BF  System.Boolean IsSessionSyncEqual(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncA, HoudiniEngineUnity.HAPI_SessionSyncInfo& syncB)
  RVA=0x088076A8  token=0x60003C0  System.Boolean DoesGeoPartHaveAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  RVA=0x0350B670  token=0x60003C1  System.Void SetAnimationCurveTangentModes(UnityEngine.AnimationCurve animCurve, System.Collections.Generic.List<System.Int32> tangentValues)
  RVA=0x08809A9C  token=0x60003C2  System.Boolean IsSupportedPolygonType(HoudiniEngineUnity.HAPI_PartType partType)
  RVA=0x08809290  token=0x60003C3  System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID)
  RVA=0x088090F8  token=0x60003C4  System.Boolean GetObjectInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.HAPI_ObjectInfo[]& objectInfos, HoudiniEngineUnity.HAPI_Transform[]& objectTransforms)
  RVA=0x088076A8  token=0x60003C5  System.Boolean ContainsSopNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId)
  RVA=0x08809970  token=0x60003C6  System.Boolean IsObjNodeFullyVisible(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.HashSet<System.Int32> allObjectIds, System.Int32 inRootNodeId, System.Int32 inChildNodeId)
  RVA=0x08809258  token=0x60003C7  System.Boolean GetOutputIndex(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Int32& outputIndex)
  RVA=0x08808074  token=0x60003C8  System.Void GatherAllAssetGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo assetInfo, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos)
  RVA=0x088085F4  token=0x60003C9  System.Void GatherAllObjectGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos)
  RVA=0x08808190  token=0x60003CA  System.Void GatherAllAssetOutputs(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Boolean bUseOutputNodes, System.Boolean bOutputTemplatedGeos, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos)
  RVA=0x08809F48  token=0x60003CB  System.String ToHapiVariableName(System.String name)
  RVA=0x03D6D4D0  token=0x60003CC  System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3& position)
  RVA=0x03D6D4B0  token=0x60003CD  System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ)
  RVA=0x03D6D490  token=0x60003CE  UnityEngine.Vector3 ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ)
  RVA=0x03D6D460  token=0x60003CF  UnityEngine.Vector3 ConvertPositionUnityToHoudini(UnityEngine.Vector3 inputVec)
  RVA=0x03D6D4E0  token=0x60003D0  System.Void ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, UnityEngine.Vector3& outputVec)
  RVA=0x08807804  token=0x60003D1  System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion& rotation)
  RVA=0x088076C0  token=0x60003D2  System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion rotation, System.Single& outputX, System.Single& outputY, System.Single& outputZ, System.Single& outputW)
  RVA=0x08807774  token=0x60003D3  UnityEngine.Quaternion ConvertRotationUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, System.Single inputW)
  RVA=0x08807874  token=0x60003D4  UnityEngine.Quaternion ConvertRotationUnityToHoudini(UnityEngine.Quaternion inputQuat)
  RVA=0x0350B670  token=0x60003D5  System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3& position)
  RVA=0x03D6D500  token=0x60003D6  System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ)
  RVA=0x03D6D520  token=0x60003D7  UnityEngine.Vector3 ConvertScaleUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ)
  RVA=0x03D56520  token=0x60003D8  UnityEngine.Vector3 ConvertScaleUnityToHoudini(UnityEngine.Vector3 inputVec)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniEngineError
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x98
EXTENDS: System.Exception
FIELDS:
  protected         System.String                   _errorMsg  // 0x90
METHODS:
  RVA=0x0880AF04  token=0x60003D9  System.Void .ctor()
  RVA=0x0880AE7C  token=0x60003DA  System.Void .ctor(System.String errorMsg)
  RVA=0x03D4EA90  token=0x60003DB  System.String ToString()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Platform
TYPE:  class
TOKEN: 0x200005B
SIZE:  0x10
FIELDS:
  private   static  System.String                   _lastErrorMsg  // static @ 0x0
  private   static  System.String                   _libPath  // static @ 0x8
  private   static  System.Boolean                  _pathSet  // static @ 0x10
PROPERTIES:
  LibPath  get=0x088187A8
  IsPathSet  get=0x08818758
  DirectorySeparator  get=0x03D56180
  DirectorySeparatorStr  get=0x0881872C
METHODS:
  RVA=0x08818724  token=0x60003DE  System.Void .cctor()
  RVA=0x08818024  token=0x60003DF  System.String GetHoudiniEnginePath()
  RVA=0x08817D9C  token=0x60003E0  System.String GetHoudiniEngineDefaultPath()
  RVA=0x0881809C  token=0x60003E1  System.String GetSavedHoudiniPath()
  RVA=0x08818524  token=0x60003E2  System.Void SetHapiClientName()
  RVA=0x0350B670  token=0x60003E3  System.Void SetHoudiniEnginePath()
  RVA=0x088179F8  token=0x60003E4  System.String GetAllFoldersInPath(System.String path)
  RVA=0x088178D8  token=0x60003E5  System.Void GetAllFoldersInPathHelper(System.String inPath, System.Text.StringBuilder pathBuilder)
  RVA=0x08817B50  token=0x60003E6  System.String[] GetFilesInFolder(System.String folderPath, System.String searchPattern, System.Boolean bRecursive)
  RVA=0x08817B04  token=0x60003E7  System.String GetFileName(System.String path)
  RVA=0x08817AB8  token=0x60003E8  System.String GetFileNameWithoutExtension(System.String path)
  RVA=0x08817C68  token=0x60003E9  System.String GetFolderPath(System.String path, System.Boolean bRemoveDirectorySeparatorAtEnd)
  RVA=0x08817760  token=0x60003EC  System.String BuildPath(System.String folder1, System.String folder2, System.Object[] args)
  RVA=0x0881856C  token=0x60003ED  System.String TrimLastDirectorySeparator(System.String inPath)
  RVA=0x088178A8  token=0x60003EE  System.Boolean DoesPathExist(System.String inPath)
  RVA=0x088178A0  token=0x60003EF  System.Boolean DoesFileExist(System.String inPath)
  RVA=0x08817898  token=0x60003F0  System.Boolean DoesDirectoryExist(System.String inPath)
  RVA=0x08817870  token=0x60003F1  System.Boolean CreateDirectory(System.String inPath)
  RVA=0x0881807C  token=0x60003F2  System.String GetParentDirectory(System.String inPath)
  RVA=0x08817D50  token=0x60003F3  System.String GetFullPath(System.String inPath)
  RVA=0x088181B8  token=0x60003F4  System.Boolean IsPathRooted(System.String inPath)
  RVA=0x0881871C  token=0x60003F5  System.Void WriteBytes(System.String path, System.Byte[] bytes)
  RVA=0x088185FC  token=0x60003F6  System.Boolean WriteAllText(System.String path, System.String text)
  RVA=0x088183CC  token=0x60003F7  System.String ReadAllText(System.String path)
  RVA=0x08817AA8  token=0x60003F8  System.String GetEnvironmentValue(System.String key)
  RVA=0x08817F98  token=0x60003F9  System.String GetHoudiniEngineEnvironmentFilePathFull()
  RVA=0x08818204  token=0x60003FA  System.Boolean LoadFileIntoMemory(System.String path, System.Byte[]& buffer)
  RVA=0x0350B670  token=0x60003FB  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PlatformWin
TYPE:  static class
TOKEN: 0x200005C
SIZE:  0x10
FIELDS:
  public    static  System.UIntPtr                  HKEY_LOCAL_MACHINE  // static @ 0x0
  public    static  System.UIntPtr                  HKEY_CURRENT_USER  // static @ 0x8
METHODS:
  RVA=0x08817548  token=0x60003FC  System.UInt32 RegOpenKeyEx(System.UIntPtr hKey, System.String lpSubKey, System.UInt32 ulOptions, System.Int32 samDesired, System.Int32& phkResult)
  RVA=0x0881760C  token=0x60003FD  System.Int32 RegQueryValueEx(System.Int32 hKey, System.String lpValueName, System.Int32 lpReserved, System.UInt32& lpType, System.Text.StringBuilder lpData, System.UInt32& lpcbData)
  RVA=0x088174D0  token=0x60003FE  System.UInt32 RegCloseKey(System.Int32 hKey)
  RVA=0x08817240  token=0x60003FF  System.String GetRegistryKeyValue(System.UIntPtr rootKey, System.String keyName, HoudiniEngineUnity.HEU_PlatformWin.RegSAM is32or64Key, System.String inPropertyName)
  RVA=0x08817464  token=0x6000400  System.String GetRegistryKeyvalue_x86(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName)
  RVA=0x088173F8  token=0x6000401  System.String GetRegistryKeyvalue_x64(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName)
  RVA=0x08816EF0  token=0x6000402  System.String GetApplicationPath(System.String appName)
  RVA=0x0881770C  token=0x6000403  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PluginSettings
TYPE:  static class
TOKEN: 0x200005E
SIZE:  0x10
FIELDS:
  public    static  System.Action<System.Boolean>   s_onEnableRawHoudiniChanged  // static @ 0x0
PROPERTIES:
  HoudiniEngineEnvFilePath  get=0x088194F0  set=0x0881B024
  EnableRawHoudini  get=0x0881926C  set=0x0881AE00
  CookingEnabled  get=0x08818AC0  set=0x0881AAE8
  CookingTriggersDownstreamCooks  get=0x08818B20  set=0x0881AB38
  CookDisabledGameObjects  get=0x08818940  set=0x0881A9A8
  CookTemplatedGeos  get=0x08818A60  set=0x0881AA98
  PushUnityTransformToHoudini  get=0x08819B84  set=0x0881B534
  TransformChangeTriggersCooks  get=0x0881A19C  set=0x0881BA00
  ChildTransformChangeTriggersCooks  get=0x0881886C  set=0x0881A904
  CollisionGroupName  get=0x088188CC  set=0x0881A954
  RenderedCollisionGroupName  get=0x08819BE4  set=0x0881B584
  RenderedConvexCollisionGroupName  get=0x08819C58  set=0x0881B5D8
  UnityMaterialAttribName  get=0x0881A358  set=0x0881BB4C
  UnitySubMaterialAttribName  get=0x0881A4B4  set=0x0881BC48
  UnitySubMaterialIndexAttribName  get=0x0881A528  set=0x0881BC9C
  UnityTagAttributeName  get=0x0881A59C  set=0x0881BCF0
  UnityStaticAttributeName  get=0x0881A440  set=0x0881BBF4
  UnityScriptAttributeName  get=0x0881A3CC  set=0x0881BBA0
  UnityLayerAttributeName  get=0x0881A2E4  set=0x0881BAF8
  ImageGamma  get=0x088195D8  set=0x0881B0E0
  NormalGenerationThresholdAngle  get=0x08819B1C  set=0x0881B4DC
  LastLoadHDAPath  get=0x08819938  set=0x0881B378
  LastLoadHIPPath  get=0x088199AC  set=0x0881B3CC
  InstanceAttr  get=0x088197DC  set=0x0881B27C
  UnityInstanceAttr  get=0x0881A270  set=0x0881BAA4
  UnityInputMeshAttr  get=0x0881A1FC  set=0x0881BA50
  LineColor  get=0x08819A20  set=0x0881B420
  UseHybridCurveEditing  get=0x0881A6D0  set=0x0881BDE4
  EditorOnly_Tag  get=0x088191F8  set=0x0881AD7C
  HDAData_Name  get=0x088192CC  set=0x0881AED0
  Session_Mode  get=0x08819E00  set=0x0881B720
  Session_PipeName  get=0x08819E68  set=0x0881B770
  Session_Localhost  get=0x08819D8C  set=0x0881B6CC
  Session_Port  get=0x08819EDC  set=0x0881B7C4
  Session_Timeout  get=0x08819F40  set=0x0881B814
  Session_AutoClose  get=0x08819D2C  set=0x0881B67C
  Curves_ShowInSceneView  get=0x08818B80  set=0x0881AB88
  AssetCachePath  get=0x088187F8  set=0x0881A8B0
  UseFullPathNamesForOutput  get=0x0881A610  set=0x0881BD44
  HEngineToolsShelves  get=0x088193A0  set=0x0881AF74
  HEngineShelfSelectedIndex  get=0x08819340  set=0x0881AF24
  DefaultTerrainMaterial  get=0x08818E7C  set=0x0881AC80
  TerrainSplatTextureDefault  get=0x0881A128  set=0x0881B9AC
  DefaultStandardShader  get=0x08818CF8  set=0x0881AC2C
  DefaultVertexColorShader  get=0x08819074  set=0x0881AD28
  DefaultTransparentShader  get=0x08818EF0  set=0x0881ACD4
  DefaultCurveShader  get=0x08818BE0  set=0x0881ABD8
  SupportHoudiniBoxType  get=0x0881A068  set=0x0881B90C
  SupportHoudiniSphereType  get=0x0881A0C8  set=0x0881B95C
  SetCurrentThreadToInvariantCulture  get=0x08819FA8  set=0x0881B86C
  HoudiniDebugLaunchPath  get=0x08819404  set=0x0881AFD0
  LastExportPath  get=0x08819850  set=0x0881B2D0
  InputSelectionFilterLocation  get=0x08819640  set=0x0881B138
  InputSelectionFilterState  get=0x08819778  set=0x0881B22C
  InputSelectionFilterRoots  get=0x08819718  set=0x0881B1DC
  InputSelectionFilterName  get=0x088196A4  set=0x0881B188
  CookOptionSplitGeosByGroup  get=0x08818A00  set=0x0881AA48
  MaxVerticesPerPrimitive  get=0x08819AB8  set=0x0881B48C
  HoudiniInstallPath  get=0x08819564  set=0x0881B08C
  LastHoudiniVersion  get=0x088198C4  set=0x0881B324
  SessionSyncAutoCook  get=0x08819CCC  set=0x0881B62C
  WriteCookLogs  get=0x0881A850  set=0x0881BF24
  UseHDRColor  get=0x0881A670  set=0x0881BD94
  UseSpecularShader  get=0x0881A7F0  set=0x0881BED4
  UseLegacyShaders  get=0x0881A790  set=0x0881BE84
  ShortenFolderPaths  get=0x0881A008  set=0x0881B8BC
  UseLegacyInputCurves  get=0x0881A730  set=0x0881BE34
  CookOnMouseUp  get=0x088189A0  set=0x0881A9F8
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PluginStorage
TYPE:  class
TOKEN: 0x200005F
SIZE:  0x28
FIELDS:
  protected         System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_PluginStorage.StoreData>_dataMap  // 0x10
  private           System.Collections.Generic.Dictionary<System.String,System.String>_envPathMap  // 0x18
  protected         System.Boolean                  _requiresSave  // 0x20
  private   static  HoudiniEngineUnity.HEU_PluginStorage_instance  // static @ 0x0
  public    static  System.String                   PluginSettingsLine1  // const
  public    static  System.String                   PluginSettingsLine2  // const
  public    static  System.String                   PluginSettingsVersion  // const
PROPERTIES:
  RequiresSave  get=0x03D4EF90
  Instance  get=0x0881E3BC
METHODS:
  RVA=0x01041090  token=0x600048C  System.Collections.Generic.Dictionary<System.String,System.String> GetEnvironmentPathMap()
  RVA=0x0881CB2C  token=0x600048F  System.Void InstantiateAndLoad()
  RVA=0x0350B670  token=0x6000490  System.Void SetCurrentCulture(System.Boolean useInvariant)
  RVA=-1  // generic def  token=0x6000491  T[] GetJSONArray(System.String jsonArray)
  RVA=0x0881E1D0  token=0x6000492  System.Void Set(System.String key, System.Boolean value)
  RVA=0x0881DF0C  token=0x6000493  System.Void Set(System.String key, System.Int32 value)
  RVA=0x0881DE48  token=0x6000494  System.Void Set(System.String key, System.Int64 value)
  RVA=0x0881E10C  token=0x6000495  System.Void Set(System.String key, System.Single value)
  RVA=0x0881DDB0  token=0x6000496  System.Void Set(System.String key, System.String value)
  RVA=0x0881DFD0  token=0x6000497  System.Void Set(System.String key, System.Collections.Generic.List<System.String> values, System.Char delimiter)
  RVA=0x0881C894  token=0x6000498  System.Boolean Get(System.String key, System.Boolean& value, System.Boolean defaultValue)
  RVA=0x0881C5A0  token=0x6000499  System.Boolean Get(System.String key, System.Int32& value, System.Int32 defaultValue)
  RVA=0x0881C7C0  token=0x600049A  System.Boolean Get(System.String key, System.Int64& value, System.Int64 defaultValue)
  RVA=0x0881CA2C  token=0x600049B  System.Boolean Get(System.String key, System.Single& value, System.Single defaultValue)
  RVA=0x0881C968  token=0x600049C  System.Boolean Get(System.String key, System.String& value, System.String defaultValue)
  RVA=0x0881C674  token=0x600049D  System.Boolean Get(System.String key, System.Collections.Generic.List<System.String>& values, System.Char delimiter)
  RVA=0x0350B670  token=0x600049E  System.Void MarkDirtyForSave()
  RVA=0x0881D85C  token=0x600049F  System.Void SaveIfRequired()
  RVA=0x0881E294  token=0x60004A0  System.String SettingsFilePath()
  RVA=0x0881D8A8  token=0x60004A1  System.Boolean SavePluginData(System.String file)
  RVA=0x0881D04C  token=0x60004A2  System.Boolean LoadPluginData(System.String file)
  RVA=0x0115F4C0  token=0x60004A3  System.Boolean ReadFromEditorPrefs()
  RVA=0x0881BF74  token=0x60004A4  System.Void ClearPluginData()
  RVA=0x0881D004  token=0x60004A5  System.Void LoadFromSavedFile()
  RVA=0x0881DD00  token=0x60004A6  System.String SessionFilePath()
  RVA=0x0350B670  token=0x60004A7  System.Void SaveAllSessionData(System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionBase> allSessions, System.String path)
  RVA=0x0881CC14  token=0x60004A8  System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionData> LoadAllSessionData(System.String path)
  RVA=0x0350B670  token=0x60004A9  System.Void DeleteAllSavedSessionData(System.String file)
  RVA=0x0881CC74  token=0x60004AA  System.Void LoadAssetEnvironmentPaths()
  RVA=0x0881C2D0  token=0x60004AB  System.String ConvertRealPathToEnvKeyedPath(System.String inPath)
  RVA=0x0881C02C  token=0x60004AC  System.String ConvertEnvKeyedPathToReal(System.String inPath)
  RVA=0x0881E344  token=0x60004AD  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Handle
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x98
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.String                   _handleName  // 0x18
  private           HoudiniEngineUnity.HEU_Handle.HEU_HandleType_handleType  // 0x20
  private           System.Int32                    _handleIndex  // 0x24
  private           HoudiniEngineUnity.HEU_HandleParamBinding_handleParamTranslateBinding  // 0x28
  private           HoudiniEngineUnity.HEU_HandleParamBinding_handleParamRotateBinding  // 0x30
  private           HoudiniEngineUnity.HEU_HandleParamBinding_handleParamScaleBinding  // 0x38
  private           UnityEngine.Vector3             _handlePosition  // 0x40
  private           UnityEngine.Quaternion          _handleRotation  // 0x4c
  private           UnityEngine.Vector3             _handleScale  // 0x5c
  private           HoudiniEngineUnity.HAPI_RSTOrder_rstOrder  // 0x68
  private           HoudiniEngineUnity.HAPI_XYZOrder_xyzOrder  // 0x6c
  private           HoudiniEngineUnity.HAPI_TransformEuler_convertedTransformEuler  // 0x70
PROPERTIES:
  HandleName  get=0x01041090
  HandleType  get=0x01003B50
  RSTOrder  get=0x03D4EEE0
  XYZOrder  get=0x03D4F400
  ConvertedTransformEuler  get=0x03D6D630
  HandlePosition  get=0x03D52300
  HandleRotation  get=0x03D5E6D0
  HandleScale  get=0x03D6D660
METHODS:
  RVA=0x05693D38  token=0x60004B5  System.Boolean HasTranslateHandle()
  RVA=0x085839D0  token=0x60004B6  System.Boolean HasRotateHandle()
  RVA=0x060DAC58  token=0x60004B7  System.Boolean HasScaleHandle()
  RVA=0x0880ACDC  token=0x60004B8  System.Boolean IsTranslateHandleDisabled()
  RVA=0x0880ACA0  token=0x60004B9  System.Boolean IsRotateHandleDisabled()
  RVA=0x0880ACB4  token=0x60004BA  System.Boolean IsScaleHandleDisabled()
  RVA=0x03D4EAC0  token=0x60004BB  HoudiniEngineUnity.HEU_HandleParamBinding GetTranslateBinding()
  RVA=0x01003830  token=0x60004BC  HoudiniEngineUnity.HEU_HandleParamBinding GetRotateBinding()
  RVA=0x03D4E2A0  token=0x60004BD  HoudiniEngineUnity.HEU_HandleParamBinding GetScaleBinding()
  RVA=0x0880ACF0  token=0x60004C1  System.Boolean SetupHandle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 handleIndex, System.String handleName, HoudiniEngineUnity.HEU_Handle.HEU_HandleType handleType, HoudiniEngineUnity.HAPI_HandleInfo& handleInfo, HoudiniEngineUnity.HEU_Parameters parameters)
  RVA=0x0880A1E8  token=0x60004C2  System.Void CleanUp()
  RVA=0x0880A220  token=0x60004C3  System.Void GenerateTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_Parameters parameters)
  RVA=0x0880A638  token=0x60004C4  System.Boolean GetUpdatedPosition(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Vector3& inPosition)
  RVA=0x0880A6F4  token=0x60004C5  System.Boolean GetUpdatedRotation(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Quaternion& inRotation)
  RVA=0x0880ACC8  token=0x60004C6  System.Boolean IsSpecialRSTOrder(HoudiniEngineUnity.HAPI_RSTOrder rstOrder)
  RVA=0x0880A828  token=0x60004C7  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Handle other)
  RVA=0x0880AE14  token=0x60004C8  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HandleParamBinding
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x30
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType_paramType  // 0x10
  public            System.Int32                    _parmID  // 0x14
  public            System.String                   _paramName  // 0x18
  public            System.Boolean                  _bDisabled  // 0x20
  public            System.Boolean[]                _boundChannels  // 0x28
METHODS:
  RVA=0x08809FD4  token=0x60004C9  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HandleParamBinding other)
  RVA=0x0880A1A0  token=0x60004CA  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HAPIConstants
TYPE:  static class
TOKEN: 0x2000067
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    HAPI_POSITION_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_SCALE_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_SHEAR_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_NORMAL_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_QUATERNION_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_EULER_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_UV_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_COLOR_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_CV_VECTOR_SIZE  // const
  public    static  System.Int32                    HAPI_PRIM_MIN_VERTEX_COUNT  // const
  public    static  System.Int32                    HAPI_PRIM_MAX_VERTEX_COUNT  // const
  public    static  System.Int32                    HAPI_INVALID_PARM_ID  // const
  public    static  System.String                   HAPI_ATTRIB_POSITION  // const
  public    static  System.String                   HAPI_ATTRIB_UV  // const
  public    static  System.String                   HAPI_ATTRIB_UV2  // const
  public    static  System.String                   HAPI_ATTRIB_NORMAL  // const
  public    static  System.String                   HAPI_ATTRIB_TANGENT  // const
  public    static  System.String                   HAPI_ATTRIB_TANGENT2  // const
  public    static  System.String                   HAPI_ATTRIB_COLOR  // const
  public    static  System.String                   HAPI_ATTRIB_NAME  // const
  public    static  System.String                   HAPI_ATTRIB_INSTANCE  // const
  public    static  System.String                   HAPI_ATTRIB_ROT  // const
  public    static  System.String                   HAPI_ATTRIB_SCALE  // const
  public    static  System.String                   HAPI_UNGROUPED_GROUP_NAME  // const
  public    static  System.String                   HAPI_RAW_FORMAT_NAME  // const
  public    static  System.String                   HAPI_PNG_FORMAT_NAME  // const
  public    static  System.String                   HAPI_JPEG_FORMAT_NAME  // const
  public    static  System.String                   HAPI_BMP_FORMAT_NAME  // const
  public    static  System.String                   HAPI_TIFF_FORMAT_NAME  // const
  public    static  System.String                   HAPI_TGA_FORMAT_NAME  // const
  public    static  System.String                   HAPI_DEFAULT_IMAGE_FORMAT_NAME  // const
  public    static  System.String                   HAPI_GLOBAL_NODES_NODE_NAME  // const
  public    static  System.String                   HAPI_ENV_HIP  // const
  public    static  System.String                   HAPI_ENV_JOB  // const
  public    static  System.String                   HAPI_ENV_CLIENT_NAME  // const
  public    static  System.String                   HAPI_CACHE_COP_COOK  // const
  public    static  System.String                   HAPI_CACHE_COP_FLIPBOOK  // const
  public    static  System.String                   HAPI_CACHE_IMAGE  // const
  public    static  System.String                   HAPI_CACHE_OBJ  // const
  public    static  System.String                   HAPI_CACHE_GL_TEXTURE  // const
  public    static  System.String                   HAPI_CACHE_GL_VERTEX  // const
  public    static  System.String                   HAPI_CACHE_SOP  // const
  public    static  System.String                   HAPI_CACHE_VEX  // const
  public    static  System.String                   HAPI_ATTRIB_INPUT_CURVE_COORDS  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_License
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_NONE  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_FX  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_INDIE  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_INDIE  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL  // const
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_StatusType
TYPE:  sealed struct
TOKEN: 0x2000069
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_CALL_RESULT  // const
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_COOK_RESULT  // const
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_COOK_STATE  // const
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_StatusVerbosity
TYPE:  sealed struct
TOKEN: 0x200006A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_0  // const
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_1  // const
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_2  // const
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_ALL  // const
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_ERRORS  // const
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_WARNINGS  // const
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_MESSAGES  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Result
TYPE:  sealed struct
TOKEN: 0x200006B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_SUCCESS  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_FAILURE  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_ALREADY_INITIALIZED  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_NOT_INITIALIZED  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_LOADFILE  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_PARM_SET_FAILED  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_INVALID_ARGUMENT  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_LOAD_GEO  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_GENERATE_PRESET  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_LOAD_PRESET  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_ASSET_DEF_ALREADY_LOADED  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_NO_LICENSE_FOUND  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_NC_LICENSE_FOUND  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_C_LICENSE  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_LC_LICENSE  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_LC_ASSET_WITH_C_LICENSE  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_HENGINEINDIE_W_3PARTY_PLUGIN  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_ASSET_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_NODE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_USER_INTERRUPTED  // const
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_INVALID_SESSION  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ErrorCode
TYPE:  sealed struct
TOKEN: 0x200006C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ErrorCodeHAPI_ERRORCODE_ASSET_DEF_NOT_FOUND  // const
  public    static  HoudiniEngineUnity.HAPI_ErrorCodeHAPI_ERRORCODE_PYTHON_NODE_ERROR  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SessionType
TYPE:  sealed struct
TOKEN: 0x200006D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_INPROCESS  // const
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_THRIFT  // const
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_CUSTOM1  // const
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_CUSTOM2  // const
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_CUSTOM3  // const
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_State
TYPE:  sealed struct
TOKEN: 0x200006E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_READY  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_READY_WITH_FATAL_ERRORS  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_READY_WITH_COOK_ERRORS  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_STARTING_COOK  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_COOKING  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_STARTING_LOAD  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_LOADING  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_MAX_READY_STATE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PackedPrimInstancingMode
TYPE:  sealed struct
TOKEN: 0x200006F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED  // const
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY  // const
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_FLAT  // const
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Permissions
TYPE:  sealed struct
TOKEN: 0x2000070
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_NON_APPLICABLE  // const
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_READ_WRITE  // const
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_READ_ONLY  // const
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_WRITE_ONLY  // const
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_RampType
TYPE:  sealed struct
TOKEN: 0x2000071
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_FLOAT  // const
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_COLOR  // const
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ParmType
TYPE:  sealed struct
TOKEN: 0x2000072
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_INT  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_MULTIPARMLIST  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_TOGGLE  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_BUTTON  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FLOAT  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_COLOR  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_STRING  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE_GEO  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE_IMAGE  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NODE  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FOLDERLIST  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FOLDERLIST_RADIO  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FOLDER  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_LABEL  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_SEPARATOR  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE_DIR  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_INT_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_INT_END  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FLOAT_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FLOAT_END  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_STRING_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_STRING_END  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_END  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NODE_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NODE_END  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_CONTAINER_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_CONTAINER_END  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NONVALUE_START  // const
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NONVALUE_END  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PrmScriptType
TYPE:  sealed struct
TOKEN: 0x2000073
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FLOAT  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_ANGLE  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_STRING  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FILE  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_DIRECTORY  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_IMAGE  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GEOMETRY  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_TOGGLE  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_BUTTON  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_VECTOR2  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_VECTOR3  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_VECTOR4  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INTVECTOR2  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INTVECTOR3  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INTVECTOR4  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_UV  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_UVW  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_DIR  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_COLOR  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_COLOR4  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OPPATH  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OPLIST  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OBJECT  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OBJECTLIST  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RENDER  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_SEPARATOR  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_LABEL  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RGBAMASK  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_ORDINAL  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RAMP_FLT  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RAMP_RGB  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FLOAT_LOG  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT_LOG  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_DATA  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT_MINMAX  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT_STARTEND  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_ICONSTRIP  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUPRADIO  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE  // const
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUP  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ChoiceListType
TYPE:  sealed struct
TOKEN: 0x2000074
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_NONE  // const
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_NORMAL  // const
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_MINI  // const
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_REPLACE  // const
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_TOGGLE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PresetType
TYPE:  sealed struct
TOKEN: 0x2000075
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_BINARY  // const
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_IDX  // const
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_NodeType
TYPE:  sealed struct
TOKEN: 0x2000076
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_ANY  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_NONE  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_OBJ  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_SOP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_CHOP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_ROP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_SHOP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_COP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_VOP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_DOP  // const
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_TOP  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_NodeFlags
TYPE:  sealed struct
TOKEN: 0x2000077
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_ANY  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_NONE  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_DISPLAY  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_RENDER  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_TEMPLATED  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_LOCKED  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_EDITABLE  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_BYPASS  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_NETWORK  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_GEOMETRY  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_CAMERA  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_LIGHT  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_SUBNET  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_SOP_CURVE  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_SOP_GUIDE  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_TOP_NONSCHEDULER  // const
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_NON_BYPASS  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_GroupType
TYPE:  sealed struct
TOKEN: 0x2000078
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_POINT  // const
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_PRIM  // const
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_EDGE  // const
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AttributeOwner
TYPE:  sealed struct
TOKEN: 0x2000079
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_VERTEX  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_POINT  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_PRIM  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_DETAIL  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CurveType
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_LINEAR  // const
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_NURBS  // const
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_BEZIER  // const
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputCurveMethod
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_CVS  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_BREAKPOINTS  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputCurveParameterization
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_UNIFORM  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_CHORD  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_CENTRIPETAL  // const
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeType
TYPE:  sealed struct
TOKEN: 0x200007D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_HOUDINI  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_VDB  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeVisualType
TYPE:  sealed struct
TOKEN: 0x200007E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_SMOKE  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_RAINBOW  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_ISO  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_INVISIBLE  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_HEIGHTFIELD  // const
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_StorageType
TYPE:  sealed struct
TOKEN: 0x200007F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT64  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT64  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_STRING  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_UINT8  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT8  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT16  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT64_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT64_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_STRING_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_UINT8_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT8_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT16_ARRAY  // const
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AttributeTypeInfo
TYPE:  sealed struct
TOKEN: 0x2000080
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_NONE  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_POINT  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_HPOINT  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_VECTOR  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_NORMAL  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_COLOR  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_QUATERNION  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_MATRIX3  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_MATRIX  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_ST  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_HIDDEN  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_BOX2  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_BOX  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_TEXTURE  // const
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_GeoType
TYPE:  sealed struct
TOKEN: 0x2000081
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_DEFAULT  // const
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INTERMEDIATE  // const
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INPUT  // const
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_CURVE  // const
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PartType
TYPE:  sealed struct
TOKEN: 0x2000082
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_MESH  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_CURVE  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_VOLUME  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_INSTANCER  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_BOX  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_SPHERE  // const
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputType
TYPE:  sealed struct
TOKEN: 0x2000083
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_TRANSFORM  // const
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_GEOMETRY  // const
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CurveOrders
TYPE:  sealed struct
TOKEN: 0x2000084
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_VARYING  // const
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_LINEAR  // const
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_QUADRATIC  // const
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_CUBIC  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_TransformComponent
TYPE:  sealed struct
TOKEN: 0x2000085
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_TX  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_TY  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_TZ  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_RX  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_RY  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_RZ  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QX  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QY  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QZ  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QW  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_SX  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_SY  // const
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_SZ  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_RSTOrder
TYPE:  sealed struct
TOKEN: 0x2000086
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_TRS  // const
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_TSR  // const
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_RTS  // const
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_RST  // const
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_STR  // const
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_SRT  // const
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_RSTORDER_DEFAULT  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_XYZOrder
TYPE:  sealed struct
TOKEN: 0x2000087
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_XYZ  // const
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_XZY  // const
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_YXZ  // const
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_YZX  // const
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_ZXY  // const
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_ZYX  // const
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_XYZORDER_DEFAULT  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImageDataFormat
TYPE:  sealed struct
TOKEN: 0x2000088
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_UNKNOWN  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_INT8  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_INT16  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_INT32  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_FLOAT16  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_FLOAT32  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_DEFAULT  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImagePacking
TYPE:  sealed struct
TOKEN: 0x2000089
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_UNKNOWN  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_SINGLE  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_DUAL  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_RGB  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_BGR  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_RGBA  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_ABGR  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_DEFAULT3  // const
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_DEFAULT4  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_EnvIntType
TYPE:  sealed struct
TOKEN: 0x200008A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_MAJOR  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_MINOR  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_BUILD  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_PATCH  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_ENGINE_MAJOR  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_ENGINE_MINOR  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_ENGINE_API  // const
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SessionEnvIntType
TYPE:  sealed struct
TOKEN: 0x200008B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_SessionEnvIntTypeHAPI_SESSIONENVINT_INVALID  // const
  public    static  HoudiniEngineUnity.HAPI_SessionEnvIntTypeHAPI_SESSIONENVINT_LICENSE  // const
  public    static  HoudiniEngineUnity.HAPI_SessionEnvIntTypeHAPI_SESSIONENVINT_MAX  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CacheProperty
TYPE:  sealed struct
TOKEN: 0x200008C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_CURRENT  // const
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_HAS_MIN  // const
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_MIN  // const
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_HAS_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_CULL_LEVEL  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_HeightFieldSampling
TYPE:  sealed struct
TOKEN: 0x200008D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_HeightFieldSamplingHAPI_HEIGHTFIELD_SAMPLING_CENTER  // const
  public    static  HoudiniEngineUnity.HAPI_HeightFieldSamplingHAPI_HEIGHTFIELD_SAMPLING_CORNER  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_State
TYPE:  sealed struct
TOKEN: 0x200008E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_READY  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_COOKING  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_MAX  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_MAX_READY_STATE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_EventType
TYPE:  sealed struct
TOKEN: 0x200008F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NULL  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_STATE_CHANGE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD_DEP  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE_DEP  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD_PARENT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE_PARENT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_CLEAR  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_ERROR  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_WARNING  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_COMPLETE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_DIRTY_START  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_DIRTY_STOP  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_DIRTY_ALL  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_UI_SELECT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_CREATE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_REMOVE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_RENAME  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_CONNECT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_DISCONNECT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_INT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_FLOAT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_STRING  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_FILE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_MERGE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_RESULT  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_PRIORITY  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_START  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_PROGRESS_UPDATE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_ALL  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_LOG  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SCHEDULER_ADDED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SCHEDULER_REMOVED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SET_SCHEDULER  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SERVICE_MANAGER_ALL  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_COOKED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_GENERATED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_CONTEXT_EVENTS  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_WorkItemState
TYPE:  sealed struct
TOKEN: 0x2000090
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_UNDEFINED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_UNCOOKED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_WAITING  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_SCHEDULED  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKING  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_SUCCESS  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_CACHE  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_FAIL  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_CANCEL  // const
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_DIRTY  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HAPIFunctions
TYPE:  static class
TOKEN: 0x2000091
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Transform
TYPE:  sealed struct
TOKEN: 0x2000092
SIZE:  0x38
FIELDS:
  public            System.Single[]                 position  // 0x10
  public            System.Single[]                 rotationQuaternion  // 0x18
  public            System.Single[]                 scale  // 0x20
  public            System.Single[]                 shear  // 0x28
  public            HoudiniEngineUnity.HAPI_RSTOrderrstOrder  // 0x30
METHODS:
  RVA=0x08805510  token=0x60004CB  System.Void .ctor(System.Boolean initializeFields)
  RVA=0x08805450  token=0x60004CC  System.Void Init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_TransformEuler
TYPE:  sealed struct
TOKEN: 0x2000093
SIZE:  0x38
FIELDS:
  public            System.Single[]                 position  // 0x10
  public            System.Single[]                 rotationEuler  // 0x18
  public            System.Single[]                 scale  // 0x20
  public            System.Single[]                 shear  // 0x28
  public            HoudiniEngineUnity.HAPI_XYZOrderrotationOrder  // 0x30
  public            HoudiniEngineUnity.HAPI_RSTOrderrstOrder  // 0x34
METHODS:
  RVA=0x08805388  token=0x60004CD  System.Void .ctor(System.Boolean initializeFields)
  RVA=0x088052E4  token=0x60004CE  System.Void Init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Session
TYPE:  sealed struct
TOKEN: 0x2000094
SIZE:  0x20
FIELDS:
  public            HoudiniEngineUnity.HAPI_SessionTypetype  // 0x10
  public            System.Int64                    id  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ThriftServerOptions
TYPE:  sealed struct
TOKEN: 0x2000095
SIZE:  0x1C
FIELDS:
  public            System.Boolean                  autoClose  // 0x10
  public            System.Single                   timeoutMs  // 0x14
  public            HoudiniEngineUnity.HAPI_StatusVerbosityverbosity  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_TimelineOptions
TYPE:  sealed struct
TOKEN: 0x2000096
SIZE:  0x1C
FIELDS:
  public            System.Single                   fps  // 0x10
  public            System.Single                   startTime  // 0x14
  public            System.Single                   endTime  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AssetInfo
TYPE:  sealed struct
TOKEN: 0x2000097
SIZE:  0x50
FIELDS:
  public            System.Int32                    nodeId  // 0x10
  public            System.Int32                    objectNodeId  // 0x14
  public            System.Boolean                  hasEverCooked  // 0x18
  public            System.Int32                    nameSH  // 0x1c
  public            System.Int32                    labelSH  // 0x20
  public            System.Int32                    filePathSH  // 0x24
  public            System.Int32                    versionSH  // 0x28
  public            System.Int32                    fullOpNameSH  // 0x2c
  public            System.Int32                    helpTextSH  // 0x30
  public            System.Int32                    helpURLSH  // 0x34
  public            System.Int32                    objectCount  // 0x38
  public            System.Int32                    handleCount  // 0x3c
  public            System.Int32                    transformInputCount  // 0x40
  public            System.Int32                    geoInputCount  // 0x44
  public            System.Int32                    geoOutputCount  // 0x48
  public            System.Boolean                  haveObjectsChanged  // 0x4c
  public            System.Boolean                  haveMaterialsChanged  // 0x4d
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CookOptions
TYPE:  sealed struct
TOKEN: 0x2000098
SIZE:  0x40
FIELDS:
  public            System.Boolean                  splitGeosByGroup  // 0x10
  public            System.Int32                    splitGroupSH  // 0x14
  public            System.Boolean                  splitGeosByAttribute  // 0x18
  public            System.Int32                    splitAttrSH  // 0x1c
  public            System.Int32                    maxVerticesPerPrimitive  // 0x20
  public            System.Boolean                  refineCurveToLinear  // 0x24
  public            System.Single                   curveRefineLOD  // 0x28
  public            System.Boolean                  clearErrorsAndWarnings  // 0x2c
  public            System.Boolean                  cookTemplatedGeos  // 0x2d
  public            System.Boolean                  splitPointsByVertexAttributes  // 0x2e
  public            HoudiniEngineUnity.HAPI_PackedPrimInstancingModepackedPrimInstancingMode  // 0x30
  public            System.Boolean                  handleBoxPartTypes  // 0x34
  public            System.Boolean                  handleSpherePartTypes  // 0x35
  public            System.Boolean                  checkPartChanges  // 0x36
  public            System.Boolean                  cacheMeshTopology  // 0x37
  public            System.Boolean                  preferOutputNodes  // 0x38
  public            System.Int32                    extraFlags  // 0x3c
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_NodeInfo
TYPE:  sealed struct
TOKEN: 0x2000099
SIZE:  0x54
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    parentId  // 0x14
  public            System.Int32                    nameSH  // 0x18
  public            HoudiniEngineUnity.HAPI_NodeTypetype  // 0x1c
  public            System.Boolean                  isValid  // 0x20
  public            System.Int32                    totalCookCount  // 0x24
  public            System.Int32                    uniqueHoudiniNodeId  // 0x28
  public            System.Int32                    internalNodePathSH  // 0x2c
  public            System.Int32                    parmCount  // 0x30
  public            System.Int32                    parmIntValueCount  // 0x34
  public            System.Int32                    parmFloatValueCount  // 0x38
  public            System.Int32                    parmStringValueCount  // 0x3c
  public            System.Int32                    parmChoiceCount  // 0x40
  public            System.Int32                    childNodeCount  // 0x44
  public            System.Int32                    inputCount  // 0x48
  public            System.Int32                    outputCount  // 0x4c
  public            System.Boolean                  createdPostAssetLoad  // 0x50
  public            System.Boolean                  isTimeDependent  // 0x51
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ParmInfo
TYPE:  sealed struct
TOKEN: 0x200009A
SIZE:  0xA4
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    parentId  // 0x14
  public            System.Int32                    childIndex  // 0x18
  public            HoudiniEngineUnity.HAPI_ParmTypetype  // 0x1c
  public            HoudiniEngineUnity.HAPI_PrmScriptTypescriptType  // 0x20
  public            System.Int32                    typeInfoSH  // 0x24
  public            HoudiniEngineUnity.HAPI_Permissionspermissions  // 0x28
  public            System.Int32                    tagCount  // 0x2c
  public            System.Int32                    size  // 0x30
  public            HoudiniEngineUnity.HAPI_ChoiceListTypechoiceListType  // 0x34
  public            System.Int32                    choiceCount  // 0x38
  public            System.Int32                    nameSH  // 0x3c
  public            System.Int32                    labelSH  // 0x40
  public            System.Int32                    templateNameSH  // 0x44
  public            System.Int32                    helpSH  // 0x48
  public            System.Boolean                  hasMin  // 0x4c
  public            System.Boolean                  hasMax  // 0x4d
  public            System.Boolean                  hasUIMin  // 0x4e
  public            System.Boolean                  hasUIMax  // 0x4f
  public            System.Single                   min  // 0x50
  public            System.Single                   max  // 0x54
  public            System.Single                   UIMin  // 0x58
  public            System.Single                   UIMax  // 0x5c
  public            System.Boolean                  invisible  // 0x60
  public            System.Boolean                  disabled  // 0x61
  public            System.Boolean                  spare  // 0x62
  public            System.Boolean                  joinNext  // 0x63
  public            System.Boolean                  labelNone  // 0x64
  public            System.Int32                    intValuesIndex  // 0x68
  public            System.Int32                    floatValuesIndex  // 0x6c
  public            System.Int32                    stringValuesIndex  // 0x70
  public            System.Int32                    choiceIndex  // 0x74
  public            HoudiniEngineUnity.HAPI_NodeTypeinputNodeType  // 0x78
  public            HoudiniEngineUnity.HAPI_NodeFlagsinputNodeFlag  // 0x7c
  public            System.Boolean                  isChildOfMultiParm  // 0x80
  public            System.Int32                    instanceNum  // 0x84
  public            System.Int32                    instanceLength  // 0x88
  public            System.Int32                    instanceCount  // 0x8c
  public            System.Int32                    instanceStartOffset  // 0x90
  public            HoudiniEngineUnity.HAPI_RampTyperampType  // 0x94
  public            System.Int32                    visibilityConditionSH  // 0x98
  public            System.Int32                    disabledConditionSH  // 0x9c
  public            System.Boolean                  useMenuItemTokenAsValue  // 0xa0
METHODS:
  RVA=0x08804FBC  token=0x60004CF  System.Boolean isInt()
  RVA=0x08804FA8  token=0x60004D0  System.Boolean isFloat()
  RVA=0x08805018  token=0x60004D1  System.Boolean isString()
  RVA=0x08805000  token=0x60004D2  System.Boolean isPath()
  RVA=0x08804FDC  token=0x60004D3  System.Boolean isNode()
  RVA=0x08804FEC  token=0x60004D4  System.Boolean isNonValue()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ParmChoiceInfo
TYPE:  sealed struct
TOKEN: 0x200009B
SIZE:  0x1C
FIELDS:
  public            System.Int32                    parentParmId  // 0x10
  public            System.Int32                    labelSH  // 0x14
  public            System.Int32                    valueSH  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_HandleInfo
TYPE:  sealed struct
TOKEN: 0x200009C
SIZE:  0x1C
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            System.Int32                    typeNameSH  // 0x14
  public            System.Int32                    bindingsCount  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_HandleBindingInfo
TYPE:  sealed struct
TOKEN: 0x200009D
SIZE:  0x20
FIELDS:
  public            System.Int32                    handleParmNameSH  // 0x10
  public            System.Int32                    assetParmNameSH  // 0x14
  public            System.Int32                    assetParmId  // 0x18
  public            System.Int32                    assetParmIndex  // 0x1c
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ObjectInfo
TYPE:  sealed struct
TOKEN: 0x200009E
SIZE:  0x2C
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            System.Int32                    objectInstancePathSH  // 0x14
  public            System.Boolean                  hasTransformChanged  // 0x18
  public            System.Boolean                  haveGeosChanged  // 0x19
  public            System.Boolean                  isVisible  // 0x1a
  public            System.Boolean                  isInstancer  // 0x1b
  public            System.Boolean                  isInstanced  // 0x1c
  public            System.Int32                    geoCount  // 0x20
  public            System.Int32                    nodeId  // 0x24
  public            System.Int32                    objectToInstanceId  // 0x28
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_GeoInfo
TYPE:  sealed struct
TOKEN: 0x200009F
SIZE:  0x34
FIELDS:
  public            HoudiniEngineUnity.HAPI_GeoType type  // 0x10
  public            System.Int32                    nameSH  // 0x14
  public            System.Int32                    nodeId  // 0x18
  public            System.Boolean                  isEditable  // 0x1c
  public            System.Boolean                  isTemplated  // 0x1d
  public            System.Boolean                  isDisplayGeo  // 0x1e
  public            System.Boolean                  hasGeoChanged  // 0x1f
  public            System.Boolean                  hasMaterialChanged  // 0x20
  public            System.Int32                    pointGroupCount  // 0x24
  public            System.Int32                    primitiveGroupCount  // 0x28
  public            System.Int32                    edgeGroupCount  // 0x2c
  public            System.Int32                    partCount  // 0x30
METHODS:
  RVA=0x08804F44  token=0x60004D5  System.Int32 getGroupCountByType(HoudiniEngineUnity.HAPI_GroupType type)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PartInfo
TYPE:  sealed struct
TOKEN: 0x20000A0
SIZE:  0x40
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    nameSH  // 0x14
  public            HoudiniEngineUnity.HAPI_PartTypetype  // 0x18
  public            System.Int32                    faceCount  // 0x1c
  public            System.Int32                    vertexCount  // 0x20
  public            System.Int32                    pointCount  // 0x24
  public            System.Int32[]                  attributeCounts  // 0x28
  public            System.Boolean                  isInstanced  // 0x30
  public            System.Int32                    instancedPartCount  // 0x34
  public            System.Int32                    instanceCount  // 0x38
  public            System.Boolean                  hasChanged  // 0x3c
PROPERTIES:
  pointAttributeCount  get=0x088050A8  set=0x088051D4
  primitiveAttributeCount  get=0x088050DC  set=0x08805214
  vertexAttributeCount  get=0x08805110  set=0x08805254
  detailAttributeCount  get=0x08805074  set=0x08805194
METHODS:
  RVA=0x08805038  token=0x60004D6  System.Int32 getElementCountByAttributeOwner(HoudiniEngineUnity.HAPI_AttributeOwner owner)
  RVA=0x08805060  token=0x60004D7  System.Int32 getElementCountByGroupType(HoudiniEngineUnity.HAPI_GroupType type)
  RVA=0x08805144  token=0x60004D8  System.Void init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AttributeInfo
TYPE:  sealed struct
TOKEN: 0x20000A1
SIZE:  0x38
FIELDS:
  public            System.Boolean                  exists  // 0x10
  public            HoudiniEngineUnity.HAPI_AttributeOwnerowner  // 0x14
  public            HoudiniEngineUnity.HAPI_StorageTypestorage  // 0x18
  public            HoudiniEngineUnity.HAPI_AttributeOwneroriginalOwner  // 0x1c
  public            System.Int32                    count  // 0x20
  public            System.Int32                    tupleSize  // 0x24
  public            System.Int64                    totalArrayElements  // 0x28
  public            HoudiniEngineUnity.HAPI_AttributeTypeInfotypeInfo  // 0x30
METHODS:
  RVA=0x03D6D430  token=0x60004E1  System.Void .ctor(System.String ignored)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_MaterialInfo
TYPE:  sealed struct
TOKEN: 0x20000A2
SIZE:  0x18
FIELDS:
  public            System.Int32                    nodeId  // 0x10
  public            System.Boolean                  exists  // 0x14
  public            System.Boolean                  hasChanged  // 0x15
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImageFileFormat
TYPE:  sealed struct
TOKEN: 0x20000A3
SIZE:  0x1C
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            System.Int32                    descriptionSH  // 0x14
  public            System.Int32                    defaultExtensionSH  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImageInfo
TYPE:  sealed struct
TOKEN: 0x20000A4
SIZE:  0x30
FIELDS:
  public            System.Int32                    imageFileFormatNameSH  // 0x10
  public            System.Int32                    xRes  // 0x14
  public            System.Int32                    yRes  // 0x18
  public            HoudiniEngineUnity.HAPI_ImageDataFormatdataFormat  // 0x1c
  public            System.Boolean                  interleaved  // 0x20
  public            HoudiniEngineUnity.HAPI_ImagePackingpacking  // 0x24
  public            System.Double                   gamma  // 0x28
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Keyframe
TYPE:  sealed struct
TOKEN: 0x20000A5
SIZE:  0x20
FIELDS:
  public            System.Single                   time  // 0x10
  public            System.Single                   value  // 0x14
  public            System.Single                   inTangent  // 0x18
  public            System.Single                   outTangent  // 0x1c
METHODS:
  RVA=0x03D516B0  token=0x60004E2  System.Void .ctor(System.Single t, System.Single v, System.Single in_tangent, System.Single out_tangent)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeInfo
TYPE:  sealed struct
TOKEN: 0x20000A6
SIZE:  0x78
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            HoudiniEngineUnity.HAPI_VolumeTypetype  // 0x14
  public            System.Int32                    xLength  // 0x18
  public            System.Int32                    yLength  // 0x1c
  public            System.Int32                    zLength  // 0x20
  public            System.Int32                    minX  // 0x24
  public            System.Int32                    minY  // 0x28
  public            System.Int32                    minZ  // 0x2c
  public            System.Int32                    tupleSize  // 0x30
  public            HoudiniEngineUnity.HAPI_StorageTypestorage  // 0x34
  public            System.Int32                    tileSize  // 0x38
  public            HoudiniEngineUnity.HAPI_Transformtransform  // 0x40
  public            System.Boolean                  hasTaper  // 0x68
  public            System.Single                   xTaper  // 0x6c
  public            System.Single                   yTaper  // 0x70
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeTileInfo
TYPE:  sealed struct
TOKEN: 0x20000A7
SIZE:  0x20
FIELDS:
  public            System.Int32                    minX  // 0x10
  public            System.Int32                    minY  // 0x14
  public            System.Int32                    minZ  // 0x18
  public            System.Boolean                  isValid  // 0x1c
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeVisualInfo
TYPE:  sealed struct
TOKEN: 0x20000A8
SIZE:  0x1C
FIELDS:
  public            HoudiniEngineUnity.HAPI_VolumeVisualTypetype  // 0x10
  public            System.Single                   iso  // 0x14
  public            System.Single                   density  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CurveInfo
TYPE:  sealed struct
TOKEN: 0x20000A9
SIZE:  0x2C
FIELDS:
  public            HoudiniEngineUnity.HAPI_CurveTypecurveType  // 0x10
  public            System.Int32                    curveCount  // 0x14
  public            System.Int32                    vertexCount  // 0x18
  public            System.Int32                    knotCount  // 0x1c
  public            System.Boolean                  isPeriodic  // 0x20
  public            System.Boolean                  isRational  // 0x21
  public            System.Int32                    order  // 0x24
  public            System.Boolean                  hasKnots  // 0x28
  public            System.Boolean                  isClosed  // 0x29
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputCurveInfo
TYPE:  sealed struct
TOKEN: 0x20000AA
SIZE:  0x24
FIELDS:
  public            HoudiniEngineUnity.HAPI_CurveTypecurveType  // 0x10
  public            System.Int32                    order  // 0x14
  public            System.Boolean                  closed  // 0x18
  public            System.Boolean                  reverse  // 0x19
  public            HoudiniEngineUnity.HAPI_InputCurveMethodinputMethod  // 0x1c
  public            HoudiniEngineUnity.HAPI_InputCurveParameterizationbreakpointParameterization  // 0x20
METHODS:
  RVA=0x08804F58  token=0x60004E3  System.Void FillData(HoudiniEngineUnity.HEU_InputCurveInfo curveInfo)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_BoxInfo
TYPE:  sealed struct
TOKEN: 0x20000AB
SIZE:  0x28
FIELDS:
  public            System.Single[]                 center  // 0x10
  public            System.Single[]                 size  // 0x18
  public            System.Single[]                 rotation  // 0x20
METHODS:
  RVA=0x08804EBC  token=0x60004E4  System.Void .ctor(System.Boolean initialize_fields)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SphereInfo
TYPE:  sealed struct
TOKEN: 0x20000AC
SIZE:  0x20
FIELDS:
  public            System.Single[]                 center  // 0x10
  public            System.Single                   radius  // 0x18
METHODS:
  RVA=0x08805294  token=0x60004E5  System.Void .ctor(System.Boolean initialize_fields)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_EventInfo
TYPE:  sealed struct
TOKEN: 0x20000AD
SIZE:  0x2C
FIELDS:
  public            System.Int32                    nodeId  // 0x10
  public            System.Int32                    workItemId  // 0x14
  public            System.Int32                    dependencyId  // 0x18
  public            System.Int32                    currentState  // 0x1c
  public            System.Int32                    lastState  // 0x20
  public            System.Int32                    eventType  // 0x24
  public            System.Int32                    msgSH  // 0x28
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_WorkItemInfo
TYPE:  sealed struct
TOKEN: 0x20000AE
SIZE:  0x1C
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    outputFileCount  // 0x14
  public            System.Int32                    nameSH  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_WorkItemOutputFile
TYPE:  sealed struct
TOKEN: 0x20000AF
SIZE:  0x20
FIELDS:
  public            System.Int32                    filePathSH  // 0x10
  public            System.Int32                    tagSH  // 0x14
  public            System.Int64                    hash  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Viewport
TYPE:  sealed struct
TOKEN: 0x20000B0
SIZE:  0x28
FIELDS:
  public            System.Single[]                 position  // 0x10
  public            System.Single[]                 rotationQuaternion  // 0x18
  public            System.Single                   offset  // 0x20
METHODS:
  RVA=0x08805650  token=0x60004E6  System.Void .ctor(System.Boolean initializeFields)
  RVA=0x088055D8  token=0x60004E7  System.Void Init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SessionSyncInfo
TYPE:  sealed struct
TOKEN: 0x20000B1
SIZE:  0x12
FIELDS:
  public            System.Boolean                  cookUsingHoudiniTime  // 0x10
  public            System.Boolean                  syncViewport  // 0x11
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CompositorOptions
TYPE:  sealed struct
TOKEN: 0x20000B2
SIZE:  0x18
FIELDS:
  public            System.Int32                    maximumResolutionX  // 0x10
  public            System.Int32                    maximumResolutionY  // 0x14
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HARCImports
TYPE:  class
TOKEN: 0x20000B3
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60004E8  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniVersion
TYPE:  class
TOKEN: 0x20000B4
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    HOUDINI_MAJOR  // const
  public    static  System.Int32                    HOUDINI_MINOR  // const
  public    static  System.Int32                    HOUDINI_BUILD  // const
  public    static  System.Int32                    HOUDINI_PATCH  // const
  public    static  System.String                   HOUDINI_VERSION_STRING  // const
  public    static  System.Int32                    HOUDINI_ENGINE_MAJOR  // const
  public    static  System.Int32                    HOUDINI_ENGINE_MINOR  // const
  public    static  System.Int32                    HOUDINI_ENGINE_API  // const
  public    static  System.Int32                    UNITY_PLUGIN_VERSION  // const
  public    static  System.String                   HAPI_BIN_PATH  // const
  public    static  System.String                   HAPI_LIBRARY  // const
  public    static  System.String                   HARC_LIBRARY  // const
  public    static  System.String                   SIDEFX_SOFTWARE_REGISTRY  // const
METHODS:
  RVA=0x0350B670  token=0x60004E9  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_APIConstants
TYPE:  class
TOKEN: 0x20000B5
SIZE:  0x10
FIELDS:
  public    static  System.String                   HOUDINI_MASTER_SERVER_HOSTNAME  // const
  public    static  System.Int32                    HOUDINI_MASTER_QUERY_FOR_UNITY_PORT  // const
  public    static  System.Int32                    TCP_HEADER_SIZE  // const
  public    static  System.Int32                    MAX_ERROR_INFO_SIZE  // const
METHODS:
  RVA=0x0350B670  token=0x60004EA  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_VERSION
TYPE:  class
TOKEN: 0x20000B6
SIZE:  0x10
FIELDS:
  public    static  System.String                   LIBRARY  // const
METHODS:
  RVA=0x0350B670  token=0x60004EB  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HoudiniConstsIdentifier
TYPE:  class
TOKEN: 0x20000B7
SIZE:  0x10
FIELDS:
  public    static  System.String                   HOUDINI_VERSION  // const
  public    static  System.String                   PROJECT_TAG  // const
METHODS:
  RVA=0x0350B670  token=0x60004EC  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_APIFunctions
TYPE:  class
TOKEN: 0x20000B8
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0881E520  token=0x60004ED  System.Void InitHoudiniTcpClient(System.String address, System.Int32 port, System.Boolean use_ip, System.Text.StringBuilder error_msg)
  RVA=0x0881E410  token=0x60004EE  System.Void GetHarsInfo(HoudiniEngineUnity.HarsInfo& harsInfo, System.Text.StringBuilder error_msg)
  RVA=0x0881E600  token=0x60004EF  System.Void UninitializeHoudiniTcpClient(System.Text.StringBuilder error_msg)
  RVA=0x0350B670  token=0x60004F0  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HarsInfo
TYPE:  sealed struct
TOKEN: 0x20000B9
SIZE:  0x20
FIELDS:
  public            System.String                   hars_address  // 0x10
  public            System.Int32                    port  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.GenericMessage
TYPE:  sealed struct
TOKEN: 0x20000BA
SIZE:  0x20
FIELDS:
  public            System.String                   protocol  // 0x10
  public            System.Object                   body  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.Logger
TYPE:  static class
TOKEN: 0x20000BB
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088203F0  token=0x60004F1  System.Void LogError(System.String msg)
  RVA=0x08820488  token=0x60004F2  System.Void LogWarning(System.String msg)
  RVA=0x0882043C  token=0x60004F3  System.Void LogInfo(System.String msg)
END_CLASS

CLASS: HoudiniEngineUnity.HTC_SessionManager
TYPE:  class
TOKEN: 0x20000BC
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Boolean                  disposedValue  // 0x10
  private   static  HoudiniEngineUnity.HTC_SessionManagerinstance_  // static @ 0x0
PROPERTIES:
  Instance  get=0x0881F170
METHODS:
  RVA=0x0881E980  token=0x60004F4  System.Void .ctor()
  RVA=0x0881E84C  token=0x60004F5  System.Void Finalize()
  RVA=0x0881E758  token=0x60004F6  System.Void Dispose(System.Boolean disposing)
  RVA=0x0881E708  token=0x60004F7  System.Void Dispose()
  RVA=0x0881E8C0  token=0x60004F8  System.Boolean GetOrRequestAvailableHARSInfo(System.String& harsAddress, System.Int32& harsPort, System.String& errorInfo)
  RVA=0x0881E6A0  token=0x60004F9  System.Void Close()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_Utils
TYPE:  static class
TOKEN: 0x20000BD
SIZE:  0x10
FIELDS:
  private   static readonly System.String                   CurrentUnityProjectPrefix  // static @ 0x0
METHODS:
  RVA=0x0881F1F4  token=0x60004FB  System.String GetUnityPathFromSystemPath(System.String systemPath)
  RVA=0x0881F3FC  token=0x60004FC  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HoudiniExtTools
TYPE:  static class
TOKEN: 0x20000BE
SIZE:  0x10
FIELDS:
  private   static readonly System.String                   LOCAL_IP_ADDRESS  // static @ 0x0
  private   static readonly System.String                   REMOTE_HOUDINI_SMB_PATH_PREFIX  // static @ 0x8
  private   static readonly System.String                   REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX  // static @ 0x10
  public    static  System.String                   REMOTE_HOUDINI_HDA_SMB_URL  // const
  public    static  System.String                   REMOTE_HOUDINI_SMB_URL  // const
  public    static  System.String                   LINUX_MOUNT_DIR_PREFIX  // const
  public    static  System.String                   PROJECT_TAG  // const
PROPERTIES:
  DefaultSessionID  get=0x088203A0
METHODS:
  RVA=0x0881FFE0  token=0x60004FD  System.Int64 GetSessionID(System.Int64 sessionId)
  RVA=0x0881FAA8  token=0x60004FE  System.String GetDefaultDirectoryOnTheSMB()
  RVA=0x0881FB24  token=0x60004FF  System.String GetDefaultSessionDirectoryOnTheSMB(System.Int64 sessionId)
  RVA=0x0881F72C  token=0x6000500  System.String ConvertLocalDirPathToSessionDirPath(System.String localPath, System.Boolean doMd5, System.Int64 sessionId)
  RVA=0x0881F634  token=0x6000501  System.String ConvertLocalDebugFilePathToSessionDebugFilePath(System.String localFilePath, System.Int64 sessionId)
  RVA=0x0881F85C  token=0x6000502  System.String ConvertLocalFilePathToSessionFilePath(System.String localFilePath, System.Int64 sessionId)
  RVA=0x0882002C  token=0x6000503  System.Boolean IsLocalPath(System.String path)
  RVA=0x0881FEDC  token=0x6000504  System.String GetMD5WithString(System.String str)
  RVA=0x0881FBF0  token=0x6000505  System.String GetLocalIPv4()
  RVA=0x0881FBC4  token=0x6000506  System.String GetHoudiniSMBUrl()
  RVA=0x0881FA48  token=0x6000507  System.String GetDefaultCachePath(System.Int64 sessionId)
  RVA=0x0881FAF8  token=0x6000508  System.String GetDefaultHdaPath()
  RVA=0x088202A4  token=0x600050A  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HoudiniExtBridge
TYPE:  static class
TOKEN: 0x20000BF
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0881F4E8  token=0x600050B  System.Boolean GetParametersFromHDA(System.Byte[] hdaBytes, HoudiniEngineUnity.HEU_Parameters& parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode>& inputNodes)
  RVA=0x0881F4A8  token=0x600050C  System.Void AddInputNodeToHoudiniAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_InputNode node)
  RVA=0x0881F4C4  token=0x600050D  System.Void Clear(HoudiniEngineUnity.HEU_Parameters parameters)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterData
TYPE:  sealed class
TOKEN: 0x20000C0
SIZE:  0x150
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.Int32                    _unityIndex  // 0x10
  public            System.String                   _name  // 0x18
  public            System.String                   _labelName  // 0x20
  public            System.String                   _help  // 0x28
  public            System.Collections.Generic.List<System.Int32>_childParameterIDs  // 0x30
  public            System.Int32                    _choiceValue  // 0x38
  public            System.Int32[]                  _intValues  // 0x40
  public            System.Single[]                 _floatValues  // 0x48
  public            System.String[]                 _stringValues  // 0x50
  public            System.Boolean                  _toggle  // 0x58
  public            UnityEngine.Color               _color  // 0x5c
  public            UnityEngine.Gradient            _gradient  // 0x70
  public            UnityEngine.AnimationCurve      _animCurve  // 0x78
  public            UnityEngine.GUIContent[]        _choiceLabels  // 0x80
  public            System.String[]                 _choiceStringValues  // 0x88
  public            System.Int32[]                  _choiceIntValues  // 0x90
  public            HoudiniEngineUnity.HAPI_ParmInfo_parmInfo  // 0x98
  public            System.Boolean                  _showChildren  // 0x12c
  public            System.String                   _fileTypeInfo  // 0x130
  public            System.Int32                    _folderListChildrenProcessed  // 0x138
  public            System.Int32                    _tabSelectedIndex  // 0x13c
  public            HoudiniEngineUnity.HEU_InputNode_paramInputNode  // 0x140
  public            System.Boolean                  _hasAssetPathTag  // 0x148
PROPERTIES:
  ParmID  get=0x03D4EB50
  ParentID  get=0x03D51960
  ChildIndex  get=0x03D50E50
  ParmSize  get=0x03D57DA0
  IntMin  get=0x0880BAA4
  IntMax  get=0x0880BA94
  IntUIMin  get=0x0880BAC4
  IntUIMax  get=0x0880BAB4
  FloatMin  get=0x03D598B0
  FloatMax  get=0x03D583B0
  FloatUIMin  get=0x03D574D0
  FloatUIMax  get=0x03D58E00
METHODS:
  RVA=0x0880B948  token=0x6000512  System.Boolean IsInt()
  RVA=0x0880B930  token=0x6000513  System.Boolean IsFloat()
  RVA=0x0880B984  token=0x6000514  System.Boolean IsString()
  RVA=0x0880B954  token=0x6000515  System.Boolean IsPathFile()
  RVA=0x03D6D690  token=0x6000516  System.Boolean HasMin()
  RVA=0x03D6D680  token=0x6000517  System.Boolean HasMax()
  RVA=0x03D6D6B0  token=0x6000518  System.Boolean HasUIMin()
  RVA=0x03D6D6A0  token=0x6000519  System.Boolean HasUIMax()
  RVA=0x0880B1A8  token=0x6000522  System.Boolean IsContainer()
  RVA=0x0589F914  token=0x6000523  System.Boolean IsMultiParam()
  RVA=0x0880B96C  token=0x6000524  System.Boolean IsRamp()
  RVA=0x0880B924  token=0x6000525  System.Boolean IsFloatRamp()
  RVA=0x0880B190  token=0x6000526  System.Boolean IsColorRamp()
  RVA=0x0880B990  token=0x6000527  System.Boolean IsToggle()
  RVA=0x0880B19C  token=0x6000528  System.Boolean IsColor()
  RVA=0x0880B93C  token=0x6000529  System.Boolean IsFolder()
  RVA=0x0880B184  token=0x600052A  System.Boolean IsButton()
  RVA=0x0880B99C  token=0x600052B  UnityEngine.Vector3 ToVector3()
  RVA=0x03D57CB0  token=0x600052C  System.Boolean IsAssetPath()
  RVA=0x0880B1EC  token=0x600052D  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterData other)
  RVA=0x0880BA1C  token=0x600052E  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ModifierActionWrapper
TYPE:  sealed struct
TOKEN: 0x20000C1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperMULTIPARM_INSERT  // const
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperMULTIPARM_REMOVE  // const
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperMULTIPARM_CLEAR  // const
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperSET_FLOAT  // const
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperSET_INT  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterModifier
TYPE:  class
TOKEN: 0x20000C2
SIZE:  0x28
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.Int32                    _parameterIndex  // 0x10
  private           HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction_action  // 0x14
  private           System.Int32                    _instanceIndex  // 0x18
  private           System.Int32                    _modifierValue  // 0x1c
  private           System.Single                   _floatValue  // 0x20
  private           System.Int32                    _intValue  // 0x24
PROPERTIES:
  ParameterIndex  get=0x03D4E340  set=0x010410F0
  Action  get=0x0880BDAC  set=0x0880BDB8
  InstanceIndex  get=0x020D1AC0  set=0x03D4E9C0
  ModifierValue  get=0x03D4EBB0  set=0x03D4EBC0
  FloatValue  get=0x03D4F2E0  set=0x03D4F2F0
  IntValue  get=0x03D4E2E0  set=0x03D4E2F0
METHODS:
  RVA=0x0880BAD4  token=0x600053B  HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ModifierActionWrapper action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue)
  RVA=0x0880BB1C  token=0x600053C  HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue)
  RVA=0x0880BB90  token=0x600053D  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterModifier other)
  RVA=0x0880BD78  token=0x600053E  HoudiniEngineUnity.HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action)
  RVA=0x0880BD78  token=0x600053F  HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction ModifierAction_WrapperToInternal(HoudiniEngineUnity.HEU_ModifierActionWrapper action)
  RVA=0x0350B670  token=0x6000540  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Parameters
TYPE:  class
TOKEN: 0x20000C4
SIZE:  0x88
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_Parameters HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           System.Int32                    _nodeID  // 0x18
  private           System.String                   _uiLabel  // 0x20
  private           System.Int32[]                  _paramInts  // 0x28
  private           System.Single[]                 _paramFloats  // 0x30
  private           System.String[]                 _paramStrings  // 0x38
  private           HoudiniEngineUnity.HAPI_ParmChoiceInfo[]_paramChoices  // 0x40
  private           System.Collections.Generic.List<System.Int32>_rootParameters  // 0x48
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData>_parameterList  // 0x50
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier>_parameterModifiers  // 0x58
  private           System.Boolean                  _regenerateParameters  // 0x60
  private           System.Byte[]                   _presetData  // 0x68
  private           System.Byte[]                   _defaultPresetData  // 0x70
  private           System.Boolean                  _validParameters  // 0x78
  private           System.Boolean                  _showParameters  // 0x79
  private           System.Boolean                  _recacheUI  // 0x7a
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x80
PROPERTIES:
  ParentAsset  get=0x03D4EAE0
  ShowParameters  get=0x03D51AE0  set=0x03D51B40
  NodeID  get=0x020D1AC0  set=0x03D4E9C0
  RootParameters  get=0x03D4EA70
  ParameterModifiers  get=0x03D4EAA0
  RequiresRegeneration  get=0x03D519A0  set=0x03D519B0
  RecacheUI  get=0x03D51AF0  set=0x03D51B50
METHODS:
  RVA=0x03D4EAB0  token=0x600054A  System.Byte[] GetPresetData()
  RVA=0x038C5570  token=0x600054B  System.Void SetPresetData(System.Byte[] data)
  RVA=0x03D4EB30  token=0x600054C  System.Byte[] GetDefaultPresetData()
  RVA=0x03D4F800  token=0x600054F  System.Boolean AreParametersValid()
  RVA=0x0880E844  token=0x6000550  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x08813BCC  token=0x6000551  System.Void Recook()
  RVA=0x03D4EAF0  token=0x6000552  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters()
  RVA=0x0880E57C  token=0x6000553  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex)
  RVA=0x0880E5EC  token=0x6000554  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name)
  RVA=0x0880E45C  token=0x6000555  HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID)
  RVA=0x08813CBC  token=0x6000556  System.Void RemoveParameter(System.Int32 listIndex)
  RVA=0x0880ECC0  token=0x6000557  System.Boolean HaveParametersChanged()
  RVA=0x08813ED4  token=0x6000558  System.Boolean ResetAllToDefault(System.Boolean bRecookAsset)
  RVA=0x08814B68  token=0x6000559  System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=0x0880CFB8  token=0x600055A  System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex)
  RVA=0x08814D70  token=0x600055B  System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset)
  RVA=0x0880D1AC  token=0x600055C  System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values)
  RVA=0x088145AC  token=0x600055D  System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset)
  RVA=0x0880C974  token=0x600055E  System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value)
  RVA=0x08815464  token=0x600055F  System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=0x0880DB4C  token=0x6000560  System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex)
  RVA=0x0881566C  token=0x6000561  System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset)
  RVA=0x0880DD40  token=0x6000562  System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values)
  RVA=0x088143DC  token=0x6000563  System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset)
  RVA=0x0880C7CC  token=0x6000564  System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value)
  RVA=0x088142C0  token=0x6000565  System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=0x0880C6C0  token=0x6000566  System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex)
  RVA=0x08815F30  token=0x6000567  System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=0x0880E8DC  token=0x6000568  System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex)
  RVA=0x08816144  token=0x6000569  System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset)
  RVA=0x0880EAF8  token=0x600056A  System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values)
  RVA=0x08813F1C  token=0x600056B  System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=0x088140E4  token=0x600056C  System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset)
  RVA=0x0880C37C  token=0x600056D  System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex)
  RVA=0x0880C4F4  token=0x600056E  System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values)
  RVA=0x08815CBC  token=0x600056F  System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset)
  RVA=0x0880E72C  token=0x6000570  System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints)
  RVA=0x08814FCC  token=0x6000571  System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset)
  RVA=0x0880D344  token=0x6000572  System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  RVA=0x088152C4  token=0x6000573  System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  RVA=0x0880D638  token=0x6000574  System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints)
  RVA=0x088146D8  token=0x6000575  System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset)
  RVA=0x0880CA94  token=0x6000576  System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  RVA=0x088149BC  token=0x6000577  System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  RVA=0x0880CD80  token=0x6000578  System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints)
  RVA=0x088168D0  token=0x6000579  System.Boolean TriggerButtonParameter(System.String parameterName)
  RVA=0x088158D0  token=0x600057A  System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecook)
  RVA=0x0880E078  token=0x600057B  System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples)
  RVA=0x088112B0  token=0x600057C  System.Boolean Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> previousParamFolders, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> previousParamInputNodes, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  RVA=0x0880F16C  token=0x600057D  System.Boolean Initialize4HGTool(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Int32 parentNodeId)
  RVA=0x088163BC  token=0x600057E  System.Void SetupRampParameter(HoudiniEngineUnity.HEU_ParameterData rampParameter)
  RVA=0x08816CB0  token=0x600057F  System.Boolean UploadValuesToHoudini(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bDoCheck, System.Boolean bForceUploadInputs)
  RVA=0x08813428  token=0x6000580  System.Void InsertInstanceToMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToAdd)
  RVA=0x08813C34  token=0x6000581  System.Void RemoveInstancesFromMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToRemove)
  RVA=0x0880C274  token=0x6000582  System.Void ClearInstancesFromMultiParm(System.Int32 unityParamIndex)
  RVA=0x0880EC7C  token=0x6000583  System.Boolean HasModifiersPending()
  RVA=0x08813768  token=0x6000584  System.Void ProcessModifiers(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0880DEDC  token=0x6000585  System.Void GetParameterDataForUIRestore(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> folderParams, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> inputNodeParams)
  RVA=0x0880D86C  token=0x6000586  System.Void GetInputNodeConnectionObjects(System.Collections.Generic.List<UnityEngine.GameObject> inputNodeObjects)
  RVA=0x0880C330  token=0x6000587  System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08816C88  token=0x6000588  System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0880C2E4  token=0x6000589  System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08816A9C  token=0x600058A  System.Void UploadParameterInputs(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bForceUpdate)
  RVA=0x08816A0C  token=0x600058B  System.Void UpdateTransformParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_TransformEuler& HAPITransform)
  RVA=0x088168A0  token=0x600058C  System.Void SyncParameterFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.String parameterName)
  RVA=0x088167C8  token=0x600058D  System.Void SyncInternalParametersForUndoCompare(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0880BDD8  token=0x600058E  System.Void CleanUp()
  RVA=0x08813D28  token=0x600058F  System.Void ResetAllToDefault(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x088134B0  token=0x6000590  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Parameters other)
  RVA=0x08816DB4  token=0x6000591  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterUtility
TYPE:  static class
TOKEN: 0x20000C7
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0882BEFC  token=0x6000596  System.Boolean GetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean& outValue)
  RVA=0x0882C528  token=0x6000597  System.Boolean SetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean setValue)
  RVA=0x0882BAF0  token=0x6000598  System.Boolean GetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue)
  RVA=0x0882C3A0  token=0x6000599  System.Boolean SetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue)
  RVA=0x0882B89C  token=0x600059A  System.Boolean GetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single& outValue)
  RVA=0x0882B960  token=0x600059B  System.Boolean GetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[]& outValues)
  RVA=0x0882C14C  token=0x600059C  System.Boolean SetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single setValue)
  RVA=0x0882C210  token=0x600059D  System.Boolean SetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[] setValues)
  RVA=0x0882BE30  token=0x600059E  System.Boolean GetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String& outValue)
  RVA=0x0882C464  token=0x600059F  System.Boolean SetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String setValue)
  RVA=0x0882BFC0  token=0x60005A0  System.Boolean SetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue)
  RVA=0x0882B714  token=0x60005A1  System.Boolean GetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue)
  RVA=0x0882C2D0  token=0x60005A2  System.Boolean SetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.GameObject obj, System.Int32 index)
  RVA=0x0882BA24  token=0x60005A3  System.Boolean GetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 index, UnityEngine.GameObject& obj)
  RVA=0x0882B7D0  token=0x60005A4  System.Boolean GetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color& getValue)
  RVA=0x0882C080  token=0x60005A5  System.Boolean SetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color setValue)
  RVA=0x0882BD74  token=0x60005A6  System.Int32 GetParameterIndexFromName(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName)
  RVA=0x0882BD40  token=0x60005A7  System.Int32 GetParameterIndexFromNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName)
  RVA=0x0882B628  token=0x60005A8  System.Int32 FindTextureParamByNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.String useTextureParmName)
  RVA=0x0882BC94  token=0x60005A9  System.Boolean GetParameterFloatValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.Single defaultValue, System.Single& returnValue)
  RVA=0x0882BBB4  token=0x60005AA  System.Boolean GetParameterColor3Value(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, UnityEngine.Color defaultValue, UnityEngine.Color& outputColor)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGCookedDataEvent
TYPE:  class
TOKEN: 0x20000C8
SIZE:  0x30
EXTENDS: UnityEngine.Events.UnityEvent`1
FIELDS:
METHODS:
  RVA=0x0882AD88  token=0x60005AB  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGCookedEventData
TYPE:  class
TOKEN: 0x20000C9
SIZE:  0x20
FIELDS:
  public            System.Boolean                  CookSuccess  // 0x10
  public            HoudiniEngineUnity.HEU_TOPNodeDataTopNodeData  // 0x18
METHODS:
  RVA=0x02F73D00  token=0x60005AC  System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_TOPNodeData bTopNodeData)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGAssetLink
TYPE:  class
TOKEN: 0x20000CA
SIZE:  0xA8
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           HoudiniEngineUnity.HEU_PDGCookedDataEvent_cookedDataEvent  // 0x18
  private           System.String                   _assetPath  // 0x20
  private           UnityEngine.GameObject          _assetGO  // 0x28
  private           System.String                   _assetName  // 0x30
  private           System.Int32                    _assetID  // 0x38
  private           HoudiniEngineUnity.HEU_HoudiniAsset_heu  // 0x40
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData>_topNetworks  // 0x48
  private           System.String[]                 _topNetworkNames  // 0x50
  private           System.Int32                    _selectedTOPNetwork  // 0x58
  private           HoudiniEngineUnity.HEU_PDGAssetLink.LinkState_linkState  // 0x5c
  private           System.Boolean                  _autoCook  // 0x60
  private           System.Boolean                  _useHEngineData  // 0x61
  public            HoudiniEngineUnity.HEU_PDGAssetLink.UpdateUIDelegate_repaintUIDelegate  // 0x68
  public            HoudiniEngineUnity.HEU_WorkItemTally_workItemTally  // 0x70
  private           UnityEngine.GameObject          _loadRootGameObject  // 0x78
  private           System.String                   _outputCachePathRoot  // 0x80
  private           System.Boolean                  _bUseTOPNodeFilter  // 0x88
  private           System.Boolean                  _bUseTOPOutputFilter  // 0x89
  private           System.String                   _topNodeFilter  // 0x90
  private           System.String                   _topOutputFilter  // 0x98
  private           System.Int32                    _numLoadingResults  // 0xa0
  private           System.Int32                    _numTotalResults  // 0xa4
PROPERTIES:
  AutoCook  get=0x03D519A0  set=0x03D519B0
  UseHEngineData  get=0x03D51F90  set=0x03D5B410
  UseTOPNodeFilter  get=0x03D51D50  set=0x03D56D40
  UseTOPOutputFilter  get=0x03D51D10  set=0x03D5B370
  TopNodeFilter  get=0x03D4EA90  set=0x051DFCB4
  TopOutputFilter  get=0x011AC510  set=0x051417AC
  ParentAsset  get=0x03D4E2B0
  AssetPath  get=0x03D4EB40
  AssetGO  get=0x03D4EAC0
  AssetName  get=0x01003830
  AssetID  get=0x03D4EC30
  TopNetworks  get=0x03D4EA70
  TopNetworkNames  get=0x03D4EAF0
  SelectedTOPNetwork  get=0x03D4EF00
  PDGLinkState  get=0x0882AD5C
  LoadRootGameObject  get=0x03D4EB20
  OutputCachePathRoot  get=0x03D4EAE0
  CookedDataEvent  get=0x01041090
  AssetLinkStateInternal  get=0x03D4EEF0
METHODS:
  RVA=0x0882A6A4  token=0x60005C6  System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset)
  RVA=0x0882A500  token=0x60005C7  System.Void Reset()
  RVA=0x0882A1B0  token=0x60005C8  System.Void Refresh()
  RVA=0x0882868C  token=0x60005C9  System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=0x0882A508  token=0x60005CA  System.Void SelectTOPNetwork(System.Int32 newIndex)
  RVA=0x0882A55C  token=0x60005CB  System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex)
  RVA=0x088287D8  token=0x60005CC  HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork()
  RVA=0x088287E4  token=0x60005CD  HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode()
  RVA=0x08828908  token=0x60005CE  HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index)
  RVA=0x08828380  token=0x60005CF  System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x08828380  token=0x60005D0  System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x08828558  token=0x60005D1  System.Void DirtyAll()
  RVA=0x0882833C  token=0x60005D2  System.Void CookOutput()
  RVA=0x08827DBC  token=0x60005D3  System.Void PauseCook()
  RVA=0x08827DBC  token=0x60005D4  System.Void CancelCook()
  RVA=0x08828578  token=0x60005D5  HoudiniEngineUnity.HEU_SessionBase GetHAPISession()
  RVA=0x08828AF0  token=0x60005D6  HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID)
  RVA=0x08828A20  token=0x60005D7  System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x08828860  token=0x60005D8  HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetworkByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> topNetworks)
  RVA=0x08828978  token=0x60005D9  HoudiniEngineUnity.HEU_TOPNodeData GetTOPNodeByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData> topNodes)
  RVA=0x0350B670  token=0x60005DA  System.Void Awake()
  RVA=0x0350B670  token=0x60005DB  System.Void OnBeforeSerialize()
  RVA=0x0350B670  token=0x60005DC  System.Void OnAfterDeserialize()
  RVA=0x0350B670  token=0x60005DD  System.Void HandleInitialLoad()
  RVA=0x08829574  token=0x60005DE  System.Void OnDestroy()
  RVA=0x0882953C  token=0x60005DF  System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> generatedOutputs)
  RVA=0x08829514  token=0x60005E0  System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_CookedEventData cookedEventData)
  RVA=0x08829514  token=0x60005E1  System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData)
  RVA=0x08829D18  token=0x60005E2  System.Void PopulateFromHDA()
  RVA=0x08829E60  token=0x60005E3  System.Boolean PopulateTOPNetworks()
  RVA=0x0882A038  token=0x60005E4  System.Boolean PopulateTOPNodes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Int32[] topNodeIDs, System.Boolean useHEngineData)
  RVA=0x08827DCC  token=0x60005E5  System.Void ClearAllTOPData()
  RVA=0x08828098  token=0x60005E6  System.Void ClearTOPNetworkWorkItemResults(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=0x088281AC  token=0x60005E7  System.Void ClearTOPNodeWorkItemResults(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x088282A8  token=0x60005E8  System.Void ClearWorkItemResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID)
  RVA=0x088282CC  token=0x60005E9  System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result)
  RVA=0x0882A834  token=0x60005EA  System.Void UpdateTOPNodeResultsVisibility(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x08828C54  token=0x60005EB  HoudiniEngineUnity.HEU_TOPWorkResult GetWorkResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID)
  RVA=0x088283A8  token=0x60005EC  System.Void DestroyWorkItemResultData(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result)
  RVA=0x08828DA0  token=0x60005ED  System.Void LoadResults(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HAPI_PDG_WorkItemInfo workItemInfo, HoudiniEngineUnity.HAPI_PDG_WorkItemOutputFile[] resultInfos, System.Int32 workItemID, System.Action<HoudiniEngineUnity.HEU_TOPNodeData,HoudiniEngineUnity.HEU_SyncedEventData> OnSynced)
  RVA=0x088285EC  token=0x60005EE  UnityEngine.Transform GetLoadRootTransform()
  RVA=0x0882A43C  token=0x60005EF  System.Void RepaintUI()
  RVA=0x0882A8A8  token=0x60005F0  System.Void UpdateWorkItemTally()
  RVA=0x0882A454  token=0x60005F1  System.Void ResetTOPNetworkWorkItemTally(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=0x088295DC  token=0x60005F2  System.Void OnTOPNodeFilterChanged(System.String filter)
  RVA=0x08829958  token=0x60005F3  System.Void OnTOPOutputFilterChanged(System.String filter)
  RVA=0x08829CB8  token=0x60005F4  System.Void ParseHEngineData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 topNodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.TOPNodeTags& nodeTags)
  RVA=0x0882A5B4  token=0x60005F5  System.Void SetupTopNetworkNames(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=0x08829584  token=0x60005F6  System.Void OnSyncComplete(HoudiniEngineUnity.HEU_PDGCookedEventData Data)
  RVA=0x087DF02C  token=0x60005F7  HoudiniEngineUnity.HEU_LinkStateWrapper LinkState_InternalToWrapper(HoudiniEngineUnity.HEU_PDGAssetLink.LinkState linkState)
  RVA=0x087DF02C  token=0x60005F8  HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LinkState_WrapperToInternal(HoudiniEngineUnity.HEU_LinkStateWrapper linkState)
  RVA=0x0882AC4C  token=0x60005F9  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.TOPNodeTags
TYPE:  class
TOKEN: 0x20000CF
SIZE:  0x18
FIELDS:
  public            System.Boolean                  _show  // 0x10
  public            System.Boolean                  _autoload  // 0x11
  public            System.Boolean                  _showHEngineData  // 0x12
  public            System.Boolean                  _autoloadHEngineData  // 0x13
METHODS:
  RVA=0x0350B670  token=0x6000601  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TOPNetworkData
TYPE:  class
TOKEN: 0x20000D0
SIZE:  0x48
FIELDS:
  public            System.Int32                    _nodeID  // 0x10
  public            System.String                   _nodeName  // 0x18
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData>_topNodes  // 0x20
  public            System.String[]                 _topNodeNames  // 0x28
  public            System.Int32                    _selectedTOPIndex  // 0x30
  public            System.String                   _parentName  // 0x38
  public            HoudiniEngineUnity.TOPNodeTags  _tags  // 0x40
METHODS:
  RVA=0x0882EE44  token=0x6000602  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TOPNodeData
TYPE:  class
TOKEN: 0x20000D1
SIZE:  0x50
FIELDS:
  public            System.Int32                    _nodeID  // 0x10
  public            System.String                   _nodeName  // 0x18
  public            System.String                   _parentName  // 0x20
  public            UnityEngine.GameObject          _workResultParentGO  // 0x28
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPWorkResult>_workResults  // 0x30
  public            HoudiniEngineUnity.TOPNodeTags  _tags  // 0x38
  public            System.Boolean                  _showResults  // 0x40
  public            HoudiniEngineUnity.HEU_TOPNodeData.PDGState_pdgState  // 0x44
  public            HoudiniEngineUnity.HEU_WorkItemTally_workItemTally  // 0x48
METHODS:
  RVA=0x0882EF6C  token=0x6000603  System.Void Reset()
  RVA=0x0882EF4C  token=0x6000604  System.Boolean AreAllWorkItemsComplete()
  RVA=0x0882EF0C  token=0x6000605  System.Boolean AnyWorkItemsFailed()
  RVA=0x0882EF2C  token=0x6000606  System.Boolean AnyWorkItemsPending()
  RVA=0x0882EF98  token=0x6000607  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TOPWorkResult
TYPE:  class
TOKEN: 0x20000D3
SIZE:  0x20
FIELDS:
  public            System.Int32                    _workItemIndex  // 0x10
  public            System.Int32                    _workItemID  // 0x14
  public            System.Collections.Generic.List<UnityEngine.GameObject>_generatedGOs  // 0x18
METHODS:
  RVA=0x0882F068  token=0x6000608  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_WorkItemTally
TYPE:  class
TOKEN: 0x20000D4
SIZE:  0x28
FIELDS:
  public            System.Int32                    _totalWorkItems  // 0x10
  public            System.Int32                    _waitingWorkItems  // 0x14
  public            System.Int32                    _scheduledWorkItems  // 0x18
  public            System.Int32                    _cookingWorkItems  // 0x1c
  public            System.Int32                    _cookedWorkItems  // 0x20
  public            System.Int32                    _erroredWorkItems  // 0x24
METHODS:
  RVA=0x03D6D890  token=0x6000609  System.Void ZeroAll()
  RVA=0x0882F79C  token=0x600060A  System.Boolean AreAllWorkItemsComplete()
  RVA=0x0882F778  token=0x600060B  System.Boolean AnyWorkItemsFailed()
  RVA=0x0882F780  token=0x600060C  System.Boolean AnyWorkItemsPending()
  RVA=0x0882F7BC  token=0x600060D  System.String ProgressRatio()
  RVA=0x0350B670  token=0x600060E  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGSession
TYPE:  class
TOKEN: 0x20000D5
SIZE:  0x70
FIELDS:
  private   static  HoudiniEngineUnity.HEU_PDGSession_pdgSession  // static @ 0x0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_PDGAssetLink>_pdgAssets  // 0x10
  public            System.Int32                    _pdgMaxProcessEvents  // 0x18
  public            HoudiniEngineUnity.HAPI_PDG_EventInfo[]_pdgQueryEvents  // 0x20
  public            System.Int32[]                  _pdgContextIDs  // 0x28
  public            System.Boolean                  _errored  // 0x30
  public            System.String                   _errorMsg  // 0x38
  public            HoudiniEngineUnity.HAPI_PDG_State_pdgState  // 0x40
  private           System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData>_cookedDataEvent  // 0x48
  private           System.Boolean                  _pendingCallback  // 0x50
  private           System.Int32                    _numItemsCompleted  // 0x54
  private           System.Int32                    _totalNumItems  // 0x58
  private           System.Boolean                  _callbackSuccess  // 0x5c
  private           System.Text.StringBuilder       _pdgEventMessages  // 0x60
  private           System.String[]                 _eventMessageColorCode  // 0x68
PROPERTIES:
  CookedDataEvent  get=0x03D4EA70  set=0x02692290
METHODS:
  RVA=0x0882B0D0  token=0x600060F  HoudiniEngineUnity.HEU_PDGSession GetPDGSession()
  RVA=0x0882B4D8  token=0x6000610  System.Void .ctor()
  RVA=0x0350B670  token=0x6000611  System.Void AddAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset)
  RVA=0x0350B670  token=0x6000612  System.Void RemoveAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset)
  RVA=0x0350B670  token=0x6000613  System.Void Update()
  RVA=0x0882AE98  token=0x6000614  System.Void CleanUp()
  RVA=0x0350B670  token=0x6000615  System.Void UpdatePDGContext()
  RVA=0x0350B670  token=0x6000616  System.Void ReinitializePDGContext()
  RVA=0x0350B670  token=0x6000617  System.Void ProcessPDGEvent(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo)
  RVA=0x0882B428  token=0x6000618  System.Void OnWorkItemLoadResults(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_SyncedEventData OnSynced)
  RVA=0x0882ADE4  token=0x6000619  System.Void CheckCallback(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x0882B160  token=0x600061A  System.Boolean GetTOPAssetLinkAndNode(System.Int32 nodeID, HoudiniEngineUnity.HEU_PDGAssetLink& assetLink, HoudiniEngineUnity.HEU_TOPNodeData& topNode)
  RVA=0x0882B47C  token=0x600061B  System.Void SetTOPNodePDGState(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPNodeData.PDGState pdgState)
  RVA=0x0882B328  token=0x600061C  System.Void NotifyTOPNodePDGStateClear(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x0882B3A8  token=0x600061D  System.Void NotifyTOPNodeTotalWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  RVA=0x0882B280  token=0x600061E  System.Void NotifyTOPNodeCookedWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x0882B2F4  token=0x600061F  System.Void NotifyTOPNodeErrorWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x0882B3E8  token=0x6000620  System.Void NotifyTOPNodeWaitingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  RVA=0x0882B368  token=0x6000621  System.Void NotifyTOPNodeScheduledWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  RVA=0x0882B2B4  token=0x6000622  System.Void NotifyTOPNodeCookingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  RVA=0x03D6D710  token=0x6000623  System.Void ResetPDGEventInfo(HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo)
  RVA=0x0882B434  token=0x6000624  System.Void SetErrorState(System.String msg, System.Boolean bLogIt)
  RVA=0x0882AF60  token=0x6000625  System.Void ClearErrorState()
  RVA=0x0882AFEC  token=0x6000626  HoudiniEngineUnity.HEU_SessionBase GetHAPIPDGSession(System.Boolean bCreate)
  RVA=0x0350B670  token=0x6000627  System.Void CookTOPNetworkOutputNode(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> OnCook)
  RVA=0x0350B670  token=0x6000628  System.Void PauseCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=0x0350B670  token=0x6000629  System.Void CancelCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=0x0350B670  token=0x600062A  System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo eventInfo, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=0x0115F4C0  token=0x600062B  System.Boolean DirtyTOPNode(System.Int32 nodeID)
  RVA=0x0115F4C0  token=0x600062C  System.Boolean CookTOPNode(System.Int32 nodeID)
  RVA=0x0115F4C0  token=0x600062D  System.Boolean DirtyAll(System.Int32 nodeID)
  RVA=0x0882ADC4  token=0x600062E  System.Void AddEventMessage(System.String msg)
  RVA=0x0882AFC8  token=0x600062F  System.String GetEventMessages()
  RVA=0x0882AFA4  token=0x6000630  System.Void ClearEventMessages()
  RVA=0x0882B03C  token=0x6000631  System.Int32[] GetNonBypassedNetworkIds(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId)
  RVA=0x0882B264  token=0x6000632  System.Boolean IsPDGAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId)
  RVA=0x03D6D700  token=0x6000633  System.Void ResetCallbackVariables()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_Curve
TYPE:  interface
TOKEN: 0x20000D9
FIELDS:
PROPERTIES:
  TargetGameObject  get=-1  // abstract  set=-1  // abstract
  GeoID  get=-1  // abstract
  PartID  get=-1  // abstract
  CurveNodeData  get=-1  // abstract
  Parameters  get=-1  // abstract
  CurveName  get=-1  // abstract
  IsInputCurve  get=-1  // abstract
  IsPartCurve  get=-1  // abstract
  InputCurveInfo  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000646  System.Boolean IsEditable()
  RVA=-1  // abstract  token=0x6000647  System.Boolean IsGeoCurve()
  RVA=-1  // abstract  token=0x6000648  System.Void SetCurveName(System.String name)
  RVA=-1  // abstract  token=0x6000649  System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600064A  System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600064B  System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600064C  UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex)
  RVA=-1  // abstract  token=0x600064D  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms()
  RVA=-1  // abstract  token=0x600064E  System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints()
  RVA=-1  // abstract  token=0x600064F  System.Int32 GetNumPoints()
  RVA=-1  // abstract  token=0x6000650  System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000651  System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000652  System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000653  System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000654  System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000655  System.Void ClearCurveNodeData(System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000656  System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000657  System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000658  UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex)
  RVA=-1  // abstract  token=0x6000659  System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints()
  RVA=-1  // abstract  token=0x600065A  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_GeoNode
TYPE:  interface
TOKEN: 0x20000DA
FIELDS:
PROPERTIES:
  GeoID  get=-1  // abstract
  GeoInfo  get=-1  // abstract
  GeoName  get=-1  // abstract
  GeoType  get=-1  // abstract
  Editable  get=-1  // abstract
  Displayable  get=-1  // abstract
  Parts  get=-1  // abstract
  ObjectNode  get=-1  // abstract
  InputNode  get=-1  // abstract
  GeoCurve  get=-1  // abstract
  VolumeCaches  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000666  System.Boolean IsVisible()
  RVA=-1  // abstract  token=0x6000667  System.Boolean IsIntermediate()
  RVA=-1  // abstract  token=0x6000668  System.Boolean IsIntermediateOrEditable()
  RVA=-1  // abstract  token=0x6000669  System.Boolean IsGeoInputType()
  RVA=-1  // abstract  token=0x600066A  System.Boolean IsGeoCurveType()
  RVA=-1  // abstract  token=0x600066B  System.Void DestroyAllData(System.Boolean bIsRebuild)
  RVA=-1  // abstract  token=0x600066C  System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part)
  RVA=-1  // abstract  token=0x600066D  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=-1  // abstract  token=0x600066E  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=-1  // abstract  token=0x600066F  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=-1  // abstract  token=0x6000670  HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID)
  RVA=-1  // abstract  token=0x6000671  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  RVA=-1  // abstract  token=0x6000672  System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts()
  RVA=-1  // abstract  token=0x6000673  System.Void HideAllGeometry()
  RVA=-1  // abstract  token=0x6000674  System.Void DisableAllColliders()
  RVA=-1  // abstract  token=0x6000675  HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetCookStatusWrapper
TYPE:  sealed struct
TOKEN: 0x20000DB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperNONE  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperCOOKING  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperPOSTCOOK  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperLOADING  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperPOSTLOAD  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperPRELOAD  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperSELECT_SUBASSET  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetCookResultWrapper
TYPE:  sealed struct
TOKEN: 0x20000DC
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetCookResultWrapperNONE  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookResultWrapperSUCCESS  // const
  public    static  HoudiniEngineUnity.HEU_AssetCookResultWrapperERRORED  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper
TYPE:  sealed struct
TOKEN: 0x20000DD
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapperINVALID  // const
  public    static  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapperCOLLIDERS  // const
  public    static  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapperLAYERMASK  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetTypeWrapper
TYPE:  sealed struct
TOKEN: 0x20000DE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_INVALID  // const
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_HDA  // const
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_CURVE  // const
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_INPUT  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_HoudiniAsset
TYPE:  interface
TOKEN: 0x20000DF
FIELDS:
PROPERTIES:
  LoadAssetFromMemory  get=-1  // abstract  set=-1  // abstract
  AlwaysOverwriteOnLoad  get=-1  // abstract  set=-1  // abstract
  GenerateUVs  get=-1  // abstract  set=-1  // abstract
  GenerateTangents  get=-1  // abstract  set=-1  // abstract
  GenerateNormals  get=-1  // abstract  set=-1  // abstract
  PushTransformToHoudini  get=-1  // abstract  set=-1  // abstract
  TransformChangeTriggersCooks  get=-1  // abstract  set=-1  // abstract
  CookingTriggersDownCooks  get=-1  // abstract  set=-1  // abstract
  AutoCookOnParameterChange  get=-1  // abstract  set=-1  // abstract
  IgnoreNonDisplayNodes  get=-1  // abstract  set=-1  // abstract
  UseOutputNodes  get=-1  // abstract  set=-1  // abstract
  GenerateMeshUsingPoints  get=-1  // abstract  set=-1  // abstract
  UseLODGroups  get=-1  // abstract  set=-1  // abstract
  SplitGeosByGroup  get=-1  // abstract  set=-1  // abstract
  SessionSyncAutoCook  get=-1  // abstract  set=-1  // abstract
  BakeUpdateKeepPreviousTransformValues  get=-1  // abstract  set=-1  // abstract
  PauseCooking  get=-1  // abstract  set=-1  // abstract
  CurveEditorEnabled  get=-1  // abstract  set=-1  // abstract
  CurveDrawCollision  get=-1  // abstract  set=-1  // abstract
  CurveDrawLayerMask  get=-1  // abstract  set=-1  // abstract
  CurveProjectMaxDistance  get=-1  // abstract  set=-1  // abstract
  CurveProjectDirection  get=-1  // abstract  set=-1  // abstract
  CurveProjectDirectionToView  get=-1  // abstract  set=-1  // abstract
  CurveDisableScaleRotation  get=-1  // abstract  set=-1  // abstract
  CurveFrameSelectedNodes  get=-1  // abstract  set=-1  // abstract
  CurveFrameSelectedNodeDistance  get=-1  // abstract  set=-1  // abstract
  HandlesEnabled  get=-1  // abstract  set=-1  // abstract
  EditableNodesToolsEnabled  get=-1  // abstract  set=-1  // abstract
  AssetType  get=-1  // abstract
  AssetInfo  get=-1  // abstract
  NodeInfo  get=-1  // abstract
  AssetName  get=-1  // abstract
  AssetOpName  get=-1  // abstract
  AssetHelp  get=-1  // abstract
  AssetID  get=-1  // abstract
  AssetPath  get=-1  // abstract
  OwnerGameObject  get=-1  // abstract
  RootGameObject  get=-1  // abstract
  MaterialCache  get=-1  // abstract
  Parameters  get=-1  // abstract
  AssetCacheFolder  get=-1  // abstract
  SubassetNames  get=-1  // abstract
  SelectedSubassetIndex  get=-1  // abstract
  CookStatus  get=-1  // abstract
  LastCookResult  get=-1  // abstract
  SessionID  get=-1  // abstract
  Curves  get=-1  // abstract
  InputNodes  get=-1  // abstract
  VolumeCaches  get=-1  // abstract
  ReloadDataEvent  get=-1  // abstract
  CookedDataEvent  get=-1  // abstract
  BakedDataEvent  get=-1  // abstract
  PreAssetEvent  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60006C7  System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters)
  RVA=-1  // abstract  token=0x60006C8  System.Boolean RequestReload(System.Boolean bAsync)
  RVA=-1  // abstract  token=0x60006C9  System.Boolean RequestResetParameters(System.Boolean bAsync)
  RVA=-1  // abstract  token=0x60006CA  UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject)
  RVA=-1  // abstract  token=0x60006CB  System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild)
  RVA=-1  // abstract  token=0x60006CC  UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath)
  RVA=-1  // abstract  token=0x60006CD  UnityEngine.GameObject BakeToNewStandalone()
  RVA=-1  // abstract  token=0x60006CE  System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO)
  RVA=-1  // abstract  token=0x60006CF  System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO)
  RVA=-1  // abstract  token=0x60006D0  System.Boolean IsAssetValid()
  RVA=-1  // abstract  token=0x60006D1  System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=-1  // abstract  token=0x60006D2  System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=-1  // abstract  token=0x60006D3  HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName)
  RVA=-1  // abstract  token=0x60006D4  System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider)
  RVA=-1  // abstract  token=0x60006D5  System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider)
  RVA=-1  // abstract  token=0x60006D6  System.Boolean ClearCurveDrawColliders()
  RVA=-1  // abstract  token=0x60006D7  HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName)
  RVA=-1  // abstract  token=0x60006D8  HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName)
  RVA=-1  // abstract  token=0x60006D9  HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index)
  RVA=-1  // abstract  token=0x60006DA  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes()
  RVA=-1  // abstract  token=0x60006DB  System.Int32 GetVolumeCacheCount()
  RVA=-1  // abstract  token=0x60006DC  HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid)
  RVA=-1  // abstract  token=0x60006DD  HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName)
  RVA=-1  // abstract  token=0x60006DE  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes)
  RVA=-1  // abstract  token=0x60006DF  HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=-1  // abstract  token=0x60006E0  System.Void ResetParametersToDefault()
  RVA=-1  // abstract  token=0x60006E1  System.Void HideAllGeometry()
  RVA=-1  // abstract  token=0x60006E2  System.Void DisableAllColliders()
  RVA=-1  // abstract  token=0x60006E3  HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material)
  RVA=-1  // abstract  token=0x60006E4  System.Void ClearMaterialCache()
  RVA=-1  // abstract  token=0x60006E5  System.Void RemoveMaterial(UnityEngine.Material material)
  RVA=-1  // abstract  token=0x60006E6  System.Void ResetMaterialOverrides()
  RVA=-1  // abstract  token=0x60006E7  HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset()
  RVA=-1  // abstract  token=0x60006E8  HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent
TYPE:  interface
TOKEN: 0x20000E0
FIELDS:
PROPERTIES:
  ParentAsset  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60006EA  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=-1  // abstract  token=0x60006EB  System.Void Recook()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputNodeTypeWrapper
TYPE:  sealed struct
TOKEN: 0x20000E1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNodeTypeWrapperCONNECTION  // const
  public    static  HoudiniEngineUnity.HEU_InputNodeTypeWrapperNODE  // const
  public    static  HoudiniEngineUnity.HEU_InputNodeTypeWrapperPARAMETER  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputObjectTypeWrapper
TYPE:  sealed struct
TOKEN: 0x20000E2
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperHDA  // const
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperUNITY_MESH  // const
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperCURVE  // const
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperTERRAIN  // const
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperBOUNDING_BOX  // const
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperTILEMAP  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_InputNode
TYPE:  interface
TOKEN: 0x20000E3
FIELDS:
PROPERTIES:
  KeepWorldTransform  get=-1  // abstract  set=-1  // abstract
  PackGeometryBeforeMerging  get=-1  // abstract  set=-1  // abstract
  NodeType  get=-1  // abstract
  ObjectType  get=-1  // abstract
  PendingObjectType  get=-1  // abstract
  InputNodeID  get=-1  // abstract
  InputName  get=-1  // abstract
  LabelName  get=-1  // abstract
  ParamName  get=-1  // abstract
  MeshSettings  get=-1  // abstract
  TilemapSettings  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60006F9  System.Boolean IsAssetInput()
  RVA=-1  // abstract  token=0x60006FA  System.Int32 NumInputEntries()
  RVA=-1  // abstract  token=0x60006FB  UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index)
  RVA=-1  // abstract  token=0x60006FC  UnityEngine.GameObject[] GetInputEntryGameObjects()
  RVA=-1  // abstract  token=0x60006FD  System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x60006FE  System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x60006FF  System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000700  System.Void ResetInputNode(System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000701  System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000702  System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000703  System.Void RemoveAllInputEntries(System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000704  System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000705  System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000706  System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000707  System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000708  System.Boolean AreAnyInputHDAsConnected()
  RVA=-1  // abstract  token=0x6000709  System.Int32 GetConnectedInputCount()
  RVA=-1  // abstract  token=0x600070A  System.Int32 GetConnectedNodeID(System.Int32 index)
  RVA=-1  // abstract  token=0x600070B  System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
  RVA=-1  // abstract  token=0x600070C  System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MaterialSourceWrapper
TYPE:  sealed struct
TOKEN: 0x20000E4
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperDEFAULT  // const
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperHOUDINI  // const
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperUNITY  // const
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperSUBSTANCE  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_MaterialData
TYPE:  interface
TOKEN: 0x20000E5
FIELDS:
PROPERTIES:
  Material  get=-1  // abstract
  MaterialSource  get=-1  // abstract
  MaterialKey  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000711  System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath)
  RVA=-1  // abstract  token=0x6000712  System.Boolean IsExistingMaterial()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_ObjectNode
TYPE:  interface
TOKEN: 0x20000E6
FIELDS:
PROPERTIES:
  ObjectID  get=-1  // abstract
  ObjectName  get=-1  // abstract
  ObjectInfo  get=-1  // abstract
  GeoNodes  get=-1  // abstract
  ObjectTransform  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000718  System.Boolean IsInstanced()
  RVA=-1  // abstract  token=0x6000719  System.Boolean IsVisible()
  RVA=-1  // abstract  token=0x600071A  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  RVA=-1  // abstract  token=0x600071B  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=-1  // abstract  token=0x600071C  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=-1  // abstract  token=0x600071D  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  RVA=-1  // abstract  token=0x600071E  HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName)
  RVA=-1  // abstract  token=0x600071F  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  RVA=-1  // abstract  token=0x6000720  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes)
  RVA=-1  // abstract  token=0x6000721  System.Void HideAllGeometry()
  RVA=-1  // abstract  token=0x6000722  System.Void DisableAllColliders()
  RVA=-1  // abstract  token=0x6000723  System.Boolean IsInstancer()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper
TYPE:  sealed struct
TOKEN: 0x20000E7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapperCONSTANT  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapperLINEAR  // const
  public    static  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapperCATMULL_ROM  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_RampPointWrapper
TYPE:  class
TOKEN: 0x20000E8
SIZE:  0x18
FIELDS:
  private           System.Single                   <Position>k__BackingField  // 0x10
  private           HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper<Interpolation>k__BackingField  // 0x14
PROPERTIES:
  Position  get=0x03D4E7A0  set=0x03D50CA0
  Interpolation  get=0x03D50CC0  set=0x03D595B0
METHODS:
  RVA=0x03D6D730  token=0x6000728  System.Void .ctor(System.Single position, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_FloatRampPointWrapper
TYPE:  class
TOKEN: 0x20000E9
SIZE:  0x20
EXTENDS: HoudiniEngineUnity.HEU_RampPointWrapper
FIELDS:
  private           System.Single                   <Value>k__BackingField  // 0x18
PROPERTIES:
  Value  get=0x03D4EBF0  set=0x03D4EC00
METHODS:
  RVA=0x03D6D6F0  token=0x600072B  System.Void .ctor(System.Single position, System.Single value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ColorRampPointWrapper
TYPE:  class
TOKEN: 0x20000EA
SIZE:  0x28
EXTENDS: HoudiniEngineUnity.HEU_RampPointWrapper
FIELDS:
  private           UnityEngine.Color               <Value>k__BackingField  // 0x18
PROPERTIES:
  Value  get=0x03D51D80  set=0x03D51D90
METHODS:
  RVA=0x03D6D6D0  token=0x600072E  System.Void .ctor(System.Single position, UnityEngine.Color value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterTupleWrapper
TYPE:  class
TOKEN: 0x20000EB
SIZE:  0x40
FIELDS:
  private           System.Boolean[]                _boolValues  // 0x10
  private           System.Int32[]                  _intValues  // 0x18
  private           System.Single[]                 _floatValues  // 0x20
  private           System.String[]                 _stringValues  // 0x28
  private           HoudiniEngineUnity.HEU_FloatRampPointWrapper[]_floatRampValues  // 0x30
  private           HoudiniEngineUnity.HEU_ColorRampPointWrapper[]_colorRampValues  // 0x38
PROPERTIES:
  BoolValues  get=0x020B7B20  set=0x0426FEE0
  IntValues  get=0x01041090  set=0x022C3A90
  FloatValues  get=0x03D4EB40  set=0x04271930
  StringValues  get=0x03D4EAC0  set=0x02C92F10
  FloatRampValues  get=0x01003830  set=0x04270470
  ColorRampValues  get=0x03D4E2A0  set=0x0388FF30
METHODS:
  RVA=0x0350B670  token=0x600073B  System.Void .ctor()
  RVA=0x0426FEE0  token=0x600073C  System.Void .ctor(System.Boolean[] boolValues)
  RVA=0x022C3A90  token=0x600073D  System.Void .ctor(System.Int32[] intValues)
  RVA=0x04271930  token=0x600073E  System.Void .ctor(System.Single[] floatValues)
  RVA=0x02C92F10  token=0x600073F  System.Void .ctor(System.String[] stringValues)
  RVA=0x04270470  token=0x6000740  System.Void .ctor(HoudiniEngineUnity.HEU_FloatRampPointWrapper[] floatRampValues)
  RVA=0x0388FF30  token=0x6000741  System.Void .ctor(HoudiniEngineUnity.HEU_ColorRampPointWrapper[] colorRampValues)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_Parameters
TYPE:  interface
TOKEN: 0x20000EC
FIELDS:
PROPERTIES:
  ShowParameters  get=-1  // abstract  set=-1  // abstract
  NodeID  get=-1  // abstract
  RootParameters  get=-1  // abstract
  ParameterModifiers  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000747  System.Boolean AreParametersValid()
  RVA=-1  // abstract  token=0x6000748  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters()
  RVA=-1  // abstract  token=0x6000749  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex)
  RVA=-1  // abstract  token=0x600074A  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name)
  RVA=-1  // abstract  token=0x600074B  HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID)
  RVA=-1  // abstract  token=0x600074C  System.Void RemoveParameter(System.Int32 listIndex)
  RVA=-1  // abstract  token=0x600074D  System.Boolean HaveParametersChanged()
  RVA=-1  // abstract  token=0x600074E  System.Boolean ResetAllToDefault(System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600074F  System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000750  System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex)
  RVA=-1  // abstract  token=0x6000751  System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000752  System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values)
  RVA=-1  // abstract  token=0x6000753  System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000754  System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value)
  RVA=-1  // abstract  token=0x6000755  System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000756  System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex)
  RVA=-1  // abstract  token=0x6000757  System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000758  System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values)
  RVA=-1  // abstract  token=0x6000759  System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600075A  System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value)
  RVA=-1  // abstract  token=0x600075B  System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600075C  System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex)
  RVA=-1  // abstract  token=0x600075D  System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600075E  System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex)
  RVA=-1  // abstract  token=0x600075F  System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000760  System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values)
  RVA=-1  // abstract  token=0x6000761  System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000762  System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex)
  RVA=-1  // abstract  token=0x6000763  System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000764  System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values)
  RVA=-1  // abstract  token=0x6000765  System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000766  System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints)
  RVA=-1  // abstract  token=0x6000767  System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000768  System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  RVA=-1  // abstract  token=0x6000769  System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600076A  System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints)
  RVA=-1  // abstract  token=0x600076B  System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600076C  System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  RVA=-1  // abstract  token=0x600076D  System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x600076E  System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints)
  RVA=-1  // abstract  token=0x600076F  System.Boolean TriggerButtonParameter(System.String parameterName)
  RVA=-1  // abstract  token=0x6000770  System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecookAsset)
  RVA=-1  // abstract  token=0x6000771  System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_PartData
TYPE:  interface
TOKEN: 0x20000ED
FIELDS:
PROPERTIES:
  PartID  get=-1  // abstract
  PartName  get=-1  // abstract
  GeoID  get=-1  // abstract
  PartType  get=-1  // abstract
  ParentGeoNode  get=-1  // abstract
  ObjectInstanceInfos  get=-1  // abstract
  Curve  get=-1  // abstract
  MeshVertexCount  get=-1  // abstract
  GeneratedOutput  get=-1  // abstract
  OutputGameObject  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600077C  System.Boolean IsPartInstancer()
  RVA=-1  // abstract  token=0x600077D  System.Boolean IsAttribInstancer()
  RVA=-1  // abstract  token=0x600077E  System.Boolean IsInstancerAnyType()
  RVA=-1  // abstract  token=0x600077F  System.Boolean IsPartInstanced()
  RVA=-1  // abstract  token=0x6000780  System.Int32 GetPartPointCount()
  RVA=-1  // abstract  token=0x6000781  System.Boolean IsObjectInstancer()
  RVA=-1  // abstract  token=0x6000782  System.Boolean IsPartVolume()
  RVA=-1  // abstract  token=0x6000783  System.Boolean IsPartCurve()
  RVA=-1  // abstract  token=0x6000784  System.Boolean IsPartMesh()
  RVA=-1  // abstract  token=0x6000785  System.Boolean IsPartEditable()
  RVA=-1  // abstract  token=0x6000786  System.Boolean HaveInstancesBeenGenerated()
  RVA=-1  // abstract  token=0x6000787  System.Void SetGameObjectName(System.String partName)
  RVA=-1  // abstract  token=0x6000788  System.Void SetGameObject(UnityEngine.GameObject gameObject)
  RVA=-1  // abstract  token=0x6000789  System.Void SetVolumeLayerName(System.String name)
  RVA=-1  // abstract  token=0x600078A  System.String GetVolumeLayerName()
  RVA=-1  // abstract  token=0x600078B  System.Void DestroyAllData(System.Boolean bIsRebuild)
  RVA=-1  // abstract  token=0x600078C  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  RVA=-1  // abstract  token=0x600078D  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  RVA=-1  // abstract  token=0x600078E  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  RVA=-1  // abstract  token=0x600078F  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject)
  RVA=-1  // abstract  token=0x6000790  System.Void ClearInstances()
  RVA=-1  // abstract  token=0x6000791  HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly)
  RVA=-1  // abstract  token=0x6000792  System.Void SetVisiblity(System.Boolean bVisibility)
  RVA=-1  // abstract  token=0x6000793  System.Void SetColliderState(System.Boolean bEnabled)
  RVA=-1  // abstract  token=0x6000794  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path)
  RVA=-1  // abstract  token=0x6000795  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID)
  RVA=-1  // abstract  token=0x6000796  System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition)
  RVA=-1  // abstract  token=0x6000797  System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LinkStateWrapper
TYPE:  sealed struct
TOKEN: 0x20000EE
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperINACTIVE  // const
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperLINKING  // const
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperLINKED  // const
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperERROR_NOT_LINKED  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_PDGAssetLink
TYPE:  interface
TOKEN: 0x20000EF
FIELDS:
PROPERTIES:
  AutoCook  get=-1  // abstract  set=-1  // abstract
  UseHEngineData  get=-1  // abstract  set=-1  // abstract
  UseTOPNodeFilter  get=-1  // abstract  set=-1  // abstract
  UseTOPOutputFilter  get=-1  // abstract  set=-1  // abstract
  TopNodeFilter  get=-1  // abstract  set=-1  // abstract
  TopOutputFilter  get=-1  // abstract  set=-1  // abstract
  ParentAsset  get=-1  // abstract
  AssetPath  get=-1  // abstract
  AssetGO  get=-1  // abstract
  AssetName  get=-1  // abstract
  AssetID  get=-1  // abstract
  TopNetworks  get=-1  // abstract
  TopNetworkNames  get=-1  // abstract
  SelectedTOPNetwork  get=-1  // abstract
  PDGLinkState  get=-1  // abstract
  LoadRootGameObject  get=-1  // abstract
  OutputCachePathRoot  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60007AF  System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset)
  RVA=-1  // abstract  token=0x60007B0  System.Void Reset()
  RVA=-1  // abstract  token=0x60007B1  System.Void Refresh()
  RVA=-1  // abstract  token=0x60007B2  System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  RVA=-1  // abstract  token=0x60007B3  System.Void SelectTOPNetwork(System.Int32 newIndex)
  RVA=-1  // abstract  token=0x60007B4  System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex)
  RVA=-1  // abstract  token=0x60007B5  HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork()
  RVA=-1  // abstract  token=0x60007B6  HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode()
  RVA=-1  // abstract  token=0x60007B7  HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index)
  RVA=-1  // abstract  token=0x60007B8  System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=-1  // abstract  token=0x60007B9  System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  RVA=-1  // abstract  token=0x60007BA  System.Void DirtyAll()
  RVA=-1  // abstract  token=0x60007BB  System.Void CookOutput()
  RVA=-1  // abstract  token=0x60007BC  System.Void PauseCook()
  RVA=-1  // abstract  token=0x60007BD  System.Void CancelCook()
  RVA=-1  // abstract  token=0x60007BE  HoudiniEngineUnity.HEU_SessionBase GetHAPISession()
  RVA=-1  // abstract  token=0x60007BF  HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID)
  RVA=-1  // abstract  token=0x60007C0  System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_VolumeCache
TYPE:  interface
TOKEN: 0x20000F0
FIELDS:
PROPERTIES:
  Layers  get=-1  // abstract
  TileIndex  get=-1  // abstract
  ObjectName  get=-1  // abstract
  GeoName  get=-1  // abstract
  TerrainData  get=-1  // abstract
  ScatterTrees  get=-1  // abstract
  DetailProperties  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60007C8  System.Void ResetParameters()
  RVA=-1  // abstract  token=0x60007C9  HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName)
  RVA=-1  // abstract  token=0x60007CA  System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset)
  RVA=-1  // abstract  token=0x60007CB  System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MaterialData
TYPE:  class
TOKEN: 0x20000F1
SIZE:  0x28
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_MaterialData HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           UnityEngine.Material            _material  // 0x18
  private           HoudiniEngineUnity.HEU_MaterialData.Source_materialSource  // 0x20
  private           System.Int32                    _materialKey  // 0x24
PROPERTIES:
  Material  get=0x01041090
  MaterialSource  get=0x088261D8
  MaterialKey  get=0x03D4E2E0  set=0x03D4E2F0
METHODS:
  RVA=0x088257E0  token=0x60007D0  System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath)
  RVA=0x08825788  token=0x60007D1  System.Boolean IsExistingMaterial()
  RVA=0x08825AE8  token=0x60007D2  System.Boolean UseLegacyShaders(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath, HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_NodeInfo nodeInfo, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos)
  RVA=0x088254E8  token=0x60007D3  System.String GetTextureFileNameFromMaterialParam(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo parmInfo)
  RVA=0x0882579C  token=0x60007D4  System.Boolean IsTransparentMaterial(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters)
  RVA=0x08825274  token=0x60007D5  System.Boolean GetMaterialAlpha(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.Single defaultValue, System.Single& alpha)
  RVA=0x088253E8  token=0x60007D6  System.String GetSupportedFileFormat(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo)
  RVA=0x088255EC  token=0x60007D7  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_MaterialData other)
  RVA=0x087DF02C  token=0x60007D8  HoudiniEngineUnity.HEU_MaterialData.Source MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialSourceWrapper materialSource)
  RVA=0x087DF02C  token=0x60007D9  HoudiniEngineUnity.HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialData.Source materialSource)
  RVA=0x088261C8  token=0x60007DA  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MaterialFactory
TYPE:  class
TOKEN: 0x20000F3
SIZE:  0x10
FIELDS:
  public    static  UnityEngine.Material            _defaultStandardMaterial  // static @ 0x0
METHODS:
  RVA=0x08826A14  token=0x60007DB  UnityEngine.Shader FindShader(System.String shaderName)
  RVA=0x088269DC  token=0x60007DC  UnityEngine.Shader FindPluginShader(System.String shaderName)
  RVA=0x08826E80  token=0x60007DD  UnityEngine.Material GetNewMaterialWithShader(System.String assetCacheFolderPath, System.String shaderName, System.String materialName, System.Boolean bWriteToFile)
  RVA=0x08826514  token=0x60007DE  UnityEngine.Material CreateNewHoudiniStandardMaterial(System.String assetCacheFolderPath, System.String materialName, System.Boolean bWriteToFile)
  RVA=0x08827A48  token=0x60007DF  System.Void WriteMaterialToAssetCache(UnityEngine.Material material, System.String assetCacheFolderPath, System.String materialName, System.Boolean bOverwriteExisting)
  RVA=0x08826874  token=0x60007E0  System.Boolean DoesMaterialExistInAssetCache(UnityEngine.Material material)
  RVA=0x08826800  token=0x60007E1  System.Void DestroyNonAssetMaterial(UnityEngine.Material material, System.Boolean bRegisterUndo)
  RVA=0x088267F8  token=0x60007E2  System.Void DeleteAssetMaterial(UnityEngine.Material material)
  RVA=0x08827980  token=0x60007E3  UnityEngine.Texture2D RenderAndExtractImageToTexture(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.Int32 textureParmID, System.String textureName, System.String assetCacheFolderPath, System.Boolean isNormalMap, System.Boolean invertTexture)
  RVA=0x0882693C  token=0x60007E4  UnityEngine.Texture2D ExtractHoudiniImageToTexturePNGJPEG(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes)
  RVA=0x08826974  token=0x60007E5  UnityEngine.Texture2D ExtractHoudiniImageToTextureRaw(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes)
  RVA=0x088268B8  token=0x60007E6  UnityEngine.Texture2D ExtractHoudiniImageToTextureFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes, System.String assetCacheFolderPath)
  RVA=0x08827678  token=0x60007E7  UnityEngine.Material LoadUnityMaterial(System.String materialPath)
  RVA=0x088273E4  token=0x60007E8  UnityEngine.Material LoadSubstanceMaterialWithName(System.String materialPath, System.String substanceName)
  RVA=0x0882721C  token=0x60007E9  UnityEngine.Material LoadSubstanceMaterialWithIndex(System.String materialPath, System.Int32 substanceMaterialIndex)
  RVA=0x08827120  token=0x60007EA  System.Int32 GetUnitySubstanceMaterialKey(System.String unityMaterialPath, System.String substanceName, System.Int32 substanceIndex)
  RVA=0x03D4C200  token=0x60007EB  System.Int32 MaterialNameToKey(System.String materialName)
  RVA=0x08826898  token=0x60007EC  System.Void EnableGPUInstancing(UnityEngine.Material material)
  RVA=0x08827964  token=0x60007ED  System.Boolean MaterialHasGPUInstancingEnabled(UnityEngine.Material material)
  RVA=0x08826204  token=0x60007EE  UnityEngine.Material CopyMaterial(UnityEngine.Material material)
  RVA=0x08826AE8  token=0x60007EF  UnityEngine.Material GetDefaultStandardMaterial()
  RVA=0x08827570  token=0x60007F0  UnityEngine.Texture2D LoadTexture(System.String path)
  RVA=0x08827A40  token=0x60007F1  UnityEngine.Texture2D WhiteTexture()
  RVA=0x08826560  token=0x60007F2  HoudiniEngineUnity.HEU_MaterialData CreateUnitySubstanceMaterialData(System.Int32 materialKey, System.String materialPath, System.String substanceName, System.Int32 substanceIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  RVA=0x088263AC  token=0x60007F3  HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialSourceWrapper sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  RVA=0x08826408  token=0x60007F4  HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialData.Source sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  RVA=0x08827050  token=0x60007F5  HoudiniEngineUnity.HEU_MaterialData GetOrCreateDefaultMaterialInCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  RVA=0x08826B98  token=0x60007F6  HoudiniEngineUnity.HEU_MaterialData GetMaterialDataFromCache(System.Int32 materialKey, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache)
  RVA=0x08826A4C  token=0x60007F7  System.String GenerateDefaultMaterialName(System.Int32 geoID, System.Int32 partID)
  RVA=0x08826264  token=0x60007F8  HoudiniEngineUnity.HEU_MaterialData CreateHoudiniMaterialData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 materialID, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  RVA=0x08826CB4  token=0x60007F9  System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData> GetMaterialDataMapFromCache(System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache)
  RVA=0x0350B670  token=0x60007FA  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_UnityMaterialInfo
TYPE:  class
TOKEN: 0x20000F4
SIZE:  0x28
FIELDS:
  public            System.String                   _unityMaterialPath  // 0x10
  public            System.String                   _substancePath  // 0x18
  public            System.Int32                    _substanceIndex  // 0x20
METHODS:
  RVA=0x03864580  token=0x60007FB  System.Void .ctor(System.String unityMaterialPath, System.String substancePath, System.Int32 substanceIndex)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionBase
TYPE:  class
TOKEN: 0x20000F5
SIZE:  0x30
FIELDS:
  protected         HoudiniEngineUnity.HEU_SessionData_sessionData  // 0x10
  private           System.Boolean                  <UserNotifiedSessionInvalid>k__BackingField  // 0x18
  private           System.String                   _sessionErrorMsg  // 0x20
  private           System.Boolean                  <LogErrorOverride>k__BackingField  // 0x28
  private           System.Boolean                  <ThrowErrorOverride>k__BackingField  // 0x29
  private           HoudiniEngineUnity.HAPI_Result  <LastCallResultCode>k__BackingField  // 0x2c
PROPERTIES:
  UserNotifiedSessionInvalid  get=0x01002A50  set=0x01002B40
  ConnectionState  get=0x0882CA84  set=0x0882CAAC
  ThisSessionMode  get=0x0882CA98  set=0x0882CABC
  LogErrorOverride  get=0x03D4ED50  set=0x03D4ED60
  ThrowErrorOverride  get=0x03D4F2A0  set=0x03D4F2B0
  LastCallResultCode  get=0x03D4EDD0  set=0x03D4EDE0
METHODS:
  RVA=0x03D4EB40  token=0x6000802  System.String GetSessionErrorMsg()
  RVA=0x0882C7B4  token=0x6000807  System.Boolean IsSessionSync()
  RVA=0x01002730  token=0x600080A  HoudiniEngineUnity.HEU_HoudiniAsset GetRegisteredAssetFromID(System.Int32 id)
  RVA=0x0115F4C0  token=0x600080B  System.Boolean IsAssetRegistered(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x0350B670  token=0x600080C  System.Void RegisterAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x0350B670  token=0x600080D  System.Void UnregisterAsset(System.Int32 id)
  RVA=0x0350B670  token=0x600080E  System.Void ReregisterOnAwake(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  RVA=0x03D6D870  token=0x600080F  System.Void .ctor()
  RVA=0x0882CA14  token=0x6000810  System.Void SetSessionErrorMsg(System.String msg, System.Boolean bLogError)
  RVA=0x0882C858  token=0x6000811  System.Void SetSessionConnectionErrorMsg(System.String introMsg, HoudiniEngineUnity.HAPI_Result result, System.Boolean bIsHARSRunning, System.Boolean bLogError)
  RVA=0x0882C7CC  token=0x6000812  System.Void SetLibraryErrorMsg(System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000813  System.Boolean CreateSessionData(System.Boolean bOverwriteExisting, System.Boolean bIsDefaultSession)
  RVA=0x0115F4C0  token=0x6000814  System.Boolean CreateInProcessSession(System.Boolean bIsDefaultSession)
  RVA=0x0115F4C0  token=0x6000815  System.Boolean CreateThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000816  System.Boolean CreateThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000817  System.Boolean CreateCustomSession(System.Boolean bIsDefaultSession)
  RVA=0x0115F4C0  token=0x6000818  System.Boolean ConnectThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize)
  RVA=0x0115F4C0  token=0x6000819  System.Boolean ConnectThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize)
  RVA=0x0115F4C0  token=0x600081A  System.Boolean CloseSession()
  RVA=0x0115F4C0  token=0x600081B  System.Boolean CheckAndCloseExistingSession()
  RVA=0x0882C5EC  token=0x600081C  System.Void ClearSessionInfo()
  RVA=0x0426FEE0  token=0x600081D  System.Void SetSessionData(HoudiniEngineUnity.HEU_SessionData sessionData)
  RVA=0x020B7B20  token=0x600081E  HoudiniEngineUnity.HEU_SessionData GetSessionData()
  RVA=0x0882C75C  token=0x600081F  System.String GetSessionInfo()
  RVA=0x0115F4C0  token=0x6000820  System.Boolean IsSessionValid()
  RVA=0x0115F4C0  token=0x6000821  System.Boolean RestartSession()
  RVA=0x03D4EB40  token=0x6000822  System.String GetLastSessionError()
  RVA=0x0115F4C0  token=0x6000823  System.Boolean CheckVersionMatch()
  RVA=0x0115F4C0  token=0x6000824  System.Boolean InitializeSession(HoudiniEngineUnity.HEU_SessionData sessionData)
  RVA=0x0115F4C0  token=0x6000825  System.Boolean HandleStatusResult(HoudiniEngineUnity.HAPI_Result result, System.String prependMsg, System.Boolean bThrowError, System.Boolean bLogError)
  RVA=0x0350B670  token=0x6000826  System.Void SetServerEnvString(System.String name, System.String value)
  RVA=0x0882C740  token=0x6000827  System.Boolean GetServerEnvString(System.String name, System.String& value)
  RVA=0x03D6D7D0  token=0x6000828  System.Boolean GetServerEnvVarCount(System.Int32& env_count)
  RVA=0x03D6D7D0  token=0x6000829  System.Boolean GetCallResult(HoudiniEngineUnity.HAPI_Result& result)
  RVA=0x03D6D7D0  token=0x600082A  System.Boolean GetCookResult(HoudiniEngineUnity.HAPI_Result& result)
  RVA=0x03D6D7D0  token=0x600082B  System.Boolean GetCookState(HoudiniEngineUnity.HAPI_State& state)
  RVA=0x0882C788  token=0x600082C  System.String GetStatusString(HoudiniEngineUnity.HAPI_StatusType statusType, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity)
  RVA=0x0882C634  token=0x600082D  System.String ComposeNodeCookResult(System.Int32 nodeId, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity)
  RVA=0x01002730  token=0x600082E  System.Int32 GetEnvInt(HoudiniEngineUnity.HAPI_EnvIntType intType)
  RVA=0x01002730  token=0x600082F  System.Int32 GetSessionEnvInt(HoudiniEngineUnity.HAPI_SessionEnvIntType intType, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000830  System.Boolean GetString(System.Int32 stringHandle, System.String& resultString, System.Int32 bufferLength)
  RVA=0x01002730  token=0x6000831  System.Int32 GetStringBufferLength(System.Int32 stringHandle)
  RVA=0x01002730  token=0x6000832  System.Int32 CheckForSpecificErrors(System.Int32 nodeID, System.Int32 errorsToCheck)
  RVA=0x03D503F0  token=0x6000833  System.Single GetTime()
  RVA=0x0115F4C0  token=0x6000834  System.Boolean SetTime(System.Single time)
  RVA=0x0115F4C0  token=0x6000835  System.Boolean GetUseHoudiniTime()
  RVA=0x0115F4C0  token=0x6000836  System.Boolean SetUseHoudiniTime(System.Boolean enable)
  RVA=0x03D6D7E0  token=0x6000837  System.Boolean LoadAssetLibraryFromFile(System.String assetPath, System.Boolean bAllowOverwrite, System.Int32& libraryID)
  RVA=0x03D6D7E0  token=0x6000838  System.Boolean LoadAssetLibraryFromMemory(System.Byte[] buffer, System.Boolean bAllowOverwrite, System.Int32& libraryID)
  RVA=0x03D6D7C0  token=0x6000839  System.Boolean CreateNode(System.Int32 parentNodeID, System.String operatorName, System.String nodeLabel, System.Boolean bCookOnCreation, System.Int32& newNodeID)
  RVA=0x0350B670  token=0x600083A  System.Void DeleteNode(System.Int32 nodeID)
  RVA=0x0115F4C0  token=0x600083B  System.Boolean CookNode(System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.Boolean bSplitGeosByGroup)
  RVA=0x0115F4C0  token=0x600083C  System.Boolean CookNodeWithOptions(System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions cookOptions)
  RVA=0x0115F4C0  token=0x600083D  System.Boolean RenameNode(System.Int32 nodeID, System.String newName)
  RVA=0x0115F4C0  token=0x600083E  System.Boolean ConnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32 nodeIDToConnect, System.Int32 outputIndex)
  RVA=0x0115F4C0  token=0x600083F  System.Boolean DisconnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Boolean bLogError)
  RVA=0x03D6D810  token=0x6000840  System.Boolean QueryNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& connectedNodeID, System.Boolean bLogError)
  RVA=0x03D6D7E0  token=0x6000841  System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& nodeNameIndex)
  RVA=0x03D6D740  token=0x6000842  System.Boolean GetAvailableAssetCount(System.Int32 libraryID, System.Int32& assetCount)
  RVA=0x0115F4C0  token=0x6000843  System.Boolean GetAvailableAssets(System.Int32 libraryID, System.Int32[]& assetNames, System.Int32 assetCount)
  RVA=0x0115F4C0  token=0x6000844  System.Boolean GetAssetInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000845  System.Boolean GetNodeInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Boolean bLogError)
  RVA=0x06B99BB0  token=0x6000846  System.Boolean GetNodePath(System.Int32 nodeID, System.Int32 relativeNodeID, System.String& path)
  RVA=0x0115F4C0  token=0x6000847  System.Boolean IsNodeValid(System.Int32 nodeID, System.Int32 uniqueNodeID)
  RVA=0x0115F4C0  token=0x6000848  System.Boolean ComposeChildNodeList(System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32& count, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000849  System.Boolean GetComposedChildNodeList(System.Int32 parentNodeID, System.Int32[] childNodeIDs, System.Int32 count, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x600084A  System.Boolean LoadHIPFile(System.String fileName, System.Boolean bCookOnLoad)
  RVA=0x0115F4C0  token=0x600084B  System.Boolean SaveHIPFile(System.String fileName, System.Boolean bLockNodes)
  RVA=0x0115F4C0  token=0x600084C  System.Boolean GetObjectInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo)
  RVA=0x0115F4C0  token=0x600084D  System.Boolean GetObjectTransform(System.Int32 nodeID, System.Int32 relativeToNodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform& hapiTransform)
  RVA=0x0115F4C0  token=0x600084E  System.Boolean SetObjectTransform(System.Int32 nodeID, HoudiniEngineUnity.HAPI_TransformEuler& hapiTransform)
  RVA=0x03D6D740  token=0x600084F  System.Boolean ComposeObjectList(System.Int32 nodeID, System.Int32& objectCount)
  RVA=0x0115F4C0  token=0x6000850  System.Boolean GetComposedObjectList(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000851  System.Boolean GetComposedObjectTransforms(System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000852  System.Boolean GetDisplayGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError)
  RVA=0x03D6D740  token=0x6000853  System.Boolean GetOutputGeoCount(System.Int32 nodeID, System.Int32& count, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000854  System.Boolean GetOutputGeoInfos(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo[]& geoInfosArray, System.Int32 count, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000855  System.Boolean GetGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000856  System.Boolean GetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x0115F4C0  token=0x6000857  System.Boolean GetAttributeInfo(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  RVA=0x0115F4C0  token=0x6000858  System.Boolean GetAttributeNames(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.String[]& attributeNames, System.Int32 count)
  RVA=0x0115F4C0  token=0x6000859  System.Boolean GetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] dataArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600085A  System.Boolean GetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Single[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600085B  System.Boolean GetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[]& data, System.Int32 dataLength, System.Int32[]& sizesArray, System.Int32 start, System.Int32 sizesLength)
  RVA=0x0115F4C0  token=0x600085C  System.Boolean GetAttributeFloat64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Double[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600085D  System.Boolean GetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600085E  System.Boolean GetAttributeUInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Byte[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600085F  System.Boolean GetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.SByte[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000860  System.Boolean GetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int16[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000861  System.Boolean GetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int64[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000862  System.Boolean GetGroupNames(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& names, System.Int32 count)
  RVA=0x0115F4C0  token=0x6000863  System.Boolean GetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length)
  RVA=0x03D6D7F0  token=0x6000864  System.Boolean GetGroupCountOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, System.Int32& pointGroupCount, System.Int32& primitiveGroupCount)
  RVA=0x0115F4C0  token=0x6000865  System.Boolean GetGroupNamesOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& groupNamesArray, System.Int32 groupCount)
  RVA=0x0115F4C0  token=0x6000866  System.Boolean GetGroupMembershipOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000867  System.Boolean GetInstancedPartIds(System.Int32 nodeID, System.Int32 partID, System.Int32[] instancedPartsArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000868  System.Boolean GetInstancerPartTransforms(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000869  System.Boolean GetInstanceTransformsOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600086A  System.Boolean GetInstancedObjectIds(System.Int32 nodeID, System.Int32[] instanced_node_id_array, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600086B  System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600086C  System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x600086D  System.Boolean GetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600086E  System.Boolean GetBoxInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_BoxInfo& boxInfo)
  RVA=0x0115F4C0  token=0x600086F  System.Boolean GetSphereInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_SphereInfo& sphereInfo)
  RVA=0x0115F4C0  token=0x6000870  System.Boolean GetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo)
  RVA=0x0115F4C0  token=0x6000871  System.Boolean GetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000872  System.Boolean GetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000873  System.Boolean GetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000874  System.Boolean GetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& inputCurveInfo)
  RVA=0x0115F4C0  token=0x6000875  System.Boolean SetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x0115F4C0  token=0x6000876  System.Boolean SetFaceCount(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000877  System.Boolean SetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000878  System.Boolean SetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int32[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000879  System.Boolean SetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.SByte[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600087A  System.Boolean SetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int16[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600087B  System.Boolean SetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int64[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600087C  System.Boolean SetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600087D  System.Boolean SetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 dataLength, System.Int32[] sizesArray, System.Int32 start, System.Int32 sizesLength)
  RVA=0x0115F4C0  token=0x600087E  System.Boolean SetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String[] data, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600087F  System.Boolean AddAttribute(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  RVA=0x0115F4C0  token=0x6000880  System.Boolean AddGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName)
  RVA=0x0115F4C0  token=0x6000881  System.Boolean DeleteGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName)
  RVA=0x0115F4C0  token=0x6000882  System.Boolean SetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[] membershipArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000883  System.Boolean CommitGeo(System.Int32 nodeID)
  RVA=0x0115F4C0  token=0x6000884  System.Boolean RevertGeo(System.Int32 nodeID)
  RVA=0x0115F4C0  token=0x6000885  System.Boolean SetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo)
  RVA=0x0115F4C0  token=0x6000886  System.Boolean SetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000887  System.Boolean SetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000888  System.Boolean SetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x6000889  System.Boolean SetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& curveInfo)
  RVA=0x0115F4C0  token=0x600088A  System.Boolean SetInputCurvePositions(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x600088B  System.Boolean SetInputCurvePositionsRotationsScales(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length, System.Single[] rotationsArray, System.Int32 rotationsStart, System.Int32 rotationsLength, System.Single[] scalesArray, System.Int32 scalesStart, System.Int32 scalesLength)
  RVA=0x0115F4C0  token=0x600088C  System.Boolean GetMaterialOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo)
  RVA=0x0115F4C0  token=0x600088D  System.Boolean GetMaterialNodeIDsOnFaces(System.Int32 nodeID, System.Int32 partID, System.Boolean& bSingleFaceMaterial, System.Int32[] materialNodeIDs, System.Int32 faceCount)
  RVA=0x0115F4C0  token=0x600088E  System.Boolean GetMaterialInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x600088F  System.Boolean GetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo)
  RVA=0x0115F4C0  token=0x6000890  System.Boolean SetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo)
  RVA=0x0115F4C0  token=0x6000891  System.Boolean RenderTextureToImage(System.Int32 materialNodeID, System.Int32 parmID, System.Boolean bLogError)
  RVA=0x0115F4C0  token=0x6000892  System.Boolean RenderCOPToImage(System.Int32 copNodeID)
  RVA=0x0882C67C  token=0x6000893  System.Boolean ExtractImageToMemory(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.Byte[]& buffer)
  RVA=0x0882C6C0  token=0x6000894  System.Boolean GetImagePlanes(System.Int32 nodeID, System.Int32[] imagePlanes, System.Int32 numImagePlanes)
  RVA=0x0882C660  token=0x6000895  System.Boolean ExtractImageToFile(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.String destinationFolderPath, System.String& destinationFilePath)
  RVA=0x0115F4C0  token=0x6000896  System.Boolean GetParams(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos, System.Int32 start, System.Int32 length)
  RVA=0x03D6D800  token=0x6000897  System.Boolean GetParmTagName(System.Int32 nodeID, System.Int32 parmID, System.Int32 tagIndex, System.Int32& tagName)
  RVA=0x03D6D800  token=0x6000898  System.Boolean GetParmTagValue(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Int32& tagValue)
  RVA=0x0115F4C0  token=0x6000899  System.Boolean ParmHasTag(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Boolean& hasTag)
  RVA=0x0115F4C0  token=0x600089A  System.Boolean GetParamIntValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length)
  RVA=0x03D6D800  token=0x600089B  System.Boolean GetParamIntValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value)
  RVA=0x0115F4C0  token=0x600089C  System.Boolean GetParamFloatValues(System.Int32 nodeID, System.Single[] values, System.Int32 start, System.Int32 length)
  RVA=0x03D6D800  token=0x600089D  System.Boolean GetParamFloatValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Single& value)
  RVA=0x0115F4C0  token=0x600089E  System.Boolean GetParamStringValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length)
  RVA=0x03D6D800  token=0x600089F  System.Boolean GetParamStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value)
  RVA=0x03D6D810  token=0x60008A0  System.Boolean GetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32& nodeValue)
  RVA=0x0115F4C0  token=0x60008A1  System.Boolean GetParamChoiceValues(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmChoiceInfo[] values, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x60008A2  System.Boolean SetParamIntValues(System.Int32 nodeID, System.Int32[]& values, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x60008A3  System.Boolean SetParamIntValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Int32 value)
  RVA=0x0115F4C0  token=0x60008A4  System.Boolean SetParamFloatValues(System.Int32 nodeID, System.Single[]& values, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x60008A5  System.Boolean SetParamFloatValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Single value)
  RVA=0x0115F4C0  token=0x60008A6  System.Boolean SetParamStringValue(System.Int32 nodeID, System.String strValue, System.Int32 parmID, System.Int32 index)
  RVA=0x0115F4C0  token=0x60008A7  System.Boolean SetParamStringValue(System.Int32 nodeID, System.String parmName, System.String parmValue, System.Int32 index)
  RVA=0x0115F4C0  token=0x60008A8  System.Boolean SetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32 nodeValueID)
  RVA=0x0115F4C0  token=0x60008A9  System.Boolean InsertMultiparmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition)
  RVA=0x0115F4C0  token=0x60008AA  System.Boolean RemoveMultiParmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition)
  RVA=0x0115F4C0  token=0x60008AB  System.Boolean GetParmWithTag(System.Int32 nodeID, System.String tagName, System.Int32& parmID)
  RVA=0x0115F4C0  token=0x60008AC  System.Boolean RevertParmToDefault(System.Int32 nodeID, System.String parm_name, System.Int32 index)
  RVA=0x0115F4C0  token=0x60008AD  System.Boolean RevertParmToDefaults(System.Int32 nodeID, System.String parm_name)
  RVA=0x03D6D810  token=0x60008AE  System.Boolean GetParmIDFromName(System.Int32 nodeID, System.String parmName, System.Int32& parmID)
  RVA=0x03D6D820  token=0x60008AF  System.Boolean GetParmStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Boolean evaluate, System.Int32& value)
  RVA=0x03D6D7B0  token=0x60008B0  System.Boolean CreateInputNode(System.Int32& nodeID, System.String name)
  RVA=0x03D6D7B0  token=0x60008B1  System.Boolean CreateInputCurveNode(System.Int32& nodeID, System.String name)
  RVA=0x03D6D770  token=0x60008B2  System.Boolean CreateHeightFieldInput(System.Int32 parentNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize, HoudiniEngineUnity.HAPI_HeightFieldSampling sampling, System.Int32& heightfieldNodeID, System.Int32& heightNodeID, System.Int32& maskNodeID, System.Int32& mergeNodeID)
  RVA=0x03D6D7A0  token=0x60008B3  System.Boolean CreateHeightfieldInputVolumeNode(System.Int32 parentNodeID, System.Int32& newNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize)
  RVA=0x0882C6F8  token=0x60008B4  System.Boolean GetPreset(System.Int32 nodeID, System.Byte[]& presetData)
  RVA=0x0115F4C0  token=0x60008B5  System.Boolean SetPreset(System.Int32 nodeID, System.Byte[] presetData)
  RVA=0x0115F4C0  token=0x60008B6  System.Boolean GetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo)
  RVA=0x0115F4C0  token=0x60008B7  System.Boolean GetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.Single[] valuesArray, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x60008B8  System.Boolean SetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo)
  RVA=0x0882CA4C  token=0x60008B9  System.Boolean SetVolumeTileFloatData(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeTileInfo& tileInfo, System.Single[] valuesArray, System.Int32 length)
  RVA=0x03D6D830  token=0x60008BA  System.Boolean GetVolumeBounds(System.Int32 nodeID, System.Int32 partID, System.Single& x_min, System.Single& y_min, System.Single& z_min, System.Single& x_max, System.Single& y_max, System.Single& z_max, System.Single& x_center, System.Single& y_center, System.Single& z_center)
  RVA=0x0115F4C0  token=0x60008BB  System.Boolean SetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.String name, System.Single[] valuesArray, System.Int32 start, System.Int32 length)
  RVA=0x03D6D7D0  token=0x60008BC  System.Boolean GetActiveCacheCount(System.Int32& activeCacheCount)
  RVA=0x0115F4C0  token=0x60008BD  System.Boolean GetActiveCacheNames(System.Int32[] cacheNamesArray, System.Int32 activeCacheCount)
  RVA=0x03D6D7E0  token=0x60008BE  System.Boolean GetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32& propertyValue)
  RVA=0x0115F4C0  token=0x60008BF  System.Boolean SetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32 propertyValue)
  RVA=0x0115F4C0  token=0x60008C0  System.Boolean SaveGeoToFile(System.Int32 nodeID, System.String fileName)
  RVA=0x0115F4C0  token=0x60008C1  System.Boolean LoadGeoFromFile(System.Int32 nodeID, System.String file_name)
  RVA=0x0115F4C0  token=0x60008C2  System.Boolean SaveNodeToFile(System.Int32 nodeID, System.String fileName)
  RVA=0x03D6D7C0  token=0x60008C3  System.Boolean LoadNodeFromFile(System.String file_name, System.Int32 parentNodeID, System.String nodeLabel, System.Boolean cook_on_load, System.Int32& newNodeID)
  RVA=0x03D6D7E0  token=0x60008C4  System.Boolean GetGeoSize(System.Int32 nodeID, System.String format, System.Int32& size)
  RVA=0x0115F4C0  token=0x60008C5  System.Boolean GetHandleInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_HandleInfo[] handleInfos, System.Int32 start, System.Int32 length)
  RVA=0x0115F4C0  token=0x60008C6  System.Boolean GetHandleBindingInfo(System.Int32 nodeID, System.Int32 handleIndex, HoudiniEngineUnity.HAPI_HandleBindingInfo[] handleBindingInfos, System.Int32 start, System.Int32 length)
  RVA=0x03D6D750  token=0x60008C7  System.Boolean ConvertTransform(HoudiniEngineUnity.HAPI_TransformEuler& inTransform, HoudiniEngineUnity.HAPI_RSTOrder RSTOrder, HoudiniEngineUnity.HAPI_XYZOrder ROTOrder, HoudiniEngineUnity.HAPI_TransformEuler& outTransform)
  RVA=0x03D6D820  token=0x60008C8  System.Boolean GetTotalCookCount(System.Int32 nodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean includeChildren, System.Int32& count)
  RVA=0x0115F4C0  token=0x60008C9  System.Boolean SetSessionSync(System.Boolean enable)
  RVA=0x0115F4C0  token=0x60008CA  System.Boolean GetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport)
  RVA=0x0115F4C0  token=0x60008CB  System.Boolean SetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport)
  RVA=0x0115F4C0  token=0x60008CC  System.Boolean GetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo)
  RVA=0x0115F4C0  token=0x60008CD  System.Boolean SetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo)
  RVA=0x0115F4C0  token=0x60008CE  System.Boolean SetNodeDisplay(System.Int32 node_id, System.Int32 onOff)
END_CLASS

CLASS: HoudiniEngineUnity.SessionConnectionState
TYPE:  sealed struct
TOKEN: 0x20000F6
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.SessionConnectionStateNOT_CONNECTED  // const
  public    static  HoudiniEngineUnity.SessionConnectionStateCONNECTED  // const
  public    static  HoudiniEngineUnity.SessionConnectionStateFAILED_TO_CONNECT  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.SessionMode
TYPE:  sealed struct
TOKEN: 0x20000F7
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.SessionMode  Socket  // const
  public    static  HoudiniEngineUnity.SessionMode  Pipe  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionData
TYPE:  sealed class
TOKEN: 0x20000F8
SIZE:  0x58
FIELDS:
  public    static  System.Int64                    INVALID_SESSION_ID  // static @ 0x0
  public            HoudiniEngineUnity.HAPI_Session _HAPISession  // 0x10
  private           System.Int32                    _serverProcessID  // 0x20
  private           System.Boolean                  _initialized  // 0x24
  private           System.String                   _pipeName  // 0x28
  private           System.Int32                    _port  // 0x30
  private           System.String                   _sessionClassType  // 0x38
  private           System.Boolean                  _isDefaultSession  // 0x40
  private           HoudiniEngineUnity.HEU_SessionSyncData_sessionSync  // 0x48
  private           HoudiniEngineUnity.SessionConnectionState_connectionState  // 0x50
  private           HoudiniEngineUnity.SessionMode  _sessionMode  // 0x54
PROPERTIES:
  SessionID  get=0x0882CC1C  set=0x03D4EC10
  ProcessID  get=0x03D5CD90  set=0x01003B60
  SessionType  get=0x01002730  set=0x010410F0
  IsInitialized  get=0x0115F4C0  set=0x03D4F0A0
  IsValidSessionID  get=0x0115F4C0
  PipeName  get=0x0882CB78  set=0x02C92F10
  Port  get=0x03D4ED20  set=0x03D4EE10
  SessionClassType  get=0x0882CBA4  set=0x0882CC6C
  IsDefaultSession  get=0x03D4EE90  set=0x03D4EEB0
  IsSessionSync  get=0x05ED8890
  ThisConnectionMode  get=0x03D4EED0  set=0x03D4EF20
  ThisSessionMode  get=0x03D4EEC0  set=0x03D4EF10
METHODS:
  RVA=0x0882CACC  token=0x60008CF  HoudiniEngineUnity.HEU_SessionSyncData GetOrCreateSessionSync()
  RVA=0x03D4EA70  token=0x60008D0  HoudiniEngineUnity.HEU_SessionSyncData GetSessionSync()
  RVA=0x02692290  token=0x60008D1  System.Void SetSessionSync(HoudiniEngineUnity.HEU_SessionSyncData syncData)
  RVA=0x03D5C2D0  token=0x60008E8  System.Void .ctor()
  RVA=0x0882CB3C  token=0x60008E9  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionHAPI
TYPE:  class
TOKEN: 0x20000F9
SIZE:  0x30
EXTENDS: HoudiniEngineUnity.HEU_SessionBase
FIELDS:
METHODS:
  RVA=0x03D6D870  token=0x60008EA  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionManager
TYPE:  static class
TOKEN: 0x20000FA
SIZE:  0x10
FIELDS:
  private   static  HoudiniEngineUnity.HEU_SessionBase_defaultSession  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int64,HoudiniEngineUnity.HEU_SessionBase>_sessionMap  // static @ 0x8
  public    static  HoudiniEngineUnity.HEU_SessionManager.CreateSessionFromTypeDelegate_createSessionFromTypeDelegate  // static @ 0x10
METHODS:
  RVA=0x0882D3E8  token=0x60008EB  HoudiniEngineUnity.HEU_SessionBase CreateSessionObject()
  RVA=0x0882D3A4  token=0x60008EC  HoudiniEngineUnity.HEU_SessionBase CreateSessionFromType(System.Type type)
  RVA=0x0882D764  token=0x60008ED  HoudiniEngineUnity.HEU_SessionBase GetDefaultSession()
  RVA=0x0882E9BC  token=0x60008EE  System.Void RegisterSession(System.Int64 sessionID, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0882EC00  token=0x60008EF  System.Void UnregisterSession(System.Int64 sessionID)
  RVA=0x0882DE94  token=0x60008F0  HoudiniEngineUnity.HEU_SessionBase GetSessionWithID(System.Int64 sessionID)
  RVA=0x0882EAE4  token=0x60008F1  System.Void SaveAllSessionData()
  RVA=0x0882E2AC  token=0x60008F2  System.Void LoadAllSessionData()
  RVA=0x0882E124  token=0x60008F3  System.Void InternalValidateSceneAssets()
  RVA=0x0882D964  token=0x60008F4  HoudiniEngineUnity.HEU_SessionBase GetOrCreateDefaultSession(System.Boolean bNotifyUserError)
  RVA=0x0882D324  token=0x60008F5  System.Boolean CreateInProcessSession()
  RVA=0x0882D4AC  token=0x60008F6  System.Boolean CreateThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  RVA=0x0882D42C  token=0x60008F7  System.Boolean CreateThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  RVA=0x0882D2A4  token=0x60008F8  System.Boolean CreateCustomSession()
  RVA=0x0882D224  token=0x60008F9  System.Boolean ConnectThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout)
  RVA=0x0882D1A4  token=0x60008FA  System.Boolean ConnectThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout)
  RVA=0x0882E958  token=0x60008FB  System.Void RecreateDefaultSessionData()
  RVA=0x0882D128  token=0x60008FC  System.Boolean ConnectSessionSyncUsingThriftSocket(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  RVA=0x0882D0AC  token=0x60008FD  System.Boolean ConnectSessionSyncUsingThriftPipe(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  RVA=0x0882E0BC  token=0x60008FE  System.Boolean InitializeDefaultSession()
  RVA=0x0882D010  token=0x60008FF  System.Boolean CloseDefaultSession()
  RVA=0x0882CD6C  token=0x6000900  System.Void CloseAllSessions()
  RVA=0x0882CC9C  token=0x6000901  System.Void CheckAndCloseExistingSession()
  RVA=0x0882DDF0  token=0x6000902  HoudiniEngineUnity.HEU_SessionData GetSessionData()
  RVA=0x0882DE34  token=0x6000903  System.String GetSessionInfo()
  RVA=0x0882E750  token=0x6000904  System.Boolean LoadStoredDefaultSession()
  RVA=0x0882EA40  token=0x6000905  System.Boolean RestartSession()
  RVA=0x0882EC78  token=0x6000906  System.Boolean ValidatePluginSession(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0882D84C  token=0x6000907  System.String GetLastSessionError()
  RVA=0x0882CD30  token=0x6000908  System.Boolean CheckVersionMatch()
  RVA=0x0232EB60  token=0x6000909  System.Boolean ClearConnectionError()
  RVA=0x0882D6F4  token=0x600090A  System.String GetConnectionError(System.Boolean clear)
  RVA=0x0882E230  token=0x600090B  System.Boolean IsHARSProcessRunning(System.Int32 processID)
  RVA=0x0882E6DC  token=0x600090C  System.Boolean LoadSessionFromHIP(System.Boolean bCookNodes, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0882EB8C  token=0x600090D  System.Boolean SaveSessionToHIP(System.Boolean bLockNodes, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0339AE90  token=0x600090E  System.String GetHoudiniPathOnMacOS(System.String houdiniPath)
  RVA=0x0882E7C0  token=0x600090F  System.Boolean OpenHoudini(System.String args)
  RVA=0x0882E874  token=0x6000910  System.Boolean OpenSessionInHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0882D720  token=0x6000911  HoudiniEngineUnity.HAPI_License GetCurrentLicense(System.Boolean bLogError)
  RVA=0x0882DFEC  token=0x6000912  System.String GetString(System.Int32 stringHandle, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0882DF14  token=0x6000913  System.String[] GetStringValuesFromStringIndices(System.Int32[] strIndices)
  RVA=0x0882D80C  token=0x6000914  System.String[] GetGroupNames(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Boolean isInstanced)
  RVA=0x0882D7D4  token=0x6000915  System.Boolean GetGroupMembership(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[]& membership, System.Boolean isInstanced)
  RVA=0x0882D904  token=0x6000916  System.String GetNodeName(System.Int32 nodeID, HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0882D8A4  token=0x6000917  System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.String& inputName)
  RVA=0x0882D52C  token=0x6000918  System.Boolean GetComposedChildNodeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32[]& childNodeIDs, System.Boolean bLogIfError)
  RVA=0x0882D578  token=0x6000919  System.Boolean GetComposedObjectListMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length)
  RVA=0x0882D634  token=0x600091A  System.Boolean GetComposedObjectTransformsMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length)
  RVA=0x0882E054  token=0x600091B  System.String GetUniqueMaterialShopName(System.Int32 assetID, System.Int32 materialID)
  RVA=0x0882ECC0  token=0x600091C  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionPDG
TYPE:  static class
TOKEN: 0x20000FC
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionSyncData
TYPE:  class
TOKEN: 0x20000FD
SIZE:  0x68
FIELDS:
  private           System.Int32                    _status  // 0x10
  public            System.Single                   _timeLastUpdate  // 0x14
  public            System.Single                   _timeStartConnection  // 0x18
  public            System.String                   _newNodeName  // 0x20
  public            System.Int32                    _nodeTypeIndex  // 0x28
  public            System.Boolean                  _validForConnection  // 0x2c
  public            HoudiniEngineUnity.HAPI_Viewport_viewportHAPI  // 0x30
  public            HoudiniEngineUnity.HAPI_Viewport_viewportLocal  // 0x48
  public            System.Boolean                  _viewportJustUpdated  // 0x60
  public            HoudiniEngineUnity.HAPI_SessionSyncInfo_syncInfo  // 0x61
PROPERTIES:
  SyncStatus  get=0x0882EE0C  set=0x03D6D880
METHODS:
  RVA=0x0882ED54  token=0x6000923  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetSync
TYPE:  class
TOKEN: 0x20000FF
SIZE:  0x98
EXTENDS: HoudiniEngineUnity.HEU_BaseSync
FIELDS:
  public            HoudiniEngineUnity.HEU_AssetSync.AssetSyncCallback_onAssetLoaded  // 0x88
  public            System.String                   _assetPath  // 0x90
METHODS:
  RVA=0x0350B670  token=0x6000924  System.Void OnEnable()
  RVA=0x088207A8  token=0x6000925  System.Void OnDestroy()
  RVA=0x088206D0  token=0x6000926  System.Void InitializeAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.String nodeName, UnityEngine.Transform parent, UnityEngine.Vector3 startPosition)
  RVA=0x08820674  token=0x6000927  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo CreateThreadedTask()
  RVA=0x08820818  token=0x6000928  System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback)
  RVA=0x0882086C  token=0x6000929  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x088207B0  token=0x600092A  System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  RVA=0x088207EC  token=0x600092B  System.Void Resync()
  RVA=0x088208E4  token=0x600092C  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SyncedEventData
TYPE:  class
TOKEN: 0x2000101
SIZE:  0x28
FIELDS:
  public            System.Boolean                  CookSuccess  // 0x10
  public            HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadDataTopNodeData  // 0x18
  public            HoudiniEngineUnity.HEU_BaseSync OutputObject  // 0x20
METHODS:
  RVA=0x0882EE1C  token=0x6000931  System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HoudiniEngineUnity.HEU_BaseSync bOutputObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_BaseSync
TYPE:  class
TOKEN: 0x2000102
SIZE:  0x88
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Int32                    _cookNodeID  // 0x18
  public            System.Int64                    _sessionID  // 0x20
  public            System.String                   _nodeName  // 0x28
  public            System.Boolean                  _initialized  // 0x30
  public            System.Boolean                  _syncing  // 0x31
  public            System.Boolean                  _deleteParent  // 0x32
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput>_generatedOutputs  // 0x38
  public            System.String                   _outputCacheDirectory  // 0x40
  public            System.Collections.Generic.List<System.String>_outputCacheFilePaths  // 0x48
  public            HoudiniEngineUnity.HEU_GenerateOptions_generateOptions  // 0x50
  public            System.Text.StringBuilder       _log  // 0x58
  public            System.Text.StringBuilder       _error  // 0x60
  public            System.Boolean                  _sessionSyncAutoCook  // 0x68
  private           System.Action<HoudiniEngineUnity.HEU_SyncedEventData>_onSynced  // 0x70
  protected         HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo_loadTask  // 0x78
  protected         System.Int32                    _totalCookCount  // 0x80
  protected         System.Boolean                  _firstSyncComplete  // 0x84
PROPERTIES:
  OnSynced  get=0x03D4EB30  set=0x0519C3C8
METHODS:
  RVA=0x0350B670  token=0x6000932  System.Void Awake()
  RVA=0x088207A8  token=0x6000933  System.Void OnDestroy()
  RVA=0x0882189C  token=0x6000934  System.Void DeleteSessionData()
  RVA=0x088218C0  token=0x6000935  System.Void DestroyGeneratedData()
  RVA=0x03D6D6C0  token=0x6000936  System.Void Initialize()
  RVA=0x088247E4  token=0x6000937  HoudiniEngineUnity.HEU_SessionBase GetHoudiniSession(System.Boolean bCreateIfNotFound)
  RVA=0x088248E8  token=0x6000938  System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08824918  token=0x6000939  System.Void Log(System.String msg)
  RVA=0x088214FC  token=0x600093A  System.Void ClearLog()
  RVA=0x08821B08  token=0x600093B  System.Void Error(System.String error)
  RVA=0x08824904  token=0x600093C  System.Boolean IsLoaded()
  RVA=0x08824E54  token=0x600093D  System.Void StartSync()
  RVA=0x0350B670  token=0x600093E  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08824F18  token=0x600093F  System.Void StopSync()
  RVA=0x08824C48  token=0x6000940  System.Void Resync()
  RVA=0x088211C4  token=0x6000941  System.Void Bake()
  RVA=0x08824F74  token=0x6000942  System.Void Unload()
  RVA=0x08824B9C  token=0x6000943  System.Void Reset()
  RVA=0x088249DC  token=0x6000944  System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  RVA=0x088233E0  token=0x6000945  System.Void GenerateObjects(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  RVA=0x08821BD8  token=0x6000946  System.Void GenerateGeometry(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, System.Int32 objIndex)
  RVA=0x08824AE0  token=0x6000947  System.Void OnStopped(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  RVA=0x08823460  token=0x6000948  System.Void GenerateTerrain(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> terrainBuffers)
  RVA=0x08822E48  token=0x6000949  System.Void GenerateMesh(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh> meshBuffers)
  RVA=0x08821B28  token=0x600094A  System.Void GenerateAllInstancers(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer> instancerBuffers, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  RVA=0x08821CE0  token=0x600094B  System.Void GenerateInstancer(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap)
  RVA=0x088227B0  token=0x600094C  System.Void GenerateInstancesFromNodeIDs(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap, UnityEngine.Transform instanceRootTransform)
  RVA=0x08821F78  token=0x600094D  System.Void GenerateInstancesFromAssetPaths(HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, UnityEngine.Transform instanceRootTransform)
  RVA=0x08821718  token=0x600094E  System.Void CreateNewInstanceFromObject(UnityEngine.GameObject assetSourceGO, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.String[] instancePrefixes, System.String instanceName, UnityEngine.GameObject collisionSourceGO)
  RVA=0x0882114C  token=0x600094F  System.Void ApplyAttributeModifiersOnGameObjectOutput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partId, UnityEngine.GameObject& go)
  RVA=0x088218C8  token=0x6000950  System.Void DestroyOutputs()
  RVA=0x08824C74  token=0x6000951  System.Void SetOutputVisiblity(HoudiniEngineUnity.HEU_LoadBufferBase buffer)
  RVA=0x0882488C  token=0x6000952  System.String GetOutputCacheDirectory()
  RVA=0x03CB2D80  token=0x6000953  System.Void SetOutputCacheDirectory(System.String directory)
  RVA=0x088210C4  token=0x6000954  System.Void AddGeneratedOutputFilePath(System.String path)
  RVA=0x0350B670  token=0x6000955  System.Void SyncUpdate()
  RVA=0x08824FE8  token=0x6000958  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GenerateOptions
TYPE:  sealed struct
TOKEN: 0x2000103
SIZE:  0x15
FIELDS:
  public            System.Boolean                  _generateUVs  // 0x10
  public            System.Boolean                  _generateTangents  // 0x11
  public            System.Boolean                  _generateNormals  // 0x12
  public            System.Boolean                  _useLODGroups  // 0x13
  public            System.Boolean                  _splitPoints  // 0x14
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeoSync
TYPE:  class
TOKEN: 0x2000104
SIZE:  0x90
EXTENDS: HoudiniEngineUnity.HEU_BaseSync
FIELDS:
  public            System.String                   _filePath  // 0x88
METHODS:
  RVA=0x08825170  token=0x6000959  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08825224  token=0x600095A  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_NodeSync
TYPE:  class
TOKEN: 0x2000105
SIZE:  0x90
EXTENDS: HoudiniEngineUnity.HEU_BaseSync
FIELDS:
  public            System.String                   _nodeSaveFilePath  // 0x88
METHODS:
  RVA=0x0350B670  token=0x600095B  System.Void OnEnable()
  RVA=0x088207A8  token=0x600095C  System.Void OnDestroy()
  RVA=0x08827BC4  token=0x600095D  System.Void InitializeFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.String nodeName, System.String filePath)
  RVA=0x08827CC8  token=0x600095E  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x08827C4C  token=0x600095F  System.Boolean SaveNodeToFile(System.String filePath)
  RVA=0x08827B20  token=0x6000960  System.Void CreateNodeSync(HoudiniEngineUnity.HEU_SessionBase session, System.String opName, System.String nodeNabel)
  RVA=0x088207EC  token=0x6000961  System.Void Resync()
  RVA=0x08827D78  token=0x6000962  System.Void SyncUpdate()
  RVA=0x088208E4  token=0x6000963  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Task
TYPE:  abstract class
TOKEN: 0x2000106
SIZE:  0x30
FIELDS:
  public            HoudiniEngineUnity.HEU_Task.TaskStatus_status  // 0x10
  public            HoudiniEngineUnity.HEU_Task.TaskResult_result  // 0x14
  private           System.Guid                     _guid  // 0x18
  public            HoudiniEngineUnity.HEU_Task.TaskCallback_taskCompletedDelegate  // 0x28
PROPERTIES:
  TaskGuid  get=0x03D51D80
METHODS:
  RVA=0x0882F754  token=0x6000965  System.Void .ctor()
  RVA=-1  // abstract  token=0x6000966  System.Void DoTask()
  RVA=0x0350B670  token=0x6000967  System.Void UpdateTask()
  RVA=-1  // abstract  token=0x6000968  System.Void KillTask()
  RVA=-1  // abstract  token=0x6000969  System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetTask
TYPE:  class
TOKEN: 0x200010A
SIZE:  0x60
EXTENDS: HoudiniEngineUnity.HEU_Task
FIELDS:
  public            HoudiniEngineUnity.HEU_AssetTask.BuildType_buildType  // 0x30
  public            HoudiniEngineUnity.HEU_HoudiniAsset_asset  // 0x38
  public            System.String                   _assetPath  // 0x40
  public            UnityEngine.Vector3             _position  // 0x48
  public            System.Boolean                  _buildResult  // 0x54
  public            System.Int64                    _forceSessionID  // 0x58
METHODS:
  RVA=0x08820E68  token=0x600096E  HoudiniEngineUnity.HEU_SessionBase GetTaskSession()
  RVA=0x08820ACC  token=0x600096F  System.Void DoTask()
  RVA=0x08820EF8  token=0x6000970  System.Void KillTask()
  RVA=0x088208EC  token=0x6000971  System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result)
  RVA=0x08820A70  token=0x6000972  System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputs)
  RVA=0x08820A48  token=0x6000973  System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_CookedEventData cookedEventData)
  RVA=0x08820A48  token=0x6000974  System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData)
  RVA=0x08821054  token=0x6000975  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TaskManager
TYPE:  class
TOKEN: 0x200010C
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task>_tasks  // static @ 0x0
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task>_pendingAdd  // static @ 0x8
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task>_pendingRemove  // static @ 0x10
METHODS:
  RVA=0x0882F628  token=0x6000976  System.Void .cctor()
  RVA=0x0350B670  token=0x6000977  System.Void Update()
  RVA=0x0882F238  token=0x6000978  HoudiniEngineUnity.HEU_Task GetTask(System.Guid taskGuid)
  RVA=0x0882F0E8  token=0x6000979  System.Void AddTask(HoudiniEngineUnity.HEU_Task task)
  RVA=0x0882F400  token=0x600097A  System.Void KillTask(HoudiniEngineUnity.HEU_Task task, System.Boolean bRemove)
  RVA=0x0882F4C0  token=0x600097B  System.Void KillTask(System.Guid taskGuid, System.Boolean bRemove)
  RVA=0x0882F53C  token=0x600097C  System.Void RemoveTask(HoudiniEngineUnity.HEU_Task task)
  RVA=0x0882F204  token=0x600097D  System.Void ExecuteTask(HoudiniEngineUnity.HEU_Task task)
  RVA=0x0882F1E0  token=0x600097E  System.Void CompleteTask(HoudiniEngineUnity.HEU_Task task, HoudiniEngineUnity.HEU_Task.TaskResult result)
  RVA=0x0882F3B0  token=0x600097F  System.Void InternalCompleteTask(HoudiniEngineUnity.HEU_Task task)
  RVA=0x0350B670  token=0x6000980  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferBase
TYPE:  class
TOKEN: 0x200010D
SIZE:  0x30
FIELDS:
  public            System.Int32                    _id  // 0x10
  public            System.String                   _name  // 0x18
  public            System.Boolean                  _bInstanced  // 0x20
  public            System.Boolean                  _bInstancer  // 0x21
  public            HoudiniEngineUnity.HEU_GeneratedOutput_generatedOutput  // 0x28
METHODS:
  RVA=0x0883F828  token=0x6000981  System.Void InitializeBuffer(System.Int32 id, System.String name, System.Boolean bInstanced, System.Boolean bInstancer)
  RVA=0x0350B670  token=0x6000982  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferMesh
TYPE:  class
TOKEN: 0x200010E
SIZE:  0x48
EXTENDS: HoudiniEngineUnity.HEU_LoadBufferBase
FIELDS:
  public            HoudiniEngineUnity.HEU_GenerateGeoCache_geoCache  // 0x30
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>_LODGroupMeshes  // 0x38
  public            System.Int32                    _defaultMaterialKey  // 0x40
  public            System.Boolean                  _bGenerateUVs  // 0x44
  public            System.Boolean                  _bGenerateTangents  // 0x45
  public            System.Boolean                  _bGenerateNormals  // 0x46
  public            System.Boolean                  _bPartInstanced  // 0x47
METHODS:
  RVA=0x0350B670  token=0x6000983  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferVolume
TYPE:  class
TOKEN: 0x200010F
SIZE:  0xA8
EXTENDS: HoudiniEngineUnity.HEU_LoadBufferBase
FIELDS:
  public            System.Int32                    _tileIndex  // 0x30
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolumeLayer>_splatLayers  // 0x38
  public            System.Int32                    _heightMapWidth  // 0x40
  public            System.Int32                    _heightMapHeight  // 0x44
  public            System.Single[,]                _heightMap  // 0x48
  public            System.Single[,,]               _splatMaps  // 0x50
  public            System.Single                   _terrainSizeX  // 0x58
  public            System.Single                   _terrainSizeY  // 0x5c
  public            System.Single                   _heightRange  // 0x60
  public            UnityEngine.Vector3             _position  // 0x64
  public            System.String                   _terrainDataPath  // 0x70
  public            System.String                   _terrainDataExportPath  // 0x78
  public            HoudiniEngineUnity.HEU_VolumeScatterTrees_scatterTrees  // 0x80
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype>_detailPrototypes  // 0x88
  public            System.Collections.Generic.List<System.Int32[,]>_detailMaps  // 0x90
  public            HoudiniEngineUnity.HEU_DetailProperties_detailProperties  // 0x98
  public            System.String                   _specifiedTerrainMaterialName  // 0xa0
METHODS:
  RVA=0x0883F88C  token=0x6000984  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferVolumeLayer
TYPE:  class
TOKEN: 0x2000110
SIZE:  0xD8
FIELDS:
  public            System.String                   _layerName  // 0x10
  public            System.Int32                    _partID  // 0x18
  public            System.Int32                    _heightMapWidth  // 0x1c
  public            System.Int32                    _heightMapHeight  // 0x20
  public            System.Single                   _strength  // 0x24
  public            System.String                   _diffuseTexturePath  // 0x28
  public            System.String                   _maskTexturePath  // 0x30
  public            System.Single                   _metallic  // 0x38
  public            System.String                   _normalTexturePath  // 0x40
  public            System.Single                   _normalScale  // 0x48
  public            System.Single                   _smoothness  // 0x4c
  public            UnityEngine.Color               _specularColor  // 0x50
  public            UnityEngine.Vector2             _tileSize  // 0x60
  public            UnityEngine.Vector2             _tileOffset  // 0x68
  public            System.Boolean                  _uiExpanded  // 0x70
  public            System.Int32                    _tile  // 0x74
  public            System.Single[]                 _normalizedHeights  // 0x78
  public            System.Single                   _minHeight  // 0x80
  public            System.Single                   _maxHeight  // 0x84
  public            System.Single                   _heightRange  // 0x88
  public            System.Single                   _terrainSizeX  // 0x8c
  public            System.Single                   _terrainSizeY  // 0x90
  public            UnityEngine.Vector3             _position  // 0x94
  public            UnityEngine.Vector3             _minBounds  // 0xa0
  public            UnityEngine.Vector3             _maxBounds  // 0xac
  public            UnityEngine.Vector3             _center  // 0xb8
  public            System.String                   _layerPath  // 0xc8
  public            System.Boolean                  _hasLayerAttributes  // 0xd0
  public            HoudiniEngineUnity.HFLayerType  _layerType  // 0xd4
METHODS:
  RVA=0x0883F854  token=0x6000985  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferInstancer
TYPE:  class
TOKEN: 0x2000111
SIZE:  0x58
EXTENDS: HoudiniEngineUnity.HEU_LoadBufferBase
FIELDS:
  public            HoudiniEngineUnity.HAPI_Transform[]_instanceTransforms  // 0x30
  public            System.String[]                 _instancePrefixes  // 0x38
  public            System.Int32[]                  _instanceNodeIDs  // 0x40
  public            System.String[]                 _assetPaths  // 0x48
  public            System.String[]                 _collisionAssetPaths  // 0x50
METHODS:
  RVA=0x0350B670  token=0x6000986  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ThreadedTask
TYPE:  class
TOKEN: 0x2000112
SIZE:  0x38
FIELDS:
  private           System.Boolean                  _isComplete  // 0x10
  private           System.Boolean                  _isActive  // 0x11
  private           System.Boolean                  _stopRequested  // 0x12
  private           System.Object                   _lockHandle  // 0x18
  private           System.Threading.Thread         _thread  // 0x20
  private           System.Threading.ThreadPriority _priority  // 0x28
  private           System.Boolean                  _isBackground  // 0x2c
  protected         System.String                   _name  // 0x30
PROPERTIES:
  TaskName  get=0x01003830
  IsComplete  get=0x088447DC  set=0x088449E0
  IsActive  get=0x08844730  set=0x08844934
  StopRequested  get=0x08844888  set=0x08844A8C
  Priority  get=0x03D4EB90  set=0x03D4EBA0
  IsBackground  get=0x03D4F1A0  set=0x03D4F1B0
METHODS:
  RVA=0x088444F4  token=0x6000987  System.Void Start()
  RVA=0x08844644  token=0x6000988  System.Void Stop()
  RVA=0x08844404  token=0x6000989  System.Void Abort()
  RVA=0x08844434  token=0x600098A  System.Void Reset()
  RVA=0x08844684  token=0x600098B  System.Void Update()
  RVA=0x0350B670  token=0x600098C  System.Void DoWork()
  RVA=0x0350B670  token=0x600098D  System.Void OnComplete()
  RVA=0x0350B670  token=0x600098E  System.Void OnStopped()
  RVA=0x0350B670  token=0x600098F  System.Void CleanUp()
  RVA=0x088444CC  token=0x6000990  System.Void Run()
  RVA=0x088446DC  token=0x600099C  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo
TYPE:  class
TOKEN: 0x2000113
SIZE:  0x78
EXTENDS: HoudiniEngineUnity.HEU_ThreadedTask
FIELDS:
  private           HoudiniEngineUnity.HEU_BaseSync _ownerSync  // 0x38
  private           HoudiniEngineUnity.HEU_SessionBase_session  // 0x40
  private           HoudiniEngineUnity.HEU_GenerateOptions_generateOptions  // 0x48
  protected         System.String                   _assetCachePath  // 0x50
  private           HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType_loadType  // 0x58
  private           System.String                   _filePath  // 0x60
  private           HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData_loadData  // 0x68
  private           HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback_loadCallback  // 0x70
METHODS:
  RVA=0x08844268  token=0x600099D  System.Void SetupLoad(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType loadType, System.Int32 cookNodeID, System.String name, System.String filePath)
  RVA=0x08844238  token=0x600099E  System.Void SetupLoadNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String name)
  RVA=0x08844208  token=0x600099F  System.Void SetupLoadFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String filePath)
  RVA=0x088441D4  token=0x60009A0  System.Void SetupLoadAsset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.String assetPath, System.String name)
  RVA=0x0519C3C8  token=0x60009A1  System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback loadCallback)
  RVA=0x08840A58  token=0x60009A2  System.Void DoWork()
  RVA=0x08840680  token=0x60009A3  System.Boolean CookNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 cookNodeID)
  RVA=0x08843CC4  token=0x60009A4  System.Boolean LoadObjectBuffers(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo)
  RVA=0x088439D4  token=0x60009A5  System.Boolean LoadNodeBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject)
  RVA=0x08840140  token=0x60009A6  System.Void BuildBufferIDsMap(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  RVA=0x088408F0  token=0x60009A7  System.Boolean DoFileLoad()
  RVA=0x088407F0  token=0x60009A8  System.Boolean DoAssetLoad()
  RVA=0x08843E98  token=0x60009A9  System.Boolean QueryParts(System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& curveParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& scatterInstancerParts)
  RVA=0x08843DA0  token=0x60009AA  System.Void OnComplete()
  RVA=0x08843E28  token=0x60009AB  System.Void OnStopped()
  RVA=0x08582664  token=0x60009AC  System.Void CleanUp()
  RVA=0x08840764  token=0x60009AD  System.String CreateLogString(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr)
  RVA=0x08840018  token=0x60009AE  System.Void AppendLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr)
  RVA=0x08843F58  token=0x60009AF  System.Void SetLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr)
  RVA=0x0884070C  token=0x60009B0  System.Boolean CreateFileNode(System.Int32& fileNodeID)
  RVA=0x08843524  token=0x60009B1  System.Int32 GetCookNodeID()
  RVA=0x08843540  token=0x60009B2  System.Int32 GetDisplayNodeID(System.Int32 objNodeID)
  RVA=0x08843F1C  token=0x60009B3  System.Boolean SetFileParm(System.Int32 fileNodeID, System.String filePath)
  RVA=0x088443B0  token=0x60009B4  System.Void Sleep()
  RVA=0x08841958  token=0x60009B5  System.Boolean GenerateTerrainBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> scatterInstancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume>& volumeBuffers)
  RVA=0x08843D18  token=0x60009B6  System.Void LoadStringFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String& strValue)
  RVA=0x08843684  token=0x60009B7  System.Void LoadFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue)
  RVA=0x08843774  token=0x60009B8  System.Void LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue)
  RVA=0x088438C4  token=0x60009B9  System.Void LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue)
  RVA=0x08840E98  token=0x60009BA  System.Boolean GenerateMeshBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> meshParts, System.Boolean bSplitPoints, System.Boolean bUseLODGroups, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh>& meshBuffers)
  RVA=0x08840AF8  token=0x60009BB  System.Boolean GenerateInstancerBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer>& instancerBuffers)
  RVA=0x08841538  token=0x60009BC  HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo)
  RVA=0x08841810  token=0x60009BD  HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo)
  RVA=0x0884355C  token=0x60009BE  HoudiniEngineUnity.HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(System.Int32 tileIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> buffers)
  RVA=0x08843678  token=0x60009BF  System.String GetValidAssetCacheFolderPath(System.String name)
  RVA=0x088443BC  token=0x60009C0  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ThreadManager
TYPE:  class
TOKEN: 0x200011A
SIZE:  0x28
FIELDS:
  private   static  HoudiniEngineUnity.HEU_ThreadManager_instance  // static @ 0x0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask>_tasks  // 0x10
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask>_pendingAdd  // 0x18
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask>_pendingRemove  // 0x20
PROPERTIES:
  Instance  get=0x0883FFE0
METHODS:
  RVA=0x0350B670  token=0x60009C8  System.Void CreateInstance()
  RVA=0x0883FAC8  token=0x60009C9  System.Void Finalize()
  RVA=0x0350B670  token=0x60009CA  System.Void Register()
  RVA=0x0350B670  token=0x60009CB  System.Void Unregister()
  RVA=0x0883FBB4  token=0x60009CC  System.Void Update()
  RVA=0x0883FA2C  token=0x60009CD  System.Void AddTask(HoudiniEngineUnity.HEU_ThreadedTask task)
  RVA=0x0883FB18  token=0x60009CE  System.Void RemoveTask(HoudiniEngineUnity.HEU_ThreadedTask task)
  RVA=0x0883FF04  token=0x60009CF  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CookLogs
TYPE:  class
TOKEN: 0x200011B
SIZE:  0x30
FIELDS:
  private   static  HoudiniEngineUnity.HEU_CookLogs _instance  // static @ 0x0
  private           System.Text.StringBuilder       _cookLogs  // 0x10
  private           System.Int32                    _currentCookLogCount  // 0x18
  private   static  System.Int32                    MAX_COOK_LOG_COUNT  // const
  private           System.String                   _lastLogStr  // 0x20
  private           System.Boolean                  _uniqueStrOnly  // 0x28
  public    static  System.Int64                    MaxLogSize  // const
PROPERTIES:
  Instance  get=0x0882FF04
METHODS:
  RVA=0x07ABAEF4  token=0x60009D1  System.String GetCookLogString()
  RVA=0x0882F954  token=0x60009D2  System.Void AppendCookLog(System.String logStr)
  RVA=0x0882FA70  token=0x60009D3  System.Void ClearCookLog()
  RVA=0x0882FB64  token=0x60009D4  System.String GetCookLogFilePath()
  RVA=0x0882FADC  token=0x60009D5  System.Void DeleteCookingFile()
  RVA=0x0882FC9C  token=0x60009D6  System.Void WriteToLogFile(System.String logStr, System.Boolean checkLastLogStr)
  RVA=0x0882FC14  token=0x60009D7  System.Int64 GetFileSizeOfLogFile()
  RVA=0x0882FE78  token=0x60009D8  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_EditorUtility
TYPE:  static class
TOKEN: 0x200011C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60009D9  System.Void MarkSceneDirty()
  RVA=0x0350B670  token=0x60009DA  System.Void SelectObject(UnityEngine.GameObject gameObject)
  RVA=0x0350B670  token=0x60009DB  System.Void SelectObjects(UnityEngine.GameObject[] gameObjects)
  RVA=0x04274B08  token=0x60009DC  UnityEngine.Vector3 GetSelectedObjectsMeanPosition()
  RVA=0x088307E8  token=0x60009DD  UnityEngine.Matrix4x4 GetSelectedObjectsMeanTransform()
  RVA=0x08830AF8  token=0x60009DE  UnityEngine.GameObject SaveAsPrefabAsset(System.String path, UnityEngine.GameObject go)
  RVA=0x0115F4C0  token=0x60009DF  System.Boolean PrefabIsAddedComponentOverride(UnityEngine.Component comp)
  RVA=0x0115F4C0  token=0x60009E0  System.Boolean IsEditorPlaying()
  RVA=0x08830AC0  token=0x60009E1  UnityEngine.GameObject ReplacePrefab(UnityEngine.GameObject go, UnityEngine.Object targetPrefab, HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions heuOptions)
  RVA=0x088309AC  token=0x60009E2  System.Boolean IsPrefabInstance(UnityEngine.GameObject go)
  RVA=0x08830974  token=0x60009E3  System.Boolean IsPrefabAsset(UnityEngine.GameObject go)
  RVA=0x0115F4C0  token=0x60009E4  System.Boolean IsEditingInPrefabMode(UnityEngine.GameObject obj)
  RVA=0x08830904  token=0x60009E5  System.Boolean IsDisconnectedPrefabInstance(UnityEngine.GameObject go)
  RVA=0x08830738  token=0x60009E6  UnityEngine.Object GetPrefabAsset(UnityEngine.GameObject go)
  RVA=0x08830700  token=0x60009E7  System.String GetPrefabAssetPath(UnityEngine.Object obj)
  RVA=0x088301CC  token=0x60009E8  System.Void DisconnectPrefabInstance(UnityEngine.GameObject instance)
  RVA=0x088308CC  token=0x60009E9  UnityEngine.Object InstantiatePrefab(UnityEngine.GameObject prefabOriginal)
  RVA=0x0883085C  token=0x60009EA  UnityEngine.GameObject InstantiateGameObject(UnityEngine.GameObject sourceGameObject, UnityEngine.Transform parentTransform, System.Boolean instantiateInWorldSpace, System.Boolean bRegisterUndo)
  RVA=-1  // generic def  token=0x60009EB  UnityEngine.Component AddComponent(UnityEngine.GameObject target, System.Boolean bRegisterUndo)
  RVA=0x0350B670  token=0x60009EC  System.Void UndoRecordObject(UnityEngine.Object objectToUndo, System.String name)
  RVA=0x0350B670  token=0x60009ED  System.Void UndoCollapseCurrentGroup()
  RVA=0x088300B8  token=0x60009EE  UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj)
  RVA=0x0883093C  token=0x60009EF  System.Boolean IsPersistant(UnityEngine.Object obj)
  RVA=0x08830824  token=0x60009F0  System.String GetUniqueNameForSibling(UnityEngine.Transform parentTransform, System.String name)
  RVA=0x088302C8  token=0x60009F1  System.Void DisplayProgressBar(System.String title, System.String info, System.Single progress)
  RVA=0x08830084  token=0x60009F2  System.Void ClearProgressBar()
  RVA=0x03D4E3A0  token=0x60009F3  System.Boolean IsEditorNotInPlayModeAndNotGoingToPlayMode()
  RVA=0x08830200  token=0x60009F4  System.Boolean DisplayDialog(System.String title, System.String message, System.String ok, System.String cancel)
  RVA=0x08830258  token=0x60009F5  System.Boolean DisplayErrorDialog(System.String title, System.String message, System.String ok, System.String cancel)
  RVA=0x0350B670  token=0x60009F6  System.Void RevealInFinder(System.String path)
  RVA=0x0350B670  token=0x60009F7  System.Void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj)
  RVA=0x0350B670  token=0x60009F8  System.Void SetStatic(UnityEngine.GameObject go, System.Boolean bStatic, System.Boolean bIncludeChildren)
  RVA=0x0350B670  token=0x60009F9  System.Void SetIsHidden(UnityEngine.GameObject go, System.Boolean isHidden, System.Boolean bIncludeChildren)
  RVA=0x01002730  token=0x60009FA  UnityEngine.GameObject[] GetSelectedObjects()
  RVA=0x08830770  token=0x60009FB  HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetSelectedAssetRoots()
  RVA=0x08830654  token=0x60009FC  HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetAllAssetRoots()
  RVA=0x088301B0  token=0x60009FD  System.Void CookSelected()
  RVA=0x088300F0  token=0x60009FE  System.Void CookAll()
  RVA=0x0883010C  token=0x60009FF  System.Void CookAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  RVA=0x08830AA4  token=0x6000A00  System.Void RebuildSelected()
  RVA=0x088309E4  token=0x6000A01  System.Void RebuildAll()
  RVA=0x08830A00  token=0x6000A02  System.Void RebuildAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  RVA=0x08830068  token=0x6000A03  System.Void BakeAndReplaceSelectedInScene()
  RVA=0x0882FF94  token=0x6000A04  System.Void BakeAndReplaceAllInScene()
  RVA=0x0882FFB0  token=0x6000A05  System.Void BakeAndReplaceAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  RVA=0x08830638  token=0x6000A06  System.Void ExportSelectedAssetsToGeoFiles()
  RVA=0x08830334  token=0x6000A07  System.Void ExportAllAssetsToGeoFiles()
  RVA=0x08830350  token=0x6000A08  System.Void ExportAssetsToGeoFiles(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  RVA=0x088302FC  token=0x6000A09  System.String EditorSaveFolderPanel(System.String title, System.String folder, System.String defaultName)
  RVA=0x0350B670  token=0x6000A0A  System.Void QuerySelectedMeshTopology()
  RVA=0x088306D4  token=0x6000A0B  System.String GetObjectParentFolder(UnityEngine.GameObject parentObject, System.Collections.Generic.HashSet<UnityEngine.Material> generatedMaterials)
  RVA=0x088306A8  token=0x6000A0C  System.String GetObjectParentFolderHelper(System.Int32 instanceID)
  RVA=0x0350B670  token=0x6000A0D  System.Void RepaintScene()
  RVA=0x0350B670  token=0x6000A0E  System.Void SetTextureToNormalMap(System.String filename)
  RVA=0x0232EB60  token=0x6000A0F  System.Boolean ReleasedMouse()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Extensions
TYPE:  static class
TOKEN: 0x200011E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000A10  System.Collections.Generic.List<R> Map(System.Collections.Generic.IEnumerable<T> self, System.Func<T,R> selector)
  RVA=-1  // generic def  token=0x6000A11  T Reduce(System.Collections.Generic.IEnumerable<T> self, System.Func<T,T,T> func)
  RVA=-1  // generic def  token=0x6000A12  System.Collections.Generic.List<T> Filter(System.Collections.Generic.IEnumerable<T> self, System.Func<T,System.Boolean> predicate)
  RVA=-1  // generic def  token=0x6000A13  System.Boolean IsValidIndex(System.Collections.Generic.List<T> self, System.Int32 index)
  RVA=-1  // generic def  token=0x6000A14  System.Boolean IsEquivalentList(System.Collections.Generic.List<T> self, System.Collections.Generic.List<T> other)
  RVA=0x08830B30  token=0x6000A15  System.Boolean ApproximatelyEquals(UnityEngine.Quaternion quatA, UnityEngine.Quaternion value)
  RVA=-1  // generic def  token=0x6000A16  System.Collections.Generic.List<U> ConvertList(System.Collections.Generic.List<T> self)
  RVA=-1  // generic def  token=0x6000A17  System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> ConvertListToEquivable(System.Collections.Generic.List<T> self)
  RVA=-1  // generic def  token=0x6000A18  HoudiniEngineUnity.IEquivable<T>[] ConvertArrayToEquivable(T[] self)
  RVA=0x05717BC8  token=0x6000A19  System.Boolean ApproximatelyEquals(System.Single self, System.Single other, System.Single epsilon)
  RVA=0x08830B7C  token=0x6000A1A  System.Byte[] AsByteArray(System.String self)
  RVA=0x08830BE8  token=0x6000A1B  System.String AsString(System.Byte[] buffer)
  RVA=0x03D6D8A0  token=0x6000A1C  UnityEngine.Vector3 SwapXAndY(UnityEngine.Vector3 self)
  RVA=0x03D6D8D0  token=0x6000A1D  UnityEngine.Vector3 SwapXAndZ(UnityEngine.Vector3 self)
  RVA=0x03D6D8F0  token=0x6000A1E  UnityEngine.Vector3 SwapYAndZ(UnityEngine.Vector3 self)
  RVA=0x088092B0  token=0x6000A1F  UnityEngine.Vector3 DecomposeToPosition(UnityEngine.Matrix4x4 self)
  RVA=0x08830C4C  token=0x6000A20  UnityEngine.Quaternion DecomposeToRotation(UnityEngine.Matrix4x4 self)
  RVA=0x08830D14  token=0x6000A21  UnityEngine.Vector3 DecomposeToScale(UnityEngine.Matrix4x4 self)
END_CLASS

CLASS: HoudiniEngineUnity.ArrayExtensions
TYPE:  static class
TOKEN: 0x200011F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000A22  System.Void Init(T[] array, T defaultValue)
  RVA=-1  // generic def  token=0x6000A23  System.Void Init(System.Collections.Generic.List<T> array, T defaultValue)
  RVA=-1  // generic def  token=0x6000A24  System.Void CopyToWithResize(T[] srcArray, T[]& destArray)
  RVA=-1  // generic def  token=0x6000A25  System.Boolean IsEquivalentArray(T[] arr, T[] other)
  RVA=-1  // generic def  token=0x6000A26  System.Boolean IsNull(T[] arr)
END_CLASS

CLASS: HoudiniEngineUnity.DictionaryExtensions
TYPE:  static class
TOKEN: 0x2000120
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000A27  System.Void AddOrSet(System.Collections.Generic.Dictionary<T,U> dict, T key, U value)
END_CLASS

CLASS: HoudiniEngineUnity.TransformData
TYPE:  sealed struct
TOKEN: 0x2000121
SIZE:  0x60
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Quaternion          rotation  // 0x1c
  public            UnityEngine.Vector3             localPosition  // 0x2c
  public            UnityEngine.Vector3             localScale  // 0x38
  public            UnityEngine.Quaternion          localRotation  // 0x44
  public            UnityEngine.Transform           parent  // 0x58
METHODS:
  RVA=0x08844CFC  token=0x6000A28  System.Void .ctor(UnityEngine.Transform other)
  RVA=0x08844C58  token=0x6000A29  System.Void CopyTo(UnityEngine.Transform other, System.Boolean copyParent)
  RVA=0x08844BB0  token=0x6000A2A  System.Void CopyToLocal(UnityEngine.Transform other, System.Boolean copyParent)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeneralUtility
TYPE:  class
TOKEN: 0x2000122
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000A2B  System.Boolean GetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count)
  RVA=-1  // generic def  token=0x6000A2C  System.Boolean GetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count)
  RVA=-1  // generic def  token=0x6000A2D  System.Boolean GetArray3Arg(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func, T[] data, System.Int32 start, System.Int32 count)
  RVA=-1  // generic def  token=0x6000A2E  System.Boolean GetArray(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func3, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize)
  RVA=-1  // generic def  token=0x6000A2F  System.Boolean SetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count)
  RVA=-1  // generic def  token=0x6000A30  System.Boolean SetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count)
  RVA=-1  // generic def  token=0x6000A31  System.Boolean SetArray(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize)
  RVA=-1  // generic def  token=0x6000A32  System.Boolean DoArrayElementsMatch(T[] array1, T[] array2)
  RVA=-1  // generic def  token=0x6000A33  System.Boolean DoArrayElementsMatch(T[] array1, System.Int32 startOffset1, T[] array2, System.Int32 startOffset2, System.Int32 length)
  RVA=-1  // generic def  token=0x6000A34  System.Boolean GetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc, System.Int32 count)
  RVA=-1  // generic def  token=0x6000A35  System.Boolean GetAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc)
  RVA=-1  // generic def  token=0x6000A36  System.Boolean GetAttributeStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc)
  RVA=0x08833540  token=0x6000A37  System.Void GetAttributeStringDataHelper(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, System.Int32[]& data)
  RVA=0x08833590  token=0x6000A38  System.String[] GetAttributeStringData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  RVA=0x08833274  token=0x6000A39  System.String[] GetAttributeDataAsString(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  RVA=-1  // generic def  token=0x6000A3A  System.Boolean SetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc, System.Int32 count, System.Int32 start)
  RVA=-1  // generic def  token=0x6000A3B  System.Boolean SetAttribute(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc)
  RVA=0x088076A8  token=0x6000A3C  System.Boolean CheckAttributeExists(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeOwner attribOwner)
  RVA=0x08833408  token=0x6000A3D  System.Boolean GetAttributeInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo)
  RVA=0x088349C0  token=0x6000A3E  System.Boolean HasValidInstanceAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName)
  RVA=0x08835AF4  token=0x6000A3F  System.Void UpdateGeneratedAttributeStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject go)
  RVA=0x08831EB0  token=0x6000A40  HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttributeHelper(System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  RVA=0x08831F30  token=0x6000A41  HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  RVA=0x08831D58  token=0x6000A42  System.Void CopyWorldTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest)
  RVA=0x08830DCC  token=0x6000A43  System.Void ApplyTransformTo(UnityEngine.Transform src, UnityEngine.Transform target)
  RVA=0x08831C9C  token=0x6000A44  System.Void CopyLocalTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest)
  RVA=0x08833DD4  token=0x6000A45  System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjects(UnityEngine.GameObject parentGO)
  RVA=0x08833B6C  token=0x6000A46  System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjectsWithNamePattern(UnityEngine.GameObject parentGO, System.String pattern, System.Boolean bExclude)
  RVA=0x08834238  token=0x6000A47  System.Collections.Generic.List<UnityEngine.GameObject> GetInstanceChildObjects(UnityEngine.GameObject parentGO)
  RVA=0x088344E4  token=0x6000A48  System.Collections.Generic.List<UnityEngine.GameObject> GetNonInstanceChildObjects(UnityEngine.GameObject parentGO)
  RVA=0x088340BC  token=0x6000A49  UnityEngine.GameObject GetGameObjectByName(System.Collections.Generic.List<UnityEngine.GameObject> goList, System.String name)
  RVA=0x08833FCC  token=0x6000A4A  UnityEngine.GameObject GetGameObjectByNameInProjectOnly(System.String name)
  RVA=0x088349EC  token=0x6000A4B  System.Boolean IsGameObjectInProject(UnityEngine.GameObject go)
  RVA=0x08834084  token=0x6000A4C  UnityEngine.GameObject GetGameObjectByNameInScene(System.String name)
  RVA=0x08834200  token=0x6000A4D  HoudiniEngineUnity.HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(System.String name)
  RVA=-1  // generic def  token=0x6000A4E  T GetOrCreateComponent(UnityEngine.GameObject gameObject)
  RVA=0x088324A4  token=0x6000A4F  System.Void DestroyGeneratedComponents(UnityEngine.GameObject gameObject)
  RVA=0x0883267C  token=0x6000A50  System.Void DestroyGeneratedMeshComponents(UnityEngine.GameObject gameObject)
  RVA=0x08832B6C  token=0x6000A51  System.Void DestroyTerrainComponents(UnityEngine.GameObject gameObject)
  RVA=-1  // generic def  token=0x6000A52  System.Void DestroyComponent(UnityEngine.GameObject gameObject)
  RVA=0x088328F0  token=0x6000A53  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean bAllowDestroyingAssets, System.Boolean bRegisterUndo)
  RVA=0x088323D8  token=0x6000A54  System.Void DestroyBakedGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy)
  RVA=0x088322CC  token=0x6000A55  System.Void DestroyBakedGameObjectsWithEndName(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy, System.String endName)
  RVA=0x08832924  token=0x6000A56  System.Void DestroyLODGroup(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources)
  RVA=0x08834278  token=0x6000A57  System.Collections.Generic.List<UnityEngine.Transform> GetLODTransforms(UnityEngine.GameObject targetGO)
  RVA=0x08835694  token=0x6000A58  System.Void SetLODTransformValues(UnityEngine.GameObject targetGO, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> transformData)
  RVA=0x08832708  token=0x6000A59  System.Void DestroyGeneratedMeshMaterialsLODGroups(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources)
  RVA=0x08832580  token=0x6000A5A  System.Void DestroyGeneratedMaterial(UnityEngine.Material material)
  RVA=0x08832A90  token=0x6000A5B  System.Void DestroyMeshCollider(UnityEngine.MeshCollider meshCollider, System.Boolean bDontDeletePersistantResources)
  RVA=0x088355E4  token=0x6000A5C  System.Void SetGameObjectRenderVisiblity(UnityEngine.GameObject gameObject, System.Boolean bVisible)
  RVA=0x0883547C  token=0x6000A5D  System.Void SetGameObjectChildrenRenderVisibility(UnityEngine.GameObject gameObject, System.Boolean bVisible)
  RVA=0x08835534  token=0x6000A5E  System.Void SetGameObjectColliderState(UnityEngine.GameObject gameObject, System.Boolean bEnabled)
  RVA=0x088353C4  token=0x6000A5F  System.Void SetGameObjectChildrenColliderState(UnityEngine.GameObject gameObject, System.Boolean bVisible)
  RVA=0x088318D4  token=0x6000A60  System.String ColorToString(UnityEngine.Color c)
  RVA=0x088359FC  token=0x6000A61  UnityEngine.Color StringToColor(System.String colorString)
  RVA=0x0232EB60  token=0x6000A62  System.Boolean DoesUnityTagExist(System.String tagName)
  RVA=0x088357D0  token=0x6000A63  System.Void SetLayer(UnityEngine.GameObject rootGO, System.Int32 layer, System.Boolean bIncludeChildren)
  RVA=0x08835938  token=0x6000A64  System.Void SetTag(UnityEngine.GameObject rootGO, System.String tag, System.Boolean bIncludeChildren)
  RVA=0x08831BA0  token=0x6000A65  System.Void CopyFlags(UnityEngine.GameObject srcGO, UnityEngine.GameObject dstGO, System.Boolean bIncludeChildren)
  RVA=0x08834AC8  token=0x6000A66  System.Boolean IsMouseWithinSceneView(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition)
  RVA=0x08834A7C  token=0x6000A67  System.Boolean IsMouseOverRect(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition, UnityEngine.Rect& rect)
  RVA=0x08834838  token=0x6000A68  System.Type GetSystemTypeByName(System.String typeName)
  RVA=0x088310C8  token=0x6000A69  System.Void AssignUnityTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject)
  RVA=0x08830EE0  token=0x6000A6A  System.Void AssignUnityLayer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject)
  RVA=0x08834E4C  token=0x6000A6B  System.Void MakeStaticIfHasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject)
  RVA=0x08834870  token=0x6000A6C  System.String GetUnityScriptAttributeValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x08833934  token=0x6000A6D  System.String GetAttributeStringValueSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner)
  RVA=0x08833648  token=0x6000A6E  System.String GetAttributeStringValueSingleStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner)
  RVA=0x088332F0  token=0x6000A6F  System.Boolean GetAttributeFloatSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& value)
  RVA=0x08833428  token=0x6000A70  System.Boolean GetAttributeIntSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32& value)
  RVA=0x088330FC  token=0x6000A71  System.Boolean GetAttributeColorSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& value)
  RVA=0x0883499C  token=0x6000A72  System.Boolean HasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner)
  RVA=0x08831360  token=0x6000A73  System.Void AttachScriptWithInvokeFunction(System.String scriptSet, UnityEngine.GameObject gameObject)
  RVA=0x088349F4  token=0x6000A74  System.Boolean IsInCameraView(UnityEngine.Camera camera, UnityEngine.Vector3 point)
  RVA=0x08832CB0  token=0x6000A75  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> FindOrGenerateHandles(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Int32 assetID, System.String assetName, HoudiniEngineUnity.HEU_Parameters parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> currentHandles)
  RVA=0x0350B670  token=0x6000A76  System.Void CopyComponents(UnityEngine.GameObject srcGO, UnityEngine.GameObject destGO)
  RVA=0x08834B38  token=0x6000A77  UnityEngine.Texture LoadTextureFromFile(System.String filePath)
  RVA=0x08834F70  token=0x6000A78  UnityEngine.Texture2D MakeTexture(System.Int32 width, System.Int32 height, UnityEngine.Color color)
  RVA=0x0883532C  token=0x6000A79  System.String ReplaceFirstOccurrence(System.String srcStr, System.String searchStr, System.String replaceStr)
  RVA=0x08835894  token=0x6000A7A  System.Void SetParentWithCleanTransform(UnityEngine.Transform parentTransform, UnityEngine.Transform childTransform)
  RVA=0x08831C10  token=0x6000A7B  System.Void CopyHAPITransform(HoudiniEngineUnity.HAPI_Transform& src, HoudiniEngineUnity.HAPI_Transform& dest)
  RVA=0x088343B8  token=0x6000A7C  System.String GetMaterialAttributeValueFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x08835200  token=0x6000A7D  System.Void ReplaceColliderMeshFromMeshFilter(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO)
  RVA=0x088350E0  token=0x6000A7E  System.Void ReplaceColliderMeshFromMeshCollider(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO)
  RVA=0x0883187C  token=0x6000A7F  System.Single BiLerpf(System.Single p00, System.Single p10, System.Single p01, System.Single p11, System.Single fracX, System.Single fracY)
  RVA=0x03D6D920  token=0x6000A80  System.Single Fractionalf(System.Single value)
  RVA=0x08834CE4  token=0x6000A81  System.String LongestCommonPrefix(System.Collections.Generic.List<System.String> list)
  RVA=0x088347DC  token=0x6000A82  System.String GetRawOperatorName(System.String assetOpName)
  RVA=0x08834524  token=0x6000A83  UnityEngine.GameObject GetPrefabFromPath(System.String path)
  RVA=0x08831A70  token=0x6000A84  System.Void ComposeNChildren(UnityEngine.GameObject parent, System.Int32 n, System.Collections.Generic.List<UnityEngine.GameObject>& childGameObjects, System.Boolean destroyIfExists)
  RVA=0x088323E4  token=0x6000A85  System.Void DestroyChildWithName(UnityEngine.Transform parent, System.String name)
  RVA=0x08832170  token=0x6000A86  System.Void DestroyAutoGeneratedChildren(UnityEngine.GameObject parent)
  RVA=0x08831E14  token=0x6000A87  UnityEngine.GameObject CreateNewGameObject(System.String name)
  RVA=0x08835070  token=0x6000A88  System.Void RenameGameObject(UnityEngine.GameObject obj, System.String name)
  RVA=0x0350B670  token=0x6000A89  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.ReverseCompare
TYPE:  class
TOKEN: 0x2000128
SIZE:  0x10
IMPLEMENTS: System.Collections.IComparer
FIELDS:
METHODS:
  RVA=0x08844B38  token=0x6000A9E  System.Int32 Compare(System.Object x, System.Object y)
  RVA=0x0350B670  token=0x6000A9F  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GenerateGeoCache
TYPE:  class
TOKEN: 0x2000129
SIZE:  0x2B8
FIELDS:
  private           System.Int32                    <AssetID>k__BackingField  // 0x10
  public            HoudiniEngineUnity.HAPI_GeoInfo _geoInfo  // 0x14
  public            HoudiniEngineUnity.HAPI_PartInfo_partInfo  // 0x38
  public            System.String                   _partName  // 0x68
  public            System.Int32[]                  _vertexList  // 0x70
  public            System.Int32[]                  _faceCounts  // 0x78
  public            System.Int32[]                  _houdiniMaterialIDs  // 0x80
  public            System.Boolean                  _singleFaceUnityMaterial  // 0x88
  public            System.Boolean                  _singleFaceHoudiniMaterial  // 0x89
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_UnityMaterialInfo>_unityMaterialInfos  // 0x90
  public            HoudiniEngineUnity.HAPI_AttributeInfo_unityMaterialAttrInfo  // 0x98
  public            System.Int32[]                  _unityMaterialAttrName  // 0xc0
  public            System.Collections.Generic.Dictionary<System.Int32,System.String>_unityMaterialAttrStringsMap  // 0xc8
  public            HoudiniEngineUnity.HAPI_AttributeInfo_substanceMaterialAttrNameInfo  // 0xd0
  public            System.Int32[]                  _substanceMaterialAttrName  // 0xf8
  public            System.Collections.Generic.Dictionary<System.Int32,System.String>_substanceMaterialAttrStringsMap  // 0x100
  public            HoudiniEngineUnity.HAPI_AttributeInfo_substanceMaterialAttrIndexInfo  // 0x108
  public            System.Int32[]                  _substanceMaterialAttrIndex  // 0x130
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData>_inUseMaterials  // 0x138
  public            HoudiniEngineUnity.HAPI_AttributeInfo_posAttrInfo  // 0x140
  public            HoudiniEngineUnity.HAPI_AttributeInfo[]_uvsAttrInfo  // 0x168
  public            HoudiniEngineUnity.HAPI_AttributeInfo_normalAttrInfo  // 0x170
  public            HoudiniEngineUnity.HAPI_AttributeInfo_colorAttrInfo  // 0x198
  public            HoudiniEngineUnity.HAPI_AttributeInfo_alphaAttrInfo  // 0x1c0
  public            HoudiniEngineUnity.HAPI_AttributeInfo_tangentAttrInfo  // 0x1e8
  public            System.Single[]                 _posAttr  // 0x210
  public            System.Single[][]               _uvsAttr  // 0x218
  public            System.Single[]                 _normalAttr  // 0x220
  public            System.Single[]                 _colorAttr  // 0x228
  public            System.Single[]                 _alphaAttr  // 0x230
  public            System.Single[]                 _tangentAttr  // 0x238
  public            System.String[]                 _groups  // 0x240
  public            System.Boolean                  _hasGroupGeometry  // 0x248
  public            System.Collections.Generic.Dictionary<System.String,System.Int32[]>_groupSplitVertexIndices  // 0x250
  public            System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>>_groupSplitFaceIndices  // 0x258
  public            System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>>_groupVertexOffsets  // 0x260
  public            System.Int32[]                  _allCollisionVertexList  // 0x268
  public            System.Int32[]                  _allCollisionFaceIndices  // 0x270
  public            System.Single                   _normalCosineThreshold  // 0x278
  public            System.Boolean                  _hasLODGroups  // 0x27c
  public            System.Single[]                 _LODTransitionValues  // 0x280
  public            System.Boolean                  _isMeshReadWrite  // 0x288
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo>_colliderInfos  // 0x290
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData>_materialCache  // 0x298
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData>_materialIDToDataMap  // 0x2a0
  public            System.String                   _assetCacheFolderPath  // 0x2a8
  public            HoudiniEngineUnity.HEU_MeshIndexFormat_meshIndexFormat  // 0x2b0
PROPERTIES:
  GeoID  get=0x03D4EBB0
  PartID  get=0x03D4EC30
  AssetID  get=0x03D4E340  set=0x010410F0
METHODS:
  RVA=0x0883D334  token=0x6000AA4  HoudiniEngineUnity.HEU_GenerateGeoCache GetPopulatedGeoCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 geoID, System.Int32 partID, System.Boolean bUseLODGroups, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  RVA=0x0883E61C  token=0x6000AA5  System.Void PopulateUnityMaterialData(HoudiniEngineUnity.HEU_SessionBase session)
  RVA=0x0883D1B8  token=0x6000AA6  System.Int32 GetMaterialKeyFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 attributeIndex, System.String& unityMaterialName, System.String& substanceName, System.Int32& substanceIndex)
  RVA=0x0883657C  token=0x6000AA7  System.Void CreateMaterialInfoEntryFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 materialAttributeIndex)
  RVA=0x0883D770  token=0x6000AA8  System.Boolean PopulateGeometryData(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bUseLODGroups)
  RVA=0x0883D690  token=0x6000AA9  System.Void ParseLODTransitionAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Single[]& LODTransitionValues)
  RVA=0x0883F47C  token=0x6000AAA  System.Void UpdateColliders(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  RVA=0x0883EE28  token=0x6000AAB  System.Void UpdateCollider(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData, HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo colliderInfo)
  RVA=0x0883CE7C  token=0x6000AAC  System.Void GetFinalMaterialsFromComparingNewWithPrevious(UnityEngine.GameObject gameObject, UnityEngine.Material[] previousMaterials, UnityEngine.Material[] newMaterials, UnityEngine.Material[]& finalMaterials)
  RVA=0x0883CC6C  token=0x6000AAD  System.Boolean GenerateMeshFromSingleGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced)
  RVA=0x0883AA04  token=0x6000AAE  System.Boolean GenerateLODMeshesFromGeoGroups(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup> GeoGroupMeshes, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced)
  RVA=0x0883B3FC  token=0x6000AAF  System.Boolean GenerateMeshFromGeoGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced, UnityEngine.Mesh& newMesh, UnityEngine.Material[]& newMaterials)
  RVA=0x08836004  token=0x6000AB0  UnityEngine.Mesh CombineQuadMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> subMeshIndices, System.Boolean bGenerateNormals)
  RVA=0x08835D90  token=0x6000AB1  UnityEngine.Mesh CombineMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> submeshIndices, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat)
  RVA=0x08836688  token=0x6000AB2  UnityEngine.Mesh CreateMeshFromMeshData(HoudiniEngineUnity.HEU_MeshData submesh, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat)
  RVA=0x0883EB68  token=0x6000AB3  System.Void TransferRegularAttributesToVertices(System.Int32[] groupVertexList, System.Int32[] allFaceCounts, System.Collections.Generic.List<System.Int32> groupFaces, System.Collections.Generic.List<System.Int32> groupVertexOffset, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo, System.Single[] inData, System.Single[]& outData)
  RVA=0x08838530  token=0x6000AB4  System.Boolean GenerateGeoGroupUsingGeoCacheVertices(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey)
  RVA=0x08836918  token=0x6000AB5  System.Boolean GenerateGeoGroupUsingGeoCachePoints(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey)
  RVA=0x0883D3EC  token=0x6000AB6  System.Void GetSubmeshIDForFace(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 faceMaterialID, System.Int32 groupFace, System.Int32 vertexFaceIndex, System.Int32[] groupVertexList, System.Int32 defaultMaterialKey, System.Int32& submeshID, System.Int32& singleFaceUnityMaterialKey, System.Int32& singleFaceHoudiniMaterialKey)
  RVA=0x08835C5C  token=0x6000AB7  UnityEngine.MeshTopology CalculateGroupMeshTopology(System.Collections.Generic.List<System.Int32> groupFaces, System.Int32[] allFaceCounts)
  RVA=0x0883F5BC  token=0x6000AB8  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeoGroup
TYPE:  class
TOKEN: 0x200012D
SIZE:  0x28
IMPLEMENTS: System.IComparable`1
FIELDS:
  public            System.String                   _groupName  // 0x10
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData>_subMeshesMap  // 0x18
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VertexEntry>[]_sharedNormalIndices  // 0x20
METHODS:
  RVA=0x08844DC4  token=0x6000ABE  System.Int32 CompareTo(HoudiniEngineUnity.HEU_GeoGroup other)
  RVA=0x08844DFC  token=0x6000ABF  System.Void SetupNormalIndices(System.Int32 indicesCount)
  RVA=0x08844EF0  token=0x6000AC0  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VertexEntry
TYPE:  class
TOKEN: 0x200012E
SIZE:  0x20
FIELDS:
  public            System.Int32                    _meshKey  // 0x10
  public            System.Int32                    _vertexIndex  // 0x14
  public            System.Int32                    _normalIndex  // 0x18
METHODS:
  RVA=0x03D51130  token=0x6000AC1  System.Void .ctor(System.Int32 meshKey, System.Int32 vertexIndex, System.Int32 normalIndex)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeometryUtility
TYPE:  static class
TOKEN: 0x200012F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088464A0  token=0x6000AC2  UnityEngine.Vector2[] GeneratePerTriangle(UnityEngine.Mesh meshSrc)
  RVA=0x088464D8  token=0x6000AC3  System.Void GenerateSecondaryUVSet(UnityEngine.Mesh meshsrc)
  RVA=0x08844F68  token=0x6000AC4  System.Void CalculateMeshTangents(UnityEngine.Mesh mesh)
  RVA=0x0884570C  token=0x6000AC5  UnityEngine.Mesh GenerateCubeMeshFromPoints(UnityEngine.Vector3[] points, UnityEngine.Color[] pointsColor, System.Single size)
  RVA=0x0884650C  token=0x6000AC6  System.String GetInstanceOutputName(System.String partName, System.String[] userPrefix, System.Int32 index)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputData
TYPE:  class
TOKEN: 0x2000130
SIZE:  0x18
FIELDS:
  public            UnityEngine.GameObject          _inputObject  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000AC7  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterface
TYPE:  abstract class
TOKEN: 0x2000131
SIZE:  0x18
FIELDS:
  public    static  System.Int32                    DEFAULT_PRIORITY  // const
  protected         System.Int32                    _priority  // 0x10
PROPERTIES:
  Priority  get=0x03D4E340
METHODS:
  RVA=0x010410F0  token=0x6000AC9  System.Void .ctor(System.Int32 priority)
  RVA=0x0884BEA4  token=0x6000ACA  System.Void RegisterInterface()
  RVA=-1  // abstract  token=0x6000ACB  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  RVA=-1  // abstract  token=0x6000ACC  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceMeshSettings
TYPE:  class
TOKEN: 0x2000132
SIZE:  0x18
FIELDS:
  private           System.Boolean                  _exportColliders  // 0x10
PROPERTIES:
  ExportColliders  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=0x0350B670  token=0x6000ACF  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceMesh
TYPE:  class
TOKEN: 0x2000133
SIZE:  0x20
EXTENDS: HoudiniEngineUnity.HEU_InputInterface
FIELDS:
  private           HoudiniEngineUnity.HEU_InputInterfaceMeshSettingssettings  // 0x18
METHODS:
  RVA=0x03D6D950  token=0x6000AD0  System.Void .ctor()
  RVA=0x022C3A90  token=0x6000AD1  System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceMeshSettings settings)
  RVA=0x08846708  token=0x6000AD2  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
  RVA=0x0884727C  token=0x6000AD3  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  RVA=0x088471F8  token=0x6000AD4  System.Void GetUVsFromMesh(UnityEngine.Mesh mesh, UnityEngine.Vector2[] srcUVs, System.Collections.Generic.List<UnityEngine.Vector3> destUVs, System.Int32 index)
  RVA=0x0884805C  token=0x6000AD5  System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData)
  RVA=0x08847B28  token=0x6000AD6  System.Boolean UploadColliderData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 mergeNodeID, HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes inputData, System.Int32 parentNodeId)
  RVA=0x08847398  token=0x6000AD7  System.Boolean UploadBoxColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.BoxCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  RVA=0x08849768  token=0x6000AD8  System.Boolean UploadSphereColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.SphereCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  RVA=0x0884750C  token=0x6000AD9  System.Boolean UploadCapsuleColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.CapsuleCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  RVA=0x08849484  token=0x6000ADA  System.Boolean UploadMeshColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.MeshCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  RVA=0x08847008  token=0x6000ADB  System.String GetColliderGroupBaseName(UnityEngine.Collider collider, System.Boolean bIsConvex, System.Boolean bIsSimple, System.Boolean bIsRendered)
  RVA=0x08846694  token=0x6000ADC  System.Boolean CreateInputNodeForCollider(HoudiniEngineUnity.HEU_SessionBase session, System.Int32& outNodeID, System.Int32 parentNodeId, System.Int32 colliderIndex, System.String colliderName, System.Single[] colliderVertices, System.Int32[] colliderIndices)
  RVA=0x08846D30  token=0x6000ADD  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes GenerateMeshDatasFromGameObject(UnityEngine.GameObject inputObject, System.Boolean bExportColliders)
  RVA=0x08846848  token=0x6000ADE  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh CreateSingleMeshData(UnityEngine.GameObject meshGameObject, System.Boolean bExportColliders)
  RVA=0x088470F8  token=0x6000ADF  UnityEngine.Mesh GetMeshFromObject(UnityEngine.GameObject meshGameObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceTerrain
TYPE:  class
TOKEN: 0x2000138
SIZE:  0x18
EXTENDS: HoudiniEngineUnity.HEU_InputInterface
FIELDS:
METHODS:
  RVA=0x03D6D950  token=0x6000AE3  System.Void .ctor()
  RVA=0x08849958  token=0x6000AE4  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
  RVA=0x08849FA4  token=0x6000AE5  System.Boolean SetMaskLayer(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo)
  RVA=0x08849EA4  token=0x6000AE6  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  RVA=0x088498E0  token=0x6000AE7  System.Boolean CreateHeightFieldInputNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt)
  RVA=0x0884A7E8  token=0x6000AE8  System.Boolean UploadHeightValuesWithTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo)
  RVA=0x0884A2F4  token=0x6000AE9  System.Boolean UploadAlphaMaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo, System.Boolean& bMaskSet)
  RVA=0x08849F3C  token=0x6000AEA  System.Boolean SetHeightFieldData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 volumeNodeID, System.Int32 partID, System.Single[] heightValues, System.String heightFieldName, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo)
  RVA=0x0884A0A8  token=0x6000AEB  System.Boolean SetTerrainDataAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData)
  RVA=0x0884A12C  token=0x6000AEC  System.Boolean SetTerrainLayerAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer)
  RVA=0x0884A1D0  token=0x6000AED  System.Void SetTreePrototypes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData)
  RVA=0x0884A1B0  token=0x6000AEE  System.Void SetTreeInstances(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData)
  RVA=0x08849AD4  token=0x6000AEF  HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain GenerateTerrainDataFromGameObject(UnityEngine.GameObject inputObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings
TYPE:  class
TOKEN: 0x200013A
SIZE:  0x18
FIELDS:
  public            System.Boolean                  _createGroupsForTiles  // 0x10
  public            System.Boolean                  _exportUnusedTiles  // 0x11
  public            System.Boolean                  _applyTileColor  // 0x12
  public            System.Boolean                  _applyTilemapOrientation  // 0x13
METHODS:
  RVA=0x03D6D960  token=0x6000AF1  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceTilemap
TYPE:  class
TOKEN: 0x200013B
SIZE:  0x20
EXTENDS: HoudiniEngineUnity.HEU_InputInterface
FIELDS:
  private           HoudiniEngineUnity.HEU_InputInterfaceTilemapSettingssettings  // 0x18
METHODS:
  RVA=0x03D6D950  token=0x6000AF2  System.Void .ctor()
  RVA=0x0884AA78  token=0x6000AF3  System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings settings)
  RVA=0x0884A8D4  token=0x6000AF4  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
  RVA=0x0884AAE4  token=0x6000AF5  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  RVA=0x0884AB78  token=0x6000AF6  System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData)
  RVA=0x0884A9AC  token=0x6000AF7  HoudiniEngineUnity.HEU_InputInterfaceTilemap.HEU_InputDataTilemap GenerateTilemapDataFromGameObject(UnityEngine.GameObject inputObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputMeshUtility
TYPE:  static class
TOKEN: 0x200013D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0884C040  token=0x6000AF9  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem)
  RVA=0x0884C3CC  token=0x6000AFA  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x0884C524  token=0x6000AFB  System.Boolean SetMeshVertexAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem)
  RVA=0x0884C678  token=0x6000AFC  System.Boolean SetMeshVertexFloatAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x0884C7CC  token=0x6000AFD  System.Boolean UploadMeshIntoHoudiniNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetNodeID, System.Int32 objectID, System.Int32 geoID, UnityEngine.Mesh& mesh)
  RVA=0x0884C198  token=0x6000AFE  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3Int[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x0884C2E8  token=0x6000AFF  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  RVA=0x0884BEF0  token=0x6000B00  System.Boolean SetMeshDetailAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3 data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputUtility
TYPE:  static class
TOKEN: 0x200013E
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterface>_inputInterfaces  // static @ 0x0
METHODS:
  RVA=0x0884CD4C  token=0x6000B01  System.Int32 GetHighestPriority()
  RVA=0x0884D0F0  token=0x6000B02  System.Void RegisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface)
  RVA=0x0884D2B0  token=0x6000B03  System.Void UnregisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface)
  RVA=0x0884CDF0  token=0x6000B04  HoudiniEngineUnity.HEU_InputInterface GetInputInterfaceByType(System.Type type)
  RVA=0x0884CFE8  token=0x6000B05  HoudiniEngineUnity.HEU_InputInterface GetInputInterface(UnityEngine.GameObject inputObject)
  RVA=0x0884CF1C  token=0x6000B06  HoudiniEngineUnity.HEU_InputInterface GetInputInterface(HoudiniEngineUnity.HEU_InputObjectInfo inputObjectInfo)
  RVA=0x0884CAB0  token=0x6000B07  System.Boolean CreateInputNodeWithMultiObjects(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo>& inputObjects, System.Collections.Generic.List<System.Int32>& inputObjectsConnectedAssetIDs, HoudiniEngineUnity.HEU_InputNode inputNode)
  RVA=0x0884C9F4  token=0x6000B08  System.Boolean CreateInputNodeWithMultiAssets(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo>& inputAssetInfos, System.Boolean bKeepWorldTransform, System.Int32 mergeParentID)
  RVA=0x0884D320  token=0x6000B09  System.Boolean UploadInputObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputObjectInfo inputObject, System.Int32 inputNodeID, System.Boolean bKeepWorldTransform)
  RVA=0x0884CBF0  token=0x6000B0A  System.Void GetChildrenTransforms(UnityEngine.Transform transform, System.Collections.Generic.List<UnityEngine.Matrix4x4>& childTransforms)
  RVA=0x0884D5B0  token=0x6000B0B  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Logger
TYPE:  class
TOKEN: 0x200013F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0884D918  token=0x6000B0C  System.Void Log(System.String text)
  RVA=0x0884D774  token=0x6000B0D  System.Void LogFormat(System.String text, System.Object[] args)
  RVA=0x0884D8CC  token=0x6000B0E  System.Void LogWarning(System.String text)
  RVA=0x0884D86C  token=0x6000B0F  System.Void LogWarningFormat(System.String text, System.Object[] args)
  RVA=0x0884D6AC  token=0x6000B10  System.Void LogError(System.String text)
  RVA=0x0884D64C  token=0x6000B11  System.Void LogErrorFormat(System.String text, System.Object[] args)
  RVA=0x0884D6F8  token=0x6000B12  System.Void LogError(System.Exception ex)
  RVA=0x0884D644  token=0x6000B13  System.Void LogAssertion(System.String text)
  RVA=0x0884D63C  token=0x6000B14  System.Void LogAssertionFormat(System.String text, System.Object[] args)
  RVA=0x0884D82C  token=0x6000B15  System.Void LogToCookLogsIfOn(System.String text)
  RVA=0x0884D7D0  token=0x6000B16  System.Void LogToCookLogsIfOnFormat(System.String text, System.Object[] args)
  RVA=0x0350B670  token=0x6000B17  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MeshData
TYPE:  class
TOKEN: 0x2000140
SIZE:  0x58
FIELDS:
  public            System.Collections.Generic.List<System.Int32>_indices  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Vector3>_vertices  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Color32>_colors  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Vector3>_normals  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Vector4>_tangents  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Vector4>[]_uvs  // 0x38
  public            System.Collections.Generic.List<UnityEngine.Vector3>_triangleNormals  // 0x40
  public            System.Collections.Generic.Dictionary<System.Int32,System.Int32>_pointIndexToMeshIndexMap  // 0x48
  public            UnityEngine.MeshTopology        _meshTopology  // 0x50
METHODS:
  RVA=0x0884D964  token=0x6000B18  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MeshIndexFormat
TYPE:  class
TOKEN: 0x2000141
SIZE:  0x18
FIELDS:
  public            UnityEngine.Rendering.IndexFormat_indexFormat  // 0x10
METHODS:
  RVA=0x0884DB9C  token=0x6000B19  System.Void CalculateIndexFormat(System.Int32 numVertices)
  RVA=0x0884DBF8  token=0x6000B1A  System.Void SetFormatForMesh(UnityEngine.Mesh mesh)
  RVA=0x0350B670  token=0x6000B1B  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PipelineType
TYPE:  sealed struct
TOKEN: 0x2000142
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PipelineTypeUnsupported  // const
  public    static  HoudiniEngineUnity.HEU_PipelineTypeBiRP  // const
  public    static  HoudiniEngineUnity.HEU_PipelineTypeURP  // const
  public    static  HoudiniEngineUnity.HEU_PipelineTypeHDRP  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_RenderingPipelineDefines
TYPE:  class
TOKEN: 0x2000143
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0884DF94  token=0x6000B1C  System.Void .cctor()
  RVA=0x0884DED0  token=0x6000B1D  System.Void UpdateDefines()
  RVA=0x0884DD20  token=0x6000B1E  HoudiniEngineUnity.HEU_PipelineType GetPipeline()
  RVA=0x0884DC1C  token=0x6000B1F  System.Void AddDefine(System.String define)
  RVA=0x0884DE2C  token=0x6000B20  System.Void RemoveDefine(System.String define)
  RVA=0x0884DCC0  token=0x6000B21  System.Collections.Generic.List<System.String> GetDefines()
  RVA=0x0350B670  token=0x6000B22  System.Void SetDefines(System.Collections.Generic.List<System.String> definesList)
  RVA=0x0350B670  token=0x6000B23  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SerializableDictionary`2
TYPE:  class
TOKEN: 0x2000144
IMPLEMENTS: System.Collections.Generic.IDictionary`2 System.Collections.Generic.ICollection`1 System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           System.Collections.Generic.Dictionary<TKey,TValue>_dictionary  // 0x0
  private           TKey[]                          _keys  // 0x0
  private           TValue[]                        _values  // 0x0
PROPERTIES:
  Item  get=-1  // not resolved  set=-1  // not resolved
  Keys  get=-1  // not resolved
  Values  get=-1  // not resolved
  Count  get=-1  // not resolved
  IsReadOnly  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000B2A  System.Void Add(TKey key, TValue value)
  RVA=-1  // not resolved  token=0x6000B2B  System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000B2C  System.Void Clear()
  RVA=-1  // not resolved  token=0x6000B2D  System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000B2E  System.Boolean ContainsKey(TKey key)
  RVA=-1  // not resolved  token=0x6000B2F  System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  RVA=-1  // not resolved  token=0x6000B30  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000B31  System.Boolean Remove(TKey key)
  RVA=-1  // not resolved  token=0x6000B32  System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  RVA=-1  // not resolved  token=0x6000B33  System.Boolean TryGetValue(TKey key, TValue& value)
  RVA=-1  // not resolved  token=0x6000B34  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=-1  // not resolved  token=0x6000B35  System.Void OnAfterDeserialize()
  RVA=-1  // not resolved  token=0x6000B36  System.Void OnBeforeSerialize()
  RVA=-1  // not resolved  token=0x6000B37  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ShelfToolData
TYPE:  class
TOKEN: 0x2000145
SIZE:  0x50
FIELDS:
  public            System.String                   _name  // 0x10
  public            HoudiniEngineUnity.HEU_ShelfToolData.ToolType_toolType  // 0x18
  public            System.String                   _toolTip  // 0x20
  public            System.String                   _iconPath  // 0x28
  public            System.String                   _assetPath  // 0x30
  public            System.String                   _helpURL  // 0x38
  public            System.String[]                 _targets  // 0x40
  public            System.String                   _jsonPath  // 0x48
METHODS:
  RVA=0x0884DF9C  token=0x6000B38  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Shelf
TYPE:  class
TOKEN: 0x2000147
SIZE:  0x30
FIELDS:
  public            System.String                   _shelfName  // 0x10
  public            System.String                   _shelfPath  // 0x18
  public            System.Boolean                  _defaultShelf  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData>_tools  // 0x28
METHODS:
  RVA=0x088513E4  token=0x6000B39  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ShelfTools
TYPE:  class
TOKEN: 0x2000148
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Shelf>_shelves  // static @ 0x0
  private   static  System.Boolean                  _shelvesLoaded  // static @ 0x8
  private   static  System.Int32                    _currentSelectedShelf  // static @ 0xc
  public    static  System.String                   TARGET_ALL  // const
  public    static  System.String                   TARGET_UNITY  // const
METHODS:
  RVA=0x0884E1E0  token=0x6000B3A  System.Boolean AreShelvesLoaded()
  RVA=0x08851274  token=0x6000B3B  System.Void SetReloadShelves()
  RVA=0x0884E230  token=0x6000B3C  System.Void ClearShelves()
  RVA=0x0884F258  token=0x6000B3D  System.Int32 GetNumShelves()
  RVA=0x0884F208  token=0x6000B3E  System.Int32 GetCurrentShelfIndex()
  RVA=0x08851220  token=0x6000B3F  System.Void SetCurrentShelf(System.Int32 index)
  RVA=0x0884F45C  token=0x6000B40  HoudiniEngineUnity.HEU_Shelf GetShelf(System.Int32 index)
  RVA=0x0884F300  token=0x6000B41  HoudiniEngineUnity.HEU_Shelf GetShelf(System.String shelfName)
  RVA=0x0884F2B4  token=0x6000B42  System.String GetShelfStorageEntry(System.String shelfName, System.String shelfPath)
  RVA=0x0884F500  token=0x6000B43  System.Void GetSplitShelfEntry(System.String shelfEntry, System.String& shelfName, System.String& shelfPath)
  RVA=0x0884FB94  token=0x6000B44  System.Void LoadShelves()
  RVA=0x08850CB8  token=0x6000B45  System.Boolean LoadToolsFromDirectory(System.String folderPath, System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData>& tools)
  RVA=0x08850270  token=0x6000B46  HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonFile(System.String jsonFilePath)
  RVA=0x0885040C  token=0x6000B47  HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonString(System.String json, System.String jsonFilePath)
  RVA=0x0884E040  token=0x6000B48  HoudiniEngineUnity.HEU_Shelf AddShelf(System.String shelfName, System.String shelfPath)
  RVA=0x08850EDC  token=0x6000B49  System.Void RemoveShelf(System.Int32 shelfIndex)
  RVA=0x0885100C  token=0x6000B4A  System.Void SaveShelf()
  RVA=0x0884EF58  token=0x6000B4B  System.Void ExecuteTool(System.Int32 toolSlot)
  RVA=0x0884E2F4  token=0x6000B4C  System.Void ExecuteToolGenerator(System.String toolName, System.String toolPath, UnityEngine.Vector3 targetPosition, UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetScale)
  RVA=0x0884FA04  token=0x6000B4D  System.Boolean IsValidInputMesh(UnityEngine.GameObject gameObject)
  RVA=0x0884F974  token=0x6000B4E  System.Boolean IsValidInputHDA(UnityEngine.GameObject gameObject)
  RVA=0x088512C4  token=0x6000B4F  System.Boolean ShouldUseHDA(UnityEngine.GameObject[] gameObjectList)
  RVA=0x0884E490  token=0x6000B50  System.Void ExecuteToolNoInput(System.String toolName, System.String toolPath)
  RVA=0x0884E9E0  token=0x6000B51  System.Void ExecuteToolOperatorSingle(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects)
  RVA=0x0884E5C4  token=0x6000B52  System.Void ExecuteToolOperatorMultiple(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects)
  RVA=0x0884E294  token=0x6000B53  System.Void ExecuteToolBatch(System.String toolName, System.String toolPath, UnityEngine.GameObject[] batchObjects)
  RVA=0x0884F8B8  token=0x6000B54  System.String GetToolResourcePath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath, System.String ext)
  RVA=0x0884F750  token=0x6000B55  System.String GetToolIconPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath)
  RVA=0x0884F5E0  token=0x6000B56  System.String GetToolAssetPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath)
  RVA=0x0350B670  token=0x6000B57  System.Void .ctor()
  RVA=0x08851344  token=0x6000B58  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONNodeType
TYPE:  sealed struct
TOKEN: 0x200014A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONNodeType Array  // const
  public    static  HoudiniEngineUnity.JSONNodeType Object  // const
  public    static  HoudiniEngineUnity.JSONNodeType String  // const
  public    static  HoudiniEngineUnity.JSONNodeType Number  // const
  public    static  HoudiniEngineUnity.JSONNodeType NullValue  // const
  public    static  HoudiniEngineUnity.JSONNodeType Boolean  // const
  public    static  HoudiniEngineUnity.JSONNodeType None  // const
  public    static  HoudiniEngineUnity.JSONNodeType Custom  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.JSONTextMode
TYPE:  sealed struct
TOKEN: 0x200014B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONTextMode Compact  // const
  public    static  HoudiniEngineUnity.JSONTextMode Indent  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.JSONNode
TYPE:  abstract class
TOKEN: 0x200014C
SIZE:  0x10
FIELDS:
  public    static  System.Boolean                  forceASCII  // static @ 0x0
  public    static  System.Boolean                  longAsString  // static @ 0x1
  private   static  System.Text.StringBuilder       m_EscapeBuilder  // static @ 0xffffffff
  public    static  HoudiniEngineUnity.JSONContainerTypeVectorContainerType  // static @ 0x4
  public    static  HoudiniEngineUnity.JSONContainerTypeQuaternionContainerType  // static @ 0x8
  public    static  HoudiniEngineUnity.JSONContainerTypeRectContainerType  // static @ 0xc
PROPERTIES:
  Tag  get=-1  // abstract
  Item  get=0x01002730  set=0x0350B670
  Item  get=0x01002730  set=0x0350B670
  Value  get=0x08853C4C  set=0x0350B670
  Count  get=0x01002730
  IsNumber  get=0x0115F4C0
  IsString  get=0x0115F4C0
  IsBoolean  get=0x0115F4C0
  IsNull  get=0x0115F4C0
  IsArray  get=0x0115F4C0
  IsObject  get=0x0115F4C0
  Inline  get=0x0115F4C0  set=0x0350B670
  Children  get=0x088539C0
  DeepChildren  get=0x08853A14
  Linq  get=0x08853BEC
  Keys  get=0x08853B38
  Values  get=0x08853B38
  AsDouble  get=0x08853880  set=0x08854628
  AsInt  get=0x08853928  set=0x088546A0
  AsFloat  get=0x0885390C  set=0x0885468C
  AsBool  get=0x088537E4  set=0x088545BC
  AsLong  get=0x08853944  set=0x088546B8
  AsArray  get=0x088537A8
  AsObject  get=0x08853984
  EscapeBuilder  get=0x08853A84
METHODS:
  RVA=0x0350B670  token=0x6000B6B  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  RVA=0x0885145C  token=0x6000B6C  System.Void Add(HoudiniEngineUnity.JSONNode aItem)
  RVA=0x01002730  token=0x6000B6D  HoudiniEngineUnity.JSONNode Remove(System.String aKey)
  RVA=0x01002730  token=0x6000B6E  HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex)
  RVA=0x03D51810  token=0x6000B6F  HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x08852C2C  token=0x6000B72  System.String ToString()
  RVA=0x08852CB0  token=0x6000B73  System.String ToString(System.Int32 aIndent)
  RVA=-1  // abstract  token=0x6000B74  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=-1  // abstract  token=0x6000B75  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x08853DA0  token=0x6000B85  HoudiniEngineUnity.JSONNode op_Implicit(System.String s)
  RVA=0x08854274  token=0x6000B86  System.String op_Implicit(HoudiniEngineUnity.JSONNode d)
  RVA=0x088543A0  token=0x6000B87  HoudiniEngineUnity.JSONNode op_Implicit(System.Double n)
  RVA=0x08853D60  token=0x6000B88  System.Double op_Implicit(HoudiniEngineUnity.JSONNode d)
  RVA=0x088542B4  token=0x6000B89  HoudiniEngineUnity.JSONNode op_Implicit(System.Single n)
  RVA=0x08854530  token=0x6000B8A  System.Single op_Implicit(HoudiniEngineUnity.JSONNode d)
  RVA=0x08853E78  token=0x6000B8B  HoudiniEngineUnity.JSONNode op_Implicit(System.Int32 n)
  RVA=0x0885412C  token=0x6000B8C  System.Int32 op_Implicit(HoudiniEngineUnity.JSONNode d)
  RVA=0x08853F10  token=0x6000B8D  HoudiniEngineUnity.JSONNode op_Implicit(System.Int64 n)
  RVA=0x088544F0  token=0x6000B8E  System.Int64 op_Implicit(HoudiniEngineUnity.JSONNode d)
  RVA=0x08853EC8  token=0x6000B8F  HoudiniEngineUnity.JSONNode op_Implicit(System.Boolean b)
  RVA=0x08854328  token=0x6000B90  System.Boolean op_Implicit(HoudiniEngineUnity.JSONNode d)
  RVA=0x08854368  token=0x6000B91  HoudiniEngineUnity.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> aKeyValue)
  RVA=0x08853C78  token=0x6000B92  System.Boolean op_Equality(HoudiniEngineUnity.JSONNode a, System.Object b)
  RVA=0x088545A8  token=0x6000B93  System.Boolean op_Inequality(HoudiniEngineUnity.JSONNode a, System.Object b)
  RVA=0x0232CE30  token=0x6000B94  System.Boolean Equals(System.Object obj)
  RVA=0x03D4F970  token=0x6000B95  System.Int32 GetHashCode()
  RVA=0x088514A4  token=0x6000B97  System.String Escape(System.String aText)
  RVA=0x08851790  token=0x6000B98  HoudiniEngineUnity.JSONNode ParseElement(System.String token, System.Boolean quoted)
  RVA=0x088518E4  token=0x6000B99  HoudiniEngineUnity.JSONNode Parse(System.String aJSON)
  RVA=0x0885170C  token=0x6000B9A  HoudiniEngineUnity.JSONNode GetContainer(HoudiniEngineUnity.JSONContainerType aType)
  RVA=0x08853FD0  token=0x6000B9B  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector2 aVec)
  RVA=0x0885406C  token=0x6000B9C  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector3 aVec)
  RVA=0x08853E00  token=0x6000B9D  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector4 aVec)
  RVA=0x0885445C  token=0x6000B9E  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Quaternion aRot)
  RVA=0x088541FC  token=0x6000B9F  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Rect aRect)
  RVA=0x088543F0  token=0x6000BA0  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.RectOffset aRect)
  RVA=0x088544D4  token=0x6000BA1  UnityEngine.Vector2 op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x08854570  token=0x6000BA2  UnityEngine.Vector3 op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x088541CC  token=0x6000BA3  UnityEngine.Vector4 op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x0885416C  token=0x6000BA4  UnityEngine.Quaternion op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x0885419C  token=0x6000BA5  UnityEngine.Rect op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x0885430C  token=0x6000BA6  UnityEngine.RectOffset op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x088525C0  token=0x6000BA7  UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault)
  RVA=0x088526A8  token=0x6000BA8  UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName)
  RVA=0x08852748  token=0x6000BA9  UnityEngine.Vector2 ReadVector2()
  RVA=0x088533A4  token=0x6000BAA  HoudiniEngineUnity.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName)
  RVA=0x08852760  token=0x6000BAB  UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault)
  RVA=0x088528DC  token=0x6000BAC  UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName)
  RVA=0x088529C4  token=0x6000BAD  UnityEngine.Vector3 ReadVector3()
  RVA=0x0885349C  token=0x6000BAE  HoudiniEngineUnity.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName)
  RVA=0x08852A14  token=0x6000BAF  UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault)
  RVA=0x08852BF0  token=0x6000BB0  UnityEngine.Vector4 ReadVector4()
  RVA=0x088535DC  token=0x6000BB1  HoudiniEngineUnity.JSONNode WriteVector4(UnityEngine.Vector4 aVec)
  RVA=0x08851F58  token=0x6000BB2  UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault)
  RVA=0x08851F1C  token=0x6000BB3  UnityEngine.Quaternion ReadQuaternion()
  RVA=0x08852DD4  token=0x6000BB4  HoudiniEngineUnity.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot)
  RVA=0x088523E4  token=0x6000BB5  UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault)
  RVA=0x088523B0  token=0x6000BB6  UnityEngine.Rect ReadRect()
  RVA=0x088531D8  token=0x6000BB7  HoudiniEngineUnity.JSONNode WriteRect(UnityEngine.Rect aRect)
  RVA=0x08852134  token=0x6000BB8  UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault)
  RVA=0x08852348  token=0x6000BB9  UnityEngine.RectOffset ReadRectOffset()
  RVA=0x08852FA0  token=0x6000BBA  HoudiniEngineUnity.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect)
  RVA=0x08851E74  token=0x6000BBB  UnityEngine.Matrix4x4 ReadMatrix()
  RVA=0x08852D40  token=0x6000BBC  HoudiniEngineUnity.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix)
  RVA=0x0350B670  token=0x6000BBD  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONArray
TYPE:  class
TOKEN: 0x2000154
SIZE:  0x20
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private           System.Collections.Generic.List<HoudiniEngineUnity.JSONNode>m_List  // 0x10
  private           System.Boolean                  inline  // 0x18
PROPERTIES:
  Inline  get=0x01002A50  set=0x01002B40
  Tag  get=0x01168950
  IsArray  get=0x0232EB60
  Item  get=0x0885CA9C  set=0x0885CB3C
  Item  get=0x0885CA9C  set=0x0885CB3C
  Count  get=0x0885C9FC
  Children  get=0x0885C98C
METHODS:
  RVA=0x0885C628  token=0x6000BED  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x0885C5A0  token=0x6000BF3  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  RVA=0x0885C6B8  token=0x6000BF4  HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex)
  RVA=0x0885C75C  token=0x6000BF5  HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x0885C7B4  token=0x6000BF7  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=0x0885C914  token=0x6000BF8  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONObject
TYPE:  class
TOKEN: 0x2000156
SIZE:  0x20
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.JSONNode>m_Dict  // 0x10
  private           System.Boolean                  inline  // 0x18
PROPERTIES:
  Inline  get=0x01002A50  set=0x01002B40
  Tag  get=0x02102C70
  IsObject  get=0x0232EB60
  Item  get=0x0885E698  set=0x0885E7E4
  Item  get=0x0885E698  set=0x0885E7E4
  Count  get=0x0885E658
  Children  get=0x0885E5E8
METHODS:
  RVA=0x0885DE80  token=0x6000C06  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x0885DD34  token=0x6000C0C  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  RVA=0x0885E190  token=0x6000C0D  HoudiniEngineUnity.JSONNode Remove(System.String aKey)
  RVA=0x0885DF24  token=0x6000C0E  HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex)
  RVA=0x0885DFE4  token=0x6000C0F  HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x0885E248  token=0x6000C11  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=0x0885E570  token=0x6000C12  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONString
TYPE:  class
TOKEN: 0x2000159
SIZE:  0x18
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private           System.String                   m_Data  // 0x10
PROPERTIES:
  Tag  get=0x03D555E0
  IsString  get=0x0232EB60
  Value  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x03D60600  token=0x6000C20  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x0426FEE0  token=0x6000C23  System.Void .ctor(System.String aData)
  RVA=0x0885EA5C  token=0x6000C24  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=0x0885E9B8  token=0x6000C25  System.Boolean Equals(System.Object obj)
  RVA=0x06FAB9A8  token=0x6000C26  System.Int32 GetHashCode()
END_CLASS

CLASS: HoudiniEngineUnity.JSONNumber
TYPE:  class
TOKEN: 0x200015A
SIZE:  0x18
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private           System.Double                   m_Data  // 0x10
PROPERTIES:
  Tag  get=0x03D50CD0
  IsNumber  get=0x0232EB60
  Value  get=0x0885DC68  set=0x0885DCB4
  AsDouble  get=0x03D61CF0  set=0x03D4E410
  AsLong  get=0x03D6D990  set=0x03D6D9A0
METHODS:
  RVA=0x03D60600  token=0x6000C29  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x03D4E410  token=0x6000C30  System.Void .ctor(System.Double aData)
  RVA=0x0885CDA8  token=0x6000C31  System.Void .ctor(System.String aData)
  RVA=0x0885DC34  token=0x6000C32  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=0x0885DAEC  token=0x6000C33  System.Boolean IsNumeric(System.Object value)
  RVA=0x0885DA0C  token=0x6000C34  System.Boolean Equals(System.Object obj)
  RVA=0x0885DAE0  token=0x6000C35  System.Int32 GetHashCode()
END_CLASS

CLASS: HoudiniEngineUnity.JSONBool
TYPE:  class
TOKEN: 0x200015B
SIZE:  0x18
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private           System.Boolean                  m_Data  // 0x10
PROPERTIES:
  Tag  get=0x03D51110
  IsBoolean  get=0x0232EB60
  Value  get=0x0885CDBC  set=0x0885CE08
  AsBool  get=0x011797F0  set=0x03D4E960
METHODS:
  RVA=0x03D60600  token=0x6000C38  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x03D4E960  token=0x6000C3D  System.Void .ctor(System.Boolean aData)
  RVA=0x0885CDA8  token=0x6000C3E  System.Void .ctor(System.String aData)
  RVA=0x0885CD3C  token=0x6000C3F  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=0x0885CC98  token=0x6000C40  System.Boolean Equals(System.Object obj)
  RVA=0x0885CCF4  token=0x6000C41  System.Int32 GetHashCode()
END_CLASS

CLASS: HoudiniEngineUnity.JSONNull
TYPE:  class
TOKEN: 0x200015C
SIZE:  0x10
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private   static  HoudiniEngineUnity.JSONNull     m_StaticInstance  // static @ 0x0
  public    static  System.Boolean                  reuseSameInstance  // static @ 0x8
PROPERTIES:
  Tag  get=0x03D51100
  IsNull  get=0x0232EB60
  Value  get=0x0885D9E0  set=0x0350B670
  AsBool  get=0x0115F4C0  set=0x0350B670
METHODS:
  RVA=0x0885D85C  token=0x6000C42  HoudiniEngineUnity.JSONNull CreateOrGet()
  RVA=0x0350B670  token=0x6000C43  System.Void .ctor()
  RVA=0x03D60600  token=0x6000C46  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x0885D8C8  token=0x6000C4B  System.Boolean Equals(System.Object obj)
  RVA=0x01002730  token=0x6000C4C  System.Int32 GetHashCode()
  RVA=0x0885D920  token=0x6000C4D  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  RVA=0x0885D968  token=0x6000C4E  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONLazyCreator
TYPE:  class
TOKEN: 0x200015D
SIZE:  0x20
EXTENDS: HoudiniEngineUnity.JSONNode
FIELDS:
  private           HoudiniEngineUnity.JSONNode     m_Node  // 0x10
  private           System.String                   m_Key  // 0x18
PROPERTIES:
  Tag  get=0x03D55AA0
  Item  get=0x0885D374  set=0x0885D724
  Item  get=0x0885D374  set=0x0885D724
  AsInt  get=0x0885D1AC  set=0x0885D5B0
  AsFloat  get=0x0885D144  set=0x0885D538
  AsDouble  get=0x0885D0DC  set=0x0885D4C4
  AsLong  get=0x0885D214  set=0x0885D628
  AsBool  get=0x0885D074  set=0x0885D454
  AsArray  get=0x0885CFFC
  AsObject  get=0x0885D2FC
METHODS:
  RVA=0x03D60600  token=0x6000C50  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  RVA=0x02E1A410  token=0x6000C51  System.Void .ctor(HoudiniEngineUnity.JSONNode aNode)
  RVA=0x02676770  token=0x6000C52  System.Void .ctor(HoudiniEngineUnity.JSONNode aNode, System.String aKey)
  RVA=-1  // generic def  token=0x6000C53  T Set(T aVal)
  RVA=0x0885CF10  token=0x6000C58  System.Void Add(HoudiniEngineUnity.JSONNode aItem)
  RVA=0x0885CE6C  token=0x6000C59  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  RVA=0x0885CFA4  token=0x6000C5A  System.Boolean op_Equality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b)
  RVA=0x0885D444  token=0x6000C5B  System.Boolean op_Inequality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b)
  RVA=0x0885CFA4  token=0x6000C5C  System.Boolean Equals(System.Object obj)
  RVA=0x01002730  token=0x6000C5D  System.Int32 GetHashCode()
  RVA=0x0885CFB4  token=0x6000C6A  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
END_CLASS

CLASS: HoudiniEngineUnity.JSON
TYPE:  static class
TOKEN: 0x200015E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0885EAC8  token=0x6000C6B  HoudiniEngineUnity.JSONNode Parse(System.String aJSON)
END_CLASS

CLASS: HoudiniEngineUnity.JSONContainerType
TYPE:  sealed struct
TOKEN: 0x200015F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONContainerTypeArray  // const
  public    static  HoudiniEngineUnity.JSONContainerTypeObject  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TerrainUtility
TYPE:  static class
TOKEN: 0x2000160
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088558B8  token=0x6000C6C  System.Boolean GenerateTerrainFromVolume(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject, UnityEngine.TerrainData& terrainData, UnityEngine.Vector3& volumePositionOffset, UnityEngine.Terrain& terrain, System.String bakedMaterialPath)
  RVA=0x08858180  token=0x6000C6D  System.Void SetTerrainMaterial(UnityEngine.Terrain terrain, System.String specifiedMaterialName, System.String bakedMaterialPath)
  RVA=0x088562E4  token=0x6000C6E  System.String GetDefaultTerrainShaderName()
  RVA=0x08856264  token=0x6000C6F  System.String GetDefaultTerrainMaterialPath()
  RVA=0x0885671C  token=0x6000C70  System.Single[] GetNormalizedHeightmapFromPartWithMinMax(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single& minHeight, System.Single& maxHeight, System.Single& heightRange, System.Boolean bUseHeightRangeOverride)
  RVA=0x08856364  token=0x6000C71  System.Int32[,] GetDetailMapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& detailResolution)
  RVA=0x088565A4  token=0x6000C72  System.Boolean GetHeightmapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 xLength, System.Int32 yLength, System.Int32 geoID, System.Int32 partID, System.Single[]& heightValues, System.Single& minHeight, System.Single& maxHeight)
  RVA=0x088557DC  token=0x6000C73  System.Single[,] ConvertHeightMapHoudiniToUnity(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[] heightValues)
  RVA=0x08855698  token=0x6000C74  System.Single[,,] ConvertHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Collections.Generic.List<System.Single[]> heightFields)
  RVA=0x08854BE0  token=0x6000C75  System.Single[,,] AppendConvertedHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[,,] existingAlphaMaps, System.Collections.Generic.List<System.Single[]> heightFields, System.Single[] strengths, System.Collections.Generic.List<System.Int32> alphaMapIndices)
  RVA=0x08856B5C  token=0x6000C76  UnityEngine.Vector3 GetVolumePositionOffset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Vector3 volumePosition, System.Single terrainSizeX, System.Single heightMapSize, System.Int32 mapWidth, System.Int32 mapHeight, System.Single minHeight)
  RVA=0x08856A68  token=0x6000C77  System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x0885733C  token=0x6000C78  System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, HoudiniEngineUnity.HEU_VolumeScatterTrees& scatterTrees, System.Boolean throwWarningIfNoTileAttribute)
  RVA=0x088551AC  token=0x6000C79  System.Void ApplyScatterTrees(UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_VolumeScatterTrees scatterTrees, System.Int32 tileIndex)
  RVA=0x08856F18  token=0x6000C7A  System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailPrototype& detailPrototype)
  RVA=0x08856C48  token=0x6000C7B  System.Void PopulateDetailProperties(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailProperties& detailProperties)
  RVA=0x08854DD8  token=0x6000C7C  System.Void ApplyDetailLayers(UnityEngine.Terrain terrain, UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_DetailProperties detailProperties, System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype> heuDetailPrototypes, System.Collections.Generic.List<System.Int32[,]> convertedDetailMaps)
  RVA=0x08856864  token=0x6000C7D  System.Int32 GetTerrainLayerIndexByName(System.String layerName, UnityEngine.TerrainLayer[] terrainLayers)
  RVA=0x088569D0  token=0x6000C7E  System.Int32 GetTerrainLayerIndex(UnityEngine.TerrainLayer layer, UnityEngine.TerrainLayer[] terrainLayers)
  RVA=0x088582EC  token=0x6000C7F  System.Boolean VolumeLayerHasAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x08856468  token=0x6000C80  HoudiniEngineUnity.HFLayerType GetHeightfieldLayerType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String volumeName)
  RVA=0x088563F4  token=0x6000C81  System.Single GetHeightRangeFromHeightfield(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x0885679C  token=0x6000C82  System.String GetTerrainDataExportPathFromHeightfieldAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  RVA=0x08857EE8  token=0x6000C83  System.Single[] ResampleData(System.Single[] data, System.Int32 oldWidth, System.Int32 oldHeight, System.Int32 newWidth, System.Int32 newHeight)
  RVA=0x088561F4  token=0x6000C84  System.Boolean GetAttributeTile(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& outTileAttribute)
END_CLASS

CLASS: HoudiniEngineUnity.IEquivable`1
TYPE:  interface
TOKEN: 0x2000161
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000C85  System.Boolean IsEquivalentTo(T other)
END_CLASS

CLASS: HoudiniEngineUnity.IEquivableWrapperClass`1
TYPE:  interface
TOKEN: 0x2000162
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000C86  System.Boolean IsNull()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TestHelpers
TYPE:  class
TOKEN: 0x2000163
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000C87  System.Boolean AssertTrueLogEquivalent(T a, T b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _)
  RVA=0x088585E0  token=0x6000C88  System.Boolean AssertTrueLogEquivalent(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C89  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C8A  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=0x088586DC  token=0x6000C8B  System.Boolean AssertTrueLogEquivalent(System.String a, System.String b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C8C  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _)
  RVA=-1  // generic def  token=0x6000C8D  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireClass<T> _)
  RVA=-1  // generic def  token=0x6000C8E  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C8F  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C90  System.Boolean AssertTrueLogEquivalent(T[] a, T[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=0x0885847C  token=0x6000C91  System.Boolean AssertTrueLogEquivalent(System.String[] a, System.String[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C92  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T>[] a, HoudiniEngineUnity.IEquivable<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C93  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T>[] a, HoudiniEngineUnity.IEquivableWrapperClass<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=0x08858794  token=0x6000C94  System.Void PrintTestLogAndSetResult(System.Boolean expression, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  RVA=-1  // generic def  token=0x6000C95  System.Boolean ShouldBeTested(T a, T b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=0x088588D8  token=0x6000C96  System.Boolean ShouldBeTested(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=-1  // generic def  token=0x6000C97  System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=-1  // generic def  token=0x6000C98  System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=-1  // generic def  token=0x6000C99  System.Boolean ShouldBeTested(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=-1  // generic def  token=0x6000C9A  System.Boolean ShouldBeTested(T[] a, T[] b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=0x08858B18  token=0x6000C9B  System.Boolean ShouldBeTested(System.String a, System.String b, System.Boolean& bResult, System.String header, System.String subject)
  RVA=0x08858BAC  token=0x6000C9C  System.Boolean TestOutputObjectEquivalence(UnityEngine.GameObject a, UnityEngine.GameObject b)
  RVA=0x0350B670  token=0x6000C9D  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AssetInfo
TYPE:  class
TOKEN: 0x2000166
SIZE:  0x50
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_AssetInfoself  // 0x10
METHODS:
  RVA=0x03D64D80  token=0x6000CA0  System.Void .ctor(HoudiniEngineUnity.HAPI_AssetInfo self)
  RVA=0x08860560  token=0x6000CA1  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AssetInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AssetInfo_Extensions
TYPE:  static class
TOKEN: 0x2000167
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088604FC  token=0x6000CA2  HoudiniEngineUnity.Test_HAPI_AssetInfo ToTestObject(HoudiniEngineUnity.HAPI_AssetInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_NodeInfo
TYPE:  class
TOKEN: 0x2000168
SIZE:  0x58
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_NodeInfoself  // 0x10
METHODS:
  RVA=0x03D6DA00  token=0x6000CA3  System.Void .ctor(HoudiniEngineUnity.HAPI_NodeInfo self)
  RVA=0x08860B9C  token=0x6000CA4  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_NodeInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_NodeInfo_Extensions
TYPE:  static class
TOKEN: 0x2000169
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08860B2C  token=0x6000CA5  HoudiniEngineUnity.Test_HAPI_NodeInfo ToTestObject(HoudiniEngineUnity.HAPI_NodeInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ObjectInfo
TYPE:  class
TOKEN: 0x200016A
SIZE:  0x30
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_ObjectInfoself  // 0x10
METHODS:
  RVA=0x03D64DF0  token=0x6000CA6  System.Void .ctor(HoudiniEngineUnity.HAPI_ObjectInfo self)
  RVA=0x08860E30  token=0x6000CA7  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ObjectInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ObjectInfo_Extensions
TYPE:  static class
TOKEN: 0x200016B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08860DD0  token=0x6000CA8  HoudiniEngineUnity.Test_HAPI_ObjectInfo ToTestObject(HoudiniEngineUnity.HAPI_ObjectInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_Transform
TYPE:  class
TOKEN: 0x200016C
SIZE:  0x38
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_Transformself  // 0x10
METHODS:
  RVA=0x08861778  token=0x6000CA9  System.Void .ctor(HoudiniEngineUnity.HAPI_Transform self)
  RVA=0x0886181C  token=0x6000CAA  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_Transform other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_Transform_Extensions
TYPE:  static class
TOKEN: 0x200016D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0886179C  token=0x6000CAB  HoudiniEngineUnity.Test_HAPI_Transform ToTestObject(HoudiniEngineUnity.HAPI_Transform self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_GeoInfo
TYPE:  class
TOKEN: 0x200016E
SIZE:  0x38
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_GeoInfo self  // 0x10
METHODS:
  RVA=0x03D64D60  token=0x6000CAC  System.Void .ctor(HoudiniEngineUnity.HAPI_GeoInfo self)
  RVA=0x088608FC  token=0x6000CAD  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_GeoInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_GeoInfo_Extensions
TYPE:  static class
TOKEN: 0x200016F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0886089C  token=0x6000CAE  HoudiniEngineUnity.Test_HAPI_GeoInfo ToTestObject(HoudiniEngineUnity.HAPI_GeoInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AttributeInfo
TYPE:  class
TOKEN: 0x2000170
SIZE:  0x38
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_AttributeInfoself  // 0x10
METHODS:
  RVA=0x03D6D9E0  token=0x6000CAF  System.Void .ctor(HoudiniEngineUnity.HAPI_AttributeInfo self)
  RVA=0x08860798  token=0x6000CB0  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AttributeInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AttributeInfo_Extensions
TYPE:  static class
TOKEN: 0x2000171
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0886073C  token=0x6000CB1  HoudiniEngineUnity.Test_HAPI_AttributeInfo ToTestObject(HoudiniEngineUnity.HAPI_AttributeInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_TransformEuler
TYPE:  class
TOKEN: 0x2000172
SIZE:  0x38
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_TransformEulerself  // 0x10
METHODS:
  RVA=0x08861778  token=0x6000CB2  System.Void .ctor(HoudiniEngineUnity.HAPI_TransformEuler self)
  RVA=0x088616A0  token=0x6000CB3  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_TransformEuler other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_TransformEuler_Extensions
TYPE:  static class
TOKEN: 0x2000173
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08861620  token=0x6000CB4  HoudiniEngineUnity.Test_HAPI_TransformEuler ToTestObject(HoudiniEngineUnity.HAPI_TransformEuler self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ParmInfo
TYPE:  class
TOKEN: 0x2000174
SIZE:  0xA8
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            HoudiniEngineUnity.HAPI_ParmInfoself  // 0x10
METHODS:
  RVA=0x03D6DA30  token=0x6000CB5  System.Void .ctor(HoudiniEngineUnity.HAPI_ParmInfo self)
  RVA=0x08860FFC  token=0x6000CB6  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ParmInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ParmInfo_Extensions
TYPE:  static class
TOKEN: 0x2000175
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08860F5C  token=0x6000CB7  HoudiniEngineUnity.Test_HAPI_ParmInfo ToTestObject(HoudiniEngineUnity.HAPI_ParmInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LODGroup
TYPE:  class
TOKEN: 0x2000176
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.LODGroup            self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CB8  System.Void .ctor(UnityEngine.LODGroup self)
  RVA=0x08861D40  token=0x6000CB9  System.Boolean IsNull()
  RVA=0x08861B20  token=0x6000CBA  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LODGroup other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LODGroup_Extensions
TYPE:  static class
TOKEN: 0x2000177
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088618B0  token=0x6000CBB  HoudiniEngineUnity.Test_LODGroup ToTestObject(UnityEngine.LODGroup self)
  RVA=0x08861A1C  token=0x6000CBC  HoudiniEngineUnity.Test_LODGroup[] ToTestObject(UnityEngine.LODGroup[] self)
  RVA=0x08861910  token=0x6000CBD  System.Collections.Generic.List<HoudiniEngineUnity.Test_LODGroup> ToTestObject(System.Collections.Generic.List<UnityEngine.LODGroup> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Transform
TYPE:  class
TOKEN: 0x2000179
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Transform           self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CC2  System.Void .ctor(UnityEngine.Transform self)
  RVA=0x08865374  token=0x6000CC3  System.Boolean IsNull()
  RVA=0x088651F0  token=0x6000CC4  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Transform other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Transform_Extensions
TYPE:  static class
TOKEN: 0x200017A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08864F80  token=0x6000CC5  HoudiniEngineUnity.Test_Transform ToTestObject(UnityEngine.Transform self)
  RVA=0x088650EC  token=0x6000CC6  HoudiniEngineUnity.Test_Transform[] ToTestObject(UnityEngine.Transform[] self)
  RVA=0x08864FE0  token=0x6000CC7  System.Collections.Generic.List<HoudiniEngineUnity.Test_Transform> ToTestObject(System.Collections.Generic.List<UnityEngine.Transform> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Material
TYPE:  class
TOKEN: 0x200017C
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Material            self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CCC  System.Void .ctor(UnityEngine.Material self)
  RVA=0x088622D4  token=0x6000CCD  System.Boolean IsNull()
  RVA=0x08862100  token=0x6000CCE  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Material other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Material_Extensions
TYPE:  static class
TOKEN: 0x200017D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08861F74  token=0x6000CCF  HoudiniEngineUnity.Test_Material ToTestObject(UnityEngine.Material self)
  RVA=0x08861FD4  token=0x6000CD0  HoudiniEngineUnity.Test_Material[] ToTestObject(UnityEngine.Material[] self)
  RVA=0x08861E68  token=0x6000CD1  System.Collections.Generic.List<HoudiniEngineUnity.Test_Material> ToTestObject(System.Collections.Generic.List<UnityEngine.Material> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Collider
TYPE:  class
TOKEN: 0x200017F
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Collider            self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CD6  System.Void .ctor(UnityEngine.Collider self)
  RVA=0x08860140  token=0x6000CD7  System.Boolean IsNull()
  RVA=0x0885FD60  token=0x6000CD8  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Collider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Collider_Extensions
TYPE:  static class
TOKEN: 0x2000180
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0885FD00  token=0x6000CD9  HoudiniEngineUnity.Test_Collider ToTestObject(UnityEngine.Collider self)
  RVA=0x0885FBFC  token=0x6000CDA  HoudiniEngineUnity.Test_Collider[] ToTestObject(UnityEngine.Collider[] self)
  RVA=0x0885FAF0  token=0x6000CDB  System.Collections.Generic.List<HoudiniEngineUnity.Test_Collider> ToTestObject(System.Collections.Generic.List<UnityEngine.Collider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_BoxCollider
TYPE:  class
TOKEN: 0x2000182
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.BoxCollider         self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CE0  System.Void .ctor(UnityEngine.BoxCollider self)
  RVA=0x0885F658  token=0x6000CE1  System.Boolean IsNull()
  RVA=0x0885F4CC  token=0x6000CE2  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_BoxCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_BoxCollider_Extensions
TYPE:  static class
TOKEN: 0x2000183
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0885F46C  token=0x6000CE3  HoudiniEngineUnity.Test_BoxCollider ToTestObject(UnityEngine.BoxCollider self)
  RVA=0x0885F25C  token=0x6000CE4  HoudiniEngineUnity.Test_BoxCollider[] ToTestObject(UnityEngine.BoxCollider[] self)
  RVA=0x0885F360  token=0x6000CE5  System.Collections.Generic.List<HoudiniEngineUnity.Test_BoxCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.BoxCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_SphereCollider
TYPE:  class
TOKEN: 0x2000185
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.SphereCollider      self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CEA  System.Void .ctor(UnityEngine.SphereCollider self)
  RVA=0x08863918  token=0x6000CEB  System.Boolean IsNull()
  RVA=0x088637B0  token=0x6000CEC  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_SphereCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_SphereCollider_Extensions
TYPE:  static class
TOKEN: 0x2000186
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08863644  token=0x6000CED  HoudiniEngineUnity.Test_SphereCollider ToTestObject(UnityEngine.SphereCollider self)
  RVA=0x08863540  token=0x6000CEE  HoudiniEngineUnity.Test_SphereCollider[] ToTestObject(UnityEngine.SphereCollider[] self)
  RVA=0x088636A4  token=0x6000CEF  System.Collections.Generic.List<HoudiniEngineUnity.Test_SphereCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.SphereCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_CapsuleCollider
TYPE:  class
TOKEN: 0x2000188
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.CapsuleCollider     self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CF4  System.Void .ctor(UnityEngine.CapsuleCollider self)
  RVA=0x0885FAA0  token=0x6000CF5  System.Boolean IsNull()
  RVA=0x0885F918  token=0x6000CF6  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_CapsuleCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_CapsuleCollider_Extensions
TYPE:  static class
TOKEN: 0x2000189
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0885F6A8  token=0x6000CF7  HoudiniEngineUnity.Test_CapsuleCollider ToTestObject(UnityEngine.CapsuleCollider self)
  RVA=0x0885F814  token=0x6000CF8  HoudiniEngineUnity.Test_CapsuleCollider[] ToTestObject(UnityEngine.CapsuleCollider[] self)
  RVA=0x0885F708  token=0x6000CF9  System.Collections.Generic.List<HoudiniEngineUnity.Test_CapsuleCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.CapsuleCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshCollider
TYPE:  class
TOKEN: 0x200018B
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.MeshCollider        self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000CFE  System.Void .ctor(UnityEngine.MeshCollider self)
  RVA=0x0886266C  token=0x6000CFF  System.Boolean IsNull()
  RVA=0x08862594  token=0x6000D00  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshCollider_Extensions
TYPE:  static class
TOKEN: 0x200018C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08862324  token=0x6000D01  HoudiniEngineUnity.Test_MeshCollider ToTestObject(UnityEngine.MeshCollider self)
  RVA=0x08862384  token=0x6000D02  HoudiniEngineUnity.Test_MeshCollider[] ToTestObject(UnityEngine.MeshCollider[] self)
  RVA=0x08862488  token=0x6000D03  System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Mesh
TYPE:  class
TOKEN: 0x200018E
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Mesh                self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D08  System.Void .ctor(UnityEngine.Mesh self)
  RVA=0x088634F0  token=0x6000D09  System.Boolean IsNull()
  RVA=0x08863134  token=0x6000D0A  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Mesh other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Mesh_Extensions
TYPE:  static class
TOKEN: 0x200018F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08862EC4  token=0x6000D0B  HoudiniEngineUnity.Test_Mesh ToTestObject(UnityEngine.Mesh self)
  RVA=0x08863030  token=0x6000D0C  HoudiniEngineUnity.Test_Mesh[] ToTestObject(UnityEngine.Mesh[] self)
  RVA=0x08862F24  token=0x6000D0D  System.Collections.Generic.List<HoudiniEngineUnity.Test_Mesh> ToTestObject(System.Collections.Generic.List<UnityEngine.Mesh> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshRenderer
TYPE:  class
TOKEN: 0x2000191
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.MeshRenderer        self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D12  System.Void .ctor(UnityEngine.MeshRenderer self)
  RVA=0x08862E74  token=0x6000D13  System.Boolean IsNull()
  RVA=0x08862D50  token=0x6000D14  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshRenderer other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshRenderer_Extensions
TYPE:  static class
TOKEN: 0x2000192
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08862AE0  token=0x6000D15  HoudiniEngineUnity.Test_MeshRenderer ToTestObject(UnityEngine.MeshRenderer self)
  RVA=0x08862C4C  token=0x6000D16  HoudiniEngineUnity.Test_MeshRenderer[] ToTestObject(UnityEngine.MeshRenderer[] self)
  RVA=0x08862B40  token=0x6000D17  System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshRenderer> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshRenderer> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshFilter
TYPE:  class
TOKEN: 0x2000194
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.MeshFilter          self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D1C  System.Void .ctor(UnityEngine.MeshFilter self)
  RVA=0x08862A90  token=0x6000D1D  System.Boolean IsNull()
  RVA=0x0886292C  token=0x6000D1E  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshFilter other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshFilter_Extensions
TYPE:  static class
TOKEN: 0x2000195
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088628CC  token=0x6000D1F  HoudiniEngineUnity.Test_MeshFilter ToTestObject(UnityEngine.MeshFilter self)
  RVA=0x088627C8  token=0x6000D20  HoudiniEngineUnity.Test_MeshFilter[] ToTestObject(UnityEngine.MeshFilter[] self)
  RVA=0x088626BC  token=0x6000D21  System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshFilter> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshFilter> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LayerMask
TYPE:  class
TOKEN: 0x2000197
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.LayerMask           self  // 0x10
METHODS:
  RVA=0x010410F0  token=0x6000D26  System.Void .ctor(UnityEngine.LayerMask self)
  RVA=0x08861DD4  token=0x6000D27  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LayerMask other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LayerMask_Extensions
TYPE:  static class
TOKEN: 0x2000198
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08861D90  token=0x6000D28  HoudiniEngineUnity.Test_LayerMask ToTestObject(UnityEngine.LayerMask self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Gradient
TYPE:  class
TOKEN: 0x2000199
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Gradient            self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D29  System.Void .ctor(UnityEngine.Gradient self)
  RVA=0x025EB8A0  token=0x6000D2A  System.Boolean IsNull()
  RVA=0x08860400  token=0x6000D2B  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Gradient other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Gradient_Extensions
TYPE:  static class
TOKEN: 0x200019A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088603A0  token=0x6000D2C  HoudiniEngineUnity.Test_Gradient ToTestObject(UnityEngine.Gradient self)
  RVA=0x0886029C  token=0x6000D2D  HoudiniEngineUnity.Test_Gradient[] ToTestObject(UnityEngine.Gradient[] self)
  RVA=0x08860190  token=0x6000D2E  System.Collections.Generic.List<HoudiniEngineUnity.Test_Gradient> ToTestObject(System.Collections.Generic.List<UnityEngine.Gradient> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_AnimationCurve
TYPE:  class
TOKEN: 0x200019C
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.AnimationCurve      self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D33  System.Void .ctor(UnityEngine.AnimationCurve self)
  RVA=0x025EB8A0  token=0x6000D34  System.Boolean IsNull()
  RVA=0x0885F170  token=0x6000D35  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_AnimationCurve other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_AnimationCurve_Extensions
TYPE:  static class
TOKEN: 0x200019D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0885EF00  token=0x6000D36  HoudiniEngineUnity.Test_AnimationCurve ToTestObject(UnityEngine.AnimationCurve self)
  RVA=0x0885EF60  token=0x6000D37  HoudiniEngineUnity.Test_AnimationCurve[] ToTestObject(UnityEngine.AnimationCurve[] self)
  RVA=0x0885F064  token=0x6000D38  System.Collections.Generic.List<HoudiniEngineUnity.Test_AnimationCurve> ToTestObject(System.Collections.Generic.List<UnityEngine.AnimationCurve> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainLayer
TYPE:  class
TOKEN: 0x200019F
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.TerrainLayer        self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D3D  System.Void .ctor(UnityEngine.TerrainLayer self)
  RVA=0x08864738  token=0x6000D3E  System.Boolean IsNull()
  RVA=0x08864370  token=0x6000D3F  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainLayer other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainLayer_Extensions
TYPE:  static class
TOKEN: 0x20001A0
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08864100  token=0x6000D40  HoudiniEngineUnity.Test_TerrainLayer ToTestObject(UnityEngine.TerrainLayer self)
  RVA=0x0886426C  token=0x6000D41  HoudiniEngineUnity.Test_TerrainLayer[] ToTestObject(UnityEngine.TerrainLayer[] self)
  RVA=0x08864160  token=0x6000D42  System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainLayer> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainLayer> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Texture2D
TYPE:  class
TOKEN: 0x20001A2
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Texture2D           self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D47  System.Void .ctor(UnityEngine.Texture2D self)
  RVA=0x08864F30  token=0x6000D48  System.Boolean IsNull()
  RVA=0x08864E04  token=0x6000D49  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Texture2D other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Texture2D_Extensions
TYPE:  static class
TOKEN: 0x20001A3
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08864B94  token=0x6000D4A  HoudiniEngineUnity.Test_Texture2D ToTestObject(UnityEngine.Texture2D self)
  RVA=0x08864BF4  token=0x6000D4B  HoudiniEngineUnity.Test_Texture2D[] ToTestObject(UnityEngine.Texture2D[] self)
  RVA=0x08864CF8  token=0x6000D4C  System.Collections.Generic.List<HoudiniEngineUnity.Test_Texture2D> ToTestObject(System.Collections.Generic.List<UnityEngine.Texture2D> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TreeInstance
TYPE:  class
TOKEN: 0x20001A5
SIZE:  0x38
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.TreeInstance        self  // 0x10
METHODS:
  RVA=0x03D6D9E0  token=0x6000D51  System.Void .ctor(UnityEngine.TreeInstance self)
  RVA=0x08865630  token=0x6000D52  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TreeInstance other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TreeInstance_Extensions
TYPE:  static class
TOKEN: 0x20001A6
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x088654C8  token=0x6000D53  HoudiniEngineUnity.Test_TreeInstance ToTestObject(UnityEngine.TreeInstance self)
  RVA=0x088653C4  token=0x6000D54  HoudiniEngineUnity.Test_TreeInstance[] ToTestObject(UnityEngine.TreeInstance[] self)
  RVA=0x08865524  token=0x6000D55  System.Collections.Generic.List<HoudiniEngineUnity.Test_TreeInstance> ToTestObject(System.Collections.Generic.List<UnityEngine.TreeInstance> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainData
TYPE:  class
TOKEN: 0x20001A8
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.TerrainData         self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D5A  System.Void .ctor(UnityEngine.TerrainData self)
  RVA=0x088640B0  token=0x6000D5B  System.Boolean IsNull()
  RVA=0x08863BD8  token=0x6000D5C  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainData other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainData_Extensions
TYPE:  static class
TOKEN: 0x20001A9
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08863B78  token=0x6000D5D  HoudiniEngineUnity.Test_TerrainData ToTestObject(UnityEngine.TerrainData self)
  RVA=0x08863A74  token=0x6000D5E  HoudiniEngineUnity.Test_TerrainData[] ToTestObject(UnityEngine.TerrainData[] self)
  RVA=0x08863968  token=0x6000D5F  System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainData> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainData> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Terrain
TYPE:  class
TOKEN: 0x20001AB
SIZE:  0x18
IMPLEMENTS: HoudiniEngineUnity.IEquivableWrapperClass`1 HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            UnityEngine.Terrain             self  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x6000D64  System.Void .ctor(UnityEngine.Terrain self)
  RVA=0x08864B44  token=0x6000D65  System.Boolean IsNull()
  RVA=0x088649F8  token=0x6000D66  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Terrain other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Terrain_Extensions
TYPE:  static class
TOKEN: 0x20001AC
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08864788  token=0x6000D67  HoudiniEngineUnity.Test_Terrain ToTestObject(UnityEngine.Terrain self)
  RVA=0x088647E8  token=0x6000D68  HoudiniEngineUnity.Test_Terrain[] ToTestObject(UnityEngine.Terrain[] self)
  RVA=0x088648EC  token=0x6000D69  System.Collections.Generic.List<HoudiniEngineUnity.Test_Terrain> ToTestObject(System.Collections.Generic.List<UnityEngine.Terrain> self)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ToolsInfo
TYPE:  class
TOKEN: 0x20001AE
SIZE:  0xA8
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.Single                   _paintBrushSize  // 0x18
  public            System.Single                   _paintBrushOpacity  // 0x1c
  public            System.Int32[]                  _paintIntValue  // 0x20
  public            System.Single[]                 _paintFloatValue  // 0x28
  public            System.String[]                 _paintStringValue  // 0x30
  public            System.Int32                    _lastAttributesGeoID  // 0x38
  public            System.Int32                    _lastAttributesPartID  // 0x3c
  public            System.String                   _lastAttributeNodeName  // 0x40
  public            System.String                   _lastAttributeName  // 0x48
  public            UnityEngine.Color               _brushHandleColor  // 0x50
  public            UnityEngine.Color               _affectedAreaPaintColor  // 0x60
  public            System.Boolean                  _liveUpdate  // 0x70
  public            System.Boolean                  _isPainting  // 0x71
  public            System.Single                   _editPointBoxSize  // 0x74
  public            UnityEngine.Color               _editPointBoxUnselectedColor  // 0x78
  public            UnityEngine.Color               _editPointBoxSelectedColor  // 0x88
  public            System.Boolean                  _recacheRequired  // 0x98
  public            HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode_paintMergeMode  // 0x9c
  public            System.Boolean                  _showOnlyEditGeometry  // 0xa0
  public            System.Boolean                  _alwaysCookUpstream  // 0xa1
  public            HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility_paintMeshVisiblity  // 0xa4
METHODS:
  RVA=0x08859204  token=0x6000D6E  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ToolsInfo other)
  RVA=0x08859748  token=0x6000D6F  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HFLayerType
TYPE:  sealed struct
TOKEN: 0x20001B1
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HFLayerType  DEFAULT  // const
  public    static  HoudiniEngineUnity.HFLayerType  HEIGHT  // const
  public    static  HoudiniEngineUnity.HFLayerType  MASK  // const
  public    static  HoudiniEngineUnity.HFLayerType  DETAIL  // const
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeLayer
TYPE:  class
TOKEN: 0x20001B2
SIZE:  0x50
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.String                   _layerName  // 0x10
  public            System.Single                   _strength  // 0x18
  public            System.Boolean                  _uiExpanded  // 0x1c
  public            System.Int32                    _tile  // 0x20
  public            System.Int32                    _xLength  // 0x24
  public            System.Int32                    _yLength  // 0x28
  public            System.Boolean                  _hasLayerAttributes  // 0x2c
  public            UnityEngine.TerrainLayer        _terrainLayer  // 0x30
  public            HoudiniEngineUnity.HFLayerType  _layerType  // 0x38
  public            HoudiniEngineUnity.HEU_DetailPrototype_detailPrototype  // 0x40
  private           HoudiniEngineUnity.HEU_PartData _part  // 0x48
METHODS:
  RVA=0x0885BFF0  token=0x6000D70  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeLayer other)
  RVA=0x03D561E0  token=0x6000D71  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeScatterTrees
TYPE:  class
TOKEN: 0x20001B3
SIZE:  0x58
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo>_treePrototypInfos  // 0x10
  public            UnityEngine.Color32[]           _colors  // 0x18
  public            System.Single[]                 _heightScales  // 0x20
  public            UnityEngine.Color32[]           _lightmapColors  // 0x28
  public            UnityEngine.Vector3[]           _positions  // 0x30
  public            System.Int32[]                  _prototypeIndices  // 0x38
  public            System.Single[]                 _rotations  // 0x40
  public            System.Single[]                 _widthScales  // 0x48
  public            System.Int32[]                  _terrainTiles  // 0x50
METHODS:
  RVA=0x0885C2CC  token=0x6000D72  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeScatterTrees other)
  RVA=0x0350B670  token=0x6000D73  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TreePrototypeInfo
TYPE:  class
TOKEN: 0x20001B4
SIZE:  0x20
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.String                   _prefabPath  // 0x10
  public            System.Single                   _bendfactor  // 0x18
METHODS:
  RVA=0x08859848  token=0x6000D74  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_TreePrototypeInfo other)
  RVA=0x0350B670  token=0x6000D75  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_DetailProperties
TYPE:  class
TOKEN: 0x20001B5
SIZE:  0x20
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.Single                   _detailDistance  // 0x10
  public            System.Single                   _detailDensity  // 0x14
  public            System.Int32                    _detailResolution  // 0x18
  public            System.Int32                    _detailResolutionPerPatch  // 0x1c
METHODS:
  RVA=0x088548FC  token=0x6000D76  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailProperties other)
  RVA=0x03D6D970  token=0x6000D77  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_DetailPrototype
TYPE:  class
TOKEN: 0x20001B6
SIZE:  0x60
IMPLEMENTS: HoudiniEngineUnity.IEquivable`1
FIELDS:
  public            System.String                   _prototypePrefab  // 0x10
  public            System.String                   _prototypeTexture  // 0x18
  public            System.Single                   _bendFactor  // 0x20
  public            UnityEngine.Color               _dryColor  // 0x24
  public            UnityEngine.Color               _healthyColor  // 0x34
  public            System.Single                   _maxHeight  // 0x44
  public            System.Single                   _maxWidth  // 0x48
  public            System.Single                   _minHeight  // 0x4c
  public            System.Single                   _minWidth  // 0x50
  public            System.Single                   _noiseSpread  // 0x54
  public            System.Int32                    _renderMode  // 0x58
METHODS:
  RVA=0x08854B28  token=0x6000D78  System.Void .ctor()
  RVA=0x08854A5C  token=0x6000D79  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailPrototype other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeCache
TYPE:  class
TOKEN: 0x20001B7
SIZE:  0x70
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: HoudiniEngineUnity.IHEU_VolumeCache HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent HoudiniEngineUnity.IEquivable`1
FIELDS:
  private           HoudiniEngineUnity.HEU_GeoNode  _ownerNode  // 0x18
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer>_layers  // 0x20
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer>_updatedLayers  // 0x28
  private           System.Int32                    _tileIndex  // 0x30
  private           System.Boolean                  _isDirty  // 0x34
  private           System.String                   _geoName  // 0x38
  private           System.String                   _objName  // 0x40
  public            System.Boolean                  _uiExpanded  // 0x48
  private           UnityEngine.TerrainData         _terrainData  // 0x50
  private           HoudiniEngineUnity.HEU_VolumeScatterTrees_scatterTrees  // 0x58
  private           HoudiniEngineUnity.HEU_DetailProperties_detailProperties  // 0x60
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x68
PROPERTIES:
  Layers  get=0x03D4EB40
  TileIndex  get=0x03D4ED20
  ObjectName  get=0x03D4E2B0
  GeoName  get=0x03D4E2A0
  TerrainData  get=0x03D4EAF0
  ScatterTrees  get=0x03D4EAA0
  DetailProperties  get=0x03D4EB00
  ParentAsset  get=0x03D4EAB0
  IsDirty  get=0x03D4F570  set=0x03D4F590
  UIExpanded  get=0x03D4EFE0  set=0x03D4F010
METHODS:
  RVA=0x0885A4BC  token=0x6000D86  HoudiniEngineUnity.HEU_SessionBase GetSession()
  RVA=0x0885B5A8  token=0x6000D87  System.Void Recook()
  RVA=0x0885B610  token=0x6000D88  System.Void ResetParameters()
  RVA=0x0885A310  token=0x6000D89  HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName)
  RVA=0x0885B2E4  token=0x6000D8A  System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset)
  RVA=0x0885995C  token=0x6000D8B  System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset)
  RVA=0x0885B880  token=0x6000D8C  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> UpdateVolumeCachesFromParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> volumeCaches)
  RVA=0x0885A550  token=0x6000D8D  System.Void Initialize(HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Int32 tileIndex)
  RVA=0x0885B77C  token=0x6000D8E  System.Void StartUpdateLayers()
  RVA=0x08859FAC  token=0x6000D8F  System.Void FinishUpdateLayers()
  RVA=0x0885A450  token=0x6000D90  System.Void GetPartLayerAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer)
  RVA=0x0885B0A0  token=0x6000D91  System.Boolean LoadLayerTextureFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Texture2D& outTexture)
  RVA=0x0885ABA8  token=0x6000D92  System.Boolean LoadLayerFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue)
  RVA=0x0885AA3C  token=0x6000D93  System.Boolean LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue)
  RVA=0x0885B190  token=0x6000D94  System.Boolean LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue)
  RVA=0x0885B7F4  token=0x6000D95  System.Void UpdateLayerFromPart(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_PartData part)
  RVA=0x08859FDC  token=0x6000D96  System.Void GenerateTerrainWithAlphamaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.Boolean bRebuild)
  RVA=0x0885ACA0  token=0x6000D97  System.Void LoadLayerPropertiesFromAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer, System.Boolean bNewTerrainLayer, UnityEngine.Texture2D defaultTexture)
  RVA=0x0885B56C  token=0x6000D98  System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, System.Boolean throwWarningIfNoTileAttribute)
  RVA=0x0885B2A8  token=0x6000D99  System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer)
  RVA=0x08859D68  token=0x6000D9A  System.Void CopyValuesTo(HoudiniEngineUnity.HEU_VolumeCache destCache)
  RVA=0x08859BEC  token=0x6000D9B  System.Void CopyDetailProperties(HoudiniEngineUnity.HEU_DetailProperties srcProp, HoudiniEngineUnity.HEU_DetailProperties destProp)
  RVA=0x08859C1C  token=0x6000D9C  System.Void CopyLayer(HoudiniEngineUnity.HEU_VolumeLayer srcLayer, HoudiniEngineUnity.HEU_VolumeLayer destLayer)
  RVA=0x08859CF8  token=0x6000D9D  System.Void CopyPrototype(HoudiniEngineUnity.HEU_DetailPrototype srcProto, HoudiniEngineUnity.HEU_DetailPrototype destProto)
  RVA=0x0885A9D4  token=0x6000D9E  UnityEngine.Texture2D LoadDefaultSplatTexture()
  RVA=0x0885A908  token=0x6000D9F  UnityEngine.Texture2D LoadAssetTexture(System.String path)
  RVA=0x0885A640  token=0x6000DA0  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeCache other)
  RVA=0x0885BF6C  token=0x6000DA1  System.Void .ctor()
END_CLASS

