using CareerPortal.Core.Dtos.Concrete.General;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Models
{
    public class HomeIndexViewModel
    {
        public GetHomePageFilterComponentsDto JobFilterComponents { get; set; }
        public int RegionId { get; set; }
        public int JobTypeId { get; set; }
    }
}
