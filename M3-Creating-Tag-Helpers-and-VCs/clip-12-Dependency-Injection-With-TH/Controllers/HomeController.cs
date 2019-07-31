﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.Controllers
{
    public class HomeController : Controller
    {
        public class ModelAddress
        {
            public string FirstName { get; set; }
            public string LastName { get; internal set; }
        }
        public IActionResult ModelTest()
        {
            var model = new ModelAddress()
            {
                FirstName = "Peter",
                LastName = "Kellner"
            };
            return View("ModelTest",model);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
