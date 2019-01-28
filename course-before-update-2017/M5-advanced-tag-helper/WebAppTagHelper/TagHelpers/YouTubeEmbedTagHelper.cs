using System;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WebAppTagHelper;

namespace WebAppTagHelpler.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("YouTubeEmbed")]
    public class YouTubeEmbedTagHelper : TagHelper
    {
        private readonly IScriptManager _scriptManager;

        public YouTubeEmbedTagHelper(IScriptManager scriptManager)
        {
            _scriptManager = scriptManager;
        }

        public string YouTubeId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            _scriptManager.AddScript(new ScriptReference("https://code.jquery.com/jquery-1.10.2.min.js", 1000));
            _scriptManager.AddScript(new ScriptReference("/js/jquery.nonSuckyYouTubeEmbed.js", 1000));

        

            output.Attributes.Add(new TagHelperAttribute("youtubeid", YouTubeId));
            output.Attributes.Add(new TagHelperAttribute("class", "nsyte"));
   
            var scriptTextExecute = string.Format(@"
                 $(document).ready(function () {{
                        $('.nsyte').nonSuckyYouTubeEmbed();
                }});
            ");
            _scriptManager.AddScriptText(scriptTextExecute);
        }
    }
}