using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfJobPostStatusDal : EfEntityRepositoryBase<JobPostStatus>,IJobPostStatusDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfJobPostStatusDal(AppDbContext context) : base(context)
        {

        }
    }
}
