using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Entities.Concrete
{
    public class JobPostStatus : Entity
    {
        public JobPostStatus()
        {
            JobPosts = new Collection<JobPost>();
        }
        public string StatusName { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }

    }
}
