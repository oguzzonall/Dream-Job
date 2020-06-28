using CareerPortal.Business.Abstract;
using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.Core.Utilities.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;
using System.IO;

namespace CareerPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobGiverJobsController : ControllerBase
    {
        private readonly IJobPostService _jobPostService;
        private IHostingEnvironment _env;

        public JobGiverJobsController(IJobPostService jobPostService, IHostingEnvironment env)
        {
            _jobPostService = jobPostService;
            _env = env;
        }

        [HttpPost("addjobpost")]
        public ActionResult AddJobPost(PostAJobViewModelDto postAJobViewModelDto)
        {
            #region base64string save iamge

            //if (!string.IsNullOrEmpty(postAJobViewModelDto.JobPostImageBase64))
            //{
            //    try
            //    {

            //        string baslik = Guid.NewGuid().ToString() + ".jpg";

            //        postAJobViewModelDto.JobPostImageUrl = "/jobimages/" + baslik + ".jpg";

            //        byte[] imageBytes = Convert.FromBase64String(postAJobViewModelDto.JobPostImageBase64);
            //        MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            //        // Convert byte[] to Image
            //        ms.Write(imageBytes, 0, imageBytes.Length);
            //        Image image = Image.FromStream(ms, true);
            //        var savePath = Path.Combine(_env.WebRootPath, "jobimages", baslik);

            //        System.IO.File.WriteAllBytes(savePath, imageBytes);

            //        //image.Save(savePath, ImageFormat.Jpeg);
            //    }
            //    catch (Exception ex)
            //    {
            //        //Log todo:ex
            //        return Ok(new ErrorDataResult<PostAJobViewModelResponseDto>());
            //    }
            //}

            //if (!string.IsNullOrEmpty(postAJobViewModelDto.ComponyLogoBase64))
            //{
            //    try
            //    {

            //        string baslik = Guid.NewGuid().ToString() + ".jpg";

            //        postAJobViewModelDto.JobPostImageUrl = "/companylogos/" + baslik + ".jpg";

            //        byte[] imageBytes = Convert.FromBase64String(postAJobViewModelDto.ComponyLogoBase64);
            //        MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            //        // Convert byte[] to Image
            //        ms.Write(imageBytes, 0, imageBytes.Length);
            //        Image image = Image.FromStream(ms, true);
            //        var savePath = Path.Combine(_env.WebRootPath, "companylogos", baslik);

            //        System.IO.File.WriteAllBytes(savePath, imageBytes);

            //        //image.Save(savePath, ImageFormat.Jpeg);
            //    }
            //    catch (Exception ex)
            //    {
            //        //Log todo:ex
            //        return Ok(new ErrorDataResult<PostAJobViewModelResponseDto>());
            //    }
            //}
            #endregion
            var data = _jobPostService.AddJobPost(postAJobViewModelDto);
            if (data.Success)
            {
                return Ok(data);
            }
            else
            {
                return Ok(new ErrorDataResult<PostAJobViewModelResponseDto>());
            }
        }
    }
}