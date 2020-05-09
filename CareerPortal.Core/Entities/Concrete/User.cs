using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CareerPortal.Core.Entities.Concrete
{
    public class User : Entity
    {
        public User()
        {
            UserOperationClaims = new Collection<UserOperationClaim>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }

        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
