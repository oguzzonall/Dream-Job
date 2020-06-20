using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;

namespace CareerPortal.Business.Abstract
{
    public interface IGenderService
    {
        IDataResult<List<Gender>> GetList();
    }
}
