using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using PioCw9.Logic;

namespace PioCw9.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private ContainerBuilder builder;

        public HomeController()
        {
            builder = new ContainerBuilder();
            builder.RegisterType<ActionResult>();
            builder.Register(c => new CallLogger());
        }

       
        public ActionResult Index()
        {
            return View("Index", null, DateTime.Now.Millisecond.ToString()); 
        }

    }
}
