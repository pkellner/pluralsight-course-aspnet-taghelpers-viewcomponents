using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHelpersBuiltInAspNetCore.Controllers
{
    public class BuiltInTagController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public class ModelParam
        {
            public int Sum { get; set; }
            public string Param1 { get; set; }
            public string Param2 { get; set; }
        }


        public IActionResult CacheTagHelper(
            string id, 
            string myParam1, string myParam2, string myParam3)
        {

            string viewName = id == null
                ? "CacheTagHelper/no-parameters"
                : "CacheTagHelper/" + id;

            int num1;
            int num2;
            int.TryParse(myParam1, out num1);
            int.TryParse(myParam2, out num2);

            var model = new ModelParam
            {
                Sum = num1 + num2,
                Param1 = myParam1,
                Param2 = myParam2
            };

            ViewData["Message"] = "Default Route";
        
            return View(viewName, model);
        }


        public IActionResult AnchorTagHelper(string id)
        {
            string viewName = id == null
                ? "AnchorTagHelper/controller-action"
                : "AnchorTagHelper/" + id;

            var speaker = new SpeakerData
            {
                SpeakerId = 12
            };

            return View(viewName, speaker);
        }

        public IActionResult DistributedCacheTagHelper(string id)
        {
            string viewName = id == null
                ? "DistributedCacheTagHelper/controller-action"
                : "DistributedCacheTagHelper/" + id;

            return View(viewName);
        }

        public IActionResult AnchorTagHelperRouteValue()
        {
            string viewName =
                "AnchorTagHelper/" + "asp-routevalue-dash10";

            var speaker = new SpeakerData
            {
                SpeakerId = 12
            };

            return View(viewName, speaker);
        }

        //public IActionResult AnchorTagHelperRouteValueDash(int id)
        //{
        //    //http://localhost:2651/BuiltInTag/AnchorTagHelper/asp-routevalue-dash/
        //    string viewName = "BuiltInTag/AnchorTagHelper/asp-routevalue-dash/";
        //    var speaker = new TagHelpersBuiltInAspNetCore.Controllers.SpeakerData()
        //    {
        //        SpeakerId = 12
        //    };
        //    return View(viewName, speaker);
        //    //return View(@"BuiltInTag/AnchorTagHelper/asp-routevalue-dash");
        //}

        public IActionResult ImageTagHelper()
        {
            return View();
        }

        public IActionResult ScriptTagHelper()
        {
            return View();
        }


        [Route("/carprice/{make}/{model}", 
            Name = "carprice")]
        public IActionResult CarPrice(
            string make,string model)
        {
            return View("CacheTagHelper/vary-by-route");
        }

       




        public IActionResult EnvironmentTagHelper()
        {
            

            return View();
        }

        

        

        //[Route("CacheTagHelper/{id:string}")]
        //public IActionResult CacheTagHelper(string id)
        //{
        //    string viewName = "CacheTagHelper/" + id;
        //    return View(viewName);
        //}
    }

    
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string SpeakerName { get; set; }
    }
}
