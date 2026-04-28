// ========================================================
// Dumped by @desirepro
// Assembly: VolumetricLightBeam.dll
// Classes:  68
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x10
    public static class EditorPrefsStrings
    {
    }

    // TypeToken: 0x200000C  // size: 0x10
    public static class Help
    {
        // Fields
        private static System.String UrlBase;  // const
        private static System.String UrlSuffix;  // const
        public static System.String UrlBeam;  // const
        public static System.String UrlDustParticles;  // const
        public static System.String UrlDynamicOcclusionRaycasting;  // const
        public static System.String UrlDynamicOcclusionDepthBuffer;  // const
        public static System.String UrlTriggerZone;  // const
        public static System.String UrlSkewingHandle;  // const
        public static System.String UrlEffectFlicker;  // const
        public static System.String UrlEffectPulse;  // const
        public static System.String UrlConfig;  // const

    }

    // TypeToken: 0x200000D  // size: 0x10
    public static class Internal
    {
        // Properties
        UnityEngine.HideFlags ProceduralObjectsHideFlags { get; /* RVA: 0x01002730 */ }

    }

    // TypeToken: 0x200000E  // size: 0x10
    public static class Beam
    {
        // Fields
        public static VLB.ColorMode ColorModeDefault;  // const
        public static System.Single MultiplierDefault;  // const
        public static System.Single MultiplierMin;  // const
        public static System.Single IntensityDefault;  // const
        public static System.Single IntensityMin;  // const
        public static System.Single HDRPExposureWeightDefault;  // const
        public static System.Single HDRPExposureWeightMin;  // const
        public static System.Single HDRPExposureWeightMax;  // const
        public static System.Single SpotAngleDefault;  // const
        public static System.Single SpotAngleMin;  // const
        public static System.Single SpotAngleMax;  // const
        public static System.Single ConeRadiusStart;  // const
        public static VLB.MeshType GeomMeshType;  // const
        public static System.Int32 GeomSidesDefault;  // const
        public static System.Int32 GeomSidesMin;  // const
        public static System.Int32 GeomSidesMax;  // const
        public static System.Int32 GeomSegmentsDefault;  // const
        public static System.Int32 GeomSegmentsMin;  // const
        public static System.Int32 GeomSegmentsMax;  // const
        public static System.Boolean GeomCap;  // const
        public static VLB.AttenuationEquation AttenuationEquationDefault;  // const
        public static System.Single AttenuationCustomBlendingDefault;  // const
        public static System.Single AttenuationCustomBlendingMin;  // const
        public static System.Single AttenuationCustomBlendingMax;  // const
        public static System.Single FallOffStart;  // const
        public static System.Single FallOffEnd;  // const
        public static System.Single FallOffDistancesMinThreshold;  // const
        public static System.Single DepthBlendDistance;  // const
        public static System.Single CameraClippingDistance;  // const
        public static System.Single FresnelPowMaxValue;  // const
        public static System.Single FresnelPow;  // const
        public static System.Single GlareFrontalDefault;  // const
        public static System.Single GlareBehindDefault;  // const
        public static System.Single GlareMin;  // const
        public static System.Single GlareMax;  // const
        public static VLB.NoiseMode NoiseModeDefault;  // const
        public static System.Single NoiseIntensityMin;  // const
        public static System.Single NoiseIntensityMax;  // const
        public static System.Single NoiseIntensityDefault;  // const
        public static System.Single NoiseScaleMin;  // const
        public static System.Single NoiseScaleMax;  // const
        public static readonly UnityEngine.Vector3 NoiseScalesDefault;  // static @ 0x0
        public static System.Single NoiseScaleDefault;  // const
        public static VLB.BlendingMode BlendingModeDefault;  // const
        public static VLB.ShaderAccuracy ShaderAccuracyDefault;  // const
        public static System.Single FadeOutBeginDefault;  // const
        public static System.Single FadeOutEndDefault;  // const
        public static System.Single FadeOutBeginSecondDefault;  // const
        public static System.Single FadeOutEndSecondDefault;  // const
        public static VLB.Dimensions DimensionsDefault;  // const
        public static UnityEngine.Transform ClippingPlaneTransformDefault;  // const
        public static readonly UnityEngine.Color FlatColor;  // static @ 0xc
        public static readonly UnityEngine.Vector3 NoiseVelocityDefault;  // static @ 0x1c
        public static readonly UnityEngine.Vector2 TiltDefault;  // static @ 0x28
        public static readonly UnityEngine.Vector3 SkewingLocalForwardDirectionDefault;  // static @ 0x30

        // Methods
        // RVA: 0x03B33110  token: 0x6000033
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x10
    public static class DustParticles
    {
        // Fields
        public static System.Single AlphaDefault;  // const
        public static System.Single SizeDefault;  // const
        public static VLB.ParticlesDirection DirectionDefault;  // const
        public static System.Single DensityDefault;  // const
        public static System.Single DensityMin;  // const
        public static System.Single DensityMax;  // const
        public static System.Boolean CullingEnabledDefault;  // const
        public static System.Single CullingMaxDistanceDefault;  // const
        public static System.Single CullingMaxDistanceMin;  // const
        public static readonly UnityEngine.Vector3 VelocityDefault;  // static @ 0x0
        public static readonly VLB.MinMaxRangeFloat SpawnDistanceRangeDefault;  // static @ 0xc

        // Methods
        // RVA: 0x0A293A0C  token: 0x6000034
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public static class DynOcclusion
    {
        // Fields
        public static System.Single FadeDistanceToSurfaceDefault;  // const
        public static VLB.DynamicOcclusionUpdateRate UpdateRateDefault;  // const
        public static System.Int32 WaitFramesCountDefault;  // const
        public static VLB.Dimensions RaycastingDimensionsDefault;  // const
        public static System.Boolean RaycastingConsiderTriggersDefault;  // const
        public static System.Single RaycastingMinOccluderAreaDefault;  // const
        public static System.Single RaycastingMinSurfaceRatioDefault;  // const
        public static System.Single RaycastingMinSurfaceRatioMin;  // const
        public static System.Single RaycastingMinSurfaceRatioMax;  // const
        public static System.Single RaycastingMaxSurfaceDotDefault;  // const
        public static System.Single RaycastingMaxSurfaceAngleMin;  // const
        public static System.Single RaycastingMaxSurfaceAngleMax;  // const
        public static VLB.PlaneAlignment RaycastingPlaneAlignmentDefault;  // const
        public static System.Single RaycastingPlaneOffsetDefault;  // const
        public static System.Int32 DepthBufferDepthMapResolutionDefault;  // const
        public static System.Boolean DepthBufferOcclusionCullingDefault;  // const
        public static readonly UnityEngine.LayerMask LayerMaskDefault;  // static @ 0x0

        // Methods
        // RVA: 0x0A293A74  token: 0x6000035
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x10
    public static class Config
    {
        // Fields
        public static System.Boolean GeometryOverrideLayerDefault;  // const
        public static System.Int32 GeometryLayerIDDefault;  // const
        public static System.String GeometryTagDefault;  // const
        public static System.String FadeOutCameraTagDefault;  // const
        public static VLB.RenderQueue GeometryRenderQueueDefault;  // const
        public static VLB.RenderPipeline GeometryRenderPipelineDefault;  // const
        public static VLB.RenderingMode GeometryRenderingModeDefault;  // const
        public static System.Int32 Noise3DSizeDefault;  // const
        public static System.Int32 SharedMeshSides;  // const
        public static System.Int32 SharedMeshSegments;  // const
        public static System.Single DitheringFactor;  // const
        public static System.Boolean UseLightColorTemperatureDefault;  // const
        public static System.Boolean FeatureEnabledDefault;  // const
        public static VLB.FeatureEnabledColorGradient FeatureEnabledColorGradientDefault;  // const

    }

    // TypeToken: 0x2000023  // size: 0x14
    public sealed struct BlendingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.BlendingMode Additive;  // const
        public static VLB.MaterialManager.BlendingMode SoftAdditive;  // const
        public static VLB.MaterialManager.BlendingMode TraditionalTransparency;  // const
        public static VLB.MaterialManager.BlendingMode Count;  // const

    }

    // TypeToken: 0x2000024  // size: 0x14
    public sealed struct ColorGradient
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.ColorGradient Off;  // const
        public static VLB.MaterialManager.ColorGradient MatrixLow;  // const
        public static VLB.MaterialManager.ColorGradient MatrixHigh;  // const
        public static VLB.MaterialManager.ColorGradient Count;  // const

    }

    // TypeToken: 0x2000025  // size: 0x14
    public sealed struct DepthBlend
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.DepthBlend Off;  // const
        public static VLB.MaterialManager.DepthBlend On;  // const
        public static VLB.MaterialManager.DepthBlend Count;  // const

    }

    // TypeToken: 0x2000026  // size: 0x14
    public sealed struct DynamicOcclusion
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.DynamicOcclusion Off;  // const
        public static VLB.MaterialManager.DynamicOcclusion ClippingPlane;  // const
        public static VLB.MaterialManager.DynamicOcclusion DepthTexture;  // const
        public static VLB.MaterialManager.DynamicOcclusion Count;  // const

    }

    // TypeToken: 0x2000027  // size: 0x14
    public sealed struct MeshSkewing
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.MeshSkewing Off;  // const
        public static VLB.MaterialManager.MeshSkewing On;  // const
        public static VLB.MaterialManager.MeshSkewing Count;  // const

    }

    // TypeToken: 0x2000028  // size: 0x14
    public sealed struct Noise3D
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.Noise3D Off;  // const
        public static VLB.MaterialManager.Noise3D On;  // const
        public static VLB.MaterialManager.Noise3D Count;  // const

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct ShaderAccuracy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MaterialManager.ShaderAccuracy Fast;  // const
        public static VLB.MaterialManager.ShaderAccuracy High;  // const
        public static VLB.MaterialManager.ShaderAccuracy Count;  // const

    }

    // TypeToken: 0x200002A  // size: 0x30
    public sealed struct StaticProperties
    {
        // Fields
        public System.Boolean useFog;  // 0x10
        public VLB.MaterialManager.BlendingMode blendingMode;  // 0x14
        public VLB.MaterialManager.Noise3D noise3D;  // 0x18
        public VLB.MaterialManager.DepthBlend depthBlend;  // 0x1c
        public VLB.MaterialManager.ColorGradient colorGradient;  // 0x20
        public VLB.MaterialManager.DynamicOcclusion dynamicOcclusion;  // 0x24
        public VLB.MaterialManager.MeshSkewing meshSkewing;  // 0x28
        public VLB.MaterialManager.ShaderAccuracy shaderAccuracy;  // 0x2c

        // Properties
        System.Int32 blendingModeID { get; /* RVA: 0x03D4E990 */ }
        System.Int32 noise3DID { get; /* RVA: 0x0A294EA8 */ }
        System.Int32 depthBlendID { get; /* RVA: 0x0A294D6C */ }
        System.Int32 colorGradientID { get; /* RVA: 0x0A294D38 */ }
        System.Int32 dynamicOcclusionID { get; /* RVA: 0x0A294DA0 */ }
        System.Int32 meshSkewingID { get; /* RVA: 0x0A294E74 */ }
        System.Int32 shaderAccuracyID { get; /* RVA: 0x0A294EDC */ }
        System.Int32 materialID { get; /* RVA: 0x0A294DD4 */ }

        // Methods
        // RVA: 0x0A294A14  token: 0x6000043
        public System.Void ApplyToMaterial(UnityEngine.Material mat) { }

    }

    // TypeToken: 0x200002B  // size: 0x18
    public class MaterialsGroup
    {
        // Fields
        public readonly UnityEngine.Material[] materials;  // 0x10

        // Methods
        // RVA: 0x0A294128  token: 0x6000044
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x80
    public sealed class Callback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0613B2F0  token: 0x6000045
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000046
        public virtual System.Void Invoke(VLB.MaterialModifier.Interface owner) { }
        // RVA: 0x0389C3B0  token: 0x6000047
        public virtual System.IAsyncResult BeginInvoke(VLB.MaterialModifier.Interface owner, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000048
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002E
    public interface Interface
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000049
        public virtual System.Void SetMaterialProp(System.Int32 nameID, System.Single value) { }
        // RVA: -1  // abstract  token: 0x600004A
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Vector4 value) { }
        // RVA: -1  // abstract  token: 0x600004B
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Color value) { }
        // RVA: -1  // abstract  token: 0x600004C
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        // RVA: -1  // abstract  token: 0x600004D
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Texture value) { }

    }

    // TypeToken: 0x2000033  // size: 0x1C
    public sealed struct Plane2D
    {
        // Fields
        public UnityEngine.Vector2 normal;  // 0x10
        public System.Single distance;  // 0x18

        // Methods
        // RVA: 0x03D8A050  token: 0x600005B
        public System.Single Distance(UnityEngine.Vector2 point) { }
        // RVA: 0x0A2942C8  token: 0x600005C
        public UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 pt) { }
        // RVA: 0x0A294630  token: 0x600005D
        public UnityEngine.Vector2 Intersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2) { }
        // RVA: 0x0A294614  token: 0x600005E
        public System.Boolean GetSide(UnityEngine.Vector2 point) { }
        // RVA: 0x0A294554  token: 0x600005F
        public static VLB.PolygonHelper.Plane2D FromPoints(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        // RVA: 0x0A2944E0  token: 0x6000060
        public static VLB.PolygonHelper.Plane2D FromNormalAndPoint(UnityEngine.Vector3 normalizedNormal, UnityEngine.Vector3 p1) { }
        // RVA: 0x0A2944B8  token: 0x6000061
        public System.Void Flip() { }
        // RVA: 0x0A29430C  token: 0x6000062
        public UnityEngine.Vector2[] CutConvex(UnityEngine.Vector2[] poly) { }
        // RVA: 0x0A2946FC  token: 0x6000063
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000038  // size: 0x14
    public sealed struct RenderPipeline
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.SRPHelper.RenderPipeline HGRP;  // const
        public static VLB.SRPHelper.RenderPipeline Undefined;  // const
        public static VLB.SRPHelper.RenderPipeline BuiltIn;  // const
        public static VLB.SRPHelper.RenderPipeline URP;  // const
        public static VLB.SRPHelper.RenderPipeline LWRP;  // const
        public static VLB.SRPHelper.RenderPipeline HDRP;  // const

    }

    // TypeToken: 0x200003A  // size: 0x38
    public sealed struct Packed
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Quaternion rotation;  // 0x1c
        public UnityEngine.Vector3 lossyScale;  // 0x2c

        // Methods
        // RVA: 0x0A294198  token: 0x6000070
        public System.Boolean IsSame(UnityEngine.Transform transf) { }

    }

    // TypeToken: 0x200003C  // size: 0x14
    public sealed struct FloatPackingPrecision
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.Utils.FloatPackingPrecision High;  // const
        public static VLB.Utils.FloatPackingPrecision Low;  // const
        public static VLB.Utils.FloatPackingPrecision Undef;  // const

    }

    // TypeToken: 0x200003F  // size: 0x14
    public sealed struct AttachedLightType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.VolumetricLightBeam.AttachedLightType NoLight;  // const
        public static VLB.VolumetricLightBeam.AttachedLightType OtherLight;  // const
        public static VLB.VolumetricLightBeam.AttachedLightType SpotLight;  // const

    }

    // TypeToken: 0x2000041  // size: 0x1C
    public sealed struct __StaticArrayInitTypeSize=12
    {
    }

    // TypeToken: 0x2000040  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D;  // static @ 0x0
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B;  // static @ 0xc

    }

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000004  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000003
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000004
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000005
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000006
        public System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000042  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x60000E3
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x0A293AB0  token: 0x60000E4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x0A293B14  token: 0x60000E5
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x60000E6
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000044  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60000E7
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0A297180  token: 0x60000E8
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x0A297270  token: 0x60000E9
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x0A29703C  token: 0x60000EA
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x0A297108  token: 0x60000EB
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x0A2971E4  token: 0x60000EC
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x0A296F98  token: 0x60000ED
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

}

