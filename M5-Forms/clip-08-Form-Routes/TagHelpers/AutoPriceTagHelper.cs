 using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement(Attributes = "[model ^= 't']")]
    [HtmlTargetElement(Attributes = "[make ^= 'f'],[model $= 'er']")]
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
