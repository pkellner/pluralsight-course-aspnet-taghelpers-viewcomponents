using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    //[HtmlTargetElement("auto-price")]
    public class AutoPriceTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        public string Make { get; set; }

        [HtmlAttributeName("model-name")]
        public string Model { get; set;  }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
