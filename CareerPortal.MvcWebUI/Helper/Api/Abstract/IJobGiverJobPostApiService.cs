using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.MvcWebUI.Areas.JobGiver.Data.Concrete;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface IJobGiverJobPostApiService
    {
        AddJobPostResponse JobGiverAddJobPostResponse(PostAJobViewModelDto PostAJobViewModelDto);
    }
}
