using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
     [HtmlTargetElement("view-ctx")]
    public class ViewCtxTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string MiscString { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //var isHttps = ViewContext.HttpContext.Request.IsHttps;
            //var isFormValid = ViewContext.ModelState.IsValid;
            MiscString = ViewContext.ExecutingFilePath;
            output.Content.SetContent("MiscString: " + MiscString);
        }
    }
}
