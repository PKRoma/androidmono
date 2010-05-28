namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Spannable : Spanned
	{ 
		void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3); 
		void removeSpan(java.lang.Object arg0); 
	} 

	public partial class Spannable_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Spannable.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Spannable : java.lang.Object, Spannable
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Spannable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__Spannable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.__Spannable(@__env); 
			} 
		} 
		internal __Spannable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpan6888; 
		 void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				@__env.CallVoidMethod(this, global::android.text.__Spannable._setSpan6888, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._setSpan6888, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSpan6889; 
		 void android.text.Spannable.removeSpan(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				@__env.CallVoidMethod(this, global::android.text.__Spannable._removeSpan6889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._removeSpan6889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpans6890; 
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			if (GetType() == typeof(android.text.__Spannable)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Spannable._getSpans6890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._getSpans6890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanStart6891; 
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return @__env.CallIntMethod(this, global::android.text.__Spannable._getSpanStart6891, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._getSpanStart6891, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanEnd6892; 
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return @__env.CallIntMethod(this, global::android.text.__Spannable._getSpanEnd6892, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._getSpanEnd6892, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanFlags6893; 
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return @__env.CallIntMethod(this, global::android.text.__Spannable._getSpanFlags6893, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._getSpanFlags6893, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextSpanTransition6894; 
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return @__env.CallIntMethod(this, global::android.text.__Spannable._nextSpanTransition6894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._nextSpanTransition6894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6895; 
		 global::java.lang.String java.lang.CharSequence.toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Spannable._toString6895)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._toString6895)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length6896; 
		 int java.lang.CharSequence.length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return @__env.CallIntMethod(this, global::android.text.__Spannable._length6896); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._length6896); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charAt6897; 
		 char java.lang.CharSequence.charAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return @__env.CallCharMethod(this, global::android.text.__Spannable._charAt6897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._charAt6897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6898; 
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__Spannable)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Spannable._subSequence6898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Spannable.staticClass, global::android.text.__Spannable._subSequence6898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.__Spannable.staticClass = @__class; 
			global::android.text.__Spannable._setSpan6888 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spannable.setSpan", "(Ljava/lang/Object;III)V"); 
			global::android.text.__Spannable._removeSpan6889 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spannable.removeSpan", "(Ljava/lang/Object;)V"); 
			global::android.text.__Spannable._getSpans6890 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spanned.getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;"); 
			global::android.text.__Spannable._getSpanStart6891 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spanned.getSpanStart", "(Ljava/lang/Object;)I"); 
			global::android.text.__Spannable._getSpanEnd6892 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spanned.getSpanEnd", "(Ljava/lang/Object;)I"); 
			global::android.text.__Spannable._getSpanFlags6893 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spanned.getSpanFlags", "(Ljava/lang/Object;)I"); 
			global::android.text.__Spannable._nextSpanTransition6894 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "android.text.Spanned.nextSpanTransition", "(IILjava/lang/Class;)I"); 
			global::android.text.__Spannable._toString6895 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "java.lang.CharSequence.toString", "()Ljava/lang/String;"); 
			global::android.text.__Spannable._length6896 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "java.lang.CharSequence.length", "()I"); 
			global::android.text.__Spannable._charAt6897 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "java.lang.CharSequence.charAt", "(I)C"); 
			global::android.text.__Spannable._subSequence6898 = @__env.GetMethodID(global::android.text.__Spannable.staticClass, "java.lang.CharSequence.subSequence", "(II)Ljava/lang/CharSequence;"); 
		} 
	} 
} 