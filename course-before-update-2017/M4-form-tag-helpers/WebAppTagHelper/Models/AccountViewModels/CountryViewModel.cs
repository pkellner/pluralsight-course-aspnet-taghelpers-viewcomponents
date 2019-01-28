using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppTagHelper.Models.AccountViewModels
{
    public class CountryViewModel
    {
        //public List<string> CountryCodes { get; set; }
        //public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "MX", Text = "Mexico" },
        //    new SelectListItem { Value = "CA", Text = "Canada" },
        //    new SelectListItem { Value = "US", Text = "USA" },
        //    new SelectListItem { Value = "FR", Text = "France" },
        //    new SelectListItem { Value = "ES", Text = "Spain" },
        //    new SelectListItem { Value = "DE", Text = "Germany"}
        //};

        public List<SelectListItem> Countries()
        {
            return new List<SelectListItem>
                {
                    new SelectListItem { Value = "MX", Text = "Mexico" },
                    new SelectListItem { Value = "CA", Text = "Canada" },
                    new SelectListItem { Value = "US", Text = "USA" },
                    new SelectListItem { Value = "FR", Text = "France" },
                    new SelectListItem { Value = "ES", Text = "Spain" },
                    new SelectListItem { Value = "DE", Text = "Germany"}
                };
        }
    }
}


    

