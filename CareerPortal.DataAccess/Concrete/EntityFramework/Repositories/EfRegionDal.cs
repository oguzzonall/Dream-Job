using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;

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
