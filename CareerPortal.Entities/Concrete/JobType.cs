using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Entities.Concrete
{
    public class JobType : Entity
    {
        public JobType()
        {
            JobPosts = new Collection<JobPost>();
        }
        public string Name { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }

    }
}
