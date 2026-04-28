// ========================================================
// Dumped by @desirepro
// Assembly: System.IO.Compression.dll
// Classes:  18
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

CLASS: Brotli
TYPE:  static class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03790590  token=0x6000001  Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque)
  RVA=0x02462950  token=0x6000002  System.Int32 BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut)
  RVA=0x042771B4  token=0x6000003  System.Void BrotliDecoderDestroyInstance(System.IntPtr state)
  RVA=0x02462580  token=0x6000004  System.Boolean BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state)
  RVA=0x09830214  token=0x6000005  Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(System.IntPtr allocFunc, System.IntPtr freeFunc, System.IntPtr opaque)
  RVA=0x09830304  token=0x6000006  System.Boolean BrotliEncoderSetParameter(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderParameter parameter, System.UInt32 value)
  RVA=0x09830164  token=0x6000007  System.Boolean BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, System.IntPtr& availableIn, System.Byte** nextIn, System.IntPtr& availableOut, System.Byte** nextOut, System.IntPtr& totalOut)
  RVA=0x09830294  token=0x6000008  System.Boolean BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state)
  RVA=0x0983028C  token=0x6000009  System.Void BrotliEncoderDestroyInstance(System.IntPtr state)
END_CLASS

CLASS: Interop
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: SR
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09830404  token=0x600000A  System.String Format(System.String resourceFormat, System.Object p1)
  RVA=0x09830384  token=0x600000B  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3)
END_CLASS

CLASS: <FinishReadAsyncMemory>d__41
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x70
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<System.Int32><>t__builder  // 0x18
  public            System.IO.Compression.BrotliStream<>4__this  // 0x38
  public            System.Threading.CancellationTokencancellationToken  // 0x40
  public            System.Memory<System.Byte>      buffer  // 0x48
  private           System.Int32                    <totalWritten>5__2  // 0x58
  private           System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.Int32><>u__1  // 0x60
METHODS:
  RVA=0x09830724  token=0x6000031  System.Void MoveNext()
  RVA=0x0983101C  token=0x6000032  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <WriteAsyncMemoryCore>d__52
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x68
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            System.IO.Compression.BrotliStream<>4__this  // 0x30
  public            System.ReadOnlyMemory<System.Byte>buffer  // 0x38
  public            System.Threading.CancellationTokencancellationToken  // 0x48
  private           System.Buffers.OperationStatus  <lastResult>5__2  // 0x50
  private           System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<>u__1  // 0x58
METHODS:
  RVA=0x098315E0  token=0x6000033  System.Void MoveNext()
  RVA=0x09831B88  token=0x6000034  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: <FlushAsyncCore>d__55
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x58
IMPLEMENTS: System.Runtime.CompilerServices.IAsyncStateMachine
FIELDS:
  public            System.Int32                    <>1__state  // 0x10
  public            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>t__builder  // 0x18
  public            System.IO.Compression.BrotliStream<>4__this  // 0x30
  public            System.Threading.CancellationTokencancellationToken  // 0x38
  private           System.Buffers.OperationStatus  <lastResult>5__2  // 0x40
  private           System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<>u__1  // 0x48
METHODS:
  RVA=0x09831068  token=0x6000035  System.Void MoveNext()
  RVA=0x09831584  token=0x6000036  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
END_CLASS

CLASS: TaskWrapperAsyncResult
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x28
IMPLEMENTS: System.IAsyncResult
FIELDS:
  private   readonly System.Threading.Tasks.Task     Task  // 0x10
  private   readonly System.Object                   _state  // 0x18
  private   readonly System.Boolean                  _completedSynchronously  // 0x20
PROPERTIES:
  System.IAsyncResult.AsyncState  get=0x01041090
  System.IAsyncResult.CompletedSynchronously  get=0x03D4EF90
  System.IAsyncResult.IsCompleted  get=0x092945A0
  System.IAsyncResult.AsyncWaitHandle  get=0x09294580
METHODS:
  RVA=0x03D01130  token=0x600004D  System.Void .ctor(System.Threading.Tasks.Task task, System.Object state, System.Boolean completedSynchronously)
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x2000010
SIZE:  0x20
FIELDS:
  public            System.AsyncCallback            callback  // 0x10
  public            System.IAsyncResult             asyncResult  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000052  System.Void .ctor()
  RVA=0x09298BD8  token=0x6000053  System.Void <InvokeCallbackWhenTaskCompletes>b__0()
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x20
EXTENDS: System.Runtime.InteropServices.SafeHandle
FIELDS:
PROPERTIES:
  IsInvalid  get=0x025EB8A0
