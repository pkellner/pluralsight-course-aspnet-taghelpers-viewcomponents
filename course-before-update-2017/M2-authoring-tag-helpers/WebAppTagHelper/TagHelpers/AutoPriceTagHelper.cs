using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    //[HtmlTargetElement(Attributes = "[model^='t']")]
    //[HtmlTargetElement(Attributes = "[make ^= 'f'],[model $= 'er']")]
    public class AutoPriceTagHelper : TagHelper
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public override void Process(
            TagHelperContext context,
            TagHelperOutput output)
        {
            //context.
        }
    }
}



//[HtmlTargetElement("*")]
//[HtmlTargetElement("auto-price", Attributes = "model")] // works, must have model
//[HtmlTargetElement("auto-price",Attributes ="make")] // works, must have make
//[HtmlTargetElement("auto-price", Attributes = "make,model")] // works, must have make and model
//[HtmlTargetElement("auto-price", Attributes = "[make ^='p']")] // works, make starts with p
//[HtmlTargetElement("auto-price", Attributes = "[model $='er']")] // works, make starts with p
//[HtmlTargetElement("auto-price", Attributes = "[make ^='p'],[model$='er']")]
//[HtmlTargetElement("auto-price", Attributes = "[model ^= 't']")] 
//[HtmlTargetElement("auto-price",ParentTag = "li")] // fails, shows all
//[HtmlTargetElement(TagStructure = TagStructure.Unspecified)]
//[HtmlTargetElement(TagStructure = TagStructure.NormalOrSelfClosing)]
//[HtmlTargetElement(TagStructure = TagStructure.WithoutEndTag)]





// output.TagName = "div";
//var tagHelperAttribute = 
//    output.Attributes.Where(a => a.Name == "class" 
//    && (a.Value).ToString() == "highlight").
//    FirstOrDefault();
//output.Attributes.Remove(tagHelperAttribute);

//output.Attributes.Clear();
        
//public override void Process(TagHelperContext context, TagHelperOutput output)
//{
//    //<my-test>&lt;div&gt;Content&lt;/div&gt;</my-test>
//    output.Content.SetContent("<div>Content</div>");


//    // <div>PreElement</div><my-test><div>PreContent</div><div>Content</div><div>PostContent</div></my-test><div>PostElement</div>
//    //output.PreElement.SetHtmlContent("<div>PreElement</div>");
//    //output.PreContent.SetHtmlContent("<div>PreContent</div>");
//    //output.Content.SetHtmlContent("<div>Content</div>");
//    //output.PostContent.SetHtmlContent("<div>PostContent</div>");
//    //output.PostElement.SetHtmlContent("<div>PostElement</div>");
//}

// output.Content.SetContent("<div>MyContent</div>");
// output.Content.SetHtmlContent("<div>MyContent</div>");





//[HtmlTargetElement("auto-price", Attributes = "[make ='ford'],[model='laser']")] // fails, shows all