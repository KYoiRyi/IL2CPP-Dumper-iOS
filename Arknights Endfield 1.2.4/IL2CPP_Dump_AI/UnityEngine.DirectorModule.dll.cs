// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.DirectorModule.dll
// Classes:  2
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

CLASS: UnityEngine.Playables.PlayableDirector
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x30
EXTENDS: UnityEngine.Behaviour
IMPLEMENTS: UnityEngine.IExposedPropertyTable
FIELDS:
  private           System.Action<UnityEngine.Playables.PlayableDirector>played  // 0x18
  private           System.Action<UnityEngine.Playables.PlayableDirector>paused  // 0x20
  private           System.Action<UnityEngine.Playables.PlayableDirector>stopped  // 0x28
PROPERTIES:
  state  get=0x09DF429C
  extrapolationMode  get=0x09DF41E0  set=0x09DF44B4
  playableAsset  get=0x09DF422C  set=0x09DF4508
  playableGraph  get=0x09DF4270
  playOnAwake  get=0x09DF4220  set=0x09DF4500
  timeUpdateMode  get=0x09DF42A8  set=0x09DF4510
  time  get=0x09DF42DC  set=0x09DF4550
  initialTime  get=0x09DF41EC  set=0x09DF44BC
  duration  get=0x09DF41AC
EVENTS:
  played  add=add_played  remove=remove_played
  paused  add=add_paused  remove=remove_paused
  stopped  add=add_stopped  remove=remove_stopped
METHODS:
  RVA=0x09DF37B8  token=0x6000009  System.Void DeferredEvaluate()
  RVA=0x09DF3C24  token=0x600000A  System.Void Play(UnityEngine.Playables.FrameRate frameRate)
  RVA=0x09DF3C40  token=0x600000B  System.Void Play(UnityEngine.Playables.PlayableAsset asset)
  RVA=0x09DF3B48  token=0x600000C  System.Void Play(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.DirectorWrapMode mode)
  RVA=0x09DF3E94  token=0x600000D  System.Void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value)
  RVA=0x09DF37F4  token=0x6000015  System.Void Evaluate()
  RVA=0x09DF3B2C  token=0x6000016  System.Void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate)
  RVA=0x09DF3D04  token=0x6000017  System.Void Play()
  RVA=0x09DF3FD4  token=0x6000018  System.Void Stop()
  RVA=0x09DF3AB4  token=0x6000019  System.Void Pause()
  RVA=0x09DF3E00  token=0x600001A  System.Void Resume()
  RVA=0x09DF3DA0  token=0x600001B  System.Void RebuildGraph()
  RVA=0x09DF379C  token=0x600001C  System.Void ClearReferenceValue(UnityEngine.PropertyName id)
  RVA=0x09DF3F78  token=0x600001D  System.Void SetReferenceValue(UnityEngine.PropertyName id, UnityEngine.Object value)
  RVA=0x09DF3998  token=0x600001E  UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, System.Boolean& idValid)
  RVA=0x09DF3828  token=0x600001F  UnityEngine.Object GetGenericBinding(UnityEngine.Object key)
  RVA=0x09DF3714  token=0x6000020  System.Void ClearGenericBinding(UnityEngine.Object key)
  RVA=0x09DF3D6C  token=0x6000021  System.Void RebindPlayableGraphOutputs()
  RVA=0x09DF3D38  token=0x6000022  System.Void ProcessPendingGraphChanges()
  RVA=0x09DF39E8  token=0x6000023  System.Boolean HasGenericBinding(UnityEngine.Object key)
  RVA=0x09DF3910  token=0x6000024  UnityEngine.Playables.PlayState GetPlayState()
  RVA=0x09DF3F94  token=0x6000025  System.Void SetWrapMode(UnityEngine.Playables.DirectorWrapMode mode)
  RVA=0x09DF39B4  token=0x6000026  UnityEngine.Playables.DirectorWrapMode GetWrapMode()
  RVA=0x09DF37C0  token=0x6000027  System.Void EvaluateNextFrame()
  RVA=0x09DF38B0  token=0x6000028  UnityEngine.Playables.PlayableGraph GetGraphHandle()
  RVA=0x09DF3E9C  token=0x6000029  System.Void SetPlayOnAwake(System.Boolean on)
  RVA=0x09DF38DC  token=0x600002A  System.Boolean GetPlayOnAwake()
  RVA=0x09DF3A60  token=0x600002B  System.Void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value)
  RVA=0x09DF3EE0  token=0x600002C  System.Void SetPlayableAsset(UnityEngine.ScriptableObject asset)
  RVA=0x09DF3A2C  token=0x600002D  UnityEngine.ScriptableObject Internal_GetPlayableAsset()
  RVA=0x09DF3DD4  token=0x6000034  System.Void ResetFrameTiming()
  RVA=0x09DF3E54  token=0x6000035  System.Void SendOnPlayableDirectorPlay()
  RVA=0x09DF3E34  token=0x6000036  System.Void SendOnPlayableDirectorPause()
  RVA=0x09DF3E74  token=0x6000037  System.Void SendOnPlayableDirectorStop()
  RVA=0x0426FE60  token=0x6000038  System.Void .ctor()
  RVA=0x09DF3AE8  token=0x6000039  System.Void PlayOnFrame_Injected(UnityEngine.Playables.FrameRate& frameRate)
  RVA=0x09DF3758  token=0x600003A  System.Void ClearReferenceValue_Injected(UnityEngine.PropertyName& id)
  RVA=0x09DF3F24  token=0x600003B  System.Void SetReferenceValue_Injected(UnityEngine.PropertyName& id, UnityEngine.Object value)
  RVA=0x09DF3944  token=0x600003C  UnityEngine.Object GetReferenceValue_Injected(UnityEngine.PropertyName& id, System.Boolean& idValid)
  RVA=0x09DF386C  token=0x600003D  System.Void GetGraphHandle_Injected(UnityEngine.Playables.PlayableGraph& ret)
END_CLASS

