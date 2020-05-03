using CareerPortal.DataAccess.Abstract;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using CareerPortal.Entities.Concrete;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfExperienceDal : EfEntityRepositoryBase<Experience>, IExperienceDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfExperienceDal(AppDbContext context) : base(context)
        {
        }
    }
}
