using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfRegionDal : EfEntityRepositoryBase<Region>, IRegionDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfRegionDal(AppDbContext context) : base(context)
        {

        }
    }
}
