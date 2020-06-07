﻿using CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete;
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

        public LoginResponse JobSeekerLogin(JobSeekerLoginModel JobSeekerSignUpModel)
        {
            jsonData = _webApiServices.Post<JobSeekerLoginModel>(ApiUrls.JobSeekerLogin, JobSeekerSignUpModel).Result;
            return JsonConvert.DeserializeObject<LoginResponse>(jsonData);
        }

        public RegisterResponse JobSeekerSignUp(JobSeekerSignUpModel JobSeekerSignUpModel)
        {
            jsonData = _webApiServices.Post<JobSeekerSignUpModel>(ApiUrls.JobSeekerRegister, JobSeekerSignUpModel).Result;
            return JsonConvert.DeserializeObject<RegisterResponse>(jsonData);
        }

        public LoginResponse JobGiverLogin(JobGiverLoginModel jobGiverLoginModel)
        {
            jsonData = _webApiServices.Post<JobGiverLoginModel>(ApiUrls.JobGiverLogin, jobGiverLoginModel).Result;
            return JsonConvert.DeserializeObject<LoginResponse>(jsonData);
        }

        public RegisterResponse JobGiverSignUp(JobGiverSignUpModel jobGiverSignUpModel)
        {
            jsonData = _webApiServices.Post<JobGiverSignUpModel>(ApiUrls.JobGiverRegister, jobGiverSignUpModel).Result;
            return JsonConvert.DeserializeObject<RegisterResponse>(jsonData);

            //try
            //{
            //    jsonData = _webApiServices.Post<JobGiverSignUpModel>(ApiUrls.JobGiverRegister, jobGiverSignUpModel).Result;
            //    return JsonConvert.DeserializeObject<LoginResponse>(jsonData);
            //}
            //catch (System.Exception ex)
            //{
            //    //todo :Log ex
            //    return new LoginResponse { Success = false, Message = "İşleminiz Gerçekleştirilemedi" };
            //    throw;
            //}
        }
    }
}