using CareerPortal.Core.DataAccess.Abstract.Repositories;
using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;

namespace CareerPortal.Core.DataAccess.Abstract.Dals
{
    public interface IUserDal : IEntityRepository<User>
    {
        IList<OperationClaim> GetClaims(User user);

        int GetJobSeekerCount();
        int GetJobGiverCount();
    }
}
