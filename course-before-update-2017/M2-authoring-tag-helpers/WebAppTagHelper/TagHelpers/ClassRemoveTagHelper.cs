using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "custom-highlight")]
    public class ClassRemoveTagHelper : TagHelper
    {
        public override int Order
        {
            get { return 5; }
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tagHelperAttribute =
                output.Attributes.Where(a => a.Name == "class"
                && (a.Value).ToString() == "highlight").
                FirstOrDefault();
            if (tagHelperAttribute != null)
            {
                output.Attributes.Remove(tagHelperAttribute);
            }
        }
    }
}
