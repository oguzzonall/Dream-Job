using CareerPortal.Core.DataAccess.Abstract.Repositories;
using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;

namespace CareerPortal.Core.DataAccess.Abstract.Dals
{
    public interface IJobPostDal : IEntityRepository<JobPost>
    {
        List<JobPost> JobPostsWithAllDependecies();
        int Count();
    }
}