namespace VLB
{

    // TypeToken: 0x2000009  // size: 0x98
    public class BeamGeometry : UnityEngine.MonoBehaviour, Interface
    {
        // Fields
        private VLB.VolumetricLightBeam m_Master;  // 0x18
        private UnityEngine.Matrix4x4 m_ColorGradientMatrix;  // 0x20
        private VLB.MeshType m_CurrentMeshType;  // 0x60
        private VLB.MaterialModifier.Callback m_MaterialModifierCallback;  // 0x68
        private UnityEngine.Coroutine m_CoFadeOut;  // 0x70
        private UnityEngine.MeshRenderer <meshRenderer>k__BackingField;  // 0x78
        private UnityEngine.MeshFilter <meshFilter>k__BackingField;  // 0x80
        private UnityEngine.Mesh <coneMesh>k__BackingField;  // 0x88
        public UnityEngine.Material m_CustomMaterial;  // 0x90

        // Properties
        UnityEngine.MeshRenderer meshRenderer { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }
        UnityEngine.MeshFilter meshFilter { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }
        UnityEngine.Mesh coneMesh { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x04274DA0 */ }
        System.Boolean visible { get; /* RVA: 0x0A293454 */ set; /* RVA: 0x0A2934B4 */ }
        System.Int32 sortingLayerID { get; /* RVA: 0x0A293414 */ set; /* RVA: 0x0A293474 */ }
        System.Int32 sortingOrder { get; /* RVA: 0x0A293434 */ set; /* RVA: 0x0A293494 */ }
        System.Boolean _INTERNAL_IsFadeOutCoroutineRunning { get; /* RVA: 0x08574B70 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000014
        public System.Void RestartFadeOutCoroutine() { }
        // RVA: 0x0350B670  token: 0x6000015
        public System.Void StopFadeOutCoroutine() { }
        // RVA: 0x0A293348  token: 0x6000016
        public virtual System.Void SetMaterialProp(System.Int32 nameID, System.Single value) { }
        // RVA: 0x0A2930C4  token: 0x6000017
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Vector4 value) { }
        // RVA: 0x0A2931A4  token: 0x6000018
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Color value) { }
        // RVA: 0x0A292FAC  token: 0x6000019
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        // RVA: 0x0A293284  token: 0x600001A
        public virtual System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Texture value) { }
        // RVA: 0x0426FE60  token: 0x600001B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0xB8
    public class Config : UnityEngine.ScriptableObject
    {
        // Fields
        public static System.String ClassName;  // const
        public static System.String kAssetName;  // const
        public static System.String kAssetNameExt;  // const
        private static VLB.Config ms_Instance;  // static @ 0x0
        public UnityEngine.Mesh sharedMesh;  // 0x18
        public System.Boolean featureEnabledDustParticles;  // 0x20
        public System.Boolean featureEnabledEffect;  // 0x21
        public System.Boolean featureEnabledTriggerZone;  // 0x22
        public System.Boolean geometryOverrideLayer;  // 0x23
        public System.Int32 geometryLayerID;  // 0x24
        public System.String geometryTag;  // 0x28
        public System.Int32 geometryRenderQueue;  // 0x30
        private VLB.RenderPipeline _RenderPipeline;  // 0x34
        private VLB.RenderingMode _RenderingMode;  // 0x38
        public System.Single ditheringFactor;  // 0x3c
        public System.Boolean useLightColorTemperature;  // 0x40
        public System.Int32 sharedMeshSides;  // 0x44
        public System.Int32 sharedMeshSegments;  // 0x48
        public UnityEngine.Vector3 globalNoisesScale;  // 0x4c
        public UnityEngine.Vector3 globalNoiseVelocity;  // 0x58
        public System.String fadeOutCameraTag;  // 0x68
        public UnityEngine.Texture3D noiseTexture3D;  // 0x70
        public UnityEngine.ParticleSystem dustParticlesPrefab;  // 0x78
        public UnityEngine.Texture2D ditheringNoiseTexture;  // 0x80
        public VLB.FeatureEnabledColorGradient featureEnabledColorGradient;  // 0x88
        public System.Boolean featureEnabledDepthBlend;  // 0x8c
        public System.Boolean featureEnabledNoise3D;  // 0x8d
        public System.Boolean featureEnabledDynamicOcclusion;  // 0x8e
        public System.Boolean featureEnabledMeshSkewing;  // 0x8f
        public System.Boolean featureEnabledShaderAccuracyHigh;  // 0x90
        private UnityEngine.Shader _BeamShader;  // 0x98
        private UnityEngine.Transform m_CachedFadeOutCamera;  // 0xa0
        private System.Int32 pluginVersion;  // 0xa8
        private UnityEngine.Material _DummyMaterial;  // 0xb0

        // Properties
        VLB.RenderPipeline renderPipeline { get; /* RVA: 0x03D4EE00 */ }
        VLB.RenderingMode renderingMode { get; /* RVA: 0x03D4EC30 */ }
        VLB.RenderingMode actualRenderingMode { get; /* RVA: 0x0A293964 */ }
        System.Boolean useSinglePassShader { get; /* RVA: 0x0A2939F4 */ }
        System.Boolean requiresDoubleSidedMesh { get; /* RVA: 0x0A2939F4 */ }
        UnityEngine.Shader beamShader { get; /* RVA: 0x011AC510 */ }
        UnityEngine.Transform fadeOutCameraTransform { get; /* RVA: 0x0A293980 */ }
        System.Boolean isHDRPExposureWeightSupported { get; /* RVA: 0x0A2939EC */ }
        System.Boolean hasRenderPipelineMismatch { get; /* RVA: 0x039ABF50 */ }
        VLB.Config Instance { get; /* RVA: 0x04276CA0 */ }

