using InterceptorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using InterceptorWeb.Interceptors;
namespace InterceptorWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Index/




        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Result = DateTime.Now.Millisecond.ToString();
            return View(model);
        }

    }
}
