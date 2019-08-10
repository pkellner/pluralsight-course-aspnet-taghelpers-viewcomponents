using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult RegisterMVC()
        {
            return View("RegisterMVC");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterMVC(RegisterViewModel model)
        {
            return View("RegisterMVC");
        }
    }
}