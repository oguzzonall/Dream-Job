using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfJobPostDal : EfEntityRepositoryBase<JobPost>, IJobPostDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfJobPostDal(AppDbContext context) : base(context)
        {
        }
    }
}
