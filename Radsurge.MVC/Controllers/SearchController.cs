using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Radsurge.MVC.Models;
using Radsurge.MVC.EntityModel;

namespace Radsurge.MVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /Search/
        public ActionResult Index(string q)
        {
            SearchResultModels sr = new SearchResultModels
            { 
                                SearchTerm = q,
                                ReturnedResults = new RadsurgeSQL().GetSearchResults().ToList()
            }; 
            return View(sr);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection collection)
        {
            return RedirectToAction("Index", "Search", new { q = collection["SearchTerm"] });
        }

    }
}
