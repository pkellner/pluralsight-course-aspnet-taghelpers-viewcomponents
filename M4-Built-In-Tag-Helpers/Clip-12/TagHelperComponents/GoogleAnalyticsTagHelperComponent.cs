using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace WebAppTHC.TagHelperComponents
{
    public class GoogleAnalyticsTagHelperComponent : TagHelperComponent
    {
        public GoogleAnalyticsTagHelperComponent(string trackingCode)
        {
            TrackingCode = trackingCode;
        }
        [HtmlAttributeName("tracking-code")]
        public string TrackingCode { get; set; } = "UA-XXXXXX-XX";

        public override Task ProcessAsync
            (TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "body",
                StringComparison.OrdinalIgnoreCase))
            {
                    var gaString =
                "<script>window.ga=window.ga||function(){(ga.q=ga.q||[]).push(arguments)};ga.l=+new Date;ga('create', '" +
                TrackingCode +
                "', 'auto');ga('send', 'pageview');</script><script async src='https://www.google-analytics.com/analytics.js'></script>";
                    output.PostContent.AppendHtml(gaString);
            }
            

            return Task.CompletedTask;
        }
    }
}