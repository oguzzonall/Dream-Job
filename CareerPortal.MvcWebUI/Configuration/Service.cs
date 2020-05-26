using CareerPortal.MvcWebUI.Helper.Api.Abstract;
using CareerPortal.MvcWebUI.Helper.Api.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CareerPortal.MvcWebUI.Configuration
{
    public static class Service
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IWebApiServices, WebApiServices>();
            services.AddScoped<ICountryApiService, CountryApiService>();
        }
    }
}
