using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;

namespace CareerPortal.Business.Abstract
{
    public interface IJobPostService
    {
        IDataResult<PostAJobViewModelResponseDto> AddJobPost(PostAJobViewModelDto dto);
        IDataResult<List<JobPost>> GetHomeJobPost();
    }
}
