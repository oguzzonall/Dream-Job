using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

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
