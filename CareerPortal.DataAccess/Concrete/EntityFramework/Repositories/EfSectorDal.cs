using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfSectorDal : EfEntityRepositoryBase<Sector>, ISectorDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfSectorDal(AppDbContext context) : base(context)
        {

        }
    }
}
