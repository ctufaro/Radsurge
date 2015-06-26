using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Radsurge.MVC.Enums;
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
            int result = 0;
            EnumModels.Role enumRole;
            
            if (ModelState.IsValid)
            {
                RadsurgeSQL radSQL = new RadsurgeSQL();
                switch (registerModels.Role)
                {
                    case("0"):
                        result = radSQL.InsertDeveloper(registerModels.UserName, registerModels.Email, registerModels.Password).First().Value;
                        enumRole = EnumModels.Role.Developer;
                        break;
                    case("1"):
                        result = radSQL.InsertMerchant(registerModels.UserName, registerModels.Email, registerModels.Password).First().Value;
                        enumRole = EnumModels.Role.Merchant;
                        break;
                    default:
                        enumRole = EnumModels.Role.Default;
                        break;
                }

                if (result == 0)
                {
                    ModelState.AddModelError("Email", "E-mail already registered");
                    return View("Index");
                }
                else
                {
                    return View("ThankYou", enumRole);
                }
            }

            return View("Index");

            
        }

        public ActionResult TY(string role)
        {
            EnumModels.Role enumRole;
            enumRole = role.Equals("D") ? EnumModels.Role.Developer : EnumModels.Role.Merchant;
            return View("ThankYou", enumRole);
        }
    }
}