        // Methods
        // RVA: 0x0A293860  token: 0x6000026
        public System.Void Reset() { }
        // RVA: 0x03D4B9C0  token: 0x6000027
        private System.Void OnEnable() { }
        // RVA: 0x0115F4C0  token: 0x6000028
        public System.Boolean IsSRPBatcherSupported() { }
        // RVA: 0x0A293530  token: 0x6000029
        public System.Void ForceUpdateFadeOutCamera() { }
        // RVA: 0x039ABEB0  token: 0x600002A
        private static System.Void OnStartup() { }
        // RVA: 0x039AC060  token: 0x600002B
        private System.Void RefreshGlobalShaderProperties() { }
        // RVA: 0x0A2936EC  token: 0x600002C
        public System.Void ResetInternalData() { }
        // RVA: 0x0A2935B4  token: 0x600002D
        public UnityEngine.ParticleSystem NewVolumetricDustParticles() { }
        // RVA: 0x03D4B9D0  token: 0x600002E
        private System.Void HandleBackwardCompatibility(System.Int32 serializedVersion, System.Int32 newVersion) { }
        // RVA: 0x0398BB80  token: 0x600002F
        private static VLB.Config LoadAssetInternal(System.String assetName) { }
        // RVA: 0x0398BA30  token: 0x6000030
        private static VLB.Config GetInstance(System.Boolean assertIfNotFound) { }
        // RVA: 0x03B5B630  token: 0x6000031
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x10
    public static class Consts
    {
        // Fields
        public static System.String PluginFolder;  // const

    }

