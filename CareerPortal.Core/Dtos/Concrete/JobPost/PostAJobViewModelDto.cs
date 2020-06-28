using Microsoft.AspNetCore.Http;

namespace CareerPortal.Core.Dtos.Concrete.JobPost
{
    public class PostAJobViewModelDto : Dto
    {
        public string JobPostImageBase64 { set; get; }
        public string JobPostImageUrl { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
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
        public string ComponyLogoBase64 { get; set; }
        public string ComponyLogoUrl { get; set; }
    }
}