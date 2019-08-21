using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTHC.TagHelpers
{
    // without the "Attributes" second parameter, this body tag helper will act whether or not there is a tracking-code associated with it
    [HtmlTargetElement("body",Attributes = "tracking-code")]
    public class GoogleAnalyticsTagHelper : TagHelper
    {
        [HtmlAttributeName("tracking-code")]
        public string TrackingCode { get; set; } = "UA-123456-XX";

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var gaString =
                "<script>window.ga=window.ga||function(){(ga.q=ga.q||[]).push(arguments)};ga.l=+new Date;ga('create', '" +
                TrackingCode +
                "', 'auto');ga('send', 'pageview');</script><script async src='https://www.google-analytics.com/analytics.js'></script>";
            output.PostContent.AppendHtml(gaString);

            return Task.CompletedTask;
        }
    }
}