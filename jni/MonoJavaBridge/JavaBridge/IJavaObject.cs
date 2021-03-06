﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoJavaBridge
{
    public interface IJavaObject
    {
	    JniGlobalHandle JvmHandle
        {
            get;
        }

        bool IsClrObject
        {
            get;
        }
        
        void Init(JNIEnv env, JniLocalHandle handle);
	}
}
