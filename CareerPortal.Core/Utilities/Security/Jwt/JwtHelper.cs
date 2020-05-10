using CareerPortal.Core.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace CareerPortal.Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            throw new NotImplementedException();
        }
    }
}
