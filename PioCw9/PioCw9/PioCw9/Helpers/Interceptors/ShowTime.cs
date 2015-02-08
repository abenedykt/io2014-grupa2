using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;

namespace PioCw9.Helpers.Interceptors
{
    public class ShowTime:IInterceptor
    {

        public void Intercept(IInvocation invocation)
        {
            var timer = new Stopwatch();
            timer.Start();
            invocation.Proceed();
            timer.Stop();
            Debug.WriteLine(timer.Elapsed.ToString());
        }
    }
}