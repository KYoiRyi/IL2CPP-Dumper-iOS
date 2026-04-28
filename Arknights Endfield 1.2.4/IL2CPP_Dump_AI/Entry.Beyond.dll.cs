// ========================================================
// Dumped by @desirepro
// Assembly: Entry.Beyond.dll
// Classes:  280
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

CLASS: RenderSilhouetteRT
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            UnityEngine.Camera              cameraRT  // 0x18
  public            UnityEngine.Camera              mainCamera  // 0x20
  public            UnityEngine.Material            materialSilhouette  // 0x28
  private   static  UnityEngine.Texture             s_mSilhouetteRT  // static @ 0x0
  private   static  UnityEngine.RenderTexture       s_mSilhouetteRth  // static @ 0x8
METHODS:
  RVA=0x028AD320  token=0x6000001  System.Void Update()
  RVA=0x032FA2B0  token=0x6000002  System.Void OnDestroy()
  RVA=0x0426FE60  token=0x6000003  System.Void .ctor()
END_CLASS

CLASS: <_InitSecuritySDK>d__31
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.GameApp                  <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000020  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000021  System.Void System.IDisposable.Dispose()
  RVA=0x02C3E060  token=0x6000022  System.Boolean MoveNext()
  RVA=0x0576FF68  token=0x6000024  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_FetchRemoteConfigUtilSuc>d__33
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           Beyond.Cfg.RemoteNetworkCfg     <config>5__2  // 0x20
  private           Beyond.Misc.ObjectRef           <resultRef>5__3  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000026  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000027  System.Void System.IDisposable.Dispose()
  RVA=0x02C37790  token=0x6000028  System.Boolean MoveNext()
  RVA=0x0576FE84  token=0x600002A  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_DoInit>d__5
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.GameInitState            <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600003B  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600003C  System.Void System.IDisposable.Dispose()
  RVA=0x02C37D40  token=0x600003D  System.Boolean MoveNext()
  RVA=0x0576FDEC  token=0x600003F  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_DoPreload>d__6
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.GamePreloadState         <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000058  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000059  System.Void System.IDisposable.Dispose()
  RVA=0x02C351F0  token=0x600005A  System.Boolean MoveNext()
  RVA=0x0576FE38  token=0x600005C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_SoftRestart>d__5
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.GameSoftRestartState     <>4__this  // 0x20
  private           UnityEngine.AsyncOperation      <clearSceneOp>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600006A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600006B  System.Void System.IDisposable.Dispose()
  RVA=0x05770098  token=0x600006C  System.Boolean MoveNext()
  RVA=0x05770760  token=0x600006E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <ReturnToLoginState>d__8
TYPE:  sealed class
TOKEN: 0x2000015
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.GameStateMachine         <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000083  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000084  System.Void System.IDisposable.Dispose()
  RVA=0x02C35D70  token=0x6000085  System.Boolean MoveNext()
  RVA=0x0576F7F0  token=0x6000087  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: FOptions
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x18
FIELDS:
  public            Beyond.LoginContext             context  // 0x10
METHODS:
END_CLASS

CLASS: <_CloseCoroutine>d__4
TYPE:  sealed class
TOKEN: 0x200001E
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginController.Dialog   <>4__this  // 0x20
  public            System.Action                   callback  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000AF  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000B0  System.Void System.IDisposable.Dispose()
  RVA=0x0576FC88  token=0x60000B1  System.Boolean MoveNext()
  RVA=0x0576FD54  token=0x60000B3  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <Create>d__8`1
TYPE:  sealed class
TOKEN: 0x200001F
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            Beyond.Misc.ObjectRef           outRef  // 0x0
  public            Beyond.LoginController          controller  // 0x0
  public            System.String                   resPath  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000B5  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x60000B6  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x60000B7  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60000B9  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Dialog
TYPE:  abstract class
TOKEN: 0x200001D
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UISwitchTween         m_switchTween  // 0x18
  private           Beyond.LoginController          m_controller  // 0x20
  public            System.String                   showAudioEvent  // 0x28
  public            System.String                   closeAudioEvent  // 0x30
METHODS:
  RVA=0x0576C5CC  token=0x60000A9  System.Collections.IEnumerator _CloseCoroutine(System.Action callback)
  RVA=0x0576C488  token=0x60000AA  System.Boolean TryCloseWithCallback(System.Action callback)
  RVA=0x0576C39C  token=0x60000AB  System.Void Show()
  RVA=0x0576C358  token=0x60000AC  System.Void OnInit()
  RVA=-1  // generic def  token=0x60000AD  System.Collections.IEnumerator Create(System.String resPath, Beyond.LoginController controller, Beyond.Misc.ObjectRef outRef)
  RVA=0x0426FE60  token=0x60000AE  System.Void .ctor()
END_CLASS

CLASS: MaskConsts
TYPE:  static class
TOKEN: 0x2000020
SIZE:  0x10
FIELDS:
  public    static  System.Single                   DELAY_WAIT_NODE  // const
  public    static  System.String                   INIT  // const
  public    static  System.String                   U8_LOGIN  // const
  public    static  System.String                   FROM_GS_LOGIN  // const
  public    static  System.String                   FROM_CREATE_ROLE  // const
  public    static  System.String                   NET_AGE_TIPS  // const
METHODS:
END_CLASS

CLASS: EMaskType
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.LoginController.EMaskTypeNone  // const
  public    static  Beyond.LoginController.EMaskTypeBlack  // const
  public    static  Beyond.LoginController.EMaskTypeBlur  // const
  public    static  Beyond.LoginController.EMaskTypeWhite  // const
METHODS:
END_CLASS

CLASS: MaskCfg
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x20
FIELDS:
  public            UnityEngine.CanvasGroup         target  // 0x10
  public            System.Single                   showDuration  // 0x18
  public            System.Single                   hideDuration  // 0x1c
METHODS:
  RVA=0x036531D0  token=0x60000BB  Beyond.UI.UISwitchTween CreateTweenAndHide()
  RVA=0x03D55780  token=0x60000BC  System.Void .ctor()
END_CLASS

CLASS: NetMaskRef
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x20
FIELDS:
  private           System.String                   <key>k__BackingField  // 0x10
  public            System.Int32                    maskId  // 0x18
  public            System.Boolean                  isEnabled  // 0x1c
PROPERTIES:
  key  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x0426FEE0  token=0x60000C9  System.Void .ctor(System.String key)
END_CLASS

CLASS: <WaitForCrossSceneMasks>d__10
TYPE:  sealed class
TOKEN: 0x2000025
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginController.MaskCtrl <>4__this  // 0x20
  private           System.Int32[]                  <>7__wrap1  // 0x28
  private           System.Int32                    <>7__wrap2  // 0x30
  private           Beyond.UI.UISwitchTween         <mask>5__4  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000CA  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000CB  System.Void System.IDisposable.Dispose()
  RVA=0x0576FB14  token=0x60000CC  System.Boolean MoveNext()
  RVA=0x0576FC3C  token=0x60000CE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: MaskCtrl
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x28
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static readonly System.Int32[]                  CROSS_SCENE_MASKS  // static @ 0x0
  private           Beyond.ListDict<System.Int32,System.Collections.Generic.HashSet<System.String>>m_maskRefs  // 0x10
  private           Beyond.ListDict<System.Int32,Beyond.UI.UISwitchTween>m_maskTweens  // 0x18
  private           Beyond.ListDict<System.String,Beyond.LoginController.MaskCtrl.NetMaskRef>m_netMasks  // 0x20
METHODS:
  RVA=0x03652FD0  token=0x60000BD  System.Void .ctor(Beyond.LoginController controller)
  RVA=0x02C3D490  token=0x60000BE  System.Void Dispose()
  RVA=0x02C3C4E0  token=0x60000BF  System.Void EnableMask(System.String key, Beyond.LoginController.EMaskType type, System.Boolean enable, System.Boolean reset)
  RVA=0x02C3C490  token=0x60000C0  System.Boolean IsMaskTweening(Beyond.LoginController.EMaskType type)
  RVA=0x02EAA010  token=0x60000C1  System.Boolean IsCrossSceneMaskTweening()
  RVA=0x0576EAD8  token=0x60000C2  System.Collections.IEnumerator WaitForCrossSceneMasks()
  RVA=0x0576E918  token=0x60000C3  System.Void EnableNetMask(System.String key, System.Single timeoutSecs)
  RVA=0x0576E82C  token=0x60000C4  System.Void DisableNetMask(System.String key)
  RVA=0x02C3C6C0  token=0x60000C5  Beyond.UI.UISwitchTween _GetMaskByType(System.Int32 type)
  RVA=0x03CB7120  token=0x60000C6  System.Void .cctor()
END_CLASS

CLASS: <BeforeDestroy>d__35
TYPE:  sealed class
TOKEN: 0x2000026
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginController          <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000D0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000D1  System.Void System.IDisposable.Dispose()
  RVA=0x02EA9730  token=0x60000D2  System.Boolean MoveNext()
  RVA=0x0576F424  token=0x60000D4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_InstantiateUIFromRes>d__36`1
TYPE:  sealed class
TOKEN: 0x2000027
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            Beyond.Misc.ObjectRef           objRef  // 0x0
  public            Beyond.LoginController          <>4__this  // 0x0
  public            System.String                   resPath  // 0x0
  public            UnityEngine.Transform           parent  // 0x0
  private           System.Nullable<Beyond.Resource.FAssetProxyHandle><handle>5__2  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60000D6  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x60000D7  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x60000D8  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x60000DA  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_InitCoroutine>d__38
TYPE:  sealed class
TOKEN: 0x2000028
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginController          <>4__this  // 0x20
  private           Beyond.LoginContext             <context>5__2  // 0x28
  private           Beyond.Misc.ObjectRef           <panelRef>5__3  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000DC  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000DD  System.Void System.IDisposable.Dispose()
  RVA=0x02EA8F90  token=0x60000DE  System.Boolean MoveNext()
  RVA=0x0576FF1C  token=0x60000E0  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass45_0
TYPE:  sealed class
TOKEN: 0x2000029
SIZE:  0x18
FIELDS:
  public            Beyond.Misc.ObjectRef           objRef  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000E2  System.Void .ctor()
  RVA=0x02F7AA70  token=0x60000E3  System.Void <_MockLoginCoroutine>b__0(System.String pUID)
END_CLASS

CLASS: <_MockLoginCoroutine>d__45
TYPE:  sealed class
TOKEN: 0x200002A
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginController          <>4__this  // 0x20
  private           Beyond.LoginController.<>c__DisplayClass45_0<>8__1  // 0x28
  public            System.String                   fixedUID  // 0x30
  private           Beyond.Login.LoginMockUIDPanel  <nullablePanel>5__2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60000E4  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60000E5  System.Void System.IDisposable.Dispose()
  RVA=0x03652A00  token=0x60000E6  System.Boolean MoveNext()
  RVA=0x05770000  token=0x60000E8  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_DisposeCoroutine>d__48
TYPE:  sealed class
TOKEN: 0x200002C
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginController          legacyController  // 0x20
  public            System.Action                   disposeAction  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000108  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000109  System.Void System.IDisposable.Dispose()
  RVA=0x03A24680  token=0x600010A  System.Boolean MoveNext()
  RVA=0x0576FDA0  token=0x600010C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: AssetLoader
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle>m_assetHandles  // 0x10
METHODS:
  RVA=-1  // generic def  token=0x6000131  Beyond.Resource.FAssetProxyHandle CachedLoad(System.String path)
  RVA=-1  // generic def  token=0x6000132  Beyond.Resource.FAssetProxyHandle CachedLoadAsync(System.String path)
  RVA=0x02AD71E0  token=0x6000133  System.Boolean _CheckDisposedBeforeLoad(System.String path)
  RVA=0x028D3CF0  token=0x6000134  System.Void Dispose()
  RVA=0x028D5190  token=0x6000135  System.Void .ctor()
END_CLASS

CLASS: <_FlowCoroutine>d__4
TYPE:  sealed class
TOKEN: 0x2000032
SIZE:  0x60
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginManager.FlowWithMaskMgr<>4__this  // 0x20
  public            Beyond.LoginManager.FFlowWithMaskflow  // 0x28
  private           Beyond.LoginController.MaskCtrl <maskCtrl>5__2  // 0x50
  private           System.Boolean                  <isFlowSuc>5__3  // 0x58
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600013A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600013B  System.Void System.IDisposable.Dispose()
  RVA=0x02C3C820  token=0x600013C  System.Boolean MoveNext()
  RVA=0x0576FED0  token=0x600013E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: FlowWithMaskMgr
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x20
FIELDS:
  private           Beyond.LoginContext             m_context  // 0x10
  private           System.Collections.Generic.HashSet<System.String>m_activeFlows  // 0x18
METHODS:
  RVA=0x028D4DC0  token=0x6000136  System.Void .ctor(Beyond.LoginContext context)
  RVA=0x02D773E0  token=0x6000137  System.Void StartFlow(Beyond.LoginManager.FFlowWithMask flow)
  RVA=0x02D77520  token=0x6000138  System.Collections.IEnumerator _FlowCoroutine(Beyond.LoginManager.FFlowWithMask flow)
  RVA=0x0576C674  token=0x6000139  System.Void _OnFlowFinished(Beyond.LoginManager.FFlowWithMask flow)
END_CLASS

CLASS: FFlowWithMask
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x38
FIELDS:
  public            System.String                   key  // 0x10
  public            Beyond.LoginController.EMaskTypemaskType  // 0x18
  public            System.Func<System.Boolean>     flowAction  // 0x20
  public            Beyond.LoginManager.FFlowConditioncondition  // 0x28
  public            System.Single                   disableDelay  // 0x30
METHODS:
END_CLASS

CLASS: FFlowCondition
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x18
FIELDS:
  private           Beyond.Login.LoginWorkFlow.ENode<priTarget>k__BackingField  // 0x10
  private           Beyond.Login.LoginWorkFlow.ENode<secTarget>k__BackingField  // 0x14
PROPERTIES:
  priTarget  get=0x03D4E980  set=0x03D4E970
  secTarget  get=0x03D4E990  set=0x03D51720
METHODS:
  RVA=0x03D55720  token=0x6000144  System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode target)
  RVA=0x03D4E4B0  token=0x6000145  System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode first, Beyond.Login.LoginWorkFlow.ENode second)
  RVA=0x02C3DF80  token=0x6000146  System.Boolean IsTargetMatch(Beyond.Login.LoginWorkFlow.ENode node)
END_CLASS

CLASS: <InitCoroutine>d__17
TYPE:  sealed class
TOKEN: 0x2000035
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginManager             <>4__this  // 0x20
  public            System.Boolean                  quickStart  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000147  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000148  System.Void System.IDisposable.Dispose()
  RVA=0x028D3C90  token=0x6000149  System.Boolean MoveNext()
  RVA=0x0576F7A4  token=0x600014B  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000036
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.LoginManager.<>c         <>9  // static @ 0x0
  public    static  System.Action<Beyond.Login.LoginAlertDialog,Beyond.Login.LoginAlertDialog.FParams><>9__29_0  // static @ 0x8
  public    static  System.Action<Beyond.Login.LoginVocResSelDialog,Beyond.Login.LoginVocResSelDialog.FParams><>9__30_0  // static @ 0x10
  public    static  System.Action<Beyond.Login.LoginJudgeDialog,Beyond.Login.LoginJudgeDialog.FParams><>9__36_0  // static @ 0x18
METHODS:
  RVA=0x0576F928  token=0x600014D  System.Void .cctor()
  RVA=0x0350B670  token=0x600014E  System.Void .ctor()
  RVA=0x0576F83C  token=0x600014F  System.Void <AlertDialog>b__29_0(Beyond.Login.LoginAlertDialog param1, Beyond.Login.LoginAlertDialog.FParams param2)
  RVA=0x0576F86C  token=0x6000150  System.Void <VocResSelDialog>b__30_0(Beyond.Login.LoginVocResSelDialog param1, Beyond.Login.LoginVocResSelDialog.FParams param2)
  RVA=0x0576F894  token=0x6000151  System.Void <_StartShowJudgeDialogCoroutine>b__36_0(Beyond.Login.LoginJudgeDialog param1, Beyond.Login.LoginJudgeDialog.FParams param2)
END_CLASS

CLASS: <>c__DisplayClass31_0
TYPE:  sealed class
TOKEN: 0x2000037
SIZE:  0x18
FIELDS:
  public            System.Object                   wait  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000152  System.Void .ctor()
  RVA=0x035ACAA0  token=0x6000153  System.Void <VocResSelDialogWithConfirm>b__0()
END_CLASS

CLASS: <VocResSelDialogWithConfirm>d__31
TYPE:  sealed class
TOKEN: 0x2000038
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginManager             <>4__this  // 0x20
  private           Beyond.LoginManager.<>c__DisplayClass31_0<>8__1  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000154  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000155  System.Void System.IDisposable.Dispose()
  RVA=0x0576F98C  token=0x6000156  System.Boolean MoveNext()
  RVA=0x0576FAC8  token=0x6000158  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass32_0
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x20
FIELDS:
  public            Beyond.Misc.ObjectRef           outRef  // 0x10
  public            System.Action<Beyond.Misc.ObjectRef>callback  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600015A  System.Void .ctor()
  RVA=0x0576F8D8  token=0x600015B  System.Void <AlertDialogWithResult>b__0()
END_CLASS

CLASS: <AlertDialogWithResult>d__32
TYPE:  sealed class
TOKEN: 0x200003A
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Misc.ObjectRef           outRef  // 0x20
  public            System.Action<Beyond.Misc.ObjectRef>callback  // 0x28
  public            Beyond.LoginManager             <>4__this  // 0x30
  public            System.String                   desc  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600015C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600015D  System.Void System.IDisposable.Dispose()
  RVA=0x0576F280  token=0x600015E  System.Boolean MoveNext()
  RVA=0x0576F3D8  token=0x6000160  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass33_0
TYPE:  sealed class
TOKEN: 0x200003B
SIZE:  0x18
FIELDS:
  public            System.Object                   wait  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000162  System.Void .ctor()
  RVA=0x035ACAA0  token=0x6000163  System.Void <AlertDialogWithConfirm>b__0()
END_CLASS

