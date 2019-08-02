using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.ViewComponents
{
    public class SpeakerCardViewComponent : ViewComponent
    {
        private ISessionsService _sessionsService;
        private IHttpContextAccessor _httpContextAccessor;

        public SpeakerCardViewComponent(ISessionsService sessionsService, IHttpContextAccessor httpContextAccessor)
        {
            _sessionsService = sessionsService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            Speaker speaker)
        {
            var isHttps = _httpContextAccessor.HttpContext.Request.IsHttps;
            var baseUrl = isHttps ? "https://" : "http://"
                                                 + _httpContextAccessor.HttpContext.Request.Host.Value
                                                 + "/";


            var sessions = await _sessionsService.GetSessions(speaker.SpeakerId, baseUrl);
            speaker.Sessions = sessions;
            return View(speaker);
        }
    }
}
