using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HarryPotter.Pages
{
    public class IndexModel : PageModel
    {
        public string House { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            House = Request.Form[nameof(House)];
        }
    }
}
