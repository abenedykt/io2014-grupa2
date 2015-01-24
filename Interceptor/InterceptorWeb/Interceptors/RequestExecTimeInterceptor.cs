using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using InterceptorWeb.Controllers;
using System.Web.Mvc;

namespace InterceptorWeb.Interceptors
{
    public class RequestExecTimeInterceptor : IRequestInterceptor
    {

        private IContainer container {get; set; }

        public RequestExecTimeInterceptor()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<HomeController>().As<Controller>();
            container = builder.Build();
        }


    }
}