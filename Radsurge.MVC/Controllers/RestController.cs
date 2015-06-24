using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radsurge.MVC.Controllers
{
    public class RestController : Controller
    {
        //
        // GET: /Rest/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Template()
        {
            return View();
        }

    }
}
