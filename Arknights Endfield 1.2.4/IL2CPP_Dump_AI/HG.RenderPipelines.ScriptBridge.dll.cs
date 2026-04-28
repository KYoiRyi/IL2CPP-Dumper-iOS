// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.ScriptBridge.dll
// Classes:  5
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

CLASS: HG.Rendering.ScriptBridge.HGRenderBridgeStatics
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x087C23F4  token=0x6000001  UnityEngine.Camera AttachHGCamera(UnityEngine.GameObject camObject)
  RVA=0x087C2568  token=0x6000002  UnityEngine.Material GetHGDecalProjectorMaterialInChildren(UnityEngine.GameObject go)
  RVA=0x087C24C0  token=0x6000003  UnityEngine.HGDecalProjector GetHGDecalProjectorInChildren(UnityEngine.GameObject go)
  RVA=0x087C28A0  token=0x6000004  System.Void SetHGDecalProjectorProgress(UnityEngine.Object component, System.Single progress)
  RVA=0x087C27F8  token=0x6000005  System.Void SetHGDecalProjectorHollow(UnityEngine.Object component, System.Single hollow)
  RVA=0x02B99300  token=0x6000006  System.Void HGCharacterHelperFindRenderers(UnityEngine.GameObject go)
  RVA=0x087C2718  token=0x6000007  System.Void SetHGDecalProjectorAngle(UnityEngine.GameObject go, System.Single angle)
  RVA=0x02A117A0  token=0x6000008  System.Void UpdateCurrentPlayerCenter(UnityEngine.Transform centerTransform)
  RVA=0x087C2B08  token=0x6000009  System.Void UpdateAnchorBrightParams(UnityEngine.Vector2 anchorPosition, System.Single anchorRadius, System.Single anchorBrightIntensity, System.Boolean anchorBrightFlag)
  RVA=0x087C2A04  token=0x600000A  System.Void SetVFXPPPriorityFilterCinematic()
  RVA=0x087C2A5C  token=0x600000B  System.Void SetVFXPPPriorityFilterNormal()
  RVA=0x087C2AB0  token=0x600000C  System.Void SetVFXPPPriorityFilterUltiSkillCam()
  RVA=0x087C29A8  token=0x600000D  System.Void SetVFXPPActive(System.Boolean isActive)
  RVA=0x087C294C  token=0x600000E  System.Void SetSceneDarkEnabled(System.Boolean enabled)
  RVA=0x087C26A0  token=0x600000F  System.String GetWorldUIKeyword()
  RVA=0x02A7B950  token=0x6000010  System.Void SetCharacterPositionsHeights(System.Collections.Generic.List<UnityEngine.Vector3> characterPositions, System.Collections.Generic.List<System.Single> characterRadiuses, System.Collections.Generic.List<System.Single> characterHeights)
  RVA=0x0303E160  token=0x6000011  System.Void SetGameplayTime(System.Double gameplayTime)
  RVA=0x0303E1D0  token=0x6000012  System.Void SetLastGameplayTime(System.Double lastGameplayTime)
  RVA=0x02C3D1B0  token=0x6000013  System.Void RequestDisableFrameGenTemporarily(UnityEngine.Camera camera, System.Boolean disable)
  RVA=0x02AB0CE0  token=0x6000014  System.Void PauseMobileFrameGenTemporarily(System.Boolean pause)
END_CLASS

CLASS: HG.Rendering.ScriptBridge.TAAUControlBridge
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
PROPERTIES:
  taauFastConverge  set=0x03B2C370
