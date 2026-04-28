// ========================================================
// Dumped by @desirepro
// Assembly: Entry.Beyond.dll
// Classes:  280
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x30
    public class RenderSilhouetteRT : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera cameraRT;  // 0x18
        public UnityEngine.Camera mainCamera;  // 0x20
        public UnityEngine.Material materialSilhouette;  // 0x28
        private static UnityEngine.Texture s_mSilhouetteRT;  // static @ 0x0
        private static UnityEngine.RenderTexture s_mSilhouetteRth;  // static @ 0x8

        // Methods
        // RVA: 0x028AD320  token: 0x6000001
        private System.Void Update() { }
        // RVA: 0x032FA2B0  token: 0x6000002
        private System.Void OnDestroy() { }
        // RVA: 0x0426FE60  token: 0x6000003
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x28
    public sealed class <_InitSecuritySDK>d__31 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.GameApp <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000020
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000021
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C3E060  token: 0x6000022
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FF68  token: 0x6000024
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000006  // size: 0x30
    public sealed class <_FetchRemoteConfigUtilSuc>d__33 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        private Beyond.Cfg.RemoteNetworkCfg <config>5__2;  // 0x20
        private Beyond.Misc.ObjectRef <resultRef>5__3;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000026
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000027
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C37790  token: 0x6000028
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FE84  token: 0x600002A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200000A  // size: 0x28
    public sealed class <_DoInit>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.GameInitState <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600003B
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600003C
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C37D40  token: 0x600003D
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FDEC  token: 0x600003F
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200000E  // size: 0x28
    public sealed class <_DoPreload>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.GamePreloadState <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000058
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000059
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C351F0  token: 0x600005A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FE38  token: 0x600005C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000011  // size: 0x30
    public sealed class <_SoftRestart>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.GameSoftRestartState <>4__this;  // 0x20
        private UnityEngine.AsyncOperation <clearSceneOp>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600006A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600006B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05770098  token: 0x600006C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05770760  token: 0x600006E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000015  // size: 0x28
    public sealed class <ReturnToLoginState>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.GameStateMachine <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000083
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000084
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C35D70  token: 0x6000085
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F7F0  token: 0x6000087
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200001C  // size: 0x18
    public sealed struct FOptions
    {
        // Fields
        public Beyond.LoginContext context;  // 0x10

    }

    // TypeToken: 0x200001E  // size: 0x30
    public sealed class <_CloseCoroutine>d__4 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginController.Dialog <>4__this;  // 0x20
        public System.Action callback;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000AF
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000B0
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0576FC88  token: 0x60000B1
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FD54  token: 0x60000B3
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200001F
    public sealed class <Create>d__8`1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public Beyond.Misc.ObjectRef outRef;  // 0x0
        public Beyond.LoginController controller;  // 0x0
        public System.String resPath;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000B5
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x60000B6
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x60000B7
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60000B9
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200001D  // size: 0x38
    public abstract class Dialog : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UISwitchTween m_switchTween;  // 0x18
        private Beyond.LoginController m_controller;  // 0x20
        public System.String showAudioEvent;  // 0x28
        public System.String closeAudioEvent;  // 0x30

        // Methods
        // RVA: 0x0576C5CC  token: 0x60000A9
        private System.Collections.IEnumerator _CloseCoroutine(System.Action callback) { }
        // RVA: 0x0576C488  token: 0x60000AA
        public System.Boolean TryCloseWithCallback(System.Action callback) { }
        // RVA: 0x0576C39C  token: 0x60000AB
        public System.Void Show() { }
        // RVA: 0x0576C358  token: 0x60000AC
        protected virtual System.Void OnInit() { }
        // RVA: -1  // generic def  token: 0x60000AD
        public static System.Collections.IEnumerator Create(System.String resPath, Beyond.LoginController controller, Beyond.Misc.ObjectRef outRef) { }
        // RVA: 0x0426FE60  token: 0x60000AE
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public static class MaskConsts
    {
        // Fields
        public static System.Single DELAY_WAIT_NODE;  // const
        public static System.String INIT;  // const
        public static System.String U8_LOGIN;  // const
        public static System.String FROM_GS_LOGIN;  // const
        public static System.String FROM_CREATE_ROLE;  // const
        public static System.String NET_AGE_TIPS;  // const

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct EMaskType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.LoginController.EMaskType None;  // const
        public static Beyond.LoginController.EMaskType Black;  // const
        public static Beyond.LoginController.EMaskType Blur;  // const
        public static Beyond.LoginController.EMaskType White;  // const

    }

    // TypeToken: 0x2000022  // size: 0x20
    public class MaskCfg
    {
        // Fields
        public UnityEngine.CanvasGroup target;  // 0x10
        public System.Single showDuration;  // 0x18
        public System.Single hideDuration;  // 0x1c

        // Methods
        // RVA: 0x036531D0  token: 0x60000BB
        public Beyond.UI.UISwitchTween CreateTweenAndHide() { }
        // RVA: 0x03D55780  token: 0x60000BC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000024  // size: 0x20
    public class NetMaskRef
    {
        // Fields
        private System.String <key>k__BackingField;  // 0x10
        public System.Int32 maskId;  // 0x18
        public System.Boolean isEnabled;  // 0x1c

        // Properties
        System.String key { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60000C9
        public System.Void .ctor(System.String key) { }

    }

    // TypeToken: 0x2000025  // size: 0x40
    public sealed class <WaitForCrossSceneMasks>d__10 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginController.MaskCtrl <>4__this;  // 0x20
        private System.Int32[] <>7__wrap1;  // 0x28
        private System.Int32 <>7__wrap2;  // 0x30
        private Beyond.UI.UISwitchTween <mask>5__4;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000CA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000CB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0576FB14  token: 0x60000CC
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FC3C  token: 0x60000CE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000023  // size: 0x28
    public class MaskCtrl : System.IDisposable
    {
        // Fields
        private static readonly System.Int32[] CROSS_SCENE_MASKS;  // static @ 0x0
        private Beyond.ListDict<System.Int32,System.Collections.Generic.HashSet<System.String>> m_maskRefs;  // 0x10
        private Beyond.ListDict<System.Int32,Beyond.UI.UISwitchTween> m_maskTweens;  // 0x18
        private Beyond.ListDict<System.String,Beyond.LoginController.MaskCtrl.NetMaskRef> m_netMasks;  // 0x20

        // Methods
        // RVA: 0x03652FD0  token: 0x60000BD
        public System.Void .ctor(Beyond.LoginController controller) { }
        // RVA: 0x02C3D490  token: 0x60000BE
        public virtual System.Void Dispose() { }
        // RVA: 0x02C3C4E0  token: 0x60000BF
        public System.Void EnableMask(System.String key, Beyond.LoginController.EMaskType type, System.Boolean enable, System.Boolean reset) { }
        // RVA: 0x02C3C490  token: 0x60000C0
        public System.Boolean IsMaskTweening(Beyond.LoginController.EMaskType type) { }
        // RVA: 0x02EAA010  token: 0x60000C1
        public System.Boolean IsCrossSceneMaskTweening() { }
        // RVA: 0x0576EAD8  token: 0x60000C2
        public System.Collections.IEnumerator WaitForCrossSceneMasks() { }
        // RVA: 0x0576E918  token: 0x60000C3
        public System.Void EnableNetMask(System.String key, System.Single timeoutSecs) { }
        // RVA: 0x0576E82C  token: 0x60000C4
        public System.Void DisableNetMask(System.String key) { }
        // RVA: 0x02C3C6C0  token: 0x60000C5
        private Beyond.UI.UISwitchTween _GetMaskByType(System.Int32 type) { }
        // RVA: 0x03CB7120  token: 0x60000C6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x28
    public sealed class <BeforeDestroy>d__35 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginController <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000D0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000D1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02EA9730  token: 0x60000D2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F424  token: 0x60000D4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000027
    public sealed class <_InstantiateUIFromRes>d__36`1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public Beyond.Misc.ObjectRef objRef;  // 0x0
        public Beyond.LoginController <>4__this;  // 0x0
        public System.String resPath;  // 0x0
        public UnityEngine.Transform parent;  // 0x0
        private System.Nullable<Beyond.Resource.FAssetProxyHandle> <handle>5__2;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000D6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x60000D7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x60000D8
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60000DA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000028  // size: 0x38
    public sealed class <_InitCoroutine>d__38 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginController <>4__this;  // 0x20
        private Beyond.LoginContext <context>5__2;  // 0x28
        private Beyond.Misc.ObjectRef <panelRef>5__3;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000DC
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000DD
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02EA8F90  token: 0x60000DE
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FF1C  token: 0x60000E0
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000029  // size: 0x18
    public sealed class <>c__DisplayClass45_0
    {
        // Fields
        public Beyond.Misc.ObjectRef objRef;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000E2
        public System.Void .ctor() { }
        // RVA: 0x02F7AA70  token: 0x60000E3
        private System.Void <_MockLoginCoroutine>b__0(System.String pUID) { }

    }

    // TypeToken: 0x200002A  // size: 0x40
    public sealed class <_MockLoginCoroutine>d__45 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginController <>4__this;  // 0x20
        private Beyond.LoginController.<>c__DisplayClass45_0 <>8__1;  // 0x28
        public System.String fixedUID;  // 0x30
        private Beyond.Login.LoginMockUIDPanel <nullablePanel>5__2;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60000E4
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000E5
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03652A00  token: 0x60000E6
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05770000  token: 0x60000E8
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200002C  // size: 0x30
    public sealed class <_DisposeCoroutine>d__48 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginController legacyController;  // 0x20
        public System.Action disposeAction;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000108
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000109
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03A24680  token: 0x600010A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FDA0  token: 0x600010C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000030  // size: 0x18
    public class AssetLoader : System.IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle> m_assetHandles;  // 0x10

        // Methods
        // RVA: -1  // generic def  token: 0x6000131
        public Beyond.Resource.FAssetProxyHandle CachedLoad(System.String path) { }
        // RVA: -1  // generic def  token: 0x6000132
        public Beyond.Resource.FAssetProxyHandle CachedLoadAsync(System.String path) { }
        // RVA: 0x02AD71E0  token: 0x6000133
        private System.Boolean _CheckDisposedBeforeLoad(System.String path) { }
        // RVA: 0x028D3CF0  token: 0x6000134
        public virtual System.Void Dispose() { }
        // RVA: 0x028D5190  token: 0x6000135
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x60
    public sealed class <_FlowCoroutine>d__4 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginManager.FlowWithMaskMgr <>4__this;  // 0x20
        public Beyond.LoginManager.FFlowWithMask flow;  // 0x28
        private Beyond.LoginController.MaskCtrl <maskCtrl>5__2;  // 0x50
        private System.Boolean <isFlowSuc>5__3;  // 0x58

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600013A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600013B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C3C820  token: 0x600013C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FED0  token: 0x600013E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000031  // size: 0x20
    public class FlowWithMaskMgr
    {
        // Fields
        private Beyond.LoginContext m_context;  // 0x10
        private System.Collections.Generic.HashSet<System.String> m_activeFlows;  // 0x18

        // Methods
        // RVA: 0x028D4DC0  token: 0x6000136
        public System.Void .ctor(Beyond.LoginContext context) { }
        // RVA: 0x02D773E0  token: 0x6000137
        public System.Void StartFlow(Beyond.LoginManager.FFlowWithMask flow) { }
        // RVA: 0x02D77520  token: 0x6000138
        private System.Collections.IEnumerator _FlowCoroutine(Beyond.LoginManager.FFlowWithMask flow) { }
        // RVA: 0x0576C674  token: 0x6000139
        private System.Void _OnFlowFinished(Beyond.LoginManager.FFlowWithMask flow) { }

    }

    // TypeToken: 0x2000033  // size: 0x38
    public sealed struct FFlowWithMask
    {
        // Fields
        public System.String key;  // 0x10
        public Beyond.LoginController.EMaskType maskType;  // 0x18
        public System.Func<System.Boolean> flowAction;  // 0x20
        public Beyond.LoginManager.FFlowCondition condition;  // 0x28
        public System.Single disableDelay;  // 0x30

    }

    // TypeToken: 0x2000034  // size: 0x18
    public sealed struct FFlowCondition
    {
        // Fields
        private Beyond.Login.LoginWorkFlow.ENode <priTarget>k__BackingField;  // 0x10
        private Beyond.Login.LoginWorkFlow.ENode <secTarget>k__BackingField;  // 0x14

        // Properties
        Beyond.Login.LoginWorkFlow.ENode priTarget { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        Beyond.Login.LoginWorkFlow.ENode secTarget { get; /* RVA: 0x03D4E990 */ set; /* RVA: 0x03D51720 */ }

        // Methods
        // RVA: 0x03D55720  token: 0x6000144
        public System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode target) { }
        // RVA: 0x03D4E4B0  token: 0x6000145
        public System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode first, Beyond.Login.LoginWorkFlow.ENode second) { }
        // RVA: 0x02C3DF80  token: 0x6000146
        public System.Boolean IsTargetMatch(Beyond.Login.LoginWorkFlow.ENode node) { }

    }

    // TypeToken: 0x2000035  // size: 0x30
    public sealed class <InitCoroutine>d__17 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginManager <>4__this;  // 0x20
        public System.Boolean quickStart;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000147
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000148
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x028D3C90  token: 0x6000149
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F7A4  token: 0x600014B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000036  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.LoginManager.<>c <>9;  // static @ 0x0
        public static System.Action<Beyond.Login.LoginAlertDialog,Beyond.Login.LoginAlertDialog.FParams> <>9__29_0;  // static @ 0x8
        public static System.Action<Beyond.Login.LoginVocResSelDialog,Beyond.Login.LoginVocResSelDialog.FParams> <>9__30_0;  // static @ 0x10
        public static System.Action<Beyond.Login.LoginJudgeDialog,Beyond.Login.LoginJudgeDialog.FParams> <>9__36_0;  // static @ 0x18

        // Methods
        // RVA: 0x0576F928  token: 0x600014D
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600014E
        public System.Void .ctor() { }
        // RVA: 0x0576F83C  token: 0x600014F
        private System.Void <AlertDialog>b__29_0(Beyond.Login.LoginAlertDialog param1, Beyond.Login.LoginAlertDialog.FParams param2) { }
        // RVA: 0x0576F86C  token: 0x6000150
        private System.Void <VocResSelDialog>b__30_0(Beyond.Login.LoginVocResSelDialog param1, Beyond.Login.LoginVocResSelDialog.FParams param2) { }
        // RVA: 0x0576F894  token: 0x6000151
        private System.Void <_StartShowJudgeDialogCoroutine>b__36_0(Beyond.Login.LoginJudgeDialog param1, Beyond.Login.LoginJudgeDialog.FParams param2) { }

    }

    // TypeToken: 0x2000037  // size: 0x18
    public sealed class <>c__DisplayClass31_0
    {
        // Fields
        public System.Object wait;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000152
        public System.Void .ctor() { }
        // RVA: 0x035ACAA0  token: 0x6000153
        private System.Void <VocResSelDialogWithConfirm>b__0() { }

    }

    // TypeToken: 0x2000038  // size: 0x30
    public sealed class <VocResSelDialogWithConfirm>d__31 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginManager <>4__this;  // 0x20
        private Beyond.LoginManager.<>c__DisplayClass31_0 <>8__1;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000154
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000155
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0576F98C  token: 0x6000156
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FAC8  token: 0x6000158
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000039  // size: 0x20
    public sealed class <>c__DisplayClass32_0
    {
        // Fields
        public Beyond.Misc.ObjectRef outRef;  // 0x10
        public System.Action<Beyond.Misc.ObjectRef> callback;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600015A
        public System.Void .ctor() { }
        // RVA: 0x0576F8D8  token: 0x600015B
        private System.Void <AlertDialogWithResult>b__0() { }

    }

    // TypeToken: 0x200003A  // size: 0x40
    public sealed class <AlertDialogWithResult>d__32 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Misc.ObjectRef outRef;  // 0x20
        public System.Action<Beyond.Misc.ObjectRef> callback;  // 0x28
        public Beyond.LoginManager <>4__this;  // 0x30
        public System.String desc;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600015C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600015D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0576F280  token: 0x600015E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F3D8  token: 0x6000160
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003B  // size: 0x18
    public sealed class <>c__DisplayClass33_0
    {
        // Fields
        public System.Object wait;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000162
        public System.Void .ctor() { }
        // RVA: 0x035ACAA0  token: 0x6000163
        private System.Void <AlertDialogWithConfirm>b__0() { }

    }

    // TypeToken: 0x200003C  // size: 0x38
    public sealed class <AlertDialogWithConfirm>d__33 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginManager <>4__this;  // 0x20
        public System.String desc;  // 0x28
        private Beyond.LoginManager.<>c__DisplayClass33_0 <>8__1;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000164
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000165
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0576F0E4  token: 0x6000166
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F234  token: 0x6000168
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003D
    public sealed class <_ShowDialogCoroutine>d__37`2 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private System.Object <>2__current;  // 0x0
        public Beyond.LoginManager <>4__this;  // 0x0
        public System.String resPath;  // 0x0
        public System.Action<TDialog,TParam> setParamFunc;  // 0x0
        public TParam param;  // 0x0
        private Beyond.Misc.ObjectRef <outRef>5__2;  // 0x0

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600016A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x600016B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x600016C
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600016E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200003E  // size: 0x18
    public sealed class <>c__DisplayClass39_0
    {
        // Fields
        public System.Action callback;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000170
        public System.Void .ctor() { }
        // RVA: 0x0576F918  token: 0x6000171
        private System.Void <MockManualSelectServer>b__0(System.String _) { }

    }

    // TypeToken: 0x200003F  // size: 0x20
    public sealed class <>c__DisplayClass40_0
    {
        // Fields
        public Beyond.LoginController controller;  // 0x10
        public Beyond.LoginManager <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000172
        public System.Void .ctor() { }
        // RVA: 0x03C7DA60  token: 0x6000173
        private System.Void <_Init>b__0() { }

    }

    // TypeToken: 0x2000040  // size: 0x30
    public sealed class <_LoginWorkFlowCoroutine>d__43 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.LoginManager <>4__this;  // 0x20
        public Beyond.LoginController nullableCtrl;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000174
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000175
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02EA9C20  token: 0x6000176
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576FFB4  token: 0x6000178
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000041  // size: 0x78
    public sealed class <FetchRemoteConfigUtilSuc>d__45 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Cfg.IRemoteConfig config;  // 0x20
        public System.String configEnv;  // 0x28
        public System.String keyErrorWithCode;  // 0x30
        public System.String keyTimeout;  // 0x38
        private Beyond.Cfg.FRemoteConfigRequest <request>5__2;  // 0x40
        private System.Boolean <isServiceSuc>5__3;  // 0x68
        private Beyond.Misc.ObjectRef <resultRef>5__4;  // 0x70

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600017A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600017B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C371A0  token: 0x600017C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F758  token: 0x600017E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200004C  // size: 0x20
    public sealed struct SplashConfig
    {
        // Fields
        public UnityEngine.Sprite sprite;  // 0x10
        public System.Boolean blackCoverFadeOut;  // 0x18

    }

    // TypeToken: 0x200004D  // size: 0x20
    public sealed struct SplashConfigOverride
    {
        // Fields
        public Beyond.GEnums.EnvLang envLang;  // 0x10
        public Beyond.UI.SplashController.SplashConfig[] splashConfigs;  // 0x18

    }

    // TypeToken: 0x200004E  // size: 0x28
    public sealed struct SplashConfigs
    {
        // Fields
        public Beyond.UI.SplashController.SplashConfig[] splashConfigs;  // 0x10
        public Beyond.UI.SplashController.SplashConfig[] splashConfigsVNMobile;  // 0x18
        public Beyond.UI.SplashController.SplashConfigOverride[] i18nSplashConfigOverrides;  // 0x20

    }

    // TypeToken: 0x200004F  // size: 0x28
    public sealed class <>c__DisplayClass31_0
    {
        // Fields
        public Beyond.UI.SplashController.SplashConfig config;  // 0x10
        public Beyond.UI.SplashController <>4__this;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60001A7
        public System.Void .ctor() { }
        // RVA: 0x03CF5200  token: 0x60001A8
        private System.Void <_DoStartSplash>b__0() { }
        // RVA: 0x03CC4460  token: 0x60001A9
        private System.Void <_DoStartSplash>b__2() { }

    }

    // TypeToken: 0x2000050  // size: 0x28
    public sealed class <_OnSplashCompleteCoroutine>d__33 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.UI.SplashController <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001AA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001AB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0229E690  token: 0x60001AC
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577004C  token: 0x60001AE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000051  // size: 0x28
    public sealed class <_StartLicenseCoroutine>d__34 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        private System.Boolean <displayCursor>5__2;  // 0x20
        private System.Boolean <usingController>5__3;  // 0x21
        private System.Boolean <isGranted>5__4;  // 0x22

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001B0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001B1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D7A0D0  token: 0x60001B2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057707AC  token: 0x60001B4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000054  // size: 0x38
    public sealed struct HttpPostRequest
    {
        // Fields
        public System.String url;  // 0x10
        public System.String param;  // 0x18
        public System.String contentType;  // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.String> header;  // 0x28
        public System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse> callback;  // 0x30

    }

    // TypeToken: 0x2000055  // size: 0x20
    public sealed struct HttpGetRequest
    {
        // Fields
        public System.String url;  // 0x10
        public System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse> callback;  // 0x18

    }

    // TypeToken: 0x2000056  // size: 0x40
    public sealed struct WebHttpResponse
    {
        // Fields
        public System.Boolean isTimeout;  // 0x10
        public System.Boolean isError;  // 0x11
        public System.Int64 responseCode;  // 0x18
        public System.Collections.Generic.Dictionary<System.String,System.String> header;  // 0x20
        public System.String text;  // 0x28
        public System.Byte[] data;  // 0x30
        public System.String error;  // 0x38

    }

    // TypeToken: 0x2000057  // size: 0x14
    public sealed struct HTTPOptType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.SDK.SDKNetUtils.HTTPOptType GET;  // const
        public static Beyond.SDK.SDKNetUtils.HTTPOptType POST;  // const

    }

    // TypeToken: 0x2000058  // size: 0x40
    public sealed struct HTTPConfig
    {
        // Fields
        public System.String url;  // 0x10
        public System.String body;  // 0x18
        public System.String contentType;  // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.String> header;  // 0x28
        public Beyond.SDK.SDKNetUtils.HTTPOptType optType;  // 0x30
        public System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse> callback;  // 0x38

    }

    // TypeToken: 0x2000059  // size: 0x10
    public abstract class HTTPImpl
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60001BB
        public virtual System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config) { }
        // RVA: 0x0350B670  token: 0x60001BC
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x58
    public sealed class <DoHTTP>d__0 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.SDK.SDKNetUtils.HTTPConfig config;  // 0x20
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> <sendTask>5__2;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001BF
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001C0
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0576F470  token: 0x60001C1
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0576F70C  token: 0x60001C3
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200005A  // size: 0x10
    public class BeyondHttp : HTTPImpl
    {
        // Methods
        // RVA: 0x0576C290  token: 0x60001BD
        public virtual System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config) { }
        // RVA: 0x0350B670  token: 0x60001BE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005E  // size: 0x12
    public sealed struct FHGSDKInit
    {
        // Fields
        public System.Boolean isIniting;  // 0x10
        public System.Boolean isInited;  // 0x11

    }

    // TypeToken: 0x2000060  // size: 0x38
    public sealed class <FetchCaptchaCoroutine>d__3 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String captchaParams;  // 0x20
        public Beyond.SDK.Impl.U8ExternalTools.CaptchaHandler <>4__this;  // 0x28
        public U8.SDK.SDKCaptchaHandler.Result outResult;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001E8
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001E9
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05777174  token: 0x60001EA
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777268  token: 0x60001EC
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200005F  // size: 0x20
    public class CaptchaHandler : U8.SDK.SDKCaptchaHandler
    {
        // Fields
        private static System.Int32 FAILED;  // const
        private System.Int64 m_flag;  // 0x10
        private System.String m_desc;  // 0x18

        // Methods
        // RVA: 0x0577288C  token: 0x60001E5
        public virtual System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult) { }
        // RVA: 0x05772954  token: 0x60001E6
        public System.Void OnGT3Message(System.Collections.Generic.Dictionary<System.String,System.Object> msg) { }
        // RVA: 0x03D55790  token: 0x60001E7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000061  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.SDK.Impl.U8ExternalTools.<>c <>9;  // static @ 0x0
        public static System.Action<System.Object> <>9__9_0;  // static @ 0x8
        public static System.Action<System.String> <>9__9_1;  // static @ 0x10
        public static System.Action <>9__27_0;  // static @ 0x18

        // Methods
        // RVA: 0x03D18530  token: 0x60001EE
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001EF
        public System.Void .ctor() { }
        // RVA: 0x057772B4  token: 0x60001F0
        private System.Void <InitSDKSystem>b__9_0(System.Object error) { }
        // RVA: 0x039CAB10  token: 0x60001F1
        private System.Void <InitSDKSystem>b__9_1(System.String rawExtConfig) { }
        // RVA: 0x05777474  token: 0x60001F2
        private System.Void <_ProcessExtraInfo>b__27_0() { }

    }

    // TypeToken: 0x2000062  // size: 0x20
    public sealed class <WaitForInited>d__10 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001F3
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001F4
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03B3CE50  token: 0x60001F5
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777800  token: 0x60001F7
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000063  // size: 0x20
    public sealed class <WaitForInitHGSDK>d__15 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001F9
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001FA
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03C9C180  token: 0x60001FB
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057777B4  token: 0x60001FD
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000064  // size: 0x18
    public sealed class <>c__DisplayClass25_0
    {
        // Fields
        public System.Action<U8.SDK.SDKExternalTools.POSTResult> callback;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60001FF
        public System.Void .ctor() { }
        // RVA: 0x05777500  token: 0x6000200
        private System.Void <POSTImplementation>b__0(Beyond.SDK.SDKNetUtils.WebHttpResponse webRequest) { }

    }

    // TypeToken: 0x2000066  // size: 0x30
    public sealed class <>c__DisplayClass7_0
    {
        // Fields
        public U8.SDK.ExternalPluginPayParams args;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600020D
        public System.Void .ctor() { }
        // RVA: 0x05777694  token: 0x600020E
        private System.Void <Pay>b__0(U8.SDK.U8PayResult payResult) { }
        // RVA: 0x057776CC  token: 0x600020F
        private System.Void <Pay>b__1(System.Object failMsg) { }

    }

    // TypeToken: 0x2000067  // size: 0x38
    public sealed class <>c__DisplayClass10_0
    {
        // Fields
        public U8.SDK.ExternalPluginLoginParams args;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000210
        public System.Void .ctor() { }
        // RVA: 0x03157E60  token: 0x6000211
        private System.Void <_MockLogin>b__0(System.String uid) { }

    }

    // TypeToken: 0x2000069  // size: 0x18
    public class AppVersionRespone
    {
        // Fields
        public System.Int32 action;  // 0x10
        public System.Int32 state;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x600021C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006A  // size: 0x28
    public sealed class <_CheckForUpdateCoroutine>d__4 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginCheckForUpdateNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600021D
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600021E
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C3CBC0  token: 0x600021F
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777B30  token: 0x6000221
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200006B  // size: 0x20
    public sealed class <AlertNoMatchDeviceBeforeLogin>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000223
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000224
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03B31500  token: 0x6000225
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05776AF0  token: 0x6000227
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200006C  // size: 0x30
    public sealed class <_CheckForUpdateCoroutineMobile>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginCheckForUpdateNode <>4__this;  // 0x20
        private Beyond.Login.LoginGameUpdater.Result <result>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000229
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600022A
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577784C  token: 0x600022B
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777A98  token: 0x600022D
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200006D  // size: 0x28
    public sealed class <_CheckForUpdateCoroutinePC>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginCheckForUpdateNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600022F
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000230
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03B298A0  token: 0x6000231
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777AE4  token: 0x6000233
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200006E  // size: 0x38
    public sealed class <_CheckForUpdatePC>d__9 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginCheckForUpdateNode <>4__this;  // 0x20
        private Beyond.Misc.ObjectRef <actionRef>5__2;  // 0x28
        private System.String <errorInfo>5__3;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000235
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000236
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03922230  token: 0x6000237
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777B7C  token: 0x6000239
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200006F  // size: 0x40
    public sealed class <_GetOnlineAppVersion>d__11 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginCheckForUpdateNode <>4__this;  // 0x20
        public Beyond.Misc.ObjectRef outRef;  // 0x28
        private System.String <url>5__2;  // 0x30
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<Beyond.Login.LoginCheckForUpdateNode.AppVersionRespone>> <httpResIndex>5__3;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600023B
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600023C
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0229C7F0  token: 0x600023D
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577902C  token: 0x600023F
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000071  // size: 0x20
    public class WorkProcess : UnityEngine.CustomYieldInstruction, System.IDisposable
    {
        // Fields
        private Beyond.Login.LoginCreateRoleNode m_closure;  // 0x10
        private System.Boolean m_isFinished;  // 0x18

        // Properties
        System.Boolean keepWaiting { get; /* RVA: 0x03D032E0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000248
        public System.Void .ctor(Beyond.Login.LoginCreateRoleNode closure) { }
        // RVA: 0x0577BEA8  token: 0x600024A
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x2000073  // size: 0x20
    public sealed class <>c__DisplayClass24_0
    {
        // Fields
        public Beyond.Login.LoginDownloadTask <>4__this;  // 0x10
        public Beyond.SDK.HGDownloader.PauseReason reason;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600025A
        public System.Void .ctor() { }
        // RVA: 0x0103D340  token: 0x600025B
        private System.Void <_OnDownloadPaused>b__1() { }

    }

    // TypeToken: 0x2000074  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Login.LoginDownloadTask.<>c <>9;  // static @ 0x0
        public static System.Action <>9__24_0;  // static @ 0x8

        // Methods
        // RVA: 0x05777750  token: 0x600025C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600025D
        public System.Void .ctor() { }
        // RVA: 0x0103C3B0  token: 0x600025E
        private System.Void <_OnDownloadPaused>b__24_0() { }

    }

    // TypeToken: 0x2000077  // size: 0x20
    public sealed class <_GameUpdateCoroutine>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600026A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600026B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03D4C410  token: 0x600026C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05778400  token: 0x600026E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000078  // size: 0x30
    public sealed class <_GameUpdateCoroutineMobileImpl>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdateNode <>4__this;  // 0x20
        private Beyond.Login.LoginGameUpdater.Result <result>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000270
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000271
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x057781D8  token: 0x6000272
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057783B4  token: 0x6000274
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200007A  // size: 0x14
    public sealed struct CodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2103;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2105;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2200;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2201;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2202;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2203;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2204;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2205;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2206;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2207;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2208;  // const
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2209;  // const

    }

    // TypeToken: 0x200007B  // size: 0x14
    public sealed struct UpdateType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginGameUpdater.UpdateType FullUpdate;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType IncrementalUpdate;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToBilibile;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToTaptap;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToAppStore;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToGooglePlay;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToSamsungStore;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToRustore;  // const

    }

    // TypeToken: 0x200007C  // size: 0x14
    public sealed struct UpdateCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginGameUpdater.UpdateCode Success;  // const

    }

    // TypeToken: 0x200007D  // size: 0x14
    public sealed struct UpdateAction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginGameUpdater.UpdateAction Invalid;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateAction Latest;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateAction ForcedUpdate;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateAction OptionalUpdate;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateAction Error;  // const
        public static Beyond.Login.LoginGameUpdater.UpdateAction Congestion;  // const

    }

    // TypeToken: 0x200007E  // size: 0x38
    public class HGLatestGameInfo
    {
        // Fields
        public System.Int32 code;  // 0x10
        public System.String version;  // 0x18
        public System.Int32 action;  // 0x20
        public System.Int32 updateType;  // 0x24
        public System.String updateInfo;  // 0x28
        public System.Int32 state;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x6000287
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007F  // size: 0x20
    public class NotificationTitleConfig
    {
        // Fields
        public System.String downloading;  // 0x10
        public System.String pause;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000288
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x18
    public class HGUpdateConfig
    {
        // Fields
        public System.String downloadPath;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000289
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000081  // size: 0x28
    public sealed struct Options
    {
        // Fields
        public Beyond.Login.NetUsagePolicy netUsagePolicy;  // 0x10
        public System.Action<System.String,System.Action> alertDialog;  // 0x18
        public Beyond.LoginContext loginContext;  // 0x20

    }

    // TypeToken: 0x2000082  // size: 0x28
    public class Result
    {
        // Fields
        public System.Boolean needRetry;  // 0x10
        public System.String errorInfo;  // 0x18
        public System.Int32 code;  // 0x20
        public System.Boolean auditing;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x600028A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x40
    public class Context
    {
        // Fields
        public System.Int64 taskId;  // 0x10
        public System.String errorInfo;  // 0x18
        public System.String logError;  // 0x20
        public System.Boolean needClear;  // 0x28
        public Beyond.Login.LoginGameUpdater.HGLatestGameInfo gameInfo;  // 0x30
        private System.Boolean <complete>k__BackingField;  // 0x38
        private System.Int32 <code>k__BackingField;  // 0x3c

        // Properties
        System.Boolean complete { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Int32 code { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x03D4EDC0 */ }

        // Methods
        // RVA: 0x05772A48  token: 0x600028F
        public System.Void CompleteWithCode(System.Int32 pCode) { }
        // RVA: 0x05772AA4  token: 0x6000290
        public System.Void UncompleteWithCode(System.Int32 pCode) { }
        // RVA: 0x05772B00  token: 0x6000291
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000084  // size: 0x30
    public sealed class <CheckLastGameInfo>d__23 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginGameUpdater.Result result;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000292
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000293
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05776B3C  token: 0x6000294
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05776D80  token: 0x6000296
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000085  // size: 0x30
    public sealed class <DoUpdate>d__24 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginGameUpdater.Result result;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000298
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000299
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05776DCC  token: 0x600029A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777128  token: 0x600029C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000086  // size: 0x30
    public sealed class <_GetLastGameInfo>d__25 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginGameUpdater.Context context;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600029E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600029F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x057789D4  token: 0x60002A0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05778FE0  token: 0x60002A2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000087  // size: 0x48
    public sealed class <_UpdateGame>d__26 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginGameUpdater.Context context;  // 0x28
        private Beyond.Login.LoginGameUpdater.HGLatestGameInfo <gameInfo>5__2;  // 0x30
        private System.Int64 <size>5__3;  // 0x38
        private System.Boolean <enableMobileData>5__4;  // 0x40

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002A4
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002A5
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577AA68  token: 0x60002A6
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B0E4  token: 0x60002A8
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000088  // size: 0x58
    public sealed class <_DoTaskUpdating>d__27 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginGameUpdater.Context context;  // 0x28
        private System.Int64 <taskId>5__2;  // 0x30
        private System.Int32 <status>5__3;  // 0x38
        private System.Int64 <curSize>5__4;  // 0x40
        private System.Int64 <totalSize>5__5;  // 0x48
        private System.Int64 <speed>5__6;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002AA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002AB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05777C60  token: 0x60002AC
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05778140  token: 0x60002AE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000089  // size: 0x18
    public sealed class <>c__DisplayClass32_0
    {
        // Fields
        public System.Boolean wait;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002B0
        public System.Void .ctor() { }
        // RVA: 0x03D557C0  token: 0x60002B1
        private System.Void <_YieldErrorAlert>b__0() { }

    }

    // TypeToken: 0x200008A  // size: 0x38
    public sealed class <_YieldErrorAlert>d__32 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public System.String desc;  // 0x28
        private Beyond.Login.LoginGameUpdater.<>c__DisplayClass32_0 <>8__1;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002B2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002B3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577B7B0  token: 0x60002B4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B8EC  token: 0x60002B6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200008B  // size: 0x18
    public sealed class <>c__DisplayClass33_0
    {
        // Fields
        public System.Boolean rejected;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008C  // size: 0x20
    public sealed class <>c__DisplayClass33_1
    {
        // Fields
        public System.Boolean complete;  // 0x10
        public Beyond.Login.LoginGameUpdater.<>c__DisplayClass33_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60002B9
        public System.Void .ctor() { }
        // RVA: 0x01168960  token: 0x60002BA
        private System.Void <_YieldCheckNetUsagePolicy>b__0() { }
        // RVA: 0x05777564  token: 0x60002BB
        private System.Void <_YieldCheckNetUsagePolicy>b__1() { }
        // RVA: 0x01168960  token: 0x60002BC
        private System.Void <_YieldCheckNetUsagePolicy>b__2() { }

    }

    // TypeToken: 0x200008D  // size: 0x40
    public sealed class <_YieldCheckNetUsagePolicy>d__33 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        private Beyond.Login.LoginGameUpdater.<>c__DisplayClass33_0 <>8__1;  // 0x20
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x28
        public System.Int64 downloadSize;  // 0x30
        private Beyond.Login.LoginGameUpdater.<>c__DisplayClass33_1 <>8__2;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002BD
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002BE
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577B4F8  token: 0x60002BF
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B764  token: 0x60002C1
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200008E  // size: 0x38
    public sealed class <_WaitForTaskCancel>d__34 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGameUpdater <>4__this;  // 0x20
        public System.Int64 taskId;  // 0x28
        private System.Boolean <isCanceled>5__2;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002C3
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002C4
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577B304  token: 0x60002C5
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B384  token: 0x60002C7
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000091  // size: 0x48
    public sealed class <_EnterGameCoroutine>d__11 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGSNode.EnterGameServiceFlow <>4__this;  // 0x20
        private U8.SDK.SDKPromiseEnumerator<U8.SDK.U8AuthV2Result> <authPromise>5__2;  // 0x28
        private System.String <token>5__3;  // 0x30
        private System.String <uid>5__4;  // 0x38
        private Beyond.Misc.ObjectRef <loginRespRef>5__5;  // 0x40

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002E7
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002E8
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D797E0  token: 0x60002E9
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577818C  token: 0x60002EB
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000092  // size: 0x58
    public sealed class <_NetConnectAndGSLogin>d__12 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Misc.ObjectRef loginRespRef;  // 0x20
        public Beyond.Login.LoginGSNode.EnterGameServiceFlow <>4__this;  // 0x28
        public System.String uid;  // 0x30
        public System.String token;  // 0x38
        private Beyond.Network.HGNetSessionConnectYield <connectTask>5__2;  // 0x40
        private System.Int32 <maxRetryCount>5__3;  // 0x48
        private System.Int32 <currentRetry>5__4;  // 0x4c
        private Beyond.Network.HGNetSessionLoginYield <loginHandler>5__5;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002ED
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002EE
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0229C260  token: 0x60002EF
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A878  token: 0x60002F1
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000093  // size: 0x28
    public sealed class <_YieldAlertError>d__14 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String errorInfo;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002F3
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002F4
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577B41C  token: 0x60002F5
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B4AC  token: 0x60002F7
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000094  // size: 0x30
    public sealed class <_SaveCurrentUserToServerConfig>d__15 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginGSNode.EnterGameServiceFlow <>4__this;  // 0x20
        public System.String uid;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60002F9
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60002FA
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0315A990  token: 0x60002FB
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577AA1C  token: 0x60002FD
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000095  // size: 0x18
    public sealed class <>c__DisplayClass16_0
    {
        // Fields
        public Beyond.Misc.ObjectRef waitForCallback;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60002FF
        public System.Void .ctor() { }
        // RVA: 0x057774DC  token: 0x6000300
        private System.Void <_MockManualSelectServer>b__0() { }

    }

    // TypeToken: 0x2000096  // size: 0x28
    public sealed class <_MockManualSelectServer>d__16 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String uid;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000301
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000302
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577A6D4  token: 0x6000303
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A82C  token: 0x6000305
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000097  // size: 0x30
    public sealed class <_OnAuthError>d__17 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Object rejectInfo;  // 0x20
        public Beyond.Login.LoginGSNode.EnterGameServiceFlow <>4__this;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000307
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000308
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577A8C4  token: 0x6000309
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A984  token: 0x600030B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000090  // size: 0x30
    public class EnterGameServiceFlow : UnityEngine.CustomYieldInstruction
    {
        // Fields
        private Beyond.LoginContext m_context;  // 0x10
        private Beyond.Login.LoginGSNode m_curNode;  // 0x18
        private Beyond.Misc.ObjectRef m_dialogBlocker;  // 0x20
        private System.Int32 m_state;  // 0x28

        // Properties
        System.Boolean keepWaiting { get; /* RVA: 0x0333FE90 */ }

        // Methods
        // RVA: 0x039CF140  token: 0x60002D8
        public System.Void .ctor(Beyond.Login.LoginGSNode node) { }
        // RVA: 0x05772BC8  token: 0x60002D9
        public System.Void MarkAborting() { }
        // RVA: 0x02D77780  token: 0x60002DA
        public System.Void EnterGame() { }
        // RVA: 0x05772B68  token: 0x60002DB
        public System.Boolean IsInterruptable() { }
        // RVA: 0x05772C20  token: 0x60002DC
        public System.Boolean TryInterrupt() { }
        // RVA: 0x02D778A0  token: 0x60002DD
        private System.Collections.IEnumerator _EnterGameCoroutine() { }
        // RVA: 0x02D77BD0  token: 0x60002DE
        private System.Collections.IEnumerator _NetConnectAndGSLogin(System.String uid, System.String token, Beyond.Misc.ObjectRef loginRespRef) { }
        // RVA: 0x05772C88  token: 0x60002DF
        private static System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout) { }
        // RVA: 0x05772F2C  token: 0x60002E0
        private System.Collections.IEnumerator _YieldAlertError(System.String errorInfo) { }
        // RVA: 0x0229C660  token: 0x60002E1
        private System.Collections.IEnumerator _SaveCurrentUserToServerConfig(System.String uid) { }
        // RVA: 0x05772D84  token: 0x60002E2
        private System.Collections.IEnumerator _MockManualSelectServer(System.String uid) { }
        // RVA: 0x05772E20  token: 0x60002E3
        private System.Collections.IEnumerator _OnAuthError(System.Object rejectInfo) { }
        // RVA: 0x05772EC8  token: 0x60002E4
        private System.Void _ReLoginWhenErrorEncountered() { }
        // RVA: 0x02D759B0  token: 0x60002E5
        private static System.Void _GlobalLoginSucBusiness(Proto.MSG_B1 msg) { }
        // RVA: 0x03D4D9A0  token: 0x60002E6
        private System.Boolean <_EnterGameCoroutine>b__11_0() { }

    }

    // TypeToken: 0x2000098  // size: 0x28
    public sealed class <_ConfirmServer>d__10 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        private U8.SDK.SDKPromiseEnumerator<U8.SDK.U8ConfirmServerResult> <confirmPromise>5__2;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600030D
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600030E
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D75BA0  token: 0x600030F
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777BC8  token: 0x6000311
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200009B
    public interface IProgress
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000315
        public virtual System.Double GetTotal() { }
        // RVA: -1  // abstract  token: 0x6000316
        public virtual System.Double GetCurrent() { }
        // RVA: -1  // abstract  token: 0x6000317
        public virtual System.String GetInfo() { }

    }

    // TypeToken: 0x200009C  // size: 0x18
    public class SimpleProgress : IProgress
    {
        // Fields
        public System.Double current;  // 0x10

        // Methods
        // RVA: 0x032F1360  token: 0x6000318
        public virtual System.Double GetCurrent() { }
        // RVA: 0x032F1530  token: 0x6000319
        public virtual System.Double GetTotal() { }
        // RVA: 0x032F15C0  token: 0x600031A
        public virtual System.String GetInfo() { }
        // RVA: 0x0350B670  token: 0x600031B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009E  // size: 0x58
    public class HotUpdateInfo
    {
        // Fields
        public Beyond.Resource.HotUpdate.FResourceDiff resDiff;  // 0x10
        public Beyond.Resource.HotUpdate.LocalResPref localResPref;  // 0x50

        // Methods
        // RVA: 0x05772FC8  token: 0x6000346
        public System.Boolean CheckIfNeedReload() { }
        // RVA: 0x039CF700  token: 0x6000347
        public System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type) { }
        // RVA: 0x05773174  token: 0x6000348
        public System.Boolean HasAssetsChanged() { }
        // RVA: 0x0350B670  token: 0x6000349
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009F  // size: 0x48
    public class WorkContext
    {
        // Fields
        public Beyond.Login.LoginHotUpdater.HotUpdateInfo updateInitial;  // 0x10
        public Beyond.Login.LoginHotUpdater.HotUpdateInfo updateMain;  // 0x18
        public System.String vitalError;  // 0x20
        public System.Boolean reboot;  // 0x28
        public Beyond.Login.NetUsagePolicy netUsagePolicy;  // 0x30
        public Beyond.Resource.HotUpdate.ResourceIndex resIndex;  // 0x38
        private System.Boolean <illegalItemsInLocalRes>k__BackingField;  // 0x40

        // Properties
        System.Boolean illegalItemsInLocalRes { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }

        // Methods
        // RVA: 0x0577BE58  token: 0x600034C
        public System.Void MarkIllegalItemsInLocalRes() { }
        // RVA: 0x0577BDF4  token: 0x600034D
        public Beyond.Login.LoginHotUpdater.HotUpdateInfo GetHotUpdateInfo(System.Boolean isInitial) { }
        // RVA: 0x039CF690  token: 0x600034E
        public System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type) { }
        // RVA: 0x02F42420  token: 0x600034F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0  // size: 0x30
    public sealed class <_Work>d__27 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        private Beyond.Login.LoginHotUpdater.WorkContext <workContext>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000350
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000351
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02F42170  token: 0x6000352
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B3D0  token: 0x6000354
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A1  // size: 0x30
    public sealed class <_CreateMainCoroutine>d__28 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000356
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000357
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0399E9C0  token: 0x6000358
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05777C14  token: 0x600035A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A2  // size: 0x30
    public sealed class <_MainCoroutineModeSkip>d__29 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginHotUpdater.WorkContext context;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600035C
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600035D
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03B21B80  token: 0x600035E
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A688  token: 0x6000360
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A3  // size: 0x30
    public sealed class <_MainCoroutineModeLocal>d__30 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginHotUpdater.WorkContext context;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000362
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000363
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577A4FC  token: 0x6000364
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A63C  token: 0x6000366
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A4  // size: 0x30
    public sealed class <_UpdateResVersion>d__31 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000368
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000369
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03B387B0  token: 0x600036A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B2B8  token: 0x600036C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A5  // size: 0x28
    public sealed class <_UpdateResVersionDev>d__35 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        private Beyond.Cfg.ResVersionDevCfg <config>5__2;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600036E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600036F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577B130  token: 0x6000370
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B220  token: 0x6000372
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A6  // size: 0x40
    public sealed class <_UpdateResVersionProd>d__37 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x20
        private Beyond.Cfg.ResVersionCfg <config>5__2;  // 0x28
        private Beyond.Misc.ObjectRef <resultRef>5__3;  // 0x30
        private System.String <url>5__4;  // 0x38

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000374
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000375
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02F43380  token: 0x6000376
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577B26C  token: 0x6000378
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000A7  // size: 0x18
    public sealed class <>c__DisplayClass42_0
    {
        // Fields
        public System.Boolean isInitial;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600037A
        public System.Void .ctor() { }
        // RVA: 0x05777584  token: 0x600037B
        private Beyond.Resource.HotUpdate.LocalResPref <_MainCoroutineModeDownload>b__0() { }

    }

    // TypeToken: 0x20000A8  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Login.LoginHotUpdater.<>c <>9;  // static @ 0x0
        public static System.Action <>9__42_1;  // static @ 0x8

        // Methods
        // RVA: 0x057776EC  token: 0x600037C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600037D
        public System.Void .ctor() { }
        // RVA: 0x05777444  token: 0x600037E
        private System.Void <_MainCoroutineModeDownload>b__42_1() { }

    }

    // TypeToken: 0x20000A9  // size: 0x58
    public sealed class <_MainCoroutineModeDownload>d__42 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x28
        private Beyond.Login.LoginHotUpdater.<>c__DisplayClass42_0 <>8__1;  // 0x30
        private System.Boolean <initialDownloaded>5__2;  // 0x38
        private System.Boolean <needDeleteInitial>5__3;  // 0x39
        private System.Boolean <neewDeleteMain>5__4;  // 0x3a
        private System.Int32 <initialOrMain>5__5;  // 0x3c
        private System.String <onlineResVersion>5__6;  // 0x40
        private Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.LocalResPref> <waitForResPref>5__7;  // 0x48
        private Beyond.Login.LoginHotUpdater.HotUpdateInfo <info>5__8;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600037F
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000380
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05779708  token: 0x6000381
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A4B0  token: 0x6000383
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000AA  // size: 0x28
    public sealed class <_ReloadResourceIndexes>d__43 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000385
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000386
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02F57720  token: 0x6000387
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0577A9D0  token: 0x6000389
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000AB  // size: 0x28
    public sealed class <>c__DisplayClass44_0
    {
        // Fields
        public System.String filePath;  // 0x10
        public Beyond.Resource.HotUpdate.ResourceIndex resIndex;  // 0x18
        public System.Func<Beyond.Resource.HotUpdate.ResourceIndex> <>9__1;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600038B
        public System.Void .ctor() { }
        // RVA: 0x05777634  token: 0x600038C
        private Beyond.Resource.HotUpdate.ResourceIndex <_LoadOrDownloadResIndex>b__1() { }
        // RVA: 0x057775F8  token: 0x600038D
        private System.Object <_LoadOrDownloadResIndex>b__0() { }

    }

    // TypeToken: 0x20000AC  // size: 0x60
    public sealed class <_LoadOrDownloadResIndex>d__44 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Boolean isInitial;  // 0x20
        private Beyond.Login.LoginHotUpdater.<>c__DisplayClass44_0 <>8__1;  // 0x28
        public System.String onlineVer;  // 0x30
        public Beyond.Misc.ObjectRef resIndexRef;  // 0x38
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x40
        private System.String <indexUrl>5__2;  // 0x48
        private Beyond.Misc.ObjectRef <resultRef>5__3;  // 0x50
        private Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.ResourceIndex> <loadTask>5__4;  // 0x58

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600038E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600038F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05779078  token: 0x6000390
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057796BC  token: 0x6000392
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000AD  // size: 0x48
    public sealed class <_GenResIndex>d__45 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public System.String onlineVer;  // 0x28
        public System.Boolean isInitial;  // 0x30
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x38
        private Beyond.Misc.ObjectRef <resIndexRef>5__2;  // 0x40

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000394
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000395
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0577844C  token: 0x6000396
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05778588  token: 0x6000398
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000AE  // size: 0x78
    public sealed class <_GenRiff>d__46 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x20
        public System.Boolean isInitial;  // 0x28
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x30
        public System.String onlineVer;  // 0x38
        private Beyond.Login.LoginHotUpdater.HotUpdateInfo <info>5__2;  // 0x40
        private Beyond.Resource.HotUpdate.LocalResPref <localResPref>5__3;  // 0x48
        private System.String <rootUrl>5__4;  // 0x50
        private System.String <patchUrl>5__5;  // 0x58
        private System.String <fileUrl>5__6;  // 0x60
        private Beyond.Resource.HotUpdate.ResourceIndex <resIndex>5__7;  // 0x68
        private Beyond.Misc.ObjectRef <streamingIndexRef>5__8;  // 0x70

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600039A
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600039B
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x057785D4  token: 0x600039C
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05778988  token: 0x600039E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000AF  // size: 0x38
    public sealed class <_GenLocalRef>d__48 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x20
        public System.Boolean isInitial;  // 0x28
        public System.String onlineVer;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003A0
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003A1
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x01041100  token: 0x60003A2
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x01041B50  token: 0x60003A4
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B0  // size: 0x78
    public sealed class <_CheckAndDownloadResource>d__49 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x20
        public System.Boolean isInitial;  // 0x28
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x30
        public System.String onlineVer;  // 0x38
        private Beyond.Login.LoginHotUpdater.HotUpdateInfo <info>5__2;  // 0x40
        private Beyond.Login.LoginHotUpdateModel <hotUpdateModel>5__3;  // 0x48
        private System.String <patchInfo>5__4;  // 0x50
        private Beyond.Login.LoginDownloadTask <downloadTask>5__5;  // 0x58
        private Beyond.SDK.HGDownloader.WorkState <lastWorkState>5__6;  // 0x60
        private System.Boolean <progress5>5__7;  // 0x64
        private System.Boolean <progress25>5__8;  // 0x65
        private System.Boolean <progress50>5__9;  // 0x66
        private System.Boolean <progress75>5__10;  // 0x67
        private System.Boolean <progress90>5__11;  // 0x68
        private Beyond.Misc.ObjectRef <patchInfoRef>5__12;  // 0x70

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003A6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003A7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0103D370  token: 0x60003A8
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x010410A0  token: 0x60003AA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B1  // size: 0x50
    public sealed class <_DownloadPatchInfo>d__51 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public System.String onlineVer;  // 0x28
        public System.Boolean isInitial;  // 0x30
        public Beyond.Misc.ObjectRef patchInfoRef;  // 0x38
        private System.String <patchInfoUrl>5__2;  // 0x40
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<Beyond.Resource.HotUpdate.PatchInfo>> <httpResIndex>5__3;  // 0x48

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003AC
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003AD
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x01048EE0  token: 0x60003AE
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0104B300  token: 0x60003B0
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B2  // size: 0x58
    public sealed class <_ClearDownloadFolder>d__52 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public System.Boolean needDeleteInitial;  // 0x28
        public System.Boolean needDeleteMain;  // 0x29
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x30
        private System.Collections.Generic.List<Beyond.SDK.HGFolder> <folderList>5__2;  // 0x38
        private System.Int32 <initialOrMain>5__3;  // 0x40
        private System.Boolean <isInitial>5__4;  // 0x44
        private System.String <onlineVer>5__5;  // 0x48
        private Beyond.Login.LoginHotUpdater.HotUpdateInfo <info>5__6;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003B2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003B3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x01045480  token: 0x60003B4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x01048E90  token: 0x60003B6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B3  // size: 0x68
    public sealed class <_CheckLocalResConsistency>d__53 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater.WorkContext context;  // 0x20
        public System.Boolean isInitial;  // 0x28
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x30
        public System.String onlineVer;  // 0x38
        private Beyond.Resource.HotUpdate.LocalResPref <localResInfo>5__2;  // 0x40
        private Beyond.Misc.ObjectRef <resIndexRef>5__3;  // 0x48
        private System.Boolean <showProgress>5__4;  // 0x50
        private Beyond.WaitForAsyncTask<System.Object> <checkTask>5__5;  // 0x58
        private Beyond.Resource.HotUpdate.LocalResChecker.CheckOutput <checkOutput>5__6;  // 0x60

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003B8
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003B9
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x01041BD0  token: 0x60003BA
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x01045430  token: 0x60003BC
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B4  // size: 0x30
    public sealed class <_VitalError>d__54 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginHotUpdater <>4__this;  // 0x20
        public System.String error;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003BE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003BF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0104DAC0  token: 0x60003C0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0104E7A0  token: 0x60003C2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B5  // size: 0x18
    public sealed class <>c__DisplayClass55_0
    {
        // Fields
        public Beyond.RuntimeFileUtils.StreamingResult indexRet;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60003C4
        public System.Void .ctor() { }
        // RVA: 0x01041BA0  token: 0x60003C5
        private Beyond.Resource.HotUpdate.ResourceIndex <_LoadStreamingIndex>b__0() { }

    }

    // TypeToken: 0x20000B6  // size: 0x50
    public sealed class <_LoadStreamingIndex>d__55 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.Boolean isInitial;  // 0x20
        private Beyond.Login.LoginHotUpdater.<>c__DisplayClass55_0 <>8__1;  // 0x28
        public Beyond.Misc.ObjectRef resultRef;  // 0x30
        public Beyond.Login.LoginHotUpdater.WorkContext workContext;  // 0x38
        private System.String <indexPath>5__2;  // 0x40
        private Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.ResourceIndex> <waitForIndex>5__3;  // 0x48

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003C6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003C7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0104B350  token: 0x60003C8
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0104DA70  token: 0x60003CA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000B9  // size: 0x14
    public sealed struct EUnit
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit NONE;  // const
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit B;  // const
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit KB;  // const
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit MB;  // const

    }

    // TypeToken: 0x20000B8  // size: 0x30
    public sealed struct FDownloadSize
    {
        // Fields
        private static System.Double MB;  // const
        private static System.Double KB;  // const
        private Beyond.Login.LoginProgress.FDownloadSize.EUnit m_unit;  // 0x10
        private System.Single m_displayCurrent;  // 0x14
        private System.Single m_displayTotal;  // 0x18
        private System.Single m_displaySpeed;  // 0x1c
        public System.String displayInfo;  // 0x20
        private System.Single m_current;  // 0x28
        private System.Single m_total;  // 0x2c

        // Methods
        // RVA: 0x0577C668  token: 0x60003D0
        public System.Void SetProgress(System.Double current, System.Double total) { }
        // RVA: 0x0577C59C  token: 0x60003D1
        public System.Void SetIdle() { }
        // RVA: 0x0577C778  token: 0x60003D2
        public System.Void SetSize(System.Double current, System.Double total, System.Double speed) { }
        // RVA: 0x0577CCEC  token: 0x60003D3
        private static Beyond.Login.LoginProgress.FDownloadSize.EUnit _PickUnit(System.Double number) { }
        // RVA: 0x0577C978  token: 0x60003D4
        private static System.Single _DisplayWithUnit(System.Double number, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit) { }
        // RVA: 0x0577CA18  token: 0x60003D5
        private static System.String _FormatDisplayInfo(System.Single current, System.Single total, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit) { }
        // RVA: 0x0577CBFC  token: 0x60003D6
        private static System.String _FormatSpeedInfo(System.Single speed, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit) { }
        // RVA: 0x0577CB4C  token: 0x60003D7
        private static System.String _FormatProgressInfo(System.Single current, System.Single total) { }

    }

    // TypeToken: 0x20000BB  // size: 0x28
    public sealed class <_InitCoroutine>d__4 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginInitNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003DE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003DF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03893BF0  token: 0x60003E0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05782148  token: 0x60003E2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000BC  // size: 0x30
    public sealed class <_InitRemoteConfigs>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginInitNode <>4__this;  // 0x20
        private Beyond.Network.NetConfigInterface.InitYiedInstruction <initNetConfig>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003E4
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003E5
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0315AE20  token: 0x60003E6
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05782194  token: 0x60003E8
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000BD  // size: 0x28
    public sealed class <_YieldAlertError>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String errorInfo;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003EA
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003EB
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x057823A8  token: 0x60003EC
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05782438  token: 0x60003EE
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000BF  // size: 0x20
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.String indexPath;  // 0x10
        public System.String prefPath;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60003F3
        public System.Void .ctor() { }
        // RVA: 0x057805C0  token: 0x60003F4
        private Beyond.Resource.HotUpdate.ResourceIndex <Work>b__0() { }
        // RVA: 0x05780610  token: 0x60003F5
        private Beyond.Resource.HotUpdate.LocalResPref <Work>b__1() { }

    }

    // TypeToken: 0x20000C0  // size: 0x80
    public sealed class <Work>d__3 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginLocalResTask <>4__this;  // 0x20
        private Beyond.Login.LoginLocalResTask.<>c__DisplayClass3_0 <>8__1;  // 0x28
        private Beyond.Login.LoginHotUpdater.WorkContext <workContext>5__2;  // 0x30
        private Beyond.Login.LoginHotUpdateProp <viewProp>5__3;  // 0x38
        private Beyond.Login.LoginHotUpdateModel <viewModel>5__4;  // 0x40
        private Beyond.Resource.HotUpdate.ResourceIndex[] <resIndexList>5__5;  // 0x48
        private System.Int32 <initialOrMain>5__6;  // 0x50
        private System.Boolean <isInitial>5__7;  // 0x54
        private Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.ResourceIndex> <waitForResIndex>5__8;  // 0x58
        private Beyond.Resource.RootCategory <rootCategory>5__9;  // 0x60
        private Beyond.Login.LoginHotUpdateModel.SimpleProgress <progress>5__10;  // 0x68
        private Beyond.WaitForAsyncTask<System.Object> <checkTask>5__11;  // 0x70
        private Beyond.Resource.HotUpdate.LocalResChecker.CheckOutput <checkOutput>5__12;  // 0x78

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60003F6
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60003F7
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0578077C  token: 0x60003F8
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057816B8  token: 0x60003FA
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C2  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Login.PreloadNode.<>c <>9;  // static @ 0x0
        public static System.Func<System.Boolean> <>9__5_0;  // static @ 0x8

        // Methods
        // RVA: 0x03D1A570  token: 0x6000408
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000409
        public System.Void .ctor() { }
        // RVA: 0x028AC600  token: 0x600040A
        private System.Boolean <Work>b__5_0() { }

    }

    // TypeToken: 0x20000C3  // size: 0x28
    public sealed class <_LoginPreLoad>d__7 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.PreloadNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600040B
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600040C
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C34DC0  token: 0x600040D
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05782278  token: 0x600040F
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C4  // size: 0x28
    public sealed class <_WarmUp>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.PreloadNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000411
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000412
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03745D60  token: 0x6000413
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0578235C  token: 0x6000415
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C5  // size: 0x28
    public sealed class <_GetServerList>d__9 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.PreloadNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000417
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000418
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D76F70  token: 0x6000419
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057820FC  token: 0x600041B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C6  // size: 0x28
    public sealed class <_GetServerListInfoMock>d__11 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.PreloadNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600041D
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600041E
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D75180  token: 0x600041F
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05781AC8  token: 0x6000421
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C7  // size: 0x30
    public sealed class <_GetServerListInfo>d__12 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.PreloadNode <>4__this;  // 0x20
        private U8.SDK.SDKPromiseEnumerator<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> <getServerListPromise>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000423
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000424
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05781B14  token: 0x6000425
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057820B0  token: 0x6000427
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000C8  // size: 0x28
    public sealed class <>c__DisplayClass13_0
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> serverZoneDataList;  // 0x10
        public System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo> serverList;  // 0x18
        public System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000429
        public System.Void .ctor() { }
        // RVA: 0x0578020C  token: 0x600042A
        private System.Void <_OnGetServerListSuc>b__0(Hypergryph.SpeedTest.SpeedTestResult result) { }
        // RVA: 0x05780558  token: 0x600042B
        private System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> <_OnGetServerListSuc>b__1() { }

    }

    // TypeToken: 0x20000CA  // size: 0x30
    public sealed class <_SDKInitCoroutine>d__4 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginSDKInitNode <>4__this;  // 0x20
        private System.String <env>5__2;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000432
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000433
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D78C10  token: 0x6000434
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057822C4  token: 0x6000436
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000CB  // size: 0x20
    public sealed class <_WaitForSDKInited>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000438
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000439
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03A93F40  token: 0x600043A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05782310  token: 0x600043C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000CC  // size: 0x28
    public sealed class <_InitSubSDKs>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public System.String env;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600043E
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600043F
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x029554C0  token: 0x6000440
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057821E0  token: 0x6000442
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000CE  // size: 0x28
    public sealed class <_LoginCoroutine>d__6 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.U8LoginNode <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000457
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000458
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D79040  token: 0x6000459
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0578222C  token: 0x600045B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000CF  // size: 0x30
    public sealed class <_FinishLogin>d__7 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        private System.String <env>5__2;  // 0x20
        private U8.SDK.SDKPromiseEnumerator<U8.SDK.U8AuthV2Result> <authPromise>5__3;  // 0x28

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x600045D
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x600045E
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02D794A0  token: 0x600045F
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05781A7C  token: 0x6000461
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000D4  // size: 0x13
    public sealed struct FAgeTipsPolicy
    {
        // Fields
        public System.Boolean canOpenDetail;  // 0x10
        public System.Boolean displayCN;  // 0x11
        public System.Boolean displayKR;  // 0x12

        // Properties
        System.Boolean display { get; /* RVA: 0x02C3B5D0 */ }

    }

    // TypeToken: 0x20000D9  // size: 0x20
    public abstract class Node
    {
        // Fields
        private Beyond.LoginContext <context>k__BackingField;  // 0x10
        private Beyond.Login.LoginWorkFlow <workflow>k__BackingField;  // 0x18

        // Properties
        Beyond.LoginContext context { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        Beyond.Login.LoginWorkFlow workflow { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: 0x02C388D0  token: 0x60004A5
        public System.Void Init(Beyond.LoginContext context, Beyond.Login.LoginWorkFlow workflow) { }
        // RVA: 0x02C389B0  token: 0x60004A6
        public System.Void Dispose() { }
        // RVA: -1  // abstract  token: 0x60004A8
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x0577FFD4  token: 0x60004A9
        public virtual System.Boolean CanCancel() { }
        // RVA: 0x05780020  token: 0x60004AA
        public virtual UnityEngine.CustomYieldInstruction Cancel() { }
        // RVA: 0x02C38930  token: 0x60004AB
        protected virtual System.Void OnInit() { }
        // RVA: 0x0379F840  token: 0x60004AC
        public virtual System.Void OnDispose() { }
        // RVA: 0x02D758F0  token: 0x60004AD
        public virtual System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param) { }
        // RVA: 0x0350B670  token: 0x60004AE
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA  // size: 0x14
    public sealed struct ENode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginWorkFlow.ENode None;  // const
        public static Beyond.Login.LoginWorkFlow.ENode CheckForUpdate;  // const
        public static Beyond.Login.LoginWorkFlow.ENode SDKInit;  // const
        public static Beyond.Login.LoginWorkFlow.ENode GameUpdate;  // const
        public static Beyond.Login.LoginWorkFlow.ENode Init;  // const
        public static Beyond.Login.LoginWorkFlow.ENode U8Login;  // const
        public static Beyond.Login.LoginWorkFlow.ENode HotUpdate;  // const
        public static Beyond.Login.LoginWorkFlow.ENode ResCheck;  // const
        public static Beyond.Login.LoginWorkFlow.ENode Preload;  // const
        public static Beyond.Login.LoginWorkFlow.ENode PreloadPostDelay;  // const
        public static Beyond.Login.LoginWorkFlow.ENode Trans2GsLogin;  // const
        public static Beyond.Login.LoginWorkFlow.ENode GsLogin;  // const
        public static Beyond.Login.LoginWorkFlow.ENode CreateRole;  // const
        public static Beyond.Login.LoginWorkFlow.ENode Finish;  // const

    }

    // TypeToken: 0x20000DB
    public interface IWorkerUpdateOnce
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60004AF
        public virtual System.Void Worker_UpdateOnce() { }

    }

    // TypeToken: 0x20000DC
    public interface IEventReceiver
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60004B0
        public virtual System.Void OnEvent(Beyond.ELoginEvent evt, System.Object param) { }

    }

    // TypeToken: 0x20000DE  // size: 0x38
    public sealed class <Work>d__20 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginWorkFlow.Worker <>4__this;  // 0x20
        public UnityEngine.CustomYieldInstruction work;  // 0x28
        private UnityEngine.CustomYieldInstruction <cancelTask>5__2;  // 0x30

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60004BF
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60004C0
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0306D680  token: 0x60004C1
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05780730  token: 0x60004C3
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000DD  // size: 0x38
    public class Worker : System.IDisposable
    {
        // Fields
        private System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce> m_updateOnce;  // 0x10
        private System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce> m_buffer;  // 0x18
        private UnityEngine.CustomYieldInstruction m_curWork;  // 0x20
        private System.Boolean <isCancelled>k__BackingField;  // 0x28
        private System.Boolean <isDisposed>k__BackingField;  // 0x29
        private Beyond.Login.LoginWorkFlow.Node <curNode>k__BackingField;  // 0x30

        // Properties
        System.Boolean isCancelled { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        System.Boolean isDisposed { get; /* RVA: 0x03D4F2A0 */ set; /* RVA: 0x03D4F2B0 */ }
        Beyond.Login.LoginWorkFlow.Node curNode { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }

        // Methods
        // RVA: 0x05782880  token: 0x60004B7
        public System.Boolean Cancel() { }
        // RVA: 0x03CF6170  token: 0x60004B8
        public virtual System.Void Dispose() { }
        // RVA: 0x02C386D0  token: 0x60004B9
        public System.Void SetCurNode(Beyond.Login.LoginWorkFlow.Node node) { }
        // RVA: 0x036007F0  token: 0x60004BA
        public System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst) { }
        // RVA: 0x0306D640  token: 0x60004BB
        public System.Void TickInEmptyFrame() { }
        // RVA: 0x02C389F0  token: 0x60004BC
        public System.Collections.IEnumerator Work(UnityEngine.CustomYieldInstruction work) { }
        // RVA: 0x0306D7C0  token: 0x60004BD
        private System.Void _InternalTick() { }
        // RVA: 0x03C95FE0  token: 0x60004BE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000DF  // size: 0x1C
    public sealed struct FWork
    {
        // Fields
        public static readonly Beyond.Login.LoginWorkFlow.FWork IDLE;  // static @ 0x0
        private System.Boolean <didFallback>k__BackingField;  // 0x10
        private System.Int32 <nodeIndex>k__BackingField;  // 0x14
        private System.Boolean <isWorking>k__BackingField;  // 0x18

        // Properties
        System.Boolean didFallback { get; /* RVA: 0x03D51020 */ set; /* RVA: 0x03D4F9D0 */ }
        System.Int32 nodeIndex { get; /* RVA: 0x03D4E990 */ set; /* RVA: 0x03D51720 */ }
        System.Boolean isWorking { get; /* RVA: 0x03D557D0 */ set; /* RVA: 0x03D557E0 */ }
        Beyond.Login.LoginWorkFlow.ENode curNode { get; /* RVA: 0x02C39460 */ }

        // Methods
        // RVA: 0x0577CD70  token: 0x60004CB
        public System.Void MarkFallback(System.Int32 newIndex) { }
        // RVA: 0x02C39570  token: 0x60004CC
        public System.Boolean ConsumeFallback() { }
        // RVA: 0x02C39510  token: 0x60004CD
        public System.Void MoveNextIndex() { }
        // RVA: 0x03CE47E0  token: 0x60004CE
        public static Beyond.Login.LoginWorkFlow.FWork Start() { }
        // RVA: 0x02C38DB0  token: 0x60004D0
        public System.Boolean WorkEnd() { }
        // RVA: 0x0350B670  token: 0x60004D1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E0  // size: 0x50
    public sealed class <DoWorkFlow>d__21 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginWorkFlow <>4__this;  // 0x20
        private Beyond.Login.LoginWorkFlow.Worker <worker>5__2;  // 0x28
        private Beyond.Login.LoginViewProperty <viewProp>5__3;  // 0x30
        private Beyond.Login.LoginWorkFlow.ENode <cachedCurrent>5__4;  // 0x38
        private System.Boolean <isEmptyFrame>5__5;  // 0x3c
        private System.Boolean <isAbort>5__6;  // 0x3d
        private Beyond.Login.LoginWorkFlow.Node[] <>7__wrap6;  // 0x40
        private System.Int32 <>7__wrap7;  // 0x48

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60004D2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60004D3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C38E60  token: 0x60004D4
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x057801C0  token: 0x60004D6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000E1  // size: 0x48
    public sealed class <_FetchAgeTipsCoroutine>d__41 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginAgeTipsProp prop;  // 0x20
        public Beyond.Login.LoginWorkFlow <>4__this;  // 0x28
        private Beyond.Login.LoginAgeTipsModel <model>5__2;  // 0x30
        private Beyond.LoginController.MaskCtrl <maskCtrl>5__3;  // 0x38
        private Beyond.Misc.ObjectRef <httpRetRef>5__4;  // 0x40

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60004D8
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60004D9
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05781750  token: 0x60004DA
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05781A30  token: 0x60004DC
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000E2  // size: 0x28
    public sealed class <_AdjustCurrentGameState>d__43 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginWorkFlow.ENode curNode;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60004DE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60004DF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C385C0  token: 0x60004E0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05781704  token: 0x60004E2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x20000EA  // size: 0x18
    public sealed struct Options
    {
        // Fields
        public System.Int64 minBytesToNotifyCarrier;  // 0x10

    }

    // TypeToken: 0x20000EB  // size: 0x30
    public sealed class <>c__DisplayClass6_0
    {
        // Fields
        public System.Int64 downloadSize;  // 0x10
        public Beyond.Login.NetUsagePolicy <>4__this;  // 0x18
        public System.Action onAllowed;  // 0x20
        public System.Action onRejected;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000504
        public System.Void .ctor() { }
        // RVA: 0x05780640  token: 0x6000505
        private System.Void <CheckIfAllowDownload>b__0() { }
        // RVA: 0x057806C0  token: 0x6000506
        private System.Void <CheckIfAllowDownload>b__1() { }

    }

    // TypeToken: 0x20000ED  // size: 0x14
    public sealed struct EState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginSceneAnimCtrl.EState NONE;  // const
        public static Beyond.Login.LoginSceneAnimCtrl.EState A1;  // const
        public static Beyond.Login.LoginSceneAnimCtrl.EState A2;  // const

    }

    // TypeToken: 0x20000F3  // size: 0x20
    public sealed struct FParams
    {
        // Fields
        public System.String text;  // 0x10
        public System.Action onConfirm;  // 0x18

    }

    // TypeToken: 0x20000F8  // size: 0x14
    public sealed struct Style
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Login.LoginJudgeDialog.Style Center;  // const
        public static Beyond.Login.LoginJudgeDialog.Style Left;  // const

    }

    // TypeToken: 0x20000F9  // size: 0x40
    public sealed struct FParams
    {
        // Fields
        public System.String text;  // 0x10
        public System.Action onPositive;  // 0x18
        public System.Action onNegative;  // 0x20
        public System.String btnPositive;  // 0x28
        public System.String btnNegative;  // 0x30
        public Beyond.Login.LoginJudgeDialog.Style style;  // 0x38

    }

    // TypeToken: 0x20000FB  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Login.LoginMenuPanel.<>c <>9;  // static @ 0x0
        public static System.Action <>9__43_0;  // static @ 0x8

        // Methods
        // RVA: 0x0578C0E4  token: 0x600057C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600057D
        public System.Void .ctor() { }
        // RVA: 0x0578BCFC  token: 0x600057E
        private System.Void <_OnQuitGameClicked>b__43_0() { }

    }

    // TypeToken: 0x20000FD  // size: 0x20
    public sealed struct FOptions
    {
        // Fields
        public System.String fixedUID;  // 0x10
        public Beyond.LoginContext context;  // 0x18

        // Methods
        // RVA: 0x03159690  token: 0x6000591
        public System.Boolean IsUIDFixed() { }

    }

    // TypeToken: 0x20000FE  // size: 0x28
    public sealed class <HideAndDestroy>d__21 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginMockUIDPanel <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000592
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000593
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x02C3D330  token: 0x6000594
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0578BCB0  token: 0x6000596
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000101  // size: 0x28
    public abstract class ChildPanel : UnityEngine.MonoBehaviour, Beyond.Login.ILoginContextReceiver
    {
        // Fields
        private Beyond.UI.UISwitchTween <switchTween>k__BackingField;  // 0x18
        private Beyond.LoginContext <context>k__BackingField;  // 0x20

        // Properties
        Beyond.UI.UISwitchTween switchTween { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        Beyond.LoginContext context { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x02EA9480  token: 0x60005A9
        public virtual System.Void OnLoginContext(Beyond.LoginContext context) { }
        // RVA: 0x03610B70  token: 0x60005AA
        protected virtual System.Void OnInit() { }
        // RVA: 0x02C3D440  token: 0x60005AB
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x05782DCC  token: 0x60005AC
        protected System.Void SetPanelVisibleByAnimSwitchTween(Beyond.UI.UIAnimationWrapper anim, System.Boolean isVisible, System.Boolean forceReset) { }
        // RVA: 0x02C3B860  token: 0x60005AD
        protected System.Void SetPanelVisibleByFadeSwitchTween(UnityEngine.CanvasGroup canvasGroup, System.Boolean isVisible, System.Boolean forceReset) { }
        // RVA: 0x0426FE60  token: 0x60005AE
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000103  // size: 0x30
    public sealed struct DelayInfo
    {
        // Fields
        public UnityEngine.Color color;  // 0x10
        public System.Int32 colorCount;  // 0x20
        public System.Int32 delayMax;  // 0x24
        public System.String text;  // 0x28

    }

    // TypeToken: 0x2000108  // size: 0x30
    public sealed class <>c__DisplayClass10_0
    {
        // Fields
        public Beyond.Login.LoginServerSelectPanel <>4__this;  // 0x10
        public System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> serverZoneDataList;  // 0x18
        public System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo> serverList;  // 0x20
        public System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60005CA
        public System.Void .ctor() { }
        // RVA: 0x0578BD08  token: 0x60005CB
        private System.Void <OnEnable>b__0(Hypergryph.SpeedTest.SpeedTestResult result) { }
        // RVA: 0x0578C07C  token: 0x60005CC
        private System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> <OnEnable>b__1() { }

    }

    // TypeToken: 0x2000109  // size: 0x28
    public sealed class <_WaitingForShowListAwake>d__11 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Beyond.Login.LoginServerSelectPanel <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60005CD
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60005CE
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0578C148  token: 0x60005CF
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0578C238  token: 0x60005D1
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200010C  // size: 0x18
    public sealed struct FParams
    {
        // Fields
        public System.Action onConfirm;  // 0x10

    }

    // TypeToken: 0x200010D  // size: 0x20
    public class VocResInfo
    {
        // Fields
        public System.String nameTextId;  // 0x10
        public Beyond.VFS.EVFSBlockType type;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60005E9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000110
    public class GameSettingSetterItem`1
    {
        // Fields
        private readonly System.String m_settingId;  // 0x0
        private readonly System.Action<T> m_otherSystemSet;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600064E
        public System.Void .ctor(System.String settingId) { }
        // RVA: -1  // not resolved  token: 0x600064F
        public System.Void .ctor(System.String settingId, System.Action<T> otherSystemSet) { }
        // RVA: -1  // not resolved  token: 0x6000650
        public System.Void Set(T value, System.Boolean forceSetOtherSystem) { }

    }

    // TypeToken: 0x2000111
    public class GameSettingSetterItem`2
    {
        // Fields
        private readonly System.String m_mainSettingId;  // 0x0
        private readonly System.String m_settingId1;  // 0x0
        private readonly System.String m_settingId2;  // 0x0
        private readonly System.Action<T1,T2> m_otherSystemSet;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000651
        public System.Void .ctor(System.String mainSettingId, System.String settingId1, System.String settingId2, System.Action<T1,T2> otherSystemSet) { }
        // RVA: -1  // not resolved  token: 0x6000652
        public System.Void Set(T1 value1, T2 value2, System.Boolean forceSetOtherSystem) { }

    }

    // TypeToken: 0x2000114  // size: 0x44
    public sealed struct __StaticArrayInitTypeSize=52
    {
    }

    // TypeToken: 0x2000113  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DF6EA5B59F0E6C03F390AD5FEA0BBC199EC3524C0A682913148FD071AF1898EC;  // static @ 0x0

    }

namespace Beyond
{

    // TypeToken: 0x2000004  // size: 0x28
    public class GameApp : UnityEngine.MonoBehaviour, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.GameStateMachine m_stateMachine;  // 0x18
        private static Beyond.GameApp <instance>k__BackingField;  // static @ 0x0
        private System.Boolean m_hasFocus;  // 0x20
        private System.Boolean m_needCallLuaFocus;  // 0x21
        private System.Boolean m_pauseStatus;  // 0x22
        private System.Boolean m_needCallLuaPause;  // 0x23

        // Properties
        Beyond.GameApp instance { get; /* RVA: 0x0576CF50 */ set; /* RVA: 0x0576CF88 */ }
        Beyond.GameState currentState { get; /* RVA: 0x028AC670 */ }

        // Methods
        // RVA: 0x02C35180  token: 0x6000008
        public System.Void SwitchState(Beyond.GameState state) { }
        // RVA: 0x03157A50  token: 0x6000009
        private System.Void Awake() { }
        // RVA: 0x0332FD80  token: 0x600000A
        private System.Void _RegisterLuaAfterGCEvent() { }
        // RVA: 0x02632400  token: 0x600000B
        private System.Void Update() { }
        // RVA: 0x02EC53C0  token: 0x600000C
        private System.Void LateUpdate() { }
        // RVA: 0x0576C72C  token: 0x600000D
        private System.Void OnApplicationQuit() { }
        // RVA: 0x029A6920  token: 0x600000E
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        // RVA: 0x02B54CB0  token: 0x600000F
        private System.Void _OnApplicationFocusForLua() { }
        // RVA: 0x03134CA0  token: 0x6000010
        private System.Void OnApplicationPause(System.Boolean pauseStatus) { }
        // RVA: 0x03134F90  token: 0x6000011
        private System.Void _OnApplicationPauseForLua() { }
        // RVA: 0x0576C954  token: 0x6000012
        private System.Void OnDestroy() { }
        // RVA: 0x02954CA0  token: 0x6000013
        private System.Void _PreInitGameSetting() { }
        // RVA: 0x03156EB0  token: 0x6000014
        private System.Void _Init() { }
        // RVA: 0x0576CEC0  token: 0x6000015
        private System.Void _UnInit() { }
        // RVA: 0x031573F0  token: 0x6000016
        private System.Void _InitGameStateMachine() { }
        // RVA: 0x0576CE38  token: 0x6000017
        private System.Void _UnInitGameStateMachine() { }
        // RVA: 0x0576CB5C  token: 0x6000018
        public static System.Void QuitGame(System.Int32 exitCode) { }
        // RVA: 0x0576CC18  token: 0x6000019
        public static System.Void RefreshScreenResolution() { }
        // RVA: 0x0576CD18  token: 0x600001A
        private static System.Void _OnSystemDisplaySizeChanged() { }
        // RVA: 0x0576CD58  token: 0x600001B
        private static System.Void _OnSystemScreenSizeChanged(Beyond.EventData<System.Boolean,System.Boolean>& data) { }
        // RVA: 0x031570D0  token: 0x600001C
        private System.Collections.IEnumerator _InitSecuritySDK() { }
        // RVA: 0x02C3E8C0  token: 0x600001D
        private System.Void _OnApplicationPauseForSecurity(System.Boolean pauseStatus) { }
        // RVA: 0x03D006E0  token: 0x600001E
        private System.Collections.IEnumerator _FetchRemoteConfigUtilSuc() { }
        // RVA: 0x03A1E660  token: 0x600001F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public interface IMemoryPackProxy
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600002C
        public virtual System.Void Init() { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public class MemoryPackProxyModule
    {
        // Fields
        private static Beyond.IMemoryPackProxy s_memoryPackProxy;  // static @ 0x0

        // Methods
        // RVA: 0x0576EBA0  token: 0x600002D
        public static System.Void RegisterProxy(Beyond.IMemoryPackProxy memoryPackProxy) { }
        // RVA: 0x0576EB68  token: 0x600002E
        public static Beyond.IMemoryPackProxy GetMemoryPackProxy() { }
        // RVA: 0x0350B670  token: 0x600002F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x18
    public class GameInitState : Beyond.GameStateBase
    {
        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000031
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x03157630  token: 0x6000032
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x02EAA390  token: 0x6000033
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x03157720  token: 0x6000034
        private System.Collections.IEnumerator _DoInit() { }
        // RVA: 0x0315ACC0  token: 0x6000035
        private System.Void _InitInitialResourceManager(Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator) { }
        // RVA: 0x02955380  token: 0x6000036
        private System.Boolean _CheckIfLocalInitialAssetsValid(Beyond.Resource.HotUpdate.LocalResPref& outputLocalResPref, Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator) { }
        // RVA: 0x0307F820  token: 0x6000037
        private System.Void _InitAPPDefaultCulture() { }
        // RVA: 0x02AB7540  token: 0x6000038
        private System.Void _InitGameSetting() { }
        // RVA: 0x0576CFD8  token: 0x6000039
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        // RVA: 0x0576CFE0  token: 0x600003A
        public System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public class GameLoginState : Beyond.GameStateBase
    {
        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x03D55730 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000042
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x03157790  token: 0x6000043
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x03102F10  token: 0x6000044
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x02C3E7E0  token: 0x6000045
        private static System.Void _TryStartLoginWorkflow() { }
        // RVA: 0x0576CFD8  token: 0x6000046
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        // RVA: 0x0576CFE0  token: 0x6000047
        public System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000C  // size: 0x20
    public class GameMainState : Beyond.GameStateBase
    {
        // Fields
        private System.Boolean m_isFirstEnter;  // 0x18

        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x03D55740 */ }

        // Methods
        // RVA: 0x042759A8  token: 0x6000049
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x02EA8690  token: 0x600004A
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x03D22EE0  token: 0x600004B
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x03102F90  token: 0x600004C
        public static System.Void ReleaseMainGame(Beyond.GameState toStateId) { }
        // RVA: 0x042753D4  token: 0x600004D
        private static System.Void _ClearUtils() { }
        // RVA: 0x0576CFD8  token: 0x600004E
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        // RVA: 0x0576CFE0  token: 0x600004F
        public System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000D  // size: 0x20
    public class GamePreloadState : Beyond.GameStateBase
    {
        // Fields
        private Beyond.Cfg.Tables.AsyncLoadTask m_asyncTask;  // 0x18

        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x03D55750 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000051
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x03B41720  token: 0x6000052
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x03CF3610  token: 0x6000053
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x03B417C0  token: 0x6000054
        private System.Collections.IEnumerator _DoPreload() { }
        // RVA: 0x02AB7DC0  token: 0x6000055
        private System.Void _InitGameSettingStateInPreload() { }
        // RVA: 0x0576CFD8  token: 0x6000056
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        // RVA: 0x0576CFE0  token: 0x6000057
        public System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000F  // size: 0x18
    public class GameQuitState : Beyond.GameStateBase
    {
        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x03D55760 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x600005F
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x0576D424  token: 0x6000060
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x0576D48C  token: 0x6000061
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x0576CFE8  token: 0x6000062
        public static System.Void DoQuit() { }
        // RVA: 0x0576CFD8  token: 0x6000063
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        // RVA: 0x0576CFE0  token: 0x6000064
        public System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public class GameSoftRestartState : Beyond.GameStateBase
    {
        // Fields
        private static System.String CLEAR_SCENE_PATH;  // const

        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x03D51100 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000066
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x0576D4F0  token: 0x6000067
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x0576D5A8  token: 0x6000068
        private System.Collections.IEnumerator _SoftRestart() { }
        // RVA: 0x0576CFD8  token: 0x6000069
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }

    }

    // TypeToken: 0x2000012  // size: 0x18
    public class GameStartState : Beyond.GameStateBase
    {
        // Properties
        Beyond.GameState stateId { get; /* RVA: 0x03D55770 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000071
        public System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x03B0DAE0  token: 0x6000072
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x03B6EA40  token: 0x6000073
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x03B46620  token: 0x6000074
        private System.Void _OnEnterMainGame() { }
        // RVA: 0x02C35D20  token: 0x6000075
        private System.Void <_OnEnterMainGame>b__5_0() { }
        // RVA: 0x0576CFD8  token: 0x6000076
        public System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        // RVA: 0x0576CFE0  token: 0x6000077
        public System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x2000013  // size: 0x18
    public abstract class GameStateBase : Beyond.Gameplay.ISimpleStateNode`1, Beyond.ILuaCallCSharp
    {
        // Fields
        protected readonly Beyond.GameStateMachine m_stateMachine;  // 0x10

        // Properties
        Beyond.GameState stateId { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000078
        protected System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        // RVA: 0x02C384A0  token: 0x600007A
        public virtual System.Void OnEnter(Beyond.GameState fromStateId) { }
        // RVA: 0x02C38530  token: 0x600007B
        public virtual System.Void OnLeave(Beyond.GameState toStateId) { }
        // RVA: 0x0576D638  token: 0x600007C
        public virtual System.Void OnTick(System.Single deltaTime) { }

    }

    // TypeToken: 0x2000014  // size: 0x38
    public class GameStateMachine : Beyond.Gameplay.SimpleEnumStateMachine`1, Beyond.IGameStateMachine, Beyond.ILuaCallCSharp
    {
        // Fields
        private readonly Beyond.GameApp <app>k__BackingField;  // 0x30

        // Properties
        Beyond.GameApp app { get; /* RVA: 0x01003830 */ }
        Beyond.GameState curState { get; /* RVA: 0x02DEEA70 */ }

        // Methods
        // RVA: 0x03157490  token: 0x600007F
        public System.Void .ctor(Beyond.GameApp gameApp) { }
        // RVA: 0x03156C80  token: 0x6000080
        private System.Void _RegisterStates() { }
        // RVA: 0x02C35000  token: 0x6000081
        public virtual System.Boolean CheckCanReturnToLoginState() { }
        // RVA: 0x03C94800  token: 0x6000082
        public virtual System.Collections.IEnumerator ReturnToLoginState() { }

    }

    // TypeToken: 0x2000016  // size: 0x10
    public static class GlobalInitializer
    {
        // Methods
        // RVA: 0x03D4C3A0  token: 0x6000089
        public static System.Void InitGlobalConfig() { }

    }

    // TypeToken: 0x2000017
    public interface IHotFixCommon
    {
    }

    // TypeToken: 0x2000018
    public interface IHotFixPatchManagerProxy : Beyond.IHotFixCommon
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600008A
        public virtual System.Void InitManager() { }
        // RVA: -1  // abstract  token: 0x600008B
        public virtual System.Void ReleaseManager() { }
        // RVA: -1  // abstract  token: 0x600008C
        public virtual System.Void PatchInitAssemble() { }
        // RVA: -1  // abstract  token: 0x600008D
        public virtual System.Void PatchRemoteInitAssemble() { }
        // RVA: -1  // abstract  token: 0x600008E
        public virtual System.Void PatchRemoteInjectedLua() { }
        // RVA: -1  // abstract  token: 0x600008F
        public virtual System.Void PatchMainAssemble() { }
        // RVA: -1  // abstract  token: 0x6000090
        public virtual System.Void PatchRemoteMainAssemble() { }

    }

    // TypeToken: 0x2000019  // size: 0x10
    public class HotFixPatchModules
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,Beyond.IHotFixCommon> s_hotFixModules;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000091
        public static System.Void Register(T module) { }
        // RVA: -1  // generic def  token: 0x6000092
        public static System.Void UnRegister() { }
        // RVA: -1  // generic def  token: 0x6000093
        public static T GetModule() { }
        // RVA: 0x0350B670  token: 0x6000094
        public System.Void .ctor() { }
        // RVA: 0x03CE4090  token: 0x6000095
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x10
    public static class InitialPathDef
    {
        // Fields
        public static System.String LOGIN_SCENE_PATH;  // const
        public static System.String LOGIN_SK_ACTOR_M;  // const
        public static System.String LOGIN_SK_ACTOR_F;  // const
        public static System.String LOGIN_SK_ACTOR_NO_GENDER;  // const
        public static System.String LOGIN_MOCK_UID_PANEL;  // const
        public static System.String LOGIN_CONTROLLER_PATH;  // const
        public static System.String LOGIN_ROOT_PANEL_PATH;  // const
        public static System.String LOGIN_ALERT_DIALOG_PATH;  // const
        public static System.String LOGIN_JUDGE_DIALOG_PATH;  // const
        public static System.String LOGIN_VOC_RES_SELECT_DIALOG_PATH;  // const

    }

    // TypeToken: 0x200001B  // size: 0xC0
    public class LoginController : UnityEngine.MonoBehaviour, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private UnityEngine.Transform _uiFunc;  // 0x18
        private UnityEngine.Transform _uiDialog;  // 0x20
        private Beyond.UI.UIButton _versionBtn;  // 0x28
        private Beyond.Login.LoginDecorateUI _uiDecorate;  // 0x30
        private Beyond.LoginController.MaskCfg _maskBlur;  // 0x38
        private Beyond.LoginController.MaskCfg _maskBlack;  // 0x40
        private Beyond.LoginController.MaskCfg _maskWhite;  // 0x48
        private System.Single _enterGamePanelPredelay;  // 0x50
        private UnityEngine.Canvas _uiRootCanvas;  // 0x58
        private Beyond.UI.UICanvasScaleHelper _uiRootCanvasScaleHelper;  // 0x60
        private UnityEngine.Canvas _uiDecoCanvas;  // 0x68
        private Beyond.UI.UICanvasScaleHelper _uiDecoCanvasScaleHelper;  // 0x70
        private System.Boolean m_isInited;  // 0x78
        private Beyond.LoginController.FOptions m_options;  // 0x80
        private Beyond.LatchUtils.InvokeWhenUnlock m_startLatch;  // 0x88
        private Beyond.LatchUtils.InvokeWhenUnlock m_initLatch;  // 0x90
        private Beyond.Login.LoginWorkFlow.ENode m_lastNode;  // 0x98
        private Beyond.LoginController.MaskCtrl m_maskCtrl;  // 0xa0
        private Beyond.Login.LoginRootPanel m_rootPanel;  // 0xa8
        private System.Collections.IEnumerator m_mockLoginRoutine;  // 0xb0
        private System.Action<System.String> m_onMockLogin;  // 0xb8

        // Properties
        Beyond.LoginController.MaskCtrl maskCtrl { get; /* RVA: 0x02EA9AB0 */ }
        Beyond.Login.LoginRootPanel rootPanel { get; /* RVA: 0x03D4EB10 */ }

        // Events
        event System.Action<System.String> m_onMockLogin;

        // Methods
        // RVA: 0x03CF9140  token: 0x6000098
        protected System.Void Awake() { }
        // RVA: 0x03D2A520  token: 0x6000099
        protected System.Void Start() { }
        // RVA: 0x02EA9B50  token: 0x600009A
        public System.Single GetEnterGamePanelPredelay() { }
        // RVA: 0x02C3B440  token: 0x600009B
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel viewModel) { }
        // RVA: 0x02EA8DE0  token: 0x600009C
        public System.Void InitUI(Beyond.LoginController.FOptions options) { }
        // RVA: 0x028D52F0  token: 0x600009D
        public System.Void InvokeWhenStart(System.Action callback) { }
        // RVA: 0x03A24780  token: 0x600009E
        public System.Collections.IEnumerator BeforeDestroy() { }
        // RVA: -1  // generic def  token: 0x600009F
        private System.Collections.IEnumerator _InstantiateUIFromRes(System.String resPath, UnityEngine.Transform parent, Beyond.Misc.ObjectRef objRef) { }
        // RVA: 0x03C86380  token: 0x60000A0
        private System.Void _InitImpl() { }
        // RVA: 0x03C863D0  token: 0x60000A1
        private System.Collections.IEnumerator _InitCoroutine() { }
        // RVA: 0x02EA9E00  token: 0x60000A2
        private System.Void _InitVersionBtn() { }
        // RVA: 0x02EAA8A0  token: 0x60000A5
        public System.Void MockLoginWithCallback(System.String fixedUID, System.Action<System.String> callback) { }
        // RVA: 0x02EAA9A0  token: 0x60000A6
        private System.Collections.IEnumerator _MockLoginCoroutine(System.String fixedUID) { }
        // RVA: 0x039BB5F0  token: 0x60000A7
        public System.Void .ctor() { }
        // RVA: 0x03D4D200  token: 0x60000A8
        private System.Void <MockLoginWithCallback>b__44_0() { }

    }

    // TypeToken: 0x200002B  // size: 0x58
    public class LoginContext : System.IDisposable
    {
        // Fields
        private Beyond.LoginController m_controller;  // 0x10
        private System.Boolean m_isDisposed;  // 0x18
        private System.Boolean <quickStart>k__BackingField;  // 0x19
        private System.Boolean <firstLogin>k__BackingField;  // 0x1a
        private Beyond.Login.LoginWorkFlow <workflow>k__BackingField;  // 0x20
        private Beyond.Login.LoginViewProperty <viewProp>k__BackingField;  // 0x28
        private Beyond.LoginManager.AssetLoader <loader>k__BackingField;  // 0x30
        private Beyond.LoginManager.FlowWithMaskMgr <flowWithMask>k__BackingField;  // 0x38
        private Beyond.Login.NetUsagePolicy <netUsagePolicy>k__BackingField;  // 0x40
        private Beyond.Login.LoginGameUpdater <gameUpdater>k__BackingField;  // 0x48
        private System.Boolean <startConnectServer>k__BackingField;  // 0x50

        // Properties
        System.Boolean quickStart { get; /* RVA: 0x03D4EF80 */ set; /* RVA: 0x03D4EFB0 */ }
        System.Boolean firstLogin { get; /* RVA: 0x03D4EFA0 */ set; /* RVA: 0x03D4EFD0 */ }
        Beyond.Login.LoginWorkFlow workflow { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        Beyond.Login.LoginViewProperty viewProp { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        Beyond.LoginManager.AssetLoader loader { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        Beyond.LoginManager.FlowWithMaskMgr flowWithMask { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        Beyond.Login.NetUsagePolicy netUsagePolicy { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        Beyond.Login.LoginGameUpdater gameUpdater { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        System.Boolean startConnectServer { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }

        // Methods
        // RVA: 0x02EA9A10  token: 0x60000FC
        public Beyond.LoginController ViewOnlyController() { }
        // RVA: 0x028D4BE0  token: 0x60000FD
        public System.Void Init(System.Boolean quickStart, Beyond.LoginController controller, Beyond.Login.LoginWorkFlow workflow, Beyond.Login.LoginViewProperty viewProp, Beyond.LoginManager.AssetLoader loader, Beyond.LoginManager.FlowWithMaskMgr flowWithMask, Beyond.Login.NetUsagePolicy netUsagePolicy, Beyond.Login.LoginGameUpdater gameUpdater) { }
        // RVA: 0x02D77950  token: 0x60000FE
        public System.Void StartCoroutine(System.Collections.IEnumerator routine) { }
        // RVA: 0x0576D880  token: 0x60000FF
        public System.Void StopCoroutine(System.Collections.IEnumerator routine) { }
        // RVA: 0x0576D72C  token: 0x6000100
        public System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param) { }
        // RVA: 0x02EAAB50  token: 0x6000101
        public virtual System.Void Dispose() { }
        // RVA: 0x0576D7AC  token: 0x6000102
        public System.Void ShutDown() { }
        // RVA: 0x0576D6D8  token: 0x6000103
        public System.Boolean IsWorkflowDisposed() { }
        // RVA: 0x0576D68C  token: 0x6000104
        public System.Boolean IsDisposed() { }
        // RVA: 0x028D4CC0  token: 0x6000105
        private System.Void _DisposeImpl() { }
        // RVA: 0x02EAAC70  token: 0x6000106
        private static System.Collections.IEnumerator _DisposeCoroutine(Beyond.LoginController legacyController, System.Action disposeAction) { }
        // RVA: 0x0350B670  token: 0x6000107
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x14
    public sealed struct ELoginEvent
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.ELoginEvent None;  // const
        public static Beyond.ELoginEvent V2C_U8Login;  // const
        public static Beyond.ELoginEvent V2C_EnterGame;  // const
        public static Beyond.ELoginEvent V2C_Logout;  // const
        public static Beyond.ELoginEvent V2C_ResourceRepair;  // const
        public static Beyond.ELoginEvent V2C_OpenAgeTips;  // const
        public static Beyond.ELoginEvent V2C_CloseAgeTips;  // const
        public static Beyond.ELoginEvent V2C_OpenServerSelect;  // const
        public static Beyond.ELoginEvent V2C_CloseServerSelect;  // const
        public static Beyond.ELoginEvent V2C_SelectServer;  // const
        public static Beyond.ELoginEvent V2C_ConfirmServer;  // const
        public static Beyond.ELoginEvent V2C_Relogin;  // const
        public static Beyond.ELoginEvent V2C_ReplayGsLogin;  // const
        public static Beyond.ELoginEvent C2V_PrepareGsLogin;  // const

    }

    // TypeToken: 0x200002E  // size: 0x10
    public static class LoginTextDefines
    {
        // Fields
        public static System.String CS_LOGIN_CONN_FAIL;  // const
        public static System.String HOTUPDATE_INDEX_FAILED;  // const
        public static System.String HOTUPDATE_IO_FAILED;  // const
        public static System.String HOTUPDATE_CHECK_VERSION;  // const
        public static System.String HOTUPDATE_DOWNLOADING;  // const
        public static System.String HOTUPDATE_DECOMPRESSING;  // const
        public static System.String HOTUPDATE_DOWNLOAD_ERROR;  // const
        public static System.String HOTUPDATE_DOWNLOAD_DISKFULL;  // const
        public static System.String HOTUPDATE_LOCAL_RES_CHECK;  // const
        public static System.String HOTUPDATE_PRELOAD_RES;  // const
        public static System.String HOTUPDATE_INVALID_LOCAL_FILES;  // const
        public static System.String HOTUPDATE_INIT_RES_CHANGED;  // const
        public static System.String HOTUPDATE_DOWNLOAD_IO_ERROR;  // const
        public static System.String HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR;  // const
        public static System.String HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR;  // const
        public static System.String HOTUPDATE_DECOMPRESS_ERROR;  // const
        public static System.String REMOTE_CFG_GAME_CFG_ERROR;  // const
        public static System.String REMOTE_CFG_GAME_CFG_TIMEOUT;  // const
        public static System.String REMOTE_CFG_NETWORK_CFG_ERROR;  // const
        public static System.String REMOTE_CFG_NETWORK_CFG_TIMEOUT;  // const
        public static System.String REMOTE_CFG_RES_VERSION_ERROR;  // const
        public static System.String REMOTE_CFG_RES_VERSION_TIMEOUT;  // const
        public static System.String REMOTE_CFG_GAME_VERSION_ERROR;  // const
        public static System.String REMOTE_CFG_GAME_VERSION_TIMEOUT;  // const
        public static System.String LOGIN_JUDGE_EXIT_GAME;  // const
        public static System.String LOGIN_JUDGE_LOGOUT;  // const
        public static System.String LOGIN_JUDGE_RES_REPAIR;  // const
        public static System.String LOGIN_AGE_TIPS_FAILED;  // const
        public static System.String LOGIN_TXT_DIALOG_CONFIRM;  // const
        public static System.String LOGIN_TXT_DIALOG_CANCEL;  // const
        public static System.String LOGIN_AUDIO_LANG_CN;  // const
        public static System.String LOGIN_AUDIO_LANG_JP;  // const
        public static System.String LOGIN_AUDIO_LANG_EN;  // const
        public static System.String LOGIN_AUDIO_LANG_KR;  // const
        public static System.String LOGIN_TXT_NETWORK_ERROR;  // const
        public static System.String LOGIN_GAME_UPGRADED;  // const
        public static System.String LOGIN_TXT_SERVER_CLOSED;  // const
        public static System.String LOGIN_TXT_SERVER_CLOSED_DATETIME;  // const
        public static System.String LOGIN_TXT_USR_BAN_DATETIME;  // const
        public static System.String LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER;  // const
        public static System.String LOGIN_GET_SERVER_LIST_FAILED;  // const
        public static System.String LOGIN_TEXT_SERVER_ZONE_FAILED;  // const
        public static System.String LOGIN_TEXT_GET_APP_VERSION_FAILED;  // const
        public static System.String LOGIN_TEXT_ALERT_CARRIER_NETWORK;  // const
        public static System.String LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED;  // const
        public static System.String LOGIN_SHADER_WARM_UP_PRELOAD_RES;  // const
        public static System.String LOGIN_GAME_UPDATE_TIPS_DOWNLOADING;  // const
        public static System.String LOGIN_GAME_UPDATE_TIPS_PAUSE;  // const
        public static System.String LOGIN_GAME_UPDATE_ALERT_NEWER;  // const
        public static System.String LOGIN_GAME_UPDATE_ERROR_DISK_FULL;  // const
        public static System.String LOGIN_GAME_UPDATE_ALERT_SUC;  // const
        public static System.String LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON;  // const
        public static System.String LOGIN_GAME_UPDATE_ERROR_COMMON;  // const
        public static System.String LOGIN_GAME_UPDATE_TITLE;  // const
        public static System.String LOGIN_GOTO_SHOP_FOR_GAME_UPDATE;  // const
        public static System.String LOGIN_SDK_INIT_FAILED;  // const
        public static System.String LOGIN_DOWNLOADING_SPEED_HINT;  // const
        public static System.String LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME;  // const
        public static System.String LOGIN_NETWORK_CONGESTION_TITLE;  // const
        public static System.String LOGIN_LOW_SCORE_DEVICE_TIP;  // const
        public static System.String LOGIN_REGISTRY_WRITE_FAILED;  // const

    }

    // TypeToken: 0x200002F  // size: 0x50
    public class LoginManager : Beyond.ExplicitSingleton`1
    {
        // Fields
        public static System.Int64 MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI;  // const
        private Beyond.Resource.ISceneHandle m_sceneHandle;  // 0x10
        private Beyond.LoginContext m_context;  // 0x18
        private Beyond.LatchUtils.InvokeWhenUnlock m_workflowFinishLatch;  // 0x20
        private Beyond.LatchUtils.InvokeWhenUnlock m_workflowStartLatch;  // 0x28
        private System.Collections.Generic.Queue<System.WeakReference<Beyond.Login.LoginSceneComponent>> m_pendingSceneComps;  // 0x30
        private System.Collections.Generic.HashSet<Beyond.Login.LoginSceneComponent> m_sceneComps;  // 0x38
        private System.Boolean <quickStart>k__BackingField;  // 0x40
        private System.Object m_dialogBlocker;  // 0x48

        // Properties
        System.Boolean quickStart { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }
        System.Boolean firstLogin { get; /* RVA: 0x0576E81C */ }

        // Methods
        // RVA: 0x03CC4260  token: 0x6000111
        public System.Collections.IEnumerator InitCoroutine(System.Boolean quickStart) { }
        // RVA: 0x0576DF5C  token: 0x6000112
        public System.Boolean IsReLoginInProgress() { }
        // RVA: 0x04275714  token: 0x6000113
        public static System.Void OnReleaseMainGame() { }
        // RVA: 0x03D42930  token: 0x6000114
        public System.Boolean IsWorkflowInProgress() { }
        // RVA: 0x0576DC74  token: 0x6000115
        public System.Void ClearSync() { }
        // RVA: 0x02EA8790  token: 0x6000116
        public System.Void Clear() { }
        // RVA: 0x02EA8340  token: 0x6000117
        private System.Void _ReleaseLoginScene() { }
        // RVA: 0x03B466E0  token: 0x6000118
        public System.Void InvokeWhenWorkFlowFinished(System.Action callback) { }
        // RVA: 0x02C3CFE0  token: 0x6000119
        public System.Void SceneComponentOnly_Bind(Beyond.Login.LoginSceneComponent comp) { }
        // RVA: 0x02EA9860  token: 0x600011A
        private System.Void _BindPendingComponents() { }
        // RVA: 0x0576E360  token: 0x600011B
        public System.Void ToggleLoginBindingGroup(System.Boolean enable) { }
        // RVA: 0x0576DA8C  token: 0x600011C
        public System.Void AlertDialog(System.String desc, System.Action callback) { }
        // RVA: 0x0576E4B4  token: 0x600011D
        public System.Void VocResSelDialog(System.Action callback) { }
        // RVA: 0x0576E424  token: 0x600011E
        public System.Collections.IEnumerator VocResSelDialogWithConfirm() { }
        // RVA: 0x0576D9A4  token: 0x600011F
        public System.Collections.IEnumerator AlertDialogWithResult(System.String desc, Beyond.Misc.ObjectRef outRef, System.Action<Beyond.Misc.ObjectRef> callback) { }
        // RVA: 0x0576D8FC  token: 0x6000120
        public System.Collections.IEnumerator AlertDialogWithConfirm(System.String desc) { }
        // RVA: 0x0576E110  token: 0x6000121
        public System.Void JudgeDialog(System.String desc, System.Action onPositive, System.Action onNegative) { }
        // RVA: 0x0576E074  token: 0x6000122
        public System.Void JudgeDialog(Beyond.Login.LoginJudgeDialog.FParams param) { }
        // RVA: 0x0576E654  token: 0x6000123
        private System.Void _StartShowJudgeDialogCoroutine(Beyond.Login.LoginJudgeDialog.FParams param) { }
        // RVA: -1  // generic def  token: 0x6000124
        private System.Collections.IEnumerator _ShowDialogCoroutine(System.String resPath, TParam param, System.Action<TDialog,TParam> setParamFunc) { }
        // RVA: 0x02EA9500  token: 0x6000125
        public System.Void MockLoginWithCallback(System.Action<System.String> callback) { }
        // RVA: 0x0576E200  token: 0x6000126
        public System.Void MockManualSelectServer(System.String uid, System.Action callback) { }
        // RVA: 0x028D5370  token: 0x6000127
        private System.Void _Init() { }
        // RVA: 0x02C3CED0  token: 0x6000128
        public System.Boolean IsLoginSceneLoading() { }
        // RVA: 0x028D4E50  token: 0x6000129
        private System.Void _PrepareBeforeLoginProcess() { }
        // RVA: 0x03C7DAA0  token: 0x600012A
        private System.Collections.IEnumerator _LoginWorkFlowCoroutine(Beyond.LoginController nullableCtrl) { }
        // RVA: 0x02EA8D10  token: 0x600012B
        private System.Void _ClearWorkflowAndContext(System.Boolean isShutDownMode) { }
        // RVA: 0x0315A7B0  token: 0x600012C
        public static System.Collections.IEnumerator FetchRemoteConfigUtilSuc(Beyond.Cfg.IRemoteConfig config, System.String configEnv, System.String keyErrorWithCode, System.String keyTimeout) { }
        // RVA: 0x02C36F20  token: 0x600012D
        private static System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout) { }
        // RVA: 0x0576DCD4  token: 0x600012E
        public static System.Void DevOnlyCheckEnableLocalResMode(System.Boolean& enable) { }
        // RVA: 0x0576DD54  token: 0x600012F
        public static System.Void DevOnlyUseLocalResVersion(Beyond.Cfg.ResVersionDevCfg config, System.Boolean& useLocalResVersion) { }
        // RVA: 0x03A93590  token: 0x6000130
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x18
    public class VietnamLoginAgePanel : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.String PREFAB_PATH;  // const
        private static Beyond.Resource.FAssetProxyHandle s_prefabAssetHandle;  // static @ 0x0
        public static UnityEngine.GameObject instance;  // static @ 0x18

        // Methods
        // RVA: 0x02EA8AA0  token: 0x6000180
        public static System.Void Init() { }
        // RVA: 0x057718A8  token: 0x6000181
        public static System.Void UnInit() { }
        // RVA: 0x05771920  token: 0x6000182
        private static System.Void _Init() { }
        // RVA: 0x05771BA8  token: 0x6000183
        private static System.Void _UnInit() { }
        // RVA: 0x057717BC  token: 0x6000184
        private System.Void OnApplicationQuit() { }
        // RVA: 0x0426FE60  token: 0x6000185
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x38
    public class VietnamLoginAgeTipsPanelCtrl : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIDrag _UIDrag;  // 0x18
        private Beyond.UI.UIButton _tipsBtn;  // 0x20
        private Beyond.UI.UIButton _circleBtn;  // 0x28
        private Beyond.UI.UIState.UIStateController _stateController;  // 0x30

        // Methods
        // RVA: 0x05771C7C  token: 0x6000186
        public System.Void Awake() { }
        // RVA: 0x05771F54  token: 0x6000187
        private System.Void _SetStateTips(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x05771EB8  token: 0x6000188
        private System.Void _SetStateCircle(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0426FE60  token: 0x6000189
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x10
    public static class RenderPipelineDataLoader
    {
        // Fields
        public static Beyond.Resource.FAssetProxyHandle s_globalSettings;  // static @ 0x0
        public static Beyond.Resource.FAssetProxyHandle s_pipelineAsset;  // static @ 0x14

        // Methods
        // RVA: 0x02EAA430  token: 0x600018A
        public static System.Void LoadSimpleRpData() { }
        // RVA: 0x031578A0  token: 0x600018B
        public static System.Void PreloadFullRpResources() { }
        // RVA: 0x02C38320  token: 0x600018C
        public static System.Boolean IsPreLoadFinished() { }
        // RVA: 0x02EAA600  token: 0x600018D
        public static System.Void LoadFullRpResources() { }

    }

    // TypeToken: 0x2000045  // size: 0x18
    public class TailGameLoop : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x02F88BB0  token: 0x600018E
        private System.Void Update() { }
        // RVA: 0x02E69680  token: 0x600018F
        private System.Void LateUpdate() { }
        // RVA: 0x0426FE60  token: 0x6000190
        public System.Void .ctor() { }

    }

}

namespace Beyond.Login
{

    // TypeToken: 0x2000068  // size: 0x30
    public class LoginCheckForUpdateNode : Node
    {
        // Fields
        private Beyond.Login.LoginGameUpdater m_sdk;  // 0x20
        private System.Boolean m_checkSuccess;  // 0x28
        private static System.String REQUEST_API;  // const
        private static System.String REQUEST_PARAM_FORMAT;  // const
        private static System.String REQUEST_URL_FORMAT;  // const
        private static System.String PRAM_SOURCE;  // const

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x01168950 */ }

        // Methods
        // RVA: 0x036BC910  token: 0x6000213
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x036BCA10  token: 0x6000214
        private System.Collections.IEnumerator _CheckForUpdateCoroutine() { }
        // RVA: 0x03D02BC0  token: 0x6000215
        public static System.Collections.IEnumerator AlertNoMatchDeviceBeforeLogin() { }
        // RVA: 0x05773218  token: 0x6000216
        private System.Collections.IEnumerator _CheckForUpdateCoroutineMobile() { }
        // RVA: 0x03CEFE20  token: 0x6000217
        private System.Collections.IEnumerator _CheckForUpdateCoroutinePC() { }
        // RVA: 0x03B29910  token: 0x6000218
        private System.Collections.IEnumerator _CheckForUpdatePC() { }
        // RVA: 0x03922450  token: 0x6000219
        private System.Collections.IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef) { }
        // RVA: 0x0229CC40  token: 0x600021A
        private System.String _GetRequestPram() { }
        // RVA: 0x0350B670  token: 0x600021B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x28
    public class LoginCreateRoleNode : Node
    {
        // Fields
        public static System.String LUA_SYS_NAME;  // const
        private Beyond.Login.LoginCreateRoleNode.WorkProcess m_activeProcess;  // 0x20

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D557A0 */ }

        // Methods
        // RVA: 0x0379F750  token: 0x6000242
        public virtual System.Void OnDispose() { }
        // RVA: 0x057732A8  token: 0x6000243
        public virtual System.Boolean CanCancel() { }
        // RVA: 0x03C9BCF0  token: 0x6000244
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x0350B670  token: 0x6000245
        public System.Void .ctor() { }
        // RVA: 0x057732FC  token: 0x6000246
        public System.Void <>iFixBaseProxy_OnDispose() { }
        // RVA: 0x057732F4  token: 0x6000247
        public System.Boolean <>iFixBaseProxy_CanCancel() { }

    }

    // TypeToken: 0x2000072  // size: 0x90
    public class LoginDownloadTask : System.IDisposable
    {
        // Fields
        private System.Boolean m_isDownloadFinished;  // 0x10
        private Beyond.SDK.HGDownloader.TaskHandler m_downloadTask;  // 0x18
        private Beyond.Resource.HotUpdate.FResourceDiff m_resDiff;  // 0x20
        private Beyond.Resource.HotUpdate.LocalResPref m_localResPref;  // 0x60
        private System.String m_patchInfo;  // 0x68
        private System.Collections.IEnumerator m_mockCoroutine;  // 0x70
        private System.Boolean m_isInitial;  // 0x78
        private System.String <vitalError>k__BackingField;  // 0x80
        private Beyond.Login.NetUsagePolicy m_netUsagePolicy;  // 0x88

        // Properties
        System.String vitalError { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }

        // Methods
        // RVA: 0x010393E0  token: 0x600024B
        public System.Void .ctor(Beyond.Resource.HotUpdate.FResourceDiff resDiff, Beyond.Resource.HotUpdate.LocalResPref localResPref, System.String patchInfo, System.Boolean isInitial, Beyond.Login.NetUsagePolicy netUsagePolicy) { }
        // RVA: 0x057733F4  token: 0x600024E
        public Beyond.SDK.HGDownloader.DownloadProgress GetDownloadProgress() { }
        // RVA: 0x05773390  token: 0x600024F
        public System.Single GetDecompressProgress() { }
        // RVA: 0x0577348C  token: 0x6000250
        public Beyond.SDK.HGDownloader.WorkState GetWorkState() { }
        // RVA: 0x057734EC  token: 0x6000251
        public System.Boolean Tick() { }
        // RVA: 0x05773304  token: 0x6000252
        public virtual System.Void Dispose() { }
        // RVA: 0x057740DC  token: 0x6000253
        private System.Void _StartDownload() { }
        // RVA: 0x05773C68  token: 0x6000254
        private System.Void _StartDownloadImpl() { }
        // RVA: 0x01037210  token: 0x6000255
        private System.Collections.Generic.List<Beyond.SDK.HGFolder> _GetAllFileList(Beyond.Resource.HotUpdate.LocalResPref localResPref) { }
        // RVA: 0x05773558  token: 0x6000256
        private System.Collections.Generic.List<Beyond.SDK.HGFileInfo> _GetFileList(System.String rootUrl) { }
        // RVA: 0x057739B4  token: 0x6000257
        private System.Void _OnDownloadFinish() { }
        // RVA: 0x05773798  token: 0x6000258
        private System.Boolean _OnDownloadError(Beyond.SDK.HGRetCodeType codeType, System.Int32 errorCode) { }
        // RVA: 0x05773A04  token: 0x6000259
        private System.Void _OnDownloadPaused(Beyond.SDK.HGDownloader.PauseReason reason) { }

    }

    // TypeToken: 0x2000075  // size: 0x28
    public class LoginGameSettingInitializer : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.Boolean s_isInitialized;  // static @ 0x0
        private UnityEngine.RectTransform m_rectTransform;  // 0x18
        private Beyond.UI.UICanvasScaleHelper m_canvasScaleHelper;  // 0x20

        // Methods
        // RVA: 0x0398C690  token: 0x600025F
        private System.Void Awake() { }
        // RVA: 0x0398C6F0  token: 0x6000260
        private System.Void OnEnable() { }
        // RVA: 0x0398C7F0  token: 0x6000261
        private System.Void _TryInitializeComponents() { }
        // RVA: 0x0398C770  token: 0x6000262
        private System.Void _InitGameSettingStateInLogin() { }
        // RVA: 0x02E3B510  token: 0x6000263
        private System.Void _InitGameSettingNotchPadding() { }
        // RVA: 0x0426FE60  token: 0x6000264
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000076  // size: 0x30
    public class LoginGameUpdateNode : Node
    {
        // Fields
        private Beyond.Login.LoginGameUpdater m_sdk;  // 0x20
        private Beyond.Login.NetUsagePolicy m_netUsagePolicy;  // 0x28

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D555E0 */ }

        // Methods
        // RVA: 0x036BCA80  token: 0x6000266
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x036BCB90  token: 0x6000267
        private System.Collections.IEnumerator _GameUpdateCoroutine() { }
        // RVA: 0x05774B44  token: 0x6000268
        private System.Collections.IEnumerator _GameUpdateCoroutineMobileImpl() { }
        // RVA: 0x0350B670  token: 0x6000269
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x50
    public class LoginGameUpdater
    {
        // Fields
        private static System.Single COOLDOWN_INSTALL;  // const
        private static System.Int32 ERROR_CODE_NETWORK;  // const
        private static System.Int32 ERROR_INIT_FAILED;  // const
        private static System.Int32 ERROR_DESERIALIZE_FAILED;  // const
        public static System.Int32 ERROR_ACTION;  // const
        private static System.Int32 WAIT_TIME_SECONDS_MIN;  // const
        private static System.Int32 WAIT_TIME_SECONDS_MAX;  // const
        private Beyond.Login.LoginGameUpdater.Options m_options;  // 0x10
        private Beyond.SDK.IGameUpdateInterface m_sdkImpl;  // 0x28
        private System.Boolean m_hasUpdateAlerted;  // 0x30
        private Beyond.Login.LoginGameUpdater.Context m_context;  // 0x38
        private Beyond.Login.LoginProgress m_progress;  // 0x40
        private Beyond.Login.LoginHotUpdateProp m_hotUpdateProp;  // 0x48

        // Methods
        // RVA: 0x036BD0C0  token: 0x6000276
        public System.Void Clear() { }
        // RVA: 0x028D4D20  token: 0x6000277
        public System.Void .ctor(Beyond.Login.LoginGameUpdater.Options options) { }
        // RVA: 0x05774BD4  token: 0x6000278
        public System.Collections.IEnumerator CheckLastGameInfo(Beyond.Login.LoginGameUpdater.Result result) { }
        // RVA: 0x05774C7C  token: 0x6000279
        public System.Collections.IEnumerator DoUpdate(Beyond.Login.LoginGameUpdater.Result result) { }
        // RVA: 0x05775120  token: 0x600027A
        private System.Collections.IEnumerator _GetLastGameInfo(Beyond.Login.LoginGameUpdater.Context context) { }
        // RVA: 0x05775410  token: 0x600027B
        private System.Collections.IEnumerator _UpdateGame(Beyond.Login.LoginGameUpdater.Context context) { }
        // RVA: 0x05775078  token: 0x600027C
        private System.Collections.IEnumerator _DoTaskUpdating(Beyond.Login.LoginGameUpdater.Context context) { }
        // RVA: 0x057752C8  token: 0x600027D
        private System.Void _OnDownloadStart() { }
        // RVA: 0x057751C8  token: 0x600027E
        private System.Void _OnDownloadProgress(System.Int64 curSize, System.Int64 totalSize, System.Int64 speed) { }
        // RVA: 0x057755F8  token: 0x600027F
        private System.Collections.IEnumerator _YieldErrorAlert(System.String desc) { }
        // RVA: 0x05775558  token: 0x6000280
        private System.Collections.IEnumerator _YieldCheckNetUsagePolicy(System.Int64 downloadSize) { }
        // RVA: 0x057754B8  token: 0x6000281
        private System.Collections.IEnumerator _WaitForTaskCancel(System.Int64 taskId) { }
        // RVA: 0x0577500C  token: 0x6000282
        private static System.Void _CreateDirectoryIfNotExists(System.String folderPath) { }
        // RVA: 0x028D47D0  token: 0x6000283
        public System.Void ClearWaitProgress() { }
        // RVA: 0x05774EC8  token: 0x6000284
        public System.Void ShowWaitProgress() { }
        // RVA: 0x05774D24  token: 0x6000285
        public System.Int32 GetNoAlertCode() { }
        // RVA: 0x05774D74  token: 0x6000286
        public System.Single GetWaitTime() { }

    }

    // TypeToken: 0x200008F  // size: 0x28
    public class LoginGSNode : Node
    {
        // Fields
        private static System.Int32 FLOW_NONE;  // const
        private static System.Int32 FLOW_WORKING;  // const
        private static System.Int32 FLOW_FINISH;  // const
        private static System.Int32 FLOW_ABORTING;  // const
        private Beyond.Login.LoginGSNode.EnterGameServiceFlow m_flow;  // 0x20

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D557B0 */ }

        // Methods
        // RVA: 0x039CEFB0  token: 0x60002CA
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x02D75850  token: 0x60002CB
        public virtual System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param) { }
        // RVA: 0x02D78290  token: 0x60002CC
        private static System.Collections.IEnumerator _ConfirmServer() { }
        // RVA: 0x0577459C  token: 0x60002CD
        private System.Void _FallbackToInitWithMask(System.Boolean bLogoutAccount) { }
        // RVA: 0x057748BC  token: 0x60002CE
        private System.Void _OnEventLogout() { }
        // RVA: 0x05774A00  token: 0x60002CF
        private System.Void _OnEventResourceRepair() { }
        // RVA: 0x05774800  token: 0x60002D0
        private System.Boolean _LogoutToInitNode() { }
        // RVA: 0x0577451C  token: 0x60002D1
        private System.Boolean _FallbackToInitNodeImpl() { }
        // RVA: 0x05774720  token: 0x60002D2
        private System.Boolean _FallbackToResRepairImpl() { }
        // RVA: 0x0350B670  token: 0x60002D3
        public System.Void .ctor() { }
        // RVA: 0x057743E4  token: 0x60002D4
        private System.Void <_OnEventLogout>b__12_0() { }
        // RVA: 0x057743F0  token: 0x60002D5
        private System.Void <_OnEventResourceRepair>b__13_0() { }
        // RVA: 0x057743DC  token: 0x60002D6
        public System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1) { }

    }

    // TypeToken: 0x2000099  // size: 0x30
    public class LoginHotUpdateProp : Beyond.Login.LoginProperty`1
    {
        // Methods
        // RVA: 0x028D48A0  token: 0x6000313
        public System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }

    }

    // TypeToken: 0x200009A  // size: 0x28
    public class LoginHotUpdateModel
    {
        // Fields
        public System.String title;  // 0x10
        public System.String desc;  // 0x18
        public Beyond.Login.LoginHotUpdateModel.IProgress progress;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000314
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009D  // size: 0x48
    public class LoginHotUpdater : UnityEngine.CustomYieldInstruction, System.IDisposable
    {
        // Fields
        private static System.Int32 MODE_SKIP;  // const
        private static System.Int32 MODE_DOWNLOAD;  // const
        private static System.Int32 MODE_LOCAL;  // const
        private static System.Boolean s_hasInitialAssetChanged;  // static @ 0x0
        private static System.Boolean s_isNeedSoftRestart;  // static @ 0x1
        private Beyond.LoginContext m_loginCxt;  // 0x10
        private System.Collections.IEnumerator m_mainRoutine;  // 0x18
        private Beyond.Login.LoginProgress m_progress;  // 0x20
        private Beyond.Login.LoginHotUpdateProp m_hotupdateProp;  // 0x28
        private Beyond.Login.LoginDownloadTask m_downloadTask;  // 0x30
        private Beyond.Login.LoginLocalResTask m_localResTask;  // 0x38
        private System.Boolean m_resRepairMode;  // 0x40
        public static System.String URL_GET_SPLIT;  // const

        // Properties
        System.Boolean keepWaiting { get; /* RVA: 0x02702DB0 */ }

        // Methods
        // RVA: 0x05775800  token: 0x600031C
        protected static System.Void MarkInitialAssetChanged() { }
        // RVA: 0x057756A0  token: 0x600031D
        protected static System.Boolean CheckInitialAssetChanged() { }
        // RVA: 0x0577586C  token: 0x600031E
        protected static System.Void MarkNeedClearFolder(System.Boolean isInitial) { }
        // RVA: 0x05775960  token: 0x600031F
        protected static System.Boolean NeedClearFolder(System.Boolean isInitial) { }
        // RVA: 0x05775778  token: 0x6000320
        protected static System.Void MarkClearSuccessed(System.Boolean isInitial) { }
        // RVA: 0x057758F4  token: 0x6000321
        public static System.Void MarkSoftRestart() { }
        // RVA: 0x0577570C  token: 0x6000322
        public static System.Void ClearSoftRestartFlag() { }
        // RVA: 0x02C38960  token: 0x6000323
        public static System.Boolean IsNeedSoftRestart() { }
        // RVA: 0x03CA90B0  token: 0x6000324
        private System.Void .ctor(Beyond.LoginContext context, System.Boolean resRepairMode) { }
        // RVA: 0x0379F8E0  token: 0x6000326
        public virtual System.Void Dispose() { }
        // RVA: 0x02C36CB0  token: 0x6000327
        public static Beyond.Login.LoginHotUpdater StartHotUpdate(Beyond.LoginContext context, System.Boolean resRepairMode) { }
        // RVA: 0x02C36D60  token: 0x6000328
        private System.Collections.IEnumerator _Work() { }
        // RVA: 0x02F42390  token: 0x6000329
        private System.Collections.IEnumerator _CreateMainCoroutine(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x0399EAC0  token: 0x600032A
        private System.Collections.IEnumerator _MainCoroutineModeSkip(Beyond.Login.LoginHotUpdater.WorkContext context) { }
        // RVA: 0x0577661C  token: 0x600032B
        private System.Collections.IEnumerator _MainCoroutineModeLocal(Beyond.Login.LoginHotUpdater.WorkContext context) { }
        // RVA: 0x02F42300  token: 0x600032C
        private System.Collections.IEnumerator _UpdateResVersion(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x02F43200  token: 0x600032D
        private static System.Void _SetResVersionForLog() { }
        // RVA: 0x05776304  token: 0x600032E
        private System.String _GetOnlineResVersion(System.Boolean isInitial) { }
        // RVA: 0x057759E4  token: 0x600032F
        public System.String ResourceRootUrl(System.String version, System.Boolean isInitial) { }
        // RVA: 0x057769C0  token: 0x6000330
        private System.Collections.IEnumerator _UpdateResVersionDev(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x03B38830  token: 0x6000331
        private System.Collections.IEnumerator _UpdateResVersionProd(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x05776908  token: 0x6000332
        private System.String _ResourcePatchUrl(System.String version, System.Boolean isInitial) { }
        // RVA: 0x057766C4  token: 0x6000333
        private System.String _ResourceFileUrl(System.String version, System.Boolean isInitial) { }
        // RVA: 0x05776844  token: 0x6000334
        private System.String _ResourcePatchRootUrl(System.String version, System.Boolean isInitial) { }
        // RVA: 0x0577677C  token: 0x6000335
        private System.String _ResourceIndexUrl(System.String version, System.Boolean isInitial) { }
        // RVA: 0x05776574  token: 0x6000336
        private System.Collections.IEnumerator _MainCoroutineModeDownload(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x03B21C20  token: 0x6000337
        private System.Collections.IEnumerator _ReloadResourceIndexes(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x057763D8  token: 0x6000338
        private System.Collections.IEnumerator _LoadOrDownloadResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef resIndexRef) { }
        // RVA: 0x0577614C  token: 0x6000339
        private System.Collections.IEnumerator _GenResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x05776228  token: 0x600033A
        private System.Collections.IEnumerator _GenRiff(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x01039570  token: 0x600033B
        private static Beyond.Resource.HotUpdate.LocalResPref _CreateUpdatedLocalResPref(System.String onlineVer, System.Boolean isInitial, Beyond.Resource.HotUpdate.LocalResPref oldLocalResPref, Beyond.Resource.HotUpdate.FResourceDiff resDiff, System.Int32& removedFileCount) { }
        // RVA: 0x0577607C  token: 0x600033C
        private System.Collections.IEnumerator _GenLocalRef(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x05775BFC  token: 0x600033D
        private System.Collections.IEnumerator _CheckAndDownloadResource(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x05775F64  token: 0x600033E
        private System.Void _EventLogDownloadProgress(System.Boolean& first, System.Double current, System.Double total, System.Int32 target, System.Boolean isInitial) { }
        // RVA: 0x05775E88  token: 0x600033F
        private System.Collections.IEnumerator _DownloadPatchInfo(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef patchInfoRef) { }
        // RVA: 0x05775DB4  token: 0x6000340
        private System.Collections.IEnumerator _ClearDownloadFolder(Beyond.Login.LoginHotUpdater.WorkContext workContext, System.Boolean needDeleteInitial, System.Boolean needDeleteMain) { }
        // RVA: 0x05775CD8  token: 0x6000341
        private System.Collections.IEnumerator _CheckLocalResConsistency(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext context) { }
        // RVA: 0x05776A48  token: 0x6000342
        private System.Collections.IEnumerator _VitalError(System.String error) { }
        // RVA: 0x057764B4  token: 0x6000343
        private static System.Collections.IEnumerator _LoadStreamingIndex(System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext, Beyond.Misc.ObjectRef resultRef) { }
        // RVA: 0x05775AA0  token: 0x6000344
        public static System.Void WriteLocalResPrefToFile(Beyond.Resource.HotUpdate.LocalResPref localResPref, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x0399EB50  token: 0x6000345
        private static System.Int32 _CurrentWorkMode(Beyond.LoginContext context) { }

    }

    // TypeToken: 0x20000B7  // size: 0x50
    public class LoginProgress : IProgress
    {
        // Fields
        public static System.Int32 MODE_PROG;  // const
        public static System.Int32 MODE_SIZE;  // const
        public static System.Int32 MODE_IDEL;  // const
        public System.Int32 mode;  // 0x10
        public System.Double current;  // 0x18
        public System.Double total;  // 0x20
        public System.Double speed;  // 0x28
        private Beyond.Login.LoginProgress.FDownloadSize m_downloadSize;  // 0x30

        // Methods
        // RVA: 0x0577ED44  token: 0x60003CC
        public virtual System.Double GetCurrent() { }
        // RVA: 0x0577EE40  token: 0x60003CD
        public virtual System.Double GetTotal() { }
        // RVA: 0x0577ED94  token: 0x60003CE
        public virtual System.String GetInfo() { }
        // RVA: 0x0350B670  token: 0x60003CF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA  // size: 0x28
    public class LoginInitNode : Node
    {
        // Fields
        private System.Boolean m_isSDKInited;  // 0x20

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D50CD0 */ }

        // Methods
        // RVA: 0x036BCBF0  token: 0x60003D9
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x036BCCD0  token: 0x60003DA
        private System.Collections.IEnumerator _InitCoroutine() { }
        // RVA: 0x03893CB0  token: 0x60003DB
        private System.Collections.IEnumerator _InitRemoteConfigs() { }
        // RVA: 0x0577D82C  token: 0x60003DC
        private System.Collections.IEnumerator _YieldAlertError(System.String errorInfo) { }
        // RVA: 0x0350B670  token: 0x60003DD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE  // size: 0x20
    public class LoginLocalResTask : System.IDisposable
    {
        // Fields
        private Beyond.LoginContext m_loginCxt;  // 0x10
        private Beyond.Login.LoginHotUpdater.WorkContext m_workCxt;  // 0x18

        // Methods
        // RVA: 0x02676770  token: 0x60003F0
        public System.Void .ctor(Beyond.LoginContext loginContext, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        // RVA: 0x0577DD64  token: 0x60003F1
        public System.Collections.IEnumerator Work() { }
        // RVA: 0x0577DD20  token: 0x60003F2
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000C1  // size: 0x38
    public class PreloadNode : Node
    {
        // Fields
        private Beyond.Login.LoginHotUpdateModel.SimpleProgress m_progress;  // 0x20
        private System.Boolean m_getServerListSuc;  // 0x28
        private System.String m_errorMsg;  // 0x30

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x02C362C0  token: 0x60003FD
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x028D4940  token: 0x60003FE
        private System.Void _ShowPreloadResourcePanel() { }
        // RVA: 0x02C36460  token: 0x60003FF
        private System.Collections.IEnumerator _LoginPreLoad() { }
        // RVA: 0x02C34EE0  token: 0x6000400
        private System.Collections.IEnumerator _WarmUp() { }
        // RVA: 0x02C34E70  token: 0x6000401
        private System.Collections.IEnumerator _GetServerList() { }
        // RVA: 0x02C34F50  token: 0x6000402
        private System.Void _EnterPreLoad() { }
        // RVA: 0x02D77060  token: 0x6000403
        private System.Collections.IEnumerator _GetServerListInfoMock() { }
        // RVA: 0x0578006C  token: 0x6000404
        private System.Collections.IEnumerator _GetServerListInfo() { }
        // RVA: 0x02D763A0  token: 0x6000405
        private System.Void _OnGetServerListSuc() { }
        // RVA: 0x057800FC  token: 0x6000406
        private System.Void _OnGetServerListFail(System.String errorInfo) { }
        // RVA: 0x037B81F0  token: 0x6000407
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9  // size: 0x28
    public class LoginSDKInitNode : Node
    {
        // Fields
        private System.Boolean m_isSDKInited;  // 0x20

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x036BCD40  token: 0x600042D
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x036BCE20  token: 0x600042E
        private System.Collections.IEnumerator _SDKInitCoroutine() { }
        // RVA: 0x02D78350  token: 0x600042F
        private System.Collections.IEnumerator _WaitForSDKInited() { }
        // RVA: 0x02D77C90  token: 0x6000430
        private System.Collections.IEnumerator _InitSubSDKs(System.String env) { }
        // RVA: 0x0350B670  token: 0x6000431
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD  // size: 0x28
    public class U8LoginNode : Node
    {
        // Fields
        private System.Boolean m_loginSuc;  // 0x20
        private System.Boolean m_isSDKLoginFinished;  // 0x21
        private System.Int32 m_rqstSkipLoginCache;  // 0x24

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D51100 */ }

        // Methods
        // RVA: 0x036BCE90  token: 0x6000445
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x036BCF70  token: 0x6000446
        private System.Collections.IEnumerator _LoginCoroutine() { }
        // RVA: 0x02D783B0  token: 0x6000447
        private System.Collections.IEnumerator _FinishLogin() { }
        // RVA: 0x05782484  token: 0x6000448
        public virtual System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param) { }
        // RVA: 0x02C37AE0  token: 0x6000449
        private System.Void _StartSDKLogin() { }
        // RVA: 0x02D770D0  token: 0x600044A
        private System.Void _SetCursorOnLoginStart() { }
        // RVA: 0x02D77240  token: 0x600044B
        private System.Void _SetCursorOnLoginFinish() { }
        // RVA: 0x057827B4  token: 0x600044C
        private System.Void _SkipSDKLogin() { }
        // RVA: 0x028D4640  token: 0x600044D
        private System.Void _ClearLoginCaches() { }
        // RVA: 0x02EA95C0  token: 0x600044E
        private System.Void _OnLoginSuc() { }
        // RVA: 0x0578268C  token: 0x600044F
        private System.Void _OnLoginFail(System.Object rawInfo) { }
        // RVA: 0x02EA9BE0  token: 0x6000450
        private System.Void _OnSDKViewDisabled() { }
        // RVA: 0x057825E0  token: 0x6000451
        private System.Void _OnLoginCanceled() { }
        // RVA: 0x02EA97C0  token: 0x6000452
        private System.Void _EnableBlurMask(System.Boolean enable) { }
        // RVA: 0x0350B670  token: 0x6000453
        public System.Void .ctor() { }
        // RVA: 0x02D77150  token: 0x6000454
        private System.Void <_StartSDKLogin>b__9_0(System.String sessionToken) { }
        // RVA: 0x05782508  token: 0x6000455
        private System.Void <_StartSDKLogin>b__9_1(System.Object pram) { }
        // RVA: 0x057743DC  token: 0x6000456
        public System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1) { }

    }

    // TypeToken: 0x20000D0
    public class LoginProperty`1 : IWorkerUpdateOnce
    {
        // Fields
        private T m_value;  // 0x0
        private System.Collections.Generic.HashSet<Beyond.Login.ILoginBinder<T>> m_binders;  // 0x0
        private Beyond.Login.LoginWorkFlow m_workflow;  // 0x0
        private System.Boolean <isDataChanged>k__BackingField;  // 0x0

        // Properties
        System.Boolean isDataChanged { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        T value { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000463
        public System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }
        // RVA: -1  // not resolved  token: 0x6000467
        public System.Void NotifyDataChanged() { }
        // RVA: -1  // not resolved  token: 0x6000468
        public System.Void Bind(Beyond.Login.ILoginBinder<T> binder) { }
        // RVA: -1  // not resolved  token: 0x6000469
        public virtual System.Void Worker_UpdateOnce() { }

    }

    // TypeToken: 0x20000D1
    public interface ILoginBinder`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600046A
        public virtual System.Void OnValueChanged(T value) { }

    }

    // TypeToken: 0x20000D2
    public interface ILoginContextReceiver
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600046B
        public virtual System.Void OnLoginContext(Beyond.LoginContext context) { }

    }

    // TypeToken: 0x20000D3  // size: 0x30
    public class LoginViewModel
    {
        // Fields
        public Beyond.Login.LoginWorkFlow.ENode workCachedCurNode;  // 0x10
        public Beyond.Login.LoginWorkFlow.ENode workCurNode;  // 0x14
        public System.Boolean isFirstLogin;  // 0x18
        private System.Int32 <rqstSkipU8Login>k__BackingField;  // 0x1c
        public System.Boolean isU8LoginCancelled;  // 0x20
        private System.Int32 <rqstResRepairCode>k__BackingField;  // 0x24
        public Beyond.Login.LoginViewModel.FAgeTipsPolicy ageTipsPolicy;  // 0x28

        // Properties
        System.Int32 rqstSkipU8Login { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }
        System.Int32 rqstResRepairCode { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }

        // Methods
        // RVA: 0x03CA4880  token: 0x600046C
        public System.Void .ctor() { }
        // RVA: 0x02C3B550  token: 0x6000471
        public System.Boolean IsAgeTipsVisible() { }
        // RVA: 0x02C3B410  token: 0x6000472
        public System.Boolean IsGovTipsVisible() { }
        // RVA: 0x02C3B5E0  token: 0x6000473
        public System.Boolean IsMenuVisible() { }
        // RVA: 0x0577EEF4  token: 0x6000474
        public System.Void RequestResourceRepair() { }
        // RVA: 0x0577EF40  token: 0x6000475
        public System.Void RequestSkipU8Login() { }
        // RVA: 0x03CA48B0  token: 0x6000476
        private static Beyond.Login.LoginViewModel.FAgeTipsPolicy _LoadAgeTipsPolicy() { }

    }

    // TypeToken: 0x20000D5  // size: 0x48
    public class LoginViewProperty : Beyond.Login.LoginProperty`1
    {
        // Fields
        private Beyond.Login.LoginHotUpdateProp <hotUpdateProp>k__BackingField;  // 0x30
        private Beyond.Login.LoginAgeTipsProp <ageTipsProp>k__BackingField;  // 0x38
        private Beyond.Login.LoginServerSelectProp <serverSelectProp>k__BackingField;  // 0x40

        // Properties
        Beyond.Login.LoginHotUpdateProp hotUpdateProp { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        Beyond.Login.LoginAgeTipsProp ageTipsProp { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        Beyond.Login.LoginServerSelectProp serverSelectProp { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }

        // Methods
        // RVA: 0x028D44E0  token: 0x600047E
        public System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }

    }

    // TypeToken: 0x20000D6  // size: 0x20
    public class LoginAgeTipsModel
    {
        // Fields
        public System.String contentCache;  // 0x10
        public System.Boolean isShow;  // 0x18
        public System.Boolean isFetchingContent;  // 0x19

        // Methods
        // RVA: 0x028D4790  token: 0x600047F
        public System.Boolean IsContentEmpty() { }
        // RVA: 0x03C7D0D0  token: 0x6000480
        public System.Boolean CanDisplay() { }
        // RVA: 0x0350B670  token: 0x6000481
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7  // size: 0x30
    public class LoginAgeTipsProp : Beyond.Login.LoginProperty`1
    {
        // Methods
        // RVA: 0x028D4720  token: 0x6000482
        public System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }
        // RVA: 0x0577D468  token: 0x6000483
        public System.Void ClearContentCache() { }
        // RVA: 0x0577D52C  token: 0x6000484
        public System.Void UpdateContent(System.String content) { }

    }

    // TypeToken: 0x20000D8  // size: 0x50
    public class LoginWorkFlow : System.IDisposable
    {
        // Fields
        public static System.String CURSOR_KEY_LOGIN;  // const
        private static readonly Beyond.Login.LoginWorkFlow.ENode[] NODE_ORDER;  // static @ 0x0
        private static Beyond.Login.LoginWorkFlow.ENode NEED_GAME_LOGIN_STATE_BEFORE_NODE;  // const
        private readonly Beyond.Login.LoginWorkFlow.Node[] m_nodes;  // 0x10
        private readonly Beyond.LoginContext m_context;  // 0x18
        private Beyond.Login.LoginWorkFlow.FWork m_work;  // 0x20
        private Beyond.Login.LoginWorkFlow.Worker m_worker;  // 0x30
        private System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IEventReceiver> m_evtRecvrs;  // 0x38
        private System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IEventReceiver> m_recvrBuffer;  // 0x40
        private System.Boolean <isDisposed>k__BackingField;  // 0x48

        // Properties
        System.Boolean isDisposed { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }

        // Methods
        // RVA: 0x037B7E90  token: 0x6000485
        private Beyond.Login.LoginWorkFlow.Node[] _RegisterNodes() { }
        // RVA: 0x02C38A80  token: 0x6000488
        public System.Void .ctor(Beyond.LoginContext context) { }
        // RVA: 0x02EA9D50  token: 0x6000489
        public System.Collections.IEnumerator DoWorkFlow() { }
        // RVA: 0x02C38C00  token: 0x600048A
        public virtual System.Void Dispose() { }
        // RVA: 0x0379FA20  token: 0x600048B
        public System.Boolean PeekFallbackStatus(Beyond.Login.LoginWorkFlow.ENode& fallbackNode) { }
        // RVA: 0x0577F0B0  token: 0x600048C
        public System.Boolean Fallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck) { }
        // RVA: 0x0577F01C  token: 0x600048D
        public System.Boolean CancelAndFallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck) { }
        // RVA: 0x02D75460  token: 0x600048E
        public System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param) { }
        // RVA: 0x0577EF8C  token: 0x600048F
        public System.Void AddEventReceiver(Beyond.Login.LoginWorkFlow.IEventReceiver receiver) { }
        // RVA: 0x03600790  token: 0x6000490
        public System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst) { }
        // RVA: 0x02C396F0  token: 0x6000491
        public static System.Boolean IsBeforeWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check) { }
        // RVA: 0x02C3B000  token: 0x6000492
        public static System.Boolean IsOnOrAfterWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check) { }
        // RVA: 0x0577F308  token: 0x6000493
        public static System.Boolean IsAfterWork(Beyond.Login.LoginWorkFlow.ENode target, Beyond.Login.LoginWorkFlow.ENode check) { }
        // RVA: 0x02D757E0  token: 0x6000494
        private System.Boolean _HandleGlobalEvent(Beyond.ELoginEvent evt, System.Object param) { }
        // RVA: 0x0577F690  token: 0x6000495
        private System.Void _EventOnOpenAgeTips() { }
        // RVA: 0x0577F3CC  token: 0x6000496
        private System.Void _EventOnCloseAgeTips() { }
        // RVA: 0x0577F804  token: 0x6000497
        private System.Void _EventOnOpenServerSelect(System.Boolean isOpen) { }
        // RVA: 0x0577F8D4  token: 0x6000498
        private System.Void _EventOnSelectServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData serverZoneData) { }
        // RVA: 0x0577F4F4  token: 0x6000499
        private System.Void _EventOnConfirmServer() { }
        // RVA: 0x02C383E0  token: 0x600049A
        private System.Void _EnableCursor(System.Boolean enabled) { }
        // RVA: 0x0577FA5C  token: 0x600049B
        private System.Void _UpdateCursor(Beyond.EventData<Beyond.DeviceInfo.InputType>& input) { }
        // RVA: 0x02D7AB60  token: 0x600049C
        private System.Void _EnbaleToggleGroup() { }
        // RVA: 0x0577F9B4  token: 0x600049D
        private System.Collections.IEnumerator _FetchAgeTipsCoroutine(Beyond.Login.LoginAgeTipsProp prop) { }
        // RVA: 0x02C395D0  token: 0x600049E
        private static System.Boolean _CheckIfGameStateNotMatch(Beyond.Login.LoginWorkFlow.ENode curNode) { }
        // RVA: 0x02C38660  token: 0x600049F
        private static System.Collections.IEnumerator _AdjustCurrentGameState(Beyond.Login.LoginWorkFlow.ENode curNode) { }
        // RVA: 0x03CE3B80  token: 0x60004A0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E3  // size: 0x30
    public class HotUpdateNode : Node
    {
        // Fields
        private Beyond.Login.LoginHotUpdater m_updater;  // 0x20
        private System.Int32 m_cachedResRepairCode;  // 0x28

        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D51110 */ }

        // Methods
        // RVA: 0x02C36DD0  token: 0x60004E5
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x0379F7A0  token: 0x60004E6
        public virtual System.Void OnDispose() { }
        // RVA: 0x0350B670  token: 0x60004E7
        public System.Void .ctor() { }
        // RVA: 0x057732FC  token: 0x60004E8
        public System.Void <>iFixBaseProxy_OnDispose() { }

    }

    // TypeToken: 0x20000E4  // size: 0x28
    public abstract class WaitForSecondsNode : Node
    {
        // Fields
        private System.Nullable<System.Int32> m_timerId;  // 0x20

        // Methods
        // RVA: 0x02C36A50  token: 0x60004E9
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x038C19F0  token: 0x60004EA
        private System.Boolean _IsTimeout() { }
        // RVA: 0x03D07940  token: 0x60004EB
        private System.Void _NotifyTimeout() { }
        // RVA: 0x0379F870  token: 0x60004EC
        private System.Void _DisposeTimer() { }
        // RVA: -1  // abstract  token: 0x60004ED
        protected virtual System.Single WaitForSeconds(System.Boolean& unscaled) { }
        // RVA: 0x0379F800  token: 0x60004EE
        public virtual System.Void OnDispose() { }
        // RVA: 0x0350B670  token: 0x60004EF
        protected System.Void .ctor() { }
        // RVA: 0x057732FC  token: 0x60004F0
        public System.Void <>iFixBaseProxy_OnDispose() { }

    }

    // TypeToken: 0x20000E5  // size: 0x28
    public class PreloadPostDelayNode : Beyond.Login.WaitForSecondsNode
    {
        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D55810 */ }

        // Methods
        // RVA: 0x03D43E20  token: 0x60004F2
        protected virtual System.Single WaitForSeconds(System.Boolean& unscaled) { }
        // RVA: 0x02C37580  token: 0x60004F3
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x028D4A40  token: 0x60004F4
        private System.Void _DisableLoadingPanel() { }
        // RVA: 0x0350B670  token: 0x60004F5
        public System.Void .ctor() { }
        // RVA: 0x057801B8  token: 0x60004F6
        public UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work() { }

    }

    // TypeToken: 0x20000E6  // size: 0x28
    public class Trans2GsLoginNode : Beyond.Login.WaitForSecondsNode
    {
        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D55730 */ }

        // Methods
        // RVA: 0x02EA9680  token: 0x60004F8
        protected virtual System.Single WaitForSeconds(System.Boolean& unscaled) { }
        // RVA: 0x02C37130  token: 0x60004F9
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x0350B670  token: 0x60004FA
        public System.Void .ctor() { }
        // RVA: 0x057801B8  token: 0x60004FB
        public UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work() { }

    }

    // TypeToken: 0x20000E7  // size: 0x20
    public class FinishNode : Node
    {
        // Properties
        Beyond.Login.LoginWorkFlow.ENode type { get; /* RVA: 0x03D557F0 */ }

        // Methods
        // RVA: 0x02C370B0  token: 0x60004FD
        public virtual UnityEngine.CustomYieldInstruction Work() { }
        // RVA: 0x0350B670  token: 0x60004FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8  // size: 0x20
    public sealed struct CarrierDownloadCache
    {
        // Fields
        public static readonly Beyond.Login.CarrierDownloadCache EMPTY;  // static @ 0x0
        public System.Int64 size;  // 0x10
        public System.Boolean isAllowed;  // 0x18

        // Methods
        // RVA: 0x03D26E90  token: 0x60004FF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000E9  // size: 0x30
    public class NetUsagePolicy
    {
        // Fields
        private static System.Int32 NOT_REACHABLE_ERROR_CODE;  // const
        private Beyond.Login.CarrierDownloadCache m_mobileDataCache;  // 0x10
        private UnityEngine.NetworkReachability m_lastNetworkState;  // 0x20
        private Beyond.Login.NetUsagePolicy.Options m_options;  // 0x28

        // Methods
        // RVA: 0x028D5280  token: 0x6000500
        public System.Void .ctor(Beyond.Login.NetUsagePolicy.Options options) { }
        // RVA: 0x0577FBFC  token: 0x6000501
        public System.Void CheckIfAllowDownload(System.Int64 downloadSize, System.Action onAllowed, System.Action onRejected, System.Action onReachable) { }
        // RVA: 0x0577FBA4  token: 0x6000502
        public System.Boolean AllowMobileDataInLastCheck() { }
        // RVA: 0x0577FF4C  token: 0x6000503
        private static System.String _GetPrettySizeStringUpToMB(System.Double number) { }

    }

    // TypeToken: 0x20000EC  // size: 0xD8
    public class LoginSceneAnimCtrl : Beyond.Login.LoginSceneComponent, Beyond.Login.ILoginBinder`1, UnityEngine.IAnimationClipSource
    {
        // Fields
        private static System.Single COUNT_DOWN_EMPTY;  // const
        private UnityEngine.Animator _target;  // 0x78
        private UnityEngine.AnimationClip _clipA1;  // 0x80
        private UnityEngine.AnimationClip _clipA1s;  // 0x88
        private System.Single _transA1;  // 0x90
        private System.Single _transA1s;  // 0x94
        private UnityEngine.Vector2 _randomRangeA1s;  // 0x98
        private UnityEngine.AnimationClip _clipA1A2;  // 0xa0
        private System.Single _predelayA1A2;  // 0xa8
        private System.Single _transA1A2;  // 0xac
        private UnityEngine.AnimationClip _clipA2;  // 0xb0
        private System.Single _transA2;  // 0xb8
        private Beyond.UI.UIAnimationMixPlayer m_player;  // 0xc0
        private Beyond.Login.LoginSceneAnimCtrl.EState m_state;  // 0xc8
        private System.Single m_countDownA1s;  // 0xcc
        private System.Single m_countDownA1A2;  // 0xd0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x02EA91C0  token: 0x6000508
        protected virtual System.Void OnBindToManager() { }
        // RVA: 0x03099C10  token: 0x6000509
        private Beyond.UI.UIAnimationMixPlayer _EnsurePlayer() { }
        // RVA: 0x02C3AF80  token: 0x600050A
        private System.Void _ChangeToState(Beyond.Login.LoginSceneAnimCtrl.EState target) { }
        // RVA: 0x03099840  token: 0x600050B
        private System.Void _ResetToA1() { }
        // RVA: 0x039B3B00  token: 0x600050C
        private System.Void _TransitionToA2() { }
        // RVA: 0x030996A0  token: 0x600050D
        private System.Void _PlayA1sAndTriggerNext() { }
        // RVA: 0x03099E60  token: 0x600050E
        private System.Single _RandomIntervalA1s() { }
        // RVA: 0x03099A10  token: 0x600050F
        private System.Void _PlayA1A2Impl() { }
        // RVA: 0x02C3AEE0  token: 0x6000510
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        // RVA: 0x02C3CA20  token: 0x6000511
        protected virtual System.Void Start() { }
        // RVA: 0x0262E210  token: 0x6000512
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x039A13E0  token: 0x6000513
        protected virtual System.Void OnRelease() { }
        // RVA: 0x0577EE90  token: 0x6000514
        public virtual System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results) { }
        // RVA: 0x03B5CD10  token: 0x6000515
        public System.Void .ctor() { }
        // RVA: 0x0577EEE4  token: 0x6000516
        public System.Void <>iFixBaseProxy_OnBindToManager() { }
        // RVA: 0x0577EEEC  token: 0x6000517
        public System.Void <>iFixBaseProxy_Start() { }
        // RVA: 0x0577D7BC  token: 0x6000518
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0577D7B4  token: 0x6000519
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000EE  // size: 0x78
    public abstract class LoginSceneComponent : Beyond.TickableMono
    {
        // Fields
        private Beyond.LoginContext <context>k__BackingField;  // 0x68
        private Beyond.LoginController <controller>k__BackingField;  // 0x70

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x01002730 */ }
        Beyond.LoginContext context { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        Beyond.LoginController controller { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }

        // Methods
        // RVA: 0x02C3CB50  token: 0x600051F
        protected virtual System.Void Start() { }
        // RVA: 0x02EA9A40  token: 0x6000520
        public System.Void Bind(Beyond.LoginContext context, Beyond.LoginController controller) { }
        // RVA: 0x02EA94D0  token: 0x6000521
        protected virtual System.Void OnBindToManager() { }
        // RVA: 0x02846010  token: 0x6000522
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF  // size: 0x78
    public class LoginSceneRoot : Beyond.Login.LoginSceneComponent
    {
        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x02EA88F0  token: 0x6000524
        protected virtual System.Void OnBindToManager() { }
        // RVA: 0x02846010  token: 0x6000525
        public System.Void .ctor() { }
        // RVA: 0x0577EEE4  token: 0x6000526
        public System.Void <>iFixBaseProxy_OnBindToManager() { }

    }

    // TypeToken: 0x20000F0  // size: 0x68
    public class LoginAgeTipsDetailPanel : UnityEngine.MonoBehaviour, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private Beyond.UI.UIAnimationWrapper _anim;  // 0x18
        private UnityEngine.RectTransform _content;  // 0x20
        private Beyond.UI.UIText _txtTitle;  // 0x28
        private Beyond.UI.UIText _lineTmpl;  // 0x30
        private Beyond.UI.UIButton _btnClose;  // 0x38
        private Beyond.UI.UIScrollRect _scroll;  // 0x40
        private Beyond.Input.InputBindingGroupMonoTarget _ageTipsBindingGroup;  // 0x48
        private Beyond.LoginContext m_context;  // 0x50
        private Beyond.UI.UISwitchTween m_switchTween;  // 0x58
        private DG.Tweening.Tween m_displayDelayTween;  // 0x60
        private static System.Int32 MAX_TEXT_STRLEN;  // const
        private static System.Int32 MIN_TEXT_STRLEN;  // const

        // Methods
        // RVA: 0x03610BA0  token: 0x6000527
        public System.Void Init(Beyond.LoginContext context) { }
        // RVA: 0x03C7D010  token: 0x6000528
        public virtual System.Void OnValueChanged(Beyond.Login.LoginAgeTipsModel value) { }
        // RVA: 0x0577CE6C  token: 0x6000529
        private System.Void _RenderContent(System.String contentStr) { }
        // RVA: 0x0577CFDC  token: 0x600052A
        private System.Void _ShowContent() { }
        // RVA: 0x0577CDF4  token: 0x600052B
        private System.Void _EventOnCloseClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577D038  token: 0x600052C
        private static System.Collections.Generic.List<System.String> _SplitLicenseToSegments(System.String content) { }
        // RVA: 0x0577D31C  token: 0x600052D
        private static System.Void _SplitLongString(System.String longStr, System.Collections.Generic.List<System.String> outputList) { }
        // RVA: 0x0426FE60  token: 0x600052E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F1  // size: 0x48
    public class LoginAgeTipsPanel : ChildPanel, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private Beyond.Login.LoginAgeTipsDetailPanel _detailPanel;  // 0x28
        private Beyond.UI.UIButton _ageTipsCN;  // 0x30
        private UnityEngine.GameObject _ageTipsKR;  // 0x38
        private UnityEngine.CanvasGroup _canvasVersionTop;  // 0x40

        // Methods
        // RVA: 0x03610410  token: 0x600052F
        protected virtual System.Void OnInit() { }
        // RVA: 0x02C3B4C0  token: 0x6000530
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        // RVA: 0x02C3BBA0  token: 0x6000531
        private System.Void _UpdateAgeTipsPolicy(Beyond.Login.LoginViewModel.FAgeTipsPolicy policy) { }
        // RVA: 0x0577D3F0  token: 0x6000532
        private System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0426FE60  token: 0x6000533
        public System.Void .ctor() { }
        // RVA: 0x0577D3E8  token: 0x6000534
        public System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000F2  // size: 0x58
    public class LoginAlertDialog : Dialog
    {
        // Fields
        private Beyond.UI.UIButton _btnConfirm;  // 0x38
        private Beyond.UI.UIText _text;  // 0x40
        private Beyond.Login.LoginAlertDialog.FParams m_params;  // 0x48

        // Methods
        // RVA: 0x0577D5DC  token: 0x6000535
        protected virtual System.Void OnInit() { }
        // RVA: 0x0577D6C0  token: 0x6000536
        public System.Void SetParams(Beyond.Login.LoginAlertDialog.FParams param) { }
        // RVA: 0x0577D750  token: 0x6000537
        private System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        // RVA: 0x0426FE60  token: 0x6000538
        public System.Void .ctor() { }
        // RVA: 0x0577D748  token: 0x6000539
        public System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000F4  // size: 0xE0
    public class LoginDecorateUI : Beyond.TickableUIMono, Beyond.Login.ILoginBinder`1, Beyond.Login.ILoginContextReceiver
    {
        // Fields
        private UnityEngine.CanvasGroup _imgLogo;  // 0x68
        private System.Single _durationLogo;  // 0x70
        private UnityEngine.AnimationClip _clipLoopGlow;  // 0x78
        private UnityEngine.AnimationClip _clipInGlow;  // 0x80
        private UnityEngine.Animator _targetGlow;  // 0x88
        private System.Single _delay;  // 0x90
        private Beyond.LoginContext m_context;  // 0x98
        private System.Boolean m_isOnTransNode;  // 0xa0
        private Beyond.Interpolator.FLerpByTime m_hideLogoLerp;  // 0xa8
        private Beyond.UI.UIAnimationLayerMixPlayer m_glowPlayer;  // 0xc8
        private System.Boolean m_isGlowEnabled;  // 0xd0
        private System.Single m_countDownDelay;  // 0xd4
        private System.Single m_countDownDisableGlow;  // 0xd8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x02EA9EA0  token: 0x600053B
        public virtual System.Void OnLoginContext(Beyond.LoginContext context) { }
        // RVA: 0x02C3B6B0  token: 0x600053C
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        // RVA: 0x03099310  token: 0x600053D
        private System.Void _TriggerTrans2GSLoginImpl() { }
        // RVA: 0x02C3BF30  token: 0x600053E
        private System.Void _ToggleGlow(System.Boolean enable) { }
        // RVA: 0x03099490  token: 0x600053F
        private Beyond.UI.UIAnimationLayerMixPlayer _EnsureGlowPlayer() { }
        // RVA: 0x03099050  token: 0x6000540
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x039A1360  token: 0x6000541
        protected virtual System.Void OnRelease() { }
        // RVA: 0x030990E0  token: 0x6000542
        private System.Void _TimeManagerTick(System.Single timeDelta) { }
        // RVA: 0x03C85980  token: 0x6000543
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x6000544
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0577D7B4  token: 0x6000545
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000F5  // size: 0x58
    public class LoginEnterGamePanel : ChildPanel, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private UnityEngine.CanvasGroup _canvasGroup;  // 0x28
        private Beyond.UI.UIButton _btnEnterGame;  // 0x30
        private Beyond.UI.UIText _textEnterGame;  // 0x38
        private System.Single _delayEnterGame;  // 0x40
        private System.Boolean m_isPanelActive;  // 0x44
        private System.Double m_panelActiveTime;  // 0x48
        private System.Boolean m_isInited;  // 0x50

        // Methods
        // RVA: 0x03B5BDA0  token: 0x6000546
        private System.Void _InitIfNot() { }
        // RVA: 0x02C3BAB0  token: 0x6000547
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        // RVA: 0x02D753B0  token: 0x6000548
        private System.Void _OnEnterGameClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        // RVA: 0x03CDE0E0  token: 0x6000549
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F6  // size: 0x30
    public class LoginGovTipsPanel : ChildPanel, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private Beyond.UI.UIButton _btnOpen;  // 0x28

        // Methods
        // RVA: 0x03610530  token: 0x600054A
        protected virtual System.Void OnInit() { }
        // RVA: 0x02C3B3B0  token: 0x600054B
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        // RVA: 0x0577D7C4  token: 0x600054C
        private System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0426FE60  token: 0x600054D
        public System.Void .ctor() { }
        // RVA: 0x0577D3E8  token: 0x600054E
        public System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000F7  // size: 0x98
    public class LoginJudgeDialog : Dialog
    {
        // Fields
        private Beyond.UI.UIButton _btnPositive;  // 0x38
        private Beyond.UI.UIButton _btnNegative;  // 0x40
        private Beyond.UI.UIText _text;  // 0x48
        private Beyond.UI.UIText _text2;  // 0x50
        private Beyond.UI.UIText _textPositive;  // 0x58
        private Beyond.UI.UIText _textNegative;  // 0x60
        private Beyond.Login.LoginJudgeDialog.FParams m_params;  // 0x68

        // Methods
        // RVA: 0x0577D8C8  token: 0x600054F
        protected virtual System.Void OnInit() { }
        // RVA: 0x0577DA14  token: 0x6000550
        public System.Void SetParams(Beyond.Login.LoginJudgeDialog.FParams param) { }
        // RVA: 0x0577DCBC  token: 0x6000551
        private System.Void _OnPositiveClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        // RVA: 0x0577DC58  token: 0x6000552
        private System.Void _OnNegativeClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        // RVA: 0x0426FE60  token: 0x6000553
        public System.Void .ctor() { }
        // RVA: 0x0577D748  token: 0x6000554
        public System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000FA  // size: 0xF0
    public class LoginMenuPanel : ChildPanel, Beyond.Login.ILoginBinder`1
    {
        // Fields
        public static System.String CONTROLLER_STATE_NORMAL;  // const
        public static System.String CONTROLLER_STATE_SELECT;  // const
        private Beyond.UI.UIButton _btnAnnounce;  // 0x28
        private Beyond.UI.UIButton _btnSetting;  // 0x30
        private Beyond.UI.UIButton _btnResCheck;  // 0x38
        private Beyond.UI.UIButton _btnLogout;  // 0x40
        private Beyond.UI.UIButton _btnQuitGame;  // 0x48
        private Beyond.UI.UIButton _btnLogin;  // 0x50
        private Beyond.UI.UIButton _btnQR;  // 0x58
        private Beyond.UI.UIState.UIStateController _ctrlAnnounce;  // 0x60
        private Beyond.UI.UIState.UIStateController _ctrlSetting;  // 0x68
        private Beyond.UI.UIState.UIStateController _ctrlResCheck;  // 0x70
        private Beyond.UI.UIState.UIStateController _ctrlLogout;  // 0x78
        private Beyond.UI.UIState.UIStateController _ctrlQR;  // 0x80
        private Beyond.UI.UISimpleStateController _ctrlRight;  // 0x88
        private Beyond.UI.UISelectableNaviGroup _naviGroupRight;  // 0x90
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroupForKeyboard;  // 0x98
        private Beyond.Input.InputBindingGroupMonoTarget _rootPanelBindingGroup;  // 0xa0
        private UnityEngine.CanvasGroup _alphaHandler;  // 0xa8
        private UnityEngine.GameObject _redDotAnnounce;  // 0xb0
        private Beyond.UI.UIAnimationWrapper _transAnim;  // 0xb8
        private Beyond.UI.UIButton _serverZoneBtn;  // 0xc0
        private Beyond.UI.UIText _serverZoneName;  // 0xc8
        private UnityEngine.GameObject _serverZonePS5;  // 0xd0
        private Beyond.UI.UIText _serverZoneNamePS5;  // 0xd8
        private Beyond.UI.UIState.UIStateController m_curRightBtnCtrl;  // 0xe0
        private System.Boolean m_hasRedDot;  // 0xe8
        private System.Int32 m_rootParentGroupId;  // 0xec

        // Methods
        // RVA: 0x02D9D470  token: 0x6000555
        protected virtual System.Void OnInit() { }
        // RVA: 0x02C3B0D0  token: 0x6000556
        public virtual System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        // RVA: 0x02EAA0E0  token: 0x6000557
        public System.Void InitBulletinAndRedAfterLoginSuc() { }
        // RVA: 0x03D42D10  token: 0x6000558
        private static System.Void _OnBulletinOpen() { }
        // RVA: 0x03D2B470  token: 0x6000559
        private static System.Void _OnBulletinClose() { }
        // RVA: 0x03C7EF60  token: 0x600055A
        private System.Void Awake() { }
        // RVA: 0x029749B0  token: 0x600055B
        private System.Void OnEnable() { }
        // RVA: 0x02974BB0  token: 0x600055C
        private System.Void OnDisable() { }
        // RVA: 0x03C7AE80  token: 0x600055D
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0577E224  token: 0x600055E
        private System.Void _OnAnnounceClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577EC58  token: 0x600055F
        private System.Void _OnSettingClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577EB24  token: 0x6000560
        private System.Void _OnResCheckClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E45C  token: 0x6000561
        private System.Void _OnCustomServiceClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E15C  token: 0x6000562
        private System.Void _OnAccountCenterClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E7A0  token: 0x6000563
        private System.Void _OnLogoutClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E918  token: 0x6000564
        private System.Void _OnQuitGameClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E728  token: 0x6000565
        private System.Void _OnLoginClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E868  token: 0x6000566
        private System.Void _OnQRClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577EAB8  token: 0x6000567
        private System.Void _OnRequestRelogin() { }
        // RVA: 0x03D276A0  token: 0x6000568
        private System.Boolean _CanQRLogin() { }
        // RVA: 0x02EAA1E0  token: 0x6000569
        private System.Void _UpdateAnnounceRedDot() { }
        // RVA: 0x02D791F0  token: 0x600056A
        private System.Void _UpdateServerZone() { }
        // RVA: 0x0577EBEC  token: 0x600056B
        private System.Void _OnServerZoneBtnClicked() { }
        // RVA: 0x0577E50C  token: 0x600056C
        private System.Void _OnFocusMenuGroup(System.Boolean isFocused) { }
        // RVA: 0x0577E3BC  token: 0x600056D
        private System.Void _OnAnnounceClosed() { }
        // RVA: 0x02EAA260  token: 0x600056E
        private System.Void _OnReceiveRedDotAndPopup(System.Boolean showRedDot) { }
        // RVA: 0x039DD5A0  token: 0x600056F
        private System.Void _OnUpdateRedDotForSDKListener(Beyond.EventData<System.Boolean>& show) { }
        // RVA: 0x0577E5FC  token: 0x6000570
        private System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input) { }
        // RVA: 0x03CDE0F0  token: 0x6000571
        public System.Void .ctor() { }
        // RVA: 0x0577DDF4  token: 0x6000572
        private System.Void <OnInit>b__28_0(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        // RVA: 0x0577DE80  token: 0x6000573
        private System.Void <OnInit>b__28_1(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        // RVA: 0x0577DF0C  token: 0x6000574
        private System.Void <OnInit>b__28_2(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        // RVA: 0x0577DF98  token: 0x6000575
        private System.Void <OnInit>b__28_3(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        // RVA: 0x0577E024  token: 0x6000576
        private System.Void <OnInit>b__28_4(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        // RVA: 0x0577E0B8  token: 0x6000577
        private System.Void <OnInit>b__28_5(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0577E0C0  token: 0x6000578
        private System.Void <OnInit>b__28_6(System.Boolean isFocused) { }
        // RVA: 0x0577E0D0  token: 0x6000579
        private System.Void <_OnAnnounceClicked>b__37_0(System.String s) { }
        // RVA: 0x0577D3E8  token: 0x600057A
        public System.Void <>iFixBaseProxy_OnInit() { }
        // RVA: 0x0577E0C8  token: 0x600057B
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000FC  // size: 0x98
    public class LoginMockUIDPanel : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup _canvas;  // 0x18
        private Beyond.UI.UIInputField _userIdInputField;  // 0x20
        private Beyond.UI.UIButton _btnEnterGame;  // 0x28
        private Beyond.UI.UIButton _btnDelLocalFile;  // 0x30
        private Beyond.UI.UIDropdown _serverDropdown;  // 0x38
        private UnityEngine.GameObject _hintSelectServer;  // 0x40
        private Beyond.UI.UIButton _btnClose;  // 0x48
        private Beyond.UI.UIText _selectedServerLabel;  // 0x50
        private System.Boolean m_isInited;  // 0x58
        private Beyond.UI.UISwitchTween m_switchTween;  // 0x60
        private System.Collections.Generic.List<Beyond.Network.ServerDesc> m_serverDescList;  // 0x68
        private Beyond.Network.ServerList m_serverListObj;  // 0x70
        private Beyond.Network.ServerConfig m_serverConfig;  // 0x78
        private System.Action<System.String> m_callback;  // 0x80
        private Beyond.Login.LoginMockUIDPanel.FOptions m_options;  // 0x88
        private static Beyond.Login.LoginMockUIDPanel s_instance;  // static @ 0x0

        // Properties
        Beyond.Login.LoginMockUIDPanel instance { get; /* RVA: 0x05788EC0 */ }

        // Methods
        // RVA: 0x03652EA0  token: 0x6000580
        public System.Void LoginWithCallback(Beyond.Login.LoginMockUIDPanel.FOptions options, System.Action<System.String> callback) { }
        // RVA: 0x05788CC8  token: 0x6000581
        public System.Void Refresh() { }
        // RVA: 0x03652DC0  token: 0x6000582
        public System.Collections.IEnumerator HideAndDestroy() { }
        // RVA: 0x031594C0  token: 0x6000583
        private System.Void _UpdateStatus() { }
        // RVA: 0x0315B0F0  token: 0x6000584
        private System.Void _InitLoginInfo() { }
        // RVA: 0x0315B880  token: 0x6000585
        private System.Void _SaveConfig() { }
        // RVA: 0x03CB7FC0  token: 0x6000586
        private System.Void _OnBtnEnterGame() { }
        // RVA: 0x05788D6C  token: 0x6000587
        private System.Void _SmokeEnterGame(System.String serverName, System.String uid) { }
        // RVA: 0x05788D28  token: 0x6000588
        private System.Void _OnBtnDelLocalFile() { }
        // RVA: 0x05788E24  token: 0x6000589
        private System.Void _TryClosePanel() { }
        // RVA: 0x0315B790  token: 0x600058A
        private System.Void _OnSelectServer(System.Int32 index) { }
        // RVA: 0x03D1EE60  token: 0x600058B
        private System.Void OnDestroy() { }
        // RVA: 0x0426FE60  token: 0x600058C
        public System.Void .ctor() { }
        // RVA: 0x03CB7FB0  token: 0x600058D
        private System.Void <_UpdateStatus>b__22_0(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x05788D18  token: 0x600058E
        private System.Void <_UpdateStatus>b__22_1(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x05788D20  token: 0x600058F
        private System.Void <_UpdateStatus>b__22_2(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x028E1300  token: 0x6000590
        private System.Void <_InitLoginInfo>b__23_0(System.Int32 index, Beyond.UI.UIDropdownOption options, System.Boolean isSelected) { }

    }

    // TypeToken: 0x20000FF  // size: 0x88
    public class LoginResourcePanel : ChildPanel, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private static System.Single PROGRESS_LERP_DURATION;  // const
        private UnityEngine.CanvasGroup _alphaHandler;  // 0x28
        private Beyond.UI.UISlider _progressBar;  // 0x30
        private Beyond.UI.UIText _textTitle;  // 0x38
        private Beyond.UI.UIText _textInfo;  // 0x40
        private Beyond.Login.LoginHotUpdateModel.IProgress m_progress;  // 0x48
        private Beyond.UI.TweenUtils.FLerpByTime m_progressLerper;  // 0x50
        private System.String m_resInfoCache;  // 0x80

        // Methods
        // RVA: 0x02C3D280  token: 0x6000598
        public virtual System.Void OnValueChanged(Beyond.Login.LoginHotUpdateModel value) { }
        // RVA: 0x032F1390  token: 0x6000599
        private System.Void _UpdateResourceInfo() { }
        // RVA: 0x032F1230  token: 0x600059A
        private System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x600059B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000100  // size: 0x60
    public class LoginRootPanel : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.NotchAdapter _notchAdapter;  // 0x18
        private Beyond.Login.LoginMenuPanel _menuPanel;  // 0x20
        private Beyond.Login.LoginAgeTipsPanel _ageTipsPanel;  // 0x28
        private Beyond.Login.LoginGovTipsPanel _govTipsPanel;  // 0x30
        private Beyond.Login.LoginResourcePanel _resPanel;  // 0x38
        private Beyond.Login.LoginEnterGamePanel _enterGamePanel;  // 0x40
        private Beyond.Login.LoginServerSelectPanel _serverSelectPanel;  // 0x48
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroup;  // 0x50
        private System.Int32 m_loginRootBindingGroupId;  // 0x58

        // Methods
        // RVA: 0x03197210  token: 0x600059C
        private System.Void Awake() { }
        // RVA: 0x03197310  token: 0x600059D
        private System.Void OnDestroy() { }
        // RVA: 0x02EA9240  token: 0x600059E
        public System.Void Init(Beyond.LoginContext context) { }
        // RVA: 0x05788F8C  token: 0x600059F
        private System.Void _OnNotchPaddingChanged(Beyond.EventData<System.Single>& data) { }
        // RVA: 0x02EA9F50  token: 0x60005A0
        private System.Void _InitController() { }
        // RVA: 0x05788EF8  token: 0x60005A1
        public System.Void ToggleLoginBindingGroup(System.Boolean enable) { }
        // RVA: 0x02EA9BA0  token: 0x60005A2
        public System.Void InitBulletinAndRedAfterLoginSuc() { }
        // RVA: 0x02EA9330  token: 0x60005A3
        private static System.Void _InitChildPanel(Beyond.Login.LoginRootPanel.ChildPanel childPanel, Beyond.LoginContext context) { }
        // RVA: 0x0426FE60  token: 0x60005A4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000102  // size: 0x68
    public class LoginServerSelectItemView : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _serverName;  // 0x18
        private Beyond.UI.UIImage _playerIcon;  // 0x20
        private Beyond.UI.UIText _playerLevel;  // 0x28
        private Beyond.UI.UIImage[] _delayImages;  // 0x30
        private Beyond.UI.UIText _delayText;  // 0x38
        private Beyond.UI.UIButton _btnSelect;  // 0x40
        private Beyond.UI.UIState.UIStateController _stateController;  // 0x48
        private static readonly UnityEngine.Color DEFAULT_COLOR;  // static @ 0x0
        private static System.String DEFAULT_TEXT;  // const
        private static readonly Beyond.Login.LoginServerSelectItemView.DelayInfo DEFAULT_SPEED_INFO;  // static @ 0x10
        private Beyond.Gameplay.ServerZoneManager.ServerZoneData m_serverItem;  // 0x50
        private Beyond.LoginContext m_context;  // 0x58
        private System.Collections.Generic.List<Beyond.Login.LoginServerSelectItemView.DelayInfo> m_speedInfos;  // 0x60

        // Methods
        // RVA: 0x057890C0  token: 0x60005AF
        public System.Void RefreshView(Beyond.LoginContext context, Beyond.Gameplay.ServerZoneManager.ServerZoneData serverItem, System.Boolean isSelected) { }
        // RVA: 0x05789030  token: 0x60005B0
        public System.Void NaviToBtnTarget() { }
        // RVA: 0x057895C0  token: 0x60005B1
        public System.Void SetSelected(System.Boolean isSelected) { }
        // RVA: 0x05789664  token: 0x60005B2
        private System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x036D52B0  token: 0x60005B3
        public System.Void .ctor() { }
        // RVA: 0x03C8A1C0  token: 0x60005B4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000104  // size: 0x30
    public class LoginServerSelectProp : Beyond.Login.LoginProperty`1
    {
        // Methods
        // RVA: 0x028D45F0  token: 0x60005B5
        public System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }

    }

    // TypeToken: 0x2000105  // size: 0x18
    public class LoginServerItem
    {
        // Fields
        public Beyond.Gameplay.ServerZoneManager.ServerZoneData serverZoneData;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60005B6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000106  // size: 0x18
    public class LoginServerSelectModel
    {
        // Fields
        public System.Boolean showPanel;  // 0x10
        public System.Int32 selectedIndex;  // 0x14

        // Properties
        System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> serverList { get; /* RVA: 0x05789910 */ }
        Beyond.Gameplay.ServerZoneManager.ServerZoneData curServerZoneData { get; /* RVA: 0x057898B8 */ }

        // Methods
        // RVA: 0x05789760  token: 0x60005B9
        public System.Void InitData() { }
        // RVA: 0x057896DC  token: 0x60005BA
        public Beyond.Gameplay.ServerZoneManager.ServerZoneData GetSelectedServer() { }
        // RVA: 0x057897C8  token: 0x60005BB
        public System.Boolean UpdateSelectedServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData selectedServer) { }
        // RVA: 0x03D55820  token: 0x60005BC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000107  // size: 0x68
    public class LoginServerSelectPanel : ChildPanel, Beyond.Login.ILoginBinder`1
    {
        // Fields
        private Beyond.UI.UIButton _btnBack;  // 0x28
        private Beyond.UI.UIButton _btnConfirm;  // 0x30
        private Beyond.UI.UIAnimationWrapper _showAnim;  // 0x38
        private Beyond.UI.UIScrollList _showList;  // 0x40
        private Beyond.UI.UISelectableNaviGroup _naviGroup;  // 0x48
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroup;  // 0x50
        private Beyond.Input.InputBindingGroupMonoTarget _rootPanelBindingGroup;  // 0x58
        private Beyond.Login.LoginServerSelectModel m_viewModel;  // 0x60

        // Methods
        // RVA: 0x03610600  token: 0x60005BD
        protected virtual System.Void OnInit() { }
        // RVA: 0x057899A4  token: 0x60005BE
        private System.Void OnDisable() { }
        // RVA: 0x05789AA8  token: 0x60005BF
        private System.Void OnEnable() { }
        // RVA: 0x0578AA8C  token: 0x60005C0
        private System.Collections.IEnumerator _WaitingForShowListAwake() { }
        // RVA: 0x0578A8C0  token: 0x60005C1
        private System.Void _UpdateServerCell(UnityEngine.GameObject cell, System.Int32 index) { }
        // RVA: 0x0578A9CC  token: 0x60005C2
        private System.Void _UpdateServerSelected(System.Int32 index, UnityEngine.GameObject cell) { }
        // RVA: 0x0578A4CC  token: 0x60005C3
        public virtual System.Void OnValueChanged(Beyond.Login.LoginServerSelectModel value) { }
        // RVA: 0x0578A624  token: 0x60005C4
        private System.Void _NaviToSelectedItem() { }
        // RVA: 0x0578A85C  token: 0x60005C5
        private System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input) { }
        // RVA: 0x0578A76C  token: 0x60005C6
        private System.Void _OnCloseClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0578A7E4  token: 0x60005C7
        private System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0426FE60  token: 0x60005C8
        public System.Void .ctor() { }
        // RVA: 0x0577D3E8  token: 0x60005C9
        public System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x200010A  // size: 0x20
    public class LoginVersionPanel : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _textVersion;  // 0x18

        // Properties
        System.String displayGameVersion { get; /* RVA: 0x0386CE50 */ }
        System.String versionZoneType { get; /* RVA: 0x0386D110 */ }
        System.String versionPlatform { get; /* RVA: 0x0386D020 */ }
        System.String versionAppType { get; /* RVA: 0x0386CFF0 */ }
        System.String versionVersionNum { get; /* RVA: 0x0386D090 */ }
        System.String versionProjectCL { get; /* RVA: 0x0386D050 */ }

        // Methods
        // RVA: 0x0386CDB0  token: 0x60005D3
        private System.Void Start() { }
        // RVA: 0x0426FE60  token: 0x60005DA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010B  // size: 0x70
    public class LoginVocResSelDialog : Dialog
    {
        // Fields
        private Beyond.Login.LoginVocResSelDialog.FParams m_params;  // 0x38
        private Beyond.UI.UIButton _btnConfirm;  // 0x40
        private Beyond.UI.UIScrollList _showList;  // 0x48
        private Beyond.UI.UISelectableNaviGroup _naviGroup;  // 0x50
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroup;  // 0x58
        private System.Collections.Generic.List<Beyond.Login.LoginVocResSelDialog.VocResInfo> m_vocResInfos;  // 0x60
        private System.Int32 m_selectedIndex;  // 0x68

        // Methods
        // RVA: 0x0578AD28  token: 0x60005DB
        protected virtual System.Void OnInit() { }
        // RVA: 0x0578AC20  token: 0x60005DC
        private System.Void OnEnable() { }
        // RVA: 0x0578AB1C  token: 0x60005DD
        private System.Void OnDisable() { }
        // RVA: 0x0578B0A8  token: 0x60005DE
        public System.Void SetParams(Beyond.Login.LoginVocResSelDialog.FParams param) { }
        // RVA: 0x0578B10C  token: 0x60005DF
        public System.Void UpdateSelected(Beyond.VFS.EVFSBlockType type) { }
        // RVA: 0x0578B6B0  token: 0x60005E0
        private System.Void _UpdateList() { }
        // RVA: 0x0578B770  token: 0x60005E1
        private System.Void _UpdateSelected(System.Int32 index, UnityEngine.GameObject cell) { }
        // RVA: 0x0578B5D0  token: 0x60005E2
        private System.Void _UpdateCell(UnityEngine.GameObject cell, System.Int32 index) { }
        // RVA: 0x0578B4B8  token: 0x60005E3
        private System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        // RVA: 0x0578B330  token: 0x60005E4
        private System.Void _OnConfirmClicked() { }
        // RVA: 0x0578B56C  token: 0x60005E5
        private System.Void _OnInputTypeChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& data) { }
        // RVA: 0x0578B200  token: 0x60005E6
        private System.Void _NaviToSelectedItem() { }
        // RVA: 0x0426FE60  token: 0x60005E7
        public System.Void .ctor() { }
        // RVA: 0x0577D748  token: 0x60005E8
        public System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x200010E  // size: 0x48
    public class LoginVocResSelItemView : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _name;  // 0x18
        private Beyond.UI.UIText _size;  // 0x20
        private Beyond.UI.UIButton _btnSelect;  // 0x28
        private Beyond.UI.UIState.UIStateController _stateController;  // 0x30
        private Beyond.Login.LoginVocResSelDialog.VocResInfo m_info;  // 0x38
        private Beyond.Login.LoginVocResSelDialog m_context;  // 0x40
        private static System.Double MB;  // const

        // Methods
        // RVA: 0x0578B8B0  token: 0x60005EA
        public System.Void RefreshView(Beyond.Login.LoginVocResSelDialog context, Beyond.Login.LoginVocResSelDialog.VocResInfo info, System.Boolean isSelected) { }
        // RVA: 0x0578B820  token: 0x60005EB
        public System.Void NaviToBtnTarget() { }
        // RVA: 0x0578BB98  token: 0x60005EC
        public System.Void SetSelected(System.Boolean isSelected) { }
        // RVA: 0x0578BC3C  token: 0x60005ED
        private System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _) { }
        // RVA: 0x0426FE60  token: 0x60005EE
        public System.Void .ctor() { }

    }

}

namespace Beyond.SDK
{

    // TypeToken: 0x2000052  // size: 0x10
    public class PlatformFont : Hypergryph.PlatformFacade.IPlatformFont
    {
        // Fields
        private static System.Int32 DEFAULT_FONT_ID;  // const

        // Methods
        // RVA: 0x0576EBF0  token: 0x60001B6
        public virtual TMPro.TMP_FontAsset GetFont() { }
        // RVA: 0x0350B670  token: 0x60001B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x10
    public static class SDKNetUtils
    {
        // Fields
        public static System.String CONTENT_TYPE_JSON;  // const
        private static System.Int32 GENERAL_TIMEOUT;  // const
        private static Beyond.SDK.SDKNetUtils.HTTPImpl s_HTTPImpl;  // static @ 0x0

        // Methods
        // RVA: 0x0576EDC4  token: 0x60001B8
        public static System.Void HTTPPost(Beyond.SDK.SDKNetUtils.HttpPostRequest request) { }
        // RVA: 0x0576EC6C  token: 0x60001B9
        public static System.Void HTTPGet(Beyond.SDK.SDKNetUtils.HttpGetRequest request) { }
        // RVA: 0x0576EFB0  token: 0x60001BA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005C  // size: 0x10
    public static class SDKTextDefines
    {
        // Fields
        public static System.String CS_SDK_STO_DESC;  // const
        public static System.String CS_SDK_COMMON_ERROR;  // const
        public static System.String CS_SDK_CREATE_ORDER_ERROR;  // const
        public static System.String CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT;  // const
        public static System.String CS_SDK_USR_BAN;  // const
        public static System.String CS_SDK_USR_BAN_TIME;  // const
        public static System.String CS_SDK_LOGIN_FORBID;  // const
        public static System.String CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT;  // const
        public static System.String CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR;  // const
        public static System.String CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID;  // const

    }

}

namespace Beyond.SDK.Impl
{

    // TypeToken: 0x200005D  // size: 0x28
    public class U8ExternalTools : U8.SDK.SDKExternalToolsShortcut
    {
        // Fields
        private static System.Boolean s_inited;  // static @ 0x0
        private static System.Boolean s_initing;  // static @ 0x1
        private static System.Boolean s_needRetry;  // static @ 0x2
        private static System.Boolean s_needQuitGame;  // static @ 0x3
        private static Beyond.SDK.Impl.U8ExternalTools.FHGSDKInit s_initHGSDK;  // static @ 0x4

        // Methods
        // RVA: 0x05770CB8  token: 0x60001C5
        public static System.Boolean IsInited() { }
        // RVA: 0x02D77A20  token: 0x60001C6
        public static System.Boolean NeedRetryInit() { }
        // RVA: 0x03A94040  token: 0x60001C7
        public static System.Boolean NeedQuitGame() { }
        // RVA: 0x05771098  token: 0x60001C8
        public static System.Void RetryInitSDKSystem(System.String env) { }
        // RVA: 0x03CF20E0  token: 0x60001C9
        public static System.Void PublicSetGameVersion(System.String version) { }
        // RVA: 0x038E3210  token: 0x60001CA
        public static System.Void InitSDKSystem(System.String env) { }
        // RVA: 0x03A93FE0  token: 0x60001CB
        public static System.Collections.IEnumerator WaitForInited() { }
        // RVA: 0x02D78AA0  token: 0x60001CC
        public static System.Void InitHGSDK(System.String env) { }
        // RVA: 0x05770C4C  token: 0x60001CD
        public static System.Boolean IsHGSDKInited() { }
        // RVA: 0x02954F30  token: 0x60001CE
        public static System.Collections.IEnumerator WaitForInitHGSDK() { }
        // RVA: 0x05770E04  token: 0x60001CF
        protected virtual System.Void Log(System.String content) { }
        // RVA: 0x05770D24  token: 0x60001D0
        protected virtual System.Void LogError(System.String content) { }
        // RVA: 0x05770DB0  token: 0x60001D1
        protected virtual System.Void LogWarning(System.String content) { }
        // RVA: 0x05770BE0  token: 0x60001D2
        protected virtual System.String GetSignKey() { }
        // RVA: 0x05770874  token: 0x60001D3
        public virtual System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs() { }
        // RVA: 0x05771138  token: 0x60001D4
        public System.Void SetSubChannel(System.String subChannel) { }
        // RVA: 0x05770B68  token: 0x60001D5
        protected virtual System.Int32 GetPlatformKey() { }
        // RVA: 0x026922A0  token: 0x60001D6
        public virtual System.Void OnSDKExtraInfo(System.String jsonData) { }
        // RVA: 0x057711A4  token: 0x60001D7
        protected virtual System.String U8RootUrl() { }
        // RVA: 0x05770E58  token: 0x60001D8
        protected virtual System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback) { }
        // RVA: 0x05771234  token: 0x60001D9
        private static U8.SDK.SDKExternalTools.POSTResult _ConvertToPOSTResult(Beyond.SDK.SDKNetUtils.WebHttpResponse response) { }
        // RVA: 0x02692800  token: 0x60001DA
        private System.Void _ProcessExtraInfo(U8.SDK.SDKExtraData extraData) { }
        // RVA: 0x05771720  token: 0x60001DB
        private static System.Void _OnRequestExitGame() { }
        // RVA: 0x057716E0  token: 0x60001DC
        private static System.Void _OnFakeAccountCenter() { }
        // RVA: 0x057707F8  token: 0x60001DD
        protected virtual U8.SDK.SDKCaptchaHandler CreateCaptchaHandler() { }
        // RVA: 0x057709A8  token: 0x60001DE
        protected virtual System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta) { }
        // RVA: 0x057714D8  token: 0x60001DF
        private System.Boolean _ErrorMsg_GET_TOKEN(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg) { }
        // RVA: 0x05771338  token: 0x60001E0
        private System.Boolean _ErrorMsg_CREATE_ORDER(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg) { }
        // RVA: 0x03D42B70  token: 0x60001E1
        public System.Void .ctor() { }
        // RVA: 0x01002730  token: 0x60001E2
        public System.String <>iFixBaseProxy_GetSignKey() { }
        // RVA: 0x0577119C  token: 0x60001E3
        public System.Collections.Generic.Dictionary<System.String,System.String> <>iFixBaseProxy_GetDeviceIDs() { }
        // RVA: 0x0350B670  token: 0x60001E4
        public System.Void <>iFixBaseProxy_OnSDKExtraInfo(System.String P0) { }

    }

    // TypeToken: 0x2000065  // size: 0x10
    public class U8Plugin : U8.SDK.IExternalPlugin
    {
        // Methods
        // RVA: 0x0577B938  token: 0x6000201
        public virtual System.String GetPayAddition() { }
        // RVA: 0x0577B984  token: 0x6000202
        public virtual System.String GetSDKToken() { }
        // RVA: 0x0577B9D0  token: 0x6000203
        public virtual System.String GetSDKUid() { }
        // RVA: 0x039CAD40  token: 0x6000204
        public virtual System.Void Init() { }
        // RVA: 0x02D775D0  token: 0x6000205
        public virtual System.Void Login(U8.SDK.ExternalPluginLoginParams args) { }
        // RVA: 0x0577BA1C  token: 0x6000206
        public virtual System.Void Logout(U8.SDK.ExternalPluginLogoutParams args) { }
        // RVA: 0x0577BAA4  token: 0x6000207
        public virtual System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        // RVA: 0x0577BAF8  token: 0x6000208
        public virtual System.Void Pay(U8.SDK.ExternalPluginPayParams args) { }
        // RVA: 0x0577BCDC  token: 0x6000209
        public virtual System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta) { }
        // RVA: 0x02D776A0  token: 0x600020A
        private static System.Boolean _UseMockVersion() { }
        // RVA: 0x02EA87D0  token: 0x600020B
        private System.Void _MockLogin(U8.SDK.ExternalPluginLoginParams args) { }
        // RVA: 0x0350B670  token: 0x600020C
        public System.Void .ctor() { }

    }

}

namespace Beyond.Scripts.Entry
{

    // TypeToken: 0x200010F  // size: 0x10
    public static class GameSettingSetter
    {
        // Fields
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioGlobalVolume>k__BackingField;  // static @ 0x0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioMusicVolume>k__BackingField;  // static @ 0x8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioVoiceVolume>k__BackingField;  // static @ 0x10
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioSfxVolume>k__BackingField;  // static @ 0x18
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioSuspendUnfocused>k__BackingField;  // static @ 0x20
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioBackgroundMusic>k__BackingField;  // static @ 0x28
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> <audioSuiteMode>k__BackingField;  // static @ 0x30
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioController>k__BackingField;  // static @ 0x38
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioSpatial>k__BackingField;  // static @ 0x40
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerCameraSpeedX>k__BackingField;  // static @ 0x48
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerCameraSpeedY>k__BackingField;  // static @ 0x50
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerCameraTopViewSpeed>k__BackingField;  // static @ 0x58
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerWalkRunRatio>k__BackingField;  // static @ 0x60
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <cameraDistanceLevel>k__BackingField;  // static @ 0x68
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> <cameraImpulseLevel>k__BackingField;  // static @ 0x70
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerCameraReverseX>k__BackingField;  // static @ 0x78
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerCameraReverseY>k__BackingField;  // static @ 0x80
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> <controllerAutoLockTarget>k__BackingField;  // static @ 0x88
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> <comboSkillCameraAlpha>k__BackingField;  // static @ 0x90
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerAutoSprint>k__BackingField;  // static @ 0x98
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerMotion>k__BackingField;  // static @ 0xa0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerTriggerEffect>k__BackingField;  // static @ 0xa8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <enableAutoAttackTouch>k__BackingField;  // static @ 0xb0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <enableAutoAttackGamepad>k__BackingField;  // static @ 0xb8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> <languageText>k__BackingField;  // static @ 0xc0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> <languageAudio>k__BackingField;  // static @ 0xc8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> <graphicsQuality>k__BackingField;  // static @ 0xd0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <graphicsFullScreen>k__BackingField;  // static @ 0xd8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> <graphicsResolution>k__BackingField;  // static @ 0xe0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <graphicsNotchPadding>k__BackingField;  // static @ 0xe8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <otherShowSmartAlert>k__BackingField;  // static @ 0xf0
        public static System.Boolean s_stageInitFinished;  // static @ 0xf8

        // Properties
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> audioGlobalVolume { get; /* RVA: 0x057831D8 */ set; /* RVA: 0x05783914 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> audioMusicVolume { get; /* RVA: 0x05783210 */ set; /* RVA: 0x05783964 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> audioVoiceVolume { get; /* RVA: 0x05783328 */ set; /* RVA: 0x05783B08 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> audioSfxVolume { get; /* RVA: 0x05783248 */ set; /* RVA: 0x057839B8 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> audioSuspendUnfocused { get; /* RVA: 0x057832F0 */ set; /* RVA: 0x05783AB4 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> audioBackgroundMusic { get; /* RVA: 0x05783168 */ set; /* RVA: 0x0578386C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> audioSuiteMode { get; /* RVA: 0x057832B8 */ set; /* RVA: 0x05783A60 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> audioController { get; /* RVA: 0x057831A0 */ set; /* RVA: 0x057838C0 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> audioSpatial { get; /* RVA: 0x05783280 */ set; /* RVA: 0x05783A0C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> controllerCameraSpeedX { get; /* RVA: 0x057834F8 */ set; /* RVA: 0x05783DC4 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> controllerCameraSpeedY { get; /* RVA: 0x05783530 */ set; /* RVA: 0x05783E18 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> controllerCameraTopViewSpeed { get; /* RVA: 0x05783568 */ set; /* RVA: 0x05783E6C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> controllerWalkRunRatio { get; /* RVA: 0x05783618 */ set; /* RVA: 0x05783F78 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> cameraDistanceLevel { get; /* RVA: 0x05783360 */ set; /* RVA: 0x05783B5C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> cameraImpulseLevel { get; /* RVA: 0x05783398 */ set; /* RVA: 0x05783BB0 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> controllerCameraReverseX { get; /* RVA: 0x05783484 */ set; /* RVA: 0x05783D18 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> controllerCameraReverseY { get; /* RVA: 0x057834BC */ set; /* RVA: 0x05783D6C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> controllerAutoLockTarget { get; /* RVA: 0x0578340C */ set; /* RVA: 0x05783C60 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> comboSkillCameraAlpha { get; /* RVA: 0x057833D0 */ set; /* RVA: 0x05783C04 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> controllerAutoSprint { get; /* RVA: 0x05783448 */ set; /* RVA: 0x05783CBC */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> controllerMotion { get; /* RVA: 0x057835A0 */ set; /* RVA: 0x05783EC0 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> controllerTriggerEffect { get; /* RVA: 0x057835DC */ set; /* RVA: 0x05783F1C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> enableAutoAttackTouch { get; /* RVA: 0x0578368C */ set; /* RVA: 0x05784028 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> enableAutoAttackGamepad { get; /* RVA: 0x05783650 */ set; /* RVA: 0x05783FCC */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> languageText { get; /* RVA: 0x057837F4 */ set; /* RVA: 0x05784250 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> languageAudio { get; /* RVA: 0x057837B8 */ set; /* RVA: 0x057841F4 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> graphicsQuality { get; /* RVA: 0x05783740 */ set; /* RVA: 0x0578413C */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> graphicsFullScreen { get; /* RVA: 0x057836C8 */ set; /* RVA: 0x05784084 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> graphicsResolution { get; /* RVA: 0x0578377C */ set; /* RVA: 0x05784198 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> graphicsNotchPadding { get; /* RVA: 0x05783704 */ set; /* RVA: 0x057840E0 */ }
        Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> otherShowSmartAlert { get; /* RVA: 0x05783830 */ set; /* RVA: 0x057842AC */ }

        // Methods
        // RVA: 0x02DF66E0  token: 0x600062D
        public static System.Void InitSetterItems() { }
        // RVA: 0x038BF640  token: 0x600062E
        private static System.Void _OnAudioGlobalVolumeChange(System.Single volume) { }
        // RVA: 0x038BF5D0  token: 0x600062F
        private static System.Void _OnAudioMusicVolumeChange(System.Single volume) { }
        // RVA: 0x038BF560  token: 0x6000630
        private static System.Void _OnAudioVoiceVolumeChange(System.Single volume) { }
        // RVA: 0x03D06600  token: 0x6000631
        private static System.Void _OnAudioSfxVolumeChange(System.Single volume) { }
        // RVA: 0x03CB7310  token: 0x6000632
        private static System.Void _OnAudioSuspendUnfocusedChange(System.Boolean suspendUnfocused) { }
        // RVA: 0x05782EC4  token: 0x6000633
        private static System.Void _OnAudioBackgroundMusicChange(System.Boolean enable) { }
        // RVA: 0x02EA2F10  token: 0x6000634
        private static System.Void _OnAudioSuiteModeChange(Beyond.GameSetting.GameSettingAudioSuiteMode mode) { }
        // RVA: 0x02A01010  token: 0x6000635
        private static System.Void _OnAudioControllerChange(System.Boolean enable) { }
        // RVA: 0x02A00FA0  token: 0x6000636
        private static System.Void _OnAudioSpatialAudioChange(System.Boolean enable) { }
        // RVA: 0x038BF490  token: 0x6000637
        private static System.Void _OnControllerCameraSpeedXChange(System.Single cameraSpeed) { }
        // RVA: 0x038BF3C0  token: 0x6000638
        private static System.Void _OnControllerCameraSpeedYChange(System.Single cameraSpeed) { }
        // RVA: 0x03CDCF60  token: 0x6000639
        private static System.Void _OnControllerCameraTopViewSpeedChange(System.Single cameraSpeed) { }
        // RVA: 0x038BF2F0  token: 0x600063A
        private static System.Void _OnControllerWalkRunRatioChange(System.Single walkRunRatio) { }
        // RVA: 0x03C7F390  token: 0x600063B
        private static System.Void _OnCameraDistanceLevelChange(System.Single distance) { }
        // RVA: 0x02952D20  token: 0x600063C
        private static System.Void _OnCameraImpulseLevelChange(Beyond.GameSetting.CameraImpulseLevel level) { }
        // RVA: 0x02A01390  token: 0x600063D
        private static System.Void _OnControllerCameraReverseXChange(System.Boolean isReverse) { }
        // RVA: 0x02A012F0  token: 0x600063E
        private static System.Void _OnControllerCameraReverseYChange(System.Boolean isReverse) { }
        // RVA: 0x02952C80  token: 0x600063F
        private static System.Void _OnControllerAutoLockTargetChange(Beyond.GameSetting.GameSettingControllerAutoLockTarget mode) { }
        // RVA: 0x02952BE0  token: 0x6000640
        private static System.Void _OnComboSkillCameraAlphaChange(Beyond.GameSetting.ComboSkillCameraAlpha alpha) { }
        // RVA: 0x05782F14  token: 0x6000641
        private static System.Void _OnControllerAutoSprintChange(System.Boolean valid) { }
        // RVA: 0x02A014D0  token: 0x6000642
        private static System.Void _OnControllerMotionChange(System.Boolean valid) { }
        // RVA: 0x02A01250  token: 0x6000643
        private static System.Void _OnControllerTriggerEffectChange(System.Boolean enable) { }
        // RVA: 0x05782FBC  token: 0x6000644
        private static System.Void _OnEnableAutoAttackTouchChange(System.Boolean enable) { }
        // RVA: 0x02A011B0  token: 0x6000645
        private static System.Void _OnEnableAutoAttackGamepadChange(System.Boolean enable) { }
        // RVA: 0x02954590  token: 0x6000646
        private static System.Void _OnLanguageTextChange(Beyond.GEnums.EnvLang language) { }
        // RVA: 0x02952DC0  token: 0x6000647
        private static System.Void _OnLanguageAudioChange(Beyond.GameSetting.GameSettingLanguageAudio language) { }
        // RVA: 0x057830EC  token: 0x6000648
        private static System.Void _OnGraphicsQualityChange(Beyond.GameSetting.GameSettingVideoQuality quality) { }
        // RVA: 0x05783064  token: 0x6000649
        private static System.Void _OnGraphicsFullScreenChanged(System.Boolean fullScreen) { }
        // RVA: 0x036366C0  token: 0x600064A
        private static System.Void _OnGraphicsResolutionChange(System.Int32 width, System.Int32 height) { }
        // RVA: 0x03637410  token: 0x600064B
        private static System.Void _SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullScreen) { }
        // RVA: 0x02E3B730  token: 0x600064C
        private static System.Void _OnGraphicsNotchPaddingChange(System.Single notchPadding) { }
        // RVA: 0x02A01110  token: 0x600064D
        private static System.Void _OnOtherShowSmartAlertChange(System.Boolean show) { }

    }

    // TypeToken: 0x2000112  // size: 0x10
    public class WarmUpProgress : IProgress
    {
        // Methods
        // RVA: 0x0578C380  token: 0x6000653
        public virtual System.Double GetTotal() { }
        // RVA: 0x0578C284  token: 0x6000654
        public virtual System.Double GetCurrent() { }
        // RVA: 0x0578C314  token: 0x6000655
        public virtual System.String GetInfo() { }
        // RVA: 0x0350B670  token: 0x6000656
        public System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000046  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000191
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000047  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000192
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000048  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000193
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000194
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004A  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000195
        public System.Void .ctor() { }

    }

}

namespace Beyond.UI
{

    // TypeToken: 0x200004B  // size: 0x80
    public class SplashController : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.String CURSOR_KEY_SPLASH;  // const
        private static System.String SPLASH_RESOURCES_PATH;  // const
        private System.Single _initialFadeTime;  // 0x18
        private System.Single _regularFadeTime;  // 0x1c
        private System.Single _showTime;  // 0x20
        private UnityEngine.UI.Image _blackCoverImage;  // 0x28
        private UnityEngine.UI.Image _splashImage;  // 0x30
        private Beyond.UI.SplashController.SplashConfigs _splashConfigsCN;  // 0x38
        private Beyond.UI.SplashController.SplashConfigs _splashConfigsOS;  // 0x50
        private DG.Tweening.Sequence m_tween;  // 0x68
        private System.Action m_onComplete;  // 0x70
        private System.Boolean m_skipLicense;  // 0x78
        private static System.Boolean s_isPlaying;  // static @ 0x0
        private System.Boolean m_canBeHide;  // 0x79
        private static Beyond.UI.SplashController <instance>k__BackingField;  // static @ 0x8

        // Properties
        Beyond.UI.SplashController instance { get; /* RVA: 0x0576F020 */ set; /* RVA: 0x0576F090 */ }
        System.Boolean isPlaying { get; /* RVA: 0x0576F058 */ }

        // Methods
        // RVA: 0x0229EA10  token: 0x6000199
        public static Beyond.UI.SplashController Show(System.Action onComplete, System.Boolean skipLicense) { }
        // RVA: 0x0229E930  token: 0x600019A
        public static System.Void Hide() { }
        // RVA: 0x0229E8A0  token: 0x600019B
        public static System.Void CanFinished() { }
        // RVA: 0x0229E570  token: 0x600019C
        private System.Void Awake() { }
        // RVA: 0x0229E600  token: 0x600019D
        private System.Void OnDestroy() { }
        // RVA: 0x02EA8B00  token: 0x600019E
        private System.Void _Play(System.Action onComplete, System.Boolean skipLicense) { }
        // RVA: 0x03C81D30  token: 0x600019F
        private System.Void _Stop() { }
        // RVA: 0x02EA8C10  token: 0x60001A0
        private Beyond.UI.SplashController.SplashConfig[] _GetSplashConfigs() { }
        // RVA: 0x02D4CE30  token: 0x60001A1
        private System.Void _DoStartSplash(Beyond.UI.SplashController.SplashConfig[] splashConfigs) { }
        // RVA: 0x03C7D880  token: 0x60001A2
        private System.Void _OnTweenFinished() { }
        // RVA: 0x03C7D8E0  token: 0x60001A3
        private System.Collections.IEnumerator _OnSplashCompleteCoroutine() { }
        // RVA: 0x0229E510  token: 0x60001A4
        private System.Collections.IEnumerator _StartLicenseCoroutine() { }
        // RVA: 0x03D2D710  token: 0x60001A5
        public System.Void .ctor() { }
        // RVA: 0x03D1B9E0  token: 0x60001A6
        private System.Void <_DoStartSplash>b__31_1() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000115  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000657
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x0549D548  token: 0x6000658
        public System.Void __Gen_Wrap_0(System.Object P0, Beyond.GameState P1) { }
        // RVA: 0x05784998  token: 0x6000659
        public System.Void __Gen_Wrap_1(System.Single P0) { }
        // RVA: 0x0514F660  token: 0x600065A
        public System.Void __Gen_Wrap_2(System.Boolean P0) { }
        // RVA: 0x0514E3FC  token: 0x600065B
        public System.Void __Gen_Wrap_3(Beyond.GameSetting.GameSettingAudioSuiteMode P0) { }
        // RVA: 0x0514E3FC  token: 0x600065C
        public System.Void __Gen_Wrap_4(Beyond.GameSetting.CameraImpulseLevel P0) { }
        // RVA: 0x0514E3FC  token: 0x600065D
        public System.Void __Gen_Wrap_5(Beyond.GameSetting.GameSettingControllerAutoLockTarget P0) { }
        // RVA: 0x0514E3FC  token: 0x600065E
        public System.Void __Gen_Wrap_6(Beyond.GameSetting.ComboSkillCameraAlpha P0) { }
        // RVA: 0x0514E3FC  token: 0x600065F
        public System.Void __Gen_Wrap_7(Beyond.GEnums.EnvLang P0) { }
        // RVA: 0x0514E3FC  token: 0x6000660
        public System.Void __Gen_Wrap_8(Beyond.GameSetting.GameSettingLanguageAudio P0) { }
        // RVA: 0x050EE9C4  token: 0x6000661
        public System.Void __Gen_Wrap_9(Beyond.GameSetting.GameSettingVideoQuality P0) { }
        // RVA: 0x05784400  token: 0x6000662
        public System.Void __Gen_Wrap_10(System.Int32 P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x056458FC  token: 0x6000663
        public System.Void __Gen_Wrap_11(System.Int32 P0, System.Int32 P1) { }
        // RVA: 0x050F3444  token: 0x6000664
        public System.Void __Gen_Wrap_12() { }
        // RVA: 0x04274234  token: 0x6000665
        public System.Void __Gen_Wrap_13(System.Object P0) { }
        // RVA: 0x057844F8  token: 0x6000666
        public Beyond.UI.SplashController.SplashConfig[] __Gen_Wrap_14(System.Object P0) { }
        // RVA: 0x057845D4  token: 0x6000667
        public System.Collections.IEnumerator __Gen_Wrap_15(System.Object P0) { }
        // RVA: 0x05163BA0  token: 0x6000668
        public System.Void __Gen_Wrap_16(System.Object P0, System.Object P1) { }
        // RVA: 0x057846C4  token: 0x6000669
        public System.Void __Gen_Wrap_17(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x057847A8  token: 0x600066A
        public Beyond.UI.SplashController __Gen_Wrap_18(System.Object P0, System.Boolean P1) { }
        // RVA: 0x057848A0  token: 0x600066B
        public System.Void __Gen_Wrap_19(Beyond.EventData<System.Boolean,System.Boolean>& P0) { }
        // RVA: 0x05477860  token: 0x600066C
        public System.Void __Gen_Wrap_20(System.Object P0, System.Boolean P1) { }
        // RVA: 0x0514E3FC  token: 0x600066D
        public System.Void __Gen_Wrap_21(System.Int32 P0) { }
        // RVA: 0x05784A58  token: 0x600066E
        public System.Boolean __Gen_Wrap_22(System.Object P0, Beyond.Resource.HotUpdate.LocalResPref& P1, Beyond.VFS.VirtualFileSystem.BlockValidator& P2) { }
        // RVA: 0x05784BE0  token: 0x600066F
        public System.Void __Gen_Wrap_23(System.Object P0, Beyond.VFS.VirtualFileSystem.BlockValidator& P1) { }
        // RVA: 0x0514F380  token: 0x6000670
        public System.Boolean __Gen_Wrap_24() { }
        // RVA: 0x0514EF5C  token: 0x6000671
        public System.Boolean __Gen_Wrap_25(System.Object P0) { }
        // RVA: 0x05784D08  token: 0x6000672
        public System.Void __Gen_Wrap_26(System.Object P0, Beyond.EventData<Beyond.DeviceInfo.InputType>& P1) { }
        // RVA: 0x05784E1C  token: 0x6000673
        public Beyond.LoginController.MaskCtrl __Gen_Wrap_27(System.Object P0) { }
        // RVA: 0x05784F0C  token: 0x6000674
        public Beyond.UI.UISwitchTween __Gen_Wrap_28(System.Object P0, System.Int32 P1) { }
        // RVA: 0x05785018  token: 0x6000675
        public System.Collections.IEnumerator __Gen_Wrap_29(System.Object P0, System.Object P1) { }
        // RVA: 0x05785124  token: 0x6000676
        public System.Void __Gen_Wrap_30(System.Object P0, System.Object P1, Beyond.LoginController.EMaskType P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x05785238  token: 0x6000677
        public Beyond.UI.UIAnimationLayerMixPlayer __Gen_Wrap_31(System.Object P0) { }
        // RVA: 0x05785328  token: 0x6000678
        public System.Void __Gen_Wrap_32(System.Object P0, Beyond.LoginController.FOptions P1) { }
        // RVA: 0x05785438  token: 0x6000679
        public Beyond.Login.LoginWorkFlow.FWork __Gen_Wrap_33() { }
        // RVA: 0x0560DC74  token: 0x600067A
        public System.Boolean __Gen_Wrap_34(Beyond.Login.LoginWorkFlow.ENode P0, Beyond.Login.LoginWorkFlow.ENode P1) { }
        // RVA: 0x0514DE88  token: 0x600067B
        public System.Boolean __Gen_Wrap_35(Beyond.Login.LoginWorkFlow.ENode P0) { }
        // RVA: 0x0578552C  token: 0x600067C
        public System.Collections.IEnumerator __Gen_Wrap_36(Beyond.Login.LoginWorkFlow.ENode P0) { }
        // RVA: 0x05785618  token: 0x600067D
        public UnityEngine.CustomYieldInstruction __Gen_Wrap_37(System.Object P0) { }
        // RVA: 0x05785708  token: 0x600067E
        public System.Boolean __Gen_Wrap_38(Beyond.Login.LoginWorkFlow.FWork& P0) { }
        // RVA: 0x0578585C  token: 0x600067F
        public System.Void __Gen_Wrap_39(Beyond.Login.LoginWorkFlow.FWork& P0) { }
        // RVA: 0x057859A0  token: 0x6000680
        public System.Void __Gen_Wrap_40(System.Object P0, Beyond.Login.LoginAlertDialog.FParams P1) { }
        // RVA: 0x05785AA0  token: 0x6000681
        public System.Void __Gen_Wrap_41(System.Object P0, Beyond.Login.LoginVocResSelDialog.FParams P1) { }
        // RVA: 0x05785BA0  token: 0x6000682
        public System.Void __Gen_Wrap_42(System.Object P0, Beyond.Login.LoginJudgeDialog.FParams P1) { }
        // RVA: 0x05785CC4  token: 0x6000683
        public System.Void __Gen_Wrap_43(Beyond.Login.LoginAlertDialog P0, Beyond.Login.LoginAlertDialog.FParams P1) { }
        // RVA: 0x05150B1C  token: 0x6000684
        public System.Void __Gen_Wrap_44(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x05785DC4  token: 0x6000685
        public System.Void __Gen_Wrap_45(System.Object P0, System.Boolean P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7, System.Object P8) { }
        // RVA: 0x05785F1C  token: 0x6000686
        public System.Collections.IEnumerator __Gen_Wrap_46(System.Object P0, System.Boolean P1) { }
        // RVA: 0x05786028  token: 0x6000687
        public System.Boolean __Gen_Wrap_47(System.Object P0, Beyond.Login.LoginWorkFlow.ENode& P1) { }
        // RVA: 0x0514E3FC  token: 0x6000688
        public System.Void __Gen_Wrap_48(Beyond.GameState P0) { }
        // RVA: 0x050F0008  token: 0x6000689
        public System.Void __Gen_Wrap_49(System.Object P0, System.Single P1) { }
        // RVA: 0x054AB08C  token: 0x600068A
        public System.Single __Gen_Wrap_50(System.Object P0) { }
        // RVA: 0x05786134  token: 0x600068B
        public Beyond.LoginController __Gen_Wrap_51(System.Object P0) { }
        // RVA: 0x05625660  token: 0x600068C
        public System.Void __Gen_Wrap_52(System.Object P0, System.Object P1, System.Single P2) { }
        // RVA: 0x05786224  token: 0x600068D
        public System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> __Gen_Wrap_53(System.Object P0) { }
        // RVA: 0x05153920  token: 0x600068E
        public System.Boolean __Gen_Wrap_54(System.Object P0, System.Object P1) { }
        // RVA: 0x05786314  token: 0x600068F
        public Beyond.Gameplay.ServerZoneManager.ServerZoneData __Gen_Wrap_55(System.Object P0) { }
        // RVA: 0x05786404  token: 0x6000690
        public System.Boolean __Gen_Wrap_56(System.Object P0, Beyond.ELoginEvent P1, System.Object P2) { }
        // RVA: 0x0514F720  token: 0x6000691
        public System.Void __Gen_Wrap_57(System.Object P0, Beyond.ELoginEvent P1, System.Object P2) { }
        // RVA: 0x050EE850  token: 0x6000692
        public System.Void __Gen_Wrap_58(System.String P0) { }
        // RVA: 0x050EE850  token: 0x6000693
        public System.Void __Gen_Wrap_59(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x05786508  token: 0x6000694
        public System.Boolean __Gen_Wrap_60(Beyond.Login.LoginMockUIDPanel.FOptions& P0) { }
        // RVA: 0x050F1438  token: 0x6000695
        public System.Void __Gen_Wrap_61(System.Int32 P0, Beyond.UI.UIDropdownOption P1, System.Boolean P2) { }
        // RVA: 0x0549D548  token: 0x6000696
        public System.Void __Gen_Wrap_62(System.Object P0, System.Int32 P1) { }
        // RVA: 0x05786654  token: 0x6000697
        public System.Void __Gen_Wrap_63(System.Object P0, Beyond.Login.LoginMockUIDPanel.FOptions P1, System.Object P2) { }
        // RVA: 0x05786780  token: 0x6000698
        public Beyond.UI.UISwitchTween __Gen_Wrap_64(System.Object P0) { }
        // RVA: 0x0548C780  token: 0x6000699
        public System.Boolean __Gen_Wrap_65(System.Object P0, Beyond.LoginController.EMaskType P1) { }
        // RVA: 0x05786870  token: 0x600069A
        public System.Void __Gen_Wrap_66(Beyond.Login.LoginVocResSelDialog P0, Beyond.Login.LoginVocResSelDialog.FParams P1) { }
        // RVA: 0x05786970  token: 0x600069B
        public System.Collections.IEnumerator __Gen_Wrap_67(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x05786AA8  token: 0x600069C
        public System.Void __Gen_Wrap_68(Beyond.Login.LoginJudgeDialog P0, Beyond.Login.LoginJudgeDialog.FParams P1) { }
        // RVA: 0x05496D84  token: 0x600069D
        public System.Void __Gen_Wrap_69(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x05786BB8  token: 0x600069E
        public System.String __Gen_Wrap_70(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x05786CE0  token: 0x600069F
        public System.Void __Gen_Wrap_71(System.Boolean& P0) { }
        // RVA: 0x05786DB4  token: 0x60006A0
        public System.Void __Gen_Wrap_72(System.Object P0, System.Boolean& P1) { }
        // RVA: 0x05786EA4  token: 0x60006A1
        public System.Void __Gen_Wrap_73(System.Object P0, Beyond.LoginManager.FFlowWithMask P1) { }
        // RVA: 0x05786FC8  token: 0x60006A2
        public System.Boolean __Gen_Wrap_74(Beyond.LoginManager.FFlowCondition& P0, Beyond.Login.LoginWorkFlow.ENode P1) { }
        // RVA: 0x0578711C  token: 0x60006A3
        public System.Collections.IEnumerator __Gen_Wrap_75(System.Object P0, Beyond.LoginManager.FFlowWithMask P1) { }
        // RVA: 0x0578725C  token: 0x60006A4
        public TMPro.TMP_FontAsset __Gen_Wrap_76(System.Object P0) { }
        // RVA: 0x05787338  token: 0x60006A5
        public System.Void __Gen_Wrap_77(Beyond.SDK.SDKNetUtils.HttpPostRequest P0) { }
        // RVA: 0x0578742C  token: 0x60006A6
        public System.Void __Gen_Wrap_78(Beyond.SDK.SDKNetUtils.HttpGetRequest P0) { }
        // RVA: 0x05787510  token: 0x60006A7
        public System.Collections.IEnumerator __Gen_Wrap_79(System.Object P0, Beyond.SDK.SDKNetUtils.HTTPConfig P1) { }
        // RVA: 0x05787640  token: 0x60006A8
        public System.Collections.IEnumerator __Gen_Wrap_80() { }
        // RVA: 0x0578770C  token: 0x60006A9
        public System.String __Gen_Wrap_81(System.Object P0) { }
        // RVA: 0x057877FC  token: 0x60006AA
        public System.Collections.Generic.Dictionary<System.String,System.String> __Gen_Wrap_82(System.Object P0) { }
        // RVA: 0x050EF614  token: 0x60006AB
        public System.Int32 __Gen_Wrap_83(System.Object P0) { }
        // RVA: 0x057878D8  token: 0x60006AC
        public System.Void __Gen_Wrap_84(System.Object P0, U8.SDK.SDKExtraData P1) { }
        // RVA: 0x057879EC  token: 0x60006AD
        public U8.SDK.SDKExternalTools.POSTResult __Gen_Wrap_85(Beyond.SDK.SDKNetUtils.WebHttpResponse P0) { }
        // RVA: 0x05787B24  token: 0x60006AE
        public System.Void __Gen_Wrap_86(Beyond.SDK.SDKNetUtils.WebHttpResponse P0) { }
        // RVA: 0x05787C18  token: 0x60006AF
        public System.Void __Gen_Wrap_87(System.Object P0, U8.SDK.SDKExternalTools.POSTRequest P1, System.Object P2) { }
        // RVA: 0x05787D3C  token: 0x60006B0
        public U8.SDK.SDKCaptchaHandler __Gen_Wrap_88(System.Object P0) { }
        // RVA: 0x05787E18  token: 0x60006B1
        public System.Boolean __Gen_Wrap_89(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1, System.String& P2) { }
        // RVA: 0x05787F84  token: 0x60006B2
        public System.String __Gen_Wrap_90(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1) { }
        // RVA: 0x057880AC  token: 0x60006B3
        public System.Collections.IEnumerator __Gen_Wrap_91(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x057881C0  token: 0x60006B4
        public System.Void __Gen_Wrap_92(System.Object P0, U8.SDK.ExternalPluginLoginParams P1) { }
        // RVA: 0x057882E4  token: 0x60006B5
        public System.Void __Gen_Wrap_93(System.Object P0, U8.SDK.ExternalPluginLogoutParams P1) { }
        // RVA: 0x057883EC  token: 0x60006B6
        public System.Void __Gen_Wrap_94(U8.SDK.U8PayResult P0) { }
        // RVA: 0x057884D8  token: 0x60006B7
        public System.Void __Gen_Wrap_95(System.Object P0, U8.SDK.ExternalPluginPayParams P1) { }
        // RVA: 0x057885E0  token: 0x60006B8
        public System.Boolean __Gen_Wrap_96(System.Object P0, System.Object P1, U8.SDK.SDKMeta& P2) { }
        // RVA: 0x05788730  token: 0x60006B9
        public System.Void __Gen_Wrap_97(Beyond.Login.LoginWorkFlow.FWork& P0, System.Int32 P1) { }
        // RVA: 0x0578888C  token: 0x60006BA
        public System.Boolean __Gen_Wrap_98(System.Object P0, Beyond.Login.LoginWorkFlow.ENode P1, System.Boolean P2) { }
        // RVA: 0x05788990  token: 0x60006BB
        public Beyond.SDK.HGDownloader.DownloadProgress __Gen_Wrap_99(System.Object P0) { }
        // RVA: 0x05477F10  token: 0x60006BC
        public Beyond.SDK.HGDownloader.WorkState __Gen_Wrap_100(System.Object P0) { }
        // RVA: 0x05784308  token: 0x60006BD
        public System.Collections.Generic.List<Beyond.SDK.HGFileInfo> __Gen_Wrap_101(System.Object P0, System.Object P1) { }
        // RVA: 0x0104E7F0  token: 0x60006BE
        public System.Collections.Generic.List<Beyond.SDK.HGFolder> __Gen_Wrap_102(System.Object P0, System.Object P1) { }
        // RVA: 0x0104F210  token: 0x60006BF
        public System.Boolean __Gen_Wrap_103(System.Object P0, Beyond.SDK.HGRetCodeType P1, System.Int32 P2) { }
        // RVA: 0x0104F510  token: 0x60006C0
        public System.String __Gen_Wrap_104(System.Double P0) { }
        // RVA: 0x0104FD90  token: 0x60006C1
        public System.Void __Gen_Wrap_105(System.Object P0, System.Int64 P1, System.Object P2, System.Object P3, System.Object P4) { }
        // RVA: 0x010502C0  token: 0x60006C2
        public System.Void __Gen_Wrap_106(System.Object P0, Beyond.SDK.HGDownloader.PauseReason P1) { }
        // RVA: 0x01050590  token: 0x60006C3
        public System.Collections.IEnumerator __Gen_Wrap_107(System.Object P0, System.Int64 P1) { }
        // RVA: 0x01050F30  token: 0x60006C4
        public System.Void __Gen_Wrap_108(System.Object P0, System.Int64 P1, System.Int64 P2, System.Int64 P3) { }
        // RVA: 0x01051240  token: 0x60006C5
        public System.Double __Gen_Wrap_109(System.Object P0) { }
        // RVA: 0x01051500  token: 0x60006C6
        public System.Boolean __Gen_Wrap_110(System.Boolean P0) { }
        // RVA: 0x01051700  token: 0x60006C7
        public System.String __Gen_Wrap_111(System.Object P0, System.Boolean P1) { }
        // RVA: 0x010520A0  token: 0x60006C8
        public Beyond.Resource.HotUpdate.LocalResPref __Gen_Wrap_112() { }
        // RVA: 0x010528E0  token: 0x60006C9
        public Beyond.Login.LoginHotUpdater.HotUpdateInfo __Gen_Wrap_113(System.Object P0, System.Boolean P1) { }
        // RVA: 0x01053280  token: 0x60006CA
        public Beyond.Resource.HotUpdate.ResourceIndex __Gen_Wrap_114() { }
        // RVA: 0x01053AC0  token: 0x60006CB
        public System.String __Gen_Wrap_115(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x01054510  token: 0x60006CC
        public System.Object __Gen_Wrap_116() { }
        // RVA: 0x01054D50  token: 0x60006CD
        public System.Collections.IEnumerator __Gen_Wrap_117(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3) { }
        // RVA: 0x01055870  token: 0x60006CE
        public System.Collections.IEnumerator __Gen_Wrap_118(System.Boolean P0, System.Object P1, System.Object P2) { }
        // RVA: 0x010562B0  token: 0x60006CF
        public Beyond.Resource.HotUpdate.LocalResPref __Gen_Wrap_119(System.Object P0, System.Boolean P1, System.Object P2, Beyond.Resource.HotUpdate.FResourceDiff P3, System.Int32& P4) { }
        // RVA: 0x01057010  token: 0x60006D0
        public System.Void __Gen_Wrap_120(System.Object P0, System.Boolean& P1, System.Double P2, System.Double P3, System.Int32 P4, System.Boolean P5) { }
        // RVA: 0x01057380  token: 0x60006D1
        public System.Boolean __Gen_Wrap_121(System.Object P0, Beyond.VFS.EVFSBlockType P1) { }
        // RVA: 0x01057670  token: 0x60006D2
        public System.Collections.IEnumerator __Gen_Wrap_122(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x010580E0  token: 0x60006D3
        public Beyond.Login.LoginHotUpdater __Gen_Wrap_123(System.Object P0, System.Boolean P1) { }
        // RVA: 0x01058A40  token: 0x60006D4
        public Beyond.Login.LoginProgress.FDownloadSize.EUnit __Gen_Wrap_124(System.Double P0) { }
        // RVA: 0x01058C40  token: 0x60006D5
        public System.Single __Gen_Wrap_125(System.Double P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1) { }
        // RVA: 0x01058E70  token: 0x60006D6
        public System.String __Gen_Wrap_126(System.Single P0, System.Single P1, Beyond.Login.LoginProgress.FDownloadSize.EUnit P2) { }
        // RVA: 0x01059760  token: 0x60006D7
        public System.String __Gen_Wrap_127(System.Single P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1) { }
        // RVA: 0x0105A010  token: 0x60006D8
        public System.String __Gen_Wrap_128(System.Single P0, System.Single P1) { }
        // RVA: 0x0105A8E0  token: 0x60006D9
        public System.Void __Gen_Wrap_129(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2, System.Double P3) { }
        // RVA: 0x0105B5B0  token: 0x60006DA
        public System.Void __Gen_Wrap_130(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2) { }
        // RVA: 0x0105C260  token: 0x60006DB
        public System.Void __Gen_Wrap_131(Beyond.Login.LoginProgress.FDownloadSize& P0) { }
        // RVA: 0x0105CE70  token: 0x60006DC
        public System.Void __Gen_Wrap_132(Hypergryph.SpeedTest.SpeedTestResult P0) { }
        // RVA: 0x0105D130  token: 0x60006DD
        public System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_133() { }
        // RVA: 0x0105D970  token: 0x60006DE
        public Beyond.Login.LoginViewModel.FAgeTipsPolicy __Gen_Wrap_134() { }
        // RVA: 0x0105E180  token: 0x60006DF
        public Beyond.Login.LoginWorkFlow.Node[] __Gen_Wrap_135(System.Object P0) { }
        // RVA: 0x0105EAC0  token: 0x60006E0
        public System.Single __Gen_Wrap_136(System.Object P0, System.Boolean& P1) { }
        // RVA: 0x0105EDE0  token: 0x60006E1
        public Beyond.UI.UIAnimationMixPlayer __Gen_Wrap_137(System.Object P0) { }
        // RVA: 0x0105F720  token: 0x60006E2
        public System.Void __Gen_Wrap_138(System.Object P0, Beyond.Login.LoginSceneAnimCtrl.EState P1) { }
        // RVA: 0x0105FA00  token: 0x60006E3
        public System.Collections.Generic.List<System.String> __Gen_Wrap_139(System.Object P0) { }
        // RVA: 0x01060340  token: 0x60006E4
        public System.Void __Gen_Wrap_140(System.Object P0, Beyond.Login.LoginViewModel.FAgeTipsPolicy P1) { }
        // RVA: 0x010609D0  token: 0x60006E5
        public System.Void __Gen_Wrap_141(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x01060DB0  token: 0x60006E6
        public System.Void __Gen_Wrap_142(System.Boolean P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x01060FE0  token: 0x60006E7
        public System.Void __Gen_Wrap_143(System.Object P0, Beyond.EventData<System.Boolean>& P1) { }
        // RVA: 0x01061680  token: 0x60006E8
        public System.Void __Gen_Wrap_144(System.Object P0, Beyond.EventData<System.Single>& P1) { }
        // RVA: 0x01061D10  token: 0x60006E9
        public System.Void __Gen_Wrap_145(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x01062180  token: 0x60006EA
        public System.Void __Gen_Wrap_146(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x01062520  token: 0x60006EB
        public System.Void __Gen_Wrap_147(System.Object P0, System.Int32 P1, System.Object P2) { }
        // RVA: 0x010628B0  token: 0x60006EC
        public System.Void __Gen_Wrap_148(System.Object P0, Beyond.VFS.EVFSBlockType P1) { }
        // RVA: 0x03D05E20  token: 0x60006ED
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000116  // size: 0x58
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey, System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerator`1
    {
        // Fields
        private System.Int32 methodId_0;  // 0x40
        private System.Int32 methodId_1;  // 0x44
        private System.Int32 methodId_2;  // 0x48
        private System.Int32 methodId_3;  // 0x4c
        private System.Int32 methodId_4;  // 0x50

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x05788A94 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x05788B40 */ }

        // Methods
        // RVA: 0x05152EA8  token: 0x60006EE
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x05152C48  token: 0x60006EF
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x05152D80  token: 0x60006F1
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x05788BEC  token: 0x60006F3
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x60006F4
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000117  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60006F5
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0578C5F0  token: 0x60006F6
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x0262E590  token: 0x60006F7
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x0578C4AC  token: 0x60006F8
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x0578C578  token: 0x60006F9
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x0578C654  token: 0x60006FA
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x0578C408  token: 0x60006FB
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000118  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-GameApp-SwitchState0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedXChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedYChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraTopViewSpeedChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerWalkRunRatioChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnCameraDistanceLevelChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnCameraImpulseLevelChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseXChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseYChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoLockTargetChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnComboSkillCameraAlphaChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoSprintChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerTriggerEffectChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackTouchChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackGamepadChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsQualityChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_SetResolution0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsFullScreenChanged0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsResolutionChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsNotchPaddingChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnOtherShowSmartAlertChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-InitSetterItems0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_PreInitGameSetting0;  // const
        public static IFix.IDMAP0 Beyond-RenderPipelineDataLoader-LoadSimpleRpData0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_GetSplashConfigs0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-PublicSetGameVersion0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_StartLicenseCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_Stop0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-Hide0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_OnSplashCompleteCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_OnTweenFinished0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_DoStartSplash0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-_Play0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-Show0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_FetchRemoteConfigUtilSuc0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_InitSecuritySDK0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_InitGameStateMachine0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_OnApplicationFocusForLua0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_OnApplicationPauseForLua0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_RegisterLuaAfterGCEvent0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_OnSystemDisplaySizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_OnSystemScreenSizeChanged0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_Init0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-Awake0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-Update0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-LateUpdate0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-OnApplicationQuit0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-OnApplicationFocus0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_OnApplicationPauseForSecurity0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-OnApplicationPause0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_UnInitGameStateMachine0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-_UnInit0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-QuitGame0;  // const
        public static IFix.IDMAP0 Beyond-GameApp-RefreshScreenResolution0;  // const
        public static IFix.IDMAP0 Beyond-GameStateBase-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-_InitAPPDefaultCulture0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-_InitInitialResourceManager0;  // const
        public static IFix.IDMAP0 Beyond-RenderPipelineDataLoader-PreloadFullRpResources0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-_UnInit0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-_Init0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-Init0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-_InitGameSetting0;  // const
        public static IFix.IDMAP0 Beyond-RenderPipelineDataLoader-IsPreLoadFinished0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-_DoInit0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-GameStateBase-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-GameInitState-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-CanFinished0;  // const
        public static IFix.IDMAP0 Beyond-RenderPipelineDataLoader-LoadFullRpResources0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-IsDisposed0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-IsWorkflowInProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-OnDispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EnableCursor0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_UpdateCursor0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-AssetLoader-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-_DisposeImpl0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-get_maskCtrl0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-_GetMaskByType0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-BeforeDestroy0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-_DisposeCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-IsWorkflowDisposed0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-EnableMask0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-_InitController0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-_InitChildPanel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-Init0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_ToggleGlow0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-OnLoginContext0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-_InitVersionBtn0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-_InitCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-_InitImpl0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-InitUI0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-Start0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-IsBeforeWork0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-SetCurNode0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-_InternalTick0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-Cancel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-IsNeedSoftRestart0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-WorkEnd0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-DoWorkFlow0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_LoginWorkFlowCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_PrepareBeforeLoginProcess0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAlertDialog-SetParams0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-SetParams0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-SetParams0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-StartCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-AlertDialog0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-Init0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-InvokeWhenStart0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_Init0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-InitCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-GameLoginState-_TryStartLoginWorkflow0;  // const
        public static IFix.IDMAP0 Beyond-GameLoginState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-GameLoginState-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-ShutDown0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_ClearWorkflowAndContext0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_ReleaseLoginScene0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-Clear0;  // const
        public static IFix.IDMAP0 Beyond-GameMainState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-IsAfterWork0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-PeekFallbackStatus0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-IsReLoginInProgress0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-OnReleaseMainGame0;  // const
        public static IFix.IDMAP0 Beyond-GameMainState-_ClearUtils0;  // const
        public static IFix.IDMAP0 Beyond-GameMainState-ReleaseMainGame0;  // const
        public static IFix.IDMAP0 Beyond-GameMainState-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-GamePreloadState-_InitGameSettingStateInPreload0;  // const
        public static IFix.IDMAP0 Beyond-GamePreloadState-_DoPreload0;  // const
        public static IFix.IDMAP0 Beyond-GamePreloadState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-GamePreloadState-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-UnInit0;  // const
        public static IFix.IDMAP0 Beyond-GameQuitState-DoQuit0;  // const
        public static IFix.IDMAP0 Beyond-GameQuitState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-GameQuitState-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-ClearSync0;  // const
        public static IFix.IDMAP0 Beyond-GameSoftRestartState-_SoftRestart0;  // const
        public static IFix.IDMAP0 Beyond-GameSoftRestartState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-InvokeWhenWorkFlowFinished0;  // const
        public static IFix.IDMAP0 Beyond-GameStartState-_OnEnterMainGame0;  // const
        public static IFix.IDMAP0 Beyond-GameStartState-OnEnter0;  // const
        public static IFix.IDMAP0 Beyond-GameStartState-OnLeave0;  // const
        public static IFix.IDMAP0 Beyond-GameStateBase-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-GameStateMachine-_RegisterStates0;  // const
        public static IFix.IDMAP0 Beyond-GameStateMachine-CheckCanReturnToLoginState0;  // const
        public static IFix.IDMAP0 Beyond-GameStateMachine-ReturnToLoginState0;  // const
        public static IFix.IDMAP0 Beyond-GlobalInitializer-InitGlobalConfig0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-Awake0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-Start0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-GetEnterGamePanelPredelay0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsModel-IsContentEmpty0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-ViewOnlyController0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-EnableNetMask0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-DisableNetMask0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-get_serverList0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnSelectServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-GetSelectedServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-OnEvent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-SendEvent0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_SaveConfig0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_TryClosePanel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_OnSelectServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_UpdateStatus0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-LoginWithCallback0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-HideAndDestroy0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-_MockLoginCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MockLoginWithCallback0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-_CloseCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-TryCloseWithCallback0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-Show0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCfg-CreateTweenAndHide0;  // const
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-IsMaskTweening0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-StopCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginContext-SendEvent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneComponent-OnBindToManager0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneComponent-Bind0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_BindPendingComponents0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-SceneComponentOnly_Bind0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-ToggleLoginBindingGroup0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-VocResSelDialog0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-VocResSelDialogWithConfirm0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-AlertDialogWithResult0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-AlertDialogWithConfirm0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_StartShowJudgeDialogCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-JudgeDialog0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-JudgeDialog1;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-MockLoginWithCallback0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-MockManualSelectServer0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-IsLoginSceneLoading0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-_ExtractErrorInfo0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-FetchRemoteConfigUtilSuc0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-DevOnlyUseLocalResVersion0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-FFlowCondition-IsTargetMatch0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-LoginManager-FlowWithMaskMgr-StartFlow0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-OnApplicationQuit0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0;  // const
        public static IFix.IDMAP0 Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0;  // const
        public static IFix.IDMAP0 Beyond-TailGameLoop-Update0;  // const
        public static IFix.IDMAP0 Beyond-TailGameLoop-LateUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-SplashController-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-SDK-PlatformFont-GetFont0;  // const
        public static IFix.IDMAP0 Beyond-SDK-SDKNetUtils-HTTPPost0;  // const
        public static IFix.IDMAP0 Beyond-SDK-SDKNetUtils-HTTPGet0;  // const
        public static IFix.IDMAP0 Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-IsInited0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-WaitForInited0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-Log0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-LogError0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-LogWarning0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetSignKey0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-GetPayAddition0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-GetSDKToken0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-GetSDKUid0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Init0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-_UseMockVersion0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-_MockLogin0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Login0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Logout0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-OnProductListChanged0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Pay0;  // const
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-Clear0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-ShowWaitProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-GetWaitTime0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-ClearWaitProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-GetNoAlertCode0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_GetLastGameInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-CheckLastGameInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-MarkFallback0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Fallback0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-OnDispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-CanCancel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-GetDownloadProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-GetDecompressProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-GetWorkState0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-Tick0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_GetFileList0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_GetAllFileList0;  // const
        public static IFix.IDMAP0 Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_OnDownloadFinish0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_OnDownloadError0;  // const
        public static IFix.IDMAP0 Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0;  // const
        public static IFix.IDMAP0 Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_OnDownloadPaused0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_StartDownloadImpl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_StartDownload0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-Awake0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdateNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_YieldErrorAlert0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_OnDownloadStart0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_OnDownloadProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_DoTaskUpdating0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_UpdateGame0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-DoUpdate0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_LogoutToInitNode0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_FallbackToInitWithMask0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_ConfirmServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_OnEventLogout0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-RequestResourceRepair0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_OnEventResourceRepair0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-OnEvent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-NeedClearFolder0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkClearSuccessed0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkSoftRestart0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-ClearSoftRestartFlag0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginLocalResTask-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_UpdateResVersion0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_SetResVersionForLog0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CurrentWorkMode0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-ResourceRootUrl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GenResIndex0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourceFileUrl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GenRiff0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CreateUpdatedLocalResPref0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GenLocalRef0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginLocalResTask-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-RequestSkipU8Login0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_VitalError0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-StartHotUpdate0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-GetCurrent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-GetTotal0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-SetSize0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-SetProgress0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-SetIdle0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-GetInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-_YieldAlertError0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-_InitRemoteConfigs0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-_InitCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_WarmUp0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_OnGetServerListSuc0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_GetServerListInfoMock0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_OnGetServerListFail0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_GetServerListInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_GetServerList0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_EnterPreLoad0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_LoginPreLoad0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-_InitSubSDKs0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_ClearLoginCaches0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_EnableBlurMask0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnSDKViewDisabled0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnBulletinOpen0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnBulletinClose0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnLoginSuc0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_SkipSDKLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnLoginCanceled0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnLoginFail0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_StartSDKLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_FinishLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_LoginCoroutine0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-OnEvent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-IsAgeTipsVisible0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-IsGovTipsVisible0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-IsMenuVisible0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsModel-CanDisplay0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsProp-ClearContentCache0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsProp-UpdateContent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_RegisterNodes0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-CanCancel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-Cancel0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-CancelAndFallback0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-AddEventReceiver0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-UpdateOnce0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-Init0;  // const
        public static IFix.IDMAP0 Beyond-Login-HotUpdateNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-HotUpdateNode-OnDispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-_NotifyTimeout0;  // const
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-_IsTimeout0;  // const
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-_DisposeTimer0;  // const
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-OnDispose0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadPostDelayNode-WaitForSeconds0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0;  // const
        public static IFix.IDMAP0 Beyond-Login-PreloadPostDelayNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-Trans2GsLoginNode-WaitForSeconds0;  // const
        public static IFix.IDMAP0 Beyond-Login-Trans2GsLoginNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-FinishNode-Work0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_ResetToA10;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneComponent-Start0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-Start0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-Tick0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginSceneRoot-OnBindToManager0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-Init0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAlertDialog-_OnConfirmClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginAlertDialog-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_TimeManagerTick0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-Tick0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginEnterGamePanel-_InitIfNot0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginEnterGamePanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGovTipsPanel-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginGovTipsPanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnSettingClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnResCheckClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnLogoutClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnLoginClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnQRClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_CanQRLogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_UpdateServerZone0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-Awake0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnRequestRelogin0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnInputChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginResourcePanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginResourcePanel-Update0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-Awake0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-_OnClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-RefreshView0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-SetSelected0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-InitData0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_OnInputChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_WaitingForShowListAwake0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnValueChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVersionPanel-get_displayGameVersion0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVersionPanel-Start0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-SetSelected0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_UpdateSelected0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_UpdateList0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-UpdateSelected0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-_OnClicked0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-RefreshView0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_UpdateCell0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-OnInit0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-WarmUpProgress-GetTotal0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Entry-WarmUpProgress-GetInfo0;  // const

    }

}

