using CareerPortal.Business.Abstract;
using CareerPortal.Business.Constants;
using CareerPortal.Core.DataAccess.Abstract.UnitOfWorks;
using CareerPortal.Core.Dtos.Concrete.General;
using CareerPortal.Core.Utilities.Results;

namespace CareerPortal.Business.Concrete
{
    public class GeneralManager : IGeneralService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GeneralManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IDataResult<GetGeneralInformationDto> GetGeneralInformations()
        {
            try
            {
                GetGeneralInformationDto getGeneralInformationDto = new GetGeneralInformationDto();
                getGeneralInformationDto.TotalJobGiver = _unitOfWork.userDal.GetJobGiverCount();
                getGeneralInformationDto.TotalJobSeeker = _unitOfWork.userDal.GetJobSeekerCount();
                getGeneralInformationDto.TotalJobPost = _unitOfWork.jobPostDal.Count();
                return new SuccessDataResult<GetGeneralInformationDto>(getGeneralInformationDto);
            }
            catch (System.Exception ex)
            {
                //todo:log
                return new ErrorDataResult<GetGeneralInformationDto>(Messages.ErrorGetGenarealInformations);
            }
        }
    }
}
