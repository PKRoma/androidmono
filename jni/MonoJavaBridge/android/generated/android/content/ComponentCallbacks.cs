namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.ComponentCallbacks_))]
	public interface ComponentCallbacks  : global::MonoJavaBridge.IJavaObject 
	{
		void onConfigurationChanged(android.content.res.Configuration arg0);
		void onLowMemory();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ComponentCallbacks))]
	public sealed partial class ComponentCallbacks_ : java.lang.Object, ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ComponentCallbacks_()
		{
			InitJNI();
		}
		internal ComponentCallbacks_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged1104;
		 void android.content.ComponentCallbacks.onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ComponentCallbacks_._onConfigurationChanged1104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ComponentCallbacks_.staticClass, global::android.content.ComponentCallbacks_._onConfigurationChanged1104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory1105;
		 void android.content.ComponentCallbacks.onLowMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ComponentCallbacks_._onLowMemory1105);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ComponentCallbacks_.staticClass, global::android.content.ComponentCallbacks_._onLowMemory1105);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ComponentCallbacks_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ComponentCallbacks"));
			global::android.content.ComponentCallbacks_._onConfigurationChanged1104 = @__env.GetMethodIDNoThrow(global::android.content.ComponentCallbacks_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.content.ComponentCallbacks_._onLowMemory1105 = @__env.GetMethodIDNoThrow(global::android.content.ComponentCallbacks_.staticClass, "onLowMemory", "()V");
		}
	}
}
