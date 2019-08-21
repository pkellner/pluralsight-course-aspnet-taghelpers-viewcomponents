using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTHC.TagHelperComponents
{
    public class FooterTagHelperComponent : TagHelperComponent
    {
        public string CopyrightNotice { get; set; }

        public FooterTagHelperComponent(string copyrightNotice)
        {
            CopyrightNotice = copyrightNotice;
        }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "footer",
                StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml("<br/>" + CopyrightNotice);
            }
            return Task.CompletedTask;
        }
    }
}
 