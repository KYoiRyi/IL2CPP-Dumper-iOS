// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.DirectorModule.dll
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

namespace UnityEngine.Playables
{

    // TypeToken: 0x2000002  // size: 0x30
    public class PlayableDirector : UnityEngine.Behaviour, UnityEngine.IExposedPropertyTable
    {
        // Fields
        private System.Action<UnityEngine.Playables.PlayableDirector> played;  // 0x18
        private System.Action<UnityEngine.Playables.PlayableDirector> paused;  // 0x20
        private System.Action<UnityEngine.Playables.PlayableDirector> stopped;  // 0x28

        // Properties
        UnityEngine.Playables.PlayState state { get; /* RVA: 0x09DF429C */ }
        UnityEngine.Playables.DirectorWrapMode extrapolationMode { get; /* RVA: 0x09DF41E0 */ set; /* RVA: 0x09DF44B4 */ }
        UnityEngine.Playables.PlayableAsset playableAsset { get; /* RVA: 0x09DF422C */ set; /* RVA: 0x09DF4508 */ }
        UnityEngine.Playables.PlayableGraph playableGraph { get; /* RVA: 0x09DF4270 */ }
        System.Boolean playOnAwake { get; /* RVA: 0x09DF4220 */ set; /* RVA: 0x09DF4500 */ }
        UnityEngine.Playables.DirectorUpdateMode timeUpdateMode { get; /* RVA: 0x09DF42A8 */ set; /* RVA: 0x09DF4510 */ }
        System.Double time { get; /* RVA: 0x09DF42DC */ set; /* RVA: 0x09DF4550 */ }
        System.Double initialTime { get; /* RVA: 0x09DF41EC */ set; /* RVA: 0x09DF44BC */ }
        System.Double duration { get; /* RVA: 0x09DF41AC */ }

        // Events
        event System.Action<UnityEngine.Playables.PlayableDirector> played;
        event System.Action<UnityEngine.Playables.PlayableDirector> paused;
        event System.Action<UnityEngine.Playables.PlayableDirector> stopped;

        // Methods
        // RVA: 0x09DF37B8  token: 0x6000009
        public System.Void DeferredEvaluate() { }
        // RVA: 0x09DF3C24  token: 0x600000A
        private System.Void Play(UnityEngine.Playables.FrameRate frameRate) { }
        // RVA: 0x09DF3C40  token: 0x600000B
        public System.Void Play(UnityEngine.Playables.PlayableAsset asset) { }
        // RVA: 0x09DF3B48  token: 0x600000C
        public System.Void Play(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.DirectorWrapMode mode) { }
        // RVA: 0x09DF3E94  token: 0x600000D
        public System.Void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) { }
        // RVA: 0x09DF37F4  token: 0x6000015
        public System.Void Evaluate() { }
        // RVA: 0x09DF3B2C  token: 0x6000016
        private System.Void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate) { }
        // RVA: 0x09DF3D04  token: 0x6000017
        public System.Void Play() { }
        // RVA: 0x09DF3FD4  token: 0x6000018
        public System.Void Stop() { }
        // RVA: 0x09DF3AB4  token: 0x6000019
        public System.Void Pause() { }
        // RVA: 0x09DF3E00  token: 0x600001A
        public System.Void Resume() { }
        // RVA: 0x09DF3DA0  token: 0x600001B
        public System.Void RebuildGraph() { }
        // RVA: 0x09DF379C  token: 0x600001C
        public virtual System.Void ClearReferenceValue(UnityEngine.PropertyName id) { }
        // RVA: 0x09DF3F78  token: 0x600001D
        public virtual System.Void SetReferenceValue(UnityEngine.PropertyName id, UnityEngine.Object value) { }
        // RVA: 0x09DF3998  token: 0x600001E
        public virtual UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, System.Boolean& idValid) { }
        // RVA: 0x09DF3828  token: 0x600001F
        public UnityEngine.Object GetGenericBinding(UnityEngine.Object key) { }
        // RVA: 0x09DF3714  token: 0x6000020
        public System.Void ClearGenericBinding(UnityEngine.Object key) { }
        // RVA: 0x09DF3D6C  token: 0x6000021
        public System.Void RebindPlayableGraphOutputs() { }
        // RVA: 0x09DF3D38  token: 0x6000022
        private System.Void ProcessPendingGraphChanges() { }
        // RVA: 0x09DF39E8  token: 0x6000023
        private System.Boolean HasGenericBinding(UnityEngine.Object key) { }
        // RVA: 0x09DF3910  token: 0x6000024
        private UnityEngine.Playables.PlayState GetPlayState() { }
        // RVA: 0x09DF3F94  token: 0x6000025
        private System.Void SetWrapMode(UnityEngine.Playables.DirectorWrapMode mode) { }
        // RVA: 0x09DF39B4  token: 0x6000026
        private UnityEngine.Playables.DirectorWrapMode GetWrapMode() { }
        // RVA: 0x09DF37C0  token: 0x6000027
        private System.Void EvaluateNextFrame() { }
        // RVA: 0x09DF38B0  token: 0x6000028
        private UnityEngine.Playables.PlayableGraph GetGraphHandle() { }
        // RVA: 0x09DF3E9C  token: 0x6000029
        private System.Void SetPlayOnAwake(System.Boolean on) { }
        // RVA: 0x09DF38DC  token: 0x600002A
        private System.Boolean GetPlayOnAwake() { }
        // RVA: 0x09DF3A60  token: 0x600002B
        private System.Void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value) { }
        // RVA: 0x09DF3EE0  token: 0x600002C
        private System.Void SetPlayableAsset(UnityEngine.ScriptableObject asset) { }
        // RVA: 0x09DF3A2C  token: 0x600002D
        private UnityEngine.ScriptableObject Internal_GetPlayableAsset() { }
        // RVA: 0x09DF3DD4  token: 0x6000034
        private static System.Void ResetFrameTiming() { }
        // RVA: 0x09DF3E54  token: 0x6000035
        private System.Void SendOnPlayableDirectorPlay() { }
        // RVA: 0x09DF3E34  token: 0x6000036
        private System.Void SendOnPlayableDirectorPause() { }
        // RVA: 0x09DF3E74  token: 0x6000037
        private System.Void SendOnPlayableDirectorStop() { }
        // RVA: 0x0426FE60  token: 0x6000038
        public System.Void .ctor() { }
        // RVA: 0x09DF3AE8  token: 0x6000039
        private System.Void PlayOnFrame_Injected(UnityEngine.Playables.FrameRate& frameRate) { }
        // RVA: 0x09DF3758  token: 0x600003A
        private virtual System.Void ClearReferenceValue_Injected(UnityEngine.PropertyName& id) { }
        // RVA: 0x09DF3F24  token: 0x600003B
        private virtual System.Void SetReferenceValue_Injected(UnityEngine.PropertyName& id, UnityEngine.Object value) { }
        // RVA: 0x09DF3944  token: 0x600003C
        private virtual UnityEngine.Object GetReferenceValue_Injected(UnityEngine.PropertyName& id, System.Boolean& idValid) { }
        // RVA: 0x09DF386C  token: 0x600003D
        private System.Void GetGraphHandle_Injected(UnityEngine.Playables.PlayableGraph& ret) { }

    }

}