CLASS: <AlertDialogWithConfirm>d__33
TYPE:  sealed class
TOKEN: 0x200003C
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginManager             <>4__this  // 0x20
  public            System.String                   desc  // 0x28
  private           Beyond.LoginManager.<>c__DisplayClass33_0<>8__1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000164  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000165  System.Void System.IDisposable.Dispose()
  RVA=0x0576F0E4  token=0x6000166  System.Boolean MoveNext()
  RVA=0x0576F234  token=0x6000168  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_ShowDialogCoroutine>d__37`2
TYPE:  sealed class
TOKEN: 0x200003D
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           System.Object                   <>2__current  // 0x0
  public            Beyond.LoginManager             <>4__this  // 0x0
  public            System.String                   resPath  // 0x0
  public            System.Action<TDialog,TParam>   setParamFunc  // 0x0
  public            TParam                          param  // 0x0
  private           Beyond.Misc.ObjectRef           <outRef>5__2  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600016A  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x600016B  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x600016C  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x600016E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass39_0
TYPE:  sealed class
TOKEN: 0x200003E
SIZE:  0x18
FIELDS:
  public            System.Action                   callback  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000170  System.Void .ctor()
  RVA=0x0576F918  token=0x6000171  System.Void <MockManualSelectServer>b__0(System.String _)
END_CLASS

CLASS: <>c__DisplayClass40_0
TYPE:  sealed class
TOKEN: 0x200003F
SIZE:  0x20
FIELDS:
  public            Beyond.LoginController          controller  // 0x10
  public            Beyond.LoginManager             <>4__this  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000172  System.Void .ctor()
  RVA=0x03C7DA60  token=0x6000173  System.Void <_Init>b__0()
END_CLASS

CLASS: <_LoginWorkFlowCoroutine>d__43
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.LoginManager             <>4__this  // 0x20
  public            Beyond.LoginController          nullableCtrl  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000174  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000175  System.Void System.IDisposable.Dispose()
  RVA=0x02EA9C20  token=0x6000176  System.Boolean MoveNext()
  RVA=0x0576FFB4  token=0x6000178  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <FetchRemoteConfigUtilSuc>d__45
TYPE:  sealed class
TOKEN: 0x2000041
SIZE:  0x78
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Cfg.IRemoteConfig        config  // 0x20
  public            System.String                   configEnv  // 0x28
  public            System.String                   keyErrorWithCode  // 0x30
  public            System.String                   keyTimeout  // 0x38
  private           Beyond.Cfg.FRemoteConfigRequest <request>5__2  // 0x40
  private           System.Boolean                  <isServiceSuc>5__3  // 0x68
  private           Beyond.Misc.ObjectRef           <resultRef>5__4  // 0x70
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600017A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600017B  System.Void System.IDisposable.Dispose()
  RVA=0x02C371A0  token=0x600017C  System.Boolean MoveNext()
  RVA=0x0576F758  token=0x600017E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: SplashConfig
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x20
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x10
  public            System.Boolean                  blackCoverFadeOut  // 0x18
METHODS:
END_CLASS

CLASS: SplashConfigOverride
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x20
FIELDS:
  public            Beyond.GEnums.EnvLang           envLang  // 0x10
  public            Beyond.UI.SplashController.SplashConfig[]splashConfigs  // 0x18
METHODS:
END_CLASS

CLASS: SplashConfigs
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x28
FIELDS:
  public            Beyond.UI.SplashController.SplashConfig[]splashConfigs  // 0x10
  public            Beyond.UI.SplashController.SplashConfig[]splashConfigsVNMobile  // 0x18
  public            Beyond.UI.SplashController.SplashConfigOverride[]i18nSplashConfigOverrides  // 0x20
METHODS:
END_CLASS

CLASS: <>c__DisplayClass31_0
TYPE:  sealed class
TOKEN: 0x200004F
SIZE:  0x28
FIELDS:
  public            Beyond.UI.SplashController.SplashConfigconfig  // 0x10
  public            Beyond.UI.SplashController      <>4__this  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60001A7  System.Void .ctor()
  RVA=0x03CF5200  token=0x60001A8  System.Void <_DoStartSplash>b__0()
  RVA=0x03CC4460  token=0x60001A9  System.Void <_DoStartSplash>b__2()
END_CLASS

CLASS: <_OnSplashCompleteCoroutine>d__33
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.UI.SplashController      <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001AA  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001AB  System.Void System.IDisposable.Dispose()
  RVA=0x0229E690  token=0x60001AC  System.Boolean MoveNext()
  RVA=0x0577004C  token=0x60001AE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_StartLicenseCoroutine>d__34
TYPE:  sealed class
TOKEN: 0x2000051
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           System.Boolean                  <displayCursor>5__2  // 0x20
  private           System.Boolean                  <usingController>5__3  // 0x21
  private           System.Boolean                  <isGranted>5__4  // 0x22
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001B0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001B1  System.Void System.IDisposable.Dispose()
  RVA=0x02D7A0D0  token=0x60001B2  System.Boolean MoveNext()
  RVA=0x057707AC  token=0x60001B4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: HttpPostRequest
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x38
FIELDS:
  public            System.String                   url  // 0x10
  public            System.String                   param  // 0x18
  public            System.String                   contentType  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.String>header  // 0x28
  public            System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse>callback  // 0x30
METHODS:
END_CLASS

CLASS: HttpGetRequest
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x20
FIELDS:
  public            System.String                   url  // 0x10
  public            System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse>callback  // 0x18
METHODS:
END_CLASS

CLASS: WebHttpResponse
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x40
FIELDS:
  public            System.Boolean                  isTimeout  // 0x10
  public            System.Boolean                  isError  // 0x11
  public            System.Int64                    responseCode  // 0x18
  public            System.Collections.Generic.Dictionary<System.String,System.String>header  // 0x20
  public            System.String                   text  // 0x28
  public            System.Byte[]                   data  // 0x30
  public            System.String                   error  // 0x38
METHODS:
END_CLASS

CLASS: HTTPOptType
TYPE:  sealed struct
TOKEN: 0x2000057
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.SDK.SDKNetUtils.HTTPOptTypeGET  // const
  public    static  Beyond.SDK.SDKNetUtils.HTTPOptTypePOST  // const
METHODS:
END_CLASS

CLASS: HTTPConfig
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x40
FIELDS:
  public            System.String                   url  // 0x10
  public            System.String                   body  // 0x18
  public            System.String                   contentType  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.String>header  // 0x28
  public            Beyond.SDK.SDKNetUtils.HTTPOptTypeoptType  // 0x30
  public            System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse>callback  // 0x38
METHODS:
END_CLASS

CLASS: HTTPImpl
TYPE:  abstract class
TOKEN: 0x2000059
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60001BB  System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config)
  RVA=0x0350B670  token=0x60001BC  System.Void .ctor()
END_CLASS

CLASS: <DoHTTP>d__0
TYPE:  sealed class
TOKEN: 0x200005B
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.SDK.SDKNetUtils.HTTPConfigconfig  // 0x20
  private           Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result><sendTask>5__2  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001BF  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001C0  System.Void System.IDisposable.Dispose()
  RVA=0x0576F470  token=0x60001C1  System.Boolean MoveNext()
  RVA=0x0576F70C  token=0x60001C3  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: BeyondHttp
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x10
EXTENDS: HTTPImpl
FIELDS:
METHODS:
  RVA=0x0576C290  token=0x60001BD  System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config)
  RVA=0x0350B670  token=0x60001BE  System.Void .ctor()
END_CLASS

CLASS: FHGSDKInit
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x12
FIELDS:
  public            System.Boolean                  isIniting  // 0x10
  public            System.Boolean                  isInited  // 0x11
METHODS:
END_CLASS

CLASS: <FetchCaptchaCoroutine>d__3
TYPE:  sealed class
TOKEN: 0x2000060
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   captchaParams  // 0x20
  public            Beyond.SDK.Impl.U8ExternalTools.CaptchaHandler<>4__this  // 0x28
  public            U8.SDK.SDKCaptchaHandler.Result outResult  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001E8  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001E9  System.Void System.IDisposable.Dispose()
  RVA=0x05777174  token=0x60001EA  System.Boolean MoveNext()
  RVA=0x05777268  token=0x60001EC  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: CaptchaHandler
TYPE:  class
TOKEN: 0x200005F
SIZE:  0x20
EXTENDS: U8.SDK.SDKCaptchaHandler
FIELDS:
  private   static  System.Int32                    FAILED  // const
  private           System.Int64                    m_flag  // 0x10
  private           System.String                   m_desc  // 0x18
METHODS:
  RVA=0x0577288C  token=0x60001E5  System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult)
  RVA=0x05772954  token=0x60001E6  System.Void OnGT3Message(System.Collections.Generic.Dictionary<System.String,System.Object> msg)
  RVA=0x03D55790  token=0x60001E7  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000061
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.SDK.Impl.U8ExternalTools.<>c<>9  // static @ 0x0
  public    static  System.Action<System.Object>    <>9__9_0  // static @ 0x8
  public    static  System.Action<System.String>    <>9__9_1  // static @ 0x10
  public    static  System.Action                   <>9__27_0  // static @ 0x18
METHODS:
  RVA=0x03D18530  token=0x60001EE  System.Void .cctor()
  RVA=0x0350B670  token=0x60001EF  System.Void .ctor()
  RVA=0x057772B4  token=0x60001F0  System.Void <InitSDKSystem>b__9_0(System.Object error)
  RVA=0x039CAB10  token=0x60001F1  System.Void <InitSDKSystem>b__9_1(System.String rawExtConfig)
  RVA=0x05777474  token=0x60001F2  System.Void <_ProcessExtraInfo>b__27_0()
END_CLASS

CLASS: <WaitForInited>d__10
TYPE:  sealed class
TOKEN: 0x2000062
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001F3  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001F4  System.Void System.IDisposable.Dispose()
  RVA=0x03B3CE50  token=0x60001F5  System.Boolean MoveNext()
  RVA=0x05777800  token=0x60001F7  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <WaitForInitHGSDK>d__15
TYPE:  sealed class
TOKEN: 0x2000063
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60001F9  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001FA  System.Void System.IDisposable.Dispose()
  RVA=0x03C9C180  token=0x60001FB  System.Boolean MoveNext()
  RVA=0x057777B4  token=0x60001FD  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass25_0
TYPE:  sealed class
TOKEN: 0x2000064
SIZE:  0x18
FIELDS:
  public            System.Action<U8.SDK.SDKExternalTools.POSTResult>callback  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60001FF  System.Void .ctor()
  RVA=0x05777500  token=0x6000200  System.Void <POSTImplementation>b__0(Beyond.SDK.SDKNetUtils.WebHttpResponse webRequest)
END_CLASS

CLASS: <>c__DisplayClass7_0
TYPE:  sealed class
TOKEN: 0x2000066
SIZE:  0x30
FIELDS:
  public            U8.SDK.ExternalPluginPayParams  args  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600020D  System.Void .ctor()
  RVA=0x05777694  token=0x600020E  System.Void <Pay>b__0(U8.SDK.U8PayResult payResult)
  RVA=0x057776CC  token=0x600020F  System.Void <Pay>b__1(System.Object failMsg)
END_CLASS

CLASS: <>c__DisplayClass10_0
TYPE:  sealed class
TOKEN: 0x2000067
SIZE:  0x38
FIELDS:
  public            U8.SDK.ExternalPluginLoginParamsargs  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000210  System.Void .ctor()
  RVA=0x03157E60  token=0x6000211  System.Void <_MockLogin>b__0(System.String uid)
END_CLASS

CLASS: AppVersionRespone
TYPE:  class
TOKEN: 0x2000069
SIZE:  0x18
FIELDS:
  public            System.Int32                    action  // 0x10
  public            System.Int32                    state  // 0x14
METHODS:
  RVA=0x0350B670  token=0x600021C  System.Void .ctor()
END_CLASS

CLASS: <_CheckForUpdateCoroutine>d__4
TYPE:  sealed class
TOKEN: 0x200006A
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginCheckForUpdateNode<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600021D  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600021E  System.Void System.IDisposable.Dispose()
  RVA=0x02C3CBC0  token=0x600021F  System.Boolean MoveNext()
  RVA=0x05777B30  token=0x6000221  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <AlertNoMatchDeviceBeforeLogin>d__5
TYPE:  sealed class
TOKEN: 0x200006B
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000223  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000224  System.Void System.IDisposable.Dispose()
  RVA=0x03B31500  token=0x6000225  System.Boolean MoveNext()
  RVA=0x05776AF0  token=0x6000227  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_CheckForUpdateCoroutineMobile>d__6
TYPE:  sealed class
TOKEN: 0x200006C
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginCheckForUpdateNode<>4__this  // 0x20
  private           Beyond.Login.LoginGameUpdater.Result<result>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000229  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600022A  System.Void System.IDisposable.Dispose()
  RVA=0x0577784C  token=0x600022B  System.Boolean MoveNext()
  RVA=0x05777A98  token=0x600022D  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_CheckForUpdateCoroutinePC>d__8
TYPE:  sealed class
TOKEN: 0x200006D
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginCheckForUpdateNode<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600022F  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000230  System.Void System.IDisposable.Dispose()
  RVA=0x03B298A0  token=0x6000231  System.Boolean MoveNext()
  RVA=0x05777AE4  token=0x6000233  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_CheckForUpdatePC>d__9
TYPE:  sealed class
TOKEN: 0x200006E
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginCheckForUpdateNode<>4__this  // 0x20
  private           Beyond.Misc.ObjectRef           <actionRef>5__2  // 0x28
  private           System.String                   <errorInfo>5__3  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000235  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000236  System.Void System.IDisposable.Dispose()
  RVA=0x03922230  token=0x6000237  System.Boolean MoveNext()
  RVA=0x05777B7C  token=0x6000239  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GetOnlineAppVersion>d__11
TYPE:  sealed class
TOKEN: 0x200006F
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginCheckForUpdateNode<>4__this  // 0x20
  public            Beyond.Misc.ObjectRef           outRef  // 0x28
  private           System.String                   <url>5__2  // 0x30
  private           Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<Beyond.Login.LoginCheckForUpdateNode.AppVersionRespone>><httpResIndex>5__3  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600023B  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600023C  System.Void System.IDisposable.Dispose()
  RVA=0x0229C7F0  token=0x600023D  System.Boolean MoveNext()
  RVA=0x0577902C  token=0x600023F  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: WorkProcess
TYPE:  class
TOKEN: 0x2000071
SIZE:  0x20
EXTENDS: UnityEngine.CustomYieldInstruction
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Beyond.Login.LoginCreateRoleNodem_closure  // 0x10
  private           System.Boolean                  m_isFinished  // 0x18
PROPERTIES:
  keepWaiting  get=0x03D032E0
METHODS:
  RVA=0x0426FEE0  token=0x6000248  System.Void .ctor(Beyond.Login.LoginCreateRoleNode closure)
  RVA=0x0577BEA8  token=0x600024A  System.Void Dispose()
END_CLASS

CLASS: <>c__DisplayClass24_0
TYPE:  sealed class
TOKEN: 0x2000073
SIZE:  0x20
FIELDS:
  public            Beyond.Login.LoginDownloadTask  <>4__this  // 0x10
  public            Beyond.SDK.HGDownloader.PauseReasonreason  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600025A  System.Void .ctor()
  RVA=0x0103D340  token=0x600025B  System.Void <_OnDownloadPaused>b__1()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000074
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Login.LoginDownloadTask.<>c<>9  // static @ 0x0
  public    static  System.Action                   <>9__24_0  // static @ 0x8
METHODS:
  RVA=0x05777750  token=0x600025C  System.Void .cctor()
  RVA=0x0350B670  token=0x600025D  System.Void .ctor()
  RVA=0x0103C3B0  token=0x600025E  System.Void <_OnDownloadPaused>b__24_0()
END_CLASS

CLASS: <_GameUpdateCoroutine>d__5
TYPE:  sealed class
TOKEN: 0x2000077
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600026A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600026B  System.Void System.IDisposable.Dispose()
  RVA=0x03D4C410  token=0x600026C  System.Boolean MoveNext()
  RVA=0x05778400  token=0x600026E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GameUpdateCoroutineMobileImpl>d__6
TYPE:  sealed class
TOKEN: 0x2000078
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdateNode<>4__this  // 0x20
  private           Beyond.Login.LoginGameUpdater.Result<result>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000270  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000271  System.Void System.IDisposable.Dispose()
  RVA=0x057781D8  token=0x6000272  System.Boolean MoveNext()
  RVA=0x057783B4  token=0x6000274  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: CodeType
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2103  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2105  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2200  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2201  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2202  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2203  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2204  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2205  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2206  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2207  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2208  // const
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2209  // const
METHODS:
END_CLASS

CLASS: UpdateType
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeFullUpdate  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeIncrementalUpdate  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToBilibile  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToTaptap  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToAppStore  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToGooglePlay  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToSamsungStore  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToRustore  // const
METHODS:
END_CLASS

CLASS: UpdateCode
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.UpdateCodeSuccess  // const
METHODS:
END_CLASS

CLASS: UpdateAction
TYPE:  sealed struct
TOKEN: 0x200007D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionInvalid  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionLatest  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionForcedUpdate  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionOptionalUpdate  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionError  // const
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionCongestion  // const
METHODS:
END_CLASS

CLASS: HGLatestGameInfo
TYPE:  class
TOKEN: 0x200007E
SIZE:  0x38
FIELDS:
  public            System.Int32                    code  // 0x10
  public            System.String                   version  // 0x18
  public            System.Int32                    action  // 0x20
  public            System.Int32                    updateType  // 0x24
  public            System.String                   updateInfo  // 0x28
  public            System.Int32                    state  // 0x30
METHODS:
  RVA=0x0350B670  token=0x6000287  System.Void .ctor()
END_CLASS

CLASS: NotificationTitleConfig
TYPE:  class
TOKEN: 0x200007F
SIZE:  0x20
FIELDS:
  public            System.String                   downloading  // 0x10
  public            System.String                   pause  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000288  System.Void .ctor()
END_CLASS

CLASS: HGUpdateConfig
TYPE:  class
TOKEN: 0x2000080
SIZE:  0x18
FIELDS:
  public            System.String                   downloadPath  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000289  System.Void .ctor()
END_CLASS

CLASS: Options
TYPE:  sealed struct
TOKEN: 0x2000081
SIZE:  0x28
FIELDS:
  public            Beyond.Login.NetUsagePolicy     netUsagePolicy  // 0x10
  public            System.Action<System.String,System.Action>alertDialog  // 0x18
  public            Beyond.LoginContext             loginContext  // 0x20
METHODS:
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x2000082
SIZE:  0x28
FIELDS:
  public            System.Boolean                  needRetry  // 0x10
  public            System.String                   errorInfo  // 0x18
  public            System.Int32                    code  // 0x20
  public            System.Boolean                  auditing  // 0x24
METHODS:
  RVA=0x0350B670  token=0x600028A  System.Void .ctor()
END_CLASS

CLASS: Context
TYPE:  class
TOKEN: 0x2000083
SIZE:  0x40
FIELDS:
  public            System.Int64                    taskId  // 0x10
  public            System.String                   errorInfo  // 0x18
  public            System.String                   logError  // 0x20
  public            System.Boolean                  needClear  // 0x28
  public            Beyond.Login.LoginGameUpdater.HGLatestGameInfogameInfo  // 0x30
  private           System.Boolean                  <complete>k__BackingField  // 0x38
  private           System.Int32                    <code>k__BackingField  // 0x3c
PROPERTIES:
  complete  get=0x03D4F190  set=0x03D4E280
  code  get=0x03D4ED90  set=0x03D4EDC0
METHODS:
  RVA=0x05772A48  token=0x600028F  System.Void CompleteWithCode(System.Int32 pCode)
  RVA=0x05772AA4  token=0x6000290  System.Void UncompleteWithCode(System.Int32 pCode)
  RVA=0x05772B00  token=0x6000291  System.Void .ctor()
END_CLASS

CLASS: <CheckLastGameInfo>d__23
TYPE:  sealed class
TOKEN: 0x2000084
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            Beyond.Login.LoginGameUpdater.Resultresult  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000292  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000293  System.Void System.IDisposable.Dispose()
  RVA=0x05776B3C  token=0x6000294  System.Boolean MoveNext()
  RVA=0x05776D80  token=0x6000296  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <DoUpdate>d__24
TYPE:  sealed class
TOKEN: 0x2000085
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            Beyond.Login.LoginGameUpdater.Resultresult  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000298  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000299  System.Void System.IDisposable.Dispose()
  RVA=0x05776DCC  token=0x600029A  System.Boolean MoveNext()
  RVA=0x05777128  token=0x600029C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GetLastGameInfo>d__25
TYPE:  sealed class
TOKEN: 0x2000086
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            Beyond.Login.LoginGameUpdater.Contextcontext  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600029E  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600029F  System.Void System.IDisposable.Dispose()
  RVA=0x057789D4  token=0x60002A0  System.Boolean MoveNext()
  RVA=0x05778FE0  token=0x60002A2  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_UpdateGame>d__26
TYPE:  sealed class
TOKEN: 0x2000087
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            Beyond.Login.LoginGameUpdater.Contextcontext  // 0x28
  private           Beyond.Login.LoginGameUpdater.HGLatestGameInfo<gameInfo>5__2  // 0x30
  private           System.Int64                    <size>5__3  // 0x38
  private           System.Boolean                  <enableMobileData>5__4  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002A4  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002A5  System.Void System.IDisposable.Dispose()
  RVA=0x0577AA68  token=0x60002A6  System.Boolean MoveNext()
  RVA=0x0577B0E4  token=0x60002A8  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_DoTaskUpdating>d__27
TYPE:  sealed class
TOKEN: 0x2000088
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            Beyond.Login.LoginGameUpdater.Contextcontext  // 0x28
  private           System.Int64                    <taskId>5__2  // 0x30
  private           System.Int32                    <status>5__3  // 0x38
  private           System.Int64                    <curSize>5__4  // 0x40
  private           System.Int64                    <totalSize>5__5  // 0x48
  private           System.Int64                    <speed>5__6  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002AA  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002AB  System.Void System.IDisposable.Dispose()
  RVA=0x05777C60  token=0x60002AC  System.Boolean MoveNext()
  RVA=0x05778140  token=0x60002AE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass32_0
TYPE:  sealed class
TOKEN: 0x2000089
SIZE:  0x18
FIELDS:
  public            System.Boolean                  wait  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002B0  System.Void .ctor()
  RVA=0x03D557C0  token=0x60002B1  System.Void <_YieldErrorAlert>b__0()
END_CLASS

CLASS: <_YieldErrorAlert>d__32
TYPE:  sealed class
TOKEN: 0x200008A
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            System.String                   desc  // 0x28
  private           Beyond.Login.LoginGameUpdater.<>c__DisplayClass32_0<>8__1  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002B2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002B3  System.Void System.IDisposable.Dispose()
  RVA=0x0577B7B0  token=0x60002B4  System.Boolean MoveNext()
  RVA=0x0577B8EC  token=0x60002B6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass33_0
TYPE:  sealed class
TOKEN: 0x200008B
SIZE:  0x18
FIELDS:
  public            System.Boolean                  rejected  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002B8  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass33_1
TYPE:  sealed class
TOKEN: 0x200008C
SIZE:  0x20
FIELDS:
  public            System.Boolean                  complete  // 0x10
  public            Beyond.Login.LoginGameUpdater.<>c__DisplayClass33_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60002B9  System.Void .ctor()
  RVA=0x01168960  token=0x60002BA  System.Void <_YieldCheckNetUsagePolicy>b__0()
  RVA=0x05777564  token=0x60002BB  System.Void <_YieldCheckNetUsagePolicy>b__1()
  RVA=0x01168960  token=0x60002BC  System.Void <_YieldCheckNetUsagePolicy>b__2()
END_CLASS

CLASS: <_YieldCheckNetUsagePolicy>d__33
TYPE:  sealed class
TOKEN: 0x200008D
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           Beyond.Login.LoginGameUpdater.<>c__DisplayClass33_0<>8__1  // 0x20
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x28
  public            System.Int64                    downloadSize  // 0x30
  private           Beyond.Login.LoginGameUpdater.<>c__DisplayClass33_1<>8__2  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002BD  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002BE  System.Void System.IDisposable.Dispose()
  RVA=0x0577B4F8  token=0x60002BF  System.Boolean MoveNext()
  RVA=0x0577B764  token=0x60002C1  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_WaitForTaskCancel>d__34
TYPE:  sealed class
TOKEN: 0x200008E
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGameUpdater   <>4__this  // 0x20
  public            System.Int64                    taskId  // 0x28
  private           System.Boolean                  <isCanceled>5__2  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002C3  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002C4  System.Void System.IDisposable.Dispose()
  RVA=0x0577B304  token=0x60002C5  System.Boolean MoveNext()
  RVA=0x0577B384  token=0x60002C7  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_EnterGameCoroutine>d__11
TYPE:  sealed class
TOKEN: 0x2000091
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGSNode.EnterGameServiceFlow<>4__this  // 0x20
  private           U8.SDK.SDKPromiseEnumerator<U8.SDK.U8AuthV2Result><authPromise>5__2  // 0x28
  private           System.String                   <token>5__3  // 0x30
  private           System.String                   <uid>5__4  // 0x38
  private           Beyond.Misc.ObjectRef           <loginRespRef>5__5  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002E7  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002E8  System.Void System.IDisposable.Dispose()
  RVA=0x02D797E0  token=0x60002E9  System.Boolean MoveNext()
  RVA=0x0577818C  token=0x60002EB  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_NetConnectAndGSLogin>d__12
TYPE:  sealed class
TOKEN: 0x2000092
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Misc.ObjectRef           loginRespRef  // 0x20
  public            Beyond.Login.LoginGSNode.EnterGameServiceFlow<>4__this  // 0x28
  public            System.String                   uid  // 0x30
  public            System.String                   token  // 0x38
  private           Beyond.Network.HGNetSessionConnectYield<connectTask>5__2  // 0x40
  private           System.Int32                    <maxRetryCount>5__3  // 0x48
  private           System.Int32                    <currentRetry>5__4  // 0x4c
  private           Beyond.Network.HGNetSessionLoginYield<loginHandler>5__5  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002ED  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002EE  System.Void System.IDisposable.Dispose()
  RVA=0x0229C260  token=0x60002EF  System.Boolean MoveNext()
  RVA=0x0577A878  token=0x60002F1  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_YieldAlertError>d__14
TYPE:  sealed class
TOKEN: 0x2000093
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   errorInfo  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002F3  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002F4  System.Void System.IDisposable.Dispose()
  RVA=0x0577B41C  token=0x60002F5  System.Boolean MoveNext()
  RVA=0x0577B4AC  token=0x60002F7  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_SaveCurrentUserToServerConfig>d__15
TYPE:  sealed class
TOKEN: 0x2000094
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginGSNode.EnterGameServiceFlow<>4__this  // 0x20
  public            System.String                   uid  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60002F9  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60002FA  System.Void System.IDisposable.Dispose()
  RVA=0x0315A990  token=0x60002FB  System.Boolean MoveNext()
  RVA=0x0577AA1C  token=0x60002FD  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass16_0
TYPE:  sealed class
TOKEN: 0x2000095
SIZE:  0x18
FIELDS:
  public            Beyond.Misc.ObjectRef           waitForCallback  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002FF  System.Void .ctor()
  RVA=0x057774DC  token=0x6000300  System.Void <_MockManualSelectServer>b__0()
END_CLASS

CLASS: <_MockManualSelectServer>d__16
TYPE:  sealed class
TOKEN: 0x2000096
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   uid  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000301  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000302  System.Void System.IDisposable.Dispose()
  RVA=0x0577A6D4  token=0x6000303  System.Boolean MoveNext()
  RVA=0x0577A82C  token=0x6000305  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_OnAuthError>d__17
TYPE:  sealed class
TOKEN: 0x2000097
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Object                   rejectInfo  // 0x20
  public            Beyond.Login.LoginGSNode.EnterGameServiceFlow<>4__this  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000307  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000308  System.Void System.IDisposable.Dispose()
  RVA=0x0577A8C4  token=0x6000309  System.Boolean MoveNext()
  RVA=0x0577A984  token=0x600030B  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: EnterGameServiceFlow
TYPE:  class
TOKEN: 0x2000090
SIZE:  0x30
EXTENDS: UnityEngine.CustomYieldInstruction
FIELDS:
  private           Beyond.LoginContext             m_context  // 0x10
  private           Beyond.Login.LoginGSNode        m_curNode  // 0x18
  private           Beyond.Misc.ObjectRef           m_dialogBlocker  // 0x20
  private           System.Int32                    m_state  // 0x28
PROPERTIES:
  keepWaiting  get=0x0333FE90
METHODS:
  RVA=0x039CF140  token=0x60002D8  System.Void .ctor(Beyond.Login.LoginGSNode node)
  RVA=0x05772BC8  token=0x60002D9  System.Void MarkAborting()
  RVA=0x02D77780  token=0x60002DA  System.Void EnterGame()
  RVA=0x05772B68  token=0x60002DB  System.Boolean IsInterruptable()
  RVA=0x05772C20  token=0x60002DC  System.Boolean TryInterrupt()
  RVA=0x02D778A0  token=0x60002DD  System.Collections.IEnumerator _EnterGameCoroutine()
  RVA=0x02D77BD0  token=0x60002DE  System.Collections.IEnumerator _NetConnectAndGSLogin(System.String uid, System.String token, Beyond.Misc.ObjectRef loginRespRef)
  RVA=0x05772C88  token=0x60002DF  System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout)
  RVA=0x05772F2C  token=0x60002E0  System.Collections.IEnumerator _YieldAlertError(System.String errorInfo)
  RVA=0x0229C660  token=0x60002E1  System.Collections.IEnumerator _SaveCurrentUserToServerConfig(System.String uid)
  RVA=0x05772D84  token=0x60002E2  System.Collections.IEnumerator _MockManualSelectServer(System.String uid)
  RVA=0x05772E20  token=0x60002E3  System.Collections.IEnumerator _OnAuthError(System.Object rejectInfo)
  RVA=0x05772EC8  token=0x60002E4  System.Void _ReLoginWhenErrorEncountered()
  RVA=0x02D759B0  token=0x60002E5  System.Void _GlobalLoginSucBusiness(Proto.MSG_B1 msg)
  RVA=0x03D4D9A0  token=0x60002E6  System.Boolean <_EnterGameCoroutine>b__11_0()
END_CLASS

CLASS: <_ConfirmServer>d__10
TYPE:  sealed class
TOKEN: 0x2000098
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           U8.SDK.SDKPromiseEnumerator<U8.SDK.U8ConfirmServerResult><confirmPromise>5__2  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600030D  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600030E  System.Void System.IDisposable.Dispose()
  RVA=0x02D75BA0  token=0x600030F  System.Boolean MoveNext()
  RVA=0x05777BC8  token=0x6000311  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: IProgress
TYPE:  interface
TOKEN: 0x200009B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000315  System.Double GetTotal()
  RVA=-1  // abstract  token=0x6000316  System.Double GetCurrent()
  RVA=-1  // abstract  token=0x6000317  System.String GetInfo()
END_CLASS

CLASS: SimpleProgress
TYPE:  class
TOKEN: 0x200009C
SIZE:  0x18
IMPLEMENTS: IProgress
FIELDS:
  public            System.Double                   current  // 0x10
METHODS:
  RVA=0x032F1360  token=0x6000318  System.Double GetCurrent()
  RVA=0x032F1530  token=0x6000319  System.Double GetTotal()
  RVA=0x032F15C0  token=0x600031A  System.String GetInfo()
  RVA=0x0350B670  token=0x600031B  System.Void .ctor()
END_CLASS

CLASS: HotUpdateInfo
TYPE:  class
TOKEN: 0x200009E
SIZE:  0x58
FIELDS:
  public            Beyond.Resource.HotUpdate.FResourceDiffresDiff  // 0x10
  public            Beyond.Resource.HotUpdate.LocalResPreflocalResPref  // 0x50
METHODS:
  RVA=0x05772FC8  token=0x6000346  System.Boolean CheckIfNeedReload()
  RVA=0x039CF700  token=0x6000347  System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type)
  RVA=0x05773174  token=0x6000348  System.Boolean HasAssetsChanged()
  RVA=0x0350B670  token=0x6000349  System.Void .ctor()
END_CLASS

CLASS: WorkContext
TYPE:  class
TOKEN: 0x200009F
SIZE:  0x48
FIELDS:
  public            Beyond.Login.LoginHotUpdater.HotUpdateInfoupdateInitial  // 0x10
  public            Beyond.Login.LoginHotUpdater.HotUpdateInfoupdateMain  // 0x18
  public            System.String                   vitalError  // 0x20
  public            System.Boolean                  reboot  // 0x28
  public            Beyond.Login.NetUsagePolicy     netUsagePolicy  // 0x30
  public            Beyond.Resource.HotUpdate.ResourceIndexresIndex  // 0x38
  private           System.Boolean                  <illegalItemsInLocalRes>k__BackingField  // 0x40
PROPERTIES:
  illegalItemsInLocalRes  get=0x03D4EE90  set=0x03D4EEB0
METHODS:
  RVA=0x0577BE58  token=0x600034C  System.Void MarkIllegalItemsInLocalRes()
  RVA=0x0577BDF4  token=0x600034D  Beyond.Login.LoginHotUpdater.HotUpdateInfo GetHotUpdateInfo(System.Boolean isInitial)
  RVA=0x039CF690  token=0x600034E  System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type)
  RVA=0x02F42420  token=0x600034F  System.Void .ctor()
END_CLASS

CLASS: <_Work>d__27
TYPE:  sealed class
TOKEN: 0x20000A0
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  private           Beyond.Login.LoginHotUpdater.WorkContext<workContext>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000350  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000351  System.Void System.IDisposable.Dispose()
  RVA=0x02F42170  token=0x6000352  System.Boolean MoveNext()
  RVA=0x0577B3D0  token=0x6000354  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_CreateMainCoroutine>d__28
TYPE:  sealed class
TOKEN: 0x20000A1
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000356  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000357  System.Void System.IDisposable.Dispose()
  RVA=0x0399E9C0  token=0x6000358  System.Boolean MoveNext()
  RVA=0x05777C14  token=0x600035A  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_MainCoroutineModeSkip>d__29
TYPE:  sealed class
TOKEN: 0x20000A2
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            Beyond.Login.LoginHotUpdater.WorkContextcontext  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600035C  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600035D  System.Void System.IDisposable.Dispose()
  RVA=0x03B21B80  token=0x600035E  System.Boolean MoveNext()
  RVA=0x0577A688  token=0x6000360  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_MainCoroutineModeLocal>d__30
TYPE:  sealed class
TOKEN: 0x20000A3
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            Beyond.Login.LoginHotUpdater.WorkContextcontext  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000362  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000363  System.Void System.IDisposable.Dispose()
  RVA=0x0577A4FC  token=0x6000364  System.Boolean MoveNext()
  RVA=0x0577A63C  token=0x6000366  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_UpdateResVersion>d__31
TYPE:  sealed class
TOKEN: 0x20000A4
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000368  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000369  System.Void System.IDisposable.Dispose()
  RVA=0x03B387B0  token=0x600036A  System.Boolean MoveNext()
  RVA=0x0577B2B8  token=0x600036C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_UpdateResVersionDev>d__35
TYPE:  sealed class
TOKEN: 0x20000A5
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           Beyond.Cfg.ResVersionDevCfg     <config>5__2  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600036E  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600036F  System.Void System.IDisposable.Dispose()
  RVA=0x0577B130  token=0x6000370  System.Boolean MoveNext()
  RVA=0x0577B220  token=0x6000372  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_UpdateResVersionProd>d__37
TYPE:  sealed class
TOKEN: 0x20000A6
SIZE:  0x40
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x20
  private           Beyond.Cfg.ResVersionCfg        <config>5__2  // 0x28
  private           Beyond.Misc.ObjectRef           <resultRef>5__3  // 0x30
  private           System.String                   <url>5__4  // 0x38
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000374  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000375  System.Void System.IDisposable.Dispose()
  RVA=0x02F43380  token=0x6000376  System.Boolean MoveNext()
  RVA=0x0577B26C  token=0x6000378  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass42_0
TYPE:  sealed class
TOKEN: 0x20000A7
SIZE:  0x18
FIELDS:
  public            System.Boolean                  isInitial  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600037A  System.Void .ctor()
  RVA=0x05777584  token=0x600037B  Beyond.Resource.HotUpdate.LocalResPref <_MainCoroutineModeDownload>b__0()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000A8
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Login.LoginHotUpdater.<>c<>9  // static @ 0x0
  public    static  System.Action                   <>9__42_1  // static @ 0x8
METHODS:
  RVA=0x057776EC  token=0x600037C  System.Void .cctor()
  RVA=0x0350B670  token=0x600037D  System.Void .ctor()
  RVA=0x05777444  token=0x600037E  System.Void <_MainCoroutineModeDownload>b__42_1()
END_CLASS

CLASS: <_MainCoroutineModeDownload>d__42
TYPE:  sealed class
TOKEN: 0x20000A9
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x28
  private           Beyond.Login.LoginHotUpdater.<>c__DisplayClass42_0<>8__1  // 0x30
  private           System.Boolean                  <initialDownloaded>5__2  // 0x38
  private           System.Boolean                  <needDeleteInitial>5__3  // 0x39
  private           System.Boolean                  <neewDeleteMain>5__4  // 0x3a
  private           System.Int32                    <initialOrMain>5__5  // 0x3c
  private           System.String                   <onlineResVersion>5__6  // 0x40
  private           Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.LocalResPref><waitForResPref>5__7  // 0x48
  private           Beyond.Login.LoginHotUpdater.HotUpdateInfo<info>5__8  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600037F  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000380  System.Void System.IDisposable.Dispose()
  RVA=0x05779708  token=0x6000381  System.Boolean MoveNext()
  RVA=0x0577A4B0  token=0x6000383  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_ReloadResourceIndexes>d__43
TYPE:  sealed class
TOKEN: 0x20000AA
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000385  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000386  System.Void System.IDisposable.Dispose()
  RVA=0x02F57720  token=0x6000387  System.Boolean MoveNext()
  RVA=0x0577A9D0  token=0x6000389  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass44_0
TYPE:  sealed class
TOKEN: 0x20000AB
SIZE:  0x28
FIELDS:
  public            System.String                   filePath  // 0x10
  public            Beyond.Resource.HotUpdate.ResourceIndexresIndex  // 0x18
  public            System.Func<Beyond.Resource.HotUpdate.ResourceIndex><>9__1  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600038B  System.Void .ctor()
  RVA=0x05777634  token=0x600038C  Beyond.Resource.HotUpdate.ResourceIndex <_LoadOrDownloadResIndex>b__1()
  RVA=0x057775F8  token=0x600038D  System.Object <_LoadOrDownloadResIndex>b__0()
END_CLASS

CLASS: <_LoadOrDownloadResIndex>d__44
TYPE:  sealed class
TOKEN: 0x20000AC
SIZE:  0x60
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Boolean                  isInitial  // 0x20
  private           Beyond.Login.LoginHotUpdater.<>c__DisplayClass44_0<>8__1  // 0x28
  public            System.String                   onlineVer  // 0x30
  public            Beyond.Misc.ObjectRef           resIndexRef  // 0x38
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x40
  private           System.String                   <indexUrl>5__2  // 0x48
  private           Beyond.Misc.ObjectRef           <resultRef>5__3  // 0x50
  private           Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.ResourceIndex><loadTask>5__4  // 0x58
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600038E  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600038F  System.Void System.IDisposable.Dispose()
  RVA=0x05779078  token=0x6000390  System.Boolean MoveNext()
  RVA=0x057796BC  token=0x6000392  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GenResIndex>d__45
TYPE:  sealed class
TOKEN: 0x20000AD
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            System.String                   onlineVer  // 0x28
  public            System.Boolean                  isInitial  // 0x30
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x38
  private           Beyond.Misc.ObjectRef           <resIndexRef>5__2  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000394  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000395  System.Void System.IDisposable.Dispose()
  RVA=0x0577844C  token=0x6000396  System.Boolean MoveNext()
  RVA=0x05778588  token=0x6000398  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GenRiff>d__46
TYPE:  sealed class
TOKEN: 0x20000AE
SIZE:  0x78
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x20
  public            System.Boolean                  isInitial  // 0x28
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x30
  public            System.String                   onlineVer  // 0x38
  private           Beyond.Login.LoginHotUpdater.HotUpdateInfo<info>5__2  // 0x40
  private           Beyond.Resource.HotUpdate.LocalResPref<localResPref>5__3  // 0x48
  private           System.String                   <rootUrl>5__4  // 0x50
  private           System.String                   <patchUrl>5__5  // 0x58
  private           System.String                   <fileUrl>5__6  // 0x60
  private           Beyond.Resource.HotUpdate.ResourceIndex<resIndex>5__7  // 0x68
  private           Beyond.Misc.ObjectRef           <streamingIndexRef>5__8  // 0x70
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600039A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600039B  System.Void System.IDisposable.Dispose()
  RVA=0x057785D4  token=0x600039C  System.Boolean MoveNext()
  RVA=0x05778988  token=0x600039E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GenLocalRef>d__48
TYPE:  sealed class
TOKEN: 0x20000AF
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x20
  public            System.Boolean                  isInitial  // 0x28
  public            System.String                   onlineVer  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003A0  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003A1  System.Void System.IDisposable.Dispose()
  RVA=0x01041100  token=0x60003A2  System.Boolean MoveNext()
  RVA=0x01041B50  token=0x60003A4  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_CheckAndDownloadResource>d__49
TYPE:  sealed class
TOKEN: 0x20000B0
SIZE:  0x78
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x20
  public            System.Boolean                  isInitial  // 0x28
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x30
  public            System.String                   onlineVer  // 0x38
  private           Beyond.Login.LoginHotUpdater.HotUpdateInfo<info>5__2  // 0x40
  private           Beyond.Login.LoginHotUpdateModel<hotUpdateModel>5__3  // 0x48
  private           System.String                   <patchInfo>5__4  // 0x50
  private           Beyond.Login.LoginDownloadTask  <downloadTask>5__5  // 0x58
  private           Beyond.SDK.HGDownloader.WorkState<lastWorkState>5__6  // 0x60
  private           System.Boolean                  <progress5>5__7  // 0x64
  private           System.Boolean                  <progress25>5__8  // 0x65
  private           System.Boolean                  <progress50>5__9  // 0x66
  private           System.Boolean                  <progress75>5__10  // 0x67
  private           System.Boolean                  <progress90>5__11  // 0x68
  private           Beyond.Misc.ObjectRef           <patchInfoRef>5__12  // 0x70
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003A6  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003A7  System.Void System.IDisposable.Dispose()
  RVA=0x0103D370  token=0x60003A8  System.Boolean MoveNext()
  RVA=0x010410A0  token=0x60003AA  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_DownloadPatchInfo>d__51
TYPE:  sealed class
TOKEN: 0x20000B1
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            System.String                   onlineVer  // 0x28
  public            System.Boolean                  isInitial  // 0x30
  public            Beyond.Misc.ObjectRef           patchInfoRef  // 0x38
  private           System.String                   <patchInfoUrl>5__2  // 0x40
  private           Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<Beyond.Resource.HotUpdate.PatchInfo>><httpResIndex>5__3  // 0x48
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003AC  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003AD  System.Void System.IDisposable.Dispose()
  RVA=0x01048EE0  token=0x60003AE  System.Boolean MoveNext()
  RVA=0x0104B300  token=0x60003B0  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_ClearDownloadFolder>d__52
TYPE:  sealed class
TOKEN: 0x20000B2
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            System.Boolean                  needDeleteInitial  // 0x28
  public            System.Boolean                  needDeleteMain  // 0x29
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x30
  private           System.Collections.Generic.List<Beyond.SDK.HGFolder><folderList>5__2  // 0x38
  private           System.Int32                    <initialOrMain>5__3  // 0x40
  private           System.Boolean                  <isInitial>5__4  // 0x44
  private           System.String                   <onlineVer>5__5  // 0x48
  private           Beyond.Login.LoginHotUpdater.HotUpdateInfo<info>5__6  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003B2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003B3  System.Void System.IDisposable.Dispose()
  RVA=0x01045480  token=0x60003B4  System.Boolean MoveNext()
  RVA=0x01048E90  token=0x60003B6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_CheckLocalResConsistency>d__53
TYPE:  sealed class
TOKEN: 0x20000B3
SIZE:  0x68
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater.WorkContextcontext  // 0x20
  public            System.Boolean                  isInitial  // 0x28
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x30
  public            System.String                   onlineVer  // 0x38
  private           Beyond.Resource.HotUpdate.LocalResPref<localResInfo>5__2  // 0x40
  private           Beyond.Misc.ObjectRef           <resIndexRef>5__3  // 0x48
  private           System.Boolean                  <showProgress>5__4  // 0x50
  private           Beyond.WaitForAsyncTask<System.Object><checkTask>5__5  // 0x58
  private           Beyond.Resource.HotUpdate.LocalResChecker.CheckOutput<checkOutput>5__6  // 0x60
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003B8  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003B9  System.Void System.IDisposable.Dispose()
  RVA=0x01041BD0  token=0x60003BA  System.Boolean MoveNext()
  RVA=0x01045430  token=0x60003BC  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_VitalError>d__54
TYPE:  sealed class
TOKEN: 0x20000B4
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginHotUpdater    <>4__this  // 0x20
  public            System.String                   error  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003BE  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003BF  System.Void System.IDisposable.Dispose()
  RVA=0x0104DAC0  token=0x60003C0  System.Boolean MoveNext()
  RVA=0x0104E7A0  token=0x60003C2  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass55_0
TYPE:  sealed class
TOKEN: 0x20000B5
SIZE:  0x18
FIELDS:
  public            Beyond.RuntimeFileUtils.StreamingResultindexRet  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003C4  System.Void .ctor()
  RVA=0x01041BA0  token=0x60003C5  Beyond.Resource.HotUpdate.ResourceIndex <_LoadStreamingIndex>b__0()
END_CLASS

CLASS: <_LoadStreamingIndex>d__55
TYPE:  sealed class
TOKEN: 0x20000B6
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Boolean                  isInitial  // 0x20
  private           Beyond.Login.LoginHotUpdater.<>c__DisplayClass55_0<>8__1  // 0x28
  public            Beyond.Misc.ObjectRef           resultRef  // 0x30
  public            Beyond.Login.LoginHotUpdater.WorkContextworkContext  // 0x38
  private           System.String                   <indexPath>5__2  // 0x40
  private           Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.ResourceIndex><waitForIndex>5__3  // 0x48
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003C6  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003C7  System.Void System.IDisposable.Dispose()
  RVA=0x0104B350  token=0x60003C8  System.Boolean MoveNext()
  RVA=0x0104DA70  token=0x60003CA  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: EUnit
TYPE:  sealed struct
TOKEN: 0x20000B9
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitNONE  // const
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitB  // const
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitKB  // const
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitMB  // const
METHODS:
END_CLASS

CLASS: FDownloadSize
TYPE:  sealed struct
TOKEN: 0x20000B8
SIZE:  0x30
FIELDS:
  private   static  System.Double                   MB  // const
  private   static  System.Double                   KB  // const
  private           Beyond.Login.LoginProgress.FDownloadSize.EUnitm_unit  // 0x10
  private           System.Single                   m_displayCurrent  // 0x14
  private           System.Single                   m_displayTotal  // 0x18
  private           System.Single                   m_displaySpeed  // 0x1c
  public            System.String                   displayInfo  // 0x20
  private           System.Single                   m_current  // 0x28
  private           System.Single                   m_total  // 0x2c
METHODS:
  RVA=0x0577C668  token=0x60003D0  System.Void SetProgress(System.Double current, System.Double total)
  RVA=0x0577C59C  token=0x60003D1  System.Void SetIdle()
  RVA=0x0577C778  token=0x60003D2  System.Void SetSize(System.Double current, System.Double total, System.Double speed)
  RVA=0x0577CCEC  token=0x60003D3  Beyond.Login.LoginProgress.FDownloadSize.EUnit _PickUnit(System.Double number)
  RVA=0x0577C978  token=0x60003D4  System.Single _DisplayWithUnit(System.Double number, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit)
  RVA=0x0577CA18  token=0x60003D5  System.String _FormatDisplayInfo(System.Single current, System.Single total, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit)
  RVA=0x0577CBFC  token=0x60003D6  System.String _FormatSpeedInfo(System.Single speed, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit)
  RVA=0x0577CB4C  token=0x60003D7  System.String _FormatProgressInfo(System.Single current, System.Single total)
END_CLASS

CLASS: <_InitCoroutine>d__4
TYPE:  sealed class
TOKEN: 0x20000BB
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginInitNode      <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003DE  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003DF  System.Void System.IDisposable.Dispose()
  RVA=0x03893BF0  token=0x60003E0  System.Boolean MoveNext()
  RVA=0x05782148  token=0x60003E2  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_InitRemoteConfigs>d__5
TYPE:  sealed class
TOKEN: 0x20000BC
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginInitNode      <>4__this  // 0x20
  private           Beyond.Network.NetConfigInterface.InitYiedInstruction<initNetConfig>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003E4  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003E5  System.Void System.IDisposable.Dispose()
  RVA=0x0315AE20  token=0x60003E6  System.Boolean MoveNext()
  RVA=0x05782194  token=0x60003E8  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_YieldAlertError>d__6
TYPE:  sealed class
TOKEN: 0x20000BD
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   errorInfo  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003EA  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003EB  System.Void System.IDisposable.Dispose()
  RVA=0x057823A8  token=0x60003EC  System.Boolean MoveNext()
  RVA=0x05782438  token=0x60003EE  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x20000BF
SIZE:  0x20
FIELDS:
  public            System.String                   indexPath  // 0x10
  public            System.String                   prefPath  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60003F3  System.Void .ctor()
  RVA=0x057805C0  token=0x60003F4  Beyond.Resource.HotUpdate.ResourceIndex <Work>b__0()
  RVA=0x05780610  token=0x60003F5  Beyond.Resource.HotUpdate.LocalResPref <Work>b__1()
END_CLASS

CLASS: <Work>d__3
TYPE:  sealed class
TOKEN: 0x20000C0
SIZE:  0x80
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginLocalResTask  <>4__this  // 0x20
  private           Beyond.Login.LoginLocalResTask.<>c__DisplayClass3_0<>8__1  // 0x28
  private           Beyond.Login.LoginHotUpdater.WorkContext<workContext>5__2  // 0x30
  private           Beyond.Login.LoginHotUpdateProp <viewProp>5__3  // 0x38
  private           Beyond.Login.LoginHotUpdateModel<viewModel>5__4  // 0x40
  private           Beyond.Resource.HotUpdate.ResourceIndex[]<resIndexList>5__5  // 0x48
  private           System.Int32                    <initialOrMain>5__6  // 0x50
  private           System.Boolean                  <isInitial>5__7  // 0x54
  private           Beyond.WaitForAsyncTask<Beyond.Resource.HotUpdate.ResourceIndex><waitForResIndex>5__8  // 0x58
  private           Beyond.Resource.RootCategory    <rootCategory>5__9  // 0x60
  private           Beyond.Login.LoginHotUpdateModel.SimpleProgress<progress>5__10  // 0x68
  private           Beyond.WaitForAsyncTask<System.Object><checkTask>5__11  // 0x70
  private           Beyond.Resource.HotUpdate.LocalResChecker.CheckOutput<checkOutput>5__12  // 0x78
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60003F6  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60003F7  System.Void System.IDisposable.Dispose()
  RVA=0x0578077C  token=0x60003F8  System.Boolean MoveNext()
  RVA=0x057816B8  token=0x60003FA  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000C2
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Login.PreloadNode.<>c    <>9  // static @ 0x0
  public    static  System.Func<System.Boolean>     <>9__5_0  // static @ 0x8
METHODS:
  RVA=0x03D1A570  token=0x6000408  System.Void .cctor()
  RVA=0x0350B670  token=0x6000409  System.Void .ctor()
  RVA=0x028AC600  token=0x600040A  System.Boolean <Work>b__5_0()
END_CLASS

CLASS: <_LoginPreLoad>d__7
TYPE:  sealed class
TOKEN: 0x20000C3
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.PreloadNode        <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600040B  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600040C  System.Void System.IDisposable.Dispose()
  RVA=0x02C34DC0  token=0x600040D  System.Boolean MoveNext()
  RVA=0x05782278  token=0x600040F  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_WarmUp>d__8
TYPE:  sealed class
TOKEN: 0x20000C4
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.PreloadNode        <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000411  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000412  System.Void System.IDisposable.Dispose()
  RVA=0x03745D60  token=0x6000413  System.Boolean MoveNext()
  RVA=0x0578235C  token=0x6000415  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GetServerList>d__9
TYPE:  sealed class
TOKEN: 0x20000C5
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.PreloadNode        <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000417  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000418  System.Void System.IDisposable.Dispose()
  RVA=0x02D76F70  token=0x6000419  System.Boolean MoveNext()
  RVA=0x057820FC  token=0x600041B  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GetServerListInfoMock>d__11
TYPE:  sealed class
TOKEN: 0x20000C6
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.PreloadNode        <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600041D  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600041E  System.Void System.IDisposable.Dispose()
  RVA=0x02D75180  token=0x600041F  System.Boolean MoveNext()
  RVA=0x05781AC8  token=0x6000421  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_GetServerListInfo>d__12
TYPE:  sealed class
TOKEN: 0x20000C7
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.PreloadNode        <>4__this  // 0x20
  private           U8.SDK.SDKPromiseEnumerator<System.Collections.Generic.List<U8.SDK.U8ServerInfo>><getServerListPromise>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000423  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000424  System.Void System.IDisposable.Dispose()
  RVA=0x05781B14  token=0x6000425  System.Boolean MoveNext()
  RVA=0x057820B0  token=0x6000427  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <>c__DisplayClass13_0
TYPE:  sealed class
TOKEN: 0x20000C8
SIZE:  0x28
FIELDS:
  public            System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData>serverZoneDataList  // 0x10
  public            System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo>serverList  // 0x18
  public            System.Action<Hypergryph.SpeedTest.SpeedTestResult>callback  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000429  System.Void .ctor()
  RVA=0x0578020C  token=0x600042A  System.Void <_OnGetServerListSuc>b__0(Hypergryph.SpeedTest.SpeedTestResult result)
  RVA=0x05780558  token=0x600042B  System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> <_OnGetServerListSuc>b__1()
END_CLASS

CLASS: <_SDKInitCoroutine>d__4
TYPE:  sealed class
TOKEN: 0x20000CA
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginSDKInitNode   <>4__this  // 0x20
  private           System.String                   <env>5__2  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000432  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000433  System.Void System.IDisposable.Dispose()
  RVA=0x02D78C10  token=0x6000434  System.Boolean MoveNext()
  RVA=0x057822C4  token=0x6000436  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_WaitForSDKInited>d__5
TYPE:  sealed class
TOKEN: 0x20000CB
SIZE:  0x20
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000438  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000439  System.Void System.IDisposable.Dispose()
  RVA=0x03A93F40  token=0x600043A  System.Boolean MoveNext()
  RVA=0x05782310  token=0x600043C  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_InitSubSDKs>d__6
TYPE:  sealed class
TOKEN: 0x20000CC
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.String                   env  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600043E  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600043F  System.Void System.IDisposable.Dispose()
  RVA=0x029554C0  token=0x6000440  System.Boolean MoveNext()
  RVA=0x057821E0  token=0x6000442  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_LoginCoroutine>d__6
TYPE:  sealed class
TOKEN: 0x20000CE
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.U8LoginNode        <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000457  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000458  System.Void System.IDisposable.Dispose()
  RVA=0x02D79040  token=0x6000459  System.Boolean MoveNext()
  RVA=0x0578222C  token=0x600045B  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_FinishLogin>d__7
TYPE:  sealed class
TOKEN: 0x20000CF
SIZE:  0x30
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  private           System.String                   <env>5__2  // 0x20
  private           U8.SDK.SDKPromiseEnumerator<U8.SDK.U8AuthV2Result><authPromise>5__3  // 0x28
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600045D  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600045E  System.Void System.IDisposable.Dispose()
  RVA=0x02D794A0  token=0x600045F  System.Boolean MoveNext()
  RVA=0x05781A7C  token=0x6000461  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: FAgeTipsPolicy
TYPE:  sealed struct
TOKEN: 0x20000D4
SIZE:  0x13
FIELDS:
  public            System.Boolean                  canOpenDetail  // 0x10
  public            System.Boolean                  displayCN  // 0x11
  public            System.Boolean                  displayKR  // 0x12
PROPERTIES:
  display  get=0x02C3B5D0
METHODS:
END_CLASS

CLASS: Node
TYPE:  abstract class
TOKEN: 0x20000D9
SIZE:  0x20
FIELDS:
  private           Beyond.LoginContext             <context>k__BackingField  // 0x10
  private           Beyond.Login.LoginWorkFlow      <workflow>k__BackingField  // 0x18
PROPERTIES:
  context  get=0x020B7B20  set=0x0426FEE0
  workflow  get=0x01041090  set=0x022C3A90
  type  get=-1  // abstract
METHODS:
  RVA=0x02C388D0  token=0x60004A5  System.Void Init(Beyond.LoginContext context, Beyond.Login.LoginWorkFlow workflow)
  RVA=0x02C389B0  token=0x60004A6  System.Void Dispose()
  RVA=-1  // abstract  token=0x60004A8  UnityEngine.CustomYieldInstruction Work()
  RVA=0x0577FFD4  token=0x60004A9  System.Boolean CanCancel()
  RVA=0x05780020  token=0x60004AA  UnityEngine.CustomYieldInstruction Cancel()
  RVA=0x02C38930  token=0x60004AB  System.Void OnInit()
  RVA=0x0379F840  token=0x60004AC  System.Void OnDispose()
  RVA=0x02D758F0  token=0x60004AD  System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param)
  RVA=0x0350B670  token=0x60004AE  System.Void .ctor()
END_CLASS

CLASS: ENode
TYPE:  sealed struct
TOKEN: 0x20000DA
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginWorkFlow.ENodeNone  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeCheckForUpdate  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeSDKInit  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeGameUpdate  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeInit  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeU8Login  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeHotUpdate  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeResCheck  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodePreload  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodePreloadPostDelay  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeTrans2GsLogin  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeGsLogin  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeCreateRole  // const
  public    static  Beyond.Login.LoginWorkFlow.ENodeFinish  // const
METHODS:
END_CLASS

CLASS: IWorkerUpdateOnce
TYPE:  interface
TOKEN: 0x20000DB
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60004AF  System.Void Worker_UpdateOnce()
END_CLASS

CLASS: IEventReceiver
TYPE:  interface
TOKEN: 0x20000DC
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60004B0  System.Void OnEvent(Beyond.ELoginEvent evt, System.Object param)
END_CLASS

CLASS: <Work>d__20
TYPE:  sealed class
TOKEN: 0x20000DE
SIZE:  0x38
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginWorkFlow.Worker<>4__this  // 0x20
  public            UnityEngine.CustomYieldInstructionwork  // 0x28
  private           UnityEngine.CustomYieldInstruction<cancelTask>5__2  // 0x30
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60004BF  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60004C0  System.Void System.IDisposable.Dispose()
  RVA=0x0306D680  token=0x60004C1  System.Boolean MoveNext()
  RVA=0x05780730  token=0x60004C3  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Worker
TYPE:  class
TOKEN: 0x20000DD
SIZE:  0x38
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce>m_updateOnce  // 0x10
  private           System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce>m_buffer  // 0x18
  private           UnityEngine.CustomYieldInstructionm_curWork  // 0x20
  private           System.Boolean                  <isCancelled>k__BackingField  // 0x28
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x29
  private           Beyond.Login.LoginWorkFlow.Node <curNode>k__BackingField  // 0x30
PROPERTIES:
  isCancelled  get=0x03D4ED50  set=0x03D4ED60
  isDisposed  get=0x03D4F2A0  set=0x03D4F2B0
  curNode  get=0x01003830  set=0x04270470
METHODS:
  RVA=0x05782880  token=0x60004B7  System.Boolean Cancel()
  RVA=0x03CF6170  token=0x60004B8  System.Void Dispose()
  RVA=0x02C386D0  token=0x60004B9  System.Void SetCurNode(Beyond.Login.LoginWorkFlow.Node node)
  RVA=0x036007F0  token=0x60004BA  System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst)
  RVA=0x0306D640  token=0x60004BB  System.Void TickInEmptyFrame()
  RVA=0x02C389F0  token=0x60004BC  System.Collections.IEnumerator Work(UnityEngine.CustomYieldInstruction work)
  RVA=0x0306D7C0  token=0x60004BD  System.Void _InternalTick()
  RVA=0x03C95FE0  token=0x60004BE  System.Void .ctor()
END_CLASS

CLASS: FWork
TYPE:  sealed struct
TOKEN: 0x20000DF
SIZE:  0x1C
FIELDS:
  public    static readonly Beyond.Login.LoginWorkFlow.FWorkIDLE  // static @ 0x0
  private           System.Boolean                  <didFallback>k__BackingField  // 0x10
  private           System.Int32                    <nodeIndex>k__BackingField  // 0x14
  private           System.Boolean                  <isWorking>k__BackingField  // 0x18
PROPERTIES:
  didFallback  get=0x03D51020  set=0x03D4F9D0
  nodeIndex  get=0x03D4E990  set=0x03D51720
  isWorking  get=0x03D557D0  set=0x03D557E0
  curNode  get=0x02C39460
METHODS:
  RVA=0x0577CD70  token=0x60004CB  System.Void MarkFallback(System.Int32 newIndex)
  RVA=0x02C39570  token=0x60004CC  System.Boolean ConsumeFallback()
  RVA=0x02C39510  token=0x60004CD  System.Void MoveNextIndex()
  RVA=0x03CE47E0  token=0x60004CE  Beyond.Login.LoginWorkFlow.FWork Start()
  RVA=0x02C38DB0  token=0x60004D0  System.Boolean WorkEnd()
  RVA=0x0350B670  token=0x60004D1  System.Void .cctor()
END_CLASS

CLASS: <DoWorkFlow>d__21
TYPE:  sealed class
TOKEN: 0x20000E0
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginWorkFlow      <>4__this  // 0x20
  private           Beyond.Login.LoginWorkFlow.Worker<worker>5__2  // 0x28
  private           Beyond.Login.LoginViewProperty  <viewProp>5__3  // 0x30
  private           Beyond.Login.LoginWorkFlow.ENode<cachedCurrent>5__4  // 0x38
  private           System.Boolean                  <isEmptyFrame>5__5  // 0x3c
  private           System.Boolean                  <isAbort>5__6  // 0x3d
  private           Beyond.Login.LoginWorkFlow.Node[]<>7__wrap6  // 0x40
  private           System.Int32                    <>7__wrap7  // 0x48
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60004D2  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60004D3  System.Void System.IDisposable.Dispose()
  RVA=0x02C38E60  token=0x60004D4  System.Boolean MoveNext()
  RVA=0x057801C0  token=0x60004D6  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_FetchAgeTipsCoroutine>d__41
TYPE:  sealed class
TOKEN: 0x20000E1
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginAgeTipsProp   prop  // 0x20
  public            Beyond.Login.LoginWorkFlow      <>4__this  // 0x28
  private           Beyond.Login.LoginAgeTipsModel  <model>5__2  // 0x30
  private           Beyond.LoginController.MaskCtrl <maskCtrl>5__3  // 0x38
  private           Beyond.Misc.ObjectRef           <httpRetRef>5__4  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60004D8  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60004D9  System.Void System.IDisposable.Dispose()
  RVA=0x05781750  token=0x60004DA  System.Boolean MoveNext()
  RVA=0x05781A30  token=0x60004DC  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: <_AdjustCurrentGameState>d__43
TYPE:  sealed class
TOKEN: 0x20000E2
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginWorkFlow.ENodecurNode  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60004DE  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60004DF  System.Void System.IDisposable.Dispose()
  RVA=0x02C385C0  token=0x60004E0  System.Boolean MoveNext()
  RVA=0x05781704  token=0x60004E2  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: Options
TYPE:  sealed struct
TOKEN: 0x20000EA
SIZE:  0x18
FIELDS:
  public            System.Int64                    minBytesToNotifyCarrier  // 0x10
METHODS:
END_CLASS

CLASS: <>c__DisplayClass6_0
TYPE:  sealed class
TOKEN: 0x20000EB
SIZE:  0x30
FIELDS:
  public            System.Int64                    downloadSize  // 0x10
  public            Beyond.Login.NetUsagePolicy     <>4__this  // 0x18
  public            System.Action                   onAllowed  // 0x20
  public            System.Action                   onRejected  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000504  System.Void .ctor()
  RVA=0x05780640  token=0x6000505  System.Void <CheckIfAllowDownload>b__0()
  RVA=0x057806C0  token=0x6000506  System.Void <CheckIfAllowDownload>b__1()
END_CLASS

CLASS: EState
TYPE:  sealed struct
TOKEN: 0x20000ED
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginSceneAnimCtrl.EStateNONE  // const
  public    static  Beyond.Login.LoginSceneAnimCtrl.EStateA1  // const
  public    static  Beyond.Login.LoginSceneAnimCtrl.EStateA2  // const
METHODS:
END_CLASS

CLASS: FParams
TYPE:  sealed struct
TOKEN: 0x20000F3
SIZE:  0x20
FIELDS:
  public            System.String                   text  // 0x10
  public            System.Action                   onConfirm  // 0x18
METHODS:
END_CLASS

CLASS: Style
TYPE:  sealed struct
TOKEN: 0x20000F8
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginJudgeDialog.StyleCenter  // const
  public    static  Beyond.Login.LoginJudgeDialog.StyleLeft  // const
METHODS:
END_CLASS

CLASS: FParams
TYPE:  sealed struct
TOKEN: 0x20000F9
SIZE:  0x40
FIELDS:
  public            System.String                   text  // 0x10
  public            System.Action                   onPositive  // 0x18
  public            System.Action                   onNegative  // 0x20
  public            System.String                   btnPositive  // 0x28
  public            System.String                   btnNegative  // 0x30
  public            Beyond.Login.LoginJudgeDialog.Stylestyle  // 0x38
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000FB
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Login.LoginMenuPanel.<>c <>9  // static @ 0x0
  public    static  System.Action                   <>9__43_0  // static @ 0x8
METHODS:
  RVA=0x0578C0E4  token=0x600057C  System.Void .cctor()
  RVA=0x0350B670  token=0x600057D  System.Void .ctor()
  RVA=0x0578BCFC  token=0x600057E  System.Void <_OnQuitGameClicked>b__43_0()
END_CLASS

CLASS: FOptions
TYPE:  sealed struct
TOKEN: 0x20000FD
SIZE:  0x20
FIELDS:
  public            System.String                   fixedUID  // 0x10
  public            Beyond.LoginContext             context  // 0x18
METHODS:
  RVA=0x03159690  token=0x6000591  System.Boolean IsUIDFixed()
END_CLASS

CLASS: <HideAndDestroy>d__21
TYPE:  sealed class
TOKEN: 0x20000FE
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginMockUIDPanel  <>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x6000592  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000593  System.Void System.IDisposable.Dispose()
  RVA=0x02C3D330  token=0x6000594  System.Boolean MoveNext()
  RVA=0x0578BCB0  token=0x6000596  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ChildPanel
TYPE:  abstract class
TOKEN: 0x2000101
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.Login.ILoginContextReceiver
FIELDS:
  private           Beyond.UI.UISwitchTween         <switchTween>k__BackingField  // 0x18
  private           Beyond.LoginContext             <context>k__BackingField  // 0x20
PROPERTIES:
  switchTween  get=0x01041090  set=0x022C3A90
  context  get=0x03D4EB40  set=0x04271930
METHODS:
  RVA=0x02EA9480  token=0x60005A9  System.Void OnLoginContext(Beyond.LoginContext context)
  RVA=0x03610B70  token=0x60005AA  System.Void OnInit()
  RVA=0x02C3D440  token=0x60005AB  System.Void OnDestroy()
  RVA=0x05782DCC  token=0x60005AC  System.Void SetPanelVisibleByAnimSwitchTween(Beyond.UI.UIAnimationWrapper anim, System.Boolean isVisible, System.Boolean forceReset)
  RVA=0x02C3B860  token=0x60005AD  System.Void SetPanelVisibleByFadeSwitchTween(UnityEngine.CanvasGroup canvasGroup, System.Boolean isVisible, System.Boolean forceReset)
  RVA=0x0426FE60  token=0x60005AE  System.Void .ctor()
END_CLASS

CLASS: DelayInfo
TYPE:  sealed struct
TOKEN: 0x2000103
SIZE:  0x30
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            System.Int32                    colorCount  // 0x20
  public            System.Int32                    delayMax  // 0x24
  public            System.String                   text  // 0x28
METHODS:
END_CLASS

CLASS: <>c__DisplayClass10_0
TYPE:  sealed class
TOKEN: 0x2000108
SIZE:  0x30
FIELDS:
  public            Beyond.Login.LoginServerSelectPanel<>4__this  // 0x10
  public            System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData>serverZoneDataList  // 0x18
  public            System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo>serverList  // 0x20
  public            System.Action<Hypergryph.SpeedTest.SpeedTestResult>callback  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60005CA  System.Void .ctor()
  RVA=0x0578BD08  token=0x60005CB  System.Void <OnEnable>b__0(Hypergryph.SpeedTest.SpeedTestResult result)
  RVA=0x0578C07C  token=0x60005CC  System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> <OnEnable>b__1()
END_CLASS

CLASS: <_WaitingForShowListAwake>d__11
TYPE:  sealed class
TOKEN: 0x2000109
SIZE:  0x28
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            Beyond.Login.LoginServerSelectPanel<>4__this  // 0x20
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x60005CD  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60005CE  System.Void System.IDisposable.Dispose()
  RVA=0x0578C148  token=0x60005CF  System.Boolean MoveNext()
  RVA=0x0578C238  token=0x60005D1  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: FParams
TYPE:  sealed struct
TOKEN: 0x200010C
SIZE:  0x18
FIELDS:
  public            System.Action                   onConfirm  // 0x10
METHODS:
END_CLASS

CLASS: VocResInfo
TYPE:  class
TOKEN: 0x200010D
SIZE:  0x20
FIELDS:
  public            System.String                   nameTextId  // 0x10
  public            Beyond.VFS.EVFSBlockType        type  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60005E9  System.Void .ctor()
END_CLASS

CLASS: GameSettingSetterItem`1
TYPE:  class
TOKEN: 0x2000110
FIELDS:
  private   readonly System.String                   m_settingId  // 0x0
  private   readonly System.Action<T>                m_otherSystemSet  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600064E  System.Void .ctor(System.String settingId)
  RVA=-1  // not resolved  token=0x600064F  System.Void .ctor(System.String settingId, System.Action<T> otherSystemSet)
  RVA=-1  // not resolved  token=0x6000650  System.Void Set(T value, System.Boolean forceSetOtherSystem)
