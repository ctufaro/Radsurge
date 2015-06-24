using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult SignUp(FormCollection form)
        {
            var role = form["role"].Equals("0") ? 0 : 1;
            var username = form["username"];
            var company = form["company"];
            var email = form["email"];
            var password = form["password"];
            var password_confirm = form["password_confirm"];
            return View("Index");
        }

    }
}
