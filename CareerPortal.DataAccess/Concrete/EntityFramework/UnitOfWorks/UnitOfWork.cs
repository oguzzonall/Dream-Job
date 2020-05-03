using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.DataAccess.Concrete.EntityFramework.Repositories;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private EfCountryDal _efCountryDal;
        private EfExperienceDal _efexperienceDal;
        private EfGenderDal _efGenderDal;
        private EfJobPostDal _efJobPostDal;
        private EfJobPostStatusDal _efJobPostStatusDal;
        private EfJobTypeDal _efJobTypeDal;
        private EfRegionDal _efRegionDal;
        private EfSectorDal _efSectorDal;


        public ICountryDal countryDal => _efCountryDal = _efCountryDal ?? new EfCountryDal(_context);

        public IExperienceDal experienceDal => _efexperienceDal = _efexperienceDal ?? new EfExperienceDal(_context);

        public IGenderDal genderDal => _efGenderDal = _efGenderDal ?? new EfGenderDal(_context);

        public IJobPostDal jobPostDal => _efJobPostDal = _efJobPostDal ?? new EfJobPostDal(_context);

        public IJobPostStatusDal jobPostStatusDal => _efJobPostStatusDal = _efJobPostStatusDal ?? new EfJobPostStatusDal(_context);

        public IJobTypeDal jobTypeDal => _efJobTypeDal = _efJobTypeDal ?? new EfJobTypeDal(_context);

        public IRegionDal regionDal => _efRegionDal = _efRegionDal ?? new EfRegionDal(_context);

        public ISectorDal sectorDal => _efSectorDal = _efSectorDal ?? new EfSectorDal(_context);

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
