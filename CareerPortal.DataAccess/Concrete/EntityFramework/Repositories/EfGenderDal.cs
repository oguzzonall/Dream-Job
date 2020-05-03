using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfGenderDal : EfEntityRepositoryBase<Gender>, IGenderDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfGenderDal(AppDbContext context) : base(context)
        {
        }
    }
}
