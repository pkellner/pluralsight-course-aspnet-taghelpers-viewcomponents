using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement(Attributes = "custom-highlight")]

[HtmlTargetElement(
  TagStructure = 
    TagStructure.Unspecified)]
    public class ClassAddTagHelper : TagHelper
    {
        public override int Order
        {
            get { return 10; }
        }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("class", "highlight");
        }
    }
}
