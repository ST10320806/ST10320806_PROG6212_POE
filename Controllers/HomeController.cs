using Microsoft.AspNetCore.Mvc;
using ST10320806_POE.Models;
using System.Diagnostics;

namespace ST10320806_POE.Controllers
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
        public IActionResult SubmitClaims()
        {
            return View();
        }
        public IActionResult VerifyClaims()
        {
            return View();
        }
        public IActionResult TrackClaims()
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
