using CareerPortal.Core.Dtos.Concrete.General;
using CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            GetJobPosts = new GetJobPostsResponse();
        }
        public GetHomePageFilterComponentsDto JobFilterComponents { get; set; }
        public GetJobPostsResponse GetJobPosts { get; set; }
        public GetGeneralInformationDto GeneralInformations { get; set; }
        public int RegionId { get; set; }
        public int JobTypeId { get; set; }
    }
}
