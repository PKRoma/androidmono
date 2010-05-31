namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class EditTextPreference : android.preference.DialogPreference
	{ 
		internal new static global::java.lang.Class staticClass; 
		static EditTextPreference() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.EditTextPreference), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.preference.EditTextPreference(@__env); 
			} 
		} 
		protected EditTextPreference(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText5942; 
		public virtual void setText(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.EditTextPreference._setText5942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._setText5942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText5943; 
		public virtual global::java.lang.String getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.EditTextPreference._getText5943)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getText5943)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState5944; 
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.EditTextPreference._onRestoreInstanceState5944, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onRestoreInstanceState5944, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState5945; 
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.EditTextPreference._onSaveInstanceState5945)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSaveInstanceState5945)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldDisableDependents5946; 
		public override bool shouldDisableDependents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.preference.EditTextPreference._shouldDisableDependents5946); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._shouldDisableDependents5946); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGetDefaultValue5947; 
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.EditTextPreference._onGetDefaultValue5947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onGetDefaultValue5947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetInitialValue5948; 
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.EditTextPreference._onSetInitialValue5948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onSetInitialValue5948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindDialogView5949; 
		protected override void onBindDialogView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.EditTextPreference._onBindDialogView5949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onBindDialogView5949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDialogClosed5950; 
		protected override void onDialogClosed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.EditTextPreference._onDialogClosed5950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onDialogClosed5950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAddEditTextToDialogView5951; 
		protected virtual void onAddEditTextToDialogView(android.view.View arg0, android.widget.EditText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.preference.EditTextPreference._onAddEditTextToDialogView5951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._onAddEditTextToDialogView5951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEditText5952; 
		public virtual global::android.widget.EditText getEditText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.EditText>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.EditTextPreference._getEditText5952)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.EditText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._getEditText5952)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditTextPreference5953; 
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference5953, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditTextPreference5954; 
		public EditTextPreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference5954, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditTextPreference5955; 
		public EditTextPreference(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.preference.EditTextPreference.staticClass, global::android.preference.EditTextPreference._EditTextPreference5955, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.EditTextPreference.staticClass = @__class; 
			global::android.preference.EditTextPreference._setText5942 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "setText", "(Ljava/lang/String;)V"); 
			global::android.preference.EditTextPreference._getText5943 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "getText", "()Ljava/lang/String;"); 
			global::android.preference.EditTextPreference._onRestoreInstanceState5944 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.preference.EditTextPreference._onSaveInstanceState5945 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.preference.EditTextPreference._shouldDisableDependents5946 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "shouldDisableDependents", "()Z"); 
			global::android.preference.EditTextPreference._onGetDefaultValue5947 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;"); 
			global::android.preference.EditTextPreference._onSetInitialValue5948 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V"); 
			global::android.preference.EditTextPreference._onBindDialogView5949 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onBindDialogView", "(Landroid/view/View;)V"); 
			global::android.preference.EditTextPreference._onDialogClosed5950 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onDialogClosed", "(Z)V"); 
			global::android.preference.EditTextPreference._onAddEditTextToDialogView5951 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V"); 
			global::android.preference.EditTextPreference._getEditText5952 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "getEditText", "()Landroid/widget/EditText;"); 
			global::android.preference.EditTextPreference._EditTextPreference5953 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.preference.EditTextPreference._EditTextPreference5954 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.preference.EditTextPreference._EditTextPreference5955 = @__env.GetMethodID(global::android.preference.EditTextPreference.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
