using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("time-since")]
    public class TimeSinceTagHelper : TagHelper
    {
        public string CompareDateTime { get; set; }

        private ITimeSinceService _timeSinceService;

        public TimeSinceTagHelper(ITimeSinceService timeSinceService)
        {
            _timeSinceService = timeSinceService;
        }

        public override void Process(TagHelperContext context, 
            TagHelperOutput output)
        {
            output.Content.
                SetContent(_timeSinceService.TimeSince(
                    Convert.ToDateTime(CompareDateTime)));
        }
    }
}
