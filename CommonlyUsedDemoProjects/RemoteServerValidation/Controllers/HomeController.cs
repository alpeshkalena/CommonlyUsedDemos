using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RemoteServerValidation.Models;

namespace RemoteServerValidation.Controllers
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
            return View(new RemoteValidation());
        }

        [HttpPost]
        public IActionResult Index(RemoteValidation data)
        {
            if(!ModelState.IsValid)
            {
                return View(data);
            }
            return View();
        }

        //Here if value are match then we have to return false instead of true
        //that is the noticed by Alpesh and tested
        [HttpPost]
        public IActionResult CheckDuplicateEmail(string Email)
       {
            var isEmailExist = Email == "xyz123@gmail.com" ? false : true;
            return Json(isEmailExist);
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
