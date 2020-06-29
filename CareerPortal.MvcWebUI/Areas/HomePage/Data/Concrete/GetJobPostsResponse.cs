using CareerPortal.Core.Dtos.Concrete.JobPost;
using System.Collections.Generic;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete
{
    public class GetJobPostsResponse:ResponseData
    {
        public List<JobPostDto> Data { get; set; }

    }
}
