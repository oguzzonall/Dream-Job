using CareerPortal.Core.DataAccess.Abstract;
using CareerPortal.Entities.Concrete;

namespace CareerPortal.DataAccess.Abstract
{
    public interface IJobPostDal : IEntityRepository<JobPost>
    {
    }
}
