using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.Constants.Enums;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Dtos.Concrete.User;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using CareerPortal.Core.Utilities.Security.Hashing;
using CareerPortal.Core.Utilities.Security.Jwt;

namespace CareerPortal.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUnitOfWork _unitOfWork;
        private ITokenHelper _tokenHelper;
        private IUserService _userService;


        public IDataResult<User> JobSeekerRegister(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _unitOfWork.userDal.Add(user);
            var userClaim = new UserOperationClaim
            {
                UserId = user.Id,
                OperationClaimId = (int)EnumOperationClaims.İşArayan
            };
            _unitOfWork.userOperationClaimDal.Add(userClaim);
            int result = _unitOfWork.Commit();
            if (result > 0)
                return new SuccessDataResult<User>(user, Messages.UserRegistered);
            else
                return new ErrorDataResult<User>(Messages.UserNotAdded);
        }

        public IDataResult<User> JobGiverRegister(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _unitOfWork.userDal.Add(user);
            var userClaim = new UserOperationClaim
            {
                UserId = user.Id,
                OperationClaimId = (int)EnumOperationClaims.İşveren
            };
            _unitOfWork.userOperationClaimDal.Add(userClaim);
            int result = _unitOfWork.Commit();
            if (result > 0)
                return new SuccessDataResult<User>(user, Messages.UserRegistered);
            else
                return new ErrorDataResult<User>(Messages.UserNotAdded);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck.Data == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck.Data, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user).Data;
            var accesstoken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accesstoken, Messages.AccessTokenCreated);
        }
    }
}
