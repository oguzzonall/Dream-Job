using CareerPortal.Core.Utilities.Security.Jwt;
using CareerPortal.MvcWebUI.Extensions;
using CareerPortal.MvcWebUI.Helper.Session.Abstract;
using Microsoft.AspNetCore.Http;

namespace CareerPortal.MvcWebUI.Helper.Session.Concrete
{
    public class TokenSessionHelper: ITokenSessionHelper
    {
        private IHttpContextAccessor _httpContextAccessor;

        public TokenSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void TokenClear()
        {
            _httpContextAccessor.HttpContext.Session.Remove("token");
        }

        public AccessToken GetToken()
        {
            AccessToken tokenToCheck = _httpContextAccessor.HttpContext.Session.GetObject<AccessToken>("token");
            return tokenToCheck;
        }

        public void SetToken(AccessToken accessToken)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("token", accessToken);
        }
    }
}
