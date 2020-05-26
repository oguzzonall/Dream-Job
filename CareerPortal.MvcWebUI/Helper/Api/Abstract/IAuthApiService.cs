using CareerPortal.Core.Utilities.Results;
using CareerPortal.Core.Utilities.Security.Jwt;
using CareerPortal.MvcWebUI.Areas.HomePage.Data;
using CareerPortal.MvcWebUI.Areas.HomePage.Models;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface IAuthApiService
    {
        LoginResponse JobSeekerSignUp(JobSeekerSignUpModel jobSeekerSignUpModel);
        RegisterResponse JobSeekerLogin(JobSeekerLoginModel jobSeekerLoginModel);

    }
}