END_CLASS

CLASS: GameSettingSetterItem`2
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private   readonly System.String                   m_mainSettingId  // 0x0
  private   readonly System.String                   m_settingId1  // 0x0
  private   readonly System.String                   m_settingId2  // 0x0
  private   readonly System.Action<T1,T2>            m_otherSystemSet  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000651  System.Void .ctor(System.String mainSettingId, System.String settingId1, System.String settingId2, System.Action<T1,T2> otherSystemSet)
  RVA=-1  // not resolved  token=0x6000652  System.Void Set(T1 value1, T2 value2, System.Boolean forceSetOtherSystem)
END_CLASS

CLASS: __StaticArrayInitTypeSize=52
TYPE:  sealed struct
TOKEN: 0x2000114
SIZE:  0x44
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000113
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52DF6EA5B59F0E6C03F390AD5FEA0BBC199EC3524C0A682913148FD071AF1898EC  // static @ 0x0
METHODS:
END_CLASS

CLASS: Beyond.GameApp
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.ILuaCallCSharp
FIELDS:
  private           Beyond.GameStateMachine         m_stateMachine  // 0x18
  private   static  Beyond.GameApp                  <instance>k__BackingField  // static @ 0x0
  private           System.Boolean                  m_hasFocus  // 0x20
  private           System.Boolean                  m_needCallLuaFocus  // 0x21
  private           System.Boolean                  m_pauseStatus  // 0x22
  private           System.Boolean                  m_needCallLuaPause  // 0x23
PROPERTIES:
  instance  get=0x0576CF50  set=0x0576CF88
  currentState  get=0x028AC670
METHODS:
  RVA=0x02C35180  token=0x6000008  System.Void SwitchState(Beyond.GameState state)
  RVA=0x03157A50  token=0x6000009  System.Void Awake()
  RVA=0x0332FD80  token=0x600000A  System.Void _RegisterLuaAfterGCEvent()
  RVA=0x02632400  token=0x600000B  System.Void Update()
  RVA=0x02EC53C0  token=0x600000C  System.Void LateUpdate()
  RVA=0x0576C72C  token=0x600000D  System.Void OnApplicationQuit()
  RVA=0x029A6920  token=0x600000E  System.Void OnApplicationFocus(System.Boolean hasFocus)
  RVA=0x02B54CB0  token=0x600000F  System.Void _OnApplicationFocusForLua()
  RVA=0x03134CA0  token=0x6000010  System.Void OnApplicationPause(System.Boolean pauseStatus)
  RVA=0x03134F90  token=0x6000011  System.Void _OnApplicationPauseForLua()
  RVA=0x0576C954  token=0x6000012  System.Void OnDestroy()
  RVA=0x02954CA0  token=0x6000013  System.Void _PreInitGameSetting()
  RVA=0x03156EB0  token=0x6000014  System.Void _Init()
  RVA=0x0576CEC0  token=0x6000015  System.Void _UnInit()
  RVA=0x031573F0  token=0x6000016  System.Void _InitGameStateMachine()
  RVA=0x0576CE38  token=0x6000017  System.Void _UnInitGameStateMachine()
  RVA=0x0576CB5C  token=0x6000018  System.Void QuitGame(System.Int32 exitCode)
  RVA=0x0576CC18  token=0x6000019  System.Void RefreshScreenResolution()
  RVA=0x0576CD18  token=0x600001A  System.Void _OnSystemDisplaySizeChanged()
  RVA=0x0576CD58  token=0x600001B  System.Void _OnSystemScreenSizeChanged(Beyond.EventData<System.Boolean,System.Boolean>& data)
  RVA=0x031570D0  token=0x600001C  System.Collections.IEnumerator _InitSecuritySDK()
  RVA=0x02C3E8C0  token=0x600001D  System.Void _OnApplicationPauseForSecurity(System.Boolean pauseStatus)
  RVA=0x03D006E0  token=0x600001E  System.Collections.IEnumerator _FetchRemoteConfigUtilSuc()
  RVA=0x03A1E660  token=0x600001F  System.Void .ctor()
END_CLASS

CLASS: Beyond.IMemoryPackProxy
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600002C  System.Void Init()
END_CLASS

CLASS: Beyond.MemoryPackProxyModule
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
  private   static  Beyond.IMemoryPackProxy         s_memoryPackProxy  // static @ 0x0
METHODS:
  RVA=0x0576EBA0  token=0x600002D  System.Void RegisterProxy(Beyond.IMemoryPackProxy memoryPackProxy)
  RVA=0x0576EB68  token=0x600002E  Beyond.IMemoryPackProxy GetMemoryPackProxy()
  RVA=0x0350B670  token=0x600002F  System.Void .ctor()
END_CLASS

CLASS: Beyond.GameInitState
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x18
EXTENDS: Beyond.GameStateBase
FIELDS:
PROPERTIES:
  stateId  get=0x01002730
METHODS:
  RVA=0x0426FEE0  token=0x6000031  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x03157630  token=0x6000032  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x02EAA390  token=0x6000033  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x03157720  token=0x6000034  System.Collections.IEnumerator _DoInit()
  RVA=0x0315ACC0  token=0x6000035  System.Void _InitInitialResourceManager(Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator)
  RVA=0x02955380  token=0x6000036  System.Boolean _CheckIfLocalInitialAssetsValid(Beyond.Resource.HotUpdate.LocalResPref& outputLocalResPref, Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator)
  RVA=0x0307F820  token=0x6000037  System.Void _InitAPPDefaultCulture()
  RVA=0x02AB7540  token=0x6000038  System.Void _InitGameSetting()
  RVA=0x0576CFD8  token=0x6000039  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  RVA=0x0576CFE0  token=0x600003A  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameLoginState
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x18
EXTENDS: Beyond.GameStateBase
FIELDS:
PROPERTIES:
  stateId  get=0x03D55730
METHODS:
  RVA=0x0426FEE0  token=0x6000042  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x03157790  token=0x6000043  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x03102F10  token=0x6000044  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x02C3E7E0  token=0x6000045  System.Void _TryStartLoginWorkflow()
  RVA=0x0576CFD8  token=0x6000046  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  RVA=0x0576CFE0  token=0x6000047  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameMainState
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x20
EXTENDS: Beyond.GameStateBase
FIELDS:
  private           System.Boolean                  m_isFirstEnter  // 0x18
PROPERTIES:
  stateId  get=0x03D55740
METHODS:
  RVA=0x042759A8  token=0x6000049  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x02EA8690  token=0x600004A  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x03D22EE0  token=0x600004B  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x03102F90  token=0x600004C  System.Void ReleaseMainGame(Beyond.GameState toStateId)
  RVA=0x042753D4  token=0x600004D  System.Void _ClearUtils()
  RVA=0x0576CFD8  token=0x600004E  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  RVA=0x0576CFE0  token=0x600004F  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GamePreloadState
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x20
EXTENDS: Beyond.GameStateBase
FIELDS:
  private           Beyond.Cfg.Tables.AsyncLoadTask m_asyncTask  // 0x18
PROPERTIES:
  stateId  get=0x03D55750
METHODS:
  RVA=0x0426FEE0  token=0x6000051  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x03B41720  token=0x6000052  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x03CF3610  token=0x6000053  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x03B417C0  token=0x6000054  System.Collections.IEnumerator _DoPreload()
  RVA=0x02AB7DC0  token=0x6000055  System.Void _InitGameSettingStateInPreload()
  RVA=0x0576CFD8  token=0x6000056  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  RVA=0x0576CFE0  token=0x6000057  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameQuitState
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x18
EXTENDS: Beyond.GameStateBase
FIELDS:
PROPERTIES:
  stateId  get=0x03D55760
METHODS:
  RVA=0x0426FEE0  token=0x600005F  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x0576D424  token=0x6000060  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x0576D48C  token=0x6000061  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x0576CFE8  token=0x6000062  System.Void DoQuit()
  RVA=0x0576CFD8  token=0x6000063  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  RVA=0x0576CFE0  token=0x6000064  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameSoftRestartState
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x18
EXTENDS: Beyond.GameStateBase
FIELDS:
  private   static  System.String                   CLEAR_SCENE_PATH  // const
PROPERTIES:
  stateId  get=0x03D51100
METHODS:
  RVA=0x0426FEE0  token=0x6000066  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x0576D4F0  token=0x6000067  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x0576D5A8  token=0x6000068  System.Collections.IEnumerator _SoftRestart()
  RVA=0x0576CFD8  token=0x6000069  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameStartState
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x18
EXTENDS: Beyond.GameStateBase
FIELDS:
PROPERTIES:
  stateId  get=0x03D55770
METHODS:
  RVA=0x0426FEE0  token=0x6000071  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x03B0DAE0  token=0x6000072  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x03B6EA40  token=0x6000073  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x03B46620  token=0x6000074  System.Void _OnEnterMainGame()
  RVA=0x02C35D20  token=0x6000075  System.Void <_OnEnterMainGame>b__5_0()
  RVA=0x0576CFD8  token=0x6000076  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  RVA=0x0576CFE0  token=0x6000077  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameStateBase
TYPE:  abstract class
TOKEN: 0x2000013
SIZE:  0x18
IMPLEMENTS: Beyond.Gameplay.ISimpleStateNode`1 Beyond.ILuaCallCSharp
FIELDS:
  protected readonly Beyond.GameStateMachine         m_stateMachine  // 0x10