METHODS:
  RVA=0x04272874  token=0x6000054  System.Void .ctor()
  RVA=0x09830460  token=0x6000055  System.Boolean ReleaseHandle()
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x20
EXTENDS: System.Runtime.InteropServices.SafeHandle
FIELDS:
PROPERTIES:
  IsInvalid  get=0x025EB8A0
METHODS:
  RVA=0x04272874  token=0x6000057  System.Void .ctor()
  RVA=0x03D450D0  token=0x6000058  System.Boolean ReleaseHandle()
END_CLASS

CLASS: System.IO.Compression.BrotliStream
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x70
EXTENDS: System.IO.Stream
FIELDS:
  private           System.IO.Stream                _stream  // 0x28
  private   readonly System.Byte[]                   _buffer  // 0x30
  private   readonly System.Boolean                  _leaveOpen  // 0x38
  private   readonly System.IO.Compression.CompressionMode_mode  // 0x3c
  private           System.Int32                    _activeAsyncOperation  // 0x40
  private           System.IO.Compression.BrotliDecoder_decoder  // 0x48
  private           System.Int32                    _bufferOffset  // 0x58
  private           System.Int32                    _bufferCount  // 0x5c
  private           System.IO.Compression.BrotliEncoder_encoder  // 0x60
PROPERTIES:
  CanRead  get=0x09830004
  CanWrite  get=0x09830030
  CanSeek  get=0x0115F4C0
  Length  get=0x0983005C
  Position  get=0x098300A8  set=0x098300F4
  AsyncOperationIsActive  get=0x0982FFFC
METHODS:
  RVA=0x03A61760  token=0x600000C  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, System.Boolean leaveOpen)
  RVA=0x03334260  token=0x600000D  System.Void EnsureNotDisposed()
  RVA=0x03B216E0  token=0x600000E  System.Void Dispose(System.Boolean disposing)
  RVA=0x0982F7C0  token=0x600000F  System.Void ValidateParameters(System.Byte[] array, System.Int32 offset, System.Int32 count)
  RVA=0x0982F6CC  token=0x6000013  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  RVA=0x0982F718  token=0x6000017  System.Void SetLength(System.Int64 value)
  RVA=0x0982EF94  token=0x6000019  System.Void EnsureNoActiveAsyncOperation()
  RVA=0x0982EE10  token=0x600001A  System.Void AsyncOperationStarting()
  RVA=0x0982EE00  token=0x600001B  System.Void AsyncOperationCompleting()
  RVA=0x0982F764  token=0x600001C  System.Void ThrowInvalidBeginCall()
  RVA=0x0982F62C  token=0x600001D  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  RVA=0x025D9CD0  token=0x600001E  System.Int32 Read(System.Span<System.Byte> buffer)
  RVA=0x0982EE30  token=0x600001F  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  RVA=0x0982EF4C  token=0x6000020  System.Int32 EndRead(System.IAsyncResult asyncResult)
  RVA=0x0982F54C  token=0x6000021  System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  RVA=0x0982F3E0  token=0x6000022  System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  RVA=0x0982EFAC  token=0x6000023  System.Threading.Tasks.ValueTask<System.Int32> FinishReadAsyncMemory(System.Memory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  RVA=0x0982FF84  token=0x6000024  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel)
  RVA=0x0982FFA0  token=0x6000025  System.Void .ctor(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, System.Boolean leaveOpen)
  RVA=0x0982FEC4  token=0x6000026  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  RVA=0x0982FF60  token=0x6000027  System.Void Write(System.ReadOnlySpan<System.Byte> buffer)
  RVA=0x0982FC88  token=0x6000028  System.Void WriteCore(System.ReadOnlySpan<System.Byte> buffer, System.Boolean isFinalBlock)
  RVA=0x0982EEC0  token=0x6000029  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback asyncCallback, System.Object asyncState)
  RVA=0x0982EF88  token=0x600002A  System.Void EndWrite(System.IAsyncResult asyncResult)
  RVA=0x0982FBA0  token=0x600002B  System.Threading.Tasks.Task WriteAsync(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.Threading.CancellationToken cancellationToken)
  RVA=0x0982FA54  token=0x600002C  System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  RVA=0x0982F964  token=0x600002D  System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<System.Byte> buffer, System.Threading.CancellationToken cancellationToken)
  RVA=0x0982F23C  token=0x600002E  System.Void Flush()
  RVA=0x0982F184  token=0x600002F  System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
  RVA=0x0982F0B0  token=0x6000030  System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.IO.Compression.BrotliUtils
