using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim>, IUserOperationClaimDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfUserOperationClaimDal(AppDbContext context) : base(context)
        {
        }
    }
}