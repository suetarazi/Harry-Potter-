using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotter.Models;
using HarryPotter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HarryPotter.Pages.Results
{
    public class ResultsModel : PageModel
    {
        private readonly ISortingHat _sortingHat;

        public ResultsModel(ISortingHat sortingHat)
        {
            _sortingHat = sortingHat;
        }

        [BindProperty]
        public SortingHat sorting { get; set; }        
        public void OnGet()
        {
        }

        public void OnPost()
        {
            async Task<IActionResult> Index()
            {
                SortingHat sorting = await _sortingHat.SortingHatOutcome();
                return Page();

            }
        }

    }
}
