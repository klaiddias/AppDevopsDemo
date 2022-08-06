using DevopsCalcWebApp.Helper;
using DevopsCalcWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevopsCalcWebApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {

            Calc calc = new();
            model.Total = calc.Sum(model.Value1, model.Value2);
            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}