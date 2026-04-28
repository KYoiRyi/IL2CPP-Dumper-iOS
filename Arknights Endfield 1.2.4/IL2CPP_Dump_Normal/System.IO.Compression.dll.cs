// ========================================================
// Dumped by @desirepro
// Assembly: System.IO.Compression.dll
// Classes:  18
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x10
    public static class Brotli
    {
        // Methods
        // RVA: 0x03790590  token: 0x6000001
        private static Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque) { }
        // RVA: 0x02462950  token: 0x6000002
        private static System.Int32 BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut) { }
        // RVA: 0x042771B4  token: 0x6000003
        private static System.Void BrotliDecoderDestroyInstance(System.IntPtr state) { }
        // RVA: 0x02462580  token: 0x6000004
        private static System.Boolean BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state) { }
        // RVA: 0x09830214  token: 0x6000005
        private static Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque) { }
        // RVA: 0x09830304  token: 0x6000006
        private static System.Boolean BrotliEncoderSetParameter(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderParameter parameter, System.UInt32 value) { }
        // RVA: 0x09830164  token: 0x6000007
        private static System.Boolean BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut) { }
        // RVA: 0x09830294  token: 0x6000008
        private static System.Boolean BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state) { }
        // RVA: 0x0983028C  token: 0x6000009
        private static System.Void BrotliEncoderDestroyInstance(System.IntPtr state) { }

    }

    // TypeToken: 0x2000002  // size: 0x10
    public static class Interop
    {
    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class SR
    {
        // Methods
        // RVA: 0x09830404  token: 0x600000A
        private static System.String Format(System.String resourceFormat, System.Object p1) { }
        // RVA: 0x09830384  token: 0x600000B
        private static System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3) { }

    }

    // TypeToken: 0x2000006  // size: 0x70
    public sealed struct <FinishReadAsyncMemory>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<System.Int32> <>t__builder;  // 0x18
        public System.IO.Compression.BrotliStream <>4__this;  // 0x38
        public System.Threading.CancellationToken cancellationToken;  // 0x40
        public System.Memory<System.Byte> buffer;  // 0x48
        private System.Int32 <totalWritten>5__2;  // 0x58
        private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.Int32> <>u__1;  // 0x60

        // Methods
        // RVA: 0x09830724  token: 0x6000031
        private virtual System.Void MoveNext() { }
        // RVA: 0x0983101C  token: 0x6000032
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000007  // size: 0x68
    public sealed struct <WriteAsyncMemoryCore>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public System.IO.Compression.BrotliStream <>4__this;  // 0x30
        public System.ReadOnlyMemory<System.Byte> buffer;  // 0x38
        public System.Threading.CancellationToken cancellationToken;  // 0x48
        private System.Buffers.OperationStatus <lastResult>5__2;  // 0x50
        private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;  // 0x58

        // Methods
        // RVA: 0x098315E0  token: 0x6000033
        private virtual System.Void MoveNext() { }
        // RVA: 0x09831B88  token: 0x6000034
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x2000008  // size: 0x58
    public sealed struct <FlushAsyncCore>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        // Fields
        public System.Int32 <>1__state;  // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;  // 0x18
        public System.IO.Compression.BrotliStream <>4__this;  // 0x30
        public System.Threading.CancellationToken cancellationToken;  // 0x38
        private System.Buffers.OperationStatus <lastResult>5__2;  // 0x40
        private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;  // 0x48

        // Methods
        // RVA: 0x09831068  token: 0x6000035
        private virtual System.Void MoveNext() { }
        // RVA: 0x09831584  token: 0x6000036
        private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }

    }

    // TypeToken: 0x200000F  // size: 0x28
    public sealed class TaskWrapperAsyncResult : System.IAsyncResult
    {
        // Fields
        private readonly System.Threading.Tasks.Task Task;  // 0x10
        private readonly System.Object _state;  // 0x18
        private readonly System.Boolean _completedSynchronously;  // 0x20

        // Properties
        System.Object System.IAsyncResult.AsyncState { get; /* RVA: 0x01041090 */ }
        System.Boolean System.IAsyncResult.CompletedSynchronously { get; /* RVA: 0x03D4EF90 */ }
        System.Boolean System.IAsyncResult.IsCompleted { get; /* RVA: 0x092945A0 */ }
        System.Threading.WaitHandle System.IAsyncResult.AsyncWaitHandle { get; /* RVA: 0x09294580 */ }

        // Methods
        // RVA: 0x03D01130  token: 0x600004D
        private System.Void .ctor(System.Threading.Tasks.Task task, System.Object state, System.Boolean completedSynchronously) { }

    }

    // TypeToken: 0x2000010  // size: 0x20
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.AsyncCallback callback;  // 0x10
        public System.IAsyncResult asyncResult;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000052
        public System.Void .ctor() { }
        // RVA: 0x09298BD8  token: 0x6000053
        private System.Void <InvokeCallbackWhenTaskCompletes>b__0() { }

    }

