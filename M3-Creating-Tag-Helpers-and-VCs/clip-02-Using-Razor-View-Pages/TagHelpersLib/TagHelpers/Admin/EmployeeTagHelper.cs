using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersLib.TagHelpers
{
    [HtmlTargetElement("employee", Attributes = "name,title",ParentTag = "company")]
    public class EmployeeTagHelper : TagHelper
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            string content = @"
                <div class='panel panel-default' style='margin-top: 10px;'>
                    <img src='images/{0}.png' 
                      style='float:left;margin-right: 10px;' >
                    <p class='list-item'>{0}<br><i>{1}</i></p>
                </div>
                 ";

            output.Content.SetHtmlContent
                (string.Format(content, Name.Replace(" ", "-"), Title));

            //var companyName = context.Items["CompanyName"] as string;
        }
    }
}