using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Radsurge.MVC.Models;

namespace Radsurge.MVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /Search/
        public ActionResult Index(string q)
        {
            return View(new SearchResults { SearchTerm = q });
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection collection)
        {
            return RedirectToAction("Index", "Search", new { q = collection["SearchTerm"] });
        }

    }
}
