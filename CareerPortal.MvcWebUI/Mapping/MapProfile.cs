using AutoMapper;
using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.MvcWebUI.Areas.JobGiver.Models;

namespace CareerPortal.MvcWebUI.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<PostAJobViewModel, PostAJobViewModelDto>();
            CreateMap<PostAJobViewModelDto, PostAJobViewModel>();
        }
    }
}
