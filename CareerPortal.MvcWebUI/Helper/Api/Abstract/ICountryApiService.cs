using CareerPortal.Core.Dtos.Concrete.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface ICountryApiService
    {
        List<CountryDto> GetAllCountries();
        //CountryDto GetProduct(int id);
        //string PostProduct(CountryDto Product);
    }
}
