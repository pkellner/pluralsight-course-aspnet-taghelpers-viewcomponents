using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterTH(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var model = new RegisterViewModel()
            {
                FirstName = "Joe",
                LastName = "Plumber",
                CountryCode = "US",
                Email = "Joe@Whitehouse.gov",
                SpecialMeal = true,
                RegisterAddress = new RegisterAddress
                {
                    City = "San Francisco",
                    State = "CA",
                    PhoneNumber = "408-876-1234"
                }
            };

            return View("RegisterTH", model);

            //ViewBag.Countries = new List<SelectListItem>
            //{
            //    new SelectListItem { Value = "MX", Text = "Mexico" },
            //    new SelectListItem { Value = "CA", Text = "Canada" },
            //    new SelectListItem { Value = "US", Text = "USA" },
            //    new SelectListItem { Value = "FR", Text = "France" },
            //    new SelectListItem { Value = "ES", Text = "Spain" },
            //    new SelectListItem { Value = "DE", Text = "Germany"}
            //};

            //ViewBag.Countries = new CountryViewModel().Countries();
            //return View("RegisterTH", model);
        }
    }
}