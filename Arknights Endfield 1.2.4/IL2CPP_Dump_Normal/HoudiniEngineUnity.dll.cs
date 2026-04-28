// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.dll
// Classes:  439
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002
    public sealed class <>f__AnonymousType0`2
    {
        // Fields
        private readonly <owner>j__TPar <owner>i__Field;  // 0x0
        private readonly <houdiniVersionRequired>j__TPar <houdiniVersionRequired>i__Field;  // 0x0

        // Properties
        <owner>j__TPar owner { get; /* RVA: -1  // not resolved */ }
        <houdiniVersionRequired>j__TPar houdiniVersionRequired { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000003
        public System.Void .ctor(<owner>j__TPar owner, <houdiniVersionRequired>j__TPar houdiniVersionRequired) { }
        // RVA: -1  // not resolved  token: 0x6000004
        public virtual System.Boolean Equals(System.Object value) { }
        // RVA: -1  // not resolved  token: 0x6000005
        public virtual System.Int32 GetHashCode() { }
        // RVA: -1  // not resolved  token: 0x6000006
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000003  // size: 0x18
    public class HEU_BoundingVolume : UnityEngine.MonoBehaviour
    {
        // Properties
        UnityEngine.Collider BoundingCollider { get; /* RVA: 0x087D35D8 */ }

        // Methods
        // RVA: 0x087D33A0  token: 0x6000008
        public System.Collections.Generic.List<UnityEngine.GameObject> GetAllIntersectingObjects() { }
        // RVA: 0x0426FE60  token: 0x6000009
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class HEU_ExampleEvergreenQuery
    {
        // Methods
        // RVA: 0x087D899C  token: 0x600000A
        public static System.Void StartQuery() { }
        // RVA: 0x087D8694  token: 0x600000B
        public static HoudiniEngineUnity.HEU_HoudiniAsset QueryHoudiniAsset(UnityEngine.GameObject rootGO) { }
        // RVA: 0x087D836C  token: 0x600000C
        public static System.Void CookAsset(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset) { }
        // RVA: 0x087D7FFC  token: 0x600000D
        public static System.Void ChangeParmsAndCook(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset) { }
        // RVA: 0x087D8810  token: 0x600000E
        public static System.Void QueryObjects(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset) { }
        // RVA: 0x087D85D0  token: 0x600000F
        public static System.Void QueryGeoParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo) { }
        // RVA: 0x087D888C  token: 0x6000010
        public static System.Void QueryPartAttributeByOwner(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.Int32 count, System.Text.StringBuilder sb) { }
        // RVA: 0x087D8380  token: 0x6000011
        public static System.Void QueryAttributeByStorageType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String attrName) { }
        // RVA: 0x087D8504  token: 0x6000012
        public static System.Void QueryAttribute(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.String objName, System.String geoName, System.Int32 partID, System.String attrName) { }
        // RVA: 0x0350B670  token: 0x6000013
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x18
    public class HEU_ExampleInstanceCustomAttribute : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x087D8B7C  token: 0x6000014
        private System.Void InstancerCallback() { }
        // RVA: -1  // generic def  token: 0x6000015
        private static System.Void LogArray(System.String name, T[] arr, System.Int32 tupleSize) { }
        // RVA: 0x087D8EFC  token: 0x6000016
        private static System.Void LogAttr(HoudiniEngineUnity.HEU_OutputAttribute outAttr) { }
        // RVA: 0x0426FE60  token: 0x6000017
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class HEU_ScriptCallbackExample : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String _msg;  // 0x18

        // Methods
        // RVA: 0x087EF628  token: 0x6000018
        private System.Void AssetCallbackWithMsg(System.String msg) { }
        // RVA: 0x087EF5D4  token: 0x6000019
        private System.Void AssetCallbackNoMsg() { }
        // RVA: 0x0426FE60  token: 0x600001A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct OutputMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HEU_ScriptMeshInputUVLayoutExample.OutputMode COPY;  // const
        public static HEU_ScriptMeshInputUVLayoutExample.OutputMode REPLACE;  // const

    }

    // TypeToken: 0x2000007  // size: 0x10
    public class HEU_ScriptMeshInputUVLayoutExample
    {
        // Methods
        // RVA: 0x087EF6AC  token: 0x600001B
        public static System.Void ApplyUVLayoutTo(UnityEngine.GameObject[] gameObjects, HEU_ScriptMeshInputUVLayoutExample.OutputMode outputMode, System.String output_name_suffix) { }
        // RVA: 0x0350B670  token: 0x600001C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x30
    public class HEU_ScriptParameterExample : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject _evergreenGameObject;  // 0x18
        private HoudiniEngineUnity.HEU_HoudiniAsset _evergreenAsset;  // 0x20
        public System.Single _updateRate;  // 0x28
        public System.Single _scale;  // 0x2c

        // Methods
        // RVA: 0x087EF80C  token: 0x600001D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x18
    public class HEU_AssetEventReceiverTest : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x087D2334  token: 0x600001E
        public System.Void ReloadCallback(HoudiniEngineUnity.HEU_ReloadEventData Data) { }
        // RVA: 0x087D21D0  token: 0x600001F
        public System.Void CookedCallback(HoudiniEngineUnity.HEU_CookedEventData Data) { }
        // RVA: 0x087D206C  token: 0x6000020
        public System.Void BakedCallback(HoudiniEngineUnity.HEU_BakedEventData Data) { }
        // RVA: 0x0426FE60  token: 0x6000021
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x14
    public sealed struct CurveEditState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState INVALID;  // const
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState GENERATED;  // const
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState EDITING;  // const
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState REQUIRES_GENERATION;  // const

    }

    // TypeToken: 0x2000026  // size: 0x14
    public sealed struct Interaction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_Curve.Interaction VIEW;  // const
        public static HoudiniEngineUnity.HEU_Curve.Interaction ADD;  // const
        public static HoudiniEngineUnity.HEU_Curve.Interaction EDIT;  // const

    }

    // TypeToken: 0x2000027  // size: 0x14
    public sealed struct CurveDrawCollision
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_Curve.CurveDrawCollision COLLIDERS;  // const
        public static HoudiniEngineUnity.HEU_Curve.CurveDrawCollision LAYERMASK;  // const

    }

    // TypeToken: 0x2000028  // size: 0x18
    public sealed class <>c__DisplayClass59_0
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> points;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000A0
        public System.Void .ctor() { }
        // RVA: 0x087EFCB4  token: 0x60000A1
        private System.Void <GetAllPoints>b__0(HoudiniEngineUnity.CurveNodeData transform) { }

    }

    // TypeToken: 0x2000029  // size: 0x40
    public sealed class <>c__DisplayClass86_0
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> positions;  // 0x10
        public System.Boolean hasRotations;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Quaternion> rotations;  // 0x20
        public System.Boolean hasScales;  // 0x28
        public System.Collections.Generic.List<UnityEngine.Vector3> scales;  // 0x30
        public System.Collections.Generic.List<System.Int32> curveCountIndices;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x60000A2
        public System.Void .ctor() { }
        // RVA: 0x087EFD24  token: 0x60000A3
        private System.Void <UpdateCurveInputForCurveParts>b__0(HoudiniEngineUnity.CurveNodeData data) { }

    }

    // TypeToken: 0x200002A  // size: 0x28
    public sealed class <>c__DisplayClass87_0
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> positions;  // 0x10
        public System.Collections.Generic.List<UnityEngine.Quaternion> rotations;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Vector3> scales;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60000A4
        public System.Void .ctor() { }
        // RVA: 0x087EFE44  token: 0x60000A5
        private System.Void <UpdateCurveInputForCustomAttributes>b__0(HoudiniEngineUnity.CurveNodeData data) { }
        // RVA: 0x087EFF34  token: 0x60000A6
        private System.Void <UpdateCurveInputForCustomAttributes>b__1(System.Int32 nIndex1, System.Int32 nIndex2, System.Single fCoeff, System.Int32 nInsertIndex) { }
        // RVA: 0x087F0224  token: 0x60000A7
        private System.Void <UpdateCurveInputForCustomAttributes>b__2(System.Int32 nIndex, System.Int32 nInsertIndex) { }

    }

    // TypeToken: 0x200002B  // size: 0x20
    public sealed class <>c__DisplayClass89_0
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> rotations;  // 0x10
        public System.Collections.Generic.List<UnityEngine.Vector3> scales;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000A8
        public System.Void .ctor() { }
        // RVA: 0x087F041C  token: 0x60000A9
        private System.Void <UpdatePoints>b__0(HoudiniEngineUnity.CurveNodeData data) { }

    }

    // TypeToken: 0x2000030  // size: 0x14
    public sealed struct HEU_AssetType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_INVALID;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_HDA;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_CURVE;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_INPUT;  // const

    }

    // TypeToken: 0x2000031  // size: 0x14
    public sealed struct AssetBuildAction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction NONE;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction RELOAD;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction COOK;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction INVALID;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction STRIP_HEDATA;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction DUPLICATE;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction RESET_PARAMS;  // const

    }

    // TypeToken: 0x2000032  // size: 0x14
    public sealed struct AssetCookStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus NONE;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus COOKING;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus POSTCOOK;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus LOADING;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus POSTLOAD;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus PRELOAD;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus SELECT_SUBASSET;  // const

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct AssetCookResult
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult NONE;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult SUCCESS;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult ERRORED;  // const

    }

    // TypeToken: 0x2000034  // size: 0x80
    public sealed class UpdateUIDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x6000206
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000207
        public virtual System.Void Invoke() { }
        // RVA: 0x042BE018  token: 0x6000208
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000209
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000035  // size: 0x14
    public sealed struct AssetInstantiationMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod DEFAULT;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod DUPLICATED;  // const
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod UNDO;  // const

    }

    // TypeToken: 0x2000036  // size: 0x18
    public sealed class <>c__DisplayClass266_0
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.TransformData> previousTransformValues;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600020A
        public System.Void .ctor() { }
        // RVA: 0x08804A94  token: 0x600020B
        private System.Void <BakeToExistingPrefab>b__0(UnityEngine.Transform trans) { }

    }

    // TypeToken: 0x2000037  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.HEU_HoudiniAsset.<>c <>9;  // static @ 0x0
        public static System.Func<HoudiniEngineUnity.HEU_InputNode,System.Boolean> <>9__278_0;  // static @ 0x8
        public static System.Func<HoudiniEngineUnity.HEU_ObjectNode,System.Boolean> <>9__316_0;  // static @ 0x10
        public static System.Func<HoudiniEngineUnity.HEU_Curve,System.Boolean> <>9__339_0;  // static @ 0x18
        public static System.Func<HoudiniEngineUnity.HEU_AttributesStore,System.Boolean> <>9__340_0;  // static @ 0x20
        public static System.Func<HoudiniEngineUnity.HEU_Curve,System.Boolean> <>9__377_0;  // static @ 0x28
        public static System.Func<HoudiniEngineUnity.HEU_ObjectNode,System.Boolean> <>9__408_0;  // static @ 0x30
        public static System.Func<HoudiniEngineUnity.HEU_Curve,System.Boolean> <>9__408_1;  // static @ 0x38
        public static System.Func<HoudiniEngineUnity.HEU_MaterialData,System.Boolean> <>9__408_2;  // static @ 0x40

        // Methods
        // RVA: 0x08804E58  token: 0x600020C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600020D
        public System.Void .ctor() { }
        // RVA: 0x088049B0  token: 0x600020E
        private System.Boolean <GetNonParameterInputNodes>b__278_0(HoudiniEngineUnity.HEU_InputNode node) { }
        // RVA: 0x08804964  token: 0x600020F
        private System.Boolean <DoPostCookWork>b__316_0(HoudiniEngineUnity.HEU_ObjectNode obj) { }
        // RVA: 0x08804A48  token: 0x6000210
        private System.Boolean <UploadCurvesParameters>b__339_0(HoudiniEngineUnity.HEU_Curve curve) { }
        // RVA: 0x088049FC  token: 0x6000211
        private System.Boolean <UploadAttributeValues>b__340_0(HoudiniEngineUnity.HEU_AttributesStore store) { }
        // RVA: 0x0880481C  token: 0x6000212
        private System.Boolean <ClearInvalidCurves>b__377_0(HoudiniEngineUnity.HEU_Curve curve) { }
        // RVA: 0x08804868  token: 0x6000213
        private System.Boolean <ClearInvalidLists>b__408_0(HoudiniEngineUnity.HEU_ObjectNode node) { }
        // RVA: 0x088048B4  token: 0x6000214
        private System.Boolean <ClearInvalidLists>b__408_1(HoudiniEngineUnity.HEU_Curve curve) { }
        // RVA: 0x08804900  token: 0x6000215
        private System.Boolean <ClearInvalidLists>b__408_2(HoudiniEngineUnity.HEU_MaterialData data) { }

    }

    // TypeToken: 0x2000038  // size: 0x28
    public sealed class <>c__DisplayClass409_0
    {
        // Fields
        public HoudiniEngineUnity.HEU_HoudiniAsset newAsset;  // 0x10
        public System.Int32 i;  // 0x18
        public System.Predicate<HoudiniEngineUnity.HEU_Curve> <>9__0;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000216
        public System.Void .ctor() { }
        // RVA: 0x08804B4C  token: 0x6000217
        private System.Boolean <CopyPropertiesTo>b__0(HoudiniEngineUnity.HEU_Curve curve) { }

    }

    // TypeToken: 0x200003B  // size: 0x14
    public sealed struct InputNodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InputNodeType CONNECTION;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputNodeType NODE;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputNodeType PARAMETER;  // const

    }

    // TypeToken: 0x200003C  // size: 0x14
    public sealed struct InputObjectType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType HDA;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType UNITY_MESH;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType CURVE;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType TERRAIN;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType BOUNDING_BOX;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType TILEMAP;  // const

    }

    // TypeToken: 0x200003D  // size: 0x14
    public sealed struct InternalObjectType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InternalObjectType UNKNOWN;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InternalObjectType HDA;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InternalObjectType UNITY_MESH;  // const

    }

    // TypeToken: 0x200003E  // size: 0x14
    public sealed struct InputActions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InputActions ACTION;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputActions DELETE;  // const
        public static HoudiniEngineUnity.HEU_InputNode.InputActions INSERT;  // const

    }

    // TypeToken: 0x2000042  // size: 0x10
    public class HEU_InputObjectUICache
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600027C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x10
    public class HEU_InputAssetUICache
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600027D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x14
    public sealed struct PartOutputType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType NONE;  // const
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType MESH;  // const
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType VOLUME;  // const
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType CURVE;  // const
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType INSTANCER;  // const

    }

    // TypeToken: 0x200004A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.HEU_PartData.<>c <>9;  // static @ 0x0
        public static System.Comparison<UnityEngine.LOD> <>9__96_0;  // static @ 0x8

        // Methods
        // RVA: 0x08804DF4  token: 0x6000302
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000303
        public System.Void .ctor() { }
        // RVA: 0x0880494C  token: 0x6000304
        private System.Int32 <CopyGameObjectComponents>b__96_0(UnityEngine.LOD a, UnityEngine.LOD b) { }

    }

    // TypeToken: 0x200004B  // size: 0x18
    public sealed class <>c__DisplayClass97_0
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.TransformData> previousTransformValues;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000305
        public System.Void .ctor() { }
        // RVA: 0x08804BCC  token: 0x6000306
        private System.Void <CopyChildGameObjects>b__0(UnityEngine.Transform trans) { }

    }

    // TypeToken: 0x200004C  // size: 0x18
    public sealed class <>c__DisplayClass99_0
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.TransformData> previousTransformValues;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000307
        public System.Void .ctor() { }
        // RVA: 0x08804C84  token: 0x6000308
        private System.Void <BakePartToGameObject>b__0(UnityEngine.Transform trans) { }

    }

    // TypeToken: 0x200004D  // size: 0x18
    public sealed class <>c__DisplayClass99_1
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.TransformData> previousTransformValues;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000309
        public System.Void .ctor() { }
        // RVA: 0x08804D3C  token: 0x600030A
        private System.Void <BakePartToGameObject>b__1(UnityEngine.Transform trans) { }

    }

    // TypeToken: 0x200004F  // size: 0x14
    public sealed struct AttributeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType UNDEFINED;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType BOOL;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType INT;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType FLOAT;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType STRING;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType MAX;  // const

    }

    // TypeToken: 0x2000050  // size: 0x14
    public sealed struct AttributeState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeState INVALID;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeState SYNCED;  // const
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeState LOCAL_DIRTY;  // const

    }

    // TypeToken: 0x2000052  // size: 0x80
    public sealed class SetAttributeValueFunc : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x088205A0  token: 0x6000342
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01028930  token: 0x6000343
        public virtual System.Void Invoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x088204D4  token: 0x6000344
        public virtual System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000345
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000057  // size: 0x14
    public sealed struct HEU_ImportAssetOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions Default;  // const
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ForceUpdate;  // const
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ForceSynchronousImport;  // const
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ImportRecursive;  // const
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions DontDownloadFromCacheServer;  // const
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ForceUncompressedImport;  // const

    }

    // TypeToken: 0x200005D  // size: 0x14
    public sealed struct RegSAM
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM QueryValue;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM SetValue;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM CreateSubKey;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM EnumerateSubKeys;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Notify;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM CreateLink;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM WOW64_32Key;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM WOW64_64Key;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM WOW64_Res;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Read;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Write;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Execute;  // const
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM AllAccess;  // const

    }

    // TypeToken: 0x2000060  // size: 0x14
    public sealed struct DataType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType BOOL;  // const
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType INT;  // const
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType LONG;  // const
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType FLOAT;  // const
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType STRING;  // const

    }

    // TypeToken: 0x2000061  // size: 0x20
    public class StoreData
    {
        // Fields
        public HoudiniEngineUnity.HEU_PluginStorage.DataType _type;  // 0x10
        public System.String _valueStr;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60004AE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class StoreDataArray`1
    {
        // Fields
        public T[] _array;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60004AF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x14
    public sealed struct HEU_HandleType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_Handle.HEU_HandleType XFORM;  // const
        public static HoudiniEngineUnity.HEU_Handle.HEU_HandleType UNSUPPORTED;  // const

    }

    // TypeToken: 0x2000066  // size: 0x14
    public sealed struct HEU_HandleParamType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType TRANSLATE;  // const
        public static HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType ROTATE;  // const
        public static HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType SCALE;  // const

    }

    // TypeToken: 0x20000C3  // size: 0x14
    public sealed struct ModifierAction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction MULTIPARM_INSERT;  // const
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction MULTIPARM_REMOVE;  // const
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction MULTIPARM_CLEAR;  // const
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction SET_FLOAT;  // const
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction SET_INT;  // const

    }

    // TypeToken: 0x20000C5  // size: 0x20
    public sealed class <>c__DisplayClass82_0
    {
        // Fields
        public System.Int32 parentID;  // 0x10
        public System.Predicate<HoudiniEngineUnity.HAPI_ParmInfo> <>9__0;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000592
        public System.Void .ctor() { }
        // RVA: 0x05CEC5C4  token: 0x6000593
        private System.Boolean <Initialize>b__0(HoudiniEngineUnity.HAPI_ParmInfo p) { }

    }

    // TypeToken: 0x20000C6  // size: 0x20
    public sealed class <>c__DisplayClass83_0
    {
        // Fields
        public System.Int32 parentID;  // 0x10
        public System.Predicate<HoudiniEngineUnity.HAPI_ParmInfo> <>9__0;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000594
        public System.Void .ctor() { }
        // RVA: 0x05CEC5C4  token: 0x6000595
        private System.Boolean <Initialize4HGTool>b__0(HoudiniEngineUnity.HAPI_ParmInfo p) { }

    }

    // TypeToken: 0x20000CB  // size: 0x14
    public sealed struct LinkState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState INACTIVE;  // const
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LINKING;  // const
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LINKED;  // const
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState ERROR_NOT_LINKED;  // const

    }

    // TypeToken: 0x20000CC  // size: 0x80
    public sealed class UpdateUIDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x60005FA
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x60005FB
        public virtual System.Void Invoke() { }
        // RVA: 0x042BE018  token: 0x60005FC
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x60005FD
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000CD  // size: 0x28
    public sealed class <>c__DisplayClass107_0
    {
        // Fields
        public HoudiniEngineUnity.HEU_PDGAssetLink <>4__this;  // 0x10
        public System.Action<HoudiniEngineUnity.HEU_TOPNodeData,HoudiniEngineUnity.HEU_SyncedEventData> OnSynced;  // 0x18
        public HoudiniEngineUnity.HEU_TOPNodeData topNode;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60005FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE  // size: 0x20
    public sealed class <>c__DisplayClass107_1
    {
        // Fields
        public HoudiniEngineUnity.HEU_GeoSync geoSync;  // 0x10
        public HoudiniEngineUnity.HEU_PDGAssetLink.<>c__DisplayClass107_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60005FF
        public System.Void .ctor() { }
        // RVA: 0x0882F84C  token: 0x6000600
        private System.Void <LoadResults>b__0(HoudiniEngineUnity.HEU_SyncedEventData Data) { }

    }

    // TypeToken: 0x20000D2  // size: 0x14
    public sealed struct PDGState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState NONE;  // const
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState DIRTIED;  // const
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState DIRTYING;  // const
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState COOKING;  // const
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState COOK_COMPLETE;  // const
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState COOK_FAILED;  // const

    }

    // TypeToken: 0x20000D6  // size: 0x80
    public sealed class OnWorkItemLoadResultsDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056E13A4  token: 0x6000636
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000637
        public virtual System.Void Invoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced) { }
        // RVA: 0x0389C3B0  token: 0x6000638
        public virtual System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000639
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000D7  // size: 0x14
    public sealed struct EventMessageColor
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_PDGSession.EventMessageColor DEFAULT;  // const
        public static HoudiniEngineUnity.HEU_PDGSession.EventMessageColor WARNING;  // const
        public static HoudiniEngineUnity.HEU_PDGSession.EventMessageColor ERROR;  // const

    }

    // TypeToken: 0x20000D8  // size: 0x28
    public sealed class <>c__DisplayClass35_0
    {
        // Fields
        public System.Int32[] allNetworkNodeIds;  // 0x10
        public System.Int32 idx;  // 0x18
        public System.Predicate<System.Int32> <>9__0;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600063A
        public System.Void .ctor() { }
        // RVA: 0x0882F924  token: 0x600063B
        private System.Boolean <GetNonBypassedNetworkIds>b__0(System.Int32 id) { }

    }

    // TypeToken: 0x20000F2  // size: 0x14
    public sealed struct Source
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_MaterialData.Source DEFAULT;  // const
        public static HoudiniEngineUnity.HEU_MaterialData.Source HOUDINI;  // const
        public static HoudiniEngineUnity.HEU_MaterialData.Source UNITY;  // const
        public static HoudiniEngineUnity.HEU_MaterialData.Source SUBSTANCE;  // const

    }

    // TypeToken: 0x20000FB  // size: 0x80
    public sealed class CreateSessionFromTypeDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06E93748  token: 0x600091D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0102B410  token: 0x600091E
        public virtual HoudiniEngineUnity.HEU_SessionBase Invoke(System.Type type) { }
        // RVA: 0x0389C3B0  token: 0x600091F
        public virtual System.IAsyncResult BeginInvoke(System.Type type, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04276D7C  token: 0x6000920
        public virtual HoudiniEngineUnity.HEU_SessionBase EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000FE  // size: 0x14
    public sealed struct Status
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Stopped;  // const
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Started;  // const
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Connecting;  // const
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Initializing;  // const
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Connected;  // const

    }

    // TypeToken: 0x2000100  // size: 0x80
    public sealed class AssetSyncCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056E13A4  token: 0x600092D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600092E
        public virtual System.Void Invoke(HoudiniEngineUnity.HEU_AssetSync assetSync) { }
        // RVA: 0x0389C3B0  token: 0x600092F
        public virtual System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AssetSync assetSync, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000930
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000107  // size: 0x14
    public sealed struct TaskStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_Task.TaskStatus NONE;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskStatus PENDING_START;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskStatus STARTED;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskStatus REQUIRE_UPDATE;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskStatus PENDING_COMPLETE;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskStatus COMPLETED;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskStatus UNUSED;  // const

    }

    // TypeToken: 0x2000108  // size: 0x14
    public sealed struct TaskResult
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_Task.TaskResult NONE;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskResult SUCCESS;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskResult FAILED;  // const
        public static HoudiniEngineUnity.HEU_Task.TaskResult KILLED;  // const

    }

    // TypeToken: 0x2000109  // size: 0x80
    public sealed class TaskCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056E13A4  token: 0x600096A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600096B
        public virtual System.Void Invoke(HoudiniEngineUnity.HEU_Task task) { }
        // RVA: 0x0389C3B0  token: 0x600096C
        public virtual System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_Task task, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600096D
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200010B  // size: 0x14
    public sealed struct BuildType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType NONE;  // const
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType LOAD;  // const
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType COOK;  // const
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType RELOAD;  // const

    }

    // TypeToken: 0x2000114  // size: 0x14
    public sealed struct LoadType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType FILE;  // const
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType NODE;  // const
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType ASSET;  // const

    }

    // TypeToken: 0x2000116  // size: 0x14
    public sealed struct LoadStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus NONE;  // const
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus STARTED;  // const
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus SUCCESS;  // const
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus ERROR;  // const

    }

    // TypeToken: 0x2000115  // size: 0x38
    public class HEU_LoadData
    {
        // Fields
        public System.Int32 _cookNodeID;  // 0x10
        public HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus _loadStatus;  // 0x14
        public System.Text.StringBuilder _logStr;  // 0x18
        public HoudiniEngineUnity.HEU_SessionBase _session;  // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject> _loadedObjects;  // 0x28
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> _idBuffersMap;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x60009C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000117  // size: 0x30
    public class HEU_LoadObject
    {
        // Fields
        public System.Int32 _objectNodeID;  // 0x10
        public System.Int32 _displayNodeID;  // 0x14
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> _terrainBuffers;  // 0x18
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh> _meshBuffers;  // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer> _instancerBuffers;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60009C2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000118  // size: 0x14
    public sealed struct HEU_LoadCallbackType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType PRECOOK;  // const
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType POSTCOOK;  // const

    }

    // TypeToken: 0x2000119  // size: 0x80
    public sealed class HEU_LoadCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x08162834  token: 0x60009C3
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x60009C4
        public virtual System.Void Invoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType) { }
        // RVA: 0x0883F9A4  token: 0x60009C5
        public virtual System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x60009C6
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200011D  // size: 0x14
    public sealed struct HEU_ReplacePrefabOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions Default;  // const
        public static HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions ConnectToPrefab;  // const
        public static HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions ReplaceNameBased;  // const

    }

    // TypeToken: 0x2000123
    public sealed class GetArray1ArgDel`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000A8A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000A8B
        public virtual System.Boolean Invoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length) { }
        // RVA: -1  // runtime  token: 0x6000A8C
        public virtual System.IAsyncResult BeginInvoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000A8D
        public virtual System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000124
    public sealed class GetArray2ArgDel`2 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000A8E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000A8F
        public virtual System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length) { }
        // RVA: -1  // runtime  token: 0x6000A90
        public virtual System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000A91
        public virtual System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000125
    public sealed class GetArray3ArgDel`3 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000A92
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000A93
        public virtual System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length) { }
        // RVA: -1  // runtime  token: 0x6000A94
        public virtual System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000A95
        public virtual System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000126
    public sealed class GetAttributeArrayInputFunc`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000A96
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000A97
        public virtual System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end) { }
        // RVA: -1  // runtime  token: 0x6000A98
        public virtual System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000A99
        public virtual System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& info, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000127
    public sealed class SetAttributeArrayFunc`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000A9A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000A9B
        public virtual System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end) { }
        // RVA: -1  // runtime  token: 0x6000A9C
        public virtual System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000A9D
        public virtual System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200012B  // size: 0x14
    public sealed struct ColliderType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType NONE;  // const
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType BOX;  // const
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SPHERE;  // const
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType MESH;  // const
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SIMPLE_BOX;  // const
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SIMPLE_SPHERE;  // const
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SIMPLE_CAPSULE;  // const

    }

    // TypeToken: 0x200012A  // size: 0x58
    public class HEU_ColliderInfo
    {
        // Fields
        public HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType _colliderType;  // 0x10
        public UnityEngine.Vector3 _colliderCenter;  // 0x14
        public UnityEngine.Vector3 _colliderSize;  // 0x20
        public System.Single _colliderRadius;  // 0x2c
        public System.Boolean _convexCollider;  // 0x30
        public System.String _collisionGroupName;  // 0x38
        public UnityEngine.Vector3[] _collisionVertices;  // 0x40
        public System.Int32[] _collisionIndices;  // 0x48
        public UnityEngine.MeshTopology _meshTopology;  // 0x50
        public System.Boolean _isTrigger;  // 0x54

        // Methods
        // RVA: 0x0350B670  token: 0x6000AB9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200012C  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.HEU_GenerateGeoCache.<>c <>9;  // static @ 0x0
        public static System.Predicate<UnityEngine.Material> <>9__63_0;  // static @ 0x8
        public static System.Comparison<System.Single> <>9__65_0;  // static @ 0x10

        // Methods
        // RVA: 0x08854750  token: 0x6000ABA
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000ABB
        public System.Void .ctor() { }
        // RVA: 0x08854704  token: 0x6000ABC
        private System.Boolean <GetFinalMaterialsFromComparingNewWithPrevious>b__63_0(UnityEngine.Material material) { }
        // RVA: 0x088546E8  token: 0x6000ABD
        private System.Int32 <GenerateLODMeshesFromGeoGroups>b__65_0(System.Single a, System.Single b) { }

    }

    // TypeToken: 0x2000134  // size: 0x28
    public class HEU_InputDataMeshes : HoudiniEngineUnity.HEU_InputData
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh> _inputMeshes;  // 0x18
        public System.Boolean _hasLOD;  // 0x20

        // Methods
        // RVA: 0x088465BC  token: 0x6000AE0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000135  // size: 0x14
    public sealed struct HEU_InputColliderType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType NONE;  // const
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType BOX;  // const
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType SPHERE;  // const
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType CAPSULE;  // const
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType MESH;  // const

    }

    // TypeToken: 0x2000136  // size: 0x20
    public class HEU_InputDataCollider
    {
        // Fields
        public UnityEngine.Collider _collider;  // 0x10
        public HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType _colliderType;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000AE1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000137  // size: 0x60
    public class HEU_InputDataMesh
    {
        // Fields
        public UnityEngine.Mesh _mesh;  // 0x10
        public UnityEngine.Material[] _materials;  // 0x18
        public System.String _meshPath;  // 0x20
        public System.String _meshName;  // 0x28
        public System.Int32 _numVertices;  // 0x30
        public System.Int32 _numSubMeshes;  // 0x34
        public System.UInt32[] _indexStart;  // 0x38
        public System.UInt32[] _indexCount;  // 0x40
        public System.Single _LODScreenTransition;  // 0x48
        public UnityEngine.Transform _transform;  // 0x50
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataCollider> _colliders;  // 0x58

        // Methods
        // RVA: 0x0350B670  token: 0x6000AE2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000139  // size: 0x80
    public class HEU_InputDataTerrain : HoudiniEngineUnity.HEU_InputData
    {
        // Fields
        public System.String _heightFieldName;  // 0x18
        public System.Int32 _parentNodeID;  // 0x20
        public System.Single _voxelSize;  // 0x24
        public UnityEngine.Terrain _terrain;  // 0x28
        public UnityEngine.TerrainData _terrainData;  // 0x30
        public System.Int32 _numPointsX;  // 0x38
        public System.Int32 _numPointsY;  // 0x3c
        public HoudiniEngineUnity.HAPI_Transform _transform;  // 0x40
        public System.Single _heightScale;  // 0x68
        public System.Int32 _heightfieldNodeID;  // 0x6c
        public System.Int32 _heightNodeID;  // 0x70
        public System.Int32 _maskNodeID;  // 0x74
        public System.Int32 _mergeNodeID;  // 0x78

        // Methods
        // RVA: 0x08846634  token: 0x6000AF0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200013C  // size: 0x28
    public class HEU_InputDataTilemap : HoudiniEngineUnity.HEU_InputData
    {
        // Fields
        public UnityEngine.Tilemaps.Tilemap _tilemap;  // 0x18
        public UnityEngine.Transform _transform;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000AF8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000146  // size: 0x14
    public sealed struct ToolType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType GENERATOR;  // const
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType OPERATOR_SINGLE;  // const
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType OPERATOR_MULTI;  // const
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType BATCH;  // const

    }

    // TypeToken: 0x2000149  // size: 0x18
    public sealed class <>c__DisplayClass19_0
    {
        // Fields
        public System.String shelfName;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000B59
        public System.Void .ctor() { }
        // RVA: 0x05A49258  token: 0x6000B5A
        private System.Boolean <AddShelf>b__0(HoudiniEngineUnity.HEU_Shelf shelf) { }

    }

    // TypeToken: 0x200014E  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.JSONNode.Enumerator.Type None;  // const
        public static HoudiniEngineUnity.JSONNode.Enumerator.Type Array;  // const
        public static HoudiniEngineUnity.JSONNode.Enumerator.Type Object;  // const

    }

    // TypeToken: 0x200014D  // size: 0x58
    public sealed struct Enumerator
    {
        // Fields
        private HoudiniEngineUnity.JSONNode.Enumerator.Type type;  // 0x10
        private System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> m_Object;  // 0x18
        private System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> m_Array;  // 0x40

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0426F724 */ }
        System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> Current { get; /* RVA: 0x08854858 */ }

        // Methods
        // RVA: 0x08854824  token: 0x6000BBF
        public System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum) { }
        // RVA: 0x03B109F0  token: 0x6000BC0
        public System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum) { }
        // RVA: 0x088547B4  token: 0x6000BC2
        public System.Boolean MoveNext() { }

    }

    // TypeToken: 0x200014F  // size: 0x58
    public sealed struct ValueEnumerator
    {
        // Fields
        private HoudiniEngineUnity.JSONNode.Enumerator m_Enumerator;  // 0x10

        // Properties
        HoudiniEngineUnity.JSONNode Current { get; /* RVA: 0x08867B98 */ }

        // Methods
        // RVA: 0x0885EBAC  token: 0x6000BC3
        public System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum) { }
        // RVA: 0x0885EAD8  token: 0x6000BC4
        public System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum) { }
        // RVA: 0x0885EB78  token: 0x6000BC5
        public System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator) { }
        // RVA: 0x0885EAD0  token: 0x6000BC7
        public System.Boolean MoveNext() { }
        // RVA: 0x03D6D9B0  token: 0x6000BC8
        public HoudiniEngineUnity.JSONNode.ValueEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000150  // size: 0x58
    public sealed struct KeyEnumerator
    {
        // Fields
        private HoudiniEngineUnity.JSONNode.Enumerator m_Enumerator;  // 0x10

        // Properties
        System.String Current { get; /* RVA: 0x0885EC44 */ }

        // Methods
        // RVA: 0x0885EBAC  token: 0x6000BC9
        public System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum) { }
        // RVA: 0x0885EAD8  token: 0x6000BCA
        public System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum) { }
        // RVA: 0x0885EB78  token: 0x6000BCB
        public System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator) { }
        // RVA: 0x0885EAD0  token: 0x6000BCD
        public System.Boolean MoveNext() { }
        // RVA: 0x03D6D9B0  token: 0x6000BCE
        public HoudiniEngineUnity.JSONNode.KeyEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000151  // size: 0x60
    public class LinqEnumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private HoudiniEngineUnity.JSONNode m_Node;  // 0x10
        private HoudiniEngineUnity.JSONNode.Enumerator m_Enumerator;  // 0x18

        // Properties
        System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> Current { get; /* RVA: 0x0885EED4 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x0885EE00 */ }

        // Methods
        // RVA: 0x0885EE58  token: 0x6000BCF
        private System.Void .ctor(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x0885ED24  token: 0x6000BD2
        public virtual System.Boolean MoveNext() { }
        // RVA: 0x0885EC84  token: 0x6000BD3
        public virtual System.Void Dispose() { }
        // RVA: 0x0885ECC0  token: 0x6000BD4
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> GetEnumerator() { }
        // RVA: 0x0885ED30  token: 0x6000BD5
        public virtual System.Void Reset() { }
        // RVA: 0x0885ED9C  token: 0x6000BD6
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000152  // size: 0x28
    public sealed class <get_Children>d__40 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private HoudiniEngineUnity.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20

        // Properties
        HoudiniEngineUnity.JSONNode System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000BD7
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000BD8
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03D4C410  token: 0x6000BD9
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x088674F4  token: 0x6000BDB
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x08867474  token: 0x6000BDD
        private virtual System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator() { }
        // RVA: 0x088674EC  token: 0x6000BDE
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000153  // size: 0x40
    public sealed class <get_DeepChildren>d__42 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private HoudiniEngineUnity.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public HoudiniEngineUnity.JSONNode <>4__this;  // 0x28
        private System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> <>7__wrap1;  // 0x30
        private System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> <>7__wrap2;  // 0x38

        // Properties
        HoudiniEngineUnity.JSONNode System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000BDF
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x08867A18  token: 0x6000BE0
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08867540  token: 0x6000BE1
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08867B04  token: 0x6000BE2
        private System.Void <>m__Finally1() { }
        // RVA: 0x08867B4C  token: 0x6000BE3
        private System.Void <>m__Finally2() { }
        // RVA: 0x088679CC  token: 0x6000BE5
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x08867938  token: 0x6000BE7
        private virtual System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator() { }
        // RVA: 0x088679C4  token: 0x6000BE8
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000155  // size: 0x48
    public sealed class <get_Children>d__22 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private HoudiniEngineUnity.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public HoudiniEngineUnity.JSONArray <>4__this;  // 0x28
        private System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> <>7__wrap1;  // 0x30

        // Properties
        HoudiniEngineUnity.JSONNode System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000BF9
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x08866FB8  token: 0x6000BFA
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x08866C90  token: 0x6000BFB
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08867030  token: 0x6000BFC
        private System.Void <>m__Finally1() { }
        // RVA: 0x08866F6C  token: 0x6000BFE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x08866ED8  token: 0x6000C00
        private virtual System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator() { }
        // RVA: 0x08866F64  token: 0x6000C01
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000157  // size: 0x18
    public sealed class <>c__DisplayClass21_0
    {
        // Fields
        public HoudiniEngineUnity.JSONNode aNode;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000C13
        public System.Void .ctor() { }
        // RVA: 0x08866540  token: 0x6000C14
        private System.Boolean <Remove>b__0(System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> k) { }

    }

    // TypeToken: 0x2000158  // size: 0x58
    public sealed class <get_Children>d__23 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private HoudiniEngineUnity.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public HoudiniEngineUnity.JSONObject <>4__this;  // 0x28
        private System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> <>7__wrap1;  // 0x30

        // Properties
        HoudiniEngineUnity.JSONNode System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000C15
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x088673C0  token: 0x6000C16
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0886706C  token: 0x6000C17
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x08867438  token: 0x6000C18
        private System.Void <>m__Finally1() { }
        // RVA: 0x08867374  token: 0x6000C1A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x088672E0  token: 0x6000C1C
        private virtual System.Collections.Generic.IEnumerator<HoudiniEngineUnity.JSONNode> System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode>.GetEnumerator() { }
        // RVA: 0x0886736C  token: 0x6000C1D
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000164
    public class RequireStruct`1
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000C9E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000165
    public class RequireClass`1
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000C9F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000178  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_LODGroup_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.LODGroup,HoudiniEngineUnity.Test_LODGroup> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.LODGroup,HoudiniEngineUnity.Test_LODGroup> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866B64  token: 0x6000CBE
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CBF
        public System.Void .ctor() { }
        // RVA: 0x08865944  token: 0x6000CC0
        private HoudiniEngineUnity.Test_LODGroup <ToTestObject>b__1_0(UnityEngine.LODGroup lod) { }
        // RVA: 0x08865EE4  token: 0x6000CC1
        private HoudiniEngineUnity.Test_LODGroup <ToTestObject>b__2_0(UnityEngine.LODGroup lod) { }

    }

    // TypeToken: 0x200017B  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Transform_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Transform,HoudiniEngineUnity.Test_Transform> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Transform,HoudiniEngineUnity.Test_Transform> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866650  token: 0x6000CC8
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CC9
        public System.Void .ctor() { }
        // RVA: 0x08865A04  token: 0x6000CCA
        private HoudiniEngineUnity.Test_Transform <ToTestObject>b__1_0(UnityEngine.Transform lod) { }
        // RVA: 0x088663C0  token: 0x6000CCB
        private HoudiniEngineUnity.Test_Transform <ToTestObject>b__2_0(UnityEngine.Transform lod) { }

    }

    // TypeToken: 0x200017E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Material_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Material,HoudiniEngineUnity.Test_Material> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Material,HoudiniEngineUnity.Test_Material> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x088666B4  token: 0x6000CD2
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CD3
        public System.Void .ctor() { }
        // RVA: 0x08865B24  token: 0x6000CD4
        private HoudiniEngineUnity.Test_Material <ToTestObject>b__1_0(UnityEngine.Material lod) { }
        // RVA: 0x08865FA4  token: 0x6000CD5
        private HoudiniEngineUnity.Test_Material <ToTestObject>b__2_0(UnityEngine.Material lod) { }

    }

    // TypeToken: 0x2000181  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Collider_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Collider,HoudiniEngineUnity.Test_Collider> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Collider,HoudiniEngineUnity.Test_Collider> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x0886677C  token: 0x6000CDC
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CDD
        public System.Void .ctor() { }
        // RVA: 0x08865888  token: 0x6000CDE
        private HoudiniEngineUnity.Test_Collider <ToTestObject>b__1_0(UnityEngine.Collider lod) { }
        // RVA: 0x088660C4  token: 0x6000CDF
        private HoudiniEngineUnity.Test_Collider <ToTestObject>b__2_0(UnityEngine.Collider lod) { }

    }

    // TypeToken: 0x2000184  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_BoxCollider_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.BoxCollider,HoudiniEngineUnity.Test_BoxCollider> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.BoxCollider,HoudiniEngineUnity.Test_BoxCollider> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866588  token: 0x6000CE6
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CE7
        public System.Void .ctor() { }
        // RVA: 0x088659A4  token: 0x6000CE8
        private HoudiniEngineUnity.Test_BoxCollider <ToTestObject>b__1_0(UnityEngine.BoxCollider lod) { }
        // RVA: 0x088664E0  token: 0x6000CE9
        private HoudiniEngineUnity.Test_BoxCollider <ToTestObject>b__2_0(UnityEngine.BoxCollider lod) { }

    }

    // TypeToken: 0x2000187  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_SphereCollider_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.SphereCollider,HoudiniEngineUnity.Test_SphereCollider> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.SphereCollider,HoudiniEngineUnity.Test_SphereCollider> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866970  token: 0x6000CF0
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CF1
        public System.Void .ctor() { }
        // RVA: 0x08865D64  token: 0x6000CF2
        private HoudiniEngineUnity.Test_SphereCollider <ToTestObject>b__1_0(UnityEngine.SphereCollider lod) { }
        // RVA: 0x088661E4  token: 0x6000CF3
        private HoudiniEngineUnity.Test_SphereCollider <ToTestObject>b__2_0(UnityEngine.SphereCollider lod) { }

    }

    // TypeToken: 0x200018A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_CapsuleCollider_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.CapsuleCollider,HoudiniEngineUnity.Test_CapsuleCollider> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.CapsuleCollider,HoudiniEngineUnity.Test_CapsuleCollider> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866718  token: 0x6000CFA
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CFB
        public System.Void .ctor() { }
        // RVA: 0x08865AC4  token: 0x6000CFC
        private HoudiniEngineUnity.Test_CapsuleCollider <ToTestObject>b__1_0(UnityEngine.CapsuleCollider lod) { }
        // RVA: 0x08866184  token: 0x6000CFD
        private HoudiniEngineUnity.Test_CapsuleCollider <ToTestObject>b__2_0(UnityEngine.CapsuleCollider lod) { }

    }

    // TypeToken: 0x200018D  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_MeshCollider_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.MeshCollider,HoudiniEngineUnity.Test_MeshCollider> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.MeshCollider,HoudiniEngineUnity.Test_MeshCollider> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866A38  token: 0x6000D04
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D05
        public System.Void .ctor() { }
        // RVA: 0x08865828  token: 0x6000D06
        private HoudiniEngineUnity.Test_MeshCollider <ToTestObject>b__1_0(UnityEngine.MeshCollider lod) { }
        // RVA: 0x08866004  token: 0x6000D07
        private HoudiniEngineUnity.Test_MeshCollider <ToTestObject>b__2_0(UnityEngine.MeshCollider lod) { }

    }

    // TypeToken: 0x2000190  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Mesh_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Mesh,HoudiniEngineUnity.Test_Mesh> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Mesh,HoudiniEngineUnity.Test_Mesh> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x0886690C  token: 0x6000D0E
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D0F
        public System.Void .ctor() { }
        // RVA: 0x08865B84  token: 0x6000D10
        private HoudiniEngineUnity.Test_Mesh <ToTestObject>b__1_0(UnityEngine.Mesh lod) { }
        // RVA: 0x08865E84  token: 0x6000D11
        private HoudiniEngineUnity.Test_Mesh <ToTestObject>b__2_0(UnityEngine.Mesh lod) { }

    }

    // TypeToken: 0x2000193  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_MeshRenderer_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.MeshRenderer,HoudiniEngineUnity.Test_MeshRenderer> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.MeshRenderer,HoudiniEngineUnity.Test_MeshRenderer> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x088667E0  token: 0x6000D18
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D19
        public System.Void .ctor() { }
        // RVA: 0x08865E24  token: 0x6000D1A
        private HoudiniEngineUnity.Test_MeshRenderer <ToTestObject>b__1_0(UnityEngine.MeshRenderer lod) { }
        // RVA: 0x08866480  token: 0x6000D1B
        private HoudiniEngineUnity.Test_MeshRenderer <ToTestObject>b__2_0(UnityEngine.MeshRenderer lod) { }

    }

    // TypeToken: 0x2000196  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_MeshFilter_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.MeshFilter,HoudiniEngineUnity.Test_MeshFilter> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.MeshFilter,HoudiniEngineUnity.Test_MeshFilter> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866C2C  token: 0x6000D22
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D23
        public System.Void .ctor() { }
        // RVA: 0x08865D04  token: 0x6000D24
        private HoudiniEngineUnity.Test_MeshFilter <ToTestObject>b__1_0(UnityEngine.MeshFilter lod) { }
        // RVA: 0x08865F44  token: 0x6000D25
        private HoudiniEngineUnity.Test_MeshFilter <ToTestObject>b__2_0(UnityEngine.MeshFilter lod) { }

    }

    // TypeToken: 0x200019B  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Gradient_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Gradient,HoudiniEngineUnity.Test_Gradient> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Gradient,HoudiniEngineUnity.Test_Gradient> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x088669D4  token: 0x6000D2F
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D30
        public System.Void .ctor() { }
        // RVA: 0x08865DC4  token: 0x6000D31
        private HoudiniEngineUnity.Test_Gradient <ToTestObject>b__1_0(UnityEngine.Gradient lod) { }
        // RVA: 0x08866064  token: 0x6000D32
        private HoudiniEngineUnity.Test_Gradient <ToTestObject>b__2_0(UnityEngine.Gradient lod) { }

    }

    // TypeToken: 0x200019E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_AnimationCurve_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.AnimationCurve,HoudiniEngineUnity.Test_AnimationCurve> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.AnimationCurve,HoudiniEngineUnity.Test_AnimationCurve> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x088668A8  token: 0x6000D39
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D3A
        public System.Void .ctor() { }
        // RVA: 0x08865BE4  token: 0x6000D3B
        private HoudiniEngineUnity.Test_AnimationCurve <ToTestObject>b__1_0(UnityEngine.AnimationCurve lod) { }
        // RVA: 0x08866360  token: 0x6000D3C
        private HoudiniEngineUnity.Test_AnimationCurve <ToTestObject>b__2_0(UnityEngine.AnimationCurve lod) { }

    }

    // TypeToken: 0x20001A1  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_TerrainLayer_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.TerrainLayer,HoudiniEngineUnity.Test_TerrainLayer> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.TerrainLayer,HoudiniEngineUnity.Test_TerrainLayer> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866A9C  token: 0x6000D43
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D44
        public System.Void .ctor() { }
        // RVA: 0x08865A64  token: 0x6000D45
        private HoudiniEngineUnity.Test_TerrainLayer <ToTestObject>b__1_0(UnityEngine.TerrainLayer lod) { }
        // RVA: 0x08866300  token: 0x6000D46
        private HoudiniEngineUnity.Test_TerrainLayer <ToTestObject>b__2_0(UnityEngine.TerrainLayer lod) { }

    }

    // TypeToken: 0x20001A4  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Texture2D_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Texture2D,HoudiniEngineUnity.Test_Texture2D> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Texture2D,HoudiniEngineUnity.Test_Texture2D> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866BC8  token: 0x6000D4D
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D4E
        public System.Void .ctor() { }
        // RVA: 0x088657C8  token: 0x6000D4F
        private HoudiniEngineUnity.Test_Texture2D <ToTestObject>b__1_0(UnityEngine.Texture2D lod) { }
        // RVA: 0x08866420  token: 0x6000D50
        private HoudiniEngineUnity.Test_Texture2D <ToTestObject>b__2_0(UnityEngine.Texture2D lod) { }

    }

    // TypeToken: 0x20001A7  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_TreeInstance_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.TreeInstance,HoudiniEngineUnity.Test_TreeInstance> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.TreeInstance,HoudiniEngineUnity.Test_TreeInstance> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866844  token: 0x6000D56
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D57
        public System.Void .ctor() { }
        // RVA: 0x088658E8  token: 0x6000D58
        private HoudiniEngineUnity.Test_TreeInstance <ToTestObject>b__1_0(UnityEngine.TreeInstance lod) { }
        // RVA: 0x08866244  token: 0x6000D59
        private HoudiniEngineUnity.Test_TreeInstance <ToTestObject>b__2_0(UnityEngine.TreeInstance lod) { }

    }

    // TypeToken: 0x20001AA  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_TerrainData_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.TerrainData,HoudiniEngineUnity.Test_TerrainData> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.TerrainData,HoudiniEngineUnity.Test_TerrainData> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x08866B00  token: 0x6000D60
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D61
        public System.Void .ctor() { }
        // RVA: 0x08865CA4  token: 0x6000D62
        private HoudiniEngineUnity.Test_TerrainData <ToTestObject>b__1_0(UnityEngine.TerrainData lod) { }
        // RVA: 0x088662A0  token: 0x6000D63
        private HoudiniEngineUnity.Test_TerrainData <ToTestObject>b__2_0(UnityEngine.TerrainData lod) { }

    }

    // TypeToken: 0x20001AD  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly HoudiniEngineUnity.Test_Terrain_Extensions.<>c <>9;  // static @ 0x0
        public static System.Converter<UnityEngine.Terrain,HoudiniEngineUnity.Test_Terrain> <>9__1_0;  // static @ 0x8
        public static System.Converter<UnityEngine.Terrain,HoudiniEngineUnity.Test_Terrain> <>9__2_0;  // static @ 0x10

        // Methods
        // RVA: 0x088665EC  token: 0x6000D6A
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D6B
        public System.Void .ctor() { }
        // RVA: 0x08865C44  token: 0x6000D6C
        private HoudiniEngineUnity.Test_Terrain <ToTestObject>b__1_0(UnityEngine.Terrain lod) { }
        // RVA: 0x08866124  token: 0x6000D6D
        private HoudiniEngineUnity.Test_Terrain <ToTestObject>b__2_0(UnityEngine.Terrain lod) { }

    }

    // TypeToken: 0x20001AF  // size: 0x14
    public sealed struct PaintMergeMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode REPLACE;  // const
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode ADD;  // const
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode SUBTRACT;  // const
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode MULTIPLY;  // const

    }

    // TypeToken: 0x20001B0  // size: 0x14
    public sealed struct PaintMeshVisibility
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility AUTO;  // const
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility SHOW;  // const
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility HIDE;  // const

    }

namespace HoudiniEngineUnity
{

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct HEU_AssetEventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AssetEventType UNKNOWN;  // const
        public static HoudiniEngineUnity.HEU_AssetEventType RELOAD;  // const
        public static HoudiniEngineUnity.HEU_AssetEventType COOK;  // const
        public static HoudiniEngineUnity.HEU_AssetEventType BAKE_NEW;  // const
        public static HoudiniEngineUnity.HEU_AssetEventType BAKE_UPDATE;  // const

    }

    // TypeToken: 0x200000C  // size: 0x30
    public class HEU_AssetEventData
    {
        // Fields
        public HoudiniEngineUnity.HEU_HoudiniAsset Asset;  // 0x10
        public System.Boolean CookSuccess;  // 0x18
        public System.Collections.Generic.List<UnityEngine.GameObject> OutputObjects;  // 0x20
        public HoudiniEngineUnity.HEU_AssetEventType EventType;  // 0x28

        // Methods
        // RVA: 0x03240600  token: 0x6000022
        public System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }

    }

    // TypeToken: 0x200000D  // size: 0x30
    public class HEU_ReloadEventData : HoudiniEngineUnity.HEU_AssetEventData
    {
        // Methods
        // RVA: 0x087EF5B0  token: 0x6000023
        public System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }

    }

    // TypeToken: 0x200000E  // size: 0x30
    public class HEU_CookedEventData : HoudiniEngineUnity.HEU_AssetEventData
    {
        // Methods
        // RVA: 0x087D3650  token: 0x6000024
        public System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }

    }

    // TypeToken: 0x200000F  // size: 0x38
    public class HEU_BakedEventData : HoudiniEngineUnity.HEU_AssetEventData
    {
        // Fields
        public System.Boolean IsNewBake;  // 0x30

        // Methods
        // RVA: 0x087D3370  token: 0x6000025
        public System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake) { }

    }

    // TypeToken: 0x2000010  // size: 0x20
    public class HEU_PreAssetEventData
    {
        // Fields
        public HoudiniEngineUnity.HEU_HoudiniAsset Asset;  // 0x10
        public HoudiniEngineUnity.HEU_AssetEventType AssetType;  // 0x18

        // Methods
        // RVA: 0x02738A30  token: 0x6000026
        public System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_AssetEventType assetType) { }

    }

    // TypeToken: 0x2000011  // size: 0x30
    public class HEU_ReloadDataEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x087EF574  token: 0x6000027
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x30
    public class HEU_CookedDataEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x087D3614  token: 0x6000028
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x30
    public class HEU_BakedDataEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x087D3334  token: 0x6000029
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x30
    public class HEU_PreAssetEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x087EF478  token: 0x600002A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x50
    public class HEU_AssetPreset
    {
        // Fields
        public System.Char[] _identifier;  // 0x10
        public System.Int32 _version;  // 0x18
        public System.String _assetOPName;  // 0x20
        public System.Byte[] _parameterPreset;  // 0x28
        public System.Collections.Generic.List<System.String> _curveNames;  // 0x30
        public System.Collections.Generic.List<System.Byte[]> _curvePresets;  // 0x38
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> inputPresets;  // 0x40
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> volumeCachePresets;  // 0x48

        // Methods
        // RVA: 0x087D3040  token: 0x600002B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x48
    public class HEU_InputPreset
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType _inputObjectType;  // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectPreset> _inputObjectPresets;  // 0x18
        public System.String _inputAssetName;  // 0x20
        public System.Int32 _inputIndex;  // 0x28
        public System.String _inputName;  // 0x30
        public System.Boolean _keepWorldTransform;  // 0x38
        public System.Boolean _packGeometryBeforeMerging;  // 0x39
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputAssetPreset> _inputAssetPresets;  // 0x40

        // Properties
        HoudiniEngineUnity.HEU_InputObjectTypeWrapper InputObjectType { get; /* RVA: 0x087EF44C */ set; /* RVA: 0x087EF458 */ }

        // Methods
        // RVA: 0x087EF38C  token: 0x600002E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x40
    public class HEU_InputObjectPreset
    {
        // Fields
        public System.String _gameObjectName;  // 0x10
        public System.Boolean _isSceneObject;  // 0x18
        public System.Boolean _useTransformOffset;  // 0x19
        public UnityEngine.Vector3 _translateOffset;  // 0x1c
        public UnityEngine.Vector3 _rotateOffset;  // 0x28
        public UnityEngine.Vector3 _scaleOffset;  // 0x34

        // Methods
        // RVA: 0x087EF32C  token: 0x600002F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x18
    public class HEU_InputAssetPreset
    {
        // Fields
        public System.String _gameObjectName;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000030
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x28
    public class HEU_VolumeLayerPreset
    {
        // Fields
        public System.String _layerName;  // 0x10
        public System.Single _strength;  // 0x18
        public System.Boolean _uiExpanded;  // 0x1c
        public System.Int32 _tile;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000031
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x40
    public class HEU_VolumeCachePreset
    {
        // Fields
        public System.String _objName;  // 0x10
        public System.String _geoName;  // 0x18
        public System.Boolean _uiExpanded;  // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayerPreset> _volumeLayersPresets;  // 0x28
        public System.String _terrainDataPath;  // 0x30
        public System.Int32 _tile;  // 0x38

        // Methods
        // RVA: 0x087EFC3C  token: 0x6000032
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x20
    public class HEU_RecookPreset
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> _volumeCachePresets;  // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> _inputPresets;  // 0x18

        // Methods
        // RVA: 0x087EF4B4  token: 0x6000033
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x10
    public static class HEU_AssetPresetUtility
    {
        // Fields
        public static System.Char[] PRESET_IDENTIFIER;  // static @ 0x0
        public static System.Int32 PRESET_VERSION;  // static @ 0x8

        // Methods
        // RVA: 0x087D2A44  token: 0x6000034
        public static System.Void SaveAssetPresetToFile(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath) { }
        // RVA: 0x087D2498  token: 0x6000035
        public static System.Void LoadPresetFileIntoAssetAndCook(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath) { }
        // RVA: 0x087D2FBC  token: 0x6000036
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x10
    public class HEU_Vector3SerializationSurrogate : System.Runtime.Serialization.ISerializationSurrogate
    {
        // Methods
        // RVA: 0x087EF9F4  token: 0x6000037
        private virtual System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x087EFABC  token: 0x6000038
        private virtual System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector) { }
        // RVA: 0x0350B670  token: 0x6000039
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E  // size: 0x10
    public class HEU_Vector2SerializationSurrogate : System.Runtime.Serialization.ISerializationSurrogate
    {
        // Methods
        // RVA: 0x087EF824  token: 0x600003A
        private virtual System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x087EF8C8  token: 0x600003B
        private virtual System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector) { }
        // RVA: 0x0350B670  token: 0x600003C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x30
    public class HEU_AssetSerializedMetaData : UnityEngine.ScriptableObject, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.Boolean _softDeleted;  // 0x18
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>> _savedCurveNodeData;  // 0x20
        private System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo> _savedInputCurveInfo;  // 0x28

        // Properties
        System.Boolean SoftDeleted { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>> SavedCurveNodeData { get; /* RVA: 0x03D4EB40 */ }
        System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo> SavedInputCurveInfo { get; /* RVA: 0x03D4EAC0 */ }

        // Methods
        // RVA: 0x087D3198  token: 0x6000041
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AssetSerializedMetaData other) { }
        // RVA: 0x087D322C  token: 0x6000042
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public class HEU_AssetUpdater
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000043
        private static System.Void .cctor() { }
        // RVA: 0x087D32F4  token: 0x6000044
        private static System.Void OnBeforeAssemblyReload() { }
        // RVA: 0x0350B670  token: 0x6000045
        private static System.Void Update() { }
        // RVA: 0x0350B670  token: 0x6000046
        public static System.Void AddAssetForUpdate(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x0350B670  token: 0x6000047
        public static System.Void RemoveAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x0350B670  token: 0x6000048
        public static System.Void AddNodeSyncForUpdate(HoudiniEngineUnity.HEU_BaseSync nodeSync) { }
        // RVA: 0x0350B670  token: 0x6000049
        public static System.Void RemoveNodeSync(HoudiniEngineUnity.HEU_BaseSync nodeSync) { }
        // RVA: 0x0350B670  token: 0x600004A
        private static System.Void OnPrefabInstanceUpdate(UnityEngine.GameObject instance) { }
        // RVA: 0x0350B670  token: 0x600004B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000021  // size: 0x38
    public class CurveNodeData : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Vector3 rotation;  // 0x1c
        public UnityEngine.Vector3 scale;  // 0x28
        public System.Int32 curveCountIndex;  // 0x34

        // Methods
        // RVA: 0x087D1EE0  token: 0x600004C
        public System.Void .ctor() { }
        // RVA: 0x087D1E70  token: 0x600004D
        public System.Void .ctor(UnityEngine.Vector3 position) { }
        // RVA: 0x087D1F40  token: 0x600004E
        public System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x087D1FC8  token: 0x600004F
        public System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        // RVA: 0x087D1DD0  token: 0x6000050
        public System.Void .ctor(HoudiniEngineUnity.CurveNodeData other) { }
        // RVA: 0x087D1C04  token: 0x6000051
        public UnityEngine.Quaternion GetRotation() { }
        // RVA: 0x087D1C40  token: 0x6000052
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.CurveNodeData other) { }

    }

    // TypeToken: 0x2000022  // size: 0x28
    public class HEU_InputCurveInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_CurveType curveType;  // 0x10
        public System.Int32 order;  // 0x14
        public System.Boolean closed;  // 0x18
        public System.Boolean reverse;  // 0x19
        public HoudiniEngineUnity.HAPI_InputCurveMethod inputMethod;  // 0x1c
        public HoudiniEngineUnity.HAPI_InputCurveParameterization breakpointParameterization;  // 0x20

        // Methods
        // RVA: 0x087EF0D0  token: 0x6000053
        public static HoudiniEngineUnity.HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HoudiniEngineUnity.HAPI_InputCurveInfo curveInfo) { }
        // RVA: 0x087EF1FC  token: 0x6000054
        public static System.String[] GetCurveTypeNames() { }
        // RVA: 0x087EF2A4  token: 0x6000055
        public static System.String[] GetInputMethodNames() { }
        // RVA: 0x087EF154  token: 0x6000056
        public static System.String[] GetBreakpointParameterizationNames() { }
        // RVA: 0x03D6D3C0  token: 0x6000057
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x14
    public sealed struct HEU_CurveDataType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_CurveDataType INVALID;  // const
        public static HoudiniEngineUnity.HEU_CurveDataType GEO_COORDS_PARAM;  // const
        public static HoudiniEngineUnity.HEU_CurveDataType HAPI_COORDS_PARAM;  // const
        public static HoudiniEngineUnity.HEU_CurveDataType POSITION_ATTRIBUTE;  // const

    }

    // TypeToken: 0x2000024  // size: 0x90
    public class HEU_Curve : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_Curve, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.Int32 _geoID;  // 0x18
        private System.Int32 _partID;  // 0x1c
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> _curveNodeData;  // 0x20
        private UnityEngine.Vector3[] _vertices;  // 0x28
        private System.Boolean _isEditable;  // 0x30
        private HoudiniEngineUnity.HEU_Parameters _parameters;  // 0x38
        private System.Boolean _bUploadParameterPreset;  // 0x40
        private System.String _curveName;  // 0x48
        private UnityEngine.GameObject _targetGameObject;  // 0x50
        private System.Boolean _isGeoCurve;  // 0x58
        private HoudiniEngineUnity.HEU_Curve.CurveEditState _editState;  // 0x5c
        public static HoudiniEngineUnity.HEU_Curve.Interaction PreferredNextInteractionMode;  // static @ 0x0
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;  // 0x60
        private System.Boolean _bIsInputCurve;  // 0x68
        private System.Boolean _bIsPartCurve;  // 0x69
        private System.Boolean _cachedCurveInfoValid;  // 0x6a
        private System.Int32[] _cachedCurveCounts;  // 0x70
        private System.Int32[] _cachedCurveCountSums;  // 0x78
        private HoudiniEngineUnity.HEU_CurveDataType _curveDataType;  // 0x80
        private HoudiniEngineUnity.HEU_InputCurveInfo _inputCurveInfo;  // 0x88

        // Properties
        UnityEngine.GameObject TargetGameObject { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.Int32 GeoID { get; /* RVA: 0x020D1AC0 */ }
        System.Int32 PartID { get; /* RVA: 0x03D4EBB0 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> CurveNodeData { get; /* RVA: 0x03D4EB40 */ }
        HoudiniEngineUnity.HEU_Parameters Parameters { get; /* RVA: 0x03D4E2A0 */ }
        System.String CurveName { get; /* RVA: 0x03D4EA70 */ }
        System.Boolean IsInputCurve { get; /* RVA: 0x03D4F3F0 */ }
        System.Boolean IsPartCurve { get; /* RVA: 0x03D4F3C0 */ }
        HoudiniEngineUnity.HEU_InputCurveInfo InputCurveInfo { get; /* RVA: 0x03D4EA60 */ }
        HoudiniEngineUnity.HEU_Curve.CurveEditState EditState { get; /* RVA: 0x03D4EEF0 */ }
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x03D4EB00 */ }
        HoudiniEngineUnity.HEU_CurveDataType CurveDataType { get; /* RVA: 0x03D4EC20 */ }

        // Methods
        // RVA: 0x03D4EEB0  token: 0x6000062
        private System.Void SetUploadParameterPreset(System.Boolean bValue) { }
        // RVA: 0x087D52C8  token: 0x6000066
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x087D60AC  token: 0x6000067
        public virtual System.Void Recook() { }
        // RVA: 0x03D4EF60  token: 0x6000068
        public virtual System.Boolean IsEditable() { }
        // RVA: 0x03D4F7E0  token: 0x6000069
        public virtual System.Boolean IsGeoCurve() { }
        // RVA: 0x087D6360  token: 0x600006A
        public virtual System.Void SetCurveName(System.String name) { }
        // RVA: 0x087D6678  token: 0x600006B
        public virtual System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset) { }
        // RVA: 0x087D6534  token: 0x600006C
        public virtual System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        // RVA: 0x087D63E0  token: 0x600006D
        public virtual System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset) { }
        // RVA: 0x087D4BB0  token: 0x600006E
        public virtual UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex) { }
        // RVA: 0x03D4EB40  token: 0x600006F
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms() { }
        // RVA: 0x087D4978  token: 0x6000070
        public virtual System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints() { }
        // RVA: 0x087D4D38  token: 0x6000071
        public virtual System.Int32 GetNumPoints() { }
        // RVA: 0x087D5650  token: 0x6000072
        public virtual System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        // RVA: 0x087D55A8  token: 0x6000073
        public virtual System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        // RVA: 0x087D3710  token: 0x6000074
        public virtual System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        // RVA: 0x087D3674  token: 0x6000075
        public virtual System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        // RVA: 0x087D6118  token: 0x6000076
        public virtual System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset) { }
        // RVA: 0x087D3808  token: 0x6000077
        public virtual System.Void ClearCurveNodeData(System.Boolean bRecookAsset) { }
        // RVA: 0x087D6058  token: 0x6000078
        public virtual System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset) { }
        // RVA: 0x087D632C  token: 0x6000079
        public virtual System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset) { }
        // RVA: 0x087D535C  token: 0x600007A
        public virtual UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex) { }
        // RVA: 0x087D5424  token: 0x600007B
        public virtual System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints() { }
        // RVA: 0x087D3F54  token: 0x600007C
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData() { }
        // RVA: 0x087D3894  token: 0x600007D
        private static HoudiniEngineUnity.HEU_Curve CreateSetupCurve(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean isEditable, System.String curveName, System.Int32 geoID, System.Int32 partID, System.Boolean bGeoCurve) { }
        // RVA: 0x087D7D0C  token: 0x600007E
        private System.Void UsePreviousCurveData(System.String curveName) { }
        // RVA: 0x087D4B68  token: 0x600007F
        private HoudiniEngineUnity.HEU_CurveDataType GetCurveDataType(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D674C  token: 0x6000080
        private System.Boolean ShouldKeepNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D3C30  token: 0x6000081
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        // RVA: 0x087D7BA8  token: 0x6000082
        private System.Void UploadParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x087D61B0  token: 0x6000083
        private System.Void ResetCurveParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x087D6464  token: 0x6000084
        private System.Void SetCurveParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Byte[] parameterPreset) { }
        // RVA: 0x087D7228  token: 0x6000085
        private System.Void UpdateCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId) { }
        // RVA: 0x087D4AF8  token: 0x6000086
        private static System.Int32[] GetCurveCounts(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoId, System.Int32 partID) { }
        // RVA: 0x087D45A8  token: 0x6000087
        private System.Void GenerateMesh(UnityEngine.GameObject inGameObject, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D4200  token: 0x6000088
        private System.Void GenerateMeshForSingleObject(UnityEngine.GameObject targetObject, UnityEngine.Vector3[] vertexList) { }
        // RVA: 0x087D5A60  token: 0x6000089
        private System.Void OnPresyncParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x087D4D78  token: 0x600008A
        private static System.Int32 GetOrderForCurveType(System.Int32 requestedOrder, HoudiniEngineUnity.HAPI_CurveType curveType) { }
        // RVA: 0x087D6954  token: 0x600008B
        private System.Boolean UpdateCurveInputForCurveParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x087D6E8C  token: 0x600008C
        private System.Boolean UpdateCurveInputForCustomAttributes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x087D67A4  token: 0x600008D
        private System.Void SyncFromParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bNewCurve) { }
        // RVA: 0x087D73F8  token: 0x600008E
        private System.Void UpdatePoints(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D5A98  token: 0x600008F
        private System.Void ProjectToCollidersInternal(HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, UnityEngine.Vector3 rayDirection, System.Single rayDistance) { }
        // RVA: 0x087D503C  token: 0x6000090
        public static System.String GetPointsString(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> points) { }
        // RVA: 0x087D4DC4  token: 0x6000091
        public static System.String GetPointsString(System.Collections.Generic.List<UnityEngine.Vector3> points) { }
        // RVA: 0x03D4EF40  token: 0x6000092
        private System.Void SetEditState(HoudiniEngineUnity.HEU_Curve.CurveEditState editState) { }
        // RVA: 0x087D5538  token: 0x6000093
        private UnityEngine.Vector3 GetTransformedPosition(UnityEngine.Vector3 inPosition) { }
        // RVA: 0x087D4CC8  token: 0x6000094
        private UnityEngine.Vector3 GetInvertedTransformedPosition(UnityEngine.Vector3 inPosition) { }
        // RVA: 0x087D4C58  token: 0x6000095
        private UnityEngine.Vector3 GetInvertedTransformedDirection(UnityEngine.Vector3 inPosition) { }
        // RVA: 0x03D4EAC0  token: 0x6000096
        private UnityEngine.Vector3[] GetVertices() { }
        // RVA: 0x087D6270  token: 0x6000097
        private System.Void SetCurveGeometryVisibilityInternal(System.Boolean bVisible) { }
        // RVA: 0x087D3ED8  token: 0x6000098
        private System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D7C90  token: 0x6000099
        private System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D3E5C  token: 0x600009A
        private System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087D684C  token: 0x600009B
        private System.Void UpdateCachedCurveInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean copyCurveSettings) { }
        // RVA: 0x087D4A88  token: 0x600009C
        private System.Int32 GetCurveCountIndexFromPositionIndex(System.Int32 positionIndex) { }
        // RVA: 0x087D5A38  token: 0x600009D
        private static System.Boolean IsMeshCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x087D5748  token: 0x600009E
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Curve other) { }
        // RVA: 0x087D7F78  token: 0x600009F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x28
    public class HEU_GeneratedOutput : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_GeneratedOutputData _outputData;  // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutputData> _childOutputs;  // 0x18
        private System.Boolean isInstancer;  // 0x20

        // Properties
        System.Boolean IsInstancer { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }

        // Methods
        // RVA: 0x087DA24C  token: 0x60000AC
        public static System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutput output) { }
        // RVA: 0x087DA394  token: 0x60000AD
        public static System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        // RVA: 0x087D9C00  token: 0x60000AE
        public static UnityEngine.Material[] GetGeneratedMaterialsForGameObject(HoudiniEngineUnity.HEU_GeneratedOutput output, UnityEngine.GameObject inGameObject) { }
        // RVA: 0x087D9DBC  token: 0x60000AF
        public static System.Boolean HasLODGroup(HoudiniEngineUnity.HEU_GeneratedOutput output) { }
        // RVA: 0x087DA0EC  token: 0x60000B0
        public static System.Boolean IsOutputUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutput output) { }
        // RVA: 0x087D9F80  token: 0x60000B1
        public static System.Boolean IsOutputDataUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        // RVA: 0x087D9398  token: 0x60000B2
        public static System.Void ClearGeneratedMaterialReferences(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData) { }
        // RVA: 0x087D96C8  token: 0x60000B3
        public static System.Void DestroyAllGeneratedColliders(HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        // RVA: 0x087D9A5C  token: 0x60000B4
        public static System.Void DestroyGeneratedOutput(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput) { }
        // RVA: 0x087D98A0  token: 0x60000B5
        public static System.Void DestroyGeneratedOutputChildren(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput) { }
        // RVA: 0x087D9A04  token: 0x60000B6
        public static System.Void DestroyGeneratedOutputData(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData, System.Boolean bDontDeletePersistantResources) { }
        // RVA: 0x087D93BC  token: 0x60000B7
        public static System.Void ClearMaterialsNoLongerUsed(UnityEngine.Material[] materialsToCheck, UnityEngine.Material[] materialsInUse) { }
        // RVA: 0x087D948C  token: 0x60000B8
        public static System.Void CopyMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData sourceOutputData, HoudiniEngineUnity.HEU_GeneratedOutputData destOutputData) { }
        // RVA: 0x087DA44C  token: 0x60000B9
        private System.Void WriteOutputToAssetCache(UnityEngine.GameObject parentObject, System.String outputPath, System.Boolean bIsInstancer) { }
        // RVA: 0x087D9250  token: 0x60000BA
        private static System.Void BakeGameObjectComponents(UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.String outputPath, System.Boolean bIsInstancer) { }
        // RVA: 0x087D9E04  token: 0x60000BB
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutput other) { }
        // RVA: 0x087DA4BC  token: 0x60000BC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x28
    public class HEU_GeneratedOutputData : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _gameObject;  // 0x10
        public UnityEngine.Material[] _renderMaterials;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Collider> _colliders;  // 0x20

        // Methods
        // RVA: 0x087D9028  token: 0x60000BD
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutputData other) { }
        // RVA: 0x087D91D8  token: 0x60000BE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x78
    public class HEU_GeoNode : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_GeoNode, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, UnityEngine.ISerializationCallbackReceiver, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HAPI_GeoInfo _geoInfo;  // 0x18
        private System.String _geoName;  // 0x40
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> _parts;  // 0x48
        private HoudiniEngineUnity.HEU_ObjectNode _containerObjectNode;  // 0x50
        private HoudiniEngineUnity.HEU_InputNode _inputNode;  // 0x58
        private HoudiniEngineUnity.HEU_Curve _geoCurve;  // 0x60
        private HoudiniEngineUnity.HEU_VolumeCache _volumeCache;  // 0x68
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> _volumeCaches;  // 0x70

        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x087DE394 */ }
        System.Int32 GeoID { get; /* RVA: 0x01003B50 */ }
        HoudiniEngineUnity.HAPI_GeoInfo GeoInfo { get; /* RVA: 0x03D65C80 */ }
        System.String GeoName { get; /* RVA: 0x03D4E2B0 */ }
        HoudiniEngineUnity.HAPI_GeoType GeoType { get; /* RVA: 0x020D1AC0 */ }
        System.Boolean Editable { get; /* RVA: 0x03D4F090 */ }
        System.Boolean Displayable { get; /* RVA: 0x087DE314 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> Parts { get; /* RVA: 0x03D4EA70 */ }
        HoudiniEngineUnity.HEU_ObjectNode ObjectNode { get; /* RVA: 0x03D4EAF0 */ }
        HoudiniEngineUnity.HEU_InputNode InputNode { get; /* RVA: 0x03D4EAA0 */ }
        HoudiniEngineUnity.HEU_Curve GeoCurve { get; /* RVA: 0x03D4EB00 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> VolumeCaches { get; /* RVA: 0x03D4EB30 */ }

        // Methods
        // RVA: 0x087DE2F4  token: 0x60000CB
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x60000CC
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: 0x087DC550  token: 0x60000CD
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x087DBC98  token: 0x60000CE
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x087DD660  token: 0x60000CF
        public virtual System.Void Recook() { }
        // RVA: 0x087DC534  token: 0x60000D0
        public virtual System.Boolean IsVisible() { }
        // RVA: 0x086E1564  token: 0x60000D1
        public virtual System.Boolean IsIntermediate() { }
        // RVA: 0x087DC3F0  token: 0x60000D2
        public virtual System.Boolean IsIntermediateOrEditable() { }
        // RVA: 0x087DC3DC  token: 0x60000D3
        public virtual System.Boolean IsGeoInputType() { }
        // RVA: 0x059BC74C  token: 0x60000D4
        public virtual System.Boolean IsGeoCurveType() { }
        // RVA: 0x087DA8B4  token: 0x60000D5
        public virtual System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        // RVA: 0x087DD6D4  token: 0x60000D6
        public virtual System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part) { }
        // RVA: 0x087DB8C0  token: 0x60000D7
        public virtual System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: 0x087DB9E4  token: 0x60000D8
        public virtual System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: 0x087DB768  token: 0x60000D9
        public virtual HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087DBB08  token: 0x60000DA
        public virtual HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID) { }
        // RVA: 0x087DB1CC  token: 0x60000DB
        public virtual System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        // RVA: 0x03D4EA70  token: 0x60000DC
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts() { }
        // RVA: 0x087DBFC8  token: 0x60000DD
        public virtual System.Void HideAllGeometry() { }
        // RVA: 0x087DAC14  token: 0x60000DE
        public virtual System.Void DisableAllColliders() { }
        // RVA: 0x087DBD3C  token: 0x60000DF
        public virtual HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex) { }
        // RVA: 0x087DD738  token: 0x60000E0
        private System.Void Reset() { }
        // RVA: 0x087DC05C  token: 0x60000E1
        private System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo, HoudiniEngineUnity.HEU_ObjectNode containerObjectNode) { }
        // RVA: 0x087DACA8  token: 0x60000E2
        private System.Boolean DoesThisRequirePotentialCook() { }
        // RVA: 0x087DDF6C  token: 0x60000E3
        private System.Void UpdateGeo(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DCFD4  token: 0x60000E4
        private System.Void ProcessUnityScriptAttribute(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DC83C  token: 0x60000E5
        private System.Void ProcessPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData& partData) { }
        // RVA: 0x087DDA94  token: 0x60000E6
        private System.Void SetupGameObjectAndTransform(HoudiniEngineUnity.HEU_PartData partData, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x087DBBB8  token: 0x60000E7
        private System.Void GetPartsByOutputType(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts) { }
        // RVA: 0x087DAE68  token: 0x60000E8
        private System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DACF0  token: 0x60000E9
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DC644  token: 0x60000EA
        private System.Void ProcessGeoCurve(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DDD44  token: 0x60000EB
        private System.Void SetupGeoCurveGameObjectAndTransform(HoudiniEngineUnity.HEU_Curve curve) { }
        // RVA: 0x087DA82C  token: 0x60000EC
        private System.Void ClearObjectInstances() { }
        // RVA: 0x087DDA10  token: 0x60000ED
        private System.Void SetGeoInfo(HoudiniEngineUnity.HAPI_GeoInfo geoInfo) { }
        // RVA: 0x087DAD90  token: 0x60000EE
        private System.String GeneratePartFullName(System.String partName) { }
        // RVA: 0x03D4E2B0  token: 0x60000EF
        private System.String GenerateGeoCurveName() { }
        // RVA: 0x087DBF90  token: 0x60000F0
        private System.Boolean HasGeoNodeChanged(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DA568  token: 0x60000F1
        private System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform) { }
        // RVA: 0x087DB3C8  token: 0x60000F2
        private System.Void GetDebugInfo(System.Text.StringBuilder sb) { }
        // RVA: 0x087DC408  token: 0x60000F3
        private System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        // RVA: 0x087DB0A8  token: 0x60000F4
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        // RVA: 0x087DBE78  token: 0x60000F5
        private System.Boolean HasAttribInstancer() { }
        // RVA: 0x087DD7E8  token: 0x60000F6
        private System.Void SetAttributeModifiersOnPartOutputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087DA71C  token: 0x60000F7
        private System.Void CalculateVisiblity(System.Boolean bParentVisibility) { }
        // RVA: 0x087DA68C  token: 0x60000F8
        private System.Void CalculateColliderState() { }
        // RVA: 0x087DD188  token: 0x60000F9
        private System.Void ProcessVolumeParts(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Boolean bRebuild) { }
        // RVA: 0x087DAA8C  token: 0x60000FA
        private System.Void DestroyVolumeCache() { }
        // RVA: 0x087DDF10  token: 0x60000FB
        public virtual System.String ToString() { }
        // RVA: 0x087DC178  token: 0x60000FC
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeoNode other) { }

    }

    // TypeToken: 0x200002F  // size: 0x268
    public sealed class HEU_HoudiniAsset : UnityEngine.MonoBehaviour, HoudiniEngineUnity.IHEU_HoudiniAsset, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType _assetType;  // 0x18
        private HoudiniEngineUnity.HAPI_AssetInfo _assetInfo;  // 0x1c
        private HoudiniEngineUnity.HAPI_NodeInfo _nodeInfo;  // 0x5c
        private System.String _assetName;  // 0xa0
        private System.String _assetOpName;  // 0xa8
        private System.String _assetHelp;  // 0xb0
        private System.Int32 _assetID;  // 0xb8
        private System.String _assetPath;  // 0xc0
        private System.Boolean _loadAssetFromMemory;  // 0xc8
        private System.Boolean _alwaysOverwriteOnLoad;  // 0xc9
        private UnityEngine.Object _assetFileObject;  // 0xd0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectNode> _objectNodes;  // 0xd8
        private UnityEngine.GameObject _rootGameObject;  // 0xe0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> _materialCache;  // 0xe8
        private HoudiniEngineUnity.HEU_Parameters _parameters;  // 0xf0
        private UnityEngine.Matrix4x4 _lastSyncedTransformMatrix;  // 0xf8
        private System.Collections.Generic.List<UnityEngine.Matrix4x4> _lastSyncedChildTransformMatrices;  // 0x138
        private System.String _assetCacheFolderPath;  // 0x140
        private System.String[] _subassetNames;  // 0x148
        private System.Int32 _selectedSubassetIndex;  // 0x150
        private HoudiniEngineUnity.HEU_AssetPreset _savedAssetPreset;  // 0x158
        private HoudiniEngineUnity.HEU_RecookPreset _recookPreset;  // 0x160
        private System.Int32 _totalCookCount;  // 0x168
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction _requestBuildAction;  // 0x16c
        private System.Boolean _checkParameterChangeForCook;  // 0x170
        private System.Boolean _skipCookCheck;  // 0x171
        private System.Boolean _uploadParameters;  // 0x172
        private System.Boolean _forceUploadInputs;  // 0x173
        private System.Boolean _upstreamCookChanged;  // 0x174
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus _cookStatus;  // 0x178
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult _lastCookResult;  // 0x17c
        private System.Boolean _isCookingAssetReloaded;  // 0x180
        private System.Boolean _bForceUpdate;  // 0x181
        private System.Int64 _sessionID;  // 0x188
        private System.Boolean <WarnedPrefabNotSupported>k__BackingField;  // 0x190
        private System.Boolean _uiLocked;  // 0x191
        private System.Boolean _showHDAOptions;  // 0x192
        private System.Boolean _showGenerateSection;  // 0x193
        private System.Boolean _showBakeSection;  // 0x194
        private System.Boolean _showEventsSection;  // 0x195
        private System.Boolean _showCurvesSection;  // 0x196
        private System.Boolean _showInputNodesSection;  // 0x197
        private System.Boolean _showToolsSection;  // 0x198
        private System.Boolean _showTerrainSection;  // 0x199
        private HoudiniEngineUnity.HEU_InstanceInputUIState _instanceInputUIState;  // 0x1a0
        private HoudiniEngineUnity.HEU_ReloadDataEvent _reloadDataEvent;  // 0x1a8
        private HoudiniEngineUnity.HEU_CookedDataEvent _cookedDataEvent;  // 0x1b0
        private HoudiniEngineUnity.HEU_BakedDataEvent _bakedDataEvent;  // 0x1b8
        private HoudiniEngineUnity.HEU_PreAssetEvent _preAssetEvent;  // 0x1c0
        private HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate _refreshUIDelegate;  // 0x1c8
        private HoudiniEngineUnity.HEU_CookedDataEvent _downstreamConnectionCookedEvent;  // 0x1d0
        private System.Boolean _generateUVs;  // 0x1d8
        private System.Boolean _generateTangents;  // 0x1d9
        private System.Boolean _generateNormals;  // 0x1da
        private System.Boolean _pushTransformToHoudini;  // 0x1db
        private System.Boolean _transformChangeTriggersCooks;  // 0x1dc
        private System.Boolean _cookingTriggersDownCooks;  // 0x1dd
        private System.Boolean _autoCookOnParameterChange;  // 0x1de
        private System.Boolean _ignoreNonDisplayNodes;  // 0x1df
        private System.Boolean _useOutputNodes;  // 0x1e0
        private System.Boolean _generateMeshUsingPoints;  // 0x1e1
        private System.Boolean _useLODGroups;  // 0x1e2
        private System.Boolean _splitGeosByGroup;  // 0x1e3
        private System.Boolean _sessionSyncAutoCook;  // 0x1e4
        private System.Boolean _bakeUpdateKeepPreviousTransformValues;  // 0x1e5
        private System.Boolean _pauseCooking;  // 0x1e6
        private System.Boolean _curveEditorEnabled;  // 0x1e7
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> _curves;  // 0x1e8
        private HoudiniEngineUnity.HEU_Curve.CurveDrawCollision _curveDrawCollision;  // 0x1f0
        private System.Collections.Generic.List<UnityEngine.Collider> _curveDrawColliders;  // 0x1f8
        private UnityEngine.LayerMask _curveDrawLayerMask;  // 0x200
        private System.Single _curveProjectMaxDistance;  // 0x204
        private UnityEngine.Vector3 _curveProjectDirection;  // 0x208
        private System.Boolean _curveProjectDirectionToView;  // 0x214
        private System.Boolean _curveDisableScaleRotation;  // 0x215
        private System.Boolean _curveCookOnDrag;  // 0x216
        private System.Boolean _curveFrameSelectedNodes;  // 0x217
        private System.Single _curveFrameSelectedNodeDistance;  // 0x218
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> _inputNodes;  // 0x220
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> _handles;  // 0x228
        private System.Boolean _handlesEnabled;  // 0x230
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> _volumeCaches;  // 0x238
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore> _attributeStores;  // 0x240
        private System.Boolean _editableNodesToolsEnabled;  // 0x248
        private HoudiniEngineUnity.HEU_ToolsInfo _toolsInfo;  // 0x250
        private HoudiniEngineUnity.HEU_AssetSerializedMetaData _serializedMetaData;  // 0x258
        private System.Boolean _pendingAutoCookOnMouseRelease;  // 0x260

        // Properties
        System.Boolean LoadAssetFromMemory { get; /* RVA: 0x03D519D0 */ set; /* RVA: 0x03D57500 */ }
        System.Boolean AlwaysOverwriteOnLoad { get; /* RVA: 0x03D58400 */ set; /* RVA: 0x03D6D220 */ }
        System.Boolean GenerateUVs { get; /* RVA: 0x03D57B10 */ set; /* RVA: 0x03D5A480 */ }
        System.Boolean GenerateTangents { get; /* RVA: 0x03D6D180 */ set; /* RVA: 0x03D6D320 */ }
        System.Boolean GenerateNormals { get; /* RVA: 0x03D6D170 */ set; /* RVA: 0x03D6D310 */ }
        System.Boolean PushTransformToHoudini { get; /* RVA: 0x03D6D1E0 */ set; /* RVA: 0x03D6D360 */ }
        System.Boolean TransformChangeTriggersCooks { get; /* RVA: 0x03D6D200 */ set; /* RVA: 0x03D6D390 */ }
        System.Boolean CookingTriggersDownCooks { get; /* RVA: 0x03D5C290 */ set; /* RVA: 0x03D6D250 */ }
        System.Boolean AutoCookOnParameterChange { get; /* RVA: 0x03D6D100 */ set; /* RVA: 0x03D6D230 */ }
        System.Boolean IgnoreNonDisplayNodes { get; /* RVA: 0x03D6D190 */ set; /* RVA: 0x03D6D340 */ }
        System.Boolean UseOutputNodes { get; /* RVA: 0x03D58E20 */ set; /* RVA: 0x03D6D3B0 */ }
        System.Boolean GenerateMeshUsingPoints { get; /* RVA: 0x03D6D160 */ set; /* RVA: 0x03D6D300 */ }
        System.Boolean UseLODGroups { get; /* RVA: 0x03D6D210 */ set; /* RVA: 0x03D6D3A0 */ }
        System.Boolean SplitGeosByGroup { get; /* RVA: 0x03D5ACA0 */ set; /* RVA: 0x03D6D380 */ }
        System.Boolean SessionSyncAutoCook { get; /* RVA: 0x03D56B40 */ set; /* RVA: 0x03D6D370 */ }
        System.Boolean BakeUpdateKeepPreviousTransformValues { get; /* RVA: 0x03D5ACB0 */ set; /* RVA: 0x03D6D240 */ }
        System.Boolean PauseCooking { get; /* RVA: 0x03D6D1D0 */ set; /* RVA: 0x03D6D350 */ }
        System.Boolean CurveEditorEnabled { get; /* RVA: 0x03D5ACD0 */ set; /* RVA: 0x03D6D280 */ }
        HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper CurveDrawCollision { get; /* RVA: 0x087EF07C */ set; /* RVA: 0x087EF0B0 */ }
        UnityEngine.LayerMask CurveDrawLayerMask { get; /* RVA: 0x03D5A250 */ set; /* RVA: 0x03D5A290 */ }
        System.Single CurveProjectMaxDistance { get; /* RVA: 0x03D59A40 */ set; /* RVA: 0x03D6D2E0 */ }
        UnityEngine.Vector3 CurveProjectDirection { get; /* RVA: 0x03D5AD60 */ set; /* RVA: 0x03D6D2C0 */ }
        System.Boolean CurveProjectDirectionToView { get; /* RVA: 0x03D6D150 */ set; /* RVA: 0x03D6D2B0 */ }
        System.Boolean CurveDisableScaleRotation { get; /* RVA: 0x03D6D120 */ set; /* RVA: 0x03D6D270 */ }
        System.Boolean CurveFrameSelectedNodes { get; /* RVA: 0x03D6D140 */ set; /* RVA: 0x03D6D2A0 */ }
        System.Single CurveFrameSelectedNodeDistance { get; /* RVA: 0x03D59960 */ set; /* RVA: 0x03D6D290 */ }
        System.Boolean HandlesEnabled { get; /* RVA: 0x03D57C20 */ set; /* RVA: 0x03D6D330 */ }
        System.Boolean EditableNodesToolsEnabled { get; /* RVA: 0x03D5BEE0 */ set; /* RVA: 0x03D6D2F0 */ }
        HoudiniEngineUnity.HEU_AssetTypeWrapper AssetType { get; /* RVA: 0x087EF040 */ }
        HoudiniEngineUnity.HAPI_AssetInfo AssetInfo { get; /* RVA: 0x03D6D0D0 */ }
        HoudiniEngineUnity.HAPI_NodeInfo NodeInfo { get; /* RVA: 0x03D6D1A0 */ }
        System.String AssetName { get; /* RVA: 0x03D4EA80 */ }
        System.String AssetOpName { get; /* RVA: 0x03D4EB10 */ }
        System.String AssetHelp { get; /* RVA: 0x03D4EAD0 */ }
        System.Int32 AssetID { get; /* RVA: 0x03D57DA0 */ }
        System.String AssetPath { get; /* RVA: 0x03D50E60 */ }
        UnityEngine.GameObject OwnerGameObject { get; /* RVA: 0x0426FB4C */ }
        UnityEngine.GameObject RootGameObject { get; /* RVA: 0x03D51140 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> MaterialCache { get; /* RVA: 0x03D50EA0 */ }
        HoudiniEngineUnity.HEU_Parameters Parameters { get; /* RVA: 0x03D51950 */ }
        System.String AssetCacheFolder { get; /* RVA: 0x03D57300 */ }
        System.String[] SubassetNames { get; /* RVA: 0x03D571B0 */ }
        System.Int32 SelectedSubassetIndex { get; /* RVA: 0x03D6D1F0 */ }
        HoudiniEngineUnity.HEU_AssetCookStatusWrapper CookStatus { get; /* RVA: 0x087EF06C */ }
        HoudiniEngineUnity.HEU_AssetCookResultWrapper LastCookResult { get; /* RVA: 0x087EF08C */ }
        System.Int64 SessionID { get; /* RVA: 0x03D56AF0 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> Curves { get; /* RVA: 0x03D50350 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> InputNodes { get; /* RVA: 0x03D57430 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> VolumeCaches { get; /* RVA: 0x03D57220 */ }
        HoudiniEngineUnity.HEU_ReloadDataEvent ReloadDataEvent { get; /* RVA: 0x03D57170 */ }
        HoudiniEngineUnity.HEU_CookedDataEvent CookedDataEvent { get; /* RVA: 0x03D57160 */ }
        HoudiniEngineUnity.HEU_BakedDataEvent BakedDataEvent { get; /* RVA: 0x03D57130 */ }
        HoudiniEngineUnity.HEU_PreAssetEvent PreAssetEvent { get; /* RVA: 0x03D571E0 */ }
        HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType AssetTypeInternal { get; /* RVA: 0x020D1AC0 */ }
        System.Boolean WarnedPrefabNotSupported { get; /* RVA: 0x03D57C30 */ set; /* RVA: 0x03D5A070 */ }
        HoudiniEngineUnity.HEU_InstanceInputUIState InstanceInputUIState { get; /* RVA: 0x03D56AD0 */ set; /* RVA: 0x04275BD4 */ }
        HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate RefreshUIDelegate { get; /* RVA: 0x03D571D0 */ set; /* RVA: 0x04275C7C */ }
        HoudiniEngineUnity.HEU_Curve.CurveDrawCollision CurveDrawCollisionInternal { get; /* RVA: 0x03D6D130 */ }
        System.Boolean CurveCookOnDrag { get; /* RVA: 0x03D6D110 */ set; /* RVA: 0x03D6D260 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> Handles { get; /* RVA: 0x03D57480 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore> AttributeStores { get; /* RVA: 0x03D56B10 */ }
        HoudiniEngineUnity.HEU_ToolsInfo ToolsInfo { get; /* RVA: 0x03D57350 */ }
        HoudiniEngineUnity.HEU_AssetSerializedMetaData SerializedMetaData { get; /* RVA: 0x03D57440 */ }
        System.Boolean PendingAutoCookOnMouseRelease { get; /* RVA: 0x03D57B60 */ set; /* RVA: 0x03D59550 */ }

        // Methods
        // RVA: 0x03D6D0A0  token: 0x600014F
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus GetCookStatus() { }
        // RVA: 0x03D5DB50  token: 0x6000150
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult GetLastCookResult() { }
        // RVA: 0x03D50340  token: 0x6000158
        private System.Collections.Generic.List<UnityEngine.Collider> GetCurveDrawColliders() { }
        // RVA: 0x03D5A250  token: 0x6000159
        private UnityEngine.LayerMask GetCurveDrawLayerMask() { }
        // RVA: 0x03D5A290  token: 0x600015A
        private System.Void SetCurveDrawLayerMask(UnityEngine.LayerMask mask) { }
        // RVA: 0x0232EB60  token: 0x6000163
        public virtual System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters) { }
        // RVA: 0x0232EB60  token: 0x6000164
        public virtual System.Boolean RequestReload(System.Boolean bAsync) { }
        // RVA: 0x0232EB60  token: 0x6000165
        public virtual System.Boolean RequestResetParameters(System.Boolean bAsync) { }
        // RVA: 0x087E3DE4  token: 0x6000166
        public virtual UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject) { }
        // RVA: 0x087E312C  token: 0x6000167
        public virtual System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild) { }
        // RVA: 0x087E02A8  token: 0x6000168
        public virtual UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath) { }
        // RVA: 0x087E05BC  token: 0x6000169
        public virtual UnityEngine.GameObject BakeToNewStandalone() { }
        // RVA: 0x087DF054  token: 0x600016A
        public virtual System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO) { }
        // RVA: 0x087DF6CC  token: 0x600016B
        public virtual System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO) { }
        // RVA: 0x087E8DA0  token: 0x600016C
        public virtual System.Boolean IsAssetValid() { }
        // RVA: 0x087E7518  token: 0x600016D
        public virtual System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: 0x087E7768  token: 0x600016E
        public virtual System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: 0x087E5E20  token: 0x600016F
        public virtual HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName) { }
        // RVA: 0x087DE554  token: 0x6000170
        public virtual System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider) { }
        // RVA: 0x087EB6D0  token: 0x6000171
        public virtual System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider) { }
        // RVA: 0x087E0F1C  token: 0x6000172
        public virtual System.Boolean ClearCurveDrawColliders() { }
        // RVA: 0x087E64B8  token: 0x6000173
        public virtual HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName) { }
        // RVA: 0x087E5204  token: 0x6000174
        public virtual HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName) { }
        // RVA: 0x087E6444  token: 0x6000175
        public virtual HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index) { }
        // RVA: 0x087E6AE8  token: 0x6000176
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes() { }
        // RVA: 0x087E7B84  token: 0x6000177
        public virtual System.Int32 GetVolumeCacheCount() { }
        // RVA: 0x087E5B14  token: 0x6000178
        public virtual HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid) { }
        // RVA: 0x087E6F68  token: 0x6000179
        public virtual HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName) { }
        // RVA: 0x087E7640  token: 0x600017A
        public virtual System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes) { }
        // RVA: 0x087E6830  token: 0x600017B
        public virtual HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087EC34C  token: 0x600017C
        public virtual System.Void ResetParametersToDefault() { }
        // RVA: 0x087E8178  token: 0x600017D
        public virtual System.Void HideAllGeometry() { }
        // RVA: 0x087E3420  token: 0x600017E
        public virtual System.Void DisableAllColliders() { }
        // RVA: 0x087E698C  token: 0x600017F
        public virtual HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material) { }
        // RVA: 0x087E1378  token: 0x6000180
        public virtual System.Void ClearMaterialCache() { }
        // RVA: 0x087EB834  token: 0x6000181
        public virtual System.Void RemoveMaterial(UnityEngine.Material material) { }
        // RVA: 0x087EC1F0  token: 0x6000182
        public virtual System.Void ResetMaterialOverrides() { }
        // RVA: 0x087E534C  token: 0x6000183
        public virtual HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset() { }
        // RVA: 0x087E73B0  token: 0x6000184
        public virtual HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink() { }
        // RVA: 0x087E8298  token: 0x6000185
        public static HoudiniEngineUnity.HEU_HoudiniAssetRoot InstantiateHDA(System.String filePath, System.Boolean bAsync, UnityEngine.Vector3 initialPosition) { }
        // RVA: 0x087E79B0  token: 0x6000186
        public static HoudiniEngineUnity.HEU_PartData GetSceneHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087E7890  token: 0x6000187
        public static HoudiniEngineUnity.HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087E9D5C  token: 0x6000188
        public static System.Boolean IsHoudiniAssetOutput(UnityEngine.GameObject go) { }
        // RVA: 0x087E9E88  token: 0x6000189
        public static System.Boolean IsHoudiniAssetRoot(UnityEngine.GameObject go) { }
        // RVA: 0x087ECAD8  token: 0x600018A
        private System.Void SetupAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String filePath, UnityEngine.GameObject rootGameObject, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E0944  token: 0x600018B
        private System.Void CleanUpAndDisable() { }
        // RVA: 0x087E8D50  token: 0x600018C
        private System.Boolean IsAssetSavedInScene() { }
        // RVA: 0x0350B670  token: 0x600018D
        private System.Void Awake() { }
        // RVA: 0x03D6D0B0  token: 0x600018E
        private System.Void InvalidateAsset() { }
        // RVA: 0x0350B670  token: 0x600018F
        private System.Void OnEnable() { }
        // RVA: 0x0350B670  token: 0x6000190
        private System.Void OnDestroy() { }
        // RVA: 0x0350B670  token: 0x6000191
        private System.Void AssetUpdate() { }
        // RVA: 0x0350B670  token: 0x6000192
        private System.Void PostAssetUpdate() { }
        // RVA: 0x087EBF20  token: 0x6000193
        private System.Void RequestBakeInPlace() { }
        // RVA: 0x03D6D080  token: 0x6000194
        private System.Void ClearBuildRequest() { }
        // RVA: 0x087E8160  token: 0x6000195
        private System.Boolean HasValidAssetPath() { }
        // RVA: 0x087EAFF4  token: 0x6000196
        private System.Void ProcessRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex) { }
        // RVA: 0x087E8C94  token: 0x6000197
        private System.Void InvokeReloadEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: 0x087ECEF0  token: 0x6000198
        private System.Boolean StartRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex) { }
        // RVA: 0x087E4200  token: 0x6000199
        private System.Boolean FinishRebuild() { }
        // RVA: 0x087EB36C  token: 0x600019A
        private System.Boolean RecookAsync(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync) { }
        // RVA: 0x087EB48C  token: 0x600019B
        private System.Boolean RecookBlocking(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync) { }
        // RVA: 0x087E35C8  token: 0x600019C
        private System.Void DoPostCookWork(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E9EF4  token: 0x600019D
        private System.Boolean IsValidForInteraction(System.String& errorMessage) { }
        // RVA: 0x087EA8DC  token: 0x600019E
        private System.Void OnValidate() { }
        // RVA: 0x087E4164  token: 0x600019F
        private System.Void ExecutePostCookCallbacks() { }
        // RVA: 0x087E8BD8  token: 0x60001A0
        private System.Void InvokePostCookEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: 0x087E84B0  token: 0x60001A1
        private System.Boolean InternalStartRecook(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync) { }
        // RVA: 0x087E8358  token: 0x60001A2
        private System.Void InternalSetAssetID(System.Int32 assetID) { }
        // RVA: 0x03D6D0C0  token: 0x60001A3
        private System.Void SetCookStatus(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus status, HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult result) { }
        // RVA: 0x087EAC18  token: 0x60001A4
        private System.Void ProcessPoskCook() { }
        // RVA: 0x087ECECC  token: 0x60001A5
        private System.Boolean StartHoudiniCookNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EAA68  token: 0x60001A6
        private System.Void ProcessHoudiniCookStatus(System.Boolean bAsync) { }
        // RVA: 0x087E390C  token: 0x60001A7
        private System.Boolean DoesAssetRequireRecook() { }
        // RVA: 0x087E340C  token: 0x60001A8
        private System.Void DeleteSessionDataOnly() { }
        // RVA: 0x087E0ABC  token: 0x60001A9
        private System.Void CleanUpInputNodes() { }
        // RVA: 0x087E33BC  token: 0x60001AA
        private System.Void DeleteAssetCacheData(System.Boolean bRegisterUndo) { }
        // RVA: 0x087E4FF0  token: 0x60001AB
        private System.Void GenerateParameters(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E3D60  token: 0x60001AC
        private System.Void DownloadParameterPresetFromHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EEB74  token: 0x60001AD
        private System.Void UploadParameterPresetToHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EDEA0  token: 0x60001AE
        private System.Void UpdateParameterInputsToHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate) { }
        // RVA: 0x087E9F64  token: 0x60001AF
        private System.Boolean LoadAssetFileWithSubasset(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex) { }
        // RVA: 0x087E2A90  token: 0x60001B0
        private System.Boolean CreateAndCookAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 subassetIndex, System.Int32& newAssetID, System.Boolean bCookTemplatedGeos) { }
        // RVA: 0x087E2BB8  token: 0x60001B1
        private System.Void CreateAssetInputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E4818  token: 0x60001B2
        public System.Void ForceUploadParameters(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EE548  token: 0x60001B3
        private System.Void UploadCurvesParameters(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bCheckParamsChanged) { }
        // RVA: 0x087EDFA4  token: 0x60001B4
        private System.Void UploadAttributeValues(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087ED14C  token: 0x60001B5
        private System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EE9A4  token: 0x60001B6
        private System.Void UploadInputNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate, System.Boolean bUpdateAll) { }
        // RVA: 0x087E7D6C  token: 0x60001B7
        private System.Boolean HasInputNodeTransformChanged() { }
        // RVA: 0x087EA708  token: 0x60001B8
        private System.Void NotifyInputNodesCookFinished() { }
        // RVA: 0x087E2FF0  token: 0x60001B9
        private System.Boolean CreateObjects(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087ED464  token: 0x60001BA
        private System.Void UpdateAllObjectNodes(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E2F0C  token: 0x60001BB
        private HoudiniEngineUnity.HEU_ObjectNode CreateObjectNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo, HoudiniEngineUnity.HAPI_Transform& objectTranform) { }
        // RVA: 0x087E4EB8  token: 0x60001BC
        private System.Void GenerateObjectsGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild) { }
        // RVA: 0x087EA854  token: 0x60001BD
        private System.Int32 NumAttributeStores() { }
        // RVA: 0x087E5B8C  token: 0x60001BE
        private HoudiniEngineUnity.HEU_AttributesStore GetAttributeStore(System.String geoName, System.Int32 partID) { }
        // RVA: 0x087E484C  token: 0x60001BF
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E4B3C  token: 0x60001C0
        private System.Void GenerateInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E4974  token: 0x60001C1
        private System.Void GenerateHandles(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E09BC  token: 0x60001C2
        private System.Void CleanUpHandles() { }
        // RVA: 0x087E60C4  token: 0x60001C3
        private HoudiniEngineUnity.HEU_Handle GetHandleByName(System.String handleName) { }
        // RVA: 0x03D57480  token: 0x60001C4
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> GetHandles() { }
        // RVA: 0x087EA898  token: 0x60001C5
        private System.Int32 NumHandles() { }
        // RVA: 0x087E7238  token: 0x60001C6
        private HoudiniEngineUnity.HAPI_Transform GetObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectID) { }
        // RVA: 0x087E72F4  token: 0x60001C7
        private HoudiniEngineUnity.HEU_ObjectNode GetObjectWithID(System.Int32 objId) { }
        // RVA: 0x087E8B18  token: 0x60001C8
        private System.Void InvokeBakedEvent(System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake) { }
        // RVA: 0x087E13C0  token: 0x60001C9
        private UnityEngine.GameObject CloneAssetWithoutHDA(System.String& bakedAssetPath, System.Boolean bWriteMeshesToAssetDatabase, System.Boolean bReconnectPrefabInstances) { }
        // RVA: 0x087EA820  token: 0x60001CA
        private System.Void NotifyUpstreamCooked(HoudiniEngineUnity.HEU_CookedEventData Data) { }
        // RVA: 0x087E18F4  token: 0x60001CB
        private System.Void ConnectToUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset) { }
        // RVA: 0x087E3538  token: 0x60001CC
        private System.Void DisconnectFromUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset) { }
        // RVA: 0x087DE660  token: 0x60001CD
        private System.Void AddDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver) { }
        // RVA: 0x087EB784  token: 0x60001CE
        private System.Void RemoveDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver) { }
        // RVA: 0x087E0CE4  token: 0x60001CF
        private System.Void ClearAllUpstreamConnections() { }
        // RVA: 0x087EDD78  token: 0x60001D0
        private System.Void UpdateInputsOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EB22C  token: 0x60001D1
        private System.Void ReconnectInputsUpstreamNotifications() { }
        // RVA: 0x087E6200  token: 0x60001D2
        private System.Void GetHoudiniTransformAndApply(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EED58  token: 0x60001D3
        private System.Void UploadUnityTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bOnlySendIfChangedFromLastSync) { }
        // RVA: 0x087EDB98  token: 0x60001D4
        private System.Void UpdateHoudiniMaterials(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087EB94C  token: 0x60001D5
        private System.Void RemoveUnusedMaterials() { }
        // RVA: 0x087E8D6C  token: 0x60001D6
        private System.Boolean IsAssetValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087E7EBC  token: 0x60001D7
        private System.Boolean HasTransformChangedSinceLastUpdate() { }
        // RVA: 0x087E5CEC  token: 0x60001D8
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        // RVA: 0x087E0F68  token: 0x60001D9
        private System.Void ClearInvalidCurves() { }
        // RVA: 0x087E5F8C  token: 0x60001DA
        private System.Int32 GetEditableCurveCount() { }
        // RVA: 0x087DE5DC  token: 0x60001DB
        private System.Void AddCurve(HoudiniEngineUnity.HEU_Curve curve) { }
        // RVA: 0x087EB72C  token: 0x60001DC
        private System.Void RemoveCurve(HoudiniEngineUnity.HEU_Curve curve) { }
        // RVA: 0x03D57430  token: 0x60001DD
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetInputNodes() { }
        // RVA: 0x087DE6E0  token: 0x60001DE
        private System.Void AddInputNode(HoudiniEngineUnity.HEU_InputNode node) { }
        // RVA: 0x087EB7DC  token: 0x60001DF
        private System.Void RemoveInputNode(HoudiniEngineUnity.HEU_InputNode node) { }
        // RVA: 0x087E8290  token: 0x60001E0
        private System.Void InputNodeNotifyRemoved(HoudiniEngineUnity.HEU_InputNode node) { }
        // RVA: 0x087DE7D0  token: 0x60001E1
        private System.Void AddVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache) { }
        // RVA: 0x087EBD98  token: 0x60001E2
        private System.Void RemoveVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache) { }
        // RVA: 0x087DE400  token: 0x60001E3
        private System.Void AddAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore) { }
        // RVA: 0x087EB678  token: 0x60001E4
        private System.Void RemoveAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore) { }
        // RVA: 0x087EBE1C  token: 0x60001E5
        private System.Void ReorderAttributeStore(System.Int32 oldIndex, System.Int32 newIndex) { }
        // RVA: 0x087EA910  token: 0x60001E6
        private System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos) { }
        // RVA: 0x087DE764  token: 0x60001E7
        private System.Void AddToAssetDBCache(System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, UnityEngine.Object& targetAssetDBObject) { }
        // RVA: 0x087EC730  token: 0x60001E8
        private static System.Void SetCurvesVisibilityInScene(System.Boolean bShow) { }
        // RVA: 0x087E7AEC  token: 0x60001E9
        private System.String GetValidAssetCacheFolderPath() { }
        // RVA: 0x087E082C  token: 0x60001EA
        private System.Void CalculateVisibility() { }
        // RVA: 0x087E0714  token: 0x60001EB
        private System.Void CalculateColliderState() { }
        // RVA: 0x087EA240  token: 0x60001EC
        private System.Void LoadAssetPresetAndCook(HoudiniEngineUnity.HEU_AssetPreset assetPreset) { }
        // RVA: 0x087DEB6C  token: 0x60001ED
        private System.Void ApplyRecookPreset() { }
        // RVA: 0x087DE854  token: 0x60001EE
        private System.Boolean ApplyInputPresets(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> inputPresets, System.Boolean bAddMissingInputsToRecookPreset) { }
        // RVA: 0x087E7BC8  token: 0x60001EF
        private HoudiniEngineUnity.HEU_VolumeCachePreset GetVolumeCachePreset(System.String objName, System.String geoName, System.Int32 tile) { }
        // RVA: 0x087EBD34  token: 0x60001F0
        private System.Void RemoveVolumeCachePreset(HoudiniEngineUnity.HEU_VolumeCachePreset preset) { }
        // RVA: 0x087DEC0C  token: 0x60001F1
        private System.Boolean ApplyVolumeCachePresets(System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> volumeCachePresets) { }
        // RVA: 0x087ED294  token: 0x60001F2
        private System.Void SyncInternalParametersForUndoCompare() { }
        // RVA: 0x087EDF38  token: 0x60001F3
        private System.Boolean UpdateSessionSync() { }
        // RVA: 0x087EDF90  token: 0x60001F4
        private System.Void UpdateTotalCookCount() { }
        // RVA: 0x087EBF34  token: 0x60001F5
        private System.Void ResetAndCopyInstantiatedProperties(HoudiniEngineUnity.HEU_HoudiniAsset newAsset) { }
        // RVA: 0x087E6688  token: 0x60001F6
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod GetInstantiationMethod() { }
        // RVA: 0x087E65FC  token: 0x60001F7
        private HoudiniEngineUnity.HEU_HoudiniAsset GetInstantiatedObject() { }
        // RVA: 0x087E1090  token: 0x60001F8
        private System.Void ClearInvalidLists() { }
        // RVA: 0x087E1984  token: 0x60001F9
        private System.Void CopyPropertiesTo(HoudiniEngineUnity.HEU_HoudiniAsset newAsset) { }
        // RVA: 0x087EC900  token: 0x60001FA
        private System.Void SetSoftDeleted() { }
        // RVA: 0x087ED068  token: 0x60001FB
        private System.Void SyncChildTransforms() { }
        // RVA: 0x087DEFE4  token: 0x60001FC
        private static HoudiniEngineUnity.HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus assetCookStatus) { }
        // RVA: 0x087DEFE4  token: 0x60001FD
        private static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus AssetCookStatus_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookStatusWrapper assetCookStatus) { }
        // RVA: 0x087DEFC4  token: 0x60001FE
        private static HoudiniEngineUnity.HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult assetCookResult) { }
        // RVA: 0x087DEFC4  token: 0x60001FF
        private static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult AssetCookResult_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookResultWrapper assetCookResult) { }
        // RVA: 0x087E3104  token: 0x6000200
        private static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HoudiniEngineUnity.HEU_Curve.CurveDrawCollision curveDrawCollision) { }
        // RVA: 0x087E311C  token: 0x6000201
        private static HoudiniEngineUnity.HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper curveDrawCollision) { }
        // RVA: 0x087DF02C  token: 0x6000202
        private static HoudiniEngineUnity.HEU_AssetTypeWrapper AssetType_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType) { }
        // RVA: 0x087DF02C  token: 0x6000203
        private static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType AssetType_WrapperToInternal(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType) { }
        // RVA: 0x087E8DDC  token: 0x6000204
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x087EEDC4  token: 0x6000205
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x28
    public class HEU_HoudiniAssetRoot : UnityEngine.MonoBehaviour
    {
        // Fields
        private HoudiniEngineUnity.HEU_HoudiniAsset _houdiniAsset;  // 0x18
        private System.Collections.Generic.List<UnityEngine.GameObject> _bakeTargets;  // 0x20

        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset HoudiniAsset { get; /* RVA: 0x01041090 */ }
        System.Collections.Generic.List<UnityEngine.GameObject> BakeTargets { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x087F4614  token: 0x600021A
        private System.Void OnDestroy() { }
        // RVA: 0x087F46B8  token: 0x600021B
        private System.Void RemoveHoudiniEngineAssetData() { }
        // RVA: 0x087F45B0  token: 0x600021C
        private System.Void ClearHoudiniEngineReferences() { }
        // RVA: 0x087F4604  token: 0x600021D
        private static System.Void DestroyRootComponent(HoudiniEngineUnity.HEU_HoudiniAssetRoot assetRoot) { }
        // RVA: 0x087F4764  token: 0x600021E
        private System.Void Reset() { }
        // RVA: 0x087F4820  token: 0x600021F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003A  // size: 0xA8
    public class HEU_InputNode : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_InputNode, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputNode.InputNodeType _inputNodeType;  // 0x18
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType _inputObjectType;  // 0x1c
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType _pendingInputObjectType;  // 0x20
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo> _inputObjects;  // 0x28
        private System.Collections.Generic.List<System.Int32> _inputObjectsConnectedAssetIDs;  // 0x30
        private UnityEngine.GameObject _inputAsset;  // 0x38
        private UnityEngine.GameObject _connectedInputAsset;  // 0x40
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo> _inputAssetInfos;  // 0x48
        private System.Int32 _nodeID;  // 0x50
        private System.Int32 _inputIndex;  // 0x54
        private System.Boolean _requiresCook;  // 0x58
        private System.Boolean _requiresUpload;  // 0x59
        private System.String _inputName;  // 0x60
        private System.String _labelName;  // 0x68
        private System.String _paramName;  // 0x70
        private System.Int32 _connectedNodeID;  // 0x78
        private System.Boolean _keepWorldTransform;  // 0x7c
        private System.Boolean _packGeometryBeforeMerging;  // 0x7d
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;  // 0x80
        private HoudiniEngineUnity.HEU_InputInterfaceMeshSettings _meshSettings;  // 0x88
        private HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings _tilemapSettings;  // 0x90
        private System.Boolean _usingSelectFromHierarchy;  // 0x98
        public HoudiniEngineUnity.HEU_InputNodeUICache _uiCache;  // 0xa0

        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x03D4EAE0 */ }
        System.Boolean KeepWorldTransform { get; /* RVA: 0x03D58A60 */ set; /* RVA: 0x03D58A90 */ }
        System.Boolean PackGeometryBeforeMerging { get; /* RVA: 0x03D6CFA0 */ set; /* RVA: 0x03D6D3E0 */ }
        HoudiniEngineUnity.HEU_InputNodeTypeWrapper NodeType { get; /* RVA: 0x087F9420 */ }
        HoudiniEngineUnity.HEU_InputObjectTypeWrapper ObjectType { get; /* RVA: 0x087F9440 */ }
        HoudiniEngineUnity.HEU_InputObjectTypeWrapper PendingObjectType { get; /* RVA: 0x087F944C */ set; /* RVA: 0x087F9458 */ }
        System.Int32 InputNodeID { get; /* RVA: 0x03D4EED0 */ }
        System.String InputName { get; /* RVA: 0x03D4EB00 */ }
        System.String LabelName { get; /* RVA: 0x03D4EAB0 */ }
        System.String ParamName { get; /* RVA: 0x03D4EB30 */ }
        HoudiniEngineUnity.HEU_InputInterfaceMeshSettings MeshSettings { get; /* RVA: 0x03D4EA60 */ }
        HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings TilemapSettings { get; /* RVA: 0x03D4EA90 */ }
        HoudiniEngineUnity.HEU_InputNode.InputNodeType InputType { get; /* RVA: 0x020D1AC0 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo> InputObjects { get; /* RVA: 0x03D4EAC0 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo> InputAssetInfos { get; /* RVA: 0x03D4EA70 */ }
        System.Boolean RequiresCook { get; /* RVA: 0x03D4F7E0 */ set; /* RVA: 0x03D4F7F0 */ }
        System.Boolean RequiresUpload { get; /* RVA: 0x03D589D0 */ set; /* RVA: 0x03D5B3E0 */ }

        // Methods
        // RVA: 0x087F5DBC  token: 0x6000236
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x087F7A8C  token: 0x6000237
        public virtual System.Void Recook() { }
        // RVA: 0x062FD96C  token: 0x6000238
        public virtual System.Boolean IsAssetInput() { }
        // RVA: 0x087F71D4  token: 0x6000239
        public virtual System.Int32 NumInputEntries() { }
        // RVA: 0x087F5A0C  token: 0x600023A
        public virtual UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index) { }
        // RVA: 0x087F5C20  token: 0x600023B
        public virtual UnityEngine.GameObject[] GetInputEntryGameObjects() { }
        // RVA: 0x087F8254  token: 0x600023C
        public virtual System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        // RVA: 0x087F64D0  token: 0x600023D
        public virtual System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        // RVA: 0x087F4A80  token: 0x600023E
        public virtual System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset) { }
        // RVA: 0x087F7DD8  token: 0x600023F
        public virtual System.Void ResetInputNode(System.Boolean bRecookAsset) { }
        // RVA: 0x087F4C60  token: 0x6000240
        public virtual System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset) { }
        // RVA: 0x087F7B60  token: 0x6000241
        public virtual System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset) { }
        // RVA: 0x087F7AF8  token: 0x6000242
        public virtual System.Void RemoveAllInputEntries(System.Boolean bRecookAsset) { }
        // RVA: 0x087F819C  token: 0x6000243
        public virtual System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset) { }
        // RVA: 0x087F80D8  token: 0x6000244
        public virtual System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset) { }
        // RVA: 0x087F7F48  token: 0x6000245
        public virtual System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset) { }
        // RVA: 0x087F8010  token: 0x6000246
        public virtual System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset) { }
        // RVA: 0x087F4B20  token: 0x6000247
        public virtual System.Boolean AreAnyInputHDAsConnected() { }
        // RVA: 0x087F58DC  token: 0x6000248
        public virtual System.Int32 GetConnectedInputCount() { }
        // RVA: 0x087F5950  token: 0x6000249
        public virtual System.Int32 GetConnectedNodeID(System.Int32 index) { }
        // RVA: 0x087F6BE8  token: 0x600024A
        public virtual System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        // RVA: 0x087F7248  token: 0x600024B
        public virtual System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        // RVA: 0x087F5404  token: 0x600024C
        private static HoudiniEngineUnity.HEU_InputNode CreateSetupInput(System.Int32 nodeID, System.Int32 inputIndex, System.String inputName, System.String labelName, HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x03D4EF20  token: 0x600024D
        private System.Void SetInputNodeID(System.Int32 nodeID) { }
        // RVA: 0x087F54B8  token: 0x600024E
        private System.Void DestroyAllData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F7E68  token: 0x600024F
        private System.Void ResetInputObjectTransforms() { }
        // RVA: 0x087F7E1C  token: 0x6000250
        private System.Void ResetInputNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F4A44  token: 0x6000251
        private HoudiniEngineUnity.HEU_InputObjectInfo AddInputEntryAtEndMesh(UnityEngine.GameObject newEntryGameObject) { }
        // RVA: 0x087F4A08  token: 0x6000252
        private HoudiniEngineUnity.HEU_InputHDAInfo AddInputEntryAtEndHDA(UnityEngine.GameObject newEntryGameObject) { }
        // RVA: 0x087F4CC8  token: 0x6000253
        private System.Void ChangeInputType(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode.InputObjectType newType) { }
        // RVA: 0x087F7D88  token: 0x6000254
        private System.Void ResetConnectionForForceUpdate(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F88A0  token: 0x6000255
        private System.Void UploadInput(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F861C  token: 0x6000256
        private System.Void UploadHDAInput(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F8D58  token: 0x6000257
        private System.Void UploadUnityInput(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F7860  token: 0x6000258
        private System.Void ReconnectToUpstreamAsset() { }
        // RVA: 0x087F5390  token: 0x6000259
        private HoudiniEngineUnity.HEU_InputObjectInfo CreateInputObjectInfo(UnityEngine.GameObject inputGameObject) { }
        // RVA: 0x087F5328  token: 0x600025A
        private HoudiniEngineUnity.HEU_InputHDAInfo CreateInputHDAInfo(UnityEngine.GameObject inputGameObject) { }
        // RVA: 0x087F6798  token: 0x600025B
        private HoudiniEngineUnity.HEU_InputObjectInfo InternalAddInputObjectAtEnd(UnityEngine.GameObject newInputGameObject) { }
        // RVA: 0x087F672C  token: 0x600025C
        private HoudiniEngineUnity.HEU_InputHDAInfo InternalAddInputHDAAtEnd(UnityEngine.GameObject newInputHDA) { }
        // RVA: 0x087F568C  token: 0x600025D
        private System.Void DisconnectConnectedMergeNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F4CF8  token: 0x600025E
        private System.Void ClearConnectedInputHDAs() { }
        // RVA: 0x087F4EDC  token: 0x600025F
        private System.Void ConnectToMergeObject(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F54FC  token: 0x6000260
        private System.Void DisconnectAndDestroyInputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F8CCC  token: 0x6000261
        private System.Boolean UploadObjectMergeTransformType(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F8C40  token: 0x6000262
        private System.Boolean UploadObjectMergePackGeometry(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F6014  token: 0x6000263
        private System.Boolean HasInputNodeTransformChanged() { }
        // RVA: 0x087F8744  token: 0x6000264
        private System.Void UploadInputObjectTransforms(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F84B0  token: 0x6000265
        private System.Void UpdateOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F4F80  token: 0x6000266
        private System.Void CopyInputValuesTo(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode destInputNode) { }
        // RVA: 0x087F6C20  token: 0x6000267
        private System.Void LoadPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        // RVA: 0x087F57C0  token: 0x6000268
        private System.Boolean FindAddToInputHDA(System.String gameObjectName) { }
        // RVA: 0x087F715C  token: 0x6000269
        private System.Void NotifyParentRemovedInput() { }
        // RVA: 0x087F4EC4  token: 0x600026A
        private System.Void ClearUICache() { }
        // RVA: 0x087F5F34  token: 0x600026B
        private System.Void HandleSelectedObjectsForInputObjects(UnityEngine.GameObject[] selectedObjects) { }
        // RVA: 0x087F5E54  token: 0x600026C
        private System.Void HandleSelectedObjectsForInputHDAs(UnityEngine.GameObject[] selectedObjects) { }
        // RVA: 0x087F6804  token: 0x600026D
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputNode other) { }
        // RVA: 0x087F5D78  token: 0x600026E
        private static HoudiniEngineUnity.HEU_InputNode.InternalObjectType GetInternalObjectType(HoudiniEngineUnity.HEU_InputNode.InputObjectType type) { }
        // RVA: 0x087DEFC4  token: 0x600026F
        private static HoudiniEngineUnity.HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType) { }
        // RVA: 0x087DEFC4  token: 0x6000270
        private static HoudiniEngineUnity.HEU_InputNode.InputNodeType InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNodeTypeWrapper inputNodeType) { }
        // RVA: 0x087F6480  token: 0x6000271
        private static HoudiniEngineUnity.HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputObjectType inputType) { }
        // RVA: 0x087F6480  token: 0x6000272
        private static HoudiniEngineUnity.HEU_InputNode.InputObjectType InputObjectType_WrapperToInternal(HoudiniEngineUnity.HEU_InputObjectTypeWrapper inputType) { }
        // RVA: 0x087F9288  token: 0x6000273
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003F  // size: 0xA8
    public class HEU_InputObjectInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _gameObject;  // 0x10
        public UnityEngine.Terrain _terrainReference;  // 0x18
        public HEU_BoundingVolume _boundingVolumeReference;  // 0x20
        public UnityEngine.Tilemaps.Tilemap _tilemapReference;  // 0x28
        public UnityEngine.Matrix4x4 _syncdTransform;  // 0x30
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> _syncdChildTransforms;  // 0x70
        public System.Boolean _useTransformOffset;  // 0x78
        public UnityEngine.Vector3 _translateOffset;  // 0x7c
        public UnityEngine.Vector3 _rotateOffset;  // 0x88
        public UnityEngine.Vector3 _scaleOffset;  // 0x94
        public System.Type _inputInterfaceType;  // 0xa0

        // Methods
        // RVA: 0x087F9478  token: 0x6000274
        public System.Void CopyTo(HoudiniEngineUnity.HEU_InputObjectInfo destObject) { }
        // RVA: 0x087F97D8  token: 0x6000275
        private System.Void SetReferencesFromGameObject() { }
        // RVA: 0x087F957C  token: 0x6000276
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputObjectInfo other) { }
        // RVA: 0x087F98C0  token: 0x6000277
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000040  // size: 0x28
    public class HEU_InputHDAInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _pendingGO;  // 0x10
        public UnityEngine.GameObject _connectedGO;  // 0x18
        public System.Int32 _connectedInputNodeID;  // 0x20
        public System.Int32 _connectedMergeNodeID;  // 0x24

        // Methods
        // RVA: 0x087F48A0  token: 0x6000278
        public System.Void CopyTo(HoudiniEngineUnity.HEU_InputHDAInfo destInfo) { }
        // RVA: 0x087F48E4  token: 0x6000279
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputHDAInfo other) { }
        // RVA: 0x03D6D3D0  token: 0x600027A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000041  // size: 0x20
    public class HEU_InputNodeUICache
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputObjectUICache> _inputObjectCache;  // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputAssetUICache> _inputAssetCache;  // 0x18

        // Methods
        // RVA: 0x087F4948  token: 0x600027B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x28
    public class HEU_InstanceInputUIState : UnityEngine.ScriptableObject, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.Boolean _showInstanceInputs;  // 0x18
        public System.Int32 _numInputsToShowUI;  // 0x1c
        public System.Int32 _inputsPageIndexUI;  // 0x20

        // Methods
        // RVA: 0x087F99BC  token: 0x600027E
        private System.Void CopyTo(HoudiniEngineUnity.HEU_InstanceInputUIState dest) { }
        // RVA: 0x087F99E4  token: 0x600027F
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstanceInputUIState other) { }
        // RVA: 0x087F9B3C  token: 0x6000280
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000045  // size: 0x40
    public class HEU_ObjectInstanceInfo : UnityEngine.ScriptableObject, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InstancedInput> _instancedInputs;  // 0x18
        public HoudiniEngineUnity.HEU_PartData _partTarget;  // 0x20
        public System.Int32 _instancedObjectNodeID;  // 0x28
        public System.String _instancedObjectPath;  // 0x30
        public System.Collections.Generic.List<UnityEngine.GameObject> _instances;  // 0x38

        // Methods
        // RVA: 0x087F9D08  token: 0x6000281
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectInstanceInfo other) { }
        // RVA: 0x087F9E28  token: 0x6000282
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x30
    public class HEU_InstancedInput : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _instancedGameObject;  // 0x10
        public UnityEngine.Vector3 _rotationOffset;  // 0x18
        public UnityEngine.Vector3 _scaleOffset;  // 0x24

        // Methods
        // RVA: 0x087F9B50  token: 0x6000283
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstancedInput other) { }
        // RVA: 0x087F9CDC  token: 0x6000284
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000047  // size: 0x80
    public class HEU_ObjectNode : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_ObjectNode, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.String _objName;  // 0x18
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;  // 0x20
        private HoudiniEngineUnity.HAPI_ObjectInfo _objectInfo;  // 0x28
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> _geoNodes;  // 0x48
        private HoudiniEngineUnity.HAPI_Transform _objectTransform;  // 0x50
        private System.Collections.Generic.List<System.Int32> _recentlyDestroyedParts;  // 0x78

        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x03D4EB40 */ }
        System.Int32 ObjectID { get; /* RVA: 0x03D4ED90 */ }
        System.String ObjectName { get; /* RVA: 0x01041090 */ }
        HoudiniEngineUnity.HAPI_ObjectInfo ObjectInfo { get; /* RVA: 0x03D5D990 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> GeoNodes { get; /* RVA: 0x03D4EA70 */ }
        HoudiniEngineUnity.HAPI_Transform ObjectTransform { get; /* RVA: 0x03D6D410 */ }

        // Methods
        // RVA: 0x087FC010  token: 0x600028B
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x087FCAF0  token: 0x600028C
        public virtual System.Void Recook() { }
        // RVA: 0x03D4F570  token: 0x600028D
        public virtual System.Boolean IsInstanced() { }
        // RVA: 0x03D4F630  token: 0x600028E
        public virtual System.Boolean IsVisible() { }
        // RVA: 0x087FC750  token: 0x600028F
        public virtual System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        // RVA: 0x087FBC74  token: 0x6000290
        public virtual System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: 0x087FBEEC  token: 0x6000291
        public virtual System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: 0x087FBB1C  token: 0x6000292
        public virtual HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087FB9DC  token: 0x6000293
        public virtual HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName) { }
        // RVA: 0x087FB610  token: 0x6000294
        public virtual System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        // RVA: 0x087FBD98  token: 0x6000295
        public virtual System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes) { }
        // RVA: 0x087FC0A4  token: 0x6000296
        public virtual System.Void HideAllGeometry() { }
        // RVA: 0x087FA57C  token: 0x6000297
        public virtual System.Void DisableAllColliders() { }
        // RVA: 0x087FC62C  token: 0x6000298
        public virtual System.Boolean IsInstancer() { }
        // RVA: 0x087FCF00  token: 0x6000299
        public System.Void .ctor() { }
        // RVA: 0x087FCB54  token: 0x600029A
        private System.Void Reset() { }
        // RVA: 0x087FCC54  token: 0x600029B
        private System.Void SyncWithObjectInfo(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087FC1B8  token: 0x600029C
        private System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, HoudiniEngineUnity.HAPI_Transform objectTranform, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bUseOutputNodes) { }
        // RVA: 0x087FA690  token: 0x600029D
        private System.Void GatherAllAssetOutputsLegacy(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode>& geoNodes) { }
        // RVA: 0x087FA4A4  token: 0x600029E
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        // RVA: 0x087FA3F8  token: 0x600029F
        private HoudiniEngineUnity.HEU_GeoNode CreateGeoNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo) { }
        // RVA: 0x087FB744  token: 0x60002A0
        private System.Void GetDebugInfo(System.Text.StringBuilder sb) { }
        // RVA: 0x03D6D3F0  token: 0x60002A1
        private System.Void SetObjectInfo(HoudiniEngineUnity.HAPI_ObjectInfo newObjectInfo) { }
        // RVA: 0x087FCD80  token: 0x60002A2
        private System.Void UpdateObject(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate) { }
        // RVA: 0x087FA860  token: 0x60002A3
        private System.Void GenerateGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild) { }
        // RVA: 0x087FB3A8  token: 0x60002A4
        private System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087FA73C  token: 0x60002A5
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F9EF4  token: 0x60002A6
        private System.Void ApplyObjectTransformToGeoNodes() { }
        // RVA: 0x087FB4CC  token: 0x60002A7
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        // RVA: 0x087FAFC8  token: 0x60002A8
        private System.Void GenerateObjectInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087FA248  token: 0x60002A9
        private System.Void ClearObjectInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087FC87C  token: 0x60002AA
        private System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos) { }
        // RVA: 0x087FC9CC  token: 0x60002AB
        private System.Void ProcessUnityScriptAttributes(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087FA128  token: 0x60002AC
        private System.Void CalculateVisibility() { }
        // RVA: 0x087FA014  token: 0x60002AD
        private System.Void CalculateColliderState() { }
        // RVA: 0x087FCD24  token: 0x60002AE
        public virtual System.String ToString() { }
        // RVA: 0x087FC3B4  token: 0x60002AF
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectNode other) { }

    }

    // TypeToken: 0x2000048  // size: 0xA0
    public class HEU_PartData : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_PartData, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.Int32 _partID;  // 0x18
        private System.String _partName;  // 0x20
        private System.Int32 _objectNodeID;  // 0x28
        private System.Int32 _geoID;  // 0x2c
        private HoudiniEngineUnity.HAPI_PartType _partType;  // 0x30
        private HoudiniEngineUnity.HEU_GeoNode _geoNode;  // 0x38
        private System.Boolean _isAttribInstancer;  // 0x40
        private System.Boolean _isPartInstanced;  // 0x41
        private System.Int32 _partPointCount;  // 0x44
        private System.Boolean _isObjectInstancer;  // 0x48
        private System.Boolean _objectInstancesGenerated;  // 0x49
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> _objectInstanceInfos;  // 0x50
        private UnityEngine.Vector3 _terrainOffsetPosition;  // 0x58
        private UnityEngine.Object _assetDBTerrainData;  // 0x68
        private System.Boolean _isPartEditable;  // 0x70
        private HoudiniEngineUnity.HEU_PartData.PartOutputType _partOutputType;  // 0x74
        private HoudiniEngineUnity.HEU_Curve _curve;  // 0x78
        private HoudiniEngineUnity.HEU_AttributesStore _attributesStore;  // 0x80
        private System.Boolean _haveInstancesBeenGenerated;  // 0x88
        private System.Int32 _meshVertexCount;  // 0x8c
        private HoudiniEngineUnity.HEU_GeneratedOutput _generatedOutput;  // 0x90
        private System.String _volumeLayerName;  // 0x98

        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x088047AC */ }
        System.Int32 PartID { get; /* RVA: 0x020D1AC0 */ }
        System.String PartName { get; /* RVA: 0x03D4EB40 */ }
        System.Int32 GeoID { get; /* RVA: 0x03D4EDD0 */ }
        HoudiniEngineUnity.HAPI_PartType PartType { get; /* RVA: 0x03D4ED20 */ }
        HoudiniEngineUnity.HEU_GeoNode ParentGeoNode { get; /* RVA: 0x03D4E2A0 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> ObjectInstanceInfos { get; /* RVA: 0x03D4EAF0 */ }
        HoudiniEngineUnity.HEU_Curve Curve { get; /* RVA: 0x03D4EB20 */ }
        System.Int32 MeshVertexCount { get; /* RVA: 0x03D4F3D0 */ }
        HoudiniEngineUnity.HEU_GeneratedOutput GeneratedOutput { get; /* RVA: 0x03D4EA90 */ }
        UnityEngine.GameObject OutputGameObject { get; /* RVA: 0x08804784 */ }

        // Methods
        // RVA: 0x08804700  token: 0x60002BB
        public System.Void .ctor() { }
        // RVA: 0x08803410  token: 0x60002BC
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x08803D60  token: 0x60002BD
        public virtual System.Void Recook() { }
        // RVA: 0x08803B60  token: 0x60002BE
        public virtual System.Boolean IsPartInstancer() { }
        // RVA: 0x03D4EE90  token: 0x60002BF
        public virtual System.Boolean IsAttribInstancer() { }
        // RVA: 0x08803B44  token: 0x60002C0
        public virtual System.Boolean IsInstancerAnyType() { }
        // RVA: 0x03D4F7B0  token: 0x60002C1
        public virtual System.Boolean IsPartInstanced() { }
        // RVA: 0x03D4EE80  token: 0x60002C2
        public virtual System.Int32 GetPartPointCount() { }
        // RVA: 0x03D4EFE0  token: 0x60002C3
        public virtual System.Boolean IsObjectInstancer() { }
        // RVA: 0x08803B70  token: 0x60002C4
        public virtual System.Boolean IsPartVolume() { }
        // RVA: 0x08803B58  token: 0x60002C5
        public virtual System.Boolean IsPartCurve() { }
        // RVA: 0x08803B68  token: 0x60002C6
        public virtual System.Boolean IsPartMesh() { }
        // RVA: 0x03D4F260  token: 0x60002C7
        public virtual System.Boolean IsPartEditable() { }
        // RVA: 0x03D51D50  token: 0x60002C8
        public virtual System.Boolean HaveInstancesBeenGenerated() { }
        // RVA: 0x08803DF8  token: 0x60002C9
        public virtual System.Void SetGameObjectName(System.String partName) { }
        // RVA: 0x08803FF0  token: 0x60002CA
        public virtual System.Void SetGameObject(UnityEngine.GameObject gameObject) { }
        // RVA: 0x051417AC  token: 0x60002CB
        public virtual System.Void SetVolumeLayerName(System.String name) { }
        // RVA: 0x011AC510  token: 0x60002CC
        public virtual System.String GetVolumeLayerName() { }
        // RVA: 0x088009C0  token: 0x60002CD
        public virtual System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        // RVA: 0x08803B78  token: 0x60002CE
        public virtual System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        // RVA: 0x08803304  token: 0x60002CF
        public virtual System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: 0x088033A8  token: 0x60002D0
        public virtual System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: 0x08803120  token: 0x60002D1
        public virtual HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject) { }
        // RVA: 0x087FDD58  token: 0x60002D2
        public System.Void CalculateVisibility(System.Boolean bParentVisibility, System.Boolean bParentDisplayGeo) { }
        // RVA: 0x087FDE84  token: 0x60002D3
        public virtual System.Void ClearInstances() { }
        // RVA: 0x08802ED4  token: 0x60002D4
        public virtual HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly) { }
        // RVA: 0x088042E8  token: 0x60002D5
        public virtual System.Void SetVisiblity(System.Boolean bVisibility) { }
        // RVA: 0x08803DD4  token: 0x60002D6
        public virtual System.Void SetColliderState(System.Boolean bEnabled) { }
        // RVA: 0x08803240  token: 0x60002D7
        public virtual HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path) { }
        // RVA: 0x08803190  token: 0x60002D8
        public virtual HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID) { }
        // RVA: 0x03D58910  token: 0x60002D9
        public virtual System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition) { }
        // RVA: 0x08804144  token: 0x60002DA
        public virtual System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser) { }
        // RVA: 0x088034B4  token: 0x60002DB
        private System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, System.Int32 geoID, System.Int32 objectNodeID, HoudiniEngineUnity.HEU_GeoNode geoNode, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData.PartOutputType partOutputType, System.Boolean isEditable, System.Boolean isObjectInstancer, System.Boolean isAttribInstancer) { }
        // RVA: 0x087FCFC8  token: 0x60002DC
        private System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform) { }
        // RVA: 0x08802F58  token: 0x60002DD
        private System.Void GetDebugInfo(System.Text.StringBuilder sb) { }
        // RVA: 0x08802D94  token: 0x60002DE
        private System.Void GetClonableObjects(System.Collections.Generic.List<UnityEngine.GameObject> clonableObjects) { }
        // RVA: 0x08802E38  token: 0x60002DF
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        // RVA: 0x03D4F010  token: 0x60002E0
        private System.Void SetObjectInstancer(System.Boolean bObjectInstancer) { }
        // RVA: 0x087FE18C  token: 0x60002E1
        private System.Void ClearObjectInstanceInfos() { }
        // RVA: 0x087FDF6C  token: 0x60002E2
        private System.Void ClearInvalidObjectInstanceInfos() { }
        // RVA: 0x087FDD84  token: 0x60002E3
        private System.Void ClearGeneratedData() { }
        // RVA: 0x087FDDA0  token: 0x60002E4
        private System.Void ClearGeneratedMeshOutput() { }
        // RVA: 0x087FDE3C  token: 0x60002E5
        private System.Void ClearGeneratedVolumeOutput() { }
        // RVA: 0x08802C00  token: 0x60002E6
        private System.Boolean GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08800D58  token: 0x60002E7
        private System.Void GenerateInstancesFromObjectID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectNodeID, System.String[] instancePrefixes, System.String[] instanceMaterialPaths) { }
        // RVA: 0x0880183C  token: 0x60002E8
        private System.Void GenerateInstancesFromObject(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ObjectNode sourceObject, System.String[] instancePrefixes, System.String[] instanceMaterialPaths) { }
        // RVA: 0x088011C0  token: 0x60002E9
        private System.Void GenerateInstancesFromObjectIds(HoudiniEngineUnity.HEU_SessionBase session, System.String[] instancePrefixes, System.String[] instanceMaterialPaths) { }
        // RVA: 0x08801BB0  token: 0x60002EA
        private System.Void GenerateInstancesFromUnityAssetPathAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.String unityInstanceAttr) { }
        // RVA: 0x08800480  token: 0x60002EB
        private System.Void CreateNewInstanceFromObject(UnityEngine.GameObject sourceObject, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Int32 instancedObjectNodeID, System.String instancedObjectPath, UnityEngine.Vector3 rotationOffset, UnityEngine.Vector3 scaleOffset, System.String[] instancePrefixes, System.String[] instanceMaterialPaths, UnityEngine.GameObject collisionSrcGO, System.Boolean copyParentFlags) { }
        // RVA: 0x08800CBC  token: 0x60002EC
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087FDABC  token: 0x60002ED
        private System.Void CalculateColliderState() { }
        // RVA: 0x087FE6AC  token: 0x60002EE
        private static System.Void CopyGameObjectComponents(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> lodTransformValues) { }
        // RVA: 0x087FE2FC  token: 0x60002EF
        private static System.Void CopyChildGameObjects(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bKeepPreviousTransformValues) { }
        // RVA: 0x087FD97C  token: 0x60002F0
        private UnityEngine.GameObject BakePartToNewGameObject(UnityEngine.Transform parentTransform, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances) { }
        // RVA: 0x087FD100  token: 0x60002F1
        private static System.Void BakePartToGameObject(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject srcGO, UnityEngine.GameObject targetGO, System.String assetName, System.Boolean bIsInstancer, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues) { }
        // RVA: 0x087FD830  token: 0x60002F2
        private System.Void BakePartToGameObject(UnityEngine.GameObject targetGO, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues) { }
        // RVA: 0x088027CC  token: 0x60002F3
        private System.Boolean GenerateMesh(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups) { }
        // RVA: 0x08803BF8  token: 0x60002F4
        private System.Void ProcessCurvePart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId) { }
        // RVA: 0x0880457C  token: 0x60002F5
        private System.Void SyncAttributesStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x088044B0  token: 0x60002F6
        private System.Void SetupAttributeGeometry(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08800AF8  token: 0x60002F7
        private System.Void DestroyAttributesStore() { }
        // RVA: 0x08803BA4  token: 0x60002F8
        private System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos) { }
        // RVA: 0x08804020  token: 0x60002F9
        private System.Void SetObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> sourceObjectInstanceInfos) { }
        // RVA: 0x03D4EAF0  token: 0x60002FA
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> GetObjectInstanceInfos() { }
        // RVA: 0x08800874  token: 0x60002FB
        private HoudiniEngineUnity.HEU_ObjectInstanceInfo CreateObjectInstanceInfo(UnityEngine.GameObject instancedObject, System.Int32 instancedObjectNodeID, System.String instancedObjectPath) { }
        // RVA: 0x087FCF8C  token: 0x60002FC
        private static System.String AppendBakedCloneName(System.String name) { }
        // RVA: 0x088046A4  token: 0x60002FD
        public virtual System.String ToString() { }
        // RVA: 0x08800C10  token: 0x60002FE
        private static System.Void DestroyParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> parts, System.Boolean bIsRebuild) { }
        // RVA: 0x08800BDC  token: 0x60002FF
        private static System.Void DestroyPart(HoudiniEngineUnity.HEU_PartData part, System.Boolean bIsRebuild) { }
        // RVA: 0x087FE244  token: 0x6000300
        private static System.Boolean ComposeUnityInstanceSplitHierarchy(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Transform parentTransform, System.Int32 numInstances, UnityEngine.Transform[]& instanceToChildTransform) { }
        // RVA: 0x08803670  token: 0x6000301
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_PartData other) { }

    }

    // TypeToken: 0x200004E  // size: 0x68
    public sealed class HEU_AttributeData : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_AttributeInfo _attributeInfo;  // 0x10
        public System.String _name;  // 0x38
        public HoudiniEngineUnity.HEU_AttributeData.AttributeType _attributeType;  // 0x40
        public System.Int32[] _intValues;  // 0x48
        public System.Single[] _floatValues;  // 0x50
        public System.String[] _stringValues;  // 0x58
        public HoudiniEngineUnity.HEU_AttributeData.AttributeState _attributeState;  // 0x60

        // Methods
        // RVA: 0x087F1118  token: 0x600030B
        public System.Boolean IsColorAttribute() { }
        // RVA: 0x087F0FE4  token: 0x600030C
        private System.Void CopyValuesTo(HoudiniEngineUnity.HEU_AttributeData destAttrData) { }
        // RVA: 0x087F1170  token: 0x600030D
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributeData other) { }
        // RVA: 0x0350B670  token: 0x600030E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000051  // size: 0x98
    public class HEU_AttributesStore : UnityEngine.ScriptableObject, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.Int32 _geoID;  // 0x18
        private System.Int32 _partID;  // 0x1c
        private System.String _geoName;  // 0x20
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> _attributeDatas;  // 0x28
        private System.Boolean _hasColorAttribute;  // 0x30
        private UnityEngine.Material _localMaterial;  // 0x38
        private UnityEngine.Transform _outputTransform;  // 0x40
        private UnityEngine.Vector3[] _positionAttributeValues;  // 0x48
        private System.Int32[] _vertexIndices;  // 0x50
        private UnityEngine.GameObject _outputGameObject;  // 0x58
        private UnityEngine.Mesh _outputMesh;  // 0x60
        private UnityEngine.Material[] _outputMaterials;  // 0x68
        private UnityEngine.MeshCollider _outputCollider;  // 0x70
        private UnityEngine.Mesh _outputColliderMesh;  // 0x78
        private UnityEngine.MeshCollider _outputMeshCollider;  // 0x80
        private UnityEngine.MeshCollider _localMeshCollider;  // 0x88
        private System.Boolean _outputMeshRendererInitiallyEnabled;  // 0x90
        private System.Boolean _outputMeshColliderInitiallyEnabled;  // 0x91

        // Properties
        System.Int32 GeoID { get; /* RVA: 0x020D1AC0 */ }
        System.Int32 PartID { get; /* RVA: 0x03D4EBB0 */ }
        System.String GeoName { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.Transform OutputTransform { get; /* RVA: 0x03D4E2B0 */ }
        UnityEngine.Mesh OutputMesh { get; /* RVA: 0x03D4EB00 */ }

        // Methods
        // RVA: 0x03D4EF60  token: 0x6000312
        public System.Boolean HasColorAttribute() { }
        // RVA: 0x087F1960  token: 0x6000315
        public System.Void DestroyAllData(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x087F3EA4  token: 0x6000316
        public System.Void SyncAllAttributesFrom(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087F3850  token: 0x6000317
        public System.Void SetupMeshAndMaterials(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HAPI_PartType partType, UnityEngine.GameObject outputGameObject) { }
        // RVA: 0x087F2454  token: 0x6000318
        public System.Boolean HasDirtyAttributes() { }
        // RVA: 0x087F4124  token: 0x6000319
        public System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F2D44  token: 0x600031A
        private System.Void PopulateAttributeData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        // RVA: 0x087F235C  token: 0x600031B
        private System.Void GetAttributesList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributesList, HoudiniEngineUnity.HAPI_AttributeOwner ownerType, System.Int32 attributeCount) { }
        // RVA: 0x087F42D8  token: 0x600031C
        private System.Void UpdateAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData) { }
        // RVA: 0x087F4188  token: 0x600031D
        private System.Void UpdateAttributeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributeDataList) { }
        // RVA: 0x087F3408  token: 0x600031E
        public System.Void RefreshUpstreamInputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F4434  token: 0x600031F
        public System.Boolean UploadAttributeViaMeshInput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x087F3620  token: 0x6000320
        private static System.Void SetAttributeDataSyncd(HoudiniEngineUnity.HEU_AttributeData attributeData) { }
        // RVA: 0x087F3604  token: 0x6000321
        public static System.Void SetAttributeDataDirty(HoudiniEngineUnity.HEU_AttributeData attributeData) { }
        // RVA: 0x087F18A8  token: 0x6000322
        public HoudiniEngineUnity.HEU_AttributeData CreateAttribute(System.String attributeName, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        // RVA: 0x087F1DE8  token: 0x6000323
        public HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.String name) { }
        // RVA: 0x087F1F28  token: 0x6000324
        public HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.Int32 index) { }
        // RVA: 0x087F1F98  token: 0x6000325
        public System.Collections.Generic.List<System.String> GetAttributeNames() { }
        // RVA: 0x087F1B8C  token: 0x6000326
        public System.Void EnablePaintCollider() { }
        // RVA: 0x087F1A74  token: 0x6000327
        public System.Void DisablePaintCollider() { }
        // RVA: 0x087F3C18  token: 0x6000328
        public System.Void ShowPaintMesh() { }
        // RVA: 0x087F25C8  token: 0x6000329
        public System.Void HidePaintMesh() { }
        // RVA: 0x087F2578  token: 0x600032A
        public System.Boolean HasMeshForPainting() { }
        // RVA: 0x087F23CC  token: 0x600032B
        public UnityEngine.MeshCollider GetPaintMeshCollider() { }
        // RVA: 0x087F2CE0  token: 0x600032C
        public System.Void PaintAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 attributeIndex, System.Single paintFactor, HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc setAttrFunc) { }
        // RVA: 0x087F36B0  token: 0x600032D
        public static System.Void SetAttributeEditValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Int32[] values) { }
        // RVA: 0x087F363C  token: 0x600032E
        public static System.Void SetAttributeEditValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Single[] values) { }
        // RVA: 0x087F3724  token: 0x600032F
        public static System.Void SetAttributeEditValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.String[] values) { }
        // RVA: 0x087F34F4  token: 0x6000330
        public static System.Void ReplaceAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F152C  token: 0x6000331
        public static System.Void AddAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F3DD8  token: 0x6000332
        public static System.Void SubtractAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F2BD0  token: 0x6000333
        public static System.Void MultiplyAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F3440  token: 0x6000334
        public static System.Void ReplaceAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F147C  token: 0x6000335
        public static System.Void AddAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F3D20  token: 0x6000336
        public static System.Void SubtractAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F2B10  token: 0x6000337
        public static System.Void MultiplyAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F37AC  token: 0x6000338
        public static System.Void SetAttributeValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        // RVA: 0x087F1D34  token: 0x6000339
        public System.Void FillAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools) { }
        // RVA: 0x087F15F8  token: 0x600033A
        public System.Boolean AreAttributesDirty() { }
        // RVA: 0x087F2434  token: 0x600033B
        public System.Void GetPositionAttributeValues(UnityEngine.Vector3[]& positionArray) { }
        // RVA: 0x087F2444  token: 0x600033C
        public System.Void GetVertexIndices(System.Int32[]& indices) { }
        // RVA: 0x087F212C  token: 0x600033D
        public static HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc GetAttributeSetValueFunction(HoudiniEngineUnity.HEU_AttributeData.AttributeType attrType, HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode paintMergeMode) { }
        // RVA: 0x087F1710  token: 0x600033E
        public System.Void CopyAttributeValuesTo(HoudiniEngineUnity.HEU_AttributesStore destAttrStore) { }
        // RVA: 0x087F2AF8  token: 0x600033F
        public System.Boolean IsValidStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x087F26A0  token: 0x6000340
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributesStore other) { }
        // RVA: 0x087F44E0  token: 0x6000341
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x40
    public class HEU_OutputAttribute
    {
        // Fields
        public System.String _name;  // 0x10
        public HoudiniEngineUnity.HAPI_AttributeOwner _class;  // 0x18
        public HoudiniEngineUnity.HAPI_StorageType _type;  // 0x1c
        public System.Int32 _count;  // 0x20
        public System.Int32 _tupleSize;  // 0x24
        public System.Int32[] _intValues;  // 0x28
        public System.Single[] _floatValues;  // 0x30
        public System.String[] _stringValues;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000346
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000054  // size: 0x28
    public class HEU_OutputAttributeDictionary : HoudiniEngineUnity.HEU_SerializableDictionary`2
    {
        // Methods
        // RVA: 0x0880AF6C  token: 0x6000347
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x20
    public class HEU_OutputAttributesStore : UnityEngine.MonoBehaviour
    {
        // Fields
        private HoudiniEngineUnity.HEU_OutputAttributeDictionary _attributes;  // 0x18

        // Methods
        // RVA: 0x0880B044  token: 0x6000348
        public System.Void SetAttribute(HoudiniEngineUnity.HEU_OutputAttribute attribute) { }
        // RVA: 0x0880AFDC  token: 0x6000349
        public HoudiniEngineUnity.HEU_OutputAttribute GetAttribute(System.String name) { }
        // RVA: 0x0880AF94  token: 0x600034A
        public System.Void Clear() { }
        // RVA: 0x0880B114  token: 0x600034B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000056  // size: 0x10
    public static class HEU_AssetDatabase
    {
        // Methods
        // RVA: 0x08805DD4  token: 0x600034C
        public static System.String GetAssetCachePath() { }
        // RVA: 0x088065B0  token: 0x600034D
        public static System.String GetUnityProjectPath() { }
        // RVA: 0x08805F68  token: 0x600034E
        public static System.String GetAssetRelativePath(System.String inFullPath) { }
        // RVA: 0x08806238  token: 0x600034F
        public static System.String GetPackagesRelativePath(System.String inFullPath) { }
        // RVA: 0x0880660C  token: 0x6000350
        public static System.String GetValidAssetPath(System.String inPath) { }
        // RVA: 0x08805ED8  token: 0x6000351
        public static System.String GetAssetPath(UnityEngine.Object asset) { }
        // RVA: 0x08805EA0  token: 0x6000352
        public static System.String GetAssetPathWithSubAssetSupport(UnityEngine.Object asset) { }
        // RVA: 0x08806358  token: 0x6000353
        public static System.Void GetSubAssetPathFromPath(System.String fullPath, System.String& mainPath, System.String& subPath) { }
        // RVA: 0x08805F10  token: 0x6000354
        private static System.String GetAssetRelativePathStart() { }
        // RVA: 0x088061E0  token: 0x6000355
        private static System.String GetPackagesRelativePathStart() { }
        // RVA: 0x08805E1C  token: 0x6000356
        public static System.String GetAssetFullPath(System.String inPath) { }
        // RVA: 0x08806B8C  token: 0x6000357
        public static System.Boolean IsPathRelativeToAssets(System.String inPath) { }
        // RVA: 0x08806C10  token: 0x6000358
        public static System.Boolean IsPathRelativeToPackages(System.String inPath) { }
        // RVA: 0x088060A8  token: 0x6000359
        public static System.String GetAssetRootPath(UnityEngine.Object asset) { }
        // RVA: 0x08806578  token: 0x600035A
        public static System.String GetUniqueAssetPath(System.String path) { }
        // RVA: 0x08805E68  token: 0x600035B
        public static System.String GetAssetOrScenePath(UnityEngine.Object inputObject) { }
        // RVA: 0x08806A80  token: 0x600035C
        public static System.Boolean IsPathInAssetCache(System.String path) { }
        // RVA: 0x08806A10  token: 0x600035D
        public static System.Boolean IsPathInAssetCacheBakedFolder(System.String path) { }
        // RVA: 0x08806A48  token: 0x600035E
        public static System.Boolean IsPathInAssetCacheWorkingFolder(System.String path) { }
        // RVA: 0x08806968  token: 0x600035F
        public static System.Boolean IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset) { }
        // RVA: 0x088069A0  token: 0x6000360
        public static System.Boolean IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset) { }
        // RVA: 0x08805B88  token: 0x6000361
        public static System.String CreateAssetCacheFolder(System.String suggestedAssetPath, System.Int32 hash) { }
        // RVA: 0x08805CC8  token: 0x6000362
        public static System.Void DeleteAssetCacheFolder(System.String assetCacheFolderPath) { }
        // RVA: 0x08805D30  token: 0x6000363
        public static System.Void DeleteAsset(UnityEngine.Object asset) { }
        // RVA: 0x08805C94  token: 0x6000364
        public static System.Void DeleteAssetAtPath(System.String path) { }
        // RVA: 0x08805CFC  token: 0x6000365
        public static System.Void DeleteAssetIfInBakedFolder(UnityEngine.Object asset) { }
        // RVA: 0x088059CC  token: 0x6000366
        public static System.Boolean ContainsAsset(UnityEngine.Object assetObject) { }
        // RVA: 0x08805AE4  token: 0x6000367
        public static System.Boolean CopyAsset(System.String path, System.String newPath) { }
        // RVA: 0x08805AAC  token: 0x6000368
        public static UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, System.String copyAssetFolder, System.String relativePath, System.Type type, System.Boolean bOverwriteExisting) { }
        // RVA: 0x08805A74  token: 0x6000369
        public static UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting) { }
        // RVA: 0x08805A04  token: 0x600036A
        public static UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting) { }
        // RVA: 0x08805A3C  token: 0x600036B
        public static UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, System.String targetPath, System.Type type) { }
        // RVA: 0x08805B1C  token: 0x600036C
        public static UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type) { }
        // RVA: 0x08805BF4  token: 0x600036D
        public static System.Void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, System.String assetCacheRoot, System.String relativeFolderPath, System.String assetFileName, System.Type type, System.Boolean bOverwriteExisting) { }
        // RVA: 0x08805BC0  token: 0x600036E
        public static System.Void CreateAsset(UnityEngine.Object asset, System.String path) { }
        // RVA: 0x08805B54  token: 0x600036F
        public static System.Void CreateAddObjectInAssetCacheFolder(System.String assetName, System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, System.String& exportRootPath, UnityEngine.Object& assetDBObject) { }
        // RVA: 0x088056D4  token: 0x6000370
        public static System.Void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject) { }
        // RVA: 0x0350B670  token: 0x6000371
        public static System.Void SaveAndRefreshDatabase() { }
        // RVA: 0x0350B670  token: 0x6000372
        public static System.Void SaveAssetDatabase() { }
        // RVA: 0x0350B670  token: 0x6000373
        public static System.Void RefreshAssetDatabase() { }
        // RVA: 0x08806D04  token: 0x6000374
        public static UnityEngine.Object LoadAssetAtPath(System.String assetPath, System.Type type) { }
        // RVA: 0x08806D3C  token: 0x6000375
        public static UnityEngine.Object LoadSubAssetAtPath(System.String mainPath, System.String subAssetPath) { }
        // RVA: 0x08806CCC  token: 0x6000376
        public static UnityEngine.Object[] LoadAllAssetsAtPath(System.String assetPath) { }
        // RVA: 0x08806C94  token: 0x6000377
        public static UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(System.String assetPath) { }
        // RVA: 0x08806934  token: 0x6000378
        public static System.Void ImportAsset(System.String assetPath, HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions heuOptions) { }
        // RVA: 0x088061A8  token: 0x6000379
        public static System.String GetAssetWorkingPath() { }
        // RVA: 0x08805D9C  token: 0x600037A
        public static System.String GetAssetBakedPath() { }
        // RVA: 0x08805D64  token: 0x600037B
        public static System.String GetAssetBakedPathWithAssetName(System.String assetName) { }
        // RVA: 0x08805C5C  token: 0x600037C
        public static System.String CreateUniqueBakePath(System.String assetName) { }
        // RVA: 0x08805C28  token: 0x600037D
        public static System.Void CreatePathWithFolders(System.String inPath) { }
        // RVA: 0x088057C0  token: 0x600037E
        public static System.String AppendMeshesPathToAssetFolder(System.String inAssetCacheFolder) { }
        // RVA: 0x08805950  token: 0x600037F
        public static System.String AppendTexturesPathToAssetFolder(System.String inAssetCacheFolder) { }
        // RVA: 0x08805708  token: 0x6000380
        public static System.String AppendMaterialsPathToAssetFolder(System.String inAssetCacheFolder) { }
        // RVA: 0x088058D4  token: 0x6000381
        public static System.String AppendTerrainPathToAssetFolder(System.String inAssetCacheFolder) { }
        // RVA: 0x088060E0  token: 0x6000382
        public static System.String[] GetAssetSubFolders() { }
        // RVA: 0x0880583C  token: 0x6000383
        public static System.String AppendPrefabPath(System.String inAssetCacheFolder, System.String assetName) { }
        // RVA: 0x08805784  token: 0x6000384
        public static System.String AppendMeshesAssetFileName(System.String assetName) { }
        // RVA: 0x0115F4C0  token: 0x6000385
        public static System.Boolean IsSubAsset(UnityEngine.Object obj) { }
        // RVA: 0x01002730  token: 0x6000386
        public static System.String[] GetAssetPathsFromAssetBundle(System.String assetBundleFileName) { }
        // RVA: 0x088069D8  token: 0x6000387
        public static System.Boolean IsAssetSavedInScene(UnityEngine.GameObject go) { }
        // RVA: 0x0350B670  token: 0x6000388
        public static System.Void SelectAssetAtPath(System.String path) { }
        // RVA: 0x0350B670  token: 0x6000389
        public static System.Void PrintDependencies(UnityEngine.GameObject targetGO) { }
        // RVA: 0x088064C8  token: 0x600038A
        public static System.String GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj) { }
        // RVA: 0x0232EB60  token: 0x600038B
        public static System.Boolean IsValidFolderName(System.String name) { }
        // RVA: -1  // generic def  token: 0x600038C
        public static T LoadUnityAssetFromUniqueAssetPath(System.String assetPath) { }
        // RVA: -1  // generic def  token: 0x600038D
        public static T GetBuiltinExtraResource(System.String resourceName) { }

    }

    // TypeToken: 0x2000058  // size: 0x10
    public class HEU_Defines
    {
        // Fields
        public static System.String HEU_PRODUCT_NAME;  // const
        public static System.String HEU_NAME;  // const
        public static System.String HEU_PLUGIN_PATH;  // static @ 0x0
        public static System.String HEU_TEXTURES_PATH;  // static @ 0x8
        public static System.String HEU_BAKED_ASSETS_PATH;  // static @ 0x10
        public static System.String HEU_ENGINE_ASSETS;  // static @ 0x18
        public static System.String HAPI_PATH;  // const
        public static System.String HEU_ENVPATH_PREFIX;  // const
        public static System.String HEU_ENVPATH_KEY;  // const
        public static System.Int32 HEU_INVALID_NODE_ID;  // const
        public static System.String HEU_DEFAULT_ASSET_NAME;  // const
        public static System.String HEU_SESSION_PIPENAME;  // const
        public static System.String HEU_SESSION_LOCALHOST;  // const
        public static System.Int32 HEU_SESSION_PORT;  // const
        public static System.Single HEU_SESSION_TIMEOUT;  // const
        public static System.Boolean HEU_SESSION_AUTOCLOSE;  // const
        public static System.Int32 HAPI_MAX_PAGE_SIZE;  // const
        public static System.Int32 HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW;  // const
        public static System.Int32 HAPI_MAX_VERTICES_PER_FACE;  // const
        public static System.Boolean HAPI_CURVE_REFINE_TO_LINEAR;  // const
        public static System.Single HAPI_CURVE_LOD;  // const
        public static System.Single HAPI_VOLUME_POSITION_MULT;  // const
        public static System.Single HAPI_VOLUME_SURFACE_MAX_PT_PER_C;  // const
        public static System.Single HAPI_VOLUME_SURFACE_DELTA_MULT;  // const
        public static System.Single HAPI_VOLUME_SURFACE_PT_SIZE_MULT;  // const
        public static System.String DEFAULT_TOP_NODE_FILTER;  // const
        public static System.String DEFAULT_TOP_OUTPUT_FILTER;  // const
        public static System.String HAPI_ATTRIB_ORIENT;  // const
        public static System.String HAPI_ATTRIB_ROTATION;  // const
        public static System.String HAPI_ATTRIB_SCALE;  // const
        public static System.String HAPI_ATTRIB_ALPHA;  // const
        public static System.String HAPI_HANDLE_TRANSFORM;  // const
        public static System.Int32 HAPI_MAX_UVS;  // const
        public static System.String HAPI_OBJMERGE_TRANSFORM_PARAM;  // const
        public static System.String HAPI_OBJMERGE_PACK_GEOMETRY;  // const
        public static System.String HAPI_OBJPATH_1_PARAM;  // const
        public static System.String NO_EXISTING_SESSION;  // const
        public static System.String HEU_ERROR_TITLE;  // const
        public static System.String HEU_INSTALL_INFO;  // const
        public static System.String PLUGIN_STORE_KEYS;  // const
        public static System.String PLUGIN_STORE_DATA;  // const
        public static System.String PLUGIN_SESSION_DATA;  // const
        public static System.String PLUGIN_SETTINGS_FILE;  // const
        public static System.String PLUGIN_SESSION_FILE;  // const
        public static System.String COOK_LOGS_FILE;  // const
        public static System.String DEFAULT_COLLISION_GEO;  // const
        public static System.String DEFAULT_RENDERED_COLLISION_GEO;  // const
        public static System.String DEFAULT_RENDERED_CONVEX_COLLISION_GEO;  // const
        public static System.String DEFAULT_CONVEX_COLLISION_GEO;  // const
        public static System.String DEFAULT_SIMPLE_COLLISION_GEO;  // const
        public static System.String DEFAULT_SIMPLE_RENDERED_COLLISION_GEO;  // const
        public static System.String DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO;  // const
        public static System.String DEFAULT_COLLISION_TRIGGER;  // const
        public static System.String DEFAULT_UNITY_MATERIAL_ATTR;  // const
        public static System.String DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR;  // const
        public static System.String DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE;  // const
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_YPOS;  // const
        public static System.String HEIGHTFIELD_TREEPROTOTYPE;  // const
        public static System.String HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX;  // const
        public static System.String HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE;  // const
        public static System.String HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE;  // const
        public static System.String HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR;  // const
        public static System.String HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH;  // const
        public static System.String HEIGHTFIELD_UNITY_TILE;  // const
        public static System.String HEIGHTFIELD_DETAIL_DISTANCE;  // const
        public static System.String HEIGHTFIELD_DETAIL_DENSITY;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD;  // const
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE;  // const
        public static System.String HEIGHTFIELD_LAYER_ATTR_TYPE;  // const
        public static System.String HEIGHTFIELD_LAYER_TYPE_DETAIL;  // const
        public static System.String HAPI_HEIGHTFIELD_TILE_ATTR;  // const
        public static System.String HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT;  // const
        public static System.String HAPI_HEIGHTFIELD_LAYERNAME_MASK;  // const
        public static System.String MAT_OGL_DIFF_ATTR;  // const
        public static System.String MAT_DIFF_ATTR;  // const
        public static System.String MAT_OGL_TEX1_ATTR;  // const
        public static System.String MAT_OGL_TEX1_ATTR_ENABLED;  // const
        public static System.String MAT_BASECOLOR_ATTR;  // const
        public static System.String MAT_BASECOLOR_ATTR_ENABLED;  // const
        public static System.String MAT_MAP_ATTR;  // const
        public static System.String MAT_OGL_NORMAL_ATTR;  // const
        public static System.String MAT_NORMAL_ATTR;  // const
        public static System.String MAT_NORMAL_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_SPEC_ATTR;  // const
        public static System.String MAT_SPEC_ATTR;  // const
        public static System.String MAT_OGL_SPEC_MAP_ATTR;  // const
        public static System.String MAT_OGL_SPEC_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_SPEC_MAP_ATTR;  // const
        public static System.String MAT_SPEC_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_ROUGH_ATTR;  // const
        public static System.String MAT_ROUGH_ATTR;  // const
        public static System.String MAT_OGL_ROUGH_MAP_ATTR;  // const
        public static System.String MAT_OGL_ROUGH_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_ROUGH_MAP_ATTR;  // const
        public static System.String MAT_ROUGH_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_METALLIC_ATTR;  // const
        public static System.String MAT_METALLIC_ATTR;  // const
        public static System.String MAT_OGL_METALLIC_MAP_ATTR;  // const
        public static System.String MAT_OGL_METALLIC_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_METALLIC_MAP_ATTR;  // const
        public static System.String MAT_METALLIC_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_EMISSIVE_ATTR;  // const
        public static System.String MAT_EMISSIVE_ATTR;  // const
        public static System.String MAT_OGL_EMISSIVE_MAP_ATTR;  // const
        public static System.String MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_EMISSIVE_MAP_ATTR;  // const
        public static System.String MAT_EMISSIVE_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_ALPHA_ATTR;  // const
        public static System.String MAT_ALPHA_ATTR;  // const
        public static System.String MAT_OGL_OPACITY_MAP_ATTR;  // const
        public static System.String MAT_OGL_OPACITY_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_OPACITY_MAP_ATTR;  // const
        public static System.String MAT_OPACITY_MAP_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_TRANSPARENCY_ATTR;  // const
        public static System.String MAT_OGL_TRANSPARENCY_ATTR_ENABLED;  // const
        public static System.String MAT_OGL_OCCLUSION_MAP_ATTR;  // const
        public static System.String MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED;  // const
        public static System.String CURVE_COORDS_PARAM;  // const
        public static System.String CURVE_TYPE_PARAM;  // const
        public static System.String CURVE_METHOD_PARAM;  // const
        public static System.String CURVE_CLOSE_PARAM;  // const
        public static System.String CURVE_REVERSE_PARAM;  // const
        public static System.String HENGINE_STORE_ATTR;  // const
        public static System.String DEFAULT_UNITY_TAG_ATTR;  // const
        public static System.String DEFAULT_UNITY_SCRIPT_ATTR;  // const
        public static System.String DEFAULT_UNITY_INSTANCE_ATTR;  // const
        public static System.String UNITY_USE_INSTANCE_FLAGS_ATTR;  // const
        public static System.String DEFAULT_UNITY_INPUT_MESH_ATTR;  // const
        public static System.String DEFAULT_UNITY_STATIC_ATTR;  // const
        public static System.String DEFAULT_UNITY_LAYER_ATTR;  // const
        public static System.String DEFAULT_UNITY_MESH_READABLE;  // const
        public static System.String DEFAULT_INSTANCE_PREFIX_ATTR;  // const
        public static System.String UNITY_SHADER_COLOR;  // const
        public static System.String UNITY_SHADER_SPEC_COLOR;  // const
        public static System.String UNITY_SHADER_SPEC_MAP;  // const
        public static System.String UNITY_SHADER_METALLIC;  // const
        public static System.String UNITY_SHADER_METALLIC_MAP;  // const
        public static System.String UNITY_SHADER_BUMP_MAP;  // const
        public static System.String UNITY_SHADER_EMISSION_COLOR;  // const
        public static System.String UNITY_SHADER_EMISSION_MAP;  // const
        public static System.String UNITY_SHADER_SMOOTHNESS;  // const
        public static System.String UNITY_SHADER_SMOOTHNESS_MAP;  // const
        public static System.String UNITY_SHADER_SHININESS;  // const
        public static System.String UNITY_SHADER_OCCLUSION;  // const
        public static System.String UNITY_SHADER_OCCLUSION_MAP;  // const
        public static System.String UNITY_SHADER_OPACITY;  // const
        public static System.String UNITY_SHADER_OPACITY_MAP;  // const
        public static System.String UNITY_EDITORONLY_TAG;  // const
        public static System.String UNITY_HDADATA_NAME;  // const
        public static System.String HOUDINI_SHADER_PREFIX;  // const
        public static System.String DEFAULT_STANDARD_SHADER;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER;  // const
        public static System.String DEFAULT_STANDARD_SHADER_SPECULAR;  // const
        public static System.String DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_SPECULAR;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER_SPECULAR;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY;  // const
        public static System.String DEFAULT_CURVE_SHADER;  // const
        public static System.String DEFAULT_TERRAIN_SHADER;  // const
        public static System.String DEFAULT_STANDARD_SHADER_HDRP;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_HDRP;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER_HDRP;  // const
        public static System.String DEFAULT_STANDARD_SHADER_HDRP_SPECULAR;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR;  // const
        public static System.String DEFAULT_CURVE_SHADER_HDRP;  // const
        public static System.String DEFAULT_TERRAIN_SHADER_HDRP;  // const
        public static System.String DEFAULT_STANDARD_SHADER_URP;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_URP;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER_URP;  // const
        public static System.String DEFAULT_STANDARD_SHADER_URP_SPECULAR;  // const
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR;  // const
        public static System.String DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR;  // const
        public static System.String DEFAULT_CURVE_SHADER_URP;  // const
        public static System.String DEFAULT_TERRAIN_SHADER_URP;  // const
        public static System.String DEFAULT_UNITY_BUILTIN_RESOURCES;  // const
        public static System.String DEFAULT_TERRAIN_MATERIAL_PATH;  // const
        public static System.String DEFAULT_TERRAIN_MATERIAL_PATH_HDRP;  // const
        public static System.String DEFAULT_TERRAIN_MATERIAL_PATH_URP;  // const
        public static System.String DEFAULT_MATERIAL;  // const
        public static System.Int32 DEFAULT_MATERIAL_KEY;  // static @ 0x20
        public static System.String EDITABLE_MATERIAL;  // const
        public static System.Int32 EDITABLE_MATERIAL_KEY;  // static @ 0x24
        public static System.Int32 HEU_INVALID_MATERIAL;  // const
        public static System.String HEU_ASSET_CACHE_PATH;  // const
        public static System.String HEU_WORKING_PATH;  // const
        public static System.String HEU_BAKED_PATH;  // const
        public static System.String HEU_BAKED_HDA;  // const
        public static System.String HEU_BAKED_CLONE;  // const
        public static System.String HEU_INSTANCE;  // const
        public static System.String HEU_INSTANCE_PATTERN;  // const
        public static System.String HEU_INSTANCE_SPLIT_ATTR;  // const
        public static System.String HEU_DEFAULT_GEO_GROUP_NAME;  // const
        public static System.String HEU_DEFAULT_LOD_NAME;  // const
        public static System.String HEU_UNITY_LOD_TRANSITION_ATTR;  // const
        public static System.String HEU_SUBASSET;  // const
        public static System.String HEU_HENGINE_TOOLS_SHIPPED_FOLDER;  // const
        public static System.String HEU_HENGINE_SHIPPED_SHELF;  // const
        public static System.String HEU_PATH_KEY_PROJECT;  // const
        public static System.String HEU_PATH_KEY_PLUGIN;  // const
        public static System.String HEU_PATH_KEY_HFS;  // const
        public static System.String HEU_PATH_KEY_TOOL;  // const
        public static System.String HEU_USERMSG_NONEDITOR_NOT_SUPPORTED;  // const
        public static System.String HEU_TERRAIN_SPLAT_DEFAULT;  // const
        public static System.String HEU_FOLDER_MESHES;  // const
        public static System.String HEU_FOLDER_MATERIALS;  // const
        public static System.String HEU_FOLDER_TERRAIN;  // const
        public static System.String HEU_FOLDER_TILE;  // const
        public static System.String HEU_FOLDER_TEXTURES;  // const
        public static System.String HEU_EXT_ASSET;  // const
        public static System.String HEU_EXT_MAT;  // const
        public static System.String HEU_EXT_TERRAINDATA;  // const
        public static System.String HEU_EXT_TERRAINLAYER;  // const
        public static System.String HEU_KEY_CTRL;  // const

        // Methods
        // RVA: 0x0350B670  token: 0x600038E
        public System.Void .ctor() { }
        // RVA: 0x08806DD4  token: 0x600038F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x10
    public static class HEU_HAPIUtility
    {
        // Methods
        // RVA: 0x08808DF8  token: 0x6000390
        public static System.String GetHoudiniEngineInstallationInfo() { }
        // RVA: 0x088087AC  token: 0x6000391
        public static System.String GetEnvironmentPath() { }
        // RVA: 0x08809500  token: 0x6000392
        public static System.String GetRealPathFromHFSPath(System.String inPath) { }
        // RVA: 0x08807E88  token: 0x6000393
        public static System.Boolean DoesMappedPathExist(System.String inPath) { }
        // RVA: 0x0880983C  token: 0x6000394
        public static System.Boolean IsHoudiniAssetFile(System.String filePath) { }
        // RVA: 0x08807EF8  token: 0x6000395
        public static System.String FindHoudiniAssetFileInPathWithExt(System.String filePath) { }
        // RVA: 0x08809E74  token: 0x6000396
        public static System.Void Log(System.String message) { }
        // RVA: 0x08809E6C  token: 0x6000397
        public static System.Void LogWarning(System.String message) { }
        // RVA: 0x08809E64  token: 0x6000398
        public static System.Void LogError(System.String message) { }
        // RVA: 0x08809E08  token: 0x6000399
        public static System.String LocateValidFilePath(UnityEngine.Object inObject) { }
        // RVA: 0x03D51810  token: 0x600039A
        public static System.String LocateValidFilePath(System.String assetName, System.String inFilePath) { }
        // RVA: 0x08809624  token: 0x600039B
        public static UnityEngine.GameObject InstantiateHDA(System.String filePath, UnityEngine.Vector3 initialPosition, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, System.Boolean bLoadFromMemory, System.Boolean bAlwaysOverwriteOnLoad, UnityEngine.GameObject rootGO) { }
        // RVA: 0x08809D54  token: 0x600039C
        public static System.Boolean LoadHDAFile(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.Int32& assetLibraryID, System.String[]& assetNames) { }
        // RVA: 0x088078E4  token: 0x600039D
        public static System.Boolean CreateAndCookAssetNode(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID) { }
        // RVA: 0x08807950  token: 0x600039E
        public static System.Boolean CreateAndCookCurveAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID) { }
        // RVA: 0x088079A4  token: 0x600039F
        public static System.Boolean CreateAndCookInputAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID) { }
        // RVA: 0x088076A8  token: 0x60003A0
        public static System.Boolean CookNodeInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.String assetName) { }
        // RVA: 0x088076A8  token: 0x60003A1
        public static System.Boolean CookNodeInHoudiniWithOptions(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions options, System.String assetName) { }
        // RVA: 0x08808770  token: 0x60003A2
        public static HoudiniEngineUnity.HAPI_CookOptions GetDefaultCookOptions(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08809E7C  token: 0x60003A3
        public static System.Boolean ProcessHoudiniCookStatus(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName) { }
        // RVA: 0x08807A0C  token: 0x60003A4
        public static UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        // RVA: 0x08807A60  token: 0x60003A5
        private static UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        // RVA: 0x08807B14  token: 0x60003A6
        public static UnityEngine.GameObject CreateNewCurveAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        // RVA: 0x08807B48  token: 0x60003A7
        public static UnityEngine.GameObject CreateNewInputAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        // RVA: 0x01002730  token: 0x60003A8
        public static UnityEngine.GameObject LoadGeoWithNewGeoSync(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08807B7C  token: 0x60003A9
        public static System.Void DestroyChildren(UnityEngine.Transform inTransform) { }
        // RVA: 0x08807E78  token: 0x60003AA
        public static System.Void DestroyGameObject(UnityEngine.GameObject gameObect, System.Boolean bRegisterUndo) { }
        // RVA: -1  // generic def  token: 0x60003AB
        public static System.Void DestroyChildrenWithComponent(UnityEngine.GameObject gameObject) { }
        // RVA: 0x08809954  token: 0x60003AC
        public static System.Boolean IsNodeValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID) { }
        // RVA: 0x08808690  token: 0x60003AD
        public static HoudiniEngineUnity.HEU_HoudiniAssetRoot GetAssetInScene(System.Int32 assetID) { }
        // RVA: 0x08807434  token: 0x60003AE
        public static System.Void ApplyWorldTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform) { }
        // RVA: 0x088071D0  token: 0x60003AF
        public static System.Void ApplyLocalTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform) { }
        // RVA: 0x08806FA0  token: 0x60003B0
        public static System.Void ApplyLocalTransfromFromHoudiniToUnityForInstance(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform) { }
        // RVA: 0x08807380  token: 0x60003B1
        public static System.Void ApplyMatrixToLocalTransform(UnityEngine.Matrix4x4& matrix, UnityEngine.Transform transform) { }
        // RVA: 0x08808ED4  token: 0x60003B2
        public static UnityEngine.Matrix4x4 GetMatrixFromHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Boolean bConvertToUnity) { }
        // RVA: 0x088092FC  token: 0x60003B3
        public static UnityEngine.Quaternion GetQuaternion(UnityEngine.Matrix4x4& m) { }
        // RVA: 0x088092B0  token: 0x60003B4
        public static UnityEngine.Vector3 GetPosition(UnityEngine.Matrix4x4& m) { }
        // RVA: 0x08809EFC  token: 0x60003B5
        public static System.Void SetMatrixPosition(UnityEngine.Matrix4x4& m, UnityEngine.Vector3& position) { }
        // RVA: 0x03D6D540  token: 0x60003B6
        public static UnityEngine.Vector3 GetScale(UnityEngine.Matrix4x4& m) { }
        // RVA: 0x0880881C  token: 0x60003B7
        public static HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransformFromMatrix(UnityEngine.Matrix4x4& mat) { }
        // RVA: 0x08808C64  token: 0x60003B8
        public static HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransform(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s) { }
        // RVA: 0x08808A08  token: 0x60003B9
        public static HoudiniEngineUnity.HAPI_Transform GetHAPITransformQuatFromMatrix(UnityEngine.Matrix4x4& mat) { }
        // RVA: 0x08808E24  token: 0x60003BA
        public static UnityEngine.Matrix4x4 GetMatrix4x4(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s) { }
        // RVA: 0x088099CC  token: 0x60003BB
        public static System.Boolean IsSameTransform(UnityEngine.Matrix4x4& transformMatrix, UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s) { }
        // RVA: 0x056649E4  token: 0x60003BC
        public static System.Boolean IsEqualTol(System.Single a, System.Single b, System.Single t) { }
        // RVA: 0x08809AB0  token: 0x60003BD
        public static System.Boolean IsTransformEqual(HoudiniEngineUnity.HAPI_Transform& transA, HoudiniEngineUnity.HAPI_Transform& transB) { }
        // RVA: 0x08809C58  token: 0x60003BE
        public static System.Boolean IsViewportEqual(HoudiniEngineUnity.HAPI_Viewport& viewA, HoudiniEngineUnity.HAPI_Viewport& viewB) { }
        // RVA: 0x08809A84  token: 0x60003BF
        public static System.Boolean IsSessionSyncEqual(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncA, HoudiniEngineUnity.HAPI_SessionSyncInfo& syncB) { }
        // RVA: 0x088076A8  token: 0x60003C0
        public static System.Boolean DoesGeoPartHaveAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        // RVA: 0x0350B670  token: 0x60003C1
        public static System.Void SetAnimationCurveTangentModes(UnityEngine.AnimationCurve animCurve, System.Collections.Generic.List<System.Int32> tangentValues) { }
        // RVA: 0x08809A9C  token: 0x60003C2
        public static System.Boolean IsSupportedPolygonType(HoudiniEngineUnity.HAPI_PartType partType) { }
        // RVA: 0x08809290  token: 0x60003C3
        public static System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID) { }
        // RVA: 0x088090F8  token: 0x60003C4
        public static System.Boolean GetObjectInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.HAPI_ObjectInfo[]& objectInfos, HoudiniEngineUnity.HAPI_Transform[]& objectTransforms) { }
        // RVA: 0x088076A8  token: 0x60003C5
        public static System.Boolean ContainsSopNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId) { }
        // RVA: 0x08809970  token: 0x60003C6
        public static System.Boolean IsObjNodeFullyVisible(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.HashSet<System.Int32> allObjectIds, System.Int32 inRootNodeId, System.Int32 inChildNodeId) { }
        // RVA: 0x08809258  token: 0x60003C7
        public static System.Boolean GetOutputIndex(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Int32& outputIndex) { }
        // RVA: 0x08808074  token: 0x60003C8
        private static System.Void GatherAllAssetGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo assetInfo, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos) { }
        // RVA: 0x088085F4  token: 0x60003C9
        private static System.Void GatherAllObjectGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos) { }
        // RVA: 0x08808190  token: 0x60003CA
        private static System.Void GatherAllAssetOutputs(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Boolean bUseOutputNodes, System.Boolean bOutputTemplatedGeos, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos) { }
        // RVA: 0x08809F48  token: 0x60003CB
        public static System.String ToHapiVariableName(System.String name) { }
        // RVA: 0x03D6D4D0  token: 0x60003CC
        public static System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3& position) { }
        // RVA: 0x03D6D4B0  token: 0x60003CD
        public static System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ) { }
        // RVA: 0x03D6D490  token: 0x60003CE
        public static UnityEngine.Vector3 ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ) { }
        // RVA: 0x03D6D460  token: 0x60003CF
        public static UnityEngine.Vector3 ConvertPositionUnityToHoudini(UnityEngine.Vector3 inputVec) { }
        // RVA: 0x03D6D4E0  token: 0x60003D0
        public static System.Void ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, UnityEngine.Vector3& outputVec) { }
        // RVA: 0x08807804  token: 0x60003D1
        public static System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion& rotation) { }
        // RVA: 0x088076C0  token: 0x60003D2
        public static System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion rotation, System.Single& outputX, System.Single& outputY, System.Single& outputZ, System.Single& outputW) { }
        // RVA: 0x08807774  token: 0x60003D3
        public static UnityEngine.Quaternion ConvertRotationUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, System.Single inputW) { }
        // RVA: 0x08807874  token: 0x60003D4
        public static UnityEngine.Quaternion ConvertRotationUnityToHoudini(UnityEngine.Quaternion inputQuat) { }
        // RVA: 0x0350B670  token: 0x60003D5
        public static System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3& position) { }
        // RVA: 0x03D6D500  token: 0x60003D6
        public static System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ) { }
        // RVA: 0x03D6D520  token: 0x60003D7
        public static UnityEngine.Vector3 ConvertScaleUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ) { }
        // RVA: 0x03D56520  token: 0x60003D8
        public static UnityEngine.Vector3 ConvertScaleUnityToHoudini(UnityEngine.Vector3 inputVec) { }

    }

    // TypeToken: 0x200005A  // size: 0x98
    public class HEU_HoudiniEngineError : System.Exception
    {
        // Fields
        protected System.String _errorMsg;  // 0x90

        // Methods
        // RVA: 0x0880AF04  token: 0x60003D9
        public System.Void .ctor() { }
        // RVA: 0x0880AE7C  token: 0x60003DA
        public System.Void .ctor(System.String errorMsg) { }
        // RVA: 0x03D4EA90  token: 0x60003DB
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200005B  // size: 0x10
    public class HEU_Platform
    {
        // Fields
        private static System.String _lastErrorMsg;  // static @ 0x0
        private static System.String _libPath;  // static @ 0x8
        private static System.Boolean _pathSet;  // static @ 0x10

        // Properties
        System.String LibPath { get; /* RVA: 0x088187A8 */ }
        System.Boolean IsPathSet { get; /* RVA: 0x08818758 */ }
        System.Char DirectorySeparator { get; /* RVA: 0x03D56180 */ }
        System.String DirectorySeparatorStr { get; /* RVA: 0x0881872C */ }

        // Methods
        // RVA: 0x08818724  token: 0x60003DE
        private static System.Void .cctor() { }
        // RVA: 0x08818024  token: 0x60003DF
        public static System.String GetHoudiniEnginePath() { }
        // RVA: 0x08817D9C  token: 0x60003E0
        public static System.String GetHoudiniEngineDefaultPath() { }
        // RVA: 0x0881809C  token: 0x60003E1
        public static System.String GetSavedHoudiniPath() { }
        // RVA: 0x08818524  token: 0x60003E2
        public static System.Void SetHapiClientName() { }
        // RVA: 0x0350B670  token: 0x60003E3
        public static System.Void SetHoudiniEnginePath() { }
        // RVA: 0x088179F8  token: 0x60003E4
        public static System.String GetAllFoldersInPath(System.String path) { }
        // RVA: 0x088178D8  token: 0x60003E5
        private static System.Void GetAllFoldersInPathHelper(System.String inPath, System.Text.StringBuilder pathBuilder) { }
        // RVA: 0x08817B50  token: 0x60003E6
        public static System.String[] GetFilesInFolder(System.String folderPath, System.String searchPattern, System.Boolean bRecursive) { }
        // RVA: 0x08817B04  token: 0x60003E7
        public static System.String GetFileName(System.String path) { }
        // RVA: 0x08817AB8  token: 0x60003E8
        public static System.String GetFileNameWithoutExtension(System.String path) { }
        // RVA: 0x08817C68  token: 0x60003E9
        public static System.String GetFolderPath(System.String path, System.Boolean bRemoveDirectorySeparatorAtEnd) { }
        // RVA: 0x08817760  token: 0x60003EC
        public static System.String BuildPath(System.String folder1, System.String folder2, System.Object[] args) { }
        // RVA: 0x0881856C  token: 0x60003ED
        public static System.String TrimLastDirectorySeparator(System.String inPath) { }
        // RVA: 0x088178A8  token: 0x60003EE
        public static System.Boolean DoesPathExist(System.String inPath) { }
        // RVA: 0x088178A0  token: 0x60003EF
        public static System.Boolean DoesFileExist(System.String inPath) { }
        // RVA: 0x08817898  token: 0x60003F0
        public static System.Boolean DoesDirectoryExist(System.String inPath) { }
        // RVA: 0x08817870  token: 0x60003F1
        public static System.Boolean CreateDirectory(System.String inPath) { }
        // RVA: 0x0881807C  token: 0x60003F2
        public static System.String GetParentDirectory(System.String inPath) { }
        // RVA: 0x08817D50  token: 0x60003F3
        public static System.String GetFullPath(System.String inPath) { }
        // RVA: 0x088181B8  token: 0x60003F4
        public static System.Boolean IsPathRooted(System.String inPath) { }
        // RVA: 0x0881871C  token: 0x60003F5
        public static System.Void WriteBytes(System.String path, System.Byte[] bytes) { }
        // RVA: 0x088185FC  token: 0x60003F6
        public static System.Boolean WriteAllText(System.String path, System.String text) { }
        // RVA: 0x088183CC  token: 0x60003F7
        public static System.String ReadAllText(System.String path) { }
        // RVA: 0x08817AA8  token: 0x60003F8
        public static System.String GetEnvironmentValue(System.String key) { }
        // RVA: 0x08817F98  token: 0x60003F9
        public static System.String GetHoudiniEngineEnvironmentFilePathFull() { }
        // RVA: 0x08818204  token: 0x60003FA
        public static System.Boolean LoadFileIntoMemory(System.String path, System.Byte[]& buffer) { }
        // RVA: 0x0350B670  token: 0x60003FB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005C  // size: 0x10
    public static class HEU_PlatformWin
    {
        // Fields
        public static System.UIntPtr HKEY_LOCAL_MACHINE;  // static @ 0x0
        public static System.UIntPtr HKEY_CURRENT_USER;  // static @ 0x8

        // Methods
        // RVA: 0x08817548  token: 0x60003FC
        private static System.UInt32 RegOpenKeyEx(System.UIntPtr hKey, System.String lpSubKey, System.UInt32 ulOptions, System.Int32 samDesired, System.Int32& phkResult) { }
        // RVA: 0x0881760C  token: 0x60003FD
        public static System.Int32 RegQueryValueEx(System.Int32 hKey, System.String lpValueName, System.Int32 lpReserved, System.UInt32& lpType, System.Text.StringBuilder lpData, System.UInt32& lpcbData) { }
        // RVA: 0x088174D0  token: 0x60003FE
        private static System.UInt32 RegCloseKey(System.Int32 hKey) { }
        // RVA: 0x08817240  token: 0x60003FF
        public static System.String GetRegistryKeyValue(System.UIntPtr rootKey, System.String keyName, HoudiniEngineUnity.HEU_PlatformWin.RegSAM is32or64Key, System.String inPropertyName) { }
        // RVA: 0x08817464  token: 0x6000400
        public static System.String GetRegistryKeyvalue_x86(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName) { }
        // RVA: 0x088173F8  token: 0x6000401
        public static System.String GetRegistryKeyvalue_x64(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName) { }
        // RVA: 0x08816EF0  token: 0x6000402
        public static System.String GetApplicationPath(System.String appName) { }
        // RVA: 0x0881770C  token: 0x6000403
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005E  // size: 0x10
    public static class HEU_PluginSettings
    {
        // Fields
        public static System.Action<System.Boolean> s_onEnableRawHoudiniChanged;  // static @ 0x0

        // Properties
        System.String HoudiniEngineEnvFilePath { get; /* RVA: 0x088194F0 */ set; /* RVA: 0x0881B024 */ }
        System.Boolean EnableRawHoudini { get; /* RVA: 0x0881926C */ set; /* RVA: 0x0881AE00 */ }
        System.Boolean CookingEnabled { get; /* RVA: 0x08818AC0 */ set; /* RVA: 0x0881AAE8 */ }
        System.Boolean CookingTriggersDownstreamCooks { get; /* RVA: 0x08818B20 */ set; /* RVA: 0x0881AB38 */ }
        System.Boolean CookDisabledGameObjects { get; /* RVA: 0x08818940 */ set; /* RVA: 0x0881A9A8 */ }
        System.Boolean CookTemplatedGeos { get; /* RVA: 0x08818A60 */ set; /* RVA: 0x0881AA98 */ }
        System.Boolean PushUnityTransformToHoudini { get; /* RVA: 0x08819B84 */ set; /* RVA: 0x0881B534 */ }
        System.Boolean TransformChangeTriggersCooks { get; /* RVA: 0x0881A19C */ set; /* RVA: 0x0881BA00 */ }
        System.Boolean ChildTransformChangeTriggersCooks { get; /* RVA: 0x0881886C */ set; /* RVA: 0x0881A904 */ }
        System.String CollisionGroupName { get; /* RVA: 0x088188CC */ set; /* RVA: 0x0881A954 */ }
        System.String RenderedCollisionGroupName { get; /* RVA: 0x08819BE4 */ set; /* RVA: 0x0881B584 */ }
        System.String RenderedConvexCollisionGroupName { get; /* RVA: 0x08819C58 */ set; /* RVA: 0x0881B5D8 */ }
        System.String UnityMaterialAttribName { get; /* RVA: 0x0881A358 */ set; /* RVA: 0x0881BB4C */ }
        System.String UnitySubMaterialAttribName { get; /* RVA: 0x0881A4B4 */ set; /* RVA: 0x0881BC48 */ }
        System.String UnitySubMaterialIndexAttribName { get; /* RVA: 0x0881A528 */ set; /* RVA: 0x0881BC9C */ }
        System.String UnityTagAttributeName { get; /* RVA: 0x0881A59C */ set; /* RVA: 0x0881BCF0 */ }
        System.String UnityStaticAttributeName { get; /* RVA: 0x0881A440 */ set; /* RVA: 0x0881BBF4 */ }
        System.String UnityScriptAttributeName { get; /* RVA: 0x0881A3CC */ set; /* RVA: 0x0881BBA0 */ }
        System.String UnityLayerAttributeName { get; /* RVA: 0x0881A2E4 */ set; /* RVA: 0x0881BAF8 */ }
        System.Single ImageGamma { get; /* RVA: 0x088195D8 */ set; /* RVA: 0x0881B0E0 */ }
        System.Single NormalGenerationThresholdAngle { get; /* RVA: 0x08819B1C */ set; /* RVA: 0x0881B4DC */ }
        System.String LastLoadHDAPath { get; /* RVA: 0x08819938 */ set; /* RVA: 0x0881B378 */ }
        System.String LastLoadHIPPath { get; /* RVA: 0x088199AC */ set; /* RVA: 0x0881B3CC */ }
        System.String InstanceAttr { get; /* RVA: 0x088197DC */ set; /* RVA: 0x0881B27C */ }
        System.String UnityInstanceAttr { get; /* RVA: 0x0881A270 */ set; /* RVA: 0x0881BAA4 */ }
        System.String UnityInputMeshAttr { get; /* RVA: 0x0881A1FC */ set; /* RVA: 0x0881BA50 */ }
        UnityEngine.Color LineColor { get; /* RVA: 0x08819A20 */ set; /* RVA: 0x0881B420 */ }
        System.Boolean UseHybridCurveEditing { get; /* RVA: 0x0881A6D0 */ set; /* RVA: 0x0881BDE4 */ }
        System.String EditorOnly_Tag { get; /* RVA: 0x088191F8 */ set; /* RVA: 0x0881AD7C */ }
        System.String HDAData_Name { get; /* RVA: 0x088192CC */ set; /* RVA: 0x0881AED0 */ }
        HoudiniEngineUnity.SessionMode Session_Mode { get; /* RVA: 0x08819E00 */ set; /* RVA: 0x0881B720 */ }
        System.String Session_PipeName { get; /* RVA: 0x08819E68 */ set; /* RVA: 0x0881B770 */ }
        System.String Session_Localhost { get; /* RVA: 0x08819D8C */ set; /* RVA: 0x0881B6CC */ }
        System.Int32 Session_Port { get; /* RVA: 0x08819EDC */ set; /* RVA: 0x0881B7C4 */ }
        System.Single Session_Timeout { get; /* RVA: 0x08819F40 */ set; /* RVA: 0x0881B814 */ }
        System.Boolean Session_AutoClose { get; /* RVA: 0x08819D2C */ set; /* RVA: 0x0881B67C */ }
        System.Boolean Curves_ShowInSceneView { get; /* RVA: 0x08818B80 */ set; /* RVA: 0x0881AB88 */ }
        System.String AssetCachePath { get; /* RVA: 0x088187F8 */ set; /* RVA: 0x0881A8B0 */ }
        System.Boolean UseFullPathNamesForOutput { get; /* RVA: 0x0881A610 */ set; /* RVA: 0x0881BD44 */ }
        System.Collections.Generic.List<System.String> HEngineToolsShelves { get; /* RVA: 0x088193A0 */ set; /* RVA: 0x0881AF74 */ }
        System.Int32 HEngineShelfSelectedIndex { get; /* RVA: 0x08819340 */ set; /* RVA: 0x0881AF24 */ }
        System.String DefaultTerrainMaterial { get; /* RVA: 0x08818E7C */ set; /* RVA: 0x0881AC80 */ }
        System.String TerrainSplatTextureDefault { get; /* RVA: 0x0881A128 */ set; /* RVA: 0x0881B9AC */ }
        System.String DefaultStandardShader { get; /* RVA: 0x08818CF8 */ set; /* RVA: 0x0881AC2C */ }
        System.String DefaultVertexColorShader { get; /* RVA: 0x08819074 */ set; /* RVA: 0x0881AD28 */ }
        System.String DefaultTransparentShader { get; /* RVA: 0x08818EF0 */ set; /* RVA: 0x0881ACD4 */ }
        System.String DefaultCurveShader { get; /* RVA: 0x08818BE0 */ set; /* RVA: 0x0881ABD8 */ }
        System.Boolean SupportHoudiniBoxType { get; /* RVA: 0x0881A068 */ set; /* RVA: 0x0881B90C */ }
        System.Boolean SupportHoudiniSphereType { get; /* RVA: 0x0881A0C8 */ set; /* RVA: 0x0881B95C */ }
        System.Boolean SetCurrentThreadToInvariantCulture { get; /* RVA: 0x08819FA8 */ set; /* RVA: 0x0881B86C */ }
        System.String HoudiniDebugLaunchPath { get; /* RVA: 0x08819404 */ set; /* RVA: 0x0881AFD0 */ }
        System.String LastExportPath { get; /* RVA: 0x08819850 */ set; /* RVA: 0x0881B2D0 */ }
        System.Int32 InputSelectionFilterLocation { get; /* RVA: 0x08819640 */ set; /* RVA: 0x0881B138 */ }
        System.Int32 InputSelectionFilterState { get; /* RVA: 0x08819778 */ set; /* RVA: 0x0881B22C */ }
        System.Boolean InputSelectionFilterRoots { get; /* RVA: 0x08819718 */ set; /* RVA: 0x0881B1DC */ }
        System.String InputSelectionFilterName { get; /* RVA: 0x088196A4 */ set; /* RVA: 0x0881B188 */ }
        System.Boolean CookOptionSplitGeosByGroup { get; /* RVA: 0x08818A00 */ set; /* RVA: 0x0881AA48 */ }
        System.Int32 MaxVerticesPerPrimitive { get; /* RVA: 0x08819AB8 */ set; /* RVA: 0x0881B48C */ }
        System.String HoudiniInstallPath { get; /* RVA: 0x08819564 */ set; /* RVA: 0x0881B08C */ }
        System.String LastHoudiniVersion { get; /* RVA: 0x088198C4 */ set; /* RVA: 0x0881B324 */ }
        System.Boolean SessionSyncAutoCook { get; /* RVA: 0x08819CCC */ set; /* RVA: 0x0881B62C */ }
        System.Boolean WriteCookLogs { get; /* RVA: 0x0881A850 */ set; /* RVA: 0x0881BF24 */ }
        System.Boolean UseHDRColor { get; /* RVA: 0x0881A670 */ set; /* RVA: 0x0881BD94 */ }
        System.Boolean UseSpecularShader { get; /* RVA: 0x0881A7F0 */ set; /* RVA: 0x0881BED4 */ }
        System.Boolean UseLegacyShaders { get; /* RVA: 0x0881A790 */ set; /* RVA: 0x0881BE84 */ }
        System.Boolean ShortenFolderPaths { get; /* RVA: 0x0881A008 */ set; /* RVA: 0x0881B8BC */ }
        System.Boolean UseLegacyInputCurves { get; /* RVA: 0x0881A730 */ set; /* RVA: 0x0881BE34 */ }
        System.Boolean CookOnMouseUp { get; /* RVA: 0x088189A0 */ set; /* RVA: 0x0881A9F8 */ }

    }

    // TypeToken: 0x200005F  // size: 0x28
    public class HEU_PluginStorage
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_PluginStorage.StoreData> _dataMap;  // 0x10
        private System.Collections.Generic.Dictionary<System.String,System.String> _envPathMap;  // 0x18
        protected System.Boolean _requiresSave;  // 0x20
        private static HoudiniEngineUnity.HEU_PluginStorage _instance;  // static @ 0x0
        public static System.String PluginSettingsLine1;  // const
        public static System.String PluginSettingsLine2;  // const
        public static System.String PluginSettingsVersion;  // const

        // Properties
        System.Boolean RequiresSave { get; /* RVA: 0x03D4EF90 */ }
        HoudiniEngineUnity.HEU_PluginStorage Instance { get; /* RVA: 0x0881E3BC */ }

        // Methods
        // RVA: 0x01041090  token: 0x600048C
        public System.Collections.Generic.Dictionary<System.String,System.String> GetEnvironmentPathMap() { }
        // RVA: 0x0881CB2C  token: 0x600048F
        public static System.Void InstantiateAndLoad() { }
        // RVA: 0x0350B670  token: 0x6000490
        public static System.Void SetCurrentCulture(System.Boolean useInvariant) { }
        // RVA: -1  // generic def  token: 0x6000491
        private T[] GetJSONArray(System.String jsonArray) { }
        // RVA: 0x0881E1D0  token: 0x6000492
        public System.Void Set(System.String key, System.Boolean value) { }
        // RVA: 0x0881DF0C  token: 0x6000493
        public System.Void Set(System.String key, System.Int32 value) { }
        // RVA: 0x0881DE48  token: 0x6000494
        public System.Void Set(System.String key, System.Int64 value) { }
        // RVA: 0x0881E10C  token: 0x6000495
        public System.Void Set(System.String key, System.Single value) { }
        // RVA: 0x0881DDB0  token: 0x6000496
        public System.Void Set(System.String key, System.String value) { }
        // RVA: 0x0881DFD0  token: 0x6000497
        public System.Void Set(System.String key, System.Collections.Generic.List<System.String> values, System.Char delimiter) { }
        // RVA: 0x0881C894  token: 0x6000498
        public System.Boolean Get(System.String key, System.Boolean& value, System.Boolean defaultValue) { }
        // RVA: 0x0881C5A0  token: 0x6000499
        public System.Boolean Get(System.String key, System.Int32& value, System.Int32 defaultValue) { }
        // RVA: 0x0881C7C0  token: 0x600049A
        public System.Boolean Get(System.String key, System.Int64& value, System.Int64 defaultValue) { }
        // RVA: 0x0881CA2C  token: 0x600049B
        public System.Boolean Get(System.String key, System.Single& value, System.Single defaultValue) { }
        // RVA: 0x0881C968  token: 0x600049C
        public System.Boolean Get(System.String key, System.String& value, System.String defaultValue) { }
        // RVA: 0x0881C674  token: 0x600049D
        public System.Boolean Get(System.String key, System.Collections.Generic.List<System.String>& values, System.Char delimiter) { }
        // RVA: 0x0350B670  token: 0x600049E
        protected virtual System.Void MarkDirtyForSave() { }
        // RVA: 0x0881D85C  token: 0x600049F
        public static System.Void SaveIfRequired() { }
        // RVA: 0x0881E294  token: 0x60004A0
        public static System.String SettingsFilePath() { }
        // RVA: 0x0881D8A8  token: 0x60004A1
        public virtual System.Boolean SavePluginData(System.String file) { }
        // RVA: 0x0881D04C  token: 0x60004A2
        public virtual System.Boolean LoadPluginData(System.String file) { }
        // RVA: 0x0115F4C0  token: 0x60004A3
        private System.Boolean ReadFromEditorPrefs() { }
        // RVA: 0x0881BF74  token: 0x60004A4
        public static System.Void ClearPluginData() { }
        // RVA: 0x0881D004  token: 0x60004A5
        public static System.Void LoadFromSavedFile() { }
        // RVA: 0x0881DD00  token: 0x60004A6
        public static System.String SessionFilePath() { }
        // RVA: 0x0350B670  token: 0x60004A7
        public static System.Void SaveAllSessionData(System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionBase> allSessions, System.String path) { }
        // RVA: 0x0881CC14  token: 0x60004A8
        public static System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionData> LoadAllSessionData(System.String path) { }
        // RVA: 0x0350B670  token: 0x60004A9
        public static System.Void DeleteAllSavedSessionData(System.String file) { }
        // RVA: 0x0881CC74  token: 0x60004AA
        public System.Void LoadAssetEnvironmentPaths() { }
        // RVA: 0x0881C2D0  token: 0x60004AB
        public System.String ConvertRealPathToEnvKeyedPath(System.String inPath) { }
        // RVA: 0x0881C02C  token: 0x60004AC
        public System.String ConvertEnvKeyedPathToReal(System.String inPath) { }
        // RVA: 0x0881E344  token: 0x60004AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x98
    public class HEU_Handle : UnityEngine.ScriptableObject, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.String _handleName;  // 0x18
        private HoudiniEngineUnity.HEU_Handle.HEU_HandleType _handleType;  // 0x20
        private System.Int32 _handleIndex;  // 0x24
        private HoudiniEngineUnity.HEU_HandleParamBinding _handleParamTranslateBinding;  // 0x28
        private HoudiniEngineUnity.HEU_HandleParamBinding _handleParamRotateBinding;  // 0x30
        private HoudiniEngineUnity.HEU_HandleParamBinding _handleParamScaleBinding;  // 0x38
        private UnityEngine.Vector3 _handlePosition;  // 0x40
        private UnityEngine.Quaternion _handleRotation;  // 0x4c
        private UnityEngine.Vector3 _handleScale;  // 0x5c
        private HoudiniEngineUnity.HAPI_RSTOrder _rstOrder;  // 0x68
        private HoudiniEngineUnity.HAPI_XYZOrder _xyzOrder;  // 0x6c
        private HoudiniEngineUnity.HAPI_TransformEuler _convertedTransformEuler;  // 0x70

        // Properties
        System.String HandleName { get; /* RVA: 0x01041090 */ }
        HoudiniEngineUnity.HEU_Handle.HEU_HandleType HandleType { get; /* RVA: 0x01003B50 */ }
        HoudiniEngineUnity.HAPI_RSTOrder RSTOrder { get; /* RVA: 0x03D4EEE0 */ }
        HoudiniEngineUnity.HAPI_XYZOrder XYZOrder { get; /* RVA: 0x03D4F400 */ }
        HoudiniEngineUnity.HAPI_TransformEuler ConvertedTransformEuler { get; /* RVA: 0x03D6D630 */ }
        UnityEngine.Vector3 HandlePosition { get; /* RVA: 0x03D52300 */ }
        UnityEngine.Quaternion HandleRotation { get; /* RVA: 0x03D5E6D0 */ }
        UnityEngine.Vector3 HandleScale { get; /* RVA: 0x03D6D660 */ }

        // Methods
        // RVA: 0x05693D38  token: 0x60004B5
        public System.Boolean HasTranslateHandle() { }
        // RVA: 0x085839D0  token: 0x60004B6
        public System.Boolean HasRotateHandle() { }
        // RVA: 0x060DAC58  token: 0x60004B7
        public System.Boolean HasScaleHandle() { }
        // RVA: 0x0880ACDC  token: 0x60004B8
        public System.Boolean IsTranslateHandleDisabled() { }
        // RVA: 0x0880ACA0  token: 0x60004B9
        public System.Boolean IsRotateHandleDisabled() { }
        // RVA: 0x0880ACB4  token: 0x60004BA
        public System.Boolean IsScaleHandleDisabled() { }
        // RVA: 0x03D4EAC0  token: 0x60004BB
        public HoudiniEngineUnity.HEU_HandleParamBinding GetTranslateBinding() { }
        // RVA: 0x01003830  token: 0x60004BC
        public HoudiniEngineUnity.HEU_HandleParamBinding GetRotateBinding() { }
        // RVA: 0x03D4E2A0  token: 0x60004BD
        public HoudiniEngineUnity.HEU_HandleParamBinding GetScaleBinding() { }
        // RVA: 0x0880ACF0  token: 0x60004C1
        public System.Boolean SetupHandle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 handleIndex, System.String handleName, HoudiniEngineUnity.HEU_Handle.HEU_HandleType handleType, HoudiniEngineUnity.HAPI_HandleInfo& handleInfo, HoudiniEngineUnity.HEU_Parameters parameters) { }
        // RVA: 0x0880A1E8  token: 0x60004C2
        public System.Void CleanUp() { }
        // RVA: 0x0880A220  token: 0x60004C3
        public System.Void GenerateTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_Parameters parameters) { }
        // RVA: 0x0880A638  token: 0x60004C4
        public System.Boolean GetUpdatedPosition(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Vector3& inPosition) { }
        // RVA: 0x0880A6F4  token: 0x60004C5
        public System.Boolean GetUpdatedRotation(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Quaternion& inRotation) { }
        // RVA: 0x0880ACC8  token: 0x60004C6
        public static System.Boolean IsSpecialRSTOrder(HoudiniEngineUnity.HAPI_RSTOrder rstOrder) { }
        // RVA: 0x0880A828  token: 0x60004C7
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Handle other) { }
        // RVA: 0x0880AE14  token: 0x60004C8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000065  // size: 0x30
    public class HEU_HandleParamBinding : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType _paramType;  // 0x10
        public System.Int32 _parmID;  // 0x14
        public System.String _paramName;  // 0x18
        public System.Boolean _bDisabled;  // 0x20
        public System.Boolean[] _boundChannels;  // 0x28

        // Methods
        // RVA: 0x08809FD4  token: 0x60004C9
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HandleParamBinding other) { }
        // RVA: 0x0880A1A0  token: 0x60004CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000067  // size: 0x10
    public static class HEU_HAPIConstants
    {
        // Fields
        public static System.Int32 HAPI_POSITION_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_SCALE_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_SHEAR_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_NORMAL_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_QUATERNION_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_EULER_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_UV_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_COLOR_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_CV_VECTOR_SIZE;  // const
        public static System.Int32 HAPI_PRIM_MIN_VERTEX_COUNT;  // const
        public static System.Int32 HAPI_PRIM_MAX_VERTEX_COUNT;  // const
        public static System.Int32 HAPI_INVALID_PARM_ID;  // const
        public static System.String HAPI_ATTRIB_POSITION;  // const
        public static System.String HAPI_ATTRIB_UV;  // const
        public static System.String HAPI_ATTRIB_UV2;  // const
        public static System.String HAPI_ATTRIB_NORMAL;  // const
        public static System.String HAPI_ATTRIB_TANGENT;  // const
        public static System.String HAPI_ATTRIB_TANGENT2;  // const
        public static System.String HAPI_ATTRIB_COLOR;  // const
        public static System.String HAPI_ATTRIB_NAME;  // const
        public static System.String HAPI_ATTRIB_INSTANCE;  // const
        public static System.String HAPI_ATTRIB_ROT;  // const
        public static System.String HAPI_ATTRIB_SCALE;  // const
        public static System.String HAPI_UNGROUPED_GROUP_NAME;  // const
        public static System.String HAPI_RAW_FORMAT_NAME;  // const
        public static System.String HAPI_PNG_FORMAT_NAME;  // const
        public static System.String HAPI_JPEG_FORMAT_NAME;  // const
        public static System.String HAPI_BMP_FORMAT_NAME;  // const
        public static System.String HAPI_TIFF_FORMAT_NAME;  // const
        public static System.String HAPI_TGA_FORMAT_NAME;  // const
        public static System.String HAPI_DEFAULT_IMAGE_FORMAT_NAME;  // const
        public static System.String HAPI_GLOBAL_NODES_NODE_NAME;  // const
        public static System.String HAPI_ENV_HIP;  // const
        public static System.String HAPI_ENV_JOB;  // const
        public static System.String HAPI_ENV_CLIENT_NAME;  // const
        public static System.String HAPI_CACHE_COP_COOK;  // const
        public static System.String HAPI_CACHE_COP_FLIPBOOK;  // const
        public static System.String HAPI_CACHE_IMAGE;  // const
        public static System.String HAPI_CACHE_OBJ;  // const
        public static System.String HAPI_CACHE_GL_TEXTURE;  // const
        public static System.String HAPI_CACHE_GL_VERTEX;  // const
        public static System.String HAPI_CACHE_SOP;  // const
        public static System.String HAPI_CACHE_VEX;  // const
        public static System.String HAPI_ATTRIB_INPUT_CURVE_COORDS;  // const

    }

    // TypeToken: 0x2000068  // size: 0x14
    public sealed struct HAPI_License
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_NONE;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_FX;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_INDIE;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_INDIE;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL;  // const
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_MAX;  // const

    }

    // TypeToken: 0x2000069  // size: 0x14
    public sealed struct HAPI_StatusType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_CALL_RESULT;  // const
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_COOK_RESULT;  // const
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_COOK_STATE;  // const
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_MAX;  // const

    }

    // TypeToken: 0x200006A  // size: 0x14
    public sealed struct HAPI_StatusVerbosity
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_0;  // const
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_1;  // const
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_2;  // const
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_ALL;  // const
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_ERRORS;  // const
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_WARNINGS;  // const
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_MESSAGES;  // const

    }

    // TypeToken: 0x200006B  // size: 0x14
    public sealed struct HAPI_Result
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_SUCCESS;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_FAILURE;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_ALREADY_INITIALIZED;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_NOT_INITIALIZED;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_LOADFILE;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_PARM_SET_FAILED;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_INVALID_ARGUMENT;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_LOAD_GEO;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_GENERATE_PRESET;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_LOAD_PRESET;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_ASSET_DEF_ALREADY_LOADED;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_NO_LICENSE_FOUND;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_NC_LICENSE_FOUND;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_C_LICENSE;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_LC_LICENSE;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_LC_ASSET_WITH_C_LICENSE;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_HENGINEINDIE_W_3PARTY_PLUGIN;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_ASSET_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_NODE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_USER_INTERRUPTED;  // const
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_INVALID_SESSION;  // const

    }

    // TypeToken: 0x200006C  // size: 0x14
    public sealed struct HAPI_ErrorCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_ErrorCode HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND;  // const
        public static HoudiniEngineUnity.HAPI_ErrorCode HAPI_ERRORCODE_PYTHON_NODE_ERROR;  // const

    }

    // TypeToken: 0x200006D  // size: 0x14
    public sealed struct HAPI_SessionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_INPROCESS;  // const
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_THRIFT;  // const
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_CUSTOM1;  // const
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_CUSTOM2;  // const
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_CUSTOM3;  // const
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_MAX;  // const

    }

    // TypeToken: 0x200006E  // size: 0x14
    public sealed struct HAPI_State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_READY;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_READY_WITH_FATAL_ERRORS;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_READY_WITH_COOK_ERRORS;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_STARTING_COOK;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_COOKING;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_STARTING_LOAD;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_LOADING;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_MAX;  // const
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_MAX_READY_STATE;  // const

    }

    // TypeToken: 0x200006F  // size: 0x14
    public sealed struct HAPI_PackedPrimInstancingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED;  // const
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY;  // const
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT;  // const
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_MAX;  // const

    }

    // TypeToken: 0x2000070  // size: 0x14
    public sealed struct HAPI_Permissions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_NON_APPLICABLE;  // const
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_READ_WRITE;  // const
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_READ_ONLY;  // const
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_WRITE_ONLY;  // const
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_MAX;  // const

    }

    // TypeToken: 0x2000071  // size: 0x14
    public sealed struct HAPI_RampType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_FLOAT;  // const
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_COLOR;  // const
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_MAX;  // const

    }

    // TypeToken: 0x2000072  // size: 0x14
    public sealed struct HAPI_ParmType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_INT;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_MULTIPARMLIST;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_TOGGLE;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_BUTTON;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FLOAT;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_COLOR;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_STRING;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE_GEO;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE_IMAGE;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NODE;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FOLDERLIST;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FOLDERLIST_RADIO;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FOLDER;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_LABEL;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_SEPARATOR;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE_DIR;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_MAX;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_INT_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_INT_END;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FLOAT_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FLOAT_END;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_STRING_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_STRING_END;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_END;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NODE_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NODE_END;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_CONTAINER_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_CONTAINER_END;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NONVALUE_START;  // const
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NONVALUE_END;  // const

    }

    // TypeToken: 0x2000073  // size: 0x14
    public sealed struct HAPI_PrmScriptType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FLOAT;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_ANGLE;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_STRING;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FILE;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_DIRECTORY;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_IMAGE;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GEOMETRY;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_TOGGLE;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_BUTTON;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_VECTOR2;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_VECTOR3;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_VECTOR4;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INTVECTOR2;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INTVECTOR3;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INTVECTOR4;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_UV;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_UVW;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_DIR;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_COLOR;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_COLOR4;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OPPATH;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OPLIST;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OBJECT;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OBJECTLIST;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RENDER;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_SEPARATOR;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_LABEL;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RGBAMASK;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_ORDINAL;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RAMP_FLT;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RAMP_RGB;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FLOAT_LOG;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT_LOG;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_DATA;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT_MINMAX;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT_STARTEND;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_ICONSTRIP;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUPRADIO;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE;  // const
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUP;  // const

    }

    // TypeToken: 0x2000074  // size: 0x14
    public sealed struct HAPI_ChoiceListType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_NONE;  // const
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_NORMAL;  // const
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_MINI;  // const
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_REPLACE;  // const
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_TOGGLE;  // const

    }

    // TypeToken: 0x2000075  // size: 0x14
    public sealed struct HAPI_PresetType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_BINARY;  // const
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_IDX;  // const
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_MAX;  // const

    }

    // TypeToken: 0x2000076  // size: 0x14
    public sealed struct HAPI_NodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_ANY;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_NONE;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_OBJ;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_SOP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_CHOP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_ROP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_SHOP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_COP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_VOP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_DOP;  // const
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_TOP;  // const

    }

    // TypeToken: 0x2000077  // size: 0x14
    public sealed struct HAPI_NodeFlags
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_ANY;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_NONE;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_DISPLAY;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_RENDER;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_TEMPLATED;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_LOCKED;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_EDITABLE;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_BYPASS;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_NETWORK;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_GEOMETRY;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_CAMERA;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_LIGHT;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_SUBNET;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_SOP_CURVE;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_SOP_GUIDE;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_TOP_NONSCHEDULER;  // const
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_NON_BYPASS;  // const

    }

    // TypeToken: 0x2000078  // size: 0x14
    public sealed struct HAPI_GroupType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_POINT;  // const
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_PRIM;  // const
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_EDGE;  // const
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_MAX;  // const

    }

    // TypeToken: 0x2000079  // size: 0x14
    public sealed struct HAPI_AttributeOwner
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_VERTEX;  // const
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_POINT;  // const
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_PRIM;  // const
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_DETAIL;  // const
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_MAX;  // const

    }

    // TypeToken: 0x200007A  // size: 0x14
    public sealed struct HAPI_CurveType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_LINEAR;  // const
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_NURBS;  // const
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_BEZIER;  // const
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_MAX;  // const

    }

    // TypeToken: 0x200007B  // size: 0x14
    public sealed struct HAPI_InputCurveMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_CVS;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_BREAKPOINTS;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_MAX;  // const

    }

    // TypeToken: 0x200007C  // size: 0x14
    public sealed struct HAPI_InputCurveParameterization
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_UNIFORM;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_CHORD;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_CENTRIPETAL;  // const
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_MAX;  // const

    }

    // TypeToken: 0x200007D  // size: 0x14
    public sealed struct HAPI_VolumeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_HOUDINI;  // const
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_VDB;  // const
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_MAX;  // const

    }

    // TypeToken: 0x200007E  // size: 0x14
    public sealed struct HAPI_VolumeVisualType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_SMOKE;  // const
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_RAINBOW;  // const
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_ISO;  // const
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_INVISIBLE;  // const
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_HEIGHTFIELD;  // const
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_MAX;  // const

    }

    // TypeToken: 0x200007F  // size: 0x14
    public sealed struct HAPI_StorageType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT64;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT64;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_STRING;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_UINT8;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT8;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT16;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT64_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT64_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_STRING_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_UINT8_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT8_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT16_ARRAY;  // const
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_MAX;  // const

    }

    // TypeToken: 0x2000080  // size: 0x14
    public sealed struct HAPI_AttributeTypeInfo
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_NONE;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_POINT;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_HPOINT;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_VECTOR;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_NORMAL;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_COLOR;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_QUATERNION;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_MATRIX3;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_MATRIX;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_ST;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_HIDDEN;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_BOX2;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_BOX;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_TEXTURE;  // const
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_MAX;  // const

    }

    // TypeToken: 0x2000081  // size: 0x14
    public sealed struct HAPI_GeoType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_DEFAULT;  // const
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INTERMEDIATE;  // const
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INPUT;  // const
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_CURVE;  // const
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_MAX;  // const

    }

    // TypeToken: 0x2000082  // size: 0x14
    public sealed struct HAPI_PartType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_MESH;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_CURVE;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_VOLUME;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_INSTANCER;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_BOX;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_SPHERE;  // const
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_MAX;  // const

    }

    // TypeToken: 0x2000083  // size: 0x14
    public sealed struct HAPI_InputType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_TRANSFORM;  // const
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_GEOMETRY;  // const
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_MAX;  // const

    }

    // TypeToken: 0x2000084  // size: 0x14
    public sealed struct HAPI_CurveOrders
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_VARYING;  // const
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_LINEAR;  // const
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_QUADRATIC;  // const
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_CUBIC;  // const

    }

    // TypeToken: 0x2000085  // size: 0x14
    public sealed struct HAPI_TransformComponent
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_TX;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_TY;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_TZ;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_RX;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_RY;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_RZ;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QX;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QY;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QZ;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QW;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_SX;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_SY;  // const
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_SZ;  // const

    }

    // TypeToken: 0x2000086  // size: 0x14
    public sealed struct HAPI_RSTOrder
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_TRS;  // const
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_TSR;  // const
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_RTS;  // const
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_RST;  // const
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_STR;  // const
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_SRT;  // const
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_RSTORDER_DEFAULT;  // const

    }

    // TypeToken: 0x2000087  // size: 0x14
    public sealed struct HAPI_XYZOrder
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_XYZ;  // const
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_XZY;  // const
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_YXZ;  // const
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_YZX;  // const
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_ZXY;  // const
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_ZYX;  // const
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_XYZORDER_DEFAULT;  // const

    }

    // TypeToken: 0x2000088  // size: 0x14
    public sealed struct HAPI_ImageDataFormat
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_UNKNOWN;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_INT8;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_INT16;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_INT32;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_FLOAT16;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_FLOAT32;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_MAX;  // const
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_DEFAULT;  // const

    }

    // TypeToken: 0x2000089  // size: 0x14
    public sealed struct HAPI_ImagePacking
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_UNKNOWN;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_SINGLE;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_DUAL;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_RGB;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_BGR;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_RGBA;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_ABGR;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_MAX;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_DEFAULT3;  // const
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_DEFAULT4;  // const

    }

    // TypeToken: 0x200008A  // size: 0x14
    public sealed struct HAPI_EnvIntType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_MAJOR;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_MINOR;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_BUILD;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_PATCH;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MAJOR;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MINOR;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_ENGINE_API;  // const
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_MAX;  // const

    }

    // TypeToken: 0x200008B  // size: 0x14
    public sealed struct HAPI_SessionEnvIntType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_SessionEnvIntType HAPI_SESSIONENVINT_INVALID;  // const
        public static HoudiniEngineUnity.HAPI_SessionEnvIntType HAPI_SESSIONENVINT_LICENSE;  // const
        public static HoudiniEngineUnity.HAPI_SessionEnvIntType HAPI_SESSIONENVINT_MAX;  // const

    }

    // TypeToken: 0x200008C  // size: 0x14
    public sealed struct HAPI_CacheProperty
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_CURRENT;  // const
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_HAS_MIN;  // const
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_MIN;  // const
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_HAS_MAX;  // const
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_MAX;  // const
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_CULL_LEVEL;  // const

    }

    // TypeToken: 0x200008D  // size: 0x14
    public sealed struct HAPI_HeightFieldSampling
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_HeightFieldSampling HAPI_HEIGHTFIELD_SAMPLING_CENTER;  // const
        public static HoudiniEngineUnity.HAPI_HeightFieldSampling HAPI_HEIGHTFIELD_SAMPLING_CORNER;  // const

    }

    // TypeToken: 0x200008E  // size: 0x14
    public sealed struct HAPI_PDG_State
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_READY;  // const
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_COOKING;  // const
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_MAX;  // const
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_MAX_READY_STATE;  // const

    }

    // TypeToken: 0x200008F  // size: 0x14
    public sealed struct HAPI_PDG_EventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NULL;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_STATE_CHANGE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD_DEP;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE_DEP;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD_PARENT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE_PARENT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_CLEAR;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_ERROR;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_WARNING;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_COMPLETE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_DIRTY_START;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_DIRTY_STOP;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_DIRTY_ALL;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_UI_SELECT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_CREATE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_REMOVE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_RENAME;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_CONNECT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_DISCONNECT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_INT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_FLOAT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_STRING;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_FILE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_MERGE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_RESULT;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_PRIORITY;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_START;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_PROGRESS_UPDATE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_ALL;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_LOG;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SCHEDULER_ADDED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SCHEDULER_REMOVED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SET_SCHEDULER;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SERVICE_MANAGER_ALL;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_COOKED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_GENERATED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_CONTEXT_EVENTS;  // const

    }

    // TypeToken: 0x2000090  // size: 0x14
    public sealed struct HAPI_PDG_WorkItemState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_UNDEFINED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_UNCOOKED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_WAITING;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_SCHEDULED;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKING;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_SUCCESS;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_CACHE;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_FAIL;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_CANCEL;  // const
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_DIRTY;  // const

    }

    // TypeToken: 0x2000091  // size: 0x10
    public static class HEU_HAPIFunctions
    {
    }

    // TypeToken: 0x2000092  // size: 0x38
    public sealed struct HAPI_Transform
    {
        // Fields
        public System.Single[] position;  // 0x10
        public System.Single[] rotationQuaternion;  // 0x18
        public System.Single[] scale;  // 0x20
        public System.Single[] shear;  // 0x28
        public HoudiniEngineUnity.HAPI_RSTOrder rstOrder;  // 0x30

        // Methods
        // RVA: 0x08805510  token: 0x60004CB
        public System.Void .ctor(System.Boolean initializeFields) { }
        // RVA: 0x08805450  token: 0x60004CC
        public System.Void Init() { }

    }

    // TypeToken: 0x2000093  // size: 0x38
    public sealed struct HAPI_TransformEuler
    {
        // Fields
        public System.Single[] position;  // 0x10
        public System.Single[] rotationEuler;  // 0x18
        public System.Single[] scale;  // 0x20
        public System.Single[] shear;  // 0x28
        public HoudiniEngineUnity.HAPI_XYZOrder rotationOrder;  // 0x30
        public HoudiniEngineUnity.HAPI_RSTOrder rstOrder;  // 0x34

        // Methods
        // RVA: 0x08805388  token: 0x60004CD
        public System.Void .ctor(System.Boolean initializeFields) { }
        // RVA: 0x088052E4  token: 0x60004CE
        public System.Void Init() { }

    }

    // TypeToken: 0x2000094  // size: 0x20
    public sealed struct HAPI_Session
    {
        // Fields
        public HoudiniEngineUnity.HAPI_SessionType type;  // 0x10
        public System.Int64 id;  // 0x18

    }

    // TypeToken: 0x2000095  // size: 0x1C
    public sealed struct HAPI_ThriftServerOptions
    {
        // Fields
        public System.Boolean autoClose;  // 0x10
        public System.Single timeoutMs;  // 0x14
        public HoudiniEngineUnity.HAPI_StatusVerbosity verbosity;  // 0x18

    }

    // TypeToken: 0x2000096  // size: 0x1C
    public sealed struct HAPI_TimelineOptions
    {
        // Fields
        public System.Single fps;  // 0x10
        public System.Single startTime;  // 0x14
        public System.Single endTime;  // 0x18

    }

    // TypeToken: 0x2000097  // size: 0x50
    public sealed struct HAPI_AssetInfo
    {
        // Fields
        public System.Int32 nodeId;  // 0x10
        public System.Int32 objectNodeId;  // 0x14
        public System.Boolean hasEverCooked;  // 0x18
        public System.Int32 nameSH;  // 0x1c
        public System.Int32 labelSH;  // 0x20
        public System.Int32 filePathSH;  // 0x24
        public System.Int32 versionSH;  // 0x28
        public System.Int32 fullOpNameSH;  // 0x2c
        public System.Int32 helpTextSH;  // 0x30
        public System.Int32 helpURLSH;  // 0x34
        public System.Int32 objectCount;  // 0x38
        public System.Int32 handleCount;  // 0x3c
        public System.Int32 transformInputCount;  // 0x40
        public System.Int32 geoInputCount;  // 0x44
        public System.Int32 geoOutputCount;  // 0x48
        public System.Boolean haveObjectsChanged;  // 0x4c
        public System.Boolean haveMaterialsChanged;  // 0x4d

    }

    // TypeToken: 0x2000098  // size: 0x40
    public sealed struct HAPI_CookOptions
    {
        // Fields
        public System.Boolean splitGeosByGroup;  // 0x10
        public System.Int32 splitGroupSH;  // 0x14
        public System.Boolean splitGeosByAttribute;  // 0x18
        public System.Int32 splitAttrSH;  // 0x1c
        public System.Int32 maxVerticesPerPrimitive;  // 0x20
        public System.Boolean refineCurveToLinear;  // 0x24
        public System.Single curveRefineLOD;  // 0x28
        public System.Boolean clearErrorsAndWarnings;  // 0x2c
        public System.Boolean cookTemplatedGeos;  // 0x2d
        public System.Boolean splitPointsByVertexAttributes;  // 0x2e
        public HoudiniEngineUnity.HAPI_PackedPrimInstancingMode packedPrimInstancingMode;  // 0x30
        public System.Boolean handleBoxPartTypes;  // 0x34
        public System.Boolean handleSpherePartTypes;  // 0x35
        public System.Boolean checkPartChanges;  // 0x36
        public System.Boolean cacheMeshTopology;  // 0x37
        public System.Boolean preferOutputNodes;  // 0x38
        public System.Int32 extraFlags;  // 0x3c

    }

    // TypeToken: 0x2000099  // size: 0x54
    public sealed struct HAPI_NodeInfo
    {
        // Fields
        public System.Int32 id;  // 0x10
        public System.Int32 parentId;  // 0x14
        public System.Int32 nameSH;  // 0x18
        public HoudiniEngineUnity.HAPI_NodeType type;  // 0x1c
        public System.Boolean isValid;  // 0x20
        public System.Int32 totalCookCount;  // 0x24
        public System.Int32 uniqueHoudiniNodeId;  // 0x28
        public System.Int32 internalNodePathSH;  // 0x2c
        public System.Int32 parmCount;  // 0x30
        public System.Int32 parmIntValueCount;  // 0x34
        public System.Int32 parmFloatValueCount;  // 0x38
        public System.Int32 parmStringValueCount;  // 0x3c
        public System.Int32 parmChoiceCount;  // 0x40
        public System.Int32 childNodeCount;  // 0x44
        public System.Int32 inputCount;  // 0x48
        public System.Int32 outputCount;  // 0x4c
        public System.Boolean createdPostAssetLoad;  // 0x50
        public System.Boolean isTimeDependent;  // 0x51

    }

    // TypeToken: 0x200009A  // size: 0xA4
    public sealed struct HAPI_ParmInfo
    {
        // Fields
        public System.Int32 id;  // 0x10
        public System.Int32 parentId;  // 0x14
        public System.Int32 childIndex;  // 0x18
        public HoudiniEngineUnity.HAPI_ParmType type;  // 0x1c
        public HoudiniEngineUnity.HAPI_PrmScriptType scriptType;  // 0x20
        public System.Int32 typeInfoSH;  // 0x24
        public HoudiniEngineUnity.HAPI_Permissions permissions;  // 0x28
        public System.Int32 tagCount;  // 0x2c
        public System.Int32 size;  // 0x30
        public HoudiniEngineUnity.HAPI_ChoiceListType choiceListType;  // 0x34
        public System.Int32 choiceCount;  // 0x38
        public System.Int32 nameSH;  // 0x3c
        public System.Int32 labelSH;  // 0x40
        public System.Int32 templateNameSH;  // 0x44
        public System.Int32 helpSH;  // 0x48
        public System.Boolean hasMin;  // 0x4c
        public System.Boolean hasMax;  // 0x4d
        public System.Boolean hasUIMin;  // 0x4e
        public System.Boolean hasUIMax;  // 0x4f
        public System.Single min;  // 0x50
        public System.Single max;  // 0x54
        public System.Single UIMin;  // 0x58
        public System.Single UIMax;  // 0x5c
        public System.Boolean invisible;  // 0x60
        public System.Boolean disabled;  // 0x61
        public System.Boolean spare;  // 0x62
        public System.Boolean joinNext;  // 0x63
        public System.Boolean labelNone;  // 0x64
        public System.Int32 intValuesIndex;  // 0x68
        public System.Int32 floatValuesIndex;  // 0x6c
        public System.Int32 stringValuesIndex;  // 0x70
        public System.Int32 choiceIndex;  // 0x74
        public HoudiniEngineUnity.HAPI_NodeType inputNodeType;  // 0x78
        public HoudiniEngineUnity.HAPI_NodeFlags inputNodeFlag;  // 0x7c
        public System.Boolean isChildOfMultiParm;  // 0x80
        public System.Int32 instanceNum;  // 0x84
        public System.Int32 instanceLength;  // 0x88
        public System.Int32 instanceCount;  // 0x8c
        public System.Int32 instanceStartOffset;  // 0x90
        public HoudiniEngineUnity.HAPI_RampType rampType;  // 0x94
        public System.Int32 visibilityConditionSH;  // 0x98
        public System.Int32 disabledConditionSH;  // 0x9c
        public System.Boolean useMenuItemTokenAsValue;  // 0xa0

        // Methods
        // RVA: 0x08804FBC  token: 0x60004CF
        public System.Boolean isInt() { }
        // RVA: 0x08804FA8  token: 0x60004D0
        public System.Boolean isFloat() { }
        // RVA: 0x08805018  token: 0x60004D1
        public System.Boolean isString() { }
        // RVA: 0x08805000  token: 0x60004D2
        public System.Boolean isPath() { }
        // RVA: 0x08804FDC  token: 0x60004D3
        public System.Boolean isNode() { }
        // RVA: 0x08804FEC  token: 0x60004D4
        public System.Boolean isNonValue() { }

    }

    // TypeToken: 0x200009B  // size: 0x1C
    public sealed struct HAPI_ParmChoiceInfo
    {
        // Fields
        public System.Int32 parentParmId;  // 0x10
        public System.Int32 labelSH;  // 0x14
        public System.Int32 valueSH;  // 0x18

    }

    // TypeToken: 0x200009C  // size: 0x1C
    public sealed struct HAPI_HandleInfo
    {
        // Fields
        public System.Int32 nameSH;  // 0x10
        public System.Int32 typeNameSH;  // 0x14
        public System.Int32 bindingsCount;  // 0x18

    }

    // TypeToken: 0x200009D  // size: 0x20
    public sealed struct HAPI_HandleBindingInfo
    {
        // Fields
        public System.Int32 handleParmNameSH;  // 0x10
        public System.Int32 assetParmNameSH;  // 0x14
        public System.Int32 assetParmId;  // 0x18
        public System.Int32 assetParmIndex;  // 0x1c

    }

    // TypeToken: 0x200009E  // size: 0x2C
    public sealed struct HAPI_ObjectInfo
    {
        // Fields
        public System.Int32 nameSH;  // 0x10
        public System.Int32 objectInstancePathSH;  // 0x14
        public System.Boolean hasTransformChanged;  // 0x18
        public System.Boolean haveGeosChanged;  // 0x19
        public System.Boolean isVisible;  // 0x1a
        public System.Boolean isInstancer;  // 0x1b
        public System.Boolean isInstanced;  // 0x1c
        public System.Int32 geoCount;  // 0x20
        public System.Int32 nodeId;  // 0x24
        public System.Int32 objectToInstanceId;  // 0x28

    }

    // TypeToken: 0x200009F  // size: 0x34
    public sealed struct HAPI_GeoInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_GeoType type;  // 0x10
        public System.Int32 nameSH;  // 0x14
        public System.Int32 nodeId;  // 0x18
        public System.Boolean isEditable;  // 0x1c
        public System.Boolean isTemplated;  // 0x1d
        public System.Boolean isDisplayGeo;  // 0x1e
        public System.Boolean hasGeoChanged;  // 0x1f
        public System.Boolean hasMaterialChanged;  // 0x20
        public System.Int32 pointGroupCount;  // 0x24
        public System.Int32 primitiveGroupCount;  // 0x28
        public System.Int32 edgeGroupCount;  // 0x2c
        public System.Int32 partCount;  // 0x30

        // Methods
        // RVA: 0x08804F44  token: 0x60004D5
        public System.Int32 getGroupCountByType(HoudiniEngineUnity.HAPI_GroupType type) { }

    }

    // TypeToken: 0x20000A0  // size: 0x40
    public sealed struct HAPI_PartInfo
    {
        // Fields
        public System.Int32 id;  // 0x10
        public System.Int32 nameSH;  // 0x14
        public HoudiniEngineUnity.HAPI_PartType type;  // 0x18
        public System.Int32 faceCount;  // 0x1c
        public System.Int32 vertexCount;  // 0x20
        public System.Int32 pointCount;  // 0x24
        public System.Int32[] attributeCounts;  // 0x28
        public System.Boolean isInstanced;  // 0x30
        public System.Int32 instancedPartCount;  // 0x34
        public System.Int32 instanceCount;  // 0x38
        public System.Boolean hasChanged;  // 0x3c

        // Properties
        System.Int32 pointAttributeCount { get; /* RVA: 0x088050A8 */ set; /* RVA: 0x088051D4 */ }
        System.Int32 primitiveAttributeCount { get; /* RVA: 0x088050DC */ set; /* RVA: 0x08805214 */ }
        System.Int32 vertexAttributeCount { get; /* RVA: 0x08805110 */ set; /* RVA: 0x08805254 */ }
        System.Int32 detailAttributeCount { get; /* RVA: 0x08805074 */ set; /* RVA: 0x08805194 */ }

        // Methods
        // RVA: 0x08805038  token: 0x60004D6
        public System.Int32 getElementCountByAttributeOwner(HoudiniEngineUnity.HAPI_AttributeOwner owner) { }
        // RVA: 0x08805060  token: 0x60004D7
        public System.Int32 getElementCountByGroupType(HoudiniEngineUnity.HAPI_GroupType type) { }
        // RVA: 0x08805144  token: 0x60004D8
        public System.Void init() { }

    }

    // TypeToken: 0x20000A1  // size: 0x38
    public sealed struct HAPI_AttributeInfo
    {
        // Fields
        public System.Boolean exists;  // 0x10
        public HoudiniEngineUnity.HAPI_AttributeOwner owner;  // 0x14
        public HoudiniEngineUnity.HAPI_StorageType storage;  // 0x18
        public HoudiniEngineUnity.HAPI_AttributeOwner originalOwner;  // 0x1c
        public System.Int32 count;  // 0x20
        public System.Int32 tupleSize;  // 0x24
        public System.Int64 totalArrayElements;  // 0x28
        public HoudiniEngineUnity.HAPI_AttributeTypeInfo typeInfo;  // 0x30

        // Methods
        // RVA: 0x03D6D430  token: 0x60004E1
        public System.Void .ctor(System.String ignored) { }

    }

    // TypeToken: 0x20000A2  // size: 0x18
    public sealed struct HAPI_MaterialInfo
    {
        // Fields
        public System.Int32 nodeId;  // 0x10
        public System.Boolean exists;  // 0x14
        public System.Boolean hasChanged;  // 0x15

    }

    // TypeToken: 0x20000A3  // size: 0x1C
    public sealed struct HAPI_ImageFileFormat
    {
        // Fields
        public System.Int32 nameSH;  // 0x10
        public System.Int32 descriptionSH;  // 0x14
        public System.Int32 defaultExtensionSH;  // 0x18

    }

    // TypeToken: 0x20000A4  // size: 0x30
    public sealed struct HAPI_ImageInfo
    {
        // Fields
        public System.Int32 imageFileFormatNameSH;  // 0x10
        public System.Int32 xRes;  // 0x14
        public System.Int32 yRes;  // 0x18
        public HoudiniEngineUnity.HAPI_ImageDataFormat dataFormat;  // 0x1c
        public System.Boolean interleaved;  // 0x20
        public HoudiniEngineUnity.HAPI_ImagePacking packing;  // 0x24
        public System.Double gamma;  // 0x28

    }

    // TypeToken: 0x20000A5  // size: 0x20
    public sealed struct HAPI_Keyframe
    {
        // Fields
        public System.Single time;  // 0x10
        public System.Single value;  // 0x14
        public System.Single inTangent;  // 0x18
        public System.Single outTangent;  // 0x1c

        // Methods
        // RVA: 0x03D516B0  token: 0x60004E2
        public System.Void .ctor(System.Single t, System.Single v, System.Single in_tangent, System.Single out_tangent) { }

    }

    // TypeToken: 0x20000A6  // size: 0x78
    public sealed struct HAPI_VolumeInfo
    {
        // Fields
        public System.Int32 nameSH;  // 0x10
        public HoudiniEngineUnity.HAPI_VolumeType type;  // 0x14
        public System.Int32 xLength;  // 0x18
        public System.Int32 yLength;  // 0x1c
        public System.Int32 zLength;  // 0x20
        public System.Int32 minX;  // 0x24
        public System.Int32 minY;  // 0x28
        public System.Int32 minZ;  // 0x2c
        public System.Int32 tupleSize;  // 0x30
        public HoudiniEngineUnity.HAPI_StorageType storage;  // 0x34
        public System.Int32 tileSize;  // 0x38
        public HoudiniEngineUnity.HAPI_Transform transform;  // 0x40
        public System.Boolean hasTaper;  // 0x68
        public System.Single xTaper;  // 0x6c
        public System.Single yTaper;  // 0x70

    }

    // TypeToken: 0x20000A7  // size: 0x20
    public sealed struct HAPI_VolumeTileInfo
    {
        // Fields
        public System.Int32 minX;  // 0x10
        public System.Int32 minY;  // 0x14
        public System.Int32 minZ;  // 0x18
        public System.Boolean isValid;  // 0x1c

    }

    // TypeToken: 0x20000A8  // size: 0x1C
    public sealed struct HAPI_VolumeVisualInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_VolumeVisualType type;  // 0x10
        public System.Single iso;  // 0x14
        public System.Single density;  // 0x18

    }

    // TypeToken: 0x20000A9  // size: 0x2C
    public sealed struct HAPI_CurveInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_CurveType curveType;  // 0x10
        public System.Int32 curveCount;  // 0x14
        public System.Int32 vertexCount;  // 0x18
        public System.Int32 knotCount;  // 0x1c
        public System.Boolean isPeriodic;  // 0x20
        public System.Boolean isRational;  // 0x21
        public System.Int32 order;  // 0x24
        public System.Boolean hasKnots;  // 0x28
        public System.Boolean isClosed;  // 0x29

    }

    // TypeToken: 0x20000AA  // size: 0x24
    public sealed struct HAPI_InputCurveInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_CurveType curveType;  // 0x10
        public System.Int32 order;  // 0x14
        public System.Boolean closed;  // 0x18
        public System.Boolean reverse;  // 0x19
        public HoudiniEngineUnity.HAPI_InputCurveMethod inputMethod;  // 0x1c
        public HoudiniEngineUnity.HAPI_InputCurveParameterization breakpointParameterization;  // 0x20

        // Methods
        // RVA: 0x08804F58  token: 0x60004E3
        public System.Void FillData(HoudiniEngineUnity.HEU_InputCurveInfo curveInfo) { }

    }

    // TypeToken: 0x20000AB  // size: 0x28
    public sealed struct HAPI_BoxInfo
    {
        // Fields
        public System.Single[] center;  // 0x10
        public System.Single[] size;  // 0x18
        public System.Single[] rotation;  // 0x20

        // Methods
        // RVA: 0x08804EBC  token: 0x60004E4
        public System.Void .ctor(System.Boolean initialize_fields) { }

    }

    // TypeToken: 0x20000AC  // size: 0x20
    public sealed struct HAPI_SphereInfo
    {
        // Fields
        public System.Single[] center;  // 0x10
        public System.Single radius;  // 0x18

        // Methods
        // RVA: 0x08805294  token: 0x60004E5
        public System.Void .ctor(System.Boolean initialize_fields) { }

    }

    // TypeToken: 0x20000AD  // size: 0x2C
    public sealed struct HAPI_PDG_EventInfo
    {
        // Fields
        public System.Int32 nodeId;  // 0x10
        public System.Int32 workItemId;  // 0x14
        public System.Int32 dependencyId;  // 0x18
        public System.Int32 currentState;  // 0x1c
        public System.Int32 lastState;  // 0x20
        public System.Int32 eventType;  // 0x24
        public System.Int32 msgSH;  // 0x28

    }

    // TypeToken: 0x20000AE  // size: 0x1C
    public sealed struct HAPI_PDG_WorkItemInfo
    {
        // Fields
        public System.Int32 index;  // 0x10
        public System.Int32 outputFileCount;  // 0x14
        public System.Int32 nameSH;  // 0x18

    }

    // TypeToken: 0x20000AF  // size: 0x20
    public sealed struct HAPI_PDG_WorkItemOutputFile
    {
        // Fields
        public System.Int32 filePathSH;  // 0x10
        public System.Int32 tagSH;  // 0x14
        public System.Int64 hash;  // 0x18

    }

    // TypeToken: 0x20000B0  // size: 0x28
    public sealed struct HAPI_Viewport
    {
        // Fields
        public System.Single[] position;  // 0x10
        public System.Single[] rotationQuaternion;  // 0x18
        public System.Single offset;  // 0x20

        // Methods
        // RVA: 0x08805650  token: 0x60004E6
        public System.Void .ctor(System.Boolean initializeFields) { }
        // RVA: 0x088055D8  token: 0x60004E7
        public System.Void Init() { }

    }

    // TypeToken: 0x20000B1  // size: 0x12
    public sealed struct HAPI_SessionSyncInfo
    {
        // Fields
        public System.Boolean cookUsingHoudiniTime;  // 0x10
        public System.Boolean syncViewport;  // 0x11

    }

    // TypeToken: 0x20000B2  // size: 0x18
    public sealed struct HAPI_CompositorOptions
    {
        // Fields
        public System.Int32 maximumResolutionX;  // 0x10
        public System.Int32 maximumResolutionY;  // 0x14

    }

    // TypeToken: 0x20000B3  // size: 0x10
    public class HEU_HARCImports
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60004E8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4  // size: 0x10
    public class HEU_HoudiniVersion
    {
        // Fields
        public static System.Int32 HOUDINI_MAJOR;  // const
        public static System.Int32 HOUDINI_MINOR;  // const
        public static System.Int32 HOUDINI_BUILD;  // const
        public static System.Int32 HOUDINI_PATCH;  // const
        public static System.String HOUDINI_VERSION_STRING;  // const
        public static System.Int32 HOUDINI_ENGINE_MAJOR;  // const
        public static System.Int32 HOUDINI_ENGINE_MINOR;  // const
        public static System.Int32 HOUDINI_ENGINE_API;  // const
        public static System.Int32 UNITY_PLUGIN_VERSION;  // const
        public static System.String HAPI_BIN_PATH;  // const
        public static System.String HAPI_LIBRARY;  // const
        public static System.String HARC_LIBRARY;  // const
        public static System.String SIDEFX_SOFTWARE_REGISTRY;  // const

        // Methods
        // RVA: 0x0350B670  token: 0x60004E9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5  // size: 0x10
    public class HTC_APIConstants
    {
        // Fields
        public static System.String HOUDINI_MASTER_SERVER_HOSTNAME;  // const
        public static System.Int32 HOUDINI_MASTER_QUERY_FOR_UNITY_PORT;  // const
        public static System.Int32 TCP_HEADER_SIZE;  // const
        public static System.Int32 MAX_ERROR_INFO_SIZE;  // const

        // Methods
        // RVA: 0x0350B670  token: 0x60004EA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6  // size: 0x10
    public class HTC_VERSION
    {
        // Fields
        public static System.String LIBRARY;  // const

        // Methods
        // RVA: 0x0350B670  token: 0x60004EB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7  // size: 0x10
    public class HoudiniConstsIdentifier
    {
        // Fields
        public static System.String HOUDINI_VERSION;  // const
        public static System.String PROJECT_TAG;  // const

        // Methods
        // RVA: 0x0350B670  token: 0x60004EC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8  // size: 0x10
    public class HTC_APIFunctions
    {
        // Methods
        // RVA: 0x0881E520  token: 0x60004ED
        private static System.Void InitHoudiniTcpClient(System.String address, System.Int32 port, System.Boolean use_ip, System.Text.StringBuilder error_msg) { }
        // RVA: 0x0881E410  token: 0x60004EE
        private static System.Void GetHarsInfo(HoudiniEngineUnity.HarsInfo& harsInfo, System.Text.StringBuilder error_msg) { }
        // RVA: 0x0881E600  token: 0x60004EF
        private static System.Void UninitializeHoudiniTcpClient(System.Text.StringBuilder error_msg) { }
        // RVA: 0x0350B670  token: 0x60004F0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9  // size: 0x20
    public sealed struct HarsInfo
    {
        // Fields
        public System.String hars_address;  // 0x10
        public System.Int32 port;  // 0x18

    }

    // TypeToken: 0x20000BA  // size: 0x20
    public sealed struct GenericMessage
    {
        // Fields
        public System.String protocol;  // 0x10
        public System.Object body;  // 0x18

    }

    // TypeToken: 0x20000BB  // size: 0x10
    public static class Logger
    {
        // Methods
        // RVA: 0x088203F0  token: 0x60004F1
        public static System.Void LogError(System.String msg) { }
        // RVA: 0x08820488  token: 0x60004F2
        public static System.Void LogWarning(System.String msg) { }
        // RVA: 0x0882043C  token: 0x60004F3
        public static System.Void LogInfo(System.String msg) { }

    }

    // TypeToken: 0x20000BC  // size: 0x18
    public class HTC_SessionManager : System.IDisposable
    {
        // Fields
        private System.Boolean disposedValue;  // 0x10
        private static HoudiniEngineUnity.HTC_SessionManager instance_;  // static @ 0x0

        // Properties
        HoudiniEngineUnity.HTC_SessionManager Instance { get; /* RVA: 0x0881F170 */ }

        // Methods
        // RVA: 0x0881E980  token: 0x60004F4
        private System.Void .ctor() { }
        // RVA: 0x0881E84C  token: 0x60004F5
        protected virtual System.Void Finalize() { }
        // RVA: 0x0881E758  token: 0x60004F6
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0881E708  token: 0x60004F7
        public virtual System.Void Dispose() { }
        // RVA: 0x0881E8C0  token: 0x60004F8
        public System.Boolean GetOrRequestAvailableHARSInfo(System.String& harsAddress, System.Int32& harsPort, System.String& errorInfo) { }
        // RVA: 0x0881E6A0  token: 0x60004F9
        public static System.Void Close() { }

    }

    // TypeToken: 0x20000BD  // size: 0x10
    public static class HTC_Utils
    {
        // Fields
        private static readonly System.String CurrentUnityProjectPrefix;  // static @ 0x0

        // Methods
        // RVA: 0x0881F1F4  token: 0x60004FB
        public static System.String GetUnityPathFromSystemPath(System.String systemPath) { }
        // RVA: 0x0881F3FC  token: 0x60004FC
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE  // size: 0x10
    public static class HoudiniExtTools
    {
        // Fields
        private static readonly System.String LOCAL_IP_ADDRESS;  // static @ 0x0
        private static readonly System.String REMOTE_HOUDINI_SMB_PATH_PREFIX;  // static @ 0x8
        private static readonly System.String REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX;  // static @ 0x10
        public static System.String REMOTE_HOUDINI_HDA_SMB_URL;  // const
        public static System.String REMOTE_HOUDINI_SMB_URL;  // const
        public static System.String LINUX_MOUNT_DIR_PREFIX;  // const
        public static System.String PROJECT_TAG;  // const

        // Properties
        System.Int64 DefaultSessionID { get; /* RVA: 0x088203A0 */ }

        // Methods
        // RVA: 0x0881FFE0  token: 0x60004FD
        private static System.Int64 GetSessionID(System.Int64 sessionId) { }
        // RVA: 0x0881FAA8  token: 0x60004FE
        public static System.String GetDefaultDirectoryOnTheSMB() { }
        // RVA: 0x0881FB24  token: 0x60004FF
        public static System.String GetDefaultSessionDirectoryOnTheSMB(System.Int64 sessionId) { }
        // RVA: 0x0881F72C  token: 0x6000500
        public static System.String ConvertLocalDirPathToSessionDirPath(System.String localPath, System.Boolean doMd5, System.Int64 sessionId) { }
        // RVA: 0x0881F634  token: 0x6000501
        public static System.String ConvertLocalDebugFilePathToSessionDebugFilePath(System.String localFilePath, System.Int64 sessionId) { }
        // RVA: 0x0881F85C  token: 0x6000502
        public static System.String ConvertLocalFilePathToSessionFilePath(System.String localFilePath, System.Int64 sessionId) { }
        // RVA: 0x0882002C  token: 0x6000503
        public static System.Boolean IsLocalPath(System.String path) { }
        // RVA: 0x0881FEDC  token: 0x6000504
        public static System.String GetMD5WithString(System.String str) { }
        // RVA: 0x0881FBF0  token: 0x6000505
        public static System.String GetLocalIPv4() { }
        // RVA: 0x0881FBC4  token: 0x6000506
        public static System.String GetHoudiniSMBUrl() { }
        // RVA: 0x0881FA48  token: 0x6000507
        public static System.String GetDefaultCachePath(System.Int64 sessionId) { }
        // RVA: 0x0881FAF8  token: 0x6000508
        public static System.String GetDefaultHdaPath() { }
        // RVA: 0x088202A4  token: 0x600050A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BF  // size: 0x10
    public static class HoudiniExtBridge
    {
        // Methods
        // RVA: 0x0881F4E8  token: 0x600050B
        public static System.Boolean GetParametersFromHDA(System.Byte[] hdaBytes, HoudiniEngineUnity.HEU_Parameters& parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode>& inputNodes) { }
        // RVA: 0x0881F4A8  token: 0x600050C
        public static System.Void AddInputNodeToHoudiniAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_InputNode node) { }
        // RVA: 0x0881F4C4  token: 0x600050D
        public static System.Void Clear(HoudiniEngineUnity.HEU_Parameters parameters) { }

    }

    // TypeToken: 0x20000C0  // size: 0x150
    public sealed class HEU_ParameterData : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.Int32 _unityIndex;  // 0x10
        public System.String _name;  // 0x18
        public System.String _labelName;  // 0x20
        public System.String _help;  // 0x28
        public System.Collections.Generic.List<System.Int32> _childParameterIDs;  // 0x30
        public System.Int32 _choiceValue;  // 0x38
        public System.Int32[] _intValues;  // 0x40
        public System.Single[] _floatValues;  // 0x48
        public System.String[] _stringValues;  // 0x50
        public System.Boolean _toggle;  // 0x58
        public UnityEngine.Color _color;  // 0x5c
        public UnityEngine.Gradient _gradient;  // 0x70
        public UnityEngine.AnimationCurve _animCurve;  // 0x78
        public UnityEngine.GUIContent[] _choiceLabels;  // 0x80
        public System.String[] _choiceStringValues;  // 0x88
        public System.Int32[] _choiceIntValues;  // 0x90
        public HoudiniEngineUnity.HAPI_ParmInfo _parmInfo;  // 0x98
        public System.Boolean _showChildren;  // 0x12c
        public System.String _fileTypeInfo;  // 0x130
        public System.Int32 _folderListChildrenProcessed;  // 0x138
        public System.Int32 _tabSelectedIndex;  // 0x13c
        public HoudiniEngineUnity.HEU_InputNode _paramInputNode;  // 0x140
        public System.Boolean _hasAssetPathTag;  // 0x148

        // Properties
        System.Int32 ParmID { get; /* RVA: 0x03D4EB50 */ }
        System.Int32 ParentID { get; /* RVA: 0x03D51960 */ }
        System.Int32 ChildIndex { get; /* RVA: 0x03D50E50 */ }
        System.Int32 ParmSize { get; /* RVA: 0x03D57DA0 */ }
        System.Int32 IntMin { get; /* RVA: 0x0880BAA4 */ }
        System.Int32 IntMax { get; /* RVA: 0x0880BA94 */ }
        System.Int32 IntUIMin { get; /* RVA: 0x0880BAC4 */ }
        System.Int32 IntUIMax { get; /* RVA: 0x0880BAB4 */ }
        System.Single FloatMin { get; /* RVA: 0x03D598B0 */ }
        System.Single FloatMax { get; /* RVA: 0x03D583B0 */ }
        System.Single FloatUIMin { get; /* RVA: 0x03D574D0 */ }
        System.Single FloatUIMax { get; /* RVA: 0x03D58E00 */ }

        // Methods
        // RVA: 0x0880B948  token: 0x6000512
        public System.Boolean IsInt() { }
        // RVA: 0x0880B930  token: 0x6000513
        public System.Boolean IsFloat() { }
        // RVA: 0x0880B984  token: 0x6000514
        public System.Boolean IsString() { }
        // RVA: 0x0880B954  token: 0x6000515
        public System.Boolean IsPathFile() { }
        // RVA: 0x03D6D690  token: 0x6000516
        public System.Boolean HasMin() { }
        // RVA: 0x03D6D680  token: 0x6000517
        public System.Boolean HasMax() { }
        // RVA: 0x03D6D6B0  token: 0x6000518
        public System.Boolean HasUIMin() { }
        // RVA: 0x03D6D6A0  token: 0x6000519
        public System.Boolean HasUIMax() { }
        // RVA: 0x0880B1A8  token: 0x6000522
        public System.Boolean IsContainer() { }
        // RVA: 0x0589F914  token: 0x6000523
        public System.Boolean IsMultiParam() { }
        // RVA: 0x0880B96C  token: 0x6000524
        public System.Boolean IsRamp() { }
        // RVA: 0x0880B924  token: 0x6000525
        public System.Boolean IsFloatRamp() { }
        // RVA: 0x0880B190  token: 0x6000526
        public System.Boolean IsColorRamp() { }
        // RVA: 0x0880B990  token: 0x6000527
        public System.Boolean IsToggle() { }
        // RVA: 0x0880B19C  token: 0x6000528
        public System.Boolean IsColor() { }
        // RVA: 0x0880B93C  token: 0x6000529
        public System.Boolean IsFolder() { }
        // RVA: 0x0880B184  token: 0x600052A
        public System.Boolean IsButton() { }
        // RVA: 0x0880B99C  token: 0x600052B
        public UnityEngine.Vector3 ToVector3() { }
        // RVA: 0x03D57CB0  token: 0x600052C
        public System.Boolean IsAssetPath() { }
        // RVA: 0x0880B1EC  token: 0x600052D
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterData other) { }
        // RVA: 0x0880BA1C  token: 0x600052E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1  // size: 0x14
    public sealed struct HEU_ModifierActionWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper MULTIPARM_INSERT;  // const
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper MULTIPARM_REMOVE;  // const
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper MULTIPARM_CLEAR;  // const
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper SET_FLOAT;  // const
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper SET_INT;  // const

    }

    // TypeToken: 0x20000C2  // size: 0x28
    public class HEU_ParameterModifier : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.Int32 _parameterIndex;  // 0x10
        private HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction _action;  // 0x14
        private System.Int32 _instanceIndex;  // 0x18
        private System.Int32 _modifierValue;  // 0x1c
        private System.Single _floatValue;  // 0x20
        private System.Int32 _intValue;  // 0x24

        // Properties
        System.Int32 ParameterIndex { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        HoudiniEngineUnity.HEU_ModifierActionWrapper Action { get; /* RVA: 0x0880BDAC */ set; /* RVA: 0x0880BDB8 */ }
        System.Int32 InstanceIndex { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Int32 ModifierValue { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }
        System.Single FloatValue { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x03D4F2F0 */ }
        System.Int32 IntValue { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }

        // Methods
        // RVA: 0x0880BAD4  token: 0x600053B
        public static HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ModifierActionWrapper action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue) { }
        // RVA: 0x0880BB1C  token: 0x600053C
        private static HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue) { }
        // RVA: 0x0880BB90  token: 0x600053D
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterModifier other) { }
        // RVA: 0x0880BD78  token: 0x600053E
        private static HoudiniEngineUnity.HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action) { }
        // RVA: 0x0880BD78  token: 0x600053F
        private static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction ModifierAction_WrapperToInternal(HoudiniEngineUnity.HEU_ModifierActionWrapper action) { }
        // RVA: 0x0350B670  token: 0x6000540
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C4  // size: 0x88
    public class HEU_Parameters : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_Parameters, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private System.Int32 _nodeID;  // 0x18
        private System.String _uiLabel;  // 0x20
        private System.Int32[] _paramInts;  // 0x28
        private System.Single[] _paramFloats;  // 0x30
        private System.String[] _paramStrings;  // 0x38
        private HoudiniEngineUnity.HAPI_ParmChoiceInfo[] _paramChoices;  // 0x40
        private System.Collections.Generic.List<System.Int32> _rootParameters;  // 0x48
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> _parameterList;  // 0x50
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> _parameterModifiers;  // 0x58
        private System.Boolean _regenerateParameters;  // 0x60
        private System.Byte[] _presetData;  // 0x68
        private System.Byte[] _defaultPresetData;  // 0x70
        private System.Boolean _validParameters;  // 0x78
        private System.Boolean _showParameters;  // 0x79
        private System.Boolean _recacheUI;  // 0x7a
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;  // 0x80

        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x03D4EAE0 */ }
        System.Boolean ShowParameters { get; /* RVA: 0x03D51AE0 */ set; /* RVA: 0x03D51B40 */ }
        System.Int32 NodeID { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Collections.Generic.List<System.Int32> RootParameters { get; /* RVA: 0x03D4EA70 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> ParameterModifiers { get; /* RVA: 0x03D4EAA0 */ }
        System.Boolean RequiresRegeneration { get; /* RVA: 0x03D519A0 */ set; /* RVA: 0x03D519B0 */ }
        System.Boolean RecacheUI { get; /* RVA: 0x03D51AF0 */ set; /* RVA: 0x03D51B50 */ }

        // Methods
        // RVA: 0x03D4EAB0  token: 0x600054A
        private System.Byte[] GetPresetData() { }
        // RVA: 0x038C5570  token: 0x600054B
        private System.Void SetPresetData(System.Byte[] data) { }
        // RVA: 0x03D4EB30  token: 0x600054C
        private System.Byte[] GetDefaultPresetData() { }
        // RVA: 0x03D4F800  token: 0x600054F
        public virtual System.Boolean AreParametersValid() { }
        // RVA: 0x0880E844  token: 0x6000550
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x08813BCC  token: 0x6000551
        public virtual System.Void Recook() { }
        // RVA: 0x03D4EAF0  token: 0x6000552
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters() { }
        // RVA: 0x0880E57C  token: 0x6000553
        public virtual HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex) { }
        // RVA: 0x0880E5EC  token: 0x6000554
        public virtual HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name) { }
        // RVA: 0x0880E45C  token: 0x6000555
        public virtual HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID) { }
        // RVA: 0x08813CBC  token: 0x6000556
        public virtual System.Void RemoveParameter(System.Int32 listIndex) { }
        // RVA: 0x0880ECC0  token: 0x6000557
        public virtual System.Boolean HaveParametersChanged() { }
        // RVA: 0x08813ED4  token: 0x6000558
        public virtual System.Boolean ResetAllToDefault(System.Boolean bRecookAsset) { }
        // RVA: 0x08814B68  token: 0x6000559
        public virtual System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: 0x0880CFB8  token: 0x600055A
        public virtual System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex) { }
        // RVA: 0x08814D70  token: 0x600055B
        public virtual System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset) { }
        // RVA: 0x0880D1AC  token: 0x600055C
        public virtual System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values) { }
        // RVA: 0x088145AC  token: 0x600055D
        public virtual System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset) { }
        // RVA: 0x0880C974  token: 0x600055E
        public virtual System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value) { }
        // RVA: 0x08815464  token: 0x600055F
        public virtual System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: 0x0880DB4C  token: 0x6000560
        public virtual System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex) { }
        // RVA: 0x0881566C  token: 0x6000561
        public virtual System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset) { }
        // RVA: 0x0880DD40  token: 0x6000562
        public virtual System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values) { }
        // RVA: 0x088143DC  token: 0x6000563
        public virtual System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset) { }
        // RVA: 0x0880C7CC  token: 0x6000564
        public virtual System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value) { }
        // RVA: 0x088142C0  token: 0x6000565
        public virtual System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: 0x0880C6C0  token: 0x6000566
        public virtual System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex) { }
        // RVA: 0x08815F30  token: 0x6000567
        public virtual System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: 0x0880E8DC  token: 0x6000568
        public virtual System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex) { }
        // RVA: 0x08816144  token: 0x6000569
        public virtual System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset) { }
        // RVA: 0x0880EAF8  token: 0x600056A
        public virtual System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values) { }
        // RVA: 0x08813F1C  token: 0x600056B
        public virtual System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: 0x088140E4  token: 0x600056C
        public virtual System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset) { }
        // RVA: 0x0880C37C  token: 0x600056D
        public virtual System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex) { }
        // RVA: 0x0880C4F4  token: 0x600056E
        public virtual System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values) { }
        // RVA: 0x08815CBC  token: 0x600056F
        public virtual System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset) { }
        // RVA: 0x0880E72C  token: 0x6000570
        public virtual System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints) { }
        // RVA: 0x08814FCC  token: 0x6000571
        public virtual System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset) { }
        // RVA: 0x0880D344  token: 0x6000572
        public virtual System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        // RVA: 0x088152C4  token: 0x6000573
        public virtual System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        // RVA: 0x0880D638  token: 0x6000574
        public virtual System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints) { }
        // RVA: 0x088146D8  token: 0x6000575
        public virtual System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset) { }
        // RVA: 0x0880CA94  token: 0x6000576
        public virtual System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        // RVA: 0x088149BC  token: 0x6000577
        public virtual System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        // RVA: 0x0880CD80  token: 0x6000578
        public virtual System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints) { }
        // RVA: 0x088168D0  token: 0x6000579
        public virtual System.Boolean TriggerButtonParameter(System.String parameterName) { }
        // RVA: 0x088158D0  token: 0x600057A
        public virtual System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecook) { }
        // RVA: 0x0880E078  token: 0x600057B
        public virtual System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples) { }
        // RVA: 0x088112B0  token: 0x600057C
        private System.Boolean Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> previousParamFolders, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> previousParamInputNodes, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        // RVA: 0x0880F16C  token: 0x600057D
        private System.Boolean Initialize4HGTool(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Int32 parentNodeId) { }
        // RVA: 0x088163BC  token: 0x600057E
        private System.Void SetupRampParameter(HoudiniEngineUnity.HEU_ParameterData rampParameter) { }
        // RVA: 0x08816CB0  token: 0x600057F
        private System.Boolean UploadValuesToHoudini(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bDoCheck, System.Boolean bForceUploadInputs) { }
        // RVA: 0x08813428  token: 0x6000580
        private System.Void InsertInstanceToMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToAdd) { }
        // RVA: 0x08813C34  token: 0x6000581
        private System.Void RemoveInstancesFromMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToRemove) { }
        // RVA: 0x0880C274  token: 0x6000582
        private System.Void ClearInstancesFromMultiParm(System.Int32 unityParamIndex) { }
        // RVA: 0x0880EC7C  token: 0x6000583
        private System.Boolean HasModifiersPending() { }
        // RVA: 0x08813768  token: 0x6000584
        private System.Void ProcessModifiers(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0880DEDC  token: 0x6000585
        private System.Void GetParameterDataForUIRestore(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> folderParams, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> inputNodeParams) { }
        // RVA: 0x0880D86C  token: 0x6000586
        private System.Void GetInputNodeConnectionObjects(System.Collections.Generic.List<UnityEngine.GameObject> inputNodeObjects) { }
        // RVA: 0x0880C330  token: 0x6000587
        private System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08816C88  token: 0x6000588
        private System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0880C2E4  token: 0x6000589
        private System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08816A9C  token: 0x600058A
        private System.Void UploadParameterInputs(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bForceUpdate) { }
        // RVA: 0x08816A0C  token: 0x600058B
        private System.Void UpdateTransformParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_TransformEuler& HAPITransform) { }
        // RVA: 0x088168A0  token: 0x600058C
        private System.Void SyncParameterFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.String parameterName) { }
        // RVA: 0x088167C8  token: 0x600058D
        private System.Void SyncInternalParametersForUndoCompare(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0880BDD8  token: 0x600058E
        private System.Void CleanUp() { }
        // RVA: 0x08813D28  token: 0x600058F
        private System.Void ResetAllToDefault(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x088134B0  token: 0x6000590
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Parameters other) { }
        // RVA: 0x08816DB4  token: 0x6000591
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7  // size: 0x10
    public static class HEU_ParameterUtility
    {
        // Methods
        // RVA: 0x0882BEFC  token: 0x6000596
        public static System.Boolean GetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean& outValue) { }
        // RVA: 0x0882C528  token: 0x6000597
        public static System.Boolean SetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean setValue) { }
        // RVA: 0x0882BAF0  token: 0x6000598
        public static System.Boolean GetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue) { }
        // RVA: 0x0882C3A0  token: 0x6000599
        public static System.Boolean SetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue) { }
        // RVA: 0x0882B89C  token: 0x600059A
        public static System.Boolean GetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single& outValue) { }
        // RVA: 0x0882B960  token: 0x600059B
        public static System.Boolean GetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[]& outValues) { }
        // RVA: 0x0882C14C  token: 0x600059C
        public static System.Boolean SetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single setValue) { }
        // RVA: 0x0882C210  token: 0x600059D
        public static System.Boolean SetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[] setValues) { }
        // RVA: 0x0882BE30  token: 0x600059E
        public static System.Boolean GetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String& outValue) { }
        // RVA: 0x0882C464  token: 0x600059F
        public static System.Boolean SetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String setValue) { }
        // RVA: 0x0882BFC0  token: 0x60005A0
        public static System.Boolean SetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue) { }
        // RVA: 0x0882B714  token: 0x60005A1
        public static System.Boolean GetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue) { }
        // RVA: 0x0882C2D0  token: 0x60005A2
        public static System.Boolean SetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.GameObject obj, System.Int32 index) { }
        // RVA: 0x0882BA24  token: 0x60005A3
        public static System.Boolean GetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 index, UnityEngine.GameObject& obj) { }
        // RVA: 0x0882B7D0  token: 0x60005A4
        public static System.Boolean GetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color& getValue) { }
        // RVA: 0x0882C080  token: 0x60005A5
        public static System.Boolean SetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color setValue) { }
        // RVA: 0x0882BD74  token: 0x60005A6
        public static System.Int32 GetParameterIndexFromName(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName) { }
        // RVA: 0x0882BD40  token: 0x60005A7
        public static System.Int32 GetParameterIndexFromNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName) { }
        // RVA: 0x0882B628  token: 0x60005A8
        public static System.Int32 FindTextureParamByNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.String useTextureParmName) { }
        // RVA: 0x0882BC94  token: 0x60005A9
        public static System.Boolean GetParameterFloatValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.Single defaultValue, System.Single& returnValue) { }
        // RVA: 0x0882BBB4  token: 0x60005AA
        public static System.Boolean GetParameterColor3Value(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, UnityEngine.Color defaultValue, UnityEngine.Color& outputColor) { }

    }

    // TypeToken: 0x20000C8  // size: 0x30
    public class HEU_PDGCookedDataEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x0882AD88  token: 0x60005AB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9  // size: 0x20
    public class HEU_PDGCookedEventData
    {
        // Fields
        public System.Boolean CookSuccess;  // 0x10
        public HoudiniEngineUnity.HEU_TOPNodeData TopNodeData;  // 0x18

        // Methods
        // RVA: 0x02F73D00  token: 0x60005AC
        public System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_TOPNodeData bTopNodeData) { }

    }

    // TypeToken: 0x20000CA  // size: 0xA8
    public class HEU_PDGAssetLink : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private HoudiniEngineUnity.HEU_PDGCookedDataEvent _cookedDataEvent;  // 0x18
        private System.String _assetPath;  // 0x20
        private UnityEngine.GameObject _assetGO;  // 0x28
        private System.String _assetName;  // 0x30
        private System.Int32 _assetID;  // 0x38
        private HoudiniEngineUnity.HEU_HoudiniAsset _heu;  // 0x40
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> _topNetworks;  // 0x48
        private System.String[] _topNetworkNames;  // 0x50
        private System.Int32 _selectedTOPNetwork;  // 0x58
        private HoudiniEngineUnity.HEU_PDGAssetLink.LinkState _linkState;  // 0x5c
        private System.Boolean _autoCook;  // 0x60
        private System.Boolean _useHEngineData;  // 0x61
        public HoudiniEngineUnity.HEU_PDGAssetLink.UpdateUIDelegate _repaintUIDelegate;  // 0x68
        public HoudiniEngineUnity.HEU_WorkItemTally _workItemTally;  // 0x70
        private UnityEngine.GameObject _loadRootGameObject;  // 0x78
        private System.String _outputCachePathRoot;  // 0x80
        private System.Boolean _bUseTOPNodeFilter;  // 0x88
        private System.Boolean _bUseTOPOutputFilter;  // 0x89
        private System.String _topNodeFilter;  // 0x90
        private System.String _topOutputFilter;  // 0x98
        private System.Int32 _numLoadingResults;  // 0xa0
        private System.Int32 _numTotalResults;  // 0xa4

        // Properties
        System.Boolean AutoCook { get; /* RVA: 0x03D519A0 */ set; /* RVA: 0x03D519B0 */ }
        System.Boolean UseHEngineData { get; /* RVA: 0x03D51F90 */ set; /* RVA: 0x03D5B410 */ }
        System.Boolean UseTOPNodeFilter { get; /* RVA: 0x03D51D50 */ set; /* RVA: 0x03D56D40 */ }
        System.Boolean UseTOPOutputFilter { get; /* RVA: 0x03D51D10 */ set; /* RVA: 0x03D5B370 */ }
        System.String TopNodeFilter { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x051DFCB4 */ }
        System.String TopOutputFilter { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x051417AC */ }
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x03D4E2B0 */ }
        System.String AssetPath { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.GameObject AssetGO { get; /* RVA: 0x03D4EAC0 */ }
        System.String AssetName { get; /* RVA: 0x01003830 */ }
        System.Int32 AssetID { get; /* RVA: 0x03D4EC30 */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> TopNetworks { get; /* RVA: 0x03D4EA70 */ }
        System.String[] TopNetworkNames { get; /* RVA: 0x03D4EAF0 */ }
        System.Int32 SelectedTOPNetwork { get; /* RVA: 0x03D4EF00 */ }
        HoudiniEngineUnity.HEU_LinkStateWrapper PDGLinkState { get; /* RVA: 0x0882AD5C */ }
        UnityEngine.GameObject LoadRootGameObject { get; /* RVA: 0x03D4EB20 */ }
        System.String OutputCachePathRoot { get; /* RVA: 0x03D4EAE0 */ }
        HoudiniEngineUnity.HEU_PDGCookedDataEvent CookedDataEvent { get; /* RVA: 0x01041090 */ }
        HoudiniEngineUnity.HEU_PDGAssetLink.LinkState AssetLinkStateInternal { get; /* RVA: 0x03D4EEF0 */ }

        // Methods
        // RVA: 0x0882A6A4  token: 0x60005C6
        public System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset) { }
        // RVA: 0x0882A500  token: 0x60005C7
        public System.Void Reset() { }
        // RVA: 0x0882A1B0  token: 0x60005C8
        public System.Void Refresh() { }
        // RVA: 0x0882868C  token: 0x60005C9
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: 0x0882A508  token: 0x60005CA
        public System.Void SelectTOPNetwork(System.Int32 newIndex) { }
        // RVA: 0x0882A55C  token: 0x60005CB
        public System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex) { }
        // RVA: 0x088287D8  token: 0x60005CC
        public HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork() { }
        // RVA: 0x088287E4  token: 0x60005CD
        public HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode() { }
        // RVA: 0x08828908  token: 0x60005CE
        public HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index) { }
        // RVA: 0x08828380  token: 0x60005CF
        public System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x08828380  token: 0x60005D0
        public System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x08828558  token: 0x60005D1
        public System.Void DirtyAll() { }
        // RVA: 0x0882833C  token: 0x60005D2
        public System.Void CookOutput() { }
        // RVA: 0x08827DBC  token: 0x60005D3
        public System.Void PauseCook() { }
        // RVA: 0x08827DBC  token: 0x60005D4
        public System.Void CancelCook() { }
        // RVA: 0x08828578  token: 0x60005D5
        public HoudiniEngineUnity.HEU_SessionBase GetHAPISession() { }
        // RVA: 0x08828AF0  token: 0x60005D6
        public HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID) { }
        // RVA: 0x08828A20  token: 0x60005D7
        public System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x08828860  token: 0x60005D8
        public static HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetworkByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> topNetworks) { }
        // RVA: 0x08828978  token: 0x60005D9
        public static HoudiniEngineUnity.HEU_TOPNodeData GetTOPNodeByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData> topNodes) { }
        // RVA: 0x0350B670  token: 0x60005DA
        private System.Void Awake() { }
        // RVA: 0x0350B670  token: 0x60005DB
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: 0x0350B670  token: 0x60005DC
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x0350B670  token: 0x60005DD
        private System.Void HandleInitialLoad() { }
        // RVA: 0x08829574  token: 0x60005DE
        private System.Void OnDestroy() { }
        // RVA: 0x0882953C  token: 0x60005DF
        private System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> generatedOutputs) { }
        // RVA: 0x08829514  token: 0x60005E0
        private System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_CookedEventData cookedEventData) { }
        // RVA: 0x08829514  token: 0x60005E1
        private System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData) { }
        // RVA: 0x08829D18  token: 0x60005E2
        private System.Void PopulateFromHDA() { }
        // RVA: 0x08829E60  token: 0x60005E3
        public System.Boolean PopulateTOPNetworks() { }
        // RVA: 0x0882A038  token: 0x60005E4
        private System.Boolean PopulateTOPNodes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Int32[] topNodeIDs, System.Boolean useHEngineData) { }
        // RVA: 0x08827DCC  token: 0x60005E5
        private System.Void ClearAllTOPData() { }
        // RVA: 0x08828098  token: 0x60005E6
        private static System.Void ClearTOPNetworkWorkItemResults(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: 0x088281AC  token: 0x60005E7
        private static System.Void ClearTOPNodeWorkItemResults(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x088282A8  token: 0x60005E8
        private static System.Void ClearWorkItemResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID) { }
        // RVA: 0x088282CC  token: 0x60005E9
        private static System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result) { }
        // RVA: 0x0882A834  token: 0x60005EA
        private System.Void UpdateTOPNodeResultsVisibility(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x08828C54  token: 0x60005EB
        private static HoudiniEngineUnity.HEU_TOPWorkResult GetWorkResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID) { }
        // RVA: 0x088283A8  token: 0x60005EC
        private static System.Void DestroyWorkItemResultData(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result) { }
        // RVA: 0x08828DA0  token: 0x60005ED
        private System.Void LoadResults(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HAPI_PDG_WorkItemInfo workItemInfo, HoudiniEngineUnity.HAPI_PDG_WorkItemOutputFile[] resultInfos, System.Int32 workItemID, System.Action<HoudiniEngineUnity.HEU_TOPNodeData,HoudiniEngineUnity.HEU_SyncedEventData> OnSynced) { }
        // RVA: 0x088285EC  token: 0x60005EE
        private UnityEngine.Transform GetLoadRootTransform() { }
        // RVA: 0x0882A43C  token: 0x60005EF
        public System.Void RepaintUI() { }
        // RVA: 0x0882A8A8  token: 0x60005F0
        public System.Void UpdateWorkItemTally() { }
        // RVA: 0x0882A454  token: 0x60005F1
        private System.Void ResetTOPNetworkWorkItemTally(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: 0x088295DC  token: 0x60005F2
        private System.Void OnTOPNodeFilterChanged(System.String filter) { }
        // RVA: 0x08829958  token: 0x60005F3
        private System.Void OnTOPOutputFilterChanged(System.String filter) { }
        // RVA: 0x08829CB8  token: 0x60005F4
        private static System.Void ParseHEngineData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 topNodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.TOPNodeTags& nodeTags) { }
        // RVA: 0x0882A5B4  token: 0x60005F5
        private System.Void SetupTopNetworkNames(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: 0x08829584  token: 0x60005F6
        private System.Void OnSyncComplete(HoudiniEngineUnity.HEU_PDGCookedEventData Data) { }
        // RVA: 0x087DF02C  token: 0x60005F7
        private static HoudiniEngineUnity.HEU_LinkStateWrapper LinkState_InternalToWrapper(HoudiniEngineUnity.HEU_PDGAssetLink.LinkState linkState) { }
        // RVA: 0x087DF02C  token: 0x60005F8
        private static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LinkState_WrapperToInternal(HoudiniEngineUnity.HEU_LinkStateWrapper linkState) { }
        // RVA: 0x0882AC4C  token: 0x60005F9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF  // size: 0x18
    public class TOPNodeTags
    {
        // Fields
        public System.Boolean _show;  // 0x10
        public System.Boolean _autoload;  // 0x11
        public System.Boolean _showHEngineData;  // 0x12
        public System.Boolean _autoloadHEngineData;  // 0x13

        // Methods
        // RVA: 0x0350B670  token: 0x6000601
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0  // size: 0x48
    public class HEU_TOPNetworkData
    {
        // Fields
        public System.Int32 _nodeID;  // 0x10
        public System.String _nodeName;  // 0x18
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData> _topNodes;  // 0x20
        public System.String[] _topNodeNames;  // 0x28
        public System.Int32 _selectedTOPIndex;  // 0x30
        public System.String _parentName;  // 0x38
        public HoudiniEngineUnity.TOPNodeTags _tags;  // 0x40

        // Methods
        // RVA: 0x0882EE44  token: 0x6000602
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1  // size: 0x50
    public class HEU_TOPNodeData
    {
        // Fields
        public System.Int32 _nodeID;  // 0x10
        public System.String _nodeName;  // 0x18
        public System.String _parentName;  // 0x20
        public UnityEngine.GameObject _workResultParentGO;  // 0x28
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPWorkResult> _workResults;  // 0x30
        public HoudiniEngineUnity.TOPNodeTags _tags;  // 0x38
        public System.Boolean _showResults;  // 0x40
        public HoudiniEngineUnity.HEU_TOPNodeData.PDGState _pdgState;  // 0x44
        public HoudiniEngineUnity.HEU_WorkItemTally _workItemTally;  // 0x48

        // Methods
        // RVA: 0x0882EF6C  token: 0x6000603
        public System.Void Reset() { }
        // RVA: 0x0882EF4C  token: 0x6000604
        public System.Boolean AreAllWorkItemsComplete() { }
        // RVA: 0x0882EF0C  token: 0x6000605
        public System.Boolean AnyWorkItemsFailed() { }
        // RVA: 0x0882EF2C  token: 0x6000606
        public System.Boolean AnyWorkItemsPending() { }
        // RVA: 0x0882EF98  token: 0x6000607
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3  // size: 0x20
    public class HEU_TOPWorkResult
    {
        // Fields
        public System.Int32 _workItemIndex;  // 0x10
        public System.Int32 _workItemID;  // 0x14
        public System.Collections.Generic.List<UnityEngine.GameObject> _generatedGOs;  // 0x18

        // Methods
        // RVA: 0x0882F068  token: 0x6000608
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4  // size: 0x28
    public class HEU_WorkItemTally
    {
        // Fields
        public System.Int32 _totalWorkItems;  // 0x10
        public System.Int32 _waitingWorkItems;  // 0x14
        public System.Int32 _scheduledWorkItems;  // 0x18
        public System.Int32 _cookingWorkItems;  // 0x1c
        public System.Int32 _cookedWorkItems;  // 0x20
        public System.Int32 _erroredWorkItems;  // 0x24

        // Methods
        // RVA: 0x03D6D890  token: 0x6000609
        public System.Void ZeroAll() { }
        // RVA: 0x0882F79C  token: 0x600060A
        public System.Boolean AreAllWorkItemsComplete() { }
        // RVA: 0x0882F778  token: 0x600060B
        public System.Boolean AnyWorkItemsFailed() { }
        // RVA: 0x0882F780  token: 0x600060C
        public System.Boolean AnyWorkItemsPending() { }
        // RVA: 0x0882F7BC  token: 0x600060D
        public System.String ProgressRatio() { }
        // RVA: 0x0350B670  token: 0x600060E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5  // size: 0x70
    public class HEU_PDGSession
    {
        // Fields
        private static HoudiniEngineUnity.HEU_PDGSession _pdgSession;  // static @ 0x0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PDGAssetLink> _pdgAssets;  // 0x10
        public System.Int32 _pdgMaxProcessEvents;  // 0x18
        public HoudiniEngineUnity.HAPI_PDG_EventInfo[] _pdgQueryEvents;  // 0x20
        public System.Int32[] _pdgContextIDs;  // 0x28
        public System.Boolean _errored;  // 0x30
        public System.String _errorMsg;  // 0x38
        public HoudiniEngineUnity.HAPI_PDG_State _pdgState;  // 0x40
        private System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> _cookedDataEvent;  // 0x48
        private System.Boolean _pendingCallback;  // 0x50
        private System.Int32 _numItemsCompleted;  // 0x54
        private System.Int32 _totalNumItems;  // 0x58
        private System.Boolean _callbackSuccess;  // 0x5c
        private System.Text.StringBuilder _pdgEventMessages;  // 0x60
        private System.String[] _eventMessageColorCode;  // 0x68

        // Properties
        System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> CookedDataEvent { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }

        // Methods
        // RVA: 0x0882B0D0  token: 0x600060F
        public static HoudiniEngineUnity.HEU_PDGSession GetPDGSession() { }
        // RVA: 0x0882B4D8  token: 0x6000610
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x6000611
        public System.Void AddAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset) { }
        // RVA: 0x0350B670  token: 0x6000612
        public System.Void RemoveAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset) { }
        // RVA: 0x0350B670  token: 0x6000613
        private System.Void Update() { }
        // RVA: 0x0882AE98  token: 0x6000614
        private System.Void CleanUp() { }
        // RVA: 0x0350B670  token: 0x6000615
        private System.Void UpdatePDGContext() { }
        // RVA: 0x0350B670  token: 0x6000616
        public System.Void ReinitializePDGContext() { }
        // RVA: 0x0350B670  token: 0x6000617
        private System.Void ProcessPDGEvent(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo) { }
        // RVA: 0x0882B428  token: 0x6000618
        private System.Void OnWorkItemLoadResults(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_SyncedEventData OnSynced) { }
        // RVA: 0x0882ADE4  token: 0x6000619
        private System.Void CheckCallback(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x0882B160  token: 0x600061A
        private System.Boolean GetTOPAssetLinkAndNode(System.Int32 nodeID, HoudiniEngineUnity.HEU_PDGAssetLink& assetLink, HoudiniEngineUnity.HEU_TOPNodeData& topNode) { }
        // RVA: 0x0882B47C  token: 0x600061B
        private System.Void SetTOPNodePDGState(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPNodeData.PDGState pdgState) { }
        // RVA: 0x0882B328  token: 0x600061C
        private System.Void NotifyTOPNodePDGStateClear(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x0882B3A8  token: 0x600061D
        private System.Void NotifyTOPNodeTotalWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        // RVA: 0x0882B280  token: 0x600061E
        private System.Void NotifyTOPNodeCookedWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x0882B2F4  token: 0x600061F
        private System.Void NotifyTOPNodeErrorWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x0882B3E8  token: 0x6000620
        private System.Void NotifyTOPNodeWaitingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        // RVA: 0x0882B368  token: 0x6000621
        private System.Void NotifyTOPNodeScheduledWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        // RVA: 0x0882B2B4  token: 0x6000622
        private System.Void NotifyTOPNodeCookingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        // RVA: 0x03D6D710  token: 0x6000623
        private static System.Void ResetPDGEventInfo(HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo) { }
        // RVA: 0x0882B434  token: 0x6000624
        private System.Void SetErrorState(System.String msg, System.Boolean bLogIt) { }
        // RVA: 0x0882AF60  token: 0x6000625
        private System.Void ClearErrorState() { }
        // RVA: 0x0882AFEC  token: 0x6000626
        public HoudiniEngineUnity.HEU_SessionBase GetHAPIPDGSession(System.Boolean bCreate) { }
        // RVA: 0x0350B670  token: 0x6000627
        public System.Void CookTOPNetworkOutputNode(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> OnCook) { }
        // RVA: 0x0350B670  token: 0x6000628
        public System.Void PauseCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: 0x0350B670  token: 0x6000629
        public System.Void CancelCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: 0x0350B670  token: 0x600062A
        public System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo eventInfo, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: 0x0115F4C0  token: 0x600062B
        public System.Boolean DirtyTOPNode(System.Int32 nodeID) { }
        // RVA: 0x0115F4C0  token: 0x600062C
        public System.Boolean CookTOPNode(System.Int32 nodeID) { }
        // RVA: 0x0115F4C0  token: 0x600062D
        public System.Boolean DirtyAll(System.Int32 nodeID) { }
        // RVA: 0x0882ADC4  token: 0x600062E
        public System.Void AddEventMessage(System.String msg) { }
        // RVA: 0x0882AFC8  token: 0x600062F
        public System.String GetEventMessages() { }
        // RVA: 0x0882AFA4  token: 0x6000630
        public System.Void ClearEventMessages() { }
        // RVA: 0x0882B03C  token: 0x6000631
        public static System.Int32[] GetNonBypassedNetworkIds(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId) { }
        // RVA: 0x0882B264  token: 0x6000632
        public static System.Boolean IsPDGAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId) { }
        // RVA: 0x03D6D700  token: 0x6000633
        private System.Void ResetCallbackVariables() { }

    }

    // TypeToken: 0x20000D9
    public interface IHEU_Curve
    {
        // Properties
        UnityEngine.GameObject TargetGameObject { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Int32 GeoID { get; /* RVA: -1  // abstract */ }
        System.Int32 PartID { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> CurveNodeData { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_Parameters Parameters { get; /* RVA: -1  // abstract */ }
        System.String CurveName { get; /* RVA: -1  // abstract */ }
        System.Boolean IsInputCurve { get; /* RVA: -1  // abstract */ }
        System.Boolean IsPartCurve { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputCurveInfo InputCurveInfo { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000646
        public virtual System.Boolean IsEditable() { }
        // RVA: -1  // abstract  token: 0x6000647
        public virtual System.Boolean IsGeoCurve() { }
        // RVA: -1  // abstract  token: 0x6000648
        public virtual System.Void SetCurveName(System.String name) { }
        // RVA: -1  // abstract  token: 0x6000649
        public virtual System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600064A
        public virtual System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600064B
        public virtual System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600064C
        public virtual UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex) { }
        // RVA: -1  // abstract  token: 0x600064D
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms() { }
        // RVA: -1  // abstract  token: 0x600064E
        public virtual System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints() { }
        // RVA: -1  // abstract  token: 0x600064F
        public virtual System.Int32 GetNumPoints() { }
        // RVA: -1  // abstract  token: 0x6000650
        public virtual System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000651
        public virtual System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000652
        public virtual System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000653
        public virtual System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000654
        public virtual System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000655
        public virtual System.Void ClearCurveNodeData(System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000656
        public virtual System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000657
        public virtual System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000658
        public virtual UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex) { }
        // RVA: -1  // abstract  token: 0x6000659
        public virtual System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints() { }
        // RVA: -1  // abstract  token: 0x600065A
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData() { }

    }

    // TypeToken: 0x20000DA
    public interface IHEU_GeoNode
    {
        // Properties
        System.Int32 GeoID { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_GeoInfo GeoInfo { get; /* RVA: -1  // abstract */ }
        System.String GeoName { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_GeoType GeoType { get; /* RVA: -1  // abstract */ }
        System.Boolean Editable { get; /* RVA: -1  // abstract */ }
        System.Boolean Displayable { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> Parts { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_ObjectNode ObjectNode { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputNode InputNode { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_Curve GeoCurve { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> VolumeCaches { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000666
        public virtual System.Boolean IsVisible() { }
        // RVA: -1  // abstract  token: 0x6000667
        public virtual System.Boolean IsIntermediate() { }
        // RVA: -1  // abstract  token: 0x6000668
        public virtual System.Boolean IsIntermediateOrEditable() { }
        // RVA: -1  // abstract  token: 0x6000669
        public virtual System.Boolean IsGeoInputType() { }
        // RVA: -1  // abstract  token: 0x600066A
        public virtual System.Boolean IsGeoCurveType() { }
        // RVA: -1  // abstract  token: 0x600066B
        public virtual System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        // RVA: -1  // abstract  token: 0x600066C
        public virtual System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part) { }
        // RVA: -1  // abstract  token: 0x600066D
        public virtual System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: -1  // abstract  token: 0x600066E
        public virtual System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: -1  // abstract  token: 0x600066F
        public virtual HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: -1  // abstract  token: 0x6000670
        public virtual HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID) { }
        // RVA: -1  // abstract  token: 0x6000671
        public virtual System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        // RVA: -1  // abstract  token: 0x6000672
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts() { }
        // RVA: -1  // abstract  token: 0x6000673
        public virtual System.Void HideAllGeometry() { }
        // RVA: -1  // abstract  token: 0x6000674
        public virtual System.Void DisableAllColliders() { }
        // RVA: -1  // abstract  token: 0x6000675
        public virtual HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex) { }

    }

    // TypeToken: 0x20000DB  // size: 0x14
    public sealed struct HEU_AssetCookStatusWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper NONE;  // const
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper COOKING;  // const
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper POSTCOOK;  // const
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper LOADING;  // const
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper POSTLOAD;  // const
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper PRELOAD;  // const
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper SELECT_SUBASSET;  // const

    }

    // TypeToken: 0x20000DC  // size: 0x14
    public sealed struct HEU_AssetCookResultWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AssetCookResultWrapper NONE;  // const
        public static HoudiniEngineUnity.HEU_AssetCookResultWrapper SUCCESS;  // const
        public static HoudiniEngineUnity.HEU_AssetCookResultWrapper ERRORED;  // const

    }

    // TypeToken: 0x20000DD  // size: 0x14
    public sealed struct HEU_CurveDrawCollisionWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper INVALID;  // const
        public static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper COLLIDERS;  // const
        public static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper LAYERMASK;  // const

    }

    // TypeToken: 0x20000DE  // size: 0x14
    public sealed struct HEU_AssetTypeWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_INVALID;  // const
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_HDA;  // const
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_CURVE;  // const
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_INPUT;  // const

    }

    // TypeToken: 0x20000DF
    public interface IHEU_HoudiniAsset
    {
        // Properties
        System.Boolean LoadAssetFromMemory { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean AlwaysOverwriteOnLoad { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean GenerateUVs { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean GenerateTangents { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean GenerateNormals { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean PushTransformToHoudini { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean TransformChangeTriggersCooks { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean CookingTriggersDownCooks { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean AutoCookOnParameterChange { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean IgnoreNonDisplayNodes { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean UseOutputNodes { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean GenerateMeshUsingPoints { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean UseLODGroups { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean SplitGeosByGroup { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean SessionSyncAutoCook { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean BakeUpdateKeepPreviousTransformValues { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean PauseCooking { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean CurveEditorEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper CurveDrawCollision { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        UnityEngine.LayerMask CurveDrawLayerMask { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Single CurveProjectMaxDistance { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        UnityEngine.Vector3 CurveProjectDirection { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean CurveProjectDirectionToView { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean CurveDisableScaleRotation { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean CurveFrameSelectedNodes { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Single CurveFrameSelectedNodeDistance { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean HandlesEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean EditableNodesToolsEnabled { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_AssetTypeWrapper AssetType { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_AssetInfo AssetInfo { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_NodeInfo NodeInfo { get; /* RVA: -1  // abstract */ }
        System.String AssetName { get; /* RVA: -1  // abstract */ }
        System.String AssetOpName { get; /* RVA: -1  // abstract */ }
        System.String AssetHelp { get; /* RVA: -1  // abstract */ }
        System.Int32 AssetID { get; /* RVA: -1  // abstract */ }
        System.String AssetPath { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject OwnerGameObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject RootGameObject { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> MaterialCache { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_Parameters Parameters { get; /* RVA: -1  // abstract */ }
        System.String AssetCacheFolder { get; /* RVA: -1  // abstract */ }
        System.String[] SubassetNames { get; /* RVA: -1  // abstract */ }
        System.Int32 SelectedSubassetIndex { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_AssetCookStatusWrapper CookStatus { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_AssetCookResultWrapper LastCookResult { get; /* RVA: -1  // abstract */ }
        System.Int64 SessionID { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> Curves { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> InputNodes { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> VolumeCaches { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_ReloadDataEvent ReloadDataEvent { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_CookedDataEvent CookedDataEvent { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_BakedDataEvent BakedDataEvent { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_PreAssetEvent PreAssetEvent { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60006C7
        public virtual System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters) { }
        // RVA: -1  // abstract  token: 0x60006C8
        public virtual System.Boolean RequestReload(System.Boolean bAsync) { }
        // RVA: -1  // abstract  token: 0x60006C9
        public virtual System.Boolean RequestResetParameters(System.Boolean bAsync) { }
        // RVA: -1  // abstract  token: 0x60006CA
        public virtual UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject) { }
        // RVA: -1  // abstract  token: 0x60006CB
        public virtual System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild) { }
        // RVA: -1  // abstract  token: 0x60006CC
        public virtual UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath) { }
        // RVA: -1  // abstract  token: 0x60006CD
        public virtual UnityEngine.GameObject BakeToNewStandalone() { }
        // RVA: -1  // abstract  token: 0x60006CE
        public virtual System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO) { }
        // RVA: -1  // abstract  token: 0x60006CF
        public virtual System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO) { }
        // RVA: -1  // abstract  token: 0x60006D0
        public virtual System.Boolean IsAssetValid() { }
        // RVA: -1  // abstract  token: 0x60006D1
        public virtual System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: -1  // abstract  token: 0x60006D2
        public virtual System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: -1  // abstract  token: 0x60006D3
        public virtual HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName) { }
        // RVA: -1  // abstract  token: 0x60006D4
        public virtual System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider) { }
        // RVA: -1  // abstract  token: 0x60006D5
        public virtual System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider) { }
        // RVA: -1  // abstract  token: 0x60006D6
        public virtual System.Boolean ClearCurveDrawColliders() { }
        // RVA: -1  // abstract  token: 0x60006D7
        public virtual HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName) { }
        // RVA: -1  // abstract  token: 0x60006D8
        public virtual HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName) { }
        // RVA: -1  // abstract  token: 0x60006D9
        public virtual HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x60006DA
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes() { }
        // RVA: -1  // abstract  token: 0x60006DB
        public virtual System.Int32 GetVolumeCacheCount() { }
        // RVA: -1  // abstract  token: 0x60006DC
        public virtual HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid) { }
        // RVA: -1  // abstract  token: 0x60006DD
        public virtual HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName) { }
        // RVA: -1  // abstract  token: 0x60006DE
        public virtual System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes) { }
        // RVA: -1  // abstract  token: 0x60006DF
        public virtual HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: -1  // abstract  token: 0x60006E0
        public virtual System.Void ResetParametersToDefault() { }
        // RVA: -1  // abstract  token: 0x60006E1
        public virtual System.Void HideAllGeometry() { }
        // RVA: -1  // abstract  token: 0x60006E2
        public virtual System.Void DisableAllColliders() { }
        // RVA: -1  // abstract  token: 0x60006E3
        public virtual HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material) { }
        // RVA: -1  // abstract  token: 0x60006E4
        public virtual System.Void ClearMaterialCache() { }
        // RVA: -1  // abstract  token: 0x60006E5
        public virtual System.Void RemoveMaterial(UnityEngine.Material material) { }
        // RVA: -1  // abstract  token: 0x60006E6
        public virtual System.Void ResetMaterialOverrides() { }
        // RVA: -1  // abstract  token: 0x60006E7
        public virtual HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset() { }
        // RVA: -1  // abstract  token: 0x60006E8
        public virtual HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink() { }

    }

    // TypeToken: 0x20000E0
    public interface IHEU_HoudiniAssetSubcomponent
    {
        // Properties
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60006EA
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: -1  // abstract  token: 0x60006EB
        public virtual System.Void Recook() { }

    }

    // TypeToken: 0x20000E1  // size: 0x14
    public sealed struct HEU_InputNodeTypeWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputNodeTypeWrapper CONNECTION;  // const
        public static HoudiniEngineUnity.HEU_InputNodeTypeWrapper NODE;  // const
        public static HoudiniEngineUnity.HEU_InputNodeTypeWrapper PARAMETER;  // const

    }

    // TypeToken: 0x20000E2  // size: 0x14
    public sealed struct HEU_InputObjectTypeWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper HDA;  // const
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper UNITY_MESH;  // const
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper CURVE;  // const
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper TERRAIN;  // const
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper BOUNDING_BOX;  // const
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper TILEMAP;  // const

    }

    // TypeToken: 0x20000E3
    public interface IHEU_InputNode
    {
        // Properties
        System.Boolean KeepWorldTransform { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean PackGeometryBeforeMerging { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputNodeTypeWrapper NodeType { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputObjectTypeWrapper ObjectType { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputObjectTypeWrapper PendingObjectType { get; /* RVA: -1  // abstract */ }
        System.Int32 InputNodeID { get; /* RVA: -1  // abstract */ }
        System.String InputName { get; /* RVA: -1  // abstract */ }
        System.String LabelName { get; /* RVA: -1  // abstract */ }
        System.String ParamName { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputInterfaceMeshSettings MeshSettings { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings TilemapSettings { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60006F9
        public virtual System.Boolean IsAssetInput() { }
        // RVA: -1  // abstract  token: 0x60006FA
        public virtual System.Int32 NumInputEntries() { }
        // RVA: -1  // abstract  token: 0x60006FB
        public virtual UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x60006FC
        public virtual UnityEngine.GameObject[] GetInputEntryGameObjects() { }
        // RVA: -1  // abstract  token: 0x60006FD
        public virtual System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x60006FE
        public virtual System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x60006FF
        public virtual System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000700
        public virtual System.Void ResetInputNode(System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000701
        public virtual System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000702
        public virtual System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000703
        public virtual System.Void RemoveAllInputEntries(System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000704
        public virtual System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000705
        public virtual System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000706
        public virtual System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000707
        public virtual System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000708
        public virtual System.Boolean AreAnyInputHDAsConnected() { }
        // RVA: -1  // abstract  token: 0x6000709
        public virtual System.Int32 GetConnectedInputCount() { }
        // RVA: -1  // abstract  token: 0x600070A
        public virtual System.Int32 GetConnectedNodeID(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x600070B
        public virtual System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        // RVA: -1  // abstract  token: 0x600070C
        public virtual System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }

    }

    // TypeToken: 0x20000E4  // size: 0x14
    public sealed struct HEU_MaterialSourceWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper DEFAULT;  // const
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper HOUDINI;  // const
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper UNITY;  // const
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper SUBSTANCE;  // const

    }

    // TypeToken: 0x20000E5
    public interface IHEU_MaterialData
    {
        // Properties
        UnityEngine.Material Material { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_MaterialSourceWrapper MaterialSource { get; /* RVA: -1  // abstract */ }
        System.Int32 MaterialKey { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000711
        public virtual System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath) { }
        // RVA: -1  // abstract  token: 0x6000712
        public virtual System.Boolean IsExistingMaterial() { }

    }

    // TypeToken: 0x20000E6
    public interface IHEU_ObjectNode
    {
        // Properties
        System.Int32 ObjectID { get; /* RVA: -1  // abstract */ }
        System.String ObjectName { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_ObjectInfo ObjectInfo { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> GeoNodes { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_Transform ObjectTransform { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000718
        public virtual System.Boolean IsInstanced() { }
        // RVA: -1  // abstract  token: 0x6000719
        public virtual System.Boolean IsVisible() { }
        // RVA: -1  // abstract  token: 0x600071A
        public virtual System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        // RVA: -1  // abstract  token: 0x600071B
        public virtual System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: -1  // abstract  token: 0x600071C
        public virtual System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: -1  // abstract  token: 0x600071D
        public virtual HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        // RVA: -1  // abstract  token: 0x600071E
        public virtual HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName) { }
        // RVA: -1  // abstract  token: 0x600071F
        public virtual System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        // RVA: -1  // abstract  token: 0x6000720
        public virtual System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes) { }
        // RVA: -1  // abstract  token: 0x6000721
        public virtual System.Void HideAllGeometry() { }
        // RVA: -1  // abstract  token: 0x6000722
        public virtual System.Void DisableAllColliders() { }
        // RVA: -1  // abstract  token: 0x6000723
        public virtual System.Boolean IsInstancer() { }

    }

    // TypeToken: 0x20000E7  // size: 0x14
    public sealed struct HEU_HoudiniRampInterpolationTypeWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper CONSTANT;  // const
        public static HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper LINEAR;  // const
        public static HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper CATMULL_ROM;  // const

    }

    // TypeToken: 0x20000E8  // size: 0x18
    public class HEU_RampPointWrapper
    {
        // Fields
        private System.Single <Position>k__BackingField;  // 0x10
        private HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper <Interpolation>k__BackingField;  // 0x14

        // Properties
        System.Single Position { get; /* RVA: 0x03D4E7A0 */ set; /* RVA: 0x03D50CA0 */ }
        HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper Interpolation { get; /* RVA: 0x03D50CC0 */ set; /* RVA: 0x03D595B0 */ }

        // Methods
        // RVA: 0x03D6D730  token: 0x6000728
        public System.Void .ctor(System.Single position, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation) { }

    }

    // TypeToken: 0x20000E9  // size: 0x20
    public class HEU_FloatRampPointWrapper : HoudiniEngineUnity.HEU_RampPointWrapper
    {
        // Fields
        private System.Single <Value>k__BackingField;  // 0x18

        // Properties
        System.Single Value { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x03D4EC00 */ }

        // Methods
        // RVA: 0x03D6D6F0  token: 0x600072B
        public System.Void .ctor(System.Single position, System.Single value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation) { }

    }

    // TypeToken: 0x20000EA  // size: 0x28
    public class HEU_ColorRampPointWrapper : HoudiniEngineUnity.HEU_RampPointWrapper
    {
        // Fields
        private UnityEngine.Color <Value>k__BackingField;  // 0x18

        // Properties
        UnityEngine.Color Value { get; /* RVA: 0x03D51D80 */ set; /* RVA: 0x03D51D90 */ }

        // Methods
        // RVA: 0x03D6D6D0  token: 0x600072E
        public System.Void .ctor(System.Single position, UnityEngine.Color value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation) { }

    }

    // TypeToken: 0x20000EB  // size: 0x40
    public class HEU_ParameterTupleWrapper
    {
        // Fields
        private System.Boolean[] _boolValues;  // 0x10
        private System.Int32[] _intValues;  // 0x18
        private System.Single[] _floatValues;  // 0x20
        private System.String[] _stringValues;  // 0x28
        private HoudiniEngineUnity.HEU_FloatRampPointWrapper[] _floatRampValues;  // 0x30
        private HoudiniEngineUnity.HEU_ColorRampPointWrapper[] _colorRampValues;  // 0x38

        // Properties
        System.Boolean[] BoolValues { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Int32[] IntValues { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Single[] FloatValues { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.String[] StringValues { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        HoudiniEngineUnity.HEU_FloatRampPointWrapper[] FloatRampValues { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        HoudiniEngineUnity.HEU_ColorRampPointWrapper[] ColorRampValues { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600073B
        public System.Void .ctor() { }
        // RVA: 0x0426FEE0  token: 0x600073C
        public System.Void .ctor(System.Boolean[] boolValues) { }
        // RVA: 0x022C3A90  token: 0x600073D
        public System.Void .ctor(System.Int32[] intValues) { }
        // RVA: 0x04271930  token: 0x600073E
        public System.Void .ctor(System.Single[] floatValues) { }
        // RVA: 0x02C92F10  token: 0x600073F
        public System.Void .ctor(System.String[] stringValues) { }
        // RVA: 0x04270470  token: 0x6000740
        public System.Void .ctor(HoudiniEngineUnity.HEU_FloatRampPointWrapper[] floatRampValues) { }
        // RVA: 0x0388FF30  token: 0x6000741
        public System.Void .ctor(HoudiniEngineUnity.HEU_ColorRampPointWrapper[] colorRampValues) { }

    }

    // TypeToken: 0x20000EC
    public interface IHEU_Parameters
    {
        // Properties
        System.Boolean ShowParameters { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Int32 NodeID { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<System.Int32> RootParameters { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> ParameterModifiers { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000747
        public virtual System.Boolean AreParametersValid() { }
        // RVA: -1  // abstract  token: 0x6000748
        public virtual System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters() { }
        // RVA: -1  // abstract  token: 0x6000749
        public virtual HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex) { }
        // RVA: -1  // abstract  token: 0x600074A
        public virtual HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name) { }
        // RVA: -1  // abstract  token: 0x600074B
        public virtual HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID) { }
        // RVA: -1  // abstract  token: 0x600074C
        public virtual System.Void RemoveParameter(System.Int32 listIndex) { }
        // RVA: -1  // abstract  token: 0x600074D
        public virtual System.Boolean HaveParametersChanged() { }
        // RVA: -1  // abstract  token: 0x600074E
        public virtual System.Boolean ResetAllToDefault(System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600074F
        public virtual System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000750
        public virtual System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex) { }
        // RVA: -1  // abstract  token: 0x6000751
        public virtual System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000752
        public virtual System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values) { }
        // RVA: -1  // abstract  token: 0x6000753
        public virtual System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000754
        public virtual System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value) { }
        // RVA: -1  // abstract  token: 0x6000755
        public virtual System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000756
        public virtual System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex) { }
        // RVA: -1  // abstract  token: 0x6000757
        public virtual System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000758
        public virtual System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values) { }
        // RVA: -1  // abstract  token: 0x6000759
        public virtual System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600075A
        public virtual System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value) { }
        // RVA: -1  // abstract  token: 0x600075B
        public virtual System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600075C
        public virtual System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex) { }
        // RVA: -1  // abstract  token: 0x600075D
        public virtual System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600075E
        public virtual System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex) { }
        // RVA: -1  // abstract  token: 0x600075F
        public virtual System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000760
        public virtual System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values) { }
        // RVA: -1  // abstract  token: 0x6000761
        public virtual System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000762
        public virtual System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex) { }
        // RVA: -1  // abstract  token: 0x6000763
        public virtual System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000764
        public virtual System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values) { }
        // RVA: -1  // abstract  token: 0x6000765
        public virtual System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000766
        public virtual System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints) { }
        // RVA: -1  // abstract  token: 0x6000767
        public virtual System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000768
        public virtual System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        // RVA: -1  // abstract  token: 0x6000769
        public virtual System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600076A
        public virtual System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints) { }
        // RVA: -1  // abstract  token: 0x600076B
        public virtual System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600076C
        public virtual System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        // RVA: -1  // abstract  token: 0x600076D
        public virtual System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x600076E
        public virtual System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints) { }
        // RVA: -1  // abstract  token: 0x600076F
        public virtual System.Boolean TriggerButtonParameter(System.String parameterName) { }
        // RVA: -1  // abstract  token: 0x6000770
        public virtual System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecookAsset) { }
        // RVA: -1  // abstract  token: 0x6000771
        public virtual System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples) { }

    }

    // TypeToken: 0x20000ED
    public interface IHEU_PartData
    {
        // Properties
        System.Int32 PartID { get; /* RVA: -1  // abstract */ }
        System.String PartName { get; /* RVA: -1  // abstract */ }
        System.Int32 GeoID { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HAPI_PartType PartType { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_GeoNode ParentGeoNode { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> ObjectInstanceInfos { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_Curve Curve { get; /* RVA: -1  // abstract */ }
        System.Int32 MeshVertexCount { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_GeneratedOutput GeneratedOutput { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject OutputGameObject { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600077C
        public virtual System.Boolean IsPartInstancer() { }
        // RVA: -1  // abstract  token: 0x600077D
        public virtual System.Boolean IsAttribInstancer() { }
        // RVA: -1  // abstract  token: 0x600077E
        public virtual System.Boolean IsInstancerAnyType() { }
        // RVA: -1  // abstract  token: 0x600077F
        public virtual System.Boolean IsPartInstanced() { }
        // RVA: -1  // abstract  token: 0x6000780
        public virtual System.Int32 GetPartPointCount() { }
        // RVA: -1  // abstract  token: 0x6000781
        public virtual System.Boolean IsObjectInstancer() { }
        // RVA: -1  // abstract  token: 0x6000782
        public virtual System.Boolean IsPartVolume() { }
        // RVA: -1  // abstract  token: 0x6000783
        public virtual System.Boolean IsPartCurve() { }
        // RVA: -1  // abstract  token: 0x6000784
        public virtual System.Boolean IsPartMesh() { }
        // RVA: -1  // abstract  token: 0x6000785
        public virtual System.Boolean IsPartEditable() { }
        // RVA: -1  // abstract  token: 0x6000786
        public virtual System.Boolean HaveInstancesBeenGenerated() { }
        // RVA: -1  // abstract  token: 0x6000787
        public virtual System.Void SetGameObjectName(System.String partName) { }
        // RVA: -1  // abstract  token: 0x6000788
        public virtual System.Void SetGameObject(UnityEngine.GameObject gameObject) { }
        // RVA: -1  // abstract  token: 0x6000789
        public virtual System.Void SetVolumeLayerName(System.String name) { }
        // RVA: -1  // abstract  token: 0x600078A
        public virtual System.String GetVolumeLayerName() { }
        // RVA: -1  // abstract  token: 0x600078B
        public virtual System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        // RVA: -1  // abstract  token: 0x600078C
        public virtual System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        // RVA: -1  // abstract  token: 0x600078D
        public virtual System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        // RVA: -1  // abstract  token: 0x600078E
        public virtual System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        // RVA: -1  // abstract  token: 0x600078F
        public virtual HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject) { }
        // RVA: -1  // abstract  token: 0x6000790
        public virtual System.Void ClearInstances() { }
        // RVA: -1  // abstract  token: 0x6000791
        public virtual HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly) { }
        // RVA: -1  // abstract  token: 0x6000792
        public virtual System.Void SetVisiblity(System.Boolean bVisibility) { }
        // RVA: -1  // abstract  token: 0x6000793
        public virtual System.Void SetColliderState(System.Boolean bEnabled) { }
        // RVA: -1  // abstract  token: 0x6000794
        public virtual HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path) { }
        // RVA: -1  // abstract  token: 0x6000795
        public virtual HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID) { }
        // RVA: -1  // abstract  token: 0x6000796
        public virtual System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition) { }
        // RVA: -1  // abstract  token: 0x6000797
        public virtual System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser) { }

    }

    // TypeToken: 0x20000EE  // size: 0x14
    public sealed struct HEU_LinkStateWrapper
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_LinkStateWrapper INACTIVE;  // const
        public static HoudiniEngineUnity.HEU_LinkStateWrapper LINKING;  // const
        public static HoudiniEngineUnity.HEU_LinkStateWrapper LINKED;  // const
        public static HoudiniEngineUnity.HEU_LinkStateWrapper ERROR_NOT_LINKED;  // const

    }

    // TypeToken: 0x20000EF
    public interface IHEU_PDGAssetLink
    {
        // Properties
        System.Boolean AutoCook { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean UseHEngineData { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean UseTOPNodeFilter { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Boolean UseTOPOutputFilter { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.String TopNodeFilter { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.String TopOutputFilter { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: -1  // abstract */ }
        System.String AssetPath { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject AssetGO { get; /* RVA: -1  // abstract */ }
        System.String AssetName { get; /* RVA: -1  // abstract */ }
        System.Int32 AssetID { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> TopNetworks { get; /* RVA: -1  // abstract */ }
        System.String[] TopNetworkNames { get; /* RVA: -1  // abstract */ }
        System.Int32 SelectedTOPNetwork { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_LinkStateWrapper PDGLinkState { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject LoadRootGameObject { get; /* RVA: -1  // abstract */ }
        System.String OutputCachePathRoot { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60007AF
        public virtual System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset) { }
        // RVA: -1  // abstract  token: 0x60007B0
        public virtual System.Void Reset() { }
        // RVA: -1  // abstract  token: 0x60007B1
        public virtual System.Void Refresh() { }
        // RVA: -1  // abstract  token: 0x60007B2
        public virtual System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        // RVA: -1  // abstract  token: 0x60007B3
        public virtual System.Void SelectTOPNetwork(System.Int32 newIndex) { }
        // RVA: -1  // abstract  token: 0x60007B4
        public virtual System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex) { }
        // RVA: -1  // abstract  token: 0x60007B5
        public virtual HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork() { }
        // RVA: -1  // abstract  token: 0x60007B6
        public virtual HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode() { }
        // RVA: -1  // abstract  token: 0x60007B7
        public virtual HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x60007B8
        public virtual System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: -1  // abstract  token: 0x60007B9
        public virtual System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        // RVA: -1  // abstract  token: 0x60007BA
        public virtual System.Void DirtyAll() { }
        // RVA: -1  // abstract  token: 0x60007BB
        public virtual System.Void CookOutput() { }
        // RVA: -1  // abstract  token: 0x60007BC
        public virtual System.Void PauseCook() { }
        // RVA: -1  // abstract  token: 0x60007BD
        public virtual System.Void CancelCook() { }
        // RVA: -1  // abstract  token: 0x60007BE
        public virtual HoudiniEngineUnity.HEU_SessionBase GetHAPISession() { }
        // RVA: -1  // abstract  token: 0x60007BF
        public virtual HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID) { }
        // RVA: -1  // abstract  token: 0x60007C0
        public virtual System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }

    }

    // TypeToken: 0x20000F0
    public interface IHEU_VolumeCache
    {
        // Properties
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> Layers { get; /* RVA: -1  // abstract */ }
        System.Int32 TileIndex { get; /* RVA: -1  // abstract */ }
        System.String ObjectName { get; /* RVA: -1  // abstract */ }
        System.String GeoName { get; /* RVA: -1  // abstract */ }
        UnityEngine.TerrainData TerrainData { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_VolumeScatterTrees ScatterTrees { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.HEU_DetailProperties DetailProperties { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60007C8
        public virtual System.Void ResetParameters() { }
        // RVA: -1  // abstract  token: 0x60007C9
        public virtual HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName) { }
        // RVA: -1  // abstract  token: 0x60007CA
        public virtual System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset) { }
        // RVA: -1  // abstract  token: 0x60007CB
        public virtual System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset) { }

    }

    // TypeToken: 0x20000F1  // size: 0x28
    public class HEU_MaterialData : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_MaterialData, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private UnityEngine.Material _material;  // 0x18
        private HoudiniEngineUnity.HEU_MaterialData.Source _materialSource;  // 0x20
        private System.Int32 _materialKey;  // 0x24

        // Properties
        UnityEngine.Material Material { get; /* RVA: 0x01041090 */ }
        HoudiniEngineUnity.HEU_MaterialSourceWrapper MaterialSource { get; /* RVA: 0x088261D8 */ }
        System.Int32 MaterialKey { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }

        // Methods
        // RVA: 0x088257E0  token: 0x60007D0
        public virtual System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath) { }
        // RVA: 0x08825788  token: 0x60007D1
        public virtual System.Boolean IsExistingMaterial() { }
        // RVA: 0x08825AE8  token: 0x60007D2
        private System.Boolean UseLegacyShaders(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath, HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_NodeInfo nodeInfo, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos) { }
        // RVA: 0x088254E8  token: 0x60007D3
        private static System.String GetTextureFileNameFromMaterialParam(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo parmInfo) { }
        // RVA: 0x0882579C  token: 0x60007D4
        private static System.Boolean IsTransparentMaterial(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters) { }
        // RVA: 0x08825274  token: 0x60007D5
        private static System.Boolean GetMaterialAlpha(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.Single defaultValue, System.Single& alpha) { }
        // RVA: 0x088253E8  token: 0x60007D6
        private static System.String GetSupportedFileFormat(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo) { }
        // RVA: 0x088255EC  token: 0x60007D7
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_MaterialData other) { }
        // RVA: 0x087DF02C  token: 0x60007D8
        private static HoudiniEngineUnity.HEU_MaterialData.Source MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialSourceWrapper materialSource) { }
        // RVA: 0x087DF02C  token: 0x60007D9
        private static HoudiniEngineUnity.HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialData.Source materialSource) { }
        // RVA: 0x088261C8  token: 0x60007DA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3  // size: 0x10
    public class HEU_MaterialFactory
    {
        // Fields
        public static UnityEngine.Material _defaultStandardMaterial;  // static @ 0x0

        // Methods
        // RVA: 0x08826A14  token: 0x60007DB
        public static UnityEngine.Shader FindShader(System.String shaderName) { }
        // RVA: 0x088269DC  token: 0x60007DC
        public static UnityEngine.Shader FindPluginShader(System.String shaderName) { }
        // RVA: 0x08826E80  token: 0x60007DD
        public static UnityEngine.Material GetNewMaterialWithShader(System.String assetCacheFolderPath, System.String shaderName, System.String materialName, System.Boolean bWriteToFile) { }
        // RVA: 0x08826514  token: 0x60007DE
        public static UnityEngine.Material CreateNewHoudiniStandardMaterial(System.String assetCacheFolderPath, System.String materialName, System.Boolean bWriteToFile) { }
        // RVA: 0x08827A48  token: 0x60007DF
        public static System.Void WriteMaterialToAssetCache(UnityEngine.Material material, System.String assetCacheFolderPath, System.String materialName, System.Boolean bOverwriteExisting) { }
        // RVA: 0x08826874  token: 0x60007E0
        public static System.Boolean DoesMaterialExistInAssetCache(UnityEngine.Material material) { }
        // RVA: 0x08826800  token: 0x60007E1
        public static System.Void DestroyNonAssetMaterial(UnityEngine.Material material, System.Boolean bRegisterUndo) { }
        // RVA: 0x088267F8  token: 0x60007E2
        public static System.Void DeleteAssetMaterial(UnityEngine.Material material) { }
        // RVA: 0x08827980  token: 0x60007E3
        public static UnityEngine.Texture2D RenderAndExtractImageToTexture(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.Int32 textureParmID, System.String textureName, System.String assetCacheFolderPath, System.Boolean isNormalMap, System.Boolean invertTexture) { }
        // RVA: 0x0882693C  token: 0x60007E4
        private static UnityEngine.Texture2D ExtractHoudiniImageToTexturePNGJPEG(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes) { }
        // RVA: 0x08826974  token: 0x60007E5
        private static UnityEngine.Texture2D ExtractHoudiniImageToTextureRaw(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes) { }
        // RVA: 0x088268B8  token: 0x60007E6
        public static UnityEngine.Texture2D ExtractHoudiniImageToTextureFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes, System.String assetCacheFolderPath) { }
        // RVA: 0x08827678  token: 0x60007E7
        public static UnityEngine.Material LoadUnityMaterial(System.String materialPath) { }
        // RVA: 0x088273E4  token: 0x60007E8
        public static UnityEngine.Material LoadSubstanceMaterialWithName(System.String materialPath, System.String substanceName) { }
        // RVA: 0x0882721C  token: 0x60007E9
        public static UnityEngine.Material LoadSubstanceMaterialWithIndex(System.String materialPath, System.Int32 substanceMaterialIndex) { }
        // RVA: 0x08827120  token: 0x60007EA
        public static System.Int32 GetUnitySubstanceMaterialKey(System.String unityMaterialPath, System.String substanceName, System.Int32 substanceIndex) { }
        // RVA: 0x03D4C200  token: 0x60007EB
        public static System.Int32 MaterialNameToKey(System.String materialName) { }
        // RVA: 0x08826898  token: 0x60007EC
        public static System.Void EnableGPUInstancing(UnityEngine.Material material) { }
        // RVA: 0x08827964  token: 0x60007ED
        public static System.Boolean MaterialHasGPUInstancingEnabled(UnityEngine.Material material) { }
        // RVA: 0x08826204  token: 0x60007EE
        public static UnityEngine.Material CopyMaterial(UnityEngine.Material material) { }
        // RVA: 0x08826AE8  token: 0x60007EF
        public static UnityEngine.Material GetDefaultStandardMaterial() { }
        // RVA: 0x08827570  token: 0x60007F0
        public static UnityEngine.Texture2D LoadTexture(System.String path) { }
        // RVA: 0x08827A40  token: 0x60007F1
        public static UnityEngine.Texture2D WhiteTexture() { }
        // RVA: 0x08826560  token: 0x60007F2
        public static HoudiniEngineUnity.HEU_MaterialData CreateUnitySubstanceMaterialData(System.Int32 materialKey, System.String materialPath, System.String substanceName, System.Int32 substanceIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        // RVA: 0x088263AC  token: 0x60007F3
        public static HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialSourceWrapper sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        // RVA: 0x08826408  token: 0x60007F4
        private static HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialData.Source sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        // RVA: 0x08827050  token: 0x60007F5
        public static HoudiniEngineUnity.HEU_MaterialData GetOrCreateDefaultMaterialInCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        // RVA: 0x08826B98  token: 0x60007F6
        public static HoudiniEngineUnity.HEU_MaterialData GetMaterialDataFromCache(System.Int32 materialKey, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache) { }
        // RVA: 0x08826A4C  token: 0x60007F7
        public static System.String GenerateDefaultMaterialName(System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x08826264  token: 0x60007F8
        public static HoudiniEngineUnity.HEU_MaterialData CreateHoudiniMaterialData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 materialID, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        // RVA: 0x08826CB4  token: 0x60007F9
        public static System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData> GetMaterialDataMapFromCache(System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache) { }
        // RVA: 0x0350B670  token: 0x60007FA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4  // size: 0x28
    public class HEU_UnityMaterialInfo
    {
        // Fields
        public System.String _unityMaterialPath;  // 0x10
        public System.String _substancePath;  // 0x18
        public System.Int32 _substanceIndex;  // 0x20

        // Methods
        // RVA: 0x03864580  token: 0x60007FB
        public System.Void .ctor(System.String unityMaterialPath, System.String substancePath, System.Int32 substanceIndex) { }

    }

    // TypeToken: 0x20000F5  // size: 0x30
    public class HEU_SessionBase
    {
        // Fields
        protected HoudiniEngineUnity.HEU_SessionData _sessionData;  // 0x10
        private System.Boolean <UserNotifiedSessionInvalid>k__BackingField;  // 0x18
        private System.String _sessionErrorMsg;  // 0x20
        private System.Boolean <LogErrorOverride>k__BackingField;  // 0x28
        private System.Boolean <ThrowErrorOverride>k__BackingField;  // 0x29
        private HoudiniEngineUnity.HAPI_Result <LastCallResultCode>k__BackingField;  // 0x2c

        // Properties
        System.Boolean UserNotifiedSessionInvalid { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        HoudiniEngineUnity.SessionConnectionState ConnectionState { get; /* RVA: 0x0882CA84 */ set; /* RVA: 0x0882CAAC */ }
        HoudiniEngineUnity.SessionMode ThisSessionMode { get; /* RVA: 0x0882CA98 */ set; /* RVA: 0x0882CABC */ }
        System.Boolean LogErrorOverride { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        System.Boolean ThrowErrorOverride { get; /* RVA: 0x03D4F2A0 */ set; /* RVA: 0x03D4F2B0 */ }
        HoudiniEngineUnity.HAPI_Result LastCallResultCode { get; /* RVA: 0x03D4EDD0 */ set; /* RVA: 0x03D4EDE0 */ }

        // Methods
        // RVA: 0x03D4EB40  token: 0x6000802
        public System.String GetSessionErrorMsg() { }
        // RVA: 0x0882C7B4  token: 0x6000807
        public System.Boolean IsSessionSync() { }
        // RVA: 0x01002730  token: 0x600080A
        public virtual HoudiniEngineUnity.HEU_HoudiniAsset GetRegisteredAssetFromID(System.Int32 id) { }
        // RVA: 0x0115F4C0  token: 0x600080B
        public virtual System.Boolean IsAssetRegistered(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x0350B670  token: 0x600080C
        public virtual System.Void RegisterAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x0350B670  token: 0x600080D
        public virtual System.Void UnregisterAsset(System.Int32 id) { }
        // RVA: 0x0350B670  token: 0x600080E
        public virtual System.Void ReregisterOnAwake(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        // RVA: 0x03D6D870  token: 0x600080F
        public System.Void .ctor() { }
        // RVA: 0x0882CA14  token: 0x6000810
        public virtual System.Void SetSessionErrorMsg(System.String msg, System.Boolean bLogError) { }
        // RVA: 0x0882C858  token: 0x6000811
        public virtual System.Void SetSessionConnectionErrorMsg(System.String introMsg, HoudiniEngineUnity.HAPI_Result result, System.Boolean bIsHARSRunning, System.Boolean bLogError) { }
        // RVA: 0x0882C7CC  token: 0x6000812
        public virtual System.Void SetLibraryErrorMsg(System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000813
        protected virtual System.Boolean CreateSessionData(System.Boolean bOverwriteExisting, System.Boolean bIsDefaultSession) { }
        // RVA: 0x0115F4C0  token: 0x6000814
        public virtual System.Boolean CreateInProcessSession(System.Boolean bIsDefaultSession) { }
        // RVA: 0x0115F4C0  token: 0x6000815
        public virtual System.Boolean CreateThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000816
        public virtual System.Boolean CreateThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000817
        public virtual System.Boolean CreateCustomSession(System.Boolean bIsDefaultSession) { }
        // RVA: 0x0115F4C0  token: 0x6000818
        public virtual System.Boolean ConnectThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize) { }
        // RVA: 0x0115F4C0  token: 0x6000819
        public virtual System.Boolean ConnectThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize) { }
        // RVA: 0x0115F4C0  token: 0x600081A
        public virtual System.Boolean CloseSession() { }
        // RVA: 0x0115F4C0  token: 0x600081B
        protected virtual System.Boolean CheckAndCloseExistingSession() { }
        // RVA: 0x0882C5EC  token: 0x600081C
        protected virtual System.Void ClearSessionInfo() { }
        // RVA: 0x0426FEE0  token: 0x600081D
        public System.Void SetSessionData(HoudiniEngineUnity.HEU_SessionData sessionData) { }
        // RVA: 0x020B7B20  token: 0x600081E
        public HoudiniEngineUnity.HEU_SessionData GetSessionData() { }
        // RVA: 0x0882C75C  token: 0x600081F
        public virtual System.String GetSessionInfo() { }
        // RVA: 0x0115F4C0  token: 0x6000820
        public virtual System.Boolean IsSessionValid() { }
        // RVA: 0x0115F4C0  token: 0x6000821
        public virtual System.Boolean RestartSession() { }
        // RVA: 0x03D4EB40  token: 0x6000822
        public System.String GetLastSessionError() { }
        // RVA: 0x0115F4C0  token: 0x6000823
        public virtual System.Boolean CheckVersionMatch() { }
        // RVA: 0x0115F4C0  token: 0x6000824
        public virtual System.Boolean InitializeSession(HoudiniEngineUnity.HEU_SessionData sessionData) { }
        // RVA: 0x0115F4C0  token: 0x6000825
        public virtual System.Boolean HandleStatusResult(HoudiniEngineUnity.HAPI_Result result, System.String prependMsg, System.Boolean bThrowError, System.Boolean bLogError) { }
        // RVA: 0x0350B670  token: 0x6000826
        public virtual System.Void SetServerEnvString(System.String name, System.String value) { }
        // RVA: 0x0882C740  token: 0x6000827
        public virtual System.Boolean GetServerEnvString(System.String name, System.String& value) { }
        // RVA: 0x03D6D7D0  token: 0x6000828
        public virtual System.Boolean GetServerEnvVarCount(System.Int32& env_count) { }
        // RVA: 0x03D6D7D0  token: 0x6000829
        public virtual System.Boolean GetCallResult(HoudiniEngineUnity.HAPI_Result& result) { }
        // RVA: 0x03D6D7D0  token: 0x600082A
        public virtual System.Boolean GetCookResult(HoudiniEngineUnity.HAPI_Result& result) { }
        // RVA: 0x03D6D7D0  token: 0x600082B
        public virtual System.Boolean GetCookState(HoudiniEngineUnity.HAPI_State& state) { }
        // RVA: 0x0882C788  token: 0x600082C
        public virtual System.String GetStatusString(HoudiniEngineUnity.HAPI_StatusType statusType, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity) { }
        // RVA: 0x0882C634  token: 0x600082D
        public virtual System.String ComposeNodeCookResult(System.Int32 nodeId, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity) { }
        // RVA: 0x01002730  token: 0x600082E
        public virtual System.Int32 GetEnvInt(HoudiniEngineUnity.HAPI_EnvIntType intType) { }
        // RVA: 0x01002730  token: 0x600082F
        public virtual System.Int32 GetSessionEnvInt(HoudiniEngineUnity.HAPI_SessionEnvIntType intType, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000830
        public virtual System.Boolean GetString(System.Int32 stringHandle, System.String& resultString, System.Int32 bufferLength) { }
        // RVA: 0x01002730  token: 0x6000831
        public virtual System.Int32 GetStringBufferLength(System.Int32 stringHandle) { }
        // RVA: 0x01002730  token: 0x6000832
        public virtual System.Int32 CheckForSpecificErrors(System.Int32 nodeID, System.Int32 errorsToCheck) { }
        // RVA: 0x03D503F0  token: 0x6000833
        public virtual System.Single GetTime() { }
        // RVA: 0x0115F4C0  token: 0x6000834
        public virtual System.Boolean SetTime(System.Single time) { }
        // RVA: 0x0115F4C0  token: 0x6000835
        public virtual System.Boolean GetUseHoudiniTime() { }
        // RVA: 0x0115F4C0  token: 0x6000836
        public virtual System.Boolean SetUseHoudiniTime(System.Boolean enable) { }
        // RVA: 0x03D6D7E0  token: 0x6000837
        public virtual System.Boolean LoadAssetLibraryFromFile(System.String assetPath, System.Boolean bAllowOverwrite, System.Int32& libraryID) { }
        // RVA: 0x03D6D7E0  token: 0x6000838
        public virtual System.Boolean LoadAssetLibraryFromMemory(System.Byte[] buffer, System.Boolean bAllowOverwrite, System.Int32& libraryID) { }
        // RVA: 0x03D6D7C0  token: 0x6000839
        public virtual System.Boolean CreateNode(System.Int32 parentNodeID, System.String operatorName, System.String nodeLabel, System.Boolean bCookOnCreation, System.Int32& newNodeID) { }
        // RVA: 0x0350B670  token: 0x600083A
        public virtual System.Void DeleteNode(System.Int32 nodeID) { }
        // RVA: 0x0115F4C0  token: 0x600083B
        public virtual System.Boolean CookNode(System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.Boolean bSplitGeosByGroup) { }
        // RVA: 0x0115F4C0  token: 0x600083C
        public virtual System.Boolean CookNodeWithOptions(System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions cookOptions) { }
        // RVA: 0x0115F4C0  token: 0x600083D
        public virtual System.Boolean RenameNode(System.Int32 nodeID, System.String newName) { }
        // RVA: 0x0115F4C0  token: 0x600083E
        public virtual System.Boolean ConnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32 nodeIDToConnect, System.Int32 outputIndex) { }
        // RVA: 0x0115F4C0  token: 0x600083F
        public virtual System.Boolean DisconnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Boolean bLogError) { }
        // RVA: 0x03D6D810  token: 0x6000840
        public virtual System.Boolean QueryNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& connectedNodeID, System.Boolean bLogError) { }
        // RVA: 0x03D6D7E0  token: 0x6000841
        public virtual System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& nodeNameIndex) { }
        // RVA: 0x03D6D740  token: 0x6000842
        public virtual System.Boolean GetAvailableAssetCount(System.Int32 libraryID, System.Int32& assetCount) { }
        // RVA: 0x0115F4C0  token: 0x6000843
        public virtual System.Boolean GetAvailableAssets(System.Int32 libraryID, System.Int32[]& assetNames, System.Int32 assetCount) { }
        // RVA: 0x0115F4C0  token: 0x6000844
        public virtual System.Boolean GetAssetInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000845
        public virtual System.Boolean GetNodeInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Boolean bLogError) { }
        // RVA: 0x06B99BB0  token: 0x6000846
        public virtual System.Boolean GetNodePath(System.Int32 nodeID, System.Int32 relativeNodeID, System.String& path) { }
        // RVA: 0x0115F4C0  token: 0x6000847
        public virtual System.Boolean IsNodeValid(System.Int32 nodeID, System.Int32 uniqueNodeID) { }
        // RVA: 0x0115F4C0  token: 0x6000848
        public virtual System.Boolean ComposeChildNodeList(System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32& count, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000849
        public virtual System.Boolean GetComposedChildNodeList(System.Int32 parentNodeID, System.Int32[] childNodeIDs, System.Int32 count, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x600084A
        public virtual System.Boolean LoadHIPFile(System.String fileName, System.Boolean bCookOnLoad) { }
        // RVA: 0x0115F4C0  token: 0x600084B
        public virtual System.Boolean SaveHIPFile(System.String fileName, System.Boolean bLockNodes) { }
        // RVA: 0x0115F4C0  token: 0x600084C
        public virtual System.Boolean GetObjectInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo) { }
        // RVA: 0x0115F4C0  token: 0x600084D
        public virtual System.Boolean GetObjectTransform(System.Int32 nodeID, System.Int32 relativeToNodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform& hapiTransform) { }
        // RVA: 0x0115F4C0  token: 0x600084E
        public virtual System.Boolean SetObjectTransform(System.Int32 nodeID, HoudiniEngineUnity.HAPI_TransformEuler& hapiTransform) { }
        // RVA: 0x03D6D740  token: 0x600084F
        public virtual System.Boolean ComposeObjectList(System.Int32 nodeID, System.Int32& objectCount) { }
        // RVA: 0x0115F4C0  token: 0x6000850
        public virtual System.Boolean GetComposedObjectList(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000851
        public virtual System.Boolean GetComposedObjectTransforms(System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000852
        public virtual System.Boolean GetDisplayGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError) { }
        // RVA: 0x03D6D740  token: 0x6000853
        public virtual System.Boolean GetOutputGeoCount(System.Int32 nodeID, System.Int32& count, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000854
        public virtual System.Boolean GetOutputGeoInfos(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo[]& geoInfosArray, System.Int32 count, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000855
        public virtual System.Boolean GetGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000856
        public virtual System.Boolean GetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000857
        public virtual System.Boolean GetAttributeInfo(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000858
        public virtual System.Boolean GetAttributeNames(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.String[]& attributeNames, System.Int32 count) { }
        // RVA: 0x0115F4C0  token: 0x6000859
        public virtual System.Boolean GetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] dataArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600085A
        public virtual System.Boolean GetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Single[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600085B
        public virtual System.Boolean GetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[]& data, System.Int32 dataLength, System.Int32[]& sizesArray, System.Int32 start, System.Int32 sizesLength) { }
        // RVA: 0x0115F4C0  token: 0x600085C
        public virtual System.Boolean GetAttributeFloat64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Double[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600085D
        public virtual System.Boolean GetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600085E
        public virtual System.Boolean GetAttributeUInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Byte[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600085F
        public virtual System.Boolean GetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.SByte[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000860
        public virtual System.Boolean GetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int16[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000861
        public virtual System.Boolean GetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int64[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000862
        public virtual System.Boolean GetGroupNames(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& names, System.Int32 count) { }
        // RVA: 0x0115F4C0  token: 0x6000863
        public virtual System.Boolean GetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D7F0  token: 0x6000864
        public virtual System.Boolean GetGroupCountOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, System.Int32& pointGroupCount, System.Int32& primitiveGroupCount) { }
        // RVA: 0x0115F4C0  token: 0x6000865
        public virtual System.Boolean GetGroupNamesOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& groupNamesArray, System.Int32 groupCount) { }
        // RVA: 0x0115F4C0  token: 0x6000866
        public virtual System.Boolean GetGroupMembershipOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000867
        public virtual System.Boolean GetInstancedPartIds(System.Int32 nodeID, System.Int32 partID, System.Int32[] instancedPartsArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000868
        public virtual System.Boolean GetInstancerPartTransforms(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000869
        public virtual System.Boolean GetInstanceTransformsOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600086A
        public virtual System.Boolean GetInstancedObjectIds(System.Int32 nodeID, System.Int32[] instanced_node_id_array, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600086B
        public virtual System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600086C
        public virtual System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x600086D
        public virtual System.Boolean GetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600086E
        public virtual System.Boolean GetBoxInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_BoxInfo& boxInfo) { }
        // RVA: 0x0115F4C0  token: 0x600086F
        public virtual System.Boolean GetSphereInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_SphereInfo& sphereInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000870
        public virtual System.Boolean GetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000871
        public virtual System.Boolean GetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000872
        public virtual System.Boolean GetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000873
        public virtual System.Boolean GetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000874
        public virtual System.Boolean GetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& inputCurveInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000875
        public virtual System.Boolean SetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000876
        public virtual System.Boolean SetFaceCount(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000877
        public virtual System.Boolean SetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000878
        public virtual System.Boolean SetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int32[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000879
        public virtual System.Boolean SetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.SByte[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600087A
        public virtual System.Boolean SetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int16[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600087B
        public virtual System.Boolean SetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int64[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600087C
        public virtual System.Boolean SetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600087D
        public virtual System.Boolean SetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 dataLength, System.Int32[] sizesArray, System.Int32 start, System.Int32 sizesLength) { }
        // RVA: 0x0115F4C0  token: 0x600087E
        public virtual System.Boolean SetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String[] data, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600087F
        public virtual System.Boolean AddAttribute(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000880
        public virtual System.Boolean AddGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName) { }
        // RVA: 0x0115F4C0  token: 0x6000881
        public virtual System.Boolean DeleteGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName) { }
        // RVA: 0x0115F4C0  token: 0x6000882
        public virtual System.Boolean SetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[] membershipArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000883
        public virtual System.Boolean CommitGeo(System.Int32 nodeID) { }
        // RVA: 0x0115F4C0  token: 0x6000884
        public virtual System.Boolean RevertGeo(System.Int32 nodeID) { }
        // RVA: 0x0115F4C0  token: 0x6000885
        public virtual System.Boolean SetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000886
        public virtual System.Boolean SetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000887
        public virtual System.Boolean SetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000888
        public virtual System.Boolean SetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x6000889
        public virtual System.Boolean SetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& curveInfo) { }
        // RVA: 0x0115F4C0  token: 0x600088A
        public virtual System.Boolean SetInputCurvePositions(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x600088B
        public virtual System.Boolean SetInputCurvePositionsRotationsScales(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length, System.Single[] rotationsArray, System.Int32 rotationsStart, System.Int32 rotationsLength, System.Single[] scalesArray, System.Int32 scalesStart, System.Int32 scalesLength) { }
        // RVA: 0x0115F4C0  token: 0x600088C
        public virtual System.Boolean GetMaterialOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo) { }
        // RVA: 0x0115F4C0  token: 0x600088D
        public virtual System.Boolean GetMaterialNodeIDsOnFaces(System.Int32 nodeID, System.Int32 partID, System.Boolean& bSingleFaceMaterial, System.Int32[] materialNodeIDs, System.Int32 faceCount) { }
        // RVA: 0x0115F4C0  token: 0x600088E
        public virtual System.Boolean GetMaterialInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x600088F
        public virtual System.Boolean GetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000890
        public virtual System.Boolean SetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo) { }
        // RVA: 0x0115F4C0  token: 0x6000891
        public virtual System.Boolean RenderTextureToImage(System.Int32 materialNodeID, System.Int32 parmID, System.Boolean bLogError) { }
        // RVA: 0x0115F4C0  token: 0x6000892
        public virtual System.Boolean RenderCOPToImage(System.Int32 copNodeID) { }
        // RVA: 0x0882C67C  token: 0x6000893
        public virtual System.Boolean ExtractImageToMemory(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.Byte[]& buffer) { }
        // RVA: 0x0882C6C0  token: 0x6000894
        public virtual System.Boolean GetImagePlanes(System.Int32 nodeID, System.Int32[] imagePlanes, System.Int32 numImagePlanes) { }
        // RVA: 0x0882C660  token: 0x6000895
        public virtual System.Boolean ExtractImageToFile(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.String destinationFolderPath, System.String& destinationFilePath) { }
        // RVA: 0x0115F4C0  token: 0x6000896
        public virtual System.Boolean GetParams(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D800  token: 0x6000897
        public virtual System.Boolean GetParmTagName(System.Int32 nodeID, System.Int32 parmID, System.Int32 tagIndex, System.Int32& tagName) { }
        // RVA: 0x03D6D800  token: 0x6000898
        public virtual System.Boolean GetParmTagValue(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Int32& tagValue) { }
        // RVA: 0x0115F4C0  token: 0x6000899
        public virtual System.Boolean ParmHasTag(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Boolean& hasTag) { }
        // RVA: 0x0115F4C0  token: 0x600089A
        public virtual System.Boolean GetParamIntValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D800  token: 0x600089B
        public virtual System.Boolean GetParamIntValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value) { }
        // RVA: 0x0115F4C0  token: 0x600089C
        public virtual System.Boolean GetParamFloatValues(System.Int32 nodeID, System.Single[] values, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D800  token: 0x600089D
        public virtual System.Boolean GetParamFloatValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Single& value) { }
        // RVA: 0x0115F4C0  token: 0x600089E
        public virtual System.Boolean GetParamStringValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D800  token: 0x600089F
        public virtual System.Boolean GetParamStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value) { }
        // RVA: 0x03D6D810  token: 0x60008A0
        public virtual System.Boolean GetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32& nodeValue) { }
        // RVA: 0x0115F4C0  token: 0x60008A1
        public virtual System.Boolean GetParamChoiceValues(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmChoiceInfo[] values, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x60008A2
        public virtual System.Boolean SetParamIntValues(System.Int32 nodeID, System.Int32[]& values, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x60008A3
        public virtual System.Boolean SetParamIntValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Int32 value) { }
        // RVA: 0x0115F4C0  token: 0x60008A4
        public virtual System.Boolean SetParamFloatValues(System.Int32 nodeID, System.Single[]& values, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x60008A5
        public virtual System.Boolean SetParamFloatValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Single value) { }
        // RVA: 0x0115F4C0  token: 0x60008A6
        public virtual System.Boolean SetParamStringValue(System.Int32 nodeID, System.String strValue, System.Int32 parmID, System.Int32 index) { }
        // RVA: 0x0115F4C0  token: 0x60008A7
        public virtual System.Boolean SetParamStringValue(System.Int32 nodeID, System.String parmName, System.String parmValue, System.Int32 index) { }
        // RVA: 0x0115F4C0  token: 0x60008A8
        public virtual System.Boolean SetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32 nodeValueID) { }
        // RVA: 0x0115F4C0  token: 0x60008A9
        public virtual System.Boolean InsertMultiparmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition) { }
        // RVA: 0x0115F4C0  token: 0x60008AA
        public virtual System.Boolean RemoveMultiParmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition) { }
        // RVA: 0x0115F4C0  token: 0x60008AB
        public virtual System.Boolean GetParmWithTag(System.Int32 nodeID, System.String tagName, System.Int32& parmID) { }
        // RVA: 0x0115F4C0  token: 0x60008AC
        public virtual System.Boolean RevertParmToDefault(System.Int32 nodeID, System.String parm_name, System.Int32 index) { }
        // RVA: 0x0115F4C0  token: 0x60008AD
        public virtual System.Boolean RevertParmToDefaults(System.Int32 nodeID, System.String parm_name) { }
        // RVA: 0x03D6D810  token: 0x60008AE
        public virtual System.Boolean GetParmIDFromName(System.Int32 nodeID, System.String parmName, System.Int32& parmID) { }
        // RVA: 0x03D6D820  token: 0x60008AF
        public virtual System.Boolean GetParmStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Boolean evaluate, System.Int32& value) { }
        // RVA: 0x03D6D7B0  token: 0x60008B0
        public virtual System.Boolean CreateInputNode(System.Int32& nodeID, System.String name) { }
        // RVA: 0x03D6D7B0  token: 0x60008B1
        public virtual System.Boolean CreateInputCurveNode(System.Int32& nodeID, System.String name) { }
        // RVA: 0x03D6D770  token: 0x60008B2
        public virtual System.Boolean CreateHeightFieldInput(System.Int32 parentNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize, HoudiniEngineUnity.HAPI_HeightFieldSampling sampling, System.Int32& heightfieldNodeID, System.Int32& heightNodeID, System.Int32& maskNodeID, System.Int32& mergeNodeID) { }
        // RVA: 0x03D6D7A0  token: 0x60008B3
        public virtual System.Boolean CreateHeightfieldInputVolumeNode(System.Int32 parentNodeID, System.Int32& newNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize) { }
        // RVA: 0x0882C6F8  token: 0x60008B4
        public virtual System.Boolean GetPreset(System.Int32 nodeID, System.Byte[]& presetData) { }
        // RVA: 0x0115F4C0  token: 0x60008B5
        public virtual System.Boolean SetPreset(System.Int32 nodeID, System.Byte[] presetData) { }
        // RVA: 0x0115F4C0  token: 0x60008B6
        public virtual System.Boolean GetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo) { }
        // RVA: 0x0115F4C0  token: 0x60008B7
        public virtual System.Boolean GetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.Single[] valuesArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x60008B8
        public virtual System.Boolean SetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo) { }
        // RVA: 0x0882CA4C  token: 0x60008B9
        public virtual System.Boolean SetVolumeTileFloatData(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeTileInfo& tileInfo, System.Single[] valuesArray, System.Int32 length) { }
        // RVA: 0x03D6D830  token: 0x60008BA
        public virtual System.Boolean GetVolumeBounds(System.Int32 nodeID, System.Int32 partID, System.Single& x_min, System.Single& y_min, System.Single& z_min, System.Single& x_max, System.Single& y_max, System.Single& z_max, System.Single& x_center, System.Single& y_center, System.Single& z_center) { }
        // RVA: 0x0115F4C0  token: 0x60008BB
        public virtual System.Boolean SetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.String name, System.Single[] valuesArray, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D7D0  token: 0x60008BC
        public virtual System.Boolean GetActiveCacheCount(System.Int32& activeCacheCount) { }
        // RVA: 0x0115F4C0  token: 0x60008BD
        public virtual System.Boolean GetActiveCacheNames(System.Int32[] cacheNamesArray, System.Int32 activeCacheCount) { }
        // RVA: 0x03D6D7E0  token: 0x60008BE
        public virtual System.Boolean GetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32& propertyValue) { }
        // RVA: 0x0115F4C0  token: 0x60008BF
        public virtual System.Boolean SetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32 propertyValue) { }
        // RVA: 0x0115F4C0  token: 0x60008C0
        public virtual System.Boolean SaveGeoToFile(System.Int32 nodeID, System.String fileName) { }
        // RVA: 0x0115F4C0  token: 0x60008C1
        public virtual System.Boolean LoadGeoFromFile(System.Int32 nodeID, System.String file_name) { }
        // RVA: 0x0115F4C0  token: 0x60008C2
        public virtual System.Boolean SaveNodeToFile(System.Int32 nodeID, System.String fileName) { }
        // RVA: 0x03D6D7C0  token: 0x60008C3
        public virtual System.Boolean LoadNodeFromFile(System.String file_name, System.Int32 parentNodeID, System.String nodeLabel, System.Boolean cook_on_load, System.Int32& newNodeID) { }
        // RVA: 0x03D6D7E0  token: 0x60008C4
        public virtual System.Boolean GetGeoSize(System.Int32 nodeID, System.String format, System.Int32& size) { }
        // RVA: 0x0115F4C0  token: 0x60008C5
        public virtual System.Boolean GetHandleInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_HandleInfo[] handleInfos, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0115F4C0  token: 0x60008C6
        public virtual System.Boolean GetHandleBindingInfo(System.Int32 nodeID, System.Int32 handleIndex, HoudiniEngineUnity.HAPI_HandleBindingInfo[] handleBindingInfos, System.Int32 start, System.Int32 length) { }
        // RVA: 0x03D6D750  token: 0x60008C7
        public virtual System.Boolean ConvertTransform(HoudiniEngineUnity.HAPI_TransformEuler& inTransform, HoudiniEngineUnity.HAPI_RSTOrder RSTOrder, HoudiniEngineUnity.HAPI_XYZOrder ROTOrder, HoudiniEngineUnity.HAPI_TransformEuler& outTransform) { }
        // RVA: 0x03D6D820  token: 0x60008C8
        public virtual System.Boolean GetTotalCookCount(System.Int32 nodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean includeChildren, System.Int32& count) { }
        // RVA: 0x0115F4C0  token: 0x60008C9
        public virtual System.Boolean SetSessionSync(System.Boolean enable) { }
        // RVA: 0x0115F4C0  token: 0x60008CA
        public virtual System.Boolean GetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport) { }
        // RVA: 0x0115F4C0  token: 0x60008CB
        public virtual System.Boolean SetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport) { }
        // RVA: 0x0115F4C0  token: 0x60008CC
        public virtual System.Boolean GetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo) { }
        // RVA: 0x0115F4C0  token: 0x60008CD
        public virtual System.Boolean SetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo) { }
        // RVA: 0x0115F4C0  token: 0x60008CE
        public virtual System.Boolean SetNodeDisplay(System.Int32 node_id, System.Int32 onOff) { }

    }

    // TypeToken: 0x20000F6  // size: 0x14
    public sealed struct SessionConnectionState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.SessionConnectionState NOT_CONNECTED;  // const
        public static HoudiniEngineUnity.SessionConnectionState CONNECTED;  // const
        public static HoudiniEngineUnity.SessionConnectionState FAILED_TO_CONNECT;  // const

    }

    // TypeToken: 0x20000F7  // size: 0x14
    public sealed struct SessionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.SessionMode Socket;  // const
        public static HoudiniEngineUnity.SessionMode Pipe;  // const

    }

    // TypeToken: 0x20000F8  // size: 0x58
    public sealed class HEU_SessionData
    {
        // Fields
        public static System.Int64 INVALID_SESSION_ID;  // static @ 0x0
        public HoudiniEngineUnity.HAPI_Session _HAPISession;  // 0x10
        private System.Int32 _serverProcessID;  // 0x20
        private System.Boolean _initialized;  // 0x24
        private System.String _pipeName;  // 0x28
        private System.Int32 _port;  // 0x30
        private System.String _sessionClassType;  // 0x38
        private System.Boolean _isDefaultSession;  // 0x40
        private HoudiniEngineUnity.HEU_SessionSyncData _sessionSync;  // 0x48
        private HoudiniEngineUnity.SessionConnectionState _connectionState;  // 0x50
        private HoudiniEngineUnity.SessionMode _sessionMode;  // 0x54

        // Properties
        System.Int64 SessionID { get; /* RVA: 0x0882CC1C */ set; /* RVA: 0x03D4EC10 */ }
        System.Int32 ProcessID { get; /* RVA: 0x03D5CD90 */ set; /* RVA: 0x01003B60 */ }
        HoudiniEngineUnity.HAPI_SessionType SessionType { get; /* RVA: 0x01002730 */ set; /* RVA: 0x010410F0 */ }
        System.Boolean IsInitialized { get; /* RVA: 0x0115F4C0 */ set; /* RVA: 0x03D4F0A0 */ }
        System.Boolean IsValidSessionID { get; /* RVA: 0x0115F4C0 */ }
        System.String PipeName { get; /* RVA: 0x0882CB78 */ set; /* RVA: 0x02C92F10 */ }
        System.Int32 Port { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }
        System.Type SessionClassType { get; /* RVA: 0x0882CBA4 */ set; /* RVA: 0x0882CC6C */ }
        System.Boolean IsDefaultSession { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }
        System.Boolean IsSessionSync { get; /* RVA: 0x05ED8890 */ }
        HoudiniEngineUnity.SessionConnectionState ThisConnectionMode { get; /* RVA: 0x03D4EED0 */ set; /* RVA: 0x03D4EF20 */ }
        HoudiniEngineUnity.SessionMode ThisSessionMode { get; /* RVA: 0x03D4EEC0 */ set; /* RVA: 0x03D4EF10 */ }

        // Methods
        // RVA: 0x0882CACC  token: 0x60008CF
        public HoudiniEngineUnity.HEU_SessionSyncData GetOrCreateSessionSync() { }
        // RVA: 0x03D4EA70  token: 0x60008D0
        public HoudiniEngineUnity.HEU_SessionSyncData GetSessionSync() { }
        // RVA: 0x02692290  token: 0x60008D1
        public System.Void SetSessionSync(HoudiniEngineUnity.HEU_SessionSyncData syncData) { }
        // RVA: 0x03D5C2D0  token: 0x60008E8
        public System.Void .ctor() { }
        // RVA: 0x0882CB3C  token: 0x60008E9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000F9  // size: 0x30
    public class HEU_SessionHAPI : HoudiniEngineUnity.HEU_SessionBase
    {
        // Methods
        // RVA: 0x03D6D870  token: 0x60008EA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FA  // size: 0x10
    public static class HEU_SessionManager
    {
        // Fields
        private static HoudiniEngineUnity.HEU_SessionBase _defaultSession;  // static @ 0x0
        private static System.Collections.Generic.Dictionary<System.Int64,HoudiniEngineUnity.HEU_SessionBase> _sessionMap;  // static @ 0x8
        public static HoudiniEngineUnity.HEU_SessionManager.CreateSessionFromTypeDelegate _createSessionFromTypeDelegate;  // static @ 0x10

        // Methods
        // RVA: 0x0882D3E8  token: 0x60008EB
        public static HoudiniEngineUnity.HEU_SessionBase CreateSessionObject() { }
        // RVA: 0x0882D3A4  token: 0x60008EC
        public static HoudiniEngineUnity.HEU_SessionBase CreateSessionFromType(System.Type type) { }
        // RVA: 0x0882D764  token: 0x60008ED
        public static HoudiniEngineUnity.HEU_SessionBase GetDefaultSession() { }
        // RVA: 0x0882E9BC  token: 0x60008EE
        public static System.Void RegisterSession(System.Int64 sessionID, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0882EC00  token: 0x60008EF
        public static System.Void UnregisterSession(System.Int64 sessionID) { }
        // RVA: 0x0882DE94  token: 0x60008F0
        public static HoudiniEngineUnity.HEU_SessionBase GetSessionWithID(System.Int64 sessionID) { }
        // RVA: 0x0882EAE4  token: 0x60008F1
        public static System.Void SaveAllSessionData() { }
        // RVA: 0x0882E2AC  token: 0x60008F2
        public static System.Void LoadAllSessionData() { }
        // RVA: 0x0882E124  token: 0x60008F3
        private static System.Void InternalValidateSceneAssets() { }
        // RVA: 0x0882D964  token: 0x60008F4
        public static HoudiniEngineUnity.HEU_SessionBase GetOrCreateDefaultSession(System.Boolean bNotifyUserError) { }
        // RVA: 0x0882D324  token: 0x60008F5
        public static System.Boolean CreateInProcessSession() { }
        // RVA: 0x0882D4AC  token: 0x60008F6
        public static System.Boolean CreateThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        // RVA: 0x0882D42C  token: 0x60008F7
        public static System.Boolean CreateThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        // RVA: 0x0882D2A4  token: 0x60008F8
        public static System.Boolean CreateCustomSession() { }
        // RVA: 0x0882D224  token: 0x60008F9
        public static System.Boolean ConnectThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout) { }
        // RVA: 0x0882D1A4  token: 0x60008FA
        public static System.Boolean ConnectThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout) { }
        // RVA: 0x0882E958  token: 0x60008FB
        public static System.Void RecreateDefaultSessionData() { }
        // RVA: 0x0882D128  token: 0x60008FC
        public static System.Boolean ConnectSessionSyncUsingThriftSocket(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        // RVA: 0x0882D0AC  token: 0x60008FD
        public static System.Boolean ConnectSessionSyncUsingThriftPipe(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        // RVA: 0x0882E0BC  token: 0x60008FE
        public static System.Boolean InitializeDefaultSession() { }
        // RVA: 0x0882D010  token: 0x60008FF
        public static System.Boolean CloseDefaultSession() { }
        // RVA: 0x0882CD6C  token: 0x6000900
        public static System.Void CloseAllSessions() { }
        // RVA: 0x0882CC9C  token: 0x6000901
        private static System.Void CheckAndCloseExistingSession() { }
        // RVA: 0x0882DDF0  token: 0x6000902
        public static HoudiniEngineUnity.HEU_SessionData GetSessionData() { }
        // RVA: 0x0882DE34  token: 0x6000903
        public static System.String GetSessionInfo() { }
        // RVA: 0x0882E750  token: 0x6000904
        public static System.Boolean LoadStoredDefaultSession() { }
        // RVA: 0x0882EA40  token: 0x6000905
        public static System.Boolean RestartSession() { }
        // RVA: 0x0882EC78  token: 0x6000906
        public static System.Boolean ValidatePluginSession(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0882D84C  token: 0x6000907
        public static System.String GetLastSessionError() { }
        // RVA: 0x0882CD30  token: 0x6000908
        public static System.Boolean CheckVersionMatch() { }
        // RVA: 0x0232EB60  token: 0x6000909
        public static System.Boolean ClearConnectionError() { }
        // RVA: 0x0882D6F4  token: 0x600090A
        public static System.String GetConnectionError(System.Boolean clear) { }
        // RVA: 0x0882E230  token: 0x600090B
        public static System.Boolean IsHARSProcessRunning(System.Int32 processID) { }
        // RVA: 0x0882E6DC  token: 0x600090C
        public static System.Boolean LoadSessionFromHIP(System.Boolean bCookNodes, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0882EB8C  token: 0x600090D
        public static System.Boolean SaveSessionToHIP(System.Boolean bLockNodes, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0339AE90  token: 0x600090E
        public static System.String GetHoudiniPathOnMacOS(System.String houdiniPath) { }
        // RVA: 0x0882E7C0  token: 0x600090F
        public static System.Boolean OpenHoudini(System.String args) { }
        // RVA: 0x0882E874  token: 0x6000910
        public static System.Boolean OpenSessionInHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0882D720  token: 0x6000911
        public static HoudiniEngineUnity.HAPI_License GetCurrentLicense(System.Boolean bLogError) { }
        // RVA: 0x0882DFEC  token: 0x6000912
        public static System.String GetString(System.Int32 stringHandle, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0882DF14  token: 0x6000913
        public static System.String[] GetStringValuesFromStringIndices(System.Int32[] strIndices) { }
        // RVA: 0x0882D80C  token: 0x6000914
        public static System.String[] GetGroupNames(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Boolean isInstanced) { }
        // RVA: 0x0882D7D4  token: 0x6000915
        public static System.Boolean GetGroupMembership(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[]& membership, System.Boolean isInstanced) { }
        // RVA: 0x0882D904  token: 0x6000916
        public static System.String GetNodeName(System.Int32 nodeID, HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0882D8A4  token: 0x6000917
        public static System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.String& inputName) { }
        // RVA: 0x0882D52C  token: 0x6000918
        public static System.Boolean GetComposedChildNodeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32[]& childNodeIDs, System.Boolean bLogIfError) { }
        // RVA: 0x0882D578  token: 0x6000919
        public static System.Boolean GetComposedObjectListMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0882D634  token: 0x600091A
        public static System.Boolean GetComposedObjectTransformsMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length) { }
        // RVA: 0x0882E054  token: 0x600091B
        public static System.String GetUniqueMaterialShopName(System.Int32 assetID, System.Int32 materialID) { }
        // RVA: 0x0882ECC0  token: 0x600091C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000FC  // size: 0x10
    public static class HEU_SessionPDG
    {
    }

    // TypeToken: 0x20000FD  // size: 0x68
    public class HEU_SessionSyncData
    {
        // Fields
        private System.Int32 _status;  // 0x10
        public System.Single _timeLastUpdate;  // 0x14
        public System.Single _timeStartConnection;  // 0x18
        public System.String _newNodeName;  // 0x20
        public System.Int32 _nodeTypeIndex;  // 0x28
        public System.Boolean _validForConnection;  // 0x2c
        public HoudiniEngineUnity.HAPI_Viewport _viewportHAPI;  // 0x30
        public HoudiniEngineUnity.HAPI_Viewport _viewportLocal;  // 0x48
        public System.Boolean _viewportJustUpdated;  // 0x60
        public HoudiniEngineUnity.HAPI_SessionSyncInfo _syncInfo;  // 0x61

        // Properties
        HoudiniEngineUnity.HEU_SessionSyncData.Status SyncStatus { get; /* RVA: 0x0882EE0C */ set; /* RVA: 0x03D6D880 */ }

        // Methods
        // RVA: 0x0882ED54  token: 0x6000923
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF  // size: 0x98
    public class HEU_AssetSync : HoudiniEngineUnity.HEU_BaseSync
    {
        // Fields
        public HoudiniEngineUnity.HEU_AssetSync.AssetSyncCallback _onAssetLoaded;  // 0x88
        public System.String _assetPath;  // 0x90

        // Methods
        // RVA: 0x0350B670  token: 0x6000924
        private System.Void OnEnable() { }
        // RVA: 0x088207A8  token: 0x6000925
        private System.Void OnDestroy() { }
        // RVA: 0x088206D0  token: 0x6000926
        public System.Void InitializeAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.String nodeName, UnityEngine.Transform parent, UnityEngine.Vector3 startPosition) { }
        // RVA: 0x08820674  token: 0x6000927
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo CreateThreadedTask() { }
        // RVA: 0x08820818  token: 0x6000928
        public System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback) { }
        // RVA: 0x0882086C  token: 0x6000929
        protected virtual System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x088207B0  token: 0x600092A
        public virtual System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        // RVA: 0x088207EC  token: 0x600092B
        public virtual System.Void Resync() { }
        // RVA: 0x088208E4  token: 0x600092C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000101  // size: 0x28
    public class HEU_SyncedEventData
    {
        // Fields
        public System.Boolean CookSuccess;  // 0x10
        public HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData TopNodeData;  // 0x18
        public HoudiniEngineUnity.HEU_BaseSync OutputObject;  // 0x20

        // Methods
        // RVA: 0x0882EE1C  token: 0x6000931
        public System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HoudiniEngineUnity.HEU_BaseSync bOutputObject) { }

    }

    // TypeToken: 0x2000102  // size: 0x88
    public class HEU_BaseSync : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Int32 _cookNodeID;  // 0x18
        public System.Int64 _sessionID;  // 0x20
        public System.String _nodeName;  // 0x28
        public System.Boolean _initialized;  // 0x30
        public System.Boolean _syncing;  // 0x31
        public System.Boolean _deleteParent;  // 0x32
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> _generatedOutputs;  // 0x38
        public System.String _outputCacheDirectory;  // 0x40
        public System.Collections.Generic.List<System.String> _outputCacheFilePaths;  // 0x48
        public HoudiniEngineUnity.HEU_GenerateOptions _generateOptions;  // 0x50
        public System.Text.StringBuilder _log;  // 0x58
        public System.Text.StringBuilder _error;  // 0x60
        public System.Boolean _sessionSyncAutoCook;  // 0x68
        private System.Action<HoudiniEngineUnity.HEU_SyncedEventData> _onSynced;  // 0x70
        protected HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo _loadTask;  // 0x78
        protected System.Int32 _totalCookCount;  // 0x80
        protected System.Boolean _firstSyncComplete;  // 0x84

        // Properties
        System.Action<HoudiniEngineUnity.HEU_SyncedEventData> OnSynced { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000932
        private System.Void Awake() { }
        // RVA: 0x088207A8  token: 0x6000933
        private System.Void OnDestroy() { }
        // RVA: 0x0882189C  token: 0x6000934
        public virtual System.Void DeleteSessionData() { }
        // RVA: 0x088218C0  token: 0x6000935
        public virtual System.Void DestroyGeneratedData() { }
        // RVA: 0x03D6D6C0  token: 0x6000936
        protected virtual System.Void Initialize() { }
        // RVA: 0x088247E4  token: 0x6000937
        public virtual HoudiniEngineUnity.HEU_SessionBase GetHoudiniSession(System.Boolean bCreateIfNotFound) { }
        // RVA: 0x088248E8  token: 0x6000938
        private System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08824918  token: 0x6000939
        public System.Void Log(System.String msg) { }
        // RVA: 0x088214FC  token: 0x600093A
        public System.Void ClearLog() { }
        // RVA: 0x08821B08  token: 0x600093B
        public System.Void Error(System.String error) { }
        // RVA: 0x08824904  token: 0x600093C
        public System.Boolean IsLoaded() { }
        // RVA: 0x08824E54  token: 0x600093D
        public virtual System.Void StartSync() { }
        // RVA: 0x0350B670  token: 0x600093E
        protected virtual System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08824F18  token: 0x600093F
        public virtual System.Void StopSync() { }
        // RVA: 0x08824C48  token: 0x6000940
        public virtual System.Void Resync() { }
        // RVA: 0x088211C4  token: 0x6000941
        public virtual System.Void Bake() { }
        // RVA: 0x08824F74  token: 0x6000942
        public virtual System.Void Unload() { }
        // RVA: 0x08824B9C  token: 0x6000943
        public virtual System.Void Reset() { }
        // RVA: 0x088249DC  token: 0x6000944
        public virtual System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        // RVA: 0x088233E0  token: 0x6000945
        public virtual System.Void GenerateObjects(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        // RVA: 0x08821BD8  token: 0x6000946
        public virtual System.Void GenerateGeometry(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, System.Int32 objIndex) { }
        // RVA: 0x08824AE0  token: 0x6000947
        public System.Void OnStopped(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        // RVA: 0x08823460  token: 0x6000948
        private System.Void GenerateTerrain(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> terrainBuffers) { }
        // RVA: 0x08822E48  token: 0x6000949
        private System.Void GenerateMesh(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh> meshBuffers) { }
        // RVA: 0x08821B28  token: 0x600094A
        private System.Void GenerateAllInstancers(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer> instancerBuffers, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        // RVA: 0x08821CE0  token: 0x600094B
        private System.Void GenerateInstancer(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap) { }
        // RVA: 0x088227B0  token: 0x600094C
        private System.Void GenerateInstancesFromNodeIDs(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap, UnityEngine.Transform instanceRootTransform) { }
        // RVA: 0x08821F78  token: 0x600094D
        private System.Void GenerateInstancesFromAssetPaths(HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, UnityEngine.Transform instanceRootTransform) { }
        // RVA: 0x08821718  token: 0x600094E
        private System.Void CreateNewInstanceFromObject(UnityEngine.GameObject assetSourceGO, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.String[] instancePrefixes, System.String instanceName, UnityEngine.GameObject collisionSourceGO) { }
        // RVA: 0x0882114C  token: 0x600094F
        private System.Void ApplyAttributeModifiersOnGameObjectOutput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partId, UnityEngine.GameObject& go) { }
        // RVA: 0x088218C8  token: 0x6000950
        private System.Void DestroyOutputs() { }
        // RVA: 0x08824C74  token: 0x6000951
        private System.Void SetOutputVisiblity(HoudiniEngineUnity.HEU_LoadBufferBase buffer) { }
        // RVA: 0x0882488C  token: 0x6000952
        private System.String GetOutputCacheDirectory() { }
        // RVA: 0x03CB2D80  token: 0x6000953
        public System.Void SetOutputCacheDirectory(System.String directory) { }
        // RVA: 0x088210C4  token: 0x6000954
        private System.Void AddGeneratedOutputFilePath(System.String path) { }
        // RVA: 0x0350B670  token: 0x6000955
        public virtual System.Void SyncUpdate() { }
        // RVA: 0x08824FE8  token: 0x6000958
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000103  // size: 0x15
    public sealed struct HEU_GenerateOptions
    {
        // Fields
        public System.Boolean _generateUVs;  // 0x10
        public System.Boolean _generateTangents;  // 0x11
        public System.Boolean _generateNormals;  // 0x12
        public System.Boolean _useLODGroups;  // 0x13
        public System.Boolean _splitPoints;  // 0x14

    }

    // TypeToken: 0x2000104  // size: 0x90
    public class HEU_GeoSync : HoudiniEngineUnity.HEU_BaseSync
    {
        // Fields
        public System.String _filePath;  // 0x88

        // Methods
        // RVA: 0x08825170  token: 0x6000959
        protected virtual System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08825224  token: 0x600095A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000105  // size: 0x90
    public class HEU_NodeSync : HoudiniEngineUnity.HEU_BaseSync
    {
        // Fields
        public System.String _nodeSaveFilePath;  // 0x88

        // Methods
        // RVA: 0x0350B670  token: 0x600095B
        private System.Void OnEnable() { }
        // RVA: 0x088207A8  token: 0x600095C
        private System.Void OnDestroy() { }
        // RVA: 0x08827BC4  token: 0x600095D
        public System.Void InitializeFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.String nodeName, System.String filePath) { }
        // RVA: 0x08827CC8  token: 0x600095E
        protected virtual System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x08827C4C  token: 0x600095F
        public System.Boolean SaveNodeToFile(System.String filePath) { }
        // RVA: 0x08827B20  token: 0x6000960
        public static System.Void CreateNodeSync(HoudiniEngineUnity.HEU_SessionBase session, System.String opName, System.String nodeNabel) { }
        // RVA: 0x088207EC  token: 0x6000961
        public virtual System.Void Resync() { }
        // RVA: 0x08827D78  token: 0x6000962
        public virtual System.Void SyncUpdate() { }
        // RVA: 0x088208E4  token: 0x6000963
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000106  // size: 0x30
    public abstract class HEU_Task
    {
        // Fields
        public HoudiniEngineUnity.HEU_Task.TaskStatus _status;  // 0x10
        public HoudiniEngineUnity.HEU_Task.TaskResult _result;  // 0x14
        private System.Guid _guid;  // 0x18
        public HoudiniEngineUnity.HEU_Task.TaskCallback _taskCompletedDelegate;  // 0x28

        // Properties
        System.Guid TaskGuid { get; /* RVA: 0x03D51D80 */ }

        // Methods
        // RVA: 0x0882F754  token: 0x6000965
        public System.Void .ctor() { }
        // RVA: -1  // abstract  token: 0x6000966
        public virtual System.Void DoTask() { }
        // RVA: 0x0350B670  token: 0x6000967
        public virtual System.Void UpdateTask() { }
        // RVA: -1  // abstract  token: 0x6000968
        public virtual System.Void KillTask() { }
        // RVA: -1  // abstract  token: 0x6000969
        public virtual System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result) { }

    }

    // TypeToken: 0x200010A  // size: 0x60
    public class HEU_AssetTask : HoudiniEngineUnity.HEU_Task
    {
        // Fields
        public HoudiniEngineUnity.HEU_AssetTask.BuildType _buildType;  // 0x30
        public HoudiniEngineUnity.HEU_HoudiniAsset _asset;  // 0x38
        public System.String _assetPath;  // 0x40
        public UnityEngine.Vector3 _position;  // 0x48
        public System.Boolean _buildResult;  // 0x54
        public System.Int64 _forceSessionID;  // 0x58

        // Methods
        // RVA: 0x08820E68  token: 0x600096E
        public HoudiniEngineUnity.HEU_SessionBase GetTaskSession() { }
        // RVA: 0x08820ACC  token: 0x600096F
        public virtual System.Void DoTask() { }
        // RVA: 0x08820EF8  token: 0x6000970
        public virtual System.Void KillTask() { }
        // RVA: 0x088208EC  token: 0x6000971
        public virtual System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result) { }
        // RVA: 0x08820A70  token: 0x6000972
        private System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputs) { }
        // RVA: 0x08820A48  token: 0x6000973
        private System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_CookedEventData cookedEventData) { }
        // RVA: 0x08820A48  token: 0x6000974
        private System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData) { }
        // RVA: 0x08821054  token: 0x6000975
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010C  // size: 0x10
    public class HEU_TaskManager
    {
        // Fields
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task> _tasks;  // static @ 0x0
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task> _pendingAdd;  // static @ 0x8
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task> _pendingRemove;  // static @ 0x10

        // Methods
        // RVA: 0x0882F628  token: 0x6000976
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000977
        private static System.Void Update() { }
        // RVA: 0x0882F238  token: 0x6000978
        public static HoudiniEngineUnity.HEU_Task GetTask(System.Guid taskGuid) { }
        // RVA: 0x0882F0E8  token: 0x6000979
        public static System.Void AddTask(HoudiniEngineUnity.HEU_Task task) { }
        // RVA: 0x0882F400  token: 0x600097A
        public static System.Void KillTask(HoudiniEngineUnity.HEU_Task task, System.Boolean bRemove) { }
        // RVA: 0x0882F4C0  token: 0x600097B
        public static System.Void KillTask(System.Guid taskGuid, System.Boolean bRemove) { }
        // RVA: 0x0882F53C  token: 0x600097C
        public static System.Void RemoveTask(HoudiniEngineUnity.HEU_Task task) { }
        // RVA: 0x0882F204  token: 0x600097D
        public static System.Void ExecuteTask(HoudiniEngineUnity.HEU_Task task) { }
        // RVA: 0x0882F1E0  token: 0x600097E
        public static System.Void CompleteTask(HoudiniEngineUnity.HEU_Task task, HoudiniEngineUnity.HEU_Task.TaskResult result) { }
        // RVA: 0x0882F3B0  token: 0x600097F
        private static System.Void InternalCompleteTask(HoudiniEngineUnity.HEU_Task task) { }
        // RVA: 0x0350B670  token: 0x6000980
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010D  // size: 0x30
    public class HEU_LoadBufferBase
    {
        // Fields
        public System.Int32 _id;  // 0x10
        public System.String _name;  // 0x18
        public System.Boolean _bInstanced;  // 0x20
        public System.Boolean _bInstancer;  // 0x21
        public HoudiniEngineUnity.HEU_GeneratedOutput _generatedOutput;  // 0x28

        // Methods
        // RVA: 0x0883F828  token: 0x6000981
        public System.Void InitializeBuffer(System.Int32 id, System.String name, System.Boolean bInstanced, System.Boolean bInstancer) { }
        // RVA: 0x0350B670  token: 0x6000982
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010E  // size: 0x48
    public class HEU_LoadBufferMesh : HoudiniEngineUnity.HEU_LoadBufferBase
    {
        // Fields
        public HoudiniEngineUnity.HEU_GenerateGeoCache _geoCache;  // 0x30
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup> _LODGroupMeshes;  // 0x38
        public System.Int32 _defaultMaterialKey;  // 0x40
        public System.Boolean _bGenerateUVs;  // 0x44
        public System.Boolean _bGenerateTangents;  // 0x45
        public System.Boolean _bGenerateNormals;  // 0x46
        public System.Boolean _bPartInstanced;  // 0x47

        // Methods
        // RVA: 0x0350B670  token: 0x6000983
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010F  // size: 0xA8
    public class HEU_LoadBufferVolume : HoudiniEngineUnity.HEU_LoadBufferBase
    {
        // Fields
        public System.Int32 _tileIndex;  // 0x30
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolumeLayer> _splatLayers;  // 0x38
        public System.Int32 _heightMapWidth;  // 0x40
        public System.Int32 _heightMapHeight;  // 0x44
        public System.Single[,] _heightMap;  // 0x48
        public System.Single[,,] _splatMaps;  // 0x50
        public System.Single _terrainSizeX;  // 0x58
        public System.Single _terrainSizeY;  // 0x5c
        public System.Single _heightRange;  // 0x60
        public UnityEngine.Vector3 _position;  // 0x64
        public System.String _terrainDataPath;  // 0x70
        public System.String _terrainDataExportPath;  // 0x78
        public HoudiniEngineUnity.HEU_VolumeScatterTrees _scatterTrees;  // 0x80
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype> _detailPrototypes;  // 0x88
        public System.Collections.Generic.List<System.Int32[,]> _detailMaps;  // 0x90
        public HoudiniEngineUnity.HEU_DetailProperties _detailProperties;  // 0x98
        public System.String _specifiedTerrainMaterialName;  // 0xa0

        // Methods
        // RVA: 0x0883F88C  token: 0x6000984
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000110  // size: 0xD8
    public class HEU_LoadBufferVolumeLayer
    {
        // Fields
        public System.String _layerName;  // 0x10
        public System.Int32 _partID;  // 0x18
        public System.Int32 _heightMapWidth;  // 0x1c
        public System.Int32 _heightMapHeight;  // 0x20
        public System.Single _strength;  // 0x24
        public System.String _diffuseTexturePath;  // 0x28
        public System.String _maskTexturePath;  // 0x30
        public System.Single _metallic;  // 0x38
        public System.String _normalTexturePath;  // 0x40
        public System.Single _normalScale;  // 0x48
        public System.Single _smoothness;  // 0x4c
        public UnityEngine.Color _specularColor;  // 0x50
        public UnityEngine.Vector2 _tileSize;  // 0x60
        public UnityEngine.Vector2 _tileOffset;  // 0x68
        public System.Boolean _uiExpanded;  // 0x70
        public System.Int32 _tile;  // 0x74
        public System.Single[] _normalizedHeights;  // 0x78
        public System.Single _minHeight;  // 0x80
        public System.Single _maxHeight;  // 0x84
        public System.Single _heightRange;  // 0x88
        public System.Single _terrainSizeX;  // 0x8c
        public System.Single _terrainSizeY;  // 0x90
        public UnityEngine.Vector3 _position;  // 0x94
        public UnityEngine.Vector3 _minBounds;  // 0xa0
        public UnityEngine.Vector3 _maxBounds;  // 0xac
        public UnityEngine.Vector3 _center;  // 0xb8
        public System.String _layerPath;  // 0xc8
        public System.Boolean _hasLayerAttributes;  // 0xd0
        public HoudiniEngineUnity.HFLayerType _layerType;  // 0xd4

        // Methods
        // RVA: 0x0883F854  token: 0x6000985
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000111  // size: 0x58
    public class HEU_LoadBufferInstancer : HoudiniEngineUnity.HEU_LoadBufferBase
    {
        // Fields
        public HoudiniEngineUnity.HAPI_Transform[] _instanceTransforms;  // 0x30
        public System.String[] _instancePrefixes;  // 0x38
        public System.Int32[] _instanceNodeIDs;  // 0x40
        public System.String[] _assetPaths;  // 0x48
        public System.String[] _collisionAssetPaths;  // 0x50

        // Methods
        // RVA: 0x0350B670  token: 0x6000986
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000112  // size: 0x38
    public class HEU_ThreadedTask
    {
        // Fields
        private System.Boolean _isComplete;  // 0x10
        private System.Boolean _isActive;  // 0x11
        private System.Boolean _stopRequested;  // 0x12
        private System.Object _lockHandle;  // 0x18
        private System.Threading.Thread _thread;  // 0x20
        private System.Threading.ThreadPriority _priority;  // 0x28
        private System.Boolean _isBackground;  // 0x2c
        protected System.String _name;  // 0x30

        // Properties
        System.String TaskName { get; /* RVA: 0x01003830 */ }
        System.Boolean IsComplete { get; /* RVA: 0x088447DC */ set; /* RVA: 0x088449E0 */ }
        System.Boolean IsActive { get; /* RVA: 0x08844730 */ set; /* RVA: 0x08844934 */ }
        System.Boolean StopRequested { get; /* RVA: 0x08844888 */ set; /* RVA: 0x08844A8C */ }
        System.Threading.ThreadPriority Priority { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        System.Boolean IsBackground { get; /* RVA: 0x03D4F1A0 */ set; /* RVA: 0x03D4F1B0 */ }

        // Methods
        // RVA: 0x088444F4  token: 0x6000987
        public virtual System.Void Start() { }
        // RVA: 0x08844644  token: 0x6000988
        public virtual System.Void Stop() { }
        // RVA: 0x08844404  token: 0x6000989
        public virtual System.Void Abort() { }
        // RVA: 0x08844434  token: 0x600098A
        public virtual System.Void Reset() { }
        // RVA: 0x08844684  token: 0x600098B
        public virtual System.Void Update() { }
        // RVA: 0x0350B670  token: 0x600098C
        protected virtual System.Void DoWork() { }
        // RVA: 0x0350B670  token: 0x600098D
        protected virtual System.Void OnComplete() { }
        // RVA: 0x0350B670  token: 0x600098E
        protected virtual System.Void OnStopped() { }
        // RVA: 0x0350B670  token: 0x600098F
        protected virtual System.Void CleanUp() { }
        // RVA: 0x088444CC  token: 0x6000990
        private System.Void Run() { }
        // RVA: 0x088446DC  token: 0x600099C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000113  // size: 0x78
    public class HEU_ThreadedTaskLoadGeo : HoudiniEngineUnity.HEU_ThreadedTask
    {
        // Fields
        private HoudiniEngineUnity.HEU_BaseSync _ownerSync;  // 0x38
        private HoudiniEngineUnity.HEU_SessionBase _session;  // 0x40
        private HoudiniEngineUnity.HEU_GenerateOptions _generateOptions;  // 0x48
        protected System.String _assetCachePath;  // 0x50
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType _loadType;  // 0x58
        private System.String _filePath;  // 0x60
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData _loadData;  // 0x68
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback _loadCallback;  // 0x70

        // Methods
        // RVA: 0x08844268  token: 0x600099D
        public System.Void SetupLoad(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType loadType, System.Int32 cookNodeID, System.String name, System.String filePath) { }
        // RVA: 0x08844238  token: 0x600099E
        public System.Void SetupLoadNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String name) { }
        // RVA: 0x08844208  token: 0x600099F
        public System.Void SetupLoadFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String filePath) { }
        // RVA: 0x088441D4  token: 0x60009A0
        public System.Void SetupLoadAsset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.String assetPath, System.String name) { }
        // RVA: 0x0519C3C8  token: 0x60009A1
        public System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback loadCallback) { }
        // RVA: 0x08840A58  token: 0x60009A2
        protected virtual System.Void DoWork() { }
        // RVA: 0x08840680  token: 0x60009A3
        protected virtual System.Boolean CookNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 cookNodeID) { }
        // RVA: 0x08843CC4  token: 0x60009A4
        protected virtual System.Boolean LoadObjectBuffers(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo) { }
        // RVA: 0x088439D4  token: 0x60009A5
        protected virtual System.Boolean LoadNodeBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject) { }
        // RVA: 0x08840140  token: 0x60009A6
        protected virtual System.Void BuildBufferIDsMap(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        // RVA: 0x088408F0  token: 0x60009A7
        public virtual System.Boolean DoFileLoad() { }
        // RVA: 0x088407F0  token: 0x60009A8
        public virtual System.Boolean DoAssetLoad() { }
        // RVA: 0x08843E98  token: 0x60009A9
        private System.Boolean QueryParts(System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& curveParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& scatterInstancerParts) { }
        // RVA: 0x08843DA0  token: 0x60009AA
        protected virtual System.Void OnComplete() { }
        // RVA: 0x08843E28  token: 0x60009AB
        protected virtual System.Void OnStopped() { }
        // RVA: 0x08582664  token: 0x60009AC
        protected virtual System.Void CleanUp() { }
        // RVA: 0x08840764  token: 0x60009AD
        private System.String CreateLogString(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr) { }
        // RVA: 0x08840018  token: 0x60009AE
        private System.Void AppendLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr) { }
        // RVA: 0x08843F58  token: 0x60009AF
        private System.Void SetLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr) { }
        // RVA: 0x0884070C  token: 0x60009B0
        private System.Boolean CreateFileNode(System.Int32& fileNodeID) { }
        // RVA: 0x08843524  token: 0x60009B1
        public virtual System.Int32 GetCookNodeID() { }
        // RVA: 0x08843540  token: 0x60009B2
        private System.Int32 GetDisplayNodeID(System.Int32 objNodeID) { }
        // RVA: 0x08843F1C  token: 0x60009B3
        private System.Boolean SetFileParm(System.Int32 fileNodeID, System.String filePath) { }
        // RVA: 0x088443B0  token: 0x60009B4
        private System.Void Sleep() { }
        // RVA: 0x08841958  token: 0x60009B5
        public System.Boolean GenerateTerrainBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> scatterInstancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume>& volumeBuffers) { }
        // RVA: 0x08843D18  token: 0x60009B6
        private System.Void LoadStringFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String& strValue) { }
        // RVA: 0x08843684  token: 0x60009B7
        private System.Void LoadFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue) { }
        // RVA: 0x08843774  token: 0x60009B8
        private System.Void LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue) { }
        // RVA: 0x088438C4  token: 0x60009B9
        private System.Void LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue) { }
        // RVA: 0x08840E98  token: 0x60009BA
        public System.Boolean GenerateMeshBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> meshParts, System.Boolean bSplitPoints, System.Boolean bUseLODGroups, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh>& meshBuffers) { }
        // RVA: 0x08840AF8  token: 0x60009BB
        public System.Boolean GenerateInstancerBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer>& instancerBuffers) { }
        // RVA: 0x08841538  token: 0x60009BC
        private HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo) { }
        // RVA: 0x08841810  token: 0x60009BD
        private HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo) { }
        // RVA: 0x0884355C  token: 0x60009BE
        public static HoudiniEngineUnity.HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(System.Int32 tileIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> buffers) { }
        // RVA: 0x08843678  token: 0x60009BF
        public static System.String GetValidAssetCacheFolderPath(System.String name) { }
        // RVA: 0x088443BC  token: 0x60009C0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011A  // size: 0x28
    public class HEU_ThreadManager
    {
        // Fields
        private static HoudiniEngineUnity.HEU_ThreadManager _instance;  // static @ 0x0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask> _tasks;  // 0x10
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask> _pendingAdd;  // 0x18
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask> _pendingRemove;  // 0x20

        // Properties
        HoudiniEngineUnity.HEU_ThreadManager Instance { get; /* RVA: 0x0883FFE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60009C8
        private static System.Void CreateInstance() { }
        // RVA: 0x0883FAC8  token: 0x60009C9
        protected virtual System.Void Finalize() { }
        // RVA: 0x0350B670  token: 0x60009CA
        public System.Void Register() { }
        // RVA: 0x0350B670  token: 0x60009CB
        public System.Void Unregister() { }
        // RVA: 0x0883FBB4  token: 0x60009CC
        public System.Void Update() { }
        // RVA: 0x0883FA2C  token: 0x60009CD
        public System.Void AddTask(HoudiniEngineUnity.HEU_ThreadedTask task) { }
        // RVA: 0x0883FB18  token: 0x60009CE
        public System.Void RemoveTask(HoudiniEngineUnity.HEU_ThreadedTask task) { }
        // RVA: 0x0883FF04  token: 0x60009CF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011B  // size: 0x30
    public class HEU_CookLogs
    {
        // Fields
        private static HoudiniEngineUnity.HEU_CookLogs _instance;  // static @ 0x0
        private System.Text.StringBuilder _cookLogs;  // 0x10
        private System.Int32 _currentCookLogCount;  // 0x18
        private static System.Int32 MAX_COOK_LOG_COUNT;  // const
        private System.String _lastLogStr;  // 0x20
        private System.Boolean _uniqueStrOnly;  // 0x28
        public static System.Int64 MaxLogSize;  // const

        // Properties
        HoudiniEngineUnity.HEU_CookLogs Instance { get; /* RVA: 0x0882FF04 */ }

        // Methods
        // RVA: 0x07ABAEF4  token: 0x60009D1
        public System.String GetCookLogString() { }
        // RVA: 0x0882F954  token: 0x60009D2
        public System.Void AppendCookLog(System.String logStr) { }
        // RVA: 0x0882FA70  token: 0x60009D3
        public System.Void ClearCookLog() { }
        // RVA: 0x0882FB64  token: 0x60009D4
        public System.String GetCookLogFilePath() { }
        // RVA: 0x0882FADC  token: 0x60009D5
        public System.Void DeleteCookingFile() { }
        // RVA: 0x0882FC9C  token: 0x60009D6
        public System.Void WriteToLogFile(System.String logStr, System.Boolean checkLastLogStr) { }
        // RVA: 0x0882FC14  token: 0x60009D7
        public System.Int64 GetFileSizeOfLogFile() { }
        // RVA: 0x0882FE78  token: 0x60009D8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011C  // size: 0x10
    public static class HEU_EditorUtility
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60009D9
        public static System.Void MarkSceneDirty() { }
        // RVA: 0x0350B670  token: 0x60009DA
        public static System.Void SelectObject(UnityEngine.GameObject gameObject) { }
        // RVA: 0x0350B670  token: 0x60009DB
        public static System.Void SelectObjects(UnityEngine.GameObject[] gameObjects) { }
        // RVA: 0x04274B08  token: 0x60009DC
        public static UnityEngine.Vector3 GetSelectedObjectsMeanPosition() { }
        // RVA: 0x088307E8  token: 0x60009DD
        public static UnityEngine.Matrix4x4 GetSelectedObjectsMeanTransform() { }
        // RVA: 0x08830AF8  token: 0x60009DE
        public static UnityEngine.GameObject SaveAsPrefabAsset(System.String path, UnityEngine.GameObject go) { }
        // RVA: 0x0115F4C0  token: 0x60009DF
        public static System.Boolean PrefabIsAddedComponentOverride(UnityEngine.Component comp) { }
        // RVA: 0x0115F4C0  token: 0x60009E0
        public static System.Boolean IsEditorPlaying() { }
        // RVA: 0x08830AC0  token: 0x60009E1
        public static UnityEngine.GameObject ReplacePrefab(UnityEngine.GameObject go, UnityEngine.Object targetPrefab, HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions heuOptions) { }
        // RVA: 0x088309AC  token: 0x60009E2
        public static System.Boolean IsPrefabInstance(UnityEngine.GameObject go) { }
        // RVA: 0x08830974  token: 0x60009E3
        public static System.Boolean IsPrefabAsset(UnityEngine.GameObject go) { }
        // RVA: 0x0115F4C0  token: 0x60009E4
        public static System.Boolean IsEditingInPrefabMode(UnityEngine.GameObject obj) { }
        // RVA: 0x08830904  token: 0x60009E5
        public static System.Boolean IsDisconnectedPrefabInstance(UnityEngine.GameObject go) { }
        // RVA: 0x08830738  token: 0x60009E6
        public static UnityEngine.Object GetPrefabAsset(UnityEngine.GameObject go) { }
        // RVA: 0x08830700  token: 0x60009E7
        public static System.String GetPrefabAssetPath(UnityEngine.Object obj) { }
        // RVA: 0x088301CC  token: 0x60009E8
        public static System.Void DisconnectPrefabInstance(UnityEngine.GameObject instance) { }
        // RVA: 0x088308CC  token: 0x60009E9
        public static UnityEngine.Object InstantiatePrefab(UnityEngine.GameObject prefabOriginal) { }
        // RVA: 0x0883085C  token: 0x60009EA
        public static UnityEngine.GameObject InstantiateGameObject(UnityEngine.GameObject sourceGameObject, UnityEngine.Transform parentTransform, System.Boolean instantiateInWorldSpace, System.Boolean bRegisterUndo) { }
        // RVA: -1  // generic def  token: 0x60009EB
        public static UnityEngine.Component AddComponent(UnityEngine.GameObject target, System.Boolean bRegisterUndo) { }
        // RVA: 0x0350B670  token: 0x60009EC
        public static System.Void UndoRecordObject(UnityEngine.Object objectToUndo, System.String name) { }
        // RVA: 0x0350B670  token: 0x60009ED
        public static System.Void UndoCollapseCurrentGroup() { }
        // RVA: 0x088300B8  token: 0x60009EE
        public static UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj) { }
        // RVA: 0x0883093C  token: 0x60009EF
        public static System.Boolean IsPersistant(UnityEngine.Object obj) { }
        // RVA: 0x08830824  token: 0x60009F0
        public static System.String GetUniqueNameForSibling(UnityEngine.Transform parentTransform, System.String name) { }
        // RVA: 0x088302C8  token: 0x60009F1
        public static System.Void DisplayProgressBar(System.String title, System.String info, System.Single progress) { }
        // RVA: 0x08830084  token: 0x60009F2
        public static System.Void ClearProgressBar() { }
        // RVA: 0x03D4E3A0  token: 0x60009F3
        public static System.Boolean IsEditorNotInPlayModeAndNotGoingToPlayMode() { }
        // RVA: 0x08830200  token: 0x60009F4
        public static System.Boolean DisplayDialog(System.String title, System.String message, System.String ok, System.String cancel) { }
        // RVA: 0x08830258  token: 0x60009F5
        public static System.Boolean DisplayErrorDialog(System.String title, System.String message, System.String ok, System.String cancel) { }
        // RVA: 0x0350B670  token: 0x60009F6
        public static System.Void RevealInFinder(System.String path) { }
        // RVA: 0x0350B670  token: 0x60009F7
        public static System.Void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj) { }
        // RVA: 0x0350B670  token: 0x60009F8
        public static System.Void SetStatic(UnityEngine.GameObject go, System.Boolean bStatic, System.Boolean bIncludeChildren) { }
        // RVA: 0x0350B670  token: 0x60009F9
        public static System.Void SetIsHidden(UnityEngine.GameObject go, System.Boolean isHidden, System.Boolean bIncludeChildren) { }
        // RVA: 0x01002730  token: 0x60009FA
        public static UnityEngine.GameObject[] GetSelectedObjects() { }
        // RVA: 0x08830770  token: 0x60009FB
        public static HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetSelectedAssetRoots() { }
        // RVA: 0x08830654  token: 0x60009FC
        public static HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetAllAssetRoots() { }
        // RVA: 0x088301B0  token: 0x60009FD
        public static System.Void CookSelected() { }
        // RVA: 0x088300F0  token: 0x60009FE
        public static System.Void CookAll() { }
        // RVA: 0x0883010C  token: 0x60009FF
        public static System.Void CookAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        // RVA: 0x08830AA4  token: 0x6000A00
        public static System.Void RebuildSelected() { }
        // RVA: 0x088309E4  token: 0x6000A01
        public static System.Void RebuildAll() { }
        // RVA: 0x08830A00  token: 0x6000A02
        public static System.Void RebuildAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        // RVA: 0x08830068  token: 0x6000A03
        public static System.Void BakeAndReplaceSelectedInScene() { }
        // RVA: 0x0882FF94  token: 0x6000A04
        public static System.Void BakeAndReplaceAllInScene() { }
        // RVA: 0x0882FFB0  token: 0x6000A05
        public static System.Void BakeAndReplaceAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        // RVA: 0x08830638  token: 0x6000A06
        public static System.Void ExportSelectedAssetsToGeoFiles() { }
        // RVA: 0x08830334  token: 0x6000A07
        public static System.Void ExportAllAssetsToGeoFiles() { }
        // RVA: 0x08830350  token: 0x6000A08
        public static System.Void ExportAssetsToGeoFiles(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        // RVA: 0x088302FC  token: 0x6000A09
        public static System.String EditorSaveFolderPanel(System.String title, System.String folder, System.String defaultName) { }
        // RVA: 0x0350B670  token: 0x6000A0A
        public static System.Void QuerySelectedMeshTopology() { }
        // RVA: 0x088306D4  token: 0x6000A0B
        public static System.String GetObjectParentFolder(UnityEngine.GameObject parentObject, System.Collections.Generic.HashSet<UnityEngine.Material> generatedMaterials) { }
        // RVA: 0x088306A8  token: 0x6000A0C
        private static System.String GetObjectParentFolderHelper(System.Int32 instanceID) { }
        // RVA: 0x0350B670  token: 0x6000A0D
        public static System.Void RepaintScene() { }
        // RVA: 0x0350B670  token: 0x6000A0E
        public static System.Void SetTextureToNormalMap(System.String filename) { }
        // RVA: 0x0232EB60  token: 0x6000A0F
        public static System.Boolean ReleasedMouse() { }

    }

    // TypeToken: 0x200011E  // size: 0x10
    public static class HEU_Extensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000A10
        public static System.Collections.Generic.List<R> Map(System.Collections.Generic.IEnumerable<T> self, System.Func<T,R> selector) { }
        // RVA: -1  // generic def  token: 0x6000A11
        public static T Reduce(System.Collections.Generic.IEnumerable<T> self, System.Func<T,T,T> func) { }
        // RVA: -1  // generic def  token: 0x6000A12
        public static System.Collections.Generic.List<T> Filter(System.Collections.Generic.IEnumerable<T> self, System.Func<T,System.Boolean> predicate) { }
        // RVA: -1  // generic def  token: 0x6000A13
        public static System.Boolean IsValidIndex(System.Collections.Generic.List<T> self, System.Int32 index) { }
        // RVA: -1  // generic def  token: 0x6000A14
        public static System.Boolean IsEquivalentList(System.Collections.Generic.List<T> self, System.Collections.Generic.List<T> other) { }
        // RVA: 0x08830B30  token: 0x6000A15
        public static System.Boolean ApproximatelyEquals(UnityEngine.Quaternion quatA, UnityEngine.Quaternion value) { }
        // RVA: -1  // generic def  token: 0x6000A16
        public static System.Collections.Generic.List<U> ConvertList(System.Collections.Generic.List<T> self) { }
        // RVA: -1  // generic def  token: 0x6000A17
        public static System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> ConvertListToEquivable(System.Collections.Generic.List<T> self) { }
        // RVA: -1  // generic def  token: 0x6000A18
        public static HoudiniEngineUnity.IEquivable<T>[] ConvertArrayToEquivable(T[] self) { }
        // RVA: 0x05717BC8  token: 0x6000A19
        public static System.Boolean ApproximatelyEquals(System.Single self, System.Single other, System.Single epsilon) { }
        // RVA: 0x08830B7C  token: 0x6000A1A
        public static System.Byte[] AsByteArray(System.String self) { }
        // RVA: 0x08830BE8  token: 0x6000A1B
        public static System.String AsString(System.Byte[] buffer) { }
        // RVA: 0x03D6D8A0  token: 0x6000A1C
        public static UnityEngine.Vector3 SwapXAndY(UnityEngine.Vector3 self) { }
        // RVA: 0x03D6D8D0  token: 0x6000A1D
        public static UnityEngine.Vector3 SwapXAndZ(UnityEngine.Vector3 self) { }
        // RVA: 0x03D6D8F0  token: 0x6000A1E
        public static UnityEngine.Vector3 SwapYAndZ(UnityEngine.Vector3 self) { }
        // RVA: 0x088092B0  token: 0x6000A1F
        public static UnityEngine.Vector3 DecomposeToPosition(UnityEngine.Matrix4x4 self) { }
        // RVA: 0x08830C4C  token: 0x6000A20
        public static UnityEngine.Quaternion DecomposeToRotation(UnityEngine.Matrix4x4 self) { }
        // RVA: 0x08830D14  token: 0x6000A21
        public static UnityEngine.Vector3 DecomposeToScale(UnityEngine.Matrix4x4 self) { }

    }

    // TypeToken: 0x200011F  // size: 0x10
    public static class ArrayExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000A22
        public static System.Void Init(T[] array, T defaultValue) { }
        // RVA: -1  // generic def  token: 0x6000A23
        public static System.Void Init(System.Collections.Generic.List<T> array, T defaultValue) { }
        // RVA: -1  // generic def  token: 0x6000A24
        public static System.Void CopyToWithResize(T[] srcArray, T[]& destArray) { }
        // RVA: -1  // generic def  token: 0x6000A25
        public static System.Boolean IsEquivalentArray(T[] arr, T[] other) { }
        // RVA: -1  // generic def  token: 0x6000A26
        public static System.Boolean IsNull(T[] arr) { }

    }

    // TypeToken: 0x2000120  // size: 0x10
    public static class DictionaryExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000A27
        public static System.Void AddOrSet(System.Collections.Generic.Dictionary<T,U> dict, T key, U value) { }

    }

    // TypeToken: 0x2000121  // size: 0x60
    public sealed struct TransformData
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Quaternion rotation;  // 0x1c
        public UnityEngine.Vector3 localPosition;  // 0x2c
        public UnityEngine.Vector3 localScale;  // 0x38
        public UnityEngine.Quaternion localRotation;  // 0x44
        public UnityEngine.Transform parent;  // 0x58

        // Methods
        // RVA: 0x08844CFC  token: 0x6000A28
        public System.Void .ctor(UnityEngine.Transform other) { }
        // RVA: 0x08844C58  token: 0x6000A29
        public System.Void CopyTo(UnityEngine.Transform other, System.Boolean copyParent) { }
        // RVA: 0x08844BB0  token: 0x6000A2A
        public System.Void CopyToLocal(UnityEngine.Transform other, System.Boolean copyParent) { }

    }

    // TypeToken: 0x2000122  // size: 0x10
    public class HEU_GeneralUtility
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000A2B
        public static System.Boolean GetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000A2C
        public static System.Boolean GetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000A2D
        public static System.Boolean GetArray3Arg(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func, T[] data, System.Int32 start, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000A2E
        private static System.Boolean GetArray(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func3, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize) { }
        // RVA: -1  // generic def  token: 0x6000A2F
        public static System.Boolean SetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000A30
        public static System.Boolean SetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000A31
        public static System.Boolean SetArray(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize) { }
        // RVA: -1  // generic def  token: 0x6000A32
        public static System.Boolean DoArrayElementsMatch(T[] array1, T[] array2) { }
        // RVA: -1  // generic def  token: 0x6000A33
        public static System.Boolean DoArrayElementsMatch(T[] array1, System.Int32 startOffset1, T[] array2, System.Int32 startOffset2, System.Int32 length) { }
        // RVA: -1  // generic def  token: 0x6000A34
        public static System.Boolean GetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x6000A35
        public static System.Boolean GetAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc) { }
        // RVA: -1  // generic def  token: 0x6000A36
        public static System.Boolean GetAttributeStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc) { }
        // RVA: 0x08833540  token: 0x6000A37
        public static System.Void GetAttributeStringDataHelper(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, System.Int32[]& data) { }
        // RVA: 0x08833590  token: 0x6000A38
        public static System.String[] GetAttributeStringData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        // RVA: 0x08833274  token: 0x6000A39
        public static System.String[] GetAttributeDataAsString(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        // RVA: -1  // generic def  token: 0x6000A3A
        public static System.Boolean SetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc, System.Int32 count, System.Int32 start) { }
        // RVA: -1  // generic def  token: 0x6000A3B
        public static System.Boolean SetAttribute(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc) { }
        // RVA: 0x088076A8  token: 0x6000A3C
        public static System.Boolean CheckAttributeExists(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeOwner attribOwner) { }
        // RVA: 0x08833408  token: 0x6000A3D
        public static System.Boolean GetAttributeInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo) { }
        // RVA: 0x088349C0  token: 0x6000A3E
        public static System.Boolean HasValidInstanceAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName) { }
        // RVA: 0x08835AF4  token: 0x6000A3F
        public static System.Void UpdateGeneratedAttributeStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject go) { }
        // RVA: 0x08831EB0  token: 0x6000A40
        public static HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttributeHelper(System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        // RVA: 0x08831F30  token: 0x6000A41
        public static HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        // RVA: 0x08831D58  token: 0x6000A42
        public static System.Void CopyWorldTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest) { }
        // RVA: 0x08830DCC  token: 0x6000A43
        public static System.Void ApplyTransformTo(UnityEngine.Transform src, UnityEngine.Transform target) { }
        // RVA: 0x08831C9C  token: 0x6000A44
        public static System.Void CopyLocalTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest) { }
        // RVA: 0x08833DD4  token: 0x6000A45
        public static System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjects(UnityEngine.GameObject parentGO) { }
        // RVA: 0x08833B6C  token: 0x6000A46
        public static System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjectsWithNamePattern(UnityEngine.GameObject parentGO, System.String pattern, System.Boolean bExclude) { }
        // RVA: 0x08834238  token: 0x6000A47
        public static System.Collections.Generic.List<UnityEngine.GameObject> GetInstanceChildObjects(UnityEngine.GameObject parentGO) { }
        // RVA: 0x088344E4  token: 0x6000A48
        public static System.Collections.Generic.List<UnityEngine.GameObject> GetNonInstanceChildObjects(UnityEngine.GameObject parentGO) { }
        // RVA: 0x088340BC  token: 0x6000A49
        public static UnityEngine.GameObject GetGameObjectByName(System.Collections.Generic.List<UnityEngine.GameObject> goList, System.String name) { }
        // RVA: 0x08833FCC  token: 0x6000A4A
        public static UnityEngine.GameObject GetGameObjectByNameInProjectOnly(System.String name) { }
        // RVA: 0x088349EC  token: 0x6000A4B
        public static System.Boolean IsGameObjectInProject(UnityEngine.GameObject go) { }
        // RVA: 0x08834084  token: 0x6000A4C
        public static UnityEngine.GameObject GetGameObjectByNameInScene(System.String name) { }
        // RVA: 0x08834200  token: 0x6000A4D
        public static HoudiniEngineUnity.HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(System.String name) { }
        // RVA: -1  // generic def  token: 0x6000A4E
        public static T GetOrCreateComponent(UnityEngine.GameObject gameObject) { }
        // RVA: 0x088324A4  token: 0x6000A4F
        public static System.Void DestroyGeneratedComponents(UnityEngine.GameObject gameObject) { }
        // RVA: 0x0883267C  token: 0x6000A50
        public static System.Void DestroyGeneratedMeshComponents(UnityEngine.GameObject gameObject) { }
        // RVA: 0x08832B6C  token: 0x6000A51
        public static System.Void DestroyTerrainComponents(UnityEngine.GameObject gameObject) { }
        // RVA: -1  // generic def  token: 0x6000A52
        public static System.Void DestroyComponent(UnityEngine.GameObject gameObject) { }
        // RVA: 0x088328F0  token: 0x6000A53
        public static System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean bAllowDestroyingAssets, System.Boolean bRegisterUndo) { }
        // RVA: 0x088323D8  token: 0x6000A54
        public static System.Void DestroyBakedGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy) { }
        // RVA: 0x088322CC  token: 0x6000A55
        public static System.Void DestroyBakedGameObjectsWithEndName(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy, System.String endName) { }
        // RVA: 0x08832924  token: 0x6000A56
        public static System.Void DestroyLODGroup(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources) { }
        // RVA: 0x08834278  token: 0x6000A57
        public static System.Collections.Generic.List<UnityEngine.Transform> GetLODTransforms(UnityEngine.GameObject targetGO) { }
        // RVA: 0x08835694  token: 0x6000A58
        public static System.Void SetLODTransformValues(UnityEngine.GameObject targetGO, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> transformData) { }
        // RVA: 0x08832708  token: 0x6000A59
        public static System.Void DestroyGeneratedMeshMaterialsLODGroups(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources) { }
        // RVA: 0x08832580  token: 0x6000A5A
        public static System.Void DestroyGeneratedMaterial(UnityEngine.Material material) { }
        // RVA: 0x08832A90  token: 0x6000A5B
        public static System.Void DestroyMeshCollider(UnityEngine.MeshCollider meshCollider, System.Boolean bDontDeletePersistantResources) { }
        // RVA: 0x088355E4  token: 0x6000A5C
        public static System.Void SetGameObjectRenderVisiblity(UnityEngine.GameObject gameObject, System.Boolean bVisible) { }
        // RVA: 0x0883547C  token: 0x6000A5D
        public static System.Void SetGameObjectChildrenRenderVisibility(UnityEngine.GameObject gameObject, System.Boolean bVisible) { }
        // RVA: 0x08835534  token: 0x6000A5E
        public static System.Void SetGameObjectColliderState(UnityEngine.GameObject gameObject, System.Boolean bEnabled) { }
        // RVA: 0x088353C4  token: 0x6000A5F
        public static System.Void SetGameObjectChildrenColliderState(UnityEngine.GameObject gameObject, System.Boolean bVisible) { }
        // RVA: 0x088318D4  token: 0x6000A60
        public static System.String ColorToString(UnityEngine.Color c) { }
        // RVA: 0x088359FC  token: 0x6000A61
        public static UnityEngine.Color StringToColor(System.String colorString) { }
        // RVA: 0x0232EB60  token: 0x6000A62
        public static System.Boolean DoesUnityTagExist(System.String tagName) { }
        // RVA: 0x088357D0  token: 0x6000A63
        public static System.Void SetLayer(UnityEngine.GameObject rootGO, System.Int32 layer, System.Boolean bIncludeChildren) { }
        // RVA: 0x08835938  token: 0x6000A64
        public static System.Void SetTag(UnityEngine.GameObject rootGO, System.String tag, System.Boolean bIncludeChildren) { }
        // RVA: 0x08831BA0  token: 0x6000A65
        public static System.Void CopyFlags(UnityEngine.GameObject srcGO, UnityEngine.GameObject dstGO, System.Boolean bIncludeChildren) { }
        // RVA: 0x08834AC8  token: 0x6000A66
        public static System.Boolean IsMouseWithinSceneView(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition) { }
        // RVA: 0x08834A7C  token: 0x6000A67
        public static System.Boolean IsMouseOverRect(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition, UnityEngine.Rect& rect) { }
        // RVA: 0x08834838  token: 0x6000A68
        public static System.Type GetSystemTypeByName(System.String typeName) { }
        // RVA: 0x088310C8  token: 0x6000A69
        public static System.Void AssignUnityTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject) { }
        // RVA: 0x08830EE0  token: 0x6000A6A
        public static System.Void AssignUnityLayer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject) { }
        // RVA: 0x08834E4C  token: 0x6000A6B
        public static System.Void MakeStaticIfHasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject) { }
        // RVA: 0x08834870  token: 0x6000A6C
        public static System.String GetUnityScriptAttributeValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x08833934  token: 0x6000A6D
        public static System.String GetAttributeStringValueSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner) { }
        // RVA: 0x08833648  token: 0x6000A6E
        public static System.String GetAttributeStringValueSingleStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner) { }
        // RVA: 0x088332F0  token: 0x6000A6F
        public static System.Boolean GetAttributeFloatSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& value) { }
        // RVA: 0x08833428  token: 0x6000A70
        public static System.Boolean GetAttributeIntSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32& value) { }
        // RVA: 0x088330FC  token: 0x6000A71
        public static System.Boolean GetAttributeColorSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& value) { }
        // RVA: 0x0883499C  token: 0x6000A72
        public static System.Boolean HasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner) { }
        // RVA: 0x08831360  token: 0x6000A73
        public static System.Void AttachScriptWithInvokeFunction(System.String scriptSet, UnityEngine.GameObject gameObject) { }
        // RVA: 0x088349F4  token: 0x6000A74
        public static System.Boolean IsInCameraView(UnityEngine.Camera camera, UnityEngine.Vector3 point) { }
        // RVA: 0x08832CB0  token: 0x6000A75
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> FindOrGenerateHandles(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Int32 assetID, System.String assetName, HoudiniEngineUnity.HEU_Parameters parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> currentHandles) { }
        // RVA: 0x0350B670  token: 0x6000A76
        public static System.Void CopyComponents(UnityEngine.GameObject srcGO, UnityEngine.GameObject destGO) { }
        // RVA: 0x08834B38  token: 0x6000A77
        public static UnityEngine.Texture LoadTextureFromFile(System.String filePath) { }
        // RVA: 0x08834F70  token: 0x6000A78
        public static UnityEngine.Texture2D MakeTexture(System.Int32 width, System.Int32 height, UnityEngine.Color color) { }
        // RVA: 0x0883532C  token: 0x6000A79
        public static System.String ReplaceFirstOccurrence(System.String srcStr, System.String searchStr, System.String replaceStr) { }
        // RVA: 0x08835894  token: 0x6000A7A
        public static System.Void SetParentWithCleanTransform(UnityEngine.Transform parentTransform, UnityEngine.Transform childTransform) { }
        // RVA: 0x08831C10  token: 0x6000A7B
        public static System.Void CopyHAPITransform(HoudiniEngineUnity.HAPI_Transform& src, HoudiniEngineUnity.HAPI_Transform& dest) { }
        // RVA: 0x088343B8  token: 0x6000A7C
        public static System.String GetMaterialAttributeValueFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x08835200  token: 0x6000A7D
        public static System.Void ReplaceColliderMeshFromMeshFilter(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO) { }
        // RVA: 0x088350E0  token: 0x6000A7E
        public static System.Void ReplaceColliderMeshFromMeshCollider(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO) { }
        // RVA: 0x0883187C  token: 0x6000A7F
        public static System.Single BiLerpf(System.Single p00, System.Single p10, System.Single p01, System.Single p11, System.Single fracX, System.Single fracY) { }
        // RVA: 0x03D6D920  token: 0x6000A80
        public static System.Single Fractionalf(System.Single value) { }
        // RVA: 0x08834CE4  token: 0x6000A81
        public static System.String LongestCommonPrefix(System.Collections.Generic.List<System.String> list) { }
        // RVA: 0x088347DC  token: 0x6000A82
        public static System.String GetRawOperatorName(System.String assetOpName) { }
        // RVA: 0x08834524  token: 0x6000A83
        public static UnityEngine.GameObject GetPrefabFromPath(System.String path) { }
        // RVA: 0x08831A70  token: 0x6000A84
        public static System.Void ComposeNChildren(UnityEngine.GameObject parent, System.Int32 n, System.Collections.Generic.List<UnityEngine.GameObject>& childGameObjects, System.Boolean destroyIfExists) { }
        // RVA: 0x088323E4  token: 0x6000A85
        private static System.Void DestroyChildWithName(UnityEngine.Transform parent, System.String name) { }
        // RVA: 0x08832170  token: 0x6000A86
        public static System.Void DestroyAutoGeneratedChildren(UnityEngine.GameObject parent) { }
        // RVA: 0x08831E14  token: 0x6000A87
        public static UnityEngine.GameObject CreateNewGameObject(System.String name) { }
        // RVA: 0x08835070  token: 0x6000A88
        public static System.Void RenameGameObject(UnityEngine.GameObject obj, System.String name) { }
        // RVA: 0x0350B670  token: 0x6000A89
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000128  // size: 0x10
    public class ReverseCompare : System.Collections.IComparer
    {
        // Methods
        // RVA: 0x08844B38  token: 0x6000A9E
        public virtual System.Int32 Compare(System.Object x, System.Object y) { }
        // RVA: 0x0350B670  token: 0x6000A9F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000129  // size: 0x2B8
    public class HEU_GenerateGeoCache
    {
        // Fields
        private System.Int32 <AssetID>k__BackingField;  // 0x10
        public HoudiniEngineUnity.HAPI_GeoInfo _geoInfo;  // 0x14
        public HoudiniEngineUnity.HAPI_PartInfo _partInfo;  // 0x38
        public System.String _partName;  // 0x68
        public System.Int32[] _vertexList;  // 0x70
        public System.Int32[] _faceCounts;  // 0x78
        public System.Int32[] _houdiniMaterialIDs;  // 0x80
        public System.Boolean _singleFaceUnityMaterial;  // 0x88
        public System.Boolean _singleFaceHoudiniMaterial;  // 0x89
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_UnityMaterialInfo> _unityMaterialInfos;  // 0x90
        public HoudiniEngineUnity.HAPI_AttributeInfo _unityMaterialAttrInfo;  // 0x98
        public System.Int32[] _unityMaterialAttrName;  // 0xc0
        public System.Collections.Generic.Dictionary<System.Int32,System.String> _unityMaterialAttrStringsMap;  // 0xc8
        public HoudiniEngineUnity.HAPI_AttributeInfo _substanceMaterialAttrNameInfo;  // 0xd0
        public System.Int32[] _substanceMaterialAttrName;  // 0xf8
        public System.Collections.Generic.Dictionary<System.Int32,System.String> _substanceMaterialAttrStringsMap;  // 0x100
        public HoudiniEngineUnity.HAPI_AttributeInfo _substanceMaterialAttrIndexInfo;  // 0x108
        public System.Int32[] _substanceMaterialAttrIndex;  // 0x130
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> _inUseMaterials;  // 0x138
        public HoudiniEngineUnity.HAPI_AttributeInfo _posAttrInfo;  // 0x140
        public HoudiniEngineUnity.HAPI_AttributeInfo[] _uvsAttrInfo;  // 0x168
        public HoudiniEngineUnity.HAPI_AttributeInfo _normalAttrInfo;  // 0x170
        public HoudiniEngineUnity.HAPI_AttributeInfo _colorAttrInfo;  // 0x198
        public HoudiniEngineUnity.HAPI_AttributeInfo _alphaAttrInfo;  // 0x1c0
        public HoudiniEngineUnity.HAPI_AttributeInfo _tangentAttrInfo;  // 0x1e8
        public System.Single[] _posAttr;  // 0x210
        public System.Single[][] _uvsAttr;  // 0x218
        public System.Single[] _normalAttr;  // 0x220
        public System.Single[] _colorAttr;  // 0x228
        public System.Single[] _alphaAttr;  // 0x230
        public System.Single[] _tangentAttr;  // 0x238
        public System.String[] _groups;  // 0x240
        public System.Boolean _hasGroupGeometry;  // 0x248
        public System.Collections.Generic.Dictionary<System.String,System.Int32[]> _groupSplitVertexIndices;  // 0x250
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>> _groupSplitFaceIndices;  // 0x258
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>> _groupVertexOffsets;  // 0x260
        public System.Int32[] _allCollisionVertexList;  // 0x268
        public System.Int32[] _allCollisionFaceIndices;  // 0x270
        public System.Single _normalCosineThreshold;  // 0x278
        public System.Boolean _hasLODGroups;  // 0x27c
        public System.Single[] _LODTransitionValues;  // 0x280
        public System.Boolean _isMeshReadWrite;  // 0x288
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo> _colliderInfos;  // 0x290
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> _materialCache;  // 0x298
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData> _materialIDToDataMap;  // 0x2a0
        public System.String _assetCacheFolderPath;  // 0x2a8
        public HoudiniEngineUnity.HEU_MeshIndexFormat _meshIndexFormat;  // 0x2b0

        // Properties
        System.Int32 GeoID { get; /* RVA: 0x03D4EBB0 */ }
        System.Int32 PartID { get; /* RVA: 0x03D4EC30 */ }
        System.Int32 AssetID { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }

        // Methods
        // RVA: 0x0883D334  token: 0x6000AA4
        public static HoudiniEngineUnity.HEU_GenerateGeoCache GetPopulatedGeoCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 geoID, System.Int32 partID, System.Boolean bUseLODGroups, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        // RVA: 0x0883E61C  token: 0x6000AA5
        public System.Void PopulateUnityMaterialData(HoudiniEngineUnity.HEU_SessionBase session) { }
        // RVA: 0x0883D1B8  token: 0x6000AA6
        public static System.Int32 GetMaterialKeyFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 attributeIndex, System.String& unityMaterialName, System.String& substanceName, System.Int32& substanceIndex) { }
        // RVA: 0x0883657C  token: 0x6000AA7
        public static System.Void CreateMaterialInfoEntryFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 materialAttributeIndex) { }
        // RVA: 0x0883D770  token: 0x6000AA8
        public System.Boolean PopulateGeometryData(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bUseLODGroups) { }
        // RVA: 0x0883D690  token: 0x6000AA9
        public static System.Void ParseLODTransitionAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Single[]& LODTransitionValues) { }
        // RVA: 0x0883F47C  token: 0x6000AAA
        public static System.Void UpdateColliders(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        // RVA: 0x0883EE28  token: 0x6000AAB
        public static System.Void UpdateCollider(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData, HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo colliderInfo) { }
        // RVA: 0x0883CE7C  token: 0x6000AAC
        private static System.Void GetFinalMaterialsFromComparingNewWithPrevious(UnityEngine.GameObject gameObject, UnityEngine.Material[] previousMaterials, UnityEngine.Material[] newMaterials, UnityEngine.Material[]& finalMaterials) { }
        // RVA: 0x0883CC6C  token: 0x6000AAD
        public static System.Boolean GenerateMeshFromSingleGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced) { }
        // RVA: 0x0883AA04  token: 0x6000AAE
        public static System.Boolean GenerateLODMeshesFromGeoGroups(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup> GeoGroupMeshes, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced) { }
        // RVA: 0x0883B3FC  token: 0x6000AAF
        public static System.Boolean GenerateMeshFromGeoGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced, UnityEngine.Mesh& newMesh, UnityEngine.Material[]& newMaterials) { }
        // RVA: 0x08836004  token: 0x6000AB0
        public static UnityEngine.Mesh CombineQuadMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> subMeshIndices, System.Boolean bGenerateNormals) { }
        // RVA: 0x08835D90  token: 0x6000AB1
        public static UnityEngine.Mesh CombineMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> submeshIndices, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat) { }
        // RVA: 0x08836688  token: 0x6000AB2
        public static UnityEngine.Mesh CreateMeshFromMeshData(HoudiniEngineUnity.HEU_MeshData submesh, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat) { }
        // RVA: 0x0883EB68  token: 0x6000AB3
        public static System.Void TransferRegularAttributesToVertices(System.Int32[] groupVertexList, System.Int32[] allFaceCounts, System.Collections.Generic.List<System.Int32> groupFaces, System.Collections.Generic.List<System.Int32> groupVertexOffset, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo, System.Single[] inData, System.Single[]& outData) { }
        // RVA: 0x08838530  token: 0x6000AB4
        public static System.Boolean GenerateGeoGroupUsingGeoCacheVertices(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey) { }
        // RVA: 0x08836918  token: 0x6000AB5
        public static System.Boolean GenerateGeoGroupUsingGeoCachePoints(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey) { }
        // RVA: 0x0883D3EC  token: 0x6000AB6
        private static System.Void GetSubmeshIDForFace(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 faceMaterialID, System.Int32 groupFace, System.Int32 vertexFaceIndex, System.Int32[] groupVertexList, System.Int32 defaultMaterialKey, System.Int32& submeshID, System.Int32& singleFaceUnityMaterialKey, System.Int32& singleFaceHoudiniMaterialKey) { }
        // RVA: 0x08835C5C  token: 0x6000AB7
        public static UnityEngine.MeshTopology CalculateGroupMeshTopology(System.Collections.Generic.List<System.Int32> groupFaces, System.Int32[] allFaceCounts) { }
        // RVA: 0x0883F5BC  token: 0x6000AB8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200012D  // size: 0x28
    public class HEU_GeoGroup : System.IComparable`1
    {
        // Fields
        public System.String _groupName;  // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> _subMeshesMap;  // 0x18
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VertexEntry>[] _sharedNormalIndices;  // 0x20

        // Methods
        // RVA: 0x08844DC4  token: 0x6000ABE
        public virtual System.Int32 CompareTo(HoudiniEngineUnity.HEU_GeoGroup other) { }
        // RVA: 0x08844DFC  token: 0x6000ABF
        public System.Void SetupNormalIndices(System.Int32 indicesCount) { }
        // RVA: 0x08844EF0  token: 0x6000AC0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200012E  // size: 0x20
    public class HEU_VertexEntry
    {
        // Fields
        public System.Int32 _meshKey;  // 0x10
        public System.Int32 _vertexIndex;  // 0x14
        public System.Int32 _normalIndex;  // 0x18

        // Methods
        // RVA: 0x03D51130  token: 0x6000AC1
        public System.Void .ctor(System.Int32 meshKey, System.Int32 vertexIndex, System.Int32 normalIndex) { }

    }

    // TypeToken: 0x200012F  // size: 0x10
    public static class HEU_GeometryUtility
    {
        // Methods
        // RVA: 0x088464A0  token: 0x6000AC2
        public static UnityEngine.Vector2[] GeneratePerTriangle(UnityEngine.Mesh meshSrc) { }
        // RVA: 0x088464D8  token: 0x6000AC3
        public static System.Void GenerateSecondaryUVSet(UnityEngine.Mesh meshsrc) { }
        // RVA: 0x08844F68  token: 0x6000AC4
        public static System.Void CalculateMeshTangents(UnityEngine.Mesh mesh) { }
        // RVA: 0x0884570C  token: 0x6000AC5
        public static UnityEngine.Mesh GenerateCubeMeshFromPoints(UnityEngine.Vector3[] points, UnityEngine.Color[] pointsColor, System.Single size) { }
        // RVA: 0x0884650C  token: 0x6000AC6
        public static System.String GetInstanceOutputName(System.String partName, System.String[] userPrefix, System.Int32 index) { }

    }

    // TypeToken: 0x2000130  // size: 0x18
    public class HEU_InputData
    {
        // Fields
        public UnityEngine.GameObject _inputObject;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000AC7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000131  // size: 0x18
    public abstract class HEU_InputInterface
    {
        // Fields
        public static System.Int32 DEFAULT_PRIORITY;  // const
        protected System.Int32 _priority;  // 0x10

        // Properties
        System.Int32 Priority { get; /* RVA: 0x03D4E340 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000AC9
        public System.Void .ctor(System.Int32 priority) { }
        // RVA: 0x0884BEA4  token: 0x6000ACA
        public System.Void RegisterInterface() { }
        // RVA: -1  // abstract  token: 0x6000ACB
        public virtual System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        // RVA: -1  // abstract  token: 0x6000ACC
        public virtual System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }

    }

    // TypeToken: 0x2000132  // size: 0x18
    public class HEU_InputInterfaceMeshSettings
    {
        // Fields
        private System.Boolean _exportColliders;  // 0x10

        // Properties
        System.Boolean ExportColliders { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000ACF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000133  // size: 0x20
    public class HEU_InputInterfaceMesh : HoudiniEngineUnity.HEU_InputInterface
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputInterfaceMeshSettings settings;  // 0x18

        // Methods
        // RVA: 0x03D6D950  token: 0x6000AD0
        private System.Void .ctor() { }
        // RVA: 0x022C3A90  token: 0x6000AD1
        public System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceMeshSettings settings) { }
        // RVA: 0x08846708  token: 0x6000AD2
        public virtual System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }
        // RVA: 0x0884727C  token: 0x6000AD3
        public virtual System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        // RVA: 0x088471F8  token: 0x6000AD4
        public static System.Void GetUVsFromMesh(UnityEngine.Mesh mesh, UnityEngine.Vector2[] srcUVs, System.Collections.Generic.List<UnityEngine.Vector3> destUVs, System.Int32 index) { }
        // RVA: 0x0884805C  token: 0x6000AD5
        public System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData) { }
        // RVA: 0x08847B28  token: 0x6000AD6
        private System.Boolean UploadColliderData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 mergeNodeID, HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes inputData, System.Int32 parentNodeId) { }
        // RVA: 0x08847398  token: 0x6000AD7
        private System.Boolean UploadBoxColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.BoxCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        // RVA: 0x08849768  token: 0x6000AD8
        private System.Boolean UploadSphereColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.SphereCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        // RVA: 0x0884750C  token: 0x6000AD9
        private System.Boolean UploadCapsuleColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.CapsuleCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        // RVA: 0x08849484  token: 0x6000ADA
        private System.Boolean UploadMeshColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.MeshCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        // RVA: 0x08847008  token: 0x6000ADB
        private System.String GetColliderGroupBaseName(UnityEngine.Collider collider, System.Boolean bIsConvex, System.Boolean bIsSimple, System.Boolean bIsRendered) { }
        // RVA: 0x08846694  token: 0x6000ADC
        private System.Boolean CreateInputNodeForCollider(HoudiniEngineUnity.HEU_SessionBase session, System.Int32& outNodeID, System.Int32 parentNodeId, System.Int32 colliderIndex, System.String colliderName, System.Single[] colliderVertices, System.Int32[] colliderIndices) { }
        // RVA: 0x08846D30  token: 0x6000ADD
        public HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes GenerateMeshDatasFromGameObject(UnityEngine.GameObject inputObject, System.Boolean bExportColliders) { }
        // RVA: 0x08846848  token: 0x6000ADE
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh CreateSingleMeshData(UnityEngine.GameObject meshGameObject, System.Boolean bExportColliders) { }
        // RVA: 0x088470F8  token: 0x6000ADF
        private static UnityEngine.Mesh GetMeshFromObject(UnityEngine.GameObject meshGameObject) { }

    }

    // TypeToken: 0x2000138  // size: 0x18
    public class HEU_InputInterfaceTerrain : HoudiniEngineUnity.HEU_InputInterface
    {
        // Methods
        // RVA: 0x03D6D950  token: 0x6000AE3
        public System.Void .ctor() { }
        // RVA: 0x08849958  token: 0x6000AE4
        public virtual System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }
        // RVA: 0x08849FA4  token: 0x6000AE5
        private System.Boolean SetMaskLayer(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo) { }
        // RVA: 0x08849EA4  token: 0x6000AE6
        public virtual System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        // RVA: 0x088498E0  token: 0x6000AE7
        public System.Boolean CreateHeightFieldInputNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt) { }
        // RVA: 0x0884A7E8  token: 0x6000AE8
        public System.Boolean UploadHeightValuesWithTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo) { }
        // RVA: 0x0884A2F4  token: 0x6000AE9
        public System.Boolean UploadAlphaMaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo, System.Boolean& bMaskSet) { }
        // RVA: 0x08849F3C  token: 0x6000AEA
        public System.Boolean SetHeightFieldData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 volumeNodeID, System.Int32 partID, System.Single[] heightValues, System.String heightFieldName, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo) { }
        // RVA: 0x0884A0A8  token: 0x6000AEB
        public System.Boolean SetTerrainDataAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData) { }
        // RVA: 0x0884A12C  token: 0x6000AEC
        public System.Boolean SetTerrainLayerAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer) { }
        // RVA: 0x0884A1D0  token: 0x6000AED
        public System.Void SetTreePrototypes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData) { }
        // RVA: 0x0884A1B0  token: 0x6000AEE
        public System.Void SetTreeInstances(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData) { }
        // RVA: 0x08849AD4  token: 0x6000AEF
        public HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain GenerateTerrainDataFromGameObject(UnityEngine.GameObject inputObject) { }

    }

    // TypeToken: 0x200013A  // size: 0x18
    public class HEU_InputInterfaceTilemapSettings
    {
        // Fields
        public System.Boolean _createGroupsForTiles;  // 0x10
        public System.Boolean _exportUnusedTiles;  // 0x11
        public System.Boolean _applyTileColor;  // 0x12
        public System.Boolean _applyTilemapOrientation;  // 0x13

        // Methods
        // RVA: 0x03D6D960  token: 0x6000AF1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200013B  // size: 0x20
    public class HEU_InputInterfaceTilemap : HoudiniEngineUnity.HEU_InputInterface
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings settings;  // 0x18

        // Methods
        // RVA: 0x03D6D950  token: 0x6000AF2
        private System.Void .ctor() { }
        // RVA: 0x0884AA78  token: 0x6000AF3
        public System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings settings) { }
        // RVA: 0x0884A8D4  token: 0x6000AF4
        public virtual System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }
        // RVA: 0x0884AAE4  token: 0x6000AF5
        public virtual System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        // RVA: 0x0884AB78  token: 0x6000AF6
        private System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData) { }
        // RVA: 0x0884A9AC  token: 0x6000AF7
        public HoudiniEngineUnity.HEU_InputInterfaceTilemap.HEU_InputDataTilemap GenerateTilemapDataFromGameObject(UnityEngine.GameObject inputObject) { }

    }

    // TypeToken: 0x200013D  // size: 0x10
    public static class HEU_InputMeshUtility
    {
        // Methods
        // RVA: 0x0884C040  token: 0x6000AF9
        public static System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem) { }
        // RVA: 0x0884C3CC  token: 0x6000AFA
        public static System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x0884C524  token: 0x6000AFB
        public static System.Boolean SetMeshVertexAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem) { }
        // RVA: 0x0884C678  token: 0x6000AFC
        public static System.Boolean SetMeshVertexFloatAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x0884C7CC  token: 0x6000AFD
        public static System.Boolean UploadMeshIntoHoudiniNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetNodeID, System.Int32 objectID, System.Int32 geoID, UnityEngine.Mesh& mesh) { }
        // RVA: 0x0884C198  token: 0x6000AFE
        public static System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3Int[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x0884C2E8  token: 0x6000AFF
        public static System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        // RVA: 0x0884BEF0  token: 0x6000B00
        public static System.Boolean SetMeshDetailAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3 data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }

    }

    // TypeToken: 0x200013E  // size: 0x10
    public static class HEU_InputUtility
    {
        // Fields
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterface> _inputInterfaces;  // static @ 0x0

        // Methods
        // RVA: 0x0884CD4C  token: 0x6000B01
        public static System.Int32 GetHighestPriority() { }
        // RVA: 0x0884D0F0  token: 0x6000B02
        public static System.Void RegisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface) { }
        // RVA: 0x0884D2B0  token: 0x6000B03
        public static System.Void UnregisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface) { }
        // RVA: 0x0884CDF0  token: 0x6000B04
        public static HoudiniEngineUnity.HEU_InputInterface GetInputInterfaceByType(System.Type type) { }
        // RVA: 0x0884CFE8  token: 0x6000B05
        public static HoudiniEngineUnity.HEU_InputInterface GetInputInterface(UnityEngine.GameObject inputObject) { }
        // RVA: 0x0884CF1C  token: 0x6000B06
        private static HoudiniEngineUnity.HEU_InputInterface GetInputInterface(HoudiniEngineUnity.HEU_InputObjectInfo inputObjectInfo) { }
        // RVA: 0x0884CAB0  token: 0x6000B07
        private static System.Boolean CreateInputNodeWithMultiObjects(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo>& inputObjects, System.Collections.Generic.List<System.Int32>& inputObjectsConnectedAssetIDs, HoudiniEngineUnity.HEU_InputNode inputNode) { }
        // RVA: 0x0884C9F4  token: 0x6000B08
        private static System.Boolean CreateInputNodeWithMultiAssets(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo>& inputAssetInfos, System.Boolean bKeepWorldTransform, System.Int32 mergeParentID) { }
        // RVA: 0x0884D320  token: 0x6000B09
        private static System.Boolean UploadInputObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputObjectInfo inputObject, System.Int32 inputNodeID, System.Boolean bKeepWorldTransform) { }
        // RVA: 0x0884CBF0  token: 0x6000B0A
        public static System.Void GetChildrenTransforms(UnityEngine.Transform transform, System.Collections.Generic.List<UnityEngine.Matrix4x4>& childTransforms) { }
        // RVA: 0x0884D5B0  token: 0x6000B0B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200013F  // size: 0x10
    public class HEU_Logger
    {
        // Methods
        // RVA: 0x0884D918  token: 0x6000B0C
        public static System.Void Log(System.String text) { }
        // RVA: 0x0884D774  token: 0x6000B0D
        public static System.Void LogFormat(System.String text, System.Object[] args) { }
        // RVA: 0x0884D8CC  token: 0x6000B0E
        public static System.Void LogWarning(System.String text) { }
        // RVA: 0x0884D86C  token: 0x6000B0F
        public static System.Void LogWarningFormat(System.String text, System.Object[] args) { }
        // RVA: 0x0884D6AC  token: 0x6000B10
        public static System.Void LogError(System.String text) { }
        // RVA: 0x0884D64C  token: 0x6000B11
        public static System.Void LogErrorFormat(System.String text, System.Object[] args) { }
        // RVA: 0x0884D6F8  token: 0x6000B12
        public static System.Void LogError(System.Exception ex) { }
        // RVA: 0x0884D644  token: 0x6000B13
        public static System.Void LogAssertion(System.String text) { }
        // RVA: 0x0884D63C  token: 0x6000B14
        public static System.Void LogAssertionFormat(System.String text, System.Object[] args) { }
        // RVA: 0x0884D82C  token: 0x6000B15
        private static System.Void LogToCookLogsIfOn(System.String text) { }
        // RVA: 0x0884D7D0  token: 0x6000B16
        private static System.Void LogToCookLogsIfOnFormat(System.String text, System.Object[] args) { }
        // RVA: 0x0350B670  token: 0x6000B17
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000140  // size: 0x58
    public class HEU_MeshData
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> _indices;  // 0x10
        public System.Collections.Generic.List<UnityEngine.Vector3> _vertices;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Color32> _colors;  // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector3> _normals;  // 0x28
        public System.Collections.Generic.List<UnityEngine.Vector4> _tangents;  // 0x30
        public System.Collections.Generic.List<UnityEngine.Vector4>[] _uvs;  // 0x38
        public System.Collections.Generic.List<UnityEngine.Vector3> _triangleNormals;  // 0x40
        public System.Collections.Generic.Dictionary<System.Int32,System.Int32> _pointIndexToMeshIndexMap;  // 0x48
        public UnityEngine.MeshTopology _meshTopology;  // 0x50

        // Methods
        // RVA: 0x0884D964  token: 0x6000B18
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000141  // size: 0x18
    public class HEU_MeshIndexFormat
    {
        // Fields
        public UnityEngine.Rendering.IndexFormat _indexFormat;  // 0x10

        // Methods
        // RVA: 0x0884DB9C  token: 0x6000B19
        public System.Void CalculateIndexFormat(System.Int32 numVertices) { }
        // RVA: 0x0884DBF8  token: 0x6000B1A
        public System.Void SetFormatForMesh(UnityEngine.Mesh mesh) { }
        // RVA: 0x0350B670  token: 0x6000B1B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000142  // size: 0x14
    public sealed struct HEU_PipelineType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HEU_PipelineType Unsupported;  // const
        public static HoudiniEngineUnity.HEU_PipelineType BiRP;  // const
        public static HoudiniEngineUnity.HEU_PipelineType URP;  // const
        public static HoudiniEngineUnity.HEU_PipelineType HDRP;  // const

    }

    // TypeToken: 0x2000143  // size: 0x10
    public class HEU_RenderingPipelineDefines
    {
        // Methods
        // RVA: 0x0884DF94  token: 0x6000B1C
        private static System.Void .cctor() { }
        // RVA: 0x0884DED0  token: 0x6000B1D
        private static System.Void UpdateDefines() { }
        // RVA: 0x0884DD20  token: 0x6000B1E
        public static HoudiniEngineUnity.HEU_PipelineType GetPipeline() { }
        // RVA: 0x0884DC1C  token: 0x6000B1F
        private static System.Void AddDefine(System.String define) { }
        // RVA: 0x0884DE2C  token: 0x6000B20
        public static System.Void RemoveDefine(System.String define) { }
        // RVA: 0x0884DCC0  token: 0x6000B21
        public static System.Collections.Generic.List<System.String> GetDefines() { }
        // RVA: 0x0350B670  token: 0x6000B22
        public static System.Void SetDefines(System.Collections.Generic.List<System.String> definesList) { }
        // RVA: 0x0350B670  token: 0x6000B23
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000144
    public class HEU_SerializableDictionary`2 : System.Collections.Generic.IDictionary`2, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.Dictionary<TKey,TValue> _dictionary;  // 0x0
        private TKey[] _keys;  // 0x0
        private TValue[] _values;  // 0x0

        // Properties
        TValue Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TKey> Keys { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.ICollection<TValue> Values { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsReadOnly { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000B2A
        public virtual System.Void Add(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x6000B2B
        public virtual System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000B2C
        public virtual System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000B2D
        public virtual System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000B2E
        public virtual System.Boolean ContainsKey(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000B2F
        public virtual System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        // RVA: -1  // not resolved  token: 0x6000B30
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000B31
        public virtual System.Boolean Remove(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000B32
        public virtual System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        // RVA: -1  // not resolved  token: 0x6000B33
        public virtual System.Boolean TryGetValue(TKey key, TValue& value) { }
        // RVA: -1  // not resolved  token: 0x6000B34
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000B35
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: -1  // not resolved  token: 0x6000B36
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: -1  // not resolved  token: 0x6000B37
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000145  // size: 0x50
    public class HEU_ShelfToolData
    {
        // Fields
        public System.String _name;  // 0x10
        public HoudiniEngineUnity.HEU_ShelfToolData.ToolType _toolType;  // 0x18
        public System.String _toolTip;  // 0x20
        public System.String _iconPath;  // 0x28
        public System.String _assetPath;  // 0x30
        public System.String _helpURL;  // 0x38
        public System.String[] _targets;  // 0x40
        public System.String _jsonPath;  // 0x48

        // Methods
        // RVA: 0x0884DF9C  token: 0x6000B38
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000147  // size: 0x30
    public class HEU_Shelf
    {
        // Fields
        public System.String _shelfName;  // 0x10
        public System.String _shelfPath;  // 0x18
        public System.Boolean _defaultShelf;  // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData> _tools;  // 0x28

        // Methods
        // RVA: 0x088513E4  token: 0x6000B39
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000148  // size: 0x10
    public class HEU_ShelfTools
    {
        // Fields
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Shelf> _shelves;  // static @ 0x0
        private static System.Boolean _shelvesLoaded;  // static @ 0x8
        private static System.Int32 _currentSelectedShelf;  // static @ 0xc
        public static System.String TARGET_ALL;  // const
        public static System.String TARGET_UNITY;  // const

        // Methods
        // RVA: 0x0884E1E0  token: 0x6000B3A
        public static System.Boolean AreShelvesLoaded() { }
        // RVA: 0x08851274  token: 0x6000B3B
        public static System.Void SetReloadShelves() { }
        // RVA: 0x0884E230  token: 0x6000B3C
        public static System.Void ClearShelves() { }
        // RVA: 0x0884F258  token: 0x6000B3D
        public static System.Int32 GetNumShelves() { }
        // RVA: 0x0884F208  token: 0x6000B3E
        public static System.Int32 GetCurrentShelfIndex() { }
        // RVA: 0x08851220  token: 0x6000B3F
        public static System.Void SetCurrentShelf(System.Int32 index) { }
        // RVA: 0x0884F45C  token: 0x6000B40
        public static HoudiniEngineUnity.HEU_Shelf GetShelf(System.Int32 index) { }
        // RVA: 0x0884F300  token: 0x6000B41
        public static HoudiniEngineUnity.HEU_Shelf GetShelf(System.String shelfName) { }
        // RVA: 0x0884F2B4  token: 0x6000B42
        public static System.String GetShelfStorageEntry(System.String shelfName, System.String shelfPath) { }
        // RVA: 0x0884F500  token: 0x6000B43
        public static System.Void GetSplitShelfEntry(System.String shelfEntry, System.String& shelfName, System.String& shelfPath) { }
        // RVA: 0x0884FB94  token: 0x6000B44
        public static System.Void LoadShelves() { }
        // RVA: 0x08850CB8  token: 0x6000B45
        public static System.Boolean LoadToolsFromDirectory(System.String folderPath, System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData>& tools) { }
        // RVA: 0x08850270  token: 0x6000B46
        public static HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonFile(System.String jsonFilePath) { }
        // RVA: 0x0885040C  token: 0x6000B47
        public static HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonString(System.String json, System.String jsonFilePath) { }
        // RVA: 0x0884E040  token: 0x6000B48
        public static HoudiniEngineUnity.HEU_Shelf AddShelf(System.String shelfName, System.String shelfPath) { }
        // RVA: 0x08850EDC  token: 0x6000B49
        public static System.Void RemoveShelf(System.Int32 shelfIndex) { }
        // RVA: 0x0885100C  token: 0x6000B4A
        public static System.Void SaveShelf() { }
        // RVA: 0x0884EF58  token: 0x6000B4B
        public static System.Void ExecuteTool(System.Int32 toolSlot) { }
        // RVA: 0x0884E2F4  token: 0x6000B4C
        public static System.Void ExecuteToolGenerator(System.String toolName, System.String toolPath, UnityEngine.Vector3 targetPosition, UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetScale) { }
        // RVA: 0x0884FA04  token: 0x6000B4D
        public static System.Boolean IsValidInputMesh(UnityEngine.GameObject gameObject) { }
        // RVA: 0x0884F974  token: 0x6000B4E
        public static System.Boolean IsValidInputHDA(UnityEngine.GameObject gameObject) { }
        // RVA: 0x088512C4  token: 0x6000B4F
        private static System.Boolean ShouldUseHDA(UnityEngine.GameObject[] gameObjectList) { }
        // RVA: 0x0884E490  token: 0x6000B50
        public static System.Void ExecuteToolNoInput(System.String toolName, System.String toolPath) { }
        // RVA: 0x0884E9E0  token: 0x6000B51
        public static System.Void ExecuteToolOperatorSingle(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects) { }
        // RVA: 0x0884E5C4  token: 0x6000B52
        public static System.Void ExecuteToolOperatorMultiple(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects) { }
        // RVA: 0x0884E294  token: 0x6000B53
        public static System.Void ExecuteToolBatch(System.String toolName, System.String toolPath, UnityEngine.GameObject[] batchObjects) { }
        // RVA: 0x0884F8B8  token: 0x6000B54
        public static System.String GetToolResourcePath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath, System.String ext) { }
        // RVA: 0x0884F750  token: 0x6000B55
        public static System.String GetToolIconPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath) { }
        // RVA: 0x0884F5E0  token: 0x6000B56
        public static System.String GetToolAssetPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath) { }
        // RVA: 0x0350B670  token: 0x6000B57
        public System.Void .ctor() { }
        // RVA: 0x08851344  token: 0x6000B58
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200014A  // size: 0x14
    public sealed struct JSONNodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.JSONNodeType Array;  // const
        public static HoudiniEngineUnity.JSONNodeType Object;  // const
        public static HoudiniEngineUnity.JSONNodeType String;  // const
        public static HoudiniEngineUnity.JSONNodeType Number;  // const
        public static HoudiniEngineUnity.JSONNodeType NullValue;  // const
        public static HoudiniEngineUnity.JSONNodeType Boolean;  // const
        public static HoudiniEngineUnity.JSONNodeType None;  // const
        public static HoudiniEngineUnity.JSONNodeType Custom;  // const

    }

    // TypeToken: 0x200014B  // size: 0x14
    public sealed struct JSONTextMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.JSONTextMode Compact;  // const
        public static HoudiniEngineUnity.JSONTextMode Indent;  // const

    }

    // TypeToken: 0x200014C  // size: 0x10
    public abstract class JSONNode
    {
        // Fields
        public static System.Boolean forceASCII;  // static @ 0x0
        public static System.Boolean longAsString;  // static @ 0x1
        private static System.Text.StringBuilder m_EscapeBuilder;  // static @ 0xffffffff
        public static HoudiniEngineUnity.JSONContainerType VectorContainerType;  // static @ 0x4
        public static HoudiniEngineUnity.JSONContainerType QuaternionContainerType;  // static @ 0x8
        public static HoudiniEngineUnity.JSONContainerType RectContainerType;  // static @ 0xc

        // Properties
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: -1  // abstract */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x01002730 */ set; /* RVA: 0x0350B670 */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x01002730 */ set; /* RVA: 0x0350B670 */ }
        System.String Value { get; /* RVA: 0x08853C4C */ set; /* RVA: 0x0350B670 */ }
        System.Int32 Count { get; /* RVA: 0x01002730 */ }
        System.Boolean IsNumber { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsString { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsBoolean { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsNull { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsArray { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsObject { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean Inline { get; /* RVA: 0x0115F4C0 */ set; /* RVA: 0x0350B670 */ }
        System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> Children { get; /* RVA: 0x088539C0 */ }
        System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> DeepChildren { get; /* RVA: 0x08853A14 */ }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> Linq { get; /* RVA: 0x08853BEC */ }
        HoudiniEngineUnity.JSONNode.KeyEnumerator Keys { get; /* RVA: 0x08853B38 */ }
        HoudiniEngineUnity.JSONNode.ValueEnumerator Values { get; /* RVA: 0x08853B38 */ }
        System.Double AsDouble { get; /* RVA: 0x08853880 */ set; /* RVA: 0x08854628 */ }
        System.Int32 AsInt { get; /* RVA: 0x08853928 */ set; /* RVA: 0x088546A0 */ }
        System.Single AsFloat { get; /* RVA: 0x0885390C */ set; /* RVA: 0x0885468C */ }
        System.Boolean AsBool { get; /* RVA: 0x088537E4 */ set; /* RVA: 0x088545BC */ }
        System.Int64 AsLong { get; /* RVA: 0x08853944 */ set; /* RVA: 0x088546B8 */ }
        HoudiniEngineUnity.JSONArray AsArray { get; /* RVA: 0x088537A8 */ }
        HoudiniEngineUnity.JSONObject AsObject { get; /* RVA: 0x08853984 */ }
        System.Text.StringBuilder EscapeBuilder { get; /* RVA: 0x08853A84 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000B6B
        public virtual System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        // RVA: 0x0885145C  token: 0x6000B6C
        public virtual System.Void Add(HoudiniEngineUnity.JSONNode aItem) { }
        // RVA: 0x01002730  token: 0x6000B6D
        public virtual HoudiniEngineUnity.JSONNode Remove(System.String aKey) { }
        // RVA: 0x01002730  token: 0x6000B6E
        public virtual HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex) { }
        // RVA: 0x03D51810  token: 0x6000B6F
        public virtual HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x08852C2C  token: 0x6000B72
        public virtual System.String ToString() { }
        // RVA: 0x08852CB0  token: 0x6000B73
        public virtual System.String ToString(System.Int32 aIndent) { }
        // RVA: -1  // abstract  token: 0x6000B74
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: -1  // abstract  token: 0x6000B75
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x08853DA0  token: 0x6000B85
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.String s) { }
        // RVA: 0x08854274  token: 0x6000B86
        public static System.String op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        // RVA: 0x088543A0  token: 0x6000B87
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.Double n) { }
        // RVA: 0x08853D60  token: 0x6000B88
        public static System.Double op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        // RVA: 0x088542B4  token: 0x6000B89
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.Single n) { }
        // RVA: 0x08854530  token: 0x6000B8A
        public static System.Single op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        // RVA: 0x08853E78  token: 0x6000B8B
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.Int32 n) { }
        // RVA: 0x0885412C  token: 0x6000B8C
        public static System.Int32 op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        // RVA: 0x08853F10  token: 0x6000B8D
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.Int64 n) { }
        // RVA: 0x088544F0  token: 0x6000B8E
        public static System.Int64 op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        // RVA: 0x08853EC8  token: 0x6000B8F
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.Boolean b) { }
        // RVA: 0x08854328  token: 0x6000B90
        public static System.Boolean op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        // RVA: 0x08854368  token: 0x6000B91
        public static HoudiniEngineUnity.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> aKeyValue) { }
        // RVA: 0x08853C78  token: 0x6000B92
        public static System.Boolean op_Equality(HoudiniEngineUnity.JSONNode a, System.Object b) { }
        // RVA: 0x088545A8  token: 0x6000B93
        public static System.Boolean op_Inequality(HoudiniEngineUnity.JSONNode a, System.Object b) { }
        // RVA: 0x0232CE30  token: 0x6000B94
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x03D4F970  token: 0x6000B95
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x088514A4  token: 0x6000B97
        private static System.String Escape(System.String aText) { }
        // RVA: 0x08851790  token: 0x6000B98
        private static HoudiniEngineUnity.JSONNode ParseElement(System.String token, System.Boolean quoted) { }
        // RVA: 0x088518E4  token: 0x6000B99
        public static HoudiniEngineUnity.JSONNode Parse(System.String aJSON) { }
        // RVA: 0x0885170C  token: 0x6000B9A
        private static HoudiniEngineUnity.JSONNode GetContainer(HoudiniEngineUnity.JSONContainerType aType) { }
        // RVA: 0x08853FD0  token: 0x6000B9B
        public static HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector2 aVec) { }
        // RVA: 0x0885406C  token: 0x6000B9C
        public static HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector3 aVec) { }
        // RVA: 0x08853E00  token: 0x6000B9D
        public static HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector4 aVec) { }
        // RVA: 0x0885445C  token: 0x6000B9E
        public static HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Quaternion aRot) { }
        // RVA: 0x088541FC  token: 0x6000B9F
        public static HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Rect aRect) { }
        // RVA: 0x088543F0  token: 0x6000BA0
        public static HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.RectOffset aRect) { }
        // RVA: 0x088544D4  token: 0x6000BA1
        public static UnityEngine.Vector2 op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x08854570  token: 0x6000BA2
        public static UnityEngine.Vector3 op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x088541CC  token: 0x6000BA3
        public static UnityEngine.Vector4 op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x0885416C  token: 0x6000BA4
        public static UnityEngine.Quaternion op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x0885419C  token: 0x6000BA5
        public static UnityEngine.Rect op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x0885430C  token: 0x6000BA6
        public static UnityEngine.RectOffset op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x088525C0  token: 0x6000BA7
        public UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault) { }
        // RVA: 0x088526A8  token: 0x6000BA8
        public UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName) { }
        // RVA: 0x08852748  token: 0x6000BA9
        public UnityEngine.Vector2 ReadVector2() { }
        // RVA: 0x088533A4  token: 0x6000BAA
        public HoudiniEngineUnity.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName) { }
        // RVA: 0x08852760  token: 0x6000BAB
        public UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault) { }
        // RVA: 0x088528DC  token: 0x6000BAC
        public UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName) { }
        // RVA: 0x088529C4  token: 0x6000BAD
        public UnityEngine.Vector3 ReadVector3() { }
        // RVA: 0x0885349C  token: 0x6000BAE
        public HoudiniEngineUnity.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName) { }
        // RVA: 0x08852A14  token: 0x6000BAF
        public UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault) { }
        // RVA: 0x08852BF0  token: 0x6000BB0
        public UnityEngine.Vector4 ReadVector4() { }
        // RVA: 0x088535DC  token: 0x6000BB1
        public HoudiniEngineUnity.JSONNode WriteVector4(UnityEngine.Vector4 aVec) { }
        // RVA: 0x08851F58  token: 0x6000BB2
        public UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault) { }
        // RVA: 0x08851F1C  token: 0x6000BB3
        public UnityEngine.Quaternion ReadQuaternion() { }
        // RVA: 0x08852DD4  token: 0x6000BB4
        public HoudiniEngineUnity.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot) { }
        // RVA: 0x088523E4  token: 0x6000BB5
        public UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault) { }
        // RVA: 0x088523B0  token: 0x6000BB6
        public UnityEngine.Rect ReadRect() { }
        // RVA: 0x088531D8  token: 0x6000BB7
        public HoudiniEngineUnity.JSONNode WriteRect(UnityEngine.Rect aRect) { }
        // RVA: 0x08852134  token: 0x6000BB8
        public UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault) { }
        // RVA: 0x08852348  token: 0x6000BB9
        public UnityEngine.RectOffset ReadRectOffset() { }
        // RVA: 0x08852FA0  token: 0x6000BBA
        public HoudiniEngineUnity.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect) { }
        // RVA: 0x08851E74  token: 0x6000BBB
        public UnityEngine.Matrix4x4 ReadMatrix() { }
        // RVA: 0x08852D40  token: 0x6000BBC
        public HoudiniEngineUnity.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix) { }
        // RVA: 0x0350B670  token: 0x6000BBD
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000154  // size: 0x20
    public class JSONArray : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private System.Collections.Generic.List<HoudiniEngineUnity.JSONNode> m_List;  // 0x10
        private System.Boolean inline;  // 0x18

        // Properties
        System.Boolean Inline { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x01168950 */ }
        System.Boolean IsArray { get; /* RVA: 0x0232EB60 */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x0885CA9C */ set; /* RVA: 0x0885CB3C */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x0885CA9C */ set; /* RVA: 0x0885CB3C */ }
        System.Int32 Count { get; /* RVA: 0x0885C9FC */ }
        System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> Children { get; /* RVA: 0x0885C98C */ }

        // Methods
        // RVA: 0x0885C628  token: 0x6000BED
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0885C5A0  token: 0x6000BF3
        public virtual System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        // RVA: 0x0885C6B8  token: 0x6000BF4
        public virtual HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex) { }
        // RVA: 0x0885C75C  token: 0x6000BF5
        public virtual HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x0885C7B4  token: 0x6000BF7
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: 0x0885C914  token: 0x6000BF8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000156  // size: 0x20
    public class JSONObject : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.JSONNode> m_Dict;  // 0x10
        private System.Boolean inline;  // 0x18

        // Properties
        System.Boolean Inline { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x02102C70 */ }
        System.Boolean IsObject { get; /* RVA: 0x0232EB60 */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x0885E698 */ set; /* RVA: 0x0885E7E4 */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x0885E698 */ set; /* RVA: 0x0885E7E4 */ }
        System.Int32 Count { get; /* RVA: 0x0885E658 */ }
        System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> Children { get; /* RVA: 0x0885E5E8 */ }

        // Methods
        // RVA: 0x0885DE80  token: 0x6000C06
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0885DD34  token: 0x6000C0C
        public virtual System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        // RVA: 0x0885E190  token: 0x6000C0D
        public virtual HoudiniEngineUnity.JSONNode Remove(System.String aKey) { }
        // RVA: 0x0885DF24  token: 0x6000C0E
        public virtual HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex) { }
        // RVA: 0x0885DFE4  token: 0x6000C0F
        public virtual HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x0885E248  token: 0x6000C11
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: 0x0885E570  token: 0x6000C12
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000159  // size: 0x18
    public class JSONString : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private System.String m_Data;  // 0x10

        // Properties
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x03D555E0 */ }
        System.Boolean IsString { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000C20
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0426FEE0  token: 0x6000C23
        public System.Void .ctor(System.String aData) { }
        // RVA: 0x0885EA5C  token: 0x6000C24
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: 0x0885E9B8  token: 0x6000C25
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x06FAB9A8  token: 0x6000C26
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200015A  // size: 0x18
    public class JSONNumber : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private System.Double m_Data;  // 0x10

        // Properties
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x03D50CD0 */ }
        System.Boolean IsNumber { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x0885DC68 */ set; /* RVA: 0x0885DCB4 */ }
        System.Double AsDouble { get; /* RVA: 0x03D61CF0 */ set; /* RVA: 0x03D4E410 */ }
        System.Int64 AsLong { get; /* RVA: 0x03D6D990 */ set; /* RVA: 0x03D6D9A0 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000C29
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x03D4E410  token: 0x6000C30
        public System.Void .ctor(System.Double aData) { }
        // RVA: 0x0885CDA8  token: 0x6000C31
        public System.Void .ctor(System.String aData) { }
        // RVA: 0x0885DC34  token: 0x6000C32
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: 0x0885DAEC  token: 0x6000C33
        private static System.Boolean IsNumeric(System.Object value) { }
        // RVA: 0x0885DA0C  token: 0x6000C34
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0885DAE0  token: 0x6000C35
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200015B  // size: 0x18
    public class JSONBool : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private System.Boolean m_Data;  // 0x10

        // Properties
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x03D51110 */ }
        System.Boolean IsBoolean { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x0885CDBC */ set; /* RVA: 0x0885CE08 */ }
        System.Boolean AsBool { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000C38
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x03D4E960  token: 0x6000C3D
        public System.Void .ctor(System.Boolean aData) { }
        // RVA: 0x0885CDA8  token: 0x6000C3E
        public System.Void .ctor(System.String aData) { }
        // RVA: 0x0885CD3C  token: 0x6000C3F
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: 0x0885CC98  token: 0x6000C40
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0885CCF4  token: 0x6000C41
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200015C  // size: 0x10
    public class JSONNull : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private static HoudiniEngineUnity.JSONNull m_StaticInstance;  // static @ 0x0
        public static System.Boolean reuseSameInstance;  // static @ 0x8

        // Properties
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x03D51100 */ }
        System.Boolean IsNull { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x0885D9E0 */ set; /* RVA: 0x0350B670 */ }
        System.Boolean AsBool { get; /* RVA: 0x0115F4C0 */ set; /* RVA: 0x0350B670 */ }

        // Methods
        // RVA: 0x0885D85C  token: 0x6000C42
        public static HoudiniEngineUnity.JSONNull CreateOrGet() { }
        // RVA: 0x0350B670  token: 0x6000C43
        private System.Void .ctor() { }
        // RVA: 0x03D60600  token: 0x6000C46
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0885D8C8  token: 0x6000C4B
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x01002730  token: 0x6000C4C
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0885D920  token: 0x6000C4D
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        // RVA: 0x0885D968  token: 0x6000C4E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200015D  // size: 0x20
    public class JSONLazyCreator : HoudiniEngineUnity.JSONNode
    {
        // Fields
        private HoudiniEngineUnity.JSONNode m_Node;  // 0x10
        private System.String m_Key;  // 0x18

        // Properties
        HoudiniEngineUnity.JSONNodeType Tag { get; /* RVA: 0x03D55AA0 */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x0885D374 */ set; /* RVA: 0x0885D724 */ }
        HoudiniEngineUnity.JSONNode Item { get; /* RVA: 0x0885D374 */ set; /* RVA: 0x0885D724 */ }
        System.Int32 AsInt { get; /* RVA: 0x0885D1AC */ set; /* RVA: 0x0885D5B0 */ }
        System.Single AsFloat { get; /* RVA: 0x0885D144 */ set; /* RVA: 0x0885D538 */ }
        System.Double AsDouble { get; /* RVA: 0x0885D0DC */ set; /* RVA: 0x0885D4C4 */ }
        System.Int64 AsLong { get; /* RVA: 0x0885D214 */ set; /* RVA: 0x0885D628 */ }
        System.Boolean AsBool { get; /* RVA: 0x0885D074 */ set; /* RVA: 0x0885D454 */ }
        HoudiniEngineUnity.JSONArray AsArray { get; /* RVA: 0x0885CFFC */ }
        HoudiniEngineUnity.JSONObject AsObject { get; /* RVA: 0x0885D2FC */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000C50
        public virtual HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x02E1A410  token: 0x6000C51
        public System.Void .ctor(HoudiniEngineUnity.JSONNode aNode) { }
        // RVA: 0x02676770  token: 0x6000C52
        public System.Void .ctor(HoudiniEngineUnity.JSONNode aNode, System.String aKey) { }
        // RVA: -1  // generic def  token: 0x6000C53
        private T Set(T aVal) { }
        // RVA: 0x0885CF10  token: 0x6000C58
        public virtual System.Void Add(HoudiniEngineUnity.JSONNode aItem) { }
        // RVA: 0x0885CE6C  token: 0x6000C59
        public virtual System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        // RVA: 0x0885CFA4  token: 0x6000C5A
        public static System.Boolean op_Equality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b) { }
        // RVA: 0x0885D444  token: 0x6000C5B
        public static System.Boolean op_Inequality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b) { }
        // RVA: 0x0885CFA4  token: 0x6000C5C
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x01002730  token: 0x6000C5D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0885CFB4  token: 0x6000C6A
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }

    }

    // TypeToken: 0x200015E  // size: 0x10
    public static class JSON
    {
        // Methods
        // RVA: 0x0885EAC8  token: 0x6000C6B
        public static HoudiniEngineUnity.JSONNode Parse(System.String aJSON) { }

    }

    // TypeToken: 0x200015F  // size: 0x14
    public sealed struct JSONContainerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.JSONContainerType Array;  // const
        public static HoudiniEngineUnity.JSONContainerType Object;  // const

    }

    // TypeToken: 0x2000160  // size: 0x10
    public static class HEU_TerrainUtility
    {
        // Methods
        // RVA: 0x088558B8  token: 0x6000C6C
        public static System.Boolean GenerateTerrainFromVolume(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject, UnityEngine.TerrainData& terrainData, UnityEngine.Vector3& volumePositionOffset, UnityEngine.Terrain& terrain, System.String bakedMaterialPath) { }
        // RVA: 0x08858180  token: 0x6000C6D
        public static System.Void SetTerrainMaterial(UnityEngine.Terrain terrain, System.String specifiedMaterialName, System.String bakedMaterialPath) { }
        // RVA: 0x088562E4  token: 0x6000C6E
        public static System.String GetDefaultTerrainShaderName() { }
        // RVA: 0x08856264  token: 0x6000C6F
        public static System.String GetDefaultTerrainMaterialPath() { }
        // RVA: 0x0885671C  token: 0x6000C70
        public static System.Single[] GetNormalizedHeightmapFromPartWithMinMax(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single& minHeight, System.Single& maxHeight, System.Single& heightRange, System.Boolean bUseHeightRangeOverride) { }
        // RVA: 0x08856364  token: 0x6000C71
        public static System.Int32[,] GetDetailMapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& detailResolution) { }
        // RVA: 0x088565A4  token: 0x6000C72
        public static System.Boolean GetHeightmapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 xLength, System.Int32 yLength, System.Int32 geoID, System.Int32 partID, System.Single[]& heightValues, System.Single& minHeight, System.Single& maxHeight) { }
        // RVA: 0x088557DC  token: 0x6000C73
        public static System.Single[,] ConvertHeightMapHoudiniToUnity(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[] heightValues) { }
        // RVA: 0x08855698  token: 0x6000C74
        public static System.Single[,,] ConvertHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Collections.Generic.List<System.Single[]> heightFields) { }
        // RVA: 0x08854BE0  token: 0x6000C75
        public static System.Single[,,] AppendConvertedHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[,,] existingAlphaMaps, System.Collections.Generic.List<System.Single[]> heightFields, System.Single[] strengths, System.Collections.Generic.List<System.Int32> alphaMapIndices) { }
        // RVA: 0x08856B5C  token: 0x6000C76
        public static UnityEngine.Vector3 GetVolumePositionOffset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Vector3 volumePosition, System.Single terrainSizeX, System.Single heightMapSize, System.Int32 mapWidth, System.Int32 mapHeight, System.Single minHeight) { }
        // RVA: 0x08856A68  token: 0x6000C77
        public static System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x0885733C  token: 0x6000C78
        public static System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, HoudiniEngineUnity.HEU_VolumeScatterTrees& scatterTrees, System.Boolean throwWarningIfNoTileAttribute) { }
        // RVA: 0x088551AC  token: 0x6000C79
        public static System.Void ApplyScatterTrees(UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_VolumeScatterTrees scatterTrees, System.Int32 tileIndex) { }
        // RVA: 0x08856F18  token: 0x6000C7A
        public static System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailPrototype& detailPrototype) { }
        // RVA: 0x08856C48  token: 0x6000C7B
        public static System.Void PopulateDetailProperties(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailProperties& detailProperties) { }
        // RVA: 0x08854DD8  token: 0x6000C7C
        public static System.Void ApplyDetailLayers(UnityEngine.Terrain terrain, UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_DetailProperties detailProperties, System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype> heuDetailPrototypes, System.Collections.Generic.List<System.Int32[,]> convertedDetailMaps) { }
        // RVA: 0x08856864  token: 0x6000C7D
        private static System.Int32 GetTerrainLayerIndexByName(System.String layerName, UnityEngine.TerrainLayer[] terrainLayers) { }
        // RVA: 0x088569D0  token: 0x6000C7E
        public static System.Int32 GetTerrainLayerIndex(UnityEngine.TerrainLayer layer, UnityEngine.TerrainLayer[] terrainLayers) { }
        // RVA: 0x088582EC  token: 0x6000C7F
        public static System.Boolean VolumeLayerHasAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x08856468  token: 0x6000C80
        public static HoudiniEngineUnity.HFLayerType GetHeightfieldLayerType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String volumeName) { }
        // RVA: 0x088563F4  token: 0x6000C81
        public static System.Single GetHeightRangeFromHeightfield(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x0885679C  token: 0x6000C82
        public static System.String GetTerrainDataExportPathFromHeightfieldAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        // RVA: 0x08857EE8  token: 0x6000C83
        public static System.Single[] ResampleData(System.Single[] data, System.Int32 oldWidth, System.Int32 oldHeight, System.Int32 newWidth, System.Int32 newHeight) { }
        // RVA: 0x088561F4  token: 0x6000C84
        public static System.Boolean GetAttributeTile(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& outTileAttribute) { }

    }

    // TypeToken: 0x2000161
    public interface IEquivable`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000C85
        public virtual System.Boolean IsEquivalentTo(T other) { }

    }

    // TypeToken: 0x2000162
    public interface IEquivableWrapperClass`1 : HoudiniEngineUnity.IEquivable`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000C86
        public virtual System.Boolean IsNull() { }

    }

    // TypeToken: 0x2000163  // size: 0x10
    public class HEU_TestHelpers
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000C87
        public static System.Boolean AssertTrueLogEquivalent(T a, T b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _) { }
        // RVA: 0x088585E0  token: 0x6000C88
        public static System.Boolean AssertTrueLogEquivalent(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C89
        public static System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C8A
        public static System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: 0x088586DC  token: 0x6000C8B
        public static System.Boolean AssertTrueLogEquivalent(System.String a, System.String b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C8C
        public static System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _) { }
        // RVA: -1  // generic def  token: 0x6000C8D
        public static System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireClass<T> _) { }
        // RVA: -1  // generic def  token: 0x6000C8E
        public static System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C8F
        public static System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C90
        public static System.Boolean AssertTrueLogEquivalent(T[] a, T[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: 0x0885847C  token: 0x6000C91
        public static System.Boolean AssertTrueLogEquivalent(System.String[] a, System.String[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C92
        public static System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T>[] a, HoudiniEngineUnity.IEquivable<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C93
        public static System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T>[] a, HoudiniEngineUnity.IEquivableWrapperClass<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: 0x08858794  token: 0x6000C94
        public static System.Void PrintTestLogAndSetResult(System.Boolean expression, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        // RVA: -1  // generic def  token: 0x6000C95
        public static System.Boolean ShouldBeTested(T a, T b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: 0x088588D8  token: 0x6000C96
        public static System.Boolean ShouldBeTested(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: -1  // generic def  token: 0x6000C97
        public static System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: -1  // generic def  token: 0x6000C98
        public static System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: -1  // generic def  token: 0x6000C99
        private static System.Boolean ShouldBeTested(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: -1  // generic def  token: 0x6000C9A
        public static System.Boolean ShouldBeTested(T[] a, T[] b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: 0x08858B18  token: 0x6000C9B
        public static System.Boolean ShouldBeTested(System.String a, System.String b, System.Boolean& bResult, System.String header, System.String subject) { }
        // RVA: 0x08858BAC  token: 0x6000C9C
        public static System.Boolean TestOutputObjectEquivalence(UnityEngine.GameObject a, UnityEngine.GameObject b) { }
        // RVA: 0x0350B670  token: 0x6000C9D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000166  // size: 0x50
    public class Test_HAPI_AssetInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_AssetInfo self;  // 0x10

        // Methods
        // RVA: 0x03D64D80  token: 0x6000CA0
        public System.Void .ctor(HoudiniEngineUnity.HAPI_AssetInfo self) { }
        // RVA: 0x08860560  token: 0x6000CA1
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AssetInfo other) { }

    }

    // TypeToken: 0x2000167  // size: 0x10
    public static class Test_HAPI_AssetInfo_Extensions
    {
        // Methods
        // RVA: 0x088604FC  token: 0x6000CA2
        public static HoudiniEngineUnity.Test_HAPI_AssetInfo ToTestObject(HoudiniEngineUnity.HAPI_AssetInfo self) { }

    }

    // TypeToken: 0x2000168  // size: 0x58
    public class Test_HAPI_NodeInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_NodeInfo self;  // 0x10

        // Methods
        // RVA: 0x03D6DA00  token: 0x6000CA3
        public System.Void .ctor(HoudiniEngineUnity.HAPI_NodeInfo self) { }
        // RVA: 0x08860B9C  token: 0x6000CA4
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_NodeInfo other) { }

    }

    // TypeToken: 0x2000169  // size: 0x10
    public static class Test_HAPI_NodeInfo_Extensions
    {
        // Methods
        // RVA: 0x08860B2C  token: 0x6000CA5
        public static HoudiniEngineUnity.Test_HAPI_NodeInfo ToTestObject(HoudiniEngineUnity.HAPI_NodeInfo self) { }

    }

    // TypeToken: 0x200016A  // size: 0x30
    public class Test_HAPI_ObjectInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_ObjectInfo self;  // 0x10

        // Methods
        // RVA: 0x03D64DF0  token: 0x6000CA6
        public System.Void .ctor(HoudiniEngineUnity.HAPI_ObjectInfo self) { }
        // RVA: 0x08860E30  token: 0x6000CA7
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ObjectInfo other) { }

    }

    // TypeToken: 0x200016B  // size: 0x10
    public static class Test_HAPI_ObjectInfo_Extensions
    {
        // Methods
        // RVA: 0x08860DD0  token: 0x6000CA8
        public static HoudiniEngineUnity.Test_HAPI_ObjectInfo ToTestObject(HoudiniEngineUnity.HAPI_ObjectInfo self) { }

    }

    // TypeToken: 0x200016C  // size: 0x38
    public class Test_HAPI_Transform : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_Transform self;  // 0x10

        // Methods
        // RVA: 0x08861778  token: 0x6000CA9
        public System.Void .ctor(HoudiniEngineUnity.HAPI_Transform self) { }
        // RVA: 0x0886181C  token: 0x6000CAA
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_Transform other) { }

    }

    // TypeToken: 0x200016D  // size: 0x10
    public static class Test_HAPI_Transform_Extensions
    {
        // Methods
        // RVA: 0x0886179C  token: 0x6000CAB
        public static HoudiniEngineUnity.Test_HAPI_Transform ToTestObject(HoudiniEngineUnity.HAPI_Transform self) { }

    }

    // TypeToken: 0x200016E  // size: 0x38
    public class Test_HAPI_GeoInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_GeoInfo self;  // 0x10

        // Methods
        // RVA: 0x03D64D60  token: 0x6000CAC
        public System.Void .ctor(HoudiniEngineUnity.HAPI_GeoInfo self) { }
        // RVA: 0x088608FC  token: 0x6000CAD
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_GeoInfo other) { }

    }

    // TypeToken: 0x200016F  // size: 0x10
    public static class Test_HAPI_GeoInfo_Extensions
    {
        // Methods
        // RVA: 0x0886089C  token: 0x6000CAE
        public static HoudiniEngineUnity.Test_HAPI_GeoInfo ToTestObject(HoudiniEngineUnity.HAPI_GeoInfo self) { }

    }

    // TypeToken: 0x2000170  // size: 0x38
    public class Test_HAPI_AttributeInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_AttributeInfo self;  // 0x10

        // Methods
        // RVA: 0x03D6D9E0  token: 0x6000CAF
        public System.Void .ctor(HoudiniEngineUnity.HAPI_AttributeInfo self) { }
        // RVA: 0x08860798  token: 0x6000CB0
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AttributeInfo other) { }

    }

    // TypeToken: 0x2000171  // size: 0x10
    public static class Test_HAPI_AttributeInfo_Extensions
    {
        // Methods
        // RVA: 0x0886073C  token: 0x6000CB1
        public static HoudiniEngineUnity.Test_HAPI_AttributeInfo ToTestObject(HoudiniEngineUnity.HAPI_AttributeInfo self) { }

    }

    // TypeToken: 0x2000172  // size: 0x38
    public class Test_HAPI_TransformEuler : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_TransformEuler self;  // 0x10

        // Methods
        // RVA: 0x08861778  token: 0x6000CB2
        public System.Void .ctor(HoudiniEngineUnity.HAPI_TransformEuler self) { }
        // RVA: 0x088616A0  token: 0x6000CB3
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_TransformEuler other) { }

    }

    // TypeToken: 0x2000173  // size: 0x10
    public static class Test_HAPI_TransformEuler_Extensions
    {
        // Methods
        // RVA: 0x08861620  token: 0x6000CB4
        public static HoudiniEngineUnity.Test_HAPI_TransformEuler ToTestObject(HoudiniEngineUnity.HAPI_TransformEuler self) { }

    }

    // TypeToken: 0x2000174  // size: 0xA8
    public class Test_HAPI_ParmInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_ParmInfo self;  // 0x10

        // Methods
        // RVA: 0x03D6DA30  token: 0x6000CB5
        public System.Void .ctor(HoudiniEngineUnity.HAPI_ParmInfo self) { }
        // RVA: 0x08860FFC  token: 0x6000CB6
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ParmInfo other) { }

    }

    // TypeToken: 0x2000175  // size: 0x10
    public static class Test_HAPI_ParmInfo_Extensions
    {
        // Methods
        // RVA: 0x08860F5C  token: 0x6000CB7
        public static HoudiniEngineUnity.Test_HAPI_ParmInfo ToTestObject(HoudiniEngineUnity.HAPI_ParmInfo self) { }

    }

    // TypeToken: 0x2000176  // size: 0x18
    public class Test_LODGroup : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.LODGroup self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CB8
        public System.Void .ctor(UnityEngine.LODGroup self) { }
        // RVA: 0x08861D40  token: 0x6000CB9
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08861B20  token: 0x6000CBA
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LODGroup other) { }

    }

    // TypeToken: 0x2000177  // size: 0x10
    public static class Test_LODGroup_Extensions
    {
        // Methods
        // RVA: 0x088618B0  token: 0x6000CBB
        public static HoudiniEngineUnity.Test_LODGroup ToTestObject(UnityEngine.LODGroup self) { }
        // RVA: 0x08861A1C  token: 0x6000CBC
        public static HoudiniEngineUnity.Test_LODGroup[] ToTestObject(UnityEngine.LODGroup[] self) { }
        // RVA: 0x08861910  token: 0x6000CBD
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_LODGroup> ToTestObject(System.Collections.Generic.List<UnityEngine.LODGroup> self) { }

    }

    // TypeToken: 0x2000179  // size: 0x18
    public class Test_Transform : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Transform self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CC2
        public System.Void .ctor(UnityEngine.Transform self) { }
        // RVA: 0x08865374  token: 0x6000CC3
        public virtual System.Boolean IsNull() { }
        // RVA: 0x088651F0  token: 0x6000CC4
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Transform other) { }

    }

    // TypeToken: 0x200017A  // size: 0x10
    public static class Test_Transform_Extensions
    {
        // Methods
        // RVA: 0x08864F80  token: 0x6000CC5
        public static HoudiniEngineUnity.Test_Transform ToTestObject(UnityEngine.Transform self) { }
        // RVA: 0x088650EC  token: 0x6000CC6
        public static HoudiniEngineUnity.Test_Transform[] ToTestObject(UnityEngine.Transform[] self) { }
        // RVA: 0x08864FE0  token: 0x6000CC7
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Transform> ToTestObject(System.Collections.Generic.List<UnityEngine.Transform> self) { }

    }

    // TypeToken: 0x200017C  // size: 0x18
    public class Test_Material : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Material self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CCC
        public System.Void .ctor(UnityEngine.Material self) { }
        // RVA: 0x088622D4  token: 0x6000CCD
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08862100  token: 0x6000CCE
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Material other) { }

    }

    // TypeToken: 0x200017D  // size: 0x10
    public static class Test_Material_Extensions
    {
        // Methods
        // RVA: 0x08861F74  token: 0x6000CCF
        public static HoudiniEngineUnity.Test_Material ToTestObject(UnityEngine.Material self) { }
        // RVA: 0x08861FD4  token: 0x6000CD0
        public static HoudiniEngineUnity.Test_Material[] ToTestObject(UnityEngine.Material[] self) { }
        // RVA: 0x08861E68  token: 0x6000CD1
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Material> ToTestObject(System.Collections.Generic.List<UnityEngine.Material> self) { }

    }

    // TypeToken: 0x200017F  // size: 0x18
    public class Test_Collider : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Collider self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CD6
        public System.Void .ctor(UnityEngine.Collider self) { }
        // RVA: 0x08860140  token: 0x6000CD7
        public virtual System.Boolean IsNull() { }
        // RVA: 0x0885FD60  token: 0x6000CD8
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Collider other) { }

    }

    // TypeToken: 0x2000180  // size: 0x10
    public static class Test_Collider_Extensions
    {
        // Methods
        // RVA: 0x0885FD00  token: 0x6000CD9
        public static HoudiniEngineUnity.Test_Collider ToTestObject(UnityEngine.Collider self) { }
        // RVA: 0x0885FBFC  token: 0x6000CDA
        public static HoudiniEngineUnity.Test_Collider[] ToTestObject(UnityEngine.Collider[] self) { }
        // RVA: 0x0885FAF0  token: 0x6000CDB
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Collider> ToTestObject(System.Collections.Generic.List<UnityEngine.Collider> self) { }

    }

    // TypeToken: 0x2000182  // size: 0x18
    public class Test_BoxCollider : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.BoxCollider self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CE0
        public System.Void .ctor(UnityEngine.BoxCollider self) { }
        // RVA: 0x0885F658  token: 0x6000CE1
        public virtual System.Boolean IsNull() { }
        // RVA: 0x0885F4CC  token: 0x6000CE2
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_BoxCollider other) { }

    }

    // TypeToken: 0x2000183  // size: 0x10
    public static class Test_BoxCollider_Extensions
    {
        // Methods
        // RVA: 0x0885F46C  token: 0x6000CE3
        public static HoudiniEngineUnity.Test_BoxCollider ToTestObject(UnityEngine.BoxCollider self) { }
        // RVA: 0x0885F25C  token: 0x6000CE4
        public static HoudiniEngineUnity.Test_BoxCollider[] ToTestObject(UnityEngine.BoxCollider[] self) { }
        // RVA: 0x0885F360  token: 0x6000CE5
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_BoxCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.BoxCollider> self) { }

    }

    // TypeToken: 0x2000185  // size: 0x18
    public class Test_SphereCollider : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.SphereCollider self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CEA
        public System.Void .ctor(UnityEngine.SphereCollider self) { }
        // RVA: 0x08863918  token: 0x6000CEB
        public virtual System.Boolean IsNull() { }
        // RVA: 0x088637B0  token: 0x6000CEC
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_SphereCollider other) { }

    }

    // TypeToken: 0x2000186  // size: 0x10
    public static class Test_SphereCollider_Extensions
    {
        // Methods
        // RVA: 0x08863644  token: 0x6000CED
        public static HoudiniEngineUnity.Test_SphereCollider ToTestObject(UnityEngine.SphereCollider self) { }
        // RVA: 0x08863540  token: 0x6000CEE
        public static HoudiniEngineUnity.Test_SphereCollider[] ToTestObject(UnityEngine.SphereCollider[] self) { }
        // RVA: 0x088636A4  token: 0x6000CEF
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_SphereCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.SphereCollider> self) { }

    }

    // TypeToken: 0x2000188  // size: 0x18
    public class Test_CapsuleCollider : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.CapsuleCollider self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CF4
        public System.Void .ctor(UnityEngine.CapsuleCollider self) { }
        // RVA: 0x0885FAA0  token: 0x6000CF5
        public virtual System.Boolean IsNull() { }
        // RVA: 0x0885F918  token: 0x6000CF6
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_CapsuleCollider other) { }

    }

    // TypeToken: 0x2000189  // size: 0x10
    public static class Test_CapsuleCollider_Extensions
    {
        // Methods
        // RVA: 0x0885F6A8  token: 0x6000CF7
        public static HoudiniEngineUnity.Test_CapsuleCollider ToTestObject(UnityEngine.CapsuleCollider self) { }
        // RVA: 0x0885F814  token: 0x6000CF8
        public static HoudiniEngineUnity.Test_CapsuleCollider[] ToTestObject(UnityEngine.CapsuleCollider[] self) { }
        // RVA: 0x0885F708  token: 0x6000CF9
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_CapsuleCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.CapsuleCollider> self) { }

    }

    // TypeToken: 0x200018B  // size: 0x18
    public class Test_MeshCollider : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.MeshCollider self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CFE
        public System.Void .ctor(UnityEngine.MeshCollider self) { }
        // RVA: 0x0886266C  token: 0x6000CFF
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08862594  token: 0x6000D00
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshCollider other) { }

    }

    // TypeToken: 0x200018C  // size: 0x10
    public static class Test_MeshCollider_Extensions
    {
        // Methods
        // RVA: 0x08862324  token: 0x6000D01
        public static HoudiniEngineUnity.Test_MeshCollider ToTestObject(UnityEngine.MeshCollider self) { }
        // RVA: 0x08862384  token: 0x6000D02
        public static HoudiniEngineUnity.Test_MeshCollider[] ToTestObject(UnityEngine.MeshCollider[] self) { }
        // RVA: 0x08862488  token: 0x6000D03
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshCollider> self) { }

    }

    // TypeToken: 0x200018E  // size: 0x18
    public class Test_Mesh : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Mesh self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D08
        public System.Void .ctor(UnityEngine.Mesh self) { }
        // RVA: 0x088634F0  token: 0x6000D09
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08863134  token: 0x6000D0A
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Mesh other) { }

    }

    // TypeToken: 0x200018F  // size: 0x10
    public static class Test_Mesh_Extensions
    {
        // Methods
        // RVA: 0x08862EC4  token: 0x6000D0B
        public static HoudiniEngineUnity.Test_Mesh ToTestObject(UnityEngine.Mesh self) { }
        // RVA: 0x08863030  token: 0x6000D0C
        public static HoudiniEngineUnity.Test_Mesh[] ToTestObject(UnityEngine.Mesh[] self) { }
        // RVA: 0x08862F24  token: 0x6000D0D
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Mesh> ToTestObject(System.Collections.Generic.List<UnityEngine.Mesh> self) { }

    }

    // TypeToken: 0x2000191  // size: 0x18
    public class Test_MeshRenderer : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.MeshRenderer self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D12
        public System.Void .ctor(UnityEngine.MeshRenderer self) { }
        // RVA: 0x08862E74  token: 0x6000D13
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08862D50  token: 0x6000D14
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshRenderer other) { }

    }

    // TypeToken: 0x2000192  // size: 0x10
    public static class Test_MeshRenderer_Extensions
    {
        // Methods
        // RVA: 0x08862AE0  token: 0x6000D15
        public static HoudiniEngineUnity.Test_MeshRenderer ToTestObject(UnityEngine.MeshRenderer self) { }
        // RVA: 0x08862C4C  token: 0x6000D16
        public static HoudiniEngineUnity.Test_MeshRenderer[] ToTestObject(UnityEngine.MeshRenderer[] self) { }
        // RVA: 0x08862B40  token: 0x6000D17
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshRenderer> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshRenderer> self) { }

    }

    // TypeToken: 0x2000194  // size: 0x18
    public class Test_MeshFilter : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.MeshFilter self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D1C
        public System.Void .ctor(UnityEngine.MeshFilter self) { }
        // RVA: 0x08862A90  token: 0x6000D1D
        public virtual System.Boolean IsNull() { }
        // RVA: 0x0886292C  token: 0x6000D1E
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshFilter other) { }

    }

    // TypeToken: 0x2000195  // size: 0x10
    public static class Test_MeshFilter_Extensions
    {
        // Methods
        // RVA: 0x088628CC  token: 0x6000D1F
        public static HoudiniEngineUnity.Test_MeshFilter ToTestObject(UnityEngine.MeshFilter self) { }
        // RVA: 0x088627C8  token: 0x6000D20
        public static HoudiniEngineUnity.Test_MeshFilter[] ToTestObject(UnityEngine.MeshFilter[] self) { }
        // RVA: 0x088626BC  token: 0x6000D21
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshFilter> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshFilter> self) { }

    }

    // TypeToken: 0x2000197  // size: 0x18
    public class Test_LayerMask : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.LayerMask self;  // 0x10

        // Methods
        // RVA: 0x010410F0  token: 0x6000D26
        public System.Void .ctor(UnityEngine.LayerMask self) { }
        // RVA: 0x08861DD4  token: 0x6000D27
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LayerMask other) { }

    }

    // TypeToken: 0x2000198  // size: 0x10
    public static class Test_LayerMask_Extensions
    {
        // Methods
        // RVA: 0x08861D90  token: 0x6000D28
        public static HoudiniEngineUnity.Test_LayerMask ToTestObject(UnityEngine.LayerMask self) { }

    }

    // TypeToken: 0x2000199  // size: 0x18
    public class Test_Gradient : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Gradient self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D29
        public System.Void .ctor(UnityEngine.Gradient self) { }
        // RVA: 0x025EB8A0  token: 0x6000D2A
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08860400  token: 0x6000D2B
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Gradient other) { }

    }

    // TypeToken: 0x200019A  // size: 0x10
    public static class Test_Gradient_Extensions
    {
        // Methods
        // RVA: 0x088603A0  token: 0x6000D2C
        public static HoudiniEngineUnity.Test_Gradient ToTestObject(UnityEngine.Gradient self) { }
        // RVA: 0x0886029C  token: 0x6000D2D
        public static HoudiniEngineUnity.Test_Gradient[] ToTestObject(UnityEngine.Gradient[] self) { }
        // RVA: 0x08860190  token: 0x6000D2E
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Gradient> ToTestObject(System.Collections.Generic.List<UnityEngine.Gradient> self) { }

    }

    // TypeToken: 0x200019C  // size: 0x18
    public class Test_AnimationCurve : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.AnimationCurve self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D33
        public System.Void .ctor(UnityEngine.AnimationCurve self) { }
        // RVA: 0x025EB8A0  token: 0x6000D34
        public virtual System.Boolean IsNull() { }
        // RVA: 0x0885F170  token: 0x6000D35
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_AnimationCurve other) { }

    }

    // TypeToken: 0x200019D  // size: 0x10
    public static class Test_AnimationCurve_Extensions
    {
        // Methods
        // RVA: 0x0885EF00  token: 0x6000D36
        public static HoudiniEngineUnity.Test_AnimationCurve ToTestObject(UnityEngine.AnimationCurve self) { }
        // RVA: 0x0885EF60  token: 0x6000D37
        public static HoudiniEngineUnity.Test_AnimationCurve[] ToTestObject(UnityEngine.AnimationCurve[] self) { }
        // RVA: 0x0885F064  token: 0x6000D38
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_AnimationCurve> ToTestObject(System.Collections.Generic.List<UnityEngine.AnimationCurve> self) { }

    }

    // TypeToken: 0x200019F  // size: 0x18
    public class Test_TerrainLayer : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.TerrainLayer self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D3D
        public System.Void .ctor(UnityEngine.TerrainLayer self) { }
        // RVA: 0x08864738  token: 0x6000D3E
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08864370  token: 0x6000D3F
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainLayer other) { }

    }

    // TypeToken: 0x20001A0  // size: 0x10
    public static class Test_TerrainLayer_Extensions
    {
        // Methods
        // RVA: 0x08864100  token: 0x6000D40
        public static HoudiniEngineUnity.Test_TerrainLayer ToTestObject(UnityEngine.TerrainLayer self) { }
        // RVA: 0x0886426C  token: 0x6000D41
        public static HoudiniEngineUnity.Test_TerrainLayer[] ToTestObject(UnityEngine.TerrainLayer[] self) { }
        // RVA: 0x08864160  token: 0x6000D42
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainLayer> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainLayer> self) { }

    }

    // TypeToken: 0x20001A2  // size: 0x18
    public class Test_Texture2D : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Texture2D self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D47
        public System.Void .ctor(UnityEngine.Texture2D self) { }
        // RVA: 0x08864F30  token: 0x6000D48
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08864E04  token: 0x6000D49
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Texture2D other) { }

    }

    // TypeToken: 0x20001A3  // size: 0x10
    public static class Test_Texture2D_Extensions
    {
        // Methods
        // RVA: 0x08864B94  token: 0x6000D4A
        public static HoudiniEngineUnity.Test_Texture2D ToTestObject(UnityEngine.Texture2D self) { }
        // RVA: 0x08864BF4  token: 0x6000D4B
        public static HoudiniEngineUnity.Test_Texture2D[] ToTestObject(UnityEngine.Texture2D[] self) { }
        // RVA: 0x08864CF8  token: 0x6000D4C
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Texture2D> ToTestObject(System.Collections.Generic.List<UnityEngine.Texture2D> self) { }

    }

    // TypeToken: 0x20001A5  // size: 0x38
    public class Test_TreeInstance : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.TreeInstance self;  // 0x10

        // Methods
        // RVA: 0x03D6D9E0  token: 0x6000D51
        public System.Void .ctor(UnityEngine.TreeInstance self) { }
        // RVA: 0x08865630  token: 0x6000D52
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TreeInstance other) { }

    }

    // TypeToken: 0x20001A6  // size: 0x10
    public static class Test_TreeInstance_Extensions
    {
        // Methods
        // RVA: 0x088654C8  token: 0x6000D53
        public static HoudiniEngineUnity.Test_TreeInstance ToTestObject(UnityEngine.TreeInstance self) { }
        // RVA: 0x088653C4  token: 0x6000D54
        public static HoudiniEngineUnity.Test_TreeInstance[] ToTestObject(UnityEngine.TreeInstance[] self) { }
        // RVA: 0x08865524  token: 0x6000D55
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_TreeInstance> ToTestObject(System.Collections.Generic.List<UnityEngine.TreeInstance> self) { }

    }

    // TypeToken: 0x20001A8  // size: 0x18
    public class Test_TerrainData : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.TerrainData self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D5A
        public System.Void .ctor(UnityEngine.TerrainData self) { }
        // RVA: 0x088640B0  token: 0x6000D5B
        public virtual System.Boolean IsNull() { }
        // RVA: 0x08863BD8  token: 0x6000D5C
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainData other) { }

    }

    // TypeToken: 0x20001A9  // size: 0x10
    public static class Test_TerrainData_Extensions
    {
        // Methods
        // RVA: 0x08863B78  token: 0x6000D5D
        public static HoudiniEngineUnity.Test_TerrainData ToTestObject(UnityEngine.TerrainData self) { }
        // RVA: 0x08863A74  token: 0x6000D5E
        public static HoudiniEngineUnity.Test_TerrainData[] ToTestObject(UnityEngine.TerrainData[] self) { }
        // RVA: 0x08863968  token: 0x6000D5F
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainData> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainData> self) { }

    }

    // TypeToken: 0x20001AB  // size: 0x18
    public class Test_Terrain : HoudiniEngineUnity.IEquivableWrapperClass`1, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public UnityEngine.Terrain self;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000D64
        public System.Void .ctor(UnityEngine.Terrain self) { }
        // RVA: 0x08864B44  token: 0x6000D65
        public virtual System.Boolean IsNull() { }
        // RVA: 0x088649F8  token: 0x6000D66
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Terrain other) { }

    }

    // TypeToken: 0x20001AC  // size: 0x10
    public static class Test_Terrain_Extensions
    {
        // Methods
        // RVA: 0x08864788  token: 0x6000D67
        public static HoudiniEngineUnity.Test_Terrain ToTestObject(UnityEngine.Terrain self) { }
        // RVA: 0x088647E8  token: 0x6000D68
        public static HoudiniEngineUnity.Test_Terrain[] ToTestObject(UnityEngine.Terrain[] self) { }
        // RVA: 0x088648EC  token: 0x6000D69
        public static System.Collections.Generic.List<HoudiniEngineUnity.Test_Terrain> ToTestObject(System.Collections.Generic.List<UnityEngine.Terrain> self) { }

    }

    // TypeToken: 0x20001AE  // size: 0xA8
    public class HEU_ToolsInfo : UnityEngine.ScriptableObject, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.Single _paintBrushSize;  // 0x18
        public System.Single _paintBrushOpacity;  // 0x1c
        public System.Int32[] _paintIntValue;  // 0x20
        public System.Single[] _paintFloatValue;  // 0x28
        public System.String[] _paintStringValue;  // 0x30
        public System.Int32 _lastAttributesGeoID;  // 0x38
        public System.Int32 _lastAttributesPartID;  // 0x3c
        public System.String _lastAttributeNodeName;  // 0x40
        public System.String _lastAttributeName;  // 0x48
        public UnityEngine.Color _brushHandleColor;  // 0x50
        public UnityEngine.Color _affectedAreaPaintColor;  // 0x60
        public System.Boolean _liveUpdate;  // 0x70
        public System.Boolean _isPainting;  // 0x71
        public System.Single _editPointBoxSize;  // 0x74
        public UnityEngine.Color _editPointBoxUnselectedColor;  // 0x78
        public UnityEngine.Color _editPointBoxSelectedColor;  // 0x88
        public System.Boolean _recacheRequired;  // 0x98
        public HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode _paintMergeMode;  // 0x9c
        public System.Boolean _showOnlyEditGeometry;  // 0xa0
        public System.Boolean _alwaysCookUpstream;  // 0xa1
        public HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility _paintMeshVisiblity;  // 0xa4

        // Methods
        // RVA: 0x08859204  token: 0x6000D6E
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ToolsInfo other) { }
        // RVA: 0x08859748  token: 0x6000D6F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20001B1  // size: 0x14
    public sealed struct HFLayerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static HoudiniEngineUnity.HFLayerType DEFAULT;  // const
        public static HoudiniEngineUnity.HFLayerType HEIGHT;  // const
        public static HoudiniEngineUnity.HFLayerType MASK;  // const
        public static HoudiniEngineUnity.HFLayerType DETAIL;  // const

    }

    // TypeToken: 0x20001B2  // size: 0x50
    public class HEU_VolumeLayer : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.String _layerName;  // 0x10
        public System.Single _strength;  // 0x18
        public System.Boolean _uiExpanded;  // 0x1c
        public System.Int32 _tile;  // 0x20
        public System.Int32 _xLength;  // 0x24
        public System.Int32 _yLength;  // 0x28
        public System.Boolean _hasLayerAttributes;  // 0x2c
        public UnityEngine.TerrainLayer _terrainLayer;  // 0x30
        public HoudiniEngineUnity.HFLayerType _layerType;  // 0x38
        public HoudiniEngineUnity.HEU_DetailPrototype _detailPrototype;  // 0x40
        private HoudiniEngineUnity.HEU_PartData _part;  // 0x48

        // Methods
        // RVA: 0x0885BFF0  token: 0x6000D70
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeLayer other) { }
        // RVA: 0x03D561E0  token: 0x6000D71
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20001B3  // size: 0x58
    public class HEU_VolumeScatterTrees : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo> _treePrototypInfos;  // 0x10
        public UnityEngine.Color32[] _colors;  // 0x18
        public System.Single[] _heightScales;  // 0x20
        public UnityEngine.Color32[] _lightmapColors;  // 0x28
        public UnityEngine.Vector3[] _positions;  // 0x30
        public System.Int32[] _prototypeIndices;  // 0x38
        public System.Single[] _rotations;  // 0x40
        public System.Single[] _widthScales;  // 0x48
        public System.Int32[] _terrainTiles;  // 0x50

        // Methods
        // RVA: 0x0885C2CC  token: 0x6000D72
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeScatterTrees other) { }
        // RVA: 0x0350B670  token: 0x6000D73
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20001B4  // size: 0x20
    public class HEU_TreePrototypeInfo : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.String _prefabPath;  // 0x10
        public System.Single _bendfactor;  // 0x18

        // Methods
        // RVA: 0x08859848  token: 0x6000D74
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_TreePrototypeInfo other) { }
        // RVA: 0x0350B670  token: 0x6000D75
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20001B5  // size: 0x20
    public class HEU_DetailProperties : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.Single _detailDistance;  // 0x10
        public System.Single _detailDensity;  // 0x14
        public System.Int32 _detailResolution;  // 0x18
        public System.Int32 _detailResolutionPerPatch;  // 0x1c

        // Methods
        // RVA: 0x088548FC  token: 0x6000D76
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailProperties other) { }
        // RVA: 0x03D6D970  token: 0x6000D77
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20001B6  // size: 0x60
    public class HEU_DetailPrototype : HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        public System.String _prototypePrefab;  // 0x10
        public System.String _prototypeTexture;  // 0x18
        public System.Single _bendFactor;  // 0x20
        public UnityEngine.Color _dryColor;  // 0x24
        public UnityEngine.Color _healthyColor;  // 0x34
        public System.Single _maxHeight;  // 0x44
        public System.Single _maxWidth;  // 0x48
        public System.Single _minHeight;  // 0x4c
        public System.Single _minWidth;  // 0x50
        public System.Single _noiseSpread;  // 0x54
        public System.Int32 _renderMode;  // 0x58

        // Methods
        // RVA: 0x08854B28  token: 0x6000D78
        public System.Void .ctor() { }
        // RVA: 0x08854A5C  token: 0x6000D79
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailPrototype other) { }

    }

    // TypeToken: 0x20001B7  // size: 0x70
    public class HEU_VolumeCache : UnityEngine.ScriptableObject, HoudiniEngineUnity.IHEU_VolumeCache, HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent, HoudiniEngineUnity.IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HEU_GeoNode _ownerNode;  // 0x18
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> _layers;  // 0x20
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> _updatedLayers;  // 0x28
        private System.Int32 _tileIndex;  // 0x30
        private System.Boolean _isDirty;  // 0x34
        private System.String _geoName;  // 0x38
        private System.String _objName;  // 0x40
        public System.Boolean _uiExpanded;  // 0x48
        private UnityEngine.TerrainData _terrainData;  // 0x50
        private HoudiniEngineUnity.HEU_VolumeScatterTrees _scatterTrees;  // 0x58
        private HoudiniEngineUnity.HEU_DetailProperties _detailProperties;  // 0x60
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;  // 0x68

        // Properties
        System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> Layers { get; /* RVA: 0x03D4EB40 */ }
        System.Int32 TileIndex { get; /* RVA: 0x03D4ED20 */ }
        System.String ObjectName { get; /* RVA: 0x03D4E2B0 */ }
        System.String GeoName { get; /* RVA: 0x03D4E2A0 */ }
        UnityEngine.TerrainData TerrainData { get; /* RVA: 0x03D4EAF0 */ }
        HoudiniEngineUnity.HEU_VolumeScatterTrees ScatterTrees { get; /* RVA: 0x03D4EAA0 */ }
        HoudiniEngineUnity.HEU_DetailProperties DetailProperties { get; /* RVA: 0x03D4EB00 */ }
        HoudiniEngineUnity.HEU_HoudiniAsset ParentAsset { get; /* RVA: 0x03D4EAB0 */ }
        System.Boolean IsDirty { get; /* RVA: 0x03D4F570 */ set; /* RVA: 0x03D4F590 */ }
        System.Boolean UIExpanded { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }

        // Methods
        // RVA: 0x0885A4BC  token: 0x6000D86
        public virtual HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        // RVA: 0x0885B5A8  token: 0x6000D87
        public virtual System.Void Recook() { }
        // RVA: 0x0885B610  token: 0x6000D88
        public virtual System.Void ResetParameters() { }
        // RVA: 0x0885A310  token: 0x6000D89
        public virtual HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName) { }
        // RVA: 0x0885B2E4  token: 0x6000D8A
        public virtual System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset) { }
        // RVA: 0x0885995C  token: 0x6000D8B
        public virtual System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset) { }
        // RVA: 0x0885B880  token: 0x6000D8C
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> UpdateVolumeCachesFromParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> volumeCaches) { }
        // RVA: 0x0885A550  token: 0x6000D8D
        private System.Void Initialize(HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Int32 tileIndex) { }
        // RVA: 0x0885B77C  token: 0x6000D8E
        private System.Void StartUpdateLayers() { }
        // RVA: 0x08859FAC  token: 0x6000D8F
        private System.Void FinishUpdateLayers() { }
        // RVA: 0x0885A450  token: 0x6000D90
        private System.Void GetPartLayerAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer) { }
        // RVA: 0x0885B0A0  token: 0x6000D91
        private System.Boolean LoadLayerTextureFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Texture2D& outTexture) { }
        // RVA: 0x0885ABA8  token: 0x6000D92
        private System.Boolean LoadLayerFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue) { }
        // RVA: 0x0885AA3C  token: 0x6000D93
        private System.Boolean LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue) { }
        // RVA: 0x0885B190  token: 0x6000D94
        private System.Boolean LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue) { }
        // RVA: 0x0885B7F4  token: 0x6000D95
        private System.Void UpdateLayerFromPart(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_PartData part) { }
        // RVA: 0x08859FDC  token: 0x6000D96
        private System.Void GenerateTerrainWithAlphamaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.Boolean bRebuild) { }
        // RVA: 0x0885ACA0  token: 0x6000D97
        public System.Void LoadLayerPropertiesFromAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer, System.Boolean bNewTerrainLayer, UnityEngine.Texture2D defaultTexture) { }
        // RVA: 0x0885B56C  token: 0x6000D98
        private System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, System.Boolean throwWarningIfNoTileAttribute) { }
        // RVA: 0x0885B2A8  token: 0x6000D99
        private System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer) { }
        // RVA: 0x08859D68  token: 0x6000D9A
        private System.Void CopyValuesTo(HoudiniEngineUnity.HEU_VolumeCache destCache) { }
        // RVA: 0x08859BEC  token: 0x6000D9B
        private static System.Void CopyDetailProperties(HoudiniEngineUnity.HEU_DetailProperties srcProp, HoudiniEngineUnity.HEU_DetailProperties destProp) { }
        // RVA: 0x08859C1C  token: 0x6000D9C
        private static System.Void CopyLayer(HoudiniEngineUnity.HEU_VolumeLayer srcLayer, HoudiniEngineUnity.HEU_VolumeLayer destLayer) { }
        // RVA: 0x08859CF8  token: 0x6000D9D
        private static System.Void CopyPrototype(HoudiniEngineUnity.HEU_DetailPrototype srcProto, HoudiniEngineUnity.HEU_DetailPrototype destProto) { }
        // RVA: 0x0885A9D4  token: 0x6000D9E
        private static UnityEngine.Texture2D LoadDefaultSplatTexture() { }
        // RVA: 0x0885A908  token: 0x6000D9F
        private static UnityEngine.Texture2D LoadAssetTexture(System.String path) { }
        // RVA: 0x0885A640  token: 0x6000DA0
        public virtual System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeCache other) { }
        // RVA: 0x0885BF6C  token: 0x6000DA1
        public System.Void .ctor() { }

    }

}

