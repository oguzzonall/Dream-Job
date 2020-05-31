﻿using AutoMapper;
using CareerPortal.Core.Dtos.Concrete.Country;
using CareerPortal.Core.Dtos.Concrete.JobType;
using CareerPortal.Core.Dtos.Concrete.Region;
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

            CreateMap<JobType, JobTypeDto>();
            CreateMap<JobTypeDto, JobType>();
        }
    }
}
