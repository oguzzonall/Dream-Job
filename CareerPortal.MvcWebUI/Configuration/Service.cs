using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using CareerPortal.MvcWebUI.Helper.Api.Concrete;
using CareerPortal.MvcWebUI.Helper.Session.Abstract;
using CareerPortal.MvcWebUI.Helper.Session.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CareerPortal.MvcWebUI.Configuration
{
    public static class Service
    {
        /// <summary>
        /// Uygulama ayağa kalktığında bağımlılıkları inject eder
        /// </summary>
        /// <param name="services"></param>
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IWebApiServices, WebApiServices>();
            services.AddScoped<ICountryApiService, CountryApiService>();
            services.AddScoped<IAuthApiService, AuthApiService>();
            services.AddScoped<IHomeApiService, HomeApiService>();
            services.AddScoped<ITokenSessionHelper, TokenSessionHelper>();
        }
    }
}
