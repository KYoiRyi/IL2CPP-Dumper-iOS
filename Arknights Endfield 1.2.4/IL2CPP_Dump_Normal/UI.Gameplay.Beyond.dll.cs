// ========================================================
// Dumped by @desirepro
// Assembly: UI.Gameplay.Beyond.dll
// Classes:  191
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0xC0
    public class UIEquipRotHelper : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.Transform _rotParent;  // 0x68
        private UnityEngine.Transform _rotTarget;  // 0x70
        private UnityEngine.Transform _posTarget;  // 0x78
        private System.Single _maxLength;  // 0x80
        private System.Collections.Generic.List<UnityEngine.Transform> _slots;  // 0x88
        private System.Collections.Generic.List<UnityEngine.Transform> _rotRoots;  // 0x90
        private System.Single _tweenTime;  // 0x98
        private UnityEngine.Vector3 m_desRot;  // 0x9c
        private UnityEngine.Vector3 m_desZero;  // 0xa8
        private System.Int32 m_curIndex;  // 0xb4
        private System.Int32 m_maxNum;  // 0xb8
        private System.Boolean <playing>k__BackingField;  // 0xbc

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.Boolean playing { get; /* RVA: 0x03D5B230 */ set; /* RVA: 0x03D5B240 */ }

        // Methods
        // RVA: 0x09B1AE7C  token: 0x6000004
        private UnityEngine.Vector3 _ClampRot(UnityEngine.Vector3 rot) { }
        // RVA: 0x09B1AF04  token: 0x6000005
        private UnityEngine.Vector3 _GetNearZero(UnityEngine.Vector3 rot) { }
        // RVA: 0x09B1AF60  token: 0x6000006
        private System.Void _Init() { }
        // RVA: 0x09B1A778  token: 0x6000007
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B1A954  token: 0x6000008
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B1A7C0  token: 0x6000009
        public System.Void SelectPart(System.Int32 index) { }
        // RVA: 0x09B1A798  token: 0x600000A
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B1B044  token: 0x600000B
        public System.Void .ctor() { }
        // RVA: 0x03D762C0  token: 0x600000C
        private System.Void <SelectPart>b__22_0() { }

    }

    // TypeToken: 0x2000003  // size: 0x98
    public class UIWatchPanelCut : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.Vector3 m_watchpanelPos;  // 0x68
        private UnityEngine.Vector3 m_watchpanelDir;  // 0x74
        private UnityEngine.Vector3 m_watchpanelRadius;  // 0x80
        public System.Single minimapRadius;  // 0x8c
        public System.Single eclosionRange;  // 0x90

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x0359F0E0  token: 0x600000E
        public System.Void Start() { }
        // RVA: 0x09B1B058  token: 0x600000F
        public UnityEngine.Vector3 GetIntersectWithLineAndPlane(UnityEngine.Vector3 point, UnityEngine.Vector3 direct, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint) { }
        // RVA: 0x0359F170  token: 0x6000010
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x02846010  token: 0x6000011
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x20
    public sealed struct StateInfo
    {
        // Fields
        public System.Int32 count;  // 0x10
        public System.String stateName;  // 0x18

    }

    // TypeToken: 0x2000012  // size: 0x14
    public sealed struct RingState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.ComboSpecialNodeRingQte.RingState None;  // const
        public static Beyond.UI.ComboSpecialNodeRingQte.RingState EarlyState;  // const
        public static Beyond.UI.ComboSpecialNodeRingQte.RingState PerfectState;  // const
        public static Beyond.UI.ComboSpecialNodeRingQte.RingState MissState;  // const
        public static Beyond.UI.ComboSpecialNodeRingQte.RingState PressedState;  // const

    }

    // TypeToken: 0x2000015  // size: 0x28
    public sealed struct CoalitionDetail
    {
        // Fields
        public Beyond.UI.DamageTextBase instance;  // 0x10
        public System.Single time;  // 0x18
        public System.Double value;  // 0x20

    }

    // TypeToken: 0x2000017  // size: 0x28
    public sealed struct CoalitionDetail
    {
        // Fields
        public Beyond.UI.DamageTextBaseV2 instance;  // 0x10
        public System.Single time;  // 0x18
        public System.Double value;  // 0x20

    }

    // TypeToken: 0x2000018  // size: 0x28
    public class IgnitePrefabOverride
    {
        // Fields
        public Beyond.GEnums.EnergyShardType energyShardType;  // 0x10
        public System.String overrideName;  // 0x18
        public System.Boolean isCrystBreak;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000064
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x20
    public class SpawnPointConfig
    {
        // Fields
        public Beyond.Gameplay.Core.ObjectType objectType;  // 0x10
        public System.Boolean followTarget;  // 0x14
        public System.Boolean useHitPoint;  // 0x15
        public Beyond.Gameplay.MountPoint targetMountPoint;  // 0x18

        // Methods
        // RVA: 0x03D762B0  token: 0x6000079
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x20
    public class SpawnPointConfig
    {
        // Fields
        public Beyond.Gameplay.Core.ObjectType objectType;  // 0x10
        public System.Boolean followTarget;  // 0x14
        public System.Boolean useHitPoint;  // 0x15
        public Beyond.Gameplay.MountPoint targetMountPoint;  // 0x18

        // Methods
        // RVA: 0x03D762B0  token: 0x6000091
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct DamageTextSortingPriority
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.DamageTextBaseV2.DamageTextSortingPriority Level0;  // const
        public static Beyond.UI.DamageTextBaseV2.DamageTextSortingPriority Level1;  // const
        public static Beyond.UI.DamageTextBaseV2.DamageTextSortingPriority Level2;  // const

    }

    // TypeToken: 0x200001E  // size: 0x58
    public class DamageTextBaseConfig
    {
        // Fields
        public Beyond.UI.DamageTextType type;  // 0x10
        public System.Single showDuration;  // 0x14
        public System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2.SpawnPointConfig> spawnPointConfigs;  // 0x18
        public Beyond.UI.DamageTextBaseV2.DamageTextSortingPriority sortingPriority;  // 0x20
        public System.String prefabName;  // 0x28
        public System.Single textNodeAlpha;  // 0x30
        public System.Collections.Generic.List<System.String> textNodeName;  // 0x38
        public System.Collections.Generic.List<System.String> colorNodeName;  // 0x40
        public System.String leftAnimation;  // 0x48
        public System.String rightAnimation;  // 0x50

        // Methods
        // RVA: 0x03585FF0  token: 0x6000092
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000028  // size: 0x14
    public sealed struct HeadBarType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.HeadBarCtrl.HeadBarType Mob;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarType Elite;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarType EnemyPart;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarType CNT;  // const

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct HeadBarRefreshReason
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason OnCreate;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason OnAddHeadBar;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason OnRemoveHeadBar;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason OnHeadBarShowConfigChanged;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason TakeDamage;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason FullHpOrZeroHp;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason EnemyPartEnableChanged;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason LateUpdate;  // const
        public static Beyond.UI.HeadBarCtrl.HeadBarRefreshReason Dialog;  // const

    }

    // TypeToken: 0x200002A  // size: 0x30
    public sealed class <>c__DisplayClass52_0
    {
        // Fields
        public Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr;  // 0x10
        public Beyond.UI.UIHeadBarFollower bar;  // 0x20
        public Beyond.UI.HeadBarCtrl <>4__this;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60000D2
        public System.Void .ctor() { }
        // RVA: 0x09B1DEA4  token: 0x60000D3
        private System.Void <_RefreshHeadBar>b__1() { }
        // RVA: 0x09B1DF5C  token: 0x60000D4
        private System.Void <_RefreshHeadBar>b__2() { }

    }

    // TypeToken: 0x200002B  // size: 0x30
    public sealed class <>c__DisplayClass56_0
    {
        // Fields
        public Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr;  // 0x10
        public Beyond.UI.UILvInfoBar bar;  // 0x20
        public Beyond.UI.HeadBarCtrl <>4__this;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60000D5
        public System.Void .ctor() { }
        // RVA: 0x09B1DFDC  token: 0x60000D6
        private System.Void <_UpdateLevelInfoBar>b__0() { }

    }

    // TypeToken: 0x200002C  // size: 0x30
    public sealed class <>c__DisplayClass58_0
    {
        // Fields
        public Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr;  // 0x10
        public Beyond.UI.UITacticalItemBar bar;  // 0x20
        public Beyond.UI.HeadBarCtrl <>4__this;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x60000D7
        public System.Void .ctor() { }
        // RVA: 0x09B1E05C  token: 0x60000D8
        private System.Void <_UpdateTacticalItemBar>b__0() { }

    }

    // TypeToken: 0x200002F  // size: 0x14
    public sealed struct HpDisplayState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIHeadBar.HpDisplayState Normal;  // const
        public static Beyond.UI.UIHeadBar.HpDisplayState Stay;  // const
        public static Beyond.UI.UIHeadBar.HpDisplayState Decrease;  // const

    }

    // TypeToken: 0x2000032  // size: 0x14
    public sealed struct HeadLabelType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIHeadLabel.HeadLabelType Root;  // const
        public static Beyond.UI.UIHeadLabel.HeadLabelType Bubble;  // const
        public static Beyond.UI.UIHeadLabel.HeadLabelType Text;  // const
        public static Beyond.UI.UIHeadLabel.HeadLabelType Icon;  // const
        public static Beyond.UI.UIHeadLabel.HeadLabelType Count;  // const

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct VisibleSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIHeadLabel.VisibleSource Comp;  // const
        public static Beyond.UI.UIHeadLabel.VisibleSource System;  // const
        public static Beyond.UI.UIHeadLabel.VisibleSource FloatingUI;  // const
        public static Beyond.UI.UIHeadLabel.VisibleSource Count;  // const

    }

    // TypeToken: 0x2000034  // size: 0x20
    public class HeadLabelRootData
    {
        // Fields
        public UnityEngine.Transform root;  // 0x10
        public Beyond.UI.UIHeadLabel.HeadLabelType headLabelType;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000126
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x28
    public class HeadLabelRootVisibleData
    {
        // Fields
        public UnityEngine.Vector3 originalPosition;  // 0x10
        public System.Collections.Generic.Dictionary<Beyond.UI.UIHeadLabel.VisibleSource,System.Boolean> visibleSource;  // 0x20

        // Properties
        System.Boolean realVisible { get; /* RVA: 0x02C74400 */ }

        // Methods
        // RVA: 0x03294890  token: 0x6000128
        public System.Void Init(UnityEngine.Vector3 position) { }
        // RVA: 0x02C73E70  token: 0x6000129
        public System.Void UpdateVisible(Beyond.UI.UIHeadLabel.VisibleSource source, System.Boolean visible) { }
        // RVA: 0x032948D0  token: 0x600012A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000036  // size: 0x20
    public sealed class <>c__DisplayClass49_0
    {
        // Fields
        public Beyond.UI.UIHeadLabel.HeadLabelType headLabelType;  // 0x10
        public Beyond.UI.UIHeadLabel <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600012B
        public System.Void .ctor() { }
        // RVA: 0x02C73CA0  token: 0x600012C
        private System.Void <_UpdateFloatingUIVisibleCallback>b__0(System.Boolean visible) { }

    }

    // TypeToken: 0x2000039  // size: 0x14
    public sealed struct PoiseDisplayState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIPoiseBar.PoiseDisplayState Normal;  // const
        public static Beyond.UI.UIPoiseBar.PoiseDisplayState Stay;  // const
        public static Beyond.UI.UIPoiseBar.PoiseDisplayState Increase;  // const

    }

    // TypeToken: 0x200003F  // size: 0x18
    public sealed class <>c__DisplayClass24_0
    {
        // Fields
        public Beyond.UI.AtbCell cell;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000164
        public System.Void .ctor() { }
        // RVA: 0x09B1DE88  token: 0x6000165
        private System.Void <OnGainAtb>b__0() { }

    }

    // TypeToken: 0x2000042  // size: 0x20
    public sealed class <>c__DisplayClass19_0
    {
        // Fields
        public Beyond.UI.ComboSkillHint hint;  // 0x10
        public Beyond.UI.ComboSkillPanel <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000180
        public System.Void .ctor() { }
        // RVA: 0x09B1DE00  token: 0x6000181
        private System.Void <_RemoveComboSkill>b__0() { }

    }

    // TypeToken: 0x2000043  // size: 0x18
    public sealed class <>c__DisplayClass20_0
    {
        // Fields
        public Beyond.UI.ComboSkillHint hint;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000182
        public System.Void .ctor() { }
        // RVA: 0x09B1DE34  token: 0x6000183
        private System.Void <_OnComboSkillClearAll>b__0() { }

    }

    // TypeToken: 0x2000044  // size: 0x20
    public sealed class <>c__DisplayClass21_0
    {
        // Fields
        public Beyond.UI.ComboSkillPanel <>4__this;  // 0x10
        public Beyond.UI.ComboSkillHint hint;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000184
        public System.Void .ctor() { }
        // RVA: 0x09B1DE54  token: 0x6000185
        private System.Void <CastComboSkill>b__0() { }

    }

    // TypeToken: 0x2000047  // size: 0x20
    public sealed struct HpScreenEffectConfig
    {
        // Fields
        public System.Single minHpPercent;  // 0x10
        public System.Single maxHpPercent;  // 0x14
        public System.String effectName;  // 0x18

    }

    // TypeToken: 0x2000049  // size: 0x28
    public class Arrow
    {
        // Fields
        public UnityEngine.GameObject obj;  // 0x10
        public UnityEngine.RectTransform rect;  // 0x18
        public Beyond.UI.UIAnimationWrapper anim;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60001C3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004A  // size: 0x20
    public sealed class <>c__DisplayClass13_0
    {
        // Fields
        public Beyond.UI.OutOfScreenTargetsCtrl.Arrow arrow;  // 0x10
        public Beyond.UI.OutOfScreenTargetsCtrl <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001C4
        public System.Void .ctor() { }
        // RVA: 0x09B26B14  token: 0x60001C5
        private System.Void <LateTick>b__0() { }

    }

    // TypeToken: 0x200004C  // size: 0x14
    public sealed struct PressingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.SkillButton.PressingMode None;  // const
        public static Beyond.UI.SkillButton.PressingMode Normal;  // const
        public static Beyond.UI.SkillButton.PressingMode Ultimate;  // const

    }

    // TypeToken: 0x200004D  // size: 0x18
    public abstract class PressHandler
    {
        // Fields
        protected Beyond.UI.SkillButton m_owner;  // 0x10

        // Properties
        Beyond.Gameplay.SkillSetting skillSetting { get; /* RVA: 0x09B24B94 */ }
        System.Boolean needUpdate { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60001F0
        public System.Void .ctor(Beyond.UI.SkillButton owner) { }
        // RVA: -1  // abstract  token: 0x60001F2
        public virtual System.Void OnPressStart() { }
        // RVA: -1  // abstract  token: 0x60001F3
        public virtual System.Void OnUpdate(System.Single deltaTime) { }
        // RVA: -1  // abstract  token: 0x60001F4
        public virtual System.Void OnPressEnd() { }
        // RVA: -1  // abstract  token: 0x60001F5
        public virtual System.Void OnPressCancel() { }
        // RVA: 0x09B24B50  token: 0x60001F6
        public virtual System.Void OnOtherPressSkillButtonStart() { }

    }

    // TypeToken: 0x200004E  // size: 0x20
    public class PressHandlerLongPress : PressHandler
    {
        // Fields
        private Beyond.UI.SkillButton.PressingMode m_pressingMode;  // 0x18
        private System.Single m_pressingSkillTime;  // 0x1c

        // Properties
        System.Boolean needUpdate { get; /* RVA: 0x0338DE50 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60001F8
        public System.Void .ctor(Beyond.UI.SkillButton owner) { }
        // RVA: 0x09B248D0  token: 0x60001F9
        public virtual System.Void OnPressStart() { }
        // RVA: 0x033B2BC0  token: 0x60001FA
        public virtual System.Void OnUpdate(System.Single deltaTime) { }
        // RVA: 0x09B246CC  token: 0x60001FB
        public virtual System.Void OnPressEnd() { }
        // RVA: 0x02B78970  token: 0x60001FC
        public virtual System.Void OnPressCancel() { }
        // RVA: 0x09B24660  token: 0x60001FD
        public virtual System.Void OnOtherPressSkillButtonStart() { }
        // RVA: 0x09B24B48  token: 0x60001FE
        public System.Void <>iFixBaseProxy_OnOtherPressSkillButtonStart() { }

    }

    // TypeToken: 0x200004F  // size: 0x20
    public class PressHandlerIndividualUltimate : PressHandler
    {
        // Fields
        private Beyond.UI.SkillButton.PressingMode m_pressingMode;  // 0x18
        private System.Single m_pressingSkillTime;  // 0x1c

        // Properties
        System.Boolean needUpdate { get; /* RVA: 0x05925600 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000200
        public System.Void .ctor(Beyond.UI.SkillButton owner) { }
        // RVA: 0x09B244D8  token: 0x6000201
        public virtual System.Void OnPressStart() { }
        // RVA: 0x09B245A0  token: 0x6000202
        public virtual System.Void OnUpdate(System.Single deltaTime) { }
        // RVA: 0x09B243E0  token: 0x6000203
        public virtual System.Void OnPressEnd() { }
        // RVA: 0x09B2432C  token: 0x6000204
        public virtual System.Void OnPressCancel() { }

    }

    // TypeToken: 0x2000050  // size: 0x50
    public class PressHandlerDrag : PressHandler
    {
        // Fields
        private Beyond.UI.SkillButton.PressingMode m_pressingMode;  // 0x18
        private System.Single m_pressingSkillTime;  // 0x1c
        private UnityEngine.RectTransform m_indicatorRoot;  // 0x20
        private System.Single m_cancelRadiusSqr;  // 0x28
        private Beyond.UI.UIAnimationWrapper m_indicatorAnim;  // 0x30
        private System.Boolean m_inCancelArea;  // 0x38
        private Beyond.UI.UIText m_ultimateName;  // 0x40
        private Beyond.UI.UIImage m_ultimateIcon;  // 0x48

        // Properties
        System.Boolean needUpdate { get; /* RVA: 0x05925600 */ }

        // Methods
        // RVA: 0x09B24030  token: 0x6000206
        public System.Void .ctor(Beyond.UI.SkillButton owner) { }
        // RVA: 0x09B239B8  token: 0x6000207
        public virtual System.Void OnPressStart() { }
        // RVA: 0x09B23BE4  token: 0x6000208
        public virtual System.Void OnUpdate(System.Single deltaTime) { }
        // RVA: 0x09B23F98  token: 0x6000209
        private System.Boolean _InCancelArea() { }
        // RVA: 0x09B23774  token: 0x600020A
        public virtual System.Void OnPressEnd() { }
        // RVA: 0x09B236AC  token: 0x600020B
        public virtual System.Void OnPressCancel() { }

    }

    // TypeToken: 0x2000056  // size: 0x30
    public sealed class <>c__DisplayClass25_0
    {
        // Fields
        public Beyond.UI.UIBuffCell <>4__this;  // 0x10
        public System.String inputSpritePath;  // 0x18
        public System.Action onSpriteLoaded;  // 0x20
        public System.UInt64 cachedLoadKey;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000262
        public System.Void .ctor() { }
        // RVA: 0x03923D80  token: 0x6000263
        private System.Void <Init>b__0(UnityEngine.Sprite sprite) { }

    }

    // TypeToken: 0x2000058  // size: 0x14
    public sealed struct BuffNodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIBuffNode.BuffNodeType HeadBarCommon;  // const
        public static Beyond.UI.UIBuffNode.BuffNodeType HeadBarAttached;  // const
        public static Beyond.UI.UIBuffNode.BuffNodeType SquadIconCommon;  // const
        public static Beyond.UI.UIBuffNode.BuffNodeType MainCharHpBarCommon;  // const

    }

    // TypeToken: 0x2000059  // size: 0x38
    public class BuffCellGroup
    {
        // Fields
        public Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle buffIconStyle;  // 0x10
        public Beyond.UI.UIBuffCell buffCellTemplate;  // 0x18
        public System.Collections.Generic.List<Beyond.UI.UIBuffCell> buffCellPool;  // 0x20
        public Beyond.DynamicFastLookupCollection<System.UInt64,Beyond.UI.UIBuffCell> buffCellDict;  // 0x28
        public Beyond.DynamicFastLookupCollection<System.UInt64,Beyond.UI.UIBuffCell> buffCellWithOutAnim;  // 0x30

        // Methods
        // RVA: 0x02B5CDD0  token: 0x600027C
        public Beyond.UI.UIBuffCell CreateBuffCell(UnityEngine.Transform transform) { }
        // RVA: 0x09B235EC  token: 0x600027D
        public System.Void RemoveBuffCell(Beyond.UI.UIBuffCell buffCell) { }
        // RVA: 0x02B725E0  token: 0x600027E
        public System.Void ClearAllBuffCells(Beyond.LuaResourceLoader loader) { }
        // RVA: 0x0350B670  token: 0x600027F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005A  // size: 0x28
    public sealed class <>c__DisplayClass27_0
    {
        // Fields
        public Beyond.UI.UIBuffNode <>4__this;  // 0x10
        public System.Boolean playAnim;  // 0x18
        public Beyond.Gameplay.Core.BuffData buffData;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000280
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x20
    public sealed class <>c__DisplayClass27_1
    {
        // Fields
        public Beyond.UI.UIBuffCell newBuffCell;  // 0x10
        public Beyond.UI.UIBuffNode.<>c__DisplayClass27_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000281
        public System.Void .ctor() { }
        // RVA: 0x09B26BB8  token: 0x6000282
        private System.Void <_AddBuffIconInternal>b__0() { }

    }

    // TypeToken: 0x200005C  // size: 0x20
    public sealed class <>c__DisplayClass27_2
    {
        // Fields
        public Beyond.UI.UIBuffCell buffCell;  // 0x10
        public Beyond.UI.UIBuffNode.<>c__DisplayClass27_0 CS$<>8__locals2;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000283
        public System.Void .ctor() { }
        // RVA: 0x09B26C04  token: 0x6000284
        private System.Void <_AddBuffIconInternal>b__1() { }

    }

    // TypeToken: 0x200005D  // size: 0x20
    public sealed class <>c__DisplayClass27_3
    {
        // Fields
        public Beyond.UI.UIBuffCell buffCell;  // 0x10
        public Beyond.UI.UIBuffNode.<>c__DisplayClass27_0 CS$<>8__locals3;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000285
        public System.Void .ctor() { }
        // RVA: 0x02B5C7E0  token: 0x6000286
        private System.Void <_AddBuffIconInternal>b__2() { }

    }

    // TypeToken: 0x200005E  // size: 0x30
    public sealed class <>c__DisplayClass28_0
    {
        // Fields
        public Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr;  // 0x10
        public Beyond.UI.UIBuffNode.BuffCellGroup buffCellGroup;  // 0x20
        public Beyond.UI.UIBuffNode <>4__this;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000287
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x28
    public sealed class <>c__DisplayClass28_1
    {
        // Fields
        public System.Collections.Generic.List<Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff>> stackBuffList;  // 0x10
        public Beyond.UI.UIBuffCell buffCell;  // 0x18
        public Beyond.UI.UIBuffNode.<>c__DisplayClass28_0 CS$<>8__locals1;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000288
        public System.Void .ctor() { }
        // RVA: 0x09B26D08  token: 0x6000289
        private System.Void <_RemoveBuffIconInternal>b__0() { }
        // RVA: 0x09B26E1C  token: 0x600028A
        private System.Void <_RemoveBuffIconInternal>b__1() { }

    }

    // TypeToken: 0x2000060  // size: 0x20
    public sealed class <>c__DisplayClass28_2
    {
        // Fields
        public Beyond.UI.UIBuffCell buffCell;  // 0x10
        public Beyond.UI.UIBuffNode.<>c__DisplayClass28_0 CS$<>8__locals2;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600028B
        public System.Void .ctor() { }
        // RVA: 0x09B26F30  token: 0x600028C
        private System.Void <_RemoveBuffIconInternal>b__2() { }
        // RVA: 0x09B27004  token: 0x600028D
        private System.Void <_RemoveBuffIconInternal>b__3() { }

    }

    // TypeToken: 0x200006F  // size: 0x14
    public sealed struct CommonTrackItemState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CommonTrackerUpdate.CommonTrackItemState Show;  // const
        public static Beyond.UI.CommonTrackerUpdate.CommonTrackItemState Hide;  // const
        public static Beyond.UI.CommonTrackerUpdate.CommonTrackItemState ShowToHide;  // const

    }

    // TypeToken: 0x2000070  // size: 0x14
    public sealed struct CommonTrackerDataState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CommonTrackerUpdate.CommonTrackerDataState Active;  // const
        public static Beyond.UI.CommonTrackerUpdate.CommonTrackerDataState InActive;  // const

    }

    // TypeToken: 0x2000071  // size: 0x28
    public class CommonTrackerData
    {
        // Fields
        public Beyond.UI.CommonTrackerUpdate.CommonTrackerDataState activeState;  // 0x10
        public Beyond.Gameplay.CommonTrackingPointInfoBase trackData;  // 0x18
        public System.String key;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600031D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000072  // size: 0x28
    public class CommonTrackerItem
    {
        // Fields
        public Beyond.UI.CommonTrackerUpdate.CommonTrackItemState showState;  // 0x10
        public UnityEngine.GameObject obj;  // 0x18
        public Beyond.UI.CommonTrackerNodeComp commonTrackerNodeComp;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600031E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x14
    public sealed struct ETemperatureState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState None;  // const
        public static Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState Low;  // const
        public static Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState Safe;  // const
        public static Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState High;  // const
        public static Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState Finish;  // const

    }

    // TypeToken: 0x200007A  // size: 0x10
    public static class CoolerUnitLangKeys
    {
        // Fields
        public static System.String TOO_COLD;  // const
        public static System.String GOOD;  // const
        public static System.String TOO_HOT;  // const
        public static System.String FINISH;  // const

    }

    // TypeToken: 0x200007C  // size: 0x14
    public sealed struct TempColorState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.CoolerUnitTemperatureUI.TempColorState Blue;  // const
        public static Beyond.UI.CoolerUnitTemperatureUI.TempColorState Green;  // const
        public static Beyond.UI.CoolerUnitTemperatureUI.TempColorState Red;  // const

    }

    // TypeToken: 0x200007F  // size: 0x20
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public Beyond.UI.FacLineCell <>4__this;  // 0x10
        public DG.Tweening.TweenCallback callback;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600036D
        public System.Void .ctor() { }
        // RVA: 0x09B3030C  token: 0x600036E
        private System.Void <PlayLineDecoAnimation>b__0() { }

    }

    // TypeToken: 0x2000081  // size: 0x28
    public sealed struct LineData
    {
        // Fields
        public Beyond.UI.FacLineCell start;  // 0x10
        public Beyond.UI.FacLineCell end;  // 0x18
        public Beyond.UI.FacLineCell link;  // 0x20

    }

    // TypeToken: 0x2000087  // size: 0x14
    public sealed struct ETemperatureState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState None;  // const
        public static Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState Low;  // const
        public static Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState Safe;  // const
        public static Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState High;  // const
        public static Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState Finish;  // const

    }

    // TypeToken: 0x2000090  // size: 0x18
    public class CraneSpritePath
    {
        // Fields
        public System.String stateSpritePath;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60003FF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000093  // size: 0x14
    public sealed struct MaskShapeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UILevelMapLimitInRect.MaskShapeType Rectangle;  // const
        public static Beyond.UI.UILevelMapLimitInRect.MaskShapeType Circle;  // const

    }

    // TypeToken: 0x2000096  // size: 0x14
    public sealed struct DisappearRectShapeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UILevelMapMissionArea.DisappearRectShapeType Rectangle;  // const
        public static Beyond.UI.UILevelMapMissionArea.DisappearRectShapeType Circle;  // const

    }

    // TypeToken: 0x2000099  // size: 0x18
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public System.String targetLevelId;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000433
        public System.Void .ctor() { }
        // RVA: 0x09B3AE50  token: 0x6000434
        private System.Void <InitSwitchButton>b__0(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x200009F  // size: 0x18
    public class SettlementRegionSpritePath
    {
        // Fields
        public System.String path;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000454
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0  // size: 0x18
    public class SettlementRegionSpriteData
    {
        // Fields
        public Beyond.SerializeFieldDictionary<System.Int32,Beyond.UI.UISettlementRegion.SettlementRegionSpritePath> spriteWithTier;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000455
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF  // size: 0x28
    public class IconGroup
    {
        // Fields
        public UnityEngine.GameObject root;  // 0x10
        public UnityEngine.UI.Image normal;  // 0x18
        public UnityEngine.UI.Image error;  // 0x20

        // Properties
        System.Boolean activeSelf { get; /* RVA: 0x09B39040 */ }

        // Methods
        // RVA: 0x09B38F50  token: 0x60004C2
        public System.Void SetActiveIfNecessary(System.Boolean active) { }
        // RVA: 0x09B38FB0  token: 0x60004C3
        public System.Void Switch(System.Boolean err) { }
        // RVA: 0x0350B670  token: 0x60004C5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0  // size: 0x38
    public class StatusHintGroup
    {
        // Fields
        public UnityEngine.GameObject root;  // 0x10
        public UnityEngine.GameObject localLinkHint;  // 0x18
        public UnityEngine.GameObject globalLinkHint;  // 0x20
        public UnityEngine.GameObject outageHint;  // 0x28
        public UnityEngine.GameObject distLimitHint;  // 0x30

        // Methods
        // RVA: 0x09B3ADAC  token: 0x60004C6
        public System.Void Switch(Beyond.Gameplay.Factory.PowerAutoConnectStatus status) { }
        // RVA: 0x0350B670  token: 0x60004C7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2  // size: 0x20
    public sealed struct TravelPoleStatusSetting
    {
        // Fields
        public System.Boolean showTextInfoBg;  // 0x10
        public UnityEngine.GameObject textToShow;  // 0x18

    }

    // TypeToken: 0x20000B4  // size: 0x14
    public sealed struct ERank
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.UIRaceModuleRankController.ERank None;  // const
        public static Beyond.UI.UIRaceModuleRankController.ERank First;  // const
        public static Beyond.UI.UIRaceModuleRankController.ERank Second;  // const
        public static Beyond.UI.UIRaceModuleRankController.ERank Third;  // const
        public static Beyond.UI.UIRaceModuleRankController.ERank Fourth;  // const
        public static Beyond.UI.UIRaceModuleRankController.ERank Fifth;  // const

    }

    // TypeToken: 0x20000BB  // size: 0x1C
    public sealed struct __StaticArrayInitTypeSize=12
    {
    }

    // TypeToken: 0x20000BA  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Fields
        private static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 11328A8F924E37E9332EFD9B6E621017D16D4199479DF8ADFCC16A5EB52CB3EB;  // static @ 0x0

    }

namespace Beyond.PoolCore
{

    // TypeToken: 0x2000005  // size: 0x10
    public static class ListPoolInitializer_UI_Gameplay_Beyond
    {
        // Fields
        private static System.Boolean s_initialized;  // static @ 0x0

        // Methods
        // RVA: 0x03CB2B30  token: 0x6000013
        private static System.Void InitializeAtRuntime() { }
        // RVA: 0x03CB2B60  token: 0x6000014
        private static System.Void Initialize() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000006  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000015
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000016
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000017
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000018
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000019
        public System.Void .ctor() { }

    }

}

namespace Beyond.UI
{

    // TypeToken: 0x200000B  // size: 0x18
    public abstract class UICharPassiveBase : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600001A
        public virtual System.Void OnCharPassiveNumChanged(System.Single num) { }
        // RVA: 0x0426FE60  token: 0x600001B
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x50
    public class UICharPassiveCounter : Beyond.UI.UICharPassiveBase
    {
        // Fields
        public Beyond.UI.UIState.UIStateController stateController;  // 0x18
        public UnityEngine.GameObject countTextRoot;  // 0x20
        public Beyond.UI.UIText countText;  // 0x28
        public Beyond.UI.UIImage[] layerImages;  // 0x30
        public System.String normalStateName;  // 0x38
        public System.String activeStateName;  // 0x40
        public System.Int32 activeCount;  // 0x48
        private System.Int32 m_currentCount;  // 0x4c

        // Methods
        // RVA: 0x09B1A400  token: 0x600001C
        public virtual System.Void OnCharPassiveNumChanged(System.Single num) { }
        // RVA: 0x0426FE60  token: 0x600001D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x38
    public class UICharPassiveMultiStates : Beyond.UI.UICharPassiveBase
    {
        // Fields
        public Beyond.UI.UIState.UIStateController stateController;  // 0x18
        public Beyond.UI.UIText countText;  // 0x20
        public Beyond.UI.UICharPassiveMultiStates.StateInfo[] states;  // 0x28
        public System.Int32 fullCount;  // 0x30
        private System.Int32 m_currentCount;  // 0x34

        // Methods
        // RVA: 0x02CD15E0  token: 0x600001E
        public virtual System.Void OnCharPassiveNumChanged(System.Single num) { }
        // RVA: 0x0426FE60  token: 0x600001F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x70
    public class UICharPassiveZhuangfy : Beyond.UI.UICharPassiveBase
    {
        // Fields
        public Beyond.UI.UIState.UIStateController stateController;  // 0x18
        public Beyond.UI.UIText countText;  // 0x20
        public Beyond.UI.UICharPassiveMultiStates.StateInfo[] states;  // 0x28
        public Beyond.UI.UIImage[] layerImages;  // 0x30
        public System.Int32 fullCount;  // 0x38
        public UnityEngine.Color emptyColor;  // 0x3c
        public UnityEngine.Color normalColor;  // 0x4c
        public UnityEngine.Color overloadColor;  // 0x5c
        private System.Int32 m_currentCount;  // 0x6c

        // Methods
        // RVA: 0x09B1A5AC  token: 0x6000020
        public virtual System.Void OnCharPassiveNumChanged(System.Single num) { }
        // RVA: 0x0426FE60  token: 0x6000021
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x20
    public abstract class ComboSpecialNodeBase : UnityEngine.MonoBehaviour
    {
        // Fields
        protected Beyond.UI.ComboSkillHint m_owner;  // 0x18

        // Properties
        System.Boolean needTick { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: 0x09B0D164  token: 0x6000023
        public virtual System.Void OnAssignData(Beyond.UI.ComboSkillHint owner) { }
        // RVA: 0x09B0D204  token: 0x6000024
        public virtual System.Void OnReady() { }
        // RVA: 0x09B0D284  token: 0x6000025
        public virtual System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x09B0D1C4  token: 0x6000026
        public virtual System.Void OnCast() { }
        // RVA: 0x09B0D244  token: 0x6000027
        public virtual System.Void OnRemove() { }
        // RVA: -1  // abstract  token: 0x6000028
        public virtual System.Void OnRelease() { }
        // RVA: 0x0426FE60  token: 0x6000029
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x70
    public class ComboSpecialNodeRingQte : Beyond.UI.ComboSpecialNodeBase
    {
        // Fields
        public UnityEngine.RectTransform ring;  // 0x20
        public UnityEngine.RectTransform perfectRegion;  // 0x28
        public Beyond.UI.UIState.UIStateController ringStateController;  // 0x30
        public Beyond.UI.UIAnimationWrapper anim;  // 0x38
        private System.Single m_initialWidth;  // 0x40
        private System.Single m_perfectWidth;  // 0x44
        private System.Single m_missWidth;  // 0x48
        private System.Single m_totalTime;  // 0x4c
        private System.Single m_activeStartTime;  // 0x50
        private System.Single m_remainTimeWhenStart;  // 0x54
        private Beyond.UI.ComboSpecialNodeRingQte.RingState m_currentState;  // 0x58
        private UnityEngine.GameObject m_bgRing01;  // 0x60
        private UnityEngine.GameObject m_bgRing02;  // 0x68

        // Properties
        System.Boolean needTick { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: 0x09B0D2D4  token: 0x600002B
        public virtual System.Void OnAssignData(Beyond.UI.ComboSkillHint owner) { }
        // RVA: 0x09B0D860  token: 0x600002C
        public virtual System.Void OnCast() { }
        // RVA: 0x09B0DB58  token: 0x600002D
        public virtual System.Void OnRemove() { }
        // RVA: 0x09B0DBA8  token: 0x600002E
        public virtual System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x09B0DA28  token: 0x600002F
        public virtual System.Void OnRelease() { }
        // RVA: 0x09B0DF30  token: 0x6000030
        private System.Void _OnComboSkillRingQte(Beyond.EventData<System.Int32,System.Single,System.Single>& evtData) { }
        // RVA: 0x09B0DE6C  token: 0x6000031
        private System.Single _GetRemainTime() { }
        // RVA: 0x09B0E09C  token: 0x6000032
        private System.Void _Reset() { }
        // RVA: 0x09B0E128  token: 0x6000033
        public System.Void .ctor() { }
        // RVA: 0x09B0DE4C  token: 0x6000034
        public System.Void <>iFixBaseProxy_OnAssignData(Beyond.UI.ComboSkillHint P0) { }
        // RVA: 0x09B0DE54  token: 0x6000035
        public System.Void <>iFixBaseProxy_OnCast() { }
        // RVA: 0x09B0DE5C  token: 0x6000036
        public System.Void <>iFixBaseProxy_OnRemove() { }
        // RVA: 0x09B0DE64  token: 0x6000037
        public System.Void <>iFixBaseProxy_OnTick(System.Single P0) { }

    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct DamageTextType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.DamageTextType Level0Normal;  // const
        public static Beyond.UI.DamageTextType Level1Normal;  // const
        public static Beyond.UI.DamageTextType Level0Critical;  // const
        public static Beyond.UI.DamageTextType Level1Critical;  // const
        public static Beyond.UI.DamageTextType Level0Block;  // const
        public static Beyond.UI.DamageTextType Level1Block;  // const
        public static Beyond.UI.DamageTextType EnemyDamage;  // const
        public static Beyond.UI.DamageTextType Heal;  // const
        public static Beyond.UI.DamageTextType IgniteBuff;  // const
        public static Beyond.UI.DamageTextType Airborne;  // const
        public static Beyond.UI.DamageTextType Crush;  // const
        public static Beyond.UI.DamageTextType KnockDown;  // const
        public static Beyond.UI.DamageTextType Fracture;  // const
        public static Beyond.UI.DamageTextType Immune;  // const
        public static Beyond.UI.DamageTextType CommonFlowText;  // const
        public static Beyond.UI.DamageTextType LevelUpText;  // const

    }

    // TypeToken: 0x2000014  // size: 0x190
    public class DamageTextCtrl : Beyond.UI.UIPanelBase
    {
        // Fields
        public UnityEngine.RectTransform content;  // 0x70
        public UnityEngine.RectTransform prefabNode;  // 0x78
        public UnityEngine.Vector2 textRandomAreaSize;  // 0x80
        public UnityEngine.Vector2 textMinDist;  // 0x88
        public System.Int32 textPosMaxRandomTimes;  // 0x90
        public UnityEngine.Color damageTextColorPhysical;  // 0x94
        public UnityEngine.Color damageTextColorReal;  // 0xa4
        public UnityEngine.Color damageTextColorFire;  // 0xb4
        public UnityEngine.Color damageTextColorPulse;  // 0xc4
        public UnityEngine.Color damageTextColorCryst;  // 0xd4
        public UnityEngine.Color damageTextColorNatural;  // 0xe4
        public UnityEngine.Color damageTextColorEther;  // 0xf4
        public UnityEngine.Vector2 mainChrDmgTxtSpawnOffset;  // 0x104
        public UnityEngine.Vector2 mainChrDmgTxtMoveSpawnOffset;  // 0x10c
        public System.Int32 mainChrDmgTxtMoveNum;  // 0x114
        public System.Single mainChrDmgTxtMoveSpawnWaitTime;  // 0x118
        public UnityEngine.Vector2 guardDmgTxtSpawnOffset;  // 0x11c
        public UnityEngine.Vector2 guardDmgTxtSpawnAreaSize;  // 0x124
        public System.Single dmgTxtCoalitionMaxTime;  // 0x12c
        public System.Boolean enableGuardDmgTxtOverwrite;  // 0x130
        public UnityEngine.Vector2 physicalInflictionTextOffset;  // 0x134
        public UnityEngine.Vector2 spellInflictionTextOffset;  // 0x13c
        private static readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,System.Int32> PRE_LOAD_TEXT_COUNTS;  // static @ 0x0
        private static System.String GUARD_OVERWRITE_COALITION_KEY;  // const
        private static System.String CRYST_BREAK_TEXT_ID;  // const
        private System.Boolean m_isShow;  // 0x144
        private readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,Beyond.UI.DamageTextBase> m_textPrefabMap;  // 0x148
        private readonly System.Collections.Generic.List<Beyond.UI.DamageTextBase> m_showingTextInstances;  // 0x150
        private readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,System.Collections.Generic.Queue<Beyond.UI.DamageTextBase>> m_textPool;  // 0x158
        private readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextBase,UnityEngine.Vector3> m_showingTextPos;  // 0x160
        private readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.String,Beyond.UI.DamageTextCtrl.CoalitionDetail>>> m_entityCoalitionGroupMap;  // 0x168
        private readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.Int32,System.Single>> m_entityTextTimeMap;  // 0x170
        private readonly System.Collections.Generic.Dictionary<System.UInt64,Beyond.UI.DamageTextLevelUp> m_charLevelUpTextMap;  // 0x178
        private readonly System.Collections.Generic.List<Beyond.EventData<System.UInt64,System.Int32>> m_charLevelUpTextToShow;  // 0x180
        private readonly System.Collections.Generic.List<Beyond.UI.DamageTextBase> m_toRecycleInTick;  // 0x188

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        UnityEngine.Vector3 outOfScreenPos { get; /* RVA: 0x09B180B8 */ }

        // Methods
        // RVA: 0x09B149E0  token: 0x600003A
        public System.Void OnCreate() { }
        // RVA: 0x09B1459C  token: 0x600003B
        public System.Void OnClose() { }
        // RVA: 0x09B13E10  token: 0x600003C
        public System.Void DebugChangeImpl(System.Boolean disableThis) { }
        // RVA: 0x09B15728  token: 0x600003D
        public System.Void OnShow() { }
        // RVA: 0x09B156DC  token: 0x600003E
        public System.Void OnHide() { }
        // RVA: 0x03CAC410  token: 0x600003F
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B1627C  token: 0x6000040
        private System.Void _OnHpChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& eventData) { }
        // RVA: 0x09B177F8  token: 0x6000041
        private System.Void _OnIgniteBuffText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String,Beyond.GEnums.EnergyShardType>& eventData) { }
        // RVA: 0x09B17CBC  token: 0x6000042
        private System.Void _OnPhysicalInflictionApplied(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,Beyond.Gameplay.Core.AbilitySystemForEnemyPart,Beyond.Gameplay.PhysicalInflictionType>& eventData) { }
        // RVA: 0x09B17A9C  token: 0x6000043
        private System.Void _OnImmuneText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String>& eventData) { }
        // RVA: 0x09B17E04  token: 0x6000044
        private System.Void _OnSquadInFightChanged(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x09B16148  token: 0x6000045
        private System.Void _OnCreateFlowText(Beyond.EventData<UnityEngine.Vector3,System.String,UnityEngine.Color>& eventData) { }
        // RVA: 0x09B15EC4  token: 0x6000046
        private System.Void _OnCharLevelUp(Beyond.EventData<System.UInt64,System.Int32>& eventData) { }
        // RVA: 0x09B15B10  token: 0x6000047
        private UnityEngine.Vector2 _GetRandomTextOffset(System.Single width, System.Single height) { }
        // RVA: 0x09B15CCC  token: 0x6000048
        private System.Boolean _IsTextPosValid(UnityEngine.Vector3 newPos) { }
        // RVA: 0x09B1595C  token: 0x6000049
        private Beyond.UI.DamageTextBase _CreateTextInstance(Beyond.UI.DamageTextType textType) { }
        // RVA: 0x09B15BD8  token: 0x600004A
        private Beyond.UI.DamageTextBase _InstantiateTextInstance(Beyond.UI.DamageTextType textType) { }
        // RVA: 0x09B17EB4  token: 0x600004B
        private System.Void _RecycleTextInstance(Beyond.UI.DamageTextBase textInstance) { }
        // RVA: 0x036D44B0  token: 0x600004C
        public System.Void .ctor() { }
        // RVA: 0x039BB420  token: 0x600004D
        private static System.Void .cctor() { }
        // RVA: 0x0577D7BC  token: 0x600004E
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000016  // size: 0x1A8
    public class DamageTextCtrlV2 : Beyond.UI.UIPanelBase
    {
        // Fields
        public Beyond.UI.GPUI.GPUISystem gpuiSystem;  // 0x70
        public System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig> damageTextConfigs;  // 0x78
        public System.Collections.Generic.List<Beyond.UI.DamageTextCtrlV2.IgnitePrefabOverride> ignitePrefabConfig;  // 0x80
        public System.Boolean useWorldRandomArea;  // 0x88
        public UnityEngine.Vector2 textRandomAreaSize;  // 0x8c
        public UnityEngine.Vector2 textRandomAreaSizeWorld;  // 0x94
        public UnityEngine.Vector2 textMinDist;  // 0x9c
        public System.Int32 textPosMaxRandomTimes;  // 0xa4
        public UnityEngine.Color damageTextColorPhysical;  // 0xa8
        public UnityEngine.Color damageTextColorReal;  // 0xb8
        public UnityEngine.Color damageTextColorFire;  // 0xc8
        public UnityEngine.Color damageTextColorPulse;  // 0xd8
        public UnityEngine.Color damageTextColorCryst;  // 0xe8
        public UnityEngine.Color damageTextColorNatural;  // 0xf8
        public UnityEngine.Color damageTextColorEther;  // 0x108
        public UnityEngine.Vector2 mainChrDmgTxtSpawnOffset;  // 0x118
        public UnityEngine.Vector2 mainChrDmgTxtMoveSpawnOffset;  // 0x120
        public System.Int32 mainChrDmgTxtMoveNum;  // 0x128
        public System.Single mainChrDmgTxtMoveSpawnWaitTime;  // 0x12c
        public System.Single dmgTxtCoalitionMaxTime;  // 0x130
        public UnityEngine.Vector2 guardDmgTxtSpawnOffset;  // 0x134
        public UnityEngine.Vector2 guardDmgTxtSpawnAreaSize;  // 0x13c
        public System.Boolean enableGuardDmgTxtOverwrite;  // 0x144
        public UnityEngine.Vector2 physicalInflictionTextOffset;  // 0x148
        public UnityEngine.Vector2 spellInflictionTextOffset;  // 0x150
        private static System.String GUARD_OVERWRITE_COALITION_KEY;  // const
        private static System.String CRYST_BREAK_TEXT_ID;  // const
        private System.Boolean m_isShow;  // 0x158
        private readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig> m_textConfigMap;  // 0x160
        private readonly System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2> m_showingTextInstances;  // 0x168
        private readonly System.Collections.Generic.Queue<Beyond.UI.DamageTextBaseV2> m_textPool;  // 0x170
        private readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextBaseV2,UnityEngine.Vector3> m_showingTextPos;  // 0x178
        private readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.String,Beyond.UI.DamageTextCtrlV2.CoalitionDetail>>> m_entityCoalitionGroupMap;  // 0x180
        private readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.Int32,System.Single>> m_entityTextTimeMap;  // 0x188
        private readonly System.Collections.Generic.Dictionary<System.UInt64,Beyond.UI.DamageTextBaseV2> m_charLevelUpTextMap;  // 0x190
        private readonly System.Collections.Generic.List<Beyond.EventData<System.UInt64,System.Int32>> m_charLevelUpTextToShow;  // 0x198
        private readonly System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2> m_toRecycleInTick;  // 0x1a0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        UnityEngine.Vector3 outOfScreenPos { get; /* RVA: 0x09B13DB8 */ }

        // Methods
        // RVA: 0x034D96C0  token: 0x6000051
        public System.Void OnCreate() { }
        // RVA: 0x09B10F78  token: 0x6000052
        public System.Void OnClose() { }
        // RVA: 0x09B10860  token: 0x6000053
        public System.Void DebugChangeImpl(System.Boolean disableThis) { }
        // RVA: 0x03A27B40  token: 0x6000054
        public System.Void OnShow() { }
        // RVA: 0x03D01280  token: 0x6000055
        public System.Void OnHide() { }
        // RVA: 0x03C917F0  token: 0x6000056
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B11E78  token: 0x6000057
        private System.Void _OnHpChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& eventData) { }
        // RVA: 0x09B134B8  token: 0x6000058
        private System.Void _OnIgniteBuffText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String,Beyond.GEnums.EnergyShardType>& eventData) { }
        // RVA: 0x09B13A70  token: 0x6000059
        private System.Void _OnPhysicalInflictionApplied(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,Beyond.Gameplay.Core.AbilitySystemForEnemyPart,Beyond.Gameplay.PhysicalInflictionType>& eventData) { }
        // RVA: 0x09B13878  token: 0x600005A
        private System.Void _OnImmuneText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String>& eventData) { }
        // RVA: 0x09B13BBC  token: 0x600005B
        private System.Void _OnSquadInFightChanged(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x09B11D48  token: 0x600005C
        private System.Void _OnCreateFlowText(Beyond.EventData<UnityEngine.Vector3,System.String,UnityEngine.Color>& eventData) { }
        // RVA: 0x09B11B00  token: 0x600005D
        private System.Void _OnCharLevelUp(Beyond.EventData<System.UInt64,System.Int32>& eventData) { }
        // RVA: 0x09B115D0  token: 0x600005E
        private UnityEngine.Vector2 _GetRandomTextOffset(System.Single width, System.Single height, System.Boolean useWorldOffset, UnityEngine.Vector3 textWorldPos) { }
        // RVA: 0x09B11908  token: 0x600005F
        private System.Boolean _IsTextPosValid(UnityEngine.Vector3 newPos) { }
        // RVA: 0x09B113BC  token: 0x6000060
        private Beyond.UI.DamageTextBaseV2 _CreateTextInstance(Beyond.UI.DamageTextType textType, System.String overrideName) { }
        // RVA: 0x09B13C6C  token: 0x6000061
        private System.Void _RecycleTextInstance(Beyond.UI.DamageTextBaseV2 textInstance) { }
        // RVA: 0x036D47B0  token: 0x6000062
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x6000063
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000019  // size: 0xC0
    public class DamageTextBase : Beyond.TickableUIMono
    {
        // Fields
        public Beyond.UI.DamageTextType type;  // 0x68
        public System.Single showDuration;  // 0x6c
        public System.Collections.Generic.List<Beyond.UI.DamageTextBase.SpawnPointConfig> spawnPointConfigs;  // 0x70
        public Beyond.UI.UIText text;  // 0x78
        public UnityEngine.Animation anim;  // 0x80
        private System.Boolean m_isActive;  // 0x88
        private System.Boolean m_isFollowingTransform;  // 0x89
        private UnityEngine.Transform m_followedTransform;  // 0x90
        private UnityEngine.Vector3 m_followedPosition;  // 0x98
        private UnityEngine.Vector2 m_uiOffset;  // 0xa4
        public Beyond.Gameplay.PeriodicTimer durationTimer;  // 0xb0
        protected Beyond.UnSafeString.UnSafeStringHandle m_textHandle;  // 0xb8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D567A0 */ }
        System.Boolean isFollowingTransform { get; /* RVA: 0x03D51D10 */ }
        UnityEngine.Vector3 worldPosition { get; /* RVA: 0x09B10418 */ }
        UnityEngine.Vector2 uiOffset { get; /* RVA: 0x03D76290 */ }

        // Methods
        // RVA: 0x02BDCCC0  token: 0x6000069
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B0F674  token: 0x600006A
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B10118  token: 0x600006B
        public virtual System.Void TailLateTick(System.Single deltaTime) { }
        // RVA: 0x09B0F860  token: 0x600006C
        public System.Void SetFollowTarget(Beyond.Gameplay.Core.AbilitySystem target, Beyond.Gameplay.Core.AbilitySystem textTargetWhenTransferred, System.Nullable<UnityEngine.Vector3> hitPoint) { }
        // RVA: 0x09B100B8  token: 0x600006D
        public System.Void SetUIOffset(UnityEngine.Vector2 offset) { }
        // RVA: 0x09B0F614  token: 0x600006E
        public System.Void Clear() { }
        // RVA: 0x09B0F7E0  token: 0x600006F
        public virtual System.Void SetColor(UnityEngine.Color color) { }
        // RVA: 0x09B0F730  token: 0x6000070
        public virtual System.Void PlayAnimation() { }
        // RVA: 0x09B10194  token: 0x6000071
        private System.Void _UpdatePosition() { }
        // RVA: 0x09B0FF10  token: 0x6000072
        public System.Void SetText(System.String newText) { }
        // RVA: 0x09B0FFE4  token: 0x6000073
        public System.Void SetText(System.Int32 newValue) { }
        // RVA: 0x09B0FE1C  token: 0x6000074
        public System.Void SetText(System.String prefix, System.Int32 newValue) { }
        // RVA: 0x02846CE0  token: 0x6000075
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x6000076
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7B4  token: 0x6000077
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x05826E68  token: 0x6000078
        public System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x200001B  // size: 0x60
    public class DamageTextBaseV2
    {
        // Fields
        private static readonly UnityEngine.Vector2 INVALID_POS;  // static @ 0x0
        private System.Boolean m_isFollowingTransform;  // 0x10
        private UnityEngine.Transform m_followedTransform;  // 0x18
        private UnityEngine.Vector3 m_followedPosition;  // 0x20
        private UnityEngine.Vector2 m_uiOffset;  // 0x2c
        private Beyond.UI.GPUI.GPUIHandle m_uiHandle;  // 0x34
        private Beyond.UI.GPUI.GPUISystem m_uiSystem;  // 0x40
        private Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig m_config;  // 0x48
        private System.UInt64 <targetCharInst>k__BackingField;  // 0x50
        protected Beyond.UnSafeString.UnSafeStringHandle m_textHandle;  // 0x58

        // Properties
        System.UInt64 targetCharInst { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x03D4F060 */ }
        System.Single textNodeAlpha { get; /* RVA: 0x09B0F524 */ }
        System.Single showDuration { get; /* RVA: 0x09B0F504 */ }
        System.Boolean isFollowingTransform { get; /* RVA: 0x011797F0 */ }
        System.Boolean isActive { get; /* RVA: 0x09B0F4DC */ }
        UnityEngine.Vector3 worldPosition { get; /* RVA: 0x09B0F544 */ }
        UnityEngine.Vector2 uiOffset { get; /* RVA: 0x03D76270 */ }

        // Methods
        // RVA: 0x09B0F4A8  token: 0x6000082
        public System.Void .ctor(Beyond.UI.GPUI.GPUISystem uiSystem) { }
        // RVA: 0x09B0E358  token: 0x6000083
        public System.Void OnRelease() { }
        // RVA: 0x09B0E144  token: 0x6000084
        public System.Void Assign(Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig config, System.String overrideName) { }
        // RVA: 0x09B0F218  token: 0x6000085
        public System.Void Tick(UnityEngine.Vector2 screenCenter, System.Single scaleFactor) { }
        // RVA: 0x09B0E5F8  token: 0x6000086
        public System.Void SetFollowTarget(Beyond.Gameplay.Core.AbilitySystem target, Beyond.Gameplay.Core.AbilitySystem textTargetWhenTransferred, System.Nullable<UnityEngine.Vector3> hitPoint) { }
        // RVA: 0x09B0F1BC  token: 0x6000087
        public System.Void SetUIOffset(UnityEngine.Vector2 offset) { }
        // RVA: 0x09B0E2A0  token: 0x6000088
        public System.Void Clear() { }
        // RVA: 0x09B0E2FC  token: 0x6000089
        public System.Void DestroyDisplay() { }
        // RVA: 0x09B0E44C  token: 0x600008A
        public virtual System.Void SetColor(UnityEngine.Color color) { }
        // RVA: 0x09B0E3BC  token: 0x600008B
        public virtual System.Void PlayAnimation(System.Boolean isLeft) { }
        // RVA: 0x09B0F294  token: 0x600008C
        private System.Void _UpdatePosition(UnityEngine.Vector2 screenCenter, System.Single scaleFactor) { }
        // RVA: 0x09B0EFB4  token: 0x600008D
        public System.Void SetText(System.String newText) { }
        // RVA: 0x09B0EDAC  token: 0x600008E
        public System.Void SetText(System.Int32 newValue) { }
        // RVA: 0x09B0EB7C  token: 0x600008F
        public System.Void SetText(System.String prefix, System.Int32 newValue) { }
        // RVA: 0x09B0F468  token: 0x6000090
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001F  // size: 0xC8
    public class DamageTextBlock : Beyond.UI.DamageTextDamageBase
    {
        // Fields
        public Beyond.UI.UIImage blockIcon;  // 0xc0

        // Methods
        // RVA: 0x09B104F8  token: 0x6000093
        public virtual System.Void SetColor(UnityEngine.Color color) { }
        // RVA: 0x03CB5C70  token: 0x6000094
        public System.Void .ctor() { }
        // RVA: 0x09B1059C  token: 0x6000095
        public System.Void <>iFixBaseProxy_SetColor(UnityEngine.Color P0) { }

    }

    // TypeToken: 0x2000020  // size: 0xC8
    public class DamageTextCriticalLevel0 : Beyond.UI.DamageTextDamageBase
    {
        // Fields
        public Beyond.UI.UIText criticalIcon;  // 0xc0

        // Methods
        // RVA: 0x09B105BC  token: 0x6000096
        public virtual System.Void SetColor(UnityEngine.Color color) { }
        // RVA: 0x03CB5C70  token: 0x6000097
        public System.Void .ctor() { }
        // RVA: 0x09B1059C  token: 0x6000098
        public System.Void <>iFixBaseProxy_SetColor(UnityEngine.Color P0) { }

    }

    // TypeToken: 0x2000021  // size: 0xE0
    public class DamageTextCriticalLevel1 : Beyond.UI.DamageTextDamageBase
    {
        // Fields
        public Beyond.UI.UIText criticalIcon;  // 0xc0
        public Beyond.UI.UIText criticalIconShadow;  // 0xc8
        public Beyond.UI.UIImage bg01;  // 0xd0
        public Beyond.UI.UIImage bg02;  // 0xd8
        private static System.String ANIM_NAME_CRITICAL_LEFT;  // const
        private static System.String ANIM_NAME_CRITICAL_RIGHT;  // const

        // Methods
        // RVA: 0x09B10748  token: 0x6000099
        public virtual System.Void SetColor(UnityEngine.Color color) { }
        // RVA: 0x09B10658  token: 0x600009A
        public virtual System.Void PlayAnimation(System.Boolean isLeft) { }
        // RVA: 0x03CB5C70  token: 0x600009B
        public System.Void .ctor() { }
        // RVA: 0x09B1059C  token: 0x600009C
        public System.Void <>iFixBaseProxy_SetColor(UnityEngine.Color P0) { }
        // RVA: 0x09B10858  token: 0x600009D
        public System.Void <>iFixBaseProxy_PlayAnimation(System.Boolean P0) { }

    }

    // TypeToken: 0x2000022  // size: 0xC0
    public class DamageTextDamageBase : Beyond.UI.DamageTextBase
    {
        // Methods
        // RVA: 0x09B18110  token: 0x600009E
        public virtual System.Void PlayAnimation(System.Boolean isLeft) { }
        // RVA: 0x03CB5C70  token: 0x600009F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0xD8
    public class DamageTextIgniteBuff : Beyond.UI.DamageTextBase
    {
        // Fields
        public Beyond.UI.UIImage bg;  // 0xc0
        public Beyond.UI.UIText textDuplication;  // 0xc8
        public Beyond.UI.UIState.UIStateController stateController;  // 0xd0

        // Methods
        // RVA: 0x02BDCBE0  token: 0x60000A0
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B181C4  token: 0x60000A1
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B18378  token: 0x60000A2
        public System.Void SetUIState(Beyond.GEnums.EnergyShardType energyShardType, System.Boolean isCrystBreak) { }
        // RVA: 0x09B18278  token: 0x60000A3
        public System.Void SetTextAndDuplication(System.String newText) { }
        // RVA: 0x03CB5C70  token: 0x60000A4
        public System.Void .ctor() { }
        // RVA: 0x09B184BC  token: 0x60000A5
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x09B184C4  token: 0x60000A6
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000024  // size: 0xC8
    public class DamageTextLevelUp : Beyond.UI.DamageTextBase
    {
        // Fields
        private System.UInt64 <targetCharInst>k__BackingField;  // 0xc0

        // Properties
        System.UInt64 targetCharInst { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x03D50F30 */ }

        // Methods
        // RVA: 0x03CB5C70  token: 0x60000A9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0xC0
    public class DamageTextNormalLevel1 : Beyond.UI.DamageTextDamageBase
    {
        // Fields
        private static System.String ANIM_NAME_NORMAL_LEFT;  // const
        private static System.String ANIM_NAME_NORMAL_RIGHT;  // const

        // Methods
        // RVA: 0x09B184CC  token: 0x60000AA
        public virtual System.Void PlayAnimation(System.Boolean isLeft) { }
        // RVA: 0x03CB5C70  token: 0x60000AB
        public System.Void .ctor() { }
        // RVA: 0x09B10858  token: 0x60000AC
        public System.Void <>iFixBaseProxy_PlayAnimation(System.Boolean P0) { }

    }

    // TypeToken: 0x2000026  // size: 0x50
    public class FootBarDashCell : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean isHalfCell;  // 0x18
        public Beyond.UI.UIImage bgImage;  // 0x20
        public UnityEngine.RectTransform cellTrans;  // 0x28
        public Beyond.UI.UIImage grayImage;  // 0x30
        public Beyond.UI.UIImage whiteImage;  // 0x38
        public Beyond.UI.UIAnimationWrapper animWrapper;  // 0x40
        private System.Int32 m_index;  // 0x48
        private static System.Int32 MAX_DASH_COUNT_IN_RING;  // const
        private static System.Single FILL_AMOUNT_PER_CELL;  // const
        private static System.Single ANGLE_PER_CELL;  // const
        private static System.Single ANGLE_PER_HALF_CELL;  // const
        private static System.Single ANGLE_PER_QUARTER_CELL;  // const

        // Methods
        // RVA: 0x09B1870C  token: 0x60000AD
        public System.Void SetIndex(System.Int32 index) { }
        // RVA: 0x09B185BC  token: 0x60000AE
        public System.Void SetDashCount(System.Single dashFillCount) { }
        // RVA: 0x09B187CC  token: 0x60000AF
        public System.Void StartPlayNotEnoughAnim() { }
        // RVA: 0x09B18878  token: 0x60000B0
        public System.Void StopPlayNotEnoughAnim() { }
        // RVA: 0x0426FE60  token: 0x60000B1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x148
    public class HeadBarCtrl : Beyond.UI.UIPanelBase
    {
        // Fields
        private UnityEngine.GameObject _mobHeadBarPrefab;  // 0x70
        private UnityEngine.GameObject _eliteHeadBarPrefab;  // 0x78
        private UnityEngine.GameObject _enemyPartHeadBarPrefab;  // 0x80
        private UnityEngine.GameObject _levelInfoBarPrefab;  // 0x88
        private UnityEngine.GameObject _vigilanceBarPrefab;  // 0x90
        private UnityEngine.GameObject _tacticalItemBarPrefab;  // 0x98
        private System.Single _hideHeadBarNotInFightDelay;  // 0xa0
        private System.Int32 _headBarInvisibleEnemyCount;  // 0xa4
        private System.Single _headBarInvisibleHpNoChangeTime;  // 0xa8
        private System.Single _headBarInvisibleScreenEdgeRatio;  // 0xac
        private System.Single _headBarInvisibleDistance;  // 0xb0
        private static System.Single TICK_SURROUNDING_INTERVAL;  // const
        private static System.String HEAD_BAR_BROKEN_ANIM;  // const
        private static readonly System.Int32[] HEAD_BAR_PREWARM_CNT;  // static @ 0x0
        private UnityEngine.Transform m_worldObjectRoot;  // 0xb8
        private static System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>> s_abilitySystemsToShowBar;  // static @ 0x8
        private static System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>> s_abilitySystemsToHideBar;  // static @ 0x10
        private static System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>> s_surroundingEnemies;  // static @ 0x18
        private System.Single m_lastTickSurrounding;  // 0xc0
        private System.Boolean m_inDialog;  // 0xc4
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UIHeadBarFollower> m_headBarDict;  // 0xc8
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UIHeadBarFollower> m_headBarWithOutAnimDict;  // 0xd0
        private System.Collections.Generic.List<Beyond.UI.UIHeadBarFollower> m_mobHeadBarPool;  // 0xd8
        private System.Collections.Generic.List<Beyond.UI.UIHeadBarFollower> m_eliteHeadBarPool;  // 0xe0
        private System.Collections.Generic.List<Beyond.UI.UIHeadBarFollower> m_enemyPartHeadBarPool;  // 0xe8
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.Gameplay.Core.AbilitySystem.Modifier> m_nonFullHpAbilitySystems;  // 0xf0
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,System.ValueTuple<Beyond.Gameplay.Core.AbilitySystem.Modifier,Beyond.Gameplay.PeriodicTimer>> m_enemyFirstDamageDict;  // 0xf8
        private System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>> m_enabledEnemyPartsByAction;  // 0x100
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UILvInfoBar> m_levelInfoBarDict;  // 0x108
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UILvInfoBar> m_levelInfoBarWithOutAnimDict;  // 0x110
        private System.Collections.Generic.List<Beyond.UI.UILvInfoBar> m_levelInfoBarPool;  // 0x118
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UIVigilanceBar> m_vigilanceBarDict;  // 0x120
        private System.Collections.Generic.List<Beyond.UI.UIVigilanceBar> m_vigilanceBarPool;  // 0x128
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UITacticalItemBar> m_tacticalItemBarDict;  // 0x130
        private System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UITacticalItemBar> m_tacticalItemBarWithOutAnimDict;  // 0x138
        private System.Collections.Generic.List<Beyond.UI.UITacticalItemBar> m_tacticalItemBarPool;  // 0x140

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        System.Boolean forceHide { get; /* RVA: 0x02404DB0 */ }

        // Methods
        // RVA: 0x034D9110  token: 0x60000B4
        public System.Void OnCreate(UnityEngine.Transform worldObjectRoot) { }
        // RVA: 0x09B18924  token: 0x60000B5
        public System.Void OnClose() { }
        // RVA: 0x02404770  token: 0x60000B6
        public System.Void OnShow() { }
        // RVA: 0x03D07AC0  token: 0x60000B7
        public System.Void OnHide() { }
        // RVA: 0x02404E10  token: 0x60000B8
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09B19988  token: 0x60000B9
        private System.Void _OnAddHeadBar(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem>& eventData) { }
        // RVA: 0x02402820  token: 0x60000BA
        private System.Void _OnRemoveHeadBar(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& eventData) { }
        // RVA: 0x09B19BDC  token: 0x60000BB
        private System.Void _OnHeadBarShowConfigChanged() { }
        // RVA: 0x09B19C30  token: 0x60000BC
        private System.Void _OnHpChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& eventData) { }
        // RVA: 0x09B19AD0  token: 0x60000BD
        private System.Void _OnEnemyPartEnableChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystemForEnemyPart,System.Boolean>& eventData) { }
        // RVA: 0x02402860  token: 0x60000BE
        private System.Void _RefreshHeadBar(Beyond.UI.HeadBarCtrl.HeadBarRefreshReason reason) { }
        // RVA: 0x034D8360  token: 0x60000BF
        private System.Void _PrewarmHeadBar() { }
        // RVA: 0x09B197A0  token: 0x60000C0
        private static Beyond.UI.HeadBarCtrl.HeadBarType _GetHeadBarType(Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr) { }
        // RVA: 0x02405080  token: 0x60000C1
        private System.Void _UpdateHeadBar(System.Single deltaTime) { }
        // RVA: 0x02406780  token: 0x60000C2
        private System.Void _UpdateLevelInfoBar(System.Single deltaTime) { }
        // RVA: 0x02407690  token: 0x60000C3
        private System.Void _UpdateVigilanceBar(System.Single deltaTime) { }
        // RVA: 0x02408640  token: 0x60000C4
        private System.Void _UpdateTacticalItemBar(System.Single deltaTime) { }
        // RVA: 0x02404E90  token: 0x60000C5
        private System.Void _UpdateSurroundingEnemies(System.Single deltaTime) { }
        // RVA: -1  // generic def  token: 0x60000C6
        private T _CreateBar(Beyond.UI.HeadBarCtrl.HeadBarType headBarType) { }
        // RVA: -1  // generic def  token: 0x60000C7
        private System.Void _RecycleBar(T bar) { }
        // RVA: -1  // generic def  token: 0x60000C8
        private System.Collections.Generic.List<T> _GetBarPool(Beyond.UI.HeadBarCtrl.HeadBarType headBarType) { }
        // RVA: -1  // generic def  token: 0x60000C9
        private UnityEngine.GameObject _GetBarPrefab(Beyond.UI.HeadBarCtrl.HeadBarType headBarType) { }
        // RVA: 0x09B1A338  token: 0x60000CA
        private System.Void _OnInteractNpc(Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& eventData) { }
        // RVA: 0x09B19A58  token: 0x60000CB
        private System.Void _OnDialogStart(Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& eventData) { }
        // RVA: 0x09B199E8  token: 0x60000CC
        private System.Void _OnDialogFinish(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x09B1A3A8  token: 0x60000CD
        private System.Void _SetInDialog(System.Boolean inDialog) { }
        // RVA: 0x032B6760  token: 0x60000CE
        public System.Void .ctor() { }
        // RVA: 0x032B6C70  token: 0x60000CF
        private static System.Void .cctor() { }
        // RVA: 0x09B19768  token: 0x60000D0
        private static System.Boolean <_RefreshHeadBar>g__ToShow|52_0(Beyond.Gameplay.Core.AbilitySystem abilitySystem) { }
        // RVA: 0x0589E548  token: 0x60000D1
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200002D  // size: 0x28
    public class HpChangeDisplayData
    {
        // Fields
        public System.Int32 priority;  // 0x10
        public System.Single minDamagePercent;  // 0x14
        public System.Single maxDamagePercent;  // 0x18
        public System.Single stayTime;  // 0x1c
        public System.Single decreaseSpeed;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60000D9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x138
    public class UIHeadBar : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean _showHpNumber;  // 0x18
        private System.Boolean _showHpChangeEffect;  // 0x19
        private System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData> _hpChangeConfig;  // 0x20
        private System.Boolean _hidePoiseBarWhenEmpty;  // 0x28
        private System.Boolean _showPoiseChangeEffect;  // 0x29
        private System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData> _poiseChangeConfig;  // 0x30
        private System.Boolean _highlightWhenWeakLock;  // 0x38
        private System.Single _weakLockHighlightScale;  // 0x3c
        private System.Single _weakLockScaleTransitionTime;  // 0x40
        private Beyond.UI.UIAnimationWrapper _barRootAnim;  // 0x48
        private UnityEngine.CanvasGroup _lvNode;  // 0x50
        private Beyond.UI.UIText _lvText;  // 0x58
        private UnityEngine.CanvasGroup _dangerousLvNode;  // 0x60
        private Beyond.UI.UIText _dangerousLvText;  // 0x68
        private UnityEngine.CanvasGroup _focusHighlight;  // 0x70
        private System.Collections.Generic.List<Beyond.UI.UIImage> _hpFastFillList;  // 0x78
        private System.Collections.Generic.List<Beyond.UI.UIImage> _hpSlowFillList;  // 0x80
        private UnityEngine.Transform _hpNumberNode;  // 0x88
        private Beyond.UI.UIText _curHpText;  // 0x90
        private Beyond.UI.UIText _maxHpText;  // 0x98
        private UnityEngine.RectTransform _hpParentRect;  // 0xa0
        private UnityEngine.RectTransform _hpEffectRect;  // 0xa8
        private UnityEngine.CanvasGroup _hpEffectCanvasGroup;  // 0xb0
        private Beyond.UI.UIPoiseBar _poiseBar;  // 0xb8
        private Beyond.UI.UIWeaknessNode _weaknessBar;  // 0xc0
        private Beyond.UI.UIBuffNode _attachedBuffNode;  // 0xc8
        private Beyond.UI.UIBuffNode _normalBuffNode;  // 0xd0
        private readonly Beyond.LuaResourceLoader m_loader;  // 0xd8
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> m_target;  // 0xe0
        private System.Boolean m_hasPoise;  // 0xf0
        private Beyond.UI.HpChangeDisplayData m_currentHpChangeData;  // 0xf8
        private Beyond.UI.UIHeadBar.HpDisplayState m_hpDisplayState;  // 0x100
        private readonly Beyond.Gameplay.PeriodicTimer m_hpStayTimer;  // 0x108
        private System.Nullable<System.Single> m_targetFillValue;  // 0x110
        private System.Nullable<System.Single> m_transferToHighlightScaleTime;  // 0x118
        private System.Nullable<System.Single> m_transferToOriginalScaleTime;  // 0x120
        private UnityEngine.Vector3 m_beforeTransferScale;  // 0x128
        public static System.Single EFFECT_OFFSET;  // const

        // Methods
        // RVA: 0x09B1E9A4  token: 0x60000DA
        private System.Void OnDestroy() { }
        // RVA: 0x034D8BE0  token: 0x60000DB
        public System.Void OnPreWarm() { }
        // RVA: 0x09B1EA00  token: 0x60000DC
        public System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x09B1F680  token: 0x60000DD
        public System.Void ShowModifierAfterSetTarget(Beyond.Gameplay.Core.AbilitySystem.Modifier& modifier) { }
        // RVA: 0x02B721C0  token: 0x60000DE
        public System.Void Clear() { }
        // RVA: 0x039B8090  token: 0x60000DF
        public System.Void Refresh() { }
        // RVA: 0x09B1FCEC  token: 0x60000E0
        private System.Void _OnHpChange(Beyond.Gameplay.Core.Entity entity, System.Double change) { }
        // RVA: 0x09B1FB24  token: 0x60000E1
        private System.Void _OnForceSetHp(Beyond.Gameplay.Core.Entity entity) { }
        // RVA: 0x09B1F86C  token: 0x60000E2
        private System.Void _CalculateHpChangeDisplay(Beyond.Gameplay.Core.AbilitySystem target, System.Double deltaValue) { }
        // RVA: 0x09B20614  token: 0x60000E3
        private System.Void _UpdateHpDisplay(System.Single deltaTime) { }
        // RVA: 0x09B2032C  token: 0x60000E4
        private System.Void _OnPoiseChange(Beyond.Gameplay.Core.Entity entity, System.Single change, System.Boolean hideUIEffect) { }
        // RVA: 0x09B201B8  token: 0x60000E5
        private System.Void _OnMultiTimeWeaknessActivate(Beyond.Gameplay.Core.Entity entity, System.Boolean active, System.Int32 count) { }
        // RVA: 0x09B203C8  token: 0x60000E6
        private System.Void _OnWeaknessCountChanged(Beyond.Gameplay.Core.Entity entity, System.Int32 total, System.Int32 count) { }
        // RVA: 0x09B20038  token: 0x60000E7
        private System.Void _OnMainTargetChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& eventData) { }
        // RVA: 0x09B20950  token: 0x60000E8
        private System.Void _UpdateScale(System.Single deltaTime) { }
        // RVA: 0x09B20494  token: 0x60000E9
        private System.Void _SetImageFill(System.Collections.Generic.List<Beyond.UI.UIImage> imageList, System.Single fillValue) { }
        // RVA: 0x09B1F7A4  token: 0x60000EA
        public System.Void UpdateData(System.Single deltaTime) { }
        // RVA: 0x0369DF50  token: 0x60000EB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x150
    public class UIHeadBarFollower : Beyond.UI.UIAbilityTargetFollower
    {
        // Fields
        public Beyond.UI.HeadBarCtrl.HeadBarType headBarType;  // 0x110
        private System.Boolean _haveGuideLine;  // 0x114
        public Beyond.UI.UIAnimationWrapper anim;  // 0x118
        private Beyond.UI.UIHeadBar _headBar;  // 0x120
        private UnityEngine.GameObject _guideLineNode;  // 0x128
        private UnityEngine.RectTransform _guideLine;  // 0x130
        private UnityEngine.RectTransform _followTargetEndPoint;  // 0x138
        private UnityEngine.RectTransform _headBarEndPoint;  // 0x140
        private System.Boolean m_headBarVisible;  // 0x148

        // Properties
        System.Boolean actualVisible { get; /* RVA: 0x09B1E990 */ }

        // Methods
        // RVA: 0x034D8B90  token: 0x60000ED
        public System.Void OnPreWarm() { }
        // RVA: 0x09B1E314  token: 0x60000EE
        public virtual System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x09B1E3DC  token: 0x60000EF
        public System.Void ShowModifierAfterSetTarget(Beyond.Gameplay.Core.AbilitySystem.Modifier& modifier) { }
        // RVA: 0x02B71CE0  token: 0x60000F0
        public virtual System.Void Clear() { }
        // RVA: 0x09B1E1E4  token: 0x60000F1
        public System.Void Refresh() { }
        // RVA: 0x09B1E274  token: 0x60000F2
        public System.Void SetHeadBarVisible(System.Boolean visible) { }
        // RVA: 0x09B1E48C  token: 0x60000F3
        protected virtual System.Void UpdateData(System.Single deltaTime) { }
        // RVA: 0x09B1E504  token: 0x60000F4
        private System.Void _UpdateGuideLine() { }
        // RVA: 0x09B1E0DC  token: 0x60000F5
        protected virtual UnityEngine.Vector3 GetOriginFollowPos() { }
        // RVA: 0x03B3AEE0  token: 0x60000F6
        public System.Void .ctor() { }
        // RVA: 0x09B1E47C  token: 0x60000F7
        public System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0) { }
        // RVA: 0x09B1E444  token: 0x60000F8
        public System.Void <>iFixBaseProxy_Clear() { }
        // RVA: 0x09B1E484  token: 0x60000F9
        public System.Void <>iFixBaseProxy_UpdateData(System.Single P0) { }
        // RVA: 0x09B1E44C  token: 0x60000FA
        public UnityEngine.Vector3 <>iFixBaseProxy_GetOriginFollowPos() { }

    }

    // TypeToken: 0x2000031  // size: 0xF0
    public class UIHeadLabel : Beyond.TickableUIMono
    {
        // Fields
        private UnityEngine.Transform _emojiNode;  // 0x68
        private Beyond.Gameplay.Core.FloatingUIFitter _rootDis;  // 0x70
        private Beyond.Gameplay.Core.ObjectType <targetType>k__BackingField;  // 0x78
        private System.UInt64 <entityLogicId>k__BackingField;  // 0x80
        private System.String m_headLabelIcon;  // 0x88
        private System.String m_headLabelIconOverwrite;  // 0x90
        private UnityEngine.Vector3 m_originalPosition;  // 0x98
        private System.Boolean m_hasBindEvent;  // 0xa4
        private System.Boolean m_hasBindTargetEvent;  // 0xa5
        private Beyond.SerializeFieldDictionary<Beyond.UI.UIHeadLabel.HeadLabelType,Beyond.UI.UIHeadLabel.HeadLabelRootData> _subRoots;  // 0xa8
        private System.Collections.Generic.Dictionary<Beyond.UI.UIHeadLabel.HeadLabelType,Beyond.UI.UIHeadLabel.HeadLabelRootVisibleData> m_subRootsVisible;  // 0xb0
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,Beyond.UI.UIHeadLabel.HeadLabelType> m_subRootsReverse;  // 0xb8
        private UnityEngine.Transform m_camera;  // 0xc0
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> m_target;  // 0xc8
        private UnityEngine.Transform m_followTarget;  // 0xd8
        private Beyond.NPC.Avatar.NPCAvatarMountPointInfo m_npcMountPointInfo;  // 0xe0
        private System.Boolean m_inited;  // 0xe8
        private System.Boolean m_visibleDirty;  // 0xe9

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        UnityEngine.Transform iconHolder { get; /* RVA: 0x09B20FD4 */ }
        Beyond.Gameplay.Core.ObjectType targetType { get; /* RVA: 0x03D4EC40 */ set; /* RVA: 0x03D4ECC0 */ }
        System.UInt64 entityLogicId { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x03D4EB60 */ }
        System.String headLabelIcon { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x02C73980 */ }
        System.String missionHeadLabelIcon { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x02C739B0 */ }

        // Methods
        // RVA: 0x09B20E4C  token: 0x6000101
        private System.Void _OnSubRootsCollectionChanged() { }
        // RVA: 0x032937A0  token: 0x6000106
        private System.Void _TryInitRootData() { }
        // RVA: 0x02C74770  token: 0x6000107
        public System.Void SetVisibleDirty() { }
        // RVA: 0x02C73EF0  token: 0x6000108
        private System.Void _UpdateVisible() { }
        // RVA: 0x02C73DA0  token: 0x6000109
        public System.Void SetSubRootVisible(Beyond.UI.UIHeadLabel.HeadLabelType type, Beyond.UI.UIHeadLabel.VisibleSource source, System.Boolean visible, System.Boolean updateNow) { }
        // RVA: 0x02C739E0  token: 0x600010A
        public System.Void SetTarget(Beyond.Gameplay.Core.Entity target) { }
        // RVA: 0x02C757F0  token: 0x600010B
        private System.Void _TryUpdateVisibleCallback() { }
        // RVA: 0x02C762D0  token: 0x600010C
        private System.Void _ClearVisibleCallback() { }
        // RVA: 0x02C76180  token: 0x600010D
        public System.Void Clear() { }
        // RVA: 0x0365EBB0  token: 0x600010E
        public System.Void SetActive(System.Boolean active) { }
        // RVA: 0x02BA2160  token: 0x600010F
        public System.Void ClearEmojis() { }
        // RVA: 0x029FD240  token: 0x6000110
        private System.Void _UpdateFloatingUIVisibleCallback() { }
        // RVA: 0x029FE8B0  token: 0x6000111
        private System.Void _ClearFloatingUIVisibleCallback() { }
        // RVA: 0x09B20D08  token: 0x6000112
        private System.Void _OnMissionTypeIconChanged(Beyond.EventData<System.String>& data) { }
        // RVA: 0x02C722C0  token: 0x6000113
        private System.Void _BindMissionTracking() { }
        // RVA: 0x02C76540  token: 0x6000114
        private System.Void _UnBindMissionTracking() { }
        // RVA: 0x02C72450  token: 0x6000115
        private System.Void _BindTargetEvent() { }
        // RVA: 0x02C763A0  token: 0x6000116
        private System.Void _UnBindTargetEvent() { }
        // RVA: 0x02F0C2E0  token: 0x6000117
        private System.Void _OnNpcVisibleChanged(Beyond.EventData<System.String>& eventData) { }
        // RVA: 0x0262C0C0  token: 0x6000118
        private System.Void _UpdatePos() { }
        // RVA: 0x02C73CE0  token: 0x6000119
        private System.Void _RefreshVisible(System.Boolean bubbleRoot, System.Boolean textNode, System.Boolean iconHolderNode) { }
        // RVA: 0x0262C6C0  token: 0x600011A
        private System.Void _TryUpdateVisible() { }
        // RVA: 0x03293650  token: 0x600011B
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0262C5E0  token: 0x600011C
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x035EA180  token: 0x600011D
        protected virtual System.Void OnEnable() { }
        // RVA: 0x02C764C0  token: 0x600011E
        protected virtual System.Void OnDisable() { }
        // RVA: 0x09B20CA4  token: 0x600011F
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02846E10  token: 0x6000120
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x6000121
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0589E548  token: 0x6000122
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058DD8AC  token: 0x6000123
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x058DD8A4  token: 0x6000124
        public System.Void <>iFixBaseProxy_OnDisable() { }
        // RVA: 0x0577D7B4  token: 0x6000125
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000037  // size: 0x138
    public class UILvInfoBar : Beyond.UI.UIAbilityTargetFollower
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper anim;  // 0x110
        private UnityEngine.Transform _lvNode;  // 0x118
        private Beyond.UI.UIText _lvText;  // 0x120
        private UnityEngine.Transform _dangerousLvNode;  // 0x128
        private Beyond.UI.UIText _dangerousLvText;  // 0x130

        // Methods
        // RVA: 0x09B2114C  token: 0x600012D
        public virtual System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x09B21044  token: 0x600012E
        protected virtual UnityEngine.Vector3 GetOriginFollowPos() { }
        // RVA: 0x03D4CD70  token: 0x600012F
        public System.Void .ctor() { }
        // RVA: 0x09B1E47C  token: 0x6000130
        public System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0) { }
        // RVA: 0x09B1E44C  token: 0x6000131
        public UnityEngine.Vector3 <>iFixBaseProxy_GetOriginFollowPos() { }

    }

    // TypeToken: 0x2000038  // size: 0xC8
    public class UIPoiseBar : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UISlider _increaseSlider;  // 0x18
        private UnityEngine.CanvasGroup _increaseCanvasGroup;  // 0x20
        private Beyond.UI.UISlider _decreaseSlider;  // 0x28
        private UnityEngine.CanvasGroup _decreaseCanvasGroup;  // 0x30
        private Beyond.UI.UIPoiseKnot _poiseKnot;  // 0x38
        private UnityEngine.Animation _poiseBreakAnim;  // 0x40
        private UnityEngine.CanvasGroup _poiseBreakCanvasGroup;  // 0x48
        private UnityEngine.RectTransform _poiseParentRect;  // 0x50
        private UnityEngine.RectTransform _poiseEffectRect;  // 0x58
        private UnityEngine.CanvasGroup _poiseEffectCanvasGroup;  // 0x60
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> m_owner;  // 0x68
        private System.Boolean m_isInPoiseRecovery;  // 0x78
        private System.Boolean m_hidePoiseBarWhenEmpty;  // 0x79
        private System.Boolean m_showPoiseChangeEffect;  // 0x7a
        private System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData> m_poiseChangeConfig;  // 0x80
        private Beyond.UI.HpChangeDisplayData m_currentPoiseChangeData;  // 0x88
        private Beyond.UI.UIPoiseBar.PoiseDisplayState m_poiseDisplayState;  // 0x90
        private readonly Beyond.Gameplay.PeriodicTimer m_poiseStayTimer;  // 0x98
        private System.Nullable<System.Single> m_targetFillValue;  // 0xa0
        private System.Single m_slowFillValue;  // 0xa8
        private System.Boolean m_enemyPartHide;  // 0xac
        private System.Collections.Generic.List<Beyond.UI.UIPoiseKnot> m_poiseKnotList;  // 0xb0
        private System.Collections.Generic.List<Beyond.UI.UIPoiseKnot> m_poiseKnotPool;  // 0xb8
        private System.Boolean m_isPoiseKnotInited;  // 0xc0
        public static System.Single EFFECT_OFFSET;  // const

        // Properties
        Beyond.Gameplay.Core.AbilitySystem owner { get; /* RVA: 0x09B22690 */ }
        System.Single maxPoise { get; /* RVA: 0x09B2266C */ }
        System.Single realPoise { get; /* RVA: 0x09B226CC */ }
        System.Boolean hidePoiseBar { get; /* RVA: 0x09B2259C */ }

        // Methods
        // RVA: 0x09B213F0  token: 0x6000136
        public System.Void Init(Beyond.Gameplay.Core.AbilitySystem owner, System.Boolean hidePoiseBarWhenEmpty, System.Boolean showPoiseChangeEffect, System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData> poiseChangeConfig) { }
        // RVA: 0x02B71FB0  token: 0x6000137
        public System.Void Clear() { }
        // RVA: 0x09B21674  token: 0x6000138
        public System.Void OnPoiseChange(Beyond.Gameplay.Core.Entity entity, System.Single change, System.Boolean hideUIEffect) { }
        // RVA: 0x039B8110  token: 0x6000139
        public System.Void Refresh() { }
        // RVA: 0x09B21B28  token: 0x600013A
        public System.Void UpdatePoiseBar(System.Single deltaTime) { }
        // RVA: 0x09B21C50  token: 0x600013B
        private System.Void _CalculatePoiseChangeDisplay(System.Double deltaValue) { }
        // RVA: 0x09B22360  token: 0x600013C
        private System.Void _UpdatePoiseDisplay(System.Single deltaTime) { }
        // RVA: 0x09B220C0  token: 0x600013D
        private System.Void _TryInitPoiseKnot(Beyond.Gameplay.Core.AbilitySystem owner) { }
        // RVA: 0x02B71E00  token: 0x600013E
        private System.Void _ClearPoiseKnot() { }
        // RVA: 0x09B21F08  token: 0x600013F
        private Beyond.UI.UIPoiseKnot _CreatePoiseKnot() { }
        // RVA: 0x0364CA90  token: 0x6000140
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003A  // size: 0x130
    public class UITacticalItemBar : Beyond.UI.UIAbilityTargetFollower
    {
        // Fields
        private System.Single _castFillMin;  // 0x110
        private System.Single _castFillMax;  // 0x114
        public Beyond.UI.UIAnimationWrapper anim;  // 0x118
        private Beyond.UI.UIImage _castFill;  // 0x120
        private Beyond.UI.UIImage _itemIcon;  // 0x128
        private static System.String UI_SPRITE_ITEM;  // const

        // Methods
        // RVA: 0x09B226F4  token: 0x6000141
        public virtual System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x09B228E4  token: 0x6000142
        protected virtual System.Void UpdateData(System.Single deltaTime) { }
        // RVA: 0x03D4D070  token: 0x6000143
        public System.Void .ctor() { }
        // RVA: 0x09B1E47C  token: 0x6000144
        public System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0) { }
        // RVA: 0x09B1E484  token: 0x6000145
        public System.Void <>iFixBaseProxy_UpdateData(System.Single P0) { }

    }

    // TypeToken: 0x200003B  // size: 0x138
    public class UIVigilanceBar : Beyond.UI.UIAbilityTargetFollower
    {
        // Fields
        private Beyond.UI.UIAnimationWrapper _vigilanceNode;  // 0x110
        private Beyond.UI.UIImage _vigilanceFill;  // 0x118
        private UnityEngine.CanvasGroup _vigilanceDim;  // 0x120
        private UnityEngine.CanvasGroup _vigilanceLight;  // 0x128
        private System.Boolean m_isVigilanceActive;  // 0x130
        private System.Boolean m_isVigilanceFull;  // 0x131

        // Methods
        // RVA: 0x09B22C78  token: 0x6000146
        public virtual System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x09B229B8  token: 0x6000147
        public virtual System.Void Clear() { }
        // RVA: 0x09B22B1C  token: 0x6000148
        public System.Void Refresh() { }
        // RVA: 0x09B22DEC  token: 0x6000149
        protected virtual System.Void UpdateData(System.Single deltaTime) { }
        // RVA: 0x09B22E4C  token: 0x600014A
        private System.Void _UpdateVigilanceNode() { }
        // RVA: 0x09B22A14  token: 0x600014B
        protected virtual UnityEngine.Vector3 GetOriginFollowPos() { }
        // RVA: 0x03D4CD70  token: 0x600014C
        public System.Void .ctor() { }
        // RVA: 0x03D762D0  token: 0x600014D
        private System.Void <_UpdateVigilanceNode>b__10_0() { }
        // RVA: 0x09B1E47C  token: 0x600014E
        public System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0) { }
        // RVA: 0x09B1E444  token: 0x600014F
        public System.Void <>iFixBaseProxy_Clear() { }
        // RVA: 0x09B1E484  token: 0x6000150
        public System.Void <>iFixBaseProxy_UpdateData(System.Single P0) { }
        // RVA: 0x09B1E44C  token: 0x6000151
        public UnityEngine.Vector3 <>iFixBaseProxy_GetOriginFollowPos() { }

    }

    // TypeToken: 0x200003C  // size: 0x28
    public class UIWeaknessNode : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.CanvasGroup weaknessCell;  // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.CanvasGroup> m_weaknessCells;  // 0x20

        // Methods
        // RVA: 0x09B230F4  token: 0x6000152
        private System.Void Awake() { }
        // RVA: 0x09B23260  token: 0x6000153
        public System.Void SetTotalCellNum(System.Int32 num) { }
        // RVA: 0x09B23194  token: 0x6000154
        public System.Void SetCurrentCellNum(System.Int32 num) { }
        // RVA: 0x02848C10  token: 0x6000155
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003D  // size: 0x50
    public class AtbCell : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIImage fill;  // 0x18
        public Beyond.UI.UIAnimationWrapper fillLoop;  // 0x20
        public UnityEngine.RectTransform blinkRect;  // 0x28
        public Beyond.UI.UIAnimationWrapper recover;  // 0x30
        public Beyond.UI.UIAnimationWrapper anim;  // 0x38
        public UnityEngine.UI.LayoutElement layoutElement;  // 0x40
        public System.Single recoverInitFillAmount;  // 0x48
        public System.Boolean atbRecovering;  // 0x4c

        // Methods
        // RVA: 0x0426FE60  token: 0x6000156
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0xC8
    public class AtbNode : Beyond.UI.UIPanelBase
    {
        // Fields
        public Beyond.UI.AtbCell atbCell;  // 0x70
        public UnityEngine.RectTransform atbGroup;  // 0x78
        public Beyond.UI.UIAnimationWrapper atbSkillHint;  // 0x80
        public UnityEngine.Color atbColorFull;  // 0x88
        public UnityEngine.Color atbColorNotFull;  // 0x98
        public System.Single atbFillSpeed;  // 0xa8
        public System.String atbHintFillOnEvent;  // 0xb0
        private readonly System.Collections.Generic.List<Beyond.UI.AtbCell> m_atbValueCellList;  // 0xb8
        private System.Boolean m_atbShowing;  // 0xc0
        private System.Single m_showingAtbValue;  // 0xc4
        private static System.Single ATB_PRESS_THRESHOLD;  // const

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        Beyond.Gameplay.Core.BattleManager battleManager { get; /* RVA: 0x09B1B870 */ }
        Beyond.Gameplay.SkillSetting skillSetting { get; /* RVA: 0x03197D40 */ }

        // Methods
        // RVA: 0x03197400  token: 0x600015A
        public System.Void OnCreate() { }
        // RVA: 0x09B1B200  token: 0x600015B
        public System.Void OnClose() { }
        // RVA: 0x03197B70  token: 0x600015C
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x0373E980  token: 0x600015D
        public System.Void CheckAtbLoopAnim() { }
        // RVA: 0x03197A70  token: 0x600015E
        private System.Void _RefreshAtbShowing() { }
        // RVA: 0x09B1B804  token: 0x600015F
        private System.Void _OnAtbCellOutAnimCallback() { }
        // RVA: 0x09B1B7A4  token: 0x6000160
        public System.Void OnInFightChanged(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x09B1B384  token: 0x6000161
        public System.Void OnGainAtb(Beyond.EventData<System.Single>& eventData) { }
        // RVA: 0x03C8AE30  token: 0x6000162
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x6000163
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000040  // size: 0x80
    public class ComboSkillHint : UnityEngine.MonoBehaviour
    {
        // Fields
        public static System.String SPECIAL_NODE_PATH;  // const
        public UnityEngine.CanvasGroup content;  // 0x18
        public Beyond.UI.UIButton button;  // 0x20
        public Beyond.UI.UIImage fill;  // 0x28
        public Beyond.UI.UIImage icon;  // 0x30
        public Beyond.UI.UIImage charHead;  // 0x38
        public UnityEngine.GameObject maskNode;  // 0x40
        public Beyond.UI.UIImage mask2Img;  // 0x48
        public Beyond.UI.UIAnimationWrapper anim;  // 0x50
        public Beyond.UI.ComboSpecialNodeBase specialNode;  // 0x58
        public System.Boolean needTick;  // 0x60
        public System.Int32 charIndex;  // 0x64
        private Beyond.UI.ComboSkillPanel m_owner;  // 0x68
        private Beyond.Gameplay.Core.SkillData m_cachedSkillData;  // 0x70
        private System.String m_lastSpecialNodeName;  // 0x78

        // Methods
        // RVA: 0x029766D0  token: 0x6000166
        public System.Void Init(Beyond.UI.ComboSkillPanel owner, System.Int32 charIndex, System.Boolean isDefaultPanel) { }
        // RVA: 0x09B1B914  token: 0x6000167
        public System.Void OnReady() { }
        // RVA: 0x09B1B8A8  token: 0x6000168
        public System.Void OnCast() { }
        // RVA: 0x09B1B9E8  token: 0x6000169
        public System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x09B1B97C  token: 0x600016A
        public System.Void OnRemove() { }
        // RVA: 0x09B1BA54  token: 0x600016B
        public System.Void Release() { }
        // RVA: 0x02976540  token: 0x600016C
        public System.Void AssignData(Beyond.Gameplay.Core.AbilitySystem abilityCom) { }
        // RVA: 0x09B1BAC0  token: 0x600016D
        public System.Void SetVisible(System.Boolean visible) { }
        // RVA: 0x03A2D3A0  token: 0x600016E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000041  // size: 0xA8
    public class ComboSkillPanel : Beyond.UI.UIPanelBase
    {
        // Fields
        public static System.String UI_SPRITE_ROUND_CHAR_HEAD;  // const
        public Beyond.UI.UIButton buttonCast;  // 0x70
        public UnityEngine.RectTransform infoNode;  // 0x78
        public Beyond.UI.ComboSkillHint[] comboSkillHints;  // 0x80
        public Beyond.UI.UICustomLayoutElement customLayoutElement;  // 0x88
        public Beyond.UI.UIState.UIStateController infoNodeStateController;  // 0x90
        public System.Single comboHintDisableAlpha;  // 0x98
        public System.Single comboHintFirstScale;  // 0x9c
        private readonly System.Collections.Generic.List<System.Int32> m_charIndexList;  // 0xa0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x02976070  token: 0x6000170
        public System.Void OnCreate(System.Boolean isDefaultPanel, System.Boolean isControllerPanel) { }
        // RVA: 0x02975F90  token: 0x6000171
        public System.Void OnShow() { }
        // RVA: 0x09B1BE70  token: 0x6000172
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B1C108  token: 0x6000173
        public virtual System.Void PreTick(System.Single deltaTime) { }
        // RVA: 0x02CD5920  token: 0x6000174
        private System.Void _CheckUpdate() { }
        // RVA: 0x02976410  token: 0x6000175
        private System.Void _OnBattleTeamChanged() { }
        // RVA: 0x09B1C3A8  token: 0x6000176
        private System.Void _OnComboSkillReady(Beyond.EventData<System.Int32>& eventData) { }
        // RVA: 0x09B1C544  token: 0x6000177
        private System.Void _OnComboSkillRemove(Beyond.EventData<System.Int32>& eventData) { }
        // RVA: 0x09B1C5A8  token: 0x6000178
        private System.Void _RemoveComboSkill(System.Int32 charIndex) { }
        // RVA: 0x02CD55F0  token: 0x6000179
        private System.Void _OnComboSkillClearAll() { }
        // RVA: 0x09B1BB1C  token: 0x600017A
        public System.Void CastComboSkill(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02975FD0  token: 0x600017B
        private System.Void _ResortSiblingIndex() { }
        // RVA: 0x03C7FB80  token: 0x600017C
        public System.Void .ctor() { }
        // RVA: 0x09B1C32C  token: 0x600017D
        private System.Void <OnCreate>b__11_0() { }
        // RVA: 0x09B1C3A0  token: 0x600017E
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x05C99784  token: 0x600017F
        public System.Void <>iFixBaseProxy_PreTick(System.Single P0) { }

    }

    // TypeToken: 0x2000045  // size: 0x38
    public class HpBarComboNode : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject comboCountLayout;  // 0x18
        public Beyond.UI.UIText comboCountText;  // 0x20
        private Beyond.UI.UIAnimationWrapper m_animationWrapper;  // 0x28
        private System.Int32 m_lastCount;  // 0x30
        private static System.String COMMON_COMBO_GLOBAL_BUFF_ID;  // const

        // Methods
        // RVA: 0x034D8C40  token: 0x6000186
        private System.Void Awake() { }
        // RVA: 0x09B1C758  token: 0x6000187
        private System.Void OnDestroy() { }
        // RVA: 0x03B3E650  token: 0x6000188
        private System.Void _OnGlobalBuffStart(Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String>& eventData) { }
        // RVA: 0x09B1C998  token: 0x6000189
        private System.Void _OnGlobalBuffFinish(Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String,Beyond.Gameplay.Core.GlobalBuff.FinishReason>& eventData) { }
        // RVA: 0x033F22B0  token: 0x600018A
        private System.Void _RefreshComboCount(System.Boolean isEarly) { }
        // RVA: 0x09B1C8DC  token: 0x600018B
        private System.Void _AnimInCallback() { }
        // RVA: 0x09B1C934  token: 0x600018C
        private System.Void _AnimOutCallback() { }
        // RVA: 0x0426FE60  token: 0x600018D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x208
    public class MainCharHpBar : Beyond.TickableUIMono
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper hpBar;  // 0x68
        public Beyond.UI.UIText hpText;  // 0x70
        public Beyond.UI.UIImage hpWhiteFill;  // 0x78
        public UnityEngine.GameObject blinkAnimObject;  // 0x80
        public System.Single hpBlinkPercent;  // 0x88
        public System.Single hpChangeColorPercent;  // 0x8c
        public Beyond.UI.UIImage hpFillHigh;  // 0x90
        public Beyond.UI.UIImage hpFillLow;  // 0x98
        public UnityEngine.RectTransform hpVfxNode;  // 0xa0
        public Beyond.UI.UIImage[] hpVfxImages;  // 0xa8
        public Beyond.SerializeFieldDictionary<Beyond.GEnums.SpellInflictionOnCharType,UnityEngine.Color> hpVfXColors;  // 0xb0
        public System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData> hpChangeConfigList;  // 0xb8
        public System.Collections.Generic.List<Beyond.UI.MainCharHpBar.HpScreenEffectConfig> hpScreenEffectConfigList;  // 0xc0
        public System.Single hpScreenEffectCd;  // 0xc8
        public Beyond.UI.UIBuffNode buffNode;  // 0xd0
        public Beyond.UI.UIImage buffIcon;  // 0xd8
        public UnityEngine.Transform leftLayout;  // 0xe0
        public UnityEngine.Transform charPassiveNode;  // 0xe8
        public UnityEngine.GameObject ultimateProgress;  // 0xf0
        public Beyond.UI.UIImage ultimateProgressFill;  // 0xf8
        public System.Single ultimateProgressFillSmoothTime;  // 0x100
        public UnityEngine.Color colorDefault;  // 0x104
        public UnityEngine.Color colorRed;  // 0x114
        public UnityEngine.Color colorYellow;  // 0x124
        public UnityEngine.Color colorBlue;  // 0x134
        public UnityEngine.Color colorGreen;  // 0x144
        private static System.String HP_BLINK_ANIM;  // const
        private System.Boolean m_nodeShowing;  // 0x154
        private Beyond.Gameplay.Core.Entity m_mainChar;  // 0x158
        private Beyond.UI.HpChangeDisplayData m_hpChangeConfig;  // 0x160
        private Beyond.UI.UIHeadBar.HpDisplayState m_hpDisplayState;  // 0x168
        private System.Nullable<System.Single> m_targetHpValue;  // 0x16c
        private readonly Beyond.Gameplay.PeriodicTimer m_hpStayTimer;  // 0x178
        private System.Boolean m_hpBarShowing;  // 0x180
        private System.Boolean m_hpBarShaking;  // 0x181
        private Beyond.UI.UIAnimationWrapper m_hpVfxAnimWrapper;  // 0x188
        private Beyond.UI.UIHudFadeController m_hudFadeController;  // 0x190
        private static readonly System.Collections.Generic.HashSet<System.String> s_tempCurPassiveUIPrefabNames;  // static @ 0x0
        private static readonly System.Collections.Generic.List<System.String> s_tempUnusedPassiveUIPrefabNames;  // static @ 0x8
        private readonly System.Collections.Generic.Dictionary<System.String,Beyond.UI.UICharPassiveBase> m_allPassiveBases;  // 0x198
        private Beyond.UI.UICharPassiveBase m_curPassiveBase;  // 0x1a0
        private Beyond.UI.UIAnimationWrapper m_buffIconAnimWrapper;  // 0x1a8
        private Beyond.UI.UIAnimationWrapper m_shakeAnimWrapper;  // 0x1b0
        private Beyond.UI.UIAnimationWrapper m_hpWhiteAnimWrapper;  // 0x1b8
        private Beyond.UI.UIAnimationWrapper m_ultimateBuffProgressAnimWrapper;  // 0x1c0
        private Beyond.UnSafeString.UnSafeStringHandle m_hpTextHandle;  // 0x1c8
        private readonly Beyond.LuaResourceLoader m_loader;  // 0x1d0
        private System.Single m_lastHpScreenEffectTime;  // 0x1d8
        private System.Boolean m_ultimateProgressShowing;  // 0x1dc
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> m_ultimateBuffPtr;  // 0x1e0
        private System.Single m_ultimateBuffProgressShowingFillAmount;  // 0x1f0
        private System.Single m_ultimateBuffProgressSmoothVelocity;  // 0x1f4
        private readonly System.Collections.Generic.List<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>> m_ultimateBuffProgressRegisteredCharacters;  // 0x1f8
        private readonly System.Collections.Generic.List<Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff>> m_activeUltimateBuffs;  // 0x200

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x02BDD880  token: 0x600018F
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0309A0A0  token: 0x6000190
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09B1CA34  token: 0x6000191
        protected virtual System.Void OnRelease() { }
        // RVA: 0x03A381C0  token: 0x6000192
        public System.Void OnShow() { }
        // RVA: 0x03B5AFF0  token: 0x6000193
        public System.Void OnHide() { }
        // RVA: 0x038B8440  token: 0x6000194
        private System.Void _ClearMainChar() { }
        // RVA: 0x0309A240  token: 0x6000195
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x0309A2B0  token: 0x6000196
        private System.Boolean _CheckHpBarShowing() { }
        // RVA: 0x0309A420  token: 0x6000197
        private System.Void _SetHpBarShowing(System.Boolean showing, System.Boolean animate) { }
        // RVA: 0x09B1D498  token: 0x6000198
        private System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data) { }
        // RVA: 0x02CB5DF0  token: 0x6000199
        private System.Void _ProcessOnMainCharChange(Beyond.Gameplay.Core.Entity newMainChar) { }
        // RVA: 0x02B79FF0  token: 0x600019A
        private System.Void _OnTeamChanged() { }
        // RVA: 0x02CB4BF0  token: 0x600019B
        private System.Void _OnHpChange(Beyond.Gameplay.Core.Entity entity, System.Double change) { }
        // RVA: 0x02CB5920  token: 0x600019C
        private System.Void _SetHpFillAmount(System.Single hpPct) { }
        // RVA: 0x02967720  token: 0x600019D
        private System.Void _CalculateHpChangeDisplay(Beyond.Gameplay.Core.AbilitySystem target, System.Double deltaValue) { }
        // RVA: 0x0309A310  token: 0x600019E
        private System.Void _UpdateHpDisplay(System.Single deltaTime) { }
        // RVA: 0x09B1D4FC  token: 0x600019F
        private System.Void _OnTakeDamage(Beyond.Gameplay.Core.Entity entity, System.Boolean hideMainCharHpScreenEffect) { }
        // RVA: 0x0309A5D0  token: 0x60001A0
        private System.Void _OnMainCharHpActiveChange() { }
        // RVA: 0x02CB5A80  token: 0x60001A1
        private System.Void _OnBuffChangeCharHpBarVfx(System.Nullable<Beyond.GEnums.SpellInflictionOnCharType> type) { }
        // RVA: 0x03D00620  token: 0x60001A2
        private System.Void _HpVfxOutAnimCallback() { }
        // RVA: 0x09B1D3E0  token: 0x60001A3
        private System.Void _OnCharPassiveNumChanged(System.Single newNum) { }
        // RVA: 0x0229F350  token: 0x60001A4
        private Beyond.UI.UICharPassiveBase _GetOrCreateCharPassiveBase(System.String prefabName) { }
        // RVA: 0x03CA8030  token: 0x60001A5
        private System.Void _OnBuffIconChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean applied, Beyond.Gameplay.Core.Buff.FinishReason finishReason) { }
        // RVA: 0x03872300  token: 0x60001A6
        private System.Void _OnProgressBarBuffChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean applied, Beyond.Gameplay.Core.Buff.FinishReason finishReason) { }
        // RVA: 0x09B1D304  token: 0x60001A7
        private System.Void _OnBuffEnhanceChanged(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x09B1D10C  token: 0x60001A8
        private System.Void _BlinkBuffIcon(System.String spritePath) { }
        // RVA: 0x02CB8030  token: 0x60001A9
        private System.Void _SetUltimateBuff(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x09B1DA44  token: 0x60001AA
        private System.Void _UltimateBuffProgressOutAnimCallback() { }
        // RVA: 0x02B752F0  token: 0x60001AB
        private System.Void _RebuildUltimateBuffTracking() { }
        // RVA: 0x09B1D1FC  token: 0x60001AC
        private System.Boolean _IsUltimateBuffValid(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x02CB7F40  token: 0x60001AD
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> _GetUltimateBuffForAbility(Beyond.Gameplay.Core.AbilitySystem ability) { }
        // RVA: 0x02CB6ED0  token: 0x60001AE
        private System.Void _SelectUltimateBuff() { }
        // RVA: 0x09B1D8D0  token: 0x60001AF
        private System.Void _RefreshUltimateBuffProgress(System.Single deltaTime) { }
        // RVA: 0x09B1B1BC  token: 0x60001B0
        private System.Void _SetUltimateProgressFill(System.Single realFillAmount, System.Single totalDuration) { }
        // RVA: 0x0375CFE0  token: 0x60001B1
        public System.Void .ctor() { }
        // RVA: 0x03C7AD90  token: 0x60001B2
        private static System.Void .cctor() { }
        // RVA: 0x09B1D0DC  token: 0x60001B3
        private System.Void <_SetHpBarShowing>b__65_0() { }
        // RVA: 0x09B1CF20  token: 0x60001B4
        private System.Void <_BlinkBuffIcon>b__82_0(UnityEngine.Sprite sprite) { }
        // RVA: 0x09B1D014  token: 0x60001B5
        private System.Void <_BlinkBuffIcon>b__82_1() { }
        // RVA: 0x09B1D0A8  token: 0x60001B6
        private System.Void <_BlinkBuffIcon>b__82_2() { }
        // RVA: 0x058E2A30  token: 0x60001B7
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60001B8
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7B4  token: 0x60001B9
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0589E548  token: 0x60001BA
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000048  // size: 0xA8
    public class OutOfScreenTargetsCtrl : Beyond.UI.UIPanelBase
    {
        // Fields
        public System.Single ellipseXRadius;  // 0x70
        public System.Single ellipseYRadius;  // 0x74
        public UnityEngine.RectTransform main;  // 0x78
        public UnityEngine.RectTransform arrowModel;  // 0x80
        private readonly System.Collections.Generic.List<Beyond.UI.OutOfScreenTargetsCtrl.Arrow> m_arrows;  // 0x88
        private readonly System.Collections.Generic.List<Beyond.UI.OutOfScreenTargetsCtrl.Arrow> m_arrowsCache;  // 0x90
        private readonly System.Collections.Generic.List<Beyond.UI.OutOfScreenTargetsCtrl.Arrow> m_arrowsWithOutAnimation;  // 0x98
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> m_targetScrPoses;  // 0xa0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x03D00560  token: 0x60001BC
        public System.Void OnCreate() { }
        // RVA: 0x03A20900  token: 0x60001BD
        public System.Void OnShow() { }
        // RVA: 0x02406410  token: 0x60001BE
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09B1DAA4  token: 0x60001BF
        private Beyond.UI.OutOfScreenTargetsCtrl.Arrow _CreateOneArrow() { }
        // RVA: 0x09B1DCA8  token: 0x60001C0
        private System.ValueTuple<UnityEngine.Vector2,System.Single> _ScreenPosToUIPos(UnityEngine.Vector3 screenPos) { }
        // RVA: 0x039B3370  token: 0x60001C1
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x60001C2
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200004B  // size: 0x2C0
    public class SkillButton : Beyond.UI.UIPanelBase
    {
        // Fields
        public static System.String UI_SPRITE_SKILL_ICON;  // const
        private static System.Single HIGHLIGHT_CHECK_INTERVAL;  // const
        public UnityEngine.CanvasGroup viewNodeCanvasGroup;  // 0x70
        public Beyond.UI.UIAnimationWrapper deadNode;  // 0x78
        public UnityEngine.GameObject emptyNode;  // 0x80
        public System.Single deadAlpha;  // 0x88
        public UnityEngine.Color colorDefault;  // 0x8c
        public UnityEngine.Color colorRed;  // 0x9c
        public UnityEngine.Color colorYellow;  // 0xac
        public UnityEngine.Color colorBlue;  // 0xbc
        public UnityEngine.Color colorGreen;  // 0xcc
        public System.Single cantCastSkillAlpha;  // 0xdc
        public Beyond.UI.UIButton normalButton;  // 0xe0
        public Beyond.UI.UIImage normalIcon;  // 0xe8
        public Beyond.UI.UIImage normalIconShadow;  // 0xf0
        public Beyond.UI.UIImage normalColorBg;  // 0xf8
        public Beyond.UI.UIImage cdMask;  // 0x100
        public Beyond.UI.UIImage cdBg;  // 0x108
        public Beyond.UI.UIText cdText;  // 0x110
        public Beyond.UI.UIAnimationWrapper cdRefresh;  // 0x118
        public UnityEngine.CanvasGroup normalCanvasGroup;  // 0x120
        public Beyond.UI.UIAnimationWrapper strengLight;  // 0x128
        public UnityEngine.GameObject normalMoveEffectsBg;  // 0x130
        public Beyond.UI.UIAnimationWrapper hint;  // 0x138
        public Beyond.UI.UIAnimationWrapper normalButtonAnim;  // 0x140
        public UnityEngine.Transform normalKeyHint;  // 0x148
        public Beyond.UI.UIImage notRecommendMask;  // 0x150
        public Beyond.UI.UIImage notRecommendIcon;  // 0x158
        public Beyond.UI.UIImage normalPressFill;  // 0x160
        public Beyond.UI.UIButton ultimateButton;  // 0x168
        public Beyond.UI.UIImage ultimateIcon;  // 0x170
        public Beyond.UI.UIImage ultimateIconShadow;  // 0x178
        public Beyond.UI.UIImage ultimateColorBg;  // 0x180
        public Beyond.UI.UIImage uspRing;  // 0x188
        public Beyond.UI.UIImage uspRingSmall;  // 0x190
        public Beyond.UI.UIImage centerImage;  // 0x198
        public Beyond.UI.UIImage glow01;  // 0x1a0
        public Beyond.UI.UIImage outRing;  // 0x1a8
        public UnityEngine.CanvasGroup ultimateCanvasGroup;  // 0x1b0
        public Beyond.UI.UIImage pressFill;  // 0x1b8
        public Beyond.UI.UIAnimationWrapper ultimateButtonAnim;  // 0x1c0
        public Beyond.UI.UIImage ultKeyIcon;  // 0x1c8
        public UnityEngine.Transform ultKeyHint;  // 0x1d0
        public System.Single uspFillSpeed;  // 0x1d8
        public Beyond.UI.UIImage ultimateFillCompleteImage;  // 0x1e0
        public UnityEngine.GameObject ultimateBar;  // 0x1e8
        public Beyond.UI.UIImage ultimateBarFill;  // 0x1f0
        public System.Single ultimateBarFillMin;  // 0x1f8
        public System.Single ultimateBarFillMax;  // 0x1fc
        public Beyond.UI.UIImage ultimateCdFill;  // 0x200
        public Beyond.UI.UIImage ultimateBarFillFrame;  // 0x208
        public Beyond.UI.UIImage touchPressUspRing;  // 0x210
        public UnityEngine.RectTransform touchPressIndicator;  // 0x218
        private System.Int32 m_charIndex;  // 0x220
        private Beyond.DeviceInfo.InputType m_panelType;  // 0x224
        private Beyond.Gameplay.CharInfo m_charInfo;  // 0x228
        private Beyond.Gameplay.Core.SkillData m_ultimateSkillData;  // 0x230
        private Beyond.Gameplay.Core.SkillData m_normalSkillData;  // 0x238
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> m_charAbilityPtr;  // 0x240
        private Beyond.Gameplay.Core.Skill m_normalSkill;  // 0x250
        private Beyond.Gameplay.Core.Skill m_ultimateSkill;  // 0x258
        private System.Boolean m_isEmpty;  // 0x260
        private System.Single m_ultimatePressingTime;  // 0x264
        private System.Boolean m_isDeadState;  // 0x268
        private System.Boolean m_normalSkillReady;  // 0x269
        private System.Single m_lastHighlightCheckTime;  // 0x26c
        private System.Single m_uspTargetFill;  // 0x270
        private UnityEngine.Color m_normalIconShadowDefaultColor;  // 0x274
        private System.Boolean m_showNotRecommendState;  // 0x284
        private Beyond.UI.SkillButton.PressHandler m_pressHandler;  // 0x288
        private System.Boolean m_hasNotRecommendIcon;  // 0x290
        private Beyond.UI.UIAnimationWrapper m_ultimateBarAnim;  // 0x298
        private Beyond.HudFadeType m_hudFadeType;  // 0x2a0
        private System.String m_actionId;  // 0x2a8
        private System.String m_curNormalIconName;  // 0x2b0
        private System.String m_curUltimateIconName;  // 0x2b8
        private static System.Action<System.Int32> s_onPressSkillButtonStart;  // static @ 0x0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x02102C70 */ }
        Beyond.Gameplay.SkillSetting skillSetting { get; /* RVA: 0x09B25CB0 */ }

        // Methods
        // RVA: 0x02F67E90  token: 0x60001C8
        protected virtual System.Void OnAwake() { }
        // RVA: 0x02B77C60  token: 0x60001C9
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09B24E54  token: 0x60001CA
        public System.Void Close() { }
        // RVA: 0x0341C9E0  token: 0x60001CB
        public System.Void FirstTimeInit(System.Int32 charIndex, System.Boolean isDefaultPanel, System.Boolean isControllerPanel) { }
        // RVA: 0x02B78C20  token: 0x60001CC
        public System.Void RefreshSkillButton() { }
        // RVA: 0x09B25C44  token: 0x60001CD
        private System.Boolean _TryGetAliveAbilitySystem(Beyond.Gameplay.Core.AbilitySystem& abilitySys) { }
        // RVA: 0x09B2571C  token: 0x60001CE
        private System.Boolean _MustUpdate() { }
        // RVA: 0x0304E080  token: 0x60001CF
        public virtual System.Void PreTick(System.Single deltaTime) { }
        // RVA: 0x02A225C0  token: 0x60001D0
        private System.Void _InitSkillData() { }
        // RVA: 0x02A1F2B0  token: 0x60001D1
        private System.Void _UpdateMainUI(System.Single deltaTime) { }
        // RVA: 0x02A25B60  token: 0x60001D2
        private System.Void _CheckNormalSkillHighlight() { }
        // RVA: 0x09B259E0  token: 0x60001D3
        private System.Void _SetNotRecommendState(System.Boolean active) { }
        // RVA: 0x09B25324  token: 0x60001D4
        public System.Void OnCharacterDie() { }
        // RVA: 0x02B79930  token: 0x60001D5
        private System.Void _RefreshDeadState(System.Boolean anim) { }
        // RVA: 0x09B25B38  token: 0x60001D6
        private System.Void _SetUspFillAmount(System.Single fillAmount) { }
        // RVA: 0x02B78B40  token: 0x60001D7
        private System.Void _SetPressFillActive(System.Boolean active) { }
        // RVA: 0x09B25A6C  token: 0x60001D8
        private System.Void _SetPressFillAmount(System.Single fillAmount) { }
        // RVA: 0x02B77CE0  token: 0x60001D9
        public System.Void OnUspChange(Beyond.Gameplay.Core.Entity entity) { }
        // RVA: 0x09B256C0  token: 0x60001DA
        private System.Boolean _CanCastSkill(Beyond.Gameplay.Core.Skill skill) { }
        // RVA: 0x09B24BF8  token: 0x60001DB
        public System.Void CastSkill(Beyond.Gameplay.Core.Skill skill) { }
        // RVA: 0x09B25434  token: 0x60001DC
        public System.Void OnPressSkillStart(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B258F0  token: 0x60001DD
        private System.Void _OnOtherPressSkillButtonStart(System.Int32 charIndex) { }
        // RVA: 0x09B25380  token: 0x60001DE
        public System.Void OnPressSkillEnd(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02BF8300  token: 0x60001DF
        public System.Void OnPressCancelled() { }
        // RVA: 0x09B256DC  token: 0x60001E0
        private System.Void _CastUltimateSkill() { }
        // RVA: 0x09B25508  token: 0x60001E1
        public System.Void OnPressUltimateSkillStart(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B2560C  token: 0x60001E2
        public System.Void ToggleControllerSkillIndicator(System.Boolean active) { }
        // RVA: 0x09B257FC  token: 0x60001E3
        private System.Void _OnCharPotentialUnlock(Beyond.EventData<System.UInt64,System.UInt32>& eventData) { }
        // RVA: 0x09B25780  token: 0x60001E4
        private System.Void _OnCharNormalSkillChange(Beyond.EventData<System.UInt64,System.String>& eventData) { }
        // RVA: 0x09B25964  token: 0x60001E5
        private System.Void _OnSkillUpgradeSuccess(Beyond.EventData<System.UInt64,System.String,System.Int32>& eventData) { }
        // RVA: 0x02B799D0  token: 0x60001E6
        private System.Void _OnSkillButtonActiveConfigChanged() { }
        // RVA: 0x09B25878  token: 0x60001E7
        private System.Void _OnInputActionKeyUpdated(Beyond.EventData<System.String>& eventData) { }
        // RVA: 0x0341D330  token: 0x60001E8
        private System.Void _UpdateLongPressKeyHint() { }
        // RVA: 0x02B79BD0  token: 0x60001E9
        private System.Void _SetGoActive(System.Boolean active) { }
        // RVA: 0x0278AA30  token: 0x60001EA
        public System.Void SetEmpty(System.Boolean isEmpty) { }
        // RVA: 0x02BF8270  token: 0x60001EB
        public System.Void ClearBtnClick() { }
        // RVA: 0x038A12E0  token: 0x60001EC
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60001ED
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60001EE
        public System.Void <>iFixBaseProxy_OnEnable() { }

    }

    // TypeToken: 0x2000051  // size: 0x2D0
    public class SquadIcon : Beyond.UI.UIPanelBase
    {
        // Fields
        private static System.String UI_CHAR_HEAD_PREFIX;  // const
        private static System.String UI_SPRITE_DIR_CHAR_HEAD;  // const
        private static System.String UI_SPRITE_DIR_ITEM;  // const
        private static System.Single HP_CHANGE_TOLERANCE;  // const
        public static System.String CHAR_PASSIVE_UI_PATH;  // const
        public Beyond.UI.UIButton button;  // 0x70
        public UnityEngine.CanvasGroup canvasGroup;  // 0x78
        public Beyond.UI.UIAnimationWrapper charIconNode;  // 0x80
        public UnityEngine.CanvasGroup keyHint;  // 0x88
        public UnityEngine.GameObject viewNode;  // 0x90
        public UnityEngine.GameObject emptyNode;  // 0x98
        public Beyond.UI.UIAnimationWrapper viewAnimationWrapper;  // 0xa0
        public Beyond.UI.UIAnimationWrapper layoutAnimationWrapper;  // 0xa8
        public System.Single cantSwitchAlpha;  // 0xb0
        public Beyond.UI.UIImage characterIcon;  // 0xb8
        public Beyond.UI.UIImage characterIconDead;  // 0xc0
        public Beyond.UI.UIImage charCdMask;  // 0xc8
        public Beyond.UI.UIAnimationWrapper charMainEffectNode;  // 0xd0
        public Beyond.UI.UIAnimationWrapper charDeadNode;  // 0xd8
        public UnityEngine.GameObject hpNode;  // 0xe0
        public Beyond.UI.UIAnimationWrapper hpFlashAnim;  // 0xe8
        public Beyond.UI.UISlider hpSlider;  // 0xf0
        public System.Single hpFlashPercent;  // 0xf8
        public System.Single hpRedPercent;  // 0xfc
        public System.Single hpShakePercent;  // 0x100
        public Beyond.UI.UIImage hpFill;  // 0x108
        public Beyond.UI.UIImage hpRedFill;  // 0x110
        public Beyond.UI.UIAnimationWrapper hpRecoverAnim;  // 0x118
        public UnityEngine.RectTransform hpVfxNode;  // 0x120
        public Beyond.UI.UIImage[] hpVfxImages;  // 0x128
        public Beyond.SerializeFieldDictionary<Beyond.GEnums.SpellInflictionOnCharType,UnityEngine.Color> hpVfXColors;  // 0x130
        public UnityEngine.GameObject levelNode;  // 0x138
        public Beyond.UI.UIAnimationWrapper levelUpAnim;  // 0x140
        public Beyond.UI.UIText animLevelTxt;  // 0x148
        public Beyond.UI.UIText levelTxt;  // 0x150
        public UnityEngine.RectTransform comboCdNode;  // 0x158
        public Beyond.UI.UIAnimationWrapper comboCdBarAnim;  // 0x160
        public Beyond.UI.UIImage comboCdFill;  // 0x168
        public Beyond.UI.UIAnimationWrapper comboReadyAnim;  // 0x170
        public Beyond.UI.UIBuffNode buffNode;  // 0x178
        public UnityEngine.CanvasGroup tacticalCanvasGroup;  // 0x180
        public UnityEngine.GameObject tacticalCdNode;  // 0x188
        public UnityEngine.GameObject tacticalCastBar;  // 0x190
        public UnityEngine.GameObject tacticalDotNode;  // 0x198
        public UnityEngine.GameObject tacticalProhibitNode;  // 0x1a0
        public UnityEngine.GameObject tacticalEmptyNode;  // 0x1a8
        public Beyond.UI.UIImage tacticalIcon;  // 0x1b0
        public Beyond.UI.UIImage tacticalCastFill;  // 0x1b8
        public System.Single tacticalDeadAlpha;  // 0x1c0
        public System.Single tacticalItemUsedUpAlpha;  // 0x1c4
        public UnityEngine.GameObject fixedIcon;  // 0x1c8
        public UnityEngine.GameObject trailIcon;  // 0x1d0
        public UnityEngine.GameObject indieTrailIcon;  // 0x1d8
        public UnityEngine.CanvasGroup igniteBuffTextNode;  // 0x1e0
        public UnityEngine.Animation igniteBuffTextAnim;  // 0x1e8
        public Beyond.UI.UIText igniteBuffText;  // 0x1f0
        public UnityEngine.Color igniteBuffColorPulse;  // 0x1f8
        public UnityEngine.Color igniteBuffColorCryst;  // 0x208
        public UnityEngine.Color igniteBuffColorNatural;  // 0x218
        public UnityEngine.Color igniteBuffColorFire;  // 0x228
        public UnityEngine.Transform charPassiveNode;  // 0x238
        private System.Boolean <isEmpty>k__BackingField;  // 0x240
        private Beyond.DeviceInfo.InputType m_panelType;  // 0x244
        private System.Boolean m_isMainCharacter;  // 0x248
        private System.Boolean m_teamSwitchUnlocked;  // 0x249
        private System.Int32 m_charIndex;  // 0x24c
        private System.String m_charIndexStr;  // 0x250
        private Beyond.Gameplay.CharInfo m_charInfo;  // 0x258
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> m_charAbilityPtr;  // 0x260
        private System.Collections.Generic.List<Beyond.UI.TacticalDotCell> m_tacticalDots;  // 0x270
        private System.Single m_tacticalCastFillMax;  // 0x278
        private System.Int32 m_lastLevel;  // 0x27c
        private System.Boolean m_indicatorShowing;  // 0x280
        private System.Boolean m_lastComboCdReady;  // 0x281
        private System.Boolean m_comboReadyAnimShowing;  // 0x282
        private System.Boolean m_comboIconShowing;  // 0x283
        private Beyond.UI.UIHudFadeController m_hudFadeController;  // 0x288
        private Beyond.UI.UIAnimationWrapper m_hpVfxAnimWrapper;  // 0x290
        private System.String m_lastCharPassiveName;  // 0x298
        private Beyond.UI.UICharPassiveBase m_charPassiveBase;  // 0x2a0
        private DG.Tweening.Sequence m_keyHintFadeSequence;  // 0x2a8
        private System.Boolean m_inDeadState;  // 0x2b0
        private Beyond.UI.UIAnimationWrapper m_tacticalSwitchAnim;  // 0x2b8
        private System.Nullable<System.Boolean> m_tacticalInProgress;  // 0x2c0
        private System.Int32 m_tacticalItemLastDisplayCount;  // 0x2c4
        private System.Single m_comboCdNodeHeight;  // 0x2c8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        System.Boolean isEmpty { get; /* RVA: 0x03D579F0 */ set; /* RVA: 0x03D762E0 */ }

        // Methods
        // RVA: 0x02BDDC10  token: 0x600020F
        protected virtual System.Void OnAwake() { }
        // RVA: 0x0341C470  token: 0x6000210
        public System.Void FirstTimeInit(System.Int32 index, System.Boolean isDefaultPanel, System.Boolean isControllerPanel) { }
        // RVA: 0x09B25EC0  token: 0x6000211
        public System.Void Close() { }
        // RVA: 0x02B77E70  token: 0x6000212
        public System.Void InitSquadIcon(System.Boolean showFixed, System.Boolean showTrail) { }
        // RVA: 0x02409970  token: 0x6000213
        private System.Boolean _MustUpdate() { }
        // RVA: 0x024083E0  token: 0x6000214
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09B26A78  token: 0x6000215
        private System.Boolean _TryGetAliveAbilitySystem(Beyond.Gameplay.Core.AbilitySystem& abilitySys) { }
        // RVA: 0x02A213C0  token: 0x6000216
        private System.Void _UpdateComboSkillIcon(System.Boolean showAnim) { }
        // RVA: 0x0278AB20  token: 0x6000217
        public System.Void SetEmpty(System.Boolean empty) { }
        // RVA: 0x09B26600  token: 0x6000218
        public System.Void ToggleIndicator(System.Boolean isShow) { }
        // RVA: 0x09B26248  token: 0x6000219
        public System.Void InformKeyHint() { }
        // RVA: 0x02CB5460  token: 0x600021A
        private System.Void _OnHpChange(Beyond.Gameplay.Core.Entity entity, System.Double change) { }
        // RVA: 0x02B79DE0  token: 0x600021B
        private System.Void _SetLevelText() { }
        // RVA: 0x09B26758  token: 0x600021C
        private System.Void _OnIgniteBuffText(Beyond.EventData<System.UInt64,System.String,Beyond.GEnums.EnergyShardType>& eventData) { }
        // RVA: 0x09B263CC  token: 0x600021D
        public System.Void OnLevelChange() { }
        // RVA: 0x0399EF40  token: 0x600021E
        private System.Void _TryShowLevelUpAnim() { }
        // RVA: 0x02B7AEF0  token: 0x600021F
        public System.Void SetDeadState(System.Boolean dead) { }
        // RVA: 0x02A29340  token: 0x6000220
        private System.Void _UpdateIconAlpha() { }
        // RVA: 0x09B25D14  token: 0x6000221
        public System.Boolean CanSwitchToCenter(System.Boolean showTip) { }
        // RVA: 0x09B26428  token: 0x6000222
        public System.Void OnPressCharIconStart(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x02B777B0  token: 0x6000223
        public System.Void OnTacticalItemChange() { }
        // RVA: 0x025C0260  token: 0x6000224
        private System.Void _UpdateTacticalItemStatus() { }
        // RVA: 0x09B265A4  token: 0x6000225
        public System.Void OnTeamSwitchUnlocked() { }
        // RVA: 0x09B26908  token: 0x6000226
        private System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data) { }
        // RVA: 0x036CDC90  token: 0x6000227
        private System.Void _OnBuffChangeCharHpBarVfx(System.Nullable<Beyond.GEnums.SpellInflictionOnCharType> type) { }
        // RVA: 0x09B266E8  token: 0x6000228
        private System.Void _HpVfxOutAnimCallback() { }
        // RVA: 0x03A37630  token: 0x6000229
        private System.Void _OnCharPassiveNumChanged(System.Single newNum) { }
        // RVA: 0x0375D200  token: 0x600022A
        public System.Void .ctor() { }
        // RVA: 0x09B26690  token: 0x600022B
        private System.Void <_UpdateComboSkillIcon>b__98_0() { }
        // RVA: 0x09B266B4  token: 0x600022C
        private System.Void <_UpdateComboSkillIcon>b__98_1() { }
        // RVA: 0x03D2B1E0  token: 0x600022D
        private System.Void <_OnHpChange>b__102_0() { }
        // RVA: 0x09B2665C  token: 0x600022E
        private System.Void <_TryShowLevelUpAnim>b__106_0() { }
        // RVA: 0x058E2A30  token: 0x600022F
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0589E548  token: 0x6000230
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000052  // size: 0x40
    public class TacticalDotCell : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIImage dotBg;  // 0x18
        public Beyond.UI.UIImage dot;  // 0x20
        public Beyond.UI.UIImage dotWarning;  // 0x28
        private Beyond.UI.UIAnimationWrapper _anim;  // 0x30
        private System.Boolean _showDotWarning;  // 0x38
        private System.Boolean m_markInit;  // 0x39
        private System.Boolean m_isDotActive;  // 0x3a

        // Methods
        // RVA: 0x02B77A90  token: 0x6000231
        public System.Void Init() { }
        // RVA: 0x025C0830  token: 0x6000232
        public System.Void SetDotActive(System.Boolean isActive, System.Boolean playAnim) { }
        // RVA: 0x025C0760  token: 0x6000233
        public System.Void SetDotUsedUp(System.Boolean isUsedUp) { }
        // RVA: 0x0426FE60  token: 0x6000234
        public System.Void .ctor() { }
        // RVA: 0x09B26AE4  token: 0x6000235
        private System.Void <SetDotActive>b__8_0() { }

    }

    // TypeToken: 0x2000053  // size: 0x88
    public class UIAbnormalBuffCell : Beyond.UI.UIBuffCell
    {
        // Fields
        private Beyond.UI.UIImage _buffLifeTimeBar;  // 0x78
        private Beyond.UI.UIState.UIStateController _abnormalLevelState;  // 0x80

        // Methods
        // RVA: 0x09B270D8  token: 0x6000236
        public virtual System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x09B27260  token: 0x6000237
        protected virtual System.Void VisualInit(UnityEngine.Sprite sprite) { }
        // RVA: 0x09B271AC  token: 0x6000238
        protected virtual System.Void SetWarningState(System.Boolean isWarning) { }
        // RVA: 0x033E9BC0  token: 0x6000239
        public System.Void .ctor() { }
        // RVA: 0x09B27248  token: 0x600023A
        public System.Void <>iFixBaseProxy_OnTick(System.Single P0) { }
        // RVA: 0x09B27258  token: 0x600023B
        public System.Void <>iFixBaseProxy_VisualInit(UnityEngine.Sprite P0) { }
        // RVA: 0x09B27250  token: 0x600023C
        public System.Void <>iFixBaseProxy_SetWarningState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000054  // size: 0xB8
    public class UIAttachedBuffCell : Beyond.UI.UIBuffCell
    {
        // Fields
        private Beyond.UI.UIImage _buffIconPhantom;  // 0x78
        private Beyond.UI.UIImage _buffStackRing;  // 0x80
        private System.Collections.Generic.List<Beyond.UI.UIAnimationWrapper> _buffStackRingConsumeAnims;  // 0x88
        private System.Single _stackRingFillChangeSpeed;  // 0x90
        private System.Single _igniteFillDelay;  // 0x94
        private static System.String BUFF_ANIM_IGNITE;  // const
        private System.Int32 m_maxStackCount;  // 0x98
        private System.Nullable<System.Single> m_targetStackRingFillAmount;  // 0x9c
        private Beyond.Gameplay.PeriodicTimer m_igniteFillDelayTimer;  // 0xa8
        private System.Boolean m_isInConsumeAnim;  // 0xb0

        // Methods
        // RVA: 0x09B27620  token: 0x600023D
        protected virtual System.Void DataInit(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x09B277E4  token: 0x600023E
        public virtual System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x09B274BC  token: 0x600023F
        public virtual System.Void BeforePlayOutAnim() { }
        // RVA: 0x09B279C8  token: 0x6000240
        protected virtual System.Void SetBuffIcon(UnityEngine.Sprite sprite) { }
        // RVA: 0x09B28008  token: 0x6000241
        protected virtual System.Void SetStackElementActive(System.Boolean showStackCount) { }
        // RVA: 0x09B27A48  token: 0x6000242
        public virtual System.Void SetStackCount(System.Int32 stackCount, System.Boolean playAnim) { }
        // RVA: 0x09B27720  token: 0x6000243
        public virtual System.Void OnBuffIgnite() { }
        // RVA: 0x033E9BD0  token: 0x6000244
        public System.Void .ctor() { }
        // RVA: 0x03D71B70  token: 0x6000245
        private System.Void <SetStackCount>b__15_0() { }
        // RVA: 0x09B28098  token: 0x6000246
        public System.Void <>iFixBaseProxy_DataInit(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P0) { }
        // RVA: 0x09B27248  token: 0x6000247
        public System.Void <>iFixBaseProxy_OnTick(System.Single P0) { }
        // RVA: 0x09B28090  token: 0x6000248
        public System.Void <>iFixBaseProxy_BeforePlayOutAnim() { }
        // RVA: 0x09B280C0  token: 0x6000249
        public System.Void <>iFixBaseProxy_SetBuffIcon(UnityEngine.Sprite P0) { }
        // RVA: 0x09B280D0  token: 0x600024A
        public System.Void <>iFixBaseProxy_SetStackElementActive(System.Boolean P0) { }
        // RVA: 0x09B280C8  token: 0x600024B
        public System.Void <>iFixBaseProxy_SetStackCount(System.Int32 P0, System.Boolean P1) { }
        // RVA: 0x09B280B8  token: 0x600024C
        public System.Void <>iFixBaseProxy_OnBuffIgnite() { }

    }

    // TypeToken: 0x2000055  // size: 0x78
    public class UIBuffCell : UnityEngine.MonoBehaviour
    {
        // Fields
        protected Beyond.UI.UIImage _buffIcon;  // 0x18
        protected System.Boolean _canShowStackCountText;  // 0x20
        protected UnityEngine.GameObject _stackCountTextNode;  // 0x28
        protected Beyond.UI.UIText _buffStackCountText;  // 0x30
        protected Beyond.UI.UIAnimationWrapper _anim;  // 0x38
        protected UnityEngine.CanvasGroup _canvasGroup;  // 0x40
        protected System.Boolean _canShowWarningBg;  // 0x48
        protected Beyond.UI.UIImage _warningBg;  // 0x50
        protected Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> m_buffPtr;  // 0x58
        private System.UInt64 <nextInstanceId>k__BackingField;  // 0x68
        private System.String <curSpritePath>k__BackingField;  // 0x70

        // Properties
        System.UInt64 nextInstanceId { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x03D4F040 */ }
        System.String curSpritePath { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        Beyond.UI.UIAnimationWrapper anim { get; /* RVA: 0x03D4E2A0 */ }
        Beyond.Gameplay.Core.BuffData buffData { get; /* RVA: 0x02B5D200 */ }
        System.Int32 orderPriority { get; /* RVA: 0x02B5D1C0 */ }
        System.UInt64 buffInstanceUid { get; /* RVA: 0x02B5D4C0 */ }

        // Methods
        // RVA: 0x02B5D6F0  token: 0x6000255
        public System.Void Init(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, Beyond.LuaResourceLoader loader, System.Action onSpriteLoaded) { }
        // RVA: 0x03CBB6D0  token: 0x6000256
        protected virtual System.Void DataInit(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x02B5CCA0  token: 0x6000257
        protected virtual System.Void VisualInit(UnityEngine.Sprite sprite) { }
        // RVA: 0x025CF3B0  token: 0x6000258
        public System.Void Clear() { }
        // RVA: 0x09B280D8  token: 0x6000259
        public virtual System.Void BeforePlayOutAnim() { }
        // RVA: 0x02409C10  token: 0x600025A
        public virtual System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x02B5D400  token: 0x600025B
        public virtual System.Void SetVisible(System.Boolean visible) { }
        // RVA: 0x03999500  token: 0x600025C
        public virtual System.Void SetStackCount(System.Int32 stackCount, System.Boolean playAnim) { }
        // RVA: 0x09B2811C  token: 0x600025D
        public virtual System.Void OnBuffIgnite() { }
        // RVA: 0x03B0EFF0  token: 0x600025E
        protected virtual System.Void SetBuffIcon(UnityEngine.Sprite sprite) { }
        // RVA: 0x03A29770  token: 0x600025F
        protected virtual System.Void SetStackElementActive(System.Boolean isActive) { }
        // RVA: 0x03824DA0  token: 0x6000260
        protected virtual System.Void SetWarningState(System.Boolean isWarning) { }
        // RVA: 0x033E9C60  token: 0x6000261
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000057  // size: 0xB8
    public class UIBuffNode : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.SerializeFieldDictionary<Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle,Beyond.UI.UIBuffCell> _buffStyleCellTemplateDict;  // 0x68
        private Beyond.UI.UIBuffNode.BuffNodeType _buffNodeType;  // 0x70
        private System.Int32 _maxBuffCellCount;  // 0x74
        private System.Boolean m_isFirstInited;  // 0x78
        private readonly Beyond.LuaResourceLoader m_loader;  // 0x80
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> m_owner;  // 0x88
        private readonly Beyond.DynamicFastLookupCollection<Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle,Beyond.UI.UIBuffNode.BuffCellGroup> m_buffCellGroupDict;  // 0x98
        private readonly Beyond.DynamicFastLookupCollection<System.String,System.Collections.Generic.List<Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff>>> m_stackBuffsDict;  // 0xa0
        private readonly System.Collections.Generic.List<Beyond.UI.UIBuffCell> m_orderedBuffCellList;  // 0xa8
        private readonly System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff>> m_addBuffIconBuffer;  // 0xb0
        private static System.String BUFF_ANIM_STRONG_IN;  // const
        private static System.String BUFF_ANIM_IGNITE_OUT;  // const

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D567A0 */ }

        // Methods
        // RVA: 0x028466A0  token: 0x6000265
        private System.Void _OnFirstInit() { }
        // RVA: 0x025CE950  token: 0x6000266
        public System.Void OnPreWarm() { }
        // RVA: 0x02B76950  token: 0x6000267
        public System.Void Init(Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr) { }
        // RVA: 0x02B73450  token: 0x6000268
        public System.Void Refresh() { }
        // RVA: 0x02B72410  token: 0x6000269
        public System.Void Clear() { }
        // RVA: 0x02853420  token: 0x600026A
        public virtual System.Void TailLateTick(System.Single deltaTime) { }
        // RVA: 0x09B28160  token: 0x600026B
        protected virtual System.Void OnRelease() { }
        // RVA: 0x036B8E30  token: 0x600026C
        public System.Void OnBuffIconChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean applied, Beyond.Gameplay.Core.Buff.FinishReason finishReason) { }
        // RVA: 0x036B8F40  token: 0x600026D
        private System.Boolean _IsBuffIconInThisNode(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x036B8EC0  token: 0x600026E
        private System.Void _OnAddBuff(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x09B28504  token: 0x600026F
        private System.Void _OnRemoveBuff(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, Beyond.Gameplay.Core.Buff.FinishReason finishReason) { }
        // RVA: 0x02B5C870  token: 0x6000270
        private System.Void _AddBuffIconInternal(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean playAnim) { }
        // RVA: 0x09B285D8  token: 0x6000271
        private System.Void _RemoveBuffIconInternal(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, Beyond.Gameplay.Core.Buff.FinishReason finishReason) { }
        // RVA: 0x09B28228  token: 0x6000272
        private System.Void _OnBuffEnhanceChanged(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x09B28390  token: 0x6000273
        private System.Void _OnBuffIgnite(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr) { }
        // RVA: 0x02B76780  token: 0x6000274
        private System.Void _RegisterAbilityBuffEvent(Beyond.Gameplay.Core.AbilitySystem abilitySystem) { }
        // RVA: 0x02B765B0  token: 0x6000275
        private System.Void _UnregisterAbilityBuffEvent(Beyond.Gameplay.Core.AbilitySystem abilitySystem) { }
        // RVA: 0x02B5D510  token: 0x6000276
        private Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle _GetIconStyle(Beyond.Gameplay.Core.BuffData buffData) { }
        // RVA: 0x02B5CF70  token: 0x6000277
        private System.Void _SetBuffCellSiblingInOrder(Beyond.UI.UIBuffCell buffCell) { }
        // RVA: 0x02B5CEC0  token: 0x6000278
        private System.Void _DealWithBuffCellVisible() { }
        // RVA: 0x028464D0  token: 0x6000279
        public System.Void .ctor() { }
        // RVA: 0x05826E68  token: 0x600027A
        public System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }
        // RVA: 0x0577D7B4  token: 0x600027B
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000061  // size: 0x80
    public class UILifeTimeBuffCell : Beyond.UI.UIBuffCell
    {
        // Fields
        private Beyond.UI.UIImage _buffLifeTimeBar;  // 0x78

        // Methods
        // RVA: 0x02409A50  token: 0x600028E
        public virtual System.Void OnTick(System.Single deltaTime) { }
        // RVA: 0x03824D20  token: 0x600028F
        protected virtual System.Void SetWarningState(System.Boolean isWarning) { }
        // RVA: 0x033E9BC0  token: 0x6000290
        public System.Void .ctor() { }
        // RVA: 0x09B27248  token: 0x6000291
        public System.Void <>iFixBaseProxy_OnTick(System.Single P0) { }
        // RVA: 0x09B27250  token: 0x6000292
        public System.Void <>iFixBaseProxy_SetWarningState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000062  // size: 0x20
    public class UIHudFadeBase : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIStyleInputValidType validType;  // 0x18

        // Properties
        System.Boolean globalNeedShow { get; /* RVA: 0x02D4DA90 */ }

        // Methods
        // RVA: 0x04276C90  token: 0x6000294
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x50
    public class UIHudFadeConsoleController : Beyond.UI.UIHudFadeBase
    {
        // Fields
        public System.String key;  // 0x20
        public System.String foldState;  // 0x28
        private UnityEngine.Animator m_animator;  // 0x30
        private System.Boolean m_curShowing;  // 0x38
        private DG.Tweening.Sequence m_fadeSequence;  // 0x40
        private System.Int32 m_keyHash;  // 0x48
        private System.Int32 m_foldStateHash;  // 0x4c

        // Methods
        // RVA: 0x09B28EDC  token: 0x6000295
        private System.Void Awake() { }
        // RVA: 0x09B29228  token: 0x6000296
        private System.Void OnDestroy() { }
        // RVA: 0x09B293BC  token: 0x6000297
        public System.Void OnShow() { }
        // RVA: 0x09B29494  token: 0x6000298
        private System.Void _CheckNeedShow() { }
        // RVA: 0x09B29634  token: 0x6000299
        private System.Void _OnFadeHud() { }
        // RVA: 0x09B29684  token: 0x600029A
        private System.Void _OnInformShow(Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& eventData) { }
        // RVA: 0x09B29098  token: 0x600029B
        public System.Void InformShow() { }
        // RVA: 0x09B296F0  token: 0x600029C
        public System.Void .ctor() { }
        // RVA: 0x09B2946C  token: 0x600029D
        private System.Void <_CheckNeedShow>b__10_0() { }
        // RVA: 0x09B2946C  token: 0x600029E
        private System.Void <InformShow>b__13_0() { }

    }

    // TypeToken: 0x2000064  // size: 0x40
    public class UIHudFadeController : Beyond.UI.UIHudFadeBase
    {
        // Fields
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0x20
        private System.Boolean m_curShowing;  // 0x28
        private DG.Tweening.Sequence m_fadeSequence;  // 0x30
        private readonly System.Collections.Generic.HashSet<System.String> m_hudPreventFadeState;  // 0x38

        // Properties
        System.Boolean needShow { get; /* RVA: 0x02D4DA30 */ }
        Beyond.Gameplay.GameplayMiscSetting setting { get; /* RVA: 0x02D4DF40 */ }

        // Methods
        // RVA: 0x02D4CA00  token: 0x60002A1
        private System.Void Awake() { }
        // RVA: 0x09B33958  token: 0x60002A2
        private System.Void OnDestroy() { }
        // RVA: 0x02D4D840  token: 0x60002A3
        private System.Void _OnFadeHud() { }
        // RVA: 0x02D4D880  token: 0x60002A4
        private System.Void _CheckNeedShow() { }
        // RVA: 0x02CB57C0  token: 0x60002A5
        public System.Void SetLocalNeedShow(System.String state, System.Boolean needShowHud) { }
        // RVA: 0x09B33AEC  token: 0x60002A6
        private System.Void _OnInformShow(Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& eventData) { }
        // RVA: 0x03D2B610  token: 0x60002A7
        public System.Void InformShow() { }
        // RVA: 0x039AA420  token: 0x60002A8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000065  // size: 0x38
    public class UIHudFadeTouchSkill : Beyond.UI.UIHudFadeBase
    {
        // Fields
        private Beyond.UI.UIAnimationWrapper m_animationWrapper;  // 0x20
        private System.Boolean m_curShowing;  // 0x28
        private System.Boolean m_animInOrLoop;  // 0x29
        private DG.Tweening.Sequence m_fadeSequence;  // 0x30

        // Methods
        // RVA: 0x09B33B58  token: 0x60002A9
        private System.Void Awake() { }
        // RVA: 0x09B33E00  token: 0x60002AA
        private System.Void OnDestroy() { }
        // RVA: 0x09B33F94  token: 0x60002AB
        public System.Void OnShow() { }
        // RVA: 0x09B341B8  token: 0x60002AC
        private System.Void _CheckNeedShow() { }
        // RVA: 0x09B3439C  token: 0x60002AD
        private System.Void _OnFadeHud() { }
        // RVA: 0x09B343EC  token: 0x60002AE
        private System.Void _OnInformShow(Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& eventData) { }
        // RVA: 0x09B33CF8  token: 0x60002AF
        public System.Void InformShow() { }
        // RVA: 0x09B34458  token: 0x60002B0
        public System.Void .ctor() { }
        // RVA: 0x09B3418C  token: 0x60002B1
        private System.Void <_CheckNeedShow>b__7_0() { }
        // RVA: 0x09B34050  token: 0x60002B2
        private System.Void <InformShow>b__10_0() { }
        // RVA: 0x09B34164  token: 0x60002B3
        private System.Void <InformShow>b__10_1() { }

    }

    // TypeToken: 0x2000066  // size: 0x110
    public class UIAbilityTargetFollower : Beyond.UI.UIPanelBase
    {
        // Fields
        public Beyond.Gameplay.MountPoint mountPoint;  // 0x70
        public System.Single minDistance;  // 0x74
        public System.Single maxDistance;  // 0x78
        public UnityEngine.AnimationCurve scaleCurve;  // 0x80
        public System.Single deltaTowardCamera;  // 0x88
        public System.Boolean applyHeadBar2DOffset;  // 0x8c
        public System.Boolean outOfScreenCorrection;  // 0x8d
        public System.Single startCorrectionScreenHeight;  // 0x90
        public System.Single endCorrectionScreenHeight;  // 0x94
        public UnityEngine.Canvas canvas;  // 0x98
        public UnityEngine.CanvasGroup canvasGroup;  // 0xa0
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0xa8
        protected Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> m_target;  // 0xb0
        protected UnityEngine.Transform m_followTransform;  // 0xc0
        protected UnityEngine.Transform m_heightFollowTransform;  // 0xc8
        protected UnityEngine.Transform m_heightBaseTransform;  // 0xd0
        protected System.Single m_heightRangeMin;  // 0xd8
        protected System.Single m_heightRangeMax;  // 0xdc
        private UnityEngine.Transform m_cameraTransform;  // 0xe0
        private UnityEngine.Vector3 m_preDeltaPosition;  // 0xe8
        private System.Single m_preDeltaDistance;  // 0xf4
        private System.Boolean m_needReassignFollowTransform;  // 0xf8
        private System.Single m_deltaTowardCamera;  // 0xfc
        private UnityEngine.Vector3 m_originalScale;  // 0x100
        protected System.Boolean m_distanceVisible;  // 0x10c

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D567A0 */ }
        System.Boolean actualVisible { get; /* RVA: 0x03D762F0 */ }
        System.Nullable<UnityEngine.Vector3> followPosition { get; /* RVA: 0x09B31258 */ }

        // Methods
        // RVA: 0x034D90A0  token: 0x60002B7
        protected virtual System.Void OnAwake() { }
        // RVA: 0x037D4650  token: 0x60002B8
        public virtual System.Void TailLateTick(System.Single deltaTime) { }
        // RVA: 0x09B3064C  token: 0x60002B9
        public virtual System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x02B71D30  token: 0x60002BA
        public virtual System.Void Clear() { }
        // RVA: 0x03D48D10  token: 0x60002BB
        protected virtual System.Void UpdateData(System.Single deltaTime) { }
        // RVA: 0x09B30884  token: 0x60002BC
        private System.Void _TryRefreshFollowTransform() { }
        // RVA: 0x09B30958  token: 0x60002BD
        private System.Void _TryRefreshHeightFollowTransform() { }
        // RVA: 0x09B31148  token: 0x60002BE
        private System.Void _UpdateSelfTransform() { }
        // RVA: 0x09B30A98  token: 0x60002BF
        private System.Void _UpdatePos() { }
        // RVA: 0x09B304C0  token: 0x60002C0
        protected virtual UnityEngine.Vector3 GetOriginFollowPos() { }
        // RVA: 0x09B30F0C  token: 0x60002C1
        private System.Void _UpdateScale() { }
        // RVA: 0x09B307E8  token: 0x60002C2
        private System.Void _SetDistanceVisible(System.Boolean visible) { }
        // RVA: 0x09B30540  token: 0x60002C3
        protected System.Void SetActualVisible(System.Boolean visible) { }
        // RVA: 0x09B3035C  token: 0x60002C4
        protected UnityEngine.Vector3 GetAdjustedHeightOffset(Beyond.Gameplay.Core.AbilitySystem target) { }
        // RVA: 0x02846F40  token: 0x60002C5
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60002C6
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x05826E68  token: 0x60002C7
        public System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000067  // size: 0x140
    public class UILockAim : Beyond.UI.UIAbilityTargetFollower
    {
        // Fields
        public System.Single showCancelProgressRatio;  // 0x110
        public UnityEngine.CanvasGroup aimGroup;  // 0x118
        public Beyond.UI.UIImage aimRingImage;  // 0x120
        public Beyond.UI.UIImage rotateImage;  // 0x128
        public UnityEngine.CanvasGroup breakingAttackGroup;  // 0x130
        private Beyond.UI.UIAnimationWrapper m_aimGroupAnimWrapper;  // 0x138

        // Methods
        // RVA: 0x034D8E10  token: 0x60002C8
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B3446C  token: 0x60002C9
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02FE1FF0  token: 0x60002CA
        protected System.Void Start() { }
        // RVA: 0x03B5C140  token: 0x60002CB
        protected virtual System.Void UpdateData(System.Single deltaTime) { }
        // RVA: 0x09B346FC  token: 0x60002CC
        private System.Void _OnLockTargetFromAutoToManual() { }
        // RVA: 0x02FE2120  token: 0x60002CD
        private System.Void _RefreshTarget(Beyond.Gameplay.Core.AbilitySystem _) { }
        // RVA: 0x03D4B840  token: 0x60002CE
        public System.Void .ctor() { }
        // RVA: 0x09B346F4  token: 0x60002CF
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x09B1C3A0  token: 0x60002D0
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x09B1E484  token: 0x60002D1
        public System.Void <>iFixBaseProxy_UpdateData(System.Single P0) { }

    }

    // TypeToken: 0x2000068  // size: 0xF8
    public class UIMainCharFootBar : Beyond.TickableUIMono
    {
        // Fields
        public Beyond.Gameplay.MountPoint mountPoint;  // 0x68
        public UnityEngine.Vector3 worldOffset;  // 0x6c
        public Beyond.UI.UIAnimationWrapper dashBar;  // 0x78
        public UnityEngine.Transform dashBarParent;  // 0x80
        public UnityEngine.Transform dashBarTransform;  // 0x88
        public UnityEngine.Vector3 dashBarWorldOffset;  // 0x90
        public System.Single dashBarScale;  // 0x9c
        public System.Single dashBarScaleMobile;  // 0xa0
        public Beyond.UI.FootBarDashCell dashFillFull;  // 0xa8
        public Beyond.UI.FootBarDashCell dashFillHalf;  // 0xb0
        public System.Single smoothTime;  // 0xb8
        private Beyond.Gameplay.Core.Entity m_mainChar;  // 0xc0
        private System.Boolean m_dashBarNeedShow;  // 0xc8
        private System.Boolean m_dashBarShowing;  // 0xc9
        private UnityEngine.Transform m_target;  // 0xd0
        private UnityEngine.Vector3 m_smoothVelocity;  // 0xd8
        private System.Boolean m_notEnoughAnimShowing;  // 0xe4
        private System.Single m_curDashCellCount;  // 0xe8
        private System.Single m_curDashFillCount;  // 0xec
        private System.Collections.Generic.List<Beyond.UI.FootBarDashCell> m_dashFillList;  // 0xf0
        private static readonly Unity.Profiling.ProfilerMarker PROFILER_MARKER_UPDATE;  // static @ 0x0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x09B359AC  token: 0x60002D3
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B35D8C  token: 0x60002D4
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09B35F14  token: 0x60002D5
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B36778  token: 0x60002D6
        private System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data) { }
        // RVA: 0x09B3686C  token: 0x60002D7
        private System.Void _ProcessOnMainCharChange() { }
        // RVA: 0x09B3508C  token: 0x60002D8
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09B362A8  token: 0x60002D9
        private System.Void _OnDashCountChanged(System.Single curCount) { }
        // RVA: 0x09B3658C  token: 0x60002DA
        private System.Void _OnDashFailed() { }
        // RVA: 0x09B36714  token: 0x60002DB
        private System.Void _OnInteractNpc(Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& eventData) { }
        // RVA: 0x09B366A8  token: 0x60002DC
        private System.Void _OnDialogStart(Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& eventData) { }
        // RVA: 0x09B36644  token: 0x60002DD
        private System.Void _OnDialogFinish(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x09B36904  token: 0x60002DE
        private System.Void _SetInDialog(System.Boolean inDialog) { }
        // RVA: 0x09B3681C  token: 0x60002DF
        private System.Void _OnOutAnimCallback() { }
        // RVA: 0x09B369FC  token: 0x60002E0
        public System.Void .ctor() { }
        // RVA: 0x09B3699C  token: 0x60002E1
        private static System.Void .cctor() { }
        // RVA: 0x058E2A30  token: 0x60002E2
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60002E3
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7B4  token: 0x60002E4
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0589E548  token: 0x60002E5
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000069  // size: 0x150
    public class UIMainCharFootBarArc : Beyond.TickableUIMono
    {
        // Fields
        public Beyond.Gameplay.MountPoint mountPoint;  // 0x68
        public UnityEngine.Vector3 worldOffset;  // 0x6c
        public Beyond.UI.UIAnimationWrapper dashBar;  // 0x78
        public Beyond.UI.UIState.UIStateController dashBarStateController;  // 0x80
        public UnityEngine.Transform dashBarParent;  // 0x88
        public UnityEngine.RectTransform dashBarTransform;  // 0x90
        public Beyond.UI.UIImage dashFill;  // 0x98
        public Beyond.UI.UIImage dashFillLow;  // 0xa0
        public Beyond.UI.UIImage dashFillWhite;  // 0xa8
        public Beyond.UI.UIAnimationWrapper notEnoughAnim;  // 0xb0
        public UnityEngine.Vector3 dashBarWorldOffset;  // 0xb8
        public System.Single dashBarScale;  // 0xc4
        public System.Single dashBarScaleMobile;  // 0xc8
        public System.Single smoothTime;  // 0xcc
        public System.Int32 dashCountMin;  // 0xd0
        public System.Int32 dashCountMax;  // 0xd4
        public System.Single fillWhiteHoldTime;  // 0xd8
        public System.Single fillWhiteDecreaseSpeed;  // 0xdc
        public UnityEngine.AnimationCurve scaleCurve;  // 0xe0
        public System.Single scaleSmoothTime;  // 0xe8
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xf0
        private Beyond.Gameplay.Core.Entity m_mainChar;  // 0xf8
        private System.Boolean m_dashBarNeedShow;  // 0x100
        private System.Boolean m_dashBarShowing;  // 0x101
        private UnityEngine.Transform m_target;  // 0x108
        private UnityEngine.Vector3 m_smoothVelocity;  // 0x110
        private System.Boolean m_notEnoughAnimShowing;  // 0x11c
        private System.Single m_originalScale;  // 0x120
        private System.Single m_dampingScale;  // 0x124
        private readonly Beyond.Gameplay.PeriodicTimer m_fillWhiteStayTimer;  // 0x128
        private readonly System.Collections.Generic.HashSet<System.String> m_disableState;  // 0x130
        private System.Single m_curDashCellCount;  // 0x138
        private System.Single m_curDashFillAmount;  // 0x13c
        private Beyond.UI.UIHeadBar.HpDisplayState m_dashWhiteState;  // 0x140
        private System.Collections.Generic.Dictionary<System.Int32,System.String> m_dashCountStateNames;  // 0x148

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D567A0 */ }

        // Methods
        // RVA: 0x02974430  token: 0x60002E7
        protected virtual System.Void OnAwake() { }
        // RVA: 0x02CD5A50  token: 0x60002E8
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09B34798  token: 0x60002E9
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B34EDC  token: 0x60002EA
        private System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data) { }
        // RVA: 0x02CD5C90  token: 0x60002EB
        private System.Void _ProcessOnMainCharChange() { }
        // RVA: 0x02B4A640  token: 0x60002EC
        public virtual System.Void TailLateTick(System.Single deltaTime) { }
        // RVA: 0x02B4A1D0  token: 0x60002ED
        private System.Void _OnDashCountChanged(System.Single curCount) { }
        // RVA: 0x09B34C8C  token: 0x60002EE
        private System.Void _OnDashFailed() { }
        // RVA: 0x09B34E78  token: 0x60002EF
        private System.Void _OnInteractNpc(Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& eventData) { }
        // RVA: 0x09B34DA8  token: 0x60002F0
        private System.Void _OnDialogStart(Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& eventData) { }
        // RVA: 0x09B34D44  token: 0x60002F1
        private System.Void _OnDialogFinish(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x09B34F54  token: 0x60002F2
        private System.Void _OnPlayCutscene(Beyond.EventData<Beyond.Gameplay.Core.CinematicTimelineManagerBase.TimelineHandle>& eventData) { }
        // RVA: 0x09B34E14  token: 0x60002F3
        private System.Void _OnFinishCutscene(Beyond.EventData<System.Boolean>& eventData) { }
        // RVA: 0x039E0FC0  token: 0x60002F4
        private System.Void _OnForbidSystemChanged(Beyond.EventData<Beyond.Gameplay.ForbidType,System.Boolean>& eventData) { }
        // RVA: 0x09B34FB8  token: 0x60002F5
        private System.Void _SetInDialog(System.Boolean inDialog) { }
        // RVA: 0x036D7950  token: 0x60002F6
        public System.Void SetUIDisable(System.String key, System.Boolean disable) { }
        // RVA: 0x036D7A20  token: 0x60002F7
        private System.Void _RefreshDisableState() { }
        // RVA: 0x03D48350  token: 0x60002F8
        private System.Void _OnOutAnimCallback() { }
        // RVA: 0x037E2E30  token: 0x60002F9
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60002FA
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x60002FB
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7B4  token: 0x60002FC
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x05826E68  token: 0x60002FD
        public System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x200006A  // size: 0x28
    public class UIPoiseKnot : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup _canvasGroup;  // 0x18
        private Beyond.UI.UIAnimationWrapper _animationWrapper;  // 0x20

        // Methods
        // RVA: 0x09B36B40  token: 0x60002FE
        public System.Void SetVisible(System.Boolean visible) { }
        // RVA: 0x09B36AE0  token: 0x60002FF
        public System.Void KnotBreak() { }
        // RVA: 0x0426FE60  token: 0x6000300
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006B  // size: 0x118
    public class UIWeakLockAim : Beyond.UI.UIAbilityTargetFollower
    {
        // Fields
        public UnityEngine.CanvasGroup aimGroup;  // 0x110

        // Methods
        // RVA: 0x034D95C0  token: 0x6000301
        protected virtual System.Void OnAwake() { }
        // RVA: 0x03B72380  token: 0x6000302
        protected System.Void Start() { }
        // RVA: 0x09B36BB0  token: 0x6000303
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B36CBC  token: 0x6000304
        private System.Void _OnMainTargetChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& data) { }
        // RVA: 0x03B723D0  token: 0x6000305
        private System.Void _RefreshTarget() { }
        // RVA: 0x03D4CD70  token: 0x6000306
        public System.Void .ctor() { }
        // RVA: 0x09B346F4  token: 0x6000307
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x09B1C3A0  token: 0x6000308
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x200006C  // size: 0x20
    public class BlueprintPreviewHelper
    {
        // Fields
        private System.UInt16[][] m_data;  // 0x10
        private System.Int32 m_width;  // 0x18
        private System.Int32 m_height;  // 0x1c

        // Methods
        // RVA: 0x09B29B7C  token: 0x6000309
        public System.Void SetSize(System.Int32 width, System.Int32 height) { }
        // RVA: 0x09B2975C  token: 0x600030A
        public System.Void AddGridValue(System.Int32 x, System.Int32 y, System.Byte value) { }
        // RVA: 0x09B298D4  token: 0x600030B
        public System.Void BatchAddGridValue(System.Int32 xMin, System.Int32 yMin, System.Int32 width, System.Int32 height, System.Byte value) { }
        // RVA: 0x09B29AAC  token: 0x600030C
        public System.Byte GetGridValue(System.Int32 x, System.Int32 y, System.Byte& value2) { }
        // RVA: 0x0350B670  token: 0x600030D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x38
    public class CommonTrackerNodeComp : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIBlackboxTracker blackboxTracker;  // 0x18
        public Beyond.UI.UICampfireTracker campfireTracker;  // 0x20
        public Beyond.UI.UICommonTracker commonTracker;  // 0x28
        public Beyond.UI.UICommonLevelTracker commonLevelTracker;  // 0x30
        private static System.Single TOO_FAR_DISTANCE;  // const

        // Methods
        // RVA: 0x09B29D9C  token: 0x600030E
        public System.Void ShowStyleType(Beyond.Gameplay.CommonTrackingPointStyleType styleType, Beyond.Gameplay.CommonTrackingPointInfoBase trackerData) { }
        // RVA: 0x09B29CFC  token: 0x600030F
        public System.Void PlayOutAnimation(Beyond.Gameplay.CommonTrackingPointStyleType styleType) { }
        // RVA: 0x09B29FDC  token: 0x6000310
        public System.Void UpdatePosition(Beyond.Gameplay.CommonTrackingPointInfoBase trackerData) { }
        // RVA: 0x0426FE60  token: 0x6000311
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x48
    public class CommonTrackerUpdate : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform rootTransform;  // 0x18
        public UnityEngine.GameObject templateTrackerGo;  // 0x20
        public UnityEngine.Transform trackerParentTransform;  // 0x28
        private System.Collections.Generic.List<Beyond.UI.CommonTrackerUpdate.CommonTrackerItem> m_trackerItemCache;  // 0x30
        private System.Collections.Generic.List<Beyond.UI.CommonTrackerUpdate.CommonTrackerData> m_trackerDatas;  // 0x38
        private System.Collections.Generic.List<Beyond.UI.CommonTrackerUpdate.CommonTrackerItem> m_trackerItems;  // 0x40
        public static readonly System.Int32 PLAY_ANIM_IN_SIGNAL;  // static @ 0x0

        // Properties
        System.Boolean _inFactoryTopView { get; /* RVA: 0x025C0B60 */ }

        // Methods
        // RVA: 0x025C0950  token: 0x6000313
        public System.Void UpdateCommonTrackers(System.Boolean missionHudOpen, System.Int32 onShowSignal) { }
        // RVA: 0x03C7FE40  token: 0x6000314
        public System.Void AllTrackersPlayOutAnimation() { }
        // RVA: 0x09B2A45C  token: 0x6000315
        private System.Boolean _InitTrackInfoByIndex(System.Int32 trackerIdx, System.String key, Beyond.Gameplay.CommonTrackingPointInfoBase trackData) { }
        // RVA: 0x09B2A178  token: 0x6000316
        private Beyond.UI.CommonTrackerUpdate.CommonTrackerItem _CreateNewMissionTracker() { }
        // RVA: 0x025C0AB0  token: 0x6000317
        private System.Void _DeleteInvalidTracker() { }
        // RVA: 0x09B2A5C8  token: 0x6000318
        private System.Void _ShowTrackerGo(Beyond.UI.CommonTrackerUpdate.CommonTrackerItem trackerItem, Beyond.Gameplay.CommonTrackingPointInfoBase trackerData) { }
        // RVA: 0x09B2A3E8  token: 0x6000319
        private System.Void _HideTrackerGo(Beyond.UI.CommonTrackerUpdate.CommonTrackerItem trackerItem) { }
        // RVA: 0x09B2A31C  token: 0x600031A
        private System.Int32 _FindTrackIndexByKey(System.String key) { }
        // RVA: 0x03A1C150  token: 0x600031B
        public System.Void .ctor() { }
        // RVA: 0x03D44960  token: 0x600031C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000073  // size: 0x38
    public class UIBlackboxTracker : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public UnityEngine.RectTransform arrowRotator;  // 0x20
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x28
        public Beyond.UI.UIText distanceTxt;  // 0x30

        // Methods
        // RVA: 0x09B31314  token: 0x600031F
        public System.Void UpdatePosition(UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, System.Boolean needShowDistance) { }
        // RVA: 0x0426FE60  token: 0x6000320
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000074  // size: 0x38
    public class UICampfireTracker : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public UnityEngine.RectTransform arrowRotator;  // 0x20
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x28
        public Beyond.UI.UIImage image;  // 0x30

        // Methods
        // RVA: 0x09B315F0  token: 0x6000321
        public System.Void UpdatePosition(UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, System.Boolean needShowDistance) { }
        // RVA: 0x09B31570  token: 0x6000322
        public System.Void UpdateImage(Beyond.Gameplay.CommonTrackingPointInfoBase trackerData) { }
        // RVA: 0x0426FE60  token: 0x6000323
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000075  // size: 0x38
    public class UICommonLevelTracker : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public UnityEngine.RectTransform arrowRotator;  // 0x20
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x28
        public Beyond.UI.UIText distanceTxt;  // 0x30

        // Methods
        // RVA: 0x09B31700  token: 0x6000324
        public System.Void UpdatePosition(Beyond.Gameplay.PosValueState posValueState, System.Boolean needShowDistance, UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, Beyond.Gameplay.CommonTrackMapTier mapTier) { }
        // RVA: 0x0426FE60  token: 0x6000325
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000076  // size: 0x68
    public class UICommonTracker : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform rectTransform;  // 0x18
        public UnityEngine.RectTransform arrowRotator;  // 0x20
        public Beyond.UI.UIText distanceTxt;  // 0x28
        public Beyond.UI.UIAnimationWrapper animationWrapper;  // 0x30
        public Beyond.UI.UIImage levelImage;  // 0x38
        public UnityEngine.RectTransform normalNode;  // 0x40
        public Beyond.UI.UIImage normalShadowImage;  // 0x48
        public Beyond.UI.UIImage normalImage;  // 0x50
        public Beyond.UI.UIImage arrowUpImage;  // 0x58
        public UnityEngine.RectTransform arrowUpRectTransform;  // 0x60

        // Methods
        // RVA: 0x09B3196C  token: 0x6000326
        public System.Void UpdateImage(Beyond.Gameplay.CommonTrackingPointInfoBase trackerData) { }
        // RVA: 0x09B31A04  token: 0x6000327
        public System.Void UpdatePosition(Beyond.Gameplay.PosValueState posValueState, System.Boolean needShowDistance, UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, Beyond.Gameplay.CommonTrackMapTier mapTier) { }
        // RVA: 0x0426FE60  token: 0x6000328
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x100
    public class CoolerUnitProgressBarUI : Beyond.UI.WorldUIController
    {
        // Fields
        private Beyond.Gameplay.Core.Entity m_targetEntity;  // 0xc0
        private Beyond.Gameplay.Core.CoolerUnitComponent m_coolerUnitComponent;  // 0xc8
        private System.Single m_displayProgress;  // 0xd0
        private static System.Single LERP_SPEED;  // const
        private static System.Single MAX_STEP;  // const
        public Beyond.UI.UIText progressDesc;  // 0xd8
        public Beyond.UI.UIText progressText;  // 0xe0
        public Beyond.UI.UIImage progressImage;  // 0xe8
        public UnityEngine.Transform progressUIRoot;  // 0xf0
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xf8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B2A668  token: 0x600032A
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B2A9F0  token: 0x600032B
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B2A8C4  token: 0x600032C
        public virtual System.Void SetPos() { }
        // RVA: 0x09B2AB70  token: 0x600032D
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B2AC14  token: 0x600032E
        private System.Void _TickCanvasGroup(System.Single deltaTime) { }
        // RVA: 0x09B2ACF8  token: 0x600032F
        private System.Void _UpdateProgress(System.Single deltaTime) { }
        // RVA: 0x02846010  token: 0x6000330
        public System.Void .ctor() { }
        // RVA: 0x09B2ABEC  token: 0x6000331
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2AC04  token: 0x6000332
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2ABFC  token: 0x6000333
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC0C  token: 0x6000334
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x2000078  // size: 0x138
    public class CoolerUnitTemperatureCircleUI : Beyond.UI.WorldUIController
    {
        // Fields
        private static System.String AUDIO_EVENT_SUCCEED;  // const
        private static readonly UnityEngine.Color COLOR_BLUE;  // static @ 0x0
        private static readonly UnityEngine.Color COLOR_GREEN;  // static @ 0x10
        private static readonly UnityEngine.Color COLOR_RED;  // static @ 0x20
        private Beyond.Gameplay.Core.Entity m_targetEntity;  // 0xc0
        private Beyond.Gameplay.Core.CoolerUnitComponent m_coolerUnitComponent;  // 0xc8
        public Beyond.UI.UIImage bg;  // 0xd0
        public Beyond.UI.UIImage warningBg;  // 0xd8
        public Beyond.UI.UIText desc;  // 0xe0
        public UnityEngine.Transform tempCircleRoot;  // 0xe8
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xf0
        private Beyond.LangKey m_customDesc;  // 0xf8
        private Beyond.LangKey m_highTempDesc;  // 0x108
        private Beyond.LangKey m_lowTempDesc;  // 0x118
        private Beyond.LangKey m_goodTempDesc;  // 0x128

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B2AE84  token: 0x6000336
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B2B300  token: 0x6000337
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B2B1D4  token: 0x6000338
        public virtual System.Void SetPos() { }
        // RVA: 0x09B2B480  token: 0x6000339
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B2B884  token: 0x600033A
        private System.Void _TickCanvasGroup(System.Single deltaTime) { }
        // RVA: 0x09B2B968  token: 0x600033B
        private System.Void _UpdateUIState() { }
        // RVA: 0x09B2B5A4  token: 0x600033C
        private System.Void _SetState(Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState state) { }
        // RVA: 0x09B2B520  token: 0x600033D
        private System.String _GetLangKeyOrDefault(Beyond.LangKey customKey, System.String defaultKey) { }
        // RVA: 0x02846010  token: 0x600033E
        public System.Void .ctor() { }
        // RVA: 0x09B2BA14  token: 0x600033F
        private static System.Void .cctor() { }
        // RVA: 0x09B2ABEC  token: 0x6000340
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2AC04  token: 0x6000341
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2ABFC  token: 0x6000342
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC0C  token: 0x6000343
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x200007B  // size: 0x120
    public class CoolerUnitTemperatureUI : Beyond.UI.WorldUIController
    {
        // Fields
        private static readonly System.Single MIN_Y_POS;  // static @ 0x0
        private static readonly System.Single MAX_HEIGHT;  // static @ 0x4
        private static readonly UnityEngine.Color COLOR_BLUE;  // static @ 0x8
        private static readonly UnityEngine.Color COLOR_GREEN;  // static @ 0x18
        private static readonly UnityEngine.Color COLOR_RED;  // static @ 0x28
        private Beyond.Gameplay.Core.Entity m_targetEntity;  // 0xc0
        private Beyond.Gameplay.Core.CoolerUnitComponent m_coolerUnitComponent;  // 0xc8
        public System.Single greenBarTotalHeight;  // 0xd0
        public System.Single initBarPosY;  // 0xd4
        public System.Single totalBarPosY;  // 0xd8
        public System.Single initHandPosY;  // 0xdc
        public System.Single totalHandPosY;  // 0xe0
        private System.Single m_greenBarCurHeight;  // 0xe4
        public Beyond.UI.UIImage progressImage;  // 0xe8
        public UnityEngine.RectTransform greenBar;  // 0xf0
        public UnityEngine.RectTransform goodHand;  // 0xf8
        public UnityEngine.Transform temperatureUI;  // 0x100
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0x108
        private System.Boolean m_initBarSize;  // 0x110
        private System.Boolean m_initPosSynced;  // 0x111
        private System.Single m_lastMount;  // 0x114
        private Beyond.UI.CoolerUnitTemperatureUI.TempColorState m_colorState;  // 0x118
        private System.Boolean m_colorStateInited;  // 0x11c
        private static System.Single COLOR_EPS;  // const
        private static System.Single SNAP_THRESHOLD;  // const

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B2BAFC  token: 0x6000345
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B2BA8C  token: 0x6000346
        public virtual System.Void Clear() { }
        // RVA: 0x09B2BE3C  token: 0x6000347
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B2BD10  token: 0x6000348
        public virtual System.Void SetPos() { }
        // RVA: 0x09B2BFBC  token: 0x6000349
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B2C050  token: 0x600034A
        private System.Void _TickCanvasGroup(System.Single deltaTime) { }
        // RVA: 0x09B2BC94  token: 0x600034B
        public System.Void NormalizeRange(System.Single& min, System.Single& max) { }
        // RVA: 0x09B2C134  token: 0x600034C
        private System.Void _UpdateUIInfo(System.Single deltaTime) { }
        // RVA: 0x09B2C57C  token: 0x600034D
        private System.Void _UpdateUIPos(System.Single deltaTime) { }
        // RVA: 0x09B2CAB0  token: 0x600034E
        public System.Void .ctor() { }
        // RVA: 0x09B2CA10  token: 0x600034F
        private static System.Void .cctor() { }
        // RVA: 0x09B2ABEC  token: 0x6000350
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2C048  token: 0x6000351
        public System.Void <>iFixBaseProxy_Clear() { }
        // RVA: 0x09B2AC04  token: 0x6000352
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2ABFC  token: 0x6000353
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC0C  token: 0x6000354
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x200007D  // size: 0xF8
    public class CoolerUnitTotalProgressBarUI : Beyond.UI.WorldUIController
    {
        // Fields
        private System.Single m_displayProgress;  // 0xc0
        private System.Int32 m_lastDisplayPercent;  // 0xc4
        private static readonly System.String[] S_PERCENT_STRING;  // static @ 0x0
        public Beyond.UI.UIText progressDesc;  // 0xc8
        public Beyond.UI.UIText progressText;  // 0xd0
        public Beyond.UI.UIImage progressImage;  // 0xd8
        public UnityEngine.Transform progressUIRoot;  // 0xe0
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xe8
        private Beyond.Gameplay.Core.WaterAbsorbedImpactController m_module;  // 0xf0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B2CDE0  token: 0x6000356
        private static System.String[] _GeneratePercentStrings() { }
        // RVA: 0x09B2CAC4  token: 0x6000357
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B2CF48  token: 0x6000358
        private System.Void _ResetUI() { }
        // RVA: 0x09B2CEB8  token: 0x6000359
        private System.Void _GetCanvas() { }
        // RVA: 0x09B2D18C  token: 0x600035A
        private System.Boolean _TryGetModule(System.UInt64 id) { }
        // RVA: 0x09B2CC34  token: 0x600035B
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B2CB94  token: 0x600035C
        public virtual System.Void SetPos() { }
        // RVA: 0x09B2CD64  token: 0x600035D
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B2D0A8  token: 0x600035E
        private System.Void _TickCanvasGroup(System.Single deltaTime) { }
        // RVA: 0x09B2D2A4  token: 0x600035F
        private System.Void _UpdateProgress(System.Single deltaTime) { }
        // RVA: 0x09B2CFC4  token: 0x6000360
        private System.Void _SetProgressText(System.Int32 percent) { }
        // RVA: 0x09B2D3DC  token: 0x6000361
        public System.Void .ctor() { }
        // RVA: 0x09B2D38C  token: 0x6000362
        private static System.Void .cctor() { }
        // RVA: 0x09B2ABEC  token: 0x6000363
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2AC04  token: 0x6000364
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2ABFC  token: 0x6000365
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC0C  token: 0x6000366
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x200007E  // size: 0x48
    public class FacLineCell : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.Single HSV_VALUE_RATIO;  // const
        private UnityEngine.RectTransform _rectTransform;  // 0x18
        public UnityEngine.RectTransform topAgent;  // 0x20
        public UnityEngine.RectTransform bottomAgent;  // 0x28
        public Beyond.UI.UIAnimationWrapper lineAnimationWrapper;  // 0x30
        public Beyond.UI.UIAnimationWrapper decoAnimationWrapper;  // 0x38
        private System.Collections.Generic.List<Beyond.UI.UIImage> m_imageList;  // 0x40

        // Methods
        // RVA: 0x09B2D3F0  token: 0x6000367
        private System.Void Awake() { }
        // RVA: 0x09B2D818  token: 0x6000368
        public System.Void PlayLineAnimation(System.String animationName, DG.Tweening.TweenCallback callback) { }
        // RVA: 0x09B2D8F0  token: 0x6000369
        public System.Void PlayLineDecoAnimation(System.String animationName, DG.Tweening.TweenCallback callback) { }
        // RVA: 0x09B2D534  token: 0x600036A
        public System.Void ChangeLineColor(UnityEngine.Color color) { }
        // RVA: 0x09B2D784  token: 0x600036B
        public System.Void ChangeLineWidth(System.Single width) { }
        // RVA: 0x038DD690  token: 0x600036C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x50
    public class FacLineDrawer : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private UnityEngine.RectTransform m_rectTransform;  // 0x18
        private readonly System.Collections.Generic.Dictionary<System.UInt32,Beyond.UI.FacLineDrawer.LineData> m_lineCache;  // 0x20
        private readonly System.Collections.Generic.List<UnityEngine.GameObject> m_instantiatedLineCell;  // 0x28
        private System.UInt32 m_nextLineId;  // 0x30
        private static System.UInt32 INVALID_LINE_ID;  // const
        public UnityEngine.RectTransform startDrawAgent;  // 0x38
        public UnityEngine.RectTransform endDrawAgent;  // 0x40
        public UnityEngine.GameObject linkLinePrefab;  // 0x48

        // Methods
        // RVA: 0x09B2DA74  token: 0x600036F
        private System.Void Awake() { }
        // RVA: 0x09B2E3B4  token: 0x6000370
        private System.Void OnDestroy() { }
        // RVA: 0x09B2E6D4  token: 0x6000371
        private System.Void _Clear() { }
        // RVA: 0x09B2E890  token: 0x6000372
        private UnityEngine.GameObject _CloneLineObject(UnityEngine.GameObject sourceObject, UnityEngine.Transform locateTransform) { }
        // RVA: 0x09B2E9CC  token: 0x6000373
        private System.Void _RefreshCopyLineObjectColor(UnityEngine.GameObject lineObject, UnityEngine.Color color) { }
        // RVA: 0x09B2DC20  token: 0x6000374
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09B2DCC0  token: 0x6000375
        public System.UInt32 DrawLine(Beyond.UI.FacLineCell start, Beyond.UI.FacLineCell end) { }
        // RVA: 0x09B2E404  token: 0x6000376
        public System.Void PlayLineAnimation(System.UInt32 lineId, System.String animationName, DG.Tweening.TweenCallback callback) { }
        // RVA: 0x09B2E58C  token: 0x6000377
        public System.Void PlayPortLineDecoAnimation(System.UInt32 lineId, System.String animationName, System.Boolean isStart, DG.Tweening.TweenCallback callback) { }
        // RVA: 0x09B2DAF4  token: 0x6000378
        public System.Void ChangeLineColor(System.UInt32 lineId, UnityEngine.Color color) { }
        // RVA: 0x09B2DC70  token: 0x6000379
        public System.Void ClearDrawer() { }
        // RVA: 0x03A93C30  token: 0x600037A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000082  // size: 0x50
    public class FacPipeAnimationSetting : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.String PIPE_ANIMATION_PATH;  // const
        public System.String decoInAnimation;  // 0x18
        public System.String decoOutAnimation;  // 0x20
        public System.String itemAnimation;  // 0x28
        public System.Boolean needBoldAnimations;  // 0x30
        public System.String boldDecoInAnimation;  // 0x38
        public System.String boldDecoOutAnimation;  // 0x40
        public System.String boldItemAnimation;  // 0x48

        // Methods
        // RVA: 0x0426FE60  token: 0x600037B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x30
    public class FacRegionUpgradeEffectController : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _waitUpgradeNode;  // 0x18
        private UnityEngine.GameObject _upgradedRegionNode;  // 0x20
        private UnityEngine.GameObject _waitUpgradeSelectNode;  // 0x28

        // Methods
        // RVA: 0x09B2EC48  token: 0x600037C
        private System.Void _RefreshNodeState(UnityEngine.GameObject node, System.Boolean active) { }
        // RVA: 0x09B2EB48  token: 0x600037D
        public System.Void SetUpgradeState(System.Boolean isUpgraded) { }
        // RVA: 0x09B2EAC8  token: 0x600037E
        public System.Void SetSelectState(System.Boolean isSelected) { }
        // RVA: 0x09B2EBD8  token: 0x600037F
        public System.Void SetVisibleState(System.Boolean isVisible) { }
        // RVA: 0x0426FE60  token: 0x6000380
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000084  // size: 0x150
    public class UIFacTechTreePanel : Beyond.UI.UIPanelBase
    {
        // Fields
        private System.Boolean m_inited;  // 0x70
        private System.Single m_zoom;  // 0x74
        private System.Single m_zoomValue;  // 0x78
        private UnityEngine.Vector2 m_oriSize;  // 0x7c
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> m_zoomTween;  // 0x88
        private System.Single m_moveLeft;  // 0x90
        private System.Single m_oldMoveLeft;  // 0x94
        private System.Single m_moveTime;  // 0x98
        private System.Boolean m_openTweenFinished;  // 0x9c
        private UnityEngine.Vector2 m_anchoredPosOffset;  // 0xa0
        private System.Single m_horizontalOffset;  // 0xa8
        private System.Single m_verticalOffset;  // 0xac
        private UnityEngine.Vector2 m_lastScale;  // 0xb0
        private Beyond.UI.LuaPanel _techTreeLuaPanel;  // 0xb8
        private Beyond.UI.UITouchPanel _touchPanel;  // 0xc0
        private UnityEngine.RectTransform _techTreeRectTransform;  // 0xc8
        private UnityEngine.RectTransform _techTreePanel;  // 0xd0
        private System.Single _titleHight;  // 0xd8
        private System.Single _moveSpeed;  // 0xdc
        private System.Single _zoomSpeed;  // 0xe0
        private System.Single _zoomDefault;  // 0xe4
        private System.Single _zoomRangeMin;  // 0xe8
        private System.Single _zoomRangeMax;  // 0xec
        private System.Single _showNameScale;  // 0xf0
        private System.Single _zoomTweenTime;  // 0xf4
        private System.Single _moveNodeXOffset;  // 0xf8
        private System.Single _moveNodeYOffset;  // 0xfc
        private System.Single _startZoomTweenTime;  // 0x100
        private UnityEngine.AnimationCurve _openUICurve;  // 0x108
        private System.Single _movePosTime;  // 0x110
        private UnityEngine.AnimationCurve _movePosCurve;  // 0x118
        private System.Single _movePanelTime;  // 0x120
        private UnityEngine.AnimationCurve _movePanelCurve;  // 0x128
        private System.Single _unlockNodeTime;  // 0x130
        private UnityEngine.AnimationCurve _unlockNodeCurve;  // 0x138
        private System.Boolean m_controllerInitialized;  // 0x140
        private System.Boolean m_isDetailShown;  // 0x141
        private System.Single _controllerDragSpeed;  // 0x144
        private System.Single _controllerZoomSpeed;  // 0x148

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B321DC  token: 0x6000382
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B3235C  token: 0x6000383
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B31DF4  token: 0x6000384
        public System.Void InitData() { }
        // RVA: 0x09B32980  token: 0x6000385
        private System.Void _OnDrag(UnityEngine.Vector2 value) { }
        // RVA: 0x09B32B8C  token: 0x6000386
        private System.Void _OnZoom(System.Single value, System.Boolean needTween) { }
        // RVA: 0x09B333F4  token: 0x6000387
        private System.Void _SetScale(System.Boolean needTween, System.Single zoomTweenTime, UnityEngine.AnimationCurve curve, DG.Tweening.TweenCallback onFinish) { }
        // RVA: 0x09B32F98  token: 0x6000388
        private System.Void _RefreshAll() { }
        // RVA: 0x09B32D34  token: 0x6000389
        private System.Void _PosAdjust() { }
        // RVA: 0x09B33024  token: 0x600038A
        private System.Void _RefreshPivotPosition() { }
        // RVA: 0x09B33734  token: 0x600038B
        private System.Void _UpdatePositionOffsetAfterZoomed() { }
        // RVA: 0x09B3200C  token: 0x600038C
        public System.Void MoveNode(System.Single dis, System.Single nodeX, System.Single nodeY, System.Boolean ignorePos) { }
        // RVA: 0x09B31D50  token: 0x600038D
        public System.Void FocusNode(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete) { }
        // RVA: 0x09B3225C  token: 0x600038E
        public System.Void OnUnlockTech(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete) { }
        // RVA: 0x09B32550  token: 0x600038F
        public System.Void ZoomToFullTechTree(DG.Tweening.TweenCallback onComplete) { }
        // RVA: 0x09B32A28  token: 0x6000390
        private System.Void _OnUnlockMoveNode(System.Single nodeX, System.Single nodeY) { }
        // RVA: 0x09B327BC  token: 0x6000391
        private System.Void _ControllerUpdate() { }
        // RVA: 0x09B32860  token: 0x6000392
        private System.Void _ControllerZoomUpdate() { }
        // RVA: 0x09B325D4  token: 0x6000393
        private System.Void _ControllerDragUpdate() { }
        // RVA: 0x09B32300  token: 0x6000394
        public System.Void SetDetailShownState(System.Boolean isShown) { }
        // RVA: 0x09B33900  token: 0x6000395
        public System.Void .ctor() { }
        // RVA: 0x09B323E0  token: 0x6000396
        private System.Void <InitData>b__39_0(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B3246C  token: 0x6000397
        private System.Void <InitData>b__39_1(System.Single zoomValue) { }
        // RVA: 0x09B324DC  token: 0x6000398
        private System.Void <InitData>b__39_2() { }
        // RVA: 0x09B1C3A0  token: 0x6000399
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0577D7BC  token: 0x600039A
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000085  // size: 0xF0
    public class ForgeIronProgressBarUI : Beyond.UI.WorldUIController
    {
        // Fields
        public Beyond.UI.UIText progressDesc;  // 0xc0
        public Beyond.UI.UIText progressText;  // 0xc8
        public Beyond.UI.UIImage progressImage;  // 0xd0
        public UnityEngine.Transform progressUIRoot;  // 0xd8
        private Beyond.Gameplay.InteractiveLogicForgeIron m_logic;  // 0xe0
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xe8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B2ECFC  token: 0x600039C
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B2EE20  token: 0x600039D
        public virtual System.Void SetPos() { }
        // RVA: 0x09B2EF5C  token: 0x600039E
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B2F198  token: 0x600039F
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B2F2AC  token: 0x60003A0
        public System.Void UpdateProgress() { }
        // RVA: 0x02846010  token: 0x60003A1
        public System.Void .ctor() { }
        // RVA: 0x09B2ABEC  token: 0x60003A2
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2ABFC  token: 0x60003A3
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC04  token: 0x60003A4
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2AC0C  token: 0x60003A5
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x2000086  // size: 0x120
    public class ForgeIronTemperatureCircleUI : Beyond.UI.WorldUIController
    {
        // Fields
        private static System.String AUDIO_EVENT_SUCCEED;  // const
        private static readonly UnityEngine.Color COLOR_BLUE;  // static @ 0x0
        private static readonly UnityEngine.Color COLOR_GREEN;  // static @ 0x10
        private static readonly UnityEngine.Color COLOR_RED;  // static @ 0x20
        public Beyond.UI.UIImage bg;  // 0xc0
        public Beyond.UI.UIImage warningBg;  // 0xc8
        public Beyond.UI.UIText desc;  // 0xd0
        public UnityEngine.Transform tempCircleRoot;  // 0xd8
        public System.Int32 belongRound;  // 0xe0
        private Beyond.Gameplay.InteractiveLogicForgeIron m_logic;  // 0xe8
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0xf0
        private System.String m_customDesc;  // 0xf8
        private System.String m_highTempDesc;  // 0x100
        private System.String m_lowTempDesc;  // 0x108
        private System.String m_goodTempDesc;  // 0x110
        private System.Boolean m_hasPlaySuccessAudio;  // 0x118

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B2F638  token: 0x60003A7
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B2F5E0  token: 0x60003A8
        public virtual System.Void Clear() { }
        // RVA: 0x09B2F730  token: 0x60003A9
        public virtual System.Void SetPos() { }
        // RVA: 0x09B2F888  token: 0x60003AA
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B2FBE0  token: 0x60003AB
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B2FD6C  token: 0x60003AC
        public System.Void UpdateUIState() { }
        // RVA: 0x09B2FEC4  token: 0x60003AD
        private System.Void _SetState(System.Boolean max, System.Boolean low, System.Boolean high, Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState state) { }
        // RVA: 0x02846010  token: 0x60003AE
        public System.Void .ctor() { }
        // RVA: 0x09B30294  token: 0x60003AF
        private static System.Void .cctor() { }
        // RVA: 0x09B2ABEC  token: 0x60003B0
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2C048  token: 0x60003B1
        public System.Void <>iFixBaseProxy_Clear() { }
        // RVA: 0x09B2ABFC  token: 0x60003B2
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC04  token: 0x60003B3
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2AC0C  token: 0x60003B4
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x2000088  // size: 0x110
    public class ForgeIronTemperatureUI : Beyond.UI.WorldUIController
    {
        // Fields
        private static readonly UnityEngine.Color COLOR_BLUE;  // static @ 0x0
        private static readonly UnityEngine.Color COLOR_GREEN;  // static @ 0x10
        private static readonly UnityEngine.Color COLOR_RED;  // static @ 0x20
        public System.Single greenBarTotalHeight;  // 0xc0
        public System.Single initBarPosY;  // 0xc4
        public System.Single totalBarPosY;  // 0xc8
        public System.Single initHandPosY;  // 0xcc
        public System.Single totalHandPosY;  // 0xd0
        private System.Single m_greenBarCurHeight;  // 0xd4
        public Beyond.UI.UIImage progressImage;  // 0xd8
        public UnityEngine.RectTransform greenBar;  // 0xe0
        public UnityEngine.RectTransform goodHand;  // 0xe8
        public UnityEngine.Transform temperatureUI;  // 0xf0
        private Beyond.Gameplay.InteractiveLogicForgeIron m_logic;  // 0xf8
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0x100
        private System.Boolean m_initBarSize;  // 0x108
        private System.Single m_lastMount;  // 0x10c

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B3717C  token: 0x60003B6
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B37274  token: 0x60003B7
        public virtual System.Void SetPos() { }
        // RVA: 0x09B373B0  token: 0x60003B8
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B3751C  token: 0x60003B9
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B3763C  token: 0x60003BA
        public System.Void UpdateUIInfo() { }
        // RVA: 0x09B3792C  token: 0x60003BB
        public System.Void UpdateUIPos() { }
        // RVA: 0x09B37E20  token: 0x60003BC
        public System.Void .ctor() { }
        // RVA: 0x09B37DA8  token: 0x60003BD
        private static System.Void .cctor() { }
        // RVA: 0x09B2ABEC  token: 0x60003BE
        public System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3) { }
        // RVA: 0x09B2ABFC  token: 0x60003BF
        public System.Void <>iFixBaseProxy_SetPos() { }
        // RVA: 0x09B2AC04  token: 0x60003C0
        public System.Void <>iFixBaseProxy_SetUIForward() { }
        // RVA: 0x09B2AC0C  token: 0x60003C1
        public System.Void <>iFixBaseProxy_TickUI(System.Single P0) { }

    }

    // TypeToken: 0x2000089  // size: 0x1B8
    public class GuideFakeButton : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public Beyond.UI.UIButton targetButton;  // 0x180
        public Beyond.UI.UIToggle targetToggle;  // 0x188
        public Beyond.UI.UIDropdown targetDropdown;  // 0x190
        public System.String targetKeyHintActionId;  // 0x198
        private System.String m_targetActionId;  // 0x1a0
        public System.Action onClick;  // 0x1a8
        private Beyond.Input.InputBindingGroupMonoTarget m_parent;  // 0x1b0

        // Methods
        // RVA: 0x09B38464  token: 0x60003C2
        public System.Void ForceToggleTargetBinding(System.Boolean active, System.Boolean forDrag) { }
        // RVA: 0x09B3817C  token: 0x60003C3
        public System.Void CopyTargetBinding() { }
        // RVA: 0x09B38EC4  token: 0x60003C4
        private System.Void _OnTriggerPlayerAction(Beyond.EventData<System.String>& actionId) { }
        // RVA: 0x09B3806C  token: 0x60003C5
        public System.Void ClearTarget() { }
        // RVA: 0x09B37ECC  token: 0x60003C6
        public System.Void ClearBinding() { }
        // RVA: 0x09B37E34  token: 0x60003C7
        protected virtual System.Void Awake() { }
        // RVA: 0x09B388D4  token: 0x60003C8
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B38CB8  token: 0x60003C9
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B38A20  token: 0x60003CA
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B38B6C  token: 0x60003CB
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B38634  token: 0x60003CC
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B3801C  token: 0x60003CD
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09B38E14  token: 0x60003CE
        private System.Void _ClearOnClick() { }
        // RVA: 0x03D2C3A0  token: 0x60003CF
        public System.Void .ctor() { }
        // RVA: 0x09AAE8DC  token: 0x60003D0
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x09ACB964  token: 0x60003D1
        public System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09ACB96C  token: 0x60003D2
        public System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09B38E04  token: 0x60003D3
        public System.Void <>iFixBaseProxy_OnPointerEnter(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x09B38E0C  token: 0x60003D4
        public System.Void <>iFixBaseProxy_OnPointerExit(UnityEngine.EventSystems.PointerEventData P0) { }

    }

    // TypeToken: 0x200008A  // size: 0x60
    public class RegionMap3DCfg
    {
        // Fields
        public UnityEngine.GameObject model;  // 0x10
        public UnityEngine.GameObject ground;  // 0x18
        public Beyond.UI.UIRegionMap3DUICell ui;  // 0x20
        public UnityEngine.GameObject glitch;  // 0x28
        public UnityEngine.Vector4 uiRect;  // 0x30
        private System.String _ui;  // 0x40
        private System.String _model;  // 0x48
        private System.String _ground;  // 0x50
        private System.Boolean <isLoaded>k__BackingField;  // 0x58

        // Properties
        System.Boolean isLoaded { get; /* RVA: 0x03D4F7E0 */ set; /* RVA: 0x03D4F7F0 */ }

        // Methods
        // RVA: 0x02F679D0  token: 0x60003D7
        public System.Void Load(Beyond.UI.RegionMapSetting regionMapSetting) { }
        // RVA: 0x0350B670  token: 0x60003D8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008B  // size: 0x14
    public sealed struct RegionMapShowType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.UI.RegionMapShowType Map;  // const
        public static Beyond.UI.RegionMapShowType Watch;  // const

    }

    // TypeToken: 0x200008C  // size: 0x110
    public class RegionMapSetting : Beyond.UI.UIPanelBase
    {
        // Fields
        public static System.String UI_REGION_MAP_TRACK_ICON;  // const
        public UnityEngine.Transform uiRoot;  // 0x70
        public UnityEngine.Transform buildingRoot;  // 0x78
        public UnityEngine.Transform groundRoot;  // 0x80
        private UnityEngine.Transform _modelNode;  // 0x88
        private UnityEngine.Transform _uiNode;  // 0x90
        private UnityEngine.RectTransform _uiPlayerMark;  // 0x98
        private UnityEngine.Color _normalModelOuterColor;  // 0xa0
        private UnityEngine.Color _selectedModelOuterColor;  // 0xb0
        private UnityEngine.Vector3 _moveFinalRotation;  // 0xc0
        private Beyond.SerializeFieldDictionary<System.String,Beyond.UI.RegionMap3DCfg> _cfg;  // 0xd0
        private UnityEngine.Transform m_currLoadedRegionTransform;  // 0xd8
        private Beyond.UI.RegionMapShowType m_curShowType;  // 0xe0
        private System.Single m_animTimer;  // 0xe4
        private System.Single m_animDuration;  // 0xe8
        private System.Boolean m_playAnim;  // 0xec
        private readonly System.Collections.Generic.List<UnityEngine.RectTransform> m_trackIconList;  // 0xf0
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Renderer,UnityEngine.Material[]> m_refreshedMaterials;  // 0xf8
        private UnityEngine.Color m_normalLevelModelColor;  // 0x100
        private static System.String OUTER_COLOR_PROPERTY_NAME;  // const
        private static UnityEngine.MaterialPropertyBlock s_materialPropertyBlock;  // static @ 0x0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x01002730 */ }
        System.Collections.Generic.Dictionary<System.String,Beyond.UI.RegionMap3DCfg> cfg { get; /* RVA: 0x02F679A0 */ }
        UnityEngine.MaterialPropertyBlock m_materialPropertyBlock { get; /* RVA: 0x09B3AD08 */ }

        // Methods
        // RVA: 0x09B3A738  token: 0x60003DB
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02F6AD30  token: 0x60003DC
        private System.Void _InitUI() { }
        // RVA: 0x02F6B5F0  token: 0x60003DD
        private System.Void _InitPlayerIcon() { }
        // RVA: 0x02F69860  token: 0x60003DE
        private System.Void _InitTrackIcon() { }
        // RVA: 0x02F67F30  token: 0x60003DF
        private System.Void _InitSelect() { }
        // RVA: 0x02F6B480  token: 0x60003E0
        private System.Void _SetMapPos(UnityEngine.RectTransform rect, UnityEngine.Vector3 pos, Beyond.Gameplay.BasicLoadConfigInfo uiLevelMapConfig) { }
        // RVA: 0x02A71FE0  token: 0x60003E1
        private System.Void _RefreshMaterials() { }
        // RVA: 0x09B3AB08  token: 0x60003E2
        private System.Void _ClearMaterials() { }
        // RVA: 0x02F68390  token: 0x60003E3
        public System.Void InitData(Beyond.UI.RegionMapShowType shotType, UnityEngine.Transform center, UnityEngine.Transform moveRoot, System.Single watchRadius) { }
        // RVA: 0x02F677B0  token: 0x60003E4
        public System.Void MoveToPlayer(UnityEngine.Transform center, UnityEngine.Transform moveRoot) { }
        // RVA: 0x09B3A67C  token: 0x60003E5
        public UnityEngine.Transform GetNodeTransform(System.String levelId) { }
        // RVA: 0x09B3A320  token: 0x60003E6
        public UnityEngine.Vector3 GetNodeMoveTargetLocalPosition(System.String levelId, UnityEngine.Camera uiCamera, UnityEngine.Transform moveRoot) { }
        // RVA: 0x09B3A298  token: 0x60003E7
        public Beyond.UI.RegionMap3DCfg GetCfg(System.String levelId) { }
        // RVA: 0x02F67DD0  token: 0x60003E8
        public static System.Boolean IsCircleIntersectingRectangle(UnityEngine.Vector2 circleCenter, System.Single circleRadius, UnityEngine.Rect rectangle) { }
        // RVA: 0x09B3A980  token: 0x60003E9
        public System.Void SetLoadedRegionTransform(UnityEngine.Transform regionTransform) { }
        // RVA: 0x09B3A9E8  token: 0x60003EA
        public DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> StartRegionRectTransformMoveRotationTween(System.Single tweenDuration, UnityEngine.AnimationCurve tweenCurve) { }
        // RVA: 0x09B3A794  token: 0x60003EC
        public System.Void SetControllerLevelSelectedState(System.String levelId, System.Boolean isSelected) { }
        // RVA: 0x0284A770  token: 0x60003ED
        public System.Void .ctor() { }
        // RVA: 0x05F2CFD8  token: 0x60003EE
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200008D  // size: 0x30
    public class UIFacMainRegionConfig
    {
        // Fields
        public System.String levelId;  // 0x10
        public System.Int32 panelIndex;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Sprite> levelSprites;  // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector3> levelPositions;  // 0x28

        // Methods
        // RVA: 0x037CAFF0  token: 0x60003EF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008E  // size: 0x40
    public class UIFacMainRegion : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.String m_levelId;  // 0x18
        private System.Int32 m_panelIndex;  // 0x20
        private System.Collections.Generic.List<Beyond.UI.UIFacMainRegionConfig> _configList;  // 0x28
        private UnityEngine.RectTransform _rectTransform;  // 0x30
        private Beyond.UI.UIImage _image;  // 0x38

        // Methods
        // RVA: 0x09B3D560  token: 0x60003F0
        private System.Void _OnMainRegionLevelChanged(System.String levelId, System.Int32 panelIndex) { }
        // RVA: 0x0346AEB0  token: 0x60003F1
        private System.Void _RefreshRegionState() { }
        // RVA: 0x0346AA80  token: 0x60003F2
        private System.Void OnDestroy() { }
        // RVA: 0x0346AC90  token: 0x60003F3
        public System.Void InitMainRegion(System.String levelId, System.Int32 panelIndex) { }
        // RVA: 0x0346ADA0  token: 0x60003F4
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x60003F5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008F  // size: 0x40
    public class UILevelMapCrane : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.CombineKey m_eventKey;  // 0x18
        private Beyond.Resource.CachedPathAssetLoader m_assetLoader;  // 0x20
        private static System.String CRANE_SPRITE_FOLDER;  // const
        private static System.String CRANE_GAME_VAR_KEY;  // const
        private Beyond.SerializeReferenceDictionary<System.Int64,Beyond.UI.UILevelMapCrane.CraneSpritePath> _stateSpriteDict;  // 0x28
        private UnityEngine.RectTransform _rectTransform;  // 0x30
        private Beyond.UI.UIImage _image;  // 0x38

        // Methods
        // RVA: 0x09B3D818  token: 0x60003F6
        private System.Void OnDestroy() { }
        // RVA: 0x09B3DADC  token: 0x60003F7
        private System.Void _RefreshCraneState() { }
        // RVA: 0x09B3DA14  token: 0x60003F8
        private System.Void _ClearSpriteAsset() { }
        // RVA: 0x09B3DA7C  token: 0x60003F9
        private System.Void _OnCraneStateChanged(Beyond.EventData<System.Int64,System.Int64>& eventData) { }
        // RVA: 0x09B3D874  token: 0x60003FA
        private System.Void _BindAll() { }
        // RVA: 0x03CF07A0  token: 0x60003FB
        private System.Void _UnBindAll() { }
        // RVA: 0x09B3D7BC  token: 0x60003FC
        public System.Void InitCrane() { }
        // RVA: 0x03CF0760  token: 0x60003FD
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x60003FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000091  // size: 0x30
    public class UILevelMapGameplayArea : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Boolean m_initialized;  // 0x18
        private UnityEngine.RectTransform _rectTransform;  // 0x20
        private UnityEngine.RectTransform _circleRectTransform;  // 0x28

        // Methods
        // RVA: 0x09B3DDC4  token: 0x6000400
        private System.Void _RefreshGameplayArea(Beyond.Gameplay.GameplayAreaInstRuntimeData areaData) { }
        // RVA: 0x09B3DD60  token: 0x6000401
        public System.Void Init(Beyond.Gameplay.GameplayAreaInstRuntimeData areaData) { }
        // RVA: 0x03D4CBB0  token: 0x6000402
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x6000403
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000092  // size: 0xC0
    public class UILevelMapLimitInRect : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Boolean m_needLimitedInRect;  // 0x68
        public UnityEngine.Vector2 originalRectPosition;  // 0x6c
        public UnityEngine.Vector3 originalWorldPosition;  // 0x74
        public System.Boolean isLimitedInRect;  // 0x80
        public UnityEngine.Events.UnityEvent<System.Boolean> onIsLimitedInRectChanged;  // 0x88
        private UnityEngine.RectTransform _rectTransform;  // 0x90
        private UnityEngine.RectTransform _limitRectTransform;  // 0x98
        private Beyond.UI.UILevelMapLimitInRect.MaskShapeType _maskShapeType;  // 0xa0
        private System.Single _circleLimitRadius;  // 0xa4
        private System.Collections.Generic.List<UnityEngine.GameObject> _limitActiveNodes;  // 0xa8
        private System.Collections.Generic.List<UnityEngine.GameObject> _limitInactiveNodes;  // 0xb0
        private System.Collections.Generic.List<UnityEngine.RectTransform> _limitDirectionNodes;  // 0xb8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x02584F80  token: 0x6000405
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x03A92890  token: 0x6000406
        protected virtual System.Void OnEnable() { }
        // RVA: 0x03B42380  token: 0x6000407
        protected virtual System.Void OnRelease() { }
        // RVA: 0x025857F0  token: 0x6000408
        private System.Void _LimitInRect() { }
        // RVA: 0x03B423C0  token: 0x6000409
        public virtual System.Void ClearComponent() { }
        // RVA: 0x039C1340  token: 0x600040A
        public System.Void StartLimitMarkInRect() { }
        // RVA: 0x03D42D80  token: 0x600040B
        public System.Void StopLimitMarkInRect() { }
        // RVA: 0x03C902F0  token: 0x600040C
        public System.Void ForceRefreshLimitState() { }
        // RVA: 0x02846010  token: 0x600040D
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x600040E
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        // RVA: 0x058DD8AC  token: 0x600040F
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7B4  token: 0x6000410
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000094  // size: 0x90
    public class UILevelMapLine : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.Boolean m_initialized;  // 0x68
        private System.Single m_basicWidth;  // 0x6c
        private System.Single m_basicHeight;  // 0x70
        private System.Single m_extraScale;  // 0x74
        public UnityEngine.RectTransform rectTransform;  // 0x78
        public UnityEngine.RectTransform referenceTransform;  // 0x80
        public System.Boolean onlyHoldOnEnable;  // 0x88

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x03553030  token: 0x6000412
        protected virtual System.Void OnEnable() { }
        // RVA: 0x0262C9F0  token: 0x6000413
        private System.Void _HoldLineSize() { }
        // RVA: 0x0262CDC0  token: 0x6000414
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x0338E820  token: 0x6000415
        public System.Void Init(System.Single basicLength) { }
        // RVA: 0x02C72290  token: 0x6000416
        public virtual System.Void ClearComponent() { }
        // RVA: 0x02846020  token: 0x6000417
        public System.Void .ctor() { }
        // RVA: 0x058DD8AC  token: 0x6000418
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0589E548  token: 0x6000419
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000095  // size: 0xC8
    public class UILevelMapMissionArea : Beyond.TickableUIMono, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private UnityEngine.GameObject m_associatedTrackingMark;  // 0x68
        private System.Boolean m_initialized;  // 0x70
        private readonly UnityEngine.Vector3[] m_disappearWorldCorners;  // 0x78
        private readonly UnityEngine.Vector3[] m_circleWorldCorners;  // 0x80
        private System.Single m_missionGuideArea;  // 0x88
        public System.Boolean needUseCenterPosition;  // 0x8c
        private Beyond.UI.LuaPanel _luaPanel;  // 0x90
        private UnityEngine.RectTransform _rectTransform;  // 0x98
        private UnityEngine.RectTransform _circleRectTransform;  // 0xa0
        private UnityEngine.CanvasGroup _canvasGroup;  // 0xa8
        private System.Boolean _coexistWithMissionTrack;  // 0xb0
        private System.Single _notCoexistGuideAreaRadius;  // 0xb4
        private UnityEngine.RectTransform _disappearRect;  // 0xb8
        private Beyond.UI.UILevelMapMissionArea.DisappearRectShapeType _disappearRectShape;  // 0xc0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        System.Boolean needCheckMissionTrackCoexist { get; /* RVA: 0x028AF1D0 */ }
        System.Boolean coexistWithMissionTrack { get; /* RVA: 0x01151530 */ }
        System.Boolean notNeedCheckCoexistBecauseOfRadius { get; /* RVA: 0x028AF1F0 */ }

        // Methods
        // RVA: 0x028AF0D0  token: 0x600041E
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x037BEEA0  token: 0x600041F
        private System.Void _RefreshMissionArea(Beyond.Gameplay.MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData) { }
        // RVA: 0x028AF210  token: 0x6000420
        private System.Boolean _IsCircleOutsideDisappearRect() { }
        // RVA: 0x028AF110  token: 0x6000421
        private System.Void _DisappearIfOutRect() { }
        // RVA: 0x037BEDE0  token: 0x6000422
        public System.Void Init(Beyond.Gameplay.MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData, UnityEngine.GameObject associatedTrackingMark) { }
        // RVA: 0x03CDE7B0  token: 0x6000423
        public virtual System.Void ClearComponent() { }
        // RVA: 0x03D00CF0  token: 0x6000424
        public System.Void ForceRefreshDisappearIfOutRect() { }
        // RVA: 0x03A293A0  token: 0x6000425
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x6000426
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000097  // size: 0x20
    public class UILevelMapMisty : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.CombineKey m_eventKey;  // 0x18
        private System.Boolean m_needBind;  // 0x1c
        private static System.Int64 INVISIBLE_STATE_VALUE;  // const
        private static System.String MISTY_GAME_VAR_KEY;  // const

        // Methods
        // RVA: 0x09B3E018  token: 0x6000427
        private System.Void OnDestroy() { }
        // RVA: 0x09B3E278  token: 0x6000428
        private System.Void _RefreshMistyState() { }
        // RVA: 0x09B3E208  token: 0x6000429
        private System.Void _OnMistyStateChanged(Beyond.EventData<System.Int64,System.Int64>& eventData) { }
        // RVA: 0x09B3E068  token: 0x600042A
        private System.Void _BindAll() { }
        // RVA: 0x09B3E2F4  token: 0x600042B
        private System.Void _UnBindAll() { }
        // RVA: 0x09B3DEFC  token: 0x600042C
        public System.Void InitMisty() { }
        // RVA: 0x09B3DF60  token: 0x600042D
        public static System.Boolean IsMistyVisible() { }
        // RVA: 0x03D4CB80  token: 0x600042E
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x600042F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000098  // size: 0x38
    public class UILevelMapSwitchBtn : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private Beyond.UI.UIButton _button;  // 0x18
        private Beyond.UI.UIText _text;  // 0x20
        private UnityEngine.GameObject _mainContent;  // 0x28
        private UnityEngine.RectTransform _direction;  // 0x30

        // Methods
        // RVA: 0x02CDFAA0  token: 0x6000430
        public System.Void InitSwitchButton(System.String targetLevelId, System.Single directionAngle) { }
        // RVA: 0x03873990  token: 0x6000431
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x6000432
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009A  // size: 0xB0
    public class UILevelMapTouchPanelWrapper : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UITouchPanel _touchPanel;  // 0x68
        private System.Single _scrollCorrectionCoefficient;  // 0x70
        private UnityEngine.Transform _raycastRoot;  // 0x78
        private System.Int32 m_lastTouchCount;  // 0x80
        private UnityEngine.EventSystems.PointerEventData m_dragPointerEventData;  // 0x88
        private UnityEngine.EventSystems.PointerEventData m_scrollPointerEventData;  // 0x90
        private System.Boolean m_inWrapperDragging;  // 0x98
        private UnityEngine.Vector2 m_lastPointerPos;  // 0x9c
        private readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_raycastResults;  // 0xa8

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B3E3D8  token: 0x6000436
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B3E530  token: 0x6000437
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B3EB2C  token: 0x6000438
        private System.Boolean _IsFirstRaycastSelectable(UnityEngine.EventSystems.PointerEventData pointerEventData) { }
        // RVA: 0x09B3E63C  token: 0x6000439
        private System.Void _CheckDrag() { }
        // RVA: 0x09B3E984  token: 0x600043A
        private System.Void _CheckScroll() { }
        // RVA: 0x09B3EDA0  token: 0x600043B
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x600043C
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7BC  token: 0x600043D
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x200009B  // size: 0xE8
    public class UIRegionMap3DPanel : Beyond.UI.UIPanelBase
    {
        // Fields
        public static System.String HOVER_ANIM_NAME;  // const
        private Beyond.UI.LuaPanel _luaPanel;  // 0x70
        private Beyond.UI.UIAnimationWrapper _panelAnimationWrapper;  // 0x78
        private UnityEngine.Transform _zoomRoot;  // 0x80
        private UnityEngine.Transform _moveRoot;  // 0x88
        private System.Single _moveDuration;  // 0x90
        private System.Single _completeRatio;  // 0x94
        private UnityEngine.AnimationCurve _moveCurve;  // 0x98
        private UnityEngine.AnimationCurve _rotationCurve;  // 0xa0
        private System.Single _zoomDistance;  // 0xa8
        private UnityEngine.AnimationCurve _zoomCurve;  // 0xb0
        private Beyond.UI.RegionMapSetting m_regionMapSetting;  // 0xb8
        private System.String m_toLevel;  // 0xc0
        private System.String m_toInsId;  // 0xc8
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> m_moveTween;  // 0xd0
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> m_rotateTween;  // 0xd8
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> m_zoomTween;  // 0xe0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09B41B24  token: 0x600043F
        private UnityEngine.Transform _GetNodeTransform(System.String levelId) { }
        // RVA: 0x09B41A70  token: 0x6000440
        private UnityEngine.Vector3 _GetMoveTargetLocalPosition(System.String levelId) { }
        // RVA: 0x09B41B90  token: 0x6000441
        private System.Void _OnDoMoveTween() { }
        // RVA: 0x09B4148C  token: 0x6000442
        public System.Void InitPanel(Beyond.UI.RegionMapSetting regionMapSetting) { }
        // RVA: 0x09B415A4  token: 0x6000443
        public System.Void OnClickLevelBtn(System.String levelId, System.String insId) { }
        // RVA: 0x09B418EC  token: 0x6000444
        public System.Void OnLevelHoverChanged(System.String levelId, System.Boolean isHover) { }
        // RVA: 0x09B41D10  token: 0x6000445
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009C  // size: 0x88
    public class UIRegionMap3DUICell : Beyond.UI.UIPanelBase
    {
        // Fields
        public Beyond.UI.UIText showName;  // 0x70
        public UnityEngine.RectTransform iconRoot;  // 0x78
        public Beyond.UI.UIButton btn;  // 0x80

        // Methods
        // RVA: 0x03D47C80  token: 0x6000446
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009D  // size: 0x80
    public class UIRegionMapTrackIcon : Beyond.UI.UIPanelBase
    {
        // Fields
        private Beyond.UI.UIImage _icon;  // 0x70
        private Beyond.UI.UIImage _track;  // 0x78

        // Methods
        // RVA: 0x03A2C0D0  token: 0x6000447
        public System.Void InitData(Beyond.Gameplay.MissionTrackingMarkInstRuntimeDate data) { }
        // RVA: 0x03D47C80  token: 0x6000448
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009E  // size: 0x48
    public class UISettlementRegion : UnityEngine.MonoBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        private System.String m_settlementId;  // 0x18
        private Beyond.UI.UISettlementRegion.SettlementRegionSpriteData m_settlementSpriteData;  // 0x20
        private System.Boolean m_needBind;  // 0x28
        private Beyond.CombineKey m_bindKey;  // 0x2c
        private Beyond.SerializeFieldDictionary<System.String,Beyond.UI.UISettlementRegion.SettlementRegionSpriteData> _spriteDict;  // 0x30
        private UnityEngine.RectTransform _rectTransform;  // 0x38
        private Beyond.UI.UIImage _image;  // 0x40
        public static System.String SETTLEMENT_REGION_SPRITE_FOLDER;  // const

        // Methods
        // RVA: 0x03A4E710  token: 0x6000449
        private System.Void OnDestroy() { }
        // RVA: 0x02F43660  token: 0x600044A
        private System.Void _RefreshSpriteWithTier(System.Int32 tier) { }
        // RVA: 0x02F42050  token: 0x600044B
        private System.Void _RefreshSettlementRegionState() { }
        // RVA: 0x09B41E8C  token: 0x600044C
        private System.Void _OnSettlementUnlocked(Beyond.EventData<System.String>& param) { }
        // RVA: 0x09B41D90  token: 0x600044D
        private System.Void _BindAll() { }
        // RVA: 0x09B41EFC  token: 0x600044E
        private System.Void _UnBindAll() { }
        // RVA: 0x02F41FF0  token: 0x600044F
        public System.Void InitSettlementRegion(System.String settlementId, UnityEngine.Vector3 centerPos) { }
        // RVA: 0x03B13160  token: 0x6000450
        public System.Boolean GetNeedRefreshSettlementRegionTier() { }
        // RVA: 0x09B41D2C  token: 0x6000451
        public System.Void RefreshSettlementRegionWithTier(System.Int32 tier) { }
        // RVA: 0x03A4E750  token: 0x6000452
        public virtual System.Void ClearComponent() { }
        // RVA: 0x0426FE60  token: 0x6000453
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1  // size: 0x30
    public class ChessboardDrop : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp
    {
        // Fields
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDropEvent;  // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerEnterEvent;  // 0x20
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerExitEvent;  // 0x28

        // Methods
        // RVA: 0x09B36DE4  token: 0x6000456
        public virtual System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B36E80  token: 0x6000457
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B36F1C  token: 0x6000458
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B36FB8  token: 0x6000459
        private System.Boolean _CheckEventValid(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B36D1C  token: 0x600045A
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09B36D94  token: 0x600045B
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09B37098  token: 0x600045C
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x600045D
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000A2  // size: 0x28
    public class PuzzleCellDrag : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        // Fields
        private Beyond.UI.PuzzleDrag m_parent;  // 0x18
        private System.Boolean _needHovering;  // 0x20

        // Methods
        // RVA: 0x09B39060  token: 0x600045E
        public System.Void Init(Beyond.UI.PuzzleDrag puzzleDrag) { }
        // RVA: 0x09B390C4  token: 0x600045F
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39130  token: 0x6000460
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B3919C  token: 0x6000461
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39274  token: 0x6000462
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B393C0  token: 0x6000463
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39208  token: 0x6000464
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B392E0  token: 0x6000465
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39350  token: 0x6000466
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x0426FE60  token: 0x6000467
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3  // size: 0x30
    public class PuzzleControllerHelper : UnityEngine.EventSystems.UIBehaviour
    {
        // Fields
        private Beyond.UI.LuaPanel m_luaPanel;  // 0x18
        private UnityEngine.EventSystems.PointerEventData m_controllerFocusEventData;  // 0x20
        private readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_raycastResults;  // 0x28

        // Properties
        System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults { get; /* RVA: 0x09B39904 */ }

        // Methods
        // RVA: 0x09B3942C  token: 0x6000469
        protected virtual System.Void Awake() { }
        // RVA: 0x09B3951C  token: 0x600046A
        public System.Int32 TryGetPuzzleSlotIndexByPos(UnityEngine.RectTransform gridCell) { }
        // RVA: 0x09B39884  token: 0x600046B
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x600046C
        public System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x20000A4  // size: 0x70
    public class PuzzleDrag : UnityEngine.EventSystems.UIBehaviour, Beyond.UI.IUIClearable, Beyond.ILuaCallCSharp, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        // Fields
        private UnityEngine.CanvasGroup m_canvasGroup;  // 0x18
        private Beyond.UI.LuaPanel m_panel;  // 0x20
        private System.Int32 m_luaIndex;  // 0x28
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDragEvent;  // 0x30
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDragEvent;  // 0x38
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDragEvent;  // 0x40
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerDownEvent;  // 0x48
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerUpEvent;  // 0x50
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerClickEvent;  // 0x58
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerEnterEvent;  // 0x60
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerExitEvent;  // 0x68

        // Properties
        Beyond.UI.LuaPanel panel { get; /* RVA: 0x09B3A1E0 */ }
        System.Int32 luaIndex { get; /* RVA: 0x03D4EB90 */ }

        // Methods
        // RVA: 0x09B39954  token: 0x600046F
        protected virtual System.Void Awake() { }
        // RVA: 0x09B39AA4  token: 0x6000470
        public virtual System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39BA0  token: 0x6000471
        public virtual System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39C38  token: 0x6000472
        public virtual System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39D70  token: 0x6000473
        public virtual System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39F14  token: 0x6000474
        public virtual System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39CE4  token: 0x6000475
        public virtual System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39DFC  token: 0x6000476
        public virtual System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B39E88  token: 0x6000477
        public virtual System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        // RVA: 0x09B399D4  token: 0x6000478
        public virtual System.Void ClearComponent() { }
        // RVA: 0x09B39B50  token: 0x6000479
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x09B39FA0  token: 0x600047A
        public System.Void SetIndex(System.Int32 index) { }
        // RVA: 0x09B39FF8  token: 0x600047B
        public System.Void .ctor() { }
        // RVA: 0x0350B670  token: 0x600047C
        public System.Void <>iFixBaseProxy_Awake() { }
        // RVA: 0x0350B670  token: 0x600047D
        public System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000A5  // size: 0x30
    public class UIBrokenLine : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Material m_material;  // 0x18
        private static System.Int32 MAX_SET_VALUE_COUNT;  // const
        private static System.String UI_BROKEN_LINE_SHADER_NAME;  // const
        private static System.String Y_VALUE_PROPERTY_NAME_FORMAT;  // const
        private static System.String X_SCALE_PROPERTY_NAME;  // const
        private static System.String LINE_WEIGHT_PROPERTY_NAME;  // const
        private System.Collections.Generic.List<System.Single> m_tmpList;  // 0x20
        private System.Boolean m_isInit;  // 0x28
        private System.Single _lineWeight;  // 0x2c

        // Methods
        // RVA: 0x09B3AEDC  token: 0x600047E
        private System.Void Awake() { }
        // RVA: 0x09B3B398  token: 0x600047F
        private System.Void _Init() { }
        // RVA: 0x09B3AF34  token: 0x6000480
        private System.Void OnDestroy() { }
        // RVA: 0x09B3AFB4  token: 0x6000481
        public System.Void SetYValueByArray(System.Single[] yValue, System.Int32 count) { }
        // RVA: 0x09B3B0AC  token: 0x6000482
        public System.Void SetYValue(System.Collections.Generic.List<System.Single> yValue, System.Int32 count) { }
        // RVA: 0x09B3B594  token: 0x6000483
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A6  // size: 0xB0
    public class UICommonScanController : Beyond.TickableUIMono
    {
        // Fields
        private System.UInt64 <entityLogicId>k__BackingField;  // 0x68
        protected UnityEngine.Transform m_camera;  // 0x70
        protected Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> m_entity;  // 0x78
        protected UnityEngine.Transform m_followTarget;  // 0x88
        public System.Single yOffset;  // 0x90
        public static readonly System.Int32 STATE_ON;  // static @ 0x0
        public static readonly System.Int32 STATE_OFF;  // static @ 0x4
        public static System.Int32 MAX_HP_RATIO;  // const
        public static System.Single TICK_REFRESH_NEED;  // const
        public static System.Int32 DONT_REFRESH;  // const
        private System.Boolean m_uiActive;  // 0x94
        protected System.Int64 m_nextRefreshTime;  // 0x98
        protected System.Single m_hpRatio;  // 0xa0
        protected UnityEngine.Vector3 m_fixedPoint;  // 0xa4

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.UInt64 entityLogicId { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x03D4F040 */ }
        System.Boolean uiActive { get; /* RVA: 0x03D6CD80 */ set; /* RVA: 0x09B3BE64 */ }

        // Methods
        // RVA: 0x09B3B8EC  token: 0x6000489
        public virtual System.Void SetTarget(Beyond.Gameplay.Core.Entity target, System.Int64 nextRefresh, System.Single hpRatio) { }
        // RVA: 0x09B3BC74  token: 0x600048A
        private System.Void _UpdatePos() { }
        // RVA: 0x09B3B70C  token: 0x600048B
        public System.Void SetFixPoint(UnityEngine.Vector3 pos, System.UInt64 waterVolume) { }
        // RVA: 0x09B3BA48  token: 0x600048C
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B3BAC8  token: 0x600048D
        private System.Void _FaceToCamera() { }
        // RVA: 0x09B3B61C  token: 0x600048E
        public virtual System.Void Clear() { }
        // RVA: 0x02846010  token: 0x600048F
        public System.Void .ctor() { }
        // RVA: 0x09B3BE14  token: 0x6000490
        private static System.Void .cctor() { }
        // RVA: 0x0577D7BC  token: 0x6000491
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000A7  // size: 0x98
    public class UICountDownBar : Beyond.TickableUIMono
    {
        // Fields
        private Beyond.UI.UIText _countDownTxt;  // 0x68
        private System.Single m_countDownTime;  // 0x70
        private System.Int32 m_id;  // 0x74
        private UnityEngine.Transform m_target;  // 0x78
        private Beyond.Gameplay.Core.CountDownShowAction.Data m_data;  // 0x80
        private UnityEngine.Transform m_camera;  // 0x88
        private System.Boolean m_update;  // 0x90

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }
        System.Boolean update { get; /* RVA: 0x03D58A70 */ set; /* RVA: 0x09B3C434 */ }

        // Methods
        // RVA: 0x09B3BF68  token: 0x6000495
        public System.Void InitData(System.Int32 id, Beyond.Gameplay.Core.AbilitySystem target, Beyond.Gameplay.Core.CountDownShowAction.Data data) { }
        // RVA: 0x09B3BED8  token: 0x6000496
        public System.Void Clear() { }
        // RVA: 0x09B3C0B8  token: 0x6000497
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09B3C13C  token: 0x6000498
        private System.Void _UpdateData(System.Single deltaTime) { }
        // RVA: 0x09B3C1F8  token: 0x6000499
        private System.Void _UpdatePos() { }
        // RVA: 0x02846010  token: 0x600049A
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x600049B
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000A8  // size: 0xC8
    public class UIDoodadMineCoreScanController : Beyond.UI.UICommonScanController
    {
        // Fields
        public UnityEngine.GameObject canMineIcon;  // 0xb0
        public Beyond.UI.UIText formingText;  // 0xb8
        public Beyond.UI.UIText purityText;  // 0xc0

        // Methods
        // RVA: 0x09B3C58C  token: 0x600049C
        public System.Void SyncConditonInfo(System.Boolean forming, System.String condition) { }
        // RVA: 0x09B3C4A8  token: 0x600049D
        public System.Void SetPurity(System.Boolean forming, System.String conditionText) { }
        // RVA: 0x09B3C608  token: 0x600049E
        public System.Void UpdateUI(System.Boolean forming, System.String condition) { }
        // RVA: 0x09B3C684  token: 0x600049F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A9  // size: 0xF0
    public class UIDoodadPlantCoreScanController : Beyond.UI.UICommonScanController
    {
        // Fields
        private static System.UInt32 OFF;  // const
        private static System.UInt32 DARK;  // const
        private static System.UInt32 LIGHT;  // const
        private static System.UInt32 GROW;  // const
        public Beyond.UI.UIText coreNameText;  // 0xb0
        public Beyond.UI.UIText coreSizeText;  // 0xb8
        public UnityEngine.GameObject refreshTimeRoot;  // 0xc0
        public Beyond.UI.UIText refreshTimeText;  // 0xc8
        public System.Collections.Generic.List<UnityEngine.GameObject> flowerDark;  // 0xd0
        public System.Collections.Generic.List<UnityEngine.GameObject> flowerLight;  // 0xd8
        public System.Collections.Generic.List<UnityEngine.GameObject> flowerGrow;  // 0xe0
        private System.Single m_tickTimeSum;  // 0xe8

        // Methods
        // RVA: 0x09B3CA94  token: 0x60004A0
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B3C720  token: 0x60004A1
        public System.Void SetCoreInfo(System.String coreName, System.String coreSize) { }
        // RVA: 0x09B3C91C  token: 0x60004A2
        public System.Void SetRefreshInfo(System.Int64 nextRefreshTime) { }
        // RVA: 0x09B3C6D0  token: 0x60004A3
        public System.Void RefreshTextNow() { }
        // RVA: 0x09B3C7BC  token: 0x60004A4
        public System.Void SetQuantityInfo(System.Int32 current, System.Int32 nextRefresh, System.Int32 maxCount) { }
        // RVA: 0x09B3C98C  token: 0x60004A5
        public System.Void SetSingle(System.Int32 index, System.UInt32 state) { }
        // RVA: 0x09B3CB60  token: 0x60004A6
        private System.Void _SyncTimeText() { }
        // RVA: 0x09B3CDE0  token: 0x60004A7
        public System.Void .ctor() { }
        // RVA: 0x09B3CB58  token: 0x60004A8
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AA  // size: 0xD0
    public class UIDoodadScanController : Beyond.UI.UICommonScanController
    {
        // Fields
        public Beyond.UI.UIText timeCom;  // 0xb0
        public UnityEngine.Transform refreshFull;  // 0xb8
        public UnityEngine.Transform refreshProgress;  // 0xc0
        private System.Single m_tickTimeSum;  // 0xc8

        // Methods
        // RVA: 0x09B3CEF0  token: 0x60004A9
        public System.Void SyncRefreshInfo(System.Int64 nextRefresh, System.Single hpRatio) { }
        // RVA: 0x09B3D000  token: 0x60004AA
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B3D174  token: 0x60004AB
        private System.Void _RefreshCountDown() { }
        // RVA: 0x09B3D0C4  token: 0x60004AC
        public System.Void UpdateUI(System.Int64 nextRefresh, System.Single hpRatio) { }
        // RVA: 0x09B3D50C  token: 0x60004AD
        public System.Void .ctor() { }
        // RVA: 0x09B3CB58  token: 0x60004AE
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AB  // size: 0x28
    public class UIGeneralTracker : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform _arrowRotator;  // 0x18
        private UnityEngine.RectTransform m_rect;  // 0x20

        // Properties
        UnityEngine.RectTransform rect { get; /* RVA: 0x09B3D6E8 */ }

        // Methods
        // RVA: 0x09B3D5EC  token: 0x60004B0
        public System.Void UpdatePosition(UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound) { }
        // RVA: 0x0426FE60  token: 0x60004B1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC  // size: 0xE8
    public class UILiquidPoolScanController : Beyond.UI.UICommonScanController
    {
        // Fields
        public UnityEngine.GameObject unLimitGroup;  // 0xb0
        public UnityEngine.GameObject limitedGroup;  // 0xb8
        public Beyond.UI.UIText currentAmountText;  // 0xc0
        public Beyond.UI.UIText maxAmountText;  // 0xc8
        public Beyond.UI.UIText waterNameText;  // 0xd0
        private static System.String EMPTY_LIQUID;  // const
        private Beyond.LangKey m_key;  // 0xd8

        // Methods
        // RVA: 0x09B3EE28  token: 0x60004B2
        public System.Void SetWaterInfo(System.UInt64 waterId, System.Int32 x, System.Int32 y, System.Int32 z) { }
        // RVA: 0x09B3F388  token: 0x60004B3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD  // size: 0x70
    public class UIPanelBase : Beyond.TickableUIMono
    {
        // Fields
        public static System.String UI_SPRITE_PATH;  // const
        private Beyond.LuaResourceLoader m_loader;  // 0x68

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09B3F40C  token: 0x60004B5
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02B77AC0  token: 0x60004B6
        public UnityEngine.Sprite LoadSprite(System.String path, System.String name) { }
        // RVA: 0x0341D480  token: 0x60004B7
        public UnityEngine.Sprite LoadSpriteWithOutFormat(System.String path) { }
        // RVA: 0x02F67CF0  token: 0x60004B8
        public UnityEngine.GameObject LoadGameObject(System.String path) { }
        // RVA: 0x02B77BC0  token: 0x60004B9
        protected System.String GetSpritePath(System.String path, System.String name) { }
        // RVA: 0x02845F80  token: 0x60004BA
        public System.Void .ctor() { }
        // RVA: 0x0577D7B4  token: 0x60004BB
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000AE  // size: 0xB8
    public class UIPowerPoleAutoConnectTracker : Beyond.UI.UIGeneralTracker
    {
        // Fields
        private UnityEngine.GameObject _rootDistance;  // 0x28
        private Beyond.UI.UIText _textDistance;  // 0x30
        private UnityEngine.Color _textColorNormal;  // 0x38
        private UnityEngine.Color _textColorDisable;  // 0x48
        private UnityEngine.Color _textColorError;  // 0x58
        private UnityEngine.CanvasGroup _colorScaleControlGroup;  // 0x68
        private System.Single _activeScale;  // 0x70
        private Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup _defaultIcon;  // 0x78
        private Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup _diffuserIcon;  // 0x80
        private Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup _hubIcon;  // 0x88
        private Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup _subhubIcon;  // 0x90
        private Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup _terminalIcon;  // 0x98
        private Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup _stationIcon;  // 0xa0
        private Beyond.UI.UIPowerPoleAutoConnectTracker.StatusHintGroup _statusHintGroup;  // 0xa8
        private System.Nullable<Beyond.Gameplay.Factory.PowerAutoConnectStatus> m_currentStatus;  // 0xb0

        // Methods
        // RVA: 0x09B3F470  token: 0x60004BC
        public System.Void UpdateDistance(System.Single distance) { }
        // RVA: 0x09B3F7A4  token: 0x60004BD
        private System.Void _ActualUpdateStatus(Beyond.Gameplay.Factory.PowerAutoConnectStatus status) { }
        // RVA: 0x09B3F600  token: 0x60004BE
        public System.Void UpdateStatus(Beyond.Gameplay.Factory.PowerAutoConnectStatus status) { }
        // RVA: 0x09B3F6A8  token: 0x60004BF
        private System.Void _ActualUpdateIcon(Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup img) { }
        // RVA: 0x09B3F53C  token: 0x60004C0
        public System.Void UpdateNodeType(System.Int32 nodeType) { }
        // RVA: 0x09B3F9FC  token: 0x60004C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1  // size: 0x158
    public class UIPowerPoleFastTravelTracker : Beyond.UI.UIGeneralTracker
    {
        // Fields
        private Beyond.UI.UIText _textDistance;  // 0x28
        private UnityEngine.Color _textColorNormal;  // 0x30
        private UnityEngine.Color _textColorWarning;  // 0x40
        private UnityEngine.Color _textColorHighlighted;  // 0x50
        private UnityEngine.Color _textColorDisabled;  // 0x60
        private UnityEngine.GameObject _parentNormal;  // 0x70
        private Beyond.UI.UIAnimationWrapper _animationWrapperNormal;  // 0x78
        private UnityEngine.GameObject _imageNormal;  // 0x80
        private UnityEngine.GameObject _imageNormalOther;  // 0x88
        private UnityEngine.GameObject _imageWarning;  // 0x90
        private UnityEngine.GameObject _imageHighlighted;  // 0x98
        private UnityEngine.GameObject _imageHighlightedOther;  // 0xa0
        private UnityEngine.GameObject _imageDisabled;  // 0xa8
        private UnityEngine.GameObject _parentUpgraded;  // 0xb0
        private Beyond.UI.UIAnimationWrapper _animationWrapperUpgraded;  // 0xb8
        private UnityEngine.GameObject _imageNormalUpgraded;  // 0xc0
        private UnityEngine.GameObject _imageNormalUpgradedOther;  // 0xc8
        private UnityEngine.GameObject _imageWarningUpgraded;  // 0xd0
        private UnityEngine.GameObject _imageHighlightedUpgraded;  // 0xd8
        private UnityEngine.GameObject _imageHighlightedUpgradedOther;  // 0xe0
        private UnityEngine.GameObject _imageDisabledUpgraded;  // 0xe8
        private UnityEngine.GameObject _parentDefaultNext;  // 0xf0
        private Beyond.UI.UIAnimationWrapper _animationWrapperNext;  // 0xf8
        private UnityEngine.GameObject _imageNormalDefaultNext;  // 0x100
        private UnityEngine.GameObject _imageNormalDefaultNextOther;  // 0x108
        private UnityEngine.GameObject _imageWarningDefaultNext;  // 0x110
        private UnityEngine.GameObject _imageHighlightedDefaultNext;  // 0x118
        private UnityEngine.GameObject _imageHighlightedDefaultNextOther;  // 0x120
        private UnityEngine.GameObject _imageDisabledDefaultNext;  // 0x128
        private UnityEngine.GameObject _textInfoBg;  // 0x130
        private Beyond.SerializeFieldDictionary<Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus,Beyond.UI.UIPowerPoleFastTravelTracker.TravelPoleStatusSetting> _statusSettingDict;  // 0x138
        private Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon m_iconStatus;  // 0x140
        private Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus m_status;  // 0x144
        private System.Boolean m_isHighlighted;  // 0x148
        private System.Boolean m_isOtherSocial;  // 0x149
        private System.String m_distanceFormatText;  // 0x150

        // Properties
        System.Boolean isWarning { get; /* RVA: 0x09B4090C */ }
        System.Boolean isDisabled { get; /* RVA: 0x09B40898 */ }
        System.Boolean allowToHighlight { get; /* RVA: 0x09B404F0 */ }
        Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon iconStatus { get; /* RVA: 0x011B8720 */ set; /* RVA: 0x09B40924 */ }
        Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus status { get; /* RVA: 0x03D76300 */ set; /* RVA: 0x09B409C4 */ }
        Beyond.UI.UIAnimationWrapper animationWrapper { get; /* RVA: 0x09B4051C */ }
        UnityEngine.GameObject imageNormal { get; /* RVA: 0x09B40798 */ }
        UnityEngine.GameObject imageWarning { get; /* RVA: 0x09B40818 */ }
        UnityEngine.GameObject imageDisabled { get; /* RVA: 0x09B40598 */ }
        UnityEngine.GameObject imageHighlighted { get; /* RVA: 0x09B40698 */ }
        UnityEngine.GameObject imageNormalOther { get; /* RVA: 0x09B40718 */ }
        UnityEngine.GameObject imageHighlightedOther { get; /* RVA: 0x09B40618 */ }

        // Methods
        // RVA: 0x09B3FAB8  token: 0x60004D6
        public System.Void PlayFocus() { }
        // RVA: 0x09B3FC34  token: 0x60004D7
        public System.Void UpdateIconStatus(Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon value) { }
        // RVA: 0x09B3FD60  token: 0x60004D8
        public System.Void UpdateStatus(Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus value) { }
        // RVA: 0x09B3FC98  token: 0x60004D9
        public System.Void UpdateIsHighlighted(System.Boolean value) { }
        // RVA: 0x09B3FCFC  token: 0x60004DA
        public System.Void UpdateIsOtherSocial(System.Boolean value) { }
        // RVA: 0x09B3FB20  token: 0x60004DB
        public System.Void UpdateDistance(UnityEngine.Vector3 value) { }
        // RVA: 0x09B3FDC4  token: 0x60004DC
        private System.Void _OnStatusChanged() { }
        // RVA: 0x09B4004C  token: 0x60004DD
        private System.Void _UpdateIcon() { }
        // RVA: 0x09B3FA58  token: 0x60004DE
        private System.Void OnEnable() { }
        // RVA: 0x09B40488  token: 0x60004DF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3  // size: 0xC8
    public class UIRaceModuleRankController : Beyond.TickableUIMono
    {
        // Fields
        private readonly Beyond.LuaResourceLoader m_loader;  // 0x68
        public Beyond.UI.UIImage image;  // 0x70
        public UnityEngine.Transform greyNode;  // 0x78
        public UnityEngine.Transform lightNode;  // 0x80
        public Beyond.UI.UIText text;  // 0x88
        public static System.String FIRST_ICON;  // const
        public static System.String SECOND_ICON;  // const
        public static System.String THIRD_ICON;  // const
        public static System.String FOURTH_ICON;  // const
        public static System.String FIFTH_ICON;  // const
        private UnityEngine.Sprite m_sprite1;  // 0x90
        private UnityEngine.Sprite m_sprite2;  // 0x98
        private UnityEngine.Sprite m_sprite3;  // 0xa0
        private UnityEngine.Sprite m_sprite4;  // 0xa8
        private UnityEngine.Sprite m_sprite5;  // 0xb0
        private Beyond.UI.UIRaceModuleRankController.ERank m_rankEnum;  // 0xb8
        private System.Single m_restTime;  // 0xbc
        private System.Boolean m_begin;  // 0xc0

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x09B41164  token: 0x60004E1
        private System.Void _ResetData() { }
        // RVA: 0x09B409DC  token: 0x60004E2
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B40B10  token: 0x60004E3
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B411C4  token: 0x60004E4
        private System.Void _ShowBaseTrans(System.Boolean show) { }
        // RVA: 0x09B40F04  token: 0x60004E5
        private System.Void _LoadAllSprite() { }
        // RVA: 0x09B41280  token: 0x60004E6
        private System.Void _UpdateRaceModuleRank(Beyond.EventData<System.Int32,System.Single>& rankData) { }
        // RVA: 0x09B40C48  token: 0x60004E7
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B4141C  token: 0x60004E8
        public System.Void .ctor() { }
        // RVA: 0x058E2A30  token: 0x60004E9
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x0577D7B4  token: 0x60004EA
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0577D7BC  token: 0x60004EB
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000B5  // size: 0x38
    public class UIVideoHelper : UnityEngine.MonoBehaviour
    {
        // Fields
        public CriWare.CriManaMovieControllerForUI criMovieController;  // 0x18
        public System.String videoPath;  // 0x20
        public System.Boolean restartOnEnable;  // 0x28
        private Beyond.UI.UIImage m_image;  // 0x30

        // Methods
        // RVA: 0x09B4219C  token: 0x60004EC
        private System.Void Reset() { }
        // RVA: 0x09B42120  token: 0x60004ED
        public System.Void ResetVideo() { }
        // RVA: 0x09B41FF0  token: 0x60004EE
        private System.Void Awake() { }
        // RVA: 0x09B420B8  token: 0x60004EF
        private System.Void OnEnable() { }
        // RVA: 0x09B4221C  token: 0x60004F0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6  // size: 0x130
    public class UIWaterDroneBar : Beyond.TickableUIMono
    {
        // Fields
        public Beyond.Gameplay.MountPoint mountPoint;  // 0x68
        public UnityEngine.Transform waterDroneBarParent;  // 0x70
        public UnityEngine.Vector3 waterDroneBarLocalOffset;  // 0x78
        public System.Single smoothTime;  // 0x84
        public Beyond.UI.UISlider slider;  // 0x88
        private Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> m_waterDronePtr;  // 0x90
        private UnityEngine.Transform _waterDroneTrans;  // 0xa0
        private UnityEngine.Vector3 m_smoothVelocity;  // 0xa8
        public Beyond.UI.UIState.UIStateController waterStateController;  // 0xb8
        public Beyond.UI.UIState.UIStateController iconStateController;  // 0xc0
        private static readonly Unity.Profiling.ProfilerMarker PROFILER_MARKER_UPDATE;  // static @ 0x0
        public static System.Single SLIDER_MAX_VALUE;  // const
        public Beyond.UI.UIAnimationWrapper uiAnimationWrapper;  // 0xc8
        private UnityEngine.Animation _animation;  // 0xd0
        private UnityEngine.AnimationClip _switchStateClip;  // 0xd8
        private UnityEngine.AnimationClip _farLoopClip;  // 0xe0
        private UnityEngine.AnimationClip _emptyLoopClip;  // 0xe8
        private System.String m_switchStateClipName;  // 0xf0
        private System.String m_farLoopClipName;  // 0xf8
        private System.String m_emptyLoopClipName;  // 0x100
        private System.Single _clampedYawAngle;  // 0x108
        private System.Single _clampedPitchAngle;  // 0x10c
        private System.Collections.Generic.List<System.String> _hydrantTemplateIds;  // 0x110
        private System.Collections.Generic.List<System.String> _tankTemplateIds;  // 0x118
        private System.Boolean m_isInfinityLiquid;  // 0x120
        private System.Boolean m_isBagEmpty;  // 0x121
        private System.Boolean m_noRemainLiquid;  // 0x122
        private System.Boolean m_isBagEmptyAndNoRemainLiquid;  // 0x123
        private System.Int32 m_stateChangeFrame;  // 0x124
        private System.Boolean m_stateDirty;  // 0x128
        private System.Boolean m_isPlayingFarLoop;  // 0x129

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x09B4280C  token: 0x60004F2
        protected virtual System.Void OnAwake() { }
        // RVA: 0x09B43564  token: 0x60004F3
        private System.Void _OnWaterDroneInfinityLiquidChanged(Beyond.EventData<System.Boolean>& data) { }
        // RVA: 0x09B433E4  token: 0x60004F4
        private System.Void _OnWaterDroneEmptyChanged(Beyond.EventData<System.Boolean>& data) { }
        // RVA: 0x09B435D0  token: 0x60004F5
        private System.Void _OnWaterDroneInteractiveChanged(Beyond.EventData<System.String>& data) { }
        // RVA: 0x09B436B0  token: 0x60004F6
        private System.Void _OnWaterDroneSourceTypeChanged(Beyond.EventData<Beyond.Gameplay.WaterDroneSourceType>& data) { }
        // RVA: 0x09B4363C  token: 0x60004F7
        private System.Void _OnWaterDroneRelaxChanged(Beyond.EventData<System.Boolean>& data) { }
        // RVA: 0x09B43500  token: 0x60004F8
        private System.Void _OnWaterDroneHydrantStateChanged(Beyond.EventData<Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState>& data) { }
        // RVA: 0x09B43450  token: 0x60004F9
        private System.Void _OnWaterDroneHydrantStateChanged(Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState state) { }
        // RVA: 0x09B42D60  token: 0x60004FA
        protected virtual System.Void OnEnable() { }
        // RVA: 0x09B42EA0  token: 0x60004FB
        protected virtual System.Void OnRelease() { }
        // RVA: 0x09B43294  token: 0x60004FC
        private System.Void _OnWaterDroneChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> waterDronePtr) { }
        // RVA: 0x09B4320C  token: 0x60004FD
        private System.Void _ClearWaterDrone() { }
        // RVA: 0x09B42268  token: 0x60004FE
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x09B4387C  token: 0x60004FF
        private System.Void _UpdateState() { }
        // RVA: 0x09B4371C  token: 0x6000500
        private System.Void _SetIconStateController(System.String stateName) { }
        // RVA: 0x09B437C8  token: 0x6000501
        private System.Void _UpdateSlider() { }
        // RVA: 0x03D02FE0  token: 0x6000502
        public System.Void .ctor() { }
        // RVA: 0x03D06AD0  token: 0x6000503
        private static System.Void .cctor() { }
        // RVA: 0x058E2A30  token: 0x6000504
        public System.Void <>iFixBaseProxy_OnAwake() { }
        // RVA: 0x058DD8AC  token: 0x6000505
        public System.Void <>iFixBaseProxy_OnEnable() { }
        // RVA: 0x0577D7B4  token: 0x6000506
        public System.Void <>iFixBaseProxy_OnRelease() { }
        // RVA: 0x0589E548  token: 0x6000507
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000B7  // size: 0x28
    public class WaterDroneJoystickCtrl : UnityEngine.MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIJoystick _joystick;  // 0x18
        public System.Single cameraInputScaleX;  // 0x20
        public System.Single cameraInputScaleY;  // 0x24

        // Methods
        // RVA: 0x03D4CC10  token: 0x6000508
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8  // size: 0xC0
    public class WorldUIController : Beyond.TickableMono
    {
        // Fields
        private System.UInt64 <entityLogicId>k__BackingField;  // 0x68
        protected UnityEngine.Transform m_camera;  // 0x70
        protected Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> m_entity;  // 0x78
        protected UnityEngine.Vector3 m_parentPos;  // 0x88
        protected Beyond.Gameplay.Core.InteractiveLogicController m_logicController;  // 0x98
        protected UnityEngine.GameObject m_postModel;  // 0xa0
        protected Beyond.Gameplay.Core.InteractiveLogicBaseComponent m_logicBaseComponent;  // 0xa8
        protected System.UInt64 m_id;  // 0xb0
        protected System.Int32 m_typeSegment;  // 0xb8
        protected System.Boolean m_uiActive;  // 0xbc

        // Properties
        System.UInt64 entityLogicId { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x03D4F040 */ }
        Beyond.TickType tickOption { get; /* RVA: 0x03D55800 */ }
        System.Boolean uiActive { get; /* RVA: 0x03D5B230 */ set; /* RVA: 0x09B4B2D0 */ }

        // Methods
        // RVA: 0x09B4AEE4  token: 0x600050E
        public virtual System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment) { }
        // RVA: 0x09B4B204  token: 0x600050F
        public virtual System.Void TryGetNeedComponent() { }
        // RVA: 0x09B4B0A4  token: 0x6000510
        public virtual System.Void SetPos() { }
        // RVA: 0x09B4B0E8  token: 0x6000511
        public virtual System.Void SetUIForward() { }
        // RVA: 0x09B4B180  token: 0x6000512
        public virtual System.Void Tick(System.Single deltaTime) { }
        // RVA: 0x09B4B12C  token: 0x6000513
        public virtual System.Void TickUI(System.Single deltaTime) { }
        // RVA: 0x09B4AE8C  token: 0x6000514
        public virtual System.Void Clear() { }
        // RVA: 0x09B4B044  token: 0x6000515
        protected virtual System.Void OnRelease() { }
        // RVA: 0x02846010  token: 0x6000516
        public System.Void .ctor() { }
        // RVA: 0x0577D7BC  token: 0x6000517
        public System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        // RVA: 0x0577D7B4  token: 0x6000518
        public System.Void <>iFixBaseProxy_OnRelease() { }

    }

}

namespace Beyond.UI.Mission
{

    // TypeToken: 0x20000B9  // size: 0x98
    public class MissionHudBGSizeUpdater : Beyond.TickableUIMono
    {
        // Fields
        public UnityEngine.RectTransform bgTransform;  // 0x68
        public UnityEngine.RectTransform objectiveList;  // 0x70
        public UnityEngine.RectTransform objectiveContent;  // 0x78
        public UnityEngine.RectTransform leftLayoutTransform;  // 0x80
        public UnityEngine.UI.VerticalLayoutGroup leftNodeVerticalLayoutGroup;  // 0x88
        public System.Single bgSizeGetterDeltaY;  // 0x90

        // Properties
        Beyond.TickType tickOption { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x024A53A0  token: 0x600051A
        public virtual System.Void LateTick(System.Single deltaTime) { }
        // RVA: 0x024A5BC0  token: 0x600051B
        public System.Void UpdateBgSize() { }
        // RVA: 0x03D4B8C0  token: 0x600051C
        public System.Void .ctor() { }
        // RVA: 0x0589E548  token: 0x600051D
        public System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000004  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000012
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x20000BC  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x600051E
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x051624BC  token: 0x600051F
        public System.Void __Gen_Wrap_0() { }
        // RVA: 0x050F0008  token: 0x6000520
        public System.Void __Gen_Wrap_1(System.Object P0, System.Single P1) { }
        // RVA: 0x05163BA0  token: 0x6000521
        public System.Void __Gen_Wrap_2(System.Object P0, System.Object P1) { }
        // RVA: 0x04274234  token: 0x6000522
        public System.Void __Gen_Wrap_3(System.Object P0) { }
        // RVA: 0x09B48338  token: 0x6000523
        public System.Void __Gen_Wrap_4(System.Object P0, Beyond.EventData<System.Int32,System.Single,System.Single>& P1) { }
        // RVA: 0x09B48AC0  token: 0x6000524
        public Beyond.UI.DamageTextBase __Gen_Wrap_5(System.Object P0, Beyond.UI.DamageTextType P1) { }
        // RVA: 0x0516413C  token: 0x6000525
        public System.Void __Gen_Wrap_6(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x0549D548  token: 0x6000526
        public System.Void __Gen_Wrap_7(System.Object P0, System.Int32 P1) { }
        // RVA: 0x09B4A3E8  token: 0x6000527
        public System.Void __Gen_Wrap_8(System.Object P0, UnityEngine.Color P1) { }
        // RVA: 0x09B4ACB8  token: 0x6000528
        public System.Void __Gen_Wrap_9(System.Object P0, System.Object P1, System.Object P2, System.Nullable<UnityEngine.Vector3> P3) { }
        // RVA: 0x09B442DC  token: 0x6000529
        public System.Void __Gen_Wrap_10(System.Object P0, UnityEngine.Vector2 P1) { }
        // RVA: 0x09B44814  token: 0x600052A
        public UnityEngine.Vector3 __Gen_Wrap_11(System.Object P0) { }
        // RVA: 0x05477860  token: 0x600052B
        public System.Void __Gen_Wrap_12(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09B45908  token: 0x600052C
        public UnityEngine.Vector2 __Gen_Wrap_13(System.Object P0, System.Single P1, System.Single P2) { }
        // RVA: 0x09B45FD0  token: 0x600052D
        public System.Boolean __Gen_Wrap_14(System.Object P0, UnityEngine.Vector3 P1) { }
        // RVA: 0x09B46528  token: 0x600052E
        public System.Void __Gen_Wrap_15(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& P1) { }
        // RVA: 0x05610058  token: 0x600052F
        public System.Void __Gen_Wrap_16(System.Object P0, Beyond.GEnums.EnergyShardType P1, System.Boolean P2) { }
        // RVA: 0x09B466C4  token: 0x6000530
        public System.Void __Gen_Wrap_17(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String,Beyond.GEnums.EnergyShardType>& P1) { }
        // RVA: 0x09B467E8  token: 0x6000531
        public System.Void __Gen_Wrap_18(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String>& P1) { }
        // RVA: 0x09B4690C  token: 0x6000532
        public System.Void __Gen_Wrap_19(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,Beyond.Gameplay.Core.AbilitySystemForEnemyPart,Beyond.Gameplay.PhysicalInflictionType>& P1) { }
        // RVA: 0x09B46A28  token: 0x6000533
        public System.Void __Gen_Wrap_20(System.Object P0, Beyond.EventData<System.Boolean>& P1) { }
        // RVA: 0x09B46B3C  token: 0x6000534
        public System.Void __Gen_Wrap_21(System.Object P0, Beyond.EventData<UnityEngine.Vector3,System.String,UnityEngine.Color>& P1) { }
        // RVA: 0x09B46C60  token: 0x6000535
        public System.Void __Gen_Wrap_22(System.Object P0, Beyond.EventData<System.UInt64,System.Int32>& P1) { }
        // RVA: 0x05150B1C  token: 0x6000536
        public System.Void __Gen_Wrap_23(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B46D84  token: 0x6000537
        public Beyond.UI.DamageTextBaseV2 __Gen_Wrap_24(System.Object P0, Beyond.UI.DamageTextType P1, System.Object P2) { }
        // RVA: 0x09B46EA8  token: 0x6000538
        public UnityEngine.Vector2 __Gen_Wrap_25(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3, UnityEngine.Vector3 P4) { }
        // RVA: 0x09B4700C  token: 0x6000539
        public System.Void __Gen_Wrap_26(System.Object P0, UnityEngine.Vector2 P1, System.Single P2) { }
        // RVA: 0x09B4713C  token: 0x600053A
        public Beyond.UI.HeadBarCtrl.HeadBarType __Gen_Wrap_27(Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> P0) { }
        // RVA: 0x05E7B3B0  token: 0x600053B
        public System.Void __Gen_Wrap_28(System.Object P0, System.Object P1, System.Single P2) { }
        // RVA: 0x05E6E454  token: 0x600053C
        public System.Void __Gen_Wrap_29(System.Object P0, System.Object P1, System.Double P2) { }
        // RVA: 0x09B47244  token: 0x600053D
        public System.Void __Gen_Wrap_30(System.Object P0, Beyond.Gameplay.Core.AbilitySystem.Modifier& P1) { }
        // RVA: 0x0549D548  token: 0x600053E
        public System.Void __Gen_Wrap_31(System.Object P0, Beyond.UI.HeadBarCtrl.HeadBarRefreshReason P1) { }
        // RVA: 0x09B473FC  token: 0x600053F
        public System.Void __Gen_Wrap_32(System.Object P0, Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& P1) { }
        // RVA: 0x09B4750C  token: 0x6000540
        public System.Void __Gen_Wrap_33(System.Object P0, Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& P1) { }
        // RVA: 0x09B47624  token: 0x6000541
        public System.Void __Gen_Wrap_34(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem>& P1) { }
        // RVA: 0x09B4773C  token: 0x6000542
        public System.Void __Gen_Wrap_35(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& P1) { }
        // RVA: 0x09B47860  token: 0x6000543
        public System.Void __Gen_Wrap_36(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystemForEnemyPart,System.Boolean>& P1) { }
        // RVA: 0x09B47970  token: 0x6000544
        public System.Boolean __Gen_Wrap_37(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1) { }
        // RVA: 0x05152714  token: 0x6000545
        public Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle __Gen_Wrap_38(System.Object P0, System.Object P1) { }
        // RVA: 0x09B47A90  token: 0x6000546
        public System.Void __Gen_Wrap_39(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1) { }
        // RVA: 0x050EE850  token: 0x6000547
        public System.Void __Gen_Wrap_40(UnityEngine.Sprite P0) { }
        // RVA: 0x09B47BA4  token: 0x6000548
        public System.Void __Gen_Wrap_41(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Object P2, System.Object P3) { }
        // RVA: 0x05477648  token: 0x6000549
        public System.Void __Gen_Wrap_42(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x09B47CE0  token: 0x600054A
        public Beyond.UI.UIBuffCell __Gen_Wrap_43(System.Object P0, System.Object P1) { }
        // RVA: 0x09B47DEC  token: 0x600054B
        public System.Void __Gen_Wrap_44(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Boolean P2) { }
        // RVA: 0x09B47F18  token: 0x600054C
        public System.Nullable<UnityEngine.Vector3> __Gen_Wrap_45(System.Object P0) { }
        // RVA: 0x09B48024  token: 0x600054D
        public Beyond.UI.UIPoiseKnot __Gen_Wrap_46(System.Object P0) { }
        // RVA: 0x0514EF5C  token: 0x600054E
        public System.Boolean __Gen_Wrap_47(System.Object P0) { }
        // RVA: 0x09B48100  token: 0x600054F
        public System.Void __Gen_Wrap_48(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, System.Object P4) { }
        // RVA: 0x09B4820C  token: 0x6000550
        public System.Void __Gen_Wrap_49(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, Beyond.Gameplay.Core.Buff.FinishReason P2) { }
        // RVA: 0x09B48454  token: 0x6000551
        public System.Void __Gen_Wrap_50(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Boolean P2, Beyond.Gameplay.Core.Buff.FinishReason P3) { }
        // RVA: 0x09B48590  token: 0x6000552
        public System.Void __Gen_Wrap_51(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> P1) { }
        // RVA: 0x09B486A4  token: 0x6000553
        public System.Void __Gen_Wrap_52(System.Object P0, System.Double P1) { }
        // RVA: 0x056239AC  token: 0x6000554
        public System.Void __Gen_Wrap_53(System.Object P0, System.Object P1, System.Single P2, System.Boolean P3) { }
        // RVA: 0x086FA5D4  token: 0x6000555
        public System.Void __Gen_Wrap_54(System.Object P0, System.Object P1, System.Boolean P2, System.Int32 P3) { }
        // RVA: 0x056277FC  token: 0x6000556
        public System.Void __Gen_Wrap_55(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x09B48770  token: 0x6000557
        public UnityEngine.Vector3 __Gen_Wrap_56(System.Object P0, System.Object P1) { }
        // RVA: 0x09B48890  token: 0x6000558
        public System.Void __Gen_Wrap_57(System.Object P0, UnityEngine.Vector3 P1) { }
        // RVA: 0x05477648  token: 0x6000559
        public System.Void __Gen_Wrap_58(System.Object P0, Beyond.UI.UIHeadLabel.VisibleSource P1, System.Boolean P2) { }
        // RVA: 0x09B489AC  token: 0x600055A
        public System.Void __Gen_Wrap_59(System.Object P0, Beyond.UI.UIHeadLabel.HeadLabelType P1, Beyond.UI.UIHeadLabel.VisibleSource P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x09B48BB8  token: 0x600055B
        public System.Void __Gen_Wrap_60(System.Object P0, Beyond.EventData<System.String>& P1) { }
        // RVA: 0x050F0C14  token: 0x600055C
        public System.Void __Gen_Wrap_61(System.Boolean P0) { }
        // RVA: 0x05E5ABBC  token: 0x600055D
        public System.Void __Gen_Wrap_62(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x09B48CDC  token: 0x600055E
        public System.String __Gen_Wrap_63(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B48E04  token: 0x600055F
        public UnityEngine.Sprite __Gen_Wrap_64(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B48F2C  token: 0x6000560
        public System.Void __Gen_Wrap_65(System.Object P0, Beyond.EventData<System.Single>& P1) { }
        // RVA: 0x054794D8  token: 0x6000561
        public System.Void __Gen_Wrap_66(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3) { }
        // RVA: 0x09B49044  token: 0x6000562
        public UnityEngine.GameObject __Gen_Wrap_67(System.Object P0, System.Object P1) { }
        // RVA: 0x09B49150  token: 0x6000563
        public System.Void __Gen_Wrap_68(System.Object P0, Beyond.EventData<System.Int32>& P1) { }
        // RVA: 0x05E3DBF4  token: 0x6000564
        public System.Void __Gen_Wrap_69(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x09B49264  token: 0x6000565
        public System.Void __Gen_Wrap_70(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String>& P1) { }
        // RVA: 0x09B49388  token: 0x6000566
        public System.Void __Gen_Wrap_71(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String,Beyond.Gameplay.Core.GlobalBuff.FinishReason>& P1) { }
        // RVA: 0x054790D0  token: 0x6000567
        public System.Void __Gen_Wrap_72(System.Object P0, System.Object P1, System.Boolean P2) { }
        // RVA: 0x09B494A4  token: 0x6000568
        public System.Void __Gen_Wrap_73(System.Object P0, System.Nullable<Beyond.GEnums.SpellInflictionOnCharType> P1) { }
        // RVA: 0x09B495B4  token: 0x6000569
        public Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> __Gen_Wrap_74(System.Object P0, System.Object P1) { }
        // RVA: 0x09B496D4  token: 0x600056A
        public Beyond.UI.UICharPassiveBase __Gen_Wrap_75(System.Object P0, System.Object P1) { }
        // RVA: 0x09B497E0  token: 0x600056B
        public System.Void __Gen_Wrap_76(System.Object P0, Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& P1) { }
        // RVA: 0x09B498FC  token: 0x600056C
        public Beyond.UI.OutOfScreenTargetsCtrl.Arrow __Gen_Wrap_77(System.Object P0) { }
        // RVA: 0x09B499EC  token: 0x600056D
        public System.ValueTuple<UnityEngine.Vector2,System.Single> __Gen_Wrap_78(System.Object P0, UnityEngine.Vector3 P1) { }
        // RVA: 0x09B49B48  token: 0x600056E
        public System.Void __Gen_Wrap_79(System.Object P0, Beyond.EventData<System.UInt64,System.UInt32>& P1) { }
        // RVA: 0x09B49C58  token: 0x600056F
        public System.Void __Gen_Wrap_80(System.Object P0, Beyond.EventData<System.UInt64,System.String>& P1) { }
        // RVA: 0x09B49D68  token: 0x6000570
        public System.Void __Gen_Wrap_81(System.Object P0, Beyond.EventData<System.UInt64,System.String,System.Int32>& P1) { }
        // RVA: 0x09B49E84  token: 0x6000571
        public UnityEngine.Sprite __Gen_Wrap_82(System.Object P0, System.Object P1) { }
        // RVA: 0x056214F0  token: 0x6000572
        public System.Void __Gen_Wrap_83(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x086E71DC  token: 0x6000573
        public System.Boolean __Gen_Wrap_84(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09B49F7C  token: 0x6000574
        public System.Void __Gen_Wrap_85(System.Object P0, Beyond.EventData<System.UInt64,System.String,Beyond.GEnums.EnergyShardType>& P1) { }
        // RVA: 0x09B4A098  token: 0x6000575
        public System.Void __Gen_Wrap_86(System.Object P0, Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& P1) { }
        // RVA: 0x09B4A1AC  token: 0x6000576
        public System.Void __Gen_Wrap_87(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.CinematicTimelineManagerBase.TimelineHandle>& P1) { }
        // RVA: 0x09B4A2C4  token: 0x6000577
        public System.Void __Gen_Wrap_88(System.Object P0, Beyond.EventData<Beyond.Gameplay.ForbidType,System.Boolean>& P1) { }
        // RVA: 0x087040F0  token: 0x6000578
        public System.Void __Gen_Wrap_89(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x09B4A4E8  token: 0x6000579
        public System.Void __Gen_Wrap_90(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte P3) { }
        // RVA: 0x09B4A5E0  token: 0x600057A
        public System.Void __Gen_Wrap_91(System.Object P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Byte P5) { }
        // RVA: 0x09B4A6F4  token: 0x600057B
        public System.Byte __Gen_Wrap_92(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte& P3) { }
        // RVA: 0x0560138C  token: 0x600057C
        public System.Void __Gen_Wrap_93(System.Object P0, Beyond.Gameplay.CommonTrackingPointStyleType P1, System.Object P2) { }
        // RVA: 0x0549D548  token: 0x600057D
        public System.Void __Gen_Wrap_94(System.Object P0, Beyond.Gameplay.CommonTrackingPointStyleType P1) { }
        // RVA: 0x09B4A81C  token: 0x600057E
        public System.Void __Gen_Wrap_95(System.Object P0, UnityEngine.Vector2 P1, System.Single P2, System.Boolean P3, System.Single P4, System.Boolean P5) { }
        // RVA: 0x09B4A968  token: 0x600057F
        public System.Void __Gen_Wrap_96(System.Object P0, Beyond.Gameplay.PosValueState P1, System.Boolean P2, UnityEngine.Vector2 P3, System.Single P4, System.Boolean P5, System.Single P6, Beyond.Gameplay.CommonTrackMapTier P7) { }
        // RVA: 0x050EF354  token: 0x6000580
        public System.Int32 __Gen_Wrap_97(System.Object P0, System.Object P1) { }
        // RVA: 0x09B4AAD4  token: 0x6000581
        public Beyond.UI.CommonTrackerUpdate.CommonTrackerItem __Gen_Wrap_98(System.Object P0) { }
        // RVA: 0x09B4ABB0  token: 0x6000582
        public System.Boolean __Gen_Wrap_99(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3) { }
        // RVA: 0x0872224C  token: 0x6000583
        public System.Void __Gen_Wrap_100(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        // RVA: 0x09B43BA0  token: 0x6000584
        public System.Void __Gen_Wrap_101(System.Object P0, System.Object P1, System.Object P2, System.UInt64 P3, System.Int32 P4) { }
        // RVA: 0x09B43CAC  token: 0x6000585
        public System.String __Gen_Wrap_102(System.Object P0, Beyond.LangKey P1, System.Object P2) { }
        // RVA: 0x055FFD60  token: 0x6000586
        public System.Void __Gen_Wrap_103(System.Object P0, Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState P1) { }
        // RVA: 0x09B43DE8  token: 0x6000587
        public System.Void __Gen_Wrap_104(System.Object P0, System.Single& P1, System.Single& P2) { }
        // RVA: 0x09B43F1C  token: 0x6000588
        public System.String[] __Gen_Wrap_105() { }
        // RVA: 0x09B43FD4  token: 0x6000589
        public System.Boolean __Gen_Wrap_106(System.Object P0, System.UInt64 P1) { }
        // RVA: 0x09B440AC  token: 0x600058A
        public UnityEngine.GameObject __Gen_Wrap_107(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B441C0  token: 0x600058B
        public System.Void __Gen_Wrap_108(System.Object P0, System.Object P1, UnityEngine.Color P2) { }
        // RVA: 0x056106A4  token: 0x600058C
        public System.UInt32 __Gen_Wrap_109(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x09B443E4  token: 0x600058D
        public System.Void __Gen_Wrap_110(System.Object P0, System.UInt32 P1, System.Object P2, System.Object P3) { }
        // RVA: 0x09B444DC  token: 0x600058E
        public System.Void __Gen_Wrap_111(System.Object P0, System.UInt32 P1, System.Object P2, System.Boolean P3, System.Object P4) { }
        // RVA: 0x09B445E8  token: 0x600058F
        public System.Void __Gen_Wrap_112(System.Object P0, System.UInt32 P1, UnityEngine.Color P2) { }
        // RVA: 0x09B44704  token: 0x6000590
        public System.Void __Gen_Wrap_113(System.Object P0, System.Boolean P1, System.Single P2, System.Object P3, System.Object P4) { }
        // RVA: 0x0870BD64  token: 0x6000591
        public System.Void __Gen_Wrap_114(System.Object P0, System.Single P1, System.Boolean P2) { }
        // RVA: 0x050EE850  token: 0x6000592
        public System.Void __Gen_Wrap_115(UnityEngine.EventSystems.PointerEventData P0) { }
        // RVA: 0x050F0B68  token: 0x6000593
        public System.Void __Gen_Wrap_116(System.Single P0) { }
        // RVA: 0x054873B8  token: 0x6000594
        public System.Void __Gen_Wrap_117(System.Object P0, System.Single P1, System.Single P2, System.Single P3, System.Boolean P4) { }
        // RVA: 0x054A1120  token: 0x6000595
        public System.Void __Gen_Wrap_118(System.Object P0, System.Single P1, System.Single P2) { }
        // RVA: 0x09AFB88C  token: 0x6000596
        public System.Void __Gen_Wrap_119(System.Object P0, System.Single P1, System.Single P2, System.Object P3) { }
        // RVA: 0x09B44928  token: 0x6000597
        public System.Void __Gen_Wrap_120(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState P4) { }
        // RVA: 0x09B44A34  token: 0x6000598
        public System.Collections.Generic.Dictionary<System.String,Beyond.UI.RegionMap3DCfg> __Gen_Wrap_121(System.Object P0) { }
        // RVA: 0x09B44B24  token: 0x6000599
        public System.Void __Gen_Wrap_122(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, System.Object P3) { }
        // RVA: 0x09B44C58  token: 0x600059A
        public System.Boolean __Gen_Wrap_123(UnityEngine.Vector2 P0, System.Single P1, UnityEngine.Rect P2) { }
        // RVA: 0x09B44DA8  token: 0x600059B
        public System.Void __Gen_Wrap_124(System.Object P0, Beyond.UI.RegionMapShowType P1, System.Object P2, System.Object P3, System.Single P4) { }
        // RVA: 0x09B44EB8  token: 0x600059C
        public UnityEngine.Transform __Gen_Wrap_125(System.Object P0, System.Object P1) { }
        // RVA: 0x09B44FB0  token: 0x600059D
        public UnityEngine.Vector3 __Gen_Wrap_126(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x09B450F0  token: 0x600059E
        public Beyond.UI.RegionMap3DCfg __Gen_Wrap_127(System.Object P0, System.Object P1) { }
        // RVA: 0x09B451E8  token: 0x600059F
        public DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> __Gen_Wrap_128(System.Object P0, System.Single P1, System.Object P2) { }
        // RVA: 0x09B452FC  token: 0x60005A0
        public System.Void __Gen_Wrap_129(System.Object P0, Beyond.EventData<System.Int64,System.Int64>& P1) { }
        // RVA: 0x050F1D3C  token: 0x60005A1
        public System.Boolean __Gen_Wrap_130() { }
        // RVA: 0x05153920  token: 0x60005A2
        public System.Boolean __Gen_Wrap_131(System.Object P0, System.Object P1) { }
        // RVA: 0x09B4540C  token: 0x60005A3
        public System.Void __Gen_Wrap_132(System.Object P0, System.Object P1, UnityEngine.Vector3 P2) { }
        // RVA: 0x09B45530  token: 0x60005A4
        public System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> __Gen_Wrap_133(System.Object P0) { }
        // RVA: 0x09B4560C  token: 0x60005A5
        public Beyond.UI.LuaPanel __Gen_Wrap_134(System.Object P0) { }
        // RVA: 0x09B456E8  token: 0x60005A6
        public System.Void __Gen_Wrap_135(System.Object P0, System.Object P1, System.Int64 P2, System.Single P3) { }
        // RVA: 0x09B457E4  token: 0x60005A7
        public System.Void __Gen_Wrap_136(System.Object P0, UnityEngine.Vector3 P1, System.UInt64 P2) { }
        // RVA: 0x09B443E4  token: 0x60005A8
        public System.Void __Gen_Wrap_137(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3) { }
        // RVA: 0x055FE324  token: 0x60005A9
        public System.Void __Gen_Wrap_138(System.Object P0, System.Boolean P1, System.Object P2) { }
        // RVA: 0x05606C1C  token: 0x60005AA
        public System.Void __Gen_Wrap_139(System.Object P0, System.Int64 P1) { }
        // RVA: 0x087040F0  token: 0x60005AB
        public System.Void __Gen_Wrap_140(System.Object P0, System.Int32 P1, System.UInt32 P2) { }
        // RVA: 0x08739D18  token: 0x60005AC
        public System.Void __Gen_Wrap_141(System.Object P0, System.Int32 P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x09B45A20  token: 0x60005AD
        public System.Void __Gen_Wrap_142(System.Object P0, System.Int64 P1, System.Single P2) { }
        // RVA: 0x09B45B04  token: 0x60005AE
        public UnityEngine.RectTransform __Gen_Wrap_143(System.Object P0) { }
        // RVA: 0x09B45BE0  token: 0x60005AF
        public System.Void __Gen_Wrap_144(System.Object P0, UnityEngine.Vector2 P1, System.Single P2, System.Boolean P3) { }
        // RVA: 0x09B45D0C  token: 0x60005B0
        public System.Void __Gen_Wrap_145(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4) { }
        // RVA: 0x055FFD60  token: 0x60005B1
        public System.Void __Gen_Wrap_146(System.Object P0, Beyond.Gameplay.Factory.PowerAutoConnectStatus P1) { }
        // RVA: 0x09B45E18  token: 0x60005B2
        public UnityEngine.GameObject __Gen_Wrap_147(System.Object P0) { }
        // RVA: 0x055FFD60  token: 0x60005B3
        public System.Void __Gen_Wrap_148(System.Object P0, Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon P1) { }
        // RVA: 0x09B45EF4  token: 0x60005B4
        public Beyond.UI.UIAnimationWrapper __Gen_Wrap_149(System.Object P0) { }
        // RVA: 0x055FFD60  token: 0x60005B5
        public System.Void __Gen_Wrap_150(System.Object P0, Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus P1) { }
        // RVA: 0x09B460E8  token: 0x60005B6
        public System.Void __Gen_Wrap_151(System.Object P0, Beyond.EventData<System.Int32,System.Single>& P1) { }
        // RVA: 0x09B46200  token: 0x60005B7
        public System.Void __Gen_Wrap_152(System.Object P0, Beyond.EventData<Beyond.Gameplay.WaterDroneSourceType>& P1) { }
        // RVA: 0x055FFD60  token: 0x60005B8
        public System.Void __Gen_Wrap_153(System.Object P0, Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState P1) { }
        // RVA: 0x09B46314  token: 0x60005B9
        public System.Void __Gen_Wrap_154(System.Object P0, Beyond.EventData<Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState>& P1) { }
        // RVA: 0x09B46428  token: 0x60005BA
        public System.Void __Gen_Wrap_155(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> P1) { }
        // RVA: 0x03D05CD0  token: 0x60005BB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BD  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x09B4ADF8  token: 0x60005BC
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x60005BD
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x20000BE  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60005BE
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x09B4B52C  token: 0x60005BF
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x0262C570  token: 0x60005C0
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x09B4B3E8  token: 0x60005C1
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x09B4B4B4  token: 0x60005C2
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x09B4B590  token: 0x60005C3
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x09B4B344  token: 0x60005C4
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x20000BF  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-InitializeAtRuntime0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICharPassiveCounter-OnCharPassiveNumChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICharPassiveMultiStates-OnCharPassiveNumChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICharPassiveZhuangfy-OnCharPassiveNumChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeBase-OnAssignData0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeBase-OnReady0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeBase-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeBase-OnCast0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeBase-OnRemove0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-_OnComboSkillRingQte0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-OnAssignData0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-_Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-OnCast0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-OnRemove0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSpecialNodeRingQte-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_InstantiateTextInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_RecycleTextInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_CreateTextInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-SetText1;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-SetFollowTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-SetUIOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-get_worldPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextDamageBase-PlayAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_GetRandomTextOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_IsTextPosValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-PlayAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnHpChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextIgniteBuff-SetUIState0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextIgniteBuff-SetTextAndDuplication0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnIgniteBuffText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-SetText2;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnImmuneText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnPhysicalInflictionApplied0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnSquadInFightChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnCreateFlowText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-_OnCharLevelUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-OnCreate0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-OnClose0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-DebugChangeImpl0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-OnHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrl-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-Assign0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_CreateTextInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-SetText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-SetText1;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-SetFollowTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-get_worldPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-SetUIOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-PlayAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_GetRandomTextOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_IsTextPosValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-DestroyDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnHpChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-SetText2;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnIgniteBuffText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnImmuneText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnPhysicalInflictionApplied0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnSquadInFightChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnCreateFlowText0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_RecycleTextInstance0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-_OnCharLevelUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-OnCreate0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-OnClose0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-DebugChangeImpl0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-OnHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-_UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCtrlV2-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-_UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBase-TailLateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBaseV2-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextBlock-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCriticalLevel0-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCriticalLevel1-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextCriticalLevel1-PlayAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextIgniteBuff-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextIgniteBuff-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-DamageTextNormalLevel1-PlayAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-FootBarDashCell-SetIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-FootBarDashCell-SetDashCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-FootBarDashCell-StartPlayNotEnoughAnim0;  // const
        public static IFix.IDMAP0 Beyond-UI-FootBarDashCell-StopPlayNotEnoughAnim0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_SetInDialog0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_GetHeadBarType0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-_TryRefreshHeightFollowTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-_TryRefreshFollowTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-GetOriginFollowPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-_UpdatePos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-SetActualVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-_SetDistanceVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-_UpdateScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-_UpdateSelfTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_SetImageFill0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_CalculateHpChangeDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_OnHpChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-ShowModifierAfterSetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-ShowModifierAfterSetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_RefreshHeadBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnInteractNpc0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnDialogStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnDialogFinish0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnAddHeadBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnRemoveHeadBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnHeadBarShowConfigChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnHpChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_OnEnemyPartEnableChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_OnFirstInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-OnPreWarm0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-OnPreWarm0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-OnPreWarm0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_PrewarmHeadBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-OnCreate0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-OnClose0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-BuffCellGroup-RemoveBuffCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-BuffCellGroup-ClearAllBuffCells0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_IsBuffIconInThisNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_GetIconStyle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-SetBuffIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-SetStackElementActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-SetWarningState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-SetVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-VisualInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-DataInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-SetStackCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_DealWithBuffCellVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_SetBuffCellSiblingInOrder0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-BuffCellGroup-CreateBuffCell0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_AddBuffIconInternal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVigilanceBar-Refresh0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-OnHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_UpdateSurroundingEnemies0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-get_followPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-SetHeadBarVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_UpdateHeadBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_UpdateLevelInfoBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_UpdateVigilanceBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-_UpdateTacticalItemBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-HeadBarCtrl-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseKnot-SetVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-_ClearPoiseKnot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-_CreatePoiseKnot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-_TryInitPoiseKnot0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-get_hidePoiseBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_OnAddBuff0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-BeforePlayOutAnim0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_RemoveBuffIconInternal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_OnRemoveBuff0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-OnBuffIconChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_OnBuffEnhanceChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-OnBuffIgnite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_OnBuffIgnite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_UnregisterAbilityBuffEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-_RegisterAbilityBuffEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_OnForceSetHp0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseKnot-KnotBreak0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-_CalculatePoiseChangeDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-OnPoiseChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_OnPoiseChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeaknessNode-SetTotalCellNum0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_OnMultiTimeWeaknessActivate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeaknessNode-SetCurrentCellNum0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_OnWeaknessCountChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_OnMainTargetChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_UpdateHpDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-_UpdateScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-_UpdatePoiseDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPoiseBar-UpdatePoiseBar0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBar-UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-_UpdateGuideLine0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-GetAdjustedHeightOffset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadBarFollower-GetOriginFollowPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_OnSubRootsCollectionChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_TryInitRootData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-SetVisibleDirty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-get_realVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_UpdateVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-UpdateVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-SetSubRootVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_OnNpcVisibleChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_BindTargetEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_UpdateFloatingUIVisibleCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_TryUpdateVisibleCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_UpdatePos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_OnMissionTypeIconChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_BindMissionTracking0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_ClearFloatingUIVisibleCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_ClearVisibleCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_RefreshVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-ClearEmojis0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_UnBindMissionTracking0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_UnBindTargetEvent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-SetActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-_TryUpdateVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-OnDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHeadLabel-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILvInfoBar-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILvInfoBar-GetOriginFollowPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPanelBase-GetSpritePath0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPanelBase-LoadSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITacticalItemBar-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UITacticalItemBar-UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVigilanceBar-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVigilanceBar-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVigilanceBar-_UpdateVigilanceNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVigilanceBar-UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVigilanceBar-GetOriginFollowPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeaknessNode-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-_OnAtbCellOutAnimCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-CheckAtbLoopAnim0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-_RefreshAtbShowing0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-OnInFightChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-OnGainAtb0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-OnCreate0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-OnClose0;  // const
        public static IFix.IDMAP0 Beyond-UI-AtbNode-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_ResortSiblingIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-OnCast0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_CheckUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-CastComboSkill0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-OnReady0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-OnRemove0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-Release0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPanelBase-LoadGameObject0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillHint-AssignData0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_OnComboSkillReady0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_RemoveComboSkill0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_OnComboSkillRemove0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_OnBattleTeamChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-_OnComboSkillClearAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-OnCreate0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPanelBase-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-ComboSkillPanel-PreTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-_AnimOutCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-_AnimInCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-_RefreshComboCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-_OnGlobalBuffStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-_OnGlobalBuffFinish0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-HpBarComboNode-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_SetHpFillAmount0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_CalculateHpChangeDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-_CheckNeedShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-SetLocalNeedShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-InformShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnHpChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnTakeDamage0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_HpVfxOutAnimCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnBuffChangeCharHpBarVfx0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnCharPassiveNumChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_BlinkBuffIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnBuffIconChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnBuffEnhanceChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_ClearMainChar0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_IsUltimateBuffValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_GetUltimateBuffForAbility0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_UltimateBuffProgressOutAnimCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_SetUltimateBuff0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_SelectUltimateBuff0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_GetOrCreateCharPassiveBase0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_ProcessOnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnProgressBarBuffChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_RebuildUltimateBuffTracking0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnTeamChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_OnMainCharHpActiveChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_CheckHpBarShowing0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_SetHpBarShowing0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-OnHide0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-_UpdateHpDisplay0;  // const
        public static IFix.IDMAP0 Beyond-UI-MainCharHpBar-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-OutOfScreenTargetsCtrl-OnCreate0;  // const
        public static IFix.IDMAP0 Beyond-UI-OutOfScreenTargetsCtrl-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-OutOfScreenTargetsCtrl-_CreateOneArrow0;  // const
        public static IFix.IDMAP0 Beyond-UI-OutOfScreenTargetsCtrl-_ScreenPosToUIPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-OutOfScreenTargetsCtrl-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandler-OnOtherPressSkillButtonStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_OnOtherPressSkillButtonStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnUspChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_InitSkillData0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnPressCancelled0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_RefreshDeadState0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_CheckNormalSkillHighlight0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_UpdateMainUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_SetPressFillActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_SetGoActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_OnSkillButtonActiveConfigChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-RefreshSkillButton0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_OnCharPotentialUnlock0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_OnCharNormalSkillChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_OnSkillUpgradeSuccess0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPanelBase-LoadSpriteWithOutFormat0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_UpdateLongPressKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_OnInputActionKeyUpdated0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-Close0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnPressSkillStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnPressSkillEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnPressUltimateSkillStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-FirstTimeInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-OnCharacterDie0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-_SetPressFillAmount0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-CastSkill0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-ToggleControllerSkillIndicator0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-SetEmpty0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-ClearBtnClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerLongPress-OnPressStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerLongPress-OnUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerLongPress-OnPressEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerLongPress-OnPressCancel0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerLongPress-OnOtherPressSkillButtonStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressCancel0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerDrag-OnPressStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerDrag-OnUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerDrag-OnPressEnd0;  // const
        public static IFix.IDMAP0 Beyond-UI-SkillButton-PressHandlerDrag-OnPressCancel0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-CanSwitchToCenter0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-OnPressCharIconStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_OnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_OnIgniteBuffText0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-FirstTimeInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_OnHpChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_HpVfxOutAnimCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_OnBuffChangeCharHpBarVfx0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_OnCharPassiveNumChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-Close0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-SetDeadState0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_UpdateComboSkillIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_TryShowLevelUpAnim0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_SetLevelText0;  // const
        public static IFix.IDMAP0 Beyond-UI-TacticalDotCell-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-OnTacticalItemChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-InitSquadIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_MustUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_UpdateIconAlpha0;  // const
        public static IFix.IDMAP0 Beyond-UI-TacticalDotCell-SetDotActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-TacticalDotCell-SetDotUsedUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-_UpdateTacticalItemStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-SetEmpty0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-ToggleIndicator0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-InformKeyHint0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-OnLevelChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-SquadIcon-OnTeamSwitchUnlocked0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffCell-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbnormalBuffCell-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbnormalBuffCell-VisualInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbnormalBuffCell-SetWarningState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-DataInit0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-BeforePlayOutAnim0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-SetBuffIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-SetStackElementActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-SetStackCount0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAttachedBuffCell-OnBuffIgnite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-TailLateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBuffNode-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILifeTimeBuffCell-OnTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILifeTimeBuffCell-SetWarningState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-_CheckNeedShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-_OnFadeHud0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-InformShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-_OnInformShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeConsoleController-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-_OnFadeHud0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-_OnInformShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeController-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-_CheckNeedShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-_OnFadeHud0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-InformShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-_OnInformShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIHudFadeTouchSkill-OnShow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIAbilityTargetFollower-TailLateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILockAim-_RefreshTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILockAim-_OnLockTargetFromAutoToManual0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILockAim-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILockAim-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILockAim-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILockAim-UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnDashFailed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_ProcessOnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_SetInDialog0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnInteractNpc0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnDialogStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnDialogFinish0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnDashCountChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-_OnOutAnimCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBar-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnDashFailed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_ProcessOnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnMainCharChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_RefreshDisableState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_SetInDialog0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnInteractNpc0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnDialogStart0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnDialogFinish0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnPlayCutscene0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnFinishCutscene0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnForbidSystemChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnDashCountChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-_OnOutAnimCallback0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-TailLateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIMainCharFootBarArc-SetUIDisable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeakLockAim-_RefreshTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeakLockAim-_OnMainTargetChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeakLockAim-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeakLockAim-Start0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWeakLockAim-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-BlueprintPreviewHelper-SetSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-BlueprintPreviewHelper-AddGridValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-BlueprintPreviewHelper-BatchAddGridValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-BlueprintPreviewHelper-GetGridValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICampfireTracker-UpdateImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonTracker-UpdateImage0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerNodeComp-ShowStyleType0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerNodeComp-PlayOutAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBlackboxTracker-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICampfireTracker-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonLevelTracker-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonTracker-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerNodeComp-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-get__inFactoryTopView0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-_FindTrackIndexByKey0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-_CreateNewMissionTracker0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-_InitTrackInfoByIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-_HideTrackerGo0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-_DeleteInvalidTracker0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-_ShowTrackerGo0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-UpdateCommonTrackers0;  // const
        public static IFix.IDMAP0 Beyond-UI-CommonTrackerUpdate-AllTrackersPlayOutAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-TryGetNeedComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitProgressBarUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitProgressBarUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitProgressBarUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitProgressBarUI-_TickCanvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitProgressBarUI-_UpdateProgress0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitProgressBarUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-_TickCanvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-_GetLangKeyOrDefault0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-_SetState0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-_UpdateUIState0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureCircleUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-set_uiActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-_TickCanvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-NormalizeRange0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTemperatureUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_GeneratePercentStrings0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_ResetUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_GetCanvas0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_TryGetModule0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_TickCanvasGroup0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_SetProgressText0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-_UpdateProgress0;  // const
        public static IFix.IDMAP0 Beyond-UI-CoolerUnitTotalProgressBarUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineCell-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineCell-PlayLineAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineCell-PlayLineDecoAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineCell-ChangeLineColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineCell-ChangeLineWidth0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-_Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-_CloneLineObject0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-_RefreshCopyLineObjectColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-DrawLine0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-PlayLineAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-PlayPortLineDecoAnimation0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-ChangeLineColor0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacLineDrawer-ClearDrawer0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacRegionUpgradeEffectController-_RefreshNodeState0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacRegionUpgradeEffectController-SetUpgradeState0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacRegionUpgradeEffectController-SetSelectState0;  // const
        public static IFix.IDMAP0 Beyond-UI-FacRegionUpgradeEffectController-SetVisibleState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_PosAdjust0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_UpdatePositionOffsetAfterZoomed0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_RefreshPivotPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_SetScale0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_OnZoom0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_ControllerZoomUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_ControllerDragUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_ControllerUpdate0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_RefreshAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-InitData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-MoveNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-_OnUnlockMoveNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-FocusNode0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-OnUnlockTech0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-ZoomToFullTechTree0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacTechTreePanel-SetDetailShownState0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronProgressBarUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronProgressBarUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronProgressBarUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronProgressBarUI-UpdateProgress0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronProgressBarUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-_SetState0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-UpdateUIState0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureCircleUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureUI-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureUI-SetPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureUI-SetUIForward0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureUI-UpdateUIInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureUI-UpdateUIPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-ForgeIronTemperatureUI-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-ForceToggleTargetBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-_OnTriggerPlayerAction0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-CopyTargetBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-ClearBinding0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-_ClearOnClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-ClearTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-GuideFakeButton-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMap3DCfg-Load0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-get_cfg0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_ClearMaterials0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMapTrackIcon-InitData0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_SetMapPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_InitTrackIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_InitUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_InitPlayerIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_InitSelect0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-_RefreshMaterials0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-MoveToPlayer0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-IsCircleIntersectingRectangle0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-InitData0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-GetNodeTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-GetNodeMoveTargetLocalPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-GetCfg0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-SetLoadedRegionTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-StartRegionRectTransformMoveRotationTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-RegionMapSetting-SetControllerLevelSelectedState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacMainRegion-_RefreshRegionState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacMainRegion-_OnMainRegionLevelChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacMainRegion-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacMainRegion-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIFacMainRegion-InitMainRegion0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-_ClearSpriteAsset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-_RefreshCraneState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-_OnCraneStateChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-_UnBindAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-_BindAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapCrane-InitCrane0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapGameplayArea-_RefreshGameplayArea0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapGameplayArea-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapGameplayArea-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-_LimitInRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-StartLimitMarkInRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-StopLimitMarkInRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLimitInRect-ForceRefreshLimitState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLine-_HoldLineSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLine-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLine-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLine-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapLine-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-_IsCircleOutsideDisappearRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-_DisappearIfOutRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-_RefreshMissionArea0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMissionArea-ForceRefreshDisappearIfOutRect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-IsMistyVisible0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-_RefreshMistyState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-_OnMistyStateChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-_UnBindAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-_BindAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapMisty-InitMisty0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapSwitchBtn-InitSwitchButton0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapSwitchBtn-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapTouchPanelWrapper-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapTouchPanelWrapper-_IsFirstRaycastSelectable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapTouchPanelWrapper-_CheckDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapTouchPanelWrapper-_CheckScroll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILevelMapTouchPanelWrapper-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMap3DPanel-_GetNodeTransform0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMap3DPanel-_GetMoveTargetLocalPosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMap3DPanel-_OnDoMoveTween0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMap3DPanel-InitPanel0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMap3DPanel-OnClickLevelBtn0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRegionMap3DPanel-OnLevelHoverChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-_RefreshSpriteWithTier0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-_RefreshSettlementRegionState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-_OnSettlementUnlocked0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-_UnBindAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-_BindAll0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-InitSettlementRegion0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-GetNeedRefreshSettlementRegionTier0;  // const
        public static IFix.IDMAP0 Beyond-UI-UISettlementRegion-RefreshSettlementRegionWithTier0;  // const
        public static IFix.IDMAP0 Beyond-UI-ChessboardDrop-_CheckEventValid0;  // const
        public static IFix.IDMAP0 Beyond-UI-ChessboardDrop-OnDrop0;  // const
        public static IFix.IDMAP0 Beyond-UI-ChessboardDrop-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-ChessboardDrop-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-ChessboardDrop-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-ChessboardDrop-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnBeginDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnEndDrag0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnPointerDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnPointerUp0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnPointerClick0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnPointerEnter0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleCellDrag-OnPointerExit0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleControllerHelper-get_raycastResults0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleControllerHelper-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleControllerHelper-TryGetPuzzleSlotIndexByPos0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-get_panel0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-ClearComponent0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-PuzzleDrag-SetIndex0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBrokenLine-_Init0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBrokenLine-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBrokenLine-OnDestroy0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBrokenLine-SetYValue0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIBrokenLine-SetYValueByArray0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-set_uiActive0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-_UpdatePos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-SetTarget0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-SetFixPoint0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-_FaceToCamera0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICommonScanController-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICountDownBar-set_update0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICountDownBar-_UpdatePos0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICountDownBar-_UpdateData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICountDownBar-InitData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICountDownBar-Clear0;  // const
        public static IFix.IDMAP0 Beyond-UI-UICountDownBar-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadMineCoreScanController-SetPurity0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadMineCoreScanController-SyncConditonInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadMineCoreScanController-UpdateUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-_SyncTimeText0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-SetCoreInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-SetRefreshInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-RefreshTextNow0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-SetSingle0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadPlantCoreScanController-SetQuantityInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadScanController-SyncRefreshInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadScanController-_RefreshCountDown0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadScanController-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIDoodadScanController-UpdateUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGeneralTracker-get_rect0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIGeneralTracker-UpdatePosition0;  // const
        public static IFix.IDMAP0 Beyond-UI-UILiquidPoolScanController-SetWaterInfo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateDistance0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-Switch0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-StatusHintGroup-Switch0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-SetActiveIfNecessary0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateNodeType0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_isDisabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormal0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormalOther0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_imageWarning0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlighted0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlightedOther0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_imageDisabled0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-_UpdateIcon0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-set_iconStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-get_animationWrapper0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-PlayFocus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIconStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-UpdateStatus0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsHighlighted0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsOtherSocial0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-UpdateDistance0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-_OnStatusChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIPowerPoleFastTravelTracker-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-_ResetData0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-_ShowBaseTrans0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-_LoadAllSprite0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-_UpdateRaceModuleRank0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIRaceModuleRankController-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVideoHelper-Reset0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVideoHelper-ResetVideo0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVideoHelper-Awake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIVideoHelper-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneInfinityLiquidChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneEmptyChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneInteractiveChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneSourceTypeChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneRelaxChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged1;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-OnAwake0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_ClearWaterDrone0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_OnWaterDroneChange0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_SetIconStateController0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_UpdateState0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-_UpdateSlider0;  // const
        public static IFix.IDMAP0 Beyond-UI-UIWaterDroneBar-LateTick0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-TickUI0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-Tick0;  // const
        public static IFix.IDMAP0 Beyond-UI-WorldUIController-OnRelease0;  // const
        public static IFix.IDMAP0 Beyond-UI-Mission-MissionHudBGSizeUpdater-UpdateBgSize0;  // const
        public static IFix.IDMAP0 Beyond-UI-Mission-MissionHudBGSizeUpdater-LateTick0;  // const

    }

}

