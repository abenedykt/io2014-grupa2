using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Autofac.Extras.DynamicProxy2;
using PioCw9.Helpers.Interceptors;

namespace PioCw9.Controllers
{
    [Intercept(typeof(ShowTime))]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Index()
        {
            Thread.Sleep(2000);

            return View("Index", null, DateTime.Now.Millisecond.ToString());
        }

    }
}
