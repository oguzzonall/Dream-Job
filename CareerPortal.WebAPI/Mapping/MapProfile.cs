using AutoMapper;
using CareerPortal.Core.Dtos.Concrete.Country;
using CareerPortal.Core.Entities.Concrete;

namespace CareerPortal.WebAPI.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
        }
    }
}
