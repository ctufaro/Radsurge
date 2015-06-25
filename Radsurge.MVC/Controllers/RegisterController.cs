using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Radsurge.MVC.Models;

namespace Radsurge.MVC.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(RegisterModels registerModels)
        {
            if (ModelState.IsValid)
            {
            }

            return View("Index");
        }

    }
}
