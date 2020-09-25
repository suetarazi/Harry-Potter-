using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotter.Models;
using HarryPotter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HarryPotter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISortingHat _sortingHat;

        public HomeController(ISortingHat sortingHat)
        {
            _sortingHat = sortingHat;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        
    }
}
