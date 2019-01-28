using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("mod-test")]
    public class ModTestTagHelper : TagHelper
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override void Process
            (TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent(FirstName + " " + LastName);
        }
    }
}
