using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Controllers
{
    [Area("JobGiver")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}