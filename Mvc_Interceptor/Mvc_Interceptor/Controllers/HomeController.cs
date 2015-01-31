using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Autofac.Extras.DynamicProxy2;

namespace Mvc_Interceptor.Controllers
{
    [Intercept(typeof(InvokeTimeLogger))]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var time = string.Format("{0}s {1}ms", DateTime.Now.Second, DateTime.Now.Millisecond);
            return View("Index", null, time);
        }
    }
}
