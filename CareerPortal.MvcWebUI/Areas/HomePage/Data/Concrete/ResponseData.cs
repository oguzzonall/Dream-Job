using CareerPortal.MvcWebUI.Areas.HomePage.Data.Abstract;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete
{
    public class ResponseData : IResponseData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
