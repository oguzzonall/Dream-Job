using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CareerPortal.MvcWebUI.Models;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;

namespace CareerPortal.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICountryApiService _countryApiService;

        public HomeController(ILogger<HomeController> logger, ICountryApiService countryApiService)
        {
            _logger = logger;
            _countryApiService = countryApiService;
        }

        public IActionResult Index()
        {
            var response = _countryApiService.GetAllCountries();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
