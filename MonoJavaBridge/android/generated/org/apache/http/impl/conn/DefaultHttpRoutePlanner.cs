namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpRoutePlanner : java.lang.Object, org.apache.http.conn.routing.HttpRoutePlanner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpRoutePlanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.conn.DefaultHttpRoutePlanner.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.impl.conn.DefaultHttpRoutePlanner._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.conn.routing.HttpRoute;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DefaultHttpRoutePlanner(org.apache.http.conn.scheme.SchemeRegistry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.DefaultHttpRoutePlanner._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.DefaultHttpRoutePlanner._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultHttpRoutePlanner.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultHttpRoutePlanner.staticClass, global::org.apache.http.impl.conn.DefaultHttpRoutePlanner._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DefaultHttpRoutePlanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultHttpRoutePlanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultHttpRoutePlanner"));
		}
	}
}