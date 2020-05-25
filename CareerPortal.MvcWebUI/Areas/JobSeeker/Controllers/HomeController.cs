using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.JobSeeker.Controllers
{
    [Area("JobSeeker")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}