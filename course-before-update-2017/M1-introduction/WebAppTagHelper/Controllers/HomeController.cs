using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTagHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ModelAddress()
            {
                FirstName = "Peter"
            };
            return View(model);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public class Info
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
    public class ModelAddress
    {
        public string FirstName { get; set; }
    }
}
