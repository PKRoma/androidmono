namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeadObjectException : android.os.RemoteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DeadObjectException()
		{
			InitJNI();
		}
		protected DeadObjectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DeadObjectException6291;
		public DeadObjectException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DeadObjectException.staticClass, global::android.os.DeadObjectException._DeadObjectException6291);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.DeadObjectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DeadObjectException"));
			global::android.os.DeadObjectException._DeadObjectException6291 = @__env.GetMethodIDNoThrow(global::android.os.DeadObjectException.staticClass, "<init>", "()V");
		}
	}
}
