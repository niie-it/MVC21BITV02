using Demo21BITV02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo21BITV02.Controllers
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

        public string ActionTest()
        {
            return "Hello World";
        }

        public string Hello(string name = "Tèo")
        {
            return $"Hello {name}";
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
