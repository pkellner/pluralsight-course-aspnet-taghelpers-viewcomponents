 using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    //[HtmlTargetElement("*")]
    [HtmlTargetElement("auto-price",Attributes ="model")]
    [HtmlTargetElement("auto-price", Attributes = "make")]
    public class AutoPriceTagHelper : TagHelper
    {
        public string Make { get; set; }
        public string Model { get; set;  }

        public override void Process(TagHelperContext 
            context, TagHelperOutput output)
        {

        }
    }
}
