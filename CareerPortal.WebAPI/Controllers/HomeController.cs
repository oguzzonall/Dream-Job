using AutoMapper;
using CareerPortal.Business.Abstract;
using CareerPortal.Core.Dtos.Concrete.Country;
using CareerPortal.Core.Dtos.Concrete.Experience;
using CareerPortal.Core.Dtos.Concrete.Gender;
using CareerPortal.Core.Dtos.Concrete.General;
using CareerPortal.Core.Dtos.Concrete.JobType;
using CareerPortal.Core.Dtos.Concrete.Region;
using CareerPortal.Core.Dtos.Concrete.Sector;
using CareerPortal.Core.Utilities.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CareerPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICountryService _countryService;

        private readonly IRegionService _regionService;
        private readonly IJobTypeService _jobTypeService;
        private readonly ISectorService _sectorService;
        private readonly IExperienceService _experienceService;
        private readonly IGenderService _genderService;

        private readonly IMapper _mapper;

        public HomeController(ICountryService countryService, IRegionService regionService, IJobTypeService jobTypeService,
            ISectorService sectorService, IExperienceService experienceService, IGenderService genderService, IMapper mapper)
        {
            _countryService = countryService;
            _regionService = regionService;
            _jobTypeService = jobTypeService;
            _sectorService = sectorService;
            _experienceService = experienceService;
            _genderService = genderService;
            _mapper = mapper;
        }

        [Authorize()]
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _countryService.GetList();
            if (result.Success)
            {
                return Ok(_mapper.Map<List<CountryDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpGet("gethomepagefiltercomponents")]
        public IActionResult GetHomePageFilterComponents()
        {
            GetHomePageFilterComponentsDto data = new GetHomePageFilterComponentsDto();
            var jobtypes = _jobTypeService.GetList();
            if (!jobtypes.Success)
                return Ok(new ErrorDataResult<GetHomePageFilterComponentsDto>());
            var regions = _regionService.GetList();
            if (!regions.Success)
                return Ok(new ErrorDataResult<GetHomePageFilterComponentsDto>());
            try
            {
                data.JobTypes = _mapper.Map<List<JobTypeDto>>(jobtypes.Data);
                data.Regions = _mapper.Map<List<RegionDto>>(regions.Data);
            }
            catch (System.Exception)
            {
                //todo:log ex
                return Ok(new ErrorDataResult<GetHomePageFilterComponentsDto>());
            }
            return Ok(new SuccessDataResult<GetHomePageFilterComponentsDto>(data));
        }

        [HttpGet("getsectorexperienceyeargender")]
        public IActionResult GetSectorExperienceYearGender()
        {
            GetSectorExperienceYearGenderDto data = new GetSectorExperienceYearGenderDto();
            var sector = _sectorService.GetList();
            if (!sector.Success)
                return Ok(new ErrorDataResult<GetSectorExperienceYearGenderDto>());
            var experience = _experienceService.GetList();
            if (!experience.Success)
                return Ok(new ErrorDataResult<GetSectorExperienceYearGenderDto>());
            var gender = _genderService.GetList();
            if (!gender.Success)
                return Ok(new ErrorDataResult<GetSectorExperienceYearGenderDto>());
            try
            {
                data.Sectors = _mapper.Map<List<SectorDto>>(sector.Data);
                data.Experiences = _mapper.Map<List<ExperienceDto>>(experience.Data);
                data.Genders = _mapper.Map<List<GenderDto>>(gender.Data);
            }
            catch (System.Exception)
            {
                //todo:log ex
                return Ok(new ErrorDataResult<GetSectorExperienceYearGenderDto>());
            }
            return Ok(new SuccessDataResult<GetSectorExperienceYearGenderDto>(data));
        }
    }
}