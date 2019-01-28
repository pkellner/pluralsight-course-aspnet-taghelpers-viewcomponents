using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace TagHelpersBuiltInAspNetCore.Controllers
{
    public class SpeakerController : Controller
    {
        public List<SpeakerData> Speakers = new List<SpeakerData>
        {
            new SpeakerData {SpeakerId = 10},
            new SpeakerData {SpeakerId = 11},
            new SpeakerData {SpeakerId = 12}
        };

        public int SpeakerId;

        [Route("Speaker/{id}",Name="speakerdetail")]
        public IActionResult Detail(int id)
        {
            SpeakerId = id;
            return View(Speakers.
                FirstOrDefault(a => a.SpeakerId == id));
        }

        
        [Route("/Speaker/Evaluations", Name = "speakerevals")]
        public IActionResult Evaluations()
        {
            return View();
        }

        [Route("/Speaker/EvaluationsCurrent", Name = "speakerevalscurrent")]
        public IActionResult EvaluationsCurrent(string speakerId,string currentYear)
        {
            return View();
        }

        [Route("/Speaker/{speakerId}/EvaluationsCount", 
            Name = "speakerevalscount")]
        public IActionResult EvaluationsCount(string speakerId)
        {
            return View();
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Speakers);
        }
    }

    public class SpeakerData
    {
        public int SpeakerId { get; set; }
    }
}