namespace Microsoft.Win32.SafeHandles
{

    // TypeToken: 0x2000011  // size: 0x20
    public sealed class SafeBrotliEncoderHandle : System.Runtime.InteropServices.SafeHandle
    {
        // Properties
        System.Boolean IsInvalid { get; /* RVA: 0x025EB8A0 */ }

        // Methods
        // RVA: 0x04272874  token: 0x6000054
        public System.Void .ctor() { }
        // RVA: 0x09830460  token: 0x6000055
        protected virtual System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000012  // size: 0x20
    public sealed class SafeBrotliDecoderHandle : System.Runtime.InteropServices.SafeHandle
    {
        // Properties
        System.Boolean IsInvalid { get; /* RVA: 0x025EB8A0 */ }

        // Methods
        // RVA: 0x04272874  token: 0x6000057
        public System.Void .ctor() { }
        // RVA: 0x03D450D0  token: 0x6000058
        protected virtual System.Boolean ReleaseHandle() { }

    }

}

namespace System.IO.Compression
{

    // TypeToken: 0x2000005  // size: 0x70
    public sealed class BrotliStream : System.IO.Stream
    {
        // Fields
        private System.IO.Stream _stream;  // 0x28
        private readonly System.Byte[] _buffer;  // 0x30
        private readonly System.Boolean _leaveOpen;  // 0x38
        private readonly System.IO.Compression.CompressionMode _mode;  // 0x3c
        private System.Int32 _activeAsyncOperation;  // 0x40
        private System.IO.Compression.BrotliDecoder _decoder;  // 0x48
        private System.Int32 _bufferOffset;  // 0x58
        private System.Int32 _bufferCount;  // 0x5c
        private System.IO.Compression.BrotliEncoder _encoder;  // 0x60

        // Properties
        System.Boolean CanRead { get; /* RVA: 0x09830004 */ }
        System.Boolean CanWrite { get; /* RVA: 0x09830030 */ }
        System.Boolean CanSeek { get; /* RVA: 0x0115F4C0 */ }
        System.Int64 Length { get; /* RVA: 0x0983005C */ }
        System.Int64 Position { get; /* RVA: 0x098300A8 */ set; /* RVA: 0x098300F4 */ }
        System.Boolean AsyncOperationIsActive { get; /* RVA: 0x0982FFFC */ }

        // Methods
        // RVA: 0x03A61760  token: 0x600000C
        public System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen) { }
        // RVA: 0x03334260  token: 0x600000D
        private System.Void EnsureNotDisposed() { }
        // RVA: 0x03B216E0  token: 0x600000E
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0982F7C0  token: 0x600000F
        private static System.Void ValidateParameters(System.Byte[] array, System.Int32 offset, System.Int32 count) { }
        // RVA: 0x0982F6CC  token: 0x6000013
        public virtual System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        // RVA: 0x0982F718  token: 0x6000017
        public virtual System.Void SetLength(System.Int64 value) { }
        // RVA: 0x0982EF94  token: 0x6000019
        private System.Void EnsureNoActiveAsyncOperation() { }
        // RVA: 0x0982EE10  token: 0x600001A
        private System.Void AsyncOperationStarting() { }
        // RVA: 0x0982EE00  token: 0x600001B
        private System.Void AsyncOperationCompleting() { }
        // RVA: 0x0982F764  token: 0x600001C
        private static System.Void ThrowInvalidBeginCall() { }
        // RVA: 0x0982F62C  token: 0x600001D
        public virtual System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        // RVA: 0x025D9CD0  token: 0x600001E
        public virtual System.Int32 Read(System.Span<System.Byte> buffer) { }
        // RVA: 0x0982EE30  token: 0x600001F
        public virtual System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        // RVA: 0x0982EF4C  token: 0x6000020
        public virtual System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        // RVA: 0x0982F54C  token: 0x6000021
        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982F3E0  token: 0x6000022
        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982EFAC  token: 0x6000023
        private System.Threading.Tasks.ValueTask<System.Int32> FinishReadAsyncMemory(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982FF84  token: 0x6000024
        public System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        // RVA: 0x0982FFA0  token: 0x6000025
        public System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, System.Boolean leaveOpen) { }
        // RVA: 0x0982FEC4  token: 0x6000026
        public virtual System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        // RVA: 0x0982FF60  token: 0x6000027
        public virtual System.Void Write(System.ReadOnlySpan<System.Byte> buffer) { }
        // RVA: 0x0982FC88  token: 0x6000028
        private System.Void WriteCore(System.ReadOnlySpan<System.Byte> buffer, System.Boolean isFinalBlock) { }
        // RVA: 0x0982EEC0  token: 0x6000029
        public virtual System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState) { }
        // RVA: 0x0982EF88  token: 0x600002A
        public virtual System.Void EndWrite(System.IAsyncResult asyncResult) { }
        // RVA: 0x0982FBA0  token: 0x600002B
        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982FA54  token: 0x600002C
        public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982F964  token: 0x600002D
        private System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982F23C  token: 0x600002E
        public virtual System.Void Flush() { }
        // RVA: 0x0982F184  token: 0x600002F
        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { }
        // RVA: 0x0982F0B0  token: 0x6000030
        private System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public static class BrotliUtils
    {
        // Methods
        // RVA: 0x09830140  token: 0x6000037
        private static System.Int32 GetQualityFromCompressionLevel(System.IO.Compression.CompressionLevel level) { }

    }

