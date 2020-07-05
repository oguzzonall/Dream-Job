using CareerPortal.Core.Dtos.Concrete.General;
using CareerPortal.Core.Utilities.Results;

namespace CareerPortal.Business.Abstract
{
    public interface IGeneralService
    {
        IDataResult<GetGeneralInformationDto> GetGeneralInformations();
    }
}
