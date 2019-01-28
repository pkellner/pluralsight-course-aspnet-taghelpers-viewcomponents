using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("my-customer")]
    public class MyCustomerTagHelper : TagHelper
    {

        public string Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            var data = _nameList.FirstOrDefault(a => a.Name == Info);
            var result = String.Format("Name: {0} Address: {1}", data.Name, data.Address);
            output.Content.SetContent(result);

            output.TagName = "i";

        }

        private class NameRecord
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }

        private readonly List<NameRecord> _nameList = new List<NameRecord>()
        {
            new NameRecord {Name="Naomi",Address = "1600 Amphitheatre"},
            new NameRecord {Name="Igor",Address = "123 Somewhere"},
        };
    }
    

   
}
