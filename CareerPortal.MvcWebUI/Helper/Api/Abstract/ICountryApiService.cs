using CareerPortal.Core.Dtos.Concrete.Country;
using System.Collections.Generic;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface ICountryApiService
    {
        List<CountryDto> GetAllCountries();
        //CountryDto GetProduct(int id);
        //string PostProduct(CountryDto Product);
    }
}
