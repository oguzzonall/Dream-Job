using CareerPortal.Core.Dtos.Concrete.Country;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CareerPortal.MvcWebUI.Helper.Api.Concrete
{
    public class CountryApiService : ICountryApiService
    {
        private IWebApiServices _webApiServices;
        private string jsonData = "";

        public CountryApiService(IWebApiServices webApiServices)
        {
            _webApiServices = webApiServices;
        }

        public List<CountryDto> GetAllProducts()
        {
            jsonData = _webApiServices.Get(ApiUrls.CountryGetAll).Result;
            return JsonConvert.DeserializeObject<List<CountryDto>>(jsonData);
        }
    }
}
