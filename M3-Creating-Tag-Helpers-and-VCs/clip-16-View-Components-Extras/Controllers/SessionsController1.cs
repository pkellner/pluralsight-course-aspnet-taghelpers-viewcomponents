using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppTagHelper.Controllers
{
    [Route("api/sessions")]
    public class SessionsController : Controller
    {

        // GET: /<controller>/

        [HttpGet]
        public JsonResult Index()
        {
            var sessions = new List<Session>() {  new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            },
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            } ,
             new Session
            {
                SpeakerId = 101,
                Title = "Critical Agile Practices, Nuanced Techniques",
            }
            };


            return Json(sessions);
        }
    }
}
