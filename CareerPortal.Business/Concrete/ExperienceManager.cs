using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperienceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<List<Experience>> GetList()
        {
            try
            {
                var experienceList = _unitOfWork.experienceDal.GetList().ToList(); ;
                return new SuccessDataResult<List<Experience>>(experienceList);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<Experience>>(Messages.ErrorExperienceList);
            }
        }
    }
}