PROPERTIES:
  stateId  get=-1  // abstract
METHODS:
  RVA=0x0426FEE0  token=0x6000078  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  RVA=0x02C384A0  token=0x600007A  System.Void OnEnter(Beyond.GameState fromStateId)
  RVA=0x02C38530  token=0x600007B  System.Void OnLeave(Beyond.GameState toStateId)
  RVA=0x0576D638  token=0x600007C  System.Void OnTick(System.Single deltaTime)
END_CLASS

CLASS: Beyond.GameStateMachine
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x38
EXTENDS: Beyond.Gameplay.SimpleEnumStateMachine`1
IMPLEMENTS: Beyond.IGameStateMachine Beyond.ILuaCallCSharp
FIELDS:
  private   readonly Beyond.GameApp                  <app>k__BackingField  // 0x30
PROPERTIES:
  app  get=0x01003830
  curState  get=0x02DEEA70
METHODS:
  RVA=0x03157490  token=0x600007F  System.Void .ctor(Beyond.GameApp gameApp)
  RVA=0x03156C80  token=0x6000080  System.Void _RegisterStates()
  RVA=0x02C35000  token=0x6000081  System.Boolean CheckCanReturnToLoginState()
  RVA=0x03C94800  token=0x6000082  System.Collections.IEnumerator ReturnToLoginState()
END_CLASS

CLASS: Beyond.GlobalInitializer
TYPE:  static class
TOKEN: 0x2000016
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D4C3A0  token=0x6000089  System.Void InitGlobalConfig()
END_CLASS

CLASS: Beyond.IHotFixCommon
TYPE:  interface
TOKEN: 0x2000017
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.IHotFixPatchManagerProxy
TYPE:  interface
TOKEN: 0x2000018
IMPLEMENTS: Beyond.IHotFixCommon
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600008A  System.Void InitManager()
  RVA=-1  // abstract  token=0x600008B  System.Void ReleaseManager()
  RVA=-1  // abstract  token=0x600008C  System.Void PatchInitAssemble()
  RVA=-1  // abstract  token=0x600008D  System.Void PatchRemoteInitAssemble()
  RVA=-1  // abstract  token=0x600008E  System.Void PatchRemoteInjectedLua()
  RVA=-1  // abstract  token=0x600008F  System.Void PatchMainAssemble()
  RVA=-1  // abstract  token=0x6000090  System.Void PatchRemoteMainAssemble()
END_CLASS

CLASS: Beyond.HotFixPatchModules
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,Beyond.IHotFixCommon>s_hotFixModules  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x6000091  System.Void Register(T module)
  RVA=-1  // generic def  token=0x6000092  System.Void UnRegister()
  RVA=-1  // generic def  token=0x6000093  T GetModule()
  RVA=0x0350B670  token=0x6000094  System.Void .ctor()
  RVA=0x03CE4090  token=0x6000095  System.Void .cctor()
END_CLASS

CLASS: Beyond.InitialPathDef
TYPE:  static class
TOKEN: 0x200001A
SIZE:  0x10
FIELDS:
  public    static  System.String                   LOGIN_SCENE_PATH  // const
  public    static  System.String                   LOGIN_SK_ACTOR_M  // const
  public    static  System.String                   LOGIN_SK_ACTOR_F  // const
  public    static  System.String                   LOGIN_SK_ACTOR_NO_GENDER  // const
  public    static  System.String                   LOGIN_MOCK_UID_PANEL  // const
  public    static  System.String                   LOGIN_CONTROLLER_PATH  // const
  public    static  System.String                   LOGIN_ROOT_PANEL_PATH  // const
  public    static  System.String                   LOGIN_ALERT_DIALOG_PATH  // const
  public    static  System.String                   LOGIN_JUDGE_DIALOG_PATH  // const
  public    static  System.String                   LOGIN_VOC_RES_SELECT_DIALOG_PATH  // const
METHODS:
END_CLASS

CLASS: Beyond.LoginController
TYPE:  class
TOKEN: 0x200001B
SIZE:  0xC0
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private           UnityEngine.Transform           _uiFunc  // 0x18
  private           UnityEngine.Transform           _uiDialog  // 0x20
  private           Beyond.UI.UIButton              _versionBtn  // 0x28
  private           Beyond.Login.LoginDecorateUI    _uiDecorate  // 0x30
  private           Beyond.LoginController.MaskCfg  _maskBlur  // 0x38
  private           Beyond.LoginController.MaskCfg  _maskBlack  // 0x40
  private           Beyond.LoginController.MaskCfg  _maskWhite  // 0x48
  private           System.Single                   _enterGamePanelPredelay  // 0x50
  private           UnityEngine.Canvas              _uiRootCanvas  // 0x58
  private           Beyond.UI.UICanvasScaleHelper   _uiRootCanvasScaleHelper  // 0x60
  private           UnityEngine.Canvas              _uiDecoCanvas  // 0x68
  private           Beyond.UI.UICanvasScaleHelper   _uiDecoCanvasScaleHelper  // 0x70
  private           System.Boolean                  m_isInited  // 0x78
  private           Beyond.LoginController.FOptions m_options  // 0x80
  private           Beyond.LatchUtils.InvokeWhenUnlockm_startLatch  // 0x88
  private           Beyond.LatchUtils.InvokeWhenUnlockm_initLatch  // 0x90
  private           Beyond.Login.LoginWorkFlow.ENodem_lastNode  // 0x98
  private           Beyond.LoginController.MaskCtrl m_maskCtrl  // 0xa0
  private           Beyond.Login.LoginRootPanel     m_rootPanel  // 0xa8
  private           System.Collections.IEnumerator  m_mockLoginRoutine  // 0xb0
  private           System.Action<System.String>    m_onMockLogin  // 0xb8
PROPERTIES:
  maskCtrl  get=0x02EA9AB0
  rootPanel  get=0x03D4EB10
EVENTS:
  m_onMockLogin  add=add_m_onMockLogin  remove=remove_m_onMockLogin
METHODS:
  RVA=0x03CF9140  token=0x6000098  System.Void Awake()
  RVA=0x03D2A520  token=0x6000099  System.Void Start()
  RVA=0x02EA9B50  token=0x600009A  System.Single GetEnterGamePanelPredelay()
  RVA=0x02C3B440  token=0x600009B  System.Void OnValueChanged(Beyond.Login.LoginViewModel viewModel)
  RVA=0x02EA8DE0  token=0x600009C  System.Void InitUI(Beyond.LoginController.FOptions options)
  RVA=0x028D52F0  token=0x600009D  System.Void InvokeWhenStart(System.Action callback)
  RVA=0x03A24780  token=0x600009E  System.Collections.IEnumerator BeforeDestroy()
  RVA=-1  // generic def  token=0x600009F  System.Collections.IEnumerator _InstantiateUIFromRes(System.String resPath, UnityEngine.Transform parent, Beyond.Misc.ObjectRef objRef)
  RVA=0x03C86380  token=0x60000A0  System.Void _InitImpl()
  RVA=0x03C863D0  token=0x60000A1  System.Collections.IEnumerator _InitCoroutine()
  RVA=0x02EA9E00  token=0x60000A2  System.Void _InitVersionBtn()
  RVA=0x02EAA8A0  token=0x60000A5  System.Void MockLoginWithCallback(System.String fixedUID, System.Action<System.String> callback)
  RVA=0x02EAA9A0  token=0x60000A6  System.Collections.IEnumerator _MockLoginCoroutine(System.String fixedUID)
  RVA=0x039BB5F0  token=0x60000A7  System.Void .ctor()
  RVA=0x03D4D200  token=0x60000A8  System.Void <MockLoginWithCallback>b__44_0()
END_CLASS

CLASS: Beyond.LoginContext
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x58
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Beyond.LoginController          m_controller  // 0x10
  private           System.Boolean                  m_isDisposed  // 0x18
  private           System.Boolean                  <quickStart>k__BackingField  // 0x19
  private           System.Boolean                  <firstLogin>k__BackingField  // 0x1a
  private           Beyond.Login.LoginWorkFlow      <workflow>k__BackingField  // 0x20
  private           Beyond.Login.LoginViewProperty  <viewProp>k__BackingField  // 0x28
  private           Beyond.LoginManager.AssetLoader <loader>k__BackingField  // 0x30
  private           Beyond.LoginManager.FlowWithMaskMgr<flowWithMask>k__BackingField  // 0x38
  private           Beyond.Login.NetUsagePolicy     <netUsagePolicy>k__BackingField  // 0x40
  private           Beyond.Login.LoginGameUpdater   <gameUpdater>k__BackingField  // 0x48
  private           System.Boolean                  <startConnectServer>k__BackingField  // 0x50
PROPERTIES:
  quickStart  get=0x03D4EF80  set=0x03D4EFB0
  firstLogin  get=0x03D4EFA0  set=0x03D4EFD0
  workflow  get=0x03D4EB40  set=0x04271930
  viewProp  get=0x03D4EAC0  set=0x02C92F10
  loader  get=0x01003830  set=0x04270470
  flowWithMask  get=0x03D4E2A0  set=0x0388FF30
  netUsagePolicy  get=0x03D4E2B0  set=0x03CB2D80
  gameUpdater  get=0x03D4EA70  set=0x02692290
  startConnectServer  get=0x03D4F000  set=0x03D4F030
METHODS:
  RVA=0x02EA9A10  token=0x60000FC  Beyond.LoginController ViewOnlyController()
  RVA=0x028D4BE0  token=0x60000FD  System.Void Init(System.Boolean quickStart, Beyond.LoginController controller, Beyond.Login.LoginWorkFlow workflow, Beyond.Login.LoginViewProperty viewProp, Beyond.LoginManager.AssetLoader loader, Beyond.LoginManager.FlowWithMaskMgr flowWithMask, Beyond.Login.NetUsagePolicy netUsagePolicy, Beyond.Login.LoginGameUpdater gameUpdater)
  RVA=0x02D77950  token=0x60000FE  System.Void StartCoroutine(System.Collections.IEnumerator routine)
  RVA=0x0576D880  token=0x60000FF  System.Void StopCoroutine(System.Collections.IEnumerator routine)
  RVA=0x0576D72C  token=0x6000100  System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param)
  RVA=0x02EAAB50  token=0x6000101  System.Void Dispose()
  RVA=0x0576D7AC  token=0x6000102  System.Void ShutDown()
  RVA=0x0576D6D8  token=0x6000103  System.Boolean IsWorkflowDisposed()
  RVA=0x0576D68C  token=0x6000104  System.Boolean IsDisposed()
  RVA=0x028D4CC0  token=0x6000105  System.Void _DisposeImpl()
  RVA=0x02EAAC70  token=0x6000106  System.Collections.IEnumerator _DisposeCoroutine(Beyond.LoginController legacyController, System.Action disposeAction)
  RVA=0x0350B670  token=0x6000107  System.Void .ctor()
END_CLASS

CLASS: Beyond.ELoginEvent
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.ELoginEvent              None  // const
  public    static  Beyond.ELoginEvent              V2C_U8Login  // const
  public    static  Beyond.ELoginEvent              V2C_EnterGame  // const
  public    static  Beyond.ELoginEvent              V2C_Logout  // const
  public    static  Beyond.ELoginEvent              V2C_ResourceRepair  // const
  public    static  Beyond.ELoginEvent              V2C_OpenAgeTips  // const
  public    static  Beyond.ELoginEvent              V2C_CloseAgeTips  // const
  public    static  Beyond.ELoginEvent              V2C_OpenServerSelect  // const
  public    static  Beyond.ELoginEvent              V2C_CloseServerSelect  // const
  public    static  Beyond.ELoginEvent              V2C_SelectServer  // const
  public    static  Beyond.ELoginEvent              V2C_ConfirmServer  // const
  public    static  Beyond.ELoginEvent              V2C_Relogin  // const
  public    static  Beyond.ELoginEvent              V2C_ReplayGsLogin  // const
  public    static  Beyond.ELoginEvent              C2V_PrepareGsLogin  // const
METHODS:
END_CLASS

CLASS: Beyond.LoginTextDefines
TYPE:  static class
TOKEN: 0x200002E
SIZE:  0x10
FIELDS:
  public    static  System.String                   CS_LOGIN_CONN_FAIL  // const
  public    static  System.String                   HOTUPDATE_INDEX_FAILED  // const
  public    static  System.String                   HOTUPDATE_IO_FAILED  // const
  public    static  System.String                   HOTUPDATE_CHECK_VERSION  // const
  public    static  System.String                   HOTUPDATE_DOWNLOADING  // const
  public    static  System.String                   HOTUPDATE_DECOMPRESSING  // const
  public    static  System.String                   HOTUPDATE_DOWNLOAD_ERROR  // const
  public    static  System.String                   HOTUPDATE_DOWNLOAD_DISKFULL  // const
  public    static  System.String                   HOTUPDATE_LOCAL_RES_CHECK  // const
  public    static  System.String                   HOTUPDATE_PRELOAD_RES  // const
  public    static  System.String                   HOTUPDATE_INVALID_LOCAL_FILES  // const
  public    static  System.String                   HOTUPDATE_INIT_RES_CHANGED  // const
  public    static  System.String                   HOTUPDATE_DOWNLOAD_IO_ERROR  // const
  public    static  System.String                   HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR  // const
  public    static  System.String                   HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR  // const
  public    static  System.String                   HOTUPDATE_DECOMPRESS_ERROR  // const
  public    static  System.String                   REMOTE_CFG_GAME_CFG_ERROR  // const
  public    static  System.String                   REMOTE_CFG_GAME_CFG_TIMEOUT  // const
  public    static  System.String                   REMOTE_CFG_NETWORK_CFG_ERROR  // const
  public    static  System.String                   REMOTE_CFG_NETWORK_CFG_TIMEOUT  // const
  public    static  System.String                   REMOTE_CFG_RES_VERSION_ERROR  // const
  public    static  System.String                   REMOTE_CFG_RES_VERSION_TIMEOUT  // const
  public    static  System.String                   REMOTE_CFG_GAME_VERSION_ERROR  // const
  public    static  System.String                   REMOTE_CFG_GAME_VERSION_TIMEOUT  // const
  public    static  System.String                   LOGIN_JUDGE_EXIT_GAME  // const
  public    static  System.String                   LOGIN_JUDGE_LOGOUT  // const
  public    static  System.String                   LOGIN_JUDGE_RES_REPAIR  // const
  public    static  System.String                   LOGIN_AGE_TIPS_FAILED  // const
  public    static  System.String                   LOGIN_TXT_DIALOG_CONFIRM  // const
  public    static  System.String                   LOGIN_TXT_DIALOG_CANCEL  // const
  public    static  System.String                   LOGIN_AUDIO_LANG_CN  // const
  public    static  System.String                   LOGIN_AUDIO_LANG_JP  // const
  public    static  System.String                   LOGIN_AUDIO_LANG_EN  // const
  public    static  System.String                   LOGIN_AUDIO_LANG_KR  // const
  public    static  System.String                   LOGIN_TXT_NETWORK_ERROR  // const
  public    static  System.String                   LOGIN_GAME_UPGRADED  // const
  public    static  System.String                   LOGIN_TXT_SERVER_CLOSED  // const
  public    static  System.String                   LOGIN_TXT_SERVER_CLOSED_DATETIME  // const
  public    static  System.String                   LOGIN_TXT_USR_BAN_DATETIME  // const
  public    static  System.String                   LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER  // const
  public    static  System.String                   LOGIN_GET_SERVER_LIST_FAILED  // const
  public    static  System.String                   LOGIN_TEXT_SERVER_ZONE_FAILED  // const
  public    static  System.String                   LOGIN_TEXT_GET_APP_VERSION_FAILED  // const
  public    static  System.String                   LOGIN_TEXT_ALERT_CARRIER_NETWORK  // const
  public    static  System.String                   LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED  // const
  public    static  System.String                   LOGIN_SHADER_WARM_UP_PRELOAD_RES  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_TIPS_DOWNLOADING  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_TIPS_PAUSE  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_ALERT_NEWER  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_ERROR_DISK_FULL  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_ALERT_SUC  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_ERROR_COMMON  // const
  public    static  System.String                   LOGIN_GAME_UPDATE_TITLE  // const
  public    static  System.String                   LOGIN_GOTO_SHOP_FOR_GAME_UPDATE  // const
  public    static  System.String                   LOGIN_SDK_INIT_FAILED  // const
  public    static  System.String                   LOGIN_DOWNLOADING_SPEED_HINT  // const
  public    static  System.String                   LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME  // const
  public    static  System.String                   LOGIN_NETWORK_CONGESTION_TITLE  // const
  public    static  System.String                   LOGIN_LOW_SCORE_DEVICE_TIP  // const
  public    static  System.String                   LOGIN_REGISTRY_WRITE_FAILED  // const
METHODS:
END_CLASS

CLASS: Beyond.LoginManager
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x50
EXTENDS: Beyond.ExplicitSingleton`1
FIELDS:
  public    static  System.Int64                    MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI  // const
  private           Beyond.Resource.ISceneHandle    m_sceneHandle  // 0x10
  private           Beyond.LoginContext             m_context  // 0x18
  private           Beyond.LatchUtils.InvokeWhenUnlockm_workflowFinishLatch  // 0x20
  private           Beyond.LatchUtils.InvokeWhenUnlockm_workflowStartLatch  // 0x28
  private           System.Collections.Generic.Queue<System.WeakReference<Beyond.Login.LoginSceneComponent>>m_pendingSceneComps  // 0x30
  private           System.Collections.Generic.HashSet<Beyond.Login.LoginSceneComponent>m_sceneComps  // 0x38
  private           System.Boolean                  <quickStart>k__BackingField  // 0x40
  private           System.Object                   m_dialogBlocker  // 0x48
PROPERTIES:
  quickStart  get=0x03D4EE90  set=0x03D4EEB0
  firstLogin  get=0x0576E81C
METHODS:
  RVA=0x03CC4260  token=0x6000111  System.Collections.IEnumerator InitCoroutine(System.Boolean quickStart)
  RVA=0x0576DF5C  token=0x6000112  System.Boolean IsReLoginInProgress()
  RVA=0x04275714  token=0x6000113  System.Void OnReleaseMainGame()
  RVA=0x03D42930  token=0x6000114  System.Boolean IsWorkflowInProgress()
  RVA=0x0576DC74  token=0x6000115  System.Void ClearSync()
  RVA=0x02EA8790  token=0x6000116  System.Void Clear()
  RVA=0x02EA8340  token=0x6000117  System.Void _ReleaseLoginScene()
  RVA=0x03B466E0  token=0x6000118  System.Void InvokeWhenWorkFlowFinished(System.Action callback)
  RVA=0x02C3CFE0  token=0x6000119  System.Void SceneComponentOnly_Bind(Beyond.Login.LoginSceneComponent comp)
  RVA=0x02EA9860  token=0x600011A  System.Void _BindPendingComponents()
  RVA=0x0576E360  token=0x600011B  System.Void ToggleLoginBindingGroup(System.Boolean enable)
  RVA=0x0576DA8C  token=0x600011C  System.Void AlertDialog(System.String desc, System.Action callback)
  RVA=0x0576E4B4  token=0x600011D  System.Void VocResSelDialog(System.Action callback)
  RVA=0x0576E424  token=0x600011E  System.Collections.IEnumerator VocResSelDialogWithConfirm()
  RVA=0x0576D9A4  token=0x600011F  System.Collections.IEnumerator AlertDialogWithResult(System.String desc, Beyond.Misc.ObjectRef outRef, System.Action<Beyond.Misc.ObjectRef> callback)
  RVA=0x0576D8FC  token=0x6000120  System.Collections.IEnumerator AlertDialogWithConfirm(System.String desc)
  RVA=0x0576E110  token=0x6000121  System.Void JudgeDialog(System.String desc, System.Action onPositive, System.Action onNegative)
  RVA=0x0576E074  token=0x6000122  System.Void JudgeDialog(Beyond.Login.LoginJudgeDialog.FParams param)
  RVA=0x0576E654  token=0x6000123  System.Void _StartShowJudgeDialogCoroutine(Beyond.Login.LoginJudgeDialog.FParams param)
  RVA=-1  // generic def  token=0x6000124  System.Collections.IEnumerator _ShowDialogCoroutine(System.String resPath, TParam param, System.Action<TDialog,TParam> setParamFunc)
  RVA=0x02EA9500  token=0x6000125  System.Void MockLoginWithCallback(System.Action<System.String> callback)
  RVA=0x0576E200  token=0x6000126  System.Void MockManualSelectServer(System.String uid, System.Action callback)
  RVA=0x028D5370  token=0x6000127  System.Void _Init()
  RVA=0x02C3CED0  token=0x6000128  System.Boolean IsLoginSceneLoading()
  RVA=0x028D4E50  token=0x6000129  System.Void _PrepareBeforeLoginProcess()
  RVA=0x03C7DAA0  token=0x600012A  System.Collections.IEnumerator _LoginWorkFlowCoroutine(Beyond.LoginController nullableCtrl)
  RVA=0x02EA8D10  token=0x600012B  System.Void _ClearWorkflowAndContext(System.Boolean isShutDownMode)
  RVA=0x0315A7B0  token=0x600012C  System.Collections.IEnumerator FetchRemoteConfigUtilSuc(Beyond.Cfg.IRemoteConfig config, System.String configEnv, System.String keyErrorWithCode, System.String keyTimeout)
  RVA=0x02C36F20  token=0x600012D  System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout)
  RVA=0x0576DCD4  token=0x600012E  System.Void DevOnlyCheckEnableLocalResMode(System.Boolean& enable)
  RVA=0x0576DD54  token=0x600012F  System.Void DevOnlyUseLocalResVersion(Beyond.Cfg.ResVersionDevCfg config, System.Boolean& useLocalResVersion)
  RVA=0x03A93590  token=0x6000130  System.Void .ctor()
END_CLASS

CLASS: Beyond.VietnamLoginAgePanel
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.String                   PREFAB_PATH  // const
  private   static  Beyond.Resource.FAssetProxyHandles_prefabAssetHandle  // static @ 0x0
  public    static  UnityEngine.GameObject          instance  // static @ 0x18
METHODS:
  RVA=0x02EA8AA0  token=0x6000180  System.Void Init()
  RVA=0x057718A8  token=0x6000181  System.Void UnInit()
  RVA=0x05771920  token=0x6000182  System.Void _Init()
  RVA=0x05771BA8  token=0x6000183  System.Void _UnInit()
  RVA=0x057717BC  token=0x6000184  System.Void OnApplicationQuit()
  RVA=0x0426FE60  token=0x6000185  System.Void .ctor()
END_CLASS

CLASS: Beyond.VietnamLoginAgeTipsPanelCtrl
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIDrag                _UIDrag  // 0x18
  private           Beyond.UI.UIButton              _tipsBtn  // 0x20
  private           Beyond.UI.UIButton              _circleBtn  // 0x28
  private           Beyond.UI.UIState.UIStateController_stateController  // 0x30
METHODS:
  RVA=0x05771C7C  token=0x6000186  System.Void Awake()
  RVA=0x05771F54  token=0x6000187  System.Void _SetStateTips(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x05771EB8  token=0x6000188  System.Void _SetStateCircle(UnityEngine.EventSystems.PointerEventData eventData)
  RVA=0x0426FE60  token=0x6000189  System.Void .ctor()
END_CLASS

CLASS: Beyond.RenderPipelineDataLoader
TYPE:  static class
TOKEN: 0x2000044
SIZE:  0x10
FIELDS:
  public    static  Beyond.Resource.FAssetProxyHandles_globalSettings  // static @ 0x0
  public    static  Beyond.Resource.FAssetProxyHandles_pipelineAsset  // static @ 0x14
METHODS:
  RVA=0x02EAA430  token=0x600018A  System.Void LoadSimpleRpData()
  RVA=0x031578A0  token=0x600018B  System.Void PreloadFullRpResources()
  RVA=0x02C38320  token=0x600018C  System.Boolean IsPreLoadFinished()
  RVA=0x02EAA600  token=0x600018D  System.Void LoadFullRpResources()
END_CLASS

CLASS: Beyond.TailGameLoop
TYPE:  class
TOKEN: 0x2000045
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x02F88BB0  token=0x600018E  System.Void Update()
  RVA=0x02E69680  token=0x600018F  System.Void LateUpdate()
  RVA=0x0426FE60  token=0x6000190  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginCheckForUpdateNode
TYPE:  class
TOKEN: 0x2000068
SIZE:  0x30
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginGameUpdater   m_sdk  // 0x20
  private           System.Boolean                  m_checkSuccess  // 0x28
  private   static  System.String                   REQUEST_API  // const
  private   static  System.String                   REQUEST_PARAM_FORMAT  // const
  private   static  System.String                   REQUEST_URL_FORMAT  // const
  private   static  System.String                   PRAM_SOURCE  // const
PROPERTIES:
  type  get=0x01168950
METHODS:
  RVA=0x036BC910  token=0x6000213  UnityEngine.CustomYieldInstruction Work()
  RVA=0x036BCA10  token=0x6000214  System.Collections.IEnumerator _CheckForUpdateCoroutine()
  RVA=0x03D02BC0  token=0x6000215  System.Collections.IEnumerator AlertNoMatchDeviceBeforeLogin()
  RVA=0x05773218  token=0x6000216  System.Collections.IEnumerator _CheckForUpdateCoroutineMobile()
  RVA=0x03CEFE20  token=0x6000217  System.Collections.IEnumerator _CheckForUpdateCoroutinePC()
  RVA=0x03B29910  token=0x6000218  System.Collections.IEnumerator _CheckForUpdatePC()
  RVA=0x03922450  token=0x6000219  System.Collections.IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef)
  RVA=0x0229CC40  token=0x600021A  System.String _GetRequestPram()
  RVA=0x0350B670  token=0x600021B  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginCreateRoleNode
