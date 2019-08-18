using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("script", Attributes = "src")]
    public class ScriptTagHelper : TagHelper
    {
        private readonly IScriptManager _scriptManager;
        public ScriptTagHelper(IScriptManager scriptManager)
        {
            _scriptManager = scriptManager;
        }
        public string IncludeOrderPriority { get; set; }
        public override async Task ProcessAsync(TagHelperContext context,
            TagHelperOutput output)
        {
            var src = output.Attributes["src"].Value.ToString();
            _scriptManager.AddScript(new ScriptReference
                (src, Convert.ToInt32(IncludeOrderPriority)));
            await output.GetChildContentAsync();
            output.SuppressOutput();
        }
    }
}
