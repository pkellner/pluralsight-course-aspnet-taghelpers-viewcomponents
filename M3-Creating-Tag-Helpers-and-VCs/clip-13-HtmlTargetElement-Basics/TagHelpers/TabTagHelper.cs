using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{  
    [RestrictChildren("tab-item")]
    [HtmlTargetElement("tab")]
    public class TabTagHelper : TagHelper
    {
        [HtmlAttributeName("active-page")]
        public string ActivePage { get; set; }

        public override void Process(TagHelperContext context, 
            TagHelperOutput output)
        {
            context.Items["ActivePage"] = ActivePage;

            output.TagName = "div";
            output.PreContent.SetHtmlContent
                (@"<h3>Silicon Valley Code Camp</h3>
                   <nav class='navbar navbar-expand-sm bg-light navbar-light'>
                     <ul class='nav nav-pills'>");
            output.PostContent.SetHtmlContent("</ul></nav>");
            output.Attributes.Add("class", "container");
        }
    }
}
