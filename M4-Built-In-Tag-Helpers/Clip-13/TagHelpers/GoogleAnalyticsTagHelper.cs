using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTHC.TagHelpers
{
    [HtmlTargetElement("body")]

    public class GoogleAnalyticsTagHelper : TagHelper
    {
        [HtmlAttributeName("tracking-code")]
        public string TrackingCode { get; set; } = "UA-XXXXXX-XX";

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