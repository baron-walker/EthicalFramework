using EthicalFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EthicalFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ResultsDeon()
        {
            return View();
        }

        public IActionResult ResultsUtil()
        {
            return View();
        }

        public IActionResult ResultsCare()
        {
            return View();
        }
        public IActionResult ResultsVirt()
        {
            return View();
        }
        public IActionResult ResultsSoci()
        {
            return View();
        }

        public IActionResult ResultsNo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(Quiz quiz)
        { 
            if (quiz.question2==quiz.question3)
            {
                switch (quiz.question2)
                {
                    case "A":
                        return View("ResultsDeon");
                    case "B":
                        return View("ResultsUtil");
                    case "C":
                        return View("ResultsVirt");
                    case "D":
                        return View("ResultsSoci");
                    case "E":
                        return View("ResultsCare");
                }
            }
            else
            {
                return View("ResultsNo");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
