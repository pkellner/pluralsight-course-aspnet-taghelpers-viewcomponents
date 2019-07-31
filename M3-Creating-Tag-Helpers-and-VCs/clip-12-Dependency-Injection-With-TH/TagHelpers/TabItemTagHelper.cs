using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("tab-item")]
    public class TabItemTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override void Process(TagHelperContext context, 
            TagHelperOutput output)
        {
            string activePage = context.Items["ActivePage"] as string;
              
            output.TagName = "li";

            var activeLabel = activePage == Title ? "active" : "";
            var str = string.Format(@"
                  <a class='nav-link {0}' data-toggle='pill' href='#'>{1}</a>
            ", activeLabel, Title);
            output.Content.SetHtmlContent(str);
        }
    }
}
