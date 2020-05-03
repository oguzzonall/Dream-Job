using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

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
