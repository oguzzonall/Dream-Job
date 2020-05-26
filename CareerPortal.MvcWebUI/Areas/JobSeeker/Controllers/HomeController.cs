using CareerPortal.MvcWebUI.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.JobSeeker.Controllers
{
    [Area("JobSeeker")]
    [Authorize(Roles = OperationClaimNames.Is_Arayan)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}