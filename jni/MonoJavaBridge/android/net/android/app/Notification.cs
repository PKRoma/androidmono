namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Notification : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Notification() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Notification), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.Notification(@__env); 
			} 
		} 
		protected Notification(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString658; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Notification._toString658)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Notification.staticClass, global::android.app.Notification._toString658)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel659; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				@__env.CallVoidMethod(this, global::android.app.Notification._writeToParcel659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._writeToParcel659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents660; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				return @__env.CallIntMethod(this, global::android.app.Notification._describeContents660); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._describeContents660); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLatestEventInfo661; 
		public virtual void setLatestEventInfo(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, android.app.PendingIntent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				@__env.CallVoidMethod(this, global::android.app.Notification._setLatestEventInfo661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._setLatestEventInfo661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Notification662; 
		public Notification()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification662, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Notification663; 
		public Notification(int arg0, java.lang.CharSequence arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification663, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Notification664; 
		public Notification(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification664, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int DEFAULT_ALL
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int DEFAULT_SOUND
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DEFAULT_VIBRATE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DEFAULT_LIGHTS
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _when665; 
		public long when
		{ 
			get 
			{ 
				return default(long); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _icon666; 
		public int icon
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _number667; 
		public int number
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _contentIntent668; 
		public global::android.app.PendingIntent contentIntent
		{ 
			get 
			{ 
				return default(global::android.app.PendingIntent); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _deleteIntent669; 
		public global::android.app.PendingIntent deleteIntent
		{ 
			get 
			{ 
				return default(global::android.app.PendingIntent); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _tickerText670; 
		public global::java.lang.CharSequence tickerText
		{ 
			get 
			{ 
				return default(global::java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _contentView671; 
		public global::android.widget.RemoteViews contentView
		{ 
			get 
			{ 
				return default(global::android.widget.RemoteViews); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _iconLevel672; 
		public int iconLevel
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sound673; 
		public global::android.net.Uri sound
		{ 
			get 
			{ 
				return default(global::android.net.Uri); 
			} 
			set 
			{ 
			} 
		} 
		public static int STREAM_DEFAULT
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _audioStreamType674; 
		public int audioStreamType
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _vibrate675; 
		public long[] vibrate
		{ 
			get 
			{ 
				return default(long[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ledARGB676; 
		public int ledARGB
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ledOnMS677; 
		public int ledOnMS
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ledOffMS678; 
		public int ledOffMS
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _defaults679; 
		public int defaults
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		public static int FLAG_SHOW_LIGHTS
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FLAG_ONGOING_EVENT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int FLAG_INSISTENT
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int FLAG_ONLY_ALERT_ONCE
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int FLAG_AUTO_CANCEL
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int FLAG_NO_CLEAR
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int FLAG_FOREGROUND_SERVICE
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _flags680; 
		public int flags
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR681; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Notification.staticClass = @__class; 
			global::android.app.Notification._toString658 = @__env.GetMethodID(global::android.app.Notification.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.app.Notification._writeToParcel659 = @__env.GetMethodID(global::android.app.Notification.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.app.Notification._describeContents660 = @__env.GetMethodID(global::android.app.Notification.staticClass, "describeContents", "()I"); 
			global::android.app.Notification._setLatestEventInfo661 = @__env.GetMethodID(global::android.app.Notification.staticClass, "setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V"); 
			global::android.app.Notification._Notification662 = @__env.GetMethodID(global::android.app.Notification.staticClass, "<init>", "()V"); 
			global::android.app.Notification._Notification663 = @__env.GetMethodID(global::android.app.Notification.staticClass, "<init>", "(ILjava/lang/CharSequence;J)V"); 
			global::android.app.Notification._Notification664 = @__env.GetMethodID(global::android.app.Notification.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 