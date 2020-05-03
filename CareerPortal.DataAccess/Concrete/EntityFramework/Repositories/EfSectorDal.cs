using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

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
