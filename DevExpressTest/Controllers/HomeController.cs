﻿using DevExpressTest.Models;
using DevExpressTest.Reports;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevExpressTest.Controllers
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

        public IActionResult GetAdvertismentsReport()
        {
            AdvertisementReport advertisementReport = new AdvertisementReport();
            return View(advertisementReport);
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