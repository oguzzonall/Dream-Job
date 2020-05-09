using CareerPortal.Business.Abstract;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;
using System.Linq;

namespace CareerPortal.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<List<Country>> GetList()
        {
            try
            {
                var countryList = _unitOfWork.countryDal.GetList().ToList(); ;
                return new SuccessDataResult<List<Country>>(countryList);
            }
            catch
            {
                //Loglama
                return new ErrorDataResult<List<Country>>();
            }
        }
    }
}
