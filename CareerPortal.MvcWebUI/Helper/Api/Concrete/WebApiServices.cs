using CareerPortal.Core.Dtos.Concrete.User;
using CareerPortal.Core.Utilities.Security.Jwt;
using CareerPortal.MvcWebUI.Extensions;
using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading.Tasks;

namespace CareerPortal.MvcWebUI.Helper.Api.Concrete
{
    public class WebApiServices : IWebApiServices
    {
        private IHttpClientFactory _clientFactory;
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _client;
        public string baseUrl = "https://localhost:44319/";

        public WebApiServices(IHttpClientFactory clientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _clientFactory = clientFactory;
            _httpContextAccessor = httpContextAccessor;
            _client = _clientFactory.CreateClient();
            SetTokenToClientHeader();
        }

        public async Task<string> Get(string serviceUrl)
        {
            serviceUrl = baseUrl + serviceUrl;
            using (HttpResponseMessage response = await _client.GetAsync(serviceUrl))
            {
                //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                //{
                //    _httpContextAccessor.HttpContext.Response.Redirect("/HomePage/Home/Index");
                //    //todo: Alertify
                //}
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> Post<T>(string serviceUrl, T instance) where T : class, new()
        {
            serviceUrl = baseUrl + serviceUrl;
            throw new System.NotImplementedException();
        }

        public async Task<string> GetToken(UserForLoginDto userForLoginDto)
        {
            throw new System.NotImplementedException();
        }

        public void SetTokenToClientHeader()
        {
            AccessToken accessToken = _httpContextAccessor.HttpContext.Session.GetObject<AccessToken>("token");
            if (accessToken != null)
            {
                var headerAuth = _client.DefaultRequestHeaders.Authorization;
                if (headerAuth == null)
                {
                    _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken.Token);
                }
                else
                {
                    _client.DefaultRequestHeaders.Remove("Authorization");
                    _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken.Token);
                }
            }
        }

        //public void IsExpirationControl()
        //{
        //    throw new System.NotImplementedException();
        //}

        public async Task<string> Put<T>(string serviceUrl, T instance) where T : class, new()
        {
            throw new System.NotImplementedException();
        }

        public async Task<string> Delete(string serviceUrl)
        {
            throw new System.NotImplementedException();
        }
    }
}
