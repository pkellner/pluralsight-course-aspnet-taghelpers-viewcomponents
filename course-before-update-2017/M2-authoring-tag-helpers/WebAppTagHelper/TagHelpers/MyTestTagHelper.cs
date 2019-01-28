using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Net;

namespace WebAppTagHelper.TagHelpers
{
    public class MyTestTagHelper : TagHelper
    {
        //private static HttpClient _httpClient = new HttpClient();

        //string requestUrl = "http://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=b1b15e88fa797225412429c1c50c122a1";

        //public override void Process(
        //    TagHelperContext context, TagHelperOutput output)
        //{
        //    var uri = new Uri(requestUrl);


        //    var result = _httpClient.GetStringAsync(uri).Result;
        //    JObject json = JObject.Parse(result);
        //    if (result != null)
        //    {
        //        output.Attributes.Add("class", "highlight");
        //    }
        //}
















        public override void Process(
            TagHelperContext context, TagHelperOutput output)
        {
            output.SuppressOutput();
        }

        //output.TagMode = TagMode.StartTagAndEndTag;
        //    output.TagMode = TagMode.SelfClosing;
        //    output.TagMode = TagMode.StartTagOnly;

        //output.Attributes.Add("class", "highlight");
        //output.Content.SetContent("<div>MyContent</div>");

        //HttpClient _httpClient = new HttpClient();

        //string requestUrl = "http://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=b1b15e88fa797225412429c1c50c122a1";


        //var threadIdBefore = Thread.CurrentThread.ManagedThreadId;
        //var uri = new Uri(requestUrl);
        //using (var response = await _httpClient.GetAsync(uri))
        //{
        //    response.EnsureSuccessStatusCode();
        //    var result = await response.Content.ReadAsStringAsync();
        //    JObject json = JObject.Parse(result);
        //    if (result != null)
        //    {
        //        output.Attributes.Add("class", "highlight");
        //        var threadIdAfter = Thread.CurrentThread.ManagedThreadId;
        //        output.Content.SetHtmlContent(
        //            string.Format("<b>Thread ID Before: {0}<br/>Thread ID After: {1}</b>",
        //            threadIdBefore, threadIdAfter));
        //    }
        //}
    }

}









//"{\"coord\":{\"lon\":139.01,\"lat\":35.02},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"base\":\"stations\",\"main\":{\"temp\":285.514,\"pressure\":1013.75,\"humidity\":100,\"temp_min\":285.514,\"temp_max\":285.514,\"sea_level\":1023.22,\"grnd_level\":1013.75},\"wind\":{\"speed\":5.52,\"deg\":311},\"clouds\":{\"all\":0},\"dt\":1485792967,\"sys\":{\"message\":0.0025,\"country\":\"JP\",\"sunrise\":1485726240,\"sunset\":1485763863},\"id\":1907296,\"name\":\"Tawarano\",\"cod\":200}"


















//output.TagName = "div";
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
