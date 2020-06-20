using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class SectorManager: ISectorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SectorManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<List<Sector>> GetList()
        {
            try
            {
                var sectorList = _unitOfWork.sectorDal.GetList().ToList(); ;
                return new SuccessDataResult<List<Sector>>(sectorList);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<Sector>>(Messages.ErrorSectorList);
            }
        }
    }
}