TYPE:  class
TOKEN: 0x2000070
SIZE:  0x28
EXTENDS: Node
FIELDS:
  public    static  System.String                   LUA_SYS_NAME  // const
  private           Beyond.Login.LoginCreateRoleNode.WorkProcessm_activeProcess  // 0x20
PROPERTIES:
  type  get=0x03D557A0
METHODS:
  RVA=0x0379F750  token=0x6000242  System.Void OnDispose()
  RVA=0x057732A8  token=0x6000243  System.Boolean CanCancel()
  RVA=0x03C9BCF0  token=0x6000244  UnityEngine.CustomYieldInstruction Work()
  RVA=0x0350B670  token=0x6000245  System.Void .ctor()
  RVA=0x057732FC  token=0x6000246  System.Void <>iFixBaseProxy_OnDispose()
  RVA=0x057732F4  token=0x6000247  System.Boolean <>iFixBaseProxy_CanCancel()
END_CLASS

CLASS: Beyond.Login.LoginDownloadTask
TYPE:  class
TOKEN: 0x2000072
SIZE:  0x90
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.Boolean                  m_isDownloadFinished  // 0x10
  private           Beyond.SDK.HGDownloader.TaskHandlerm_downloadTask  // 0x18
  private           Beyond.Resource.HotUpdate.FResourceDiffm_resDiff  // 0x20
  private           Beyond.Resource.HotUpdate.LocalResPrefm_localResPref  // 0x60
  private           System.String                   m_patchInfo  // 0x68
  private           System.Collections.IEnumerator  m_mockCoroutine  // 0x70
  private           System.Boolean                  m_isInitial  // 0x78
  private           System.String                   <vitalError>k__BackingField  // 0x80
  private           Beyond.Login.NetUsagePolicy     m_netUsagePolicy  // 0x88
PROPERTIES:
  vitalError  get=0x03D4EAE0  set=0x051DFC94
METHODS:
  RVA=0x010393E0  token=0x600024B  System.Void .ctor(Beyond.Resource.HotUpdate.FResourceDiff resDiff, Beyond.Resource.HotUpdate.LocalResPref localResPref, System.String patchInfo, System.Boolean isInitial, Beyond.Login.NetUsagePolicy netUsagePolicy)
  RVA=0x057733F4  token=0x600024E  Beyond.SDK.HGDownloader.DownloadProgress GetDownloadProgress()
  RVA=0x05773390  token=0x600024F  System.Single GetDecompressProgress()
  RVA=0x0577348C  token=0x6000250  Beyond.SDK.HGDownloader.WorkState GetWorkState()
  RVA=0x057734EC  token=0x6000251  System.Boolean Tick()
  RVA=0x05773304  token=0x6000252  System.Void Dispose()
  RVA=0x057740DC  token=0x6000253  System.Void _StartDownload()
  RVA=0x05773C68  token=0x6000254  System.Void _StartDownloadImpl()
  RVA=0x01037210  token=0x6000255  System.Collections.Generic.List<Beyond.SDK.HGFolder> _GetAllFileList(Beyond.Resource.HotUpdate.LocalResPref localResPref)
  RVA=0x05773558  token=0x6000256  System.Collections.Generic.List<Beyond.SDK.HGFileInfo> _GetFileList(System.String rootUrl)
  RVA=0x057739B4  token=0x6000257  System.Void _OnDownloadFinish()
  RVA=0x05773798  token=0x6000258  System.Boolean _OnDownloadError(Beyond.SDK.HGRetCodeType codeType, System.Int32 errorCode)
  RVA=0x05773A04  token=0x6000259  System.Void _OnDownloadPaused(Beyond.SDK.HGDownloader.PauseReason reason)
END_CLASS

CLASS: Beyond.Login.LoginGameSettingInitializer
TYPE:  class
TOKEN: 0x2000075
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.Boolean                  s_isInitialized  // static @ 0x0
  private           UnityEngine.RectTransform       m_rectTransform  // 0x18
  private           Beyond.UI.UICanvasScaleHelper   m_canvasScaleHelper  // 0x20
METHODS:
  RVA=0x0398C690  token=0x600025F  System.Void Awake()
  RVA=0x0398C6F0  token=0x6000260  System.Void OnEnable()
  RVA=0x0398C7F0  token=0x6000261  System.Void _TryInitializeComponents()
  RVA=0x0398C770  token=0x6000262  System.Void _InitGameSettingStateInLogin()
  RVA=0x02E3B510  token=0x6000263  System.Void _InitGameSettingNotchPadding()
  RVA=0x0426FE60  token=0x6000264  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginGameUpdateNode
TYPE:  class
TOKEN: 0x2000076
SIZE:  0x30
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginGameUpdater   m_sdk  // 0x20
  private           Beyond.Login.NetUsagePolicy     m_netUsagePolicy  // 0x28
PROPERTIES:
  type  get=0x03D555E0
METHODS:
  RVA=0x036BCA80  token=0x6000266  UnityEngine.CustomYieldInstruction Work()
  RVA=0x036BCB90  token=0x6000267  System.Collections.IEnumerator _GameUpdateCoroutine()
  RVA=0x05774B44  token=0x6000268  System.Collections.IEnumerator _GameUpdateCoroutineMobileImpl()
  RVA=0x0350B670  token=0x6000269  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginGameUpdater
TYPE:  class
TOKEN: 0x2000079
SIZE:  0x50
FIELDS:
  private   static  System.Single                   COOLDOWN_INSTALL  // const
  private   static  System.Int32                    ERROR_CODE_NETWORK  // const
  private   static  System.Int32                    ERROR_INIT_FAILED  // const
  private   static  System.Int32                    ERROR_DESERIALIZE_FAILED  // const
  public    static  System.Int32                    ERROR_ACTION  // const
  private   static  System.Int32                    WAIT_TIME_SECONDS_MIN  // const
  private   static  System.Int32                    WAIT_TIME_SECONDS_MAX  // const
  private           Beyond.Login.LoginGameUpdater.Optionsm_options  // 0x10
  private           Beyond.SDK.IGameUpdateInterface m_sdkImpl  // 0x28
  private           System.Boolean                  m_hasUpdateAlerted  // 0x30
  private           Beyond.Login.LoginGameUpdater.Contextm_context  // 0x38
  private           Beyond.Login.LoginProgress      m_progress  // 0x40
  private           Beyond.Login.LoginHotUpdateProp m_hotUpdateProp  // 0x48
METHODS:
  RVA=0x036BD0C0  token=0x6000276  System.Void Clear()
  RVA=0x028D4D20  token=0x6000277  System.Void .ctor(Beyond.Login.LoginGameUpdater.Options options)
  RVA=0x05774BD4  token=0x6000278  System.Collections.IEnumerator CheckLastGameInfo(Beyond.Login.LoginGameUpdater.Result result)
  RVA=0x05774C7C  token=0x6000279  System.Collections.IEnumerator DoUpdate(Beyond.Login.LoginGameUpdater.Result result)
  RVA=0x05775120  token=0x600027A  System.Collections.IEnumerator _GetLastGameInfo(Beyond.Login.LoginGameUpdater.Context context)
  RVA=0x05775410  token=0x600027B  System.Collections.IEnumerator _UpdateGame(Beyond.Login.LoginGameUpdater.Context context)
  RVA=0x05775078  token=0x600027C  System.Collections.IEnumerator _DoTaskUpdating(Beyond.Login.LoginGameUpdater.Context context)
  RVA=0x057752C8  token=0x600027D  System.Void _OnDownloadStart()
  RVA=0x057751C8  token=0x600027E  System.Void _OnDownloadProgress(System.Int64 curSize, System.Int64 totalSize, System.Int64 speed)
  RVA=0x057755F8  token=0x600027F  System.Collections.IEnumerator _YieldErrorAlert(System.String desc)
  RVA=0x05775558  token=0x6000280  System.Collections.IEnumerator _YieldCheckNetUsagePolicy(System.Int64 downloadSize)
  RVA=0x057754B8  token=0x6000281  System.Collections.IEnumerator _WaitForTaskCancel(System.Int64 taskId)
  RVA=0x0577500C  token=0x6000282  System.Void _CreateDirectoryIfNotExists(System.String folderPath)
  RVA=0x028D47D0  token=0x6000283  System.Void ClearWaitProgress()
  RVA=0x05774EC8  token=0x6000284  System.Void ShowWaitProgress()
  RVA=0x05774D24  token=0x6000285  System.Int32 GetNoAlertCode()
  RVA=0x05774D74  token=0x6000286  System.Single GetWaitTime()
END_CLASS

CLASS: Beyond.Login.LoginGSNode
TYPE:  class
TOKEN: 0x200008F
SIZE:  0x28
EXTENDS: Node
FIELDS:
  private   static  System.Int32                    FLOW_NONE  // const
  private   static  System.Int32                    FLOW_WORKING  // const
  private   static  System.Int32                    FLOW_FINISH  // const
  private   static  System.Int32                    FLOW_ABORTING  // const
  private           Beyond.Login.LoginGSNode.EnterGameServiceFlowm_flow  // 0x20
PROPERTIES:
  type  get=0x03D557B0
METHODS:
  RVA=0x039CEFB0  token=0x60002CA  UnityEngine.CustomYieldInstruction Work()
  RVA=0x02D75850  token=0x60002CB  System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param)
  RVA=0x02D78290  token=0x60002CC  System.Collections.IEnumerator _ConfirmServer()
  RVA=0x0577459C  token=0x60002CD  System.Void _FallbackToInitWithMask(System.Boolean bLogoutAccount)
  RVA=0x057748BC  token=0x60002CE  System.Void _OnEventLogout()
  RVA=0x05774A00  token=0x60002CF  System.Void _OnEventResourceRepair()
  RVA=0x05774800  token=0x60002D0  System.Boolean _LogoutToInitNode()
  RVA=0x0577451C  token=0x60002D1  System.Boolean _FallbackToInitNodeImpl()
  RVA=0x05774720  token=0x60002D2  System.Boolean _FallbackToResRepairImpl()
  RVA=0x0350B670  token=0x60002D3  System.Void .ctor()
  RVA=0x057743E4  token=0x60002D4  System.Void <_OnEventLogout>b__12_0()
  RVA=0x057743F0  token=0x60002D5  System.Void <_OnEventResourceRepair>b__13_0()
  RVA=0x057743DC  token=0x60002D6  System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1)
END_CLASS

CLASS: Beyond.Login.LoginHotUpdateProp
TYPE:  class
TOKEN: 0x2000099
SIZE:  0x30
EXTENDS: Beyond.Login.LoginProperty`1
FIELDS:
METHODS:
  RVA=0x028D48A0  token=0x6000313  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
END_CLASS

CLASS: Beyond.Login.LoginHotUpdateModel
TYPE:  class
TOKEN: 0x200009A
SIZE:  0x28
FIELDS:
  public            System.String                   title  // 0x10
  public            System.String                   desc  // 0x18
  public            Beyond.Login.LoginHotUpdateModel.IProgressprogress  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000314  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginHotUpdater
TYPE:  class
TOKEN: 0x200009D
SIZE:  0x48
EXTENDS: UnityEngine.CustomYieldInstruction
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.Int32                    MODE_SKIP  // const
  private   static  System.Int32                    MODE_DOWNLOAD  // const
  private   static  System.Int32                    MODE_LOCAL  // const
  private   static  System.Boolean                  s_hasInitialAssetChanged  // static @ 0x0
  private   static  System.Boolean                  s_isNeedSoftRestart  // static @ 0x1
  private           Beyond.LoginContext             m_loginCxt  // 0x10
  private           System.Collections.IEnumerator  m_mainRoutine  // 0x18
  private           Beyond.Login.LoginProgress      m_progress  // 0x20
  private           Beyond.Login.LoginHotUpdateProp m_hotupdateProp  // 0x28
  private           Beyond.Login.LoginDownloadTask  m_downloadTask  // 0x30
  private           Beyond.Login.LoginLocalResTask  m_localResTask  // 0x38
  private           System.Boolean                  m_resRepairMode  // 0x40
  public    static  System.String                   URL_GET_SPLIT  // const
PROPERTIES:
  keepWaiting  get=0x02702DB0
METHODS:
  RVA=0x05775800  token=0x600031C  System.Void MarkInitialAssetChanged()
  RVA=0x057756A0  token=0x600031D  System.Boolean CheckInitialAssetChanged()
  RVA=0x0577586C  token=0x600031E  System.Void MarkNeedClearFolder(System.Boolean isInitial)
  RVA=0x05775960  token=0x600031F  System.Boolean NeedClearFolder(System.Boolean isInitial)
  RVA=0x05775778  token=0x6000320  System.Void MarkClearSuccessed(System.Boolean isInitial)
  RVA=0x057758F4  token=0x6000321  System.Void MarkSoftRestart()
  RVA=0x0577570C  token=0x6000322  System.Void ClearSoftRestartFlag()
  RVA=0x02C38960  token=0x6000323  System.Boolean IsNeedSoftRestart()
  RVA=0x03CA90B0  token=0x6000324  System.Void .ctor(Beyond.LoginContext context, System.Boolean resRepairMode)
  RVA=0x0379F8E0  token=0x6000326  System.Void Dispose()
  RVA=0x02C36CB0  token=0x6000327  Beyond.Login.LoginHotUpdater StartHotUpdate(Beyond.LoginContext context, System.Boolean resRepairMode)
  RVA=0x02C36D60  token=0x6000328  System.Collections.IEnumerator _Work()
  RVA=0x02F42390  token=0x6000329  System.Collections.IEnumerator _CreateMainCoroutine(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x0399EAC0  token=0x600032A  System.Collections.IEnumerator _MainCoroutineModeSkip(Beyond.Login.LoginHotUpdater.WorkContext context)
  RVA=0x0577661C  token=0x600032B  System.Collections.IEnumerator _MainCoroutineModeLocal(Beyond.Login.LoginHotUpdater.WorkContext context)
  RVA=0x02F42300  token=0x600032C  System.Collections.IEnumerator _UpdateResVersion(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x02F43200  token=0x600032D  System.Void _SetResVersionForLog()
  RVA=0x05776304  token=0x600032E  System.String _GetOnlineResVersion(System.Boolean isInitial)
  RVA=0x057759E4  token=0x600032F  System.String ResourceRootUrl(System.String version, System.Boolean isInitial)
  RVA=0x057769C0  token=0x6000330  System.Collections.IEnumerator _UpdateResVersionDev(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x03B38830  token=0x6000331  System.Collections.IEnumerator _UpdateResVersionProd(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x05776908  token=0x6000332  System.String _ResourcePatchUrl(System.String version, System.Boolean isInitial)
  RVA=0x057766C4  token=0x6000333  System.String _ResourceFileUrl(System.String version, System.Boolean isInitial)
  RVA=0x05776844  token=0x6000334  System.String _ResourcePatchRootUrl(System.String version, System.Boolean isInitial)
  RVA=0x0577677C  token=0x6000335  System.String _ResourceIndexUrl(System.String version, System.Boolean isInitial)
  RVA=0x05776574  token=0x6000336  System.Collections.IEnumerator _MainCoroutineModeDownload(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x03B21C20  token=0x6000337  System.Collections.IEnumerator _ReloadResourceIndexes(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x057763D8  token=0x6000338  System.Collections.IEnumerator _LoadOrDownloadResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef resIndexRef)
  RVA=0x0577614C  token=0x6000339  System.Collections.IEnumerator _GenResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x05776228  token=0x600033A  System.Collections.IEnumerator _GenRiff(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x01039570  token=0x600033B  Beyond.Resource.HotUpdate.LocalResPref _CreateUpdatedLocalResPref(System.String onlineVer, System.Boolean isInitial, Beyond.Resource.HotUpdate.LocalResPref oldLocalResPref, Beyond.Resource.HotUpdate.FResourceDiff resDiff, System.Int32& removedFileCount)
  RVA=0x0577607C  token=0x600033C  System.Collections.IEnumerator _GenLocalRef(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x05775BFC  token=0x600033D  System.Collections.IEnumerator _CheckAndDownloadResource(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x05775F64  token=0x600033E  System.Void _EventLogDownloadProgress(System.Boolean& first, System.Double current, System.Double total, System.Int32 target, System.Boolean isInitial)
  RVA=0x05775E88  token=0x600033F  System.Collections.IEnumerator _DownloadPatchInfo(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef patchInfoRef)
  RVA=0x05775DB4  token=0x6000340  System.Collections.IEnumerator _ClearDownloadFolder(Beyond.Login.LoginHotUpdater.WorkContext workContext, System.Boolean needDeleteInitial, System.Boolean needDeleteMain)
  RVA=0x05775CD8  token=0x6000341  System.Collections.IEnumerator _CheckLocalResConsistency(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext context)
  RVA=0x05776A48  token=0x6000342  System.Collections.IEnumerator _VitalError(System.String error)
  RVA=0x057764B4  token=0x6000343  System.Collections.IEnumerator _LoadStreamingIndex(System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext, Beyond.Misc.ObjectRef resultRef)
  RVA=0x05775AA0  token=0x6000344  System.Void WriteLocalResPrefToFile(Beyond.Resource.HotUpdate.LocalResPref localResPref, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x0399EB50  token=0x6000345  System.Int32 _CurrentWorkMode(Beyond.LoginContext context)
END_CLASS

CLASS: Beyond.Login.LoginProgress
TYPE:  class
TOKEN: 0x20000B7
SIZE:  0x50
IMPLEMENTS: IProgress
FIELDS:
  public    static  System.Int32                    MODE_PROG  // const
  public    static  System.Int32                    MODE_SIZE  // const
  public    static  System.Int32                    MODE_IDEL  // const
  public            System.Int32                    mode  // 0x10
  public            System.Double                   current  // 0x18
  public            System.Double                   total  // 0x20
  public            System.Double                   speed  // 0x28
  private           Beyond.Login.LoginProgress.FDownloadSizem_downloadSize  // 0x30
METHODS:
  RVA=0x0577ED44  token=0x60003CC  System.Double GetCurrent()
  RVA=0x0577EE40  token=0x60003CD  System.Double GetTotal()
  RVA=0x0577ED94  token=0x60003CE  System.String GetInfo()
  RVA=0x0350B670  token=0x60003CF  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginInitNode
TYPE:  class
TOKEN: 0x20000BA
SIZE:  0x28
EXTENDS: Node
FIELDS:
  private           System.Boolean                  m_isSDKInited  // 0x20
PROPERTIES:
  type  get=0x03D50CD0
METHODS:
  RVA=0x036BCBF0  token=0x60003D9  UnityEngine.CustomYieldInstruction Work()
  RVA=0x036BCCD0  token=0x60003DA  System.Collections.IEnumerator _InitCoroutine()
  RVA=0x03893CB0  token=0x60003DB  System.Collections.IEnumerator _InitRemoteConfigs()
  RVA=0x0577D82C  token=0x60003DC  System.Collections.IEnumerator _YieldAlertError(System.String errorInfo)
  RVA=0x0350B670  token=0x60003DD  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginLocalResTask
TYPE:  class
TOKEN: 0x20000BE
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Beyond.LoginContext             m_loginCxt  // 0x10
  private           Beyond.Login.LoginHotUpdater.WorkContextm_workCxt  // 0x18
METHODS:
  RVA=0x02676770  token=0x60003F0  System.Void .ctor(Beyond.LoginContext loginContext, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  RVA=0x0577DD64  token=0x60003F1  System.Collections.IEnumerator Work()
  RVA=0x0577DD20  token=0x60003F2  System.Void Dispose()
END_CLASS

CLASS: Beyond.Login.PreloadNode
TYPE:  class
TOKEN: 0x20000C1
SIZE:  0x38
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginHotUpdateModel.SimpleProgressm_progress  // 0x20
  private           System.Boolean                  m_getServerListSuc  // 0x28
  private           System.String                   m_errorMsg  // 0x30
PROPERTIES:
  type  get=0x03D55800
METHODS:
  RVA=0x02C362C0  token=0x60003FD  UnityEngine.CustomYieldInstruction Work()
  RVA=0x028D4940  token=0x60003FE  System.Void _ShowPreloadResourcePanel()
  RVA=0x02C36460  token=0x60003FF  System.Collections.IEnumerator _LoginPreLoad()
  RVA=0x02C34EE0  token=0x6000400  System.Collections.IEnumerator _WarmUp()
  RVA=0x02C34E70  token=0x6000401  System.Collections.IEnumerator _GetServerList()
  RVA=0x02C34F50  token=0x6000402  System.Void _EnterPreLoad()
  RVA=0x02D77060  token=0x6000403  System.Collections.IEnumerator _GetServerListInfoMock()
  RVA=0x0578006C  token=0x6000404  System.Collections.IEnumerator _GetServerListInfo()
  RVA=0x02D763A0  token=0x6000405  System.Void _OnGetServerListSuc()
  RVA=0x057800FC  token=0x6000406  System.Void _OnGetServerListFail(System.String errorInfo)
  RVA=0x037B81F0  token=0x6000407  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginSDKInitNode
TYPE:  class
TOKEN: 0x20000C9
SIZE:  0x28
EXTENDS: Node
FIELDS:
  private           System.Boolean                  m_isSDKInited  // 0x20
PROPERTIES:
  type  get=0x02102C70
METHODS:
  RVA=0x036BCD40  token=0x600042D  UnityEngine.CustomYieldInstruction Work()
  RVA=0x036BCE20  token=0x600042E  System.Collections.IEnumerator _SDKInitCoroutine()
  RVA=0x02D78350  token=0x600042F  System.Collections.IEnumerator _WaitForSDKInited()
  RVA=0x02D77C90  token=0x6000430  System.Collections.IEnumerator _InitSubSDKs(System.String env)
  RVA=0x0350B670  token=0x6000431  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.U8LoginNode
TYPE:  class
TOKEN: 0x20000CD
SIZE:  0x28
EXTENDS: Node
FIELDS:
  private           System.Boolean                  m_loginSuc  // 0x20
  private           System.Boolean                  m_isSDKLoginFinished  // 0x21
  private           System.Int32                    m_rqstSkipLoginCache  // 0x24
PROPERTIES:
  type  get=0x03D51100
METHODS:
  RVA=0x036BCE90  token=0x6000445  UnityEngine.CustomYieldInstruction Work()
  RVA=0x036BCF70  token=0x6000446  System.Collections.IEnumerator _LoginCoroutine()
  RVA=0x02D783B0  token=0x6000447  System.Collections.IEnumerator _FinishLogin()
  RVA=0x05782484  token=0x6000448  System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param)
  RVA=0x02C37AE0  token=0x6000449  System.Void _StartSDKLogin()
  RVA=0x02D770D0  token=0x600044A  System.Void _SetCursorOnLoginStart()
  RVA=0x02D77240  token=0x600044B  System.Void _SetCursorOnLoginFinish()
  RVA=0x057827B4  token=0x600044C  System.Void _SkipSDKLogin()
  RVA=0x028D4640  token=0x600044D  System.Void _ClearLoginCaches()
  RVA=0x02EA95C0  token=0x600044E  System.Void _OnLoginSuc()
  RVA=0x0578268C  token=0x600044F  System.Void _OnLoginFail(System.Object rawInfo)
  RVA=0x02EA9BE0  token=0x6000450  System.Void _OnSDKViewDisabled()
  RVA=0x057825E0  token=0x6000451  System.Void _OnLoginCanceled()
  RVA=0x02EA97C0  token=0x6000452  System.Void _EnableBlurMask(System.Boolean enable)
  RVA=0x0350B670  token=0x6000453  System.Void .ctor()
  RVA=0x02D77150  token=0x6000454  System.Void <_StartSDKLogin>b__9_0(System.String sessionToken)
  RVA=0x05782508  token=0x6000455  System.Void <_StartSDKLogin>b__9_1(System.Object pram)
  RVA=0x057743DC  token=0x6000456  System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1)
END_CLASS

CLASS: Beyond.Login.LoginProperty`1
TYPE:  class
TOKEN: 0x20000D0
IMPLEMENTS: IWorkerUpdateOnce
FIELDS:
  private           T                               m_value  // 0x0
  private           System.Collections.Generic.HashSet<Beyond.Login.ILoginBinder<T>>m_binders  // 0x0
  private           Beyond.Login.LoginWorkFlow      m_workflow  // 0x0
  private           System.Boolean                  <isDataChanged>k__BackingField  // 0x0
PROPERTIES:
  isDataChanged  get=-1  // not resolved  set=-1  // not resolved
  value  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000463  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
  RVA=-1  // not resolved  token=0x6000467  System.Void NotifyDataChanged()
  RVA=-1  // not resolved  token=0x6000468  System.Void Bind(Beyond.Login.ILoginBinder<T> binder)
  RVA=-1  // not resolved  token=0x6000469  System.Void Worker_UpdateOnce()
END_CLASS

CLASS: Beyond.Login.ILoginBinder`1
TYPE:  interface
TOKEN: 0x20000D1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600046A  System.Void OnValueChanged(T value)
END_CLASS

CLASS: Beyond.Login.ILoginContextReceiver
TYPE:  interface
TOKEN: 0x20000D2
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600046B  System.Void OnLoginContext(Beyond.LoginContext context)
END_CLASS

CLASS: Beyond.Login.LoginViewModel
TYPE:  class
TOKEN: 0x20000D3
SIZE:  0x30
FIELDS:
  public            Beyond.Login.LoginWorkFlow.ENodeworkCachedCurNode  // 0x10
  public            Beyond.Login.LoginWorkFlow.ENodeworkCurNode  // 0x14
  public            System.Boolean                  isFirstLogin  // 0x18
  private           System.Int32                    <rqstSkipU8Login>k__BackingField  // 0x1c
  public            System.Boolean                  isU8LoginCancelled  // 0x20
  private           System.Int32                    <rqstResRepairCode>k__BackingField  // 0x24
  public            Beyond.Login.LoginViewModel.FAgeTipsPolicyageTipsPolicy  // 0x28
PROPERTIES:
  rqstSkipU8Login  get=0x03D4EBB0  set=0x03D4EBC0
  rqstResRepairCode  get=0x03D4E2E0  set=0x03D4E2F0
METHODS:
  RVA=0x03CA4880  token=0x600046C  System.Void .ctor()
  RVA=0x02C3B550  token=0x6000471  System.Boolean IsAgeTipsVisible()
  RVA=0x02C3B410  token=0x6000472  System.Boolean IsGovTipsVisible()
  RVA=0x02C3B5E0  token=0x6000473  System.Boolean IsMenuVisible()
  RVA=0x0577EEF4  token=0x6000474  System.Void RequestResourceRepair()
  RVA=0x0577EF40  token=0x6000475  System.Void RequestSkipU8Login()
  RVA=0x03CA48B0  token=0x6000476  Beyond.Login.LoginViewModel.FAgeTipsPolicy _LoadAgeTipsPolicy()
END_CLASS

CLASS: Beyond.Login.LoginViewProperty
TYPE:  class
TOKEN: 0x20000D5
SIZE:  0x48
EXTENDS: Beyond.Login.LoginProperty`1
FIELDS:
  private           Beyond.Login.LoginHotUpdateProp <hotUpdateProp>k__BackingField  // 0x30
  private           Beyond.Login.LoginAgeTipsProp   <ageTipsProp>k__BackingField  // 0x38
  private           Beyond.Login.LoginServerSelectProp<serverSelectProp>k__BackingField  // 0x40
PROPERTIES:
  hotUpdateProp  get=0x01003830  set=0x04270470
  ageTipsProp  get=0x03D4E2A0  set=0x0388FF30
  serverSelectProp  get=0x03D4E2B0  set=0x03CB2D80
METHODS:
  RVA=0x028D44E0  token=0x600047E  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsModel
TYPE:  class
TOKEN: 0x20000D6
SIZE:  0x20
FIELDS:
  public            System.String                   contentCache  // 0x10
  public            System.Boolean                  isShow  // 0x18
  public            System.Boolean                  isFetchingContent  // 0x19
METHODS:
  RVA=0x028D4790  token=0x600047F  System.Boolean IsContentEmpty()
  RVA=0x03C7D0D0  token=0x6000480  System.Boolean CanDisplay()
  RVA=0x0350B670  token=0x6000481  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsProp
