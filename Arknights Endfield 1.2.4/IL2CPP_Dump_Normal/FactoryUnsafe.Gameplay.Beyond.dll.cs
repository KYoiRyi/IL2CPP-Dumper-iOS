// ========================================================
// Dumped by @desirepro
// Assembly: FactoryUnsafe.Gameplay.Beyond.dll
// Classes:  629
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000008  // size: 0x11
    public sealed struct <>c__DisplayClass0_0
    {
        // Fields
        public System.Boolean enable;  // 0x10

    }

    // TypeToken: 0x200000C  // size: 0x80
    public sealed class EntityCommandCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0578E524  token: 0x6000054
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x6000055
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.EntityCommandBufferData& buffer) { }
        // RVA: 0x0578E468  token: 0x6000056
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.EntityCommandBufferData& buffer, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C3CFC  token: 0x6000057
        public virtual System.Void EndInvoke(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.EntityCommandBufferData& buffer, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000D  // size: 0x20
    public sealed struct VirtualEntityMap
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity virtualEntity;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity realEntity;  // 0x18

    }

    // TypeToken: 0x2000013  // size: 0x20
    public sealed struct VirtualEntityMap
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity virtualEntity;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity realEntity;  // 0x18

    }

    // TypeToken: 0x2000014  // size: 0x40
    public sealed struct EntityCommandBufferParallelWriter
    {
        // Fields
        public System.Int64 tempIdx;  // 0x10
        public Unity.Collections.NativeQueue.ParallelWriter<UnityEngine.HyperGryph.ECS.EntityCommandBufferData> buffersWriter;  // 0x18
        public Unity.Collections.NativeParallelHashMap.ParallelWriter<System.UInt64,UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.VirtualEntityMap> tempEntitiesWriter;  // 0x30

    }

    // TypeToken: 0x2000019  // size: 0x3C
    public sealed struct EntityTransformData
    {
        // Fields
        public System.UInt32 next;  // 0x10
        public Beyond.Gameplay.Factory.LocalTransform localTrans;  // 0x14
        public System.Int32 parentIndex;  // 0x34
        public System.Boolean dirty;  // 0x38

    }

    // TypeToken: 0x200001A  // size: 0x3C
    public sealed struct Node
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData value;  // 0x10
        public System.UInt32 next;  // 0x10

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData.Type INCLUDE;  // const
        public static UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData.Type EXCLUDE;  // const

    }

    // TypeToken: 0x200001C  // size: 0x50
    public sealed struct BuilderData
    {
        // Fields
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.ComponentType> all;  // 0x10
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.ComponentType> none;  // 0x30

        // Methods
        // RVA: 0x02434AF0  token: 0x60000B6
        public UnityEngine.HyperGryph.ECS.ComponentMask ComponentMask(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData.Type type) { }

    }

    // TypeToken: 0x200001F  // size: 0x20
    public sealed struct BlockRange
    {
        // Fields
        public System.Int32 beginGroupIdx;  // 0x10
        public System.Int32 endGroupIdx;  // 0x14
        public System.Int32 beginGroupElemBeginIdx;  // 0x18
        public System.Int32 endGroupElemEndIdx;  // 0x1c

    }

    // TypeToken: 0x2000020  // size: 0x28
    public sealed struct QueryResultDefer : System.IDisposable
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups;  // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRanges;  // 0x18
        public System.Int32 rangeCount;  // 0x20

        // Properties
        System.Boolean valid { get; /* RVA: 0x0578FFB0 */ }
        System.Int32* rangeCountPtr { get; /* RVA: 0x03D55960 */ }

        // Methods
        // RVA: 0x03278C30  token: 0x60000C5
        public System.Void InitList(Unity.Collections.Allocator allocator, System.Int32 initialCapacity) { }
        // RVA: 0x0578FD74  token: 0x60000C6
        public System.Void ReleaseList() { }
        // RVA: 0x026DFA10  token: 0x60000C7
        public System.Void Reset() { }
        // RVA: 0x0578F9F4  token: 0x60000C8
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange& BlockRangeAt(System.Int32 index) { }
        // RVA: 0x0578FD30  token: 0x60000C9
        public UnityEngine.HyperGryph.ECS.GroupType& GroupAt(System.Int32 index) { }
        // RVA: 0x0578FC60  token: 0x60000CB
        public System.Void Foreach(System.Func<UnityEngine.HyperGryph.ECS.GroupType,System.Boolean> callback) { }
        // RVA: 0x0578FB94  token: 0x60000CC
        public System.Int32 EntityCount() { }
        // RVA: 0x0578FA3C  token: 0x60000CD
        public virtual System.Void Dispose() { }
        // RVA: 0x0578FA60  token: 0x60000CE
        public System.Void Dispose(Unity.Jobs.JobHandle jobHandle, System.Boolean inCrossFrame) { }
        // RVA: 0x0578FDCC  token: 0x60000CF
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000021  // size: 0x30
    public sealed struct QueryResult : System.IDisposable
    {
        // Fields
        public Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> groups;  // 0x10
        public Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange> blockRanges;  // 0x20

        // Properties
        System.Int32 rangeCount { get; /* RVA: 0x026DEED0 */ }
        System.Boolean isEmpty { get; /* RVA: 0x05790658 */ }

        // Methods
        // RVA: 0x05790420  token: 0x60000D2
        public virtual System.String ToString() { }
        // RVA: 0x057902A8  token: 0x60000D3
        public System.Void Foreach(System.Func<UnityEngine.HyperGryph.ECS.GroupType,System.Boolean> callback) { }
        // RVA: 0x026DEF90  token: 0x60000D4
        public System.Int32 EntityCount() { }
        // RVA: 0x05790284  token: 0x60000D5
        public virtual System.Void Dispose() { }
        // RVA: 0x026E6970  token: 0x60000D6
        public System.Void Dispose(Unity.Jobs.JobHandle jobHandle, System.Boolean inCrossFrame) { }

    }

    // TypeToken: 0x2000032
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.AdditiveEffectRequestStack<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600017D
        public System.Void .ctor(Beyond.Gameplay.Factory.AdditiveEffectRequestStack<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600017E
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600017F
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000180
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000033  // size: 0x50
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000035  // size: 0x1C
    public sealed struct ConveyorExt
    {
        // Fields
        public System.Int32 outCargoIndex;  // 0x10
        public System.Int32 cargoBeginIndex;  // 0x14
        public System.Int32 cargoEndIndex;  // 0x18

        // Methods
        // RVA: 0x02BC1160  token: 0x600018F
        public System.Void Reset() { }

    }

    // TypeToken: 0x2000036  // size: 0x1C
    public sealed struct Node
    {
        // Fields
        public Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt value;  // 0x10
        public System.UInt32 next;  // 0x10

    }

    // TypeToken: 0x2000038  // size: 0x40
    public sealed struct Info
    {
        // Fields
        public System.Byte protoType;  // 0x10
        public System.Boolean isCorner;  // 0x11
        public System.Single adjustHeight;  // 0x14
        public Unity.Mathematics.float3 position;  // 0x18
        public Unity.Mathematics.float3 rotation;  // 0x24
        public System.Single bend;  // 0x30
        public System.UInt32 lightMode;  // 0x34

    }

    // TypeToken: 0x200003F
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData4<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001C5
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData4<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60001C6
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60001C7
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60001C8
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000040  // size: 0x30
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000042
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData8<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001E8
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData8<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60001E9
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60001EA
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60001EB
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000043  // size: 0x50
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000045
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData32<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600020B
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData32<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600020C
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600020D
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600020E
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000046  // size: 0x110
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000048
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData64<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600022E
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData64<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600022F
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000230
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000231
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000049  // size: 0x210
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200004B
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData128<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000251
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData128<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000252
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000253
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000254
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200004C  // size: 0x410
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200004E
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData256<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000274
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData256<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000275
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000276
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000277
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200004F  // size: 0x810
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000051
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData512<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000297
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData512<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000298
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000299
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600029A
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000052  // size: 0x1010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000054
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.EntityData1024<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002BA
        public System.Void .ctor(Beyond.Gameplay.Factory.EntityData1024<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60002BB
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60002BC
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60002BD
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000055  // size: 0x2010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000057
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.Float4Data6<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002DD
        public System.Void .ctor(Beyond.Gameplay.Factory.Float4Data6<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60002DE
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60002DF
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60002E0
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000058  // size: 0x90
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200005A
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.Float4Data16<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000300
        public System.Void .ctor(Beyond.Gameplay.Factory.Float4Data16<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000301
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000302
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000303
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200005B  // size: 0x110
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200005D
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.IntData8<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000323
        public System.Void .ctor(Beyond.Gameplay.Factory.IntData8<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000324
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000325
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000326
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200005E  // size: 0x30
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000060
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.IntData32<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000346
        public System.Void .ctor(Beyond.Gameplay.Factory.IntData32<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000347
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000348
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000349
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000061  // size: 0x90
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000063  // size: 0x11
    public sealed struct LogisticsExtData
    {
    }

    // TypeToken: 0x2000066
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PortData16<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000369
        public System.Void .ctor(Beyond.Gameplay.Factory.PortData16<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600036A
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600036B
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600036C
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000067  // size: 0x410
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000069
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PortData32<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600038C
        public System.Void .ctor(Beyond.Gameplay.Factory.PortData32<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600038D
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600038E
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600038F
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200006A  // size: 0x810
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200006C
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PortData128<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60003AF
        public System.Void .ctor(Beyond.Gameplay.Factory.PortData128<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60003B0
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60003B1
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60003B2
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200006D  // size: 0x2010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200006F
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PortData256<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60003D2
        public System.Void .ctor(Beyond.Gameplay.Factory.PortData256<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60003D3
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60003D4
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60003D5
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000070  // size: 0x4010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000072  // size: 0xD28
    public sealed struct SharedExtData
    {
        // Fields
        public System.UInt32 next;  // 0x10
        public System.Int32 pendingSlotId;  // 0x14
        public System.UInt32 nodeId;  // 0x18
        public Beyond.Gameplay.Factory.ChapterTagFragment chapter;  // 0x1c
        public Beyond.Gameplay.Factory.StaticMountInfoCollection<Beyond.Gameplay.Factory.StaticMountInfo> staticMountInfos;  // 0x2c
        public System.Boolean adjustMapValid;  // 0x534
        public System.Single adjustMapHeight;  // 0x538
        public System.Boolean bAdjustedMap;  // 0x53c
        public System.Boolean bAdjustedOnce;  // 0x53d
        public System.Boolean culled;  // 0x53e
        public System.Boolean buildingNameCulled;  // 0x53f
        public System.Boolean stateUICulled;  // 0x540
        public System.UInt32 dirtyBitmask;  // 0x544
        public Beyond.Gameplay.Factory.Visibility visibility;  // 0x548
        public Beyond.Gameplay.Factory.Visibility additiveMatVisibility;  // 0x560
        public Beyond.Gameplay.Factory.AdditiveEffectFragment additiveEffect;  // 0x578
        public System.Boolean inMainRegion;  // 0xd20

        // Properties
        System.Boolean visible { get; /* RVA: 0x024FBB30 */ }
        System.Boolean visibleAdditiveMat { get; /* RVA: 0x02429770 */ }

        // Methods
        // RVA: 0x05790918  token: 0x60003E6
        public System.Boolean IsDirty(Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag f) { }
        // RVA: 0x05790978  token: 0x60003E7
        public System.Void SetDirty(Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag f, System.Boolean d) { }
        // RVA: 0x028BD8F0  token: 0x60003E8
        public System.Boolean IsPendingUnit() { }

    }

    // TypeToken: 0x2000073  // size: 0x14
    public sealed struct DirtyFlag
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag NONE;  // const
        public static Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag ALL;  // const
        public static Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag STATUS_CHANGE;  // const
        public static Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag VAT_UPDATE;  // const
        public static Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag UPDATE_STATUS_EFFECT;  // const
        public static Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag CULL_STATUS_CHANGE;  // const

    }

    // TypeToken: 0x2000074  // size: 0xD28
    public sealed struct Node
    {
        // Fields
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData value;  // 0x10
        public System.UInt32 next;  // 0x10

    }

    // TypeToken: 0x2000077
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.StaticMountInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000407
        public System.Void .ctor(Beyond.Gameplay.Factory.StaticMountInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000408
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000409
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600040A
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000078  // size: 0x510
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200007A
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.UnitExtendConfig12<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600042A
        public System.Void .ctor(Beyond.Gameplay.Factory.UnitExtendConfig12<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600042B
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600042C
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600042D
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200007B  // size: 0x810
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200007E
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000451
        public System.Void .ctor(Beyond.Gameplay.Factory.WireRendererInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000452
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000453
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000454
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200007F  // size: 0x6010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000085  // size: 0x14
    public sealed struct Request
    {
        // Fields
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType type;  // 0x10
        public System.Int16 typeValue;  // 0x10
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType lastType;  // 0x12
        public System.Int16 lastTypeValue;  // 0x12

    }

    // TypeToken: 0x2000086  // size: 0x12
    public sealed struct AdditiveEffectType
    {
        // Fields
        public System.Int16 value__;  // 0x10
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType NONE;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType SOLO_SELECT;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType BUILD_DISMISS;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType BLUEPRINT_BUILD;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType CUTOFF;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType REPAIR;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType HIGH_LIGHT;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType HINT;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType FIGURE;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType OVERLOAD;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType OVERLOAD_INVALID;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType BLUEPRINT;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType PRE_SELECT;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType CONTINUATION;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType SOCIAL_SHARING;  // const
        public static Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType POWER_INTERACTION;  // const

    }

    // TypeToken: 0x2000089  // size: 0x11
    public sealed struct BuildEffectType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.BuildDismissState.BuildEffectType DEFAULT;  // const
        public static Beyond.Gameplay.Factory.BuildDismissState.BuildEffectType TYPE1;  // const

    }

    // TypeToken: 0x2000094  // size: 0x11
    public sealed struct EffectType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.BlueprintState.EffectType NONE;  // const
        public static Beyond.Gameplay.Factory.BlueprintState.EffectType TO_BE_BUILD;  // const
        public static Beyond.Gameplay.Factory.BlueprintState.EffectType TO_BE_BUILD_SELECT;  // const
        public static Beyond.Gameplay.Factory.BlueprintState.EffectType MOVING;  // const
        public static Beyond.Gameplay.Factory.BlueprintState.EffectType MOVING_INVALID;  // const
        public static Beyond.Gameplay.Factory.BlueprintState.EffectType TO_BUILD_INVALID;  // const

    }

    // TypeToken: 0x20000A1  // size: 0x18
    public sealed struct <cacheSizePtr>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000A2  // size: 0x18
    public sealed struct <cacheFluidSizePtr>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000A3  // size: 0x210
    public sealed struct <cacheContentPtr>e__FixedBuffer
    {
        // Fields
        public System.Int32 FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000A4  // size: 0x210
    public sealed struct <itemInPtr>e__FixedBuffer
    {
        // Fields
        public System.Int32 FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000A5  // size: 0x210
    public sealed struct <itemOutPtr>e__FixedBuffer
    {
        // Fields
        public System.Int32 FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000A6  // size: 0x210
    public sealed struct <fluidInPtr>e__FixedBuffer
    {
        // Fields
        public System.Int32 FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000A7  // size: 0x210
    public sealed struct <fluidOutPtr>e__FixedBuffer
    {
        // Fields
        public System.Int32 FixedElementField;  // 0x10

    }

    // TypeToken: 0x20000AA  // size: 0x34
    public sealed struct ItemUV
    {
        // Fields
        public System.Boolean isLiquid;  // 0x10
        public Unity.Mathematics.int4 itemAtlasRect;  // 0x14
        public Unity.Mathematics.int4 liquidAtlasRect;  // 0x24

    }

    // TypeToken: 0x20000AF  // size: 0x11
    public sealed struct RendererType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.ConnectionFragment.RendererType NORMAL;  // const
        public static Beyond.Gameplay.Factory.ConnectionFragment.RendererType HS;  // const

    }

    // TypeToken: 0x20000B1  // size: 0x11
    public sealed struct ProtoType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.ConveyorFragment.ProtoType LEFT;  // const
        public static Beyond.Gameplay.Factory.ConveyorFragment.ProtoType MID;  // const
        public static Beyond.Gameplay.Factory.ConveyorFragment.ProtoType RIGHT;  // const

    }

    // TypeToken: 0x20000DB  // size: 0x14
    public sealed struct EntityTarget
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTarget BUILDING;  // const
        public static Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTarget PEDESTAL_LOGISTIC;  // const
        public static Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTarget PEDESTAL_NO_LOGISTIC;  // const

    }

    // TypeToken: 0x20000DC  // size: 0x14
    public sealed struct EntityType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.UnitPreviewFragment.EntityType NORMAL;  // const
        public static Beyond.Gameplay.Factory.UnitPreviewFragment.EntityType BLUEPRINT;  // const

    }

    // TypeToken: 0x2000102  // size: 0x50
    public sealed struct <intensity>e__FixedBuffer
    {
        // Fields
        public System.Single FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000103  // size: 0x50
    public sealed struct <flashIntensity>e__FixedBuffer
    {
        // Fields
        public System.Single FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000104  // size: 0x50
    public sealed struct <flashDuration>e__FixedBuffer
    {
        // Fields
        public System.Single FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000105  // size: 0x20
    public sealed struct <flash>e__FixedBuffer
    {
        // Fields
        public System.Boolean FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000116  // size: 0x14
    public sealed struct EOwner
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.SocialFragment.EOwner ALL;  // const
        public static Beyond.Gameplay.Factory.SocialFragment.EOwner MINE;  // const
        public static Beyond.Gameplay.Factory.SocialFragment.EOwner OTHERS;  // const

    }

    // TypeToken: 0x200013D  // size: 0x810
    public sealed struct <m_blueprintSlotInfo0>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x200013E  // size: 0x810
    public sealed struct <m_blueprintSlotInfo1>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x200013F  // size: 0x810
    public sealed struct <m_blueprintSlotInfo2>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000140  // size: 0x810
    public sealed struct <m_blueprintSlotInfo3>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000141  // size: 0x810
    public sealed struct <m_blueprintSlotInfo4>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000142  // size: 0x810
    public sealed struct <m_blueprintSlotInfo5>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000143  // size: 0x810
    public sealed struct <m_blueprintRelatedSlotInfo>e__FixedBuffer
    {
        // Fields
        public System.UInt64 FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000145
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.CargoRendererInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000750
        public System.Void .ctor(Beyond.Gameplay.Factory.CargoRendererInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000751
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000752
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000753
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000146  // size: 0x48010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000149
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000774
        public System.Void .ctor(Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000775
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000776
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000777
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200014A  // size: 0x40010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200014E
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600079A
        public System.Void .ctor(Beyond.Gameplay.Factory.PipeRendererInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600079B
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600079C
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x600079D
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200014F  // size: 0x60010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000151
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60007BE
        public System.Void .ctor(Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60007BF
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60007C0
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60007C1
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000152  // size: 0x2010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000156
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60007E2
        public System.Void .ctor(Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60007E3
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60007E4
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60007E5
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000157  // size: 0x20010
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x200015B  // size: 0x14
    public sealed struct EFlag
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.Visibility.EFlag BASIC;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag FIGURE;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag OTHER_MAP;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag PHOTO;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag BUILD_MODE;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag UI;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag HINT_EFFECT;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag EXTERNAL;  // const
        public static Beyond.Gameplay.Factory.Visibility.EFlag ALL;  // const

    }

    // TypeToken: 0x200015C  // size: 0x11
    public sealed struct Type
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.Visibility.Type BASE;  // const
        public static Beyond.Gameplay.Factory.Visibility.Type ADDITIVE_MAT;  // const

    }

    // TypeToken: 0x200015D  // size: 0x20
    public sealed struct <invisibleSubBits>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x200015F  // size: 0x11
    public sealed struct Type
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.WireRendererFragment.Type NORMAL;  // const
        public static Beyond.Gameplay.Factory.WireRendererFragment.Type HS_NORMAL;  // const
        public static Beyond.Gameplay.Factory.WireRendererFragment.Type DISABLE;  // const
        public static Beyond.Gameplay.Factory.WireRendererFragment.Type STRENGTHEN;  // const
        public static Beyond.Gameplay.Factory.WireRendererFragment.Type HS_STRENGTHEN;  // const
        public static Beyond.Gameplay.Factory.WireRendererFragment.Type STRENGTHEN_DISABLE;  // const

    }

    // TypeToken: 0x2000161  // size: 0x34
    public sealed struct CullingGlobalSetting
    {
        // Fields
        public System.Boolean bOverride;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.CullingDisSetting setting;  // 0x14
        public Beyond.Gameplay.Factory.GlobalSharedData.CullingDisSetting overrideSetting;  // 0x24

        // Properties
        System.Single sqrCullDis { get; /* RVA: 0x02501140 */ set; /* RVA: 0x03D56240 */ }
        System.Single sqrUI { get; /* RVA: 0x02C663C0 */ set; /* RVA: 0x03D56250 */ }
        System.Single sqrBuildingName { get; /* RVA: 0x02C66380 */ set; /* RVA: 0x03D56230 */ }
        System.Single sqrWireCullDis { get; /* RVA: 0x02765B90 */ set; /* RVA: 0x03D56260 */ }

        // Methods
        // RVA: 0x03102240  token: 0x60007FC
        public System.Void ResetOverride() { }

    }

    // TypeToken: 0x2000162  // size: 0x20
    public sealed struct CullingDisSetting
    {
        // Fields
        public System.Single sqrCullDis;  // 0x10
        public System.Single sqrBuildingName;  // 0x14
        public System.Single sqrUI;  // 0x18
        public System.Single sqrWireCullDis;  // 0x1c

    }

    // TypeToken: 0x2000163  // size: 0x4C
    public sealed struct NearByDistanceGlobalSetting
    {
        // Fields
        public System.Boolean bOverride;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceSetting setting;  // 0x14
        public Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceSetting overrideSetting;  // 0x30

        // Properties
        System.Boolean nearByCheck { get; /* RVA: 0x02BBE240 */ set; /* RVA: 0x03D56330 */ }
        System.Single portPreviewCheckDistance { get; /* RVA: 0x02BC01E0 */ set; /* RVA: 0x03D56350 */ }
        System.Single pedestalFlashCheckDistance { get; /* RVA: 0x02BBE1C0 */ set; /* RVA: 0x03D56340 */ }
        System.Single logisticEffectCheckDistance { get; /* RVA: 0x02BBE200 */ set; /* RVA: 0x03D56320 */ }
        System.Single unitRendererCheckDistance { get; /* RVA: 0x02BBB290 */ set; /* RVA: 0x03D56360 */ }
        System.Single l2wCheckDistance { get; /* RVA: 0x02BBEB80 */ set; /* RVA: 0x03D56310 */ }
        System.Single additiveEffectCheckDistance { get; /* RVA: 0x02BBED60 */ set; /* RVA: 0x03D56300 */ }

        // Methods
        // RVA: 0x031022B0  token: 0x6000805
        public System.Void ResetOverride() { }
        // RVA: 0x057A5F70  token: 0x6000806
        public System.Void Disable() { }

    }

    // TypeToken: 0x2000164  // size: 0x2C
    public sealed struct NearByDistanceSetting
    {
        // Fields
        public System.Boolean nearByCheck;  // 0x10
        public System.Single portPreviewCheckDistance;  // 0x14
        public System.Single pedestalFlashCheckDistance;  // 0x18
        public System.Single logisticEffectCheckDistance;  // 0x1c
        public System.Single unitRendererCheckDistance;  // 0x20
        public System.Single l2wCheckDistance;  // 0x24
        public System.Single additiveEffectCheckDistance;  // 0x28

    }

    // TypeToken: 0x2000165  // size: 0x13
    public sealed struct World3DUiGlobalSetting
    {
        // Fields
        public System.Boolean bOverride;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.World3DUiSetting setting;  // 0x11
        public Beyond.Gameplay.Factory.GlobalSharedData.World3DUiSetting overrideSetting;  // 0x12

        // Properties
        System.Boolean buildingNameShadowDisable { get; /* RVA: 0x031021D0 */ set; /* RVA: 0x03D565B0 */ }

        // Methods
        // RVA: 0x057AA228  token: 0x6000815
        public System.Void Disable() { }
        // RVA: 0x03102210  token: 0x6000816
        public System.Void ResetOverride() { }

    }

    // TypeToken: 0x2000166  // size: 0x11
    public sealed struct World3DUiSetting
    {
        // Fields
        public System.Boolean buildingNameShadowDisable;  // 0x10

    }

    // TypeToken: 0x2000167  // size: 0x38
    public sealed struct CurveGlobalSetting
    {
        // Fields
        public System.Void* buildCurve;  // 0x10
        public System.Void* buildAlphaCurve0;  // 0x18
        public System.Void* buildAlphaCurve1;  // 0x20
        public System.Void* repairCurve0;  // 0x28
        public System.Void* repairCurve1;  // 0x30

        // Methods
        // RVA: 0x033D9E00  token: 0x6000819
        public System.Void SetBuildCurve(Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1) { }
        // RVA: 0x033D9DC0  token: 0x600081A
        public System.Void SetRepairCurve0(Beyond.Gameplay.Factory.FPtrNativeCurve& curve) { }
        // RVA: 0x033D9D80  token: 0x600081B
        public System.Void SetRepairCurve1(Beyond.Gameplay.Factory.FPtrNativeCurve& curve) { }

    }

    // TypeToken: 0x200016A  // size: 0x14
    public sealed struct SelectType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo.SelectType NORMAL;  // const
        public static Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo.SelectType BLUEPRINT;  // const

    }

    // TypeToken: 0x2000169  // size: 0x48
    public sealed struct MapGridInfo
    {
        // Fields
        public Beyond.Gameplay.Factory.LocalTransform trans;  // 0x10
        public Unity.Mathematics.int3 gridVoxelIndex;  // 0x30
        public System.Boolean selected;  // 0x3c
        public Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo.SelectType selectedRenderType;  // 0x40
        public System.Boolean hover;  // 0x44
        public System.Boolean water;  // 0x45
        public System.Boolean invalid;  // 0x46

    }

    // TypeToken: 0x200016B  // size: 0x32010
    public sealed struct <infos>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000168  // size: 0x32016
    public sealed struct MapGridRendererData
    {
        // Fields
        public static System.Int32 MAX_COUNT;  // const
        public System.Int16 gridCountRegion;  // 0x10
        public System.Int16 gridCountField;  // 0x12
        public System.Int16 gridCount;  // 0x14
        public Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.<infos>e__FixedBuffer infos;  // 0x16

        // Properties
        Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo Item { get; /* RVA: 0x03D562C0 */ }

        // Methods
        // RVA: 0x029112B0  token: 0x600081C
        public System.Void UpdateGrid(Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& gridInfosRegion, Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& gridInfosField) { }
        // RVA: 0x0327BA20  token: 0x600081D
        public System.Void Reset() { }
        // RVA: 0x03D562B0  token: 0x600081F
        public Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo* GetGridInfoPtr(System.Int32 idx) { }

    }

    // TypeToken: 0x200016C  // size: 0x20
    public sealed struct UnitPortConfigDB
    {
        // Fields
        public Unity.Collections.NativeParallelHashMap<System.Int32,Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig> configMap;  // 0x10

        // Methods
        // RVA: 0x031022F0  token: 0x6000820
        public System.Void Initialize(System.Int32 capacity) { }
        // RVA: 0x057A8DF0  token: 0x6000821
        public System.Void Dispose() { }
        // RVA: 0x029C00F0  token: 0x6000822
        public System.Boolean EnsureValue(System.String unitName, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& value) { }
        // RVA: 0x029BFE20  token: 0x6000823
        public System.Boolean EnsureValue(System.Int32 unitNameFastId, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& value) { }
        // RVA: 0x029C02D0  token: 0x6000824
        public System.Boolean TryGetValue(System.String unitName, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& value) { }
        // RVA: 0x029C0340  token: 0x6000825
        public System.Boolean TryGetValue(System.Int32 unitNameFastId, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& value) { }
        // RVA: 0x0345DAE0  token: 0x6000826
        public System.Void Add(System.String unitName, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig value) { }
        // RVA: 0x0345DBB0  token: 0x6000827
        public System.Void Add(System.Int32 unitNameFastId, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig value) { }
        // RVA: 0x057A8D64  token: 0x6000828
        public System.Boolean ContainsKey(System.String unitName) { }
        // RVA: 0x057A8CD0  token: 0x6000829
        public System.Void Clear() { }
        // RVA: 0x057A8E84  token: 0x600082A
        private Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig _CreateWithTable(System.Int32 unitNameFastId) { }
        // RVA: 0x0287FC00  token: 0x600082B
        private Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig _CreateWithTable(System.String unitName) { }
        // RVA: 0x02880B60  token: 0x600082C
        private static System.Void _ParseGlobalPortIdx(System.String templateName, Beyond.Gameplay.Factory.FactoryUnitPortConfig& port, System.Int32 inPortCount) { }
        // RVA: 0x028813B0  token: 0x600082D
        private static System.Void <_CreateWithTable>g__FillBuildingPorts|12_0(System.String templateName, Beyond.Cfg.FactoryBuildingData data, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& target) { }
        // RVA: 0x0287F4B0  token: 0x600082E
        private static System.Void <_CreateWithTable>g__ParsePort|12_1(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& target, System.String templateName, Beyond.Cfg.Vector3IntData range, Beyond.SparkBuffer.Runtime.Wrapper.BeanArray<Beyond.Cfg.TransformInt> inputPorts, Beyond.SparkBuffer.Runtime.Wrapper.BeanArray<Beyond.Cfg.TransformInt> outputPorts, System.Boolean isPipePort) { }

    }

    // TypeToken: 0x200016D  // size: 0x414
    public sealed struct UnitPortConfig
    {
        // Fields
        public System.UInt16 inputPortCount;  // 0x10
        public System.UInt16 outputPortCount;  // 0x12
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig> portIn;  // 0x14
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig> portOut;  // 0x214

    }

    // TypeToken: 0x2000170  // size: 0x290
    public sealed struct <config>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x200016F  // size: 0x294
    public sealed struct PerDrawPassGlobalSetting
    {
        // Fields
        public System.Int32 count;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting.<config>e__FixedBuffer config;  // 0x14

        // Properties
        Beyond.Gameplay.Factory.PerDrawPassConfig Item { get; /* RVA: 0x057A6504 */ set; /* RVA: 0x032C9270 */ }

        // Methods
        // RVA: 0x057A6464  token: 0x6000837
        public Beyond.Gameplay.Factory.PerDrawPassConfig GetPerDrawPassConfig(System.Int32 idx) { }

    }

    // TypeToken: 0x2000172  // size: 0x290
    public sealed struct <configs>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000171  // size: 0x294
    public sealed struct PerDrawColorGlobalSetting
    {
        // Fields
        public System.Int32 count;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting.<configs>e__FixedBuffer configs;  // 0x14

        // Properties
        Beyond.Gameplay.Factory.PerDrawConfig Item { get; /* RVA: 0x057A6188 */ set; /* RVA: 0x032C9200 */ }

        // Methods
        // RVA: 0x057A60E0  token: 0x600083A
        public Beyond.Gameplay.Factory.PerDrawConfig GetPerDrawConfig(System.Int32 idx) { }

    }

    // TypeToken: 0x2000173  // size: 0xE16A
    public sealed struct <colorData>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x2000174  // size: 0xE110
    public sealed struct <passData>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x10

    }

    // TypeToken: 0x200016E  // size: 0x1C26A
    public sealed struct PerDrawGlobalSetting
    {
        // Fields
        public static System.Int32 COLOR_DATA_CAPACITY;  // const
        public static System.Int32 PASS_DATA_CAPACITY;  // const
        public Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.<colorData>e__FixedBuffer colorData;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.<passData>e__FixedBuffer passData;  // 0xe16a

        // Methods
        // RVA: 0x057A63FC  token: 0x600082F
        public System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType) { }
        // RVA: 0x02421790  token: 0x6000830
        public System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType) { }
        // RVA: 0x02421860  token: 0x6000831
        public static System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length) { }
        // RVA: 0x057A6308  token: 0x6000832
        public System.Void ApplyPass(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType, System.UInt32 currentLightMode) { }
        // RVA: 0x057A6244  token: 0x6000833
        public System.Void ApplyPass(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType, System.UInt32 currentLightMode) { }
        // RVA: 0x057A6378  token: 0x6000834
        public static System.Void ApplyPass(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.PerDrawPassConfig* perDrawConfigs, System.Int32 length, System.UInt32 currentLightMode) { }
        // RVA: 0x032C7C20  token: 0x6000835
        public System.Void Parse(Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityState,Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityType,Beyond.Gameplay.Factory.PerDrawConfigArray>> setting) { }
        // RVA: 0x02421820  token: 0x6000836
        private System.Int32 _GetKey(Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType) { }

    }

    // TypeToken: 0x2000175  // size: 0x64
    public sealed struct SystemIntervalGlobalSetting
    {
        // Fields
        public System.Boolean bOverride;  // 0x10
        public Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalSetting setting;  // 0x14
        public Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalSetting overrideSetting;  // 0x3c

        // Properties
        System.Int32 crossCollectFrameInterval { get; /* RVA: 0x03280FB0 */ set; /* RVA: 0x03D56430 */ }
        System.Int32 cullingSystemInterval { get; /* RVA: 0x023110D0 */ set; /* RVA: 0x03D56440 */ }
        System.Int32 unitPreviewSystemInterval { get; /* RVA: 0x02310F90 */ set; /* RVA: 0x03D56490 */ }
        System.Int32 portPreviewRenderSystemInterval { get; /* RVA: 0x02311010 */ set; /* RVA: 0x03D56480 */ }
        System.Int32 buildingStateSystemInterval { get; /* RVA: 0x02311110 */ set; /* RVA: 0x03D56420 */ }
        System.Int32 portBlockSystemInterval { get; /* RVA: 0x02310FD0 */ set; /* RVA: 0x03D56470 */ }
        System.Int32 outputUISystemInterval { get; /* RVA: 0x02311050 */ set; /* RVA: 0x03D56460 */ }
        System.Int32 buildingNameSystemInterval { get; /* RVA: 0x057A84FC */ set; /* RVA: 0x03D56410 */ }
        System.Int32 adjustGroundSystemInterval { get; /* RVA: 0x02311150 */ set; /* RVA: 0x03D56400 */ }
        System.Int32 gridSystemInterval { get; /* RVA: 0x02311090 */ set; /* RVA: 0x03D56450 */ }

        // Methods
        // RVA: 0x057A8484  token: 0x600083D
        public System.Void Disable() { }
        // RVA: 0x03102270  token: 0x600083E
        public System.Void ResetOverride() { }

    }

    // TypeToken: 0x2000176  // size: 0x38
    public sealed struct SystemIntervalSetting
    {
        // Fields
        private static System.Int32 MIN_INTERVAL;  // const
        private static System.Int32 MAX_INTERVAL;  // const
        public System.Int32 crossCollectFrameInterval;  // 0x10
        public System.Int32 cullingSystemInterval;  // 0x14
        public System.Int32 unitPreviewSystemInterval;  // 0x18
        public System.Int32 portPreviewRenderSystemInterval;  // 0x1c
        public System.Int32 buildingStateSystemInterval;  // 0x20
        public System.Int32 portBlockSystemInterval;  // 0x24
        public System.Int32 outputUISystemInterval;  // 0x28
        public System.Int32 buildingNameSystemInterval;  // 0x2c
        public System.Int32 adjustGroundSystemInterval;  // 0x30
        public System.Int32 gridSystemInterval;  // 0x34

    }

    // TypeToken: 0x2000177  // size: 0x40
    public sealed struct UIEffectPathConfig
    {
        // Fields
        public static System.Int32 s_max;  // static @ 0x0
        public Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Collections.FixedString32Bytes> atlasNames;  // 0x10
        public Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float4> atlasColors;  // 0x20
        public Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float4> atlasUVs;  // 0x30

        // Methods
        // RVA: 0x0327F6A0  token: 0x6000853
        public System.Void Parse(Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,System.String> config, Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,UnityEngine.Color> factoryStateIconColorConfig, FactoryUIAtlas.FactoryUIAtlasSOData uvConfig) { }
        // RVA: 0x057A8558  token: 0x6000854
        public System.Boolean Get(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color) { }
        // RVA: 0x03D438E0  token: 0x6000855
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200017C  // size: 0x80
    public sealed class ApplyRender : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03CC3530  token: 0x6000885
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x6000886
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length) { }
        // RVA: 0x057A1888  token: 0x6000887
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000888
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200017D  // size: 0x80
    public sealed class FacRegionPosValid : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03281380  token: 0x6000889
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x057A2E88  token: 0x600088A
        public virtual System.Boolean Invoke(UnityEngine.HyperGryph.ECS.EntityManager* entityManager, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment) { }
        // RVA: 0x057A2DCC  token: 0x600088B
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager* entityManager, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C0FC0  token: 0x600088C
        public virtual System.Boolean EndInvoke(Beyond.Gameplay.Factory.UnitFragment*& unitFragment, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200017E  // size: 0x80
    public sealed class QueryStateIconPath : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x032812F0  token: 0x600088D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0101C850  token: 0x600088E
        public virtual System.Boolean Invoke(Beyond.GEnums.FacBuildingState stateUI, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color) { }
        // RVA: 0x057A7894  token: 0x600088F
        public virtual System.IAsyncResult BeginInvoke(Beyond.GEnums.FacBuildingState stateUI, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C0580  token: 0x6000890
        public virtual System.Boolean EndInvoke(Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200017F  // size: 0x80
    public sealed class QueryBuildingState : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x038DDD40  token: 0x6000891
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01035ED0  token: 0x6000892
        public virtual Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x057A7798  token: 0x6000893
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x057A785C  token: 0x6000894
        public virtual Beyond.GEnums.FacBuildingState EndInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000180  // size: 0x80
    public sealed class SetEntityFlashStatue : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x038DDCB0  token: 0x6000895
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x6000896
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue) { }
        // RVA: 0x057A7F28  token: 0x6000897
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x050C3CFC  token: 0x6000898
        public virtual System.Void EndInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001E7  // size: 0x24
    public sealed struct FAggregateEmitterTempData
    {
        // Fields
        public Unity.Mathematics.float3 sumPos;  // 0x10
        public System.Single sumWeight;  // 0x1c
        public System.Int32 count;  // 0x20

    }

    // TypeToken: 0x20001E8  // size: 0x2C
    public sealed struct FWaterPipeEmitterData
    {
        // Fields
        public Unity.Mathematics.float3 posData;  // 0x10
        public Unity.Mathematics.float2 extraData;  // 0x1c
        public System.Single sumWeight;  // 0x24
        public System.Int32 count;  // 0x28

    }

    // TypeToken: 0x20001E9  // size: 0x50
    public sealed struct FGroupEmitterTempData
    {
        // Fields
        public Unity.Mathematics.float3x3 sumPos;  // 0x10
        public Unity.Mathematics.float3 sumWeight;  // 0x34
        public Unity.Mathematics.float3 count;  // 0x40
        public System.Int32 inMainRegionActiveCount;  // 0x4c

    }

    // TypeToken: 0x20001EA  // size: 0x48
    public sealed struct AudioDistanceAndCullingJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single cullingCullDistanceSq;  // 0x10
        public System.Single cullingRestoreDistanceSq;  // 0x14
        public Unity.Mathematics.float3 listenerPos;  // 0x18
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x28

        // Methods
        // RVA: 0x057AD0F0  token: 0x6000AFA
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001EB  // size: 0x60
    public sealed struct AudioGroupEmitterJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float3 listenerPos;  // 0x10
        public System.Single innerRadiusSq;  // 0x1c
        public System.Single outerRadiusSq;  // 0x20
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x28
        public Unity.Collections.NativeArray<Beyond.Gameplay.Factory.AudioJobs.FGroupEmitterTempData> tempEmitterData;  // 0x48
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x58

        // Methods
        // RVA: 0x057AD30C  token: 0x6000AFB
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x02762ED0  token: 0x6000AFC
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001EC  // size: 0x60
    public sealed struct WaterPipeEmitterJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Mathematics.float3 listenerPos;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x20
        public Unity.Collections.NativeArray<Beyond.Gameplay.Factory.AudioJobs.FWaterPipeEmitterData> tempEmitterData;  // 0x40
        public System.Single outerRadiusSq;  // 0x50
        public Beyond.Gameplay.Factory.GlobalEnv* envPtr;  // 0x58

        // Methods
        // RVA: 0x057B7830  token: 0x6000AFD
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B79A0  token: 0x6000AFE
        private System.Void _DoCalculate(System.Int32 index, Beyond.Gameplay.Factory.PipeFragment& unit) { }
        // RVA: 0x032071A0  token: 0x6000AFF
        public System.Void SetGlobalEnv(Beyond.Gameplay.Factory.GlobalEnv& env) { }

    }

    // TypeToken: 0x2000200  // size: 0xBC
    public sealed struct BuildingInfoWrap
    {
        // Fields
        public Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo buildingInfo;  // 0x10
        private Beyond.Gameplay.Factory.UnitConfigFragment <unitConfig>k__BackingField;  // 0x64

        // Properties
        Beyond.Gameplay.Factory.UnitConfigFragment unitConfig { get; /* RVA: 0x03D565C0 */ set; /* RVA: 0x03D56600 */ }

        // Methods
        // RVA: 0x057BF4C8  token: 0x6000B4F
        public System.Void SwapTo(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap* other) { }

    }

    // TypeToken: 0x2000201  // size: 0x64
    public sealed struct BuildingInfo
    {
        // Fields
        public System.Boolean valid;  // 0x10
        public System.Int32 chapterId;  // 0x14
        public System.Int32 pendingSlotId;  // 0x18
        public System.UInt32 nodeId;  // 0x1c
        public System.UInt32 sharedDataHandle;  // 0x20
        public System.Int32 subIndex;  // 0x24
        public System.Single adjustMapHeight;  // 0x28
        public Unity.Mathematics.float3 position;  // 0x2c
        public Unity.Mathematics.float3 rotation;  // 0x38
        public Unity.Mathematics.float3 subPosition;  // 0x44
        public Unity.Mathematics.float3 subRotation;  // 0x50
        public System.Single subDist;  // 0x5c
        public System.Int32 templateNameFastString;  // 0x60

        // Properties
        System.String templateName { get; /* RVA: 0x02763320 */ }

        // Methods
        // RVA: 0x057BF5D0  token: 0x6000B51
        public virtual System.String ToString() { }
        // RVA: 0x057BF508  token: 0x6000B52
        public System.Void SetData(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& info) { }
        // RVA: 0x02AAED30  token: 0x6000B53
        public System.Boolean IsPending() { }
        // RVA: 0x057BF730  token: 0x6000B54
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000202  // size: 0x30
    public sealed struct LogisticInfo
    {
        // Fields
        public System.Boolean valid;  // 0x10
        public System.Boolean isConveyor;  // 0x11
        public System.Int32 pendingSlotId;  // 0x14
        public System.Int32 chapterId;  // 0x18
        public System.UInt32 nodeId;  // 0x1c
        public System.Int32 uintIndex;  // 0x20
        public Unity.Mathematics.float3 position;  // 0x24

        // Methods
        // RVA: 0x057C0C74  token: 0x6000B55
        public System.Boolean IsPending() { }
        // RVA: 0x057C0CC4  token: 0x6000B56
        public System.Void SwapTo(Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* other) { }

    }

    // TypeToken: 0x2000237  // size: 0x3C
    public sealed struct LogicStateConfig
    {
        // Fields
        public UnityEngine.Color color;  // 0x10
        public System.Single intensity;  // 0x20
        public System.Single alpha;  // 0x24
        public System.Single flowAlpha;  // 0x28
        public UnityEngine.Color c;  // 0x2c

        // Methods
        // RVA: 0x05800CC4  token: 0x6000C12
        private System.Void _OnColorChanged() { }

    }

    // TypeToken: 0x200023F  // size: 0x11
    public sealed struct VATAnimatorRequestType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType SetParameter;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType PauseOrResume;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType SetSpeed;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType ForceSetState;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType SetStateLoop;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType Reset;  // const

    }

    // TypeToken: 0x2000240  // size: 0x28
    public sealed struct SetAnimatorParamRequest
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity renderEntity;  // 0x10
        public System.Boolean waitForStateFinish;  // 0x18
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestType type;  // 0x1c
        public System.Boolean isPause;  // 0x20
        public System.Single speed;  // 0x20
        public System.Int32 stateIndex;  // 0x20
        public System.Single stateProgress;  // 0x24
        public System.Boolean isStateLoop;  // 0x24
        public System.Int32 paramIndex;  // 0x20
        public System.Single paramValue;  // 0x24

        // Methods
        // RVA: 0x05800D58  token: 0x6000C45
        public System.Void SetParamToAnimator(Beyond.Gameplay.Factory.GlobalEnv* envPtr, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& fragment, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition* sharedDataPtr) { }

    }

    // TypeToken: 0x2000241  // size: 0x1C
    public sealed struct VATFSMAudioData
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity entity;  // 0x10
        public System.Int32 hashStateName;  // 0x18

    }

    // TypeToken: 0x200024E
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_index;  // 0x0
        private Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20<T> m_data;  // 0x0

        // Properties
        T Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C6A
        public System.Void .ctor(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20<T>& data, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000C6B
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000C6C
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x6000C6D
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x200024F  // size: 0x810
    public sealed struct <data>e__FixedBuffer
    {
        // Fields
        public System.Byte FixedElementField;  // 0x0

    }

    // TypeToken: 0x2000255  // size: 0xA9C
    public sealed struct Node
    {
        // Fields
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition value;  // 0x10
        public System.UInt32 next;  // 0x10

    }

    // TypeToken: 0x2000267  // size: 0x1C
    public sealed struct Allocation
    {
        // Fields
        public System.Int32 start;  // 0x10
        public System.Int32 end;  // 0x14
        public System.Boolean reallocated;  // 0x18

    }

    // TypeToken: 0x2000268  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Gameplay.Factory.Unsafe.LinearAllocator.<>c <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__10_0;  // static @ 0x8
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__10_1;  // static @ 0x10
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__18_0;  // static @ 0x18
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__18_1;  // static @ 0x20

        // Methods
        // RVA: 0x058018EC  token: 0x6000CEF
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000CF0
        public System.Void .ctor() { }
        // RVA: 0x058017CC  token: 0x6000CF1
        private System.Int32 <Allocate>b__10_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> b) { }
        // RVA: 0x058017FC  token: 0x6000CF2
        private System.Int32 <Allocate>b__10_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> b) { }
        // RVA: 0x0580182C  token: 0x6000CF3
        private System.Int32 <PrintAllocations>b__18_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> a) { }
        // RVA: 0x0580185C  token: 0x6000CF4
        private System.Int32 <PrintAllocations>b__18_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> b) { }

    }

    // TypeToken: 0x200026A  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged.<>c <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__20_1;  // static @ 0x8
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__20_0;  // static @ 0x10

        // Methods
        // RVA: 0x05801950  token: 0x6000D02
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000D03
        public System.Void .ctor() { }
        // RVA: 0x058018BC  token: 0x6000D04
        private System.Int32 <PrintAllocations>b__20_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> a) { }
        // RVA: 0x0580188C  token: 0x6000D05
        private System.Int32 <PrintAllocations>b__20_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> b) { }

    }

    // TypeToken: 0x200026F  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Methods
        // RVA: 0x02D041B0  token: 0x6000D22
        private static System.UInt32 ComputeStringHash(System.String s) { }

    }

    // TypeToken: 0x2000270  // size: 0x10
    public class __JobReflectionRegistrationOutput__3364214955
    {
        // Methods
        // RVA: 0x01138FB0  token: 0x6000D23
        public static System.Void CreateJobReflectionData() { }
        // RVA: 0x0113E6C0  token: 0x6000D24
        public static System.Void EarlyInit() { }

    }

    // TypeToken: 0x2000271  // size: 0x10
    public static class $BurstDirectCallInitializer
    {
        // Methods
        // RVA: 0x037FF630  token: 0x6000D25
        private static System.Void Initialize() { }

    }

namespace Beyond
{

    // TypeToken: 0x2000025
    public sealed struct FixedStack`1 : System.IDisposable
    {
        // Fields
        private T* m_items;  // 0x0
        private readonly System.Int32 m_capacity;  // 0x0
        private System.Int32 m_size;  // 0x0
        private System.Boolean m_disposed;  // 0x0

        // Properties
        System.Int32 count { get; /* RVA: -1  // not resolved */ }
        System.Int32 capacity { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        System.Boolean isFull { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000E3
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x60000E8
        public System.Void Push(T item) { }
        // RVA: -1  // not resolved  token: 0x60000E9
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60000EA
        public T Peek() { }
        // RVA: -1  // not resolved  token: 0x60000EB
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60000EC
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x2000026
    public sealed struct HGArray`1
    {
        // Fields
        private T* m_ptr;  // 0x0
        private readonly Unity.Collections.Allocator m_allocator;  // 0x0
        private System.UInt32 m_size;  // 0x0
        private System.UInt32 m_capacity;  // 0x0

        // Properties
        T& Item { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000ED
        public System.UInt32 Size() { }
        // RVA: -1  // not resolved  token: 0x60000EE
        public System.UInt32 Capacity() { }
        // RVA: -1  // not resolved  token: 0x60000EF
        public T* Ptr() { }
        // RVA: -1  // not resolved  token: 0x60000F0
        private System.Void _Grow(System.UInt32 targetSize) { }
        // RVA: -1  // not resolved  token: 0x60000F1
        public System.Void .ctor(Unity.Collections.Allocator label) { }
        // RVA: -1  // not resolved  token: 0x60000F2
        public System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60000F3
        public System.Void Resize(System.UInt32 newSize) { }
        // RVA: -1  // not resolved  token: 0x60000F4
        public System.Void PushBack(T& v0) { }
        // RVA: -1  // not resolved  token: 0x60000F5
        public System.Void PushBack(T v0) { }
        // RVA: -1  // not resolved  token: 0x60000F6
        public T& EmplaceBack() { }
        // RVA: -1  // not resolved  token: 0x60000F7
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60000F8
        public System.Void PopBack() { }
        // RVA: -1  // not resolved  token: 0x60000F9
        public T& Back() { }
        // RVA: -1  // not resolved  token: 0x60000FA
        public System.Void SwapAndPopBack(System.UInt32 indexA) { }
        // RVA: -1  // not resolved  token: 0x60000FB
        public System.Void Reserve(System.UInt32 newCapacity) { }
        // RVA: -1  // not resolved  token: 0x60000FE
        public System.Span<T> AsSpan() { }

    }

    // TypeToken: 0x2000027  // size: 0x10
    public static class AssetInstanceParseUtil
    {
        // Methods
        // RVA: 0x0578D3FC  token: 0x60000FF
        public static Unity.Collections.NativeArray<System.Int32> Parse(UnityEngine.Object[] objects) { }
        // RVA: 0x0578D4EC  token: 0x6000100
        public static System.Int32 Parse(UnityEngine.Object obj) { }
        // RVA: 0x031148C0  token: 0x6000101
        public static System.Object Get(System.Int32 id) { }
        // RVA: -1  // generic def  token: 0x6000102
        public static T Get(System.Int32 id) { }

    }

}

namespace Beyond.Gameplay
{

    // TypeToken: 0x200002E  // size: 0x178
    public class FactorySetting : UnityEngine.ScriptableObject
    {
        // Fields
        public Beyond.Gameplay.Factory.GlobalSharedData.CullingDisSetting cullingDisSetting;  // 0x18
        public Beyond.Gameplay.FactoryEffectSetting lowFactoryEffectSetting;  // 0x28
        public Beyond.Gameplay.FactoryEffectSetting midFactoryEffectSetting;  // 0x30
        public Beyond.Gameplay.FactoryEffectSetting highFactoryEffectSetting;  // 0x38
        public Beyond.Gameplay.FactoryEffectSetting highestFactoryEffectSetting;  // 0x40
        public System.Single uiEffectOffsetY;  // 0x48
        public System.Single uiFactoryOutputOffsetY;  // 0x4c
        public System.Single conveyorOffsetY;  // 0x50
        public System.Single conveyorPortBlockOffsetY;  // 0x54
        public System.Single pipePortBlockOffsetY;  // 0x58
        public System.Int32 outputPoolSize;  // 0x5c
        public System.Int32 buildingStatePoolSize;  // 0x60
        public System.Int32 portBlockPoolSize;  // 0x64
        public System.Int32 portArrowPoolSize;  // 0x68
        public System.Int32 cargoPoolSize;  // 0x6c
        public Unity.Mathematics.int3 conveyorPoolSize;  // 0x70
        public Unity.Mathematics.int3 pipePoolSize;  // 0x7c
        public Unity.Mathematics.int3 figurePoolSize;  // 0x88
        public System.Int32 figurePipeHolderPoolSize;  // 0x94
        public System.Int32 wirePoolSize;  // 0x98
        public System.Int32 pipeRendererMaxSize;  // 0x9c
        public System.Int32 portRendererMaxSize;  // 0xa0
        public System.Boolean disableSystemInterval;  // 0xa4
        public Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalSetting systemIntervalSetting;  // 0xa8
        public Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceSetting nearByDistanceSetting;  // 0xd0
        public Beyond.Gameplay.Factory.FactoryBaseColorLutConfig factoryLutConfig;  // 0xf0
        public Beyond.Gameplay.Factory.FFactoryStateColorConfig factoryStateIconColorConfig;  // 0xf8
        public FactoryUIAtlas.FactoryUIAtlasSOData factoryItemIconAtlasUVConfig;  // 0x118
        public FactoryUIAtlas.FactoryUIAtlasSOData factoryStateIconAtlasUVConfig;  // 0x120
        public FactoryUIAtlas.FactoryUIAtlasSOData factorySocialIconAtlasUVConfig;  // 0x128
        public FactoryUIAtlas.FactoryLiquidAtlasSOData factoryLiquidAtlasUVConfig;  // 0x130
        public UnityEngine.AnimationCurve buildCutoffYCurve;  // 0x138
        public UnityEngine.AnimationCurve buildAlphaCurveType0;  // 0x140
        public UnityEngine.AnimationCurve buildAlphaCurveType1;  // 0x148
        public UnityEngine.AnimationCurve repairCurve0;  // 0x150
        public UnityEngine.AnimationCurve repairCurve1;  // 0x158
        public System.Single buildingDither;  // 0x160
        public System.Single pedestalDither;  // 0x164
        public System.Single ditherTargetField;  // 0x168
        public System.Single ditherDistance;  // 0x16c
        public System.Single lowFrameRate;  // 0x170

        // Methods
        // RVA: 0x032BB410  token: 0x600010A
        private System.Void OnEnable() { }
        // RVA: 0x03D3A980  token: 0x600010B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002F  // size: 0x18
    public sealed struct FactoryEffectSetting
    {
        // Fields
        public System.Int32 maxEffectCount;  // 0x10
        public System.Single effectInterval;  // 0x14

    }

}

namespace Beyond.Gameplay.Factory
{

    // TypeToken: 0x2000030  // size: 0x10
    public static class Archetypes
    {
        // Properties
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> empty { get; /* RVA: 0x0241BE40 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> env { get; /* RVA: 0x02AE47C0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> connection { get; /* RVA: 0x027D0A00 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> buildingUnit { get; /* RVA: 0x0241D130 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> powerStation { get; /* RVA: 0x02D02A80 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> furnace { get; /* RVA: 0x02D049D0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> grinder { get; /* RVA: 0x02D04C00 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> winder { get; /* RVA: 0x02D06190 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> componentMc { get; /* RVA: 0x02D05310 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> shaper { get; /* RVA: 0x02D051E0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> fillingPowderMc { get; /* RVA: 0x02D056A0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> thickener { get; /* RVA: 0x02D04770 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> hub { get; /* RVA: 0x02D027B0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> subHub { get; /* RVA: 0x02D02960 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> miner { get; /* RVA: 0x02D04B00 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> toolsAssemblingMc { get; /* RVA: 0x02D05570 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> seedCollector { get; /* RVA: 0x02D02F80 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> planter { get; /* RVA: 0x02D048A0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> powerDiffuser { get; /* RVA: 0x02D04210 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> powerPole { get; /* RVA: 0x02D03140 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> travelPole { get; /* RVA: 0x02D030B0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> loader { get; /* RVA: 0x02D02840 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> unloader { get; /* RVA: 0x02D04690 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> storage { get; /* RVA: 0x02D02D60 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> powerTerminal { get; /* RVA: 0x0578D268 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> powerPort { get; /* RVA: 0x02D02BF0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> facBattle { get; /* RVA: 0x02D04D30 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pump { get; /* RVA: 0x02D02E80 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> liquidStorage { get; /* RVA: 0x02D062B0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> mixPool { get; /* RVA: 0x02D050B0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> squirter { get; /* RVA: 0x0578D314 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> dumper { get; /* RVA: 0x02D057D0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> liquidCleaner { get; /* RVA: 0x02D02B60 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> xiraniteOven { get; /* RVA: 0x02D05440 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> liquidPurifier { get; /* RVA: 0x02D05A20 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> dismantler { get; /* RVA: 0x0578CE18 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> hsBus { get; /* RVA: 0x02D02C80 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> hsBusSource { get; /* RVA: 0x02D028D0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> udPipeLoader { get; /* RVA: 0x02D04E10 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> udPipeUnloader { get; /* RVA: 0x02D04F60 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> liquidCleanGate { get; /* RVA: 0x0578CF48 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> liquidRecycleGate { get; /* RVA: 0x0578D030 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> carrier { get; /* RVA: 0x02D029F0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> marker { get; /* RVA: 0x02D02DF0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> decoration { get; /* RVA: 0x0578CAF8 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeConditioner { get; /* RVA: 0x02D058D0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> logConditioner { get; /* RVA: 0x0578D118 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> buildingFakeUnit { get; /* RVA: 0x02D06380 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> buildingRenderOnlyUnit { get; /* RVA: 0x02EB09E0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> buildingPreviewUnit { get; /* RVA: 0x02EAFED0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> buildingGuideHintUnit { get; /* RVA: 0x02EB06E0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> conveyor { get; /* RVA: 0x02768D50 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> guideConveyor { get; /* RVA: 0x0398B3E0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipe { get; /* RVA: 0x02C5E200 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeHolder { get; /* RVA: 0x02D05E90 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> cargo { get; /* RVA: 0x0241CBB0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> buildingRender { get; /* RVA: 0x02767720 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pedestalRender { get; /* RVA: 0x02768FF0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> conveyorLeftRender { get; /* RVA: 0x02C5D2B0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> conveyorRightRender { get; /* RVA: 0x02C5CEC0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> conveyorMidRender { get; /* RVA: 0x02C5DDE0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> figurePipeHolderRender { get; /* RVA: 0x0365A400 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> figureLeftRender { get; /* RVA: 0x0365A5E0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> figureRightRender { get; /* RVA: 0x0365A7C0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> figureMidRender { get; /* RVA: 0x0365A9A0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> conveyorPreviewRender { get; /* RVA: 0x037F78C0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipePreviewRender { get; /* RVA: 0x038755D0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeComRender { get; /* RVA: 0x02C5D6A0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeLeftRender { get; /* RVA: 0x02C5CAA0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeMidRender { get; /* RVA: 0x02C5DFF0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeRightRender { get; /* RVA: 0x02C5CCB0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeTrackLeftPreviewRender { get; /* RVA: 0x02C5BF60 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeTrackMidPreviewRender { get; /* RVA: 0x02C5C140 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> pipeTrackRightPreviewRender { get; /* RVA: 0x02C5C320 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> outputUIRenderer { get; /* RVA: 0x0388E780 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> wireRenderer { get; /* RVA: 0x02C5EDE0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> unitStatusUIRenderer { get; /* RVA: 0x0388EAD0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> portPreviewUIRenderer { get; /* RVA: 0x036F9360 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> gridRenderer { get; /* RVA: 0x037AFEB0 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> gridMainRegionRenderer { get; /* RVA: 0x037B0090 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> portStatusUIRenderer { get; /* RVA: 0x0388EE10 */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> scope { get; /* RVA: 0x02D07070 */ }

        // Methods
        // RVA: 0x02D042A0  token: 0x600015E
        public static Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> CreateArchetype(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> baseArchetype, UnityEngine.HyperGryph.ECS.ComponentType[] extraTypes) { }
        // RVA: 0x02D031D0  token: 0x600015F
        public static Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> Select(System.String templateId) { }

    }

    // TypeToken: 0x2000031
    public sealed struct AdditiveEffectRequestStack`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.AdditiveEffectRequestStack.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000164
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000165
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000166
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000167
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000168
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000169
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x600016A
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600016B
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x600016C
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x600016D
        public T First() { }
        // RVA: -1  // not resolved  token: 0x600016E
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x600016F
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000170
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000171
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000173
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000174
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000175
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000176
        public Beyond.Gameplay.Factory.AdditiveEffectRequestStack.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000177
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000178
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600017A
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600017B
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600017C
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000034  // size: 0x28
    public sealed struct ConveyorExtContainer
    {
        // Fields
        private Beyond.HGArray<Beyond.Gameplay.Factory.ConveyorExtContainer.Node> m_nodes;  // 0x10

        // Properties
        Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& Item { get; /* RVA: 0x0578DBC0 */ }
        Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& Item { get; /* RVA: 0x0578DBC0 */ }

        // Methods
        // RVA: 0x02C34C80  token: 0x6000183
        public System.Void .ctor(Unity.Collections.Allocator allocator) { }
        // RVA: 0x0578DA14  token: 0x6000184
        public System.Void Dispose() { }
        // RVA: 0x0578DB5C  token: 0x6000185
        public System.UInt32 Size() { }
        // RVA: 0x0578D8D8  token: 0x6000186
        public System.Span<Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt> AsSpan() { }
        // RVA: 0x02A8F6B0  token: 0x6000187
        public System.UInt32 Create(Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& value) { }
        // RVA: 0x0578D988  token: 0x6000188
        public System.Void Destroy(System.UInt32 handle) { }
        // RVA: 0x02C34B70  token: 0x6000189
        public System.Void Reset() { }
        // RVA: 0x0578DADC  token: 0x600018A
        public System.Void Reserve(System.UInt32 newCapacity) { }
        // RVA: 0x026DE950  token: 0x600018B
        public System.IntPtr Data() { }
        // RVA: 0x0578DA7C  token: 0x600018E
        public Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& Get(System.UInt32 handle) { }

    }

    // TypeToken: 0x2000037  // size: 0x48
    public sealed struct ConveyorInfoAllocator
    {
        // Fields
        private Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged m_allocator;  // 0x10

        // Properties
        System.Void* memoryPtr { get; /* RVA: 0x0578DCE0 */ }

        // Methods
        // RVA: 0x03281030  token: 0x6000190
        public static Beyond.Gameplay.Factory.ConveyorInfoAllocator* Create(System.Int32 capacity) { }
        // RVA: 0x0578DC54  token: 0x6000191
        public static System.Void Destroy(Beyond.Gameplay.Factory.ConveyorInfoAllocator* allocator) { }
        // RVA: 0x02A8E070  token: 0x6000192
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 count) { }
        // RVA: 0x039B16D0  token: 0x6000193
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation allocation, System.Int32 newCount) { }
        // RVA: 0x0578DC80  token: 0x6000194
        public System.Void Free(System.UInt32 memoryOffset) { }
        // RVA: 0x02A90290  token: 0x6000195
        public System.Int64 CalculateSize(System.UInt32 memoryOffset) { }
        // RVA: 0x0427032C  token: 0x6000196
        public Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info* GetInfo(System.Int64 offset) { }
        // RVA: 0x0578DC04  token: 0x6000198
        public System.Void DebugPrint() { }

    }

    // TypeToken: 0x2000039
    public sealed struct Data2`1
    {
        // Fields
        public T port0;  // 0x0
        public T port1;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

    }

    // TypeToken: 0x200003A
    public sealed struct Data4`1
    {
        // Fields
        public Beyond.Gameplay.Factory.Data2<T> port0;  // 0x0
        public Beyond.Gameplay.Factory.Data2<T> port1;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

    }

    // TypeToken: 0x200003B
    public sealed struct Data8`1
    {
        // Fields
        public Beyond.Gameplay.Factory.Data4<T> port0;  // 0x0
        public Beyond.Gameplay.Factory.Data4<T> port1;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

    }

    // TypeToken: 0x200003C
    public sealed struct Data16`1
    {
        // Fields
        public Beyond.Gameplay.Factory.Data8<T> port0;  // 0x0
        public Beyond.Gameplay.Factory.Data8<T> port1;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

    }

    // TypeToken: 0x200003D
    public sealed struct Data32`1
    {
        // Fields
        public Beyond.Gameplay.Factory.Data16<T> port0;  // 0x0
        public Beyond.Gameplay.Factory.Data16<T> port1;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

    }

    // TypeToken: 0x200003E
    public sealed struct EntityData4`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData4.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001AC
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60001AD
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60001AE
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60001AF
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60001B0
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60001B1
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60001B2
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60001B3
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60001B4
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60001B5
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60001B6
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60001B7
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60001B8
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001B9
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60001BB
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60001BC
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60001BD
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60001BE
        public Beyond.Gameplay.Factory.EntityData4.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60001BF
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60001C0
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60001C2
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001C3
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001C4
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000041
    public sealed struct EntityData8`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData8.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001CF
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60001D0
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60001D1
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60001D2
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60001D3
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60001D4
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60001D5
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60001D6
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60001D7
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60001D8
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60001D9
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60001DA
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60001DB
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001DC
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60001DE
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60001DF
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60001E0
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60001E1
        public Beyond.Gameplay.Factory.EntityData8.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60001E2
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60001E3
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60001E5
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001E6
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001E7
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000044
    public sealed struct EntityData32`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData32.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60001F2
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60001F3
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60001F4
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60001F5
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60001F6
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60001F7
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60001F8
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60001F9
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60001FA
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60001FB
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60001FC
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60001FD
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60001FE
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60001FF
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000201
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000202
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000203
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000204
        public Beyond.Gameplay.Factory.EntityData32.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000205
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000206
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000208
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000209
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600020A
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000047
    public sealed struct EntityData64`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData64.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000215
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000216
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000217
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000218
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000219
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x600021A
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x600021B
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600021C
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x600021D
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x600021E
        public T First() { }
        // RVA: -1  // not resolved  token: 0x600021F
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000220
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000221
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000222
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000224
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000225
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000226
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000227
        public Beyond.Gameplay.Factory.EntityData64.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000228
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000229
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600022B
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600022C
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600022D
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200004A
    public sealed struct EntityData128`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData128.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000238
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000239
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x600023A
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x600023B
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600023C
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x600023D
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x600023E
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600023F
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000240
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000241
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000242
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000243
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000244
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000245
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000247
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000248
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000249
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600024A
        public Beyond.Gameplay.Factory.EntityData128.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600024B
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600024C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600024E
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600024F
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000250
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200004D
    public sealed struct EntityData256`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData256.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600025B
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x600025C
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x600025D
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x600025E
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600025F
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000260
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000261
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000262
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000263
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000264
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000265
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000266
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000267
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000268
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x600026A
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600026B
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x600026C
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600026D
        public Beyond.Gameplay.Factory.EntityData256.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600026E
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600026F
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000271
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000272
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000273
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000050
    public sealed struct EntityData512`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData512.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600027E
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x600027F
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000280
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000281
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000282
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000283
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000284
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000285
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000286
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000287
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000288
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000289
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x600028A
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600028B
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x600028D
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600028E
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x600028F
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000290
        public Beyond.Gameplay.Factory.EntityData512.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000291
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000292
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000294
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000295
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000296
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000053
    public sealed struct EntityData1024`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.EntityData1024.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002A1
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60002A2
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60002A3
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60002A4
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60002A5
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60002A6
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60002A7
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60002A8
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60002A9
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60002AA
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60002AB
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60002AC
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60002AD
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002AE
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60002B0
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60002B1
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60002B2
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60002B3
        public Beyond.Gameplay.Factory.EntityData1024.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002B4
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002B5
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002B7
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002B8
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002B9
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000056
    public sealed struct Float4Data6`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.Float4Data6.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002C4
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60002C5
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60002C6
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60002C7
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60002C8
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60002C9
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60002CA
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60002CB
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60002CC
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60002CD
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60002CE
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60002CF
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60002D0
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002D1
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60002D3
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60002D4
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60002D5
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60002D6
        public Beyond.Gameplay.Factory.Float4Data6.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002D7
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002D8
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002DA
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002DB
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002DC
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000059
    public sealed struct Float4Data16`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.Float4Data16.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002E7
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60002E8
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60002E9
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60002EA
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60002EB
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60002EC
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60002ED
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60002EE
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60002EF
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60002F0
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60002F1
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60002F2
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60002F3
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002F4
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60002F6
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60002F7
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60002F8
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60002F9
        public Beyond.Gameplay.Factory.Float4Data16.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002FA
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002FB
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60002FD
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002FE
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60002FF
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200005C
    public sealed struct IntData8`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.IntData8.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600030A
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x600030B
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x600030C
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x600030D
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600030E
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x600030F
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000310
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000311
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000312
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000313
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000314
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000315
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000316
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000317
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000319
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600031A
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x600031B
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600031C
        public Beyond.Gameplay.Factory.IntData8.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600031D
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600031E
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000320
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000321
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000322
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200005F
    public sealed struct IntData32`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.IntData32.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600032D
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x600032E
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x600032F
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000330
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000331
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000332
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000333
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000334
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000335
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000336
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000337
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000338
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000339
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600033A
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x600033C
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600033D
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x600033E
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600033F
        public Beyond.Gameplay.Factory.IntData32.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000340
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000341
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000343
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000344
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000345
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000062  // size: 0x11
    public sealed struct LogisticsExtContainer
    {
    }

    // TypeToken: 0x2000064  // size: 0x38
    public sealed struct OutputRendererInfo
    {
        // Fields
        public Unity.Mathematics.float3 outputPos;  // 0x10
        public System.Boolean enableLiquidIcon;  // 0x1c
        public System.Boolean depthBlendDisabled;  // 0x1d
        public Unity.Mathematics.half4 color;  // 0x20
        public Unity.Mathematics.half4 atlasRect;  // 0x28
        public Unity.Mathematics.half4 liquidAtlasUV;  // 0x30

    }

    // TypeToken: 0x2000065
    public sealed struct PortData16`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PortData16.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000350
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000351
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000352
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000353
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000354
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000355
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000356
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000357
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000358
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000359
        public T First() { }
        // RVA: -1  // not resolved  token: 0x600035A
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x600035B
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x600035C
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600035D
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x600035F
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000360
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000361
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000362
        public Beyond.Gameplay.Factory.PortData16.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000363
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000364
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000366
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000367
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000368
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000068
    public sealed struct PortData32`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PortData32.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000373
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000374
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000375
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000376
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000377
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000378
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000379
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600037A
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x600037B
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x600037C
        public T First() { }
        // RVA: -1  // not resolved  token: 0x600037D
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x600037E
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x600037F
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000380
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000382
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000383
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000384
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000385
        public Beyond.Gameplay.Factory.PortData32.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000386
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000387
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000389
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600038A
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600038B
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200006B
    public sealed struct PortData128`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PortData128.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000396
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000397
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000398
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000399
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600039A
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x600039B
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x600039C
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600039D
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x600039E
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x600039F
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60003A0
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60003A1
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60003A2
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003A3
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60003A5
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60003A6
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60003A7
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60003A8
        public Beyond.Gameplay.Factory.PortData128.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60003A9
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60003AA
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60003AC
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003AD
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003AE
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200006E
    public sealed struct PortData256`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PortData256.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60003B9
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60003BA
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60003BB
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60003BC
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60003BD
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60003BE
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60003BF
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60003C0
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60003C1
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60003C2
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60003C3
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60003C4
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60003C5
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003C6
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60003C8
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60003C9
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60003CA
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60003CB
        public Beyond.Gameplay.Factory.PortData256.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60003CC
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60003CD
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60003CF
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003D0
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003D1
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000071  // size: 0x28
    public sealed struct SharedDataContainer
    {
        // Fields
        private Beyond.HGArray<Beyond.Gameplay.Factory.SharedDataContainer.Node> m_nodes;  // 0x10

        // Properties
        Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& Item { get; /* RVA: 0x057908D4 */ }
        Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& Item { get; /* RVA: 0x057908D4 */ }

        // Methods
        // RVA: 0x02C34BE0  token: 0x60003D8
        public System.Void .ctor(Unity.Collections.Allocator allocator) { }
        // RVA: 0x05790720  token: 0x60003D9
        public System.Void Dispose() { }
        // RVA: 0x05790870  token: 0x60003DA
        public System.UInt32 Size() { }
        // RVA: 0x05790670  token: 0x60003DB
        public System.Span<Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData> AsSpan() { }
        // RVA: 0x02755A20  token: 0x60003DC
        public System.UInt32 Create(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& value) { }
        // RVA: 0x03854130  token: 0x60003DD
        public System.Void Destroy(System.UInt32 handle) { }
        // RVA: 0x02C34B00  token: 0x60003DE
        public System.Void Reset() { }
        // RVA: 0x057907EC  token: 0x60003DF
        public System.Void Reserve(System.UInt32 newCapacity) { }
        // RVA: 0x026E4790  token: 0x60003E0
        public System.IntPtr Data() { }
        // RVA: 0x05790788  token: 0x60003E3
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& Get(System.UInt32 handle) { }

    }

    // TypeToken: 0x2000075  // size: 0x60
    public sealed struct StaticMountInfo
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity rendererEntity;  // 0x10
        public Beyond.Gameplay.Factory.FactoryUnitExtendConfig mountConfig;  // 0x18

    }

    // TypeToken: 0x2000076
    public sealed struct StaticMountInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.StaticMountInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60003E9
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x60003EE
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60003EF
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60003F0
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60003F1
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60003F2
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60003F3
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60003F4
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60003F5
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60003F6
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60003F7
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60003F8
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60003F9
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60003FA
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60003FB
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60003FD
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60003FE
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60003FF
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000400
        public Beyond.Gameplay.Factory.StaticMountInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000401
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000402
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000404
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000405
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000406
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000079
    public sealed struct UnitExtendConfig12`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.UnitExtendConfig12.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000411
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000412
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000413
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000414
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000415
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000416
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000417
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000418
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000419
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x600041A
        public T First() { }
        // RVA: -1  // not resolved  token: 0x600041B
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x600041C
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x600041D
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600041E
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000420
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000421
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000422
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000423
        public Beyond.Gameplay.Factory.UnitExtendConfig12.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000424
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000425
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000427
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000428
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000429
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200007C  // size: 0x40
    public sealed struct WireRendererInfo
    {
        // Fields
        public Unity.Mathematics.float3 fromPos;  // 0x10
        public Unity.Mathematics.float3 toPos;  // 0x1c
        public System.UInt64 connectionId;  // 0x28
        public System.Single alpha;  // 0x30

        // Properties
        Unity.Mathematics.float3 pos { get; /* RVA: 0x05790A00 */ }
        Unity.Mathematics.quaternion rot { get; /* RVA: 0x05790AC8 */ }
        System.Single scale { get; /* RVA: 0x05790C04 */ }

    }

    // TypeToken: 0x200007D
    public sealed struct WireRendererInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.WireRendererInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000433
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x6000438
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000439
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x600043A
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x600043B
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600043C
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x600043D
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x600043E
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600043F
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000440
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000441
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000442
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000443
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000444
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000445
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000447
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000448
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000449
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600044A
        public Beyond.Gameplay.Factory.WireRendererInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600044B
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600044C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600044E
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600044F
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000450
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000080  // size: 0x20
    public class EntitySearcher
    {
        // Fields
        private Unity.Collections.NativeParallelHashMap<Beyond.Gameplay.Factory.UnitId,UnityEngine.HyperGryph.ECS.Entity> m_logicEntityMap;  // 0x10

        // Methods
        // RVA: 0x0578F04C  token: 0x6000457
        public Unity.Collections.NativeParallelHashMap<Beyond.Gameplay.Factory.UnitId,UnityEngine.HyperGryph.ECS.Entity> GetLogicEntityMap() { }
        // RVA: 0x030EB410  token: 0x6000458
        public System.Void RegisterLogicEntity(System.Int32 chapterId, System.UInt32 nodeId, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: 0x0399FC10  token: 0x6000459
        public System.Boolean UnregisterLogicEntity(System.Int32 chapterId, System.UInt32 nodeId) { }
        // RVA: 0x024FC8E0  token: 0x600045A
        public System.Boolean GetLogicEntity(System.Int32 chapterId, System.UInt32 nodeId, UnityEngine.HyperGryph.ECS.Entity& entity) { }
        // RVA: 0x0578F0B4  token: 0x600045B
        private System.Void _DestroyAllEntities() { }
        // RVA: 0x0578EFFC  token: 0x600045C
        public System.Void DestroyAll() { }
        // RVA: 0x0350B670  token: 0x600045D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000081  // size: 0x10
    public static class MiscExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x600045E
        public static System.Void SafeDispose(Unity.Collections.NativeList<T> list) { }
        // RVA: -1  // generic def  token: 0x600045F
        public static System.Void SafeDispose(Unity.Collections.NativeArray<T> array) { }
        // RVA: -1  // generic def  token: 0x6000460
        public static System.Void SafeDispose(Unity.Collections.NativeQueue<T> queue) { }
        // RVA: -1  // generic def  token: 0x6000461
        public static System.Void SafeDispose(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list) { }
        // RVA: -1  // generic def  token: 0x6000462
        public static System.Void SafeDispose(Unity.Collections.NativeParallelHashMap<TKey,TValue> list) { }
        // RVA: -1  // generic def  token: 0x6000463
        public static System.Void SafeDispose(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey,TValue> list) { }

    }

    // TypeToken: 0x2000082  // size: 0x10
    public static class FactoryProfilerMakers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker S_PROFILER_PRE_EXECUTE;  // static @ 0x0
        public static readonly Unity.Profiling.ProfilerMarker S_PROFILER_EXECUTE;  // static @ 0x8
        public static readonly Unity.Profiling.ProfilerMarker S_PROFILER_FLUSH_REPEATER;  // static @ 0x10
        public static readonly Unity.Profiling.ProfilerMarker S_PROFILER_BLUEPRINT_UPDATE;  // static @ 0x18
        public static readonly Unity.Profiling.ProfilerMarker S_PROFILER_LATE_EXECUTE;  // static @ 0x20
        public static readonly Unity.Profiling.ProfilerMarker S_PROFILER_CLEAN;  // static @ 0x28
        public static readonly Unity.Profiling.ProfilerMarker S_MODIFY_REGION_NODES;  // static @ 0x30
        public static readonly Unity.Profiling.ProfilerMarker S_DITHER_PREPARE_ENTITY_POS;  // static @ 0x38
        public static readonly Unity.Profiling.ProfilerMarker S_SEARCH_DITHER_ENTITY;  // static @ 0x40
        public static readonly Unity.Profiling.ProfilerMarker S_EXECUTE_DITHER;  // static @ 0x48
        public static readonly Unity.Profiling.ProfilerMarker S_PROTO_LOGISTIC;  // static @ 0x50
        public static readonly Unity.Profiling.ProfilerMarker S_PROTO_EXECUTE_LOGISTIC_EFFECT;  // static @ 0x58
        public static readonly Unity.Profiling.ProfilerMarker S_PROTO_CARGO;  // static @ 0x60
        public static readonly Unity.Profiling.ProfilerMarker S_PROTO_PARSE_CARGO;  // static @ 0x68
        public static readonly Unity.Profiling.ProfilerMarker S_PROTO_PARSE_CARGO_PREPARE;  // static @ 0x70
        public static readonly Unity.Profiling.ProfilerMarker S_CARGO_ENQUEUE;  // static @ 0x78
        public static readonly Unity.Profiling.ProfilerMarker S_CARGO_DEQUEUE;  // static @ 0x80
        public static readonly Unity.Profiling.ProfilerMarker S_CARGO_ADJUST;  // static @ 0x88
        public static readonly Unity.Profiling.ProfilerMarker S_ECS_INSTANCE;  // static @ 0x90
        public static readonly Unity.Profiling.ProfilerMarker S_TRY_NUM_TO_STR_ITEM;  // static @ 0x98
        public static readonly Unity.Profiling.ProfilerMarker S_TRY_STR_TO_NUM_ITEM;  // static @ 0xa0

        // Methods
        // RVA: 0x0380A1F0  token: 0x6000464
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x10
    public static class FactorySharedDataManager
    {
        // Fields
        private static Beyond.Gameplay.Factory.ConveyorExtContainer s_conveyorExtData;  // static @ 0x0
        private static Beyond.Gameplay.Factory.SharedDataContainer s_sharedData;  // static @ 0x18
        private static UnityEngine.HyperGryph.ECS.EntityHierarchyContainer s_hierarchy;  // static @ 0x30
        private static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer s_vatFsm;  // static @ 0x38

        // Methods
        // RVA: 0x02C34620  token: 0x6000465
        public static System.Void InitExtData() { }
        // RVA: 0x02C34790  token: 0x6000466
        public static System.Void ResetExtData() { }
        // RVA: 0x0578F410  token: 0x6000467
        public static System.Void ReleaseExtData() { }
        // RVA: 0x02A8DF80  token: 0x6000468
        public static System.UInt32 CreateConveyorExtHandle() { }
        // RVA: 0x0578F314  token: 0x6000469
        public static System.Void DestroyConveyorExtHandle(System.UInt32 handle) { }
        // RVA: 0x023F8A80  token: 0x600046A
        public static Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& GetConveyorExt(System.UInt32 handle) { }
        // RVA: 0x026DE8A0  token: 0x600046B
        public static System.IntPtr GetConveyorExtData() { }
        // RVA: 0x02755910  token: 0x600046C
        public static System.UInt32 CreateSharedData(System.Boolean adjustMapValid) { }
        // RVA: 0x024FD550  token: 0x600046D
        public static Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetSharedData(System.UInt32 handle) { }
        // RVA: 0x038540C0  token: 0x600046E
        public static System.Void DestroySharedData(System.UInt32 handle) { }
        // RVA: 0x026E4640  token: 0x600046F
        public static System.IntPtr GetSharedData() { }
        // RVA: 0x02765460  token: 0x6000470
        public static System.UInt32 CreateTransHierarchy() { }
        // RVA: 0x02769FE0  token: 0x6000471
        public static UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& GetHierarchyData(System.UInt32 handle) { }
        // RVA: 0x02767640  token: 0x6000472
        public static UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& GetHierarchyData(System.Int32 handle) { }
        // RVA: 0x0578F4CC  token: 0x6000473
        public static Unity.Mathematics.float4x4 WorldTrans(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& transform) { }
        // RVA: 0x02AADB20  token: 0x6000474
        public static System.Void DestroyHierarchyData(System.UInt32 handle) { }
        // RVA: 0x026E0B00  token: 0x6000475
        public static System.IntPtr GetHierarchyData() { }
        // RVA: 0x02C349B0  token: 0x6000476
        public static System.UInt32 CreateVATFSMDefinitionContainer(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& definition) { }
        // RVA: 0x031A8A30  token: 0x6000477
        public static Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& GetVATFSMDefinition(System.UInt32 handle) { }
        // RVA: 0x0578F390  token: 0x6000478
        public static System.Void DestroyVATFSMDefinition(System.UInt32 handle) { }
        // RVA: 0x027DA610  token: 0x6000479
        public static System.IntPtr GetVATFSMDefinition() { }

    }

    // TypeToken: 0x2000084  // size: 0x7B8
    public sealed struct AdditiveEffectFragment
    {
        // Fields
        public System.Byte entityType;  // 0x10
        public System.UInt32 lightMode;  // 0x14
        public Beyond.Gameplay.Factory.SoloSelectState soloSelectState;  // 0x18
        public Beyond.Gameplay.Factory.BuildDismissState buildDismissState;  // 0x20
        public Beyond.Gameplay.Factory.CutoffState cutoffState;  // 0x38
        public Beyond.Gameplay.Factory.RepairState repairState;  // 0x48
        public Beyond.Gameplay.Factory.HighLightState highLightState;  // 0x70
        public Beyond.Gameplay.Factory.HintState hintState;  // 0xfc
        public Beyond.Gameplay.Factory.FigureState figureState;  // 0x108
        public Beyond.Gameplay.Factory.OverloadState overloadState;  // 0x114
        public Beyond.Gameplay.Factory.OverloadInvalidState overloadInvalidState;  // 0x120
        public Beyond.Gameplay.Factory.BlueprintState blueprintState;  // 0x130
        public Beyond.Gameplay.Factory.PreSelectState preSelectState;  // 0x360
        public Beyond.Gameplay.Factory.ContinuationState continuationState;  // 0x562
        public Beyond.Gameplay.Factory.SocialSharingState socialSharingState;  // 0x764
        public Beyond.Gameplay.Factory.PowerInteractionState powerInteractionState;  // 0x765
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.Request curEffectRequest;  // 0x766
        public Beyond.Gameplay.Factory.AdditiveEffectRequestStack<Beyond.Gameplay.Factory.AdditiveEffectFragment.Request> stateWaitStack;  // 0x76c

        // Properties
        Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType curEffectType { get; /* RVA: 0x03D55980 */ set; /* RVA: 0x03D55990 */ }

        // Methods
        // RVA: 0x02CBAB50  token: 0x600047C
        public System.Void PushState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state) { }
        // RVA: 0x02CB9D20  token: 0x600047D
        public System.Void InsertState(System.Int32 index, Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state) { }
        // RVA: 0x05790EB0  token: 0x600047E
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType ShiftState() { }
        // RVA: 0x05790E08  token: 0x600047F
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType PopState() { }
        // RVA: 0x02CBA770  token: 0x6000480
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType PeekState() { }
        // RVA: 0x02CBA690  token: 0x6000481
        public System.Void DisableState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state) { }
        // RVA: 0x02CBAC10  token: 0x6000482
        private System.Void _Shrink() { }
        // RVA: 0x05790F3C  token: 0x6000483
        public virtual System.String ToString() { }
        // RVA: 0x05791080  token: 0x6000484
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000087  // size: 0x20
    public sealed struct CutoffState
    {
        // Fields
        private System.Boolean m_enable;  // 0x10
        public System.UInt32 mode;  // 0x14
        public System.Single cutOffY;  // 0x18
        private System.Boolean <enable>k__BackingField;  // 0x1c

        // Properties
        System.Boolean enable { get; /* RVA: 0x03D516E0 */ set; /* RVA: 0x03D51700 */ }

        // Methods
        // RVA: 0x057946C8  token: 0x6000487
        public System.Void SetEnable(System.Boolean v) { }
        // RVA: 0x0579465C  token: 0x6000488
        public System.Void SetCutoffY(System.Single v) { }
        // RVA: 0x05794720  token: 0x6000489
        public System.Void SetMode(System.UInt32 v) { }

    }

    // TypeToken: 0x2000088  // size: 0x28
    public sealed struct BuildDismissState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Boolean started;  // 0x11
        public System.Boolean build;  // 0x12
        public System.Byte effectType;  // 0x13
        public System.Single duration;  // 0x14
        public System.Single startY;  // 0x18
        public System.Single deltaY;  // 0x1c
        public System.Int64 startTms;  // 0x20

        // Methods
        // RVA: 0x05791AA0  token: 0x600048A
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x200008A  // size: 0x38
    public sealed struct RepairState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public Beyond.Gameplay.Factory.RepairState0 state0;  // 0x18
        public Beyond.Gameplay.Factory.RepairState1 state1;  // 0x28

    }

    // TypeToken: 0x200008B  // size: 0x20
    public sealed struct RepairState0
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Single duration;  // 0x14
        public System.Int64 startTms;  // 0x18

    }

    // TypeToken: 0x200008C  // size: 0x20
    public sealed struct RepairState1
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Single duration;  // 0x14
        public System.Int64 startTms;  // 0x18

    }

    // TypeToken: 0x200008D  // size: 0x9C
    public sealed struct HighLightState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Boolean invalid;  // 0x11
        public System.Boolean social;  // 0x12
        public Unity.Collections.FixedList128Bytes<System.Byte> indexList;  // 0x14
        public Beyond.Gameplay.Factory.DitherState ditherState;  // 0x94

        // Methods
        // RVA: 0x037F7B20  token: 0x600048B
        public System.Void SetEnable(System.Boolean isEnable) { }
        // RVA: 0x02CBA620  token: 0x600048C
        public System.Void SetData(System.Boolean isInvalid, System.Boolean isSocial) { }
        // RVA: 0x057983B8  token: 0x600048D
        public Beyond.Gameplay.Factory.LogicEntityState GetEffectType() { }
        // RVA: 0x057984FC  token: 0x600048E
        public System.Boolean IsHighlight(System.Byte index) { }
        // RVA: 0x0579841C  token: 0x600048F
        public System.Void HighlightWithSubIndex(System.Byte index, System.Boolean en) { }
        // RVA: 0x02CBA5C0  token: 0x6000490
        public System.Void ClearHighlightableIndexList() { }

    }

    // TypeToken: 0x200008E  // size: 0x1C
    public sealed struct HintState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Boolean showSelf;  // 0x11
        public Beyond.Gameplay.Factory.DitherState ditherState;  // 0x14

        // Methods
        // RVA: 0x057985AC  token: 0x6000491
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x200008F  // size: 0x1C
    public sealed struct FigureState
    {
        // Fields
        public System.Boolean valid;  // 0x10
        public System.Boolean enable;  // 0x11
        public Beyond.Gameplay.Factory.DitherState ditherState;  // 0x14

        // Methods
        // RVA: 0x05795C50  token: 0x6000492
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x2000090  // size: 0x1C
    public sealed struct OverloadState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public Beyond.Gameplay.Factory.DitherState ditherState;  // 0x14

        // Methods
        // RVA: 0x0579961C  token: 0x6000493
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x2000091  // size: 0x1C
    public sealed struct OverloadInvalidState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public Beyond.Gameplay.Factory.DitherState ditherState;  // 0x14

        // Methods
        // RVA: 0x057995C4  token: 0x6000494
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x2000092  // size: 0x18
    public sealed struct DitherState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Single ditherVal;  // 0x14

        // Methods
        // RVA: 0x05794884  token: 0x6000495
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x2000093  // size: 0x240
    public sealed struct BlueprintState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public Beyond.Gameplay.Factory.BlueprintState.EffectType effectType;  // 0x11
        public Unity.Collections.FixedList512Bytes<System.Byte> indexList;  // 0x12
        public Beyond.Gameplay.Factory.CutoffState cutoffState;  // 0x214
        public Beyond.Gameplay.Factory.BuildDismissState buildState;  // 0x228

        // Methods
        // RVA: 0x02422A20  token: 0x6000496
        public System.Void SetEnable(System.Boolean v) { }
        // RVA: 0x024229D0  token: 0x6000497
        public System.Void SetEnable(System.Boolean v, Beyond.Gameplay.Factory.BlueprintState.EffectType type) { }
        // RVA: 0x057919F0  token: 0x6000498
        public System.Boolean IsLighten(System.Byte index) { }
        // RVA: 0x0361E700  token: 0x6000499
        public System.Void LightenWithSubIndex(System.Byte index, System.Boolean en) { }
        // RVA: 0x02422650  token: 0x600049A
        public System.Void ClearLightenIndexList() { }

    }

    // TypeToken: 0x2000095  // size: 0x212
    public sealed struct PreSelectState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public Unity.Collections.FixedList512Bytes<System.Byte> indexList;  // 0x12

        // Methods
        // RVA: 0x037F7AE0  token: 0x600049B
        public System.Void SetEnable(System.Boolean v) { }
        // RVA: 0x0579AD30  token: 0x600049C
        public System.Boolean IsLighten(System.Byte index) { }
        // RVA: 0x0579ADE0  token: 0x600049D
        public System.Void LightenWithSubIndex(System.Byte index, System.Boolean en) { }
        // RVA: 0x0579ACBC  token: 0x600049E
        public System.Void ClearLightenIndexList() { }

    }

    // TypeToken: 0x2000096  // size: 0x18
    public sealed struct SoloSelectState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.Int32 selectedIndex;  // 0x14

        // Methods
        // RVA: 0x0579B3A8  token: 0x600049F
        public System.Void SetEnable(System.Boolean v) { }
        // RVA: 0x0579B348  token: 0x60004A0
        public System.Boolean IsLighten(System.Int32 index) { }

    }

    // TypeToken: 0x2000097  // size: 0x212
    public sealed struct ContinuationState
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public Unity.Collections.FixedList512Bytes<System.Byte> indexList;  // 0x12

        // Methods
        // RVA: 0x037F7AA0  token: 0x60004A1
        public System.Void SetEnable(System.Boolean v) { }
        // RVA: 0x05793830  token: 0x60004A2
        public System.Boolean IsLighten(System.Byte index) { }
        // RVA: 0x057938E0  token: 0x60004A3
        public System.Void LightenWithSubIndex(System.Byte index, System.Boolean en) { }
        // RVA: 0x057937BC  token: 0x60004A4
        public System.Void ClearLightenIndexList() { }

    }

    // TypeToken: 0x2000098  // size: 0x11
    public sealed struct SocialSharingState
    {
        // Fields
        public System.Boolean enable;  // 0x10

        // Methods
        // RVA: 0x0579B2F0  token: 0x60004A5
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x2000099  // size: 0x11
    public sealed struct PowerInteractionState
    {
        // Fields
        public System.Boolean enable;  // 0x10

        // Methods
        // RVA: 0x0579AC64  token: 0x60004A6
        public System.Void SetEnable(System.Boolean v) { }

    }

    // TypeToken: 0x200009A  // size: 0x22
    public sealed struct AdditiveEffectRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean anyEffectStateChanged;  // 0x10
        private System.Boolean m_buildDismissEnabledState;  // 0x11
        private System.Boolean m_blueprintBuildEnabledState;  // 0x12
        private System.Boolean m_blueprintBuildCutoffYEnabledState;  // 0x13
        private System.Boolean m_cutOffYIgnoredState;  // 0x14
        private System.Boolean m_cutoffYEnabledState;  // 0x15
        private System.Boolean m_highLightEnabledState;  // 0x16
        private System.Boolean m_figureEnabledState;  // 0x17
        private System.Boolean m_hintEnabledState;  // 0x18
        private System.Boolean m_overloadEnabledState;  // 0x19
        private System.Boolean m_overloadInvalidEnabledState;  // 0x1a
        private System.Boolean m_repair0EnabledState;  // 0x1b
        private System.Boolean m_repair1EnabledState;  // 0x1c
        private System.Boolean m_blueprintEnabledState;  // 0x1d
        private System.Boolean m_preSelectEnabledState;  // 0x1e
        private System.Boolean m_continuationEnabledState;  // 0x1f
        private System.Boolean m_socialSharingEnabledState;  // 0x20
        private System.Boolean m_powerInteractionEnabledState;  // 0x21
        public static System.Int32 ID;  // const

        // Properties
        System.Boolean buildDismissEnabled { get; /* RVA: 0x03D559E0 */ set; /* RVA: 0x057912D8 */ }
        System.Boolean blueprintBuildEnabled { get; /* RVA: 0x03D559C0 */ set; /* RVA: 0x057912C0 */ }
        System.Boolean blueprintBuildCutoffYEnabled { get; /* RVA: 0x03D559B0 */ set; /* RVA: 0x057912B4 */ }
        System.Boolean cutOffYIgnored { get; /* RVA: 0x03D55A00 */ set; /* RVA: 0x057912F0 */ }
        System.Boolean cutoffYEnabled { get; /* RVA: 0x03D55A10 */ set; /* RVA: 0x057912FC */ }
        System.Boolean highLightEnabled { get; /* RVA: 0x03D55A30 */ set; /* RVA: 0x05791314 */ }
        System.Boolean figureEnabled { get; /* RVA: 0x03D55A20 */ set; /* RVA: 0x05791308 */ }
        System.Boolean hintEnabled { get; /* RVA: 0x03D557D0 */ set; /* RVA: 0x05791320 */ }
        System.Boolean overloadEnabled { get; /* RVA: 0x03D55A40 */ set; /* RVA: 0x0579132C */ }
        System.Boolean overloadInvalidEnabled { get; /* RVA: 0x03D55A50 */ set; /* RVA: 0x05791338 */ }
        System.Boolean repair0Enabled { get; /* RVA: 0x03D55A70 */ set; /* RVA: 0x0579135C */ }
        System.Boolean repair1Enabled { get; /* RVA: 0x03D516E0 */ set; /* RVA: 0x05791368 */ }
        System.Boolean blueprintEnabled { get; /* RVA: 0x03D559D0 */ set; /* RVA: 0x057912CC */ }
        System.Boolean preSelectEnabled { get; /* RVA: 0x03D55A60 */ set; /* RVA: 0x05791350 */ }
        System.Boolean continuationEnabled { get; /* RVA: 0x03D559F0 */ set; /* RVA: 0x057912E4 */ }
        System.Boolean socialSharingEnabled { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x05791374 */ }
        System.Boolean powerInteractionEnabled { get; /* RVA: 0x03D510E0 */ set; /* RVA: 0x05791344 */ }
        System.Boolean anyEffect { get; /* RVA: 0x05791200 */ }
        System.Int32 id { get; /* RVA: 0x01168950 */ }

        // Methods
        // RVA: 0x057910E0  token: 0x60004CB
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200009B  // size: 0x1C
    public sealed struct BattleFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean overload;  // 0x10
        public System.Single currentEnergy;  // 0x14
        public System.Single maxEnergy;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x02102C70 */ }

        // Methods
        // RVA: 0x0579149C  token: 0x60004CD
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200009C  // size: 0x1018
    public sealed struct BindRenderEntityFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.EntityData512<UnityEngine.HyperGryph.ECS.Entity> renderEntities;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D555E0 */ }

        // Methods
        // RVA: 0x02429600  token: 0x60004CE
        public System.Void BindRenderEntity(UnityEngine.HyperGryph.ECS.Entity renderEntity) { }
        // RVA: 0x057915B8  token: 0x60004CF
        public System.Void BindRenderEntities(UnityEngine.HyperGryph.ECS.Entity[] renderEntityList) { }
        // RVA: 0x05791648  token: 0x60004D0
        public System.Void BindRenderEntities(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> renderEntityList) { }
        // RVA: 0x0579179C  token: 0x60004D1
        public System.Void UnbindRenderEntity(UnityEngine.HyperGryph.ECS.Entity renderEntity) { }
        // RVA: 0x02603DB0  token: 0x60004D2
        public System.Void ClearBindRenderEntities() { }
        // RVA: 0x02429680  token: 0x60004D3
        public System.Boolean Binded(UnityEngine.HyperGryph.ECS.Entity renderEntity) { }
        // RVA: 0x027D9720  token: 0x60004D4
        public System.Boolean HasRenderer() { }
        // RVA: 0x057918A4  token: 0x60004D6
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200009D  // size: 0x60
    public sealed struct BurnPowerFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 currentLeastProgress;  // 0x10
        public System.Int64 powerGenPerSec;  // 0x18
        public Unity.Collections.FixedString64Bytes burningItemId;  // 0x20
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D50CD0 */ }

        // Methods
        // RVA: 0x05791AF8  token: 0x60004D8
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200009E  // size: 0x11
    public sealed struct BusFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D51100 */ }

        // Methods
        // RVA: 0x05791C1C  token: 0x60004DA
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200009F  // size: 0x12
    public sealed struct BusFreeFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean connectToStart;  // 0x10
        public System.Boolean enabled;  // 0x11
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D51110 */ }

        // Methods
        // RVA: 0x05791D28  token: 0x60004DC
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000A0  // size: 0x3A0
    public sealed struct CacheFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        private static System.Int32 CONTAINER_OFFSET;  // const
        private static System.Int32 ITEM_SIZE;  // const
        public Beyond.Gameplay.Factory.CacheFragment.<cacheSizePtr>e__FixedBuffer cacheSizePtr;  // 0x10
        public System.Byte cacheIn0Size;  // 0x10
        public System.Byte cacheIn1Size;  // 0x11
        public System.Byte cacheIn2Size;  // 0x12
        public System.Byte cacheIn3Size;  // 0x13
        public System.Byte cacheOut0Size;  // 0x14
        public System.Byte cacheOut1Size;  // 0x15
        public System.Byte cacheOut2Size;  // 0x16
        public System.Byte cacheOut3Size;  // 0x17
        public Beyond.Gameplay.Factory.CacheFragment.<cacheFluidSizePtr>e__FixedBuffer cacheFluidSizePtr;  // 0x18
        public System.Byte cacheFluidIn0Size;  // 0x18
        public System.Byte cacheFluidIn1Size;  // 0x19
        public System.Byte cacheFluidIn2Size;  // 0x1a
        public System.Byte cacheFluidIn3Size;  // 0x1b
        public System.Byte cacheFluidOut0Size;  // 0x1c
        public System.Byte cacheFluidOut1Size;  // 0x1d
        public System.Byte cacheFluidOut2Size;  // 0x1e
        public System.Byte cacheFluidOut3Size;  // 0x1f
        public Beyond.Gameplay.Factory.CacheFragment.<cacheContentPtr>e__FixedBuffer cacheContentPtr;  // 0x20
        public Beyond.Gameplay.Factory.CacheFragment.<itemInPtr>e__FixedBuffer itemInPtr;  // 0x20
        public Beyond.Gameplay.Factory.FactoryItem in0;  // 0x20
        public Beyond.Gameplay.Factory.FactoryItem in1;  // 0x30
        public Beyond.Gameplay.Factory.FactoryItem in2;  // 0x40
        public Beyond.Gameplay.Factory.FactoryItem in3;  // 0x50
        public Beyond.Gameplay.Factory.FactoryItem in4;  // 0x60
        public Beyond.Gameplay.Factory.FactoryItem in5;  // 0x70
        public Beyond.Gameplay.Factory.FactoryItem in6;  // 0x80
        public Beyond.Gameplay.Factory.FactoryItem in7;  // 0x90
        public Beyond.Gameplay.Factory.CacheFragment.<itemOutPtr>e__FixedBuffer itemOutPtr;  // 0xa0
        public Beyond.Gameplay.Factory.FactoryItem out0;  // 0xa0
        public Beyond.Gameplay.Factory.FactoryItem out1;  // 0xb0
        public Beyond.Gameplay.Factory.FactoryItem out2;  // 0xc0
        public Beyond.Gameplay.Factory.FactoryItem out3;  // 0xd0
        public Beyond.Gameplay.Factory.FactoryItem out4;  // 0xe0
        public Beyond.Gameplay.Factory.FactoryItem out5;  // 0xf0
        public Beyond.Gameplay.Factory.FactoryItem out6;  // 0x100
        public Beyond.Gameplay.Factory.FactoryItem out7;  // 0x110
        public Beyond.Gameplay.Factory.CacheFragment.<fluidInPtr>e__FixedBuffer fluidInPtr;  // 0x120
        public Beyond.Gameplay.Factory.FactoryItem fluidIn0;  // 0x120
        public Beyond.Gameplay.Factory.FactoryItem fluidIn1;  // 0x130
        public Beyond.Gameplay.Factory.FactoryItem fluidIn2;  // 0x140
        public Beyond.Gameplay.Factory.FactoryItem fluidIn3;  // 0x150
        public Beyond.Gameplay.Factory.FactoryItem fluidIn4;  // 0x160
        public Beyond.Gameplay.Factory.FactoryItem fluidIn5;  // 0x170
        public Beyond.Gameplay.Factory.FactoryItem fluidIn6;  // 0x180
        public Beyond.Gameplay.Factory.FactoryItem fluidIn7;  // 0x190
        public Beyond.Gameplay.Factory.CacheFragment.<fluidOutPtr>e__FixedBuffer fluidOutPtr;  // 0x1a0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut0;  // 0x1a0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut1;  // 0x1b0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut2;  // 0x1c0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut3;  // 0x1d0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut4;  // 0x1e0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut5;  // 0x1f0
        public Beyond.Gameplay.Factory.FactoryItem fluidOut6;  // 0x200
        public Beyond.Gameplay.Factory.FactoryItem fluidOut7;  // 0x210
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55AA0 */ }

        // Methods
        // RVA: 0x05791F48  token: 0x60004DD
        public System.Void GetCacheItem(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 indexInCache, System.UInt32& itemId, System.Int32& itemAmount, System.Int64& tms) { }
        // RVA: 0x027545C0  token: 0x60004DE
        public System.Void SetCacheItem(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 indexInCache, System.UInt32 itemId, System.Int32 itemAmount, System.Int64 tms) { }
        // RVA: 0x02754550  token: 0x60004DF
        public System.Void SetCacheSize(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 sizeCount) { }
        // RVA: 0x02754680  token: 0x60004E0
        public System.Int32 CalcIndex(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 indexInCache, Beyond.Gameplay.Factory.FactoryItem*& ptr) { }
        // RVA: 0x0579205C  token: 0x60004E2
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000A8  // size: 0x1C
    public sealed struct CacheTransportFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean autoTransport;  // 0x10
        public System.Boolean inUse;  // 0x11
        public System.Single currentProgress;  // 0x14
        public System.Single totalProgress;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55800 */ }

        // Methods
        // RVA: 0x057921A0  token: 0x60004E4
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000A9  // size: 0x88
    public sealed struct CargoFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef, System.IComparable`1
    {
        // Fields
        public System.Boolean serverArrived;  // 0x10
        public System.Boolean arrived;  // 0x11
        public System.Boolean enter;  // 0x12
        public System.Boolean isLiquidItem;  // 0x13
        public System.UInt32 conveyorId;  // 0x14
        public System.Single moveSpeed;  // 0x18
        public System.Int32 minDist;  // 0x1c
        public System.Int32 conveyorLength;  // 0x20
        public System.Single predictPos;  // 0x24
        public Unity.Mathematics.float3 position;  // 0x28
        public Unity.Mathematics.float4 itemUV;  // 0x34
        public Unity.Mathematics.float4 itemLiquidUV;  // 0x44
        public Unity.Mathematics.quaternion rotation;  // 0x54
        public System.Int32 itemFastId;  // 0x64
        public System.Int64 tms;  // 0x68
        public System.Single adjustTms;  // 0x70
        public System.UInt32 conveyorExtHandle;  // 0x74
        public System.Int32 cargoIndex;  // 0x78
        public System.Int32 indexInRendererList;  // 0x7c
        public System.Int32 unitConfigAssetInstanceId;  // 0x80
        public static System.Int32 ID;  // const

        // Properties
        System.String itemId { get; /* RVA: 0x05792604 */ set; /* RVA: 0x05792620 */ }
        System.Boolean recyclable { get; /* RVA: 0x05792610 */ }
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4F0C0 */ set; /* RVA: 0x03D4F0F0 */ }
        System.Int32 id { get; /* RVA: 0x03D55810 */ }

        // Methods
        // RVA: 0x05792438  token: 0x60004E7
        public System.Single PredictPos(System.Int64 serverTime) { }
        // RVA: 0x057923C8  token: 0x60004E8
        public System.Single PredictPosWithDeltaTime(System.Int64 deltaTime) { }
        // RVA: 0x057922BC  token: 0x60004E9
        public virtual System.Int32 CompareTo(Beyond.Gameplay.Factory.CargoFragment other) { }
        // RVA: 0x0579237C  token: 0x60004ED
        public System.Boolean GetVisible(Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>* rendererList) { }
        // RVA: 0x027DA350  token: 0x60004EE
        public static Beyond.Gameplay.Factory.CargoFragment Create(System.UInt32 unitId, Unity.Mathematics.int4 itemAtlasRect, Unity.Mathematics.int4 liquidAtlasRect, System.Int32 itemFastId, System.Int32 conveyorSpeed, System.Int64 tms, System.Int32 conveyorLength, System.Single minDis, System.Boolean isLiquidItem) { }
        // RVA: 0x057924C8  token: 0x60004F0
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000AB  // size: 0x14
    public sealed struct CargoRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D55730 */ }

        // Methods
        // RVA: 0x05792640  token: 0x60004F4
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000AC  // size: 0x3838
    public sealed struct ChapterFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 powerCost;  // 0x10
        public System.Int64 powerGen;  // 0x18
        public System.Int64 powerSaveCurrent;  // 0x20
        public System.Int64 powerSaveMax;  // 0x28
        public System.Boolean isStopByPower;  // 0x30
        public System.Int32 chapterId;  // 0x34
        public Beyond.Gameplay.Factory.BlueprintSlotInfo blueprintSlotInfo;  // 0x38
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D557B0 */ }

        // Methods
        // RVA: 0x0579274C  token: 0x60004F6
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000AD  // size: 0x20
    public sealed struct CollectorFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 currentProgress;  // 0x10
        public System.UInt32 collectItem;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D557A0 */ }

        // Methods
        // RVA: 0x05792898  token: 0x60004F8
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000AE  // size: 0x38
    public sealed struct ConnectionFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 connectionId;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity fromEntity;  // 0x18
        public System.Int64 fromNodeEntityId;  // 0x18
        public UnityEngine.HyperGryph.ECS.Entity toEntity;  // 0x20
        public System.Int64 toNodeEntityId;  // 0x20
        public System.Boolean strengthenConnection;  // 0x28
        public Beyond.Gameplay.Factory.ConnectionFragment.RendererType rendererType;  // 0x29
        public System.Int32 chapterId;  // 0x2a
        public System.Single alpha;  // 0x2e
        public static System.Int32 ID;  // const

        // Properties
        System.Boolean valid { get; /* RVA: 0x027D2640 */ }
        System.Int32 id { get; /* RVA: 0x03D557F0 */ }

        // Methods
        // RVA: 0x05793698  token: 0x60004FB
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B0  // size: 0x34
    public sealed struct ConveyorFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.ILogisticSample
    {
        // Fields
        public System.UInt32 factoryUnitId;  // 0x10
        public System.Single speed;  // 0x14
        public UnityEngine.Rect bounds;  // 0x18
        private System.Int32 <length>k__BackingField;  // 0x28
        public System.UInt32 startMemoryOffsetHandle;  // 0x2c
        public System.UInt32 endMemoryOffsetHandle;  // 0x30
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 length { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Int32 id { get; /* RVA: 0x03D55AC0 */ }

        // Methods
        // RVA: 0x02A8DC80  token: 0x60004FE
        public System.Void SetInflection(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Collections.NativeList<Unity.Mathematics.float3>& p, Unity.Collections.NativeList<Unity.Mathematics.float3>& r, Unity.Collections.NativeArray<System.Byte>& proto) { }
        // RVA: 0x02A8DAB0  token: 0x60004FF
        public static System.Void CalcRect(Unity.Collections.NativeList<Unity.Mathematics.float3> posList, UnityEngine.Rect& b) { }
        // RVA: 0x024FB300  token: 0x6000500
        public virtual System.Boolean Sample(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Mathematics.float2 p, System.UInt32& unitId, System.Int32& indexInConveyor) { }
        // RVA: 0x05793C30  token: 0x6000501
        public virtual System.Boolean IsInRect(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax) { }
        // RVA: 0x028BD970  token: 0x6000502
        public virtual System.Boolean GetInRectUnitIndex(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, Beyond.PoolCore.PooledList<System.Int32>& unitIndex) { }
        // RVA: 0x05793A14  token: 0x6000503
        public virtual System.Boolean FillRectTargets(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.ValueTuple<System.UInt32,System.Int32>[,]& rectTargets) { }
        // RVA: 0x057939C0  token: 0x6000504
        public System.Void DrawDebug(System.Single groundY) { }
        // RVA: 0x05793DB8  token: 0x6000506
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B2
    public interface ILogisticSample
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000507
        public virtual System.Boolean Sample(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Mathematics.float2 p, System.UInt32& unitId, System.Int32& indexInLogistic) { }
        // RVA: -1  // abstract  token: 0x6000508
        public virtual System.Boolean IsInRect(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax) { }
        // RVA: -1  // abstract  token: 0x6000509
        public virtual System.Boolean GetInRectUnitIndex(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, Beyond.PoolCore.PooledList<System.Int32>& unitIndex) { }
        // RVA: -1  // abstract  token: 0x600050A
        public virtual System.Boolean FillRectTargets(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.ValueTuple<System.UInt32,System.Int32>[,]& rectTargets) { }

    }

    // TypeToken: 0x20000B3  // size: 0x11
    public sealed struct ConveyorLogisticsUnitFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55AE0 */ }

        // Methods
        // RVA: 0x05793FE8  token: 0x600050C
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B4  // size: 0x38
    public sealed struct ConveyorRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public System.Int32 indexInConveyor;  // 0x14
        public UnityEngine.HyperGryph.HGFactoryEntityTransformData transformData;  // 0x18
        public Unity.Mathematics.float3 position;  // 0x18
        public System.Single scale;  // 0x24
        public Unity.Mathematics.quaternion rotation;  // 0x28
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D55B10 */ }

        // Methods
        // RVA: 0x05794320  token: 0x6000510
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B5  // size: 0x11
    public sealed struct LeftFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55F90 */ }

        // Methods
        // RVA: 0x05798710  token: 0x6000512
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B6  // size: 0x11
    public sealed struct RightFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56100 */ }

        // Methods
        // RVA: 0x0579AFCC  token: 0x6000514
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B7  // size: 0x11
    public sealed struct MidFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55FE0 */ }

        // Methods
        // RVA: 0x05798D48  token: 0x6000516
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B8  // size: 0x11
    public sealed struct CullResultFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean culled;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55B20 */ }

        // Methods
        // RVA: 0x05794444  token: 0x6000518
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000B9  // size: 0x11
    public sealed struct DebugFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55B40 */ }

        // Methods
        // RVA: 0x05794778  token: 0x600051A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000BA  // size: 0x20
    public sealed struct EvtDestroyUnit : Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 targetDestroyTime;  // 0x10
        public System.Int64 checkedTime;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Boolean timeout { get; /* RVA: 0x02AABCC0 */ }
        System.Int32 id { get; /* RVA: 0x03D55BC0 */ }

        // Methods
        // RVA: 0x05794D54  token: 0x600051D
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000BB  // size: 0x11
    public sealed struct ShowStateUI : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56120 */ }

        // Methods
        // RVA: 0x0579B1E4  token: 0x600051F
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000BC  // size: 0x11
    public sealed struct ShowNameUI : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56110 */ }

        // Methods
        // RVA: 0x0579B0D8  token: 0x6000521
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000BD  // size: 0x11
    public sealed struct HasRenderer : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55770 */ }

        // Methods
        // RVA: 0x05798194  token: 0x6000523
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000BE  // size: 0x18
    public sealed struct EvtUpdatePipeEffect : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x03D51730 */ }
        System.Int32 id { get; /* RVA: 0x03D55C10 */ }

        // Methods
        // RVA: 0x057951B0  token: 0x6000527
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000BF  // size: 0x84
    public sealed struct EvtChangeTemplate : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean playBuildEffect;  // 0x10
        public System.Single playBuildEffectDuration;  // 0x14
        public System.Boolean updatePedestal;  // 0x18
        public System.Boolean updateBuilding;  // 0x19
        public Unity.Collections.FixedString32Bytes newTemplate;  // 0x1a
        public Unity.Collections.FixedString32Bytes newLogisticPedestalTemplate;  // 0x3a
        public Unity.Collections.FixedString32Bytes newNonLogisticPedestalTemplate;  // 0x5a
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x7c
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x03D55B60 */ set; /* RVA: 0x03D55B80 */ }
        System.Int32 id { get; /* RVA: 0x03D55B70 */ }

        // Methods
        // RVA: 0x057949F4  token: 0x600052B
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C0  // size: 0x18
    public sealed struct EvtCreateUnitRenderer : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 evtEntityId;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x03D51730 */ }
        System.Int32 id { get; /* RVA: 0x03D55BB0 */ }

        // Methods
        // RVA: 0x05794C48  token: 0x600052F
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C1  // size: 0x18
    public sealed struct EvtUpdateStatusEffect : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 evtEntityId;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x03D51730 */ }
        System.Int32 id { get; /* RVA: 0x03D55C30 */ }

        // Methods
        // RVA: 0x057953D4  token: 0x6000533
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C2  // size: 0x18
    public sealed struct EvtPendingCreateRenderer : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x03D51730 */ }
        System.Int32 id { get; /* RVA: 0x03D55BD0 */ }

        // Methods
        // RVA: 0x05794E6C  token: 0x6000537
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C3  // size: 0x20
    public sealed struct EvtUpdateRendererProperty : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean evtColliderToggle;  // 0x10
        public System.Boolean colliderToggle;  // 0x11
        public System.Boolean evtVisible;  // 0x12
        public System.Boolean visible;  // 0x13
        public System.Boolean additiveVisible;  // 0x14
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x03D55BA0 */ }
        System.Int32 id { get; /* RVA: 0x03D55C20 */ }

        // Methods
        // RVA: 0x057952BC  token: 0x600053B
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C4  // size: 0x1C
    public sealed struct EvtStatusChange : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean forceUpdate;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x14
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x03D55BE0 */ set; /* RVA: 0x03D55C00 */ }
        System.Int32 id { get; /* RVA: 0x03D55BF0 */ }

        // Methods
        // RVA: 0x05794F78  token: 0x600053F
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C5  // size: 0x20
    public sealed struct EvtCreateInteract : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 interactObjectId;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x18
        public System.UInt64 evtEntityId;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x03D55BA0 */ }
        System.Int32 id { get; /* RVA: 0x03D55B90 */ }

        // Methods
        // RVA: 0x05794B30  token: 0x6000543
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C6  // size: 0x20
    public sealed struct EvtVatUpdate : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 evtEntityId;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x10
        public System.Byte placeHolder;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x03D51730 */ }
        System.Int32 id { get; /* RVA: 0x03D55C40 */ }

        // Methods
        // RVA: 0x057954E0  token: 0x6000547
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C7  // size: 0x1C
    public sealed struct EvtUpdatePedestalColorLUT : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean light;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x14
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x03D55BE0 */ set; /* RVA: 0x03D55C00 */ }
        System.Int32 id { get; /* RVA: 0x03D55740 */ }

        // Methods
        // RVA: 0x05795094  token: 0x600054B
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000C8  // size: 0x12
    public sealed struct EvtAudioType
    {
        // Fields
        public System.Int16 value__;  // 0x10
        public static Beyond.Gameplay.Factory.EvtAudioType BUILDING_STATUS;  // const
        public static Beyond.Gameplay.Factory.EvtAudioType BUILDING_DESTROY;  // const

    }

    // TypeToken: 0x20000C9  // size: 0x11
    public sealed struct AudioCullingState
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.AudioCullingState AUDIBLE;  // const
        public static Beyond.Gameplay.Factory.AudioCullingState PENDING_CULL;  // const
        public static Beyond.Gameplay.Factory.AudioCullingState CULLED;  // const
        public static Beyond.Gameplay.Factory.AudioCullingState PENDING_RESTORE;  // const
        public static Beyond.Gameplay.Factory.AudioCullingState AUDIBLE_CUR_FRAME;  // const
        public static Beyond.Gameplay.Factory.AudioCullingState CULLED_CUR_FRAME;  // const

    }

    // TypeToken: 0x20000CA  // size: 0x11
    public sealed struct AudioDebugGizmosType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType NONE;  // const
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType GROUP_EMITTER_AREA1;  // const
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType GROUP_EMITTER_AREA2;  // const
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType GROUP_EMITTER_AREA3;  // const
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType GROUP_EMITTER_OUT_OF_RANGE;  // const
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType GROUP_EMITTER_NOT_CONSIDERED_TYPE;  // const
        public static Beyond.Gameplay.Factory.AudioDebugGizmosType GROUP_EMITTER_NOT_CONSIDERED_STATUS;  // const

    }

    // TypeToken: 0x20000CB  // size: 0x20
    public sealed struct EvtAudio : Beyond.Gameplay.Factory.INotificationComponent, Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 evtEntityId;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity evtEntity;  // 0x10
        public Beyond.Gameplay.Factory.EvtAudioType evtType;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x03D51730 */ }
        System.Int32 id { get; /* RVA: 0x03D55B50 */ }

        // Methods
        // RVA: 0x057948DC  token: 0x600054F
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000CC  // size: 0x1C
    public sealed struct AudioFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt32 audioFragmentId;  // 0x10
        public System.Single distSqToListener;  // 0x14
        public Beyond.Gameplay.Factory.AudioCullingState cullingState;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55A80 */ }

        // Methods
        // RVA: 0x05791380  token: 0x6000551
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000CD  // size: 0x11
    public sealed struct ReleaseTagFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D560F0 */ }

        // Methods
        // RVA: 0x0579AEC0  token: 0x6000553
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000CE  // size: 0x11
    public sealed struct CurMapUnitTag : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55B30 */ }

        // Methods
        // RVA: 0x05794550  token: 0x6000555
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000CF  // size: 0x19C
    public sealed struct StaticMountOffset
    {
        // Fields
        public System.Boolean outputPosValid;  // 0x10
        public Unity.Mathematics.float4x4 outputPos;  // 0x14
        public System.Boolean nameUIPosValid;  // 0x54
        public Unity.Mathematics.float4x4 nameUIPos;  // 0x58
        public Unity.Mathematics.bool4 statusPosValid;  // 0x98
        public Unity.Mathematics.float4x4 statusPos0;  // 0x9c
        public Unity.Mathematics.float4x4 statusPos1;  // 0xdc
        public Unity.Mathematics.float4x4 statusPos2;  // 0x11c
        public Unity.Mathematics.float4x4 statusPos3;  // 0x15c

    }

    // TypeToken: 0x20000D0  // size: 0x1E8
    public sealed struct UnitFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt32 nodeId;  // 0x10
        public System.Int32 level;  // 0x14
        public System.Int32 nodeType;  // 0x18
        public System.Boolean inPower;  // 0x1c
        public System.Int64 powerCost;  // 0x20
        public System.Boolean inBlock;  // 0x28
        public System.Boolean isActive;  // 0x29
        public Unity.Mathematics.bool2 buildDismissEffectEnabled;  // 0x2a
        public System.UInt32 flag;  // 0x2c
        public System.Boolean formulaManMode;  // 0x30
        public System.Int32 rvoObstacleId;  // 0x34
        public System.Int32 navObstacleId;  // 0x38
        public System.Int32 navSourceId;  // 0x3c
        public System.Int32 nameInstanceId;  // 0x40
        public System.Int32 templateIdFastString;  // 0x44
        public System.Int32 rendererTemplateIdFastString;  // 0x48
        public System.Int32 logisticBaseRendererTemplateIdFastString;  // 0x4c
        public System.Int32 nonLogisticBaseRendererTemplateIdFastString;  // 0x50
        public System.Int32 instKeyFastString;  // 0x54
        public Beyond.Gameplay.Factory.StaticMountOffset staticMountOffset;  // 0x58
        public static System.Int32 ID;  // const

        // Properties
        System.Boolean needRepair { get; /* RVA: 0x0579B658 */ }
        System.Boolean battleBroken { get; /* RVA: 0x0579B650 */ }
        System.Boolean socialUnit { get; /* RVA: 0x028BC270 */ }
        System.String templateId { get; /* RVA: 0x0426FD18 */ set; /* RVA: 0x042716CC */ }
        System.String rendererTemplateId { get; /* RVA: 0x0579B660 */ set; /* RVA: 0x042716AC */ }
        System.String logisticBaseRendererTemplateId { get; /* RVA: 0x04270AD8 */ set; /* RVA: 0x0579B66C */ }
        System.String nonLogisticBaseRendererTemplateId { get; /* RVA: 0x04270ACC */ set; /* RVA: 0x0579B68C */ }
        System.String instKey { get; /* RVA: 0x042725B0 */ set; /* RVA: 0x0427168C */ }
        Beyond.GEnums.FCNodeMode formulaType { get; /* RVA: 0x02763520 */ }
        System.Int32 id { get; /* RVA: 0x03D56140 */ }

        // Methods
        // RVA: 0x02754E10  token: 0x6000564
        public static Beyond.Gameplay.Factory.UnitFragment Create(System.UInt32 nodeId, System.String templateId, System.Int32 nodeType, Unity.Mathematics.bool2 buildDismissEnabled, System.Int32 level, System.UInt32 nodeFlag, System.String rendererTemplateId, System.Boolean inBlock, System.Boolean inPower, System.Boolean inActive, System.Int64 powerCost, System.Boolean formulaManMode, System.String instKey) { }
        // RVA: 0x0579B50C  token: 0x6000566
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D1  // size: 0x11
    public sealed struct UnitRenderPipeLogisticsFigureReplaceFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56180 */ }

        // Methods
        // RVA: 0x0579BB1C  token: 0x6000568
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D2  // size: 0x14
    public sealed struct BusRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 idx;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55A90 */ }

        // Methods
        // RVA: 0x05791E3C  token: 0x600056A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D3  // size: 0x11
    public sealed struct UnitRenderBuildingFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56170 */ }

        // Methods
        // RVA: 0x0579B904  token: 0x600056C
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D4  // size: 0x11
    public sealed struct UnitRenderPedestalFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55760 */ }

        // Methods
        // RVA: 0x0579BA10  token: 0x600056E
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D5  // size: 0x11
    public sealed struct UnitRendererRegularFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56190 */ }

        // Methods
        // RVA: 0x0579BC28  token: 0x6000570
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D6  // size: 0x11
    public sealed struct UnitOnlyRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56150 */ }

        // Methods
        // RVA: 0x0579B6AC  token: 0x6000572
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D7  // size: 0x11
    public sealed struct FakeUnitFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55C50 */ }

        // Methods
        // RVA: 0x057955F8  token: 0x6000574
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D8  // size: 0x11
    public sealed struct UIUnitFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56130 */ }

        // Methods
        // RVA: 0x0579B400  token: 0x6000576
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000D9  // size: 0x14
    public sealed struct GuideHintFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 hashKey;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55F60 */ }

        // Methods
        // RVA: 0x05798088  token: 0x6000578
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000DA  // size: 0x30
    public sealed struct UnitPreviewFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 templateIdFastId;  // 0x10
        public System.Int32 previewRendererTemplateIdFastId;  // 0x14
        public System.Int32 logisticPedestalRendererTemplateIdFastId;  // 0x18
        public System.Int32 nonLogisticPedestalRendererTemplateIdFastId;  // 0x1c
        public System.Boolean formulaManMode;  // 0x20
        public System.Int32 nodeType;  // 0x24
        public Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTarget entityTarget;  // 0x28
        public Beyond.Gameplay.Factory.UnitPreviewFragment.EntityType entityType;  // 0x2c
        public static System.Int32 ID;  // const

        // Properties
        System.String templateId { get; /* RVA: 0x0579B8F8 */ set; /* RVA: 0x042744C8 */ }
        System.String previewRendererTemplateId { get; /* RVA: 0x0579B8EC */ set; /* RVA: 0x042744A8 */ }
        System.String logisticPedestalRendererTemplateId { get; /* RVA: 0x0579B8D4 */ set; /* RVA: 0x04274488 */ }
        System.String nonLogisticPedestalRendererTemplateId { get; /* RVA: 0x0579B8E0 */ set; /* RVA: 0x04274468 */ }
        System.Int32 id { get; /* RVA: 0x03D56160 */ }

        // Methods
        // RVA: 0x0579B7B8  token: 0x6000582
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000DD  // size: 0x11
    public sealed struct ConveyorRegularFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55B00 */ }

        // Methods
        // RVA: 0x05794214  token: 0x6000584
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000DE  // size: 0x11
    public sealed struct ConveyorGuideFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55AD0 */ }

        // Methods
        // RVA: 0x05793EDC  token: 0x6000586
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000DF  // size: 0x11
    public sealed struct PipeRegularFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D560C0 */ }

        // Methods
        // RVA: 0x0579A918  token: 0x6000588
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E0  // size: 0x24
    public sealed struct ConveyorPreviewRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean valid;  // 0x10
        public Beyond.Gameplay.Factory.UnitPreviewFragment.EntityType entityType;  // 0x14
        public System.Int32 length;  // 0x18
        public System.UInt32 startMemoryOffsetHandle;  // 0x1c
        public System.UInt32 endMemoryOffsetHandle;  // 0x20
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55AF0 */ }

        // Methods
        // RVA: 0x057940F4  token: 0x600058A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E1  // size: 0x30
    public sealed struct PipePreviewRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean valid;  // 0x10
        public System.Single pipeHeight;  // 0x14
        public System.Single gridPathHeightStart;  // 0x18
        public System.Single gridPathHeightEnd;  // 0x1c
        public System.Int32 length;  // 0x20
        public System.UInt32 startMemoryOffsetHandle;  // 0x24
        public System.UInt32 endMemoryOffsetHandle;  // 0x28
        public System.Boolean trackValid;  // 0x2c
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D560B0 */ }

        // Methods
        // RVA: 0x0579A7FC  token: 0x600058C
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E2  // size: 0x11
    public sealed struct PipePreviewFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D560A0 */ }

        // Methods
        // RVA: 0x0579A6F0  token: 0x600058E
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E3  // size: 0x30
    public sealed struct FigureRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public Unity.Mathematics.float3 position;  // 0x14
        public Unity.Mathematics.quaternion rotation;  // 0x20
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D55C60 */ }

        // Methods
        // RVA: 0x05795704  token: 0x6000592
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E4  // size: 0x11
    public sealed struct FigureRenderLeftFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55C70 */ }

        // Methods
        // RVA: 0x05795820  token: 0x6000594
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E5  // size: 0x11
    public sealed struct FigureRenderRightFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55CA0 */ }

        // Methods
        // RVA: 0x05795B44  token: 0x6000596
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E6  // size: 0x11
    public sealed struct FigureRenderMidFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55C80 */ }

        // Methods
        // RVA: 0x0579592C  token: 0x6000598
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E7  // size: 0x11
    public sealed struct FigureRenderPipeHolderFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55C90 */ }

        // Methods
        // RVA: 0x05795A38  token: 0x600059A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E8  // size: 0x18
    public sealed struct FluidConsumeFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 progress;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55CB0 */ }

        // Methods
        // RVA: 0x05795CA8  token: 0x600059C
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000E9  // size: 0xB0
    public sealed struct FluidContainerFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Unity.Mathematics.int4x2 itemId;  // 0x10
        public System.Int32 itemId0;  // 0x10
        public System.Int32 itemId1;  // 0x14
        public System.Int32 itemId2;  // 0x18
        public System.Int32 itemId3;  // 0x1c
        public System.Int32 itemId4;  // 0x20
        public System.Int32 itemId5;  // 0x24
        public System.Int32 itemId6;  // 0x28
        public System.Int32 itemId7;  // 0x2c
        public Unity.Mathematics.int4x2 itemAmount;  // 0x30
        public Unity.Mathematics.int4 itemAmount_0;  // 0x30
        public Unity.Mathematics.int4 itemAmount_1;  // 0x40
        public System.Int32 itemAmount0;  // 0x30
        public System.Int32 itemAmount1;  // 0x34
        public System.Int32 itemAmount2;  // 0x38
        public System.Int32 itemAmount3;  // 0x3c
        public System.Int32 itemAmount4;  // 0x40
        public System.Int32 itemAmount5;  // 0x44
        public System.Int32 itemAmount6;  // 0x48
        public System.Int32 itemAmount7;  // 0x4c
        public Unity.Mathematics.float4x2 renderItemAmount;  // 0x50
        public Unity.Mathematics.float4 renderItemAmount_0;  // 0x50
        public Unity.Mathematics.float4 renderItemAmount_1;  // 0x60
        public System.Single renderItemAmount0;  // 0x50
        public System.Single renderItemAmount1;  // 0x54
        public System.Single renderItemAmount2;  // 0x58
        public System.Single renderItemAmount3;  // 0x5c
        public System.Single renderItemAmount4;  // 0x60
        public System.Single renderItemAmount5;  // 0x64
        public System.Single renderItemAmount6;  // 0x68
        public System.Single renderItemAmount7;  // 0x6c
        public System.Int32 itemSubType0;  // 0x70
        public System.Int32 itemSubType1;  // 0x74
        public System.Int32 itemSubType2;  // 0x78
        public System.Int32 itemSubType3;  // 0x7c
        public System.Int32 itemSubType4;  // 0x80
        public System.Int32 itemSubType5;  // 0x84
        public System.Int32 itemSubType6;  // 0x88
        public System.Int32 itemSubType7;  // 0x8c
        public Unity.Mathematics.float4x2 capacity;  // 0x90
        public System.Int32 capacity0;  // 0x90
        public System.Int32 capacity1;  // 0x94
        public System.Int32 capacity2;  // 0x98
        public System.Int32 capacity3;  // 0x9c
        public System.Int32 capacity4;  // 0xa0
        public System.Int32 capacity5;  // 0xa4
        public System.Int32 capacity6;  // 0xa8
        public System.Int32 capacity7;  // 0xac
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55CC0 */ }

        // Methods
        // RVA: 0x030AF660  token: 0x600059D
        public System.Void Set(System.Int32 index, System.Int32 itemId, System.Int32 itemAmount, System.Int32 itemSubType) { }
        // RVA: 0x030AF6C0  token: 0x600059E
        public System.Void SetCapacity(System.Int32 index, System.Int32 cap) { }
        // RVA: 0x05796384  token: 0x600059F
        public System.Void SetAmount(System.Int32 index, System.Int32 amount) { }
        // RVA: 0x030D4630  token: 0x60005A0
        public System.Boolean Get(System.Int32 index, System.Int32& itemId, System.Int32& itemAmount, System.Single& renderItemAmount, System.Int32& itemSubType, System.Int32& cap) { }
        // RVA: 0x0579631C  token: 0x60005A1
        public System.Boolean HasLiquid() { }
        // RVA: 0x05795DB4  token: 0x60005A2
        public System.Void CalcRenderItemAmount(System.Single step) { }
        // RVA: 0x0579619C  token: 0x60005A3
        public System.ValueTuple<System.Int32,System.UInt32> GetOffsetData() { }
        // RVA: 0x03B297A0  token: 0x60005A4
        public System.Void Reset() { }
        // RVA: 0x057963F8  token: 0x60005A5
        public virtual System.String ToString() { }
        // RVA: 0x05796E74  token: 0x60005A7
        private System.Void __AOT_FOR_FIX__() { }
        // RVA: 0x05796DCC  token: 0x60005A8
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20000EA  // size: 0x11
    public sealed struct FluidPumpInFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55CD0 */ }

        // Methods
        // RVA: 0x05796FB4  token: 0x60005AA
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000EB  // size: 0x11
    public sealed struct FluidPumpOutFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55CE0 */ }

        // Methods
        // RVA: 0x057970C0  token: 0x60005AC
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000EC  // size: 0x11
    public sealed struct FluidReactionFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55CF0 */ }

        // Methods
        // RVA: 0x057971CC  token: 0x60005AE
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000ED  // size: 0x18
    public sealed struct FluidSprayFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 progress;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55D00 */ }

        // Methods
        // RVA: 0x057972D8  token: 0x60005B0
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000EE  // size: 0x1C
    public sealed struct FormulaManualFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 currentGroup;  // 0x10
        public System.Int32 currentMode;  // 0x14
        public System.Int32 lockedFormulaId;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55D10 */ }

        // Methods
        // RVA: 0x057973E4  token: 0x60005B2
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000EF  // size: 0x18
    public sealed struct EvtLogisticFigureRenderer
    {
        // Fields
        public System.Boolean triggered;  // 0x10
        public System.Int32 figureType;  // 0x14
        public static readonly System.Byte S_NONE;  // static @ 0x0
        public static readonly System.Byte S_PIPE;  // static @ 0x1
        public static readonly System.Byte S_CONVEYOR;  // static @ 0x2
        public static readonly System.Byte S_CONVEYOR_GUIDE;  // static @ 0x3

        // Methods
        // RVA: 0x03D06750  token: 0x60005B3
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000F0  // size: 0x15
    public sealed struct OutOfBufferWarning
    {
        // Fields
        public System.Boolean pipe;  // 0x10
        public System.Boolean wire;  // 0x11
        public System.Boolean conveyor;  // 0x12
        public System.Boolean cargo;  // 0x13
        public System.Boolean operated;  // 0x14

        // Methods
        // RVA: 0x03B341C0  token: 0x60005B4
        public System.Void ResetFlags() { }
        // RVA: 0x05798E54  token: 0x60005B5
        public virtual System.String ToString() { }
        // RVA: 0x05799020  token: 0x60005B6
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20000F1  // size: 0x11
    public sealed struct FacSystemTickSkipSource
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.FacSystemTickSkipSource NONE;  // const
        public static Beyond.Gameplay.Factory.FacSystemTickSkipSource ALL;  // const
        public static Beyond.Gameplay.Factory.FacSystemTickSkipSource MAP;  // const
        public static Beyond.Gameplay.Factory.FacSystemTickSkipSource UI;  // const
        public static Beyond.Gameplay.Factory.FacSystemTickSkipSource GM;  // const

    }

    // TypeToken: 0x20000F2  // size: 0x488
    public sealed struct GlobalEnv : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.OutOfBufferWarning outOfBufferWarning;  // 0x10
        public System.Boolean teardown;  // 0x15
        public System.Boolean isSquadInFight;  // 0x16
        public System.Boolean isTowerDefence;  // 0x17
        public Beyond.Gameplay.Factory.FacSystemTickSkipSource facSystemTickSkip;  // 0x18
        public Unity.Mathematics.float3 playerPosition;  // 0x1c
        public Unity.Mathematics.float3 playerForward;  // 0x28
        public Unity.Mathematics.float3 playerRight;  // 0x34
        public Unity.Mathematics.float3 cameraPosition;  // 0x40
        public UnityEngine.HyperGryph.ECS.Entity currentScopeEntity;  // 0x4c
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer unitPreviewQueryResult;  // 0x58
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer cargoPredictQueryResult;  // 0x70
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer lookAtQueryResult;  // 0x88
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer pipeThicknessQueryResult;  // 0xa0
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer l2wQueryResult;  // 0xb8
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer unitRendererQueryResult;  // 0xd0
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer liquidRendererQueryResult;  // 0xe8
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer pumpRendererQueryResult;  // 0x100
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer additiveEffectQueryResult;  // 0x118
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer hintEffectQueryResult;  // 0x130
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer additiveEffectRendererQueryResult;  // 0x148
        public Unity.Jobs.JobHandle baseTickChainJobHandle;  // 0x160
        public Unity.Jobs.JobHandle crossFrameJobHandle;  // 0x170
        public Unity.Jobs.JobHandle cullingJobHandle;  // 0x180
        public Unity.Jobs.JobHandle l2wJobHandle;  // 0x190
        public Unity.Jobs.JobHandle cargoPredictJobHandle;  // 0x1a0
        public Unity.Jobs.JobHandle cargoRenderJobHandle;  // 0x1b0
        public Unity.Jobs.JobHandle lookAtJobHandle;  // 0x1c0
        public Unity.Jobs.JobHandle conveyorFigureRenderJobHandle;  // 0x1d0
        public Unity.Jobs.JobHandle portArrowRenderJobHandle;  // 0x1e0
        public Unity.Jobs.JobHandle portConveyorInsideRenderJobHandle;  // 0x1f0
        public System.Int64 anyTransChangedFrame;  // 0x200
        public System.Boolean evtLevelLoadStatus;  // 0x208
        public System.Boolean evtTopViewChanged;  // 0x209
        public System.Boolean evtPipeDirty;  // 0x20a
        public System.Boolean evtOutputDirty;  // 0x20b
        public System.Boolean evtForceUpdatePreviewPortRenderer;  // 0x20c
        public System.Boolean firstEnterGameScene;  // 0x20d
        public Beyond.Gameplay.Factory.EvtLogisticFigureRenderer evtLogisticFigureRenderer;  // 0x210
        public System.Boolean systemUnlockedPipe;  // 0x218
        public System.Boolean systemUnlockedConveyor;  // 0x219
        public System.Boolean useDistanceFilter;  // 0x21a
        public Unity.Mathematics.float2 distanceFilterCenterPos;  // 0x21c
        public System.Single distanceThreshold;  // 0x224
        public Unity.Mathematics.float4x4 arrowUV;  // 0x228
        public Unity.Mathematics.float2 arrowOffset;  // 0x268
        public System.Single conveyorOffsetY;  // 0x270
        public System.Boolean UIBuildingAnimationEnabled;  // 0x274
        public System.Boolean vatEnableEnvDirty;  // 0x275
        public System.Boolean buildingNameInvalid;  // 0x276
        public System.Boolean topViewEnable;  // 0x277
        public System.Boolean showOutputUI;  // 0x278
        public System.Boolean inBuildMode;  // 0x279
        public System.Boolean buildConveyor;  // 0x27a
        public System.Boolean buildPipe;  // 0x27b
        public System.Boolean simpleConveyor;  // 0x27c
        public System.Boolean simplePipe;  // 0x27d
        public System.Boolean inputDisable;  // 0x27e
        public System.Boolean outputDisable;  // 0x27f
        public System.Boolean inputFluidDisable;  // 0x280
        public System.Boolean outputFluidDisable;  // 0x281
        public Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap* interactBuilding;  // 0x288
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* conveyorInfo;  // 0x290
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* pipeInfo;  // 0x298
        public Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap* interactBuildingLast;  // 0x2a0
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* conveyorInfoLast;  // 0x2a8
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* pipeInfoLast;  // 0x2b0
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* portBlockPosListPtr;  // 0x2b8
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.OutputRendererInfo>* outputUIPosListPtr;  // 0x2c0
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* buildingStatePosListPtr;  // 0x2c8
        public Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>* cargoMatricesBufferWriter;  // 0x2d0
        public Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>* cargoMatricesBufferReader;  // 0x2d8
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorLPosMatricesBufferWriter;  // 0x2e0
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorMPosMatricesBufferWriter;  // 0x2e8
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorRPosMatricesBufferWriter;  // 0x2f0
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorLPosMatricesBufferReader;  // 0x2f8
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorMPosMatricesBufferReader;  // 0x300
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorRPosMatricesBufferReader;  // 0x308
        public System.Boolean bConflictCheck;  // 0x310
        public System.IntPtr arrowPlacedDicPtr;  // 0x318
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>* portArrowMatricesWriter;  // 0x320
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>* portArrowMatricesReader;  // 0x328
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorPreviewLPosMatricesWriter;  // 0x330
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorPreviewMPosMatricesWriter;  // 0x338
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorPreviewRPosMatricesWriter;  // 0x340
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorPreviewLPosMatricesReader;  // 0x348
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorPreviewMPosMatricesReader;  // 0x350
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* conveyorPreviewRPosMatricesReader;  // 0x358
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* conveyorInsideMatricesPtr;  // 0x360
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* guideFigureLPosMatricesBufferWriter;  // 0x368
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* guideFigureMPosMatricesBufferWriter;  // 0x370
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* guideFigureRPosMatricesBufferWriter;  // 0x378
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* guideFigureLPosMatricesBufferReader;  // 0x380
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* guideFigureMPosMatricesBufferReader;  // 0x388
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* guideFigureRPosMatricesBufferReader;  // 0x390
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeLPosMatricesBufferWriter;  // 0x398
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeMPosMatricesBufferWriter;  // 0x3a0
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeRPosMatricesBufferWriter;  // 0x3a8
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeLPosMatricesBufferReader;  // 0x3b0
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeMPosMatricesBufferReader;  // 0x3b8
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeRPosMatricesBufferReader;  // 0x3c0
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferWriter;  // 0x3c8
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferWriter;  // 0x3d0
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferWriter;  // 0x3d8
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferReader;  // 0x3e0
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferReader;  // 0x3e8
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferReader;  // 0x3f0
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Matrix4x4>* pipeHolderPosMatricesPtr;  // 0x3f8
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* comPosMatricesPtr;  // 0x400
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireNormalBufferWriter;  // 0x408
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireHsNormalBufferWriter;  // 0x410
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireDisableBufferWriter;  // 0x418
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireStrengthenBufferWriter;  // 0x420
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireHsStrengthenBufferWriter;  // 0x428
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireStrengthenDisableBufferWriter;  // 0x430
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireNormalBufferReader;  // 0x438
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireHsNormalBufferReader;  // 0x440
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireDisableBufferReader;  // 0x448
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireStrengthenBufferReader;  // 0x450
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireHsStrengthenBufferReader;  // 0x458
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* wireStrengthenDisableBufferReader;  // 0x460
        public System.Boolean levelShowForceUpdate;  // 0x468
        public System.Boolean conveyorEffectDirty;  // 0x469
        public System.Boolean pipeEffectDirty;  // 0x46a
        public Beyond.Gameplay.Factory.ConveyorInfoAllocator* conveyorInfoAllocator;  // 0x470
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest>* animatorParamRequestQueue;  // 0x478
        public Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData>* animatorAudioQueue;  // 0x480
        public static System.Int32 ID;  // const

        // Properties
        System.Boolean facSystemTickEnabled { get; /* RVA: 0x0312EE60 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> portBlockPosListReader { get; /* RVA: 0x02BC0770 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.OutputRendererInfo> outputUIPosListReader { get; /* RVA: 0x033B82C0 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> buildingStatePosListReader { get; /* RVA: 0x02BC0580 */ }
        System.IntPtr cargoMatricesBufferIntPtrReader { get; /* RVA: 0x03D55DF0 */ }
        System.Int32 cargoRendererCount { get; /* RVA: 0x024F4CF0 */ }
        System.Boolean cargoDirty { get; /* RVA: 0x024F5340 */ }
        System.IntPtr conveyorLPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E00 */ }
        System.IntPtr conveyorMPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E10 */ }
        System.IntPtr conveyorRPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E40 */ }
        System.Int32 lConveyorRenderCount { get; /* RVA: 0x02F51F40 */ }
        System.Int32 mConveyorRenderCount { get; /* RVA: 0x02F51F00 */ }
        System.Int32 rConveyorRenderCount { get; /* RVA: 0x02F51EC0 */ }
        System.Boolean conveyorDirty { get; /* RVA: 0x022BC460 */ }
        System.IntPtr portArrowMatricesIntPtrReader { get; /* RVA: 0x03D55EF0 */ }
        System.Int32 portArrowRenderCount { get; /* RVA: 0x02BBFE00 */ }
        System.Boolean portArrowDirty { get; /* RVA: 0x05797E84 */ }
        System.IntPtr conveyorPreviewLPosMatricesIntPtrReader { get; /* RVA: 0x03D55E20 */ }
        System.IntPtr conveyorPreviewMPosMatricesIntPtrReader { get; /* RVA: 0x01143890 */ }
        System.IntPtr conveyorPreviewRPosMatricesIntPtrReader { get; /* RVA: 0x03D55E30 */ }
        System.Int32 lConveyorPreviewRenderCount { get; /* RVA: 0x02F51E80 */ }
        System.Int32 mConveyorPreviewRenderCount { get; /* RVA: 0x02F51E40 */ }
        System.Int32 rConveyorPreviewRenderCount { get; /* RVA: 0x02F51E00 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> conveyorInsideMatricesReader { get; /* RVA: 0x02BC0220 */ }
        System.Boolean previewConveyorDirty { get; /* RVA: 0x022BC7A0 */ }
        System.IntPtr guideFigureLPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E50 */ }
        System.IntPtr guideFigureMPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E60 */ }
        System.IntPtr guideFigureRPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E70 */ }
        System.Int32 lGuideFigureRenderCount { get; /* RVA: 0x02F53700 */ }
        System.Int32 mGuideFigureRenderCount { get; /* RVA: 0x02F536C0 */ }
        System.Int32 rGuideFigureRenderCount { get; /* RVA: 0x02F53680 */ }
        System.Boolean guideFigureDirty { get; /* RVA: 0x022B9B60 */ }
        System.IntPtr pipeLPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55E90 */ }
        System.IntPtr pipeMPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55EA0 */ }
        System.IntPtr pipeRPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55EB0 */ }
        System.Int32 lPipeRenderCount { get; /* RVA: 0x02F53640 */ }
        System.Int32 mPipeRenderCount { get; /* RVA: 0x02F53600 */ }
        System.Int32 rPipeRenderCount { get; /* RVA: 0x02F535C0 */ }
        System.IntPtr pipeTrackLPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55EC0 */ }
        System.IntPtr pipeTrackMPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55ED0 */ }
        System.IntPtr pipeTrackRPosMatricesBufferIntPtrReader { get; /* RVA: 0x03D55EE0 */ }
        System.Int32 lPipeTrackRenderCount { get; /* RVA: 0x03365940 */ }
        System.Int32 mPipeTrackRenderCount { get; /* RVA: 0x03365900 */ }
        System.Int32 rPipeTrackRenderCount { get; /* RVA: 0x033658C0 */ }
        System.Boolean pipeDirty { get; /* RVA: 0x022BCAE0 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<UnityEngine.Matrix4x4> pipeHolderPosMatricesReader { get; /* RVA: 0x02F533F0 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> comPosMatricesReader { get; /* RVA: 0x02BC0640 */ }
        System.IntPtr wireNormalBufferIntPtrReader { get; /* RVA: 0x03D55F30 */ }
        System.IntPtr wireHsNormalBufferIntPtrReader { get; /* RVA: 0x03D55F10 */ }
        System.IntPtr wireDisableBufferIntPtrReader { get; /* RVA: 0x03D55F00 */ }
        System.IntPtr wireStrengthenBufferIntPtrReader { get; /* RVA: 0x03D55F40 */ }
        System.IntPtr wireHsStrengthenBufferIntPtrReader { get; /* RVA: 0x03D55F20 */ }
        System.IntPtr wireStrengthenDisableBufferIntPtrReader { get; /* RVA: 0x03D55F50 */ }
        System.Int32 wireNormalRendererCount { get; /* RVA: 0x024F47C0 */ }
        System.Int32 wireHsNormalRendererCount { get; /* RVA: 0x024F4800 */ }
        System.Int32 wireDisableRendererCount { get; /* RVA: 0x05797FD4 */ }
        System.Int32 wireStrengthenRendererCount { get; /* RVA: 0x0579804C */ }
        System.Int32 wireHsStrengthenRendererCount { get; /* RVA: 0x024F4840 */ }
        System.Int32 wireStrengthenDisableRendererCount { get; /* RVA: 0x05798010 */ }
        System.Boolean wireNormalDirty { get; /* RVA: 0x024F5560 */ }
        System.Boolean wireHsNormalDirty { get; /* RVA: 0x024F5780 */ }
        System.Boolean wireDisableDirty { get; /* RVA: 0x024F59A0 */ }
        System.Boolean wireStrengthenDirty { get; /* RVA: 0x024F5BC0 */ }
        System.Boolean wireHsStrengthenDirty { get; /* RVA: 0x024F5DE0 */ }
        System.Boolean wireStrengthenDisableDirty { get; /* RVA: 0x024F6000 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest> animatorParamRequestQueueReader { get; /* RVA: 0x05797DE8 */ }
        Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData> animatorAudioQueueWriter { get; /* RVA: 0x026DEF30 */ }
        System.Int32 id { get; /* RVA: 0x03D55E80 */ }

        // Methods
        // RVA: 0x0327B3C0  token: 0x60005B8
        public System.Void InitSkipFlag() { }
        // RVA: 0x03278AF0  token: 0x60005B9
        public System.Void CreateQueryResult() { }
        // RVA: 0x05797554  token: 0x60005BA
        public System.Void DisposeQueryResult() { }
        // RVA: 0x0579768C  token: 0x60005C0
        public System.Void SwapCargoBuffer() { }
        // RVA: 0x03D55D60  token: 0x60005C8
        public System.Void SetConveyorBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1) { }
        // RVA: 0x05797728  token: 0x60005C9
        public System.Void SwapConveyorBuffer() { }
        // RVA: 0x03D55DA0  token: 0x60005CD
        public System.Void SetPortArrowBuffers(System.Void* buffer0, System.Void* buffer1) { }
        // RVA: 0x05797A08  token: 0x60005CE
        public System.Void SwapPortArrowBuffer() { }
        // RVA: 0x03D55DB0  token: 0x60005D7
        public System.Void SetPreviewConveyorBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1) { }
        // RVA: 0x05797AA4  token: 0x60005D8
        public System.Void SwapPreviewConveyorBuffer() { }
        // RVA: 0x03D55D20  token: 0x60005E0
        public System.Void SeGuideFigureBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1) { }
        // RVA: 0x057977FC  token: 0x60005E1
        public System.Void SwapGuideFigureBuffer() { }
        // RVA: 0x03281170  token: 0x60005EF
        public System.Void SetPipeBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1, System.Void* trackLBuffer0, System.Void* trackLBuffer1, System.Void* trackMBuffer0, System.Void* trackMBuffer1, System.Void* trackRBuffer0, System.Void* trackRBuffer1) { }
        // RVA: 0x057978D0  token: 0x60005F0
        public System.Void SwapPipeBuffer() { }
        // RVA: 0x032810E0  token: 0x6000600
        public System.Void SetWireBuffer(System.Void* normal0, System.Void* normal1, System.Void* hsNormal0, System.Void* hsNormal1, System.Void* disable0, System.Void* disable1, System.Void* strengthen0, System.Void* strengthen1, System.Void* hsStrengthen0, System.Void* hsStrengthen1, System.Void* strengthenDisable0, System.Void* strengthenDisable1) { }
        // RVA: 0x05797B78  token: 0x6000601
        public System.Void SwapWireBuffer() { }
        // RVA: 0x024FBA60  token: 0x6000608
        public System.Void GetConveyorRendererInfo(System.UInt32 memoryStartOffset, System.Int32 countIdx, Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info*& info) { }
        // RVA: 0x02A8C040  token: 0x6000609
        public Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info& GetConveyorRendererInfo(System.UInt32 memoryStartOffset, System.Int32 countIdx) { }
        // RVA: 0x02A8DFF0  token: 0x600060A
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation AllocateConveyorInfo(System.Int32 count) { }
        // RVA: 0x02A90250  token: 0x600060B
        public System.Int64 CalculateConveyorInfoSize(System.UInt32 memoryOffset) { }
        // RVA: 0x039B1620  token: 0x600060C
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation ResizeConveyorInfo(System.UInt32 startIndex, System.Int32 count) { }
        // RVA: 0x05797624  token: 0x600060D
        public System.Void FreeConveyorInfo(System.UInt32 startIndex) { }
        // RVA: 0x05797500  token: 0x600060E
        public System.Void DebugAllocatorPrint() { }
        // RVA: 0x027D86B0  token: 0x6000610
        public System.Void AddSetAnimatorParamRequest(UnityEngine.HyperGryph.ECS.Entity logicEntity, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest rq) { }
        // RVA: 0x027D9290  token: 0x6000611
        private System.Void _AddAnimatorParamRequest(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity renderEntity, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest& rq) { }
        // RVA: 0x02764120  token: 0x6000613
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData& GetAudioVATDataAt(System.Int32 index) { }
        // RVA: 0x02764080  token: 0x6000614
        public System.Int32 GetAudioVATDataLength() { }
        // RVA: 0x027640D0  token: 0x6000615
        public System.Void ClearAudioVATData() { }
        // RVA: 0x03316880  token: 0x6000616
        public System.Void ResetFlags() { }
        // RVA: 0x05797CA4  token: 0x6000618
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000F3  // size: 0x20
    public sealed struct HealthPoleFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int64 currentProgress;  // 0x10
        public System.Int32 currentPoint;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55F70 */ }

        // Methods
        // RVA: 0x057982A0  token: 0x600061A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000F4  // size: 0x11
    public sealed struct InventoryFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55F80 */ }

        // Methods
        // RVA: 0x05798604  token: 0x600061C
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000F5
    public interface IPositionFragment
    {
        // Properties
        Unity.Mathematics.float3 Position { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x20000F6
    public interface IReactiveComponent : UnityEngine.HyperGryph.ECS.IComponentECS
    {
    }

    // TypeToken: 0x20000F7
    public interface INotificationComponent : Beyond.Gameplay.Factory.IReactiveComponent, UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Properties
        UnityEngine.HyperGryph.ECS.Entity eventEntity { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x20000F8
    public interface IRotateFragment
    {
        // Properties
        Unity.Mathematics.float3 Rotation { get; /* RVA: -1  // abstract */ }
        Unity.Mathematics.quaternion RotationQuaternion { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x20000F9
    public interface IUnitConfigRef
    {
        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x20000FA  // size: 0x11
    public sealed struct LiquidPurifierFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55FA0 */ }

        // Methods
        // RVA: 0x0579881C  token: 0x6000625
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000FB  // size: 0x2C
    public sealed struct LogisticEffectFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Unity.Mathematics.bool4 portStatusBits;  // 0x10
        public System.Boolean port0;  // 0x10
        public System.Boolean port1;  // 0x11
        public System.Boolean port2;  // 0x12
        public System.Boolean port3;  // 0x13
        public Unity.Mathematics.bool4 portDirectionBits;  // 0x14
        public System.Boolean portDirection0;  // 0x14
        public System.Boolean portDirection1;  // 0x15
        public System.Boolean portDirection2;  // 0x16
        public System.Boolean portDirection3;  // 0x17
        public Unity.Mathematics.bool4 currentPortStatusBits;  // 0x18
        public System.Boolean currentPort0;  // 0x18
        public System.Boolean currentPort1;  // 0x19
        public System.Boolean currentPort2;  // 0x1a
        public System.Boolean currentPort3;  // 0x1b
        public Unity.Mathematics.float4 duration;  // 0x1c
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55FB0 */ }

        // Methods
        // RVA: 0x05798928  token: 0x6000627
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000FC  // size: 0x81C
    public sealed struct LogisticEntityBindFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.EntityData256<UnityEngine.HyperGryph.ECS.Entity> cargoEntities;  // 0x10
        public System.UInt32 conveyorExtHandle;  // 0x818
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 cargoCount { get; /* RVA: 0x02BC1430 */ }
        System.Int32 id { get; /* RVA: 0x03D55FC0 */ }

        // Methods
        // RVA: 0x023F8BC0  token: 0x6000628
        public System.Void EnqueueCargoEntityImpl(UnityEngine.HyperGryph.ECS.Entity cargoEntity, System.UInt32 conveyorSharedDataIndex) { }
        // RVA: 0x023F8730  token: 0x6000629
        public System.Boolean DequeueCargoEntityImpl(UnityEngine.HyperGryph.ECS.Entity& cargoEntity) { }
        // RVA: 0x05798AC0  token: 0x600062A
        public System.Void Arrive(Beyond.Gameplay.Factory.CargoFragment& cargo, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt* conveyorExtData) { }
        // RVA: 0x05798A48  token: 0x600062B
        public System.Void Arrive(UnityEngine.HyperGryph.ECS.Entity cargoEntity, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt* conveyorExtData) { }
        // RVA: 0x05798AF0  token: 0x600062E
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000FD  // size: 0x14
    public sealed struct MapGridRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        private System.Int32 <unitAssetInstanceId>k__BackingField;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D55FD0 */ }

        // Methods
        // RVA: 0x05798C3C  token: 0x6000632
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x20000FE  // size: 0xB0
    public sealed struct OutputFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Unity.Mathematics.int3 itemAll;  // 0x10
        public Unity.Mathematics.float4x3 rarityColorAll;  // 0x1c
        public Unity.Mathematics.float4x3 atlasRectAll;  // 0x4c
        public System.Byte enableLiquidIcon;  // 0x7c
        public Unity.Mathematics.float4x3 liquidAtlasUV;  // 0x7d
        public static readonly System.Int32 MAX_OUTPUT;  // static @ 0x0
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 Item { get; /* RVA: 0x03D55FF0 */ set; /* RVA: 0x03D56010 */ }
        System.Boolean hasOutput { get; /* RVA: 0x05799454 */ }
        System.Int32 id { get; /* RVA: 0x03D56000 */ }

        // Methods
        // RVA: 0x02752430  token: 0x6000633
        public System.Void Clean() { }
        // RVA: 0x057990D8  token: 0x6000636
        public Unity.Mathematics.float4& GetColor(System.Int32 index) { }
        // RVA: 0x05799290  token: 0x6000637
        public System.Void SetColor(System.Int32 index, Unity.Mathematics.float4 color) { }
        // RVA: 0x02C04040  token: 0x6000638
        public System.Void SetColor(System.Int32 index, UnityEngine.Color color) { }
        // RVA: 0x0579920C  token: 0x6000639
        public System.Void SetAtlasRect(System.Int32 index, Unity.Mathematics.float4 rect) { }
        // RVA: 0x02C03770  token: 0x600063A
        public System.Void SetAtlasRect(System.Int32 index, UnityEngine.RectInt rect) { }
        // RVA: 0x05799074  token: 0x600063B
        public Unity.Mathematics.float4& GetAtlasRect(System.Int32 index) { }
        // RVA: 0x0579913C  token: 0x600063C
        public System.Boolean GetEnableLiquidIcon(System.Int32 index) { }
        // RVA: 0x02C04090  token: 0x600063D
        public System.Void SetEnableLiquidIcon(System.Int32 index, System.Boolean enable) { }
        // RVA: 0x057991A8  token: 0x600063E
        public Unity.Mathematics.float4& GetLiquidIconUV(System.Int32 index) { }
        // RVA: 0x02C04100  token: 0x600063F
        public System.Void SetLiquidIconUV(System.Int32 index, UnityEngine.RectInt rect) { }
        // RVA: 0x05799314  token: 0x6000642
        private System.Void __AOT_FOR_FIX__() { }
        // RVA: 0x03D43FA0  token: 0x6000643
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000FF  // size: 0x14
    public sealed struct OutputUIRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D56020 */ }

        // Methods
        // RVA: 0x057994B8  token: 0x6000647
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000100  // size: 0x4C
    public sealed struct PedestalLightFlashFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte status;  // 0x10
        public System.Single intensity;  // 0x14
        public System.Single flashIntensity;  // 0x18
        public System.Single flashDuration;  // 0x1c
        public System.Boolean flash;  // 0x20
        public System.Int32 flashSpeed;  // 0x24
        public System.Single flashStatusLerpTime;  // 0x28
        public Unity.Mathematics.float4 color;  // 0x2c
        public Unity.Mathematics.float4 flashColor;  // 0x3c
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56040 */ }

        // Methods
        // RVA: 0x05799BFC  token: 0x6000649
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000101  // size: 0x2F0
    public sealed struct PedestalLightFlashConfigFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<intensity>e__FixedBuffer intensity;  // 0x10
        public Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<flashIntensity>e__FixedBuffer flashIntensity;  // 0x50
        public Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<flashDuration>e__FixedBuffer flashDuration;  // 0x90
        public Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<flash>e__FixedBuffer flash;  // 0xd0
        public Beyond.Gameplay.Factory.Float4Data16<Unity.Mathematics.float4> color;  // 0xe0
        public Beyond.Gameplay.Factory.Float4Data16<Unity.Mathematics.float4> flashColor;  // 0x1e8
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56030 */ }

        // Methods
        // RVA: 0x05799A3C  token: 0x600064A
        public System.Boolean IsValid() { }
        // RVA: 0x0276B1A0  token: 0x600064B
        public System.Void SetIntensity(System.Int32 idx, System.Single value) { }
        // RVA: 0x0276B110  token: 0x600064C
        public System.Void SetFlashIntensity(System.Int32 idx, System.Single value) { }
        // RVA: 0x0276B230  token: 0x600064D
        public System.Void SetFlash(System.Int32 idx, System.Boolean value) { }
        // RVA: 0x0276B080  token: 0x600064E
        public System.Void SetFlashDuration(System.Int32 idx, System.Single value) { }
        // RVA: 0x0276B2D0  token: 0x600064F
        public System.Void SetColor(System.Int32 idx, UnityEngine.Color value) { }
        // RVA: 0x0276B430  token: 0x6000650
        public System.Void SetFlashColor(System.Int32 idx, UnityEngine.Color value) { }
        // RVA: 0x057999E0  token: 0x6000651
        public System.Single GetIntensity(System.Int32 idx) { }
        // RVA: 0x05799924  token: 0x6000652
        public System.Single GetFlashIntensity(System.Int32 idx) { }
        // RVA: 0x05799980  token: 0x6000653
        public System.Boolean GetFlash(System.Int32 idx) { }
        // RVA: 0x057998C4  token: 0x6000654
        public System.Single GetFlashDuration(System.Int32 idx) { }
        // RVA: 0x05799674  token: 0x6000655
        public Unity.Mathematics.float4 GetColor(System.Int32 idx) { }
        // RVA: 0x0579979C  token: 0x6000656
        public Unity.Mathematics.float4 GetFlashColor(System.Int32 idx) { }
        // RVA: 0x05799AB8  token: 0x6000658
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000106  // size: 0x198
    public sealed struct PipeEffectFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.IntData32<System.UInt32> pipeEffectInstanceId;  // 0x10
        public Unity.Collections.FixedString64Bytes inEffectName;  // 0x98
        public Unity.Collections.FixedString64Bytes outEffectName;  // 0xd8
        public Unity.Collections.FixedString64Bytes inEffectConnectedName;  // 0x118
        public Unity.Collections.FixedString64Bytes outEffectConnectedName;  // 0x158
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56060 */ }

        // Methods
        // RVA: 0x05799E44  token: 0x600065A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000107  // size: 0x8C
    public sealed struct PipeFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.ILogisticSample
    {
        // Fields
        public static readonly System.Single PIPE_HEIGHT;  // static @ 0x0
        public System.UInt32 factoryUnitId;  // 0x10
        public System.Boolean validMode;  // 0x14
        public System.Single pipeHeight;  // 0x18
        public System.Single currentWaterThickness;  // 0x1c
        public System.Single waterFlowDeltaTime;  // 0x20
        public System.Single waterThickness;  // 0x24
        public System.Single speed;  // 0x28
        public System.Int32 waterDirection;  // 0x2c
        public System.Int32 subItemType;  // 0x30
        public System.Boolean entranceConnected;  // 0x34
        public System.Boolean exitConnected;  // 0x35
        public Unity.Mathematics.float3 entranceGroundAdjustPos;  // 0x38
        public Unity.Mathematics.float3 exitGroundAdjustPos;  // 0x44
        public Unity.Mathematics.float3 entrancePortDirection;  // 0x50
        public Unity.Mathematics.float3 exitPortDirection;  // 0x5c
        public System.Single bend;  // 0x68
        public UnityEngine.Rect bounds;  // 0x6c
        public System.UInt32 itemId;  // 0x7c
        private System.Int32 <length>k__BackingField;  // 0x80
        public System.UInt32 startMemoryOffsetHandle;  // 0x84
        public System.UInt32 endMemoryOffsetHandle;  // 0x88
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 length { get; /* RVA: 0x03D4F0C0 */ set; /* RVA: 0x03D4F0F0 */ }
        System.Int32 id { get; /* RVA: 0x03D56070 */ }

        // Methods
        // RVA: 0x02A8D600  token: 0x600065D
        public System.Boolean SetInflection(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Collections.NativeList<Unity.Mathematics.float3>& p, Unity.Collections.NativeList<Unity.Mathematics.float3>& r, Unity.Collections.NativeList<System.Byte>& proto) { }
        // RVA: 0x02A8BED0  token: 0x600065E
        public static System.Void Bend(Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 pipeLength, System.UInt32 startMemoryOffsetHandle, System.Single pipeHeight, System.Boolean bOverrideEntranceY, System.Single overrideEntranceY, System.Boolean bOverrideExitY, System.Single overrideExitY) { }
        // RVA: 0x02AAF1E0  token: 0x600065F
        public static System.ValueTuple<System.Int32[],System.Int32> GetCornerIndexList(Beyond.Gameplay.Factory.GlobalEnv& env, System.UInt32 startMemoryOffsetHandle, System.Int32 length) { }
        // RVA: 0x024FB6F0  token: 0x6000660
        public virtual System.Boolean Sample(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Mathematics.float2 p, System.UInt32& unitId, System.Int32& indexInPipe) { }
        // RVA: 0x0579A1C8  token: 0x6000661
        public virtual System.Boolean IsInRect(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax) { }
        // RVA: 0x028BF7C0  token: 0x6000662
        public virtual System.Boolean GetInRectUnitIndex(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, Beyond.PoolCore.PooledList<System.Int32>& unitIndex) { }
        // RVA: 0x05799F88  token: 0x6000663
        public virtual System.Boolean FillRectTargets(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.ValueTuple<System.UInt32,System.Int32>[,]& rectTargets) { }
        // RVA: 0x0579A38C  token: 0x6000665
        private System.Void __AOT_FOR_FIX__() { }
        // RVA: 0x03D43EA0  token: 0x6000666
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000108  // size: 0x1C
    public sealed struct PipeHolderFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 indexInPipe;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity pipeEntity;  // 0x14
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56080 */ }

        // Methods
        // RVA: 0x0579A4C8  token: 0x6000668
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000109  // size: 0x11
    public sealed struct PipeLogisticsUnitFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56090 */ }

        // Methods
        // RVA: 0x0579A5E4  token: 0x600066A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200010A  // size: 0x30
    public sealed struct PipeComRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public Unity.Mathematics.float3 position;  // 0x14
        public Unity.Mathematics.quaternion rotation;  // 0x20
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D56050 */ }

        // Methods
        // RVA: 0x05799D28  token: 0x600066E
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200010B  // size: 0x58
    public sealed struct PipeRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public System.Int32 indexInPipe;  // 0x14
        public Unity.Collections.FixedString32Bytes prototype;  // 0x18
        public Unity.Mathematics.float3 position;  // 0x38
        public System.Single scale;  // 0x44
        public Unity.Mathematics.quaternion rotation;  // 0x48
        public UnityEngine.HyperGryph.HGFactoryEntityTransformData transformData;  // 0x38
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D560D0 */ }

        // Methods
        // RVA: 0x0579AA24  token: 0x6000672
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200010C  // size: 0x30
    public sealed struct PipeTrackRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public Unity.Mathematics.float3 position;  // 0x14
        public Unity.Mathematics.quaternion rotation;  // 0x20
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D560E0 */ }

        // Methods
        // RVA: 0x0579AB48  token: 0x6000676
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200010D  // size: 0x82C
    public sealed struct ComplexPortFragment : UnityEngine.HyperGryph.ECS.IComponentECS, System.IEquatable`1
    {
        // Fields
        public Beyond.Gameplay.Factory.PortData32<Beyond.Gameplay.Factory.PortData> ports;  // 0x10
        public Unity.Mathematics.int2 pedestalPortCount;  // 0x818
        public Unity.Mathematics.int2 pipePortCount;  // 0x820
        public System.Boolean dataInit;  // 0x828
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D55AB0 */ }

        // Methods
        // RVA: 0x028B67B0  token: 0x6000677
        public System.Boolean BindComponentId(System.UInt32 componentId, System.Int32 idx, System.Boolean isInput, System.Boolean isBlock, System.UInt32 touchComId, System.Boolean& pipeChanged) { }
        // RVA: 0x05792B24  token: 0x6000678
        public System.Boolean BlockPortsWithComponentId(System.UInt32 componentId, System.Boolean isBlock, System.Int32[] portIndices) { }
        // RVA: 0x028B7240  token: 0x6000679
        public System.Boolean BlockPorts(System.Boolean isBlock, System.Collections.Generic.List<System.Int32> portIndices, System.Boolean input) { }
        // RVA: 0x028B6A90  token: 0x600067A
        public System.Void FollowUnit(Unity.Mathematics.float3 worldPos, Unity.Mathematics.float3 worldDir, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& portConfig, Beyond.Gameplay.Factory.UnitConfigFragment& unitConfig, System.Single effectOffset) { }
        // RVA: 0x057929B0  token: 0x600067B
        public System.Boolean AnyPortBlocked() { }
        // RVA: 0x05792A6C  token: 0x600067C
        public System.Boolean AnyPortConnected() { }
        // RVA: 0x05792D60  token: 0x600067D
        public virtual System.Boolean Equals(Beyond.Gameplay.Factory.ComplexPortFragment other) { }
        // RVA: 0x05792CA4  token: 0x600067E
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x05792F54  token: 0x600067F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x05793510  token: 0x6000680
        public static System.Boolean op_Equality(Beyond.Gameplay.Factory.ComplexPortFragment left, Beyond.Gameplay.Factory.ComplexPortFragment right) { }
        // RVA: 0x057935D4  token: 0x6000681
        public static System.Boolean op_Inequality(Beyond.Gameplay.Factory.ComplexPortFragment left, Beyond.Gameplay.Factory.ComplexPortFragment right) { }
        // RVA: 0x05793148  token: 0x6000682
        public virtual System.String ToString() { }
        // RVA: 0x057933C4  token: 0x6000684
        private System.Void __AOT_FOR_FIX__() { }
        // RVA: 0x05793290  token: 0x6000685
        public System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        // RVA: 0x05793304  token: 0x6000686
        public System.Int32 <>iFixBaseProxy_GetHashCode() { }
        // RVA: 0x05793364  token: 0x6000687
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200010E  // size: 0x40
    public sealed struct PortData : System.IEquatable`1
    {
        // Fields
        public System.Byte idx;  // 0x10
        public System.Boolean isInput;  // 0x11
        public System.Boolean isPipe;  // 0x12
        public System.Boolean isBlock;  // 0x13
        public System.Boolean valid;  // 0x14
        public System.Boolean evaluated;  // 0x15
        public System.UInt32 touchComId;  // 0x18
        public System.UInt32 bindComId;  // 0x1c
        public System.UInt32 touchNodeId;  // 0x20
        public Unity.Mathematics.float3 worldPos;  // 0x24
        public Unity.Mathematics.quaternion worldDir;  // 0x30

        // Methods
        // RVA: 0x057A698C  token: 0x6000688
        public Unity.Mathematics.float4x4 TRS() { }
        // RVA: 0x057A666C  token: 0x6000689
        public virtual System.Boolean Equals(Beyond.Gameplay.Factory.PortData other) { }
        // RVA: 0x057A65B4  token: 0x600068A
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x057A67C4  token: 0x600068B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x057A6E40  token: 0x600068C
        public static System.Boolean op_Equality(Beyond.Gameplay.Factory.PortData left, Beyond.Gameplay.Factory.PortData right) { }
        // RVA: 0x057A6F00  token: 0x600068D
        public static System.Boolean op_Inequality(Beyond.Gameplay.Factory.PortData left, Beyond.Gameplay.Factory.PortData right) { }
        // RVA: 0x057A6A5C  token: 0x600068E
        public virtual System.String ToString() { }
        // RVA: 0x057A6DE0  token: 0x600068F
        public System.String <>iFixBaseProxy_ToString() { }
        // RVA: 0x057A6D10  token: 0x6000690
        public System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        // RVA: 0x057A6D80  token: 0x6000691
        public System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200010F  // size: 0x14
    public sealed struct PortPreviewUIRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D56380 */ }

        // Methods
        // RVA: 0x057A6FC4  token: 0x6000695
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000110  // size: 0x14
    public sealed struct PortStatusUIFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D56390 */ }

        // Methods
        // RVA: 0x057A70D0  token: 0x6000699
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000111  // size: 0x11
    public sealed struct PowerPoleFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D563A0 */ }

        // Methods
        // RVA: 0x057A71DC  token: 0x600069B
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000112  // size: 0x28
    public sealed struct ProducerFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt32 componentId;  // 0x10
        public System.Int64 currentProgress;  // 0x18
        public System.UInt32 formulaId;  // 0x20
        public System.UInt32 lastFormulaId;  // 0x24
        public static System.Int32 ID;  // const

        // Properties
        System.UInt32 outputFormulaId { get; /* RVA: 0x02752540 */ }
        System.Int32 id { get; /* RVA: 0x03D563B0 */ }

        // Methods
        // RVA: 0x057A72E8  token: 0x600069E
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000113  // size: 0x14
    public sealed struct SharedDataFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt32 dataHandle;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D563E0 */ }

        // Methods
        // RVA: 0x024FD3F0  token: 0x600069F
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetExtData() { }
        // RVA: 0x03854080  token: 0x60006A0
        public System.Void DestroyData() { }
        // RVA: 0x057A7FE4  token: 0x60006A2
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000114  // size: 0x14
    public sealed struct SocialBuildingStates
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.SocialBuildingStates Invalid;  // const
        public static Beyond.Gameplay.Factory.SocialBuildingStates Disable;  // const
        public static Beyond.Gameplay.Factory.SocialBuildingStates Unlocked;  // const
        public static Beyond.Gameplay.Factory.SocialBuildingStates Activated;  // const
        public static Beyond.Gameplay.Factory.SocialBuildingStates Locked;  // const

    }

    // TypeToken: 0x2000115  // size: 0x48
    public sealed struct SocialFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt32 socialState;  // 0x10
        public System.UInt64 ownerId;  // 0x14
        public System.UInt32 socialNodeId;  // 0x1c
        public System.UInt64 like;  // 0x20
        public System.Int64 lastSetLikeTs;  // 0x28
        public System.Int64 expirationTs;  // 0x30
        public Beyond.Gameplay.Factory.SignData signData;  // 0x38
        public System.Boolean isPreset;  // 0x44
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D563F0 */ }

        // Methods
        // RVA: 0x029BCFF0  token: 0x60006A3
        public static Beyond.Gameplay.Factory.SocialFragment Create(System.UInt64 ownerId, System.UInt32 socialNodeId, System.UInt64 like, System.Int64 lastSetLikeTs, System.Int64 expirationTs, System.UInt32 socialState, System.Boolean isPreset) { }
        // RVA: 0x02F870F0  token: 0x60006A4
        public System.Boolean IsHighLiked() { }
        // RVA: 0x057A8288  token: 0x60006A5
        public System.Boolean IsLiked() { }
        // RVA: 0x057A8304  token: 0x60006A7
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000117  // size: 0x1C
    public sealed struct SignData
    {
        // Fields
        public Unity.Mathematics.uint3 content;  // 0x10
        public static System.Int32 CONTENT_LENGTH;  // const

        // Methods
        // RVA: 0x057A80F0  token: 0x60006A8
        public System.String GetText() { }
        // RVA: 0x02F887D0  token: 0x60006A9
        public static System.Single GetCustomPerDrawData(FactoryUIAtlas.FactoryUIAtlasSOData config, Unity.Mathematics.uint3 content) { }
        // RVA: 0x02F877C0  token: 0x60006AA
        public static System.Void SetSignBuildingIcon(FactoryUIAtlas.FactoryUIAtlasSOData data, UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity) { }
        // RVA: 0x02F882B0  token: 0x60006AB
        public static System.Void SetSignBuildingIconWithRenderEntity(FactoryUIAtlas.FactoryUIAtlasSOData config, UnityEngine.HyperGryph.ECS.Entity rEntity, Unity.Mathematics.uint3 iconId) { }

    }

    // TypeToken: 0x2000118  // size: 0x30
    public sealed struct LocalTransform : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Unity.Mathematics.float3 position;  // 0x10
        public System.Single scale;  // 0x1c
        public Unity.Mathematics.quaternion rotation;  // 0x20
        public UnityEngine.HyperGryph.HGFactoryEntityTransformData entityTransformData;  // 0x10
        public static readonly Beyond.Gameplay.Factory.LocalTransform Identity;  // static @ 0x0
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D562A0 */ }

        // Methods
        // RVA: 0x057A458C  token: 0x60006AC
        public static Beyond.Gameplay.Factory.LocalTransform FromMatrix(Unity.Mathematics.float4x4 matrix) { }
        // RVA: 0x057A4028  token: 0x60006AD
        public static Beyond.Gameplay.Factory.LocalTransform FromMatrixSafe(Unity.Mathematics.float4x4 matrix) { }
        // RVA: 0x057A4838  token: 0x60006AE
        public static Beyond.Gameplay.Factory.LocalTransform FromPositionRotation(Unity.Mathematics.float3 position, Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x0276A190  token: 0x60006AF
        public static Beyond.Gameplay.Factory.LocalTransform FromPositionRotationScale(Unity.Mathematics.float3 position, Unity.Mathematics.quaternion rotation, System.Single scale) { }
        // RVA: 0x057A49EC  token: 0x60006B0
        public static Beyond.Gameplay.Factory.LocalTransform FromPosition(Unity.Mathematics.float3 position) { }
        // RVA: 0x057A4904  token: 0x60006B1
        public static Beyond.Gameplay.Factory.LocalTransform FromPosition(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x057A4ABC  token: 0x60006B2
        public static Beyond.Gameplay.Factory.LocalTransform FromRotation(Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x057A4B84  token: 0x60006B3
        public static Beyond.Gameplay.Factory.LocalTransform FromScale(System.Single scale) { }
        // RVA: 0x057A5710  token: 0x60006B4
        public virtual System.String ToString() { }
        // RVA: 0x057A5208  token: 0x60006B5
        public Unity.Mathematics.float3 Right() { }
        // RVA: 0x057A5A84  token: 0x60006B6
        public Unity.Mathematics.float3 Up() { }
        // RVA: 0x057A3F50  token: 0x60006B7
        public Unity.Mathematics.float3 Forward() { }
        // RVA: 0x030B6370  token: 0x60006B8
        public Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3 point) { }
        // RVA: 0x057A4D34  token: 0x60006B9
        public Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3 point) { }
        // RVA: 0x057A5874  token: 0x60006BA
        public Unity.Mathematics.float3 TransformDirection(Unity.Mathematics.float3 direction) { }
        // RVA: 0x057A4C5C  token: 0x60006BB
        public Unity.Mathematics.float3 InverseTransformDirection(Unity.Mathematics.float3 direction) { }
        // RVA: 0x030B6300  token: 0x60006BC
        public Unity.Mathematics.quaternion TransformRotation(Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x057A4E70  token: 0x60006BD
        public Unity.Mathematics.quaternion InverseTransformRotation(Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x030B62C0  token: 0x60006BE
        public System.Single TransformScale(System.Single scale) { }
        // RVA: 0x057A4F30  token: 0x60006BF
        public System.Single InverseTransformScale(System.Single scale) { }
        // RVA: 0x030B6160  token: 0x60006C0
        public Beyond.Gameplay.Factory.LocalTransform TransformTransform(Beyond.Gameplay.Factory.LocalTransform& transformData) { }
        // RVA: 0x057A4F90  token: 0x60006C1
        public Beyond.Gameplay.Factory.LocalTransform InverseTransformTransform(Beyond.Gameplay.Factory.LocalTransform& transformData) { }
        // RVA: 0x057A50C8  token: 0x60006C2
        public Beyond.Gameplay.Factory.LocalTransform Inverse() { }
        // RVA: 0x028B4C60  token: 0x60006C3
        public Unity.Mathematics.float4x4 ToMatrix() { }
        // RVA: 0x057A5634  token: 0x60006C4
        public Unity.Mathematics.float4x4 ToInverseMatrix() { }
        // RVA: 0x057A5B5C  token: 0x60006C5
        public Beyond.Gameplay.Factory.LocalTransform WithPosition(Unity.Mathematics.float3 p) { }
        // RVA: 0x057A5C18  token: 0x60006C6
        public Beyond.Gameplay.Factory.LocalTransform WithPosition(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x057A5CF8  token: 0x60006C7
        public Beyond.Gameplay.Factory.LocalTransform WithRotation(Unity.Mathematics.quaternion r) { }
        // RVA: 0x057A5DB0  token: 0x60006C8
        public Beyond.Gameplay.Factory.LocalTransform WithScale(System.Single s) { }
        // RVA: 0x057A5934  token: 0x60006C9
        public Beyond.Gameplay.Factory.LocalTransform Translate(Unity.Mathematics.float3 translation) { }
        // RVA: 0x057A3DFC  token: 0x60006CA
        public Beyond.Gameplay.Factory.LocalTransform ApplyScale(System.Single scale) { }
        // RVA: 0x057A5550  token: 0x60006CB
        public Beyond.Gameplay.Factory.LocalTransform Rotate(Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x057A52D4  token: 0x60006CC
        public Beyond.Gameplay.Factory.LocalTransform RotateX(System.Single angle) { }
        // RVA: 0x057A53A8  token: 0x60006CD
        public Beyond.Gameplay.Factory.LocalTransform RotateY(System.Single angle) { }
        // RVA: 0x057A547C  token: 0x60006CE
        public Beyond.Gameplay.Factory.LocalTransform RotateZ(System.Single angle) { }
        // RVA: 0x057A3EA8  token: 0x60006CF
        public System.Boolean Equals(Beyond.Gameplay.Factory.LocalTransform& other) { }
        // RVA: 0x057A5E54  token: 0x60006D1
        private System.Void __AOT_FOR_FIX__() { }
        // RVA: 0x03CBD130  token: 0x60006D2
        private static System.Void .cctor() { }
        // RVA: 0x057A5A2C  token: 0x60006D3
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000119  // size: 0x11
    public sealed struct Root : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D563D0 */ }

        // Methods
        // RVA: 0x057A7A94  token: 0x60006D5
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200011A  // size: 0x18
    public sealed struct Parent : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity value;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56370 */ }

        // Methods
        // RVA: 0x057A5FD4  token: 0x60006D7
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200011B  // size: 0x118
    public sealed struct Child : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.EntityData32<UnityEngine.HyperGryph.ECS.Entity> value;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56220 */ }

        // Methods
        // RVA: 0x057A2850  token: 0x60006D9
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200011C  // size: 0x9C
    public sealed struct LocalToWorld : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Unity.Mathematics.float4x4 READ_ONLY_VAL;  // 0x10
        public Unity.Mathematics.float4x4 PRE_FRAME_READ_ONLY_VAL;  // 0x50
        public System.UInt32 hierarchyHandle;  // 0x90
        public System.Boolean dirty;  // 0x94
        public System.Int32 calcFrameCount;  // 0x98
        public static System.Int32 ID;  // const

        // Properties
        Unity.Mathematics.float3 right { get; /* RVA: 0x057A3D0C */ }
        Unity.Mathematics.float3 up { get; /* RVA: 0x057A3D84 */ }
        Unity.Mathematics.float3 forward { get; /* RVA: 0x057A3B64 */ }
        Unity.Mathematics.float3 position { get; /* RVA: 0x028B41D0 */ }
        Unity.Mathematics.quaternion rotation { get; /* RVA: 0x028B4E70 */ }
        Unity.Mathematics.float3 prePosition { get; /* RVA: 0x057A3BDC */ }
        Unity.Mathematics.quaternion preRotation { get; /* RVA: 0x057A3C54 */ }
        Unity.Mathematics.float4x4* READ_ONLY_VAL_PTR { get; /* RVA: 0x0339AE90 */ }
        Unity.Mathematics.float4x4* PRE_FRAME_READ_ONLY_VAL_PTR { get; /* RVA: 0x03D56280 */ }
        System.Int32 id { get; /* RVA: 0x03D56290 */ }

        // Methods
        // RVA: 0x028B47E0  token: 0x60006DA
        public System.Boolean SetValue(Unity.Mathematics.float4x4 value, System.Int32 frameCount) { }
        // RVA: 0x057A3A24  token: 0x60006E5
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200011D  // size: 0x20
    public sealed struct UdPipeFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 connectedCompId;  // 0x10
        public System.Int32 offset;  // 0x18
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D564A0 */ }

        // Methods
        // RVA: 0x057A8700  token: 0x60006E7
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200011E  // size: 0x68
    public sealed struct UnitConfigFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public System.Int32 powerCost;  // 0x14
        public System.Boolean isShowOutputUI;  // 0x18
        public System.Boolean needPower;  // 0x19
        public System.Boolean hidePreviewArrow;  // 0x1a
        public System.Int16 inputPortCount;  // 0x1c
        public System.Int16 outputPortCount;  // 0x1e
        public System.Int32 facBuildingType;  // 0x20
        public Unity.Mathematics.float3 bounds;  // 0x24
        public System.Int32 unitNameFastString;  // 0x30
        public System.Int32 iconOnPanelFastString;  // 0x34
        public Beyond.Gameplay.Factory.UnitConfigInternal baseConfig;  // 0x38
        public static System.Int32 ID;  // const

        // Properties
        System.String iconOnPanel { get; /* RVA: 0x04272998 */ set; /* RVA: 0x04274E78 */ }
        System.String unitName { get; /* RVA: 0x057A8940 */ set; /* RVA: 0x057A894C */ }
        System.Int32 id { get; /* RVA: 0x03D564B0 */ }

        // Methods
        // RVA: 0x057A8818  token: 0x60006ED
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200011F  // size: 0x40
    public sealed struct UnitConfigInternal
    {
        // Fields
        public UnityEngine.Bounds bounds;  // 0x10
        public UnityEngine.Bounds buildingBounds;  // 0x28

    }

    // TypeToken: 0x2000120  // size: 0x34
    public sealed struct FactoryUnitPortConfig
    {
        // Fields
        public System.Int32 portIdx;  // 0x10
        public System.Int32 globalPortIdx;  // 0x14
        public System.Boolean inOut;  // 0x18
        public System.Boolean isPipe;  // 0x19
        public Unity.Mathematics.float3 pos;  // 0x1c
        public Unity.Mathematics.float3 dir;  // 0x28

    }

    // TypeToken: 0x2000121  // size: 0x54
    public sealed struct FactoryUnitExtendConfig
    {
        // Fields
        public Unity.Collections.FixedString32Bytes nameRaw;  // 0x10
        public Unity.Mathematics.float3 pos;  // 0x30
        public Unity.Mathematics.quaternion rot;  // 0x3c
        private System.Int32 <unLoaderIndex>k__BackingField;  // 0x4c
        private System.Boolean <isUnLoader>k__BackingField;  // 0x50

        // Properties
        System.String name { get; /* RVA: 0x04270A90 */ }
        System.Int32 unLoaderIndex { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x03D4EDC0 */ }
        System.Boolean isUnLoader { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }

        // Methods
        // RVA: 0x057A2E9C  token: 0x60006F3
        public virtual System.String ToString() { }
        // RVA: 0x057A308C  token: 0x60006F4
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000122  // size: 0x18
    public sealed struct UnitInteractFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.UInt64 interactObjectId;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D564C0 */ }

        // Methods
        // RVA: 0x057A8AB8  token: 0x60006F6
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000123  // size: 0x68
    public sealed struct UnitRenderFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.UInt32 logicNodeId;  // 0x10
        public System.Int32 partGuid;  // 0x14
        public UnityEngine.HyperGryph.ECS.Entity logicEntity;  // 0x18
        public System.Int32 assetHashGuid;  // 0x20
        public System.Boolean isSkipVATAnimation;  // 0x24
        public System.Single frameRate;  // 0x28
        public Unity.Mathematics.float3 bounds;  // 0x2c
        public UnityEngine.Bounds buildingBounds;  // 0x38
        public Unity.Mathematics.bool2 buildDismissEffectEnabled;  // 0x50
        public Unity.Mathematics.float4 customArg0;  // 0x54
        public System.Int32 unitConfigAssetInstanceId;  // 0x64
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4EEC0 */ set; /* RVA: 0x03D4EF10 */ }
        System.Int32 id { get; /* RVA: 0x03D564E0 */ }

        // Methods
        // RVA: 0x057A8FC8  token: 0x60006FA
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000124  // size: 0x34
    public sealed struct RenderLookAtFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean lookAtEnable;  // 0x10
        public System.Boolean lookAtArrived;  // 0x11
        public System.Boolean yawEnabled;  // 0x12
        public System.Boolean pitchEnabled;  // 0x13
        public Unity.Mathematics.quaternion deltaQuaternion;  // 0x14
        public Unity.Mathematics.float3 targetPos;  // 0x24
        public Unity.Mathematics.half interpolation;  // 0x30
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D563C0 */ }

        // Methods
        // RVA: 0x057A7970  token: 0x60006FC
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000125  // size: 0x20
    public sealed struct ChapterTagFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Int32 chapterId;  // 0x10
        public System.Int32 mapId;  // 0x14
        public System.Int32 panelIndex;  // 0x18
        public System.Int32 sceneId;  // 0x1c
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56210 */ }

        // Methods
        // RVA: 0x057A2738  token: 0x60006FE
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000126  // size: 0x13
    public sealed struct UnitStatusFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte preStatus;  // 0x10
        public System.Byte status;  // 0x11
        public System.Byte subStatus;  // 0x12
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56500 */ }

        // Methods
        // RVA: 0x057A923C  token: 0x6000700
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000127  // size: 0x11
    public sealed struct UnitOverrideStatusFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean working;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D564D0 */ }

        // Methods
        // RVA: 0x057A8BC4  token: 0x6000702
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000128  // size: 0x141C
    public sealed struct UnitStatusEffectFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.StatusNormalEffect normal;  // 0x10
        public Beyond.Gameplay.Factory.StatusClosedEffect closed;  // 0x210
        public Beyond.Gameplay.Factory.StatusIdleEffect idle;  // 0x410
        public Beyond.Gameplay.Factory.StatusBlockedEffect blocked;  // 0x610
        public Beyond.Gameplay.Factory.StatusNoPowerEffect noPower;  // 0x810
        public Beyond.Gameplay.Factory.StatusNotInPowerNetEffect notInPowerNet;  // 0xa10
        public Beyond.Gameplay.Factory.StatusFixableEffect fixable;  // 0xc10
        public Beyond.Gameplay.Factory.StatusBrokenEffect broken;  // 0xe10
        public Beyond.Gameplay.Factory.StatusOverloadEffect overload;  // 0x1010
        public Beyond.Gameplay.Factory.StatusBusDisconnectEffect busDisconnect;  // 0x1210
        public Unity.Mathematics.int3 effectInstanceIdList;  // 0x1410
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D564F0 */ }

        // Methods
        // RVA: 0x02EC6620  token: 0x6000703
        public System.Void SetEffects(Beyond.Gameplay.Factory.BuildingStatus buildingStatus, Beyond.Gameplay.Factory.FacEffectCfgList cfgList) { }
        // RVA: 0x029BF710  token: 0x6000704
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> GetEffect(Beyond.GEnums.FacBuildingState status) { }
        // RVA: 0x057A90F0  token: 0x6000706
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000129  // size: 0x210
    public sealed struct StatusNormalEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x200012A  // size: 0x210
    public sealed struct StatusClosedEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x200012B  // size: 0x210
    public sealed struct StatusIdleEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x200012C  // size: 0x210
    public sealed struct StatusBlockedEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x200012D  // size: 0x210
    public sealed struct StatusNoPowerEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x200012E  // size: 0x210
    public sealed struct StatusNotInPowerNetEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x200012F  // size: 0x210
    public sealed struct StatusFixableEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x2000130  // size: 0x210
    public sealed struct StatusBrokenEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x2000131  // size: 0x210
    public sealed struct StatusOverloadEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x2000132  // size: 0x210
    public sealed struct StatusBusDisconnectEffect
    {
        // Fields
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> effectSetting;  // 0x10

    }

    // TypeToken: 0x2000133  // size: 0x64
    public sealed struct StatusSingleEffect
    {
        // Fields
        public Beyond.Gameplay.Factory.BuildingSubState subState;  // 0x10
        public Unity.Collections.FixedString64Bytes name;  // 0x12
        public Unity.Mathematics.float3 offset;  // 0x54
        public System.Boolean needAlignToBuilding;  // 0x60

        // Properties
        System.String effectName { get; /* RVA: 0x029BF4A0 */ set; /* RVA: 0x057A842C */ }

    }

    // TypeToken: 0x2000134  // size: 0x18
    public class FacEffectCfgList
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Gameplay.Factory.StatusSingleEffect> list;  // 0x10

        // Properties
        System.Int32 cfgCount { get; /* RVA: 0x057A2D8C */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600070A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000135  // size: 0x14
    public sealed struct BuildingStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.BuildingStatus INVALID;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus CLOSED;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus UNKNOWN;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus IDLE;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus NORMAL;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus BLOCKED;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus NO_POWER;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus NOT_IN_POWER_NET;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus FIXABLE;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus BROKEN;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus OVERLOAD;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus BUS_DISCONNECT;  // const
        public static Beyond.Gameplay.Factory.BuildingStatus MAX;  // const

    }

    // TypeToken: 0x2000136  // size: 0x11
    public sealed struct BuildingSubState
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.BuildingSubState ANY;  // const
        public static Beyond.Gameplay.Factory.BuildingSubState NONE;  // const
        public static Beyond.Gameplay.Factory.BuildingSubState SUB_STATE_1;  // const
        public static Beyond.Gameplay.Factory.BuildingSubState SUB_STATE_2;  // const
        public static Beyond.Gameplay.Factory.BuildingSubState SUB_STATE_3;  // const
        public static Beyond.Gameplay.Factory.BuildingSubState SUB_STATE_4;  // const

    }

    // TypeToken: 0x2000137  // size: 0x14
    public sealed struct UnitStatusUIRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        private System.Int32 <unitConfigAssetInstanceId>k__BackingField;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitConfigAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D56510 */ }

        // Methods
        // RVA: 0x057A9350  token: 0x6000710
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000138  // size: 0x40
    public sealed struct UnitTransFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IRotateFragment, Beyond.Gameplay.Factory.IPositionFragment
    {
        // Fields
        public Unity.Mathematics.float3 __position;  // 0x10
        public Unity.Mathematics.float3 __rotation;  // 0x1c
        public Unity.Mathematics.float3 cornerLD;  // 0x28
        public Unity.Mathematics.float3 cornerRU;  // 0x34
        public static System.Int32 ID;  // const

        // Properties
        Unity.Mathematics.quaternion RotationQuaternion { get; /* RVA: 0x02503F00 */ }
        Unity.Mathematics.float3 Position { get; /* RVA: 0x03D56520 */ set; /* RVA: 0x03D56570 */ }
        Unity.Mathematics.float3 Rotation { get; /* RVA: 0x03D56540 */ set; /* RVA: 0x03D56580 */ }
        System.Int32 id { get; /* RVA: 0x03D56560 */ }

        // Methods
        // RVA: 0x057A945C  token: 0x6000716
        public System.Boolean InBound(Unity.Mathematics.float3 pos, System.Boolean ignoreY) { }
        // RVA: 0x057A95F0  token: 0x6000718
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000139  // size: 0x30
    public sealed struct ValveFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.UInt32 selectedItemId;  // 0x14
        public System.Int32 passed;  // 0x18
        public System.Int32 currentPassed;  // 0x1c
        public Beyond.Gameplay.Factory.FactoryItem holdItem;  // 0x20
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56590 */ }

        // Methods
        // RVA: 0x057A9F44  token: 0x600071A
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200013A  // size: 0x11
    public sealed struct BoxValve : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56200 */ }

        // Methods
        // RVA: 0x057A262C  token: 0x600071C
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200013B  // size: 0x11
    public sealed struct FluidValve : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public System.Byte placeHolder;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 id { get; /* RVA: 0x03D56270 */ }

        // Methods
        // RVA: 0x057A30FC  token: 0x600071E
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x200013C  // size: 0x3810
    public sealed struct BlueprintSlotInfo
    {
        // Fields
        public static System.Int32 RELATED_SLOT_ID;  // const
        public static System.Int32 SLOT_MAX_COUNT;  // const
        public static System.Int32 UNIT_MAX_COUNT_PER_SLOT;  // const
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo0>e__FixedBuffer m_blueprintSlotInfo0;  // 0x10
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo1>e__FixedBuffer m_blueprintSlotInfo1;  // 0x810
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo2>e__FixedBuffer m_blueprintSlotInfo2;  // 0x1010
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo3>e__FixedBuffer m_blueprintSlotInfo3;  // 0x1810
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo4>e__FixedBuffer m_blueprintSlotInfo4;  // 0x2010
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo5>e__FixedBuffer m_blueprintSlotInfo5;  // 0x2810
        private Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintRelatedSlotInfo>e__FixedBuffer m_blueprintRelatedSlotInfo;  // 0x3010

        // Methods
        // RVA: 0x057A1ADC  token: 0x600071F
        public System.Boolean ContainsNodeId(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 slotId, System.Int32 nodeId) { }
        // RVA: 0x057A1F5C  token: 0x6000720
        public System.Void RemoveEntityFromSlot(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 slotId, UnityEngine.HyperGryph.ECS.Entity overdueEntity) { }
        // RVA: 0x057A1C0C  token: 0x6000721
        public System.Int32 FindEmptySlotIdx() { }
        // RVA: 0x057A1ED4  token: 0x6000722
        public System.Int32 GetSuitableSlotIdx(System.Int32 slotId) { }
        // RVA: 0x057A2060  token: 0x6000723
        public System.Void SetSlotId(System.Int32 index, System.Int32 slotId) { }
        // RVA: 0x02D077E0  token: 0x6000724
        public System.UInt64[] GetSlotIds() { }
        // RVA: 0x057A196C  token: 0x6000725
        public System.Void AppendSlotInfo(System.Int32 slotId, UnityEngine.HyperGryph.ECS.Entity logicEntity) { }
        // RVA: 0x057A1A4C  token: 0x6000726
        public UnityEngine.HyperGryph.ECS.Entity[] ClearSlotInfo(System.Int32 slotId) { }
        // RVA: 0x057A24FC  token: 0x6000727
        private UnityEngine.HyperGryph.ECS.Entity[] _ClearSlotInfo(System.UInt64* slotGroupPtr) { }
        // RVA: 0x02AD3B40  token: 0x6000728
        public System.Void DiffSlotInfo(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 slotId, Beyond.PoolCore.PooledList<System.UInt32>& baseList, Beyond.PoolCore.PooledList<System.UInt32>& newList, Beyond.PoolCore.PooledList<UnityEngine.HyperGryph.ECS.Entity>& overdueList) { }
        // RVA: 0x057A1C80  token: 0x6000729
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> GetAllPendingEntitiesInSlot(System.Int32 slotId) { }
        // RVA: 0x057A1E10  token: 0x600072A
        public UnityEngine.HyperGryph.ECS.Entity GetSlotInfo(System.Int32 slotId, System.Int32 index) { }
        // RVA: 0x057A1D90  token: 0x600072B
        public System.UInt64 GetPendingEntityCountInSlot(System.Int32 slotId) { }
        // RVA: 0x02AD3D20  token: 0x600072C
        public System.UInt64* GetSlotGroupWithSlotId(System.Int32 slotId, System.Int32& slotIdx, System.Boolean includeInvalid) { }
        // RVA: 0x03D561F0  token: 0x600072D
        public System.UInt64* GetRelatedSlotGroup() { }
        // RVA: 0x02D07880  token: 0x600072E
        public System.UInt64* GetSlotGroup(System.Int32 index) { }
        // RVA: 0x02D06FF0  token: 0x600072F
        public static Beyond.Gameplay.Factory.BlueprintSlotInfo CreateDefault() { }
        // RVA: 0x057A20DC  token: 0x6000730
        public virtual System.String ToString() { }
        // RVA: 0x057A247C  token: 0x6000731
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000144
    public sealed struct CargoRendererInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.CargoRendererInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000732
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x6000737
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000738
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000739
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x600073A
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600073B
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x600073C
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x600073D
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x600073E
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x600073F
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000740
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000741
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000742
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000743
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000744
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000746
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000747
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000748
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000749
        public Beyond.Gameplay.Factory.CargoRendererInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600074A
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600074B
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600074D
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600074E
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600074F
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000147  // size: 0x58
    public sealed struct CargoRendererInfo
    {
        // Fields
        public Unity.Mathematics.float4 positionAndScale;  // 0x10
        public Unity.Mathematics.float3 position;  // 0x10
        public System.Single scale;  // 0x1c
        public Unity.Mathematics.quaternion rotation;  // 0x20
        public UnityEngine.HyperGryph.HGFactoryEntityTransformData transform;  // 0x10
        public Unity.Mathematics.float4 itemUV;  // 0x30
        public Unity.Mathematics.float4 itemLiquidUV;  // 0x40
        public System.Single isLiquidItem;  // 0x50
        public System.Byte preFrameVisible;  // 0x54

    }

    // TypeToken: 0x2000148
    public sealed struct ConveyorRendererInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000756
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x600075B
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x600075C
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x600075D
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x600075E
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x600075F
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000760
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000761
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000762
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000763
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000764
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000765
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000766
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000767
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000768
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x600076A
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600076B
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x600076C
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600076D
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600076E
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x600076F
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000771
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000772
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000773
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x200014B  // size: 0x50
    public sealed struct ConveyorRendererInfo
    {
        // Fields
        public System.Int32 index;  // 0x10
        public System.Int32 totalLength;  // 0x14
        public System.Single speed;  // 0x18
        public System.Single adjustMapHeight;  // 0x1c
        public System.Boolean isPreview;  // 0x20
        public System.Boolean isCorner;  // 0x21
        public System.Boolean valid;  // 0x22
        public System.Boolean highLight;  // 0x23
        public System.UInt32 sharedDataHandle;  // 0x24
        public Unity.Mathematics.float3 position;  // 0x28
        public Unity.Mathematics.float3 rotation;  // 0x34
        public System.UInt32 lightMode;  // 0x40
        public Beyond.Gameplay.Factory.BlueprintState.EffectType blueprintType;  // 0x44

        // Methods
        // RVA: 0x057A2994  token: 0x600077A
        public virtual System.String ToString() { }
        // RVA: 0x057A2D24  token: 0x600077B
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200014C  // size: 0x20
    public sealed struct FactoryItem
    {
        // Fields
        public System.UInt32 itemId;  // 0x10
        public System.Int32 itemAmount;  // 0x14
        public System.Int64 tms;  // 0x18

    }

    // TypeToken: 0x200014D
    public sealed struct PipeRendererInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600077C
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x6000781
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000782
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000783
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000784
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000785
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000786
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000787
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000788
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000789
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x600078A
        public T First() { }
        // RVA: -1  // not resolved  token: 0x600078B
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x600078C
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x600078D
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600078E
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000790
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000791
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000792
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000793
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000794
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000795
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000797
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000798
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000799
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000150
    public sealed struct PipeTrackRendererInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60007A0
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x60007A5
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60007A6
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60007A7
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60007A8
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60007A9
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60007AA
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60007AB
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60007AC
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60007AD
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60007AE
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60007AF
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60007B0
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60007B1
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60007B2
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60007B4
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60007B5
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60007B6
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60007B7
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60007B8
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60007B9
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60007BB
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60007BC
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60007BD
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000153  // size: 0x70
    public sealed struct PipeRendererInfo
    {
        // Fields
        public System.Int32 index;  // 0x10
        public System.Int32 totalLength;  // 0x14
        public System.Single waterDirection;  // 0x18
        public System.Single pipeHeight;  // 0x1c
        public System.Single waterThickness;  // 0x20
        public System.Single waterFlowDeltaTime;  // 0x24
        public System.Boolean isPreview;  // 0x28
        public System.Boolean valid;  // 0x29
        public System.Boolean highLight;  // 0x2a
        public System.Byte proto;  // 0x2b
        public System.Int32 subItemType;  // 0x2c
        public System.UInt32 sharedDataHandle;  // 0x30
        public System.Single bend;  // 0x34
        public System.UInt32 lightMode;  // 0x38
        public Unity.Mathematics.float3 position;  // 0x40
        public Unity.Mathematics.float3 rotation;  // 0x4c
        public Beyond.Gameplay.Factory.BlueprintState.EffectType blueprintType;  // 0x58

    }

    // TypeToken: 0x2000154  // size: 0x50
    public sealed struct PipeTrackRendererInfo
    {
        // Fields
        public System.Int32 index;  // 0x10
        public System.Int32 totalLength;  // 0x14
        public System.Single pipeHeight;  // 0x18
        public System.Single gridPathHeight;  // 0x1c
        public System.Single gridPathHeightEnd;  // 0x20
        public Unity.Mathematics.float3 position;  // 0x24
        public Unity.Mathematics.float3 rotation;  // 0x30
        public System.Boolean valid;  // 0x3c

    }

    // TypeToken: 0x2000155
    public sealed struct PortArrowRendererInfoCollection`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60007C4
        public T* GetDataPtr() { }
        // RVA: -1  // not resolved  token: 0x60007C9
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x60007CA
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x60007CB
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x60007CC
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x60007CD
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x60007CE
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x60007CF
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x60007D0
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x60007D1
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x60007D2
        public T First() { }
        // RVA: -1  // not resolved  token: 0x60007D3
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x60007D4
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x60007D5
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60007D6
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x60007D8
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x60007D9
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x60007DA
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x60007DB
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60007DC
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60007DD
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60007DF
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60007E0
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60007E1
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000158  // size: 0x50
    public sealed struct PortArrowRendererInfo
    {
        // Fields
        public Unity.Mathematics.float3 pos;  // 0x10
        public System.Boolean isForbidden;  // 0x1c
        public Unity.Mathematics.quaternion rot;  // 0x20
        public Unity.Mathematics.float4 renderColor;  // 0x30
        public Unity.Mathematics.float4 atlasUV;  // 0x40

    }

    // TypeToken: 0x2000159  // size: 0x18
    public sealed struct UnitId : System.IEquatable`1
    {
        // Fields
        public System.Int32 mapId;  // 0x10
        public System.UInt32 factoryUnitId;  // 0x14

        // Methods
        // RVA: 0x024FD350  token: 0x60007E8
        public virtual System.Boolean Equals(Beyond.Gameplay.Factory.UnitId other) { }
        // RVA: 0x057A896C  token: 0x60007E9
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x024FD0F0  token: 0x60007EA
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x024FD060  token: 0x60007EB
        public static Beyond.Gameplay.Factory.UnitId Create(System.Int32 mapId, System.UInt32 factoryUnitId) { }
        // RVA: 0x057A8A08  token: 0x60007EC
        public System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        // RVA: 0x057A8A68  token: 0x60007ED
        public System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200015A  // size: 0x28
    public sealed struct Visibility
    {
        // Fields
        public static Beyond.Gameplay.Factory.Visibility s_defaultVal;  // static @ 0x0
        public System.UInt32 visibleFlags;  // 0x10
        public System.Int16 invisibleSubCount;  // 0x14
        public Beyond.Gameplay.Factory.Visibility.<invisibleSubBits>e__FixedBuffer invisibleSubBits;  // 0x16
        public static System.Int32 SUB_INDEX_MAX_COUNT;  // const
        public static System.Int32 SUB_BIT_BYTE_COUNT;  // const

        // Properties
        System.Boolean isVisible { get; /* RVA: 0x024FBD00 */ }

        // Methods
        // RVA: 0x02F41F60  token: 0x60007EF
        public System.Boolean SetVisible(Beyond.Gameplay.Factory.Visibility.EFlag flag, System.Boolean visible) { }
        // RVA: 0x024FB150  token: 0x60007F0
        public System.Boolean SetVisible(Beyond.Gameplay.Factory.Visibility.EFlag flag, System.Boolean visible, System.Int16* invisibleIndexListPtr, System.Int16 invisibleIndexCount) { }
        // RVA: 0x024FBE80  token: 0x60007F1
        public System.Boolean GetVisible(Beyond.Gameplay.Factory.Visibility.EFlag flag) { }
        // RVA: 0x057AA060  token: 0x60007F2
        public System.Boolean IsSubRendererInvisible(System.Int32 subIndex) { }
        // RVA: 0x057AA0F0  token: 0x60007F3
        private static System.Void _SetSubInvisible(System.Byte* head, System.Int32 index, System.Boolean invisible) { }
        // RVA: 0x057AA0D0  token: 0x60007F4
        private static System.Boolean _GetSubInvisible(System.Byte* head, System.Int32 index) { }
        // RVA: 0x03D0C950  token: 0x60007F5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200015E  // size: 0x14
    public sealed struct WireRendererFragment : UnityEngine.HyperGryph.ECS.IComponentECS, Beyond.Gameplay.Factory.IUnitConfigRef
    {
        // Fields
        public System.Int32 unitConfigAssetInstanceId;  // 0x10
        public static System.Int32 ID;  // const

        // Properties
        System.Int32 unitAssetInstanceId { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 id { get; /* RVA: 0x03D565A0 */ }

        // Methods
        // RVA: 0x057AA11C  token: 0x60007F9
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000160  // size: 0x11
    public sealed struct GlobalSharedData
    {
        // Fields
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.CullingGlobalSetting> CULLING_SETTING;  // static @ 0x0
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting> NEAR_BY_DISTANCE_SETTING;  // static @ 0x8
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.World3DUiGlobalSetting> WORLD_3D_UI_SETTING;  // static @ 0x10
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.CurveGlobalSetting> CURVE_SETTING;  // static @ 0x18
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData> GRID_RENDERER_DATA;  // static @ 0x20
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB> UNIT_PORT_DB;  // static @ 0x28
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting> PERDRAW_SETTING;  // static @ 0x30
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalGlobalSetting> SYSTEM_INTERVAL_SETTING;  // static @ 0x38
        public static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.UIEffectPathConfig> STATE_UI_PATH;  // static @ 0x40

        // Methods
        // RVA: 0x057A3980  token: 0x60007FA
        public System.Void Reset() { }
        // RVA: 0x039C9260  token: 0x60007FB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000178  // size: 0x20
    public abstract class BaseProcessor : Beyond.Gameplay.Factory.IProcessor
    {
        // Fields
        protected Beyond.Gameplay.FactorySetting m_factorySetting;  // 0x10
        private System.Single <interval>k__BackingField;  // 0x18
        private System.Single <curInterval>k__BackingField;  // 0x1c

        // Properties
        System.Single interval { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x03D4EC00 */ }
        System.Single curInterval { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x03D4F120 */ }
        System.String name { get; /* RVA: -1  // abstract */ }
        System.Boolean lowFrameEnable { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x0327B300  token: 0x6000856
        public virtual System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting) { }
        // RVA: 0x0230FF50  token: 0x6000857
        public virtual Unity.Jobs.JobHandle PreExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 deltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: 0x0230BA00  token: 0x6000858
        public virtual Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 deltaTime, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: 0x024FC4C0  token: 0x6000859
        public virtual Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0230BAB0  token: 0x600085A
        public virtual System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook) { }
        // RVA: 0x057A1910  token: 0x600085B
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x02311370  token: 0x6000862
        protected System.Void StructuralSync(Unity.Jobs.JobHandle& jh, Unity.Collections.NativeList<Unity.Jobs.JobHandle>& noneDependencies) { }
        // RVA: 0x023111D0  token: 0x6000863
        protected System.Void ScheduleNoneDependencies(Unity.Collections.NativeList<Unity.Jobs.JobHandle>& noneDependencies) { }
        // RVA: 0x024FB9D0  token: 0x6000864
        public virtual System.Boolean InLowFrameMode(Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x02BBB120  token: 0x6000865
        protected System.Boolean SpecialEntityExisted(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x03D561E0  token: 0x6000866
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000179
    public interface IProcessor
    {
        // Properties
        System.Single interval { get; /* RVA: -1  // abstract */ }
        System.Single curInterval { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.String name { get; /* RVA: -1  // abstract */ }
        System.Boolean lowFrameEnable { get; /* RVA: 0x0232EB60 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000867
        public virtual System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting) { }
        // RVA: -1  // abstract  token: 0x6000868
        public virtual Unity.Jobs.JobHandle PreExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: -1  // abstract  token: 0x6000869
        public virtual Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: -1  // abstract  token: 0x600086A
        public virtual Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: -1  // abstract  token: 0x600086B
        public virtual System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook) { }
        // RVA: -1  // abstract  token: 0x600086C
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: -1  // abstract  token: 0x6000872
        public virtual System.Boolean InLowFrameMode(Beyond.Gameplay.Factory.GlobalEnv& env) { }

    }

    // TypeToken: 0x200017A  // size: 0x10
    public class StructuralChangedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000873
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000181  // size: 0x80
    public sealed class ApplyPerDrawRender_0000085C$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x054E1E0C  token: 0x6000899
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x600089A
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length) { }
        // RVA: 0x057A1800  token: 0x600089B
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x600089C
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000182  // size: 0x10
    public static class ApplyPerDrawRender_0000085C$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057A160C  token: 0x600089D
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057A1710  token: 0x600089E
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CECB00  token: 0x600089F
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008A0
        public static System.Void Initialize() { }
        // RVA: 0x03CECAF0  token: 0x60008A1
        private static System.Void .cctor() { }
        // RVA: 0x057A1764  token: 0x60008A2
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length) { }

    }

    // TypeToken: 0x2000183  // size: 0x80
    public sealed class GetQueryStateIconPath_0000085E$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057A38B8  token: 0x60008A3
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x0101C850  token: 0x60008A4
        public virtual System.Boolean Invoke(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color) { }
        // RVA: 0x057A37DC  token: 0x60008A5
        public virtual System.IAsyncResult BeginInvoke(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD8EC  token: 0x60008A6
        public virtual System.Boolean EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000184  // size: 0x10
    public static class GetQueryStateIconPath_0000085E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057A35D8  token: 0x60008A7
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057A36DC  token: 0x60008A8
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CEB520  token: 0x60008A9
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008AA
        public static System.Void Initialize() { }
        // RVA: 0x03CEB510  token: 0x60008AB
        private static System.Void .cctor() { }
        // RVA: 0x057A3730  token: 0x60008AC
        public static System.Boolean Invoke(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color) { }

    }

    // TypeToken: 0x2000185  // size: 0x80
    public sealed class GetLogicEntityWithPos_00000860$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057A3504  token: 0x60008AD
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x057A2E88  token: 0x60008AE
        public virtual System.Boolean Invoke(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment) { }
        // RVA: 0x057A3448  token: 0x60008AF
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD8EC  token: 0x60008B0
        public virtual System.Boolean EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000186  // size: 0x10
    public static class GetLogicEntityWithPos_00000860$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057A3208  token: 0x60008B1
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057A330C  token: 0x60008B2
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CEB5C0  token: 0x60008B3
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008B4
        public static System.Void Initialize() { }
        // RVA: 0x03CEB5B0  token: 0x60008B5
        private static System.Void .cctor() { }
        // RVA: 0x057A3360  token: 0x60008B6
        public static System.Boolean Invoke(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment) { }

    }

    // TypeToken: 0x2000187  // size: 0x80
    public sealed class QueryBuildingStateFunc_00000862$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057A76C4  token: 0x60008B7
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01035ED0  token: 0x60008B8
        public virtual Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x057A7600  token: 0x60008B9
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState, System.AsyncCallback , System.Object ) { }
        // RVA: 0x04279B70  token: 0x60008BA
        public virtual Beyond.GEnums.FacBuildingState EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000188  // size: 0x10
    public static class QueryBuildingStateFunc_00000862$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057A7408  token: 0x60008BB
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057A750C  token: 0x60008BC
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CEA9E0  token: 0x60008BD
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008BE
        public static System.Void Initialize() { }
        // RVA: 0x03CEA9D0  token: 0x60008BF
        private static System.Void .cctor() { }
        // RVA: 0x057A7560  token: 0x60008C0
        public static Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState) { }

    }

    // TypeToken: 0x2000189  // size: 0x80
    public sealed class SetEntityFlashStatueFunc_00000864$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057A7E54  token: 0x60008C1
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60008C2
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue) { }
        // RVA: 0x057A7D98  token: 0x60008C3
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60008C4
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200018A  // size: 0x10
    public static class SetEntityFlashStatueFunc_00000864$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057A7BA0  token: 0x60008C5
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057A7CA4  token: 0x60008C6
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CEA940  token: 0x60008C7
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008C8
        public static System.Void Initialize() { }
        // RVA: 0x03CEA930  token: 0x60008C9
        private static System.Void .cctor() { }
        // RVA: 0x057A7CF8  token: 0x60008CA
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue) { }

    }

    // TypeToken: 0x200017B  // size: 0x10
    public class UnsafeJobFuncPointers
    {
        // Methods
        // RVA: 0x0327EC70  token: 0x6000874
        public static Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.ApplyRender> GetApplyRenderPointer() { }
        // RVA: 0x03280EE0  token: 0x6000875
        public static Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> GetFacRegionValid() { }
        // RVA: 0x057A9768  token: 0x6000876
        public static System.Void ApplyPerDrawRender(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length) { }
        // RVA: 0x03280E10  token: 0x6000877
        public static Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath> GetQueryStateIconPathFuncPtr() { }
        // RVA: 0x057A9DE8  token: 0x6000878
        public static System.Boolean GetQueryStateIconPath(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color) { }
        // RVA: 0x057A97C8  token: 0x6000879
        public static System.Boolean GetLogicEntityWithPosAdapter(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.UnitFragment& unitFragment) { }
        // RVA: 0x057A9C88  token: 0x600087A
        public static System.Boolean GetLogicEntityWithPos(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment) { }
        // RVA: 0x038DDBE0  token: 0x600087B
        public static Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryBuildingState> GetQueryBuildingStatePointer() { }
        // RVA: 0x057A9E70  token: 0x600087C
        public static Beyond.GEnums.FacBuildingState QueryBuildingStateFunc(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x038DDB10  token: 0x600087D
        public static Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.SetEntityFlashStatue> GetSetEntityFlashStatuePointer() { }
        // RVA: 0x057A9EE4  token: 0x600087E
        public static System.Void SetEntityFlashStatueFunc(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue) { }
        // RVA: 0x0350B670  token: 0x600087F
        public System.Void .ctor() { }
        // RVA: 0x057A9714  token: 0x6000880
        public static System.Void ApplyPerDrawRender$BurstManaged(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length) { }
        // RVA: 0x057A9D1C  token: 0x6000881
        public static System.Boolean GetQueryStateIconPath$BurstManaged(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color) { }
        // RVA: 0x057A99B0  token: 0x6000882
        public static System.Boolean GetLogicEntityWithPos$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment) { }
        // RVA: 0x057A9E5C  token: 0x6000883
        public static Beyond.GEnums.FacBuildingState QueryBuildingStateFunc$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x057A9ED0  token: 0x6000884
        public static System.Void SetEntityFlashStatueFunc$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue) { }

    }

    // TypeToken: 0x200018C  // size: 0x80
    public sealed class _BuildDismissState_00000882$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057AA5F0  token: 0x60008DD
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x02121030  token: 0x60008DE
        public virtual System.Boolean Invoke(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x057AA4A8  token: 0x60008DF
        public virtual System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD8EC  token: 0x60008E0
        public virtual System.Boolean EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200018D  // size: 0x10
    public static class _BuildDismissState_00000882$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057AA278  token: 0x60008E1
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057AA37C  token: 0x60008E2
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8500  token: 0x60008E3
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008E4
        public static System.Void Initialize() { }
        // RVA: 0x03CE84F0  token: 0x60008E5
        private static System.Void .cctor() { }
        // RVA: 0x057AA3D0  token: 0x60008E6
        public static System.Boolean Invoke(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }

    }

    // TypeToken: 0x200018E  // size: 0x80
    public sealed class _Repair0_00000884$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057AA970  token: 0x60008E7
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01035ED0  token: 0x60008E8
        public virtual System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x057AA8B4  token: 0x60008E9
        public virtual System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD8EC  token: 0x60008EA
        public virtual System.Boolean EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200018F  // size: 0x10
    public static class _Repair0_00000884$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057AA6C4  token: 0x60008EB
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057AA7C8  token: 0x60008EC
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7240  token: 0x60008ED
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008EE
        public static System.Void Initialize() { }
        // RVA: 0x03CE7230  token: 0x60008EF
        private static System.Void .cctor() { }
        // RVA: 0x057AA81C  token: 0x60008F0
        public static System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }

    }

    // TypeToken: 0x2000190  // size: 0x80
    public sealed class _Repair1_00000885$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057AA970  token: 0x60008F1
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01035ED0  token: 0x60008F2
        public virtual System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x057AAC34  token: 0x60008F3
        public virtual System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD8EC  token: 0x60008F4
        public virtual System.Boolean EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000191  // size: 0x10
    public static class _Repair1_00000885$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057AAA44  token: 0x60008F5
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057AAB48  token: 0x60008F6
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE6FC0  token: 0x60008F7
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60008F8
        public static System.Void Initialize() { }
        // RVA: 0x03CE6FB0  token: 0x60008F9
        private static System.Void .cctor() { }
        // RVA: 0x057AAB9C  token: 0x60008FA
        public static System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }

    }

    // TypeToken: 0x200018B  // size: 0xD0
    public sealed struct AdditiveEffectJob : Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* qr;  // 0x10
        public System.Int64 time;  // 0x18
        public Beyond.Gameplay.Factory.FPtrNativeCurve buildCurve;  // 0x20
        public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve0;  // 0x38
        public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve1;  // 0x50
        public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve0;  // 0x68
        public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve1;  // 0x80
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x98
        public System.Int32 threadId;  // 0xa8
        public System.Int32 frameCount;  // 0xac
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedExtDataPtr;  // 0xb0
        public Unity.Collections.NativeQueue.ParallelWriter<Beyond.Gameplay.Factory.FactoryBuildingEffectData> finishedEffectQueue;  // 0xb8

        // Methods
        // RVA: 0x0322B560  token: 0x60008CB
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x0579C8B4  token: 0x60008CC
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x0579C590  token: 0x60008CD
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x0579CB58  token: 0x60008CE
        private System.Void _OnStackEmpty(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData) { }
        // RVA: 0x0579BE44  token: 0x60008CF
        private System.Void _CancelPreState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType preState, Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData) { }
        // RVA: 0x0579BEC0  token: 0x60008D0
        private System.Void _ResumeState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state, Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData) { }
        // RVA: 0x0579CCAC  token: 0x60008D1
        private System.Void _SetStateValid(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state, Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, System.Boolean valid) { }
        // RVA: 0x0579CF2C  token: 0x60008D2
        private System.Void _UpdateInternalStateLifeCycle(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData) { }
        // RVA: 0x0579CA4C  token: 0x60008D3
        private static System.Boolean _BuildDismissState(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579CAE4  token: 0x60008D4
        private static System.Void _InitBuildState(Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.BuildDismissState& buildDismissState) { }
        // RVA: 0x0579CBEC  token: 0x60008D5
        private static System.Boolean _Repair0(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x0579CC4C  token: 0x60008D6
        private static System.Boolean _Repair1(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x0322B5F0  token: 0x60008D7
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x030EA470  token: 0x60008D8
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }
        // RVA: 0x0579C934  token: 0x60008D9
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandleDep0, Unity.Jobs.JobHandle jobHandleDep1, System.Int32 innerLoopBatchCount) { }
        // RVA: 0x0579BD34  token: 0x60008DA
        public static System.Boolean _BuildDismissState$BurstManaged(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579BE58  token: 0x60008DB
        public static System.Boolean _Repair0$BurstManaged(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x0579BE8C  token: 0x60008DC
        public static System.Boolean _Repair1$BurstManaged(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }

    }

    // TypeToken: 0x2000192  // size: 0x40
    public sealed struct AdditiveEffectQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_additiveEffectQr;  // 0x28
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_hintEffectQr;  // 0x30
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_additiveEffectRendererQr;  // 0x38

        // Methods
        // RVA: 0x0579D0A0  token: 0x60008FB
        public virtual System.Void Execute() { }
        // RVA: 0x026DF900  token: 0x60008FC
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& additiveEffectQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& hintQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& additiveEffectRendererQr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x2000194  // size: 0x80
    public sealed class _BPBuildStart_0000088E$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B88B4  token: 0x600095E
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x0551C468  token: 0x600095F
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x057B8F10  token: 0x6000960
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000961
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000195  // size: 0x10
    public static class _BPBuildStart_0000088E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B8CF0  token: 0x6000962
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B8DF4  token: 0x6000963
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8780  token: 0x6000964
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000965
        public static System.Void Initialize() { }
        // RVA: 0x03CE8770  token: 0x6000966
        private static System.Void .cctor() { }
        // RVA: 0x057B8E48  token: 0x6000967
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }

    }

    // TypeToken: 0x2000196  // size: 0x80
    public sealed class _BPBuildProcess_0000088F$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B88B4  token: 0x6000968
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x0551C468  token: 0x6000969
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x057B8BA8  token: 0x600096A
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x600096B
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000197  // size: 0x10
    public static class _BPBuildProcess_0000088F$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B8988  token: 0x600096C
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B8A8C  token: 0x600096D
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8820  token: 0x600096E
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x600096F
        public static System.Void Initialize() { }
        // RVA: 0x03CE8810  token: 0x6000970
        private static System.Void .cctor() { }
        // RVA: 0x057B8AE0  token: 0x6000971
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }

    }

    // TypeToken: 0x2000198  // size: 0x80
    public sealed class _BPBuildEnd_00000890$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B88B4  token: 0x6000972
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x0551C468  token: 0x6000973
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x057B876C  token: 0x6000974
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000975
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000199  // size: 0x10
    public static class _BPBuildEnd_00000890$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B8548  token: 0x6000976
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B864C  token: 0x6000977
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE88C0  token: 0x6000978
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000979
        public static System.Void Initialize() { }
        // RVA: 0x03CE88B0  token: 0x600097A
        private static System.Void .cctor() { }
        // RVA: 0x057B86A0  token: 0x600097B
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }

    }

    // TypeToken: 0x200019A  // size: 0x80
    public sealed class _BPBuildCutoffStateStart_00000891$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x600097C
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x600097D
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x057B8484  token: 0x600097E
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x600097F
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200019B  // size: 0x10
    public static class _BPBuildCutoffStateStart_00000891$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B8298  token: 0x6000980
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B839C  token: 0x6000981
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8960  token: 0x6000982
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000983
        public static System.Void Initialize() { }
        // RVA: 0x03CE8950  token: 0x6000984
        private static System.Void .cctor() { }
        // RVA: 0x057B83F0  token: 0x6000985
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }

    }

    // TypeToken: 0x200019C  // size: 0x80
    public sealed class _BPBuildCutoffStateEnd_00000892$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000986
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000987
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x057B7E4C  token: 0x6000988
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000989
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200019D  // size: 0x10
    public static class _BPBuildCutoffStateEnd_00000892$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B7C5C  token: 0x600098A
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B7D60  token: 0x600098B
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8AA0  token: 0x600098C
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x600098D
        public static System.Void Initialize() { }
        // RVA: 0x03CE8A90  token: 0x600098E
        private static System.Void .cctor() { }
        // RVA: 0x057B7DB4  token: 0x600098F
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }

    }

    // TypeToken: 0x200019E  // size: 0x80
    public sealed class _BPBuildCutoffStateProcess_00000893$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000990
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000991
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x057B81D4  token: 0x6000992
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000993
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200019F  // size: 0x10
    public static class _BPBuildCutoffStateProcess_00000893$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B7FE4  token: 0x6000994
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B80E8  token: 0x6000995
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8A00  token: 0x6000996
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000997
        public static System.Void Initialize() { }
        // RVA: 0x03CE89F0  token: 0x6000998
        private static System.Void .cctor() { }
        // RVA: 0x057B813C  token: 0x6000999
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }

    }

    // TypeToken: 0x20001A0  // size: 0x80
    public sealed class _CutoffStateStart_00000897$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x600099A
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x600099B
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x057BAC74  token: 0x600099C
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x600099D
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A1  // size: 0x10
    public static class _CutoffStateStart_00000897$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BAA84  token: 0x600099E
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BAB88  token: 0x600099F
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE80A0  token: 0x60009A0
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009A1
        public static System.Void Initialize() { }
        // RVA: 0x03CE8090  token: 0x60009A2
        private static System.Void .cctor() { }
        // RVA: 0x057BABDC  token: 0x60009A3
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }

    }

    // TypeToken: 0x20001A2  // size: 0x80
    public sealed class _CutoffStateEnd_00000898$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009A4
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009A5
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x057BA70C  token: 0x60009A6
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009A7
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A3  // size: 0x10
    public static class _CutoffStateEnd_00000898$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BA51C  token: 0x60009A8
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BA620  token: 0x60009A9
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE81E0  token: 0x60009AA
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009AB
        public static System.Void Initialize() { }
        // RVA: 0x03CE81D0  token: 0x60009AC
        private static System.Void .cctor() { }
        // RVA: 0x057BA674  token: 0x60009AD
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }

    }

    // TypeToken: 0x20001A4  // size: 0x80
    public sealed class _CutoffStateProcess_00000899$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009AE
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009AF
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x057BA9C0  token: 0x60009B0
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009B1
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A5  // size: 0x10
    public static class _CutoffStateProcess_00000899$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BA7D0  token: 0x60009B2
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BA8D4  token: 0x60009B3
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8140  token: 0x60009B4
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009B5
        public static System.Void Initialize() { }
        // RVA: 0x03CE8130  token: 0x60009B6
        private static System.Void .cctor() { }
        // RVA: 0x057BA928  token: 0x60009B7
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }

    }

    // TypeToken: 0x20001A6  // size: 0x80
    public sealed class _BuildStateProcess_0000089C$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B88B4  token: 0x60009B8
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x0551C468  token: 0x60009B9
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x057B9BD0  token: 0x60009BA
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009BB
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A7  // size: 0x10
    public static class _BuildStateProcess_0000089C$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B998C  token: 0x60009BC
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B9A90  token: 0x60009BD
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8460  token: 0x60009BE
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009BF
        public static System.Void Initialize() { }
        // RVA: 0x03CE8450  token: 0x60009C0
        private static System.Void .cctor() { }
        // RVA: 0x057B9AE4  token: 0x60009C1
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }

    }

    // TypeToken: 0x20001A8  // size: 0x80
    public sealed class _HighLightStart_0000089D$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009C2
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009C3
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BBCC0  token: 0x60009C4
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009C5
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001A9  // size: 0x10
    public static class _HighLightStart_0000089D$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BBAD0  token: 0x60009C6
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BBBD4  token: 0x60009C7
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7C40  token: 0x60009C8
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009C9
        public static System.Void Initialize() { }
        // RVA: 0x03CE7C30  token: 0x60009CA
        private static System.Void .cctor() { }
        // RVA: 0x057BBC28  token: 0x60009CB
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001AA  // size: 0x80
    public sealed class _HighLightEnd_0000089E$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009CC
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009CD
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BB754  token: 0x60009CE
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009CF
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001AB  // size: 0x10
    public static class _HighLightEnd_0000089E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BB560  token: 0x60009D0
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BB664  token: 0x60009D1
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7D80  token: 0x60009D2
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009D3
        public static System.Void Initialize() { }
        // RVA: 0x03CE7D70  token: 0x60009D4
        private static System.Void .cctor() { }
        // RVA: 0x057BB6B8  token: 0x60009D5
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001AC  // size: 0x80
    public sealed class _HighLightProcess_0000089F$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009D6
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009D7
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BBA0C  token: 0x60009D8
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009D9
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001AD  // size: 0x10
    public static class _HighLightProcess_0000089F$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BB818  token: 0x60009DA
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BB91C  token: 0x60009DB
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7CE0  token: 0x60009DC
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009DD
        public static System.Void Initialize() { }
        // RVA: 0x03CE7CD0  token: 0x60009DE
        private static System.Void .cctor() { }
        // RVA: 0x057BB970  token: 0x60009DF
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001AE  // size: 0x80
    public sealed class _FigureStart_000008A0$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009E0
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009E1
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BB49C  token: 0x60009E2
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009E3
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001AF  // size: 0x10
    public static class _FigureStart_000008A0$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BB2A8  token: 0x60009E4
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BB3AC  token: 0x60009E5
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7E20  token: 0x60009E6
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009E7
        public static System.Void Initialize() { }
        // RVA: 0x03CE7E10  token: 0x60009E8
        private static System.Void .cctor() { }
        // RVA: 0x057BB400  token: 0x60009E9
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001B0  // size: 0x80
    public sealed class _FigureProcess_000008A1$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009EA
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009EB
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BB1E4  token: 0x60009EC
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009ED
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001B1  // size: 0x10
    public static class _FigureProcess_000008A1$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BAFF0  token: 0x60009EE
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BB0F4  token: 0x60009EF
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7EC0  token: 0x60009F0
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009F1
        public static System.Void Initialize() { }
        // RVA: 0x03CE7EB0  token: 0x60009F2
        private static System.Void .cctor() { }
        // RVA: 0x057BB148  token: 0x60009F3
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001B2  // size: 0x80
    public sealed class _FigureEnd_000008A2$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x60009F4
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x60009F5
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BAF2C  token: 0x60009F6
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60009F7
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001B3  // size: 0x10
    public static class _FigureEnd_000008A2$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BAD38  token: 0x60009F8
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BAE3C  token: 0x60009F9
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7F60  token: 0x60009FA
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60009FB
        public static System.Void Initialize() { }
        // RVA: 0x03CE7F50  token: 0x60009FC
        private static System.Void .cctor() { }
        // RVA: 0x057BAE90  token: 0x60009FD
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001B4  // size: 0x80
    public sealed class _HintStart_000008A3$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057BC5DC  token: 0x60009FE
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x02097E50  token: 0x60009FF
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha) { }
        // RVA: 0x057BC4EC  token: 0x6000A00
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A01
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001B5  // size: 0x10
    public static class _HintStart_000008A3$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BC2E4  token: 0x6000A02
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BC3E8  token: 0x6000A03
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7A60  token: 0x6000A04
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A05
        public static System.Void Initialize() { }
        // RVA: 0x03CE7A50  token: 0x6000A06
        private static System.Void .cctor() { }
        // RVA: 0x057BC43C  token: 0x6000A07
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha) { }

    }

    // TypeToken: 0x20001B6  // size: 0x80
    public sealed class _HintEnd_000008A4$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A08
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A09
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BBF78  token: 0x6000A0A
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A0B
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001B7  // size: 0x10
    public static class _HintEnd_000008A4$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BBD84  token: 0x6000A0C
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BBE88  token: 0x6000A0D
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7BA0  token: 0x6000A0E
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A0F
        public static System.Void Initialize() { }
        // RVA: 0x03CE7B90  token: 0x6000A10
        private static System.Void .cctor() { }
        // RVA: 0x057BBEDC  token: 0x6000A11
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001B8  // size: 0x80
    public sealed class _HintProcess_000008A5$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A12
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A13
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BC220  token: 0x6000A14
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A15
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001B9  // size: 0x10
    public static class _HintProcess_000008A5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BC03C  token: 0x6000A16
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BC140  token: 0x6000A17
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7B00  token: 0x6000A18
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A19
        public static System.Void Initialize() { }
        // RVA: 0x03CE7AF0  token: 0x6000A1A
        private static System.Void .cctor() { }
        // RVA: 0x057BC194  token: 0x6000A1B
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001BA  // size: 0x80
    public sealed class _OverloadStart_000008A6$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A1C
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A1D
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BD61C  token: 0x6000A1E
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A1F
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001BB  // size: 0x10
    public static class _OverloadStart_000008A6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BD428  token: 0x6000A20
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BD52C  token: 0x6000A21
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE76A0  token: 0x6000A22
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A23
        public static System.Void Initialize() { }
        // RVA: 0x03CE7690  token: 0x6000A24
        private static System.Void .cctor() { }
        // RVA: 0x057BD580  token: 0x6000A25
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001BC  // size: 0x80
    public sealed class _OverloadEnd_000008A7$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A26
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A27
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BC8A4  token: 0x6000A28
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A29
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001BD  // size: 0x10
    public static class _OverloadEnd_000008A7$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BC6B0  token: 0x6000A2A
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BC7B4  token: 0x6000A2B
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE79C0  token: 0x6000A2C
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A2D
        public static System.Void Initialize() { }
        // RVA: 0x03CE79B0  token: 0x6000A2E
        private static System.Void .cctor() { }
        // RVA: 0x057BC808  token: 0x6000A2F
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001BE  // size: 0x80
    public sealed class _OverloadProcess_000008A8$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A30
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A31
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BD364  token: 0x6000A32
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A33
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001BF  // size: 0x10
    public static class _OverloadProcess_000008A8$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BD180  token: 0x6000A34
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BD284  token: 0x6000A35
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7740  token: 0x6000A36
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A37
        public static System.Void Initialize() { }
        // RVA: 0x03CE7730  token: 0x6000A38
        private static System.Void .cctor() { }
        // RVA: 0x057BD2D8  token: 0x6000A39
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001C0  // size: 0x80
    public sealed class _OverloadInvalidStart_000008A9$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A3A
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A3B
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BD0BC  token: 0x6000A3C
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A3D
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001C1  // size: 0x10
    public static class _OverloadInvalidStart_000008A9$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BCEC8  token: 0x6000A3E
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BCFCC  token: 0x6000A3F
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE77E0  token: 0x6000A40
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A41
        public static System.Void Initialize() { }
        // RVA: 0x03CE77D0  token: 0x6000A42
        private static System.Void .cctor() { }
        // RVA: 0x057BD020  token: 0x6000A43
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001C2  // size: 0x80
    public sealed class _OverloadInvalidEnd_000008AA$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A44
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A45
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BCB5C  token: 0x6000A46
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A47
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001C3  // size: 0x10
    public static class _OverloadInvalidEnd_000008AA$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BC968  token: 0x6000A48
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BCA6C  token: 0x6000A49
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7920  token: 0x6000A4A
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A4B
        public static System.Void Initialize() { }
        // RVA: 0x03CE7910  token: 0x6000A4C
        private static System.Void .cctor() { }
        // RVA: 0x057BCAC0  token: 0x6000A4D
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001C4  // size: 0x80
    public sealed class _OverloadInvalidProcess_000008AB$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A4E
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A4F
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BCE04  token: 0x6000A50
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A51
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001C5  // size: 0x10
    public static class _OverloadInvalidProcess_000008AB$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BCC20  token: 0x6000A52
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BCD24  token: 0x6000A53
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7880  token: 0x6000A54
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A55
        public static System.Void Initialize() { }
        // RVA: 0x03CE7870  token: 0x6000A56
        private static System.Void .cctor() { }
        // RVA: 0x057BCD78  token: 0x6000A57
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001C6  // size: 0x80
    public sealed class _Repair0Process_000008AE$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057BE784  token: 0x6000A58
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01028930  token: 0x6000A59
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x057BE670  token: 0x6000A5A
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A5B
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001C7  // size: 0x10
    public static class _Repair0Process_000008AE$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BE458  token: 0x6000A5C
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BE55C  token: 0x6000A5D
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE72E0  token: 0x6000A5E
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A5F
        public static System.Void Initialize() { }
        // RVA: 0x03CE72D0  token: 0x6000A60
        private static System.Void .cctor() { }
        // RVA: 0x057BE5B0  token: 0x6000A61
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }

    }

    // TypeToken: 0x20001C8  // size: 0x80
    public sealed class _Repair1Start_000008AF$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A62
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A63
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BF024  token: 0x6000A64
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A65
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001C9  // size: 0x10
    public static class _Repair1Start_000008AF$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BEE34  token: 0x6000A66
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BEF38  token: 0x6000A67
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7060  token: 0x6000A68
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A69
        public static System.Void Initialize() { }
        // RVA: 0x03CE7050  token: 0x6000A6A
        private static System.Void .cctor() { }
        // RVA: 0x057BEF8C  token: 0x6000A6B
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001CA  // size: 0x80
    public sealed class _Repair1End_000008B0$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A6C
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A6D
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BEA44  token: 0x6000A6E
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A6F
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001CB  // size: 0x10
    public static class _Repair1End_000008B0$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BE858  token: 0x6000A70
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BE95C  token: 0x6000A71
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE71A0  token: 0x6000A72
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A73
        public static System.Void Initialize() { }
        // RVA: 0x03CE7190  token: 0x6000A74
        private static System.Void .cctor() { }
        // RVA: 0x057BE9B0  token: 0x6000A75
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001CC  // size: 0x80
    public sealed class _Repair1Process_000008B1$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057BE784  token: 0x6000A76
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01028930  token: 0x6000A77
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x057BED20  token: 0x6000A78
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A79
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001CD  // size: 0x10
    public static class _Repair1Process_000008B1$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BEB08  token: 0x6000A7A
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BEC0C  token: 0x6000A7B
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7100  token: 0x6000A7C
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A7D
        public static System.Void Initialize() { }
        // RVA: 0x03CE70F0  token: 0x6000A7E
        private static System.Void .cctor() { }
        // RVA: 0x057BEC60  token: 0x6000A7F
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }

    }

    // TypeToken: 0x20001CE  // size: 0x80
    public sealed class _BlueprintProcessInternal_000008B3$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A80
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A81
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057B9610  token: 0x6000A82
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A83
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001CF  // size: 0x10
    public static class _BlueprintProcessInternal_000008B3$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B941C  token: 0x6000A84
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B9520  token: 0x6000A85
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8640  token: 0x6000A86
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A87
        public static System.Void Initialize() { }
        // RVA: 0x03CE8630  token: 0x6000A88
        private static System.Void .cctor() { }
        // RVA: 0x057B9574  token: 0x6000A89
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001D0  // size: 0x80
    public sealed class _BlueprintEnd_000008B4$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B9348  token: 0x6000A8A
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x02097E50  token: 0x6000A8B
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer) { }
        // RVA: 0x057B9258  token: 0x6000A8C
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A8D
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001D1  // size: 0x10
    public static class _BlueprintEnd_000008B4$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B9058  token: 0x6000A8E
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B915C  token: 0x6000A8F
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE86E0  token: 0x6000A90
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A91
        public static System.Void Initialize() { }
        // RVA: 0x03CE86D0  token: 0x6000A92
        private static System.Void .cctor() { }
        // RVA: 0x057B91B0  token: 0x6000A93
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer) { }

    }

    // TypeToken: 0x20001D2  // size: 0x80
    public sealed class _BlueprintStart_000008B5$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A94
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A95
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057B98C8  token: 0x6000A96
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000A97
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001D3  // size: 0x10
    public static class _BlueprintStart_000008B5$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B96D4  token: 0x6000A98
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B97D8  token: 0x6000A99
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE85A0  token: 0x6000A9A
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000A9B
        public static System.Void Initialize() { }
        // RVA: 0x03CE8590  token: 0x6000A9C
        private static System.Void .cctor() { }
        // RVA: 0x057B982C  token: 0x6000A9D
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001D4  // size: 0x80
    public sealed class _PreSelectStart_000008B6$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000A9E
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000A9F
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BE394  token: 0x6000AA0
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AA1
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001D5  // size: 0x10
    public static class _PreSelectStart_000008B6$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BE1A4  token: 0x6000AA2
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BE2A8  token: 0x6000AA3
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7380  token: 0x6000AA4
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AA5
        public static System.Void Initialize() { }
        // RVA: 0x03CE7370  token: 0x6000AA6
        private static System.Void .cctor() { }
        // RVA: 0x057BE2FC  token: 0x6000AA7
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001D6  // size: 0x80
    public sealed class _PreSelectEnd_000008B7$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000AA8
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000AA9
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BDE38  token: 0x6000AAA
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AAB
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001D7  // size: 0x10
    public static class _PreSelectEnd_000008B7$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BDC4C  token: 0x6000AAC
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BDD50  token: 0x6000AAD
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE74C0  token: 0x6000AAE
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AAF
        public static System.Void Initialize() { }
        // RVA: 0x03CE74B0  token: 0x6000AB0
        private static System.Void .cctor() { }
        // RVA: 0x057BDDA4  token: 0x6000AB1
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001D8  // size: 0x80
    public sealed class _PreSelectProcess_000008B8$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000AB2
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000AB3
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BE0E0  token: 0x6000AB4
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AB5
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001D9  // size: 0x10
    public static class _PreSelectProcess_000008B8$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BDEFC  token: 0x6000AB6
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BE000  token: 0x6000AB7
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7420  token: 0x6000AB8
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AB9
        public static System.Void Initialize() { }
        // RVA: 0x03CE7410  token: 0x6000ABA
        private static System.Void .cctor() { }
        // RVA: 0x057BE054  token: 0x6000ABB
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001DA  // size: 0x80
    public sealed class _ContinuationStart_000008B9$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000ABC
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000ABD
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BA458  token: 0x6000ABE
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000ABF
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001DB  // size: 0x10
    public static class _ContinuationStart_000008B9$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BA268  token: 0x6000AC0
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BA36C  token: 0x6000AC1
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8280  token: 0x6000AC2
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AC3
        public static System.Void Initialize() { }
        // RVA: 0x03CE8270  token: 0x6000AC4
        private static System.Void .cctor() { }
        // RVA: 0x057BA3C0  token: 0x6000AC5
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001DC  // size: 0x80
    public sealed class _ContinuationEnd_000008BA$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000AC6
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000AC7
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057B9EFC  token: 0x6000AC8
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AC9
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001DD  // size: 0x10
    public static class _ContinuationEnd_000008BA$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B9D18  token: 0x6000ACA
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057B9E1C  token: 0x6000ACB
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE83C0  token: 0x6000ACC
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000ACD
        public static System.Void Initialize() { }
        // RVA: 0x03CE83B0  token: 0x6000ACE
        private static System.Void .cctor() { }
        // RVA: 0x057B9E70  token: 0x6000ACF
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001DE  // size: 0x80
    public sealed class _ContinuationProcess_000008BB$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000AD0
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000AD1
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BA1A4  token: 0x6000AD2
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AD3
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001DF  // size: 0x10
    public static class _ContinuationProcess_000008BB$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057B9FC0  token: 0x6000AD4
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BA0C4  token: 0x6000AD5
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8320  token: 0x6000AD6
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AD7
        public static System.Void Initialize() { }
        // RVA: 0x03CE8310  token: 0x6000AD8
        private static System.Void .cctor() { }
        // RVA: 0x057BA118  token: 0x6000AD9
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001E0  // size: 0x80
    public sealed class _SocialSharingStart_000008BC$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000ADA
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000ADB
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BF2D8  token: 0x6000ADC
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000ADD
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001E1  // size: 0x10
    public static class _SocialSharingStart_000008BC$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BF0E8  token: 0x6000ADE
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BF1EC  token: 0x6000ADF
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE6F20  token: 0x6000AE0
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AE1
        public static System.Void Initialize() { }
        // RVA: 0x03CE6F10  token: 0x6000AE2
        private static System.Void .cctor() { }
        // RVA: 0x057BF240  token: 0x6000AE3
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001E2  // size: 0x80
    public sealed class _PowerInteractionStart_000008BD$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000AE4
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000AE5
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BDB88  token: 0x6000AE6
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AE7
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001E3  // size: 0x10
    public static class _PowerInteractionStart_000008BD$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BD994  token: 0x6000AE8
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BDA98  token: 0x6000AE9
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7560  token: 0x6000AEA
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AEB
        public static System.Void Initialize() { }
        // RVA: 0x03CE7550  token: 0x6000AEC
        private static System.Void .cctor() { }
        // RVA: 0x057BDAEC  token: 0x6000AED
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001E4  // size: 0x80
    public sealed class _PowerInteractionEnd_000008BE$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x057B7F10  token: 0x6000AEE
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000AEF
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057BD8D0  token: 0x6000AF0
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x6000AF1
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x20001E5  // size: 0x10
    public static class _PowerInteractionEnd_000008BE$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x057BD6E0  token: 0x6000AF2
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x057BD7E4  token: 0x6000AF3
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE7600  token: 0x6000AF4
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000AF5
        public static System.Void Initialize() { }
        // RVA: 0x03CE75F0  token: 0x6000AF6
        private static System.Void .cctor() { }
        // RVA: 0x057BD838  token: 0x6000AF7
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x2000193  // size: 0xB0
    public sealed struct AdditiveEffectRenderJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* qr;  // 0x10
        public System.Int64 time;  // 0x18
        public UnityEngine.HyperGryph.ECS.EntityManager rEntityManager;  // 0x20
        public Beyond.Gameplay.Factory.FPtrNativeCurve buildCurve;  // 0x30
        public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve0;  // 0x48
        public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve1;  // 0x60
        public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve0;  // 0x78
        public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve1;  // 0x90
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedExtDataPtr;  // 0xa8

        // Methods
        // RVA: 0x0579E634  token: 0x60008FD
        private System.Void _BPNormalEffectExecute(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579E0E8  token: 0x60008FE
        private System.Void _BPBuildEffectExecute(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579DD6C  token: 0x60008FF
        private System.Void _BPBuildCutoffEffectExecute(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579E59C  token: 0x6000900
        private static System.Void _BPBuildStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579E460  token: 0x6000901
        private static System.Void _BPBuildProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579E354  token: 0x6000902
        private static System.Void _BPBuildEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579E088  token: 0x6000903
        private static System.Void _BPBuildCutoffStateStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579DEF0  token: 0x6000904
        private static System.Void _BPBuildCutoffStateEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579DFD0  token: 0x6000905
        private static System.Void _BPBuildCutoffStateProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x033253B0  token: 0x6000906
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x0579DA5C  token: 0x6000907
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x0579D224  token: 0x6000908
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x0579F5D0  token: 0x6000909
        private static System.Void _CutoffStateStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579F3FC  token: 0x600090A
        private static System.Void _CutoffStateEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579F4DC  token: 0x600090B
        private static System.Void _CutoffStateProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579EFA0  token: 0x600090C
        private static System.Void _BuildStateStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579EC6C  token: 0x600090D
        private static System.Void _BuildStateEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579EF08  token: 0x600090E
        private static System.Void _BuildStateProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579FF04  token: 0x600090F
        private static System.Void _HighLightStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579FA34  token: 0x6000910
        private static System.Void _HighLightEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579FCE4  token: 0x6000911
        private static System.Void _HighLightProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F8B4  token: 0x6000912
        private static System.Void _FigureStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F84C  token: 0x6000913
        private static System.Void _FigureProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F6E8  token: 0x6000914
        private static System.Void _FigureEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0298  token: 0x6000915
        private static System.Void _HintStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha) { }
        // RVA: 0x057A0050  token: 0x6000916
        private static System.Void _HintEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A00B0  token: 0x6000917
        private static System.Void _HintProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A08B4  token: 0x6000918
        private static System.Void _OverloadStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A03BC  token: 0x6000919
        private static System.Void _OverloadEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0768  token: 0x600091A
        private static System.Void _OverloadProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0708  token: 0x600091B
        private static System.Void _OverloadInvalidStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A04CC  token: 0x600091C
        private static System.Void _OverloadInvalidEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A052C  token: 0x600091D
        private static System.Void _OverloadInvalidProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A10B8  token: 0x600091E
        private static System.Void _Repair0Start(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0E98  token: 0x600091F
        private static System.Void _Repair0End(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A1038  token: 0x6000920
        private static System.Void _Repair0Process(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x057A1428  token: 0x6000921
        private static System.Void _Repair1Start(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A1220  token: 0x6000922
        private static System.Void _Repair1End(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A1310  token: 0x6000923
        private static System.Void _Repair1Process(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x0579C120  token: 0x6000924
        private static System.Void _BlueprintProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer) { }
        // RVA: 0x0579EB5C  token: 0x6000925
        private static System.Void _BlueprintProcessInternal(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579E80C  token: 0x6000926
        private static System.Void _BlueprintEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer) { }
        // RVA: 0x0579EC0C  token: 0x6000927
        private static System.Void _BlueprintStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0E38  token: 0x6000928
        private static System.Void _PreSelectStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0C38  token: 0x6000929
        private static System.Void _PreSelectEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0C98  token: 0x600092A
        private static System.Void _PreSelectProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F2E8  token: 0x600092B
        private static System.Void _ContinuationStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F13C  token: 0x600092C
        private static System.Void _ContinuationEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F19C  token: 0x600092D
        private static System.Void _ContinuationProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A15AC  token: 0x600092E
        private static System.Void _SocialSharingStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0B64  token: 0x600092F
        private static System.Void _PowerInteractionStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A09A8  token: 0x6000930
        private static System.Void _PowerInteractionEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579DADC  token: 0x6000931
        public static System.Void ResetMaterial(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, System.Boolean resetRenderPass, System.Boolean resetAdditiveMat) { }
        // RVA: 0x033253F0  token: 0x6000932
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x0579DC94  token: 0x6000933
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }
        // RVA: 0x02BC0AA0  token: 0x6000934
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandleDep0, Unity.Jobs.JobHandle jobHandleDep1, System.Int32 innerLoopBatchCount) { }
        // RVA: 0x0579E4F8  token: 0x6000935
        public static System.Void _BPBuildStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579E3EC  token: 0x6000936
        public static System.Void _BPBuildProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579E23C  token: 0x6000937
        public static System.Void _BPBuildEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579E030  token: 0x6000938
        public static System.Void _BPBuildCutoffStateStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579DE50  token: 0x6000939
        public static System.Void _BPBuildCutoffStateEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579DF50  token: 0x600093A
        public static System.Void _BPBuildCutoffStateProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579F53C  token: 0x600093B
        public static System.Void _CutoffStateStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579F348  token: 0x600093C
        public static System.Void _CutoffStateEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579F45C  token: 0x600093D
        public static System.Void _CutoffStateProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder) { }
        // RVA: 0x0579EE24  token: 0x600093E
        public static System.Void _BuildStateProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time) { }
        // RVA: 0x0579FD44  token: 0x600093F
        public static System.Void _HighLightStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F914  token: 0x6000940
        public static System.Void _HighLightEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579FA94  token: 0x6000941
        public static System.Void _HighLightProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F8AC  token: 0x6000942
        public static System.Void _FigureStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F748  token: 0x6000943
        public static System.Void _FigureProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F630  token: 0x6000944
        public static System.Void _FigureEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0110  token: 0x6000945
        public static System.Void _HintStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha) { }
        // RVA: 0x0579FF64  token: 0x6000946
        public static System.Void _HintEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0350B670  token: 0x6000947
        public static System.Void _HintProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A07C8  token: 0x6000948
        public static System.Void _OverloadStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A030C  token: 0x6000949
        public static System.Void _OverloadEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0350B670  token: 0x600094A
        public static System.Void _OverloadProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A058C  token: 0x600094B
        public static System.Void _OverloadInvalidStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A041C  token: 0x600094C
        public static System.Void _OverloadInvalidEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0350B670  token: 0x600094D
        public static System.Void _OverloadInvalidProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0F70  token: 0x600094E
        public static System.Void _Repair0Process$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x057A1390  token: 0x600094F
        public static System.Void _Repair1Start$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A1180  token: 0x6000950
        public static System.Void _Repair1End$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A1280  token: 0x6000951
        public static System.Void _Repair1Process$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time) { }
        // RVA: 0x0579E880  token: 0x6000952
        public static System.Void _BlueprintProcessInternal$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579E71C  token: 0x6000953
        public static System.Void _BlueprintEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer) { }
        // RVA: 0x0579EBBC  token: 0x6000954
        public static System.Void _BlueprintStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0CF8  token: 0x6000955
        public static System.Void _PreSelectStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0BC4  token: 0x6000956
        public static System.Void _PreSelectEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0350B670  token: 0x6000957
        public static System.Void _PreSelectProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0579F1FC  token: 0x6000958
        public static System.Void _ContinuationStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0350B670  token: 0x6000959
        public static System.Void _ContinuationEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x0350B670  token: 0x600095A
        public static System.Void _ContinuationProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A1488  token: 0x600095B
        public static System.Void _SocialSharingStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0A08  token: 0x600095C
        public static System.Void _PowerInteractionStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }
        // RVA: 0x057A0914  token: 0x600095D
        public static System.Void _PowerInteractionEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder) { }

    }

    // TypeToken: 0x20001E6  // size: 0x10
    public static class AudioJobs
    {
        // Methods
        // RVA: 0x057ACC7C  token: 0x6000AF8
        private static System.Void _EntityIdx(System.Int32 groupIdx, UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange blockRange, UnityEngine.HyperGryph.ECS.GroupType group, System.Int32& startEntityIdx, System.Int32& endEntityIdx) { }
        // RVA: 0x0350B670  token: 0x6000AF9
        private static System.Void _SetDebugGizmosType(Beyond.Gameplay.Factory.AudioFragment& audioFrag, Beyond.Gameplay.Factory.AudioDebugGizmosType t) { }

    }

    // TypeToken: 0x20001ED  // size: 0x528
    public sealed struct BatchArrowJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Mathematics.float4 forbiddenColor;  // 0x20
        public Unity.Mathematics.float4 evaluatedColor;  // 0x30
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult normalQr;  // 0x40
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult previewQr;  // 0x60
        public Beyond.Gameplay.Factory.GlobalEnv globalEnv;  // 0x80
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>* outputMatrices;  // 0x4f8
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr;  // 0x500
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x508
        public Unity.Mathematics.float4 normalColor;  // 0x510
        private System.Int32 m_threadIndex;  // 0x520

        // Methods
        // RVA: 0x057AE694  token: 0x6000B00
        private System.Void _ExecutePort(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr) { }
        // RVA: 0x057AED24  token: 0x6000B01
        private System.Void _ExecutePreview(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr) { }
        // RVA: 0x057AD9E0  token: 0x6000B02
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057ADAA4  token: 0x6000B03
        private System.Void _BatchPortArrow(System.Boolean formulaManMode, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos, Beyond.Gameplay.Factory.ComplexPortFragment ports, Unity.Mathematics.float4x4 uvList, System.Single mapHeightValue, System.Boolean inOut, System.Boolean preview, System.Boolean inBuildMode, System.Boolean inMainRegion, System.Boolean buildingBelt, System.Boolean buildingPipe, System.Boolean blueprintSelectedUnit, System.Boolean inputDisabled, System.Boolean outputDisabled, System.Boolean inputFluidDisabled, System.Boolean outputFluidDisabled) { }
        // RVA: 0x026DBDA0  token: 0x6000B04
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x057AD928  token: 0x6000B05
        public virtual System.Void Execute() { }

    }

    // TypeToken: 0x20001EE  // size: 0x4C0
    public sealed struct BatchInsideConveyorJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult normalQr;  // 0x10
        public Beyond.Gameplay.Factory.GlobalEnv globalEnv;  // 0x30
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4> conveyorInsideMatrices;  // 0x4a8
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x4b0
        private System.Int32 m_threadIndex;  // 0x4b8

        // Methods
        // RVA: 0x057AF29C  token: 0x6000B06
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057AF7AC  token: 0x6000B07
        private System.Void _CollectInsideConveyor(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr) { }
        // RVA: 0x057AF390  token: 0x6000B08
        private System.Void _BatchPortInside(System.UInt32 nodeId, Unity.Mathematics.float3 pos, Unity.Mathematics.quaternion rot, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Beyond.Gameplay.Factory.ComplexPortFragment& ports, System.Boolean bInOut, System.Single mapHeightValue, System.Boolean blueprintSelectedUnit) { }
        // RVA: 0x026DBDE0  token: 0x6000B09
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x057AF314  token: 0x6000B0A
        public virtual System.Void Execute() { }

    }

    // TypeToken: 0x20001EF  // size: 0x518
    public sealed struct BatchNormalArrowJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Mathematics.float4 forbiddenColor;  // 0x20
        public Unity.Mathematics.float4 evaluatedColor;  // 0x30
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult normalQr;  // 0x40
        public Beyond.Gameplay.Factory.GlobalEnv globalEnv;  // 0x60
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>* outputMatrices;  // 0x4d8
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr;  // 0x4e0
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x4e8
        public Unity.Mathematics.float4 normalColor;  // 0x4f0
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<System.Int32,System.Boolean> arrowPlacedDic;  // 0x500
        private System.Int32 m_threadIndex;  // 0x510

        // Methods
        // RVA: 0x057B0A40  token: 0x6000B0B
        private System.Void _ExecutePort(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr) { }
        // RVA: 0x057AFDFC  token: 0x6000B0C
        private System.Void _BatchPortArrow(System.UInt32 nodeId, System.Boolean formulaManMode, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos, Beyond.Gameplay.Factory.ComplexPortFragment ports, Unity.Mathematics.float4x4 uvList, System.Single mapHeightValue, System.Boolean inOut, System.Boolean inBuildMode, System.Boolean inMainRegion, System.Boolean buildingBelt, System.Boolean buildingPipe, System.Boolean inputDisabled, System.Boolean outputDisabled, System.Boolean inputFluidDisabled, System.Boolean outputFluidDisabled) { }
        // RVA: 0x057AFD28  token: 0x6000B0D
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057AFCA0  token: 0x6000B0E
        public virtual System.Void Execute() { }
        // RVA: 0x057AFDA0  token: 0x6000B0F
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001F0  // size: 0x4F8
    public sealed struct BatchPreviewArrowJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult previewQr;  // 0x20
        public Beyond.Gameplay.Factory.GlobalEnv globalEnv;  // 0x40
        public Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>* outputMatrices;  // 0x4b8
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr;  // 0x4c0
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x4c8
        public Unity.Mathematics.float4 normalColor;  // 0x4d0
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<System.Int32,System.Boolean> arrowPlacedDic;  // 0x4e0
        private System.Int32 m_threadIndex;  // 0x4f0

        // Methods
        // RVA: 0x057B10CC  token: 0x6000B10
        public virtual System.Void Execute() { }
        // RVA: 0x057B1B84  token: 0x6000B11
        private System.Void _ExecutePreview(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr) { }
        // RVA: 0x057B11C4  token: 0x6000B12
        private System.Void _BatchPortArrow(System.Boolean formulaManMode, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos, Beyond.Gameplay.Factory.ComplexPortFragment ports, Unity.Mathematics.float4x4 uvList, System.Single mapHeightValue, System.Boolean inOut, System.Boolean inBuildMode, System.Boolean inMainRegion) { }
        // RVA: 0x057B1168  token: 0x6000B13
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001F1  // size: 0x20
    public sealed struct BufferSwapJob : Unity.Jobs.IJob
    {
        // Fields
        public Beyond.Gameplay.Factory.GlobalEnv* globalEnvPtr;  // 0x10
        public System.Boolean bConveyorSwap;  // 0x18
        public System.Boolean bGuideFigureSwap;  // 0x19
        public System.Boolean bPreviewConveyorSwap;  // 0x1a
        public System.Boolean bPipeSwap;  // 0x1b
        public System.Boolean bPortArrowSwap;  // 0x1c
        public System.Boolean bCargoSwap;  // 0x1d
        public System.Boolean bWireSwap;  // 0x1e

        // Methods
        // RVA: 0x057B20B0  token: 0x6000B14
        public virtual System.Void Execute() { }

    }

    // TypeToken: 0x20001F2  // size: 0x30
    public sealed struct BuildingLiquidRenderJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_qr;  // 0x20
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x28

        // Methods
        // RVA: 0x057B2168  token: 0x6000B15
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x01062B80  token: 0x6000B16
        private System.Void _ApplyLiquidPerDraw(UnityEngine.HyperGryph.ECS.Entity rEntity, System.ValueTuple<System.Int32,System.UInt32> liquidData) { }
        // RVA: 0x057B2790  token: 0x6000B17
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02BBA8F0  token: 0x6000B18
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x02BBAC40  token: 0x6000B19
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }
        // RVA: 0x02BBA930  token: 0x6000B1A
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001F3  // size: 0x58
    public sealed struct BuildingStatePosCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public System.Single offsetY;  // 0x30
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPath;  // 0x38
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4> statePosList;  // 0x40
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x48
        public System.Boolean isInFight;  // 0x50

        // Methods
        // RVA: 0x057B2810  token: 0x6000B1B
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B2B70  token: 0x6000B1C
        private System.Void _Collect(Beyond.Gameplay.Factory.UnitFragment& unit, Beyond.Gameplay.Factory.UnitTransFragment& trans, Beyond.Gameplay.Factory.UnitConfigFragment& config, Beyond.Gameplay.Factory.UnitStatusFragment& status, Beyond.Gameplay.Factory.SharedDataFragment& sharedData) { }
        // RVA: 0x057B2A68  token: 0x6000B1D
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057B2AF4  token: 0x6000B1E
        public virtual System.Void Execute() { }
        // RVA: 0x026DBC20  token: 0x6000B1F
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001F4  // size: 0x40
    public sealed struct BuildingStateRendererJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x20
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> statePosList;  // 0x30

        // Methods
        // RVA: 0x057B30C8  token: 0x6000B20
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001F5  // size: 0x58
    public sealed struct CargoCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public System.Single offsetY;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x18
        public Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>* rendererList;  // 0x38
        public Beyond.Gameplay.Factory.GlobalEnv* env;  // 0x40
        public Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt* conveyorExtData;  // 0x48
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x50

        // Methods
        // RVA: 0x057B3278  token: 0x6000B21
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B34F8  token: 0x6000B22
        private System.Void _Collect(Beyond.Gameplay.Factory.CargoFragment* cargoFrag, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& conveyorExt) { }
        // RVA: 0x057B344C  token: 0x6000B23
        public virtual System.Void Execute() { }
        // RVA: 0x03325470  token: 0x6000B24
        public System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef) { }
        // RVA: 0x033254B0  token: 0x6000B25
        public System.Void SetConveyorExtData(System.IntPtr data) { }
        // RVA: 0x03325430  token: 0x6000B26
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001F6  // size: 0x48
    public sealed struct CargoPredictJob : Unity.Jobs.IJobParallelFor, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* qr;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x18
        public System.Int64 serverTime;  // 0x28
        public Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt* conveyorExtData;  // 0x30
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x38
        public Beyond.Gameplay.Factory.GlobalEnv* env;  // 0x40

        // Methods
        // RVA: 0x057B3728  token: 0x6000B27
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x026DF630  token: 0x6000B28
        public System.Void SetConveyorExtData(System.IntPtr data) { }
        // RVA: 0x026DF5F0  token: 0x6000B29
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x026DF5B0  token: 0x6000B2A
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x026DE7F0  token: 0x6000B2B
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }

    }

    // TypeToken: 0x20001F7  // size: 0x30
    public sealed struct CargoPredictQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_queryResult;  // 0x28

        // Methods
        // RVA: 0x057B3B44  token: 0x6000B2C
        public virtual System.Void Execute() { }
        // RVA: 0x026DF670  token: 0x6000B2D
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x20001F8  // size: 0x38
    public sealed struct CargoRenderJob : Unity.Jobs.IJobParallelForDefer, Unity.Jobs.IJobParallelFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x20
        public Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>* rendererList;  // 0x30

        // Methods
        // RVA: 0x057B3C20  token: 0x6000B2E
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x024F4880  token: 0x6000B2F
        public System.Void SetRendererList(System.IntPtr data) { }

    }

    // TypeToken: 0x20001F9  // size: 0x30
    public sealed struct CargoRenderQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_queryResult;  // 0x28

        // Methods
        // RVA: 0x057B3DAC  token: 0x6000B30
        public virtual System.Void Execute() { }
        // RVA: 0x057B3E68  token: 0x6000B31
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x20001FA  // size: 0x58
    public sealed struct ConveyorCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* lPosList;  // 0x30
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* mPosList;  // 0x38
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* rPosList;  // 0x40
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x48
        public Beyond.Gameplay.Factory.GlobalEnv* globalEnvPtr;  // 0x50

        // Methods
        // RVA: 0x057B3EE4  token: 0x6000B32
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B41A4  token: 0x6000B33
        private System.Void _Collect(Beyond.Gameplay.Factory.ConveyorFragment& conveyor, Beyond.Gameplay.Factory.SharedDataFragment& sharedDataFrag, System.Boolean preview, System.Boolean valid) { }
        // RVA: 0x057B409C  token: 0x6000B34
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057B4128  token: 0x6000B35
        public virtual System.Void Execute() { }
        // RVA: 0x0322B730  token: 0x6000B36
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001FB  // size: 0x50
    public sealed struct ConveyorFigureRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public System.Int32 startOffsetIndex;  // 0x10
        public System.Single conveyorOffsetY;  // 0x14
        public System.Single simpleDrawingType;  // 0x18
        public System.IntPtr dataMatrices;  // 0x20
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x28
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x38
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x48

        // Methods
        // RVA: 0x057B4614  token: 0x6000B37
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B47F8  token: 0x6000B38
        private System.Void _UpdateCachedConveyor(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.UInt32 sharedDataHandle, System.Single adjustGroundHeight, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single conveyorIdx, System.Single conveyorLength, System.Single speed, System.Boolean preview, System.Single offsetY, System.Boolean valid, System.Boolean highlight, System.Boolean selectTypeInvalid) { }
        // RVA: 0x057B4588  token: 0x6000B39
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02F533B0  token: 0x6000B3A
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001FC  // size: 0x80
    public sealed struct ConveyorInsideRenderJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> matrices;  // 0x10
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> renderEntities;  // 0x20
        public UnityEngine.Color beltInsideColor;  // 0x30
        public System.Single speed;  // 0x40
        public System.Single offsetY;  // 0x44
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x48
        public Unity.Collections.NativeArray<Beyond.Gameplay.Factory.PerDrawConfig> perDrawConfigs;  // 0x58
        public Unity.Collections.NativeArray<Beyond.Gameplay.Factory.PerDrawConfig> blueprintPerDrawConfigs;  // 0x68
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.ApplyRender> applyRenderFunc;  // 0x78

        // Methods
        // RVA: 0x057B4A54  token: 0x6000B3B
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20001FD  // size: 0x60
    public sealed struct ConveyorPreviewCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* lPosList;  // 0x30
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* mPosList;  // 0x38
        public Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>* rPosList;  // 0x40
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x48
        public Beyond.Gameplay.Factory.GlobalEnv* globalEnvPtr;  // 0x50
        public System.Void* conveyorInfoAllocatorPtr;  // 0x58

        // Methods
        // RVA: 0x057B4CD8  token: 0x6000B3C
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B4F28  token: 0x6000B3D
        private System.Void _Collect(Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment& conveyor, Beyond.Gameplay.Factory.SharedDataFragment& sharedData, System.Boolean preview, System.Boolean valid) { }
        // RVA: 0x057B4EAC  token: 0x6000B3E
        public virtual System.Void Execute() { }
        // RVA: 0x026DBC60  token: 0x6000B3F
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001FE  // size: 0x50
    public sealed struct ConveyorRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public System.Single conveyorOffsetY;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x18
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x28
        public System.IntPtr dataMatrices;  // 0x38
        public System.IntPtr previewDataMatrices;  // 0x40
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x48

        // Methods
        // RVA: 0x057B51C8  token: 0x6000B40
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057B5418  token: 0x6000B41
        private System.Void _UpdateCachedConveyor(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.Single adjustGroundHeight, System.UInt32 sharedDataHandle, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single conveyorIdx, System.Single conveyorLength, System.Single speed, System.Boolean preview, Beyond.Gameplay.Factory.BlueprintState.EffectType blueprintRenderType, System.Single offsetY, System.UInt32 lightMode, System.Boolean valid, System.Boolean highlight, System.Boolean selectTypeInvalid) { }
        // RVA: 0x057B5148  token: 0x6000B42
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02F51DC0  token: 0x6000B43
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x20001FF  // size: 0xE0
    public sealed struct InteractFacCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public Unity.Mathematics.float3 targetPosition;  // 0x10
        public Unity.Mathematics.float3 targetForward;  // 0x1c
        public System.Single maxAngle;  // 0x28
        public System.Single maxDist;  // 0x2c
        public System.Single radiusExpand;  // 0x30
        public static System.Single ROLE_HIGH_ADDED_VALUE;  // const
        public static System.Single PIPE_HEIGHT_RANGE;  // const
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x38
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult buildingQr;  // 0x48
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult pipeRendererQr;  // 0x68
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult conveyorRendererQr;  // 0x88
        public Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap* mNearBuildingInfo;  // 0xa8
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* mConveyorInfo;  // 0xb0
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* mPipeInfo;  // 0xb8
        public Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap* mNearBuildingInfoLast;  // 0xc0
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* mConveyorInfoLast;  // 0xc8
        public Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* mPipeInfoLast;  // 0xd0
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0xd8
        private static readonly Unity.Collections.FixedList512Bytes<Unity.Mathematics.float3> LOGISTIC_INTERACT_SAMPLE_OFFSETS;  // static @ 0x0

        // Methods
        // RVA: 0x057B77A4  token: 0x6000B44
        private System.Void _SwapBuffer() { }
        // RVA: 0x057B58F0  token: 0x6000B45
        public virtual System.Void Execute() { }
        // RVA: 0x057B5DE8  token: 0x6000B46
        private System.Void _ExecuteBuilding() { }
        // RVA: 0x057B6F48  token: 0x6000B47
        private System.Void _ExecuteConveyor() { }
        // RVA: 0x057B7240  token: 0x6000B48
        private System.Void _ExecutePipe() { }
        // RVA: 0x057B5988  token: 0x6000B49
        private System.Boolean _CheckDist(Unity.Mathematics.float3 pos, System.Single distSqThreshold, System.Int32& minSearchIndex) { }
        // RVA: 0x057B756C  token: 0x6000B4A
        private static Unity.Mathematics.float3 _SnapDirectionToAxis(Unity.Mathematics.float3 direction) { }
        // RVA: 0x031E6E60  token: 0x6000B4B
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x03925820  token: 0x6000B4C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000203  // size: 0x28
    public sealed struct LocalToWorldJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* qr;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr;  // 0x18
        public System.Int32 frameCount;  // 0x20

        // Methods
        // RVA: 0x057C06B8  token: 0x6000B57
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x028B4730  token: 0x6000B58
        public static System.Void TransTRS(Beyond.Gameplay.Factory.LocalToWorld& localToWorld, System.IntPtr hierarchyIntPtr, System.Int32 frameCount) { }
        // RVA: 0x028B48A0  token: 0x6000B59
        public static System.Void TransTRS(Beyond.Gameplay.Factory.LocalToWorld& localToWorld, UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData* hierarchyPtr, System.Int32 frameCount) { }
        // RVA: 0x057C0638  token: 0x6000B5A
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02BBF010  token: 0x6000B5B
        public System.Void SetHierarchyData(System.IntPtr data) { }
        // RVA: 0x02BBEFD0  token: 0x6000B5C
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x02BBEF20  token: 0x6000B5D
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }

    }

    // TypeToken: 0x2000204  // size: 0x30
    public sealed struct LocalToWorldQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_queryResult;  // 0x28

        // Methods
        // RVA: 0x057C0810  token: 0x6000B5E
        public virtual System.Void Execute() { }
        // RVA: 0x02BBF050  token: 0x6000B5F
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x2000205  // size: 0x38
    public sealed struct LogisticEffectJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public System.Int64 deltaTime;  // 0x30

        // Methods
        // RVA: 0x057C08EC  token: 0x6000B60
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000206  // size: 0x20
    public sealed struct LookAtJob : Unity.Jobs.IJobParallelFor, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_qr;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr;  // 0x18

        // Methods
        // RVA: 0x057C0D0C  token: 0x6000B61
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x026DFA60  token: 0x6000B62
        public System.Void SetHierarchyData(System.IntPtr data) { }
        // RVA: 0x026DFAA0  token: 0x6000B63
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x026DFD50  token: 0x6000B64
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }

    }

    // TypeToken: 0x2000207  // size: 0x30
    public sealed struct LookAtQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_queryResult;  // 0x28

        // Methods
        // RVA: 0x057C151C  token: 0x6000B65
        public virtual System.Void Execute() { }
        // RVA: 0x026DF6F0  token: 0x6000B66
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x2000208  // size: 0x48
    public sealed struct OutputCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public System.Single offsetY;  // 0x30
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.OutputRendererInfo> posList;  // 0x38
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x40

        // Methods
        // RVA: 0x057C1710  token: 0x6000B67
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C198C  token: 0x6000B68
        private System.Void _Collect(Beyond.Gameplay.Factory.UnitFragment& unit, Beyond.Gameplay.Factory.UnitTransFragment& trans, Beyond.Gameplay.Factory.UnitConfigFragment& config, Beyond.Gameplay.Factory.OutputFragment& output, Beyond.Gameplay.Factory.SharedDataFragment& sharedData) { }
        // RVA: 0x057C15D8  token: 0x6000B69
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057C1664  token: 0x6000B6A
        public virtual System.Void Execute() { }
        // RVA: 0x026DBCE0  token: 0x6000B6B
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x2000209  // size: 0x40
    public sealed struct OutputRenderJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x20
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.OutputRendererInfo> posList;  // 0x30

        // Methods
        // RVA: 0x057C1DAC  token: 0x6000B6C
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200020A  // size: 0x40
    public sealed struct PedestalFlashJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public System.Int64 time;  // 0x30
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedExtDataPtr;  // 0x38

        // Methods
        // RVA: 0x057C21E8  token: 0x6000B6D
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C245C  token: 0x6000B6E
        private Unity.Mathematics.float4 _Flash(Beyond.Gameplay.Factory.PedestalLightFlashFragment& flashConfig, System.Single deltaTime) { }
        // RVA: 0x057C2168  token: 0x6000B6F
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x0346C8E0  token: 0x6000B70
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x200020B  // size: 0x98
    public sealed struct PipeCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult pipeQr;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult previewPipeQr;  // 0x30
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeLPosMatrices;  // 0x50
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeMPosMatrices;  // 0x58
        public Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>* pipeRPosMatrices;  // 0x60
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* trackLPosMatrices;  // 0x68
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* trackMPosMatrices;  // 0x70
        public Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>* trackRPosMatrices;  // 0x78
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4> comPosMatrices;  // 0x80
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x88
        public Beyond.Gameplay.Factory.GlobalEnv* envPtr;  // 0x90

        // Properties
        System.Int32 pipeCount { get; /* RVA: 0x057C3D40 */ }

        // Methods
        // RVA: 0x057C2AD8  token: 0x6000B72
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C383C  token: 0x6000B73
        private System.Void _ExecutePipe(UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange blockRange, Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> groups) { }
        // RVA: 0x057C3AE0  token: 0x6000B74
        private System.Void _ExecutePreviewPipe(UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange blockRange, Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> groups) { }
        // RVA: 0x057C316C  token: 0x6000B75
        private System.Void _CollectPipe(System.Int32 pipeLength, System.UInt32 memoryStartOffset, System.UInt32 memoryEndOffset, System.Int32 subItemType, System.Single waterThickness, System.Single waterFlowDeltaTime, System.Single waterDirection, System.Single pipeHeight, System.UInt32 sharedDataHandle, System.Boolean isPreview, System.Boolean valid, System.Boolean highLight) { }
        // RVA: 0x057C2C78  token: 0x6000B76
        private System.Void _CollectPipeCom(Beyond.Gameplay.Factory.PipeFragment& pipe, System.UInt32 sharedDataHandle) { }
        // RVA: 0x057C35D8  token: 0x6000B77
        private System.Void _CollectTrack(System.Int32 pipeLength, System.UInt32 memoryStartOffset, System.UInt32 memoryEndOffset, System.Single pipeHeight, System.Single gridPathHeightStart, System.Single gridPathHeightEnd, System.UInt32 sharedDataHandle, System.Boolean pipeValid) { }
        // RVA: 0x057C2BEC  token: 0x6000B78
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057C2A5C  token: 0x6000B79
        public virtual System.Void Execute() { }
        // RVA: 0x026DBD20  token: 0x6000B7A
        public System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef) { }
        // RVA: 0x026DBD60  token: 0x6000B7B
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x200020C  // size: 0x50
    public sealed struct PipeComRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> comPosArr;  // 0x20
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x30
        public System.Boolean useDistanceFilter;  // 0x40
        public Unity.Mathematics.float2 distanceFilterCenterPos;  // 0x44
        public System.Single distanceThreshold;  // 0x4c

        // Methods
        // RVA: 0x057C3D70  token: 0x6000B7C
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }

    }

    // TypeToken: 0x200020D  // size: 0x40
    public sealed struct PipeFigureRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public System.Int32 startOffsetIndex;  // 0x10
        public System.Single simpleDrawingType;  // 0x14
        public System.IntPtr dataMatrices;  // 0x18
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x20
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x30

        // Methods
        // RVA: 0x057C4090  token: 0x6000B7D
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C43DC  token: 0x6000B7E
        private System.Void _UpdateCachedPipe(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.Byte protoType, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single indexInPipe, System.Single pipeLength, System.Single waterDirection, System.Single waterThickness, System.Single pipeHeight, System.Single subItemType, System.Boolean isPreview, System.Boolean valid, System.Boolean highLight) { }
        // RVA: 0x057C4350  token: 0x6000B7F
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }

    }

    // TypeToken: 0x200020E  // size: 0x48
    public sealed struct PipeHolderFigureRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Single offsetY;  // 0x20
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<UnityEngine.Matrix4x4> dataMatrices;  // 0x28
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x38

        // Methods
        // RVA: 0x057C4774  token: 0x6000B80
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C46E8  token: 0x6000B81
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }

    }

    // TypeToken: 0x200020F  // size: 0x40
    public sealed struct PipeHolderHideRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public System.Boolean drawPipe;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult holderQr;  // 0x18
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x38

        // Methods
        // RVA: 0x057C49E8  token: 0x6000B82
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C4B74  token: 0x6000B83
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02F53740  token: 0x6000B84
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x2000210  // size: 0x40
    public sealed struct PipeLogisticsPosCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x30
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<UnityEngine.Matrix4x4> posList;  // 0x38

        // Methods
        // RVA: 0x057C4D08  token: 0x6000B85
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C4C7C  token: 0x6000B86
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x036D0C20  token: 0x6000B87
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x057C4C00  token: 0x6000B88
        public virtual System.Void Execute() { }

    }

    // TypeToken: 0x2000211  // size: 0x60
    public sealed struct PipeRendererJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityManager rendererEntityManager;  // 0x20
        public System.Boolean inTopView;  // 0x30
        public System.Boolean useDistanceFilter;  // 0x31
        public Unity.Mathematics.float2 distanceFilterCenterPos;  // 0x34
        public System.Single distanceThreshold;  // 0x3c
        public System.IntPtr dataMatrices;  // 0x40
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x48
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x58

        // Methods
        // RVA: 0x057C505C  token: 0x6000B89
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057C5334  token: 0x6000B8A
        private System.Void _UpdateCachedPipe(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.Byte protoType, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single bend, System.UInt32 sharedDataHandle, System.Int32 indexInPipe, System.Int32 pipeLength, System.Single waterDirection, System.Single waterThickness, System.Single subItemType, Beyond.Gameplay.Factory.BlueprintState.EffectType blueprintRenderType, System.Single waterFlowDeltaTime, System.UInt32 lightMode, System.Boolean isPreview, System.Boolean valid, System.Boolean highLight) { }
        // RVA: 0x026E3E00  token: 0x6000B8B
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x2000212  // size: 0x80
    public sealed struct PipeTrackRendererJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.IntPtr leftArr;  // 0x20
        public System.IntPtr rightArr;  // 0x28
        public System.IntPtr middleArr;  // 0x30
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererLEntities;  // 0x38
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererREntities;  // 0x48
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererMEntities;  // 0x58
        public System.Boolean useDistanceFilter;  // 0x68
        public Unity.Mathematics.float2 distanceFilterCenterPos;  // 0x6c
        public System.Single distanceThreshold;  // 0x74
        public System.Boolean inTopView;  // 0x78

        // Methods
        // RVA: 0x057C5B88  token: 0x6000B8C
        public virtual System.Void Execute() { }
        // RVA: 0x057C5FAC  token: 0x6000B8D
        private System.Void _UpdateCachedTrack(UnityEngine.HyperGryph.ECS.Entity cachedEntity, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single indexInPipe, System.Single pipeLength, System.Single pipeHeight, System.Single gridPathHeight, System.Single gridPathHeightEnd, System.Boolean valid) { }

    }

    // TypeToken: 0x2000213  // size: 0x30
    public sealed struct PipeWaterThicknessQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_queryResult;  // 0x28

        // Methods
        // RVA: 0x057C6350  token: 0x6000B8E
        public virtual System.Void Execute() { }
        // RVA: 0x026DF770  token: 0x6000B8F
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x2000214  // size: 0x28
    public sealed struct PipeWaterThicknessRiseJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_qr;  // 0x10
        public System.Single deltaTime;  // 0x18
        public Beyond.Gameplay.Factory.GlobalEnv* globalEnv;  // 0x20

        // Methods
        // RVA: 0x057C640C  token: 0x6000B90
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057C648C  token: 0x6000B91
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x026DF530  token: 0x6000B92
        public System.Void SetGlobalEnv(Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x026DF4F0  token: 0x6000B93
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x026DF440  token: 0x6000B94
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }

    }

    // TypeToken: 0x2000215  // size: 0x50
    public sealed struct PortArrowRenderJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.IntPtr arrowMatricesReaderIntPtr;  // 0x10
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> renderEntities;  // 0x18
        public System.Boolean buildMode;  // 0x28
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x30
        public System.IntPtr arrowPlacedDicPtr;  // 0x40
        public System.Boolean bConflictCheck;  // 0x48

        // Methods
        // RVA: 0x057C6640  token: 0x6000B95
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000216  // size: 0x48
    public sealed struct PortStateCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4> portStatePosList;  // 0x30
        public System.Single pipePortBlockOffsetY;  // 0x38
        public System.Single conveyorPortBlockOffsetY;  // 0x3c
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x40

        // Methods
        // RVA: 0x057C6A1C  token: 0x6000B96
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C6BC0  token: 0x6000B97
        private System.Void _Collect(Beyond.Gameplay.Factory.ComplexPortFragment& complexPortFrag, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData) { }
        // RVA: 0x026DBCA0  token: 0x6000B98
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x057C69A0  token: 0x6000B99
        public virtual System.Void Execute() { }
        // RVA: 0x057C6914  token: 0x6000B9A
        public System.Void Execute(System.Int32 startIndex, System.Int32 count) { }

    }

    // TypeToken: 0x2000217  // size: 0x40
    public sealed struct PortStateRendererJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x20
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> posList;  // 0x30

        // Methods
        // RVA: 0x057C6E44  token: 0x6000B9B
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000218  // size: 0x30
    public sealed struct PreviewUnitQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_previewUnitQr;  // 0x28

        // Methods
        // RVA: 0x057C703C  token: 0x6000B9C
        public virtual System.Void Execute() { }
        // RVA: 0x0306C940  token: 0x6000B9D
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& previewUnitQr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x2000219  // size: 0x30
    public sealed struct PumpInEffectJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_qr;  // 0x20
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x28

        // Methods
        // RVA: 0x057C7178  token: 0x6000B9E
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C70F8  token: 0x6000B9F
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02BBA970  token: 0x6000BA0
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x02BBADC0  token: 0x6000BA1
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }
        // RVA: 0x02BBA9B0  token: 0x6000BA2
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x200021A  // size: 0x80
    public sealed struct StatusChangeJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x20
        public UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb;  // 0x40
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryBuildingState> queryBuildingState;  // 0x70
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.SetEntityFlashStatue> setEntityFlashStatue;  // 0x78

        // Methods
        // RVA: 0x057C75F0  token: 0x6000BA3
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200021B  // size: 0x70
    public sealed struct UnitCullingJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public System.Boolean inTopView;  // 0x10
        public Unity.Mathematics.float3 playerPos;  // 0x14
        public Unity.Mathematics.float3 mainCameraPos;  // 0x20
        public System.Single stateDistanceSqrt;  // 0x2c
        public System.Single buildingNameDistanceSqrt;  // 0x30
        public System.Single renderDistanceSqr;  // 0x34
        public System.Single maxConveyorLengthSqr;  // 0x38
        public System.Single maxPipeLengthSqr;  // 0x3c
        public Beyond.Gameplay.Factory.GlobalEnv* env;  // 0x40
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x48
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x68

        // Methods
        // RVA: 0x057C7DA4  token: 0x6000BA4
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057C79A4  token: 0x6000BA5
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x02C666A0  token: 0x6000BA6
        public System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef) { }
        // RVA: 0x02C66660  token: 0x6000BA7
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x200021C  // size: 0x28
    public sealed struct UnitPreviewRenderJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        public Beyond.Gameplay.Factory.GlobalEnv* env;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* qr;  // 0x18
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x20

        // Methods
        // RVA: 0x057C8160  token: 0x6000BA8
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x057C7E24  token: 0x6000BA9
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x0306C900  token: 0x6000BAA
        public System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef) { }
        // RVA: 0x0306C8C0  token: 0x6000BAB
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x0306C880  token: 0x6000BAC
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x0306C790  token: 0x6000BAD
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }

    }

    // TypeToken: 0x200021D  // size: 0x40
    public sealed struct UnitRendererQueryJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x10
        public System.Int32 jobCount;  // 0x20
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_unitQueryResult;  // 0x28
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_liquidQueryResult;  // 0x30
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_liquidPumpQueryResult;  // 0x38

        // Methods
        // RVA: 0x057C81E0  token: 0x6000BAE
        public virtual System.Void Execute() { }
        // RVA: 0x026DF7F0  token: 0x6000BAF
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& unitQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& liquidQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& pumpQr, System.Boolean resetQr) { }

    }

    // TypeToken: 0x200021E  // size: 0x20
    public sealed struct UpdateUnitRendererTRSJob : Unity.Jobs.IJobParallelForBatch, Unity.Jobs.IJobParallelForDefer
    {
        // Fields
        private UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer* m_qr;  // 0x10
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x18

        // Methods
        // RVA: 0x057C83F0  token: 0x6000BB0
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C85B0  token: 0x6000BB1
        private System.Void _Transform(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.LocalToWorld& localToWorld, Beyond.Gameplay.Factory.SharedDataFragment& sharedData) { }
        // RVA: 0x057C8364  token: 0x6000BB2
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }
        // RVA: 0x02BBA870  token: 0x6000BB3
        public System.Void SetSharedExtData(System.IntPtr data) { }
        // RVA: 0x02BBA8B0  token: 0x6000BB4
        public System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data) { }
        // RVA: 0x02BBAE70  token: 0x6000BB5
        public Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount) { }

    }

    // TypeToken: 0x200021F  // size: 0xA8
    public sealed struct WireCollectJob : Unity.Jobs.IJob
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x30
        public Beyond.Gameplay.Factory.GlobalEnv* env;  // 0x40
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x48
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* normalRenderers;  // 0x50
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* hsNormalRenderers;  // 0x58
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* hsStrengthenRenderers;  // 0x60
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* strengthenRenderers;  // 0x68
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* disableRenderers;  // 0x70
        public Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>* strengthenDisableRenderers;  // 0x78
        public Unity.Collections.FixedString32Bytes factoryPowerPoleMountPoint;  // 0x80
        public System.Single wireCullDistance;  // 0xa0

        // Methods
        // RVA: 0x057C8664  token: 0x6000BB6
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057BF460  token: 0x6000BB7
        private System.Boolean _IsNormalConnection(Beyond.GEnums.FacBuildingState state) { }
        // RVA: 0x057BF450  token: 0x6000BB8
        private System.Boolean _IsDisabledConnection(Beyond.GEnums.FacBuildingState state) { }
        // RVA: 0x057C8C9C  token: 0x6000BB9
        public virtual System.Void Execute() { }
        // RVA: 0x02765640  token: 0x6000BBA
        public System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef) { }
        // RVA: 0x02765680  token: 0x6000BBB
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x2000220  // size: 0x38
    public sealed struct WireRenderJob : Unity.Jobs.IJobParallelForBatch
    {
        // Fields
        public System.IntPtr dataMatrices;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityManager em;  // 0x18
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> rendererEntities;  // 0x28

        // Methods
        // RVA: 0x057C8DD4  token: 0x6000BBC
        public System.Void Execute(System.Int32 index) { }
        // RVA: 0x057C8ED0  token: 0x6000BBD
        private System.Void _UpdateCachedWire(UnityEngine.HyperGryph.ECS.Entity cachedEntity, Beyond.Gameplay.Factory.WireRendererInfo arg) { }
        // RVA: 0x057C8D48  token: 0x6000BBE
        public virtual System.Void Execute(System.Int32 startIndex, System.Int32 count) { }

    }

    // TypeToken: 0x2000221  // size: 0x1C
    public sealed struct FactoryBuildingEffectData : Beyond.IEventData
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.Entity buildingLogicEntity;  // 0x10
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType effectType;  // 0x18

    }

    // TypeToken: 0x2000222  // size: 0x28
    public sealed struct FPtrNativeCurve
    {
        // Fields
        private System.Single* m_values;  // 0x10
        private System.Int32 m_valuesLength;  // 0x18
        private UnityEngine.WrapMode m_preWrapMode;  // 0x1c
        private UnityEngine.WrapMode m_postWrapMode;  // 0x20

        // Methods
        // RVA: 0x057BFB5C  token: 0x6000BBF
        public System.Boolean IsValid() { }
        // RVA: 0x033D9B30  token: 0x6000BC0
        public Unity.Collections.NativeArray<System.Single> CreateCurve(UnityEngine.AnimationCurve curve, System.Int32 resolution) { }
        // RVA: 0x057BF9C8  token: 0x6000BC1
        public System.Single Evaluate(System.Single t) { }
        // RVA: 0x04277234  token: 0x6000BC2
        private System.Single _Repeat(System.Single t, System.Single length) { }
        // RVA: 0x042786BC  token: 0x6000BC3
        private System.Single _Pingpong(System.Single t, System.Single length) { }

    }

    // TypeToken: 0x2000223  // size: 0x20
    public sealed struct PerDrawConfigArray
    {
        // Fields
        public static System.Int32 MAX_COUNT;  // const
        public Beyond.Gameplay.Factory.PerDrawConfig[] perDrawConfigArray;  // 0x10
        public Beyond.Gameplay.Factory.PerDrawPassConfig[] passConfigArray;  // 0x18

    }

    // TypeToken: 0x2000224  // size: 0x50
    public sealed struct PerDrawPassConfig
    {
        // Fields
        public System.Boolean enable;  // 0x10
        public System.UInt32 lightModeRaw;  // 0x11

        // Properties
        Beyond.Gameplay.Factory.PerDrawLightMode lightMode { get; /* RVA: 0x03D56660 */ set; /* RVA: 0x03D56670 */ }

        // Methods
        // RVA: 0x057C283C  token: 0x6000BC6
        public System.Int32 Size() { }
        // RVA: 0x057C2714  token: 0x6000BC7
        public System.Void Apply(UnityEngine.HyperGryph.ECS.Entity rendererEntity, System.UInt32& currentLightMode) { }
        // RVA: 0x057C27B8  token: 0x6000BC8
        public System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, System.UInt32& currentLightMode) { }
        // RVA: 0x057C288C  token: 0x6000BC9
        private UnityEngine.HyperGryph.HGShaderLightMode _ParseToHGShaderLightMode(Beyond.Gameplay.Factory.PerDrawLightMode value) { }

    }

    // TypeToken: 0x2000225  // size: 0x4C
    public sealed struct PerDrawConfig
    {
        // Fields
        public Beyond.Gameplay.Factory.PerDrawOffset offset;  // 0x10
        public System.Int32 valueType;  // 0x14
        public Unity.Mathematics.float4 valueRaw;  // 0x18
        private Unity.Mathematics.float4 m_value0;  // 0x28
        private System.Single m_value1;  // 0x38
        private UnityEngine.Color m_value2;  // 0x3c

        // Methods
        // RVA: 0x057C2580  token: 0x6000BCA
        public static System.Int32 Size() { }
        // RVA: 0x032BBE50  token: 0x6000BCB
        public System.Void OnValidate() { }
        // RVA: 0x032BBEA0  token: 0x6000BCC
        private System.Void _OnPerDrawTypeChanged() { }
        // RVA: 0x057C25C4  token: 0x6000BCD
        private System.Void _OnColorChanged(UnityEngine.Color c) { }
        // RVA: 0x057C2634  token: 0x6000BCE
        private System.Void _OnFloat4Changed(Unity.Mathematics.float4 f) { }
        // RVA: 0x057C269C  token: 0x6000BCF
        private System.Void _OnFloatChanged(System.Single f) { }
        // RVA: 0x02421A10  token: 0x6000BD0
        public System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder) { }

    }

    // TypeToken: 0x2000226  // size: 0x14
    public sealed struct LogicEntityState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.LogicEntityState NORMAL;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState INVALID;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState PREVIEW;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState MULTI_SELECT;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState SOLO_SELECT;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState PRE_SELECT;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState WATER_AREA;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState BLUEPRINT_TOBEBUILD;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState BLUEPRINT_TOBEBUILD_SELECT;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState BLUEPRINT_MOVING;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState BLUEPRINT_MOVING_INVALID;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState CONTINUATION;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState DEFAULT;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState SHARING;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState SHARING_INVALID;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState POWER_INTERACTION;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState BLUEPRINT_TOBUILD_INVALID;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState OVERLOAD_INVALID;  // const
        public static Beyond.Gameplay.Factory.LogicEntityState MAX;  // const

    }

    // TypeToken: 0x2000227  // size: 0x20
    public class PerDrawDataOffsetAttribute : System.Attribute
    {
        // Fields
        public System.Type type;  // 0x10
        public System.Int32 typeValue;  // 0x18

        // Methods
        // RVA: 0x03C805B0  token: 0x6000BD1
        public System.Void .ctor(System.Type type, System.Int32 typeValue) { }

    }

    // TypeToken: 0x2000228  // size: 0x14
    public sealed struct LogicEntityType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.LogicEntityType CONVEYOR;  // const
        public static Beyond.Gameplay.Factory.LogicEntityType PIPE;  // const
        public static Beyond.Gameplay.Factory.LogicEntityType BUILDING;  // const
        public static Beyond.Gameplay.Factory.LogicEntityType INDICATOR;  // const
        public static Beyond.Gameplay.Factory.LogicEntityType GRID;  // const
        public static Beyond.Gameplay.Factory.LogicEntityType MAX;  // const

    }

    // TypeToken: 0x2000229  // size: 0x14
    public sealed struct PerDrawOffset
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.PerDrawOffset BASE_COLOR;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset TINT_COLOR;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset FLOW_ALPHA;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset BELT_COLOR_INTENSITY;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset BELT_COLOR_ALPHA;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset GRID_MODE;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset RENDER_ON_WATER;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset BLUEPRINT_NOISE_ALPHA;  // const
        public static Beyond.Gameplay.Factory.PerDrawOffset CONVEYOR_INDICATOR;  // const

    }

    // TypeToken: 0x200022A  // size: 0x14
    public sealed struct PerDrawLightMode
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.PerDrawLightMode None;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode GBuffer;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode GBufferMobile;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode Erosion;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ErosionMobile;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ErosionClear;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ForwardOnly;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode Forward;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ForwardCharacterOnly;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ForwardReflection;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode CharacterOutline;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ShadowCaster;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode DepthOnly;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode DepthCharacterOnly;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode SRPDefaultUnlit;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode ForwardDecal;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode VFXDecal;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode Distortion;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode FullScreenDebug;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode OccludedDisplay;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode TerrainVTDecal;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode TerrainVTDecalMobile;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode RayTracingReflection;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode StencilAlphaBlend;  // const
        public static Beyond.Gameplay.Factory.PerDrawLightMode WaterMarkUI;  // const

    }

    // TypeToken: 0x200022B  // size: 0x10
    public static class PerDrawDataOffset
    {
        // Fields
        public static System.Int32 BASE_COLOR;  // const
        public static System.Int32 EMISSIVE_COLOR;  // const
        public static System.Int32 SOCIAL_SIGN_ICON_INDEX;  // const
        public static System.Int32 CUTOFF_POS_Y;  // const
        public static System.Int32 EMISSIVE_LUT_INDEX;  // const
        public static System.Int32 EMISSIVE_LUT_BIT_MASK;  // const
        public static System.Int32 LIQUID_HEIGHT_INDEX;  // const
        public static System.Int32 FACTORY_COLOR_TYPE;  // const
        public static System.Int32 ENABLE_CUTOFF;  // const
        public static System.Int32 EMISSIVE_ANIMATION_MODE;  // const
        public static System.Int32 LIQUID_COLOR_INDEX;  // const
        public static System.Int32 UI_ATLAS_UV;  // const
        public static System.Int32 UI_LIQUID_ATLAS_UV;  // const
        public static System.Int32 ENABLE_LIQUID_ICON;  // const
        public static System.Int32 RARITY_COLOR;  // const
        public static System.Int32 TINT_COLOR;  // const
        public static System.Int32 INDICATOR_DATA;  // const
        public static System.Int32 DISABLE_ICON_DEPTH_BLEND;  // const
        public static System.Int32 GRID_MODE;  // const
        public static System.Int32 RENDER_ON_WATER;  // const
        public static System.Int32 OVERLOOK;  // const
        public static System.Int32 ARROW_STEP_COUNT;  // const
        public static System.Int32 SIMPLE_DRAWING_TYPE;  // const
        public static System.Int32 TIME_OFFSET;  // const
        public static System.Int32 ARROW_UV_SPEED;  // const
        public static System.Int32 ENABLE_CONVEYOR_INDICATOR;  // const
        public static System.Int32 ARROW_DATA;  // const
        public static System.Int32 BELT_COLOR;  // const
        public static System.Int32 FLOW_INTENSITY;  // const
        public static System.Int32 BELT_COLOR_INTENSITY;  // const
        public static System.Int32 BELT_COLOR_ALPHA;  // const
        public static System.Int32 ELECTRIC_WIRE_ALPHA;  // const
        public static System.Int32 VFX_TINT_COLOR_ALPHA;  // const
        public static System.Int32 ELECTRIC_WIRE_LENGTH;  // const
        public static System.Int32 WATER_THICKNESS;  // const
        public static System.Int32 WATER_DELTA_TIME;  // const
        public static System.Int32 TUBE_INDEX;  // const
        public static System.Int32 TUBE_COUNT;  // const
        public static System.Int32 WATER_DIRECTION;  // const
        public static System.Int32 ENABLE_OVERLOOK_ARROW;  // const
        public static System.Int32 TUBE_BEND_X_DEGREE;  // const
        public static System.Int32 TUBE_BEND_TAG;  // const
        public static System.Int32 GLASS_COLOR;  // const
        public static System.Int32 ATLAS_UV_INDEX;  // const
        public static System.Int32 ENABLE_TUBE_INDICATOR;  // const
        public static System.Int32 DITHER_TRANSPARENT_ALPHA;  // const
        public static System.Int32 BLUEPRINT_NOISE_ALPHA;  // const
        public static System.Int32 FACTORY_VAT_FRAME;  // const
        public static System.Int32 FACTORY_VAT_LAST_FRAME;  // const

    }

    // TypeToken: 0x200022C  // size: 0x10
    public class ProcessorInterval
    {
        // Methods
        // RVA: 0x0230D4A0  token: 0x6000BD2
        public static System.Boolean CheckInterval(Beyond.Gameplay.Factory.IProcessor& processor, System.Single delta, System.Single rate) { }
        // RVA: 0x0230D810  token: 0x6000BD3
        private static System.Boolean _CheckInterval(System.Single frameInterval, System.Single intervalSetting, System.Single& curInterval, System.Single delta, System.Single rate) { }
        // RVA: 0x0350B670  token: 0x6000BD4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200022D  // size: 0x20
    public class CargoPredictProcessor : Beyond.Gameplay.Factory.BaseProcessor
    {
        // Properties
        System.Boolean lowFrameEnable { get; /* RVA: 0x0232EB60 */ }
        System.String name { get; /* RVA: 0x057BF85C */ }

        // Methods
        // RVA: 0x026DE520  token: 0x6000BD5
        public virtual Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: 0x03D561E0  token: 0x6000BD8
        public System.Void .ctor() { }
        // RVA: 0x057BF7B0  token: 0x6000BD9
        public Unity.Jobs.JobHandle <>iFixBaseProxy_Execute(UnityEngine.HyperGryph.ECS.EntityManager& P0, System.Int64 P1, System.Int64 P2, System.Single P3, System.Int32 P4, System.Int32 P5, System.Int32 P6, Beyond.Gameplay.Factory.GlobalEnv& P7, Unity.Jobs.JobHandle P8, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P9) { }

    }

    // TypeToken: 0x200022E  // size: 0x148
    public class CrossFrameProcessor : Beyond.Gameplay.Factory.BaseProcessor
    {
        // Fields
        private Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo m_nearBuildingInfo;  // 0x20
        private Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo m_nearConveyorInfo;  // 0x74
        private Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo m_nearPipeInfo;  // 0x94
        private Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo m_nearBuildingInfoLast;  // 0xb4
        private Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo m_nearConveyorInfoLast;  // 0x108
        private Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo m_nearPipeInfoLast;  // 0x128
        private static System.Single MAX_BUILDING_INTERACT_RADIUS;  // const
        private static System.Single BUILDING_INTERACT_RADIUS_EXPAND;  // const

        // Properties
        System.String name { get; /* RVA: 0x057BF99C */ }
        System.Boolean lowFrameEnable { get; /* RVA: 0x0115F4C0 */ }

        // Methods
        // RVA: 0x03B290B0  token: 0x6000BDA
        public virtual System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting) { }
        // RVA: 0x026E8330  token: 0x6000BDB
        public virtual Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x057BF888  token: 0x6000BDC
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x03D561E0  token: 0x6000BDF
        public System.Void .ctor() { }
        // RVA: 0x057BF920  token: 0x6000BE0
        public System.Void <>iFixBaseProxy_Initialize(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Beyond.Gameplay.FactorySetting P2) { }
        // RVA: 0x057BF930  token: 0x6000BE1
        public Unity.Jobs.JobHandle <>iFixBaseProxy_LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, Unity.Jobs.JobHandle P5) { }
        // RVA: 0x057BF994  token: 0x6000BE2
        public System.Void <>iFixBaseProxy_TearDown(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }

    }

    // TypeToken: 0x200022F
    public abstract class EntityDestroyReactiveProcessor`1 : Beyond.Gameplay.Factory.ReactiveProcessor`1
    {
        // Fields
        private Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.Entity> m_removedEntities;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BE3
        public virtual System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting) { }
        // RVA: -1  // not resolved  token: 0x6000BE4
        public virtual System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook) { }
        // RVA: -1  // not resolved  token: 0x6000BE5
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: -1  // not resolved  token: 0x6000BE6
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000230  // size: 0x7E4228
    public class FacRendererCollectProcessor : Beyond.Gameplay.Factory.BaseProcessor
    {
        // Fields
        public static System.Boolean s_statusRenderEnabled;  // static @ 0x0
        public static System.Boolean s_portStatusRenderEnabled;  // static @ 0x1
        private System.Single m_conveyorOffsetY;  // 0x20
        private System.Single m_conveyorPortBlockOffsetY;  // 0x24
        private System.Single m_pipePortBlockOffsetY;  // 0x28
        private Unity.Mathematics.float4 m_portForbiddenColor;  // 0x2c
        private Unity.Mathematics.float4 m_portEvaluatedColor;  // 0x3c
        private Unity.Mathematics.float4 m_portNormalColor;  // 0x4c
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* m_portBlockPosList;  // 0x60
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.OutputRendererInfo>* m_outputPosList;  // 0x68
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* m_buildingStatePosList;  // 0x70
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorLPosList0;  // 0x78
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorMPosList0;  // 0x40080
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorRPosList0;  // 0x80088
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorLPosList1;  // 0xc0090
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorMPosList1;  // 0x100098
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorRPosList1;  // 0x1400a0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorPreviewLPosList0;  // 0x1800a8
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorPreviewMPosList0;  // 0x1c00b0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorPreviewRPosList0;  // 0x2000b8
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorPreviewLPosList1;  // 0x2400c0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorPreviewMPosList1;  // 0x2800c8
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorPreviewRPosList1;  // 0x2c00d0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorGuideLPosList0;  // 0x3000d8
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorGuideMPosList0;  // 0x3400e0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorGuideRPosList0;  // 0x3800e8
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorGuideLPosList1;  // 0x3c00f0
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorGuideMPosList1;  // 0x4000f8
        private Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo> m_conveyorGuideRPosList1;  // 0x440100
        private Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo> m_cargoList0;  // 0x480108
        private Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo> m_cargoList1;  // 0x4c8110
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo> m_pipeLPosList0;  // 0x510118
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo> m_pipeMPosList0;  // 0x570120
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo> m_pipeRPosList0;  // 0x5d0128
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo> m_pipeLPosList1;  // 0x630130
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo> m_pipeMPosList1;  // 0x690138
        private Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo> m_pipeRPosList1;  // 0x6f0140
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo> m_trackLPosList0;  // 0x750148
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo> m_trackMPosList0;  // 0x752150
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo> m_trackRPosList0;  // 0x754158
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo> m_trackLPosList1;  // 0x756160
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo> m_trackMPosList1;  // 0x758168
        private Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo> m_trackRPosList1;  // 0x75a170
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireNormalList0;  // 0x75c178
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireNormalList1;  // 0x762180
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireHsNormalList0;  // 0x768188
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireHsNormalList1;  // 0x76e190
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireDisableList0;  // 0x774198
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireDisableList1;  // 0x77a1a0
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireStrengthenList0;  // 0x7801a8
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireStrengthenList1;  // 0x7861b0
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireHsStrengthenList0;  // 0x78c1b8
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireHsStrengthenList1;  // 0x7921c0
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireStrengthenDisableList0;  // 0x7981c8
        private Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo> m_wireStrengthenDisableList1;  // 0x79e1d0
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Matrix4x4>* m_pipeHolderPosList;  // 0x7a41d8
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* m_comPosList;  // 0x7a41e0
        private Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo> m_portArrowList0;  // 0x7a41e8
        private Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo> m_portArrowList1;  // 0x7c41f0
        private Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>* m_conveyorInsideMatrices;  // 0x7e41f8
        private Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> m_facRegionPosValidFuncPtr;  // 0x7e4200
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPathFuncPtr;  // 0x7e4208
        private System.Int32 m_lowFrameInterval;  // 0x7e4210
        private Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Boolean> m_arrowPlacedDic;  // 0x7e4218

        // Properties
        System.String name { get; /* RVA: 0x057C060C */ }

        // Methods
        // RVA: 0x026DDD60  token: 0x6000BE7
        private Unity.Jobs.JobHandle _CollectConveyor(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& conveyorCollectJobHandle) { }
        // RVA: 0x026DD450  token: 0x6000BE8
        private Unity.Jobs.JobHandle _CollectPreviewConveyor(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& conveyorPreviewCollectJobHandle) { }
        // RVA: 0x026DDFF0  token: 0x6000BE9
        private Unity.Jobs.JobHandle _CollectGuideConveyor(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& conveyorCollectJobHandle) { }
        // RVA: 0x03280BC0  token: 0x6000BEB
        public virtual System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting) { }
        // RVA: 0x03280FE0  token: 0x6000BEC
        private System.Void _CreateAllocator(Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x03280830  token: 0x6000BED
        private System.Void _CreateCurrent(Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x026DC270  token: 0x6000BEE
        private Unity.Jobs.JobHandle _CollectPortState(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& portCollectJobHandle) { }
        // RVA: 0x026DBF10  token: 0x6000BEF
        private Unity.Jobs.JobHandle _CollectBuildingState(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& buildingStateCollectJobHandle) { }
        // RVA: 0x026DD180  token: 0x6000BF0
        private Unity.Jobs.JobHandle _CollectOutput(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& outputCollectJobHandle) { }
        // RVA: 0x026DE280  token: 0x6000BF1
        private Unity.Jobs.JobHandle _CollectCargo(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& cargoCollectJobHandle) { }
        // RVA: 0x027656C0  token: 0x6000BF2
        private Unity.Jobs.JobHandle _CollectWire(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& wireCollectJobHandle) { }
        // RVA: 0x026DD6F0  token: 0x6000BF3
        public virtual Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x057BFBAC  token: 0x6000BF4
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x026DC5A0  token: 0x6000BF5
        private Unity.Jobs.JobHandle _CollectPipe(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& pipeCollectJobHandle) { }
        // RVA: 0x026DDB30  token: 0x6000BF6
        private Unity.Jobs.JobHandle _CollectPipeLogistics(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& pipeHolderCollectJobHandle) { }
        // RVA: 0x03281200  token: 0x6000BF7
        private System.Void _InitArrowPlaced(Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x026DCA40  token: 0x6000BF8
        private Unity.Jobs.JobHandle _CollectPortArrow(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& portArrowCollectJobHandle) { }
        // RVA: 0x057BFD48  token: 0x6000BF9
        private Unity.Jobs.JobHandle _CollectPortArrowWithDiff(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& portArrowCollectJobHandle) { }
        // RVA: 0x03D56640  token: 0x6000BFA
        public System.Void .ctor() { }
        // RVA: 0x03D2C4E0  token: 0x6000BFB
        private static System.Void .cctor() { }
        // RVA: 0x057BF920  token: 0x6000BFC
        public System.Void <>iFixBaseProxy_Initialize(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Beyond.Gameplay.FactorySetting P2) { }
        // RVA: 0x057BF930  token: 0x6000BFD
        public Unity.Jobs.JobHandle <>iFixBaseProxy_LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, Unity.Jobs.JobHandle P5) { }
        // RVA: 0x057BF994  token: 0x6000BFE
        public System.Void <>iFixBaseProxy_TearDown(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }

    }

    // TypeToken: 0x2000231
    public abstract class ReactiveProcessor`1 : Beyond.Gameplay.Factory.BaseProcessor
    {
        // Fields
        private readonly System.String <name>k__BackingField;  // 0x0

        // Properties
        System.String name { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000BFF
        public virtual Unity.Jobs.JobHandle PreExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: -1  // not resolved  token: 0x6000C00
        public virtual Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: -1  // not resolved  token: 0x6000C01
        protected virtual System.Void Perform(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& ecb, UnityEngine.HyperGryph.ECS.ECSSpan<T>& dataSpans, Beyond.Gameplay.Factory.GlobalEnv& env, UnityEngine.HyperGryph.ECS.GroupType group, System.Int64 time) { }
        // RVA: -1  // not resolved  token: 0x6000C02
        protected virtual System.Boolean CleanUpEntityFilter(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // not resolved  token: 0x6000C03
        public virtual System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook) { }
        // RVA: -1  // not resolved  token: 0x6000C04
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: -1  // not resolved  token: 0x6000C06
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000232  // size: 0x10
    public class AdditiveMaterialBitIndex
    {
        // Fields
        public static readonly System.Int32 PREVIEW;  // static @ 0x0
        public static readonly System.Int32 HIGHLIGHT;  // static @ 0x4
        public static readonly System.Int32 OUTLINE;  // static @ 0x8
        public static readonly System.Int32 CUTOFF;  // static @ 0xc
        public static readonly System.Int32 PRECESS;  // static @ 0x10
        public static readonly System.Int32 REPAIR1;  // static @ 0x14
        public static readonly System.Int32 REPAIR2;  // static @ 0x18
        public static readonly System.Int32 REPAIR3;  // static @ 0x1c
        public static readonly System.Int32 OVERLOAD;  // static @ 0x20
        public static readonly System.Int32 BLUEPRINT_BUILD;  // static @ 0x24
        public static readonly System.Int32 BLUEPRINT_MOVE;  // static @ 0x28
        public static readonly System.Int32 BLUEPRINT_BUILD_OUTLINE;  // static @ 0x2c
        public static readonly System.Int32 BLUEPRINT_MOVE_OUTLINE;  // static @ 0x30
        public static readonly System.Int32 PRESELECT_PREVIEW;  // static @ 0x34
        public static readonly System.Int32 SOCIAL_SHARING;  // static @ 0x38
        public static readonly System.Int32 POWER_INTERACTION;  // static @ 0x3c
        public static readonly System.Int32 MAX;  // static @ 0x40

        // Methods
        // RVA: 0x0350B670  token: 0x6000C07
        public System.Void .ctor() { }
        // RVA: 0x03CC46F0  token: 0x6000C08
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000233  // size: 0x30
    public class FactoryBaseColorLutConfig : UnityEngine.ScriptableObject
    {
        // Fields
        public Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.FacBuildingBaseBuffer,UnityEngine.Color> factoryBuildingBaseStateConfig;  // 0x18
        public Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.BuildAndMode,System.Int32> factoryBuildingCrafterData;  // 0x20
        public System.Int32 factoryBuildingCount;  // 0x28

        // Methods
        // RVA: 0x057FD538  token: 0x6000C09
        public System.Boolean GetColor(System.Int32 sort, UnityEngine.Color& col) { }
        // RVA: 0x03214600  token: 0x6000C0A
        public System.Boolean GetIndex(System.String id, System.String group, System.Int32& index) { }
        // RVA: 0x057FD418  token: 0x6000C0B
        public static Beyond.Gameplay.Factory.FactoryBaseColorLutConfig CreateOrGet(System.String path) { }
        // RVA: 0x0286F540  token: 0x6000C0C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000234  // size: 0x14
    public sealed struct FacBuildingBaseBuffer
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.FacBuildingBaseBuffer InputBuffer1;  // const
        public static Beyond.Gameplay.Factory.FacBuildingBaseBuffer InputBuffer2;  // const
        public static Beyond.Gameplay.Factory.FacBuildingBaseBuffer InputBuffer3;  // const
        public static Beyond.Gameplay.Factory.FacBuildingBaseBuffer OutputBuffer1;  // const
        public static Beyond.Gameplay.Factory.FacBuildingBaseBuffer OutputBuffer2;  // const
        public static Beyond.Gameplay.Factory.FacBuildingBaseBuffer OutputBuffer3;  // const

    }

    // TypeToken: 0x2000235  // size: 0x20
    public sealed struct BuildAndMode
    {
        // Fields
        public System.String build;  // 0x10
        public System.String mode;  // 0x18

    }

    // TypeToken: 0x2000236  // size: 0x30
    public sealed struct FFactoryStateColorConfig
    {
        // Fields
        public Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,UnityEngine.Color> factoryStateIconColorConfig;  // 0x10
        public Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,UnityEngine.Color> factoryIndicatorColorConfig;  // 0x18
        public Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,System.String> factoryUIEffectConfig;  // 0x20
        public Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityState,Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityType,Beyond.Gameplay.Factory.PerDrawConfigArray>> factoryLogicEntityColorConfig2;  // 0x28

        // Methods
        // RVA: 0x0327F620  token: 0x6000C0D
        public System.Boolean GetStateColor(Beyond.GEnums.FacBuildingState enumKey, UnityEngine.Color& col) { }
        // RVA: 0x057FC5F8  token: 0x6000C0E
        public System.Boolean GetIndicatorColor(Beyond.GEnums.FacBuildingState enumKey, UnityEngine.Color& col) { }
        // RVA: 0x057FC698  token: 0x6000C0F
        public System.Boolean GetStateName(Beyond.GEnums.FacBuildingState enumKey, System.String& name) { }
        // RVA: 0x0327EBA0  token: 0x6000C10
        public System.Boolean GetPerDrawList(Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType, Beyond.Gameplay.Factory.PerDrawConfigArray& perDrawList) { }
        // RVA: 0x032BB450  token: 0x6000C11
        public System.Void OnEnable() { }

    }

}

namespace Beyond.Gameplay.Factory.ECSVATFSM
{

    // TypeToken: 0x2000238  // size: 0x88
    public sealed struct VATFSMStateFragment : UnityEngine.HyperGryph.ECS.IComponentECS
    {
        // Fields
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMState currentState;  // 0x10
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMState nextState;  // 0x2c
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet parameters;  // 0x48
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition transition;  // 0x6c
        public System.Single speed;  // 0x78
        public System.UInt32 definitionHandle;  // 0x7c
        public System.UInt32 binderSharedDataIndex;  // 0x80
        public System.Boolean isTransitioning;  // 0x84
        public System.Boolean isPause;  // 0x85
        public static System.Int32 ID;  // const

        // Properties
        Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& def { get; /* RVA: 0x04271798 */ }
        System.Int32 id { get; /* RVA: 0x03D566A0 */ }

        // Methods
        // RVA: 0x027637A0  token: 0x6000C14
        public System.Void Init(System.UInt32 defHandle, System.UInt32 binderHandle) { }
        // RVA: 0x05802664  token: 0x6000C15
        public System.Void SetState(Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& stateDef) { }
        // RVA: 0x0580279C  token: 0x6000C16
        public System.Void ToNextState() { }
        // RVA: 0x05802704  token: 0x6000C17
        public System.Void SetTransition(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& transDef, Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& nextStateDef) { }
        // RVA: 0x0580283C  token: 0x6000C19
        private System.Void __AOT_FOR_FIX__() { }

    }

    // TypeToken: 0x2000239  // size: 0x2C
    public sealed struct FSMState
    {
        // Fields
        public System.Byte index;  // 0x10
        public System.Single duration;  // 0x14
        public System.Single speed;  // 0x18
        public System.Boolean isLoop;  // 0x1c
        public System.UInt32 prevFrame;  // 0x20
        private System.Single m_elapsedTime;  // 0x24
        private System.Boolean m_isFinish;  // 0x28

        // Properties
        System.Single process { get; /* RVA: 0x057FD1D8 */ }
        System.Boolean isFinished { get; /* RVA: 0x01002A50 */ }

        // Methods
        // RVA: 0x027638A0  token: 0x6000C1C
        public System.Void Enter() { }
        // RVA: 0x057FD144  token: 0x6000C1D
        public System.Void Update(System.Single deltaTime, System.Single fsmSpeed) { }
        // RVA: 0x057FD094  token: 0x6000C1E
        public System.Void Exit() { }
        // RVA: 0x057FD0D8  token: 0x6000C1F
        public System.Void SetProgress(System.Single normalized) { }

    }

    // TypeToken: 0x200023A  // size: 0x1C
    public sealed struct FSMTransition
    {
        // Fields
        public System.Single duration;  // 0x10
        private System.Single m_elapsedTime;  // 0x14
        private System.Boolean m_isFinish;  // 0x18

        // Properties
        System.Boolean isFinished { get; /* RVA: 0x057FD3F0 */ }
        System.Single fromStateWeight { get; /* RVA: 0x057FD370 */ }
        System.Single toStateWeight { get; /* RVA: 0x057FD3F8 */ }

        // Methods
        // RVA: 0x057FD254  token: 0x6000C23
        public System.Void Enter() { }
        // RVA: 0x057FD2E8  token: 0x6000C24
        public System.Void Update(System.Single deltaTime, System.Single fsmSpeed) { }
        // RVA: 0x057FD2A4  token: 0x6000C25
        public System.Void Exit() { }

    }

    // TypeToken: 0x200023B  // size: 0x32
    public sealed struct FSMParameterSet
    {
        // Fields
        public Unity.Collections.FixedList32Bytes<System.Single> floats;  // 0x10
        public System.Byte bools;  // 0x30
        public System.Byte triggers;  // 0x31

        // Methods
        // RVA: 0x057FCA24  token: 0x6000C26
        public System.Single GetFloat(System.Byte index) { }
        // RVA: 0x057FCDE4  token: 0x6000C27
        public System.Void SetFloat(System.Byte index, System.Single value) { }
        // RVA: 0x057FCAC8  token: 0x6000C28
        public System.Int32 GetInt(System.Byte index) { }
        // RVA: 0x057FCE7C  token: 0x6000C29
        public System.Void SetInt(System.Byte index, System.Int32 value) { }
        // RVA: 0x057FC9C4  token: 0x6000C2A
        public System.Boolean GetBool(System.Byte index) { }
        // RVA: 0x057FCD60  token: 0x6000C2B
        public System.Void SetBool(System.Byte index, System.Boolean value) { }
        // RVA: 0x057FCB74  token: 0x6000C2C
        public System.Boolean GetTrigger(System.Byte index) { }
        // RVA: 0x057FCF18  token: 0x6000C2D
        public System.Void SetTrigger(System.Byte index) { }
        // RVA: 0x057FCCF8  token: 0x6000C2E
        public System.Void ResetTrigger(System.Byte index) { }
        // RVA: 0x057FCCAC  token: 0x6000C2F
        public System.Void ResetAllTriggers() { }
        // RVA: 0x057FCF80  token: 0x6000C30
        public System.Void SetValue(System.Byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type, System.Single value) { }
        // RVA: 0x057FCBD4  token: 0x6000C31
        public System.Single GetValue(System.Byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type) { }
        // RVA: 0x02763530  token: 0x6000C32
        public System.Void ResetParametersByDef(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& def) { }

    }

    // TypeToken: 0x200023C  // size: 0x40
    public sealed struct VATFSMSetParamRequestHandlerJob : Unity.Jobs.IJobFor
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityManager renderEm;  // 0x10
        public Unity.Collections.NativeArray.ReadOnly<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest> setParamRequestList;  // 0x20
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition* sharedDataPtr;  // 0x30
        public Beyond.Gameplay.Factory.GlobalEnv* envPtr;  // 0x38

        // Methods
        // RVA: 0x05802520  token: 0x6000C33
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200023D  // size: 0x50
    public sealed struct VATFSMStateUpdateJob : Unity.Jobs.IJobFor
    {
        // Fields
        public System.Single deltaTime;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr;  // 0x18
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition* fsmDefinitionPtr;  // 0x38
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr;  // 0x40
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData> animatorAudioQueue;  // 0x48
        private static System.Int32 S_CURRENT_FRAME_OFFSET;  // const
        private static System.Int32 S_PREVIOUS_FRAME_OFFSET;  // const

        // Methods
        // RVA: 0x05802C5C  token: 0x6000C34
        public System.Void Execute() { }
        // RVA: 0x05802978  token: 0x6000C35
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x05802DD0  token: 0x6000C36
        private System.Boolean _CheckTransitions(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& fsm, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& fsmDef) { }
        // RVA: 0x05802F08  token: 0x6000C37
        private System.Void _ComputeVATFrameData(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& state, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& fsmDef) { }
        // RVA: 0x05802CE4  token: 0x6000C38
        private System.Void _AddVATAudioData(UnityEngine.HyperGryph.ECS.Entity renderEntity, Beyond.Gameplay.Factory.ECSVATFSM.FSMState& newState, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& fsmDef) { }
        // RVA: 0x026DF570  token: 0x6000C39
        public System.Void SetSharedExtData(System.IntPtr data) { }

    }

    // TypeToken: 0x200023E  // size: 0x40
    public class VATFSMProcessor : Beyond.Gameplay.Factory.BaseProcessor
    {
        // Fields
        public Unity.Collections.NativeList<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest> animatorParamRequestQueue;  // 0x20
        private Unity.Collections.NativeParallelHashMap<UnityEngine.HyperGryph.ECS.Entity,System.Int32> m_requestMaskPerEntity;  // 0x30

        // Properties
        System.String name { get; /* RVA: 0x058024F4 */ }
        Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition* fsmDefinitionPtr { get; /* RVA: 0x026DEF20 */ }

        // Methods
        // RVA: 0x039B4770  token: 0x6000C3C
        public virtual System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting) { }
        // RVA: 0x026DE9E0  token: 0x6000C3D
        public virtual Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 deltaTime, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies) { }
        // RVA: 0x058023CC  token: 0x6000C3E
        public virtual System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x024FD6F0  token: 0x6000C3F
        private Unity.Jobs.JobHandle _HandleSetAnimatorParamRequest(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x024FDE30  token: 0x6000C40
        private System.Void _RemoveDuplicationRequest(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x03D561E0  token: 0x6000C41
        public System.Void .ctor() { }
        // RVA: 0x057BF920  token: 0x6000C42
        public System.Void <>iFixBaseProxy_Initialize(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Beyond.Gameplay.FactorySetting P2) { }
        // RVA: 0x057BF7B0  token: 0x6000C43
        public Unity.Jobs.JobHandle <>iFixBaseProxy_Execute(UnityEngine.HyperGryph.ECS.EntityManager& P0, System.Int64 P1, System.Int64 P2, System.Single P3, System.Int32 P4, System.Int32 P5, System.Int32 P6, Beyond.Gameplay.Factory.GlobalEnv& P7, Unity.Jobs.JobHandle P8, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P9) { }
        // RVA: 0x057BF994  token: 0x6000C44
        public System.Void <>iFixBaseProxy_TearDown(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }

    }

    // TypeToken: 0x2000242  // size: 0x40
    public class ECSVATFSMDefinitionData
    {
        // Fields
        public System.String fsmName;  // 0x10
        public System.String defaultStateName;  // 0x18
        public System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.StateData> states;  // 0x20
        public System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.TransitionData> transitions;  // 0x28
        public System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.ParameterData> parameters;  // 0x30
        public System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.AnimationClipData> animationClips;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000C46
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000243  // size: 0x28
    public class StateData
    {
        // Fields
        public System.String name;  // 0x10
        public System.Single speed;  // 0x18
        public System.String clipName;  // 0x20

        // Methods
        // RVA: 0x03D561E0  token: 0x6000C47
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000244  // size: 0x14
    public sealed struct TransitionInterruptionSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource None;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource Source;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource Destination;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource SourceThenDestination;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource DestinationThenSource;  // const

    }

    // TypeToken: 0x2000245  // size: 0x38
    public class TransitionData
    {
        // Fields
        public System.String fromState;  // 0x10
        public System.String toState;  // 0x18
        public System.Single exitTime;  // 0x20
        public System.Single duration;  // 0x24
        public Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource interruptionSource;  // 0x28
        public System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.ConditionData> condition;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x6000C48
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000246  // size: 0x14
    public sealed struct AnimatorConditionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode If;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode IfNot;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode Greater;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode Less;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode Equals;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode NotEqual;  // const

    }

    // TypeToken: 0x2000247  // size: 0x20
    public class ConditionData
    {
        // Fields
        public System.String parameterName;  // 0x10
        public Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode comparison;  // 0x18
        public System.Single threshold;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x6000C49
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000248  // size: 0x28
    public class ParameterData
    {
        // Fields
        public System.String name;  // 0x10
        public UnityEngine.AnimatorControllerParameterType type;  // 0x18
        public System.Single defaultFloat;  // 0x1c
        public System.Int32 defaultInt;  // 0x20
        public System.Boolean defaultBool;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x6000C4A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000249  // size: 0x28
    public class AnimationClipData
    {
        // Fields
        public System.String name;  // 0x10
        public System.Boolean isLoop;  // 0x18
        public System.Single length;  // 0x1c
        public System.Int32 startFrame;  // 0x20
        public System.Int32 totalFrames;  // 0x24

        // Methods
        // RVA: 0x057FA4EC  token: 0x6000C4B
        public System.String GetClipDesStr() { }
        // RVA: 0x0350B670  token: 0x6000C4C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200024A  // size: 0xA9C
    public sealed struct VATFSMDefinition
    {
        // Fields
        public System.Byte defaultStateIndex;  // 0x10
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition> states;  // 0x12
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20<Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition> transitions;  // 0x214
        public Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition> parameters;  // 0xa1c

    }

    // TypeToken: 0x200024B  // size: 0x11
    public sealed struct ConditionMode
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode If;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode IfNot;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode Greater;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode Less;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode Equals;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode NotEqual;  // const

    }

    // TypeToken: 0x200024C  // size: 0x18
    public sealed struct FSMCondition
    {
        // Fields
        public System.Byte parameterIndex;  // 0x10
        public Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode comparison;  // 0x11
        public System.Single threshold;  // 0x14

    }

    // TypeToken: 0x200024D
    public sealed struct FSMTransitionDefinition20`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public static System.Int32 T_SIZE;  // const
        public static System.Int32 CAPACITY;  // const
        public static System.Int32 CAPACITY_MINUS_ONE;  // const
        public static System.Int32 INVALID_INDEX;  // const
        private System.Int32 m_beginIndex;  // 0x0
        private System.Int32 m_endIndex;  // 0x0
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20.<data>e__FixedBuffer<T> data;  // 0x0

        // Properties
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Boolean ring { get; /* RVA: -1  // not resolved */ }
        System.Int32 beginIndex { get; /* RVA: -1  // not resolved */ }
        System.Int32 endIndex { get; /* RVA: -1  // not resolved */ }
        System.Boolean isEmpty { get; /* RVA: -1  // not resolved */ }
        T& Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C51
        public System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend) { }
        // RVA: -1  // not resolved  token: 0x6000C52
        public System.Byte* GetPtr() { }
        // RVA: -1  // not resolved  token: 0x6000C53
        public System.IntPtr GetDataAsIntPtr() { }
        // RVA: -1  // not resolved  token: 0x6000C54
        public System.Int32 Enqueue(T value) { }
        // RVA: -1  // not resolved  token: 0x6000C55
        public T Dequeue() { }
        // RVA: -1  // not resolved  token: 0x6000C56
        public System.Int32 Unshift(T value) { }
        // RVA: -1  // not resolved  token: 0x6000C57
        public T Shift() { }
        // RVA: -1  // not resolved  token: 0x6000C58
        public System.Int32 Push(T value) { }
        // RVA: -1  // not resolved  token: 0x6000C59
        public T Pop() { }
        // RVA: -1  // not resolved  token: 0x6000C5A
        public T First() { }
        // RVA: -1  // not resolved  token: 0x6000C5B
        public T Last() { }
        // RVA: -1  // not resolved  token: 0x6000C5C
        public System.Void InsertAt(System.Int32 index, T value) { }
        // RVA: -1  // not resolved  token: 0x6000C5D
        public T RemoveAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000C5E
        public System.Int32 Find(T value) { }
        // RVA: -1  // not resolved  token: 0x6000C60
        public System.Void Extend(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000C61
        public System.Void Extend() { }
        // RVA: -1  // not resolved  token: 0x6000C62
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x6000C63
        public Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20.Enumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C64
        private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C65
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000C67
        public T* GetElementAt(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000C68
        public T GetValue(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000C69
        public T GetValueWithGlobalIndex(System.Int32 globalIndex) { }

    }

    // TypeToken: 0x2000250  // size: 0x50
    public sealed struct FSMTransitionDefinition
    {
        // Fields
        public System.Byte fromStateIndex;  // 0x10
        public System.Byte toStateIndex;  // 0x11
        public System.Single exitTime;  // 0x12
        public System.Single duration;  // 0x16
        public Unity.Collections.FixedList32Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition> conditions;  // 0x1a

    }

    // TypeToken: 0x2000251  // size: 0x11
    public sealed struct ParameterType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.Factory.ECSVATFSM.ParameterType Float;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ParameterType Int;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ParameterType Bool;  // const
        public static Beyond.Gameplay.Factory.ECSVATFSM.ParameterType Trigger;  // const

    }

    // TypeToken: 0x2000252  // size: 0x1C
    public sealed struct FSMParameterDefinition
    {
        // Fields
        public System.Int32 nameHash;  // 0x10
        public Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type;  // 0x14
        public System.Byte index;  // 0x15
        public System.Single defaultFloat;  // 0x18
        public System.Int32 defaultInt;  // 0x18
        public System.Byte defaultBool;  // 0x18

    }

    // TypeToken: 0x2000253  // size: 0x2C
    public sealed struct FSMStateDefinition
    {
        // Fields
        public System.Int32 nameHash;  // 0x10
        public System.Single length;  // 0x14
        public System.Single speed;  // 0x18
        public System.Int32 clipNameHash;  // 0x1c
        public System.UInt32 startFrame;  // 0x20
        public System.UInt32 totalFrames;  // 0x24
        public System.Byte index;  // 0x28
        public System.Boolean isLoop;  // 0x29

    }

    // TypeToken: 0x2000254  // size: 0x28
    public sealed struct VATFSMDefinitionContainer
    {
        // Fields
        public static System.Int32 INVALID_INDEX;  // const
        private Beyond.HGArray<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer.Node> m_nodes;  // 0x10

        // Properties
        Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& Item { get; /* RVA: 0x05801D18 */ }
        Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& Item { get; /* RVA: 0x05801D18 */ }

        // Methods
        // RVA: 0x02C34910  token: 0x6000C70
        public System.Void .ctor(Unity.Collections.Allocator allocator) { }
        // RVA: 0x05801AF8  token: 0x6000C71
        public System.Void Dispose() { }
        // RVA: 0x05801CB0  token: 0x6000C72
        public System.UInt32 Size() { }
        // RVA: 0x058019B4  token: 0x6000C73
        public System.Span<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition> AsSpan() { }
        // RVA: 0x02C34A20  token: 0x6000C74
        public System.UInt32 Create(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& value) { }
        // RVA: 0x05801A68  token: 0x6000C75
        public System.Void Destroy(System.UInt32 handle) { }
        // RVA: 0x02C348A0  token: 0x6000C76
        public System.Void Reset() { }
        // RVA: 0x05801C2C  token: 0x6000C77
        public System.Void Reserve(System.UInt32 newCapacity) { }
        // RVA: 0x027DA760  token: 0x6000C78
        public System.IntPtr Data() { }
        // RVA: 0x05801BC8  token: 0x6000C7B
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& Get(System.UInt32 handle) { }
        // RVA: 0x05801B64  token: 0x6000C7C
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& Get(System.Int32 handle) { }

    }

    // TypeToken: 0x2000256  // size: 0x10
    public static class VATFSMDefinitionHelper
    {
        // Methods
        // RVA: 0x05802218  token: 0x6000C7D
        private static System.Boolean _Evaluate(Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition& cond, Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& param, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& paramDefs) { }
        // RVA: 0x05802068  token: 0x6000C7E
        public static System.Boolean TryGetValidTransition(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& state, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& def, System.Int32& transitionIndex) { }
        // RVA: 0x05801EF8  token: 0x6000C7F
        public static System.Boolean TryGetParameterIndexAndType(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition def, System.Int32 nameHash, System.Byte& index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType& type) { }
        // RVA: 0x05801D5C  token: 0x6000C80
        public static System.Void ResetUsedTriggers(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& param, Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& transition, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& paramDefs) { }

    }

    // TypeToken: 0x2000257  // size: 0x10
    public static class FSMDefinitionLibrary
    {
        // Fields
        public static System.Int32 MAX_FSM_DEFINITION_COUNT;  // const
        public static System.Int32 MAX_STATE_COUNT;  // const
        public static System.Int32 MAX_TRANSITION_COUNT;  // const
        public static System.Int32 MAX_CONDITION_PRE_TRANSITION_COUNT;  // const
        public static System.Int32 MAX_PARAMETER_COUNT;  // const
        public static System.Byte ANY_STATE_INDEX;  // const
        public static Unity.Collections.NativeParallelHashMap<System.Int32,System.UInt32> s_assetHashGuidToHandle;  // static @ 0x0
        public static Unity.Collections.NativeParallelHashMap<Unity.Mathematics.int2,System.Byte> s_stateNameHashToIndex;  // static @ 0x10
        public static Unity.Collections.NativeParallelHashMap<Unity.Mathematics.int2,System.Byte> s_parameterNameHashToIndex;  // static @ 0x20

        // Methods
        // RVA: 0x039B48A0  token: 0x6000C81
        public static System.Void Initialize() { }
        // RVA: 0x02764770  token: 0x6000C82
        public static System.Void InitFSMDefinition(System.Int32 guid, Beyond.Gameplay.Factory.ECSVATFSM.ECSVATFSMDefinitionData data) { }
        // RVA: 0x02764180  token: 0x6000C83
        public static System.Void RegisterFSM(UnityEngine.HyperGryph.ECS.Entity rEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x057FC880  token: 0x6000C84
        public static System.String GetStateName(System.UInt32 fsmHandler, System.Byte stateIndex) { }
        // RVA: 0x027DA800  token: 0x6000C85
        public static System.Byte GetStateIndex(System.UInt32 fsmHandler, System.Int32 stateNameHash) { }
        // RVA: 0x057FC738  token: 0x6000C86
        public static System.Void Dispose() { }

    }

}

namespace Beyond.Gameplay.Factory.Unsafe
{

    // TypeToken: 0x200025A  // size: 0x80
    public sealed class SamplePredictCargo_00000A4A$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x01133350  token: 0x6000C8C
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01133330  token: 0x6000C8D
        public virtual System.Void Invoke(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation) { }
        // RVA: 0x01132510  token: 0x6000C8E
        public virtual System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation, System.AsyncCallback , System.Object ) { }
        // RVA: 0x010286D0  token: 0x6000C8F
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200025B  // size: 0x10
    public static class SamplePredictCargo_00000A4A$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x01130F60  token: 0x6000C90
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x01131BD0  token: 0x6000C91
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x011306C0  token: 0x6000C92
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000C93
        public static System.Void Initialize() { }
        // RVA: 0x01132500  token: 0x6000C94
        private static System.Void .cctor() { }
        // RVA: 0x01131ED0  token: 0x6000C95
        public static System.Void Invoke(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation) { }

    }

    // TypeToken: 0x2000259  // size: 0x10
    public static class BurstBridge
    {
        // Methods
        // RVA: 0x026E72D0  token: 0x6000C88
        public static System.Void BeginProfilerSample(System.String name) { }
        // RVA: 0x026E7340  token: 0x6000C89
        public static System.Void EndProfilerSample() { }
        // RVA: 0x057FA6E4  token: 0x6000C8A
        public static System.Void SamplePredictCargo(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation) { }
        // RVA: 0x057F908C  token: 0x6000C8B
        public static System.Void SamplePredictCargo$BurstManaged(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation) { }

    }

    // TypeToken: 0x200025D  // size: 0x80
    public sealed class QueryBuildingState_00000A4E$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x01130580  token: 0x6000CB3
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x01035ED0  token: 0x6000CB4
        public virtual Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x0112F710  token: 0x6000CB5
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState, System.AsyncCallback , System.Object ) { }
        // RVA: 0x0102B1A0  token: 0x6000CB6
        public virtual Beyond.GEnums.FacBuildingState EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x200025E  // size: 0x10
    public static class QueryBuildingState_00000A4E$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x0112E180  token: 0x6000CB7
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x0112EDF0  token: 0x6000CB8
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x0112D8E0  token: 0x6000CB9
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000CBA
        public static System.Void Initialize() { }
        // RVA: 0x0112F700  token: 0x6000CBB
        private static System.Void .cctor() { }
        // RVA: 0x0112F0F0  token: 0x6000CBC
        public static Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState) { }

    }

    // TypeToken: 0x200025F  // size: 0x80
    public sealed class SetFlashStatue_00000A50$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x011360F0  token: 0x6000CBD
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000CBE
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue) { }
        // RVA: 0x011352C0  token: 0x6000CBF
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue, System.AsyncCallback , System.Object ) { }
        // RVA: 0x010286D0  token: 0x6000CC0
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000260  // size: 0x10
    public static class SetFlashStatue_00000A50$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x01133D30  token: 0x6000CC1
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x011349A0  token: 0x6000CC2
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x01133490  token: 0x6000CC3
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000CC4
        public static System.Void Initialize() { }
        // RVA: 0x011352B0  token: 0x6000CC5
        private static System.Void .cctor() { }
        // RVA: 0x01134CA0  token: 0x6000CC6
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue) { }

    }

    // TypeToken: 0x2000261  // size: 0x80
    public sealed class _SetRenderEntityFlashStatue_00000A51$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x01138E70  token: 0x6000CC7
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x011360D0  token: 0x6000CC8
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue) { }
        // RVA: 0x01138060  token: 0x6000CC9
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue, System.AsyncCallback , System.Object ) { }
        // RVA: 0x010286D0  token: 0x6000CCA
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000262  // size: 0x10
    public static class _SetRenderEntityFlashStatue_00000A51$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x01136AD0  token: 0x6000CCB
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x01137740  token: 0x6000CCC
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x01136230  token: 0x6000CCD
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x6000CCE
        public static System.Void Initialize() { }
        // RVA: 0x01138050  token: 0x6000CCF
        private static System.Void .cctor() { }
        // RVA: 0x01137A40  token: 0x6000CD0
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue) { }

    }

    // TypeToken: 0x200025C  // size: 0x10
    public static class EntityExtensions
    {
        // Methods
        // RVA: 0x024FC570  token: 0x6000C96
        public static Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetExtData(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x057FB540  token: 0x6000C97
        public static Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetExtData(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr) { }
        // RVA: 0x057FB86C  token: 0x6000C98
        public static System.Boolean QueryBuildingStateIsClosed(UnityEngine.HyperGryph.ECS.Entity logicEntity) { }
        // RVA: 0x057FBDCC  token: 0x6000C99
        public static Beyond.GEnums.FacBuildingState QueryBuildingState(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x057FC28C  token: 0x6000C9A
        private static System.Boolean _IsPowerBuilding(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& logicEntity) { }
        // RVA: 0x057FC010  token: 0x6000C9B
        public static System.Void SetFlashStatue(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue) { }
        // RVA: 0x057FC598  token: 0x6000C9C
        private static System.Void _SetRenderEntityFlashStatue(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue) { }
        // RVA: 0x057FA764  token: 0x6000C9D
        public static System.Boolean CulledWithLogicEntity(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x057FA864  token: 0x6000C9E
        public static System.Boolean CulledWithRendererEntity(UnityEngine.HyperGryph.ECS.Entity rendererEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x057FB6FC  token: 0x6000C9F
        public static System.Boolean GetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, Beyond.Gameplay.Factory.Visibility.Type type) { }
        // RVA: 0x02429500  token: 0x6000CA0
        public static System.Boolean GetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.Visibility.Type type) { }
        // RVA: 0x057FB780  token: 0x6000CA1
        public static System.Boolean GetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.Visibility.Type type) { }
        // RVA: 0x023F91F0  token: 0x6000CA2
        public static System.Boolean SetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, System.Int16[] invisibleSubIndexList) { }
        // RVA: 0x023F93D0  token: 0x6000CA3
        public static System.Boolean SetVisibility(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, System.Int16* subIndexListPtr, System.Int16 subIndexCount) { }
        // RVA: 0x024297D0  token: 0x6000CA4
        public static System.Void SetVisibilityWithNotify(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, System.Int16[] invisibleSubIndexList) { }
        // RVA: 0x023F8F70  token: 0x6000CA5
        public static System.Boolean SetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, UnityEngine.HyperGryph.ECS.EntityCommandBuffer& ecb) { }
        // RVA: 0x027D3380  token: 0x6000CA6
        public static System.Void SetInMainRegion(UnityEngine.HyperGryph.ECS.Entity logicEntity, System.Boolean value) { }
        // RVA: 0x027D32A0  token: 0x6000CA7
        public static System.Boolean IsInMainRegionFuzzy(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x057FB83C  token: 0x6000CA8
        public static System.Boolean IsInMainRegion(Beyond.Gameplay.Factory.SharedDataFragment sharedData, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr) { }
        // RVA: 0x026E3250  token: 0x6000CA9
        public static System.Void UpdatePipeEffect(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x057FC070  token: 0x6000CAA
        public static System.Void UpdatePipeEffect(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& ecb) { }
        // RVA: 0x057FA9A8  token: 0x6000CAB
        public static System.Boolean GetBuildingExtendConfig(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot, UnityEngine.HyperGryph.ECS.Entity& posRendererEntity) { }
        // RVA: 0x057FAC54  token: 0x6000CAC
        public static System.Boolean GetBuildingExtendConfig(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot, UnityEngine.HyperGryph.ECS.Entity& posRendererEntity) { }
        // RVA: 0x057FB468  token: 0x6000CAD
        public static System.Boolean GetBuildingStaticMountWorldTRS(UnityEngine.HyperGryph.ECS.Entity entity, System.String extendKey, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot) { }
        // RVA: 0x057FAF4C  token: 0x6000CAE
        public static System.Boolean GetBuildingStaticMountWorldTRS(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot) { }
        // RVA: 0x057FB204  token: 0x6000CAF
        public static System.Boolean GetBuildingStaticMountWorldTRS(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot) { }
        // RVA: 0x057FB930  token: 0x6000CB0
        public static Beyond.GEnums.FacBuildingState QueryBuildingState$BurstManaged(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState) { }
        // RVA: 0x057FBE2C  token: 0x6000CB1
        public static System.Void SetFlashStatue$BurstManaged(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue) { }
        // RVA: 0x057FC340  token: 0x6000CB2
        public static System.Void _SetRenderEntityFlashStatue$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue) { }

    }

    // TypeToken: 0x2000263  // size: 0x10
    public static class GameplayExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000CD1
        public static System.Void FacUnitAssertComponent(UnityEngine.HyperGryph.ECS.EntityManager em, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: 0x02D07F30  token: 0x6000CD2
        public static Beyond.Gameplay.Factory.ChapterFragment& GetChapterEntity(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 chapterId, System.Boolean& existed, UnityEngine.HyperGryph.ECS.Entity& chapterEntity) { }

    }

    // TypeToken: 0x2000264  // size: 0x10
    public static class GlobalEnvExtensions
    {
        // Methods
        // RVA: 0x027D9B30  token: 0x6000CD3
        public static Beyond.Gameplay.Factory.GlobalEnv* GetGlobalEnv(UnityEngine.HyperGryph.ECS.EntityManager em) { }
        // RVA: 0x057FD878  token: 0x6000CD4
        public static System.IntPtr GetGlobalEnvPtr(UnityEngine.HyperGryph.ECS.EntityManager em) { }
        // RVA: 0x02985AE0  token: 0x6000CD5
        public static System.Boolean IsGlobalEnvValid(UnityEngine.HyperGryph.ECS.EntityManager em) { }
        // RVA: 0x027D9930  token: 0x6000CD6
        public static Beyond.Gameplay.Factory.GlobalEnv& GetGlobalEnvRef(UnityEngine.HyperGryph.ECS.EntityManager em) { }
        // RVA: 0x03B29160  token: 0x6000CD7
        public static System.Void SetNearBuildingPtr(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& info, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& infoLast) { }
        // RVA: 0x03B291B0  token: 0x6000CD8
        public static System.Void SetNearConveyorPtr(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& infoLast) { }
        // RVA: 0x03B29200  token: 0x6000CD9
        public static System.Void SetNearPipePtr(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& infoLast) { }
        // RVA: 0x02AAEC30  token: 0x6000CDA
        public static System.Boolean GetInteractFac(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& info) { }
        // RVA: 0x02AAEBC0  token: 0x6000CDB
        public static System.Boolean GetInteractConveyor(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info) { }
        // RVA: 0x02AAEB60  token: 0x6000CDC
        public static System.Boolean GetInteractPipe(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info) { }

    }

    // TypeToken: 0x2000265
    public interface IAllocator : System.IDisposable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000CDD
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 size) { }
        // RVA: -1  // abstract  token: 0x6000CDE
        public virtual System.Void Reserve(System.Int32 newCapacity) { }
        // RVA: -1  // abstract  token: 0x6000CDF
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Expand(System.Int32 startIndex, System.Int32 additionalSize) { }
        // RVA: -1  // abstract  token: 0x6000CE0
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(System.Int32 startIndex, System.Int32 newSize) { }
        // RVA: -1  // abstract  token: 0x6000CE1
        public virtual System.Void Free(System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000266  // size: 0x30
    public class LinearAllocator : Beyond.Gameplay.Factory.Unsafe.IAllocator, System.IDisposable
    {
        // Fields
        private static System.Int32 INITIAL_CAPACITY;  // const
        private System.Int32 m_totalCapacity;  // 0x10
        private System.Byte* m_memory;  // 0x18
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> <freeBlocks>k__BackingField;  // 0x20
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_allocations;  // 0x28

        // Properties
        System.Collections.Generic.Dictionary<System.Int32,System.Int32> freeBlocks { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x05800BD4  token: 0x6000CE3
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: 0x058008DC  token: 0x6000CE4
        private System.Void _ExpandMemory() { }
        // RVA: 0x057FE788  token: 0x6000CE5
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 size) { }
        // RVA: 0x058002E8  token: 0x6000CE6
        public virtual System.Void Reserve(System.Int32 newCapacity) { }
        // RVA: 0x057FF1D8  token: 0x6000CE7
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Expand(System.Int32 startIndex, System.Int32 additionalSize) { }
        // RVA: 0x058003F0  token: 0x6000CE8
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(System.Int32 startIndex, System.Int32 newSize) { }
        // RVA: 0x05800A38  token: 0x6000CE9
        private System.Void _MergeAdjacentFreeBlocks() { }
        // RVA: 0x057FF5F4  token: 0x6000CEA
        public virtual System.Void Free(System.Int32 startIndex) { }
        // RVA: 0x03D56680  token: 0x6000CEB
        public System.Void* GetPointer(System.Int32 offset) { }
        // RVA: 0x057FF124  token: 0x6000CEC
        public virtual System.Void Dispose() { }
        // RVA: 0x057FF9F4  token: 0x6000CED
        public System.Void PrintAllocations() { }
        // RVA: 0x057FF584  token: 0x6000CEE
        protected virtual System.Void Finalize() { }

    }

    // TypeToken: 0x2000269  // size: 0x48
    public sealed struct LinearAllocatorUnmanaged : Beyond.Gameplay.Factory.Unsafe.IAllocator, System.IDisposable
    {
        // Fields
        private static System.Int32 INITIAL_CAPACITY;  // const
        private System.Int32 m_totalCapacity;  // 0x10
        private System.Byte* m_memory;  // 0x18
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> <freeBlocks>k__BackingField;  // 0x20
        private Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> m_allocations;  // 0x30
        private System.Boolean m_initialized;  // 0x40
        private Unity.Collections.Allocator m_allocator;  // 0x44

        // Properties
        Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> freeBlocks { get; /* RVA: 0x020B7B30 */ set; /* RVA: 0x03D55580 */ }

        // Methods
        // RVA: 0x03281410  token: 0x6000CF7
        public System.Void Initialize(System.Int32 capacity, Unity.Collections.Allocator allocator) { }
        // RVA: 0x02A90100  token: 0x6000CF8
        private System.Void _ExpandMemory() { }
        // RVA: 0x02A8E0E0  token: 0x6000CF9
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 size) { }
        // RVA: 0x057FE678  token: 0x6000CFA
        public virtual System.Void Reserve(System.Int32 newCapacity) { }
        // RVA: 0x039B1870  token: 0x6000CFB
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Expand(System.Int32 startIndex, System.Int32 additionalSize) { }
        // RVA: 0x039B1750  token: 0x6000CFC
        public virtual Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(System.Int32 startIndex, System.Int32 newSize) { }
        // RVA: 0x023CB160  token: 0x6000CFD
        private System.Void _MergeAdjacentFreeBlocks() { }
        // RVA: 0x039B1A50  token: 0x6000CFE
        public virtual System.Void Free(System.Int32 startIndex) { }
        // RVA: 0x02E50A70  token: 0x6000CFF
        public System.Void* GetPointer(System.Int64 offset) { }
        // RVA: 0x057FD9D8  token: 0x6000D00
        public virtual System.Void Dispose() { }
        // RVA: 0x057FDAD4  token: 0x6000D01
        public System.Void PrintAllocations() { }

    }

    // TypeToken: 0x200026B  // size: 0x30
    public sealed struct TLSFBlockHeader
    {
        // Fields
        public static System.Int32 ALIGNMENT;  // const
        public Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* prev;  // 0x10
        public Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* next;  // 0x18
        public Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* prePhys;  // 0x20
        public System.UInt32 size;  // 0x28
        public System.Boolean isFree;  // 0x2c

    }

    // TypeToken: 0x200026C  // size: 0x40
    public class TLSFAllocator
    {
        // Fields
        private static System.Int32 FIRST_LEVEL_INDEX_COUNT;  // const
        private static System.Int32 SECOND_LEVEL_INDEX_COUNT;  // const
        private static System.Int32 SMALL_BLOCK_SIZE;  // const
        private static System.Int32 ALIGNMENT;  // const
        private System.UInt32 _flBitmap;  // 0x10
        private System.UInt32[] _slBitmap;  // 0x18
        private Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader*[,] _freeList;  // 0x20
        private System.IntPtr _memoryPool;  // 0x28
        private System.UInt32 _poolSize;  // 0x30
        private Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* _firstBlock;  // 0x38

        // Methods
        // RVA: 0x058016A8  token: 0x6000D06
        public System.Void .ctor(System.UInt32 size) { }
        // RVA: 0x0580107C  token: 0x6000D07
        protected virtual System.Void Finalize() { }
        // RVA: 0x05801010  token: 0x6000D08
        public System.Void* Allocate(System.UInt32 size) { }
        // RVA: 0x058011E0  token: 0x6000D09
        public System.Void Free(System.Void* ptr) { }
        // RVA: 0x0580121C  token: 0x6000D0A
        public System.UInt32 GetFreeSpace() { }
        // RVA: 0x05801134  token: 0x6000D0B
        private Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* FindSuitableBlock(System.UInt32 size) { }
        // RVA: 0x058012B8  token: 0x6000D0C
        private System.Void InsertFreeBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block) { }
        // RVA: 0x05801540  token: 0x6000D0D
        private System.Void RemoveFreeBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block) { }
        // RVA: 0x05801638  token: 0x6000D0E
        private System.Void SplitBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block, System.UInt32 size) { }
        // RVA: 0x0580145C  token: 0x6000D0F
        private Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* MergeBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block) { }
        // RVA: 0x058013B4  token: 0x6000D10
        private System.Void MappingInsert(System.UInt32 size, System.Int32& fl, System.Int32& sl) { }
        // RVA: 0x057FA43C  token: 0x6000D11
        private static System.Int32 MostSignificantBit(System.UInt32 value) { }
        // RVA: 0x057FA41C  token: 0x6000D12
        private static System.Int32 FindFirstSet(System.UInt32 value) { }
        // RVA: 0x03D56690  token: 0x6000D13
        private static System.UInt32 AlignSize(System.UInt32 size) { }

    }

    // TypeToken: 0x200026D  // size: 0x10
    public class FactoryUnsafeUtil
    {
        // Fields
        private static System.UInt32 NO_NODE_ID_RANGE_MIN;  // const
        private static System.UInt32 NO_NODE_ID_RANGE_MAX;  // const
        private static System.UInt32 s_nodeId;  // static @ 0x0

        // Methods
        // RVA: 0x057FD5D8  token: 0x6000D14
        public static System.Boolean IsManualNodeId(System.UInt32 id) { }
        // RVA: 0x02F40DD0  token: 0x6000D15
        public static System.UInt32 AllocManualNodeId() { }
        // RVA: 0x057FD5EC  token: 0x6000D16
        public static System.Boolean IsPointInSector(Unity.Mathematics.float3 point, Unity.Mathematics.float3 center, Unity.Mathematics.float3 dir, System.Single checkRad, System.Single checkDist, System.Single& curDistanceSq, System.Single& curCosTheta, System.Boolean ignoreY) { }
        // RVA: -1  // generic def  token: 0x6000D17
        public static System.Void SwapPointer(T*& p1, T*& p2) { }
        // RVA: 0x027DD160  token: 0x6000D18
        public static System.IntPtr AddressOf(Beyond.Gameplay.Factory.GlobalEnv& env) { }
        // RVA: 0x0350B670  token: 0x6000D19
        public static System.Void CallFromLuaCheck() { }
        // RVA: 0x0350B670  token: 0x6000D1A
        public System.Void .ctor() { }
        // RVA: 0x03D44820  token: 0x6000D1B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200026E  // size: 0x10
    public static class StructMarshal
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000D1C
        public static System.Byte[] StructToBytes(T str) { }
        // RVA: -1  // generic def  token: 0x6000D1D
        public static System.Byte[] UnmanagedStructToBytes(T value) { }
        // RVA: -1  // generic def  token: 0x6000D1E
        public static T BytesToStruct(System.Byte[] bytes, System.Int32 offset) { }
        // RVA: -1  // generic def  token: 0x6000D1F
        public static T BytesToUnmanagedStruct(System.Byte[] bytes, System.Int32 offset) { }
        // RVA: -1  // generic def  token: 0x6000D20
        public static System.Byte[] FixedList512BytesToBytes(Unity.Collections.FixedList512Bytes<T>& list) { }
        // RVA: -1  // generic def  token: 0x6000D21
        public static Unity.Collections.FixedList512Bytes<T> BytesToFixedList512Bytes(System.Byte[]& bytes) { }

    }

}

namespace Beyond.Gameplay.Factory.Util
{

    // TypeToken: 0x2000258  // size: 0x10
    public static class JobHandlerExtensions
    {
        // Methods
        // RVA: 0x057FD970  token: 0x6000C87
        public static System.Void SafeComplete(Unity.Jobs.JobHandle jobHandle) { }

    }

}

namespace Beyond.PoolCore
{

    // TypeToken: 0x2000028  // size: 0x10
    public static class ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond
    {
        // Fields
        private static System.Boolean s_initialized;  // static @ 0x0

        // Methods
        // RVA: 0x03CB2C90  token: 0x6000103
        private static System.Void InitializeAtRuntime() { }
        // RVA: 0x03CB2CC0  token: 0x6000104
        private static System.Void Initialize() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000029  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000105
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x200002A  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000106
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000107
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000108
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000109
        public System.Void .ctor() { }

    }

}

namespace FactoryUIAtlas
{

    // TypeToken: 0x2000005  // size: 0x28
    public class FactoryLiquidAtlasSOData : UnityEngine.ScriptableObject
    {
        // Fields
        public Beyond.SerializeFieldDictionary<System.String,Beyond.GEnums.FacItemSubType> m_liquidMaterial;  // 0x18
        public Beyond.SerializeFieldDictionary<Beyond.GEnums.FacItemSubType,System.Int32> m_liquidMatIndex;  // 0x20

        // Methods
        // RVA: 0x0578F2B0  token: 0x6000004
        public System.Boolean GetMaterial(System.String mat, Beyond.GEnums.FacItemSubType& matName) { }
        // RVA: 0x0578F24C  token: 0x6000005
        public System.Boolean GetAtlasMaterialSort(Beyond.GEnums.FacItemSubType matName, System.Int32& sort) { }
        // RVA: 0x0578F168  token: 0x6000006
        public static FactoryUIAtlas.FactoryLiquidAtlasSOData CreateOrGet(System.String path) { }
        // RVA: 0x03C8A360  token: 0x6000007
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x28
    public class FactoryUIAtlasSOData : UnityEngine.ScriptableObject
    {
        // Fields
        public Beyond.SerializeFieldDictionary<System.String,UnityEngine.RectInt> m_insertName;  // 0x18
        public Beyond.SerializeFieldDictionary<System.String,System.Int32> m_insertIndex;  // 0x20

        // Methods
        // RVA: 0x02C03700  token: 0x6000008
        public System.Boolean GetRect(System.String texName, UnityEngine.RectInt& rect) { }
        // RVA: 0x02F889B0  token: 0x6000009
        public System.Boolean GetIndex(System.String texName, System.Int32& index) { }
        // RVA: 0x0578F5F0  token: 0x600000A
        public static FactoryUIAtlas.FactoryUIAtlasSOData CreateOrGet(System.String path) { }
        // RVA: 0x039DEBD0  token: 0x600000B
        public System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000004  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000003
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000272  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000D26
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x05477F10  token: 0x6000D27
        public System.Int32 __Gen_Wrap_0(System.Object P0) { }
        // RVA: 0x057D3C80  token: 0x6000D28
        public Unity.Collections.NativeArray<System.Int32> __Gen_Wrap_1(System.Object P0) { }
        // RVA: 0x057E0920  token: 0x6000D29
        public System.Object __Gen_Wrap_2(System.Int32 P0) { }
        // RVA: 0x050F3444  token: 0x6000D2A
        public System.Void __Gen_Wrap_3() { }
        // RVA: 0x057F3BBC  token: 0x6000D2B
        public System.Void __Gen_Wrap_4(Beyond.Gameplay.Factory.PerDrawConfig& P0) { }
        // RVA: 0x057F494C  token: 0x6000D2C
        public System.Void __Gen_Wrap_5(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0) { }
        // RVA: 0x04274234  token: 0x6000D2D
        public System.Void __Gen_Wrap_6(System.Object P0) { }
        // RVA: 0x057F6984  token: 0x6000D2E
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> __Gen_Wrap_7() { }
        // RVA: 0x057F7EE0  token: 0x6000D2F
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> __Gen_Wrap_8(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> P0, System.Object P1) { }
        // RVA: 0x057F8F80  token: 0x6000D30
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> __Gen_Wrap_9(System.Object P0) { }
        // RVA: 0x057CA008  token: 0x6000D31
        public System.Void __Gen_Wrap_10(Beyond.Gameplay.Factory.ConveyorExtContainer& P0) { }
        // RVA: 0x057CB6B0  token: 0x6000D32
        public System.UInt32 __Gen_Wrap_11(Beyond.Gameplay.Factory.ConveyorExtContainer& P0) { }
        // RVA: 0x057CCE4C  token: 0x6000D33
        public System.Span<Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt> __Gen_Wrap_12(Beyond.Gameplay.Factory.ConveyorExtContainer& P0) { }
        // RVA: 0x057CE07C  token: 0x6000D34
        public System.UInt32 __Gen_Wrap_13(Beyond.Gameplay.Factory.ConveyorExtContainer& P0, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& P1) { }
        // RVA: 0x057CEDD8  token: 0x6000D35
        public System.Void __Gen_Wrap_14(Beyond.Gameplay.Factory.ConveyorExtContainer& P0, System.UInt32 P1) { }
        // RVA: 0x057CFC34  token: 0x6000D36
        public System.IntPtr __Gen_Wrap_15(Beyond.Gameplay.Factory.ConveyorExtContainer& P0) { }
        // RVA: 0x057D0998  token: 0x6000D37
        public Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& __Gen_Wrap_16(Beyond.Gameplay.Factory.ConveyorExtContainer& P0, System.UInt32 P1) { }
        // RVA: 0x057D1654  token: 0x6000D38
        public System.Void __Gen_Wrap_17(Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& P0) { }
        // RVA: 0x057D2A60  token: 0x6000D39
        public System.Void __Gen_Wrap_18(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0) { }
        // RVA: 0x057D3ABC  token: 0x6000D3A
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_19(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1) { }
        // RVA: 0x057D56F4  token: 0x6000D3B
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_20(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, System.Int32 P1) { }
        // RVA: 0x057D6B50  token: 0x6000D3C
        public System.Void __Gen_Wrap_21(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1) { }
        // RVA: 0x057D7F70  token: 0x6000D3D
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_22(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x057D9650  token: 0x6000D3E
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_23(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation P1, System.Int32 P2) { }
        // RVA: 0x057DB9A0  token: 0x6000D3F
        public System.Void __Gen_Wrap_24(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, System.UInt32 P1) { }
        // RVA: 0x057DCC40  token: 0x6000D40
        public System.Int64 __Gen_Wrap_25(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, System.UInt32 P1) { }
        // RVA: 0x057DDC10  token: 0x6000D41
        public System.Int32 __Gen_Wrap_26(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> P0) { }
        // RVA: 0x057DE968  token: 0x6000D42
        public System.Void __Gen_Wrap_27(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0) { }
        // RVA: 0x057DF84C  token: 0x6000D43
        public System.Void __Gen_Wrap_28(Beyond.Gameplay.Factory.SharedDataContainer& P0) { }
        // RVA: 0x057E07DC  token: 0x6000D44
        public System.UInt32 __Gen_Wrap_29(Beyond.Gameplay.Factory.SharedDataContainer& P0) { }
        // RVA: 0x057E19E8  token: 0x6000D45
        public System.Span<Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData> __Gen_Wrap_30(Beyond.Gameplay.Factory.SharedDataContainer& P0) { }
        // RVA: 0x057E2998  token: 0x6000D46
        public System.UInt32 __Gen_Wrap_31(Beyond.Gameplay.Factory.SharedDataContainer& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1) { }
        // RVA: 0x057E39B8  token: 0x6000D47
        public System.Void __Gen_Wrap_32(Beyond.Gameplay.Factory.SharedDataContainer& P0, System.UInt32 P1) { }
        // RVA: 0x057E4F74  token: 0x6000D48
        public System.IntPtr __Gen_Wrap_33(Beyond.Gameplay.Factory.SharedDataContainer& P0) { }
        // RVA: 0x057E6028  token: 0x6000D49
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_34(Beyond.Gameplay.Factory.SharedDataContainer& P0, System.UInt32 P1) { }
        // RVA: 0x057E6F78  token: 0x6000D4A
        public System.Boolean __Gen_Wrap_35(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P0, Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag P1) { }
        // RVA: 0x057E82A8  token: 0x6000D4B
        public System.Void __Gen_Wrap_36(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P0, Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag P1, System.Boolean P2) { }
        // RVA: 0x057E9898  token: 0x6000D4C
        public System.Boolean __Gen_Wrap_37(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P0) { }
        // RVA: 0x057EB2B4  token: 0x6000D4D
        public Unity.Mathematics.float3 __Gen_Wrap_38(Beyond.Gameplay.Factory.WireRendererInfo& P0) { }
        // RVA: 0x057EC6A4  token: 0x6000D4E
        public Unity.Mathematics.quaternion __Gen_Wrap_39(Beyond.Gameplay.Factory.WireRendererInfo& P0) { }
        // RVA: 0x057EDCD4  token: 0x6000D4F
        public Unity.Collections.NativeParallelHashMap<Beyond.Gameplay.Factory.UnitId,UnityEngine.HyperGryph.ECS.Entity> __Gen_Wrap_40(System.Object P0) { }
        // RVA: 0x057EF65C  token: 0x6000D50
        public Beyond.Gameplay.Factory.UnitId __Gen_Wrap_41(System.Int32 P0, System.UInt32 P1) { }
        // RVA: 0x057F0E34  token: 0x6000D51
        public System.Void __Gen_Wrap_42(System.Object P0, System.Int32 P1, System.UInt32 P2, UnityEngine.HyperGryph.ECS.Entity P3) { }
        // RVA: 0x0561022C  token: 0x6000D52
        public System.Boolean __Gen_Wrap_43(System.Object P0, System.Int32 P1, System.UInt32 P2) { }
        // RVA: 0x057F382C  token: 0x6000D53
        public System.Boolean __Gen_Wrap_44(System.Object P0, System.Int32 P1, System.UInt32 P2, UnityEngine.HyperGryph.ECS.Entity& P3) { }
        // RVA: 0x057F3988  token: 0x6000D54
        public System.Void __Gen_Wrap_45(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0) { }
        // RVA: 0x050EF068  token: 0x6000D55
        public System.UInt32 __Gen_Wrap_46() { }
        // RVA: 0x0514E3FC  token: 0x6000D56
        public System.Void __Gen_Wrap_47(System.UInt32 P0) { }
        // RVA: 0x057F3AD0  token: 0x6000D57
        public Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& __Gen_Wrap_48(System.UInt32 P0) { }
        // RVA: 0x0516C778  token: 0x6000D58
        public System.IntPtr __Gen_Wrap_49() { }
        // RVA: 0x057F3D1C  token: 0x6000D59
        public System.UInt32 __Gen_Wrap_50(System.Boolean P0) { }
        // RVA: 0x057F3DEC  token: 0x6000D5A
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_51(System.UInt32 P0) { }
        // RVA: 0x057F3ED8  token: 0x6000D5B
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& __Gen_Wrap_52(System.UInt32 P0) { }
        // RVA: 0x057F3FC4  token: 0x6000D5C
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& __Gen_Wrap_53(System.Int32 P0) { }
        // RVA: 0x057F40B0  token: 0x6000D5D
        public Unity.Mathematics.float4x4 __Gen_Wrap_54(Beyond.Gameplay.Factory.LocalTransform& P0) { }
        // RVA: 0x057F4244  token: 0x6000D5E
        public Unity.Mathematics.float4x4 __Gen_Wrap_55(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& P0) { }
        // RVA: 0x057F43A8  token: 0x6000D5F
        public System.UInt32 __Gen_Wrap_56(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P1) { }
        // RVA: 0x057F45A8  token: 0x6000D60
        public System.UInt32 __Gen_Wrap_57(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P0) { }
        // RVA: 0x057F4710  token: 0x6000D61
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& __Gen_Wrap_58(System.UInt32 P0) { }
        // RVA: 0x057F47FC  token: 0x6000D62
        public System.Void __Gen_Wrap_59(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, System.UInt32 P1) { }
        // RVA: 0x057F4A84  token: 0x6000D63
        public System.IntPtr __Gen_Wrap_60(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0) { }
        // RVA: 0x057F4BDC  token: 0x6000D64
        public Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType __Gen_Wrap_61(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0) { }
        // RVA: 0x057F4D44  token: 0x6000D65
        public System.Void __Gen_Wrap_62(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0) { }
        // RVA: 0x057F4E9C  token: 0x6000D66
        public System.Void __Gen_Wrap_63(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0, Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType P1) { }
        // RVA: 0x057F5010  token: 0x6000D67
        public System.Void __Gen_Wrap_64(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0, System.Int32 P1, Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType P2) { }
        // RVA: 0x057F51A0  token: 0x6000D68
        public System.String __Gen_Wrap_65(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0) { }
        // RVA: 0x057F5318  token: 0x6000D69
        public System.Void __Gen_Wrap_66(Beyond.Gameplay.Factory.CutoffState& P0, System.Boolean P1) { }
        // RVA: 0x057F5458  token: 0x6000D6A
        public System.Void __Gen_Wrap_67(Beyond.Gameplay.Factory.CutoffState& P0, System.Single P1) { }
        // RVA: 0x057F55A8  token: 0x6000D6B
        public System.Void __Gen_Wrap_68(Beyond.Gameplay.Factory.CutoffState& P0, System.UInt32 P1) { }
        // RVA: 0x057F56E4  token: 0x6000D6C
        public System.Void __Gen_Wrap_69(Beyond.Gameplay.Factory.BuildDismissState& P0, System.Boolean P1) { }
        // RVA: 0x057F5834  token: 0x6000D6D
        public System.Void __Gen_Wrap_70(Beyond.Gameplay.Factory.HighLightState& P0, System.Boolean P1) { }
        // RVA: 0x057F5A3C  token: 0x6000D6E
        public System.Void __Gen_Wrap_71(Beyond.Gameplay.Factory.HighLightState& P0, System.Boolean P1, System.Boolean P2) { }
        // RVA: 0x057F5C58  token: 0x6000D6F
        public Beyond.Gameplay.Factory.LogicEntityState __Gen_Wrap_72(Beyond.Gameplay.Factory.HighLightState& P0) { }
        // RVA: 0x057F5E44  token: 0x6000D70
        public System.Boolean __Gen_Wrap_73(Beyond.Gameplay.Factory.HighLightState& P0, System.Byte P1) { }
        // RVA: 0x057F604C  token: 0x6000D71
        public System.Void __Gen_Wrap_74(Beyond.Gameplay.Factory.HighLightState& P0, System.Byte P1, System.Boolean P2) { }
        // RVA: 0x057F6268  token: 0x6000D72
        public System.Void __Gen_Wrap_75(Beyond.Gameplay.Factory.HighLightState& P0) { }
        // RVA: 0x057F6454  token: 0x6000D73
        public System.Void __Gen_Wrap_76(Beyond.Gameplay.Factory.HintState& P0, System.Boolean P1) { }
        // RVA: 0x057F65A0  token: 0x6000D74
        public System.Void __Gen_Wrap_77(Beyond.Gameplay.Factory.FigureState& P0, System.Boolean P1) { }
        // RVA: 0x057F66EC  token: 0x6000D75
        public System.Void __Gen_Wrap_78(Beyond.Gameplay.Factory.OverloadState& P0, System.Boolean P1) { }
        // RVA: 0x057F6838  token: 0x6000D76
        public System.Void __Gen_Wrap_79(Beyond.Gameplay.Factory.OverloadInvalidState& P0, System.Boolean P1) { }
        // RVA: 0x057F6A74  token: 0x6000D77
        public System.Void __Gen_Wrap_80(Beyond.Gameplay.Factory.DitherState& P0, System.Boolean P1) { }
        // RVA: 0x057F6BA8  token: 0x6000D78
        public System.Void __Gen_Wrap_81(Beyond.Gameplay.Factory.BlueprintState& P0, System.Boolean P1) { }
        // RVA: 0x057F6DD4  token: 0x6000D79
        public System.Void __Gen_Wrap_82(Beyond.Gameplay.Factory.BlueprintState& P0, System.Boolean P1, Beyond.Gameplay.Factory.BlueprintState.EffectType P2) { }
        // RVA: 0x057F701C  token: 0x6000D7A
        public System.Boolean __Gen_Wrap_83(Beyond.Gameplay.Factory.BlueprintState& P0, System.Byte P1) { }
        // RVA: 0x057F7248  token: 0x6000D7B
        public System.Void __Gen_Wrap_84(Beyond.Gameplay.Factory.BlueprintState& P0, System.Byte P1, System.Boolean P2) { }
        // RVA: 0x057F7490  token: 0x6000D7C
        public System.Void __Gen_Wrap_85(Beyond.Gameplay.Factory.BlueprintState& P0) { }
        // RVA: 0x057F76A8  token: 0x6000D7D
        public System.Void __Gen_Wrap_86(Beyond.Gameplay.Factory.PreSelectState& P0, System.Boolean P1) { }
        // RVA: 0x057F78B4  token: 0x6000D7E
        public System.Boolean __Gen_Wrap_87(Beyond.Gameplay.Factory.PreSelectState& P0, System.Byte P1) { }
        // RVA: 0x057F7AC0  token: 0x6000D7F
        public System.Void __Gen_Wrap_88(Beyond.Gameplay.Factory.PreSelectState& P0, System.Byte P1, System.Boolean P2) { }
        // RVA: 0x057F7CE8  token: 0x6000D80
        public System.Void __Gen_Wrap_89(Beyond.Gameplay.Factory.PreSelectState& P0) { }
        // RVA: 0x057F802C  token: 0x6000D81
        public System.Void __Gen_Wrap_90(Beyond.Gameplay.Factory.SoloSelectState& P0, System.Boolean P1) { }
        // RVA: 0x057F8160  token: 0x6000D82
        public System.Boolean __Gen_Wrap_91(Beyond.Gameplay.Factory.SoloSelectState& P0, System.Int32 P1) { }
        // RVA: 0x057F82A0  token: 0x6000D83
        public System.Void __Gen_Wrap_92(Beyond.Gameplay.Factory.ContinuationState& P0, System.Boolean P1) { }
        // RVA: 0x057F84AC  token: 0x6000D84
        public System.Boolean __Gen_Wrap_93(Beyond.Gameplay.Factory.ContinuationState& P0, System.Byte P1) { }
        // RVA: 0x057F86B8  token: 0x6000D85
        public System.Void __Gen_Wrap_94(Beyond.Gameplay.Factory.ContinuationState& P0, System.Byte P1, System.Boolean P2) { }
        // RVA: 0x057F88CC  token: 0x6000D86
        public System.Void __Gen_Wrap_95(Beyond.Gameplay.Factory.ContinuationState& P0) { }
        // RVA: 0x057F8AB0  token: 0x6000D87
        public System.Void __Gen_Wrap_96(Beyond.Gameplay.Factory.SocialSharingState& P0, System.Boolean P1) { }
        // RVA: 0x057F8BE0  token: 0x6000D88
        public System.Void __Gen_Wrap_97(Beyond.Gameplay.Factory.PowerInteractionState& P0, System.Boolean P1) { }
        // RVA: 0x057F8D10  token: 0x6000D89
        public System.Boolean __Gen_Wrap_98(Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& P0) { }
        // RVA: 0x057F8E50  token: 0x6000D8A
        public System.Void __Gen_Wrap_99(Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& P0) { }
        // RVA: 0x057C90A8  token: 0x6000D8B
        public System.Void __Gen_Wrap_100(Beyond.Gameplay.Factory.BattleFragment& P0) { }
        // RVA: 0x057C91D8  token: 0x6000D8C
        public System.Boolean __Gen_Wrap_101(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, UnityEngine.HyperGryph.ECS.Entity P1) { }
        // RVA: 0x057C93C0  token: 0x6000D8D
        public System.Void __Gen_Wrap_102(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, UnityEngine.HyperGryph.ECS.Entity P1) { }
        // RVA: 0x057C9598  token: 0x6000D8E
        public System.Void __Gen_Wrap_103(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, System.Object P1) { }
        // RVA: 0x057C9740  token: 0x6000D8F
        public System.Void __Gen_Wrap_104(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> P1) { }
        // RVA: 0x057C9924  token: 0x6000D90
        public System.Void __Gen_Wrap_105(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0) { }
        // RVA: 0x057C9AC4  token: 0x6000D91
        public System.Boolean __Gen_Wrap_106(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0) { }
        // RVA: 0x057C9C74  token: 0x6000D92
        public System.Void __Gen_Wrap_107(Beyond.Gameplay.Factory.BurnPowerFragment& P0) { }
        // RVA: 0x057C9DD4  token: 0x6000D93
        public System.Void __Gen_Wrap_108(Beyond.Gameplay.Factory.BusFragment& P0) { }
        // RVA: 0x057C9EEC  token: 0x6000D94
        public System.Void __Gen_Wrap_109(Beyond.Gameplay.Factory.BusFreeFragment& P0) { }
        // RVA: 0x057CA150  token: 0x6000D95
        public System.Int32 __Gen_Wrap_110(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4, Beyond.Gameplay.Factory.FactoryItem*& P5) { }
        // RVA: 0x057CA404  token: 0x6000D96
        public System.Void __Gen_Wrap_111(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4, System.UInt32& P5, System.Int32& P6, System.Int64& P7) { }
        // RVA: 0x057CA704  token: 0x6000D97
        public System.Void __Gen_Wrap_112(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4, System.UInt32 P5, System.Int32 P6, System.Int64 P7) { }
        // RVA: 0x057CA98C  token: 0x6000D98
        public System.Void __Gen_Wrap_113(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4) { }
        // RVA: 0x057CABDC  token: 0x6000D99
        public System.Void __Gen_Wrap_114(Beyond.Gameplay.Factory.CacheFragment& P0) { }
        // RVA: 0x057CADC0  token: 0x6000D9A
        public System.Void __Gen_Wrap_115(Beyond.Gameplay.Factory.CacheTransportFragment& P0) { }
        // RVA: 0x057CAEF0  token: 0x6000D9B
        public System.Single __Gen_Wrap_116(Beyond.Gameplay.Factory.CargoFragment& P0, System.Int64 P1) { }
        // RVA: 0x057CB0C0  token: 0x6000D9C
        public System.Int32 __Gen_Wrap_117(Beyond.Gameplay.Factory.CargoFragment& P0, Beyond.Gameplay.Factory.CargoFragment P1) { }
        // RVA: 0x057CB2E4  token: 0x6000D9D
        public Beyond.Gameplay.Factory.CargoFragment __Gen_Wrap_118(System.UInt32 P0, Unity.Mathematics.int4 P1, Unity.Mathematics.int4 P2, System.Int32 P3, System.Int32 P4, System.Int64 P5, System.Int32 P6, System.Single P7, System.Boolean P8) { }
        // RVA: 0x057CB50C  token: 0x6000D9E
        public System.Void __Gen_Wrap_119(Beyond.Gameplay.Factory.CargoFragment& P0) { }
        // RVA: 0x057CB7F4  token: 0x6000D9F
        public System.Void __Gen_Wrap_120(Beyond.Gameplay.Factory.CargoRendererFragment& P0) { }
        // RVA: 0x057CB90C  token: 0x6000DA0
        public System.Void __Gen_Wrap_121(Beyond.Gameplay.Factory.ChapterFragment& P0) { }
        // RVA: 0x057CBA98  token: 0x6000DA1
        public System.Void __Gen_Wrap_122(Beyond.Gameplay.Factory.CollectorFragment& P0) { }
        // RVA: 0x057CBBBC  token: 0x6000DA2
        public System.Boolean __Gen_Wrap_123(Beyond.Gameplay.Factory.ConnectionFragment& P0) { }
        // RVA: 0x057CBD24  token: 0x6000DA3
        public System.Void __Gen_Wrap_124(Beyond.Gameplay.Factory.ConnectionFragment& P0) { }
        // RVA: 0x057CBE68  token: 0x6000DA4
        public System.Void __Gen_Wrap_125(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2, Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info*& P3) { }
        // RVA: 0x057CC150  token: 0x6000DA5
        public System.Void __Gen_Wrap_126(Unity.Collections.NativeList<Unity.Mathematics.float3> P0, UnityEngine.Rect& P1) { }
        // RVA: 0x057CC2C4  token: 0x6000DA6
        public System.Void __Gen_Wrap_127(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Collections.NativeList<Unity.Mathematics.float3>& P2, Unity.Collections.NativeList<Unity.Mathematics.float3>& P3, Unity.Collections.NativeArray<System.Byte>& P4) { }
        // RVA: 0x057CC734  token: 0x6000DA7
        public System.Boolean __Gen_Wrap_128(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Mathematics.float2 P2, System.UInt32& P3, System.Int32& P4) { }
        // RVA: 0x057CCAF0  token: 0x6000DA8
        public System.Boolean __Gen_Wrap_129(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5) { }
        // RVA: 0x057CCFBC  token: 0x6000DA9
        public System.Boolean __Gen_Wrap_130(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, Beyond.PoolCore.PooledList<System.Int32>& P6) { }
        // RVA: 0x057CD374  token: 0x6000DAA
        public System.Boolean __Gen_Wrap_131(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, System.ValueTuple<System.UInt32,System.Int32>[,]& P6) { }
        // RVA: 0x057CD72C  token: 0x6000DAB
        public System.Void __Gen_Wrap_132(Beyond.Gameplay.Factory.ConveyorFragment& P0, System.Single P1) { }
        // RVA: 0x057CD884  token: 0x6000DAC
        public System.Void __Gen_Wrap_133(Beyond.Gameplay.Factory.ConveyorFragment& P0) { }
        // RVA: 0x057CD9C0  token: 0x6000DAD
        public System.Void __Gen_Wrap_134(Beyond.Gameplay.Factory.ConveyorLogisticsUnitFragment& P0) { }
        // RVA: 0x057CDAD8  token: 0x6000DAE
        public System.Void __Gen_Wrap_135(Beyond.Gameplay.Factory.ConveyorRenderFragment& P0) { }
        // RVA: 0x057CDC1C  token: 0x6000DAF
        public System.Void __Gen_Wrap_136(Beyond.Gameplay.Factory.LeftFragment& P0) { }
        // RVA: 0x057CDD34  token: 0x6000DB0
        public System.Void __Gen_Wrap_137(Beyond.Gameplay.Factory.RightFragment& P0) { }
        // RVA: 0x057CDE4C  token: 0x6000DB1
        public System.Void __Gen_Wrap_138(Beyond.Gameplay.Factory.MidFragment& P0) { }
        // RVA: 0x057CDF64  token: 0x6000DB2
        public System.Void __Gen_Wrap_139(Beyond.Gameplay.Factory.CullResultFragment& P0) { }
        // RVA: 0x057CE25C  token: 0x6000DB3
        public System.Void __Gen_Wrap_140(Beyond.Gameplay.Factory.DebugFragment& P0) { }
        // RVA: 0x057CE360  token: 0x6000DB4
        public System.Void __Gen_Wrap_141(Beyond.Gameplay.Factory.EvtDestroyUnit& P0) { }
        // RVA: 0x057CE484  token: 0x6000DB5
        public System.Void __Gen_Wrap_142(Beyond.Gameplay.Factory.ShowStateUI& P0) { }
        // RVA: 0x057CE59C  token: 0x6000DB6
        public System.Void __Gen_Wrap_143(Beyond.Gameplay.Factory.ShowNameUI& P0) { }
        // RVA: 0x057CE6B4  token: 0x6000DB7
        public System.Void __Gen_Wrap_144(Beyond.Gameplay.Factory.HasRenderer& P0) { }
        // RVA: 0x057CE7CC  token: 0x6000DB8
        public System.Void __Gen_Wrap_145(Beyond.Gameplay.Factory.EvtUpdatePipeEffect& P0) { }
        // RVA: 0x057CE8E8  token: 0x6000DB9
        public System.Void __Gen_Wrap_146(Beyond.Gameplay.Factory.EvtChangeTemplate& P0) { }
        // RVA: 0x057CEA84  token: 0x6000DBA
        public System.Void __Gen_Wrap_147(Beyond.Gameplay.Factory.EvtCreateUnitRenderer& P0) { }
        // RVA: 0x057CEBA0  token: 0x6000DBB
        public System.Void __Gen_Wrap_148(Beyond.Gameplay.Factory.EvtUpdateStatusEffect& P0) { }
        // RVA: 0x057CECBC  token: 0x6000DBC
        public System.Void __Gen_Wrap_149(Beyond.Gameplay.Factory.EvtPendingCreateRenderer& P0) { }
        // RVA: 0x057CEF38  token: 0x6000DBD
        public System.Void __Gen_Wrap_150(Beyond.Gameplay.Factory.EvtUpdateRendererProperty& P0) { }
        // RVA: 0x057CF05C  token: 0x6000DBE
        public System.Void __Gen_Wrap_151(Beyond.Gameplay.Factory.EvtStatusChange& P0) { }
        // RVA: 0x057CF18C  token: 0x6000DBF
        public System.Void __Gen_Wrap_152(Beyond.Gameplay.Factory.EvtCreateInteract& P0) { }
        // RVA: 0x057CF2B0  token: 0x6000DC0
        public System.Void __Gen_Wrap_153(Beyond.Gameplay.Factory.EvtVatUpdate& P0) { }
        // RVA: 0x057CF3D4  token: 0x6000DC1
        public System.Void __Gen_Wrap_154(Beyond.Gameplay.Factory.EvtUpdatePedestalColorLUT& P0) { }
        // RVA: 0x057CF504  token: 0x6000DC2
        public System.Void __Gen_Wrap_155(Beyond.Gameplay.Factory.EvtAudio& P0) { }
        // RVA: 0x057CF628  token: 0x6000DC3
        public System.Void __Gen_Wrap_156(Beyond.Gameplay.Factory.AudioFragment& P0) { }
        // RVA: 0x057CF758  token: 0x6000DC4
        public System.Void __Gen_Wrap_157(Beyond.Gameplay.Factory.ReleaseTagFragment& P0) { }
        // RVA: 0x057CF870  token: 0x6000DC5
        public System.Void __Gen_Wrap_158(Beyond.Gameplay.Factory.CurMapUnitTag& P0) { }
        // RVA: 0x057CF988  token: 0x6000DC6
        public Beyond.Gameplay.Factory.UnitFragment __Gen_Wrap_159(System.UInt32 P0, System.Object P1, System.Int32 P2, Unity.Mathematics.bool2 P3, System.Int32 P4, System.UInt32 P5, System.Object P6, System.Boolean P7, System.Boolean P8, System.Boolean P9, System.Int64 P10, System.Boolean P11, System.Object P12) { }
        // RVA: 0x057CFD8C  token: 0x6000DC7
        public System.Void __Gen_Wrap_160(Beyond.Gameplay.Factory.UnitFragment& P0) { }
        // RVA: 0x057CFFC0  token: 0x6000DC8
        public System.Void __Gen_Wrap_161(Beyond.Gameplay.Factory.UnitRenderPipeLogisticsFigureReplaceFragment& P0) { }
        // RVA: 0x057D00D8  token: 0x6000DC9
        public System.Void __Gen_Wrap_162(Beyond.Gameplay.Factory.BusRenderFragment& P0) { }
        // RVA: 0x057D01F0  token: 0x6000DCA
        public System.Void __Gen_Wrap_163(Beyond.Gameplay.Factory.UnitRenderBuildingFragment& P0) { }
        // RVA: 0x057D0308  token: 0x6000DCB
        public System.Void __Gen_Wrap_164(Beyond.Gameplay.Factory.UnitRenderPedestalFragment& P0) { }
        // RVA: 0x057D0420  token: 0x6000DCC
        public System.Void __Gen_Wrap_165(Beyond.Gameplay.Factory.UnitRendererRegularFragment& P0) { }
        // RVA: 0x057D0538  token: 0x6000DCD
        public System.Void __Gen_Wrap_166(Beyond.Gameplay.Factory.UnitOnlyRendererFragment& P0) { }
        // RVA: 0x057D0650  token: 0x6000DCE
        public System.Void __Gen_Wrap_167(Beyond.Gameplay.Factory.FakeUnitFragment& P0) { }
        // RVA: 0x057D0768  token: 0x6000DCF
        public System.Void __Gen_Wrap_168(Beyond.Gameplay.Factory.UIUnitFragment& P0) { }
        // RVA: 0x057D0880  token: 0x6000DD0
        public System.Void __Gen_Wrap_169(Beyond.Gameplay.Factory.GuideHintFragment& P0) { }
        // RVA: 0x057D0B08  token: 0x6000DD1
        public System.Void __Gen_Wrap_170(Beyond.Gameplay.Factory.UnitPreviewFragment& P0) { }
        // RVA: 0x057D0C38  token: 0x6000DD2
        public System.Void __Gen_Wrap_171(Beyond.Gameplay.Factory.ConveyorRegularFragment& P0) { }
        // RVA: 0x057D0D50  token: 0x6000DD3
        public System.Void __Gen_Wrap_172(Beyond.Gameplay.Factory.ConveyorGuideFragment& P0) { }
        // RVA: 0x057D0E68  token: 0x6000DD4
        public System.Void __Gen_Wrap_173(Beyond.Gameplay.Factory.PipeRegularFragment& P0) { }
        // RVA: 0x057D0F80  token: 0x6000DD5
        public System.Void __Gen_Wrap_174(Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment& P0) { }
        // RVA: 0x057D10AC  token: 0x6000DD6
        public System.Void __Gen_Wrap_175(Beyond.Gameplay.Factory.PipePreviewRendererFragment& P0) { }
        // RVA: 0x057D11DC  token: 0x6000DD7
        public System.Void __Gen_Wrap_176(Beyond.Gameplay.Factory.PipePreviewFragment& P0) { }
        // RVA: 0x057D12F4  token: 0x6000DD8
        public System.Void __Gen_Wrap_177(Beyond.Gameplay.Factory.FigureRenderFragment& P0) { }
        // RVA: 0x057D1424  token: 0x6000DD9
        public System.Void __Gen_Wrap_178(Beyond.Gameplay.Factory.FigureRenderLeftFragment& P0) { }
        // RVA: 0x057D153C  token: 0x6000DDA
        public System.Void __Gen_Wrap_179(Beyond.Gameplay.Factory.FigureRenderRightFragment& P0) { }
        // RVA: 0x057D1798  token: 0x6000DDB
        public System.Void __Gen_Wrap_180(Beyond.Gameplay.Factory.FigureRenderMidFragment& P0) { }
        // RVA: 0x057D18B0  token: 0x6000DDC
        public System.Void __Gen_Wrap_181(Beyond.Gameplay.Factory.FigureRenderPipeHolderFragment& P0) { }
        // RVA: 0x057D19C8  token: 0x6000DDD
        public System.Void __Gen_Wrap_182(Beyond.Gameplay.Factory.FluidConsumeFragment& P0) { }
        // RVA: 0x057D1AE4  token: 0x6000DDE
        public System.Void __Gen_Wrap_183(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4) { }
        // RVA: 0x057D1D24  token: 0x6000DDF
        public System.Void __Gen_Wrap_184(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x057D1F44  token: 0x6000DE0
        public System.Boolean __Gen_Wrap_185(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Int32 P1, System.Int32& P2, System.Int32& P3, System.Single& P4, System.Int32& P5, System.Int32& P6) { }
        // RVA: 0x057D226C  token: 0x6000DE1
        public System.Boolean __Gen_Wrap_186(Beyond.Gameplay.Factory.FluidContainerFragment& P0) { }
        // RVA: 0x057D2470  token: 0x6000DE2
        public System.Void __Gen_Wrap_187(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Single P1) { }
        // RVA: 0x057D266C  token: 0x6000DE3
        public System.ValueTuple<System.Int32,System.UInt32> __Gen_Wrap_188(Beyond.Gameplay.Factory.FluidContainerFragment& P0) { }
        // RVA: 0x057D286C  token: 0x6000DE4
        public System.Void __Gen_Wrap_189(Beyond.Gameplay.Factory.FluidContainerFragment& P0) { }
        // RVA: 0x057D2BC8  token: 0x6000DE5
        public System.String __Gen_Wrap_190(Beyond.Gameplay.Factory.FluidContainerFragment& P0) { }
        // RVA: 0x057D2DC8  token: 0x6000DE6
        public System.Void __Gen_Wrap_191(Beyond.Gameplay.Factory.FluidPumpInFragment& P0) { }
        // RVA: 0x057D2EE0  token: 0x6000DE7
        public System.Void __Gen_Wrap_192(Beyond.Gameplay.Factory.FluidPumpOutFragment& P0) { }
        // RVA: 0x057D2FF8  token: 0x6000DE8
        public System.Void __Gen_Wrap_193(Beyond.Gameplay.Factory.FluidReactionFragment& P0) { }
        // RVA: 0x057D3110  token: 0x6000DE9
        public System.Void __Gen_Wrap_194(Beyond.Gameplay.Factory.FluidSprayFragment& P0) { }
        // RVA: 0x057D322C  token: 0x6000DEA
        public System.Void __Gen_Wrap_195(Beyond.Gameplay.Factory.FormulaManualFragment& P0) { }
        // RVA: 0x057D335C  token: 0x6000DEB
        public System.Void __Gen_Wrap_196(Beyond.Gameplay.Factory.OutOfBufferWarning& P0) { }
        // RVA: 0x057D3494  token: 0x6000DEC
        public System.String __Gen_Wrap_197(Beyond.Gameplay.Factory.OutOfBufferWarning& P0) { }
        // RVA: 0x057D35DC  token: 0x6000DED
        public System.Boolean __Gen_Wrap_198(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D3854  token: 0x6000DEE
        public System.Void __Gen_Wrap_199(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D3D78  token: 0x6000DEF
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> __Gen_Wrap_200(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D4018  token: 0x6000DF0
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.OutputRendererInfo> __Gen_Wrap_201(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D42B8  token: 0x6000DF1
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<UnityEngine.Matrix4x4> __Gen_Wrap_202(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D4558  token: 0x6000DF2
        public Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info& __Gen_Wrap_203(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2) { }
        // RVA: 0x057D4814  token: 0x6000DF3
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_204(Beyond.Gameplay.Factory.GlobalEnv& P0, System.Int32 P1) { }
        // RVA: 0x057D4AD8  token: 0x6000DF4
        public System.Int64 __Gen_Wrap_205(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1) { }
        // RVA: 0x057D4D64  token: 0x6000DF5
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_206(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2) { }
        // RVA: 0x057D503C  token: 0x6000DF6
        public System.Void __Gen_Wrap_207(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1) { }
        // RVA: 0x057D52B8  token: 0x6000DF7
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest> __Gen_Wrap_208(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D5544  token: 0x6000DF8
        public System.Boolean __Gen_Wrap_209(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition P0, System.Int32 P1, System.Byte& P2, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType& P3) { }
        // RVA: 0x0561A558  token: 0x6000DF9
        public System.Byte __Gen_Wrap_210(System.UInt32 P0, System.Int32 P1) { }
        // RVA: 0x057D58B8  token: 0x6000DFA
        public System.Void __Gen_Wrap_211(Beyond.Gameplay.Factory.GlobalEnv& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, UnityEngine.HyperGryph.ECS.Entity P2, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest& P3) { }
        // RVA: 0x057D5C38  token: 0x6000DFB
        public System.Void __Gen_Wrap_212(Beyond.Gameplay.Factory.GlobalEnv& P0, UnityEngine.HyperGryph.ECS.Entity P1, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest P2) { }
        // RVA: 0x057D5F20  token: 0x6000DFC
        public Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData> __Gen_Wrap_213(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D61A8  token: 0x6000DFD
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData& __Gen_Wrap_214(Beyond.Gameplay.Factory.GlobalEnv& P0, System.Int32 P1) { }
        // RVA: 0x057D6444  token: 0x6000DFE
        public System.Int32 __Gen_Wrap_215(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x057D66BC  token: 0x6000DFF
        public System.Void __Gen_Wrap_216(Beyond.Gameplay.Factory.HealthPoleFragment& P0) { }
        // RVA: 0x057D67E0  token: 0x6000E00
        public System.Void __Gen_Wrap_217(Beyond.Gameplay.Factory.InventoryFragment& P0) { }
        // RVA: 0x057D68F8  token: 0x6000E01
        public System.Void __Gen_Wrap_218(Beyond.Gameplay.Factory.LiquidPurifierFragment& P0) { }
        // RVA: 0x057D6A10  token: 0x6000E02
        public System.Void __Gen_Wrap_219(Beyond.Gameplay.Factory.LogisticEffectFragment& P0) { }
        // RVA: 0x057D6CD0  token: 0x6000E03
        public System.Void __Gen_Wrap_220(Beyond.Gameplay.Factory.LogisticEntityBindFragment& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.UInt32 P2) { }
        // RVA: 0x057D6E7C  token: 0x6000E04
        public System.Boolean __Gen_Wrap_221(Beyond.Gameplay.Factory.LogisticEntityBindFragment& P0, UnityEngine.HyperGryph.ECS.Entity& P1) { }
        // RVA: 0x057D7034  token: 0x6000E05
        public System.Void __Gen_Wrap_222(Beyond.Gameplay.Factory.LogisticEntityBindFragment& P0) { }
        // RVA: 0x057D7178  token: 0x6000E06
        public System.Void __Gen_Wrap_223(Beyond.Gameplay.Factory.MapGridRendererFragment& P0) { }
        // RVA: 0x057D7290  token: 0x6000E07
        public System.Void __Gen_Wrap_224(Beyond.Gameplay.Factory.OutputFragment& P0) { }
        // RVA: 0x057D7484  token: 0x6000E08
        public Unity.Mathematics.float4& __Gen_Wrap_225(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1) { }
        // RVA: 0x057D76A0  token: 0x6000E09
        public System.Void __Gen_Wrap_226(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, Unity.Mathematics.float4 P2) { }
        // RVA: 0x057D78D4  token: 0x6000E0A
        public System.Void __Gen_Wrap_227(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, UnityEngine.Color P2) { }
        // RVA: 0x057D7B1C  token: 0x6000E0B
        public System.Void __Gen_Wrap_228(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, UnityEngine.RectInt P2) { }
        // RVA: 0x057D7D64  token: 0x6000E0C
        public System.Boolean __Gen_Wrap_229(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1) { }
        // RVA: 0x057D8144  token: 0x6000E0D
        public System.Void __Gen_Wrap_230(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x057D8364  token: 0x6000E0E
        public System.Boolean __Gen_Wrap_231(Beyond.Gameplay.Factory.OutputFragment& P0) { }
        // RVA: 0x057D8554  token: 0x6000E0F
        public System.Void __Gen_Wrap_232(Beyond.Gameplay.Factory.OutputUIRendererFragment& P0) { }
        // RVA: 0x057D866C  token: 0x6000E10
        public System.Void __Gen_Wrap_233(Beyond.Gameplay.Factory.PedestalLightFlashFragment& P0) { }
        // RVA: 0x057D87CC  token: 0x6000E11
        public System.Boolean __Gen_Wrap_234(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0) { }
        // RVA: 0x057D8A10  token: 0x6000E12
        public System.Void __Gen_Wrap_235(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1, System.Single P2) { }
        // RVA: 0x057D8C88  token: 0x6000E13
        public System.Void __Gen_Wrap_236(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1, System.Boolean P2) { }
        // RVA: 0x057D8F00  token: 0x6000E14
        public System.Void __Gen_Wrap_237(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1, UnityEngine.Color P2) { }
        // RVA: 0x057D91A0  token: 0x6000E15
        public System.Single __Gen_Wrap_238(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1) { }
        // RVA: 0x057D93F8  token: 0x6000E16
        public System.Boolean __Gen_Wrap_239(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1) { }
        // RVA: 0x057D9850  token: 0x6000E17
        public Unity.Mathematics.float4 __Gen_Wrap_240(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1) { }
        // RVA: 0x057D9AD8  token: 0x6000E18
        public System.Void __Gen_Wrap_241(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0) { }
        // RVA: 0x057D9D0C  token: 0x6000E19
        public System.Void __Gen_Wrap_242(Beyond.Gameplay.Factory.PipeEffectFragment& P0) { }
        // RVA: 0x057D9EF0  token: 0x6000E1A
        public System.Boolean __Gen_Wrap_243(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Collections.NativeList<Unity.Mathematics.float3>& P2, Unity.Collections.NativeList<Unity.Mathematics.float3>& P3, Unity.Collections.NativeList<System.Byte>& P4) { }
        // RVA: 0x057DA3D4  token: 0x6000E1B
        public System.Void __Gen_Wrap_244(Beyond.Gameplay.Factory.GlobalEnv& P0, System.Int32 P1, System.UInt32 P2, System.Single P3, System.Boolean P4, System.Single P5, System.Boolean P6, System.Single P7) { }
        // RVA: 0x057DA6D0  token: 0x6000E1C
        public System.ValueTuple<System.Int32[],System.Int32> __Gen_Wrap_245(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2) { }
        // RVA: 0x057DA98C  token: 0x6000E1D
        public System.Boolean __Gen_Wrap_246(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Mathematics.float2 P2, System.UInt32& P3, System.Int32& P4) { }
        // RVA: 0x057DADA8  token: 0x6000E1E
        public System.Boolean __Gen_Wrap_247(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5) { }
        // RVA: 0x057DB168  token: 0x6000E1F
        public System.Boolean __Gen_Wrap_248(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, Beyond.PoolCore.PooledList<System.Int32>& P6) { }
        // RVA: 0x057DB584  token: 0x6000E20
        public System.Boolean __Gen_Wrap_249(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, System.ValueTuple<System.UInt32,System.Int32>[,]& P6) { }
        // RVA: 0x057DBB20  token: 0x6000E21
        public System.Void __Gen_Wrap_250(Beyond.Gameplay.Factory.PipeFragment& P0) { }
        // RVA: 0x057DBCD0  token: 0x6000E22
        public System.Void __Gen_Wrap_251(Beyond.Gameplay.Factory.PipeHolderFragment& P0) { }
        // RVA: 0x057DBE00  token: 0x6000E23
        public System.Void __Gen_Wrap_252(Beyond.Gameplay.Factory.PipeLogisticsUnitFragment& P0) { }
        // RVA: 0x057DBF18  token: 0x6000E24
        public System.Void __Gen_Wrap_253(Beyond.Gameplay.Factory.PipeComRenderFragment& P0) { }
        // RVA: 0x057DC048  token: 0x6000E25
        public System.Void __Gen_Wrap_254(Beyond.Gameplay.Factory.PipeRenderFragment& P0) { }
        // RVA: 0x057DC1AC  token: 0x6000E26
        public System.Void __Gen_Wrap_255(Beyond.Gameplay.Factory.PipeTrackRenderFragment& P0) { }
        // RVA: 0x057DC2DC  token: 0x6000E27
        public System.Boolean __Gen_Wrap_256(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.UInt32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.UInt32 P5, System.Boolean& P6) { }
        // RVA: 0x057DC4EC  token: 0x6000E28
        public System.Boolean __Gen_Wrap_257(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.UInt32 P1, System.Boolean P2, System.Object P3) { }
        // RVA: 0x057DC68C  token: 0x6000E29
        public System.Boolean __Gen_Wrap_258(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.Boolean P1, System.Object P2, System.Boolean P3) { }
        // RVA: 0x057DC840  token: 0x6000E2A
        public System.Void __Gen_Wrap_259(Beyond.Gameplay.Factory.ComplexPortFragment& P0, Unity.Mathematics.float3 P1, Unity.Mathematics.float3 P2, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& P3, Beyond.Gameplay.Factory.UnitConfigFragment& P4, System.Single P5) { }
        // RVA: 0x057DCDD0  token: 0x6000E2B
        public System.Boolean __Gen_Wrap_260(Beyond.Gameplay.Factory.ComplexPortFragment& P0) { }
        // RVA: 0x057DCF38  token: 0x6000E2C
        public System.Boolean __Gen_Wrap_261(Beyond.Gameplay.Factory.PortData& P0, Beyond.Gameplay.Factory.PortData P1) { }
        // RVA: 0x057DD0CC  token: 0x6000E2D
        public System.Boolean __Gen_Wrap_262(Beyond.Gameplay.Factory.ComplexPortFragment& P0, Beyond.Gameplay.Factory.ComplexPortFragment P1) { }
        // RVA: 0x057DD264  token: 0x6000E2E
        public System.Boolean __Gen_Wrap_263(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.Object P1) { }
        // RVA: 0x057DD3D4  token: 0x6000E2F
        public System.Int32 __Gen_Wrap_264(Beyond.Gameplay.Factory.ComplexPortFragment& P0) { }
        // RVA: 0x057DD528  token: 0x6000E30
        public System.Boolean __Gen_Wrap_265(Beyond.Gameplay.Factory.ComplexPortFragment P0, Beyond.Gameplay.Factory.ComplexPortFragment P1) { }
        // RVA: 0x057DD670  token: 0x6000E31
        public System.String __Gen_Wrap_266(Beyond.Gameplay.Factory.PortData& P0) { }
        // RVA: 0x057DD7D4  token: 0x6000E32
        public System.String __Gen_Wrap_267(Beyond.Gameplay.Factory.ComplexPortFragment& P0) { }
        // RVA: 0x057DD938  token: 0x6000E33
        public System.Void __Gen_Wrap_268(Beyond.Gameplay.Factory.ComplexPortFragment& P0) { }
        // RVA: 0x057DDA7C  token: 0x6000E34
        public Unity.Mathematics.float4x4 __Gen_Wrap_269(Beyond.Gameplay.Factory.PortData& P0) { }
        // RVA: 0x057DDD04  token: 0x6000E35
        public System.Boolean __Gen_Wrap_270(Beyond.Gameplay.Factory.PortData& P0, System.Object P1) { }
        // RVA: 0x057DDE70  token: 0x6000E36
        public System.Int32 __Gen_Wrap_271(Beyond.Gameplay.Factory.PortData& P0) { }
        // RVA: 0x057DDFC0  token: 0x6000E37
        public System.Boolean __Gen_Wrap_272(Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1) { }
        // RVA: 0x057DE108  token: 0x6000E38
        public System.Void __Gen_Wrap_273(Beyond.Gameplay.Factory.PortPreviewUIRendererFragment& P0) { }
        // RVA: 0x057DE220  token: 0x6000E39
        public System.Void __Gen_Wrap_274(Beyond.Gameplay.Factory.PortStatusUIFragment& P0) { }
        // RVA: 0x057DE338  token: 0x6000E3A
        public System.Void __Gen_Wrap_275(Beyond.Gameplay.Factory.PowerPoleFragment& P0) { }
        // RVA: 0x057DE43C  token: 0x6000E3B
        public System.Void __Gen_Wrap_276(Beyond.Gameplay.Factory.ProducerFragment& P0) { }
        // RVA: 0x057DE570  token: 0x6000E3C
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_277(Beyond.Gameplay.Factory.SharedDataFragment& P0) { }
        // RVA: 0x057DE6B4  token: 0x6000E3D
        public System.Void __Gen_Wrap_278(Beyond.Gameplay.Factory.SharedDataFragment& P0) { }
        // RVA: 0x057DE7D8  token: 0x6000E3E
        public Beyond.Gameplay.Factory.SocialFragment __Gen_Wrap_279(System.UInt64 P0, System.UInt32 P1, System.UInt64 P2, System.Int64 P3, System.Int64 P4, System.UInt32 P5, System.Boolean P6) { }
        // RVA: 0x057DEABC  token: 0x6000E3F
        public System.Boolean __Gen_Wrap_280(Beyond.Gameplay.Factory.SocialFragment& P0) { }
        // RVA: 0x057DEC34  token: 0x6000E40
        public System.Void __Gen_Wrap_281(Beyond.Gameplay.Factory.SocialFragment& P0) { }
        // RVA: 0x057DED88  token: 0x6000E41
        public System.String __Gen_Wrap_282(Beyond.Gameplay.Factory.SignData& P0) { }
        // RVA: 0x057DEEEC  token: 0x6000E42
        public System.Single __Gen_Wrap_283(System.Object P0, Unity.Mathematics.uint3 P1) { }
        // RVA: 0x057DF014  token: 0x6000E43
        public System.Void __Gen_Wrap_284(System.Object P0, UnityEngine.HyperGryph.ECS.Entity P1, Unity.Mathematics.uint3 P2) { }
        // RVA: 0x057DF160  token: 0x6000E44
        public System.Void __Gen_Wrap_285(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, UnityEngine.HyperGryph.ECS.Entity P2) { }
        // RVA: 0x057DF2E0  token: 0x6000E45
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_286(Unity.Mathematics.float4x4 P0) { }
        // RVA: 0x057DF420  token: 0x6000E46
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_287(Unity.Mathematics.float3 P0, Unity.Mathematics.quaternion P1) { }
        // RVA: 0x057DF58C  token: 0x6000E47
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_288(Unity.Mathematics.float3 P0, Unity.Mathematics.quaternion P1, System.Single P2) { }
        // RVA: 0x057DF71C  token: 0x6000E48
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_289(Unity.Mathematics.float3 P0) { }
        // RVA: 0x057DF994  token: 0x6000E49
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_290(System.Single P0, System.Single P1, System.Single P2) { }
        // RVA: 0x057DFAC4  token: 0x6000E4A
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_291(Unity.Mathematics.quaternion P0) { }
        // RVA: 0x057DFBEC  token: 0x6000E4B
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_292(System.Single P0) { }
        // RVA: 0x057DFCF0  token: 0x6000E4C
        public System.String __Gen_Wrap_293(Beyond.Gameplay.Factory.LocalTransform& P0) { }
        // RVA: 0x057DFE40  token: 0x6000E4D
        public Unity.Mathematics.float3 __Gen_Wrap_294(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.float3 P1) { }
        // RVA: 0x057E000C  token: 0x6000E4E
        public Unity.Mathematics.float3 __Gen_Wrap_295(Beyond.Gameplay.Factory.LocalTransform& P0) { }
        // RVA: 0x057E0180  token: 0x6000E4F
        public Unity.Mathematics.quaternion __Gen_Wrap_296(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.quaternion P1) { }
        // RVA: 0x057E0340  token: 0x6000E50
        public System.Single __Gen_Wrap_297(Beyond.Gameplay.Factory.LocalTransform& P0, System.Single P1) { }
        // RVA: 0x057E04B0  token: 0x6000E51
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_298(Beyond.Gameplay.Factory.LocalTransform& P0, Beyond.Gameplay.Factory.LocalTransform& P1) { }
        // RVA: 0x057E0674  token: 0x6000E52
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_299(Beyond.Gameplay.Factory.LocalTransform& P0) { }
        // RVA: 0x057E0A0C  token: 0x6000E53
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_300(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.float3 P1) { }
        // RVA: 0x057E0BCC  token: 0x6000E54
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_301(Beyond.Gameplay.Factory.LocalTransform& P0, System.Single P1, System.Single P2, System.Single P3) { }
        // RVA: 0x057E0D74  token: 0x6000E55
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_302(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.quaternion P1) { }
        // RVA: 0x057E0F30  token: 0x6000E56
        public Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_303(Beyond.Gameplay.Factory.LocalTransform& P0, System.Single P1) { }
        // RVA: 0x057E10C4  token: 0x6000E57
        public System.Boolean __Gen_Wrap_304(Beyond.Gameplay.Factory.LocalTransform& P0, Beyond.Gameplay.Factory.LocalTransform& P1) { }
        // RVA: 0x057E124C  token: 0x6000E58
        public System.Void __Gen_Wrap_305(Beyond.Gameplay.Factory.LocalTransform& P0) { }
        // RVA: 0x057E137C  token: 0x6000E59
        public System.Void __Gen_Wrap_306(Beyond.Gameplay.Factory.Root& P0) { }
        // RVA: 0x057E1480  token: 0x6000E5A
        public System.Void __Gen_Wrap_307(Beyond.Gameplay.Factory.Parent& P0) { }
        // RVA: 0x057E159C  token: 0x6000E5B
        public System.Void __Gen_Wrap_308(Beyond.Gameplay.Factory.Child& P0) { }
        // RVA: 0x057E1780  token: 0x6000E5C
        public System.Boolean __Gen_Wrap_309(Beyond.Gameplay.Factory.LocalToWorld& P0, Unity.Mathematics.float4x4 P1, System.Int32 P2) { }
        // RVA: 0x057E1B58  token: 0x6000E5D
        public Unity.Mathematics.float3 __Gen_Wrap_310(Beyond.Gameplay.Factory.LocalToWorld& P0) { }
        // RVA: 0x057E1D8C  token: 0x6000E5E
        public System.Void __Gen_Wrap_311(Beyond.Gameplay.Factory.LocalToWorld& P0) { }
        // RVA: 0x057E1F64  token: 0x6000E5F
        public System.Void __Gen_Wrap_312(Beyond.Gameplay.Factory.UdPipeFragment& P0) { }
        // RVA: 0x057E2088  token: 0x6000E60
        public System.Void __Gen_Wrap_313(Beyond.Gameplay.Factory.UnitConfigFragment& P0) { }
        // RVA: 0x057E21FC  token: 0x6000E61
        public System.String __Gen_Wrap_314(Beyond.Gameplay.Factory.FactoryUnitExtendConfig& P0) { }
        // RVA: 0x057E237C  token: 0x6000E62
        public System.Void __Gen_Wrap_315(Beyond.Gameplay.Factory.UnitInteractFragment& P0) { }
        // RVA: 0x057E2498  token: 0x6000E63
        public System.Void __Gen_Wrap_316(Beyond.Gameplay.Factory.UnitRenderFragment& P0) { }
        // RVA: 0x057E260C  token: 0x6000E64
        public System.Void __Gen_Wrap_317(Beyond.Gameplay.Factory.RenderLookAtFragment& P0) { }
        // RVA: 0x057E2748  token: 0x6000E65
        public System.Void __Gen_Wrap_318(Beyond.Gameplay.Factory.ChapterTagFragment& P0) { }
        // RVA: 0x057E286C  token: 0x6000E66
        public System.Void __Gen_Wrap_319(Beyond.Gameplay.Factory.UnitStatusFragment& P0) { }
        // RVA: 0x057E2B98  token: 0x6000E67
        public System.Void __Gen_Wrap_320(Beyond.Gameplay.Factory.UnitOverrideStatusFragment& P0) { }
        // RVA: 0x057E2CB0  token: 0x6000E68
        public System.Void __Gen_Wrap_321(Beyond.Gameplay.Factory.UnitStatusEffectFragment& P0, Beyond.Gameplay.Factory.BuildingStatus P1, System.Object P2) { }
        // RVA: 0x057E2E80  token: 0x6000E69
        public Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> __Gen_Wrap_322(Beyond.Gameplay.Factory.UnitStatusEffectFragment& P0, Beyond.GEnums.FacBuildingState P1) { }
        // RVA: 0x057E30C4  token: 0x6000E6A
        public System.Void __Gen_Wrap_323(Beyond.Gameplay.Factory.UnitStatusEffectFragment& P0) { }
        // RVA: 0x057E3250  token: 0x6000E6B
        public System.Void __Gen_Wrap_324(Beyond.Gameplay.Factory.UnitStatusUIRendererFragment& P0) { }
        // RVA: 0x057E3368  token: 0x6000E6C
        public System.Boolean __Gen_Wrap_325(Beyond.Gameplay.Factory.UnitTransFragment& P0, Unity.Mathematics.float3 P1, System.Boolean P2) { }
        // RVA: 0x057E3518  token: 0x6000E6D
        public System.Void __Gen_Wrap_326(Beyond.Gameplay.Factory.UnitTransFragment& P0) { }
        // RVA: 0x057E3658  token: 0x6000E6E
        public System.Void __Gen_Wrap_327(Beyond.Gameplay.Factory.ValveFragment& P0) { }
        // RVA: 0x057E3788  token: 0x6000E6F
        public System.Void __Gen_Wrap_328(Beyond.Gameplay.Factory.BoxValve& P0) { }
        // RVA: 0x057E38A0  token: 0x6000E70
        public System.Void __Gen_Wrap_329(Beyond.Gameplay.Factory.FluidValve& P0) { }
        // RVA: 0x057E3B18  token: 0x6000E71
        public Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_330(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1) { }
        // RVA: 0x057E3CA8  token: 0x6000E72
        public System.Boolean __Gen_Wrap_331(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x057E3EEC  token: 0x6000E73
        public System.Void __Gen_Wrap_332(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int32 P2, UnityEngine.HyperGryph.ECS.Entity P3) { }
        // RVA: 0x057E4160  token: 0x6000E74
        public System.Int32 __Gen_Wrap_333(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0) { }
        // RVA: 0x057E4310  token: 0x6000E75
        public System.Int32 __Gen_Wrap_334(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1) { }
        // RVA: 0x057E44DC  token: 0x6000E76
        public System.Void __Gen_Wrap_335(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x057E46A8  token: 0x6000E77
        public System.UInt64[] __Gen_Wrap_336(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0) { }
        // RVA: 0x057E486C  token: 0x6000E78
        public System.Void __Gen_Wrap_337(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.Entity P2) { }
        // RVA: 0x057E4A60  token: 0x6000E79
        public UnityEngine.HyperGryph.ECS.Entity[] __Gen_Wrap_338(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1) { }
        // RVA: 0x057E4C3C  token: 0x6000E7A
        public System.Void __Gen_Wrap_339(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int32 P2, Beyond.PoolCore.PooledList<System.UInt32>& P3, Beyond.PoolCore.PooledList<System.UInt32>& P4, Beyond.PoolCore.PooledList<UnityEngine.HyperGryph.ECS.Entity>& P5) { }
        // RVA: 0x057E50CC  token: 0x6000E7B
        public System.UInt64 __Gen_Wrap_340(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1) { }
        // RVA: 0x057E5298  token: 0x6000E7C
        public UnityEngine.HyperGryph.ECS.Entity __Gen_Wrap_341(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x057E5488  token: 0x6000E7D
        public Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> __Gen_Wrap_342(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1) { }
        // RVA: 0x057E567C  token: 0x6000E7E
        public Beyond.Gameplay.Factory.BlueprintSlotInfo __Gen_Wrap_343() { }
        // RVA: 0x057E57B0  token: 0x6000E7F
        public System.String __Gen_Wrap_344(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0) { }
        // RVA: 0x057E5960  token: 0x6000E80
        public System.String __Gen_Wrap_345(Beyond.Gameplay.Factory.ConveyorRendererInfo& P0) { }
        // RVA: 0x057E5AD4  token: 0x6000E81
        public System.Boolean __Gen_Wrap_346(Beyond.Gameplay.Factory.UnitId& P0, Beyond.Gameplay.Factory.UnitId P1) { }
        // RVA: 0x057E5C3C  token: 0x6000E82
        public System.Boolean __Gen_Wrap_347(Beyond.Gameplay.Factory.UnitId& P0, System.Object P1) { }
        // RVA: 0x057E5D80  token: 0x6000E83
        public System.Int32 __Gen_Wrap_348(Beyond.Gameplay.Factory.UnitId& P0) { }
        // RVA: 0x057E5EB8  token: 0x6000E84
        public System.Boolean __Gen_Wrap_349(Beyond.Gameplay.Factory.Visibility& P0, Beyond.Gameplay.Factory.Visibility.EFlag P1) { }
        // RVA: 0x057E6198  token: 0x6000E85
        public System.Boolean __Gen_Wrap_350(Beyond.Gameplay.Factory.Visibility& P0) { }
        // RVA: 0x057E62F0  token: 0x6000E86
        public System.Boolean __Gen_Wrap_351(Beyond.Gameplay.Factory.Visibility& P0, Beyond.Gameplay.Factory.Visibility.EFlag P1, System.Boolean P2) { }
        // RVA: 0x057E647C  token: 0x6000E87
        public System.Void __Gen_Wrap_352(Beyond.Gameplay.Factory.WireRendererFragment& P0) { }
        // RVA: 0x057E6594  token: 0x6000E88
        public System.Void __Gen_Wrap_353(Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData& P0) { }
        // RVA: 0x057E6734  token: 0x6000E89
        public System.Void __Gen_Wrap_354(Beyond.Gameplay.Factory.GlobalSharedData& P0) { }
        // RVA: 0x057E684C  token: 0x6000E8A
        public System.Void __Gen_Wrap_355(Beyond.Gameplay.Factory.GlobalSharedData.CullingGlobalSetting& P0) { }
        // RVA: 0x057E699C  token: 0x6000E8B
        public System.Single __Gen_Wrap_356(Beyond.Gameplay.Factory.GlobalSharedData.CullingGlobalSetting& P0) { }
        // RVA: 0x057E6AFC  token: 0x6000E8C
        public System.Void __Gen_Wrap_357(Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting& P0) { }
        // RVA: 0x057E6C70  token: 0x6000E8D
        public System.Boolean __Gen_Wrap_358(Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting& P0) { }
        // RVA: 0x057E6DF4  token: 0x6000E8E
        public System.Single __Gen_Wrap_359(Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting& P0) { }
        // RVA: 0x057E70E8  token: 0x6000E8F
        public System.Void __Gen_Wrap_360(Beyond.Gameplay.Factory.GlobalSharedData.World3DUiGlobalSetting& P0) { }
        // RVA: 0x057E7224  token: 0x6000E90
        public System.Boolean __Gen_Wrap_361(Beyond.Gameplay.Factory.GlobalSharedData.World3DUiGlobalSetting& P0) { }
        // RVA: 0x057E7370  token: 0x6000E91
        public System.Void __Gen_Wrap_362(Beyond.Gameplay.Factory.GlobalSharedData.CurveGlobalSetting& P0, Beyond.Gameplay.Factory.FPtrNativeCurve& P1, Beyond.Gameplay.Factory.FPtrNativeCurve& P2, Beyond.Gameplay.Factory.FPtrNativeCurve& P3) { }
        // RVA: 0x057E764C  token: 0x6000E92
        public System.Void __Gen_Wrap_363(Beyond.Gameplay.Factory.GlobalSharedData.CurveGlobalSetting& P0, Beyond.Gameplay.Factory.FPtrNativeCurve& P1) { }
        // RVA: 0x057E7830  token: 0x6000E93
        public System.Void __Gen_Wrap_364(Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData& P0, Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& P1, Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& P2) { }
        // RVA: 0x057E7A74  token: 0x6000E94
        public System.Void __Gen_Wrap_365(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Int32 P1) { }
        // RVA: 0x057E7BC4  token: 0x6000E95
        public System.Void __Gen_Wrap_366(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0) { }
        // RVA: 0x057E7CE8  token: 0x6000E96
        public System.Boolean __Gen_Wrap_367(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Int32 P1, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& P2) { }
        // RVA: 0x057E7F04  token: 0x6000E97
        public System.Boolean __Gen_Wrap_368(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Object P1, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig& P2) { }
        // RVA: 0x057E8124  token: 0x6000E98
        public System.Void __Gen_Wrap_369(System.Object P0, Beyond.Gameplay.Factory.FactoryUnitPortConfig& P1, System.Int32 P2) { }
        // RVA: 0x057E8424  token: 0x6000E99
        public Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig __Gen_Wrap_370(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Object P1) { }
        // RVA: 0x057E861C  token: 0x6000E9A
        public System.Void __Gen_Wrap_371(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Int32 P1, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig P2) { }
        // RVA: 0x057E8810  token: 0x6000E9B
        public System.Void __Gen_Wrap_372(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Object P1, Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig P2) { }
        // RVA: 0x057E8A08  token: 0x6000E9C
        public Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfig __Gen_Wrap_373(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Int32 P1) { }
        // RVA: 0x057E8C00  token: 0x6000E9D
        public System.Boolean __Gen_Wrap_374(Beyond.Gameplay.Factory.GlobalSharedData.UnitPortConfigDB& P0, System.Object P1) { }
        // RVA: 0x057E8D50  token: 0x6000E9E
        public System.Int32 __Gen_Wrap_375(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, Beyond.Gameplay.Factory.LogicEntityState P1, Beyond.Gameplay.Factory.LogicEntityType P2) { }
        // RVA: 0x057E8F30  token: 0x6000E9F
        public System.Void __Gen_Wrap_376(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P1, Beyond.Gameplay.Factory.LogicEntityState P2, Beyond.Gameplay.Factory.LogicEntityType P3) { }
        // RVA: 0x057E9178  token: 0x6000EA0
        public System.Void __Gen_Wrap_377(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P1, Beyond.Gameplay.Factory.LogicEntityState P2, Beyond.Gameplay.Factory.LogicEntityType P3, System.UInt32 P4) { }
        // RVA: 0x057E93C0  token: 0x6000EA1
        public System.Void __Gen_Wrap_378(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting& P0, System.Int32 P1, Beyond.Gameplay.Factory.PerDrawConfig P2) { }
        // RVA: 0x057E9630  token: 0x6000EA2
        public System.Void __Gen_Wrap_379(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting& P0, System.Int32 P1, Beyond.Gameplay.Factory.PerDrawPassConfig P2) { }
        // RVA: 0x057E9A00  token: 0x6000EA3
        public System.Void __Gen_Wrap_380(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, System.Object P1) { }
        // RVA: 0x057E9BBC  token: 0x6000EA4
        public Beyond.Gameplay.Factory.PerDrawPassConfig __Gen_Wrap_381(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting& P0, System.Int32 P1) { }
        // RVA: 0x057E9E08  token: 0x6000EA5
        public Beyond.Gameplay.Factory.PerDrawConfig __Gen_Wrap_382(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting& P0, System.Int32 P1) { }
        // RVA: 0x057EA05C  token: 0x6000EA6
        public System.Void __Gen_Wrap_383(Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalGlobalSetting& P0) { }
        // RVA: 0x057EA1DC  token: 0x6000EA7
        public System.Int32 __Gen_Wrap_384(Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalGlobalSetting& P0) { }
        // RVA: 0x057EA36C  token: 0x6000EA8
        public System.Void __Gen_Wrap_385(Beyond.Gameplay.Factory.GlobalSharedData.UIEffectPathConfig& P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x057EA504  token: 0x6000EA9
        public System.Boolean __Gen_Wrap_386(Beyond.Gameplay.Factory.GlobalSharedData.UIEffectPathConfig& P0, Beyond.GEnums.FacBuildingState P1, Unity.Collections.FixedString32Bytes& P2, Unity.Mathematics.float4& P3, Unity.Mathematics.float4& P4) { }
        // RVA: 0x057EA75C  token: 0x6000EAA
        public System.Void __Gen_Wrap_387(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, System.Object P3) { }
        // RVA: 0x057EAA70  token: 0x6000EAB
        public Unity.Jobs.JobHandle __Gen_Wrap_388(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int64 P2, System.Int64 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6, Beyond.Gameplay.Factory.GlobalEnv& P7, Unity.Jobs.JobHandle P8, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P9) { }
        // RVA: 0x057EAE88  token: 0x6000EAC
        public Unity.Jobs.JobHandle __Gen_Wrap_389(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int64 P2, System.Int64 P3, System.Single P4, System.Int32 P5, System.Int32 P6, System.Int32 P7, Beyond.Gameplay.Factory.GlobalEnv& P8, Unity.Jobs.JobHandle P9, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P10) { }
        // RVA: 0x057EB438  token: 0x6000EAD
        public Unity.Jobs.JobHandle __Gen_Wrap_390(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, System.Int32 P3, System.Int32 P4, System.Int32 P5, Unity.Jobs.JobHandle P6) { }
        // RVA: 0x057EB7E8  token: 0x6000EAE
        public System.Void __Gen_Wrap_391(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2) { }
        // RVA: 0x057EBAD4  token: 0x6000EAF
        public System.Void __Gen_Wrap_392(System.Object P0, Unity.Collections.NativeList<Unity.Jobs.JobHandle>& P1) { }
        // RVA: 0x057EBC24  token: 0x6000EB0
        public System.Void __Gen_Wrap_393(System.Object P0, Unity.Jobs.JobHandle& P1, Unity.Collections.NativeList<Unity.Jobs.JobHandle>& P2) { }
        // RVA: 0x057EBDF0  token: 0x6000EB1
        public System.Boolean __Gen_Wrap_394(System.Object P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x057EC07C  token: 0x6000EB2
        public System.Boolean __Gen_Wrap_395(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1) { }
        // RVA: 0x057EC1DC  token: 0x6000EB3
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.ApplyRender> __Gen_Wrap_396() { }
        // RVA: 0x057EC2A8  token: 0x6000EB4
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> __Gen_Wrap_397() { }
        // RVA: 0x057EC374  token: 0x6000EB5
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath> __Gen_Wrap_398() { }
        // RVA: 0x057EC440  token: 0x6000EB6
        public System.Boolean __Gen_Wrap_399(UnityEngine.HyperGryph.ECS.EntityManager& P0, System.Single P1, System.Single P2, System.Single P3, Beyond.Gameplay.Factory.UnitFragment& P4) { }
        // RVA: 0x057EC820  token: 0x6000EB7
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryBuildingState> __Gen_Wrap_400() { }
        // RVA: 0x057EC8EC  token: 0x6000EB8
        public Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.SetEntityFlashStatue> __Gen_Wrap_401() { }
        // RVA: 0x057EC9B8  token: 0x6000EB9
        public System.Void __Gen_Wrap_402(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, System.IntPtr P1) { }
        // RVA: 0x057ECBE0  token: 0x6000EBA
        public System.Void __Gen_Wrap_403(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, Beyond.Gameplay.Factory.AdditiveEffectFragment& P1, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P2) { }
        // RVA: 0x057ECEFC  token: 0x6000EBB
        public System.Void __Gen_Wrap_404(Beyond.Gameplay.Factory.CutoffState& P0, Beyond.Gameplay.Factory.BuildDismissState& P1) { }
        // RVA: 0x057ED0AC  token: 0x6000EBC
        public System.Void __Gen_Wrap_405(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, System.Int32 P1) { }
        // RVA: 0x057ED2C0  token: 0x6000EBD
        public System.Void __Gen_Wrap_406(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x057ED4E4  token: 0x6000EBE
        public System.Void __Gen_Wrap_407(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x057ED788  token: 0x6000EBF
        public Unity.Jobs.JobHandle __Gen_Wrap_408(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x057EDA20  token: 0x6000EC0
        public Unity.Jobs.JobHandle __Gen_Wrap_409(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, Unity.Jobs.JobHandle P1, Unity.Jobs.JobHandle P2, System.Int32 P3) { }
        // RVA: 0x057EDDCC  token: 0x6000EC1
        public System.Void __Gen_Wrap_410(Beyond.Gameplay.Factory.AdditiveEffectQueryJob& P0) { }
        // RVA: 0x057EDF0C  token: 0x6000EC2
        public System.Void __Gen_Wrap_411(Beyond.Gameplay.Factory.AdditiveEffectQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P2, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P3, System.Boolean P4) { }
        // RVA: 0x057EE200  token: 0x6000EC3
        public System.Void __Gen_Wrap_412(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& P2, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P3) { }
        // RVA: 0x057EE578  token: 0x6000EC4
        public System.Void __Gen_Wrap_413(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, System.IntPtr P1) { }
        // RVA: 0x057EE788  token: 0x6000EC5
        public System.Void __Gen_Wrap_414(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, System.Boolean P2, System.Boolean P3) { }
        // RVA: 0x057EE97C  token: 0x6000EC6
        public System.Void __Gen_Wrap_415(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P2, Beyond.Gameplay.Factory.FPtrNativeCurve& P3, Beyond.Gameplay.Factory.FPtrNativeCurve& P4, Beyond.Gameplay.Factory.FPtrNativeCurve& P5, System.Int64 P6) { }
        // RVA: 0x057EED80  token: 0x6000EC7
        public System.Void __Gen_Wrap_416(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P2) { }
        // RVA: 0x057EEFCC  token: 0x6000EC8
        public System.Void __Gen_Wrap_417(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x057EF1C4  token: 0x6000EC9
        public System.Void __Gen_Wrap_418(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x057EF3D0  token: 0x6000ECA
        public System.Void __Gen_Wrap_419(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x057EF764  token: 0x6000ECB
        public Unity.Jobs.JobHandle __Gen_Wrap_420(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x057EF9CC  token: 0x6000ECC
        public Unity.Jobs.JobHandle __Gen_Wrap_421(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, Unity.Jobs.JobHandle P1, Unity.Jobs.JobHandle P2, System.Int32 P3) { }
        // RVA: 0x057EFC7C  token: 0x6000ECD
        public System.Void __Gen_Wrap_422(Beyond.Gameplay.Factory.AudioJobs.AudioDistanceAndCullingJob& P0, System.Int32 P1) { }
        // RVA: 0x057EFDEC  token: 0x6000ECE
        public System.Void __Gen_Wrap_423(Beyond.Gameplay.Factory.AudioJobs.AudioGroupEmitterJob& P0, System.Int32 P1) { }
        // RVA: 0x057EFF68  token: 0x6000ECF
        public System.Void __Gen_Wrap_424(Beyond.Gameplay.Factory.AudioJobs.AudioGroupEmitterJob& P0, System.IntPtr P1) { }
        // RVA: 0x057F00F4  token: 0x6000ED0
        public System.Void __Gen_Wrap_425(Beyond.Gameplay.Factory.AudioJobs.WaterPipeEmitterJob& P0, System.Int32 P1, Beyond.Gameplay.Factory.PipeFragment& P2) { }
        // RVA: 0x057F036C  token: 0x6000ED1
        public System.Void __Gen_Wrap_426(Beyond.Gameplay.Factory.AudioJobs.WaterPipeEmitterJob& P0, System.Int32 P1) { }
        // RVA: 0x057F04E8  token: 0x6000ED2
        public System.Void __Gen_Wrap_427(Beyond.Gameplay.Factory.AudioJobs.WaterPipeEmitterJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x057F0810  token: 0x6000ED3
        public System.Void __Gen_Wrap_428(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.Boolean P1, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P2, Unity.Mathematics.quaternion P3, Unity.Mathematics.float3 P4, Beyond.Gameplay.Factory.ComplexPortFragment P5, Unity.Mathematics.float4x4 P6, System.Single P7, System.Boolean P8, System.Boolean P9, System.Boolean P10, System.Boolean P11, System.Boolean P12, System.Boolean P13, System.Boolean P14, System.Boolean P15, System.Boolean P16, System.Boolean P17, System.Boolean P18) { }
        // RVA: 0x057F0C8C  token: 0x6000ED4
        public System.Void __Gen_Wrap_429(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2) { }
        // RVA: 0x057F0F64  token: 0x6000ED5
        public System.Void __Gen_Wrap_430(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.Int32 P1) { }
        // RVA: 0x057F10C4  token: 0x6000ED6
        public System.Void __Gen_Wrap_431(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.IntPtr P1) { }
        // RVA: 0x057F1238  token: 0x6000ED7
        public System.Void __Gen_Wrap_432(Beyond.Gameplay.Factory.BatchArrowJob& P0) { }
        // RVA: 0x057F137C  token: 0x6000ED8
        public System.Void __Gen_Wrap_433(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.UInt32 P1, Unity.Mathematics.float3 P2, Unity.Mathematics.quaternion P3, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P4, Beyond.Gameplay.Factory.ComplexPortFragment& P5, System.Boolean P6, System.Single P7, System.Boolean P8) { }
        // RVA: 0x057F1804  token: 0x6000ED9
        public System.Void __Gen_Wrap_434(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2) { }
        // RVA: 0x057F1A68  token: 0x6000EDA
        public System.Void __Gen_Wrap_435(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.Int32 P1) { }
        // RVA: 0x057F1C80  token: 0x6000EDB
        public System.Void __Gen_Wrap_436(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.IntPtr P1) { }
        // RVA: 0x057F1EAC  token: 0x6000EDC
        public System.Void __Gen_Wrap_437(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0) { }
        // RVA: 0x057F20B0  token: 0x6000EDD
        public System.Void __Gen_Wrap_438(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.UInt32 P1, System.Boolean P2, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P3, Unity.Mathematics.quaternion P4, Unity.Mathematics.float3 P5, Beyond.Gameplay.Factory.ComplexPortFragment P6, Unity.Mathematics.float4x4 P7, System.Single P8, System.Boolean P9, System.Boolean P10, System.Boolean P11, System.Boolean P12, System.Boolean P13, System.Boolean P14, System.Boolean P15, System.Boolean P16, System.Boolean P17) { }
        // RVA: 0x057F2520  token: 0x6000EDE
        public System.Void __Gen_Wrap_439(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2) { }
        // RVA: 0x057F26C8  token: 0x6000EDF
        public System.Void __Gen_Wrap_440(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.Int32 P1) { }
        // RVA: 0x057F2828  token: 0x6000EE0
        public System.Void __Gen_Wrap_441(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0) { }
        // RVA: 0x057F296C  token: 0x6000EE1
        public System.Void __Gen_Wrap_442(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.IntPtr P1) { }
        // RVA: 0x057F2AE0  token: 0x6000EE2
        public System.Void __Gen_Wrap_443(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0, System.Boolean P1, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P2, Unity.Mathematics.quaternion P3, Unity.Mathematics.float3 P4, Beyond.Gameplay.Factory.ComplexPortFragment P5, Unity.Mathematics.float4x4 P6, System.Single P7, System.Boolean P8, System.Boolean P9, System.Boolean P10) { }
        // RVA: 0x057F2FB4  token: 0x6000EE3
        public System.Void __Gen_Wrap_444(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2) { }
        // RVA: 0x057F3258  token: 0x6000EE4
        public System.Void __Gen_Wrap_445(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0) { }
        // RVA: 0x057F349C  token: 0x6000EE5
        public System.Void __Gen_Wrap_446(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0, System.IntPtr P1) { }
        // RVA: 0x057F3708  token: 0x6000EE6
        public System.Void __Gen_Wrap_447(Beyond.Gameplay.Factory.BufferSwapJob& P0) { }
        // RVA: 0x01063B70  token: 0x6000EE7
        public System.Void __Gen_Wrap_448(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.ValueTuple<System.Int32,System.UInt32> P2) { }
        // RVA: 0x01064B50  token: 0x6000EE8
        public System.Void __Gen_Wrap_449(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x01065710  token: 0x6000EE9
        public System.Void __Gen_Wrap_450(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010662E0  token: 0x6000EEA
        public System.Void __Gen_Wrap_451(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x010672B0  token: 0x6000EEB
        public Unity.Jobs.JobHandle __Gen_Wrap_452(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x01068250  token: 0x6000EEC
        public System.Void __Gen_Wrap_453(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, System.IntPtr P1) { }
        // RVA: 0x01068E40  token: 0x6000EED
        public System.Void __Gen_Wrap_454(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, Beyond.Gameplay.Factory.UnitFragment& P1, Beyond.Gameplay.Factory.UnitTransFragment& P2, Beyond.Gameplay.Factory.UnitConfigFragment& P3, Beyond.Gameplay.Factory.UnitStatusFragment& P4, Beyond.Gameplay.Factory.SharedDataFragment& P5) { }
        // RVA: 0x0106AD70  token: 0x6000EEE
        public System.Void __Gen_Wrap_455(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x0106B970  token: 0x6000EEF
        public System.Void __Gen_Wrap_456(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x0106C580  token: 0x6000EF0
        public System.Void __Gen_Wrap_457(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0) { }
        // RVA: 0x0106D170  token: 0x6000EF1
        public System.Void __Gen_Wrap_458(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x0106DDB0  token: 0x6000EF2
        public System.Void __Gen_Wrap_459(Beyond.Gameplay.Factory.BuildingStateRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x0106E980  token: 0x6000EF3
        public System.Void __Gen_Wrap_460(Beyond.Gameplay.Factory.CargoCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x0106F580  token: 0x6000EF4
        public System.Void __Gen_Wrap_461(Beyond.Gameplay.Factory.CargoCollectJob& P0) { }
        // RVA: 0x01070170  token: 0x6000EF5
        public System.Void __Gen_Wrap_462(Beyond.Gameplay.Factory.CargoCollectJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x01071370  token: 0x6000EF6
        public System.Void __Gen_Wrap_463(Beyond.Gameplay.Factory.CargoCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x01071FB0  token: 0x6000EF7
        public System.Void __Gen_Wrap_464(Beyond.Gameplay.Factory.CargoPredictJob& P0, System.Int32 P1) { }
        // RVA: 0x01072B90  token: 0x6000EF8
        public System.Void __Gen_Wrap_465(Beyond.Gameplay.Factory.CargoPredictJob& P0, System.IntPtr P1) { }
        // RVA: 0x010737B0  token: 0x6000EF9
        public System.Void __Gen_Wrap_466(Beyond.Gameplay.Factory.CargoPredictJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x010747A0  token: 0x6000EFA
        public Unity.Jobs.JobHandle __Gen_Wrap_467(Beyond.Gameplay.Factory.CargoPredictJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x01075780  token: 0x6000EFB
        public System.Void __Gen_Wrap_468(Beyond.Gameplay.Factory.CargoPredictQueryJob& P0) { }
        // RVA: 0x01076330  token: 0x6000EFC
        public System.Void __Gen_Wrap_469(Beyond.Gameplay.Factory.CargoPredictQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2) { }
        // RVA: 0x01077320  token: 0x6000EFD
        public System.Void __Gen_Wrap_470(Beyond.Gameplay.Factory.CargoRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x01077F00  token: 0x6000EFE
        public System.Void __Gen_Wrap_471(Beyond.Gameplay.Factory.CargoRenderJob& P0, System.IntPtr P1) { }
        // RVA: 0x01078B10  token: 0x6000EFF
        public System.Void __Gen_Wrap_472(Beyond.Gameplay.Factory.CargoRenderQueryJob& P0) { }
        // RVA: 0x010796C0  token: 0x6000F00
        public System.Void __Gen_Wrap_473(Beyond.Gameplay.Factory.CargoRenderQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2) { }
        // RVA: 0x0107A6B0  token: 0x6000F01
        public System.Void __Gen_Wrap_474(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, Beyond.Gameplay.Factory.ConveyorFragment& P1, Beyond.Gameplay.Factory.SharedDataFragment& P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x0107BB30  token: 0x6000F02
        public System.Void __Gen_Wrap_475(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x0107C730  token: 0x6000F03
        public System.Void __Gen_Wrap_476(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x0107D340  token: 0x6000F04
        public System.Void __Gen_Wrap_477(Beyond.Gameplay.Factory.ConveyorCollectJob& P0) { }
        // RVA: 0x0107DF30  token: 0x6000F05
        public System.Void __Gen_Wrap_478(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x0107EB70  token: 0x6000F06
        public System.Void __Gen_Wrap_479(Beyond.Gameplay.Factory.ConveyorFigureRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x0107F750  token: 0x6000F07
        public System.Void __Gen_Wrap_480(Beyond.Gameplay.Factory.ConveyorFigureRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x01080350  token: 0x6000F08
        public System.Void __Gen_Wrap_481(Beyond.Gameplay.Factory.ConveyorFigureRendererJob& P0, System.IntPtr P1) { }
        // RVA: 0x01080F70  token: 0x6000F09
        public System.Void __Gen_Wrap_482(Beyond.Gameplay.Factory.ConveyorInsideRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x01081BB0  token: 0x6000F0A
        public System.Void __Gen_Wrap_483(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0, Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment& P1, Beyond.Gameplay.Factory.SharedDataFragment& P2, System.Boolean P3, System.Boolean P4) { }
        // RVA: 0x01083010  token: 0x6000F0B
        public System.Void __Gen_Wrap_484(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x01083C10  token: 0x6000F0C
        public System.Void __Gen_Wrap_485(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0) { }
        // RVA: 0x01084800  token: 0x6000F0D
        public System.Void __Gen_Wrap_486(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x01085430  token: 0x6000F0E
        public System.Void __Gen_Wrap_487(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.Single P2, System.UInt32 P3, Unity.Mathematics.float3 P4, Unity.Mathematics.float3 P5, System.Single P6, System.Single P7, System.Single P8, System.Boolean P9, Beyond.Gameplay.Factory.BlueprintState.EffectType P10, System.Single P11, System.UInt32 P12, System.Boolean P13, System.Boolean P14, System.Boolean P15) { }
        // RVA: 0x01086570  token: 0x6000F0F
        public System.Void __Gen_Wrap_488(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x01087150  token: 0x6000F10
        public System.Void __Gen_Wrap_489(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x01087D50  token: 0x6000F11
        public System.Void __Gen_Wrap_490(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, System.IntPtr P1) { }
        // RVA: 0x01088970  token: 0x6000F12
        public System.Void __Gen_Wrap_491(Beyond.Gameplay.Factory.InteractFacCollectJob& P0) { }
        // RVA: 0x010896C0  token: 0x6000F13
        public System.Boolean __Gen_Wrap_492(Unity.Mathematics.float3 P0, Unity.Mathematics.float3 P1, Unity.Mathematics.float3 P2, System.Single P3, System.Single P4, System.Single& P5, System.Single& P6, System.Boolean P7) { }
        // RVA: 0x01089F40  token: 0x6000F14
        public System.Void __Gen_Wrap_493(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P1) { }
        // RVA: 0x0108AC70  token: 0x6000F15
        public Unity.Mathematics.float3 __Gen_Wrap_494(Unity.Mathematics.float3 P0) { }
        // RVA: 0x0108B820  token: 0x6000F16
        public System.Boolean __Gen_Wrap_495(Beyond.Gameplay.Factory.InteractFacCollectJob& P0, Unity.Mathematics.float3 P1, System.Single P2, System.Int32& P3) { }
        // RVA: 0x0108C7A0  token: 0x6000F17
        public System.Void __Gen_Wrap_496(Beyond.Gameplay.Factory.InteractFacCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x0108D530  token: 0x6000F18
        public System.String __Gen_Wrap_497(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P0) { }
        // RVA: 0x0108E420  token: 0x6000F19
        public System.Boolean __Gen_Wrap_498(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P0) { }
        // RVA: 0x0108F030  token: 0x6000F1A
        public System.Boolean __Gen_Wrap_499(Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P0) { }
        // RVA: 0x0108FC00  token: 0x6000F1B
        public System.Void __Gen_Wrap_500(Beyond.Gameplay.Factory.LocalToWorldJob& P0, System.Int32 P1) { }
        // RVA: 0x010907C0  token: 0x6000F1C
        public System.Void __Gen_Wrap_501(Beyond.Gameplay.Factory.LocalToWorld& P0, System.IntPtr P1, System.Int32 P2) { }
        // RVA: 0x010914D0  token: 0x6000F1D
        public System.Void __Gen_Wrap_502(Beyond.Gameplay.Factory.LocalToWorldJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010920A0  token: 0x6000F1E
        public System.Void __Gen_Wrap_503(Beyond.Gameplay.Factory.LocalToWorldJob& P0, System.IntPtr P1) { }
        // RVA: 0x01092CA0  token: 0x6000F1F
        public System.Void __Gen_Wrap_504(Beyond.Gameplay.Factory.LocalToWorldJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x01093C70  token: 0x6000F20
        public Unity.Jobs.JobHandle __Gen_Wrap_505(Beyond.Gameplay.Factory.LocalToWorldJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x01094C20  token: 0x6000F21
        public System.Void __Gen_Wrap_506(Beyond.Gameplay.Factory.LocalToWorldQueryJob& P0) { }
        // RVA: 0x010957D0  token: 0x6000F22
        public System.Void __Gen_Wrap_507(Beyond.Gameplay.Factory.LocalToWorldQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2) { }
        // RVA: 0x010967C0  token: 0x6000F23
        public System.Void __Gen_Wrap_508(Beyond.Gameplay.Factory.LogisticEffectJob& P0, System.Int32 P1) { }
        // RVA: 0x010973A0  token: 0x6000F24
        public System.Void __Gen_Wrap_509(Beyond.Gameplay.Factory.LookAtJob& P0, System.Int32 P1) { }
        // RVA: 0x01097F50  token: 0x6000F25
        public System.Void __Gen_Wrap_510(Beyond.Gameplay.Factory.LookAtJob& P0, System.IntPtr P1) { }
        // RVA: 0x01098B30  token: 0x6000F26
        public System.Void __Gen_Wrap_511(Beyond.Gameplay.Factory.LookAtJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x01099AE0  token: 0x6000F27
        public Unity.Jobs.JobHandle __Gen_Wrap_512(Beyond.Gameplay.Factory.LookAtJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x0109AA80  token: 0x6000F28
        public System.Void __Gen_Wrap_513(Beyond.Gameplay.Factory.LookAtQueryJob& P0) { }
        // RVA: 0x0109B630  token: 0x6000F29
        public System.Void __Gen_Wrap_514(Beyond.Gameplay.Factory.LookAtQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2) { }
        // RVA: 0x0109C620  token: 0x6000F2A
        public System.Void __Gen_Wrap_515(Beyond.Gameplay.Factory.OutputCollectJob& P0, Beyond.Gameplay.Factory.UnitFragment& P1, Beyond.Gameplay.Factory.UnitTransFragment& P2, Beyond.Gameplay.Factory.UnitConfigFragment& P3, Beyond.Gameplay.Factory.OutputFragment& P4, Beyond.Gameplay.Factory.SharedDataFragment& P5) { }
        // RVA: 0x0109E640  token: 0x6000F2B
        public System.Void __Gen_Wrap_516(Beyond.Gameplay.Factory.OutputCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x0109F220  token: 0x6000F2C
        public System.Void __Gen_Wrap_517(Beyond.Gameplay.Factory.OutputCollectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x0109FE20  token: 0x6000F2D
        public System.Void __Gen_Wrap_518(Beyond.Gameplay.Factory.OutputCollectJob& P0) { }
        // RVA: 0x010A09F0  token: 0x6000F2E
        public System.Void __Gen_Wrap_519(Beyond.Gameplay.Factory.OutputCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x010A1610  token: 0x6000F2F
        public System.Void __Gen_Wrap_520(Beyond.Gameplay.Factory.OutputRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x010A21E0  token: 0x6000F30
        public Unity.Mathematics.float4 __Gen_Wrap_521(Beyond.Gameplay.Factory.PedestalFlashJob& P0, Beyond.Gameplay.Factory.PedestalLightFlashFragment& P1, System.Single P2) { }
        // RVA: 0x010A3420  token: 0x6000F31
        public System.Void __Gen_Wrap_522(Beyond.Gameplay.Factory.PedestalFlashJob& P0, System.Int32 P1) { }
        // RVA: 0x010A3FF0  token: 0x6000F32
        public System.Void __Gen_Wrap_523(Beyond.Gameplay.Factory.PedestalFlashJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010A4BD0  token: 0x6000F33
        public System.Void __Gen_Wrap_524(Beyond.Gameplay.Factory.PedestalFlashJob& P0, System.IntPtr P1) { }
        // RVA: 0x010A57D0  token: 0x6000F34
        public System.Void __Gen_Wrap_525(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1, System.UInt32 P2, System.UInt32 P3, System.Int32 P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.UInt32 P9, System.Boolean P10, System.Boolean P11, System.Boolean P12) { }
        // RVA: 0x010A64D0  token: 0x6000F35
        public System.Void __Gen_Wrap_526(Beyond.Gameplay.Factory.PipeCollectJob& P0, Beyond.Gameplay.Factory.PipeFragment& P1, System.UInt32 P2) { }
        // RVA: 0x010A7360  token: 0x6000F36
        public System.Void __Gen_Wrap_527(Beyond.Gameplay.Factory.PipeCollectJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange P1, Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> P2) { }
        // RVA: 0x010A83F0  token: 0x6000F37
        public System.Void __Gen_Wrap_528(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1, System.UInt32 P2, System.UInt32 P3, System.Single P4, System.Single P5, System.Single P6, System.UInt32 P7, System.Boolean P8) { }
        // RVA: 0x010A9080  token: 0x6000F38
        public System.Void __Gen_Wrap_529(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x010A9D10  token: 0x6000F39
        public System.Void __Gen_Wrap_530(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010AA9C0  token: 0x6000F3A
        public System.Void __Gen_Wrap_531(Beyond.Gameplay.Factory.PipeCollectJob& P0) { }
        // RVA: 0x010AB640  token: 0x6000F3B
        public System.Void __Gen_Wrap_532(Beyond.Gameplay.Factory.PipeCollectJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x010AC8D0  token: 0x6000F3C
        public System.Void __Gen_Wrap_533(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x010AD5B0  token: 0x6000F3D
        public System.Void __Gen_Wrap_534(Beyond.Gameplay.Factory.PipeComRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010AE1B0  token: 0x6000F3E
        public System.Void __Gen_Wrap_535(Beyond.Gameplay.Factory.PipeFigureRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.Byte P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.Single P9, System.Single P10, System.Boolean P11, System.Boolean P12, System.Boolean P13) { }
        // RVA: 0x010AF2A0  token: 0x6000F3F
        public System.Void __Gen_Wrap_536(Beyond.Gameplay.Factory.PipeFigureRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x010AFE70  token: 0x6000F40
        public System.Void __Gen_Wrap_537(Beyond.Gameplay.Factory.PipeFigureRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010B0A50  token: 0x6000F41
        public System.Void __Gen_Wrap_538(Beyond.Gameplay.Factory.PipeHolderFigureRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x010B1630  token: 0x6000F42
        public System.Void __Gen_Wrap_539(Beyond.Gameplay.Factory.PipeHolderFigureRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010B2230  token: 0x6000F43
        public System.Void __Gen_Wrap_540(Beyond.Gameplay.Factory.PipeHolderHideRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x010B2E00  token: 0x6000F44
        public System.Void __Gen_Wrap_541(Beyond.Gameplay.Factory.PipeHolderHideRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010B39E0  token: 0x6000F45
        public System.Void __Gen_Wrap_542(Beyond.Gameplay.Factory.PipeHolderHideRendererJob& P0, System.IntPtr P1) { }
        // RVA: 0x010B45E0  token: 0x6000F46
        public System.Void __Gen_Wrap_543(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x010B51B0  token: 0x6000F47
        public System.Void __Gen_Wrap_544(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010B5D90  token: 0x6000F48
        public System.Void __Gen_Wrap_545(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x010B6990  token: 0x6000F49
        public System.Void __Gen_Wrap_546(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0) { }
        // RVA: 0x010B7550  token: 0x6000F4A
        public System.Void __Gen_Wrap_547(Beyond.Gameplay.Factory.PipeRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.Byte P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4, System.Single P5, System.UInt32 P6, System.Int32 P7, System.Int32 P8, System.Single P9, System.Single P10, System.Single P11, Beyond.Gameplay.Factory.BlueprintState.EffectType P12, System.Single P13, System.UInt32 P14, System.Boolean P15, System.Boolean P16, System.Boolean P17) { }
        // RVA: 0x010B8670  token: 0x6000F4B
        public System.Void __Gen_Wrap_548(Beyond.Gameplay.Factory.PipeRendererJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010B9280  token: 0x6000F4C
        public System.Void __Gen_Wrap_549(Beyond.Gameplay.Factory.PipeRendererJob& P0, System.IntPtr P1) { }
        // RVA: 0x010B9EB0  token: 0x6000F4D
        public System.Void __Gen_Wrap_550(Beyond.Gameplay.Factory.PipeTrackRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, Unity.Mathematics.float3 P2, Unity.Mathematics.float3 P3, System.Single P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.Boolean P9) { }
        // RVA: 0x010BB080  token: 0x6000F4E
        public System.Void __Gen_Wrap_551(Beyond.Gameplay.Factory.PipeTrackRendererJob& P0) { }
        // RVA: 0x010BBCA0  token: 0x6000F4F
        public System.Void __Gen_Wrap_552(Beyond.Gameplay.Factory.PipeWaterThicknessQueryJob& P0) { }
        // RVA: 0x010BC850  token: 0x6000F50
        public System.Void __Gen_Wrap_553(Beyond.Gameplay.Factory.PipeWaterThicknessQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2) { }
        // RVA: 0x010BD840  token: 0x6000F51
        public System.Void __Gen_Wrap_554(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, System.Int32 P1) { }
        // RVA: 0x010BE400  token: 0x6000F52
        public System.Void __Gen_Wrap_555(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010BEFD0  token: 0x6000F53
        public System.Void __Gen_Wrap_556(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x010C01B0  token: 0x6000F54
        public System.Void __Gen_Wrap_557(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x010C1180  token: 0x6000F55
        public Unity.Jobs.JobHandle __Gen_Wrap_558(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x010C2130  token: 0x6000F56
        public System.Void __Gen_Wrap_559(Beyond.Gameplay.Factory.PortArrowRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x010C2D10  token: 0x6000F57
        public System.Void __Gen_Wrap_560(Beyond.Gameplay.Factory.PortStateCollectJob& P0, Beyond.Gameplay.Factory.ComplexPortFragment& P1, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P2) { }
        // RVA: 0x010C41A0  token: 0x6000F58
        public System.Void __Gen_Wrap_561(Beyond.Gameplay.Factory.PortStateCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x010C4D80  token: 0x6000F59
        public System.Void __Gen_Wrap_562(Beyond.Gameplay.Factory.PortStateCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x010C59A0  token: 0x6000F5A
        public System.Void __Gen_Wrap_563(Beyond.Gameplay.Factory.PortStateCollectJob& P0) { }
        // RVA: 0x010C6570  token: 0x6000F5B
        public System.Void __Gen_Wrap_564(Beyond.Gameplay.Factory.PortStateCollectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010C7170  token: 0x6000F5C
        public System.Void __Gen_Wrap_565(Beyond.Gameplay.Factory.PortStateRendererJob& P0, System.Int32 P1) { }
        // RVA: 0x010C7D40  token: 0x6000F5D
        public System.Void __Gen_Wrap_566(Beyond.Gameplay.Factory.PreviewUnitQueryJob& P0) { }
        // RVA: 0x010C88F0  token: 0x6000F5E
        public System.Void __Gen_Wrap_567(Beyond.Gameplay.Factory.PreviewUnitQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2) { }
        // RVA: 0x010C98E0  token: 0x6000F5F
        public System.Void __Gen_Wrap_568(Beyond.Gameplay.Factory.PumpInEffectJob& P0, System.Int32 P1) { }
        // RVA: 0x010CA4A0  token: 0x6000F60
        public System.Void __Gen_Wrap_569(Beyond.Gameplay.Factory.PumpInEffectJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010CB070  token: 0x6000F61
        public System.Void __Gen_Wrap_570(Beyond.Gameplay.Factory.PumpInEffectJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x010CC040  token: 0x6000F62
        public Unity.Jobs.JobHandle __Gen_Wrap_571(Beyond.Gameplay.Factory.PumpInEffectJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x010CCFE0  token: 0x6000F63
        public System.Void __Gen_Wrap_572(Beyond.Gameplay.Factory.PumpInEffectJob& P0, System.IntPtr P1) { }
        // RVA: 0x010CDBD0  token: 0x6000F64
        public System.Void __Gen_Wrap_573(Beyond.Gameplay.Factory.StatusChangeJob& P0, System.Int32 P1) { }
        // RVA: 0x010CE810  token: 0x6000F65
        public System.Void __Gen_Wrap_574(Beyond.Gameplay.Factory.UnitCullingJob& P0, System.Int32 P1) { }
        // RVA: 0x010CF420  token: 0x6000F66
        public System.Void __Gen_Wrap_575(Beyond.Gameplay.Factory.UnitCullingJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010D0040  token: 0x6000F67
        public System.Void __Gen_Wrap_576(Beyond.Gameplay.Factory.UnitCullingJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x010D1260  token: 0x6000F68
        public System.Void __Gen_Wrap_577(Beyond.Gameplay.Factory.UnitCullingJob& P0, System.IntPtr P1) { }
        // RVA: 0x010D1EB0  token: 0x6000F69
        public System.Void __Gen_Wrap_578(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x010D2A70  token: 0x6000F6A
        public System.Void __Gen_Wrap_579(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010D3640  token: 0x6000F6B
        public System.Void __Gen_Wrap_580(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x010D4820  token: 0x6000F6C
        public System.Void __Gen_Wrap_581(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, System.IntPtr P1) { }
        // RVA: 0x010D5420  token: 0x6000F6D
        public System.Void __Gen_Wrap_582(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x010D63F0  token: 0x6000F6E
        public Unity.Jobs.JobHandle __Gen_Wrap_583(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x010D73A0  token: 0x6000F6F
        public System.Void __Gen_Wrap_584(Beyond.Gameplay.Factory.UnitRendererQueryJob& P0) { }
        // RVA: 0x010D7F60  token: 0x6000F70
        public System.Void __Gen_Wrap_585(Beyond.Gameplay.Factory.UnitRendererQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P2, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P3, System.Boolean P4) { }
        // RVA: 0x010D9320  token: 0x6000F71
        public System.Void __Gen_Wrap_586(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, System.Int32 P1) { }
        // RVA: 0x010D9ED0  token: 0x6000F72
        public System.Void __Gen_Wrap_587(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010DAA80  token: 0x6000F73
        public System.Void __Gen_Wrap_588(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, System.IntPtr P1) { }
        // RVA: 0x010DB660  token: 0x6000F74
        public System.Void __Gen_Wrap_589(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1) { }
        // RVA: 0x010DC610  token: 0x6000F75
        public Unity.Jobs.JobHandle __Gen_Wrap_590(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2) { }
        // RVA: 0x010DD5B0  token: 0x6000F76
        public System.Void __Gen_Wrap_591(Beyond.Gameplay.Factory.WireCollectJob& P0, System.Int32 P1) { }
        // RVA: 0x010DE270  token: 0x6000F77
        public System.Void __Gen_Wrap_592(Beyond.Gameplay.Factory.WireCollectJob& P0) { }
        // RVA: 0x010DEF20  token: 0x6000F78
        public System.Void __Gen_Wrap_593(Beyond.Gameplay.Factory.WireCollectJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x010E01D0  token: 0x6000F79
        public System.Void __Gen_Wrap_594(Beyond.Gameplay.Factory.WireCollectJob& P0, System.IntPtr P1) { }
        // RVA: 0x010E0ED0  token: 0x6000F7A
        public System.Void __Gen_Wrap_595(Beyond.Gameplay.Factory.WireRenderJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, Beyond.Gameplay.Factory.WireRendererInfo P2) { }
        // RVA: 0x010E1E90  token: 0x6000F7B
        public System.Void __Gen_Wrap_596(Beyond.Gameplay.Factory.WireRenderJob& P0, System.Int32 P1) { }
        // RVA: 0x010E2A70  token: 0x6000F7C
        public System.Void __Gen_Wrap_597(Beyond.Gameplay.Factory.WireRenderJob& P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x010E3660  token: 0x6000F7D
        public System.Boolean __Gen_Wrap_598(Beyond.Gameplay.Factory.FPtrNativeCurve& P0) { }
        // RVA: 0x010E4230  token: 0x6000F7E
        public Unity.Collections.NativeArray<System.Single> __Gen_Wrap_599(Beyond.Gameplay.Factory.FPtrNativeCurve& P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x010E5230  token: 0x6000F7F
        public System.Single __Gen_Wrap_600(Beyond.Gameplay.Factory.FPtrNativeCurve& P0, System.Single P1) { }
        // RVA: 0x010E5E20  token: 0x6000F80
        public System.Int32 __Gen_Wrap_601(Beyond.Gameplay.Factory.PerDrawPassConfig& P0) { }
        // RVA: 0x010E6A00  token: 0x6000F81
        public UnityEngine.HyperGryph.HGShaderLightMode __Gen_Wrap_602(Beyond.Gameplay.Factory.PerDrawPassConfig& P0, Beyond.Gameplay.Factory.PerDrawLightMode P1) { }
        // RVA: 0x010E75F0  token: 0x6000F82
        public System.Void __Gen_Wrap_603(Beyond.Gameplay.Factory.PerDrawPassConfig& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.UInt32& P2) { }
        // RVA: 0x010E83B0  token: 0x6000F83
        public System.Void __Gen_Wrap_604(Beyond.Gameplay.Factory.PerDrawPassConfig& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent P1, System.UInt32& P2) { }
        // RVA: 0x010E9170  token: 0x6000F84
        public System.Int32 __Gen_Wrap_605() { }
        // RVA: 0x010E9340  token: 0x6000F85
        public System.Void __Gen_Wrap_606(Beyond.Gameplay.Factory.PerDrawConfig& P0, UnityEngine.Color P1) { }
        // RVA: 0x010EA2A0  token: 0x6000F86
        public System.Void __Gen_Wrap_607(Beyond.Gameplay.Factory.PerDrawConfig& P0, Unity.Mathematics.float4 P1) { }
        // RVA: 0x010EB200  token: 0x6000F87
        public System.Void __Gen_Wrap_608(Beyond.Gameplay.Factory.PerDrawConfig& P0, System.Single P1) { }
        // RVA: 0x010EBE20  token: 0x6000F88
        public System.Void __Gen_Wrap_609(Beyond.Gameplay.Factory.PerDrawConfig& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent P1) { }
        // RVA: 0x010ECDE0  token: 0x6000F89
        public System.Boolean __Gen_Wrap_610(System.Single P0, System.Single P1, System.Single& P2, System.Single P3, System.Single P4) { }
        // RVA: 0x010ED0E0  token: 0x6000F8A
        public System.Boolean __Gen_Wrap_611(Beyond.Gameplay.Factory.IProcessor& P0, System.Single P1, System.Single P2) { }
        // RVA: 0x010EDB30  token: 0x6000F8B
        public System.Void __Gen_Wrap_612(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P1, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P2) { }
        // RVA: 0x010EEF70  token: 0x6000F8C
        public System.Void __Gen_Wrap_613(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P1, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P2) { }
        // RVA: 0x010F0320  token: 0x6000F8D
        public Unity.Jobs.JobHandle __Gen_Wrap_614(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, Unity.Jobs.JobHandle& P3, Unity.Jobs.JobHandle& P4) { }
        // RVA: 0x010F1AF0  token: 0x6000F8E
        public System.Boolean __Gen_Wrap_615(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0, Beyond.GEnums.FacBuildingState P1, UnityEngine.Color& P2) { }
        // RVA: 0x010F2920  token: 0x6000F8F
        public System.Void __Gen_Wrap_616(System.Object P0, Beyond.Gameplay.Factory.GlobalEnv& P1) { }
        // RVA: 0x010F3810  token: 0x6000F90
        public System.Boolean __Gen_Wrap_617(System.Object P0, System.Int32 P1, UnityEngine.Color& P2) { }
        // RVA: 0x010F4170  token: 0x6000F91
        public System.Boolean __Gen_Wrap_618(System.Object P0, System.Object P1, System.Object P2, System.Int32& P3) { }
        // RVA: 0x010F4660  token: 0x6000F92
        public Beyond.Gameplay.Factory.FactoryBaseColorLutConfig __Gen_Wrap_619(System.Object P0) { }
        // RVA: 0x010F4F90  token: 0x6000F93
        public System.Boolean __Gen_Wrap_620(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0, Beyond.GEnums.FacBuildingState P1, System.String& P2) { }
        // RVA: 0x010F5E60  token: 0x6000F94
        public System.Boolean __Gen_Wrap_621(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0, Beyond.Gameplay.Factory.LogicEntityState P1, Beyond.Gameplay.Factory.LogicEntityType P2, Beyond.Gameplay.Factory.PerDrawConfigArray& P3) { }
        // RVA: 0x010F6D00  token: 0x6000F95
        public System.Void __Gen_Wrap_622(Beyond.Gameplay.Factory.FFactoryStateColorConfig.LogicStateConfig& P0) { }
        // RVA: 0x010F78D0  token: 0x6000F96
        public System.Void __Gen_Wrap_623(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, System.Single P2) { }
        // RVA: 0x010F8510  token: 0x6000F97
        public System.Void __Gen_Wrap_624(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, System.Int32 P2) { }
        // RVA: 0x010F9140  token: 0x6000F98
        public System.Void __Gen_Wrap_625(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, System.Boolean P2) { }
        // RVA: 0x010F9D70  token: 0x6000F99
        public System.Void __Gen_Wrap_626(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0) { }
        // RVA: 0x010FA950  token: 0x6000F9A
        public System.Void __Gen_Wrap_627(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P1) { }
        // RVA: 0x010FB930  token: 0x6000F9B
        public System.Void __Gen_Wrap_628(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0) { }
        // RVA: 0x010FC510  token: 0x6000F9C
        public System.Void __Gen_Wrap_629(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, System.UInt32 P1, System.UInt32 P2) { }
        // RVA: 0x010FD1E0  token: 0x6000F9D
        public System.Void __Gen_Wrap_630(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition& P0) { }
        // RVA: 0x010FDDA0  token: 0x6000F9E
        public System.Void __Gen_Wrap_631(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& P1) { }
        // RVA: 0x010FEE10  token: 0x6000F9F
        public System.Void __Gen_Wrap_632(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0) { }
        // RVA: 0x010FFA60  token: 0x6000FA0
        public System.Void __Gen_Wrap_633(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& P1, Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& P2) { }
        // RVA: 0x01100AE0  token: 0x6000FA1
        public System.Single __Gen_Wrap_634(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0) { }
        // RVA: 0x011016D0  token: 0x6000FA2
        public System.Void __Gen_Wrap_635(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0, System.Single P1, System.Single P2) { }
        // RVA: 0x011022E0  token: 0x6000FA3
        public System.Void __Gen_Wrap_636(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0, System.Single P1) { }
        // RVA: 0x01102F00  token: 0x6000FA4
        public System.Single __Gen_Wrap_637(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition& P0) { }
        // RVA: 0x01103AD0  token: 0x6000FA5
        public System.Void __Gen_Wrap_638(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition& P0, System.Single P1, System.Single P2) { }
        // RVA: 0x011046C0  token: 0x6000FA6
        public System.Single __Gen_Wrap_639(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1) { }
        // RVA: 0x011052B0  token: 0x6000FA7
        public System.Int32 __Gen_Wrap_640(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1) { }
        // RVA: 0x01105EA0  token: 0x6000FA8
        public System.Boolean __Gen_Wrap_641(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1) { }
        // RVA: 0x01106A90  token: 0x6000FA9
        public System.Void __Gen_Wrap_642(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1) { }
        // RVA: 0x01107690  token: 0x6000FAA
        public System.Void __Gen_Wrap_643(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2, System.Single P3) { }
        // RVA: 0x01108300  token: 0x6000FAB
        public System.Single __Gen_Wrap_644(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2) { }
        // RVA: 0x01108F00  token: 0x6000FAC
        public System.Void __Gen_Wrap_645(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMSetParamRequestHandlerJob& P0, System.Int32 P1) { }
        // RVA: 0x01109AD0  token: 0x6000FAD
        public System.Boolean __Gen_Wrap_646(Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P1, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& P2) { }
        // RVA: 0x0110A7F0  token: 0x6000FAE
        public System.Boolean __Gen_Wrap_647(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P1, System.Int32& P2) { }
        // RVA: 0x0110B8C0  token: 0x6000FAF
        public System.Void __Gen_Wrap_648(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& P1, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& P2) { }
        // RVA: 0x0110C8E0  token: 0x6000FB0
        public System.Boolean __Gen_Wrap_649(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P1, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P2) { }
        // RVA: 0x0110DDE0  token: 0x6000FB1
        public System.Void __Gen_Wrap_650(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P2, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P3) { }
        // RVA: 0x0110F4B0  token: 0x6000FB2
        public System.Void __Gen_Wrap_651(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P1, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P2) { }
        // RVA: 0x011109A0  token: 0x6000FB3
        public System.Void __Gen_Wrap_652(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, System.Int32 P1) { }
        // RVA: 0x01111580  token: 0x6000FB4
        public System.Void __Gen_Wrap_653(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0) { }
        // RVA: 0x01112150  token: 0x6000FB5
        public System.Void __Gen_Wrap_654(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, System.IntPtr P1) { }
        // RVA: 0x01112D70  token: 0x6000FB6
        public System.Void __Gen_Wrap_655(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1) { }
        // RVA: 0x01113A20  token: 0x6000FB7
        public Unity.Jobs.JobHandle __Gen_Wrap_656(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, Unity.Jobs.JobHandle P3) { }
        // RVA: 0x01115170  token: 0x6000FB8
        public System.String __Gen_Wrap_657(System.Object P0) { }
        // RVA: 0x01115AA0  token: 0x6000FB9
        public System.UInt32 __Gen_Wrap_658(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0) { }
        // RVA: 0x01116660  token: 0x6000FBA
        public System.Span<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition> __Gen_Wrap_659(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0) { }
        // RVA: 0x01117540  token: 0x6000FBB
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& __Gen_Wrap_660(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, System.UInt32 P1) { }
        // RVA: 0x01118410  token: 0x6000FBC
        public Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& __Gen_Wrap_661(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, System.Int32 P1) { }
        // RVA: 0x011192E0  token: 0x6000FBD
        public System.Void __Gen_Wrap_662(System.Int32 P0, System.Object P1) { }
        // RVA: 0x011195D0  token: 0x6000FBE
        public System.Void __Gen_Wrap_663(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1) { }
        // RVA: 0x0111A540  token: 0x6000FBF
        public System.String __Gen_Wrap_664(System.UInt32 P0, System.Byte P1) { }
        // RVA: 0x0111ADE0  token: 0x6000FC0
        public System.Void __Gen_Wrap_665(Unity.Jobs.JobHandle P0) { }
        // RVA: 0x0111B380  token: 0x6000FC1
        public System.Boolean __Gen_Wrap_666(UnityEngine.HyperGryph.ECS.Entity P0) { }
        // RVA: 0x0111B930  token: 0x6000FC2
        public System.Boolean __Gen_Wrap_667(UnityEngine.HyperGryph.ECS.EntityManager& P0, UnityEngine.HyperGryph.ECS.Entity& P1) { }
        // RVA: 0x0111C8E0  token: 0x6000FC3
        public System.Boolean __Gen_Wrap_668(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1) { }
        // RVA: 0x0111D860  token: 0x6000FC4
        public System.Boolean __Gen_Wrap_669(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.Visibility.Type P2) { }
        // RVA: 0x0111E4A0  token: 0x6000FC5
        public System.Boolean __Gen_Wrap_670(UnityEngine.HyperGryph.ECS.Entity P0, Beyond.Gameplay.Factory.Visibility.Type P1) { }
        // RVA: 0x0111EA50  token: 0x6000FC6
        public System.Boolean __Gen_Wrap_671(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Boolean P2, Beyond.Gameplay.Factory.Visibility.EFlag P3, Beyond.Gameplay.Factory.Visibility.Type P4, System.Object P5) { }
        // RVA: 0x0111F7D0  token: 0x6000FC7
        public System.Void __Gen_Wrap_672(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Boolean P2, Beyond.Gameplay.Factory.Visibility.EFlag P3, Beyond.Gameplay.Factory.Visibility.Type P4, System.Object P5) { }
        // RVA: 0x01120540  token: 0x6000FC8
        public System.Boolean __Gen_Wrap_673(UnityEngine.HyperGryph.ECS.Entity P0, System.Boolean P1, Beyond.Gameplay.Factory.Visibility.EFlag P2, Beyond.Gameplay.Factory.Visibility.Type P3, UnityEngine.HyperGryph.ECS.EntityCommandBuffer& P4) { }
        // RVA: 0x011212A0  token: 0x6000FC9
        public System.Void __Gen_Wrap_674(UnityEngine.HyperGryph.ECS.Entity P0, System.Boolean P1) { }
        // RVA: 0x01121850  token: 0x6000FCA
        public System.Void __Gen_Wrap_675(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& P1) { }
        // RVA: 0x011227B0  token: 0x6000FCB
        public System.Boolean __Gen_Wrap_676(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Unity.Collections.FixedString32Bytes P2, Unity.Mathematics.float3& P3, Unity.Mathematics.quaternion& P4, UnityEngine.HyperGryph.ECS.Entity& P5) { }
        // RVA: 0x01123C10  token: 0x6000FCC
        public System.Boolean __Gen_Wrap_677(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Unity.Collections.FixedString32Bytes P2, Unity.Mathematics.float3& P3, Unity.Mathematics.quaternion& P4) { }
        // RVA: 0x01125020  token: 0x6000FCD
        public System.Boolean __Gen_Wrap_678(UnityEngine.HyperGryph.ECS.Entity P0, System.Object P1, Unity.Mathematics.float3& P2, Unity.Mathematics.quaternion& P3) { }
        // RVA: 0x01125F10  token: 0x6000FCE
        public Beyond.Gameplay.Factory.ChapterFragment& __Gen_Wrap_679(UnityEngine.HyperGryph.ECS.EntityManager P0, System.Int32 P1, System.Boolean& P2, UnityEngine.HyperGryph.ECS.Entity& P3) { }
        // RVA: 0x01126CF0  token: 0x6000FCF
        public System.IntPtr __Gen_Wrap_680(UnityEngine.HyperGryph.ECS.EntityManager P0) { }
        // RVA: 0x011272A0  token: 0x6000FD0
        public System.Boolean __Gen_Wrap_681(UnityEngine.HyperGryph.ECS.EntityManager P0) { }
        // RVA: 0x01127850  token: 0x6000FD1
        public Beyond.Gameplay.Factory.GlobalEnv& __Gen_Wrap_682(UnityEngine.HyperGryph.ECS.EntityManager P0) { }
        // RVA: 0x01128430  token: 0x6000FD2
        public System.Boolean __Gen_Wrap_683(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P1) { }
        // RVA: 0x01129410  token: 0x6000FD3
        public System.Boolean __Gen_Wrap_684(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P1) { }
        // RVA: 0x0112A3D0  token: 0x6000FD4
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_685(System.Object P0, System.Int32 P1) { }
        // RVA: 0x010502C0  token: 0x6000FD5
        public System.Void __Gen_Wrap_686(System.Object P0, System.Int32 P1) { }
        // RVA: 0x0112ACD0  token: 0x6000FD6
        public Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_687(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x0112B5F0  token: 0x6000FD7
        public System.Void __Gen_Wrap_688(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1, Unity.Collections.Allocator P2) { }
        // RVA: 0x0112C230  token: 0x6000FD8
        public System.UInt32 __Gen_Wrap_689(System.Object P0) { }
        // RVA: 0x0112C4F0  token: 0x6000FD9
        public System.Void __Gen_Wrap_690(System.Object P0, System.UInt32 P1, System.Int32& P2, System.Int32& P3) { }
        // RVA: 0x0112C830  token: 0x6000FDA
        public System.IntPtr __Gen_Wrap_691(Beyond.Gameplay.Factory.GlobalEnv& P0) { }
        // RVA: 0x03D05AA0  token: 0x6000FDB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000273  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x057FD8DC  token: 0x6000FDC
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x6000FDD
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000274  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000FDE
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x05803258  token: 0x6000FDF
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x024FD680  token: 0x6000FE0
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x05803114  token: 0x6000FE1
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x058031E0  token: 0x6000FE2
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x058032BC  token: 0x6000FE3
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x05803070  token: 0x6000FE4
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000275  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-AssetInstanceParseUtil-Parse0;  // const
        public static IFix.IDMAP0 Beyond-AssetInstanceParseUtil-Parse1;  // const
        public static IFix.IDMAP0 Beyond-AssetInstanceParseUtil-Get0;  // const
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond-InitializeAtRuntime0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-_OnPerDrawTypeChanged0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-OnValidate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FFactoryStateColorConfig-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-FactorySetting-OnEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_empty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_env0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_connection0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_buildingUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-CreateArchetype0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_powerStation0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_furnace0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_grinder0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_winder0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_componentMc0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_shaper0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_fillingPowderMc0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_thickener0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_hub0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_subHub0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_miner0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_toolsAssemblingMc0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_seedCollector0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_planter0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_powerDiffuser0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_powerPole0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_travelPole0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_loader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_unloader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_storage0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_powerTerminal0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_powerPort0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_facBattle0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pump0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_liquidStorage0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_mixPool0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_squirter0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_dumper0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_liquidCleaner0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_xiraniteOven0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_liquidPurifier0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_dismantler0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_hsBus0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_hsBusSource0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_udPipeLoader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_udPipeUnloader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_liquidCleanGate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_liquidRecycleGate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_carrier0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_marker0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_decoration0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeConditioner0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_logConditioner0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_buildingFakeUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_buildingRenderOnlyUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_buildingPreviewUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_buildingGuideHintUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_conveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_guideConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeHolder0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_cargo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_buildingRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pedestalRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_conveyorLeftRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_conveyorRightRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_conveyorMidRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_figurePipeHolderRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_figureLeftRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_figureRightRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_figureMidRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_conveyorPreviewRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipePreviewRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeComRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeLeftRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeMidRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeRightRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeTrackLeftPreviewRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeTrackMidPreviewRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_pipeTrackRightPreviewRender0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_outputUIRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_wireRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_unitStatusUIRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_portPreviewUIRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_gridRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_gridMainRegionRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_portStatusUIRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-get_scope0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Archetypes-Select0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Size0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-AsSpan0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Destroy0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Reserve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Data0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-Get0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorExtContainer-ConveyorExt-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_MergeAdjacentFreeBlocks0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_ExpandMemory0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Allocate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorInfoAllocator-Allocate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Free0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Expand0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Reserve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Resize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorInfoAllocator-Resize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorInfoAllocator-Free0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorInfoAllocator-CalculateSize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-PrintAllocations0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorInfoAllocator-DebugPrint0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Size0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-AsSpan0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Destroy0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Reserve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Data0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-Get0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-SetDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsPendingUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireRendererInfo-get_pos0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireRendererInfo-get_rot0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntityMap0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitId-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EntitySearcher-RegisterLogicEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EntitySearcher-UnregisterLogicEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EntitySearcher-_DestroyAllEntities0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EntitySearcher-DestroyAll0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-InitExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-ResetExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-ReleaseExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-CreateConveyorExtHandle0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyConveyorExtHandle0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExt0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-CreateSharedData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-DestroySharedData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-CreateTransHierarchy0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-ToMatrix0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-WorldTrans0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyHierarchyData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-CreateVATFSMDefinitionContainer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Destroy0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyVATFSMDefinition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Data0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-PeekState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-PopState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-ShiftState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-_Shrink0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-PushState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-InsertState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-DisableState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectFragment-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CutoffState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CutoffState-SetCutoffY0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CutoffState-SetMode0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildDismissState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HighLightState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HighLightState-SetData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HighLightState-GetEffectType0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HighLightState-IsHighlight0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HighLightState-HighlightWithSubIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HighLightState-ClearHighlightableIndexList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HintState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FigureState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OverloadState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OverloadInvalidState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-DitherState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintState-SetEnable1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintState-IsLighten0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintState-LightenWithSubIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintState-ClearLightenIndexList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PreSelectState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PreSelectState-IsLighten0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PreSelectState-LightenWithSubIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PreSelectState-ClearLightenIndexList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SoloSelectState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SoloSelectState-IsLighten0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ContinuationState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ContinuationState-IsLighten0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ContinuationState-LightenWithSubIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ContinuationState-ClearLightenIndexList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SocialSharingState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PowerInteractionState-SetEnable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_anyEffect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BattleFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-Binded0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-UnbindRenderEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-ClearBindRenderEntities0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-HasRenderer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BindRenderEntityFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BurnPowerFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BusFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BusFreeFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CacheFragment-CalcIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CacheFragment-GetCacheItem0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CacheFragment-SetCacheItem0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CacheFragment-SetCacheSize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CacheFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CacheTransportFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoFragment-PredictPos0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoFragment-PredictPosWithDeltaTime0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoFragment-CompareTo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoFragment-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ChapterFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CollectorFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConnectionFragment-get_valid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConnectionFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-CalcRect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-SetInflection0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-Sample0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-IsInRect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-GetInRectUnitIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-FillRectTargets0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-DrawDebug0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorLogisticsUnitFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LeftFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-RightFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-MidFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CullResultFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-DebugFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtDestroyUnit-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ShowStateUI-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ShowNameUI-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HasRenderer-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtUpdatePipeEffect-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtChangeTemplate-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtCreateUnitRenderer-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtUpdateStatusEffect-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtPendingCreateRenderer-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtUpdateRendererProperty-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtStatusChange-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtCreateInteract-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtVatUpdate-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtUpdatePedestalColorLUT-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-EvtAudio-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ReleaseTagFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CurMapUnitTag-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitFragment-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRenderPipeLogisticsFigureReplaceFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BusRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRenderBuildingFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRenderPedestalFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRendererRegularFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitOnlyRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FakeUnitFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UIUnitFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GuideHintFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRegularFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorGuideFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeRegularFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorPreviewRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipePreviewRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipePreviewFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FigureRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FigureRenderLeftFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FigureRenderRightFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FigureRenderMidFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FigureRenderPipeHolderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidConsumeFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-Set0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-SetCapacity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-SetAmount0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-Get0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-HasLiquid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-CalcRenderItemAmount0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-GetOffsetData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidContainerFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidPumpInFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidPumpOutFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidReactionFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidSprayFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FormulaManualFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutOfBufferWarning-ResetFlags0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutOfBufferWarning-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_facSystemTickEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-InitSkipFlag0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-CreateQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-DisposeQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_portBlockPosListReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_outputUIPosListReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_buildingStatePosListReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapCargoBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_cargoDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapConveyorBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_conveyorDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapPortArrowBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_portArrowDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_conveyorInsideMatricesReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapPreviewConveyorBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_previewConveyorDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapGuideFigureBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapPipeBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_pipeDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_pipeHolderPosMatricesReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_comPosMatricesReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-SwapWireBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_wireNormalDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_wireHsNormalDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_wireDisableDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_wireHsStrengthenDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDisableDirty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-AllocateConveyorInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-CalculateConveyorInfoSize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-ResizeConveyorInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-FreeConveyorInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-DebugAllocatorPrint0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_animatorParamRequestQueueReader0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetParameterIndexAndType0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-_AddAnimatorParamRequest0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorParamRequest0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-get_animatorAudioQueueWriter0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataAt0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataLength0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-ClearAudioVATData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-ResetFlags0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalEnv-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-HealthPoleFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InventoryFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LiquidPurifierFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LogisticEffectFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LogisticEntityBindFragment-EnqueueCargoEntityImpl0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LogisticEntityBindFragment-DequeueCargoEntityImpl0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LogisticEntityBindFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-MapGridRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-Clean0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-GetColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-SetColor1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-GetAtlasRect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-GetEnableLiquidIcon0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-SetEnableLiquidIcon0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-GetLiquidIconUV0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-SetLiquidIconUV0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-get_hasOutput0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputUIRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetIntensity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashIntensity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlash0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashDuration0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetIntensity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashIntensity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlash0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashDuration0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeEffectFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-SetInflection0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-Bend0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-GetCornerIndexList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-Sample0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-IsInRect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-GetInRectUnitIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-FillRectTargets0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeHolderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeLogisticsUnitFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeComRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeTrackRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-BindComponentId0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-BlockPortsWithComponentId0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-BlockPorts0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-FollowUnit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortBlocked0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortConnected0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-Equals1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-GetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-op_Equality0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-op_Inequality0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ComplexPortFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-TRS0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-Equals1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-GetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-op_Equality0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortData-op_Inequality0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStatusUIFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PowerPoleFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ProducerFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataFragment-GetExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataFragment-DestroyData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SharedDataFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SocialFragment-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SocialFragment-IsHighLiked0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SocialFragment-IsLiked0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SocialFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SignData-GetText0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SignData-GetCustomPerDrawData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SignData-SetSignBuildingIconWithRenderEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-SignData-SetSignBuildingIcon0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromMatrix0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromMatrixSafe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromPositionRotation0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromPositionRotationScale0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromPosition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromPosition1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromRotation0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-FromScale0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-TransformDirection0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Right0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Up0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Forward0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-TransformPoint0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-InverseTransformPoint0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-InverseTransformDirection0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-TransformRotation0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-InverseTransformRotation0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-TransformScale0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-InverseTransformScale0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-TransformTransform0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-InverseTransformTransform0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Inverse0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-ToInverseMatrix0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-WithPosition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-WithPosition1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-WithRotation0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-WithScale0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Translate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-ApplyScale0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Rotate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-RotateX0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-RotateY0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-RotateZ0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalTransform-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Root-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Parent-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Child-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-SetValue0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-get_right0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-get_up0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-get_forward0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-get_position0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-get_prePosition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorld-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UdPipeFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitConfigFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactoryUnitExtendConfig-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitInteractFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRenderFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-RenderLookAtFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ChapterTagFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitStatusFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitOverrideStatusFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitStatusEffectFragment-SetEffects0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitStatusEffectFragment-GetEffect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitStatusEffectFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitTransFragment-InBound0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitTransFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ValveFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BoxValve-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FluidValve-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-ContainsNodeId0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-RemoveEntityFromSlot0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-FindEmptySlotIdx0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSuitableSlotIdx0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-SetSlotId0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotIds0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-AppendSlotInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-ClearSlotInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-DiffSlotInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-GetPendingEntityCountInSlot0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotInfo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-GetAllPendingEntitiesInSlot0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-CreateDefault0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BlueprintSlotInfo-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRendererInfo-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitId-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitId-Equals1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitId-GetHashCode0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Visibility-GetVisible0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Visibility-get_isVisible0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Visibility-SetVisible0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireRendererFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-Reset0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-ResetOverride0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrCullDis0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrUI0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrBuildingName0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrWireCullDis0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-ResetOverride0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-Disable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_nearByCheck0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_portPreviewCheckDistance0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_pedestalFlashCheckDistance0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_logisticEffectCheckDistance0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_unitRendererCheckDistance0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_l2wCheckDistance0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_additiveEffectCheckDistance0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-Disable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-ResetOverride0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-get_buildingNameShadowDisable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetBuildCurve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve00;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve10;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-UpdateGrid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_ParseGlobalPortIdx0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-ContainsKey0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Clear0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-_GetKey0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-ApplyPass0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-set_Item0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-set_Item0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Parse0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-get_Item0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-GetPerDrawPassConfig0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-get_Item0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-GetPerDrawConfig0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-Disable0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-ResetOverride0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_crossCollectFrameInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_cullingSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_unitPreviewSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portPreviewRenderSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingStateSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portBlockSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_outputUISystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingNameSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_adjustGroundSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_gridSystemInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Parse0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Get0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-PreExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-LateExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-CleanUp0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-TearDown0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-ScheduleNoneDependencies0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-StructuralSync0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-InLowFrameMode0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BaseProcessor-SpecialEntityExisted0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetApplyRenderPointer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetFacRegionValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryStateIconPathFuncPtr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetLogicEntityWithPosAdapter0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryBuildingStatePointer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetSetEntityFlashStatuePointer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-_OnStackEmpty0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-_UpdateInternalStateLifeCycle0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-_InitBuildState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPNormalEffectExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildEffectExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildCutoffEffectExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ResetMaterial0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateStart0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateEnd0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0Start0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0End0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioJobs-AudioDistanceAndCullingJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-_DoCalculate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-SetGlobalEnv0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchArrowJob-_BatchPortArrow0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePort0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePreview0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchArrowJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchArrowJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchArrowJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchInsideConveyorJob-_BatchPortInside0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchInsideConveyorJob-_CollectInsideConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchInsideConveyorJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchNormalArrowJob-_BatchPortArrow0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchNormalArrowJob-_ExecutePort0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchNormalArrowJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchPreviewArrowJob-_BatchPortArrow0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchPreviewArrowJob-_ExecutePreview0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchPreviewArrowJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BatchPreviewArrowJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BufferSwapJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingLiquidRenderJob-_ApplyLiquidPerDraw0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingLiquidRenderJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingStatePosCollectJob-_Collect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingStatePosCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-BuildingStateRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoCollectJob-SetGlobalEnvRef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoCollectJob-SetConveyorExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictJob-SetConveyorExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoRenderJob-SetRendererList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoRenderQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoRenderQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorCollectJob-_Collect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorCollectJob-Execute2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorFigureRendererJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorInsideRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-_Collect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRendererJob-_UpdateCachedConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRendererJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ConveyorRendererJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-_SwapBuffer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-IsPointInSector0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-SetData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteBuilding0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-_SnapDirectionToAxis0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-_CheckDist0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecutePipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-IsPending0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-InteractFacCollectJob-LogisticInfo-IsPending0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldJob-TransTRS0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldJob-SetHierarchyData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LocalToWorldQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LogisticEffectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LookAtJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LookAtJob-SetHierarchyData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LookAtJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LookAtJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LookAtQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-LookAtQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputCollectJob-_Collect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputCollectJob-Execute2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-OutputRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalFlashJob-_Flash0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalFlashJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalFlashJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PedestalFlashJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipeCom0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-_CollectTrack0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePreviewPipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-Execute2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-SetGlobalEnvRef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeComRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFigureRendererJob-_UpdateCachedPipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeHolderHideRendererJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeRendererJob-_UpdateCachedPipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeRendererJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeTrackRendererJob-_UpdateCachedTrack0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeTrackRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetGlobalEnv0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortArrowRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStateCollectJob-_Collect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStateCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStateCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStateCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStateCollectJob-Execute2;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PortStateRendererJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PreviewUnitQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PreviewUnitQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PumpInEffectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PumpInEffectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PumpInEffectJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PumpInEffectJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PumpInEffectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-StatusChangeJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitCullingJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitCullingJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitCullingJob-SetGlobalEnvRef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitCullingJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetGlobalEnvRef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitPreviewRenderJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRendererQueryJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UnitRendererQueryJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetQueryResult0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-ScheduleDefer0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireCollectJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireCollectJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireCollectJob-SetGlobalEnvRef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireCollectJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireRenderJob-_UpdateCachedWire0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireRenderJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-WireRenderJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FPtrNativeCurve-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FPtrNativeCurve-CreateCurve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FPtrNativeCurve-Evaluate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawPassConfig-Size0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawPassConfig-_ParseToHGShaderLightMode0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawPassConfig-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawPassConfig-Apply1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-Size0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-_OnColorChanged0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-_OnFloat4Changed0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-_OnFloatChanged0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-PerDrawConfig-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ProcessorInterval-_CheckInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ProcessorInterval-CheckInterval0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CargoPredictProcessor-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearBuildingPtr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearConveyorPtr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearPipePtr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CrossFrameProcessor-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CrossFrameProcessor-LateExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-CrossFrameProcessor-TearDown0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPreviewConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectGuideConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateCurrent0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateAllocator0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_InitArrowPlaced0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectBuildingState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectOutput0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectCargo0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectWire0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipeLogistics0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrowWithDiff0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrow0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-LateExecute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FacRendererCollectProcessor-TearDown0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetIndex0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-CreateOrGet0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetIndicatorColor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateName0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetPerDrawList0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-FFactoryStateColorConfig-LogicStateConfig-_OnColorChanged0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetFloat0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetInt0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetBool0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetAllTriggers0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetParametersByDef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Enter0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-Init0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Exit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Exit0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-ToNextState0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Enter0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetTransition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-__AOT_FOR_FIX__0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMState-get_process0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Update0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMState-SetProgress0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_fromStateWeight0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Update0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetFloat0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetInt0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetBool0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetTrigger0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetTrigger0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetTrigger0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetValue0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetValue0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMSetParamRequestHandlerJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-_Evaluate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetValidTransition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-ResetUsedTriggers0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_CheckTransitions0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_AddVATAudioData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_ComputeVATFrameData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-SetSharedExtData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_RemoveDuplicationRequest0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_HandleSetAnimatorParamRequest0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-TearDown0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-AnimationClipData-GetClipDesStr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Size0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-AsSpan0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reserve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-InitFSMDefinition0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-RegisterFSM0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateName0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Util-JobHandlerExtensions-SafeComplete0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-BurstBridge-BeginProfilerSample0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-BurstBridge-EndProfilerSample0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-QueryBuildingStateIsClosed0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-_IsPowerBuilding0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithLogicEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithRendererEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibilityWithNotify0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetInMainRegion0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-IsInMainRegionFuzzy0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingExtendConfig0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GameplayExtensions-GetChapterEntity0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvPtr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-IsGlobalEnvValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvRef0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractFac0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractConveyor0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractPipe0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_MergeAdjacentFreeBlocks0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_ExpandMemory0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Allocate0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Reserve0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Free0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Expand0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Resize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocator-PrintAllocations0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-GetFreeSpace0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-MappingInsert0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AllocManualNodeId0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AddressOf0;  // const

    }

}

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002  // size: 0x10
    public sealed class EmbeddedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class IsUnmanagedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.HyperGryph.ECS
{

    // TypeToken: 0x2000007  // size: 0x10
    public static class ColliderComponentExtensions
    {
        // Methods
        // RVA: 0x026E1310  token: 0x600000C
        public static System.Void ToggleCollision(UnityEngine.HyperGryph.ECS.Entity logicEntity, System.Boolean enable, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x0294A510  token: 0x600000D
        public static System.Void Toggle(UnityEngine.HyperGryph.ECS.ECSColliderComponent& collision, System.Boolean enable) { }
        // RVA: 0x0294AD30  token: 0x600000E
        public static System.Void UpdateCollisionTRS(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x0294BB80  token: 0x600000F
        public static System.Void UpdateCollisionTRS(UnityEngine.HyperGryph.ECS.ECSColliderComponent c, Unity.Mathematics.float3 pos, Unity.Mathematics.quaternion rot) { }
        // RVA: 0x02AAC900  token: 0x6000010
        public static System.Void DestroyCollisionWithRenderEntity(UnityEngine.HyperGryph.ECS.Entity rEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x0578D580  token: 0x6000011
        public static System.Void DestroyCollision(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x0294A5E0  token: 0x6000012
        private static System.Void <ToggleCollision>g__Toggle|0_0(UnityEngine.HyperGryph.ECS.Entity rendererEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.ColliderComponentExtensions.<>c__DisplayClass0_0& ) { }
        // RVA: 0x0294B260  token: 0x6000013
        private static System.Void <UpdateCollisionTRS>g__UpdateTRS|2_0(UnityEngine.HyperGryph.ECS.Entity rendererEntity, UnityEngine.HyperGryph.ECS.EntityManager& em) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public static class ECSExtensions
    {
        // Methods
        // RVA: 0x02433940  token: 0x6000014
        public static UnityEngine.HyperGryph.ECS.Entity GetEntity(UnityEngine.HyperGryph.ECS.GroupType group, System.Int32 index) { }
        // RVA: 0x023F4300  token: 0x6000015
        public static System.Boolean HasComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, System.Int32 componentId) { }
        // RVA: 0x02C5E9B0  token: 0x6000016
        public static System.Void CreateEntities(UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> archetypes, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> result) { }
        // RVA: 0x0241C8B0  token: 0x6000017
        public static UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityManager& entityManager) { }
        // RVA: 0x02755860  token: 0x6000018
        public static UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> archetypes) { }
        // RVA: -1  // generic def  token: 0x6000019
        public static System.Void Is(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Boolean flag) { }
        // RVA: -1  // generic def  token: 0x600001A
        public static System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: 0x0241D6F0  token: 0x600001B
        public static System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId, System.IntPtr& component, System.Int32 componentSize) { }
        // RVA: -1  // generic def  token: 0x600001C
        public static System.Void AddOrSetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, T t) { }
        // RVA: -1  // generic def  token: 0x600001D
        public static System.Void AddOrSetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, T1 t1, T2 t2) { }
        // RVA: 0x03386BB0  token: 0x600001E
        public static System.Void SetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId, System.IntPtr& component, System.Int32 componentSize) { }
        // RVA: -1  // generic def  token: 0x600001F
        public static System.Void SetComponents(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1, T2& t2) { }
        // RVA: -1  // generic def  token: 0x6000020
        public static System.Void SetComponents(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1, T2& t2, T3& t3) { }
        // RVA: -1  // generic def  token: 0x6000021
        public static System.Void SetComponents(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1, T2& t2, T3& t3, T4& t4) { }
        // RVA: 0x023F4F60  token: 0x6000022
        private static System.Void _SetComponentImpl(UnityEngine.HyperGryph.ECS.EntityInstanceData& entityData, UnityEngine.HyperGryph.ECS.EntityTypeInstanceData& entityTypeData, System.Int32 componentId, System.IntPtr& component, System.Int32 componentSize) { }
        // RVA: 0x02434950  token: 0x6000023
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder& queryBuilder) { }
        // RVA: -1  // generic def  token: 0x6000024
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000025
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000026
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000027
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000028
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000029
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x600002A
        public static UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x0578DF1C  token: 0x600002B
        public static System.Void GetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId, System.Int32 componentSize, System.Void* componentPtr) { }
        // RVA: -1  // generic def  token: 0x600002C
        public static System.Boolean MoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity src, UnityEngine.HyperGryph.ECS.Entity des) { }
        // RVA: 0x02420E00  token: 0x600002D
        public static System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId) { }
        // RVA: -1  // generic def  token: 0x600002E
        public static System.Void SafeRemoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x600002F
        public static System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager) { }
        // RVA: -1  // generic def  token: 0x6000030
        public static System.Boolean GetInstance(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, TR& component) { }
        // RVA: -1  // generic def  token: 0x6000031
        public static System.Boolean GetFirst(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, TR& component) { }
        // RVA: -1  // generic def  token: 0x6000032
        public static System.Boolean GetFirst(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, TR& component) { }
        // RVA: -1  // generic def  token: 0x6000033
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity) { }
        // RVA: -1  // generic def  token: 0x6000034
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity, T t) { }
        // RVA: -1  // generic def  token: 0x6000035
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity, T1 t1, T2 t2) { }
        // RVA: -1  // generic def  token: 0x6000036
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000037
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, T t) { }
        // RVA: -1  // generic def  token: 0x6000038
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, T1 t1, T2 t2) { }
        // RVA: 0x0578DCEC  token: 0x6000039
        public static System.Void DestroyEntitiesWithArchetype(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.ComponentMask& entityMask) { }
        // RVA: -1  // generic def  token: 0x600003A
        public static System.Void DestroyEntities(UnityEngine.HyperGryph.ECS.EntityManager& entityManager) { }
        // RVA: -1  // generic def  token: 0x600003B
        public static System.Void DestroyEntities(UnityEngine.HyperGryph.ECS.EntityManager& entityManager) { }
        // RVA: -1  // generic def  token: 0x600003C
        public static System.Boolean HasEntity(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x600003D
        public static System.Boolean HasEntity(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: 0x0578E00C  token: 0x600003E
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 compId) { }
        // RVA: 0x0578E180  token: 0x600003F
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 compId0, System.Int32 compId1) { }
        // RVA: -1  // generic def  token: 0x6000040
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000041
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000042
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000043
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000044
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000045
        public static System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em) { }
        // RVA: -1  // generic def  token: 0x6000046
        public static System.Void EnsureComponent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000047
        public static System.Void EnsureComponent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, T& comp) { }
        // RVA: -1  // generic def  token: 0x6000048
        public static UnityEngine.HyperGryph.ECS.ECSSpan<T> GetComponentAsSpan(UnityEngine.HyperGryph.ECS.GroupType groupType) { }
        // RVA: -1  // generic def  token: 0x6000049
        public static UnityEngine.HyperGryph.ECS.ECSSpan<T> GetComponentAsSpan(UnityEngine.HyperGryph.ECS.GroupType groupType, System.Int32 componentId) { }
        // RVA: 0x02F1F010  token: 0x600004A
        public static UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5, System.Int32 id6) { }
        // RVA: 0x02F6D7C0  token: 0x600004B
        public static UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5, System.Int32 id6, System.Int32 id7) { }
        // RVA: 0x03D55830  token: 0x600004C
        public static UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5, System.Int32 id6, System.Int32 id7, System.Int32 id8) { }

    }

    // TypeToken: 0x200000A  // size: 0x10
    public static class HGFactoryRendererBinderExtensions
    {
        // Methods
        // RVA: 0x0578F6D4  token: 0x600004D
        public static System.Void RenderWithTRS(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, Beyond.Gameplay.Factory.LocalToWorld& localToWorld) { }
        // RVA: 0x0578F870  token: 0x600004E
        public static System.Void RenderWithTRS(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, Unity.Mathematics.float4x4 value) { }
        // RVA: 0x026E3920  token: 0x600004F
        public static System.Void EnableDither(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, System.Boolean enable, System.Single alphaValue, UnityEngine.HyperGryph.HGObjectFlags objectFlags) { }
        // RVA: 0x026E3740  token: 0x6000050
        public static System.Void EnableDither(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, System.Boolean enable, System.Single alphaValue, UnityEngine.HyperGryph.HGObjectFlags objectFlags) { }

    }

    // TypeToken: 0x200000B  // size: 0x70
    public sealed struct EntityCommandBuffer
    {
        // Fields
        public UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallback onEntityCreate;  // 0x10
        public UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallback onEntityDestroy;  // 0x18
        public UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallback onComponentUpdate;  // 0x20
        public UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallback onComponentAdd;  // 0x28
        public UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallback onComponentRemove;  // 0x30
        public static System.UInt32 TempIdx;  // static @ 0x0
        public Unity.Collections.NativeQueue<UnityEngine.HyperGryph.ECS.EntityCommandBufferData> buffers;  // 0x38
        public Unity.Collections.NativeParallelHashMap<System.UInt64,UnityEngine.HyperGryph.ECS.EntityCommandBuffer.VirtualEntityMap> tempEntities;  // 0x50
        private readonly UnityEngine.HyperGryph.ECS.EntityManager <entityManager>k__BackingField;  // 0x60

        // Properties
        UnityEngine.HyperGryph.ECS.EntityManager entityManager { get; /* RVA: 0x03D55950 */ }

        // Methods
        // RVA: 0x02751B20  token: 0x6000051
        public System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, Unity.Collections.Allocator allocator) { }
        // RVA: 0x02420010  token: 0x6000053
        public System.ValueTuple<System.Boolean,UnityEngine.HyperGryph.ECS.Entity> GetRealEntity(UnityEngine.HyperGryph.ECS.Entity virtualEntity) { }

    }

    // TypeToken: 0x200000E  // size: 0x10
    public static class EntityCommand
    {
        // Methods
        // RVA: 0x02751AE0  token: 0x6000058
        public static UnityEngine.HyperGryph.ECS.EntityCommandBuffer CreateCommandBuffer(UnityEngine.HyperGryph.ECS.EntityManager entityManager, Unity.Collections.Allocator allocator) { }
        // RVA: 0x026037B0  token: 0x6000059
        public static UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb) { }
        // RVA: 0x02603550  token: 0x600005A
        public static System.Void DestroyEntity(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x600005B
        public static System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x600005C
        public static System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T component) { }
        // RVA: -1  // generic def  token: 0x600005D
        public static System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x600005E
        public static System.Void SetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T component) { }
        // RVA: -1  // generic def  token: 0x600005F
        public static System.Void Is(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, System.Boolean flag) { }
        // RVA: -1  // generic def  token: 0x6000060
        public static System.Void GetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T& component) { }
        // RVA: -1  // generic def  token: 0x6000061
        private static System.Void* _ComponentCpy(T component) { }
        // RVA: -1  // generic def  token: 0x6000062
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000063
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T t) { }
        // RVA: -1  // generic def  token: 0x6000064
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000065
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T component) { }
        // RVA: 0x0241F5C0  token: 0x6000066
        public static System.Void Playback(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, System.Boolean autoDispose) { }
        // RVA: 0x02420E50  token: 0x6000067
        public static System.Void Dispose(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb) { }

    }

    // TypeToken: 0x200000F  // size: 0x10
    public class EntityCommandOp
    {
        // Fields
        public static readonly System.Int32 CREATE;  // static @ 0x0
        public static readonly System.Int32 ADD;  // static @ 0x4
        public static readonly System.Int32 REMOVE;  // static @ 0x8
        public static readonly System.Int32 MODIFY;  // static @ 0xc
        public static readonly System.Int32 DESTROY;  // static @ 0x10
        public static readonly System.Int32 QUERY;  // static @ 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000068
        public System.Void .ctor() { }
        // RVA: 0x03CF0C70  token: 0x6000069
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x30
    public sealed struct EntityCommandBufferData
    {
        // Fields
        public System.Int32 op;  // 0x10
        public UnityEngine.HyperGryph.ECS.Entity entity;  // 0x14
        public UnityEngine.HyperGryph.ECS.CommandBufferComponent componentData;  // 0x20

        // Methods
        // RVA: 0x0426FD78  token: 0x600006A
        public System.Void Free() { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public sealed struct CommandBufferComponent
    {
        // Fields
        public System.Int32 componentId;  // 0x10
        public System.Int32 componentSize;  // 0x14
        public System.Void* component;  // 0x18

    }

    // TypeToken: 0x2000012  // size: 0x38
    public sealed struct EntityCommandBufferV2 : Unity.Collections.INativeDisposable, System.IDisposable
    {
        // Fields
        public static System.Int32 s_mapSize;  // static @ 0x0
        public Unity.Collections.NativeQueue<UnityEngine.HyperGryph.ECS.EntityCommandBufferData> buffers;  // 0x10
        public Unity.Collections.NativeParallelHashMap<System.UInt64,UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.VirtualEntityMap> tempEntities;  // 0x28

        // Properties
        System.Boolean isEmpty { get; /* RVA: 0x0578E42C */ }

        // Methods
        // RVA: 0x03C787B0  token: 0x600006B
        public System.Void .ctor(Unity.Collections.Allocator allocator) { }
        // RVA: 0x0241E560  token: 0x600006C
        public System.ValueTuple<System.Boolean,UnityEngine.HyperGryph.ECS.Entity> GetRealEntity(UnityEngine.HyperGryph.ECS.Entity virtualEntity) { }
        // RVA: 0x0241F0A0  token: 0x600006D
        public System.Void Reset() { }
        // RVA: 0x0578E3C0  token: 0x600006E
        public virtual System.Void Dispose() { }
        // RVA: 0x0578E2F4  token: 0x600006F
        public virtual Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle dependsOn) { }
        // RVA: 0x02309D90  token: 0x6000071
        public UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter AsParallelWriter() { }
        // RVA: 0x03D44920  token: 0x6000072
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public static class EntityCommandV2
    {
        // Fields
        private static readonly System.Collections.Generic.Queue<UnityEngine.HyperGryph.ECS.EntityCommandBufferV2> S_POOL;  // static @ 0x0

        // Methods
        // RVA: 0x023081E0  token: 0x6000073
        public static UnityEngine.HyperGryph.ECS.EntityCommandBufferV2 CreateConcurrentCommandBufferV2(UnityEngine.HyperGryph.ECS.EntityManager em) { }
        // RVA: 0x0578E7A4  token: 0x6000074
        public static System.Void DisposePool() { }
        // RVA: 0x0241ED90  token: 0x6000075
        public static System.Void Recycle(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2& buffer) { }
        // RVA: 0x0578E5EC  token: 0x6000076
        public static UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer) { }
        // RVA: 0x0578E704  token: 0x6000077
        public static System.Void DestroyEntity(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000078
        public static System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000079
        public static System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T component) { }
        // RVA: -1  // generic def  token: 0x600007A
        public static System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x600007B
        public static System.Void SetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T component) { }
        // RVA: -1  // generic def  token: 0x600007C
        public static System.Void GetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T& component) { }
        // RVA: -1  // generic def  token: 0x600007D
        private static T* _ComponentCpy(T component) { }
        // RVA: -1  // generic def  token: 0x600007E
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x600007F
        public static System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T t) { }
        // RVA: -1  // generic def  token: 0x6000080
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // generic def  token: 0x6000081
        public static System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T component) { }
        // RVA: 0x0241DB30  token: 0x6000082
        public static System.Void Playback(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2 ecb, System.Boolean autoRecycle) { }
        // RVA: 0x03CDEFC0  token: 0x6000083
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public sealed struct ECSSpan`1
    {
        // Fields
        public System.Void* buffer;  // 0x0
        public System.Int32 length;  // 0x0

        // Properties
        T& Item { get; /* RVA: -1  // not resolved */ }

    }

    // TypeToken: 0x2000017
    public sealed struct EntityPool`3
    {
        // Fields
        private System.Int32 <defaultSize>k__BackingField;  // 0x0
        private System.Int32 m_count;  // 0x0
        private System.Int32 m_usedCount;  // 0x0
        public Unity.Mathematics.float4x4 customData;  // 0x0
        private Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> m_pool;  // 0x0
        private System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float3,Unity.Mathematics.float3,UnityEngine.Matrix4x4,Unity.Mathematics.float4x4> m_onSpawn;  // 0x0
        private System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float4x4> m_onRecycle;  // 0x0
        private System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4> m_onAllocate;  // 0x0
        private System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4> m_onDeallocate;  // 0x0
        private Unity.Collections.Allocator m_allocator;  // 0x0

        // Properties
        System.Int32 defaultSize { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        UnityEngine.HyperGryph.ECS.Entity Item { get; /* RVA: -1  // not resolved */ }
        Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> entities { get; /* RVA: -1  // not resolved */ }
        System.Boolean initialized { get; /* RVA: -1  // not resolved */ }
        System.Int32 length { get; /* RVA: -1  // not resolved */ }
        System.Int32 cacheSize { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000087
        public System.Boolean DecreasePool() { }
        // RVA: -1  // not resolved  token: 0x6000088
        public System.Boolean NeedToResize(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000089
        public UnityEngine.HyperGryph.ECS.Entity Spawn(Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, UnityEngine.Matrix4x4 fArgs) { }
        // RVA: -1  // not resolved  token: 0x600008A
        public UnityEngine.HyperGryph.ECS.Entity Spawn(System.Boolean& resized) { }
        // RVA: -1  // not resolved  token: 0x600008B
        public System.Boolean Spawn(System.Int32 n) { }
        // RVA: -1  // not resolved  token: 0x600008C
        public System.Void Recycle(System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x600008D
        public UnityEngine.HyperGryph.ECS.Entity Recycle(UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: -1  // not resolved  token: 0x600008F
        public static UnityEngine.HyperGryph.ECS.EntityPool<T0,T1,T2> Alloc(System.Int32 count, System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float3,Unity.Mathematics.float3,UnityEngine.Matrix4x4,Unity.Mathematics.float4x4> onSpawn, System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float4x4> onRecycle, System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4> onAllocate, System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4> onDeallocate, Unity.Mathematics.float4x4 customData, Unity.Collections.Allocator allocator, System.Boolean autoAllocate) { }
        // RVA: -1  // not resolved  token: 0x6000090
        public System.Void Free() { }
        // RVA: -1  // not resolved  token: 0x6000091
        private System.Void _Resize() { }
        // RVA: -1  // not resolved  token: 0x6000092
        public static Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> op_Implicit(UnityEngine.HyperGryph.ECS.EntityPool<T0,T1,T2> pool) { }
        // RVA: -1  // not resolved  token: 0x6000094
        public Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> AsReadOnly() { }

    }

    // TypeToken: 0x2000018  // size: 0x28
    public class EntityHierarchyContainer
    {
        // Fields
        public static System.Int32 INVALID_INDEX;  // const
        private Beyond.HGArray<UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.Node> m_nodes;  // 0x10

        // Properties
        UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& Item { get; /* RVA: 0x027676D0 */ }
        UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& Item { get; /* RVA: 0x027676D0 */ }

        // Methods
        // RVA: 0x02C34D20  token: 0x6000098
        public System.Void .ctor(Unity.Collections.Allocator allocator) { }
        // RVA: 0x0578E918  token: 0x6000099
        public System.Void Dispose() { }
        // RVA: 0x0578E9B4  token: 0x600009A
        public System.UInt32 Size() { }
        // RVA: 0x0578E8A8  token: 0x600009B
        public System.Span<UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData> AsSpan() { }
        // RVA: 0x0578EB34  token: 0x600009C
        public Beyond.Gameplay.Factory.LocalTransform WorldTrans(System.UInt32 handle) { }
        // RVA: 0x0578E9E8  token: 0x600009D
        public Beyond.Gameplay.Factory.LocalTransform WorldTrans(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData transform) { }
        // RVA: 0x028B4AF0  token: 0x600009E
        public static Beyond.Gameplay.Factory.LocalTransform WorldTrans(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData transform, UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData* hierarchyContainer) { }
        // RVA: 0x02765500  token: 0x600009F
        public System.UInt32 Create(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& value) { }
        // RVA: 0x02AADB90  token: 0x60000A0
        public System.Void Destroy(System.UInt32 handle) { }
        // RVA: 0x02C34840  token: 0x60000A1
        public System.Void Reset() { }
        // RVA: 0x0578E96C  token: 0x60000A2
        public System.Void Reserve(System.UInt32 newCapacity) { }
        // RVA: 0x026E0BE0  token: 0x60000A3
        public System.IntPtr Data() { }
        // RVA: 0x0578E95C  token: 0x60000A6
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& Get(System.UInt32 handle) { }
        // RVA: 0x0578E964  token: 0x60000A7
        public UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& Get(System.Int32 handle) { }

    }

    // TypeToken: 0x200001B  // size: 0x18
    public sealed struct EntityQueryBuilder
    {
        // Fields
        private UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData* builderDataPtr;  // 0x10

        // Methods
        // RVA: 0x026E8D50  token: 0x60000A8
        public System.Void .ctor(System.Int32 maxCount) { }
        // RVA: 0x026E8CD0  token: 0x60000A9
        public static UnityEngine.HyperGryph.ECS.EntityQueryBuilder Create(System.Int32 maxCount) { }
        // RVA: -1  // generic def  token: 0x60000AA
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000AB
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000AC
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000AD
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000AE
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000AF
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000B0
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll() { }
        // RVA: -1  // generic def  token: 0x60000B1
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone() { }
        // RVA: -1  // generic def  token: 0x60000B2
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone() { }
        // RVA: -1  // generic def  token: 0x60000B3
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone() { }
        // RVA: -1  // generic def  token: 0x60000B4
        public UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone() { }
        // RVA: 0x04271414  token: 0x60000B5
        public UnityEngine.HyperGryph.ECS.EntityManagerRange Build(UnityEngine.HyperGryph.ECS.EntityManager& em) { }

    }

    // TypeToken: 0x200001E  // size: 0x10
    public static class EntityQueryV2
    {
        // Methods
        // RVA: 0x026E6FC0  token: 0x60000B7
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder& builder, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: 0x0578EEFC  token: 0x60000B8
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& QueryDefer(UnityEngine.HyperGryph.ECS.EntityManager em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder& builder, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qrd, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000B9
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000BA
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000BB
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000BC
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000BD
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000BE
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000BF
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000C0
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: -1  // generic def  token: 0x60000C1
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }
        // RVA: 0x0578EBAC  token: 0x60000C2
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer GetBlockRangesDefer(UnityEngine.HyperGryph.ECS.EntityManagerRange range, System.Int32 jobCount, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr) { }
        // RVA: 0x026E73B0  token: 0x60000C3
        public static UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult GetBlockRanges(UnityEngine.HyperGryph.ECS.EntityManagerRange range, Unity.Collections.Allocator allocator, System.Int32 jobCount) { }

    }

    // TypeToken: 0x2000023  // size: 0x80
    public sealed class Wrapper_000000D7$PostfixBurstDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x05790CDC  token: 0x60000D9
        public System.Void .ctor(System.Object , System.IntPtr ) { }
        // RVA: 0x02097E50  token: 0x60000DA
        public virtual System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount) { }
        // RVA: 0x05790C40  token: 0x60000DB
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount, System.AsyncCallback , System.Object ) { }
        // RVA: 0x042BD330  token: 0x60000DC
        public virtual System.Void EndInvoke(System.IAsyncResult ) { }

    }

    // TypeToken: 0x2000024  // size: 0x10
    public static class Wrapper_000000D7$BurstDirectCall
    {
        // Fields
        private static System.IntPtr Pointer;  // static @ 0x0
        private static System.IntPtr DeferredCompilation;  // static @ 0x8

        // Methods
        // RVA: 0x026E8180  token: 0x60000DD
        private static System.Void GetFunctionPointerDiscard(System.IntPtr& ) { }
        // RVA: 0x026E7F60  token: 0x60000DE
        private static System.IntPtr GetFunctionPointer() { }
        // RVA: 0x03CE8F00  token: 0x60000DF
        public static System.Void Constructor() { }
        // RVA: 0x0350B670  token: 0x60000E0
        public static System.Void Initialize() { }
        // RVA: 0x03CE8EF0  token: 0x60000E1
        private static System.Void .cctor() { }
        // RVA: 0x026E7EA0  token: 0x60000E2
        public static System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount) { }

    }

    // TypeToken: 0x2000022  // size: 0x10
    public static class QueryResultWrapper
    {
        // Methods
        // RVA: 0x026E7D80  token: 0x60000D7
        public static System.Void Wrapper(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount) { }
        // RVA: 0x0578FFB8  token: 0x60000D8
        public static System.Void Wrapper$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount) { }

    }

}

