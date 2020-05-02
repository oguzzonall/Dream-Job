using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Entities.Concrete
{
    internal class Experience : Entity
    {
        public Experience()
        {
            JobPosts = new Collection<JobPost>();
        }
        public int ExperienceYear { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }

    }
}
