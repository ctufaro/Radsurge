using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radsurge.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Search(FormCollection collection)
        {
            return RedirectToAction("Index", "Search", new { q = collection["SearchTerm"] });
        }

    }
}
