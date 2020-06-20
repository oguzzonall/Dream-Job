using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class GenderManager : IGenderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenderManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<List<Gender>> GetList()
        {
            try
            {
                var genderList = _unitOfWork.genderDal.GetList().ToList(); ;
                return new SuccessDataResult<List<Gender>>(genderList);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<Gender>>(Messages.ErrorGenderList);
            }
        }
    }
}
