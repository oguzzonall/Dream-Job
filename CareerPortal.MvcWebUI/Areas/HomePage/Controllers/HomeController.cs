using CareerPortal.MvcWebUI.Areas.HomePage.Models;
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

        public IActionResult JobSeekerLoginSignUp()
        {
            JobSeekerLoginSignUpViewModel model = new JobSeekerLoginSignUpViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult JobSeekerLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult JobSeekerSignUp(JobSeekerLoginSignUpViewModel model)
        {
            return View();
        }

        public IActionResult JobGiverLoginSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult JobGiverLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult JobGiverSignUp()
        {
            return View();
        }
    }
}