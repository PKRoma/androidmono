namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UserDictionary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UserDictionary()
		{
			InitJNI();
		}
		protected UserDictionary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Words : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Words()
			{
				InitJNI();
			}
			protected Words(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _addWord7234;
			public static void addWord(android.content.Context arg0, java.lang.String arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.UserDictionary.Words.staticClass, global::android.provider.UserDictionary.Words._addWord7234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _Words7235;
			public Words()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.UserDictionary.Words.staticClass, global::android.provider.UserDictionary.Words._Words7235);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI7236;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					return default(global::android.net.Uri);
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/vnd.google.userword";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/vnd.google.userword";
				}
			}
			public static global::java.lang.String _ID
			{
				get
				{
					return "_id";
				}
			}
			public static global::java.lang.String WORD
			{
				get
				{
					return "word";
				}
			}
			public static global::java.lang.String FREQUENCY
			{
				get
				{
					return "frequency";
				}
			}
			public static global::java.lang.String LOCALE
			{
				get
				{
					return "locale";
				}
			}
			public static global::java.lang.String APP_ID
			{
				get
				{
					return "appid";
				}
			}
			public static int LOCALE_TYPE_ALL
			{
				get
				{
					return 0;
				}
			}
			public static int LOCALE_TYPE_CURRENT
			{
				get
				{
					return 1;
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "frequency DESC";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.UserDictionary.Words.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/UserDictionary$Words"));
				global::android.provider.UserDictionary.Words._addWord7234 = @__env.GetStaticMethodIDNoThrow(global::android.provider.UserDictionary.Words.staticClass, "addWord", "(Landroid/content/Context;Ljava/lang/String;II)V");
				global::android.provider.UserDictionary.Words._Words7235 = @__env.GetMethodIDNoThrow(global::android.provider.UserDictionary.Words.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _UserDictionary7237;
		public UserDictionary()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.UserDictionary.staticClass, global::android.provider.UserDictionary._UserDictionary7237);
			Init(@__env, handle);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "user_dictionary";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONTENT_URI7238;
		public static global::android.net.Uri CONTENT_URI
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.UserDictionary.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/UserDictionary"));
			global::android.provider.UserDictionary._UserDictionary7237 = @__env.GetMethodIDNoThrow(global::android.provider.UserDictionary.staticClass, "<init>", "()V");
		}
	}
}
