namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathEffect : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PathEffect()
		{
			InitJNI();
		}
		protected PathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3591;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PathEffect._finalize3591);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PathEffect.staticClass, global::android.graphics.PathEffect._finalize3591);
		}
		internal static global::MonoJavaBridge.MethodId _PathEffect3592;
		public PathEffect()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathEffect.staticClass, global::android.graphics.PathEffect._PathEffect3592);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathEffect"));
			global::android.graphics.PathEffect._finalize3591 = @__env.GetMethodIDNoThrow(global::android.graphics.PathEffect.staticClass, "finalize", "()V");
			global::android.graphics.PathEffect._PathEffect3592 = @__env.GetMethodIDNoThrow(global::android.graphics.PathEffect.staticClass, "<init>", "()V");
		}
	}
}
