using Autofac;
using CareerPortal.Business.Abstract;
using CareerPortal.Business.Concrete;
using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.DataAccess.Concrete.EntityFramework.Repositories;
using CareerPortal.DataAccess.Concrete.EntityFramework.UnitOfWorks;

namespace CareerPortal.Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>();

            builder.RegisterType<ExperienceManager>().As<IExperienceService>();
            builder.RegisterType<EfExperienceDal>().As<IExperienceDal>();

            builder.RegisterType<GenderManager>().As<IGenderService>();
            builder.RegisterType<EfGenderDal>().As<IGenderDal>();

            builder.RegisterType<JobPostManager>().As<IJobPostService>();
            builder.RegisterType<EfJobPostDal>().As<IJobPostDal>();

            builder.RegisterType<JobPostStatusManager>().As<IJobPostStatusService>();
            builder.RegisterType<EfJobPostStatusDal>().As<IJobPostStatusDal>();

            builder.RegisterType<JobTypeManager>().As<IJobTypeService>();
            builder.RegisterType<EfJobTypeDal>().As<IJobTypeDal>();

            builder.RegisterType<RegionManager>().As<IRegionService>();
            builder.RegisterType<EfRegionDal>().As<IRegionDal>();

            builder.RegisterType<SectorManager>().As<ISectorService>();
            builder.RegisterType<EfSectorDal>().As<ISectorDal>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
