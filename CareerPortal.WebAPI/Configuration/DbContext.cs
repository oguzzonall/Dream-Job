using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CareerPortal.WebAPI.Configuration
{
    public static class DbContext
    {
        public static void AddMyDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration["ConnectionStrings:SqlConStr"];

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString, o =>
            {
                o.MigrationsAssembly("CareerPortal.DataAccess");
            }));
        }
    }
}
