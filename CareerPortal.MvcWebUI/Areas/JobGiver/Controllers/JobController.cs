using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Controllers
{
    [Area("JobGiver")]
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PostAJob()
        {
            return View();
        }
    }
}