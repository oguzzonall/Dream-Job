using CareerPortal.MvcWebUI.Areas.HomePage.Models;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Alert.AlertifyJs;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using CareerPortal.MvcWebUI.Helper.Session.Abstract;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Controllers
{
    [Area("HomePage")]
    public class HomeController : Controller
    {
        private IAuthApiService _authApiService;
        private IHomeApiService _homeApiService;
        private ITokenSessionHelper _tokenSessionHelper;

        public HomeController(IAuthApiService authApiService, IHomeApiService homeApiService, ITokenSessionHelper tokenSessionHelper)
        {
            _authApiService = authApiService;
            _homeApiService = homeApiService;
            _tokenSessionHelper = tokenSessionHelper;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            var responsefilter = _homeApiService.GetHomeFilterComponents();
            if (responsefilter.Success)
                model.JobFilterComponents = responsefilter.Data;

            var responsejobposts = _homeApiService.GetJobPosts();
            if (responsejobposts.Success)
                model.GetJobPosts.Data = responsejobposts.Data;
            return View(model);
        }

        public IActionResult JobSeekerLoginSignUp()
        {
            JobSeekerLoginSignUpViewModel model = new JobSeekerLoginSignUpViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult JobSeekerLogin(JobSeekerLoginSignUpViewModel model)
        {
            var response = _authApiService.JobSeekerLogin(model.JobSeekerLoginModel);
            if (!response.Success)
            {
                HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(response.Message));
                return RedirectToAction("JobSeekerLoginSignUp");
            }
            var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.JobSeekerLoginModel.Email),
                    new Claim(ClaimTypes.Role, OperationClaimNames.Is_Arayan)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            _tokenSessionHelper.SetToken(response.Data);
            HttpContext.Session.SetString("Alert", AlertifyHelper.SuccessMessage(Messages.SuccessLogin));

            //todo: Alertify
            return RedirectToAction("Index", "Home", new { area = "JobSeeker" });
        }

        [HttpPost]
        public IActionResult JobSeekerSignUp(JobSeekerLoginSignUpViewModel model)
        {
            var response = _authApiService.JobSeekerSignUp(model.JobSeekerSignUpModel);
            if (!response.Success)
            {
                HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(response.Message));
                return RedirectToAction("JobSeekerLoginSignUp");
            }
            var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.JobSeekerSignUpModel.Email),
                    new Claim(ClaimTypes.Role, OperationClaimNames.Is_Arayan)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            _tokenSessionHelper.SetToken(response.Data);
            HttpContext.Session.SetString("Alert", AlertifyHelper.SuccessMessage(Messages.SuccessRegister));
            //todo: Alertify
            return RedirectToAction("Index", "Home", new { area = "JobSeeker" });
        }

        [HttpGet]
        public IActionResult JobGiverLoginSignUp()
        {
            JobGiverLoginSignUpViewModel model = new JobGiverLoginSignUpViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult JobGiverLogin(JobGiverLoginSignUpViewModel model)
        {
            var response = _authApiService.JobGiverLogin(model.JobGiverLoginModel);
            if (!response.Success)
            {
                HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(response.Message));
                return RedirectToAction("JobSeekerLoginSignUp");
            }
            var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.JobGiverLoginModel.Email),
                    new Claim(ClaimTypes.Role, OperationClaimNames.Is_Veren)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            _tokenSessionHelper.SetToken(response.Data);
            HttpContext.Session.SetString("Alert", AlertifyHelper.SuccessMessage(Messages.SuccessLogin));
            return RedirectToAction("Index", "Home", new { area = "JobGiver" });
        }

        [HttpPost]
        public IActionResult JobGiverSignUp(JobGiverLoginSignUpViewModel model)
        {
            var response = _authApiService.JobGiverSignUp(model.JobGiverSignUpModel);
            if (!response.Success)
            {
                HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(response.Message));
                return RedirectToAction("JobGiverLoginSignUp");
            }
            var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.JobGiverSignUpModel.Email),
                    new Claim(ClaimTypes.Role, OperationClaimNames.Is_Veren)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            _tokenSessionHelper.SetToken(response.Data);
            HttpContext.Session.SetString("Alert", AlertifyHelper.SuccessMessage(Messages.SuccessRegister));
            return RedirectToAction("Index", "Home", new { area = "JobGiver" });
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

        public IActionResult LogOut()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}