TYPE:  class
TOKEN: 0x20000D7
SIZE:  0x30
EXTENDS: Beyond.Login.LoginProperty`1
FIELDS:
METHODS:
  RVA=0x028D4720  token=0x6000482  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
  RVA=0x0577D468  token=0x6000483  System.Void ClearContentCache()
  RVA=0x0577D52C  token=0x6000484  System.Void UpdateContent(System.String content)
END_CLASS

CLASS: Beyond.Login.LoginWorkFlow
TYPE:  class
TOKEN: 0x20000D8
SIZE:  0x50
IMPLEMENTS: System.IDisposable
FIELDS:
  public    static  System.String                   CURSOR_KEY_LOGIN  // const
  private   static readonly Beyond.Login.LoginWorkFlow.ENode[]NODE_ORDER  // static @ 0x0
  private   static  Beyond.Login.LoginWorkFlow.ENodeNEED_GAME_LOGIN_STATE_BEFORE_NODE  // const
  private   readonly Beyond.Login.LoginWorkFlow.Node[]m_nodes  // 0x10
  private   readonly Beyond.LoginContext             m_context  // 0x18
  private           Beyond.Login.LoginWorkFlow.FWorkm_work  // 0x20
  private           Beyond.Login.LoginWorkFlow.Workerm_worker  // 0x30
  private           System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IEventReceiver>m_evtRecvrs  // 0x38
  private           System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IEventReceiver>m_recvrBuffer  // 0x40
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x48
PROPERTIES:
  isDisposed  get=0x03D4EFE0  set=0x03D4F010
METHODS:
  RVA=0x037B7E90  token=0x6000485  Beyond.Login.LoginWorkFlow.Node[] _RegisterNodes()
  RVA=0x02C38A80  token=0x6000488  System.Void .ctor(Beyond.LoginContext context)
  RVA=0x02EA9D50  token=0x6000489  System.Collections.IEnumerator DoWorkFlow()
  RVA=0x02C38C00  token=0x600048A  System.Void Dispose()
  RVA=0x0379FA20  token=0x600048B  System.Boolean PeekFallbackStatus(Beyond.Login.LoginWorkFlow.ENode& fallbackNode)
  RVA=0x0577F0B0  token=0x600048C  System.Boolean Fallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck)
  RVA=0x0577F01C  token=0x600048D  System.Boolean CancelAndFallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck)
  RVA=0x02D75460  token=0x600048E  System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param)
  RVA=0x0577EF8C  token=0x600048F  System.Void AddEventReceiver(Beyond.Login.LoginWorkFlow.IEventReceiver receiver)
  RVA=0x03600790  token=0x6000490  System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst)
  RVA=0x02C396F0  token=0x6000491  System.Boolean IsBeforeWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check)
  RVA=0x02C3B000  token=0x6000492  System.Boolean IsOnOrAfterWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check)
  RVA=0x0577F308  token=0x6000493  System.Boolean IsAfterWork(Beyond.Login.LoginWorkFlow.ENode target, Beyond.Login.LoginWorkFlow.ENode check)
  RVA=0x02D757E0  token=0x6000494  System.Boolean _HandleGlobalEvent(Beyond.ELoginEvent evt, System.Object param)
  RVA=0x0577F690  token=0x6000495  System.Void _EventOnOpenAgeTips()
  RVA=0x0577F3CC  token=0x6000496  System.Void _EventOnCloseAgeTips()
  RVA=0x0577F804  token=0x6000497  System.Void _EventOnOpenServerSelect(System.Boolean isOpen)
  RVA=0x0577F8D4  token=0x6000498  System.Void _EventOnSelectServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData serverZoneData)
  RVA=0x0577F4F4  token=0x6000499  System.Void _EventOnConfirmServer()
  RVA=0x02C383E0  token=0x600049A  System.Void _EnableCursor(System.Boolean enabled)
  RVA=0x0577FA5C  token=0x600049B  System.Void _UpdateCursor(Beyond.EventData<Beyond.DeviceInfo.InputType>& input)
  RVA=0x02D7AB60  token=0x600049C  System.Void _EnbaleToggleGroup()
  RVA=0x0577F9B4  token=0x600049D  System.Collections.IEnumerator _FetchAgeTipsCoroutine(Beyond.Login.LoginAgeTipsProp prop)
  RVA=0x02C395D0  token=0x600049E  System.Boolean _CheckIfGameStateNotMatch(Beyond.Login.LoginWorkFlow.ENode curNode)
  RVA=0x02C38660  token=0x600049F  System.Collections.IEnumerator _AdjustCurrentGameState(Beyond.Login.LoginWorkFlow.ENode curNode)
  RVA=0x03CE3B80  token=0x60004A0  System.Void .cctor()
END_CLASS

CLASS: Beyond.Login.HotUpdateNode
TYPE:  class
TOKEN: 0x20000E3
SIZE:  0x30
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginHotUpdater    m_updater  // 0x20
  private           System.Int32                    m_cachedResRepairCode  // 0x28
PROPERTIES:
  type  get=0x03D51110
METHODS:
  RVA=0x02C36DD0  token=0x60004E5  UnityEngine.CustomYieldInstruction Work()
  RVA=0x0379F7A0  token=0x60004E6  System.Void OnDispose()
  RVA=0x0350B670  token=0x60004E7  System.Void .ctor()
  RVA=0x057732FC  token=0x60004E8  System.Void <>iFixBaseProxy_OnDispose()
END_CLASS

CLASS: Beyond.Login.WaitForSecondsNode
TYPE:  abstract class
TOKEN: 0x20000E4
SIZE:  0x28
EXTENDS: Node
FIELDS:
  private           System.Nullable<System.Int32>   m_timerId  // 0x20
METHODS:
  RVA=0x02C36A50  token=0x60004E9  UnityEngine.CustomYieldInstruction Work()
  RVA=0x038C19F0  token=0x60004EA  System.Boolean _IsTimeout()
  RVA=0x03D07940  token=0x60004EB  System.Void _NotifyTimeout()
  RVA=0x0379F870  token=0x60004EC  System.Void _DisposeTimer()
  RVA=-1  // abstract  token=0x60004ED  System.Single WaitForSeconds(System.Boolean& unscaled)
  RVA=0x0379F800  token=0x60004EE  System.Void OnDispose()
  RVA=0x0350B670  token=0x60004EF  System.Void .ctor()
  RVA=0x057732FC  token=0x60004F0  System.Void <>iFixBaseProxy_OnDispose()
END_CLASS

CLASS: Beyond.Login.PreloadPostDelayNode
TYPE:  class
TOKEN: 0x20000E5
SIZE:  0x28
EXTENDS: Beyond.Login.WaitForSecondsNode
FIELDS:
PROPERTIES:
  type  get=0x03D55810
METHODS:
  RVA=0x03D43E20  token=0x60004F2  System.Single WaitForSeconds(System.Boolean& unscaled)
  RVA=0x02C37580  token=0x60004F3  UnityEngine.CustomYieldInstruction Work()
  RVA=0x028D4A40  token=0x60004F4  System.Void _DisableLoadingPanel()
  RVA=0x0350B670  token=0x60004F5  System.Void .ctor()
  RVA=0x057801B8  token=0x60004F6  UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work()
END_CLASS

CLASS: Beyond.Login.Trans2GsLoginNode
TYPE:  class
TOKEN: 0x20000E6
SIZE:  0x28
EXTENDS: Beyond.Login.WaitForSecondsNode
FIELDS:
PROPERTIES:
  type  get=0x03D55730
METHODS:
  RVA=0x02EA9680  token=0x60004F8  System.Single WaitForSeconds(System.Boolean& unscaled)
  RVA=0x02C37130  token=0x60004F9  UnityEngine.CustomYieldInstruction Work()
  RVA=0x0350B670  token=0x60004FA  System.Void .ctor()
  RVA=0x057801B8  token=0x60004FB  UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work()
END_CLASS

CLASS: Beyond.Login.FinishNode
TYPE:  class
TOKEN: 0x20000E7
SIZE:  0x20
EXTENDS: Node
FIELDS:
PROPERTIES:
  type  get=0x03D557F0
METHODS:
  RVA=0x02C370B0  token=0x60004FD  UnityEngine.CustomYieldInstruction Work()
  RVA=0x0350B670  token=0x60004FE  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.CarrierDownloadCache
TYPE:  sealed struct
TOKEN: 0x20000E8
SIZE:  0x20
FIELDS:
  public    static readonly Beyond.Login.CarrierDownloadCacheEMPTY  // static @ 0x0
  public            System.Int64                    size  // 0x10
  public            System.Boolean                  isAllowed  // 0x18
METHODS:
  RVA=0x03D26E90  token=0x60004FF  System.Void .cctor()
END_CLASS

CLASS: Beyond.Login.NetUsagePolicy
TYPE:  class
TOKEN: 0x20000E9
SIZE:  0x30
FIELDS:
  private   static  System.Int32                    NOT_REACHABLE_ERROR_CODE  // const
  private           Beyond.Login.CarrierDownloadCachem_mobileDataCache  // 0x10
  private           UnityEngine.NetworkReachability m_lastNetworkState  // 0x20
  private           Beyond.Login.NetUsagePolicy.Optionsm_options  // 0x28
METHODS:
  RVA=0x028D5280  token=0x6000500  System.Void .ctor(Beyond.Login.NetUsagePolicy.Options options)
  RVA=0x0577FBFC  token=0x6000501  System.Void CheckIfAllowDownload(System.Int64 downloadSize, System.Action onAllowed, System.Action onRejected, System.Action onReachable)
  RVA=0x0577FBA4  token=0x6000502  System.Boolean AllowMobileDataInLastCheck()
  RVA=0x0577FF4C  token=0x6000503  System.String _GetPrettySizeStringUpToMB(System.Double number)
END_CLASS

CLASS: Beyond.Login.LoginSceneAnimCtrl
TYPE:  class
TOKEN: 0x20000EC
SIZE:  0xD8
EXTENDS: Beyond.Login.LoginSceneComponent
IMPLEMENTS: Beyond.Login.ILoginBinder`1 UnityEngine.IAnimationClipSource
FIELDS:
  private   static  System.Single                   COUNT_DOWN_EMPTY  // const
  private           UnityEngine.Animator            _target  // 0x78
  private           UnityEngine.AnimationClip       _clipA1  // 0x80
  private           UnityEngine.AnimationClip       _clipA1s  // 0x88
  private           System.Single                   _transA1  // 0x90
  private           System.Single                   _transA1s  // 0x94
  private           UnityEngine.Vector2             _randomRangeA1s  // 0x98
  private           UnityEngine.AnimationClip       _clipA1A2  // 0xa0
  private           System.Single                   _predelayA1A2  // 0xa8
  private           System.Single                   _transA1A2  // 0xac
  private           UnityEngine.AnimationClip       _clipA2  // 0xb0
  private           System.Single                   _transA2  // 0xb8
  private           Beyond.UI.UIAnimationMixPlayer  m_player  // 0xc0
  private           Beyond.Login.LoginSceneAnimCtrl.EStatem_state  // 0xc8
  private           System.Single                   m_countDownA1s  // 0xcc
  private           System.Single                   m_countDownA1A2  // 0xd0
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x02EA91C0  token=0x6000508  System.Void OnBindToManager()
  RVA=0x03099C10  token=0x6000509  Beyond.UI.UIAnimationMixPlayer _EnsurePlayer()
  RVA=0x02C3AF80  token=0x600050A  System.Void _ChangeToState(Beyond.Login.LoginSceneAnimCtrl.EState target)
  RVA=0x03099840  token=0x600050B  System.Void _ResetToA1()
  RVA=0x039B3B00  token=0x600050C  System.Void _TransitionToA2()
  RVA=0x030996A0  token=0x600050D  System.Void _PlayA1sAndTriggerNext()
  RVA=0x03099E60  token=0x600050E  System.Single _RandomIntervalA1s()
  RVA=0x03099A10  token=0x600050F  System.Void _PlayA1A2Impl()
  RVA=0x02C3AEE0  token=0x6000510  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  RVA=0x02C3CA20  token=0x6000511  System.Void Start()
  RVA=0x0262E210  token=0x6000512  System.Void Tick(System.Single deltaTime)
  RVA=0x039A13E0  token=0x6000513  System.Void OnRelease()
  RVA=0x0577EE90  token=0x6000514  System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results)
  RVA=0x03B5CD10  token=0x6000515  System.Void .ctor()
  RVA=0x0577EEE4  token=0x6000516  System.Void <>iFixBaseProxy_OnBindToManager()
  RVA=0x0577EEEC  token=0x6000517  System.Void <>iFixBaseProxy_Start()
  RVA=0x0577D7BC  token=0x6000518  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0577D7B4  token=0x6000519  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.Login.LoginSceneComponent
TYPE:  abstract class
TOKEN: 0x20000EE
SIZE:  0x78
EXTENDS: Beyond.TickableMono
FIELDS:
  private           Beyond.LoginContext             <context>k__BackingField  // 0x68
  private           Beyond.LoginController          <controller>k__BackingField  // 0x70
PROPERTIES:
  tickOption  get=0x01002730
  context  get=0x03D4EAB0  set=0x038C5570
  controller  get=0x03D4EB30  set=0x0519C3C8
METHODS:
  RVA=0x02C3CB50  token=0x600051F  System.Void Start()
  RVA=0x02EA9A40  token=0x6000520  System.Void Bind(Beyond.LoginContext context, Beyond.LoginController controller)
  RVA=0x02EA94D0  token=0x6000521  System.Void OnBindToManager()
  RVA=0x02846010  token=0x6000522  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginSceneRoot
TYPE:  class
TOKEN: 0x20000EF
SIZE:  0x78
EXTENDS: Beyond.Login.LoginSceneComponent
FIELDS:
PROPERTIES:
  tickOption  get=0x01002730
METHODS:
  RVA=0x02EA88F0  token=0x6000524  System.Void OnBindToManager()
  RVA=0x02846010  token=0x6000525  System.Void .ctor()
  RVA=0x0577EEE4  token=0x6000526  System.Void <>iFixBaseProxy_OnBindToManager()
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsDetailPanel
TYPE:  class
TOKEN: 0x20000F0
SIZE:  0x68
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private           Beyond.UI.UIAnimationWrapper    _anim  // 0x18
  private           UnityEngine.RectTransform       _content  // 0x20
  private           Beyond.UI.UIText                _txtTitle  // 0x28
  private           Beyond.UI.UIText                _lineTmpl  // 0x30
  private           Beyond.UI.UIButton              _btnClose  // 0x38
  private           Beyond.UI.UIScrollRect          _scroll  // 0x40
  private           Beyond.Input.InputBindingGroupMonoTarget_ageTipsBindingGroup  // 0x48
  private           Beyond.LoginContext             m_context  // 0x50
  private           Beyond.UI.UISwitchTween         m_switchTween  // 0x58
  private           DG.Tweening.Tween               m_displayDelayTween  // 0x60
  private   static  System.Int32                    MAX_TEXT_STRLEN  // const
  private   static  System.Int32                    MIN_TEXT_STRLEN  // const
METHODS:
  RVA=0x03610BA0  token=0x6000527  System.Void Init(Beyond.LoginContext context)
  RVA=0x03C7D010  token=0x6000528  System.Void OnValueChanged(Beyond.Login.LoginAgeTipsModel value)
  RVA=0x0577CE6C  token=0x6000529  System.Void _RenderContent(System.String contentStr)
  RVA=0x0577CFDC  token=0x600052A  System.Void _ShowContent()
  RVA=0x0577CDF4  token=0x600052B  System.Void _EventOnCloseClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577D038  token=0x600052C  System.Collections.Generic.List<System.String> _SplitLicenseToSegments(System.String content)
  RVA=0x0577D31C  token=0x600052D  System.Void _SplitLongString(System.String longStr, System.Collections.Generic.List<System.String> outputList)
  RVA=0x0426FE60  token=0x600052E  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsPanel
TYPE:  class
TOKEN: 0x20000F1
SIZE:  0x48
EXTENDS: ChildPanel
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private           Beyond.Login.LoginAgeTipsDetailPanel_detailPanel  // 0x28
  private           Beyond.UI.UIButton              _ageTipsCN  // 0x30
  private           UnityEngine.GameObject          _ageTipsKR  // 0x38
  private           UnityEngine.CanvasGroup         _canvasVersionTop  // 0x40
METHODS:
  RVA=0x03610410  token=0x600052F  System.Void OnInit()
  RVA=0x02C3B4C0  token=0x6000530  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  RVA=0x02C3BBA0  token=0x6000531  System.Void _UpdateAgeTipsPolicy(Beyond.Login.LoginViewModel.FAgeTipsPolicy policy)
  RVA=0x0577D3F0  token=0x6000532  System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0426FE60  token=0x6000533  System.Void .ctor()
  RVA=0x0577D3E8  token=0x6000534  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginAlertDialog
TYPE:  class
TOKEN: 0x20000F2
SIZE:  0x58
EXTENDS: Dialog
FIELDS:
  private           Beyond.UI.UIButton              _btnConfirm  // 0x38
  private           Beyond.UI.UIText                _text  // 0x40
  private           Beyond.Login.LoginAlertDialog.FParamsm_params  // 0x48
METHODS:
  RVA=0x0577D5DC  token=0x6000535  System.Void OnInit()
  RVA=0x0577D6C0  token=0x6000536  System.Void SetParams(Beyond.Login.LoginAlertDialog.FParams param)
  RVA=0x0577D750  token=0x6000537  System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt)
  RVA=0x0426FE60  token=0x6000538  System.Void .ctor()
  RVA=0x0577D748  token=0x6000539  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginDecorateUI
TYPE:  class
TOKEN: 0x20000F4
SIZE:  0xE0
EXTENDS: Beyond.TickableUIMono
IMPLEMENTS: Beyond.Login.ILoginBinder`1 Beyond.Login.ILoginContextReceiver
FIELDS:
  private           UnityEngine.CanvasGroup         _imgLogo  // 0x68
  private           System.Single                   _durationLogo  // 0x70
  private           UnityEngine.AnimationClip       _clipLoopGlow  // 0x78
  private           UnityEngine.AnimationClip       _clipInGlow  // 0x80
  private           UnityEngine.Animator            _targetGlow  // 0x88
  private           System.Single                   _delay  // 0x90
  private           Beyond.LoginContext             m_context  // 0x98
  private           System.Boolean                  m_isOnTransNode  // 0xa0
  private           Beyond.Interpolator.FLerpByTime m_hideLogoLerp  // 0xa8
  private           Beyond.UI.UIAnimationLayerMixPlayerm_glowPlayer  // 0xc8
  private           System.Boolean                  m_isGlowEnabled  // 0xd0
  private           System.Single                   m_countDownDelay  // 0xd4
  private           System.Single                   m_countDownDisableGlow  // 0xd8
PROPERTIES:
  tickOption  get=0x03D55800
METHODS:
  RVA=0x02EA9EA0  token=0x600053B  System.Void OnLoginContext(Beyond.LoginContext context)
  RVA=0x02C3B6B0  token=0x600053C  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  RVA=0x03099310  token=0x600053D  System.Void _TriggerTrans2GSLoginImpl()
  RVA=0x02C3BF30  token=0x600053E  System.Void _ToggleGlow(System.Boolean enable)
  RVA=0x03099490  token=0x600053F  Beyond.UI.UIAnimationLayerMixPlayer _EnsureGlowPlayer()
  RVA=0x03099050  token=0x6000540  System.Void Tick(System.Single deltaTime)
  RVA=0x039A1360  token=0x6000541  System.Void OnRelease()
  RVA=0x030990E0  token=0x6000542  System.Void _TimeManagerTick(System.Single timeDelta)
  RVA=0x03C85980  token=0x6000543  System.Void .ctor()
  RVA=0x0577D7BC  token=0x6000544  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  RVA=0x0577D7B4  token=0x6000545  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.Login.LoginEnterGamePanel
TYPE:  class
TOKEN: 0x20000F5
SIZE:  0x58
EXTENDS: ChildPanel
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x28
  private           Beyond.UI.UIButton              _btnEnterGame  // 0x30
  private           Beyond.UI.UIText                _textEnterGame  // 0x38
  private           System.Single                   _delayEnterGame  // 0x40
  private           System.Boolean                  m_isPanelActive  // 0x44
  private           System.Double                   m_panelActiveTime  // 0x48
  private           System.Boolean                  m_isInited  // 0x50
METHODS:
  RVA=0x03B5BDA0  token=0x6000546  System.Void _InitIfNot()
  RVA=0x02C3BAB0  token=0x6000547  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  RVA=0x02D753B0  token=0x6000548  System.Void _OnEnterGameClicked(UnityEngine.EventSystems.PointerEventData evt)
  RVA=0x03CDE0E0  token=0x6000549  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginGovTipsPanel
TYPE:  class
TOKEN: 0x20000F6
SIZE:  0x30
EXTENDS: ChildPanel
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private           Beyond.UI.UIButton              _btnOpen  // 0x28
METHODS:
  RVA=0x03610530  token=0x600054A  System.Void OnInit()
  RVA=0x02C3B3B0  token=0x600054B  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  RVA=0x0577D7C4  token=0x600054C  System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0426FE60  token=0x600054D  System.Void .ctor()
  RVA=0x0577D3E8  token=0x600054E  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginJudgeDialog
TYPE:  class
TOKEN: 0x20000F7
SIZE:  0x98
EXTENDS: Dialog
FIELDS:
  private           Beyond.UI.UIButton              _btnPositive  // 0x38
  private           Beyond.UI.UIButton              _btnNegative  // 0x40
  private           Beyond.UI.UIText                _text  // 0x48
  private           Beyond.UI.UIText                _text2  // 0x50
  private           Beyond.UI.UIText                _textPositive  // 0x58
  private           Beyond.UI.UIText                _textNegative  // 0x60
  private           Beyond.Login.LoginJudgeDialog.FParamsm_params  // 0x68
METHODS:
  RVA=0x0577D8C8  token=0x600054F  System.Void OnInit()
  RVA=0x0577DA14  token=0x6000550  System.Void SetParams(Beyond.Login.LoginJudgeDialog.FParams param)
  RVA=0x0577DCBC  token=0x6000551  System.Void _OnPositiveClicked(UnityEngine.EventSystems.PointerEventData evt)
  RVA=0x0577DC58  token=0x6000552  System.Void _OnNegativeClicked(UnityEngine.EventSystems.PointerEventData evt)
  RVA=0x0426FE60  token=0x6000553  System.Void .ctor()
  RVA=0x0577D748  token=0x6000554  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginMenuPanel
TYPE:  class
TOKEN: 0x20000FA
SIZE:  0xF0
EXTENDS: ChildPanel
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  public    static  System.String                   CONTROLLER_STATE_NORMAL  // const
  public    static  System.String                   CONTROLLER_STATE_SELECT  // const
  private           Beyond.UI.UIButton              _btnAnnounce  // 0x28
  private           Beyond.UI.UIButton              _btnSetting  // 0x30
  private           Beyond.UI.UIButton              _btnResCheck  // 0x38
  private           Beyond.UI.UIButton              _btnLogout  // 0x40
  private           Beyond.UI.UIButton              _btnQuitGame  // 0x48
  private           Beyond.UI.UIButton              _btnLogin  // 0x50
  private           Beyond.UI.UIButton              _btnQR  // 0x58
  private           Beyond.UI.UIState.UIStateController_ctrlAnnounce  // 0x60
  private           Beyond.UI.UIState.UIStateController_ctrlSetting  // 0x68
  private           Beyond.UI.UIState.UIStateController_ctrlResCheck  // 0x70
  private           Beyond.UI.UIState.UIStateController_ctrlLogout  // 0x78
  private           Beyond.UI.UIState.UIStateController_ctrlQR  // 0x80
  private           Beyond.UI.UISimpleStateController_ctrlRight  // 0x88
  private           Beyond.UI.UISelectableNaviGroup _naviGroupRight  // 0x90
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroupForKeyboard  // 0x98
  private           Beyond.Input.InputBindingGroupMonoTarget_rootPanelBindingGroup  // 0xa0
  private           UnityEngine.CanvasGroup         _alphaHandler  // 0xa8
  private           UnityEngine.GameObject          _redDotAnnounce  // 0xb0
  private           Beyond.UI.UIAnimationWrapper    _transAnim  // 0xb8
  private           Beyond.UI.UIButton              _serverZoneBtn  // 0xc0
  private           Beyond.UI.UIText                _serverZoneName  // 0xc8
  private           UnityEngine.GameObject          _serverZonePS5  // 0xd0
  private           Beyond.UI.UIText                _serverZoneNamePS5  // 0xd8
  private           Beyond.UI.UIState.UIStateControllerm_curRightBtnCtrl  // 0xe0
  private           System.Boolean                  m_hasRedDot  // 0xe8
  private           System.Int32                    m_rootParentGroupId  // 0xec
METHODS:
  RVA=0x02D9D470  token=0x6000555  System.Void OnInit()
  RVA=0x02C3B0D0  token=0x6000556  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  RVA=0x02EAA0E0  token=0x6000557  System.Void InitBulletinAndRedAfterLoginSuc()
  RVA=0x03D42D10  token=0x6000558  System.Void _OnBulletinOpen()
  RVA=0x03D2B470  token=0x6000559  System.Void _OnBulletinClose()
  RVA=0x03C7EF60  token=0x600055A  System.Void Awake()
  RVA=0x029749B0  token=0x600055B  System.Void OnEnable()
  RVA=0x02974BB0  token=0x600055C  System.Void OnDisable()
  RVA=0x03C7AE80  token=0x600055D  System.Void OnDestroy()
  RVA=0x0577E224  token=0x600055E  System.Void _OnAnnounceClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577EC58  token=0x600055F  System.Void _OnSettingClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577EB24  token=0x6000560  System.Void _OnResCheckClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E45C  token=0x6000561  System.Void _OnCustomServiceClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E15C  token=0x6000562  System.Void _OnAccountCenterClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E7A0  token=0x6000563  System.Void _OnLogoutClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E918  token=0x6000564  System.Void _OnQuitGameClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E728  token=0x6000565  System.Void _OnLoginClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E868  token=0x6000566  System.Void _OnQRClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577EAB8  token=0x6000567  System.Void _OnRequestRelogin()
  RVA=0x03D276A0  token=0x6000568  System.Boolean _CanQRLogin()
  RVA=0x02EAA1E0  token=0x6000569  System.Void _UpdateAnnounceRedDot()
  RVA=0x02D791F0  token=0x600056A  System.Void _UpdateServerZone()
  RVA=0x0577EBEC  token=0x600056B  System.Void _OnServerZoneBtnClicked()
  RVA=0x0577E50C  token=0x600056C  System.Void _OnFocusMenuGroup(System.Boolean isFocused)
  RVA=0x0577E3BC  token=0x600056D  System.Void _OnAnnounceClosed()
  RVA=0x02EAA260  token=0x600056E  System.Void _OnReceiveRedDotAndPopup(System.Boolean showRedDot)
  RVA=0x039DD5A0  token=0x600056F  System.Void _OnUpdateRedDotForSDKListener(Beyond.EventData<System.Boolean>& show)
  RVA=0x0577E5FC  token=0x6000570  System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input)
  RVA=0x03CDE0F0  token=0x6000571  System.Void .ctor()
  RVA=0x0577DDF4  token=0x6000572  System.Void <OnInit>b__28_0(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  RVA=0x0577DE80  token=0x6000573  System.Void <OnInit>b__28_1(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  RVA=0x0577DF0C  token=0x6000574  System.Void <OnInit>b__28_2(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  RVA=0x0577DF98  token=0x6000575  System.Void <OnInit>b__28_3(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  RVA=0x0577E024  token=0x6000576  System.Void <OnInit>b__28_4(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  RVA=0x0577E0B8  token=0x6000577  System.Void <OnInit>b__28_5(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0577E0C0  token=0x6000578  System.Void <OnInit>b__28_6(System.Boolean isFocused)
  RVA=0x0577E0D0  token=0x6000579  System.Void <_OnAnnounceClicked>b__37_0(System.String s)
  RVA=0x0577D3E8  token=0x600057A  System.Void <>iFixBaseProxy_OnInit()
  RVA=0x0577E0C8  token=0x600057B  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.Login.LoginMockUIDPanel
TYPE:  class
TOKEN: 0x20000FC
SIZE:  0x98
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.CanvasGroup         _canvas  // 0x18
  private           Beyond.UI.UIInputField          _userIdInputField  // 0x20
  private           Beyond.UI.UIButton              _btnEnterGame  // 0x28
  private           Beyond.UI.UIButton              _btnDelLocalFile  // 0x30
  private           Beyond.UI.UIDropdown            _serverDropdown  // 0x38
  private           UnityEngine.GameObject          _hintSelectServer  // 0x40
  private           Beyond.UI.UIButton              _btnClose  // 0x48
  private           Beyond.UI.UIText                _selectedServerLabel  // 0x50
  private           System.Boolean                  m_isInited  // 0x58
  private           Beyond.UI.UISwitchTween         m_switchTween  // 0x60
  private           System.Collections.Generic.List<Beyond.Network.ServerDesc>m_serverDescList  // 0x68
  private           Beyond.Network.ServerList       m_serverListObj  // 0x70
  private           Beyond.Network.ServerConfig     m_serverConfig  // 0x78
  private           System.Action<System.String>    m_callback  // 0x80
  private           Beyond.Login.LoginMockUIDPanel.FOptionsm_options  // 0x88
  private   static  Beyond.Login.LoginMockUIDPanel  s_instance  // static @ 0x0
PROPERTIES:
  instance  get=0x05788EC0
METHODS:
  RVA=0x03652EA0  token=0x6000580  System.Void LoginWithCallback(Beyond.Login.LoginMockUIDPanel.FOptions options, System.Action<System.String> callback)
  RVA=0x05788CC8  token=0x6000581  System.Void Refresh()
  RVA=0x03652DC0  token=0x6000582  System.Collections.IEnumerator HideAndDestroy()
  RVA=0x031594C0  token=0x6000583  System.Void _UpdateStatus()
  RVA=0x0315B0F0  token=0x6000584  System.Void _InitLoginInfo()
  RVA=0x0315B880  token=0x6000585  System.Void _SaveConfig()
  RVA=0x03CB7FC0  token=0x6000586  System.Void _OnBtnEnterGame()
  RVA=0x05788D6C  token=0x6000587  System.Void _SmokeEnterGame(System.String serverName, System.String uid)
  RVA=0x05788D28  token=0x6000588  System.Void _OnBtnDelLocalFile()
  RVA=0x05788E24  token=0x6000589  System.Void _TryClosePanel()
  RVA=0x0315B790  token=0x600058A  System.Void _OnSelectServer(System.Int32 index)
  RVA=0x03D1EE60  token=0x600058B  System.Void OnDestroy()
  RVA=0x0426FE60  token=0x600058C  System.Void .ctor()
  RVA=0x03CB7FB0  token=0x600058D  System.Void <_UpdateStatus>b__22_0(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x05788D18  token=0x600058E  System.Void <_UpdateStatus>b__22_1(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x05788D20  token=0x600058F  System.Void <_UpdateStatus>b__22_2(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x028E1300  token=0x6000590  System.Void <_InitLoginInfo>b__23_0(System.Int32 index, Beyond.UI.UIDropdownOption options, System.Boolean isSelected)
END_CLASS

CLASS: Beyond.Login.LoginResourcePanel
TYPE:  class
TOKEN: 0x20000FF
SIZE:  0x88
EXTENDS: ChildPanel
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private   static  System.Single                   PROGRESS_LERP_DURATION  // const
  private           UnityEngine.CanvasGroup         _alphaHandler  // 0x28
  private           Beyond.UI.UISlider              _progressBar  // 0x30
  private           Beyond.UI.UIText                _textTitle  // 0x38
  private           Beyond.UI.UIText                _textInfo  // 0x40
  private           Beyond.Login.LoginHotUpdateModel.IProgressm_progress  // 0x48
  private           Beyond.UI.TweenUtils.FLerpByTimem_progressLerper  // 0x50
  private           System.String                   m_resInfoCache  // 0x80
METHODS:
  RVA=0x02C3D280  token=0x6000598  System.Void OnValueChanged(Beyond.Login.LoginHotUpdateModel value)
  RVA=0x032F1390  token=0x6000599  System.Void _UpdateResourceInfo()
  RVA=0x032F1230  token=0x600059A  System.Void Update()
  RVA=0x0426FE60  token=0x600059B  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginRootPanel
TYPE:  class
TOKEN: 0x2000100
SIZE:  0x60
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.NotchAdapter          _notchAdapter  // 0x18
  private           Beyond.Login.LoginMenuPanel     _menuPanel  // 0x20
  private           Beyond.Login.LoginAgeTipsPanel  _ageTipsPanel  // 0x28
  private           Beyond.Login.LoginGovTipsPanel  _govTipsPanel  // 0x30
  private           Beyond.Login.LoginResourcePanel _resPanel  // 0x38
  private           Beyond.Login.LoginEnterGamePanel_enterGamePanel  // 0x40
  private           Beyond.Login.LoginServerSelectPanel_serverSelectPanel  // 0x48
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroup  // 0x50
  private           System.Int32                    m_loginRootBindingGroupId  // 0x58
METHODS:
  RVA=0x03197210  token=0x600059C  System.Void Awake()
  RVA=0x03197310  token=0x600059D  System.Void OnDestroy()
  RVA=0x02EA9240  token=0x600059E  System.Void Init(Beyond.LoginContext context)
  RVA=0x05788F8C  token=0x600059F  System.Void _OnNotchPaddingChanged(Beyond.EventData<System.Single>& data)
  RVA=0x02EA9F50  token=0x60005A0  System.Void _InitController()
  RVA=0x05788EF8  token=0x60005A1  System.Void ToggleLoginBindingGroup(System.Boolean enable)
  RVA=0x02EA9BA0  token=0x60005A2  System.Void InitBulletinAndRedAfterLoginSuc()
  RVA=0x02EA9330  token=0x60005A3  System.Void _InitChildPanel(Beyond.Login.LoginRootPanel.ChildPanel childPanel, Beyond.LoginContext context)
  RVA=0x0426FE60  token=0x60005A4  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectItemView
TYPE:  class
TOKEN: 0x2000102
SIZE:  0x68
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _serverName  // 0x18
  private           Beyond.UI.UIImage               _playerIcon  // 0x20
  private           Beyond.UI.UIText                _playerLevel  // 0x28
  private           Beyond.UI.UIImage[]             _delayImages  // 0x30
  private           Beyond.UI.UIText                _delayText  // 0x38
  private           Beyond.UI.UIButton              _btnSelect  // 0x40
  private           Beyond.UI.UIState.UIStateController_stateController  // 0x48
  private   static readonly UnityEngine.Color               DEFAULT_COLOR  // static @ 0x0
  private   static  System.String                   DEFAULT_TEXT  // const
  private   static readonly Beyond.Login.LoginServerSelectItemView.DelayInfoDEFAULT_SPEED_INFO  // static @ 0x10
  private           Beyond.Gameplay.ServerZoneManager.ServerZoneDatam_serverItem  // 0x50
  private           Beyond.LoginContext             m_context  // 0x58
  private           System.Collections.Generic.List<Beyond.Login.LoginServerSelectItemView.DelayInfo>m_speedInfos  // 0x60
METHODS:
  RVA=0x057890C0  token=0x60005AF  System.Void RefreshView(Beyond.LoginContext context, Beyond.Gameplay.ServerZoneManager.ServerZoneData serverItem, System.Boolean isSelected)
  RVA=0x05789030  token=0x60005B0  System.Void NaviToBtnTarget()
  RVA=0x057895C0  token=0x60005B1  System.Void SetSelected(System.Boolean isSelected)
  RVA=0x05789664  token=0x60005B2  System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x036D52B0  token=0x60005B3  System.Void .ctor()
  RVA=0x03C8A1C0  token=0x60005B4  System.Void .cctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectProp
TYPE:  class
TOKEN: 0x2000104
SIZE:  0x30
EXTENDS: Beyond.Login.LoginProperty`1
FIELDS:
METHODS:
  RVA=0x028D45F0  token=0x60005B5  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
