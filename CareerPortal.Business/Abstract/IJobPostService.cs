using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.Core.Utilities.Results;

namespace CareerPortal.Business.Abstract
{
    public interface IJobPostService
    {
        IDataResult<PostAJobViewModelResponseDto> AddJobPost(PostAJobViewModelDto dto);
    }
}
