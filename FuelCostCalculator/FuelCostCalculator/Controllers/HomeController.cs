using FuelCostCalculator.Models;                 // Importing the necessary model
using Microsoft.AspNetCore.Mvc;                  // Importing the Microsoft.AspNetCore.Mvc namespace
using Microsoft.Extensions.Logging;             // Importing the Microsoft.Extensions.Logging namespace
using System;                                    // Importing the System namespace
using System.Diagnostics;                        // Importing the System.Diagnostics namespace
using System.Linq;                               // Importing the System.Linq namespace
using System.Threading.Tasks;                    // Importing the System.Threading.Tasks namespace

namespace FuelCostCalculator.Controllers          // Defining the namespace for the controller
{
    // Defining the HomeController class inheriting from Controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;  // Declaring a private readonly ILogger instance

        // Constructor to initialize ILogger instance
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;  // Initializing ILogger instance
        }

        // Index action method to handle the default route
        public IActionResult Index()
        {
            return View();  // Returning the Index view
        }

        // Privacy action method to handle privacy-related requests
        public IActionResult Privacy()
        {
            return View();  // Returning the Privacy view
        }

        // Error action method to handle errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Returning the Error view with a new instance of ErrorViewModel
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
