using CareerPortal.MvcWebUI.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.JobSeeker.Controllers
{
    [Authorize(Roles = OperationClaimNames.Is_Arayan)]
    [Area("JobSeeker")]
    public class SeekerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}