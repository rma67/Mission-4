using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoviesContext AnyName)
        {
            _logger = logger;
            _blahContext = AnyName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult addMovie ()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult addMovie (AddResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();

            return View("Confirmation", ar);
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
