using CareerPortal.Core.Dtos.Concrete.User;
using System.Threading.Tasks;

namespace CareerPortal.MvcWebUI.Helper.Api.Abstract
{
    public interface IWebApiServices
    {
        Task<string> Get(string serviceUrl);
        Task<string> Post<T>(string serviceUrl, T instance) where T : class, new();
        Task<string> Put<T>(string serviceUrl, T instance) where T : class, new();
        Task<string> Delete(string serviceUrl);
        Task<string> GetToken(UserForLoginDto userForLoginDto);
        void SetTokenToClientHeader();
        //void IsExpirationControl();
    }
}
