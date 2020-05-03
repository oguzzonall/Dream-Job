using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCountryDal : EfEntityRepositoryBase<Country>, ICountryDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfCountryDal(AppDbContext context) : base(context)
        {
        }
    }
}
