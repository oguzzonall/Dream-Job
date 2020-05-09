using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Core.Entities.Concrete
{
    public class OperationClaim : Entity
    {
        public OperationClaim()
        {
            UserOperationClaims = new Collection<UserOperationClaim>();
        }

        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
