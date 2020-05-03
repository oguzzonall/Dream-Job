using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfJobTypeDal:EfEntityRepositoryBase<JobType>, IJobTypeDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfJobTypeDal(AppDbContext context) : base(context)
        {

        }
    }
}
