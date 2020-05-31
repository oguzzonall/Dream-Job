using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class RegionManager : IRegionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegionManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<List<Region>> GetList()
        {
            try
            {
                var regionList = _unitOfWork.regionDal.GetList().ToList(); ;
                return new SuccessDataResult<List<Region>>(regionList);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<Region>>(Messages.ErrorRegionList);
            }
        }
    }
}
