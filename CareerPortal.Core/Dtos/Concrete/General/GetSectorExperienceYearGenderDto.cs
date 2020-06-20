using CareerPortal.Core.Dtos.Concrete.Experience;
using CareerPortal.Core.Dtos.Concrete.Gender;
using CareerPortal.Core.Dtos.Concrete.Sector;
using System.Collections.Generic;

namespace CareerPortal.Core.Dtos.Concrete.General
{
    public class GetSectorExperienceYearGenderDto
    {
        public List<SectorDto> Sectors { get; set; }
        public List<ExperienceDto> Experiences { get; set; }
        public List<GenderDto> Genders { get; set; }
    }
}
