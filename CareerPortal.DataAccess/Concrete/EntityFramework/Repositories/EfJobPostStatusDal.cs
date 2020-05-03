using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;

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
