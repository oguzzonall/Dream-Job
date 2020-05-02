using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Entities.Concrete
{
    internal class Region : Entity
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
