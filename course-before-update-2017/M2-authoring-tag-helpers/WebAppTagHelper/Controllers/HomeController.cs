using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAppTagHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ModelTest()
        {
            var model = new ModelAddress()
            {
                FirstName = "Peter",
                LastName = "Kellner"
            };
            return View("ModelTest", model);
        }

        //public IActionResult NasaData()
        //{
        //    var model = new NasaData()
        //    {
        //        MoonLandingDate = "07-20-1969",
        //        Country = "USA"
        //    };
        //    return View("NasaData", model);
        //}





        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModelSample()
        {
            var model = new ModelAddress()
            {
                FirstName = "Peter",
                LastName = "Kellner",
                Id = 101
            };
            return View("ModelSample", model);
        }

        public IActionResult FirstLastForm()
        {
            var model = new ModelAddress()
            {
                FirstName = "Peter",
                LastName = "Kellner",
                Id = 101
            };
            return View("FirstLastForm", model);
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
        public int Id { get; internal set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; internal set; }
    }
}
