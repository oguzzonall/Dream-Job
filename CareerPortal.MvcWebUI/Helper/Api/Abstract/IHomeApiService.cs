using CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface IHomeApiService
    {
        HomeFilterComponentsResponse GetHomeFilterComponents();
    }
}