END_CLASS

CLASS: Beyond.Login.LoginServerItem
TYPE:  class
TOKEN: 0x2000105
SIZE:  0x18
FIELDS:
  public            Beyond.Gameplay.ServerZoneManager.ServerZoneDataserverZoneData  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60005B6  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectModel
TYPE:  class
TOKEN: 0x2000106
SIZE:  0x18
FIELDS:
  public            System.Boolean                  showPanel  // 0x10
  public            System.Int32                    selectedIndex  // 0x14
PROPERTIES:
  serverList  get=0x05789910
  curServerZoneData  get=0x057898B8
METHODS:
  RVA=0x05789760  token=0x60005B9  System.Void InitData()
  RVA=0x057896DC  token=0x60005BA  Beyond.Gameplay.ServerZoneManager.ServerZoneData GetSelectedServer()
  RVA=0x057897C8  token=0x60005BB  System.Boolean UpdateSelectedServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData selectedServer)
  RVA=0x03D55820  token=0x60005BC  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectPanel
TYPE:  class
TOKEN: 0x2000107
SIZE:  0x68
EXTENDS: ChildPanel
IMPLEMENTS: Beyond.Login.ILoginBinder`1
FIELDS:
  private           Beyond.UI.UIButton              _btnBack  // 0x28
  private           Beyond.UI.UIButton              _btnConfirm  // 0x30
  private           Beyond.UI.UIAnimationWrapper    _showAnim  // 0x38
  private           Beyond.UI.UIScrollList          _showList  // 0x40
  private           Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x48
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroup  // 0x50
  private           Beyond.Input.InputBindingGroupMonoTarget_rootPanelBindingGroup  // 0x58
  private           Beyond.Login.LoginServerSelectModelm_viewModel  // 0x60
METHODS:
  RVA=0x03610600  token=0x60005BD  System.Void OnInit()
  RVA=0x057899A4  token=0x60005BE  System.Void OnDisable()
  RVA=0x05789AA8  token=0x60005BF  System.Void OnEnable()
  RVA=0x0578AA8C  token=0x60005C0  System.Collections.IEnumerator _WaitingForShowListAwake()
  RVA=0x0578A8C0  token=0x60005C1  System.Void _UpdateServerCell(UnityEngine.GameObject cell, System.Int32 index)
  RVA=0x0578A9CC  token=0x60005C2  System.Void _UpdateServerSelected(System.Int32 index, UnityEngine.GameObject cell)
  RVA=0x0578A4CC  token=0x60005C3  System.Void OnValueChanged(Beyond.Login.LoginServerSelectModel value)
  RVA=0x0578A624  token=0x60005C4  System.Void _NaviToSelectedItem()
  RVA=0x0578A85C  token=0x60005C5  System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input)
  RVA=0x0578A76C  token=0x60005C6  System.Void _OnCloseClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0578A7E4  token=0x60005C7  System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0426FE60  token=0x60005C8  System.Void .ctor()
  RVA=0x0577D3E8  token=0x60005C9  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginVersionPanel
TYPE:  class
TOKEN: 0x200010A
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _textVersion  // 0x18
PROPERTIES:
  displayGameVersion  get=0x0386CE50
  versionZoneType  get=0x0386D110
  versionPlatform  get=0x0386D020
  versionAppType  get=0x0386CFF0
  versionVersionNum  get=0x0386D090
  versionProjectCL  get=0x0386D050
METHODS:
  RVA=0x0386CDB0  token=0x60005D3  System.Void Start()
  RVA=0x0426FE60  token=0x60005DA  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginVocResSelDialog
TYPE:  class
TOKEN: 0x200010B
SIZE:  0x70
EXTENDS: Dialog
FIELDS:
  private           Beyond.Login.LoginVocResSelDialog.FParamsm_params  // 0x38
  private           Beyond.UI.UIButton              _btnConfirm  // 0x40
  private           Beyond.UI.UIScrollList          _showList  // 0x48
  private           Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x50
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroup  // 0x58
  private           System.Collections.Generic.List<Beyond.Login.LoginVocResSelDialog.VocResInfo>m_vocResInfos  // 0x60
  private           System.Int32                    m_selectedIndex  // 0x68
METHODS:
  RVA=0x0578AD28  token=0x60005DB  System.Void OnInit()
  RVA=0x0578AC20  token=0x60005DC  System.Void OnEnable()
  RVA=0x0578AB1C  token=0x60005DD  System.Void OnDisable()
  RVA=0x0578B0A8  token=0x60005DE  System.Void SetParams(Beyond.Login.LoginVocResSelDialog.FParams param)
  RVA=0x0578B10C  token=0x60005DF  System.Void UpdateSelected(Beyond.VFS.EVFSBlockType type)
  RVA=0x0578B6B0  token=0x60005E0  System.Void _UpdateList()
  RVA=0x0578B770  token=0x60005E1  System.Void _UpdateSelected(System.Int32 index, UnityEngine.GameObject cell)
  RVA=0x0578B5D0  token=0x60005E2  System.Void _UpdateCell(UnityEngine.GameObject cell, System.Int32 index)
  RVA=0x0578B4B8  token=0x60005E3  System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt)
  RVA=0x0578B330  token=0x60005E4  System.Void _OnConfirmClicked()
  RVA=0x0578B56C  token=0x60005E5  System.Void _OnInputTypeChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& data)
  RVA=0x0578B200  token=0x60005E6  System.Void _NaviToSelectedItem()
  RVA=0x0426FE60  token=0x60005E7  System.Void .ctor()
  RVA=0x0577D748  token=0x60005E8  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginVocResSelItemView
TYPE:  class
TOKEN: 0x200010E
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _name  // 0x18
  private           Beyond.UI.UIText                _size  // 0x20
  private           Beyond.UI.UIButton              _btnSelect  // 0x28
  private           Beyond.UI.UIState.UIStateController_stateController  // 0x30
  private           Beyond.Login.LoginVocResSelDialog.VocResInfom_info  // 0x38
  private           Beyond.Login.LoginVocResSelDialogm_context  // 0x40
  private   static  System.Double                   MB  // const
METHODS:
  RVA=0x0578B8B0  token=0x60005EA  System.Void RefreshView(Beyond.Login.LoginVocResSelDialog context, Beyond.Login.LoginVocResSelDialog.VocResInfo info, System.Boolean isSelected)
  RVA=0x0578B820  token=0x60005EB  System.Void NaviToBtnTarget()
  RVA=0x0578BB98  token=0x60005EC  System.Void SetSelected(System.Boolean isSelected)
  RVA=0x0578BC3C  token=0x60005ED  System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _)
  RVA=0x0426FE60  token=0x60005EE  System.Void .ctor()
END_CLASS

CLASS: Beyond.SDK.PlatformFont
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x10
IMPLEMENTS: Hypergryph.PlatformFacade.IPlatformFont
FIELDS:
  private   static  System.Int32                    DEFAULT_FONT_ID  // const
METHODS:
  RVA=0x0576EBF0  token=0x60001B6  TMPro.TMP_FontAsset GetFont()
  RVA=0x0350B670  token=0x60001B7  System.Void .ctor()
END_CLASS

CLASS: Beyond.SDK.SDKNetUtils
TYPE:  static class
TOKEN: 0x2000053
SIZE:  0x10
FIELDS:
  public    static  System.String                   CONTENT_TYPE_JSON  // const
  private   static  System.Int32                    GENERAL_TIMEOUT  // const
  private   static  Beyond.SDK.SDKNetUtils.HTTPImpl s_HTTPImpl  // static @ 0x0
METHODS:
  RVA=0x0576EDC4  token=0x60001B8  System.Void HTTPPost(Beyond.SDK.SDKNetUtils.HttpPostRequest request)
  RVA=0x0576EC6C  token=0x60001B9  System.Void HTTPGet(Beyond.SDK.SDKNetUtils.HttpGetRequest request)
  RVA=0x0576EFB0  token=0x60001BA  System.Void .cctor()
END_CLASS

CLASS: Beyond.SDK.SDKTextDefines
TYPE:  static class
TOKEN: 0x200005C
SIZE:  0x10
FIELDS:
  public    static  System.String                   CS_SDK_STO_DESC  // const
  public    static  System.String                   CS_SDK_COMMON_ERROR  // const
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR  // const
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT  // const
  public    static  System.String                   CS_SDK_USR_BAN  // const
  public    static  System.String                   CS_SDK_USR_BAN_TIME  // const
  public    static  System.String                   CS_SDK_LOGIN_FORBID  // const
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT  // const
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR  // const
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID  // const
METHODS:
END_CLASS

CLASS: Beyond.SDK.Impl.U8ExternalTools
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x28
EXTENDS: U8.SDK.SDKExternalToolsShortcut
FIELDS:
  private   static  System.Boolean                  s_inited  // static @ 0x0
  private   static  System.Boolean                  s_initing  // static @ 0x1
  private   static  System.Boolean                  s_needRetry  // static @ 0x2
  private   static  System.Boolean                  s_needQuitGame  // static @ 0x3
  private   static  Beyond.SDK.Impl.U8ExternalTools.FHGSDKInits_initHGSDK  // static @ 0x4
METHODS:
  RVA=0x05770CB8  token=0x60001C5  System.Boolean IsInited()
  RVA=0x02D77A20  token=0x60001C6  System.Boolean NeedRetryInit()
  RVA=0x03A94040  token=0x60001C7  System.Boolean NeedQuitGame()
  RVA=0x05771098  token=0x60001C8  System.Void RetryInitSDKSystem(System.String env)
  RVA=0x03CF20E0  token=0x60001C9  System.Void PublicSetGameVersion(System.String version)
  RVA=0x038E3210  token=0x60001CA  System.Void InitSDKSystem(System.String env)
  RVA=0x03A93FE0  token=0x60001CB  System.Collections.IEnumerator WaitForInited()
  RVA=0x02D78AA0  token=0x60001CC  System.Void InitHGSDK(System.String env)
  RVA=0x05770C4C  token=0x60001CD  System.Boolean IsHGSDKInited()
  RVA=0x02954F30  token=0x60001CE  System.Collections.IEnumerator WaitForInitHGSDK()
  RVA=0x05770E04  token=0x60001CF  System.Void Log(System.String content)
  RVA=0x05770D24  token=0x60001D0  System.Void LogError(System.String content)
  RVA=0x05770DB0  token=0x60001D1  System.Void LogWarning(System.String content)
  RVA=0x05770BE0  token=0x60001D2  System.String GetSignKey()
  RVA=0x05770874  token=0x60001D3  System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs()
  RVA=0x05771138  token=0x60001D4  System.Void SetSubChannel(System.String subChannel)
  RVA=0x05770B68  token=0x60001D5  System.Int32 GetPlatformKey()
  RVA=0x026922A0  token=0x60001D6  System.Void OnSDKExtraInfo(System.String jsonData)
  RVA=0x057711A4  token=0x60001D7  System.String U8RootUrl()
  RVA=0x05770E58  token=0x60001D8  System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback)
  RVA=0x05771234  token=0x60001D9  U8.SDK.SDKExternalTools.POSTResult _ConvertToPOSTResult(Beyond.SDK.SDKNetUtils.WebHttpResponse response)
  RVA=0x02692800  token=0x60001DA  System.Void _ProcessExtraInfo(U8.SDK.SDKExtraData extraData)
  RVA=0x05771720  token=0x60001DB  System.Void _OnRequestExitGame()
  RVA=0x057716E0  token=0x60001DC  System.Void _OnFakeAccountCenter()
  RVA=0x057707F8  token=0x60001DD  U8.SDK.SDKCaptchaHandler CreateCaptchaHandler()
  RVA=0x057709A8  token=0x60001DE  System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta)
  RVA=0x057714D8  token=0x60001DF  System.Boolean _ErrorMsg_GET_TOKEN(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg)
  RVA=0x05771338  token=0x60001E0  System.Boolean _ErrorMsg_CREATE_ORDER(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg)
  RVA=0x03D42B70  token=0x60001E1  System.Void .ctor()
  RVA=0x01002730  token=0x60001E2  System.String <>iFixBaseProxy_GetSignKey()
  RVA=0x0577119C  token=0x60001E3  System.Collections.Generic.Dictionary<System.String,System.String> <>iFixBaseProxy_GetDeviceIDs()
  RVA=0x0350B670  token=0x60001E4  System.Void <>iFixBaseProxy_OnSDKExtraInfo(System.String P0)
END_CLASS

CLASS: Beyond.SDK.Impl.U8Plugin
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x10
IMPLEMENTS: U8.SDK.IExternalPlugin
FIELDS:
METHODS:
  RVA=0x0577B938  token=0x6000201  System.String GetPayAddition()
  RVA=0x0577B984  token=0x6000202  System.String GetSDKToken()
  RVA=0x0577B9D0  token=0x6000203  System.String GetSDKUid()
  RVA=0x039CAD40  token=0x6000204  System.Void Init()
  RVA=0x02D775D0  token=0x6000205  System.Void Login(U8.SDK.ExternalPluginLoginParams args)
  RVA=0x0577BA1C  token=0x6000206  System.Void Logout(U8.SDK.ExternalPluginLogoutParams args)
  RVA=0x0577BAA4  token=0x6000207  System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  RVA=0x0577BAF8  token=0x6000208  System.Void Pay(U8.SDK.ExternalPluginPayParams args)
  RVA=0x0577BCDC  token=0x6000209  System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta)
  RVA=0x02D776A0  token=0x600020A  System.Boolean _UseMockVersion()
  RVA=0x02EA87D0  token=0x600020B  System.Void _MockLogin(U8.SDK.ExternalPluginLoginParams args)
  RVA=0x0350B670  token=0x600020C  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Entry.GameSettingSetter
TYPE:  static class
TOKEN: 0x200010F
SIZE:  0x10
FIELDS:
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioGlobalVolume>k__BackingField  // static @ 0x0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioMusicVolume>k__BackingField  // static @ 0x8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioVoiceVolume>k__BackingField  // static @ 0x10
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioSfxVolume>k__BackingField  // static @ 0x18
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioSuspendUnfocused>k__BackingField  // static @ 0x20
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioBackgroundMusic>k__BackingField  // static @ 0x28
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode><audioSuiteMode>k__BackingField  // static @ 0x30
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioController>k__BackingField  // static @ 0x38
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioSpatial>k__BackingField  // static @ 0x40
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerCameraSpeedX>k__BackingField  // static @ 0x48
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerCameraSpeedY>k__BackingField  // static @ 0x50
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerCameraTopViewSpeed>k__BackingField  // static @ 0x58
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerWalkRunRatio>k__BackingField  // static @ 0x60
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><cameraDistanceLevel>k__BackingField  // static @ 0x68
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel><cameraImpulseLevel>k__BackingField  // static @ 0x70
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerCameraReverseX>k__BackingField  // static @ 0x78
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerCameraReverseY>k__BackingField  // static @ 0x80
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget><controllerAutoLockTarget>k__BackingField  // static @ 0x88
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha><comboSkillCameraAlpha>k__BackingField  // static @ 0x90
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerAutoSprint>k__BackingField  // static @ 0x98
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerMotion>k__BackingField  // static @ 0xa0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerTriggerEffect>k__BackingField  // static @ 0xa8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><enableAutoAttackTouch>k__BackingField  // static @ 0xb0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><enableAutoAttackGamepad>k__BackingField  // static @ 0xb8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang><languageText>k__BackingField  // static @ 0xc0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio><languageAudio>k__BackingField  // static @ 0xc8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality><graphicsQuality>k__BackingField  // static @ 0xd0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><graphicsFullScreen>k__BackingField  // static @ 0xd8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32><graphicsResolution>k__BackingField  // static @ 0xe0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><graphicsNotchPadding>k__BackingField  // static @ 0xe8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><otherShowSmartAlert>k__BackingField  // static @ 0xf0
  public    static  System.Boolean                  s_stageInitFinished  // static @ 0xf8
PROPERTIES:
  audioGlobalVolume  get=0x057831D8  set=0x05783914
  audioMusicVolume  get=0x05783210  set=0x05783964
  audioVoiceVolume  get=0x05783328  set=0x05783B08
  audioSfxVolume  get=0x05783248  set=0x057839B8
  audioSuspendUnfocused  get=0x057832F0  set=0x05783AB4
  audioBackgroundMusic  get=0x05783168  set=0x0578386C
  audioSuiteMode  get=0x057832B8  set=0x05783A60
  audioController  get=0x057831A0  set=0x057838C0
  audioSpatial  get=0x05783280  set=0x05783A0C
  controllerCameraSpeedX  get=0x057834F8  set=0x05783DC4
  controllerCameraSpeedY  get=0x05783530  set=0x05783E18
  controllerCameraTopViewSpeed  get=0x05783568  set=0x05783E6C
  controllerWalkRunRatio  get=0x05783618  set=0x05783F78
  cameraDistanceLevel  get=0x05783360  set=0x05783B5C
  cameraImpulseLevel  get=0x05783398  set=0x05783BB0
  controllerCameraReverseX  get=0x05783484  set=0x05783D18
  controllerCameraReverseY  get=0x057834BC  set=0x05783D6C
  controllerAutoLockTarget  get=0x0578340C  set=0x05783C60
  comboSkillCameraAlpha  get=0x057833D0  set=0x05783C04
  controllerAutoSprint  get=0x05783448  set=0x05783CBC
  controllerMotion  get=0x057835A0  set=0x05783EC0
  controllerTriggerEffect  get=0x057835DC  set=0x05783F1C
  enableAutoAttackTouch  get=0x0578368C  set=0x05784028
  enableAutoAttackGamepad  get=0x05783650  set=0x05783FCC
  languageText  get=0x057837F4  set=0x05784250
  languageAudio  get=0x057837B8  set=0x057841F4
  graphicsQuality  get=0x05783740  set=0x0578413C
  graphicsFullScreen  get=0x057836C8  set=0x05784084
  graphicsResolution  get=0x0578377C  set=0x05784198
  graphicsNotchPadding  get=0x05783704  set=0x057840E0
  otherShowSmartAlert  get=0x05783830  set=0x057842AC
METHODS:
  RVA=0x02DF66E0  token=0x600062D  System.Void InitSetterItems()
  RVA=0x038BF640  token=0x600062E  System.Void _OnAudioGlobalVolumeChange(System.Single volume)
  RVA=0x038BF5D0  token=0x600062F  System.Void _OnAudioMusicVolumeChange(System.Single volume)
  RVA=0x038BF560  token=0x6000630  System.Void _OnAudioVoiceVolumeChange(System.Single volume)
  RVA=0x03D06600  token=0x6000631  System.Void _OnAudioSfxVolumeChange(System.Single volume)
  RVA=0x03CB7310  token=0x6000632  System.Void _OnAudioSuspendUnfocusedChange(System.Boolean suspendUnfocused)
  RVA=0x05782EC4  token=0x6000633  System.Void _OnAudioBackgroundMusicChange(System.Boolean enable)
  RVA=0x02EA2F10  token=0x6000634  System.Void _OnAudioSuiteModeChange(Beyond.GameSetting.GameSettingAudioSuiteMode mode)
  RVA=0x02A01010  token=0x6000635  System.Void _OnAudioControllerChange(System.Boolean enable)
  RVA=0x02A00FA0  token=0x6000636  System.Void _OnAudioSpatialAudioChange(System.Boolean enable)
  RVA=0x038BF490  token=0x6000637  System.Void _OnControllerCameraSpeedXChange(System.Single cameraSpeed)
  RVA=0x038BF3C0  token=0x6000638  System.Void _OnControllerCameraSpeedYChange(System.Single cameraSpeed)
  RVA=0x03CDCF60  token=0x6000639  System.Void _OnControllerCameraTopViewSpeedChange(System.Single cameraSpeed)
  RVA=0x038BF2F0  token=0x600063A  System.Void _OnControllerWalkRunRatioChange(System.Single walkRunRatio)
  RVA=0x03C7F390  token=0x600063B  System.Void _OnCameraDistanceLevelChange(System.Single distance)
  RVA=0x02952D20  token=0x600063C  System.Void _OnCameraImpulseLevelChange(Beyond.GameSetting.CameraImpulseLevel level)
  RVA=0x02A01390  token=0x600063D  System.Void _OnControllerCameraReverseXChange(System.Boolean isReverse)
  RVA=0x02A012F0  token=0x600063E  System.Void _OnControllerCameraReverseYChange(System.Boolean isReverse)
  RVA=0x02952C80  token=0x600063F  System.Void _OnControllerAutoLockTargetChange(Beyond.GameSetting.GameSettingControllerAutoLockTarget mode)
  RVA=0x02952BE0  token=0x6000640  System.Void _OnComboSkillCameraAlphaChange(Beyond.GameSetting.ComboSkillCameraAlpha alpha)
  RVA=0x05782F14  token=0x6000641  System.Void _OnControllerAutoSprintChange(System.Boolean valid)
  RVA=0x02A014D0  token=0x6000642  System.Void _OnControllerMotionChange(System.Boolean valid)
  RVA=0x02A01250  token=0x6000643  System.Void _OnControllerTriggerEffectChange(System.Boolean enable)
  RVA=0x05782FBC  token=0x6000644  System.Void _OnEnableAutoAttackTouchChange(System.Boolean enable)
  RVA=0x02A011B0  token=0x6000645  System.Void _OnEnableAutoAttackGamepadChange(System.Boolean enable)
  RVA=0x02954590  token=0x6000646  System.Void _OnLanguageTextChange(Beyond.GEnums.EnvLang language)
  RVA=0x02952DC0  token=0x6000647  System.Void _OnLanguageAudioChange(Beyond.GameSetting.GameSettingLanguageAudio language)
  RVA=0x057830EC  token=0x6000648  System.Void _OnGraphicsQualityChange(Beyond.GameSetting.GameSettingVideoQuality quality)
  RVA=0x05783064  token=0x6000649  System.Void _OnGraphicsFullScreenChanged(System.Boolean fullScreen)
  RVA=0x036366C0  token=0x600064A  System.Void _OnGraphicsResolutionChange(System.Int32 width, System.Int32 height)
  RVA=0x03637410  token=0x600064B  System.Void _SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullScreen)
  RVA=0x02E3B730  token=0x600064C  System.Void _OnGraphicsNotchPaddingChange(System.Single notchPadding)
  RVA=0x02A01110  token=0x600064D  System.Void _OnOtherShowSmartAlertChange(System.Boolean show)
END_CLASS

CLASS: Beyond.Scripts.Entry.WarmUpProgress
TYPE:  class
TOKEN: 0x2000112
SIZE:  0x10
IMPLEMENTS: IProgress
FIELDS:
METHODS:
  RVA=0x0578C380  token=0x6000653  System.Double GetTotal()
  RVA=0x0578C284  token=0x6000654  System.Double GetCurrent()
  RVA=0x0578C314  token=0x6000655  System.String GetInfo()
  RVA=0x0350B670  token=0x6000656  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x2000046
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_enableFastPathBuffer  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x6000191  System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity)
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000192  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000193  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  RVA=0x0350B670  token=0x6000194  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x200004A
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000195  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.SplashController
TYPE:  class
TOKEN: 0x200004B
SIZE:  0x80
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.String                   CURSOR_KEY_SPLASH  // const
  private   static  System.String                   SPLASH_RESOURCES_PATH  // const
  private           System.Single                   _initialFadeTime  // 0x18
  private           System.Single                   _regularFadeTime  // 0x1c
  private           System.Single                   _showTime  // 0x20
  private           UnityEngine.UI.Image            _blackCoverImage  // 0x28
  private           UnityEngine.UI.Image            _splashImage  // 0x30
  private           Beyond.UI.SplashController.SplashConfigs_splashConfigsCN  // 0x38
  private           Beyond.UI.SplashController.SplashConfigs_splashConfigsOS  // 0x50
  private           DG.Tweening.Sequence            m_tween  // 0x68
  private           System.Action                   m_onComplete  // 0x70
  private           System.Boolean                  m_skipLicense  // 0x78
  private   static  System.Boolean                  s_isPlaying  // static @ 0x0
  private           System.Boolean                  m_canBeHide  // 0x79
  private   static  Beyond.UI.SplashController      <instance>k__BackingField  // static @ 0x8
PROPERTIES:
  instance  get=0x0576F020  set=0x0576F090
  isPlaying  get=0x0576F058
METHODS:
  RVA=0x0229EA10  token=0x6000199  Beyond.UI.SplashController Show(System.Action onComplete, System.Boolean skipLicense)
  RVA=0x0229E930  token=0x600019A  System.Void Hide()
  RVA=0x0229E8A0  token=0x600019B  System.Void CanFinished()
  RVA=0x0229E570  token=0x600019C  System.Void Awake()
  RVA=0x0229E600  token=0x600019D  System.Void OnDestroy()
  RVA=0x02EA8B00  token=0x600019E  System.Void _Play(System.Action onComplete, System.Boolean skipLicense)
  RVA=0x03C81D30  token=0x600019F  System.Void _Stop()
  RVA=0x02EA8C10  token=0x60001A0  Beyond.UI.SplashController.SplashConfig[] _GetSplashConfigs()
  RVA=0x02D4CE30  token=0x60001A1  System.Void _DoStartSplash(Beyond.UI.SplashController.SplashConfig[] splashConfigs)
  RVA=0x03C7D880  token=0x60001A2  System.Void _OnTweenFinished()
  RVA=0x03C7D8E0  token=0x60001A3  System.Collections.IEnumerator _OnSplashCompleteCoroutine()
  RVA=0x0229E510  token=0x60001A4  System.Collections.IEnumerator _StartLicenseCoroutine()
  RVA=0x03D2D710  token=0x60001A5  System.Void .ctor()
  RVA=0x03D1B9E0  token=0x60001A6  System.Void <_DoStartSplash>b__31_1()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000115
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x6000657  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x0549D548  token=0x6000658  System.Void __Gen_Wrap_0(System.Object P0, Beyond.GameState P1)
  RVA=0x05784998  token=0x6000659  System.Void __Gen_Wrap_1(System.Single P0)
  RVA=0x0514F660  token=0x600065A  System.Void __Gen_Wrap_2(System.Boolean P0)
  RVA=0x0514E3FC  token=0x600065B  System.Void __Gen_Wrap_3(Beyond.GameSetting.GameSettingAudioSuiteMode P0)
  RVA=0x0514E3FC  token=0x600065C  System.Void __Gen_Wrap_4(Beyond.GameSetting.CameraImpulseLevel P0)
  RVA=0x0514E3FC  token=0x600065D  System.Void __Gen_Wrap_5(Beyond.GameSetting.GameSettingControllerAutoLockTarget P0)
  RVA=0x0514E3FC  token=0x600065E  System.Void __Gen_Wrap_6(Beyond.GameSetting.ComboSkillCameraAlpha P0)
  RVA=0x0514E3FC  token=0x600065F  System.Void __Gen_Wrap_7(Beyond.GEnums.EnvLang P0)
  RVA=0x0514E3FC  token=0x6000660  System.Void __Gen_Wrap_8(Beyond.GameSetting.GameSettingLanguageAudio P0)
  RVA=0x050EE9C4  token=0x6000661  System.Void __Gen_Wrap_9(Beyond.GameSetting.GameSettingVideoQuality P0)
  RVA=0x05784400  token=0x6000662  System.Void __Gen_Wrap_10(System.Int32 P0, System.Int32 P1, System.Boolean P2)
  RVA=0x056458FC  token=0x6000663  System.Void __Gen_Wrap_11(System.Int32 P0, System.Int32 P1)
  RVA=0x050F3444  token=0x6000664  System.Void __Gen_Wrap_12()
  RVA=0x04274234  token=0x6000665  System.Void __Gen_Wrap_13(System.Object P0)
  RVA=0x057844F8  token=0x6000666  Beyond.UI.SplashController.SplashConfig[] __Gen_Wrap_14(System.Object P0)
  RVA=0x057845D4  token=0x6000667  System.Collections.IEnumerator __Gen_Wrap_15(System.Object P0)
  RVA=0x05163BA0  token=0x6000668  System.Void __Gen_Wrap_16(System.Object P0, System.Object P1)
  RVA=0x057846C4  token=0x6000669  System.Void __Gen_Wrap_17(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x057847A8  token=0x600066A  Beyond.UI.SplashController __Gen_Wrap_18(System.Object P0, System.Boolean P1)
  RVA=0x057848A0  token=0x600066B  System.Void __Gen_Wrap_19(Beyond.EventData<System.Boolean,System.Boolean>& P0)
  RVA=0x05477860  token=0x600066C  System.Void __Gen_Wrap_20(System.Object P0, System.Boolean P1)
  RVA=0x0514E3FC  token=0x600066D  System.Void __Gen_Wrap_21(System.Int32 P0)
  RVA=0x05784A58  token=0x600066E  System.Boolean __Gen_Wrap_22(System.Object P0, Beyond.Resource.HotUpdate.LocalResPref& P1, Beyond.VFS.VirtualFileSystem.BlockValidator& P2)
  RVA=0x05784BE0  token=0x600066F  System.Void __Gen_Wrap_23(System.Object P0, Beyond.VFS.VirtualFileSystem.BlockValidator& P1)
  RVA=0x0514F380  token=0x6000670  System.Boolean __Gen_Wrap_24()
  RVA=0x0514EF5C  token=0x6000671  System.Boolean __Gen_Wrap_25(System.Object P0)
  RVA=0x05784D08  token=0x6000672  System.Void __Gen_Wrap_26(System.Object P0, Beyond.EventData<Beyond.DeviceInfo.InputType>& P1)
  RVA=0x05784E1C  token=0x6000673  Beyond.LoginController.MaskCtrl __Gen_Wrap_27(System.Object P0)
  RVA=0x05784F0C  token=0x6000674  Beyond.UI.UISwitchTween __Gen_Wrap_28(System.Object P0, System.Int32 P1)
  RVA=0x05785018  token=0x6000675  System.Collections.IEnumerator __Gen_Wrap_29(System.Object P0, System.Object P1)
  RVA=0x05785124  token=0x6000676  System.Void __Gen_Wrap_30(System.Object P0, System.Object P1, Beyond.LoginController.EMaskType P2, System.Boolean P3, System.Boolean P4)
  RVA=0x05785238  token=0x6000677  Beyond.UI.UIAnimationLayerMixPlayer __Gen_Wrap_31(System.Object P0)
  RVA=0x05785328  token=0x6000678  System.Void __Gen_Wrap_32(System.Object P0, Beyond.LoginController.FOptions P1)
  RVA=0x05785438  token=0x6000679  Beyond.Login.LoginWorkFlow.FWork __Gen_Wrap_33()
  RVA=0x0560DC74  token=0x600067A  System.Boolean __Gen_Wrap_34(Beyond.Login.LoginWorkFlow.ENode P0, Beyond.Login.LoginWorkFlow.ENode P1)
  RVA=0x0514DE88  token=0x600067B  System.Boolean __Gen_Wrap_35(Beyond.Login.LoginWorkFlow.ENode P0)
  RVA=0x0578552C  token=0x600067C  System.Collections.IEnumerator __Gen_Wrap_36(Beyond.Login.LoginWorkFlow.ENode P0)
  RVA=0x05785618  token=0x600067D  UnityEngine.CustomYieldInstruction __Gen_Wrap_37(System.Object P0)
  RVA=0x05785708  token=0x600067E  System.Boolean __Gen_Wrap_38(Beyond.Login.LoginWorkFlow.FWork& P0)
  RVA=0x0578585C  token=0x600067F  System.Void __Gen_Wrap_39(Beyond.Login.LoginWorkFlow.FWork& P0)
  RVA=0x057859A0  token=0x6000680  System.Void __Gen_Wrap_40(System.Object P0, Beyond.Login.LoginAlertDialog.FParams P1)
  RVA=0x05785AA0  token=0x6000681  System.Void __Gen_Wrap_41(System.Object P0, Beyond.Login.LoginVocResSelDialog.FParams P1)
  RVA=0x05785BA0  token=0x6000682  System.Void __Gen_Wrap_42(System.Object P0, Beyond.Login.LoginJudgeDialog.FParams P1)
  RVA=0x05785CC4  token=0x6000683  System.Void __Gen_Wrap_43(Beyond.Login.LoginAlertDialog P0, Beyond.Login.LoginAlertDialog.FParams P1)
  RVA=0x05150B1C  token=0x6000684  System.Void __Gen_Wrap_44(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x05785DC4  token=0x6000685  System.Void __Gen_Wrap_45(System.Object P0, System.Boolean P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7, System.Object P8)
  RVA=0x05785F1C  token=0x6000686  System.Collections.IEnumerator __Gen_Wrap_46(System.Object P0, System.Boolean P1)
  RVA=0x05786028  token=0x6000687  System.Boolean __Gen_Wrap_47(System.Object P0, Beyond.Login.LoginWorkFlow.ENode& P1)
  RVA=0x0514E3FC  token=0x6000688  System.Void __Gen_Wrap_48(Beyond.GameState P0)
  RVA=0x050F0008  token=0x6000689  System.Void __Gen_Wrap_49(System.Object P0, System.Single P1)
  RVA=0x054AB08C  token=0x600068A  System.Single __Gen_Wrap_50(System.Object P0)
  RVA=0x05786134  token=0x600068B  Beyond.LoginController __Gen_Wrap_51(System.Object P0)
  RVA=0x05625660  token=0x600068C  System.Void __Gen_Wrap_52(System.Object P0, System.Object P1, System.Single P2)
  RVA=0x05786224  token=0x600068D  System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> __Gen_Wrap_53(System.Object P0)
  RVA=0x05153920  token=0x600068E  System.Boolean __Gen_Wrap_54(System.Object P0, System.Object P1)
  RVA=0x05786314  token=0x600068F  Beyond.Gameplay.ServerZoneManager.ServerZoneData __Gen_Wrap_55(System.Object P0)
  RVA=0x05786404  token=0x6000690  System.Boolean __Gen_Wrap_56(System.Object P0, Beyond.ELoginEvent P1, System.Object P2)
  RVA=0x0514F720  token=0x6000691  System.Void __Gen_Wrap_57(System.Object P0, Beyond.ELoginEvent P1, System.Object P2)
  RVA=0x050EE850  token=0x6000692  System.Void __Gen_Wrap_58(System.String P0)
  RVA=0x050EE850  token=0x6000693  System.Void __Gen_Wrap_59(UnityEngine.EventSystems.PointerEventData P0)
  RVA=0x05786508  token=0x6000694  System.Boolean __Gen_Wrap_60(Beyond.Login.LoginMockUIDPanel.FOptions& P0)
  RVA=0x050F1438  token=0x6000695  System.Void __Gen_Wrap_61(System.Int32 P0, Beyond.UI.UIDropdownOption P1, System.Boolean P2)
  RVA=0x0549D548  token=0x6000696  System.Void __Gen_Wrap_62(System.Object P0, System.Int32 P1)
  RVA=0x05786654  token=0x6000697  System.Void __Gen_Wrap_63(System.Object P0, Beyond.Login.LoginMockUIDPanel.FOptions P1, System.Object P2)
  RVA=0x05786780  token=0x6000698  Beyond.UI.UISwitchTween __Gen_Wrap_64(System.Object P0)
  RVA=0x0548C780  token=0x6000699  System.Boolean __Gen_Wrap_65(System.Object P0, Beyond.LoginController.EMaskType P1)
  RVA=0x05786870  token=0x600069A  System.Void __Gen_Wrap_66(Beyond.Login.LoginVocResSelDialog P0, Beyond.Login.LoginVocResSelDialog.FParams P1)
  RVA=0x05786970  token=0x600069B  System.Collections.IEnumerator __Gen_Wrap_67(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  RVA=0x05786AA8  token=0x600069C  System.Void __Gen_Wrap_68(Beyond.Login.LoginJudgeDialog P0, Beyond.Login.LoginJudgeDialog.FParams P1)
  RVA=0x05496D84  token=0x600069D  System.Void __Gen_Wrap_69(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  RVA=0x05786BB8  token=0x600069E  System.String __Gen_Wrap_70(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x05786CE0  token=0x600069F  System.Void __Gen_Wrap_71(System.Boolean& P0)
  RVA=0x05786DB4  token=0x60006A0  System.Void __Gen_Wrap_72(System.Object P0, System.Boolean& P1)
  RVA=0x05786EA4  token=0x60006A1  System.Void __Gen_Wrap_73(System.Object P0, Beyond.LoginManager.FFlowWithMask P1)
  RVA=0x05786FC8  token=0x60006A2  System.Boolean __Gen_Wrap_74(Beyond.LoginManager.FFlowCondition& P0, Beyond.Login.LoginWorkFlow.ENode P1)
  RVA=0x0578711C  token=0x60006A3  System.Collections.IEnumerator __Gen_Wrap_75(System.Object P0, Beyond.LoginManager.FFlowWithMask P1)
  RVA=0x0578725C  token=0x60006A4  TMPro.TMP_FontAsset __Gen_Wrap_76(System.Object P0)
  RVA=0x05787338  token=0x60006A5  System.Void __Gen_Wrap_77(Beyond.SDK.SDKNetUtils.HttpPostRequest P0)
  RVA=0x0578742C  token=0x60006A6  System.Void __Gen_Wrap_78(Beyond.SDK.SDKNetUtils.HttpGetRequest P0)
  RVA=0x05787510  token=0x60006A7  System.Collections.IEnumerator __Gen_Wrap_79(System.Object P0, Beyond.SDK.SDKNetUtils.HTTPConfig P1)
  RVA=0x05787640  token=0x60006A8  System.Collections.IEnumerator __Gen_Wrap_80()
  RVA=0x0578770C  token=0x60006A9  System.String __Gen_Wrap_81(System.Object P0)
  RVA=0x057877FC  token=0x60006AA  System.Collections.Generic.Dictionary<System.String,System.String> __Gen_Wrap_82(System.Object P0)
  RVA=0x050EF614  token=0x60006AB  System.Int32 __Gen_Wrap_83(System.Object P0)
  RVA=0x057878D8  token=0x60006AC  System.Void __Gen_Wrap_84(System.Object P0, U8.SDK.SDKExtraData P1)
  RVA=0x057879EC  token=0x60006AD  U8.SDK.SDKExternalTools.POSTResult __Gen_Wrap_85(Beyond.SDK.SDKNetUtils.WebHttpResponse P0)
  RVA=0x05787B24  token=0x60006AE  System.Void __Gen_Wrap_86(Beyond.SDK.SDKNetUtils.WebHttpResponse P0)
  RVA=0x05787C18  token=0x60006AF  System.Void __Gen_Wrap_87(System.Object P0, U8.SDK.SDKExternalTools.POSTRequest P1, System.Object P2)
  RVA=0x05787D3C  token=0x60006B0  U8.SDK.SDKCaptchaHandler __Gen_Wrap_88(System.Object P0)
  RVA=0x05787E18  token=0x60006B1  System.Boolean __Gen_Wrap_89(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1, System.String& P2)
  RVA=0x05787F84  token=0x60006B2  System.String __Gen_Wrap_90(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1)
  RVA=0x057880AC  token=0x60006B3  System.Collections.IEnumerator __Gen_Wrap_91(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x057881C0  token=0x60006B4  System.Void __Gen_Wrap_92(System.Object P0, U8.SDK.ExternalPluginLoginParams P1)
  RVA=0x057882E4  token=0x60006B5  System.Void __Gen_Wrap_93(System.Object P0, U8.SDK.ExternalPluginLogoutParams P1)
  RVA=0x057883EC  token=0x60006B6  System.Void __Gen_Wrap_94(U8.SDK.U8PayResult P0)
  RVA=0x057884D8  token=0x60006B7  System.Void __Gen_Wrap_95(System.Object P0, U8.SDK.ExternalPluginPayParams P1)
  RVA=0x057885E0  token=0x60006B8  System.Boolean __Gen_Wrap_96(System.Object P0, System.Object P1, U8.SDK.SDKMeta& P2)
  RVA=0x05788730  token=0x60006B9  System.Void __Gen_Wrap_97(Beyond.Login.LoginWorkFlow.FWork& P0, System.Int32 P1)
  RVA=0x0578888C  token=0x60006BA  System.Boolean __Gen_Wrap_98(System.Object P0, Beyond.Login.LoginWorkFlow.ENode P1, System.Boolean P2)
  RVA=0x05788990  token=0x60006BB  Beyond.SDK.HGDownloader.DownloadProgress __Gen_Wrap_99(System.Object P0)
  RVA=0x05477F10  token=0x60006BC  Beyond.SDK.HGDownloader.WorkState __Gen_Wrap_100(System.Object P0)
  RVA=0x05784308  token=0x60006BD  System.Collections.Generic.List<Beyond.SDK.HGFileInfo> __Gen_Wrap_101(System.Object P0, System.Object P1)
  RVA=0x0104E7F0  token=0x60006BE  System.Collections.Generic.List<Beyond.SDK.HGFolder> __Gen_Wrap_102(System.Object P0, System.Object P1)
  RVA=0x0104F210  token=0x60006BF  System.Boolean __Gen_Wrap_103(System.Object P0, Beyond.SDK.HGRetCodeType P1, System.Int32 P2)
  RVA=0x0104F510  token=0x60006C0  System.String __Gen_Wrap_104(System.Double P0)
  RVA=0x0104FD90  token=0x60006C1  System.Void __Gen_Wrap_105(System.Object P0, System.Int64 P1, System.Object P2, System.Object P3, System.Object P4)
  RVA=0x010502C0  token=0x60006C2  System.Void __Gen_Wrap_106(System.Object P0, Beyond.SDK.HGDownloader.PauseReason P1)
  RVA=0x01050590  token=0x60006C3  System.Collections.IEnumerator __Gen_Wrap_107(System.Object P0, System.Int64 P1)
  RVA=0x01050F30  token=0x60006C4  System.Void __Gen_Wrap_108(System.Object P0, System.Int64 P1, System.Int64 P2, System.Int64 P3)
  RVA=0x01051240  token=0x60006C5  System.Double __Gen_Wrap_109(System.Object P0)
  RVA=0x01051500  token=0x60006C6  System.Boolean __Gen_Wrap_110(System.Boolean P0)
  RVA=0x01051700  token=0x60006C7  System.String __Gen_Wrap_111(System.Object P0, System.Boolean P1)
  RVA=0x010520A0  token=0x60006C8  Beyond.Resource.HotUpdate.LocalResPref __Gen_Wrap_112()
  RVA=0x010528E0  token=0x60006C9  Beyond.Login.LoginHotUpdater.HotUpdateInfo __Gen_Wrap_113(System.Object P0, System.Boolean P1)
  RVA=0x01053280  token=0x60006CA  Beyond.Resource.HotUpdate.ResourceIndex __Gen_Wrap_114()
  RVA=0x01053AC0  token=0x60006CB  System.String __Gen_Wrap_115(System.Object P0, System.Object P1, System.Boolean P2)
  RVA=0x01054510  token=0x60006CC  System.Object __Gen_Wrap_116()
  RVA=0x01054D50  token=0x60006CD  System.Collections.IEnumerator __Gen_Wrap_117(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3)
  RVA=0x01055870  token=0x60006CE  System.Collections.IEnumerator __Gen_Wrap_118(System.Boolean P0, System.Object P1, System.Object P2)
  RVA=0x010562B0  token=0x60006CF  Beyond.Resource.HotUpdate.LocalResPref __Gen_Wrap_119(System.Object P0, System.Boolean P1, System.Object P2, Beyond.Resource.HotUpdate.FResourceDiff P3, System.Int32& P4)
  RVA=0x01057010  token=0x60006D0  System.Void __Gen_Wrap_120(System.Object P0, System.Boolean& P1, System.Double P2, System.Double P3, System.Int32 P4, System.Boolean P5)
  RVA=0x01057380  token=0x60006D1  System.Boolean __Gen_Wrap_121(System.Object P0, Beyond.VFS.EVFSBlockType P1)
  RVA=0x01057670  token=0x60006D2  System.Collections.IEnumerator __Gen_Wrap_122(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3)
  RVA=0x010580E0  token=0x60006D3  Beyond.Login.LoginHotUpdater __Gen_Wrap_123(System.Object P0, System.Boolean P1)
  RVA=0x01058A40  token=0x60006D4  Beyond.Login.LoginProgress.FDownloadSize.EUnit __Gen_Wrap_124(System.Double P0)
  RVA=0x01058C40  token=0x60006D5  System.Single __Gen_Wrap_125(System.Double P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1)
  RVA=0x01058E70  token=0x60006D6  System.String __Gen_Wrap_126(System.Single P0, System.Single P1, Beyond.Login.LoginProgress.FDownloadSize.EUnit P2)
  RVA=0x01059760  token=0x60006D7  System.String __Gen_Wrap_127(System.Single P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1)
  RVA=0x0105A010  token=0x60006D8  System.String __Gen_Wrap_128(System.Single P0, System.Single P1)
  RVA=0x0105A8E0  token=0x60006D9  System.Void __Gen_Wrap_129(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2, System.Double P3)
  RVA=0x0105B5B0  token=0x60006DA  System.Void __Gen_Wrap_130(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2)
  RVA=0x0105C260  token=0x60006DB  System.Void __Gen_Wrap_131(Beyond.Login.LoginProgress.FDownloadSize& P0)
  RVA=0x0105CE70  token=0x60006DC  System.Void __Gen_Wrap_132(Hypergryph.SpeedTest.SpeedTestResult P0)
  RVA=0x0105D130  token=0x60006DD  System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_133()
  RVA=0x0105D970  token=0x60006DE  Beyond.Login.LoginViewModel.FAgeTipsPolicy __Gen_Wrap_134()
  RVA=0x0105E180  token=0x60006DF  Beyond.Login.LoginWorkFlow.Node[] __Gen_Wrap_135(System.Object P0)
  RVA=0x0105EAC0  token=0x60006E0  System.Single __Gen_Wrap_136(System.Object P0, System.Boolean& P1)
  RVA=0x0105EDE0  token=0x60006E1  Beyond.UI.UIAnimationMixPlayer __Gen_Wrap_137(System.Object P0)
  RVA=0x0105F720  token=0x60006E2  System.Void __Gen_Wrap_138(System.Object P0, Beyond.Login.LoginSceneAnimCtrl.EState P1)
  RVA=0x0105FA00  token=0x60006E3  System.Collections.Generic.List<System.String> __Gen_Wrap_139(System.Object P0)
  RVA=0x01060340  token=0x60006E4  System.Void __Gen_Wrap_140(System.Object P0, Beyond.Login.LoginViewModel.FAgeTipsPolicy P1)
  RVA=0x010609D0  token=0x60006E5  System.Void __Gen_Wrap_141(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3)
  RVA=0x01060DB0  token=0x60006E6  System.Void __Gen_Wrap_142(System.Boolean P0, System.Boolean P1, System.Boolean P2)
  RVA=0x01060FE0  token=0x60006E7  System.Void __Gen_Wrap_143(System.Object P0, Beyond.EventData<System.Boolean>& P1)
  RVA=0x01061680  token=0x60006E8  System.Void __Gen_Wrap_144(System.Object P0, Beyond.EventData<System.Single>& P1)
  RVA=0x01061D10  token=0x60006E9  System.Void __Gen_Wrap_145(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3)
  RVA=0x01062180  token=0x60006EA  System.Void __Gen_Wrap_146(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x01062520  token=0x60006EB  System.Void __Gen_Wrap_147(System.Object P0, System.Int32 P1, System.Object P2)
  RVA=0x010628B0  token=0x60006EC  System.Void __Gen_Wrap_148(System.Object P0, Beyond.VFS.EVFSBlockType P1)
  RVA=0x03D05E20  token=0x60006ED  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000116
SIZE:  0x58
EXTENDS: IFix.Core.AnonymousStorey
IMPLEMENTS: System.IDisposable System.Collections.IEnumerator System.Collections.Generic.IEnumerator`1
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4c
  private           System.Int32                    methodId_4  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x05788A94
  System.Collections.IEnumerator.Current  get=0x05788B40
