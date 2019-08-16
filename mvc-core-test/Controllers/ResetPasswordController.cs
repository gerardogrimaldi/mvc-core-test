using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_core_test.Models;

namespace mvc_core_test.Controllers
{
    public class ResetPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/ResetPassword.cshtml");
        }

        [HttpPost]
        public IActionResult Index(string password, string password2)
        {
            ViewData["Message"] = "Se reseteo el password por " + password + ".";
            return View("~/Views/Home/ResetPassword.cshtml");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
