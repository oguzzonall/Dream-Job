using CareerPortal.Core.Dtos.Concrete.General;
using Microsoft.AspNetCore.Http;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Models
{
    public class PostAJobViewModel
    {
        public IFormFile JobPostImage { set; get; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public GetHomePageFilterComponentsDto JobFilterComponents { get; set; }
        public GetSectorExperienceYearGenderDto GetSectorExperienceYearGenderDtos { get; set; }
        public int RegionId { get; set; }
        public int JobTypeId { get; set; }
        public int SectorId { get; set; }
        public int ExperienceId { get; set; }
        public int GenderId { get; set; }
        public string JobDescription { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string WebSite { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public IFormFile ComponyLogo { get; set; }
    }
}
