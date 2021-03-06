namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimePicker : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimePicker()
		{
			InitJNI();
		}
		protected TimePicker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TimePicker.OnTimeChangedListener_))]
		public interface OnTimeChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TimePicker.OnTimeChangedListener))]
		public sealed partial class OnTimeChangedListener_ : java.lang.Object, OnTimeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTimeChangedListener_()
			{
				InitJNI();
			}
			internal OnTimeChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTimeChanged12318;
			 void android.widget.TimePicker.OnTimeChangedListener.onTimeChanged(android.widget.TimePicker arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged12318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged12318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TimePicker.OnTimeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker$OnTimeChangedListener"));
				global::android.widget.TimePicker.OnTimeChangedListener_._onTimeChanged12318 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.OnTimeChangedListener_.staticClass, "onTimeChanged", "(Landroid/widget/TimePicker;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled12319;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setEnabled12319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setEnabled12319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState12320;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._onRestoreInstanceState12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onRestoreInstanceState12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState12321;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._onSaveInstanceState12321)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._onSaveInstanceState12321)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12322;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TimePicker._getBaseline12322);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getBaseline12322);
		}
		internal static global::MonoJavaBridge.MethodId _is24HourView12323;
		public virtual bool is24HourView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TimePicker._is24HourView12323);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._is24HourView12323);
		}
		internal static global::MonoJavaBridge.MethodId _setOnTimeChangedListener12324;
		public virtual void setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setOnTimeChangedListener12324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setOnTimeChangedListener12324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentHour12325;
		public virtual global::java.lang.Integer getCurrentHour() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._getCurrentHour12325)) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentHour12325)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentHour12326;
		public virtual void setCurrentHour(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setCurrentHour12326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentHour12326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIs24HourView12327;
		public virtual void setIs24HourView(java.lang.Boolean arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setIs24HourView12327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setIs24HourView12327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentMinute12328;
		public virtual global::java.lang.Integer getCurrentMinute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TimePicker._getCurrentMinute12328)) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._getCurrentMinute12328)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentMinute12329;
		public virtual void setCurrentMinute(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TimePicker._setCurrentMinute12329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TimePicker.staticClass, global::android.widget.TimePicker._setCurrentMinute12329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker12330;
		public TimePicker(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker12330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker12331;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker12331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimePicker12332;
		public TimePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TimePicker.staticClass, global::android.widget.TimePicker._TimePicker12332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TimePicker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TimePicker"));
			global::android.widget.TimePicker._setEnabled12319 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TimePicker._onRestoreInstanceState12320 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TimePicker._onSaveInstanceState12321 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TimePicker._getBaseline12322 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getBaseline", "()I");
			global::android.widget.TimePicker._is24HourView12323 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "is24HourView", "()Z");
			global::android.widget.TimePicker._setOnTimeChangedListener12324 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V");
			global::android.widget.TimePicker._getCurrentHour12325 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getCurrentHour", "()Ljava/lang/Integer;");
			global::android.widget.TimePicker._setCurrentHour12326 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setCurrentHour", "(Ljava/lang/Integer;)V");
			global::android.widget.TimePicker._setIs24HourView12327 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setIs24HourView", "(Ljava/lang/Boolean;)V");
			global::android.widget.TimePicker._getCurrentMinute12328 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "getCurrentMinute", "()Ljava/lang/Integer;");
			global::android.widget.TimePicker._setCurrentMinute12329 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "setCurrentMinute", "(Ljava/lang/Integer;)V");
			global::android.widget.TimePicker._TimePicker12330 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TimePicker._TimePicker12331 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TimePicker._TimePicker12332 = @__env.GetMethodIDNoThrow(global::android.widget.TimePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
