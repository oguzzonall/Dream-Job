using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Entities.Concrete
{
    public class Sector : Entity
    {
        public Sector()
        {
            JobPosts = new Collection<JobPost>();
        }
        public string Name { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }

    }
}
