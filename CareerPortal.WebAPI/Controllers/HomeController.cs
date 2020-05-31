using AutoMapper;
using CareerPortal.Business.Abstract;
using CareerPortal.Core.Dtos.Concrete.Country;
using CareerPortal.Core.Dtos.Concrete.General;
using CareerPortal.Core.Dtos.Concrete.JobType;
using CareerPortal.Core.Dtos.Concrete.Region;
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

        private readonly IMapper _mapper;

        public HomeController(ICountryService countryService, IRegionService regionService, IJobTypeService jobTypeService, IMapper mapper)
        {
            _countryService = countryService;
            _regionService = regionService;
            _jobTypeService = jobTypeService;
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
    }
}