using CareerPortal.MvcWebUI.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Controllers
{
    [Area("JobGiver")]
    [Authorize(Roles = OperationClaimNames.Is_Veren)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}