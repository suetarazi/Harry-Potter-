using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotter.Models;
using HarryPotter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HarryPotter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISortingHat _sortingHat;

        public IndexModel(ISortingHat sortingHat)
        {
            _sortingHat = sortingHat;
        }

        public void OnGet()
        {

        }

    }
}
