using CareerPortal.Business.Abstract;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IResult Add(User user)
        {
            try
            {
                _unitOfWork.userDal.Add(user);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }

        public IDataResult<User> GetByMail(string email)
        {
            try
            {
                var user = _unitOfWork.userDal.Get(u => u.Email == email);
                return new SuccessDataResult<User>(user);
            }
            catch
            {
                return new ErrorDataResult<User>();
            }
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            try
            {
                var claims = _unitOfWork.userDal.GetClaims(user).ToList();
                return new SuccessDataResult<List<OperationClaim>>(claims);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<OperationClaim>>();
            }
        }
    }
}
