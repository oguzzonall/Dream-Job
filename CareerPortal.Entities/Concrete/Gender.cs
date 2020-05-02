using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Entities.Concrete
{
    public class Gender : Entity
    {
        public Gender()
        {
            JobPosts = new Collection<JobPost>();
        }
        public string GenderName { get; set; }

        public ICollection<JobPost> JobPosts { get; set; }

    }
}
