using CareerPortal.Core.DataAccess.Abstract.Dals;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfJobPostDal : EfEntityRepositoryBase<JobPost>, IJobPostDal
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EfJobPostDal(AppDbContext context) : base(context)
        {
        }

        public int Count()
        {
            return _appDbContext.JobPosts.Count();
        }

        public List<JobPost> JobPostsWithAllDependecies()
        {
            return _appDbContext.JobPosts.Include(x=>x.Region).Include(x=>x.JobType).ToList();
        }
    }
}
