using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Radsurge.MVC.Models;
using Radsurge.MVC.EntityModel;

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
                RadsurgeSQL radSQL = new RadsurgeSQL();
                if (registerModels.Role.Equals("0"))
                {
                    var shit = radSQL.InsertDeveloper(registerModels.UserName, registerModels.Company, registerModels.Email, registerModels.Password);
                }
                else
                {
                    var shit = radSQL.InsertMerchant(registerModels.UserName, registerModels.Company, registerModels.Email, registerModels.Password);
                }
            }

            return View("Index");
        }

    }
}
