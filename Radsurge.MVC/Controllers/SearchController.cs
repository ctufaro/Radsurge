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
        //
        // GET: /Search/
        public ActionResult Index(string q)
        {
            ViewBag.SearchTerm = q;
            SearchResults sr = new SearchResults { SearchTerm = q };
            return View(sr);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection collection)
        {
            string q = collection["searchTxt"];
            SearchResults sr = new SearchResults { SearchTerm = q };
            return View(sr);
        }

    }
}
