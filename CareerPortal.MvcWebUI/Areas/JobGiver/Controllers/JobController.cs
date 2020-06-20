using CareerPortal.MvcWebUI.Areas.JobGiver.Models;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Controllers
{
    [Area("JobGiver")]
    [Authorize(Roles = OperationClaimNames.Is_Veren)]
    public class JobController : Controller
    {
        private IHomeApiService _homeApiService;

        public JobController(IHomeApiService homeApiService)
        {
            _homeApiService = homeApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PostAJob()
        {
            PostAJobViewModel model = new PostAJobViewModel();
            model.JobFilterComponents = _homeApiService.GetHomeFilterComponents().Data;
            model.GetSectorExperienceYearGenderDtos = _homeApiService.GetSectorExperienceYearGender().Data;
            return View(model);
        }

        [HttpPost]
        public IActionResult PostAJob(PostAJobViewModel model)
        {
            model.JobDescription = HttpUtility.HtmlEncode(model.JobDescription);
            model.CompanyDescription = HttpUtility.HtmlEncode(model.CompanyDescription);
            return View("Index");
        }
    }
}