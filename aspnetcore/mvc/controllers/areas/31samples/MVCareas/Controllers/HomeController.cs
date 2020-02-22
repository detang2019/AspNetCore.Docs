﻿using Microsoft.AspNetCore.Mvc;
using MVCareas.Models;
using System.Diagnostics;

namespace MVCareas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy() =>
            ControllerContext.ToActionResult();

        public IActionResult About() =>
            ControllerContext.ToActionResult();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
