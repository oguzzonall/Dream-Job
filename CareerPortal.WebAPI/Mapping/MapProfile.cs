using AutoMapper;
using CareerPortal.Core.Dtos.Concrete.Country;
using CareerPortal.Core.Dtos.Concrete.Experience;
using CareerPortal.Core.Dtos.Concrete.Gender;
using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.Core.Dtos.Concrete.JobType;
using CareerPortal.Core.Dtos.Concrete.Region;
using CareerPortal.Core.Dtos.Concrete.Sector;
using CareerPortal.Core.Entities.Concrete;

namespace CareerPortal.WebAPI.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();

            CreateMap<Region, RegionDto>();
            CreateMap<RegionDto, Region>();

            CreateMap<JobPostDto, JobPost>();
            CreateMap<JobPost, JobPostDto>();

            CreateMap<JobType, JobTypeDto>();
            CreateMap<JobTypeDto, JobType>();

            CreateMap<Sector, SectorDto>();
            CreateMap<SectorDto, Sector>();

            CreateMap<Experience, ExperienceDto>();
            CreateMap<ExperienceDto, Experience>();

            CreateMap<Gender, GenderDto>();
            CreateMap<GenderDto, Gender>();
        }
    }
}
