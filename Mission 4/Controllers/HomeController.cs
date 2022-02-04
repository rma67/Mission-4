using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MoviesContext _blahContext { get; set; }

        public HomeController(MoviesContext AnyName)
        {
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
            ViewBag.Categories = _blahContext.Categories.ToList();

            return View();
        }
        
        [HttpPost]
        public IActionResult addMovie (AddResponse ar)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _blahContext.Categories.ToList();

                return View();
            }
        }
        
        [HttpGet]
        public IActionResult WaitList ()
        {
            var applications = _blahContext.Responses
                .Include(x => x.Category)
                //.Where(x => x.Year == 1999)
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categories = _blahContext.Categories.ToList();

            var application = _blahContext.Responses.Single(x => x.MovieID == applicationid);

            return View("addMovie", application);
        }

        [HttpPost]
        public IActionResult Edit (AddResponse ab)
        {
            _blahContext.Update(ab);
            _blahContext.SaveChanges();

            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete (int applicationid)
        {
            var application = _blahContext.Responses.Single(x => x.MovieID == applicationid);
            
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete (AddResponse ac)
        {
            _blahContext.Responses.Remove(ac);
            _blahContext.SaveChanges();

            return RedirectToAction("WaitList");
        }
    }
}
