using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Speakers = new List<Speaker>
            {
                new Speaker
                {
                    SpeakerId = 10803,
                    UserFirstName = "Eugene",
                    UserLastName = "Chuvyrov",
                    TrackName = "Microservices",
                    Company = "Microsoft"
                },
                new Speaker
                {
                    SpeakerId = 187,
                    UserFirstName = "David",
                    UserLastName = "Nielsen",
                    TrackName = "Microservices",
                    Company = "RedHat"
                },
                new Speaker
                {
                    SpeakerId = 1269,
                    UserFirstName = "Arun",
                    UserLastName = "Gupta",
                    TrackName = "Microservices",
                    Company = "Oracle"
                },
                new Speaker
                {
                    SpeakerId = 1725,
                    UserFirstName = "Brad",
                    UserLastName = "Irby",
                    TrackName = "Microservices",
                    Company = "BradIrby"
                },
                new Speaker
                {
                    SpeakerId = 2920,
                    UserFirstName = "Ron",
                    UserLastName = "Lichty",
                    TrackName = "Microservices",
                    Company = "Ron Lichty Consulting, Inc."
                },
                new Speaker
                {
                    SpeakerId = 1124,
                    UserFirstName = "Douglas",
                    UserLastName = "Crockford",
                    TrackName = "JavaScript",
                    Company = "PayPal"
                },
                new Speaker
                {
                    SpeakerId = 823,
                    UserFirstName = "Kevin",
                    UserLastName = "Nilson",
                    TrackName = "JavaScript",
                    Company = "Google"
                },
                new Speaker
                {
                    SpeakerId = 6548,
                    UserFirstName = "Steve",
                    UserLastName = "Souders",
                    TrackName = "JavaScript",
                    Company = "SpeedCurver"
                },
                new Speaker
                {
                    SpeakerId = 1530,
                    UserFirstName = "Tamara",
                    UserLastName = "Baker",
                    TrackName = "Microservices",
                    Company = "Cantaloupe Systems"
                },
                new Speaker
                {
                    SpeakerId = 41808,
                    UserFirstName = "Paul",
                    UserLastName = "Everitt",
                    TrackName = "JavaScript",
                    Company = "JetBrains"
                }
            };

            return View(Speakers);
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}