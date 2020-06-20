﻿using CareerPortal.Core.Entities.Concrete;
using CareerPortal.Core.Utilities.Results;
using System.Collections.Generic;

namespace CareerPortal.Business.Abstract
{
    public interface ISectorService
    {
        IDataResult<List<Sector>> GetList();
    }
}
