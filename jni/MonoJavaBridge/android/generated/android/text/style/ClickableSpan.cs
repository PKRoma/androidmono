namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.ClickableSpan_))]
	public abstract partial class ClickableSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClickableSpan()
		{
			InitJNI();
		}
		protected ClickableSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick8238;
		public abstract void onClick(android.view.View arg0);
		internal static global::MonoJavaBridge.MethodId _updateDrawState8239;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ClickableSpan._updateDrawState8239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ClickableSpan.staticClass, global::android.text.style.ClickableSpan._updateDrawState8239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ClickableSpan8240;
		public ClickableSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ClickableSpan.staticClass, global::android.text.style.ClickableSpan._ClickableSpan8240);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ClickableSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ClickableSpan"));
			global::android.text.style.ClickableSpan._onClick8238 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.text.style.ClickableSpan._updateDrawState8239 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ClickableSpan._ClickableSpan8240 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.ClickableSpan))]
	public sealed partial class ClickableSpan_ : android.text.style.ClickableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClickableSpan_()
		{
			InitJNI();
		}
		internal ClickableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick8241;
		public override void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ClickableSpan_._onClick8241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ClickableSpan_.staticClass, global::android.text.style.ClickableSpan_._onClick8241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ClickableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ClickableSpan"));
			global::android.text.style.ClickableSpan_._onClick8241 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan_.staticClass, "onClick", "(Landroid/view/View;)V");
		}
	}
}
