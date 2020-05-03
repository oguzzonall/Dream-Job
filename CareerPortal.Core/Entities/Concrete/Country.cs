using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Core.Entities.Concrete
{
    public class Country : Entity
    {
        public Country()
        {
            JobPosts = new Collection<JobPost>();
            Regions = new Collection<Region>();
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Language { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }
        public ICollection<Region> Regions { get; set; }
    }
}
