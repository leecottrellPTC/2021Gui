using LoggingLecture.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingLecture.Controllers
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
            //track visits from a remote IP
            String ClientIPAddr = HttpContext.Connection.RemoteIpAddress.ToString();
            _logger.Log(LogLevel.Information, "Index page visited from {ClientIP}", ClientIPAddr);

            int a = 5, b = 0;
            try
            {
                int answer = a / b;
            }
            catch(Exception ex)
            {
                _logger.LogError((EventId)1500, ex, "Division by zero in Home Index controller");
            }
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
