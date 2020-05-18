using AutoMapper;
using CareerPortal.Business.Abstract;
using CareerPortal.Core.Dtos.Concrete.Country;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CareerPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public HomeController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        //[Authorize()]
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
    }
}