using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Controllers
{
    [Area("HomePage")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult JobSeekerLogin()
        {
            return View();
        }

        public IActionResult JobGiverLogin()
        {
            return View();
        }
    }
}