namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RasterizerSpan : android.text.style.CharacterStyle, UpdateAppearance
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RasterizerSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.RasterizerSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.RasterizerSpan(@__env); 
			} 
		} 
		protected RasterizerSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRasterizer7383; 
		public virtual global::android.graphics.Rasterizer getRasterizer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.RasterizerSpan._getRasterizer7383)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rasterizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._getRasterizer7383)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7384; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.style.RasterizerSpan._updateDrawState7384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._updateDrawState7384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RasterizerSpan7385; 
		public RasterizerSpan(android.graphics.Rasterizer arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._RasterizerSpan7385, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.RasterizerSpan.staticClass = @__class; 
			global::android.text.style.RasterizerSpan._getRasterizer7383 = @__env.GetMethodID(global::android.text.style.RasterizerSpan.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;"); 
			global::android.text.style.RasterizerSpan._updateDrawState7384 = @__env.GetMethodID(global::android.text.style.RasterizerSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.RasterizerSpan._RasterizerSpan7385 = @__env.GetMethodID(global::android.text.style.RasterizerSpan.staticClass, "<init>", "(Landroid/graphics/Rasterizer;)V"); 
		} 
	} 
} 
