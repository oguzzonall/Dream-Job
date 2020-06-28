using CareerPortal.MvcWebUI.Areas.JobGiver.Data.Abstract;

namespace CareerPortal.MvcWebUI.Areas.JobGiver.Data.Concrete
{
    public class ResponseData : IResponseData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
