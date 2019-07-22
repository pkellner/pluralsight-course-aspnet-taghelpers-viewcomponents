using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.ViewComponents
{
    public class SpeakerCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            Speaker speaker)
        {
            return View(speaker);
        }
    }
}
