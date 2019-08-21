using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppTagHelper.Models;
namespace WebAppTagHelper.Controllers
{
    [Route("api/sessions")]
    public class SessionsController : Controller
    {
        [HttpGet]
        public JsonResult Index()
        {
            var sessions = new List<Session>
            {
                new Session
                {
                    SpeakerId = 1124,
                    Title = "The History of JSON"
                },
                new Session
                {
                    SpeakerId = 1124,
                    Title = "How JavaScript Works"
                },
                new Session
                {
                    SpeakerId = 1124,
                    Title = "The Good Parts"
                },
                new Session
                {
                    SpeakerId = 6548,
                    Title = "Web Panel"
                },
                new Session
                {
                    SpeakerId = 6548,
                    Title = "Faster Mobile Anyone?"
                },
                new Session
                {
                    SpeakerId = 823,
                    Title = "Chromecast"
                },
                new Session
                {
                    SpeakerId = 823,
                    Title = "Google Data APIs"
                }
            };
            return Json(sessions);
        }
    }
}