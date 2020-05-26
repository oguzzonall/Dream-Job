using CareerPortal.Core.Utilities.Security.Jwt;

namespace CareerPortal.MvcWebUI.Areas.HomePage.Data
{
    public class RegisterResponse
    {
        public AccessToken Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
