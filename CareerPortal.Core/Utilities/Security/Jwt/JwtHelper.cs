using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace CareerPortal.Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions") as TokenOptions;
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            return new AccessToken();
        }
    }
}