METHODS:
  RVA=0x087C3C7C  token=0x6000015  System.Void SetRenderingScale(UnityEngine.Camera camera, System.Single scale)
  RVA=0x087C3FC0  token=0x6000016  System.Void ToggleTAAU(UnityEngine.Camera camera)
  RVA=0x087C3DA0  token=0x6000017  System.Void ToggleMetalFXSpatial(UnityEngine.Camera camera)
  RVA=0x087C3EB0  token=0x6000018  System.Void ToggleMetalFXTemporal(UnityEngine.Camera camera)
  RVA=0x087C3F38  token=0x6000019  System.Void ToggleTAAUWithMetalFXSpatial(UnityEngine.Camera camera)
  RVA=0x087C3E28  token=0x600001A  System.Void ToggleMetalFXTemporalWithMetalFXSpatial(UnityEngine.Camera camera)
  RVA=0x087C3250  token=0x600001C  System.Void ChangeHistoryWeight(System.Single val)
  RVA=0x087C346C  token=0x600001D  System.Single GetHistoryWeight()
  RVA=0x087C319C  token=0x600001E  System.Void ChangeHistoryWeightInMotion(System.Single val)
  RVA=0x087C30E8  token=0x600001F  System.Void ChangeDepthDiff(System.Single val)
  RVA=0x087C366C  token=0x6000020  System.Void MinMVConsideredDynamic(System.Single val)
  RVA=0x087C35B8  token=0x6000021  System.Void MaxMVConsideredDynamic(System.Single val)
  RVA=0x087C3304  token=0x6000022  System.Void CharacterMotionSensitivity(System.Single val)
  RVA=0x087C33B8  token=0x6000023  System.Void FastConvergeHistoryWeight(System.Single val)
  RVA=0x087C3504  token=0x6000024  System.Void InputSampleLumaWeight(System.Single val)
  RVA=0x087C4048  token=0x6000025  System.Void ToggleTargetFrameRate(System.Int32 val)
  RVA=0x02569680  token=0x6000026  System.Void NotifyTimeScale(System.Single timeScale)
  RVA=0x087C3954  token=0x6000027  System.Void SetDLSSQuality(UnityEngine.Camera camera, System.Int32 quality)
  RVA=0x087C3D18  token=0x6000028  System.Void ToggleDLSS(UnityEngine.Camera camera)
  RVA=0x087C37C8  token=0x6000029  System.Void SetDLSSFG(UnityEngine.Camera camera, System.Int32 mode)
  RVA=0x087C3720  token=0x600002A  System.Void SetDLSSFGModeGenFrames(System.Int32 numFramesToGenerate)
  RVA=0x087C39EC  token=0x600002B  System.Void SetDLSSReflex(System.Int32 mode)
  RVA=0x087C38AC  token=0x600002C  System.Void SetDLSSPCLEnable(System.Boolean enable)
  RVA=0x087C3A94  token=0x600002D  System.Void SetDLSSSharpenStrength(System.Single sharpenStrength)
  RVA=0x087C3BE4  token=0x600002E  System.Void SetForceJitterPhaseIdx(UnityEngine.Camera camera, System.Int32 idx)
  RVA=0x087C4094  token=0x600002F  System.Void UseDLSSExposure(System.Boolean use)
  RVA=0x087C3B4C  token=0x6000030  System.Void SetFSR3Quality(UnityEngine.Camera camera, System.Int32 quality)
  RVA=0x0350B670  token=0x6000031  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x0514F660  token=0x6000032  System.Void __Gen_Wrap_0(System.Boolean P0)
  RVA=0x055FFD60  token=0x6000033  System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  RVA=0x087C2C58  token=0x6000034  UnityEngine.Camera __Gen_Wrap_3(System.Object P0)
  RVA=0x087C2D34  token=0x6000035  UnityEngine.Material __Gen_Wrap_4(System.Object P0)
  RVA=0x087C2E10  token=0x6000036  UnityEngine.HGDecalProjector __Gen_Wrap_5(System.Object P0)
  RVA=0x087C2EEC  token=0x6000037  System.Void __Gen_Wrap_6(System.Object P0, System.Single P1)
  RVA=0x04274234  token=0x6000038  System.Void __Gen_Wrap_7(System.Object P0)
  RVA=0x087C2FB8  token=0x6000039  System.Void __Gen_Wrap_8(UnityEngine.Vector2 P0, System.Single P1, System.Single P2, System.Boolean P3)
  RVA=0x050F3444  token=0x600003A  System.Void __Gen_Wrap_9()
  RVA=0x087C2BA0  token=0x600003B  System.String __Gen_Wrap_10()
  RVA=0x05150B1C  token=0x600003C  System.Void __Gen_Wrap_11(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x08738F34  token=0x600003D  System.Void __Gen_Wrap_12(System.Double P0)
  RVA=0x05477860  token=0x600003E  System.Void __Gen_Wrap_13(System.Object P0, System.Boolean P1)
  RVA=0x050EE9C4  token=0x600003F  System.Void __Gen_Wrap_14(System.Int32 P0)
  RVA=0x05784998  token=0x6000040  System.Void __Gen_Wrap_15(System.Single P0)
  RVA=0x050F18D0  token=0x6000041  System.Single __Gen_Wrap_16()
  RVA=0x03D05640  token=0x6000042  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x087C413C  token=0x6000043  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x02568500  token=0x6000044  System.Boolean IsPatched(System.Int32 id)
END_CLASS

