using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("body")]
    public class BodyTagHelper : TagHelper
    {
        private readonly IScriptManager _scriptManager;
      
        public BodyTagHelper(IScriptManager scriptManager)
        {
            _scriptManager = scriptManager;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (await output.GetChildContentAsync()).GetContent();

            var sb = new StringBuilder();
            if (_scriptManager.Scripts.Count > 0)
            {
                foreach (var scriptRef in _scriptManager.Scripts.OrderBy(a => a.IncludeOrderPriorty))
                    sb.AppendLine(string.Format("<script src='{0}' ></script>", scriptRef.ScriptPath));
                sb.AppendLine("<script type='text/javascript'>");
                foreach (var scriptText in _scriptManager.ScriptTexts)
                    sb.AppendLine(scriptText);
                sb.AppendLine("</script>");
            }
            output.PostContent.AppendHtml(sb.ToString());
        }
    }
}