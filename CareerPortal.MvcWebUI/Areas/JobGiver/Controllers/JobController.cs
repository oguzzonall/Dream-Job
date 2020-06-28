using AutoMapper;
using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.MvcWebUI.Areas.JobGiver.Models;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Alert.AlertifyJs;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Web;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Controllers
{
    [Area("JobGiver")]
    [Authorize(Roles = OperationClaimNames.Is_Veren)]
    public class JobController : Controller
    {
        private IHomeApiService _homeApiService;
        private IJobGiverJobPostApiService _jobGiverJobPostApiService;
        private readonly IMapper _mapper;
        private IHostingEnvironment _env;

        public JobController(IHomeApiService homeApiService, IJobGiverJobPostApiService jobGiverJobPostApiService, IMapper mapper, IHostingEnvironment env)
        {
            _homeApiService = homeApiService;
            _jobGiverJobPostApiService = jobGiverJobPostApiService;
            _mapper = mapper;
            _env = env;
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
            try
            {
                if (model.JobPostImage != null && model.JobPostImage.Length > 0)
                {
                    #region base64string convert
                    //try
                    //{
                    //    using (var ms = new MemoryStream())
                    //    {
                    //        model.JobPostImage.CopyTo(ms);
                    //        var fileBytes = ms.ToArray();
                    //        model.JobPostImageBase64 = Convert.ToBase64String(fileBytes);
                    //        // act on the Base64 data
                    //    }
                    //}
                    //catch
                    //{
                    //    model.JobFilterComponents = _homeApiService.GetHomeFilterComponents().Data;
                    //    model.GetSectorExperienceYearGenderDtos = _homeApiService.GetSectorExperienceYearGender().Data;
                    //    HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(Messages.ErrorAddJobPost));
                    //    return View(model);
                    //}
                    #endregion
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "jobimages");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.JobPostImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.JobPostImage.CopyTo(fileStream);
                    }
                    model.JobPostImageUrl = "/jobimages/" + uniqueFileName;
                }

                if (model.ComponyLogo != null && model.ComponyLogo.Length > 0)
                {
                    #region base64string convert
                    //try
                    //{
                    //    using (var ms = new MemoryStream())
                    //    {
                    //        model.ComponyLogo.CopyTo(ms);
                    //        var fileBytes = ms.ToArray();
                    //        model.ComponyLogoBase64 = Convert.ToBase64String(fileBytes);
                    //        // act on the Base64 data
                    //    }
                    //}
                    //catch
                    //{
                    //    model.JobFilterComponents = _homeApiService.GetHomeFilterComponents().Data;
                    //    model.GetSectorExperienceYearGenderDtos = _homeApiService.GetSectorExperienceYearGender().Data;
                    //    HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(Messages.ErrorAddJobPost));
                    //    return View(model);
                    //}
                    #endregion
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "companyimages");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ComponyLogo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ComponyLogo.CopyTo(fileStream);
                    }
                    model.ComponyLogoUrl = "/companyimages/" + uniqueFileName;
                }
            }
            catch (Exception ex)
            {
                //todo: ex
                HttpContext.Session.SetString("Alert", AlertifyHelper.SuccessMessage(Messages.ErrorAddJobPost));
                model.JobFilterComponents = _homeApiService.GetHomeFilterComponents().Data;
                model.GetSectorExperienceYearGenderDtos = _homeApiService.GetSectorExperienceYearGender().Data;
                return View(model);
            }

            model.JobDescription = HttpUtility.HtmlEncode(model.JobDescription);
            model.CompanyDescription = HttpUtility.HtmlEncode(model.CompanyDescription);
            PostAJobViewModelDto dto = _mapper.Map<PostAJobViewModelDto>(model);
            var response = _jobGiverJobPostApiService.JobGiverAddJobPostResponse(dto);
            if (response.Success)
            {
                HttpContext.Session.SetString("Alert", AlertifyHelper.SuccessMessage(Messages.SuccessAddJobPost));
            }
            else
            {
                HttpContext.Session.SetString("Alert", AlertifyHelper.ErrorMessage(Messages.ErrorAddJobPost));
            }
            model.JobFilterComponents = _homeApiService.GetHomeFilterComponents().Data;
            model.GetSectorExperienceYearGenderDtos = _homeApiService.GetSectorExperienceYearGender().Data;
            return View(model);
        }
    }
}