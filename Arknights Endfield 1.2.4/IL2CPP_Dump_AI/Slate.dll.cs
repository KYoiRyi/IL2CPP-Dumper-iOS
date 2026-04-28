// ========================================================
// Dumped by @desirepro
// Assembly: Slate.dll
// Classes:  273
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

CLASS: SubtitlesGUIDelegate
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09687D1C  token=0x6000049  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x029CE1E0  token=0x600004A  System.Void Invoke(System.String text, UnityEngine.Color color)
  RVA=0x09687C94  token=0x600004B  System.IAsyncResult BeginInvoke(System.String text, UnityEngine.Color color, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600004C  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TextOverlayGUIDelegate
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09687F2C  token=0x600004D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09687EE4  token=0x600004E  System.Void Invoke(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor alignment, UnityEngine.Vector2 position)
  RVA=0x09687DF0  token=0x600004F  System.IAsyncResult BeginInvoke(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor alignment, UnityEngine.Vector2 position, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000050  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ImageOverlayGUIDelegate
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09686874  token=0x6000051  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0968683C  token=0x6000052  System.Void Invoke(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position)
  RVA=0x0968677C  token=0x6000053  System.IAsyncResult BeginInvoke(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000054  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ScreenFadeGUIDelegate
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06891E40  token=0x6000055  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x03D490A0  token=0x6000056  System.Void Invoke(UnityEngine.Color color)
  RVA=0x09687050  token=0x6000057  System.IAsyncResult BeginInvoke(UnityEngine.Color color, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000058  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: LetterboxGUIDelegate
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x07D6D6C4  token=0x6000059  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x600005A  System.Void Invoke(System.Single completion)
  RVA=0x0968699C  token=0x600005B  System.IAsyncResult BeginInvoke(System.Single completion, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x600005C  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CameraDissolveDelegate
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0967B818  token=0x600005D  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x600005E  System.Void Invoke(UnityEngine.Texture texture, System.Single completion)
  RVA=0x0967B798  token=0x600005F  System.IAsyncResult BeginInvoke(UnityEngine.Texture texture, System.Single completion, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000060  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TrackingMode
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.DynamicCameraController.Transposer.TrackingModeNone  // const
  public    static  Slate.DynamicCameraController.Transposer.TrackingModeOffsetTracking  // const
  public    static  Slate.DynamicCameraController.Transposer.TrackingModeRailTracking  // const
METHODS:
END_CLASS

CLASS: OffsetMode
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.DynamicCameraController.Transposer.OffsetModeLocalSpace  // const
  public    static  Slate.DynamicCameraController.Transposer.OffsetModeWorldSpace  // const
METHODS:
END_CLASS

CLASS: Transposer
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x50
FIELDS:
  public            Slate.DynamicCameraController.Transposer.TrackingModetrackingMode  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  public            UnityEngine.Vector3             targetOffset  // 0x20
  public            Slate.DynamicCameraController.Transposer.OffsetModeoffsetMode  // 0x2c
  public            UnityEngine.Vector3             railStart  // 0x30
  public            UnityEngine.Vector3             railEnd  // 0x3c
  public            System.Single                   railOffset  // 0x48
  public            System.Single                   smoothDamping  // 0x4c
METHODS:
  RVA=0x03D74FD0  token=0x600006A  System.Void .ctor()
END_CLASS

CLASS: TrackingMode
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.DynamicCameraController.Composer.TrackingModeNone  // const
  public    static  Slate.DynamicCameraController.Composer.TrackingModeFrameComposition  // const
METHODS:
END_CLASS

CLASS: Composer
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x50
FIELDS:
  public            Slate.DynamicCameraController.Composer.TrackingModetrackingMode  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  public            UnityEngine.Vector3             targetOffset  // 0x20
  public            System.Single                   targetSize  // 0x2c
  public            UnityEngine.Vector2             frameCenter  // 0x30
  public            UnityEngine.Vector2             frameExtends  // 0x38
  public            System.Single                   dutchTilt  // 0x40
  public            System.Boolean                  zoomAtTargetFrame  // 0x44
  public            System.Single                   smoothDamping  // 0x48
METHODS:
  RVA=0x03D74F40  token=0x600006B  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass47_0
TYPE:  sealed class
TOKEN: 0x2000013
SIZE:  0x18
FIELDS:
  public            System.String                   shotName  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000A8  System.Void .ctor()
  RVA=0x096881C4  token=0x60000A9  System.Boolean <Find>b__0(Slate.ShotCamera s)
END_CLASS

CLASS: <>c__DisplayClass19_0
TYPE:  sealed class
TOKEN: 0x2000017
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000CC  System.Void .ctor()
  RVA=0x0968810C  token=0x60000CD  System.Boolean <FindExpressionByName>b__0(Slate.BlendShapeGroup x)
END_CLASS

CLASS: <>c__DisplayClass20_0
TYPE:  sealed class
TOKEN: 0x2000018
SIZE:  0x18
FIELDS:
  public            System.String                   UID  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000CE  System.Void .ctor()
  RVA=0x09688128  token=0x60000CF  System.Boolean <FindExpressionByUID>b__0(Slate.BlendShapeGroup x)
END_CLASS

CLASS: BlendInEffectType
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CameraShot.BlendInEffectTypeNone  // const
  public    static  Slate.CameraShot.BlendInEffectTypeFadeFromColor  // const
  public    static  Slate.CameraShot.BlendInEffectTypeCrossDissolve  // const
  public    static  Slate.CameraShot.BlendInEffectTypeEaseIn  // const
METHODS:
END_CLASS

CLASS: BlendOutEffectType
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CameraShot.BlendOutEffectTypeNone  // const
  public    static  Slate.CameraShot.BlendOutEffectTypeFadeToColor  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x10
FIELDS:
  public    static readonly Slate.CameraShot.<>c            <>9  // static @ 0x0
METHODS:
  RVA=0x09688260  token=0x6000115  System.Void .cctor()
  RVA=0x0350B670  token=0x6000116  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000043
SIZE:  0x10
FIELDS:
  public    static readonly Slate.AnimatorTrack.<>c         <>9  // static @ 0x0
  public    static  System.Func<Slate.AnimatorTrack,System.Boolean><>9__36_0  // static @ 0x8
METHODS:
  RVA=0x096882C4  token=0x6000177  System.Void .cctor()
  RVA=0x0350B670  token=0x6000178  System.Void .ctor()
  RVA=0x09688000  token=0x6000179  System.Boolean <OnInitialize>b__36_0(Slate.AnimatorTrack t)
END_CLASS

CLASS: SerializationMetaData
TYPE:  class
TOKEN: 0x200004E
SIZE:  0x50
FIELDS:
  public            System.String                   parameterName  // 0x10
  public            System.String                   declaringTypeName  // 0x18
  public            System.String                   transformHierarchyPath  // 0x20
  public            Slate.AnimatedParameter.ParameterTypeparameterType  // 0x28
  private           System.Type                     <declaringType>k__BackingField  // 0x30
  private           System.Reflection.PropertyInfo  <property>k__BackingField  // 0x38
  private           System.Reflection.FieldInfo     <field>k__BackingField  // 0x40
  private           System.Type                     <animatedType>k__BackingField  // 0x48
PROPERTIES:
  declaringType  get=0x01003830  set=0x04270470
  property  get=0x03D4E2A0  set=0x0388FF30
  field  get=0x03D4E2B0  set=0x03CB2D80
  animatedType  get=0x03D4EA70  set=0x02692290
METHODS:
  RVA=0x096870D0  token=0x6000272  System.Void Deserialize()
  RVA=0x0350B670  token=0x6000273  System.Void .ctor()
END_CLASS

CLASS: ParameterType
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.AnimatedParameter.ParameterTypeNotSet  // const
  public    static  Slate.AnimatedParameter.ParameterTypeProperty  // const
  public    static  Slate.AnimatedParameter.ParameterTypeField  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass112_0
TYPE:  sealed class
TOKEN: 0x2000050
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000274  System.Void .ctor()
  RVA=0x09688060  token=0x6000275  System.Single <GetKeyLabel>b__0(UnityEngine.AnimationCurve c)
END_CLASS

CLASS: AddParameterDelegate
TYPE:  sealed class
TOKEN: 0x200005D
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0967210C  token=0x60002E3  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01035ED0  token=0x60002E4  System.Boolean Invoke(System.Type type, System.String memberPath, System.String transformPath)
  RVA=0x050C0AC4  token=0x60002E5  System.IAsyncResult BeginInvoke(System.Type type, System.String memberPath, System.String transformPath, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD8EC  token=0x60002E6  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x200005E
SIZE:  0x18
FIELDS:
  public            Slate.AnimatedParameter         newParam  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002E7  System.Void .ctor()
  RVA=0x09688084  token=0x60002E8  System.Boolean <TryAddParameter>b__0(Slate.AnimatedParameter p)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200005F
SIZE:  0x10
FIELDS:
  public    static readonly Slate.AnimationDataCollection.<>c<>9  // static @ 0x0
  public    static  System.Func<Slate.AnimatedParameter,System.String><>9__14_0  // static @ 0x8
  public    static  System.Func<Slate.AnimatedParameter,System.String><>9__14_1  // static @ 0x10
  public    static  System.Func<System.Single,System.Single><>9__31_1  // static @ 0x18
  public    static  System.Func<System.Single,System.Single><>9__32_1  // static @ 0x20
METHODS:
  RVA=0x096881FC  token=0x60002E9  System.Void .cctor()
  RVA=0x0350B670  token=0x60002EA  System.Void .ctor()
  RVA=0x09688020  token=0x60002EB  System.String <ReOrderParameters>b__14_0(Slate.AnimatedParameter p)
  RVA=0x09688040  token=0x60002EC  System.String <ReOrderParameters>b__14_1(Slate.AnimatedParameter p)
  RVA=0x03D65EB0  token=0x60002ED  System.Single <GetKeyNext>b__31_1(System.Single t)
  RVA=0x03D65EB0  token=0x60002EE  System.Single <GetKeyPrevious>b__32_1(System.Single t)
END_CLASS

CLASS: <>c__DisplayClass15_0
TYPE:  sealed class
TOKEN: 0x2000060
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002EF  System.Void .ctor()
  RVA=0x096880AC  token=0x60002F0  System.Boolean <GetParameterOfName>b__0(Slate.AnimatedParameter d)
END_CLASS

CLASS: <>c__DisplayClass31_0
TYPE:  sealed class
TOKEN: 0x2000061
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002F1  System.Void .ctor()
  RVA=0x09688144  token=0x60002F2  System.Single <GetKeyNext>b__0(Slate.AnimatedParameter p)
  RVA=0x09688168  token=0x60002F3  System.Boolean <GetKeyNext>b__2(System.Single t)
END_CLASS

CLASS: <>c__DisplayClass32_0
TYPE:  sealed class
TOKEN: 0x2000062
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002F4  System.Void .ctor()
  RVA=0x09688170  token=0x60002F5  System.Single <GetKeyPrevious>b__0(Slate.AnimatedParameter p)
  RVA=0x09688194  token=0x60002F6  System.Boolean <GetKeyPrevious>b__2(System.Single t)
END_CLASS

CLASS: <>c__DisplayClass33_0
TYPE:  sealed class
TOKEN: 0x2000063
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60002F7  System.Void .ctor()
  RVA=0x096881A0  token=0x60002F8  System.Boolean <GetKeyLabel>b__0(Slate.AnimatedParameter p)
END_CLASS

CLASS: WrapMode
TYPE:  sealed struct
TOKEN: 0x2000065
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.WrapMode         Once  // const
  public    static  Slate.Cutscene.WrapMode         Loop  // const
  public    static  Slate.Cutscene.WrapMode         PingPong  // const
METHODS:
END_CLASS

CLASS: StopMode
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.StopMode         Skip  // const
  public    static  Slate.Cutscene.StopMode         Rewind  // const
  public    static  Slate.Cutscene.StopMode         Hold  // const
  public    static  Slate.Cutscene.StopMode         SkipRewindNoUndo  // const
METHODS:
END_CLASS

CLASS: UpdateMode
TYPE:  sealed struct
TOKEN: 0x2000067
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.UpdateMode       Normal  // const
  public    static  Slate.Cutscene.UpdateMode       AnimatePhysics  // const
  public    static  Slate.Cutscene.UpdateMode       UnscaledTime  // const
  public    static  Slate.Cutscene.UpdateMode       Manual  // const
METHODS:
END_CLASS

CLASS: PlayingDirection
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.PlayingDirection Forwards  // const
  public    static  Slate.Cutscene.PlayingDirection Backwards  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000069
SIZE:  0x10
FIELDS:
  public    static readonly Slate.Cutscene.<>c              <>9  // static @ 0x0
  public    static  System.Predicate<Slate.CutsceneGroup><>9__62_0  // static @ 0x8
  public    static  System.Predicate<Slate.CutsceneGroup><>9__64_0  // static @ 0x10
  public    static  System.Predicate<Slate.CutsceneTrack><>9__74_0  // static @ 0x18
  public    static  System.Func<Slate.ActorGroup,UnityEngine.GameObject><>9__135_0  // static @ 0x20
  public    static  System.Func<Slate.IDirectableTimePointer,System.Single><>9__136_0  // static @ 0x28
  public    static  System.Comparison<Slate.IDirectableTimePointer><>9__170_0  // static @ 0x30
  public    static  System.Func<Slate.Section,System.String><>9__190_0  // static @ 0x38
  public    static  System.Func<Slate.IEvent,System.String><>9__191_0  // static @ 0x40
METHODS:
  RVA=0x0969B070  token=0x600037A  System.Void .cctor()
  RVA=0x0350B670  token=0x600037B  System.Void .ctor()
  RVA=0x0969AB6C  token=0x600037C  System.Boolean <get_directorGroup>b__62_0(Slate.CutsceneGroup g)
  RVA=0x0969AAEC  token=0x600037D  System.Boolean <get_actorGroup>b__64_0(Slate.CutsceneGroup g)
  RVA=0x0969AB2C  token=0x600037E  System.Boolean <get_cameraTrack>b__74_0(Slate.CutsceneTrack t)
  RVA=0x0969A90C  token=0x600037F  UnityEngine.GameObject <GetAffectedActors>b__135_0(Slate.ActorGroup g)
  RVA=0x0969A988  token=0x6000380  System.Single <GetPointerTimes>b__136_0(Slate.IDirectableTimePointer t)
  RVA=0x0969A9A4  token=0x6000381  System.Int32 <InitializeTimePointers>b__170_0(Slate.IDirectableTimePointer a, Slate.IDirectableTimePointer b)
  RVA=0x059311B8  token=0x6000382  System.String <GetSectionNames>b__190_0(Slate.Section s)
  RVA=0x0969A92C  token=0x6000383  System.String <GetDefinedEventNames>b__191_0(Slate.IEvent d)
END_CLASS

CLASS: <>c__DisplayClass177_0
TYPE:  sealed class
TOKEN: 0x200006A
SIZE:  0x20
FIELDS:
  public            System.Action                   callback  // 0x10
  public            Slate.Cutscene                  instance  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000384  System.Void .ctor()
  RVA=0x0969AD08  token=0x6000385  System.Void <Play>b__0()
END_CLASS

CLASS: <>c__DisplayClass182_0
TYPE:  sealed class
TOKEN: 0x200006B
SIZE:  0x18
FIELDS:
  public            System.String                   groupName  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000386  System.Void .ctor()
  RVA=0x0969ADB0  token=0x6000387  System.Boolean <SetGroupActorOfName>b__0(Slate.ActorGroup g)
END_CLASS

CLASS: <>c__DisplayClass184_0
TYPE:  sealed class
TOKEN: 0x200006C
SIZE:  0x18
FIELDS:
  public            System.String[]                 split  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000388  System.Void .ctor()
  RVA=0x0969AE0C  token=0x6000389  System.Boolean <FindElement>b__0(Slate.CutsceneGroup g)
END_CLASS

CLASS: <Internal_RenderCutscene>d__194
TYPE:  sealed class
TOKEN: 0x200006D
SIZE:  0x50
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           System.Object                   <>2__current  // 0x18
  public            System.Int32                    frameRate  // 0x20
  public            Slate.Cutscene                  <>4__this  // 0x28
  public            System.Int32                    width  // 0x30
  public            System.Int32                    height  // 0x34
  public            System.Action<UnityEngine.Texture2D[]>callback  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Texture2D><renderSequence>5__2  // 0x40
  private           System.Single                   <sampleRate>5__3  // 0x48
  private           System.Single                   <i>5__4  // 0x4c
PROPERTIES:
  System.Collections.Generic.IEnumerator<System.Object>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x010410F0  token=0x600038A  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x600038B  System.Void System.IDisposable.Dispose()
  RVA=0x0969A680  token=0x600038C  System.Boolean MoveNext()
  RVA=0x0969A8C0  token=0x600038E  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ActorReferenceMode
TYPE:  sealed struct
TOKEN: 0x200006F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CutsceneGroup.ActorReferenceModeUseOriginal  // const
  public    static  Slate.CutsceneGroup.ActorReferenceModeUseInstanceHideOriginal  // const
METHODS:
END_CLASS

CLASS: ActorInitialTransformation
TYPE:  sealed struct
TOKEN: 0x2000070
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CutsceneGroup.ActorInitialTransformationUseOriginal  // const
  public    static  Slate.CutsceneGroup.ActorInitialTransformationUseLocal  // const
METHODS:
END_CLASS

CLASS: CustomToggleInfo
TYPE:  class
TOKEN: 0x2000071
SIZE:  0x30
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            System.Int32                    endIndex  // 0x14
  public            System.String                   desc  // 0x18
  public            System.Boolean                  isCollapsed  // 0x20
  private           System.Int32                    <index>k__BackingField  // 0x24
  private           Slate.CutsceneGroup             <group>k__BackingField  // 0x28
PROPERTIES:
  index  get=0x03D4E2E0  set=0x03D4E2F0
  group  get=0x03D4EAC0  set=0x02C92F10
METHODS:
  RVA=0x0968D5CC  token=0x60003D8  System.Void _OnToggleChanged()
  RVA=0x0968D47C  token=0x60003D9  System.Collections.IEnumerable _GetAllTrackNames()
  RVA=0x03D68FC0  token=0x60003DA  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000072
SIZE:  0x10
FIELDS:
  public    static readonly Slate.CutsceneGroup.<>c         <>9  // static @ 0x0
  public    static  System.Func<Slate.CutsceneGroup.CustomToggleInfo,System.Int32><>9__48_0  // static @ 0x8
  public    static  System.Func<Slate.CutsceneTrack,System.Boolean><>9__88_0  // static @ 0x10
  public    static  System.Func<Slate.Section,System.Single><>9__88_1  // static @ 0x18
METHODS:
  RVA=0x0969B138  token=0x60003DB  System.Void .cctor()
  RVA=0x0350B670  token=0x60003DC  System.Void .ctor()
  RVA=0x0945DFE0  token=0x60003DD  System.Int32 <_OnCustomToggleValueChanged>b__48_0(Slate.CutsceneGroup.CustomToggleInfo t)
  RVA=0x0969AA84  token=0x60003DE  System.Boolean <Validate>b__88_0(Slate.CutsceneTrack t)
  RVA=0x0969AAD0  token=0x60003DF  System.Single <Validate>b__88_1(Slate.Section s)
END_CLASS

CLASS: <>c__DisplayClass89_0
TYPE:  sealed class
TOKEN: 0x2000073
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003E0  System.Void .ctor()
  RVA=0x0969AED8  token=0x60003E1  System.Boolean <GetSectionByName>b__0(Slate.Section s)
END_CLASS

CLASS: <>c__DisplayClass90_0
TYPE:  sealed class
TOKEN: 0x2000074
SIZE:  0x18
FIELDS:
  public            System.String                   UID  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003E2  System.Void .ctor()
  RVA=0x05A49258  token=0x60003E3  System.Boolean <GetSectionByUID>b__0(Slate.Section s)
END_CLASS

CLASS: <>c__DisplayClass91_0
TYPE:  sealed class
TOKEN: 0x2000075
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003E4  System.Void .ctor()
  RVA=0x0969AFCC  token=0x60003E5  System.Boolean <GetSectionAfter>b__0(Slate.Section s)
END_CLASS

CLASS: <>c__DisplayClass92_0
TYPE:  sealed class
TOKEN: 0x2000076
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60003E6  System.Void .ctor()
  RVA=0x0969AFEC  token=0x60003E7  System.Boolean <GetSectionBefore>b__0(Slate.Section s)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000078
SIZE:  0x10
FIELDS:
  public    static readonly Slate.CutsceneTrack.<>c         <>9  // static @ 0x0
  public    static  System.Func<Slate.ActionClip,System.Single><>9__70_0  // static @ 0x8
METHODS:
  RVA=0x0969B0D4  token=0x6000429  System.Void .cctor()
  RVA=0x0350B670  token=0x600042A  System.Void .ctor()
  RVA=0x0969AA68  token=0x600042B  System.Single <Validate>b__70_0(Slate.ActionClip a)
END_CLASS

CLASS: <>c__DisplayClass90_0
TYPE:  sealed class
TOKEN: 0x2000079
SIZE:  0x18
FIELDS:
  public            Slate.ActionClip                newAction  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600042C  System.Void .ctor()
  RVA=0x0969AFA0  token=0x600042D  System.Boolean <AddAction>b__0(Slate.ActionClip a)
END_CLASS

CLASS: <>c__DisplayClass12_0
TYPE:  sealed class
TOKEN: 0x200007F
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000482  System.Void .ctor()
  RVA=0x0969AC0C  token=0x6000483  System.Boolean <FindChild>b__0(Slate.IDirectable d)
END_CLASS

CLASS: <>c__DisplayClass14_0
TYPE:  sealed class
TOKEN: 0x2000080
SIZE:  0x18
FIELDS:
  public            Slate.IDirectable               directable  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000484  System.Void .ctor()
  RVA=0x0969AC68  token=0x6000485  System.Boolean <GetPreviousSibling>b__0(Slate.IDirectable d)
END_CLASS

CLASS: <>c__DisplayClass16_0
TYPE:  sealed class
TOKEN: 0x2000081
SIZE:  0x18
FIELDS:
  public            Slate.IDirectable               directable  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000486  System.Void .ctor()
  RVA=0x0969ACB8  token=0x6000487  System.Boolean <GetNextSibling>b__0(Slate.IDirectable d)
END_CLASS

CLASS: ExitMode
TYPE:  sealed struct
TOKEN: 0x2000084
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Section.ExitMode          Continue  // const
  public    static  Slate.Section.ExitMode          Loop  // const
METHODS:
END_CLASS

CLASS: HandleStyle
TYPE:  sealed struct
TOKEN: 0x200008A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.BezierPoint.HandleStyle   Connected  // const
  public    static  Slate.BezierPoint.HandleStyle   Broken  // const
METHODS:
END_CLASS

CLASS: SampleSettings
TYPE:  sealed struct
TOKEN: 0x200008F
SIZE:  0x24
FIELDS:
  public            System.Single                   volume  // 0x10
  public            System.Single                   pitch  // 0x14
  public            System.Single                   pan  // 0x18
  public            System.Single                   spatialBlend  // 0x1c
  public            System.Boolean                  ignoreTimescale  // 0x20
  public            System.Boolean                  bypassReverb  // 0x21
METHODS:
  RVA=0x03D75060  token=0x60004FA  Slate.AudioSampler.SampleSettings Default()
END_CLASS

CLASS: <>c__DisplayClass1_0
TYPE:  sealed class
TOKEN: 0x2000093
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000505  System.Void .ctor()
  RVA=0x0969AE80  token=0x6000506  System.Boolean <GetKeyNext>b__1(UnityEngine.Keyframe k)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000094
SIZE:  0x10
FIELDS:
  public    static readonly Slate.CurveUtility.<>c          <>9  // static @ 0x0
  public    static  System.Func<UnityEngine.Keyframe,System.Single><>9__1_0  // static @ 0x8
  public    static  System.Func<UnityEngine.Keyframe,System.Single><>9__2_0  // static @ 0x10
METHODS:
  RVA=0x0969B00C  token=0x6000507  System.Void .cctor()
  RVA=0x0350B670  token=0x6000508  System.Void .ctor()
  RVA=0x03D750D0  token=0x6000509  System.Single <GetKeyNext>b__1_0(UnityEngine.Keyframe k)
  RVA=0x03D750D0  token=0x600050A  System.Single <GetKeyPrevious>b__2_0(UnityEngine.Keyframe k)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x2000095
SIZE:  0x18
FIELDS:
  public            System.Single                   time  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600050B  System.Void .ctor()
  RVA=0x0969AE9C  token=0x600050C  System.Boolean <GetKeyPrevious>b__1(UnityEngine.Keyframe k)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x2000096
SIZE:  0x20
FIELDS:
  public            System.Single                   time  // 0x10
  public            System.Func<UnityEngine.Keyframe,System.Boolean><>9__0  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600050D  System.Void .ctor()
  RVA=0x0969AEB4  token=0x600050E  System.Boolean <HasKey>b__0(UnityEngine.Keyframe k)
END_CLASS

CLASS: <>c__DisplayClass8_0
TYPE:  sealed class
TOKEN: 0x20000A0
SIZE:  0x20
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Func<System.Type,System.Boolean><>9__0  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600056C  System.Void .ctor()
  RVA=0x0969AF2C  token=0x600056D  System.Boolean <GetImplementationsOf>b__0(System.Type t)
END_CLASS

CLASS: <>c__DisplayClass28_0`2
TYPE:  sealed class
TOKEN: 0x20000A1
FIELDS:
  public            System.Reflection.MemberInfo    info  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x600056E  System.Void .ctor()
  RVA=-1  // not resolved  token=0x600056F  System.Void <GetFieldOrPropSetter>b__0(T x, TValue v)
END_CLASS

CLASS: StoreMode
TYPE:  sealed struct
TOKEN: 0x20000A6
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.TransformSnapshot.StoreModeAll  // const
  public    static  Slate.TransformSnapshot.StoreModeRootOnly  // const
  public    static  Slate.TransformSnapshot.StoreModeChildrenOnly  // const
METHODS:
END_CLASS

CLASS: TransformData
TYPE:  sealed struct
TOKEN: 0x20000A7
SIZE:  0x48
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            UnityEngine.Transform           parent  // 0x18
  public            UnityEngine.Vector3             pos  // 0x20
  public            UnityEngine.Quaternion          rot  // 0x2c
  public            UnityEngine.Vector3             scale  // 0x3c
METHODS:
  RVA=0x09699ADC  token=0x600058B  System.Void .ctor(UnityEngine.Transform transform, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale)
END_CLASS

CLASS: <>c__DisplayClass10_0
TYPE:  sealed class
TOKEN: 0x20000A9
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600059A  System.Void .ctor()
  RVA=0x0969ABAC  token=0x600059B  System.Boolean <FindInChildren>b__0(UnityEngine.Transform t)
END_CLASS

CLASS: VideoRenderTarget
TYPE:  sealed struct
TOKEN: 0x20000AB
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.VideoSampler.VideoRenderTargetCameraBackground  // const
  public    static  Slate.VideoSampler.VideoRenderTargetCameraForeground  // const
METHODS:
END_CLASS

CLASS: SampleSettings
TYPE:  sealed struct
TOKEN: 0x20000AC
SIZE:  0x24
FIELDS:
  public            Slate.VideoSampler.VideoRenderTargetrenderTarget  // 0x10
  public            System.Single                   playbackSpeed  // 0x14
  public            System.Single                   alpha  // 0x18
  public            UnityEngine.Video.VideoAspectRatioaspectRatio  // 0x1c
  public            System.Single                   audioVolume  // 0x20
METHODS:
  RVA=0x03D75080  token=0x60005A1  Slate.VideoSampler.SampleSettings Default()
END_CLASS

CLASS: StartingTransformsMode
TYPE:  sealed struct
TOKEN: 0x2000103
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.ActionClips.PlayAnimatorClip.StartingTransformsModeAutoMatchTransforms  // const
  public    static  Slate.ActionClips.PlayAnimatorClip.StartingTransformsModeManualSetTransforms  // const
METHODS:
END_CLASS

CLASS: ClipWrapMode
TYPE:  sealed struct
TOKEN: 0x2000104
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.ActionClips.PlayAnimatorClip.ClipWrapModeLoop  // const
  public    static  Slate.ActionClips.PlayAnimatorClip.ClipWrapModePingPong  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200010B
SIZE:  0x10
FIELDS:
  public    static readonly Slate.ActionClips.AnimateLimbIK.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x096A8968  token=0x60008B9  System.Void .cctor()
  RVA=0x0350B670  token=0x60008BA  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200010D
SIZE:  0x10
FIELDS:
  public    static readonly Slate.ActionClips.AnimateLookAtIK.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x096A8904  token=0x60008CD  System.Void .cctor()
  RVA=0x0350B670  token=0x60008CE  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x2000111
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60008DE  System.Void .ctor()
  RVA=0x05A49258  token=0x60008DF  System.Boolean <HasParameter>b__0(UnityEngine.AnimatorControllerParameter p)
END_CLASS

CLASS: Slate.DirectorCamera
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirectableCamera
FIELDS:
  private           System.Boolean                  _matchMainWhenActive  // 0x18
  private           System.Boolean                  _setMainWhenActive  // 0x19
  private           System.Boolean                  _autoHandleActiveState  // 0x1a
  private           System.Boolean                  _ignoreFOVChanges  // 0x1b
  private           System.Boolean                  _dontDestroyOnLoad  // 0x1c
  public    static  System.Single                   MAX_DAMP  // const
  private   static  System.Action<Slate.IDirectableCamera>onCut  // static @ 0x0
  private   static  System.Action                   onActivate  // static @ 0x8
  private   static  System.Action                   onDeactivate  // static @ 0x10
  private   static  Slate.DirectorCamera            _current  // static @ 0x18
  private   static  UnityEngine.Camera              _cam  // static @ 0x20
  private   static  Slate.IDirectableCamera         lastTargetShot  // static @ 0x28
  private           System.Single                   <focalDistance>k__BackingField  // 0x20
  private           System.Single                   <focalLength>k__BackingField  // 0x24
  private           System.Single                   <focalAperture>k__BackingField  // 0x28
  private   static  Slate.GameCamera                <gameCamera>k__BackingField  // static @ 0x30
  private   static  System.Boolean                  <isEnabled>k__BackingField  // static @ 0x38
  private   static  System.Single                   noiseTimer  // static @ 0x3c
  private   static  UnityEngine.Vector3             noisePosOffset  // static @ 0x40
  private   static  UnityEngine.Vector3             noiseRotOffset  // static @ 0x4c
  private   static  UnityEngine.Vector3             noiseTargetPosOffset  // static @ 0x58
  private   static  UnityEngine.Vector3             noiseTargetRotOffset  // static @ 0x64
  private   static  UnityEngine.Vector3             noiseCamPosVel  // static @ 0x70
  private   static  UnityEngine.Vector3             noiseCamRotVel  // static @ 0x7c
PROPERTIES:
  current  get=0x09683E4C
  cam  get=0x09683D1C
  position  get=0x09684160  set=0x096845C8
  rotation  get=0x096841D8  set=0x0968461C
  fieldOfView  get=0x09684050  set=0x09684488
  focalDistance  get=0x03D4F2E0  set=0x03D4F2F0
  focalLength  get=0x03D524F0  set=0x03D52500
  focalAperture  get=0x03D4F480  set=0x03D4F490
  matchMainWhenActive  get=0x09684140  set=0x096845A4
  setMainWhenActive  get=0x09684224  set=0x09684668
  autoHandleActiveState  get=0x09683CFC  set=0x09684440
  ignoreFOVChanges  get=0x096840E8  set=0x09684544
  dontDestroyOnLoad  get=0x09684030  set=0x09684464
  renderCamera  get=0x096841B4
  gameCamera  get=0x096840B0  set=0x096844F0
  isEnabled  get=0x09684108  set=0x09684568
EVENTS:
  onCut  add=add_onCut  remove=remove_onCut
  onActivate  add=add_onActivate  remove=remove_onActivate
  onDeactivate  add=add_onDeactivate  remove=remove_onDeactivate
METHODS:
  RVA=0x09682C28  token=0x6000024  System.Void Awake()
  RVA=0x09682D4C  token=0x6000025  UnityEngine.Camera CreateRenderCamera()
  RVA=0x0968300C  token=0x6000026  System.Void Enable()
  RVA=0x09682EE4  token=0x6000027  System.Void Disable()
  RVA=0x09683428  token=0x6000028  System.Void Update(Slate.IDirectableCamera source, Slate.IDirectableCamera target, Slate.EaseType interpolation, System.Single weight, System.Single damping)
  RVA=0x0968283C  token=0x6000029  System.Void ApplyNoise(System.Single magnitude, System.Single weight)
  RVA=0x03D42A90  token=0x600002A  System.Void .ctor()
  RVA=0x0426FB4C  token=0x600002B  UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject()
END_CLASS

CLASS: Slate.DirectorGUI
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  Slate.DirectorGUI.SubtitlesGUIDelegateOnSubtitlesGUI  // static @ 0x0
  private   static  Slate.DirectorGUI.TextOverlayGUIDelegateOnTextOverlayGUI  // static @ 0x8
  private   static  Slate.DirectorGUI.ImageOverlayGUIDelegateOnImageOverlayGUI  // static @ 0x10
  private   static  Slate.DirectorGUI.ScreenFadeGUIDelegateOnScreenFadeGUI  // static @ 0x18
  private   static  Slate.DirectorGUI.LetterboxGUIDelegateOnLetterboxGUI  // static @ 0x20
  private   static  Slate.DirectorGUI.CameraDissolveDelegateOnCameraDissolve  // static @ 0x28
  private   static  System.Action                   OnGUIEnable  // static @ 0x30
  private   static  System.Action                   OnGUIDisable  // static @ 0x38
  private   static  Slate.DirectorGUI               _current  // static @ 0x40
  private   static  UnityEngine.Color               <lastFadeColor>k__BackingField  // static @ 0x48
PROPERTIES:
  current  get=0x09685138
  lastFadeColor  get=0x096852C4  set=0x09685880
EVENTS:
  OnSubtitlesGUI  add=add_OnSubtitlesGUI  remove=remove_OnSubtitlesGUI
  OnTextOverlayGUI  add=add_OnTextOverlayGUI  remove=remove_OnTextOverlayGUI
  OnImageOverlayGUI  add=add_OnImageOverlayGUI  remove=remove_OnImageOverlayGUI
  OnScreenFadeGUI  add=add_OnScreenFadeGUI  remove=remove_OnScreenFadeGUI
  OnLetterboxGUI  add=add_OnLetterboxGUI  remove=remove_OnLetterboxGUI
  OnCameraDissolve  add=add_OnCameraDissolve  remove=remove_OnCameraDissolve
  OnGUIEnable  add=add_OnGUIEnable  remove=remove_OnGUIEnable
  OnGUIDisable  add=add_OnGUIDisable  remove=remove_OnGUIDisable
METHODS:
  RVA=0x0968468C  token=0x600003D  System.Void Awake()
  RVA=0x09684880  token=0x600003E  System.Void OnEnable()
  RVA=0x0968476C  token=0x600003F  System.Void OnDisable()
  RVA=0x096849B8  token=0x6000040  System.Void UpdateLetterbox(System.Single completion)
  RVA=0x096848C4  token=0x6000041  System.Void UpdateDissolve(UnityEngine.Texture texture, System.Single completion)
  RVA=0x09684928  token=0x6000044  System.Void UpdateFade(UnityEngine.Color color)
  RVA=0x09684B54  token=0x6000045  System.Void UpdateSubtitles(System.String text, UnityEngine.Color color)
  RVA=0x09684AB0  token=0x6000046  System.Void UpdateOverlayText(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 pos)
  RVA=0x09684A14  token=0x6000047  System.Void UpdateOverlayImage(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 positionOffset)
  RVA=0x0426FE60  token=0x6000048  System.Void .ctor()
END_CLASS

CLASS: Slate.DynamicCameraController
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x28
FIELDS:
  private   static  System.Single                   MIN_DAMP  // const
  private   static  System.Single                   MAX_DAMP  // const
  private           Slate.DynamicCameraController.Transposer_transposer  // 0x10
  private           Slate.DynamicCameraController.Composer_composer  // 0x18
  private           System.Int32                    lastUpdateFrame  // 0x20
PROPERTIES:
  transposer  get=0x020B7B20
  composer  get=0x01041090
  controlsPosition  get=0x09686660
  controlsRotation  get=0x09686678
  controlsFieldOfView  get=0x09686644
METHODS:
  RVA=0x09685938  token=0x6000066  System.Void UpdateControllerHard(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable)
  RVA=0x09685954  token=0x6000067  System.Void UpdateControllerSoft(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable)
  RVA=0x09685970  token=0x6000068  System.Void UpdateController(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable, System.Boolean isHard)
  RVA=0x09686598  token=0x6000069  System.Void .ctor()
END_CLASS

CLASS: Slate.GameCamera
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirectableCamera
FIELDS:
  private           UnityEngine.Camera              _cam  // 0x18
PROPERTIES:
  cam  get=0x09686690
  position  get=0x085BEE50  set=0x0350B670
  rotation  get=0x085BEE98  set=0x0350B670
  fieldOfView  get=0x0968671C  set=0x0350B670
  focalDistance  get=0x03D5E210  set=0x0350B670
  focalLength  get=0x03D74FC0  set=0x0350B670
  focalAperture  get=0x03D74FB0  set=0x0350B670
METHODS:
  RVA=0x0426FE60  token=0x6000079  System.Void .ctor()
  RVA=0x0426FB4C  token=0x600007A  UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject()
END_CLASS

CLASS: Slate.IDirectableCamera
TYPE:  interface
TOKEN: 0x2000011
FIELDS:
PROPERTIES:
  gameObject  get=-1  // abstract
  cam  get=-1  // abstract
  position  get=-1  // abstract  set=-1  // abstract
  rotation  get=-1  // abstract  set=-1  // abstract
  fieldOfView  get=-1  // abstract  set=-1  // abstract
  focalDistance  get=-1  // abstract  set=-1  // abstract
  focalLength  get=-1  // abstract  set=-1  // abstract
  focalAperture  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: Slate.ShotCamera
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirectableCamera
FIELDS:
  public    static  System.String                   DEFAULT_NAME  // const
  private           Slate.DynamicCameraController   _dynamicController  // 0x18
  private           System.Single                   _focalDistance  // 0x20
  private           System.Single                   _focalLength  // 0x24
  private           System.Single                   _focalAperture  // 0x28
  private           UnityEngine.Camera              _cam  // 0x30
PROPERTIES:
  cam  get=0x09687994
  position  get=0x085BEE50  set=0x059185D4
  rotation  get=0x085BEE98  set=0x059162F0
  localPosition  get=0x09687B3C  set=0x09687C50
  localEulerAngles  get=0x09687AC8  set=0x09687BDC
  fieldOfView  get=0x09687A68  set=0x09687B84
  focalDistance  get=0x03D4F2E0  set=0x03D4F2F0
  focalLength  get=0x03D524F0  set=0x03D52500
  focalAperture  get=0x03D4F480  set=0x03D4F490
  dynamicController  get=0x01041090
  dynamicControlledPosition  get=0x09687A38
  dynamicControlledRotation  get=0x09687A50
  dynamicControlledFieldOfView  get=0x09687A20
METHODS:
  RVA=0x09687248  token=0x600009E  System.Void Awake()
  RVA=0x096878C0  token=0x600009F  System.Void UpdateDynamicControllerHard(Slate.IDirectable directable)
  RVA=0x096878E8  token=0x60000A0  System.Void UpdateDynamicControllerSoft(Slate.IDirectable directable)
  RVA=0x096878B4  token=0x60000A1  System.Void SetDynamicControllerTargets(UnityEngine.Transform target)
  RVA=0x09687860  token=0x60000A2  System.Void SetDynamicControllerTargets(UnityEngine.Transform transposerTarget, UnityEngine.Transform composerTarget)
  RVA=0x096876BC  token=0x60000A3  UnityEngine.RenderTexture GetRenderTexture(System.Int32 width, System.Int32 height)
  RVA=0x0968733C  token=0x60000A4  Slate.ShotCamera Create(UnityEngine.Transform targetParent)
  RVA=0x096875C4  token=0x60000A5  Slate.ShotCamera Find(System.String shotName)
  RVA=0x09687910  token=0x60000A6  System.Void .ctor()
  RVA=0x0426FB4C  token=0x60000A7  UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject()
END_CLASS

CLASS: Slate.BlendShape
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x28
FIELDS:
  private           UnityEngine.SkinnedMeshRenderer _skin  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Single                   _weight  // 0x20
PROPERTIES:
  skin  get=0x020B7B20  set=0x0426FEE0
  name  get=0x01041090  set=0x022C3A90
  weight  get=0x03D4F2E0  set=0x03D4F2F0
METHODS:
  RVA=0x0967B6CC  token=0x60000B0  System.Void SetRealWeight(System.Single modWeight)
  RVA=0x01041090  token=0x60000B1  System.String ToString()
  RVA=0x0350B670  token=0x60000B2  System.Void .ctor()
END_CLASS

CLASS: Slate.BlendShapeGroup
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x30
FIELDS:
  private           System.String                   _UID  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Single                   _weight  // 0x20
  private           System.Collections.Generic.List<Slate.BlendShape>_blendShapes  // 0x28
PROPERTIES:
  UID  get=0x020B7B20  set=0x0426FEE0
  name  get=0x01041090  set=0x022C3A90
  weight  get=0x03D4F2E0  set=0x0967B6C0
  blendShapes  get=0x03D4EAC0
METHODS:
  RVA=0x0967B5F4  token=0x60000BA  System.Void .ctor()
  RVA=0x0967B574  token=0x60000BB  System.Void SetBlendWeights()
  RVA=0x01041090  token=0x60000BC  System.String ToString()
END_CLASS

CLASS: Slate.Character
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Slate.BlendShapeGroup>_expressions  // 0x18
  private           UnityEngine.Transform           _neckTransform  // 0x20
  private           UnityEngine.Transform           _headTransform  // 0x28
  private           UnityEngine.Vector3             _upVector  // 0x30
  private           UnityEngine.Vector3             _rotationOffset  // 0x3c
PROPERTIES:
  neck  get=0x03D4EB40  set=0x04271930
  head  get=0x03D4EAC0  set=0x02C92F10
  upVector  get=0x03D51B80  set=0x03D51BB0
  rotationOffset  get=0x03D51B60  set=0x03D51BA0
  expressions  get=0x01041090
METHODS:
  RVA=0x0967D690  token=0x60000C6  Slate.BlendShapeGroup FindExpressionByName(System.String name)
  RVA=0x0967D760  token=0x60000C7  Slate.BlendShapeGroup FindExpressionByUID(System.String UID)
  RVA=0x0967D8B0  token=0x60000C8  System.Void SetExpressionWeightByName(System.String name, System.Single weight)
  RVA=0x0967D8E4  token=0x60000C9  System.Void SetExpressionWeightByUID(System.String UID, System.Single weight)
  RVA=0x0967D830  token=0x60000CA  System.Void ResetExpressions()
  RVA=0x0967D918  token=0x60000CB  System.Void .ctor()
END_CLASS

CLASS: Slate.NameAttribute
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.String                   name  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000D0  System.Void .ctor(System.String name)
END_CLASS

CLASS: Slate.CategoryAttribute
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.String                   category  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000D1  System.Void .ctor(System.String category)
END_CLASS

CLASS: Slate.DescriptionAttribute
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.String                   description  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000D2  System.Void .ctor(System.String description)
END_CLASS

CLASS: Slate.IconAttribute
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.String                   iconName  // 0x10
  public    readonly System.Type                     fromType  // 0x18
METHODS:
  RVA=0x0426FEE0  token=0x60000D3  System.Void .ctor(System.String iconName)
  RVA=0x022C3A90  token=0x60000D4  System.Void .ctor(System.Type fromType)
END_CLASS

CLASS: Slate.AttachableAttribute
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type[]                   types  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000D5  System.Void .ctor(System.Type[] types)
END_CLASS

CLASS: Slate.UniqueElementAttribute
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000D6  System.Void .ctor()
END_CLASS

CLASS: Slate.ShowTrajectoryAttribute
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000D7  System.Void .ctor()
END_CLASS

CLASS: Slate.PositionHandleAttribute
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000D8  System.Void .ctor()
END_CLASS

CLASS: Slate.RotationHandleAttribute
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.String                   positionPropertyName  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000D9  System.Void .ctor(System.String positionPropertyName)
END_CLASS

CLASS: Slate.AnimatableParameterAttribute
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x30
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public            System.String                   link  // 0x10
  public    readonly System.Nullable<System.Single>  min  // 0x18
  public    readonly System.Nullable<System.Single>  max  // 0x20
  public    readonly System.String                   customName  // 0x28
METHODS:
  RVA=0x0350B670  token=0x60000DA  System.Void .ctor()
  RVA=0x02C92F10  token=0x60000DB  System.Void .ctor(System.String customName)
  RVA=0x09672234  token=0x60000DC  System.Void .ctor(System.String customName, System.Single min, System.Single max)
  RVA=0x096722C8  token=0x60000DD  System.Void .ctor(System.Single min, System.Single max)
END_CLASS

CLASS: Slate.ParseAnimatableParametersAttribute
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000DE  System.Void .ctor()
END_CLASS

CLASS: Slate.ShaderPropertyPopupAttribute
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.Type                     propertyType  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000DF  System.Void .ctor()
  RVA=0x0426FEE0  token=0x60000E0  System.Void .ctor(System.Type propertyType)
END_CLASS

CLASS: Slate.LeftToggleAttribute
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000E1  System.Void .ctor()
END_CLASS

CLASS: Slate.MinAttribute
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
METHODS:
  RVA=0x03D50CA0  token=0x60000E2  System.Void .ctor(System.Single min)
END_CLASS

CLASS: Slate.ExampleTextAttribute
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.String                   text  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000E3  System.Void .ctor(System.String text)
END_CLASS

CLASS: Slate.HelpBoxAttribute
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.String                   text  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000E4  System.Void .ctor(System.String text)
END_CLASS

CLASS: Slate.ShowIfAttribute
TYPE:  class
TOKEN: 0x2000029
SIZE:  0x20
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.String                   propertyName  // 0x10
  public    readonly System.Int32                    value  // 0x18
METHODS:
  RVA=0x02738A30  token=0x60000E5  System.Void .ctor(System.String propertyName, System.Int32 value)
END_CLASS

CLASS: Slate.EnabledIfAttribute
TYPE:  class
TOKEN: 0x200002A
SIZE:  0x20
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.String                   propertyName  // 0x10
  public    readonly System.Int32                    value  // 0x18
METHODS:
  RVA=0x02738A30  token=0x60000E6  System.Void .ctor(System.String propertyName, System.Int32 value)
END_CLASS

CLASS: Slate.CallbackAttribute
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  public    readonly System.String                   methodName  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60000E7  System.Void .ctor(System.String methodName)
END_CLASS

CLASS: Slate.RequiredAttribute
TYPE:  class
TOKEN: 0x200002C
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000E8  System.Void .ctor()
END_CLASS

CLASS: Slate.PlaybackProtectedAttribute
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000E9  System.Void .ctor()
END_CLASS

CLASS: Slate.ReadOnlyAttribute
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000EA  System.Void .ctor()
END_CLASS

CLASS: Slate.SortingLayerAttribute
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000EB  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorGroupPopupAttribute
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60000EC  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorActionClip
TYPE:  abstract class
TOKEN: 0x2000031
SIZE:  0x40
EXTENDS: Slate.ActionClip
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x60000ED  System.Void .ctor()
END_CLASS

CLASS: Slate.IEvent
TYPE:  interface
TOKEN: 0x2000032
FIELDS:
PROPERTIES:
  name  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60000EF  System.Void Invoke()
END_CLASS

CLASS: Slate.TransformSpace
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.TransformSpace            CutsceneSpace  // const
  public    static  Slate.TransformSpace            ActorSpace  // const
  public    static  Slate.TransformSpace            WorldSpace  // const
  public    static  Slate.TransformSpace            ParentSpace  // const
METHODS:
END_CLASS

CLASS: Slate.MiniTransformSpace
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.MiniTransformSpace        CutsceneSpace  // const
  public    static  Slate.MiniTransformSpace        WorldSpace  // const
  public    static  Slate.MiniTransformSpace        ParentSpace  // const
METHODS:
END_CLASS

CLASS: Slate.ActiveState
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.ActiveState               Disable  // const
  public    static  Slate.ActiveState               Enable  // const
  public    static  Slate.ActiveState               Toggle  // const
METHODS:
END_CLASS

CLASS: Slate.CameraShot
TYPE:  class
TOKEN: 0x2000036
SIZE:  0xA8
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  private           Slate.ShotCamera                _targetShot  // 0x50
  public            Slate.CameraShot.BlendInEffectTypeblendInEffect  // 0x58
  public            Slate.CameraShot.BlendOutEffectTypeblendOutEffect  // 0x5c
  public            System.Single                   steadyCamEffect  // 0x60
  public            UnityEngine.Color               fadeToColor  // 0x64
  public            UnityEngine.Color               fadeFromColor  // 0x74
  public            Slate.ActorGroup                overrideShotTargetActorGroup  // 0x88
  private           UnityEngine.Color               lastFadeColor  // 0x90
  private           Slate.CameraShot                <previousShot>k__BackingField  // 0xa0
PROPERTIES:
  info  get=0x0967C648
  isValid  get=0x0967C6C8
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  canCrossBlend  get=0x05CB8870
  actor  get=0x0967C410
  previousShot  get=0x03D4EA80  set=0x04270264
  targetShot  get=0x03D4EAF0  set=0x0967CBA8
  track  get=0x0967C848
  position  get=0x0967C718  set=0x0967CA88
  rotation  get=0x0967C7B0  set=0x0967CB18
  fieldOfView  get=0x0967C484  set=0x0967C884
  focalPoint  get=0x0967C568  set=0x0967C998
  focalRange  get=0x0967C5D8  set=0x0967CA10
  focalAperture  get=0x0967C4F8  set=0x0967C920
METHODS:
  RVA=0x0967B940  token=0x600010B  System.Void OnAfterValidate()
  RVA=0x0967BF14  token=0x600010C  System.Void OnRootEnabled()
  RVA=0x0967BE88  token=0x600010D  System.Void OnRootDisabled()
  RVA=0x0967BFA0  token=0x600010E  System.Void OnRootUpdated(System.Single time, System.Single previousTime)
  RVA=0x0967C2FC  token=0x600010F  System.Void TryUpdateShotTargetOverride()
  RVA=0x0967BE10  token=0x6000110  System.Boolean OnInitialize()
  RVA=0x0967BD24  token=0x6000111  System.Void OnEnter()
  RVA=0x0967C02C  token=0x6000112  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0967BE24  token=0x6000113  System.Void OnReverse()
  RVA=0x0967C3D0  token=0x6000114  System.Void .ctor()
END_CLASS

CLASS: Slate.PlayVideo
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x70
EXTENDS: Slate.ActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Video.VideoClip     videoClip  // 0x50
  private           Slate.VideoSampler.SampleSettingssettings  // 0x58
PROPERTIES:
  isValid  get=0x09686E70
  info  get=0x09686DF0
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  track  get=0x09686EC0
METHODS:
  RVA=0x09686CC4  token=0x6000120  System.Void OnEnter()
  RVA=0x09686CC4  token=0x6000121  System.Void OnReverseEnter()
  RVA=0x09686CCC  token=0x6000122  System.Void OnReverse()
  RVA=0x09686CCC  token=0x6000123  System.Void OnExit()
  RVA=0x09686C4C  token=0x6000124  System.Void Enable()
  RVA=0x09686CD4  token=0x6000125  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x09686C20  token=0x6000126  System.Void Disable()
  RVA=0x09686DD4  token=0x6000127  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorGroup
TYPE:  class
TOKEN: 0x200003B
SIZE:  0xA8
EXTENDS: Slate.CutsceneGroup
FIELDS:
  private           System.String                   _name  // 0x70
  private           UnityEngine.GameObject          _actor  // 0x78
  private           Slate.CutsceneGroup.ActorReferenceMode_referenceMode  // 0x80
  private           Slate.CutsceneGroup.ActorInitialTransformation_initialCoordinates  // 0x84
  private           UnityEngine.Vector3             _initialLocalPosition  // 0x88
  private           UnityEngine.Vector3             _initialLocalRotation  // 0x94
  private           System.Boolean                  _displayVirtualMeshGizmo  // 0xa0
PROPERTIES:
  name  get=0x09671F14  set=0x0519C3C8
  actor  get=0x09671F08  set=0x09671FAC
  referenceMode  get=0x03D4EC20  set=0x03D4ECA0
  initialTransformation  get=0x03D4F370  set=0x03D4F390
  initialLocalPosition  get=0x03D74EC0  set=0x03D74EE0
  initialLocalRotation  get=0x03D5B040  set=0x03D5B060
  displayVirtualMeshGizmo  get=0x03D50A40  set=0x03D50A60
METHODS:
  RVA=0x09671EB8  token=0x6000136  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorGroup
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x70
EXTENDS: Slate.CutsceneGroup
FIELDS:
PROPERTIES:
  name  get=0x0968590C  set=0x0350B670
  actor  get=0x05DB5C08  set=0x0350B670
  referenceMode  get=0x01002730  set=0x0350B670
  initialTransformation  get=0x01002730  set=0x0350B670
  initialLocalPosition  get=0x04274B08  set=0x0350B670
  initialLocalRotation  get=0x04274B08  set=0x0350B670
  displayVirtualMeshGizmo  get=0x0115F4C0  set=0x0350B670
METHODS:
  RVA=0x096858C0  token=0x6000145  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionTrack
TYPE:  abstract class
TOKEN: 0x200003D
SIZE:  0x50
EXTENDS: Slate.CutsceneTrack
FIELDS:
METHODS:
  RVA=0x09671E98  token=0x6000146  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorActionTrack
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x50
EXTENDS: Slate.ActionTrack
FIELDS:
METHODS:
  RVA=0x09671E98  token=0x6000147  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorAudioTrack
TYPE:  class
TOKEN: 0x200003F
SIZE:  0x98
EXTENDS: Slate.AudioTrack
FIELDS:
  protected         System.Boolean                  _useAudioSourceOnActor  // 0x90
PROPERTIES:
  useAudioSourceOnActor  get=0x03D58A70
METHODS:
  RVA=0x09671EA0  token=0x6000149  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorPropertiesTrack
TYPE:  class
TOKEN: 0x2000040
SIZE:  0x58
EXTENDS: Slate.PropertiesTrack
FIELDS:
METHODS:
  RVA=0x0967201C  token=0x600014A  System.Void OnCreate()
  RVA=0x09672104  token=0x600014B  System.Void .ctor()
END_CLASS

CLASS: Slate.AnimationTrack
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x78
EXTENDS: Slate.CutsceneTrack
FIELDS:
  private           System.Single                   _weight  // 0x50
  private           System.Single                   _blendIn  // 0x54
  private           System.Single                   _blendOut  // 0x58
  private           UnityEngine.AnimationBlendMode  _animationBlendMode  // 0x5c
  private           System.String                   _mixTransformName  // 0x60
  private           UnityEngine.Animation           anim  // 0x68
  private           UnityEngine.AnimationState      state  // 0x70
PROPERTIES:
  info  get=0x09679038
  blendIn  get=0x03D4F670
  blendOut  get=0x03D51080
  weight  get=0x03D51C90
  animationBlendMode  get=0x03D4EEF0  set=0x03D4EF40
  mixTransformName  get=0x03D4EB00  set=0x039274B0
METHODS:
  RVA=0x09678DE0  token=0x6000154  System.Boolean OnInitialize()
  RVA=0x09678BCC  token=0x6000155  System.Void OnEnter()
  RVA=0x09678EFC  token=0x6000156  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x09678DA0  token=0x6000157  System.Void OnExit()
  RVA=0x09678EBC  token=0x6000158  System.Void OnReverseEnter()
  RVA=0x09678DA0  token=0x6000159  System.Void OnReverse()
  RVA=0x09678A4C  token=0x600015A  UnityEngine.Transform GetMixTransform()
  RVA=0x09678FD4  token=0x600015B  System.Void .ctor()
  RVA=0x09678F9C  token=0x600015C  System.Boolean <GetMixTransform>b__27_0(UnityEngine.Transform t)
END_CLASS

CLASS: Slate.AnimatorTrack
TYPE:  class
TOKEN: 0x2000042
SIZE:  0xF8
EXTENDS: Slate.CutsceneTrack
FIELDS:
  private   static  System.Int32                    ROOTMOTION_FRAMERATE  // const
  public            UnityEngine.AvatarMask          mask  // 0x50
  public            UnityEngine.AnimationBlendMode  blendMode  // 0x58
  public            System.Single                   weight  // 0x5c
  public            System.Boolean                  useRootMotion  // 0x60
  public            System.Boolean                  applyFootIK  // 0x61
  public            System.Boolean                  isRootMotionPreBaked  // 0x62
  private           System.Collections.Generic.List<UnityEngine.Vector3>rmPositions  // 0x68
  private           System.Collections.Generic.List<UnityEngine.Quaternion>rmRotations  // 0x70
  private           System.Int32                    activeClips  // 0x78
  private           System.Single                   activeClipsWeight  // 0x7c
  private           System.Collections.Generic.Dictionary<Slate.ActionClips.PlayAnimatorClip,System.Int32>ports  // 0x80
  private           UnityEngine.Playables.PlayableGraphgraph  // 0x88
  private           UnityEngine.Animations.AnimationPlayableOutputanimationOutput  // 0x98
  private           UnityEngine.Animations.AnimationLayerMixerPlayablemasterMixer  // 0xa8
  private           UnityEngine.Animations.AnimationMixerPlayableclipsMixer  // 0xb8
  private           UnityEngine.Animations.AnimatorControllerPlayableanimatorPlayable  // 0xc8
  private           System.Collections.Generic.List<Slate.AnimatorTrack>siblingTracks  // 0xd8
  private           System.Boolean                  wasRootMotion  // 0xe0
  private           UnityEngine.AnimatorCullingMode wasCullingMode  // 0xe4
  private           System.Boolean                  useBakedRootMotion  // 0xe8
  private           UnityEngine.Animator            _animator  // 0xf0
PROPERTIES:
  animator  get=0x0967AEA0
  info  get=0x0967AFAC
  isLocked  get=0x0967B124
  masterTrack  get=0x0967B15C
  isMasterTrack  get=0x0967B154
  isLastTrack  get=0x0967B0DC
  compoundTrackWeight  get=0x0967AF94
METHODS:
  RVA=0x0967A658  token=0x6000164  System.Boolean OnInitialize()
  RVA=0x0967A4C0  token=0x6000165  System.Void OnEnter()
  RVA=0x0967A990  token=0x6000166  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0967AB48  token=0x6000167  System.Void PostUpdateMasterTrack(System.Single time, System.Single previousTime)
  RVA=0x0967A868  token=0x6000168  System.Void OnReverseEnter()
  RVA=0x0967A618  token=0x6000169  System.Void OnExit()
  RVA=0x0967AA90  token=0x600016A  System.Void PostExitMasterTrack()
  RVA=0x0967A904  token=0x600016B  System.Void OnReverse()
  RVA=0x0967A0B8  token=0x600016C  System.Void EnableClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single blendWeight, System.Single subClipWeight)
  RVA=0x0967AD80  token=0x600016D  System.Void UpdateClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single clipTime, System.Single clipPrevious, System.Single blendWeight, System.Single subClipWeight)
  RVA=0x0967A010  token=0x600016E  System.Void DisableClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single blendWeight, System.Single subClipWeight)
  RVA=0x09679990  token=0x600016F  System.Void CreateAndPlayTree()
  RVA=0x09679D3C  token=0x6000170  UnityEngine.Playables.Playable CreateClipsMixer(UnityEngine.Playables.PlayableGraph graph)
  RVA=0x0967AD30  token=0x6000171  System.Void PreBakeRootMotion()
  RVA=0x096798CC  token=0x6000172  System.Void ClearPreBakeRootMotion()
  RVA=0x09679408  token=0x6000173  System.Void BakeRootMotion()
  RVA=0x0967A174  token=0x6000174  System.Void EvaluateTrackClips(System.Single time, System.Single previousTime, System.Int32& tempActiveClips)
  RVA=0x09679138  token=0x6000175  System.Void ApplyBakedRootMotion(System.Single time)
  RVA=0x0967AE8C  token=0x6000176  System.Void .ctor()
END_CLASS

CLASS: Slate.MecanimTrack
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x58
EXTENDS: Slate.CutsceneTrack
FIELDS:
  private           UnityEngine.Animator            animator  // 0x50
METHODS:
  RVA=0x09686AB4  token=0x600017A  System.Boolean OnInitialize()
  RVA=0x09686AAC  token=0x600017B  System.Void OnReverse()
  RVA=0x09686AAC  token=0x600017C  System.Void OnExit()
  RVA=0x09686A18  token=0x600017D  System.Void DestroyDispatcher()
  RVA=0x09671E98  token=0x600017E  System.Void .ctor()
END_CLASS

CLASS: Slate.AudioTrack
TYPE:  abstract class
TOKEN: 0x2000045
SIZE:  0x90
EXTENDS: Slate.CutsceneTrack
FIELDS:
  protected         UnityEngine.Audio.AudioMixerGroup_outputMixer  // 0x50
  protected         System.Single                   _masterVolume  // 0x58
  protected         System.Single                   _masterPitch  // 0x5c
  protected         System.Single                   _masterStereoPan  // 0x60
  protected         System.Single                   _masterSpatialBlend  // 0x64
  protected         System.Boolean                  _ignoreTimeScale  // 0x68
  protected         System.Boolean                  _bypassReverb  // 0x69
  private           UnityEngine.AudioSource         <source>k__BackingField  // 0x70
  private           Slate.AudioSampler.SampleSettings<sampleSettings>k__BackingField  // 0x78
PROPERTIES:
  info  get=0x0967B4A4
  source  get=0x03D4EB30  set=0x0519C3C8
  sampleSettings  get=0x03D74F00  set=0x03D74F20
  mixer  get=0x03D4EAF0
  useAudioSourceOnActor  get=0x0115F4C0
METHODS:
  RVA=0x0967B2E4  token=0x6000186  System.Void OnEnter()
  RVA=0x0967B2E4  token=0x6000187  System.Void OnReverseEnter()
  RVA=0x0967B2F4  token=0x6000188  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0967B2EC  token=0x6000189  System.Void OnExit()
  RVA=0x0967B2EC  token=0x600018A  System.Void OnReverse()
  RVA=0x0967B208  token=0x600018B  System.Void Enable()
  RVA=0x0967B1A8  token=0x600018C  System.Void Disable()
  RVA=0x0967B3F8  token=0x600018D  System.Void SetAndApplySettings()
  RVA=0x0967B498  token=0x600018E  System.Void SetVolume(System.Single volume)
  RVA=0x09671EA0  token=0x600018F  System.Void .ctor()
END_CLASS

CLASS: Slate.CameraTrack
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x98
EXTENDS: Slate.CutsceneTrack
FIELDS:
  private   static  Slate.CameraTrack               activeCameraTrack  // static @ 0x0
  private           System.Single                   _startTimeOffset  // 0x50
  private           System.Single                   _endTimeOffset  // 0x54
  public            System.Single                   _blendIn  // 0x58
  public            System.Single                   _blendOut  // 0x5c
  public            Slate.EaseType                  interpolation  // 0x60
  public            System.Single                   cineBoxFadeTime  // 0x64
  public            System.Single                   appliedSmoothing  // 0x68
  public            UnityEngine.Camera              exitCameraOverride  // 0x70
  private           Slate.GameCamera                entryCamera  // 0x78
  private           Slate.CameraShot                <firstShot>k__BackingField  // 0x80
  private           Slate.CameraShot                <lastShot>k__BackingField  // 0x88
  private           Slate.CameraShot                <currentShot>k__BackingField  // 0x90
PROPERTIES:
  firstShot  get=0x03D4EAE0  set=0x051DFC94
  lastShot  get=0x03D4EA60  set=0x04274DA0
  currentShot  get=0x03D4EA90  set=0x051DFCB4
  info  get=0x0967D564
  startTime  get=0x03D51C90  set=0x0967D63C
  endTime  get=0x0967D538  set=0x0967D5C8
  blendIn  get=0x0967D3E4  set=0x03D510B0
  blendOut  get=0x0967D48C  set=0x03D5BDF0
METHODS:
  RVA=0x0967CC24  token=0x600019F  System.Void OnEnter()
  RVA=0x0967D014  token=0x60001A0  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0967CE40  token=0x60001A1  System.Void OnExit()
  RVA=0x0967CEDC  token=0x60001A2  System.Void OnReverseEnter()
  RVA=0x0967CF78  token=0x60001A3  System.Void OnReverse()
  RVA=0x0967D3CC  token=0x60001A4  System.Void .ctor()
  RVA=0x0967D34C  token=0x60001A5  System.Boolean <OnEnter>b__36_0(Slate.ActionClip s)
  RVA=0x0967D384  token=0x60001A6  System.Boolean <OnEnter>b__36_1(Slate.ActionClip s)
END_CLASS

CLASS: Slate.DirectorActionTrack
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x50
EXTENDS: Slate.ActionTrack
FIELDS:
METHODS:
  RVA=0x09671E98  token=0x60001A7  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorAudioTrack
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x90
EXTENDS: Slate.AudioTrack
FIELDS:
METHODS:
  RVA=0x09671EA0  token=0x60001A8  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorPropertiesTrack
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x58
EXTENDS: Slate.PropertiesTrack
FIELDS:
METHODS:
  RVA=0x09672104  token=0x60001A9  System.Void .ctor()
END_CLASS

CLASS: Slate.VideoTrack
TYPE:  class
TOKEN: 0x200004A
SIZE:  0x60
EXTENDS: Slate.CutsceneTrack
FIELDS:
  public            Slate.VideoSampler.VideoRenderTargetrenderTarget  // 0x50
  public            UnityEngine.Video.VideoAspectRatioaspectRatio  // 0x54
  private           UnityEngine.Video.VideoPlayer   <source>k__BackingField  // 0x58
PROPERTIES:
  source  get=0x03D4EAA0  set=0x03081D30
  info  get=0x096883F8
METHODS:
  RVA=0x096883D8  token=0x60001AD  System.Void OnEnter()
  RVA=0x096883D8  token=0x60001AE  System.Void OnReverseEnter()
  RVA=0x096883E0  token=0x60001AF  System.Void OnReverse()
  RVA=0x096883E0  token=0x60001B0  System.Void OnExit()
  RVA=0x09688374  token=0x60001B1  System.Void Enable()
  RVA=0x09688328  token=0x60001B2  System.Void Disable()
  RVA=0x096883E8  token=0x60001B3  System.Void .ctor()
END_CLASS

CLASS: Slate.PropertiesTrack
TYPE:  abstract class
TOKEN: 0x200004B
SIZE:  0x58
EXTENDS: Slate.CutsceneTrack
IMPLEMENTS: Slate.IKeyable Slate.IDirectable
FIELDS:
  private           Slate.AnimationDataCollection   _animationData  // 0x50
PROPERTIES:
  animationData  get=0x03D4EAF0
  animatedParametersTarget  get=0x09687048
METHODS:
  RVA=0x09686EFC  token=0x60001B6  System.Void OnAfterValidate()
  RVA=0x09686F24  token=0x60001B7  System.Void OnEnter()
  RVA=0x09686F98  token=0x60001B8  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x09686F78  token=0x60001B9  System.Void OnReverse()
  RVA=0x09686FF0  token=0x60001BA  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClip
TYPE:  abstract class
TOKEN: 0x200004C
SIZE:  0x40
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirectable Slate.IKeyable
FIELDS:
  private           System.Single                   _startTime  // 0x18
  private           Slate.AnimationDataCollection   _animationData  // 0x20
  private           Slate.IDirectable               <parent>k__BackingField  // 0x28
  private           System.Boolean                  <isHighlight>k__BackingField  // 0x30
  private           System.String[]                 _cachedAnimParamPaths  // 0x38
PROPERTIES:
  root  get=0x09671BA0
  parent  get=0x03D4EAC0  set=0x02C92F10
  actor  get=0x0967188C
  Slate.IDirectable.children  get=0x01002730
  animationData  get=0x03D4EB40  set=0x04271930
  startTime  get=0x03D4EBF0  set=0x09671D9C
  endTime  get=0x096718E4  set=0x09671C80
  isActive  get=0x09671A94
  isCollapsed  get=0x09671AD0
  isLocked  get=0x09671AF0
  length  get=0x03D503F0  set=0x0350B670
  blendIn  get=0x03D503F0  set=0x0350B670
  blendOut  get=0x03D503F0  set=0x0350B670
  canCrossBlend  get=0x0115F4C0
  info  get=0x096719F0
  isValid  get=0x09671B30
  color  get=0x05F47B78
  textColor  get=0x0426F8FC
  textSizeInner  get=0x03D55730
  textSizeOuter  get=0x03D55810
  interval  get=0x03D503F0
  url  get=0x09671BC0
  isHighlight  get=0x03D4EF60  set=0x03D4EF70
  isReadOnly  get=0x09671B10
  defaultTransformSpace  get=0x01002730
  animatedParameterPaths  get=0x096718AC
  handleParametersRegistrationManually  get=0x09671910
  animatedParametersTarget  get=0x0339AE90
  animatedParametersInterpolation  get=0x01002730
  useWeightInParameters  get=0x0115F4C0
  hasParameters  get=0x096719D8
  hasActiveParameters  get=0x09671934
  needActor  get=0x09671B80
  canSample  get=0x0232EB60
  updateOrder  get=0x03D5A950
METHODS:
  RVA=0x09671204  token=0x60001E6  System.Boolean Slate.IDirectable.Initialize()
  RVA=0x096711D0  token=0x60001E7  System.Void Slate.IDirectable.Enter()
  RVA=0x09671294  token=0x60001E8  System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime)
  RVA=0x096711F4  token=0x60001E9  System.Void Slate.IDirectable.Exit()
  RVA=0x09671214  token=0x60001EA  System.Void Slate.IDirectable.ReverseEnter()
  RVA=0x09671224  token=0x60001EB  System.Void Slate.IDirectable.Reverse()
  RVA=0x09671260  token=0x60001EC  System.Void Slate.IDirectable.RootEnabled()
  RVA=0x09671248  token=0x60001ED  System.Void Slate.IDirectable.RootDisabled()
  RVA=0x09671278  token=0x60001EE  System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime)
  RVA=0x03D4B9D0  token=0x60001EF  System.Void Slate.IDirectable.RootDestroyed()
  RVA=0x09671080  token=0x60001F0  System.Void PostCreate(Slate.IDirectable parent)
  RVA=0x09671838  token=0x60001F1  System.Void Validate()
  RVA=0x09671848  token=0x60001F2  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  RVA=0x0232EB60  token=0x60001F3  System.Boolean OnInitialize()
  RVA=0x0350B670  token=0x60001F4  System.Void OnEnter()
  RVA=0x09671070  token=0x60001F5  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0350B670  token=0x60001F6  System.Void OnUpdate(System.Single time)
  RVA=0x0350B670  token=0x60001F7  System.Void OnExit()
  RVA=0x0350B670  token=0x60001F8  System.Void OnReverse()
  RVA=0x0350B670  token=0x60001F9  System.Void OnReverseEnter()
  RVA=0x0350B670  token=0x60001FA  System.Void OnDrawGizmosSelected()
  RVA=0x0350B670  token=0x60001FB  System.Void OnSceneGUI()
  RVA=0x0350B670  token=0x60001FC  System.Void OnCreate()
  RVA=0x0350B670  token=0x60001FD  System.Void OnAfterValidate()
  RVA=0x0350B670  token=0x60001FE  System.Void OnRootEnabled()
  RVA=0x0350B670  token=0x60001FF  System.Void OnRootDisabled()
  RVA=0x0350B670  token=0x6000200  System.Void OnRootUpdated(System.Single time, System.Single previousTime)
  RVA=0x0350B670  token=0x6000201  System.Void OnRootDestroyed()
  RVA=0x09671100  token=0x6000202  System.Boolean RootTimeWithinRange()
  RVA=0x096712D8  token=0x6000203  UnityEngine.Vector3 TransformPosition(UnityEngine.Vector3 point, Slate.TransformSpace space)
  RVA=0x09670FE0  token=0x6000204  UnityEngine.Vector3 InverseTransformPosition(UnityEngine.Vector3 point, Slate.TransformSpace space)
  RVA=0x09671324  token=0x6000205  UnityEngine.Quaternion TransformRotation(UnityEngine.Vector3 euler, Slate.TransformSpace space)
  RVA=0x0967102C  token=0x6000206  UnityEngine.Vector3 InverseTransformRotation(UnityEngine.Quaternion rot, Slate.TransformSpace space)
  RVA=0x09670D70  token=0x6000207  UnityEngine.Vector3 ActorPositionInSpace(Slate.TransformSpace space)
  RVA=0x09670FD8  token=0x6000208  UnityEngine.Transform GetSpaceTransform(Slate.TransformSpace space, UnityEngine.GameObject actorOverride)
  RVA=0x09670F9C  token=0x6000209  Slate.ActionClip GetPreviousClip()
  RVA=0x09670F40  token=0x600020A  Slate.ActionClip GetNextClip()
  RVA=0x09670E7C  token=0x600020B  System.Single GetClipWeight()
  RVA=0x09670EE4  token=0x600020C  System.Single GetClipWeight(System.Single time)
  RVA=0x09670EB8  token=0x600020D  System.Single GetClipWeight(System.Single time, System.Single blendInOut)
  RVA=0x09670ED4  token=0x600020E  System.Single GetClipWeight(System.Single time, System.Single blendIn, System.Single blendOut)
  RVA=0x096714A4  token=0x600020F  System.Void TryMatchSubClipLength()
  RVA=0x0967143C  token=0x6000210  System.Void TryMatchPreviousSubClipLoop()
  RVA=0x09671368  token=0x6000211  System.Void TryMatchNexSubClipLoop()
  RVA=-1  // generic def  token=0x6000212  System.String GetParameterName(System.Linq.Expressions.Expression<System.Func<T,TResult>> func)
  RVA=-1  // generic def  token=0x6000213  Slate.AnimatedParameter GetParameter(System.Linq.Expressions.Expression<System.Func<T,TResult>> func)
  RVA=0x09670F7C  token=0x6000214  Slate.AnimatedParameter GetParameter(System.String paramName)
  RVA=-1  // generic def  token=0x6000215  System.Void SetParameterEnabled(System.Linq.Expressions.Expression<System.Func<T,TResult>> func, System.Boolean enabled)
  RVA=0x09671168  token=0x6000216  System.Void SetParameterEnabled(System.String paramName, System.Boolean enabled)
  RVA=0x096710B4  token=0x6000217  System.Void ResetAnimatedParameters()
  RVA=0x09670DA0  token=0x6000218  System.Void CreateAnimationDataCollection()
  RVA=0x0967163C  token=0x6000219  System.Void ValidateAnimParams()
  RVA=0x09671108  token=0x600021A  System.Void SetAnimParamsSnapshot()
  RVA=0x09671560  token=0x600021B  System.Void UpdateAnimParams(System.Single time, System.Single previousTime)
  RVA=0x096710C8  token=0x600021C  System.Void RestoreAnimParamsSnapshot()
  RVA=0x0426FE60  token=0x600021D  System.Void .ctor()
  RVA=0x04276114  token=0x600021E  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.AnimatedParameter
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x70
IMPLEMENTS: Slate.IAnimatableData UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private   static  System.Action<Slate.IAnimatableData>onParameterChanged  // static @ 0x0
  private           System.String                   _serializedData  // 0x10
  private           System.Boolean                  _isDisabled  // 0x18
  private           UnityEngine.AnimationCurve[]    _curves  // 0x20
  private           System.String                   _scriptExpression  // 0x28
  private           Slate.AnimatedParameter.SerializationMetaData_data  // 0x30
  private           Slate.IAnimatedParameterModel   _parameterModel  // 0x38
  private           Slate.IKeyable                  <keyable>k__BackingField  // 0x40
  private           System.Single[]                 <snapshot>k__BackingField  // 0x48
  private           System.Single[]                 <lastEval>k__BackingField  // 0x50
  private           UnityEngine.Transform           <virtualTransformParent>k__BackingField  // 0x58
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type>parameterModelsMap  // static @ 0x8
  public    static readonly System.Type[]                   supportedTypes  // static @ 0x10
  private           System.Object                   _animatableAttribute  // 0x60
  private           System.Object                   _resolvedMemberObject  // 0x68
PROPERTIES:
  enabled  get=0x03D032E0
  serializedData  get=0x020B7B20  set=0x0426FEE0
  data  get=0x0967455C
  parameterModel  get=0x096746C0
  curves  get=0x03D4EB40  set=0x04271930
  scriptExpression  get=0x03D4EAC0  set=0x09674910
  hasActiveExpression  get=0x09674608
  parameterName  get=0x096747AC
  animatedType  get=0x0967453C
  parameterType  get=0x096747CC
  transformHierarchyPath  get=0x0967482C
  declaringType  get=0x096745C8
  property  get=0x096747EC
  field  get=0x096745E8
  isProperty  get=0x09674638
  keyable  get=0x03D4E2B0  set=0x03CB2D80
  snapshot  get=0x03D4EA70  set=0x02692290
  lastEval  get=0x03D4EAF0  set=0x02C926C0
  virtualTransformParent  get=0x03D4EAA0  set=0x03081D30
  targetObject  get=0x0967480C
  animatableAttribute  get=0x09674464
  isExternal  get=0x09674620
  isValid  get=0x09674650
EVENTS:
  onParameterChanged  add=add_onParameterChanged  remove=remove_onParameterChanged
METHODS:
  RVA=0x09673FB0  token=0x600021F  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x09673F74  token=0x6000220  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x09673D50  token=0x6000224  System.Void SetEnabled(System.Boolean value, System.Single time)
  RVA=0x09673FE0  token=0x6000242  System.Void .cctor()
  RVA=0x09674250  token=0x6000243  System.Void .ctor(Slate.IKeyable keyable, System.Type type, System.String memberPath, System.String transformPath)
  RVA=0x09672478  token=0x6000244  System.Void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, System.String memberPath, System.String transformPath)
  RVA=0x09672648  token=0x6000245  System.Void ConstructWithProperty(System.Reflection.PropertyInfo targetProperty, System.Type type, System.String memberPath, System.String transformPath)
  RVA=0x096732D0  token=0x6000246  System.Reflection.MemberInfo GetMemberInfo()
  RVA=0x03D4EB40  token=0x6000247  UnityEngine.AnimationCurve[] GetCurves()
  RVA=0x096723A4  token=0x6000248  System.Boolean CompareTo(Slate.AnimatedParameter other)
  RVA=0x096733A8  token=0x6000249  System.Void InitializeCurves()
  RVA=0x03CB2D80  token=0x600024A  System.Void Validate(Slate.IKeyable keyable)
  RVA=0x03081D30  token=0x600024B  System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent)
  RVA=0x09673E9C  token=0x600024C  System.Void SetSnapshot()
  RVA=0x09673F14  token=0x600024D  System.Boolean TryAutoKey(System.Single time)
  RVA=0x09672978  token=0x600024E  System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight)
  RVA=0x0967288C  token=0x600024F  System.Void Evaluate_1_Curves(System.Single time, System.Single previousTime, System.Single weight)
  RVA=0x0115F4C0  token=0x6000250  System.Boolean Evaluate_2_Expression(System.Single time, System.Single previousTime, System.Single weight)
  RVA=0x09673888  token=0x6000251  System.Void RestoreSnapshot()
  RVA=0x096730C8  token=0x6000252  System.Object GetEvalValue(System.Single time)
  RVA=0x09673654  token=0x6000253  System.Object ResolvedMemberObject()
  RVA=0x09673084  token=0x6000254  System.Object GetCurrentValueAsObject()
  RVA=0x09672C84  token=0x6000255  System.Single[] GetCurrentValueAsFloats()
  RVA=0x096738E8  token=0x6000256  System.Void SetCurrentValue(System.Object value)
  RVA=0x09673930  token=0x6000257  System.Void SetCurrentValue(System.Single[] floats)
  RVA=0x09673320  token=0x6000258  System.Boolean HasChanged()
  RVA=0x09673314  token=0x6000259  System.Boolean HasAnyKey()
  RVA=0x09673398  token=0x600025A  System.Boolean HasKey(System.Single time)
  RVA=0x096732B0  token=0x600025B  System.Single GetKeyNext(System.Single time)
  RVA=0x096732C0  token=0x600025C  System.Single GetKeyPrevious(System.Single time)
  RVA=0x0115F4C0  token=0x600025D  System.Boolean TryKeyIdentity(System.Single time)
  RVA=0x0350B670  token=0x600025E  System.Void SetKeyCurrent(System.Single time)
  RVA=0x0350B670  token=0x600025F  System.Void RemoveKey(System.Single time)
  RVA=0x09673E2C  token=0x6000260  System.Void SetPreWrapMode(UnityEngine.WrapMode mode)
  RVA=0x09673DBC  token=0x6000261  System.Void SetPostWrapMode(UnityEngine.WrapMode mode)
  RVA=0x096734FC  token=0x6000262  System.Void OffsetValue(System.Object deltaValue)
  RVA=0x0967358C  token=0x6000263  System.Void Reset()
  RVA=0x09672344  token=0x6000264  System.Void ChangeMemberType(Slate.AnimatedParameter.ParameterType newType)
  RVA=0x09673F0C  token=0x6000265  System.String ToString()
  RVA=0x09672A04  token=0x6000266  System.String FriendlyName()
  RVA=0x0967319C  token=0x6000267  System.String GetKeyLabel(System.Single time)
  RVA=0x0350B670  token=0x6000268  System.Void RecordUndo()
  RVA=0x09673484  token=0x6000269  System.Void NotifyChange()
END_CLASS

CLASS: Slate.IAnimatedParameterModel
TYPE:  interface
TOKEN: 0x2000051
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000276  System.Boolean ForceStepMode()
  RVA=-1  // abstract  token=0x6000277  System.Int32 RequiredCurvesCount()
  RVA=-1  // abstract  token=0x6000278  System.Object ConvertToObject(System.Single[] floats)
  RVA=-1  // abstract  token=0x6000279  System.Single[] ConvertToFloats(System.Object value)
  RVA=-1  // abstract  token=0x600027A  System.String GetKeyLabel(System.Single[] floats)
  RVA=-1  // abstract  token=0x600027B  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=-1  // abstract  token=0x600027C  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Bool
TYPE:  sealed struct
TOKEN: 0x2000052
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,System.Boolean>setter  // 0x10
METHODS:
  RVA=0x0232EB60  token=0x600027D  System.Boolean ForceStepMode()
  RVA=0x01168950  token=0x600027E  System.Int32 RequiredCurvesCount()
  RVA=0x096749E4  token=0x600027F  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09674948  token=0x6000280  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x09674B1C  token=0x6000281  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x09674BA0  token=0x6000282  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09674A48  token=0x6000283  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Int
TYPE:  sealed struct
TOKEN: 0x2000053
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,System.Int32>setter  // 0x10
METHODS:
  RVA=0x0232EB60  token=0x6000284  System.Boolean ForceStepMode()
  RVA=0x01168950  token=0x6000285  System.Int32 RequiredCurvesCount()
  RVA=0x09675B58  token=0x6000286  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09675ACC  token=0x6000287  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x09675C74  token=0x6000288  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x09675CF0  token=0x6000289  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09675BB4  token=0x600028A  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Float
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,System.Single>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x600028B  System.Boolean ForceStepMode()
  RVA=0x01168950  token=0x600028C  System.Int32 RequiredCurvesCount()
  RVA=0x09675878  token=0x600028D  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x096757F0  token=0x600028E  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x09675998  token=0x600028F  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x09675A14  token=0x6000290  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x096758D8  token=0x6000291  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Vector2
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Vector2>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x6000292  System.Boolean ForceStepMode()
  RVA=0x02102C70  token=0x6000293  System.Int32 RequiredCurvesCount()
  RVA=0x096767EC  token=0x6000294  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09676750  token=0x6000295  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x0967692C  token=0x6000296  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x096769DC  token=0x6000297  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09676858  token=0x6000298  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Vector3
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Vector3>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x6000299  System.Boolean ForceStepMode()
  RVA=0x03D555E0  token=0x600029A  System.Int32 RequiredCurvesCount()
  RVA=0x09676B48  token=0x600029B  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09676AA8  token=0x600029C  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x09676CA0  token=0x600029D  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x09676D84  token=0x600029E  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09676BC8  token=0x600029F  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Color
TYPE:  sealed struct
TOKEN: 0x2000057
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Color>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x60002A0  System.Boolean ForceStepMode()
  RVA=0x03D50CD0  token=0x60002A1  System.Int32 RequiredCurvesCount()
  RVA=0x0967541C  token=0x60002A2  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09675368  token=0x60002A3  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x096755A4  token=0x60002A4  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x096756F0  token=0x60002A5  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x096754B8  token=0x60002A6  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Vector4
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Vector4>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x60002A7  System.Boolean ForceStepMode()
  RVA=0x03D50CD0  token=0x60002A8  System.Int32 RequiredCurvesCount()
  RVA=0x09676F18  token=0x60002A9  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09676E64  token=0x60002AA  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x096770A0  token=0x60002AB  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x09677238  token=0x60002AC  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09676FB4  token=0x60002AD  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Quaternion
TYPE:  sealed struct
TOKEN: 0x2000059
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Quaternion>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x60002AE  System.Boolean ForceStepMode()
  RVA=0x03D50CD0  token=0x60002AF  System.Int32 RequiredCurvesCount()
  RVA=0x09675E5C  token=0x60002B0  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09675DA8  token=0x60002B1  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x09675FE4  token=0x60002B2  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x0967617C  token=0x60002B3  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09675EF8  token=0x60002B4  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Rect
TYPE:  sealed struct
TOKEN: 0x200005A
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Rect>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x60002B5  System.Boolean ForceStepMode()
  RVA=0x03D50CD0  token=0x60002B6  System.Int32 RequiredCurvesCount()
  RVA=0x09676330  token=0x60002B7  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x0967627C  token=0x60002B8  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x096764B8  token=0x60002B9  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x09676650  token=0x60002BA  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x096763CC  token=0x60002BB  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Bounds
TYPE:  sealed struct
TOKEN: 0x200005B
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatedParameterModel
FIELDS:
  private           System.Action<System.Object,UnityEngine.Bounds>setter  // 0x10
METHODS:
  RVA=0x0115F4C0  token=0x60002BC  System.Boolean ForceStepMode()
  RVA=0x03D51110  token=0x60002BD  System.Int32 RequiredCurvesCount()
  RVA=0x09674D88  token=0x60002BE  System.Object ConvertToObject(System.Single[] floats)
  RVA=0x09674C64  token=0x60002BF  System.Single[] ConvertToFloats(System.Object value)
  RVA=0x09674FE8  token=0x60002C0  System.String GetKeyLabel(System.Single[] floats)
  RVA=0x096751FC  token=0x60002C1  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  RVA=0x09674E88  token=0x60002C2  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.AnimationDataCollection
TYPE:  class
TOKEN: 0x200005C
SIZE:  0x18
IMPLEMENTS: Slate.IAnimatableData
FIELDS:
  private           System.Collections.Generic.List<Slate.AnimatedParameter>_animatedParameters  // 0x10
PROPERTIES:
  animatedParameters  get=0x020B7B20
  isValid  get=0x09678A08
  Item  get=0x09678998
  Item  get=0x09678998
METHODS:
  RVA=0x0350B670  token=0x60002C7  System.Void .ctor()
  RVA=0x09678914  token=0x60002C8  System.Void .ctor(Slate.IKeyable keyable, System.Type type, System.String[] memberPaths, System.String transformPath)
  RVA=0x0967850C  token=0x60002C9  System.Boolean TryAddParameter(Slate.IKeyable keyable, System.Type type, System.String memberPath, System.String transformPath)
  RVA=0x0967805C  token=0x60002CA  System.Void RemoveParameter(Slate.AnimatedParameter animParam)
  RVA=0x09677DF0  token=0x60002CB  System.Void ReOrderParameters()
  RVA=0x09677A10  token=0x60002CC  Slate.AnimatedParameter GetParameterOfName(System.String name)
  RVA=0x096773FC  token=0x60002CD  UnityEngine.AnimationCurve[] GetCurves()
  RVA=0x096773F0  token=0x60002CE  UnityEngine.AnimationCurve[] GetCurvesAll()
  RVA=0x09677C9C  token=0x60002CF  UnityEngine.AnimationCurve[] Internal_GetCurves(System.Boolean enabledParamsOnly)
  RVA=0x09678880  token=0x60002D0  System.Void Validate(Slate.IKeyable keyable)
  RVA=0x096783D4  token=0x60002D1  System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent)
  RVA=0x09678350  token=0x60002D2  System.Void SetSnapshot()
  RVA=0x09678748  token=0x60002D3  System.Boolean TryAutoKey(System.Single time)
  RVA=0x09677338  token=0x60002D4  System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight)
  RVA=0x09678134  token=0x60002D5  System.Void RestoreSnapshot()
  RVA=0x09678804  token=0x60002D6  System.Boolean TryKeyIdentity(System.Single time)
  RVA=0x09677FE4  token=0x60002D7  System.Void RemoveKey(System.Single time)
  RVA=0x09677B74  token=0x60002D8  System.Boolean HasChanged()
  RVA=0x09677C00  token=0x60002D9  System.Boolean HasKey(System.Single time)
  RVA=0x09677AE8  token=0x60002DA  System.Boolean HasAnyKey()
  RVA=0x096781B8  token=0x60002DB  System.Void SetKeyCurrent(System.Single time)
  RVA=0x096775B8  token=0x60002DC  System.Single GetKeyNext(System.Single time)
  RVA=0x096777E4  token=0x60002DD  System.Single GetKeyPrevious(System.Single time)
  RVA=0x09677408  token=0x60002DE  System.String GetKeyLabel(System.Single time)
  RVA=0x096782C0  token=0x60002DF  System.Void SetPreWrapMode(UnityEngine.WrapMode mode)
  RVA=0x09678230  token=0x60002E0  System.Void SetPostWrapMode(UnityEngine.WrapMode mode)
  RVA=0x096780B0  token=0x60002E1  System.Void Reset()
  RVA=0x09678468  token=0x60002E2  System.String ToString()
END_CLASS

CLASS: Slate.Cutscene
TYPE:  class
TOKEN: 0x2000064
SIZE:  0xA8
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirector
FIELDS:
  public    static  System.Single                   VERSION_NUMBER  // const
  private   static  System.Action<Slate.Cutscene>   OnCutsceneStarted  // static @ 0x0
  private   static  System.Action<Slate.Cutscene>   OnCutsceneStopped  // static @ 0x8
  private           System.Action<Slate.Section>    OnSectionReached  // 0x18
  private           System.Action<System.String,System.Object>OnGlobalMessageSend  // 0x20
  private           System.Action                   OnStop  // 0x28
  private           Slate.Cutscene.UpdateMode       _updateMode  // 0x30
  private           Slate.Cutscene.WrapMode         _defaultWrapMode  // 0x34
  private           Slate.Cutscene.StopMode         _defaultStopMode  // 0x38
  private           System.Single                   _playbackSpeed  // 0x3c
  private           System.Boolean                  _playOnStart  // 0x40
  private           System.Boolean                  _explicitActiveLayers  // 0x41
  private           UnityEngine.LayerMask           _activeLayers  // 0x44
  public            System.Collections.Generic.List<Slate.CutsceneGroup>groups  // 0x48
  private           System.Single                   _length  // 0x50
  private           System.Single                   _viewTimeMin  // 0x54
  private           System.Single                   _viewTimeMax  // 0x58
  private           System.Single                   _currentTime  // 0x5c
  private           System.Single                   _playTimeMin  // 0x60
  private           System.Single                   _playTimeMax  // 0x64
  private           UnityEngine.Transform           _groupsRoot  // 0x68
  private           System.Collections.Generic.List<Slate.IDirectableTimePointer>timePointers  // 0x70
  private           System.Collections.Generic.List<Slate.IDirectableTimePointer>unsortedStartTimePointers  // 0x78
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean>affectedLayerGOStates  // 0x80
  private   static  System.Collections.Generic.Dictionary<System.String,Slate.Cutscene>allSceneCutscenes  // static @ 0x10
  private           System.Boolean                  preInitialized  // 0x88
  private           System.Boolean                  _isReSampleFrame  // 0x89
  private           System.Boolean                  <isBakingRootMotion>k__BackingField  // 0x8a
  private           Slate.Cutscene.PlayingDirection <playingDirection>k__BackingField  // 0x8c
  private           Slate.Cutscene.WrapMode         <playingWrapMode>k__BackingField  // 0x90
  private           System.Collections.Generic.List<Slate.IDirectable><directables>k__BackingField  // 0x98
  private           System.Boolean                  <isActive>k__BackingField  // 0xa0
  private           System.Boolean                  <isPaused>k__BackingField  // 0xa1
  private           System.Single                   <previousTime>k__BackingField  // 0xa4
PROPERTIES:
  groupsRoot  get=0x096821F4
  updateMode  get=0x03D4ED20  set=0x03D4EE10
  defaultWrapMode  get=0x03D4EE00  set=0x03D4EE40
  defaultStopMode  get=0x03D4EC30  set=0x03D4ECB0
  playOnStart  get=0x03D4EE90  set=0x03D4EEB0
  explicitActiveLayers  get=0x03D4F7B0  set=0x03D4F7D0
  activeLayers  get=0x03D4EE80  set=0x03D4EEA0
  directorGroup  get=0x0968204C
  actorGroup  get=0x09681DE8
  abortDirectorCamera  get=0x0115F4C0
  multiSelectOverlapCheck  get=0x0115F4C0
  isBakingRootMotion  get=0x03D51D70  set=0x03D74F90
  cameraTrack  get=0x09681F10
  currentTime  get=0x03D56C10  set=0x0968270C
  length  get=0x03D51C90  set=0x09682730
  viewTimeMin  get=0x03D4F670  set=0x09682818
  viewTimeMax  get=0x03D51080  set=0x0968278C
  playTimeMin  get=0x03D50D50  set=0x09682768
  playTimeMax  get=0x03D50D60  set=0x09682740
  playbackSpeed  get=0x03D4EC60  set=0x03D4ECE0
  playingDirection  get=0x03D4F3D0  set=0x03D4F420
  playingWrapMode  get=0x03D4FB60  set=0x03D4FB70
  directables  get=0x011AC510  set=0x051417AC
  isActive  get=0x03D50A40  set=0x03D50A60
  isPaused  get=0x03D50A50  set=0x03D50A70
  previousTime  get=0x03D56EE0  set=0x03D74FA0
  Slate.IDirector.isReSampleFrame  get=0x03D51D10
  Slate.IDirector.context  get=0x09680D70
  Slate.IDirector.children  get=0x09680D34
  remainingTime  get=0x096823A8
EVENTS:
  OnCutsceneStarted  add=add_OnCutsceneStarted  remove=remove_OnCutsceneStarted
  OnCutsceneStopped  add=add_OnCutsceneStopped  remove=remove_OnCutsceneStopped
  OnSectionReached  add=add_OnSectionReached  remove=remove_OnSectionReached
  OnGlobalMessageSend  add=add_OnGlobalMessageSend  remove=remove_OnGlobalMessageSend
  OnStop  add=add_OnStop  remove=remove_OnStop
METHODS:
  RVA=0x0967D9C4  token=0x6000335  System.Void Awake()
  RVA=0x09680DCC  token=0x6000336  System.Void Start()
  RVA=0x0967F5D4  token=0x6000337  System.Void OnDestroy()
  RVA=0x0967F5A0  token=0x6000338  System.Void ManualUpdate(System.Single deltaTime)
  RVA=0x0967F53C  token=0x6000339  System.Void LateUpdate()
  RVA=0x0967DFBC  token=0x600033A  System.Void FixedUpdate()
  RVA=0x0967DB54  token=0x600033B  System.Void DirectorSectionReached(Slate.Section section)
  RVA=0x0967E004  token=0x600033C  System.Collections.Generic.IEnumerable<UnityEngine.GameObject> GetAffectedActors()
  RVA=0x0967E270  token=0x600033D  System.Single[] GetPointerTimes()
  RVA=0x09680290  token=0x600033E  System.Void Play()
  RVA=0x0967FFFC  token=0x600033F  System.Void Play(System.Action callback)
  RVA=0x0968000C  token=0x6000340  System.Void Play(System.Single startTime)
  RVA=0x0967FDF4  token=0x6000341  System.Void Play(System.Single startTime, System.Action callback)
  RVA=0x09680034  token=0x6000342  System.Void Play(System.Single startTime, System.Single endTime, Slate.Cutscene.WrapMode wrapMode, System.Action callback, Slate.Cutscene.PlayingDirection playDirection)
  RVA=0x09680FA4  token=0x6000343  System.Void Stop()
  RVA=0x09680E78  token=0x6000344  System.Void Stop(Slate.Cutscene.StopMode stopMode)
  RVA=0x0967FBEC  token=0x6000345  System.Void PlayReverse()
  RVA=0x0967FBFC  token=0x6000346  System.Void PlayReverse(System.Single startTime, System.Single endTime)
  RVA=0x03D74F70  token=0x6000347  System.Void Pause()
  RVA=0x03D74F80  token=0x6000348  System.Void Resume()
  RVA=0x09680C74  token=0x6000349  System.Void SkipAll()
  RVA=0x096805F4  token=0x600034A  System.Void Rewind()
  RVA=0x096805B0  token=0x600034B  System.Void RewindNoUndo()
  RVA=0x03D74F60  token=0x600034C  System.Void BreakCutsceneLoop()
  RVA=0x0967DAFC  token=0x600034D  System.Void BreakSectionLoop(System.Boolean alsoSkip)
  RVA=0x09680D2C  token=0x600034E  System.Void Skip()
  RVA=0x09680CA0  token=0x600034F  System.Void SkipCurrentSection()
  RVA=0x0967F518  token=0x6000350  System.Boolean JumpToSection(System.String name)
  RVA=0x0967F490  token=0x6000351  System.Boolean JumpToSection(Slate.Section section)
  RVA=0x0967FAA8  token=0x6000352  System.Boolean PlayFromSection(System.String name)
  RVA=0x0967FAE8  token=0x6000353  System.Boolean PlayFromSection(System.String name, Slate.Cutscene.WrapMode wrap, System.Action callback)
  RVA=0x0967FAC8  token=0x6000354  System.Boolean PlayFromSection(Slate.Section section)
  RVA=0x0967FB34  token=0x6000355  System.Boolean PlayFromSection(Slate.Section section, Slate.Cutscene.WrapMode wrap, System.Action callback)
  RVA=0x0967FD74  token=0x6000356  System.Boolean PlaySection(System.String name)
  RVA=0x0967FD08  token=0x6000357  System.Boolean PlaySection(System.String name, Slate.Cutscene.WrapMode wrap, System.Action callback)
  RVA=0x0967FD54  token=0x6000358  System.Boolean PlaySection(Slate.Section section)
  RVA=0x0967FC24  token=0x6000359  System.Boolean PlaySection(Slate.Section section, Slate.Cutscene.WrapMode wrap, System.Action callback)
  RVA=0x09680624  token=0x600035A  System.Void Sample()
  RVA=0x09680634  token=0x600035B  System.Void Sample(System.Single time)
  RVA=0x0967F098  token=0x600035C  System.Void Internal_SamplePointers(System.Single currentTime, System.Single previousTime)
  RVA=0x096802BC  token=0x600035D  System.Void ReSample()
  RVA=0x09681198  token=0x600035E  System.Void Validate()
  RVA=0x0967E614  token=0x600035F  System.Void InitializeTimePointers()
  RVA=0x0967F890  token=0x6000360  System.Void OnSampleStarted()
  RVA=0x0967F6D0  token=0x6000361  System.Void OnSampleEnded()
  RVA=0x09680B24  token=0x6000362  System.Void SetLayersActive()
  RVA=0x09680424  token=0x6000363  System.Void RestoreLayersActive()
  RVA=0x09680FF8  token=0x6000364  System.Void UpdateCutscene(System.Single delta)
  RVA=0x0967FDA8  token=0x6000365  Slate.Cutscene Play(System.String name)
  RVA=0x0967FE1C  token=0x6000366  Slate.Cutscene Play(System.String name, System.Action callback)
  RVA=0x0967DDA8  token=0x6000367  Slate.Cutscene FindFromResources(System.String name)
  RVA=0x0967DEF0  token=0x6000368  Slate.Cutscene Find(System.String name)
  RVA=0x09680DE0  token=0x6000369  System.Void StopAllCutscenes()
  RVA=0x09680744  token=0x600036A  System.Void SendGlobalMessage(System.String message, System.Object value)
  RVA=0x09680940  token=0x600036B  System.Void SetGroupActorOfName(System.String groupName, UnityEngine.GameObject newActor)
  RVA=-1  // generic def  token=0x600036C  T FindElement(System.String path)
  RVA=0x0967DC24  token=0x600036D  Slate.IDirectable FindElement(System.String path)
  RVA=0x09680FB0  token=0x600036E  System.String ToString()
  RVA=0x0967E3A4  token=0x600036F  Slate.Section GetSectionByName(System.String name)
  RVA=0x0967E3D4  token=0x6000370  Slate.Section GetSectionByUID(System.String UID)
  RVA=0x0967E5C0  token=0x6000371  Slate.Section[] GetSections()
  RVA=0x0967E404  token=0x6000372  System.Single GetSectionLength(System.String name)
  RVA=0x0967E488  token=0x6000373  System.String[] GetSectionNames()
  RVA=0x0967E12C  token=0x6000374  System.String[] GetDefinedEventNames()
  RVA=0x0968029C  token=0x6000375  System.Void PreInitialize()
  RVA=0x0968032C  token=0x6000376  System.Void RenderCutscene(System.Int32 width, System.Int32 height, System.Int32 frameRate, System.Action<UnityEngine.Texture2D[]> callback)
  RVA=0x0967EFFC  token=0x6000377  System.Collections.IEnumerator Internal_RenderCutscene(System.Int32 width, System.Int32 height, System.Int32 frameRate, System.Action<UnityEngine.Texture2D[]> callback)
  RVA=0x09681A18  token=0x6000378  System.Void .ctor()
  RVA=0x09681984  token=0x6000379  System.Void .cctor()
END_CLASS

CLASS: Slate.CutsceneGroup
TYPE:  abstract class
TOKEN: 0x200006E
SIZE:  0x70
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirectable
FIELDS:
  private           System.Action<Slate.Section>    OnSectionReached  // 0x18
  private           System.Collections.Generic.List<Slate.CutsceneTrack>_tracks  // 0x20
  private           System.Collections.Generic.List<Slate.Section>_sections  // 0x28
  private           System.Boolean                  _isCollapsed  // 0x30
  private           System.Boolean                  _active  // 0x31
  private           System.Boolean                  _isLocked  // 0x32
  private           System.Boolean                  _isReadOnly  // 0x33
  private           Slate.TransformSnapshot         transformSnapshot  // 0x38
  private           Slate.ObjectSnapshot            objectSnapshot  // 0x40
  private           UnityEngine.GameObject          refDuplicateActor  // 0x48
  private   static  System.Int32                    totalCustomToggleNum  // static @ 0x0
  public            System.Collections.Generic.List<Slate.CutsceneGroup.CustomToggleInfo>customToggle  // 0x50
  private           System.Boolean                  m_customToggleValid  // 0x58
  private           System.Boolean                  m_customToggleCheckDirty  // 0x59
  public            System.Collections.Generic.Dictionary<System.Int32,Slate.CutsceneGroup.CustomToggleInfo>customInfoCache  // 0x60
  private           Slate.IDirector                 <root>k__BackingField  // 0x68
PROPERTIES:
  name  get=-1  // abstract  set=-1  // abstract
  actor  get=-1  // abstract  set=-1  // abstract
  referenceMode  get=-1  // abstract  set=-1  // abstract
  initialTransformation  get=-1  // abstract  set=-1  // abstract
  initialLocalPosition  get=-1  // abstract  set=-1  // abstract
  initialLocalRotation  get=-1  // abstract  set=-1  // abstract
  displayVirtualMeshGizmo  get=-1  // abstract  set=-1  // abstract
  needActor  get=0x0232EB60
  updateOrder  get=0x03D5A950
  customToggleValid  get=0x0968F1A8
  tracks  get=0x03D4EB40  set=0x04271930
  sections  get=0x03D4EAC0  set=0x02C92F10
  Slate.IDirectable.children  get=0x0968E174
  Slate.IDirectable.startTime  get=0x03D503F0
  Slate.IDirectable.endTime  get=0x0968E1B0
  Slate.IDirectable.blendIn  get=0x03D503F0
  Slate.IDirectable.blendOut  get=0x03D503F0
  Slate.IDirectable.canCrossBlend  get=0x0115F4C0
  Slate.IDirectable.parent  get=0x01002730
  root  get=0x03D4EAB0  set=0x038C5570
  isActive  get=0x03D4F2C0  set=0x0968F2B0
  isCollapsed  get=0x03D4EF60  set=0x03D4EF70
  isLocked  get=0x0968F214  set=0x03D4F640
  isReadOnly  get=0x03D75040  set=0x03D75050
EVENTS:
  OnSectionReached  add=add_OnSectionReached  remove=remove_OnSectionReached
METHODS:
  RVA=0x0968DDB8  token=0x60003A2  System.Void SetCustomToggleDirty()
  RVA=0x0968E72C  token=0x60003A4  System.Void _OnCustomToggleValueChanged()
  RVA=0x0968D5E4  token=0x60003A5  System.Boolean CheckCustomCollapsed(System.Int32 index)
  RVA=0x0968E888  token=0x60003A6  System.Void _TryRefreshCustomToggleInfo()
  RVA=0x0968E2B8  token=0x60003BC  System.String ToString()
  RVA=0x0968E438  token=0x60003BD  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  RVA=0x0968D90C  token=0x60003BE  Slate.Section GetSectionByName(System.String name)
  RVA=0x0968DA5C  token=0x60003BF  Slate.Section GetSectionByUID(System.String UID)
  RVA=0x0968D774  token=0x60003C0  Slate.Section GetSectionAfter(System.Single time)
  RVA=0x0968D840  token=0x60003C1  Slate.Section GetSectionBefore(System.Single time)
  RVA=0x0968DE98  token=0x60003C2  System.Boolean Slate.IDirectable.Initialize()
  RVA=0x0968DDC4  token=0x60003C3  System.Void Slate.IDirectable.Enter()
  RVA=0x0968DFDC  token=0x60003C4  System.Void Slate.IDirectable.Reverse()
  RVA=0x0968E03C  token=0x60003C5  System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime)
  RVA=0x0968DE38  token=0x60003C6  System.Void Slate.IDirectable.Exit()
  RVA=0x0968DF7C  token=0x60003C7  System.Void Slate.IDirectable.ReverseEnter()
  RVA=0x0350B670  token=0x60003C8  System.Void Slate.IDirectable.RootEnabled()
  RVA=0x0350B670  token=0x60003C9  System.Void Slate.IDirectable.RootDisabled()
  RVA=0x0350B670  token=0x60003CA  System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime)
  RVA=0x0350B670  token=0x60003CB  System.Void Slate.IDirectable.RootDestroyed()
  RVA=0x0968E1CC  token=0x60003CC  System.Void StoreActorState()
  RVA=0x0968DC3C  token=0x60003CD  System.Void RestoreActorState()
  RVA=0x0968E2C8  token=0x60003CE  System.Void TryInstantiateLocalActor()
  RVA=0x0968DB2C  token=0x60003CF  System.Void ReleaseLocalActorInstance()
  RVA=0x0968DC8C  token=0x60003D0  System.Void SetActorLocalCoords()
  RVA=0x0968DBD0  token=0x60003D1  UnityEngine.GameObject ResolveActor(UnityEngine.GameObject original)
  RVA=0x0968EF6C  token=0x60003D2  System.Void .ctor()
  RVA=0x0968EF30  token=0x60003D3  System.Void .cctor()
END_CLASS

CLASS: Slate.CutsceneTrack
TYPE:  abstract class
TOKEN: 0x2000077
SIZE:  0x50
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: Slate.IDirectable
FIELDS:
  private           System.String                   _name  // 0x18
  private           UnityEngine.Color               _color  // 0x20
  private           System.Boolean                  _active  // 0x30
  private           System.Boolean                  _isLocked  // 0x31
  private           System.Collections.Generic.List<Slate.ActionClip>_actionClips  // 0x38
  private           System.Boolean                  _isReadOnly  // 0x40
  private           System.Int32                    <layerOrder>k__BackingField  // 0x44
  private           Slate.IDirectable               <parent>k__BackingField  // 0x48
PROPERTIES:
  actor  get=0x0968FE18
  name  get=0x0968FF78  set=0x0969005C
  color  get=0x0968FE38
  clips  get=0x03D4E2A0  set=0x0388FF30
  info  get=0x0968FE90
  Slate.IDirectable.children  get=0x0968FA64
  layerOrder  get=0x03D4EE80  set=0x03D4EEA0
  root  get=0x0968FFDC
  parent  get=0x03D4EA70  set=0x02692290
  isCollapsed  get=0x0968FEF4
  isActive  get=0x0968FEC8  set=0x0969001C
  isLocked  get=0x0968FF14  set=0x03D4F2D0
  startTime  get=0x0968FFFC  set=0x0350B670
  endTime  get=0x0968FE70  set=0x0350B670
  blendIn  get=0x03D503F0  set=0x0350B670
  blendOut  get=0x03D503F0  set=0x0350B670
  canCrossBlend  get=0x0115F4C0
  needActor  get=0x0968FFBC
  updateOrder  get=0x03D5A950
  isReadOnly  get=0x0968FF48  set=0x03D4EEB0
METHODS:
  RVA=0x0968FA20  token=0x6000407  System.Boolean Slate.IDirectable.Initialize()
  RVA=0x0968FA00  token=0x6000408  System.Void Slate.IDirectable.Enter()
  RVA=0x0968FA50  token=0x6000409  System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime)
  RVA=0x0968FA10  token=0x600040A  System.Void Slate.IDirectable.Exit()
  RVA=0x0968FA30  token=0x600040B  System.Void Slate.IDirectable.ReverseEnter()
  RVA=0x0968FA40  token=0x600040C  System.Void Slate.IDirectable.Reverse()
  RVA=0x0350B670  token=0x600040D  System.Void Slate.IDirectable.RootEnabled()
  RVA=0x0350B670  token=0x600040E  System.Void Slate.IDirectable.RootDisabled()
  RVA=0x0350B670  token=0x600040F  System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime)
  RVA=0x0350B670  token=0x6000410  System.Void Slate.IDirectable.RootDestroyed()
  RVA=0x0968F9D8  token=0x6000411  System.Void PostCreate(Slate.IDirectable parent)
  RVA=0x0968FB24  token=0x6000412  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  RVA=0x0350B670  token=0x6000413  System.Void OnCreate()
  RVA=0x0350B670  token=0x6000414  System.Void OnAfterValidate()
  RVA=0x0232EB60  token=0x6000415  System.Boolean OnInitialize()
  RVA=0x0350B670  token=0x6000416  System.Void OnEnter()
  RVA=0x0350B670  token=0x6000417  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0350B670  token=0x6000418  System.Void OnExit()
  RVA=0x0350B670  token=0x6000419  System.Void OnReverseEnter()
  RVA=0x0350B670  token=0x600041A  System.Void OnReverse()
  RVA=0x0350B670  token=0x600041B  System.Void OnDrawGizmosSelected()
  RVA=0x0350B670  token=0x600041C  System.Void OnSceneGUI()
  RVA=0x0350B670  token=0x600041D  System.Void OnRootEnabled()
  RVA=0x0350B670  token=0x600041E  System.Void OnRootDisabled()
  RVA=0x0350B670  token=0x600041F  System.Void OnRootUpdated(System.Single time, System.Single previousTime)
  RVA=0x0350B670  token=0x6000420  System.Void OnRootDestroyed()
  RVA=0x0968F940  token=0x6000421  System.Single GetTrackWeight()
  RVA=0x0968F8E4  token=0x6000422  System.Single GetTrackWeight(System.Single time)
  RVA=0x09670EB8  token=0x6000423  System.Single GetTrackWeight(System.Single time, System.Single blendInOut)
  RVA=0x09670ED4  token=0x6000424  System.Single GetTrackWeight(System.Single time, System.Single blendIn, System.Single blendOut)
  RVA=-1  // generic def  token=0x6000425  T AddAction(System.Single time)
  RVA=0x0968F604  token=0x6000426  Slate.ActionClip AddAction(System.Type type, System.Single time)
  RVA=0x0968FD80  token=0x6000427  System.Void .ctor()
  RVA=0x0968FAA0  token=0x6000428  System.Boolean <Validate>b__70_1(Slate.IDirectable t)
END_CLASS

CLASS: Slate.IAnimatableData
TYPE:  interface
TOKEN: 0x200007A
FIELDS:
PROPERTIES:
  isValid  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600042F  UnityEngine.AnimationCurve[] GetCurves()
  RVA=-1  // abstract  token=0x6000430  System.Void Validate(Slate.IKeyable keyable)
  RVA=-1  // abstract  token=0x6000431  System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent)
  RVA=-1  // abstract  token=0x6000432  System.Void SetSnapshot()
  RVA=-1  // abstract  token=0x6000433  System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight)
  RVA=-1  // abstract  token=0x6000434  System.Void RestoreSnapshot()
  RVA=-1  // abstract  token=0x6000435  System.Void SetKeyCurrent(System.Single time)
  RVA=-1  // abstract  token=0x6000436  System.Boolean TryAutoKey(System.Single time)
  RVA=-1  // abstract  token=0x6000437  System.Boolean TryKeyIdentity(System.Single time)
  RVA=-1  // abstract  token=0x6000438  System.Void RemoveKey(System.Single time)
  RVA=-1  // abstract  token=0x6000439  System.Boolean HasKey(System.Single time)
  RVA=-1  // abstract  token=0x600043A  System.Boolean HasAnyKey()
  RVA=-1  // abstract  token=0x600043B  System.Boolean HasChanged()
  RVA=-1  // abstract  token=0x600043C  System.Single GetKeyNext(System.Single time)
  RVA=-1  // abstract  token=0x600043D  System.Single GetKeyPrevious(System.Single time)
  RVA=-1  // abstract  token=0x600043E  System.String GetKeyLabel(System.Single time)
  RVA=-1  // abstract  token=0x600043F  System.Void SetPreWrapMode(UnityEngine.WrapMode mode)
  RVA=-1  // abstract  token=0x6000440  System.Void SetPostWrapMode(UnityEngine.WrapMode mode)
  RVA=-1  // abstract  token=0x6000441  System.Void Reset()
END_CLASS

CLASS: Slate.IDirectable
TYPE:  interface
TOKEN: 0x200007B
FIELDS:
PROPERTIES:
  root  get=-1  // abstract
  parent  get=-1  // abstract
  children  get=-1  // abstract
  actor  get=-1  // abstract
  name  get=-1  // abstract
  isActive  get=-1  // abstract
  isCollapsed  get=-1  // abstract
  isLocked  get=-1  // abstract
  startTime  get=-1  // abstract
  endTime  get=-1  // abstract
  blendIn  get=-1  // abstract
  blendOut  get=-1  // abstract
  canCrossBlend  get=-1  // abstract
  needActor  get=-1  // abstract
  updateOrder  get=-1  // abstract
  isReadOnly  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600044F  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  RVA=-1  // abstract  token=0x6000450  System.Boolean Initialize()
  RVA=-1  // abstract  token=0x6000451  System.Void Enter()
  RVA=-1  // abstract  token=0x6000452  System.Void Exit()
  RVA=-1  // abstract  token=0x6000453  System.Void Update(System.Single time, System.Single previousTime)
  RVA=-1  // abstract  token=0x6000454  System.Void ReverseEnter()
  RVA=-1  // abstract  token=0x6000455  System.Void Reverse()
  RVA=-1  // abstract  token=0x6000456  System.Void RootEnabled()
  RVA=-1  // abstract  token=0x6000457  System.Void RootUpdated(System.Single time, System.Single previousTime)
  RVA=-1  // abstract  token=0x6000458  System.Void RootDisabled()
  RVA=-1  // abstract  token=0x6000459  System.Void RootDestroyed()
END_CLASS

CLASS: Slate.IKeyable
TYPE:  interface
TOKEN: 0x200007C
IMPLEMENTS: Slate.IDirectable
FIELDS:
PROPERTIES:
  animationData  get=-1  // abstract
  animatedParametersTarget  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Slate.ISubClipContainable
TYPE:  interface
TOKEN: 0x200007D
IMPLEMENTS: Slate.IDirectable
FIELDS:
PROPERTIES:
  subClipOffset  get=-1  // abstract  set=-1  // abstract
  subClipSpeed  get=-1  // abstract
  subClipLength  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Slate.IDirectableExtensions
TYPE:  static class
TOKEN: 0x200007E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09692620  token=0x6000463  System.Single GetLength(Slate.IDirectable directable)
  RVA=0x09692E74  token=0x6000464  System.Single RootTimeToLocalTime(Slate.IDirectable directable)
  RVA=0x09692E38  token=0x6000465  System.Single RootTimeToLocalTimeUnclamped(Slate.IDirectable directable)
  RVA=0x09692DB0  token=0x6000466  System.Boolean IsRootTimeWithinClip(Slate.IDirectable directable)
  RVA=0x09692EE0  token=0x6000467  System.Single ToLocalTime(Slate.IDirectable directable, System.Single time)
  RVA=0x09692EB0  token=0x6000468  System.Single ToLocalTimeUnclamped(Slate.IDirectable directable, System.Single time)
  RVA=0x09692DEC  token=0x6000469  System.Boolean IsTimeWithinClip(Slate.IDirectable directable, System.Single time)
  RVA=0x09692338  token=0x600046A  System.Boolean CanCrossBlend(Slate.IDirectable directable, Slate.IDirectable other)
  RVA=0x09692148  token=0x600046B  System.Boolean CanBlendIn(Slate.IDirectable directable)
  RVA=0x09692240  token=0x600046C  System.Boolean CanBlendOut(Slate.IDirectable directable)
  RVA=0x096923C4  token=0x600046D  System.Boolean CanScale(Slate.IDirectable directable)
  RVA=0x09693124  token=0x600046E  System.Boolean WithinBufferTriggerRange(Slate.IDirectable directable, System.Single time, System.Single previousTime, System.Boolean bypass)
  RVA=0x096924AC  token=0x600046F  Slate.IDirectable FindChild(Slate.IDirectable directable, System.String name)
  RVA=-1  // generic def  token=0x6000470  T GetPreviousSibling(Slate.IDirectable directable)
  RVA=0x09692888  token=0x6000471  Slate.IDirectable GetPreviousSibling(Slate.IDirectable directable)
  RVA=-1  // generic def  token=0x6000472  T GetNextSibling(Slate.IDirectable directable)
  RVA=0x096926FC  token=0x6000473  Slate.IDirectable GetNextSibling(Slate.IDirectable directable)
  RVA=-1  // generic def  token=0x6000474  T GetFirstParentOfType(Slate.IDirectable directable)
  RVA=0x09692BB4  token=0x6000475  System.Single GetWeight(Slate.IDirectable directable)
  RVA=0x09692AC8  token=0x6000476  System.Single GetWeight(Slate.IDirectable directable, System.Single time)
  RVA=0x09670EB8  token=0x6000477  System.Single GetWeight(Slate.IDirectable directable, System.Single time, System.Single blendInOut)
  RVA=0x09692B20  token=0x6000478  System.Single GetWeight(Slate.IDirectable directable, System.Single time, System.Single blendIn, System.Single blendOut)
  RVA=0x09692984  token=0x6000479  UnityEngine.Transform GetSpaceTransform(Slate.IDirectable directable, Slate.TransformSpace space, UnityEngine.GameObject actorOverride)
  RVA=0x09692F40  token=0x600047A  UnityEngine.Vector3 TransformPosition(Slate.IDirectable directable, UnityEngine.Vector3 point, Slate.TransformSpace space)
  RVA=0x09692BD8  token=0x600047B  UnityEngine.Vector3 InverseTransformPosition(Slate.IDirectable directable, UnityEngine.Vector3 point, Slate.TransformSpace space)
  RVA=0x0969300C  token=0x600047C  UnityEngine.Quaternion TransformRotation(Slate.IDirectable directable, UnityEngine.Vector3 euler, Slate.TransformSpace space)
  RVA=0x09692CA4  token=0x600047D  UnityEngine.Vector3 InverseTransformRotation(Slate.IDirectable directable, UnityEngine.Quaternion rot, Slate.TransformSpace space)
  RVA=0x09692014  token=0x600047E  UnityEngine.Vector3 ActorPositionInSpace(Slate.IDirectable directable, Slate.TransformSpace space)
  RVA=0x096927F8  token=0x600047F  System.Single GetPreviousLoopLocalTime(Slate.ISubClipContainable clip)
  RVA=0x0969265C  token=0x6000480  System.Single GetNextLoopLocalTime(Slate.ISubClipContainable clip)
  RVA=0x09692594  token=0x6000481  UnityEngine.AnimationCurve[] GetCurvesAll(Slate.IKeyable keyable)
END_CLASS

CLASS: Slate.IDirector
TYPE:  interface
TOKEN: 0x2000082
FIELDS:
PROPERTIES:
  children  get=-1  // abstract
  context  get=-1  // abstract
  length  get=-1  // abstract
  currentTime  get=-1  // abstract  set=-1  // abstract
  previousTime  get=-1  // abstract
  playbackSpeed  get=-1  // abstract  set=-1  // abstract
  isActive  get=-1  // abstract
  isPaused  get=-1  // abstract
  isReSampleFrame  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000493  System.Collections.Generic.IEnumerable<UnityEngine.GameObject> GetAffectedActors()
  RVA=-1  // abstract  token=0x6000494  System.Void Play()
  RVA=-1  // abstract  token=0x6000495  System.Void Pause()
  RVA=-1  // abstract  token=0x6000496  System.Void Stop()
  RVA=-1  // abstract  token=0x6000497  System.Void Sample(System.Single time)
  RVA=-1  // abstract  token=0x6000498  System.Void ReSample()
  RVA=-1  // abstract  token=0x6000499  System.Void Validate()
  RVA=-1  // abstract  token=0x600049A  System.Void SendGlobalMessage(System.String message, System.Object value)
END_CLASS

CLASS: Slate.Section
TYPE:  class
TOKEN: 0x2000083
SIZE:  0x48
FIELDS:
  public    static readonly UnityEngine.Color               DEFAULT_COLOR  // static @ 0x0
  private           System.String                   _UID  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Single                   _time  // 0x20
  private           Slate.Section.ExitMode          _exitMode  // 0x24
  private           System.Int32                    _loopCount  // 0x28
  private           UnityEngine.Color               _color  // 0x2c
  private           System.Boolean                  _colorizeBackground  // 0x3c
  private           System.Int32                    <currentLoopIteration>k__BackingField  // 0x40
PROPERTIES:
  currentLoopIteration  get=0x03D4ED80  set=0x03D4EDB0
  UID  get=0x020B7B20  set=0x0426FEE0
  name  get=0x01041090  set=0x022C3A90
  time  get=0x03D4F2E0  set=0x03D4F2F0
  exitMode  get=0x03D4E2E0  set=0x03D4E2F0
  loopCount  get=0x03D4EB90  set=0x03D4EBA0
  color  get=0x096982A0  set=0x03D56F80
  colorizeBackground  get=0x03D4F460  set=0x03D4F470
METHODS:
  RVA=0x096981F0  token=0x60004AB  System.Void .ctor(System.String name, System.Single time)
  RVA=0x03D750C0  token=0x60004AC  System.Void ResetLoops()
  RVA=0x03D750B0  token=0x60004AD  System.Void BreakLoop()
  RVA=0x09698164  token=0x60004AE  System.Boolean TryUpdateLoop()
  RVA=0x096980F0  token=0x60004AF  System.String ToString()
  RVA=0x09698184  token=0x60004B0  System.Void .cctor()
END_CLASS

CLASS: Slate.IDirectableTimePointer
TYPE:  interface
TOKEN: 0x2000085
FIELDS:
PROPERTIES:
  target  get=-1  // abstract
  time  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60004B3  System.Void TriggerForward(System.Single currentTime, System.Single previousTime)
  RVA=-1  // abstract  token=0x60004B4  System.Void TriggerBackward(System.Single currentTime, System.Single previousTime)
  RVA=-1  // abstract  token=0x60004B5  System.Void Update(System.Single currentTime, System.Single previousTime)
END_CLASS

CLASS: Slate.StartTimePointer
TYPE:  sealed struct
TOKEN: 0x2000086
SIZE:  0x20
IMPLEMENTS: Slate.IDirectableTimePointer
FIELDS:
  private           System.Boolean                  triggered  // 0x10
  private           System.Single                   lastTargetStartTime  // 0x14
  private           Slate.IDirectable               <target>k__BackingField  // 0x18
PROPERTIES:
  target  get=0x03D50DE0  set=0x0558FF08
  Slate.IDirectableTimePointer.time  get=0x096995B8
METHODS:
  RVA=0x096995D4  token=0x60004B9  System.Void .ctor(Slate.IDirectable target)
  RVA=0x096993EC  token=0x60004BA  System.Void Slate.IDirectableTimePointer.TriggerForward(System.Single currentTime, System.Single previousTime)
  RVA=0x09699468  token=0x60004BB  System.Void Slate.IDirectableTimePointer.Update(System.Single currentTime, System.Single previousTime)
  RVA=0x09699350  token=0x60004BC  System.Void Slate.IDirectableTimePointer.TriggerBackward(System.Single currentTime, System.Single previousTime)
END_CLASS

CLASS: Slate.EndTimePointer
TYPE:  sealed struct
TOKEN: 0x2000087
SIZE:  0x20
IMPLEMENTS: Slate.IDirectableTimePointer
FIELDS:
  private           System.Boolean                  triggered  // 0x10
  private           Slate.IDirectable               <target>k__BackingField  // 0x18
PROPERTIES:
  target  get=0x03D50DE0  set=0x0558FF08
  Slate.IDirectableTimePointer.time  get=0x096919A4
METHODS:
  RVA=0x096919C0  token=0x60004C0  System.Void .ctor(Slate.IDirectable target)
  RVA=0x096918C4  token=0x60004C1  System.Void Slate.IDirectableTimePointer.TriggerForward(System.Single currentTime, System.Single previousTime)
  RVA=0x09691958  token=0x60004C2  System.Void Slate.IDirectableTimePointer.Update(System.Single currentTime, System.Single previousTime)
  RVA=0x0969183C  token=0x60004C3  System.Void Slate.IDirectableTimePointer.TriggerBackward(System.Single currentTime, System.Single previousTime)
END_CLASS

CLASS: Slate.BezierPath
TYPE:  class
TOKEN: 0x2000088
SIZE:  0x38
EXTENDS: Slate.Path
FIELDS:
  public            System.Int32                    resolution  // 0x18
  private           System.Collections.Generic.List<Slate.BezierPoint>_points  // 0x20
  private           UnityEngine.Vector3[]           _sampledPathPoints  // 0x28
  private           System.Single                   _length  // 0x30
PROPERTIES:
  points  get=0x03D4EB40
  Item  get=0x0968BA1C
  pointCount  get=0x0968BA70
  length  get=0x03D4F5D0
METHODS:
  RVA=0x0968B140  token=0x60004C8  System.Void Awake()
  RVA=0x0968B140  token=0x60004C9  System.Void OnValidate()
  RVA=0x0968B2DC  token=0x60004CA  System.Void Compute()
  RVA=0x0968B140  token=0x60004CB  System.Void SetDirty()
  RVA=0x0968B150  token=0x60004CC  System.Void ComputeLength()
  RVA=0x0968B170  token=0x60004CD  System.Void ComputeSampledPathPoints()
  RVA=0x0968B304  token=0x60004CE  Slate.BezierPath Create(UnityEngine.Transform targetParent)
  RVA=0x0968B058  token=0x60004CF  Slate.BezierPoint AddPointAt(UnityEngine.Vector3 position, System.Int32 index)
  RVA=0x0968B934  token=0x60004D0  System.Void RemovePoint(Slate.BezierPoint point)
  RVA=0x0968B5CC  token=0x60004D1  System.Int32 GetPointIndex(Slate.BezierPoint point)
  RVA=0x0968B828  token=0x60004D2  UnityEngine.Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, System.Int32 resolution)
  RVA=0x0968B758  token=0x60004D3  UnityEngine.Vector3 GetPositionAt(System.Single t)
  RVA=0x0968B650  token=0x60004D4  UnityEngine.Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, System.Single t)
  RVA=0x0968B994  token=0x60004D5  System.Void .ctor()
END_CLASS

CLASS: Slate.BezierPoint
TYPE:  class
TOKEN: 0x2000089
SIZE:  0x40
FIELDS:
  private           Slate.BezierPath                _path  // 0x10
  public            UnityEngine.Vector3             _position  // 0x18
  private           UnityEngine.Vector3             _handle1  // 0x24
  private           UnityEngine.Vector3             _handle2  // 0x30
  private           Slate.BezierPoint.HandleStyle   _handleStyle  // 0x3c
PROPERTIES:
  handleStyle  get=0x03D4ED90  set=0x03D4EDC0
  path  get=0x020B7B20  set=0x0426FEE0
  position  get=0x0968BC48  set=0x0968BFA0
  handle1LocalPosition  get=0x03D59780  set=0x0968BCB8
  handle2LocalPosition  get=0x03D51B80  set=0x0968BE2C
  handle1Position  get=0x0968BAF0  set=0x0968BD70
  handle2Position  get=0x0968BB9C  set=0x0968BEE4
METHODS:
  RVA=0x0968BAB0  token=0x60004D6  System.Void .ctor(Slate.BezierPath path, UnityEngine.Vector3 position)
END_CLASS

CLASS: Slate.Path
TYPE:  abstract class
TOKEN: 0x200008B
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
PROPERTIES:
  length  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x60004E6  UnityEngine.Vector3 GetPositionAt(System.Single t)
  RVA=-1  // abstract  token=0x60004E7  System.Void Compute()
  RVA=0x09693BF4  token=0x60004E8  UnityEngine.Vector3 GetPositionAlongCurve(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 fromTangent, UnityEngine.Vector3 toTangent, System.Single t)
  RVA=0x09693DEC  token=0x60004E9  UnityEngine.Vector3 GetPosition(System.Single t, UnityEngine.Vector3[] path)
  RVA=0x09693B48  token=0x60004EA  System.Single GetLength(UnityEngine.Vector3[] path)
  RVA=0x0426FE60  token=0x60004EB  System.Void .ctor()
END_CLASS

CLASS: Slate.AnimationDataUtility
TYPE:  static class
TOKEN: 0x200008C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0968A178  token=0x60004EC  System.String[] GetAnimatableMemberPaths(System.Object root)
  RVA=0x0968A1D4  token=0x60004ED  System.String[] Internal_GetAnimatableMemberPaths(System.Type type, System.String path)
END_CLASS

CLASS: Slate.AnimatorDispatcher
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Action<System.Int32>     onAnimatorIK  // 0x18
  private           UnityEngine.Animator            _animator  // 0x20
PROPERTIES:
  animator  get=0x0968A5EC
EVENTS:
  onAnimatorIK  add=add_onAnimatorIK  remove=remove_onAnimatorIK
METHODS:
  RVA=0x0968A54C  token=0x60004F1  System.Void OnAnimatorIK(System.Int32 index)
  RVA=0x0426FE60  token=0x60004F2  System.Void .ctor()
END_CLASS

CLASS: Slate.AudioSampler
TYPE:  static class
TOKEN: 0x200008E
SIZE:  0x10
FIELDS:
  private   static  System.String                   ROOT_NAME  // const
  private   static  UnityEngine.GameObject          root  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Object,UnityEngine.AudioSource>sources  // static @ 0x8
METHODS:
  RVA=0x0968A704  token=0x60004F3  UnityEngine.AudioSource GetSourceForID(System.Object keyID)
  RVA=0x0968A9E0  token=0x60004F4  System.Void ReleaseSourceForID(System.Object keyID)
  RVA=0x0968AB6C  token=0x60004F5  System.Void SampleForID(System.Object keyID, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, System.Single volume)
  RVA=0x0968AC30  token=0x60004F6  System.Void SampleForID(System.Object keyID, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, Slate.AudioSampler.SampleSettings settings)
  RVA=0x0968ACD4  token=0x60004F7  System.Void Sample(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, System.Single volume)
  RVA=0x0968AD98  token=0x60004F8  System.Void Sample(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, Slate.AudioSampler.SampleSettings settings)
  RVA=0x0968AFC4  token=0x60004F9  System.Void .cctor()
END_CLASS

CLASS: Slate.ColorUtility
TYPE:  static class
TOKEN: 0x2000090
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D71F80  token=0x60004FB  UnityEngine.Color Grey(System.Single value)
  RVA=0x03D71FA0  token=0x60004FC  UnityEngine.Color WithAlpha(UnityEngine.Color color, System.Single alpha)
END_CLASS

CLASS: Slate.TangentMode
TYPE:  sealed struct
TOKEN: 0x2000091
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.TangentMode               Editable  // const
  public    static  Slate.TangentMode               Smooth  // const
  public    static  Slate.TangentMode               Linear  // const
  public    static  Slate.TangentMode               Constant  // const
METHODS:
END_CLASS

CLASS: Slate.CurveUtility
TYPE:  static class
TOKEN: 0x2000092
SIZE:  0x10
FIELDS:
  private   static  System.Single                   KEY_PROXIMITY_TOLERANCE  // const
METHODS:
  RVA=0x0968CB4C  token=0x60004FD  System.Single GetKeyNext(System.Single time, UnityEngine.AnimationCurve[] curves)
  RVA=0x0968CD98  token=0x60004FE  System.Single GetKeyPrevious(System.Single time, UnityEngine.AnimationCurve[] curves)
  RVA=0x0968D054  token=0x60004FF  System.Boolean HasKey(System.Single time, UnityEngine.AnimationCurve[] curves)
  RVA=0x0968D000  token=0x6000500  System.Boolean HasAnyKey(UnityEngine.AnimationCurve[] curves)
  RVA=0x0968D288  token=0x6000501  System.Void OffsetCurveValue(UnityEngine.AnimationCurve curve, System.Single deltaValue)
  RVA=0x0968D198  token=0x6000502  System.Void OffsetCurveTime(UnityEngine.AnimationCurve curve, System.Single deltaTime)
  RVA=0x0968D468  token=0x6000503  System.Void RemoveNegativeKeys(UnityEngine.AnimationCurve curve)
  RVA=0x0968D328  token=0x6000504  System.Void RemoveKeysOffRange(UnityEngine.AnimationCurve curve, System.Single min, System.Single max)
END_CLASS

CLASS: Slate.DecoratorAttribute
TYPE:  class
TOKEN: 0x2000097
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type                     targetType  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x600050F  System.Void .ctor(System.Type targetType)
END_CLASS

CLASS: Slate.IDecorator
TYPE:  interface
TOKEN: 0x2000098
FIELDS:
PROPERTIES:
  Target  get=-1  // abstract  set=-1  // abstract
METHODS:
END_CLASS

CLASS: Slate.DecoratorFactory
TYPE:  static class
TOKEN: 0x2000099
SIZE:  0x10
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type>decoratorsTypeMap  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Object,Slate.IDecorator>decoratorsInstanceMap  // static @ 0x8
METHODS:
  RVA=-1  // generic def  token=0x6000512  T Decorator(System.Object target)
  RVA=-1  // generic def  token=0x6000513  T GetDecorator(System.Object target)
  RVA=-1  // generic def  token=0x6000514  T CreateDecorator(System.Type targetType)
  RVA=0x096900A4  token=0x6000515  System.Void .cctor()
END_CLASS

CLASS: Slate.EaseType
TYPE:  sealed struct
TOKEN: 0x200009A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.EaseType                  Linear  // const
  public    static  Slate.EaseType                  QuadraticIn  // const
  public    static  Slate.EaseType                  QuadraticOut  // const
  public    static  Slate.EaseType                  QuadraticInOut  // const
  public    static  Slate.EaseType                  QuarticIn  // const
  public    static  Slate.EaseType                  QuarticOut  // const
  public    static  Slate.EaseType                  QuarticInOut  // const
  public    static  Slate.EaseType                  QuinticIn  // const
  public    static  Slate.EaseType                  QuinticOut  // const
  public    static  Slate.EaseType                  QuinticInOut  // const
  public    static  Slate.EaseType                  CubicIn  // const
  public    static  Slate.EaseType                  CubicOut  // const
  public    static  Slate.EaseType                  CubicInOut  // const
  public    static  Slate.EaseType                  ExponentialIn  // const
  public    static  Slate.EaseType                  ExponentialOut  // const
  public    static  Slate.EaseType                  ExponentialInOut  // const
  public    static  Slate.EaseType                  CircularIn  // const
  public    static  Slate.EaseType                  CircularOut  // const
  public    static  Slate.EaseType                  CircularInOut  // const
  public    static  Slate.EaseType                  SinusoidalIn  // const
  public    static  Slate.EaseType                  SinusoidalOut  // const
  public    static  Slate.EaseType                  SinusoidalInOut  // const
  public    static  Slate.EaseType                  ElasticIn  // const
  public    static  Slate.EaseType                  ElasticOut  // const
  public    static  Slate.EaseType                  ElasticInOut  // const
  public    static  Slate.EaseType                  BounceIn  // const
  public    static  Slate.EaseType                  BounceOut  // const
  public    static  Slate.EaseType                  BounceInOut  // const
  public    static  Slate.EaseType                  BackIn  // const
  public    static  Slate.EaseType                  BackOut  // const
  public    static  Slate.EaseType                  BackInOut  // const
METHODS:
END_CLASS

CLASS: Slate.Easing
TYPE:  static class
TOKEN: 0x200009B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09690E24  token=0x6000516  System.Single Ease(Slate.EaseType type, System.Single from, System.Single to, System.Single t)
  RVA=0x09691028  token=0x6000517  UnityEngine.Vector3 Ease(Slate.EaseType type, UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t)
  RVA=0x09690EA8  token=0x6000518  UnityEngine.Quaternion Ease(Slate.EaseType type, UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single t)
  RVA=0x09690F6C  token=0x6000519  UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, System.Single t)
  RVA=0x0969110C  token=0x600051A  System.Func<System.Single,System.Single> Function(Slate.EaseType type)
  RVA=0x0350B670  token=0x600051B  System.Single Linear(System.Single t)
  RVA=0x03D51490  token=0x600051C  System.Single QuadraticIn(System.Single t)
  RVA=0x03D721C0  token=0x600051D  System.Single QuadraticOut(System.Single t)
  RVA=0x093BB5FC  token=0x600051E  System.Single QuadraticInOut(System.Single t)
  RVA=0x03D721E0  token=0x600051F  System.Single QuarticIn(System.Single t)
  RVA=0x03D721F0  token=0x6000520  System.Single QuarticOut(System.Single t)
  RVA=0x093BB658  token=0x6000521  System.Single QuarticInOut(System.Single t)
  RVA=0x03D72220  token=0x6000522  System.Single QuinticIn(System.Single t)
  RVA=0x03D72240  token=0x6000523  System.Single QuinticOut(System.Single t)
  RVA=0x093BB6AC  token=0x6000524  System.Single QuinticInOut(System.Single t)
  RVA=0x03D525D0  token=0x6000525  System.Single CubicIn(System.Single t)
  RVA=0x03D720B0  token=0x6000526  System.Single CubicOut(System.Single t)
  RVA=0x093BA9AC  token=0x6000527  System.Single CubicInOut(System.Single t)
  RVA=0x093BB708  token=0x6000528  System.Single SinusoidalIn(System.Single t)
  RVA=0x093BB738  token=0x6000529  System.Single SinusoidalOut(System.Single t)
  RVA=0x03D72270  token=0x600052A  System.Single SinusoidalInOut(System.Single t)
  RVA=0x093BAE5C  token=0x600052B  System.Single ExponentialIn(System.Single t)
  RVA=0x093BAE88  token=0x600052C  System.Single ExponentialOut(System.Single t)
  RVA=0x093BADDC  token=0x600052D  System.Single ExponentialInOut(System.Single t)
  RVA=0x03D72020  token=0x600052E  System.Single CircularIn(System.Single t)
  RVA=0x03D72080  token=0x600052F  System.Single CircularOut(System.Single t)
  RVA=0x093BA948  token=0x6000530  System.Single CircularInOut(System.Single t)
  RVA=0x03D720D0  token=0x6000531  System.Single ElasticIn(System.Single t)
  RVA=0x03D72150  token=0x6000532  System.Single ElasticOut(System.Single t)
  RVA=0x093BACFC  token=0x6000533  System.Single ElasticInOut(System.Single t)
  RVA=0x093BA87C  token=0x6000534  System.Single BounceIn(System.Single t)
  RVA=0x093BA8B0  token=0x6000535  System.Single BounceOut(System.Single t)
  RVA=0x093BA810  token=0x6000536  System.Single BounceInOut(System.Single t)
  RVA=0x03D71FD0  token=0x6000537  System.Single BackIn(System.Single t)
  RVA=0x03D71FF0  token=0x6000538  System.Single BackOut(System.Single t)
  RVA=0x093BA7A8  token=0x6000539  System.Single BackInOut(System.Single t)
END_CLASS

CLASS: Slate.ITransformRefParameter
TYPE:  interface
TOKEN: 0x200009C
FIELDS:
PROPERTIES:
  transform  get=-1  // abstract
  space  get=-1  // abstract
  useAnimation  get=-1  // abstract
METHODS:
END_CLASS

CLASS: Slate.ObjectSnapshot
TYPE:  class
TOKEN: 0x200009D
SIZE:  0x18
FIELDS:
  private   static  System.Collections.Generic.List<System.Type>ignoreTypes  // static @ 0x0
  private           System.Collections.Generic.Dictionary<UnityEngine.Object,System.String>serialized  // 0x10
METHODS:
  RVA=0x09693470  token=0x600053D  System.Void AppendIgnoreType(System.Type type)
  RVA=0x09693AA8  token=0x600053E  System.Void .ctor(UnityEngine.Object target, System.Boolean fullObjectHierarchy)
  RVA=0x09693760  token=0x600053F  System.Void Store(UnityEngine.Object target, System.Boolean fullObjectHierarchy)
  RVA=0x09693520  token=0x6000540  System.Void Restore()
  RVA=0x09693A1C  token=0x6000541  System.Void .cctor()
END_CLASS

CLASS: Slate.RectUtility
TYPE:  static class
TOKEN: 0x200009E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x093AB5C4  token=0x6000542  UnityEngine.Rect GetBoundRect(UnityEngine.Rect[] rects)
  RVA=0x093AB6E4  token=0x6000543  UnityEngine.Rect GetBoundRect(UnityEngine.Vector2[] positions)
  RVA=0x09695A80  token=0x6000544  System.Boolean Encapsulates(UnityEngine.Rect a, UnityEngine.Rect b)
  RVA=0x09695B9C  token=0x6000545  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single margin)
  RVA=0x09695B38  token=0x6000546  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single xMargin, System.Single yMargin)
  RVA=0x093AB874  token=0x6000547  UnityEngine.Rect TransformSpace(UnityEngine.Rect rect, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer)
  RVA=0x09695BD8  token=0x6000548  UnityEngine.Rect ToViewRect(UnityEngine.Bounds b, UnityEngine.Camera cam)
END_CLASS

CLASS: Slate.ReflectionTools
TYPE:  static class
TOKEN: 0x200009F
SIZE:  0x10
FIELDS:
  private   static  System.Reflection.BindingFlags  flagsEverything  // const
  private   static  System.Collections.Generic.List<System.Reflection.Assembly>_loadedAssemblies  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,System.Type>typeMap  // static @ 0x8
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type[]>subTypesMap  // static @ 0x10
PROPERTIES:
  loadedAssemblies  get=0x09698020
METHODS:
  RVA=0x0969728C  token=0x600054A  System.Type GetType(System.String typeName)
  RVA=0x0969643C  token=0x600054B  System.Type[] GetAllTypes()
  RVA=0x0969668C  token=0x600054C  System.Type[] GetImplementationsOf(System.Type type)
  RVA=0x09697868  token=0x600054D  System.Type[] RTGetExportedTypes(System.Reflection.Assembly asm)
  RVA=0x0969634C  token=0x600054E  System.String FriendlyName(System.Type type)
  RVA=0x09697CF0  token=0x600054F  System.Boolean RTIsStatic(System.Reflection.PropertyInfo propertyInfo)
  RVA=0x0939B954  token=0x6000550  System.Boolean RTIsAbstract(System.Type type)
  RVA=0x0939BBB0  token=0x6000551  System.Boolean RTIsSubclassOf(System.Type type, System.Type other)
  RVA=0x09697CCC  token=0x6000552  System.Boolean RTIsAssignableFrom(System.Type type, System.Type second)
  RVA=0x09697B38  token=0x6000553  System.Reflection.FieldInfo RTGetField(System.Type type, System.String name)
  RVA=0x09697CA8  token=0x6000554  System.Reflection.PropertyInfo RTGetProperty(System.Type type, System.String name)
  RVA=0x09697C60  token=0x6000555  System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name)
  RVA=0x09697C3C  token=0x6000556  System.Reflection.FieldInfo[] RTGetFields(System.Type type)
  RVA=0x09697C84  token=0x6000557  System.Reflection.PropertyInfo[] RTGetProperties(System.Type type)
  RVA=0x0939B3A4  token=0x6000558  System.Reflection.MethodInfo RTGetGetMethod(System.Reflection.PropertyInfo prop)
  RVA=0x0939B938  token=0x6000559  System.Reflection.MethodInfo RTGetSetMethod(System.Reflection.PropertyInfo prop)
  RVA=0x09697DA0  token=0x600055A  System.Type RTReflectedType(System.Type type)
  RVA=0x09697DA0  token=0x600055B  System.Type RTReflectedType(System.Reflection.MemberInfo member)
  RVA=-1  // generic def  token=0x600055C  T RTGetAttribute(System.Type type, System.Boolean inherited)
  RVA=-1  // generic def  token=0x600055D  T RTGetAttribute(System.Reflection.MemberInfo member, System.Boolean inherited)
  RVA=-1  // generic def  token=0x600055E  System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Boolean inherited)
  RVA=-1  // generic def  token=0x600055F  T RTCreateDelegate(System.Reflection.MethodInfo method, System.Object instance)
  RVA=-1  // generic def  token=0x6000560  System.Action<T,TValue> GetFieldOrPropSetter(System.Reflection.MemberInfo info)
  RVA=0x09697B5C  token=0x6000561  System.Reflection.MemberInfo[] RTGetFieldsAndProps(System.Type type)
  RVA=0x09697AA8  token=0x6000562  System.Reflection.MemberInfo RTGetFieldOrProp(System.Type type, System.String name)
  RVA=0x0969794C  token=0x6000563  System.Object RTGetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Int32 index)
  RVA=0x09697DC0  token=0x6000564  System.Void RTSetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Object value, System.Int32 index)
  RVA=0x09697888  token=0x6000565  System.Type RTGetFieldOrPropType(System.Reflection.MemberInfo member)
  RVA=0x09697218  token=0x6000566  System.Reflection.MemberInfo GetRelativeMember(System.Object root, System.String path)
  RVA=0x096970C4  token=0x6000567  System.Reflection.MemberInfo GetRelativeMember(System.Type type, System.String path)
  RVA=0x09696F80  token=0x6000568  System.Object GetRelativeMemberParent(System.Object root, System.String path)
  RVA=-1  // generic def  token=0x6000569  System.String GetMemberPath(System.Linq.Expressions.Expression<System.Func<T,TResult>> func)
  RVA=0x09696B3C  token=0x600056A  System.String[] GetMemberPaths(System.Type type, System.Predicate<System.Type> shouldInclude, System.Predicate<System.Type> shouldContinue, System.String currentPath, System.Collections.Generic.List<System.Type> recursionCheck)
  RVA=0x09697F24  token=0x600056B  System.Void .cctor()
END_CLASS

CLASS: Slate.StringUtility
TYPE:  static class
TOKEN: 0x20000A2
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x096999D8  token=0x6000570  System.String SplitCamelCase(System.String s)
  RVA=0x096998FC  token=0x6000571  System.String AbsToRelativePath(System.String absolutepath)
END_CLASS

CLASS: Slate.TransformRefPosition
TYPE:  sealed struct
TOKEN: 0x20000A3
SIZE:  0x30
IMPLEMENTS: Slate.ITransformRefParameter
FIELDS:
  private           Slate.CutsceneGroup             _group  // 0x10
  private           UnityEngine.Transform           _transform  // 0x18
  private           UnityEngine.Vector3             _vector  // 0x20
  private           Slate.TransformSpace            _space  // 0x2c
PROPERTIES:
  useAnimation  get=0x09699FB4
  group  get=0x020C61B0  set=0x042715A0
  transform  get=0x09699EFC  set=0x0558FF08
  value  get=0x0969A060  set=0x03D55570
  space  get=0x09699ED8  set=0x03D4EBC0
METHODS:
  RVA=0x09699E50  token=0x600057B  System.String ToString()
END_CLASS

CLASS: Slate.TransformRefPositionRotation
TYPE:  sealed struct
TOKEN: 0x20000A4
SIZE:  0x40
IMPLEMENTS: Slate.ITransformRefParameter
FIELDS:
  private           Slate.CutsceneGroup             _group  // 0x10
  private           UnityEngine.Transform           _transform  // 0x18
  private           UnityEngine.Vector3             _position  // 0x20
  private           UnityEngine.Vector3             _rotation  // 0x2c
  private           Slate.TransformSpace            _space  // 0x38
PROPERTIES:
  useAnimation  get=0x09699DA4
  group  get=0x020C61B0  set=0x042715A0
  transform  get=0x09699CEC  set=0x0558FF08
  position  get=0x09699BF0  set=0x03D55570
  rotation  get=0x09699C5C  set=0x03D5CBC0
  space  get=0x09699CC8  set=0x03D4EBA0
METHODS:
  RVA=0x09699B38  token=0x6000587  System.String ToString()
END_CLASS

CLASS: Slate.TransformSnapshot
TYPE:  class
TOKEN: 0x20000A5
SIZE:  0x18
FIELDS:
  private           System.Collections.Generic.List<Slate.TransformSnapshot.TransformData>data  // 0x10
METHODS:
  RVA=0x0969A5E0  token=0x6000588  System.Void .ctor(UnityEngine.GameObject root, Slate.TransformSnapshot.StoreMode mode)
  RVA=0x0969A23C  token=0x6000589  System.Void Store(UnityEngine.GameObject root, Slate.TransformSnapshot.StoreMode mode)
  RVA=0x0969A0CC  token=0x600058A  System.Void Restore()
END_CLASS

CLASS: Slate.UnityObjectUtility
TYPE:  static class
TOKEN: 0x20000A8
SIZE:  0x10
FIELDS:
  private   static  System.Reflection.MethodInfo    _getLocalEulerAngles  // static @ 0x0
  private   static  System.Reflection.MethodInfo    _setLocalEulerAngles  // static @ 0x8
  private   static  System.Reflection.PropertyInfo  _rotationOrder  // static @ 0x10
  private   static  System.Object[]                 _rotationOrderArgGet  // static @ 0x18
  private   static  System.Object[]                 _rotationOrderArgSet  // static @ 0x20
METHODS:
  RVA=0x0969BCC4  token=0x600058C  System.Void .cctor()
  RVA=0x0969B6E8  token=0x600058D  UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.Transform transform)
  RVA=0x0969BB64  token=0x600058E  System.Void SetLocalEulerAngles(UnityEngine.Transform transform, UnityEngine.Vector3 value)
  RVA=0x0969B19C  token=0x600058F  System.String CalculateTransformPath(UnityEngine.Transform root, UnityEngine.Transform child)
  RVA=0x0969B984  token=0x6000590  UnityEngine.Transform ResolveTransformPath(UnityEngine.Transform root, System.String path)
  RVA=0x0969B350  token=0x6000591  UnityEngine.Transform FindInChildren(UnityEngine.Transform root, System.String name, System.Boolean includeHidden)
  RVA=0x0969B8E0  token=0x6000592  System.Void ResetLocalCoords(UnityEngine.Transform transform, System.Boolean includeScale)
  RVA=0x0969BAA8  token=0x6000593  System.Void SetLocalCoordsFrom(UnityEngine.Transform transform, UnityEngine.Transform source)
  RVA=0x0969B808  token=0x6000594  UnityEngine.Transform InsertParentInChain(UnityEngine.Transform transform, System.String name)
  RVA=-1  // generic def  token=0x6000595  T GetAddComponent(UnityEngine.GameObject go)
  RVA=-1  // generic def  token=0x6000596  T GetAddComponent(UnityEngine.Component comp)
  RVA=0x0969B48C  token=0x6000597  UnityEngine.Component GetAddComponent(UnityEngine.GameObject go, System.Type type)
  RVA=0x0969B5E0  token=0x6000598  System.Collections.Generic.List<System.String> GetBlendShapeNames(UnityEngine.SkinnedMeshRenderer skinnedMesh)
  RVA=0x0969B51C  token=0x6000599  System.Int32 GetBlendShapeIndex(UnityEngine.SkinnedMeshRenderer skinnedMesh, System.String shapeName)
END_CLASS

CLASS: Slate.VideoSampler
TYPE:  static class
TOKEN: 0x20000AA
SIZE:  0x10
FIELDS:
  private   static  System.String                   ROOT_NAME  // const
  private   static  UnityEngine.GameObject          root  // static @ 0x0
  private   static  System.Collections.Generic.Dictionary<System.Object,UnityEngine.Video.VideoPlayer>sources  // static @ 0x8
METHODS:
  RVA=0x0969BE8C  token=0x600059C  UnityEngine.Video.VideoPlayer GetSourceForID(System.Object keyID)
  RVA=0x0969C1D4  token=0x600059D  System.Void ReleaseSourceForID(System.Object keyID)
  RVA=0x0969C388  token=0x600059E  System.Void SampleForID(System.Object keyID, UnityEngine.Video.VideoClip clip, System.Single time, System.Single previousTime, Slate.VideoSampler.SampleSettings settings)
  RVA=0x0969C42C  token=0x600059F  System.Void Sample(UnityEngine.Video.VideoPlayer source, UnityEngine.Video.VideoClip clip, System.Single time, System.Single previousTime, Slate.VideoSampler.SampleSettings settings)
  RVA=0x0969C62C  token=0x60005A0  System.Void .cctor()
END_CLASS

CLASS: Slate.CutsceneSequencePlayer
TYPE:  class
TOKEN: 0x20000AD
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  playOnStart  // 0x18
  public            System.Collections.Generic.List<Slate.Cutscene>cutscenes  // 0x20
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x28
  private           System.Int32                    currentIndex  // 0x30
  private           System.Boolean                  isPlaying  // 0x34
METHODS:
  RVA=0x0968F584  token=0x60005A2  System.Void Start()
  RVA=0x0968F4B0  token=0x60005A3  System.Void Play()
  RVA=0x0968F594  token=0x60005A4  System.Void Stop()
  RVA=0x0968F34C  token=0x60005A5  System.Void MoveNext()
  RVA=0x0968F2CC  token=0x60005A6  UnityEngine.GameObject Create()
  RVA=0x042726E8  token=0x60005A7  System.Void .ctor()
  RVA=0x0968F5FC  token=0x60005A8  System.Void <MoveNext>b__8_0()
END_CLASS

CLASS: Slate.DirectorGUITemplate
TYPE:  class
TOKEN: 0x20000AE
SIZE:  0x98
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  dontDestroyOnLoad  // 0x18
  public            UnityEngine.UI.CanvasScaler     absScaler  // 0x20
  public            UnityEngine.UI.CanvasScaler     refScaler  // 0x28
  public            UnityEngine.CanvasGroup         cameraDissolveGroup  // 0x30
  public            UnityEngine.UI.RawImage         dissolverImage  // 0x38
  public            UnityEngine.CanvasGroup         letterboxGroup  // 0x40
  public            UnityEngine.UI.RawImage         letterboxTop  // 0x48
  public            UnityEngine.UI.RawImage         letterboxBottom  // 0x50
  public            UnityEngine.CanvasGroup         screenFadeGroup  // 0x58
  public            UnityEngine.UI.RawImage         screenFadeImage  // 0x60
  public            UnityEngine.CanvasGroup         overlayImageGroup  // 0x68
  public            UnityEngine.UI.RawImage         overlayImage  // 0x70
  public            UnityEngine.CanvasGroup         overlayTextGroup  // 0x78
  public            UnityEngine.UI.Text             overlayText  // 0x80
  public            UnityEngine.CanvasGroup         subtitlesGroup  // 0x88
  public            UnityEngine.UI.Text             subtitlesText  // 0x90
  private   static  Slate.DirectorGUITemplate       _current  // static @ 0x0
METHODS:
  RVA=0x09690198  token=0x60005A9  System.Void Awake()
  RVA=0x09690D28  token=0x60005AA  System.Void ShowAll()
  RVA=0x096902B8  token=0x60005AB  System.Void HideAll()
  RVA=0x0969064C  token=0x60005AC  System.Void OnEnable()
  RVA=0x09690430  token=0x60005AD  System.Void OnDisable()
  RVA=0x09690DD0  token=0x60005AE  System.Void Update()
  RVA=0x09690348  token=0x60005AF  System.Void OnCameraDissolve(UnityEngine.Texture texture, System.Single completion)
  RVA=0x09690868  token=0x60005B0  System.Void OnImageOverlayGUI(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position)
  RVA=0x096909D0  token=0x60005B1  System.Void OnLetterboxGUI(System.Single completion)
  RVA=0x09690B60  token=0x60005B2  System.Void OnScreenFadeGUI(UnityEngine.Color color)
  RVA=0x09690C3C  token=0x60005B3  System.Void OnTextOverlayGUI(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 position)
  RVA=0x09690BB8  token=0x60005B4  System.Void OnSubtitlesGUI(System.String text, UnityEngine.Color color)
  RVA=0x042726E8  token=0x60005B5  System.Void .ctor()
END_CLASS

CLASS: Slate.PlayCutsceneOnClick
TYPE:  class
TOKEN: 0x20000AF
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Single                   startTime  // 0x20
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x28
METHODS:
  RVA=0x096953CC  token=0x60005B6  System.Void OnMouseDown()
  RVA=0x096954E0  token=0x60005B7  System.Void Reset()
  RVA=0x0969535C  token=0x60005B8  UnityEngine.GameObject Create()
  RVA=0x0426FE60  token=0x60005B9  System.Void .ctor()
  RVA=0x09695580  token=0x60005BA  System.Void <OnMouseDown>b__3_0()
END_CLASS

CLASS: Slate.PlayCutsceneOnStart
TYPE:  class
TOKEN: 0x20000B0
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Single                   startTime  // 0x20
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x28
METHODS:
  RVA=0x0969562C  token=0x60005BB  System.Void Start()
  RVA=0x096955A0  token=0x60005BC  UnityEngine.GameObject Create()
  RVA=0x0426FE60  token=0x60005BD  System.Void .ctor()
  RVA=0x09695580  token=0x60005BE  System.Void <Start>b__3_0()
END_CLASS

CLASS: Slate.PlayCutsceneOnTrigger
TYPE:  class
TOKEN: 0x20000B1
SIZE:  0x40
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Single                   startTime  // 0x20
  public            System.Boolean                  checkSpecificTagOnly  // 0x24
  public            System.String                   tagName  // 0x28
  public            System.Boolean                  once  // 0x30
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x38
METHODS:
  RVA=0x096957CC  token=0x60005BF  System.Void OnTriggerEnter(UnityEngine.Collider other)
  RVA=0x09695944  token=0x60005C0  System.Void Reset()
  RVA=0x09695740  token=0x60005C1  UnityEngine.GameObject Create()
  RVA=0x09695A34  token=0x60005C2  System.Void .ctor()
  RVA=0x096959BC  token=0x60005C3  System.Void <OnTriggerEnter>b__6_0()
END_CLASS

CLASS: Slate.StopCutsceneOnClick
TYPE:  class
TOKEN: 0x20000B2
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            Slate.Cutscene.StopMode         stopMode  // 0x20
METHODS:
  RVA=0x09699610  token=0x60005C4  System.Void OnMouseDown()
  RVA=0x096996C4  token=0x60005C5  System.Void Reset()
  RVA=0x0426FE60  token=0x60005C6  System.Void .ctor()
END_CLASS

CLASS: Slate.StopCutsceneOnTrigger
TYPE:  class
TOKEN: 0x20000B3
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Boolean                  checkSpecificTagOnly  // 0x20
  public            System.String                   tagName  // 0x28
  public            Slate.Cutscene.StopMode         stopMode  // 0x30
METHODS:
  RVA=0x09699724  token=0x60005C7  System.Void OnTriggerEnter(UnityEngine.Collider other)
  RVA=0x09699838  token=0x60005C8  System.Void Reset()
  RVA=0x096998B0  token=0x60005C9  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ActorActionClip
TYPE:  abstract class
TOKEN: 0x20000B4
SIZE:  0x40
EXTENDS: Slate.ActionClip
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x60005CA  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ActorActionClip`1
TYPE:  abstract class
TOKEN: 0x20000B5
EXTENDS: Slate.ActionClip
FIELDS:
  private           T                               _actorComponent  // 0x0
PROPERTIES:
  actor  get=-1  // not resolved
  isValid  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60005CD  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateProperties
TYPE:  class
TOKEN: 0x20000B6
SIZE:  0x60
EXTENDS: Slate.ActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  protected         System.String                   _name  // 0x50
  public            Slate.EaseType                  interpolation  // 0x58
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  isValid  get=0x096719D8
  info  get=0x0968A108
  animatedParametersTarget  get=0x0968A100
  animatedParametersInterpolation  get=0x03D4EF00
  useWeightInParameters  get=0x0232EB60
METHODS:
  RVA=0x0968A0E8  token=0x60005D9  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateBlendShape
TYPE:  class
TOKEN: 0x20000B7
SIZE:  0x78
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  private           System.String                   _skinName  // 0x50
  private           System.String                   _shapeName  // 0x58
  public            System.Single                   weight  // 0x60
  private           System.Single                   originalWeight  // 0x64
  private           System.Int32                    index  // 0x68
  private           UnityEngine.SkinnedMeshRenderer _skinnedMesh  // 0x70
PROPERTIES:
  info  get=0x096892A0
  isValid  get=0x096892E0
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  canCrossBlend  get=0x0232EB60
  skinName  get=0x03D4EAF0  set=0x096894E0
  shapeName  get=0x03D4EAA0  set=0x03081D30
  skinnedMesh  get=0x09689388
METHODS:
  RVA=0x0968909C  token=0x60005E8  System.Void OnEnter()
  RVA=0x096891BC  token=0x60005E9  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x09689180  token=0x60005EA  System.Void OnReverse()
  RVA=0x0968927C  token=0x60005EB  System.Void .ctor()
  RVA=0x09689244  token=0x60005EC  System.Boolean <get_skinnedMesh>b__31_0(UnityEngine.SkinnedMeshRenderer s)
END_CLASS

CLASS: Slate.ActionClips.CharacterExpression
TYPE:  class
TOKEN: 0x20000B8
SIZE:  0x78
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   expressionName  // 0x58
  public            System.String                   expressionUID  // 0x60
  public            System.Single                   weight  // 0x68
  private           System.Single                   originalWeight  // 0x6c
  private           Slate.BlendShapeGroup           expression  // 0x70
PROPERTIES:
  info  get=0x0968C1D0
  isValid  get=0x0968C284
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
  canCrossBlend  get=0x0232EB60
METHODS:
  RVA=0x0968C0F4  token=0x60005F6  Slate.BlendShapeGroup ResolveExpression()
  RVA=0x0968C00C  token=0x60005F7  System.Void OnEnter()
  RVA=0x0968C084  token=0x60005F8  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x0968C040  token=0x60005F9  System.Void OnReverse()
  RVA=0x0968C180  token=0x60005FA  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.CharacterLookAt
TYPE:  class
TOKEN: 0x20000B9
SIZE:  0xA0
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  public            System.Single                   weight  // 0x58
  public            Slate.TransformRefPosition      targetPosition  // 0x60
  private           UnityEngine.Quaternion          wasNeckRot  // 0x80
  private           UnityEngine.Quaternion          wasHeadRot  // 0x90
PROPERTIES:
  targetPositionVector  get=0x0968CB18  set=0x03D75030
  info  get=0x0968C9C0
  isValid  get=0x0968CA38
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
METHODS:
  RVA=0x0968C334  token=0x6000605  System.Void OnCreate()
  RVA=0x0968C2E8  token=0x6000606  System.Void OnAfterValidate()
  RVA=0x0968C3FC  token=0x6000607  System.Void OnEnter()
  RVA=0x0968C53C  token=0x6000608  System.Void OnUpdate(System.Single time)
  RVA=0x0968C49C  token=0x6000609  System.Void OnReverse()
  RVA=0x0968C96C  token=0x600060A  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessage`1
TYPE:  abstract class
TOKEN: 0x20000BA
EXTENDS: Slate.ActionClips.SendMessage
FIELDS:
  public            T                               value  // 0x0
PROPERTIES:
  info  get=-1  // not resolved
  isValid  get=-1  // not resolved
  parameterType  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x600060E  System.Void OnEnter()
  RVA=-1  // not resolved  token=0x600060F  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessage
TYPE:  class
TOKEN: 0x20000BB
SIZE:  0x50
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  public            System.String                   message  // 0x40
  public            System.Int32                    componentIndex  // 0x48
PROPERTIES:
  info  get=0x096986F0
  isValid  get=0x07C21C88
  parameterType  get=0x01002730
METHODS:
  RVA=0x0969843C  token=0x6000613  System.Void OnEnter()
  RVA=0x07C20DB4  token=0x6000614  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageBoolean
TYPE:  class
TOKEN: 0x20000BC
SIZE:  0x58
EXTENDS: Slate.ActionClips.SendMessage`1
FIELDS:
METHODS:
  RVA=0x09698310  token=0x6000615  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageFloat
TYPE:  class
TOKEN: 0x20000BD
SIZE:  0x58
EXTENDS: Slate.ActionClips.SendMessage`1
FIELDS:
METHODS:
  RVA=0x0969834C  token=0x6000616  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageInteger
TYPE:  class
TOKEN: 0x20000BE
SIZE:  0x58
EXTENDS: Slate.ActionClips.SendMessage`1
FIELDS:
METHODS:
  RVA=0x09698388  token=0x6000617  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageObject
TYPE:  class
TOKEN: 0x20000BF
SIZE:  0x58
EXTENDS: Slate.ActionClips.SendMessage`1
FIELDS:
METHODS:
  RVA=0x096983C4  token=0x6000618  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageString
TYPE:  class
TOKEN: 0x20000C0
SIZE:  0x58
EXTENDS: Slate.ActionClips.SendMessage`1
FIELDS:
METHODS:
  RVA=0x09698400  token=0x6000619  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateActorVisibility
TYPE:  class
TOKEN: 0x20000C1
SIZE:  0x48
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            System.Boolean                  visible  // 0x44
  private           System.Boolean                  wasVisible  // 0x45
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x09688FCC  token=0x600061C  System.Void OnCreate()
  RVA=0x09688FFC  token=0x600061D  System.Void OnEnter()
  RVA=0x0968905C  token=0x600061E  System.Void OnUpdate(System.Single time)
  RVA=0x0968902C  token=0x600061F  System.Void OnReverse()
  RVA=0x0968908C  token=0x6000620  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.MakeCameraTarget
TYPE:  class
TOKEN: 0x20000C2
SIZE:  0x58
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  public            System.Boolean                  setTransposerTarget  // 0x40
  public            System.Boolean                  setComposerTarget  // 0x41
  private           UnityEngine.Transform           wasTransposerTarget  // 0x48
  private           UnityEngine.Transform           wasComposerTarget  // 0x50
METHODS:
  RVA=0x096931B4  token=0x6000621  System.Void OnEnter()
  RVA=0x09693340  token=0x6000622  System.Void OnReverse()
  RVA=0x09693460  token=0x6000623  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetActorActiveState
TYPE:  class
TOKEN: 0x20000C3
SIZE:  0x50
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            Slate.ActiveState               activeState  // 0x44
  private           System.Boolean                  lastState  // 0x48
  private           System.Boolean                  currentState  // 0x49
  private           System.Boolean                  temporary  // 0x4a
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  info  get=0x096988B0
METHODS:
  RVA=0x09698730  token=0x6000627  System.Void OnEnter()
  RVA=0x096987F8  token=0x6000628  System.Void OnExit()
  RVA=0x09698834  token=0x6000629  System.Void OnReverseEnter()
  RVA=0x09698870  token=0x600062A  System.Void OnReverse()
  RVA=0x096988A0  token=0x600062B  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetActorVisibilityTemporary
TYPE:  class
TOKEN: 0x20000C4
SIZE:  0x50
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            Slate.ActiveState               activeState  // 0x44
  private           System.Boolean                  lastState  // 0x48
  private           System.Boolean                  currentState  // 0x49
  private           System.Boolean                  temporary  // 0x4a
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  info  get=0x09698928
METHODS:
  RVA=0x09698730  token=0x600062F  System.Void OnEnter()
  RVA=0x096987F8  token=0x6000630  System.Void OnExit()
  RVA=0x09698834  token=0x6000631  System.Void OnReverseEnter()
  RVA=0x09698870  token=0x6000632  System.Void OnReverse()
  RVA=0x09698910  token=0x6000633  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetBehavioursActiveState
TYPE:  class
TOKEN: 0x20000C5
SIZE:  0x70
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            System.Collections.Generic.List<System.String>behaviourNames  // 0x48
  public            Slate.ActiveState               activeState  // 0x50
  private           System.Collections.Generic.Dictionary<UnityEngine.Behaviour,System.Boolean>originalStates  // 0x58
  private           System.Collections.Generic.Dictionary<UnityEngine.Behaviour,System.Boolean>currentStates  // 0x60
  private           System.Boolean                  temporary  // 0x68
PROPERTIES:
  info  get=0x09699294
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x09698988  token=0x6000637  System.Void OnEnter()
  RVA=0x09698CA8  token=0x6000638  System.Void OnExit()
  RVA=0x09698E5C  token=0x6000639  System.Void OnReverseEnter()
  RVA=0x0969900C  token=0x600063A  System.Void OnReverse()
  RVA=0x0969920C  token=0x600063B  System.Void .ctor()
  RVA=0x09699194  token=0x600063C  System.Boolean <OnEnter>b__11_0(UnityEngine.Behaviour c)
END_CLASS

CLASS: Slate.ActionClips.AnimateOnPath
TYPE:  class
TOKEN: 0x20000C6
SIZE:  0x80
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  public            Slate.Path                      path  // 0x48
  public            System.Single                   positionOnPath  // 0x50
  public            UnityEngine.Vector3             lookAtTargetPosition  // 0x54
  public            Slate.EaseType                  blendInterpolation  // 0x60
  private           UnityEngine.Vector3             wasPosition  // 0x64
  private           UnityEngine.Quaternion          wasRotation  // 0x70
PROPERTIES:
  info  get=0x09689FF8
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  isValid  get=0x0968A098
METHODS:
  RVA=0x09689BB8  token=0x6000643  System.Void OnEnter()
  RVA=0x09689CE4  token=0x6000644  System.Void OnUpdate(System.Single time)
  RVA=0x09689C58  token=0x6000645  System.Void OnReverse()
  RVA=0x09689FE0  token=0x6000646  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.FollowPath
TYPE:  class
TOKEN: 0x20000C7
SIZE:  0x90
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            Slate.Path                      path  // 0x50
  public            System.Boolean                  useSpeed  // 0x58
  public            System.Single                   speed  // 0x5c
  public            System.Single                   lookAhead  // 0x60
  public            UnityEngine.Vector3             upVector  // 0x64
  public            Slate.EaseType                  blendInterpolation  // 0x70
  private           UnityEngine.Vector3             lastPos  // 0x74
  private           UnityEngine.Quaternion          lastRot  // 0x80
PROPERTIES:
  info  get=0x09691E98
  length  get=0x09691F88  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  isValid  get=0x09691F38
METHODS:
  RVA=0x096919E0  token=0x600064F  System.Void OnEnter()
  RVA=0x09691B14  token=0x6000650  System.Void OnUpdate(System.Single time)
  RVA=0x09691A84  token=0x6000651  System.Void OnReverse()
  RVA=0x09691E60  token=0x6000652  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PathfindFromTo
TYPE:  class
TOKEN: 0x20000C8
SIZE:  0xC8
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _blendIn  // 0x40
  public            System.Single                   speed  // 0x44
  public            Slate.TransformRefPosition      sourcePosition  // 0x48
  public            Slate.TransformRefPosition      targetPosition  // 0x68
  private           UnityEngine.Vector3[]           pathPoints  // 0x88
  private           UnityEngine.Vector3             wasPosition  // 0x90
  private           UnityEngine.Quaternion          wasRotation  // 0x9c
  private           UnityEngine.Vector3             lastFrom  // 0xac
  private           UnityEngine.Vector3             lastTo  // 0xb8
PROPERTIES:
  info  get=0x09694930
  length  get=0x09694978
  blendIn  get=0x09694900  set=0x03D4ECF0
METHODS:
  RVA=0x09693FF0  token=0x6000657  System.Void OnEnter()
  RVA=0x09694250  token=0x6000658  System.Void OnUpdate(System.Single time)
  RVA=0x096941A4  token=0x6000659  System.Void OnReverse()
  RVA=0x0969468C  token=0x600065A  System.Void TryCalculatePath()
  RVA=0x096948E8  token=0x600065B  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PathfindTo
TYPE:  class
TOKEN: 0x20000C9
SIZE:  0xA8
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _blendIn  // 0x40
  public            System.Single                   speed  // 0x44
  public            Slate.TransformRefPosition      targetPosition  // 0x48
  private           UnityEngine.Vector3[]           pathPoints  // 0x68
  private           UnityEngine.Vector3             wasPosition  // 0x70
  private           UnityEngine.Quaternion          wasRotation  // 0x7c
  private           UnityEngine.Vector3             lastFrom  // 0x8c
  private           UnityEngine.Vector3             lastTo  // 0x98
PROPERTIES:
  info  get=0x096952D4
  length  get=0x0969531C
  blendIn  get=0x09694900  set=0x03D4ECF0
METHODS:
  RVA=0x096949BC  token=0x6000660  System.Void OnEnter()
  RVA=0x09694BF4  token=0x6000661  System.Void OnUpdate(System.Single time)
  RVA=0x09694B5C  token=0x6000662  System.Void OnReverse()
  RVA=0x09695018  token=0x6000663  System.Void TryCalculatePath()
  RVA=0x096948E8  token=0x6000664  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateMaterialColor
TYPE:  class
TOKEN: 0x20000CA
SIZE:  0x88
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   propertyName  // 0x58
  public            UnityEngine.Color               color  // 0x60
  public            Slate.EaseType                  interpolation  // 0x70
  private           UnityEngine.Color               originalColor  // 0x74
PROPERTIES:
  info  get=0x096896C4
  isValid  get=0x09689704
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
  targetMaterial  get=0x096897F0
METHODS:
  RVA=0x09689588  token=0x600066E  System.Void OnEnter()
  RVA=0x09689588  token=0x600066F  System.Void OnReverseEnter()
  RVA=0x09689598  token=0x6000670  System.Void OnUpdate(System.Single time)
  RVA=0x09689590  token=0x6000671  System.Void OnReverse()
  RVA=0x09689590  token=0x6000672  System.Void OnExit()
  RVA=0x0968954C  token=0x6000673  System.Void DoSet()
  RVA=0x0968950C  token=0x6000674  System.Void DoReset()
  RVA=0x09689644  token=0x6000675  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateMaterialFloat
TYPE:  class
TOKEN: 0x20000CB
SIZE:  0x70
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   propertyName  // 0x58
  public            System.Single                   value  // 0x60
  public            Slate.EaseType                  interpolation  // 0x64
  private           System.Single                   originalValue  // 0x68
PROPERTIES:
  info  get=0x096899E4
  isValid  get=0x09689A24
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
  targetMaterial  get=0x09689B10
METHODS:
  RVA=0x09689904  token=0x600067F  System.Void OnEnter()
  RVA=0x09689904  token=0x6000680  System.Void OnReverseEnter()
  RVA=0x09689914  token=0x6000681  System.Void OnUpdate(System.Single time)
  RVA=0x0968990C  token=0x6000682  System.Void OnReverse()
  RVA=0x0968990C  token=0x6000683  System.Void OnExit()
  RVA=0x096898CC  token=0x6000684  System.Void DoSet()
  RVA=0x09689898  token=0x6000685  System.Void DoReset()
  RVA=0x09689994  token=0x6000686  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateMaterialTexture
TYPE:  class
TOKEN: 0x20000CC
SIZE:  0x88
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   propertyName  // 0x58
  public            UnityEngine.Vector2             offset  // 0x60
  public            UnityEngine.Vector2             scale  // 0x68
  public            Slate.EaseType                  interpolation  // 0x70
  private           UnityEngine.Vector2             originalOffset  // 0x74
  private           UnityEngine.Vector2             originalScale  // 0x7c
PROPERTIES:
  info  get=0x0969F004
  isValid  get=0x0969F044
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
  targetMaterial  get=0x0969F130
METHODS:
  RVA=0x0969EDC0  token=0x6000690  System.Void OnEnter()
  RVA=0x0969EDC0  token=0x6000691  System.Void OnReverseEnter()
  RVA=0x0969EDD0  token=0x6000692  System.Void OnUpdate(System.Single time)
  RVA=0x0969EDC8  token=0x6000693  System.Void OnReverse()
  RVA=0x0969EDC8  token=0x6000694  System.Void OnExit()
  RVA=0x0969ED38  token=0x6000695  System.Void DoSet()
  RVA=0x0969ECC4  token=0x6000696  System.Void DoReset()
  RVA=0x0969EF8C  token=0x6000697  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScrollMaterialTexture
TYPE:  class
TOKEN: 0x20000CD
SIZE:  0x70
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   propertyName  // 0x50
  public            UnityEngine.Vector2             speed  // 0x58
  public            Slate.EaseType                  interpolation  // 0x60
  private           UnityEngine.Vector2             originalOffset  // 0x64
PROPERTIES:
  info  get=0x096A5CF4
  isValid  get=0x096A5D58
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x0969FD10
  targetMaterial  get=0x096A5E04
METHODS:
  RVA=0x096A5A78  token=0x600069E  System.Void OnEnter()
  RVA=0x096A5B08  token=0x600069F  System.Void OnUpdate(System.Single time)
  RVA=0x096A5AC4  token=0x60006A0  System.Void OnReverse()
  RVA=0x096A5C84  token=0x60006A1  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetMaterial
TYPE:  class
TOKEN: 0x20000CE
SIZE:  0x68
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            UnityEngine.Material            material  // 0x50
  private           UnityEngine.Material            sharedMat  // 0x58
  private           System.Boolean                  temporary  // 0x60
PROPERTIES:
  info  get=0x096A650C
  length  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x096A647C  token=0x60006A5  System.Void OnEnter()
  RVA=0x096A64C0  token=0x60006A6  System.Void OnReverseEnter()
  RVA=0x096A64D0  token=0x60006A7  System.Void OnReverse()
  RVA=0x096A64B0  token=0x60006A8  System.Void OnExit()
  RVA=0x096A63FC  token=0x60006A9  System.Void DoSet()
  RVA=0x096A63A8  token=0x60006AA  System.Void DoReset()
  RVA=0x096A64D8  token=0x60006AB  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetMaterialTexture
TYPE:  class
TOKEN: 0x20000CF
SIZE:  0x70
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   propertyName  // 0x50
  public            UnityEngine.Texture             texture  // 0x58
  private           UnityEngine.Texture             originalTexture  // 0x60
  private           System.Boolean                  temporary  // 0x68
PROPERTIES:
  info  get=0x096A6174
  isValid  get=0x096A6214
  length  get=0x03D58370  set=0x03D5BE60
  targetMaterial  get=0x096A6300
METHODS:
  RVA=0x096A60C4  token=0x60006B1  System.Void OnEnter()
  RVA=0x096A6108  token=0x60006B2  System.Void OnReverseEnter()
  RVA=0x096A6118  token=0x60006B3  System.Void OnReverse()
  RVA=0x096A60F8  token=0x60006B4  System.Void OnExit()
  RVA=0x096A6064  token=0x60006B5  System.Void DoSet()
  RVA=0x096A6030  token=0x60006B6  System.Void DoReset()
  RVA=0x096A6120  token=0x60006B7  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetSortingLayer
TYPE:  class
TOKEN: 0x20000D0
SIZE:  0x60
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  public            System.Int32                    sortingOrder  // 0x48
  public            System.Int32                    sortingLayerID  // 0x4c
  private           System.String                   _lastLayer  // 0x50
  private           System.Int32                    _lastOrder  // 0x58
PROPERTIES:
  info  get=0x096A6B8C
METHODS:
  RVA=0x096A6A1C  token=0x60006B9  System.Void OnEnter()
  RVA=0x096A6AE0  token=0x60006BA  System.Void OnReverse()
  RVA=0x096A6B58  token=0x60006BB  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetSprite
TYPE:  class
TOKEN: 0x20000D1
SIZE:  0x98
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x48
  public            UnityEngine.Color               color  // 0x50
  public            System.Boolean                  flipX  // 0x60
  public            System.Boolean                  flipY  // 0x61
  public            System.Boolean                  changeSorting  // 0x62
  public            System.Int32                    sortingLayerID  // 0x64
  public            System.Int32                    sortingOrder  // 0x68
  private           UnityEngine.Sprite              lastSprite  // 0x70
  private           UnityEngine.Color               lastColor  // 0x78
  private           System.Boolean                  lastFlipX  // 0x88
  private           System.Boolean                  lastFlipY  // 0x89
  private           System.Int32                    lastSortingLayerID  // 0x8c
  private           System.Int32                    lastSortingOrder  // 0x90
PROPERTIES:
  info  get=0x096A6FD4
METHODS:
  RVA=0x096A6C44  token=0x60006BD  System.Void OnEnter()
  RVA=0x096A6E68  token=0x60006BE  System.Void OnReverse()
  RVA=0x096A6F8C  token=0x60006BF  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SpriteFlipbook
TYPE:  class
TOKEN: 0x20000D2
SIZE:  0x68
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.Int32                    loops  // 0x4c
  public            System.Collections.Generic.List<UnityEngine.Sprite>sprites  // 0x50
  public            System.Boolean                  endWithPrevious  // 0x58
  private           UnityEngine.Sprite              lastSprite  // 0x60
PROPERTIES:
  info  get=0x096A7C08
  length  get=0x03D58370  set=0x03D5BE60
  isValid  get=0x096A7CC8
METHODS:
  RVA=0x096A7900  token=0x60006C4  System.Void OnEnter()
  RVA=0x096A7A0C  token=0x60006C5  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A795C  token=0x60006C6  System.Void OnExit()
  RVA=0x096A79B8  token=0x60006C7  System.Void OnReverse()
  RVA=0x096A7B68  token=0x60006C8  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AttachObject
TYPE:  class
TOKEN: 0x20000D3
SIZE:  0x90
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Transform           targetObject  // 0x48
  public            System.String                   childTransformName  // 0x50
  public            UnityEngine.Vector3             localPosition  // 0x58
  public            UnityEngine.Vector3             localRotation  // 0x64
  public            UnityEngine.Vector3             localScale  // 0x70
  private           Slate.TransformSnapshot         snapshot  // 0x80
  private           System.Boolean                  temporary  // 0x88
PROPERTIES:
  isValid  get=0x0969FAD0
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x0969FA48  token=0x60006CC  System.Void OnEnter()
  RVA=0x0969FA90  token=0x60006CD  System.Void OnReverseEnter()
  RVA=0x0969FA7C  token=0x60006CE  System.Void OnExit()
  RVA=0x0969FAA4  token=0x60006CF  System.Void OnReverse()
  RVA=0x0969F81C  token=0x60006D0  System.Void Do()
  RVA=0x0969FAAC  token=0x60006D1  System.Void UnDo()
  RVA=0x0969F7A4  token=0x60006D2  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AttachObjectPrefab
TYPE:  class
TOKEN: 0x20000D4
SIZE:  0x98
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Transform           targetPrefab  // 0x48
  public            System.String                   childTransformName  // 0x50
  public            UnityEngine.Vector3             localPosition  // 0x58
  public            UnityEngine.Vector3             localRotation  // 0x64
  public            UnityEngine.Vector3             localScale  // 0x70
  private           UnityEngine.Transform           instance  // 0x80
  private           Slate.TransformSnapshot         snapshot  // 0x88
  private           System.Boolean                  temporary  // 0x90
PROPERTIES:
  isValid  get=0x0969F7CC
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x0969F6A0  token=0x60006D6  System.Void OnEnter()
  RVA=0x0969F6E8  token=0x60006D7  System.Void OnReverseEnter()
  RVA=0x0969F6D4  token=0x60006D8  System.Void OnExit()
  RVA=0x0969F6FC  token=0x60006D9  System.Void OnReverse()
  RVA=0x0969F494  token=0x60006DA  System.Void Do()
  RVA=0x0969F704  token=0x60006DB  System.Void UnDo()
  RVA=0x0969F7A4  token=0x60006DC  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.LookAt
TYPE:  class
TOKEN: 0x20000D5
SIZE:  0x88
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Boolean                  verticalOnly  // 0x4c
  public            Slate.EaseType                  interpolation  // 0x50
  public            Slate.TransformRefPosition      targetPosition  // 0x58
  private           UnityEngine.Quaternion          wasRotation  // 0x78
PROPERTIES:
  targetPositionVector  get=0x096A144C  set=0x03D71C40
  info  get=0x096A13D4
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x096A10C4  token=0x60006E6  System.Void OnCreate()
  RVA=0x096A1078  token=0x60006E7  System.Void OnAfterValidate()
  RVA=0x096A1100  token=0x60006E8  System.Void OnEnter()
  RVA=0x096A1198  token=0x60006E9  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A114C  token=0x60006EA  System.Void OnReverse()
  RVA=0x096A13B0  token=0x60006EB  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.MatchTransformsToTarget
TYPE:  class
TOKEN: 0x20000D6
SIZE:  0xB8
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Transform           targetObject  // 0x50
  public            Slate.EaseType                  interpolation  // 0x58
  public            System.Boolean                  matchPosition  // 0x5c
  public            UnityEngine.Vector3             positionOffset  // 0x60
  public            System.Boolean                  matchRotation  // 0x6c
  public            UnityEngine.Vector3             rotationOffset  // 0x70
  public            System.Boolean                  matchScale  // 0x7c
  public            UnityEngine.Vector3             scaleOffset  // 0x80
  private           UnityEngine.Vector3             lastPos  // 0x8c
  private           UnityEngine.Quaternion          lastRot  // 0x98
  private           UnityEngine.Vector3             lastScale  // 0xa8
PROPERTIES:
  info  get=0x096A1B74
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  isValid  get=0x096A1C14
METHODS:
  RVA=0x096A1480  token=0x60006F4  System.Void OnEnter()
  RVA=0x096A1640  token=0x60006F5  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A155C  token=0x60006F6  System.Void OnReverse()
  RVA=0x096A1B48  token=0x60006F7  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.Noise
TYPE:  class
TOKEN: 0x20000D7
SIZE:  0x78
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Vector3             seed  // 0x4c
  public            UnityEngine.Vector3             amplitude  // 0x58
  public            System.Single                   frequency  // 0x64
  private           UnityEngine.Vector3             wasPosition  // 0x68
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x096A1FF8  token=0x60006FE  System.Void OnCreate()
  RVA=0x096A2070  token=0x60006FF  System.Void OnEnter()
  RVA=0x096A20C0  token=0x6000700  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x096A2298  token=0x6000701  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RotateAround
TYPE:  class
TOKEN: 0x20000D8
SIZE:  0xA0
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             rotation  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            System.Boolean                  lookTarget  // 0x51
  public            Slate.EaseType                  interpolation  // 0x54
  public            Slate.TransformRefPosition      targetPosition  // 0x58
  private           UnityEngine.Vector3             wasPosition  // 0x78
  private           UnityEngine.Quaternion          wasRotation  // 0x84
  private           UnityEngine.Vector3             targetWasPosition  // 0x94
PROPERTIES:
  targetPositionVector  get=0x096A144C  set=0x03D71C40
  info  get=0x096A4770
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A4184  token=0x6000708  System.Void OnAfterValidate()
  RVA=0x096A41D0  token=0x6000709  System.Void OnEnter()
  RVA=0x096A436C  token=0x600070A  System.Void OnUpdate(System.Single time)
  RVA=0x096A42DC  token=0x600070B  System.Void OnReverse()
  RVA=0x096A4740  token=0x600070C  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RotateBy
TYPE:  class
TOKEN: 0x20000D9
SIZE:  0x68
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             rotation  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             originalRot  // 0x58
PROPERTIES:
  info  get=0x096A4B3C
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A4858  token=0x6000711  System.Void OnEnter()
  RVA=0x096A496C  token=0x6000712  System.Void OnUpdate(System.Single time)
  RVA=0x096A48DC  token=0x6000713  System.Void OnReverse()
  RVA=0x096A4B0C  token=0x6000714  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RotateTo
TYPE:  class
TOKEN: 0x20000DA
SIZE:  0x60
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             targetRotation  // 0x44
  public            Slate.EaseType                  interpolation  // 0x50
  private           UnityEngine.Vector3             originalRot  // 0x54
PROPERTIES:
  info  get=0x096A4DF0
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A4BEC  token=0x6000719  System.Void OnEnter()
  RVA=0x096A4C90  token=0x600071A  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A4C3C  token=0x600071B  System.Void OnReverse()
  RVA=0x0969F300  token=0x600071C  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScaleBy
TYPE:  class
TOKEN: 0x20000DB
SIZE:  0x68
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             scale  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             originalScale  // 0x58
PROPERTIES:
  info  get=0x096A5660
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A540C  token=0x6000721  System.Void OnEnter()
  RVA=0x096A54B0  token=0x6000722  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A545C  token=0x6000723  System.Void OnReverse()
  RVA=0x096A5630  token=0x6000724  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScaleTo
TYPE:  class
TOKEN: 0x20000DC
SIZE:  0x60
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             targetScale  // 0x44
  public            Slate.EaseType                  interpolation  // 0x50
  private           UnityEngine.Vector3             originalPos  // 0x54
PROPERTIES:
  info  get=0x096A5914
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A5710  token=0x6000729  System.Void OnEnter()
  RVA=0x096A57B4  token=0x600072A  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A5760  token=0x600072B  System.Void OnReverse()
  RVA=0x0969F300  token=0x600072C  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetParentTemporary
TYPE:  class
TOKEN: 0x20000DD
SIZE:  0x88
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  public            System.Single                   _length  // 0x40
  public            UnityEngine.Transform           newParent  // 0x48
  public            System.Boolean                  matchPosition  // 0x50
  public            System.Boolean                  matchRotation  // 0x51
  public            System.Boolean                  matchScale  // 0x52
  private           UnityEngine.Transform           originalParent  // 0x58
  private           UnityEngine.Vector3             originalPos  // 0x60
  private           UnityEngine.Quaternion          originalRot  // 0x6c
  private           UnityEngine.Vector3             originalScale  // 0x7c
PROPERTIES:
  info  get=0x096A697C
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x096A65AC  token=0x6000730  System.Void OnEnter()
  RVA=0x096A67C8  token=0x6000731  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A66B8  token=0x6000732  System.Void OnReverse()
  RVA=0x0968908C  token=0x6000733  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetTransformParent
TYPE:  class
TOKEN: 0x20000DE
SIZE:  0x90
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Transform           newParent  // 0x48
  public            System.Boolean                  resetPosition  // 0x50
  public            System.Boolean                  resetRotation  // 0x51
  public            System.Boolean                  resetScale  // 0x52
  private           UnityEngine.Transform           originalParent  // 0x58
  private           UnityEngine.Vector3             originalPos  // 0x60
  private           UnityEngine.Quaternion          originalRot  // 0x6c
  private           UnityEngine.Vector3             originalScale  // 0x7c
  private           System.Boolean                  temporary  // 0x88
PROPERTIES:
  info  get=0x096A7314
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x096A72B0  token=0x6000737  System.Void OnEnter()
  RVA=0x096A72F8  token=0x6000738  System.Void OnReverseEnter()
  RVA=0x096A72E4  token=0x6000739  System.Void OnExit()
  RVA=0x096A730C  token=0x600073A  System.Void OnReverse()
  RVA=0x096A7054  token=0x600073B  System.Void Do()
  RVA=0x096A66B8  token=0x600073C  System.Void UnDo()
  RVA=0x0426FE60  token=0x600073D  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetTransformValues
TYPE:  class
TOKEN: 0x20000DF
SIZE:  0x80
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  public            Slate.MiniTransformSpace        space  // 0x40
  public            System.Boolean                  setPosition  // 0x44
  public            UnityEngine.Vector3             position  // 0x48
  public            System.Boolean                  setRotation  // 0x54
  public            UnityEngine.Vector3             rotation  // 0x58
  public            System.Boolean                  setScale  // 0x64
  public            UnityEngine.Vector3             scale  // 0x68
  private           Slate.TransformSnapshot         undo  // 0x78
METHODS:
  RVA=0x096A73B4  token=0x600073E  System.Void OnEnter()
  RVA=0x096A7580  token=0x600073F  System.Void OnReverse()
  RVA=0x096A75A0  token=0x6000740  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SimpleGrounder
TYPE:  class
TOKEN: 0x20000E0
SIZE:  0xA0
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            System.Single                   maxCheckDistance  // 0x44
  public            System.Single                   offset  // 0x48
  private           UnityEngine.RaycastHit          hit  // 0x50
  private           UnityEngine.Vector3             lastPos  // 0x90
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x096A75C4  token=0x6000743  System.Void OnEnter()
  RVA=0x096A7674  token=0x6000744  System.Void OnUpdate(System.Single time)
  RVA=0x096A761C  token=0x6000745  System.Void OnReverse()
  RVA=0x096A78E4  token=0x6000746  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.TranslateBy
TYPE:  class
TOKEN: 0x20000E1
SIZE:  0x68
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             translation  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             originalPos  // 0x58
PROPERTIES:
  info  get=0x096A85B0
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A835C  token=0x600074B  System.Void OnEnter()
  RVA=0x096A8400  token=0x600074C  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A83AC  token=0x600074D  System.Void OnReverse()
  RVA=0x096A8580  token=0x600074E  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.TranslateTo
TYPE:  class
TOKEN: 0x20000E2
SIZE:  0x68
EXTENDS: Slate.ActionClips.ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             targetPosition  // 0x44
  public            Slate.MiniTransformSpace        space  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             wasPosition  // 0x58
PROPERTIES:
  info  get=0x096A8898
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x096A8660  token=0x6000753  System.Void OnEnter()
  RVA=0x096A8704  token=0x6000754  System.Void OnUpdate(System.Single time)
  RVA=0x096A86B0  token=0x6000755  System.Void OnReverse()
  RVA=0x096A8880  token=0x6000756  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AdditiveScene
TYPE:  class
TOKEN: 0x20000E3
SIZE:  0x88
EXTENDS: Slate.DirectorActionClip
IMPLEMENTS: Slate.ISubClipContainable Slate.IDirectable
FIELDS:
  private           System.Single                   _length  // 0x40
  protected         System.String                   _scenePath  // 0x48
  public            UnityEngine.Vector3             scenePosition  // 0x50
  public            UnityEngine.Vector3             sceneRotation  // 0x5c
  public            Slate.MiniTransformSpace        space  // 0x68
  public            System.Boolean                  updateRootCutscenes  // 0x6c
  public            System.Single                   timeOffset  // 0x70
  private           UnityEngine.SceneManagement.ScenesubScene  // 0x74
  private           System.Collections.Generic.List<Slate.Cutscene>rootCutscenes  // 0x78
  private           System.Boolean                  temporary  // 0x80
  private           System.Boolean                  waitLoad  // 0x81
PROPERTIES:
  Slate.ISubClipContainable.subClipOffset  get=0x03D56C00  set=0x03D5BD20
  Slate.ISubClipContainable.subClipLength  get=0x03D503F0
  Slate.ISubClipContainable.subClipSpeed  get=0x03D503F0
  isValid  get=0x0969D004
  length  get=0x03D4EC70  set=0x03D4ECF0
METHODS:
  RVA=0x0969CE74  token=0x600075E  System.Void OnEnter()
  RVA=0x0969CEDC  token=0x600075F  System.Void OnReverseEnter()
  RVA=0x0969CF14  token=0x6000760  System.Void OnUpdate(System.Single time)
  RVA=0x0969CEA8  token=0x6000761  System.Void OnExit()
  RVA=0x0969CEF0  token=0x6000762  System.Void OnReverse()
  RVA=0x0969C784  token=0x6000763  System.Void Activate()
  RVA=0x0969C89C  token=0x6000764  System.Void Deactivate()
  RVA=0x0969C818  token=0x6000765  System.String CleanPath(System.String path)
  RVA=0x0969CADC  token=0x6000766  System.Void InitializeSubSceneCutscenes()
  RVA=0x0969C910  token=0x6000767  System.Void DenitializeSubSceneCutscenes(System.Boolean forward)
  RVA=0x0969CFF0  token=0x6000768  System.Void .ctor()
  RVA=0x04276114  token=0x6000769  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.SubCutscene
TYPE:  class
TOKEN: 0x20000E4
SIZE:  0x58
EXTENDS: Slate.DirectorActionClip
IMPLEMENTS: Slate.ISubClipContainable Slate.IDirectable
FIELDS:
  private           System.Single                   _length  // 0x40
  public            Slate.Cutscene                  subCutscene  // 0x48
  public            System.Single                   subCutsceneTimeOffset  // 0x50
  private           System.Boolean                  wasCamTrackActive  // 0x54
PROPERTIES:
  info  get=0x096A8140
  isValid  get=0x096A8208
  length  get=0x03D4EC70  set=0x03D4ECF0
  actor  get=0x096A80FC
  Slate.ISubClipContainable.subClipOffset  get=0x03D51C90  set=0x03D51CA0
  Slate.ISubClipContainable.subClipLength  get=0x096A8084
  Slate.ISubClipContainable.subClipSpeed  get=0x096A80C0
METHODS:
  RVA=0x096A7D5C  token=0x6000773  System.Void OnEnter()
  RVA=0x096A7ECC  token=0x6000774  System.Void OnReverseEnter()
  RVA=0x096A7E24  token=0x6000775  System.Void OnExit()
  RVA=0x096A7F98  token=0x6000776  System.Void OnReverse()
  RVA=0x096A8038  token=0x6000777  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x0968908C  token=0x6000778  System.Void .ctor()
  RVA=0x04276114  token=0x6000779  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.DestroyGameObjects
TYPE:  class
TOKEN: 0x20000E5
SIZE:  0x48
EXTENDS: Slate.DirectorActionClip
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>targetObjects  // 0x40
PROPERTIES:
  info  get=0x096A0014
METHODS:
  RVA=0x0969FE40  token=0x600077B  System.Void OnEnter()
  RVA=0x0969FF94  token=0x600077C  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.DirectorDisableGameObjects
TYPE:  class
TOKEN: 0x20000E6
SIZE:  0x50
EXTENDS: Slate.DirectorActionClip
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>targetObjects  // 0x40
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean>states  // 0x48
PROPERTIES:
  info  get=0x096A0464
METHODS:
  RVA=0x096A0090  token=0x600077E  System.Void OnEnter()
  RVA=0x096A0258  token=0x600077F  System.Void OnReverse()
  RVA=0x096A03E4  token=0x6000780  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.DirectorEnableGameObjects
TYPE:  class
TOKEN: 0x20000E7
SIZE:  0x50
EXTENDS: Slate.DirectorActionClip
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>targetObjects  // 0x40
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean>states  // 0x48
PROPERTIES:
  info  get=0x096A08B4
METHODS:
  RVA=0x096A04E0  token=0x6000782  System.Void OnEnter()
  RVA=0x096A06A8  token=0x6000783  System.Void OnReverse()
  RVA=0x096A0834  token=0x6000784  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.InstantiateObject
TYPE:  class
TOKEN: 0x20000E8
SIZE:  0x98
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.GameObject          targetObject  // 0x50
  public            UnityEngine.Transform           optionalParent  // 0x58
  public            UnityEngine.Vector3             targetPosition  // 0x60
  public            UnityEngine.Vector3             targetRotation  // 0x6c
  public            Slate.MiniTransformSpace        space  // 0x78
  public            Slate.EaseType                  popupInterpolation  // 0x7c
  private           UnityEngine.GameObject          instance  // 0x80
  private           UnityEngine.Vector3             wasScale  // 0x88
PROPERTIES:
  isValid  get=0x096A1028
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  info  get=0x096A0F88
  actor  get=0x03D4EAE0
METHODS:
  RVA=0x096A0A20  token=0x600078E  System.Void OnEnter()
  RVA=0x096A0E20  token=0x600078F  System.Void OnUpdate(System.Single time)
  RVA=0x096A0D30  token=0x6000790  System.Void OnExit()
  RVA=0x096A0D94  token=0x6000791  System.Void OnReverseEnter()
  RVA=0x096A0DCC  token=0x6000792  System.Void OnReverse()
  RVA=0x096A0F70  token=0x6000793  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SampleParticleSystem
TYPE:  class
TOKEN: 0x20000E9
SIZE:  0x60
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.ParticleSystem      particles  // 0x48
  public            System.Boolean                  simulationSync  // 0x50
  private           UnityEngine.ParticleSystem.EmissionModuleem  // 0x58
PROPERTIES:
  info  get=0x096A5110
  isValid  get=0x096A5228
  length  get=0x096A5278  set=0x03D4ECF0
  blendOut  get=0x096A5044
  loop  get=0x096A5308
  duration  get=0x096A508C
  startLifetime  get=0x096A5388
METHODS:
  RVA=0x096A4E5C  token=0x600079C  System.Void OnEnter()
  RVA=0x096A4E5C  token=0x600079D  System.Void OnReverseEnter()
  RVA=0x096A4E64  token=0x600079E  System.Void OnExit()
  RVA=0x096A4E64  token=0x600079F  System.Void OnReverse()
  RVA=0x096A4EB8  token=0x60007A0  System.Void OnRootEnabled()
  RVA=0x096A4E6C  token=0x60007A1  System.Void OnRootDisabled()
  RVA=0x096A4F74  token=0x60007A2  System.Void Play()
  RVA=0x096A4F08  token=0x60007A3  System.Void OnUpdate(System.Single time)
  RVA=0x096A4FF0  token=0x60007A4  System.Void Stop()
  RVA=0x096A5030  token=0x60007A5  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.TransitAudioMixerSnapshot
TYPE:  class
TOKEN: 0x20000EA
SIZE:  0x60
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Audio.AudioMixer    audioMixer  // 0x48
  public            System.String                   snapshotName  // 0x50
  private           UnityEngine.Audio.AudioMixerSnapshotsnapshot  // 0x58
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x0969FD10
  isValid  get=0x096A830C
METHODS:
  RVA=0x096A8304  token=0x60007AA  System.Void OnReverseEnter()
  RVA=0x096A8304  token=0x60007AB  System.Void OnEnter()
  RVA=0x096A8274  token=0x60007AC  System.Void Do()
  RVA=0x0968908C  token=0x60007AD  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateAmbientLighting
TYPE:  class
TOKEN: 0x20000EB
SIZE:  0x78
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   ambientIntensity  // 0x4c
  public            UnityEngine.Color               ambientColor  // 0x50
  private           System.Single                   wasIntensity  // 0x60
  private           UnityEngine.Color               wasColor  // 0x64
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969D01C  token=0x60007B4  System.Void OnCreate()
  RVA=0x0969D04C  token=0x60007B5  System.Void OnEnter()
  RVA=0x0969D0AC  token=0x60007B6  System.Void OnUpdate(System.Single time)
  RVA=0x0969D07C  token=0x60007B7  System.Void OnReverse()
  RVA=0x0968908C  token=0x60007B8  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateFog
TYPE:  class
TOKEN: 0x20000EC
SIZE:  0x88
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Color               fogColor  // 0x4c
  public            System.Single                   fogDensity  // 0x5c
  public            System.Single                   linearFogStartDistance  // 0x60
  public            System.Single                   linearFogEndDistance  // 0x64
  private           UnityEngine.Color               wasColor  // 0x68
  private           System.Single                   wasDensity  // 0x78
  private           System.Single                   wasStartDistance  // 0x7c
  private           System.Single                   wasEndDistance  // 0x80
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969D540  token=0x60007BF  System.Void OnCreate()
  RVA=0x0969D588  token=0x60007C0  System.Void OnEnter()
  RVA=0x0969D620  token=0x60007C1  System.Void OnUpdate(System.Single time)
  RVA=0x0969D5D4  token=0x60007C2  System.Void OnReverse()
  RVA=0x0968908C  token=0x60007C3  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateGravity
TYPE:  class
TOKEN: 0x20000ED
SIZE:  0x68
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Vector3             gravity  // 0x4c
  private           UnityEngine.Vector3             wasGravity  // 0x58
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969D6D4  token=0x60007CA  System.Void OnCreate()
  RVA=0x0969D700  token=0x60007CB  System.Void OnEnter()
  RVA=0x0969D7B8  token=0x60007CC  System.Void OnUpdate(System.Single time)
  RVA=0x0969D72C  token=0x60007CD  System.Void OnReverse()
  RVA=0x0968908C  token=0x60007CE  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateTimeScale
TYPE:  class
TOKEN: 0x20000EE
SIZE:  0x58
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   timeScale  // 0x4c
  public            Slate.EaseType                  interpolation  // 0x50
  private           System.Single                   wasScale  // 0x54
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969F318  token=0x60007D5  System.Void OnCreate()
  RVA=0x0969F334  token=0x60007D6  System.Void OnEnter()
  RVA=0x0969F35C  token=0x60007D7  System.Void OnUpdate(System.Single time)
  RVA=0x0969F350  token=0x60007D8  System.Void OnReverse()
  RVA=0x0969F300  token=0x60007D9  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.EasySlowMotion
TYPE:  class
TOKEN: 0x20000EF
SIZE:  0x58
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   timeScale  // 0x4c
  public            Slate.EaseType                  interpolation  // 0x50
  private           System.Single                   lastTimeScale  // 0x54
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  info  get=0x096A09C4
METHODS:
  RVA=0x0969F334  token=0x60007E1  System.Void OnEnter()
  RVA=0x096A0930  token=0x60007E2  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x0969F350  token=0x60007E3  System.Void OnReverse()
  RVA=0x096A0998  token=0x60007E4  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RaiseUnityEvent
TYPE:  class
TOKEN: 0x20000F0
SIZE:  0x58
EXTENDS: Slate.DirectorActionClip
FIELDS:
  public            System.String                   customLabel  // 0x40
  public            UnityEngine.Events.UnityEvent   forwardEvent  // 0x48
  public            UnityEngine.Events.UnityEvent   reverseEvent  // 0x50
PROPERTIES:
  info  get=0x096A3F60
METHODS:
  RVA=0x096A3E84  token=0x60007E6  System.Void OnEnter()
  RVA=0x096A3EA4  token=0x60007E7  System.Void OnReverse()
  RVA=0x096A3EC4  token=0x60007E8  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessage`1
TYPE:  abstract class
TOKEN: 0x20000F1
EXTENDS: Slate.ActionClips.SendGlobalMessage
FIELDS:
  public            T                               value  // 0x0
PROPERTIES:
  info  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60007EA  System.Void OnEnter()
  RVA=-1  // not resolved  token=0x60007EB  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessage
TYPE:  class
TOKEN: 0x20000F2
SIZE:  0x48
EXTENDS: Slate.DirectorActionClip
IMPLEMENTS: Slate.IEvent
FIELDS:
  public            System.String                   message  // 0x40
PROPERTIES:
  info  get=0x096A5FF0
  isValid  get=0x07C21C88
  Slate.IEvent.name  get=0x03D4E2B0
METHODS:
  RVA=0x092CE85C  token=0x60007EF  System.Void Slate.IEvent.Invoke()
  RVA=0x096A5FB0  token=0x60007F0  System.Void OnEnter()
  RVA=0x0426FE60  token=0x60007F1  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageBoolean
TYPE:  class
TOKEN: 0x20000F3
SIZE:  0x50
EXTENDS: Slate.ActionClips.SendGlobalMessage`1
FIELDS:
METHODS:
  RVA=0x096A5EAC  token=0x60007F2  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageFloat
TYPE:  class
TOKEN: 0x20000F4
SIZE:  0x50
EXTENDS: Slate.ActionClips.SendGlobalMessage`1
FIELDS:
METHODS:
  RVA=0x096A5EE0  token=0x60007F3  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageInteger
TYPE:  class
TOKEN: 0x20000F5
SIZE:  0x50
EXTENDS: Slate.ActionClips.SendGlobalMessage`1
FIELDS:
METHODS:
  RVA=0x096A5F14  token=0x60007F4  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageObject
TYPE:  class
TOKEN: 0x20000F6
SIZE:  0x50
EXTENDS: Slate.ActionClips.SendGlobalMessage`1
FIELDS:
METHODS:
  RVA=0x096A5F48  token=0x60007F5  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageString
TYPE:  class
TOKEN: 0x20000F7
SIZE:  0x50
EXTENDS: Slate.ActionClips.SendGlobalMessage`1
FIELDS:
METHODS:
  RVA=0x096A5F7C  token=0x60007F6  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.Captions
TYPE:  class
TOKEN: 0x20000F8
SIZE:  0x70
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.String                   text  // 0x50
  public            UnityEngine.Color               color  // 0x58
  public            Slate.EaseType                  interpolation  // 0x68
PROPERTIES:
  info  get=0x0969FC08
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969FB20  token=0x60007FE  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x0969FB94  token=0x60007FF  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.CineBox
TYPE:  class
TOKEN: 0x20000F9
SIZE:  0x50
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969FC48  token=0x6000806  System.Void OnUpdate(System.Single time)
  RVA=0x0969FC60  token=0x6000807  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.OverlayText
TYPE:  class
TOKEN: 0x20000FA
SIZE:  0x80
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.String                   text  // 0x50
  public            UnityEngine.TextAnchor          anchor  // 0x58
  public            Slate.EaseType                  interpolation  // 0x5c
  public            UnityEngine.Color               color  // 0x60
  public            System.Single                   size  // 0x70
  public            UnityEngine.Vector2             position  // 0x74
PROPERTIES:
  info  get=0x096A23EC
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x096A22D4  token=0x600080F  System.Void OnUpdate(System.Single time)
  RVA=0x096A2368  token=0x6000810  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.OverlayTexture
TYPE:  class
TOKEN: 0x20000FB
SIZE:  0x80
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Texture             texture  // 0x50
  public            UnityEngine.Color               color  // 0x58
  public            UnityEngine.Vector2             scale  // 0x68
  public            UnityEngine.Vector2             position  // 0x70
  public            Slate.EaseType                  interpolation  // 0x78
PROPERTIES:
  info  get=0x096A2518
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x096A242C  token=0x6000818  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A24C8  token=0x6000819  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScreenFader
TYPE:  class
TOKEN: 0x20000FC
SIZE:  0x78
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   fade  // 0x4c
  public            UnityEngine.Color               outColor  // 0x50
  public            Slate.EaseType                  interpolation  // 0x60
  private           UnityEngine.Color               lastColor  // 0x64
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x096A5980  token=0x6000820  System.Void OnEnter()
  RVA=0x096A59C0  token=0x6000821  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x096A59A0  token=0x6000822  System.Void OnReverse()
  RVA=0x096A5A2C  token=0x6000823  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimatePlaybackSpeed
TYPE:  class
TOKEN: 0x20000FD
SIZE:  0x58
EXTENDS: Slate.DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   speed  // 0x4c
  public            Slate.EaseType                  interpolation  // 0x50
  private           System.Single                   wasSpeed  // 0x54
PROPERTIES:
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969F1D8  token=0x600082A  System.Void OnCreate()
  RVA=0x0969F208  token=0x600082B  System.Void OnEnter()
  RVA=0x0969F268  token=0x600082C  System.Void OnUpdate(System.Single time)
  RVA=0x0969F238  token=0x600082D  System.Void OnReverse()
  RVA=0x0969F300  token=0x600082E  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.DebugLog
TYPE:  class
TOKEN: 0x20000FE
SIZE:  0x50
EXTENDS: Slate.DirectorActionClip
FIELDS:
  public            System.Boolean                  neverSkip  // 0x40
  public            System.String                   text  // 0x48
PROPERTIES:
  info  get=0x0969FE00
METHODS:
  RVA=0x0969FD60  token=0x6000830  System.Void OnEnter()
  RVA=0x0426FE60  token=0x6000831  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PauseCutscene
TYPE:  class
TOKEN: 0x20000FF
SIZE:  0x40
EXTENDS: Slate.DirectorActionClip
FIELDS:
METHODS:
  RVA=0x096A25B8  token=0x6000832  System.Void OnEnter()
  RVA=0x0426FE60  token=0x6000833  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScreenCapture
TYPE:  class
TOKEN: 0x2000100
SIZE:  0x40
EXTENDS: Slate.DirectorActionClip
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x6000834  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PlayAnimationClip
TYPE:  class
TOKEN: 0x2000101
SIZE:  0x88
EXTENDS: Slate.ActionClips.ActorActionClip`1
IMPLEMENTS: Slate.ISubClipContainable Slate.IDirectable
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            UnityEngine.AnimationClip       animationClip  // 0x58
  public            System.Single                   clipOffset  // 0x60
  public            System.Single                   playbackSpeed  // 0x64
  private           Slate.TransformSnapshot         snapShot  // 0x68
  private           UnityEngine.Transform           mixTransform  // 0x70
  private           UnityEngine.AnimationState      state  // 0x78
  private           System.Boolean                  isListClip  // 0x80
PROPERTIES:
  Slate.ISubClipContainable.subClipOffset  get=0x03D50D50  set=0x03D50D80
  Slate.ISubClipContainable.subClipLength  get=0x096A2C74
  Slate.ISubClipContainable.subClipSpeed  get=0x03D50D60
  info  get=0x096A2D28
  isValid  get=0x096A2D9C
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
  canCrossBlend  get=0x0232EB60
  track  get=0x096A2E2C
METHODS:
  RVA=0x096A2684  token=0x6000843  System.Void OnEnter()
  RVA=0x096A2934  token=0x6000844  System.Void OnUpdate(System.Single time)
  RVA=0x096A28B4  token=0x6000845  System.Void OnReverse()
  RVA=0x096A286C  token=0x6000846  System.Void OnExit()
  RVA=0x096A2890  token=0x6000847  System.Void OnReverseEnter()
  RVA=0x096A2CE4  token=0x6000848  System.Void .ctor()
  RVA=0x04276114  token=0x6000849  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.PlayAnimatorClip
TYPE:  class
TOKEN: 0x2000102
SIZE:  0xB0
EXTENDS: Slate.ActionClips.ActorActionClip
IMPLEMENTS: Slate.ISubClipContainable Slate.IDirectable
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.AnimationClip       animationClip  // 0x50
  public            System.Single                   clipOffset  // 0x58
  public            Slate.ActionClips.PlayAnimatorClip.ClipWrapModeclipWrapMode  // 0x5c
  public            System.Single                   clipWeight  // 0x60
  public            System.Single                   playbackSpeed  // 0x64
  public            Slate.ActionClips.PlayAnimatorClip.StartingTransformsModestartingTransformsMode  // 0x68
  public            Slate.MiniTransformSpace        transformSpace  // 0x6c
  public            UnityEngine.Vector3             startingPosition  // 0x70
  public            UnityEngine.Vector3             startingRotation  // 0x7c
  public            UnityEngine.Vector2             steerLocalRotation  // 0x88
  protected         UnityEngine.Vector3             wasPosition  // 0x90
  protected         UnityEngine.Quaternion          wasRotation  // 0x9c
PROPERTIES:
  isMasterAndManualSet  get=0x096A3780
  Slate.ISubClipContainable.subClipOffset  get=0x03D51080  set=0x03D510B0
  Slate.ISubClipContainable.subClipLength  get=0x096A3658
  Slate.ISubClipContainable.subClipSpeed  get=0x03D50D60
  info  get=0x096A3708
  isValid  get=0x096A37C8
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  canCrossBlend  get=0x0232EB60
  track  get=0x096A3874
  animator  get=0x096A36E4
  isMasterTrack  get=0x096A37A4
METHODS:
  RVA=0x096A2E68  token=0x600085B  System.Void OnEnter()
  RVA=0x096A30F0  token=0x600085C  System.Void OnReverseEnter()
  RVA=0x096A3234  token=0x600085D  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x096A308C  token=0x600085E  System.Void OnExit()
  RVA=0x096A3154  token=0x600085F  System.Void OnReverse()
  RVA=0x096A36C8  token=0x6000860  System.Void .ctor()
  RVA=0x04276114  token=0x6000861  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.PlayAudio
TYPE:  class
TOKEN: 0x2000105
SIZE:  0x80
EXTENDS: Slate.ActionClip
IMPLEMENTS: Slate.ISubClipContainable Slate.IDirectable
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.AudioClip           audioClip  // 0x50
  public            System.Single                   volume  // 0x58
  public            System.Single                   pitch  // 0x5c
  public            System.Single                   stereoPan  // 0x60
  public            System.Single                   clipOffset  // 0x64
  public            System.String                   subtitlesText  // 0x68
  public            UnityEngine.Color               subtitlesColor  // 0x70
PROPERTIES:
  Slate.ISubClipContainable.subClipOffset  get=0x03D50D60  set=0x03D50D70
  Slate.ISubClipContainable.subClipLength  get=0x096A3C14
  Slate.ISubClipContainable.subClipSpeed  get=0x03D51A60
  length  get=0x03D4EC70  set=0x03D4ECF0
  blendIn  get=0x03D4EC80  set=0x03D4ED00
  blendOut  get=0x03D58370  set=0x03D5BE60
  isValid  get=0x096A3DD8
  info  get=0x096A3D50
  track  get=0x096A3E48
  source  get=0x096A3E28
METHODS:
  RVA=0x096A3934  token=0x6000870  System.Void OnEnter()
  RVA=0x096A3934  token=0x6000871  System.Void OnReverseEnter()
  RVA=0x096A393C  token=0x6000872  System.Void OnExit()
  RVA=0x096A393C  token=0x6000873  System.Void OnReverse()
  RVA=0x096A38B0  token=0x6000874  System.Void Do()
  RVA=0x096A3944  token=0x6000875  System.Void OnUpdate(System.Single time, System.Single previousTime)
  RVA=0x096A3C84  token=0x6000876  System.Void Undo()
  RVA=0x096A3D04  token=0x6000877  System.Void .ctor()
  RVA=0x04276114  token=0x6000878  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.AnimateBoolParameter
TYPE:  class
TOKEN: 0x2000106
SIZE:  0x60
EXTENDS: Slate.ActionClips.MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   parameterName  // 0x50
  public            System.Boolean                  value  // 0x58
  private           System.Boolean                  lastValue  // 0x59
PROPERTIES:
  isValid  get=0x0969D304
  info  get=0x0969D2C4
  length  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969D12C  token=0x600087D  System.Void OnEnter()
  RVA=0x0969D258  token=0x600087E  System.Void OnUpdate(System.Single time)
  RVA=0x0969D184  token=0x600087F  System.Void OnExit()
  RVA=0x0969D1F4  token=0x6000880  System.Void OnReverse()
  RVA=0x0969D2B0  token=0x6000881  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateFloatParameter
TYPE:  class
TOKEN: 0x2000107
SIZE:  0x68
EXTENDS: Slate.ActionClips.MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   parameterName  // 0x58
  public            System.Single                   value  // 0x60
  private           System.Single                   lastValue  // 0x64
PROPERTIES:
  isValid  get=0x0969D510
  info  get=0x0969D4D0
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
METHODS:
  RVA=0x0969D334  token=0x600088A  System.Void OnEnter()
  RVA=0x0969D3F4  token=0x600088B  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x0969D390  token=0x600088C  System.Void OnReverse()
  RVA=0x0969D4AC  token=0x600088D  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateIntegerParameter
TYPE:  class
TOKEN: 0x2000108
SIZE:  0x68
EXTENDS: Slate.ActionClips.MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   parameterName  // 0x58
  public            System.Int32                    value  // 0x60
  private           System.Int32                    lastValue  // 0x64
PROPERTIES:
  isValid  get=0x0969D510
  info  get=0x0969DA30
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
METHODS:
  RVA=0x0969D89C  token=0x6000896  System.Void OnEnter()
  RVA=0x0969D958  token=0x6000897  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x0969D8F4  token=0x6000898  System.Void OnReverse()
  RVA=0x0969DA14  token=0x6000899  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateLayerWeight
TYPE:  class
TOKEN: 0x2000109
SIZE:  0x60
EXTENDS: Slate.ActionClips.MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.Int32                    layerIndex  // 0x54
  public            System.Single                   weight  // 0x58
  private           System.Single                   lastValue  // 0x5c
PROPERTIES:
  info  get=0x0969DC08
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
METHODS:
  RVA=0x0969DA70  token=0x60008A1  System.Void OnEnter()
  RVA=0x0969DB2C  token=0x60008A2  System.Void OnUpdate(System.Single deltaTime)
  RVA=0x0969DAC8  token=0x60008A3  System.Void OnReverse()
  RVA=0x0969DBE4  token=0x60008A4  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateLimbIK
TYPE:  class
TOKEN: 0x200010A
SIZE:  0x98
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            UnityEngine.AvatarIKGoal        IKGoal  // 0x54
  public            System.Single                   weight  // 0x58
  public            Slate.TransformRefPositionRotationIKTarget  // 0x60
  private           Slate.AnimatorDispatcher        dispatcher  // 0x90
PROPERTIES:
  targetPosition  get=0x0969E508  set=0x03D75030
  targetRotation  get=0x0969E53C  set=0x03D750E0
  info  get=0x0969E498
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
METHODS:
  RVA=0x0969E078  token=0x60008B0  System.Void OnCreate()
  RVA=0x0969DC68  token=0x60008B1  System.Void OnAfterValidate()
  RVA=0x0969E0B4  token=0x60008B2  System.Void OnEnter()
  RVA=0x0969E240  token=0x60008B3  System.Void OnReverseEnter()
  RVA=0x0969E338  token=0x60008B4  System.Void OnReverse()
  RVA=0x0969E1AC  token=0x60008B5  System.Void OnExit()
  RVA=0x0969E3CC  token=0x60008B6  System.Void OnRootDisabled()
  RVA=0x0969DEB4  token=0x60008B7  System.Void OnAnimatorIK(System.Int32 index)
  RVA=0x0969E444  token=0x60008B8  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateLookAtIK
TYPE:  class
TOKEN: 0x200010C
SIZE:  0x90
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4c
  private           System.Single                   _blendOut  // 0x50
  public            System.Single                   weight  // 0x54
  public            System.Single                   bodyWeight  // 0x58
  public            System.Single                   headWeight  // 0x5c
  public            System.Single                   eyesWeight  // 0x60
  public            Slate.TransformRefPosition      targetPosition  // 0x68
  private           Slate.AnimatorDispatcher        dispatcher  // 0x88
PROPERTIES:
  targetPositionVector  get=0x0969EC90  set=0x03D75100
  info  get=0x0969EC64
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x03D50200  set=0x03D5E680
  blendOut  get=0x03D51C90  set=0x03D51CA0
METHODS:
  RVA=0x0969E838  token=0x60008C4  System.Void OnCreate()
  RVA=0x0969E570  token=0x60008C5  System.Void OnAfterValidate()
  RVA=0x0969E878  token=0x60008C6  System.Void OnEnter()
  RVA=0x0969EA04  token=0x60008C7  System.Void OnReverseEnter()
  RVA=0x0969EAFC  token=0x60008C8  System.Void OnReverse()
  RVA=0x0969E970  token=0x60008C9  System.Void OnExit()
  RVA=0x0969EB90  token=0x60008CA  System.Void OnRootDisabled()
  RVA=0x0969E6F4  token=0x60008CB  System.Void OnAnimatorIK(System.Int32 index)
  RVA=0x0969EC08  token=0x60008CC  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateTrigger
TYPE:  class
TOKEN: 0x200010E
SIZE:  0x60
EXTENDS: Slate.ActionClips.MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   triggerName  // 0x50
  public            System.Boolean                  value  // 0x58
PROPERTIES:
  isValid  get=0x0969D304
  info  get=0x0969F454
  length  get=0x03D58370  set=0x03D5BE60
METHODS:
  RVA=0x0969F3CC  token=0x60008D3  System.Void OnUpdate(System.Single time)
  RVA=0x0969F444  token=0x60008D4  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.CrossFadeState
TYPE:  class
TOKEN: 0x200010F
SIZE:  0x58
EXTENDS: Slate.ActionClips.MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   stateName  // 0x50
PROPERTIES:
  info  get=0x0969FD20
  length  get=0x03D58370  set=0x03D5BE60
  blendIn  get=0x0969FD10
METHODS:
  RVA=0x0969FC7C  token=0x60008D9  System.Void OnEnter()
  RVA=0x0969F444  token=0x60008DA  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.MecanimBaseClip
TYPE:  abstract class
TOKEN: 0x2000110
SIZE:  0x48
EXTENDS: Slate.ActionClips.ActorActionClip`1
FIELDS:
PROPERTIES:
  isValid  get=0x096A1F44
METHODS:
  RVA=0x096A1C64  token=0x60008DC  System.Boolean HasParameter(System.String name)
  RVA=0x096A1F10  token=0x60008DD  System.Void .ctor()
END_CLASS

