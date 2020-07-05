using CareerPortal.Core.Constants.Enums;
using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUserDal : EfEntityRepositoryBase<User>, IUserDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfUserDal(AppDbContext context) : base(context)
        {

        }

        public IList<OperationClaim> GetClaims(User user)
        {
            //using (var context = new AppDbContext())
            //{
            //    var result = from operationClaim in context.OperationClaims
            //                 join userOperationClaim in context.UserOperationClaims
            //                 on operationClaim.Id equals userOperationClaim.OperationClaimId
            //                 where userOperationClaim.UserId == user.Id
            //                 select new OperationClaim
            //                 {
            //                     Id = operationClaim.Id,
            //                     Name = operationClaim.Name
            //                 };
            //    return result.ToList();
            //}
            return _appDbContext.UserOperationClaims.Where(x => x.UserId == user.Id).Include(x => x.OperationClaim).Select(x => x.OperationClaim).ToList();
        }

        public int GetJobSeekerCount()
        {
            return _appDbContext.UserOperationClaims.Where(x => x.OperationClaimId == (int)EnumOperationClaims.IS_Arayan).Count();
        }

        public int GetJobGiverCount()
        {
            return _appDbContext.UserOperationClaims.Where(x => x.OperationClaimId == (int)EnumOperationClaims.Is_Veren).Count();
        }
    }
}
