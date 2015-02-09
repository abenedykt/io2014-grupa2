using InterceptorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using InterceptorWeb.Interceptors;
using InterceptorWeb.Props;
namespace InterceptorWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Index/      

        [ControllerExecutionFilter]
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel("");

            //simulate some work with rand sleep
            Random rand = new Random();
            int randSleep = rand.Next(400);
            System.Threading.Thread.Sleep(randSleep);
        

            return View(model);
        }

    }
}
