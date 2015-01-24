using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Castle.DynamicProxy;
using System.IO;
using Autofac.Extras.DynamicProxy2;

namespace Mvc.Interceptor
{
    public class MyInterceptor : IInterceptor
    {
        TextWriter _output;
        public MyInterceptor(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInterceptor invocation)
        {
            

        }
    }
}