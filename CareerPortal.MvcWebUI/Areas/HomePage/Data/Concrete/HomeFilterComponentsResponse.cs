using CareerPortal.Core.Dtos.Concrete.General;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete
{
    public class HomeFilterComponentsResponse:ResponseData
    {
        public GetHomePageFilterComponentsDto Data { get; set; }
    }
}