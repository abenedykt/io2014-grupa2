using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /FirstControler/

        public ActionResult index()
        {
            return View("index", null, 12);
        }

    }
}
