using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarryPotter.Models;
using HarryPotter.Models.Interfaces;

namespace HarryPotter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISpells _spells;

        public List<Spells> Spells { get; set; }

        public HomeController(ILogger<HomeController> logger, ISpells spells)
        {
            _logger = logger;
            _spells = spells;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public async Task<List<IActionResult>> Index()
        {
            Spells = await _spells.GetAllSpells();
            return View(Spells); ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
