using System;

namespace CareerPortal.Core.Entities.Concrete
{
    public class JobPost : Entity
    {
        public string JobPostTitle { get; set; }
        public string JobPostDescription { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public int ExperienceId { get; set; }
        public int SectorId { get; set; }
        public int JobTypeId { get; set; }
        public int JobPostStatusId { get; set; }
        public int GenderId { get; set; }
        public string JobPostImageUrl { get; set; }
        public string CompanyName { get; set; }
        public string ComponyLogoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }


        public virtual Region Region { get; set; }
        public virtual Experience Experience { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual JobPostStatus JobPostStatus { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Country Country { get; set; }
    }
}