METHODS:
  RVA=0x05152EA8  token=0x60006EE  System.Void System.IDisposable.Dispose()
  RVA=0x05152C48  token=0x60006EF  System.Boolean MoveNext()
  RVA=0x05152D80  token=0x60006F1  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x05788BEC  token=0x60006F3  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0350B670  token=0x60006F4  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000117
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60006F5  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0578C5F0  token=0x60006F6  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x0262E590  token=0x60006F7  System.Boolean IsPatched(System.Int32 id)
  RVA=0x0578C4AC  token=0x60006F8  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x0578C578  token=0x60006F9  System.Object CreateWrapper(System.Int32 id)
  RVA=0x0578C654  token=0x60006FA  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x0578C408  token=0x60006FB  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x2000118
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-GameApp-SwitchState0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedXChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedYChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraTopViewSpeedChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerWalkRunRatioChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnCameraDistanceLevelChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnCameraImpulseLevelChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseXChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseYChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoLockTargetChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnComboSkillCameraAlphaChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoSprintChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerTriggerEffectChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackTouchChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackGamepadChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsQualityChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_SetResolution0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsFullScreenChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsResolutionChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsNotchPaddingChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnOtherShowSmartAlertChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-InitSetterItems0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_PreInitGameSetting0  // const
  public    static  IFix.IDMAP0                     Beyond-RenderPipelineDataLoader-LoadSimpleRpData0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_GetSplashConfigs0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-PublicSetGameVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_StartLicenseCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_Stop0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-Hide0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_OnSplashCompleteCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_OnTweenFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_DoStartSplash0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_Play0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-Show0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_FetchRemoteConfigUtilSuc0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_InitSecuritySDK0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_InitGameStateMachine0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnApplicationFocusForLua0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnApplicationPauseForLua0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_RegisterLuaAfterGCEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnSystemDisplaySizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnSystemScreenSizeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_Init0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-LateUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnApplicationQuit0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnApplicationFocus0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnApplicationPauseForSecurity0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnApplicationPause0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_UnInitGameStateMachine0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-_UnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-QuitGame0  // const
  public    static  IFix.IDMAP0                     Beyond-GameApp-RefreshScreenResolution0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStateBase-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_InitAPPDefaultCulture0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_InitInitialResourceManager0  // const
  public    static  IFix.IDMAP0                     Beyond-RenderPipelineDataLoader-PreloadFullRpResources0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-_UnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-_Init0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_InitGameSetting0  // const
  public    static  IFix.IDMAP0                     Beyond-RenderPipelineDataLoader-IsPreLoadFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_DoInit0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStateBase-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-GameInitState-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-CanFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-RenderPipelineDataLoader-LoadFullRpResources0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-IsDisposed0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-IsWorkflowInProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-OnDispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EnableCursor0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_UpdateCursor0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AssetLoader-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-_DisposeImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-get_maskCtrl0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-_GetMaskByType0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-BeforeDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-_DisposeCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-IsWorkflowDisposed0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-EnableMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-_InitController0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-_InitChildPanel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_ToggleGlow0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-OnLoginContext0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-_InitVersionBtn0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-_InitCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-_InitImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-InitUI0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-IsBeforeWork0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-SetCurNode0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-_InternalTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-Cancel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-IsNeedSoftRestart0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-WorkEnd0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-DoWorkFlow0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_LoginWorkFlowCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_PrepareBeforeLoginProcess0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAlertDialog-SetParams0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-SetParams0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-SetParams0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-StartCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AlertDialog0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-InvokeWhenStart0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_Init0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-InitCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-GameLoginState-_TryStartLoginWorkflow0  // const
  public    static  IFix.IDMAP0                     Beyond-GameLoginState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-GameLoginState-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-ShutDown0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ClearWorkflowAndContext0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ReleaseLoginScene0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-GameMainState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-IsAfterWork0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-PeekFallbackStatus0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-IsReLoginInProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-OnReleaseMainGame0  // const
  public    static  IFix.IDMAP0                     Beyond-GameMainState-_ClearUtils0  // const
  public    static  IFix.IDMAP0                     Beyond-GameMainState-ReleaseMainGame0  // const
  public    static  IFix.IDMAP0                     Beyond-GameMainState-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-_InitGameSettingStateInPreload0  // const
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-_DoPreload0  // const
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-UnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-GameQuitState-DoQuit0  // const
  public    static  IFix.IDMAP0                     Beyond-GameQuitState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-GameQuitState-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-ClearSync0  // const
  public    static  IFix.IDMAP0                     Beyond-GameSoftRestartState-_SoftRestart0  // const
  public    static  IFix.IDMAP0                     Beyond-GameSoftRestartState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-InvokeWhenWorkFlowFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStartState-_OnEnterMainGame0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStartState-OnEnter0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStartState-OnLeave0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStateBase-OnTick0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStateMachine-_RegisterStates0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStateMachine-CheckCanReturnToLoginState0  // const
  public    static  IFix.IDMAP0                     Beyond-GameStateMachine-ReturnToLoginState0  // const
  public    static  IFix.IDMAP0                     Beyond-GlobalInitializer-InitGlobalConfig0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-GetEnterGamePanelPredelay0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsModel-IsContentEmpty0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-ViewOnlyController0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-EnableNetMask0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-DisableNetMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-get_serverList0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnSelectServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-GetSelectedServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-OnEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-SendEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_SaveConfig0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_TryClosePanel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_OnSelectServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_UpdateStatus0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-LoginWithCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-HideAndDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-_MockLoginCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MockLoginWithCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-_CloseCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-TryCloseWithCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-Show0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCfg-CreateTweenAndHide0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-IsMaskTweening0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-StopCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginContext-SendEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneComponent-OnBindToManager0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneComponent-Bind0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_BindPendingComponents0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-SceneComponentOnly_Bind0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-ToggleLoginBindingGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-VocResSelDialog0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-VocResSelDialogWithConfirm0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AlertDialogWithResult0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AlertDialogWithConfirm0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_StartShowJudgeDialogCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-JudgeDialog0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-JudgeDialog1  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-MockLoginWithCallback0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-MockManualSelectServer0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-IsLoginSceneLoading0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ExtractErrorInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FetchRemoteConfigUtilSuc0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-DevOnlyUseLocalResVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FFlowCondition-IsTargetMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FlowWithMaskMgr-StartFlow0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-OnApplicationQuit0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0  // const
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-TailGameLoop-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-TailGameLoop-LateUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-PlatformFont-GetFont0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-SDKNetUtils-HTTPPost0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-SDKNetUtils-HTTPGet0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-IsInited0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-WaitForInited0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-Log0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-LogError0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-LogWarning0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetSignKey0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-GetPayAddition0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-GetSDKToken0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-GetSDKUid0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-_UseMockVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-_MockLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Login0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Logout0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-OnProductListChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Pay0  // const
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-Clear0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-ShowWaitProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-GetWaitTime0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-ClearWaitProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-GetNoAlertCode0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_GetLastGameInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-CheckLastGameInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-MarkFallback0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Fallback0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-OnDispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-CanCancel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-GetDownloadProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-GetDecompressProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-GetWorkState0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_GetFileList0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_GetAllFileList0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_OnDownloadFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_OnDownloadError0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_OnDownloadPaused0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_StartDownloadImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_StartDownload0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdateNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_YieldErrorAlert0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_OnDownloadStart0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_OnDownloadProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_DoTaskUpdating0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_UpdateGame0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-DoUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_LogoutToInitNode0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_FallbackToInitWithMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_ConfirmServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_OnEventLogout0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-RequestResourceRepair0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_OnEventResourceRepair0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-OnEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-NeedClearFolder0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkClearSuccessed0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkSoftRestart0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-ClearSoftRestartFlag0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginLocalResTask-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_UpdateResVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_SetResVersionForLog0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CurrentWorkMode0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-ResourceRootUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GenResIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourceFileUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GenRiff0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CreateUpdatedLocalResPref0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GenLocalRef0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginLocalResTask-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-RequestSkipU8Login0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_VitalError0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-StartHotUpdate0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-GetCurrent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-GetTotal0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-SetSize0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-SetProgress0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-SetIdle0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-GetInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-_YieldAlertError0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-_InitRemoteConfigs0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-_InitCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_WarmUp0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_OnGetServerListSuc0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_GetServerListInfoMock0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_OnGetServerListFail0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_GetServerListInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_GetServerList0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_EnterPreLoad0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_LoginPreLoad0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-_InitSubSDKs0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_ClearLoginCaches0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_EnableBlurMask0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnSDKViewDisabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnBulletinOpen0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnBulletinClose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnLoginSuc0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_SkipSDKLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnLoginCanceled0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnLoginFail0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_StartSDKLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_FinishLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_LoginCoroutine0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-OnEvent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-IsAgeTipsVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-IsGovTipsVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-IsMenuVisible0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsModel-CanDisplay0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsProp-ClearContentCache0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsProp-UpdateContent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_RegisterNodes0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-CanCancel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-Cancel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-CancelAndFallback0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-AddEventReceiver0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-UpdateOnce0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-HotUpdateNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-HotUpdateNode-OnDispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-_NotifyTimeout0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-_IsTimeout0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-_DisposeTimer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-OnDispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadPostDelayNode-WaitForSeconds0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadPostDelayNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-Trans2GsLoginNode-WaitForSeconds0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-Trans2GsLoginNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-FinishNode-Work0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_ResetToA10  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneComponent-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneRoot-OnBindToManager0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAlertDialog-_OnConfirmClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAlertDialog-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_TimeManagerTick0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-Tick0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-OnRelease0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginEnterGamePanel-_InitIfNot0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginEnterGamePanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGovTipsPanel-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGovTipsPanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnSettingClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnResCheckClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnLogoutClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnLoginClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnQRClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_CanQRLogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_UpdateServerZone0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnRequestRelogin0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnInputChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-Refresh0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginResourcePanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginResourcePanel-Update0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-Awake0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-OnDestroy0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-_OnClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-RefreshView0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-SetSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-InitData0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_OnInputChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_WaitingForShowListAwake0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnValueChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVersionPanel-get_displayGameVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVersionPanel-Start0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-SetSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_UpdateSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_UpdateList0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-UpdateSelected0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-_OnClicked0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-RefreshView0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_UpdateCell0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-OnInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-OnEnable0  // const
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-OnDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-WarmUpProgress-GetTotal0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-WarmUpProgress-GetInfo0  // const
METHODS:
END_CLASS

