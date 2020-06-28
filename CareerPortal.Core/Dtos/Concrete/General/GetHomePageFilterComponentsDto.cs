using CareerPortal.Core.Dtos.Concrete.JobType;
using CareerPortal.Core.Dtos.Concrete.Region;
using System.Collections.Generic;

namespace CareerPortal.Core.Dtos.Concrete.General
{
    public class GetHomePageFilterComponentsDto:Dto
    {
        public List<JobTypeDto> JobTypes { get; set; }
        public List<RegionDto> Regions { get; set; }
    }
}
