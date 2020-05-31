using CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Newtonsoft.Json;

namespace CareerPortal.MvcWebUI.Helper.Api.Concrete
{
    public class HomeApiService : IHomeApiService
    {
        private IWebApiServices _webApiServices;
        private string jsonData = "";

        public HomeApiService(IWebApiServices webApiServices)
        {
            _webApiServices = webApiServices;
        }

        public HomeFilterComponentsResponse GetHomeFilterComponents()
        {
            jsonData = _webApiServices.Get(ApiUrls.GetHomePageFilterComponents).Result;
            return JsonConvert.DeserializeObject<HomeFilterComponentsResponse>(jsonData);
        }
    }
}
