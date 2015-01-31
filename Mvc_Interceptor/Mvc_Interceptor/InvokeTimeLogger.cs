using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;

namespace Mvc_Interceptor
{
    public class InvokeTimeLogger : IInterceptor
    {
        public InvokeTimeLogger()
        {
        }

        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("a");
        }
    }
}