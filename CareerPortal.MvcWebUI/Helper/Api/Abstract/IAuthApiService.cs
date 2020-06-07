using CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete;
using CareerPortal.MvcWebUI.Areas.HomePage.Models;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface IAuthApiService
    {
        RegisterResponse JobSeekerSignUp(JobSeekerSignUpModel jobSeekerSignUpModel);
        LoginResponse JobSeekerLogin(JobSeekerLoginModel jobSeekerLoginModel);
        RegisterResponse JobGiverSignUp(JobGiverSignUpModel jobSeekerSignUpModel);
        LoginResponse JobGiverLogin(JobGiverLoginModel jobSeekerLoginModel);
    }
}