    // TypeToken: 0x2000012  // size: 0x10
    public static class DummyMaterial
    {
    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct FeatureEnabledColorGradient
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.FeatureEnabledColorGradient Off;  // const
        public static VLB.FeatureEnabledColorGradient HighOnly;  // const
        public static VLB.FeatureEnabledColorGradient HighAndLow;  // const

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct ColorMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.ColorMode Flat;  // const
        public static VLB.ColorMode Gradient;  // const

    }

    // TypeToken: 0x2000015  // size: 0x14
    public sealed struct AttenuationEquation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.AttenuationEquation Linear;  // const
        public static VLB.AttenuationEquation Quadratic;  // const
        public static VLB.AttenuationEquation Blend;  // const

    }

    // TypeToken: 0x2000016  // size: 0x14
    public sealed struct BlendingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.BlendingMode Additive;  // const
        public static VLB.BlendingMode SoftAdditive;  // const
        public static VLB.BlendingMode TraditionalTransparency;  // const

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct ShaderAccuracy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.ShaderAccuracy Fast;  // const
        public static VLB.ShaderAccuracy High;  // const

    }

    // TypeToken: 0x2000018  // size: 0x14
    public sealed struct NoiseMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.NoiseMode Disabled;  // const
        public static VLB.NoiseMode WorldSpace;  // const
        public static VLB.NoiseMode LocalSpace;  // const

    }

    // TypeToken: 0x2000019  // size: 0x14
    public sealed struct MeshType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.MeshType Shared;  // const
        public static VLB.MeshType Custom;  // const

    }

    // TypeToken: 0x200001A  // size: 0x14
    public sealed struct RenderPipeline
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.RenderPipeline HGRP;  // const
        public static VLB.RenderPipeline BuiltIn;  // const
        public static VLB.RenderPipeline URP;  // const
        public static VLB.RenderPipeline HDRP;  // const

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct RenderingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.RenderingMode MultiPass;  // const
        public static VLB.RenderingMode SinglePass;  // const
        public static VLB.RenderingMode GPUInstancing;  // const
        public static VLB.RenderingMode SRPBatcher;  // const

    }

    // TypeToken: 0x200001C  // size: 0x14
    public sealed struct RenderQueue
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.RenderQueue Custom;  // const
        public static VLB.RenderQueue Background;  // const
        public static VLB.RenderQueue Geometry;  // const
        public static VLB.RenderQueue AlphaTest;  // const
        public static VLB.RenderQueue GeometryLast;  // const
        public static VLB.RenderQueue Transparent;  // const
        public static VLB.RenderQueue Overlay;  // const

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct Dimensions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.Dimensions Dim3D;  // const
        public static VLB.Dimensions Dim2D;  // const

    }

    // TypeToken: 0x200001E  // size: 0x14
    public sealed struct PlaneAlignment
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.PlaneAlignment Surface;  // const
        public static VLB.PlaneAlignment Beam;  // const

    }

    // TypeToken: 0x200001F  // size: 0x14
    public sealed struct DynamicOcclusionUpdateRate
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.DynamicOcclusionUpdateRate Never;  // const
        public static VLB.DynamicOcclusionUpdateRate OnEnable;  // const
        public static VLB.DynamicOcclusionUpdateRate OnBeamMove;  // const
        public static VLB.DynamicOcclusionUpdateRate EveryXFrames;  // const
        public static VLB.DynamicOcclusionUpdateRate OnBeamMoveAndEveryXFrames;  // const

    }

    // TypeToken: 0x2000020  // size: 0x14
    public sealed struct ParticlesDirection
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static VLB.ParticlesDirection Random;  // const
        public static VLB.ParticlesDirection LocalSpace;  // const
        public static VLB.ParticlesDirection WorldSpace;  // const

    }

    // TypeToken: 0x2000021  // size: 0x10
    public sealed class HighlightNullAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000036
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x10
    public static class MaterialManager
    {
        // Fields
        public static System.Int32 staticPropertiesCount;  // const
        public static UnityEngine.MaterialPropertyBlock materialPropertyBlock;  // static @ 0x0
        private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor;  // static @ 0x8
        private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor;  // static @ 0x10
        private static readonly System.Boolean[] BlendingMode_AlphaAsBlack;  // static @ 0x18
        private static readonly System.Collections.Hashtable ms_MaterialsGroup;  // static @ 0x20

        // Methods
        // RVA: 0x0A293E58  token: 0x6000037
        public static UnityEngine.Material NewMaterialTransient(System.Boolean gpuInstanced) { }
        // RVA: 0x0A293D9C  token: 0x6000038
        public static UnityEngine.Material NewMaterialPersistent(UnityEngine.Shader shader, System.Boolean gpuInstanced) { }
        // RVA: 0x0A293BA8  token: 0x6000039
        public static UnityEngine.Material GetInstancedMaterial(System.UInt32 groupID, VLB.MaterialManager.StaticProperties& staticProps) { }
        // RVA: 0x0A293F18  token: 0x600003A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x10
    public static class MaterialModifier
    {
    }

    // TypeToken: 0x200002F  // size: 0x18
    public sealed struct MinMaxRangeFloat
    {
        // Fields
        private System.Single m_MinValue;  // 0x10
        private System.Single m_MaxValue;  // 0x14

        // Properties
        System.Single minValue { get; /* RVA: 0x03D4FA00 */ }
        System.Single maxValue { get; /* RVA: 0x03D58BC0 */ }
        System.Single randomValue { get; /* RVA: 0x0A294184 */ }
        UnityEngine.Vector2 asVector2 { get; /* RVA: 0x03D51540 */ }

        // Methods
        // RVA: 0x03D50430  token: 0x600004E
        public System.Void .ctor(System.Single min, System.Single max) { }
        // RVA: 0x0A294170  token: 0x6000053
        public System.Single GetLerpedValue(System.Single lerp01) { }

    }

    // TypeToken: 0x2000030  // size: 0x18
    public class MinMaxRangeAttribute : System.Attribute
    {
        // Fields
        private readonly System.Single <minValue>k__BackingField;  // 0x10
        private readonly System.Single <maxValue>k__BackingField;  // 0x14

        // Properties
        System.Single minValue { get; /* RVA: 0x03D4E7A0 */ }
        System.Single maxValue { get; /* RVA: 0x03D51930 */ }

        // Methods
        // RVA: 0x03D5E2F0  token: 0x6000054
        public System.Void .ctor(System.Single min, System.Single max) { }

    }

    // TypeToken: 0x2000031  // size: 0x10
    public class PlatformHelper
    {
        // Methods
        // RVA: 0x0398BBC0  token: 0x6000057
        public static System.String GetCurrentPlatformSuffix() { }
        // RVA: 0x0398BBE0  token: 0x6000058
        private static System.String GetPlatformSuffix(UnityEngine.RuntimePlatform platform) { }
        // RVA: 0x0350B670  token: 0x6000059
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x18
    public class PolygonHelper : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x600005A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x10
    public static class ShaderKeywords
    {
        // Fields
        public static System.String UseFog;  // const
        public static System.String AlphaAsBlack;  // const
        public static System.String ColorGradientMatrixLow;  // const
        public static System.String ColorGradientMatrixHigh;  // const
        public static System.String DepthBlend;  // const
        public static System.String Noise3D;  // const
        public static System.String OcclusionClippingPlane;  // const
        public static System.String OcclusionDepthTexture;  // const
        public static System.String MeshSkewing;  // const
        public static System.String ShaderAccuracyHigh;  // const

    }

    // TypeToken: 0x2000035  // size: 0x10
    public static class ShaderProperties
    {
        // Fields
        public static readonly System.Int32 ConeParams0;  // static @ 0x0
        public static readonly System.Int32 ConeParams1;  // static @ 0x4
        public static readonly System.Int32 TiltVectorX;  // static @ 0x8
        public static readonly System.Int32 TiltVectorY;  // static @ 0xc
        public static readonly System.Int32 DistanceFadeStart;  // static @ 0x10
        public static readonly System.Int32 DistanceFadeEnd;  // static @ 0x14
        public static readonly System.Int32 DistanceFadeStartSecond;  // static @ 0x18
        public static readonly System.Int32 DistanceFadeEndSecond;  // static @ 0x1c
        public static readonly System.Int32 NoiseVelocity;  // static @ 0x20
        public static readonly System.Int32 NoiseScale;  // static @ 0x24
        public static readonly System.Int32 DepthBlendCapOff;  // static @ 0x28
        public static readonly System.Int32 BlendMode;  // static @ 0x2c
        public static readonly System.Int32 FogIntensity;  // static @ 0x30
        public static readonly System.Int32 ClippingPlaneTransition;  // static @ 0x34
        public static readonly System.Int32 UseClippingPlane;  // static @ 0x38
        public static readonly System.Int32 FadeOutFactor;  // static @ 0x3c
        public static readonly System.Int32 ConeSlopeCosSin;  // static @ 0x40
        public static readonly System.Int32 ConeRadius;  // static @ 0x44
        public static readonly System.Int32 ConeGeomProps;  // static @ 0x48
        public static readonly System.Int32 ColorFlat;  // static @ 0x4c
        public static readonly System.Int32 AlphaInside;  // static @ 0x50
        public static readonly System.Int32 AlphaOutside;  // static @ 0x54
        public static readonly System.Int32 HDRPExposureWeight;  // static @ 0x58
        public static readonly System.Int32 AttenuationLerpLinearQuad;  // static @ 0x5c
        public static readonly System.Int32 DistanceFallOff;  // static @ 0x60
        public static readonly System.Int32 DistanceCamClipping;  // static @ 0x64
        public static readonly System.Int32 FresnelPow;  // static @ 0x68
        public static readonly System.Int32 GlareBehind;  // static @ 0x6c
        public static readonly System.Int32 GlareFrontal;  // static @ 0x70
        public static readonly System.Int32 DrawCap;  // static @ 0x74
        public static readonly System.Int32 DepthBlendDistance;  // static @ 0x78
        public static readonly System.Int32 NoiseVelocityAndScale;  // static @ 0x7c
        public static readonly System.Int32 NoiseParam;  // static @ 0x80
        public static readonly System.Int32 CameraParams;  // static @ 0x84
        public static readonly System.Int32 ColorGradientMatrix;  // static @ 0x88
        public static readonly System.Int32 LocalToWorldMatrix;  // static @ 0x8c
        public static readonly System.Int32 WorldToLocalMatrix;  // static @ 0x90
        public static readonly System.Int32 BlendSrcFactor;  // static @ 0x94
        public static readonly System.Int32 BlendDstFactor;  // static @ 0x98
        public static readonly System.Int32 DynamicOcclusionClippingPlaneWS;  // static @ 0x9c
        public static readonly System.Int32 DynamicOcclusionClippingPlaneProps;  // static @ 0xa0
        public static readonly System.Int32 DynamicOcclusionDepthTexture;  // static @ 0xa4
        public static readonly System.Int32 DynamicOcclusionDepthProps;  // static @ 0xa8
        public static readonly System.Int32 LocalForwardDirection;  // static @ 0xac
        public static readonly System.Int32 TiltVector;  // static @ 0xb0
        public static readonly System.Int32 AdditionalClippingPlaneWS;  // static @ 0xb4
        public static readonly System.Int32 ParticlesTintColor;  // static @ 0xb8
        public static readonly System.Int32 GlobalUsesReversedZBuffer;  // static @ 0xbc
        public static readonly System.Int32 GlobalNoiseTex3D;  // static @ 0xc0
        public static readonly System.Int32 GlobalNoiseCustomTime;  // static @ 0xc4
        public static readonly System.Int32 GlobalDitheringFactor;  // static @ 0xc8
        public static readonly System.Int32 GlobalDitheringNoiseTex;  // static @ 0xcc

        // Methods
        // RVA: 0x0370AD50  token: 0x6000064
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000036  // size: 0x10
    public static class SpotLightHelper
    {
        // Methods
        // RVA: 0x0A294854  token: 0x6000065
        public static System.Void GetCullingDistance(UnityEngine.Light light, System.Single& cullingDistance, System.Single& falloffDistance) { }
        // RVA: 0x0A294944  token: 0x6000066
        public static System.Single GetIntensity(UnityEngine.Light light) { }
        // RVA: 0x0A2949AC  token: 0x6000067
        public static System.Single GetSpotAngle(UnityEngine.Light light) { }
        // RVA: 0x0A2948DC  token: 0x6000068
        public static System.Single GetFallOffEnd(UnityEngine.Light light) { }

    }

    // TypeToken: 0x2000037  // size: 0x10
    public static class SRPHelper
    {
        // Fields
        private static VLB.SRPHelper.RenderPipeline m_RenderPipelineCached;  // static @ 0x0

        // Properties
        VLB.SRPHelper.RenderPipeline renderPipelineType { get; /* RVA: 0x039ABFC0 */ }

        // Methods
        // RVA: 0x01002730  token: 0x600006A
        private static VLB.SRPHelper.RenderPipeline ComputeRenderPipeline() { }
        // RVA: 0x0232EB60  token: 0x600006B
        public static System.Boolean IsUsingCustomRenderPipeline() { }
        // RVA: 0x0A2947BC  token: 0x600006C
        public static System.Void RegisterOnBeginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> cb) { }
        // RVA: 0x0A294808  token: 0x600006D
        public static System.Void UnregisterOnBeginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> cb) { }
        // RVA: 0x03D43CE0  token: 0x600006E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x10
    public static class TransformUtils
    {
        // Methods
        // RVA: 0x0A294F10  token: 0x600006F
        public static VLB.TransformUtils.Packed GetWorldPacked(UnityEngine.Transform self) { }

    }

    // TypeToken: 0x200003B  // size: 0x10
    public static class Utils
    {
        // Fields
        private static System.Single kEpsilon;  // const
        private static System.Int32 kFloatPackingHighMinShaderLevel;  // const
        private static VLB.Utils.FloatPackingPrecision ms_FloatPackingPrecision;  // static @ 0x0

        // Methods
        // RVA: 0x03D8A0A0  token: 0x6000071
        public static System.Single ComputeConeRadiusEnd(System.Single fallOffEnd, System.Single spotAngle) { }
        // RVA: 0x03D8A0E0  token: 0x6000072
        public static System.Single ComputeSpotAngle(System.Single fallOffEnd, System.Single coneRadiusEnd) { }
        // RVA: -1  // generic def  token: 0x6000073
        public static System.Void Swap(T& a, T& b) { }
        // RVA: 0x0A2952F0  token: 0x6000074
        public static System.String GetPath(UnityEngine.Transform current) { }
        // RVA: -1  // generic def  token: 0x6000075
        public static T NewWithComponent(System.String name) { }
        // RVA: -1  // generic def  token: 0x6000076
        public static T GetOrAddComponent(UnityEngine.GameObject self) { }
        // RVA: -1  // generic def  token: 0x6000077
        public static T GetOrAddComponent(UnityEngine.MonoBehaviour self) { }
        // RVA: -1  // generic def  token: 0x6000078
        public static System.Void ForeachComponentsOnlyInChildren(UnityEngine.GameObject self, System.Action<T> lambda, System.Boolean includeInactive) { }
        // RVA: 0x0A295410  token: 0x6000079
        public static System.Boolean HasFlag(System.Enum mask, System.Enum flags) { }
        // RVA: 0x03D51540  token: 0x600007A
        public static UnityEngine.Vector2 xy(UnityEngine.Vector3 aVector) { }
        // RVA: 0x03D51590  token: 0x600007B
        public static UnityEngine.Vector2 xz(UnityEngine.Vector3 aVector) { }
        // RVA: 0x03D54520  token: 0x600007C
        public static UnityEngine.Vector2 yz(UnityEngine.Vector3 aVector) { }
        // RVA: 0x03D7F9F0  token: 0x600007D
        public static UnityEngine.Vector2 yx(UnityEngine.Vector3 aVector) { }
        // RVA: 0x03D80D00  token: 0x600007E
        public static UnityEngine.Vector2 zx(UnityEngine.Vector3 aVector) { }
        // RVA: 0x03D80E60  token: 0x600007F
        public static UnityEngine.Vector2 zy(UnityEngine.Vector3 aVector) { }
        // RVA: 0x05717BC8  token: 0x6000080
        public static System.Boolean Approximately(System.Single a, System.Single b, System.Single epsilon) { }
        // RVA: 0x0A294F9C  token: 0x6000081
        public static System.Boolean Approximately(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single epsilon) { }
        // RVA: 0x0A294FD0  token: 0x6000082
        public static System.Boolean Approximately(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single epsilon) { }
        // RVA: 0x0A295034  token: 0x6000083
        public static System.Boolean Approximately(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single epsilon) { }
        // RVA: 0x03D8A080  token: 0x6000084
        public static UnityEngine.Vector4 AsVector4(UnityEngine.Vector3 vec3, System.Single w) { }
        // RVA: 0x0A2955A8  token: 0x6000085
        public static UnityEngine.Vector4 PlaneEquation(UnityEngine.Vector3 normalizedNormal, UnityEngine.Vector3 pt) { }
        // RVA: 0x0A2953B4  token: 0x6000086
        public static System.Single GetVolumeCubic(UnityEngine.Bounds self) { }
        // RVA: 0x0A295244  token: 0x6000087
        public static System.Single GetMaxArea2D(UnityEngine.Bounds self) { }
        // RVA: 0x03D8A110  token: 0x6000088
        public static UnityEngine.Color Opaque(UnityEngine.Color self) { }
        // RVA: 0x0A295130  token: 0x6000089
        public static UnityEngine.Color ComputeComplementaryColor(UnityEngine.Color self, System.Boolean blackAndWhite) { }
        // RVA: 0x0A2957A8  token: 0x600008A
        public static UnityEngine.Plane TranslateCustom(UnityEngine.Plane plane, UnityEngine.Vector3 translation) { }
        // RVA: 0x0A295088  token: 0x600008B
        public static UnityEngine.Vector3 ClosestPointOnPlaneCustom(UnityEngine.Plane plane, UnityEngine.Vector3 point) { }
        // RVA: 0x0A29548C  token: 0x600008C
        public static System.Boolean IsAlmostZero(System.Single f) { }
        // RVA: 0x0A2954A4  token: 0x600008D
        public static System.Boolean IsValid(UnityEngine.Plane plane) { }
        // RVA: 0x056EC558  token: 0x600008E
        public static System.Void SetKeywordEnabled(UnityEngine.Material mat, System.String name, System.Boolean enabled) { }
        // RVA: 0x0A295784  token: 0x600008F
        public static System.Void SetShaderKeywordEnabled(System.String name, System.Boolean enabled) { }
        // RVA: 0x0A2956E0  token: 0x6000090
        public static UnityEngine.Matrix4x4 SampleInMatrix(UnityEngine.Gradient self, System.Int32 floatPackingPrecision) { }
        // RVA: 0x0A29561C  token: 0x6000091
        public static UnityEngine.Color[] SampleInArray(UnityEngine.Gradient self, System.Int32 samplesCount) { }
        // RVA: 0x03D7ACF0  token: 0x6000092
        private static UnityEngine.Vector4 Vector4_Floor(UnityEngine.Vector4 vec) { }
        // RVA: 0x0A2954D4  token: 0x6000093
        public static System.Single PackToFloat(UnityEngine.Color color, System.Int32 floatPackingPrecision) { }
        // RVA: 0x0A2951D4  token: 0x6000094
        public static VLB.Utils.FloatPackingPrecision GetFloatPackingPrecision() { }
        // RVA: 0x0350B670  token: 0x6000095
        public static System.Void MarkCurrentSceneDirty() { }
        // RVA: 0x0350B670  token: 0x6000096
        public static System.Void MarkObjectDirty(UnityEngine.Object obj) { }

    }

    // TypeToken: 0x200003D  // size: 0x10
    public static class Version
    {
        // Fields
        public static System.Int32 Current;  // const

    }

    // TypeToken: 0x200003E  // size: 0x170
    public class VolumetricLightBeam : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.PlatformLayers platformLayers;  // 0x18
        public static System.String ClassName;  // const
        public System.Boolean colorFromLight;  // 0x1c
        public VLB.ColorMode colorMode;  // 0x20
        public UnityEngine.Color color;  // 0x24
        public UnityEngine.Gradient colorGradient;  // 0x38
        public System.Boolean intensityFromLight;  // 0x40
        public System.Boolean intensityModeAdvanced;  // 0x41
        public System.Single intensityInside;  // 0x44
        public System.Single intensityOutside;  // 0x48
        public System.Single intensityMultiplier;  // 0x4c
        public System.Single hdrpExposureWeight;  // 0x50
        public VLB.BlendingMode blendingMode;  // 0x54
        public System.Boolean spotAngleFromLight;  // 0x58
        public System.Single spotAngle;  // 0x5c
        public System.Single spotAngleMultiplier;  // 0x60
        public System.Single coneRadiusStart;  // 0x64
        public VLB.ShaderAccuracy shaderAccuracy;  // 0x68
        public VLB.MeshType geomMeshType;  // 0x6c
        public System.Int32 geomCustomSides;  // 0x70
        public System.Int32 geomCustomSegments;  // 0x74
        public UnityEngine.Vector3 skewingLocalForwardDirection;  // 0x78
        public System.Boolean useAdditionalClippingPlane;  // 0x84
        public UnityEngine.Transform clippingPlaneTransform;  // 0x88
        public UnityEngine.Vector3 clippingPlanePosition;  // 0x90
        public UnityEngine.Quaternion clippingPlaneRotation;  // 0x9c
        public System.Single clippingPlaneTransition;  // 0xac
        public System.Boolean geomCap;  // 0xb0
        public VLB.AttenuationEquation attenuationEquation;  // 0xb4
        public System.Single attenuationCustomBlending;  // 0xb8
        public System.Single fallOffStart;  // 0xbc
        public System.Single fallOffEnd;  // 0xc0
        public System.Boolean fallOffEndFromLight;  // 0xc4
        private UnityEngine.Light m_CachedLightSpot;  // 0xc8
        public System.Single fallOffCap;  // 0xd0
        public System.Single fallOffEndMultiplier;  // 0xd4
        public System.Boolean depthBlendCapOff;  // 0xd8
        public System.Single depthBlendDistance;  // 0xdc
        public System.Single cameraClippingDistance;  // 0xe0
        public System.Single glareFrontal;  // 0xe4
        public System.Single glareBehind;  // 0xe8
        public System.Single fresnelPow;  // 0xec
        public VLB.NoiseMode noiseMode;  // 0xf0
        public System.Single noiseIntensity;  // 0xf4
        public System.Boolean noiseScaleUseGlobal;  // 0xf8
        public System.Boolean noiseScaleUseSeparateAxis;  // 0xf9
        public UnityEngine.Vector3 noiseScalesLocal;  // 0xfc
        public System.Single noiseScaleLocal;  // 0x108
        public System.Boolean noiseVelocityUseGlobal;  // 0x10c
        public UnityEngine.Vector3 noiseVelocityLocal;  // 0x110
        public System.Boolean fadeOutFromLight;  // 0x11c
        public System.Single fadeOutBeginSecond;  // 0x120
        public System.Single fadeOutEndSecond;  // 0x124
        public System.Boolean useFog;  // 0x128
        public System.Single fogIntensity;  // 0x12c
        public VLB.Dimensions dimensions;  // 0x130
        public UnityEngine.Vector2 tiltFactor;  // 0x134
        private System.Int32 pluginVersion;  // 0x13c
        private System.Boolean _TrackChangesDuringPlaytime;  // 0x140
        private System.Int32 _SortingLayerID;  // 0x144
        private System.Int32 _SortingOrder;  // 0x148
        private System.Single _FadeOutBegin;  // 0x14c
        private System.Single _FadeOutEnd;  // 0x150
        private System.UInt32 <_INTERNAL_InstancedMaterialGroupID>k__BackingField;  // 0x154
        public VLB.BeamGeometry m_BeamGeom;  // 0x158
        public System.Boolean matIsPersistent;  // 0x160
        private UnityEngine.Coroutine m_CoPlaytimeUpdate;  // 0x168

        // Properties
        VLB.ColorMode usedColorMode { get; /* RVA: 0x0A296D00 */ }
        System.Boolean useColorFromAttachedLightSpot { get; /* RVA: 0x0A296B50 */ }
        System.Boolean useColorTemperatureFromAttachedLightSpot { get; /* RVA: 0x0A296BA8 */ }
        System.Single alphaInside { get; /* RVA: 0x03D4EC80 */ set; /* RVA: 0x03D4ED00 */ }
        System.Single alphaOutside { get; /* RVA: 0x03D58370 */ set; /* RVA: 0x03D5BE60 */ }
        System.Single intensityGlobal { get; /* RVA: 0x03D58370 */ set; /* RVA: 0x03D8A170 */ }
        System.Boolean useIntensityFromAttachedLightSpot { get; /* RVA: 0x0A296C50 */ }
        System.Boolean useSpotAngleFromAttachedLightSpot { get; /* RVA: 0x0A296CA8 */ }
        System.Single coneAngle { get; /* RVA: 0x0A296030 */ }
        System.Single coneRadiusEnd { get; /* RVA: 0x0A2961F0 */ set; /* RVA: 0x0A296D34 */ }
        System.Single coneVolume { get; /* RVA: 0x0A296250 */ }
        System.Single coneApexOffsetZ { get; /* RVA: 0x0A296088 */ }
        UnityEngine.Vector3 coneApexPositionLocal { get; /* RVA: 0x0A2961C0 */ }
        UnityEngine.Vector3 coneApexPositionGlobal { get; /* RVA: 0x0A2960F8 */ }
        System.Int32 geomSides { get; /* RVA: 0x0A2962EC */ set; /* RVA: 0x0A296DE8 */ }
        System.Int32 geomSegments { get; /* RVA: 0x0A2962C0 */ set; /* RVA: 0x0A296D88 */ }
        UnityEngine.Vector3 skewingLocalForwardDirectionNormalized { get; /* RVA: 0x0A296A44 */ }
        System.Boolean canHaveMeshSkewing { get; /* RVA: 0x0232EB60 */ }
        System.Boolean hasMeshSkewing { get; /* RVA: 0x0A29636C */ }
        UnityEngine.Vector4 additionalClippingPlane { get; /* RVA: 0x0A295B28 */ }
        System.Single attenuationLerpLinearQuad { get; /* RVA: 0x0A295CE8 */ }
        System.Single fadeStart { get; /* RVA: 0x03D582F0 */ set; /* RVA: 0x03D71A70 */ }
        System.Single fadeEnd { get; /* RVA: 0x03D5D790 */ set; /* RVA: 0x03D5D7B0 */ }
        System.Boolean fadeEndFromLight { get; /* RVA: 0x03D57F00 */ set; /* RVA: 0x03D57F80 */ }
        UnityEngine.Light lightSpotAttached { get; /* RVA: 0x03D4E7C0 */ }
        System.Boolean useFallOffEndFromAttachedLightSpot { get; /* RVA: 0x0A296BF4 */ }
        System.Single maxGeometryDistance { get; /* RVA: 0x0A296564 */ }
        System.Boolean isNoiseEnabled { get; /* RVA: 0x0A296408 */ }
        System.Boolean noiseEnabled { get; /* RVA: 0x0A296408 */ set; /* RVA: 0x0A296E48 */ }
        System.Single cullingDistance { get; /* RVA: 0x0A2962A0 */ }
        System.Single fadeOutBegin { get; /* RVA: 0x03D575C0 */ set; /* RVA: 0x03D8A150 */ }
        System.Single fadeOutEnd { get; /* RVA: 0x03D581F0 */ set; /* RVA: 0x03D8A160 */ }
        System.Boolean isFadeOutEnabled { get; /* RVA: 0x0A2963E4 */ }
        System.Boolean isTilted { get; /* RVA: 0x0A296414 */ }
        System.Int32 sortingLayerID { get; /* RVA: 0x03D76300 */ set; /* RVA: 0x0A296E68 */ }
        System.String sortingLayerName { get; /* RVA: 0x0A296B40 */ set; /* RVA: 0x0A296EEC */ }
        System.Int32 sortingOrder { get; /* RVA: 0x03D72F40 */ set; /* RVA: 0x0A296F14 */ }
        System.Boolean trackChangesDuringPlaytime { get; /* RVA: 0x03D576E0 */ set; /* RVA: 0x03D8A180 */ }
        System.Boolean isCurrentlyTrackingChanges { get; /* RVA: 0x0A2963D8 */ }
        System.Boolean hasGeometry { get; /* RVA: 0x0A296318 */ }
        UnityEngine.Bounds bounds { get; /* RVA: 0x0A295F34 */ }
        System.Int32 blendingModeAsInt { get; /* RVA: 0x0A295E88 */ }
        UnityEngine.Quaternion beamInternalLocalRotation { get; /* RVA: 0x0A295DC8 */ }
        UnityEngine.Vector3 beamLocalForward { get; /* RVA: 0x0A295E4C */ }
        UnityEngine.Vector3 beamGlobalForward { get; /* RVA: 0x0A295D10 */ }
        UnityEngine.Vector3 lossyScale { get; /* RVA: 0x0A296474 */ }
        System.Single raycastDistance { get; /* RVA: 0x0A296878 */ }
        UnityEngine.Vector3 raycastGlobalForward { get; /* RVA: 0x0A296920 */ }
        UnityEngine.Vector3 raycastGlobalUp { get; /* RVA: 0x0A2969F4 */ }
        UnityEngine.Vector3 raycastGlobalRight { get; /* RVA: 0x0A2969A4 */ }
        System.Int32 _INTERNAL_pluginVersion { get; /* RVA: 0x03D4FC20 */ }
        System.UInt32 _INTERNAL_InstancedMaterialGroupID { get; /* RVA: 0x03D58C90 */ set; /* RVA: 0x03D8A140 */ }
        System.String meshStats { get; /* RVA: 0x0A296594 */ }
        System.Int32 meshVerticesCount { get; /* RVA: 0x0A2967CC */ }
        System.Int32 meshTrianglesCount { get; /* RVA: 0x0A296708 */ }

        // Methods
        // RVA: 0x0A29590C  token: 0x60000A1
        public System.Void GetInsideAndOutsideIntensity(System.Single& inside, System.Single& outside) { }
        // RVA: 0x0A29583C  token: 0x60000D7
        private UnityEngine.Vector3 ComputeRaycastGlobalVector(UnityEngine.Vector3 localVec) { }
        // RVA: 0x03D8A130  token: 0x60000DC
        private System.Void SetFadeOutValue(System.Single& propToChange, System.Single value) { }
        // RVA: 0x0A295930  token: 0x60000E2
        public System.Void .ctor() { }

    }

}

