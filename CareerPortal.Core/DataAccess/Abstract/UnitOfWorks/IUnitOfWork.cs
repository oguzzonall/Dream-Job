﻿using CareerPortal.Core.DataAccess.Abstract.Dals;
using System;

namespace CareerPortal.Core.DataAccess.Abstract.UnitOfWorks
{
    public interface IUnitOfWork: IDisposable
    {
        ICountryDal countryDal { get; }
        IExperienceDal experienceDal { get; }
        IGenderDal genderDal { get; }
        IJobPostDal jobPostDal { get; }
        IJobPostStatusDal jobPostStatusDal { get; }
        IJobTypeDal jobTypeDal { get; }
        IRegionDal regionDal { get; }
        ISectorDal sectorDal { get; }
        int Commit();
    }
}
