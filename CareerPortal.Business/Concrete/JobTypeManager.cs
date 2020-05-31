using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class JobTypeManager : IJobTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobTypeManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<List<JobType>> GetList()
        {
            try
            {
                var jobTypeList = _unitOfWork.jobTypeDal.GetList().ToList(); ;
                return new SuccessDataResult<List<JobType>>(jobTypeList);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<JobType>>(Messages.ErrorJobTypeList);
            }
        }
    }
}
