// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AndroidJNIModule.dll
// Classes:  15
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace UnityEngine
{

    // TypeToken: 0x2000002  // size: 0x80
    public sealed class AndroidJavaRunnable : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x6000001
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000002
        public virtual System.Void Invoke() { }

    }

    // TypeToken: 0x2000003  // size: 0x98
    public sealed class AndroidJavaException : System.Exception
    {
        // Fields
        private System.String mJavaStackTrace;  // 0x90

        // Properties
        System.String StackTrace { get; /* RVA: 0x09D83610 */ }

        // Methods
        // RVA: 0x09D835A0  token: 0x6000003
        private System.Void .ctor(System.String message, System.String javaStackTrace) { }

    }

    // TypeToken: 0x2000004  // size: 0x20
    public class GlobalJavaObjectRef
    {
        // Fields
        private System.Boolean m_disposed;  // 0x10
        protected System.IntPtr m_jobject;  // 0x18

        // Methods
        // RVA: 0x09D85A4C  token: 0x6000005
        public System.Void .ctor(System.IntPtr jobject) { }
        // RVA: 0x09D859DC  token: 0x6000006
        protected virtual System.Void Finalize() { }
        // RVA: 0x042C4004  token: 0x6000007
        public static System.IntPtr op_Implicit(UnityEngine.GlobalJavaObjectRef obj) { }
        // RVA: 0x09D859B4  token: 0x6000008
        public System.Void Dispose() { }

    }

    // TypeToken: 0x2000005  // size: 0x28
    public class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        // Fields
        private UnityEngine.AndroidJavaRunnable mRunnable;  // 0x20

        // Methods
        // RVA: 0x09D84BC4  token: 0x6000009
        public System.Void .ctor(UnityEngine.AndroidJavaRunnable runnable) { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class AndroidJavaProxy
    {
        // Fields
        public readonly UnityEngine.AndroidJavaClass javaInterface;  // 0x10
        private System.IntPtr proxyObject;  // 0x18
        private static readonly UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;  // static @ 0x0
        private static readonly System.IntPtr s_HashCodeMethodID;  // static @ 0x8

        // Methods
        // RVA: 0x09D849F4  token: 0x600000A
        public System.Void .ctor(System.String javaInterface) { }
        // RVA: 0x09D84A6C  token: 0x600000B
        public System.Void .ctor(UnityEngine.AndroidJavaClass javaInterface) { }
        // RVA: 0x09D83EE0  token: 0x600000C
        protected virtual System.Void Finalize() { }
        // RVA: 0x09D83FD0  token: 0x600000D
        public virtual UnityEngine.AndroidJavaObject Invoke(System.String methodName, System.Object[] args) { }
        // RVA: 0x09D847D0  token: 0x600000E
        public virtual UnityEngine.AndroidJavaObject Invoke(System.String methodName, UnityEngine.AndroidJavaObject[] javaArgs) { }
        // RVA: 0x09D84A84  token: 0x600000F
        public virtual System.Boolean equals(UnityEngine.AndroidJavaObject obj) { }
        // RVA: 0x09D84AB8  token: 0x6000010
        public virtual System.Int32 hashCode() { }
        // RVA: 0x09D84B68  token: 0x6000011
        public virtual System.String toString() { }
        // RVA: 0x09D83F54  token: 0x6000012
        private UnityEngine.AndroidJavaObject GetProxyObject() { }
        // RVA: 0x09D83F70  token: 0x6000013
        private System.IntPtr GetRawProxy() { }
        // RVA: 0x09D848E8  token: 0x6000014
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x20
    public class AndroidJavaObject : System.IDisposable
    {
        // Fields
        private static System.Boolean enableDebugPrints;  // static @ 0x0
        private UnityEngine.GlobalJavaObjectRef m_jobject;  // 0x10
        private UnityEngine.GlobalJavaObjectRef m_jclass;  // 0x18

        // Methods
        // RVA: 0x09D83ED8  token: 0x6000015
        public System.Void .ctor(System.String className, System.Object[] args) { }
        // RVA: 0x09D83A1C  token: 0x6000016
        public virtual System.Void Dispose() { }
        // RVA: -1  // generic def  token: 0x6000017
        public FieldType Get(System.String fieldName) { }
        // RVA: -1  // generic def  token: 0x6000018
        public FieldType GetStatic(System.String fieldName) { }
        // RVA: 0x09D83B3C  token: 0x6000019
        public System.IntPtr GetRawObject() { }
        // RVA: 0x09D83B30  token: 0x600001A
        public System.IntPtr GetRawClass() { }
        // RVA: -1  // generic def  token: 0x600001B
        public ReturnType Call(System.String methodName, System.Object[] args) { }
        // RVA: -1  // generic def  token: 0x600001C
        public ReturnType CallStatic(System.String methodName, System.Object[] args) { }
        // RVA: 0x09D839BC  token: 0x600001D
        protected System.Void DebugPrint(System.String msg) { }
        // RVA: 0x09D83B48  token: 0x600001E
        private System.Void _AndroidJavaObject(System.String className, System.Object[] args) { }
        // RVA: 0x09D83DB8  token: 0x600001F
        private System.Void .ctor(System.IntPtr jobject) { }
        // RVA: 0x0350B670  token: 0x6000020
        private System.Void .ctor() { }
        // RVA: 0x09D83ABC  token: 0x6000021
        protected virtual System.Void Finalize() { }
        // RVA: 0x09D83A6C  token: 0x6000022
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: -1  // generic def  token: 0x6000023
        protected ReturnType _Call(System.String methodName, System.Object[] args) { }
        // RVA: -1  // generic def  token: 0x6000024
        protected FieldType _Get(System.String fieldName) { }
        // RVA: -1  // generic def  token: 0x6000025
        protected ReturnType _CallStatic(System.String methodName, System.Object[] args) { }
        // RVA: -1  // generic def  token: 0x6000026
        protected FieldType _GetStatic(System.String fieldName) { }
        // RVA: 0x09D837FC  token: 0x6000027
        private static UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(System.IntPtr jobject) { }
        // RVA: 0x09D8363C  token: 0x6000028
        private static UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(System.IntPtr jclass) { }
        // RVA: -1  // generic def  token: 0x6000029
        private static ReturnType FromJavaArrayDeleteLocalRef(System.IntPtr jobject) { }
        // RVA: 0x09D83DA4  token: 0x600002A
        protected System.IntPtr _GetRawObject() { }
        // RVA: 0x06179578  token: 0x600002B
        protected System.IntPtr _GetRawClass() { }

    }

    // TypeToken: 0x2000008  // size: 0x20
    public class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        // Methods
        // RVA: 0x09D83598  token: 0x600002C
        public System.Void .ctor(System.String className) { }
        // RVA: 0x09D833E0  token: 0x600002D
        private System.Void _AndroidJavaClass(System.String className) { }
        // RVA: 0x09D834C0  token: 0x600002E
        private System.Void .ctor(System.IntPtr jclass) { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public class AndroidReflection
    {
        // Fields
        private static readonly UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass;  // static @ 0x0
        private static readonly System.IntPtr s_ReflectionHelperGetConstructorID;  // static @ 0x8
        private static readonly System.IntPtr s_ReflectionHelperGetMethodID;  // static @ 0x10
        private static readonly System.IntPtr s_ReflectionHelperGetFieldID;  // static @ 0x18
        private static readonly System.IntPtr s_ReflectionHelperGetFieldSignature;  // static @ 0x20
        private static readonly System.IntPtr s_ReflectionHelperNewProxyInstance;  // static @ 0x28
        private static readonly System.IntPtr s_ReflectionHelperSetNativeExceptionOnProxy;  // static @ 0x30
        private static readonly System.IntPtr s_FieldGetDeclaringClass;  // static @ 0x38

        // Methods
        // RVA: 0x094C874C  token: 0x600002F
        public static System.Boolean IsPrimitive(System.Type t) { }
        // RVA: 0x09697CCC  token: 0x6000030
        public static System.Boolean IsAssignableFrom(System.Type t, System.Type from) { }
        // RVA: 0x09D852F0  token: 0x6000031
        private static System.IntPtr GetStaticMethodID(System.String clazz, System.String methodName, System.String signature) { }
        // RVA: 0x09D85070  token: 0x6000032
        private static System.IntPtr GetMethodID(System.String clazz, System.String methodName, System.String signature) { }
        // RVA: 0x09D84C34  token: 0x6000033
        public static System.IntPtr GetConstructorMember(System.IntPtr jclass, System.String signature) { }
        // RVA: 0x09D8511C  token: 0x6000034
        public static System.IntPtr GetMethodMember(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D84DF4  token: 0x6000035
        public static System.IntPtr GetFieldMember(System.IntPtr jclass, System.String fieldName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D84D9C  token: 0x6000036
        public static System.IntPtr GetFieldClass(System.IntPtr field) { }
        // RVA: 0x09D84FC8  token: 0x6000037
        public static System.String GetFieldSignature(System.IntPtr field) { }
        // RVA: 0x09D8539C  token: 0x6000038
        public static System.IntPtr NewProxyInstance(System.IntPtr player, System.IntPtr delegateHandle, System.IntPtr interfaze) { }
        // RVA: 0x09D85478  token: 0x6000039
        public static System.Void SetNativeExceptionOnProxy(System.IntPtr proxy, System.Exception e, System.Boolean methodNotFound) { }
        // RVA: 0x09D85564  token: 0x600003A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x10
    public sealed class _AndroidJNIHelper
    {
        // Methods
        // RVA: 0x09D87020  token: 0x600003B
        public static System.IntPtr CreateJavaProxy(System.IntPtr player, System.IntPtr delegateHandle, UnityEngine.AndroidJavaProxy proxy) { }
        // RVA: 0x09D870A0  token: 0x600003C
        public static System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable) { }
        // RVA: 0x09D887A8  token: 0x600003D
        public static System.IntPtr InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, System.IntPtr jmethodName, System.IntPtr jargs) { }
        // RVA: 0x09D86A8C  token: 0x600003E
        public static UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args) { }
        // RVA: 0x09D88A44  token: 0x600003F
        public static System.Object UnboxArray(UnityEngine.AndroidJavaObject obj) { }
        // RVA: 0x09D8902C  token: 0x6000040
        public static System.Object Unbox(UnityEngine.AndroidJavaObject obj) { }
        // RVA: 0x09D85A78  token: 0x6000041
        public static UnityEngine.AndroidJavaObject Box(System.Object obj) { }
        // RVA: 0x09D87108  token: 0x6000042
        public static System.Void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs) { }
        // RVA: 0x09D863BC  token: 0x6000043
        public static System.IntPtr ConvertToJNIArray(System.Array array) { }
        // RVA: -1  // generic def  token: 0x6000044
        public static ArrayType ConvertFromJNIArray(System.IntPtr array) { }
        // RVA: 0x09D873A8  token: 0x6000045
        public static System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args) { }
        // RVA: -1  // generic def  token: 0x6000046
        public static System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.Object[] args, System.Boolean isStatic) { }
        // RVA: -1  // generic def  token: 0x6000047
        public static System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.Boolean isStatic) { }
        // RVA: 0x09D871FC  token: 0x6000048
        public static System.IntPtr GetConstructorID(System.IntPtr jclass, System.String signature) { }
        // RVA: 0x09D877BC  token: 0x6000049
        public static System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D87734  token: 0x600004A
        private static System.IntPtr GetMethodIDFallback(System.IntPtr jclass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D873D4  token: 0x600004B
        public static System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D87A4C  token: 0x600004C
        public static System.String GetSignature(System.Object obj) { }
        // RVA: 0x09D8797C  token: 0x600004D
        public static System.String GetSignature(System.Object[] args) { }
        // RVA: -1  // generic def  token: 0x600004E
        public static System.String GetSignature(System.Object[] args) { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public sealed struct jvalue
    {
        // Fields
        public System.Boolean z;  // 0x10
        public System.SByte b;  // 0x10
        public System.Char c;  // 0x10
        public System.Int16 s;  // 0x10
        public System.Int32 i;  // 0x10
        public System.Int64 j;  // 0x10
        public System.Single f;  // 0x10
        public System.Double d;  // 0x10
        public System.IntPtr l;  // 0x10

    }

    // TypeToken: 0x200000C  // size: 0x10
    public static class AndroidJNIHelper
    {
        // Methods
        // RVA: 0x09D7F4C0  token: 0x600004F
        public static System.IntPtr GetConstructorID(System.IntPtr javaClass, System.String signature) { }
        // RVA: 0x09D7F4DC  token: 0x6000050
        public static System.IntPtr GetMethodID(System.IntPtr javaClass, System.String methodName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D7F4CC  token: 0x6000051
        public static System.IntPtr GetFieldID(System.IntPtr javaClass, System.String fieldName, System.String signature, System.Boolean isStatic) { }
        // RVA: 0x09D7F4A0  token: 0x6000052
        public static System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable) { }
        // RVA: 0x09D7F38C  token: 0x6000053
        public static System.IntPtr CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy) { }
        // RVA: 0x09D7F380  token: 0x6000054
        public static UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args) { }
        // RVA: 0x09D7F4AC  token: 0x6000055
        public static System.Void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs) { }
        // RVA: 0x09D7F4B4  token: 0x6000056
        public static System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args) { }
        // RVA: -1  // generic def  token: 0x6000057
        public static ArrayType ConvertFromJNIArray(System.IntPtr array) { }
        // RVA: -1  // generic def  token: 0x6000058
        public static System.IntPtr GetMethodID(System.IntPtr jclass, System.String methodName, System.Object[] args, System.Boolean isStatic) { }
        // RVA: -1  // generic def  token: 0x6000059
        public static System.IntPtr GetFieldID(System.IntPtr jclass, System.String fieldName, System.Boolean isStatic) { }

    }

    // TypeToken: 0x200000D  // size: 0x10
    public static class AndroidJNI
    {
        // Methods
        // RVA: 0x09D82594  token: 0x600005A
        public static System.IntPtr FindClass(System.String name) { }
        // RVA: 0x09D82734  token: 0x600005B
        public static System.IntPtr FromReflectedMethod(System.IntPtr refMethod) { }
        // RVA: 0x09D82568  token: 0x600005C
        public static System.IntPtr ExceptionOccurred() { }
        // RVA: 0x09D8253C  token: 0x600005D
        public static System.Void ExceptionClear() { }
        // RVA: 0x09D83144  token: 0x600005E
        public static System.Int32 PushLocalFrame(System.Int32 capacity) { }
        // RVA: 0x09D83110  token: 0x600005F
        public static System.IntPtr PopLocalFrame(System.IntPtr ptr) { }
        // RVA: 0x09D82F90  token: 0x6000060
        public static System.IntPtr NewGlobalRef(System.IntPtr obj) { }
        // RVA: 0x09D824A0  token: 0x6000061
        public static System.Void DeleteGlobalRef(System.IntPtr obj) { }
        // RVA: 0x09D830DC  token: 0x6000062
        public static System.IntPtr NewWeakGlobalRef(System.IntPtr obj) { }
        // RVA: 0x09D82508  token: 0x6000063
        public static System.Void DeleteWeakGlobalRef(System.IntPtr obj) { }
        // RVA: 0x09D82FC4  token: 0x6000064
        public static System.IntPtr NewLocalRef(System.IntPtr obj) { }
        // RVA: 0x09D824D4  token: 0x6000065
        public static System.Void DeleteLocalRef(System.IntPtr obj) { }
        // RVA: 0x09D82F4C  token: 0x6000066
        public static System.Boolean IsSameObject(System.IntPtr obj1, System.IntPtr obj2) { }
        // RVA: 0x09D83048  token: 0x6000067
        public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82A84  token: 0x6000068
        public static System.IntPtr GetObjectClass(System.IntPtr obj) { }
        // RVA: 0x09D829F0  token: 0x6000069
        public static System.IntPtr GetMethodID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D828D0  token: 0x600006A
        public static System.IntPtr GetFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D82D70  token: 0x600006B
        public static System.IntPtr GetStaticMethodID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D82C50  token: 0x600006C
        public static System.IntPtr GetStaticFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D830D0  token: 0x600006D
        public static System.IntPtr NewString(System.String chars) { }
        // RVA: 0x09D8309C  token: 0x600006E
        private static System.IntPtr NewStringFromStr(System.String chars) { }
        // RVA: 0x09D82ED4  token: 0x600006F
        public static System.String GetStringChars(System.IntPtr str) { }
        // RVA: 0x09D8244C  token: 0x6000070
        public static System.String CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81FB4  token: 0x6000071
        public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81F0C  token: 0x6000072
        public static System.Int32 CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81DBC  token: 0x6000073
        public static System.Boolean CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D8205C  token: 0x6000074
        public static System.Int16 CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82008  token: 0x6000075
        public static System.SByte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81E10  token: 0x6000076
        public static System.Char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81EB8  token: 0x6000077
        public static System.Single CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81E64  token: 0x6000078
        public static System.Double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81F60  token: 0x6000079
        public static System.Int64 CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82F08  token: 0x600007A
        public static System.String GetStringField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82AB8  token: 0x600007B
        public static System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82804  token: 0x600007C
        public static System.Boolean GetBooleanField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82AFC  token: 0x600007D
        public static System.SByte GetSByteField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82848  token: 0x600007E
        public static System.Char GetCharField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82B40  token: 0x600007F
        public static System.Int16 GetShortField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82968  token: 0x6000080
        public static System.Int32 GetIntField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D829AC  token: 0x6000081
        public static System.Int64 GetLongField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D82924  token: 0x6000082
        public static System.Single GetFloatField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D8288C  token: 0x6000083
        public static System.Double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D823A4  token: 0x6000084
        public static System.String CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D822A8  token: 0x6000085
        public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82200  token: 0x6000086
        public static System.Int32 CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D820B0  token: 0x6000087
        public static System.Boolean CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82350  token: 0x6000088
        public static System.Int16 CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D822FC  token: 0x6000089
        public static System.SByte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82104  token: 0x600008A
        public static System.Char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D821AC  token: 0x600008B
        public static System.Single CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82158  token: 0x600008C
        public static System.Double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82254  token: 0x600008D
        public static System.Int64 CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D823F8  token: 0x600008E
        public static System.Void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D82E90  token: 0x600008F
        public static System.String GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82DC4  token: 0x6000090
        public static System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82B84  token: 0x6000091
        public static System.Boolean GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82E08  token: 0x6000092
        public static System.SByte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82BC8  token: 0x6000093
        public static System.Char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82E4C  token: 0x6000094
        public static System.Int16 GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82CE8  token: 0x6000095
        public static System.Int32 GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82D2C  token: 0x6000096
        public static System.Int64 GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82CA4  token: 0x6000097
        public static System.Single GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D82C0C  token: 0x6000098
        public static System.Double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D831C8  token: 0x6000099
        public static System.IntPtr ToBooleanArray(System.Boolean[] array) { }
        // RVA: 0x09D831FC  token: 0x600009A
        public static System.IntPtr ToByteArray(System.Byte[] array) { }
        // RVA: 0x09D83378  token: 0x600009B
        public static System.IntPtr ToSByteArray(System.SByte[] array) { }
        // RVA: 0x09D83230  token: 0x600009C
        public static System.IntPtr ToCharArray(System.Char[] array) { }
        // RVA: 0x09D833AC  token: 0x600009D
        public static System.IntPtr ToShortArray(System.Int16[] array) { }
        // RVA: 0x09D832CC  token: 0x600009E
        public static System.IntPtr ToIntArray(System.Int32[] array) { }
        // RVA: 0x09D83300  token: 0x600009F
        public static System.IntPtr ToLongArray(System.Int64[] array) { }
        // RVA: 0x09D83298  token: 0x60000A0
        public static System.IntPtr ToFloatArray(System.Single[] array) { }
        // RVA: 0x09D83264  token: 0x60000A1
        public static System.IntPtr ToDoubleArray(System.Double[] array) { }
        // RVA: 0x09D83334  token: 0x60000A2
        public static System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr arrayClass) { }
        // RVA: 0x09D825C8  token: 0x60000A3
        public static System.Boolean[] FromBooleanArray(System.IntPtr array) { }
        // RVA: 0x09D825FC  token: 0x60000A4
        public static System.Byte[] FromByteArray(System.IntPtr array) { }
        // RVA: 0x09D82768  token: 0x60000A5
        public static System.SByte[] FromSByteArray(System.IntPtr array) { }
        // RVA: 0x09D82630  token: 0x60000A6
        public static System.Char[] FromCharArray(System.IntPtr array) { }
        // RVA: 0x09D8279C  token: 0x60000A7
        public static System.Int16[] FromShortArray(System.IntPtr array) { }
        // RVA: 0x09D826CC  token: 0x60000A8
        public static System.Int32[] FromIntArray(System.IntPtr array) { }
        // RVA: 0x09D82700  token: 0x60000A9
        public static System.Int64[] FromLongArray(System.IntPtr array) { }
        // RVA: 0x09D82698  token: 0x60000AA
        public static System.Single[] FromFloatArray(System.IntPtr array) { }
        // RVA: 0x09D82664  token: 0x60000AB
        public static System.Double[] FromDoubleArray(System.IntPtr array) { }
        // RVA: 0x09D827D0  token: 0x60000AC
        public static System.Int32 GetArrayLength(System.IntPtr array) { }
        // RVA: 0x09D82FF8  token: 0x60000AD
        public static System.IntPtr NewObjectArray(System.Int32 size, System.IntPtr clazz, System.IntPtr obj) { }
        // RVA: 0x09D82A44  token: 0x60000AE
        public static System.IntPtr GetObjectArrayElement(System.IntPtr array, System.Int32 index) { }
        // RVA: 0x09D83178  token: 0x60000AF
        public static System.Void SetObjectArrayElement(System.IntPtr array, System.Int32 index, System.IntPtr obj) { }

    }

    // TypeToken: 0x200000E  // size: 0x10
    public class AndroidJNISafe
    {
        // Methods
        // RVA: 0x09D7FFF4  token: 0x60000B0
        public static System.Void CheckException() { }
        // RVA: 0x09D802E0  token: 0x60000B1
        public static System.Void DeleteGlobalRef(System.IntPtr globalref) { }
        // RVA: 0x09D80300  token: 0x60000B2
        public static System.Void DeleteWeakGlobalRef(System.IntPtr globalref) { }
        // RVA: 0x09D802F0  token: 0x60000B3
        public static System.Void DeleteLocalRef(System.IntPtr localref) { }
        // RVA: 0x09D8180C  token: 0x60000B4
        public static System.IntPtr NewString(System.String chars) { }
        // RVA: 0x09D81678  token: 0x60000B5
        public static System.String GetStringChars(System.IntPtr str) { }
        // RVA: 0x09D80E08  token: 0x60000B6
        public static System.IntPtr GetObjectClass(System.IntPtr ptr) { }
        // RVA: 0x09D813D8  token: 0x60000B7
        public static System.IntPtr GetStaticMethodID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D80CF8  token: 0x60000B8
        public static System.IntPtr GetMethodID(System.IntPtr obj, System.String name, System.String sig) { }
        // RVA: 0x09D80AD8  token: 0x60000B9
        public static System.IntPtr GetFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D811B8  token: 0x60000BA
        public static System.IntPtr GetStaticFieldID(System.IntPtr clazz, System.String name, System.String sig) { }
        // RVA: 0x09D80730  token: 0x60000BB
        public static System.IntPtr FromReflectedMethod(System.IntPtr refMethod) { }
        // RVA: 0x09D80310  token: 0x60000BC
        public static System.IntPtr FindClass(System.String name) { }
        // RVA: 0x09D81784  token: 0x60000BD
        public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D81460  token: 0x60000BE
        public static System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D815F0  token: 0x60000BF
        public static System.String GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D8109C  token: 0x60000C0
        public static System.Char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D81124  token: 0x60000C1
        public static System.Double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D81240  token: 0x60000C2
        public static System.Single GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D81350  token: 0x60000C3
        public static System.Int64 GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D81568  token: 0x60000C4
        public static System.Int16 GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D814E8  token: 0x60000C5
        public static System.SByte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D8101C  token: 0x60000C6
        public static System.Boolean GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D812D0  token: 0x60000C7
        public static System.Int32 GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID) { }
        // RVA: 0x09D7FEFC  token: 0x60000C8
        public static System.Void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FCE4  token: 0x60000C9
        public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FE74  token: 0x60000CA
        public static System.String CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FA30  token: 0x60000CB
        public static System.Char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FAB8  token: 0x60000CC
        public static System.Double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FB4C  token: 0x60000CD
        public static System.Single CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FC5C  token: 0x60000CE
        public static System.Int64 CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FDEC  token: 0x60000CF
        public static System.Int16 CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FD6C  token: 0x60000D0
        public static System.SByte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F9B0  token: 0x60000D1
        public static System.Boolean CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FBDC  token: 0x60000D2
        public static System.Int32 CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D80E8C  token: 0x60000D3
        public static System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D816FC  token: 0x60000D4
        public static System.String GetStringField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D809BC  token: 0x60000D5
        public static System.Char GetCharField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D80A44  token: 0x60000D6
        public static System.Double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D80B60  token: 0x60000D7
        public static System.Single GetFloatField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D80C70  token: 0x60000D8
        public static System.Int64 GetLongField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D80F94  token: 0x60000D9
        public static System.Int16 GetShortField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D80F14  token: 0x60000DA
        public static System.SByte GetSByteField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D8093C  token: 0x60000DB
        public static System.Boolean GetBooleanField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D80BF0  token: 0x60000DC
        public static System.Int32 GetIntField(System.IntPtr obj, System.IntPtr fieldID) { }
        // RVA: 0x09D7F820  token: 0x60000DD
        public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7FF6C  token: 0x60000DE
        public static System.String CallStringMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F56C  token: 0x60000DF
        public static System.Char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F5F4  token: 0x60000E0
        public static System.Double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F688  token: 0x60000E1
        public static System.Single CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F798  token: 0x60000E2
        public static System.Int64 CallLongMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F928  token: 0x60000E3
        public static System.Int16 CallShortMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F8A8  token: 0x60000E4
        public static System.SByte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F4EC  token: 0x60000E5
        public static System.Boolean CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D7F718  token: 0x60000E6
        public static System.Int32 CallIntMethod(System.IntPtr obj, System.IntPtr methodID, UnityEngine.jvalue[] args) { }
        // RVA: 0x09D8049C  token: 0x60000E7
        public static System.Char[] FromCharArray(System.IntPtr array) { }
        // RVA: 0x09D80520  token: 0x60000E8
        public static System.Double[] FromDoubleArray(System.IntPtr array) { }
        // RVA: 0x09D805A4  token: 0x60000E9
        public static System.Single[] FromFloatArray(System.IntPtr array) { }
        // RVA: 0x09D806AC  token: 0x60000EA
        public static System.Int64[] FromLongArray(System.IntPtr array) { }
        // RVA: 0x09D80838  token: 0x60000EB
        public static System.Int16[] FromShortArray(System.IntPtr array) { }
        // RVA: 0x09D80418  token: 0x60000EC
        public static System.Byte[] FromByteArray(System.IntPtr array) { }
        // RVA: 0x09D807B4  token: 0x60000ED
        public static System.SByte[] FromSByteArray(System.IntPtr array) { }
        // RVA: 0x09D80394  token: 0x60000EE
        public static System.Boolean[] FromBooleanArray(System.IntPtr array) { }
        // RVA: 0x09D80628  token: 0x60000EF
        public static System.Int32[] FromIntArray(System.IntPtr array) { }
        // RVA: 0x09D81C2C  token: 0x60000F0
        public static System.IntPtr ToObjectArray(System.IntPtr[] array, System.IntPtr type) { }
        // RVA: 0x09D81998  token: 0x60000F1
        public static System.IntPtr ToCharArray(System.Char[] array) { }
        // RVA: 0x09D81A1C  token: 0x60000F2
        public static System.IntPtr ToDoubleArray(System.Double[] array) { }
        // RVA: 0x09D81AA0  token: 0x60000F3
        public static System.IntPtr ToFloatArray(System.Single[] array) { }
        // RVA: 0x09D81BA8  token: 0x60000F4
        public static System.IntPtr ToLongArray(System.Int64[] array) { }
        // RVA: 0x09D81D38  token: 0x60000F5
        public static System.IntPtr ToShortArray(System.Int16[] array) { }
        // RVA: 0x09D81914  token: 0x60000F6
        public static System.IntPtr ToByteArray(System.Byte[] array) { }
        // RVA: 0x09D81CB4  token: 0x60000F7
        public static System.IntPtr ToSByteArray(System.SByte[] array) { }
        // RVA: 0x09D81890  token: 0x60000F8
        public static System.IntPtr ToBooleanArray(System.Boolean[] array) { }
        // RVA: 0x09D81B24  token: 0x60000F9
        public static System.IntPtr ToIntArray(System.Int32[] array) { }
        // RVA: 0x09D80D80  token: 0x60000FA
        public static System.IntPtr GetObjectArrayElement(System.IntPtr array, System.Int32 index) { }
        // RVA: 0x09D808BC  token: 0x60000FB
        public static System.Int32 GetArrayLength(System.IntPtr array) { }

    }

}

namespace UnityEngine.Android
{

    // TypeToken: 0x200000F  // size: 0x10
    public static class Common
    {
        // Fields
        private static UnityEngine.AndroidJavaObject m_Activity;  // static @ 0x0

        // Methods
        // RVA: 0x09D8580C  token: 0x60000FC
        public static UnityEngine.AndroidJavaObject GetActivity() { }

    }

}

