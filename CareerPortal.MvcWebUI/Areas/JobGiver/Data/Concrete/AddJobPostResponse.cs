using CareerPortal.Core.Dtos.Concrete.JobPost;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Data.Concrete
{
    public class AddJobPostResponse:ResponseData
    {
        public PostAJobViewModelResponseDto Data { get; set; }
    }
}
