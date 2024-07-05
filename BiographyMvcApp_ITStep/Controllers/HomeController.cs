using BiographyMvcApp_ITStep.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BiographyMvcApp_ITStep.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Paintings()
        {
            return View();
        }

        public IActionResult Discoveries()
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
