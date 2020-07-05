﻿using CareerPortal.Business.Abstract;
using CareerPortal.Core.Constants.Enums;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class JobPostManager : IJobPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobPostManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<PostAJobViewModelResponseDto> AddJobPost(PostAJobViewModelDto dto)
        {
            try
            {
                Core.Entities.Concrete.JobPost jobPost = new Core.Entities.Concrete.JobPost
                {
                    CompanyName = dto.CompanyName,
                    ComponyLogoUrl = dto.ComponyLogoUrl,
                    JobPostImageUrl = dto.JobPostImageUrl,
                    ExperienceId = dto.ExperienceId,
                    GenderId = dto.GenderId,
                    JobPostDescription = dto.JobDescription,
                    JobPostStatusId = (int)JobPostStatusEnum.Aktif,
                    JobPostTitle = dto.JobTitle,
                    JobTypeId = dto.JobTypeId,
                    RegionId = dto.RegionId,
                    ReleaseDate = DateTime.Now,
                    SectorId = dto.SectorId,
                    CountryId = 1,
                    WebSiteUrl = dto.WebSite,
                    FacebookUrl = dto.FacebookUrl,
                    LinkedinUrl = dto.LinkedinUrl,
                    TwitterUrl = dto.TwitterUrl
                };
                _unitOfWork.jobPostDal.Add(jobPost);
                int result = _unitOfWork.Save();
                if (result > 0)
                {
                    return new SuccessDataResult<PostAJobViewModelResponseDto>(new PostAJobViewModelResponseDto { Id = jobPost.Id, Result = true });
                }
                else
                {
                    return new ErrorDataResult<PostAJobViewModelResponseDto>(new PostAJobViewModelResponseDto { Result = false });
                }
            }
            catch (Exception ex)
            {
                //Loglama
                return new ErrorDataResult<PostAJobViewModelResponseDto>(new PostAJobViewModelResponseDto { Result = false });
            }
        }

        public IDataResult<List<JobPost>> GetHomeJobPost()
        {
            try
            {
                var jobPosts = _unitOfWork.jobPostDal.JobPostsWithAllDependecies().OrderByDescending(x => x.Id).Take(5).ToList();
                return new SuccessDataResult<List<JobPost>>(jobPosts);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<JobPost>>();
            }
        }
    }
}