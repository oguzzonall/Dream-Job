using CareerPortal.Core.Utilities.Security.Jwt;

namespace CareerPortal.MvcWebUI.Helper.Session.Abstract
{
    public interface ITokenSessionHelper
    {
        AccessToken GetToken();
        void SetToken(AccessToken accessToken);
        void TokenClear();
    }
}
