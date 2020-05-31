using CareerPortal.Core.Utilities.Security.Jwt;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Data.Concrete
{
    public class RegisterResponse:ResponseData
    {
        public AccessToken Data { get; set; }
    }
}
