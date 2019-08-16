
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("mod-exp")]
    public class ModExpTagHelper : TagHelper
    {
        public ModelExpression HelperFor { get; set; }

        public override void Process(TagHelperContext context, 
            TagHelperOutput output)
        {
            var str = HelperFor == null ? "" :
                " Name: " + HelperFor.Name +
                " Model: " + HelperFor.Model;
            output.Content.SetContent(str);
        }
    }
}
