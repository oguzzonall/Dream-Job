using CareerPortal.Core.Dtos.Concrete.JobPost;
using CareerPortal.MvcWebUI.Areas.JobGiver.Data.Concrete;
using CareerPortal.MvcWebUI.Constants;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Newtonsoft.Json;

namespace CareerPortal.MvcWebUI.Helper.Api.Concrete
{
    public class JobGiverJobPostApiService: IJobGiverJobPostApiService
    {

        private IWebApiServices _webApiServices;
        private string jsonData = "";

        public JobGiverJobPostApiService(IWebApiServices webApiServices)
        {
            _webApiServices = webApiServices;
        }

        public AddJobPostResponse JobGiverAddJobPostResponse(PostAJobViewModelDto PostAJobViewModelDto)
        {
            jsonData = _webApiServices.Post<PostAJobViewModelDto>(ApiUrls.AddJobPost, PostAJobViewModelDto).Result;
            return JsonConvert.DeserializeObject<AddJobPostResponse>(jsonData);
        }
    }
}
