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
            SearchResults sr = new SearchResults();
            sr.SearchTerm = q;
            sr.ReturnedResults.Add(new Results
            {
                DeveloperName = "",
                DeveloperProductClaim = "Play Round 1 - Get High Score",
                DeveloperProductImage = "~/Content/Images/Results/Kimiko.png",
                DeveloperProductName = "Kimiko Forgotten Forest",
                DeveloperProductUrl = "",
                MerchantIncentive = "15% Off Dipped Chocolate",
                MerchantName = "Dipped Chocolate Designs",
                MerchantProductImage = "~/Content/Images/Results/Dipped.jpg",
                MerchantProductName = "Chocolate Strawberries",
                MerchantUrl = ""
            });

            sr.ReturnedResults.Add(new Results
            {
                DeveloperName = "",
                DeveloperProductClaim = "Play Round 1 - Get High Score",
                DeveloperProductImage = "~/Content/Images/Results/Kimiko.png",
                DeveloperProductName = "Kimiko Forgotten Forest",
                DeveloperProductUrl = "",
                MerchantIncentive = "Free Fresqe Sample",
                MerchantName = "Fresqe Body Scrub",
                MerchantProductImage = "~/Content/Images/Results/Fresqe.jpg",
                MerchantProductName = "Fresqe Body Scrub",
                MerchantUrl = ""
            });
            return View(sr);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection collection)
        {
            return RedirectToAction("Index", "Search", new { q = collection["SearchTerm"] });
        }

    }
}
