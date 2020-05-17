using CareerPortal.Business.Abstract;
using CareerPortal.Core.Dtos.Concrete.User;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using CareerPortal.Core.Utilities.Security.Jwt;

namespace CareerPortal.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            throw new System.NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
