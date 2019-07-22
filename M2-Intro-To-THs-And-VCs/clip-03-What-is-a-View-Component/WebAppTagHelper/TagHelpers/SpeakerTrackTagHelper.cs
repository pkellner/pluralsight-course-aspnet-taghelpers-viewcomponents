using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("speaker-track")]
    public class SpeakerTrackTagHelper : TagHelper
    {
        public string trackName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string preContent = $@"
                <h2>{trackName}</h2>
                <div class='row'>
            ";
            const string postContent = @"
                </div>
            ";
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "track");
            output.PreContent.SetHtmlContent(preContent);
            output.PostContent.SetHtmlContent(postContent);
        }
    }
}