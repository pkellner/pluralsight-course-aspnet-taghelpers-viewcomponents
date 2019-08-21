using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace WebAppTagHelper.TagHelpers
{   
    [HtmlTargetElement("my-test")]
    public class MyTestTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var tagHelperAttribute =
                output.Attributes.Where(a => a.Name == "class"
                && (a.Value).ToString() == "highlight").
                FirstOrDefault();

            //output.Attributes.Remove(tagHelperAttribute);
            //output.Attributes.Clear();

            //<my-test>&lt;div&gt;Content&lt;/div&gt;</my-test>
            output.Content.SetContent("<div>Content</div>");

            // <div>PreElement</div><my-test><div>PreContent</div><div>Content</div><div>PostContent</div></my-test><div>PostElement</div>
            output.PreElement.SetHtmlContent("<div>PreElement</div>");
            output.PreContent.SetHtmlContent("<div>PreContent</div>");
            output.Content.SetHtmlContent("<div>Content</div>");
            output.PostContent.SetHtmlContent("<div>PostContent</div>");
            output.PostElement.SetHtmlContent("<div>PostElement</div>");


        }


        //private static HttpClient _httpClient = new HttpClient();
        //string requestUrl = 
        //    "http://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=b1b15e88fa797225412429c1c50c122a1";

        //public override async Task ProcessAsync(
        //    TagHelperContext context, TagHelperOutput output)
        //{
        //    var threadIdBefore = Thread.CurrentThread.ManagedThreadId;
        //    var uri = new Uri(requestUrl);
        //    using (var response = await _httpClient.GetAsync(uri))
        //    {
        //        response.EnsureSuccessStatusCode();
        //        var result = await response.Content.ReadAsStringAsync();
        //        var threadIdAfter = Thread.CurrentThread.ManagedThreadId;
        //        JObject json = JObject.Parse(result);
        //        if (json != null)
        //        {
        //            output.Content.SetHtmlContent(
        //            string.Format("<b>Thread ID Before: {0}<br/>Thread ID After: {1}</b>",
        //            threadIdBefore, threadIdAfter));

        //            //output.Content.SetHtmlContent(json.ToString().
        //            //    Replace(Environment.NewLine, "<br/>").
        //            //    Replace(" ", "&nbsp;"));
        //        }
        //    }
        //}


        //public override void Process(
        //    TagHelperContext context, TagHelperOutput output)
        //{
        //    var uri = new Uri(requestUrl);
        //    var result = _httpClient.GetStringAsync(uri).Result;
        //    JObject json = JObject.Parse(result);
        //    if (json != null)
        //    {
        //        output.Content.SetHtmlContent(json.ToString().
        //            Replace(Environment.NewLine, "<br/>").
        //            Replace(" ", "&nbsp;"));
        //    }
        //}
    }
}
 