TYPE:  static class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09830140  token=0x6000037  System.Int32 GetQualityFromCompressionLevel(System.IO.Compression.CompressionLevel level)
END_CLASS

CLASS: System.IO.Compression.BrotliDecoder
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle_state  // 0x10
  private           System.Boolean                  _disposed  // 0x18
METHODS:
  RVA=0x03790540  token=0x6000038  System.Void InitializeDecoder()
  RVA=0x02462900  token=0x6000039  System.Void EnsureInitialized()
  RVA=0x02959A20  token=0x600003A  System.Void Dispose()
  RVA=0x02462930  token=0x600003B  System.Void EnsureNotDisposed()
  RVA=0x024625E0  token=0x600003C  System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten)
END_CLASS

CLASS: System.IO.Compression.BrotliEncoder
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x20
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle_state  // 0x10
  private           System.Boolean                  _disposed  // 0x18
METHODS:
  RVA=0x0982ED34  token=0x600003D  System.Void .ctor(System.Int32 quality, System.Int32 window)
  RVA=0x0982E8F4  token=0x600003E  System.Void InitializeEncoder()
  RVA=0x0982E744  token=0x600003F  System.Void EnsureInitialized()
  RVA=0x03D47C60  token=0x6000040  System.Void Dispose()
  RVA=0x0982E770  token=0x6000041  System.Void EnsureNotDisposed()
  RVA=0x0982E990  token=0x6000042  System.Void SetQuality(System.Int32 quality)
  RVA=0x0982EB60  token=0x6000043  System.Void SetWindow(System.Int32 window)
  RVA=0x0982E7F4  token=0x6000044  System.Buffers.OperationStatus Flush(System.Memory<System.Byte> destination, System.Int32& bytesWritten)
  RVA=0x0982E86C  token=0x6000045  System.Buffers.OperationStatus Flush(System.Span<System.Byte> destination, System.Int32& bytesWritten)
  RVA=0x0982E628  token=0x6000046  System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<System.Byte> source, System.Memory<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock)
  RVA=0x0982E6F8  token=0x6000047  System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.Boolean isFinalBlock)
  RVA=0x0982E46C  token=0x6000048  System.Buffers.OperationStatus Compress(System.ReadOnlySpan<System.Byte> source, System.Span<System.Byte> destination, System.Int32& bytesConsumed, System.Int32& bytesWritten, System.IO.Compression.BrotliEncoderOperation operation)
END_CLASS

CLASS: System.IO.Compression.BrotliEncoderOperation
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.Compression.BrotliEncoderOperationProcess  // const
  public    static  System.IO.Compression.BrotliEncoderOperationFlush  // const
  public    static  System.IO.Compression.BrotliEncoderOperationFinish  // const
  public    static  System.IO.Compression.BrotliEncoderOperationEmitMetadata  // const
METHODS:
END_CLASS

CLASS: System.IO.Compression.BrotliEncoderParameter
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.Compression.BrotliEncoderParameterMode  // const
  public    static  System.IO.Compression.BrotliEncoderParameterQuality  // const
  public    static  System.IO.Compression.BrotliEncoderParameterLGWin  // const
  public    static  System.IO.Compression.BrotliEncoderParameterLGBlock  // const
  public    static  System.IO.Compression.BrotliEncoderParameterLCModeling  // const
  public    static  System.IO.Compression.BrotliEncoderParameterSizeHint  // const
METHODS:
END_CLASS

CLASS: System.Threading.Tasks.TaskToApm
TYPE:  static class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09830474  token=0x6000049  System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, System.Object state)
  RVA=0x09830570  token=0x600004A  System.Void End(System.IAsyncResult asyncResult)
  RVA=-1  // generic def  token=0x600004B  TResult End(System.IAsyncResult asyncResult)
  RVA=0x0983062C  token=0x600004C  System.Void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult)
END_CLASS

