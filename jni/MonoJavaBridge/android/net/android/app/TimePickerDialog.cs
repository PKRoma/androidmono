namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimePickerDialog : android.app.AlertDialog, android.content.DialogInterface_OnClickListener, android.widget.TimePicker.OnTimeChangedListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TimePickerDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.TimePickerDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.TimePickerDialog(@__env); 
			} 
		} 
		protected TimePickerDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTimeSetListener 
		{ 
			void onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2); 
		} 

		public partial class OnTimeSetListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnTimeSetListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnTimeSetListener : java.lang.Object, OnTimeSetListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnTimeSetListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.TimePickerDialog.__OnTimeSetListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.TimePickerDialog.__OnTimeSetListener(@__env); 
				} 
			} 
			internal __OnTimeSetListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTimeSet770; 
			 void android.app.TimePickerDialog.OnTimeSetListener.onTimeSet(android.widget.TimePicker arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.TimePickerDialog.__OnTimeSetListener)) 
					@__env.CallVoidMethod(this, global::android.app.TimePickerDialog.__OnTimeSetListener._onTimeSet770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.app.TimePickerDialog.__OnTimeSetListener.staticClass, global::android.app.TimePickerDialog.__OnTimeSetListener._onTimeSet770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.TimePickerDialog.__OnTimeSetListener.staticClass = @__class; 
				global::android.app.TimePickerDialog.__OnTimeSetListener._onTimeSet770 = @__env.GetMethodID(global::android.app.TimePickerDialog.__OnTimeSetListener.staticClass, "android.app.TimePickerDialog.OnTimeSetListener.onTimeSet", "(Landroid/widget/TimePicker;II)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick771; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.TimePickerDialog._onClick771, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onClick771, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState772; 
		public override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.TimePickerDialog._onRestoreInstanceState772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onRestoreInstanceState772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState773; 
		public override global::android.os.Bundle onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.TimePickerDialog._onSaveInstanceState773)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onSaveInstanceState773)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTimeChanged774; 
		public virtual void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.TimePickerDialog._onTimeChanged774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._onTimeChanged774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateTime775; 
		public virtual void updateTime(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TimePickerDialog)) 
				@__env.CallVoidMethod(this, global::android.app.TimePickerDialog._updateTime775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._updateTime775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePickerDialog776; 
		public TimePickerDialog(android.content.Context arg0, android.app.TimePickerDialog.OnTimeSetListener arg1, int arg2, int arg3, bool arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog776, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimePickerDialog777; 
		public TimePickerDialog(android.content.Context arg0, int arg1, android.app.TimePickerDialog.OnTimeSetListener arg2, int arg3, int arg4, bool arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.TimePickerDialog.staticClass, global::android.app.TimePickerDialog._TimePickerDialog777, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.TimePickerDialog.staticClass = @__class; 
			global::android.app.TimePickerDialog._onClick771 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.app.TimePickerDialog._onRestoreInstanceState772 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.TimePickerDialog._onSaveInstanceState773 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.TimePickerDialog._onTimeChanged774 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V"); 
			global::android.app.TimePickerDialog._updateTime775 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "updateTime", "(II)V"); 
			global::android.app.TimePickerDialog._TimePickerDialog776 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V"); 
			global::android.app.TimePickerDialog._TimePickerDialog777 = @__env.GetMethodID(global::android.app.TimePickerDialog.staticClass, "<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V"); 
		} 
	} 
} 