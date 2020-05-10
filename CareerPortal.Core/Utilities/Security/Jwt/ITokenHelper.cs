using CareerPortal.Core.Entities.Concrete;
using System.Collections.Generic;

namespace CareerPortal.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
