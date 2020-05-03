using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Core.Entities.Concrete
{
    public class Region : Entity
    {
        public Region()
        {
            JobPosts = new Collection<JobPost>();
        }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }
        public virtual Country Country { get; set; }
    }
}
