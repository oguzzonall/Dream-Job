using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly AppDbContext _context;

        private EfCountryDal _efCountryDal;
        private EfExperienceDal _efexperienceDal;
        private EfGenderDal _efGenderDal;
        private EfJobPostDal _efJobPostDal;
        private EfJobPostStatusDal _efJobPostStatusDal;
        private EfJobTypeDal _efJobTypeDal;
        private EfRegionDal _efRegionDal;
        private EfSectorDal _efSectorDal;
        private EfUserDal _efUserDal;
        private EfUserOperationClaimDal _efUserOperationClaimDal;

        public ICountryDal countryDal => _efCountryDal = _efCountryDal ?? new EfCountryDal(_context);

        public IExperienceDal experienceDal => _efexperienceDal = _efexperienceDal ?? new EfExperienceDal(_context);

        public IGenderDal genderDal => _efGenderDal = _efGenderDal ?? new EfGenderDal(_context);

        public IJobPostDal jobPostDal => _efJobPostDal = _efJobPostDal ?? new EfJobPostDal(_context);

        public IJobPostStatusDal jobPostStatusDal => _efJobPostStatusDal = _efJobPostStatusDal ?? new EfJobPostStatusDal(_context);

        public IJobTypeDal jobTypeDal => _efJobTypeDal = _efJobTypeDal ?? new EfJobTypeDal(_context);

        public IRegionDal regionDal => _efRegionDal = _efRegionDal ?? new EfRegionDal(_context);

        public ISectorDal sectorDal => _efSectorDal = _efSectorDal ?? new EfSectorDal(_context);

        public IUserDal userDal => _efUserDal = _efUserDal ?? new EfUserDal(_context);

        public IUserOperationClaimDal userOperationClaimDal => _efUserOperationClaimDal = _efUserOperationClaimDal ?? new EfUserOperationClaimDal(_context);

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        //Transaction Tanımladım.
        IDbContextTransaction transaction;
        public void BeginTransaction()
        {
            transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
