using CareerPortal.Core.Utilities.Results;
using CareerPortal.Core.Utilities.Security.Jwt;
using CareerPortal.MvcWebUI.Areas.HomePage.Data;
using CareerPortal.MvcWebUI.Areas.HomePage.Models;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Newtonsoft.Json;

namespace CareerPortal.MvcWebUI.Helper.Api.Concrete
{
    public class AuthApiService : IAuthApiService
    {
        private IWebApiServices _webApiServices;
        private string jsonData = "";

        public AuthApiService(IWebApiServices webApiServices)
        {
            _webApiServices = webApiServices;
        }

        public RegisterResponse JobSeekerLogin(JobSeekerLoginModel JobSeekerSignUpModel)
        {
            jsonData = _webApiServices.Post<JobSeekerLoginModel>(ApiUrls.JobSeekerLogin, JobSeekerSignUpModel).Result;
            return JsonConvert.DeserializeObject<RegisterResponse>(jsonData);
        }

        public LoginResponse JobSeekerSignUp(JobSeekerSignUpModel JobSeekerSignUpModel)
        {
            jsonData = _webApiServices.Post<JobSeekerSignUpModel>(ApiUrls.JobSeekerRegister, JobSeekerSignUpModel).Result;
            return JsonConvert.DeserializeObject<LoginResponse>(jsonData);
        }
    }
}
