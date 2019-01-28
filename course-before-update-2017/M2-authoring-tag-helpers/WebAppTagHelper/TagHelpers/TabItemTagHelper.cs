using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [RestrictChildren("tab-item")]
    public class TabItemTagHelper : TagHelper
    {

        public string Title { get; set; }

        public override void Process(
            TagHelperContext context, TagHelperOutput output)
        {
            string activePage = context.Items["ActivePage"] as string;

            if (activePage == Title)
            {
                output.Attributes.Add("class", "active");
            }

            output.TagName = "li";
            var str = string.Format("<a href = '#' >{0}</a>", Title);
            output.Content.SetHtmlContent(str);
        }
    }
}

