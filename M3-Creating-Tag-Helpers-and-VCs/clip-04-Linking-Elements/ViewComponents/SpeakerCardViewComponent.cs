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
