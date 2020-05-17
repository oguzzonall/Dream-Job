using CareerPortal.Core.Dtos.Concrete.User;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using CareerPortal.Core.Utilities.Security.Jwt;

namespace CareerPortal.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> JobSeekerRegister(UserForRegisterDto userForRegisterDto);
        IDataResult<User> JobGiverRegister(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
