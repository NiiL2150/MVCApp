using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApp.Models;
using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITesting _test;

        public HomeController(ILogger<HomeController> logger, ITesting test)
        {
            _logger = logger;
            _test = test;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //ViewData["name"] = "NiiL";

            ViewBag.Name = "NiiL";

            return View(new TestViewModel() { ToDoList = _test.ToDoList });
        }

        [HttpPost]
        public IActionResult Index(TestViewModel model)
        {
            ViewBag.Name = "NiiL";
            _test.ToDoList.Add(model.ToDoList[model.ToDoList.Count-1]);
            model.ToDoList = _test.ToDoList;

            return View(model);
        }

        public IActionResult Privacy()
        {
            //return RedirectToAction("Results", "Home", new { count = 700 });
            return View();
        }

        /*
        public IActionResult Results(int count = 999)
        {
            Visit visit = new Visit() { Visits = count };
            return Ok(visit);
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
