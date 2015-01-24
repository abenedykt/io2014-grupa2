using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCinterceptors.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var date = (DateTime.Now.Millisecond).ToString();
            return View("Index", null, date);
        }

    }
}
