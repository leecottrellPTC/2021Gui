using ComputerStoreLecture.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStoreLecture.Controllers
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


        public IActionResult TheAds()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Order(OrderItem theOrder)
        {
            if (ModelState.IsValid)
            {
                //write to the database, check inventory...
                return View("Thanks", theOrder);
            }
            else
            {
                return View(theOrder);
            }
        }

       

        public IActionResult Desktops()
        {
            Desktop gaming = new("Gaming Rig", 1500, 16);
            Desktop office = new("Office rig", 800, 8);
            Desktop home = new("Home Rig", 500, 8);

            return View(new Desktop[] { gaming, office, home });
        }

        public IActionResult Laptops()
        {
            Laptop[] list = {new("Surface Pro", (Decimal) 1700.50, 8, 19, 6),
                new("iPad", 1000, 8, 8, 2),
                new("Dell Latitude", 1100, 16, 15, 8)
            };
            return View(list);
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
