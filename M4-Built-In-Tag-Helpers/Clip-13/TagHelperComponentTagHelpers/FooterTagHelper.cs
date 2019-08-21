



using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace WebAppTHC.TagHelperComponentTagHelpers
{
    [HtmlTargetElement("footer")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class FooterTagHelper : TagHelperComponentTagHelper
    {
        public FooterTagHelper(ITagHelperComponentManager manager, 
            ILoggerFactory loggerFactory)
            : base(manager, loggerFactory)
        {
        }
    }
}