    // TypeToken: 0x200000A  // size: 0x20
    public sealed struct BrotliDecoder : System.IDisposable
    {
        // Fields
        private Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle _state;  // 0x10
        private System.Boolean _disposed;  // 0x18

        // Methods
        // RVA: 0x03790540  token: 0x6000038
        private System.Void InitializeDecoder() { }
        // RVA: 0x02462900  token: 0x6000039
        private System.Void EnsureInitialized() { }
        // RVA: 0x02959A20  token: 0x600003A
        public virtual System.Void Dispose() { }
        // RVA: 0x02462930  token: 0x600003B
        private System.Void EnsureNotDisposed() { }
        // RVA: 0x024625E0  token: 0x600003C
        public System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten) { }

    }

    // TypeToken: 0x200000B  // size: 0x20
    public sealed struct BrotliEncoder : System.IDisposable
    {
        // Fields
        private Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle _state;  // 0x10
        private System.Boolean _disposed;  // 0x18

        // Methods
        // RVA: 0x0982ED34  token: 0x600003D
        public System.Void .ctor(System.Int32 quality, System.Int32 window) { }
        // RVA: 0x0982E8F4  token: 0x600003E
        private System.Void InitializeEncoder() { }
        // RVA: 0x0982E744  token: 0x600003F
        private System.Void EnsureInitialized() { }
        // RVA: 0x03D47C60  token: 0x6000040
        public virtual System.Void Dispose() { }
        // RVA: 0x0982E770  token: 0x6000041
        private System.Void EnsureNotDisposed() { }
        // RVA: 0x0982E990  token: 0x6000042
        private System.Void SetQuality(System.Int32 quality) { }
        // RVA: 0x0982EB60  token: 0x6000043
        private System.Void SetWindow(System.Int32 window) { }
        // RVA: 0x0982E7F4  token: 0x6000044
        private System.Buffers.OperationStatus Flush(System.Memory<System.Byte> destination, System.Int32& bytesWritten) { }
        // RVA: 0x0982E86C  token: 0x6000045
        public System.Buffers.OperationStatus Flush(System.Span<System.Byte> destination, System.Int32& bytesWritten) { }
        // RVA: 0x0982E628  token: 0x6000046
        private System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<System.Byte> source, System.Memory<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock) { }
        // RVA: 0x0982E6F8  token: 0x6000047
        public System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock) { }
        // RVA: 0x0982E46C  token: 0x6000048
        private System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.IO.Compression.BrotliEncoderOperation operation) { }

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct BrotliEncoderOperation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.IO.Compression.BrotliEncoderOperation Process;  // const
        public static System.IO.Compression.BrotliEncoderOperation Flush;  // const
        public static System.IO.Compression.BrotliEncoderOperation Finish;  // const
        public static System.IO.Compression.BrotliEncoderOperation EmitMetadata;  // const

    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct BrotliEncoderParameter
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static System.IO.Compression.BrotliEncoderParameter Mode;  // const
        public static System.IO.Compression.BrotliEncoderParameter Quality;  // const
        public static System.IO.Compression.BrotliEncoderParameter LGWin;  // const
        public static System.IO.Compression.BrotliEncoderParameter LGBlock;  // const
        public static System.IO.Compression.BrotliEncoderParameter LCModeling;  // const
        public static System.IO.Compression.BrotliEncoderParameter SizeHint;  // const

    }

}

namespace System.Threading.Tasks
{

    // TypeToken: 0x200000E  // size: 0x10
    public static class TaskToApm
    {
        // Methods
        // RVA: 0x09830474  token: 0x6000049
        public static System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, System.Object state) { }
        // RVA: 0x09830570  token: 0x600004A
        public static System.Void End(System.IAsyncResult asyncResult) { }
        // RVA: -1  // generic def  token: 0x600004B
        public static TResult End(System.IAsyncResult asyncResult) { }
        // RVA: 0x0983062C  token: 0x600004C
        private static System.Void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult) { }

    }

}

