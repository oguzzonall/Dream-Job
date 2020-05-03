using Autofac;
using CareerPortal.Business.Abstract;
using CareerPortal.Business.Concrete;

namespace CareerPortal.Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<ExperienceManager>().As<IExperienceService>();
            builder.RegisterType<GenderManager>().As<IGenderService>();
            builder.RegisterType<JobPostManager>().As<IJobPostService>();
            builder.RegisterType<JobPostStatusManager>().As<IJobPostStatusService>();
            builder.RegisterType<JobTypeManager>().As<IJobTypeService>();
            builder.RegisterType<RegionManager>().As<IRegionService>();
            builder.RegisterType<SectorManager>().As<ISectorService>();
        }
    }
}
